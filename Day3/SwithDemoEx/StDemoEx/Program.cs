using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StDemoEx
{
    class Data
    {
        public static void Login()
        {
            Console.WriteLine("Login by 9 AM Sharp");
        }
    }
    class Demo
    {
        public static void Show()
        {
            Console.WriteLine("Show method from Demo...");
        }

        public static void Logout()
        {
            Console.WriteLine("Logout by 8.30 Today");
        }
        static void Main(string[] args)
        {
            Show();
            Logout();
            Data.Login();
        }
    }
}
