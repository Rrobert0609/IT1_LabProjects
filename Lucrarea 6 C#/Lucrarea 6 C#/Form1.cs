using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucrarea_6_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool[,] desen = new bool[17, 17];
        Random random = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 1;i<=16;i++)
                for(int j = 1; j <= 16; j++)
                {
                    if (random.Next(0, 2) == 1)
                        desen[i, j] = true;
                    else
                        desen[i, j] = false;
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g=this.CreateGraphics();
            Pen negru = new Pen(Color.Black);
            SolidBrush albastru = new SolidBrush(Color.DarkCyan);
            int x = 10, y = 10;
            for(int i = 1; i <= 16; i++)
            {
                for(int j = 1;j <= 16; j++)
                {
                    g.DrawRectangle(negru, x, y, 15, 15);
                    if (desen[i,j]==true)
                        g.FillRectangle(albastru, x+1, y+1, 14,14);
                    x += 16;
                }
                x = 10;
                y += 16;
            }
            x = 276;
            y = 10;
            for(int i = 1;i <= 16; i++)
            {
                for(int j = 1; j <= 16; j++)
                {
                    g.DrawRectangle(negru, x, y, 15, 15);
                    if(i==4||i==13||j==4||j==13)
                            g.FillRectangle(albastru,x+1,y+1, 14,14);
                    x += 16;
                }
                x = 276; 
                y += 16;
            }
        }
    }
}
