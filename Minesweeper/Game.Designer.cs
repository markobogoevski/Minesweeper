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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.miniMenu = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.leaderboardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseDifficultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.enterFullscreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flag = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.boostedLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mainScreen = new System.Windows.Forms.PictureBox();
            this.idleTimer = new System.Windows.Forms.Timer(this.components);
            this.miniMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // miniMenu
            // 
            this.miniMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.miniMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.miniMenu.Location = new System.Drawing.Point(0, 0);
            this.miniMenu.Name = "miniMenu";
            this.miniMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.miniMenu.Size = new System.Drawing.Size(1147, 28);
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
            this.toolStripSeparator3,
            this.enterFullscreenToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(259, 6);
            // 
            // leaderboardsToolStripMenuItem
            // 
            this.leaderboardsToolStripMenuItem.Name = "leaderboardsToolStripMenuItem";
            this.leaderboardsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.leaderboardsToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.leaderboardsToolStripMenuItem.Text = "Leaderboards";
            this.leaderboardsToolStripMenuItem.Click += new System.EventHandler(this.leaderboardsToolStripMenuItem_Click);
            // 
            // chooseDifficultyToolStripMenuItem
            // 
            this.chooseDifficultyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.hardToolStripMenuItem});
            this.chooseDifficultyToolStripMenuItem.Name = "chooseDifficultyToolStripMenuItem";
            this.chooseDifficultyToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.chooseDifficultyToolStripMenuItem.Text = "Choose difficulty";
            // 
            // easyToolStripMenuItem
            // 
            this.easyToolStripMenuItem.Checked = true;
            this.easyToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            this.easyToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.easyToolStripMenuItem.Text = "Easy";
            this.easyToolStripMenuItem.Click += new System.EventHandler(this.easyToolStripMenuItem_Click);
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.mediumToolStripMenuItem.Text = "Medium";
            this.mediumToolStripMenuItem.Click += new System.EventHandler(this.mediumToolStripMenuItem_Click);
            // 
            // hardToolStripMenuItem
            // 
            this.hardToolStripMenuItem.Name = "hardToolStripMenuItem";
            this.hardToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.hardToolStripMenuItem.Text = "Hard";
            this.hardToolStripMenuItem.Click += new System.EventHandler(this.hardToolStripMenuItem_Click);
            // 
            // backToMainMenuToolStripMenuItem
            // 
            this.backToMainMenuToolStripMenuItem.Name = "backToMainMenuToolStripMenuItem";
            this.backToMainMenuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.backToMainMenuToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.backToMainMenuToolStripMenuItem.Text = "Back to main menu";
            this.backToMainMenuToolStripMenuItem.Click += new System.EventHandler(this.backToMainMenuToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(259, 6);
            // 
            // enterFullscreenToolStripMenuItem
            // 
            this.enterFullscreenToolStripMenuItem.Name = "enterFullscreenToolStripMenuItem";
            this.enterFullscreenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.enterFullscreenToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.enterFullscreenToolStripMenuItem.Text = "Toggle full-screen";
            this.enterFullscreenToolStripMenuItem.Click += new System.EventHandler(this.enterFullscreenToolStripMenuItem_Click);
            // 
            // flag
            // 
            this.flag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flag.BackColor = System.Drawing.Color.Transparent;
            this.flag.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flag.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.flag.Location = new System.Drawing.Point(939, 114);
            this.flag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.flag.Name = "flag";
            this.flag.Size = new System.Drawing.Size(147, 41);
            this.flag.TabIndex = 4;
            this.flag.Text = "Flags: 00";
            this.flag.Paint += new System.Windows.Forms.PaintEventHandler(this.flag_Paint);
            // 
            // time
            // 
            this.time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.time.Location = new System.Drawing.Point(67, 114);
            this.time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(183, 41);
            this.time.TabIndex = 2;
            this.time.Text = "Time: 00";
            this.time.Paint += new System.Windows.Forms.PaintEventHandler(this.time_Paint);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // boostedLabel
            // 
            this.boostedLabel.AutoSize = true;
            this.boostedLabel.BackColor = System.Drawing.Color.Transparent;
            this.boostedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boostedLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.boostedLabel.Location = new System.Drawing.Point(459, 30);
            this.boostedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.boostedLabel.Name = "boostedLabel";
            this.boostedLabel.Size = new System.Drawing.Size(191, 39);
            this.boostedLabel.TabIndex = 5;
            this.boostedLabel.Text = "BOOSTED";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Minesweeper.Properties.Resources.smileyHappy;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(527, 33);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 58);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainScreen
            // 
            this.mainScreen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainScreen.Location = new System.Drawing.Point(67, 159);
            this.mainScreen.Margin = new System.Windows.Forms.Padding(4);
            this.mainScreen.Name = "mainScreen";
            this.mainScreen.Size = new System.Drawing.Size(830, 562);
            this.mainScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mainScreen.TabIndex = 0;
            this.mainScreen.TabStop = false;
            this.mainScreen.Paint += new System.Windows.Forms.PaintEventHandler(this.mainScreen_Paint);
            this.mainScreen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainScreen_MouseClick);
            // 
            // idleTimer
            // 
            this.idleTimer.Enabled = true;
            this.idleTimer.Interval = 1000;
            this.idleTimer.Tick += new System.EventHandler(this.idleTimer_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Minesweeper.Properties.Resources.back1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1147, 820);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.boostedLabel);
            this.Controls.Add(this.flag);
            this.Controls.Add(this.time);
            this.Controls.Add(this.mainScreen);
            this.Controls.Add(this.miniMenu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.miniMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2126, 1217);
            this.MinimumSize = new System.Drawing.Size(618, 609);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minesweeper";
            this.ResizeBegin += new System.EventHandler(this.Game_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.Game_ResizeEnd);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Game_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Game_MouseMove);
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
        private System.Windows.Forms.Label flag;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox mainScreen;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label boostedLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer idleTimer;
        private System.Windows.Forms.ToolStripMenuItem enterFullscreenToolStripMenuItem;
    }
}

