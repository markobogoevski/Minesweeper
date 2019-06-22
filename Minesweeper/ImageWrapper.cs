using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class ImageWrapper
    {
        public Image image { get; set; }

        public ImageWrapper(Image image)
        {
            this.image = image;
        }

        public Image getImage() { return image; }
        public void setImage(Image image) { this.image = image; }
    }
}
