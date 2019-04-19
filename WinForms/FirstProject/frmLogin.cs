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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> users = new Dictionary<string, string>();
            users.Add("Bhargav", "Naga");
            users.Add("Arun", "Arun");
            users.Add("Pallavi", "Anu");
            users.Add("Jitendra", "Jitu");
            string pwd = string.Empty;
            users.TryGetValue(txtUserName.Text, out pwd);
            if(pwd!=null)
            {
                if (pwd.Equals(txtPassword.Text))
                {
                    frmMenu obj = new frmMenu();
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials...");
                }
            }
            else
            {
                MessageBox.Show("Invalid user...");
            }
           
        }
    }
}
