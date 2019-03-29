using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


/*
 * Printing all the types from the given Assembly
 */ 

namespace Reflection01
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.LoadFile(@"C:\Windows\Microsoft.NET\Framework\v2.0.50727\System.Drawing.dll");
            foreach (Type t in assembly.GetTypes())
            {
                Console.WriteLine(t.Name);
            }

            Console.ReadKey();
        }
    }
}
