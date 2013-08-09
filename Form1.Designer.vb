<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.SerialPortETM = New System.IO.Ports.SerialPort(Me.components)
        Me.LabelComMsg = New System.Windows.Forms.Label()
        Me.ComboBoxComPorts = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelFwdAPower = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelFwdATemp = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.LabelState = New System.Windows.Forms.Label()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronStatusBit15 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronFaultBit15 = New System.Windows.Forms.CheckBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronStatusBit14 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronFaultBit14 = New System.Windows.Forms.CheckBox()
        Me.CheckBox29 = New System.Windows.Forms.CheckBox()
        Me.CheckBox30 = New System.Windows.Forms.CheckBox()
        Me.CheckBox33 = New System.Windows.Forms.CheckBox()
        Me.CheckBox44 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronStatusBit13 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronStatusBit11 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronStatusBit12 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronStatusBit10 = New System.Windows.Forms.CheckBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.CheckBoxThyratronFaultBit13 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronFaultBit11 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronFaultBit12 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronFaultBit10 = New System.Windows.Forms.CheckBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.CheckBox75 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronStatusBit9 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronFaultBit9 = New System.Windows.Forms.CheckBox()
        Me.CheckBox78 = New System.Windows.Forms.CheckBox()
        Me.CheckBox79 = New System.Windows.Forms.CheckBox()
        Me.CheckBox80 = New System.Windows.Forms.CheckBox()
        Me.CheckBox81 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronStatusBit8 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronStatusBit6 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronStatusBit7 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronStatusBit5 = New System.Windows.Forms.CheckBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.CheckBoxThyratronFaultBit8 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronFaultBit6 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronFaultBit7 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronFaultBit5 = New System.Windows.Forms.CheckBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.CheckBox90 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronStatusBit4 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronFaultBit4 = New System.Windows.Forms.CheckBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.CheckBox93 = New System.Windows.Forms.CheckBox()
        Me.CheckBox94 = New System.Windows.Forms.CheckBox()
        Me.CheckBox95 = New System.Windows.Forms.CheckBox()
        Me.CheckBox96 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronStatusBit3 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronStatusBit1 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronStatusBit2 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronStatusBit0 = New System.Windows.Forms.CheckBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.CheckBoxThyratronFaultBit3 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronFaultBit1 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronFaultBit2 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronFaultBit0 = New System.Windows.Forms.CheckBox()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.ButtonSetBaudRate = New System.Windows.Forms.Button()
        Me.TextBoxBaudRate = New System.Windows.Forms.TextBox()
        Me.LabelGUIVersion = New System.Windows.Forms.Label()
        Me.LabelMCUVersion = New System.Windows.Forms.Label()
        Me.LabelFwdBTemp = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelFwdBPower = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabelRevBTemp = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelRevBPower = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LabelRevATemp = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LabelRevAPower = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LabelTime = New System.Windows.Forms.Label()
        Me.LabelTotalPwr = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabelPwrProg = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LabelRFAmpTemp = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LabelDacOut = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LabelRevPwr = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LabelTargetPower = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelScaleError = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.LabelOverReverseCount = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.LabelLTC2656Errors = New System.Windows.Forms.Label()
        Me.Label20x = New System.Windows.Forms.Label()
        Me.LabelWatch1 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.LabelWatch2 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.LabelWatch4 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.LabelWatch3 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TextPowerLevel = New System.Windows.Forms.TextBox()
        Me.ButtonSetPwrLevel = New System.Windows.Forms.Button()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.TextBoxPCoeff = New System.Windows.Forms.TextBox()
        Me.TextBoxICoeff = New System.Windows.Forms.TextBox()
        Me.TextBoxDCoeff = New System.Windows.Forms.TextBox()
        Me.ButtonWritePID = New System.Windows.Forms.Button()
        Me.ButtonReadPID = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TextBoxStep = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TextBoxInterval = New System.Windows.Forms.TextBox()
        Me.ButtonStartTest = New System.Windows.Forms.Button()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SerialPortETM
        '
        Me.SerialPortETM.BaudRate = 122000
        Me.SerialPortETM.DtrEnable = True
        Me.SerialPortETM.ReadTimeout = 100
        Me.SerialPortETM.RtsEnable = True
        '
        'LabelComMsg
        '
        Me.LabelComMsg.AutoSize = True
        Me.LabelComMsg.Location = New System.Drawing.Point(704, 348)
        Me.LabelComMsg.Name = "LabelComMsg"
        Me.LabelComMsg.Size = New System.Drawing.Size(98, 13)
        Me.LabelComMsg.TabIndex = 1
        Me.LabelComMsg.Text = "Selected COM Port"
        '
        'ComboBoxComPorts
        '
        Me.ComboBoxComPorts.FormattingEnabled = True
        Me.ComboBoxComPorts.Location = New System.Drawing.Point(707, 364)
        Me.ComboBoxComPorts.Name = "ComboBoxComPorts"
        Me.ComboBoxComPorts.Size = New System.Drawing.Size(114, 21)
        Me.ComboBoxComPorts.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Forward Detector A"
        '
        'LabelFwdAPower
        '
        Me.LabelFwdAPower.AutoSize = True
        Me.LabelFwdAPower.Location = New System.Drawing.Point(148, 158)
        Me.LabelFwdAPower.Name = "LabelFwdAPower"
        Me.LabelFwdAPower.Size = New System.Drawing.Size(10, 13)
        Me.LabelFwdAPower.TabIndex = 10
        Me.LabelFwdAPower.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Power"
        '
        'LabelFwdATemp
        '
        Me.LabelFwdATemp.AutoSize = True
        Me.LabelFwdATemp.Location = New System.Drawing.Point(148, 171)
        Me.LabelFwdATemp.Name = "LabelFwdATemp"
        Me.LabelFwdATemp.Size = New System.Drawing.Size(10, 13)
        Me.LabelFwdATemp.TabIndex = 34
        Me.LabelFwdATemp.Text = "-"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(12, 171)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(67, 13)
        Me.Label28.TabIndex = 33
        Me.Label28.Text = "Temperature"
        '
        'LabelState
        '
        Me.LabelState.AutoSize = True
        Me.LabelState.Location = New System.Drawing.Point(214, 9)
        Me.LabelState.Name = "LabelState"
        Me.LabelState.Size = New System.Drawing.Size(10, 13)
        Me.LabelState.TabIndex = 438
        Me.LabelState.Text = "-"
        '
        'Label93
        '
        Me.Label93.AutoSize = True
        Me.Label93.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label93.Location = New System.Drawing.Point(163, 9)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(37, 13)
        Me.Label93.TabIndex = 437
        Me.Label93.Text = "State"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 60000
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoCheck = False
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(749, 269)
        Me.CheckBox3.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox3.TabIndex = 725
        Me.CheckBox3.UseVisualStyleBackColor = True
        Me.CheckBox3.Visible = False
        '
        'CheckBoxThyratronStatusBit15
        '
        Me.CheckBoxThyratronStatusBit15.AutoCheck = False
        Me.CheckBoxThyratronStatusBit15.AutoSize = True
        Me.CheckBoxThyratronStatusBit15.Location = New System.Drawing.Point(728, 269)
        Me.CheckBoxThyratronStatusBit15.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronStatusBit15.Name = "CheckBoxThyratronStatusBit15"
        Me.CheckBoxThyratronStatusBit15.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronStatusBit15.TabIndex = 724
        Me.CheckBoxThyratronStatusBit15.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronFaultBit15
        '
        Me.CheckBoxThyratronFaultBit15.AutoCheck = False
        Me.CheckBoxThyratronFaultBit15.AutoSize = True
        Me.CheckBoxThyratronFaultBit15.Location = New System.Drawing.Point(707, 269)
        Me.CheckBoxThyratronFaultBit15.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronFaultBit15.Name = "CheckBoxThyratronFaultBit15"
        Me.CheckBoxThyratronFaultBit15.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronFaultBit15.TabIndex = 723
        Me.CheckBoxThyratronFaultBit15.UseVisualStyleBackColor = True
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(582, 269)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(120, 13)
        Me.Label38.TabIndex = 722
        Me.Label38.Text = "Rev Det B Temperature"
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoCheck = False
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Location = New System.Drawing.Point(749, 255)
        Me.CheckBox8.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox8.TabIndex = 721
        Me.CheckBox8.UseVisualStyleBackColor = True
        Me.CheckBox8.Visible = False
        '
        'CheckBoxThyratronStatusBit14
        '
        Me.CheckBoxThyratronStatusBit14.AutoCheck = False
        Me.CheckBoxThyratronStatusBit14.AutoSize = True
        Me.CheckBoxThyratronStatusBit14.Location = New System.Drawing.Point(728, 255)
        Me.CheckBoxThyratronStatusBit14.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronStatusBit14.Name = "CheckBoxThyratronStatusBit14"
        Me.CheckBoxThyratronStatusBit14.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronStatusBit14.TabIndex = 720
        Me.CheckBoxThyratronStatusBit14.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronFaultBit14
        '
        Me.CheckBoxThyratronFaultBit14.AutoCheck = False
        Me.CheckBoxThyratronFaultBit14.AutoSize = True
        Me.CheckBoxThyratronFaultBit14.Location = New System.Drawing.Point(707, 255)
        Me.CheckBoxThyratronFaultBit14.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronFaultBit14.Name = "CheckBoxThyratronFaultBit14"
        Me.CheckBoxThyratronFaultBit14.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronFaultBit14.TabIndex = 719
        Me.CheckBoxThyratronFaultBit14.UseVisualStyleBackColor = True
        '
        'CheckBox29
        '
        Me.CheckBox29.AutoCheck = False
        Me.CheckBox29.AutoSize = True
        Me.CheckBox29.Location = New System.Drawing.Point(749, 241)
        Me.CheckBox29.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox29.Name = "CheckBox29"
        Me.CheckBox29.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox29.TabIndex = 718
        Me.CheckBox29.UseVisualStyleBackColor = True
        Me.CheckBox29.Visible = False
        '
        'CheckBox30
        '
        Me.CheckBox30.AutoCheck = False
        Me.CheckBox30.AutoSize = True
        Me.CheckBox30.Location = New System.Drawing.Point(749, 213)
        Me.CheckBox30.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox30.Name = "CheckBox30"
        Me.CheckBox30.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox30.TabIndex = 717
        Me.CheckBox30.UseVisualStyleBackColor = True
        Me.CheckBox30.Visible = False
        '
        'CheckBox33
        '
        Me.CheckBox33.AutoCheck = False
        Me.CheckBox33.AutoSize = True
        Me.CheckBox33.Location = New System.Drawing.Point(749, 227)
        Me.CheckBox33.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox33.Name = "CheckBox33"
        Me.CheckBox33.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox33.TabIndex = 716
        Me.CheckBox33.UseVisualStyleBackColor = True
        Me.CheckBox33.Visible = False
        '
        'CheckBox44
        '
        Me.CheckBox44.AutoCheck = False
        Me.CheckBox44.AutoSize = True
        Me.CheckBox44.Location = New System.Drawing.Point(749, 199)
        Me.CheckBox44.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox44.Name = "CheckBox44"
        Me.CheckBox44.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox44.TabIndex = 715
        Me.CheckBox44.UseVisualStyleBackColor = True
        Me.CheckBox44.Visible = False
        '
        'CheckBoxThyratronStatusBit13
        '
        Me.CheckBoxThyratronStatusBit13.AutoCheck = False
        Me.CheckBoxThyratronStatusBit13.AutoSize = True
        Me.CheckBoxThyratronStatusBit13.Location = New System.Drawing.Point(728, 241)
        Me.CheckBoxThyratronStatusBit13.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronStatusBit13.Name = "CheckBoxThyratronStatusBit13"
        Me.CheckBoxThyratronStatusBit13.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronStatusBit13.TabIndex = 714
        Me.CheckBoxThyratronStatusBit13.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronStatusBit11
        '
        Me.CheckBoxThyratronStatusBit11.AutoCheck = False
        Me.CheckBoxThyratronStatusBit11.AutoSize = True
        Me.CheckBoxThyratronStatusBit11.Location = New System.Drawing.Point(728, 213)
        Me.CheckBoxThyratronStatusBit11.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronStatusBit11.Name = "CheckBoxThyratronStatusBit11"
        Me.CheckBoxThyratronStatusBit11.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronStatusBit11.TabIndex = 713
        Me.CheckBoxThyratronStatusBit11.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronStatusBit12
        '
        Me.CheckBoxThyratronStatusBit12.AutoCheck = False
        Me.CheckBoxThyratronStatusBit12.AutoSize = True
        Me.CheckBoxThyratronStatusBit12.Location = New System.Drawing.Point(728, 227)
        Me.CheckBoxThyratronStatusBit12.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronStatusBit12.Name = "CheckBoxThyratronStatusBit12"
        Me.CheckBoxThyratronStatusBit12.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronStatusBit12.TabIndex = 712
        Me.CheckBoxThyratronStatusBit12.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronStatusBit10
        '
        Me.CheckBoxThyratronStatusBit10.AutoCheck = False
        Me.CheckBoxThyratronStatusBit10.AutoSize = True
        Me.CheckBoxThyratronStatusBit10.Location = New System.Drawing.Point(728, 199)
        Me.CheckBoxThyratronStatusBit10.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronStatusBit10.Name = "CheckBoxThyratronStatusBit10"
        Me.CheckBoxThyratronStatusBit10.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronStatusBit10.TabIndex = 711
        Me.CheckBoxThyratronStatusBit10.UseVisualStyleBackColor = True
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(582, 227)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(120, 13)
        Me.Label40.TabIndex = 710
        Me.Label40.Text = "Fwd Det A Temperature"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(582, 213)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(81, 13)
        Me.Label47.TabIndex = 709
        Me.Label47.Text = "Rev Detector B"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(582, 255)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(120, 13)
        Me.Label48.TabIndex = 708
        Me.Label48.Text = "Rev Det A Temperature"
        '
        'CheckBoxThyratronFaultBit13
        '
        Me.CheckBoxThyratronFaultBit13.AutoCheck = False
        Me.CheckBoxThyratronFaultBit13.AutoSize = True
        Me.CheckBoxThyratronFaultBit13.Location = New System.Drawing.Point(707, 241)
        Me.CheckBoxThyratronFaultBit13.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronFaultBit13.Name = "CheckBoxThyratronFaultBit13"
        Me.CheckBoxThyratronFaultBit13.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronFaultBit13.TabIndex = 707
        Me.CheckBoxThyratronFaultBit13.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronFaultBit11
        '
        Me.CheckBoxThyratronFaultBit11.AutoCheck = False
        Me.CheckBoxThyratronFaultBit11.AutoSize = True
        Me.CheckBoxThyratronFaultBit11.Location = New System.Drawing.Point(707, 213)
        Me.CheckBoxThyratronFaultBit11.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronFaultBit11.Name = "CheckBoxThyratronFaultBit11"
        Me.CheckBoxThyratronFaultBit11.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronFaultBit11.TabIndex = 706
        Me.CheckBoxThyratronFaultBit11.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronFaultBit12
        '
        Me.CheckBoxThyratronFaultBit12.AutoCheck = False
        Me.CheckBoxThyratronFaultBit12.AutoSize = True
        Me.CheckBoxThyratronFaultBit12.Location = New System.Drawing.Point(707, 227)
        Me.CheckBoxThyratronFaultBit12.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronFaultBit12.Name = "CheckBoxThyratronFaultBit12"
        Me.CheckBoxThyratronFaultBit12.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronFaultBit12.TabIndex = 705
        Me.CheckBoxThyratronFaultBit12.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronFaultBit10
        '
        Me.CheckBoxThyratronFaultBit10.AutoCheck = False
        Me.CheckBoxThyratronFaultBit10.AutoSize = True
        Me.CheckBoxThyratronFaultBit10.Location = New System.Drawing.Point(707, 199)
        Me.CheckBoxThyratronFaultBit10.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronFaultBit10.Name = "CheckBoxThyratronFaultBit10"
        Me.CheckBoxThyratronFaultBit10.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronFaultBit10.TabIndex = 704
        Me.CheckBoxThyratronFaultBit10.UseVisualStyleBackColor = True
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(582, 241)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(120, 13)
        Me.Label49.TabIndex = 703
        Me.Label49.Text = "Fwd Det B Temperature"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(582, 199)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(81, 13)
        Me.Label50.TabIndex = 702
        Me.Label50.Text = "Rev Detector A"
        '
        'CheckBox75
        '
        Me.CheckBox75.AutoCheck = False
        Me.CheckBox75.AutoSize = True
        Me.CheckBox75.Location = New System.Drawing.Point(749, 185)
        Me.CheckBox75.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox75.Name = "CheckBox75"
        Me.CheckBox75.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox75.TabIndex = 701
        Me.CheckBox75.UseVisualStyleBackColor = True
        Me.CheckBox75.Visible = False
        '
        'CheckBoxThyratronStatusBit9
        '
        Me.CheckBoxThyratronStatusBit9.AutoCheck = False
        Me.CheckBoxThyratronStatusBit9.AutoSize = True
        Me.CheckBoxThyratronStatusBit9.Location = New System.Drawing.Point(728, 185)
        Me.CheckBoxThyratronStatusBit9.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronStatusBit9.Name = "CheckBoxThyratronStatusBit9"
        Me.CheckBoxThyratronStatusBit9.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronStatusBit9.TabIndex = 700
        Me.CheckBoxThyratronStatusBit9.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronFaultBit9
        '
        Me.CheckBoxThyratronFaultBit9.AutoCheck = False
        Me.CheckBoxThyratronFaultBit9.AutoSize = True
        Me.CheckBoxThyratronFaultBit9.Location = New System.Drawing.Point(707, 185)
        Me.CheckBoxThyratronFaultBit9.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronFaultBit9.Name = "CheckBoxThyratronFaultBit9"
        Me.CheckBoxThyratronFaultBit9.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronFaultBit9.TabIndex = 699
        Me.CheckBoxThyratronFaultBit9.UseVisualStyleBackColor = True
        '
        'CheckBox78
        '
        Me.CheckBox78.AutoCheck = False
        Me.CheckBox78.AutoSize = True
        Me.CheckBox78.Location = New System.Drawing.Point(749, 171)
        Me.CheckBox78.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox78.Name = "CheckBox78"
        Me.CheckBox78.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox78.TabIndex = 698
        Me.CheckBox78.UseVisualStyleBackColor = True
        Me.CheckBox78.Visible = False
        '
        'CheckBox79
        '
        Me.CheckBox79.AutoCheck = False
        Me.CheckBox79.AutoSize = True
        Me.CheckBox79.Location = New System.Drawing.Point(749, 143)
        Me.CheckBox79.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox79.Name = "CheckBox79"
        Me.CheckBox79.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox79.TabIndex = 697
        Me.CheckBox79.UseVisualStyleBackColor = True
        Me.CheckBox79.Visible = False
        '
        'CheckBox80
        '
        Me.CheckBox80.AutoCheck = False
        Me.CheckBox80.AutoSize = True
        Me.CheckBox80.Location = New System.Drawing.Point(749, 157)
        Me.CheckBox80.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox80.Name = "CheckBox80"
        Me.CheckBox80.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox80.TabIndex = 696
        Me.CheckBox80.UseVisualStyleBackColor = True
        Me.CheckBox80.Visible = False
        '
        'CheckBox81
        '
        Me.CheckBox81.AutoCheck = False
        Me.CheckBox81.AutoSize = True
        Me.CheckBox81.Location = New System.Drawing.Point(749, 129)
        Me.CheckBox81.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox81.Name = "CheckBox81"
        Me.CheckBox81.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox81.TabIndex = 695
        Me.CheckBox81.UseVisualStyleBackColor = True
        Me.CheckBox81.Visible = False
        '
        'CheckBoxThyratronStatusBit8
        '
        Me.CheckBoxThyratronStatusBit8.AutoCheck = False
        Me.CheckBoxThyratronStatusBit8.AutoSize = True
        Me.CheckBoxThyratronStatusBit8.Location = New System.Drawing.Point(728, 171)
        Me.CheckBoxThyratronStatusBit8.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronStatusBit8.Name = "CheckBoxThyratronStatusBit8"
        Me.CheckBoxThyratronStatusBit8.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronStatusBit8.TabIndex = 694
        Me.CheckBoxThyratronStatusBit8.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronStatusBit6
        '
        Me.CheckBoxThyratronStatusBit6.AutoCheck = False
        Me.CheckBoxThyratronStatusBit6.AutoSize = True
        Me.CheckBoxThyratronStatusBit6.Location = New System.Drawing.Point(728, 143)
        Me.CheckBoxThyratronStatusBit6.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronStatusBit6.Name = "CheckBoxThyratronStatusBit6"
        Me.CheckBoxThyratronStatusBit6.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronStatusBit6.TabIndex = 693
        Me.CheckBoxThyratronStatusBit6.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronStatusBit7
        '
        Me.CheckBoxThyratronStatusBit7.AutoCheck = False
        Me.CheckBoxThyratronStatusBit7.AutoSize = True
        Me.CheckBoxThyratronStatusBit7.Location = New System.Drawing.Point(728, 157)
        Me.CheckBoxThyratronStatusBit7.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronStatusBit7.Name = "CheckBoxThyratronStatusBit7"
        Me.CheckBoxThyratronStatusBit7.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronStatusBit7.TabIndex = 692
        Me.CheckBoxThyratronStatusBit7.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronStatusBit5
        '
        Me.CheckBoxThyratronStatusBit5.AutoCheck = False
        Me.CheckBoxThyratronStatusBit5.AutoSize = True
        Me.CheckBoxThyratronStatusBit5.Location = New System.Drawing.Point(728, 129)
        Me.CheckBoxThyratronStatusBit5.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronStatusBit5.Name = "CheckBoxThyratronStatusBit5"
        Me.CheckBoxThyratronStatusBit5.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronStatusBit5.TabIndex = 691
        Me.CheckBoxThyratronStatusBit5.UseVisualStyleBackColor = True
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(582, 157)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(101, 13)
        Me.Label51.TabIndex = 690
        Me.Label51.Text = "Reverse Pwr Match"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(582, 143)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(99, 13)
        Me.Label52.TabIndex = 689
        Me.Label52.Text = "Forward Pwr Match"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(582, 185)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(81, 13)
        Me.Label53.TabIndex = 688
        Me.Label53.Text = "Fwd Detector B"
        '
        'CheckBoxThyratronFaultBit8
        '
        Me.CheckBoxThyratronFaultBit8.AutoCheck = False
        Me.CheckBoxThyratronFaultBit8.AutoSize = True
        Me.CheckBoxThyratronFaultBit8.Location = New System.Drawing.Point(707, 171)
        Me.CheckBoxThyratronFaultBit8.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronFaultBit8.Name = "CheckBoxThyratronFaultBit8"
        Me.CheckBoxThyratronFaultBit8.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronFaultBit8.TabIndex = 687
        Me.CheckBoxThyratronFaultBit8.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronFaultBit6
        '
        Me.CheckBoxThyratronFaultBit6.AutoCheck = False
        Me.CheckBoxThyratronFaultBit6.AutoSize = True
        Me.CheckBoxThyratronFaultBit6.Location = New System.Drawing.Point(707, 143)
        Me.CheckBoxThyratronFaultBit6.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronFaultBit6.Name = "CheckBoxThyratronFaultBit6"
        Me.CheckBoxThyratronFaultBit6.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronFaultBit6.TabIndex = 686
        Me.CheckBoxThyratronFaultBit6.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronFaultBit7
        '
        Me.CheckBoxThyratronFaultBit7.AutoCheck = False
        Me.CheckBoxThyratronFaultBit7.AutoSize = True
        Me.CheckBoxThyratronFaultBit7.Location = New System.Drawing.Point(707, 157)
        Me.CheckBoxThyratronFaultBit7.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronFaultBit7.Name = "CheckBoxThyratronFaultBit7"
        Me.CheckBoxThyratronFaultBit7.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronFaultBit7.TabIndex = 685
        Me.CheckBoxThyratronFaultBit7.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronFaultBit5
        '
        Me.CheckBoxThyratronFaultBit5.AutoCheck = False
        Me.CheckBoxThyratronFaultBit5.AutoSize = True
        Me.CheckBoxThyratronFaultBit5.Location = New System.Drawing.Point(707, 129)
        Me.CheckBoxThyratronFaultBit5.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronFaultBit5.Name = "CheckBoxThyratronFaultBit5"
        Me.CheckBoxThyratronFaultBit5.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronFaultBit5.TabIndex = 684
        Me.CheckBoxThyratronFaultBit5.UseVisualStyleBackColor = True
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(582, 171)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(81, 13)
        Me.Label54.TabIndex = 683
        Me.Label54.Text = "Fwd Detector A"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(582, 129)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(55, 13)
        Me.Label55.TabIndex = 682
        Me.Label55.Text = "CPU Fault"
        '
        'CheckBox90
        '
        Me.CheckBox90.AutoCheck = False
        Me.CheckBox90.AutoSize = True
        Me.CheckBox90.Location = New System.Drawing.Point(749, 115)
        Me.CheckBox90.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox90.Name = "CheckBox90"
        Me.CheckBox90.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox90.TabIndex = 681
        Me.CheckBox90.UseVisualStyleBackColor = True
        Me.CheckBox90.Visible = False
        '
        'CheckBoxThyratronStatusBit4
        '
        Me.CheckBoxThyratronStatusBit4.AutoCheck = False
        Me.CheckBoxThyratronStatusBit4.AutoSize = True
        Me.CheckBoxThyratronStatusBit4.Location = New System.Drawing.Point(728, 115)
        Me.CheckBoxThyratronStatusBit4.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronStatusBit4.Name = "CheckBoxThyratronStatusBit4"
        Me.CheckBoxThyratronStatusBit4.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronStatusBit4.TabIndex = 680
        Me.CheckBoxThyratronStatusBit4.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronFaultBit4
        '
        Me.CheckBoxThyratronFaultBit4.AutoCheck = False
        Me.CheckBoxThyratronFaultBit4.AutoSize = True
        Me.CheckBoxThyratronFaultBit4.Location = New System.Drawing.Point(707, 115)
        Me.CheckBoxThyratronFaultBit4.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronFaultBit4.Name = "CheckBoxThyratronFaultBit4"
        Me.CheckBoxThyratronFaultBit4.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronFaultBit4.TabIndex = 679
        Me.CheckBoxThyratronFaultBit4.UseVisualStyleBackColor = True
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(582, 32)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(54, 13)
        Me.Label56.TabIndex = 678
        Me.Label56.Text = "FAULTS"
        '
        'CheckBox93
        '
        Me.CheckBox93.AutoCheck = False
        Me.CheckBox93.AutoSize = True
        Me.CheckBox93.Location = New System.Drawing.Point(749, 101)
        Me.CheckBox93.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox93.Name = "CheckBox93"
        Me.CheckBox93.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox93.TabIndex = 677
        Me.CheckBox93.UseVisualStyleBackColor = True
        Me.CheckBox93.Visible = False
        '
        'CheckBox94
        '
        Me.CheckBox94.AutoCheck = False
        Me.CheckBox94.AutoSize = True
        Me.CheckBox94.Location = New System.Drawing.Point(749, 73)
        Me.CheckBox94.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox94.Name = "CheckBox94"
        Me.CheckBox94.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox94.TabIndex = 676
        Me.CheckBox94.UseVisualStyleBackColor = True
        Me.CheckBox94.Visible = False
        '
        'CheckBox95
        '
        Me.CheckBox95.AutoCheck = False
        Me.CheckBox95.AutoSize = True
        Me.CheckBox95.Location = New System.Drawing.Point(749, 87)
        Me.CheckBox95.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox95.Name = "CheckBox95"
        Me.CheckBox95.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox95.TabIndex = 675
        Me.CheckBox95.UseVisualStyleBackColor = True
        Me.CheckBox95.Visible = False
        '
        'CheckBox96
        '
        Me.CheckBox96.AutoCheck = False
        Me.CheckBox96.AutoSize = True
        Me.CheckBox96.Location = New System.Drawing.Point(749, 59)
        Me.CheckBox96.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox96.Name = "CheckBox96"
        Me.CheckBox96.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox96.TabIndex = 674
        Me.CheckBox96.UseVisualStyleBackColor = True
        Me.CheckBox96.Visible = False
        '
        'CheckBoxThyratronStatusBit3
        '
        Me.CheckBoxThyratronStatusBit3.AutoCheck = False
        Me.CheckBoxThyratronStatusBit3.AutoSize = True
        Me.CheckBoxThyratronStatusBit3.Location = New System.Drawing.Point(728, 101)
        Me.CheckBoxThyratronStatusBit3.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronStatusBit3.Name = "CheckBoxThyratronStatusBit3"
        Me.CheckBoxThyratronStatusBit3.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronStatusBit3.TabIndex = 673
        Me.CheckBoxThyratronStatusBit3.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronStatusBit1
        '
        Me.CheckBoxThyratronStatusBit1.AutoCheck = False
        Me.CheckBoxThyratronStatusBit1.AutoSize = True
        Me.CheckBoxThyratronStatusBit1.Location = New System.Drawing.Point(728, 73)
        Me.CheckBoxThyratronStatusBit1.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronStatusBit1.Name = "CheckBoxThyratronStatusBit1"
        Me.CheckBoxThyratronStatusBit1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronStatusBit1.TabIndex = 672
        Me.CheckBoxThyratronStatusBit1.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronStatusBit2
        '
        Me.CheckBoxThyratronStatusBit2.AutoCheck = False
        Me.CheckBoxThyratronStatusBit2.AutoSize = True
        Me.CheckBoxThyratronStatusBit2.Location = New System.Drawing.Point(728, 87)
        Me.CheckBoxThyratronStatusBit2.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronStatusBit2.Name = "CheckBoxThyratronStatusBit2"
        Me.CheckBoxThyratronStatusBit2.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronStatusBit2.TabIndex = 671
        Me.CheckBoxThyratronStatusBit2.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronStatusBit0
        '
        Me.CheckBoxThyratronStatusBit0.AutoCheck = False
        Me.CheckBoxThyratronStatusBit0.AutoSize = True
        Me.CheckBoxThyratronStatusBit0.Location = New System.Drawing.Point(728, 59)
        Me.CheckBoxThyratronStatusBit0.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronStatusBit0.Name = "CheckBoxThyratronStatusBit0"
        Me.CheckBoxThyratronStatusBit0.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronStatusBit0.TabIndex = 670
        Me.CheckBoxThyratronStatusBit0.UseVisualStyleBackColor = True
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(582, 87)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(108, 13)
        Me.Label57.TabIndex = 669
        Me.Label57.Text = "RF Amp Temperature"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(582, 73)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(64, 13)
        Me.Label58.TabIndex = 668
        Me.Label58.Text = "PS 2 Failure"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(582, 115)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(98, 13)
        Me.Label59.TabIndex = 667
        Me.Label59.Text = "Output Over Power"
        '
        'CheckBoxThyratronFaultBit3
        '
        Me.CheckBoxThyratronFaultBit3.AutoCheck = False
        Me.CheckBoxThyratronFaultBit3.AutoSize = True
        Me.CheckBoxThyratronFaultBit3.Location = New System.Drawing.Point(707, 101)
        Me.CheckBoxThyratronFaultBit3.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronFaultBit3.Name = "CheckBoxThyratronFaultBit3"
        Me.CheckBoxThyratronFaultBit3.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronFaultBit3.TabIndex = 666
        Me.CheckBoxThyratronFaultBit3.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronFaultBit1
        '
        Me.CheckBoxThyratronFaultBit1.AutoCheck = False
        Me.CheckBoxThyratronFaultBit1.AutoSize = True
        Me.CheckBoxThyratronFaultBit1.Location = New System.Drawing.Point(707, 73)
        Me.CheckBoxThyratronFaultBit1.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronFaultBit1.Name = "CheckBoxThyratronFaultBit1"
        Me.CheckBoxThyratronFaultBit1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronFaultBit1.TabIndex = 665
        Me.CheckBoxThyratronFaultBit1.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronFaultBit2
        '
        Me.CheckBoxThyratronFaultBit2.AutoCheck = False
        Me.CheckBoxThyratronFaultBit2.AutoSize = True
        Me.CheckBoxThyratronFaultBit2.Location = New System.Drawing.Point(707, 87)
        Me.CheckBoxThyratronFaultBit2.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronFaultBit2.Name = "CheckBoxThyratronFaultBit2"
        Me.CheckBoxThyratronFaultBit2.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronFaultBit2.TabIndex = 664
        Me.CheckBoxThyratronFaultBit2.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronFaultBit0
        '
        Me.CheckBoxThyratronFaultBit0.AutoCheck = False
        Me.CheckBoxThyratronFaultBit0.AutoSize = True
        Me.CheckBoxThyratronFaultBit0.Location = New System.Drawing.Point(707, 59)
        Me.CheckBoxThyratronFaultBit0.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronFaultBit0.Name = "CheckBoxThyratronFaultBit0"
        Me.CheckBoxThyratronFaultBit0.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronFaultBit0.TabIndex = 663
        Me.CheckBoxThyratronFaultBit0.UseVisualStyleBackColor = True
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(582, 101)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(95, 13)
        Me.Label62.TabIndex = 662
        Me.Label62.Text = "Output Power Low"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(582, 59)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(64, 13)
        Me.Label63.TabIndex = 661
        Me.Label63.Text = "PS 1 Failure"
        '
        'ButtonSetBaudRate
        '
        Me.ButtonSetBaudRate.Location = New System.Drawing.Point(707, 416)
        Me.ButtonSetBaudRate.Name = "ButtonSetBaudRate"
        Me.ButtonSetBaudRate.Size = New System.Drawing.Size(114, 23)
        Me.ButtonSetBaudRate.TabIndex = 841
        Me.ButtonSetBaudRate.Text = "Set Baud Rate"
        Me.ButtonSetBaudRate.UseVisualStyleBackColor = True
        '
        'TextBoxBaudRate
        '
        Me.TextBoxBaudRate.Location = New System.Drawing.Point(707, 390)
        Me.TextBoxBaudRate.Name = "TextBoxBaudRate"
        Me.TextBoxBaudRate.Size = New System.Drawing.Size(114, 20)
        Me.TextBoxBaudRate.TabIndex = 840
        '
        'LabelGUIVersion
        '
        Me.LabelGUIVersion.AutoSize = True
        Me.LabelGUIVersion.Location = New System.Drawing.Point(12, 283)
        Me.LabelGUIVersion.Name = "LabelGUIVersion"
        Me.LabelGUIVersion.Size = New System.Drawing.Size(64, 13)
        Me.LabelGUIVersion.TabIndex = 844
        Me.LabelGUIVersion.Text = "GUI Version"
        '
        'LabelMCUVersion
        '
        Me.LabelMCUVersion.AutoSize = True
        Me.LabelMCUVersion.Location = New System.Drawing.Point(12, 270)
        Me.LabelMCUVersion.Name = "LabelMCUVersion"
        Me.LabelMCUVersion.Size = New System.Drawing.Size(63, 13)
        Me.LabelMCUVersion.TabIndex = 848
        Me.LabelMCUVersion.Text = "McuVersion"
        '
        'LabelFwdBTemp
        '
        Me.LabelFwdBTemp.AutoSize = True
        Me.LabelFwdBTemp.Location = New System.Drawing.Point(383, 171)
        Me.LabelFwdBTemp.Name = "LabelFwdBTemp"
        Me.LabelFwdBTemp.Size = New System.Drawing.Size(10, 13)
        Me.LabelFwdBTemp.TabIndex = 853
        Me.LabelFwdBTemp.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(247, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 852
        Me.Label3.Text = "Temperature"
        '
        'LabelFwdBPower
        '
        Me.LabelFwdBPower.AutoSize = True
        Me.LabelFwdBPower.Location = New System.Drawing.Point(383, 158)
        Me.LabelFwdBPower.Name = "LabelFwdBPower"
        Me.LabelFwdBPower.Size = New System.Drawing.Size(10, 13)
        Me.LabelFwdBPower.TabIndex = 851
        Me.LabelFwdBPower.Text = "-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(247, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 850
        Me.Label6.Text = "Power"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(247, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 13)
        Me.Label7.TabIndex = 849
        Me.Label7.Text = "Forward Detector B"
        '
        'LabelRevBTemp
        '
        Me.LabelRevBTemp.AutoSize = True
        Me.LabelRevBTemp.Location = New System.Drawing.Point(383, 224)
        Me.LabelRevBTemp.Name = "LabelRevBTemp"
        Me.LabelRevBTemp.Size = New System.Drawing.Size(10, 13)
        Me.LabelRevBTemp.TabIndex = 863
        Me.LabelRevBTemp.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(247, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 862
        Me.Label5.Text = "Temperature"
        '
        'LabelRevBPower
        '
        Me.LabelRevBPower.AutoSize = True
        Me.LabelRevBPower.Location = New System.Drawing.Point(383, 211)
        Me.LabelRevBPower.Name = "LabelRevBPower"
        Me.LabelRevBPower.Size = New System.Drawing.Size(10, 13)
        Me.LabelRevBPower.TabIndex = 861
        Me.LabelRevBPower.Text = "-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(247, 211)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 860
        Me.Label9.Text = "Power"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(247, 198)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 13)
        Me.Label10.TabIndex = 859
        Me.Label10.Text = "Reverse Detector B"
        '
        'LabelRevATemp
        '
        Me.LabelRevATemp.AutoSize = True
        Me.LabelRevATemp.Location = New System.Drawing.Point(148, 224)
        Me.LabelRevATemp.Name = "LabelRevATemp"
        Me.LabelRevATemp.Size = New System.Drawing.Size(10, 13)
        Me.LabelRevATemp.TabIndex = 858
        Me.LabelRevATemp.Text = "-"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 224)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 13)
        Me.Label12.TabIndex = 857
        Me.Label12.Text = "Temperature"
        '
        'LabelRevAPower
        '
        Me.LabelRevAPower.AutoSize = True
        Me.LabelRevAPower.Location = New System.Drawing.Point(148, 211)
        Me.LabelRevAPower.Name = "LabelRevAPower"
        Me.LabelRevAPower.Size = New System.Drawing.Size(10, 13)
        Me.LabelRevAPower.TabIndex = 856
        Me.LabelRevAPower.Text = "-"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 211)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 13)
        Me.Label14.TabIndex = 855
        Me.Label14.Text = "Power"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 198)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(119, 13)
        Me.Label15.TabIndex = 854
        Me.Label15.Text = "Reverse Detector A"
        '
        'LabelTime
        '
        Me.LabelTime.AutoSize = True
        Me.LabelTime.Location = New System.Drawing.Point(12, 257)
        Me.LabelTime.Name = "LabelTime"
        Me.LabelTime.Size = New System.Drawing.Size(30, 13)
        Me.LabelTime.TabIndex = 864
        Me.LabelTime.Text = "Time"
        '
        'LabelTotalPwr
        '
        Me.LabelTotalPwr.AutoSize = True
        Me.LabelTotalPwr.Location = New System.Drawing.Point(148, 72)
        Me.LabelTotalPwr.Name = "LabelTotalPwr"
        Me.LabelTotalPwr.Size = New System.Drawing.Size(10, 13)
        Me.LabelTotalPwr.TabIndex = 868
        Me.LabelTotalPwr.Text = "-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 867
        Me.Label8.Text = "Forward Power"
        '
        'LabelPwrProg
        '
        Me.LabelPwrProg.AutoSize = True
        Me.LabelPwrProg.Location = New System.Drawing.Point(148, 47)
        Me.LabelPwrProg.Name = "LabelPwrProg"
        Me.LabelPwrProg.Size = New System.Drawing.Size(10, 13)
        Me.LabelPwrProg.TabIndex = 866
        Me.LabelPwrProg.Text = "-"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 47)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 13)
        Me.Label13.TabIndex = 865
        Me.Label13.Text = "Power Program"
        '
        'LabelRFAmpTemp
        '
        Me.LabelRFAmpTemp.AutoSize = True
        Me.LabelRFAmpTemp.Location = New System.Drawing.Point(148, 98)
        Me.LabelRFAmpTemp.Name = "LabelRFAmpTemp"
        Me.LabelRFAmpTemp.Size = New System.Drawing.Size(10, 13)
        Me.LabelRFAmpTemp.TabIndex = 870
        Me.LabelRFAmpTemp.Text = "-"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(12, 98)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 13)
        Me.Label17.TabIndex = 869
        Me.Label17.Text = "RF Amp Temp"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(250, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 23)
        Me.Button1.TabIndex = 871
        Me.Button1.Text = "Update All"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(250, 54)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(114, 23)
        Me.Button2.TabIndex = 872
        Me.Button2.Text = "Read State"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LabelDacOut
        '
        Me.LabelDacOut.AutoSize = True
        Me.LabelDacOut.Location = New System.Drawing.Point(148, 111)
        Me.LabelDacOut.Name = "LabelDacOut"
        Me.LabelDacOut.Size = New System.Drawing.Size(10, 13)
        Me.LabelDacOut.TabIndex = 874
        Me.LabelDacOut.Text = "-"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 111)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 13)
        Me.Label11.TabIndex = 873
        Me.Label11.Text = "PID DAC Out"
        '
        'LabelRevPwr
        '
        Me.LabelRevPwr.AutoSize = True
        Me.LabelRevPwr.Location = New System.Drawing.Point(148, 85)
        Me.LabelRevPwr.Name = "LabelRevPwr"
        Me.LabelRevPwr.Size = New System.Drawing.Size(10, 13)
        Me.LabelRevPwr.TabIndex = 876
        Me.LabelRevPwr.Text = "-"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 85)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 13)
        Me.Label16.TabIndex = 875
        Me.Label16.Text = "ReversePower"
        '
        'LabelTargetPower
        '
        Me.LabelTargetPower.AutoSize = True
        Me.LabelTargetPower.Location = New System.Drawing.Point(148, 60)
        Me.LabelTargetPower.Name = "LabelTargetPower"
        Me.LabelTargetPower.Size = New System.Drawing.Size(10, 13)
        Me.LabelTargetPower.TabIndex = 878
        Me.LabelTargetPower.Text = "-"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(12, 60)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 13)
        Me.Label18.TabIndex = 877
        Me.Label18.Text = "Target Power"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(247, 257)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 879
        Me.Label2.Text = "Debug Info"
        '
        'LabelScaleError
        '
        Me.LabelScaleError.AutoSize = True
        Me.LabelScaleError.Location = New System.Drawing.Point(383, 286)
        Me.LabelScaleError.Name = "LabelScaleError"
        Me.LabelScaleError.Size = New System.Drawing.Size(10, 13)
        Me.LabelScaleError.TabIndex = 883
        Me.LabelScaleError.Text = "-"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(247, 286)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(64, 13)
        Me.Label20.TabIndex = 882
        Me.Label20.Text = "Scale Errors"
        '
        'LabelOverReverseCount
        '
        Me.LabelOverReverseCount.AutoSize = True
        Me.LabelOverReverseCount.Location = New System.Drawing.Point(383, 273)
        Me.LabelOverReverseCount.Name = "LabelOverReverseCount"
        Me.LabelOverReverseCount.Size = New System.Drawing.Size(10, 13)
        Me.LabelOverReverseCount.TabIndex = 881
        Me.LabelOverReverseCount.Text = "-"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(247, 273)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(104, 13)
        Me.Label22.TabIndex = 880
        Me.Label22.Text = "Over Reverse Count"
        '
        'LabelLTC2656Errors
        '
        Me.LabelLTC2656Errors.AutoSize = True
        Me.LabelLTC2656Errors.Location = New System.Drawing.Point(383, 299)
        Me.LabelLTC2656Errors.Name = "LabelLTC2656Errors"
        Me.LabelLTC2656Errors.Size = New System.Drawing.Size(10, 13)
        Me.LabelLTC2656Errors.TabIndex = 885
        Me.LabelLTC2656Errors.Text = "-"
        '
        'Label20x
        '
        Me.Label20x.AutoSize = True
        Me.Label20x.Location = New System.Drawing.Point(247, 299)
        Me.Label20x.Name = "Label20x"
        Me.Label20x.Size = New System.Drawing.Size(81, 13)
        Me.Label20x.TabIndex = 884
        Me.Label20x.Text = "LTC2656 Errors"
        '
        'LabelWatch1
        '
        Me.LabelWatch1.AutoSize = True
        Me.LabelWatch1.Location = New System.Drawing.Point(383, 335)
        Me.LabelWatch1.Name = "LabelWatch1"
        Me.LabelWatch1.Size = New System.Drawing.Size(10, 13)
        Me.LabelWatch1.TabIndex = 887
        Me.LabelWatch1.Text = "-"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(247, 335)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(48, 13)
        Me.Label21.TabIndex = 886
        Me.Label21.Text = "Watch 1"
        '
        'LabelWatch2
        '
        Me.LabelWatch2.AutoSize = True
        Me.LabelWatch2.Location = New System.Drawing.Point(383, 348)
        Me.LabelWatch2.Name = "LabelWatch2"
        Me.LabelWatch2.Size = New System.Drawing.Size(10, 13)
        Me.LabelWatch2.TabIndex = 889
        Me.LabelWatch2.Text = "-"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(247, 348)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(48, 13)
        Me.Label24.TabIndex = 888
        Me.Label24.Text = "Watch 2"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'LabelWatch4
        '
        Me.LabelWatch4.AutoSize = True
        Me.LabelWatch4.Location = New System.Drawing.Point(383, 374)
        Me.LabelWatch4.Name = "LabelWatch4"
        Me.LabelWatch4.Size = New System.Drawing.Size(10, 13)
        Me.LabelWatch4.TabIndex = 893
        Me.LabelWatch4.Text = "-"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(247, 374)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(48, 13)
        Me.Label26.TabIndex = 892
        Me.Label26.Text = "Watch 4"
        '
        'LabelWatch3
        '
        Me.LabelWatch3.AutoSize = True
        Me.LabelWatch3.Location = New System.Drawing.Point(383, 361)
        Me.LabelWatch3.Name = "LabelWatch3"
        Me.LabelWatch3.Size = New System.Drawing.Size(10, 13)
        Me.LabelWatch3.TabIndex = 891
        Me.LabelWatch3.Text = "-"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(247, 361)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(48, 13)
        Me.Label29.TabIndex = 890
        Me.Label29.Text = "Watch 3"
        '
        'TextPowerLevel
        '
        Me.TextPowerLevel.Location = New System.Drawing.Point(422, 57)
        Me.TextPowerLevel.Name = "TextPowerLevel"
        Me.TextPowerLevel.Size = New System.Drawing.Size(114, 20)
        Me.TextPowerLevel.TabIndex = 894
        '
        'ButtonSetPwrLevel
        '
        Me.ButtonSetPwrLevel.Location = New System.Drawing.Point(422, 83)
        Me.ButtonSetPwrLevel.Name = "ButtonSetPwrLevel"
        Me.ButtonSetPwrLevel.Size = New System.Drawing.Size(114, 23)
        Me.ButtonSetPwrLevel.TabIndex = 895
        Me.ButtonSetPwrLevel.Text = "Set Power Level"
        Me.ButtonSetPwrLevel.UseVisualStyleBackColor = True
        '
        'ButtonReset
        '
        Me.ButtonReset.Location = New System.Drawing.Point(422, 112)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(114, 23)
        Me.ButtonReset.TabIndex = 896
        Me.ButtonReset.Text = "Fault Reset"
        Me.ButtonReset.UseVisualStyleBackColor = True
        '
        'TextBoxPCoeff
        '
        Me.TextBoxPCoeff.Location = New System.Drawing.Point(15, 336)
        Me.TextBoxPCoeff.Name = "TextBoxPCoeff"
        Me.TextBoxPCoeff.Size = New System.Drawing.Size(64, 20)
        Me.TextBoxPCoeff.TabIndex = 897
        '
        'TextBoxICoeff
        '
        Me.TextBoxICoeff.Location = New System.Drawing.Point(15, 361)
        Me.TextBoxICoeff.Name = "TextBoxICoeff"
        Me.TextBoxICoeff.Size = New System.Drawing.Size(64, 20)
        Me.TextBoxICoeff.TabIndex = 898
        '
        'TextBoxDCoeff
        '
        Me.TextBoxDCoeff.Location = New System.Drawing.Point(15, 387)
        Me.TextBoxDCoeff.Name = "TextBoxDCoeff"
        Me.TextBoxDCoeff.Size = New System.Drawing.Size(64, 20)
        Me.TextBoxDCoeff.TabIndex = 899
        '
        'ButtonWritePID
        '
        Me.ButtonWritePID.Location = New System.Drawing.Point(15, 442)
        Me.ButtonWritePID.Name = "ButtonWritePID"
        Me.ButtonWritePID.Size = New System.Drawing.Size(104, 23)
        Me.ButtonWritePID.TabIndex = 900
        Me.ButtonWritePID.Text = "Write New PID"
        Me.ButtonWritePID.UseVisualStyleBackColor = True
        '
        'ButtonReadPID
        '
        Me.ButtonReadPID.Location = New System.Drawing.Point(15, 413)
        Me.ButtonReadPID.Name = "ButtonReadPID"
        Me.ButtonReadPID.Size = New System.Drawing.Size(104, 23)
        Me.ButtonReadPID.TabIndex = 901
        Me.ButtonReadPID.Text = "Read PID"
        Me.ButtonReadPID.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(85, 338)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(14, 13)
        Me.Label19.TabIndex = 902
        Me.Label19.Text = "P"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(85, 364)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(10, 13)
        Me.Label23.TabIndex = 903
        Me.Label23.Text = "I"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(85, 390)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(15, 13)
        Me.Label25.TabIndex = 904
        Me.Label25.Text = "D"
        '
        'TextBoxStep
        '
        Me.TextBoxStep.Location = New System.Drawing.Point(422, 419)
        Me.TextBoxStep.Name = "TextBoxStep"
        Me.TextBoxStep.Size = New System.Drawing.Size(64, 20)
        Me.TextBoxStep.TabIndex = 905
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(503, 426)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(60, 13)
        Me.Label27.TabIndex = 906
        Me.Label27.Text = "Step Watts"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(503, 452)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(90, 13)
        Me.Label30.TabIndex = 908
        Me.Label30.Text = "Inverval Seconds"
        '
        'TextBoxInterval
        '
        Me.TextBoxInterval.Location = New System.Drawing.Point(422, 445)
        Me.TextBoxInterval.Name = "TextBoxInterval"
        Me.TextBoxInterval.Size = New System.Drawing.Size(64, 20)
        Me.TextBoxInterval.TabIndex = 907
        '
        'ButtonStartTest
        '
        Me.ButtonStartTest.Location = New System.Drawing.Point(422, 471)
        Me.ButtonStartTest.Name = "ButtonStartTest"
        Me.ButtonStartTest.Size = New System.Drawing.Size(104, 23)
        Me.ButtonStartTest.TabIndex = 909
        Me.ButtonStartTest.Text = "Start Test"
        Me.ButtonStartTest.UseVisualStyleBackColor = True
        '
        'Timer3
        '
        Me.Timer3.Interval = 60000
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(532, 471)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 23)
        Me.Button3.TabIndex = 910
        Me.Button3.Text = "Stop Test"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 520)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ButtonStartTest)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.TextBoxInterval)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.TextBoxStep)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.ButtonReadPID)
        Me.Controls.Add(Me.ButtonWritePID)
        Me.Controls.Add(Me.TextBoxDCoeff)
        Me.Controls.Add(Me.TextBoxICoeff)
        Me.Controls.Add(Me.TextBoxPCoeff)
        Me.Controls.Add(Me.ButtonReset)
        Me.Controls.Add(Me.ButtonSetPwrLevel)
        Me.Controls.Add(Me.TextPowerLevel)
        Me.Controls.Add(Me.LabelWatch4)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.LabelWatch3)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.LabelWatch2)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.LabelWatch1)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.LabelLTC2656Errors)
        Me.Controls.Add(Me.Label20x)
        Me.Controls.Add(Me.LabelScaleError)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.LabelOverReverseCount)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelTargetPower)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.LabelRevPwr)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.LabelDacOut)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LabelRFAmpTemp)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.LabelTotalPwr)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LabelPwrProg)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.LabelTime)
        Me.Controls.Add(Me.LabelRevBTemp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LabelRevBPower)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LabelRevATemp)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.LabelRevAPower)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.LabelFwdBTemp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabelFwdBPower)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LabelMCUVersion)
        Me.Controls.Add(Me.LabelGUIVersion)
        Me.Controls.Add(Me.ButtonSetBaudRate)
        Me.Controls.Add(Me.TextBoxBaudRate)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBoxThyratronStatusBit15)
        Me.Controls.Add(Me.CheckBoxThyratronFaultBit15)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.CheckBox8)
        Me.Controls.Add(Me.CheckBoxThyratronStatusBit14)
        Me.Controls.Add(Me.CheckBoxThyratronFaultBit14)
        Me.Controls.Add(Me.CheckBox29)
        Me.Controls.Add(Me.CheckBox30)
        Me.Controls.Add(Me.CheckBox33)
        Me.Controls.Add(Me.CheckBox44)
        Me.Controls.Add(Me.CheckBoxThyratronStatusBit13)
        Me.Controls.Add(Me.CheckBoxThyratronStatusBit11)
        Me.Controls.Add(Me.CheckBoxThyratronStatusBit12)
        Me.Controls.Add(Me.CheckBoxThyratronStatusBit10)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.Label47)
        Me.Controls.Add(Me.Label48)
        Me.Controls.Add(Me.CheckBoxThyratronFaultBit13)
        Me.Controls.Add(Me.CheckBoxThyratronFaultBit11)
        Me.Controls.Add(Me.CheckBoxThyratronFaultBit12)
        Me.Controls.Add(Me.CheckBoxThyratronFaultBit10)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.Label50)
        Me.Controls.Add(Me.CheckBox75)
        Me.Controls.Add(Me.CheckBoxThyratronStatusBit9)
        Me.Controls.Add(Me.CheckBoxThyratronFaultBit9)
        Me.Controls.Add(Me.CheckBox78)
        Me.Controls.Add(Me.CheckBox79)
        Me.Controls.Add(Me.CheckBox80)
        Me.Controls.Add(Me.CheckBox81)
        Me.Controls.Add(Me.CheckBoxThyratronStatusBit8)
        Me.Controls.Add(Me.CheckBoxThyratronStatusBit6)
        Me.Controls.Add(Me.CheckBoxThyratronStatusBit7)
        Me.Controls.Add(Me.CheckBoxThyratronStatusBit5)
        Me.Controls.Add(Me.Label51)
        Me.Controls.Add(Me.Label52)
        Me.Controls.Add(Me.Label53)
        Me.Controls.Add(Me.CheckBoxThyratronFaultBit8)
        Me.Controls.Add(Me.CheckBoxThyratronFaultBit6)
        Me.Controls.Add(Me.CheckBoxThyratronFaultBit7)
        Me.Controls.Add(Me.CheckBoxThyratronFaultBit5)
        Me.Controls.Add(Me.Label54)
        Me.Controls.Add(Me.Label55)
        Me.Controls.Add(Me.CheckBox90)
        Me.Controls.Add(Me.CheckBoxThyratronStatusBit4)
        Me.Controls.Add(Me.CheckBoxThyratronFaultBit4)
        Me.Controls.Add(Me.Label56)
        Me.Controls.Add(Me.CheckBox93)
        Me.Controls.Add(Me.CheckBox94)
        Me.Controls.Add(Me.CheckBox95)
        Me.Controls.Add(Me.CheckBox96)
        Me.Controls.Add(Me.CheckBoxThyratronStatusBit3)
        Me.Controls.Add(Me.CheckBoxThyratronStatusBit1)
        Me.Controls.Add(Me.CheckBoxThyratronStatusBit2)
        Me.Controls.Add(Me.CheckBoxThyratronStatusBit0)
        Me.Controls.Add(Me.Label57)
        Me.Controls.Add(Me.Label58)
        Me.Controls.Add(Me.Label59)
        Me.Controls.Add(Me.CheckBoxThyratronFaultBit3)
        Me.Controls.Add(Me.CheckBoxThyratronFaultBit1)
        Me.Controls.Add(Me.CheckBoxThyratronFaultBit2)
        Me.Controls.Add(Me.CheckBoxThyratronFaultBit0)
        Me.Controls.Add(Me.Label62)
        Me.Controls.Add(Me.Label63)
        Me.Controls.Add(Me.LabelState)
        Me.Controls.Add(Me.Label93)
        Me.Controls.Add(Me.LabelFwdATemp)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.LabelFwdAPower)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxComPorts)
        Me.Controls.Add(Me.LabelComMsg)
        Me.Name = "Form1"
        Me.Text = "Lund - Test GUI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SerialPortETM As System.IO.Ports.SerialPort
    Friend WithEvents LabelComMsg As System.Windows.Forms.Label
    Friend WithEvents ComboBoxComPorts As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelFwdAPower As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LabelFwdATemp As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents LabelState As System.Windows.Forms.Label
    Friend WithEvents Label93 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronStatusBit15 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronFaultBit15 As System.Windows.Forms.CheckBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronStatusBit14 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronFaultBit14 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox29 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox30 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox33 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox44 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronStatusBit13 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronStatusBit11 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronStatusBit12 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronStatusBit10 As System.Windows.Forms.CheckBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxThyratronFaultBit13 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronFaultBit11 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronFaultBit12 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronFaultBit10 As System.Windows.Forms.CheckBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents CheckBox75 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronStatusBit9 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronFaultBit9 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox78 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox79 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox80 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox81 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronStatusBit8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronStatusBit6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronStatusBit7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronStatusBit5 As System.Windows.Forms.CheckBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxThyratronFaultBit8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronFaultBit6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronFaultBit7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronFaultBit5 As System.Windows.Forms.CheckBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents CheckBox90 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronStatusBit4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronFaultBit4 As System.Windows.Forms.CheckBox
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents CheckBox93 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox94 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox95 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox96 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronStatusBit3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronStatusBit1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronStatusBit2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronStatusBit0 As System.Windows.Forms.CheckBox
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxThyratronFaultBit3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronFaultBit1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronFaultBit2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronFaultBit0 As System.Windows.Forms.CheckBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents ButtonSetBaudRate As System.Windows.Forms.Button
    Friend WithEvents TextBoxBaudRate As System.Windows.Forms.TextBox
    Friend WithEvents LabelGUIVersion As System.Windows.Forms.Label
    Friend WithEvents LabelMCUVersion As System.Windows.Forms.Label
    Friend WithEvents LabelFwdBTemp As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LabelFwdBPower As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LabelRevBTemp As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LabelRevBPower As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LabelRevATemp As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LabelRevAPower As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents LabelTime As System.Windows.Forms.Label
    Friend WithEvents LabelTotalPwr As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LabelPwrProg As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LabelRFAmpTemp As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LabelDacOut As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LabelRevPwr As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents LabelTargetPower As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LabelScaleError As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents LabelOverReverseCount As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents LabelLTC2656Errors As System.Windows.Forms.Label
    Friend WithEvents Label20x As System.Windows.Forms.Label
    Friend WithEvents LabelWatch1 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents LabelWatch2 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents LabelWatch4 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents LabelWatch3 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents TextPowerLevel As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSetPwrLevel As System.Windows.Forms.Button
    Friend WithEvents ButtonReset As System.Windows.Forms.Button
    Friend WithEvents TextBoxPCoeff As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxICoeff As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDCoeff As System.Windows.Forms.TextBox
    Friend WithEvents ButtonWritePID As System.Windows.Forms.Button
    Friend WithEvents ButtonReadPID As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents TextBoxStep As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents TextBoxInterval As System.Windows.Forms.TextBox
    Friend WithEvents ButtonStartTest As System.Windows.Forms.Button
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
