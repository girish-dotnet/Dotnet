using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhc
{
    class C1
    {
        static C1()
        {
            Console.WriteLine("base class static constructor...");
        }
        public C1()
        {
            Console.WriteLine("Base Class Constructor...");
        }
        ~C1()
        {
            Console.WriteLine("Base Class Destructor...");
        }
    }
    class C2 : C1
    {
        static C2()
        {
            Console.WriteLine("Derived class static constructor...");
        }
        public C2()
        {
            Console.WriteLine("Derived Class Constructor...");
        }
        ~C2()
        {
            Console.WriteLine("Derived Class Destructor...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
