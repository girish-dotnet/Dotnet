using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQTOEFCRUDExamples
{
    public partial class Form1 : Form
    {
        EmployeeDatabaseEntities employeeContext = new EmployeeDatabaseEntities();
        Employee employee;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                BindDatatoGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindDatatoGrid()
        {
            dataGridView1.DataSource = employeeContext.Employees.ToList();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (txtFname.Text == "" || txtLname.Text == "" || txtEmail.Text == "" || cboGender.Text == "(Select Gender)" || cboDesign.Text == "(Select)")
            {
                MessageBox.Show("Please all the details properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Employee emp = new Employee();
                    emp.FirstName = txtFname.Text;
                    emp.LastName = txtLname.Text;
                    emp.Gender = cboGender.Text;
                    emp.DOB = dtpDOB.Text;
                    emp.Designation = cboDesign.Text;
                    emp.Email = txtEmail.Text;

                    employeeContext.Employees.Add(emp);
                    employeeContext.SaveChanges();
                    
                    MessageBox.Show("Employee Addedd Sucessfully....");

                    ResetFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ResetFields()
        {
            txtFname.Text = "";
            txtLname.Text = "";
            txtEmail.Text = "";
            cboDesign.ResetText();
            cboDesign.Text = "(Select)";
            cboGender.ResetText();
            cboGender.Text = "(Select Gender)";
            dtpDOB.ResetText();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                BindDatatoGrid();    
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                ResetFields();
            }
            else if (tabControl1.SelectedIndex==2)
            {
                ResetFields1();   
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtEmpID.Text == "")
            {
                MessageBox.Show("Please Enter Employee id for Search");
                txtEmpID.Focus();
            }
            else
            {
                int id = Convert.ToInt32(txtEmpID.Text);

                var emps = (from emp in employeeContext.Employees.Where
                                (emp => emp.Id == id)
                            select emp).FirstOrDefault();

                if(emps!=null)
                {
                    employee = emps;

                    txtFirstName.Text = employee.FirstName;
                    txtLastName.Text = employee.LastName;
                    txtEmailID.Text = employee.Email;
                    txtDob.Text = employee.DOB;
                    txtGender.Text = employee.Gender;
                    cboDesignation.Text = employee.Designation;
                }
                else
                {
                    MessageBox.Show("Invalid Employee Id , Employee not available");
                }
            }
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                employee.Designation = cboDesignation.Text;
                employee.Email = txtEmailID.Text;

                employeeContext.SaveChanges();

                MessageBox.Show("Employee Record updated sucessfully....");

                ResetFields1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ResetFields1()
        {
            txtEmpID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtGender.Text = "";
            txtDob.Text = "";
            txtEmailID.Text = "";
            cboDesignation.ResetText();
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                employeeContext.Employees.Remove(employee);
                employeeContext.SaveChanges();

                MessageBox.Show("Employee Record deleted Successfully.......");

                ResetFields1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
