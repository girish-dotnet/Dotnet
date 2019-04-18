using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data;

namespace DAL
{
    public class DataConnection
    {
        //Creates and prepare a new DBCommand object on a new Connection
        public static DbCommand CreateCommand()
        {
            //Obtain the database provider name
            string dataProviderName = PhoneBookConfiguration.ProviderName;

            //Obtain the database ConnectionString
            string connectionString = PhoneBookConfiguration.ConnectionString;

            //Create a New Data Provider Factory
            DbProviderFactory factory = DbProviderFactories.GetFactory(dataProviderName);

            //Obtain the Database specific connection object
            DbConnection connection = factory.CreateConnection();

            //Set the Connection string
            connection.ConnectionString = connectionString;

            //Create a Database specific command Object
            DbCommand command = connection.CreateCommand();

            //Set the command Type to Stored Procedure
            command.CommandType = CommandType.StoredProcedure;

            //Return the Initialized Command Object
            return command;
        }

        // Execute a select command and returns Records as DataTable
        public static DataTable ExecuteSelectCommand(DbCommand command)
        {
            //The Datatable to be returned
            DataTable dataTable = null;
            //Execute the command making sure the connection gets closed in the end
            try
            {
                //open the connection
                command.Connection.Open();
                //Execute the Command and store the results in a datatable
                DbDataReader dataReader = command.ExecuteReader();
                dataTable = new DataTable();
                dataTable.Load(dataReader);
                //Close the reader
                dataReader.Close();
            }
            catch (DbException ex)
            {
                throw ex;
            }
            finally
            {
                //Close the Connection
                if (command.Connection.State == ConnectionState.Open)
                    command.Connection.Close();
            }
            return dataTable;
        }

        // execute an update, delete, or insert command 
        // and return the number of affected rows
        public static int ExecuteNonQueryCommand(DbCommand command)
        {
            // The number of affected rows 
            int affectedRows = -1;
            // Execute the command making sure the connection gets closed in the end
            try
            {
                // Open the connection of the command
                command.Connection.Open();
                // Execute the command and get the number of affected rows
                affectedRows = command.ExecuteNonQuery();
            }
            catch (DbException ex)
            {
                throw ex;
            }
            finally
            {
                //Close the Connection
                if (command.Connection.State == ConnectionState.Open)
                    command.Connection.Close();
            }
            // return the number of affected rows
            return affectedRows;
        }

        // execute a select command and return a single result as a string
        public static object ExecuteScalarCommand(DbCommand command)
        {

            // The value to be returned 
            object result = null;
            // Execute the command making sure the connection gets closed in the end
            try
            {
                // Open the connection of the command
                command.Connection.Open();
                // Execute the command and get the aggregate value
                result = command.ExecuteScalar();
            }
            catch (DbException ex)
            {
                throw ex;
            }

            finally
            {
                //Close the Connection
                if (command.Connection.State == ConnectionState.Open)
                    command.Connection.Close();
            }
            // return the result
            return result;
        }
    }
}

