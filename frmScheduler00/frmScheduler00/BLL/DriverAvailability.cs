using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using frmScheduler00.DAL;

namespace frmScheduler00.BLL
{
    /// <summary>
    /// 
    /// </summary>
    public class DriverAvailability
    {
        #region "Fields"
        /// <summary>
        /// Properties
        /// </summary>
        public DateTime PlanDate { get; set; }
        public int DriverID { get; set; }
        public bool DriverAvailable { get; set; }
        public DateTime EndDate { get; set; }
        public string StrIsAvailable 
        {
            get 
            {
                return DriverAvailable ? "Available" : "Unavailable";
            } 
        }
        #endregion

        #region "Constructors"
        /// <summary>
        /// The default paramless constructor
        /// </summary>
        public DriverAvailability()
        {
            PlanDate = ToFirstSecond(DateTime.Now);
            DriverID = 0;
            DriverAvailable = false;
            EndDate = ToLastSecond(DateTime.Now);
        }

        private DateTime ToFirstSecond(DateTime date)
        {
            DateTime tmp;
            string strTmp;
            strTmp = date.ToShortDateString();
            strTmp = strTmp + " 00:00:00";
            tmp = Convert.ToDateTime(strTmp);

            return tmp;
        }

        private DateTime ToLastSecond(DateTime date)
        {
            DateTime tmp;
            string strTmp;
            strTmp = date.ToShortDateString();
            strTmp = strTmp + " 23:59:59";
            tmp = Convert.ToDateTime(strTmp);

            return tmp;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="driverId"></param>
        /// <param name="driverAvailability"></param>
        public DriverAvailability(DateTime date, int driverId, bool driverAvailability)
        {
            this.PlanDate = ToFirstSecond(date);
            this.DriverID = driverId;
            this.DriverAvailable = driverAvailability;
        }
        #endregion

        #region "Methods"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="driverId"></param>
        /// <param name="driverAvailability"></param>
        /// <param name="endDate"></param>
        public static DriverAvailability GetDriverAvailability(DateTime date, int driverId)
        {
            return DriverDAL.GetDriverAvailability(date, driverId);
        }

        public static List<DriverAvailability> GetAllAvailability()
        {
            return DriverDAL.GetAllAvailability();
        }
        #endregion
    }
}
