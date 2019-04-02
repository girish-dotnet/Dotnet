using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictDemo
{
    class Demo
    {
        public void Show(int empno)
        {
            Dictionary<int, string> dicEmp = new Dictionary<int, string>();
            dicEmp.Add(1, "Arun");
            dicEmp.Add(3, "Dhivya");
            dicEmp.Add(4, "Likhita");
            dicEmp.Add(5, "Jitu");
            string res = string.Empty;
            dicEmp.TryGetValue(empno, out res);
            Console.WriteLine("Result is  " +res);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employ No  ");
            int empno = Convert.ToInt32(Console.ReadLine());
            new Demo().Show(empno);
        }
    }
}
