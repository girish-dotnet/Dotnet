using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;

namespace ReflectionClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ReflectionDemos.Employ objEmp = new ReflectionDemos.Employ();
            Type typeObj = typeof(ReflectionDemos.Employ);
            foreach (MethodInfo mi in typeObj.GetMethods())
            {
                Console.WriteLine("Following are the methods in Test class");
                Console.WriteLine("Method {0}", mi.Name);
            }

            //FieldInfo[] f = typeObj.GetFields();
            FieldInfo f1 = typeObj.GetField("city");
            f1.SetValue(objEmp, "Chennai");
            Console.WriteLine("Value " +f1.GetValue(objEmp));
            foreach(FieldInfo f in typeObj.GetFields())
            {
                Console.WriteLine("Following are the Fields in Test class");
                Console.WriteLine("Field {0}", f.Name);
            }

            foreach(ConstructorInfo c in typeObj.GetConstructors())
            {
                Console.WriteLine("Following are the Constructors in Test class");
                Console.WriteLine("Constructor {0}", c.Name);
            }
        }
    }
}
