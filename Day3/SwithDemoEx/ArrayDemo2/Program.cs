using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo2
{
    class Demo
    {
        public void ArrayEx()
        {
            int[] a = new int[5];
            Console.WriteLine("Enter 5 Elements");
            for(int i=0;i<5;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Elements of Array are ");
            foreach(int i in a)
            {
                Console.WriteLine(i);
            }
            Array.Sort(a);
            Console.WriteLine("Sorted List ");
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
