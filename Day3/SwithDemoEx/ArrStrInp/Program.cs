using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrStrInp
{
    class Demo
    {
        public void Show()
        {
            string[] arr = new string[5];
            Console.WriteLine("Enter 5 Names ");
            for(int i=0;i<5;i++)
            {
                arr[i] = Console.ReadLine();
            }
            Console.WriteLine("Names are");
            foreach(string s in arr)
            {
                Console.WriteLine(s);
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
