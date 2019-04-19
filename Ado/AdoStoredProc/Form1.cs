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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection cnSqlpractice;
        SqlCommand cmdSelectSp;

        private void Form1_Load(object sender, EventArgs e)
        {
            string strCon = ConfigurationManager.ConnectionStrings["sqlpracticeConn"].ConnectionString;
            cnSqlpractice = new SqlConnection(strCon);
            cnSqlpractice.Open();
            //MessageBox.Show("Database Connected...");
            cmdSelectSp = new SqlCommand("prcEmpShow", cnSqlpractice);
            cmdSelectSp.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmdSelectSp.ExecuteReader();
            if(dr.Read())
            {
                txtEmpno.Text = dr["empno"].ToString();
                txtNam.Text = dr["nam"].ToString();
                txtDept.Text = dr["dept"].ToString();
                txtDesig.Text = dr["desig"].ToString();
                txtBasic.Text = dr["basic"].ToString();
            }
        }
    }
}
