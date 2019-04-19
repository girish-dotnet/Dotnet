using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo4new
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            AppEvents.ShowEmployeeEvent += new DisplayEmployeeHandler(ShowEmployee);
        }

        void ShowEmployee(Employee employee)
        {
            txtEmployeeID.Text = employee.EmployeeID.ToString();
            txtEmployeeName.Text = employee.Name;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
