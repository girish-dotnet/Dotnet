using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVariable
{
    class Cricket
    {
        static int score;
        static Cricket()
        {
            score = 0;
        }
        public void Incr(int x)
        {
            score += x;
        }
        static void Main(string[] args)
        {
            Cricket fb = new Cricket();
            Cricket sb = new Cricket();
            Cricket ext = new Cricket();
            fb.Incr(45);
            sb.Incr(34);
            ext.Incr(7);
            Console.WriteLine("Total Score " +Cricket.score);
        }
    }
}
