using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using frmScheduler00.BLL;

namespace frmScheduler00.DAL
{
    /// <summary>
    /// The data access layer of the Vehicle class.
    /// </summary>
    public class VehicleDAL
    {
        public static List<Vehi> GetAllDrivers()
        {
            List<Vehicle> lstVehicle = new List<Vehicle>();
            string strDBConnection = Helper.DBHelper.getDbConnectionString();
            string sqlQuery = "SELECT * FROM dbo.Vehicle";
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
                    lstVehicle.Add(GetVehicle(dbRdr));
                }
            }
            catch (SqlException se) { throw se; }
            catch (Exception e) { throw e; }
            finally { dbCon.Close(); }

            return lstVehicle;
        }

        /// <summary>
        /// Create a driver object from the SqlDataReader
        /// </summary>
        /// <param name="dbRdr">From the SqlDataReader</param>
        /// <returns>Returns the driver object from IDataReader</returns>
        /// <exception cref="InvalidCastException">InvalidCastException may be thrown</exception>
        public static Vehicle GetVehicle(IDataReader dbRdr)
        {
            Vehicle tmp;
            try
            {
                tmp = new Vehicle(Convert.ToInt32(dbRdr["ID"]),
                               Convert.ToInt32(dbRdr["VehicleType"]),
                               Convert.ToDecimal(dbRdr["MaxLoad"]),
                               Convert.ToInt32(dbRdr["IsAvailable"]) == 0 ? false : true
                               );
            }
            catch (InvalidCastException ice) { throw ice; }

            return tmp;
        }

        public static Vehicle GetVehicle(int driverId)
        {
            Vehicle tmp = new Vehicle();
            string strDBConnection = Helper.DBHelper.getDbConnectionString();
            string sqlQuery = "SELECT * FROM dbo.Vehicle WHERE ID = {0}";
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
                    tmp = GetVehicle(dbRdr);
                    iTest++;
                }
                if (iTest > 1)
                {
                    throw new Exception("Expect to get one vehicle, but more drivers are got.");
                }
            }
            catch (SqlException se) { throw se; }
            catch (Exception e) { throw e; }
            finally { dbCon.Close(); }

            return tmp;
        }

        public static void SetVehicleToAvaliable(int driverID)
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
