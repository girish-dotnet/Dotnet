using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenStudentDemo
{
    class Student
    {
        public int Sno { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public double Cgp { get; set; }
    }
    class Demo
    {
        static void Main(string[] args)
        {
            List<Student> lstStudent = new List<Student>();
            
            lstStudent.Add(new Student { Sno = 1, Name = "Jitu", City = "Chennai", Cgp = 8.6 });
            lstStudent.Add(new Student { Sno = 2, Name = "Arun", City = "Hyderabad", Cgp = 8.7 });
            lstStudent.Add(new Student { Sno = 3, Name = "Siva", City = "Bangalore", Cgp = 7.6 });
            lstStudent.Add(new Student { Sno = 4, Name = "Bhargav", City = "Hyderabad", Cgp = 6.6 });
            lstStudent.Add(new Student { Sno = 5, Name = "Priya", City = "Chennai", Cgp = 7.9 });
          
            foreach(Student s in lstStudent)
            {
                Console.WriteLine(s.Sno + " " +s.Name + " " +s.City + " " +s.Cgp);
            }
            lstStudent.Sort();
        }
    }
}
