Public Class frmProfilesSettings
    Private TickCount As Byte
    Private TT As New ToolTip()
    Private SelectedDPIMode As Byte



    Private Sub frmProfiles_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Call ShowSystemTrayOptions(True)
    End Sub

    Private Sub frmProfiles_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        If WasEnabled = True Then
            Call SetCheckerStatus(True)
            WasEnabled = False
        End If

        Call ShowSystemTrayOptions(True)
    End Sub

    Private Sub frmProfiles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TT.SetToolTip(chkDefaultP, "This will select the current profile highlighted to be the Default Profile. The default profile is loaded when no processes are detected.")
        TT.SetToolTip(tpDPIMode, "This setting will change the R.A.Ts DPI mode to the this setting when the profile is loaded.")
        TT.SetToolTip(tbMouseSpeed, "This setting will change the Windows Mouse Speed setting to this when the profile is loaded.")
        TT.SetToolTip(chkChangeMouseSpeed, "This setting will change the Windows Mouse Speed setting to this when the profile is loaded.")
        TT.SetToolTip(chkChangPrecisionPercent, "This setting will change the R.A.Ts Precision Aim Percentages to the custom settings here when the profile is loaded.")
        TT.SetToolTip(hsbPrecisionX, "This setting determines the percent the R.A.Ts Left/Right will be decreased when using Precision Aim.")
        TT.SetToolTip(hsbPrecisionY, "This setting determines the percent the R.A.Ts Up/Down will be decreased when using Precision Aim.")
        TT.SetToolTip(chkCLED, "This setting will change the M.M.O.7 LEDs to the custom colors when the profile is loaded.")
        TT.SetToolTip(cmdMoveUp, "This will move the currently selected profile up in priority in the profiles list. This is used for Process Detection Mode and Processes with specific Titles.")
        TT.SetToolTip(cmdMoveDown, "This will move the currently selected profile up in priority in the profiles list. This is used for Process Detection Mode and Processes with specific Titles.")
        TT.SetToolTip(chkFlow, "This setting will enable the Color Flow for the M.M.O.7 LEDs when the profile is loaded.")
        TT.SetToolTip(cmdFlowSettings, "This is the control panel for the M.M.O.7 Color Flow. This is a global setting and not profile specific.")

        cmdSave.Enabled = True
        cmdCancel.Enabled = True

        hsbDPIX.Maximum = RATMaxDPI
        hsbDPIY.Maximum = RATMaxDPI


        Call LoadScriptList()

    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click

        If tmrMouseSpeedPreview.Enabled = True Then
            tmrMouseSpeedPreview.Enabled = False
            SystemParametersInfo(SPI_SETMOUSESPEED, 0, DefaultMouseSpeed, SPIF_UPDATEINIFILE)
            cmdPreviewMS.Text = "Preview"
        End If

        Me.Dispose()
    End Sub

    Private Sub lstProfiles_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstProfiles.KeyDown
        If e.KeyCode = Keys.Delete Then
            If lstProfiles.SelectedIndex >= 0 Then
                Call cmdDelete_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub lstProfiles_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstProfiles.KeyPress


    End Sub

    Private Sub lstProfiles_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstProfiles.MouseDown

        If lstProfiles.IndexFromPoint(e.X, e.Y) >= 0 Then
            lstProfiles.SelectedIndex = lstProfiles.IndexFromPoint(e.X, e.Y)
            lstProfiles.ContextMenuStrip = cmProfiles
        Else
            lstProfiles.ContextMenuStrip = Nothing
        End If
    End Sub

    Private Sub lstProfiles_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstProfiles.SelectedIndexChanged
        Dim i As Byte, x As Byte
        Dim s() As String
        Dim C() As Integer

        SelectedProfile = lstProfiles.SelectedIndex + 1


        If SelectedProfile >= 1 Then
            lstProcesses.Enabled = True
            cmdAddP.Enabled = True
            cmdRemoveP.Enabled = False
            cmdDelete.Enabled = True
            cmdEditProfile.Enabled = True
            cmdPCLeft.Enabled = True
            cmdPCRight.Enabled = True
            chkDefaultP.Enabled = True
            chkCLED.Enabled = True
            lstProcesses.AllowDrop = True
            cmdEditHotKey.Enabled = False
            cmdRemoveHotKey.Enabled = False
            cbSCaps.Enabled = True
            cbSNum.Enabled = True
            cbSScroll.Enabled = True
            tcMisc.Enabled = True
            txtHotKey.Text = "No Key"
            cbScript.Enabled = True
            chkLock.Enabled = True

            If GetProfileLongestMacro(TempProfiles(SelectedProfile).ProfilePath) > 0 Then
                lblBSoD.Text = "BSoD Protection may be needed to prevent the profile" & vbNewLine & "from changing during a macro."
                lblBSoD.ForeColor = Color.Red
                chkBSoD.Enabled = True
            Else
                lblBSoD.Text = "No need for BSoD Protection."
                lblBSoD.ForeColor = Color.Black
                chkBSoD.Enabled = False
            End If


            If TempDefaultProfile <> SelectedProfile Then
                chkDefaultP.Checked = False
                lstProcesses.Enabled = True
                cmdAddP.Enabled = True
                lstProcesses.AllowDrop = True
                'cmdRemoveP.Enabled = True
                cmdEditHotKey.Enabled = True
                cmdRemoveHotKey.Enabled = True
            Else
                chkDefaultP.Checked = True
                lstProcesses.Items.Clear()
                lstProcesses.Enabled = False
                cmdAddP.Enabled = False
                lstProcesses.AllowDrop = False
                cmdRemoveP.Enabled = False
                cmdEditHotKey.Enabled = True
                cmdRemoveHotKey.Enabled = True
                chkLock.Checked = False
                chkLock.Enabled = False


            End If

            If System.IO.File.Exists(TempProfiles(SelectedProfile).ProfilePath) Then
                cmdEditProfile.Enabled = True
            Else
                cmdEditProfile.Enabled = False
            End If

            If lstProfiles.SelectedIndex > 0 Then
                cmdMoveUp.Enabled = True
            Else
                cmdMoveUp.Enabled = False
            End If

            If lstProfiles.SelectedIndex < TempMaxProfiles - 1 Then
                cmdMoveDown.Enabled = True
            Else
                cmdMoveDown.Enabled = False
            End If


            ' Load the Lock Settings
            C = GetProfileSettings(TempProfiles(SelectedProfile).Settings)

            If C(0) >= 0 Then
                cbSCaps.SelectedIndex = C(0)
            End If

            If C(1) >= 0 Then
                cbSNum.SelectedIndex = C(1)
            End If

            If C(2) >= 0 Then
                cbSScroll.SelectedIndex = C(2)
            End If


            ' Check the Hot Key Setting
            If C(3) > 0 Then
                Dim K As KeyEventArgs

                K = New KeyEventArgs(C(3))

                If C(4) > 0 Then
                    txtHotKey.Text = K.KeyCode.ToString
                    K = New KeyEventArgs(C(4))
                    txtHotKey.Text = txtHotKey.Text & "+" & K.KeyCode.ToString

                Else

                    txtHotKey.Text = K.KeyCode.ToString
                End If


            Else
                txtHotKey.Text = "No Key"
            End If

            If C(5) > 0 Then
                chkChangeMouseSpeed.Checked = True
                tbMouseSpeed.Enabled = True
                tbMouseSpeed.Value = C(5)
                cmdPreviewMS.Enabled = True
            Else
                chkChangeMouseSpeed.Checked = False
                tbMouseSpeed.Enabled = False
                tbMouseSpeed.Value = 10
                cmdPreviewMS.Enabled = False
            End If

            ' Check for the Lock Profile Setting

            If C(6) = 0 Then
                chkLock.Checked = False
            Else
                chkLock.Checked = True
            End If

            ' Check for BSoD Protection
            If C(7) = 0 Then
                chkBSoD.Checked = False
            Else
                chkBSoD.Checked = True
            End If


            ' Check for the Script Settings.
            If TempProfiles(SelectedProfile).Script <> "None" And TempProfiles(SelectedProfile).Script <> "" Then
                cbScript.SelectedItem = TempProfiles(SelectedProfile).Script
            Else
                cbScript.SelectedIndex = 0
            End If


            ' Load the Custom RAT Settings

            If HasRAT = True Then

                rbDPI1.Enabled = True
                rbDPI2.Enabled = True
                rbDPI3.Enabled = True
                rbDPI4.Enabled = True
                hsbDPIX.Enabled = True
                hsbDPIY.Enabled = True
                chkCDPI.Enabled = True
                tcMMO7.Enabled = True

                C = GetRATCSettings(TempProfiles(SelectedProfile).RATCS)

                If HasMMO7 = True Then

                    'Check for LED Settings
                    If C(0) = 1 Then
                        chkFlow.Enabled = False
                        chkFlow.Checked = False
                        chkCLED.Checked = True
                        cmdPCLeft.Enabled = True
                        cmdPCRight.Enabled = True
                        cmdCopyLeft.Enabled = True
                        cmdCopyRight.Enabled = True

                        pbCPLeft.BackColor = Color.FromArgb(C(1), C(2), C(3))
                        pbCPRight.BackColor = Color.FromArgb(C(4), C(5), C(6))
                    Else
                        chkFlow.Enabled = True

                        chkCLED.Checked = False
                        cmdPCLeft.Enabled = False
                        cmdPCRight.Enabled = False
                        cmdCopyLeft.Enabled = False
                        cmdCopyRight.Enabled = False

                        pbCPLeft.BackColor = Color.Black
                        pbCPRight.BackColor = Color.Black
                    End If

                    'Check for Flow Setting
                    If C(11) = 1 Then
                        chkFlow.Checked = True
                        chkCLED.Enabled = False
                    Else
                        chkFlow.Checked = False
                        chkCLED.Enabled = True
                    End If

                Else
                    chkCLED.Checked = False
                    cmdPCLeft.Enabled = False
                    cmdPCRight.Enabled = False
                    cmdCopyLeft.Enabled = False
                    cmdCopyRight.Enabled = False

                    pbCPLeft.BackColor = Color.Black
                    pbCPRight.BackColor = Color.Black
                End If


                If C(7) = 0 Then
                    tbDPI.Value = 0

                ElseIf C(7) > 0 And C(7) < 5 Then

                    tbDPI.Value = C(7)

                End If

                'Check for the Precision Aim Settings
                If HasRAT3 = False Then
                    chkChangPrecisionPercent.Enabled = True
                    hsbPrecisionX.Enabled = True
                    hsbPrecisionY.Enabled = True

                    If C(8) = 1 Then

                        chkChangPrecisionPercent.Checked = True

                        hsbPrecisionX.Value = C(9)
                        hsbPrecisionY.Value = C(10)

                    Else
                        chkChangPrecisionPercent.Checked = False

                        hsbPrecisionX.Value = 0
                        hsbPrecisionY.Value = 0
                    End If
                Else
                    chkChangPrecisionPercent.Enabled = False
                    hsbPrecisionX.Enabled = False
                    hsbPrecisionY.Enabled = False
                End If

                ' DPI Settings
                If C(12) = 1 Then
                    chkCDPI.Checked = True
                    rbDPI1.Enabled = True
                    rbDPI2.Enabled = True
                    rbDPI3.Enabled = True
                    rbDPI4.Enabled = True
                    hsbDPIX.Enabled = True
                    hsbDPIY.Enabled = True

                    rbDPI1.Checked = True
                    rbDPI2.Checked = False
                    rbDPI3.Checked = False
                    rbDPI4.Checked = False


                    hsbDPIX.Value = C(13)
                    hsbDPIY.Value = C(14)
                Else
                    chkCDPI.Checked = False
                    rbDPI1.Enabled = False
                    rbDPI2.Enabled = False
                    rbDPI3.Enabled = False
                    rbDPI4.Enabled = False
                    hsbDPIX.Enabled = False
                    hsbDPIY.Enabled = False
                End If




                Call UpdateDPIDisplay()

            Else
                tcMMO7.Enabled = False
            End If

            ' Check if we need to disable Default Profile for 'Clear Profile' setting
            If ClearProfile = 1 Then
                chkDefaultP.Enabled = False
            Else
                chkDefaultP.Enabled = True
            End If


        ElseIf SelectedProfile <= 0 Then
            lstProcesses.Enabled = False
            cmdAddP.Enabled = False
            cmdRemoveP.Enabled = False
            cmdDelete.Enabled = False
            cmdEditProfile.Enabled = False
            cmdMoveDown.Enabled = False
            cmdMoveUp.Enabled = False
            cmdPCLeft.Enabled = False
            cmdPCRight.Enabled = False
            chkDefaultP.Enabled = False
            chkCLED.Enabled = False
            tcMMO7.Enabled = False
            cbSCaps.Enabled = False
            cbSNum.Enabled = False
            cbSScroll.Enabled = False
            tcMisc.Enabled = False
            lstProcesses.AllowDrop = False
            cbScript.Enabled = False
            rbDPI1.Enabled = False
            rbDPI2.Enabled = False
            rbDPI3.Enabled = False
            rbDPI4.Enabled = False
            hsbDPIX.Enabled = False
            hsbDPIY.Enabled = False
            chkCDPI.Enabled = False
            chkLock.Enabled = False
            chkBSoD.Enabled = False
            lblBSoD.Text = "No need for BSoD Protection."
            lblBSoD.ForeColor = Color.Black
            chkChangPrecisionPercent.Enabled = False
            hsbPrecisionX.Enabled = False
            hsbPrecisionY.Enabled = False

        End If




        lstProcesses.Items.Clear()

        s = Split(TempProfiles(SelectedProfile).ProcessName, "�")

        If s.Count = 0 Then
            x = 0
        Else
            x = s.Count - 1
        End If

        For i = 0 To x
            lstProcesses.Items.Add(s(i))
        Next








    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim i As Byte

        cmdSave.Enabled = False
        cmdCancel.Enabled = False
        'Lets check for errors first!

        If tmrMouseSpeedPreview.Enabled = True Then
            tmrMouseSpeedPreview.Enabled = False
            SystemParametersInfo(SPI_SETMOUSESPEED, 0, DefaultMouseSpeed, SPIF_UPDATEINIFILE)
            cmdPreviewMS.Text = "Preview"
        End If


        For i = 1 To TempMaxProfiles

            If TempProfiles(i).ProfilePath = "New Profile" Then
                Call MsgBox("Profile " & i & " does not have a profile set!", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If System.IO.File.Exists(TempProfiles(i).ProfilePath) = False Then
                Call MsgBox("Profile " & i & " cannot locate a profile named " & TempProfiles(i).ProfilePath & "!", MsgBoxStyle.Critical)
                Exit Sub
            End If

            'If i <> TempDefaultProfile Then
            '    If TempProfiles(i).ProcessName = "" Then
            '        Call MsgBox("Profile '" & TempProfiles(i).ProfilePath & "' does not have a process set!", MsgBoxStyle.Critical)
            '        Exit Sub

            '    End If
            'End If

        Next

        Call SaveTempProfiles()

        lstProfiles.SelectedIndex = -1

        If HotKeyEnabled = 1 Then
            frmAutoProfiler.tmrHotKey.Enabled = True
        End If

        Me.Close()
    End Sub


    Private Sub chkDefaultP_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkDefaultP.Click
        Dim i As Byte

        If chkDefaultP.Checked = True Then
            TempDefaultProfile = SelectedProfile

            lstProcesses.Items.Clear()
            lstProcesses.Enabled = False
            cmdAddP.Enabled = False
            cmdRemoveP.Enabled = False
            chkLock.Checked = False
            chkLock.Enabled = False
            Call SetProfileSettings(6, SelectedProfile, 0, True)

            Call ReloadTempProfileList()
            lstProfiles.SelectedIndex = TempDefaultProfile - 1
        Else
            i = lstProfiles.SelectedIndex
            TempDefaultProfile = 0
            Call ReloadTempProfileList()
            lstProfiles.SelectedIndex = i
            chkLock.Enabled = True
        End If


    End Sub

    Private Sub cmdAP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAP.Click
        frmAddProfile.ShowDialog()

    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim I As Byte
        Dim Y As Byte
        Dim DeleteName As String

        DeleteName = TempProfiles(SelectedProfile).ProfilePath

        If MsgBox("Are you sure you want to remove '" & DeleteName & "'?", MsgBoxStyle.YesNo, "Remove Profile?") = vbYes Then

            ' If TempMaxProfiles = 1 Then
            ' Call MsgBox("You cannot delete your only profile!", vbCritical)
            'Exit Sub
            'End If

            Y = SelectedProfile

            If TempDefaultProfile = Y Then TempDefaultProfile = 0

            For I = Y To TempMaxProfiles - 1
                TempProfiles(I).ProfilePath = TempProfiles(I + 1).ProfilePath
                TempProfiles(I).ProcessName = TempProfiles(I + 1).ProcessName
                TempProfiles(I).Settings = TempProfiles(I + 1).Settings
                TempProfiles(I).RATCS = TempProfiles(I + 1).RATCS

                If TempDefaultProfile = I + 1 Then TempDefaultProfile = I
            Next

            TempProfiles(TempMaxProfiles).ProfilePath = ""
            TempProfiles(TempMaxProfiles).ProcessName = ""


            TempMaxProfiles = TempMaxProfiles - 1



            Call ReloadTempProfileList()
            Call LoadProfileList()

            If TempMaxProfiles = 0 Then
                lstProfiles.SelectedIndex = -1
                lstProcesses.Items.Clear()
                lstProcesses.Enabled = False
                cmdAddP.Enabled = False
                cmdRemoveP.Enabled = False
                cmdDelete.Enabled = False
                cmdEditProfile.Enabled = False
                chkDefaultP.Enabled = False
                chkRAT.Enabled = False
                chkKeyboard.Enabled = False
                chkGamepad.Enabled = False
                chkFLY.Enabled = False
                chkCCU.Enabled = False
                chkAllD.Enabled = False

            Else
                lstProfiles.SelectedIndex = 0
            End If

            Call MsgBox("Profile '" & DeleteName & "' Removed!", vbInformation)
        End If
    End Sub





    Private Sub cmdEditProfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditProfile.Click
        On Error GoTo EndofSub
        If System.IO.File.Exists(TempProfiles(SelectedProfile).ProfilePath) Then
            Call LoadNewProfile(SelectedProfile)
            Process.Start(EditorPath)
        Else
            Call MsgBox("Selected profile does not exist!", vbCritical)
            cmdEditProfile.Enabled = False
            Exit Sub
        End If

EndofSub:
    End Sub




    Private Sub cmdMoveUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMoveUp.Click
        Dim OldProfilePath As String, OldProcessName As String, OldMMO7LED As String, i As Byte



        If lstProfiles.SelectedIndex = 0 Then
            cmdMoveUp.Enabled = False
            Exit Sub
        End If

        i = lstProfiles.SelectedIndex - 1

        If TempDefaultProfile = SelectedProfile Then
            TempDefaultProfile = TempDefaultProfile - 1
        ElseIf TempDefaultProfile = lstProfiles.SelectedIndex Then
            TempDefaultProfile = TempDefaultProfile + 1
        End If

        OldProfilePath = TempProfiles(SelectedProfile).ProfilePath
        OldProcessName = TempProfiles(SelectedProfile).ProcessName
        OldMMO7LED = TempProfiles(SelectedProfile).RATCS

        TempProfiles(SelectedProfile).ProfilePath = TempProfiles(lstProfiles.SelectedIndex).ProfilePath
        TempProfiles(SelectedProfile).ProcessName = TempProfiles(lstProfiles.SelectedIndex).ProcessName
        TempProfiles(SelectedProfile).RATCS = TempProfiles(lstProfiles.SelectedIndex).RATCS

        TempProfiles(lstProfiles.SelectedIndex).ProfilePath = OldProfilePath
        TempProfiles(lstProfiles.SelectedIndex).ProcessName = OldProcessName
        TempProfiles(lstProfiles.SelectedIndex).RATCS = OldMMO7LED

        Call ReloadTempProfileList()
        lstProfiles.SelectedIndex = i

    End Sub

    Private Sub cmdMoveDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMoveDown.Click
        Dim OldProfilePath As String, OldProcessName As String, OldMMO7LED As String, i As Byte



        If SelectedProfile = TempMaxProfiles Then
            cmdMoveDown.Enabled = False
            Exit Sub
        End If

        i = SelectedProfile

        If TempDefaultProfile = SelectedProfile Then
            TempDefaultProfile = TempDefaultProfile + 1
        ElseIf TempDefaultProfile = lstProfiles.SelectedIndex + 2 Then
            TempDefaultProfile = TempDefaultProfile - 1
        End If

        OldProfilePath = TempProfiles(SelectedProfile).ProfilePath
        OldProcessName = TempProfiles(SelectedProfile).ProcessName
        OldMMO7LED = TempProfiles(SelectedProfile).RATCS

        TempProfiles(SelectedProfile).ProfilePath = TempProfiles(lstProfiles.SelectedIndex + 2).ProfilePath
        TempProfiles(SelectedProfile).ProcessName = TempProfiles(lstProfiles.SelectedIndex + 2).ProcessName
        TempProfiles(SelectedProfile).RATCS = TempProfiles(lstProfiles.SelectedIndex + 2).RATCS


        TempProfiles(lstProfiles.SelectedIndex + 2).ProfilePath = OldProfilePath
        TempProfiles(lstProfiles.SelectedIndex + 2).ProcessName = OldProcessName
        TempProfiles(lstProfiles.SelectedIndex + 2).RATCS = OldMMO7LED


        Call ReloadTempProfileList()
        lstProfiles.SelectedIndex = i
    End Sub

    Private Sub cbProfiles_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ' If System.IO.File.Exists(ProfilesDir & "\" & cbProfiles.SelectedItem) Then


        ' Else
        cmdEditProfile.Enabled = False
        ' End If
    End Sub








    Private Sub tsmDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmDelete.Click
        Call cmdDelete_Click(sender, e)
    End Sub

    Private Sub tsmDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmDefault.Click
        Dim i As Byte

        If TempDefaultProfile <> SelectedProfile Then
            TempDefaultProfile = SelectedProfile
            lstProcesses.Items.Clear()
            lstProcesses.Enabled = False
            cmdAddP.Enabled = False
            cmdRemoveP.Enabled = False

            Call ReloadTempProfileList()
            lstProfiles.SelectedIndex = TempDefaultProfile - 1

        Else
            i = lstProfiles.SelectedIndex
            TempDefaultProfile = 0
            Call ReloadTempProfileList()
            lstProfiles.SelectedIndex = i
        End If
    End Sub

    Private Sub tsmRenameProfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmRenameProfile.Click
        Dim RenamedProfile As String, OriginalProfile As String
        Dim y As Byte, p As Byte
        Dim s As String

        p = SelectedProfile
        OriginalProfile = TempProfiles(p).ProfilePath

        RenamedProfile = Interaction.InputBox("What would you like to rename the profile?", "Renaming profile (" & GetProfileName(TempProfiles(p).ProfilePath) & ")", GetProfileName(TempProfiles(p).ProfilePath))

        If RenamedProfile = "" Or (LCase(RenamedProfile & ".pr0")) = LCase(TempProfiles(p).ProfilePath) Or (LCase(RenamedProfile)) = LCase(TempProfiles(p).ProfilePath) Then
            Exit Sub
        End If


        If UnallowedChr(RenamedProfile) = True Then
            Call MsgBox("a filename cannot contain any of the following '\ / : * ? " & Chr(34) & "  < > |", vbCritical)
            Exit Sub
        End If

        If Len(RenamedProfile) >= 5 Then
            If LCase(Mid(RenamedProfile, Len(RenamedProfile) - 3)) = ".pr0" Then
                RenamedProfile = Mid(RenamedProfile, 1, Len(RenamedProfile) - 4)
            End If
        End If

        If System.IO.File.Exists(TempProfiles(p).ProfilePath) = False Then
            Call MsgBox("Could not find the profile to rename!", vbCritical)
            Exit Sub
        End If



        RenamedProfile = RenamedProfile

        s = Mid(TempProfiles(p).ProfilePath, 1, Len(TempProfiles(p).ProfilePath) - Len(GetProfileName(TempProfiles(p).ProfilePath) & ".pr0")) & RenamedProfile & ".pr0"


        My.Computer.FileSystem.RenameFile(TempProfiles(p).ProfilePath, RenamedProfile & ".pr0")


        TempProfiles(p).ProfilePath = s

        For y = 1 To MaxProfiles
            If Profiles(y).ProfilePath = OriginalProfile Then
                Profiles(y).ProfilePath = s
                Call SetSetting("Profile " & y & " Name", s)
                Exit For

            End If
        Next y

        Call ReloadTempProfileList()

        lstProfiles.SelectedIndex = p - 1

        Call MsgBox("Profile '" & GetProfileName(OriginalProfile) & "' was renamed '" & RenamedProfile & "!", vbInformation)

    End Sub


    Private Sub cmdAddP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddP.Click
        cmdAddP.ContextMenuStrip.Show(MousePosition.X, MousePosition.Y)
    End Sub

    Private Sub cmdRemoveP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemoveP.Click
        If lstProcesses.SelectedIndex >= 0 Then
            lstProcesses.Items.RemoveAt(lstProcesses.SelectedIndex)
            Call MakeProcessList(SelectedProfile)
        End If
    End Sub
    Public Sub MakeProcessList(ByVal Index As Byte)
        Dim i As Byte
        Dim ProcessArray As String

        ProcessArray = ""

        If lstProcesses.Items.Count > 1 Then
            For i = 0 To lstProcesses.Items.Count - 1
                ProcessArray = ProcessArray & lstProcesses.Items.Item(i)

                If i < lstProcesses.Items.Count - 1 Then
                    ProcessArray = ProcessArray & "�"
                End If
            Next

            TempProfiles(Index).ProcessName = ProcessArray
        ElseIf lstProcesses.Items.Count = 1 Then

            TempProfiles(Index).ProcessName = lstProcesses.Items.Item(0)

        ElseIf lstProcesses.Items.Count = 0 Then

            TempProfiles(Index).ProcessName = ""

        End If
    End Sub



    Private Sub chkDefaultP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDefaultP.CheckedChanged

    End Sub




    Private Sub gbProfile_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmdAddPP_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tsmAddText_Click(sender As Object, e As EventArgs) Handles tsmAddText.Click
        Dim s As String

        s = InputBox("What process would you like to add?", "Add Process")

        If Trim(s) = "" Then Exit Sub

        If Len(s) >= 4 Then
            If Mid(s, Len(s) - 3) = ".exe" Then
                s = Mid(s, 1, Len(s) - 4)
            End If
        End If

        'If UnallowedChrProcess(s) = True Then
        '    'Call MsgBox("a process cannot contain any of the following '\ : * ? " & Chr(34) & "  < > |", vbCritical)
        '    Call MsgBox("a process cannot contain any of the following ':'", vbCritical)
        '    Exit Sub
        'End If

        If lstProcesses.Items.Count > 0 Then
            If lstProcesses.Items.Item(0) = "" Then lstProcesses.Items.RemoveAt(0)
        End If

        lstProcesses.Items.Add(s)

        Call MakeProcessList(SelectedProfile)


    End Sub

    Private Sub cmProfiles_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmProfiles.Opening

    End Sub

    Private Sub cmsAddP_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmsAddP.Opening

    End Sub

    Private Sub tsmAddEXE_Click(sender As Object, e As EventArgs) Handles tsmAddEXE.Click
        Dim s As String
        Using dialog As New OpenFileDialog
            dialog.Filter = "Executable files (*.exe)|*.exe"

            If dialog.ShowDialog() <> DialogResult.OK Then Return
            s = dialog.SafeFileName

            If Len(s) >= 4 Then
                If Mid(s, Len(s) - 3) = ".exe" Then
                    s = Mid(s, 1, Len(s) - 4)
                End If
            End If

            If lstProcesses.Items.Count > 0 Then
                If lstProcesses.Items.Item(0) = "" Then lstProcesses.Items.RemoveAt(0)
            End If

            lstProcesses.Items.Add(s)

            Call MakeProcessList(SelectedProfile)
        End Using
    End Sub

    Private Sub tsmProcessList_Click(sender As Object, e As EventArgs) Handles tsmProcessList.Click
        frmProcessList.ShowDialog()
    End Sub


    Private Sub cmdPC_Click(sender As Object, e As EventArgs) Handles cmdPCLeft.Click
        ColorDestination = 0
        frmPickColor.ShowDialog()


        'Dim PickedColor As Color

        'ColorDialog.ShowDialog()
        'PickedColor = ColorDialog.Color


        'pbCPLeft.BackColor = PickedColor

        'Call SetRATCustomSettings(1, SelectedProfile, PickedColor.R, True)
        'Call SetRATCustomSettings(2, SelectedProfile, PickedColor.G, True)
        'Call SetRATCustomSettings(3, SelectedProfile, PickedColor.B, True)




    End Sub

    Private Sub chkCLED_CheckedChanged(sender As Object, e As EventArgs) Handles chkCLED.CheckedChanged

    End Sub

    Private Sub chkCLED_Click(sender As Object, e As EventArgs) Handles chkCLED.Click
        If chkCLED.Checked = False Then
            chkFlow.Enabled = True
            cmdPCLeft.Enabled = False
            cmdPCRight.Enabled = False
            cmdCopyLeft.Enabled = False
            cmdCopyRight.Enabled = False
            pbCPLeft.BackColor = Color.Black
            pbCPRight.BackColor = Color.Black
            Call SetRATCustomSettings(0, SelectedProfile, 0, True)
            Call SetRATCustomSettings(1, SelectedProfile, 0, True)
            Call SetRATCustomSettings(2, SelectedProfile, 0, True)
            Call SetRATCustomSettings(3, SelectedProfile, 0, True)
            Call SetRATCustomSettings(4, SelectedProfile, 0, True)
            Call SetRATCustomSettings(5, SelectedProfile, 0, True)
            Call SetRATCustomSettings(6, SelectedProfile, 0, True)
        Else
            chkFlow.Enabled = False
            cmdPCLeft.Enabled = True
            cmdPCRight.Enabled = True
            cmdCopyLeft.Enabled = True
            cmdCopyRight.Enabled = True
            Call SetRATCustomSettings(0, SelectedProfile, 1, True)
            Call SetRATCustomSettings(11, SelectedProfile, 0, True)
        End If
    End Sub
    Private Sub UpdateDPIDisplay()
        Select Case tbDPI.Value

            Case 0
                lblDPIMode.Text = "No Change."
                pbDPIMode.Image = My.Resources.DPIMode0

            Case 1
                lblDPIMode.Text = "Mode 1"
                pbDPIMode.Image = My.Resources.DPIMode1

            Case 2
                lblDPIMode.Text = "Mode 2"
                pbDPIMode.Image = My.Resources.DPIMode2

            Case 3
                lblDPIMode.Text = "Mode 3"
                pbDPIMode.Image = My.Resources.DPIMode3

            Case 4
                lblDPIMode.Text = "Mode 4"
                pbDPIMode.Image = My.Resources.DPIMode4


        End Select
    End Sub
    Private Sub cmdPCRight_Click(sender As Object, e As EventArgs) Handles cmdPCRight.Click
        ColorDestination = 1
        frmPickColor.ShowDialog()

        'Dim PickedColor As Color

        'ColorDialog.ShowDialog()
        'PickedColor = ColorDialog.Color


        'pbCPRight.BackColor = PickedColor

        'Call SetRATCustomSettings(4, SelectedProfile, PickedColor.R, True)
        'Call SetRATCustomSettings(5, SelectedProfile, PickedColor.G, True)
        'Call SetRATCustomSettings(6, SelectedProfile, PickedColor.B, True)
    End Sub
    Public Sub ReturnColor(Position As Byte, R As Byte, G As Byte, B As Byte)

        Select Case Position

            Case 0 ' Left LED
                pbCPLeft.BackColor = Color.FromArgb(R, G, B)

                Call SetRATCustomSettings(1, SelectedProfile, R, True)
                Call SetRATCustomSettings(2, SelectedProfile, G, True)
                Call SetRATCustomSettings(3, SelectedProfile, B, True)
                

            Case 1 ' Right LED
                pbCPRight.BackColor = Color.FromArgb(R, G, B)

                Call SetRATCustomSettings(4, SelectedProfile, R, True)
                Call SetRATCustomSettings(5, SelectedProfile, G, True)
                Call SetRATCustomSettings(6, SelectedProfile, B, True)

        End Select
    End Sub

    Private Sub cmdCopyLeft_Click(sender As Object, e As EventArgs) Handles cmdCopyLeft.Click

        pbCPRight.BackColor = pbCPLeft.BackColor

        Call SetRATCustomSettings(4, SelectedProfile, pbCPLeft.BackColor.R, True)
        Call SetRATCustomSettings(5, SelectedProfile, pbCPLeft.BackColor.G, True)
        Call SetRATCustomSettings(6, SelectedProfile, pbCPLeft.BackColor.B, True)

    End Sub

    Private Sub cmdCopyRight_Click(sender As Object, e As EventArgs) Handles cmdCopyRight.Click

        pbCPLeft.BackColor = pbCPRight.BackColor

        Call SetRATCustomSettings(1, SelectedProfile, pbCPRight.BackColor.R, True)
        Call SetRATCustomSettings(2, SelectedProfile, pbCPRight.BackColor.G, True)
        Call SetRATCustomSettings(3, SelectedProfile, pbCPRight.BackColor.B, True)

    End Sub

    Private Sub tpDPIMode_Click(sender As Object, e As EventArgs) Handles tpDPIMode.Click

    End Sub

    Private Sub chkCLED_HandleCreated(sender As Object, e As EventArgs) Handles chkCLED.HandleCreated

    End Sub



    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub pbDPIMode_Click(sender As Object, e As EventArgs) Handles pbDPIMode.Click

    End Sub

    Private Sub tsmEditProfile_Click_1(sender As Object, e As EventArgs) Handles tsmEditProfile.Click
        If cmdEditProfile.Enabled = True Then
            Call cmdEditProfile_Click(sender, e)
        End If
    End Sub

    Private Sub lstProcesses_DragDrop(sender As Object, e As DragEventArgs) Handles lstProcesses.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        Dim s As String

        For Each FilePath In files
            If LCase(System.IO.Path.GetExtension(FilePath)) = ".exe" Then
                lstProcesses.Items.Add(System.IO.Path.GetFileNameWithoutExtension(FilePath))

                Call MakeProcessList(SelectedProfile)
            ElseIf LCase(System.IO.Path.GetExtension(FilePath)) = ".lnk" Then

                s = GetTargetPathFromShortcut(FilePath)

                If System.IO.File.Exists(s) Then
                    lstProcesses.Items.Add(System.IO.Path.GetFileNameWithoutExtension(s))
                End If
            End If
        Next
    End Sub

    Private Sub lstProcesses_DragEnter(sender As Object, e As DragEventArgs) Handles lstProcesses.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub lstProcesses_KeyDown(sender As Object, e As KeyEventArgs) Handles lstProcesses.KeyDown
        If e.KeyData = Keys.Delete Then
            Call cmdRemoveP_Click(sender, e)
        End If
    End Sub

    Private Sub lstProcesses_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstProcesses.MouseDoubleClick
        If lstProcesses.SelectedIndex >= 0 Then
            Call tsmEditProcess_Click(sender, e)
        End If
    End Sub

    Private Sub lstProcesses_MouseDown(sender As Object, e As MouseEventArgs) Handles lstProcesses.MouseDown
        If lstProcesses.IndexFromPoint(e.X, e.Y) >= 0 Then
            lstProcesses.SelectedIndex = lstProcesses.IndexFromPoint(e.X, e.Y)
            lstProcesses.ContextMenuStrip = cmsProcesses
        Else
            lstProcesses.ContextMenuStrip = Nothing
        End If
    End Sub

    Private Sub lstProcesses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProcesses.SelectedIndexChanged
        If lstProcesses.SelectedIndex < 0 Then
            cmdRemoveP.Enabled = False
        Else
            cmdRemoveP.Enabled = True
        End If
    End Sub

    Private Sub tsmRemoveProcess_Click(sender As Object, e As EventArgs) Handles tsmRemoveProcess.Click
        Call cmdRemoveP_Click(sender, e)
    End Sub

    Private Sub tsmEditProcess_Click(sender As Object, e As EventArgs) Handles tsmEditProcess.Click
        Dim s As String

        s = InputBox("What would to like to rename the process?", "Edit Process", lstProcesses.Items.Item(lstProcesses.SelectedIndex))

        If Trim(s) = "" Or Trim(s) = lstProcesses.Items.Item(lstProcesses.SelectedIndex) Then Exit Sub

        If Len(s) >= 4 Then
            If Mid(s, Len(s) - 3) = ".exe" Then
                s = Mid(s, 1, Len(s) - 4)
            End If
        End If

        'If UnallowedChrProcess(s) = True Then
        '    'Call MsgBox("a process cannot contain any of the following '\ : * ? " & Chr(34) & "  < > |", vbCritical)
        '    Call MsgBox("a process cannot contain any of the following ':'", vbCritical)
        '    Exit Sub
        'End If

        lstProcesses.Items.Item(lstProcesses.SelectedIndex) = s

        Call MakeProcessList(SelectedProfile)
    End Sub


    Private Sub chkChangPrecisionPercent_CheckedChanged(sender As Object, e As EventArgs) Handles chkChangPrecisionPercent.CheckedChanged
        If chkChangPrecisionPercent.Checked = True Then
            hsbPrecisionX.Enabled = True
            hsbPrecisionY.Enabled = True
        Else
            hsbPrecisionX.Enabled = False
            hsbPrecisionY.Enabled = False
        End If
    End Sub

    Private Sub chkChangPrecisionPercent_Click(sender As Object, e As EventArgs) Handles chkChangPrecisionPercent.Click
        If lstProfiles.SelectedIndex < 0 Then Exit Sub

        Call SetRATCustomSettings(8, SelectedProfile, 1, True)


    End Sub

    Private Sub hsbPrecisionX_Scroll(sender As Object, e As ScrollEventArgs) Handles hsbPrecisionX.Scroll
        If lstProfiles.SelectedIndex < 0 Then Exit Sub

        Call SetRATCustomSettings(9, SelectedProfile, hsbPrecisionX.Value, True)
        lblPrecisionPercentX.Text = hsbPrecisionX.Value & "%"
    End Sub

    Private Sub hsbPrecisionY_Scroll(sender As Object, e As ScrollEventArgs) Handles hsbPrecisionY.Scroll
        If lstProfiles.SelectedIndex < 0 Then Exit Sub

        Call SetRATCustomSettings(10, SelectedProfile, hsbPrecisionY.Value, True)
        lblPrecisionPercentY.Text = hsbPrecisionY.Value & "%"
    End Sub

    Private Sub hsbPrecisionY_ValueChanged(sender As Object, e As EventArgs) Handles hsbPrecisionY.ValueChanged
        lblPrecisionPercentY.Text = hsbPrecisionY.Value & "%"
    End Sub

    Private Sub hsbPrecisionX_ValueChanged(sender As Object, e As EventArgs) Handles hsbPrecisionX.ValueChanged
        lblPrecisionPercentX.Text = hsbPrecisionX.Value & "%"
    End Sub

    Private Sub lblPrecisionPercentY_Click(sender As Object, e As EventArgs) Handles lblPrecisionPercentY.Click

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmdEditHotKey_Click(sender As Object, e As EventArgs) Handles cmdEditHotKey.Click
        frmKeyPress.ShowDialog()
    End Sub

    Private Sub cmdRemoveHotKey_Click(sender As Object, e As EventArgs) Handles cmdRemoveHotKey.Click
        txtHotKey.Text = "No Key"
        Call SetProfileSettings(3, SelectedProfile, 0, True)
    End Sub

    Private Sub txtHotKey_TextChanged(sender As Object, e As EventArgs) Handles txtHotKey.TextChanged

    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub tsmAdvancedInput_Click(sender As Object, e As EventArgs) Handles tsmAdvancedInput.Click
        frmAdvProcessInput.ShowDialog()
    End Sub

    Private Sub tbDPI_Scroll(sender As Object, e As EventArgs) Handles tbDPI.Scroll
        Select Case tbDPI.Value

            Case 0
                lblDPIMode.Text = "No Change."
                Call SetRATCustomSettings(7, SelectedProfile, 0, True)
                pbDPIMode.Image = My.Resources.DPIMode0

            Case 1
                lblDPIMode.Text = "Mode 1"
                Call SetRATCustomSettings(7, SelectedProfile, 1, True)
                pbDPIMode.Image = My.Resources.DPIMode1

            Case 2
                lblDPIMode.Text = "Mode 2"
                Call SetRATCustomSettings(7, SelectedProfile, 2, True)
                pbDPIMode.Image = My.Resources.DPIMode2

            Case 3
                lblDPIMode.Text = "Mode 3"
                Call SetRATCustomSettings(7, SelectedProfile, 3, True)
                pbDPIMode.Image = My.Resources.DPIMode3

            Case 4
                lblDPIMode.Text = "Mode 4"
                Call SetRATCustomSettings(7, SelectedProfile, 4, True)
                pbDPIMode.Image = My.Resources.DPIMode4


        End Select
    End Sub

    Private Sub cbSCaps_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSCaps.SelectedIndexChanged
        If cbSCaps.SelectedIndex >= 0 Then
            Call SetProfileSettings(0, SelectedProfile, cbSCaps.SelectedIndex, True)
        End If
    End Sub

    Private Sub cbSNum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSNum.SelectedIndexChanged
        If cbSNum.SelectedIndex >= 0 Then
            Call SetProfileSettings(1, SelectedProfile, cbSNum.SelectedIndex, True)
        End If
    End Sub

    Private Sub cbSScroll_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSScroll.SelectedIndexChanged
        If cbSScroll.SelectedIndex >= 0 Then
            Call SetProfileSettings(2, SelectedProfile, cbSScroll.SelectedIndex, True)
        End If
    End Sub

    Private Sub Splitter1_SplitterMoved(sender As Object, e As SplitterEventArgs)

    End Sub

    Private Sub chkAllD_CheckedChanged(sender As Object, e As EventArgs) Handles chkAllD.CheckedChanged

    End Sub

    Private Sub GroupBox4_Enter_1(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub cmsProcesses_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmsProcesses.Opening

    End Sub

    Private Sub tmrMouseSpeedPreview_Tick(sender As Object, e As EventArgs) Handles tmrMouseSpeedPreview.Tick
        TickCount = TickCount + 1

        cmdPreviewMS.Text = "Returning to Normal in " & 5 - TickCount & " Seconds."

        If TickCount >= 5 Then
            SystemParametersInfo(SPI_SETMOUSESPEED, 0, DefaultMouseSpeed, SPIF_UPDATEINIFILE)
            cmdPreviewMS.Text = "Preview"
            tmrMouseSpeedPreview.Enabled = False
            cmdPreviewMS.Enabled = True
        End If
    End Sub

    Private Sub cmdPreviewMS_Click(sender As Object, e As EventArgs) Handles cmdPreviewMS.Click
        If chkChangeMouseSpeed.Checked = True Then
            SystemParametersInfo(SPI_SETMOUSESPEED, 0, tbMouseSpeed.Value, SPIF_UPDATEINIFILE)
            TickCount = 0
            tmrMouseSpeedPreview.Enabled = True
            cmdPreviewMS.Enabled = False
        End If
    End Sub

    Private Sub cmdCancel_Disposed(sender As Object, e As EventArgs) Handles cmdCancel.Disposed
        If tmrMouseSpeedPreview.Enabled = True Then
            tmrMouseSpeedPreview.Enabled = False
            SystemParametersInfo(SPI_SETMOUSESPEED, 0, DefaultMouseSpeed, SPIF_UPDATEINIFILE)
            cmdPreviewMS.Text = "Preview"
        End If
    End Sub

    Private Sub chkChangeMouseSpeed_CheckedChanged(sender As Object, e As EventArgs) Handles chkChangeMouseSpeed.CheckedChanged
        If chkChangeMouseSpeed.Checked = True Then
            tbMouseSpeed.Enabled = True
            cmdPreviewMS.Enabled = True
            Call SetProfileSettings(5, SelectedProfile, 10, True)
        Else
            tbMouseSpeed.Enabled = False
            cmdPreviewMS.Enabled = False
            Call SetProfileSettings(5, SelectedProfile, 0, True)
        End If
    End Sub

    Private Sub tbMouseSpeed_Scroll(sender As Object, e As EventArgs) Handles tbMouseSpeed.Scroll
        Call SetProfileSettings(5, SelectedProfile, tbMouseSpeed.Value, True)
    End Sub

    Private Sub chkFlow_CheckedChanged(sender As Object, e As EventArgs) Handles chkFlow.CheckedChanged

    End Sub

    Private Sub chkFlow_Click(sender As Object, e As EventArgs) Handles chkFlow.Click
        If chkFlow.Checked = True Then
            chkCLED.Checked = False
            Call chkCLED_Click(sender, e)
            chkCLED.Enabled = False

            Call SetRATCustomSettings(11, SelectedProfile, 1, True)
        Else
            chkCLED.Enabled = True
            Call SetRATCustomSettings(11, SelectedProfile, 0, True)
        End If
    End Sub

    Private Sub cmdFlowSettings_Click(sender As Object, e As EventArgs) Handles cmdFlowSettings.Click
        frmMMO7LEDFlow.ShowDialog()
    End Sub

    Private Sub cmdDLProfile_Click(sender As Object, e As EventArgs) Handles cmdDLProfile.Click
        frmProfileDB.ShowDialog()
    End Sub


    Private Sub cbScriptLP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbScript.SelectedIndexChanged
        TempProfiles(SelectedProfile).Script = cbScript.SelectedItem
    End Sub

    Private Sub cmdTestScript_Click(sender As Object, e As EventArgs) Handles cmdTestScript.Click
        frmTestScript.ShowDialog()
    End Sub

    Private Sub tpMouseSpeed_Click(sender As Object, e As EventArgs) Handles tpMouseSpeed.Click

    End Sub

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox6_Enter(sender As Object, e As EventArgs) Handles GroupBox6.Enter

    End Sub

    Private Sub lblDPIMode_Click(sender As Object, e As EventArgs) Handles lblDPIMode.Click

    End Sub

    Private Sub hsbDPIX_Scroll(sender As Object, e As ScrollEventArgs) Handles hsbDPIX.Scroll
        lblDPIX.Text = "X: " & hsbDPIX.Value

        Select Case SelectedDPIMode

            Case 1
                Call SetRATCustomSettings(13, SelectedProfile, hsbDPIX.Value, True)

            Case 2
                Call SetRATCustomSettings(15, SelectedProfile, hsbDPIX.Value, True)

            Case 3
                Call SetRATCustomSettings(17, SelectedProfile, hsbDPIX.Value, True)

            Case 4
                Call SetRATCustomSettings(19, SelectedProfile, hsbDPIX.Value, True)


        End Select
    End Sub

    Private Sub hsbDPIY_Scroll(sender As Object, e As ScrollEventArgs) Handles hsbDPIY.Scroll
        lblDPIY.Text = "Y: " & hsbDPIY.Value

        Select Case SelectedDPIMode

            Case 1
                Call SetRATCustomSettings(14, SelectedProfile, hsbDPIY.Value, True)

            Case 2
                Call SetRATCustomSettings(16, SelectedProfile, hsbDPIY.Value, True)

            Case 3
                Call SetRATCustomSettings(18, SelectedProfile, hsbDPIY.Value, True)

            Case 4
                Call SetRATCustomSettings(20, SelectedProfile, hsbDPIY.Value, True)


        End Select
    End Sub

    Private Sub tpDPI_Click(sender As Object, e As EventArgs) Handles tpDPI.Click

    End Sub

    Private Sub rbDPI1_CheckedChanged(sender As Object, e As EventArgs) Handles rbDPI1.CheckedChanged
        Dim x As Integer, y As Integer

        SelectedDPIMode = 1

        x = GetRATCSetting(SelectedProfile, 13, True)
        y = GetRATCSetting(SelectedProfile, 14, True)

        If x < 1000 Or x > RATMaxDPI Then x = 1000
        If y < 1000 Or y > RATMaxDPI Then y = 1000

        lblDPIX.Text = "X: " & x
        hsbDPIX.Value = x
        lblDPIY.Text = "Y: " & y
        hsbDPIY.Value = y
    End Sub

    Private Sub rbDPI2_CheckedChanged(sender As Object, e As EventArgs) Handles rbDPI2.CheckedChanged
        Dim x As Integer, y As Integer

        SelectedDPIMode = 2

        x = GetRATCSetting(SelectedProfile, 15, True)
        y = GetRATCSetting(SelectedProfile, 16, True)

        If x < 1000 Or x > RATMaxDPI Then x = 1000
        If y < 1000 Or y > RATMaxDPI Then y = 1000

        lblDPIX.Text = "X: " & x
        hsbDPIX.Value = x
        lblDPIY.Text = "Y: " & y
        hsbDPIY.Value = y
    End Sub

    Private Sub rbDPI3_CheckedChanged(sender As Object, e As EventArgs) Handles rbDPI3.CheckedChanged
        Dim x As Integer, y As Integer

        SelectedDPIMode = 3

        x = GetRATCSetting(SelectedProfile, 17, True)
        y = GetRATCSetting(SelectedProfile, 18, True)

        If x < 1000 Or x > RATMaxDPI Then x = 1000
        If y < 1000 Or y > RATMaxDPI Then y = 1000

        lblDPIX.Text = "X: " & x
        hsbDPIX.Value = x
        lblDPIY.Text = "Y: " & y
        hsbDPIY.Value = y
    End Sub

    Private Sub rbDPI4_CheckedChanged(sender As Object, e As EventArgs) Handles rbDPI4.CheckedChanged
        Dim x As Integer, y As Integer

        SelectedDPIMode = 4

        x = GetRATCSetting(SelectedProfile, 19, True)
        y = GetRATCSetting(SelectedProfile, 20, True)

        If x < 1000 Or x > RATMaxDPI Then x = 1000
        If y < 1000 Or y > RATMaxDPI Then y = 1000

        lblDPIX.Text = "X: " & x
        hsbDPIX.Value = x
        lblDPIY.Text = "Y: " & y
        hsbDPIY.Value = y
    End Sub

    Private Sub chkCDPI_CheckedChanged(sender As Object, e As EventArgs) Handles chkCDPI.CheckedChanged

        If chkCDPI.Checked = True Then
            rbDPI1.Enabled = True
            rbDPI2.Enabled = True
            rbDPI3.Enabled = True
            rbDPI4.Enabled = True
            hsbDPIX.Enabled = True
            hsbDPIY.Enabled = True

            rbDPI1.Checked = True
            lblDPIX.Text = "X: 1000"
            hsbDPIX.Value = 1000
            lblDPIY.Text = "Y: 1000"
            hsbDPIY.Value = 1000

            Call SetRATCustomSettings(12, SelectedProfile, 1, True)
        Else

            rbDPI1.Enabled = False
            rbDPI2.Enabled = False
            rbDPI3.Enabled = False
            rbDPI4.Enabled = False
            hsbDPIX.Enabled = False
            hsbDPIY.Enabled = False
            Call SetRATCustomSettings(12, SelectedProfile, 0, True)
        End If

    End Sub

    Private Sub hsbDPIX_ValueChanged(sender As Object, e As EventArgs) Handles hsbDPIX.ValueChanged
        lblDPIX.Text = "X: " & hsbDPIX.Value
    End Sub

    Private Sub hsbDPIY_ValueChanged(sender As Object, e As EventArgs) Handles hsbDPIY.ValueChanged
        lblDPIY.Text = "Y: " & hsbDPIY.Value
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub chkLock_CheckedChanged(sender As Object, e As EventArgs) Handles chkLock.CheckedChanged
        If TempDefaultProfile = SelectedProfile Then
            chkLock.Checked = False
            chkLock.Enabled = False
            Call SetProfileSettings(6, SelectedProfile, 0, True)
        End If

        If chkLock.Checked = True Then

            Call SetProfileSettings(6, SelectedProfile, 1, True)
        Else
            Call SetProfileSettings(6, SelectedProfile, 0, True)
        End If
    End Sub

    Private Sub chkBSoD_CheckedChanged(sender As Object, e As EventArgs) Handles chkBSoD.CheckedChanged
        If chkBSoD.Checked = True Then

            Call SetProfileSettings(7, SelectedProfile, 1, True)
        Else
            Call SetProfileSettings(7, SelectedProfile, 0, True)
        End If
    End Sub
End Class