Public Class LOGIN


    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        If Len(Trim(txt_user.Text)) = 0 Then
            MessageBox.Show("Please enter user name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_user.Focus()
            Exit Sub
        End If
        If Len(Trim(txt_pass.Text)) = 0 Then
            MessageBox.Show("Please enter password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_pass.Focus()
            Exit Sub
        End If

        Try

            Dim ncs = My.Settings.cstring.Replace("username", txt_user.Text).Replace("password", txt_pass.Text).Replace("SRV", cmb_server.SelectedItem)
            'MsgBox(ncs)

            My.Settings.Item("gdssConnectionString") = ncs
            'MsgBox(My.Settings.Item("numbersConnectionString"))


            ServerdatetimeTableAdapter1.Connection.ConnectionString = ncs

            ServerdatetimeTableAdapter1.Connection.Open()

            'Me.Get_nameTableAdapter1.Fill(NumbersDataSet1.get_name)
            Dim Mmain As main
            Mmain = New main(txt_user.Text)
            Mmain.Show()

            ServerdatetimeTableAdapter1.Connection.Close()
            Me.Close()

            'MsgBox("logged in")



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_server.Items.Add(My.Settings.Item("autoserv").ToString())
        cmb_server.SelectedIndex = 0

        Dim ser() = My.Settings.Item("servip").ToString.Split(";")

        For Each ss In ser
            cmb_server.Items.Add(ss)
        Next
    End Sub

    Private Sub cmb_server_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_server.SelectedIndexChanged
        My.Settings.Item("autoserv") = cmb_server.SelectedItem
        My.Settings.Save()
    End Sub


    Private Sub SettingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingToolStripMenuItem.Click
        serversettings.ShowDialog()
        cmb_server.Items.Clear()
        cmb_server.Items.Add(My.Settings.Item("autoserv").ToString())
        cmb_server.SelectedIndex = 0

        Dim ser() = My.Settings.Item("servip").ToString.Split(";")

        For Each ss In ser
            cmb_server.Items.Add(ss)
        Next
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub
End Class
