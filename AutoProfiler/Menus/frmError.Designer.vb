<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmError
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmError))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblErr = New System.Windows.Forms.Label()
        Me.rtbErr = New System.Windows.Forms.RichTextBox()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox2.Location = New System.Drawing.Point(-6, -4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(447, 101)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'lblErr
        '
        Me.lblErr.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblErr.Location = New System.Drawing.Point(59, 12)
        Me.lblErr.Name = "lblErr"
        Me.lblErr.Size = New System.Drawing.Size(360, 75)
        Me.lblErr.TabIndex = 2
        Me.lblErr.Text = "Error finding Devices! Error occurred at line: "" & Err.Erl & "". Error Description" & _
    ": "" & Err.Description & "" Please report this to CyborgAutoProfiler@gmail.com and" & _
    " include the devices you have."
        Me.lblErr.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'rtbErr
        '
        Me.rtbErr.Location = New System.Drawing.Point(4, 103)
        Me.rtbErr.Name = "rtbErr"
        Me.rtbErr.ReadOnly = True
        Me.rtbErr.Size = New System.Drawing.Size(425, 94)
        Me.rtbErr.TabIndex = 3
        Me.rtbErr.Text = ""
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(354, 203)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 23)
        Me.cmdOk.TabIndex = 4
        Me.cmdOk.Text = "Continue"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(274, 203)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(74, 23)
        Me.cmdExit.TabIndex = 5
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'frmError
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(432, 232)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.rtbErr)
        Me.Controls.Add(Me.lblErr)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmError"
        Me.Text = "Cyborg Auto-Profiler - Error!"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblErr As System.Windows.Forms.Label
    Friend WithEvents rtbErr As System.Windows.Forms.RichTextBox
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
End Class
