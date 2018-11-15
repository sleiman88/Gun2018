<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GunInfo
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
        Dim CODELabel As System.Windows.Forms.Label
        Dim GTYPELabel As System.Windows.Forms.Label
        Dim GNUMBERLabel As System.Windows.Forms.Label
        Dim GSTORELabel As System.Windows.Forms.Label
        Dim GSIZELabel As System.Windows.Forms.Label
        Dim GCLEANERLabel As System.Windows.Forms.Label
        Dim GAMMOLabel As System.Windows.Forms.Label
        Dim DDATELabel As System.Windows.Forms.Label
        Dim NBDOCLabel As System.Windows.Forms.Label
        Dim NOTELabel As System.Windows.Forms.Label
        Dim SDATELabel As System.Windows.Forms.Label
        Dim UDATELabel As System.Windows.Forms.Label
        Dim UUSERLabel As System.Windows.Forms.Label
        Dim MDATELabel As System.Windows.Forms.Label
        Dim MUSERLabel As System.Windows.Forms.Label
        Dim LABELLabel As System.Windows.Forms.Label
        Dim EXPR1Label As System.Windows.Forms.Label
        Dim EXPR2Label As System.Windows.Forms.Label
        Dim DBIRTHLabel As System.Windows.Forms.Label
        Me.GdssDataSet1 = New GDSSTEMPLATE.gdssDataSet1()
        Me.GunReportInfoFormBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GunReportInfoFormTableAdapter = New GDSSTEMPLATE.gdssDataSet1TableAdapters.GunReportInfoFormTableAdapter()
        Me.TableAdapterManager = New GDSSTEMPLATE.gdssDataSet1TableAdapters.TableAdapterManager()
        Me.CODETextBox = New System.Windows.Forms.TextBox()
        Me.GTYPETextBox = New System.Windows.Forms.TextBox()
        Me.GNUMBERTextBox = New System.Windows.Forms.TextBox()
        Me.GSTORETextBox = New System.Windows.Forms.TextBox()
        Me.GSIZETextBox = New System.Windows.Forms.TextBox()
        Me.GAMMOTextBox = New System.Windows.Forms.TextBox()
        Me.NBDOCTextBox = New System.Windows.Forms.TextBox()
        Me.NOTETextBox = New System.Windows.Forms.TextBox()
        Me.UUSERTextBox = New System.Windows.Forms.TextBox()
        Me.MUSERTextBox = New System.Windows.Forms.TextBox()
        Me.LABELTextBox = New System.Windows.Forms.TextBox()
        Me.EXPR1TextBox = New System.Windows.Forms.TextBox()
        Me.EXPR2TextBox = New System.Windows.Forms.TextBox()
        Me.FullName_TextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateOFBirth_TextBox = New System.Windows.Forms.TextBox()
        Me.SDATE_TextBox = New System.Windows.Forms.TextBox()
        Me.UDATE_TextBox = New System.Windows.Forms.TextBox()
        Me.DDATE_TextBox = New System.Windows.Forms.TextBox()
        Me.MDATE_TextBox = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Print_Button = New System.Windows.Forms.Button()
        CODELabel = New System.Windows.Forms.Label()
        GTYPELabel = New System.Windows.Forms.Label()
        GNUMBERLabel = New System.Windows.Forms.Label()
        GSTORELabel = New System.Windows.Forms.Label()
        GSIZELabel = New System.Windows.Forms.Label()
        GCLEANERLabel = New System.Windows.Forms.Label()
        GAMMOLabel = New System.Windows.Forms.Label()
        DDATELabel = New System.Windows.Forms.Label()
        NBDOCLabel = New System.Windows.Forms.Label()
        NOTELabel = New System.Windows.Forms.Label()
        SDATELabel = New System.Windows.Forms.Label()
        UDATELabel = New System.Windows.Forms.Label()
        UUSERLabel = New System.Windows.Forms.Label()
        MDATELabel = New System.Windows.Forms.Label()
        MUSERLabel = New System.Windows.Forms.Label()
        LABELLabel = New System.Windows.Forms.Label()
        EXPR1Label = New System.Windows.Forms.Label()
        EXPR2Label = New System.Windows.Forms.Label()
        DBIRTHLabel = New System.Windows.Forms.Label()
        CType(Me.GdssDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunReportInfoFormBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'CODELabel
        '
        CODELabel.AutoSize = True
        CODELabel.Location = New System.Drawing.Point(25, 512)
        CODELabel.Name = "CODELabel"
        CODELabel.Size = New System.Drawing.Size(50, 13)
        CODELabel.TabIndex = 1
        CODELabel.Text = "CODEpk:"
        CODELabel.Visible = False
        '
        'GTYPELabel
        '
        GTYPELabel.AutoSize = True
        GTYPELabel.Location = New System.Drawing.Point(23, 32)
        GTYPELabel.Name = "GTYPELabel"
        GTYPELabel.Size = New System.Drawing.Size(29, 13)
        GTYPELabel.TabIndex = 5
        GTYPELabel.Text = "النوع"
        '
        'GNUMBERLabel
        '
        GNUMBERLabel.AutoSize = True
        GNUMBERLabel.Location = New System.Drawing.Point(23, 58)
        GNUMBERLabel.Name = "GNUMBERLabel"
        GNUMBERLabel.Size = New System.Drawing.Size(60, 13)
        GNUMBERLabel.TabIndex = 7
        GNUMBERLabel.Text = "رقم السلاح"
        '
        'GSTORELabel
        '
        GSTORELabel.AutoSize = True
        GSTORELabel.Location = New System.Drawing.Point(23, 84)
        GSTORELabel.Name = "GSTORELabel"
        GSTORELabel.Size = New System.Drawing.Size(73, 13)
        GSTORELabel.TabIndex = 9
        GSTORELabel.Text = "عدد المماشط "
        '
        'GSIZELabel
        '
        GSIZELabel.AutoSize = True
        GSIZELabel.Location = New System.Drawing.Point(23, 110)
        GSIZELabel.Name = "GSIZELabel"
        GSIZELabel.Size = New System.Drawing.Size(50, 13)
        GSIZELabel.TabIndex = 11
        GSIZELabel.Text = "عيار (مم)"
        '
        'GCLEANERLabel
        '
        GCLEANERLabel.AutoSize = True
        GCLEANERLabel.Location = New System.Drawing.Point(23, 192)
        GCLEANERLabel.Name = "GCLEANERLabel"
        GCLEANERLabel.Size = New System.Drawing.Size(60, 13)
        GCLEANERLabel.TabIndex = 13
        GCLEANERLabel.Text = " عدة تنظيف"
        '
        'GAMMOLabel
        '
        GAMMOLabel.AutoSize = True
        GAMMOLabel.Location = New System.Drawing.Point(23, 136)
        GAMMOLabel.Name = "GAMMOLabel"
        GAMMOLabel.Size = New System.Drawing.Size(61, 13)
        GAMMOLabel.TabIndex = 15
        GAMMOLabel.Text = "عدد الذخيرة"
        '
        'DDATELabel
        '
        DDATELabel.AutoSize = True
        DDATELabel.Location = New System.Drawing.Point(22, 64)
        DDATELabel.Name = "DDATELabel"
        DDATELabel.Size = New System.Drawing.Size(58, 13)
        DDATELabel.TabIndex = 25
        DDATELabel.Text = "تاريخ الملف"
        '
        'NBDOCLabel
        '
        NBDOCLabel.AutoSize = True
        NBDOCLabel.Location = New System.Drawing.Point(26, 15)
        NBDOCLabel.Name = "NBDOCLabel"
        NBDOCLabel.Size = New System.Drawing.Size(54, 13)
        NBDOCLabel.TabIndex = 27
        NBDOCLabel.Text = "رقم الملف"
        '
        'NOTELabel
        '
        NOTELabel.AutoSize = True
        NOTELabel.Location = New System.Drawing.Point(10, 456)
        NOTELabel.Name = "NOTELabel"
        NOTELabel.Size = New System.Drawing.Size(48, 13)
        NOTELabel.TabIndex = 29
        NOTELabel.Text = "ملاحظات"
        '
        'SDATELabel
        '
        SDATELabel.AutoSize = True
        SDATELabel.Location = New System.Drawing.Point(11, 64)
        SDATELabel.Name = "SDATELabel"
        SDATELabel.Size = New System.Drawing.Size(69, 13)
        SDATELabel.TabIndex = 31
        SDATELabel.Text = "تاريخ التسليم"
        '
        'UDATELabel
        '
        UDATELabel.AutoSize = True
        UDATELabel.Location = New System.Drawing.Point(-2, 38)
        UDATELabel.Name = "UDATELabel"
        UDATELabel.Size = New System.Drawing.Size(105, 13)
        UDATELabel.TabIndex = 33
        UDATELabel.Text = "تاريخ ادخال المعلومات"
        '
        'UUSERLabel
        '
        UUSERLabel.AutoSize = True
        UUSERLabel.Location = New System.Drawing.Point(11, 8)
        UUSERLabel.Name = "UUSERLabel"
        UUSERLabel.Size = New System.Drawing.Size(86, 13)
        UUSERLabel.TabIndex = 35
        UUSERLabel.Text = "مدخل المعلومات "
        '
        'MDATELabel
        '
        MDATELabel.AutoSize = True
        MDATELabel.Location = New System.Drawing.Point(11, 94)
        MDATELabel.Name = "MDATELabel"
        MDATELabel.Size = New System.Drawing.Size(64, 13)
        MDATELabel.TabIndex = 37
        MDATELabel.Text = "تاريخ التعديل"
        '
        'MUSERLabel
        '
        MUSERLabel.AutoSize = True
        MUSERLabel.Location = New System.Drawing.Point(11, 119)
        MUSERLabel.Name = "MUSERLabel"
        MUSERLabel.Size = New System.Drawing.Size(39, 13)
        MUSERLabel.TabIndex = 39
        MUSERLabel.Text = "المعدل"
        '
        'LABELLabel
        '
        LABELLabel.AutoSize = True
        LABELLabel.Location = New System.Drawing.Point(23, 6)
        LABELLabel.Name = "LABELLabel"
        LABELLabel.Size = New System.Drawing.Size(68, 13)
        LABELLabel.TabIndex = 41
        LABELLabel.Text = "اسم السلاح "
        AddHandler LABELLabel.Click, AddressOf Me.LABELLabel_Click
        '
        'EXPR1Label
        '
        EXPR1Label.AutoSize = True
        EXPR1Label.Location = New System.Drawing.Point(16, 54)
        EXPR1Label.Name = "EXPR1Label"
        EXPR1Label.Size = New System.Drawing.Size(31, 13)
        EXPR1Label.TabIndex = 43
        EXPR1Label.Text = "الرتبة"
        '
        'EXPR2Label
        '
        EXPR2Label.AutoSize = True
        EXPR2Label.Location = New System.Drawing.Point(23, 162)
        EXPR2Label.Name = "EXPR2Label"
        EXPR2Label.Size = New System.Drawing.Size(39, 13)
        EXPR2Label.TabIndex = 45
        EXPR2Label.Text = "المصنع"
        '
        'DBIRTHLabel
        '
        DBIRTHLabel.AutoSize = True
        DBIRTHLabel.Location = New System.Drawing.Point(16, 91)
        DBIRTHLabel.Name = "DBIRTHLabel"
        DBIRTHLabel.Size = New System.Drawing.Size(61, 13)
        DBIRTHLabel.TabIndex = 53
        DBIRTHLabel.Text = "تاريخ الميلاد"
        '
        'GdssDataSet1
        '
        Me.GdssDataSet1.DataSetName = "gdssDataSet1"
        Me.GdssDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.AMMOTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.N0ITEMSTableAdapter = Nothing
        Me.TableAdapterManager.PERGUNTableAdapterTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GDSSTEMPLATE.gdssDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CODETextBox
        '
        Me.CODETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GunReportInfoFormBindingSource, "CODE", True))
        Me.CODETextBox.Enabled = False
        Me.CODETextBox.Location = New System.Drawing.Point(88, 509)
        Me.CODETextBox.Name = "CODETextBox"
        Me.CODETextBox.Size = New System.Drawing.Size(200, 20)
        Me.CODETextBox.TabIndex = 2
        Me.CODETextBox.Visible = False
        '
        'GTYPETextBox
        '
        Me.GTYPETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GunReportInfoFormBindingSource, "GTYPE", True))
        Me.GTYPETextBox.Enabled = False
        Me.GTYPETextBox.Location = New System.Drawing.Point(119, 29)
        Me.GTYPETextBox.Name = "GTYPETextBox"
        Me.GTYPETextBox.Size = New System.Drawing.Size(200, 20)
        Me.GTYPETextBox.TabIndex = 6
        '
        'GNUMBERTextBox
        '
        Me.GNUMBERTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GunReportInfoFormBindingSource, "GNUMBER", True))
        Me.GNUMBERTextBox.Enabled = False
        Me.GNUMBERTextBox.Location = New System.Drawing.Point(119, 55)
        Me.GNUMBERTextBox.Name = "GNUMBERTextBox"
        Me.GNUMBERTextBox.Size = New System.Drawing.Size(200, 20)
        Me.GNUMBERTextBox.TabIndex = 8
        '
        'GSTORETextBox
        '
        Me.GSTORETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GunReportInfoFormBindingSource, "GSTORE", True))
        Me.GSTORETextBox.Enabled = False
        Me.GSTORETextBox.Location = New System.Drawing.Point(119, 81)
        Me.GSTORETextBox.Name = "GSTORETextBox"
        Me.GSTORETextBox.Size = New System.Drawing.Size(200, 20)
        Me.GSTORETextBox.TabIndex = 10
        '
        'GSIZETextBox
        '
        Me.GSIZETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GunReportInfoFormBindingSource, "GSIZE", True))
        Me.GSIZETextBox.Enabled = False
        Me.GSIZETextBox.Location = New System.Drawing.Point(119, 107)
        Me.GSIZETextBox.Name = "GSIZETextBox"
        Me.GSIZETextBox.Size = New System.Drawing.Size(200, 20)
        Me.GSIZETextBox.TabIndex = 12
        '
        'GAMMOTextBox
        '
        Me.GAMMOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GunReportInfoFormBindingSource, "GAMMO", True))
        Me.GAMMOTextBox.Enabled = False
        Me.GAMMOTextBox.Location = New System.Drawing.Point(119, 133)
        Me.GAMMOTextBox.Name = "GAMMOTextBox"
        Me.GAMMOTextBox.Size = New System.Drawing.Size(200, 20)
        Me.GAMMOTextBox.TabIndex = 16
        '
        'NBDOCTextBox
        '
        Me.NBDOCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GunReportInfoFormBindingSource, "NBDOC", True))
        Me.NBDOCTextBox.Enabled = False
        Me.NBDOCTextBox.Location = New System.Drawing.Point(118, 15)
        Me.NBDOCTextBox.Name = "NBDOCTextBox"
        Me.NBDOCTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NBDOCTextBox.TabIndex = 28
        '
        'NOTETextBox
        '
        Me.NOTETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GunReportInfoFormBindingSource, "NOTE", True))
        Me.NOTETextBox.Enabled = False
        Me.NOTETextBox.Location = New System.Drawing.Point(351, 456)
        Me.NOTETextBox.Multiline = True
        Me.NOTETextBox.Name = "NOTETextBox"
        Me.NOTETextBox.Size = New System.Drawing.Size(334, 137)
        Me.NOTETextBox.TabIndex = 30
        '
        'UUSERTextBox
        '
        Me.UUSERTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GunReportInfoFormBindingSource, "UUSER", True))
        Me.UUSERTextBox.Enabled = False
        Me.UUSERTextBox.Location = New System.Drawing.Point(107, 5)
        Me.UUSERTextBox.Name = "UUSERTextBox"
        Me.UUSERTextBox.Size = New System.Drawing.Size(200, 20)
        Me.UUSERTextBox.TabIndex = 36
        '
        'MUSERTextBox
        '
        Me.MUSERTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GunReportInfoFormBindingSource, "MUSER", True))
        Me.MUSERTextBox.Enabled = False
        Me.MUSERTextBox.Location = New System.Drawing.Point(107, 116)
        Me.MUSERTextBox.Name = "MUSERTextBox"
        Me.MUSERTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MUSERTextBox.TabIndex = 40
        '
        'LABELTextBox
        '
        Me.LABELTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GunReportInfoFormBindingSource, "LABEL", True))
        Me.LABELTextBox.Enabled = False
        Me.LABELTextBox.Location = New System.Drawing.Point(119, 3)
        Me.LABELTextBox.Name = "LABELTextBox"
        Me.LABELTextBox.Size = New System.Drawing.Size(200, 20)
        Me.LABELTextBox.TabIndex = 42
        '
        'EXPR1TextBox
        '
        Me.EXPR1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GunReportInfoFormBindingSource, "EXPR1", True))
        Me.EXPR1TextBox.Enabled = False
        Me.EXPR1TextBox.Location = New System.Drawing.Point(112, 51)
        Me.EXPR1TextBox.Name = "EXPR1TextBox"
        Me.EXPR1TextBox.Size = New System.Drawing.Size(197, 20)
        Me.EXPR1TextBox.TabIndex = 44
        '
        'EXPR2TextBox
        '
        Me.EXPR2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GunReportInfoFormBindingSource, "EXPR2", True))
        Me.EXPR2TextBox.Enabled = False
        Me.EXPR2TextBox.Location = New System.Drawing.Point(119, 159)
        Me.EXPR2TextBox.Name = "EXPR2TextBox"
        Me.EXPR2TextBox.Size = New System.Drawing.Size(200, 20)
        Me.EXPR2TextBox.TabIndex = 46
        '
        'FullName_TextBox
        '
        Me.FullName_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GunReportInfoFormBindingSource, "FullName", True))
        Me.FullName_TextBox.Enabled = False
        Me.FullName_TextBox.Location = New System.Drawing.Point(112, 13)
        Me.FullName_TextBox.Name = "FullName_TextBox"
        Me.FullName_TextBox.Size = New System.Drawing.Size(197, 20)
        Me.FullName_TextBox.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "الاسم الكامل"
        '
        'DateOFBirth_TextBox
        '
        Me.DateOFBirth_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GunReportInfoFormBindingSource, "DBIRTH", True))
        Me.DateOFBirth_TextBox.Enabled = False
        Me.DateOFBirth_TextBox.Location = New System.Drawing.Point(112, 88)
        Me.DateOFBirth_TextBox.Name = "DateOFBirth_TextBox"
        Me.DateOFBirth_TextBox.Size = New System.Drawing.Size(197, 20)
        Me.DateOFBirth_TextBox.TabIndex = 57
        '
        'SDATE_TextBox
        '
        Me.SDATE_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GunReportInfoFormBindingSource, "SDATE", True))
        Me.SDATE_TextBox.Enabled = False
        Me.SDATE_TextBox.Location = New System.Drawing.Point(107, 61)
        Me.SDATE_TextBox.Name = "SDATE_TextBox"
        Me.SDATE_TextBox.Size = New System.Drawing.Size(200, 20)
        Me.SDATE_TextBox.TabIndex = 58
        '
        'UDATE_TextBox
        '
        Me.UDATE_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GunReportInfoFormBindingSource, "UDATE", True))
        Me.UDATE_TextBox.Enabled = False
        Me.UDATE_TextBox.Location = New System.Drawing.Point(107, 31)
        Me.UDATE_TextBox.Name = "UDATE_TextBox"
        Me.UDATE_TextBox.Size = New System.Drawing.Size(200, 20)
        Me.UDATE_TextBox.TabIndex = 59
        '
        'DDATE_TextBox
        '
        Me.DDATE_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GunReportInfoFormBindingSource, "DDATE", True))
        Me.DDATE_TextBox.Enabled = False
        Me.DDATE_TextBox.Location = New System.Drawing.Point(118, 57)
        Me.DDATE_TextBox.Name = "DDATE_TextBox"
        Me.DDATE_TextBox.Size = New System.Drawing.Size(200, 20)
        Me.DDATE_TextBox.TabIndex = 60
        '
        'MDATE_TextBox
        '
        Me.MDATE_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GunReportInfoFormBindingSource, "MDATE", True))
        Me.MDATE_TextBox.Enabled = False
        Me.MDATE_TextBox.Location = New System.Drawing.Point(107, 87)
        Me.MDATE_TextBox.Name = "MDATE_TextBox"
        Me.MDATE_TextBox.Size = New System.Drawing.Size(200, 20)
        Me.MDATE_TextBox.TabIndex = 61
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.GunReportInfoFormBindingSource, "GCLEANER", True))
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Location = New System.Drawing.Point(119, 192)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 62
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.LABELTextBox)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.EXPR2TextBox)
        Me.Panel1.Controls.Add(EXPR2Label)
        Me.Panel1.Controls.Add(LABELLabel)
        Me.Panel1.Controls.Add(Me.GAMMOTextBox)
        Me.Panel1.Controls.Add(GAMMOLabel)
        Me.Panel1.Controls.Add(GCLEANERLabel)
        Me.Panel1.Controls.Add(Me.GSIZETextBox)
        Me.Panel1.Controls.Add(GSIZELabel)
        Me.Panel1.Controls.Add(Me.GSTORETextBox)
        Me.Panel1.Controls.Add(GSTORELabel)
        Me.Panel1.Controls.Add(GTYPELabel)
        Me.Panel1.Controls.Add(Me.GNUMBERTextBox)
        Me.Panel1.Controls.Add(Me.GTYPETextBox)
        Me.Panel1.Controls.Add(GNUMBERLabel)
        Me.Panel1.Location = New System.Drawing.Point(12, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(333, 219)
        Me.Panel1.TabIndex = 63
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.FullName_TextBox)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.EXPR1TextBox)
        Me.Panel2.Controls.Add(EXPR1Label)
        Me.Panel2.Controls.Add(Me.DateOFBirth_TextBox)
        Me.Panel2.Controls.Add(DBIRTHLabel)
        Me.Panel2.Location = New System.Drawing.Point(351, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(334, 219)
        Me.Panel2.TabIndex = 64
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.NBDOCTextBox)
        Me.Panel3.Controls.Add(NBDOCLabel)
        Me.Panel3.Controls.Add(Me.DDATE_TextBox)
        Me.Panel3.Controls.Add(DDATELabel)
        Me.Panel3.Location = New System.Drawing.Point(13, 269)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(332, 159)
        Me.Panel3.TabIndex = 65
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.UDATE_TextBox)
        Me.Panel4.Controls.Add(UDATELabel)
        Me.Panel4.Controls.Add(Me.UUSERTextBox)
        Me.Panel4.Controls.Add(UUSERLabel)
        Me.Panel4.Controls.Add(Me.MDATE_TextBox)
        Me.Panel4.Controls.Add(Me.SDATE_TextBox)
        Me.Panel4.Controls.Add(SDATELabel)
        Me.Panel4.Controls.Add(Me.MUSERTextBox)
        Me.Panel4.Controls.Add(MUSERLabel)
        Me.Panel4.Controls.Add(MDATELabel)
        Me.Panel4.Location = New System.Drawing.Point(351, 269)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(334, 159)
        Me.Panel4.TabIndex = 66
        '
        'Print_Button
        '
        Me.Print_Button.Location = New System.Drawing.Point(610, 608)
        Me.Print_Button.Name = "Print_Button"
        Me.Print_Button.Size = New System.Drawing.Size(75, 23)
        Me.Print_Button.TabIndex = 67
        Me.Print_Button.Text = "Print"
        Me.Print_Button.UseVisualStyleBackColor = True
        '
        'GunInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 634)
        Me.Controls.Add(Me.Print_Button)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(CODELabel)
        Me.Controls.Add(Me.CODETextBox)
        Me.Controls.Add(NOTELabel)
        Me.Controls.Add(Me.NOTETextBox)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GunReportInfoFormBindingSource, "SDATE", True))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GunInfo"
        Me.Text = "GunInfo"
        CType(Me.GdssDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunReportInfoFormBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GdssDataSet1 As gdssDataSet1
    Friend WithEvents GunReportInfoFormBindingSource As BindingSource
    Friend WithEvents GunReportInfoFormTableAdapter As gdssDataSet1TableAdapters.GunReportInfoFormTableAdapter
    Friend WithEvents TableAdapterManager As gdssDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents CODETextBox As TextBox
    Friend WithEvents GTYPETextBox As TextBox
    Friend WithEvents GNUMBERTextBox As TextBox
    Friend WithEvents GSTORETextBox As TextBox
    Friend WithEvents GSIZETextBox As TextBox
    Friend WithEvents GAMMOTextBox As TextBox
    Friend WithEvents NBDOCTextBox As TextBox
    Friend WithEvents NOTETextBox As TextBox
    Friend WithEvents UUSERTextBox As TextBox
    Friend WithEvents MUSERTextBox As TextBox
    Friend WithEvents LABELTextBox As TextBox
    Friend WithEvents EXPR1TextBox As TextBox
    Friend WithEvents EXPR2TextBox As TextBox
    Friend WithEvents FullName_TextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DateOFBirth_TextBox As TextBox
    Friend WithEvents SDATE_TextBox As TextBox
    Friend WithEvents UDATE_TextBox As TextBox
    Friend WithEvents DDATE_TextBox As TextBox
    Friend WithEvents MDATE_TextBox As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Print_Button As Button
End Class
