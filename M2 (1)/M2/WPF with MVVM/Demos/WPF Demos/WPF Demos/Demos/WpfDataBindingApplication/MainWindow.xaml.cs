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
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
//using DAL;

namespace WpfDataBindingApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStudentsDetails_Click(object sender, RoutedEventArgs e)
        {
            //StudentOperations studOp = new StudentOperations();
            //DataView dv = studOp.GetStudentDetails(Convert.ToInt32(txtRollNo.Text));
            //grdStudents.ItemsSource = dv;
        }
        /// <summary>
        ///    Method to retrieve details of students
        ///    No of Parameters:0
        ///    Author:Nachiket Inamdar Date of Creation:19-October-2014
        /// </summary>
        /// <returns>DataView</returns>
        //public DataView GetStudentsDetails()
        //{
        //    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["demo"].ConnectionString);
        //    SqlCommand cmdStudentDetails = new SqlCommand("SELECT * FROM Students_824447 WHERE RollNo="+txtRollNo.Text+"", con);
        //    if (con.State == ConnectionState.Closed)
        //    {
        //        con.Open();
        //    }
        //    SqlDataReader cmdStudentDetailsReader = cmdStudentDetails.ExecuteReader();
        //    DataTable cmdStudentDetailsTable = new DataTable();
        //    cmdStudentDetailsTable.Load(cmdStudentDetailsReader);
        //    return cmdStudentDetailsTable.DefaultView;
        //}

       
    }
}
