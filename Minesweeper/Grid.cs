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
        Random generator { get; set; }
        Tile[][] mainMatrix { get; set; }
        List<ImageWrapper> mainImages { get; set; }
        int bombCount { get; set; }
        int tileNumber { get; set; }

        public Grid(int numberOfBombs)
        {
            mainImages = new List<ImageWrapper>();
            addImages();

            bombCount = numberOfBombs;
            generator = new Random();
            mainMatrix = new Tile[Form1.tileRowNumber][];
            for (int i = 0; i < mainMatrix.Length; i++)
            {
                mainMatrix[i] = new Tile[Form1.tileColumnNumber];
            }

            setTileNumber();
            fillMatrix();
        }

        private void addImages()
        {
            mainImages.Add(new ImageWrapper(0, Resizer.ResizeImage(Resources._0, Form1.Width, Form1.Height)));            mainImages.Add(new ImageWrapper(0, Resizer.ResizeImage(Resources._0, Form1.Width, Form1.Height)));
            mainImages.Add(new ImageWrapper(1, Resizer.ResizeImage(Resources._1, Form1.Width, Form1.Height)));
            mainImages.Add(new ImageWrapper(2, Resizer.ResizeImage(Resources._2, Form1.Width, Form1.Height)));
            mainImages.Add(new ImageWrapper(3, Resizer.ResizeImage(Resources._3, Form1.Width, Form1.Height)));
            mainImages.Add(new ImageWrapper(4, Resizer.ResizeImage(Resources._4, Form1.Width, Form1.Height)));
            mainImages.Add(new ImageWrapper(5, Resizer.ResizeImage(Resources._5, Form1.Width, Form1.Height)));
            mainImages.Add(new ImageWrapper(6, Resizer.ResizeImage(Resources._6, Form1.Width, Form1.Height)));
            mainImages.Add(new ImageWrapper(7, Resizer.ResizeImage(Resources._7, Form1.Width, Form1.Height)));
            mainImages.Add(new ImageWrapper(8, Resizer.ResizeImage(Resources._8, Form1.Width, Form1.Height)));
            mainImages.Add(new ImageWrapper(9, Resizer.ResizeImage(Resources._9, Form1.Width, Form1.Height)));
        }

        private void setTileNumber()
        {
            tileNumber = Form1.tileColumnNumber * Form1.tileRowNumber;
        }


        private void fillMatrix()
        {
           for(int i = 0; i < Form1.tileRowNumber; i++)
            {
                for(int j = 0; j < Form1.tileColumnNumber; j++)
                {
                    Tile newTile = new Tile(j * Tile.Width, i * Tile.Height);
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
            while(bombsSet!=bombCount)
            {
                int randomX = generator.Next(Form1.tileRowNumber);
                int randomY = generator.Next(Form1.tileColumnNumber);
                if (!mainMatrix[randomX][randomY].getBomb())
                {
                    mainMatrix[randomX][randomY].setBomb(true);
                    bombsSet++;
                }
            }
        }

        private void fillNumbersOfTiles()
        {
            for (int i = 0; i < Form1.tileRowNumber; i++)
            {
                for (int j = 0; j < Form1.tileColumnNumber; j++)
                {
                    int numberOfNeighbourBombs = 0;
                    //top
                    if (i - 1 >= 0 && mainMatrix[i - 1][j].getBomb())
                        numberOfNeighbourBombs++;
                    //top-right
                    if (i - 1 >= 0 && j + 1 <= Form1.tileColumnNumber - 1 && mainMatrix[i - 1][j + 1].getBomb())
                        numberOfNeighbourBombs++;
                    //right
                    if (j + 1 <= Form1.tileColumnNumber - 1 && mainMatrix[i][j + 1].getBomb())
                        numberOfNeighbourBombs++;
                    //bottom-right
                    if (i + 1 <= Form1.tileRowNumber - 1 && j + 1 <= Form1.tileColumnNumber - 1 && mainMatrix[i + 1][j + 1].getBomb())
                        numberOfNeighbourBombs++;
                    //bottom
                    if (i + 1 <= Form1.tileRowNumber-1 && mainMatrix[i + 1][j].getBomb())
                        numberOfNeighbourBombs++;
                    //bottom-left
                    if (i + 1 <= Form1.tileRowNumber-1 && j - 1 >= 0 && mainMatrix[i + 1][j - 1].getBomb())
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
            for (int i = 0; i < Form1.tileRowNumber; i++)
            {
                for (int j = 0; j < Form1.tileColumnNumber; j++)
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
            for (int i = 0; i < Form1.tileRowNumber; i++)
            {
                for (int j = 0; j < Form1.tileColumnNumber; j++)
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
                Form1.gameEnd = true;
                return;
            }

            if (mainMatrix[i][j].getNeighbourBombs()==0)
            {
                //top
                if (i - 1 >= 0)
                    tileClicked(i - 1, j);
                //top-right
                if (i - 1 >= 0 && j + 1 <= Form1.tileColumnNumber - 1)
                    tileClicked(i - 1, j + 1);
                //right
                if (j + 1 <= Form1.tileColumnNumber - 1)
                    tileClicked(i, j + 1);
                //bottom-right
                if (i + 1 <= Form1.tileRowNumber - 1 && j + 1 <= Form1.tileColumnNumber - 1) 
                    tileClicked(i + 1, j + 1);
                //bottom
                if (i + 1 <= Form1.tileRowNumber)
                    tileClicked(i + 1, j);
                //bottom-left
                if (i + 1 <= Form1.tileRowNumber - 1 && j - 1 >= 0)
                    tileClicked(i + 1, j - 1);
                //left
                if (j - 1 >= 0)
                    tileClicked(i, j - 1);
                //top-left
                if (j - 1 >= 0 && i - 1 >= 0)
                    tileClicked(i - 1, j - 1);
            }
        }

    }
}
