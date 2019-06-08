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
            menuPanel.BackgroundImage = Properties.Resources.background;
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

        private void btnPlay_MouseEnter(object sender, EventArgs e)
        {
            btnPlay.Image = Properties.Resources.btnPlay;
            btnPlay.Width += 20;
            btnPlay.Height += 10;
            btnPlay.Location = new Point(btnPlay.Location.X - 10, btnPlay.Location.Y - 5);
        }

        private void btnPlay_MouseLeave(object sender, EventArgs e)
        {
            btnPlay.Image = Properties.Resources.btnPlayDark;
            btnPlay.Width -= 20;
            btnPlay.Height -= 10;
            btnPlay.Location = new Point(btnPlay.Location.X + 10, btnPlay.Location.Y + 5);
        }

        private void btnAchievments_MouseEnter(object sender, EventArgs e)
        {
            btnAchievments.Image = Properties.Resources.btnAchiev;
            btnAchievments.Width += 20;
            btnAchievments.Height += 10;
            btnAchievments.Location = new Point(btnAchievments.Location.X - 10, btnAchievments.Location.Y - 5);
        }

        private void btnAchievments_MouseLeave(object sender, EventArgs e)
        {
            btnAchievments.Image = Properties.Resources.btnAchievDark;
            btnAchievments.Width -= 20;
            btnAchievments.Height -= 10;
            btnAchievments.Location = new Point(btnAchievments.Location.X + 10, btnAchievments.Location.Y + 5);
        }

        private void btnLeaderboards_MouseEnter(object sender, EventArgs e)
        {
            btnLeaderboards.Image = Properties.Resources.btnLead;
            btnLeaderboards.Width += 20;
            btnLeaderboards.Height += 10;
            btnLeaderboards.Location = new Point(btnLeaderboards.Location.X - 10, btnLeaderboards.Location.Y - 5);
        }

        private void btnLeaderboards_MouseLeave(object sender, EventArgs e)
        {
            btnLeaderboards.Image = Properties.Resources.btnLeadDark;
            btnLeaderboards.Width -= 20;
            btnLeaderboards.Height -= 10;
            btnLeaderboards.Location = new Point(btnLeaderboards.Location.X + 10, btnLeaderboards.Location.Y + 5);
        }

        private void btnQuit_MouseEnter(object sender, EventArgs e)
        {
            btnQuit.Image = Properties.Resources.btnQuit;
            btnQuit.Width += 20;
            btnQuit.Height += 10;
            btnQuit.Location = new Point(btnQuit.Location.X - 10, btnQuit.Location.Y - 5);
        }

        private void btnQuit_MouseLeave(object sender, EventArgs e)
        {
            btnQuit.Image = Properties.Resources.btnQuitDark;
            btnQuit.Width -= 20;
            btnQuit.Height -= 10;
            btnQuit.Location = new Point(btnQuit.Location.X + 10, btnQuit.Location.Y + 5);
        }
    }
}
