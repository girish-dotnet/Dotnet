using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrDemo3
{
    class Demo
    {
        public void Show()
        {
            string[] arr = new string[]
            {
                "Arun","Girish","Karthik","Gangadhar","Anusha","Aruna"
            };
            Console.WriteLine("Names are  ");
            foreach(string s in arr)
            {
                Console.WriteLine(s);
            }
            Array.Sort(arr);
            Console.WriteLine("Sorted List  ");
            foreach (string s in arr)
            {
                Console.WriteLine(s);
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
