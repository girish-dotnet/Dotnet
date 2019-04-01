using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConEx
{
    class Employ
    {
        int empno;
        string name;
        double basic;

        public Employ()
        {
            this.empno = 1;
            this.name = "Arun";
            this.basic = 88234;
        }
        public Employ(int empno,string name,double basic)
        {
            this.empno = empno;
            this.name = name;
            this.basic = basic;
        }
        public void Show()
        {
            Console.WriteLine($"Empno {empno} Name {name} Basic {basic}");
        }
        ~Employ()
        {
            Console.WriteLine("Destructor...");
        }
        static void Main(string[] args)
        {
            Employ e = new Employ();
            e.Show(); // calls default constructor
            Employ obj1 = new Employ(12, "Siva", 97775);
            obj1.Show(); // calls the overloaded constructor.
        }
    }
}







