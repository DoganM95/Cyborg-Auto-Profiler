<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.valInterval = New System.Windows.Forms.NumericUpDown()
        Me.chkStartup = New System.Windows.Forms.CheckBox()
        Me.chkAutoEnable = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdPDBrowse = New System.Windows.Forms.Button()
        Me.txtProfileDest = New System.Windows.Forms.TextBox()
        Me.cmdDefault = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rbCursor = New System.Windows.Forms.RadioButton()
        Me.rbAW = New System.Windows.Forms.RadioButton()
        Me.rbProcess = New System.Windows.Forms.RadioButton()
        Me.chkBTPC = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.chkCFU = New System.Windows.Forms.CheckBox()
        Me.chkClearProfile = New System.Windows.Forms.CheckBox()
        Me.chkHotKey = New System.Windows.Forms.CheckBox()
        Me.chkRDC = New System.Windows.Forms.CheckBox()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdDI = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.valInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(330, 279)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 1
        Me.cmdSave.Text = "Apply"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(247, 279)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 2
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.valInterval)
        Me.GroupBox2.Location = New System.Drawing.Point(288, 64)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(116, 45)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Check Interval(ms)"
        '
        'valInterval
        '
        Me.valInterval.Location = New System.Drawing.Point(10, 18)
        Me.valInterval.Maximum = New Decimal(New Integer() {30000, 0, 0, 0})
        Me.valInterval.Minimum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.valInterval.Name = "valInterval"
        Me.valInterval.Size = New System.Drawing.Size(100, 20)
        Me.valInterval.TabIndex = 0
        Me.valInterval.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'chkStartup
        '
        Me.chkStartup.AutoSize = True
        Me.chkStartup.Location = New System.Drawing.Point(236, 42)
        Me.chkStartup.Name = "chkStartup"
        Me.chkStartup.Size = New System.Drawing.Size(117, 17)
        Me.chkStartup.TabIndex = 4
        Me.chkStartup.Text = "Start with Windows"
        Me.chkStartup.UseVisualStyleBackColor = True
        '
        'chkAutoEnable
        '
        Me.chkAutoEnable.AutoSize = True
        Me.chkAutoEnable.Location = New System.Drawing.Point(235, 65)
        Me.chkAutoEnable.Name = "chkAutoEnable"
        Me.chkAutoEnable.Size = New System.Drawing.Size(116, 17)
        Me.chkAutoEnable.TabIndex = 5
        Me.chkAutoEnable.Text = "Enabled at Launch"
        Me.chkAutoEnable.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdPDBrowse)
        Me.GroupBox3.Controls.Add(Me.txtProfileDest)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(401, 55)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Profiles Directory"
        '
        'cmdPDBrowse
        '
        Me.cmdPDBrowse.Location = New System.Drawing.Point(320, 19)
        Me.cmdPDBrowse.Name = "cmdPDBrowse"
        Me.cmdPDBrowse.Size = New System.Drawing.Size(75, 20)
        Me.cmdPDBrowse.TabIndex = 1
        Me.cmdPDBrowse.Text = "Browse"
        Me.cmdPDBrowse.UseVisualStyleBackColor = True
        '
        'txtProfileDest
        '
        Me.txtProfileDest.Location = New System.Drawing.Point(6, 20)
        Me.txtProfileDest.Name = "txtProfileDest"
        Me.txtProfileDest.Size = New System.Drawing.Size(308, 20)
        Me.txtProfileDest.TabIndex = 0
        '
        'cmdDefault
        '
        Me.cmdDefault.Location = New System.Drawing.Point(166, 279)
        Me.cmdDefault.Name = "cmdDefault"
        Me.cmdDefault.Size = New System.Drawing.Size(75, 23)
        Me.cmdDefault.TabIndex = 7
        Me.cmdDefault.Text = "Default"
        Me.cmdDefault.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbCursor)
        Me.GroupBox4.Controls.Add(Me.rbAW)
        Me.GroupBox4.Controls.Add(Me.rbProcess)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 64)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(279, 45)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Detection Type"
        '
        'rbCursor
        '
        Me.rbCursor.AutoSize = True
        Me.rbCursor.Location = New System.Drawing.Point(218, 19)
        Me.rbCursor.Name = "rbCursor"
        Me.rbCursor.Size = New System.Drawing.Size(55, 17)
        Me.rbCursor.TabIndex = 2
        Me.rbCursor.TabStop = True
        Me.rbCursor.Text = "Cursor"
        Me.rbCursor.UseVisualStyleBackColor = True
        '
        'rbAW
        '
        Me.rbAW.AutoSize = True
        Me.rbAW.Checked = True
        Me.rbAW.Location = New System.Drawing.Point(6, 19)
        Me.rbAW.Name = "rbAW"
        Me.rbAW.Size = New System.Drawing.Size(97, 17)
        Me.rbAW.TabIndex = 1
        Me.rbAW.TabStop = True
        Me.rbAW.Text = "Active Window"
        Me.rbAW.UseVisualStyleBackColor = True
        '
        'rbProcess
        '
        Me.rbProcess.AutoSize = True
        Me.rbProcess.Location = New System.Drawing.Point(125, 19)
        Me.rbProcess.Name = "rbProcess"
        Me.rbProcess.Size = New System.Drawing.Size(63, 17)
        Me.rbProcess.TabIndex = 0
        Me.rbProcess.Text = "Process"
        Me.rbProcess.UseVisualStyleBackColor = True
        '
        'chkBTPC
        '
        Me.chkBTPC.AutoSize = True
        Me.chkBTPC.Location = New System.Drawing.Point(7, 19)
        Me.chkBTPC.Name = "chkBTPC"
        Me.chkBTPC.Size = New System.Drawing.Size(193, 17)
        Me.chkBTPC.TabIndex = 9
        Me.chkBTPC.Text = "Show Profile Change in System tray"
        Me.chkBTPC.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chkCFU)
        Me.GroupBox5.Controls.Add(Me.chkStartup)
        Me.GroupBox5.Controls.Add(Me.chkClearProfile)
        Me.GroupBox5.Controls.Add(Me.chkAutoEnable)
        Me.GroupBox5.Controls.Add(Me.chkHotKey)
        Me.GroupBox5.Controls.Add(Me.chkRDC)
        Me.GroupBox5.Controls.Add(Me.chkBTPC)
        Me.GroupBox5.Location = New System.Drawing.Point(3, 115)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(402, 110)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Options"
        '
        'chkCFU
        '
        Me.chkCFU.AutoSize = True
        Me.chkCFU.Location = New System.Drawing.Point(236, 19)
        Me.chkCFU.Name = "chkCFU"
        Me.chkCFU.Size = New System.Drawing.Size(115, 17)
        Me.chkCFU.TabIndex = 12
        Me.chkCFU.Text = "Check for Updates"
        Me.chkCFU.UseVisualStyleBackColor = True
        '
        'chkClearProfile
        '
        Me.chkClearProfile.AutoSize = True
        Me.chkClearProfile.Location = New System.Drawing.Point(7, 87)
        Me.chkClearProfile.Name = "chkClearProfile"
        Me.chkClearProfile.Size = New System.Drawing.Size(221, 17)
        Me.chkClearProfile.TabIndex = 12
        Me.chkClearProfile.Text = "Clear Profile when no process is detected"
        Me.chkClearProfile.UseVisualStyleBackColor = True
        '
        'chkHotKey
        '
        Me.chkHotKey.AutoSize = True
        Me.chkHotKey.Location = New System.Drawing.Point(7, 65)
        Me.chkHotKey.Name = "chkHotKey"
        Me.chkHotKey.Size = New System.Drawing.Size(106, 17)
        Me.chkHotKey.TabIndex = 11
        Me.chkHotKey.Text = "Hot Key Enabled"
        Me.chkHotKey.UseVisualStyleBackColor = True
        '
        'chkRDC
        '
        Me.chkRDC.AutoSize = True
        Me.chkRDC.Location = New System.Drawing.Point(7, 42)
        Me.chkRDC.Name = "chkRDC"
        Me.chkRDC.Size = New System.Drawing.Size(163, 17)
        Me.chkRDC.TabIndex = 10
        Me.chkRDC.Text = "Remember RAT DPI Change"
        Me.chkRDC.UseVisualStyleBackColor = True
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(14, 277)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(65, 25)
        Me.lblVersion.TabIndex = 13
        Me.lblVersion.Text = "0.0.0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 260)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Version:"
        '
        'cmdDI
        '
        Me.cmdDI.Location = New System.Drawing.Point(9, 231)
        Me.cmdDI.Name = "cmdDI"
        Me.cmdDI.Size = New System.Drawing.Size(393, 23)
        Me.cmdDI.TabIndex = 15
        Me.cmdDI.Text = "Device Information"
        Me.cmdDI.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(409, 306)
        Me.Controls.Add(Me.cmdDI)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.cmdDefault)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.Text = "Cyborg Auto-Profiler - Settings"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.valInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents valInterval As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkStartup As System.Windows.Forms.CheckBox
    Friend WithEvents chkAutoEnable As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdPDBrowse As System.Windows.Forms.Button
    Friend WithEvents txtProfileDest As System.Windows.Forms.TextBox
    Friend WithEvents cmdDefault As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rbAW As System.Windows.Forms.RadioButton
    Friend WithEvents rbProcess As System.Windows.Forms.RadioButton
    Friend WithEvents chkBTPC As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents chkRDC As System.Windows.Forms.CheckBox
    Friend WithEvents chkHotKey As System.Windows.Forms.CheckBox
    Friend WithEvents chkCFU As System.Windows.Forms.CheckBox
    Friend WithEvents rbCursor As System.Windows.Forms.RadioButton
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents chkClearProfile As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdDI As System.Windows.Forms.Button
End Class
