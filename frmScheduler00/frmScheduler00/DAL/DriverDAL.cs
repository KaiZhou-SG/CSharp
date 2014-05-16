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
    internal class DriverDAL
    {
        internal static List<Driver> GetAllDrivers()
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
        internal static Driver GetDriver(IDataReader dbRdr)
        {
            Driver tmp;
            try
            {
                tmp = new Driver(Convert.ToInt32(dbRdr["ID"]),
                               Convert.ToString(dbRdr["Name"]),
                               Convert.ToInt32(dbRdr["IsAvailable"]) == 0 ? false : true,
                               Convert.ToInt32(dbRdr["DefaultVehicleID"]));
            }
            catch (NullReferenceException ne) { throw ne; }
            catch (InvalidCastException ice) { throw ice; }
            
            return tmp;
        }

        internal static Driver GetDriver(int driverId)
        {
            Driver tmp = new Driver();
            string strDBConnection = Helper.DBHelper.getDbConnectionString();
            string sqlQuery = "SELECT * FROM dbo.Driver WHERE ID = {0}";
            sqlQuery = String.Format(sqlQuery, driverId);
            SqlConnection dbCon = new SqlConnection(strDBConnection);
            SqlCommand dbCmd = new SqlCommand();
            SqlTransaction tran;

            try
            {
                if (dbCon.State == ConnectionState.Closed) { dbCon.Open(); }
                tran = dbCon.BeginTransaction();
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
                    tran.Rollback();
                    throw new Exception("Expect to get one driver, but more drivers are got.");
                }

                tran.Commit();
            }
            catch (SqlException se) { throw se; }
            catch (Exception e) { throw e; }
            finally { dbCon.Close(); }

            return tmp;
        }

        internal static void SetDriverToAvaliable(int driverID)
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

                dbTran.Commit();
            }
            catch (SqlException se) { throw se; }
            catch (Exception e) { throw e; }
            finally { dbCon.Close(); }
        }

        internal static void SetDriverToUnAvaliable(int driverID)
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

                dbTran.Commit();
            }
            catch (SqlException se) { throw se; }
            catch (Exception e) { throw e; }
            finally { dbCon.Close(); }
        }

        internal static void SetDriverToAvaliableOnGivenDate(int DriverID, DateTime date)
        {
            string strDBConnection = Helper.DBHelper.getDbConnectionString();
            string strDate = date.ToString("yyyy-MM-dd HH:mm:ss");
            string sqlQuery = "SELECT COUNT (PlanDate) FROM dbo.DriverAvailability " +
                "WHERE DriverID = {0} AND PlanDate = '{1}'";
            sqlQuery = String.Format(sqlQuery, DriverID, strDate);
            SqlConnection dbCon = new SqlConnection(strDBConnection);
            SqlCommand dbCmd = new SqlCommand();
            SqlTransaction dbTran;

            try
            {
                if (dbCon.State == ConnectionState.Closed) { dbCon.Open(); }
                dbCmd.Connection = dbCon;
                dbCmd.CommandType = CommandType.Text;
                dbCmd.CommandText = sqlQuery;
                int count = Convert.ToInt32(dbCmd.ExecuteScalar());
                if (count == 1)
                {
                    sqlQuery = "UPDATE dbo.DriverAvailability SET DriverAvailable = 1";
                    dbCmd.CommandType = CommandType.Text;
                    dbCmd.CommandText = sqlQuery;
                    dbTran = dbCon.BeginTransaction();
                    dbCmd.Transaction = dbTran;
                    if (Convert.ToInt32(dbCmd.ExecuteNonQuery()) != 1)
                    {
                        dbTran.Rollback();
                        throw new Exception("Expect to update one driver, but zero or more drivers are updated.");
                    }

                    dbTran.Commit();
                }
                else
                {
                    sqlQuery = "INSERT INTO dbo.DriverAvailability VALUES (" +
                        "'{0}', {1}, {2})";
                    sqlQuery = String.Format(sqlQuery, strDate, DriverID, 1);
                    dbCmd.CommandType = CommandType.Text;
                    dbCmd.CommandText = sqlQuery;
                    dbCmd.ExecuteNonQuery();
                }
            }
            catch (SqlException se) { throw se; }
            catch (Exception e) { throw e; }
            finally { dbCon.Close(); }
        }

        internal static void SetDriverToUnAvaliableOnGivenDate(int DriverID, DateTime date)
        {
            string strDBConnection = Helper.DBHelper.getDbConnectionString();
            string strDate = date.ToString("yyyy-MM-dd HH:mm:ss");
            string sqlQuery = "SELECT COUNT (PlanDate) FROM dbo.DriverAvailability " +
                "WHERE DriverID = {0} AND PlanDate = '{1}'";
            sqlQuery = String.Format(sqlQuery, DriverID, strDate);
            SqlConnection dbCon = new SqlConnection(strDBConnection);
            SqlCommand dbCmd = new SqlCommand();
            SqlTransaction dbTran;

            try
            {
                if (dbCon.State == ConnectionState.Closed) { dbCon.Open(); }
                dbCmd.Connection = dbCon;
                dbCmd.CommandType = CommandType.Text;
                dbCmd.CommandText = sqlQuery;
                int count = Convert.ToInt32(dbCmd.ExecuteScalar());
                if (count == 1)
                {
                    sqlQuery = "UPDATE dbo.DriverAvailability SET DriverAvailable = 0";
                    dbCmd.CommandType = CommandType.Text;
                    dbCmd.CommandText = sqlQuery;
                    dbTran = dbCon.BeginTransaction();
                    dbCmd.Transaction = dbTran;
                    if (Convert.ToInt32(dbCmd.ExecuteNonQuery()) != 1)
                    {
                        dbTran.Rollback();
                        throw new Exception("Expect to update one driver, but zero or more drivers are updated.");
                    }
                    dbTran.Commit();

                }
                else
                {
                    sqlQuery = "INSERT INTO dbo.DriverAvailability VALUES (" +
                        "'{0}', {1}, {2})";
                    sqlQuery = String.Format(sqlQuery, strDate, DriverID, 0);
                    dbCmd.CommandType = CommandType.Text;
                    dbCmd.CommandText = sqlQuery;
                    dbCmd.ExecuteNonQuery();
                }
            }
            catch (SqlException se) { throw se; }
            catch (Exception e) { throw e; }
            finally { dbCon.Close(); }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="driverId"></param>
        /// <returns></returns>
        internal static DriverAvailability GetDriverAvailability(DateTime date, int driverId)
        {
            DriverAvailability tmp = new DriverAvailability();
            string strDBConnection = Helper.DBHelper.getDbConnectionString();
            string strDate = date.ToString("yyyy-MM-dd HH:mm:ss");
            string sqlQuery = "SELECT * FROM dbo.DriverAvailability WHERE PlanDate = '{0}' AND DriverID = {1}";
            sqlQuery = String.Format(sqlQuery, strDate, driverId);
            SqlConnection dbCon = new SqlConnection(strDBConnection);
            SqlCommand dbCmd = new SqlCommand();
            SqlTransaction tran;

            try
            {
                if (dbCon.State == ConnectionState.Closed) { dbCon.Open(); }
                tran = dbCon.BeginTransaction();
                dbCmd.Connection = dbCon;
                dbCmd.Transaction = tran;
                dbCmd.CommandType = CommandType.Text;
                dbCmd.CommandText = sqlQuery;

                SqlDataReader dbRdr = dbCmd.ExecuteReader();
                int iTest = 0;
                while (dbRdr.Read())
                {
                    tmp = GetDriverAvailability(dbRdr);
                    iTest++;
                }
                if (iTest > 1)
                {
                    tran.Rollback();
                    throw new Exception("Expect to get one record, but more records are got.");
                }

                tran.Commit();
            }
            catch (SqlException se) { throw se; }
            catch (Exception e) { throw e; }
            finally { dbCon.Close(); }

            return tmp;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="driverId"></param>
        /// <returns></returns>
        internal static List<DriverAvailability> GetAllAvailabilityByDriver(int driverId)
        {
            List<DriverAvailability> tmp = new List<DriverAvailability>();
            string strDBConnection = Helper.DBHelper.getDbConnectionString();
            string sqlQuery = "SELECT * FROM dbo.DriverAvailability WHERE DriverID = {1}";
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
                while (dbRdr.Read())
                {
                    tmp.Add(GetDriverAvailability(dbRdr));
                }
            }
            catch (SqlException se) { throw se; }
            catch (Exception e) { throw e; }
            finally { dbCon.Close(); }

            return tmp;
        }

        internal static List<DriverAvailability> GetAllAvailability()
        {
            List<DriverAvailability> tmp = new List<DriverAvailability>();
            string strDBConnection = Helper.DBHelper.getDbConnectionString();
            string sqlQuery = "SELECT * FROM dbo.DriverAvailability";
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
                    tmp.Add(GetDriverAvailability(dbRdr));
                }
            }
            catch (SqlException se) { throw se; }
            catch (Exception e) { throw e; }
            finally { dbCon.Close(); }

            return tmp;
        }

        internal static DriverAvailability GetDriverAvailability(IDataReader dbRdr)
        {
            DriverAvailability tmp;
            try
            {
                tmp = new DriverAvailability(Convert.ToDateTime(dbRdr["PlanDate"]),
                               Convert.ToInt32(dbRdr["DriverID"]),
                               (Convert.ToBoolean(dbRdr["DriverAvailable"]) ? true : false));
            }
            catch (NullReferenceException ne) { throw ne; }
            catch (InvalidCastException ice) { throw ice; }

            return tmp;
        }
    }
}
