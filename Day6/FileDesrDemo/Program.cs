using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FileSerDemo
{
    [Serializable]
    class Employ
    {
        public int Empno { get; set; }
        public string Name { get; set; }
        public int Basic { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FileStream stream = new FileStream(@"c:\csh\Emp.txt", FileMode.OpenOrCreate,FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            Employ e = (Employ)formatter.Deserialize(stream);
            Console.WriteLine(e.Empno);
            Console.WriteLine(e.Name);
            Console.WriteLine(e.Basic);
        }
    }
}
