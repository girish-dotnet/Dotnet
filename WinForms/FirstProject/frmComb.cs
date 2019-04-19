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
    public partial class frmComb : Form
    {
        public frmComb()
        {
            InitializeComponent();
        }

        private void frmComb_Load(object sender, EventArgs e)
        {
            cmbNames.Items.Add("Arun");
            cmbNames.Items.Add("Jitu");
            cmbNames.Items.Add("Bhargav");
            cmbNames.Items.Add("Siva");
            cmbNames.Items.Add("Aruna");
        }

        private void cmbNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Selected Name is  " + cmbNames.Text);
        }
    }
}
