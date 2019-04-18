using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo04
{
    public class AppEventArgs:EventArgs
    {

        private object info;

        public object Info
        {
            get { return info; }
            set { info = value; }
        }

        public AppEventArgs()
        {
            info = null;
        }

        public AppEventArgs(object info)
        {
            this.info = info;
           
        }

    }
}
