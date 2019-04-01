using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropDemo
{
    class Student
    {
        private int sno;
  
        public int Sno
        {
            get
            {
                return sno;
            }
            set
            {
                sno=value;
            }
        }
        static void Main(string[] args)
        {
            Student obj = new Student();
            obj.Sno = 1;
            Console.WriteLine("Sno is  " +obj.Sno);
        }
    }
}
