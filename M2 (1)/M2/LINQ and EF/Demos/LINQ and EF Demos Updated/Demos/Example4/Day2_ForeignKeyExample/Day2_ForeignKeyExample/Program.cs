using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_ForeignKeyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SampleDBContext dbcontext = new SampleDBContext())
            {
                Standard[] std = new Standard[] 
                {
                    new Standard{StandardName="ABC"},
                    new Standard{StandardName="PQR"}
                };

                Student[] stud = new Student[] 
                {
                    new Student{StudentName="Vijay",StandardId=1},
                    new Student{StudentName="Ajay",StandardId=2},
                    new Student{StudentName="Suresh",StandardId=1}
                };

                dbcontext.Standards.AddRange(std);
                dbcontext.Students.AddRange(stud);

                dbcontext.SaveChanges();

                Console.WriteLine("Sucess....");
            }
        }
    }
}
