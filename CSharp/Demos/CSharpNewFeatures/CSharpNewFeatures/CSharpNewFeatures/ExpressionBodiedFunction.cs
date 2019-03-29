using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace CSharpNewFeatures
{
    class ExpressionBodiedFunction
    {
        private static void Main(string[] args)
        {
            double x = 1.618;
            double y = 3.142;

            WriteLine(AddNumbers(x, y));
            ReadLine();
        }

        /* Expression bodied function */
        private static double AddNumbers(double x, double y) => x + y;

    }
}
