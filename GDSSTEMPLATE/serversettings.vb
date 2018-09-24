Public Class serversettings

    Private Sub serversettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.Item("servip").ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        My.Settings.Item("servip") = TextBox1.Text
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Close()
    End Sub
End Class