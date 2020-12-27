using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;


namespace Project3
{
    public partial class Form1 : Form
    {
        // Одиниця вимірюваня визначена у світовій системі координат: 
        private float xMin = 0f;
        private float xMax = 10f;
        private float yMin = 0f;
        private float yMax = 10f;
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
            drawingPanel.Height = ClientRectangle.Height - 2 * offset; Graphics g = e.Graphics;
            Pen aPen = new Pen(Color.Green, 3); g.DrawLine(aPen, Point2D(new PointF(2, 3)),
            Point2D(new PointF(6, 7))); aPen.Dispose();
            g.Dispose();
        }

        private PointF Point2D(PointF ptf)
        {
            PointF aPoint = new PointF();
            aPoint.X = (ptf.X - xMin) * drawingPanel.Width / (xMax - xMin);
            aPoint.Y = drawingPanel.Height - (ptf.Y - yMin) * drawingPanel.Height / (yMax - yMin); return aPoint;
        }

        private void InitializeComponent()
        {
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // drawingPanel
            // 
            this.drawingPanel.Location = new System.Drawing.Point(318, 112);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(200, 100);
            this.drawingPanel.TabIndex = 0;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(690, 363);
            this.Controls.Add(this.drawingPanel);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

    }

}
