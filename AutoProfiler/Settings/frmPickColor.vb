Public Class frmPickColor

    Private IsMouseDown As Boolean
    Private SwatchBitmap As Bitmap
    Private PickedColor As Color

    Private RedVal As Byte
    Private GreenVal As Byte
    Private BlueVal As Byte


    Private Sub pbSwatch_Click(sender As Object, e As EventArgs) Handles pbSwatch.Click

    End Sub

    Private Sub frmColorPicker_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Call SetMMO7DefaultLed()
    End Sub

    Private Sub frmColorPicker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SwatchBitmap = New Bitmap(pbSwatch.Image)
    End Sub

    Private Sub pbSwatch_MouseClick(sender As Object, e As MouseEventArgs) Handles pbSwatch.MouseClick
        If e.X < 0 Or e.X >= pbSwatch.Width - 4 Or e.Y < 0 Or e.Y >= pbSwatch.Height - 4 Then Exit Sub
        PickColor(SwatchBitmap.GetPixel(e.X, e.Y))
        ' MessageBox.Show("Pixel x=" & e.X & ", y=" & e.Y & ", color=" & MyColor.ToString, "Color", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub pbSwatch_MouseDown(sender As Object, e As MouseEventArgs) Handles pbSwatch.MouseDown
        IsMouseDown = True
        If e.X < 0 Or e.X >= pbSwatch.Width - 4 Or e.Y < 0 Or e.Y >= pbSwatch.Height - 4 Then Exit Sub
        PickColor(SwatchBitmap.GetPixel(e.X, e.Y))
    End Sub

    Private Sub pbSwatch_MouseMove(sender As Object, e As MouseEventArgs) Handles pbSwatch.MouseMove
        If IsMouseDown = True Then
            If e.X < 0 Or e.X >= pbSwatch.Width - 4 Or e.Y < 0 Or e.Y >= pbSwatch.Height - 4 Then Exit Sub
            PickColor(SwatchBitmap.GetPixel(e.X, e.Y))
        End If
    End Sub

    Private Sub pbSwatch_MouseUp(sender As Object, e As MouseEventArgs) Handles pbSwatch.MouseUp
        IsMouseDown = False
    End Sub
    Private Sub PickColor(C As Color)
        PickedColor = C

        pbColor.BackColor = PickedColor
        pbMMO7.BackColor = PickedColor

        If chkP.Checked = True Then
            RedVal = PickedColor.R / 255 * 100
            hsbR.Value = RedVal

            GreenVal = PickedColor.G / 255 * 100
            hsbG.Value = GreenVal

            BlueVal = PickedColor.B / 255 * 100
            hsbB.Value = BlueVal
        Else
            RedVal = PickedColor.R
            hsbR.Value = RedVal
            GreenVal = PickedColor.G
            hsbG.Value = GreenVal
            BlueVal = PickedColor.B
            hsbB.Value = BlueVal

        End If

        Call SetMMO7LED(PickedColor.R, PickedColor.G, PickedColor.B, PickedColor.R, PickedColor.G, PickedColor.B)

    End Sub

    Private Sub hsbR_Scroll(sender As Object, e As ScrollEventArgs) Handles hsbR.Scroll

        If chkP.Checked = True Then
            RedVal = hsbR.Value * 2.55
        Else
            RedVal = hsbR.Value
        End If

        PickColor(Color.FromArgb(RedVal, PickedColor.G, PickedColor.B))
    End Sub

    Private Sub hsbR_ValueChanged(sender As Object, e As EventArgs) Handles hsbR.ValueChanged
        lblR.Text = hsbR.Value
    End Sub

    Private Sub hsbG_Scroll(sender As Object, e As ScrollEventArgs) Handles hsbG.Scroll

        If chkP.Checked = True Then
            GreenVal = hsbG.Value * 2.55
        Else
            GreenVal = hsbG.Value
        End If

        PickColor(Color.FromArgb(PickedColor.R, GreenVal, PickedColor.B))
    End Sub

    Private Sub hsbG_ValueChanged(sender As Object, e As EventArgs) Handles hsbG.ValueChanged
        lblG.Text = hsbG.Value
    End Sub

    Private Sub hsbB_Scroll(sender As Object, e As ScrollEventArgs) Handles hsbB.Scroll

        If chkP.Checked = True Then
            BlueVal = hsbB.Value * 2.55
        Else
            BlueVal = hsbB.Value
        End If

        PickColor(Color.FromArgb(PickedColor.R, PickedColor.G, BlueVal))
    End Sub

    Private Sub hsbB_ValueChanged(sender As Object, e As EventArgs) Handles hsbB.ValueChanged
        lblB.Text = hsbB.Value
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub chkP_CheckedChanged(sender As Object, e As EventArgs) Handles chkP.CheckedChanged
        If chkP.Checked = True Then

            RedVal = PickedColor.R / 255 * 100
            hsbR.Value = RedVal
            hsbR.Maximum = 100

            GreenVal = PickedColor.G / 255 * 100
            hsbG.Value = GreenVal
            hsbG.Maximum = 100

            BlueVal = PickedColor.B / 255 * 100
            hsbB.Value = BlueVal
            hsbB.Maximum = 100


        Else
            hsbR.Maximum = 255
            RedVal = hsbR.Value * 2.55
            hsbR.Value = RedVal

            hsbG.Maximum = 255
            GreenVal = hsbG.Value * 2.55
            hsbG.Value = GreenVal

            hsbB.Maximum = 255
            BlueVal = hsbB.Value * 2.55
            hsbB.Value = BlueVal

        End If
    End Sub

    Private Sub cmdSet_Click(sender As Object, e As EventArgs) Handles cmdSet.Click

        If chkP.Checked = True Then
            RedVal = hsbR.Value * 2.55
            GreenVal = hsbG.Value * 2.55
            BlueVal = hsbB.Value * 2.55
        End If

        If ColorDestination = 0 Or ColorDestination = 1 Then
            Call frmProfilesSettings.ReturnColor(ColorDestination, RedVal, GreenVal, BlueVal)
        Else
            Call frmMMO7LEDFlow.ReturnColor(ColorDestination, RedVal, GreenVal, BlueVal)
        End If

        Me.Close()
    End Sub
End Class