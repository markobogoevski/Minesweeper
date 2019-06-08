namespace Minesweeper
{
    partial class Menu
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbHard = new System.Windows.Forms.RadioButton();
            this.rbEasy = new System.Windows.Forms.RadioButton();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.PictureBox();
            this.btnLeaderboards = new System.Windows.Forms.PictureBox();
            this.btnAchievments = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnQuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLeaderboards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAchievments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.btnQuit);
            this.menuPanel.Controls.Add(this.btnLeaderboards);
            this.menuPanel.Controls.Add(this.btnAchievments);
            this.menuPanel.Controls.Add(this.btnPlay);
            this.menuPanel.Controls.Add(this.button1);
            this.menuPanel.Controls.Add(this.rbMedium);
            this.menuPanel.Controls.Add(this.rbHard);
            this.menuPanel.Controls.Add(this.rbEasy);
            this.menuPanel.Controls.Add(this.lblDifficulty);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(612, 596);
            this.menuPanel.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(499, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "Spin!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(17, 64);
            this.rbMedium.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(78, 21);
            this.rbMedium.TabIndex = 11;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbHard
            // 
            this.rbHard.AutoSize = true;
            this.rbHard.Location = new System.Drawing.Point(17, 91);
            this.rbHard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbHard.Name = "rbHard";
            this.rbHard.Size = new System.Drawing.Size(60, 21);
            this.rbHard.TabIndex = 10;
            this.rbHard.Text = "Hard";
            this.rbHard.UseVisualStyleBackColor = true;
            // 
            // rbEasy
            // 
            this.rbEasy.AutoSize = true;
            this.rbEasy.Checked = true;
            this.rbEasy.Location = new System.Drawing.Point(17, 37);
            this.rbEasy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbEasy.Name = "rbEasy";
            this.rbEasy.Size = new System.Drawing.Size(60, 21);
            this.rbEasy.TabIndex = 9;
            this.rbEasy.TabStop = true;
            this.rbEasy.Text = "Easy";
            this.rbEasy.UseVisualStyleBackColor = true;
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficulty.Location = new System.Drawing.Point(12, 9);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(84, 25);
            this.lblDifficulty.TabIndex = 5;
            this.lblDifficulty.Text = "Difficulty";
            this.lblDifficulty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnQuit.Image = global::Minesweeper.Properties.Resources.btnQuitDark;
            this.btnQuit.Location = new System.Drawing.Point(183, 407);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(246, 73);
            this.btnQuit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnQuit.TabIndex = 19;
            this.btnQuit.TabStop = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            this.btnQuit.MouseEnter += new System.EventHandler(this.btnQuit_MouseEnter);
            this.btnQuit.MouseLeave += new System.EventHandler(this.btnQuit_MouseLeave);
            // 
            // btnLeaderboards
            // 
            this.btnLeaderboards.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLeaderboards.BackColor = System.Drawing.Color.Transparent;
            this.btnLeaderboards.Image = global::Minesweeper.Properties.Resources.btnLeadDark;
            this.btnLeaderboards.Location = new System.Drawing.Point(183, 318);
            this.btnLeaderboards.Name = "btnLeaderboards";
            this.btnLeaderboards.Size = new System.Drawing.Size(246, 73);
            this.btnLeaderboards.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLeaderboards.TabIndex = 18;
            this.btnLeaderboards.TabStop = false;
            this.btnLeaderboards.Click += new System.EventHandler(this.btnLeaderboards_Click);
            this.btnLeaderboards.MouseEnter += new System.EventHandler(this.btnLeaderboards_MouseEnter);
            this.btnLeaderboards.MouseLeave += new System.EventHandler(this.btnLeaderboards_MouseLeave);
            // 
            // btnAchievments
            // 
            this.btnAchievments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAchievments.BackColor = System.Drawing.Color.Transparent;
            this.btnAchievments.Image = global::Minesweeper.Properties.Resources.btnAchievDark;
            this.btnAchievments.Location = new System.Drawing.Point(183, 226);
            this.btnAchievments.Name = "btnAchievments";
            this.btnAchievments.Size = new System.Drawing.Size(246, 73);
            this.btnAchievments.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAchievments.TabIndex = 17;
            this.btnAchievments.TabStop = false;
            this.btnAchievments.Click += new System.EventHandler(this.btnAchievements_Click);
            this.btnAchievments.MouseEnter += new System.EventHandler(this.btnAchievments_MouseEnter);
            this.btnAchievments.MouseLeave += new System.EventHandler(this.btnAchievments_MouseLeave);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.Image = global::Minesweeper.Properties.Resources.btnPlayDark;
            this.btnPlay.Location = new System.Drawing.Point(183, 135);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(246, 73);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPlay.TabIndex = 16;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            this.btnPlay.MouseEnter += new System.EventHandler(this.btnPlay_MouseEnter);
            this.btnPlay.MouseLeave += new System.EventHandler(this.btnPlay_MouseLeave);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 596);
            this.Controls.Add(this.menuPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(459, 538);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnQuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLeaderboards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAchievments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbHard;
        private System.Windows.Forms.RadioButton rbEasy;
        private System.Windows.Forms.Label lblDifficulty;
        
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox btnPlay;
        private System.Windows.Forms.PictureBox btnQuit;
        private System.Windows.Forms.PictureBox btnLeaderboards;
        private System.Windows.Forms.PictureBox btnAchievments;
    }
}