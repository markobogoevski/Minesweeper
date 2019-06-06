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
        Point location { get; set; }

        //Size info 
        public static int Width = Game.TileWidth;
        public static int Height = Game.TileHeight;

        //Images
        public static Image backgroundImage { get; set; }
        Image flaggedImage { get; set; }
        Image mainImage { get; set; }
        
        //Logic
        private bool hasBomb { get; set; }
        public bool previousState { get; set; }
        public bool isRevealed { get; set; }
        private int neighbourBombs { get; set; }
        private bool flagged { get; set; }

        public Tile(int xCoord, int yCoord)
        {
            XCoord = xCoord;
            YCoord = yCoord;
            flaggedImage = Resizer.ResizeImage(Resources.flagged,Game.TileWidth,Game.TileHeight);
            backgroundImage = Resizer.ResizeImage(Resources.back, Game.TileWidth, Game.TileHeight);
            location = new Point(XCoord, YCoord);
        }

        public bool getBomb() { return hasBomb; }

        public void setBomb(bool hasBomb)
        {
            this.hasBomb = hasBomb;
        }
        
        public bool getFlag() { return flagged; }

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

        public void setImage(Image image)
        {
            this.mainImage = image;
        }

        public int getNeighbourBombs() { return neighbourBombs; }

        public void setNeighbourBombs(int bombs)
        {
            this.neighbourBombs = bombs;
        }
        
        public void draw(Graphics g)
        {
            if (isRevealed)
            {
                g.DrawImageUnscaled(mainImage, location);
            }
            else
            {
                if (flagged)
                    g.DrawImageUnscaled(flaggedImage, location);
                else
                g.DrawImageUnscaled(backgroundImage, location);
            }
        }

        public bool click()
        {
            if (!isRevealed)
            {
                isRevealed = true;
                previousState = isRevealed;
                Game.openedTiles++;
                return true;
            }
            else
            return false;
        }

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
