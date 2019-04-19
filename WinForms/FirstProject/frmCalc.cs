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
    public partial class frmCalc : Form
    {
        public frmCalc()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if(txtFirstNo.Text.Length==0)
            {
                errorProvider1.SetError(txtFirstNo, "Please Enter FirstNo");
                return;
            }
            else
            {
                errorProvider1.SetError(txtFirstNo, "");
            }
            if (txtSecondNo.Text.Length == 0)
            {
                errorProvider1.SetError(txtSecondNo, "Please Enter SecondNo");
                return;
            }
            else
            {
                errorProvider1.SetError(txtSecondNo, "");
            }
            int a, b, c;
            a = Convert.ToInt32(txtFirstNo.Text);
            b = Convert.ToInt32(txtSecondNo.Text);
            c = a + b;
            txtResult.Text = c.ToString();
        }
    }
}
