using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCastDemo
{
    class Program
    {
        public delegate void Demo();
        public static void Login()
        {
            Console.WriteLine("Login at 9 AM Sharp");
        }
        public static void Lunch()
        {
            Console.WriteLine("Lunch at 1 PM ");
        }
        public static void Logout()
        {
            Console.WriteLine("Logout by 8 PM");
        }
        static void Main(string[] args)
        {
            Demo obj = new Demo(Login);
            obj += new Demo(Lunch);
            obj += new Demo(Logout);
            obj();
            Console.WriteLine("Delegate after Minus ");
            obj -= new Demo(Lunch);
            obj();
        }
    }
}
