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

namespace LayoutPanels
{
    /// <summary>
    /// Interaction logic for DataBind1.xaml
    /// </summary>
    public partial class DataBind1 : Window
    {
        public DataBind1()
        {
            InitializeComponent();
            this.DataContext = person;
        }

        Person person = new Person { Name = "Arun", Age = 22 };

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string message = person.Name + " is " + person.Age;
            MessageBox.Show(message);

        }
    }
}
