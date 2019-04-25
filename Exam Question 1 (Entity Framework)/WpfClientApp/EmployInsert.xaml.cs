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
    /// Interaction logic for EmployInsert.xaml
    /// </summary>
    public partial class EmployInsert : Window
    {
        public EmployInsert()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Employ newEmploy = new Employ();
            newEmploy.EmployName = txtEmpname.Text;
            newEmploy.Department = txtDepartment.Text;
            newEmploy.Salary = Convert.ToInt32(txtSalary.Text);
            bool employAdded = EmployBL.AddEmployBL(newEmploy);
            if(employAdded)
            {
                MessageBox.Show("Employ Record Added...");
            }
        }
    }
}
