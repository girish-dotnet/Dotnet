using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDemo
{
    class Employ
    {
        public int empno;
        public string name;
        public double basic;
    }
    class Program
    {
        public void Show()
        {
            Employ e1 = new Employ();
            e1.empno = 1;
            e1.name = "Arun";
            e1.basic = 88234;

            Employ e2 = new Employ();
            e2.empno = 3;
            e2.name = "Dhivya";
            e2.basic = 88142;

            Employ e3 = new Employ();
            e3.empno = 4;
            e3.name = "Gaurav";
            e3.basic = 88111;

            //int[] a = new int[] { 12, 5, 77 };
         
            Console.WriteLine(string.Format("{0,-10} {1,-20} {2,-10} \n",
                "Empno", "Name", "Basic"));

            Employ[] arr = new Employ[] {e1, e2, e3 };
            foreach(Employ e in arr)
            {
                Console.WriteLine(string.Format("{0,-10} {1,-20} {2, -10} \n",
                    e.empno,e.name,e.basic));
                //Console.WriteLine(e.empno + " " +e.name + " " +e.basic);
            }
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Show();
        }
    }
}
