<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewGun
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_gunName = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label_error_double = New System.Windows.Forms.Label()
        Me.Label_er = New System.Windows.Forms.Label()
        Me.GdssDataSet1 = New GDSSTEMPLATE.gdssDataSet1()
        Me.N0ITEMSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.N0ITEMSTableAdapter = New GDSSTEMPLATE.gdssDataSet1TableAdapters.N0ITEMSTableAdapter()
        CType(Me.GdssDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N0ITEMSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(360, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "اسم السلاح"
        '
        'TextBox_gunName
        '
        Me.TextBox_gunName.Location = New System.Drawing.Point(169, 42)
        Me.TextBox_gunName.Name = "TextBox_gunName"
        Me.TextBox_gunName.Size = New System.Drawing.Size(174, 20)
        Me.TextBox_gunName.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(70, 141)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "ادخال"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label_error_double
        '
        Me.Label_error_double.AutoSize = True
        Me.Label_error_double.ForeColor = System.Drawing.Color.Red
        Me.Label_error_double.Location = New System.Drawing.Point(63, 45)
        Me.Label_error_double.Name = "Label_error_double"
        Me.Label_error_double.Size = New System.Drawing.Size(82, 13)
        Me.Label_error_double.TabIndex = 3
        Me.Label_error_double.Text = "اسم سلاح مكرر"
        Me.Label_error_double.Visible = False
        '
        'Label_er
        '
        Me.Label_er.AutoSize = True
        Me.Label_er.ForeColor = System.Drawing.Color.Red
        Me.Label_er.Location = New System.Drawing.Point(150, 45)
        Me.Label_er.Name = "Label_er"
        Me.Label_er.Size = New System.Drawing.Size(13, 13)
        Me.Label_er.TabIndex = 4
        Me.Label_er.Text = "*"
        Me.Label_er.Visible = False
        '
        'GdssDataSet1
        '
        Me.GdssDataSet1.DataSetName = "gdssDataSet1"
        Me.GdssDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'N0ITEMSBindingSource
        '
        Me.N0ITEMSBindingSource.DataMember = "N0ITEMS"
        Me.N0ITEMSBindingSource.DataSource = Me.GdssDataSet1
        '
        'N0ITEMSTableAdapter
        '
        Me.N0ITEMSTableAdapter.ClearBeforeFill = True
        '
        'AddNewGun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 206)
        Me.Controls.Add(Me.Label_er)
        Me.Controls.Add(Me.Label_error_double)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox_gunName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddNewGun"
        Me.Text = "AddNewGun"
        CType(Me.GdssDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N0ITEMSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_gunName As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label_error_double As Label
    Friend WithEvents Label_er As Label
    Friend WithEvents GdssDataSet1 As gdssDataSet1
    Friend WithEvents N0ITEMSBindingSource As BindingSource
    Friend WithEvents N0ITEMSTableAdapter As gdssDataSet1TableAdapters.N0ITEMSTableAdapter
End Class
