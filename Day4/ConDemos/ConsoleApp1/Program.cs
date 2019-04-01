using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Training
    {
        public abstract void Name();
        public abstract void Email();
    }

    class Sangeetha : Training
    {
        public override void Name()
        {
            Console.WriteLine("Hi I am Sangeetha...");
        }

        public override void Email()
        {
            Console.WriteLine("Email is sangeetha@capgemini.com");
        }
    }

    class Nishanth : Training
    {
        public override void Name()
        {
            Console.WriteLine("Name is Nishanth...");
        }

        public override void Email()
        {
            Console.WriteLine("Email is Nishanth@gmail.com");
        }
    }

    class Bhargav : Training
    {
        public override void Name()
        {
            Console.WriteLine("Name is Bhargav...");
        }

        public override void Email()
        {
            Console.WriteLine("Email is Bhargav@gmail.com");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Training obj1 = new Sangeetha();
            //Training obj2 = new Nishanth();
            //Training obj3 = new Bhargav();
            Training[] arr = new Training[]
            {
                new Sangeetha(),
                new Nishanth(),
                new Bhargav()
            };
            foreach(Training t in arr)
            {
                t.Name();
                t.Email();
            }
        }
    }
}







