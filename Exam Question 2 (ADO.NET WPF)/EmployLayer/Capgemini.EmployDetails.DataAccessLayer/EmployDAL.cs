using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Capgemini.EmployDetails.Entities;
using Capgemini.EmployDetails.Exceptions;
using System.Threading.Tasks;

namespace Capgemini.EmployDetails.DataAccessLayer
{
    public class EmployDAL
    {
        string strcon = ConfigurationManager.ConnectionStrings["sqlpracticeConn"].ConnectionString;
        SqlConnection connection;
        SqlDataAdapter adapter;
        DataSet dataset;
        public DataSet GetAllEmployDAL()
        {
            try
            {
                connection = new SqlConnection(strcon);
                adapter = new SqlDataAdapter("SELECT * FROM EMPLOY", connection);
                dataset = new DataSet();
                adapter.Fill(dataset, "EMPLOYDUMMY");
                return dataset;
            }
            catch (EmployException e)
            {
                throw;
            }
        }

        public bool DeleteEmployDAL(int employID)
        {
            bool employDeleted = false;
            connection = new SqlConnection(strcon);
            adapter = new SqlDataAdapter("SELECT * FROM EMPLOY WHERE EMPNO=@employID", connection);
            adapter.SelectCommand.Parameters.AddWithValue("@employID", employID);
            SqlCommandBuilder cmd = new SqlCommandBuilder(adapter);
            dataset = new DataSet();
            adapter.Fill(dataset, "EMPLOYDUMMY");

            if (dataset.Tables["EMPLOYDUMMY"].Rows.Count > 0)
            {
                DataRow dr = dataset.Tables["EMPLOYDUMMY"].Rows[0];
                dr.Delete();
                adapter.Update(dataset, "EMPLOYDUMMY");
                employDeleted = true;
            }
            return employDeleted;
        }

        public bool UpdateEmployDAL(Employ employ)
        {
            bool employupdated = false;

            connection = new SqlConnection(strcon);
            adapter = new SqlDataAdapter("SELECT * FROM EMPLOY WHERE EMPNO=@employID", connection);
            adapter.SelectCommand.Parameters.AddWithValue("@employID", employ.EmployID);
            SqlCommandBuilder cmd = new SqlCommandBuilder(adapter);
            dataset = new DataSet();
            adapter.Fill(dataset, "EMPLOYDUMMY");
            if (dataset.Tables["EMPLOYDUMMY"].Rows.Count > 0)
            {
                DataRow dr = dataset.Tables["EMPLOYDUMMY"].Rows[0];
                dr["EMPLOYNAME"] = employ.EmployName;
                dr["SALARY"] = employ.Salary;
                adapter.Update(dataset, "EMPLOYDUMMY");
                employupdated = true;
            }
            return employupdated;
        }

        public Employ SearchEmployDAL(int employID)
        {
            connection = new SqlConnection(strcon);
            adapter = new SqlDataAdapter("SELECT * FROM EMPLOY WHERE EMPNO=@employID", connection);
            adapter.SelectCommand.Parameters.AddWithValue("@employID", employID);
            dataset = new DataSet();
            adapter.Fill(dataset, "EMPLOYDUMMY");
            Employ employ = null;
            if(dataset.Tables["EMPLOYDUMMY"].Rows.Count > 0)
            {
                employ = new Employ();
                DataRow dr = dataset.Tables["EMPLOYDUMMY"].Rows[0];
                employ.EmployID = Convert.ToInt32(dr["Empno"]);
                employ.EmployName = dr["EmployName"].ToString();
                employ.Salary = Convert.ToInt32(dr["SALARY"]);
            }
            return employ;
        }

        public bool AddEmployDAL(Employ employ)
        {
            bool employAdded = false;
            connection = new SqlConnection(strcon);
            adapter = new SqlDataAdapter("SELECT * FROM EMPLOY", connection);
            dataset = new DataSet();
            SqlCommandBuilder cmd = new SqlCommandBuilder(adapter);
            adapter.Fill(dataset, "EMPLOYDUMMY");
            DataRow dr = dataset.Tables["EMPLOYDUMMY"].NewRow();
            dr["EMPNO"] = employ.EmployID;
            dr["NAME"] = employ.EmployName;
            dr["SALARY"] = employ.Salary;
            dataset.Tables["EMPLOYDUMMY"].Rows.Add(dr);
            adapter.Update(dataset, "EMPLOYDUMMY");
            employAdded = true;
            return employAdded;
        }
        
    
    }
}
