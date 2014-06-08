using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using frmScheduler00.BLL;

namespace frmScheduler00
{
    public partial class Form1 : Form
    {
        #region "Class Fields"
        public List<Driver> lstAllDrivers;
        public List<Vehicle> lstAllVehicles;
        #endregion

        /// <summary>
        /// The default constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            lstAllDrivers = new List<Driver>();
            lstAllVehicles = new List<Vehicle>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GetResources()
        {
            lstAllDrivers = Driver.GetAllDrivers();
            
        }
    }
}
