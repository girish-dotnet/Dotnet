using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstApproachEx
{
    public partial class Form1 : Form
    {
        EmployeeContext empContext;
        Employee emp;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (txtFName.Text == "" || txtLName.Text == "" || cboDesignation.Text == "(Select)")
            {
                MessageBox.Show("Please provide all the details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    emp = new Employee();
                    emp.FirstName = txtFName.Text;
                    emp.LastName = txtLName.Text;
                    emp.DOB = Convert.ToDateTime(dtpDOB.Text);
                    emp.Designation = cboDesignation.Text;

                    empContext.Employees.Add(emp);//Adds the employee object to the entity set
                    empContext.SaveChanges();//Commits the change to the database;

                    MessageBox.Show("Employee Record Inserted", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    emp = null;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            empContext = new EmployeeContext();
        }

        private void ResetFields()
        {
            txtLName.Text = "";
            txtFName.Text = "";
            dtpDOB.ResetText();
            cboDesignation.ResetText();
            cboDesignation.Text = "(Select)";
        }
    }
}
