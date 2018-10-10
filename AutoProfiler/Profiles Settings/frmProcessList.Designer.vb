<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProcessList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProcessList))
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSelect = New System.Windows.Forms.Button()
        Me.lstProcesses = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(5, 273)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(117, 23)
        Me.cmdCancel.TabIndex = 0
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdSelect
        '
        Me.cmdSelect.Location = New System.Drawing.Point(128, 273)
        Me.cmdSelect.Name = "cmdSelect"
        Me.cmdSelect.Size = New System.Drawing.Size(117, 23)
        Me.cmdSelect.TabIndex = 1
        Me.cmdSelect.Text = "Select"
        Me.cmdSelect.UseVisualStyleBackColor = True
        '
        'lstProcesses
        '
        Me.lstProcesses.FormattingEnabled = True
        Me.lstProcesses.Location = New System.Drawing.Point(5, 3)
        Me.lstProcesses.Name = "lstProcesses"
        Me.lstProcesses.Size = New System.Drawing.Size(240, 264)
        Me.lstProcesses.TabIndex = 2
        '
        'frmProcessList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(250, 299)
        Me.ControlBox = False
        Me.Controls.Add(Me.lstProcesses)
        Me.Controls.Add(Me.cmdSelect)
        Me.Controls.Add(Me.cmdCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmProcessList"
        Me.ShowInTaskbar = False
        Me.Text = "Cyborg Auto-Profiler - Process List"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdSelect As System.Windows.Forms.Button
    Friend WithEvents lstProcesses As System.Windows.Forms.ListBox
End Class
