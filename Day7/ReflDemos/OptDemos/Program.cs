using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptDemos
{
    class Demo
    {
        public void Show(string company,string course="Dotnet")
        {
            Console.WriteLine($"Company {company} Course {course}");
        }

        public void Venue(string city,string venue="Capgemini")
        {
            Console.WriteLine($"City {city} Venue {venue}");
        }
        static void Main(string[] args)
        {
            Demo obj = new Demo();
            obj.Show("Capgemini");
            obj.Venue("Hyderabad");
            obj.Show("Capgemini", "Javascript");
            obj.Venue("Hyderabad", "Cg");
        }
    }
}
