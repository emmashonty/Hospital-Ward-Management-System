<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaternityForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtWardNo = New System.Windows.Forms.ComboBox
        Me.txtWardName = New System.Windows.Forms.TextBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.cmbOut = New System.Windows.Forms.ComboBox
        Me.cmbSex = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmbSexB = New System.Windows.Forms.ComboBox
        Me.txtTimeDeliver = New System.Windows.Forms.TextBox
        Me.txtDateDeliver = New System.Windows.Forms.TextBox
        Me.cmbNature = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.CmbBedNo = New System.Windows.Forms.ComboBox
        Me.txtTimeD = New System.Windows.Forms.TextBox
        Me.txtDateD = New System.Windows.Forms.TextBox
        Me.txtOther = New System.Windows.Forms.TextBox
        Me.txtSurname = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BillToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MaternityWardBillToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MedicalWardBillToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SurgicalWardBillToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnReset = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtWardNo)
        Me.GroupBox1.Controls.Add(Me.txtWardName)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.cmbOut)
        Me.GroupBox1.Controls.Add(Me.cmbSex)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.CmbBedNo)
        Me.GroupBox1.Controls.Add(Me.txtTimeD)
        Me.GroupBox1.Controls.Add(Me.txtDateD)
        Me.GroupBox1.Controls.Add(Me.txtOther)
        Me.GroupBox1.Controls.Add(Me.txtSurname)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(697, 384)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "                                                          Maternity Discharge For" & _
            "m"
        '
        'txtWardNo
        '
        Me.txtWardNo.FormattingEnabled = True
        Me.txtWardNo.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.txtWardNo.Location = New System.Drawing.Point(154, 163)
        Me.txtWardNo.Name = "txtWardNo"
        Me.txtWardNo.Size = New System.Drawing.Size(112, 21)
        Me.txtWardNo.TabIndex = 25
        '
        'txtWardName
        '
        Me.txtWardName.Location = New System.Drawing.Point(154, 127)
        Me.txtWardName.Name = "txtWardName"
        Me.txtWardName.Size = New System.Drawing.Size(173, 20)
        Me.txtWardName.TabIndex = 24
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(229, 238)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(133, 20)
        Me.DateTimePicker1.TabIndex = 22
        '
        'cmbOut
        '
        Me.cmbOut.FormattingEnabled = True
        Me.cmbOut.Items.AddRange(New Object() {"Discharged", "Transfered", "Refered", "Dead"})
        Me.cmbOut.Location = New System.Drawing.Point(157, 318)
        Me.cmbOut.Name = "cmbOut"
        Me.cmbOut.Size = New System.Drawing.Size(130, 21)
        Me.cmbOut.TabIndex = 20
        '
        'cmbSex
        '
        Me.cmbSex.FormattingEnabled = True
        Me.cmbSex.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbSex.Location = New System.Drawing.Point(154, 94)
        Me.cmbSex.Name = "cmbSex"
        Me.cmbSex.Size = New System.Drawing.Size(69, 21)
        Me.cmbSex.TabIndex = 19
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbSexB)
        Me.GroupBox2.Controls.Add(Me.txtTimeDeliver)
        Me.GroupBox2.Controls.Add(Me.txtDateDeliver)
        Me.GroupBox2.Controls.Add(Me.cmbNature)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(418, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(264, 181)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Delivery Details"
        '
        'cmbSexB
        '
        Me.cmbSexB.FormattingEnabled = True
        Me.cmbSexB.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbSexB.Location = New System.Drawing.Point(115, 136)
        Me.cmbSexB.Name = "cmbSexB"
        Me.cmbSexB.Size = New System.Drawing.Size(85, 21)
        Me.cmbSexB.TabIndex = 7
        '
        'txtTimeDeliver
        '
        Me.txtTimeDeliver.Location = New System.Drawing.Point(115, 61)
        Me.txtTimeDeliver.Name = "txtTimeDeliver"
        Me.txtTimeDeliver.Size = New System.Drawing.Size(133, 20)
        Me.txtTimeDeliver.TabIndex = 6
        '
        'txtDateDeliver
        '
        Me.txtDateDeliver.Location = New System.Drawing.Point(115, 27)
        Me.txtDateDeliver.Name = "txtDateDeliver"
        Me.txtDateDeliver.Size = New System.Drawing.Size(133, 20)
        Me.txtDateDeliver.TabIndex = 5
        '
        'cmbNature
        '
        Me.cmbNature.FormattingEnabled = True
        Me.cmbNature.Items.AddRange(New Object() {"Successful", "CS", "Still Birth"})
        Me.cmbNature.Location = New System.Drawing.Point(115, 96)
        Me.cmbNature.Name = "cmbNature"
        Me.cmbNature.Size = New System.Drawing.Size(133, 21)
        Me.cmbNature.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(17, 136)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 13)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Sex Of Baby"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Nature Of Delivery"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 66)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Time Of Delivery"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 34)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Date Of Delivery"
        '
        'CmbBedNo
        '
        Me.CmbBedNo.FormattingEnabled = True
        Me.CmbBedNo.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"})
        Me.CmbBedNo.Location = New System.Drawing.Point(154, 196)
        Me.CmbBedNo.Name = "CmbBedNo"
        Me.CmbBedNo.Size = New System.Drawing.Size(62, 21)
        Me.CmbBedNo.TabIndex = 17
        '
        'txtTimeD
        '
        Me.txtTimeD.Location = New System.Drawing.Point(156, 284)
        Me.txtTimeD.Name = "txtTimeD"
        Me.txtTimeD.ReadOnly = True
        Me.txtTimeD.Size = New System.Drawing.Size(131, 20)
        Me.txtTimeD.TabIndex = 14
        '
        'txtDateD
        '
        Me.txtDateD.Location = New System.Drawing.Point(154, 237)
        Me.txtDateD.Name = "txtDateD"
        Me.txtDateD.Size = New System.Drawing.Size(69, 20)
        Me.txtDateD.TabIndex = 13
        '
        'txtOther
        '
        Me.txtOther.Location = New System.Drawing.Point(156, 68)
        Me.txtOther.Name = "txtOther"
        Me.txtOther.Size = New System.Drawing.Size(171, 20)
        Me.txtOther.TabIndex = 11
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(156, 30)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(171, 20)
        Me.txtSurname.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 321)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Outcome Of Care"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 287)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Time Of Discharge"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 244)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Date Of Discharge"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Bed Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Ward Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ward Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sax"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Other names"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Surname"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(51, 424)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(81, 27)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Proceed"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.FileToolStripMenuItem, Me.BillToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(733, 24)
        Me.MenuStrip1.TabIndex = 2
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
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.ResetToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'BillToolStripMenuItem
        '
        Me.BillToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaternityWardBillToolStripMenuItem, Me.MedicalWardBillToolStripMenuItem, Me.SurgicalWardBillToolStripMenuItem})
        Me.BillToolStripMenuItem.Name = "BillToolStripMenuItem"
        Me.BillToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.BillToolStripMenuItem.Text = "Bill"
        '
        'MaternityWardBillToolStripMenuItem
        '
        Me.MaternityWardBillToolStripMenuItem.Name = "MaternityWardBillToolStripMenuItem"
        Me.MaternityWardBillToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.MaternityWardBillToolStripMenuItem.Text = "Maternity Ward Bill"
        '
        'MedicalWardBillToolStripMenuItem
        '
        Me.MedicalWardBillToolStripMenuItem.Name = "MedicalWardBillToolStripMenuItem"
        Me.MedicalWardBillToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.MedicalWardBillToolStripMenuItem.Text = "Medical Ward Bill"
        '
        'SurgicalWardBillToolStripMenuItem
        '
        Me.SurgicalWardBillToolStripMenuItem.Name = "SurgicalWardBillToolStripMenuItem"
        Me.SurgicalWardBillToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.SurgicalWardBillToolStripMenuItem.Text = "Surgical Ward Bill"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(138, 424)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(68, 26)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'frmMaternityForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 463)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMaternityForm"
        Me.Text = "frmMaternityForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmbBedNo As System.Windows.Forms.ComboBox
    Friend WithEvents txtTimeD As System.Windows.Forms.TextBox
    Friend WithEvents txtDateD As System.Windows.Forms.TextBox
    Friend WithEvents txtOther As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents cmbOut As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSex As System.Windows.Forms.ComboBox
    Friend WithEvents txtTimeDeliver As System.Windows.Forms.TextBox
    Friend WithEvents txtDateDeliver As System.Windows.Forms.TextBox
    Friend WithEvents cmbNature As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents cmbSexB As System.Windows.Forms.ComboBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BillToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaternityWardBillToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MedicalWardBillToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SurgicalWardBillToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtWardName As System.Windows.Forms.TextBox
    Friend WithEvents txtWardNo As System.Windows.Forms.ComboBox
End Class
