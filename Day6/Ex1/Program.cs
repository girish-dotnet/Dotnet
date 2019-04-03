using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Demo
    {
        public void Calc(int a,int b)
        {
            int c = a / b;
            Console.WriteLine("Div  " +c);
        }
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter 2 Numbers  ");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                new Demo().Calc(a, b);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Division By Zero Impossible...");
            }
            catch(OverflowException e)
            {
                Console.WriteLine("Number is Too Big...");
            }
            catch(FormatException e)
            {
                Console.WriteLine("String Cannot be converted as integer");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Program By Capgemini Participants");
            }
        }
    }
}
