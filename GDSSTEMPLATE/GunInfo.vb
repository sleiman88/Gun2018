Public Class GunInfo
    Dim mycode As Integer

    Public Sub New(code As Integer)
        mycode = code
        ' This call is required by the designer.
        InitializeComponent()
        '  Me.GunReportInfoFormTableAdapter.GetDataByCode(mycode)

        ' Add any initialization after the InitializeComponent() call.
        Me.GunReportInfoFormTableAdapter.FillByCode(Me.GdssDataSet1.GunReportInfoForm, mycode)
    End Sub



    Private Sub Print_Button_Click(sender As Object, e As EventArgs) Handles Print_Button.Click
        'Call report viwer
        'Me.GunReportInfoFormTableAdapter.FillByCode(Me.GdssDataSet1.GunReportInfoForm, mycode)
        Dim MyPrintGunIfo As PrintGunInfo
        MyPrintGunIfo = New PrintGunInfo(mycode)
        MyPrintGunIfo.ShowDialog()

        MyPrintGunIfo.ReportViewer1.RefreshReport()
    End Sub

    Private Sub LABELLabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class