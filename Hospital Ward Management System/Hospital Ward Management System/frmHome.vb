Public Class frmHome

   
    Private Sub InpatientBillToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InpatientBillToolStripMenuItem.Click
        Me.Hide()
        frmMedicalWardBill.Show()
    End Sub

    Private Sub MaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaToolStripMenuItem.Click
        Me.Hide()
        frmSurgicalWard.Show()
    End Sub

    Private Sub MaternityWardBillToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaternityWardBillToolStripMenuItem.Click
        Me.Hide()
        frmMaternityBillForm.Show()
    End Sub

    Private Sub SearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearToolStripMenuItem.Click
        Me.Hide()
        frmPatientAdmittedRecord.Show()
    End Sub

    Private Sub SearchDischargeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchDischargeToolStripMenuItem.Click
        Me.Hide()
        frmDischargePatientList.Show()
    End Sub

    Private Sub SearchOutcomeOFCareToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchOutcomeOFCareToolStripMenuItem.Click
        Me.Hide()
        frmDisplay.Show()
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Me.Hide()
        frmAdmission.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub DischargeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DischargeToolStripMenuItem.Click
        Me.Hide()
        frmDischargeForm.Show()
    End Sub

    Private Sub SearchDischargedPatientToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchDischargedPatientToolStripMenuItem.Click
        Me.Hide()
        frmSearchDischargedPatient.show()
    End Sub

    Private Sub PediatricWardBillToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PediatricWardBillToolStripMenuItem.Click
        Me.Hide()
        frmPediatricBill.Show()
    End Sub

    Private Sub NewMaternityDischargeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewMaternityDischargeToolStripMenuItem.Click
        frmMaternityForm.Show()
        Me.Hide()
    End Sub
End Class