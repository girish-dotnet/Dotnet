using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrExDemo
{
    class Demo
    {
        public void Show()
        {
            int[] a = new int[] { 12, 5 };
            try
            {
                a[10] = 62;
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Array Size is Small...");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static void Main(string[] args)
        {
            new Demo().Show();
        }
    }
}
