using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo4new
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frmObj1 = new Form1();
            frmObj1.MdiParent = this;
            frmObj1.Show();
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frmObj1 = new Form2();
            frmObj1.MdiParent = this;
            frmObj1.Show();
        }
    }
}
