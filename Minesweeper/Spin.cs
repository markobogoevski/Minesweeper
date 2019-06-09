﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Spin : Form
    {
        private static Random rand = new Random();
        List<Image> spinImages;
        List<string> spinDescriptions;
        public Image award;
        PictureBox[] pictureBoxes;
        int spins;
        int count;
        int[] rotateAngles;

        public Spin(){
            InitializeComponent();
            this.DoubleBuffered = true;

            spinImages = new List<Image>();
            //if (listaLockedAchievements.Count >= 5) // ako se >=5 zemi gi prvite 5
            //    for (int i = 0; i < 5; i++)
            //        spinImages.Add(listaLockedAchievements[i]);
            //else {                                  // ako ne, povtoruvaj gi istit dodeka ne bidat 5
            //    while (spinImages.Count != 5) { 
            //        foreach (var item in listaLockedAchievements){
            //            spinImages.Add(item);
            //            if (spinImages.Count == 5) break;
            //        }
            //    }
            //}
            spinDescriptions = new List<string>();
            spinDescriptions.Add("Bomb");
            spinDescriptions.Add("Nuke");
            spinDescriptions.Add("Shuriken");
            spinDescriptions.Add("Trap");
            spinDescriptions.Add("Poison");
            spinDescriptions.Add("Heart");

            this.BackgroundImage = Properties.Resources.background;

            spinImages.Add(Properties.Resources.bomb);
            spinImages.Add(Properties.Resources.nuke);
            spinImages.Add(Properties.Resources.shuriken);
            spinImages.Add(Properties.Resources.trap);
            spinImages.Add(Properties.Resources.poison);
            spinImages.Add(Properties.Resources.heart); // posleden achievement e extra life
            
            pictureBoxes = new PictureBox[6];
            Point[] locations = new Point[6];
            rotateAngles = new int[6];

            rotateAngles[0] = 0;
            rotateAngles[1] = 325;
            rotateAngles[2] = 225;
            rotateAngles[3] = 180;
            rotateAngles[4] = 135;
            rotateAngles[5] = 45;
            locations[0] = new Point(195, 115); // locations za Pictureboxes
            locations[1] = new Point(117, 185);
            locations[2] = new Point(117, 260);
            locations[3] = new Point(195, 320);
            locations[4] = new Point(270, 260);
            locations[5] = new Point(270, 185);
            pictureBoxes[0] = pictureBox1;
            pictureBoxes[1] = pictureBox2;
            pictureBoxes[2] = pictureBox3;
            pictureBoxes[3] = pictureBox4;
            pictureBoxes[4] = pictureBox5;
            pictureBoxes[5] = pictureBox6;
            for (int i = 0; i < pictureBoxes.Count(); i++){
                pictureBoxes[i].SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxes[i].Size = new Size(60, 60);
                pictureBoxes[i].Location = locations[i];
                Bitmap bmp = new Bitmap(spinImages[i]);
                bmp = RotateBitmap(bmp, rotateAngles[i]);
                pictureBoxes[i].Image = bmp;
            }
            Invalidate();
        }
        

        private void spin() {
            spinImages.Add(spinImages[0]); // prvata se dodava posledna i se brishe [0]
            spinImages.RemoveAt(0);
            spinDescriptions.Add(spinDescriptions[0]);
            spinDescriptions.RemoveAt(0);

            //sekoja slika ja rotiram i ja stavam vo soodvetniot Picturebox
            for (int i = 0; i < pictureBoxes.Count(); i++)
            {
                Bitmap bmp = new Bitmap(spinImages[i]);
                bmp = RotateBitmap(bmp, rotateAngles[i]);
                pictureBoxes[i].Image = bmp;
            }
        }

        
        private void Spin_Paint(object sender, PaintEventArgs e){
            Pen pen = new Pen(Color.Black, 3);
            e.Graphics.DrawPie(pen, 100, 100, 250, 300, -60, -60);
            e.Graphics.DrawPie(pen, 100, 100, 250, 300, -120, -60);
            e.Graphics.DrawPie(pen, 100, 100, 250, 300, -180, -60);
            e.Graphics.DrawPie(pen, 100, 100, 250, 300, -240, -60);
            e.Graphics.DrawPie(pen, 100, 100, 250, 300, -360, -60);
            e.Graphics.DrawPie(pen, 100, 100, 250, 300, 0, 60);
            Brush b = new SolidBrush(Color.Black);
            PointF[] triangle = new PointF[3];
            triangle[0]= new PointF(210, 60); // triagolnikot od gore
            triangle[1]= new PointF(230, 60);
            triangle[2]= new PointF(220, 75);
            e.Graphics.FillPolygon(b, triangle);
            b.Dispose();
            pen.Dispose();
        }

        private void Timer1_Tick(object sender, EventArgs e){
            if (count == spins+1){
                timer1.Stop();
                Image awardWon = returnAward();
                AwardAccept awardForm;
                if (awardWon.Equals(Properties.Resources.heart))
                {
                     awardForm = new AwardAccept("get another Chance", awardWon);
                }else awardForm = new AwardAccept("LOSE", awardWon);
                /*
                 TODO : If extra life ....., If achievement , achievement.Unlock();
                 */
                awardForm.Location = new Point(800, 800);
                awardForm.Show(); 
                this.Close();
                // da se vrati nultiot element 
            }
            this.count++;
            spin();
            timer1.Interval = timer1.Interval +30;  
            Invalidate();
        }

        public Image returnAward(){
            this.award = spinImages[0];
            return spinImages[0];
        }

        private void Button1_Click(object sender, EventArgs e){
            this.spins = rand.Next(4,25);
            this.count = 0;
            timer1.Start();
            button1.Enabled = false;
        }


        private Bitmap RotateBitmap(Bitmap bm, float angle)
        {
            // Make a Matrix to represent rotation by this angle.
            Matrix rotate_at_origin = new Matrix();
            rotate_at_origin.Rotate(angle);

            // Rotate the image's corners to see how big
            // it will be after rotation.
            PointF[] points =
            {
                new PointF(0, 0),
                new PointF(bm.Width, 0),
                new PointF(bm.Width, bm.Height),
                new PointF(0, bm.Height),
            };
            rotate_at_origin.TransformPoints(points);
            float xmin, xmax, ymin, ymax;
            GetPointBounds(points, out xmin, out xmax, out ymin, out ymax);

            // Make a bitmap to hold the rotated result.
            int wid = (int)Math.Round(xmax - xmin);
            int hgt = (int)Math.Round(ymax - ymin);
            Bitmap result = new Bitmap(wid, hgt);

            // Create the real rotation transformation.
            Matrix rotate_at_center = new Matrix();
            rotate_at_center.RotateAt(angle,
                new PointF(wid / 2f, hgt / 2f));

            // Draw the image onto the new bitmap rotated.
            using (Graphics gr = Graphics.FromImage(result))
            {
                // Use smooth image interpolation.
                gr.InterpolationMode = InterpolationMode.High;

                // Clear with the color in the image's upper left corner.
                gr.Clear(bm.GetPixel(0, 0));

                //// For debugging. (Makes it easier to see the background.)
                //gr.Clear(Color.LightBlue);

                // Set up the transformation to rotate.
                gr.Transform = rotate_at_center;

                // Draw the image centered on the bitmap.
                int x = (wid - bm.Width) / 2;
                int y = (hgt - bm.Height) / 2;
                gr.DrawImage(bm, x, y);
            }

            // Return the result bitmap.
            return result;
        }

        private void GetPointBounds(PointF[] points, out float xmin, out float xmax, out float ymin, out float ymax)
        {
            xmin = points[0].X;
            xmax = xmin;
            ymin = points[0].Y;
            ymax = ymin;
            foreach (PointF point in points)
            {
                if (xmin > point.X) xmin = point.X;
                if (xmax < point.X) xmax = point.X;
                if (ymin > point.Y) ymin = point.Y;
                if (ymax < point.Y) ymax = point.Y;
            }
        }

        private void Spin_Load(object sender, EventArgs e){}
    }
    
}