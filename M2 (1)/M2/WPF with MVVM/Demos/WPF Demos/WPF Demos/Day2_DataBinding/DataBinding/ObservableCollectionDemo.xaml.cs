using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for ObservableCollectionDemo.xaml
    /// </summary>
    public partial class ObservableCollectionDemo : Window
    {
        private ObservableCollection<Customer> customer;
        public ObservableCollectionDemo()
        {
            InitializeComponent();
            customer = new ObservableCollection<Customer>()
            {
                new Customer(){FirstName="Amit", LastName="Desai",ContactPerson="Sujay", ContactNo=9988776655},
                new Customer(){FirstName="Manoj", LastName="Joshi",ContactPerson="Amol", ContactNo=9876543210}
            };
            lstCustomerDetails.ItemsSource = customer;
        }

        private void btnAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            Customer customerObj = new Customer {FirstName=txtFirstName.Text,LastName=txtLastName.Text,ContactNo=long.Parse(txtContactNo.Text),ContactPerson=txtContactPerson.Text };
            customer.Add(customerObj);
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtContactNo.Text = string.Empty;
            txtContactPerson.Text = string.Empty;
        }
    }
}
