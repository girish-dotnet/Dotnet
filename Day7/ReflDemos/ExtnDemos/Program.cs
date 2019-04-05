using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtnDemos
{
    /// <summary>
    /// Extension Methods
    /// </summary>
    static class ExtnDemo
    {
        public static int Sum(this int p,int x,int y)
        {
            return x + y;
        } 

        public static string Lunch(this int s)
        {
            return "Lunch time by 2 PM";
        }
        public static string SayHello(this string s)
        {
            return "Welcome to C# Extension Methods...";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Welcome";
            Console.WriteLine(s);
            Console.WriteLine(s.SayHello());

            int i = 12;
            Console.WriteLine(i.Lunch());

            Console.WriteLine(i.Sum(65,66));
            
        }
    }
}








