using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;

using System.Windows.Forms;

namespace Minesweeper
{
    public partial class AchievementsForm : Form
    {
        ImageWrapper skin;
        List<Achievement> achievements;
        PictureBox[] boxes;
        Button Back;
        bool click;
        Rectangle selected;
        public AchievementsForm(ImageWrapper skin, List<Achievement>achievements){
            InitializeComponent();
            this.DoubleBuffered = true;
            click = false;
            this.skin = skin;
            this.achievements = achievements;
            this.BackgroundImage = Properties.Resources.background;
            pictureBox7.Image = Properties.Resources.mine;
            Back = new Button(new Point(400, 450), Properties.Resources.btnBackDark, Properties.Resources.btnBackLight, 125, 59);

            boxes = new PictureBox[6];
            boxes[0] = pictureBox1;
            boxes[1] = pictureBox2;
            boxes[2] = pictureBox3;
            boxes[3] = pictureBox6;
            boxes[4] = pictureBox5;
            boxes[5] = pictureBox4;
            
            for (int i = 0; i < 6; i++) { 
                boxes[i].Image = achievements[i].getImage(); // se zima lock ili unlock image
            }

            //mora hard-kodirano
            pictureBox1.Image.Tag = "Baloon";
            pictureBox2.Image.Tag = "Nuke";
            pictureBox3.Image.Tag = "Poison";
            pictureBox6.Image.Tag = "Bomb";
            pictureBox5.Image.Tag = "Trap";
            pictureBox4.Image.Tag = "Shuriken";

            Point a = new Point(pictureBox7.Location.X - 10, pictureBox7.Location.Y - 7);
            Size b = new Size(120, 125);
            selected = new Rectangle(a, b);//selected e pravoagolnikot sho kazuva so koj skin igrame
            for (int i = 0; i < 6; i++){
                if ((string)boxes[i].Image.Tag == (string)skin.image.Tag){ // ja naogjam bombata sho ja koristi i ja "selektiram"
                    a = new Point(boxes[i].Location.X - 10, boxes[i].Location.Y - 7);
                    b = new Size(120, 125);
                    selected = new Rectangle(a, b);
                }
            }
           
            Invalidate();
        }
        Point from;
        Point to;
       

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            label7.Text = "45 seconds on Easy";
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label7.Text = "";
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            label8.Text = "15 seconds on Easy";
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            label8.Text = "";
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            label9.Text = "4 minutes on Medium";
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            label9.Text = "";
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            label10.Text = "2 minutes on Medium";
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            label10.Text = "";
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            label11.Text = "10 minutes on Hard";
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            label11.Text = "";
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            label12.Text = "8 minutes on Hard";
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            label12.Text = "";
        }
              
        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            if (achievements[5].iSUnlocked())
            {
                click = true;
                from = new Point(pictureBox4.Location.X - 10, pictureBox4.Location.Y - 7);
                to = new Point(130, 125);
                Invalidate();
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (achievements[0].iSUnlocked())
            {
                click = true;
                from = new Point(pictureBox1.Location.X - 10, pictureBox1.Location.Y - 7);
                to = new Point(130, 125);
                Invalidate();
            }
        }
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (achievements[1].iSUnlocked())
            {
                click = true;
                from = new Point(pictureBox2.Location.X - 10, pictureBox2.Location.Y - 7);
                to = new Point(130, 125);
                Invalidate();
            }
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            if (achievements[2].iSUnlocked())
            {
                click = true;
                from = new Point(pictureBox3.Location.X - 10, pictureBox3.Location.Y - 7);
                to = new Point(130, 125);
                Invalidate();
            }
        }

        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            if (achievements[3].iSUnlocked())
            {
                click = true;
                from = new Point(pictureBox6.Location.X - 10, pictureBox6.Location.Y - 7);
                to = new Point(130, 125);
                Invalidate();
            }
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            if (achievements[4].iSUnlocked())
            {
                click = true;
                from = new Point(pictureBox5.Location.X - 10, pictureBox5.Location.Y - 7);
                to = new Point(130, 125);
                Invalidate();
            }
        }
  
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            from = new Point(0, 0);
            to = new Point(0, 0);
            click = false;
            Invalidate();
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            from = new Point(0, 0);
            to = new Point(0, 0);
            click = false;
            Invalidate();
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            from = new Point(0, 0);
            to = new Point(0, 0);
            click = false;
            Invalidate();
        }

        private void pictureBox6_MouseUp(object sender, MouseEventArgs e)
        {
            from = new Point(0, 0);
            to = new Point(0, 0);
            click = false;
            Invalidate();
        }

        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        {
            from = new Point(0, 0);
            to = new Point(0, 0);
            click = false;
            Invalidate();
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            from = new Point(0, 0);
            to = new Point(0, 0);
            click = false;
            Invalidate();
        }
  
        public GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            // top left arc  
            path.AddArc(arc, 180, 90);

            // top right arc  
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // bottom right arc  
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // bottom left arc 
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (achievements[0].iSUnlocked())
            {
                skin.image = achievements[0].getImage();
                from = new Point(pictureBox1.Location.X - 10, pictureBox1.Location.Y - 7);
                selected.Location = from;

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (achievements[1].iSUnlocked())
            {
                skin.image = achievements[1].getImage();
                from = new Point(pictureBox2.Location.X - 10, pictureBox2.Location.Y - 7);
                selected.Location = from;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (achievements[2].iSUnlocked())
            {
                skin.image = achievements[2].getImage();
                from = new Point(pictureBox3.Location.X - 10, pictureBox3.Location.Y - 7);
                selected.Location = from;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (achievements[5].iSUnlocked())
            {
                skin.image = achievements[5].getImage();
                from = new Point(pictureBox4.Location.X - 10, pictureBox4.Location.Y - 7);
                selected.Location = from;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (achievements[4].iSUnlocked())
            {
                skin.image = achievements[4].getImage();
                from = new Point(pictureBox5.Location.X - 10, pictureBox5.Location.Y - 7);
                selected.Location = from;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (achievements[3].iSUnlocked())
            {
                skin.image = achievements[3].getImage();
                from = new Point(pictureBox6.Location.X - 10, pictureBox6.Location.Y - 7);
                selected.Location = from;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Image mine = Properties.Resources.mine;
            mine.Tag = "Mine";
            skin.image = mine;
            from = new Point(pictureBox7.Location.X - 10, pictureBox7.Location.Y - 7);
            selected.Location = from;
        }
    
        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            click = true;
            from = new Point(pictureBox7.Location.X - 10, pictureBox7.Location.Y - 7);
            to = new Point(130, 125);
            Invalidate();
        }

        private void pictureBox7_MouseUp(object sender, MouseEventArgs e)
        {
            from = new Point(0, 0);
            to = new Point(0, 0);
            click = false;
            Invalidate();
        }
        private void AchievementsForm_Paint(object sender, PaintEventArgs e)
        {
            Back.Draw(e.Graphics);
            Pen pen = new Pen(Color.PeachPuff, 3);
            Rectangle rect = new Rectangle(from.X, from.Y, to.X-10, to.Y);
            Pen markedPen = new Pen(Color.Peru, 4);
            GraphicsPath path;
            if (click) //mouse down go setira click na true
            {
                path = RoundedRect(rect, 20); // zaoblen rectangle
                e.Graphics.DrawPath(pen, path);
            }
            path = RoundedRect(selected, 20);
            e.Graphics.DrawPath(markedPen, path);
            pen.Dispose();
            markedPen.Dispose();
        }

        private void AchievementsForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (Back.Hit) this.Close();
        }

        private void AchievementsForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (Back.Hit) Back.Clicked = true;
        }

        private void AchievementsForm_MouseUp(object sender, MouseEventArgs e)
        {
            Back.Clicked = false;
        }

        private void AchievementsForm_MouseMove(object sender, MouseEventArgs e)
        {
            Back.isHit(e.X, e.Y);
            Invalidate();
        }
    }
}
