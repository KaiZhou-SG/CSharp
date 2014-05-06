using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using frmScheduler00.BLL;
using System.Data;
using System.Data.SqlClient;

namespace frmScheduler00.DAL
{
    /// <summary>
    /// The DriverDAL class, which is a data access layer.
    /// </summary>
    public class DriverDAL
    {
        public static List<Driver> GetAllDrivers()
        {
            List<Driver> lstDriver = new List<Driver>();
            string strDBConnection = Helper.DBHelper.getDbConnectionString();
            string sqlQuery = "SELECT * FROM dbo.Driver";
            SqlConnection dbCon = new SqlConnection(strDBConnection);
            SqlCommand dbCmd = new SqlCommand();

            try
            {
                if (dbCon.State == ConnectionState.Closed) { dbCon.Open(); }
                dbCmd.Connection = dbCon;
                dbCmd.CommandType = CommandType.Text;
                dbCmd.CommandText = sqlQuery;

                SqlDataReader dbRdr = dbCmd.ExecuteReader();
                while (dbRdr.Read())
                {
                    lstDriver.Add(GetDriver(dbRdr));
                }
            }
            catch (SqlException se) { throw se; }
            catch (Exception e) { throw e; }
            finally{dbCon.Close();}

            return lstDriver;
        }

        /// <summary>
        /// Create a driver object from the SqlDataReader
        /// </summary>
        /// <param name="dbRdr">From the SqlDataReader</param>
        /// <returns>Returns the driver object from IDataReader</returns>
        /// <exception cref="InvalidCastException">InvalidCastException may be thrown</exception>
        public static Driver GetDriver(IDataReader dbRdr)
        {
            Driver tmp;
            try
            {
                tmp = new Driver(Convert.ToInt32(dbRdr["ID"]),
                               Convert.ToString(dbRdr["Name"]),
                               Convert.ToInt32(dbRdr["IsAvailable"]) == 0 ? false : true,
                               Convert.ToInt32(dbRdr["DefaultVehicleID"]));
            }
            catch (InvalidCastException ice) { throw ice; }
            
            return tmp;
        }

        public static Driver GetDriver(int driverId)
        {
            Driver tmp = new Driver();
            string strDBConnection = Helper.DBHelper.getDbConnectionString();
            string sqlQuery = "SELECT * FROM dbo.Driver WHERE ID = {0}";
            sqlQuery = String.Format(sqlQuery, driverId);
            SqlConnection dbCon = new SqlConnection(strDBConnection);
            SqlCommand dbCmd = new SqlCommand();

            try
            {
                if (dbCon.State == ConnectionState.Closed) { dbCon.Open(); }
                dbCmd.Connection = dbCon;
                dbCmd.CommandType = CommandType.Text;
                dbCmd.CommandText = sqlQuery;

                SqlDataReader dbRdr = dbCmd.ExecuteReader();
                int iTest = 0;
                while (dbRdr.Read())
                {
                    tmp = GetDriver(dbRdr);
                    iTest++;
                }
                if (iTest > 1)
                {
                    throw new Exception("Expect to get one driver, but more drivers are got.");
                }
            }
            catch (SqlException se) { throw se; }
            catch (Exception e) { throw e; }
            finally { dbCon.Close(); }

            return tmp;
        }

        public static void SetDriverToAvaliable(int driverID)
        {
            string strDBConnection = Helper.DBHelper.getDbConnectionString();
            string sqlQuery = "UPDATE dbo.Driver SET IsAvailable = 1 WHERE ID = {0}";
            sqlQuery = String.Format(sqlQuery, driverID);
            SqlConnection dbCon = new SqlConnection(strDBConnection);
            SqlCommand dbCmd = new SqlCommand();
            SqlTransaction dbTran;

            try
            {
                if (dbCon.State == ConnectionState.Closed) { dbCon.Open(); }
                dbTran = dbCon.BeginTransaction();
                dbCmd.Connection = dbCon;
                dbCmd.Transaction = dbTran;
                dbCmd.CommandType = CommandType.Text;
                dbCmd.CommandText = sqlQuery;
                int iTest = 0;

                iTest = dbCmd.ExecuteNonQuery();
                
                if (iTest > 1)
                {
                    dbTran.Rollback();
                    throw new Exception("Expect to update one driver, but more drivers are updated.");
                }
            }
            catch (SqlException se) { throw se; }
            catch (Exception e) { throw e; }
            finally { dbCon.Close(); }
        }

        public static void SetDriverToUnAvaliable(int driverID)
        {
            string strDBConnection = Helper.DBHelper.getDbConnectionString();
            string sqlQuery = "UPDATE dbo.Driver SET IsAvailable = 0 WHERE ID = {0}";
            sqlQuery = String.Format(sqlQuery, driverID);
            SqlConnection dbCon = new SqlConnection(strDBConnection);
            SqlCommand dbCmd = new SqlCommand();
            SqlTransaction dbTran;

            try
            {
                if (dbCon.State == ConnectionState.Closed) { dbCon.Open(); }
                dbTran = dbCon.BeginTransaction();
                dbCmd.Connection = dbCon;
                dbCmd.Transaction = dbTran;
                dbCmd.CommandType = CommandType.Text;
                dbCmd.CommandText = sqlQuery;
                int iTest = 0;

                iTest = dbCmd.ExecuteNonQuery();

                if (iTest > 1)
                {
                    dbTran.Rollback();
                    throw new Exception("Expect to update one driver, but more drivers are updated.");
                }
            }
            catch (SqlException se) { throw se; }
            catch (Exception e) { throw e; }
            finally { dbCon.Close(); }
        }
    }
}
