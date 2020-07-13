
Public Class AmmoInfo
    Public myPK As Int32
    Public Sub New(pk As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        myPK = pk
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub AmmoInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GdssDataSet1.AmmoReportWithGrade' table. You can move, or remove it, as needed.
        ' Me.AmmoReportWithGradeTableAdapter.Fill(Me.GdssDataSet1.AmmoReportWithGrade)
        'TODO: This line of code loads data into the 'GdssDataSet1.AmmoReportInfo' table. You can move, or remove it, as needed.
        ' Me.AmmoReportInfoTableAdapter.Fill(Me.GdssDataSet1.AmmoReportInfo)
        Me.AmmoReportInfoTableAdapter.FillByPK(Me.GdssDataSet1.AmmoReportInfo, myPK)
    End Sub

    Private Sub Button_Print_Click(sender As Object, e As EventArgs) Handles Button_Print.Click


        Dim MyPrintAmmoInfo As PrintAmmoInfo
        MyPrintAmmoInfo = New PrintAmmoInfo(myPK)
        Me.AmmoReportInfoTableAdapter.ClearBeforeFill = True

        Me.AmmoReportInfoTableAdapter.FillByPK(Me.GdssDataSet1.AmmoReportInfo, myPK)
        MyPrintAmmoInfo.ShowDialog()

        MyPrintAmmoInfo.ReportViewer1.RefreshReport()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class