namespace frmScheduler00
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            this.panel1 = new System.Windows.Forms.Panel();
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerStorage_driver = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.bdsDriverAvailability = new System.Windows.Forms.BindingSource(this.components);
            this.bdsDrivers = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.bdsVehicles = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage_driver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDriverAvailability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDrivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.schedulerControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 670);
            this.panel1.TabIndex = 0;
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl1.Location = new System.Drawing.Point(0, 0);
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.Size = new System.Drawing.Size(791, 670);
            this.schedulerControl1.Start = new System.DateTime(2014, 5, 6, 0, 0, 0, 0);
            this.schedulerControl1.Storage = this.schedulerStorage_driver;
            this.schedulerControl1.TabIndex = 0;
            this.schedulerControl1.Text = "schedulerControl1";
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl1.Views.MonthView.Enabled = false;
            this.schedulerControl1.Views.WeekView.Enabled = false;
            this.schedulerControl1.Views.WorkWeekView.Enabled = false;
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControl1.EditAppointmentFormShowing += new DevExpress.XtraScheduler.AppointmentFormEventHandler(this.schedulerControl1_EditAppointmentFormShowing);
            // 
            // schedulerStorage_driver
            // 
            this.schedulerStorage_driver.Appointments.DataSource = this.bdsDriverAvailability;
            this.schedulerStorage_driver.Appointments.Mappings.End = "EndDate";
            this.schedulerStorage_driver.Appointments.Mappings.Label = "DriverAvailable";
            this.schedulerStorage_driver.Appointments.Mappings.ResourceId = "DriverID";
            this.schedulerStorage_driver.Appointments.Mappings.Start = "PlanDate";
            this.schedulerStorage_driver.Appointments.Mappings.Subject = "StrIsAvailable";
            this.schedulerStorage_driver.Resources.DataSource = this.bdsDrivers;
            this.schedulerStorage_driver.Resources.Mappings.Caption = "Name";
            this.schedulerStorage_driver.Resources.Mappings.Id = "ID";
            // 
            // bdsDriverAvailability
            // 
            this.bdsDriverAvailability.DataSource = typeof(frmScheduler00.BLL.DriverAvailability);
            // 
            // bdsDrivers
            // 
            this.bdsDrivers.DataSource = typeof(frmScheduler00.BLL.Driver);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 670);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 33);
            this.panel2.TabIndex = 1;
            // 
            // bdsVehicles
            // 
            this.bdsVehicles.DataSource = typeof(frmScheduler00.BLL.Vehicle);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 703);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage_driver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDriverAvailability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDrivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVehicles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage_driver;
        private System.Windows.Forms.BindingSource bdsDrivers;
        private System.Windows.Forms.BindingSource bdsDriverAvailability;
        private System.Windows.Forms.BindingSource bdsVehicles;
    }
}

