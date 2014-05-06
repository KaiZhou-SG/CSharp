<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TimeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Dim TimeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Me.SchedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
        Me.SchedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
        Me.AppointmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SchedulerControlDataSet = New scheduler01.SchedulerControlDataSet()
        Me.ResourcesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AppointmentsTableAdapter = New scheduler01.SchedulerControlDataSetTableAdapters.AppointmentsTableAdapter()
        Me.ResourcesTableAdapter = New scheduler01.SchedulerControlDataSetTableAdapters.ResourcesTableAdapter()
        Me.DateNavigator1 = New DevExpress.XtraScheduler.DateNavigator()
        CType(Me.SchedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppointmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchedulerControlDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResourcesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SchedulerControl1
        '
        Me.SchedulerControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SchedulerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SchedulerControl1.Name = "SchedulerControl1"
        Me.SchedulerControl1.Size = New System.Drawing.Size(797, 356)
        Me.SchedulerControl1.Start = New Date(2013, 8, 1, 0, 0, 0, 0)
        Me.SchedulerControl1.Storage = Me.SchedulerStorage1
        Me.SchedulerControl1.TabIndex = 0
        Me.SchedulerControl1.Text = "SchedulerControl1"
        Me.SchedulerControl1.Views.DayView.TimeRulers.Add(TimeRuler1)
        Me.SchedulerControl1.Views.WorkWeekView.TimeRulers.Add(TimeRuler2)
        '
        'SchedulerStorage1
        '
        Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("CustomField1", "CustomField1"))
        Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("ResourceIDs", "ResourceIDs"))
        Me.SchedulerStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("UniqueID", "UniqueID"))
        Me.SchedulerStorage1.Appointments.DataSource = Me.AppointmentsBindingSource
        Me.SchedulerStorage1.Appointments.Mappings.AllDay = "AllDay"
        Me.SchedulerStorage1.Appointments.Mappings.Description = "Description"
        Me.SchedulerStorage1.Appointments.Mappings.End = "EndDate"
        Me.SchedulerStorage1.Appointments.Mappings.Label = "Label"
        Me.SchedulerStorage1.Appointments.Mappings.Location = "Location"
        Me.SchedulerStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo"
        Me.SchedulerStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo"
        Me.SchedulerStorage1.Appointments.Mappings.ResourceId = "ResourceID"
        Me.SchedulerStorage1.Appointments.Mappings.Start = "StartDate"
        Me.SchedulerStorage1.Appointments.Mappings.Status = "Status"
        Me.SchedulerStorage1.Appointments.Mappings.Subject = "Subject"
        Me.SchedulerStorage1.Appointments.Mappings.Type = "Type"
        Me.SchedulerStorage1.Resources.CustomFieldMappings.Add(New DevExpress.XtraScheduler.ResourceCustomFieldMapping("CustomField1", "CustomField1"))
        Me.SchedulerStorage1.Resources.DataSource = Me.ResourcesBindingSource
        Me.SchedulerStorage1.Resources.Mappings.Caption = "ResourceName"
        Me.SchedulerStorage1.Resources.Mappings.Color = "Color"
        Me.SchedulerStorage1.Resources.Mappings.Id = "ResourceID"
        Me.SchedulerStorage1.Resources.Mappings.Image = "Image"
        Me.SchedulerStorage1.Resources.Mappings.ParentId = "UniqueID"
        '
        'AppointmentsBindingSource
        '
        Me.AppointmentsBindingSource.DataMember = "Appointments"
        Me.AppointmentsBindingSource.DataSource = Me.SchedulerControlDataSet
        '
        'SchedulerControlDataSet
        '
        Me.SchedulerControlDataSet.DataSetName = "SchedulerControlDataSet"
        Me.SchedulerControlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ResourcesBindingSource
        '
        Me.ResourcesBindingSource.DataMember = "Resources"
        Me.ResourcesBindingSource.DataSource = Me.SchedulerControlDataSet
        '
        'AppointmentsTableAdapter
        '
        Me.AppointmentsTableAdapter.ClearBeforeFill = True
        '
        'ResourcesTableAdapter
        '
        Me.ResourcesTableAdapter.ClearBeforeFill = True
        '
        'DateNavigator1
        '
        Me.DateNavigator1.HotDate = Nothing
        Me.DateNavigator1.Location = New System.Drawing.Point(12, 362)
        Me.DateNavigator1.Name = "DateNavigator1"
        Me.DateNavigator1.SchedulerControl = Me.SchedulerControl1
        Me.DateNavigator1.Size = New System.Drawing.Size(224, 175)
        Me.DateNavigator1.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 543)
        Me.Controls.Add(Me.DateNavigator1)
        Me.Controls.Add(Me.SchedulerControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.SchedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppointmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchedulerControlDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResourcesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SchedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
    Friend WithEvents SchedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
    Friend WithEvents SchedulerControlDataSet As scheduler01.SchedulerControlDataSet
    Friend WithEvents AppointmentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AppointmentsTableAdapter As scheduler01.SchedulerControlDataSetTableAdapters.AppointmentsTableAdapter
    Friend WithEvents ResourcesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ResourcesTableAdapter As scheduler01.SchedulerControlDataSetTableAdapters.ResourcesTableAdapter
    Friend WithEvents DateNavigator1 As DevExpress.XtraScheduler.DateNavigator

End Class
