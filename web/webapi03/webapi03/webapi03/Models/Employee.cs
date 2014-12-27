using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace webapi02.Models
{
    public class Employee : ICloneable
    {
        #region "Public fields"
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Gender { get; set; }

        // Trusted Connection
        public static String strDbCon =
            "Server=zhoukai\\sql2012;database=Company_zk;Trusted_Connection=True";

        #endregion

        #region "Constructors"
        public Employee()
        {
            this.Id = 0;
            this.FirstName = String.Empty;
            this.LastName = String.Empty;
            this.Gender = "M";

        }

        public Employee(int Id, String firstLame, String lastName, String gender)
        {
            this.Id = Id;
            this.FirstName = firstLame;
            this.LastName = lastName;
            this.Gender = gender;
        }

        #endregion

        #region "Functions"
        public List<Employee> GetAllEmployees()
        {
            List<Employee> allEmployees = new List<Employee>();
            String strQueryById = "SELECT * FROM Employee";
            using (SqlConnection dbCon = new SqlConnection(strDbCon))
            using (SqlCommand dbCmd = new SqlCommand(strQueryById, dbCon))
            {
                try
                {
                    if (dbCon.State == ConnectionState.Closed) { dbCon.Open(); }
                    SqlDataReader reader = dbCmd.ExecuteReader();
                    while (reader.Read())
                    {
                        allEmployees.Add(GetEmployeeFromDBReader(reader));
                    }
                }
                catch (SqlException se) { throw new Exception(se.Message); }
            }

            return allEmployees;
        }

        // Controller --> Http, GET
        public Employee GetEmployeeById(int id)
        {
            Employee e = new Employee();
            String strQueryById = "SELECT * FROM Employee WHERE ID = {0}";
            strQueryById = String.Format(strQueryById, id);
            using (SqlConnection dbCon = new SqlConnection(strDbCon))
            using (SqlCommand dbCmd = new SqlCommand(strQueryById, dbCon))
            {
                try
                {
                    if (dbCon.State == ConnectionState.Closed) { dbCon.Open(); }
                    SqlDataReader reader = dbCmd.ExecuteReader();
                    int count = 0;
                    while (reader.Read())
                    {
                        count++;
                        e = GetEmployeeFromDBReader(reader);
                    }
                    if (count > 1) throw new Exception("Duplicated employee id.");
                }
                catch (SqlException se) { throw new Exception(se.Message); }
            }

            return e;
        }

        // Controller --> Http, GET
        public Employee GetEmployeeByFullName(String FirstName, 
            String LastName)
        {
            Employee e = new Employee();
            String strQueryByName = "SELECT * FROM Employee WHERE FirstName" +
            " = '{0}'AND LastName = '{1}'";
            strQueryByName = String.Format(strQueryByName, FirstName, LastName);
            using (SqlConnection dbCon = new SqlConnection(strDbCon))
            using (SqlCommand dbCmd = new SqlCommand(strQueryByName, dbCon))
            {
                try
                {
                    if (dbCon.State == ConnectionState.Closed) { dbCon.Open(); }
                    SqlDataReader reader = dbCmd.ExecuteReader();
                    int count = 0;
                    while (reader.Read())
                    {
                        count++;
                        e = GetEmployeeFromDBReader(reader);
                    }
                    if (count > 1) throw new Exception(
                        "Duplicated employee id.");
                }
                catch (SqlException se) { throw new Exception(se.Message); }
            }

            return e;
        }

        // Controller, Http GET
        // [Route("employees/{FirstName}")]
        public Employee GetEmployeeByFirstName(String FirstName)
        {
            Employee e = new Employee();
            String strQueryByName = 
                "SELECT * FROM Employee WHERE FirstName = '{0}'";
            strQueryByName = String.Format(strQueryByName, FirstName, LastName);
            using (SqlConnection dbCon = new SqlConnection(strDbCon))
            using (SqlCommand dbCmd = new SqlCommand(strQueryByName, dbCon))
            {
                try
                {
                    if (dbCon.State == ConnectionState.Closed) { dbCon.Open(); }
                    SqlDataReader reader = dbCmd.ExecuteReader();
                    int count = 0;
                    while (reader.Read())
                    {
                        count++;
                        e = GetEmployeeFromDBReader(reader);
                    }
                    // allow more than 1 entities with the same first name
                    // if (count > 1) throw new Exception("Duplicated employee id.");
                }
                catch (SqlException se) { throw new Exception(se.Message); }
            }

            return e;
        }

        // Controller --> Http, REMOVE
        public Employee DeleteEmployeeById(int id)
        {
            Employee e = new Employee();

            return e;
        }

        // Controller --> Http, PUT
        public Employee UpdateEmployeeById(Employee e)
        {
            String updateObjById = "UPDATE Employee SET FirstName = " +
            " '{0}', LastName = '{1}', Gender = '{2}' WHERE ID = {3}";
            updateObjById = String.Format(updateObjById, e.FirstName,
                e.LastName, e.Id);
            using (SqlConnection dbCon = new SqlConnection(strDbCon))
            using (SqlCommand dbCmd = new SqlCommand(updateObjById, dbCon))
            {
                try
                {
                    if (dbCon.State == ConnectionState.Closed) { dbCon.Open(); }
                    int count = dbCmd.ExecuteNonQuery();
                    
                    if (count != 1) throw new Exception(
                        "Should update 1 row, but it didn't.");
                }
                catch (SqlException se) { throw new Exception(se.Message); }
            }

            return e;
        }

        public Employee GetEmployeeFromDBReader(IDataReader reader)
        {
            Employee e = new Employee()
            {
                Id = Convert.ToInt32(reader["Id"]),
                FirstName = Convert.ToString(reader["FirstName"]),
                LastName = Convert.ToString(reader["LastName"]),
                Gender = Convert.ToString(reader["Gender"])
            };

            return e;
        }

        public Employee CreateEmployee(Employee e)
        {
            // insert the provided employee into the database
            String strInsertObj = "INSERT INTO Employee VALUES(" +
                "{0}, '{1}', '{2}', '{3}')";
            strInsertObj = String.Format(strInsertObj, e.Id, e.FirstName, 
                e.LastName, e.Gender);
            using (SqlConnection dbCon = new SqlConnection(strDbCon))
            using (SqlCommand dbCmd = new SqlCommand(strInsertObj, dbCon))
            {
                int nRowsAffected = 0;
                try
                {
                    if (dbCon.State == ConnectionState.Closed) { dbCon.Open(); }
                    nRowsAffected = dbCmd.ExecuteNonQuery();
                    e = GetEmployeeById(e.Id);
                }
                catch (SqlException se) { throw new Exception(se.Message); }
                catch (Exception ee) { throw new Exception(ee.Message); }

                if (nRowsAffected != 1)
                {
                    throw new Exception("Should inserted one row, but actually, it didn't.");
                }
            }

            return e;
        }

        // implement the Clone method in the ICloneable interface
        object ICloneable.Clone()
        {
            Employee e = new Employee()
            {
                Id = this.Id,
                FirstName = this.FirstName,
                LastName = this.LastName,
                Gender = this.Gender
            };

            return (object)e;
        }

        #endregion

    }
}