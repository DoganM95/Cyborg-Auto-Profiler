<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdvProcessInput
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdvProcessInput))
        Me.txtProcess = New System.Windows.Forms.TextBox()
        Me.txtProcessTitle = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gbWindowTitle = New System.Windows.Forms.GroupBox()
        Me.lstProcesses = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.pbSpy = New System.Windows.Forms.PictureBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lstWindowTitles = New System.Windows.Forms.ListBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdAddP = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.gbWindowTitle.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.pbSpy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtProcess
        '
        Me.txtProcess.Location = New System.Drawing.Point(10, 18)
        Me.txtProcess.Name = "txtProcess"
        Me.txtProcess.Size = New System.Drawing.Size(152, 20)
        Me.txtProcess.TabIndex = 0
        '
        'txtProcessTitle
        '
        Me.txtProcessTitle.Location = New System.Drawing.Point(6, 19)
        Me.txtProcessTitle.Name = "txtProcessTitle"
        Me.txtProcessTitle.Size = New System.Drawing.Size(232, 20)
        Me.txtProcessTitle.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtProcess)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 302)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(168, 44)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Process Name"
        '
        'gbWindowTitle
        '
        Me.gbWindowTitle.Controls.Add(Me.txtProcessTitle)
        Me.gbWindowTitle.Location = New System.Drawing.Point(185, 302)
        Me.gbWindowTitle.Name = "gbWindowTitle"
        Me.gbWindowTitle.Size = New System.Drawing.Size(244, 44)
        Me.gbWindowTitle.TabIndex = 3
        Me.gbWindowTitle.TabStop = False
        Me.gbWindowTitle.Text = "Process Window Title"
        '
        'lstProcesses
        '
        Me.lstProcesses.FormattingEnabled = True
        Me.lstProcesses.Location = New System.Drawing.Point(6, 19)
        Me.lstProcesses.Name = "lstProcesses"
        Me.lstProcesses.Size = New System.Drawing.Size(156, 264)
        Me.lstProcesses.TabIndex = 4
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.pbSpy)
        Me.GroupBox3.Controls.Add(Me.lstProcesses)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(171, 296)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "List of Processes with Titles"
        '
        'pbSpy
        '
        Me.pbSpy.BackColor = System.Drawing.Color.Transparent
        Me.pbSpy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbSpy.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbSpy.ErrorImage = Nothing
        Me.pbSpy.Image = CType(resources.GetObject("pbSpy.Image"), System.Drawing.Image)
        Me.pbSpy.InitialImage = Nothing
        Me.pbSpy.Location = New System.Drawing.Point(130, 251)
        Me.pbSpy.Name = "pbSpy"
        Me.pbSpy.Size = New System.Drawing.Size(32, 32)
        Me.pbSpy.TabIndex = 9
        Me.pbSpy.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lstWindowTitles)
        Me.GroupBox4.Location = New System.Drawing.Point(185, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(244, 296)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Process Active Window Titles"
        '
        'lstWindowTitles
        '
        Me.lstWindowTitles.Enabled = False
        Me.lstWindowTitles.FormattingEnabled = True
        Me.lstWindowTitles.Location = New System.Drawing.Point(6, 18)
        Me.lstWindowTitles.Name = "lstWindowTitles"
        Me.lstWindowTitles.Size = New System.Drawing.Size(232, 264)
        Me.lstWindowTitles.TabIndex = 0
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(14, 352)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(200, 23)
        Me.cmdCancel.TabIndex = 6
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdAddP
        '
        Me.cmdAddP.Location = New System.Drawing.Point(223, 352)
        Me.cmdAddP.Name = "cmdAddP"
        Me.cmdAddP.Size = New System.Drawing.Size(200, 23)
        Me.cmdAddP.TabIndex = 8
        Me.cmdAddP.Text = "Add Process"
        Me.cmdAddP.UseVisualStyleBackColor = True
        '
        'frmAdvProcessInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(434, 380)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdAddP)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.gbWindowTitle)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAdvProcessInput"
        Me.ShowInTaskbar = False
        Me.Text = "Cyborg Auto-Profiler - Advanced Process Input"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbWindowTitle.ResumeLayout(False)
        Me.gbWindowTitle.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.pbSpy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtProcess As System.Windows.Forms.TextBox
    Friend WithEvents txtProcessTitle As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gbWindowTitle As System.Windows.Forms.GroupBox
    Friend WithEvents lstProcesses As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lstWindowTitles As System.Windows.Forms.ListBox
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdAddP As System.Windows.Forms.Button
    Friend WithEvents pbSpy As System.Windows.Forms.PictureBox
End Class
