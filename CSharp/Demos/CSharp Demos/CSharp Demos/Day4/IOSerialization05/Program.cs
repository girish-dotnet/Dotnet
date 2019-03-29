using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

/*
 * Program to demonstrate Serialization and DeSerailization of Built in Type 
 */

namespace IOSerialization05
{
    class Program
    {
        static void Main(string[] args)
        {
            SerializeData();
            DeserializeData();

            Console.ReadKey();
        }

        private static void SerializeData()
        {
            FileStream fileStream = new FileStream("d:\\ser.dat", FileMode.Create);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fileStream, DateTime.Now);
            fileStream.Close();
        }

        private static void DeserializeData()
        {
            FileStream fileStream = new FileStream("d:\\ser.dat", FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            DateTime dt = (DateTime)binaryFormatter.Deserialize(fileStream);
            fileStream.Close();
            Console.WriteLine(dt.ToString());
        }

    }
}
