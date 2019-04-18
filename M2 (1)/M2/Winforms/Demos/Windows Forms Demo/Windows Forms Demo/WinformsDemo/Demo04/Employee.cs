using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo04
{
    public class Employee
    {
        private int employeeID;

        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Employee()
        {
            employeeID = 0;
            name = string.Empty;
        }
        public Employee(int employeeID, string name)
        {
            this.employeeID = employeeID;
            this.name = name;
        }
    
    }
}
