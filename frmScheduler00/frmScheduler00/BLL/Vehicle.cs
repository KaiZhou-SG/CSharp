using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using frmScheduler00.DAL;

namespace frmScheduler00.BLL
{
    /// <summary>
    /// The Vehicle class, represents a vehicle in real-world.
    /// </summary>
    public class Vehicle
    {
        #region "Properties"
        internal int ID { get; set; }
        internal int VehicleType { get; set; }
        internal decimal MaxLoad { get; set; }
        internal bool IsAvailable { get; set; }
        #endregion

        #region "Constructors"
        /// <summary>
        /// The default constructor
        /// </summary>
        internal Vehicle()
        {
            this.ID = 0;
            this.VehicleType = 0;
            this.MaxLoad = 0;
            this.IsAvailable = false;
        }

        /// <summary>
        /// The constructor, all properties initialized
        /// </summary>
        /// <param name="id">driver id</param>
        /// <param name="name">driver name</param>
        /// <param name="isAvailable">driver availability</param>
        /// <param name="defaultVehicleID">the id of the driver's default vehicle</param>
        internal Vehicle(int id, int vehicleType, decimal maxLoad, bool isAvailable)
        {
            this.ID = 0;
            this.VehicleType = vehicleType;
            this.MaxLoad = maxLoad;
            this.IsAvailable = IsAvailable;
        }
        #endregion

        #region "Methods"
        /// <summary>
        /// Get all the vehicles, either available or not.
        /// </summary>
        /// <returns>All the vehicles.</returns>
        public static List<Vehicle> GetAllVehicles()
        {
            return VehicleDAL.GetAllVehicles();
        }

        /// <summary>
        /// Get driver by driver ID.
        /// </summary>
        /// <param name="driverId">The driver ID</param>
        /// <returns>The driver with id = driverId</returns>
        public static Vehicle GetVehicle(int VehicleID)
        {
            return VehicleDAL.GetVehicle(VehicleID);
        }

        /// <summary>
        /// Set driver with id = driverID to available.
        /// </summary>
        /// <param name="driverID">the provided driver id</param>
        public static void SetDriverToAvaliable(int VehicleID)
        {
            VehicleDAL.SetVehicleToAvaliable(VehicleID);
        }

        /// <summary>
        /// Set this driver to available
        /// </summary>
        public void SetDriverToAvaliable()
        {
            VehicleDAL.SetVehicleToAvaliable(this.ID);
        }

        /// <summary>
        /// Set driver with id = driverID to un-available.
        /// </summary>
        /// <param name="driverID">the provided driver id</param>
        public static void SetVehicleToUnAvaliable(int VehicleID)
        {
            VehicleDAL.SetVehicleToUnAvaliable(VehicleID);
        }

        /// <summary>
        /// Set this driver to un-available
        /// </summary>
        public void SetVehicleToUnAvaliable()
        {
            VehicleDAL.SetVehicleToUnAvaliable(this.ID);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="VehicleID"></param>
        /// <param name="date"></param>
        public static void SetVehicleToAvaliableOnGivenDate(int VehicleID, DateTime date)
        {
            VehicleDAL.SetVehicleToAvaliableOnGivenDate(VehicleID, date);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="VehicleID"></param>
        /// <param name="date"></param>
        public static void SetVehicleToUnAvaliableOnGivenDate(int VehicleID, DateTime date)
        {
            VehicleDAL.SetVehicleToUnAvaliableOnGivenDate(VehicleID, date);
        }
        #endregion
    }
}
