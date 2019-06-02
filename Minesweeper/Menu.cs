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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Game g = new Game();
            g.FormClosed += new FormClosedEventHandler(game_FormClosed);
            g.Show();
            this.Hide();
        }

        private void game_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
