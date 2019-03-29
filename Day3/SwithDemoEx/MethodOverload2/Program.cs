using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload2
{
    class Demo
    {
        public int Sum()
        {
            return 5;
        }

        public int Sum(int x)
        {
            return x + 5;
        }

        public int Sum(int x,int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            Demo obj = new Demo();
            Console.WriteLine("Result " +obj.Sum());
            Console.WriteLine("Result  " +obj.Sum(65));
            Console.WriteLine("Result " +obj.Sum(66,23));
        }
    }
}
