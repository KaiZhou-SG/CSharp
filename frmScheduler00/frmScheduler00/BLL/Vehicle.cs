using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace frmScheduler00.BLL
{
    /// <summary>
    /// The Vehicle class, represents a vehicle in real-world.
    /// </summary>
    public class Vehicle
    {
        #region "Properties"
        public int ID { get; set; }
        public int VehicleType { get; set; }
        public decimal MaxLoad { get; set; }
        public bool IsAvailable { get; set; }
        #endregion

        #region "Constructors"
        /// <summary>
        /// The default constructor
        /// </summary>
        public Vehicle()
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
        public Vehicle(int id, int vehicleType, decimal maxLoad, bool isAvailable)
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
            return Vehicle.GetAllVehicles();
        }

        /// <summary>
        /// Get driver by driver ID.
        /// </summary>
        /// <param name="driverId">The driver ID</param>
        /// <returns>The driver with id = driverId</returns>
        public static Driver GetVehicle(int VehicleID)
        {
            return VehicleDAL.GetVehicle(VehicleID);
        }

        /// <summary>
        /// Set driver with id = driverID to available.
        /// </summary>
        /// <param name="driverID">the provided driver id</param>
        public static void SetDriverToAvaliable(int driverID)
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
        public static void SetDriverToUnAvaliable(int driverID)
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
        #endregion
    }
}
