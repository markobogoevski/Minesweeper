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
    public class Tile : IEquatable<Tile>
    {
        //Position info
        public Point location { get; set; }

        //Size info 
        public static int Width = Game.TileWidth;
        public static int Height = Game.TileHeight;

        //Images
        public static Image backgroundImage = Resources.back;
        public static Image flaggedImage = Resources.flagged;
        public static Image questionMark = Resources.questionMark;
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
            setLocation(xCoord,yCoord);
        }

        public void setMainImage(Image image)
        {
            this.mainImage = image;
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

        private void setLocation(int XCoord, int YCoord)
        {
            location = new Point(XCoord, YCoord);
        }
        public void draw(Graphics g)
        {
            Rectangle rectangle = new Rectangle(location, new Size(Game.TileWidth, Game.TileHeight));
            if (isRevealed)
            {
                if (hasBomb)
                    g.FillRectangle(new SolidBrush(Color.IndianRed), rectangle);
                g.DrawImage(mainImage, rectangle);
            }
            else
            {
                if (flagged)
                {
                    g.DrawImage(flaggedImage, rectangle);
                }
                else if (questionMarked)
                {
                    g.DrawImage(questionMark, rectangle);
                }
                else
                {
                    g.DrawImage(backgroundImage, rectangle);
                }
            }
            g.DrawRectangle(new Pen(Color.Black, 2), rectangle);
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
                    location.X == other.location.X &&
                   location.Y == other.location.Y;
        }

        public override int GetHashCode()
        {
            var hashCode = 269724561;
            hashCode = hashCode * -1521134295 + location.X.GetHashCode();
            hashCode = hashCode * -1521134295 + location.Y.GetHashCode();
            return hashCode;
        }
    }
}
