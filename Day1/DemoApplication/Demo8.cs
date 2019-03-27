using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    /// <summary>
    /// Program to check the given number is +ve or -ve
    /// </summary>
    class Demo8
    {
        public void Check(int n)
        {
            if(n >= 0)
            {
                Console.WriteLine("Positive No");
            } 
            else
            {
                Console.WriteLine("Negative No");
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter N value  ");
            n = Convert.ToInt32(Console.ReadLine());
        }
    }
}
