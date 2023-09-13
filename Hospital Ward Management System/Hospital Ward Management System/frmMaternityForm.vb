Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class frmMaternityForm

   
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim strSQL As String
        Dim objCmd As New OleDbCommand
        strSQL = "INSERT INTO Maternity_Discharge(Sur_Name, Other_Names, F_Sex, Ward_Name,Ward_No, Bed_No, Date_Discharge, Outcome_Care, Date_Delivery, Time_Delivery,Nature_Delivery, Sex_Baby)"
        strSQL = strSQL & "VALUES('" & (txtSurname.Text) & "', '" & (txtOther.Text) & "', '" & (cmbSex.Text) & "', '" & (txtWardName.Text) & "','" & (txtWardNo.Text) & "', '" & (CmbBedNo.Text) & "', '" & (txtDateD.Text) & "', '" & (cmbOut.Text) & "', '" & (txtDateDeliver.Text) & "', '" & (txtTimeD.Text) & "', '" & (cmbNature.Text) & "', '" & (cmbSexB.Text) & "');"
        Dim Con = New OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.3.51;Data Source=C:\Users\eee p\Documents\Visual Studio 2008\Projects\Hospital Ward Management System\HOSPITALSYSTEM.mdb;")
        Con.Open()
        objCmd = New OleDbCommand(strSQL, Con)
        objCmd.ExecuteNonQuery()
        Con.Close()
        frmMaternityBillForm.Show()
        Me.Hide()
    End Sub

    Private Sub MaternityWardBillToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaternityWardBillToolStripMenuItem.Click
        Me.Hide()
        frmMaternityBillForm.Show()
    End Sub

    Private Sub MedicalWardBillToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MedicalWardBillToolStripMenuItem.Click
        Me.Hide()
        frmMedicalWardBill.Show()
    End Sub

    Private Sub SurgicalWardBillToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SurgicalWardBillToolStripMenuItem.Click
        Me.Hide()
        frmSurgicalWard.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub HomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click
        Me.Hide()
        frmHome.Show()
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        txtSurname.Text = ""
        txtOther.Text = ""
        cmbSex.Text = ""
        txtWardName.Text = ""
        txtWardNo.Text = ""
        CmbBedNo.Text = ""
        txtDateD.Text = ""
        cmbOut.Text = ""
        txtDateDeliver.Text = ""
        txtTimeD.Text = ""
        cmbNature.Text = ""
        cmbSexB.Text = ""
    End Sub

    Private Sub ResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem.Click
        txtSurname.Text = ""
        txtOther.Text = ""
        cmbSex.Text = ""
        txtWardName.Text = ""
        txtWardNo.Text = ""
        CmbBedNo.Text = ""
        txtDateD.Text = ""
        cmbOut.Text = ""
        txtDateDeliver.Text = ""
        txtTimeD.Text = ""
        cmbNature.Text = ""
        cmbSexB.Text = ""
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Dim strSQL As String
        Dim objCmd As New OleDbCommand
        strSQL = "INSERT INTO Maternity_Discharge(Sur_Name, Other_Names, F_Sex, Ward_Name,Ward_No, Bed_No, Date_Discharge, Outcome_Care, Date_Delivery, Time_Delivery,Nature_Delivery, Sex_Baby)"
        strSQL = strSQL & "VALUES('" & (txtSurname.Text) & "', '" & (txtOther.Text) & "', '" & (cmbSex.Text) & "', '" & (txtWardName.Text) & "','" & (txtWardNo.Text) & "', '" & (CmbBedNo.Text) & "', '" & (txtDateD.Text) & "', '" & (cmbOut.Text) & "', '" & (txtDateDeliver.Text) & "', '" & (txtTimeD.Text) & "', '" & (cmbNature.Text) & "', '" & (cmbSexB.Text) & "');"
        Dim Con = New OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.3.51;Data Source=C:\Users\eee p\Documents\Visual Studio 2008\Projects\Hospital Ward Management System\HOSPITALSYSTEM.mdb;")
        Con.Open()
        objCmd = New OleDbCommand(strSQL, Con)
        objCmd.ExecuteNonQuery()
        Con.Close()
        frmMaternityBillForm.Show()
        Me.Hide()
    End Sub


    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        txtDateD.Text = DateTimePicker1.Value
    End Sub

    Private Sub frmMaternityForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtWardName.Text = "Maternity Ward"
        txtTimeDeliver.Text = TimeOfDay
        txtTimeD.Text = TimeOfDay
    End Sub
End Class