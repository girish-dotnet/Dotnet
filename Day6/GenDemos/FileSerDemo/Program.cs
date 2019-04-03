using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
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
            FileStream fs = new FileStream(@"c:\files\Emp.txt", FileMode.Create, FileAccess.Write);
            BinaryFormatter form = new BinaryFormatter();
            Employ e = new Employ();
            e.Empno = 1;
            e.Name = "asdfasf";
            e.Basic = 88233;
            form.Serialize(fs, e);
            fs.Close();
        }
    }
}
