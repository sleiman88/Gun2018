﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintGunInfo
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
        Me.GunReportInfoFormBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GdssDataSet1 = New GDSSTEMPLATE.gdssDataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GunReportInfoFormTableAdapter = New GDSSTEMPLATE.gdssDataSet1TableAdapters.GunReportInfoFormTableAdapter()
        Me.AmmoReportInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AmmoReportInfoTableAdapter = New GDSSTEMPLATE.gdssDataSet1TableAdapters.AmmoReportInfoTableAdapter()
        CType(Me.GunReportInfoFormBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GdssDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmmoReportInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunReportInfoFormBindingSource
        '
        Me.GunReportInfoFormBindingSource.DataMember = "GunReportInfoForm"
        Me.GunReportInfoFormBindingSource.DataSource = Me.GdssDataSet1
        '
        'GdssDataSet1
        '
        Me.GdssDataSet1.DataSetName = "gdssDataSet1"
        Me.GdssDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.GunReportInfoFormBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GDSSTEMPLATE.DeliveryGunReportUpdated.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(883, 391)
        Me.ReportViewer1.TabIndex = 0
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
        'PrintGunInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 471)
        Me.Controls.Add(Me.ReportViewer1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PrintGunInfo"
        Me.Text = "PrintGunInfo"
        CType(Me.GunReportInfoFormBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GdssDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmmoReportInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents GdssDataSet1 As gdssDataSet1
    Friend WithEvents GunReportInfoFormBindingSource As BindingSource
    Friend WithEvents GunReportInfoFormTableAdapter As gdssDataSet1TableAdapters.GunReportInfoFormTableAdapter
    Friend WithEvents AmmoReportInfoBindingSource As BindingSource
    Friend WithEvents AmmoReportInfoTableAdapter As gdssDataSet1TableAdapters.AmmoReportInfoTableAdapter
End Class
