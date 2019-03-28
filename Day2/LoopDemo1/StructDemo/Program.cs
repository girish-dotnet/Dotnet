using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructDemo
{
    struct Employ
    {
        public int Empno;
        public string Name;
        public double Salary;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employ e;
            e.Empno = 1;
            e.Name = "Arun";
            e.Salary = 88522;
            Console.WriteLine($"Empno {e.Empno} Name {e.Name} Sal {e.Salary}");
        }
    }
}
