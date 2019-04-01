using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnly
{
    class Employ
    {
        int empno;
        string name;
        string compnany;
        public Employ()
        {
            this.empno = 1;
            this.name = "Arun";
            this.compnany = "Capgemini";
        }
        public int Empno
        {
            get { return empno; }
        }
        public string Name
        {
            get { return name; }
        }
        public string Company
        {
            get { return compnany; }
        }
        static void Main(string[] args)
        {
            Employ e = new Employ();
            //e.Empno = 66;
            //e.Company = "Cg";
            //e.Name = "Aruna";  
            /* Will not work as its readonly property */
            Console.WriteLine(e.Empno + " " +e.Name + " " +e.Company);
        }
    }
}
