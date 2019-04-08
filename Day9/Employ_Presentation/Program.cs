using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpEntity;
using Employ_BLL;
using Employ_DAL;
using Emp_Exceptions;

namespace Employ_Presentation
{
    class Program
    {
        static EmployValidation objValidation;


        public static void PrintMenu()
        {
            Console.WriteLine("============================================");
            Console.WriteLine("Employee Management System Menu");
            Console.WriteLine("Press 1 To Add New Employee");
            Console.WriteLine("Press 2 To Display All Employees");
            Console.WriteLine("Press 3 To Search Employee");
            Console.WriteLine("Press 4 To Delete Employee");
            Console.WriteLine("Press 5 To Update Employee");
            Console.WriteLine("Press 6 To Store Data in File");
            Console.WriteLine("Press 7 To Display Data from File");
            Console.WriteLine("Press 8 To Exit");
            Console.WriteLine("============================================");
        }
        public static void DeleteEmploy()
        {
            try
            {
                Console.WriteLine("Enter EmployNo to Delete ");
                int empno = Convert.ToInt32(Console.ReadLine());
                if (objValidation.DeleteEmployBLL(empno))
                {
                    Console.WriteLine("Employ Deleted...");
                }
            }
            catch(EmployException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        }
        public static void UpdateEmploy()
        {
            try
            {
                Employ emp = new Employ();
                Console.WriteLine("Enter Employee Id to be updated:");
                emp.Empno = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee Name :");
                emp.Name = Console.ReadLine();
                Console.WriteLine("Enter Employee Department :");
                emp.Dept = Console.ReadLine();
                Console.WriteLine("Enter Employee Salary :");
                emp.Salary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Employee DOJ :");
                emp.Doj = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee Designation :");
                emp.Desig = Console.ReadLine();
                Console.WriteLine("Enter Employee Mobile :");
                emp.Mobile = Console.ReadLine();
                if (objValidation.UpdateEmployBLL(emp))
                {
                    Console.WriteLine("Employ Updated...");
                }
            }
            catch(EmployException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void DisplayEmploy()
        {
            try
            {
              
                List<Employ> empList = objValidation.DisplayEmployBLL();
                Console.WriteLine("List of Employees ");
                foreach (Employ e in empList)
                {
                    Console.WriteLine("Empno " + e.Empno);
                    Console.WriteLine("Name  " + e.Name);
                    Console.WriteLine("Dept " + e.Dept);
                    Console.WriteLine("Salary " + e.Salary);
                    Console.WriteLine("Mobile " + e.Mobile);
                    Console.WriteLine("--------------------------------");
                }
            }
            catch(EmployException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public static void SearchEmploy()
        {
            try
            {
                Employ empSearch = null;
        
                int empno;
                Console.WriteLine("Enter Employ no   ");
                empno = Convert.ToInt32(Console.ReadLine());
                empSearch = objValidation.SearchEmployBLL(empno);
                if (empSearch != null)
                {
                    Console.WriteLine("Name  " + empSearch.Name);
                    Console.WriteLine("Mobile " + empSearch.Mobile);
                    Console.WriteLine("Department  " + empSearch.Dept);
                    Console.WriteLine("Designation  " + empSearch.Desig);
                    Console.WriteLine("Salary " + empSearch.Salary);
                }

            }
            catch(EmployException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine( e.Message);
            }
        }
        public static void AddEmploy()
        {
            try
            {
                objValidation = new EmployValidation();
                Employ newEmploy = new Employ();
                Console.WriteLine("Enter Employ No  ");
                newEmploy.Empno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Employ Name   ");
                newEmploy.Name = Console.ReadLine();
                Console.WriteLine("Enter Department  ");
                newEmploy.Dept = Console.ReadLine();
                Console.WriteLine("Enter Designation  ");
                newEmploy.Desig = Console.ReadLine();
                Console.WriteLine("Enter Salary ");
                newEmploy.Salary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter DateofJoining  ");
                newEmploy.Doj = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Enter Gender ");
                newEmploy.Gender = Console.ReadLine();
                Console.WriteLine("Enter Mobile  ");
                newEmploy.Mobile = Console.ReadLine();
                if (objValidation.ValidateEmploy(newEmploy))
                {
                    objValidation.AddEmployBLL(newEmploy);
                    Console.WriteLine("Employ Record Added Successfully...");
                }
            }
            catch(EmployException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void DeserializeEmployee()
        {
            try
            {
                List<Employ> eList = objValidation.DeserializeEmployeeBLL();
                Console.WriteLine("Records from File: ");
                foreach (Employ e in eList)
                {
                    Console.WriteLine("Empno " + e.Empno);
                    Console.WriteLine("Name  " + e.Name);
                    Console.WriteLine("Dept " + e.Dept);
                    Console.WriteLine("Salary " + e.Salary);
                    Console.WriteLine("Mobile " + e.Mobile);
                    Console.WriteLine("--------------------------------");
                }
            }
            catch (EmployException ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private static void SerializeEmployee()
        {
            try
            {
                objValidation.SerializeEmployeeBLL();
                Console.WriteLine("Employee Record stored in File");
            }
            catch (EmployException ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            byte choice;
            do
            {
                PrintMenu();
                Console.WriteLine("Enter Your Choice:");
                bool chkChoice;

                chkChoice = byte.TryParse(Console.ReadLine(), out choice);
                if (!chkChoice) { Console.WriteLine("Invalid Input "); }
                switch (choice)
                {
                    case 1:
                        AddEmploy();
                        break;
                    case 2:
                        DisplayEmploy();
                        break;
                    case 3:
                        SearchEmploy();
                        break;
                    case 4:
                        DeleteEmploy();
                        break;
                    case 5:
                        UpdateEmploy();
                        break;
                    case 6:
                        SerializeEmployee();
                        break;
                    case 7:
                        DeserializeEmployee();
                        break;
                    case 8:
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } while (choice != 6);

            Console.ReadKey();
        }
    
    }
}
