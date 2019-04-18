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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections.ObjectModel;


namespace ObservableCollectionWithDatabase
{
    public partial class MainWindow : Window
    {
        SqlConnection conn;
        SqlCommand cmd;
        public MainWindow()
        {
            InitializeComponent();
        }

        public ObservableCollection<Student> Display()
        {

            StringBuilder sb = new StringBuilder();
            try
            {
                ObservableCollection<Student> list = new ObservableCollection<Student>();

                conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString);

                conn.Open();

                cmd = new SqlCommand("SELECT * FROM StudentDetails", conn);

                SqlDataReader dr = cmd.ExecuteReader();

                Student s;

                while (dr.Read())
                {
                    s = new Student();
                    s.StudentID = dr.GetInt32(0);
                    s.StudentName = dr.GetString(1);
                    list.Add(s);
                }

                dr.Close();
                conn.Close();
                return list;

            }
            catch (SqlException ex)
            {

                sb.Append(Environment.NewLine + ex.Message);
            }

            return null;
        }

        private void btnStudentsDetails_Click(object sender, RoutedEventArgs e)
        {
            ObservableCollection<Student> students = Display();
            grdStudents.ItemsSource = students;
            //cmdCustomerID.ItemsSource = students;
        }
    }
}
