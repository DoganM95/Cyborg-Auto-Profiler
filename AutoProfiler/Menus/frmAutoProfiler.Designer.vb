<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAutoProfiler
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAutoProfiler))
        Me.cmdSettings = New System.Windows.Forms.Button()
        Me.cmdProfiles = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.tmrAPCheck = New System.Windows.Forms.Timer(Me.components)
        Me.cmdED = New System.Windows.Forms.Button()
        Me.TaskIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cmtTaskbar = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmED = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmHotKey = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmEditProfiles = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmProfiles = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsProfiles = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsbProfiles = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsmProfileEditor = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.TSAutoProfiler = New System.Windows.Forms.ToolStrip()
        Me.TScmdHelp = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.TScmdAbout = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbWeb = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbMMO7 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsmiMMO7FlowSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiMMO7FlowToggle = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrMinimize = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblCP = New System.Windows.Forms.Label()
        Me.gbDevices = New System.Windows.Forms.GroupBox()
        Me.lblFindDevices = New System.Windows.Forms.Label()
        Me.lblDeviceCount = New System.Windows.Forms.Label()
        Me.pbDevice8 = New System.Windows.Forms.PictureBox()
        Me.pbDevice7 = New System.Windows.Forms.PictureBox()
        Me.pbDevice6 = New System.Windows.Forms.PictureBox()
        Me.pbDevice5 = New System.Windows.Forms.PictureBox()
        Me.pbDPIMode = New System.Windows.Forms.PictureBox()
        Me.pbDevice4 = New System.Windows.Forms.PictureBox()
        Me.pbDevice3 = New System.Windows.Forms.PictureBox()
        Me.pbDevice2 = New System.Windows.Forms.PictureBox()
        Me.pbDevice1 = New System.Windows.Forms.PictureBox()
        Me.tmrHotKey = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDrawText = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.cmsProfilesRC = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmProfileRCEditProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmProfilesRCSetProfileAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrLEDFlow = New System.Windows.Forms.Timer(Me.components)
        Me.tmrShowDevices = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.cmtTaskbar.SuspendLayout()
        Me.TSAutoProfiler.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbDevices.SuspendLayout()
        CType(Me.pbDevice8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDevice7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDevice6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDevice5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDPIMode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDevice4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDevice3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDevice2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDevice1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsProfilesRC.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdSettings
        '
        Me.cmdSettings.Location = New System.Drawing.Point(184, 126)
        Me.cmdSettings.Name = "cmdSettings"
        Me.cmdSettings.Size = New System.Drawing.Size(90, 23)
        Me.cmdSettings.TabIndex = 4
        Me.cmdSettings.Text = "Settings"
        Me.cmdSettings.UseVisualStyleBackColor = True
        '
        'cmdProfiles
        '
        Me.cmdProfiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdProfiles.Location = New System.Drawing.Point(184, 97)
        Me.cmdProfiles.Name = "cmdProfiles"
        Me.cmdProfiles.Size = New System.Drawing.Size(90, 23)
        Me.cmdProfiles.TabIndex = 5
        Me.cmdProfiles.Text = "Profiles Settings"
        Me.cmdProfiles.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblStatus)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(158, 45)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Status"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Red
        Me.lblStatus.Location = New System.Drawing.Point(6, 16)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(79, 20)
        Me.lblStatus.TabIndex = 7
        Me.lblStatus.Text = "Disabled"
        '
        'tmrAPCheck
        '
        Me.tmrAPCheck.Interval = 1000
        '
        'cmdED
        '
        Me.cmdED.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdED.Location = New System.Drawing.Point(184, 33)
        Me.cmdED.Name = "cmdED"
        Me.cmdED.Size = New System.Drawing.Size(90, 40)
        Me.cmdED.TabIndex = 8
        Me.cmdED.Text = "Enable"
        Me.cmdED.UseVisualStyleBackColor = True
        '
        'TaskIcon
        '
        Me.TaskIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.TaskIcon.ContextMenuStrip = Me.cmtTaskbar
        Me.TaskIcon.Icon = CType(resources.GetObject("TaskIcon.Icon"), System.Drawing.Icon)
        Me.TaskIcon.Text = "Cyborg Auto-Profiler"
        '
        'cmtTaskbar
        '
        Me.cmtTaskbar.BackgroundImage = Global.CyborgAutoProfiler.My.Resources.Resources.TaskMenu
        Me.cmtTaskbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmtTaskbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmED, Me.tsmHotKey, Me.tsmOpen, Me.tsmEditProfiles, Me.tsmSettings, Me.tsmProfiles, Me.tsmProfileEditor, Me.tsmExit})
        Me.cmtTaskbar.Name = "cmtTaskbar"
        Me.cmtTaskbar.ShowImageMargin = False
        Me.cmtTaskbar.Size = New System.Drawing.Size(202, 212)
        '
        'tsmED
        '
        Me.tsmED.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmED.ForeColor = System.Drawing.Color.Green
        Me.tsmED.Name = "tsmED"
        Me.tsmED.Size = New System.Drawing.Size(201, 26)
        Me.tsmED.Text = "          Enable"
        '
        'tsmHotKey
        '
        Me.tsmHotKey.ForeColor = System.Drawing.Color.Green
        Me.tsmHotKey.Name = "tsmHotKey"
        Me.tsmHotKey.Size = New System.Drawing.Size(201, 26)
        Me.tsmHotKey.Text = "              Enable Hot Key"
        '
        'tsmOpen
        '
        Me.tsmOpen.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmOpen.Name = "tsmOpen"
        Me.tsmOpen.Size = New System.Drawing.Size(201, 26)
        Me.tsmOpen.Text = "              Open"
        '
        'tsmEditProfiles
        '
        Me.tsmEditProfiles.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmEditProfiles.Name = "tsmEditProfiles"
        Me.tsmEditProfiles.Size = New System.Drawing.Size(201, 26)
        Me.tsmEditProfiles.Text = "              Edit Profile Settings"
        '
        'tsmSettings
        '
        Me.tsmSettings.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmSettings.Name = "tsmSettings"
        Me.tsmSettings.Size = New System.Drawing.Size(201, 26)
        Me.tsmSettings.Text = "              Settings"
        '
        'tsmProfiles
        '
        Me.tsmProfiles.DropDown = Me.cmsProfiles
        Me.tsmProfiles.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmProfiles.Name = "tsmProfiles"
        Me.tsmProfiles.Size = New System.Drawing.Size(201, 26)
        Me.tsmProfiles.Text = "              Profiles"
        '
        'cmsProfiles
        '
        Me.cmsProfiles.BackgroundImage = Global.CyborgAutoProfiler.My.Resources.Resources.TaskProfileNormal
        Me.cmsProfiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmsProfiles.ImageScalingSize = New System.Drawing.Size(45, 23)
        Me.cmsProfiles.Name = "cmsProfiles"
        Me.cmsProfiles.OwnerItem = Me.tsmProfiles
        Me.cmsProfiles.ShowImageMargin = False
        Me.cmsProfiles.Size = New System.Drawing.Size(36, 4)
        '
        'tsbProfiles
        '
        Me.tsbProfiles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbProfiles.DropDown = Me.cmsProfiles
        Me.tsbProfiles.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbProfiles.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbProfiles.Name = "tsbProfiles"
        Me.tsbProfiles.Size = New System.Drawing.Size(59, 22)
        Me.tsbProfiles.Text = "Profiles"
        Me.tsbProfiles.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'tsmProfileEditor
        '
        Me.tsmProfileEditor.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmProfileEditor.Name = "tsmProfileEditor"
        Me.tsmProfileEditor.Size = New System.Drawing.Size(201, 26)
        Me.tsmProfileEditor.Text = "              Profile Editor"
        '
        'tsmExit
        '
        Me.tsmExit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsmExit.Name = "tsmExit"
        Me.tsmExit.Size = New System.Drawing.Size(201, 26)
        Me.tsmExit.Text = "          Close"
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(184, 155)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(90, 23)
        Me.cmdExit.TabIndex = 9
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'TSAutoProfiler
        '
        Me.TSAutoProfiler.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TSAutoProfiler.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TScmdHelp, Me.ToolStripSeparator3, Me.TScmdAbout, Me.ToolStripSeparator2, Me.tsbWeb, Me.ToolStripSeparator1, Me.tsbProfiles, Me.ToolStripSeparator4, Me.tsbMMO7})
        Me.TSAutoProfiler.Location = New System.Drawing.Point(0, 0)
        Me.TSAutoProfiler.Name = "TSAutoProfiler"
        Me.TSAutoProfiler.Padding = New System.Windows.Forms.Padding(0)
        Me.TSAutoProfiler.ShowItemToolTips = False
        Me.TSAutoProfiler.Size = New System.Drawing.Size(278, 25)
        Me.TSAutoProfiler.TabIndex = 10
        '
        'TScmdHelp
        '
        Me.TScmdHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.TScmdHelp.Image = CType(resources.GetObject("TScmdHelp.Image"), System.Drawing.Image)
        Me.TScmdHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TScmdHelp.Name = "TScmdHelp"
        Me.TScmdHelp.Size = New System.Drawing.Size(36, 22)
        Me.TScmdHelp.Text = "Help"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'TScmdAbout
        '
        Me.TScmdAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.TScmdAbout.Image = CType(resources.GetObject("TScmdAbout.Image"), System.Drawing.Image)
        Me.TScmdAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TScmdAbout.Name = "TScmdAbout"
        Me.TScmdAbout.Size = New System.Drawing.Size(44, 22)
        Me.TScmdAbout.Text = "About"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsbWeb
        '
        Me.tsbWeb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbWeb.Image = CType(resources.GetObject("tsbWeb.Image"), System.Drawing.Image)
        Me.tsbWeb.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbWeb.Name = "tsbWeb"
        Me.tsbWeb.Size = New System.Drawing.Size(53, 22)
        Me.tsbWeb.Text = "Website"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'tsbMMO7
        '
        Me.tsbMMO7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbMMO7.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiMMO7FlowSettings, Me.tsmiMMO7FlowToggle})
        Me.tsbMMO7.Image = CType(resources.GetObject("tsbMMO7.Image"), System.Drawing.Image)
        Me.tsbMMO7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbMMO7.Name = "tsbMMO7"
        Me.tsbMMO7.Size = New System.Drawing.Size(57, 22)
        Me.tsbMMO7.Text = "MMO7"
        Me.tsbMMO7.Visible = False
        '
        'tsmiMMO7FlowSettings
        '
        Me.tsmiMMO7FlowSettings.BackgroundImage = Global.CyborgAutoProfiler.My.Resources.Resources.TaskProfileNormal
        Me.tsmiMMO7FlowSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tsmiMMO7FlowSettings.Name = "tsmiMMO7FlowSettings"
        Me.tsmiMMO7FlowSettings.Size = New System.Drawing.Size(231, 22)
        Me.tsmiMMO7FlowSettings.Text = "        MMO7 LED Flow Settings"
        '
        'tsmiMMO7FlowToggle
        '
        Me.tsmiMMO7FlowToggle.BackgroundImage = Global.CyborgAutoProfiler.My.Resources.Resources.TaskProfileNormal
        Me.tsmiMMO7FlowToggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tsmiMMO7FlowToggle.Name = "tsmiMMO7FlowToggle"
        Me.tsmiMMO7FlowToggle.Size = New System.Drawing.Size(231, 22)
        Me.tsmiMMO7FlowToggle.Text = "        Enable MMO7 LED Flow"
        '
        'tmrMinimize
        '
        Me.tmrMinimize.Interval = 50
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblCP)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 79)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(158, 40)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Current Profile"
        '
        'lblCP
        '
        Me.lblCP.AutoSize = True
        Me.lblCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCP.Location = New System.Drawing.Point(6, 16)
        Me.lblCP.Name = "lblCP"
        Me.lblCP.Size = New System.Drawing.Size(51, 20)
        Me.lblCP.TabIndex = 8
        Me.lblCP.Text = "None"
        Me.lblCP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbDevices
        '
        Me.gbDevices.Controls.Add(Me.lblFindDevices)
        Me.gbDevices.Controls.Add(Me.lblDeviceCount)
        Me.gbDevices.Controls.Add(Me.pbDevice8)
        Me.gbDevices.Controls.Add(Me.pbDevice7)
        Me.gbDevices.Controls.Add(Me.pbDevice6)
        Me.gbDevices.Controls.Add(Me.pbDevice5)
        Me.gbDevices.Controls.Add(Me.pbDPIMode)
        Me.gbDevices.Controls.Add(Me.pbDevice4)
        Me.gbDevices.Controls.Add(Me.pbDevice3)
        Me.gbDevices.Controls.Add(Me.pbDevice2)
        Me.gbDevices.Controls.Add(Me.pbDevice1)
        Me.gbDevices.Location = New System.Drawing.Point(12, 121)
        Me.gbDevices.Name = "gbDevices"
        Me.gbDevices.Size = New System.Drawing.Size(158, 58)
        Me.gbDevices.TabIndex = 12
        Me.gbDevices.TabStop = False
        Me.gbDevices.Text = "Devices"
        '
        'lblFindDevices
        '
        Me.lblFindDevices.AutoSize = True
        Me.lblFindDevices.BackColor = System.Drawing.Color.Transparent
        Me.lblFindDevices.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFindDevices.Location = New System.Drawing.Point(6, 16)
        Me.lblFindDevices.Name = "lblFindDevices"
        Me.lblFindDevices.Size = New System.Drawing.Size(136, 20)
        Me.lblFindDevices.TabIndex = 21
        Me.lblFindDevices.Text = "Finding Devices"
        Me.lblFindDevices.Visible = False
        '
        'lblDeviceCount
        '
        Me.lblDeviceCount.AutoSize = True
        Me.lblDeviceCount.BackColor = System.Drawing.Color.Transparent
        Me.lblDeviceCount.Location = New System.Drawing.Point(145, 1)
        Me.lblDeviceCount.Name = "lblDeviceCount"
        Me.lblDeviceCount.Size = New System.Drawing.Size(13, 13)
        Me.lblDeviceCount.TabIndex = 15
        Me.lblDeviceCount.Text = "0"
        Me.lblDeviceCount.Visible = False
        '
        'pbDevice8
        '
        Me.pbDevice8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbDevice8.Location = New System.Drawing.Point(120, 61)
        Me.pbDevice8.Name = "pbDevice8"
        Me.pbDevice8.Size = New System.Drawing.Size(32, 32)
        Me.pbDevice8.TabIndex = 20
        Me.pbDevice8.TabStop = False
        '
        'pbDevice7
        '
        Me.pbDevice7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbDevice7.Location = New System.Drawing.Point(82, 61)
        Me.pbDevice7.Name = "pbDevice7"
        Me.pbDevice7.Size = New System.Drawing.Size(32, 32)
        Me.pbDevice7.TabIndex = 19
        Me.pbDevice7.TabStop = False
        '
        'pbDevice6
        '
        Me.pbDevice6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbDevice6.Location = New System.Drawing.Point(44, 61)
        Me.pbDevice6.Name = "pbDevice6"
        Me.pbDevice6.Size = New System.Drawing.Size(32, 32)
        Me.pbDevice6.TabIndex = 18
        Me.pbDevice6.TabStop = False
        '
        'pbDevice5
        '
        Me.pbDevice5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbDevice5.Location = New System.Drawing.Point(6, 61)
        Me.pbDevice5.Name = "pbDevice5"
        Me.pbDevice5.Size = New System.Drawing.Size(32, 32)
        Me.pbDevice5.TabIndex = 17
        Me.pbDevice5.TabStop = False
        '
        'pbDPIMode
        '
        Me.pbDPIMode.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.pbDPIMode.Image = Global.CyborgAutoProfiler.My.Resources.Resources.DPIMode0
        Me.pbDPIMode.Location = New System.Drawing.Point(6, 14)
        Me.pbDPIMode.Name = "pbDPIMode"
        Me.pbDPIMode.Size = New System.Drawing.Size(9, 43)
        Me.pbDPIMode.TabIndex = 16
        Me.pbDPIMode.TabStop = False
        Me.pbDPIMode.Visible = False
        '
        'pbDevice4
        '
        Me.pbDevice4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbDevice4.Location = New System.Drawing.Point(120, 16)
        Me.pbDevice4.Name = "pbDevice4"
        Me.pbDevice4.Size = New System.Drawing.Size(32, 32)
        Me.pbDevice4.TabIndex = 3
        Me.pbDevice4.TabStop = False
        '
        'pbDevice3
        '
        Me.pbDevice3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbDevice3.Location = New System.Drawing.Point(82, 16)
        Me.pbDevice3.Name = "pbDevice3"
        Me.pbDevice3.Size = New System.Drawing.Size(32, 32)
        Me.pbDevice3.TabIndex = 2
        Me.pbDevice3.TabStop = False
        '
        'pbDevice2
        '
        Me.pbDevice2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbDevice2.Location = New System.Drawing.Point(44, 16)
        Me.pbDevice2.Name = "pbDevice2"
        Me.pbDevice2.Size = New System.Drawing.Size(32, 32)
        Me.pbDevice2.TabIndex = 1
        Me.pbDevice2.TabStop = False
        '
        'pbDevice1
        '
        Me.pbDevice1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbDevice1.Location = New System.Drawing.Point(6, 16)
        Me.pbDevice1.Name = "pbDevice1"
        Me.pbDevice1.Size = New System.Drawing.Size(32, 32)
        Me.pbDevice1.TabIndex = 0
        Me.pbDevice1.TabStop = False
        '
        'tmrHotKey
        '
        Me.tmrHotKey.Interval = 350
        '
        'tmrDrawText
        '
        Me.tmrDrawText.Enabled = True
        Me.tmrDrawText.Interval = 25
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 91)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(11, 28)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(165, 91)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(11, 28)
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'cmsProfilesRC
        '
        Me.cmsProfilesRC.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmProfileRCEditProfile, Me.tsmProfilesRCSetProfileAll})
        Me.cmsProfilesRC.Name = "cmsProfilesRC"
        Me.cmsProfilesRC.Size = New System.Drawing.Size(132, 48)
        '
        'tsmProfileRCEditProfile
        '
        Me.tsmProfileRCEditProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tsmProfileRCEditProfile.Name = "tsmProfileRCEditProfile"
        Me.tsmProfileRCEditProfile.Size = New System.Drawing.Size(131, 22)
        Me.tsmProfileRCEditProfile.Text = "Edit Profile"
        Me.tsmProfileRCEditProfile.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tsmProfilesRCSetProfileAll
        '
        Me.tsmProfilesRCSetProfileAll.Name = "tsmProfilesRCSetProfileAll"
        Me.tsmProfilesRCSetProfileAll.Size = New System.Drawing.Size(131, 22)
        Me.tsmProfilesRCSetProfileAll.Visible = False
        '
        'tmrLEDFlow
        '
        Me.tmrLEDFlow.Interval = 1
        '
        'tmrShowDevices
        '
        Me.tmrShowDevices.Enabled = True
        Me.tmrShowDevices.Interval = 1000
        '
        'frmAutoProfiler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(278, 185)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.gbDevices)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TSAutoProfiler)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdED)
        Me.Controls.Add(Me.cmdProfiles)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdSettings)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAutoProfiler"
        Me.Text = "Cyborg Auto-Profiler"
        Me.TransparencyKey = System.Drawing.Color.Pink
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.cmtTaskbar.ResumeLayout(False)
        Me.TSAutoProfiler.ResumeLayout(False)
        Me.TSAutoProfiler.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbDevices.ResumeLayout(False)
        Me.gbDevices.PerformLayout()
        CType(Me.pbDevice8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDevice7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDevice6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDevice5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDPIMode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDevice4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDevice3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDevice2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDevice1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsProfilesRC.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdSettings As System.Windows.Forms.Button
    Friend WithEvents cmdProfiles As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents tmrAPCheck As System.Windows.Forms.Timer
    Friend WithEvents cmdED As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents TSAutoProfiler As System.Windows.Forms.ToolStrip
    Friend WithEvents TScmdHelp As System.Windows.Forms.ToolStripButton
    Friend WithEvents TScmdAbout As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmtTaskbar As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TaskIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents tsmED As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrMinimize As System.Windows.Forms.Timer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCP As System.Windows.Forms.Label
    Friend WithEvents tsbWeb As System.Windows.Forms.ToolStripButton
    Friend WithEvents gbDevices As System.Windows.Forms.GroupBox
    Friend WithEvents pbDevice4 As System.Windows.Forms.PictureBox
    Friend WithEvents pbDevice3 As System.Windows.Forms.PictureBox
    Friend WithEvents pbDevice2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbDevice1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbDPIMode As System.Windows.Forms.PictureBox
    Friend WithEvents pbDevice8 As System.Windows.Forms.PictureBox
    Friend WithEvents pbDevice7 As System.Windows.Forms.PictureBox
    Friend WithEvents pbDevice6 As System.Windows.Forms.PictureBox
    Friend WithEvents pbDevice5 As System.Windows.Forms.PictureBox
    Friend WithEvents tsmProfiles As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbProfiles As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tsmProfileEditor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmEditProfiles As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrHotKey As System.Windows.Forms.Timer
    Friend WithEvents tsmHotKey As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsProfiles As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tmrDrawText As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblDeviceCount As System.Windows.Forms.Label
    Friend WithEvents cmsProfilesRC As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmProfileRCEditProfile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmProfilesRCSetProfileAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tmrLEDFlow As System.Windows.Forms.Timer
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbMMO7 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tsmiMMO7FlowSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiMMO7FlowToggle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrShowDevices As System.Windows.Forms.Timer
    Friend WithEvents lblFindDevices As System.Windows.Forms.Label

End Class
