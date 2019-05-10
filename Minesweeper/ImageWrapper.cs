using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    class ImageWrapper
    {
        int number { get; set; }
        Image image { get; set; }

        public ImageWrapper(int number, Image image)
        {
            this.number = number;
            this.image = image;
        }

        public Image getImage() { return image; }
        public int getNumber() { return number; }
    }
}
