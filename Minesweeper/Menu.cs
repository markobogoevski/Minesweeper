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
        public ImageWrapper skin { get; set; }
        private Button Play, Achiev, Leaderboards, Quit, Easy, Medium, Hard;
        private difficulty Diff;

        public Menu()
        {
            Play = new Button(new Point(185, 100), Resources.btnPlayDark, Resources.btnPlay, 245, 75);
            Achiev = new Button(new Point(185, 200), Resources.btnAchievDark, Resources.btnAchiev, 245, 75);
            Leaderboards = new Button(new Point(185, 300), Resources.btnLeadDark, Resources.btnLead, 245, 75);
            Quit = new Button(new Point(185, 400), Resources.btnQuitDark, Resources.btnQuit, 245, 75);
            Easy = new Button(new Point(135, 535), Resources.btnEasyDark, Resources.btnEasy, 100, 100);
            Medium = new Button(new Point(257, 535), Resources.btnMediumDark, Resources.btnMedium, 100, 100);
            Hard = new Button(new Point(380, 535), Resources.btnHardDark, Resources.btnHard, 100, 100);
            Diff = difficulty.EASY;
            Easy.Clicked = true;
            InitializeComponent();
            this.BackgroundImage = Resources.background;
            DoubleBuffered = true;
            skin = new ImageWrapper(9, Resources.mine);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Game g = new Game(Diff, skin);
            g.FormClosed += new FormClosedEventHandler(window_FormClosed);
            this.Cursor = Cursors.Default;
            g.Show();
            this.Hide();
            
        }

        private void window_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
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

        private void Menu_Paint(object sender, PaintEventArgs e)
        {
            Play.Draw(e.Graphics);
            Achiev.Draw(e.Graphics);
            Quit.Draw(e.Graphics);
            Leaderboards.Draw(e.Graphics);
            Easy.Draw(e.Graphics);
            Medium.Draw(e.Graphics);
            Hard.Draw(e.Graphics);
        }

        private void Menu_MouseClick(object sender, MouseEventArgs e)
        {
            if (Play.Hit) btnPlay_Click(null, null);
            else if (Quit.Hit) Application.Exit();
            else if (Leaderboards.Hit) btnLeaderboards_Click(null, null);
            else if (Achiev.Hit) btnAchievements_Click(null, null);
        }

        private void Menu_MouseMove(object sender, MouseEventArgs e)
        {
            Play.isHit(e.X, e.Y);
            Achiev.isHit(e.X, e.Y);
            Leaderboards.isHit(e.X, e.Y);
            Quit.isHit(e.X, e.Y);
            Easy.isHit(e.X, e.Y);
            Medium.isHit(e.X, e.Y);
            Hard.isHit(e.X, e.Y);
            Invalidate();
        }

        private void Menu_MouseDown(object sender, MouseEventArgs e)
        {
            if (Play.Hit) Play.Clicked = true;
            if (Quit.Hit) Quit.Clicked = true;
            if (Achiev.Hit) Achiev.Clicked = true;
            if (Leaderboards.Hit) Leaderboards.Clicked = true;
            if (Easy.Hit)
            {
                Easy.Clicked = true;
                Medium.Clicked = Hard.Clicked = false;
                Diff = difficulty.EASY;
            }
            else if (Medium.Hit)
            {
                Medium.Clicked = true;
                Easy.Clicked = Hard.Clicked = false;
                Diff = difficulty.INTERMEDIATE;
            }
            else if (Hard.Hit)
            {
                Hard.Clicked = true;
                Medium.Clicked = Easy.Clicked = false;
                Diff = difficulty.HARD;
            }
            Invalidate();
        }

        private void Menu_MouseUp(object sender, MouseEventArgs e)
        {
            Play.Clicked = Leaderboards.Clicked = Achiev.Clicked = Quit.Clicked = false;
        }
    }
}
