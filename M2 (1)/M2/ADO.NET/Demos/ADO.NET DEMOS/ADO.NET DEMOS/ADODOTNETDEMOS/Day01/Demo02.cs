using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

/* Create the following procedure in Northwind Database
   Create Procedure uspProductDetails
   As
	  SELECT ProductID,ProductName,QuantityPerUnit,UnitPrice
	  FROM dbo.Products
*/

namespace Day01
{
    public partial class Demo02 : Form
    {
        //string sqlConnectString = "Data Source=vm-iLearn;Initial Catalog=Northwind;User ID=sa;Password=igate@123";
        string sqlConnectString = @"Data Source=10.125.6.71\sqlilearn;Initial Catalog=Northwind;User ID=sqluser;Password=sqluser";
        string sqlConnectString1 = "Data Source=vm-iLearn;Initial Catalog=Training;User ID=lab3;Password=lab3@igate";

        SqlConnection conn;
        SqlCommand cmdQuery;

        public Demo02()
        {
            InitializeComponent();
        }

        private void btnGet10MostExpProds_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sqlConnectString);
            cmdQuery = new SqlCommand("[Ten Expensive Products]", conn);
            cmdQuery.CommandType = CommandType.StoredProcedure;
                       
            conn.Open();

            SqlDataReader drProducts = cmdQuery.ExecuteReader(CommandBehavior.CloseConnection);
                      
            // Loop through the contents of the SqlDataReader object.
            // Display the results.     
            while(drProducts.Read())
            {
                lstTenMostExpProds.Items.Add(drProducts.GetInt32(0).ToString() + " " + drProducts.GetSqlMoney(1).ToDouble().ToString("c"));                   
            }
            drProducts.Close();
            //conn.Close();
         }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sqlConnectString1);
            conn.Open();
            SqlCommand cmdInsert = new SqlCommand();

            cmdInsert.Connection = conn;
            cmdInsert.CommandType = CommandType.StoredProcedure;
            cmdInsert.CommandText = "prcInsertCustomer";

            cmdInsert.Parameters.AddWithValue("@CID", txtCID.Text);
            cmdInsert.Parameters.AddWithValue("@FName", txtFN.Text);
            cmdInsert.Parameters.AddWithValue("@LName", txtLN.Text);
            cmdInsert.Parameters.AddWithValue("@Address", txtAdd.Text);
            cmdInsert.Parameters.AddWithValue("@City", txtCity.Text);
            cmdInsert.Parameters.AddWithValue("@Country", txtCountry.Text);
            cmdInsert.Parameters.AddWithValue("@Phone", txtPhone.Text);

            int iRowsAffected;

            iRowsAffected = cmdInsert.ExecuteNonQuery();

            if (iRowsAffected >= 1)
            {
                MessageBox.Show("Data Inserted");
            }
            else
            {
                MessageBox.Show("Error");
            }

            conn.Close();

            //conn = new SqlConnection(sqlConnectString);
            //SqlCommand cmdDelete = new SqlCommand();
            //cmdDelete.CommandType = CommandType.StoredProcedure;
            //cmdDelete.CommandText = "RemoveCustomerRecord";
            //cmdDelete.Connection = conn;

            //cmdDelete.Parameters.AddWithValue("@CustomerID",txtCID.Text);
            //conn.Open();
            //int result = 0;
            //result = cmdDelete.ExecuteNonQuery();
            //if(result>=1)
            //    MessageBox.Show("Record deleted successfully");
            //else
            //    MessageBox.Show("Failed to delete the record");
        }

        private void btnOutputParam_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sqlConnectString);
            SqlCommand command = new SqlCommand("RegionFind", conn);
            command.CommandType = CommandType.StoredProcedure;

            //SqlParameter firstParam = new SqlParameter("@RegionID",SqlDbType.Int);
            //firstParam.Direction = ParameterDirection.Input;
            //SqlParameter secondParameter = new SqlParameter("@RegionDescription",SqlDbType.NChar,50);
            //secondParameter.Direction = ParameterDirection.Output;
            //command.Parameters.Add(firstParam);
            //command.Parameters.Add(secondParameter);

            command.Parameters.Add("@RegionID", SqlDbType.Int);
            command.Parameters.Add("@RegionDescription", SqlDbType.NChar, 50);
            command.Parameters["@RegionDescription"].Direction = ParameterDirection.Output;
            command.Parameters["@RegionID"].Value = 4;
            conn.Open();
            command.ExecuteNonQuery();
            string regionDescription = (string)command.Parameters["@RegionDescription"].Value;
            conn.Close();
            MessageBox.Show(regionDescription);

        }      

       
    }
}