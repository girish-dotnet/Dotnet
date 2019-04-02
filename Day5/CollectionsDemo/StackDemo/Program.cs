using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace StackDemo
{
    class Program
    {
        public void Show()
        {
            Stack obj = new Stack();
            obj.Push("Bhaskar");
            obj.Push("Anu");
            obj.Push("Priya");
            obj.Push("Siva");
            obj.Push("Bhargav");
            Console.WriteLine("Stack List  ");
            foreach(object ob in obj)
            {
                Console.WriteLine(ob);
            }
            obj.Pop();
            obj.Pop();
            Console.WriteLine("Stack after POP  ");
            foreach (object ob in obj)
            {
                Console.WriteLine(ob);
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
