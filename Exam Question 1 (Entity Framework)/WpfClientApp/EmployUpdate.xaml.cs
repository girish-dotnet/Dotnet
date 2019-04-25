using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Capgemini.EmployDetails.Entities;
using Capgemini.EmployDetails.BusinessLayer;

namespace WpfClientApp
{
    /// <summary>
    /// Interaction logic for EmployUpdate.xaml
    /// </summary>
    public partial class EmployUpdate : Window
    {
        public EmployUpdate()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int updateEmployID = Convert.ToInt32(txtEmpId.Text);
            Employ updatedEmploy = EmployBL.SearchEmployBL(updateEmployID);
            if(updatedEmploy!=null)
            {
                updatedEmploy.EmployName = txtEmpname.Text;
                updatedEmploy.Department = txtDepartment.Text;
                updatedEmploy.Salary = Convert.ToInt32(txtSalary.Text);
                bool employUpdated = EmployBL.UpdateEmployBL(updatedEmploy);
                if (employUpdated)
                {
                    MessageBox.Show("Record Updated...");
                }
            }
           
        }
    }
}
