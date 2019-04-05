using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deleg2
{
    class Demo
    {
        public delegate void Test(int n);

        public static void Check(int n)
        {
            if(n%2==0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
        }
        static void Main(string[] args)
        {
            Test obj = new Test(Check);
            obj(5);
        }
    }
}
