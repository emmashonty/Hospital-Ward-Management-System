Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class frmDischargePatientList
    Dim myDA As OleDbDataAdapter
    Dim myDataSet As DataSet
    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Dim con As OleDbConnection = New OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.3.51;Data Source=C:\Users\eee p\Documents\Visual Studio 2008\Projects\Hospital Ward Management System\HOSPITALSYSTEM.mdb;")
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM Inpatient_Discharge ", con)

        con.Open()

        myDA = New OleDbDataAdapter(cmd)

        'Here one CommandBuilder object is required.

        'It will automatically generate DeleteCommand,UpdateCommand and InsertCommand for DataAdapter object

        Dim builder As OleDbCommandBuilder = New OleDbCommandBuilder(myDA)

        myDataSet = New DataSet()

        myDA.Fill(myDataSet, "MyTable")

        DataGridView1.DataSource = myDataSet.Tables("MyTable").DefaultView

        con.Close()

        con = Nothing
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub HomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click
        Me.Hide()
        frmHome.Show()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        Dim AB As New PrintDialog
        Try
            AB.ShowDialog()
            DataGridView1.Text = AB.PrintToFile
           
        Catch ex As Exception
            'Again, do nothing on exception
        End Try
    End Sub

    Private Sub FileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub MaternityWardBillToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaternityWardBillToolStripMenuItem.Click
        Dim con As OleDbConnection = New OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.3.51;Data Source=C:\Users\eee p\Documents\Visual Studio 2008\Projects\Hospital Ward Management System\HOSPITALSYSTEM.mdb;")
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM Medical_Bill ", con)

        con.Open()

        myDA = New OleDbDataAdapter(cmd)

        'Here one CommandBuilder object is required.

        'It will automatically generate DeleteCommand,UpdateCommand and InsertCommand for DataAdapter object

        Dim builder As OleDbCommandBuilder = New OleDbCommandBuilder(myDA)

        myDataSet = New DataSet()

        myDA.Fill(myDataSet, "MyTable")

        DataGridView1.DataSource = myDataSet.Tables("MyTable").DefaultView

        con.Close()

        con = Nothing
    End Sub

    Private Sub MedicalWardBillToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MedicalWardBillToolStripMenuItem.Click
        Dim con As OleDbConnection = New OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.3.51;Data Source=C:\Users\eee p\Documents\Visual Studio 2008\Projects\Hospital Ward Management System\HOSPITALSYSTEM.mdb;")
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM Medical_ward ", con)

        con.Open()

        myDA = New OleDbDataAdapter(cmd)

        'Here one CommandBuilder object is required.

        'It will automatically generate DeleteCommand,UpdateCommand and InsertCommand for DataAdapter object

        Dim builder As OleDbCommandBuilder = New OleDbCommandBuilder(myDA)

        myDataSet = New DataSet()

        myDA.Fill(myDataSet, "MyTable")

        DataGridView1.DataSource = myDataSet.Tables("MyTable").DefaultView

        con.Close()

        con = Nothing
    End Sub

    Private Sub SurgicalWardBillToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SurgicalWardBillToolStripMenuItem.Click
        Dim con As OleDbConnection = New OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.3.51;Data Source=C:\Users\eee p\Documents\Visual Studio 2008\Projects\Hospital Ward Management System\HOSPITALSYSTEM.mdb;")
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM Surgical_Ward ", con)

        con.Open()

        myDA = New OleDbDataAdapter(cmd)

        'Here one CommandBuilder object is required.

        'It will automatically generate DeleteCommand,UpdateCommand and InsertCommand for DataAdapter object

        Dim builder As OleDbCommandBuilder = New OleDbCommandBuilder(myDA)

        myDataSet = New DataSet()

        myDA.Fill(myDataSet, "MyTable")

        DataGridView1.DataSource = myDataSet.Tables("MyTable").DefaultView

        con.Close()

        con = Nothing
    End Sub

    Private Sub PediatricWardBillToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PediatricWardBillToolStripMenuItem.Click
        Dim con As OleDbConnection = New OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.3.51;Data Source=C:\Users\eee p\Documents\Visual Studio 2008\Projects\Hospital Ward Management System\HOSPITALSYSTEM.mdb;")
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM Pediatric_Bill ", con)

        con.Open()

        myDA = New OleDbDataAdapter(cmd)

        'Here one CommandBuilder object is required.

        'It will automatically generate DeleteCommand,UpdateCommand and InsertCommand for DataAdapter object

        Dim builder As OleDbCommandBuilder = New OleDbCommandBuilder(myDA)

        myDataSet = New DataSet()

        myDA.Fill(myDataSet, "MyTable")

        DataGridView1.DataSource = myDataSet.Tables("MyTable").DefaultView

        con.Close()

        con = Nothing
    End Sub
End Class