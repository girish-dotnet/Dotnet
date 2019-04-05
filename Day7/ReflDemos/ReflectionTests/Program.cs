using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;

namespace ReflectionTests
{
    class Program
    {
        static void Main(string[] args)
        {
            //MemberInfo info = typeof(System.Int32);
            //object[] attributes = info.GetCustomAttributes(true);
            //for (int i = 0; i < attributes.Length; i++)
            //{
            //    System.Console.WriteLine(attributes[i]);
            //}

            Type t = typeof(System.Int32);

  

            foreach(FieldInfo f in t.GetFields())
            {
                Console.WriteLine(f.Name + " " +f.GetValue(null));
            }

            foreach(MethodInfo m in t.GetMethods())
            {
                Console.WriteLine("Methods " +m.Name);
            }
            foreach(ConstructorInfo c in t.GetConstructors())
            {
                Console.WriteLine("Cons " +c.Name);
            }
        }
    }
}
