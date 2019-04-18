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
    public partial class Demo04 : Form
    {
        string sqlConnectString = "Data Source=VM-iLearn;Initial Catalog=Training;User ID=lab3;Password=lab3@igate";

        public Demo04()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(sqlConnectString);
            SqlCommand command = new SqlCommand();

            command.Connection = connection;

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "prcStudentDetails";
            SqlParameter Param1 = new SqlParameter("@RollNo", SqlDbType.Int);
            command.Parameters.Add(Param1);
            command.Parameters["@RollNo"].Value = txtRollNo.Text;


            connection.Open();
            SqlDataReader dr;
            dr = command.ExecuteReader();
            while(dr.Read())
            {
                    txtFN.Text = dr["FirstName"].ToString();
                    txtLN.Text = dr[1].ToString();
                    txtGender.Text = dr.GetString(2);
                    txtAge.Text = dr.GetInt32(3).ToString();
                    txtAdd.Text = dr.GetString(4);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(sqlConnectString);
            SqlCommand command = new SqlCommand();


            command.Connection = connection;
            command.CommandText = "UPDATE DN05MayStudent SET FirstName=@FirstName, " +
            "LastName=@LastName, Gender=@Gender, Age=@Age, Address=@Address " +
            "WHERE RollNo=@RollNo";

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@FirstName", txtFN.Text);
            command.Parameters.AddWithValue("@LastName", txtLN.Text);
            command.Parameters.AddWithValue("@Gender", txtGender.Text);
            command.Parameters.AddWithValue("@Age", Convert.ToInt32(txtAge.Text));
            command.Parameters.AddWithValue("@Address", txtAdd.Text);
            command.Parameters.AddWithValue("@RollNo", Convert.ToInt32(txtRollNo.Text));

            try
            {
                connection.Open();
                int result = command.ExecuteNonQuery();

                if (result > 0)
                    MessageBox.Show("Update Successful!");
                else
                    MessageBox.Show("Update Failed!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occured.");
            }
            finally
            {
                connection.Close();
            }   
        }
    }
}
