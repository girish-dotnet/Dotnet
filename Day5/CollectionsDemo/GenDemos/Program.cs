using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenDemos
{
    class GenTest
    {
        public static void Swap<T>(ref T x, ref T y)
        {
            T t;
            t = x;
            x = y;
            y = t;
        }
        static void Main(string[] args)
        {
            int a = 5, b = 7;
            Swap<int>(ref a, ref b);
            Console.WriteLine($"A value {a} B value {b}");
            double d1 = 12.5, d2 = 56.23;
            Swap<double>(ref d1, ref d2);
            Console.WriteLine($"A value {d1} B value {d2}");
            string s1 = "Tamil", s2 = "Selva";
            Swap<string>(ref s1, ref s2);
            Console.WriteLine($"A value {s1} B value {s2}");

        }
    }
}
