Namespace My

    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication

        Private Sub CAP_Startup(ByVal Sender As Object, ByVal e As System.EventArgs) Handles Me.Startup
Startup:

            Dim MyDoc As String

            ' Programs Startup code

            ' Set the default settings
            MaxProfiles = 0
            CheckforUpdate = 1
            DefaultProfile = 0
            ClearProfile = 0
            LoadedProfile = 0
            UsingDefaultProfile = False
            AutoEnable = 0
            HotKeyEnabled = 0
            ShowTrayProfileChange = 1
            DetectionType = 1
            'PPath = "C:\Program Files\SmartTechnology"
            CurrentVersion = My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build
            CheckTime = 1000
            DefaultMouseSpeed = SystemInformation.MouseSpeed

            MyDoc = Mid(Environment.GetFolderPath(Environment.SpecialFolder.System), 1, 2) & "\Users\Public\Documents"

            If IsBeta = True Then
                frmAutoProfiler.Text = "CAP Beta: " & CurrentVersion & ", Build: " & BetaBuild
            End If


            ' Check for Administor Rights
            If IsAdmin() = False Then
                If InStr(Windows.Forms.Application.StartupPath, "Program Files") > 0 Then
                    Call MsgBox("Cyborg Auto-Profiler is in a folder that requires Administrator rights! Please run this software as an Administrator!", vbCritical)
                    End
                End If
            End If

            ' Check if the script directory exist.
            If System.IO.Directory.Exists(ScriptsDir) = False Then
                System.IO.Directory.CreateDirectory(ScriptsDir)
            End If



            ' Is the 'Saitek.Devices.dll' in the folder? If not extract it from the resources
            If System.IO.File.Exists(Windows.Forms.Application.StartupPath & "\Saitek.Devices.dll") = False Then
MakeDLL:
                Dim b() As Byte = My.Resources.Saitek_Devices

                System.IO.File.WriteAllBytes(Windows.Forms.Application.StartupPath & "\Saitek.Devices.dll", b)
                CurrentSaitekDevicesVersion = CAPSaitekDevicesVersion

            ElseIf System.IO.File.Exists(Windows.Forms.Application.StartupPath & "\Saitek.Devices.dll") = True Then

                CurrentSaitekDevicesVersion = FileVersionInfo.GetVersionInfo(Windows.Forms.Application.StartupPath & "\Saitek.Devices.dll").ProductVersion

                If CurrentSaitekDevicesVersion <> CAPSaitekDevicesVersion Then
                    GoTo MakeDLL
                End If
            End If


            ' Is the 'msscript.ocx' in the folder? If not extract it from the resources
            If System.IO.File.Exists(Windows.Forms.Application.StartupPath & "\msscript.ocx") = False Then
                Dim b() As Byte = My.Resources.msscript

                System.IO.File.WriteAllBytes(Windows.Forms.Application.StartupPath & "\msscript.ocx", b)
            End If



            ' Check if settings exist, if not create them.
            If SettingsExist() = False Then

                Call CreateDefaultSettings()
                Call MsgBox("Created default Settings file!", vbInformation)
                GoTo Startup
                Exit Sub
            End If


            ' Clear then load profiles

            Call ClearProfiles()

            Call LoadSettings()
            Call LoadMMO7LEDFlowSettings()

            Call CheckVersion()


            If System.IO.Directory.Exists(ProfilesDir) = False Then
                If System.IO.Directory.Exists(MyDoc & "\SmartTechnology Profiles") Then
                    ProfilesDir = MyDoc & "\SmartTechnology Profiles"
                ElseIf System.IO.Directory.Exists(MyDoc & "\Saitek SD6 Profiles") Then
                    ProfilesDir = MyDoc & "\Saitek SD6 Profiles"
                Else
                    Call MsgBox("Could not find profiles directory! Please go to setting and change 'Profiles Directory' to the correct location.", vbExclamation)
                    ProfilesDir = MyDoc & "\SmartTechnology Profiles"
                End If
            End If


            ' Find devices and show them
            Call FindDevices()


            'frmAutoProfiler.tmrCheckDevices.Enabled = True

            ' Should we enable?
            If AutoEnable = 1 Then
                Call SetCheckerStatus(True)
            End If

            ' Should we enable Hot Keys?
            If HotKeyEnabled = 1 Then
                frmAutoProfiler.tmrHotKey.Enabled = True
                frmAutoProfiler.tsmHotKey.Text = "              Disable Hot Key"
                frmAutoProfiler.tsmHotKey.ForeColor = Color.Red
            End If


            ' Lets check if we can find the editor and if so lets show the option.
            If System.IO.File.Exists(EditorPath) = True Then
                frmAutoProfiler.tsmProfileEditor.Visible = True
            Else
                frmAutoProfiler.tsmProfileEditor.Visible = False
            End If

            ' Timer used to minimize at launch if starting up with system, I have to use a delay or it won't work for some reason...

            frmAutoProfiler.tmrMinimize.Enabled = True


        End Sub
        Public Sub CAP_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown

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

        End Sub



        Private Sub MyApplication_StartupNextInstance(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupNextInstanceEventArgs) Handles Me.StartupNextInstance

            Call MsgBox("Cyborg Auto-Profiler is already running!", vbCritical)

        End Sub



    End Class

    
End Namespace

