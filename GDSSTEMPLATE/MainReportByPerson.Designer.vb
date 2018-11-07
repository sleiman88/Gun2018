<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainReportByPerson
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
        Me.Button_ReportAmoo = New System.Windows.Forms.Button()
        Me.Button_ReportGun = New System.Windows.Forms.Button()
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
        Me.IDCARDTableAdapter = New GDSSTEMPLATE.gdssDataSet1TableAdapters.IDCARDTableAdapter()
        Me.N0itemsAndPerGUnBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.N0itemsAndPerGUnTableAdapter = New GDSSTEMPLATE.gdssDataSet1TableAdapters.N0itemsAndPerGUnTableAdapter()
        Me.GunReportInfoFormBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GunReportInfoFormTableAdapter = New GDSSTEMPLATE.gdssDataSet1TableAdapters.GunReportInfoFormTableAdapter()
        Me.AmmoReportInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AmmoReportInfoTableAdapter = New GDSSTEMPLATE.gdssDataSet1TableAdapters.AmmoReportInfoTableAdapter()
        Me.Panel2.SuspendLayout()
        CType(Me.IDCARDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GdssDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N0itemsAndPerGUnBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunReportInfoFormBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmmoReportInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Button_ReportAmoo)
        Me.Panel2.Controls.Add(Me.Button_ReportGun)
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
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(656, 181)
        Me.Panel2.TabIndex = 6
        '
        'Button_ReportAmoo
        '
        Me.Button_ReportAmoo.Location = New System.Drawing.Point(429, 153)
        Me.Button_ReportAmoo.Name = "Button_ReportAmoo"
        Me.Button_ReportAmoo.Size = New System.Drawing.Size(128, 23)
        Me.Button_ReportAmoo.TabIndex = 20
        Me.Button_ReportAmoo.Text = "Print Report Ammo"
        Me.Button_ReportAmoo.UseVisualStyleBackColor = True
        '
        'Button_ReportGun
        '
        Me.Button_ReportGun.Location = New System.Drawing.Point(287, 153)
        Me.Button_ReportGun.Name = "Button_ReportGun"
        Me.Button_ReportGun.Size = New System.Drawing.Size(118, 23)
        Me.Button_ReportGun.TabIndex = 19
        Me.Button_ReportGun.Text = "Print Report Guns"
        Me.Button_ReportGun.UseVisualStyleBackColor = True
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
        Me.ComboBoxPersons.Location = New System.Drawing.Point(99, 19)
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
        Me.TextBoxMilitNb.Location = New System.Drawing.Point(306, 20)
        Me.TextBoxMilitNb.Name = "TextBoxMilitNb"
        Me.TextBoxMilitNb.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxMilitNb.TabIndex = 0
        '
        'IDCARDTableAdapter
        '
        Me.IDCARDTableAdapter.ClearBeforeFill = True
        '
        'N0itemsAndPerGUnBindingSource
        '
        Me.N0itemsAndPerGUnBindingSource.DataMember = "N0itemsAndPerGUn"
        Me.N0itemsAndPerGUnBindingSource.DataSource = Me.GdssDataSet1
        '
        'N0itemsAndPerGUnTableAdapter
        '
        Me.N0itemsAndPerGUnTableAdapter.ClearBeforeFill = True
        '
        'GunReportInfoFormBindingSource
        '
        Me.GunReportInfoFormBindingSource.DataMember = "GunReportInfoForm"
        Me.GunReportInfoFormBindingSource.DataSource = Me.GdssDataSet1
        '
        'GunReportInfoFormTableAdapter
        '
        Me.GunReportInfoFormTableAdapter.ClearBeforeFill = True
        '
        'AmmoReportInfoBindingSource
        '
        Me.AmmoReportInfoBindingSource.DataMember = "AmmoReportInfo"
        Me.AmmoReportInfoBindingSource.DataSource = Me.GdssDataSet1
        '
        'AmmoReportInfoTableAdapter
        '
        Me.AmmoReportInfoTableAdapter.ClearBeforeFill = True
        '
        'MainReportByPerson
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 220)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.Name = "MainReportByPerson"
        Me.Text = "MainReportByPerson"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.IDCARDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GdssDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N0itemsAndPerGUnBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunReportInfoFormBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmmoReportInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
    Friend WithEvents GdssDataSet1 As gdssDataSet1
    Friend WithEvents IDCARDBindingSource As BindingSource
    Friend WithEvents IDCARDTableAdapter As gdssDataSet1TableAdapters.IDCARDTableAdapter
    Friend WithEvents N0itemsAndPerGUnBindingSource As BindingSource
    Friend WithEvents N0itemsAndPerGUnTableAdapter As gdssDataSet1TableAdapters.N0itemsAndPerGUnTableAdapter
    Friend WithEvents Button_ReportAmoo As Button
    Friend WithEvents Button_ReportGun As Button
    Friend WithEvents GunReportInfoFormBindingSource As BindingSource
    Friend WithEvents GunReportInfoFormTableAdapter As gdssDataSet1TableAdapters.GunReportInfoFormTableAdapter
    Friend WithEvents AmmoReportInfoBindingSource As BindingSource
    Friend WithEvents AmmoReportInfoTableAdapter As gdssDataSet1TableAdapters.AmmoReportInfoTableAdapter
End Class
