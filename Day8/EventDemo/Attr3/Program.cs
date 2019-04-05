using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Attr3
{
    public class CheckStatus : Attribute
    {
        private bool Val = false;
        public bool status
        {
            get { return Val; }
        }
        public CheckStatus(bool val)
        {
            Val = val;
        }
    }
    [CheckStatus(true)]
    public class Test
    {
        private string EmpName;
        private string Country;
        public Test(string name, string country)
        {
            this.EmpName = name;
            this.Country = country;
        }
        public string FullDetails()
        {
            string str = null;
            Type type = this.GetType();
            CheckStatus[] attrib =
               (CheckStatus[])type.GetCustomAttributes(typeof(CheckStatus), false);
            if (attrib[0].status == true)
            {
                str = EmpName + "-" + Country;
            }
            else
            {
                str = "Hi " + EmpName;
            }
            return str;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test obj = new Test("Ram", "India");
            Console.WriteLine("Welcome:{0}", obj.FullDetails());
            Console.WriteLine(obj.FullDetails());
           
        }
    }
}
