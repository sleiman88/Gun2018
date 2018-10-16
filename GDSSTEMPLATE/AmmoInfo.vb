Public Class AmmoInfo
    Public myPK As Int32
    Public Sub New(pk As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        myPK = pk
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub AmmoInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GdssDataSet1.AmmoReportInfo' table. You can move, or remove it, as needed.
        ' Me.AmmoReportInfoTableAdapter.Fill(Me.GdssDataSet1.AmmoReportInfo)
        Me.AmmoReportInfoTableAdapter.FillByPK(Me.GdssDataSet1.AmmoReportInfo, myPK)
    End Sub
End Class