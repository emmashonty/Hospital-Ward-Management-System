Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class frmClinicForm


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim strSQL As String
        Dim objCmd As New OleDbCommand
        strSQL = "INSERT INTO Clinic_Record(Date_Adm, Time_Adm, Ward_Name, Ward_No,Bed_No, Diagnostic_Details)"
        strSQL = strSQL & "VALUES('" & (txtDateAdm.Text) & "', '" & (txtTimeAdm.Text) & "', '" & (cmbWardName.Text) & "', '" & (cmbWardNo.Text) & "','" & (cmbBedNo.Text) & "', '" & (txtDiagnostic.Text) & "');"
        Dim Con = New OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.3.51;Data Source=C:\Users\eee p\Documents\Visual Studio 2008\Projects\Hospital Ward Management System\HOSPITALSYSTEM.mdb;")
        Con.Open()
        objCmd = New OleDbCommand(strSQL, Con)
        objCmd.ExecuteNonQuery()
        Con.Close()
        MessageBox.Show("You have successfully Save Patient's Information.")
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        txtDateAdm.Text = ""
        txtTimeAdm.Text = ""
        cmbWardName.Text = ""
        cmbWardNo.Text = ""
        cmbBedNo.Text = ""
        txtDiagnostic.Text = ""
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Dim strSQL As String
        Dim objCmd As New OleDbCommand
        strSQL = "INSERT INTO Clinic_Record(Date_Adm, Time_Adm, Ward_Name, Ward_No,Bed_No, Diagnostic_Details)"
        strSQL = strSQL & "VALUES('" & (txtDateAdm.Text) & "', '" & (txtTimeAdm.Text) & "', '" & (cmbWardName.Text) & "', '" & (cmbWardNo.Text) & "','" & (cmbBedNo.Text) & "', '" & (txtDiagnostic.Text) & "');"
        Dim Con = New OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.3.51;Data Source=C:\Users\eee p\Documents\Visual Studio 2008\Projects\Hospital Ward Management System\HOSPITALSYSTEM.mdb;")
        Con.Open()
        objCmd = New OleDbCommand(strSQL, Con)
        objCmd.ExecuteNonQuery()
        Con.Close()
        MessageBox.Show("You have successfully Save Patient's Information.")
    End Sub

    Private Sub ResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem.Click
        txtDateAdm.Text = ""
        txtTimeAdm.Text = ""
        cmbWardName.Text = ""
        cmbWardNo.Text = ""
        cmbBedNo.Text = ""
        txtDiagnostic.Text = ""
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub HomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click
        Me.Hide()
        frmHome.Show()
    End Sub
End Class