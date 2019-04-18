using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo04
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            ShowTime();
        }

        private void ShowTime()
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ShowTime();
        }

        private void openForm01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmObj1 = Form1.GetInstance();
            frmObj1.MdiParent = this;
            frmObj1.Show();
        }

        private void closeForm01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmObj1 = Form1.GetInstance();
            frmObj1.Close();

        }

        private void openForm02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmObj2 = Form2.GetInstance();
            frmObj2.MdiParent = this;
            frmObj2.Show();
        }

        private void closeForm02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmObj2 = Form2.GetInstance();
            frmObj2.Close();
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadeWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
        
    }
}
