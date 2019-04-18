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
    /// Interaction logic for Sp2.xaml
    /// </summary>
    public partial class Sp2 : Window
    {
        public Sp2()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            stackPanel1.Orientation = Orientation.Vertical;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {

        }
    }
}
