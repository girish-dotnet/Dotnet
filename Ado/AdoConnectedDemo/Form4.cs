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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        string strcon = "integrated security=true;initial catalog=sqlpractice;" +
         "data source=DESKTOP-07HGAQG";
        SqlConnection cnSqlpractice;
        SqlCommand cmdInsert;
        SqlCommand cmdSelect;

        private void button1_Click(object sender, EventArgs e)
        {
            cnSqlpractice = new SqlConnection(strcon);
            cnSqlpractice.Open();
            string strIns = "INSERT INTO Emp VALUES(@empno,@name,@dept,@desig,@basic)";
            cmdInsert = new SqlCommand(strIns, cnSqlpractice);
            cmdInsert.Parameters.AddWithValue("@empno", Convert.ToInt32(txtEmpno.Text));
            cmdInsert.Parameters.AddWithValue("@name", txtNam.Text);
            cmdInsert.Parameters.AddWithValue("@dept", txtDept.Text);
            cmdInsert.Parameters.AddWithValue("@desig", txtDesig.Text);
            cmdInsert.Parameters.AddWithValue("@basic", Convert.ToInt32(txtBasic.Text));
            cmdInsert.ExecuteNonQuery();
            MessageBox.Show("Record Inserted...");
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            cnSqlpractice = new SqlConnection(strcon);
            cnSqlpractice.Open();
            string strMax = "SELECT MAX(Empno) FROM Emp";
            cmdSelect = new SqlCommand(strMax, cnSqlpractice);
            int empno=Convert.ToInt32(cmdSelect.ExecuteScalar());
            empno++;
            txtEmpno.Text = empno.ToString();
            cnSqlpractice.Close();
        }
    }
}
