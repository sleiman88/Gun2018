Public Class ReportAmmoByPerson
    Private Sub ReportAmmoByPerson_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'gdssDataSet1.AmmoReportWithGrade' table. You can move, or remove it, as needed.
        Me.AmmoReportWithGradeTableAdapter.Fill(Me.gdssDataSet1.AmmoReportWithGrade)
        'TODO: This line of code loads data into the 'gdssDataSet1.AmmoReportInfo' table. You can move, or remove it, as needed.


        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class