using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace AdoStoredProc
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection cnSqlpractice;
        SqlCommand cmdSelectSp;
        private void Form2_Load(object sender, EventArgs e)
        {
            string strCon = ConfigurationManager.ConnectionStrings["sqlpracticeConn"].ConnectionString;
            cnSqlpractice = new SqlConnection(strCon);
            cnSqlpractice.Open();
            //MessageBox.Show("Database Connected...");
            cmdSelectSp = new SqlCommand("prcEmpShow", cnSqlpractice);
            cmdSelectSp.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmdSelectSp.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgEmp.DataSource = dt;
        }
    }
}
