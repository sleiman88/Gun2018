﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintAmmoInfo
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
        Me.AmmoReportInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gdssDataSet1 = New GDSSTEMPLATE.gdssDataSet1()
        Me.AmmoReportInfoTableAdapter = New GDSSTEMPLATE.gdssDataSet1TableAdapters.AmmoReportInfoTableAdapter()
        Me.AmmoReportWithGradeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AmmoReportWithGradeTableAdapter = New GDSSTEMPLATE.gdssDataSet1TableAdapters.AmmoReportWithGradeTableAdapter()
        CType(Me.AmmoReportInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdssDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmmoReportWithGradeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.AmmoReportInfoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GDSSTEMPLATE.AmmoInfoUpdated.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(1, 24)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(723, 547)
        Me.ReportViewer1.TabIndex = 0
        '
        'AmmoReportInfoBindingSource
        '
        Me.AmmoReportInfoBindingSource.DataMember = "AmmoReportInfo"
        Me.AmmoReportInfoBindingSource.DataSource = Me.gdssDataSet1
        '
        'gdssDataSet1
        '
        Me.gdssDataSet1.DataSetName = "gdssDataSet1"
        Me.gdssDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AmmoReportInfoTableAdapter
        '
        Me.AmmoReportInfoTableAdapter.ClearBeforeFill = True
        '
        'AmmoReportWithGradeBindingSource
        '
        Me.AmmoReportWithGradeBindingSource.DataMember = "AmmoReportWithGrade"
        Me.AmmoReportWithGradeBindingSource.DataSource = Me.gdssDataSet1
        '
        'AmmoReportWithGradeTableAdapter
        '
        Me.AmmoReportWithGradeTableAdapter.ClearBeforeFill = True
        '
        'PrintAmmoInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 647)
        Me.Controls.Add(Me.ReportViewer1)
        Me.MaximizeBox = False
        Me.Name = "PrintAmmoInfo"
        Me.Text = "PrintAmmoInfo"
        CType(Me.AmmoReportInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdssDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmmoReportWithGradeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents AmmoReportInfoBindingSource As BindingSource
    Friend WithEvents gdssDataSet1 As gdssDataSet1
    Friend WithEvents AmmoReportInfoTableAdapter As gdssDataSet1TableAdapters.AmmoReportInfoTableAdapter
    Friend WithEvents AmmoReportWithGradeBindingSource As BindingSource
    Friend WithEvents AmmoReportWithGradeTableAdapter As gdssDataSet1TableAdapters.AmmoReportWithGradeTableAdapter
End Class
