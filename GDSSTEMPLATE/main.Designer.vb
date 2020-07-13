<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GiveGunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GiveAmmoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ByPersonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchGunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SearchGun_Button = New System.Windows.Forms.Button()
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
        Me.Gun_DataGridView = New System.Windows.Forms.DataGridView()
        Me.LABELDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N0itemsAndPerGUnBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ammo_DataGridView = New System.Windows.Forms.DataGridView()
        Me.AMMOTRANSACTIONPKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YEARDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QUANTITYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AMMODataGridBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.N0itemsAndPerGUnTableAdapter = New GDSSTEMPLATE.gdssDataSet1TableAdapters.N0itemsAndPerGUnTableAdapter()
        Me.AMMODataGridTableAdapter = New GDSSTEMPLATE.gdssDataSet1TableAdapters.AMMODataGridTableAdapter()
        Me.GiveGun_Button = New System.Windows.Forms.Button()
        Me.GiveAmmo_Button = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.IDCARDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GdssDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gun_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N0itemsAndPerGUnBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ammo_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AMMODataGridBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1287, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GiveGunToolStripMenuItem, Me.GiveAmmoToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.SearchGunToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'GiveGunToolStripMenuItem
        '
        Me.GiveGunToolStripMenuItem.Name = "GiveGunToolStripMenuItem"
        Me.GiveGunToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GiveGunToolStripMenuItem.Text = "Give Gun"
        '
        'GiveAmmoToolStripMenuItem
        '
        Me.GiveAmmoToolStripMenuItem.Name = "GiveAmmoToolStripMenuItem"
        Me.GiveAmmoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GiveAmmoToolStripMenuItem.Text = "Give ammo"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ByPersonToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'ByPersonToolStripMenuItem
        '
        Me.ByPersonToolStripMenuItem.Name = "ByPersonToolStripMenuItem"
        Me.ByPersonToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ByPersonToolStripMenuItem.Text = "By Person"
        '
        'SearchGunToolStripMenuItem
        '
        Me.SearchGunToolStripMenuItem.Name = "SearchGunToolStripMenuItem"
        Me.SearchGunToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SearchGunToolStripMenuItem.Text = "Search Gun"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.SearchGun_Button)
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
        Me.Panel2.Location = New System.Drawing.Point(12, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(656, 181)
        Me.Panel2.TabIndex = 5
        '
        'SearchGun_Button
        '
        Me.SearchGun_Button.Location = New System.Drawing.Point(477, 141)
        Me.SearchGun_Button.Name = "SearchGun_Button"
        Me.SearchGun_Button.Size = New System.Drawing.Size(160, 23)
        Me.SearchGun_Button.TabIndex = 18
        Me.SearchGun_Button.Text = "Search Guns and Ammo"
        Me.SearchGun_Button.UseVisualStyleBackColor = True
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
        'Gun_DataGridView
        '
        Me.Gun_DataGridView.AllowUserToAddRows = False
        Me.Gun_DataGridView.AllowUserToDeleteRows = False
        Me.Gun_DataGridView.AutoGenerateColumns = False
        Me.Gun_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Gun_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LABELDataGridViewTextBoxColumn, Me.CODEDataGridViewTextBoxColumn, Me.SDATEDataGridViewTextBoxColumn})
        Me.Gun_DataGridView.DataSource = Me.N0itemsAndPerGUnBindingSource
        Me.Gun_DataGridView.Location = New System.Drawing.Point(683, 46)
        Me.Gun_DataGridView.Name = "Gun_DataGridView"
        Me.Gun_DataGridView.ReadOnly = True
        Me.Gun_DataGridView.Size = New System.Drawing.Size(300, 368)
        Me.Gun_DataGridView.TabIndex = 6
        '
        'LABELDataGridViewTextBoxColumn
        '
        Me.LABELDataGridViewTextBoxColumn.DataPropertyName = "LABEL"
        Me.LABELDataGridViewTextBoxColumn.HeaderText = "Gun"
        Me.LABELDataGridViewTextBoxColumn.Name = "LABELDataGridViewTextBoxColumn"
        Me.LABELDataGridViewTextBoxColumn.ReadOnly = True
        Me.LABELDataGridViewTextBoxColumn.Width = 105
        '
        'CODEDataGridViewTextBoxColumn
        '
        Me.CODEDataGridViewTextBoxColumn.DataPropertyName = "CODE"
        Me.CODEDataGridViewTextBoxColumn.HeaderText = "CODE"
        Me.CODEDataGridViewTextBoxColumn.Name = "CODEDataGridViewTextBoxColumn"
        Me.CODEDataGridViewTextBoxColumn.ReadOnly = True
        Me.CODEDataGridViewTextBoxColumn.Visible = False
        '
        'SDATEDataGridViewTextBoxColumn
        '
        Me.SDATEDataGridViewTextBoxColumn.DataPropertyName = "SDATE"
        Me.SDATEDataGridViewTextBoxColumn.HeaderText = "Delivery Date"
        Me.SDATEDataGridViewTextBoxColumn.Name = "SDATEDataGridViewTextBoxColumn"
        Me.SDATEDataGridViewTextBoxColumn.ReadOnly = True
        Me.SDATEDataGridViewTextBoxColumn.Width = 150
        '
        'N0itemsAndPerGUnBindingSource
        '
        Me.N0itemsAndPerGUnBindingSource.DataMember = "N0itemsAndPerGUn"
        Me.N0itemsAndPerGUnBindingSource.DataSource = Me.GdssDataSet1
        '
        'Ammo_DataGridView
        '
        Me.Ammo_DataGridView.AllowUserToAddRows = False
        Me.Ammo_DataGridView.AllowUserToDeleteRows = False
        Me.Ammo_DataGridView.AutoGenerateColumns = False
        Me.Ammo_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Ammo_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AMMOTRANSACTIONPKDataGridViewTextBoxColumn, Me.YEARDataGridViewTextBoxColumn, Me.QUANTITYDataGridViewTextBoxColumn})
        Me.Ammo_DataGridView.DataSource = Me.AMMODataGridBindingSource
        Me.Ammo_DataGridView.Location = New System.Drawing.Point(989, 46)
        Me.Ammo_DataGridView.Name = "Ammo_DataGridView"
        Me.Ammo_DataGridView.ReadOnly = True
        Me.Ammo_DataGridView.Size = New System.Drawing.Size(286, 368)
        Me.Ammo_DataGridView.TabIndex = 7
        '
        'AMMOTRANSACTIONPKDataGridViewTextBoxColumn
        '
        Me.AMMOTRANSACTIONPKDataGridViewTextBoxColumn.DataPropertyName = "AMMOTRANSACTION_PK"
        Me.AMMOTRANSACTIONPKDataGridViewTextBoxColumn.HeaderText = "AMMOTRANSACTION_PK"
        Me.AMMOTRANSACTIONPKDataGridViewTextBoxColumn.Name = "AMMOTRANSACTIONPKDataGridViewTextBoxColumn"
        Me.AMMOTRANSACTIONPKDataGridViewTextBoxColumn.ReadOnly = True
        Me.AMMOTRANSACTIONPKDataGridViewTextBoxColumn.Visible = False
        '
        'YEARDataGridViewTextBoxColumn
        '
        Me.YEARDataGridViewTextBoxColumn.DataPropertyName = "YEAR"
        Me.YEARDataGridViewTextBoxColumn.HeaderText = "YEAR"
        Me.YEARDataGridViewTextBoxColumn.Name = "YEARDataGridViewTextBoxColumn"
        Me.YEARDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QUANTITYDataGridViewTextBoxColumn
        '
        Me.QUANTITYDataGridViewTextBoxColumn.DataPropertyName = "QUANTITY"
        Me.QUANTITYDataGridViewTextBoxColumn.HeaderText = "QUANTITY"
        Me.QUANTITYDataGridViewTextBoxColumn.Name = "QUANTITYDataGridViewTextBoxColumn"
        Me.QUANTITYDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AMMODataGridBindingSource
        '
        Me.AMMODataGridBindingSource.DataMember = "AMMODataGrid"
        Me.AMMODataGridBindingSource.DataSource = Me.GdssDataSet1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(680, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Guns"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(986, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Ammo"
        '
        'N0itemsAndPerGUnTableAdapter
        '
        Me.N0itemsAndPerGUnTableAdapter.ClearBeforeFill = True
        '
        'AMMODataGridTableAdapter
        '
        Me.AMMODataGridTableAdapter.ClearBeforeFill = True
        '
        'GiveGun_Button
        '
        Me.GiveGun_Button.Location = New System.Drawing.Point(561, 288)
        Me.GiveGun_Button.Name = "GiveGun_Button"
        Me.GiveGun_Button.Size = New System.Drawing.Size(75, 23)
        Me.GiveGun_Button.TabIndex = 19
        Me.GiveGun_Button.Text = "Give Gun"
        Me.GiveGun_Button.UseVisualStyleBackColor = True
        '
        'GiveAmmo_Button
        '
        Me.GiveAmmo_Button.Location = New System.Drawing.Point(561, 317)
        Me.GiveAmmo_Button.Name = "GiveAmmo_Button"
        Me.GiveAmmo_Button.Size = New System.Drawing.Size(75, 23)
        Me.GiveAmmo_Button.TabIndex = 20
        Me.GiveAmmo_Button.Text = "Give Ammo"
        Me.GiveAmmo_Button.UseVisualStyleBackColor = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1287, 431)
        Me.Controls.Add(Me.GiveAmmo_Button)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GiveGun_Button)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Ammo_DataGridView)
        Me.Controls.Add(Me.Gun_DataGridView)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.IDCARDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GdssDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gun_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N0itemsAndPerGUnBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ammo_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AMMODataGridBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GiveGunToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GiveAmmoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ByPersonToolStripMenuItem As ToolStripMenuItem
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
    Friend WithEvents SearchGun_Button As Button
    Friend WithEvents Gun_DataGridView As DataGridView
    Friend WithEvents Ammo_DataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents N0itemsAndPerGUnBindingSource As BindingSource
    Friend WithEvents N0itemsAndPerGUnTableAdapter As gdssDataSet1TableAdapters.N0itemsAndPerGUnTableAdapter
    Friend WithEvents LABELDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CODEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SDATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AMMODataGridBindingSource As BindingSource
    Friend WithEvents AMMODataGridTableAdapter As gdssDataSet1TableAdapters.AMMODataGridTableAdapter
    Friend WithEvents AMMOTRANSACTIONPKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YEARDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QUANTITYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GiveGun_Button As Button
    Friend WithEvents GiveAmmo_Button As Button
    Friend WithEvents SearchGunToolStripMenuItem As ToolStripMenuItem
End Class
