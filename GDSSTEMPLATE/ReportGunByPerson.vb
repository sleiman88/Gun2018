Public Class ReportGunByPerson
    Private Sub ReportGunByPerson_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'gdssDataSet1.GunReportInfoForm' table. You can move, or remove it, as needed.
        Me.GunReportInfoFormTableAdapter.Fill(Me.gdssDataSet1.GunReportInfoForm)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class