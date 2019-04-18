using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace AsyncDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async static Task<SqlDataReader> GetDataAsynchronously(SqlCommand dbCommand,SqlConnection conn)
        {
            await conn.OpenAsync();
            dbCommand.Connection = conn;
            return  await dbCommand.ExecuteReaderAsync();
        }
        private async void btnGetData_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("WAITFOR DELAY '00:00:05';Select * from Categories"))
                    {
                        lblStatus.Visible = true;
                        using (SqlDataReader reader = await GetDataAsynchronously(cmd, conn))
                        {
                            DataTable categoriesTable = new DataTable();
                            categoriesTable.Load(reader);
                            dgvCategories.DataSource = categoriesTable;
                            //while (await reader.ReadAsync())
                            //{
                            //    MessageBox.Show(reader[0].ToString());
                            //}
                        }
                        lblStatus.Visible = false;
                    }
                    //conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
