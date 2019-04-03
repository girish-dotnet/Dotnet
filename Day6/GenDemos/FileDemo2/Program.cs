using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace FileDemo2
{
    class Program
    {
        public void ShowFile()
        {
            FileStream fs = new FileStream(@"c:\files\Hello.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str;
            while((str=sr.ReadLine()) != null)
            {
                Console.WriteLine(str);
            }
            sr.Close();
            fs.Close();
        }
        static void Main(string[] args)
        {
            new Program().ShowFile();
        }
    }
}
