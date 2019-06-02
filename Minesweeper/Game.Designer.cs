namespace Minesweeper
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.miniMenu = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.leaderboardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseDifficultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flag = new System.Windows.Forms.Label();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soundOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.time = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.mainScreen = new System.Windows.Forms.PictureBox();
            this.miniMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // miniMenu
            // 
            this.miniMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.miniMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.miniMenu.Location = new System.Drawing.Point(0, 0);
            this.miniMenu.Name = "miniMenu";
            this.miniMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.miniMenu.Size = new System.Drawing.Size(1143, 28);
            this.miniMenu.TabIndex = 1;
            this.miniMenu.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.toolStripSeparator1,
            this.leaderboardsToolStripMenuItem,
            this.chooseDifficultyToolStripMenuItem,
            this.backToMainMenuToolStripMenuItem,
            this.toolStripSeparator3});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
            // 
            // leaderboardsToolStripMenuItem
            // 
            this.leaderboardsToolStripMenuItem.Name = "leaderboardsToolStripMenuItem";
            this.leaderboardsToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.leaderboardsToolStripMenuItem.Text = "Leaderboards";
            // 
            // hardToolStripMenuItem
            // 
            this.hardToolStripMenuItem.Name = "hardToolStripMenuItem";
            this.hardToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.hardToolStripMenuItem.Text = "Hard";
            this.hardToolStripMenuItem.Click += new System.EventHandler(this.hardToolStripMenuItem_Click);
            // 
            // chooseDifficultyToolStripMenuItem
            // 
            this.chooseDifficultyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.hardToolStripMenuItem});
            this.chooseDifficultyToolStripMenuItem.Name = "chooseDifficultyToolStripMenuItem";
            this.chooseDifficultyToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.chooseDifficultyToolStripMenuItem.Text = "Choose difficulty";
            // 
            // easyToolStripMenuItem
            // 
            this.easyToolStripMenuItem.Checked = true;
            this.easyToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            this.easyToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.easyToolStripMenuItem.Text = "Easy";
            this.easyToolStripMenuItem.Click += new System.EventHandler(this.easyToolStripMenuItem_Click);
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.mediumToolStripMenuItem.Text = "Medium";
            this.mediumToolStripMenuItem.Click += new System.EventHandler(this.mediumToolStripMenuItem_Click);
            // 
            // backToMainMenuToolStripMenuItem
            // 
            this.backToMainMenuToolStripMenuItem.Name = "backToMainMenuToolStripMenuItem";
            this.backToMainMenuToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.backToMainMenuToolStripMenuItem.Text = "Back to main menu";
            this.backToMainMenuToolStripMenuItem.Click += new System.EventHandler(this.backToMainMenuToolStripMenuItem_Click);
            // 
            // flag
            // 
            this.flag.AutoSize = true;
            this.flag.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flag.Location = new System.Drawing.Point(941, 50);
            this.flag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.flag.Name = "flag";
            this.flag.Size = new System.Drawing.Size(159, 42);
            this.flag.TabIndex = 4;
            this.flag.Text = "Flags: 0";
            this.flag.Paint += new System.Windows.Forms.PaintEventHandler(this.flag_Paint);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(213, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowSizeToolStripMenuItem,
            this.soundOptionsToolStripMenuItem,
            this.toolStripSeparator2});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // windowSizeToolStripMenuItem
            // 
            this.windowSizeToolStripMenuItem.Name = "windowSizeToolStripMenuItem";
            this.windowSizeToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.windowSizeToolStripMenuItem.Text = "Window size";
            // 
            // soundOptionsToolStripMenuItem
            // 
            this.soundOptionsToolStripMenuItem.Name = "soundOptionsToolStripMenuItem";
            this.soundOptionsToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.soundOptionsToolStripMenuItem.Text = "Sound options";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(213, 6);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(16, 50);
            this.time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(170, 42);
            this.time.TabIndex = 2;
            this.time.Text = "Time: 00";
            this.time.Paint += new System.Windows.Forms.PaintEventHandler(this.time_Paint);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // mainScreen
            // 
            this.mainScreen.Location = new System.Drawing.Point(16, 95);
            this.mainScreen.Margin = new System.Windows.Forms.Padding(4);
            this.mainScreen.Name = "mainScreen";
            this.mainScreen.Size = new System.Drawing.Size(1107, 692);
            this.mainScreen.TabIndex = 0;
            this.mainScreen.TabStop = false;
            this.mainScreen.Paint += new System.Windows.Forms.PaintEventHandler(this.mainScreen_Paint);
            this.mainScreen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainScreen_MouseClick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 804);
            this.Controls.Add(this.flag);
            this.Controls.Add(this.time);
            this.Controls.Add(this.mainScreen);
            this.Controls.Add(this.miniMenu);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.miniMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minesweeper";
            this.miniMenu.ResumeLayout(false);
            this.miniMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip miniMenu;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem leaderboardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseDifficultyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToMainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soundOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label flag;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox mainScreen;
    }
}

