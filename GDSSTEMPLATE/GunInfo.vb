Public Class GunInfo
    Dim mycode As Integer
    Public Sub New(code As Integer)
        mycode = code
        ' This call is required by the designer.
        InitializeComponent()
        Me.GunReportInfoFormTableAdapter.GetDataByCode(mycode)

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub GunInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.GunReportInfoFormTableAdapter.FillByCode(Me.GdssDataSet1.GunReportInfoForm, mycode)

    End Sub
End Class