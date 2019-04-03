using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace GenDemos
{
    class Student
    {
        public int Sno { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public double Cgp { get; set; }
    }
    class Emp
    {
        public int Empno { get; set; }
        public string Name { get; set; }
        public double Basic { get; set; }
    }
    class Demo
    {
        public static IEnumerable ShowEmp()
        {
            List<Emp> lstEmp = new List<Emp>()
            {
                new Emp{Empno=1,Name="Nitish",Basic=82834},
                new Emp{Empno=3,Name="Priya",Basic=82834},
                new Emp{Empno=4,Name="Siva",Basic=92844},
                new Emp{Empno=5,Name="Bhargav",Basic=88211}
            };
            foreach(Emp e in lstEmp)
            {
                yield return e;
            }
        }
        public static IEnumerable ShowNames()
        {
            List<string> lstNames = new List<string>()
            {
                "Kiran","Arun","Rivitha","Dhivya","Anusha","Jitu"
            };
            foreach (string s in lstNames)
            {
                yield return s;
            }
        }
    
        public static IEnumerable Show()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5 };
            foreach(int i in a)
            {
               yield return i;
            }
        }
        static void Main(string[] args)
        {
            foreach(int i in Show())
            {
                Console.WriteLine(i);
            }

            foreach(string s in ShowNames())
            {
                Console.WriteLine(s);
            }
            foreach(Emp e in ShowEmp())
            {
                Console.WriteLine(e.Empno + " " +e.Name + " " +e.Basic);
            }
        }
    }
}
