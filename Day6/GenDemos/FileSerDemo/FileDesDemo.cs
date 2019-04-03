using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
//using System.Runtime.Serialization.Formatters.Soap;


namespace FileSerDemo
{
    
    class FileDesDemo
    {
        static void Main(string[] args)
        {
            FileStream stream = new FileStream(@"c:\files\Emp.txt", FileMode.OpenOrCreate, 
                FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            Employ e = (Employ)formatter.Deserialize(stream);
            Console.WriteLine(e.Empno);
            Console.WriteLine(e.Name);
            Console.WriteLine(e.Basic);
        }
    }
}
