using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            for (int i = 0; i < 50; i++)
            {
                g.DrawEllipse(new Pen(Brushes.Black), 20, 20, 200, 200);
                g.DrawEllipse(new Pen(Brushes.Black), 45, 45, 150, 150);
                g.DrawEllipse(new Pen(Brushes.Black), 67, 67, 100, 100);

                g.DrawRectangle(new Pen(Brushes.Black), 300, 60, 50, 100);
                g.DrawRectangle(new Pen(Brushes.Black), 320, 120, 50, 100);
                g.DrawRectangle(new Pen(Brushes.Black), 340, 180, 50, 100);
                g.DrawRectangle(new Pen(Brushes.Black), 360, 240, 50, 100);
                g.DrawRectangle(new Pen(Brushes.Black), 380, 300, 50, 100);

                g.DrawRectangle(new Pen(Brushes.Black), 499, 99, 151, 151);
                g.FillRectangle(new SolidBrush(Color.Black),500, 100, 50, 50);
                g.FillRectangle(new SolidBrush(Color.White), 550, 100, 50, 50);
                g.FillRectangle(new SolidBrush(Color.Black), 600, 100, 50, 50);
                g.FillRectangle(new SolidBrush(Color.White), 500, 150, 50, 50);
                g.FillRectangle(new SolidBrush(Color.Black), 550, 150, 50, 50);
                g.FillRectangle(new SolidBrush(Color.White), 600, 150, 50, 50);
                g.FillRectangle(new SolidBrush(Color.Black), 500, 200, 50, 50);
                g.FillRectangle(new SolidBrush(Color.White), 550, 200, 50, 50);
                g.FillRectangle(new SolidBrush(Color.Black), 600, 200, 50, 50);

                g.FillEllipse(new SolidBrush(Color.Black), 50, 230, 50, 50);
            }
        }
    }
}
