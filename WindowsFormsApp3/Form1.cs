using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

           
        }
        private void triangleDrawer (Pen linePen, int x1, int y1, int x2, int y2, int x3, int y3)
        {
            Graphics Graphic = this.CreateGraphics();
            Graphic.DrawLine(linePen, x1, y1, x2, y2);
            Graphic.DrawLine(linePen, x2, y2, x3, y3);
            Graphic.DrawLine(linePen, x1, y1, x3, y3);
        }
        public void triangleDrawer(Pen linePen, Point p1, Point p2, Point p3)
        {
            Graphics Graphic = this.CreateGraphics();
            Graphic.DrawLine(linePen, p1, p2);
            Graphic.DrawLine(linePen, p2, p3);
            Graphic.DrawLine(linePen, p1, p3);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Point A = new Point(1, 1);
            Point B = new Point(10, 10);
            Point C = new Point(60, 100);
            Pen gPen = new Pen(Color.Black, 2);
            triangleDrawer(gPen, A, B, C);

        }
        private void recusrsion(int numberA, int numberB)
        {
            int numberC = numberA * numberB;
            recusrsion(numberC, numberA);
           
        }
    }
}
