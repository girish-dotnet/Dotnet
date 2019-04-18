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
    public partial class Demo05 : Form
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private SqlCommandBuilder builder;
        private DataSet dataSet;
        bool updateReady = false;
        bool insertReady = false;

        public Demo05()
        {
            InitializeComponent();
        }

        private void ClearFields()
        {
            txtFN.Text = String.Empty;
            txtLN.Text = String.Empty;
            txtGender.Text = String.Empty;
            txtAge.Text = String.Empty;
            txtAddress.Text = String.Empty;
        }

        private int GetNextEmployeeID()
        {
            command.CommandText = "SELECT IDENT_CURRENT('Employee') + IDENT_INCR('Employee')";

            try
            {
                connection.Open();
                int nextID = Convert.ToInt32(command.ExecuteScalar());
                return nextID;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return 0;
        }

        private void Demo05_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
            
            command = connection.CreateCommand();
            adapter = new SqlDataAdapter(command);
            builder = new SqlCommandBuilder(adapter);
            dataSet = new DataSet();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            command.CommandText = "SELECT * FROM Employee WHERE EmpId=@EmployeeID";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@EmployeeID", Convert.ToInt32(txtEmpID.Text));

            dataSet.Tables.Clear();

            int result = adapter.Fill(dataSet, "Employee");

            if (result > 0)
            {
                DataRow employee = dataSet.Tables["Employee"].Rows[0];
                txtFN.Text = employee["FirstName"].ToString();
                txtLN.Text = employee["LastName"].ToString();
                txtGender.Text = employee["Gender"].ToString();
                txtAge.Text = employee["Age"].ToString();
                txtAddress.Text = employee["Address"].ToString();
            }
            else
            {
                ClearFields();
                MessageBox.Show("Employee does not exist.");
            }

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (!insertReady)
            {
                btnAddNew.Text = "Insert";
                ClearFields();
                txtEmpID.Text = GetNextEmployeeID().ToString();

                txtEmpID.Enabled = false;
                txtFN.Enabled = true;
                txtLN.Enabled = true;
                txtGender.Enabled = true;
                txtAddress.Enabled = true;
                txtAge.Enabled = true;
                btnShow.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                insertReady = true;
            }
            else
            {
                btnAddNew.Text = "Add New";

                command.CommandText = "SELECT * FROM Employee";
                dataSet.Tables.Clear();
                adapter.Fill(dataSet, "Employee");

                DataRow row = dataSet.Tables["Employee"].NewRow();
                row["FirstName"] = txtFN.Text;
                row["LastName"] = txtLN.Text;
                row["Gender"] = txtGender.Text;
                row["Age"] = Convert.ToInt32(txtAge.Text);
                row["Address"] = txtAddress.Text;

                dataSet.Tables["Employee"].Rows.Add(row);
                MessageBox.Show("Current Row Status : " + row.RowState.ToString());
                try
                {
                    int result = adapter.Update(dataSet, "Employee");

                    if (result > 0)
                    {
                        MessageBox.Show("Employee successfully added.");
                        
                    }
                    else
                        MessageBox.Show("Failed to add employee.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                txtEmpID.Enabled = true;
                txtFN.Enabled = false;
                txtLN.Enabled = false;
                txtGender.Enabled = false;
                txtAge.Enabled = false;
                txtAddress.Enabled = false;
                btnShow.Enabled = true;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                insertReady = false;
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!updateReady)
            {
                btnEdit.Text = "Update";
                txtEmpID.Enabled = false;
                txtFN.Enabled = true;
                txtLN.Enabled = true;
                txtGender.Enabled = true;
                txtAge.Enabled = true;
                txtAddress.Enabled = true;
                btnShow.Enabled = false;
                btnAddNew.Enabled = false;
                btnDelete.Enabled = false;
                updateReady = true;
            }
            else
            {
                btnEdit.Text = "Edit";
                command.CommandText = "SELECT * FROM Employee";
                dataSet.Tables.Clear();
                adapter.Fill(dataSet, "Employee");

                foreach (DataRow employee in dataSet.Tables["Employee"].Rows)
                {
                    if (employee["EmpID"].ToString() == txtEmpID.Text)
                    {
                        employee["FirstName"] = txtFN.Text;
                        employee["LastName"] = txtLN.Text;
                        employee["Gender"] = txtGender.Text;
                        employee["Age"] = txtAge.Text;
                        employee["Address"] = txtAddress.Text;

                        MessageBox.Show("Current Row Status : " + employee.RowState.ToString());
                    }
                }

                try
                {
                    int result = adapter.Update(dataSet, "Employee");

                    if (result > 0)
                        MessageBox.Show("Update successful.");
                    else
                        MessageBox.Show("Failed to update.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                txtEmpID.Enabled = true;
                txtFN.Enabled = false;
                txtLN.Enabled = false;
                txtGender.Enabled = false;
                txtAge.Enabled = false;
                txtAddress.Enabled = false;
                btnShow.Enabled = true;
                btnAddNew.Enabled = true;
                btnDelete.Enabled = true;
                updateReady = false;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            command.CommandText = "SELECT * FROM Employee";
            dataSet.Tables.Clear();
            adapter.Fill(dataSet, "Employee");

            foreach (DataRow employee in dataSet.Tables["Employee"].Rows)
            {
                if (employee["EmpId"].ToString() == txtEmpID.Text)
                {
                    employee.Delete();
                    MessageBox.Show("Current Row Status : " + employee.RowState.ToString());
                    break;
                }
            }

            try
            {
                int result = adapter.Update(dataSet, "Employee");

                if (result > 0)
                    MessageBox.Show("Employee successfully deleted.");
                else
                    MessageBox.Show("Failed to delete Employee.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            command.CommandText = "SELECT * FROM Employee";
            adapter.Fill(dataSet, "Employee");
        }

        private void btnRowState_Click(object sender, EventArgs e)
        {
            //Iterate through Rows of DataTable and display RowStates .....

            foreach (DataRow drow in dataSet.Tables["appusers"].Rows)
            {
                if (drow.RowState == DataRowState.Deleted)
                {
                    MessageBox.Show(
                        drow["username", DataRowVersion.Original].ToString() + " deleted ");
                }
                else
                    MessageBox.Show(drow["username"].ToString() + "  "
                                + drow.RowState.ToString());
            }

        }       

     }
}