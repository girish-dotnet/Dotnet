using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo03
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

        private void openForm1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form1Obj = Form1.GetInstance();
            form1Obj.MdiParent = this;
            form1Obj.Show();
        }

        private void closeForm1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form1Obj = Form1.GetInstance();
            form1Obj.Close();
        }

        private void openForm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form2Obj = Form2.GetInstance();
            form2Obj.MdiParent = this;
            form2Obj.Show();
        }

        private void closeForm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form2Obj = Form2.GetInstance();
            form2Obj.Close();
        }

        private void tileHorizontallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);  
        }

        private void tileVerticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);  
        }

        private void cascadeWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);  
        }
    }
}
