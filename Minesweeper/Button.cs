using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    class Button
    {
        public Point Location { get; set; }
        public Image Image { get; set; }
        public Image ImageHover { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool Clicked { get; set; }
        public bool Hit { get; set; }

        public Button(Point p, Image i1, Image i2, int width, int height)
        {
            Location = p;
            Image = i1;
            ImageHover = i2;
            Width = width;
            Height = height;
            Clicked = false;
            Hit = false;
        }

        public void Draw(Graphics g)
        {
            if (Clicked)
            {
                g.DrawImage(ImageHover, new Rectangle(Location, new Size(Width, Height)));
            }
            else if (Hit)
            {
                g.DrawImage(ImageHover, new Rectangle(new Point(Location.X - (int)(Width * 0.05), Location.Y - (int)(Height * 0.05)),
                    new Size((int)(Width * 1.1), (int)(Height * 1.1))));
            }
            else
            {
                g.DrawImage(Image, new Rectangle(Location, new Size(Width, Height)));
            }
        }

        public void isHit(int x, int y)
        {
            Hit = x > Location.X && x < Location.X + Width && y > Location.Y && y < Location.Y + Height;
        }

    }
}
