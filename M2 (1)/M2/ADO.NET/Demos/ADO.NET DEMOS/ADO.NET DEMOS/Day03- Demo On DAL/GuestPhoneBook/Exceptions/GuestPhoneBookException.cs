using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exceptions
{
    public class GuestPhoneBookException : ApplicationException
    {
        public GuestPhoneBookException()
            : base()
        {
        }

        public GuestPhoneBookException(string message)
            : base(message)
        {
        }
        public GuestPhoneBookException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
