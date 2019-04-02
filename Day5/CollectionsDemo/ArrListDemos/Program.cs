using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace ArrListDemos
{
    class Program
    {
        public void Show()
        {
            List<string> alist = new List<string>();
            alist.Add("Jitu");
            alist.Add("Likhitha");
            alist.Add("Aruna");
            alist.Add("Bhargav");
            foreach(string s in alist)
            {
                Console.WriteLine(s);
            }
        }
        static void Main(string[] args)
        {
            new Program().Show();
        }
    }
}
