Public Class GunInfo
    Private Sub PERGUNTableAdapterBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PERGUNTableAdapterBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GdssDataSet1)

    End Sub

    Private Sub GunInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GdssDataSet1.PERGUNTableAdapter' table. You can move, or remove it, as needed.
        Me.PERGUNTableAdapterTableAdapter.Fill(Me.GdssDataSet1.PERGUNTableAdapter)
        'TODO: This line of code loads data into the 'GdssDataSet1.PERGUNTableAdapter' table. You can move, or remove it, as needed.
        Me.PERGUNTableAdapterTableAdapter.Fill(Me.GdssDataSet1.PERGUNTableAdapter)

    End Sub

    Private Sub PERGUNTableAdapterBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PERGUNTableAdapterBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GdssDataSet1)

    End Sub
End Class