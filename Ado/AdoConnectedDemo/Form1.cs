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
    public partial class Form1 : Form
    {
        string strcon = "integrated security=true;initial catalog=sqlpractice;" +
            "data source=DESKTOP-07HGAQG";
        SqlConnection cnSqlpractice;
        SqlCommand cmdQuery;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cnSqlpractice = new SqlConnection(strcon);
            cnSqlpractice.Open();
            string sqlSelect = "SELECT empno,nam,dept,desig,basic FROM Emp";
            cmdQuery = new SqlCommand(sqlSelect, cnSqlpractice);
            SqlDataReader dr = cmdQuery.ExecuteReader();
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
