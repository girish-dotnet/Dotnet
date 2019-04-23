using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.EmployDetails.Exceptions
{
    public class EmployException : ApplicationException
    {
        public EmployException() : base()
        {
        }
        public EmployException(string message) : base(message)
        {

        }
        public EmployException(string message, Exception innerException) :
            base(message, innerException)
        {
        }
    }
}
