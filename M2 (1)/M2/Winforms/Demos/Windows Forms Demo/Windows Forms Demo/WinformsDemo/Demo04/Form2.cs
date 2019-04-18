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
     
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            AppEvents.AddEvent += new CalculationHandler(AddNumbers);
            AppEvents.ShowEmployeeEvent += new DisplayEmployeeHandler(ShowEmployee);
            AppEvents.ShowStudentEvent += new EventHandler(ShowStudent);
        }

        void ShowStudent(object sender, EventArgs e)
        {

            // Student student = ((Student)((AppEventArgs)e).Info);
            AppEventArgs ae = (AppEventArgs)e;
            Student student  = (Student)ae.Info;
            txtStudentID.Text = student.StudentID.ToString();
            txtStudentName.Text = student.StudentName;
        }

        void ShowEmployee(Employee employee)
        {
            txtEmployeeID.Text = employee.EmployeeID.ToString();
            txtEmployeeName.Text = employee.Name;
        }

        void AddNumbers(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            txtResult.Text = result.ToString();   
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
