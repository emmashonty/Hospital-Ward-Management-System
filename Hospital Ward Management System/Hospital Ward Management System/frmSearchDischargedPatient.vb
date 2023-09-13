Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class frmSearchDischargedPatient

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim SQL As String
        Dim dbConnection As OleDbConnection
        Dim dbCommand As New OleDbCommand
        Dim dbFilePath As String = "C:\Users\eee p\Documents\Visual Studio 2008\Projects\Hospital Ward Management System\HOSPITALSYSTEM.mdb;"
        SQL = "SELECT Sur_Name, Other_Names, F_Sex, Ward_Name, Ward_No,Bed_No, Date_Discharge, Time_Discharge, Outcome_Care FROM Inpatient_Discharge"
        dbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dbFilePath)
        dbCommand = New OleDbCommand(SQL, dbConnection)
        Dim data As New OleDbDataAdapter(dbCommand)
        Dim table As New DataTable("Test")
        dbConnection.Open()
        data.Fill(table)
        txtSurname.Text = table.Rows(txtSerial.Text)("Sur_Name").ToString()
        txtOther.Text = table.Rows(txtSerial.Text)("Other_Names").ToString()
        txtSex.Text = table.Rows(txtSerial.Text)("F_Sex").ToString()
        txtWard.Text = table.Rows(txtSerial.Text)("Ward_Name").ToString()
        txtWardNo.Text = table.Rows(txtSerial.Text)("Ward_No").ToString()
        txtBed.Text = table.Rows(txtSerial.Text)("Bed_No").ToString()
        txtDate.Text = table.Rows(txtSerial.Text)("Date_Discharge").ToString()
        txtTime.Text = table.Rows(txtSerial.Text)("Time_Discharge").ToString()
        txtOutcome.Text = table.Rows(txtSerial.Text)("Outcome_Care").ToString()
    End Sub

    Private Sub HomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click
        Me.Hide()
        frmHome.Show()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim AB As New PrintDialog
        Try
            AB.ShowDialog()
            txtSurname.Text = AB.PrintToFile
            txtOther.Text = AB.PrintToFile
            txtSex.Text = AB.PrintToFile
            txtWard.Text = AB.PrintToFile
            txtWardNo.Text = AB.PrintToFile
            txtBed.Text = AB.PrintToFile
            txtDate.Text = AB.PrintToFile
            txtTime.Text = AB.PrintToFile
            txtOutcome.Text = AB.PrintToFile
        Catch ex As Exception
            'Again, do nothing on exception
        End Try
    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        Dim AB As New PrintDialog
        Try
            AB.ShowDialog()
            txtSurname.Text = AB.PrintToFile
            txtOther.Text = AB.PrintToFile
            txtSex.Text = AB.PrintToFile
            txtWard.Text = AB.PrintToFile
            txtWardNo.Text = AB.PrintToFile
            txtBed.Text = AB.PrintToFile
            txtDate.Text = AB.PrintToFile
            txtTime.Text = AB.PrintToFile
            txtOutcome.Text = AB.PrintToFile
        Catch ex As Exception
            'Again, do nothing on exception
        End Try
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        txtSerial.Text = ""
        txtPWard.Text = ""
    End Sub
End Class