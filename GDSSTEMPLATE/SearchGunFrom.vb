Public Class SearchGunFrom
    Private Sub Button_Search_Click(sender As Object, e As EventArgs) Handles Button_Search.Click

        If TextBox_GunNumb.Text.Length = 0 Then
            Label_error.Visible = True
            MsgBox("Please enter Gun Number First !!")
        Else
            'not empty go 
            Label_error.Visible = False

            If getCode() = 0 Then
                MsgBox("This Gun Number does not Exist !!")
            Else
                Dim AgunInfo As GunInfo
                AgunInfo = New GunInfo(Decimal.Parse(getCode()))
                AgunInfo.ShowDialog()
            End If




        End If

    End Sub

    Private Sub TextBox_GunNumb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_GunNumb.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If TextBox_GunNumb.Text.Length = 0 Then
                Label_error.Visible = True
                MsgBox("Please enter Gun Number First !!")
            Else
                Label_error.Visible = False

                If getCode() = 0 Then
                    MsgBox("This Gun Number does not Exist !!")
                Else
                    Dim AgunInfo As GunInfo
                    AgunInfo = New GunInfo(Decimal.Parse(getCode()))
                    AgunInfo.ShowDialog()
                End If


            End If
        End If
    End Sub

    Private Function getCode() As String
        Dim code As Int32
        code = Me.GunReportInfoFormTableAdapter.getCodeByGunNumber(TextBox_GunNumb.Text)

        Return code
    End Function

    Private Sub SearchGunFrom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GdssDataSet1.GunReportInfoForm' table. You can move, or remove it, as needed.
        Me.GunReportInfoFormTableAdapter.Fill(Me.GdssDataSet1.GunReportInfoForm)

    End Sub
End Class