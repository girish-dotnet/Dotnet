using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employ_DAL;
using Emp_Exceptions;
using System.Text.RegularExpressions;
using EmpEntity;

namespace Employ_BLL
{
    public class EmployValidation
    {
        static List<Employ> empList = new List<Employ>();
        EmployOperation operationObj;

        public void SerializeEmployeeBLL()
        {
            try
            {
                EmployOperation.SerializeEmployeeDAL();
            }
            catch (Exception ex) { throw ex; }
        }

        public List<Employ> DeserializeEmployeeBLL()
        {
            List<Employ> empList = null;
            try
            {
                empList = EmployOperation.DeserializeEmployeeDAL();

                if (empList.Count <= 0) throw new EmployException("No records found");
            }
            catch (EmployException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            return empList;
        }
        public bool ValidateEmploy(Employ newEmploy)
        {
            bool isValidEmploy = true;
            StringBuilder sb = new StringBuilder();
            if(newEmploy.Empno <= 0)
            {
                isValidEmploy = false;
                sb.Append("Employ No Cannot be Zero or Negative " + Environment.NewLine);
            }
            if(newEmploy.Name.Length==0)
            {
                isValidEmploy = false;
                sb.Append("Name Cannot be Empty..." + Environment.NewLine);
            }
            if(newEmploy.Doj >= DateTime.Now)
            {
                isValidEmploy = false;
                sb.Append("Doj cannot be tomorrow's date..." + Environment.NewLine);
            }
            if (!(Regex.IsMatch(newEmploy.Mobile, "[0-9]{10}")))
            {
                isValidEmploy = false;
                sb.Append("Employee Mobile should have 10 digits " + Environment.NewLine);
            }

            if (!isValidEmploy)
            { throw new EmployException(sb.ToString()); }

            return isValidEmploy;
        } 

        public bool AddEmployBLL(Employ newEmploy)
        {
            bool isEmployAdded = false;
            operationObj = new EmployOperation();
            if (ValidateEmploy(newEmploy))
            {
                isEmployAdded = operationObj.AddEmployDAL(newEmploy);
            }
            else
            {
                Console.WriteLine("error");
                throw new 
                    EmployException("Validation Failed!!!Employ Record could not be added");
            }
            return isEmployAdded;
        }

        public List<Employ> DisplayEmployBLL()
        {
            operationObj = new EmployOperation();
            empList = operationObj.DisplayEmployDAL(); 
            if(empList.Count <= 0)
            {
                throw new EmployException("No Records Found");
            }
            return empList;
        }

        public bool DeleteEmployBLL(int empno)
        {
            bool isDeleted = false;
            operationObj = new EmployOperation();
            isDeleted = operationObj.DeleteEmployDAL(empno);
            if(isDeleted==false)
            {
                throw new EmployException("Employ No Not Found...");
            }
            return isDeleted;
        }
        public bool UpdateEmployBLL(Employ editEmploy)
        {
            operationObj = new EmployOperation();
            bool isUpdated = false;
            isUpdated = operationObj.UpdateEmployDAL(editEmploy);
            if(isUpdated==false)
            {
                throw new EmployException("Employ No Not Found...");
            }
            return isUpdated;
        }


        public Employ SearchEmployBLL(int empno)
        {
            operationObj = new EmployOperation();
            Employ searchEmploy = null;
            searchEmploy = operationObj.SearchEmployDAL(empno); 
            if(searchEmploy==null)
            {
                throw new EmployException("Employee not found");
            }
            return searchEmploy;
        }
    }
}
