using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoConnectedDemo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string strcon = "integrated security=true;initial catalog=sqlpractice;" +
          "data source=DESKTOP-07HGAQG";
        SqlConnection cnSqlpractice;
        SqlCommand cmdQuery;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cnSqlpractice = new SqlConnection(strcon);
            cnSqlpractice.Open();
            string strSearch = "SELECT * FROM Emp WHERE Empno=@empno";
            cmdQuery = new SqlCommand(strSearch, cnSqlpractice);
        cmdQuery.Parameters.AddWithValue("@empno",Convert.ToInt32(txtEmpno.Text));
            SqlDataReader dr = cmdQuery.ExecuteReader();
            if(dr.Read())
            {
                txtNam.Text = dr["nam"].ToString();
                txtDept.Text = dr["dept"].ToString();
                txtDesig.Text = dr["desig"].ToString();
                txtBasic.Text = dr["basic"].ToString();
            }
            else
            {
                txtNam.Clear();
                txtDept.Clear();
                txtDesig.Clear();
                txtBasic.Clear();
                MessageBox.Show("Record Not Found...");
            }
        }

        private void btnUpdated_Click(object sender, EventArgs e)
        {
            cnSqlpractice = new SqlConnection(strcon);
            cnSqlpractice.Open();
            string strUpd = "UPDATE Emp SET Nam=@nam,Dept=@dept," +
                "Desig=@desig,Basic=@basic WHERE empno=@empno";
            SqlCommand cmdUpdate = new SqlCommand(strUpd, cnSqlpractice);
            cmdUpdate.Parameters.AddWithValue("@nam", txtNam.Text);
            cmdUpdate.Parameters.AddWithValue("@dept", txtDept.Text);
            cmdUpdate.Parameters.AddWithValue("@desig", txtDesig.Text);
            cmdUpdate.Parameters.AddWithValue("@basic", Convert.ToInt32(txtBasic.Text));
            cmdUpdate.Parameters.AddWithValue("@empno", Convert.ToInt32(txtEmpno.Text));
            cmdUpdate.ExecuteNonQuery();
            MessageBox.Show("record Updated...");
        }
    }
}
