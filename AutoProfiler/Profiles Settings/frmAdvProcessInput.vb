Public Class frmAdvProcessInput

    Private P As Process
    Private PID As Integer
    Private TT As New ToolTip()


    Private Sub frmAdvProcessInput_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Cursor = Cursors.Default
    End Sub
    Private Sub frmAdvProcessInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ProcessList As System.Diagnostics.Process()
        TT.InitialDelay = 1000
        TT.SetToolTip(pbSpy, "Drag this over a window to select the process and window title.")
        TT.SetToolTip(gbWindowTitle, "This is for the text displayed on the Window of a process. Use this if you would only like to detect the process if it is currently displaying the text you set.")

        lstProcesses.Items.Clear()


        ProcessList = System.Diagnostics.Process.GetProcesses()

        Dim Proc As System.Diagnostics.Process

        For Each Proc In ProcessList

            If Not Proc.ProcessName = "rundll32" And Not Proc.ProcessName = "svchost" And Not Proc.ProcessName = "system" And Not Proc.ProcessName = "System Idle Process" And Not Proc.ProcessName = "conhost" And Not Proc.ProcessName = "sidebar" And Not Proc.ProcessName = "idle" And Not Proc.ProcessName = "audiodg" Then

                If Proc.MainWindowTitle <> "" Then
                    lstProcesses.Items.Add(Proc.ProcessName)
                End If
            End If



        Next
    End Sub
    Private Sub MakeProcessList(ByVal Index As Byte)
        Dim i As Byte
        Dim ProcessArray As String

        ProcessArray = ""

        If frmProfilesSettings.lstProcesses.Items.Count > 1 Then
            For i = 0 To frmProfilesSettings.lstProcesses.Items.Count - 1
                ProcessArray = ProcessArray & frmProfilesSettings.lstProcesses.Items.Item(i)

                If i < frmProfilesSettings.lstProcesses.Items.Count - 1 Then
                    ProcessArray = ProcessArray & "�"
                End If
            Next

            TempProfiles(Index).ProcessName = ProcessArray
        ElseIf frmProfilesSettings.lstProcesses.Items.Count = 1 Then

            TempProfiles(Index).ProcessName = frmProfilesSettings.lstProcesses.Items.Item(0)

        ElseIf frmProfilesSettings.lstProcesses.Items.Count = 0 Then

            TempProfiles(Index).ProcessName = ""

        End If
    End Sub

    Private Sub lstProcesses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProcesses.SelectedIndexChanged

        If lstProcesses.SelectedIndex < 0 Then Exit Sub
        If lstProcesses.SelectedItem = "" Then Exit Sub

        lstWindowTitles.Items.Clear()
        txtProcessTitle.Text = ""

        txtProcess.Text = lstProcesses.SelectedItem

        Dim MyProcess() As Process = System.Diagnostics.Process.GetProcessesByName(lstProcesses.SelectedItem)


        Me.Text = MyProcess.Count

        For Each MyPCheck As Process In MyProcess

            If MyPCheck.MainWindowTitle <> "" Then
                lstWindowTitles.Items.Add(MyPCheck.MainWindowTitle)
            End If

        Next



        If lstWindowTitles.Items.Count > 0 Then
            lstWindowTitles.Enabled = True
        Else
            lstWindowTitles.Enabled = False
        End If
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Dispose()
    End Sub

    Private Sub lstWindowTitles_Disposed(sender As Object, e As EventArgs) Handles lstWindowTitles.Disposed
        lstProcesses.Items.Clear()
        lstWindowTitles.Items.Clear()
        txtProcess.Text = ""
        txtProcessTitle.Text = ""
    End Sub

    Private Sub lstWindowTitles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstWindowTitles.SelectedIndexChanged
        If lstWindowTitles.SelectedItem = "" Then Exit Sub

        txtProcessTitle.Text = lstWindowTitles.SelectedItem
    End Sub

    Private Sub cmdAddP_Click(sender As Object, e As EventArgs) Handles cmdAddP.Click
        Dim s As String

        Cursor = Cursors.Default

        If txtProcess.Text = "" Then
            Me.Dispose()
            Exit Sub
        End If


        s = txtProcess.Text

        If frmProfilesSettings.lstProcesses.Items.Count > 0 Then
            If frmProfilesSettings.lstProcesses.Items.Item(0) = "" Then frmProfilesSettings.lstProcesses.Items.RemoveAt(0)
        End If

        If txtProcessTitle.Text <> "" Then
            s = s & "/caption=" & txtProcessTitle.Text
        End If

        frmProfilesSettings.lstProcesses.Items.Add(s)

        Call MakeProcessList(SelectedProfile)

        Me.Dispose()
    End Sub

    Private Sub pbSpy_Click(sender As Object, e As EventArgs) Handles pbSpy.Click

    End Sub

    Private Sub pbSpy_MouseClick(sender As Object, e As MouseEventArgs) Handles pbSpy.MouseClick


    End Sub

    Private Sub pbSpy_MouseDown(sender As Object, e As MouseEventArgs) Handles pbSpy.MouseDown
        Dim SpyCon As New System.IO.MemoryStream(My.Resources.SpyCursorIcon)


        Cursor = New Cursor(SpyCon)

        SpyCon.Close()
    End Sub

    Private Sub pbSpy_MouseUp(sender As Object, e As MouseEventArgs) Handles pbSpy.MouseUp
        GetWindowThreadProcessId(GetAncestor(WindowFromPoint(Cursor.Position.X, Cursor.Position.Y), 2), PID)


        P = Process.GetProcessById(PID)

        If P.ProcessName <> "Cyborg Auto-Profiler" And P.ProcessName <> "Cyborg Auto-Profiler.vshost" Then
            txtProcess.Text = P.ProcessName
            txtProcessTitle.Text = GetWinText(GetAncestor(WindowFromPoint(Cursor.Position.X, Cursor.Position.Y), 2))
        End If

        Cursor = Cursors.Default
    End Sub



End Class