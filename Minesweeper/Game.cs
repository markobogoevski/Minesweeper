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
    public enum difficulty
    {
        EASY,
        INTERMEDIATE,
        HARD
    }
    public partial class Game : Form
    {
        //Logic
        public static difficulty DIFF { get; set; }
        int seconds { get; set; }
        public static bool gameEnd = false;
        int numberOfBombs { get; set; }
        int numberOfFlags { get; set; }
        public static int openedTiles { get; set; }
        Grid grid { get; set; }
        public int currentStreak { get; set; }
        public bool boosted { get; set; }
        public int simulation { get; set; }
        public bool wow { get; set; }

        //Drawing
        public static Size mainWindowSize { get; set; }
        public static int tileRowNumber { get; set; }
        public static int tileColumnNumber { get; set; }
        public static int TileWidth { get; set; }
        public static int TileHeight { get; set; }
        public static int windowWidth{get;set;}
        public static int windowHeight { get; set; }
        public static int WidthOffset = 10;
        public static int HeightOffset = 25;
        public Size initialSize { get; set; }

       
        public Game(difficulty d)
        {
            this.DoubleBuffered = true;
            mainScreen = new PictureBox();
            miniMenu = new MenuStrip();
            timer = new Timer();
            time = new Label();
            flag = new Label();
            boostedLabel = new Label();
            this.BackColor = Color.LightGray ;
            this.ClientSize = new Size(800, 600);
            initialSize = this.ClientSize;

            InitializeComponent();
            newGame(d);
        }

        private void newGame(difficulty d)
        {
            wow = false;
            button1.Enabled = false;
            button1.BackgroundImage = Resources.smileyHappy;
            grid = null;
            HeightOffset = miniMenu.Height + button1.Height ;
            mainScreen.Hide();
            boosted = false;
            simulation = 0;
            currentStreak = 0;
            DIFF = d;
            gameEnd = false;
            seconds = 0;
            openedTiles = 0;

            //cutting bottom
            if (DIFF == difficulty.HARD)
                this.ClientSize = cutBottom();
            else
                this.ClientSize = initialSize;

            //setting window size based on resolution (default)
            //setting picture box Size based on window size
            mainScreen.Size = setScreenOptions(Game.DIFF);

            //cutting bottom
            if (DIFF == difficulty.HARD)
                this.ClientSize = cutBottom();
            else
                this.ClientSize = initialSize;


            //centering screen 
            centerTheScreen();
          

            //starting game..
           

            grid = new Grid(numberOfBombs);
            numberOfFlags = numberOfBombs;
            mainScreen.Show();
            timer.Start();
            timer1.Stop();
            timer1.Enabled = false;
            boostedLabel.Hide();
            mainScreen.Invalidate();
        }

        private Size cutBottom()
        {
            return new Size(ClientSize.Width, miniMenu.Height + HeightOffset * 2 + mainScreen.Height);
        }

        private void centerTheScreen()
        {
            //center picture box
            mainScreen.Location = new Point((ClientSize.Width - mainScreen.Width) / 2,
               miniMenu.Height+HeightOffset);

            //center labels
            button1.Location = new Point(mainScreen.Left + mainScreen.Width / 2 - button1.Width / 2, mainScreen.Top - button1.Height - 5);
            time.Location = new Point(mainScreen.Left, mainScreen.Top-button1.Height+5);
            flag.Location = new Point(mainScreen.Right-flag.Width-8, mainScreen.Top-button1.Height+5);
        }

        private int getTileSize(int tileRowNumber, int tileColumnNumber)
        {
            int size1= (ClientSize.Width - 2 * WidthOffset) / tileColumnNumber;
            int size2= (ClientSize.Height - 2 * HeightOffset - miniMenu.Height) / tileRowNumber;
            return Math.Min(size1, size2);
        }

        private Size setScreenOptions(difficulty diff)
        {
            int size = 0;
            switch (diff)
            {
                case difficulty.EASY:
                    //setting easy options
                    numberOfBombs = 10;
                    tileRowNumber = tileColumnNumber = 9;
                    //Calculating tileSize
                    size = getTileSize(tileRowNumber, tileColumnNumber);
                    TileWidth = TileHeight = size;
                    //setting font and menu items
                    easyToolStripMenuItem.Checked = true;
                    mediumToolStripMenuItem.Checked = false;
                    hardToolStripMenuItem.Checked = false;
                    time.Font = new Font(time.Font.FontFamily, 16);
                    flag.Font = new Font(flag.Font.FontFamily, 16);
                    break;
                case difficulty.INTERMEDIATE:
                    //setting medium options
                    tileRowNumber = tileColumnNumber = 16;
                    numberOfBombs = 40;
                    //Calculating tileSize
                    size = getTileSize(tileRowNumber, tileColumnNumber);
                    TileWidth = TileHeight = size;
                    //setting font and menu items
                    easyToolStripMenuItem.Checked = false;
                    mediumToolStripMenuItem.Checked = true;
                    hardToolStripMenuItem.Checked = false;
                    time.Font = new Font(time.Font.FontFamily, 14);
                    flag.Font = new Font(flag.Font.FontFamily, 14);
                    break;
                case difficulty.HARD:
                    //setting medium options
                    tileRowNumber = 16;
                    tileColumnNumber = 30;
                    numberOfBombs = 99;
                    //Calculating tileSize
                    size = getTileSize(tileRowNumber, tileColumnNumber);
                    TileWidth = TileHeight = size;
                    //setting font and menu items
                    easyToolStripMenuItem.Checked = false;
                    mediumToolStripMenuItem.Checked = false;
                    hardToolStripMenuItem.Checked = true;
                    time.Font = new Font(time.Font.FontFamily, 12);
                    flag.Font = new Font(flag.Font.FontFamily, 12);
                    break;
            }

            mainWindowSize = new Size(tileColumnNumber * TileWidth, tileRowNumber * TileHeight);
           
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!boosted)
            {
                simulation++;
                if (simulation % 30 == 0)
                {
                    currentStreak = 0;
                    simulation = 0;
                }
            }
            else
            {
                if(simulation%2==0)
                {
                    this.BackColor = Color.Orange;
                }
                else
                {
                    this.BackColor = Color.YellowGreen;
                }

                simulation++;
                if (simulation % 8 == 0)
                {
                    simulation = 0;
                    endBoost();
                }
            }
        }

        private void endBoost()
        {
            button1.Show();
            simulation = 0;
            boosted = false;
            this.BackColor = Color.LightGray;
            grid.revertAll();
            timer1.Enabled = false;
            timer1.Stop();
            boostedLabel.Hide();
        }

        private void enableBoost()
        {
            button1.Hide();
            boostedLabel.Show();
            boostedLabel.Location = new Point(mainScreen.Left + mainScreen.Width / 2 - boostedLabel.Width / 2, mainScreen.Top - boostedLabel.Height-5);
            this.BackColor = Color.Orange;
            simulation = 0;
            boosted = true;
            grid.showAll();
            Invalidate(true);
        }

        private void mainScreen_MouseClick(object sender, MouseEventArgs e)
        {
            Point clickLocation = e.Location;
            int j = (clickLocation.X) / TileWidth;
            int i = (clickLocation.Y) / TileHeight;
            if (e.Button == MouseButtons.Left)
            {
                if (grid.getFlagged(i, j))
                    return;
                grid.tileClicked(i, j);
                mainScreen.Invalidate();
                checkWin();
                if (gameEnd)
                    endGame();
                if (Game.openedTiles >= 1 && !wow)
                {
                    button1.BackgroundImage = Resources.smileyWow;
                    wow = true;
                }
                else if (grid.visibleNumber() >= (Game.tileRowNumber * Game.tileColumnNumber / 2))
                    button1.BackgroundImage = Resources.smileyGlasses;
                
                
                if (!boosted)
                {
                    currentStreak++;
                    if (Game.openedTiles >= 1 && !timer1.Enabled)
                    {
                        timer1.Enabled = true;
                        timer1.Start();
                    }

                    if (currentStreak == 10)
                    {
                        currentStreak = 0;
                        enableBoost();
                    }
                }

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
            if (openedTiles == tileColumnNumber * tileRowNumber - numberOfBombs)
            {
                timer.Stop();
                DialogResult result = MessageBox.Show("You win! Do you want to play again?", "Congratulations!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    newGame(DIFF);
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

            //this.Hide();
            //new form



            //
            if (boosted)
                endBoost();

                for (int i = 0; i < tileRowNumber; i++)
                for (int j = 0; j < tileColumnNumber; j++)
                    if (grid.mainMatrix[i][j].getBomb() && !grid.mainMatrix[i][j].getFlag())
                        grid.mainMatrix[i][j].click();
            button1.BackgroundImage = Resources.smileyDead;
            DialogResult result = MessageBox.Show("You lost! Do you want to try again?","Oops!",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                newGame(DIFF);
                this.CenterToScreen();
            }
            else this.Close();
            
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGame(DIFF);
            this.CenterToScreen();
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGame(difficulty.EASY);
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGame(difficulty.INTERMEDIATE);
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGame(difficulty.HARD);

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

        private void Game_Resize(object sender, EventArgs e)
        {
            this.SuspendLayout();
            mainScreen.Hide();
            if (grid != null)
            {
                mainScreen.Size = setScreenOptions(DIFF);
                centerTheScreen();
                grid.changeMatrix();
            }
            Invalidate();
            mainScreen.Show();
            this.ResumeLayout();

        }
    }
}
