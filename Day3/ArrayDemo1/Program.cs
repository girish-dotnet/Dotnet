using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo1
{
    class Demo
    {
        public void ShowArray()
        {
            int[] arr = new int[] { 12, 5, 67, 23, 33, 24 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //    i = 4;
            //}
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Demo obj = new Demo();
            obj.ShowArray();
        }
    }
}
