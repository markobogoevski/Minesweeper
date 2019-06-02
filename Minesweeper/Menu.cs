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

        private difficulty getChecked()
        {
            if (rbEasy.Checked) return difficulty.EASY;
            else if (rbMedium.Checked) return difficulty.INTERMEDIATE;
            else return difficulty.HARD;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Game g = new Game(getChecked());
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

        private void btnAchievements_Click(object sender, EventArgs e)
        {

        }

        private void btnLeaderboards_Click(object sender, EventArgs e)
        {

        }

        private void btnSkins_Click(object sender, EventArgs e)
        {

        }
    }
}
