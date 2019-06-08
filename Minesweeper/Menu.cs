using Minesweeper.Properties;
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
        public ImageWrapper skin;
        public Menu()
        {
            InitializeComponent();
            menuPanel.BackgroundImage = Resources.background;
            DoubleBuffered = true;
            skin = new ImageWrapper(9, Properties.Resources.mine);
        }

        private difficulty getChecked()
        {
            if (rbEasy.Checked) return difficulty.EASY;
            else if (rbMedium.Checked) return difficulty.INTERMEDIATE;
            else return difficulty.HARD;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Game g = new Game(getChecked(),skin);
            g.FormClosed += new FormClosedEventHandler(window_FormClosed);
            g.Show();
            this.Hide();
        }

        private void window_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAchievements_Click(object sender, EventArgs e)
        {
            // TODO: Implement the achievments form, showing all unlocked and locked achievments and the criteria for unlocking
            AchievementsForm form = new AchievementsForm(skin);
            form.FormClosed += new FormClosedEventHandler(window_FormClosed);
            form.Show();
            this.Hide();
        }

        private void btnLeaderboards_Click(object sender, EventArgs e)
        {
            // TODO: Implement the leaderboards form, showing best scores sorted by time descending, for each difficulty.
            Leaderboards l = new Leaderboards();
            l.FormClosed += new FormClosedEventHandler(window_FormClosed);
            l.Show();
            this.Hide();
        }



        private void Button1_Click(object sender, EventArgs e)
        {
            Spin forma = new Spin();
            forma.Show();
        }
    }
}
