using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParams
{
    class Program
    {
        public static void Show(string firstName,string lastName,string city,string course)
        {
            Console.WriteLine("First Name " +firstName);
            Console.WriteLine("Last Name " +lastName);
            Console.WriteLine("City  " +city);
            Console.WriteLine("Course " +course);
        }
        static void Main(string[] args)
        {
            Show("Bangalore", "Dotnet", "Reddy", "Aruna");
            Show(city: "Bangalore", course: "Dotnet", lastName: "Reddy", firstName: "Aruna");
        }
    }
}






