using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IOSerialization03
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fileStream01 = new FileStream("d:\\test.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream01);
            streamWriter.WriteLine("this is a Test");
            streamWriter.WriteLine("this is a Test");
            streamWriter.WriteLine("this is a Test");
            streamWriter.Flush();
            streamWriter.Close();
            fileStream01.Close();


            FileStream fileStream02 = new FileStream("d:\\test.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream02);
            int ch = streamReader.Read();
            while (ch > 0)
            {
                Console.Write((char)ch);
                ch = streamReader.Read();
            }
            streamReader.Read();
            streamReader.Close();
            fileStream02.Close();

            Console.ReadKey();
        }
    }
}
