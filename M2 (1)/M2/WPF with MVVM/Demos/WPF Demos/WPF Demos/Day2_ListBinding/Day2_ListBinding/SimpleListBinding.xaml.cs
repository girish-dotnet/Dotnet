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

namespace Day2_ListBinding
{
    /// <summary>
    /// Interaction logic for SimpleListBinding.xaml
    /// </summary>
    public partial class SimpleListBinding : Window
    {
        private BookFactory factory = new BookFactory();
        public SimpleListBinding()
        {
            InitializeComponent();
            this.DataContext = factory.GetBooks();
        }
    }
}
