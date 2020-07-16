Public Class GiveAmmo
    Public Muser As String
    Public MymilitNB As String
    Private Sub GiveAmmo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Year_NumericUpDown.Value = Decimal.Parse(System.DateTime.UtcNow.Year)
        Year_TextBox.Text = Year_NumericUpDown.Value.ToString
        'TODO: This line of code loads data into the 'GdssDataSet1.AMMO' table. You can move, or remove it, as needed.
        ' Me.AMMOTableAdapter.Fill(Me.GdssDataSet1.AMMO)
        'TODO: This line of code loads data into the 'GdssDataSet1.PERGUNTableAdapter' table. You can move, or remove it, as needed.
        '  Me.PERGUNTableAdapterTableAdapter.Fill(Me.GdssDataSet1.PERGUNTableAdapter)
        'TODO: This line of code loads data into the 'GdssDataSet11.AMMO' table. You can move, or remove it, as needed.
        ' Me.AMMOTableAdapter.Fill(Me.GdssDataSet11.AMMO)
        'TODO: This line of code loads data into the 'GdssDataSet1.IDCARD' table. You can move, or remove it, as needed.
        '  Me.IDCARDTableAdapter.Fill(Me.GdssDataSet1.IDCARD)
        User_TextBox.Text = Muser


    End Sub
    Public Sub New(user As String)

        ' This call is required by the designer.
        InitializeComponent()

        Year_NumericUpDown.Minimum = 1
        Year_NumericUpDown.Maximum = 3000

        Muser = user

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(user As String, militNb As String)

        ' This call is required by the designer.
        InitializeComponent()

        Year_NumericUpDown.Minimum = 1
        Year_NumericUpDown.Maximum = 3000

        Muser = user
        MymilitNB = militNb
        TextBoxMilitNb.Text = MymilitNB

        Me.IDCARDTableAdapter.FillByCODE(Me.GdssDataSet1.IDCARD, Decimal.Parse(MymilitNB))
        FullName_TextBox.Text = ComboBoxPersons.GetItemText(ComboBoxPersons.SelectedItem)

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub TextBoxMilitNb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxMilitNb.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            FName_CheckBox.Checked = False
            LName_CheckBox.Checked = False
            FATHER_CheckBox.Checked = False
            Try
                If IsNumeric(TextBoxMilitNb.Text) Then

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

    Private Sub ComboBoxPersons_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPersons.SelectedIndexChanged
        FullName_TextBox.Text = ComboBoxPersons.GetItemText(ComboBoxPersons.SelectedItem)
        TextBoxMilitNb.Text = ComboBoxPersons.SelectedValue
        If FullName_TextBox.Text <> String.Empty Then
            Person_Label.Visible = False
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

    Private Sub NBDoc_TextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles NBDoc_TextBox.KeyUp
        If NBDoc_TextBox.Text <> String.Empty Then
            Document_Label.Visible = False
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles Document_DateTimePicker.ValueChanged
        Dim temp As Date
        temp = Document_DateTimePicker.Value
        temp.ToString("yyyy")
        DDATE_TextBox.Text = temp.ToString
        DDate_Label.Visible = False
    End Sub




    Private Function checkValidation() As Boolean
        Dim result As Boolean
        result = False
        If FullName_TextBox.Text.Length = 0 Then
            result = True
            Person_Label.Visible = True

        End If

        If NBDoc_TextBox.Text.Length = 0 Then
            result = True
            Document_Label.Visible = True

        End If

        If Year_TextBox.Text.Length = 0 Then
            result = True

            Year_Label.Visible = True

        End If

        If DDATE_TextBox.Text.Length = 0 Then
            result = True
            DDate_Label.Visible = True

        End If

        If AmoQuantity_TextBox.Text.Length = 0 Then
            result = True
            AmmoQuantity_Label.Visible = True

        End If

        If Special_CheckBox.Checked = True And SpecialNote_TextBox.Text.Length = 0 Then
            SpecialNote_Label.Visible = True

        End If
        If size_TextBox.Text.Length = 0 Then
            result = True
            size_Label.Visible = True

        End If
        If Year_TextBox.Text <> String.Empty And FullName_TextBox.Text <> String.Empty And AmoQuantity_TextBox.Text <> String.Empty Then
            Dim totalQuantity As Integer
            totalQuantity = Decimal.Parse(Me.AMMOTableAdapter.getTotalQuantityByYearAndPerson(Year_TextBox.Text, ComboBoxPersons.SelectedValue.ToString))
            totalQuantity = totalQuantity + Decimal.Parse(AmoQuantity_TextBox.Text)
            If totalQuantity >= 100 And SpecialNote_TextBox.Text = String.Empty Then
                MsgBox("Maximum Ammo quantity allowed for year :  " + Year_TextBox.Text + " taken already .It required as special permisison please !!")
                result = True
                SpecialNote_Label.Visible = True
            End If
        End If


        Return result
    End Function

    Private Sub Check_Button_Click(sender As Object, e As EventArgs) Handles Check_Button.Click
        If Year_TextBox.Text.Length = 0 Or FullName_TextBox.Text.Length = 0 Or AmoQuantity_TextBox.Text.Length = 0 Then
            MsgBox("Please choose first a person and a Year and add a quantity  ")
        Else
            Dim totalQuantity As Integer
            totalQuantity = Decimal.Parse(Me.AMMOTableAdapter.getTotalQuantityByYearAndPerson(Year_TextBox.Text, ComboBoxPersons.SelectedValue.ToString))
            totalQuantity = totalQuantity + Decimal.Parse(AmoQuantity_TextBox.Text)
            If totalQuantity >= 100 And SpecialNote_TextBox.Text = String.Empty Then
                MsgBox("Maximum Ammo quantity allowed for year :  " + Year_TextBox.Text + " taken already .It required as special permisison please !!")
            Else
                MsgBox("Valide")
            End If

        End If
    End Sub

    Private Sub AmoQuantity_TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AmoQuantity_TextBox.KeyPress
        If Not Char.IsNumber(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
            MsgBox("only Numbers allowed")
            e.Handled = True
            AmmoQuantity_Label.Visible = True
        End If
    End Sub

    Private Sub AmoQuantity_TextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles AmoQuantity_TextBox.KeyUp
        If AmoQuantity_TextBox.Text <> String.Empty Then
            AmmoQuantity_Label.Visible = False
        End If
    End Sub

    Private Sub Save_Button_Click(sender As Object, e As EventArgs) Handles Save_Button.Click
        If checkValidation() = True Then
            MsgBox("Please enter Missing Informations!")
        Else
            Dim status As Int32
            If Special_CheckBox.Checked = True Then
                status = 1
            Else
                status = 0
            End If
            Me.AMMOTableAdapter.InsertQuery(Decimal.Parse(Me.AMMOTableAdapter.getNewPK()), TextBoxMilitNb.Text, Year_TextBox.Text, Decimal.Parse(AmoQuantity_TextBox.Text), NBDoc_TextBox.Text, Document_DateTimePicker.Value, status, SpecialNote_TextBox.Text, size_TextBox.Text, Note_TextBox.Text, Muser, System.DateTime.Now, "Null", System.DateTime.Now)
            MsgBox("Saved")
            Me.Close()
        End If
    End Sub

    Private Sub Special_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Special_CheckBox.CheckedChanged
        If Special_CheckBox.Checked = True Then
            SpecialNote_TextBox.Visible = True
        Else

            SpecialNote_TextBox.Text = ""
            SpecialNote_TextBox.Visible = False

        End If
    End Sub

    Private Sub SpecialNote_TextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles SpecialNote_TextBox.KeyUp
        If SpecialNote_TextBox.Text.Length > 0 Then
            SpecialNote_Label.Visible = False

        End If
    End Sub

    Private Sub size_TextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles size_TextBox.KeyUp
        If size_TextBox.Text <> String.Empty Then
            size_Label.Visible = False
        End If
    End Sub

    Private Sub Year_NumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles Year_NumericUpDown.ValueChanged
        Year_TextBox.Text = Year_NumericUpDown.Value
    End Sub
End Class