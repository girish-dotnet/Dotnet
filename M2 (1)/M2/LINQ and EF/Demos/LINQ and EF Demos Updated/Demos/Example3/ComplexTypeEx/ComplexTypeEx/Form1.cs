using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace ComplexTypeEx
{
    public partial class Form1 : Form
    {
        CustomerModelContainer customerContext;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                customerContext = new CustomerModelContainer();

                Customer cust1 = new Customer();
                Name custName1 = new Name { FirstName="Asdin",LastName="Dhalla" };
                Contact custContact1 = new Contact {MobileNo=98273263772,Email="asdin.dhalla@gmail.com" };
                cust1.CustomerName = custName1;
                cust1.CustomerContact = custContact1;
                cust1.Status = "Active";

                Customer cust2 = new Customer();
                Name custName2 = new Name { FirstName = "Malcolm", LastName = "Daruwalla" };
                Contact custContact2 = new Contact { MobileNo = 98278663772, Email = "malcolm.daruwalla@gmail.com" };
                cust2.CustomerName = custName2;
                cust2.CustomerContact = custContact2;
                cust2.Status = "Active";

                customerContext.Customers.Add(cust1);
                customerContext.Customers.Add(cust2);

                customerContext.SaveChanges();

                //dataGridView1.DataSource = customerContext.Customers.ToList();
                var query = from cust in customerContext.Customers
                            select new { cust.Id,cust.CustomerName.FirstName,cust.CustomerName.LastName,cust.CustomerContact.MobileNo,cust.CustomerContact.Email };

                dataGridView1.DataSource = query.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
