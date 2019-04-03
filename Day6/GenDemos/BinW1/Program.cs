using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace BinW1
{
    class Program
    {
        public void Create()
        {
            FileStream fs = new FileStream("c:\\files\\bin1.txt", FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(523);
            bw.Write(234);
            bw.Close();
            fs.Close();
        }
        static void Main(string[] args)
        {
            new Program().Create();
        }
    }
}
