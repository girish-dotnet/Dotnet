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
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for WPFWithDatabase.xaml
    /// </summary>
    public partial class WPFWithDatabase : Window
    {
        public WPFWithDatabase()
        {
            InitializeComponent();
        }

        private void btnGetCategories_Click(object sender, RoutedEventArgs e)
        {
            DataView dv = GetCategories();
            dgCategories.ItemsSource = dv;
        }
        /// <summary>
        ///    Method to retrieve category details
        ///    No of Parameters:0
        ///    Author:Nachiket Inamdar 
        ///    Date of Creation:26-September-2016
        /// </summary>
        /// <returns>DataView</returns>
        public DataView GetCategories()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["WPFConnString"].ConnectionString);
            SqlCommand cmdCategories = new SqlCommand("SELECT * FROM Emp", con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader categoriesReader = cmdCategories.ExecuteReader();
            DataTable cmdCategoriesTable = new DataTable();
            cmdCategoriesTable.Load(categoriesReader);
            return cmdCategoriesTable.DefaultView;
        }
        
    }
}
