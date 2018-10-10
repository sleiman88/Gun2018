<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GiveAmmo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.FullName_TextBox = New System.Windows.Forms.TextBox()
        Me.Person_Label = New System.Windows.Forms.Label()
        Me.LName_CheckBox = New System.Windows.Forms.CheckBox()
        Me.FATHER_CheckBox = New System.Windows.Forms.CheckBox()
        Me.FName_CheckBox = New System.Windows.Forms.CheckBox()
        Me.TextBoxLName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_FATHER = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxPersons = New System.Windows.Forms.ComboBox()
        Me.IDCARDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GdssDataSet1 = New GDSSTEMPLATE.gdssDataSet1()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_FName = New System.Windows.Forms.TextBox()
        Me.TextBoxMilitNb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IDCARDTableAdapter = New GDSSTEMPLATE.gdssDataSet1TableAdapters.IDCARDTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.User_TextBox = New System.Windows.Forms.TextBox()
        Me.Note_TextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Document_DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DDate_Label = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Document_Label = New System.Windows.Forms.Label()
        Me.DDATE_TextBox = New System.Windows.Forms.TextBox()
        Me.NBDoc_TextBox = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Save_Button = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Year_NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Year_Label = New System.Windows.Forms.Label()
        Me.Year_TextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.size_Label = New System.Windows.Forms.Label()
        Me.size_TextBox = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SpecialNote_Label = New System.Windows.Forms.Label()
        Me.Special_CheckBox = New System.Windows.Forms.CheckBox()
        Me.SpecialNote_TextBox = New System.Windows.Forms.TextBox()
        Me.AmmoQuantity_Label = New System.Windows.Forms.Label()
        Me.Check_Button = New System.Windows.Forms.Button()
        Me.AmoQuantity_TextBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.AMMOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AMMOTableAdapter = New GDSSTEMPLATE.gdssDataSet1TableAdapters.AMMOTableAdapter()
        Me.Panel2.SuspendLayout()
        CType(Me.IDCARDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GdssDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Year_NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.AMMOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.FullName_TextBox)
        Me.Panel2.Controls.Add(Me.Person_Label)
        Me.Panel2.Controls.Add(Me.LName_CheckBox)
        Me.Panel2.Controls.Add(Me.FATHER_CheckBox)
        Me.Panel2.Controls.Add(Me.FName_CheckBox)
        Me.Panel2.Controls.Add(Me.TextBoxLName)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.TextBox_FATHER)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.ComboBoxPersons)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.TextBox_FName)
        Me.Panel2.Controls.Add(Me.TextBoxMilitNb)
        Me.Panel2.Location = New System.Drawing.Point(12, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(654, 178)
        Me.Panel2.TabIndex = 5
        '
        'FullName_TextBox
        '
        Me.FullName_TextBox.Enabled = False
        Me.FullName_TextBox.Location = New System.Drawing.Point(412, 19)
        Me.FullName_TextBox.Name = "FullName_TextBox"
        Me.FullName_TextBox.Size = New System.Drawing.Size(211, 20)
        Me.FullName_TextBox.TabIndex = 17
        '
        'Person_Label
        '
        Me.Person_Label.AutoSize = True
        Me.Person_Label.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Person_Label.ForeColor = System.Drawing.Color.OrangeRed
        Me.Person_Label.Location = New System.Drawing.Point(629, 21)
        Me.Person_Label.Name = "Person_Label"
        Me.Person_Label.Size = New System.Drawing.Size(18, 19)
        Me.Person_Label.TabIndex = 16
        Me.Person_Label.Text = "*"
        Me.Person_Label.Visible = False
        '
        'LName_CheckBox
        '
        Me.LName_CheckBox.AutoSize = True
        Me.LName_CheckBox.Location = New System.Drawing.Point(204, 123)
        Me.LName_CheckBox.Name = "LName_CheckBox"
        Me.LName_CheckBox.Size = New System.Drawing.Size(58, 17)
        Me.LName_CheckBox.TabIndex = 12
        Me.LName_CheckBox.Text = "Enable"
        Me.LName_CheckBox.UseVisualStyleBackColor = True
        '
        'FATHER_CheckBox
        '
        Me.FATHER_CheckBox.AutoSize = True
        Me.FATHER_CheckBox.Location = New System.Drawing.Point(204, 94)
        Me.FATHER_CheckBox.Name = "FATHER_CheckBox"
        Me.FATHER_CheckBox.Size = New System.Drawing.Size(58, 17)
        Me.FATHER_CheckBox.TabIndex = 11
        Me.FATHER_CheckBox.Text = "Enable"
        Me.FATHER_CheckBox.UseVisualStyleBackColor = True
        '
        'FName_CheckBox
        '
        Me.FName_CheckBox.AutoSize = True
        Me.FName_CheckBox.Location = New System.Drawing.Point(204, 63)
        Me.FName_CheckBox.Name = "FName_CheckBox"
        Me.FName_CheckBox.Size = New System.Drawing.Size(58, 17)
        Me.FName_CheckBox.TabIndex = 10
        Me.FName_CheckBox.Text = "Enable"
        Me.FName_CheckBox.UseVisualStyleBackColor = True
        '
        'TextBoxLName
        '
        Me.TextBoxLName.Enabled = False
        Me.TextBoxLName.Location = New System.Drawing.Point(96, 116)
        Me.TextBoxLName.Name = "TextBoxLName"
        Me.TextBoxLName.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxLName.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Last Name"
        '
        'TextBox_FATHER
        '
        Me.TextBox_FATHER.Enabled = False
        Me.TextBox_FATHER.Location = New System.Drawing.Point(96, 87)
        Me.TextBox_FATHER.Name = "TextBox_FATHER"
        Me.TextBox_FATHER.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_FATHER.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Father Name"
        '
        'ComboBoxPersons
        '
        Me.ComboBoxPersons.DataSource = Me.IDCARDBindingSource
        Me.ComboBoxPersons.DisplayMember = "FullName"
        Me.ComboBoxPersons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPersons.FormattingEnabled = True
        Me.ComboBoxPersons.Location = New System.Drawing.Point(96, 16)
        Me.ComboBoxPersons.Name = "ComboBoxPersons"
        Me.ComboBoxPersons.Size = New System.Drawing.Size(201, 21)
        Me.ComboBoxPersons.TabIndex = 4
        Me.ComboBoxPersons.ValueMember = "CODE"
        '
        'IDCARDBindingSource
        '
        Me.IDCARDBindingSource.DataMember = "IDCARD"
        Me.IDCARDBindingSource.DataSource = Me.GdssDataSet1
        '
        'GdssDataSet1
        '
        Me.GdssDataSet1.DataSetName = "gdssDataSet1"
        Me.GdssDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Military Number"
        '
        'TextBox_FName
        '
        Me.TextBox_FName.Enabled = False
        Me.TextBox_FName.Location = New System.Drawing.Point(96, 61)
        Me.TextBox_FName.Name = "TextBox_FName"
        Me.TextBox_FName.Size = New System.Drawing.Size(101, 20)
        Me.TextBox_FName.TabIndex = 1
        '
        'TextBoxMilitNb
        '
        Me.TextBoxMilitNb.Location = New System.Drawing.Point(306, 17)
        Me.TextBoxMilitNb.Name = "TextBoxMilitNb"
        Me.TextBoxMilitNb.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxMilitNb.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Person"
        '
        'IDCARDTableAdapter
        '
        Me.IDCARDTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "User"
        '
        'User_TextBox
        '
        Me.User_TextBox.Enabled = False
        Me.User_TextBox.Location = New System.Drawing.Point(49, 1)
        Me.User_TextBox.Name = "User_TextBox"
        Me.User_TextBox.Size = New System.Drawing.Size(173, 20)
        Me.User_TextBox.TabIndex = 8
        '
        'Note_TextBox
        '
        Me.Note_TextBox.Location = New System.Drawing.Point(791, 360)
        Me.Note_TextBox.Multiline = True
        Me.Note_TextBox.Name = "Note_TextBox"
        Me.Note_TextBox.Size = New System.Drawing.Size(451, 129)
        Me.Note_TextBox.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(788, 335)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Note"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Document_DateTimePicker)
        Me.Panel4.Controls.Add(Me.DDate_Label)
        Me.Panel4.Controls.Add(Me.Label21)
        Me.Panel4.Controls.Add(Me.Document_Label)
        Me.Panel4.Controls.Add(Me.DDATE_TextBox)
        Me.Panel4.Controls.Add(Me.NBDoc_TextBox)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Location = New System.Drawing.Point(689, 63)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(512, 70)
        Me.Panel4.TabIndex = 13
        '
        'Document_DateTimePicker
        '
        Me.Document_DateTimePicker.Location = New System.Drawing.Point(140, 37)
        Me.Document_DateTimePicker.Name = "Document_DateTimePicker"
        Me.Document_DateTimePicker.Size = New System.Drawing.Size(192, 20)
        Me.Document_DateTimePicker.TabIndex = 2
        '
        'DDate_Label
        '
        Me.DDate_Label.AutoSize = True
        Me.DDate_Label.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DDate_Label.ForeColor = System.Drawing.Color.OrangeRed
        Me.DDate_Label.Location = New System.Drawing.Point(489, 41)
        Me.DDate_Label.Name = "DDate_Label"
        Me.DDate_Label.Size = New System.Drawing.Size(18, 19)
        Me.DDate_Label.TabIndex = 16
        Me.DDate_Label.Text = "*"
        Me.DDate_Label.Visible = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(4, 40)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(81, 13)
        Me.Label21.TabIndex = 17
        Me.Label21.Text = "Document Date"
        '
        'Document_Label
        '
        Me.Document_Label.AutoSize = True
        Me.Document_Label.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Document_Label.ForeColor = System.Drawing.Color.OrangeRed
        Me.Document_Label.Location = New System.Drawing.Point(338, 10)
        Me.Document_Label.Name = "Document_Label"
        Me.Document_Label.Size = New System.Drawing.Size(18, 19)
        Me.Document_Label.TabIndex = 16
        Me.Document_Label.Text = "*"
        Me.Document_Label.Visible = False
        '
        'DDATE_TextBox
        '
        Me.DDATE_TextBox.Enabled = False
        Me.DDATE_TextBox.Location = New System.Drawing.Point(338, 37)
        Me.DDATE_TextBox.Name = "DDATE_TextBox"
        Me.DDATE_TextBox.Size = New System.Drawing.Size(145, 20)
        Me.DDATE_TextBox.TabIndex = 1
        '
        'NBDoc_TextBox
        '
        Me.NBDoc_TextBox.Location = New System.Drawing.Point(140, 9)
        Me.NBDoc_TextBox.MaxLength = 20
        Me.NBDoc_TextBox.Name = "NBDoc_TextBox"
        Me.NBDoc_TextBox.Size = New System.Drawing.Size(192, 20)
        Me.NBDoc_TextBox.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(4, 9)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(108, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Number of Document"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(689, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Document"
        '
        'Save_Button
        '
        Me.Save_Button.Location = New System.Drawing.Point(1130, 521)
        Me.Save_Button.Name = "Save_Button"
        Me.Save_Button.Size = New System.Drawing.Size(75, 23)
        Me.Save_Button.TabIndex = 15
        Me.Save_Button.Text = "Save"
        Me.Save_Button.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Year_NumericUpDown)
        Me.Panel1.Controls.Add(Me.Year_Label)
        Me.Panel1.Controls.Add(Me.Year_TextBox)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Location = New System.Drawing.Point(12, 270)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(654, 62)
        Me.Panel1.TabIndex = 16
        '
        'Year_NumericUpDown
        '
        Me.Year_NumericUpDown.Location = New System.Drawing.Point(223, 17)
        Me.Year_NumericUpDown.Name = "Year_NumericUpDown"
        Me.Year_NumericUpDown.Size = New System.Drawing.Size(145, 20)
        Me.Year_NumericUpDown.TabIndex = 22
        '
        'Year_Label
        '
        Me.Year_Label.AutoSize = True
        Me.Year_Label.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Year_Label.ForeColor = System.Drawing.Color.OrangeRed
        Me.Year_Label.Location = New System.Drawing.Point(629, 18)
        Me.Year_Label.Name = "Year_Label"
        Me.Year_Label.Size = New System.Drawing.Size(18, 19)
        Me.Year_Label.TabIndex = 21
        Me.Year_Label.Text = "*"
        Me.Year_Label.Visible = False
        '
        'Year_TextBox
        '
        Me.Year_TextBox.Enabled = False
        Me.Year_TextBox.Location = New System.Drawing.Point(412, 17)
        Me.Year_TextBox.Name = "Year_TextBox"
        Me.Year_TextBox.Size = New System.Drawing.Size(211, 20)
        Me.Year_TextBox.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(5, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Year of the Ammo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 254)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Year"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.size_Label)
        Me.Panel3.Controls.Add(Me.size_TextBox)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.SpecialNote_Label)
        Me.Panel3.Controls.Add(Me.Special_CheckBox)
        Me.Panel3.Controls.Add(Me.SpecialNote_TextBox)
        Me.Panel3.Controls.Add(Me.AmmoQuantity_Label)
        Me.Panel3.Controls.Add(Me.Check_Button)
        Me.Panel3.Controls.Add(Me.AmoQuantity_TextBox)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Location = New System.Drawing.Point(6, 379)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(654, 172)
        Me.Panel3.TabIndex = 18
        '
        'size_Label
        '
        Me.size_Label.AutoSize = True
        Me.size_Label.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.size_Label.ForeColor = System.Drawing.Color.OrangeRed
        Me.size_Label.Location = New System.Drawing.Point(250, 44)
        Me.size_Label.Name = "size_Label"
        Me.size_Label.Size = New System.Drawing.Size(18, 19)
        Me.size_Label.TabIndex = 23
        Me.size_Label.Text = "*"
        Me.size_Label.Visible = False
        '
        'size_TextBox
        '
        Me.size_TextBox.Location = New System.Drawing.Point(102, 41)
        Me.size_TextBox.Name = "size_TextBox"
        Me.size_TextBox.Size = New System.Drawing.Size(139, 20)
        Me.size_TextBox.TabIndex = 22
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(4, 50)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Ammo Size"
        '
        'SpecialNote_Label
        '
        Me.SpecialNote_Label.AutoSize = True
        Me.SpecialNote_Label.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpecialNote_Label.ForeColor = System.Drawing.Color.OrangeRed
        Me.SpecialNote_Label.Location = New System.Drawing.Point(67, 89)
        Me.SpecialNote_Label.Name = "SpecialNote_Label"
        Me.SpecialNote_Label.Size = New System.Drawing.Size(18, 19)
        Me.SpecialNote_Label.TabIndex = 20
        Me.SpecialNote_Label.Text = "*"
        Me.SpecialNote_Label.Visible = False
        '
        'Special_CheckBox
        '
        Me.Special_CheckBox.AutoSize = True
        Me.Special_CheckBox.Location = New System.Drawing.Point(6, 69)
        Me.Special_CheckBox.Name = "Special_CheckBox"
        Me.Special_CheckBox.Size = New System.Drawing.Size(90, 17)
        Me.Special_CheckBox.TabIndex = 19
        Me.Special_CheckBox.Text = "Special Order"
        Me.Special_CheckBox.UseVisualStyleBackColor = True
        '
        'SpecialNote_TextBox
        '
        Me.SpecialNote_TextBox.Location = New System.Drawing.Point(101, 67)
        Me.SpecialNote_TextBox.Multiline = True
        Me.SpecialNote_TextBox.Name = "SpecialNote_TextBox"
        Me.SpecialNote_TextBox.Size = New System.Drawing.Size(508, 95)
        Me.SpecialNote_TextBox.TabIndex = 18
        Me.SpecialNote_TextBox.Visible = False
        '
        'AmmoQuantity_Label
        '
        Me.AmmoQuantity_Label.AutoSize = True
        Me.AmmoQuantity_Label.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmmoQuantity_Label.ForeColor = System.Drawing.Color.OrangeRed
        Me.AmmoQuantity_Label.Location = New System.Drawing.Point(250, 21)
        Me.AmmoQuantity_Label.Name = "AmmoQuantity_Label"
        Me.AmmoQuantity_Label.Size = New System.Drawing.Size(18, 19)
        Me.AmmoQuantity_Label.TabIndex = 17
        Me.AmmoQuantity_Label.Text = "*"
        Me.AmmoQuantity_Label.Visible = False
        '
        'Check_Button
        '
        Me.Check_Button.Location = New System.Drawing.Point(292, 17)
        Me.Check_Button.Name = "Check_Button"
        Me.Check_Button.Size = New System.Drawing.Size(119, 23)
        Me.Check_Button.TabIndex = 2
        Me.Check_Button.Text = "Check"
        Me.Check_Button.UseVisualStyleBackColor = True
        '
        'AmoQuantity_TextBox
        '
        Me.AmoQuantity_TextBox.Location = New System.Drawing.Point(102, 17)
        Me.AmoQuantity_TextBox.Name = "AmoQuantity_TextBox"
        Me.AmoQuantity_TextBox.Size = New System.Drawing.Size(139, 20)
        Me.AmoQuantity_TextBox.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Quantiy"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 360)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Ammo"
        '
        'AMMOBindingSource
        '
        Me.AMMOBindingSource.DataMember = "AMMO"
        Me.AMMOBindingSource.DataSource = Me.GdssDataSet1
        '
        'AMMOTableAdapter
        '
        Me.AMMOTableAdapter.ClearBeforeFill = True
        '
        'GiveAmmo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1254, 563)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Save_Button)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Note_TextBox)
        Me.Controls.Add(Me.User_TextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "GiveAmmo"
        Me.Text = "Ammo"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.IDCARDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GdssDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Year_NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.AMMOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents FullName_TextBox As TextBox
    Friend WithEvents Person_Label As Label
    Friend WithEvents LName_CheckBox As CheckBox
    Friend WithEvents FATHER_CheckBox As CheckBox
    Friend WithEvents FName_CheckBox As CheckBox
    Friend WithEvents TextBoxLName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox_FATHER As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxPersons As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_FName As TextBox
    Friend WithEvents TextBoxMilitNb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GdssDataSet1 As gdssDataSet1
    Friend WithEvents IDCARDBindingSource As BindingSource
    Friend WithEvents IDCARDTableAdapter As gdssDataSet1TableAdapters.IDCARDTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents User_TextBox As TextBox
    Friend WithEvents Note_TextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Document_DateTimePicker As DateTimePicker
    Friend WithEvents DDate_Label As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Document_Label As Label
    Friend WithEvents DDATE_TextBox As TextBox
    Friend WithEvents NBDoc_TextBox As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Save_Button As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Year_Label As Label
    Friend WithEvents Year_TextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents AmmoQuantity_Label As Label
    Friend WithEvents Check_Button As Button
    Friend WithEvents AmoQuantity_TextBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Special_CheckBox As CheckBox
    Friend WithEvents SpecialNote_TextBox As TextBox
    Friend WithEvents SpecialNote_Label As Label
    Friend WithEvents AMMOBindingSource As BindingSource
    Friend WithEvents AMMOTableAdapter As gdssDataSet1TableAdapters.AMMOTableAdapter
    Friend WithEvents size_Label As Label
    Friend WithEvents size_TextBox As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Year_NumericUpDown As NumericUpDown
End Class
