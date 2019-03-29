using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace CSharpNewFeatures
{
    class NameOfExpression
    {
        private static void Main(string[] args)
        {
            try
            {
                CallSomething();
            }
            catch (Exception exception)
            {
                WriteLine(exception.Message);
            }
            ReadKey();
        }
        private static void CallSomething()
        {
            int? number = null;
            if (number == null)
            {
                throw new Exception(nameof(number) + " is null");
            }
        }

    }
}
