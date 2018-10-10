Public Class frmProfileDB



    Private Const CATEGORY_FPS As Byte = 0
    Private Const CATEGORY_ACTION As Byte = 1
    Private Const CATEGORY_MMO As Byte = 2
    Private Const CATEGORY_RPG As Byte = 3
    Private Const CATEGORY_STRATEGY As Byte = 4
    Private Const CATEGORY_SOFTWARE As Byte = 5
    Private ProfileListData(0 To 255) As Integer
    Private ProfileC As Integer
    Private Shared DLProfileIndex As Integer


    Private DL As New System.Net.WebClient


    Private Sub frmProfileDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AddHandler DL.DownloadProgressChanged, AddressOf DownloadProgress
        AddHandler DL.DownloadFileCompleted, AddressOf DownloadComplete

        Call ReadDB()
    End Sub
    Private Shared Sub DownloadProgress(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs)

    End Sub
    Private Shared Sub DownloadComplete(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)

        TempMaxProfiles = TempMaxProfiles + 1

        If System.IO.Directory.Exists(ProfilesDir & "\CAP Profiles") = False Then
            System.IO.Directory.CreateDirectory(ProfilesDir & "\CAP Profiles")
        End If

        System.IO.File.Move(Application.StartupPath & "\" & PDB(DLProfileIndex).ProfileName & ".pr0", ProfilesDir & "\CAP Profiles\" & PDB(DLProfileIndex).ProfileName & ".pr0")

        TempProfiles(TempMaxProfiles).ProfilePath = ProfilesDir & "\CAP Profiles\" & PDB(DLProfileIndex).ProfileName & ".pr0"


        ' If System.IO.File.Exists(ProfilesDir & "\" & cbProfiles.SelectedItem) Then
        frmProfilesSettings.cmdEditProfile.Enabled = True


        Call LoadProfileList()
        Call ReloadTempProfileList()


        frmProfilesSettings.lstProfiles.SelectedIndex = TempMaxProfiles - 1
        frmProfilesSettings.lstProcesses.Items.Add(PDB(DLProfileIndex).ProfileProcess)

        If frmProfilesSettings.lstProcesses.Items.Count > 1 Then
            If frmProfilesSettings.lstProcesses.Items.Item(0) = "" Then frmProfilesSettings.lstProcesses.Items.RemoveAt(0)
        End If


        Call frmProfilesSettings.MakeProcessList(SelectedProfile)

        Call MsgBox("Profile '" & PDB(DLProfileIndex).ProfileName & "' Download Complete and has been added into your profile settings.", vbInformation)

    End Sub

    Private Sub lstCategorys_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCategorys.SelectedIndexChanged
        Dim i As Integer, y As Integer

        If lstCategorys.SelectedIndex >= 0 Then
            lstProfiles.Enabled = True
            lstProfiles.Items.Clear()
            lstDevices.Items.Clear()
            rtbDescription.Text = ""
            ProfileC = 0

            For i = 0 To PROFILECOUNT

                If PDB(i).ProfileName <> "" Then
                    If PDB(i).ProfileCategory = lstCategorys.SelectedIndex Then
                        lstProfiles.Items.Add(PDB(i).ProfileName)


                    End If

                Else

                    Exit For
                End If


            Next

            For i = 0 To lstProfiles.Items.Count - 1

                For y = 0 To PROFILECOUNT

                    If lstProfiles.Items.Item(i) = PDB(y).ProfileName Then
                        ProfileListData(ProfileC) = y
                        ProfileC = ProfileC + 1
                        Exit For
                    End If

                Next

            Next


        Else
            lstProfiles.Items.Clear()
            lstProfiles.Enabled = False
            ProfileC = 0
        End If

    End Sub

    Private Sub lstProfiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProfiles.SelectedIndexChanged
        If lstProfiles.SelectedIndex >= 0 Then
            Dim Array As String()
            Dim i As Byte

            lstDevices.Items.Clear()
            rtbDescription.Text = ""

            Array = Split(PDB(ProfileListData(lstProfiles.SelectedIndex)).ProfileDevices, ",")

            For i = 0 To Array.Length - 1
                lstDevices.Items.Add(Array(i))
            Next

            If PDB(ProfileListData(lstProfiles.SelectedIndex)).ProfileDescription <> "" Then
                wbReadURL.Navigate(New Uri(PDB(ProfileListData(lstProfiles.SelectedIndex)).ProfileDescription))
            Else
                rtbDescription.Text = "There is no description for the '" & PDB(ProfileListData(lstProfiles.SelectedIndex)).ProfileName & "' profile."
            End If

            If PDB(ProfileListData(lstProfiles.SelectedIndex)).ProfileDownload <> "" Then

            End If

        End If
    End Sub

    Private Sub wbReadURL_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles wbReadURL.DocumentCompleted
        Dim Description As String

        If wbReadURL.DocumentText.Length > 20 Then
            Description = Mid(wbReadURL.DocumentText, InStr(wbReadURL.DocumentText, "<SPD>") + 6, InStrRev(wbReadURL.DocumentText, "<EPD>") - 7 - InStr(wbReadURL.DocumentText, "<SPD>"))
            rtbDescription.Text = Description
        End If
    End Sub

    Private Sub cmdDownload_Click(sender As Object, e As EventArgs) Handles cmdDownload.Click
        DLProfileIndex = ProfileListData(lstProfiles.SelectedIndex)

        If System.IO.File.Exists(ProfilesDir & "\CAP Profiles\" & PDB(DLProfileIndex).ProfileName & ".pr0") = True Then
            DLProfileIndex = 0
            Call MsgBox("You already have this profile downloaded!", vbCritical)
            Exit Sub
        End If

        If PDB(DLProfileIndex).ProfileDownload <> "" Then
            DL.DownloadFileAsync(New Uri(PDB(DLProfileIndex).ProfileDownload), PDB(DLProfileIndex).ProfileName & ".pr0")
            cmdDownload.Enabled = False
        Else
            Call MsgBox("No download link found! Please report to CyborgAutoProfiler@gmail.com")
        End If

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Dispose()
    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub
End Class