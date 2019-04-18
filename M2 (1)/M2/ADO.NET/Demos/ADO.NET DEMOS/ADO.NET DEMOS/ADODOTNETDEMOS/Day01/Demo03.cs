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
    public partial class Demo03 : Form
    {
        public Demo03()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string sqlConnectString = "Data Source=vm-iLearn;Initial Catalog=Training;User ID=lab3;Password=lab3@igate";

            SqlConnection connection = new SqlConnection(sqlConnectString);
            SqlCommand command = new SqlCommand();

            command.Connection = connection;

            command.CommandText = "INSERT INTO DN05MayStudent " +
           "(RollNo,FirstName, LastName, Gender, Age, Address) VALUES " +
              "(@RollNo,@FirstName, @LastName, @Gender, @Age, @Address)";

            command.Parameters.AddWithValue("@RollNo", Convert.ToInt32(txtRollNo.Text));
            command.Parameters.AddWithValue("@FirstName", txtFN.Text);
            command.Parameters.AddWithValue("@LastName", txtLN.Text);
            command.Parameters.AddWithValue("@Gender", txtGender.Text);
            command.Parameters.AddWithValue("@Age", Convert.ToInt32(txtAge.Text));
            command.Parameters.AddWithValue("@Address", txtAdd.Text);

            try
            {
                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                    MessageBox.Show("Student successfully added!");
                else
                    MessageBox.Show("Failed to add student!");
            }
            catch (SqlException)
            {
                MessageBox.Show("An error has occured!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}