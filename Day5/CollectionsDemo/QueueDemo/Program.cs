using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace QueueDemo
{
    class Demo
    {
        public void Show()
        {
            Queue obj = new Queue();
            obj.Enqueue("Bhaskar");
            obj.Enqueue("Anu");
            obj.Enqueue("Priya");
            obj.Enqueue("Siva");
            obj.Enqueue("Bhargav");
            Console.WriteLine("Queue List  ");
            foreach (object ob in obj)
            {
                Console.WriteLine(ob);
            }
            obj.Dequeue();
            obj.Dequeue();
            Console.WriteLine("Queue after POP  ");
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
