using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Arun", s2 = "Pallavi", s3 = "Priya", s4 = "Arun";
            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());
            Console.WriteLine(s3.GetHashCode());
            Console.WriteLine(s4.GetHashCode());
        }
    }
}
