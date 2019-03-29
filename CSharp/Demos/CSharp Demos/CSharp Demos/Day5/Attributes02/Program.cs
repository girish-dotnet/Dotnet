using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Reflection;

/*
 *Working with Attributes
 */ 


namespace Attributes02
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Console.Write("Enter Employee ID:");
            employee.EmployeeID = Console.ReadLine();

            Console.Write("Enter Employee Name:");
            employee.EmployeeName = Console.ReadLine();

            if (!ValidateEmployee(employee))
            {
                foreach (Error error in employee.ErrorList)
                {
                    Console.WriteLine("{0}", error.ErrorMessage);
                }
            }
            else
            {
                Console.WriteLine("Employee Id = {0} and Name = {1}", employee.EmployeeID, employee.EmployeeName);
            }

            Console.ReadKey();
        }

        private static bool ValidateEmployee(Employee employee)
        {
            PropertyInfo[] properties = employee.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo property in properties)
            {
                object[] customAtt = property.GetCustomAttributes(typeof(IAttribute), true);

                foreach (object att in customAtt)
                {
                    IAttribute valAtt = (IAttribute)att;
                    if (valAtt == null) continue;

                    if (valAtt.IsValid(property.GetValue(employee, null))) continue;
                    Error error = new Error(property.Name, valAtt.Message);
                    employee.ErrorList.Add(error);

                }

            }

            return (employee.ErrorList.Count == 0);

        }
    }
}
