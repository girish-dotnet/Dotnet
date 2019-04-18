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
    public partial class Demo04 : Form
    {
        public Demo04()
        {
            InitializeComponent();
        }

        private void Demo04_Load(object sender, EventArgs e)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
            SqlConnection conn = new SqlConnection(ConnectionString);

            conn.Open();

            DataSet ds = new DataSet("Orders");

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Orders", conn);

            adapter.Fill(ds, "Orders");
            DataView dataView1 = new DataView(ds.Tables["Orders"]);
            dataView1.Sort = "ShippedDate ASC";

            DataView dataView2 = new DataView(ds.Tables["Orders"]);
            dataView2.Sort = "EmployeeID ASC";

            dataGrid1.DataSource = dataView1;
            dataGrid2.DataSource = dataView2;


        }
    }
}
