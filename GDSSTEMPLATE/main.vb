Public Class main

    Public Myuser As String
    Private Sub GiveGunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GiveGunToolStripMenuItem.Click
        Dim givegun As GiveGun
        givegun = New GiveGun(Myuser)

        givegun.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub GiveAmmoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GiveAmmoToolStripMenuItem.Click
        Dim giveAmo As GiveAmmo
        giveAmo = New GiveAmmo(Myuser)
        giveAmo.ShowDialog()
    End Sub


    Public Sub New(user As String)

        ' This call is required by the designer.
        InitializeComponent()
        Myuser = user
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class