using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;


namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        // Одиниця вимірюваня визначена у світовій системі координат: 
        private float xMin = 4f; 
        private float xMax = 6; 
        private float yMin = 3f; 
        private float yMax = 6f;
        private Panel drawingPanel1;
        private Panel drawingPanel;


        // Одиниця вимірювання у пікселях: 
        private int offset = 30;

        public Form1()
        {
            InitializeComponent(); 
            this.SetStyle(ControlStyles.ResizeRedraw, true); 
            this.BackColor = Color.White;
            // Subscribing to a paint eventhandler to drawingPanel: 
            drawingPanel.Paint += new PaintEventHandler(drawingPanelPaint);
            drawingPanel.BorderStyle = BorderStyle.FixedSingle; 
            drawingPanel.Anchor = AnchorStyles.Bottom;
            drawingPanel.Anchor = AnchorStyles.Left;
            drawingPanel.Anchor = AnchorStyles.Right; 
            drawingPanel.Anchor = AnchorStyles.Top;
        }

        private void drawingPanelPaint(object sender, PaintEventArgs e)
        {
            drawingPanel.Left = offset; 
            drawingPanel.Top = offset;
            drawingPanel.Width = ClientRectangle.Width - 2 * offset;
            drawingPanel.Height = ClientRectangle.Height - 2 * offset;
            Graphics g = e.Graphics;
            Pen aPen = new Pen(Color.Green, 3);
            g.DrawLine(aPen, Point2D(new PointF(2, 3)),
            Point2D(new PointF(6, 7))); 
            aPen.Dispose();
            g.Dispose();
        }

        private PointF Point2D(PointF ptf)
        {
            PointF aPoint = new PointF();
            aPoint.X = (ptf.X - xMin) * drawingPanel.Width / (xMax - xMin);
            aPoint.Y = drawingPanel.Height - (ptf.Y - yMin) * drawingPanel.Height / (yMax - yMin); return aPoint;
        }
    }
}
