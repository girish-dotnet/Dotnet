using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Capgemini.EmployDetails.Entities;
using Capgemini.EmployDetails.Exceptions;
using Capgemini.EmployDetails.BusinessLayer;
using System.Threading.Tasks;

namespace EmployDetailsApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                PrintMenu();
                Console.WriteLine("Enter your Choice:");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddEmploy();
                        break;
                    case 2:
                        ListAllEmployees();
                        break;
                    case 3:
                        SearchEmployByID();
                        break;
                    case 4:
                        UpdateEmploy();
                        break;
                    case 5:
                        DeleteEmploy();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } while (choice != -1);
        }

        private static void ListAllEmployees()
        {
            try
            {
                List<Employ> employList = EmployBL.GetAllEmployBL();
                if (employList != null)
                {
                    Console.WriteLine("******************************************************************************");
                    Console.WriteLine("EmployID\t\tName\t\tDepartment\t\tSalary");
                    Console.WriteLine("******************************************************************************");
                    foreach (Employ employ in employList)
                    {
                        Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", employ.EmployID, employ.EmployName, employ.Department, employ.Salary);
                    }
                    Console.WriteLine("******************************************************************************");

                }
                else
                {
                    Console.WriteLine("No Employ Details Available");
                }
            }
            catch (EmployException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void AddEmploy()
        {
            try
            {
                Employ newEmploy = new Employ();
                //Console.WriteLine("Enter GuestID :");
                //newGuest.GuestID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Employ Name :");
                newEmploy.EmployName = Console.ReadLine();
                Console.WriteLine("Enter Department :");
                newEmploy.Department = Console.ReadLine();
                Console.WriteLine("Enter Salary  ");
                newEmploy.Salary = Convert.ToInt32(Console.ReadLine());
                bool employAdded = EmployBL.AddEmployBL(newEmploy);
                if (employAdded)
                {
                    Console.WriteLine("Employ Added");
                }
                else
                {
                    Console.WriteLine("Employ not Added");
                }
            }
            catch (EmployException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void SearchEmployByID()
        {
            try
            {
                int searchEmployID;
                Console.WriteLine("Enter EmployID to Search:");
                searchEmployID = Convert.ToInt32(Console.ReadLine());
                Employ searchEmploy = EmployBL.SearchEmployBL(searchEmployID);
                if (searchEmploy != null)
                {
                    Console.WriteLine("******************************************************************************");
                    Console.WriteLine("EmployID\t\tName\t\tDepartment\t\tSalary");
                    Console.WriteLine("******************************************************************************");
                    Console.WriteLine("{0}\t\t{1}\t\t{2}{3}", searchEmploy.EmployID, searchEmploy.EmployName, searchEmploy.Department, searchEmploy.Salary);
                    Console.WriteLine("******************************************************************************");
                }
                else
                {
                    Console.WriteLine("No Employ Details Available");
                }
            }
            catch (EmployException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void DeleteEmploy()
        {
            try
            {
                int deleteEmployID;
                Console.WriteLine("Enter EmployID to Delete:");
                deleteEmployID = Convert.ToInt32(Console.ReadLine());
                Employ deleteEmploy = EmployBL.SearchEmployBL(deleteEmployID);
                if (deleteEmploy != null)
                {
                    bool guestdeleted = EmployBL.DeleteEmployBL(deleteEmployID);
                    if (guestdeleted)
                    {
                        Console.WriteLine("Employ Deleted");
                    }
                    else
                    {
                        Console.WriteLine("Employ not Deleted ");
                    }
                }
                else
                {
                    Console.WriteLine("No Employ Details Available");
                }
            }
            catch (EmployException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void UpdateEmploy()
        {
            try
            {
                int updateEmployID;
                Console.WriteLine("Enter EmployID to Update Details:");
                updateEmployID = Convert.ToInt32(Console.ReadLine());
                Employ updatedEmploy = EmployBL.SearchEmployBL(updateEmployID);
                if (updatedEmploy != null)
                {
                    Console.WriteLine("Update Employ Name :");
                    updatedEmploy.EmployName = Console.ReadLine();
                    Console.WriteLine("Update Employ Department ");
                    updatedEmploy.Department = Console.ReadLine();
                    Console.WriteLine("Update Salary :");
                    updatedEmploy.Salary = Convert.ToInt32(Console.ReadLine());
                    bool employUpdated = EmployBL.UpdateEmployBL(updatedEmploy);
                    if (employUpdated)
                    {
                        Console.WriteLine("Employ Details Updated");
                    }
                    else
                    {
                        Console.WriteLine("Employ Details not Updated ");
                    }
                }
                else
                {
                    Console.WriteLine("No Employ Details Available");
                }
            }
            catch (EmployException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void PrintMenu()
        {
            Console.WriteLine("\n***********Employ Menu Class Exercise***********");
            Console.WriteLine("1. Add Employ");
            Console.WriteLine("2. List All Employees");
            Console.WriteLine("3. Search Employee by ID");
            Console.WriteLine("4. Update Employee");
            Console.WriteLine("5. Delete Employee");
            Console.WriteLine("6. Exit");
            Console.WriteLine("******************************************\n");
        }
    }

}
