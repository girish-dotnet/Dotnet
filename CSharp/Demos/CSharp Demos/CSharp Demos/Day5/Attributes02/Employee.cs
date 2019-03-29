using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes02
{
    public class Employee : AttributeErrors
    {
        [CheckLength(6, 6, "Employee ID Must be 6 Characters")]
        [CheckBlank("Employee ID is Required")]
        public string EmployeeID { get; set; }

        [CheckLength(4, 10, "Employee Name must be between 4 to 10 characters")]
        [CheckBlank("Employee Name is Required")]
        public string EmployeeName { get; set; }
    }
}
