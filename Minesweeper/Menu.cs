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
        public ImageWrapper skin { get; set; }
        private Button Play, Achiev, Leaderboards, Quit, Easy, Medium, Hard;
        private difficulty Diff;
        public List<Achievement> achievements;
        public Menu()
        {
            Play = new Button(new Point(218, 100), Resources.btnPlayDark, Resources.btnPlay, 178, 84);
            Achiev = new Button(new Point(218, 205), Resources.btnAchievDark, Resources.btnAchiev, 178, 84);
            Leaderboards = new Button(new Point(218, 310), Resources.btnLeadDark, Resources.btnLead, 178, 84);
            Quit = new Button(new Point(218, 415), Resources.btnQuitDark, Resources.btnQuit, 178, 84);
            Easy = new Button(new Point(135, 535), Resources.btnEasyDark, Resources.btnEasy, 100, 100);
            Medium = new Button(new Point(257, 535), Resources.btnMediumDark, Resources.btnMedium, 100, 100);
            Hard = new Button(new Point(380, 535), Resources.btnHardDark, Resources.btnHard, 100, 100);
            Diff = difficulty.EASY;
            Easy.Clicked = true;
            InitializeComponent();
            this.BackgroundImage = Resources.background;
            DoubleBuffered = true;
            skin = new ImageWrapper(9, Resources.mine);
            
            //TODO: try read from file, if can -> overwrite this ^ list
            if (LoadAchievements()!=null)
            {
                achievements = LoadAchievements();
            }
            else {
                achievements = new List<Achievement>();
                achievements.Add(new Achievement("Baloon", Resources.baloon, Resources.baloonLocked, 45, difficulty.EASY));
                achievements.Add(new Achievement("Nuke", Resources.nuke, Resources.nukeLocked, 15, difficulty.EASY));
                achievements.Add(new Achievement("Poison", Resources.poison, Resources.poisonLocked, 210, difficulty.INTERMEDIATE));
                achievements.Add(new Achievement("Shuriken", Resources.shuriken, Resources.shurikenLocked, 90, difficulty.INTERMEDIATE));
                achievements.Add(new Achievement("Trap", Resources.trap, Resources.trapLocked, 600, difficulty.HARD));
                achievements.Add(new Achievement("Bomb", Resources.bomb, Resources.bombLocked, 360, difficulty.HARD));
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
            if (File.Exists("../../Assets/achievements.lst"))
            {
                using (FileStream stream = new FileStream("../../Assets/achievements.lst", FileMode.Open))
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
            Game g = new Game(Diff, skin,achievements);
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
            AchievementsForm form = new AchievementsForm(skin,achievements);
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
