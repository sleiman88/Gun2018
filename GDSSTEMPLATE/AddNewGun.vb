Public Class AddNewGun
    Private Function checkTest() As Boolean
        Dim result As Boolean
        result = False
        If TextBox_gunName.Text.Length = 0 Then
            result = True
            Label_er.Visible = True

        End If
        If checkNumberIfExist() = True Then
            result = True
            If TextBox_gunName.Text.Length > 0 Then
                MsgBox("this Current Number already exist ,Please enter a valid Number ")
                TextBox_gunName.Text = ""

                Label_error_double.Visible = True

                TextBox_gunName.Focus()

            End If


        End If

        Return result
    End Function

    Private Function checkNumberIfExist() As Boolean

        Dim result As String
        ''  result = Me.N0ITEMSAddGunTableAdapter.checkIfExist(TextBox_gunName.Text)

        If result Is Nothing Then
            Return False
        Else
            Return True
        End If
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If checkTest() = True Then
            MsgBox("error")
        Else

        End If
    End Sub



    Private Sub TextBox_gunName_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox_gunName.KeyUp
        If TextBox_gunName.Text <> String.Empty Then
            Label_er.Visible = False
        End If
    End Sub

    Private Sub AddNewGun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GdssDataSet1.N0ITEMSAddGun' table. You can move, or remove it, as needed.
        Me.N0ITEMSAddGunTableAdapter.Fill(Me.GdssDataSet1.N0ITEMSAddGun)
        'TODO: This line of code loads data into the 'GdssDataSet1.N0ITEMS' table. You can move, or remove it, as needed.
        Me.N0ITEMSTableAdapter.Fill(Me.GdssDataSet1.N0ITEMS)

    End Sub
End Class