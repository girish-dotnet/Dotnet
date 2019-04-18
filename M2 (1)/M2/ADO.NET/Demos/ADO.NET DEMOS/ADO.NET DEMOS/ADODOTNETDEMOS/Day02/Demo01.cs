using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Day02
{
    public partial class Demo01 : Form
    {
        public Demo01()
        {
            InitializeComponent();
        }

        private void btnFillGrid_Click(object sender, EventArgs e)
        {
            SqlConnection connection=new SqlConnection();
            string sqlConnectString = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
            
            connection = new SqlConnection(sqlConnectString);
            SqlCommand command = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet dsProduct = new DataSet();

            command.Connection = connection;
            command.CommandText = "Select ProductID,ProductName,UnitPrice,UnitsInStock From Products";
            adapter.SelectCommand = command;
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adapter.Fill(dsProduct,"Product");
            dgvProducts.DataSource = dsProduct.Tables["Product"];

            SqlDataAdapter adapter2 = new SqlDataAdapter("Select * From Categories", connection);
            adapter2.Fill(dsProduct,"Category");
            dgvCategories.DataSource = dsProduct.Tables[1];
        }
    }
}
