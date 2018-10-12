Public Class GunInfo
    Private Sub GunInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GdssDataSet1.GunReportInfoForm' table. You can move, or remove it, as needed.
        Me.GunReportInfoFormTableAdapter.Fill(Me.GdssDataSet1.GunReportInfoForm)

    End Sub
End Class