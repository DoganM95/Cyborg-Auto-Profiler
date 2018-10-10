<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPickColor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPickColor))
        Me.pbSwatch = New System.Windows.Forms.PictureBox()
        Me.pbColor = New System.Windows.Forms.PictureBox()
        Me.hsbR = New System.Windows.Forms.HScrollBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.hsbB = New System.Windows.Forms.HScrollBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblG = New System.Windows.Forms.Label()
        Me.hsbG = New System.Windows.Forms.HScrollBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblR = New System.Windows.Forms.Label()
        Me.pbMMO7 = New System.Windows.Forms.PictureBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSet = New System.Windows.Forms.Button()
        Me.chkP = New System.Windows.Forms.CheckBox()
        CType(Me.pbSwatch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbColor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbMMO7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbSwatch
        '
        Me.pbSwatch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbSwatch.Image = Global.CyborgAutoProfiler.My.Resources.Resources.Swatch
        Me.pbSwatch.Location = New System.Drawing.Point(8, 8)
        Me.pbSwatch.Name = "pbSwatch"
        Me.pbSwatch.Size = New System.Drawing.Size(391, 214)
        Me.pbSwatch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbSwatch.TabIndex = 0
        Me.pbSwatch.TabStop = False
        '
        'pbColor
        '
        Me.pbColor.BackColor = System.Drawing.Color.Black
        Me.pbColor.Location = New System.Drawing.Point(405, 190)
        Me.pbColor.Name = "pbColor"
        Me.pbColor.Size = New System.Drawing.Size(32, 32)
        Me.pbColor.TabIndex = 1
        Me.pbColor.TabStop = False
        '
        'hsbR
        '
        Me.hsbR.LargeChange = 1
        Me.hsbR.Location = New System.Drawing.Point(67, 16)
        Me.hsbR.Maximum = 255
        Me.hsbR.Name = "hsbR"
        Me.hsbR.Size = New System.Drawing.Size(173, 31)
        Me.hsbR.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblB)
        Me.GroupBox1.Controls.Add(Me.hsbB)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblG)
        Me.GroupBox1.Controls.Add(Me.hsbG)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblR)
        Me.GroupBox1.Controls.Add(Me.hsbR)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 228)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 150)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "RGB"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Blue"
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB.Location = New System.Drawing.Point(245, 122)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(19, 20)
        Me.lblB.TabIndex = 9
        Me.lblB.Text = "0"
        '
        'hsbB
        '
        Me.hsbB.LargeChange = 1
        Me.hsbB.Location = New System.Drawing.Point(67, 116)
        Me.hsbB.Maximum = 255
        Me.hsbB.Name = "hsbB"
        Me.hsbB.Size = New System.Drawing.Size(173, 31)
        Me.hsbB.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Green"
        '
        'lblG
        '
        Me.lblG.AutoSize = True
        Me.lblG.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblG.Location = New System.Drawing.Point(245, 70)
        Me.lblG.Name = "lblG"
        Me.lblG.Size = New System.Drawing.Size(19, 20)
        Me.lblG.TabIndex = 6
        Me.lblG.Text = "0"
        '
        'hsbG
        '
        Me.hsbG.LargeChange = 1
        Me.hsbG.Location = New System.Drawing.Point(67, 64)
        Me.hsbG.Maximum = 255
        Me.hsbG.Name = "hsbG"
        Me.hsbG.Size = New System.Drawing.Size(173, 31)
        Me.hsbG.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Red"
        '
        'lblR
        '
        Me.lblR.AutoSize = True
        Me.lblR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblR.Location = New System.Drawing.Point(245, 22)
        Me.lblR.Name = "lblR"
        Me.lblR.Size = New System.Drawing.Size(19, 20)
        Me.lblR.TabIndex = 3
        Me.lblR.Text = "0"
        '
        'pbMMO7
        '
        Me.pbMMO7.BackColor = System.Drawing.Color.Black
        Me.pbMMO7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbMMO7.Image = Global.CyborgAutoProfiler.My.Resources.Resources.MMO7LED
        Me.pbMMO7.Location = New System.Drawing.Point(405, 9)
        Me.pbMMO7.Name = "pbMMO7"
        Me.pbMMO7.Size = New System.Drawing.Size(182, 213)
        Me.pbMMO7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbMMO7.TabIndex = 46
        Me.pbMMO7.TabStop = False
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(314, 355)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(264, 23)
        Me.cmdCancel.TabIndex = 47
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdSet
        '
        Me.cmdSet.Location = New System.Drawing.Point(314, 326)
        Me.cmdSet.Name = "cmdSet"
        Me.cmdSet.Size = New System.Drawing.Size(264, 23)
        Me.cmdSet.TabIndex = 48
        Me.cmdSet.Text = "Set Color"
        Me.cmdSet.UseVisualStyleBackColor = True
        '
        'chkP
        '
        Me.chkP.AutoSize = True
        Me.chkP.Location = New System.Drawing.Point(314, 244)
        Me.chkP.Name = "chkP"
        Me.chkP.Size = New System.Drawing.Size(108, 17)
        Me.chkP.TabIndex = 49
        Me.chkP.Text = "Use Percentages"
        Me.chkP.UseVisualStyleBackColor = True
        '
        'frmPickColor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(590, 390)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkP)
        Me.Controls.Add(Me.cmdSet)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pbColor)
        Me.Controls.Add(Me.pbMMO7)
        Me.Controls.Add(Me.pbSwatch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmPickColor"
        Me.Text = "Color Dialog"
        CType(Me.pbSwatch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbColor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbMMO7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbSwatch As System.Windows.Forms.PictureBox
    Friend WithEvents pbColor As System.Windows.Forms.PictureBox
    Friend WithEvents hsbR As System.Windows.Forms.HScrollBar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblR As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblB As System.Windows.Forms.Label
    Friend WithEvents hsbB As System.Windows.Forms.HScrollBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblG As System.Windows.Forms.Label
    Friend WithEvents hsbG As System.Windows.Forms.HScrollBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pbMMO7 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdSet As System.Windows.Forms.Button
    Friend WithEvents chkP As System.Windows.Forms.CheckBox
End Class
