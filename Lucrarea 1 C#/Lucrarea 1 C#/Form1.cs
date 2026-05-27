using System;
using System.Drawing;

namespace Lucrarea_1_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                PictureBox pb1 = new PictureBox();
                pb1.Image = Image.FromFile("C:/Users/Robert/source/repos/Lucrarea 1 C#/poza random pt proiect.jpeg");
                pb1.Location = new Point(25, 125);
                pb1.Size = new Size(250, 250);
                this.Controls.Add(pb1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PictureBox pb2 = new PictureBox();
            pb2.Image = Image.FromFile("C:/Users/Robert/source/repos/Lucrarea 1 C#/alta poza random pentru proiect.jpeg");
            pb2.Location = new Point(565, 125);
            pb2.Size = new Size(500, 190);
            this.Controls.Add(pb2);
            label4.Text = "Gluma proasta din liceu\nVa rog ignorati :)";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Drawing.Graphics desen;
            desen = this.CreateGraphics();
            System.Drawing.Pen bluepen;
            bluepen = new System.Drawing.Pen(System.Drawing.Color.Blue);
            desen.DrawLine(bluepen, 390, 150, 390, 300);
            desen.DrawLine(bluepen, 390, 150, 300, 300);
            desen.DrawLine(bluepen, 390, 150, 480, 300);
            desen.DrawLine(bluepen, 300, 300, 480, 300);
            desen.DrawEllipse(bluepen, 340, 200, 100, 100);
            desen.DrawRectangle(bluepen, new Rectangle(300, 300, 180, 180));
            Point[] romb = { new Point(390, 300), new Point(480, 390), new Point(390, 480), new Point(300, 390) };
            desen.DrawPolygon(bluepen, romb);
        }
    }
}
