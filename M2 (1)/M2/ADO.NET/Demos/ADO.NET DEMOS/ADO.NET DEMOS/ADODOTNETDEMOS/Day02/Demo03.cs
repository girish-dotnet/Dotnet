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
    public partial class Demo03 : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
        string categorySQL = "SELECT * FROM Categories";
        string productSQL = "SELECT * FROM Products";

        DataSet ds = new DataSet();
        DataRelation relation;

        public Demo03()
        {
            InitializeComponent();
        }

        private void Demo03_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand com = new SqlCommand(categorySQL, con);
            SqlDataAdapter adapter = new SqlDataAdapter(com);

            con.Open();
            adapter.Fill(ds, "Categories");
            adapter.SelectCommand.CommandText = productSQL;
            adapter.Fill(ds, "Products");
            con.Close();

            DataColumn parentCol = ds.Tables["Categories"].Columns["CategoryID"];
            DataColumn childCol = ds.Tables["Products"].Columns["CategoryID"];
            relation = new DataRelation("Cat_Prod", parentCol, childCol);
            ds.Relations.Add(relation);

            foreach (DataRow row in ds.Tables["Categories"].Rows)
            {
                lstCategories.Items.Add(row["CategoryName"]);
            }

        }

        private void lstCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstProducts.Items.Clear();

            DataRow[] rows = ds.Tables["Categories"].Select("CategoryName='" + lstCategories.Text + "'");
            DataRow parent = rows[0];

            foreach (DataRow child in parent.GetChildRows(relation))
            {
                lstProducts.Items.Add(child["ProductName"]);
            }
        }
    }
}
  