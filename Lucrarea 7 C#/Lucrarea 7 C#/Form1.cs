using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucrarea_7_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        struct tranz_bursa
        {
            public int data;
            public int val_min;
            public int val_max;
            public int val_desch;
            public int val_inch;
        }
        tranz_bursa[] stock = new tranz_bursa[31];

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            Graphics g = this.CreateGraphics();
            Pen black_pen = new Pen(Color.Black);
            SolidBrush red_brush = new SolidBrush(Color.Red);
            SolidBrush green_brush = new SolidBrush(Color.Green);
            Random rnd = new Random();
            for (int i = 1; i <= 30; i++)
            {
                stock[i].data = i;
                stock[i].val_min = rnd.Next(100, 200);
                stock[i].val_max = rnd.Next(201, 400);
                stock[i].val_desch = rnd.Next(stock[i].val_min, stock[i].val_max);
                stock[i].val_inch = rnd.Next(stock[i].val_desch, stock[i].val_max);
            }
            int x = 15, y = 150;
            for (int i = 1; i <= 30; i++)
            {
                g.DrawLine(black_pen, x, 400 - stock[i].val_min, x, 400 - stock[i].val_max);
                if (y > (800 - stock[i].val_desch - stock[i].val_inch) / 2)
                    g.FillRectangle(green_brush, x - 3, 400 - stock[i].val_inch, 6, stock[i].val_inch - stock[i].val_desch);
                else
                    g.FillRectangle(red_brush, x - 3, 400 - stock[i].val_inch, 6, stock[i].val_inch - stock[i].val_desch);
                g.DrawRectangle(black_pen, x - 4, 399 - stock[i].val_inch, 7, stock[i].val_inch - stock[i].val_desch + 1);
                g.DrawLine(black_pen, x - 15, y, x, (800 - stock[i].val_inch - stock[i].val_desch) / 2);
                x += 15;
                y = (800 - stock[i].val_desch - stock[i].val_inch) / 2;

            }
        }
    }
}
