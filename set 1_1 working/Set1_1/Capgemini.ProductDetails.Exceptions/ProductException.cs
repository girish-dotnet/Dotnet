using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.ProductDetails.Exceptions
{
    public class ProductException : ApplicationException
    {
      
            public ProductException() : base()
            {
            }
            public ProductException(string message) : base(message)
            {

            }
            public ProductException(string message, Exception innerException) :
                base(message, innerException)
            {
            }
    }
    
}
