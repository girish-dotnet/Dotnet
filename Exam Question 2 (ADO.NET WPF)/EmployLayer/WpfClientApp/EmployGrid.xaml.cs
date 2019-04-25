using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Reflection;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Capgemini.EmployDetails.Entities;
using Capgemini.EmployDetails.BusinessLayer;

namespace WpfClientApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class EmployGrid : Window
    {
        public EmployGrid()
        {
            InitializeComponent();
            DataSet employList = EmployBL.GetAllEmployBL();
            DataTable dt = employList.Tables[0];
            grid1.DataContext = dt.DefaultView;
        }

        private void BtnEmployGrid_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
