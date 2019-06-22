using Minesweeper.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public class Grid
    {

        //utility
        static Random generator = new Random();
        Dictionary<int, Image> imagesByNumber { get; set; }
        Image skin;
        //main info
        public Tile[][] mainMatrix { get; set; }
        int bombCount { get; set; }
        int tileNumber { get; set; }

        public Grid(int numberOfBombs, Image skin)
        {
            this.skin = skin;
            imagesByNumber = new Dictionary<int, Image>();
            //add images
            addImages();

            //initialize matrix
            bombCount = numberOfBombs;
            mainMatrix = new Tile[Game.tileRowNumber][];
            for (int i = 0; i < mainMatrix.Length; i++)
            {
                mainMatrix[i] = new Tile[Game.tileColumnNumber];
            }

            setTileNumber();
            fillMatrix();
        }

        //filling hash map and adding images
        private void addImages()
        {
            imagesByNumber.Add(0, Resources._0);
            imagesByNumber.Add(1, Resources._1);
            imagesByNumber.Add(2, Resources._2);
            imagesByNumber.Add(3, Resources._3);
            imagesByNumber.Add(4, Resources._4);
            imagesByNumber.Add(5, Resources._5);
            imagesByNumber.Add(6, Resources._6);
            imagesByNumber.Add(7, Resources._7);
            imagesByNumber.Add(8, Resources._8);
            imagesByNumber.Add(9, skin);
        }

        //determine number of tiles
        private void setTileNumber()
        {
            tileNumber = Game.tileColumnNumber * Game.tileRowNumber;
        }

        public void changeMatrix()
        {
            for (int i = 0; i < Game.tileRowNumber; i++)
                for (int j = 0; j < Game.tileColumnNumber; j++)
                    mainMatrix[i][j].location = new Point(j * Game.TileWidth, i * Game.TileHeight);

        }
        //fill the matrix with tiles determined from image sizes, 
        private void fillMatrix()
        {
            for (int i = 0; i < Game.tileRowNumber; i++)
                for (int j = 0; j < Game.tileColumnNumber; j++)
                    mainMatrix[i][j] = new Tile(j * Game.TileWidth, i * Game.TileHeight);

            fillBombs();
            fillNumbersOfTiles();
            fillImages();
        }

       

        private void fillBombs()
        {
            int bombsSet = 0;
            while(bombsSet < bombCount)
            {
                int randomX = generator.Next(Game.tileRowNumber);
                int randomY = generator.Next(Game.tileColumnNumber);
                if (!mainMatrix[randomX][randomY].getBomb())
                {
                    mainMatrix[randomX][randomY].setBomb(true);
                    bombsSet++;
                }
            }
        }

        public int visibleNumber()
        {
            int count = 0;
            for (int i = 0; i < Game.tileRowNumber; i++)
            {
                for (int j = 0; j < Game.tileColumnNumber; j++)
                {
                    if (mainMatrix[i][j].isRevealed)
                        count++;
                }
            }
            return count;
        }
        //calculate numbers for each tiles using neighbour bombs
        private void fillNumbersOfTiles()
        {
            for (int i = 0; i < Game.tileRowNumber; i++)
            {
                for (int j = 0; j < Game.tileColumnNumber; j++)
                {
                    int numberOfNeighbourBombs = 0;
                    //top
                    if (i - 1 >= 0 && mainMatrix[i - 1][j].getBomb())
                        numberOfNeighbourBombs++;
                    //top-right
                    if (i - 1 >= 0 && j + 1 <= Game.tileColumnNumber - 1 && mainMatrix[i - 1][j + 1].getBomb())
                        numberOfNeighbourBombs++;
                    //right
                    if (j + 1 <= Game.tileColumnNumber - 1 && mainMatrix[i][j + 1].getBomb())
                        numberOfNeighbourBombs++;
                    //bottom-right
                    if (i + 1 <= Game.tileRowNumber - 1 && j + 1 <= Game.tileColumnNumber - 1 && mainMatrix[i + 1][j + 1].getBomb())
                        numberOfNeighbourBombs++;
                    //bottom
                    if (i + 1 <= Game.tileRowNumber-1 && mainMatrix[i + 1][j].getBomb())
                        numberOfNeighbourBombs++;
                    //bottom-left
                    if (i + 1 <= Game.tileRowNumber-1 && j - 1 >= 0 && mainMatrix[i + 1][j - 1].getBomb())
                        numberOfNeighbourBombs++;
                    //left
                    if (j - 1 >= 0 && mainMatrix[i][j - 1].getBomb())
                        numberOfNeighbourBombs++;
                    //top-left
                    if (j - 1 >= 0 && i - 1 >= 0 && mainMatrix[i - 1][j - 1].getBomb())
                        numberOfNeighbourBombs++;

                    mainMatrix[i][j].setNeighbourBombs(numberOfNeighbourBombs);
                }
            }
        }

        //fill the main images
        private void fillImages()
        {
            for (int i = 0; i < Game.tileRowNumber; i++)
            {
                for (int j = 0; j < Game.tileColumnNumber; j++)
                {
                    //if bomb
                    if (mainMatrix[i][j].getBomb())
                        mainMatrix[i][j].setMainImage(imagesByNumber[9]);
                    //else fill with number image
                    else
                        mainMatrix[i][j].setMainImage(imagesByNumber[mainMatrix[i][j].getNeighbourBombs()]);
                }
            }
        }

        //get flag status for i and j coordinate, used elsewhere
        public bool getFlagged(int i,int j)
        {
            return mainMatrix[i][j].getFlag();
        }

        //trigger flag on a tile for i and j coordinate
        public bool flag(int i,int j)
        {
            return mainMatrix[i][j].flag();
        }

        //question mark
        public bool getQuestionMark(int i, int j)
        {
            return mainMatrix[i][j].getQuestionMark();
        }

        public void questionMark(int i, int j)
        {
            mainMatrix[i][j].tryToQuestionMark();
        }

        //draw all tiles
        public void draw(Graphics g)
        {
            for (int i = 0; i < Game.tileRowNumber; i++)
                for (int j = 0; j < Game.tileColumnNumber; j++)
                    mainMatrix[i][j].draw(g);

            g.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(mainMatrix[0][0].location,new Size(
                Game.tileColumnNumber * Game.TileWidth, Game.tileRowNumber * Game.TileHeight)));
        }
        
        //recursive function to click a tile
        public void tileClicked(int i,int j)
        {
            if (mainMatrix[i][j].getBomb())
            {
                Game.gameEnd = true;
                return;
            }

            if (!mainMatrix[i][j].click())
                return;


            if (mainMatrix[i][j].getNeighbourBombs()==0)
            {
                //top
                if (i - 1 >= 0)
                    tileClicked(i - 1, j);
                //top-right
                if (i - 1 >= 0 && j + 1 <= Game.tileColumnNumber - 1)
                  tileClicked(i - 1, j + 1);
                //right
                if (j + 1 <= Game.tileColumnNumber - 1)
                    tileClicked(i, j + 1);
                //bottom-right
                if (i + 1 <= Game.tileRowNumber - 1 && j + 1 <= Game.tileColumnNumber - 1) 
                    tileClicked(i + 1, j + 1);
                //bottom
                if (i + 1 <= Game.tileRowNumber - 1)
                    tileClicked(i + 1, j);
                //bottom-left
                if (i + 1 <= Game.tileRowNumber - 1 && j - 1 >= 0)
                    tileClicked(i + 1, j - 1);
                //left
                if (j - 1 >= 0)
                    tileClicked(i, j - 1);
                //top-left
                if (j - 1 >= 0 && i - 1 >= 0)
                    tileClicked(i - 1, j - 1);
            }
        }

        //show All for boosted status
        public void showAll()
        {
            for (int i = 0; i < Game.tileRowNumber; i++)
            {
                for (int j = 0; j < Game.tileColumnNumber; j++)
                {
                    if (mainMatrix[i][j].getBomb() && !mainMatrix[i][j].isRevealed&&!mainMatrix[i][j].getFlag())
                    {
                        mainMatrix[i][j].previousState = mainMatrix[i][j].isRevealed;
                        mainMatrix[i][j].isRevealed = true;
                    }
                    
                }
            }
        }

        //revert all for boost end
        public void revertAll()
        {
            for (int i = 0; i < Game.tileRowNumber; i++)
            {
                for (int j = 0; j < Game.tileColumnNumber; j++)
                {
                    mainMatrix[i][j].isRevealed = mainMatrix[i][j].previousState;
                }
            }
        }

        //get unopened tile without bomb
        public Tile getUnopened()
        {
            while (true)
            {
                int randomX = generator.Next(Game.tileRowNumber);
                int randomY = generator.Next(Game.tileColumnNumber);
                if(!mainMatrix[randomX][randomY].isRevealed&&!mainMatrix[randomX][randomY].getBomb())
                {
                    return mainMatrix[randomX][randomY];
                }
            }
        }

        public bool getBomb(int i, int j)
        {
            return mainMatrix[i][j].getBomb();
        }
    }
}
