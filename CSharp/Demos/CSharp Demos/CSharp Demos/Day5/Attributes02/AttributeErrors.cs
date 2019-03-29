using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes02
{
    public class AttributeErrors
    {
        private List<Error> errorList = new List<Error>();

        public List<Error> ErrorList
        {
            get { return errorList; }
            set { errorList = value; }
        }
    }
}
