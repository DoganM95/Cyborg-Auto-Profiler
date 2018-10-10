<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDBManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDBManager))
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txtProfileCategory = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdSetProfile = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.cmdSaveDB = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtProfileDevices = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtProcessName = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtProfileDownload = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtProfileName = New System.Windows.Forms.TextBox()
        Me.cmdRemoveProfile = New System.Windows.Forms.Button()
        Me.cmdAddProfile = New System.Windows.Forms.Button()
        Me.lstProfiles = New System.Windows.Forms.ListBox()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txtProfileCategory)
        Me.GroupBox7.Location = New System.Drawing.Point(428, 31)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(200, 49)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Category"
        '
        'txtProfileCategory
        '
        Me.txtProfileCategory.Location = New System.Drawing.Point(7, 20)
        Me.txtProfileCategory.Name = "txtProfileCategory"
        Me.txtProfileCategory.Size = New System.Drawing.Size(187, 20)
        Me.txtProfileCategory.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdSetProfile)
        Me.GroupBox1.Controls.Add(Me.cmdExit)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.cmdSaveDB)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(204, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(435, 345)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Profile Settings"
        '
        'cmdSetProfile
        '
        Me.cmdSetProfile.Location = New System.Drawing.Point(6, 316)
        Me.cmdSetProfile.Name = "cmdSetProfile"
        Me.cmdSetProfile.Size = New System.Drawing.Size(200, 23)
        Me.cmdSetProfile.TabIndex = 0
        Me.cmdSetProfile.Text = "Set Profile"
        Me.cmdSetProfile.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(268, 315)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 0
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtDescription)
        Me.GroupBox6.Location = New System.Drawing.Point(224, 71)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(200, 48)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Description URL"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(7, 20)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(187, 20)
        Me.txtDescription.TabIndex = 4
        '
        'cmdSaveDB
        '
        Me.cmdSaveDB.Location = New System.Drawing.Point(349, 315)
        Me.cmdSaveDB.Name = "cmdSaveDB"
        Me.cmdSaveDB.Size = New System.Drawing.Size(75, 23)
        Me.cmdSaveDB.TabIndex = 0
        Me.cmdSaveDB.Text = "Save DB"
        Me.cmdSaveDB.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtProfileDevices)
        Me.GroupBox5.Location = New System.Drawing.Point(224, 122)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(200, 51)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Profile Devices"
        '
        'txtProfileDevices
        '
        Me.txtProfileDevices.Location = New System.Drawing.Point(7, 20)
        Me.txtProfileDevices.Name = "txtProfileDevices"
        Me.txtProfileDevices.Size = New System.Drawing.Size(187, 20)
        Me.txtProfileDevices.TabIndex = 5
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtProcessName)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 74)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 45)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Process Name"
        '
        'txtProcessName
        '
        Me.txtProcessName.Location = New System.Drawing.Point(7, 20)
        Me.txtProcessName.Name = "txtProcessName"
        Me.txtProcessName.Size = New System.Drawing.Size(187, 20)
        Me.txtProcessName.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtProfileDownload)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 125)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 48)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Profile Download URL"
        '
        'txtProfileDownload
        '
        Me.txtProfileDownload.Location = New System.Drawing.Point(7, 20)
        Me.txtProfileDownload.Name = "txtProfileDownload"
        Me.txtProfileDownload.Size = New System.Drawing.Size(187, 20)
        Me.txtProfileDownload.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtProfileName)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 49)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Profile Name"
        '
        'txtProfileName
        '
        Me.txtProfileName.Location = New System.Drawing.Point(7, 20)
        Me.txtProfileName.Name = "txtProfileName"
        Me.txtProfileName.Size = New System.Drawing.Size(187, 20)
        Me.txtProfileName.TabIndex = 0
        '
        'cmdRemoveProfile
        '
        Me.cmdRemoveProfile.Location = New System.Drawing.Point(109, 334)
        Me.cmdRemoveProfile.Name = "cmdRemoveProfile"
        Me.cmdRemoveProfile.Size = New System.Drawing.Size(89, 23)
        Me.cmdRemoveProfile.TabIndex = 0
        Me.cmdRemoveProfile.Text = "Remove Profile"
        Me.cmdRemoveProfile.UseVisualStyleBackColor = True
        '
        'cmdAddProfile
        '
        Me.cmdAddProfile.Location = New System.Drawing.Point(12, 334)
        Me.cmdAddProfile.Name = "cmdAddProfile"
        Me.cmdAddProfile.Size = New System.Drawing.Size(91, 23)
        Me.cmdAddProfile.TabIndex = 0
        Me.cmdAddProfile.TabStop = False
        Me.cmdAddProfile.Text = "Add Profile"
        Me.cmdAddProfile.UseVisualStyleBackColor = True
        '
        'lstProfiles
        '
        Me.lstProfiles.FormattingEnabled = True
        Me.lstProfiles.Location = New System.Drawing.Point(12, 12)
        Me.lstProfiles.Name = "lstProfiles"
        Me.lstProfiles.Size = New System.Drawing.Size(186, 316)
        Me.lstProfiles.TabIndex = 0
        '
        'frmDBManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 366)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdRemoveProfile)
        Me.Controls.Add(Me.cmdAddProfile)
        Me.Controls.Add(Me.lstProfiles)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmDBManager"
        Me.Text = "CAP - Profile Database Manager"
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents txtProfileCategory As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSetProfile As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents cmdSaveDB As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtProfileDevices As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtProcessName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtProfileDownload As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtProfileName As System.Windows.Forms.TextBox
    Friend WithEvents cmdRemoveProfile As System.Windows.Forms.Button
    Friend WithEvents cmdAddProfile As System.Windows.Forms.Button
    Friend WithEvents lstProfiles As System.Windows.Forms.ListBox
End Class
