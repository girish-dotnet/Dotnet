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
    /// Interaction logic for Calc.xaml
    /// </summary>
    public partial class Calc : Window
    {
        public Calc()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(firstNo.Text);
            b = Convert.ToInt32(secondNo.Text);
            c = a + b;
            result.Text = c.ToString();
        }
    }
}
