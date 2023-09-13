<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHome))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DischargeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SearchDischargeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SearchOutcomeOFCareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SearchDischargedPatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BillingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InpatientBillToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MaternityWardBillToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PediatricWardBillToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewMaternityDischargeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.BillingToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(681, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.DischargeToolStripMenuItem, Me.NewMaternityDischargeToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.NewToolStripMenuItem.Text = "New Admission"
        '
        'DischargeToolStripMenuItem
        '
        Me.DischargeToolStripMenuItem.Name = "DischargeToolStripMenuItem"
        Me.DischargeToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.DischargeToolStripMenuItem.Text = "New Discharge"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchDischargeToolStripMenuItem, Me.SearToolStripMenuItem, Me.SearchOutcomeOFCareToolStripMenuItem, Me.SearchDischargedPatientToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'SearchDischargeToolStripMenuItem
        '
        Me.SearchDischargeToolStripMenuItem.Name = "SearchDischargeToolStripMenuItem"
        Me.SearchDischargeToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.SearchDischargeToolStripMenuItem.Text = "Discharge Record"
        '
        'SearToolStripMenuItem
        '
        Me.SearToolStripMenuItem.Name = "SearToolStripMenuItem"
        Me.SearToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.SearToolStripMenuItem.Text = "Admission Record"
        '
        'SearchOutcomeOFCareToolStripMenuItem
        '
        Me.SearchOutcomeOFCareToolStripMenuItem.Name = "SearchOutcomeOFCareToolStripMenuItem"
        Me.SearchOutcomeOFCareToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.SearchOutcomeOFCareToolStripMenuItem.Text = "Search Admitted Patient"
        '
        'SearchDischargedPatientToolStripMenuItem
        '
        Me.SearchDischargedPatientToolStripMenuItem.Name = "SearchDischargedPatientToolStripMenuItem"
        Me.SearchDischargedPatientToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.SearchDischargedPatientToolStripMenuItem.Text = "Search Discharged Patient"
        '
        'BillingToolStripMenuItem
        '
        Me.BillingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InpatientBillToolStripMenuItem, Me.MaToolStripMenuItem, Me.MaternityWardBillToolStripMenuItem, Me.PediatricWardBillToolStripMenuItem})
        Me.BillingToolStripMenuItem.Name = "BillingToolStripMenuItem"
        Me.BillingToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.BillingToolStripMenuItem.Text = "Billing"
        '
        'InpatientBillToolStripMenuItem
        '
        Me.InpatientBillToolStripMenuItem.Name = "InpatientBillToolStripMenuItem"
        Me.InpatientBillToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.InpatientBillToolStripMenuItem.Text = "Medical Ward Bill"
        '
        'MaToolStripMenuItem
        '
        Me.MaToolStripMenuItem.Name = "MaToolStripMenuItem"
        Me.MaToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.MaToolStripMenuItem.Text = "Surgical Ward Bill"
        '
        'MaternityWardBillToolStripMenuItem
        '
        Me.MaternityWardBillToolStripMenuItem.Name = "MaternityWardBillToolStripMenuItem"
        Me.MaternityWardBillToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.MaternityWardBillToolStripMenuItem.Text = "Maternity Ward Bill"
        '
        'PediatricWardBillToolStripMenuItem
        '
        Me.PediatricWardBillToolStripMenuItem.Name = "PediatricWardBillToolStripMenuItem"
        Me.PediatricWardBillToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.PediatricWardBillToolStripMenuItem.Text = "Pediatric Ward Bill"
        '
        'NewMaternityDischargeToolStripMenuItem
        '
        Me.NewMaternityDischargeToolStripMenuItem.Name = "NewMaternityDischargeToolStripMenuItem"
        Me.NewMaternityDischargeToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.NewMaternityDischargeToolStripMenuItem.Text = "New Maternity Discharge"
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(681, 492)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmHome"
        Me.Text = "Home"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BillingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchDischargeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchOutcomeOFCareToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InpatientBillToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaternityWardBillToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DischargeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchDischargedPatientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PediatricWardBillToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewMaternityDischargeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
