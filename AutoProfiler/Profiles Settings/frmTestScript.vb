Public Class frmTestScript

    Private Sub frmTestScript_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim folderInfo As New IO.DirectoryInfo(ScriptsDir)
        Dim arrFilesInFolder() As IO.FileInfo
        Dim fileInFolder As IO.FileInfo


        cbScript.Items.Clear()



        arrFilesInFolder = folderInfo.GetFiles("*" & ScriptExt & "*")

        If arrFilesInFolder.Count = 0 Then
            cbScript.Enabled = False
            cmdTestScript.Enabled = False
            rbLoadProfile.Enabled = False
            rbUnloadProfile.Enabled = False
            cbScript.Items.Add("None")
        Else
            cbScript.Enabled = True
            cmdTestScript.Enabled = True
            rbLoadProfile.Enabled = True
            rbUnloadProfile.Enabled = True
        End If


        For Each fileInFolder In arrFilesInFolder


            If Len(fileInFolder.Name) > 3 Then
                cbScript.Items.Add(Mid(fileInFolder.Name, 1, Len(fileInFolder.Name) - 4))
            End If

        Next

        cbScript.SelectedIndex = 0


    End Sub

    Private Sub cmdTestScript_Click(sender As Object, e As EventArgs) Handles cmdTestScript.Click
        Dim SubName As String

        If rbLoadProfile.Checked = True Then
            SubName = "LoadProfile"
        Else
            SubName = "UnloadProfile"
        End If

        If System.IO.File.Exists(Application.StartupPath & "\Scripts\" & cbScript.SelectedItem & ScriptExt) = False Then
            Call MsgBox("This Script could not be found!", vbCritical)
        End If

        Call RunScript(cbScript.SelectedItem, SubName)
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rbLoadProfile.CheckedChanged

    End Sub
End Class