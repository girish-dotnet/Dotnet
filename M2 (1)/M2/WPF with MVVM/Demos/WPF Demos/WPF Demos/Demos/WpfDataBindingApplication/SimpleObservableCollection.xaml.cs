using System;
using System.Collections.Generic;
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
using System.Collections.ObjectModel;

namespace WpfDataBindingApplication
{
    /// <summary>
    /// Interaction logic for SimpleObservableCollection.xaml
    /// </summary>
    public partial class SimpleObservableCollection : Window
    {
        private ObservableCollection<Person> person;
        public SimpleObservableCollection()
        {
            InitializeComponent();
            person = new ObservableCollection<Person>()
            {
                new Person(){Name="Amit", Address="India"},
                new Person(){Name="Sujay",Address="UK"}
            };
            lstNames.ItemsSource = person;
        }

        private void btnAddNames_Click(object sender, RoutedEventArgs e)
        {
            person.Add(new Person() { Name = txtName.Text, Address = txtAddress.Text });
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtName.Focus();
        }
    }
}
