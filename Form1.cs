using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.Turquoise);
            SolidBrush myCorp = new SolidBrush(Color.DarkGreen);
            SolidBrush myTrum = new SolidBrush(Color.Green);
            SolidBrush myTrub = new SolidBrush(Color.LimeGreen);
            SolidBrush mySeà = new SolidBrush(Color.Blue);
            Pen myWind = new Pen(Color.Brown, 4);
            g.FillRectangle(myTrub, 300, 125, 75, 75);
            g.FillRectangle(myTrub, 480, 125, 75, 75);
            g.FillPolygon(myCorp, new Point[]
              {
            new Point(100,300),new Point(700,300),
            new Point(700,300),new Point(600,400),
            new Point(600,400),new Point(200,400),
            new Point(200,400),new Point(100,300)
              }
            );
            g.FillRectangle(myTrum, 250, 200, 350, 100);
            int x = 50;
            int Radius = 50;
            while (x <= pictureBox1.Width - Radius)
            {
                g.FillPie(mySeà, 0 + x, 375, 50, 50, 0, -180);
                x += 50;
            }
            for (int y = 300; y <= 550; y += 50)
            {
                g.DrawEllipse(myWind, y, 240, 20, 20);
            }
        }
    }
}
