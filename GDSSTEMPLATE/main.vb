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
        'TODO: This line of code loads data into the 'GdssDataSet1.AMMODataGrid' table. You can move, or remove it, as needed.
        ' Me.AMMODataGridTableAdapter.Fill(Me.GdssDataSet1.AMMODataGrid)
        'TODO: This line of code loads data into the 'GdssDataSet1.N0itemsAndPerGUn' table. You can move, or remove it, as needed.
        'Me.N0itemsAndPerGUnTableAdapter.Fill(Me.GdssDataSet1.N0itemsAndPerGUn)
        'TODO: This line of code loads data into the 'GdssDataSet1.IDCARD' table. You can move, or remove it, as needed.
        ' Me.IDCARDTableAdapter.Fill(Me.GdssDataSet1.IDCARD)

    End Sub

    Private Sub TextBoxMilitNb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxMilitNb.KeyPress
        If TextBoxMilitNb.Text <> String.Empty Then
            Person_Label.Visible = False

        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            Try

                FName_CheckBox.Checked = False
                LName_CheckBox.Checked = False
                FATHER_CheckBox.Checked = False

                If IsNumeric(TextBoxMilitNb.Text) Then
                    'Me.N0ITEMSTableAdapter.ClearBeforeFill = True
                    Me.IDCARDTableAdapter.FillByCODE(Me.GdssDataSet1.IDCARD, CDec(Val(TextBoxMilitNb.Text)))
                Else
                    MsgBox("Invalid Military Number")
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            If ComboBoxPersons.Items.Count = 1 Then
                Person_Label.Visible = False
            End If
        End If
    End Sub

    Private Sub ComboBoxPersons_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPersons.SelectedIndexChanged
        FullName_TextBox.Text = ComboBoxPersons.GetItemText(ComboBoxPersons.SelectedItem)
        If FullName_TextBox.Text <> String.Empty Then
            Person_Label.Visible = False

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
            TextBoxMilitNb.Text = ""
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
            TextBoxMilitNb.Text = ""
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

    Private Sub TextBox_FName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_FName.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            TextBoxMilitNb.Text = ""
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
            If ComboBoxPersons.Items.Count = 1 Then
                Person_Label.Visible = False
            End If
        End If
    End Sub

    Private Sub SearchGun_Button_Click(sender As Object, e As EventArgs) Handles SearchGun_Button.Click
        If FullName_TextBox.Text.Length = 0 Then
            MsgBox("Please a choose a person first !!!")

            Person_Label.Visible = True
        Else
            Me.N0itemsAndPerGUnTableAdapter.FillByOwner(Me.GdssDataSet1.N0itemsAndPerGUn, ComboBoxPersons.SelectedValue)
            Me.AMMODataGridTableAdapter.FillByMilitaryNB(Me.GdssDataSet1.AMMODataGrid, ComboBoxPersons.SelectedValue.ToString)

        End If

    End Sub

    Private Sub Gun_DataGridView_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Gun_DataGridView.CellContentDoubleClick
        If Gun_DataGridView.Item(1, e.RowIndex).Value IsNot Nothing Then
            'MsgBox(Gun_DataGridView.Item(1, e.RowIndex).Value.ToString)
            Dim AgunInfo As GunInfo
            AgunInfo = New GunInfo(Gun_DataGridView.Item(1, e.RowIndex).Value)
            AgunInfo.ShowDialog()
        End If
    End Sub

    Private Sub Gun_DataGridView_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Gun_DataGridView.RowHeaderMouseDoubleClick

        If Gun_DataGridView.Item(1, e.RowIndex).Value IsNot Nothing Then
            Dim AgunInfo As GunInfo
            AgunInfo = New GunInfo(Gun_DataGridView.Item(1, e.RowIndex).Value)
            AgunInfo.ShowDialog()
        End If
    End Sub

    Private Sub Ammo_DataGridView_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Ammo_DataGridView.RowHeaderMouseDoubleClick
        If Ammo_DataGridView.Item(0, e.RowIndex).Value IsNot Nothing Then
            Dim myAmmoInfo As AmmoInfo
            myAmmoInfo = New AmmoInfo(Ammo_DataGridView.Item(0, e.RowIndex).Value)
            myAmmoInfo.ShowDialog()
        End If
    End Sub

    Private Sub Ammo_DataGridView_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Ammo_DataGridView.CellContentDoubleClick
        If Ammo_DataGridView.Item(0, e.RowIndex).Value IsNot Nothing Then
            Dim myAmmoInfo As AmmoInfo
            myAmmoInfo = New AmmoInfo(Ammo_DataGridView.Item(0, e.RowIndex).Value)
            myAmmoInfo.ShowDialog()
        End If
    End Sub

    Private Sub GiveAmmo_Button_Click(sender As Object, e As EventArgs) Handles GiveAmmo_Button.Click
        If FullName_TextBox.Text.Length = 0 Then
            MsgBox("Please choose a person first !!")
            Person_Label.Visible = True
            TextBoxMilitNb.Focus()
        Else
            Dim myGiveAmo As GiveAmmo
            myGiveAmo = New GiveAmmo(Myuser, ComboBoxPersons.SelectedValue.ToString)
            myGiveAmo.ShowDialog()
            'call give Gun  
        End If
    End Sub

    Private Sub GiveGun_Button_Click(sender As Object, e As EventArgs) Handles GiveGun_Button.Click
        If FullName_TextBox.Text.Length = 0 Then
            MsgBox("Please choose a person first !!")
            Person_Label.Visible = True
            TextBoxMilitNb.Focus()
        Else
            Dim MyGivGun As GiveGun
            MyGivGun = New GiveGun(Myuser, ComboBoxPersons.SelectedValue.ToString)
            MyGivGun.ShowDialog()

            'call give Gun  
        End If
    End Sub





    'Private Sub DataGridView_TypeErreur_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView_TypeErreur.RowHeaderMouseDoubleClick
    '    If DataGridView_TypeErreur.Item(0, e.RowIndex).Value IsNot Nothing Then
    '        callImgVieweWithEdit(DataGridView_TypeErreur.Item(0, e.RowIndex).Value.ToString(), IdScan)
    '    End If
    'End Sub


    ''------------------------
    'Private Sub DataGridView_good_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_good.CellContentDoubleClick
    '    If DataGridView_good.Item(0, e.RowIndex).Value IsNot Nothing Then
    '        callImgVieweWithEdit(DataGridView_good.Item(0, e.RowIndex).Value.ToString(), IdScan)
    '    End If
    'End Sub


End Class