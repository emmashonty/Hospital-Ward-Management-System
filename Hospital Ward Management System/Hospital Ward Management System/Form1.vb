Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class frmAdmission

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim strSQL As String
        Dim objCmd As New OleDbCommand
        strSQL = "INSERT INTO Admission(Sur_Name, Other_Names, F_Age, F_Sex,Contact_No, Contact_Address, Relations_Infor, Relations_Name,Relations_No)"
        strSQL = strSQL & "VALUES('" & (txtSurname.Text) & "', '" & (txtOther.Text) & "', '" & (txtAge.Text) & "', '" & (txtSex.Text) & "','" & (txtContactNo.Text) & "', '" & (txtAdress.Text) & "', '" & (txtInfor.Text) & "', '" & (txtRelation.Text) & "', '" & (txtRaletionNo.Text) & "');"
        Dim Con = New OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.3.51;Data Source=C:\Users\eee p\Documents\Visual Studio 2008\Projects\Hospital Ward Management System\HOSPITALSYSTEM.mdb;")
        Con.Open()
        objCmd = New OleDbCommand(strSQL, Con)
        objCmd.ExecuteNonQuery()
        Con.Close()
        Me.Hide()
        frmClinicForm.Show()
        
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        txtSurname.Text = ""
        txtOther.Text = ""
        txtAge.Text = ""
        txtSex.Text = ""
        txtContactNo.Text = ""
        txtAdress.Text = ""
        txtInfor.Text = ""
        txtRelation.Text = ""
        txtRaletionNo.Text = ""
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Dim strSQL As String
        Dim objCmd As New OleDbCommand
        strSQL = "INSERT INTO Admission(Sur_Name, Other_Names, F_Age, F_Sex,Contact_No, Contact_Address, Relations_Infor, Relations_Name,Relations_No)"
        strSQL = strSQL & "VALUES('" & (txtSurname.Text) & "', '" & (txtOther.Text) & "', '" & (txtAge.Text) & "', '" & (txtSex.Text) & "','" & (txtContactNo.Text) & "', '" & (txtAdress.Text) & "', '" & (txtInfor.Text) & "', '" & (txtRelation.Text) & "', '" & (txtRaletionNo.Text) & "');"
        Dim Con = New OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.3.51;Data Source=C:\Users\eee p\Documents\Visual Studio 2008\Projects\Hospital Ward Management System\HOSPITALSYSTEM.mdb;")
        Con.Open()
        objCmd = New OleDbCommand(strSQL, Con)
        objCmd.ExecuteNonQuery()
        Con.Close()
        Me.Hide()
        frmClinicForm.Show()
    End Sub

    Private Sub ResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem.Click
        txtSurname.Text = ""
        txtOther.Text = ""
        txtAge.Text = ""
        txtSex.Text = ""
        txtContactNo.Text = ""
        txtAdress.Text = ""
        txtInfor.Text = ""
        txtRelation.Text = ""
        txtRaletionNo.Text = ""
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub HomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click
        Me.Hide()
        frmHome.Show()
    End Sub
End Class
