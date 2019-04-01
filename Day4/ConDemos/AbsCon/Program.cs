using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsCon
{
    abstract class Employ
    {
        int empno;
        string name;
        double sal;
        public Employ(int empno,string name,double sal)
        {
            this.empno = empno;
            this.name = name;
            this.sal = sal;
        }
        public void Show()
        {
            Console.WriteLine("Empno " +empno+ " Name " +name+ " Salary " +sal);
        }
    }

    class Pallavi : Employ
    {
        public Pallavi(int empno,string name,double sal) : base(empno,name,sal)
        {

        }
    }

    class Aruna : Employ
    {
        public Aruna(int empno,string name,double sal) : base(empno,name,sal)
        {

        }
    }

    class Siva : Employ
    {
        public Siva(int empno,string name,double sal) : base(empno,name,sal)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
