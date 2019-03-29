using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingDemo
{
    class Box1
    {
        public void Show()
        {
            int x = 12;
            double y = 12.5;
            string name = "Arun";

            /* Implementing Boxing */
            object ob1 = x;
            object ob2 = y;
            object ob3 = name;

            /* Implemeting Unboxing */

            int x1 = (Int32)ob1;
            double y1 = (Double)ob2;
            string n1 = (string)ob3;

            Console.WriteLine($"After Unboxing {x1} {y1} {n1}");
        }
        static void Main(string[] args)
        {
            
        }
    }
}
