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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Capgemini.ProductDetails.Entities;
using Capgemini.ProductDetails.BusinessLayer;
using Capgemini.ProductDetails.Exceptions;

namespace Capgemini.ProductDetails.PresentationLayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cmdProductType.Items.Add("Mobiles");
            cmdProductType.Items.Add("Cameras");
            cmdProductType.Items.Add("Laptop");
            cmdProductType.Items.Add("Appliances");
            cmdProductType.Items.Add("Accessories");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Product product = new Product();
            product.ProductName = txtProductName.Text;
            product.SerialNumber = txtSerialNo.Text;
            product.BrandName = txtBrandName.Text;
            product.ProductType = cmdProductType.Text;
            product.ProductDescription = txtProductDescription.Text;
            product.Price = Convert.ToInt32(txtProductPrice.Text);
            bool res = ProductBL.AddProductBL(product);
            MessageBox.Show(res.ToString());
        }
    }
}
