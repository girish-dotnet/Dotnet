using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.EmployDetails.Entities
{
    public class Employ
    {
        public Employ()
        {
            EmployID = 0;
            EmployName = string.Empty;
            Department = string.Empty;
            Salary = 0;
        }
    
        public int EmployID { get; set; }
        public string EmployName { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }

    }
}
