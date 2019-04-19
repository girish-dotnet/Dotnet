using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoStoredProc
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        SqlConnection cnSqlpractice;
        SqlCommand cmdSelectSp;

        private void Form6_Load(object sender, EventArgs e)
        {
            string strCon = ConfigurationManager.
                ConnectionStrings["sqlpracticeConn"].ConnectionString;
            cnSqlpractice = new SqlConnection(strCon);
            cnSqlpractice.Open();
            cmdSelectSp = new SqlCommand("prcAgentShow", cnSqlpractice);
            cmdSelectSp.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmdSelectSp.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            DataView dv = new DataView(dt);
            dv.Sort = "FirstName ASC";
            dv.RowFilter = "Gender='Male'";
            dgAgent.DataSource = dv;

        }
    }
}
