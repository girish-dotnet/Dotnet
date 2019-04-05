using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMultiDemo
{
    class Program
    {
        public delegate void Calc(int n);

        public static void Factors(int n)
        {
            for(int i=1;i<=n;i++)
            {
                if(n%i==0)
                {
                    Console.WriteLine("Factor " +i);
                }
            }
        }
        public static void Fact(int n)
        {
            int f = 1;
            for(int i=1;i<=n;i++)
            {
                f = f * i;
            }
            Console.WriteLine("Factorial "+f);
        }
        public static void EvenOdd(int n)
        {
            if(n%2==0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
        static void Main(string[] args)
        {
            Calc obj = new Calc(EvenOdd);
            obj += new Calc(Fact);
            obj += new Calc(Factors);
            obj(7);
        }
    }
}
