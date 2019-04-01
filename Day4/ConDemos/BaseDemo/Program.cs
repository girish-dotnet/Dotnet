using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDemo
{
    class C1
    {
        public void Show()
        {
            Console.WriteLine("Show From class C1...");
        }
    }

    class C2 : C1
    {
        public new  void Show()
        {
            base.Show();
            Console.WriteLine("Show From Class C2...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            C2 ob = new C2();
            ob.Show();
        }
    }
}
