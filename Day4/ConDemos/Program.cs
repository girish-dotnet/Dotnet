using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConDemos
{
    class Demo
    {
        static Demo()
        {
            Console.WriteLine("Static Constructor...");
        }
        public Demo()
        {
            Console.WriteLine("Instance Constructor...");
        }
        ~Demo()
        {
            Console.WriteLine("Destructor Fired...");
        }
        static void Main(string[] args)
        {
            Demo obj = new Demo();

        }
    }
}
