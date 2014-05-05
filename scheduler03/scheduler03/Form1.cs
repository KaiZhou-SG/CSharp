using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using System.ComponentModel;

namespace scheduler03
{
    public partial class Form1 : Form
    {
        /*
         * 2013-08-06 Zhou Kai writes the program to 
         * learn and practice the concepts of the 
         * DevExpress.XtraScheduler control
         * 
         */

        #region "Private Variables"

        private int i;

        // For an appointment
        private Plan currentPlan;
        private DateTime startDateTime; // mandatory
        private DateTime endDateTime; // mandatory
        private string appointmentSubject;
        private string appointmentDescription;
        private int appointmentResourceId;

        // For a resource to an appointment
        private Apartment currentPlanResource;
        private int apartmentId; // mandatory
        private string apartmentCaption;

        #endregion

        #region "Properties"

        public BindingList<Plan> lstPlans;
        public BindingList<Apartment> lstResources;

        #endregion

        #region "Constructors"

        public Form1()
        {
            InitializeComponent();

            i = 0;

            // Appointment
            currentPlan = new Plan();
            startDateTime = DateTime.Now;
            endDateTime = DateTime.Now.AddHours(2);
            appointmentSubject = String.Empty;
            appointmentDescription = String.Empty;
            appointmentResourceId = 0;

            // Resource
            currentPlanResource = new Apartment();
            apartmentId = 0;
            apartmentCaption = String.Empty;

            // Binding data source
            lstPlans = new BindingList<Plan>();
            lstResources = new BindingList<Apartment>();

            // Assignments
            bdsPlans.DataSource = lstPlans;
            bdsApartments.DataSource = lstResources;
            schedulerStorage1.Appointments.DataSource = bdsPlans;
            schedulerStorage1.Resources.DataSource = bdsApartments;

            // Mappings
            InitSchedulerAppointmentMappings();
            InitSchedulerResourceMappings();
            InitSchedulerAppearence();

        }

        #endregion

        #region "Methods"

        private void InitSchedulerAppointmentMappings()
        {
            schedulerStorage1.Appointments.Mappings.Start = "Start";
            schedulerStorage1.Appointments.Mappings.End = "End";
            schedulerStorage1.Appointments.Mappings.Subject = "Subject";
            schedulerStorage1.Appointments.Mappings.Description = "Description";
            schedulerStorage1.Appointments.Mappings.ResourceId = "ResourceId";
        }

        private void InitSchedulerResourceMappings()
        {
            schedulerStorage1.Resources.Mappings.Caption = "Caption";
            schedulerStorage1.Resources.Mappings.Id = "ID";

            currentPlanResource.Caption = i.ToString();
            currentPlanResource.ID = i;
            lstResources.Add(currentPlanResource);
        }

        private void InitSchedulerAppearence()
        {
            schedulerControl1.Start = DateTime.Today;
            schedulerControl1.ActiveViewType = SchedulerViewType.Day;
            schedulerControl1.GroupType = SchedulerGroupType.Date;
        }

        #endregion

        #region "Event Handler Targets"

        private void Button1_Click(object sender, EventArgs e)
        {
            currentPlan = new Plan();
            currentPlan.Start = DateTime.Now.AddHours(i);
            currentPlan.End = DateTime.Now.AddHours(i + 0.5);
            currentPlan.Subject = "Subject " + i.ToString();
            currentPlan.Description = "Description " + i.ToString();
            currentPlan.ResourceId = 0;
            lstPlans.Add(currentPlan);
            
            i += 2;
        }


        #endregion

    }



}
