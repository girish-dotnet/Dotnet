using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes02
{
    public class CheckLength : Attribute, IAttribute
    {
        private int minChar, maxChar;
        string errormessage;
        public CheckLength(int minChar, int maxChar, string errorMessage)
        {
            this.minChar = minChar;
            this.maxChar = maxChar;
            this.errormessage = errorMessage;
        }

        #region IAttribute Members

        public string Message
        {
            get
            {
                return errormessage;
            }
            set
            {
                errormessage = value;
            }
        }

        public bool IsValid(object item)
        {
            bool res = true;
            try
            {
                string s = (string)item;
                if (s.Trim().Equals(string.Empty))
                    res = true;
                else if (s.Trim().Length < minChar || s.Trim().Length > maxChar)
                    res = false;

            }
            catch (InvalidCastException)
            {
                res = false;
            }
            return res;
        }

        #endregion
    }
}
