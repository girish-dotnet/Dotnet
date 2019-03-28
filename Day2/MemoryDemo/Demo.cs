using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryDemo
{
    class Demo
    {
        int x;
        static void Main(string[] args)
        {
            Demo obj1 = new Demo();
            obj1.x = 12;
            Demo obj2 = obj1;
            obj2.x = 13;
            Console.WriteLine(obj1.x);
            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());
        }
    }
}
