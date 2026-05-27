using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucrarea_3_C_
{
    public partial class Form1 : Form
    {
        static int max_forme = (Screen.PrimaryScreen.Bounds.Width-30)/40;
        int[] rnd_forme_gen = new int[max_forme+1];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 1; i <= max_forme; i++)
            {
                int aux = rnd.Next(1, 7);
                rnd_forme_gen[i] = aux;
            }
        }

        void forme(int nr_forma,int auxHeight,int currentX,Point auxstart)
        {
            Point s_sus = new Point(currentX - auxHeight / 2 + auxHeight / 10, auxHeight);
            Point s_jos = new Point(currentX - auxHeight / 2 + auxHeight / 10, 2 * auxHeight - auxHeight / 5);
            Point d_sus = new Point(currentX + auxHeight / 2 - auxHeight / 10, auxHeight);
            Point d_jos = new Point(currentX + auxHeight / 2 - auxHeight / 10, 2 * auxHeight - auxHeight / 5);
            int marimeAux = auxstart.X - s_sus.X;
            Graphics ornamente = this.CreateGraphics();
            Pen redPen = new Pen(Color.Red);
            switch (nr_forma)
            {
                case 1:
                    Point[] romb = new Point[] { auxstart, new Point(s_sus.X, s_sus.Y + marimeAux), new Point(auxstart.X, auxstart.Y + 2 * marimeAux), new Point(d_sus.X, d_sus.Y + marimeAux), auxstart};
                    ornamente.DrawEllipse(redPen, s_sus.X, s_sus.Y, 2 * marimeAux, 2 * marimeAux);
                    ornamente.DrawPolygon(redPen, romb);
                    ornamente.DrawLine(redPen, auxstart.X, auxstart.Y, auxstart.X, auxstart.Y + 2 * marimeAux);
                    ornamente.DrawLine(redPen, s_sus.X, s_sus.Y + marimeAux, d_sus.X, d_sus.Y + marimeAux);
                    break;
                case 2:
                    Point[] formaciudata = new Point[] { auxstart, new Point(s_sus.X + marimeAux * 3 / 4, auxstart.Y + marimeAux / 4), new Point(s_sus.X + marimeAux / 4, auxstart.Y + marimeAux / 4), new Point(s_sus.X + marimeAux / 4, auxstart.Y + marimeAux * 3 / 4), new Point(s_sus.X, auxstart.Y + marimeAux), new Point(s_sus.X + marimeAux / 4, auxstart.Y + marimeAux * 5 / 4), new Point(s_sus.X + marimeAux / 4, auxstart.Y + marimeAux * 7 / 4), new Point(s_sus.X + marimeAux * 3 / 4, auxstart.Y + marimeAux * 7 / 4), new Point(s_sus.X + marimeAux, auxstart.Y + 2 * marimeAux), new Point(s_sus.X + marimeAux * 5 / 4, auxstart.Y + marimeAux * 7 / 4), new Point(s_sus.X + marimeAux * 7 / 4, auxstart.Y + marimeAux * 7 / 4), new Point(s_sus.X + marimeAux * 7 / 4, auxstart.Y + marimeAux * 5 / 4), new Point(s_sus.X + 2 * marimeAux, auxstart.Y + marimeAux), new Point(s_sus.X + marimeAux * 7 / 4, auxstart.Y + marimeAux * 3 / 4), new Point(s_sus.X + marimeAux * 7 / 4, auxstart.Y + marimeAux / 4), new Point(s_sus.X + marimeAux * 5 / 4, auxstart.Y + marimeAux / 4), auxstart };
                    ornamente.DrawPolygon(redPen, formaciudata);
                    ornamente.DrawLine(redPen, auxstart, new Point(auxstart.X, auxstart.Y + 2 * marimeAux));
                    ornamente.DrawLine(redPen, new Point(s_sus.X + marimeAux / 4, s_sus.Y + marimeAux / 4), new Point(s_sus.X + marimeAux * 7 / 4, s_sus.Y + marimeAux * 7 / 4));
                    ornamente.DrawLine(redPen, new Point(s_sus.X, s_sus.Y + marimeAux), new Point(s_sus.X + 2 * marimeAux, s_sus.Y + marimeAux));
                    ornamente.DrawLine(redPen, new Point(s_jos.X + marimeAux / 4, s_jos.Y - marimeAux / 4), new Point(s_sus.X + marimeAux * 7 / 4, s_sus.Y + marimeAux / 4));
                    break;
                case 3:
                    Point[] pentagrama = new Point[] { auxstart, new Point(s_sus.X + marimeAux * 3 / 7, s_sus.Y + 2 * marimeAux), new Point(s_sus.X + 2 * marimeAux, s_sus.Y + marimeAux * 6 / 7), new Point(s_sus.X, s_sus.Y + marimeAux * 6 / 7), new Point(s_sus.X + marimeAux * 11 / 7, s_sus.Y + 2 * marimeAux), auxstart };
                    ornamente.DrawPolygon(redPen, pentagrama);
                    break;
                case 4:
                    Point[] clepsidra = new Point[] {s_sus,d_jos,s_jos,d_sus,s_sus};
                    ornamente.DrawPolygon(redPen, clepsidra);
                    ornamente.DrawLine(redPen, auxstart, new Point(auxstart.X, auxstart.Y + 2 * marimeAux));
                    break;
                case 5:
                    Point[] altromb = new Point[] { auxstart, new Point(s_sus.X + marimeAux / 2, s_sus.Y + marimeAux), new Point(auxstart.X, auxstart.Y + 2 * marimeAux), new Point(d_sus.X - marimeAux / 2, d_sus.Y + marimeAux), auxstart, new Point(s_sus.X + marimeAux * 4 / 5, s_sus.Y + marimeAux), new Point(auxstart.X, auxstart.Y + 2 * marimeAux), new Point(auxstart.X + marimeAux / 4, auxstart.Y + marimeAux), auxstart };
                    ornamente.DrawPolygon(redPen , altromb);
                    ornamente.DrawLine(redPen, new Point(s_sus.X + marimeAux / 2, s_sus.Y + marimeAux), new Point(auxstart.X + marimeAux / 2, auxstart.Y + marimeAux));
                    break;
                case 6:
                    ornamente.DrawEllipse(redPen, s_sus.X, s_sus.Y, 2 * marimeAux, 2 * marimeAux);
                    ornamente.DrawEllipse(redPen, s_sus.X+marimeAux/2,s_sus.Y,marimeAux,2*marimeAux);
                    ornamente.DrawEllipse(redPen, s_sus.X, s_sus.Y + marimeAux / 2, 2 * marimeAux, marimeAux);
                    break;
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int minHeight = 40;
            minHeight += (this.Height - 40) / 20;
            Graphics desen = this.CreateGraphics();
            Pen bluePen = new Pen(Color.Blue);
            desen.Clear(this.BackColor);
            desen.DrawLine(bluePen, 0, 20, this.Width, 20);
            int j = 1;
            for(int i=30; i <= this.Width; i += minHeight)
            {
                Point ornamentStart = new Point(i, minHeight);
                desen.DrawLine(bluePen, i, 20, i, minHeight);
                forme(rnd_forme_gen[j], minHeight, i, ornamentStart);
                j++;
            }
        }
    }
}

