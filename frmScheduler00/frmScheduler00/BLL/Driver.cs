using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using frmScheduler00.DAL;

namespace frmScheduler00.BLL
{
    /// <summary>
    /// The Driver class.
    /// </summary>
    public class Driver
    {
        #region "Properties"
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsAvailable { get; set; }
        public int DefaultVehicleID { get; set; }
        public string StrIsAvailable { get { return IsAvailable.ToString(); } }
        #endregion

        #region "Constructors"
        /// <summary>
        /// The default constructor
        /// </summary>
        public Driver()
        {
            this.ID = 0;
            this.Name = String.Empty;
            this.IsAvailable = false;
            this.DefaultVehicleID = 0;
        }

        /// <summary>
        /// The constructor, all properties initialized
        /// </summary>
        /// <param name="id">driver id</param>
        /// <param name="name">driver name</param>
        /// <param name="isAvailable">driver availability</param>
        /// <param name="defaultVehicleID">the id of the driver's default vehicle</param>
        public Driver(int id, string name, bool isAvailable, int defaultVehicleID)
        {
            this.ID = id;
            this.Name = name;
            this.IsAvailable = isAvailable;
            this.DefaultVehicleID = defaultVehicleID;
        }
        #endregion

        #region "Methods"
        /// <summary>
        /// Get all the drivers, either available or not.
        /// </summary>
        /// <returns>All the drivers.</returns>
        public static List<Driver> GetAllDrivers()
        {
            return DriverDAL.GetAllDrivers();
        }

        /// <summary>
        /// Get driver by driver ID.
        /// </summary>
        /// <param name="driverId">The driver ID</param>
        /// <returns>The driver with id = driverId</returns>
        public static Driver GetDriver(int driverID)
        {
            return DriverDAL.GetDriver(driverID);
        }

        /// <summary>
        /// Set driver with id = driverID to available.
        /// </summary>
        /// <param name="driverID">the provided driver id</param>
        public static void SetDriverToAvaliable(int driverID)
        {
            DriverDAL.SetDriverToAvaliable(driverID);
        }

        /// <summary>
        /// Set this driver to available
        /// </summary>
        public void SetDriverToAvaliable()
        {
            DriverDAL.SetDriverToAvaliable(this.ID);
        }

        /// <summary>
        /// Set driver with id = driverID to un-available.
        /// </summary>
        /// <param name="driverID">the provided driver id</param>
        public static void SetDriverToUnAvaliable(int driverID)
        {
            DriverDAL.SetDriverToUnAvaliable(driverID);
        }

        /// <summary>
        /// Set this driver to un-available
        /// </summary>
        public void SetDriverToUnAvaliable()
        {
            DriverDAL.SetDriverToUnAvaliable(this.ID);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="DriverID"></param>
        /// <param name="date"></param>
        public static void SetDriverToAvaliableOnGivenDate(int DriverID, DateTime date)
        {
            DriverDAL.SetDriverToAvaliableOnGivenDate(DriverID, date);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="DriverID"></param>
        /// <param name="date"></param>
        public static void SetDriverToUnAvaliableOnGivenDate(int DriverID, DateTime date)
        {
            DriverDAL.SetDriverToUnAvaliableOnGivenDate(DriverID, date);
        }
        #endregion
    }
}
