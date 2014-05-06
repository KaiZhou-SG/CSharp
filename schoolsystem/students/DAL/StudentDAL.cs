using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SchoolSystem.Students.BLL;
using SchoolSystem.SystemGlobals;

namespace SchoolSystem.Students.DAL
{
    public class StudentDAL
    {
        #region "Public Methods"
        public static Student GetStudent(int stuId)
        {
            Student stu = null;
            string strQuery = "SELECT * FROM dbo.Students WHERE ID = @id;";
            SqlConnection dbCon = new SqlConnection(SystemVariables.strDbCon);

            try
            {
                if (dbCon.State != ConnectionState.Open) { dbCon.Open(); }
                SqlCommand dbCmd = new SqlCommand(strQuery, dbCon);
                dbCmd.Parameters.AddWithValue("id", stuId);
                SqlDataReader sr = dbCmd.ExecuteReader();
                stu = GetStudent(sr);
            }
            catch (InvalidCastException ice) { throw ice; }
            catch (SqlException se) { throw se; }
            catch (InvalidOperationException ioe) { throw ioe; }
            finally { dbCon.Close(); }

            return stu;
        }

        public static List<Student> GetAllStudents()
        {
            List<Student> lstStudents = new List<Student>();
            string strQuery = "SELECT * FROM dbo.Students;";
            SqlConnection dbCon = new SqlConnection(SystemVariables.strDbCon);

            try
            {
                if (dbCon.State != ConnectionState.Open) { dbCon.Open(); }
                SqlCommand dbCmd = new SqlCommand(strQuery, dbCon);
                SqlDataReader sr = dbCmd.ExecuteReader();
                lstStudents.Add(GetStudent(sr));
            }
            catch (InvalidCastException ice) { throw ice; }
            catch (SqlException se) { throw se; }
            catch (InvalidOperationException ioe) { throw ioe; }
            finally { dbCon.Close(); }

            return lstStudents;
        }

        public static Student GetStudent(IDataReader reader)
        {
            Student stu = new Student();
            stu.ID = Convert.ToInt32(reader["ID"]);
            stu.ClassID = Convert.ToInt32(reader["ClassID"]);
            stu.Name = reader["Name"].ToString();
            stu.Gender = Convert.ToChar(reader["Gender"]);
            stu.Age = Convert.ToInt32(reader["Age"]);
            stu.Grade = Convert.ToInt32(reader["Grade"]);

            return stu;
        }

        public static bool RegisterStudent(int stuId, int clsId)
        {
            bool retVal = false;
            
            return retVal;
        }

        public static bool UnregisterStudent(int stuId)
        {
            bool retVal = false;
            
            return retVal;
        }

        public static bool UnregisterStudentFromClass(int stuId, int clsId)
        {
            bool retVal = false;

            return retVal;
        }

        public static bool DeleteStudent(int stuId)
        {
            bool retValue = false;
            string strQuery = "DELETE FROM dbo.Students WHERE ID = @id;";
            SqlConnection dbCon = new SqlConnection(SystemVariables.strDbCon);

            try
            {
                if (dbCon.State != ConnectionState.Open) { dbCon.Open(); }
                SqlCommand dbCmd = new SqlCommand(strQuery, dbCon);
                dbCmd.Parameters.AddWithValue("id", stuId);
                dbCmd.ExecuteNonQuery();
                retValue = true;
            }
            catch (InvalidCastException ice) { throw ice; }
            catch (SqlException se) { throw se; }
            catch (InvalidOperationException ioe) { throw ioe; }
            finally { dbCon.Close(); }

            return retValue;
        }
        #endregion
    }
}
