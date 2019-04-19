using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace AdoStoredProc
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection cnSqlpractice;
        SqlCommand cmdSelectSp;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strCon = ConfigurationManager.
                ConnectionStrings["sqlpracticeConn"].ConnectionString;
            cnSqlpractice = new SqlConnection(strCon);
            cnSqlpractice.Open();
            //MessageBox.Show("Database Connected...");
            cmdSelectSp = new SqlCommand("prcEmpSearch", cnSqlpractice);
            cmdSelectSp.CommandType = CommandType.StoredProcedure;
            cmdSelectSp.Parameters.AddWithValue("@empno", Convert.ToInt32(txtEmpno.Text));
            SqlDataReader dr = cmdSelectSp.ExecuteReader();
            if (dr.Read())
            {
                txtNam.Text = dr["nam"].ToString();
                txtDept.Text = dr["dept"].ToString();
                txtDesig.Text = dr["desig"].ToString();
                txtBasic.Text = dr["basic"].ToString();
            }
            else
            {
                MessageBox.Show("Record Not Found...");
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string strCon = ConfigurationManager.
                ConnectionStrings["sqlpracticeConn"].ConnectionString;
            cnSqlpractice = new SqlConnection(strCon);
            cnSqlpractice.Open();
            //MessageBox.Show("Database Connected...");
            SqlCommand cmdInsertSp = new SqlCommand("prcEmpInsert", cnSqlpractice);
            cmdInsertSp.CommandType = CommandType.StoredProcedure;
    cmdInsertSp.Parameters.AddWithValue("@empno", Convert.ToInt32(txtEmpno.Text));
            cmdInsertSp.Parameters.AddWithValue("@name", txtNam.Text);
            cmdInsertSp.Parameters.AddWithValue("@dept", txtDept.Text);
            cmdInsertSp.Parameters.AddWithValue("@desig", txtDesig.Text);
            cmdInsertSp.Parameters.AddWithValue("@basic",
                Convert.ToInt32(txtBasic.Text));
            cmdInsertSp.ExecuteNonQuery();
            MessageBox.Show("record Inserted...");
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
