using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactRef
{
    class Fact
    {
        /// <summary>
        /// Calc method for Factorial Logic
        /// </summary>
        /// <param name="n"></param>
        /// <param name="f"></param>
        public void Calc(int n,ref int f)
        {
            for(int i=1;i<=n;i++)
            {
                f = f * i;
            }
        }
        /// <summary>
        /// Main Method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int n, f = 1;
            Console.WriteLine("Enter N value  ");
            n = Convert.ToInt32(Console.ReadLine());
            new Fact().Calc(n, ref f);
            Console.WriteLine($"Factorial {f}");
        }
    }
}
