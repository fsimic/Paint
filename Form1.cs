using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing.Drawing2D;
using System.Runtime.Serialization.Formatters.Binary;

namespace PaintProjectWFAproba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);     
        }


        Graphics g;
        Bitmap bmp;
      
        int x1, x2, y1, y2;          
      
        bool canPaint = false;
      

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if(drawSquare == false && drawElipse == false && drawEmptyElipse == false && drawEmptySquare == false)
                canPaint = true;
            
            if(drawSquare)
            {
                canPaint = false;
                x1 = e.X;
                y1 = e.Y;
            }
            if (drawElipse)
            {
                canPaint = false;
                x1 = e.X;
                y1 = e.Y;
            }
            if (drawEmptySquare)
            {
                canPaint = false;
                x1 = e.X;
                y1 = e.Y;
            }
            if (drawEmptyElipse)
            {
                canPaint = false;
                x1 = e.X;
                y1 = e.Y;
            }
            
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (canPaint)
            {
                canPaint = false;
                oldX = null;
                oldY = null;
            }

            if (drawSquare)
            {
                x2 = e.X;
                y2 = e.Y;

                g = Graphics.FromImage(bmp);

                SolidBrush sb = new SolidBrush(boja.BackColor);
                g.FillRectangle(sb, x1, y1, x2 - x1, y2 - y1);
                pictureBox1.Image = bmp;

                drawSquare = false;
            }

            if (drawElipse)
            {
                x2 = e.X;
                y2 = e.Y;


                g = Graphics.FromImage(bmp);

                SolidBrush sb = new SolidBrush(boja.BackColor);
                g.FillEllipse(sb, x1, y1, x2 - x1, y2 - y1);
              //  Pen p = new Pen(boja.BackColor, float.Parse(debljina.Text));
             //   g.DrawEllipse(p, x1, y1, x2 - x1, y2 - y1);
                pictureBox1.Image = bmp; //kopira iz bitmapa u picturebox

                drawElipse = false;
            }

            if (drawEmptySquare)
            {
                x2 = e.X;
                y2 = e.Y;

                g = Graphics.FromImage(bmp);

                Pen p = new Pen(boja.BackColor, float.Parse(debljina.Text));
                g.DrawRectangle(p, x1, y1, x2 - x1, y2 - y1);
                pictureBox1.Image = bmp;

                drawEmptySquare = false;
            }

            if (drawEmptyElipse)
            {
                x2 = e.X;
                y2 = e.Y;

                g = Graphics.FromImage(bmp);

                Pen p = new Pen(boja.BackColor, float.Parse(debljina.Text));
                g.DrawEllipse(p, x1, y1, x2 - x1, y2 - y1);
                pictureBox1.Image = bmp;

                drawEmptyElipse = false;
            }

            
        }

        int? oldX = null;
        int? oldY = null;

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (canPaint)
            {
                try
                {
                 
                    g = Graphics.FromImage(bmp); 
                    Pen pen = new Pen(boja.BackColor, float.Parse(debljina.Text));
                    g.DrawLine(pen, new Point(oldX ?? e.X, oldY ?? e.Y), new Point(e.X, e.Y));
                
                    pictureBox1.Image = bmp;   //kopira sliku iz bitmapa u picturebox 
                    oldX = e.X;
                    oldY = e.Y;
                    g.Dispose();  // KRIVO!!!!
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void boja_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                boja.BackColor = cd.Color;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Da li zelite spremiti dokument prije izlaza?", "Izlazak iz programa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    bmp.Save(saveFileDialog1.FileName, ImageFormat.Bmp);

                }
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Close();
            }
            
        }

        private void spremiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                bmp.Save(saveFileDialog1.FileName, ImageFormat.Bmp);

            }
        }

        private void otvoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            if (od.ShowDialog() == DialogResult.OK)
            {
                bmp = new Bitmap(Image.FromFile(od.FileName));
                pictureBox1.Image = bmp;
            }
        }

        private void noviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            SolidBrush sb = new SolidBrush(ispunaBojom.BackColor);
            g.FillRectangle(sb, 0, 0, pictureBox1.Width, pictureBox1.Height);

            pictureBox1.Image = bmp;
        }


        bool drawSquare = false;
        private void pravokutnik_Click(object sender, EventArgs e)
        {
            drawSquare = true;
        }


        bool drawElipse = false;
        private void elipsa_Click(object sender, EventArgs e)
        {
            drawElipse = true;
        }

        private void pozadinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                g = Graphics.FromImage(bmp);
                SolidBrush sb = new SolidBrush(cd.Color);
                g.FillRectangle(sb, 0, 0, pictureBox1.Width, pictureBox1.Height);

                pictureBox1.BackColor = cd.Color;
                ispunaBojom.BackColor = cd.Color;
            }
        }

        private void ispunaBojom_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                g = Graphics.FromImage(bmp);
                SolidBrush sb = new SolidBrush(cd.Color);
                g.FillRectangle(sb, 0, 0, pictureBox1.Width, pictureBox1.Height);

                pictureBox1.BackColor = cd.Color;
                ispunaBojom.BackColor = cd.Color;
            }
        }

        private void fill_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            SolidBrush sb = new SolidBrush(ispunaBojom.BackColor);
            g.FillRectangle(sb, 0, 0, pictureBox1.Width, pictureBox1.Height);


            pictureBox1.Image = bmp;
        }

        bool drawEmptySquare = false;
        private void pravokutnikPrazni_Click(object sender, EventArgs e)
        {
            drawEmptySquare = true;
        }

        bool drawEmptyElipse = false;
        private void elipsaPrazna_Click(object sender, EventArgs e)
        {
            drawEmptyElipse = true;
        }

        
    }
}
