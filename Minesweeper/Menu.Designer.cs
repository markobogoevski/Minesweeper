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
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnSkins = new System.Windows.Forms.Button();
            this.btnLeaderboards = new System.Windows.Forms.Button();
            this.btnAchievements = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.btnQuit);
            this.menuPanel.Controls.Add(this.btnSkins);
            this.menuPanel.Controls.Add(this.btnLeaderboards);
            this.menuPanel.Controls.Add(this.btnAchievements);
            this.menuPanel.Controls.Add(this.btnPlay);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(464, 521);
            this.menuPanel.TabIndex = 6;
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuit.Location = new System.Drawing.Point(141, 360);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(185, 46);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnSkins
            // 
            this.btnSkins.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSkins.Location = new System.Drawing.Point(141, 299);
            this.btnSkins.Name = "btnSkins";
            this.btnSkins.Size = new System.Drawing.Size(185, 46);
            this.btnSkins.TabIndex = 3;
            this.btnSkins.Text = "Skins and Backgrounds";
            this.btnSkins.UseVisualStyleBackColor = true;
            // 
            // btnLeaderboards
            // 
            this.btnLeaderboards.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLeaderboards.Location = new System.Drawing.Point(141, 236);
            this.btnLeaderboards.Name = "btnLeaderboards";
            this.btnLeaderboards.Size = new System.Drawing.Size(185, 46);
            this.btnLeaderboards.TabIndex = 2;
            this.btnLeaderboards.Text = "Leaderboards";
            this.btnLeaderboards.UseVisualStyleBackColor = true;
            // 
            // btnAchievements
            // 
            this.btnAchievements.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAchievements.Location = new System.Drawing.Point(141, 176);
            this.btnAchievements.Name = "btnAchievements";
            this.btnAchievements.Size = new System.Drawing.Size(185, 46);
            this.btnAchievements.TabIndex = 1;
            this.btnAchievements.Text = "Achievements";
            this.btnAchievements.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlay.Location = new System.Drawing.Point(141, 111);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(185, 46);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 521);
            this.Controls.Add(this.menuPanel);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnSkins;
        private System.Windows.Forms.Button btnLeaderboards;
        private System.Windows.Forms.Button btnAchievements;
        private System.Windows.Forms.Button btnPlay;
    }
}