namespace scheduler03
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
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerStorage1 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.bdsPlans = new System.Windows.Forms.BindingSource(this.components);
            this.bdsApartments = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPlans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsApartments)).BeginInit();
            this.SuspendLayout();
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.schedulerControl1.Location = new System.Drawing.Point(0, 0);
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.Size = new System.Drawing.Size(727, 312);
            this.schedulerControl1.Start = new System.DateTime(2013, 8, 10, 0, 0, 0, 0);
            this.schedulerControl1.Storage = this.schedulerStorage1;
            this.schedulerControl1.TabIndex = 0;
            this.schedulerControl1.Text = "My_Scheduler";
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2);
            // 
            // schedulerStorage1, map both appointment and resource, can also be done at runtime
            // 
            //this.schedulerStorage1.Appointments.DataSource = this.bdsPlans;
            //this.schedulerStorage1.Appointments.Mappings.Description = "Description";
            //this.schedulerStorage1.Appointments.Mappings.End = "End";
            //this.schedulerStorage1.Appointments.Mappings.ResourceId = "ResourceId";
            //this.schedulerStorage1.Appointments.Mappings.Start = "Start";
            //this.schedulerStorage1.Appointments.Mappings.Subject = "Subject";
            //this.schedulerStorage1.Resources.DataSource = this.bdsApartments;
            //this.schedulerStorage1.Resources.Mappings.Caption = "Caption";
            //this.schedulerStorage1.Resources.Mappings.Id = "ID";
            // 
            // bdsPlans
            // 
            this.bdsPlans.DataSource = typeof(scheduler03.Plan);
            // 
            // bdsApartments
            // 
            this.bdsApartments.DataSource = typeof(scheduler03.Apartment);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "AddAppointment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 448);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.schedulerControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPlans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsApartments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bdsPlans;
        private System.Windows.Forms.BindingSource bdsApartments;
    }
}

