using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4new
{
    public class Employee
    {
        public int EmployeeID  {   get;set;  }
        public string Name { get;set; }
        public Employee()
        {
            EmployeeID = 0;
            Name = string.Empty;
        }
        public Employee(int employeeID, string name)
        {
            this.EmployeeID = employeeID;
            this.Name = name;
        }

    }
}
