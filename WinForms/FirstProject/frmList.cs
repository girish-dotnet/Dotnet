using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProject
{
    public partial class frmList : Form
    {
        public frmList()
        {
            InitializeComponent();
        }

        private void frmList_Load(object sender, EventArgs e)
        {
            lstSource.Items.Add("Arun");
            lstSource.Items.Add("Jitu");
            lstSource.Items.Add("Bhargav");
            lstSource.Items.Add("Siva");
            lstSource.Items.Add("Aruna");
        }

        private void btnGt_Click(object sender, EventArgs e)
        {
            lstTarget.Items.Add(lstSource.Text);
            lstSource.Items.Remove(lstSource.Text);
        }

        private void btnDgt_Click(object sender, EventArgs e)
        {
            for(int i=0;i<lstSource.Items.Count;i++)
            {
                lstTarget.Items.Add(lstSource.Items[i].ToString());
            }
            lstSource.Items.Clear();
        }
    }
}
