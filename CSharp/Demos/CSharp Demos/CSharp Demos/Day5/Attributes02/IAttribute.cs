using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes02
{
    public interface IAttribute
    {
        string Message { get; set; }

        bool IsValid(object item);
    }
}
