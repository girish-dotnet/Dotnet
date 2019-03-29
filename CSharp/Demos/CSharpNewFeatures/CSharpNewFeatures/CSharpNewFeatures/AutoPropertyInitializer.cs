using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace CSharpNewFeatures
{
    class AutoPropertyInitializer
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            WriteLine("Name: " +
            employee.Name + "\nSalary: " + employee.Salary);
            ReadKey();
        }
    }
        public class Employee
        {
        /* Getter only property with inline initialization */
        public string Name { get; } = "Nikhil";
            /* Property with inline initialization */
            public decimal Salary { get; set; } = 10000;
        }

    
}
