using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace ArrListEmp
{

    class Emp : IComparable
    {
        public int Empno { get; set; }
        public string Name { get; set; }
        public int Basic { get; set; }

        public int CompareTo(object ob)
        {
            Emp e = (Emp)ob;
            return e.Name.CompareTo(Name);
            //if(e.Basic >= Basic)
            //{
            //    return 1;
            //}
            //else
            //{
            //    return -1;
            //}
        }
    class Demo
    {
        static void Main(string[] args)
        {
            Emp e1 = new Emp();
            e1.Empno = 1;
            e1.Name = "Jitu";
            e1.Basic = 88234;

            Emp e2 = new Emp();
            e2.Empno = 3;
            e2.Name = "Arun";
            e2.Basic = 87233;

            Emp e3 = new Emp();
            e3.Empno = 4;
            e3.Name = "Dhivya";
            e3.Basic = 88221;

            ArrayList alist = new ArrayList();
            alist.Add(e1);
            alist.Add(e2);
            alist.Add(e3);
            foreach(Emp e in alist)
            {
                Console.WriteLine(e.Empno + " " +e.Name +" " +e.Basic);
            }

            alist.Sort();
            Console.WriteLine("Employ after Sorting...");
            foreach (Emp e in alist)
            {
                Console.WriteLine(e.Empno + " " + e.Name + " " + e.Basic);
            }
        }
    }
}
