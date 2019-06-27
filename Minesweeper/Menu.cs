using Minesweeper.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    [Serializable]
    public partial class Menu : Form
    {
        public ImageWrapper skinImage { get; set; }
        private Button Play, Achiev, Leaderboards, Quit, Easy, Medium, Hard;
        private difficulty Diff;
        public List<Achievement> achievements;
        public Menu()
        {

            Play = new Button(new Point(140, 50), Resources.btnPlayDark, Resources.btnPlay, 150, 70);
            Achiev = new Button(new Point(140, 130), Resources.btnAchievDark, Resources.btnAchiev, 150, 70);
            Leaderboards = new Button(new Point(140, 210), Resources.btnLeadDark, Resources.btnLead, 150, 70);
            Quit = new Button(new Point(140, 290), Resources.btnQuitDark, Resources.btnQuit, 150, 70);
            Easy = new Button(new Point(55, 375), Resources.btnEasyDark, Resources.btnEasy, 90, 90);
            Medium = new Button(new Point(175, 375), Resources.btnMediumDark, Resources.btnMedium, 90, 90);
            Hard = new Button(new Point(295, 375), Resources.btnHardDark, Resources.btnHard, 90, 90);
            Diff = difficulty.EASY;
            Easy.Clicked = true;
            InitializeComponent();
            this.BackgroundImage = Resources.background;
            DoubleBuffered = true;
            skinImage = new ImageWrapper(Resources.mine);
            skinImage.getImage().Tag = "Mine";
            
            // try read from file, if can -> overwrite this ^ list
            if (LoadAchievements()!=null)
            {
                achievements = LoadAchievements();
            }
            else {
                achievements = new List<Achievement>();
                achievements.Add(new Achievement("Baloon", Resources.baloon, Resources.baloonLocked, 45, difficulty.EASY));
                achievements.Add(new Achievement("Nuke", Resources.nuke, Resources.nukeLocked, 15, difficulty.EASY));
                achievements.Add(new Achievement("Poison", Resources.poison, Resources.poisonLocked, 240, difficulty.INTERMEDIATE));
                achievements.Add(new Achievement("Shuriken", Resources.shuriken, Resources.shurikenLocked, 120, difficulty.INTERMEDIATE));
                achievements.Add(new Achievement("Trap", Resources.trap, Resources.trapLocked, 600, difficulty.HARD));
                achievements.Add(new Achievement("Bomb", Resources.bomb, Resources.bombLocked, 480, difficulty.HARD));
            }
            
        }
        private void SaveAchievements(List<Achievement>achievements)
        {
            using (FileStream stream = new FileStream("../../Assets/achievements.lst", FileMode.Create))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, achievements);
                stream.Close();
            }
        }
        private List<Achievement> LoadAchievements()
        {
            List<Achievement> achievements = null;
            if (File.Exists("Assets/achievements.lst"))
            {
                using (FileStream stream = new FileStream("Assets/achievements.lst", FileMode.Open))
                {
                    IFormatter formatter = new BinaryFormatter();
                    achievements = (List<Achievement>)formatter.Deserialize(stream);
                    stream.Close();
                }
            }
            return achievements;

        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Game g = new Game(Diff, skinImage, achievements);
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
            AchievementsForm form = new AchievementsForm(skinImage, achievements);
            form.FormClosed += new FormClosedEventHandler(window_FormClosed);
            form.Show();
            this.Hide();
        }

        private void btnLeaderboards_Click(object sender, EventArgs e)
        {
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
