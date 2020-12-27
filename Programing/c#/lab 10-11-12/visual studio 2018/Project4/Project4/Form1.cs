using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Project4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.White;
        }



        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // Create a pen object:
            Pen aPen = new Pen(Color.Blue, 4);
            // Set line caps and dash style: 
            aPen.StartCap = LineCap.DiamondAnchor;
            aPen.EndCap = LineCap.ArrowAnchor;
            aPen.DashStyle = DashStyle.DashDot;
            aPen.DashOffset = 50;
            //draw straight line: 
            g.DrawLine(aPen, 50, 30, 200, 30);
            // define point array to draw a curve: 
            Point point1 = new Point(50, 200);
            Point point2 = new Point(100, 75);
            Point point3 = new Point(150, 60);

            Point point4 = new Point(200, 160);
            Point point5 = new Point(250, 250);
            Point[] Points = { point1, point2, point3, point4, point5 }; g.DrawCurve(aPen, Points);
            aPen.Dispose(); g.Dispose();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

    
    }

}
