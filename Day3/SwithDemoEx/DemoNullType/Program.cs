using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNullType
{
    class Program
    {
        public void Show()
        {
            int? examscore = null;
            double? salary = null;

            salary = 85224;
            /* check about null value */ 
            if (examscore.HasValue)
            {
                Console.WriteLine("Score is " +examscore);
            }
            else
            {
                Console.WriteLine("Still Exam not happend...");
            }
            if (salary.HasValue)
            {
                Console.WriteLine("Salary is " +salary);
            }
            else
            {
                Console.WriteLine("Not Applicable");
            }
        }

        static void Main(string[] args)
        {
            new Program().Show();
        }
    }
}
