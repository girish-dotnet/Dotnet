using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialDemo
{
    class Fact
    {
        public void Calc(int n)
        {
            int i = 1, f = 1;
            while(i <= n)
            {
                f = f * i;
                i++;
            }
            Console.WriteLine($"Factorial {f}");
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter N value ");
            n = Convert.ToInt32(Console.ReadLine());
        }
    }
}
