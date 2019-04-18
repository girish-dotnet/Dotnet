using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo04
{
    public partial class Form1 : Form
    {
        private Form1()
        {
            InitializeComponent();
        }

        private void btnAddNumbers_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(txtFirstNumber.Text);
            int secondNumber = Convert.ToInt32(txtSecondNumber.Text);
            AppEvents.OnAddEvent(firstNumber, secondNumber);
        }

        private void btnShowEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.EmployeeID = Convert.ToInt32(txtEmployeeID.Text);
            employee.Name = txtEmployeeName.Text;
            AppEvents.OnShowEmployeeEvent(employee);
        }

        private void btnShowStudentDetails_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.StudentID = Convert.ToInt32(txtStudentID.Text);
            student.StudentName = txtStudentName.Text;

            AppEventArgs ae = new AppEventArgs();
            ae.Info = student;
          
            AppEvents.OnShowStudentEvent(sender, ae);
            
            //AppEvents.OnShowStudentEvent(sender, new AppEventArgs(student));

        }

        private void txtEmployeeID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmployeeName_Click(object sender, EventArgs e)
        {

        }

        private void txtEmployeeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmployeeID_Click(object sender, EventArgs e)
        {

        }
    }

}
