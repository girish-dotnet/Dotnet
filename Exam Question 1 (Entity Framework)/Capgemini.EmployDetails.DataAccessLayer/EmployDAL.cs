using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Capgemini.EmployDetails.Entities;
using Capgemini.EmployDetails.Exceptions;
using System.Threading.Tasks;

namespace Capgemini.EmployDetails.DataAccessLayer
{
    public class EmployDAL
    {
        EmployContext context = new EmployContext();

        public List<Employ> GetAllEmployDAL()
        {
            List<Employ> employList = null;
            try
            {
                employList = context.Employs.ToList();
            }
            catch (Exception ex)
            {

                throw new EmployException(ex.Message);
            }
            return employList;
        }

        public bool DeleteEmployDAL(int employID)
        {
            bool employDeleted = false;
            try
            {
                Employ employ = null;
                employ = context.Employs.Where(e => e.EmployID ==
                employID).Select(e => e).FirstOrDefault();
                if (employ != null)
                {
                    context.Employs.Remove(employ);
                    int status = context.SaveChanges();
                    if (status > 0)
                    {
                        employDeleted = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new EmployException(ex.Message);
            }
            return employDeleted;
        }

        public bool UpdateEmployDAL(Employ employ)
        {
            bool employupdated = false;
            try
            {
                Employ oldEmploy = null;
                oldEmploy = context.Employs.Where(e => e.EmployID == 
                    employ.EmployID).Select(e => e).FirstOrDefault();
                if (oldEmploy != null)
                {
                    oldEmploy.EmployName = employ.EmployName;
                    oldEmploy.Department = employ.Department;
                    oldEmploy.Salary = employ.Salary;
                    int status = context.SaveChanges();
                    if (status > 0)
                    {
                        employupdated = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new EmployException(ex.Message);
            }
            return employupdated;
        }

        public Employ SearchEmployDAL(int employID)
        {
            Employ searchedEmploy = null;
            try
            {
                searchedEmploy = context.Employs.Where(e =>
                    e.EmployID == employID).Select(e => e).FirstOrDefault();
            }
            catch (Exception ex)
            {

                throw new EmployException(ex.Message);
            }
            return searchedEmploy;
        }

        public bool AddEmployDAL(Employ employ)
        {
            bool employAdded = false;
            try
            {
                context.Employs.Add(employ);
                
                int status = context.SaveChanges();

                if (status > 0)
                {
                    employAdded = true;
                }
            }
            catch (Exception ex)
            {

                throw new EmployException(ex.Message);
            }
            return employAdded;
        }
    
    }
}
