using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace DataBinding
{
    /// <summary>
    /// Interaction logic for EmployBinding.xaml
    /// </summary>
    public partial class EmployBinding : Window
    {
        public EmployBinding()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string strcon = ConfigurationManager.
                ConnectionStrings["sqlpracticeConn"].ConnectionString;
            SqlConnection cnSqlpractice = new SqlConnection(strcon);
            cnSqlpractice.Open();
            SqlCommand cmdSelect = new SqlCommand("SELECT * FROM EMP", cnSqlpractice);
            SqlDataReader dr = cmdSelect.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            DataView dv = new DataView(dt);
            dgEmp.ItemsSource = dv;
        }
    }
}
