Public Class GiveGun
    Public erreur As Boolean
    Public Muser As String
    Public myMiliNb As String
    'Private Sub New()
    '    erreur = False
    '    ' This call is required by the designer.
    '    InitializeComponent()

    '    ' Add any initialization after the InitializeComponent() call.

    'End Sub
    Private Sub GiveGun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GunType_TextBox.Text = ""
        'TODO: This line of code loads data into the 'GdssDataSet1.PERGUNTableAdapter' table. You can move, or remove it, as needed.
        Me.PERGUNTableAdapterTableAdapter.Fill(Me.GdssDataSet1.PERGUNTableAdapter)


        'TODO: This line of code loads data into the 'GdssDataSet11.N0OFFICE1' table. You can move, or remove it, as needed.
        ' Me.N0OFFICE1TableAdapter.Fill(Me.GdssDataSet1.N0OFFICE1)
        'TODO: This line of code loads data into the 'GdssDataSet1.IDCARD' table. You can move, or remove it, as needed.
        '  Me.IDCARDTableAdapter.Fill(Me.GdssDataSet1.IDCARD)
        'TODO: This line of code loads data into the 'GdssDataSet1.N0ITEMS' table. You can move, or remove it, as needed.
        '  Me.N0ITEMSTableAdapter.Fill(Me.GdssDataSet1.N0ITEMS)
        User_TextBox.Text = Muser
        erreur = False
    End Sub
    Public Sub New(user As String)

        ' This call is required by the designer.
        InitializeComponent()
        Muser = user
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(user As String, MilitiNB As String)

        ' This call is required by the designer.
        InitializeComponent()
        myMiliNb = MilitiNB
        Muser = user
        TextBoxMilitNb.Text = myMiliNb

        Me.IDCARDTableAdapter.FillByCODE(Me.GdssDataSet1.IDCARD, Decimal.Parse(myMiliNb))
        FullName_TextBox.Text = ComboBoxPersons.GetItemText(ComboBoxPersons.SelectedItem)

        ' Add any initialization after the InitializeComponent() call.

    End Sub





    Private Sub TextBox_NameGun_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_NameGun.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Me.N0ITEMSTableAdapter.FillBy(Me.GdssDataSet1.N0ITEMS, "%" & TextBox_NameGun.Text & "%")

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

    'module log in 
    Private Sub TextBoxMilitNb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxMilitNb.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Try

                FName_CheckBox.Checked = False
                LName_CheckBox.Checked = False
                FATHER_CheckBox.Checked = False

                If IsNumeric(TextBoxMilitNb.Text) Then
                    Me.N0ITEMSTableAdapter.ClearBeforeFill = True
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
    'module login
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
    'module login 
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



    Private Sub GunType_TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GunType_TextBox.KeyPress




    End Sub



    Private Sub GunType_TextBox_TextChanged(sender As Object, e As EventArgs) Handles GunType_TextBox.TextChanged

    End Sub

    Private Sub GunType_TextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles GunType_TextBox.KeyUp

        If Not String.IsNullOrEmpty(GunType_TextBox.Text) Then
            GunLabel_Label.Visible = False
        End If

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

        If GunNb_TextBox.Text <> String.Empty Then
            GNb_Label.Visible = False

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
            e.Handled = True

            MsgBox("Not allow to copy and past ")
            gunNbConfirm_TextBox.Text = ""
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
            GNb_Label.Visible = False
            erreur = False
            If checkNumberIfExist() = True Then
                erreur = True
                If gunNbConfirm_TextBox.Text.Length > 0 Then
                    MsgBox("this Current Number already exist ,Please enter a valid Number ")
                    gunNbConfirm_TextBox.Text = ""
                    GunNb_TextBox.Text = ""
                    Confirm_Label.Visible = False
                    GNb_Label.Visible = False
                    GunNb_TextBox.Focus()

                End If
            Else
                erreur = False

            End If


        End If

    End Sub


    Private Function checkNumberIfExist() As Boolean

        Dim result As String

        result = Me.PERGUNTableAdapterTableAdapter.checkIfNbExist(gunNbConfirm_TextBox.Text)

        If result Is Nothing Then
            Return False
        Else
            Return True
        End If


    End Function

    Private Sub GunStore_TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GunStore_TextBox.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            MsgBox("only Numbers allowed")
            e.Handled = True
            GunStore_Label.Visible = True
        End If
        If GunStore_TextBox.Text = String.Empty Then
            GunStore_Label.Visible = False
        End If
    End Sub

    Private Sub GAMMO_TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GAMMO_TextBox.KeyPress
        If Not Char.IsNumber(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
            MsgBox("only Numbers allowed")
            e.Handled = True
            GAMMO_Label.Visible = True
        End If



    End Sub

    Private Sub Supplier_TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Supplier_TextBox.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            ' Me.N0OFFICE1TableAdapter .FillByName (Me.da)
            Me.N0OFFICE1TableAdapter.FillByName(Me.GdssDataSet1.N0OFFICE1, "%" & Supplier_TextBox.Text & "%")
            If Supplier_ComboBox.Items.Count = 1 Then
                Supplier_Label.Visible = False
            End If
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim temp As Date
        temp = DateTimePicker1.Value
        temp.ToString("MM/DD/yyyy")
        ' temp.ToString("MM/DD/yyyy hh:mm")
        DDATE_TextBox.Text = temp.ToString
        DDate_Label.Visible = False

    End Sub

    Private Sub Save_Button_Click(sender As Object, e As EventArgs) Handles Save_Button.Click

        If checkTest() = True Then
            MsgBox("error")
        Else
            'MsgBox("every thing is good ")

            Dim CurrentTime As String

            CurrentTime = Date.Now.ToString("MM/dd/yyyy ")
            '  CurrentTime = Date.Now.ToString("MM/dd/yyyy hh:mm tt")

            Dim withCleaner As Integer
            If WithCleaner_CheckBox.AutoCheck = True Then
                withCleaner = 1
            Else
                withCleaner = 0
            End If

            Try
                Me.PERGUNTableAdapterTableAdapter.InsertQuery(Decimal.Parse(Me.PERGUNTableAdapterTableAdapter.getMaxCodePlus1().ToString), ComboBox1.SelectedValue.ToString, GunType_TextBox.Text, gunNbConfirm_TextBox.Text, Decimal.Parse(GunStore_TextBox.Text), Decimal.Parse(GunSize_TextBox.Text), withCleaner, Decimal.Parse(GAMMO_TextBox.Text), Decimal.Parse(Supplier_ComboBox.SelectedValue.ToString), Decimal.Parse(ComboBoxPersons.SelectedValue.ToString), Decimal.Parse(Source_ComboBox.SelectedValue.ToString), Decimal.Parse(Grade_ComboBox.SelectedValue.ToString), DDATE_TextBox.Text, NBDoc_TextBox.Text, Note_TextBox.Text, SDATE_TextBox.Text, CurrentTime, Muser, CurrentTime, "None")
                MsgBox("Saved")
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try



        End If




    End Sub
    Private Function checkTest() As Boolean
        Dim result As Boolean
        result = False
        If DDATE_TextBox.Text.Length = 0 Then
            result = True
            DDate_Label.Visible = True

        End If

        If NBDoc_TextBox.Text.Length = 0 Then
            result = True
            Document_Label.Visible = True
        End If

        If SuppShow_TextBox.Text.Length = 0 Then
            result = True
            Supplier_Label.Visible = True
        End If



        If GAMMO_TextBox.Text.Length = 0 Then
            GAMMO_Label.Visible = True
            result = True
        End If
        If GunSize_TextBox.Text.Length = 0 Then
            gunSize_Label.Visible = True
            result = True
        End If

        If GunStore_TextBox.Text.Length = 0 Then
            GunStore_Label.Visible = True
            result = True
        End If

        If GunNb_TextBox.Text.Length = 0 Then
            GNb_Label.Visible = True
            result = True

        End If

        If gunNbConfirm_TextBox.Text.Length = 0 Then
            Confirm_Label.Visible = True
            result = True

        End If

        If String.Compare(GunNb_TextBox.Text, gunNbConfirm_TextBox.Text) <> 0 Then
            Confirm_Label.Visible = True
            result = True
        End If


        If checkNumberIfExist() = True Then
            result = True

        End If

        If GunType_TextBox.Text.Length = 0 Then
            GunLabel_Label.Visible = True
            result = True

        End If


        If Item_TextBox.Text.Length = 0 Then
            Item_Label.Visible = True
            result = True
        End If


        If FullName_TextBox.Text.Length = 0 Then
            Person_Label.Visible = True
            result = True
        End If

        If SDATE_TextBox.Text.Length = 0 Then
            SDATE_Label.Visible = True
            result = True

        End If










        Return result
    End Function

    Private Sub NBDoc_TextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles NBDoc_TextBox.KeyUp
        If NBDoc_TextBox.Text <> String.Empty Then
            Document_Label.Visible = False

        End If
    End Sub

    Private Sub GunSize_TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GunSize_TextBox.KeyPress

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Item_TextBox.Text = ComboBox1.GetItemText(ComboBox1.SelectedItem)
        If Item_TextBox.Text <> String.Empty Then
            Item_Label.Visible = False
        End If
    End Sub
    'module login 
    Private Sub ComboBoxPersons_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPersons.SelectedIndexChanged
        FullName_TextBox.Text = ComboBoxPersons.GetItemText(ComboBoxPersons.SelectedItem)
        If FullName_TextBox.Text <> String.Empty Then
            Person_Label.Visible = False

        End If
    End Sub

    Private Sub Supplier_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Supplier_ComboBox.SelectedIndexChanged
        SuppShow_TextBox.Text = Supplier_ComboBox.GetItemText(Supplier_ComboBox.SelectedItem)

        If SuppShow_TextBox.Text <> String.Empty Then
            Supplier_Label.Visible = False
        End If
    End Sub

    Private Sub GAMMO_TextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles GAMMO_TextBox.KeyUp
        If GAMMO_TextBox.Text <> String.Empty Then
            GAMMO_Label.Visible = False
        End If
    End Sub

    Private Sub GunSize_TextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles GunSize_TextBox.KeyUp
        If GunSize_TextBox.Text <> String.Empty Then
            gunSize_Label.Visible = False
        End If
    End Sub

    Private Sub GunStore_TextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles GunStore_TextBox.KeyUp
        If GunStore_TextBox.Text <> String.Empty Then
            GunStore_Label.Visible = False
        End If
    End Sub

    Private Sub DateTimePickerSDATE_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerSDATE.ValueChanged
        Dim temp, temp2 As Date
        temp = DateTimePicker1.Value
        Try
            temp2 = DateTime.ParseExact(temp, "MM/dd/yyyy", Globalization.CultureInfo.InstalledUICulture)
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try

        temp.ToString("MM/dd/yyyy")
        'temp.ToString("MM/DD/yyyy hh:mm")
        SDATE_TextBox.Text = temp.ToString
        SDATE_Label.Visible = False
    End Sub

    Private Sub SDATE_TextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles SDATE_TextBox.KeyUp
        If SDATE_TextBox.Text <> String.Empty Then
            SDATE_Label.Visible = False
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub


End Class