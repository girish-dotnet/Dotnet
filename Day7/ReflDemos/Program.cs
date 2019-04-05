using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;

namespace ReflDemos
{
    //public class FieldsClass
    //{
    //    public string fieldA;
    //    public string fieldB;

    //    public FieldsClass()
    //    {
    //        fieldA = "A public field";
    //        fieldB = "Another public field";
    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            //FieldsClass fieldsInst = new FieldsClass();
            //// Get the type of FieldsClass.
            //Type fieldsType = typeof(FieldsClass);

            //// Get an array of FieldInfo objects.
            //FieldInfo[] fields = fieldsType.GetFields(BindingFlags.Public
            //    | BindingFlags.Instance);
            //// Display the values of the fields.
            //Console.WriteLine("Displaying the values of the fields of {0}:",
            //    fieldsType);
            //for (int i = 0; i < fields.Length; i++)
            //{
            //    Console.WriteLine("   {0}:\t'{1}'",
            //        fields[i].Name, fields[i].GetValue(fieldsInst));
            //}

            Type typeObj = typeof(Employ);

            foreach (MethodInfo mi in typeObj.GetMethods())

            {

                Console.WriteLine("Following are the methods in Test class");

                Console.WriteLine("Method {0}", mi.Name);

            }

            foreach (FieldInfo fi in typeObj.GetFields())

            {

                Console.WriteLine("Following are the fields in Test class");

                Console.WriteLine("Field {0}", fi.Name);

            }

            foreach(ConstructorInfo c in typeObj.GetConstructors())
            {
                Console.WriteLine("Following are Constructors in Employ Class...");
                Console.WriteLine("Constructor {0}",c.Name);
            }

           object o = Activator.CreateInstance(typeObj);

            MethodInfo method = typeObj.GetMethod("Show");

            Console.Write("\t");

            method.Invoke(o, null);


        }
    }
}
