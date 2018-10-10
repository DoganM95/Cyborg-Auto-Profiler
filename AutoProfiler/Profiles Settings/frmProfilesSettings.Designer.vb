<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProfilesSettings
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProfilesSettings))
        Me.cmProfiles = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmRenameProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmDefault = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmEditProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdEditProfile = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.tcMisc = New System.Windows.Forms.TabControl()
        Me.tpGeneral = New System.Windows.Forms.TabPage()
        Me.chkLock = New System.Windows.Forms.CheckBox()
        Me.chkDefaultP = New System.Windows.Forms.CheckBox()
        Me.tpLockKeys = New System.Windows.Forms.TabPage()
        Me.cbSScroll = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbSCaps = New System.Windows.Forms.ComboBox()
        Me.cbSNum = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tpMouseSpeed = New System.Windows.Forms.TabPage()
        Me.cmdPreviewMS = New System.Windows.Forms.Button()
        Me.chkChangeMouseSpeed = New System.Windows.Forms.CheckBox()
        Me.tbMouseSpeed = New System.Windows.Forms.TrackBar()
        Me.tpHotKey = New System.Windows.Forms.TabPage()
        Me.cmdRemoveHotKey = New System.Windows.Forms.Button()
        Me.txtHotKey = New System.Windows.Forms.TextBox()
        Me.cmdEditHotKey = New System.Windows.Forms.Button()
        Me.tpScript = New System.Windows.Forms.TabPage()
        Me.cmdTestScript = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.cbScript = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lstProcesses = New System.Windows.Forms.ListBox()
        Me.cmsProcesses = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmEditProcess = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmRemoveProcess = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRemoveP = New System.Windows.Forms.Button()
        Me.cmdAddP = New System.Windows.Forms.Button()
        Me.cmsAddP = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmAddEXE = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmProcessList = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmAddText = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmAdvancedInput = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbRAT = New System.Windows.Forms.GroupBox()
        Me.tcMMO7 = New System.Windows.Forms.TabControl()
        Me.tpDPI = New System.Windows.Forms.TabPage()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.rbDPI4 = New System.Windows.Forms.RadioButton()
        Me.rbDPI3 = New System.Windows.Forms.RadioButton()
        Me.rbDPI2 = New System.Windows.Forms.RadioButton()
        Me.rbDPI1 = New System.Windows.Forms.RadioButton()
        Me.chkCDPI = New System.Windows.Forms.CheckBox()
        Me.lblDPIY = New System.Windows.Forms.Label()
        Me.lblDPIX = New System.Windows.Forms.Label()
        Me.hsbDPIY = New System.Windows.Forms.HScrollBar()
        Me.hsbDPIX = New System.Windows.Forms.HScrollBar()
        Me.tpDPIMode = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbDPI = New System.Windows.Forms.TrackBar()
        Me.pbDPIMode = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblDPIMode = New System.Windows.Forms.Label()
        Me.tpPP = New System.Windows.Forms.TabPage()
        Me.chkChangPrecisionPercent = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblPrecisionPercentY = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.hsbPrecisionY = New System.Windows.Forms.HScrollBar()
        Me.gbPrecisionX = New System.Windows.Forms.GroupBox()
        Me.lblPrecisionPercentX = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.hsbPrecisionX = New System.Windows.Forms.HScrollBar()
        Me.tpLED = New System.Windows.Forms.TabPage()
        Me.chkFlow = New System.Windows.Forms.CheckBox()
        Me.tcMMO7LED = New System.Windows.Forms.TabControl()
        Me.tpMMO7LeftLED = New System.Windows.Forms.TabPage()
        Me.cmdCopyLeft = New System.Windows.Forms.Button()
        Me.cmdPCLeft = New System.Windows.Forms.Button()
        Me.pbCPLeft = New System.Windows.Forms.PictureBox()
        Me.tpMMO7RightLED = New System.Windows.Forms.TabPage()
        Me.cmdCopyRight = New System.Windows.Forms.Button()
        Me.cmdPCRight = New System.Windows.Forms.Button()
        Me.pbCPRight = New System.Windows.Forms.PictureBox()
        Me.tpMMO7Flow = New System.Windows.Forms.TabPage()
        Me.cmdFlowSettings = New System.Windows.Forms.Button()
        Me.chkCLED = New System.Windows.Forms.CheckBox()
        Me.gbDevices = New System.Windows.Forms.GroupBox()
        Me.chkCCU = New System.Windows.Forms.CheckBox()
        Me.chkAllD = New System.Windows.Forms.CheckBox()
        Me.chkGamepad = New System.Windows.Forms.CheckBox()
        Me.chkFLY = New System.Windows.Forms.CheckBox()
        Me.chkKeyboard = New System.Windows.Forms.CheckBox()
        Me.chkRAT = New System.Windows.Forms.CheckBox()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.cmdAP = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdMoveDown = New System.Windows.Forms.Button()
        Me.cmdMoveUp = New System.Windows.Forms.Button()
        Me.lstProfiles = New System.Windows.Forms.ListBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cmdDLProfile = New System.Windows.Forms.Button()
        Me.tmrMouseSpeedPreview = New System.Windows.Forms.Timer(Me.components)
        Me.chkBSoD = New System.Windows.Forms.CheckBox()
        Me.lblBSoD = New System.Windows.Forms.Label()
        Me.cmProfiles.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.tcMisc.SuspendLayout()
        Me.tpGeneral.SuspendLayout()
        Me.tpLockKeys.SuspendLayout()
        Me.tpMouseSpeed.SuspendLayout()
        CType(Me.tbMouseSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpHotKey.SuspendLayout()
        Me.tpScript.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.cmsProcesses.SuspendLayout()
        Me.cmsAddP.SuspendLayout()
        Me.gbRAT.SuspendLayout()
        Me.tcMMO7.SuspendLayout()
        Me.tpDPI.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.tpDPIMode.SuspendLayout()
        CType(Me.tbDPI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDPIMode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.tpPP.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.gbPrecisionX.SuspendLayout()
        Me.tpLED.SuspendLayout()
        Me.tcMMO7LED.SuspendLayout()
        Me.tpMMO7LeftLED.SuspendLayout()
        CType(Me.pbCPLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpMMO7RightLED.SuspendLayout()
        CType(Me.pbCPRight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpMMO7Flow.SuspendLayout()
        Me.gbDevices.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmProfiles
        '
        Me.cmProfiles.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmRenameProfile, Me.tsmDefault, Me.tsmEditProfile, Me.tsmDelete})
        Me.cmProfiles.Name = "cmProfiles"
        Me.cmProfiles.Size = New System.Drawing.Size(155, 92)
        '
        'tsmRenameProfile
        '
        Me.tsmRenameProfile.Name = "tsmRenameProfile"
        Me.tsmRenameProfile.Size = New System.Drawing.Size(154, 22)
        Me.tsmRenameProfile.Text = "Rename Profile"
        '
        'tsmDefault
        '
        Me.tsmDefault.Name = "tsmDefault"
        Me.tsmDefault.Size = New System.Drawing.Size(154, 22)
        Me.tsmDefault.Text = "Default"
        '
        'tsmEditProfile
        '
        Me.tsmEditProfile.Name = "tsmEditProfile"
        Me.tsmEditProfile.Size = New System.Drawing.Size(154, 22)
        Me.tsmEditProfile.Text = "Edit Profile"
        '
        'tsmDelete
        '
        Me.tsmDelete.Name = "tsmDelete"
        Me.tsmDelete.Size = New System.Drawing.Size(154, 22)
        Me.tsmDelete.Text = "Delete"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(553, 366)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(115, 23)
        Me.cmdSave.TabIndex = 4
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(432, 366)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(115, 23)
        Me.cmdCancel.TabIndex = 8
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdEditProfile
        '
        Me.cmdEditProfile.Enabled = False
        Me.cmdEditProfile.Location = New System.Drawing.Point(987, 260)
        Me.cmdEditProfile.Name = "cmdEditProfile"
        Me.cmdEditProfile.Size = New System.Drawing.Size(102, 23)
        Me.cmdEditProfile.TabIndex = 9
        Me.cmdEditProfile.Text = "Edit Profile"
        Me.cmdEditProfile.UseVisualStyleBackColor = True
        Me.cmdEditProfile.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.gbRAT)
        Me.GroupBox2.Controls.Add(Me.cmdCancel)
        Me.GroupBox2.Controls.Add(Me.cmdSave)
        Me.GroupBox2.Location = New System.Drawing.Point(249, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(673, 398)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Profile Settings"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.tcMisc)
        Me.GroupBox6.Location = New System.Drawing.Point(329, 201)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(339, 159)
        Me.GroupBox6.TabIndex = 16
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Settings"
        '
        'tcMisc
        '
        Me.tcMisc.Controls.Add(Me.tpGeneral)
        Me.tcMisc.Controls.Add(Me.tpLockKeys)
        Me.tcMisc.Controls.Add(Me.tpMouseSpeed)
        Me.tcMisc.Controls.Add(Me.tpHotKey)
        Me.tcMisc.Controls.Add(Me.tpScript)
        Me.tcMisc.Enabled = False
        Me.tcMisc.Location = New System.Drawing.Point(6, 19)
        Me.tcMisc.Name = "tcMisc"
        Me.tcMisc.SelectedIndex = 0
        Me.tcMisc.Size = New System.Drawing.Size(328, 138)
        Me.tcMisc.TabIndex = 0
        '
        'tpGeneral
        '
        Me.tpGeneral.BackColor = System.Drawing.SystemColors.Control
        Me.tpGeneral.Controls.Add(Me.lblBSoD)
        Me.tpGeneral.Controls.Add(Me.chkBSoD)
        Me.tpGeneral.Controls.Add(Me.chkLock)
        Me.tpGeneral.Controls.Add(Me.chkDefaultP)
        Me.tpGeneral.Location = New System.Drawing.Point(4, 22)
        Me.tpGeneral.Name = "tpGeneral"
        Me.tpGeneral.Size = New System.Drawing.Size(320, 112)
        Me.tpGeneral.TabIndex = 4
        Me.tpGeneral.Text = "General"
        '
        'chkLock
        '
        Me.chkLock.AutoSize = True
        Me.chkLock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLock.Location = New System.Drawing.Point(9, 37)
        Me.chkLock.Name = "chkLock"
        Me.chkLock.Size = New System.Drawing.Size(200, 17)
        Me.chkLock.TabIndex = 0
        Me.chkLock.Text = "Lock profile until process ends"
        Me.chkLock.UseVisualStyleBackColor = True
        '
        'chkDefaultP
        '
        Me.chkDefaultP.AutoSize = True
        Me.chkDefaultP.Enabled = False
        Me.chkDefaultP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDefaultP.Location = New System.Drawing.Point(9, 14)
        Me.chkDefaultP.Name = "chkDefaultP"
        Me.chkDefaultP.Size = New System.Drawing.Size(107, 17)
        Me.chkDefaultP.TabIndex = 7
        Me.chkDefaultP.Text = "Default Profile"
        Me.chkDefaultP.UseVisualStyleBackColor = True
        '
        'tpLockKeys
        '
        Me.tpLockKeys.BackColor = System.Drawing.SystemColors.Control
        Me.tpLockKeys.Controls.Add(Me.cbSScroll)
        Me.tpLockKeys.Controls.Add(Me.Label3)
        Me.tpLockKeys.Controls.Add(Me.Label5)
        Me.tpLockKeys.Controls.Add(Me.cbSCaps)
        Me.tpLockKeys.Controls.Add(Me.cbSNum)
        Me.tpLockKeys.Controls.Add(Me.Label4)
        Me.tpLockKeys.Location = New System.Drawing.Point(4, 22)
        Me.tpLockKeys.Name = "tpLockKeys"
        Me.tpLockKeys.Padding = New System.Windows.Forms.Padding(3)
        Me.tpLockKeys.Size = New System.Drawing.Size(320, 112)
        Me.tpLockKeys.TabIndex = 1
        Me.tpLockKeys.Text = "Lock Keys"
        '
        'cbSScroll
        '
        Me.cbSScroll.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSScroll.Enabled = False
        Me.cbSScroll.FormattingEnabled = True
        Me.cbSScroll.Items.AddRange(New Object() {"No Change", "Enabled", "Disabled"})
        Me.cbSScroll.Location = New System.Drawing.Point(84, 72)
        Me.cbSScroll.MaxDropDownItems = 3
        Me.cbSScroll.Name = "cbSScroll"
        Me.cbSScroll.Size = New System.Drawing.Size(230, 21)
        Me.cbSScroll.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Caps Lock:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Scroll Lock:"
        '
        'cbSCaps
        '
        Me.cbSCaps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSCaps.Enabled = False
        Me.cbSCaps.FormattingEnabled = True
        Me.cbSCaps.Items.AddRange(New Object() {"No Change", "Enabled", "Disabled"})
        Me.cbSCaps.Location = New System.Drawing.Point(84, 9)
        Me.cbSCaps.MaxDropDownItems = 3
        Me.cbSCaps.Name = "cbSCaps"
        Me.cbSCaps.Size = New System.Drawing.Size(230, 21)
        Me.cbSCaps.TabIndex = 1
        '
        'cbSNum
        '
        Me.cbSNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSNum.Enabled = False
        Me.cbSNum.FormattingEnabled = True
        Me.cbSNum.Items.AddRange(New Object() {"No Change", "Enabled", "Disabled"})
        Me.cbSNum.Location = New System.Drawing.Point(84, 40)
        Me.cbSNum.MaxDropDownItems = 3
        Me.cbSNum.Name = "cbSNum"
        Me.cbSNum.Size = New System.Drawing.Size(230, 21)
        Me.cbSNum.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Num Lock:"
        '
        'tpMouseSpeed
        '
        Me.tpMouseSpeed.BackColor = System.Drawing.SystemColors.Control
        Me.tpMouseSpeed.Controls.Add(Me.cmdPreviewMS)
        Me.tpMouseSpeed.Controls.Add(Me.chkChangeMouseSpeed)
        Me.tpMouseSpeed.Controls.Add(Me.tbMouseSpeed)
        Me.tpMouseSpeed.Location = New System.Drawing.Point(4, 22)
        Me.tpMouseSpeed.Name = "tpMouseSpeed"
        Me.tpMouseSpeed.Size = New System.Drawing.Size(320, 112)
        Me.tpMouseSpeed.TabIndex = 2
        Me.tpMouseSpeed.Text = "Mouse Speed"
        '
        'cmdPreviewMS
        '
        Me.cmdPreviewMS.Enabled = False
        Me.cmdPreviewMS.Location = New System.Drawing.Point(7, 66)
        Me.cmdPreviewMS.Name = "cmdPreviewMS"
        Me.cmdPreviewMS.Size = New System.Drawing.Size(303, 23)
        Me.cmdPreviewMS.TabIndex = 20
        Me.cmdPreviewMS.Text = "Preview"
        Me.cmdPreviewMS.UseVisualStyleBackColor = True
        '
        'chkChangeMouseSpeed
        '
        Me.chkChangeMouseSpeed.AutoSize = True
        Me.chkChangeMouseSpeed.Location = New System.Drawing.Point(7, 8)
        Me.chkChangeMouseSpeed.Name = "chkChangeMouseSpeed"
        Me.chkChangeMouseSpeed.Size = New System.Drawing.Size(132, 17)
        Me.chkChangeMouseSpeed.TabIndex = 19
        Me.chkChangeMouseSpeed.Text = "Change Mouse Speed"
        Me.chkChangeMouseSpeed.UseVisualStyleBackColor = True
        '
        'tbMouseSpeed
        '
        Me.tbMouseSpeed.Enabled = False
        Me.tbMouseSpeed.Location = New System.Drawing.Point(6, 31)
        Me.tbMouseSpeed.Maximum = 20
        Me.tbMouseSpeed.Minimum = 1
        Me.tbMouseSpeed.Name = "tbMouseSpeed"
        Me.tbMouseSpeed.Size = New System.Drawing.Size(311, 45)
        Me.tbMouseSpeed.TabIndex = 18
        Me.tbMouseSpeed.Value = 10
        '
        'tpHotKey
        '
        Me.tpHotKey.BackColor = System.Drawing.SystemColors.Control
        Me.tpHotKey.Controls.Add(Me.cmdRemoveHotKey)
        Me.tpHotKey.Controls.Add(Me.txtHotKey)
        Me.tpHotKey.Controls.Add(Me.cmdEditHotKey)
        Me.tpHotKey.Location = New System.Drawing.Point(4, 22)
        Me.tpHotKey.Name = "tpHotKey"
        Me.tpHotKey.Padding = New System.Windows.Forms.Padding(3)
        Me.tpHotKey.Size = New System.Drawing.Size(320, 112)
        Me.tpHotKey.TabIndex = 0
        Me.tpHotKey.Text = "Hot Key"
        '
        'cmdRemoveHotKey
        '
        Me.cmdRemoveHotKey.Enabled = False
        Me.cmdRemoveHotKey.Location = New System.Drawing.Point(10, 41)
        Me.cmdRemoveHotKey.Name = "cmdRemoveHotKey"
        Me.cmdRemoveHotKey.Size = New System.Drawing.Size(129, 23)
        Me.cmdRemoveHotKey.TabIndex = 2
        Me.cmdRemoveHotKey.Text = "Remove"
        Me.cmdRemoveHotKey.UseVisualStyleBackColor = True
        '
        'txtHotKey
        '
        Me.txtHotKey.Location = New System.Drawing.Point(10, 15)
        Me.txtHotKey.Name = "txtHotKey"
        Me.txtHotKey.ReadOnly = True
        Me.txtHotKey.Size = New System.Drawing.Size(304, 20)
        Me.txtHotKey.TabIndex = 0
        Me.txtHotKey.Text = "No Key"
        '
        'cmdEditHotKey
        '
        Me.cmdEditHotKey.Enabled = False
        Me.cmdEditHotKey.Location = New System.Drawing.Point(185, 41)
        Me.cmdEditHotKey.Name = "cmdEditHotKey"
        Me.cmdEditHotKey.Size = New System.Drawing.Size(129, 23)
        Me.cmdEditHotKey.TabIndex = 1
        Me.cmdEditHotKey.Text = "Edit Hot Key"
        Me.cmdEditHotKey.UseVisualStyleBackColor = True
        '
        'tpScript
        '
        Me.tpScript.BackColor = System.Drawing.SystemColors.Control
        Me.tpScript.Controls.Add(Me.cmdTestScript)
        Me.tpScript.Controls.Add(Me.GroupBox8)
        Me.tpScript.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tpScript.Location = New System.Drawing.Point(4, 22)
        Me.tpScript.Name = "tpScript"
        Me.tpScript.Padding = New System.Windows.Forms.Padding(3)
        Me.tpScript.Size = New System.Drawing.Size(320, 112)
        Me.tpScript.TabIndex = 3
        Me.tpScript.Text = "Scripts"
        '
        'cmdTestScript
        '
        Me.cmdTestScript.Location = New System.Drawing.Point(6, 72)
        Me.cmdTestScript.Name = "cmdTestScript"
        Me.cmdTestScript.Size = New System.Drawing.Size(308, 27)
        Me.cmdTestScript.TabIndex = 4
        Me.cmdTestScript.Text = "Test Scripts"
        Me.cmdTestScript.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.cbScript)
        Me.GroupBox8.Location = New System.Drawing.Point(7, 14)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(307, 52)
        Me.GroupBox8.TabIndex = 18
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Script"
        '
        'cbScript
        '
        Me.cbScript.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbScript.Enabled = False
        Me.cbScript.FormattingEnabled = True
        Me.cbScript.Location = New System.Drawing.Point(9, 22)
        Me.cbScript.MaxDropDownItems = 100
        Me.cbScript.Name = "cbScript"
        Me.cbScript.Size = New System.Drawing.Size(292, 21)
        Me.cbScript.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lstProcesses)
        Me.GroupBox4.Controls.Add(Me.cmdRemoveP)
        Me.GroupBox4.Controls.Add(Me.cmdAddP)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 15)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(315, 377)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Process Selection"
        '
        'lstProcesses
        '
        Me.lstProcesses.ContextMenuStrip = Me.cmsProcesses
        Me.lstProcesses.FormattingEnabled = True
        Me.lstProcesses.HorizontalScrollbar = True
        Me.lstProcesses.Location = New System.Drawing.Point(7, 17)
        Me.lstProcesses.Name = "lstProcesses"
        Me.lstProcesses.Size = New System.Drawing.Size(302, 316)
        Me.lstProcesses.TabIndex = 5
        '
        'cmsProcesses
        '
        Me.cmsProcesses.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmEditProcess, Me.tsmRemoveProcess})
        Me.cmsProcesses.Name = "cmsProcesses"
        Me.cmsProcesses.Size = New System.Drawing.Size(161, 48)
        '
        'tsmEditProcess
        '
        Me.tsmEditProcess.Name = "tsmEditProcess"
        Me.tsmEditProcess.Size = New System.Drawing.Size(160, 22)
        Me.tsmEditProcess.Text = "Edit Process"
        '
        'tsmRemoveProcess
        '
        Me.tsmRemoveProcess.Name = "tsmRemoveProcess"
        Me.tsmRemoveProcess.Size = New System.Drawing.Size(160, 22)
        Me.tsmRemoveProcess.Text = "Remove Process"
        '
        'cmdRemoveP
        '
        Me.cmdRemoveP.Enabled = False
        Me.cmdRemoveP.Location = New System.Drawing.Point(7, 348)
        Me.cmdRemoveP.Name = "cmdRemoveP"
        Me.cmdRemoveP.Size = New System.Drawing.Size(143, 23)
        Me.cmdRemoveP.TabIndex = 3
        Me.cmdRemoveP.Text = "Remove Process"
        Me.cmdRemoveP.UseVisualStyleBackColor = True
        '
        'cmdAddP
        '
        Me.cmdAddP.ContextMenuStrip = Me.cmsAddP
        Me.cmdAddP.Enabled = False
        Me.cmdAddP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddP.Location = New System.Drawing.Point(166, 349)
        Me.cmdAddP.Name = "cmdAddP"
        Me.cmdAddP.Size = New System.Drawing.Size(143, 23)
        Me.cmdAddP.TabIndex = 2
        Me.cmdAddP.Text = "Add Process"
        Me.cmdAddP.UseVisualStyleBackColor = True
        '
        'cmsAddP
        '
        Me.cmsAddP.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmAddEXE, Me.tsmProcessList, Me.tsmAddText, Me.tsmAdvancedInput})
        Me.cmsAddP.Name = "cmsAddP"
        Me.cmsAddP.Size = New System.Drawing.Size(199, 92)
        '
        'tsmAddEXE
        '
        Me.tsmAddEXE.Name = "tsmAddEXE"
        Me.tsmAddEXE.Size = New System.Drawing.Size(198, 22)
        Me.tsmAddEXE.Text = "Link Executable"
        '
        'tsmProcessList
        '
        Me.tsmProcessList.Name = "tsmProcessList"
        Me.tsmProcessList.Size = New System.Drawing.Size(198, 22)
        Me.tsmProcessList.Text = "Select from Process List"
        '
        'tsmAddText
        '
        Me.tsmAddText.Name = "tsmAddText"
        Me.tsmAddText.Size = New System.Drawing.Size(198, 22)
        Me.tsmAddText.Text = "Manual Input"
        '
        'tsmAdvancedInput
        '
        Me.tsmAdvancedInput.Name = "tsmAdvancedInput"
        Me.tsmAdvancedInput.Size = New System.Drawing.Size(198, 22)
        Me.tsmAdvancedInput.Text = "Advanced Input"
        '
        'gbRAT
        '
        Me.gbRAT.Controls.Add(Me.tcMMO7)
        Me.gbRAT.Location = New System.Drawing.Point(329, 15)
        Me.gbRAT.Name = "gbRAT"
        Me.gbRAT.Size = New System.Drawing.Size(339, 183)
        Me.gbRAT.TabIndex = 6
        Me.gbRAT.TabStop = False
        Me.gbRAT.Text = "RAT/MMO7"
        Me.gbRAT.Visible = False
        '
        'tcMMO7
        '
        Me.tcMMO7.Controls.Add(Me.tpDPI)
        Me.tcMMO7.Controls.Add(Me.tpDPIMode)
        Me.tcMMO7.Controls.Add(Me.tpPP)
        Me.tcMMO7.Controls.Add(Me.tpLED)
        Me.tcMMO7.Enabled = False
        Me.tcMMO7.Location = New System.Drawing.Point(6, 15)
        Me.tcMMO7.Name = "tcMMO7"
        Me.tcMMO7.SelectedIndex = 0
        Me.tcMMO7.Size = New System.Drawing.Size(328, 160)
        Me.tcMMO7.TabIndex = 15
        '
        'tpDPI
        '
        Me.tpDPI.BackColor = System.Drawing.SystemColors.Control
        Me.tpDPI.Controls.Add(Me.GroupBox9)
        Me.tpDPI.Controls.Add(Me.chkCDPI)
        Me.tpDPI.Controls.Add(Me.lblDPIY)
        Me.tpDPI.Controls.Add(Me.lblDPIX)
        Me.tpDPI.Controls.Add(Me.hsbDPIY)
        Me.tpDPI.Controls.Add(Me.hsbDPIX)
        Me.tpDPI.Location = New System.Drawing.Point(4, 22)
        Me.tpDPI.Name = "tpDPI"
        Me.tpDPI.Size = New System.Drawing.Size(320, 134)
        Me.tpDPI.TabIndex = 3
        Me.tpDPI.Text = "DPI"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.rbDPI4)
        Me.GroupBox9.Controls.Add(Me.rbDPI3)
        Me.GroupBox9.Controls.Add(Me.rbDPI2)
        Me.GroupBox9.Controls.Add(Me.rbDPI1)
        Me.GroupBox9.Location = New System.Drawing.Point(3, 14)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(71, 112)
        Me.GroupBox9.TabIndex = 0
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "DPI Mode"
        '
        'rbDPI4
        '
        Me.rbDPI4.AutoSize = True
        Me.rbDPI4.Location = New System.Drawing.Point(5, 89)
        Me.rbDPI4.Name = "rbDPI4"
        Me.rbDPI4.Size = New System.Drawing.Size(61, 17)
        Me.rbDPI4.TabIndex = 3
        Me.rbDPI4.TabStop = True
        Me.rbDPI4.Text = "Mode 4"
        Me.rbDPI4.UseVisualStyleBackColor = True
        '
        'rbDPI3
        '
        Me.rbDPI3.AutoSize = True
        Me.rbDPI3.Location = New System.Drawing.Point(6, 66)
        Me.rbDPI3.Name = "rbDPI3"
        Me.rbDPI3.Size = New System.Drawing.Size(61, 17)
        Me.rbDPI3.TabIndex = 2
        Me.rbDPI3.TabStop = True
        Me.rbDPI3.Text = "Mode 3"
        Me.rbDPI3.UseVisualStyleBackColor = True
        '
        'rbDPI2
        '
        Me.rbDPI2.AutoSize = True
        Me.rbDPI2.Location = New System.Drawing.Point(5, 43)
        Me.rbDPI2.Name = "rbDPI2"
        Me.rbDPI2.Size = New System.Drawing.Size(61, 17)
        Me.rbDPI2.TabIndex = 1
        Me.rbDPI2.TabStop = True
        Me.rbDPI2.Text = "Mode 2"
        Me.rbDPI2.UseVisualStyleBackColor = True
        '
        'rbDPI1
        '
        Me.rbDPI1.AutoSize = True
        Me.rbDPI1.Location = New System.Drawing.Point(5, 20)
        Me.rbDPI1.Name = "rbDPI1"
        Me.rbDPI1.Size = New System.Drawing.Size(61, 17)
        Me.rbDPI1.TabIndex = 0
        Me.rbDPI1.TabStop = True
        Me.rbDPI1.Text = "Mode 1"
        Me.rbDPI1.UseVisualStyleBackColor = True
        '
        'chkCDPI
        '
        Me.chkCDPI.AutoSize = True
        Me.chkCDPI.Location = New System.Drawing.Point(92, 17)
        Me.chkCDPI.Name = "chkCDPI"
        Me.chkCDPI.Size = New System.Drawing.Size(84, 17)
        Me.chkCDPI.TabIndex = 5
        Me.chkCDPI.Text = "Change DPI"
        Me.chkCDPI.UseVisualStyleBackColor = True
        '
        'lblDPIY
        '
        Me.lblDPIY.AutoSize = True
        Me.lblDPIY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDPIY.Location = New System.Drawing.Point(181, 89)
        Me.lblDPIY.Name = "lblDPIY"
        Me.lblDPIY.Size = New System.Drawing.Size(51, 20)
        Me.lblDPIY.TabIndex = 4
        Me.lblDPIY.Text = "Y: 25"
        '
        'lblDPIX
        '
        Me.lblDPIX.AutoSize = True
        Me.lblDPIX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDPIX.Location = New System.Drawing.Point(181, 37)
        Me.lblDPIX.Name = "lblDPIX"
        Me.lblDPIX.Size = New System.Drawing.Size(51, 20)
        Me.lblDPIX.TabIndex = 3
        Me.lblDPIX.Text = "X: 25"
        '
        'hsbDPIY
        '
        Me.hsbDPIY.LargeChange = 1
        Me.hsbDPIY.Location = New System.Drawing.Point(92, 109)
        Me.hsbDPIY.Maximum = 500
        Me.hsbDPIY.Minimum = 25
        Me.hsbDPIY.Name = "hsbDPIY"
        Me.hsbDPIY.Size = New System.Drawing.Size(222, 17)
        Me.hsbDPIY.TabIndex = 2
        Me.hsbDPIY.Value = 25
        '
        'hsbDPIX
        '
        Me.hsbDPIX.LargeChange = 1
        Me.hsbDPIX.Location = New System.Drawing.Point(92, 57)
        Me.hsbDPIX.Maximum = 500
        Me.hsbDPIX.Minimum = 25
        Me.hsbDPIX.Name = "hsbDPIX"
        Me.hsbDPIX.Size = New System.Drawing.Size(222, 17)
        Me.hsbDPIX.TabIndex = 1
        Me.hsbDPIX.Value = 25
        '
        'tpDPIMode
        '
        Me.tpDPIMode.BackColor = System.Drawing.SystemColors.Control
        Me.tpDPIMode.Controls.Add(Me.Label6)
        Me.tpDPIMode.Controls.Add(Me.tbDPI)
        Me.tpDPIMode.Controls.Add(Me.pbDPIMode)
        Me.tpDPIMode.Controls.Add(Me.GroupBox1)
        Me.tpDPIMode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tpDPIMode.Location = New System.Drawing.Point(4, 22)
        Me.tpDPIMode.Name = "tpDPIMode"
        Me.tpDPIMode.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDPIMode.Size = New System.Drawing.Size(320, 134)
        Me.tpDPIMode.TabIndex = 1
        Me.tpDPIMode.Text = "DPI Mode"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 20)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Select DPI Mode"
        '
        'tbDPI
        '
        Me.tbDPI.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbDPI.LargeChange = 1
        Me.tbDPI.Location = New System.Drawing.Point(6, 83)
        Me.tbDPI.Maximum = 4
        Me.tbDPI.Name = "tbDPI"
        Me.tbDPI.Size = New System.Drawing.Size(308, 45)
        Me.tbDPI.TabIndex = 16
        '
        'pbDPIMode
        '
        Me.pbDPIMode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbDPIMode.Image = Global.CyborgAutoProfiler.My.Resources.Resources.DPIMode0
        Me.pbDPIMode.Location = New System.Drawing.Point(14, 33)
        Me.pbDPIMode.Name = "pbDPIMode"
        Me.pbDPIMode.Size = New System.Drawing.Size(9, 43)
        Me.pbDPIMode.TabIndex = 15
        Me.pbDPIMode.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblDPIMode)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(282, 42)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DPI"
        '
        'lblDPIMode
        '
        Me.lblDPIMode.AutoSize = True
        Me.lblDPIMode.Location = New System.Drawing.Point(7, 16)
        Me.lblDPIMode.Name = "lblDPIMode"
        Me.lblDPIMode.Size = New System.Drawing.Size(61, 13)
        Me.lblDPIMode.TabIndex = 1
        Me.lblDPIMode.Text = "No Change"
        '
        'tpPP
        '
        Me.tpPP.BackColor = System.Drawing.SystemColors.Control
        Me.tpPP.Controls.Add(Me.chkChangPrecisionPercent)
        Me.tpPP.Controls.Add(Me.GroupBox3)
        Me.tpPP.Controls.Add(Me.gbPrecisionX)
        Me.tpPP.Location = New System.Drawing.Point(4, 22)
        Me.tpPP.Name = "tpPP"
        Me.tpPP.Size = New System.Drawing.Size(320, 134)
        Me.tpPP.TabIndex = 2
        Me.tpPP.Text = "Precision Percent"
        '
        'chkChangPrecisionPercent
        '
        Me.chkChangPrecisionPercent.AutoSize = True
        Me.chkChangPrecisionPercent.Location = New System.Drawing.Point(9, 11)
        Me.chkChangPrecisionPercent.Name = "chkChangPrecisionPercent"
        Me.chkChangPrecisionPercent.Size = New System.Drawing.Size(149, 17)
        Me.chkChangPrecisionPercent.TabIndex = 4
        Me.chkChangPrecisionPercent.Text = "Change Precision Percent"
        Me.chkChangPrecisionPercent.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblPrecisionPercentY)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.hsbPrecisionY)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 82)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(304, 45)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Precision Y Percent"
        '
        'lblPrecisionPercentY
        '
        Me.lblPrecisionPercentY.AutoSize = True
        Me.lblPrecisionPercentY.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecisionPercentY.Location = New System.Drawing.Point(240, 20)
        Me.lblPrecisionPercentY.Name = "lblPrecisionPercentY"
        Me.lblPrecisionPercentY.Size = New System.Drawing.Size(58, 25)
        Me.lblPrecisionPercentY.TabIndex = 3
        Me.lblPrecisionPercentY.Text = "50%"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(231, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = ":"
        '
        'hsbPrecisionY
        '
        Me.hsbPrecisionY.Enabled = False
        Me.hsbPrecisionY.LargeChange = 1
        Me.hsbPrecisionY.Location = New System.Drawing.Point(8, 25)
        Me.hsbPrecisionY.Name = "hsbPrecisionY"
        Me.hsbPrecisionY.Size = New System.Drawing.Size(220, 17)
        Me.hsbPrecisionY.TabIndex = 1
        Me.hsbPrecisionY.Value = 50
        '
        'gbPrecisionX
        '
        Me.gbPrecisionX.Controls.Add(Me.lblPrecisionPercentX)
        Me.gbPrecisionX.Controls.Add(Me.Label1)
        Me.gbPrecisionX.Controls.Add(Me.hsbPrecisionX)
        Me.gbPrecisionX.Location = New System.Drawing.Point(10, 34)
        Me.gbPrecisionX.Name = "gbPrecisionX"
        Me.gbPrecisionX.Size = New System.Drawing.Size(304, 42)
        Me.gbPrecisionX.TabIndex = 2
        Me.gbPrecisionX.TabStop = False
        Me.gbPrecisionX.Text = "Precision X Percent"
        '
        'lblPrecisionPercentX
        '
        Me.lblPrecisionPercentX.AutoSize = True
        Me.lblPrecisionPercentX.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecisionPercentX.Location = New System.Drawing.Point(240, 16)
        Me.lblPrecisionPercentX.Name = "lblPrecisionPercentX"
        Me.lblPrecisionPercentX.Size = New System.Drawing.Size(58, 25)
        Me.lblPrecisionPercentX.TabIndex = 2
        Me.lblPrecisionPercentX.Text = "50%"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(231, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = ":"
        '
        'hsbPrecisionX
        '
        Me.hsbPrecisionX.Enabled = False
        Me.hsbPrecisionX.LargeChange = 1
        Me.hsbPrecisionX.Location = New System.Drawing.Point(8, 19)
        Me.hsbPrecisionX.Name = "hsbPrecisionX"
        Me.hsbPrecisionX.Size = New System.Drawing.Size(220, 17)
        Me.hsbPrecisionX.TabIndex = 0
        Me.hsbPrecisionX.Value = 50
        '
        'tpLED
        '
        Me.tpLED.BackColor = System.Drawing.SystemColors.Control
        Me.tpLED.Controls.Add(Me.chkFlow)
        Me.tpLED.Controls.Add(Me.tcMMO7LED)
        Me.tpLED.Controls.Add(Me.chkCLED)
        Me.tpLED.Location = New System.Drawing.Point(4, 22)
        Me.tpLED.Name = "tpLED"
        Me.tpLED.Padding = New System.Windows.Forms.Padding(3)
        Me.tpLED.Size = New System.Drawing.Size(320, 134)
        Me.tpLED.TabIndex = 0
        Me.tpLED.Text = "LED"
        '
        'chkFlow
        '
        Me.chkFlow.AutoSize = True
        Me.chkFlow.Location = New System.Drawing.Point(114, 12)
        Me.chkFlow.Name = "chkFlow"
        Me.chkFlow.Size = New System.Drawing.Size(70, 17)
        Me.chkFlow.TabIndex = 9
        Me.chkFlow.Text = "Use Flow"
        Me.chkFlow.UseVisualStyleBackColor = True
        '
        'tcMMO7LED
        '
        Me.tcMMO7LED.Controls.Add(Me.tpMMO7LeftLED)
        Me.tcMMO7LED.Controls.Add(Me.tpMMO7RightLED)
        Me.tcMMO7LED.Controls.Add(Me.tpMMO7Flow)
        Me.tcMMO7LED.Location = New System.Drawing.Point(6, 35)
        Me.tcMMO7LED.Name = "tcMMO7LED"
        Me.tcMMO7LED.SelectedIndex = 0
        Me.tcMMO7LED.Size = New System.Drawing.Size(308, 88)
        Me.tcMMO7LED.TabIndex = 8
        '
        'tpMMO7LeftLED
        '
        Me.tpMMO7LeftLED.BackColor = System.Drawing.SystemColors.Control
        Me.tpMMO7LeftLED.Controls.Add(Me.cmdCopyLeft)
        Me.tpMMO7LeftLED.Controls.Add(Me.cmdPCLeft)
        Me.tpMMO7LeftLED.Controls.Add(Me.pbCPLeft)
        Me.tpMMO7LeftLED.Location = New System.Drawing.Point(4, 22)
        Me.tpMMO7LeftLED.Name = "tpMMO7LeftLED"
        Me.tpMMO7LeftLED.Padding = New System.Windows.Forms.Padding(3)
        Me.tpMMO7LeftLED.Size = New System.Drawing.Size(300, 62)
        Me.tpMMO7LeftLED.TabIndex = 0
        Me.tpMMO7LeftLED.Text = "Left LED"
        '
        'cmdCopyLeft
        '
        Me.cmdCopyLeft.Enabled = False
        Me.cmdCopyLeft.Location = New System.Drawing.Point(6, 36)
        Me.cmdCopyLeft.Name = "cmdCopyLeft"
        Me.cmdCopyLeft.Size = New System.Drawing.Size(288, 23)
        Me.cmdCopyLeft.TabIndex = 8
        Me.cmdCopyLeft.Text = "Copy To Right"
        Me.cmdCopyLeft.UseVisualStyleBackColor = True
        '
        'cmdPCLeft
        '
        Me.cmdPCLeft.Enabled = False
        Me.cmdPCLeft.Location = New System.Drawing.Point(33, 6)
        Me.cmdPCLeft.Name = "cmdPCLeft"
        Me.cmdPCLeft.Size = New System.Drawing.Size(261, 23)
        Me.cmdPCLeft.TabIndex = 6
        Me.cmdPCLeft.Text = "Pick Color"
        Me.cmdPCLeft.UseVisualStyleBackColor = True
        '
        'pbCPLeft
        '
        Me.pbCPLeft.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pbCPLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbCPLeft.Location = New System.Drawing.Point(6, 6)
        Me.pbCPLeft.Name = "pbCPLeft"
        Me.pbCPLeft.Size = New System.Drawing.Size(25, 25)
        Me.pbCPLeft.TabIndex = 7
        Me.pbCPLeft.TabStop = False
        '
        'tpMMO7RightLED
        '
        Me.tpMMO7RightLED.BackColor = System.Drawing.SystemColors.Control
        Me.tpMMO7RightLED.Controls.Add(Me.cmdCopyRight)
        Me.tpMMO7RightLED.Controls.Add(Me.cmdPCRight)
        Me.tpMMO7RightLED.Controls.Add(Me.pbCPRight)
        Me.tpMMO7RightLED.Location = New System.Drawing.Point(4, 22)
        Me.tpMMO7RightLED.Name = "tpMMO7RightLED"
        Me.tpMMO7RightLED.Padding = New System.Windows.Forms.Padding(3)
        Me.tpMMO7RightLED.Size = New System.Drawing.Size(300, 62)
        Me.tpMMO7RightLED.TabIndex = 1
        Me.tpMMO7RightLED.Text = "Right LED"
        '
        'cmdCopyRight
        '
        Me.cmdCopyRight.Enabled = False
        Me.cmdCopyRight.Location = New System.Drawing.Point(6, 36)
        Me.cmdCopyRight.Name = "cmdCopyRight"
        Me.cmdCopyRight.Size = New System.Drawing.Size(288, 23)
        Me.cmdCopyRight.TabIndex = 11
        Me.cmdCopyRight.Text = "Copy To Left"
        Me.cmdCopyRight.UseVisualStyleBackColor = True
        '
        'cmdPCRight
        '
        Me.cmdPCRight.Enabled = False
        Me.cmdPCRight.Location = New System.Drawing.Point(33, 6)
        Me.cmdPCRight.Name = "cmdPCRight"
        Me.cmdPCRight.Size = New System.Drawing.Size(261, 23)
        Me.cmdPCRight.TabIndex = 9
        Me.cmdPCRight.Text = "Pick Color"
        Me.cmdPCRight.UseVisualStyleBackColor = True
        '
        'pbCPRight
        '
        Me.pbCPRight.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pbCPRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbCPRight.Location = New System.Drawing.Point(6, 6)
        Me.pbCPRight.Name = "pbCPRight"
        Me.pbCPRight.Size = New System.Drawing.Size(25, 25)
        Me.pbCPRight.TabIndex = 10
        Me.pbCPRight.TabStop = False
        '
        'tpMMO7Flow
        '
        Me.tpMMO7Flow.BackColor = System.Drawing.SystemColors.Control
        Me.tpMMO7Flow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tpMMO7Flow.Controls.Add(Me.cmdFlowSettings)
        Me.tpMMO7Flow.Location = New System.Drawing.Point(4, 22)
        Me.tpMMO7Flow.Name = "tpMMO7Flow"
        Me.tpMMO7Flow.Size = New System.Drawing.Size(300, 62)
        Me.tpMMO7Flow.TabIndex = 2
        Me.tpMMO7Flow.Text = "Flow"
        '
        'cmdFlowSettings
        '
        Me.cmdFlowSettings.Location = New System.Drawing.Point(3, 3)
        Me.cmdFlowSettings.Name = "cmdFlowSettings"
        Me.cmdFlowSettings.Size = New System.Drawing.Size(294, 56)
        Me.cmdFlowSettings.TabIndex = 0
        Me.cmdFlowSettings.Text = "Color Flow Settings"
        Me.cmdFlowSettings.UseVisualStyleBackColor = True
        '
        'chkCLED
        '
        Me.chkCLED.AutoSize = True
        Me.chkCLED.Enabled = False
        Me.chkCLED.Location = New System.Drawing.Point(6, 12)
        Me.chkCLED.Name = "chkCLED"
        Me.chkCLED.Size = New System.Drawing.Size(87, 17)
        Me.chkCLED.TabIndex = 0
        Me.chkCLED.Text = "Change LED"
        Me.chkCLED.UseVisualStyleBackColor = True
        '
        'gbDevices
        '
        Me.gbDevices.Controls.Add(Me.chkCCU)
        Me.gbDevices.Controls.Add(Me.chkAllD)
        Me.gbDevices.Controls.Add(Me.chkGamepad)
        Me.gbDevices.Controls.Add(Me.chkFLY)
        Me.gbDevices.Controls.Add(Me.chkKeyboard)
        Me.gbDevices.Controls.Add(Me.chkRAT)
        Me.gbDevices.Location = New System.Drawing.Point(987, 67)
        Me.gbDevices.Name = "gbDevices"
        Me.gbDevices.Size = New System.Drawing.Size(200, 158)
        Me.gbDevices.TabIndex = 6
        Me.gbDevices.TabStop = False
        Me.gbDevices.Text = "Devices"
        Me.gbDevices.Visible = False
        '
        'chkCCU
        '
        Me.chkCCU.AutoSize = True
        Me.chkCCU.Enabled = False
        Me.chkCCU.Location = New System.Drawing.Point(9, 110)
        Me.chkCCU.Name = "chkCCU"
        Me.chkCCU.Size = New System.Drawing.Size(131, 17)
        Me.chkCCU.TabIndex = 6
        Me.chkCCU.Text = "Cyborg Command Unit"
        Me.chkCCU.UseVisualStyleBackColor = True
        '
        'chkAllD
        '
        Me.chkAllD.AutoSize = True
        Me.chkAllD.Enabled = False
        Me.chkAllD.Location = New System.Drawing.Point(9, 133)
        Me.chkAllD.Name = "chkAllD"
        Me.chkAllD.Size = New System.Drawing.Size(79, 17)
        Me.chkAllD.TabIndex = 5
        Me.chkAllD.Text = "All Devices"
        Me.chkAllD.UseVisualStyleBackColor = True
        '
        'chkGamepad
        '
        Me.chkGamepad.AutoSize = True
        Me.chkGamepad.Enabled = False
        Me.chkGamepad.Location = New System.Drawing.Point(9, 87)
        Me.chkGamepad.Name = "chkGamepad"
        Me.chkGamepad.Size = New System.Drawing.Size(77, 17)
        Me.chkGamepad.TabIndex = 4
        Me.chkGamepad.Text = "Gamepads"
        Me.chkGamepad.UseVisualStyleBackColor = True
        '
        'chkFLY
        '
        Me.chkFLY.AutoSize = True
        Me.chkFLY.Enabled = False
        Me.chkFLY.Location = New System.Drawing.Point(9, 65)
        Me.chkFLY.Name = "chkFLY"
        Me.chkFLY.Size = New System.Drawing.Size(83, 17)
        Me.chkFLY.TabIndex = 3
        Me.chkFLY.Text = "Flight Sticks"
        Me.chkFLY.UseVisualStyleBackColor = True
        '
        'chkKeyboard
        '
        Me.chkKeyboard.AutoSize = True
        Me.chkKeyboard.Enabled = False
        Me.chkKeyboard.Location = New System.Drawing.Point(9, 42)
        Me.chkKeyboard.Name = "chkKeyboard"
        Me.chkKeyboard.Size = New System.Drawing.Size(76, 17)
        Me.chkKeyboard.TabIndex = 2
        Me.chkKeyboard.Text = "Keyboards"
        Me.chkKeyboard.UseVisualStyleBackColor = True
        '
        'chkRAT
        '
        Me.chkRAT.AutoSize = True
        Me.chkRAT.Enabled = False
        Me.chkRAT.Location = New System.Drawing.Point(9, 19)
        Me.chkRAT.Name = "chkRAT"
        Me.chkRAT.Size = New System.Drawing.Size(63, 17)
        Me.chkRAT.TabIndex = 1
        Me.chkRAT.Text = "Mouses"
        Me.chkRAT.UseVisualStyleBackColor = True
        '
        'cmdAP
        '
        Me.cmdAP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAP.Location = New System.Drawing.Point(129, 358)
        Me.cmdAP.Name = "cmdAP"
        Me.cmdAP.Size = New System.Drawing.Size(102, 34)
        Me.cmdAP.TabIndex = 6
        Me.cmdAP.Text = "Add Profile"
        Me.cmdAP.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Enabled = False
        Me.cmdDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Location = New System.Drawing.Point(6, 358)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(103, 34)
        Me.cmdDelete.TabIndex = 5
        Me.cmdDelete.Text = "Remove Profile"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdMoveDown
        '
        Me.cmdMoveDown.Enabled = False
        Me.cmdMoveDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMoveDown.Location = New System.Drawing.Point(215, 325)
        Me.cmdMoveDown.Name = "cmdMoveDown"
        Me.cmdMoveDown.Size = New System.Drawing.Size(16, 23)
        Me.cmdMoveDown.TabIndex = 14
        Me.cmdMoveDown.Text = "V"
        Me.cmdMoveDown.UseVisualStyleBackColor = True
        '
        'cmdMoveUp
        '
        Me.cmdMoveUp.Enabled = False
        Me.cmdMoveUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMoveUp.Location = New System.Drawing.Point(215, 19)
        Me.cmdMoveUp.Name = "cmdMoveUp"
        Me.cmdMoveUp.Size = New System.Drawing.Size(16, 23)
        Me.cmdMoveUp.TabIndex = 13
        Me.cmdMoveUp.Text = "Λ"
        Me.cmdMoveUp.UseVisualStyleBackColor = True
        '
        'lstProfiles
        '
        Me.lstProfiles.ContextMenuStrip = Me.cmProfiles
        Me.lstProfiles.FormattingEnabled = True
        Me.lstProfiles.HorizontalScrollbar = True
        Me.lstProfiles.Location = New System.Drawing.Point(6, 19)
        Me.lstProfiles.Name = "lstProfiles"
        Me.lstProfiles.Size = New System.Drawing.Size(208, 329)
        Me.lstProfiles.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lstProfiles)
        Me.GroupBox5.Controls.Add(Me.cmdMoveUp)
        Me.GroupBox5.Controls.Add(Me.cmdMoveDown)
        Me.GroupBox5.Controls.Add(Me.cmdDelete)
        Me.GroupBox5.Controls.Add(Me.cmdAP)
        Me.GroupBox5.Location = New System.Drawing.Point(3, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(240, 398)
        Me.GroupBox5.TabIndex = 16
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Profiles"
        '
        'cmdDLProfile
        '
        Me.cmdDLProfile.Location = New System.Drawing.Point(987, 231)
        Me.cmdDLProfile.Name = "cmdDLProfile"
        Me.cmdDLProfile.Size = New System.Drawing.Size(102, 23)
        Me.cmdDLProfile.TabIndex = 15
        Me.cmdDLProfile.Text = "Download Profiles"
        Me.cmdDLProfile.UseVisualStyleBackColor = True
        Me.cmdDLProfile.Visible = False
        '
        'tmrMouseSpeedPreview
        '
        Me.tmrMouseSpeedPreview.Interval = 1000
        '
        'chkBSoD
        '
        Me.chkBSoD.AutoSize = True
        Me.chkBSoD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBSoD.Location = New System.Drawing.Point(9, 60)
        Me.chkBSoD.Name = "chkBSoD"
        Me.chkBSoD.Size = New System.Drawing.Size(120, 17)
        Me.chkBSoD.TabIndex = 8
        Me.chkBSoD.Text = "BSoD Protection"
        Me.chkBSoD.UseVisualStyleBackColor = True
        '
        'lblBSoD
        '
        Me.lblBSoD.AutoSize = True
        Me.lblBSoD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBSoD.Location = New System.Drawing.Point(5, 83)
        Me.lblBSoD.Name = "lblBSoD"
        Me.lblBSoD.Size = New System.Drawing.Size(176, 13)
        Me.lblBSoD.TabIndex = 9
        Me.lblBSoD.Text = "No need for BSoD Protection."
        '
        'frmProfilesSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(928, 405)
        Me.Controls.Add(Me.cmdDLProfile)
        Me.Controls.Add(Me.gbDevices)
        Me.Controls.Add(Me.cmdEditProfile)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProfilesSettings"
        Me.Text = "Cyborg Auto-Profiler - Profiles Settings"
        Me.cmProfiles.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.tcMisc.ResumeLayout(False)
        Me.tpGeneral.ResumeLayout(False)
        Me.tpGeneral.PerformLayout()
        Me.tpLockKeys.ResumeLayout(False)
        Me.tpLockKeys.PerformLayout()
        Me.tpMouseSpeed.ResumeLayout(False)
        Me.tpMouseSpeed.PerformLayout()
        CType(Me.tbMouseSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpHotKey.ResumeLayout(False)
        Me.tpHotKey.PerformLayout()
        Me.tpScript.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.cmsProcesses.ResumeLayout(False)
        Me.cmsAddP.ResumeLayout(False)
        Me.gbRAT.ResumeLayout(False)
        Me.tcMMO7.ResumeLayout(False)
        Me.tpDPI.ResumeLayout(False)
        Me.tpDPI.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.tpDPIMode.ResumeLayout(False)
        Me.tpDPIMode.PerformLayout()
        CType(Me.tbDPI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDPIMode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tpPP.ResumeLayout(False)
        Me.tpPP.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.gbPrecisionX.ResumeLayout(False)
        Me.gbPrecisionX.PerformLayout()
        Me.tpLED.ResumeLayout(False)
        Me.tpLED.PerformLayout()
        Me.tcMMO7LED.ResumeLayout(False)
        Me.tpMMO7LeftLED.ResumeLayout(False)
        CType(Me.pbCPLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpMMO7RightLED.ResumeLayout(False)
        CType(Me.pbCPRight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpMMO7Flow.ResumeLayout(False)
        Me.gbDevices.ResumeLayout(False)
        Me.gbDevices.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdEditProfile As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmProfiles As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmRenameProfile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmDefault As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gbDevices As System.Windows.Forms.GroupBox
    Friend WithEvents chkGamepad As System.Windows.Forms.CheckBox
    Friend WithEvents chkFLY As System.Windows.Forms.CheckBox
    Friend WithEvents chkKeyboard As System.Windows.Forms.CheckBox
    Friend WithEvents chkRAT As System.Windows.Forms.CheckBox
    Friend WithEvents cmdRemoveP As System.Windows.Forms.Button
    Friend WithEvents cmdAddP As System.Windows.Forms.Button
    Friend WithEvents lstProcesses As System.Windows.Forms.ListBox
    Friend WithEvents chkAllD As System.Windows.Forms.CheckBox
    Friend WithEvents chkCCU As System.Windows.Forms.CheckBox
    Friend WithEvents cmsAddP As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmAddText As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmAddEXE As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmProcessList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorDialog As System.Windows.Forms.ColorDialog
    Friend WithEvents tsmEditProfile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsProcesses As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmEditProcess As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmRemoveProcess As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdRemoveHotKey As System.Windows.Forms.Button
    Friend WithEvents cmdEditHotKey As System.Windows.Forms.Button
    Friend WithEvents txtHotKey As System.Windows.Forms.TextBox
    Friend WithEvents tsmAdvancedInput As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cbSCaps As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbSScroll As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbSNum As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gbRAT As System.Windows.Forms.GroupBox
    Friend WithEvents tcMMO7 As System.Windows.Forms.TabControl
    Friend WithEvents tpDPIMode As System.Windows.Forms.TabPage
    Friend WithEvents tbDPI As System.Windows.Forms.TrackBar
    Friend WithEvents pbDPIMode As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblDPIMode As System.Windows.Forms.Label
    Friend WithEvents tpPP As System.Windows.Forms.TabPage
    Friend WithEvents chkChangPrecisionPercent As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPrecisionPercentY As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents hsbPrecisionY As System.Windows.Forms.HScrollBar
    Friend WithEvents gbPrecisionX As System.Windows.Forms.GroupBox
    Friend WithEvents lblPrecisionPercentX As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents hsbPrecisionX As System.Windows.Forms.HScrollBar
    Friend WithEvents tpLED As System.Windows.Forms.TabPage
    Friend WithEvents tcMMO7LED As System.Windows.Forms.TabControl
    Friend WithEvents tpMMO7LeftLED As System.Windows.Forms.TabPage
    Friend WithEvents cmdCopyLeft As System.Windows.Forms.Button
    Friend WithEvents cmdPCLeft As System.Windows.Forms.Button
    Friend WithEvents pbCPLeft As System.Windows.Forms.PictureBox
    Friend WithEvents tpMMO7RightLED As System.Windows.Forms.TabPage
    Friend WithEvents cmdCopyRight As System.Windows.Forms.Button
    Friend WithEvents cmdPCRight As System.Windows.Forms.Button
    Friend WithEvents pbCPRight As System.Windows.Forms.PictureBox
    Friend WithEvents chkCLED As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents tcMisc As System.Windows.Forms.TabControl
    Friend WithEvents tpHotKey As System.Windows.Forms.TabPage
    Friend WithEvents tpLockKeys As System.Windows.Forms.TabPage
    Friend WithEvents cmdAP As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents chkDefaultP As System.Windows.Forms.CheckBox
    Friend WithEvents cmdMoveDown As System.Windows.Forms.Button
    Friend WithEvents cmdMoveUp As System.Windows.Forms.Button
    Friend WithEvents lstProfiles As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tpMouseSpeed As System.Windows.Forms.TabPage
    Friend WithEvents cmdPreviewMS As System.Windows.Forms.Button
    Friend WithEvents chkChangeMouseSpeed As System.Windows.Forms.CheckBox
    Friend WithEvents tbMouseSpeed As System.Windows.Forms.TrackBar
    Friend WithEvents tmrMouseSpeedPreview As System.Windows.Forms.Timer
    Friend WithEvents chkFlow As System.Windows.Forms.CheckBox
    Friend WithEvents tpMMO7Flow As System.Windows.Forms.TabPage
    Friend WithEvents cmdFlowSettings As System.Windows.Forms.Button
    Friend WithEvents cmdDLProfile As System.Windows.Forms.Button
    Friend WithEvents cbScript As System.Windows.Forms.ComboBox
    Friend WithEvents cmdTestScript As System.Windows.Forms.Button
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents tpScript As System.Windows.Forms.TabPage
    Friend WithEvents tpDPI As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents rbDPI4 As System.Windows.Forms.RadioButton
    Friend WithEvents rbDPI3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbDPI2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbDPI1 As System.Windows.Forms.RadioButton
    Friend WithEvents chkCDPI As System.Windows.Forms.CheckBox
    Friend WithEvents lblDPIY As System.Windows.Forms.Label
    Friend WithEvents lblDPIX As System.Windows.Forms.Label
    Friend WithEvents hsbDPIY As System.Windows.Forms.HScrollBar
    Friend WithEvents hsbDPIX As System.Windows.Forms.HScrollBar
    Friend WithEvents tpGeneral As System.Windows.Forms.TabPage
    Friend WithEvents chkLock As System.Windows.Forms.CheckBox
    Friend WithEvents chkBSoD As System.Windows.Forms.CheckBox
    Friend WithEvents lblBSoD As System.Windows.Forms.Label
End Class
