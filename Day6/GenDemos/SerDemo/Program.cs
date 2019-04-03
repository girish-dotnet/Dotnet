using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace SerDemo
{
    [Serializable]
    class Student
    {
        public int Sno { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public double Cgp { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
