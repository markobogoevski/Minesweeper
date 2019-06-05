﻿namespace Minesweeper
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
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbHard = new System.Windows.Forms.RadioButton();
            this.rbEasy = new System.Windows.Forms.RadioButton();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnSkins = new System.Windows.Forms.Button();
            this.btnLeaderboards = new System.Windows.Forms.Button();
            this.btnAchievements = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.lblName);
            this.menuPanel.Controls.Add(this.tbName);
            this.menuPanel.Controls.Add(this.rbMedium);
            this.menuPanel.Controls.Add(this.rbHard);
            this.menuPanel.Controls.Add(this.rbEasy);
            this.menuPanel.Controls.Add(this.lblDifficulty);
            this.menuPanel.Controls.Add(this.btnQuit);
            this.menuPanel.Controls.Add(this.btnSkins);
            this.menuPanel.Controls.Add(this.btnLeaderboards);
            this.menuPanel.Controls.Add(this.btnAchievements);
            this.menuPanel.Controls.Add(this.btnPlay);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(682, 653);
            this.menuPanel.TabIndex = 6;
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(17, 64);
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
            this.btnQuit.Location = new System.Drawing.Point(247, 445);
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
            this.btnSkins.Location = new System.Drawing.Point(247, 393);
            this.btnSkins.Name = "btnSkins";
            this.btnSkins.Size = new System.Drawing.Size(185, 46);
            this.btnSkins.TabIndex = 3;
            this.btnSkins.Text = "Skins and Backgrounds";
            this.btnSkins.UseVisualStyleBackColor = true;
            this.btnSkins.Click += new System.EventHandler(this.btnSkins_Click);
            // 
            // btnLeaderboards
            // 
            this.btnLeaderboards.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLeaderboards.Location = new System.Drawing.Point(247, 341);
            this.btnLeaderboards.Name = "btnLeaderboards";
            this.btnLeaderboards.Size = new System.Drawing.Size(185, 46);
            this.btnLeaderboards.TabIndex = 2;
            this.btnLeaderboards.Text = "Leaderboards";
            this.btnLeaderboards.UseVisualStyleBackColor = true;
            this.btnLeaderboards.Click += new System.EventHandler(this.btnLeaderboards_Click);
            // 
            // btnAchievements
            // 
            this.btnAchievements.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAchievements.Location = new System.Drawing.Point(247, 289);
            this.btnAchievements.Name = "btnAchievements";
            this.btnAchievements.Size = new System.Drawing.Size(185, 46);
            this.btnAchievements.TabIndex = 1;
            this.btnAchievements.Text = "Achievements";
            this.btnAchievements.UseVisualStyleBackColor = true;
            this.btnAchievements.Click += new System.EventHandler(this.btnAchievements_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlay.Location = new System.Drawing.Point(247, 237);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(185, 46);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(485, 37);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(185, 30);
            this.tbName.TabIndex = 12;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(554, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(116, 25);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Your Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.menuPanel);
            this.MinimumSize = new System.Drawing.Size(460, 540);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnSkins;
        private System.Windows.Forms.Button btnLeaderboards;
        private System.Windows.Forms.Button btnAchievements;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbHard;
        private System.Windows.Forms.RadioButton rbEasy;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
    }
}