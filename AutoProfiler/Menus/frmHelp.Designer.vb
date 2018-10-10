<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHelp))
        Me.rtbReadMe = New System.Windows.Forms.RichTextBox()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rtbReadMe
        '
        Me.rtbReadMe.Location = New System.Drawing.Point(0, 0)
        Me.rtbReadMe.Name = "rtbReadMe"
        Me.rtbReadMe.ReadOnly = True
        Me.rtbReadMe.Size = New System.Drawing.Size(824, 530)
        Me.rtbReadMe.TabIndex = 0
        Me.rtbReadMe.Text = "README"
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(0, 536)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(824, 23)
        Me.cmdExit.TabIndex = 1
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'frmHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(824, 562)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.rtbReadMe)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHelp"
        Me.Text = "Cyborg Auto-Profiler - Help"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtbReadMe As System.Windows.Forms.RichTextBox
    Friend WithEvents cmdExit As System.Windows.Forms.Button
End Class
