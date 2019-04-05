using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    class Demo
    {
        public delegate void Hello();

        public static void Login()
        {
            Console.WriteLine("Everyone Please login by 9 AM ");
        }
        static void Main(string[] args)
        {
            Hello obj = new Hello(Login);
            obj();
        }
    }
}
