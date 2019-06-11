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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leaderboards));
            this.lblDiff = new System.Windows.Forms.Label();
            this.lblScores = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDiff
            // 
            this.lblDiff.AutoSize = true;
            this.lblDiff.BackColor = System.Drawing.Color.Transparent;
            this.lblDiff.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiff.ForeColor = System.Drawing.SystemColors.Info;
            this.lblDiff.Location = new System.Drawing.Point(12, 9);
            this.lblDiff.Name = "lblDiff";
            this.lblDiff.Size = new System.Drawing.Size(152, 27);
            this.lblDiff.TabIndex = 6;
            this.lblDiff.Text = "Difficulty";
            // 
            // lblScores
            // 
            this.lblScores.AutoSize = true;
            this.lblScores.BackColor = System.Drawing.Color.Transparent;
            this.lblScores.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScores.ForeColor = System.Drawing.SystemColors.Info;
            this.lblScores.Location = new System.Drawing.Point(12, 88);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(82, 22);
            this.lblScores.TabIndex = 7;
            this.lblScores.Text = "Scores";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.Info;
            this.lblHeader.Location = new System.Drawing.Point(12, 51);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(82, 22);
            this.lblHeader.TabIndex = 8;
            this.lblHeader.Text = "Header";
            // 
            // Leaderboards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(843, 339);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblScores);
            this.Controls.Add(this.lblDiff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(840, 47);
            this.Name = "Leaderboards";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leaderboards";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Leaderboards_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Lead_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Lead_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Lead_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Lead_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDiff;
        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.Label lblHeader;
    }
}