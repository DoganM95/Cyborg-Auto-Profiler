Public Class frmDBManager

    Private Sub frmDBManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ReadDB()
        Call LoadProfileDBList()
    End Sub

    Private Sub cmdAddProfile_Click(sender As Object, e As EventArgs) Handles cmdAddProfile.Click
        lstProfiles.Items.Add("New Profile")
    End Sub

    Private Sub cmdRemoveProfile_Click(sender As Object, e As EventArgs) Handles cmdRemoveProfile.Click
        If lstProfiles.SelectedIndex >= 0 Then
            lstProfiles.Items.RemoveAt(lstProfiles.SelectedIndex)
        End If
    End Sub
    Public Sub LoadProfileDBList()
        Dim i As Integer

        For i = 0 To PROFILECOUNT
            If PDB(i).ProfileName <> "" Then
                lstProfiles.Items.Add(PDB(i).ProfileName)
            Else
                Exit Sub
            End If
        Next
    End Sub
    Private Sub cmdSetProfile_Click(sender As Object, e As EventArgs) Handles cmdSetProfile.Click
        If lstProfiles.SelectedIndex < 0 Then Exit Sub


        PDB(lstProfiles.SelectedIndex).ProfileName = txtProfileName.Text
        PDB(lstProfiles.SelectedIndex).ProfileProcess = txtProcessName.Text
        PDB(lstProfiles.SelectedIndex).ProfileDownload = txtProfileDownload.Text
        PDB(lstProfiles.SelectedIndex).ProfileDevices = txtProfileDevices.Text
        PDB(lstProfiles.SelectedIndex).ProfileDescription = txtDescription.Text
        PDB(lstProfiles.SelectedIndex).ProfileCategory = txtProfileCategory.Text

        lstProfiles.Items.Item(lstProfiles.SelectedIndex) = txtProfileName.Text
    End Sub

    Private Sub lstProfiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProfiles.SelectedIndexChanged
        If lstProfiles.SelectedIndex >= 0 Then
            txtProfileName.Text = PDB(lstProfiles.SelectedIndex).ProfileName
            txtProcessName.Text = PDB(lstProfiles.SelectedIndex).ProfileProcess
            txtProfileDownload.Text = PDB(lstProfiles.SelectedIndex).ProfileDownload
            txtProfileDevices.Text = PDB(lstProfiles.SelectedIndex).ProfileDevices
            txtDescription.Text = PDB(lstProfiles.SelectedIndex).ProfileDescription
            txtProfileCategory.Text = PDB(lstProfiles.SelectedIndex).ProfileCategory
        End If
    End Sub

    Private Sub cmdSaveDB_Click(sender As Object, e As EventArgs) Handles cmdSaveDB.Click
        Call SaveDB()
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Dispose()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class