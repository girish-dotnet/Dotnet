using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCustomer
{
    class Customer
    {
        public int CustId { get; set; }
        public string CustName { get; set; }
        public double Premium { get; set; }
        public int PayMode { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer obj = new Customer();
            Console.WriteLine("Enter CustID, Name, Premium and PayMode ");
            obj.CustId = Convert.ToInt32(Console.ReadLine());
            obj.CustName = Console.ReadLine();
            obj.Premium = Convert.ToDouble(Console.ReadLine());
            obj.PayMode = Convert.ToInt32(Console.ReadLine());
        }
    }
}
