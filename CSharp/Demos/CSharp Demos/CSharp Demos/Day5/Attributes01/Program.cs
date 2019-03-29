using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/*
 * Program to demonstrate Attribute
 */ 


namespace Attributes01
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class Sample : Attribute
    {
        private string name;

        public string Name //Name is called as Named Parameter
        {
            get { return name; }
            set { name = value; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Sample(string name)//name is positional Parameter
        {
            Name = name;
        }

    }

    [Sample("John", Age = 30)]
    [Sample("Carmel", Age = 21)]
    class SampleTest
    {
        static void Main(string[] args)
        {
            Attribute[] attr = Attribute.GetCustomAttributes(typeof(SampleTest));
            Sample sample = (Sample)attr[0];
            Console.WriteLine("{0}-{1}", sample.Name, sample.Age);

            Console.ReadKey();
        }
    }
}
