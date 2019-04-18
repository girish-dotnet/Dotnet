using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo06
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (System.Diagnostics.Process.GetProcessesByName(System.Diagnostics.Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                MessageBox.Show("The Application is Already Running", "Message");
            }
            else
            {
                SplashAppContext splashContext = new SplashAppContext(new MainFormWindow(), new SplashScreen());
                Application.Run(splashContext);
            }
        }
    }
}
