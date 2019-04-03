using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Welcome to C#";
            Console.WriteLine("Length  " +str.Length);
            Console.WriteLine("Position of P " +str.IndexOf("P"));
            string s2 = "Welcome to C#";
            Console.WriteLine(str.Equals(s2));
            string res = s2.Substring(3, 5);
            Console.WriteLine(res);
            string s3 = "Hello";
            string s1 = "hello";
            Console.WriteLine(s1.CompareTo(s3));
            Console.WriteLine(s3.CompareTo(s1));
            Console.WriteLine(str.CompareTo(s2));
       }
    }
}
