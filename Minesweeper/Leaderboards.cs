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
    public partial class Leaderboards : Form
    {
        static Random rand = new Random();
        public static SortedList<Score,Score> EasyScores { get; set; }
        public static SortedList<Score,Score> MediumScores { get; set; }
        public static SortedList<Score,Score> HardScores { get; set; }
        private Button Easy, Medium, Hard, Back;
        string EasyName = "../../Assets/easy.lst";
        string MediumName = "../../Assets/medium.lst";
        string HardName = "../../Assets/hard.lst";
        public Leaderboards()
        {
            InitializeComponent();
            DoubleBuffered = true;
            EasyScores = getList(EasyName);
            MediumScores = getList(MediumName);
            HardScores = getList(HardName);
            this.BackgroundImage = Resources.background;
            Easy = new Button(new Point(530, 50), Resources.btnEasyDarkLead, Resources.btnEasyLeaderboards, 89, 42);
            Medium = new Button(new Point(530, 100), Resources.btnMediumDarkLead, Resources.btnMediumLeaderboards, 89, 42);
            Hard = new Button(new Point(530, 150), Resources.btnHardDarkLead, Resources.btnHardLeaderboards, 89, 42);
            Back = new Button(new Point(530, 200), Resources.btnBackDark, Resources.btnBackLight, 89, 42);
            generateScore(EasyScores, "Easy");
        }

        private void Leaderboards_Paint(object sender, PaintEventArgs e)
        {
            Easy.Draw(e.Graphics);
            Medium.Draw(e.Graphics);
            Hard.Draw(e.Graphics);
            Back.Draw(e.Graphics);
        }

        private SortedList<Score,Score> getList(string FileName)
        {
            SortedList<Score,Score> scores;
            try
            {
                using (FileStream stream = new FileStream(FileName, FileMode.Open))
                {
                    IFormatter formatter = new BinaryFormatter();
                    scores = (SortedList<Score,Score>)formatter.Deserialize(stream);
                    stream.Close();
                }
            }
            catch (FileNotFoundException)
            {
                scores = new SortedList<Score,Score>();
            }
            return scores;
        }

        private void generateScore(SortedList<Score,Score> s, string text)
        {
            lblDiff.Text = text;
            lblHeader.Text = string.Format("{0,-4} {1,-25} {2,-7} {3,-10}", "No.", "Name", "Time", "Date");
            lblScores.Text = "";
            for (int i = 1; i <= s.Count; i++)
            {
                lblScores.Text += string.Format("{0,-4} {1}\n", i+")", s.Keys[i - 1]);
            }
        }
        private void Lead_MouseClick(object sender, MouseEventArgs e)
        {
            if (Easy.Hit) generateScore(EasyScores, "Easy");
            else if (Medium.Hit) generateScore(MediumScores, "Medium");
            else if (Hard.Hit) generateScore(HardScores, "Hard");
            else if (Back.Hit) this.Close();
        }

        private void Lead_MouseMove(object sender, MouseEventArgs e)
        {
            Back.isHit(e.X, e.Y);
            Easy.isHit(e.X, e.Y);
            Medium.isHit(e.X, e.Y);
            Hard.isHit(e.X, e.Y);
            Invalidate();
        }

        private void Lead_MouseDown(object sender, MouseEventArgs e)
        {
            if (Back.Hit) Back.Clicked = true;
            if (Easy.Hit)
                Easy.Clicked = true;
            else if (Medium.Hit)
                Medium.Clicked = true;
            else if (Hard.Hit)
                Hard.Clicked = true;
            Invalidate();
        }

        private void Lead_MouseUp(object sender, MouseEventArgs e)
        {
            Easy.Clicked = Medium.Clicked = Hard.Clicked = Back.Clicked = false;
        }
    }
}
