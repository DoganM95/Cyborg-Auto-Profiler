Module modAutoProfiler

    '// This module is for anything CAP Related

    Public Declare Function SystemParametersInfo Lib "user32.dll" Alias "SystemParametersInfoA" (ByVal uAction As Int32, ByVal uParam As Int32, ByVal lpvParam As Int32, ByVal fuWinIni As Int32) As Int32
    Public Declare Function FindWindowHandle Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Integer
    Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    Public Declare Function GetWindowText Lib "user32" Alias "GetWindowTextA" (ByVal hwnd As IntPtr, ByVal lpString As String, ByVal cch As Integer) As Integer
    Public Declare Function GetWindowTextLength Lib "user32" Alias "GetWindowTextLengthA" (ByVal hwnd As Integer) As Integer
    Public Declare Function GetForegroundWindow Lib "user32" () As Integer
    Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As System.Windows.Forms.Keys) As Short
    Public Declare Function WindowFromPoint Lib "user32" (ByVal xpoint As Integer, ByVal ypoint As Integer) As Integer
    Public Declare Function GetAncestor Lib "user32" (ByVal hWnd As IntPtr, ByVal flags As Integer) As IntPtr
    Public Declare Function GetAsyncKeyState Lib "user32.dll" (ByVal vKey As Int32) As UShort
    Public Declare Sub keybd_event Lib "user32" (ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Integer, ByVal dwExtraInfo As Integer)
    Public Declare Auto Function GetWindowThreadProcessId Lib "user32.dll" (ByVal hWnd As IntPtr, ByRef ProcessID As Integer) As Integer

    Public Declare Function GetCursorPos Lib "user32" (ByRef lpPoint As POINTAPI) As Integer
    Public Declare Function GetDC Lib "user32" Alias "GetDC" (ByVal hwnd As Integer) As Integer
    Public Declare Function GetPixel Lib "gdi32" (ByVal hdc As Integer, ByVal x As Integer, ByVal y As Integer) As Integer


    Public Const WM_CLOSE As Long = &H10
    Public Const KEYEVENTF_KEYUP = &H2
    Public Const SPI_SETMOUSESPEED As Integer = 113
    Public Const SPIF_UPDATEINIFILE As Integer = &H1


    'Debugging option
    Public IsDebugging As Boolean = False

    ' Beta Settings
    Public Const IsBeta As Boolean = False
    Public Const BetaBuild As String = "0"

    Public NewVersion As String = "0.0.0"

    Public LogoText As String = ""

    'URLs
    Public WebpageURL As String = "http://CyborgAutoProfiler.com"

    'Files Version Information
    Public Const CAPSaitekDevicesVersion As String = "7.0.27.13"
    Public CurrentSaitekDevicesVersion As String
    Public NewMD5 As String


    Public LastProfilePath As String

    'Scripting file extension
    Public ScriptExt As String = ".vbs"

    ' Default Information from Start of application
    Public DefaultMouseSpeed As Byte


    ' Used for launching the ProfilerU software
    Public ProfilerU As Process
    Public CurrentVersion As String
    Public LastVersion As String

    ' Profiles data
    Public Profiles() As ProfileDat
    Public DefaultProfile As Byte
    Public MaxProfiles As Integer
    Public ActiveProfile As String
    Public ProfileHotKeyCount As Byte

    'Temp Profiles
    Public SelectedProfile As Byte
    Public TempProfiles() As ProfileDat
    Public TempMaxProfiles As Byte
    Public TempDefaultProfile As Byte


    ' Settings Data
    Public AutoEnable As Byte
    Public CheckforUpdate As Byte
    Public CheckTime As Integer
    Public HotKeyEnabled As Byte
    Public ProfilesDir As String
    Public EditorPath As String = Mid(Environment.GetFolderPath(Environment.SpecialFolder.System), 1, 2) & "\Program Files\SmartTechnology\Software\ProfileEditor.exe"
    Public DocPath As String = Mid(Environment.GetFolderPath(Environment.SpecialFolder.System), 1, 2) & "\Users\Public\Documents"
    Public DetectionType As Byte
    Public ShowTrayProfileChange As Byte
    Public RATRemeberDPIChange As Byte
    Public ScriptsDir As String = Application.StartupPath & "\Scripts\"
    Public ColorDestination As Byte
    Public ClearProfile As Byte
    Public WasEnabled As Boolean
    Public IsWaiting As Boolean
    Public RestartAPCheck As Boolean = False
    Public RefreshDevices As Boolean
    Public IgnoredDevices As String
    Public LEDFlowEnabled As Byte
    Public MMO7LEDCUSORPOS As Byte




    ' 0 = Color Count, 1 = Flow Rate, 2 = Random, All colors after that follow R,G,B 10 times.
    Public Const MMO7LEDFlowSettingsCount As Byte = 35

    ' Settings Global Count

    ' 0 = Caps Lock, 1 = Num Lock, 2 = Scroll Lock, 3 = Hot Key(1), 4 = Hot Key(2), 5 = Mouse Speed, 6 = Lock Profile, 7 = BSoD Protection
    Public Const ProfileSettingsCount As Byte = 7

    ' 0 = Change LED?, 1 = Left LED Color(R), 2 = Left LED Color(B), 3 = Left LED Color(G), 4 = Right LED Color(R), 5 = Right LED Color(B) _ 
    ' 6 = Right LED Color(G), 7 = DPI Mode Setting, 8 = Change Precision Aim?, 9 = Precision Aim X %, 10 = Precision Aim Y %, 11 = LED Use Flow
    ' 12 = Change DPI Settings, 13 = DPI(1) X, 14 = DPI(1) Y, 15 = DPI(2) X, 16 = DPI(2) Y, 17 = DPI(3) X, 18 = DPI(3) Y, 19 = DPI(4) X, 20 = DPI(4) Y

    Public Const RATSettingsCount As Byte = 20


    ' Public Const ProfilerUHandle As String = "Saitek Device Monitor"

    'Gettings errors for saving too fast, a little delay fixed it.
    Public SaveDelay As Byte = 100

    ' Local data for handling profiles
    Public LastProfile As Byte
    Public LoadedProfile As Byte
    Public UsingDefaultProfile As Boolean
    Public FirstLaunch As Boolean
    Public ProfileLocked As Boolean
    Public LockedProfile As Byte



    'Hot key
    Public ProfileHotKey() As HotKeyClass

    ' MMO7 LED Flow
    Public MMO7LEDFlow(0 To 9) As MMO7LEDFlowClass

    ' Max amount of profiles for the DB
    Public Const PROFILECOUNT As Integer = 1000
    Public DBFileLoc As String = Application.StartupPath & "/Profiles.db"

    Public PDB(0 To PROFILECOUNT) As ProfileDB

    Public Structure POINTAPI
        Dim x As Integer
        Dim y As Integer
    End Structure
    Public Structure ProfileDat

        Dim ProfilePath As String
        Dim ProcessName As String
        Dim Settings As String
        Dim RATCS As String
        Dim Script As String

    End Structure
    Public Structure HotKeyClass
        Public HotKeyProfile As Byte
        Public HotKeyChr As Integer
        Public HotKeyChr2 As Integer
    End Structure
    Public Structure MMO7LEDFlowClass
        Public Red As Byte
        Public Green As Byte
        Public Blue As Byte
    End Structure

    <Serializable()>
    Public Structure ProfileDB

        Dim ProfileName As String
        Dim ProfileDownload As String
        Dim ProfileDevices As String
        Dim ProfileDescription As String
        Dim ProfileProcess As String
        Dim ProfileCategory As Byte

    End Structure
    Public Sub CloseCAP()

        ' Check if we need to restore the mouse speed
        If SystemInformation.MouseSpeed <> DefaultMouseSpeed Then
            SystemParametersInfo(SPI_SETMOUSESPEED, 0, DefaultMouseSpeed, SPIF_UPDATEINIFILE)
        End If

        ' If we have the MMO7 Mouse lets be nice and change the LED back to the one before we changed it.
        If HasRAT = True Then

            If RATReadMode IsNot Nothing Then RATReadMode.Stop()

            Call SetRATDefualtDPI()

            If HasMMO7 = True Then
                If MMO7HASCHANGEDLED = True Then
                    Call SetMMO7DefaultLed()
                End If
            End If

            If RATHASCHANGEDDPI = True Then
                Call SetRATDPIMode(RATDEFAULTDPI)
            End If

        End If

        ' Shut it down!!
        Application.Exit()

    End Sub
    Public Sub ToggleSoftware()
        If frmAutoProfiler.tmrAPCheck.Enabled = True Then
            Call SetCheckerStatus(False)
        Else
            Call SetCheckerStatus(True)
        End If
    End Sub
    Public Sub ClearProfiles()
        Dim i As Integer

        ReDim Profiles(0 To 255)
        ReDim TempProfiles(0 To 255)
        ReDim ProfileHotKey(0 To 255)


        For i = 0 To MaxProfiles

            Profiles(i).ProfilePath = ""
            Profiles(i).ProcessName = ""
            Profiles(i).Settings = "0/0/0/0/0/0"
            Profiles(i).RATCS = "0/0/0/0/0/0/0/0/0/0/0/0/0/0/0/0/0/0/0/0"
            Profiles(i).Script = "None"

            ProfileHotKey(i).HotKeyProfile = 0
            ProfileHotKey(i).HotKeyChr = 0
        Next i

    End Sub
    Public Sub CreateDefaultSettings()



        SetSetting("Version", My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build)

        If System.IO.Directory.Exists(DocPath & "\SmartTechnology Profiles") Then
            SetSetting("ProfilesDirectory", DocPath & "\SmartTechnology Profiles")
        Else
            SetSetting("ProfilesDirectory", DocPath & "\Saitek SD6 Profiles")
        End If

        SetSetting("CheckforUpdates", "1")
        SetSetting("Profiles", "0")
        SetSetting("DefaultProfile", "0")
        SetSetting("ClearProfile", "0")
        SetSetting("CheckTime", "1000")
        SetSetting("AutoEnable", "0")
        SetSetting("HotKeyEnabled", 0)
        SetSetting("SystemTrayInfo", "1")
        SetSetting("DetectionType", "1")
        SetSetting("Version", My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build)


        'Call LoadSettings()
        Application.DoEvents()

    End Sub
    Public Sub SaveSettings()

        'SetSetting("ProfilerPath", PPath)

        SetSetting("ProfilesDirectory", ProfilesDir)
        SetSetting("Version", My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build)
        SetSetting("CheckforUpdates", CheckforUpdate)
        SetSetting("Profiles", MaxProfiles)
        SetSetting("DefaultProfile", DefaultProfile)
        SetSetting("ClearProfile", ClearProfile)
        SetSetting("CheckTime", CheckTime)
        SetSetting("AutoEnable", AutoEnable)
        SetSetting("HotKeyEnabled", HotKeyEnabled)
        SetSetting("SystemTrayInfo", ShowTrayProfileChange)
        SetSetting("DetectionType", DetectionType)
        SetSetting("RATRDC", RATRemeberDPIChange)
        SetSetting("MMO7LEDFlowSettings", MMO7LEDFlowSettings)
        SetSetting("MMO7LEDFlowColorDelay", MMO7LEDFlowColorDelay)
        SetSetting("IgnoredDevices", IgnoredDevices)
        SetSetting("LEDFlowEnabled", LEDFlowEnabled)

    End Sub
    Public Sub SaveTempProfiles()
        Dim i As Integer

        MaxProfiles = TempMaxProfiles
        DefaultProfile = TempDefaultProfile





        'Make the Current Profile class the Temp profile settings
        For i = 1 To MaxProfiles
            Profiles(i).ProfilePath = TempProfiles(i).ProfilePath
            Profiles(i).ProcessName = TempProfiles(i).ProcessName
            Profiles(i).Settings = TempProfiles(i).Settings
            Profiles(i).RATCS = TempProfiles(i).RATCS
            Profiles(i).Script = TempProfiles(i).Script
        Next



        Call SaveSettings()


        For i = 1 To MaxProfiles
            SetSetting("Profile" & " " & i & " Name", Profiles(i).ProfilePath)
            SetSetting("Profile" & " " & i & " Process", Profiles(i).ProcessName)
            SetSetting("Profile" & " " & i & " Settings", Profiles(i).Settings)
            SetSetting("Profile" & " " & i & " RATSettings", Profiles(i).RATCS)
            SetSetting("Profile" & " " & i & " Script", Profiles(i).Script)
        Next


        Call EnumerateHotKeys()
    End Sub
    Public Sub SaveProfiles()

        For i = 1 To MaxProfiles
            SetSetting("Profile" & " " & i & " Name", Profiles(i).ProfilePath)
            SetSetting("Profile" & " " & i & " Process", Profiles(i).ProcessName)
            SetSetting("Profile" & " " & i & " Settings", Profiles(i).Settings)
            SetSetting("Profile" & " " & i & " RATSettings", Profiles(i).RATCS)
            SetSetting("Profile" & " " & i & " Script", Profiles(i).Script)
        Next

        Call EnumerateHotKeys()
    End Sub

    Public Sub LoadSettings()
        Dim i As Integer, Temp As String


        'PPath = GetSetting("ProfilerPath")
        ProfilesDir = GetSetting("ProfilesDirectory")

        LastVersion = GetSetting("Version")

        CheckforUpdate = Val(GetSetting("CheckforUpdates"))

        AutoEnable = Val(GetSetting("AutoEnable"))

        HotKeyEnabled = Val(GetSetting("HotKeyEnabled"))

        ShowTrayProfileChange = Val(GetSetting("SystemTrayInfo"))

        MaxProfiles = Val(GetSetting("Profiles"))

        DefaultProfile = Val(GetSetting("DefaultProfile"))

        ClearProfile = Val(GetSetting("ClearProfile"))

        DetectionType = Val(GetSetting("DetectionType"))

        RATRemeberDPIChange = Val(GetSetting("RATRDC"))

        CheckTime = Val(GetSetting("CheckTime"))

        MMO7LEDFlowSettings = GetSetting("MMO7LEDFlowSettings")

        IgnoredDevices = GetSetting("IgnoredDevices")

        LEDFlowEnabled = Val(GetSetting("LEDFlowEnabled"))


        If LEDFlowEnabled = 1 Then
            MMO7FLOWDEFAULT = True
            Call ToggleMMO7LEDFlow(True, False)
        End If

        Temp = GetSetting("MMO7LEDFlowColorDelay")

        If Temp = "" Then
            MMO7LEDFlowColorDelay = 0
        Else
            MMO7LEDFlowColorDelay = Convert.ToDecimal(GetSetting("MMO7LEDFlowColorDelay"))
        End If

        If CheckTime < 1 Or CheckTime > 30000 Then CheckTime = 1000

        frmAutoProfiler.tmrAPCheck.Interval = CheckTime

        For i = 1 To MaxProfiles

            Profiles(i).ProfilePath = GetSetting("Profile" & " " & i & " Name")
            Profiles(i).ProcessName = GetSetting("Profile" & " " & i & " Process")
            Profiles(i).Settings = GetSetting("Profile" & " " & i & " Settings")
            Profiles(i).RATCS = GetSetting("Profile" & " " & i & " RATSettings")
            Profiles(i).Script = GetSetting("Profile" & " " & i & " Script")

            If Profiles(i).Settings = "" Then
                Profiles(i).Settings = "0/0/0"
            End If

            If Profiles(i).RATCS = "" Then
                Temp = GetSetting("Profile" & " " & i & " MMO7CustomSettings")

                If Temp <> "" Then
                    Profiles(i).RATCS = Temp
                Else
                    Profiles(i).RATCS = "0/0/0/0/0/0/0/0/0/0/0/0/0/0/0/0/0/0/0/0"
                End If

            End If

        Next

RemoveLostProfiles:


        For i = 0 To MaxProfiles
            If i > 0 Then
                If System.IO.File.Exists(Profiles(i).ProfilePath) = False Then

                    'Check if it's the old versions Settings
                    If System.IO.File.Exists(ProfilesDir & "\" & Profiles(i).ProfilePath) = True Then
                        Profiles(i).ProfilePath = ProfilesDir & "\" & Profiles(i).ProfilePath
                    Else
                        Call MsgBox("Could not find '" & Profiles(i).ProfilePath & "'! Removing profile! Save in Profile Editor if you would like to keep changes.", vbExclamation)
                        Call DeleteProfile(i)
                        GoTo RemoveLostProfiles
                    End If
                End If
            End If
        Next


        Call EnumerateHotKeys()


    End Sub
    Public Sub LoadTempProfiles()
        Dim i As Byte


        Call SetCheckerStatus(False)


        If System.IO.Directory.Exists(ProfilesDir) = False Then
            Call MsgBox("No Profile Directory found! Please set a Profile Directory first!", vbCritical)
            Exit Sub
        End If


        'Make the Temp Profile class the current profile settings
        For i = 1 To MaxProfiles

            TempProfiles(i).ProfilePath = Profiles(i).ProfilePath
            TempProfiles(i).ProcessName = Profiles(i).ProcessName
            TempProfiles(i).Settings = Profiles(i).Settings
            TempProfiles(i).RATCS = Profiles(i).RATCS
            TempProfiles(i).Script = Profiles(i).Script
        Next



        TempMaxProfiles = MaxProfiles
        TempDefaultProfile = DefaultProfile

        ' If DetectionType = 1 Then
        '    frmProfiles.chkDefaultP.Enabled = False
        ' Else
        '    frmProfiles.chkDefaultP.Enabled = True
        'End If



        Call LoadProfileList()
        Call ReloadTempProfileList()

        If HasRAT = True Then


            frmProfilesSettings.gbRAT.Visible = True
            frmProfilesSettings.lblDPIMode.Text = "No Change."
            frmProfilesSettings.tbDPI.Value = 0

            If HasMMO7 = False Then
                frmProfilesSettings.gbRAT.Text = "RAT"

                If frmProfilesSettings.tcMMO7.Controls.Count = 4 Then
                    frmProfilesSettings.tcMMO7.Controls.RemoveAt(3)
                End If

            End If

        End If

        'If System.IO.File.Exists(EditorPath) = True Then
        '    frmProfilesSettings.cmdEditProfile.Visible = True
        'Else
        '    frmProfilesSettings.cmdEditProfile.Visible = False
        'End If


        frmProfilesSettings.lstProfiles.SelectedIndex = -1

        frmProfilesSettings.ShowDialog()

    End Sub
    Public Sub LoadMMO7LEDFlowSettings()
        Dim c() As Byte



        c = GetMMO7LEDFlowSetting(MMO7LEDFlowSettings)

        MMO7LEDFlowCount = c(0)

        MMO7LEDFlowSpeed = c(1)

        If MMO7LEDFlowSpeed <= 0 Then
            MMO7LEDFlowSpeed = 50
        End If

        frmAutoProfiler.tmrLEDFlow.Interval = MMO7LEDFlowSpeed

        MMO7LedFlowRandom = c(2)
        MMO7LedFlowPulse = c(34)
        MMO7LEDCUSORPOS = c(35)
        'MMO7LEDFlowColorDelay = c(3)


        MMO7LEDFlow(0).Red = c(4)
        MMO7LEDFlow(0).Green = c(5)
        MMO7LEDFlow(0).Blue = c(6)

        MMO7LEDFlow(1).Red = c(7)
        MMO7LEDFlow(1).Green = c(8)
        MMO7LEDFlow(1).Blue = c(9)

        MMO7LEDFlow(2).Red = c(10)
        MMO7LEDFlow(2).Green = c(11)
        MMO7LEDFlow(2).Blue = c(12)

        MMO7LEDFlow(3).Red = c(13)
        MMO7LEDFlow(3).Green = c(14)
        MMO7LEDFlow(3).Blue = c(15)

        MMO7LEDFlow(4).Red = c(16)
        MMO7LEDFlow(4).Green = c(17)
        MMO7LEDFlow(4).Blue = c(18)

        MMO7LEDFlow(5).Red = c(19)
        MMO7LEDFlow(5).Green = c(20)
        MMO7LEDFlow(5).Blue = c(21)

        MMO7LEDFlow(6).Red = c(22)
        MMO7LEDFlow(6).Green = c(23)
        MMO7LEDFlow(6).Blue = c(24)

        MMO7LEDFlow(7).Red = c(25)
        MMO7LEDFlow(7).Green = c(26)
        MMO7LEDFlow(7).Blue = c(27)

        MMO7LEDFlow(8).Red = c(28)
        MMO7LEDFlow(8).Green = c(29)
        MMO7LEDFlow(8).Blue = c(30)

        MMO7LEDFlow(9).Red = c(31)
        MMO7LEDFlow(9).Green = c(32)
        MMO7LEDFlow(9).Blue = c(33)

    End Sub
    Public Sub SaveMMO7LEDFlowSettings()


        SetMMO7FlowSettings(0, MMO7LEDFlowCount)
        SetMMO7FlowSettings(1, MMO7LEDFlowSpeed)
        SetMMO7FlowSettings(2, MMO7LedFlowRandom)
        SetMMO7FlowSettings(3, MMO7LEDFlowColorDelay)
        SetMMO7FlowSettings(34, MMO7LedFlowPulse)
        SetMMO7FlowSettings(35, MMO7LEDCUSORPOS)

        SetMMO7FlowSettings(4, MMO7LEDFlow(0).Red)
        SetMMO7FlowSettings(5, MMO7LEDFlow(0).Green)
        SetMMO7FlowSettings(6, MMO7LEDFlow(0).Blue)

        SetMMO7FlowSettings(7, MMO7LEDFlow(1).Red)
        SetMMO7FlowSettings(8, MMO7LEDFlow(1).Green)
        SetMMO7FlowSettings(9, MMO7LEDFlow(1).Blue)

        SetMMO7FlowSettings(10, MMO7LEDFlow(2).Red)
        SetMMO7FlowSettings(11, MMO7LEDFlow(2).Green)
        SetMMO7FlowSettings(12, MMO7LEDFlow(2).Blue)

        SetMMO7FlowSettings(13, MMO7LEDFlow(3).Red)
        SetMMO7FlowSettings(14, MMO7LEDFlow(3).Green)
        SetMMO7FlowSettings(15, MMO7LEDFlow(3).Blue)

        SetMMO7FlowSettings(16, MMO7LEDFlow(4).Red)
        SetMMO7FlowSettings(17, MMO7LEDFlow(4).Green)
        SetMMO7FlowSettings(18, MMO7LEDFlow(4).Blue)

        SetMMO7FlowSettings(19, MMO7LEDFlow(5).Red)
        SetMMO7FlowSettings(20, MMO7LEDFlow(5).Green)
        SetMMO7FlowSettings(21, MMO7LEDFlow(5).Blue)

        SetMMO7FlowSettings(22, MMO7LEDFlow(6).Red)
        SetMMO7FlowSettings(23, MMO7LEDFlow(6).Green)
        SetMMO7FlowSettings(24, MMO7LEDFlow(6).Blue)

        SetMMO7FlowSettings(25, MMO7LEDFlow(7).Red)
        SetMMO7FlowSettings(26, MMO7LEDFlow(7).Green)
        SetMMO7FlowSettings(27, MMO7LEDFlow(7).Blue)

        SetMMO7FlowSettings(28, MMO7LEDFlow(8).Red)
        SetMMO7FlowSettings(29, MMO7LEDFlow(8).Green)
        SetMMO7FlowSettings(30, MMO7LEDFlow(8).Blue)

        SetMMO7FlowSettings(31, MMO7LEDFlow(9).Red)
        SetMMO7FlowSettings(32, MMO7LEDFlow(9).Green)
        SetMMO7FlowSettings(33, MMO7LEDFlow(9).Blue)

        Call SaveSettings()
    End Sub
    Public Sub LoadProfileList()
        Dim folderInfo As New IO.DirectoryInfo(ProfilesDir)
        Dim arrFilesInFolder() As IO.FileInfo
        Dim arrDirectoriesInFolder() As IO.DirectoryInfo
        Dim fileInFolder As IO.FileInfo
        Dim i As Byte, b As Byte
        Dim AlreadyUsed(0 To 255) As Boolean

        frmAddProfile.cbProfiles.Items.Clear()
        frmProfilesSettings.lstProcesses.Items.Clear()


        arrFilesInFolder = folderInfo.GetFiles("*.pr0*")

        arrDirectoriesInFolder = folderInfo.GetDirectories


        For Each fileInFolder In arrFilesInFolder


            If Len(fileInFolder.Name) > 3 Then
                frmAddProfile.cbProfiles.Items.Add(fileInFolder.Name)
            End If

        Next

        'Subfolders
        For Each directoryInFolder In arrDirectoriesInFolder

            folderInfo = New IO.DirectoryInfo(directoryInFolder.FullName)
            arrFilesInFolder = folderInfo.GetFiles("*.pr0*")

            For Each fileInFolder In arrFilesInFolder


                If Len(fileInFolder.Name) > 3 Then

                    frmAddProfile.cbProfiles.Items.Add(directoryInFolder.Name & "\" & fileInFolder.Name)

                End If
            Next

        Next




        ' If the profile count is the exact as the amount of profiles go ahead and skip cause we are using them all.
        If frmAddProfile.cbProfiles.Items.Count = TempMaxProfiles Then
            frmAddProfile.cbProfiles.Items.Clear()
            frmAddProfile.cbProfiles.Items.Add("No Profiles")
            frmAddProfile.cbProfiles.SelectedIndex = 0
            frmAddProfile.cmdAdd.Enabled = False
            Exit Sub
        End If

RemoveAgain:

        ' Clean out the profiles already in use. Wash and repeat to RemoveAgain till done.
        For i = 0 To frmAddProfile.cbProfiles.Items.Count - 1
            For b = 1 To TempMaxProfiles

                If frmAddProfile.cbProfiles.Items.Item(i) = GetProfileName(TempProfiles(b).ProfilePath) & ".pr0" Then
                    frmAddProfile.cbProfiles.Items.RemoveAt(i)
                    GoTo RemoveAgain
                End If
            Next
        Next



        frmAddProfile.cbProfiles.SelectedIndex = 0
        frmAddProfile.cmdAdd.Enabled = True
    End Sub
    Public Sub LoadScriptList()
        Dim folderInfo As New IO.DirectoryInfo(ScriptsDir)
        Dim arrFilesInFolder() As IO.FileInfo
        Dim fileInFolder As IO.FileInfo



        frmProfilesSettings.cbScript.Items.Clear()


        arrFilesInFolder = folderInfo.GetFiles("*" & ScriptExt & "*")

        frmProfilesSettings.cbScript.Items.Add("None")

        For Each fileInFolder In arrFilesInFolder


            If Len(fileInFolder.Name) > 3 Then
                frmProfilesSettings.cbScript.Items.Add(Mid(fileInFolder.Name, 1, Len(fileInFolder.Name) - 4))
            End If

        Next

        frmProfilesSettings.cbScript.SelectedIndex = 0

    End Sub
    Public Sub ReloadTempProfileList()
        Dim i As Byte

        frmProfilesSettings.lstProfiles.Items.Clear()

        For i = 1 To TempMaxProfiles

            If i = TempDefaultProfile Then
                frmProfilesSettings.lstProfiles.Items.Add(GetProfileName(TempProfiles(i).ProfilePath) & " (Default)")
            Else
                frmProfilesSettings.lstProfiles.Items.Add(GetProfileName(TempProfiles(i).ProfilePath))
            End If
        Next


    End Sub
    Public Sub ClearTempProfiles()
        Dim I As Byte

        For I = 1 To MaxProfiles

            TempProfiles(I).ProfilePath = ""
            TempProfiles(I).ProcessName = ""
            TempProfiles(I).Settings = "0/0/0"
            TempProfiles(I).RATCS = "0/0/0/0/0/0/0/0/0/0/0/0/0/0/0/0/0/0/0/0"
            TempProfiles(I).Script = "None"
        Next

        TempMaxProfiles = 0
        TempDefaultProfile = 0

    End Sub
    Public Sub CheckVersion()
        Dim i As Byte, x() As Integer, y() As Integer


        If LastVersion = CurrentVersion Then Exit Sub

        If IsVersionLower(LastVersion, CurrentVersion) = True Then

            ' 3.1.6 Update
            If IsVersionLower("3.1.5", CurrentVersion) = True Then

                ' Change the boot with windows settings

                ' Delete the old
                If Not My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", False).GetValue("CyborgAutoProfiler") = Nothing Then
                    My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue("CyborgAutoProfiler")
                    My.Computer.Registry.CurrentUser.Close()
                End If

                ' Setup the new if possible
                If IsAdmin() = True Then
                    My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue("CyborgAutoProfiler", Chr(34) & Application.ExecutablePath & Chr(34) & " -minimize", Microsoft.Win32.RegistryValueKind.String)
                    My.Computer.Registry.LocalMachine.Close()
                End If
            End If


            ' 3.1.5 Update
            If IsVersionLower("3.1.4", CurrentVersion) = True Then

                ' Lets get rid of the old shortcut method and replace it with the new one
                If System.IO.File.Exists("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Startup\Cyborg Auto-Profiler.lnk") = True Then
                    System.IO.File.Delete("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Startup\Cyborg Auto-Profiler.lnk")

                    ' Setup the new if possible
                    If IsAdmin() = True Then
                        My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue("CyborgAutoProfiler", Chr(34) & Application.ExecutablePath & Chr(34) & " -minimize", Microsoft.Win32.RegistryValueKind.String)
                        My.Computer.Registry.LocalMachine.Close()
                    End If
                End If

                SetSetting("Version", My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build)

                ' Lets add the new script examples.
                System.IO.File.WriteAllText(Application.StartupPath & "\Scripts\Kill Process Script.vbs", My.Resources.Kill_Process_Script)
                System.IO.File.WriteAllText(Application.StartupPath & "\Scripts\Run Process Script.vbs", My.Resources.Run_Process_Script)
                System.IO.File.WriteAllText(Application.StartupPath & "\Scripts\uTorrent - Close&Open.vbs", My.Resources.uTorrent___Close_Open)

            End If

            ' 3.1.2 Update
            If IsVersionLower("3.1.1", CurrentVersion) = True Then

                For i = 0 To MaxProfiles

                    x = GetProfileSettings(Profiles(i).Settings)
                    y = GetOldRATCS(Profiles(i).RATCS)

                    Call SetProfileSettings(3, i, y(11), False)
                    Call SetProfileSettings(4, i, y(12), False)

                Next

                Call SaveProfiles()

                SetSetting("Version", My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build)
                Exit Sub
            End If

            '3.0.1 
            If LastVersion = "3.0.0" Then
                CheckforUpdate = True
                SetSetting("CheckforUpdates", "1")

                SetSetting("Version", My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build)
            End If

            '3.0.0 Update
            If LastVersion = "" Then

                CheckforUpdate = True

                For i = 0 To MaxProfiles
                    If Profiles(i).ProcessName <> "" Then
                        Profiles(i).ProcessName = Replace(Profiles(i).ProcessName, ":", "�")
                    End If
                Next

                Call SaveSettings()
                Call SaveProfiles()
            End If


        End If
    End Sub

    Public Sub RunScript(ScriptName As String, SubName As String)
        On Error GoTo ScriptError

        If System.IO.File.Exists(Application.StartupPath & "\Scripts\" & ScriptName & ScriptExt) = False Then Exit Sub

        Dim ScriptToRun As String = System.IO.File.OpenText(Application.StartupPath & "\Scripts\" & ScriptName & ScriptExt).ReadToEnd

        ' Check if the requested Sub exist.
        If InStr(LCase(ScriptToRun), "sub " & LCase(SubName), CompareMethod.Text) = 0 Then Exit Sub

        Dim myScript As New MSScriptControl.ScriptControl

        myScript = New MSScriptControl.ScriptControl
        myScript.Language = "VBScript"
        myScript.AddCode(ScriptToRun)
        myScript.Run(SubName)

        Exit Sub

ScriptError:
        Call MsgBox("an error has ocured from the script '" & ScriptName & "'" & vbCrLf & "Description: " & Err.Description, vbCritical)

    End Sub
    Public Function GetSetting(ByVal Key As String) As String
        Dim sReturn As String = String.Empty
        Dim dsSettings As New DataSet

        dsSettings.Dispose()

        If System.IO.File.Exists(Application.StartupPath & "\Settings.xml") Then
            dsSettings.ReadXml(Application.StartupPath & "\Settings.xml")
        Else
            dsSettings.Tables.Add("Settings")
            dsSettings.Tables(0).Columns.Add("Key", GetType(String))
            dsSettings.Tables(0).Columns.Add("Value", GetType(String))
        End If

        Dim dr() As DataRow = dsSettings.Tables("Settings").Select("Key = '" & Key & "'")
        If dr.Length = 1 Then sReturn = dr(0)("Value").ToString


        Return sReturn
    End Function

    Public Sub SetSetting(ByVal Key As String, ByVal Value As String)
        On Error GoTo ReportE
        Dim DSSettings As New DataSet
        Dim i As Long

        dsSettings.Dispose()

        If System.IO.File.Exists(Application.StartupPath & "\Settings.xml") Then
            dsSettings.ReadXml(Application.StartupPath & "\Settings.xml")
        Else
            dsSettings.Tables.Add("Settings")
            dsSettings.Tables(0).Columns.Add("Key", GetType(String))
            dsSettings.Tables(0).Columns.Add("Value", GetType(String))
        End If

        Dim dr() As DataRow = dsSettings.Tables(0).Select("Key = '" & Key & "'")
        If dr.Length = 1 Then
            dr(0)("Value") = Value
        Else
            Dim drSetting As DataRow = dsSettings.Tables("Settings").NewRow
            drSetting("Key") = Key
            drSetting("Value") = Value
            dsSettings.Tables("Settings").Rows.Add(drSetting)
        End If


        dsSettings.WriteXml(Application.StartupPath & "\Settings.xml")

        Threading.Thread.Sleep(SaveDelay)
        Application.DoEvents()
        Exit Sub

ReportE:
        Call MsgBox("Saving Failed!", vbCritical)
    End Sub




    Public Sub KillProfilerU()
        'Dim ProfileH As Integer
        'ProfileH = FindWindowHandle(vbNullString, ProfilerUHandle)

        'If Not ProfileH.Equals(0) Then
        '    SendMessage(ProfileH, WM_CLOSE, 0, 0)
        'Else
        '    If IsProfilerURunning() = True Then
        '        Call ForceKillProfilerU()
        '    End If
        'End If

    End Sub
    Public Sub ForceKillProfilerU()
        Dim KP() As Process = System.Diagnostics.Process.GetProcessesByName("ProfilerU")

        ' This is where we murder the 'ProfilerU' Process. May it rest in peace.
        For Each MyKill As Process In KP
            MyKill.Kill()

        Next
    End Sub
    Public Sub SetCheckerStatus(ByVal Enabled As Boolean)



        If Enabled = True Then
            frmAutoProfiler.tmrAPCheck.Enabled = True
            frmAutoProfiler.lblStatus.Text = "Enabled"
            frmAutoProfiler.lblStatus.ForeColor = Color.Green
            frmAutoProfiler.tsmED.Text = "          Disable"
            frmAutoProfiler.cmdED.Text = "Disable"
            frmAutoProfiler.tsmED.ForeColor = Color.Red
            frmAutoProfiler.TaskIcon.Icon = My.Resources.CAP___Green
            frmAutoProfiler.Icon = My.Resources.CAP___Green
        Else
            frmAutoProfiler.tmrAPCheck.Enabled = False
            frmAutoProfiler.lblStatus.Text = "Disabled"
            frmAutoProfiler.lblStatus.ForeColor = Color.Red
            frmAutoProfiler.tsmED.Text = "          Enable"
            frmAutoProfiler.tsmED.ForeColor = Color.Green
            frmAutoProfiler.cmdED.Text = "Enable"

            frmAutoProfiler.lblCP.Text = "None"
            LoadedProfile = 0
            UsingDefaultProfile = False
            frmAutoProfiler.TaskIcon.Icon = My.Resources.CAP
            frmAutoProfiler.Icon = My.Resources.CAP
            frmAutoProfiler.TaskIcon.Text = "Cyborg Auto-Profiler"



        End If
    End Sub
    Public Sub MigrateProfiles()
        Dim folderInfo As New IO.DirectoryInfo(DocPath & "\Saitek SD6 Profiles")
        Dim arrFilesInFolder() As IO.FileInfo
        Dim fileInFolder As IO.FileInfo


        arrFilesInFolder = folderInfo.GetFiles("*.*")
        For Each fileInFolder In arrFilesInFolder

            If Len(fileInFolder.Name) > 3 Then
                If LCase(Mid(fileInFolder.Name, Len(fileInFolder.Name) - 3)) = ".pr0" Then
                    System.IO.File.Copy(fileInFolder.FullName, ProfilesDir & "\" & fileInFolder.Name, overwrite:=True)
                End If
            End If
        Next

        Call MsgBox("Migration Successful!", vbInformation)

    End Sub
    Public Sub DeleteProfile(ByVal Profile As Byte)
        Dim i As Byte

        If DefaultProfile = Profile Then DefaultProfile = 0

        For i = Profile To MaxProfiles - 1
            Profiles(i).ProfilePath = Profiles(i + 1).ProfilePath
            Profiles(i).ProcessName = Profiles(i + 1).ProcessName
            Profiles(i).RATCS = Profiles(i + 1).RATCS

            If DefaultProfile = i + 1 Then DefaultProfile = i
        Next

        Profiles(MaxProfiles).ProfilePath = ""
        Profiles(MaxProfiles).ProcessName = ""
        Profiles(MaxProfiles).RATCS = "0/0/0/0/0/0/0/0/0/0/0/0/0/0/0/0/0/0/0/0"


        MaxProfiles = MaxProfiles - 1
    End Sub
    Public Sub SetProfileSettings(ByVal Index As Byte, ByVal Profile As Byte, ByVal NewVal As Integer, ByVal TempProfile As Boolean)
        Dim c() As Integer, i As Byte

        If TempProfile = True Then
            With TempProfiles(Profile)

                c = GetProfileSettings(.Settings)

                c(Index) = NewVal

                .Settings = ""

                For i = 0 To ProfileSettingsCount - 1
                    .Settings = .Settings & c(i) & "/"
                Next

                .Settings = .Settings & c(ProfileSettingsCount)

            End With
        Else
            With Profiles(Profile)

                c = GetProfileSettings(.Settings)

                c(Index) = NewVal

                .Settings = ""

                For i = 0 To ProfileSettingsCount - 1
                    .Settings = .Settings & c(i) & "/"
                Next

                .Settings = .Settings & c(ProfileSettingsCount)

            End With
        End If
    End Sub


    Public Sub SetRATCustomSettings(ByVal Index As Byte, ByVal Profile As Byte, ByVal NewVal As Integer, ByVal TempProfile As Boolean)
        Dim c() As Integer, i As Byte

        If TempProfile = True Then
            With TempProfiles(Profile)

                c = GetRATCSettings(.RATCS)

                c(Index) = NewVal

                .RATCS = ""

                For i = 0 To RATSettingsCount - 1
                    .RATCS = .RATCS & c(i) & "/"
                Next

                .RATCS = .RATCS & c(RATSettingsCount)

            End With
        Else
            With Profiles(Profile)

                c = GetRATCSettings(.RATCS)

                c(Index) = NewVal

                .RATCS = ""

                For i = 0 To RATSettingsCount - 1
                    .RATCS = .RATCS & c(i) & "/"
                Next

                .RATCS = .RATCS & c(RATSettingsCount)

            End With
        End If

    End Sub
    Public Sub SetIgnoredDevices(ByVal DeviceAliase As String, Ignored As Boolean)
        Dim s() As String
        Dim i As Byte


        If Ignored = True Then

            IgnoredDevices = IgnoredDevices & DeviceAliase & "/"
        Else

            If IgnoredDevices.Contains(DeviceAliase) = True Then
                s = Split(IgnoredDevices, "/")

                IgnoredDevices = ""

                For i = 0 To s.Count - 2
                    If s(i) <> DeviceAliase Then
                        IgnoredDevices = IgnoredDevices & s(i) & "/"
                    End If
                Next i


            End If
        End If

    End Sub
    Public Function IsDeviceIgnored(ByVal DeviceAliase As String) As String
        
        If IgnoredDevices.Contains(DeviceAliase) = True Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Sub SetMMO7FlowSettings(ByVal Index As Byte, ByVal NewVal As Byte)
        Dim c() As Byte, i As Byte



        c = GetMMO7LEDFlowSetting(MMO7LEDFlowSettings)

        c(Index) = NewVal

        MMO7LEDFlowSettings = ""

        For i = 0 To MMO7LEDFlowSettingsCount - 1
            MMO7LEDFlowSettings = MMO7LEDFlowSettings & c(i) & "/"
        Next

        MMO7LEDFlowSettings = MMO7LEDFlowSettings & c(MMO7LEDFlowSettingsCount)


    End Sub
    Public Sub ShowDevicePictures()
        Dim i As Byte

        For i = 1 To 8
            Call ModifyDevicePicture(i, Nothing, "")
        Next


        i = 0



        'Default Positions and Sizes
        frmAutoProfiler.gbDevices.Size = New Size(158, 60)
        frmAutoProfiler.pbDPIMode.Location = New Point(6, 14)


        If DeviceCount <= 0 Then
            Call ModifyDevicePicture(1, My.Resources.None, "None")
            Exit Sub
        ElseIf DeviceCount >= 1 And DeviceCount <= 4 Then
            frmAutoProfiler.gbDevices.Size = New Size(158, 60)
            frmAutoProfiler.Size = New Size(frmAutoProfiler.Size.Width, 220)

        Else
            frmAutoProfiler.gbDevices.Size = New Size(158, 99)
            frmAutoProfiler.Size = New Size(frmAutoProfiler.Size.Width, 262)
        End If

        If DeviceCount <= 0 Then Exit Sub

        'Keyboards


        If HasKeyboard = True Then
            i = i + 1
            Call ModifyDevicePicture(i, My.Resources.KeyboardV1, "Keyboard V1")
        End If


        If HasKeyboardv5 = True Then
            i = i + 1
            Call ModifyDevicePicture(i, My.Resources.KeyboardV5, "Keyboard V5")

        End If

        If HasKeyboardv7 = True Then
            i = i + 1
            Call ModifyDevicePicture(i, My.Resources.Keyboardv7, "Keyboard V7")
        End If

        If HasKeyboardSTRIKE7 = True Then
            i = i + 1
            Call ModifyDevicePicture(i, My.Resources.STRIKE7, "S.T.R.I.K.E.7")
        End If


        ' RATs
        If HasRAT = True Then

43:         RATReadMode = New Saitek.Devices.ReadMouseMode(RAT)
44:         AddHandler RATReadMode.MouseModeChanged, AddressOf RATDPIModeChanged
45:         RATReadMode.Start()

            If HasMMO7 = True Then
                i = i + 1

                frmAutoProfiler.tsbMMO7.Visible = True

                If HasMMO7White = True Then
                    Call ModifyDevicePicture(i, My.Resources.WhiteRAT, "M.M.O.7")
                Else
                    Call ModifyDevicePicture(i, My.Resources.MMO7, "M.M.O.7")
                End If

                frmAutoProfiler.pbDPIMode.Visible = True

                If i <> 1 Then
                    frmAutoProfiler.pbDPIMode.Location = New Point(frmAutoProfiler.pbDPIMode.Location.X + ((i - 1) * 38), frmAutoProfiler.pbDPIMode.Location.Y)
                End If

            ElseIf HasRATInfection = True Then
                i = i + 1



                Call ModifyDevicePicture(i, My.Resources.Infection, "Infection")
                frmAutoProfiler.pbDPIMode.Visible = True

                If i <> 1 Then
                    frmAutoProfiler.pbDPIMode.Location = New Point(frmAutoProfiler.pbDPIMode.Location.X + ((i - 1) * 38), frmAutoProfiler.pbDPIMode.Location.Y)
                End If


            ElseIf HasRATWhite = True Then
                i = i + 1
                Call ModifyDevicePicture(i, My.Resources.WhiteRAT, "R.A.T.")
                frmAutoProfiler.pbDPIMode.Visible = True

                If i <> 1 Then
                    frmAutoProfiler.pbDPIMode.Location = New Point(frmAutoProfiler.pbDPIMode.Location.X + ((i - 1) * 38), frmAutoProfiler.pbDPIMode.Location.Y)
                End If
            Else

                i = i + 1
                Call ModifyDevicePicture(i, My.Resources.RAT, "R.A.T.")
                frmAutoProfiler.pbDPIMode.Visible = True

                If i <> 1 Then
                    frmAutoProfiler.pbDPIMode.Location = New Point(frmAutoProfiler.pbDPIMode.Location.X + ((i - 1) * 38), frmAutoProfiler.pbDPIMode.Location.Y)
                End If
            End If

        Else
            frmAutoProfiler.pbDPIMode.Visible = False
        End If


        ' Flight

        If HasFly = True Then

            i = i + 1
            Call ModifyDevicePicture(i, My.Resources.Flight, "F.L.Y")
        End If


        ' Pro Flight
        If HasPF_YOKE = True Then

            i = i + 1
            Call ModifyDevicePicture(i, My.Resources.PF_Yoke, "Yoke")
        End If

        If HasPF_BIB = True Then

            i = i + 1
            Call ModifyDevicePicture(i, My.Resources.PF_BIB, "BIB")
        End If

        If HasPF_THROTTLE = True Then

            i = i + 1
            Call ModifyDevicePicture(i, My.Resources.PF_Throttle, "Throttle")
        End If

        If HasPF_RUDDERS = True Then

            i = i + 1
            Call ModifyDevicePicture(i, My.Resources.PF_Rudder, "Rudder")
        End If

        If HasPF_TPM = True Then

            i = i + 1
            Call ModifyDevicePicture(i, My.Resources.PF_TPM, "TPM")
        End If

        If HasPF_X52 = True Then

            i = i + 1
            Call ModifyDevicePicture(i, My.Resources.PF_X52, "X52")
        End If


        'Command Unit

        If HasCCU = True Then

            i = i + 1
            Call ModifyDevicePicture(i, My.Resources.CommandUnit, "Command Unit")
        End If



        'Gamepads

        If HasGamePad = True Then

            i = i + 1
            Call ModifyDevicePicture(i, My.Resources.Gamepad, "Gamepad")
        End If



    End Sub
    Public Sub ModifyDevicePicture(ByVal Index As Byte, ByVal Picture As Image, DeviceName As String)
        frmAutoProfiler.TT.InitialDelay = 1000

        Select Case Index

            Case 1
                frmAutoProfiler.pbDevice1.Image = Picture
                frmAutoProfiler.TT.SetToolTip(frmAutoProfiler.pbDevice1, DeviceName)

            Case 2
                frmAutoProfiler.pbDevice2.Image = Picture
                frmAutoProfiler.TT.SetToolTip(frmAutoProfiler.pbDevice2, DeviceName)

            Case 3
                frmAutoProfiler.pbDevice3.Image = Picture
                frmAutoProfiler.TT.SetToolTip(frmAutoProfiler.pbDevice3, DeviceName)

            Case 4
                frmAutoProfiler.pbDevice4.Image = Picture
                frmAutoProfiler.TT.SetToolTip(frmAutoProfiler.pbDevice4, DeviceName)

            Case 5
                frmAutoProfiler.pbDevice5.Image = Picture
                frmAutoProfiler.TT.SetToolTip(frmAutoProfiler.pbDevice5, DeviceName)

            Case 6
                frmAutoProfiler.pbDevice6.Image = Picture
                frmAutoProfiler.TT.SetToolTip(frmAutoProfiler.pbDevice6, DeviceName)

            Case 7
                frmAutoProfiler.pbDevice7.Image = Picture
                frmAutoProfiler.TT.SetToolTip(frmAutoProfiler.pbDevice7, DeviceName)

            Case 8
                frmAutoProfiler.pbDevice8.Image = Picture
                frmAutoProfiler.TT.SetToolTip(frmAutoProfiler.pbDevice8, DeviceName)

        End Select

    End Sub
    Public Sub ShowSystemTrayOptions(ByVal Show As Boolean)

        If Show = False Then
            frmAutoProfiler.tsmED.Enabled = False
            frmAutoProfiler.tsmOpen.Enabled = False
            frmAutoProfiler.tsmSettings.Enabled = False
            frmAutoProfiler.tsmEditProfiles.Enabled = False
        Else
            frmAutoProfiler.tsmED.Enabled = True
            frmAutoProfiler.tsmOpen.Enabled = True
            frmAutoProfiler.tsmSettings.Enabled = True
            frmAutoProfiler.tsmEditProfiles.Enabled = True

        End If

    End Sub
    Public Sub RefreshSystemTrayProfiles()
        On Error GoTo ErrorHandler


1:      For i = 0 To frmAutoProfiler.cmsProfiles.Items.Count - 1
2:          If frmAutoProfiler.cmsProfiles.Items.Item(i).Tag = ActiveProfile Then
3:              frmAutoProfiler.cmsProfiles.Items.Item(i).BackgroundImage = My.Resources.TaskProfileSelected
4:              frmAutoProfiler.cmsProfiles.Items.Item(i).BackgroundImageLayout = ImageLayout.Stretch
            Else
5:              frmAutoProfiler.cmsProfiles.Items.Item(i).BackgroundImage = My.Resources.TaskProfileNormal
6:              frmAutoProfiler.cmsProfiles.Items.Item(i).BackgroundImageLayout = ImageLayout.Stretch
            End If
        Next


7:      If frmAutoProfiler.ProfileListSubFolderCount > 0 Then
8:          For i = 1 To frmAutoProfiler.ProfileListSubFolderCount
9:              For x = 0 To frmAutoProfiler.ProfileListSubFolder(i).DropDownItems.Count - 1

10:                 If frmAutoProfiler.ProfileListSubFolder(i).DropDownItems.Item(x).Tag = ActiveProfile Then
11:                     frmAutoProfiler.ProfileListSubFolder(i).DropDownItems.Item(x).BackgroundImage = My.Resources.TaskProfileSelected
12:                     frmAutoProfiler.ProfileListSubFolder(i).DropDownItems.Item(x).BackgroundImageLayout = ImageLayout.Stretch
                    Else
13:                     frmAutoProfiler.ProfileListSubFolder(i).DropDownItems.Item(x).BackgroundImage = My.Resources.TaskProfileNormal
14:                     frmAutoProfiler.ProfileListSubFolder(i).DropDownItems.Item(x).BackgroundImageLayout = ImageLayout.Stretch

                    End If

                Next
            Next i
        End If

        Exit Sub

ErrorHandler:
        If frmError.Visible = True Then Exit Sub
        frmError.lblErr.Text = "RefreshSystemTrayProfiles has had an error at line " & Err.Erl & vbNewLine & vbNewLine & "Description: " & Err.Description & vbNewLine & vbNewLine & "Please report this to CyborgAutoProfiler@gmail.com"
        frmError.rtbErr.Text = "RefreshSystemTrayProfiles has had an error! Error Description: " & Err.Description & vbNewLine & vbNewLine & "Operating System: " & My.Computer.Info.OSFullName & vbNewLine & "Operating System Version: " & My.Computer.Info.OSVersion & vbNewLine & "Cyborg Version: " & CurrentVersion

        frmError.ShowDialog()
    End Sub

    Public Sub EnumerateHotKeys()
        Dim i As Byte, c() As Integer

        ProfileHotKeyCount = 0

        ReDim ProfileHotKey(0 To MaxProfiles)


        For i = 1 To MaxProfiles

            c = GetProfileSettings(Profiles(i).Settings)

            If c(3) > 0 Then
                ProfileHotKeyCount = ProfileHotKeyCount + 1

                ProfileHotKey(ProfileHotKeyCount).HotKeyProfile = i
                ProfileHotKey(ProfileHotKeyCount).HotKeyChr = c(3)
                ProfileHotKey(ProfileHotKeyCount).HotKeyChr2 = c(4)
            End If
        Next
    End Sub
    Public Sub MakeDefaultDb()
        Dim I As Integer

        For I = 0 To PROFILECOUNT
            PDB(I).ProfileName = ""
            PDB(I).ProfileDownload = ""
            PDB(I).ProfileDevices = ""
            PDB(I).ProfileDescription = ""
            PDB(I).ProfileProcess = ""
            PDB(I).ProfileCategory = 0
        Next I
    End Sub
    Public Sub SaveDB()
        Dim BinOut As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter
        Dim Bin As New System.IO.MemoryStream()



        BinOut.Serialize(Bin, PDB)


        System.IO.File.WriteAllBytes(DBFileLoc, Bin.GetBuffer())
        Bin.Close()
    End Sub
    Public Sub ReadDB()
        Dim BinOut As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter

        If System.IO.File.Exists(DBFileLoc) = True Then
            Dim FileStream As New System.IO.FileStream(DBFileLoc, System.IO.FileMode.Open)

            PDB = BinOut.Deserialize(FileStream)
            FileStream.Close()
        Else

            Call MsgBox("Could not find Profiles.db!", vbCritical)
        End If



    End Sub

    Public Function IsProfilerURunning() As Boolean
        If Process.GetProcessesByName("ProfilerU").Length = 0 Then
            IsProfilerURunning = False
        Else
            IsProfilerURunning = True
        End If
    End Function
    Public Function IsProccessRunning(ByVal ProcessName As String) As Boolean

        Dim ProcessArray() As String
        Dim Processes(0 To 255) As String
        Dim ProcessCommand(0 To 255) As String
        Dim ArrayCount As Byte
        Dim FWT As String
        Dim PWT As String
        Dim i As Byte



        If ProcessName = "" Then
            IsProccessRunning = False
            Exit Function
        End If

        ProcessArray = Split(ProcessName, "�")


        If ProcessArray.Count > 0 Then
            ArrayCount = ProcessArray.Count - 1
        Else
            ArrayCount = ProcessArray.Count
        End If

        For i = 0 To ArrayCount
            If InStr(ProcessArray(i), "/caption=") > 0 Then

                Processes(i) = Mid(ProcessArray(i), 1, InStr(ProcessArray(i), "/caption=") - 1)
                ProcessCommand(i) = Mid(ProcessArray(i), InStr(ProcessArray(i), "/caption=") + Len("/caption="))
            Else
                Processes(i) = ProcessArray(i)
                ProcessCommand(i) = ""
            End If

        Next


        IsProccessRunning = False



        'New detection mode. 0 Is the Process Detection Mode
        If DetectionType = 0 Then

            For i = 0 To ArrayCount
                If Process.GetProcessesByName(Processes(i)).Length = 0 Then
                    IsProccessRunning = False
                Else

                    ' Check for the '/caption=' command

                    If ProcessCommand(i) <> "" Then

                        Dim MyProcess() As Process = System.Diagnostics.Process.GetProcessesByName(Processes(i))



                        ' This is where we check the text of the active window and the text of the process
                        For Each MyPCheck As Process In MyProcess
                            PWT = MyPCheck.MainWindowTitle

                            If ProcessCommand(i) = PWT Then
                                IsProccessRunning = True
                                Exit Function
                            End If

                        Next

                        IsProccessRunning = False


                    Else
                        IsProccessRunning = True
                        Exit Function
                    End If

                End If
            Next

            ' Mode 1 is Active Window Detection Mode
        ElseIf DetectionType = 1 Then

            FWT = GetForgroundWText()



            'This is the new detection mode that looks for the current window
            For i = 0 To ArrayCount
                If Process.GetProcessesByName(Processes(i)).Length > 0 Then


                    Dim MyProcess() As Process = System.Diagnostics.Process.GetProcessesByName(Processes(i))

                    ' This is where we check the text of the active window and the text of the process
                    For Each MyPCheck As Process In MyProcess



                        ' Check for a command
                        If ProcessCommand(i) <> "" Then
                            If FWT = ProcessCommand(i) Then
                                IsProccessRunning = True
                                Exit Function
                            End If

                        Else
                            Dim PID As Integer
                            Dim P2 As Process



                            GetWindowThreadProcessId(GetAncestor(GetForegroundWindow.ToString, 2), PID)

                            Try
                                P2 = Process.GetProcessById(PID)

                            Catch ex As Exception

                                If ex.Message <> "Process with an Id of " & PID & " is not running." Then
                                    If frmError.Visible = True Then Exit Function
                                    frmError.lblErr.Text = "Error detecting process! Error Description: " & Err.Description & " Please report this to CyborgAutoProfiler@gmail.com and include the devices you have."
                                    frmError.rtbErr.Text = "Error detecting process! Error Description: " & Err.Description & vbNewLine & vbNewLine & "Operating System: " & My.Computer.Info.OSFullName & vbNewLine & "Operating System Version: " & My.Computer.Info.OSVersion & vbNewLine & "Cyborg Version: " & CurrentVersion
                                    frmError.ShowDialog()
                                End If

                                Continue For
                            End Try



                            PWT = MyPCheck.MainWindowTitle



                            'If FWT = PWT Then
                            '    IsProccessRunning = True
                            '    Exit Function
                            'End If


                            'Debugging
                            'frmDebug.txtDebug.Text = frmDebug.txtDebug.Text & "PWT:" & PWT & ", MWT: " & P2.MainWindowTitle & vbNewLine


                            If P2.MainWindowTitle = PWT And PWT <> "" And P2.MainWindowTitle <> "" Then
                                IsProccessRunning = True
                                Exit Function
                            Else

                                If MyPCheck.ProcessName = P2.ProcessName Then
                                    IsProccessRunning = True
                                    Exit Function
                                End If

                                IsProccessRunning = False
                            End If

                        End If

                    Next

                    IsProccessRunning = False
                Else

                    IsProccessRunning = False
                End If

            Next


            ' Mode 2 is Cursor Detection Mode.

        ElseIf DetectionType = 2 Then
            Dim P As Process
            Dim PID As Integer

            For i = 0 To ArrayCount
                If Process.GetProcessesByName(Processes(i)).Length > 0 Then


                    Dim MyProcess() As Process = System.Diagnostics.Process.GetProcessesByName(Processes(i))


                    ' Get the Process that the cursor is over.
                    GetWindowThreadProcessId(GetAncestor(WindowFromPoint(Cursor.Position.X, Cursor.Position.Y), 2), PID)

                    Try
                        P = Process.GetProcessById(PID)

                    Catch ex As Exception

                        If ex.Message <> "Process with an Id of " & PID & " is not running." Then
                            If frmError.Visible = True Then Exit Function
                            frmError.lblErr.Text = "Error detecting process! Error Description: " & Err.Description & " Please report this to CyborgAutoProfiler@gmail.com and include the devices you have."
                            frmError.rtbErr.Text = "Error detecting process! Error Description: " & Err.Description & vbNewLine & vbNewLine & "Operating System: " & My.Computer.Info.OSFullName & vbNewLine & "Operating System Version: " & My.Computer.Info.OSVersion & vbNewLine & "Cyborg Version: " & CurrentVersion
                            frmError.ShowDialog()
                        End If

                        Continue For
                    End Try



                    ' This is where we check the text of the active window and the text of the process
                    For Each MyPCheck As Process In MyProcess

                        If MyPCheck.ProcessName = P.ProcessName Then
                            'If MyPCheck.MainWindowHandle = GetAncestor(WindowFromPoint(Cursor.Position.X, Cursor.Position.Y), 2) Then

                            If ProcessCommand(i) <> "" Then
                                PWT = MyPCheck.MainWindowTitle

                                If ProcessCommand(i) = PWT Then
                                    Return True
                                End If

                            Else
                                Return True
                            End If

                        End If
                    Next

                    IsProccessRunning = False
                Else

                    IsProccessRunning = False
                End If

            Next

        End If


    End Function
    Public Function CheckLockedProfileRunning() As Boolean
        Dim ProcessArray() As String, ProcessName As String
        Dim Processes(0 To 255) As String
        Dim ProcessCommand(0 To 255) As String
        Dim ArrayCount As Byte
        Dim PWT As String
        Dim i As Byte

        ProcessName = Profiles(LockedProfile).ProcessName


        CheckLockedProfileRunning = False

        If ProcessName = "" Then
            CheckLockedProfileRunning = False
            Exit Function
        End If

        ProcessArray = Split(ProcessName, "�")


        If ProcessArray.Count > 0 Then
            ArrayCount = ProcessArray.Count - 1
        Else
            ArrayCount = ProcessArray.Count
        End If

        For i = 0 To ArrayCount
            If InStr(ProcessArray(i), "/caption=") > 0 Then

                Processes(i) = Mid(ProcessArray(i), 1, InStr(ProcessArray(i), "/caption=") - 1)
                ProcessCommand(i) = Mid(ProcessArray(i), InStr(ProcessArray(i), "/caption=") + Len("/caption="))
            Else
                Processes(i) = ProcessArray(i)
                ProcessCommand(i) = ""
            End If

        Next

        For i = 0 To ArrayCount
            If Process.GetProcessesByName(Processes(i)).Length = 0 Then
                CheckLockedProfileRunning = False
            Else

                ' Check for the '/caption=' command

                If ProcessCommand(i) <> "" Then

                    Dim MyProcess() As Process = System.Diagnostics.Process.GetProcessesByName(Processes(i))



                    ' This is where we check the text of the active window and the text of the process
                    For Each MyPCheck As Process In MyProcess
                        PWT = MyPCheck.MainWindowTitle

                        If ProcessCommand(i) = PWT Then
                            CheckLockedProfileRunning = True
                            Exit Function
                        End If

                    Next

                    CheckLockedProfileRunning = False


                Else
                    CheckLockedProfileRunning = True
                    Exit Function
                End If

            End If
        Next
    End Function
    Public Function SettingsExist() As Boolean

        If System.IO.File.Exists(Application.StartupPath & "\Settings.xml") = False Then
            SettingsExist = False
        Else
            SettingsExist = True
        End If

    End Function

    Public Function IsAdmin() As Boolean

        If My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator) = True Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function GetForgroundWText() As String
        Dim textlen As Integer
        Dim wintext As String
        Dim slength As Integer
        Dim ActiveWin As Integer = CInt(GetForegroundWindow.ToString)

        textlen = GetWindowTextLength(ActiveWin) + 1

        If textlen > 2147483647 Or textlen < -214783648 Then
            MsgBox("Error: Overflow at text length.", vbExclamation)
            Call SetCheckerStatus(False)
            Return ""
            Exit Function
        End If

        wintext = Space(textlen)
        slength = GetWindowText(GetForegroundWindow, wintext, Len(wintext))
        wintext = Microsoft.VisualBasic.Left(wintext, Len(wintext) - 1)

        Return wintext
    End Function
    Public Function GetProcessWText(ByVal hwnd As Integer) As String
        Dim textlen As Integer
        Dim wintext As String
        Dim slength As Integer
        Dim ActiveWin As Integer = CInt(hwnd.ToString)


        textlen = GetWindowTextLength(ActiveWin) + 1

        If textlen > 2147483647 Or textlen < -214783648 Then
            MsgBox("Error: Overflow at text length.", vbExclamation)
            Call SetCheckerStatus(False)
            Return ""
            Exit Function
        End If

        wintext = Space(textlen)
        slength = GetWindowText(hwnd, wintext, Len(wintext))
        Return wintext
    End Function
    Public Function GetWinText(ByVal hWnd As IntPtr) As String
        Dim textlen As Integer
        Dim wintext As String
        Dim slength As Integer
        Dim ActiveWin As Integer = CInt(hWnd.ToString)

        textlen = GetWindowTextLength(ActiveWin) + 1

        If textlen > 2147483647 Or textlen < -214783648 Then
            MsgBox("Error: Overflow at text length.", vbExclamation)
            Call SetCheckerStatus(False)
            Return ""
            Exit Function
        End If

        wintext = Space(textlen)
        slength = GetWindowText(hWnd, wintext, Len(wintext))
        wintext = Microsoft.VisualBasic.Left(wintext, Len(wintext) - 1)

        Return wintext
    End Function
    Public Function GetProfileSettings(ByVal Input As String) As Integer()
        Dim s() As String
        Dim x As Integer, Count As Byte
        Dim R(0 To ProfileSettingsCount) As Integer

        For x = 0 To ProfileSettingsCount
            R(x) = 0
        Next

        If Input = "" Then
            Return R
        End If

        s = Split(Input, "/")

        Count = s.Count - 1

        If Count <= 0 Then
            Return R
        End If


        For i = 0 To ProfileSettingsCount
            If i > Count Then
                R(i) = 0
            Else
                R(i) = s(i)
            End If

        Next



        Return R

    End Function
    Public Function GetProfileSetting(ByVal Profile As Byte, Index As Byte, Temp As Boolean) As String
        Dim C() As Integer
        If Temp = False Then

            C = GetProfileSettings(Profiles(Profile).Settings)
            Return C(Index)
        Else
            C = GetProfileSettings(TempProfiles(Profile).Settings)
            Return C(Index)
        End If

    End Function
    Public Function GetRATCSettings(ByVal Input As String) As Integer()
        Dim s() As String
        Dim x As Integer, Count As Integer
        Dim R(0 To RATSettingsCount) As Integer

        For x = 0 To RATSettingsCount
            R(x) = 0
        Next

        If Input = "" Then
            Return R
        End If

        s = Split(Input, "/")

        Count = s.Count - 1

        If Count <= 0 Then
            Return R
        End If


        For i = 0 To RATSettingsCount
            If i > Count Then
                R(i) = 0
            Else
                R(i) = s(i)
            End If

        Next



        Return R

    End Function
    Public Function GetRATCSetting(ByVal Profile As Byte, Index As Byte, Temp As Boolean) As String
        Dim C() As Integer
        If Temp = False Then

            C = GetRATCSettings(Profiles(Profile).RATCS)
            Return C(Index)
        Else
            C = GetRATCSettings(TempProfiles(Profile).RATCS)
            Return C(Index)
        End If

    End Function
    Public Function GetOldRATCS(ByVal Input As String) As Integer()
        Dim s() As String
        Dim x As Integer, Count As Byte
        Dim R(0 To 12) As Integer

        For x = 0 To 12
            R(x) = 0
        Next

        If Input = "" Then
            Return R
        End If

        s = Split(Input, "/")

        Count = s.Count - 1

        If Count <= 0 Then
            Return R
        End If


        For i = 0 To 12
            If i > Count Then
                R(i) = 0
            Else
                R(i) = s(i)
            End If

        Next



        Return R

    End Function
    Public Function GetMMO7LEDFlowSetting(ByVal Input As String) As Byte()
        Dim s() As String
        Dim x As Byte, Count As Byte
        Dim R(0 To MMO7LEDFlowSettingsCount) As Byte

        For x = 0 To MMO7LEDFlowSettingsCount
            R(x) = 0
        Next

        If R(0) = 0 Then R(0) = 2
        If R(1) = 0 Then R(1) = 1


        If Input = "" Then
            Return R
        End If

        s = Split(Input, "/")

        Count = s.Count - 1

        If Count <= 0 Then
            Return R
        End If


        For i = 0 To MMO7LEDFlowSettingsCount
            If i > Count Then
                R(i) = 0
            Else
                R(i) = s(i)
            End If

        Next



        Return R

    End Function

    Public Function UnallowedChr(ByVal S As String) As Boolean
        Dim i As Integer

        i = i + InStr(S, "/")
        i = i + InStr(S, "\")
        i = i + InStr(S, ":")
        i = i + InStr(S, "*")
        i = i + InStr(S, "?")
        i = i + InStr(S, Chr(34))
        i = i + InStr(S, "<")
        i = i + InStr(S, ">")
        i = i + InStr(S, "|")

        If i > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function UnallowedChrProcess(ByVal S As String) As Boolean
        Dim i As Integer

        i = i + InStr(S, ":")


        If i > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function GetProfileName(ByVal ProfilePath As String) As String
        Dim s() As String

        s = Split(ProfilePath, "\")


        If Len(s.Last) <= 4 Then
            Return "None"
            Exit Function
        End If



        Return Mid(s.Last, 1, Len(s.Last) - 4)

    End Function
    Public Function FindProfileFromPath(ByVal ProfilePath As String) As Byte
        Dim i As Byte

        For i = 1 To MaxProfiles

            If Profiles(i).ProfilePath = ProfilePath Then
                Return i
            End If

        Next


        Return 0
    End Function
    Public Function GetTargetPathFromShortcut(ByVal FileName As String)
        Dim Obj As Object
        Dim Shortcut As Object

        Obj = CreateObject("WScript.Shell")

        Shortcut = Obj.CreateShortcut(FileName)
        GetTargetPathFromShortcut = Shortcut.TargetPath

    End Function
    Public Function IsVersionLower(ByVal OldVersion As String, ByVal NewVersion As String) As Boolean
        Dim s() As String
        Dim s2() As String

        If OldVersion = "" Then OldVersion = "0.0.0"
        If NewVersion = "" Then NewVersion = "0.0.0"

        If OldVersion = NewVersion Then
            Return False
        End If



        s = Split(OldVersion, ".")
        s2 = Split(NewVersion, ".")

        If s.Count <> 3 Then Return False
        If s2.Count <> 3 Then Return False

        'Check Major
        If s(0) < s2(0) Then
            Return True
        Else

            ' Check Minor
            If Not s(0) > s2(0) And s(1) < s2(1) Then
                Return True
            Else

                'Check Revision
                If Not s(0) > s2(0) And Not s(1) > s2(1) And s(2) < s2(2) Then
                    Return True
                Else


                    Return False
                End If

            End If
        End If



    End Function
    Public Function IsAnyKeyPressed() As Boolean

        'QWERTY
        If GetAsyncKeyState(Keys.Q) < 0 Then Return True
        If GetAsyncKeyState(Keys.W) < 0 Then Return True
        If GetAsyncKeyState(Keys.E) < 0 Then Return True
        If GetAsyncKeyState(Keys.R) < 0 Then Return True
        If GetAsyncKeyState(Keys.T) < 0 Then Return True
        If GetAsyncKeyState(Keys.Y) < 0 Then Return True
        If GetAsyncKeyState(Keys.U) < 0 Then Return True
        If GetAsyncKeyState(Keys.I) < 0 Then Return True
        If GetAsyncKeyState(Keys.O) < 0 Then Return True
        If GetAsyncKeyState(Keys.P) < 0 Then Return True
        If GetAsyncKeyState(Keys.A) < 0 Then Return True
        If GetAsyncKeyState(Keys.S) < 0 Then Return True
        If GetAsyncKeyState(Keys.D) < 0 Then Return True
        If GetAsyncKeyState(Keys.F) < 0 Then Return True
        If GetAsyncKeyState(Keys.G) < 0 Then Return True
        If GetAsyncKeyState(Keys.H) < 0 Then Return True
        If GetAsyncKeyState(Keys.J) < 0 Then Return True
        If GetAsyncKeyState(Keys.K) < 0 Then Return True
        If GetAsyncKeyState(Keys.L) < 0 Then Return True
        If GetAsyncKeyState(Keys.Z) < 0 Then Return True
        If GetAsyncKeyState(Keys.X) < 0 Then Return True
        If GetAsyncKeyState(Keys.C) < 0 Then Return True
        If GetAsyncKeyState(Keys.V) < 0 Then Return True
        If GetAsyncKeyState(Keys.B) < 0 Then Return True
        If GetAsyncKeyState(Keys.N) < 0 Then Return True
        If GetAsyncKeyState(Keys.M) < 0 Then Return True
        If GetAsyncKeyState(Keys.Space) < 0 Then Return True


        ' F1-12
        If GetAsyncKeyState(Keys.F1) < 0 Then Return True
        If GetAsyncKeyState(Keys.F2) < 0 Then Return True
        If GetAsyncKeyState(Keys.F3) < 0 Then Return True
        If GetAsyncKeyState(Keys.F4) < 0 Then Return True
        If GetAsyncKeyState(Keys.F5) < 0 Then Return True
        If GetAsyncKeyState(Keys.F6) < 0 Then Return True
        If GetAsyncKeyState(Keys.F7) < 0 Then Return True
        If GetAsyncKeyState(Keys.F8) < 0 Then Return True
        If GetAsyncKeyState(Keys.F9) < 0 Then Return True
        If GetAsyncKeyState(Keys.F10) < 0 Then Return True
        If GetAsyncKeyState(Keys.F11) < 0 Then Return True
        If GetAsyncKeyState(Keys.F12) < 0 Then Return True


        ' Numbers
        If GetAsyncKeyState(Keys.D0) < 0 Then Return True
        If GetAsyncKeyState(Keys.D1) < 0 Then Return True
        If GetAsyncKeyState(Keys.D2) < 0 Then Return True
        If GetAsyncKeyState(Keys.D3) < 0 Then Return True
        If GetAsyncKeyState(Keys.D4) < 0 Then Return True
        If GetAsyncKeyState(Keys.D5) < 0 Then Return True
        If GetAsyncKeyState(Keys.D6) < 0 Then Return True
        If GetAsyncKeyState(Keys.D7) < 0 Then Return True
        If GetAsyncKeyState(Keys.D8) < 0 Then Return True
        If GetAsyncKeyState(Keys.D9) < 0 Then Return True

        'Number Num Pad
        If GetAsyncKeyState(Keys.NumPad0) < 0 Then Return True
        If GetAsyncKeyState(Keys.NumPad1) < 0 Then Return True
        If GetAsyncKeyState(Keys.NumPad2) < 0 Then Return True
        If GetAsyncKeyState(Keys.NumPad3) < 0 Then Return True
        If GetAsyncKeyState(Keys.NumPad4) < 0 Then Return True
        If GetAsyncKeyState(Keys.NumPad5) < 0 Then Return True
        If GetAsyncKeyState(Keys.NumPad6) < 0 Then Return True
        If GetAsyncKeyState(Keys.NumPad7) < 0 Then Return True
        If GetAsyncKeyState(Keys.NumPad8) < 0 Then Return True
        If GetAsyncKeyState(Keys.NumPad9) < 0 Then Return True

        ' Number Related
        If GetAsyncKeyState(Keys.Separator) < 0 Then Return True
        If GetAsyncKeyState(Keys.OemMinus) < 0 Then Return True
        If GetAsyncKeyState(Keys.Oemplus) < 0 Then Return True
        If GetAsyncKeyState(Keys.OemQuestion) < 0 Then Return True
        If GetAsyncKeyState(Keys.OemBackslash) < 0 Then Return True
        If GetAsyncKeyState(Keys.Divide) < 0 Then Return True
        If GetAsyncKeyState(Keys.Decimal) < 0 Then Return True
        If GetAsyncKeyState(Keys.Multiply) < 0 Then Return True



        If GetAsyncKeyState(Keys.OemPeriod) < 0 Then Return True
        If GetAsyncKeyState(Keys.Oemcomma) < 0 Then Return True
        If GetAsyncKeyState(Keys.OemQuotes) < 0 Then Return True
        If GetAsyncKeyState(Keys.OemSemicolon) < 0 Then Return True
        If GetAsyncKeyState(Keys.OemCloseBrackets) < 0 Then Return True
        If GetAsyncKeyState(Keys.OemOpenBrackets) < 0 Then Return True

        '\
        If GetAsyncKeyState(220) < 0 Then Return True

        ' Numpad Plus
        If GetAsyncKeyState(107) < 0 Then Return True

        'Numpad Minus
        If GetAsyncKeyState(109) < 0 Then Return True

        If GetAsyncKeyState(12) < 0 Then Return True

        'Pause/Break
        If GetAsyncKeyState(19) < 0 Then Return True

        ' Other area
        If GetAsyncKeyState(Keys.Insert) < 0 Then Return True
        If GetAsyncKeyState(Keys.Home) < 0 Then Return True
        If GetAsyncKeyState(Keys.PageUp) < 0 Then Return True
        If GetAsyncKeyState(Keys.Delete) < 0 Then Return True
        If GetAsyncKeyState(Keys.End) < 0 Then Return True
        If GetAsyncKeyState(Keys.PageDown) < 0 Then Return True

        ' Arrows
        If GetAsyncKeyState(Keys.Up) < 0 Then Return True
        If GetAsyncKeyState(Keys.Left) < 0 Then Return True
        If GetAsyncKeyState(Keys.Down) < 0 Then Return True
        If GetAsyncKeyState(Keys.Right) < 0 Then Return True

        ' Misc
        If GetAsyncKeyState(Keys.Enter) < 0 Then Return True
        If GetAsyncKeyState(Keys.Escape) < 0 Then Return True
        If GetAsyncKeyState(Keys.Oemtilde) < 0 Then Return True
        If GetAsyncKeyState(Keys.Tab) < 0 Then Return True
        If GetAsyncKeyState(Keys.CapsLock) < 0 Then Return True
        If GetAsyncKeyState(Keys.ShiftKey) < 0 Then Return True
        If GetAsyncKeyState(Keys.ControlKey) < 0 Then Return True
        If GetAsyncKeyState(Keys.LWin) < 0 Then Return True
        If GetAsyncKeyState(Keys.RWin) < 0 Then Return True
        If GetAsyncKeyState(Keys.Menu) < 0 Then Return True
        If GetAsyncKeyState(Keys.Apps) < 0 Then Return True
        If GetAsyncKeyState(Keys.NumLock) < 0 Then Return True


        If GetAsyncKeyState(Keys.Back) < 0 Then Return True
        If GetAsyncKeyState(Keys.PrintScreen) < 0 Then Return True
        If GetAsyncKeyState(Keys.Scroll) < 0 Then Return True
        If GetAsyncKeyState(Keys.Pause) < 0 Then Return True

        ' Volume and Music
        If GetAsyncKeyState(Keys.VolumeDown) > 0 Then Return True
        If GetAsyncKeyState(Keys.VolumeUp) > 0 Then Return True
        If GetAsyncKeyState(Keys.VolumeMute) > 0 Then Return True
        If GetAsyncKeyState(Keys.MediaPlayPause) > 0 Then Return True
        If GetAsyncKeyState(Keys.Play) > 0 Then Return True
        If GetAsyncKeyState(Keys.MediaNextTrack) > 0 Then Return True
        If GetAsyncKeyState(Keys.MediaPreviousTrack) > 0 Then Return True
        If GetAsyncKeyState(Keys.MediaStop) > 0 Then Return True
        If GetAsyncKeyState(Keys.SelectMedia) > 0 Then Return True

        ' Mouse
        If GetAsyncKeyState(4) > 0 Then Return True
        If GetAsyncKeyState(1) > 0 Then Return True
        If GetAsyncKeyState(2) > 0 Then Return True



        Return False
    End Function
    Public Function GetMD5(ByVal filePath As String)

        If System.IO.File.Exists(filePath) = False Then
            Call MsgBox("Could not find '" & filePath & "'. MD5 Check has failed.", MsgBoxStyle.Critical)
            Return "Failed"
        End If

        Dim md5 As System.Security.Cryptography.MD5CryptoServiceProvider = New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim f As System.IO.FileStream = New System.IO.FileStream(filePath, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read, 8192)

        f = New System.IO.FileStream(filePath, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read, 8192)
        md5.ComputeHash(f)
        f.Close()
        f.Dispose()

        Dim hash As Byte() = md5.Hash
        Dim buff As System.Text.StringBuilder = New System.Text.StringBuilder
        Dim hashByte As Byte

        For Each hashByte In hash
            buff.Append(String.Format("{0:X2}", hashByte))
        Next

        Dim md5string As String
        md5string = buff.ToString()


        md5.Dispose()

        Return md5string

    End Function
    Public Function FileInUse(ByVal FilePath As String) As Boolean
        If System.IO.File.Exists(FilePath) Then
            Try
                Dim F As Short = FreeFile()
                FileOpen(F, FilePath, OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.LockReadWrite)
                FileClose(F)
            Catch
                Return True
            End Try
        End If
        Return False
    End Function
    Public Function GetProfileLongestMacro(ProfileLocation As String) As Integer
        On Error GoTo ErrorHandler
        Dim ProfileText As String
        Dim i As Integer, MacroTime As Integer = 0, LongestMacro As Integer = 0


        If System.IO.File.Exists(ProfileLocation) = False Then Return 0

        Dim sr As System.IO.StreamReader = System.IO.File.OpenText(ProfileLocation)


        ProfileText = sr.ReadToEnd
        sr.Close()


        If ProfileText.IndexOf("time=") >= 0 Then

            Do While ProfileText.IndexOf("time=", i) <> -1


                MacroTime = Convert.ToInt16(Mid(ProfileText, ProfileText.IndexOf("time=", i) + 6, 10), 16)
                'frmDebug.txtDebug.Text += MacroTime & vbNewLine

                If MacroTime > LongestMacro Then LongestMacro = MacroTime

                i = ProfileText.IndexOf("time=", i) + 15
            Loop

        End If



        Return LongestMacro

        Exit Function

ErrorHandler:
        If frmError.Visible = True Then Exit Function
        frmError.lblErr.Text = "Detecting Macro Time has had an error at line " & Err.Erl & vbNewLine & vbNewLine & "Description: " & Err.Description & vbNewLine & vbNewLine & "Please report this to CyborgAutoProfiler@gmail.com"
        frmError.rtbErr.Text = "Detecting Macro Time an error! Error Description: " & Err.Description & vbNewLine & vbNewLine & "Operating System: " & My.Computer.Info.OSFullName & vbNewLine & "Operating System Version: " & My.Computer.Info.OSVersion & vbNewLine & "Cyborg Version: " & CurrentVersion
        frmError.ShowDialog()
    End Function
End Module
