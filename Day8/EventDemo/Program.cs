using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    class Demo
    {
        public delegate void Training(string participant);
        public static event Training ReportOnTime;
        public static event Training EscalateToHR;

        public static void Venue(string venue)
        {
            Console.WriteLine("Venue is " + venue);
        }

        public static void Ontime(string participant)
        {
            Console.WriteLine(participant + " You came Ontime Go to Class");
        }

        public static void HrReport(string participant)
        {
            Console.WriteLine(participant + " Please meet HR as You came late today");
        }
        static void Main(string[] args)
        {
            int hr;
            string student;
            Console.WriteLine("Enter Student and Report Time");
            student = Console.ReadLine();
            hr = Convert.ToInt32(Console.ReadLine());
         
            if(hr <= 9)
            {
                ReportOnTime += new Training(Ontime);
                ReportOnTime(student);
            }
            else
            {
                EscalateToHR += new Training(HrReport);
                EscalateToHR(student);
            }
        
        }
    }
}
