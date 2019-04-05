using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ClientCustomer
{
    class Program
    {
        static void Main(string[] args)
        {
            clsCustomerDemo.Customer obj = new clsCustomerDemo.Customer();
            Type t = typeof(clsCustomerDemo.Customer);
            FieldInfo f = t.GetField("custName");
            f.SetValue(obj,"Arun");
            Console.WriteLine("Name is  " +f.GetValue(obj));

            MethodInfo m = t.GetMethod("Hello");
            m.Invoke(obj, null);
        }
    }
}
