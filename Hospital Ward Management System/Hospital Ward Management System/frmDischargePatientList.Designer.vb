﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDischargePatientList
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.MaternityWardBillToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MedicalWardBillToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SurgicalWardBillToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PediatricWardBillToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(717, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.MaternityWardBillToolStripMenuItem, Me.MedicalWardBillToolStripMenuItem, Me.SurgicalWardBillToolStripMenuItem, Me.PediatricWardBillToolStripMenuItem, Me.PrintToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.OpenToolStripMenuItem.Text = "Open Discharge Record"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 27)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(693, 271)
        Me.DataGridView1.TabIndex = 1
        '
        'MaternityWardBillToolStripMenuItem
        '
        Me.MaternityWardBillToolStripMenuItem.Name = "MaternityWardBillToolStripMenuItem"
        Me.MaternityWardBillToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.MaternityWardBillToolStripMenuItem.Text = "Maternity Ward Bill"
        '
        'MedicalWardBillToolStripMenuItem
        '
        Me.MedicalWardBillToolStripMenuItem.Name = "MedicalWardBillToolStripMenuItem"
        Me.MedicalWardBillToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.MedicalWardBillToolStripMenuItem.Text = "Medical Ward Bill"
        '
        'SurgicalWardBillToolStripMenuItem
        '
        Me.SurgicalWardBillToolStripMenuItem.Name = "SurgicalWardBillToolStripMenuItem"
        Me.SurgicalWardBillToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.SurgicalWardBillToolStripMenuItem.Text = "Surgical Ward Bill"
        '
        'PediatricWardBillToolStripMenuItem
        '
        Me.PediatricWardBillToolStripMenuItem.Name = "PediatricWardBillToolStripMenuItem"
        Me.PediatricWardBillToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.PediatricWardBillToolStripMenuItem.Text = "Pediatric Ward Bill"
        '
        'frmDischargePatientList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 322)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmDischargePatientList"
        Me.Text = "frmDischargePatientList"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MaternityWardBillToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MedicalWardBillToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SurgicalWardBillToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PediatricWardBillToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
