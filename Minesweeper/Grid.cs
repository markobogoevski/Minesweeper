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
    class Grid
    {
        //utility
        Random generator { get; set; }
        List<ImageWrapper> mainImages { get; set; }

        //main info
        public Tile[][] mainMatrix { get; set; }
        int bombCount { get; set; }
        int tileNumber { get; set; }

        public Grid(int numberOfBombs)
        {
            mainImages = new List<ImageWrapper>();
            addImages();

            bombCount = numberOfBombs;
            generator = new Random();
            mainMatrix = new Tile[Game.tileRowNumber][];
            for (int i = 0; i < mainMatrix.Length; i++)
            {
                mainMatrix[i] = new Tile[Game.tileColumnNumber];
            }

            setTileNumber();
            fillMatrix();
        }

        private void addImages()
        {
            mainImages.Add(new ImageWrapper(0, Resizer.ResizeImage(Resources._0, Game.TileWidth, Game.TileHeight)));
            mainImages.Add(new ImageWrapper(1, Resizer.ResizeImage(Resources._1, Game.TileWidth, Game.TileHeight)));
            mainImages.Add(new ImageWrapper(2, Resizer.ResizeImage(Resources._2, Game.TileWidth, Game.TileHeight)));
            mainImages.Add(new ImageWrapper(3, Resizer.ResizeImage(Resources._3, Game.TileWidth, Game.TileHeight)));
            mainImages.Add(new ImageWrapper(4, Resizer.ResizeImage(Resources._4, Game.TileWidth, Game.TileHeight)));
            mainImages.Add(new ImageWrapper(5, Resizer.ResizeImage(Resources._5, Game.TileWidth, Game.TileHeight)));
            mainImages.Add(new ImageWrapper(6, Resizer.ResizeImage(Resources._6, Game.TileWidth, Game.TileHeight)));
            mainImages.Add(new ImageWrapper(7, Resizer.ResizeImage(Resources._7, Game.TileWidth, Game.TileHeight)));
            mainImages.Add(new ImageWrapper(8, Resizer.ResizeImage(Resources._8, Game.TileWidth, Game.TileHeight)));
            mainImages.Add(new ImageWrapper(9, Resizer.ResizeImage(Resources._9, Game.TileWidth, Game.TileHeight)));
        }

        private void setTileNumber()
        {
            tileNumber = Game.tileColumnNumber * Game.tileRowNumber;
        }


        private void fillMatrix()
        {
           for(int i = 0; i < Game.tileRowNumber; i++)
            {
                for(int j = 0; j < Game.tileColumnNumber; j++)
                {
                    Tile newTile = new Tile(j * Game.TileWidth, i * Game.TileHeight);
                    mainMatrix[i][j] = newTile;
                }
            }

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

        private void fillImages()
        {
            for (int i = 0; i < Game.tileRowNumber; i++)
            {
                for (int j = 0; j < Game.tileColumnNumber; j++)
                {
                    if (mainMatrix[i][j].getBomb())
                    {
                        mainMatrix[i][j].setImage(mainImages.ElementAt(mainImages.Count - 1).getImage());
                        continue;
                    }
                    foreach(ImageWrapper image in mainImages)
                    {
                        if (image.getNumber() == mainMatrix[i][j].getNeighbourBombs())
                            mainMatrix[i][j].setImage(image.getImage());
                    }
                }
            }
        }

        public bool getFlagged(int i,int j)
        {
            return mainMatrix[i][j].getFlag();
        }

        public bool flag(int i,int j)
        {
            return mainMatrix[i][j].flag();
        }

        public void draw(Graphics g)
        {
            for (int i = 0; i < Game.tileRowNumber; i++)
            {
                for (int j = 0; j < Game.tileColumnNumber; j++)
                {
                    mainMatrix[i][j].draw(g);
                }
            }
        }

        public void tileClicked(int i,int j)
        {

            if (!mainMatrix[i][j].click())
                return;

            if (mainMatrix[i][j].getBomb())
            {
                Game.gameEnd = true;
                return;
            }

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

        public void showAll()
        {
            for (int i = 0; i < Game.tileRowNumber; i++)
            {
                for (int j = 0; j < Game.tileColumnNumber; j++)
                {
                    if (mainMatrix[i][j].getBomb())
                    {
                        mainMatrix[i][j].previousState = mainMatrix[i][j].isRevealed;
                        mainMatrix[i][j].isRevealed = true;
                    }
                    
                }
            }
        }

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
    }
}
