using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ShapesDraw
{
    public partial class Form1 : Form
    {
        #region Properties
        private Point _startPoint { get; set; }
        private Point _endPoint { get; set; }
        private IList<IDrawableElement> _drawableElements { get; set; }
        private BitmapSaver _bitmapSaver { get; set; }
        #endregion

        //Ctor
        public Form1()
        {
            InitializeComponent();
            _drawableElements = new List<IDrawableElement>();
            ResizeRedraw = true;
            _bitmapSaver = new BitmapSaver(@"C:\temp\testbmp.bmp");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Paint += Form1_Paint;
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var fig in this._drawableElements)
            {
                fig.Draw(e);
            }
        }

        //Close Application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }


        #region Menu treatment
        //Clear Activation of all menus
        private void ClearAllMenus()
        {
            circleToolStripMenuItem.Checked = false;
            squareToolStripMenuItem.Checked = false;
            lineToolStripMenuItem.Checked = false;
        }

        //Activate Circle menu
        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearAllMenus();
            circleToolStripMenuItem.Checked = true;
        }

        //Activate Square menu
        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearAllMenus();
            squareToolStripMenuItem.Checked = true;
        }

        //Activate Line menu
        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearAllMenus();
            lineToolStripMenuItem.Checked = true;
        }

        //Activate Bitmap menu
        private void bitmapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _bitmapSaver.Save(this);
        }
        #endregion

        //Start click
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            _startPoint = e.Location;
        }

        //End Click
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            _endPoint = e.Location;

            NewFigureTreatment();
        }

        //Adding new figure to Form
        private void NewFigureTreatment()
        {
            bool isNewFigureAdded = true;

            if (circleToolStripMenuItem.Checked)
            {
                IDrawableElement element = new DrawableCircle(_startPoint, _endPoint);
                _drawableElements.Add(element);
            }
            else if (squareToolStripMenuItem.Checked)
            {
                IDrawableElement element = new DrawableSquare(_startPoint, _endPoint);
                _drawableElements.Add(element);
            }
            else if (lineToolStripMenuItem.Checked)
            {
                IDrawableElement element = new DrawableLine(_startPoint, _endPoint);
                _drawableElements.Add(element);
            }
            else
            {
                isNewFigureAdded = false;
            }

            if (isNewFigureAdded)
            {
                this.Invalidate();
            }
        }
    }
}