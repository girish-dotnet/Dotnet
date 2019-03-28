
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    /// <summary>
    /// Program to check max of 3 numbers.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Method to Check Max of 3 numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public void Check(int a,int b,int c)
        {
            int m = a;
            if(m < b)
            {
                m = b;
            }
            if(m < c)
            {
                m = c;
            }
            Console.WriteLine($"Max Value {m}");
        }
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter 3 Numbers   ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            new Program().Check(a, b, c);
        }
    }
}
