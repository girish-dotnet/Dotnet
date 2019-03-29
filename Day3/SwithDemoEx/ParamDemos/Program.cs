using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamDemos
{
    class Demo
    {
        public void Attendance(params string[] names)
        {
            foreach(string s in names)
            {
                Console.Write(s + "  ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Demo obj = new Demo();
            obj.Attendance();
            obj.Attendance("Arun", "Dhivya");
            obj.Attendance("Arun", "Bhargav", "Sangeetha");
            obj.Attendance("Arun", "Sangeetha", "Pallavi", "Priya");
        }
    }
}
