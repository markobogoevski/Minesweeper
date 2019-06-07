using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class AwardAccept : Form
    {
        string name;
        Image img;
        public AwardAccept(string name, Image img)
        {
            this.name = name;
            this.img = img;
            InitializeComponent();
            pictureBox1.Image = img;
            label2.Text = name;
        }

        private void AwardAccept_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
