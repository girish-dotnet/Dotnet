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
    public partial class Form5 : Form
    {
        public Form5()
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
            cmdSelectSp = new SqlCommand("prcEmpOut", cnSqlpractice);
            cmdSelectSp.CommandType = CommandType.StoredProcedure;
            cmdSelectSp.Parameters.AddWithValue("@empno",
                    Convert.ToInt32(txtEmpno.Text));

            cmdSelectSp.Parameters.Add(new 
                SqlParameter("@Nam", SqlDbType.VarChar, 30));
            cmdSelectSp.Parameters["@Nam"].Direction = ParameterDirection.Output;

            cmdSelectSp.Parameters.Add(new
                SqlParameter("@Dept", SqlDbType.VarChar, 30));
            cmdSelectSp.Parameters["@Dept"].Direction = ParameterDirection.Output;

            cmdSelectSp.Parameters.Add(new
              SqlParameter("@Desig", SqlDbType.VarChar, 30));
            cmdSelectSp.Parameters["@Desig"].Direction = ParameterDirection.Output;

            cmdSelectSp.Parameters.Add(new
              SqlParameter("@Basic", SqlDbType.Int));
            cmdSelectSp.Parameters["@Basic"].Direction = ParameterDirection.Output;
            cmdSelectSp.ExecuteNonQuery();
            txtNam.Text = cmdSelectSp.Parameters["@Nam"].Value.ToString();
            txtDept.Text = cmdSelectSp.Parameters["@Dept"].Value.ToString();
            txtDesig.Text = cmdSelectSp.Parameters["@Desig"].Value.ToString();
            txtBasic.Text = cmdSelectSp.Parameters["@Basic"].Value.ToString();
        }
    }
}
