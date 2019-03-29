using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

/*
 * Program to invoke Methods through Assembly
 */

namespace Reflection02
{
    class Calculation
    {
        private int firstNumber;

        public int FirstNumber
        {
            get { return firstNumber; }
            set { firstNumber = value; }
        }
        private int secondNumber;

        public int SecondNumber
        {
            get { return secondNumber; }
            set { secondNumber = value; }
        }

        public int AddTwoNumbers()
        {
            return FirstNumber + SecondNumber;
        }
    }

    class CalculationTest
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            foreach (Type t in assembly.GetTypes())
            {
                if (t.Name == "Calculation")
                {
                    object obj = assembly.CreateInstance("Reflection02.Calculation");
                    PropertyInfo[] property = t.GetProperties();
                    property[0].SetValue(obj, 4, null);
                    property[1].SetValue(obj, 5, null);
                    MethodInfo methodInfo = t.GetMethod("AddTwoNumbers");
                    int result = (int)methodInfo.Invoke(obj, null);
                    Console.WriteLine(result);

                }
            }

            Console.ReadKey();
        }
    }
}
