using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes02
{
    public class Error
    {
        private string propertyName;

        public string PropertyName
        {
            get { return propertyName; }
            set { propertyName = value; }
        }
        private string errorMessage;

        public string ErrorMessage
        {
            get { return errorMessage; }
            set { errorMessage = value; }
        }

        public Error()
        {
            this.propertyName = string.Empty;
            this.errorMessage = string.Empty;

        }
        public Error(string propertyName, string errorMessage)
        {
            this.propertyName = propertyName;
            this.errorMessage = errorMessage;

        }
    }
}
