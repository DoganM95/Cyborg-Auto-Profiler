Public Class frmProcessList

    Private Sub frmProcessList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ProcessList As System.Diagnostics.Process()

        lstProcesses.Items.Clear()


        ProcessList = System.Diagnostics.Process.GetProcesses()

        Dim Proc As System.Diagnostics.Process

        For Each Proc In ProcessList

            If Not Proc.ProcessName = "rundll32" And Not Proc.ProcessName = "svchost" And Not Proc.ProcessName = "system" And Not Proc.ProcessName = "System Idle Process" And Not Proc.ProcessName = "conhost" And Not Proc.ProcessName = "sidebar" And Not Proc.ProcessName = "idle" And Not Proc.ProcessName = "audiodg" Then
                lstProcesses.Items.Add(Proc.ProcessName)
            End If



        Next
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdSelect_Click(sender As Object, e As EventArgs) Handles cmdSelect.Click
        Dim s As String

        If lstProcesses.SelectedIndex < 0 Then Exit Sub

        s = lstProcesses.Items.Item(lstProcesses.SelectedIndex)

        If frmProfilesSettings.lstProcesses.Items.Count > 0 Then
            If frmProfilesSettings.lstProcesses.Items.Item(0) = "" Then frmProfilesSettings.lstProcesses.Items.RemoveAt(0)
        End If

        frmProfilesSettings.lstProcesses.Items.Add(s)

        Call MakeProcessList(SelectedProfile)

        Me.Close()
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

    Private Sub lstProcessesPreview_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lstProcesses_DoubleClick(sender As Object, e As EventArgs) Handles lstProcesses.DoubleClick
        If lstProcesses.SelectedIndex >= 0 Then
            Call cmdSelect_Click(sender, e)
        End If
    End Sub

    Private Sub lstProcesses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProcesses.SelectedIndexChanged

    End Sub
End Class