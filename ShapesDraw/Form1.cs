using System;
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


        //Clear Activation of all menues
        private void ClearAllMenues()
        {
            circleToolStripMenuItem.Checked = false;
            squareToolStripMenuItem.Checked = false;
            lineToolStripMenuItem.Checked = false;
            bitmapToolStripMenuItem.Checked = false;
        }

        //Activate Circle menu
        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearAllMenues();
            circleToolStripMenuItem.Checked = true;
        }
        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearAllMenues();
            squareToolStripMenuItem.Checked = true;
        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearAllMenues();
            lineToolStripMenuItem.Checked = true;
        }

        private void bitmapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearAllMenues();
            bitmapToolStripMenuItem.Checked = true;
        }
    }
}
