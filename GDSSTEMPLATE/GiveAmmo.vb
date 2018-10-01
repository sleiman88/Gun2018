Public Class GiveAmmo
    Public Muser As String
    Private Sub GiveAmmo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub New(user As String)

        ' This call is required by the designer.
        InitializeComponent()
        Muser = user

        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class