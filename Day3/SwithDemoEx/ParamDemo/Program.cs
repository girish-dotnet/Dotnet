using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamDemo
{
    class Demo
    {
        public void Show(params int[] a)
        {
            foreach(int i in a)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Demo obj = new Demo();
            obj.Show();
            obj.Show(12);
            obj.Show(12, 5);
            obj.Show(12, 6, 23);
            obj.Show(12, 77, 34, 33);
        }
    }
}
