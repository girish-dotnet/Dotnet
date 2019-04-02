using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginDemo
{
    class Login
    {
        public void Check(string user,string pwd)
        {
            Dictionary<string, string> users = new Dictionary<string, string>();
            users.Add("Tamil", "Selva");
            users.Add("Aruna", "Reddy");
            users.Add("Arun", "Arun");
            users.Add("Jitu", "Capgemini");
            string res = string.Empty;
            users.TryGetValue(user, out res);
            if (res.Equals(pwd))
            {
                Console.WriteLine("Correct Credentials...");
            }
            else
            {
                Console.WriteLine("Invalid Credentials...");
            }
        }
        static void Main(string[] args)
        {
            string user, pwd;
            Console.WriteLine("Enter UserName and Password   ");
            user = Console.ReadLine();
            pwd = Console.ReadLine();
            new Login().Check(user, pwd);
        }
    }
}
