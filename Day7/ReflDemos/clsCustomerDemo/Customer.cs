using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsCustomerDemo
{
    public class Customer
    {
        public int custId;
        public string custName;
        public double premium;
        public string city;

        public void Hello()
        {
            Console.WriteLine("Good Morning all...");
        }

        public void Lunch()
        {
            Console.WriteLine("No Lunch Today...");
        }

        public void Logout()
        {
            Console.WriteLine("Logout By 8 PM Today...");
        }

        public int Sum(int x,int y)
        {
            return x + y;
        }

        public int Fact(int n)
        {
            int f = 1;
            for(int i=1;i<=n;i++)
            {
                f = f * i;
            }
            return f;
        }
    }
}
