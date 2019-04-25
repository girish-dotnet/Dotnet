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
using Capgemini.CertificationDetails.Entities;
using Capgemini.CertificationDetails.Exceptions;
using Capgemini.CertificationDetails.BusinessLayer;

namespace Capgemini.CertificationDetails.Presentation
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Certificates res = CertificatesBL.SearchCertificateBL(txtVoucherNumber.Text);
            if(res!=null)
            {
                lblResParticipantname.Content = res.ParticipantName;
            }
            else
            {
                MessageBox.Show("Voucher Number " + txtVoucherNumber.Text + " Does not exist");
            }
        }
    }
}
