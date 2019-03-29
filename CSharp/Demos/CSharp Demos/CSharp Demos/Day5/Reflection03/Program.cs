using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

/*
 * Program to read the Data from Embedded Resource
 */ 

namespace Reflection03
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            string resource = assembly.GetName().Name + ".Sample.txt";
            Stream stream = assembly.GetManifestResourceStream(resource);
            StreamReader reader = new StreamReader(stream);
            string data = reader.ReadToEnd();
            Console.WriteLine(data);
            reader.Close();

            Console.ReadKey();
        }
    }
}
