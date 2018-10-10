Public Class frmDeviceInfo

    Private Sub frmDeviceInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim I As Byte

        lbDevices.Items.Clear()

        For I = 1 To DeviceCount
            lbDevices.Items.Add(GetDeviceName(Devices(I).DeviceAlias))
        Next
        lbDevices.SelectedIndex = -1
    End Sub

    Private Sub lbDevices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbDevices.SelectedIndexChanged
        If lbDevices.SelectedIndex < 0 Then
            cbIgnoreDevice.Enabled = False
            Exit Sub
        End If

        pbDevice.Image = GetDeviceIcon(Devices(lbDevices.SelectedIndex + 1).DeviceAlias)

        Dim Dev As Saitek.Devices.TorontoDevice

        Dev = New Saitek.Devices.TorontoDevice(Devices(lbDevices.SelectedIndex + 1).LinkName)

        'Link Name
        txtLinkName.Text = Devices(lbDevices.SelectedIndex + 1).LinkName

        'Serial
        txtSerial.Text = Dev.GetSerialNumberFromDeviceMemory.ToString

        ' Aliases
        txtAliase.Text = Saitek.Devices.TorontoDevice.GetAlias(Devices(lbDevices.SelectedIndex + 1).LinkName).ToString
        txtBaliase.Text = Saitek.Devices.TorontoDevice.GetBalias(Devices(lbDevices.SelectedIndex + 1).LinkName).ToString

        'Manufacturer
        txtManufacturer.Text = Dev.GetManufacturerStringFromDevice

        ' Version
        txtVersion.Text = Dev.VersionString

        ' PID & VID
        txtPID.Text = Dev.Pid.ToString
        txtVID.Text = Dev.Vid.ToString

        ' Driver Version
        txtDV.Text = Saitek.Devices.TorontoDevice.GetDriverVersion(Devices(lbDevices.SelectedIndex + 1).LinkName).ToString

        'Check if we are ignoring the device
        cbIgnoreDevice.Enabled = True
        If IsDeviceIgnored(txtAliase.Text) = True Then
            cbIgnoreDevice.Checked = True
        Else
            cbIgnoreDevice.Checked = False
        End If


    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Dispose()
    End Sub

    Private Sub txtManufacturer_TextChanged(sender As Object, e As EventArgs) Handles txtManufacturer.TextChanged

    End Sub

    Private Sub cbIgnoreDevice_CheckedChanged(sender As Object, e As EventArgs) Handles cbIgnoreDevice.CheckedChanged

    End Sub

    Private Sub cbIgnoreDevice_Click(sender As Object, e As EventArgs) Handles cbIgnoreDevice.Click
        If cbIgnoreDevice.Checked = True Then
            SetIgnoredDevices(txtAliase.Text, True)
        Else
            SetIgnoredDevices(txtAliase.Text, False)
        End If
    End Sub
End Class