using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

/*
 * Invoking Private Static Method using Assembly
 */ 

namespace Reflection04
{
    class Calculation
    {

        private static int AddTwoNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }

    class CalculationTest
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type t = assembly.GetType("Reflection04.Calculation");
            MethodInfo methodInfo = t.GetMethod("AddTwoNumbers", BindingFlags.NonPublic | BindingFlags.Static);
            int result = (int)methodInfo.Invoke(null, new object[] { 22, 3 });
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
