﻿Public Class PrintGunInfo
    Dim MyCode As Integer
    Dim MyGunInfo As GunInfo
    Sub New(code As Integer, gunIn As GunInfo)
        MyCode = code
        MyGunInfo = gunIn
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub PrintGunInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GdssDataSet1.GunReportInfoForm' table. You can move, or remove it, as needed.
        Dim dtable = Me.GunReportInfoFormTableAdapter.FillByCode(GdssDataSet1.GunReportInfoForm, MyCode)
        ReportViewer1.RefreshReport()



    End Sub
End Class