namespace Minesweeper
{
    partial class Leaderboards
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
            this.lblEasyScores = new System.Windows.Forms.Label();
            this.lblEasyHeader = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageEasy = new System.Windows.Forms.TabPage();
            this.tabPageMedium = new System.Windows.Forms.TabPage();
            this.lblMediumHeader = new System.Windows.Forms.Label();
            this.lblMediumScores = new System.Windows.Forms.Label();
            this.tabPageHard = new System.Windows.Forms.TabPage();
            this.lblHardHeader = new System.Windows.Forms.Label();
            this.lblHardScores = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageEasy.SuspendLayout();
            this.tabPageMedium.SuspendLayout();
            this.tabPageHard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEasyScores
            // 
            this.lblEasyScores.AutoSize = true;
            this.lblEasyScores.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEasyScores.Location = new System.Drawing.Point(6, 35);
            this.lblEasyScores.Name = "lblEasyScores";
            this.lblEasyScores.Size = new System.Drawing.Size(70, 22);
            this.lblEasyScores.TabIndex = 0;
            this.lblEasyScores.Text = "label";
            // 
            // lblEasyHeader
            // 
            this.lblEasyHeader.AutoSize = true;
            this.lblEasyHeader.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEasyHeader.Location = new System.Drawing.Point(6, 3);
            this.lblEasyHeader.Name = "lblEasyHeader";
            this.lblEasyHeader.Size = new System.Drawing.Size(178, 22);
            this.lblEasyHeader.TabIndex = 2;
            this.lblEasyHeader.Text = "Name/Time/Date";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageEasy);
            this.tabControl1.Controls.Add(this.tabPageMedium);
            this.tabControl1.Controls.Add(this.tabPageHard);
            this.tabControl1.Location = new System.Drawing.Point(28, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(750, 352);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPageEasy
            // 
            this.tabPageEasy.AutoScroll = true;
            this.tabPageEasy.Controls.Add(this.lblEasyHeader);
            this.tabPageEasy.Controls.Add(this.lblEasyScores);
            this.tabPageEasy.Location = new System.Drawing.Point(4, 25);
            this.tabPageEasy.Name = "tabPageEasy";
            this.tabPageEasy.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEasy.Size = new System.Drawing.Size(742, 323);
            this.tabPageEasy.TabIndex = 0;
            this.tabPageEasy.Text = "Easy";
            this.tabPageEasy.UseVisualStyleBackColor = true;
            // 
            // tabPageMedium
            // 
            this.tabPageMedium.AutoScroll = true;
            this.tabPageMedium.Controls.Add(this.lblMediumHeader);
            this.tabPageMedium.Controls.Add(this.lblMediumScores);
            this.tabPageMedium.Location = new System.Drawing.Point(4, 25);
            this.tabPageMedium.Name = "tabPageMedium";
            this.tabPageMedium.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMedium.Size = new System.Drawing.Size(790, 361);
            this.tabPageMedium.TabIndex = 1;
            this.tabPageMedium.Text = "Medium";
            this.tabPageMedium.UseVisualStyleBackColor = true;
            // 
            // lblMediumHeader
            // 
            this.lblMediumHeader.AutoSize = true;
            this.lblMediumHeader.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediumHeader.Location = new System.Drawing.Point(6, 3);
            this.lblMediumHeader.Name = "lblMediumHeader";
            this.lblMediumHeader.Size = new System.Drawing.Size(178, 22);
            this.lblMediumHeader.TabIndex = 4;
            this.lblMediumHeader.Text = "Name/Time/Date";
            // 
            // lblMediumScores
            // 
            this.lblMediumScores.AutoSize = true;
            this.lblMediumScores.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediumScores.Location = new System.Drawing.Point(6, 35);
            this.lblMediumScores.Name = "lblMediumScores";
            this.lblMediumScores.Size = new System.Drawing.Size(70, 22);
            this.lblMediumScores.TabIndex = 3;
            this.lblMediumScores.Text = "label";
            // 
            // tabPageHard
            // 
            this.tabPageHard.AutoScroll = true;
            this.tabPageHard.Controls.Add(this.lblHardHeader);
            this.tabPageHard.Controls.Add(this.lblHardScores);
            this.tabPageHard.Location = new System.Drawing.Point(4, 25);
            this.tabPageHard.Name = "tabPageHard";
            this.tabPageHard.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHard.Size = new System.Drawing.Size(790, 361);
            this.tabPageHard.TabIndex = 2;
            this.tabPageHard.Text = "Hard";
            this.tabPageHard.UseVisualStyleBackColor = true;
            // 
            // lblHardHeader
            // 
            this.lblHardHeader.AutoSize = true;
            this.lblHardHeader.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHardHeader.Location = new System.Drawing.Point(6, 3);
            this.lblHardHeader.Name = "lblHardHeader";
            this.lblHardHeader.Size = new System.Drawing.Size(178, 22);
            this.lblHardHeader.TabIndex = 4;
            this.lblHardHeader.Text = "Name/Time/Date";
            // 
            // lblHardScores
            // 
            this.lblHardScores.AutoSize = true;
            this.lblHardScores.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHardScores.Location = new System.Drawing.Point(6, 35);
            this.lblHardScores.Name = "lblHardScores";
            this.lblHardScores.Size = new System.Drawing.Size(70, 22);
            this.lblHardScores.TabIndex = 3;
            this.lblHardScores.Text = "label";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(695, 408);
            this.btnBack.MaximumSize = new System.Drawing.Size(115, 32);
            this.btnBack.MinimumSize = new System.Drawing.Size(115, 32);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(115, 32);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back to Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Leaderboards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(822, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(840, 47);
            this.Name = "Leaderboards";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leaderboards";
            this.tabControl1.ResumeLayout(false);
            this.tabPageEasy.ResumeLayout(false);
            this.tabPageEasy.PerformLayout();
            this.tabPageMedium.ResumeLayout(false);
            this.tabPageMedium.PerformLayout();
            this.tabPageHard.ResumeLayout(false);
            this.tabPageHard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEasyScores;
        private System.Windows.Forms.Label lblEasyHeader;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageEasy;
        private System.Windows.Forms.TabPage tabPageMedium;
        private System.Windows.Forms.TabPage tabPageHard;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblMediumHeader;
        private System.Windows.Forms.Label lblMediumScores;
        private System.Windows.Forms.Label lblHardHeader;
        private System.Windows.Forms.Label lblHardScores;
    }
}