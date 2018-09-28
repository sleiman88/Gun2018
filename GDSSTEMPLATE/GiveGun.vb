Public Class GiveGun
    Public erreur As Boolean
    'Private Sub New()
    '    erreur = False
    '    ' This call is required by the designer.
    '    InitializeComponent()

    '    ' Add any initialization after the InitializeComponent() call.

    'End Sub
    Private Sub GiveGun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GdssDataSet1.IDCARD' table. You can move, or remove it, as needed.
        '  Me.IDCARDTableAdapter.Fill(Me.GdssDataSet1.IDCARD)
        'TODO: This line of code loads data into the 'GdssDataSet1.N0ITEMS' table. You can move, or remove it, as needed.
        '  Me.N0ITEMSTableAdapter.Fill(Me.GdssDataSet1.N0ITEMS)
        erreur = False
    End Sub

    Private Sub Button_Search_Click(sender As Object, e As EventArgs) Handles Button_Search.Click
        Me.N0ITEMSTableAdapter.ClearBeforeFill = True
        Me.N0ITEMSTableAdapter.FillBy(Me.GdssDataSet1.N0ITEMS, "%" & TextBox_NameGun.Text & "%")
    End Sub



    Private Sub TextBox_NameGun_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_NameGun.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Me.N0ITEMSTableAdapter.FillBy(Me.GdssDataSet1.N0ITEMS, "%" & TextBox_NameGun.Text & "%")
        End If
    End Sub




    Private Sub TextBox_FName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_FName.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Try
                If FATHER_CheckBox.Checked = True And LName_CheckBox.Checked = True Then

                    Me.IDCARDTableAdapter.FillByFullName(Me.GdssDataSet1.IDCARD, "%" & TextBox_FName.Text & "%", "%" & TextBoxLName.Text & "%", "%" & TextBox_FATHER.Text & "%")
                Else


                    If LName_CheckBox.Checked = True Then
                        Me.IDCARDTableAdapter.FillByFnameAndLName(Me.GdssDataSet1.IDCARD, "%" & TextBox_FName.Text & "%", "%" & TextBoxLName.Text & "%")

                    Else
                        If FATHER_CheckBox.Checked = True Then
                            Me.IDCARDTableAdapter.FillByFnameAndFather(Me.GdssDataSet1.IDCARD, "%" & TextBox_FName.Text & "%", "%" & TextBox_FATHER.Text & "%")
                        Else
                            Me.IDCARDTableAdapter.FillByFName(Me.GdssDataSet1.IDCARD, "%" & TextBox_FName.Text & "%")
                        End If
                    End If



                End If



            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub TextBoxMilitNb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxMilitNb.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Try
                If IsNumeric(TextBoxMilitNb.Text) Then
                    Me.N0ITEMSTableAdapter.ClearBeforeFill = True
                    Me.IDCARDTableAdapter.FillByCODE(Me.GdssDataSet1.IDCARD, CDec(Val(TextBoxMilitNb.Text)))
                Else
                    MsgBox("Invalid Military Number")
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub FName_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles FName_CheckBox.CheckedChanged
        If FName_CheckBox.Checked = True Then
            TextBox_FName.Enabled = True
        Else
            TextBox_FName.Enabled = False
            TextBox_FName.Text = ""
        End If
    End Sub

    Private Sub FATHER_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles FATHER_CheckBox.CheckedChanged
        If FATHER_CheckBox.Checked = True Then
            TextBox_FATHER.Enabled = True
        Else
            TextBox_FATHER.Enabled = False
            TextBox_FATHER.Text = ""

        End If
    End Sub

    Private Sub LName_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles LName_CheckBox.CheckedChanged
        If LName_CheckBox.Checked = True Then
            TextBoxLName.Enabled = True
        Else
            TextBoxLName.Enabled = False
            TextBoxLName.Text = ""
        End If
    End Sub

    Private Sub TextBox_FATHER_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_FATHER.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Try
                If FName_CheckBox.Checked = True And LName_CheckBox.Checked = True Then

                    Me.IDCARDTableAdapter.FillByFullName(Me.GdssDataSet1.IDCARD, "%" & TextBox_FName.Text & "%", "%" & TextBoxLName.Text & "%", "%" & TextBox_FATHER.Text & "%")
                Else


                    If LName_CheckBox.Checked = True Then
                        Me.IDCARDTableAdapter.FillByFatherAndLname(Me.GdssDataSet1.IDCARD, "%" & TextBox_FATHER.Text & "%", "%" & TextBoxLName.Text & "%")

                    Else
                        If FName_CheckBox.Checked = True Then
                            Me.IDCARDTableAdapter.FillByFnameAndFather(Me.GdssDataSet1.IDCARD, "%" & TextBox_FName.Text & "%", "%" & TextBox_FATHER.Text & "%")
                        Else
                            Me.IDCARDTableAdapter.FillByFather(Me.GdssDataSet1.IDCARD, "%" & TextBox_FATHER.Text & "%")
                        End If
                    End If



                End If



            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub TextBoxLName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxLName.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Try
                If FName_CheckBox.Checked = True And LName_CheckBox.Checked = True Then

                    Me.IDCARDTableAdapter.FillByFullName(Me.GdssDataSet1.IDCARD, "%" & TextBox_FName.Text & "%", "%" & TextBoxLName.Text & "%", "%" & TextBox_FATHER.Text & "%")
                Else


                    If FName_CheckBox.Checked = True Then
                        Me.IDCARDTableAdapter.FillByFnameAndLName(Me.GdssDataSet1.IDCARD, "%" & TextBox_FName.Text & "%", "%" & TextBoxLName.Text & "%")

                    Else
                        If FATHER_CheckBox.Checked = True Then
                            Me.IDCARDTableAdapter.FillByFatherAndLname(Me.GdssDataSet1.IDCARD, "%" & TextBox_FATHER.Text & "%", "%" & TextBoxLName.Text & "%")
                        Else
                            Me.IDCARDTableAdapter.FillByLname(Me.GdssDataSet1.IDCARD, "%" & TextBoxLName.Text & "%")
                        End If
                    End If



                End If



            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub



    Private Sub GunType_TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GunType_TextBox.KeyPress

        If e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
            If GunType_TextBox.Text.Length > 19 Then
                GunLabel_Label.Visible = True
                e.Handled = True
                MsgBox("Maximum length allowed 20 Caracter")
                erreur = True



            End If
        Else

            If GunType_TextBox.Text.Length <= 20 Then
                GunLabel_Label.Visible = False
                erreur = False
            End If
        End If



    End Sub



    Private Sub GunType_TextBox_TextChanged(sender As Object, e As EventArgs) Handles GunType_TextBox.TextChanged

    End Sub

    Private Sub GunType_TextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles GunType_TextBox.KeyUp



    End Sub

    Private Sub GunNb_TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GunNb_TextBox.KeyPress


        If e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
            If GunType_TextBox.Text.Length > 49 Then
                GunLabel_Label.Visible = True
                e.Handled = True
                MsgBox("Maximum length allowed 50 Caracter")
                erreur = True



            End If
        Else

            If GunType_TextBox.Text.Length <= 50 Then
                GunLabel_Label.Visible = False
                erreur = False
            End If
        End If

    End Sub




    Private Sub gunNbConfirm_TextBox_MouseDown(sender As Object, e As MouseEventArgs) Handles gunNbConfirm_TextBox.MouseDown
        If e.Button = MouseButtons.Right Then
            MsgBox("Not allow to copy and past ")
            gunNbConfirm_TextBox.Text = ""

        End If
    End Sub

    Private Sub gunNbConfirm_TextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles gunNbConfirm_TextBox.KeyDown
        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.V Then
            e.SuppressKeyPress = True
            MsgBox("Not allow to copy and past ")
        End If
    End Sub

    Private Sub gunNbConfirm_TextBox_Leave(sender As Object, e As EventArgs) Handles gunNbConfirm_TextBox.Leave

        If String.Compare(GunNb_TextBox.Text, gunNbConfirm_TextBox.Text) <> 0 Then
            Confirm_Label.Visible = True
            MsgBox("Gun Number does not Match ")
            erreur = True
            gunNbConfirm_TextBox.Focus()
        Else
            Confirm_Label.Visible = False
            erreur = False
            If checkNumberIfExist() = True Then
                erreur = True
                If gunNbConfirm_TextBox.Text.Length > 0 Then
                    MsgBox("this Current Number already exist ,Please enter a valid Number ")
                    gunNbConfirm_TextBox.Text = ""
                    GunNb_TextBox.Text = ""

                    GunNb_TextBox.Focus()

                End If
            Else
                erreur = False

            End If


        End If

    End Sub


    Private Function checkNumberIfExist() As Boolean

        Dim result As String

        result = Me.PergunTableAdapter1.checkIfNbExist(gunNbConfirm_TextBox.Text)
        If result Is Nothing Then
            Return True
        Else
            Return False
        End If


    End Function

    Private Sub GunStore_TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GunStore_TextBox.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            MsgBox("only Numbers allowed")
            e.Handled = True
        End If
    End Sub

    Private Sub GAMMO_TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GAMMO_TextBox.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            MsgBox("only Numbers allowed")
            e.Handled = True
        End If
    End Sub
End Class