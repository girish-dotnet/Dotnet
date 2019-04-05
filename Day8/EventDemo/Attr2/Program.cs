using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attr2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Attributes sample");
            TestMethod();
            Console.ReadKey();
        }
        [Obsolete("Deprecated Method", false)]
        public static void TestMethod()
        {
            Console.WriteLine("Hello world");
        }
    }
}
