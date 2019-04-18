using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SqlCredentialsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SecureString securePassword = new SecureString();
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                securePassword.AppendChar(e.KeyChar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString))
                {
                    securePassword.MakeReadOnly();
                    SqlCredential credentials = new SqlCredential(txtUserName.Text, securePassword);
                    conn.Credential = credentials;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select * From Categories", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(reader);
                    dgvCategories.DataSource = table;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                txtUserName.Text = string.Empty;
                txtPassword.Text = string.Empty;
                txtUserName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
