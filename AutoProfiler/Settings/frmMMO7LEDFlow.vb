Public Class frmMMO7LEDFlow

    Private TT As New ToolTip()
    Private Sub pbCP1_Click(sender As Object, e As EventArgs) Handles pbCP1.Click

    End Sub
    Private Sub cmdPC1_Click(sender As Object, e As EventArgs) Handles cmdPC1.Click
        ColorDestination = 2
        frmPickColor.ShowDialog()

        'Dim PickedColor As Color

        'CD.ShowDialog()
        'PickedColor = CD.Color

        'pbCP1.BackColor = PickedColor

        'MMO7LEDFlow(0).Red = PickedColor.R
        'MMO7LEDFlow(0).Green = PickedColor.G
        'MMO7LEDFlow(0).Blue = PickedColor.B
    End Sub

    Private Sub frmMMO7LEDFlow_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        tmrLEDPreview.Enabled = False
    End Sub

    Private Sub frmMMO7LEDFlow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TT.InitialDelay = 1000
        TT.SetToolTip(valInterval, "This setting is the amount of milliseconds that need to pass for each color change in the flow.")
        TT.SetToolTip(valColorDelay, "This setting is for how many seconds are waited after reaching a set color before flowing to the next color.")
        TT.SetToolTip(tbColorCount, "This setting lets you choose how many colors are in the flow. 2-10")
        TT.SetToolTip(chkRandom, "This setting lets you choose if the Flow should follow in the order you set or pick the order of the set colors randomly.")

        If MMO7LEDFlowCount < 2 Or MMO7LEDFlowCount > 10 Then MMO7LEDFlowCount = 2

        tbColorCount.Value = MMO7LEDFlowCount

        valInterval.Value = Val(MMO7LEDFlowSpeed)

        tmrLEDPreview.Interval = MMO7LEDFlowSpeed

        valColorDelay.Value = MMO7LEDFlowColorDelay


        If MMO7LedFlowRandom = 1 Then
            chkRandom.Checked = 1
            chkCursorPos.Enabled = False
        Else
            chkRandom.Checked = 0
        End If

        If MMO7LedFlowPulse = 1 Then
            chkEnablePulse.Checked = True
            chkCursorPos.Enabled = False
        Else
            chkEnablePulse.Checked = False
        End If

        If MMO7LEDCUSORPOS = 1 Then
            chkCursorPos.Enabled = True
            chkCursorPos.Checked = True
            chkEnablePulse.Enabled = False
            chkRandom.Enabled = False
        End If

        pbCP1.BackColor = Color.FromArgb(MMO7LEDFlow(0).Red, MMO7LEDFlow(0).Green, MMO7LEDFlow(0).Blue)
        pbCP2.BackColor = Color.FromArgb(MMO7LEDFlow(1).Red, MMO7LEDFlow(1).Green, MMO7LEDFlow(1).Blue)
        pbCP3.BackColor = Color.FromArgb(MMO7LEDFlow(2).Red, MMO7LEDFlow(2).Green, MMO7LEDFlow(2).Blue)
        pbCP4.BackColor = Color.FromArgb(MMO7LEDFlow(3).Red, MMO7LEDFlow(3).Green, MMO7LEDFlow(3).Blue)
        pbCP5.BackColor = Color.FromArgb(MMO7LEDFlow(4).Red, MMO7LEDFlow(4).Green, MMO7LEDFlow(4).Blue)
        pbCP6.BackColor = Color.FromArgb(MMO7LEDFlow(5).Red, MMO7LEDFlow(5).Green, MMO7LEDFlow(5).Blue)
        pbCP7.BackColor = Color.FromArgb(MMO7LEDFlow(6).Red, MMO7LEDFlow(6).Green, MMO7LEDFlow(6).Blue)
        pbCP8.BackColor = Color.FromArgb(MMO7LEDFlow(7).Red, MMO7LEDFlow(7).Green, MMO7LEDFlow(7).Blue)
        pbCP9.BackColor = Color.FromArgb(MMO7LEDFlow(8).Red, MMO7LEDFlow(8).Green, MMO7LEDFlow(8).Blue)
        pbCP10.BackColor = Color.FromArgb(MMO7LEDFlow(9).Red, MMO7LEDFlow(9).Green, MMO7LEDFlow(9).Blue)
    End Sub

    Private Sub tbColorCount_Scroll(sender As Object, e As EventArgs) Handles tbColorCount.Scroll
        MMO7LEDFlowCount = tbColorCount.Value


        If MMO7LEDFlowCount >= 3 Then
            pbCP3.Enabled = True
            cmdPC3.Enabled = True
        Else
            pbCP3.Enabled = False
            cmdPC3.Enabled = False
        End If

        If MMO7LEDFlowCount >= 4 Then
            pbCP4.Enabled = True
            cmdPC4.Enabled = True
        Else
            pbCP4.Enabled = False
            cmdPC4.Enabled = False
        End If

        If MMO7LEDFlowCount >= 5 Then
            pbCP5.Enabled = True
            cmdPC5.Enabled = True
        Else
            pbCP5.Enabled = False
            cmdPC5.Enabled = False
        End If

        If MMO7LEDFlowCount >= 6 Then
            pbCP6.Enabled = True
            cmdPC6.Enabled = True
        Else
            pbCP6.Enabled = False
            cmdPC6.Enabled = False
        End If

        If MMO7LEDFlowCount >= 7 Then
            pbCP7.Enabled = True
            cmdPC7.Enabled = True
        Else
            pbCP7.Enabled = False
            cmdPC7.Enabled = False
        End If

        If MMO7LEDFlowCount >= 8 Then
            pbCP8.Enabled = True
            cmdPC8.Enabled = True
        Else
            pbCP8.Enabled = False
            cmdPC8.Enabled = False
        End If

        If MMO7LEDFlowCount >= 9 Then
            pbCP9.Enabled = True
            cmdPC9.Enabled = True
        Else
            pbCP9.Enabled = False
            cmdPC9.Enabled = False
        End If

        If MMO7LEDFlowCount = 10 Then
            pbCP10.Enabled = True
            cmdPC10.Enabled = True
        Else
            pbCP10.Enabled = False
            cmdPC10.Enabled = False
        End If



    End Sub

    Private Sub cmdPC2_Click(sender As Object, e As EventArgs) Handles cmdPC2.Click
        ColorDestination = 3
        frmPickColor.ShowDialog()

        'Dim PickedColor As Color

        'CD.ShowDialog()
        'PickedColor = CD.Color

        'pbCP2.BackColor = PickedColor

        'MMO7LEDFlow(1).Red = PickedColor.R
        'MMO7LEDFlow(1).Green = PickedColor.G
        'MMO7LEDFlow(1).Blue = PickedColor.B
    End Sub

    Private Sub cmdPC3_Click(sender As Object, e As EventArgs) Handles cmdPC3.Click
        ColorDestination = 4
        frmPickColor.ShowDialog()


        'Dim PickedColor As Color

        'CD.ShowDialog()
        'PickedColor = CD.Color

        'pbCP3.BackColor = PickedColor

        'MMO7LEDFlow(2).Red = PickedColor.R
        'MMO7LEDFlow(2).Green = PickedColor.G
        'MMO7LEDFlow(2).Blue = PickedColor.B
    End Sub

    Private Sub cmdPC4_Click(sender As Object, e As EventArgs) Handles cmdPC4.Click
        ColorDestination = 5
        frmPickColor.ShowDialog()


        'Dim PickedColor As Color

        'CD.ShowDialog()
        'PickedColor = CD.Color

        'pbCP4.BackColor = PickedColor

        'MMO7LEDFlow(3).Red = PickedColor.R
        'MMO7LEDFlow(3).Green = PickedColor.G
        'MMO7LEDFlow(3).Blue = PickedColor.B
    End Sub

    Private Sub cmdPC5_Click(sender As Object, e As EventArgs) Handles cmdPC5.Click
        ColorDestination = 6
        frmPickColor.ShowDialog()

        'Dim PickedColor As Color

        'CD.ShowDialog()
        'PickedColor = CD.Color

        'pbCP5.BackColor = PickedColor

        'MMO7LEDFlow(4).Red = PickedColor.R
        'MMO7LEDFlow(4).Green = PickedColor.G
        'MMO7LEDFlow(4).Blue = PickedColor.B
    End Sub

    Private Sub cmdPC6_Click(sender As Object, e As EventArgs) Handles cmdPC6.Click
        ColorDestination = 7
        frmPickColor.ShowDialog()

        'Dim PickedColor As Color

        'CD.ShowDialog()
        'PickedColor = CD.Color

        'pbCP6.BackColor = PickedColor

        'MMO7LEDFlow(5).Red = PickedColor.R
        'MMO7LEDFlow(5).Green = PickedColor.G
        'MMO7LEDFlow(5).Blue = PickedColor.B
    End Sub

    Private Sub cmdPC7_Click(sender As Object, e As EventArgs) Handles cmdPC7.Click
        ColorDestination = 8
        frmPickColor.ShowDialog()

        'Dim PickedColor As Color

        'CD.ShowDialog()
        'PickedColor = CD.Color

        'pbCP7.BackColor = PickedColor

        'MMO7LEDFlow(6).Red = PickedColor.R
        'MMO7LEDFlow(6).Green = PickedColor.G
        'MMO7LEDFlow(6).Blue = PickedColor.B
    End Sub

    Private Sub cmdPC8_Click(sender As Object, e As EventArgs) Handles cmdPC8.Click
        ColorDestination = 9
        frmPickColor.ShowDialog()

        'Dim PickedColor As Color

        'CD.ShowDialog()
        'PickedColor = CD.Color

        'pbCP8.BackColor = PickedColor

        'MMO7LEDFlow(7).Red = PickedColor.R
        'MMO7LEDFlow(7).Green = PickedColor.G
        'MMO7LEDFlow(7).Blue = PickedColor.B
    End Sub

    Private Sub cmdPC9_Click(sender As Object, e As EventArgs) Handles cmdPC9.Click
        ColorDestination = 10
        frmPickColor.ShowDialog()

        'Dim PickedColor As Color

        'CD.ShowDialog()
        'PickedColor = CD.Color

        'pbCP9.BackColor = PickedColor

        'MMO7LEDFlow(8).Red = PickedColor.R
        'MMO7LEDFlow(8).Green = PickedColor.G
        'MMO7LEDFlow(8).Blue = PickedColor.B
    End Sub

    Private Sub cmdPC10_Click(sender As Object, e As EventArgs) Handles cmdPC10.Click
        ColorDestination = 11
        frmPickColor.ShowDialog()

        'Dim PickedColor As Color

        'CD.ShowDialog()
        'PickedColor = CD.Color

        'pbCP10.BackColor = PickedColor

        'MMO7LEDFlow(9).Red = PickedColor.R
        'MMO7LEDFlow(9).Green = PickedColor.G
        'MMO7LEDFlow(9).Blue = PickedColor.B
    End Sub

    Private Sub chkRandom_CheckedChanged(sender As Object, e As EventArgs) Handles chkRandom.CheckedChanged
        If chkRandom.Checked = True Then
            MMO7LedFlowRandom = 1
            chkCursorPos.Enabled = False
        Else
            MMO7LedFlowRandom = 0
            If chkEnablePulse.Checked = False Then
                chkCursorPos.Enabled = True
            End If
            End If
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

        tmrLEDPreview.Enabled = False
        MMO7LEDFlowSpeed = valInterval.Value
        MMO7LEDFlowColorDelay = valColorDelay.Value


        frmAutoProfiler.tmrLEDFlow.Interval = MMO7LEDFlowSpeed


        Call SetMMO7DefaultLed()
        Call SaveMMO7LEDFlowSettings()
        Me.Dispose()
    End Sub

    Private Sub tbColorCount_ValueChanged(sender As Object, e As EventArgs) Handles tbColorCount.ValueChanged


        If MMO7LEDFlowCount >= 3 Then
            pbCP3.Enabled = True
            cmdPC3.Enabled = True
        Else
            pbCP3.Enabled = False
            cmdPC3.Enabled = False
        End If

        If MMO7LEDFlowCount >= 4 Then
            pbCP4.Enabled = True
            cmdPC4.Enabled = True
        Else
            pbCP4.Enabled = False
            cmdPC4.Enabled = False
        End If

        If MMO7LEDFlowCount >= 5 Then
            pbCP5.Enabled = True
            cmdPC5.Enabled = True
        Else
            pbCP5.Enabled = False
            cmdPC5.Enabled = False
        End If

        If MMO7LEDFlowCount >= 6 Then
            pbCP6.Enabled = True
            cmdPC6.Enabled = True
        Else
            pbCP6.Enabled = False
            cmdPC6.Enabled = False
        End If

        If MMO7LEDFlowCount >= 7 Then
            pbCP7.Enabled = True
            cmdPC7.Enabled = True
        Else
            pbCP7.Enabled = False
            cmdPC7.Enabled = False
        End If

        If MMO7LEDFlowCount >= 8 Then
            pbCP8.Enabled = True
            cmdPC8.Enabled = True
        Else
            pbCP8.Enabled = False
            cmdPC8.Enabled = False
        End If

        If MMO7LEDFlowCount >= 9 Then
            pbCP9.Enabled = True
            cmdPC9.Enabled = True
        Else
            pbCP9.Enabled = False
            cmdPC9.Enabled = False
        End If

        If MMO7LEDFlowCount = 10 Then
            pbCP10.Enabled = True
            cmdPC10.Enabled = True
        Else
            pbCP10.Enabled = False
            cmdPC10.Enabled = False
        End If
    End Sub

    Private Sub pbCP2_Click(sender As Object, e As EventArgs) Handles pbCP2.Click

    End Sub



    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub valInterval_Click(sender As Object, e As EventArgs) Handles valInterval.Click
        MMO7LEDFlowSpeed = valInterval.Value
        frmAutoProfiler.tmrLEDFlow.Interval = MMO7LEDFlowSpeed
        tmrLEDPreview.Interval = MMO7LEDFlowSpeed
    End Sub

    Private Sub valInterval_KeyPress(sender As Object, e As KeyPressEventArgs) Handles valInterval.KeyPress
        MMO7LEDFlowSpeed = valInterval.Value
        frmAutoProfiler.tmrLEDFlow.Interval = MMO7LEDFlowSpeed
        tmrLEDPreview.Interval = MMO7LEDFlowSpeed
    End Sub

    Private Sub valInterval_Scroll(sender As Object, e As ScrollEventArgs) Handles valInterval.Scroll
        MMO7LEDFlowSpeed = valInterval.Value
        frmAutoProfiler.tmrLEDFlow.Interval = MMO7LEDFlowSpeed
        tmrLEDPreview.Interval = MMO7LEDFlowSpeed
    End Sub



    Private Sub valInterval_ValueChanged(sender As Object, e As EventArgs) Handles valInterval.ValueChanged

    End Sub

    Private Sub valColorDelay_Click(sender As Object, e As EventArgs) Handles valColorDelay.Click
        MMO7LEDFlowColorDelay = valColorDelay.Value
    End Sub

    Private Sub valColorDelay_KeyPress(sender As Object, e As KeyPressEventArgs) Handles valColorDelay.KeyPress
        MMO7LEDFlowColorDelay = valColorDelay.Value
    End Sub

    Private Sub valColorDelay_Scroll(sender As Object, e As ScrollEventArgs) Handles valColorDelay.Scroll
        MMO7LEDFlowColorDelay = valColorDelay.Value
    End Sub

    Private Sub tmrLEDPreview_Tick(sender As Object, e As EventArgs) Handles tmrLEDPreview.Tick
        Static RLED As Byte, GLED As Byte, BLED As Byte
        Static CurrentColor As Byte
        Static NextColor As Byte
        Static Tick As Integer
        Static Delaying As Boolean



        If Delaying = True Then
            If Environment.TickCount >= Tick Then
                Delaying = False
            Else
                Exit Sub
            End If
        End If



        If MMO7LEDFlow(NextColor).Red = RLED And MMO7LEDFlow(NextColor).Green = GLED And MMO7LEDFlow(NextColor).Blue = BLED Then
            CurrentColor = NextColor
            Tick = Environment.TickCount + MMO7LEDFlowColorDelay * 1000
            Delaying = True

        End If

        If NextColor = CurrentColor Then

            If MMO7LedFlowRandom = 0 Then
                NextColor = CurrentColor + 1

                If NextColor >= MMO7LEDFlowCount Then NextColor = 0
            Else
                NextColor = CInt(Math.Ceiling(Rnd() * MMO7LEDFlowCount - 1))
            End If
        End If


        If RLED > MMO7LEDFlow(NextColor).Red Then
            RLED = RLED - 1
        ElseIf RLED < MMO7LEDFlow(NextColor).Red Then
            RLED = RLED + 1
        End If

        If GLED > MMO7LEDFlow(NextColor).Green Then
            GLED = GLED - 1
        ElseIf GLED < MMO7LEDFlow(NextColor).Green Then
            GLED = GLED + 1
        End If

        If BLED > MMO7LEDFlow(NextColor).Blue Then
            BLED = BLED - 1
        ElseIf BLED < MMO7LEDFlow(NextColor).Blue Then
            BLED = BLED + 1
        End If

        pbMMO7.BackColor = Color.FromArgb(RLED, GLED, BLED)
        Call SetMMO7LED(RLED, GLED, BLED, RLED, GLED, BLED)

    End Sub

    Private Sub cmdPreviewToggle_Click(sender As Object, e As EventArgs) Handles cmdPreviewToggle.Click
        If tmrLEDPreview.Enabled = False Then
            tmrLEDPreview.Enabled = True
            cmdPreviewToggle.Text = "Disable Preview"
        Else
            tmrLEDPreview.Enabled = False
            cmdPreviewToggle.Text = "Enable Preview"
            pbMMO7.BackColor = Color.Black
            Call SetMMO7DefaultLed()
        End If
    End Sub
    Public Sub ReturnColor(Position As Byte, R As Byte, G As Byte, B As Byte)
        Select Case Position

            Case 2
                pbCP1.BackColor = Color.FromArgb(R, G, B)

                MMO7LEDFlow(0).Red = R
                MMO7LEDFlow(0).Green = G
                MMO7LEDFlow(0).Blue = B

            Case 3
                pbCP2.BackColor = Color.FromArgb(R, G, B)

                MMO7LEDFlow(1).Red = R
                MMO7LEDFlow(1).Green = G
                MMO7LEDFlow(1).Blue = B

            Case 4
                pbCP3.BackColor = Color.FromArgb(R, G, B)

                MMO7LEDFlow(2).Red = R
                MMO7LEDFlow(2).Green = G
                MMO7LEDFlow(2).Blue = B

            Case 5
                pbCP4.BackColor = Color.FromArgb(R, G, B)

                MMO7LEDFlow(3).Red = R
                MMO7LEDFlow(3).Green = G
                MMO7LEDFlow(3).Blue = B

            Case 6
                pbCP5.BackColor = Color.FromArgb(R, G, B)

                MMO7LEDFlow(4).Red = R
                MMO7LEDFlow(4).Green = G
                MMO7LEDFlow(4).Blue = B

            Case 7
                pbCP6.BackColor = Color.FromArgb(R, G, B)

                MMO7LEDFlow(5).Red = R
                MMO7LEDFlow(5).Green = G
                MMO7LEDFlow(5).Blue = B

            Case 8
                pbCP7.BackColor = Color.FromArgb(R, G, B)

                MMO7LEDFlow(6).Red = R
                MMO7LEDFlow(6).Green = G
                MMO7LEDFlow(6).Blue = B

            Case 9
                pbCP8.BackColor = Color.FromArgb(R, G, B)

                MMO7LEDFlow(7).Red = R
                MMO7LEDFlow(7).Green = G
                MMO7LEDFlow(7).Blue = B

            Case 10
                pbCP9.BackColor = Color.FromArgb(R, G, B)

                MMO7LEDFlow(8).Red = R
                MMO7LEDFlow(8).Green = G
                MMO7LEDFlow(8).Blue = B

            Case 11
                pbCP10.BackColor = Color.FromArgb(R, G, B)

                MMO7LEDFlow(9).Red = R
                MMO7LEDFlow(9).Green = G
                MMO7LEDFlow(9).Blue = B


        End Select
    End Sub

    Private Sub chkEnablePulse_CheckedChanged(sender As Object, e As EventArgs) Handles chkEnablePulse.CheckedChanged
        If chkEnablePulse.Checked = True Then
            MMO7LedFlowPulse = 1
            chkCursorPos.Enabled = False
        Else
            MMO7LedFlowPulse = 0
            If chkRandom.Checked = False Then
                chkCursorPos.Enabled = True
            End If
        End If
    End Sub

    Private Sub chkCursorPos_CheckedChanged(sender As Object, e As EventArgs) Handles chkCursorPos.CheckedChanged
        If chkCursorPos.Checked = True Then
            MMO7LEDCUSORPOS = 1
            chkEnablePulse.Enabled = False
            chkRandom.Enabled = False
        Else
            MMO7LEDCUSORPOS = 0
            chkEnablePulse.Enabled = True
            chkRandom.Enabled = True
        End If

    End Sub
End Class