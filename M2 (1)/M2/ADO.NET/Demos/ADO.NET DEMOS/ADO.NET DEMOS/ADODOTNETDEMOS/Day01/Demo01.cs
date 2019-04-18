using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Day01
{
    public partial class Demo01 : Form
    {
        //string sqlConnectString1 = "Data Source=ATRGSQL\\SQL2005;Initial Catalog=AdventureWorksarl;User ID=sa;Password=patni@123;";
        //string sqlConnectString2 = "Data Source=ATRGSQL\\SQL2005;Initial Catalog=Northwind;User ID=sa;Password=patni@123;";
        string sqlConnectString1 = @"Data Source=10.125.6.71\sqlilearn;Initial Catalog=Northwind;User ID=sqluser;Password=sqluser";
        //string sqlConnectString2 = "Data Source=vm-iLearn;Initial Catalog=Northwind;User ID=lab3;Password=lab3@igate";
        SqlConnection cnAdvWorks;
        SqlCommand cmdQuery;

        public Demo01()
        {
            InitializeComponent();
        }

        private void Demo01_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlSelect = "SELECT COUNT(*) FROM Categories";
            cnAdvWorks = new SqlConnection(sqlConnectString1);
            cmdQuery = new SqlCommand(sqlSelect,cnAdvWorks);
            cnAdvWorks.Open();

            int count = Convert.ToInt32(cmdQuery.ExecuteScalar());
            cnAdvWorks.Close();

            MessageBox.Show("Product Count = "+ count);

        }

        
        private void btnFillListBox_Click(object sender, EventArgs e)
        {
            string sqlSelect = "SELECT EmployeeID,LastName,FirstName FROM Employees ORDER BY EmployeeID";
            cnAdvWorks = new SqlConnection(sqlConnectString1);
            cmdQuery = new SqlCommand(sqlSelect, cnAdvWorks);
            cnAdvWorks.Open();
            SqlDataReader drEmployeeDetails;
            drEmployeeDetails = cmdQuery.ExecuteReader();

            while (drEmployeeDetails.Read())
            {
                lstEmployees.Items.Add(drEmployeeDetails.GetInt32(0) + " " + drEmployeeDetails.GetString(1) + " " + drEmployeeDetails.GetString(2));    
            }

            drEmployeeDetails.Close();
            cnAdvWorks.Close();
            
        }
    }
}