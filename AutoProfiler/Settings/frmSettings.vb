Public Class frmSettings


    Private TT As New ToolTip()

    Private Sub txtPPath_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmSettings_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Call ShowSystemTrayOptions(True)
    End Sub

    Private Sub frmSettings_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        If WasEnabled = True Then
            Call SetCheckerStatus(True)
            WasEnabled = False
        End If

        Call ShowSystemTrayOptions(True)
    End Sub

    Private Sub frmSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TT.InitialDelay = 1000
        TT.SetToolTip(rbProcess, "This mode simply selects profiles by if the set process is running and works through priority on the Profiles list.")
        TT.SetToolTip(rbAW, "(Recommended) This mode swaps profiles depending on your current active window associated with a process. This is great for swapping between programs quickly.")
        TT.SetToolTip(rbCursor, "This mode will change the profiles by the software the mouses cursor is over.")
        TT.SetToolTip(valInterval, "This setting sets how many milliseconds need to pass before the detector checks again.")
        TT.SetToolTip(chkCFU, "(Recommended) This setting will enable the software to check if it is up to date.")
        TT.SetToolTip(chkAutoEnable, "This setting will automatically enable the software when it is launched.")
        TT.SetToolTip(chkStartup, "This setting will make the software start with the computer.")
        TT.SetToolTip(chkRDC, "This setting makes it so if you change the DPI mode while using a profile it will remember the change and keep it if it swaps back to the profile.")
        TT.SetToolTip(chkHotKey, "This is the control setting for the Hot Key feature. Simply check this box if you would like to enable this feature.")
        TT.SetToolTip(chkBTPC, "This setting effects if you would like the System tray icon to show a message when the profile is changed.")
        TT.SetToolTip(chkClearProfile, "This setting if enabled will clear the profiles on the devices if no process is detected. Default Profile will be disabled if used.")


        Call ShowSettings()

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim OldPD As String

        OldPD = ProfilesDir
        'PPath = txtPPath.Text

        ProfilesDir = txtProfileDest.Text

        CheckTime = valInterval.Value
        frmAutoProfiler.tmrAPCheck.Interval = CheckTime

        'Setting for Auto Enable at start
        If chkAutoEnable.Checked = True Then
            AutoEnable = 1
        Else
            AutoEnable = 0
        End If

        'Setting for Clear Profile
        If chkClearProfile.Checked = True Then
            ClearProfile = 1
            DefaultProfile = 0
        Else
            ClearProfile = 0
        End If


        'Setting for Show Profile Change in balloon tip
        If chkBTPC.Checked = True Then
            ShowTrayProfileChange = 1
        Else
            ShowTrayProfileChange = 0
        End If



        If rbProcess.Checked = True Then
            DetectionType = 0
        ElseIf rbAW.Checked = True Then
            DetectionType = 1
        ElseIf rbCursor.Checked = True Then
            DetectionType = 2
        End If

        If chkRDC.Checked = True Then
            RATRemeberDPIChange = 1
        Else
            RATRemeberDPIChange = 0
        End If

        If chkHotKey.Checked = True Then
            HotKeyEnabled = 1
            frmAutoProfiler.tmrHotKey.Enabled = True
            frmAutoProfiler.tsmHotKey.Text = "              Disable Hot Key"
            frmAutoProfiler.tsmHotKey.ForeColor = Color.Red
        Else
            HotKeyEnabled = 0
            frmAutoProfiler.tmrHotKey.Enabled = False
            frmAutoProfiler.tsmHotKey.Text = "              Enable Hot Key"
            frmAutoProfiler.tsmHotKey.ForeColor = Color.Green
        End If


        'Start with windows
        If IsAdmin() = True Then
            If chkStartup.Checked = True Then
                My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue("CyborgAutoProfiler", Chr(34) & Application.ExecutablePath & Chr(34) & " -minimize", Microsoft.Win32.RegistryValueKind.String)
                My.Computer.Registry.LocalMachine.Close()
            ElseIf chkStartup.Checked = False Then
                If Not My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", False).GetValue("CyborgAutoProfiler") = Nothing Then
                    My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue("CyborgAutoProfiler")
                    My.Computer.Registry.LocalMachine.Close()
                End If
            End If
        End If



        Call SaveSettings()

        If OldPD <> ProfilesDir Then
            Call frmAutoProfiler.ListSystemTrayProfiles()
        End If

        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Dispose()
    End Sub

    Private Sub chkStartup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkStartup.CheckedChanged

    End Sub


    Private Sub cmdPDBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPDBrowse.Click
        Using dialog As New FolderBrowserDialog
            If dialog.ShowDialog() <> DialogResult.OK Then Return
            txtProfileDest.Text = dialog.SelectedPath
        End Using
    End Sub

    Private Sub chkAutoEnable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAutoEnable.CheckedChanged

    End Sub

    Private Sub cmdDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDefault.Click

        If MsgBox("Are you sure you want to set the default settings?", vbYesNo) = MsgBoxResult.Yes Then
            chkAutoEnable.Checked = False
            chkCFU.Checked = True
            chkBTPC.Checked = True

            'txtPPath.Text = "C:\Program Files\SmartTechnology"

            If System.IO.Directory.Exists(DocPath & "\SmartTechnology Profiles") Then
                txtProfileDest.Text = DocPath & "\SmartTechnology Profiles"
            Else
                txtProfileDest.Text = DocPath & "\Saitek SD6 Profiles"
            End If

            rbAW.Checked = True
            chkRDC.Checked = False
            chkHotKey.Checked = False

            valInterval.Value = 1000

        End If
    End Sub

    Private Sub ShowSettings()

        If IsBeta = True Then
            lblVersion.Text = CurrentVersion & " BETA"
        Else
            lblVersion.Text = CurrentVersion
        End If



        'txtPPath.Text = PPath
        txtProfileDest.Text = ProfilesDir
        valInterval.Value = CheckTime


        If My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", False).GetValue("CyborgAutoProfiler") = Nothing Then
            chkStartup.Checked = False
        Else
            chkStartup.Checked = True
        End If


        If AutoEnable = 1 Then
            chkAutoEnable.Checked = True
        Else
            chkAutoEnable.Checked = False
        End If

        If CheckforUpdate = 1 Then
            chkCFU.Checked = True
        Else
            chkCFU.Checked = False

        End If

        If ShowTrayProfileChange = 1 Then
            chkBTPC.Checked = True
        Else
            chkBTPC.Checked = False
        End If

        If DetectionType = 0 Then
            rbProcess.Checked = True
        ElseIf DetectionType = 1 Then
            rbAW.Checked = True
        ElseIf DetectionType = 2 Then
            rbCursor.Checked = True
        End If

        If RATRemeberDPIChange = 1 Then
            chkRDC.Checked = True
        Else
            chkRDC.Checked = False
        End If

        If ClearProfile = 0 Then
            chkClearProfile.Checked = False
        Else
            chkClearProfile.Checked = True
        End If

    End Sub

    Private Sub chkStartup_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkStartup.Click
        If IsAdmin() = False Then

            If My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", False).GetValue("CyborgAutoProfiler") = Nothing Then
                chkStartup.Checked = False
            Else
                chkStartup.Checked = True
            End If

            Call MsgBox("You require administrator access to configure this software to boot with windows! Please open this software with Administrator access and try again!", vbExclamation)
        End If
    End Sub

    Private Sub txtProfileDest_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProfileDest.TextChanged

    End Sub

    Private Sub rbAW_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAW.CheckedChanged

    End Sub

    Private Sub rbAW_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbAW.Click
        If DetectionType = 0 Then
            valInterval.Value = 1000
        End If
    End Sub

    Private Sub valInterval_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles valInterval.ValueChanged

    End Sub

    Private Sub rbProcess_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbProcess.CheckedChanged

    End Sub

    Private Sub rbProcess_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbProcess.Click
        valInterval.Value = 5000
    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub rbCursor_CheckedChanged(sender As Object, e As EventArgs) Handles rbCursor.CheckedChanged
        valInterval.Value = 1000
    End Sub

    Private Sub chkCFU_CheckedChanged(sender As Object, e As EventArgs) Handles chkCFU.CheckedChanged

    End Sub

    Private Sub chkHotKey_CheckedChanged(sender As Object, e As EventArgs) Handles chkHotKey.CheckedChanged

    End Sub

    Private Sub frmSettings_RightToLeftLayoutChanged(sender As Object, e As EventArgs) Handles Me.RightToLeftLayoutChanged

    End Sub

    Private Sub cmdDI_Click(sender As Object, e As EventArgs) Handles cmdDI.Click
        frmDeviceInfo.ShowDialog()
    End Sub

    Private Sub chkRDC_CheckedChanged(sender As Object, e As EventArgs) Handles chkRDC.CheckedChanged

    End Sub
End Class