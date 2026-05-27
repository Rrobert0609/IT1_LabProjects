using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucrarea_4_C_
{
    public partial class Form1 : Form
    {
        float vmx, pxl;
        public Form1()
        {
            InitializeComponent();
        }
        private void desenareRigla(float valoareMax, float pixeli)
        {
            Graphics desen = this.CreateGraphics();
            Pen creionNegru = new Pen(Color.Black);
            Pen creionAlbastru = new Pen(Color.Blue);
            Brush brushRosu = new SolidBrush(Color.Red);
            Brush brushAqua = new SolidBrush(Color.BlanchedAlmond);
            Brush brushAlb = new SolidBrush(Color.White);
            desen.Clear(BackColor);
            desen.DrawRectangle(creionAlbastru, 30, 50, 70 + valoareMax * 10 * (pixeli + 1), 80);
            desen.FillRectangle(brushAqua, 31, 51, 69 + valoareMax * 10 * (pixeli + 1), 79);
            int pozStart = 60;
            Font font = new Font("Arial", 8);
            desen.DrawEllipse(creionAlbastru, 35, 82, 10, 10);
            desen.FillEllipse(brushAlb, 36, 83, 8, 8);
            for (int i = 0; i < valoareMax; i++)
            {
                desen.DrawString(i.ToString(), font, brushRosu, pozStart - 4, 76);
                for(int j = 0; j <= 9; j++)
                {
                    if (j  == 0)
                        desen.DrawLine(creionNegru, pozStart, 90, pozStart, 120);
                    else if(j == 5)
                        desen.DrawLine(creionNegru, pozStart, 100, pozStart, 120);
                    else
                        desen.DrawLine(creionNegru, pozStart, 110, pozStart, 120);
                    pozStart += ((int)pixeli+1);

                }
            }
            desen.DrawString(valoareMax.ToString(), font, brushRosu, pozStart - 4, 76);
            desen.DrawLine(creionNegru, pozStart, 90, pozStart, 120);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            vmx = (float)numericUpDown2.Value;
            pxl = (float)numericUpDown1.Value;
            desenareRigla(vmx,pxl);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            vmx = (float)numericUpDown2.Value;
            pxl = (float)numericUpDown1.Value;
            desenareRigla(vmx,pxl);
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            vmx = (float)numericUpDown2.Value;
            pxl = (float)numericUpDown1.Value;
            desenareRigla(vmx,pxl);
        }
    }
}
