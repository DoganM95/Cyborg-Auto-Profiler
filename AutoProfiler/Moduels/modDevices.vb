Module modDevices

    '// This module is for anything device related


    ' Saitek Devices
    Public SaiDeviceList As Saitek.Devices.DeviceList
    Public Devices() As ControllerInfo
    Public DeviceLinkName(0 To 255) As String
    Public DeviceLinkNameType(0 To 255) As Byte
    Public DeviceCount As Byte = 0
    Public IsFindingDevices As Boolean


    'RAT Device
    Public RAT As Saitek.Devices.DpiDevice
    Public RATReadMode As Saitek.Devices.ReadMouseMode

    ' RAT/MMO7 Data
    Public RATLINKNAME As String
    Public RATDEFAULTDPI As Integer
    Public RATCURRENTDPI As Integer
    Public RATCURRENTCXP As Byte
    Public RATCURRENTCYP As Byte
    Public RATProfileLastDPI(0 To 255) As Integer
    Public MMO7DEFAULTLED() As Byte
    Public MMO7CURRENTLED() As Byte
    Public MMO7HASCHANGEDLED As Boolean
    Public MMO7FLOWDEFAULT As Boolean
    Public RATDefualtDPI(0 To 4) As Saitek.Devices.DpiPair
    Public RATMaxDPI As Integer
    Public RATHASCHANGEDDPI As Boolean

    'MMO7 LED Flow Settings
    Public MMO7LEDFlowSettings As String
    Public MMO7LEDFlowCount As Byte = 2
    Public MMO7LEDFlowSpeed As Byte
    Public MMO7LEDFlowColorDelay As Decimal
    Public MMO7LedFlowRandom As Byte = 0
    Public MMO7LedFlowPulse As Byte = 0
    Public FLOW_RLED As Byte, FLOW_GLED As Byte, FLOW_BLED As Byte
    Public CurrentColor As Byte
    Public NextColor As Byte

    'Controller Types
    Public Const CONTROLLER_TYPE_RAT As Byte = 1
    Public Const CONTROLLER_TYPE_MMO7 As Byte = 2
    Public Const CONTROLLER_TYPE_KEYBOARD As Byte = 3
    Public Const CONTROLLER_TYPE_GAMEPAD As Byte = 4
    Public Const CONTROLLER_TYPE_CCU As Byte = 5
    Public Const CONTROLLER_TYPE_FLIGHT As Byte = 6

    'Controller Typse
    Public HasRAT As Boolean
    Public HasRAT3 As Boolean
    Public HasMMO7 As Boolean
    Public HasMMO7White As Boolean
    Public HasRATWhite As Boolean
    Public HasRATInfection As Boolean
    Public HasKeyboard As Boolean
    Public HasKeyboardv5 As Boolean
    Public HasKeyboardv7 As Boolean
    Public HasKeyboardSTRIKE7 As Boolean
    Public HasGamePad As Boolean
    Public HasCCU As Boolean
    Public HasFly As Boolean

    'Pro Flight Controllers
    Public HasPF_BIB As Boolean
    Public HasPF_RUDDERS As Boolean
    Public HasPF_THROTTLE As Boolean
    Public HasPF_TPM As Boolean
    Public HasPF_X52 As Boolean
    Public HasPF_YOKE As Boolean

    Public Structure ControllerInfo

        Dim LinkName As String
        Dim DeviceName As String
        Dim DeviceAlias As String
        Dim DeviceType As Byte

    End Structure


    Public Sub ClearDevices()
        Dim i As Byte

        HasRAT = False
        HasMMO7 = False
        HasMMO7White = False
        HasCCU = False
        HasGamePad = False
        HasKeyboard = False
        HasKeyboardSTRIKE7 = False
        HasKeyboardv5 = False
        HasKeyboardv7 = False
        HasRATInfection = False
        HasRATWhite = False
        HasFly = False

        HasPF_BIB = False
        HasPF_RUDDERS = False
        HasPF_THROTTLE = False
        HasPF_TPM = False
        HasPF_X52 = False
        HasPF_YOKE = False

        For i = 0 To DeviceCount
            DeviceLinkName(i) = ""
            DeviceLinkNameType(i) = 0
        Next


        DeviceCount = 0

    End Sub
    Public Sub OnDeviceAdded(sender As Object, e As Saitek.Devices.DeviceChangeEventArgs)
        If e.Added = False Then Exit Sub

        SaiDeviceList.Dispose()
        Call FindDevices()

    End Sub
    Public Sub OnDeviceRemoved(sender As Object, e As Saitek.Devices.DeviceChangeEventArgs)

        SaiDeviceList.Dispose()
        Call FindDevices()

    End Sub

    Public Sub FindDevices()
        On Error GoTo ErrHandler

26:     Dim i As Byte
27:     Dim Input(0 To 4) As Byte
28:     Dim RCArry(0 To 5) As Byte
        Dim TempRAT As Saitek.Devices.DpiDevice

        If IsFindingDevices = True Then Exit Sub

        IsFindingDevices = True

        ' Clear what devices the user has.
        DeviceCount = 0
        HasRAT = False
        HasRATInfection = False
        HasRATWhite = False
        HasMMO7 = False
        HasMMO7White = False
        HasCCU = False
        HasFly = False
        HasGamePad = False
        HasKeyboard = False
        HasKeyboardSTRIKE7 = False
        HasKeyboardv5 = False
        HasKeyboardv7 = False
        HasPF_BIB = False
        HasPF_RUDDERS = False
        HasPF_THROTTLE = False
        HasPF_TPM = False
        HasPF_X52 = False
        HasPF_YOKE = False


        'If SaiDeviceList IsNot Nothing Then SaiDeviceList.Dispose()
        'RAT = Nothing
        'RATReadMode = Nothing

1:      SaiDeviceList = New Saitek.Devices.DeviceList(Saitek.Devices.TorontoDevice.InterfaceGuid)

2:      SaiDeviceList.EnumerateExistingDevices()

49:     AddHandler SaiDeviceList.OnDeviceAdded, AddressOf OnDeviceAdded
50:     AddHandler SaiDeviceList.OnDeviceRemoved, AddressOf OnDeviceRemoved


        SaiDeviceList.StartListen()



        ' Clear the device information
        ReDim Devices(0 To 15)
        DeviceCount = 0

        'RAT = Nothing
        RATLINKNAME = ""

        For i = 0 To 15
            Devices(i).LinkName = ""
            Devices(i).DeviceType = 0
            Devices(i).DeviceAlias = ""
        Next

3:      If SaiDeviceList.Devices.Count > 0 Then

36:         ReDim Devices(0 To SaiDeviceList.Devices.Count)

4:          For i = 0 To SaiDeviceList.Devices.Count - 1

5:              If SaiDeviceList.Devices.Item(i).LinkName <> "" Then
6:                  DeviceCount = DeviceCount + 1
7:                  Devices(DeviceCount).LinkName = SaiDeviceList.Devices.Item(i).LinkName
35:                 Devices(DeviceCount).DeviceAlias = Saitek.Devices.TorontoDevice.GetAlias(SaiDeviceList.Devices.Item(i).LinkName).ToString


8:                  ActiveProfile = Mid(Saitek.Devices.TorontoDevice.GetActiveProfile(Devices(DeviceCount).LinkName.ToString), 1, InStr(Saitek.Devices.TorontoDevice.GetActiveProfile(Devices(DeviceCount).LinkName), ".pr0") + 3)

                    ' Lets set the device name
33:                 Call SetDeviceType(DeviceCount, Saitek.Devices.TorontoDevice.GetAlias(SaiDeviceList.Devices.Item(i).LinkName).ToString)


                    '9:                  TempRAT = New Saitek.Devices.DpiDevice(Devices(DeviceCount).LinkName)

                    '10:                 If IsNothing(TempRAT) Then Continue For


11:                 If IsRat(Devices(DeviceCount).DeviceAlias) Then

                        'We've found the RAT device!
66:                     RAT = New Saitek.Devices.DpiDevice(Devices(DeviceCount).LinkName)


12:                     RATLINKNAME = Devices(DeviceCount).LinkName
13:                     ' RATDEFAULTDPI = GetRATDPIMode()
34:                     RATCURRENTDPI = RATDEFAULTDPI

                        ' Check if it is the RAT3
43:                     If HasRAT3 = False Then
14:                         RATCURRENTCXP = RAT.PrecisionX
15:                         RATCURRENTCYP = RAT.PrecisionY

41:                         Call GetRATDefualtDPI()
42:                         Call GetRATMaxDPI()
                        End If


16:                     HasRAT = True

                        '17:                     frmSettings.chkRDC.Enabled = True




                        'Check the MMO7 LEDS
37:                     If HasMMO7 = True Then
38:                         MMO7DEFAULTLED = GetMMO7LED()
39:                         MMO7CURRENTLED = MMO7DEFAULTLED
40:                     End If


                        'DeviceLinkNameType(i) = CONTROLLER_TYPE_RAT
                    End If




                End If
            Next i


            '   frmAutoProfiler.tmrCheckDevices.Interval = 60000

        Else
            '  frmAutoProfiler.tmrCheckDevices.Interval = 5000
            ' Call MsgBox("Couldn't find any Cyborg/Saitek Devices!", vbCritical)
        End If

        '46:     If RestartAPCheck = True Then
        '47:         RestartAPCheck = False
        '48:         Call SetCheckerStatus(True)
        '        End If


        RefreshDevices = True
        IsFindingDevices = False


        Exit Sub


ErrHandler:
        ' Call MsgBox("Error finding Devices! Error occurred at line: " & Err.Erl & ". Error Description: " & Err.Description & " Please report this to CyborgAutoProfiler@gmail.com and include the devices you have.", vbCritical)
        If frmError.Visible = True Then Exit Sub
        frmError.lblErr.Text = "Error finding Devices! Error occurred at line: " & Err.Erl & ". Error Description: " & Err.Description & " Please report this to CyborgAutoProfiler@gmail.com and include the devices you have."
        frmError.rtbErr.Text = "Error finding Devices! Error occurred at line: " & Err.Erl & vbNewLine & "Error Description: " & Err.Description & vbNewLine & vbNewLine & "Operating System: " & My.Computer.Info.OSFullName & vbNewLine & "Operating System Version: " & My.Computer.Info.OSVersion & vbNewLine & "Cyborg Version: " & CurrentVersion
        frmError.ShowDialog()

    End Sub
    Public Function IsRat(Alasis As String) As Boolean

        Select Case LCase(Alasis)

            Case RAT3, RAT3_3500, RAT3_3500_MadCatz, RAT5, RAT5_5600, RAT5_5600_MadCatz, RAT7, RAT7_6400, RAT7_6400_MadCatz, RAT9, RAT9_6400, RAT9_6400_MadCatz, StealthMouse, MOUS9, RAT7Infection, RAT7Albino, RAT7Contagion, RATm, MMO7, MMO7_MadCatz, MMO7White
                Return True
                '       Exit Function

        End Select



        Return False

    End Function
    Public Sub SetDeviceType(ByVal ControllerIndex As Byte, ByVal Alasis As String)

        Select Case LCase(Alasis)

            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ' RAT Devices


            Case RAT3, RAT3_3500, RAT3_3500_MadCatz, MOUS9, RATm
                HasRAT = True
                HasRAT3 = True

            Case RAT5, RAT5_5600, RAT5_5600_MadCatz, RAT7, RAT7_6400, RAT7_6400_MadCatz, RAT9, RAT9_6400, RAT9_6400_MadCatz, StealthMouse
                HasRAT = True


            Case RAT7Albino, RAT7Contagion
                HasRAT = True

                HasRATWhite = True

            Case RAT7Infection
                HasRAT = True
                HasRATInfection = True


            Case MMO7, MMO7_MadCatz
                HasRAT = True
                HasMMO7 = True



            Case MMO7White
                HasRAT = True
                HasMMO7White = True
                HasMMO7 = True





                '///////////////////////////////////////////////////////////////////////////////////////////////////////
                ' Keyboard Devices


            Case V1_Keyboard_Cyborg
                HasKeyboard = True


            Case V5_Keyboard_Cyborg, V5_Keyboard_MadCatz
                HasKeyboardv5 = True

            Case V7_Keyboard_Cyborg, V7_Keyboard_MadCatz
                HasKeyboardv7 = True


            Case Strike3, Strike5, Strike7, Strike7_MadCatz
                HasKeyboardSTRIKE7 = True


                '///////////////////////////////////////////////////////////////////////////////////////////////////////
                ' Flight Devices

            Case FLY5, FLY5_MadCatz
                HasFly = True


                '///////////////////////////////////////////////////////////////////////////////////////////////////////
                ' Pro Flight Devices

            Case ProFlightCessnaYoke
                HasPF_YOKE = True

            Case ProFlightCessnaRudderPedals, ProFlightCombatRudderPedals, ProFlightRudderPedals
                HasPF_RUDDERS = True

            Case ProFlightCessnaTrimWheel
                'HasPFTrimWheel = True

            Case ProFlightPacificAviator
                HasFly = True

            Case ProFlightThrottlePitchMixture
                HasPF_TPM = True


                '///////////////////////////////////////////////////////////////////////////////////////////////////////
                ' Gamepad Devices

            Case Cyborg_V1_Pad, Cyborg_V3_Pad, CyborgV5Pad, CyborgXBoxRumblePad, StealthPad
                HasGamePad = True

                '///////////////////////////////////////////////////////////////////////////////////////////////////////
                ' Command Unit Devices

        End Select


    End Sub
    Public Sub SetMMO7LED(ByVal LRed As Byte, ByVal LGreen As Byte, ByVal LBlue As Byte, ByVal RRed As Byte, ByVal RGreen As Byte, ByVal RBlue As Byte)
        Dim CArryLeft(0 To 2) As Byte
        Dim CArryRight(0 To 2) As Byte
        Dim CArryCheck(0 To 5) As Byte


        If RATLINKNAME = "" Or HasRAT = False Then Exit Sub

        CArryLeft(0) = LRed
        CArryLeft(1) = LGreen
        CArryLeft(2) = LBlue
        CArryRight(0) = RRed
        CArryRight(1) = RGreen
        CArryRight(2) = RBlue

        CArryCheck(0) = CArryLeft(0)
        CArryCheck(1) = CArryLeft(1)
        CArryCheck(2) = CArryLeft(2)
        CArryCheck(3) = CArryRight(0)
        CArryCheck(4) = CArryRight(1)
        CArryCheck(5) = CArryRight(2)



        If CArryCheck(0) = MMO7CURRENTLED(0) And CArryCheck(1) = MMO7CURRENTLED(1) And CArryCheck(2) = MMO7CURRENTLED(2) And CArryCheck(3) = MMO7CURRENTLED(3) And CArryCheck(4) = MMO7CURRENTLED(4) And CArryCheck(5) = MMO7CURRENTLED(5) Then Exit Sub


        If RAT.GetCurrentDpiMode > 0 And RAT.GetCurrentDpiMode <= 4 Then
            'We've found the right device!



            MMO7CURRENTLED = CArryCheck

            ' Value 3 is Left LED
            ' Value 0 is Right LED


            'Sets the colors
            RAT.VendorCommandOut(145, 3, 184, CArryLeft)
            RAT.VendorCommandOut(145, 0, 184, CArryRight)

            'This saves the changes to the mouse. I'm going to stop this from happening as I don't see why I would need to save to the EEPROM
            'RAT.Commit()

            Exit Sub
        End If


    End Sub
    Public Sub SetMMO7DefaultLed()

        Call SetMMO7LED(MMO7DEFAULTLED(0), MMO7DEFAULTLED(1), MMO7DEFAULTLED(2), MMO7DEFAULTLED(3), MMO7DEFAULTLED(4), MMO7DEFAULTLED(5))

    End Sub
    Public Sub SetMMO7ALLED(ByVal LRed As Byte, ByVal LGreen As Byte, ByVal LBlue As Byte, ByVal RRed As Byte, ByVal RGreen As Byte, ByVal RBlue As Byte)
        Dim CArryLeft(0 To 2) As Byte
        Dim CArryRight(0 To 2) As Byte
        Dim CArryCheck(0 To 5) As Byte


        If RATLINKNAME = "" Or HasRAT = False Then Exit Sub

        CArryLeft(0) = LRed
        CArryLeft(1) = LGreen
        CArryLeft(2) = LBlue
        CArryRight(0) = RRed
        CArryRight(1) = RGreen
        CArryRight(2) = RBlue

        CArryCheck(0) = CArryLeft(0)
        CArryCheck(1) = CArryLeft(1)
        CArryCheck(2) = CArryLeft(2)
        CArryCheck(3) = CArryRight(0)
        CArryCheck(4) = CArryRight(1)
        CArryCheck(5) = CArryRight(2)



        ' If CArryCheck(0) = MMO7CURRENTLED(0) And CArryCheck(1) = MMO7CURRENTLED(1) And CArryCheck(2) = MMO7CURRENTLED(2) And CArryCheck(3) = MMO7CURRENTLED(3) And CArryCheck(4) = MMO7CURRENTLED(4) And CArryCheck(5) = MMO7CURRENTLED(5) Then Exit Sub


        If RAT.GetCurrentDpiMode > 0 And RAT.GetCurrentDpiMode <= 4 Then
            'We've found the right device!



            MMO7CURRENTLED = CArryCheck

            ' Value 3 is Left LED
            ' Value 0 is Right LED

            'Sets the colors
            RAT.VendorCommandOut(145, 3, 136, CArryLeft)
            RAT.VendorCommandOut(145, 0, 136, CArryRight)

            'This saves the changes to the mouse. I'm going to stop this from happening as I don't see why I would need to save to the EEPROM
            'RAT.Commit()

            Exit Sub
        End If


    End Sub
    Public Sub LoadNewProfile(ByVal Profile As Byte)
        Dim ProfilePath As String
        Dim C() As Integer, x(0 To 3) As Integer, y(0 To 3) As Integer

        On Error GoTo ErrorHandler

1:      ProfilePath = Profiles(Profile).ProfilePath

2:      If ProfilePath = "" Then
            Call MsgBox("Error! Somehow we are trying to swap to a profile that doesn't exist!", vbExclamation)
            Exit Sub
        End If


        'Check if the profile that we are unloading has a script
3:      If Profiles(LastProfile).Script <> "None" And Profiles(LastProfile).Script <> "" And LastProfile > 0 Then
            Call RunScript(Profiles(LastProfile).Script, "UnloadProfile")
        End If



4:      Call SetDevicesActiveProfile(ProfilePath)


        'Check if the Profile we are loading has a script
5:      If Profiles(Profile).Script <> "None" And Profiles(Profile).Script <> "" Then
6:          Call RunScript(Profiles(Profile).Script, "LoadProfile")
        End If

7:      C = GetProfileSettings(Profiles(Profile).Settings)

        ' Check for the Lock Settings

        'Caps Lock
8:      If C(0) = 1 Then
            If My.Computer.Keyboard.CapsLock = False Then
9:              keybd_event(Keys.Capital, 0, 0, 0)
10:             keybd_event(Keys.Capital, 0, KEYEVENTF_KEYUP, 0)
            End If
11:     ElseIf C(0) = 2 Then
            If My.Computer.Keyboard.CapsLock = True Then
13:             keybd_event(Keys.Capital, 0, 0, 0)
14:             keybd_event(Keys.Capital, 0, KEYEVENTF_KEYUP, 0)
            End If
        End If

        'Num Lock
15:     If C(1) = 1 Then
            If My.Computer.Keyboard.NumLock = False Then
16:             keybd_event(Keys.NumLock, 0, 0, 0)
17:             keybd_event(Keys.NumLock, 0, KEYEVENTF_KEYUP, 0)
            End If
18:     ElseIf C(1) = 2 Then
            If My.Computer.Keyboard.NumLock = True Then
19:             keybd_event(Keys.NumLock, 0, 0, 0)
20:             keybd_event(Keys.NumLock, 0, KEYEVENTF_KEYUP, 0)
            End If
        End If

        'Scroll Lock
21:     If C(2) = 1 Then
            If My.Computer.Keyboard.ScrollLock = False Then
22:             keybd_event(Keys.Scroll, 0, 0, 0)
23:             keybd_event(Keys.Scroll, 0, KEYEVENTF_KEYUP, 0)
            End If
24:     ElseIf C(2) = 2 Then
            If My.Computer.Keyboard.ScrollLock = True Then
25:             keybd_event(Keys.Scroll, 0, 0, 0)
26:             keybd_event(Keys.Scroll, 0, KEYEVENTF_KEYUP, 0)
            End If
        End If

        ' Mouse Speed

27:     If C(5) > 0 Then
28:         If C(5) <> SystemInformation.MouseSpeed Then
29:             SystemParametersInfo(SPI_SETMOUSESPEED, 0, C(5), SPIF_UPDATEINIFILE)
            End If
        Else
30:         If SystemInformation.MouseSpeed <> DefaultMouseSpeed Then
31:             SystemParametersInfo(SPI_SETMOUSESPEED, 0, DefaultMouseSpeed, SPIF_UPDATEINIFILE)
            End If
        End If

        ' Check if we need to lock the Profile

32:     If C(6) = 1 Then
            ProfileLocked = True
            LockedProfile = Profile
        End If


        'Check for the RAT Settings
33:     If HasRAT = True Then
34:         C = GetRATCSettings(Profiles(Profile).RATCS)

            If HasMMO7 = True Then

                'Check for Flow
35:             If C(11) = 1 And C(0) = 0 Then
                    Call ToggleMMO7LEDFlow(True, False)
                End If


                ' Check for LED Change
37:             If C(0) = 1 Then

                    'Check if we need to disable the LED Flow
                    Call ToggleMMO7LEDFlow(False, False)

38:                 Call SetMMO7LED(C(1), C(2), C(3), C(4), C(5), C(6))
                    MMO7HASCHANGEDLED = True
                Else

                    If MMO7FLOWDEFAULT = True Then
                        Call ToggleMMO7LEDFlow(True, False)
                    End If
                End If


                'Check if we need to change the LEDs back to the default color.
39:             If C(0) = 0 And C(11) = 0 And MMO7HASCHANGEDLED = True Then
40:                 Call SetMMO7DefaultLed()
                End If

            End If


            ' Check for DPI Settings Change
41:         If C(12) = 1 Then

42:             x(0) = C(13)
43:             y(0) = C(14)
44:             x(1) = C(15)
45:             y(1) = C(16)
46:             x(2) = C(17)
47:             y(2) = C(18)
48:             x(3) = C(19)
49:             y(3) = C(20)

50:             Call ChangeRATDPI(x, y)
            Else

                ' No change required, lets go back to tge default.
51:             Call SetRATDefualtDPI()

            End If


            'Check for DPI Mode Change
52:         If C(7) > 0 And C(7) <= 4 Then


53:             If RATRemeberDPIChange = 1 Then
54:                 If C(7) <> RATProfileLastDPI(Profile) And RATProfileLastDPI(Profile) <> 0 Then

55:                     Call SetRATDPIMode(RATProfileLastDPI(Profile))
                        RATHASCHANGEDDPI = True

                    Else

56:                     If C(7) <> RATCURRENTDPI Then
57:                         Call SetRATDPIMode(C(7))
                            RATHASCHANGEDDPI = True
                        End If

                    End If
                Else

58:                 If C(7) <> RATCURRENTDPI Then
59:                     Call SetRATDPIMode(C(7))
                        RATHASCHANGEDDPI = True
                    End If
                End If


60:         ElseIf C(7) = 0 And RATHASCHANGEDDPI = True Then

61:             If RATRemeberDPIChange = 1 Then

62:                 If RATProfileLastDPI(Profile) > 0 Then
63:                     Call SetRATDPIMode(RATProfileLastDPI(Profile))
                    End If

                End If


            End If


            'Check if we need to change the Precision Aim Percent
64:         If C(8) = 1 Then
65:             Call SetRATPrecisionPercent(C(9), C(10))
            End If


        End If

        frmAutoProfiler.TaskIcon.Text = "Cyborg Auto-Profiler: " & GetProfileName(ProfilePath)
        frmAutoProfiler.lblCP.Text = GetProfileName(ProfilePath)

66:     If Len(GetProfileName(ProfilePath)) >= 14 Then
            frmAutoProfiler.tmrDrawText.Enabled = True
        Else
            frmAutoProfiler.lblCP.Location = New Point(6, 16)
            frmAutoProfiler.tmrDrawText.Enabled = False
        End If



        If ShowTrayProfileChange = 1 Then

            frmAutoProfiler.TaskIcon.ShowBalloonTip(1, "", "Profile has been changed to " & GetProfileName(ProfilePath), frmAutoProfiler.TaskIcon.BalloonTipIcon)
        End If

        ActiveProfile = ProfilePath
        LastProfile = Profile
        LastProfilePath = ProfilePath

67:     Call RefreshSystemTrayProfiles()

        'ProfilerU = Process.Start(PPath & ProfilerPath)

        Exit Sub

ErrorHandler:
        If frmError.Visible = True Then Exit Sub
        frmError.lblErr.Text = "Loading profile has had an error at line " & Err.Erl & vbNewLine & vbNewLine & "Description: " & Err.Description & vbNewLine & vbNewLine & "Please report this to CyborgAutoProfiler@gmail.com"
        frmError.rtbErr.Text = "Loading profile has had an error! Error Description: " & Err.Description & vbNewLine & vbNewLine & "Operating System: " & My.Computer.Info.OSFullName & vbNewLine & "Operating System Version: " & My.Computer.Info.OSVersion & vbNewLine & "Cyborg Version: " & CurrentVersion

        frmError.ShowDialog()
    End Sub
    Public Sub LoadProfile(ByVal ProfilePath As String)

        If ProfilePath = "" Then
            Call MsgBox("Error! Somehow we are trying to swap to a profile that doesn't exist!", vbExclamation)
            Exit Sub
        End If



        Call SetDevicesActiveProfile(ProfilePath)


        frmAutoProfiler.TaskIcon.Text = "Cyborg Auto-Profiler: " & GetProfileName(ProfilePath)
        frmAutoProfiler.lblCP.Text = GetProfileName(ProfilePath)


        If ShowTrayProfileChange = 1 Then
            frmAutoProfiler.TaskIcon.ShowBalloonTip(1, "", "Profile has been changed to " & GetProfileName(ProfilePath), frmAutoProfiler.TaskIcon.BalloonTipIcon)
        End If


    End Sub
    Public Sub RATDPIModeChanged(sender As Object, e As Saitek.Devices.MouseModeEventArgs)
        On Error GoTo ErrorHandler

        Dim DPIMode As Integer


        If HasRAT = False Or RATLINKNAME = "" Then
            If RATReadMode IsNot Nothing Then RATReadMode.Stop()
            Exit Sub
        End If




2:      DPIMode = e.Mode
3:      RATCURRENTDPI = e.Mode

        If RATRemeberDPIChange = 1 Then
4:          RATProfileLastDPI(LoadedProfile) = DPIMode
        End If

        Select Case e.Mode

            Case 1
                frmAutoProfiler.pbDPIMode.Image = My.Resources.DPIMode1


            Case 2
                frmAutoProfiler.pbDPIMode.Image = My.Resources.DPIMode2


            Case 3
                frmAutoProfiler.pbDPIMode.Image = My.Resources.DPIMode3


            Case 4
                frmAutoProfiler.pbDPIMode.Image = My.Resources.DPIMode4


        End Select



        Exit Sub

ErrorHandler:
        RATRemeberDPIChange = 0
        If RATReadMode IsNot Nothing Then RATReadMode.Stop()

        If frmError.Visible = True Then Exit Sub
        frmError.lblErr.Text = "DPI Mode check has had an error at line " & Err.Erl & vbNewLine & vbNewLine & "Description: " & Err.Description & vbNewLine & vbNewLine & "Please report this to CyborgAutoProfiler@gmail.com"
        frmError.rtbErr.Text = "DPI Mode check has had an error! Error Description: " & Err.Description & vbNewLine & vbNewLine & "Operating System: " & My.Computer.Info.OSFullName & vbNewLine & "Operating System Version: " & My.Computer.Info.OSVersion & vbNewLine & "Cyborg Version: " & CurrentVersion

        frmError.ShowDialog()


    End Sub
    Public Sub ToggleMMO7LEDFlow(ByVal Enabled As Boolean, Save As Boolean)

        If frmAutoProfiler.tmrLEDFlow.Enabled = True And Enabled = True Then Exit Sub
        If frmAutoProfiler.tmrLEDFlow.Enabled = False And Enabled = False Then Exit Sub


        If Enabled = True Then
            frmAutoProfiler.tmrLEDFlow.Enabled = True
            frmAutoProfiler.tsmiMMO7FlowToggle.Text = "        Disable MMO7 LED Flow"
            Dim c() As Byte

            c = GetMMO7LED()

            FLOW_RLED = c(0)
            FLOW_GLED = c(1)
            FLOW_BLED = c(2)

        Else
            frmAutoProfiler.tmrLEDFlow.Enabled = False
            frmAutoProfiler.tsmiMMO7FlowToggle.Text = "        Enable MMO7 LED Flow"

            Call SetMMO7DefaultLed()
        End If

        If Save = True Then
            If Enabled = True Then
                LEDFlowEnabled = 1
                MMO7FLOWDEFAULT = True
            Else
                LEDFlowEnabled = 0
                MMO7FLOWDEFAULT = False
            End If

            SetSetting("LEDFlowEnabled", LEDFlowEnabled)
        End If
    End Sub
    Public Function GetMMO7LED() As Byte()
        Dim CArryLeft(0 To 2) As Byte
        Dim CArryRight(0 To 2) As Byte
        Dim RCArry(0 To 5) As Byte

        RCArry(0) = 0
        RCArry(1) = 0
        RCArry(2) = 0
        RCArry(3) = 0
        RCArry(4) = 0
        RCArry(5) = 0

        If RATLINKNAME = "" Or HasRAT = False Then Return RCArry


        If RAT.GetCurrentDpiMode > 0 And RAT.GetCurrentDpiMode <= 4 Then
            'We've found the right device!


            ' Value 3 is Left LED
            ' Value 0 is Right LED

            'get the colors
            RAT.VendorCommandIn(144, 3, 184, CArryLeft)
            RAT.VendorCommandIn(144, 0, 184, CArryRight)

            RAT.VendorCommandIn(144, 3, 134, CArryLeft)
            RAT.VendorCommandIn(144, 0, 134, CArryRight)



            RCArry(0) = CArryLeft(0)
            RCArry(1) = CArryLeft(1)
            RCArry(2) = CArryLeft(2)
            RCArry(3) = CArryRight(0)
            RCArry(4) = CArryRight(1)
            RCArry(5) = CArryRight(2)


            Return RCArry
            Exit Function
        End If



        Return RCArry

    End Function
    Public Function GetMMO7ALLED() As Byte()
        Dim CArryLeft(0 To 2) As Byte
        Dim CArryRight(0 To 2) As Byte
        Dim RCArry(0 To 5) As Byte

        RCArry(0) = 0
        RCArry(1) = 0
        RCArry(2) = 0
        RCArry(3) = 0
        RCArry(4) = 0
        RCArry(5) = 0

        If RATLINKNAME = "" Or HasRAT = False Then Return RCArry


        If RAT.GetCurrentDpiMode > 0 And RAT.GetCurrentDpiMode <= 4 Then
            'We've found the right device!


            ' Value 3 is Left LED
            ' Value 0 is Right LED

            'get the colors
            RAT.VendorCommandIn(144, 3, 136, CArryLeft)
            RAT.VendorCommandIn(144, 0, 136, CArryRight)



            RCArry(0) = CArryLeft(0)
            RCArry(1) = CArryLeft(1)
            RCArry(2) = CArryLeft(2)
            RCArry(3) = CArryRight(0)
            RCArry(4) = CArryRight(1)
            RCArry(5) = CArryRight(2)


            Return RCArry
            Exit Function
        End If



        Return RCArry

    End Function
    Public Function GetRATDPIMode() As Integer
        Dim DPIMode As Integer

        If RATLINKNAME = "" Or HasRAT = False Then Return 0


        If RAT.GetCurrentDpiMode > 0 And RAT.GetCurrentDpiMode <= 4 Then

            'We've found the right device!


            DPIMode = RAT.GetCurrentDpiMode

            Select Case DPIMode

                Case 1
                    frmAutoProfiler.pbDPIMode.Image = My.Resources.DPIMode1


                Case 2
                    frmAutoProfiler.pbDPIMode.Image = My.Resources.DPIMode2


                Case 3
                    frmAutoProfiler.pbDPIMode.Image = My.Resources.DPIMode3


                Case 4
                    frmAutoProfiler.pbDPIMode.Image = My.Resources.DPIMode4


            End Select

            Return DPIMode

            Exit Function
        End If


        Return 0

    End Function
    Public Sub GetRATMaxDPI()
        Dim NewDPI As New Saitek.Devices.DpiPair, OldDPI As New Saitek.Devices.DpiPair
        Dim i As Integer, DPIMode As Integer

        If HasRAT3 = True Then Exit Sub

        i = RAT.GetCurrentDpiMode

        DPIMode = i + 1

        If DPIMode = 5 Then DPIMode = 1

        NewDPI = New Saitek.Devices.DpiPair
        OldDPI = New Saitek.Devices.DpiPair

        OldDPI.X = RAT.MouseDpi(DPIMode).X
        OldDPI.Y = RAT.MouseDpi(DPIMode).Y

        NewDPI.X = 9000
        NewDPI.Y = 9000
        RAT.MouseDpi(DPIMode, NewDPI)

        RATMaxDPI = RAT.MouseDpi(DPIMode).X

        RAT.MouseDpi(DPIMode, OldDPI)

    End Sub
    Public Sub ChangeRATDPI(DPIX() As Integer, DPIY() As Integer)
        Dim NewDPI As New Saitek.Devices.DpiPair
        Dim i As Byte

        If HasRAT3 = True Then Exit Sub

        NewDPI = New Saitek.Devices.DpiPair


        For i = 0 To 3
            NewDPI.X = DPIX(i)
            NewDPI.Y = DPIY(i)
            RAT.MouseDpi(i + 1, NewDPI)
        Next

    End Sub
    Public Sub GetRATDefualtDPI()
        On Error GoTo ErrHandler

        If HasRAT3 = True Then Exit Sub

1:      RATDefualtDPI(1) = New Saitek.Devices.DpiPair
2:      RATDefualtDPI(2) = New Saitek.Devices.DpiPair
3:      RATDefualtDPI(3) = New Saitek.Devices.DpiPair
4:      RATDefualtDPI(4) = New Saitek.Devices.DpiPair

5:      RATDefualtDPI(1).X = RAT.MouseDpi(1).X
6:      RATDefualtDPI(1).Y = RAT.MouseDpi(1).Y
7:      RATDefualtDPI(2).X = RAT.MouseDpi(2).X
8:      RATDefualtDPI(2).Y = RAT.MouseDpi(2).Y
9:      RATDefualtDPI(3).X = RAT.MouseDpi(3).X
10:     RATDefualtDPI(3).Y = RAT.MouseDpi(3).Y
11:     RATDefualtDPI(4).X = RAT.MouseDpi(4).X
12:     RATDefualtDPI(4).Y = RAT.MouseDpi(4).Y

        Exit Sub


ErrHandler:

        If frmError.Visible = True Then Exit Sub
        frmError.lblErr.Text = "Error reading RAR DPI! Error occurred at line: " & Err.Erl & ". Error Description: " & Err.Description & " Please report this to CyborgAutoProfiler@gmail.com and include the devices you have."
        frmError.rtbErr.Text = "Error reading RAR DPI! Error occurred at line: " & Err.Erl & vbNewLine & "Error Description: " & Err.Description & vbNewLine & vbNewLine & "Operating System: " & My.Computer.Info.OSFullName & vbNewLine & "Operating System Version: " & My.Computer.Info.OSVersion & vbNewLine & "Cyborg Version: " & CurrentVersion
        frmError.ShowDialog()
    End Sub
    Public Sub SetRATDefualtDPI()

        If HasRAT3 = True Then Exit Sub

        RAT.MouseDpi(1, RATDefualtDPI(1))
        RAT.MouseDpi(2, RATDefualtDPI(2))
        RAT.MouseDpi(3, RATDefualtDPI(3))
        RAT.MouseDpi(4, RATDefualtDPI(4))
    End Sub
    Public Sub SetRATDPIMode(ByVal DPIMode As Integer)

        If RATLINKNAME = "" Or HasRAT = False Then Exit Sub
        If HasRAT3 = True Then Exit Sub


        If RATCURRENTDPI = DPIMode Then Exit Sub

        If RAT.GetCurrentDpiMode > 0 And RAT.GetCurrentDpiMode <= 4 Then
            'We've found the right device!


            If DPIMode > 0 And DPIMode <= 4 Then
                RAT.SetCurrentDpiMode(DPIMode)

                RATCURRENTDPI = DPIMode


                Select Case DPIMode

                    Case 1
                        frmAutoProfiler.pbDPIMode.Image = My.Resources.DPIMode1


                    Case 2
                        frmAutoProfiler.pbDPIMode.Image = My.Resources.DPIMode2


                    Case 3
                        frmAutoProfiler.pbDPIMode.Image = My.Resources.DPIMode3


                    Case 4
                        frmAutoProfiler.pbDPIMode.Image = My.Resources.DPIMode4


                End Select
            End If

            Exit Sub
        End If
    End Sub
    Public Sub SetRATPrecisionPercent(ByVal XPercent As Byte, ByVal YPercent As Byte)

        If RATLINKNAME = "" Or HasRAT = False Or HasRAT3 = True Then Exit Sub

        If RATCURRENTCXP = XPercent And RATCURRENTCYP = YPercent Then Exit Sub

        If XPercent < 0 Or YPercent < 0 Or XPercent > 100 Or YPercent > 100 Then Exit Sub

        If RAT.GetCurrentDpiMode > 0 And RAT.GetCurrentDpiMode <= 4 Then
            'We've found the right device!
            RAT.PrecisionX = XPercent
            RAT.PrecisionY = YPercent
            RATCURRENTCXP = XPercent
            RATCURRENTCYP = YPercent


        End If
    End Sub
    Public Sub SetDevicesActiveProfile(ByVal ProfilePath As String)
        Dim i As Byte, MacroTime As Integer, TickCount As Integer
        IsWaiting = True

        If ProfilePath = "" Then
            Call MsgBox("Error! Somehow we are trying to swap to a profile that doesn't exist!", vbExclamation)
            Exit Sub
        End If

1:      If System.IO.File.Exists(ProfilePath) = False Then
2:          Call SetCheckerStatus(False)
            Call MsgBox("Cannot find designated profile to use! Reloading Profiles!", vbCritical)

            LoadedProfile = 0
            UsingDefaultProfile = False

3:          Call LoadSettings()
            frmAutoProfiler.lblCP.Text = "None"
            Exit Sub
        End If

4:      If DeviceCount <= 0 Then Exit Sub


        'Try to stop the BSoD

        If GetProfileSetting(LastProfile, 7, False) = 1 Then
            If LastProfilePath <> "" Then
                MacroTime = GetProfileLongestMacro(LastProfilePath)

                If MacroTime > 0 Then
                    MacroTime = MacroTime + 50
                    TickCount = Environment.TickCount + MacroTime

                    Do While Environment.TickCount < TickCount
                        If IsAnyKeyPressed() = True Then

                            frmDebug.txtDebug.Text = "Waiting on Macro..." & vbNewLine



                            Application.DoEvents()
                            If IsAnyKeyPressed() = True Then TickCount = Environment.TickCount + MacroTime + 50
                            Application.DoEvents()


                        End If
                    Loop


                    frmDebug.txtDebug.Text = "Macro Finish, we are clear!" & vbNewLine
                End If
            End If
        End If

        For i = 1 To DeviceCount
            If IsDeviceIgnored(Devices(i).DeviceAlias) = False Then
5:              Saitek.Devices.TorontoDevice.ClearProfile(Devices(i).LinkName)
6:              Saitek.Devices.TorontoDevice.SetActiveProfile(Devices(i).LinkName, ProfilePath)
            End If
        Next

        ActiveProfile = ProfilePath

        IsWaiting = False

        Exit Sub

ErrorHandler:
        If frmError.Visible = True Then Exit Sub
        frmError.lblErr.Text = "SetDevicesActiveProfile has had an error at line " & Err.Erl & vbNewLine & vbNewLine & "Description: " & Err.Description & vbNewLine & vbNewLine & "Please report this to CyborgAutoProfiler@gmail.com"
        frmError.rtbErr.Text = "SetDevicesActiveProfile an error! Error Description: " & Err.Description & vbNewLine & vbNewLine & "Operating System: " & My.Computer.Info.OSFullName & vbNewLine & "Operating System Version: " & My.Computer.Info.OSVersion & vbNewLine & "Cyborg Version: " & CurrentVersion
        frmError.ShowDialog()
    End Sub
    Public Sub ClearDevicesActiveProfile()
        Dim i As Byte

        If DeviceCount <= 0 Then Exit Sub

        'Try to stop the BSoD
        'Do While IsAnyKeyPressed() = True
        '    System.Threading.Thread.Sleep(500)
        'Loop

        For i = 1 To DeviceCount
            Saitek.Devices.TorontoDevice.ClearProfile(Devices(i).LinkName)
        Next


        frmAutoProfiler.TaskIcon.Text = "Cyborg Auto-Profiler: None"
        frmAutoProfiler.lblCP.Text = "None"
        frmAutoProfiler.lblCP.Location = New Point(6, 16)
        frmAutoProfiler.tmrDrawText.Enabled = False


        If ShowTrayProfileChange = 1 Then
            frmAutoProfiler.TaskIcon.ShowBalloonTip(1, "", "Profile has been cleared", frmAutoProfiler.TaskIcon.BalloonTipIcon)
        End If

        ActiveProfile = ""
        'LastProfile = Profile

        Call RefreshSystemTrayProfiles()

    End Sub
End Module
