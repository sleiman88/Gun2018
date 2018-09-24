Public Class main
    Private Sub GiveGunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GiveGunToolStripMenuItem.Click
        GiveGun.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub GiveAmmoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GiveAmmoToolStripMenuItem.Click
        GiveAmmo.ShowDialog()
    End Sub
End Class