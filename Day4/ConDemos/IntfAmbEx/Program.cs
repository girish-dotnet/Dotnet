using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntfAmbEx
{
    interface IOne
    {
        void Name();
    } 
    interface ITwo
    {
        void Name();
    }
    class Demo : IOne,ITwo
    {
        void IOne.Name()
        {
            Console.WriteLine("name from IOne");
        }
        void ITwo.Name()
        {
            Console.WriteLine("Name from Itwo");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IOne obj1 = new Demo();
            ITwo obj2 = new Demo();
            obj1.Name();
            obj2.Name();
        }
    }
}

