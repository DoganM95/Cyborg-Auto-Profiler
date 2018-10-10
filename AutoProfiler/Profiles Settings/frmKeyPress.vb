Public Class frmKeyPress


    Private Sub frmKeyPress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        AddHandler Me.KeyDown, AddressOf KeyDownHandler
        AddHandler Me.KeyUp, AddressOf KeyUpHandler
    End Sub
    Private Sub KeyUpHandler(ByVal o As Object, ByVal e As KeyEventArgs)
        e.SuppressKeyPress = True



        If e.Modifiers = Keys.None Then
            frmProfilesSettings.txtHotKey.Text = e.KeyCode.ToString

            'MsgBox(e.KeyCode)
            'End
            Call SetProfileSettings(3, SelectedProfile, e.KeyCode, True)
            Call SetProfileSettings(4, SelectedProfile, 0, True)
            Me.Close()
        ElseIf e.KeyCode = Keys.None And e.Modifiers <> Keys.None Then
            frmProfilesSettings.txtHotKey.Text = e.KeyCode.ToString
            Call SetProfileSettings(3, SelectedProfile, e.KeyCode, True)
            Call SetProfileSettings(3, SelectedProfile, 0, True)
            Me.Close()
        ElseIf e.Modifiers <> Keys.None And e.KeyCode <> Keys.None Then

            frmProfilesSettings.txtHotKey.Text = e.Modifiers.ToString & "+" & e.KeyCode.ToString

            If e.Alt = True Then
                Call SetProfileSettings(3, SelectedProfile, 18, True)
            ElseIf e.Control = True Then
                Call SetProfileSettings(3, SelectedProfile, 17, True)
            ElseIf e.Shift = True Then
                Call SetProfileSettings(3, SelectedProfile, 16, True)
            End If

            Call SetProfileSettings(4, SelectedProfile, e.KeyCode, True)

            Me.Close()
        End If



    End Sub

    Private Sub KeyDownHandler(ByVal o As Object, ByVal e As KeyEventArgs)
        e.SuppressKeyPress = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class