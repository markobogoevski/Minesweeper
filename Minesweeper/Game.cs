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
    public enum difficulty
    {
        EASY,
        INTERMEDIATE,
        HARD,
        NONE
    }
    public partial class Game : Form
    {
        //Logic
        static Random rand = new Random();
        public static difficulty DIFF { get; set; }
        int seconds { get; set; }
        public static bool gameEnd = false;
        int numberOfBombs { get; set; }
        int numberOfFlags { get; set; }
        public static int openedTiles { get; set; }
        public Grid grid { get; set; }
        public int currentStreak { get; set; }
        public bool boosted { get; set; }
        public int simulation { get; set; }
        public bool wow { get; set; }
        public int simulationIdleEvent { get; set; }
        public bool resizeHold { get; set; }
        bool secondChance;
        Tile hintTile { get; set; }
        List<Achievement> achievements;
        //Drawing
        public static Size mainWindowSize { get; set; }
        public static int tileRowNumber { get; set; }
        public static int tileColumnNumber { get; set; }
        public static int TileWidth { get; set; }
        public static int TileHeight { get; set; }
        public static int windowWidth{get;set;}
        public static int windowHeight { get; set; }
        public static int WidthOffset = 25;
        public static int HeightOffset { get; set; }
        public Size previousSize { get; set; }
        public static float coefWidth { get; set; }
        public static float coefHeight { get; set; }
        public bool outside { get; set; }
        public FormBorderStyle previousStyle { get; set; }
        public FormWindowState previousState { get; set; }
        public Size previousMaxSize { get; set; }
        public int previousTileSize { get; set; }
        public bool fullscreen { get; set; }
        public ImageWrapper skin { get; set; }
       

       
        public Game(difficulty d, ImageWrapper s, List<Achievement>achievements)
        {
            this.skin = s;
            DIFF = difficulty.NONE ;

            this.DoubleBuffered = true;
            this.BackColor = Color.LightGray ;

            //default tile size
            resizeHold = true;
            Game.TileWidth = Game.TileHeight = 50;

            resizeHold = false;

            InitializeComponent();
            HeightOffset = miniMenu.Height + button1.Height + 15;
            this.achievements = achievements;
            newGame(d);
        }

        //main func
        private void newGame(difficulty d)
        {
            mainScreen.SuspendLayout();
            mainScreen.Hide();
            secondChance = false;



            button1.BackgroundImage = Resources.smileyHappy;
           
            this.Cursor = Cursors.WaitCursor;


            //initializing properties
            outside = false;
            grid = null;
            hintTile = null;
            wow = false;
            boosted = false;
            simulation = 0;
            currentStreak = 0;
            simulationIdleEvent = 0;
            gameEnd = false;
            seconds = 0;
            openedTiles = 0;

            if (!fullscreen)
            {
                //setting window size based on resolution (default)
                //setting picture box Size based on window size

                setScreenOptions(d);



                //centering screen 

                centerTheScreen();
            }
            DIFF = d;


            //starting game..


            grid = new Grid(numberOfBombs,skin);
            numberOfFlags = numberOfBombs;
           

            timer.Start();
            idleTimer.Start();
            timer1.Stop();
            timer1.Enabled = false;
            boostedLabel.Hide();
        
          
            this.Cursor = Cursors.Default;
            this.CenterToScreen();

            
            mainScreen.Show();
            mainScreen.ResumeLayout();
            Invalidate();
        }


        private void centerTheScreen()
        {
           

            if(ClientSize.Height-mainScreen.Height >= 300)
                this.ClientSize = new Size(this.ClientSize.Width, mainScreen.Size.Height + 1 * HeightOffset
                   + miniMenu.Height+100);

            mainScreen.Location = new Point((ClientSize.Width - mainScreen.Width) / 2,
               HeightOffset);
            //center labels
            button1.Location = new Point(mainScreen.Left + mainScreen.Width / 2 - button1.Width / 2, mainScreen.Top - button1.Height - 5);
            time.Location = new Point(mainScreen.Left, mainScreen.Top-time.Height);
            flag.Location = new Point(mainScreen.Right-flag.Width, mainScreen.Top-flag.Height);
        }

        private int getTileSize(int tileRowNumber, int tileColumnNumber)
        {
            int size1= (ClientSize.Width - 2 * WidthOffset) / tileColumnNumber;
            int size2= (ClientSize.Height - 2 * HeightOffset - miniMenu.Height) / tileRowNumber;
            return Math.Min(size1, size2);
        }

        private void setScreenOptions(difficulty d)
        {
            if (DIFF != d)
            {
                int size = 0;
                switch (d)
                {
                    case difficulty.EASY:
                        //setting easy options
                        numberOfBombs = 10;
                        tileRowNumber = tileColumnNumber = 9;
                        this.MinimumSize = new Size(468, 515);
                        this.MaximumSize = new Size(1200, 915);
                        //Calculating tileSize
                        if (Game.TileHeight == 0)
                        {
                            size = getTileSize(tileRowNumber, tileColumnNumber);
                            MessageBox.Show(size.ToString());
                            TileWidth = TileHeight = size;
                        }
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
                        this.MinimumSize = new Size(520, 585);
                        this.MaximumSize = new Size(1440, 990);

                        //Calculating tileSize
                        if (Game.TileHeight == 0)
                        {
                            size = getTileSize(tileRowNumber, tileColumnNumber);
                            MessageBox.Show(size.ToString());

                            TileWidth = TileHeight = size;
                        }
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
                        this.MinimumSize = new Size(950, 600);
                        this.MaximumSize = new Size(1550, 950);

                        //Calculating tileSize
                        if (Game.TileHeight == 0)
                        {
                            size = getTileSize(tileRowNumber, tileColumnNumber);
                            MessageBox.Show(size.ToString());

                            TileWidth = TileHeight = size;
                        }
                        //setting font and menu items
                        easyToolStripMenuItem.Checked = false;
                        mediumToolStripMenuItem.Checked = false;
                        hardToolStripMenuItem.Checked = true;
                        time.Font = new Font(time.Font.FontFamily, 12);
                        flag.Font = new Font(flag.Font.FontFamily, 12);
                        break;
                }

                mainScreen.Size = new Size(tileColumnNumber * TileWidth, tileRowNumber * TileHeight);
                previousSize = this.ClientSize;
                this.ClientSize = new Size(mainScreen.Size.Width + 2 * WidthOffset, mainScreen.Size.Height + 1 * HeightOffset
                    + miniMenu.Height);

                
                    coefWidth = (float)mainScreen.Size.Width / this.ClientSize.Width;
                    coefHeight = (float)mainScreen.Size.Height / this.ClientSize.Height;
               

                Invalidate();
            }
            else
            {
                mainScreen.Size = new Size(tileColumnNumber * TileWidth, tileRowNumber * TileHeight);
                previousSize = this.ClientSize;
                this.ClientSize = new Size(mainScreen.Size.Width + 2 * WidthOffset, mainScreen.Size.Height + 1 * HeightOffset
                    + miniMenu.Height);
                Invalidate();
            }
        }


        private void Game_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            if (fullscreen)
            {
                Brush brush = new SolidBrush(Color.DarkGoldenrod);
                Pen pen = new Pen(Color.DarkKhaki,2);

                Rectangle rectangle1 = new Rectangle(new Point(0,0), new Size(
                    (int)((ClientSize.Width - mainScreen.Width) / 4), ClientSize.Height));
                Rectangle rectangle2 = new Rectangle(new Point(ClientSize.Width-rectangle1.Width,0), new Size(
                    (int)((ClientSize.Width - mainScreen.Width) / 4), ClientSize.Height));
                graphics.FillRectangle(brush, rectangle1);
                graphics.DrawRectangle(pen, rectangle1);
                graphics.FillRectangle(brush, rectangle2);
                graphics.DrawRectangle(pen, rectangle2);
                brush.Dispose();
                pen.Dispose();
            }
        }

        public void mainScreen_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            grid.draw(graphics);
            if (hintTile != null)
            {
                Rectangle rectangle = new Rectangle(hintTile.location, new Size(Game.TileWidth, Game.TileHeight));
                graphics.FillPolygon(new SolidBrush(Color.Gold), StarPoints(5, rectangle));
            }
            
        }

        //utility for star
        private PointF[] StarPoints(int num_points, Rectangle bounds)
        {
            // Make room for the points.
            PointF[] pts = new PointF[num_points];
            double rx = bounds.Width / 2;
            double ry = bounds.Height / 2;
            double cx = bounds.X + rx;
            double cy = bounds.Y + ry;

            // Start at the top.
            double theta = -Math.PI / 2;
            double dtheta = 4 * Math.PI / num_points;
            for (int i = 0; i < num_points; i++)
            {
                pts[i] = new PointF(
                (float)(cx + rx * Math.Cos(theta)),
                (float)(cy + ry * Math.Sin(theta)));
                theta += dtheta;
            }

            return pts;
        }

            //seconds timer for seconds and idle time event trigger
            private void timer_Tick(object sender, EventArgs e)
        {
            seconds++;
            Invalidate(true);
        }


        private void idleTimer_Tick(object sender, EventArgs e)
        {
            simulationIdleEvent++;
            if (simulationIdleEvent % 5 == 0)
            {
                simulationIdleEvent = 0;
                idleTimeEvent();
            }
        }
        //showing hint if idle 5 seconds!
        private void idleTimeEvent()
        {
            hintTile = grid.getUnopened();
            Invalidate();
        }

        // BOOSTED TIMER SIMULATION
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!boosted)
            {
                simulation++;
                if (simulation % 20 == 0)
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

        //ends boost and enables timer toggle
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
            Invalidate();
        }

        //starts boost and enables timer toggle
        private void enableBoost()
        {
            button1.Hide();
            boostedLabel.Show();
            boostedLabel.Location = new Point(mainScreen.Left + mainScreen.Width / 2 - boostedLabel.Width / 2, mainScreen.Top - boostedLabel.Height-5);
            this.BackColor = Color.Orange;
            simulation = 0;
            boosted = true;
            grid.showAll();
            Invalidate();
        }

        //everything on click..
        private void mainScreen_MouseClick(object sender, MouseEventArgs e)
        {
            simulationIdleEvent = 0;
            idleTimer.Start();
            hintTile = null;
            Point clickLocation = e.Location;
            int j = (clickLocation.X) / TileWidth;
            int i = (clickLocation.Y) / TileHeight;
            if (e.Button == MouseButtons.Left)
            {
                if (grid.getFlagged(i, j))
                    return;
                int tileBefore = Game.openedTiles;
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
                
                
                if (!boosted&&Game.openedTiles>tileBefore)
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
            //question mark + flag part
            else if (e.Button == MouseButtons.Right)
            {
                if (grid.getFlagged(i, j))
                {
                    numberOfFlags++;
                    grid.questionMark(i, j);
                }
                else if (grid.getQuestionMark(i, j))
                {
                    grid.questionMark(i, j);
                }
                else
                {
                    if (boosted&&!grid.getBomb(i,j) || !boosted)
                    {
                        if (numberOfFlags == 0)
                            return;
                        grid.flag(i, j);
                        numberOfFlags--;
                    }
                }
            }

            Invalidate(true);
            idleTimer.Start();
        }

        //check to see if you've won
        private void checkWin()
        {
            
            if (openedTiles == tileColumnNumber * tileRowNumber - numberOfBombs)
            {
                timer.Stop();
                timer1.Stop();
                idleTimer.Stop();
                if (boosted)
                {
                    endBoost();
                }

                SerializeScores.checkScoresAchievs(DIFF, seconds, achievements);

                DialogResult result = MessageBox.Show("You win! Do you want to play again?", "Congratulations!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    newGame(DIFF);
                }
                else
                {
                    timer.Stop();
                    idleTimer.Stop();
                    timer1.Stop();

                    this.Close();
                }
            }
        }
        
        //end the game or run mini game
        private void endGame()
        {
            //this.Hide();
            //new form
            //
            
            timer1.Stop();
            timer.Stop();
            idleTimer.Stop();
           
            int chance = rand.Next(1, 7);
            if (secondChance || chance >= 4F) // if NOT OK, you got bomb and you lose
            {
                Lost();
            }
            else
            {
                MessageBox.Show("Oops, seems like you stepped on a bomb. But...");
                Spin spinForm = new Spin();
                if (spinForm.ShowDialog() == DialogResult.OK)
                {
                    gameEnd = false;
                    secondChance = true;
                    timer1.Start();
                    timer.Start();
                    idleTimer.Start();
                }
                else
                {
                    gameEnd = true;
                    secondChance = false;
                    Lost();
                }
            }
        }

        private void Lost()
        {
            if (boosted)
            {
                endBoost();
            }

            for (int i = 0; i < tileRowNumber; i++)
                for (int j = 0; j < tileColumnNumber; j++)
                    if (grid.mainMatrix[i][j].getBomb() && !grid.mainMatrix[i][j].getFlag())
                        grid.mainMatrix[i][j].click();
            DialogResult result = MessageBox.Show("You lost! Do you want to try again?", "Oops!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                button1.BackgroundImage = Resources.smileyDead;
                previousSize = this.ClientSize;
                newGame(DIFF);
            }
            else this.Close();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game.TileWidth = Game.TileHeight = 50;
            newGame(DIFF);
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game.TileWidth = Game.TileHeight = 50;
            if (fullscreen&&DIFF!=difficulty.EASY)
            {
                fullscreen = false;
                MaximumSize = previousMaxSize;
                FormBorderStyle = previousStyle;
                WindowState = previousState;
                Game.TileHeight = Game.TileWidth = previousTileSize;
                setScreenOptions(DIFF);
                centerTheScreen();
                grid.changeMatrix();
            }
            newGame(difficulty.EASY);
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game.TileWidth = Game.TileHeight = 50;
            if (fullscreen && DIFF != difficulty.INTERMEDIATE)
            {
                fullscreen = false;
                MaximumSize = previousMaxSize;
                FormBorderStyle = previousStyle;
                WindowState = previousState;
                Game.TileHeight = Game.TileWidth = previousTileSize;
                setScreenOptions(DIFF);
                centerTheScreen();
                grid.changeMatrix();
            }
            newGame(difficulty.INTERMEDIATE);
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game.TileWidth = Game.TileHeight = 50;
            if (fullscreen && DIFF != difficulty.HARD)
            {
                fullscreen = false;
                MaximumSize = previousMaxSize;
                FormBorderStyle = previousStyle;
                WindowState = previousState;
                Game.TileHeight = Game.TileWidth = previousTileSize;
                setScreenOptions(DIFF);
                centerTheScreen();
                grid.changeMatrix();
            }
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


        //restarting via button
        private void button1_Click(object sender, EventArgs e)
        {
            newGame(DIFF);
        }

        private void Game_ResizeBegin(object sender, EventArgs e)
        {
            if(!resizeHold)
            previousSize = this.ClientSize;
        }

        private void Game_ResizeEnd(object sender, EventArgs e)
        {
            if (previousSize != this.ClientSize&&!resizeHold)
            {
                mainScreen.Hide();
                int widthOffset = this.ClientSize.Width - previousSize.Width;
                int heightOffset = this.ClientSize.Height - previousSize.Height;
                int offset = 0;
                if (widthOffset > 0 || heightOffset > 0)
                    offset = Math.Max(widthOffset, heightOffset);
                else
                    offset = Math.Min(widthOffset, heightOffset);

                widthOffset = offset;
                heightOffset = (int)(((float)Game.tileRowNumber / Game.tileColumnNumber) * offset);

                //chaning client size
                if (offset < 0)
                {
                    this.ClientSize = new Size(Math.Max(this.MinimumSize.Width, previousSize.Width + widthOffset),
                        Math.Max(this.MinimumSize.Height, this.ClientSize.Height + heightOffset));
                }
                else
                {
                    this.ClientSize = new Size(Math.Min(this.MaximumSize.Width, previousSize.Width + widthOffset),
                        Math.Min(this.MaximumSize.Height, this.ClientSize.Height + heightOffset));
                }
                int newMainScreenWidth = (int)(coefWidth * this.ClientSize.Width);
                int newMainScreenHeight = (int)(coefHeight * this.ClientSize.Height);

                //changing tile size
                Game.TileWidth = newMainScreenWidth / Game.tileColumnNumber;
                Game.TileHeight = newMainScreenHeight / Game.tileRowNumber;
                Game.TileHeight = Game.TileWidth = Math.Min(Game.TileWidth, Game.TileHeight);
                mainScreen.Size = new Size(Game.TileWidth * Game.tileColumnNumber, Game.TileHeight * Game.tileRowNumber);


                //grid.changeMatrix();
                grid.changeMatrix();
                centerTheScreen();
                mainScreen.Show();
                this.Cursor = Cursors.Default;
                previousSize = this.ClientSize;
                Invalidate();
            }
                
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F&&!fullscreen)
            {
                previousTileSize = Game.TileHeight;
                previousMaxSize = this.MaximumSize;
                MaximumSize = new Size(SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height);
                previousState = this.WindowState;
                previousStyle = this.FormBorderStyle;
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                Game_ResizeEnd(null, null);
                fullscreen = true;
            }
            else if (e.KeyCode == Keys.Escape&&fullscreen)
            {
                fullscreen = false;
                MaximumSize = previousMaxSize;
                FormBorderStyle = previousStyle;
                WindowState = previousState;
                Game.TileHeight=Game.TileWidth = previousTileSize;
                setScreenOptions(DIFF);
                centerTheScreen();
                grid.changeMatrix();
            }
        }

        private void Game_MouseMove(object sender, MouseEventArgs e)
        {
            Point location = e.Location;
            Rectangle buttonRectangle =new  Rectangle(button1.Location, new Size(button1.Width, button1.Height));
            if (location.X >= buttonRectangle.Left && location.X <= buttonRectangle.Right
                && location.Y >= buttonRectangle.Top && location.Y <= buttonRectangle.Bottom)
            {
                button1.Enabled = true;
            }
            else
                button1.Enabled = false;
        }
    }
}
