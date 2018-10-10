<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMMO7LEDFlow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMMO7LEDFlow))
        Me.tbColorCount = New System.Windows.Forms.TrackBar()
        Me.pbCP1 = New System.Windows.Forms.PictureBox()
        Me.chkRandom = New System.Windows.Forms.CheckBox()
        Me.cmdPC1 = New System.Windows.Forms.Button()
        Me.CD = New System.Windows.Forms.ColorDialog()
        Me.cmdPC2 = New System.Windows.Forms.Button()
        Me.pbCP2 = New System.Windows.Forms.PictureBox()
        Me.cmdPC3 = New System.Windows.Forms.Button()
        Me.pbCP3 = New System.Windows.Forms.PictureBox()
        Me.cmdPC4 = New System.Windows.Forms.Button()
        Me.pbCP4 = New System.Windows.Forms.PictureBox()
        Me.cmdPC5 = New System.Windows.Forms.Button()
        Me.pbCP5 = New System.Windows.Forms.PictureBox()
        Me.cmdPC6 = New System.Windows.Forms.Button()
        Me.pbCP6 = New System.Windows.Forms.PictureBox()
        Me.cmdPC7 = New System.Windows.Forms.Button()
        Me.pbCP7 = New System.Windows.Forms.PictureBox()
        Me.cmdPC8 = New System.Windows.Forms.Button()
        Me.pbCP8 = New System.Windows.Forms.PictureBox()
        Me.cmdPC9 = New System.Windows.Forms.Button()
        Me.pbCP9 = New System.Windows.Forms.PictureBox()
        Me.cmdPC10 = New System.Windows.Forms.Button()
        Me.pbCP10 = New System.Windows.Forms.PictureBox()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.valInterval = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.valColorDelay = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.pbMMO7 = New System.Windows.Forms.PictureBox()
        Me.tmrLEDPreview = New System.Windows.Forms.Timer(Me.components)
        Me.cmdPreviewToggle = New System.Windows.Forms.Button()
        Me.chkEnablePulse = New System.Windows.Forms.CheckBox()
        Me.chkCursorPos = New System.Windows.Forms.CheckBox()
        CType(Me.tbColorCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCP1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCP2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCP3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCP4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCP5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCP6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCP7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCP8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCP9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCP10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.valInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.valColorDelay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.pbMMO7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbColorCount
        '
        Me.tbColorCount.Location = New System.Drawing.Point(6, 23)
        Me.tbColorCount.Minimum = 2
        Me.tbColorCount.Name = "tbColorCount"
        Me.tbColorCount.Size = New System.Drawing.Size(187, 45)
        Me.tbColorCount.TabIndex = 0
        Me.tbColorCount.Value = 2
        '
        'pbCP1
        '
        Me.pbCP1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pbCP1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbCP1.Location = New System.Drawing.Point(21, 19)
        Me.pbCP1.Name = "pbCP1"
        Me.pbCP1.Size = New System.Drawing.Size(25, 25)
        Me.pbCP1.TabIndex = 8
        Me.pbCP1.TabStop = False
        '
        'chkRandom
        '
        Me.chkRandom.AutoSize = True
        Me.chkRandom.Location = New System.Drawing.Point(13, 81)
        Me.chkRandom.Name = "chkRandom"
        Me.chkRandom.Size = New System.Drawing.Size(95, 17)
        Me.chkRandom.TabIndex = 9
        Me.chkRandom.Text = "Random Order"
        Me.chkRandom.UseVisualStyleBackColor = True
        '
        'cmdPC1
        '
        Me.cmdPC1.Location = New System.Drawing.Point(52, 19)
        Me.cmdPC1.Name = "cmdPC1"
        Me.cmdPC1.Size = New System.Drawing.Size(90, 23)
        Me.cmdPC1.TabIndex = 10
        Me.cmdPC1.Text = "Pick Color"
        Me.cmdPC1.UseVisualStyleBackColor = True
        '
        'cmdPC2
        '
        Me.cmdPC2.Location = New System.Drawing.Point(52, 48)
        Me.cmdPC2.Name = "cmdPC2"
        Me.cmdPC2.Size = New System.Drawing.Size(90, 23)
        Me.cmdPC2.TabIndex = 12
        Me.cmdPC2.Text = "Pick Color"
        Me.cmdPC2.UseVisualStyleBackColor = True
        '
        'pbCP2
        '
        Me.pbCP2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pbCP2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbCP2.Location = New System.Drawing.Point(21, 48)
        Me.pbCP2.Name = "pbCP2"
        Me.pbCP2.Size = New System.Drawing.Size(25, 25)
        Me.pbCP2.TabIndex = 11
        Me.pbCP2.TabStop = False
        '
        'cmdPC3
        '
        Me.cmdPC3.Enabled = False
        Me.cmdPC3.Location = New System.Drawing.Point(52, 77)
        Me.cmdPC3.Name = "cmdPC3"
        Me.cmdPC3.Size = New System.Drawing.Size(90, 23)
        Me.cmdPC3.TabIndex = 14
        Me.cmdPC3.Text = "Pick Color"
        Me.cmdPC3.UseVisualStyleBackColor = True
        '
        'pbCP3
        '
        Me.pbCP3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pbCP3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbCP3.Location = New System.Drawing.Point(21, 77)
        Me.pbCP3.Name = "pbCP3"
        Me.pbCP3.Size = New System.Drawing.Size(25, 25)
        Me.pbCP3.TabIndex = 13
        Me.pbCP3.TabStop = False
        '
        'cmdPC4
        '
        Me.cmdPC4.Enabled = False
        Me.cmdPC4.Location = New System.Drawing.Point(52, 106)
        Me.cmdPC4.Name = "cmdPC4"
        Me.cmdPC4.Size = New System.Drawing.Size(90, 23)
        Me.cmdPC4.TabIndex = 16
        Me.cmdPC4.Text = "Pick Color"
        Me.cmdPC4.UseVisualStyleBackColor = True
        '
        'pbCP4
        '
        Me.pbCP4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pbCP4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbCP4.Location = New System.Drawing.Point(21, 106)
        Me.pbCP4.Name = "pbCP4"
        Me.pbCP4.Size = New System.Drawing.Size(25, 25)
        Me.pbCP4.TabIndex = 15
        Me.pbCP4.TabStop = False
        '
        'cmdPC5
        '
        Me.cmdPC5.Enabled = False
        Me.cmdPC5.Location = New System.Drawing.Point(52, 135)
        Me.cmdPC5.Name = "cmdPC5"
        Me.cmdPC5.Size = New System.Drawing.Size(90, 23)
        Me.cmdPC5.TabIndex = 18
        Me.cmdPC5.Text = "Pick Color"
        Me.cmdPC5.UseVisualStyleBackColor = True
        '
        'pbCP5
        '
        Me.pbCP5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pbCP5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbCP5.Location = New System.Drawing.Point(21, 135)
        Me.pbCP5.Name = "pbCP5"
        Me.pbCP5.Size = New System.Drawing.Size(25, 25)
        Me.pbCP5.TabIndex = 17
        Me.pbCP5.TabStop = False
        '
        'cmdPC6
        '
        Me.cmdPC6.Enabled = False
        Me.cmdPC6.Location = New System.Drawing.Point(199, 19)
        Me.cmdPC6.Name = "cmdPC6"
        Me.cmdPC6.Size = New System.Drawing.Size(90, 23)
        Me.cmdPC6.TabIndex = 20
        Me.cmdPC6.Text = "Pick Color"
        Me.cmdPC6.UseVisualStyleBackColor = True
        '
        'pbCP6
        '
        Me.pbCP6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pbCP6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbCP6.Location = New System.Drawing.Point(168, 19)
        Me.pbCP6.Name = "pbCP6"
        Me.pbCP6.Size = New System.Drawing.Size(25, 25)
        Me.pbCP6.TabIndex = 19
        Me.pbCP6.TabStop = False
        '
        'cmdPC7
        '
        Me.cmdPC7.Enabled = False
        Me.cmdPC7.Location = New System.Drawing.Point(199, 48)
        Me.cmdPC7.Name = "cmdPC7"
        Me.cmdPC7.Size = New System.Drawing.Size(90, 23)
        Me.cmdPC7.TabIndex = 22
        Me.cmdPC7.Text = "Pick Color"
        Me.cmdPC7.UseVisualStyleBackColor = True
        '
        'pbCP7
        '
        Me.pbCP7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pbCP7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbCP7.Location = New System.Drawing.Point(168, 48)
        Me.pbCP7.Name = "pbCP7"
        Me.pbCP7.Size = New System.Drawing.Size(25, 25)
        Me.pbCP7.TabIndex = 21
        Me.pbCP7.TabStop = False
        '
        'cmdPC8
        '
        Me.cmdPC8.Enabled = False
        Me.cmdPC8.Location = New System.Drawing.Point(199, 77)
        Me.cmdPC8.Name = "cmdPC8"
        Me.cmdPC8.Size = New System.Drawing.Size(90, 23)
        Me.cmdPC8.TabIndex = 24
        Me.cmdPC8.Text = "Pick Color"
        Me.cmdPC8.UseVisualStyleBackColor = True
        '
        'pbCP8
        '
        Me.pbCP8.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pbCP8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbCP8.Location = New System.Drawing.Point(168, 77)
        Me.pbCP8.Name = "pbCP8"
        Me.pbCP8.Size = New System.Drawing.Size(25, 25)
        Me.pbCP8.TabIndex = 23
        Me.pbCP8.TabStop = False
        '
        'cmdPC9
        '
        Me.cmdPC9.Enabled = False
        Me.cmdPC9.Location = New System.Drawing.Point(199, 106)
        Me.cmdPC9.Name = "cmdPC9"
        Me.cmdPC9.Size = New System.Drawing.Size(90, 23)
        Me.cmdPC9.TabIndex = 26
        Me.cmdPC9.Text = "Pick Color"
        Me.cmdPC9.UseVisualStyleBackColor = True
        '
        'pbCP9
        '
        Me.pbCP9.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pbCP9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbCP9.Location = New System.Drawing.Point(168, 106)
        Me.pbCP9.Name = "pbCP9"
        Me.pbCP9.Size = New System.Drawing.Size(25, 25)
        Me.pbCP9.TabIndex = 25
        Me.pbCP9.TabStop = False
        '
        'cmdPC10
        '
        Me.cmdPC10.Enabled = False
        Me.cmdPC10.Location = New System.Drawing.Point(199, 135)
        Me.cmdPC10.Name = "cmdPC10"
        Me.cmdPC10.Size = New System.Drawing.Size(90, 23)
        Me.cmdPC10.TabIndex = 28
        Me.cmdPC10.Text = "Pick Color"
        Me.cmdPC10.UseVisualStyleBackColor = True
        '
        'pbCP10
        '
        Me.pbCP10.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pbCP10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbCP10.Location = New System.Drawing.Point(168, 135)
        Me.pbCP10.Name = "pbCP10"
        Me.pbCP10.Size = New System.Drawing.Size(25, 25)
        Me.pbCP10.TabIndex = 27
        Me.pbCP10.TabStop = False
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(13, 297)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(282, 23)
        Me.cmdSave.TabIndex = 29
        Me.cmdSave.Text = "Ok"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(152, 325)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 20)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 20)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 20)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 20)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 20)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(148, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 20)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "6"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(147, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 20)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "7"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(147, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 20)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "8"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(147, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 20)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "9"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(142, 135)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 20)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "10"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbColorCount)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 75)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Color Count"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.valInterval)
        Me.GroupBox2.Location = New System.Drawing.Point(212, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(89, 45)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Flow Interval"
        '
        'valInterval
        '
        Me.valInterval.Location = New System.Drawing.Point(6, 18)
        Me.valInterval.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.valInterval.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.valInterval.Name = "valInterval"
        Me.valInterval.Size = New System.Drawing.Size(77, 20)
        Me.valInterval.TabIndex = 0
        Me.valInterval.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.pbCP1)
        Me.GroupBox4.Controls.Add(Me.cmdPC10)
        Me.GroupBox4.Controls.Add(Me.pbCP10)
        Me.GroupBox4.Controls.Add(Me.cmdPC9)
        Me.GroupBox4.Controls.Add(Me.pbCP9)
        Me.GroupBox4.Controls.Add(Me.cmdPC8)
        Me.GroupBox4.Controls.Add(Me.pbCP8)
        Me.GroupBox4.Controls.Add(Me.cmdPC7)
        Me.GroupBox4.Controls.Add(Me.cmdPC1)
        Me.GroupBox4.Controls.Add(Me.pbCP7)
        Me.GroupBox4.Controls.Add(Me.pbCP2)
        Me.GroupBox4.Controls.Add(Me.cmdPC6)
        Me.GroupBox4.Controls.Add(Me.cmdPC2)
        Me.GroupBox4.Controls.Add(Me.pbCP6)
        Me.GroupBox4.Controls.Add(Me.pbCP3)
        Me.GroupBox4.Controls.Add(Me.cmdPC5)
        Me.GroupBox4.Controls.Add(Me.cmdPC3)
        Me.GroupBox4.Controls.Add(Me.pbCP5)
        Me.GroupBox4.Controls.Add(Me.pbCP4)
        Me.GroupBox4.Controls.Add(Me.cmdPC4)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 126)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(295, 165)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Colors"
        '
        'valColorDelay
        '
        Me.valColorDelay.DecimalPlaces = 2
        Me.valColorDelay.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.valColorDelay.Location = New System.Drawing.Point(6, 18)
        Me.valColorDelay.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.valColorDelay.Name = "valColorDelay"
        Me.valColorDelay.ReadOnly = True
        Me.valColorDelay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.valColorDelay.Size = New System.Drawing.Size(77, 20)
        Me.valColorDelay.TabIndex = 43
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.valColorDelay)
        Me.GroupBox3.Location = New System.Drawing.Point(212, 50)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(89, 48)
        Me.GroupBox3.TabIndex = 44
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Color Delay"
        '
        'pbMMO7
        '
        Me.pbMMO7.BackColor = System.Drawing.Color.Black
        Me.pbMMO7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbMMO7.Image = Global.CyborgAutoProfiler.My.Resources.Resources.MMO7LED
        Me.pbMMO7.Location = New System.Drawing.Point(310, 11)
        Me.pbMMO7.Name = "pbMMO7"
        Me.pbMMO7.Size = New System.Drawing.Size(202, 251)
        Me.pbMMO7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbMMO7.TabIndex = 45
        Me.pbMMO7.TabStop = False
        '
        'tmrLEDPreview
        '
        '
        'cmdPreviewToggle
        '
        Me.cmdPreviewToggle.Location = New System.Drawing.Point(310, 268)
        Me.cmdPreviewToggle.Name = "cmdPreviewToggle"
        Me.cmdPreviewToggle.Size = New System.Drawing.Size(202, 23)
        Me.cmdPreviewToggle.TabIndex = 46
        Me.cmdPreviewToggle.Text = "Enable Preview"
        Me.cmdPreviewToggle.UseVisualStyleBackColor = True
        '
        'chkEnablePulse
        '
        Me.chkEnablePulse.AutoSize = True
        Me.chkEnablePulse.Location = New System.Drawing.Point(118, 81)
        Me.chkEnablePulse.Name = "chkEnablePulse"
        Me.chkEnablePulse.Size = New System.Drawing.Size(88, 17)
        Me.chkEnablePulse.TabIndex = 47
        Me.chkEnablePulse.Text = "Enable Pulse"
        Me.chkEnablePulse.UseVisualStyleBackColor = True
        '
        'chkCursorPos
        '
        Me.chkCursorPos.AutoSize = True
        Me.chkCursorPos.Location = New System.Drawing.Point(12, 104)
        Me.chkCursorPos.Name = "chkCursorPos"
        Me.chkCursorPos.Size = New System.Drawing.Size(179, 17)
        Me.chkCursorPos.TabIndex = 48
        Me.chkCursorPos.Text = "Use Color Under Mouse Position"
        Me.chkCursorPos.UseVisualStyleBackColor = True
        '
        'frmMMO7LEDFlow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(514, 323)
        Me.Controls.Add(Me.chkCursorPos)
        Me.Controls.Add(Me.chkEnablePulse)
        Me.Controls.Add(Me.cmdPreviewToggle)
        Me.Controls.Add(Me.pbMMO7)
        Me.Controls.Add(Me.chkRandom)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cmdSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMMO7LEDFlow"
        Me.Text = "M.M.O.7 LED Flow Settings"
        CType(Me.tbColorCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCP1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCP2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCP3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCP4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCP5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCP6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCP7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCP8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCP9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCP10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.valInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.valColorDelay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.pbMMO7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbColorCount As System.Windows.Forms.TrackBar
    Friend WithEvents pbCP1 As System.Windows.Forms.PictureBox
    Friend WithEvents chkRandom As System.Windows.Forms.CheckBox
    Friend WithEvents cmdPC1 As System.Windows.Forms.Button
    Friend WithEvents CD As System.Windows.Forms.ColorDialog
    Friend WithEvents cmdPC2 As System.Windows.Forms.Button
    Friend WithEvents pbCP2 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdPC3 As System.Windows.Forms.Button
    Friend WithEvents pbCP3 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdPC4 As System.Windows.Forms.Button
    Friend WithEvents pbCP4 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdPC5 As System.Windows.Forms.Button
    Friend WithEvents pbCP5 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdPC6 As System.Windows.Forms.Button
    Friend WithEvents pbCP6 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdPC7 As System.Windows.Forms.Button
    Friend WithEvents pbCP7 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdPC8 As System.Windows.Forms.Button
    Friend WithEvents pbCP8 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdPC9 As System.Windows.Forms.Button
    Friend WithEvents pbCP9 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdPC10 As System.Windows.Forms.Button
    Friend WithEvents pbCP10 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents valInterval As System.Windows.Forms.NumericUpDown
    Friend WithEvents valColorDelay As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents pbMMO7 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrLEDPreview As System.Windows.Forms.Timer
    Friend WithEvents cmdPreviewToggle As System.Windows.Forms.Button
    Friend WithEvents chkEnablePulse As System.Windows.Forms.CheckBox
    Friend WithEvents chkCursorPos As System.Windows.Forms.CheckBox
End Class
