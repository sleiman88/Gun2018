Imports GDSSTEMPLATE.gdssDataSet1TableAdapters

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GiveGun
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
        Me.TextBox_NameGun = New System.Windows.Forms.TextBox()
        Me.Button_Search = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.N0ITEMSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GdssDataSet1 = New GDSSTEMPLATE.gdssDataSet1()
        Me.N0ITEMSTableAdapter = New GDSSTEMPLATE.gdssDataSet1TableAdapters.N0ITEMSTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GAMMO_TextBox = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.gunSize_Label = New System.Windows.Forms.Label()
        Me.GunStore_Label = New System.Windows.Forms.Label()
        Me.Confirm_Label = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GunLabel_Label = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.WithCleaner_CheckBox = New System.Windows.Forms.CheckBox()
        Me.GunSize_TextBox = New System.Windows.Forms.TextBox()
        Me.GunStore_TextBox = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.gunNbConfirm_TextBox = New System.Windows.Forms.TextBox()
        Me.GunNb_TextBox = New System.Windows.Forms.TextBox()
        Me.GunType_TextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LName_CheckBox = New System.Windows.Forms.CheckBox()
        Me.FATHER_CheckBox = New System.Windows.Forms.CheckBox()
        Me.FName_CheckBox = New System.Windows.Forms.CheckBox()
        Me.TextBoxLName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_FATHER = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxPersons = New System.Windows.Forms.ComboBox()
        Me.IDCARDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_FName = New System.Windows.Forms.TextBox()
        Me.TextBoxMilitNb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IDCARDTableAdapter = New GDSSTEMPLATE.gdssDataSet1TableAdapters.IDCARDTableAdapter()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PergunTableAdapter1 = New GDSSTEMPLATE.gdssDataSet1TableAdapters.PERGUNTableAdapter()
        Me.GAMMO_Label = New System.Windows.Forms.Label()
        Me.Supplier = New System.Windows.Forms.Label()
        Me.Note_TextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Save_Button = New System.Windows.Forms.Button()
        CType(Me.N0ITEMSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GdssDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.IDCARDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox_NameGun
        '
        Me.TextBox_NameGun.Location = New System.Drawing.Point(3, 16)
        Me.TextBox_NameGun.Name = "TextBox_NameGun"
        Me.TextBox_NameGun.Size = New System.Drawing.Size(197, 20)
        Me.TextBox_NameGun.TabIndex = 0
        '
        'Button_Search
        '
        Me.Button_Search.Location = New System.Drawing.Point(206, 14)
        Me.Button_Search.Name = "Button_Search"
        Me.Button_Search.Size = New System.Drawing.Size(97, 23)
        Me.Button_Search.TabIndex = 1
        Me.Button_Search.Text = "Search"
        Me.Button_Search.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.N0ITEMSBindingSource
        Me.ComboBox1.DisplayMember = "LABEL"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(309, 16)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(201, 21)
        Me.ComboBox1.TabIndex = 2
        Me.ComboBox1.ValueMember = "ITEM"
        '
        'N0ITEMSBindingSource
        '
        Me.N0ITEMSBindingSource.DataMember = "N0ITEMS"
        Me.N0ITEMSBindingSource.DataSource = Me.GdssDataSet1
        '
        'GdssDataSet1
        '
        Me.GdssDataSet1.DataSetName = "gdssDataSet1"
        Me.GdssDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'N0ITEMSTableAdapter
        '
        Me.N0ITEMSTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GAMMO_Label)
        Me.Panel1.Controls.Add(Me.GAMMO_TextBox)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.gunSize_Label)
        Me.Panel1.Controls.Add(Me.GunStore_Label)
        Me.Panel1.Controls.Add(Me.Confirm_Label)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.GunLabel_Label)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.WithCleaner_CheckBox)
        Me.Panel1.Controls.Add(Me.GunSize_TextBox)
        Me.Panel1.Controls.Add(Me.GunStore_TextBox)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.gunNbConfirm_TextBox)
        Me.Panel1.Controls.Add(Me.GunNb_TextBox)
        Me.Panel1.Controls.Add(Me.GunType_TextBox)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.TextBox_NameGun)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Button_Search)
        Me.Panel1.Location = New System.Drawing.Point(12, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(691, 364)
        Me.Panel1.TabIndex = 3
        '
        'GAMMO_TextBox
        '
        Me.GAMMO_TextBox.Location = New System.Drawing.Point(88, 243)
        Me.GAMMO_TextBox.Name = "GAMMO_TextBox"
        Me.GAMMO_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.GAMMO_TextBox.TabIndex = 21
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(1, 243)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(58, 13)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "Gun Ammo"
        '
        'gunSize_Label
        '
        Me.gunSize_Label.AutoSize = True
        Me.gunSize_Label.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gunSize_Label.ForeColor = System.Drawing.Color.OrangeRed
        Me.gunSize_Label.Location = New System.Drawing.Point(162, 185)
        Me.gunSize_Label.Name = "gunSize_Label"
        Me.gunSize_Label.Size = New System.Drawing.Size(18, 19)
        Me.gunSize_Label.TabIndex = 19
        Me.gunSize_Label.Text = "*"
        Me.gunSize_Label.Visible = False
        '
        'GunStore_Label
        '
        Me.GunStore_Label.AutoSize = True
        Me.GunStore_Label.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunStore_Label.ForeColor = System.Drawing.Color.OrangeRed
        Me.GunStore_Label.Location = New System.Drawing.Point(162, 157)
        Me.GunStore_Label.Name = "GunStore_Label"
        Me.GunStore_Label.Size = New System.Drawing.Size(18, 19)
        Me.GunStore_Label.TabIndex = 18
        Me.GunStore_Label.Text = "*"
        Me.GunStore_Label.Visible = False
        '
        'Confirm_Label
        '
        Me.Confirm_Label.AutoSize = True
        Me.Confirm_Label.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Confirm_Label.ForeColor = System.Drawing.Color.OrangeRed
        Me.Confirm_Label.Location = New System.Drawing.Point(302, 117)
        Me.Confirm_Label.Name = "Confirm_Label"
        Me.Confirm_Label.Size = New System.Drawing.Size(18, 19)
        Me.Confirm_Label.TabIndex = 17
        Me.Confirm_Label.Text = "*"
        Me.Confirm_Label.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(-3, 122)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 13)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Confirme Number"
        '
        'GunLabel_Label
        '
        Me.GunLabel_Label.AutoSize = True
        Me.GunLabel_Label.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunLabel_Label.ForeColor = System.Drawing.Color.OrangeRed
        Me.GunLabel_Label.Location = New System.Drawing.Point(302, 49)
        Me.GunLabel_Label.Name = "GunLabel_Label"
        Me.GunLabel_Label.Size = New System.Drawing.Size(18, 19)
        Me.GunLabel_Label.TabIndex = 15
        Me.GunLabel_Label.Text = "*"
        Me.GunLabel_Label.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(1, 214)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "With Cleaner"
        '
        'WithCleaner_CheckBox
        '
        Me.WithCleaner_CheckBox.AutoSize = True
        Me.WithCleaner_CheckBox.Location = New System.Drawing.Point(88, 214)
        Me.WithCleaner_CheckBox.Name = "WithCleaner_CheckBox"
        Me.WithCleaner_CheckBox.Size = New System.Drawing.Size(15, 14)
        Me.WithCleaner_CheckBox.TabIndex = 13
        Me.WithCleaner_CheckBox.UseVisualStyleBackColor = True
        '
        'GunSize_TextBox
        '
        Me.GunSize_TextBox.Location = New System.Drawing.Point(88, 184)
        Me.GunSize_TextBox.MaxLength = 10
        Me.GunSize_TextBox.Name = "GunSize_TextBox"
        Me.GunSize_TextBox.Size = New System.Drawing.Size(59, 20)
        Me.GunSize_TextBox.TabIndex = 12
        '
        'GunStore_TextBox
        '
        Me.GunStore_TextBox.Location = New System.Drawing.Point(88, 156)
        Me.GunStore_TextBox.MaxLength = 20
        Me.GunStore_TextBox.Name = "GunStore_TextBox"
        Me.GunStore_TextBox.Size = New System.Drawing.Size(59, 20)
        Me.GunStore_TextBox.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(2, 184)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 13)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Gun Size"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 156)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Gun Store"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(4, 86)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Gun Number"
        '
        'gunNbConfirm_TextBox
        '
        Me.gunNbConfirm_TextBox.Location = New System.Drawing.Point(88, 116)
        Me.gunNbConfirm_TextBox.Name = "gunNbConfirm_TextBox"
        Me.gunNbConfirm_TextBox.Size = New System.Drawing.Size(208, 20)
        Me.gunNbConfirm_TextBox.TabIndex = 6
        '
        'GunNb_TextBox
        '
        Me.GunNb_TextBox.Location = New System.Drawing.Point(88, 80)
        Me.GunNb_TextBox.Name = "GunNb_TextBox"
        Me.GunNb_TextBox.Size = New System.Drawing.Size(208, 20)
        Me.GunNb_TextBox.TabIndex = 5
        '
        'GunType_TextBox
        '
        Me.GunType_TextBox.Location = New System.Drawing.Point(88, 48)
        Me.GunType_TextBox.Name = "GunType_TextBox"
        Me.GunType_TextBox.Size = New System.Drawing.Size(208, 20)
        Me.GunType_TextBox.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Gun Type"
        '
        'Panel2
        '
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
        Me.Panel2.Location = New System.Drawing.Point(12, 452)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(521, 181)
        Me.Panel2.TabIndex = 4
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
        Me.ComboBoxPersons.FormattingEnabled = True
        Me.ComboBoxPersons.Location = New System.Drawing.Point(306, 16)
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
        Me.TextBoxMilitNb.Location = New System.Drawing.Point(96, 19)
        Me.TextBoxMilitNb.Name = "TextBoxMilitNb"
        Me.TextBoxMilitNb.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxMilitNb.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Guns"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 419)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Person"
        '
        'IDCARDTableAdapter
        '
        Me.IDCARDTableAdapter.ClearBeforeFill = True
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(709, 36)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(512, 135)
        Me.Panel3.TabIndex = 7
        '
        'PergunTableAdapter1
        '
        Me.PergunTableAdapter1.ClearBeforeFill = True
        '
        'GAMMO_Label
        '
        Me.GAMMO_Label.AutoSize = True
        Me.GAMMO_Label.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GAMMO_Label.ForeColor = System.Drawing.Color.OrangeRed
        Me.GAMMO_Label.Location = New System.Drawing.Point(194, 244)
        Me.GAMMO_Label.Name = "GAMMO_Label"
        Me.GAMMO_Label.Size = New System.Drawing.Size(18, 19)
        Me.GAMMO_Label.TabIndex = 22
        Me.GAMMO_Label.Text = "*"
        Me.GAMMO_Label.Visible = False
        '
        'Supplier
        '
        Me.Supplier.AutoSize = True
        Me.Supplier.Location = New System.Drawing.Point(709, 17)
        Me.Supplier.Name = "Supplier"
        Me.Supplier.Size = New System.Drawing.Size(45, 13)
        Me.Supplier.TabIndex = 8
        Me.Supplier.Text = "Supplier"
        '
        'Note_TextBox
        '
        Me.Note_TextBox.Location = New System.Drawing.Point(776, 488)
        Me.Note_TextBox.Multiline = True
        Me.Note_TextBox.Name = "Note_TextBox"
        Me.Note_TextBox.Size = New System.Drawing.Size(401, 127)
        Me.Note_TextBox.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(776, 468)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Note"
        '
        'Save_Button
        '
        Me.Save_Button.Location = New System.Drawing.Point(1120, 643)
        Me.Save_Button.Name = "Save_Button"
        Me.Save_Button.Size = New System.Drawing.Size(75, 23)
        Me.Save_Button.TabIndex = 11
        Me.Save_Button.Text = "Save"
        Me.Save_Button.UseVisualStyleBackColor = True
        '
        'GiveGun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1233, 684)
        Me.Controls.Add(Me.Save_Button)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Note_TextBox)
        Me.Controls.Add(Me.Supplier)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "GiveGun"
        Me.Text = "  "
        CType(Me.N0ITEMSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GdssDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.IDCARDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_NameGun As TextBox
    Friend WithEvents Button_Search As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GdssDataSet1 As gdssDataSet1
    Friend WithEvents N0ITEMSBindingSource As BindingSource
    Friend WithEvents N0ITEMSTableAdapter As gdssDataSet1TableAdapters.N0ITEMSTableAdapter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ComboBoxPersons As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_FName As TextBox
    Friend WithEvents TextBoxMilitNb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents IDCARDBindingSource As BindingSource
    Friend WithEvents IDCARDTableAdapter As gdssDataSet1TableAdapters.IDCARDTableAdapter
    Friend WithEvents TextBoxLName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox_FATHER As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LName_CheckBox As CheckBox
    Friend WithEvents FATHER_CheckBox As CheckBox
    Friend WithEvents FName_CheckBox As CheckBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents WithCleaner_CheckBox As CheckBox
    Friend WithEvents GunSize_TextBox As TextBox
    Friend WithEvents GunStore_TextBox As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents gunNbConfirm_TextBox As TextBox
    Friend WithEvents GunNb_TextBox As TextBox
    Friend WithEvents GunType_TextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GunLabel_Label As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Confirm_Label As Label
    Friend WithEvents PergunTableAdapter1 As PERGUNTableAdapter
    Friend WithEvents gunSize_Label As Label
    Friend WithEvents GunStore_Label As Label
    Friend WithEvents GAMMO_TextBox As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents GAMMO_Label As Label
    Friend WithEvents Supplier As Label
    Friend WithEvents Note_TextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Save_Button As Button
End Class
