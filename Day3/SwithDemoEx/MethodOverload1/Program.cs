using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload1
{
    class Demo
    {
        public void Show(int x)
        {
            Console.WriteLine("Show With Integer " +x);
        }
        public void Show(double x)
        {
            Console.WriteLine("Show With Double " +x);
        }

        public void Show(string x)
        {
            Console.WriteLine("Show with String " +x);
        }

        static void Main(string[] args)
        {
            Demo obj = new Demo();
            obj.Show(12);
            obj.Show(12.5);
            obj.Show("Arun");
        }
    }
}




