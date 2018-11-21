<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchGunFrom
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
        Me.TextBox_GunNumb = New System.Windows.Forms.TextBox()
        Me.Button_Search = New System.Windows.Forms.Button()
        Me.Label_error = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GdssDataSet1 = New GDSSTEMPLATE.gdssDataSet1()
        Me.GunReportInfoFormBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GunReportInfoFormTableAdapter = New GDSSTEMPLATE.gdssDataSet1TableAdapters.GunReportInfoFormTableAdapter()
        CType(Me.GdssDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunReportInfoFormBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox_GunNumb
        '
        Me.TextBox_GunNumb.Location = New System.Drawing.Point(80, 33)
        Me.TextBox_GunNumb.Name = "TextBox_GunNumb"
        Me.TextBox_GunNumb.Size = New System.Drawing.Size(141, 20)
        Me.TextBox_GunNumb.TabIndex = 0
        '
        'Button_Search
        '
        Me.Button_Search.Location = New System.Drawing.Point(265, 33)
        Me.Button_Search.Name = "Button_Search"
        Me.Button_Search.Size = New System.Drawing.Size(75, 23)
        Me.Button_Search.TabIndex = 1
        Me.Button_Search.Text = "Search"
        Me.Button_Search.UseVisualStyleBackColor = True
        '
        'Label_error
        '
        Me.Label_error.AutoSize = True
        Me.Label_error.ForeColor = System.Drawing.Color.Red
        Me.Label_error.Location = New System.Drawing.Point(236, 38)
        Me.Label_error.Name = "Label_error"
        Me.Label_error.Size = New System.Drawing.Size(13, 13)
        Me.Label_error.TabIndex = 2
        Me.Label_error.Text = "*"
        Me.Label_error.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-3, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Gun Number"
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
        'SearchGunFrom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 102)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label_error)
        Me.Controls.Add(Me.Button_Search)
        Me.Controls.Add(Me.TextBox_GunNumb)
        Me.MaximizeBox = False
        Me.Name = "SearchGunFrom"
        Me.Text = "SearchGunFrom"
        CType(Me.GdssDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunReportInfoFormBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_GunNumb As TextBox
    Friend WithEvents Button_Search As Button
    Friend WithEvents Label_error As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GdssDataSet1 As gdssDataSet1
    Friend WithEvents GunReportInfoFormBindingSource As BindingSource
    Friend WithEvents GunReportInfoFormTableAdapter As gdssDataSet1TableAdapters.GunReportInfoFormTableAdapter
End Class
