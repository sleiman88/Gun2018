<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AmmoInfo
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
        Dim AMMOTRANSACTION_PKLabel As System.Windows.Forms.Label
        Dim MILITARY_NBLabel As System.Windows.Forms.Label
        Dim YEARLabel As System.Windows.Forms.Label
        Dim QUANTITYLabel As System.Windows.Forms.Label
        Dim NBROF_DOCLabel As System.Windows.Forms.Label
        Dim DATEOF_DOCLabel As System.Windows.Forms.Label
        Dim IS_SPECIAL_ORDERLabel As System.Windows.Forms.Label
        Dim SIZE_AMMOLabel As System.Windows.Forms.Label
        Dim NOTELabel As System.Windows.Forms.Label
        Dim USER_APPLabel As System.Windows.Forms.Label
        Dim SYSTEM_DATELabel As System.Windows.Forms.Label
        Dim UPDATE_USERLabel As System.Windows.Forms.Label
        Dim UPDATE_DATELabel As System.Windows.Forms.Label
        Dim DBIRTHLabel As System.Windows.Forms.Label
        Dim PHONELabel As System.Windows.Forms.Label
        Dim FullNameLabel As System.Windows.Forms.Label
        Me.GdssDataSet1 = New GDSSTEMPLATE.gdssDataSet1()
        Me.AmmoReportInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AmmoReportInfoTableAdapter = New GDSSTEMPLATE.gdssDataSet1TableAdapters.AmmoReportInfoTableAdapter()
        Me.TableAdapterManager = New GDSSTEMPLATE.gdssDataSet1TableAdapters.TableAdapterManager()
        Me.AMMOTRANSACTION_PKTextBox = New System.Windows.Forms.TextBox()
        Me.MILITARY_NBTextBox = New System.Windows.Forms.TextBox()
        Me.YEARTextBox = New System.Windows.Forms.TextBox()
        Me.QUANTITYTextBox = New System.Windows.Forms.TextBox()
        Me.NBROF_DOCTextBox = New System.Windows.Forms.TextBox()
        Me.SPECIAL_NOTETextBox = New System.Windows.Forms.TextBox()
        Me.SIZE_AMMOTextBox = New System.Windows.Forms.TextBox()
        Me.NOTETextBox = New System.Windows.Forms.TextBox()
        Me.USER_APPTextBox = New System.Windows.Forms.TextBox()
        Me.UPDATE_USERTextBox = New System.Windows.Forms.TextBox()
        Me.PHONETextBox = New System.Windows.Forms.TextBox()
        Me.FullNameTextBox = New System.Windows.Forms.TextBox()
        Me.UpdateDate_TextBox = New System.Windows.Forms.TextBox()
        Me.SystemDate_TextBox = New System.Windows.Forms.TextBox()
        Me.DateOfBirth_TextBox = New System.Windows.Forms.TextBox()
        Me.DateOfDocument_TextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SpecialOrder_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Button_Print = New System.Windows.Forms.Button()
        AMMOTRANSACTION_PKLabel = New System.Windows.Forms.Label()
        MILITARY_NBLabel = New System.Windows.Forms.Label()
        YEARLabel = New System.Windows.Forms.Label()
        QUANTITYLabel = New System.Windows.Forms.Label()
        NBROF_DOCLabel = New System.Windows.Forms.Label()
        DATEOF_DOCLabel = New System.Windows.Forms.Label()
        IS_SPECIAL_ORDERLabel = New System.Windows.Forms.Label()
        SIZE_AMMOLabel = New System.Windows.Forms.Label()
        NOTELabel = New System.Windows.Forms.Label()
        USER_APPLabel = New System.Windows.Forms.Label()
        SYSTEM_DATELabel = New System.Windows.Forms.Label()
        UPDATE_USERLabel = New System.Windows.Forms.Label()
        UPDATE_DATELabel = New System.Windows.Forms.Label()
        DBIRTHLabel = New System.Windows.Forms.Label()
        PHONELabel = New System.Windows.Forms.Label()
        FullNameLabel = New System.Windows.Forms.Label()
        CType(Me.GdssDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmmoReportInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'AMMOTRANSACTION_PKLabel
        '
        AMMOTRANSACTION_PKLabel.AutoSize = True
        AMMOTRANSACTION_PKLabel.Enabled = False
        AMMOTRANSACTION_PKLabel.Location = New System.Drawing.Point(58, 485)
        AMMOTRANSACTION_PKLabel.Name = "AMMOTRANSACTION_PKLabel"
        AMMOTRANSACTION_PKLabel.Size = New System.Drawing.Size(129, 13)
        AMMOTRANSACTION_PKLabel.TabIndex = 1
        AMMOTRANSACTION_PKLabel.Text = "AMMOTRANSACTION PK:"
        AMMOTRANSACTION_PKLabel.Visible = False
        '
        'MILITARY_NBLabel
        '
        MILITARY_NBLabel.AutoSize = True
        MILITARY_NBLabel.Location = New System.Drawing.Point(5, 36)
        MILITARY_NBLabel.Name = "MILITARY_NBLabel"
        MILITARY_NBLabel.Size = New System.Drawing.Size(74, 13)
        MILITARY_NBLabel.TabIndex = 3
        MILITARY_NBLabel.Text = "MILITARY NB:"
        '
        'YEARLabel
        '
        YEARLabel.AutoSize = True
        YEARLabel.Location = New System.Drawing.Point(4, 6)
        YEARLabel.Name = "YEARLabel"
        YEARLabel.Size = New System.Drawing.Size(37, 13)
        YEARLabel.TabIndex = 5
        YEARLabel.Text = "YEAR:"
        '
        'QUANTITYLabel
        '
        QUANTITYLabel.AutoSize = True
        QUANTITYLabel.Location = New System.Drawing.Point(4, 43)
        QUANTITYLabel.Name = "QUANTITYLabel"
        QUANTITYLabel.Size = New System.Drawing.Size(62, 13)
        QUANTITYLabel.TabIndex = 7
        QUANTITYLabel.Text = "QUANTITY:"
        '
        'NBROF_DOCLabel
        '
        NBROF_DOCLabel.AutoSize = True
        NBROF_DOCLabel.Location = New System.Drawing.Point(5, 9)
        NBROF_DOCLabel.Name = "NBROF_DOCLabel"
        NBROF_DOCLabel.Size = New System.Drawing.Size(70, 13)
        NBROF_DOCLabel.TabIndex = 9
        NBROF_DOCLabel.Text = "NBROF DOC:"
        '
        'DATEOF_DOCLabel
        '
        DATEOF_DOCLabel.AutoSize = True
        DATEOF_DOCLabel.Location = New System.Drawing.Point(3, 32)
        DATEOF_DOCLabel.Name = "DATEOF_DOCLabel"
        DATEOF_DOCLabel.Size = New System.Drawing.Size(76, 13)
        DATEOF_DOCLabel.TabIndex = 11
        DATEOF_DOCLabel.Text = "DATEOF DOC:"
        '
        'IS_SPECIAL_ORDERLabel
        '
        IS_SPECIAL_ORDERLabel.AutoSize = True
        IS_SPECIAL_ORDERLabel.Location = New System.Drawing.Point(9, 356)
        IS_SPECIAL_ORDERLabel.Name = "IS_SPECIAL_ORDERLabel"
        IS_SPECIAL_ORDERLabel.Size = New System.Drawing.Size(103, 13)
        IS_SPECIAL_ORDERLabel.TabIndex = 13
        IS_SPECIAL_ORDERLabel.Text = "IS SPECIAL ORDER:"
        '
        'SIZE_AMMOLabel
        '
        SIZE_AMMOLabel.AutoSize = True
        SIZE_AMMOLabel.Location = New System.Drawing.Point(4, 80)
        SIZE_AMMOLabel.Name = "SIZE_AMMOLabel"
        SIZE_AMMOLabel.Size = New System.Drawing.Size(67, 13)
        SIZE_AMMOLabel.TabIndex = 17
        SIZE_AMMOLabel.Text = "SIZE AMMO:"
        '
        'NOTELabel
        '
        NOTELabel.AutoSize = True
        NOTELabel.Location = New System.Drawing.Point(390, 252)
        NOTELabel.Name = "NOTELabel"
        NOTELabel.Size = New System.Drawing.Size(38, 13)
        NOTELabel.TabIndex = 19
        NOTELabel.Text = "NOTE:"
        '
        'USER_APPLabel
        '
        USER_APPLabel.AutoSize = True
        USER_APPLabel.Location = New System.Drawing.Point(3, 7)
        USER_APPLabel.Name = "USER_APPLabel"
        USER_APPLabel.Size = New System.Drawing.Size(84, 13)
        USER_APPLabel.TabIndex = 21
        USER_APPLabel.Text = "Data Entry User"
        '
        'SYSTEM_DATELabel
        '
        SYSTEM_DATELabel.AutoSize = True
        SYSTEM_DATELabel.Location = New System.Drawing.Point(3, 34)
        SYSTEM_DATELabel.Name = "SYSTEM_DATELabel"
        SYSTEM_DATELabel.Size = New System.Drawing.Size(84, 13)
        SYSTEM_DATELabel.TabIndex = 23
        SYSTEM_DATELabel.Text = "Data Entry date"
        '
        'UPDATE_USERLabel
        '
        UPDATE_USERLabel.AutoSize = True
        UPDATE_USERLabel.Location = New System.Drawing.Point(5, 6)
        UPDATE_USERLabel.Name = "UPDATE_USERLabel"
        UPDATE_USERLabel.Size = New System.Drawing.Size(79, 13)
        UPDATE_USERLabel.TabIndex = 25
        UPDATE_USERLabel.Text = "UPDATE USER:"
        '
        'UPDATE_DATELabel
        '
        UPDATE_DATELabel.AutoSize = True
        UPDATE_DATELabel.Location = New System.Drawing.Point(5, 33)
        UPDATE_DATELabel.Name = "UPDATE_DATELabel"
        UPDATE_DATELabel.Size = New System.Drawing.Size(79, 13)
        UPDATE_DATELabel.TabIndex = 27
        UPDATE_DATELabel.Text = "UPDATE DATE:"
        '
        'DBIRTHLabel
        '
        DBIRTHLabel.AutoSize = True
        DBIRTHLabel.Location = New System.Drawing.Point(5, 91)
        DBIRTHLabel.Name = "DBIRTHLabel"
        DBIRTHLabel.Size = New System.Drawing.Size(68, 13)
        DBIRTHLabel.TabIndex = 35
        DBIRTHLabel.Text = "Date of Birth"
        '
        'PHONELabel
        '
        PHONELabel.AutoSize = True
        PHONELabel.Location = New System.Drawing.Point(5, 62)
        PHONELabel.Name = "PHONELabel"
        PHONELabel.Size = New System.Drawing.Size(45, 13)
        PHONELabel.TabIndex = 37
        PHONELabel.Text = "PHONE:"
        '
        'FullNameLabel
        '
        FullNameLabel.AutoSize = True
        FullNameLabel.Location = New System.Drawing.Point(5, 6)
        FullNameLabel.Name = "FullNameLabel"
        FullNameLabel.Size = New System.Drawing.Size(57, 13)
        FullNameLabel.TabIndex = 41
        FullNameLabel.Text = "Full Name:"
        '
        'GdssDataSet1
        '
        Me.GdssDataSet1.DataSetName = "gdssDataSet1"
        Me.GdssDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.AMMOTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.N0ITEMSTableAdapter = Nothing
        Me.TableAdapterManager.PERGUNTableAdapterTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GDSSTEMPLATE.gdssDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AMMOTRANSACTION_PKTextBox
        '
        Me.AMMOTRANSACTION_PKTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AmmoReportInfoBindingSource, "AMMOTRANSACTION_PK", True))
        Me.AMMOTRANSACTION_PKTextBox.Enabled = False
        Me.AMMOTRANSACTION_PKTextBox.Location = New System.Drawing.Point(193, 482)
        Me.AMMOTRANSACTION_PKTextBox.Name = "AMMOTRANSACTION_PKTextBox"
        Me.AMMOTRANSACTION_PKTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AMMOTRANSACTION_PKTextBox.TabIndex = 2
        Me.AMMOTRANSACTION_PKTextBox.Visible = False
        '
        'MILITARY_NBTextBox
        '
        Me.MILITARY_NBTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AmmoReportInfoBindingSource, "MILITARY_NB", True))
        Me.MILITARY_NBTextBox.Enabled = False
        Me.MILITARY_NBTextBox.Location = New System.Drawing.Point(140, 29)
        Me.MILITARY_NBTextBox.Name = "MILITARY_NBTextBox"
        Me.MILITARY_NBTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MILITARY_NBTextBox.TabIndex = 4
        '
        'YEARTextBox
        '
        Me.YEARTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AmmoReportInfoBindingSource, "YEAR", True))
        Me.YEARTextBox.Enabled = False
        Me.YEARTextBox.Location = New System.Drawing.Point(139, 3)
        Me.YEARTextBox.Name = "YEARTextBox"
        Me.YEARTextBox.Size = New System.Drawing.Size(200, 20)
        Me.YEARTextBox.TabIndex = 6
        '
        'QUANTITYTextBox
        '
        Me.QUANTITYTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AmmoReportInfoBindingSource, "QUANTITY", True))
        Me.QUANTITYTextBox.Enabled = False
        Me.QUANTITYTextBox.Location = New System.Drawing.Point(139, 36)
        Me.QUANTITYTextBox.Name = "QUANTITYTextBox"
        Me.QUANTITYTextBox.Size = New System.Drawing.Size(200, 20)
        Me.QUANTITYTextBox.TabIndex = 8
        '
        'NBROF_DOCTextBox
        '
        Me.NBROF_DOCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AmmoReportInfoBindingSource, "NBROF_DOC", True))
        Me.NBROF_DOCTextBox.Enabled = False
        Me.NBROF_DOCTextBox.Location = New System.Drawing.Point(140, 2)
        Me.NBROF_DOCTextBox.Name = "NBROF_DOCTextBox"
        Me.NBROF_DOCTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NBROF_DOCTextBox.TabIndex = 10
        '
        'SPECIAL_NOTETextBox
        '
        Me.SPECIAL_NOTETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AmmoReportInfoBindingSource, "SPECIAL_NOTE", True))
        Me.SPECIAL_NOTETextBox.Enabled = False
        Me.SPECIAL_NOTETextBox.Location = New System.Drawing.Point(12, 383)
        Me.SPECIAL_NOTETextBox.Multiline = True
        Me.SPECIAL_NOTETextBox.Name = "SPECIAL_NOTETextBox"
        Me.SPECIAL_NOTETextBox.Size = New System.Drawing.Size(728, 93)
        Me.SPECIAL_NOTETextBox.TabIndex = 16
        '
        'SIZE_AMMOTextBox
        '
        Me.SIZE_AMMOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AmmoReportInfoBindingSource, "SIZE_AMMO", True))
        Me.SIZE_AMMOTextBox.Enabled = False
        Me.SIZE_AMMOTextBox.Location = New System.Drawing.Point(139, 73)
        Me.SIZE_AMMOTextBox.Name = "SIZE_AMMOTextBox"
        Me.SIZE_AMMOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SIZE_AMMOTextBox.TabIndex = 18
        '
        'NOTETextBox
        '
        Me.NOTETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AmmoReportInfoBindingSource, "NOTE", True))
        Me.NOTETextBox.Enabled = False
        Me.NOTETextBox.Location = New System.Drawing.Point(389, 271)
        Me.NOTETextBox.Multiline = True
        Me.NOTETextBox.Name = "NOTETextBox"
        Me.NOTETextBox.Size = New System.Drawing.Size(351, 79)
        Me.NOTETextBox.TabIndex = 20
        '
        'USER_APPTextBox
        '
        Me.USER_APPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AmmoReportInfoBindingSource, "USER_APP", True))
        Me.USER_APPTextBox.Enabled = False
        Me.USER_APPTextBox.Location = New System.Drawing.Point(139, 8)
        Me.USER_APPTextBox.Name = "USER_APPTextBox"
        Me.USER_APPTextBox.Size = New System.Drawing.Size(200, 20)
        Me.USER_APPTextBox.TabIndex = 22
        '
        'UPDATE_USERTextBox
        '
        Me.UPDATE_USERTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AmmoReportInfoBindingSource, "UPDATE_USER", True))
        Me.UPDATE_USERTextBox.Enabled = False
        Me.UPDATE_USERTextBox.Location = New System.Drawing.Point(140, 3)
        Me.UPDATE_USERTextBox.Name = "UPDATE_USERTextBox"
        Me.UPDATE_USERTextBox.Size = New System.Drawing.Size(200, 20)
        Me.UPDATE_USERTextBox.TabIndex = 26
        '
        'PHONETextBox
        '
        Me.PHONETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AmmoReportInfoBindingSource, "PHONE", True))
        Me.PHONETextBox.Enabled = False
        Me.PHONETextBox.Location = New System.Drawing.Point(140, 55)
        Me.PHONETextBox.Name = "PHONETextBox"
        Me.PHONETextBox.Size = New System.Drawing.Size(200, 20)
        Me.PHONETextBox.TabIndex = 38
        '
        'FullNameTextBox
        '
        Me.FullNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AmmoReportInfoBindingSource, "FullName", True))
        Me.FullNameTextBox.Enabled = False
        Me.FullNameTextBox.Location = New System.Drawing.Point(140, 3)
        Me.FullNameTextBox.Name = "FullNameTextBox"
        Me.FullNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.FullNameTextBox.TabIndex = 42
        '
        'UpdateDate_TextBox
        '
        Me.UpdateDate_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AmmoReportInfoBindingSource, "UPDATE_DATE", True))
        Me.UpdateDate_TextBox.Enabled = False
        Me.UpdateDate_TextBox.Location = New System.Drawing.Point(140, 33)
        Me.UpdateDate_TextBox.Name = "UpdateDate_TextBox"
        Me.UpdateDate_TextBox.Size = New System.Drawing.Size(200, 20)
        Me.UpdateDate_TextBox.TabIndex = 43
        '
        'SystemDate_TextBox
        '
        Me.SystemDate_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AmmoReportInfoBindingSource, "SYSTEM_DATE", True))
        Me.SystemDate_TextBox.Enabled = False
        Me.SystemDate_TextBox.Location = New System.Drawing.Point(139, 34)
        Me.SystemDate_TextBox.Name = "SystemDate_TextBox"
        Me.SystemDate_TextBox.Size = New System.Drawing.Size(200, 20)
        Me.SystemDate_TextBox.TabIndex = 44
        '
        'DateOfBirth_TextBox
        '
        Me.DateOfBirth_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AmmoReportInfoBindingSource, "DBIRTH", True))
        Me.DateOfBirth_TextBox.Enabled = False
        Me.DateOfBirth_TextBox.Location = New System.Drawing.Point(140, 84)
        Me.DateOfBirth_TextBox.Name = "DateOfBirth_TextBox"
        Me.DateOfBirth_TextBox.Size = New System.Drawing.Size(200, 20)
        Me.DateOfBirth_TextBox.TabIndex = 45
        '
        'DateOfDocument_TextBox
        '
        Me.DateOfDocument_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AmmoReportInfoBindingSource, "DATEOF_DOC", True))
        Me.DateOfDocument_TextBox.Enabled = False
        Me.DateOfDocument_TextBox.Location = New System.Drawing.Point(140, 29)
        Me.DateOfDocument_TextBox.Name = "DateOfDocument_TextBox"
        Me.DateOfDocument_TextBox.Size = New System.Drawing.Size(200, 20)
        Me.DateOfDocument_TextBox.TabIndex = 46
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.FullNameTextBox)
        Me.Panel1.Controls.Add(FullNameLabel)
        Me.Panel1.Controls.Add(Me.DateOfBirth_TextBox)
        Me.Panel1.Controls.Add(Me.PHONETextBox)
        Me.Panel1.Controls.Add(PHONELabel)
        Me.Panel1.Controls.Add(DBIRTHLabel)
        Me.Panel1.Controls.Add(Me.MILITARY_NBTextBox)
        Me.Panel1.Controls.Add(MILITARY_NBLabel)
        Me.Panel1.Location = New System.Drawing.Point(12, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(347, 117)
        Me.Panel1.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Person"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.YEARTextBox)
        Me.Panel2.Controls.Add(Me.SIZE_AMMOTextBox)
        Me.Panel2.Controls.Add(SIZE_AMMOLabel)
        Me.Panel2.Controls.Add(Me.QUANTITYTextBox)
        Me.Panel2.Controls.Add(QUANTITYLabel)
        Me.Panel2.Controls.Add(YEARLabel)
        Me.Panel2.Location = New System.Drawing.Point(386, 27)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(354, 117)
        Me.Panel2.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(386, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Ammo"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DateOfDocument_TextBox)
        Me.Panel3.Controls.Add(DATEOF_DOCLabel)
        Me.Panel3.Controls.Add(NBROF_DOCLabel)
        Me.Panel3.Controls.Add(Me.NBROF_DOCTextBox)
        Me.Panel3.Location = New System.Drawing.Point(12, 175)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(347, 67)
        Me.Panel3.TabIndex = 51
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Document"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(SYSTEM_DATELabel)
        Me.Panel4.Controls.Add(Me.USER_APPTextBox)
        Me.Panel4.Controls.Add(USER_APPLabel)
        Me.Panel4.Controls.Add(Me.SystemDate_TextBox)
        Me.Panel4.Location = New System.Drawing.Point(386, 177)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(354, 65)
        Me.Panel4.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(386, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Operation"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.UPDATE_USERTextBox)
        Me.Panel5.Controls.Add(UPDATE_DATELabel)
        Me.Panel5.Controls.Add(UPDATE_USERLabel)
        Me.Panel5.Controls.Add(Me.UpdateDate_TextBox)
        Me.Panel5.Location = New System.Drawing.Point(12, 268)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(347, 72)
        Me.Panel5.TabIndex = 55
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Update"
        '
        'SpecialOrder_CheckBox
        '
        Me.SpecialOrder_CheckBox.AutoSize = True
        Me.SpecialOrder_CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.AmmoReportInfoBindingSource, "IS_SPECIAL_ORDER", True))
        Me.SpecialOrder_CheckBox.Location = New System.Drawing.Point(118, 355)
        Me.SpecialOrder_CheckBox.Name = "SpecialOrder_CheckBox"
        Me.SpecialOrder_CheckBox.Size = New System.Drawing.Size(15, 14)
        Me.SpecialOrder_CheckBox.TabIndex = 57
        Me.SpecialOrder_CheckBox.UseVisualStyleBackColor = True
        '
        'Button_Print
        '
        Me.Button_Print.Location = New System.Drawing.Point(669, 485)
        Me.Button_Print.Name = "Button_Print"
        Me.Button_Print.Size = New System.Drawing.Size(75, 23)
        Me.Button_Print.TabIndex = 58
        Me.Button_Print.Text = "Print"
        Me.Button_Print.UseVisualStyleBackColor = True
        '
        'AmmoInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 508)
        Me.Controls.Add(Me.Button_Print)
        Me.Controls.Add(Me.SpecialOrder_CheckBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(NOTELabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.NOTETextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(AMMOTRANSACTION_PKLabel)
        Me.Controls.Add(Me.AMMOTRANSACTION_PKTextBox)
        Me.Controls.Add(IS_SPECIAL_ORDERLabel)
        Me.Controls.Add(Me.SPECIAL_NOTETextBox)
        Me.Name = "AmmoInfo"
        Me.Text = "AmmoInfo"
        CType(Me.GdssDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmmoReportInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GdssDataSet1 As gdssDataSet1
    Friend WithEvents AmmoReportInfoBindingSource As BindingSource
    Friend WithEvents AmmoReportInfoTableAdapter As gdssDataSet1TableAdapters.AmmoReportInfoTableAdapter
    Friend WithEvents TableAdapterManager As gdssDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents AMMOTRANSACTION_PKTextBox As TextBox
    Friend WithEvents MILITARY_NBTextBox As TextBox
    Friend WithEvents YEARTextBox As TextBox
    Friend WithEvents QUANTITYTextBox As TextBox
    Friend WithEvents NBROF_DOCTextBox As TextBox
    Friend WithEvents SPECIAL_NOTETextBox As TextBox
    Friend WithEvents SIZE_AMMOTextBox As TextBox
    Friend WithEvents NOTETextBox As TextBox
    Friend WithEvents USER_APPTextBox As TextBox
    Friend WithEvents UPDATE_USERTextBox As TextBox
    Friend WithEvents PHONETextBox As TextBox
    Friend WithEvents FullNameTextBox As TextBox
    Friend WithEvents UpdateDate_TextBox As TextBox
    Friend WithEvents SystemDate_TextBox As TextBox
    Friend WithEvents DateOfBirth_TextBox As TextBox
    Friend WithEvents DateOfDocument_TextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents SpecialOrder_CheckBox As CheckBox
    Friend WithEvents Button_Print As Button
End Class
