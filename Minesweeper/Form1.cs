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
    public enum difficulty
    {
        EASY,
        INTERMEDIATE,
        HARD
    }
    public partial class Form1 : Form
    {
        difficulty diff { get; set; }
        int seconds { get; set; }
        public static bool gameEnd=false;
        public static Size mainWindowSize { get; set; }
        public static int tileRowNumber { get; set; }
        public static int tileColumnNumber { get; set; }
        public static int Width { get; set; }
        public static int Height { get; set; }
        int numberOfBombs { get; set; }
        int numberOfFlags { get; set; }
        Grid grid { get; set; }

        public Form1(difficulty diff)
        {
            this.diff = diff;
            InitializeComponent();
            mainScreen.Size = setScreen(diff);
            newGame();
        }

        private void newGame()
        {
            gameEnd = false;
            seconds = 0;
            timer.Start();
            grid = new Grid(numberOfBombs);
            numberOfFlags = numberOfBombs;
            flag.Text = "Flags : " + numberOfFlags.ToString();
            this.ClientSize = new Size(mainWindowSize.Width + 20, mainWindowSize.Height + 95);
            time.Location = new Point(ClientRectangle.Left + 10, ClientRectangle.Top + 40);
            flag.Location = new Point(ClientRectangle.Right - 160, ClientRectangle.Top + 40);
            mainScreen.Invalidate();
        }

        private Size setScreen(difficulty diff)
        {
            switch (diff)
            {
                case difficulty.EASY:
                    tileRowNumber = tileColumnNumber = 9;
                    Width = Height = 50;
                    mainWindowSize = new Size(tileColumnNumber*Width,tileRowNumber*Height);
                    numberOfBombs = 10;
                    break;
                case difficulty.INTERMEDIATE:
                    tileRowNumber = tileColumnNumber = 16;
                    numberOfBombs = 40;
                    Width = Height = 36;
                    mainWindowSize = new Size(tileColumnNumber*Width,tileRowNumber*Height);
                    break;
                case difficulty.HARD:
                    tileRowNumber = 16;
                    tileColumnNumber = 30;
                    numberOfBombs = 99;
                    Width = Height = 36;
                    mainWindowSize = new Size(tileColumnNumber*Width, tileRowNumber*Height);
                    break;
            }
            return mainWindowSize;
        }

        public void mainScreen_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            grid.draw(graphics);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            seconds++;
            if(seconds < 60)
                time.Text = "Time: " + seconds.ToString("00");
            else
                time.Text = "Time: " + (seconds / 60).ToString() + ":" + (seconds % 60).ToString("00");
        }

        private void mainScreen_MouseClick(object sender, MouseEventArgs e)
        {
            Point clickLocation = e.Location;
            int j = (clickLocation.X) / Width;
            int i = (clickLocation.Y) / Height;
            if (e.Button == MouseButtons.Left)
            {
                if(grid.getFlagged(i,j))
                {
                    numberOfFlags++;
                    flag.Text = "Flags : " + numberOfFlags.ToString();
                }
                grid.tileClicked(i, j);
                mainScreen.Invalidate();
                if (gameEnd)
                    endGame();
            }
            else
            {
                if (grid.flag(i, j))
                    numberOfFlags--;
                else
                    numberOfFlags++;

                flag.Text = "Flags : " + numberOfFlags.ToString();
                mainScreen.Invalidate();
            }
        }

        private void endGame()
        {
            timer.Stop();
            for (int i = 0; i < tileRowNumber; i++)
                for (int j = 0; j < tileColumnNumber; j++)
                    if (grid.mainMatrix[i][j].getBomb() && !grid.mainMatrix[i][j].getFlag())
                        grid.mainMatrix[i][j].click();
            DialogResult result = MessageBox.Show("You lost! Do you want to try again?","Oops!",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                newGame();
            }
            else
                this.Close();
        }
    }
}
