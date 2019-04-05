using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Attr1
{
    class Program
    {
        [DllImport("user32.dll", EntryPoint = "MessageBox")]
        public static extern int ShowMessageBox(int hWnd, string text, string caption, 
            uint type);
   
        static void Main(string[] args)
        {
            string caption = "Hello World";
            string text = "Sample Article on DLLImport Attribute";
            Program.ShowMessageBox(0, text, caption, 0);
        }
    }
}

