using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo05
{
    public partial class Layouts : Form
    {
        public Layouts()
        {
            InitializeComponent();
        }

        private void Layouts_Load(object sender, EventArgs e)
        {
            LoadEmployees();
            treeView1.ExpandAll();
        }

        private void LoadEmployees()
        {
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(new Employee { EmployeeID = 101, EmployeeName = "Karthik", Location = "Bangalore" });
            employeeList.Add(new Employee { EmployeeID = 102, EmployeeName = "JeyaVidhya", Location = "Bangalore" });
            employeeList.Add(new Employee { EmployeeID = 103, EmployeeName = "Ganesh Desai", Location = "Mumbai" });
            employeeList.Add(new Employee { EmployeeID = 104, EmployeeName = "Ajit Jog", Location = "Mumbai" });
            employeeList.Add(new Employee { EmployeeID = 105, EmployeeName = "Shilpa Bhosle", Location = "Mumbai" });
            employeeList.Add(new Employee { EmployeeID = 106, EmployeeName = "SelvaLakshmi", Location = "Chennai" });

            listView1.Items.Clear();
            for (int counter = 0; counter < employeeList.Count; counter++)
            {
                listView1.Items.Add(new ListViewItem(employeeList[counter].EmployeeID.ToString()));
                listView1.Items[counter].SubItems.Add(employeeList[counter].EmployeeName);
                listView1.Items[counter].SubItems.Add(employeeList[counter].Location);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
