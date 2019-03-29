using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
 * Program demonstrating retriving file Information
 */
namespace IOSerialization01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FileInfo fileObj = new FileInfo(@"d:\test.txt");
                if (fileObj.Exists)
                {
                    Console.WriteLine("File Name = {0}", fileObj.Name);
                    Console.WriteLine("File length in Bytes = {0}", fileObj.Length);
                    Console.WriteLine("File Extension = {0}", fileObj.Extension);
                    Console.WriteLine("File Full path = {0}", fileObj.FullName);
                    Console.WriteLine("File Directory = {0}", fileObj.DirectoryName);
                    Console.WriteLine("File Parent Directory = {0}", fileObj.Directory);
                    Console.WriteLine("File Creation Date and Time = {0}", fileObj.CreationTime.ToString("dd-MM-yyyy hh:mm:ss tt"));
                    Console.WriteLine("File Modified Date and Time = {0}", fileObj.LastWriteTime.ToString("dd-MM-yyyy hh:mm:ss tt"));
                    Console.WriteLine("File Last Access Date and Time = {0}", fileObj.LastAccessTime.ToString("dd-MM-yyyy hh:mm:ss tt"));
                    Console.WriteLine("File Attributes = {0}", fileObj.Attributes.ToString());
                }
                else
                {
                    Console.WriteLine("File does not Exists");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
