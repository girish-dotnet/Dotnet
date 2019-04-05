using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsStudent
{
    public class Student
    {
        public string fname;
        public string lname;
        public string city;
        public int Sno { get; set; } 
        public string Course { get; set; }
        public double Cgp { get; set; }
        public Student()
        {
        }
        public Student(string fname,string lname,string city)
        {
            this.fname = fname;
            this.lname = lname;
            this.city = city;
        }
    }
}
