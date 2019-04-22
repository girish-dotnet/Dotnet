using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Day02
{
    
    public partial class Demo06 : Form
    {
        public Demo06()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            string sqlConnectString = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString; 
            SqlConnection connection = new SqlConnection(sqlConnectString);

            connection.Open();
            SqlTransaction trn = connection.BeginTransaction();

            SqlCommand command = new SqlCommand();
            
            command.Transaction = trn;
            command.Connection = connection;
            command.CommandText = "INSERT INTO EmployeeDetails " +
            "(FirstName, LastName, PostionCode, Gender, Age, Address) VALUES " +
            "(@FirstName, @LastName, @PostionCode, @Gender, @Age, @Address)";

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@FirstName", txtFN.Text);
            command.Parameters.AddWithValue("@LastName", txtLN.Text);
            command.Parameters.AddWithValue("@PostionCode", Convert.ToInt32(txtPCode.Text));
            command.Parameters.AddWithValue("@Gender", txtGender.Text);
            command.Parameters.AddWithValue("@Age", Convert.ToInt32(txtAge.Text));
            command.Parameters.AddWithValue("@Address", txtAddress.Text);

            SqlCommand cmdUpdatePostion = new SqlCommand();
            cmdUpdatePostion.Connection = connection;
            cmdUpdatePostion.Transaction = trn;
            
            cmdUpdatePostion.CommandText = "UPDATE EmployeePosition SET CurrentStrength=CurrentStrength + 1" +
            "WHERE PositionCode=@PositionCode";

            cmdUpdatePostion.Parameters.AddWithValue("@PositionCode", Convert.ToInt32(txtPCode.Text));

            SqlCommand cmdPosition = new SqlCommand();
            cmdPosition.Connection = connection;
            cmdPosition.CommandText = "Select CurrentStrength,PositionName From EmployeePosition Where PositionCode=@PositionCode";
            cmdPosition.Parameters.AddWithValue("@PositionCode", Convert.ToInt32(txtPCode.Text));
            
            try
            {
                command.ExecuteNonQuery();
                cmdUpdatePostion.ExecuteNonQuery();
                trn.Commit();
                MessageBox.Show("Employee added successfully");

                SqlDataReader dr;
                dr=cmdPosition.ExecuteReader();
                dr.Read();
                MessageBox.Show("The current strength for the position : " + dr.GetString(1).ToString() + " " + "is " + dr.GetInt32(0).ToString());
            }
            catch (SqlException ex)
            {
                trn.Rollback();
                MessageBox.Show("An error occured.");
            }
            finally
            {
                connection.Close();
            }   
       }

        private void txtPCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGender_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFN_TextChanged(object sender, EventArgs e)
        {

        }

        private void Demo06_Load(object sender, EventArgs e)
        {

        }
    }
}