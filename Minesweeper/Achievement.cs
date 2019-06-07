using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    class Achievement{
        string name;
        Image image;
        bool unlocked;
        

        public Achievement(string name, Image image){
            this.name = name;
            this.image = image;
            this.unlocked = false;
        }

        public string getName() { return name; }
        public Image getImage() { return image; }
        public bool isLocked() { return unlocked; }
    }
}
