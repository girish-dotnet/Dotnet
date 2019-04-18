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
    public partial class Demo04Cont : Form
    {
        public Demo04Cont()
        {
            InitializeComponent();
        }

        private void Demo04Cont_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
            string SQL = "SELECT * FROM Customers";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand com = new SqlCommand(SQL, con);
            SqlDataAdapter adapter = new SqlDataAdapter(com);
            DataSet ds = new DataSet("Northwind");

            con.Open();
            adapter.Fill(ds, "Customers");
            con.Close();

            DataView viewArgentina = new DataView(ds.Tables["Customers"]);
            DataView viewBrazil = new DataView(ds.Tables["Customers"]);

            viewArgentina.RowFilter = "Country = 'Argentina'";
            viewBrazil.RowFilter = "Country = 'Brazil'";

            gridArgentina.DataSource = viewArgentina;
            gridBrazil.DataSource = viewBrazil;
            gridAll.DataSource = ds.Tables["Customers"].DefaultView;

        }
    }
}
