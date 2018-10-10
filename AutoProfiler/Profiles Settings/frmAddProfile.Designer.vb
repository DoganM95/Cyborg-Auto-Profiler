<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddProfile
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
        Me.cmdCancelAdd = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cbProfiles = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cmdCancelAdd
        '
        Me.cmdCancelAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelAdd.Location = New System.Drawing.Point(12, 39)
        Me.cmdCancelAdd.Name = "cmdCancelAdd"
        Me.cmdCancelAdd.Size = New System.Drawing.Size(167, 23)
        Me.cmdCancelAdd.TabIndex = 5
        Me.cmdCancelAdd.Text = "Cancel"
        Me.cmdCancelAdd.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Enabled = False
        Me.cmdAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Location = New System.Drawing.Point(182, 39)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(167, 23)
        Me.cmdAdd.TabIndex = 4
        Me.cmdAdd.Text = "Add Profile"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cbProfiles
        '
        Me.cbProfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProfiles.FormattingEnabled = True
        Me.cbProfiles.Location = New System.Drawing.Point(12, 12)
        Me.cbProfiles.Name = "cbProfiles"
        Me.cbProfiles.Size = New System.Drawing.Size(337, 21)
        Me.cbProfiles.TabIndex = 2
        '
        'frmAddProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(358, 69)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdCancelAdd)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cbProfiles)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddProfile"
        Me.ShowInTaskbar = False
        Me.Text = "Cyborg Auto-Profiler - Profile Selection"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdCancelAdd As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cbProfiles As System.Windows.Forms.ComboBox
End Class
