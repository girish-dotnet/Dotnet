using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoImpl
{
    class Employ
    {
        public int Empno { get; set; } 
        public string Name { get; set; } 
        public double Basic { get; set; }
        public string Company { get; set; } = "CapGemini";

        public override bool Equals(object obj)
        {
            Employ e = (Employ)obj;
            if(e.Basic==Basic)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employ obj = new Employ();
            obj.Empno = 1;
            obj.Name = "Arun";
            obj.Basic = 88234;
            Console.WriteLine("Empno " +obj.Empno + " Name " +obj.Name + " Sal " +obj.Basic);
            Console.WriteLine("Company " + obj.Company);

            Employ obj2 = obj;
            Employ obj3 = new Employ();
            obj3.Empno = 5;
            obj3.Name = "Payal";
            obj3.Basic = 88234;

            Console.WriteLine(obj2==obj);
            Console.WriteLine(obj2.Equals(obj));
            Console.WriteLine(obj3==obj);
            Console.WriteLine(obj3.Equals(obj));
        }
    }
}
