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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            List<Employee> lstEmployee = new List<Employee>()
            {
                new Employee { EmployeeID = 1,Name="Arun"},
                new Employee { EmployeeID = 2, Name = "Bhargav" },
                new Employee { EmployeeID = 3, Name = "Kiran" },
                new Employee { EmployeeID = 4, Name = "Dhivya" }
            };
            listView1.Items.Clear();
            for(int i=0;i<lstEmployee.Count;i++)
            {
                listView1.Items.Add(new ListViewItem(lstEmployee[i].EmployeeID.ToString()));
                listView1.Items[i].SubItems.Add(lstEmployee[i].Name);
            }
        }
    }
}
