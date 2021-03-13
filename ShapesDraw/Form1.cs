using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShapesDraw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            bitmapToolStripMenuItem.Checked = false;
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
            ClearAllMenus();
            bitmapToolStripMenuItem.Checked = true;
        } 
        #endregion
    }
}