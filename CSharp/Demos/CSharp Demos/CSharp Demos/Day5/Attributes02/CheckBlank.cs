using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes02
{
    [AttributeUsage(AttributeTargets.Property)]
    public class CheckBlank : Attribute, IAttribute
    {
        private string errorMessage;
        public CheckBlank(string errorMessage)
        {
            this.errorMessage = errorMessage;
        }

        #region IAttribute Members

        public string Message
        {
            get
            {
                return errorMessage;
            }
            set
            {
                errorMessage = value;
            }
        }

        public bool IsValid(object item)
        {
            bool result = true;
            try
            {
                string s = (string)item;
                if (s.Trim().Equals(String.Empty))
                    result = false;
            }
            catch (InvalidCastException)
            {
                result = false;
            }
            return result;
        }
        #endregion
    }
}
