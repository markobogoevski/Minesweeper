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
    public partial class Game : Form
    {
        public static difficulty DIFF { get; set; }
        int seconds { get; set; }
        public static bool gameEnd=false;
        public static Size mainWindowSize { get; set; }
        public static int tileRowNumber { get; set; }
        public static int tileColumnNumber { get; set; }
        public new static int Width { get; set; }
        public new static int Height { get; set; }
        int numberOfBombs { get; set; }
        int numberOfFlags { get; set; }
        public static int openedTiles { get; set; }
        Grid grid { get; set; }

        public Game(difficulty d)
        {
            mainScreen = new PictureBox();
            miniMenu = new MenuStrip();
            timer = new Timer();
            time = new Label();
            flag = new Label();
            DIFF = d;
            InitializeComponent();
            newGame();
        }

        private void newGame()
        {
            
            gameEnd = false;
            seconds = 0;
            openedTiles = 0;
            mainScreen.Size = setScreen(Game.DIFF);
            miniMenu.Visible = true;
            timer.Start();
            grid = new Grid(numberOfBombs);
            numberOfFlags = numberOfBombs;
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
                    Width = Height = 40;
                    mainWindowSize = new Size(tileColumnNumber*Width,tileRowNumber*Height);
                    numberOfBombs = 10;
                    break;
                case difficulty.INTERMEDIATE:
                    tileRowNumber = tileColumnNumber = 16;
                    numberOfBombs = 40;
                    Width = Height = 40;
                    mainWindowSize = new Size(tileColumnNumber*Width,tileRowNumber*Height);
                    break;
                case difficulty.HARD:
                    tileRowNumber = 16;
                    tileColumnNumber = 30;
                    numberOfBombs = 99;
                    Width = Height = 40;
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
            Invalidate(true);
        }

        private void mainScreen_MouseClick(object sender, MouseEventArgs e)
        {
            Point clickLocation = e.Location;
            int j = (clickLocation.X) / Width;
            int i = (clickLocation.Y) / Height;
            if (e.Button == MouseButtons.Left)
            {
                if (grid.getFlagged(i, j))
                    return;
                grid.tileClicked(i, j);
                mainScreen.Invalidate();
                checkWin();
                if (gameEnd)
                    endGame();
            }
            else if(e.Button == MouseButtons.Right)
            {
                if(numberOfFlags == 0 && !grid.getFlagged(i, j))
                    return;
                else if (grid.flag(i, j))
                    numberOfFlags--;
                else
                    numberOfFlags++;
                mainScreen.Invalidate();
                checkWin();
            }
            Invalidate(true);
        }

        private void checkWin()
        {
            if (numberOfFlags == 0 && openedTiles == tileColumnNumber * tileRowNumber - numberOfBombs)
            {
                timer.Stop();
                DialogResult result = MessageBox.Show("You win! Do you want to play again?", "Congratulations!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    newGame();
                    this.CenterToScreen();
                }
                else
                {
                    this.Close();
                }
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
                this.CenterToScreen();
            }
            else this.Close();
            
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGame();
            this.CenterToScreen();
        }

        private void CheckMenuItem(ToolStripMenuItem menu, ToolStripMenuItem checked_item)
        {
            foreach (ToolStripMenuItem item in menu.DropDownItems)
            {
                if (item == checked_item)
                    item.Checked = true;
                else item.Checked = false;
            }
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckMenuItem(chooseDifficultyToolStripMenuItem, easyToolStripMenuItem);
            Game.DIFF = difficulty.EASY;
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckMenuItem(chooseDifficultyToolStripMenuItem, mediumToolStripMenuItem);
            Game.DIFF = difficulty.INTERMEDIATE;
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckMenuItem(chooseDifficultyToolStripMenuItem, hardToolStripMenuItem);
            Game.DIFF = difficulty.HARD;
        }

        private void backToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void time_Paint(object sender, PaintEventArgs e)
        {
            if (seconds < 60)
                time.Text = "Time: " + seconds.ToString("00");
            else
                time.Text = "Time: " + (seconds / 60).ToString() + ":" + (seconds % 60).ToString("00");
        }

        private void flag_Paint(object sender, PaintEventArgs e)
        {
            flag.Text = "Flags: " + numberOfFlags.ToString();
        }

    }
}
