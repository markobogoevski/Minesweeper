namespace Minesweeper
{
    partial class Form1
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
            this.mainScreen = new System.Windows.Forms.PictureBox();
            this.miniMenu = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.leaderboardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseDifficultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soundOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.time = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.flag = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainScreen)).BeginInit();
            this.miniMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainScreen
            // 
            this.mainScreen.Location = new System.Drawing.Point(12, 77);
            this.mainScreen.Name = "mainScreen";
            this.mainScreen.Size = new System.Drawing.Size(830, 562);
            this.mainScreen.TabIndex = 0;
            this.mainScreen.TabStop = false;
            this.mainScreen.Paint += new System.Windows.Forms.PaintEventHandler(this.mainScreen_Paint);
            this.mainScreen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainScreen_MouseClick);
            // 
            // miniMenu
            // 
            this.miniMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.miniMenu.Location = new System.Drawing.Point(0, 0);
            this.miniMenu.Name = "miniMenu";
            this.miniMenu.Size = new System.Drawing.Size(854, 24);
            this.miniMenu.TabIndex = 1;
            this.miniMenu.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetGameToolStripMenuItem,
            this.newGameToolStripMenuItem,
            this.toolStripSeparator1,
            this.leaderboardsToolStripMenuItem,
            this.chooseDifficultyToolStripMenuItem,
            this.backToMainMenuToolStripMenuItem,
            this.toolStripSeparator3});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // resetGameToolStripMenuItem
            // 
            this.resetGameToolStripMenuItem.Name = "resetGameToolStripMenuItem";
            this.resetGameToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.resetGameToolStripMenuItem.Text = "Reset game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(174, 6);
            // 
            // leaderboardsToolStripMenuItem
            // 
            this.leaderboardsToolStripMenuItem.Name = "leaderboardsToolStripMenuItem";
            this.leaderboardsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.leaderboardsToolStripMenuItem.Text = "Leaderboards";
            // 
            // chooseDifficultyToolStripMenuItem
            // 
            this.chooseDifficultyToolStripMenuItem.Name = "chooseDifficultyToolStripMenuItem";
            this.chooseDifficultyToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.chooseDifficultyToolStripMenuItem.Text = "Choose difficulty";
            // 
            // backToMainMenuToolStripMenuItem
            // 
            this.backToMainMenuToolStripMenuItem.Name = "backToMainMenuToolStripMenuItem";
            this.backToMainMenuToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.backToMainMenuToolStripMenuItem.Text = "Back to main menu";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(174, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowSizeToolStripMenuItem,
            this.soundOptionsToolStripMenuItem,
            this.toolStripSeparator2});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // windowSizeToolStripMenuItem
            // 
            this.windowSizeToolStripMenuItem.Name = "windowSizeToolStripMenuItem";
            this.windowSizeToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.windowSizeToolStripMenuItem.Text = "Window size";
            // 
            // soundOptionsToolStripMenuItem
            // 
            this.soundOptionsToolStripMenuItem.Name = "soundOptionsToolStripMenuItem";
            this.soundOptionsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.soundOptionsToolStripMenuItem.Text = "Sound options";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(148, 6);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(12, 41);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(129, 33);
            this.time.TabIndex = 2;
            this.time.Text = "Time : 0";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // flag
            // 
            this.flag.AutoSize = true;
            this.flag.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flag.Location = new System.Drawing.Point(706, 41);
            this.flag.Name = "flag";
            this.flag.Size = new System.Drawing.Size(136, 33);
            this.flag.TabIndex = 4;
            this.flag.Text = "Flags : 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 651);
            this.Controls.Add(this.flag);
            this.Controls.Add(this.time);
            this.Controls.Add(this.mainScreen);
            this.Controls.Add(this.miniMenu);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.miniMenu;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mainScreen)).EndInit();
            this.miniMenu.ResumeLayout(false);
            this.miniMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainScreen;
        private System.Windows.Forms.MenuStrip miniMenu;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soundOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem leaderboardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseDifficultyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToMainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label flag;
    }
}

