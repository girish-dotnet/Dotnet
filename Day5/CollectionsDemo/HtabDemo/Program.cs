using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace HtabDemo
{
    class Htab
    {
        public void Show()
        {
            Hashtable ht = new Hashtable();
            ht.Add("1", "Aruna");
            ht.Add("2", "Siva");
            ht.Add("3", "Sai");
            ht.Add("4", "Jitu");
            ht.Add("5", "Pallavi");

            Console.WriteLine("HashTable Data is  ");
            foreach(DictionaryEntry ent in ht)
            {
                Console.WriteLine(ent.Key + " " +ent.Value);
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
