Imports GDSSTEMPLATE.gdssDataSet1TableAdapters

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GiveGun
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
        Me.SuspendLayout()
        '
        'GiveGun
        '
        Me.ClientSize = New System.Drawing.Size(447, 261)
        Me.Name = "GiveGun"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextBox_NameGun As TextBox
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
    Friend WithEvents gunSize_Label As Label
    Friend WithEvents GunStore_Label As Label
    Friend WithEvents GAMMO_TextBox As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents GAMMO_Label As Label
    Friend WithEvents Supplier As Label
    Friend WithEvents Note_TextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Save_Button As Button
    Friend WithEvents Source_ComboBox As ComboBox
    Friend WithEvents Grade_ComboBox As ComboBox
    Friend WithEvents Supplier_TextBox As TextBox
    Friend WithEvents N0OFFICE1TableAdapter As N0OFFICE1TableAdapter
    Friend WithEvents Supplier_ComboBox As ComboBox
    Friend WithEvents N0OFFICE1BindingSource As BindingSource
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents NBDoc_TextBox As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents User_TextBox As TextBox
    Friend WithEvents PERGUNTableAdapterBindingSource As BindingSource
    Friend WithEvents PERGUNTableAdapterTableAdapter As PERGUNTableAdapterTableAdapter
    Friend WithEvents TableAdapterManager As TableAdapterManager
    Friend WithEvents Item_Label As Label
    Friend WithEvents Person_Label As Label
    Friend WithEvents Supplier_Label As Label
    Friend WithEvents Document_Label As Label
    Friend WithEvents GNb_Label As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Item_TextBox As TextBox
    Friend WithEvents FullName_TextBox As TextBox
    Friend WithEvents SuppShow_TextBox As TextBox
    Friend WithEvents DDate_Label As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DDATE_TextBox As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents SDATE_Label As Label
    Friend WithEvents SDATE_TextBox As TextBox
    Friend WithEvents DateTimePicker_SDATE As DateTimePicker
    Friend WithEvents Label22 As Label
End Class
