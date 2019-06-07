using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class Achievement{
        string name;
        bool isLocked;
        Image image;

        public Achievement(string name, Image image){
            this.name = name;
            this.image = image;
            this.isLocked = true;
        }

        public void Unlock(){
            this.isLocked = false;
        }
        public bool iSLocked() { return isLocked; }

        public string getName() { return name; }
        public Image getImage() { return image; }

    }
}
