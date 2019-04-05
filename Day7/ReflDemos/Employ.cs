using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflDemos
{
    class Employ
    {
        public string city;
        public string course;
        public string moduleName;

        public int Empno { get; set; }
        public string Name { get; set; }
        public double Basic { get; set; }

        public Employ()
        {
            Empno = 1;
            Name = "Aurn";
            Basic = 82834;
        }

        public Employ(string city,string course,string moduleName)
        {
            this.city = city;
            this.course = course;
            this.moduleName = moduleName;
        }
        public void Show()
        {
            Console.WriteLine("Empno " +Empno + " Name " +Name+ " Basic " +Basic);
        }
    }
}
