using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_ForeignKeyExample
{
    public class Student
    {
        public Student()
        { }

        public int StudentID { get; set; }
        public string StudentName { get; set; }

        //Foreign key for Standard
        //[ForeignKey("StdID")]
        public int StandardId { get; set; }

        public Standard Standard { get; set; }
    }
}
