using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopDemo1
{
    /// <summary>
    /// Program to demo about While Loop
    /// </summary>
    class Demo
    {
        /// <summary>
        /// Show method to Display content
        /// </summary>
        /// <param name="x"></param>
        public void Show(int x)
        {
            int i = 0; // Initialiation
            while(i < x) // Condition
            {
                Console.WriteLine("Welcome to C#");
                i++; // Increment
            }
        }
        static void Main(string[] args)
        {
            int n = 5;
            new Demo().Show(n);
        }
    }
}
