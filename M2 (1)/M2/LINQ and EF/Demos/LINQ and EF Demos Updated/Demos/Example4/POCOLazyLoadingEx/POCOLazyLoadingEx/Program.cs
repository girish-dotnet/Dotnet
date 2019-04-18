using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCOLazyLoadingEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Department [] depts=new Department[]
            {
             new Department{Name="IT",Location="New York"},
             new Department{Name="HR",Location="London"},
             new Department{Name="Payroll",Location="Sydney"}
            };

            Employee[] emps = new Employee[]
            {
                new Employee {FirstName="Mark",LastName="Hastings",Gender="Male",Salary=60000,DepartmentId=1},
                new Employee {FirstName="Steve",LastName="Pound",Gender="Male",Salary=45000,DepartmentId=3},
                new Employee {FirstName="Ben",LastName="Hoskins",Gender="Male",Salary=70000,DepartmentId=1},
                new Employee {FirstName="Philip",LastName="Hastings",Gender="Male",Salary=45000,DepartmentId=2},
                new Employee {FirstName="Mary",LastName="Lambeth",Gender="Female",Salary=30000,DepartmentId=2},
                new Employee {FirstName="Valarie",LastName="Viking",Gender="Female",Salary=35000,DepartmentId=3},
                new Employee {FirstName="John",LastName="Stanmore",Gender="Male",Salary=80000,DepartmentId=1}
            };

            CompanyModel companyContext = new CompanyModel();
            
            companyContext.Departments.AddRange(depts);
            companyContext.Employees.AddRange(emps);
            companyContext.SaveChanges();

            foreach (Department d in companyContext.Departments)
            {
                Console.WriteLine(d.Name);
                foreach (Employee e in d.Employees)
                {
                    Console.WriteLine("\t" + e.FirstName + " " + e.LastName);
                }
            }

            Console.WriteLine("Press any key to continue............");
            Console.ReadKey();
        }
    }
}
