Public Class frmHelp

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click

        Me.Dispose()
    End Sub

    Private Sub frmHelp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rtbReadMe.Text = My.Resources.Read_Me.ToString
    End Sub

    Private Sub rtbReadMe_TextChanged(sender As Object, e As EventArgs) Handles rtbReadMe.TextChanged

    End Sub
End Class