Public Class PrintAmmoInfo

    Dim MyPk As Integer

    Sub New(pk As Integer)
        MyPk = pk

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub PrintAmmoInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'gdssDataSet1.AmmoReportInfo' table. You can move, or remove it, as needed.
        Me.AmmoReportInfoTableAdapter.Fill(Me.gdssDataSet1.AmmoReportInfo)
        Me.AmmoReportInfoTableAdapter.FillByPK(Me.gdssDataSet1.AmmoReportInfo, MyPk)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class