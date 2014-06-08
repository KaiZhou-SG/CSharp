using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using frmScheduler00.BLL;
using frmScheduler00.UI;

namespace frmScheduler00
{
    internal partial class Form1 : Form
    {
        #region "Class Fields"
        internal List<Driver> lstAllDrivers;
        internal List<Vehicle> lstAllVehicles;
        internal List<DriverAvailability> lstDriverAvailability;
        internal string strDriverAvailability; // represent the driver availability
        internal string strVehicleAvailability; // represent the vehicle availability
        #endregion

        /// <summary>
        /// The default constructor
        /// </summary>
        internal Form1()
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
            CustomizeScheduler();

            GetResources();
        }

        /// <summary>
        /// 
        /// </summary>
        private void GetResources()
        {
            lstAllDrivers = Driver.GetAllDrivers();
            bdsDrivers.DataSource = lstAllDrivers;
            lstAllVehicles = Vehicle.GetAllVehicles();
            bdsVehicles.DataSource = lstAllVehicles;
            lstDriverAvailability = DriverAvailability.GetAllAvailability();
            bdsDriverAvailability.DataSource = lstDriverAvailability;
        }

        /// <summary>
        /// 
        /// </summary>
        private void CustomizeScheduler()
        {
            schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Timeline;
            schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource;

            schedulerControl1.DayView.Enabled = false;
            schedulerControl1.WeekView.Enabled = false;
            schedulerControl1.WorkWeekView.Enabled = false;
            schedulerControl1.MonthView.Enabled = false;
        }

        // pop up FrmSetDriverAvailability
        private void schedulerControl1_EditAppointmentFormShowing(object sender, DevExpress.XtraScheduler.AppointmentFormEventArgs e)
        {
            DevExpress.XtraScheduler.Appointment apt = e.Appointment;

            // Required to open the recurrence form via context menu.
            bool openRecurrenceForm = apt.IsRecurring && schedulerStorage_driver.Appointments.IsNewAppointment(apt);

            // Create a custom form.
            SetDriverAvailability setDriverAvailability = new SetDriverAvailability(strDriverAvailability);

            try
            {
                e.DialogResult = setDriverAvailability.ShowDialog();

                if (setDriverAvailability.Confirm)
                {
                    Driver.SetDriverToUnAvaliableOnGivenDate((int)apt.ResourceId, apt.Start);
                    bdsDriverAvailability.DataSource = DriverAvailability.GetAllAvailability();
                    schedulerControl1.RefreshData();
                }
                else
                { 
                    // do nothing
                }
                schedulerControl1.Refresh();
                e.Handled = true;
            }
            catch(Exception ex){MessageBox.Show("Failed\n" + ex.Message);}
            finally{setDriverAvailability.Dispose();}
        }
    }
}
