using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;

namespace AttributesDemo
{
    [AttributeUsage(AttributeTargets.Class)]
    public class FunwithAttribute : Attribute
    {
        public FunwithAttribute(string s)
        {
            this.Company = s;
        }
        public string Company { get; set; }
    }
    [Funwith("Capgemini Technology")]
    public class Test
    {
        public Test(string name, string country)
        {
            this.EmpName = name;
            this.Country = country;
        }
        public string FullDetails()
        {
            string str = EmpName + "-" + Country;
            return str;
        }
        private string EmpName;
        private string Country;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test obj = new Test("Ram", "India");
            Console.WriteLine("Result:{0}", obj.FullDetails());
            Console.ReadKey();

            MemberInfo info = typeof(Test);
            object[] attrib = info.GetCustomAttributes(typeof(FunwithAttribute), false);
            foreach (Object attribute in attrib)
            {
                FunwithAttribute a = (FunwithAttribute)attribute;
                Console.WriteLine("Company: {0}", a.Company);
            }
        }
    }
}
