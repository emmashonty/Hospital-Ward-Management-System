Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class frmSurgicalWard

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim strSQL As String
        Dim objCmd As New OleDbCommand
        strSQL = "INSERT INTO Surgical_ward(Adm_Fee, Bed_fee, Service_Fee,Surgical_fee, Total_Bill)"
        strSQL = strSQL & "VALUES('" & (txtAdmFee.Text) & "', '" & (txtBedFee.Text) & "', '" & (txtService.Text) & "', '" & (txtSurgical.Text) & "', '" & (txtTotal.Text) & "');"
        Dim Con = New OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.3.51;Data Source=C:\Users\eee p\Documents\Visual Studio 2008\Projects\Hospital Ward Management System\HOSPITALSYSTEM.mdb;")
        Con.Open()
        objCmd = New OleDbCommand(strSQL, Con)
        objCmd.ExecuteNonQuery()
        Con.Close()
        MessageBox.Show("You have successfully Save Patient's Information.")
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        txtAdmFee.Text = ""
        txtBedFee.Text = ""
        txtService.Text = ""
        txtSurgical.Text = ""
        txtTotal.Text = ""
        txtSpent.Text = ""
    End Sub

    Private Sub ResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem.Click
        txtAdmFee.Text = ""
        txtBedFee.Text = ""
        txtService.Text = ""
        txtSurgical.Text = ""
        txtTotal.Text = ""
        txtSpent.Text = ""
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Dim strSQL As String
        Dim objCmd As New OleDbCommand
        strSQL = "INSERT INTO Surgical_ward(Adm_Fee, Bed_fee, Service_Fee,Surgical_fee, Total_Bill)"
        strSQL = strSQL & "VALUES('" & (txtAdmFee.Text) & "', '" & (txtBedFee.Text) & "', '" & (txtService.Text) & "', '" & (txtSurgical.Text) & "', '" & (txtTotal.Text) & "');"
        Dim Con = New OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.3.51;Data Source=C:\Users\eee p\Documents\Visual Studio 2008\Projects\Hospital Ward Management System\HOSPITALSYSTEM.mdb;")
        Con.Open()
        objCmd = New OleDbCommand(strSQL, Con)
        objCmd.ExecuteNonQuery()
        Con.Close()
        MessageBox.Show("You have successfully Save Patient's Information.")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub HomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click
        Me.Hide()
        frmHome.Show()
    End Sub

    Private Sub btnSum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSum.Click
        txtBedFee.Text = Val(txtSpent.Text) * 100
        txtTotal.Text = Val(txtAdmFee.Text) + Val(txtBedFee.Text) + Val(txtService.Text) + Val(txtSurgical.Text)
       
    End Sub
End Class