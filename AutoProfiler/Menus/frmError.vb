Public Class frmError

    Private Sub frmError_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        Me.Dispose()
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Application.Exit()
    End Sub
End Class