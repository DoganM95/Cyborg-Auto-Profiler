Public Class frmAddProfile

    Private Sub cmdCancelAdd_Click(sender As Object, e As EventArgs) Handles cmdCancelAdd.Click
        Me.Close()
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click


        TempMaxProfiles = TempMaxProfiles + 1




        TempProfiles(TempMaxProfiles).ProfilePath = ProfilesDir & "\" & cbProfiles.SelectedItem


        ' If System.IO.File.Exists(ProfilesDir & "\" & cbProfiles.SelectedItem) Then
        frmProfilesSettings.cmdEditProfile.Enabled = True

        ' If TempDefaultProfile = SelectedProfile Then
        'lstProfiles.Items.Item(lstProfiles.SelectedIndex) = cbProfiles.SelectedItem & " (Default)"
        ' Else
        'lstProfiles.Items.Item(lstProfiles.SelectedIndex) = cbProfiles.SelectedItem
        ' End If

        Call LoadProfileList()
        Call ReloadTempProfileList()

        frmProfilesSettings.lstProfiles.SelectedIndex = TempMaxProfiles - 1

        Me.Close()
    End Sub

    Private Sub cbProfiles_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If cbProfiles.SelectedItem <> "No Profiles" Then
            cmdAdd.Enabled = True
        Else
            cmdAdd.Enabled = False
        End If
    End Sub

    Private Sub frmAddProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)

    End Sub
End Class