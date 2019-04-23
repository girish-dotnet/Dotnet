using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capgemini.EmployDetails.Exceptions;
using Capgemini.EmployDetails.DataAccessLayer;
using Capgemini.EmployDetails.Entities;


namespace Capgemini.EmployDetails.BusinessLayer
{

    public class EmployBL
    {
        public static List<Employ> GetAllEmployBL()
        {
            List<Employ> employList = null;
            EmployDAL guestDAL = new EmployDAL();
            employList = guestDAL.GetAllEmployDAL();
            return employList;

        }
        public static bool UpdateEmployBL(Employ employ)
        {
            bool employUpdated = false;

            try
            {
                if (Validate(employ))
                {
                    EmployDAL employDAL = new EmployDAL();
                    employUpdated = employDAL.UpdateEmployDAL(employ);
                }
            }
            catch (EmployException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return employUpdated;
        }
        public static bool DeleteEmployBL(int employID)
        {
            bool employDeleted = false;

            try
            {
                if (employID > 0)
                {
                    EmployDAL employDAL = new EmployDAL();
                    employDeleted = employDAL.DeleteEmployDAL(employID);
                }
                else
                {
                    throw new EmployException("Invalid Employ ID");
                }
            }
            catch (EmployException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return employDeleted;
        }

        public static Employ SearchEmployBL(int searchEmployID)
        {
            Employ searchedEmploy = null;

            try
            {
                EmployDAL employDAL = new EmployDAL();
                searchedEmploy = employDAL.SearchEmployDAL(searchEmployID);
            }
            catch (EmployException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return searchedEmploy;
        }
        public static bool AddEmployBL(Employ employ)
        {
            bool employAdded = false;

            try
            {
                if (Validate(employ))
                {
                    EmployDAL employDAL = new EmployDAL();
                    employAdded = employDAL.AddEmployDAL(employ);
                }
            }
            catch (EmployException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return employAdded;
        }
        private static bool Validate(Employ employ)
        {
            StringBuilder sb = new StringBuilder();

            bool validateEmploy = true;

            if (employ.EmployName == string.Empty)
            {
                validateEmploy = false;
                sb.Append(Environment.NewLine + "Employ Name Required");
            }
            //if (employ.Department != "Java" || employ.Department != "Dotnet" ||
            //    employ.Department != "Sql")
            //{
            //    validateEmploy = false;
            //    sb.Append(Environment.NewLine + "Java or Dotnet or Sql only allowed...");
            //}
            if(employ.Salary < 10000)
            {
                validateEmploy = false;
                sb.Append(Environment.NewLine + "Salary cannot be less than 1000");
            }
            if(employ.Salary > 99999)
            {
                validateEmploy = false;
                sb.Append(Environment.NewLine + "Salary cannot cross 99999");
            }
            if (validateEmploy == false)
            {
                throw new EmployException(sb.ToString());
            }
            return validateEmploy;
        }

    }
}
