Public Class frmAutoProfiler

    Public ProfileListSubFolder() As System.Windows.Forms.ToolStripMenuItem
    Public ProfileListSubFolderCount As Byte
    Private RC As Boolean = False
    Private PickedProfile As String = ""
    Public UpdateNotified As Boolean
    Public TT As New ToolTip()


    Private Sub frmAutoProfiler_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    End Sub
    
    Private Sub frmAutoProfiler_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        ''If e.CloseReason = CloseReason.ApplicationExitCall Then
        ''    Exit Sub
        ''End If

        'MsgBox(e.CloseReason)

        'If e.CloseReason = CloseReason.UserClosing Then

        '    Me.Visible = False
        '    TaskIcon.Visible = True
        '    e.Cancel = True

        'Else
        '    e.Cancel = False
        '    Call CloseCAP()

        'End If

        Call CloseCAP()

    End Sub

    Private Sub frmAutoProfiler_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
    
    End Sub

    Private Sub frmAutoProfiler_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

    End Sub







    Private Sub frmAutoProfiler_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ListSystemTrayProfiles()

        ' frmDebug.Show()
    End Sub

    Private Sub cmdSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSettings.Click
        tmrHotKey.Enabled = False

        If tmrAPCheck.Enabled = True Then
            WasEnabled = True
        Else
            WasEnabled = False
        End If


        Call ShowSystemTrayOptions(False)
        Call SetCheckerStatus(False)
        frmSettings.ShowDialog()
    End Sub

    Private Sub cmdProfiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProfiles.Click

        If tmrAPCheck.Enabled = True Then
            WasEnabled = True
        Else
            WasEnabled = False
        End If


        Call ShowSystemTrayOptions(False)
        Call SetCheckerStatus(False)
        tmrHotKey.Enabled = False
        Call LoadTempProfiles()



    End Sub

    Private Sub tmrAPCheck_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAPCheck.Tick
        On Error GoTo ErrorHandler
        Dim i As Byte


1:      If MaxProfiles = 0 Then
2:          Call SetCheckerStatus(False)
3:          Exit Sub
4:      End If

        ' Check if we are waiting
5:      If IsWaiting = True Then Exit Sub


        ' Check if we have a locked profile
        If ProfileLocked = True Then

            If LoadedProfile <> LockedProfile Or LockedProfile = 0 Then
                LockedProfile = 0
                ProfileLocked = False
            End If

            If CheckLockedProfileRunning() = False Then
                LockedProfile = 0
                ProfileLocked = False
            Else
                Exit Sub
            End If

        End If


        'Check if they are using Detection mode 1. If so disable default profile.

6:      If LoadedProfile > 0 And UsingDefaultProfile = False Then

7:          If IsProccessRunning(Profiles(LoadedProfile).ProcessName) = False Then
                ' If DefaultProfile > 0 Then
                ' Call LoadNewProfile(Profiles.ProfilePath(DefaultProfile))
                '  LoadedProfile = DefaultProfile
                '   UsingDefaultProfile = True
                '    Exit Sub
                ' Else

                ' Check if we need to clear the profile from the devices.
8:              If ClearProfile = 1 Then
9:                  Call ClearDevicesActiveProfile()
10:             End If

                ProfileLocked = False
                LockedProfile = 0
                LoadedProfile = 0
11:         End If
12:     End If



13:     For i = 1 To MaxProfiles
14:         If IsProccessRunning(Profiles(i).ProcessName) = True And i <> DefaultProfile Then
15:             If i <> LoadedProfile Then
16:                 LoadedProfile = i
17:                 Call LoadNewProfile(i)
18:                 UsingDefaultProfile = False
19:                 Exit Sub
20:             Else
21:                 Exit Sub
22:             End If

23:         End If
24:     Next


        ' Check if we need to use the default profile
25:     If DefaultProfile > 0 And ClearProfile = 0 Then
26:         If LoadedProfile = 0 And UsingDefaultProfile = False Then
27:             LoadedProfile = DefaultProfile
28:             Call LoadNewProfile(DefaultProfile)
29:             UsingDefaultProfile = True
30:             Exit Sub
31:         End If
32:     End If


33:     Exit Sub

ErrorHandler:
        If frmError.Visible = True Then Exit Sub
        frmError.lblErr.Text = "Process Check has had an error at line " & Err.Erl & vbNewLine & vbNewLine & "Description: " & Err.Description & vbNewLine & vbNewLine & "Please report this to CyborgAutoProfiler@gmail.com"
        frmError.rtbErr.Text = "Process Check has had an error! Error Description: " & Err.Description & vbNewLine & vbNewLine & "Operating System: " & My.Computer.Info.OSFullName & vbNewLine & "Operating System Version: " & My.Computer.Info.OSVersion & vbNewLine & "Cyborg Version: " & CurrentVersion
        Call SetCheckerStatus(False)
        frmError.ShowDialog()
    End Sub


    Private Sub TaskIcon_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TaskIcon.MouseClick

    End Sub

    Private Sub TaskIcon_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TaskIcon.MouseDoubleClick

        If frmSettings.Visible = False And frmProfilesSettings.Visible = False Then
            Me.Visible = True
            TaskIcon.Visible = False
            Me.WindowState = FormWindowState.Normal
        End If

    End Sub

    Private Sub frmAutoProfiler_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then

            Me.Visible = False
            TaskIcon.Visible = True


        End If
    End Sub



    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Call CloseCAP()
    End Sub

    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles TSAutoProfiler.ItemClicked

    End Sub

    Private Sub TScmdAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TScmdAbout.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub TScmdHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TScmdHelp.Click
        frmHelp.ShowDialog()
    End Sub

    Private Sub tsmOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmOpen.Click
        Me.Visible = True
        TaskIcon.Visible = False
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub tsmExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmExit.Click
        Application.Exit()
    End Sub

    Private Sub cmtTaskbar_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmtTaskbar.Opening

    End Sub

    Private Sub tsmED_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmED.Click
        Call cmdED_Click(sender, e)
    End Sub

    Private Sub cmdED_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdED.Click

        If MaxProfiles = 0 Then
            Call MsgBox("You currently have no profiles set!", vbCritical)
            Call SetCheckerStatus(False)
            Exit Sub
        End If

        Call ToggleSoftware()

    End Sub

    Private Sub CheckToMinimize()

    End Sub

    Private Sub tmrMinimize_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMinimize.Tick
        On Error GoTo HandleError

        If Environment.GetCommandLineArgs.Count <> 1 Then
            If Environment.GetCommandLineArgs(1) = "-minimize" Then
                TaskIcon.Visible = True
                Me.Visible = False
            End If
        End If

        tmrMinimize.Enabled = False

        Exit Sub

HandleError:
        Call MsgBox("Minimize timer has had an error! Please report this to CyborgAutoProfiler@gmail.com", vbCritical)
    End Sub



    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub tsbWeb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbWeb.Click
        System.Diagnostics.Process.Start(WebpageURL)

    End Sub

    Private Sub cmsProfiles_Click(sender As Object, e As EventArgs) Handles cmsProfiles.Click

    End Sub

    Private Sub cmsProfiles_Closing(sender As Object, e As ToolStripDropDownClosingEventArgs) Handles cmsProfiles.Closing
        '   Static ClosingCount As Byte = 0


        If RC = True Then
            e.Cancel = True
            'ClosingCount = ClosingCount + 1

            'If cmtTaskbar.Visible = True Then
            '    If ClosingCount >= 3 Then
            '        RC = False
            '        ClosingCount = 0
            '    End If
            'Else
            '    If ClosingCount >= 2 Then
            '        RC = False
            '        ClosingCount = 0
            '    End If
            'End If
        End If
    End Sub

    Private Sub cmsProfiles_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles cmsProfiles.ItemClicked


        If RC = True Then
            PickedProfile = e.ClickedItem.Tag
            cmsProfilesRC.Show(MousePosition.X, MousePosition.Y)

        Else
            Dim i As Byte ', x As Byte
            i = FindProfileFromPath(e.ClickedItem.Tag)


            If e.ClickedItem.Tag = "" Then Exit Sub



            If i > 0 Then
                Call SetCheckerStatus(False)
                Call LoadNewProfile(i)
            Else
                Call SetCheckerStatus(False)
                Call LoadProfile(e.ClickedItem.Tag)
            End If



            Call RefreshSystemTrayProfiles()

        End If
    End Sub

    Public Sub ListSystemTrayProfiles()
        Dim folderInfo As New IO.DirectoryInfo(ProfilesDir)
        Dim arrFilesInFolder() As IO.FileInfo
        Dim arrDirectoriesInFolder() As IO.DirectoryInfo
        Dim fileInFolder As IO.FileInfo
        Dim FoundActiveProfile As Boolean = False
        Dim i As Byte

        tsmProfiles.DropDownItems.Clear()

        ProfileListSubFolderCount = 0


        If System.IO.Directory.Exists(ProfilesDir) = False Then
            Exit Sub
        End If

        arrFilesInFolder = folderInfo.GetFiles("*.pr0*")

        arrDirectoriesInFolder = folderInfo.GetDirectories


        For Each fileInFolder In arrFilesInFolder


            If Len(fileInFolder.Name) > 3 Then
                tsmProfiles.DropDownItems.Add("              " & fileInFolder.Name)
                tsmProfiles.DropDownItems.Item(tsmProfiles.DropDownItems.Count - 1).Tag = fileInFolder.FullName
                AddHandler tsmProfiles.DropDownItems.Item(tsmProfiles.DropDownItems.Count - 1).MouseDown, AddressOf cmsProfiles_MouseDown



                If FoundActiveProfile = False Then

                    If tsmProfiles.DropDownItems.Item(tsmProfiles.DropDownItems.Count - 1).Tag = ActiveProfile Then
                        tsmProfiles.DropDownItems.Item(tsmProfiles.DropDownItems.Count - 1).BackgroundImage = My.Resources.TaskProfileSelected
                        tsmProfiles.DropDownItems.Item(tsmProfiles.DropDownItems.Count - 1).BackgroundImageLayout = ImageLayout.Stretch
                        FoundActiveProfile = True
                    End If
                End If


            End If

        Next

        ''Subfolders

        ReDim ProfileListSubFolder(0 To arrDirectoriesInFolder.Count)

        For Each directoryInFolder In arrDirectoriesInFolder

            folderInfo = New IO.DirectoryInfo(directoryInFolder.FullName)
            arrFilesInFolder = folderInfo.GetFiles("*.pr0*")

            ProfileListSubFolderCount = ProfileListSubFolderCount + 1

            i = ProfileListSubFolderCount

            ProfileListSubFolder(i) = New System.Windows.Forms.ToolStripMenuItem

            ProfileListSubFolder(i).Name = directoryInFolder.Name
            ProfileListSubFolder(i).Text = "              " & directoryInFolder.Name


            For Each fileInFolder In arrFilesInFolder


                If Len(fileInFolder.Name) > 3 Then

                    ProfileListSubFolder(i).DropDownItems.Add("       " & fileInFolder.Name)
                    ProfileListSubFolder(i).DropDownItems.Item(ProfileListSubFolder(i).DropDownItems.Count - 1).Tag = fileInFolder.FullName
                    ProfileListSubFolder(i).DropDownItems.Item(ProfileListSubFolder(i).DropDownItems.Count - 1).Name = fileInFolder.Name
                    ProfileListSubFolder(i).DropDownItems.Item(ProfileListSubFolder(i).DropDownItems.Count - 1).BackgroundImage = My.Resources.TaskProfileNormal
                    ProfileListSubFolder(i).DropDownItems.Item(ProfileListSubFolder(i).DropDownItems.Count - 1).BackgroundImageLayout = ImageLayout.Stretch

                    If FoundActiveProfile = False Then
                        If ProfileListSubFolder(i).DropDownItems.Item(ProfileListSubFolder(i).DropDownItems.Count - 1).Tag = ActiveProfile Then
                            ProfileListSubFolder(i).DropDownItems.Item(ProfileListSubFolder(i).DropDownItems.Count - 1).BackgroundImage = My.Resources.TaskProfileSelected
                            ProfileListSubFolder(i).DropDownItems.Item(ProfileListSubFolder(i).DropDownItems.Count - 1).BackgroundImageLayout = ImageLayout.Stretch
                            FoundActiveProfile = True
                        End If
                    End If

                End If
            Next

            tsmProfiles.DropDownItems.Add(ProfileListSubFolder(i))
            AddHandler ProfileListSubFolder(i).DropDownItemClicked, AddressOf cmsProfiles_ItemClicked
            AddHandler ProfileListSubFolder(i).MouseDown, AddressOf cmsProfiles_MouseDown
        Next



    End Sub

    Private Sub tsmProfileEditor_Click(sender As Object, e As EventArgs) Handles tsmProfileEditor.Click
        If System.IO.File.Exists(EditorPath) = True Then
            Process.Start(EditorPath)
        Else
            tsmProfileEditor.Visible = False
        End If

    End Sub

    Private Sub tsmEditProfiles_Click(sender As Object, e As EventArgs) Handles tsmEditProfiles.Click
        Call cmdProfiles_Click(sender, e)
    End Sub

    Private Sub tsmSettings_Click(sender As Object, e As EventArgs) Handles tsmSettings.Click
        Call cmdSettings_Click(sender, e)
    End Sub

    Private Sub tsbProfiles_Click(sender As Object, e As EventArgs) Handles tsbProfiles.Click

    End Sub

    Private Sub cmsProfiles_LostFocus(sender As Object, e As EventArgs) Handles cmsProfiles.LostFocus

    End Sub

    Private Sub cmsProfiles_MouseClick(sender As Object, e As MouseEventArgs) Handles cmsProfiles.MouseClick

    End Sub

    Private Sub cmsProfiles_MouseDown(sender As Object, e As MouseEventArgs) Handles cmsProfiles.MouseDown
        RC = False

        If e.Button = Windows.Forms.MouseButtons.Right Then
            RC = True

        End If
    End Sub

    Private Sub cmsProfiles_MouseUp(sender As Object, e As MouseEventArgs) Handles cmsProfiles.MouseUp

    End Sub

    Private Sub cmsProfiles_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmsProfiles.Opening

    End Sub

    Private Sub tsmProfiles_Click(sender As Object, e As EventArgs) Handles tsmProfiles.Click

    End Sub

    Private Sub tmrHotKey_Tick(sender As Object, e As EventArgs) Handles tmrHotKey.Tick
        On Error GoTo ErrorHandler

        Dim i As Byte


1:      If ProfileHotKeyCount <= 0 Then Exit Sub

2:      For i = 1 To ProfileHotKeyCount
3:          If ProfileHotKey(i).HotKeyChr2 <> 0 Then
4:              If GetAsyncKeyState(ProfileHotKey(i).HotKeyChr) <> 0 And GetAsyncKeyState(ProfileHotKey(i).HotKeyChr2) <> 0 Then
5:                  Call LoadNewProfile(ProfileHotKey(i).HotKeyProfile)
                End If
            Else
6:              If GetAsyncKeyState(ProfileHotKey(i).HotKeyChr) <> 0 Then
7:                  Call LoadNewProfile(ProfileHotKey(i).HotKeyProfile)
                End If
            End If

        Next

        Exit Sub

ErrorHandler:

        Call tsmHotKey_Click(sender, e)

        If frmError.Visible = True Then Exit Sub
        frmError.lblErr.Text = "Hot Key has had an error at line " & Err.Erl & vbNewLine & vbNewLine & "Description: " & Err.Description & vbNewLine & vbNewLine & "Please report this to CyborgAutoProfiler@gmail.com"
        frmError.rtbErr.Text = "Hot Key has had an error! Error Description: " & Err.Description & vbNewLine & vbNewLine & "Operating System: " & My.Computer.Info.OSFullName & vbNewLine & "Operating System Version: " & My.Computer.Info.OSVersion & vbNewLine & "Cyborg Version: " & CurrentVersion

        frmError.ShowDialog()


    End Sub

    Private Sub tsmHotKey_Click(sender As Object, e As EventArgs) Handles tsmHotKey.Click
        If HotKeyEnabled = 1 Then
            HotKeyEnabled = 0
            tmrHotKey.Enabled = False
            tsmHotKey.Text = "              Enable Hot Key"
            tsmHotKey.ForeColor = Color.Green

        Else
            HotKeyEnabled = 1
            tmrHotKey.Enabled = True
            tsmHotKey.Text = "              Disable Hot Key"
            tsmHotKey.ForeColor = Color.Red
        End If

        SetSetting("HotKeyEnabled", HotKeyEnabled)
    End Sub



    Private Sub lblCP_Click(sender As Object, e As EventArgs) Handles lblCP.Click

    End Sub

    Private Sub tmrDrawText_Tick(sender As Object, e As EventArgs) Handles tmrDrawText.Tick
        'Dim i As Size = lblStatus.Location
        If lblCP.Size.Width >= 151 Then
            If lblCP.Location.X <= -lblCP.Size.Width + 10 Then
                lblCP.Location = New Point(160, lblCP.Location.Y)
            End If


            lblCP.Location = New Point(lblCP.Location.X - 1, lblCP.Location.Y)

        Else
            lblCP.Location = New Point(6, 16)

        End If
    End Sub

    Private Sub frmAutoProfiler_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then
            If Len(lblCP.Text) >= 14 Then
                tmrDrawText.Enabled = True
            Else
                tmrDrawText.Enabled = False
            End If
        Else
            tmrDrawText.Enabled = False
        End If
    End Sub

    Private Sub cmsProfilesRC_Closing(sender As Object, e As ToolStripDropDownClosingEventArgs) Handles cmsProfilesRC.Closing
        RC = False

        If e.CloseReason = ToolStripDropDownCloseReason.AppFocusChange Or e.CloseReason = ToolStripDropDownCloseReason.AppClicked Or e.CloseReason = ToolStripDropDownCloseReason.ItemClicked Or e.CloseReason = ToolStripDropDownCloseReason.Keyboard Then
            cmsProfiles.Close()
        End If
    End Sub

    Private Sub cmsProfilesRC_DragOver(sender As Object, e As DragEventArgs) Handles cmsProfilesRC.DragOver

    End Sub

    Private Sub cmsProfilesRC_MouseClick(sender As Object, e As MouseEventArgs) Handles cmsProfilesRC.MouseClick


    End Sub

    Private Sub cmsProfilesRC_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmsProfilesRC.Opening

    End Sub

    Private Sub tsmProfiles_MouseDown(sender As Object, e As MouseEventArgs) Handles tsmProfiles.MouseDown

    End Sub

    Private Sub tsmProfileRCEditProfile_Click(sender As Object, e As EventArgs) Handles tsmProfileRCEditProfile.Click
        On Error GoTo EndofSub
        Dim i As Byte

        RC = False

        If System.IO.File.Exists(PickedProfile) Then

            i = FindProfileFromPath(PickedProfile)
            If i > 0 Then
                Call LoadNewProfile(i)
                Process.Start(EditorPath)

            Else
                Call LoadProfile(PickedProfile)
                Process.Start(EditorPath)
            End If
        Else
            Call MsgBox("Selected profile does not exist!", vbCritical)
            Exit Sub
        End If

        cmtTaskbar.Close()
        cmsProfiles.Close()

        cmsProfilesRC.Close()
EndofSub:
    End Sub

    Private Sub tsbDonate_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=YQBQT9XZXS92S")
    End Sub

    Private Sub tmrLEDFlow_Disposed(sender As Object, e As EventArgs) Handles tmrLEDFlow.Disposed

    End Sub

    Private Sub tmrLEDFlow_Tick(sender As Object, e As EventArgs) Handles tmrLEDFlow.Tick
        Static Tick As Integer
        Static Delaying As Boolean
        Static IdleTick As Integer
        Static LastXY As Integer
        Static IsIdle As Boolean
        Static DetectingIdle As Boolean
        Static PulsingOff As Boolean

        If HasMMO7 = False Then Exit Sub


        If MousePosition.X + MousePosition.Y = LastXY And IsIdle = False Then


            MMO7HASCHANGEDLED = True

            If DetectingIdle = False Then
                IdleTick = Environment.TickCount + 290 * 1000
                DetectingIdle = True
            End If

            If Environment.TickCount >= IdleTick Then
                IsIdle = True
                'DetectingIdle = False
            End If

            LastXY = MousePosition.X + MousePosition.Y

        ElseIf MousePosition.X + MousePosition.Y <> LastXY Then

            If IsIdle = True Then
                IsIdle = False
            End If

            DetectingIdle = False
        End If

        LastXY = MousePosition.X + MousePosition.Y

        If IsIdle = True Then Exit Sub



        If Delaying = True Then
            If Environment.TickCount >= Tick Then
                Delaying = False
            Else
                Exit Sub
            End If
        End If

        If MMO7LEDCUSORPOS = 1 Then
            Dim structCursorPosition As POINTAPI
            Call GetCursorPos(structCursorPosition)
            Dim lColor As Integer = GetPixel(GetDC(0), structCursorPosition.x, structCursorPosition.y)

            Call SetMMO7LED(System.Drawing.ColorTranslator.FromOle(lColor).R, System.Drawing.ColorTranslator.FromOle(lColor).G, System.Drawing.ColorTranslator.FromOle(lColor).B, System.Drawing.ColorTranslator.FromOle(lColor).R, System.Drawing.ColorTranslator.FromOle(lColor).G, System.Drawing.ColorTranslator.FromOle(lColor).B)
            Exit Sub
        End If


        If MMO7LEDFlow(NextColor).Red = FLOW_RLED And MMO7LEDFlow(NextColor).Green = FLOW_GLED And MMO7LEDFlow(NextColor).Blue = FLOW_BLED Then

            If MMO7LedFlowPulse = 1 Then PulsingOff = True
            CurrentColor = NextColor
            Tick = Environment.TickCount + MMO7LEDFlowColorDelay * 1000
            Delaying = True

        End If

        If NextColor = CurrentColor Then

            If MMO7LedFlowRandom = 0 Then
                NextColor = CurrentColor + 1

                If NextColor >= MMO7LEDFlowCount Then NextColor = 0
                If MMO7LedFlowPulse = 1 Then PulsingOff = True
            Else
                NextColor = CInt(Math.Ceiling(Rnd() * MMO7LEDFlowCount - 1))
                If MMO7LedFlowPulse = 1 Then PulsingOff = True
            End If
        End If


        If PulsingOff = True Then
            If FLOW_RLED > 0 Then FLOW_RLED = FLOW_RLED - 1
            If FLOW_BLED > 0 Then FLOW_BLED = FLOW_BLED - 1
            If FLOW_GLED > 0 Then FLOW_GLED = FLOW_GLED - 1

            If FLOW_RLED = 0 And FLOW_GLED = 0 And FLOW_BLED = 0 Then PulsingOff = False
        Else

            If FLOW_RLED > MMO7LEDFlow(NextColor).Red Then
                FLOW_RLED = FLOW_RLED - 1
            ElseIf FLOW_RLED < MMO7LEDFlow(NextColor).Red Then
                FLOW_RLED = FLOW_RLED + 1
            End If

            If FLOW_GLED > MMO7LEDFlow(NextColor).Green Then
                FLOW_GLED = FLOW_GLED - 1
            ElseIf FLOW_GLED < MMO7LEDFlow(NextColor).Green Then
                FLOW_GLED = FLOW_GLED + 1
            End If

            If FLOW_BLED > MMO7LEDFlow(NextColor).Blue Then
                FLOW_BLED = FLOW_BLED - 1
            ElseIf FLOW_BLED < MMO7LEDFlow(NextColor).Blue Then
                FLOW_BLED = FLOW_BLED + 1
            End If
        End If


        Call SetMMO7LED(FLOW_RLED, FLOW_GLED, FLOW_BLED, FLOW_RLED, FLOW_GLED, FLOW_BLED)
    End Sub

    Private Sub tsmiMMO7FlowSettings_Click(sender As Object, e As EventArgs) Handles tsmiMMO7FlowSettings.Click
        If tmrLEDFlow.Enabled = True Then
            Call ToggleMMO7LEDFlow(False, False)
        End If

        frmMMO7LEDFlow.ShowDialog()
    End Sub

    Private Sub tsmiMMO7FlowToggle_Click(sender As Object, e As EventArgs) Handles tsmiMMO7FlowToggle.Click
        If tmrLEDFlow.Enabled = False Then
            Call ToggleMMO7LEDFlow(True, True)

        ElseIf tmrLEDFlow.Enabled = True Then
            Call ToggleMMO7LEDFlow(False, True)
        End If
    End Sub


    Private Sub tmrCheckDevices_Tick(sender As Object, e As EventArgs)
        Call FindDevices()
    End Sub

    Private Sub tmrShowDevices_Tick(sender As Object, e As EventArgs) Handles tmrShowDevices.Tick
        Static LDM As Byte

        If IsFindingDevices = True Then

            If LDM = 3 Then
                LDM = 0
                lblFindDevices.Text = "Finding Devices"
            End If

            LDM = LDM + 1

            lblFindDevices.Text = lblFindDevices.Text & "."

            lblFindDevices.Visible = True

        Else
            lblFindDevices.Visible = False
        End If

        If RefreshDevices = True And IsFindingDevices = False Then
            RefreshDevices = False
            Call ShowDevicePictures()
        End If
    End Sub

   
    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub


    Public Sub ChangeRATDPI(DPIX() As Integer, DPIY() As Integer)
        Dim NewDPI As Saitek.Devices.DpiPair
        Dim i As Byte

        If HasRAT3 = True Then Exit Sub

        NewDPI = New Saitek.Devices.DpiPair


        For i = 0 To 3
            NewDPI.X = DPIX(i)
            NewDPI.Y = DPIY(i)
            RAT.MouseDpi(i + 1, NewDPI)
        Next

    End Sub

End Class