using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutParamDemo
{
    class Employ
    {
        public void Show(int empno,out string name,out double sal)
        {
            if(empno==1)
            {
                name = "Arun";
                sal = 48852;
            }
            else
            {
                name = "Not Found";
                sal = 0;
            }
        }
        static void Main(string[] args)
        {
            int empno = 2;
            double basic;
            string name;
            new Employ().Show(empno, out name, out basic);
            Console.WriteLine($"Name {name} Salary {basic}");
        }
    }
}
