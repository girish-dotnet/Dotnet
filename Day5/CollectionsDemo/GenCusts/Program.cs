using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenCusts
{
    class SortByPremium : IComparer<Customer>
    {
        public int Compare(Customer c1,Customer c2)
        {
            if (c1.Premium >= c2.Premium)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }
    class Customer
    {
        public int CustId { get; set; }
        public string CustName { get; set; }
        public double Premium { get; set; }
        public string Gender { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> lstCustomer = new List<Customer>()
            {
                new Customer{CustId=1,CustName="Arun",Gender="Male",Premium=82344},
                new Customer{CustId=2,CustName="Siva",Gender="Male",Premium=78344},
                new Customer{CustId=3,CustName="Priya",Gender="Female",Premium=81111},
                new Customer{CustId=4,CustName="Sangeetha",Gender="Female",Premium=777888},
                new Customer{CustId=5,CustName="Jitu",Gender="Male",Premium=81224}
            };

            lstCustomer.Sort(new SortByPremium());
            foreach(Customer c in lstCustomer)
            {
                Console.WriteLine(c.CustId + " " +c.CustName + " " +c.Gender + " " +c.Premium);
            }
        }
    }
}
