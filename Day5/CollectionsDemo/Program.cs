using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class Demo
    {
        public void Show()
        {
            ArrayList alist = new ArrayList();
            alist.Add("Poornima");
            alist.Add("Jitu");
            alist.Add("Arun");
            alist.Add("Bhargav");
            Console.WriteLine("Elements are  ");
            foreach(object ob in alist)
            {
                Console.WriteLine(ob);
            }
            alist.Insert(2, "Aruna");
            Console.WriteLine("List after Adding new Element");
            foreach (object ob in alist)
            {
                Console.WriteLine(ob);
            }
            alist.Remove("Jitu");
            Console.WriteLine("List after Removing by Object Name ");
            foreach (object ob in alist)
            {
                Console.WriteLine(ob);
            }
            alist.RemoveAt(2);
            Console.WriteLine("List by removing by object index ");
            foreach (object ob in alist)
            {
                Console.WriteLine(ob);
            }
            alist.Add("Sameer");
            alist.Add("Yamini");
            alist.Add("Sangeetha");

            alist.Sort();
            Console.WriteLine("Sorted List ");
            foreach (object ob in alist)
            {
                Console.WriteLine(ob);
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
