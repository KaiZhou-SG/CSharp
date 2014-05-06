using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmDragDrop03
{
    internal class Truck
    {
        #region "variables"
        private string truckNo;
        private string truckCondition;
        private string driverName;
        private string driverLicense;
        #endregion

        #region "constructors"
        public Truck()
        {
            this.truckNo = String.Empty;
            this.truckCondition = String.Empty;
            this.driverName = String.Empty;
            this.driverLicense = String.Empty;
        }

        public Truck(string truckNo, string truckCondition, 
            string driverName, string driverLicense)
        {
            this.truckNo = truckNo;
            this.truckCondition = truckCondition;
            this.driverName = driverName;
            this.driverLicense = driverLicense;
        }
        #endregion

        #region "methods"
        public override string ToString()
        {
            return String.Format("TruckNo: {0}, DriverName: {1}, DriverLicense: {2},"
                + " TruckCondition: {3}.", truckNo, driverName, driverLicense, truckCondition);
        }
        #endregion

    }
}
