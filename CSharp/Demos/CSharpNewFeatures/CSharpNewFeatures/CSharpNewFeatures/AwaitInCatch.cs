using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;
namespace CSharpNewFeatures
{

    public class Awaitincatchandfinally
    {
        public static void Main(string[] args)
        {
            FileRead fr = new FileRead();
            WriteLine(" Class Object Created Successfully!\n");
            fr.FileReadOperation();
            ReadKey();
        }
    }
    public class FileRead
    {
        public async void FileReadOperation()
        {
            try
            {
                StreamReader sr = File.OpenText("D:\\data.txt");
                WriteLine("The first line of the file is: {sr.ReadLine()}");
                sr.Close();
            }
            catch { await FileNotFound(); }
            finally { await ExitProgram(); }
        }
        private async Task FileNotFound()
        {
            WriteLine(" File not found. Please check the file name and file location.");
        }
        private async Task ExitProgram()
        {
            WriteLine("\n Press any key to exit");
        }
    }

}
