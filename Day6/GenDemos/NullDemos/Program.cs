using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullDemos
{
    class Emp
    {
        public int Empno { get; set; }
        public string Name { get; set; }
        public double Basic { get; set; }
    }
    class Program
    {
        public void Show()
        {
            Emp e = null ;
            e.Empno =1;
            e.Name = "Arun";
            e.Basic = 88233;
        }
        static void Main(string[] args)
        {
            new Program().Show();
        }
    }
}
