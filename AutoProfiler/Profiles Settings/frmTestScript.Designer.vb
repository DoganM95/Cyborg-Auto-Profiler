<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTestScript
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTestScript))
        Me.cbScript = New System.Windows.Forms.ComboBox()
        Me.cmdTestScript = New System.Windows.Forms.Button()
        Me.rbLoadProfile = New System.Windows.Forms.RadioButton()
        Me.rbUnloadProfile = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'cbScript
        '
        Me.cbScript.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbScript.Enabled = False
        Me.cbScript.FormattingEnabled = True
        Me.cbScript.Location = New System.Drawing.Point(12, 12)
        Me.cbScript.MaxDropDownItems = 100
        Me.cbScript.Name = "cbScript"
        Me.cbScript.Size = New System.Drawing.Size(220, 21)
        Me.cbScript.TabIndex = 1
        '
        'cmdTestScript
        '
        Me.cmdTestScript.Location = New System.Drawing.Point(12, 62)
        Me.cmdTestScript.Name = "cmdTestScript"
        Me.cmdTestScript.Size = New System.Drawing.Size(220, 23)
        Me.cmdTestScript.TabIndex = 2
        Me.cmdTestScript.Text = "Test Script"
        Me.cmdTestScript.UseVisualStyleBackColor = True
        '
        'rbLoadProfile
        '
        Me.rbLoadProfile.AutoSize = True
        Me.rbLoadProfile.Checked = True
        Me.rbLoadProfile.Location = New System.Drawing.Point(12, 39)
        Me.rbLoadProfile.Name = "rbLoadProfile"
        Me.rbLoadProfile.Size = New System.Drawing.Size(78, 17)
        Me.rbLoadProfile.TabIndex = 3
        Me.rbLoadProfile.TabStop = True
        Me.rbLoadProfile.Text = "LoadProfile"
        Me.rbLoadProfile.UseVisualStyleBackColor = True
        '
        'rbUnloadProfile
        '
        Me.rbUnloadProfile.AutoSize = True
        Me.rbUnloadProfile.Location = New System.Drawing.Point(108, 39)
        Me.rbUnloadProfile.Name = "rbUnloadProfile"
        Me.rbUnloadProfile.Size = New System.Drawing.Size(88, 17)
        Me.rbUnloadProfile.TabIndex = 4
        Me.rbUnloadProfile.Text = "UnloadProfile"
        Me.rbUnloadProfile.UseVisualStyleBackColor = True
        '
        'frmTestScript
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(241, 87)
        Me.Controls.Add(Me.rbUnloadProfile)
        Me.Controls.Add(Me.rbLoadProfile)
        Me.Controls.Add(Me.cmdTestScript)
        Me.Controls.Add(Me.cbScript)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTestScript"
        Me.Text = "Cyborg Auto-Profiler - Test Script"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbScript As System.Windows.Forms.ComboBox
    Friend WithEvents cmdTestScript As System.Windows.Forms.Button
    Friend WithEvents rbLoadProfile As System.Windows.Forms.RadioButton
    Friend WithEvents rbUnloadProfile As System.Windows.Forms.RadioButton
End Class
