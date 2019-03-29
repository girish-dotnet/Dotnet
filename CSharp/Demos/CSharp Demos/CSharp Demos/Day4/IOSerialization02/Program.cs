using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
 * Program demonstrating BinaryReader and BinaryWriter
 */ 

namespace IOSerialization02
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fileStream01 = new FileStream("d:\\test.txt", FileMode.Create, FileAccess.Write);
            BinaryWriter binaryWriter = new BinaryWriter(fileStream01);
            binaryWriter.Write(54);
            binaryWriter.Write("IGATEPATNI");
            binaryWriter.Write(65.76);
            binaryWriter.Close();
            fileStream01.Close();

            FileStream fileStream02 = new FileStream(@"d:\test.txt", FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream02);
            Console.WriteLine(binaryReader.ReadInt32());
            Console.WriteLine(binaryReader.ReadString());
            Console.WriteLine(binaryReader.ReadDouble());
            binaryReader.Close();
            fileStream02.Close();

            Console.ReadKey();
        }
    }
}
