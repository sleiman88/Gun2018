Public Class GunInfo
    Dim mycode As Integer
    Public Sub New(code As Integer)
        mycode = code
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub GunInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.GunReportInfoFormTableAdapter.GetDataByCode(mycode)
        'TODO: This line of code loads data into the 'GdssDataSet1.GunReportInfoForm' table. You can move, or remove it, as needed.
        '  Me.GunReportInfoFormTableAdapter.Fill(Me.GdssDataSet1.GunReportInfoForm)

    End Sub
End Class