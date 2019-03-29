using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
 * Program to work with directories and File extension
 */ 

namespace IOSerialization04
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //retriving details from d: drive
                DirectoryInfo info = new DirectoryInfo(@"d:\");

                //Get the top Level Directories Starting with A
                DirectoryInfo[] directories = info.GetDirectories("N*", SearchOption.TopDirectoryOnly);

                foreach (DirectoryInfo directory in directories)
                {
                    //retriving the files from the current directory
                    FileInfo[] files = directory.GetFiles();

                    foreach (FileInfo fileInfo in files)
                    {
                        //retriving the extension of the file
                        string extension = Path.GetExtension(fileInfo.FullName);
                        //Checking for .cs extension
                        if (extension.Equals(".cs"))
                        {
                            Console.WriteLine("{0}=>{1}", directory.Name, fileInfo.Name);
                        }

                    }
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
