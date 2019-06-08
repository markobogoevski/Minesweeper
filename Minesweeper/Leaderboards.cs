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
        public static List<Score> EasyScores { get; set; }
        public static List<Score> MediumScores { get; set; }
        public static List<Score> HardScores { get; set; }
        string EasyName = "easy.lst";
        string MediumName = "medium.lst";
        string HardName = "hard.lst";
        public Leaderboards()
        {
            InitializeComponent();
            DoubleBuffered = true;
            EasyScores = getList(EasyName);
            MediumScores = getList(MediumName);
            HardScores = getList(HardName);
            this.BackgroundImage = Resources.background;
            //for(int i = 0; i < 100; i++)
            //{
                
            //    EasyScores.Add(new Score("Andrej Milovanovikj", rand.Next(0,2), rand.Next(10,60)));
            //    MediumScores.Add(new Score("Andrej Milovanovikj", rand.Next(2, 6), rand.Next(0, 60)));
            //    HardScores.Add(new Score("Andrej Milovanovikj", rand.Next(7, 12), rand.Next(0, 60)));
            //}

            EasyScores.Sort();
            MediumScores.Sort();
            HardScores.Sort();
            generateScore();
        }

        private List<Score> getList(string FileName)
        {
            List<Score> scores;
            try
            {
                using (FileStream stream = new FileStream(FileName, FileMode.Open))
                {
                    IFormatter formatter = new BinaryFormatter();
                    scores = (List<Score>)formatter.Deserialize(stream);
                }
            }
            catch (FileNotFoundException)
            {
                scores = new List<Score>();
            }
            return scores;
        }

        private void generateScore()
        {
            lblEasyHeader.Text = string.Format("{0,-4} {1,-25} {2,-7} {3,-10}", "No.", "Name", "Time", "Date");
            lblEasyScores.Text = "";
            for (int i = 1; i <= EasyScores.Count; i++)
            {
                lblEasyScores.Text += string.Format("{0,-4} {1}\n", i+")", EasyScores[i - 1]);
            }

            lblMediumHeader.Text = string.Format("{0,-4} {1,-25} {2,-7} {3,-10}", "No.", "Name", "Time", "Date");
            lblMediumScores.Text = "";
            for (int i = 1; i <= MediumScores.Count; i++)
            {
                lblMediumScores.Text += string.Format("{0,-4} {1}\n", i + ")", MediumScores[i - 1]);
            }

            lblHardHeader.Text = string.Format("{0,-4} {1,-25} {2,-7} {3,-10}", "No.", "Name", "Time", "Date");
            lblHardScores.Text = "";
            for (int i = 1; i <= HardScores.Count; i++)
            {
                lblHardScores.Text += string.Format("{0,-4} {1}\n", i + ")", HardScores[i - 1]);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
