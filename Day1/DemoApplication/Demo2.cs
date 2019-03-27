using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    class Demo2
    {
        public void Display(string name)
        {
            Console.WriteLine($"Name is {name}");
        }
        public void Show()
        {
            Console.WriteLine("Welcome to Dotnet...");
        }
        static void Main(string[] args)
        {
            string name = "Arun";
            Demo2 obj = new Demo2();
            obj.Show();
            obj.Display(name);
        }
    }
}
