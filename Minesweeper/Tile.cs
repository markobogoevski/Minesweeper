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
    class Tile : IEquatable<Tile>
    {
        //Position info
        int XCoord { get; set; }
        int YCoord { get; set; }
        public Point location { get; set; }

        //Size info 
        public static int Width = Game.TileWidth;
        public static int Height = Game.TileHeight;

        //Images
        public static Image backgroundImage { get; set; }
        public static Image flaggedImage { get; set; }
        public static Image questionMark { get; set; }
        public Image mainImage { get; set; }
        
        //Logic
        private bool hasBomb { get; set; }
        public bool previousState { get; set; }
        public bool isRevealed { get; set; }
        private int neighbourBombs { get; set; }
        private bool flagged { get; set; }
        private bool questionMarked { get; set; }

        public Tile(int xCoord, int yCoord)
        {
            XCoord = xCoord;
            YCoord = yCoord;
            setImagesSizeWithoutMain();
            setLocation();
        }


        // Images options
        public void setImagesSizeWithoutMain()
        {
            //questionMark = Resources.questionMark;
            //flaggedImage = Resources.flagged;
            //backgroundImage = Resources.back;
           questionMark = Resizer.ResizeImage(Resources.questionMark, Game.TileWidth, Game.TileHeight);
            flaggedImage = Resizer.ResizeImage(Resources.flagged, Game.TileWidth, Game.TileHeight);
            backgroundImage = Resizer.ResizeImage(Resources.back, Game.TileWidth, Game.TileHeight);
        }

        public void setMainImage(Image image)
        {
            this.mainImage = image;
            mainImage = Resizer.ResizeImage(mainImage, Game.TileWidth, Game.TileHeight);
        }

        //checks to see if there is a bomb in tile
        public bool getBomb() { return hasBomb; }

        public void setBomb(bool hasBomb)
        {
            this.hasBomb = hasBomb;
        }
        
        //checks if tile is flagged
        public bool getFlag() { return flagged; }

        //toggles the flag on tile
        public bool flag()
        {
            if (!flagged)
            {
                flagged = true;
                return true;
            }
            else
            {
                flagged = false;
                return false;
            }
        }

        //question mark
        public void tryToQuestionMark()
        {
            if (flagged)
            {
                questionMarked = true;
            }
            else if (questionMarked)
            {
                questionMarked = false;
            }
            flagged = false;
        }
        public bool getQuestionMark() { return questionMarked; }


        //for numbering the grid, calculates neighbour bombs number
        public int getNeighbourBombs() { return neighbourBombs; }

        public void setNeighbourBombs(int bombs)
        {
            this.neighbourBombs = bombs;
        }

        //draws tile (3 images - background, flagged and main image)

        private void setLocation()
        {
            location = new Point(XCoord, YCoord);
        }
        public void draw(Graphics g)
        {
            if (isRevealed)
            {
                if (hasBomb)
                    g.FillRectangle(new SolidBrush(Color.IndianRed), new Rectangle(location, new Size(Game.TileWidth, Game.TileHeight)));
                g.DrawImageUnscaled(mainImage, location);
            }
            else
            {
                if (flagged)
                    g.DrawImageUnscaled(flaggedImage, location);
                else if (questionMarked)
                    g.DrawImageUnscaled(questionMark, location);
                else
                g.DrawImageUnscaled(backgroundImage, location);
            }
            g.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(location, new Size(Game.TileWidth, Game.TileHeight)));
        }

        //click function, tries to click the tiled and indicates if success (game.openedTiles)
        public bool click()
        {
            if (!isRevealed)
            {
                isRevealed = true;
                previousState = isRevealed;
                Game.openedTiles++;
                return true;
            }
            return false;
        }


        //Equality utilities
        public override bool Equals(object obj)
        {
            return Equals(obj as Tile);
        }

        public bool Equals(Tile other)
        {
            return other != null &&
                   XCoord == other.XCoord &&
                   YCoord == other.YCoord;
        }

        public override int GetHashCode()
        {
            var hashCode = 269724561;
            hashCode = hashCode * -1521134295 + XCoord.GetHashCode();
            hashCode = hashCode * -1521134295 + YCoord.GetHashCode();
            return hashCode;
        }
    }
}
