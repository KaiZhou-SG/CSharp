using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolSystem.SystemGlobals;
using System.Data;
using System.Data.SqlClient;

namespace SchoolSystem.Login.DAL
{
    public class LoginDAL
    {
        #region "Public Static Functions"
        public static bool IsUserAlreadyLoggedIn(int userId)
        {
            bool retVal = false;
            SqlConnection dbCon = new SqlConnection(SystemVariables.strDbCon);
            string sqlQuery = String.Format("SELECT COUNT(UserID) FROM dbo.CurrentUsers WHERE UserID = {0}", userId);
            try
            {
                if (dbCon.State != ConnectionState.Open) { dbCon.Open(); }
                SqlCommand dbCmd = new SqlCommand(sqlQuery, dbCon);
                if ((int)dbCmd.ExecuteScalar() == 0)
                {
                    retVal = true; 
                }
            }
            catch (InvalidCastException ice) { throw ice; }
            catch (SqlException se) { throw se; }
            catch (InvalidOperationException ioe) { throw ioe; }
            finally { dbCon.Close(); }

            return retVal;
        }

        public static bool IsUserAlreadyLoggedIn(string userName)
        {
            bool retVal = false;
            SqlConnection dbCon = new SqlConnection(SystemVariables.strDbCon);
            string sqlQuery = String.Format("SELECT COUNT(UserName) FROM dbo.CurrentUsers WHERE UserID = {0}", userName);
            try
            {
                if (dbCon.State != ConnectionState.Open) { dbCon.Open(); }
                SqlCommand dbCmd = new SqlCommand(sqlQuery, dbCon);
                if ((int)dbCmd.ExecuteScalar() == 0)
                {
                    retVal = true;
                }
            }
            catch (InvalidCastException ice) { throw ice; }
            catch (SqlException se) { throw se; }
            catch (InvalidOperationException ioe) { throw ioe; }
            finally { dbCon.Close(); }

            return retVal;
        }

        public static bool ForceUserLogout(int userId)
        {
            bool retVal = false;
            SqlConnection dbCon = new SqlConnection(SystemVariables.strDbCon);
            string sqlQuery = String.Format("DELETE FROM dbo.CurrentUsers WHERE UserID = {0}", userId);
            try
            {
                if (dbCon.State != ConnectionState.Open) { dbCon.Open(); }
                SqlCommand dbCmd = new SqlCommand(sqlQuery, dbCon);
                dbCmd.ExecuteNonQuery();
                retVal = true;
            }
            catch (InvalidCastException ice) { throw ice; }
            catch (SqlException se) { throw se; }
            catch (InvalidOperationException ioe) { throw ioe; }
            finally { dbCon.Close(); }

            return retVal;    
        }

        public static bool ForceUserLogout(string userName)
        {
            bool retVal = false;
            SqlConnection dbCon = new SqlConnection(SystemVariables.strDbCon);
            string sqlQuery = String.Format("DELETE FROM dbo.CurrentUsers WHERE UserID = {0}", userName);
            try
            {
                if (dbCon.State != ConnectionState.Open) { dbCon.Open(); }
                SqlCommand dbCmd = new SqlCommand(sqlQuery, dbCon);
                dbCmd.ExecuteNonQuery();
                retVal = true;
            }
            catch (InvalidCastException ice) { throw ice; }
            catch (SqlException se) { throw se; }
            catch (InvalidOperationException ioe) { throw ioe; }
            finally { dbCon.Close(); }

            return retVal; 
        }
        #endregion

    }
}
