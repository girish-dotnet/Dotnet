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
    /// Interaction logic for EmploySearch.xaml
    /// </summary>
    public partial class EmploySearch : Window
    {
        public EmploySearch()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int searchEmployID = Convert.ToInt32(txtEmpId.Text);
            Employ searchEmploy = EmployBL.SearchEmployBL(searchEmployID);
            if(searchEmploy!=null)
            {
                txtEmpname.Text = searchEmploy.EmployName;
                txtSalary.Text = searchEmploy.Salary.ToString();
                txtDepartment.Text = searchEmploy.Department;
            }
        }
    }
}
