<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDebug
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDebug))
        Me.txtDebug = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'txtDebug
        '
        Me.txtDebug.Location = New System.Drawing.Point(1, 1)
        Me.txtDebug.Name = "txtDebug"
        Me.txtDebug.ReadOnly = True
        Me.txtDebug.Size = New System.Drawing.Size(588, 556)
        Me.txtDebug.TabIndex = 0
        Me.txtDebug.Text = ""
        '
        'frmDebug
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 569)
        Me.Controls.Add(Me.txtDebug)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDebug"
        Me.Text = "frmDebug"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtDebug As System.Windows.Forms.RichTextBox
End Class
