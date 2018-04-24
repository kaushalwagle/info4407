using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Deliv6
{
    static class DAL
    {
        private static string _ReadOnlyConnectionString = "Server=134.50.214.81;" +
                                                  "Database=;" +
                                                  "User Id=;" +
                                                  "Password=;";
        private static string _EditOnlyConnectionString = "Server=134.50.214.81;" +
                                                     "Database=;" +
                                                     "User Id=;" +
                                                     "Password=;";

        /// <summary>
        /// Gets a Employee object from the database by id.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public static Employee GetEmployee(int id)
        {
            Employee retEmployee = new Employee();

            Employee emp = null;
            try
            {
                //entering false to get a read only connection
                SqlConnection conn = GetSQLConnection(false);
                conn.Open();
                //SPOC from DataBase
                string CommandText = "sprocEmployeesGetById";
                //Get a command object entering the conenction from previously and the commandtext
                SqlCommand comm = GetSQLSPROCCommand(conn, CommandText);
                //Create a parameter to enter into the SPROC
                SqlParameter paraTitle = new SqlParameter("@EmployeeID", id);
                //Add the parameter to the command object
                comm.Parameters.Add(paraTitle);
                //execute the reader
                SqlDataReader dr = comm.ExecuteReader();

                while (dr.Read())
                {
                    //create a new employee for each row returned
                    emp = new Employee();
                    //create a person for each employee returned
                    Person pers = new Person();

                    //Gets the personID and geta a Person for the Employee
                    int.TryParse(dr["PersonID"].ToString(), out int PID);
                    pers = GetPerson(PID);

                    //Pass a SqlDataReader and a Person to fill the Employee
                    emp.FillEmployee(dr, pers);

                  
                    retEmployee = emp;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return retEmployee;
        }


        /// <summary>
        /// Gets a Person object from the database by id.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public static Person GetPerson(int id)
        {
            Person retPers = new Person();

            Person person = null;

            try
            {
                //entering false to get a read only connection
                SqlConnection conn = GetSQLConnection(false);
                conn.Open();
                //SPOC from DataBase
                string CommandText = "sprocPersonGetById";
                //Get a command object entering the conenction from previously and the commandtext
                SqlCommand comm = GetSQLSPROCCommand(conn, CommandText);
                //Create a parameter to enter into the SPROC
                SqlParameter paraTitle = new SqlParameter("@PersonID", id);
                //Add the parameter to the command object
                comm.Parameters.Add(paraTitle);
                //execute the reader
                SqlDataReader dr = comm.ExecuteReader();

                while (dr.Read())
                {
                    //Create a new person for each row
                    person = new Person();
                    //pass an SqlDataReader to fill the Person
                    person.FillPerson(dr);

                    retPers = person;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return retPers;
        }

        /// <summary>
        /// Enter true if the connection string if for editing user, or false for read only user
        /// </summary>
        /// <param name="IsEdit"></param>
        /// <returns>SQL Connection object</returns>
        public static SqlConnection GetSQLConnection(bool IsEdit)
        {
            if (IsEdit == true)
            {
                //Returns connection with the edit only connection string
                SqlConnection conn = new SqlConnection(_EditOnlyConnectionString);
                return conn;
            }
            else
            {
                //Returns connection with the read only conenction string
                SqlConnection conn = new SqlConnection(_ReadOnlyConnectionString);
                return conn;
            }
        }


        /// <summary>
        /// Enter SQL SPROC name as string
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="command"></param>
        /// <returns>SQLCommand Object</returns>
        public static SqlCommand GetSQLSPROCCommand(SqlConnection conn, string command)
        {
            //returns the command as a stored procedure 
            SqlCommand comm = new SqlCommand(command)
            {
                Connection = conn,
                CommandType = System.Data.CommandType.StoredProcedure
            };

            return comm;
        }

    }
}