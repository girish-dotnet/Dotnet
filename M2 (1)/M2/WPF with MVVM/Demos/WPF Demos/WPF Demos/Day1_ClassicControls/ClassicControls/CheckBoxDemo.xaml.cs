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

namespace ClassicControls
{
    /// <summary>
    /// Interaction logic for CheckBoxDemo.xaml
    /// </summary>
    public partial class CheckBoxDemo : Window
    {
        public CheckBoxDemo()
        {
            InitializeComponent();
        }

        private void Lst_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Select when checkbox portion is clicked (optional).
            if (e.OriginalSource is CheckBox)
            {
                lst.SelectedItem = e.OriginalSource;
            }
            if (lst.SelectedItem == null) return;
            txtSelection.Text = String.Format(
         "You chose item at position {0}.\r\nChecked state is {1}.",
                lst.SelectedIndex,
                ((CheckBox)lst.SelectedItem).IsChecked);
        }
    }
}
