using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp_Exceptions
{
    public class EmployException : ApplicationException
    {
        public EmployException() : base()
        {

        }

        public EmployException(string error) : base(error)
        {

        }
    }
}
