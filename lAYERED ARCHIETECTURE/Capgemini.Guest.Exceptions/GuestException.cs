using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.Guest.Exceptions
{
    public class GuestException:ApplicationException
    {
        public GuestException() :base()
        {

        }
        public GuestException(string message):base(message)
        {

        }
        public GuestException(string message,Exception innerException):base (message,innerException)
        {

        }
    }
}
