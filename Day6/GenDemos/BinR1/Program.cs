using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace BinR1
{
    class Program
    {
        public void Show()
        {
            FileStream fs = new FileStream("c:\\files\\bin1.txt", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            int x = br.ReadInt32();
            int y = br.ReadInt32();
            int c = x + y;
            Console.WriteLine("Sum is  " +c);
            br.Close();
            fs.Close();
        }
        static void Main(string[] args)
        {
            new Program().Show();
        }
    }
}
