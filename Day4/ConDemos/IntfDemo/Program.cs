using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntfDemo
{
    interface IOne
    {
        void Name();
        void Email();
    }

    class Priya : IOne
    {
        public void Name()
        {
            Console.WriteLine("name is Priya...");
        }

        public void Email()
        {
            Console.WriteLine("Email is priya@gmail.com");
        }
    }

    class Payal : IOne
    {
        public void Name()
        {
            Console.WriteLine("Name is Payal");
        }
        public void Email()
        {
            Console.WriteLine("Email is Payal@gmail.com");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IOne[] arr = new IOne[]
            {
                new Payal(), new Priya()
            };
        }
    }
}
