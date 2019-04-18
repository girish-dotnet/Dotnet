using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObservableCollectionWithDatabase
{
    public class Student
    {
        private int studentId;
        private string studentName;

        public Student()
        {

        }
        public Student(int studentId, string studentName)
        {
            this.studentId = studentId;
            this.studentName = studentName;
        }

        public int StudentID
        {
            get
            {
                return studentId;
            }
            set
            {
                studentId = value;
            }
        }

        public string StudentName
        {
            get
            {
                return studentName;
            }
            set
            {
                studentName = value;
            }
        }
    }
}
