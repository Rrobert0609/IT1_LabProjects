using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucrarea_2_C_
{
    public partial class Form1 : Form
    {
        int nr = 0;
        bool c = true;
        Point s_jos = new Point(30, 280);
        Point s_sus = new Point(30, 280);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            System.Drawing.Graphics desen;
            desen = this.CreateGraphics();
            System.Drawing.SolidBrush fillVerde = new System.Drawing.SolidBrush(System.Drawing.Color.LightGreen);
            if (c == true)
            {
                nr += 10;
                if (nr == 100)
                {
                    c = false;
                    button1.Text = "Scade";
                }
            }
            else
            {
                nr -= 10;
                if (nr == 0)
                {
                    c = true;
                    button1.Text = "Adauga";
                }
            }
            label1.Text = nr.ToString();
            if (nr != 0) desen.FillRectangle(fillVerde, s_jos.X, s_jos.Y - nr, 15, nr);
            else desen.FillRectangle(fillVerde, s_jos.X, s_jos.Y - nr - 1, 15, nr + 1);
            s_jos = Point.Add(s_jos, new Size(18, 0));
            if (c == true)
                s_sus = Point.Add(s_sus, new Size(18, -10));
            else
                s_sus = Point.Add(s_sus, new Size(18, 10));
        }
    }
}
