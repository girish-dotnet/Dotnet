using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoConnectedDemo
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        string strcon = "integrated security=true;initial catalog=sqlpractice;" +
          "data source=DESKTOP-07HGAQG";
        SqlConnection cnSqlpractice;
        SqlCommand cmdQuery;
        private void Form5_Load(object sender, EventArgs e)
        {
            cnSqlpractice = new SqlConnection(strcon);
            cnSqlpractice.Open();
            string sqlSelect = "SELECT * FROM Emp";
            cmdQuery = new SqlCommand(sqlSelect, cnSqlpractice);
            SqlDataReader dr = cmdQuery.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgEmp.DataSource = dt;
        }
    }
}
