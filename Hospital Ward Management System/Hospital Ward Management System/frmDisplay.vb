Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class frmDisplay


    Private Sub HomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click
        Me.Hide()
        frmHome.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim SQL As String
        Dim dbConnection As OleDbConnection
        Dim dbCommand As New OleDbCommand
        Dim dbFilePath As String = "C:\Users\eee p\Documents\Visual Studio 2008\Projects\Hospital Ward Management System\HOSPITALSYSTEM.mdb;"
        SQL = "SELECT Sur_Name, Other_Names, F_Age, F_Sex, Contact_No,Contact_Address, Relations_Infor, Relations_Name, Relations_No FROM Admission"
        dbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dbFilePath)
        dbCommand = New OleDbCommand(SQL, dbConnection)
        Dim data As New OleDbDataAdapter(dbCommand)
        Dim table As New DataTable("Test")
        dbConnection.Open()
        data.Fill(table)
        txtSurname.Text = table.Rows(txtSerial.Text)("Sur_Name").ToString()
        txtOther.Text = table.Rows(txtSerial.Text)("Other_Names").ToString()
        txtAge.Text = table.Rows(txtSerial.Text)("F_Age").ToString()
        txtSex.Text = table.Rows(txtSerial.Text)("F_Sex").ToString()
        txtCNum.Text = table.Rows(txtSerial.Text)("Contact_No").ToString()
        txtCAdd.Text = table.Rows(txtSerial.Text)("Contact_Address").ToString()
        txtRInfo.Text = table.Rows(txtSerial.Text)("Relations_Infor").ToString()
        txtRNm.Text = table.Rows(txtSerial.Text)("Relations_Name").ToString()
        txtRNum.Text = table.Rows(txtSerial.Text)("Relations_No").ToString()

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim AB As New PrintDialog
        Try
            AB.ShowDialog()
            txtSurname.Text = AB.PrintToFile
            txtOther.Text = AB.PrintToFile
            txtAge.Text = AB.PrintToFile
            txtSex.Text = AB.PrintToFile
            txtCNum.Text = AB.PrintToFile
            txtCAdd.Text = AB.PrintToFile
            txtRInfo.Text = AB.PrintToFile
            txtRNm.Text = AB.PrintToFile
            txtRNum.Text = AB.PrintToFile
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
            txtAge.Text = AB.PrintToFile
            txtSex.Text = AB.PrintToFile
            txtCNum.Text = AB.PrintToFile
            txtCAdd.Text = AB.PrintToFile
            txtRInfo.Text = AB.PrintToFile
            txtRNm.Text = AB.PrintToFile
            txtRNum.Text = AB.PrintToFile
        Catch ex As Exception
            'Again, do nothing on exception
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        txtSerial.Text = ""
        txtPWard.Text = ""
    End Sub
End Class