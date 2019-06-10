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
    public partial class AchievementsForm : Form
    {
        ImageWrapper skin;
        public AchievementsForm(ImageWrapper skin){
            InitializeComponent();
            this.skin = skin;
            this.BackgroundImage = Properties.Resources.background;
        }
        Point from;
        Point to;
       

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            label7.Text = "45 seconds on Easy mode";
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label7.Text = "";
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            label8.Text = "15 seconds on Easy mode";
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            label8.Text = "";
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            label9.Text = "3:30 on Medium mode";
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            label9.Text = "";
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            label10.Text = "1:30 on Medium";
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            label10.Text = "";
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            label11.Text = "7 minutes on Hard";
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            label11.Text = "";
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            label12.Text = "4 minutes on Hard";
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            label12.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            skin.image = Properties.Resources.mine;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            skin.image= Properties.Resources.baloon;
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            Image img = Properties.Resources.nuke;
            skin.image= img;
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            skin.image=Properties.Resources.poison;

        }

        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {
            skin.image=Properties.Resources.shuriken;

        }

        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            skin.image = Properties.Resources.trap;

        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            skin.image = Properties.Resources.bomb;
            from = new Point(pictureBox4.Location.X - 3, pictureBox4.Location.Y - 3);
            to = new Point(125, 105);
            Invalidate();

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            from = new Point(pictureBox1.Location.X - 3, pictureBox1.Location.Y - 3);
            to = new Point(125, 105);
            Invalidate();
        }

        private void AchievementsForm_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 1);
            e.Graphics.DrawRectangle(pen, from.X, from.Y, to.X,to.Y);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            from = new Point(0, 0);
            to = new Point(0, 0);
            Invalidate();
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            from = new Point(pictureBox2.Location.X - 3, pictureBox2.Location.Y - 3);
            to = new Point(125, 105);
            Invalidate();
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            from = new Point(pictureBox3.Location.X - 3, pictureBox3.Location.Y - 3);
            to = new Point(125, 105);
            Invalidate();
        }

        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            from = new Point(pictureBox6.Location.X - 3, pictureBox6.Location.Y - 3);
            to = new Point(125, 105);
            Invalidate();
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            from = new Point(pictureBox5.Location.X - 3, pictureBox5.Location.Y - 3);
            to = new Point(125, 105);
            Invalidate();
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            from = new Point(0, 0);
            to = new Point(0, 0);
            Invalidate();
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            from = new Point(0, 0);
            to = new Point(0, 0);
            Invalidate();
        }

        private void pictureBox6_MouseUp(object sender, MouseEventArgs e)
        {
            from = new Point(0, 0);
            to = new Point(0, 0);
            Invalidate();
        }

        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        {
            from = new Point(0, 0);
            to = new Point(0, 0);
            Invalidate();
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            from = new Point(0, 0);
            to = new Point(0, 0);
            Invalidate();
        }

        private void AchievementsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
