<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeviceInfo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeviceInfo))
        Me.lbDevices = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSerial = New System.Windows.Forms.TextBox()
        Me.lblSerial = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAliase = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBaliase = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLinkName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtManufacturer = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtVersion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtVID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDV = New System.Windows.Forms.TextBox()
        Me.pbDevice = New System.Windows.Forms.PictureBox()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cbIgnoreDevice = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbDevice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbDevices
        '
        Me.lbDevices.FormattingEnabled = True
        Me.lbDevices.Location = New System.Drawing.Point(12, 19)
        Me.lbDevices.Name = "lbDevices"
        Me.lbDevices.Size = New System.Drawing.Size(151, 225)
        Me.lbDevices.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbDevices)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(171, 256)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Devices"
        '
        'txtSerial
        '
        Me.txtSerial.Location = New System.Drawing.Point(259, 46)
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.ReadOnly = True
        Me.txtSerial.Size = New System.Drawing.Size(211, 20)
        Me.txtSerial.TabIndex = 2
        '
        'lblSerial
        '
        Me.lblSerial.AutoSize = True
        Me.lblSerial.Location = New System.Drawing.Point(217, 49)
        Me.lblSerial.Name = "lblSerial"
        Me.lblSerial.Size = New System.Drawing.Size(36, 13)
        Me.lblSerial.TabIndex = 3
        Me.lblSerial.Text = "Serial:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(217, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Aliase:"
        '
        'txtAliase
        '
        Me.txtAliase.Location = New System.Drawing.Point(259, 74)
        Me.txtAliase.Name = "txtAliase"
        Me.txtAliase.ReadOnly = True
        Me.txtAliase.Size = New System.Drawing.Size(211, 20)
        Me.txtAliase.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(211, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Baliase:"
        '
        'txtBaliase
        '
        Me.txtBaliase.Location = New System.Drawing.Point(259, 100)
        Me.txtBaliase.Name = "txtBaliase"
        Me.txtBaliase.ReadOnly = True
        Me.txtBaliase.Size = New System.Drawing.Size(211, 20)
        Me.txtBaliase.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(192, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Link Name:"
        '
        'txtLinkName
        '
        Me.txtLinkName.Location = New System.Drawing.Point(259, 20)
        Me.txtLinkName.Name = "txtLinkName"
        Me.txtLinkName.ReadOnly = True
        Me.txtLinkName.Size = New System.Drawing.Size(211, 20)
        Me.txtLinkName.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(183, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Manufacturer:"
        '
        'txtManufacturer
        '
        Me.txtManufacturer.Location = New System.Drawing.Point(259, 126)
        Me.txtManufacturer.Name = "txtManufacturer"
        Me.txtManufacturer.ReadOnly = True
        Me.txtManufacturer.Size = New System.Drawing.Size(211, 20)
        Me.txtManufacturer.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(211, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Version:"
        '
        'txtVersion
        '
        Me.txtVersion.Location = New System.Drawing.Point(259, 152)
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.ReadOnly = True
        Me.txtVersion.Size = New System.Drawing.Size(211, 20)
        Me.txtVersion.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(227, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "PID:"
        '
        'txtPID
        '
        Me.txtPID.Location = New System.Drawing.Point(259, 178)
        Me.txtPID.Name = "txtPID"
        Me.txtPID.ReadOnly = True
        Me.txtPID.Size = New System.Drawing.Size(211, 20)
        Me.txtPID.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(227, 207)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "VID:"
        '
        'txtVID
        '
        Me.txtVID.Location = New System.Drawing.Point(259, 204)
        Me.txtVID.Name = "txtVID"
        Me.txtVID.ReadOnly = True
        Me.txtVID.Size = New System.Drawing.Size(211, 20)
        Me.txtVID.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(180, 233)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Driver Version:"
        '
        'txtDV
        '
        Me.txtDV.Location = New System.Drawing.Point(259, 230)
        Me.txtDV.Name = "txtDV"
        Me.txtDV.ReadOnly = True
        Me.txtDV.Size = New System.Drawing.Size(211, 20)
        Me.txtDV.TabIndex = 18
        '
        'pbDevice
        '
        Me.pbDevice.Location = New System.Drawing.Point(476, 20)
        Me.pbDevice.Name = "pbDevice"
        Me.pbDevice.Size = New System.Drawing.Size(160, 160)
        Me.pbDevice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbDevice.TabIndex = 20
        Me.pbDevice.TabStop = False
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(476, 239)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(160, 23)
        Me.cmdClose.TabIndex = 21
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cbIgnoreDevice
        '
        Me.cbIgnoreDevice.AutoSize = True
        Me.cbIgnoreDevice.Enabled = False
        Me.cbIgnoreDevice.Location = New System.Drawing.Point(511, 186)
        Me.cbIgnoreDevice.Name = "cbIgnoreDevice"
        Me.cbIgnoreDevice.Size = New System.Drawing.Size(93, 17)
        Me.cbIgnoreDevice.TabIndex = 22
        Me.cbIgnoreDevice.Text = "Ignore Device"
        Me.cbIgnoreDevice.UseVisualStyleBackColor = True
        '
        'frmDeviceInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 267)
        Me.Controls.Add(Me.cbIgnoreDevice)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.pbDevice)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDV)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtVID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtVersion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtManufacturer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLinkName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBaliase)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAliase)
        Me.Controls.Add(Me.lblSerial)
        Me.Controls.Add(Me.txtSerial)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmDeviceInfo"
        Me.Text = "Device Information"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.pbDevice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbDevices As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSerial As System.Windows.Forms.TextBox
    Friend WithEvents lblSerial As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAliase As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBaliase As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLinkName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtManufacturer As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtVersion As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPID As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtVID As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDV As System.Windows.Forms.TextBox
    Friend WithEvents pbDevice As System.Windows.Forms.PictureBox
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cbIgnoreDevice As System.Windows.Forms.CheckBox
End Class
