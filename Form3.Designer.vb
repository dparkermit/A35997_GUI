<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.TextBoxVSetPoint = New System.Windows.Forms.TextBox()
        Me.TextBoxVDACGain = New System.Windows.Forms.TextBox()
        Me.TextBoxVDACOffset = New System.Windows.Forms.TextBox()
        Me.TextBoxVADCGain = New System.Windows.Forms.TextBox()
        Me.TextBoxVADCOffset = New System.Windows.Forms.TextBox()
        Me.TextBoxISetPoint = New System.Windows.Forms.TextBox()
        Me.TextBoxIDACGain = New System.Windows.Forms.TextBox()
        Me.TextBoxIDACOffset = New System.Windows.Forms.TextBox()
        Me.TextBoxIADCGain = New System.Windows.Forms.TextBox()
        Me.TextBoxIADCOffset = New System.Windows.Forms.TextBox()
        Me.TextBoxUnused1 = New System.Windows.Forms.TextBox()
        Me.TextBoxUnused2 = New System.Windows.Forms.TextBox()
        Me.TextBoxUnused3 = New System.Windows.Forms.TextBox()
        Me.TextBoxUnused4 = New System.Windows.Forms.TextBox()
        Me.TextBoxUnused5 = New System.Windows.Forms.TextBox()
        Me.TextBoxCRC = New System.Windows.Forms.TextBox()
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ButtonWriteMagnetPs = New System.Windows.Forms.Button()
        Me.ButtonReadMagnetPS = New System.Windows.Forms.Button()
        Me.ButtonReadFilamentPS = New System.Windows.Forms.Button()
        Me.ButtonReadThyrCathodePS = New System.Windows.Forms.Button()
        Me.ButtonReadThyrReservoirPS = New System.Windows.Forms.Button()
        Me.ButtonReadHVModeA = New System.Windows.Forms.Button()
        Me.ButtonReadHVModeB = New System.Windows.Forms.Button()
        Me.ButtonReadMagnetronModeB = New System.Windows.Forms.Button()
        Me.ButtonReadMagnetronModeA = New System.Windows.Forms.Button()
        Me.ButtonWriteFilamentPS = New System.Windows.Forms.Button()
        Me.ButtonWriteThyrCathodePS = New System.Windows.Forms.Button()
        Me.ButtonWriteThyrReservoirPS = New System.Windows.Forms.Button()
        Me.ButtonWriteHVModeA = New System.Windows.Forms.Button()
        Me.ButtonWriteHVModeB = New System.Windows.Forms.Button()
        Me.ButtonWriteMagnetronModeA = New System.Windows.Forms.Button()
        Me.ButtonWriteMagnetronModeB = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ButtonSaveConfig = New System.Windows.Forms.Button()
        Me.ButtonLoadConfig = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxVSetPoint
        '
        Me.TextBoxVSetPoint.Location = New System.Drawing.Point(207, 38)
        Me.TextBoxVSetPoint.Name = "TextBoxVSetPoint"
        Me.TextBoxVSetPoint.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxVSetPoint.TabIndex = 0
        '
        'TextBoxVDACGain
        '
        Me.TextBoxVDACGain.Location = New System.Drawing.Point(207, 64)
        Me.TextBoxVDACGain.Name = "TextBoxVDACGain"
        Me.TextBoxVDACGain.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxVDACGain.TabIndex = 1
        '
        'TextBoxVDACOffset
        '
        Me.TextBoxVDACOffset.Location = New System.Drawing.Point(207, 90)
        Me.TextBoxVDACOffset.Name = "TextBoxVDACOffset"
        Me.TextBoxVDACOffset.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxVDACOffset.TabIndex = 3
        '
        'TextBoxVADCGain
        '
        Me.TextBoxVADCGain.Location = New System.Drawing.Point(207, 116)
        Me.TextBoxVADCGain.Name = "TextBoxVADCGain"
        Me.TextBoxVADCGain.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxVADCGain.TabIndex = 2
        '
        'TextBoxVADCOffset
        '
        Me.TextBoxVADCOffset.Location = New System.Drawing.Point(207, 142)
        Me.TextBoxVADCOffset.Name = "TextBoxVADCOffset"
        Me.TextBoxVADCOffset.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxVADCOffset.TabIndex = 7
        '
        'TextBoxISetPoint
        '
        Me.TextBoxISetPoint.Location = New System.Drawing.Point(207, 168)
        Me.TextBoxISetPoint.Name = "TextBoxISetPoint"
        Me.TextBoxISetPoint.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxISetPoint.TabIndex = 6
        '
        'TextBoxIDACGain
        '
        Me.TextBoxIDACGain.Location = New System.Drawing.Point(207, 194)
        Me.TextBoxIDACGain.Name = "TextBoxIDACGain"
        Me.TextBoxIDACGain.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxIDACGain.TabIndex = 5
        '
        'TextBoxIDACOffset
        '
        Me.TextBoxIDACOffset.Location = New System.Drawing.Point(207, 220)
        Me.TextBoxIDACOffset.Name = "TextBoxIDACOffset"
        Me.TextBoxIDACOffset.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxIDACOffset.TabIndex = 4
        '
        'TextBoxIADCGain
        '
        Me.TextBoxIADCGain.Location = New System.Drawing.Point(512, 38)
        Me.TextBoxIADCGain.Name = "TextBoxIADCGain"
        Me.TextBoxIADCGain.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxIADCGain.TabIndex = 8
        '
        'TextBoxIADCOffset
        '
        Me.TextBoxIADCOffset.Location = New System.Drawing.Point(512, 64)
        Me.TextBoxIADCOffset.Name = "TextBoxIADCOffset"
        Me.TextBoxIADCOffset.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxIADCOffset.TabIndex = 9
        '
        'TextBoxUnused1
        '
        Me.TextBoxUnused1.Location = New System.Drawing.Point(512, 90)
        Me.TextBoxUnused1.Name = "TextBoxUnused1"
        Me.TextBoxUnused1.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxUnused1.TabIndex = 10
        '
        'TextBoxUnused2
        '
        Me.TextBoxUnused2.Location = New System.Drawing.Point(512, 116)
        Me.TextBoxUnused2.Name = "TextBoxUnused2"
        Me.TextBoxUnused2.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxUnused2.TabIndex = 11
        '
        'TextBoxUnused3
        '
        Me.TextBoxUnused3.Location = New System.Drawing.Point(512, 142)
        Me.TextBoxUnused3.Name = "TextBoxUnused3"
        Me.TextBoxUnused3.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxUnused3.TabIndex = 12
        '
        'TextBoxUnused4
        '
        Me.TextBoxUnused4.Location = New System.Drawing.Point(512, 168)
        Me.TextBoxUnused4.Name = "TextBoxUnused4"
        Me.TextBoxUnused4.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxUnused4.TabIndex = 13
        '
        'TextBoxUnused5
        '
        Me.TextBoxUnused5.Location = New System.Drawing.Point(512, 194)
        Me.TextBoxUnused5.Name = "TextBoxUnused5"
        Me.TextBoxUnused5.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxUnused5.TabIndex = 14
        '
        'TextBoxCRC
        '
        Me.TextBoxCRC.Location = New System.Drawing.Point(512, 220)
        Me.TextBoxCRC.Name = "TextBoxCRC"
        Me.TextBoxCRC.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCRC.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(313, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "V Set Point"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(313, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "V DAC Gain"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(313, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "V DAC Offset"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(313, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "V ADC Gain"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(313, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "V ADC Offset"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(313, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "I Set Point"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(313, 197)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "I DAC Gain"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(313, 223)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "I DAC Offset"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(618, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "I ADC Gain"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(618, 67)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "I ADC Offset"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(618, 93)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Unused 1"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(618, 119)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Unused 2"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(618, 145)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 13)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Unused 3"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(618, 171)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 13)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Unused 4"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(618, 197)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 13)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Unused 5"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(618, 223)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(106, 13)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "CRC not Implimented"
        '
        'ButtonWriteMagnetPs
        '
        Me.ButtonWriteMagnetPs.Location = New System.Drawing.Point(12, 298)
        Me.ButtonWriteMagnetPs.Name = "ButtonWriteMagnetPs"
        Me.ButtonWriteMagnetPs.Size = New System.Drawing.Size(131, 23)
        Me.ButtonWriteMagnetPs.TabIndex = 32
        Me.ButtonWriteMagnetPs.Text = "Write Magnet PS"
        Me.ButtonWriteMagnetPs.UseVisualStyleBackColor = True
        '
        'ButtonReadMagnetPS
        '
        Me.ButtonReadMagnetPS.Location = New System.Drawing.Point(12, 269)
        Me.ButtonReadMagnetPS.Name = "ButtonReadMagnetPS"
        Me.ButtonReadMagnetPS.Size = New System.Drawing.Size(131, 23)
        Me.ButtonReadMagnetPS.TabIndex = 33
        Me.ButtonReadMagnetPS.Text = "Read Magnet PS"
        Me.ButtonReadMagnetPS.UseVisualStyleBackColor = True
        '
        'ButtonReadFilamentPS
        '
        Me.ButtonReadFilamentPS.Location = New System.Drawing.Point(149, 269)
        Me.ButtonReadFilamentPS.Name = "ButtonReadFilamentPS"
        Me.ButtonReadFilamentPS.Size = New System.Drawing.Size(131, 23)
        Me.ButtonReadFilamentPS.TabIndex = 34
        Me.ButtonReadFilamentPS.Text = "Read Filament PS"
        Me.ButtonReadFilamentPS.UseVisualStyleBackColor = True
        '
        'ButtonReadThyrCathodePS
        '
        Me.ButtonReadThyrCathodePS.Location = New System.Drawing.Point(286, 269)
        Me.ButtonReadThyrCathodePS.Name = "ButtonReadThyrCathodePS"
        Me.ButtonReadThyrCathodePS.Size = New System.Drawing.Size(131, 23)
        Me.ButtonReadThyrCathodePS.TabIndex = 35
        Me.ButtonReadThyrCathodePS.Text = "Read Thyr Cathode PS"
        Me.ButtonReadThyrCathodePS.UseVisualStyleBackColor = True
        '
        'ButtonReadThyrReservoirPS
        '
        Me.ButtonReadThyrReservoirPS.Location = New System.Drawing.Point(423, 269)
        Me.ButtonReadThyrReservoirPS.Name = "ButtonReadThyrReservoirPS"
        Me.ButtonReadThyrReservoirPS.Size = New System.Drawing.Size(131, 23)
        Me.ButtonReadThyrReservoirPS.TabIndex = 36
        Me.ButtonReadThyrReservoirPS.Text = "Read Thyr Reservoir PS"
        Me.ButtonReadThyrReservoirPS.UseVisualStyleBackColor = True
        '
        'ButtonReadHVModeA
        '
        Me.ButtonReadHVModeA.Location = New System.Drawing.Point(560, 269)
        Me.ButtonReadHVModeA.Name = "ButtonReadHVModeA"
        Me.ButtonReadHVModeA.Size = New System.Drawing.Size(131, 23)
        Me.ButtonReadHVModeA.TabIndex = 37
        Me.ButtonReadHVModeA.Text = "Read HV Mode A"
        Me.ButtonReadHVModeA.UseVisualStyleBackColor = True
        '
        'ButtonReadHVModeB
        '
        Me.ButtonReadHVModeB.Location = New System.Drawing.Point(697, 269)
        Me.ButtonReadHVModeB.Name = "ButtonReadHVModeB"
        Me.ButtonReadHVModeB.Size = New System.Drawing.Size(131, 23)
        Me.ButtonReadHVModeB.TabIndex = 38
        Me.ButtonReadHVModeB.Text = "Read HV Mode B"
        Me.ButtonReadHVModeB.UseVisualStyleBackColor = True
        '
        'ButtonReadMagnetronModeB
        '
        Me.ButtonReadMagnetronModeB.Location = New System.Drawing.Point(971, 269)
        Me.ButtonReadMagnetronModeB.Name = "ButtonReadMagnetronModeB"
        Me.ButtonReadMagnetronModeB.Size = New System.Drawing.Size(131, 23)
        Me.ButtonReadMagnetronModeB.TabIndex = 39
        Me.ButtonReadMagnetronModeB.Text = "Read Magnetron B"
        Me.ButtonReadMagnetronModeB.UseVisualStyleBackColor = True
        '
        'ButtonReadMagnetronModeA
        '
        Me.ButtonReadMagnetronModeA.Location = New System.Drawing.Point(834, 269)
        Me.ButtonReadMagnetronModeA.Name = "ButtonReadMagnetronModeA"
        Me.ButtonReadMagnetronModeA.Size = New System.Drawing.Size(131, 23)
        Me.ButtonReadMagnetronModeA.TabIndex = 40
        Me.ButtonReadMagnetronModeA.Text = "Read Magnetron  A"
        Me.ButtonReadMagnetronModeA.UseVisualStyleBackColor = True
        '
        'ButtonWriteFilamentPS
        '
        Me.ButtonWriteFilamentPS.Location = New System.Drawing.Point(149, 298)
        Me.ButtonWriteFilamentPS.Name = "ButtonWriteFilamentPS"
        Me.ButtonWriteFilamentPS.Size = New System.Drawing.Size(131, 23)
        Me.ButtonWriteFilamentPS.TabIndex = 41
        Me.ButtonWriteFilamentPS.Text = "Write Filament PS"
        Me.ButtonWriteFilamentPS.UseVisualStyleBackColor = True
        '
        'ButtonWriteThyrCathodePS
        '
        Me.ButtonWriteThyrCathodePS.Location = New System.Drawing.Point(286, 298)
        Me.ButtonWriteThyrCathodePS.Name = "ButtonWriteThyrCathodePS"
        Me.ButtonWriteThyrCathodePS.Size = New System.Drawing.Size(131, 23)
        Me.ButtonWriteThyrCathodePS.TabIndex = 42
        Me.ButtonWriteThyrCathodePS.Text = "Write Thyr Cathode PS"
        Me.ButtonWriteThyrCathodePS.UseVisualStyleBackColor = True
        '
        'ButtonWriteThyrReservoirPS
        '
        Me.ButtonWriteThyrReservoirPS.Location = New System.Drawing.Point(423, 298)
        Me.ButtonWriteThyrReservoirPS.Name = "ButtonWriteThyrReservoirPS"
        Me.ButtonWriteThyrReservoirPS.Size = New System.Drawing.Size(131, 23)
        Me.ButtonWriteThyrReservoirPS.TabIndex = 43
        Me.ButtonWriteThyrReservoirPS.Text = "Write Thyr Reservoir PS"
        Me.ButtonWriteThyrReservoirPS.UseVisualStyleBackColor = True
        '
        'ButtonWriteHVModeA
        '
        Me.ButtonWriteHVModeA.Location = New System.Drawing.Point(560, 298)
        Me.ButtonWriteHVModeA.Name = "ButtonWriteHVModeA"
        Me.ButtonWriteHVModeA.Size = New System.Drawing.Size(131, 23)
        Me.ButtonWriteHVModeA.TabIndex = 44
        Me.ButtonWriteHVModeA.Text = "Write HV Mode A"
        Me.ButtonWriteHVModeA.UseVisualStyleBackColor = True
        '
        'ButtonWriteHVModeB
        '
        Me.ButtonWriteHVModeB.Location = New System.Drawing.Point(697, 298)
        Me.ButtonWriteHVModeB.Name = "ButtonWriteHVModeB"
        Me.ButtonWriteHVModeB.Size = New System.Drawing.Size(131, 23)
        Me.ButtonWriteHVModeB.TabIndex = 45
        Me.ButtonWriteHVModeB.Text = "Write HV Mode B"
        Me.ButtonWriteHVModeB.UseVisualStyleBackColor = True
        '
        'ButtonWriteMagnetronModeA
        '
        Me.ButtonWriteMagnetronModeA.Location = New System.Drawing.Point(834, 298)
        Me.ButtonWriteMagnetronModeA.Name = "ButtonWriteMagnetronModeA"
        Me.ButtonWriteMagnetronModeA.Size = New System.Drawing.Size(131, 23)
        Me.ButtonWriteMagnetronModeA.TabIndex = 46
        Me.ButtonWriteMagnetronModeA.Text = "Write Magnetron  A"
        Me.ButtonWriteMagnetronModeA.UseVisualStyleBackColor = True
        '
        'ButtonWriteMagnetronModeB
        '
        Me.ButtonWriteMagnetronModeB.Location = New System.Drawing.Point(971, 298)
        Me.ButtonWriteMagnetronModeB.Name = "ButtonWriteMagnetronModeB"
        Me.ButtonWriteMagnetronModeB.Size = New System.Drawing.Size(131, 23)
        Me.ButtonWriteMagnetronModeB.TabIndex = 47
        Me.ButtonWriteMagnetronModeB.Text = "Write Magnetron  B"
        Me.ButtonWriteMagnetronModeB.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ButtonSaveConfig
        '
        Me.ButtonSaveConfig.Location = New System.Drawing.Point(12, 375)
        Me.ButtonSaveConfig.Name = "ButtonSaveConfig"
        Me.ButtonSaveConfig.Size = New System.Drawing.Size(131, 23)
        Me.ButtonSaveConfig.TabIndex = 48
        Me.ButtonSaveConfig.Text = "Save Config"
        Me.ButtonSaveConfig.UseVisualStyleBackColor = True
        '
        'ButtonLoadConfig
        '
        Me.ButtonLoadConfig.Location = New System.Drawing.Point(12, 404)
        Me.ButtonLoadConfig.Name = "ButtonLoadConfig"
        Me.ButtonLoadConfig.Size = New System.Drawing.Size(131, 23)
        Me.ButtonLoadConfig.TabIndex = 49
        Me.ButtonLoadConfig.Text = "Load Config"
        Me.ButtonLoadConfig.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1135, 459)
        Me.Controls.Add(Me.ButtonLoadConfig)
        Me.Controls.Add(Me.ButtonSaveConfig)
        Me.Controls.Add(Me.ButtonWriteMagnetronModeB)
        Me.Controls.Add(Me.ButtonWriteMagnetronModeA)
        Me.Controls.Add(Me.ButtonWriteHVModeB)
        Me.Controls.Add(Me.ButtonWriteHVModeA)
        Me.Controls.Add(Me.ButtonWriteThyrReservoirPS)
        Me.Controls.Add(Me.ButtonWriteThyrCathodePS)
        Me.Controls.Add(Me.ButtonWriteFilamentPS)
        Me.Controls.Add(Me.ButtonReadMagnetronModeA)
        Me.Controls.Add(Me.ButtonReadMagnetronModeB)
        Me.Controls.Add(Me.ButtonReadHVModeB)
        Me.Controls.Add(Me.ButtonReadHVModeA)
        Me.Controls.Add(Me.ButtonReadThyrReservoirPS)
        Me.Controls.Add(Me.ButtonReadThyrCathodePS)
        Me.Controls.Add(Me.ButtonReadFilamentPS)
        Me.Controls.Add(Me.ButtonReadMagnetPS)
        Me.Controls.Add(Me.ButtonWriteMagnetPs)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxCRC)
        Me.Controls.Add(Me.TextBoxUnused5)
        Me.Controls.Add(Me.TextBoxUnused4)
        Me.Controls.Add(Me.TextBoxUnused3)
        Me.Controls.Add(Me.TextBoxUnused2)
        Me.Controls.Add(Me.TextBoxUnused1)
        Me.Controls.Add(Me.TextBoxIADCOffset)
        Me.Controls.Add(Me.TextBoxIADCGain)
        Me.Controls.Add(Me.TextBoxVADCOffset)
        Me.Controls.Add(Me.TextBoxISetPoint)
        Me.Controls.Add(Me.TextBoxIDACGain)
        Me.Controls.Add(Me.TextBoxIDACOffset)
        Me.Controls.Add(Me.TextBoxVDACOffset)
        Me.Controls.Add(Me.TextBoxVADCGain)
        Me.Controls.Add(Me.TextBoxVDACGain)
        Me.Controls.Add(Me.TextBoxVSetPoint)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxVSetPoint As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxVDACGain As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxVDACOffset As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxVADCGain As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxVADCOffset As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxISetPoint As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxIDACGain As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxIDACOffset As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxIADCGain As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxIADCOffset As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxUnused1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxUnused2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxUnused3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxUnused4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxUnused5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCRC As System.Windows.Forms.TextBox
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
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ButtonWriteMagnetPs As System.Windows.Forms.Button
    Friend WithEvents ButtonReadMagnetPS As System.Windows.Forms.Button
    Friend WithEvents ButtonReadFilamentPS As System.Windows.Forms.Button
    Friend WithEvents ButtonReadThyrCathodePS As System.Windows.Forms.Button
    Friend WithEvents ButtonReadThyrReservoirPS As System.Windows.Forms.Button
    Friend WithEvents ButtonReadHVModeA As System.Windows.Forms.Button
    Friend WithEvents ButtonReadHVModeB As System.Windows.Forms.Button
    Friend WithEvents ButtonReadMagnetronModeB As System.Windows.Forms.Button
    Friend WithEvents ButtonReadMagnetronModeA As System.Windows.Forms.Button
    Friend WithEvents ButtonWriteFilamentPS As System.Windows.Forms.Button
    Friend WithEvents ButtonWriteThyrCathodePS As System.Windows.Forms.Button
    Friend WithEvents ButtonWriteThyrReservoirPS As System.Windows.Forms.Button
    Friend WithEvents ButtonWriteHVModeA As System.Windows.Forms.Button
    Friend WithEvents ButtonWriteHVModeB As System.Windows.Forms.Button
    Friend WithEvents ButtonWriteMagnetronModeA As System.Windows.Forms.Button
    Friend WithEvents ButtonWriteMagnetronModeB As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ButtonSaveConfig As System.Windows.Forms.Button
    Friend WithEvents ButtonLoadConfig As System.Windows.Forms.Button
End Class
