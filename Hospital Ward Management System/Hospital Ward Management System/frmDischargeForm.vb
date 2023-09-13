Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class frmDischargeForm

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim strSQL As String
        Dim objCmd As New OleDbCommand
        strSQL = "INSERT INTO Inpatient_Discharge(Sur_Name, Other_Names, F_Sex, Ward_Name,Ward_No, Bed_No, Date_Discharge,Time_Discharge,Outcome_Care)"
        strSQL = strSQL & "VALUES('" & (txtName.Text) & "', '" & (txtOther.Text) & "', '" & (cmbSex.Text) & "','" & (cmbWardName.Text) & "', '" & (txtWardNo.Text) & "', '" & (cmbBed.Text) & "', '" & (txtDateD.Text) & "', '" & (txtTimeD.Text) & "', '" & (cmbOut.Text) & "');"
        Dim Con = New OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.3.51;Data Source=C:\Users\eee p\Documents\Visual Studio 2008\Projects\Hospital Ward Management System\HOSPITALSYSTEM.mdb;")
        Con.Open()
        objCmd = New OleDbCommand(strSQL, Con)
        objCmd.ExecuteNonQuery()
        Con.Close()
        If cmbWardName.Text = "Male Medical Ward" Then
            frmMedicalWardBill.Show()
            Me.Hide()
        ElseIf cmbWardName.Text = "Male Surgical Ward" Then
            frmSurgicalWard.Show()
            Me.Hide()
        ElseIf cmbWardName.Text = "Female Medical Ward" Then
            frmMedicalWardBill.Show()
            Me.Hide()
        ElseIf cmbWardName.Text = "Female Surgical Ward" Then
            frmSurgicalWard.Show()
            Me.Hide()
        ElseIf cmbWardName.Text = "Pediatric Ward" Then
            frmPediatricBill.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        txtName.Text = ""
        txtOther.Text = ""
        cmbSex.Text = ""
        cmbWardName.Text = ""
        txtWardNo.Text = ""
        cmbBed.Text = ""
        txtDateD.Text = ""
        txtTimeD.Text = ""
        cmbOut.Text = ""
    End Sub

    Private Sub ResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem.Click
        txtName.Text = ""
        txtOther.Text = ""
        cmbSex.Text = ""
        cmbWardName.Text = ""
        txtWardNo.Text = ""
        cmbBed.Text = ""
        txtDateD.Text = ""
        txtTimeD.Text = ""
        cmbOut.Text = ""
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Dim strSQL As String
        Dim objCmd As New OleDbCommand
        strSQL = "INSERT INTO Inpatient_Discharge(Sur_Name, Other_Names, F_Sex, Ward_Name,Ward_No, Bed_No, Date_Discharge,Time_Discharge,Outcome_Care)"
        strSQL = strSQL & "VALUES('" & (txtName.Text) & "', '" & (txtOther.Text) & "', '" & (cmbSex.Text) & "','" & (cmbWardName.Text) & "', '" & (txtWardNo.Text) & "', '" & (cmbBed.Text) & "', '" & (txtDateD.Text) & "', '" & (txtTimeD.Text) & "', '" & (cmbOut.Text) & "');"
        Dim Con = New OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.3.51;Data Source=C:\Users\eee p\Documents\Visual Studio 2008\Projects\Hospital Ward Management System\HOSPITALSYSTEM.mdb;")
        Con.Open()
        objCmd = New OleDbCommand(strSQL, Con)
        objCmd.ExecuteNonQuery()
        Con.Close()
        If cmbWardName.Text = "Male Medical Ward" Then
            frmMedicalWardBill.Show()
            Me.Hide()
        ElseIf cmbWardName.Text = "Male Surgical Ward" Then
            frmSurgicalWard.Show()
            Me.Hide()
        ElseIf cmbWardName.Text = "Female Medical Ward" Then
            frmMedicalWardBill.Show()
            Me.Hide()
        ElseIf cmbWardName.Text = "Female Surgical Ward" Then
            frmSurgicalWard.Show()
            Me.Hide()
        ElseIf cmbWardName.Text = "Pediatric Ward" Then
            frmPediatricBill.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub HomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click
        Me.Hide()
        frmHome.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub frmDischargeForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtTimeD.Text = TimeOfDay
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        txtDateD.Text = DateTimePicker1.Value
    End Sub

    Private Sub cmbWardName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbWardName.SelectedIndexChanged
        If cmbWardName.Text = "Male Medical Ward" Then
            txtWardNo.Text = 1
            txtBill.Text = "Male Medical Ward"
        ElseIf cmbWardName.Text = "Male Surgical Ward" Then
            txtWardNo.Text = 2
            txtBill.Text = "Male Surgical Ward"
        ElseIf cmbWardName.Text = "Female Medical Ward" Then
            txtWardNo.Text = 3
            txtBill.Text = "Female Medical Ward"
        ElseIf cmbWardName.Text = "Female Surgical Ward" Then
            txtWardNo.Text = 4
            txtBill.Text = "Female Surgical Ward"
        ElseIf cmbWardName.Text = "Pediatric Ward" Then
            txtWardNo.Text = 6
            txtBill.Text = "Pediatric Ward"
        End If
    End Sub
End Class