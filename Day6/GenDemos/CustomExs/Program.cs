using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExs
{
    class NegativeException : Exception
    {
        public NegativeException(string error) : base(error)
        {
        }
    }

    class NumberZeroException : Exception
    {
        public NumberZeroException(string error) : base(error)
        {

        }
    }
    class Program
    {
        public void Check(int a,int b)
        {
            bool flag = true;
            if(a < 0 || b < 0)
            {
                flag = false;
                throw new NegativeException("Negative Nos Not Allowed...");
            }
            if(a==0 || b==0)
            {
                flag = false;
                throw new NumberZeroException("Zero is Invalid...");
            }
            if(flag==true)
            {
                int c = a + b;
                Console.WriteLine("Sum is  " +c);
            }
        }
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter 2 Numbers  ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            try
            {
                new Program().Check(a, b);
            }
            catch(NegativeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(NumberZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
