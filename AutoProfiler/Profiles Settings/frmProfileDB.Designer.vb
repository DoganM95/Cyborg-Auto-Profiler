<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProfileDB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProfileDB))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstCategorys = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lstProfiles = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lstDevices = New System.Windows.Forms.ListBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rtbDescription = New System.Windows.Forms.RichTextBox()
        Me.wbReadURL = New System.Windows.Forms.WebBrowser()
        Me.cmdDownload = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstCategorys)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(174, 194)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Categorys"
        '
        'lstCategorys
        '
        Me.lstCategorys.FormattingEnabled = True
        Me.lstCategorys.Items.AddRange(New Object() {"FPS", "Action", "M.M.O.", "RPG", "Stratagy", "Software"})
        Me.lstCategorys.Location = New System.Drawing.Point(7, 20)
        Me.lstCategorys.Name = "lstCategorys"
        Me.lstCategorys.Size = New System.Drawing.Size(161, 160)
        Me.lstCategorys.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstProfiles)
        Me.GroupBox2.Location = New System.Drawing.Point(192, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 194)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Profiles"
        '
        'lstProfiles
        '
        Me.lstProfiles.Enabled = False
        Me.lstProfiles.FormattingEnabled = True
        Me.lstProfiles.Location = New System.Drawing.Point(7, 20)
        Me.lstProfiles.Name = "lstProfiles"
        Me.lstProfiles.Size = New System.Drawing.Size(187, 160)
        Me.lstProfiles.Sorted = True
        Me.lstProfiles.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lstDevices)
        Me.GroupBox3.Location = New System.Drawing.Point(398, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(156, 101)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Supported Devices"
        '
        'lstDevices
        '
        Me.lstDevices.FormattingEnabled = True
        Me.lstDevices.Location = New System.Drawing.Point(7, 20)
        Me.lstDevices.Name = "lstDevices"
        Me.lstDevices.Size = New System.Drawing.Size(143, 69)
        Me.lstDevices.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rtbDescription)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 213)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(542, 157)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Description"
        '
        'rtbDescription
        '
        Me.rtbDescription.Location = New System.Drawing.Point(7, 20)
        Me.rtbDescription.Name = "rtbDescription"
        Me.rtbDescription.ReadOnly = True
        Me.rtbDescription.Size = New System.Drawing.Size(529, 131)
        Me.rtbDescription.TabIndex = 0
        Me.rtbDescription.Text = ""
        '
        'wbReadURL
        '
        Me.wbReadURL.Location = New System.Drawing.Point(571, 22)
        Me.wbReadURL.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbReadURL.Name = "wbReadURL"
        Me.wbReadURL.Size = New System.Drawing.Size(20, 20)
        Me.wbReadURL.TabIndex = 14
        Me.wbReadURL.Url = New System.Uri("", System.UriKind.Relative)
        Me.wbReadURL.Visible = False
        '
        'cmdDownload
        '
        Me.cmdDownload.Location = New System.Drawing.Point(405, 119)
        Me.cmdDownload.Name = "cmdDownload"
        Me.cmdDownload.Size = New System.Drawing.Size(143, 87)
        Me.cmdDownload.TabIndex = 15
        Me.cmdDownload.Text = "Download Profile"
        Me.cmdDownload.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(479, 376)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 16
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'frmProfileDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(560, 402)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdDownload)
        Me.Controls.Add(Me.wbReadURL)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProfileDB"
        Me.Text = "Cyborg Auto-Profiler - Download Profiles"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstCategorys As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lstProfiles As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lstDevices As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rtbDescription As System.Windows.Forms.RichTextBox
    Friend WithEvents wbReadURL As System.Windows.Forms.WebBrowser
    Friend WithEvents cmdDownload As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
End Class
