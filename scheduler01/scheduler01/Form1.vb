Imports DevExpress.XtraScheduler

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SchedulerControlDataSet.Resources' table. You can move, or remove it, as needed.
        Me.ResourcesTableAdapter.Fill(Me.SchedulerControlDataSet.Resources)
        'TODO: This line of code loads data into the 'SchedulerControlDataSet.Appointments' table. You can move, or remove it, as needed.
        Me.AppointmentsTableAdapter.Fill(Me.SchedulerControlDataSet.Appointments)

        SchedulerControl1.Start = Date.Today.AddDays(2)
        SchedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Day
        SchedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource
        SchedulerControl1.WeekView.ResourcesPerPage = 2

    End Sub

    Private Sub UpdateScheduler()
        AppointmentsTableAdapter.Update(SchedulerControlDataSet)
        SchedulerControlDataSet.AcceptChanges()
    End Sub


    Private Sub SchedulerStorage1_AppointmentsChanged(sender As Object, e As PersistentObjectsEventArgs) Handles SchedulerStorage1.AppointmentsChanged
        UpdateScheduler()
    End Sub

    Private Sub SchedulerStorage1_AppointmentsDeleted(sender As Object, e As PersistentObjectsEventArgs) Handles SchedulerStorage1.AppointmentsDeleted
        UpdateScheduler()
    End Sub

    Private Sub SchedulerStorage1_AppointmentsInserted(sender As Object, e As PersistentObjectsEventArgs) Handles SchedulerStorage1.AppointmentsInserted
        UpdateScheduler()
    End Sub
End Class
