using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OldAsyncProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
   
        private void btnGetData_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString);
                SqlCommand cmd = new SqlCommand("WAITFOR DELAY '00:00:10';SELECT * FROM Categories", conn);
                conn.Open();
                AsyncCallback callback = new AsyncCallback(GetCategories);
                IAsyncResult result = cmd.BeginExecuteReader(callback, cmd);
                while (!result.IsCompleted)
                {
                     lblStatus.Visible = true;
                     this.Refresh();
                }
                lblStatus.Visible = false;
                this.Refresh();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private static void GetCategories(IAsyncResult result)
        {
            try
            {
                SqlCommand cmd = (SqlCommand)result.AsyncState;
                SqlDataReader reader = cmd.EndExecuteReader(result);
                while (reader.Read())
                {
                    MessageBox.Show(reader[0].ToString());
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
