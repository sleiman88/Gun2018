Public Class MainReportByPerson
    Private Sub MainReportByPerson_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GdssDataSet1.AmmoReportWithGrade' table. You can move, or remove it, as needed.
        'Me.AmmoReportWithGradeTableAdapter.Fill(Me.GdssDataSet1.AmmoReportWithGrade)
        'TODO: This line of code loads data into the 'GdssDataSet1.AmmoReportInfo' table. You can move, or remove it, as needed.
        ' Me.AmmoReportInfoTableAdapter.Fill(Me.GdssDataSet1.AmmoReportInfo)
        'TODO: This line of code loads data into the 'GdssDataSet1.GunReportInfoForm' table. You can move, or remove it, as needed.
        '  Me.GunReportInfoFormTableAdapter.Fill(Me.GdssDataSet1.GunReportInfoForm)
        'TODO: This line of code loads data into the 'GdssDataSet1.N0itemsAndPerGUn' table. You can move, or remove it, as needed.
        ' Me.N0itemsAndPerGUnTableAdapter.Fill(Me.GdssDataSet1.N0itemsAndPerGUn)
        'TODO: This line of code loads data into the 'GdssDataSet1.IDCARD' table. You can move, or remove it, as needed.
        'Me.IDCARDTableAdapter.Fill(Me.GdssDataSet1.IDCARD)

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
    'search person form 
    Private Sub ComboBoxPersons_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPersons.SelectedIndexChanged
        FullName_TextBox.Text = ComboBoxPersons.GetItemText(ComboBoxPersons.SelectedItem)
        If FullName_TextBox.Text <> String.Empty Then
            Person_Label.Visible = False

        End If
    End Sub
    'search person form 
    Private Sub FName_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles FName_CheckBox.CheckedChanged
        If FName_CheckBox.Checked = True Then
            TextBox_FName.Enabled = True
        Else
            TextBox_FName.Enabled = False
            TextBox_FName.Text = ""
        End If
    End Sub
    'search person form 
    Private Sub FATHER_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles FATHER_CheckBox.CheckedChanged
        If FATHER_CheckBox.Checked = True Then
            TextBox_FATHER.Enabled = True
        Else
            TextBox_FATHER.Enabled = False
            TextBox_FATHER.Text = ""

        End If
    End Sub
    'search person form 
    Private Sub LName_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles LName_CheckBox.CheckedChanged
        If LName_CheckBox.Checked = True Then
            TextBoxLName.Enabled = True
        Else
            TextBoxLName.Enabled = False
            TextBoxLName.Text = ""
        End If
    End Sub
    'search person form 
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
    'search person form 
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
    'search person form 
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
    'search person form 


    Private Sub Button_ReportGun_Click(sender As Object, e As EventArgs) Handles Button_ReportGun.Click
        If FullName_TextBox.Text.Length = 0 Then
            MsgBox("Please a choose a person first !!!")

            Person_Label.Visible = True
        Else
            Me.GunReportInfoFormTableAdapter.FillByOwner(Me.GdssDataSet1.GunReportInfoForm, ComboBoxPersons.SelectedValue)
            Dim MyReportGunByPerson As ReportGunByPerson
            MyReportGunByPerson = New ReportGunByPerson()
            MyReportGunByPerson.ShowDialog()
            MyReportGunByPerson.ReportViewer1.RefreshReport()
            ' Me.N0itemsAndPerGUnTableAdapter.FillByOwner(Me.GdssDataSet1.N0itemsAndPerGUn, ComboBoxPersons.SelectedValue)

        End If
    End Sub

    Private Sub Button_ReportAmoo_Click(sender As Object, e As EventArgs) Handles Button_ReportAmoo.Click
        If FullName_TextBox.Text.Length = 0 Then
            MsgBox("Please a choose a person first !!!")

            Person_Label.Visible = True
        Else
            Me.AmmoReportWithGradeTableAdapter.FillByMilitaryNb(Me.GdssDataSet1.AmmoReportWithGrade, ComboBoxPersons.SelectedValue)
            ' Me.GunReportInfoFormTableAdapter.FillByOwner(Me.GdssDataSet1.GunReportInfoForm, ComboBoxPersons.SelectedValue)
            'Me.AmmoReportInfoTableAdapter.FillByMILINB(Me.GdssDataSet1.AmmoReportInfo, ComboBoxPersons.SelectedValue)
            ' Me.AmmoReportInfoTableAdapter.FillByMILINB(Me.GdssDataSet1.AmmoReportInfo, ComboBoxPersons.SelectedValue.ToString)
            Dim MyReportAmmoByPerson As ReportAmmoByPerson
            MyReportAmmoByPerson = New ReportAmmoByPerson()
            MyReportAmmoByPerson.ShowDialog()
            MyReportAmmoByPerson.ReportViewer1.RefreshReport()

            'Me.GunReportInfoFormTableAdapter.FillByOwner(Me.GdssDataSet1.GunReportInfoForm, ComboBoxPersons.SelectedValue)
            ' Me.N0itemsAndPerGUnTableAdapter.FillByOwner(Me.GdssDataSet1.N0itemsAndPerGUn, ComboBoxPersons.SelectedValue)

        End If
    End Sub
End Class