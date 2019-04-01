using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhTest
{
    class First
    {
        public void Show()
        {
            Console.WriteLine("Show Method...");
        }
    }

    class Second : First
    {
        public void Display()
        {
            Console.WriteLine("Display Method...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            First obj1 = new Second();
            obj1.Show();
            
            //Second obj2 = new First();
        }
    }
}
