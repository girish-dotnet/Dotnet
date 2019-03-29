using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

/*
 * Program to Serialize and Deserialize Custom Type
 */

namespace IOSerialization06
{
    [Serializable]
    public class Employee : IDeserializationCallback
    {
        private string employeeName;

        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }

        private DateTime employeeDOB;

        public DateTime EmployeeDOB
        {
            get { return employeeDOB; }
            set { employeeDOB = value; }
        }

        [NonSerialized]
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        #region IDeserializationCallback Members

        public void OnDeserialization(object sender)
        {
            age = DateTime.Now.Year - EmployeeDOB.Year;
        }

        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Serialize Employee Object
            SerializeData(new Employee { EmployeeName = "Ajit", EmployeeDOB = DateTime.Parse("12/12/1981") });

            //Deserialize Employee Object
            DeSerializeData();

            Console.ReadKey();
        }


        private static void SerializeData(Employee employee)
        {

            FileStream fileStream = new FileStream("d:\\Employee.dat", FileMode.Create);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fileStream, employee);
            fileStream.Close();
        }

        private static void DeSerializeData()
        {
            FileStream fileStream = new FileStream("d:\\Employee.dat", FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Employee employee = binaryFormatter.Deserialize(fileStream) as Employee;
            Console.WriteLine("Employee Name = {0} Age = {1}", employee.EmployeeName, employee.Age);
            fileStream.Close();

        }
    }
}
