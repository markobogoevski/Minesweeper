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

            generateScore();
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
                }
            }
            catch (FileNotFoundException)
            {
                scores = new SortedList<Score,Score>();
            }
            return scores;
        }

        private void generateScore()
        {
            lblEasyHeader.Text = string.Format("{0,-4} {1,-25} {2,-7} {3,-10}", "No.", "Name", "Time", "Date");
            lblEasyScores.Text = "";
            for (int i = 1; i <= EasyScores.Count; i++)
            {
                lblEasyScores.Text += string.Format("{0,-4} {1}\n", i+")", EasyScores.Keys[i - 1]);
            }

            lblMediumHeader.Text = string.Format("{0,-4} {1,-25} {2,-7} {3,-10}", "No.", "Name", "Time", "Date");
            lblMediumScores.Text = "";
            for (int i = 1; i <= MediumScores.Count; i++)
            {
                lblMediumScores.Text += string.Format("{0,-4} {1}\n", i + ")", MediumScores.Keys[i - 1]);
            }

            lblHardHeader.Text = string.Format("{0,-4} {1,-25} {2,-7} {3,-10}", "No.", "Name", "Time", "Date");
            lblHardScores.Text = "";
            for (int i = 1; i <= HardScores.Count; i++)
            {
                lblHardScores.Text += string.Format("{0,-4} {1}\n", i + ")", HardScores.Keys[i - 1]);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
