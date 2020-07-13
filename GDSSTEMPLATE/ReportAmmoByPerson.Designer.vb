<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportAmmoByPerson
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.AmmoReportWithGradeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gdssDataSet1 = New GDSSTEMPLATE.gdssDataSet1()
        Me.AmmoReportWithGradeTableAdapter = New GDSSTEMPLATE.gdssDataSet1TableAdapters.AmmoReportWithGradeTableAdapter()
        CType(Me.AmmoReportWithGradeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdssDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.AmmoReportWithGradeBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GDSSTEMPLATE.ReportAmmoByPersonUpdated.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(691, 355)
        Me.ReportViewer1.TabIndex = 0
        '
        'AmmoReportWithGradeBindingSource
        '
        Me.AmmoReportWithGradeBindingSource.DataMember = "AmmoReportWithGrade"
        Me.AmmoReportWithGradeBindingSource.DataSource = Me.gdssDataSet1
        '
        'gdssDataSet1
        '
        Me.gdssDataSet1.DataSetName = "gdssDataSet1"
        Me.gdssDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AmmoReportWithGradeTableAdapter
        '
        Me.AmmoReportWithGradeTableAdapter.ClearBeforeFill = True
        '
        'ReportAmmoByPerson
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 415)
        Me.Controls.Add(Me.ReportViewer1)
        Me.MaximizeBox = False
        Me.Name = "ReportAmmoByPerson"
        Me.Text = "ReportAmmoByPerson"
        CType(Me.AmmoReportWithGradeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdssDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents gdssDataSet1 As gdssDataSet1
    Friend WithEvents AmmoReportWithGradeBindingSource As BindingSource
    Friend WithEvents AmmoReportWithGradeTableAdapter As gdssDataSet1TableAdapters.AmmoReportWithGradeTableAdapter
End Class
