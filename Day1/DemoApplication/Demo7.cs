using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    class Demo7
    {
        public void Calc(double radius)
        {
            double area = Math.PI * radius * radius;
            double circ = Math.PI * 2 * radius;
            Console.WriteLine($"Area is {area} Circumference {circ}");
        }
        static void Main(string[] args)
        {
            double radius;
            Console.WriteLine("Enter radius  ");
            radius = Convert.ToDouble(Console.ReadLine());
        }
    }
}
