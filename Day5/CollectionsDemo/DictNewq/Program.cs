using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictNewq
{
    class Demo
    {
        public void Check(string name)
        {
            Dictionary<string, double> empDict = new Dictionary<string, double>();
            empDict["arun"] = 85855.64;
            empDict["siva"] = 8842.556;
            empDict["aruna"] = 88664.23;
            empDict["bhargav"] = 88855.23;
            empDict["dhivya"] = 88235.23;
            double res = 0;
            empDict.TryGetValue(name, out res);
            Console.WriteLine("Result is " +res);
        }
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Enter Name  ");
            name = Console.ReadLine();
            new Demo().Check(name);
        }
    }
}
