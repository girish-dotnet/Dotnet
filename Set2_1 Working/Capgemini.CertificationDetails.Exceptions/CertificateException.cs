using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.CertificationDetails.Exceptions
{
    public class CertificateException : ApplicationException
    {
        public CertificateException() : base()
        {
        }
        public CertificateException(string message) : base(message)
        {

        }
        public CertificateException(string message, Exception innerException) :
            base(message, innerException)
        {
        }
    }
}
