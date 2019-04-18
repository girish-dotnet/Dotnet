using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo06
{
    public class SplashAppContext:ApplicationContext
    {
        //SplashAppContext's instance Variable to hold MainWindowForm
        Form mainForm = null;

        //Creating Timer Variable
        Timer splashTimer = new Timer();

        public SplashAppContext(Form mainForm, Form splashForm)
            : base(splashForm)//Setting SplashScreen Window as a MainForm
        {
            //MainFormWindow is set to SplashAppContext's mainForm instance variable
            this.mainForm = mainForm;

            splashTimer.Tick += new EventHandler(SplashTimerUp);
            splashTimer.Interval = 2000;
            splashTimer.Enabled = true;
        }

        //Gets Executed after 2 seconds
        void SplashTimerUp(object sender, EventArgs e)
        {
            splashTimer.Enabled = false; //Disabling timer
            splashTimer.Dispose();
            base.MainForm.Close(); //Closing Splash Screen
        }

        //This method gets executed when the MainForm is Closed
        protected override void OnMainFormClosed(object sender, EventArgs e)
        {
            //Executes only if sender is SplashScreen
            if (sender is SplashScreen)
            {
                base.MainForm = this.mainForm;
                base.MainForm.Show();
            }
            else
            {
                //Executes when actual MainWindow gets closed.
                base.OnMainFormClosed(sender, e);
            }
        }
    }
}
