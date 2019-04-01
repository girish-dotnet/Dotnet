using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsExs
{
    abstract class Animal
    {
        public abstract void Name();
        public abstract void Type();
    }

    class Lion : Animal
    {
        public override void Name()
        {
            Console.WriteLine("Name is Lion...");
        }
        public override void Type()
        {
            Console.WriteLine("Its Wild Animal...");
        }
    } 

    class Crocodile : Animal
    {
        public override void Name()
        {
            Console.WriteLine("Name is Crocodile...");
        }

        public override void Type()
        {
            Console.WriteLine("Its Water Animal...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
