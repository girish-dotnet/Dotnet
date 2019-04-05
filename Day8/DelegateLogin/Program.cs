using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLogin
{
    class Program
    {
        public delegate void Login(string user);
        public static event Login LoginSuccess;
        public static event Login LoginFailure;

        public static void Success(string user)
        {
            Console.WriteLine("Welcome " +user+ " Capgemini");
        }
        public static void Failure(string user)
        {
            Console.WriteLine("Sorry " +user+ " Invalid Details");
        }
        public static void Check(string user,string pwd)
        {
            Dictionary<string, string> users = new Dictionary<string, string>();
            users["Arun"] = "capgemini";
            users["Aruna"] = "Reddy";
            users["Anu"] = "Pallavi";
            users["Sangeetha"] = "Sangeetha";
            users["Bhargav"] = "Bhargav";

            if(user.Equals("Arun") && pwd.Equals("Capgemini"))
            {
                LoginSuccess += new Login(Success);
                LoginSuccess(user);
            }
            else
            {
                LoginFailure += new Login(Failure);
                LoginFailure(user);
            }
        }
        static void Main(string[] args)
        {
            string user, pwd;
            Console.WriteLine("Enter User and Password  ");
            user = Console.ReadLine();
            pwd = Console.ReadLine();
            Check(user, pwd);
           // Dictionary<string, string> s = new Dictionary<string, string>();
           //for(int i=0;i<5;i++)
           // {
           //     Console.WriteLine("Enter User and Password ");
           //     user = Console.ReadLine();
           //     pwd = Console.ReadLine();
           //     s.Add(user, pwd);
           // }
        }
    }
}
