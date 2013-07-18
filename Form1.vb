'Imports System
'Imports System.IO
'Imports System.Collections

Public Class Form1
    Public ReturnData As UInt16
    Dim ComError As Boolean
    Dim Timer1Tic As Boolean = False
    Dim SerialCommandTransmitBuffer(9) As Byte
    Dim SerialCommandReceiveBuffer(9) As Byte
    Public Const SYNC_1 As Byte = &HF1
    Public Const SYNC_2 As Byte = &HF2
    Public Const SYNC_3_SEND As Byte = &HF3
    Public Const SYNC_3_RECIEVE As Byte = &HF4
    Public Const COMMAND_LENGTH As Byte = 9



    'Commands
    Public Const CMD_READ_RAM_VALUE As Byte = &H30

    Public Const CMD_READ_EEPROM_REGISTER As Byte = &H32

    Public Const CMD_SET_TARGET_POWER As Byte = &H34

    Public Const CMD_RESET As Byte = &H36

    Public Const CMD_SET_PID As Byte = &H38


    ' Ram Locations
    Public Const RAM_READ_STATE As Byte = &H1
    Public Const RAM_READ_VERSION As Byte = &H2

    Public Const RAM_READ_FORWARD_POWER_DETECTOR_A_TEMPERATURE As Byte = &H10
    Public Const RAM_READ_FORWARD_POWER_DETECTOR_A_POWER As Byte = &H11

    Public Const RAM_READ_FORWARD_POWER_DETECTOR_B_TEMPERATURE As Byte = &H18
    Public Const RAM_READ_FORWARD_POWER_DETECTOR_B_POWER As Byte = &H19

    Public Const RAM_READ_REVERSE_POWER_DETECTOR_A_TEMPERATURE As Byte = &H20
    Public Const RAM_READ_REVERSE_POWER_DETECTOR_A_POWER As Byte = &H21

    Public Const RAM_READ_REVERSE_POWER_DETECTOR_B_TEMPERATURE As Byte = &H28
    Public Const RAM_READ_REVERSE_POWER_DETECTOR_B_POWER As Byte = &H29

    Public Const RAM_READ_PROGRAM_POWER_LEVEL As Byte = &H30
    Public Const RAM_READ_RF_AMPLIFIER_TEMPERATURE As Byte = &H31
    Public Const RAM_READ_TOTAL_FORWARD_POWER As Byte = &H32
    Public Const RAM_READ_PID_DAC_OUTPUT As Byte = &H33
    Public Const RAM_READ_TOTAL_REVERSE_POWER As Byte = &H34
    Public Const RAM_READ_PID_POWER_TARGET As Byte = &H35

    Public Const RAM_READ_FAULT_REGISTER As Byte = &H40
    Public Const RAM_READ_FAULT_STATUS_REGISTER As Byte = &H41



    Public Const RAM_READ_OVER_REVERSE_COUNT As Byte = &H50
    Public Const RAM_READ_SCALE_ERRORS As Byte = &H51
    Public Const RAM_READ_LTC2656_ERRORS As Byte = &H52
    Public Const RAM_READ_GUI_DEBUG_1 As Byte = &H53
    Public Const RAM_READ_GUI_DEBUG_2 As Byte = &H54
    Public Const RAM_READ_GUI_DEBUG_3 As Byte = &H55
    Public Const RAM_READ_GUI_DEBUG_4 As Byte = &H56


    Public Const RAM_READ_PID_P_COEF As Byte = &H60
    Public Const RAM_READ_PID_I_COEF As Byte = &H61
    Public Const RAM_READ_PID_D_COEF As Byte = &H62







    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each sp As String In My.Computer.Ports.SerialPortNames
            ComboBoxComPorts.Items.Add(sp)
        Next

        TextBoxBaudRate.Text = My.Settings.SelectedBaudRate

        Try
            ComboBoxComPorts.SelectedText = My.Settings.SelectedComPortString
        Catch ex As Exception
            MsgBox("Please select a Valid Com Port")
        End Try

        If (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed) Then
            Dim verDeployed As System.Version = My.Application.Deployment.CurrentVersion
            LabelGUIVersion.Text = "GUI Version " & verDeployed.ToString
        Else
            LabelGUIVersion.Text = "GUI Version not Available in Debug Mode"
        End If

        LabelMCUVersion.Text = "PIC Version "

    End Sub


    Private Sub OpenSerialPortETM()
        Try
            If SerialPortETM.IsOpen Then
                SerialPortETM.Close()
            End If
        Catch ex As Exception
            LabelComMsg.Text = "Serial Port Open/Close Error"
            ComError = True
        End Try

        Try
            SerialPortETM.PortName = My.Settings.SelectedComPortString
            SerialPortETM.ReadTimeout = 100
            SerialPortETM.BaudRate = My.Settings.SelectedBaudRate

        Catch ex As Exception
            MsgBox("Please Select a valid Com Port")
        End Try

        Try
            SerialPortETM.Open()
        Catch ex As Exception
            LabelComMsg.Text = "Serial Port Failed to Open"
            ComError = True
        End Try
    End Sub

    Private Sub CloseSerialPortETM()
        Try
            SerialPortETM.Close()
        Catch ex As Exception
            LabelComMsg.Text = "Serial Port Failed to Close"
            ComError = True
        End Try
    End Sub

    Private Function CheckCRC() As Boolean
        Dim CrcCheck As UInt16 = 0
        Dim CRC As UInt16 = 0
        CrcCheck = Int(SerialCommandReceiveBuffer(0))
        CrcCheck = CrcCheck + Int(SerialCommandReceiveBuffer(1))
        CrcCheck = CrcCheck + Int(SerialCommandReceiveBuffer(2))
        CrcCheck = CrcCheck + Int(SerialCommandReceiveBuffer(3))
        CrcCheck = CrcCheck + Int(SerialCommandReceiveBuffer(4))
        CrcCheck = CrcCheck + Int(SerialCommandReceiveBuffer(5))
        CrcCheck = CrcCheck + Int(SerialCommandReceiveBuffer(6))
        CRC = Int(SerialCommandReceiveBuffer(7)) * 256 + Int(SerialCommandReceiveBuffer(8))
        If CrcCheck = CRC Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function SendAndValidateCommand(ByVal commandB As Byte, ByVal locationB As Byte, ByVal DataHB As Byte, ByVal DataLB As Byte) As Boolean
        Dim valid_command As Boolean = False
        Dim CheckSum As UInt16 = 0


        SerialCommandTransmitBuffer(0) = SYNC_1
        SerialCommandTransmitBuffer(1) = SYNC_2
        SerialCommandTransmitBuffer(2) = SYNC_3_SEND
        SerialCommandTransmitBuffer(3) = commandB
        SerialCommandTransmitBuffer(4) = DataHB
        SerialCommandTransmitBuffer(5) = DataLB
        SerialCommandTransmitBuffer(6) = locationB


        CheckSum = SYNC_1
        CheckSum = CheckSum + SYNC_2
        CheckSum = CheckSum + SYNC_3_SEND + commandB + DataHB + DataLB + locationB

        SerialCommandTransmitBuffer(7) = Int(CheckSum / 256)
        SerialCommandTransmitBuffer(8) = CheckSum Mod 256



        LabelComMsg.Text = "-"

        Try
            If SerialPortETM.IsOpen = False Then
                OpenSerialPortETM()
            End If
            SerialPortETM.Write(SerialCommandTransmitBuffer, 0, 9)
        Catch ex As Exception
            LabelComMsg.Text = "Serial Port Failed to Write Command Buffer"
            Return False
        End Try

        Try
            SerialCommandReceiveBuffer(0) = SerialPortETM.ReadByte
            SerialCommandReceiveBuffer(1) = SerialPortETM.ReadByte
            SerialCommandReceiveBuffer(2) = SerialPortETM.ReadByte
            SerialCommandReceiveBuffer(3) = SerialPortETM.ReadByte
            SerialCommandReceiveBuffer(4) = SerialPortETM.ReadByte
            SerialCommandReceiveBuffer(5) = SerialPortETM.ReadByte
            SerialCommandReceiveBuffer(6) = SerialPortETM.ReadByte
            SerialCommandReceiveBuffer(7) = SerialPortETM.ReadByte
            SerialCommandReceiveBuffer(8) = SerialPortETM.ReadByte

        Catch ex As Exception
            LabelComMsg.Text = "Serial Port Failed to Read Return"
            Return False
        End Try



        Try
            'TextBox1.Text = TransmitBuffer(3)
            'TextBox2.Text = TransmitBuffer(4)
            'TextBox3.Text = TransmitBuffer(5)
            'TextBox4.Text = TransmitBuffer(6)

            'TextBox5.Text = ReceiveBuffer(3)
            'TextBox6.Text = ReceiveBuffer(4)
            'TextBox7.Text = ReceiveBuffer(5)
            'TextBox8.Text = ReceiveBuffer(6)


            If SerialCommandReceiveBuffer(0) = SYNC_1 Then
                If SerialCommandReceiveBuffer(1) = SYNC_2 Then
                    If SerialCommandReceiveBuffer(2) = SYNC_3_RECIEVE Then
                        If CheckCRC() = True Then
                            valid_command = True
                            LabelComMsg.Text = "Message Sent/Received"
                            'A valid return was recieved.  Check what the responce was
                            If SerialCommandReceiveBuffer(3) <> SerialCommandTransmitBuffer(3) Then
                                'The pic was not able to process the command
                                If SerialCommandReceiveBuffer(3) = &H1 Then
                                    LabelComMsg.Text = "ETM Controller Responds - Unknown Command"
                                ElseIf SerialCommandReceiveBuffer(3) = &H22 Then
                                    LabelComMsg.Text = "ETM Controller Responds - Program Value out of Valid Range"
                                ElseIf SerialCommandReceiveBuffer(3) = &H23 Then
                                    LabelComMsg.Text = "ETM Controller Responds - EEPROM ERROR - Unable to set value"
                                Else
                                    LabelComMsg.Text = "ETM Controller Responce Error - " & SerialCommandReceiveBuffer(3)
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            If valid_command <> True Then
                LabelComMsg.Text = "Serial Port return data was not valid"
                SerialPortETM.Close()
            End If
        Catch ex As Exception
            LabelComMsg.Text = "Error processing Serial Port data"
            ComError = True
            Return 0
        End Try

        ReturnData = SerialCommandReceiveBuffer(4) * 256 + SerialCommandReceiveBuffer(5)
        Return valid_command
    End Function


    Private Sub ReadAllFromRam()
        'Read Control State
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_STATE, 0, 0) = True Then
            If ReturnData = &H1 Then
                LabelState.Text = "Start Up"
            ElseIf ReturnData = &H5 Then
                LabelState.Text = "Flash LEDs"
            ElseIf ReturnData = &H11 Then
                LabelState.Text = "RF Off"
            ElseIf ReturnData = &H21 Then
                LabelState.Text = "RF On"
            ElseIf ReturnData = &H25 Then
                LabelState.Text = "RF On Foldback"
            ElseIf ReturnData = &H31 Then
                LabelState.Text = "Fault - General"
            ElseIf ReturnData = &H35 Then
                LabelState.Text = "Fault - Over Temp"
            End If
        Else
            LabelState.Text = "error"
        End If


        ' Data for Forward Detector A
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_FORWARD_POWER_DETECTOR_A_TEMPERATURE, 0, 0) = True Then
            LabelFwdATemp.Text = Math.Round(((ReturnData / 10) - 273), 2) & " C"
        Else
            LabelFwdATemp.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_FORWARD_POWER_DETECTOR_A_POWER, 0, 0) = True Then
            LabelFwdAPower.Text = Math.Round((ReturnData / 100), 2) & " Watts"
        Else
            LabelFwdAPower.Text = "error"
        End If


        ' Data for Forward Detector B
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_FORWARD_POWER_DETECTOR_B_TEMPERATURE, 0, 0) = True Then
            LabelFwdBTemp.Text = Math.Round(((ReturnData / 10) - 273), 2) & " C"
        Else
            LabelFwdBTemp.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_FORWARD_POWER_DETECTOR_B_POWER, 0, 0) = True Then
            LabelFwdBPower.Text = Math.Round((ReturnData / 100), 2) & " Watts"
        Else
            LabelFwdBPower.Text = "error"
        End If



        ' Data for reverse Detector A
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_REVERSE_POWER_DETECTOR_A_TEMPERATURE, 0, 0) = True Then
            LabelRevATemp.Text = Math.Round(((ReturnData / 10) - 273), 2) & " C"
        Else
            LabelRevATemp.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_REVERSE_POWER_DETECTOR_A_POWER, 0, 0) = True Then
            LabelRevAPower.Text = Math.Round((ReturnData / 100), 2) & " Watts"
        Else
            LabelRevAPower.Text = "error"
        End If


        ' Data for reverse Detector B
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_REVERSE_POWER_DETECTOR_B_TEMPERATURE, 0, 0) = True Then
            LabelRevBTemp.Text = Math.Round(((ReturnData / 10) - 273), 2) & " C"
        Else
            LabelRevBTemp.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_REVERSE_POWER_DETECTOR_B_POWER, 0, 0) = True Then
            LabelRevBPower.Text = Math.Round((ReturnData / 100), 2) & " Watts"
        Else
            LabelRevBPower.Text = "error"
        End If


        ' Total Power
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_PID_POWER_TARGET, 0, 0) = True Then
            LabelTargetPower.Text = Math.Round((ReturnData / 100), 2) & " Watts"
        Else
            LabelTargetPower.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_PROGRAM_POWER_LEVEL, 0, 0) = True Then
            LabelPwrProg.Text = Math.Round((ReturnData / 100), 2) & " Watts"
        Else
            LabelPwrProg.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_TOTAL_FORWARD_POWER, 0, 0) = True Then
            LabelTotalPwr.Text = Math.Round((ReturnData / 100), 2) & " Watts"
        Else
            LabelTotalPwr.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_TOTAL_REVERSE_POWER, 0, 0) = True Then
            LabelRevPwr.Text = Math.Round((ReturnData / 100), 2) & " Watts"
        Else
            LabelRevPwr.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_RF_AMPLIFIER_TEMPERATURE, 0, 0) = True Then
            LabelRFAmpTemp.Text = Math.Round(((ReturnData / 10) - 273), 2) & " C"
        Else
            LabelRFAmpTemp.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_PID_DAC_OUTPUT, 0, 0) = True Then
            LabelDacOut.Text = Math.Round((ReturnData * 5 / 2 ^ 16), 5) & " V"
        Else
            LabelDacOut.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_VERSION, 0, 0) = True Then
            LabelMCUVersion.Text = "MCU Version = " & ReturnData
        Else
            LabelMCUVersion.Text = "Version Unknown"
        End If

        ' Debug Info
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_OVER_REVERSE_COUNT, 0, 0) = True Then
            LabelOverReverseCount.Text = ReturnData
        Else
            LabelOverReverseCount.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_SCALE_ERRORS, 0, 0) = True Then
            LabelScaleError.Text = ReturnData
        Else
            LabelScaleError.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_LTC2656_ERRORS, 0, 0) = True Then
            LabelLTC2656Errors.Text = ReturnData
        Else
            LabelLTC2656Errors.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_GUI_DEBUG_1, 0, 0) = True Then
            LabelWatch1.Text = ReturnData
        Else
            LabelWatch1.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_GUI_DEBUG_2, 0, 0) = True Then
            LabelWatch2.Text = ReturnData
        Else
            LabelWatch2.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_GUI_DEBUG_3, 0, 0) = True Then
            LabelWatch3.Text = ReturnData
        Else
            LabelWatch3.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_GUI_DEBUG_4, 0, 0) = True Then
            LabelWatch4.Text = ReturnData
        Else
            LabelWatch4.Text = "error"
        End If


        LabelTime.Text = DateTime.Now



    End Sub


    Private Sub ComboBoxComPorts_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxComPorts.SelectedIndexChanged
        Try
            My.Settings.SelectedComPortString = ComboBoxComPorts.SelectedItem.ToString

        Catch ex As Exception
            MsgBox("Please select a Valid Com Port")
        End Try
        Try
            OpenSerialPortETM()
        Catch ex As Exception
            MsgBox("Unable to open selected Com Port")
        End Try


    End Sub

    Private Sub ReadAllFaults()

        ' Thyratron Faults
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_FAULT_REGISTER, 0, 0) = True Then
            If (ReturnData And &H1) Then
                CheckBoxThyratronFaultBit0.Checked = True
            Else
                CheckBoxThyratronFaultBit0.Checked = False
            End If
            If (ReturnData And &H2) Then
                CheckBoxThyratronFaultBit1.Checked = True
            Else
                CheckBoxThyratronFaultBit1.Checked = False
            End If
            If (ReturnData And &H4) Then
                CheckBoxThyratronFaultBit2.Checked = True
            Else
                CheckBoxThyratronFaultBit2.Checked = False
            End If
            If (ReturnData And &H8) Then
                CheckBoxThyratronFaultBit3.Checked = True
            Else
                CheckBoxThyratronFaultBit3.Checked = False
            End If
            If (ReturnData And &H10) Then
                CheckBoxThyratronFaultBit4.Checked = True
            Else
                CheckBoxThyratronFaultBit4.Checked = False
            End If
            If (ReturnData And &H20) Then
                CheckBoxThyratronFaultBit5.Checked = True
            Else
                CheckBoxThyratronFaultBit5.Checked = False
            End If
            If (ReturnData And &H40) Then
                CheckBoxThyratronFaultBit6.Checked = True
            Else
                CheckBoxThyratronFaultBit6.Checked = False
            End If
            If (ReturnData And &H80) Then
                CheckBoxThyratronFaultBit7.Checked = True
            Else
                CheckBoxThyratronFaultBit7.Checked = False
            End If
            If (ReturnData And &H100) Then
                CheckBoxThyratronFaultBit8.Checked = True
            Else
                CheckBoxThyratronFaultBit8.Checked = False
            End If
            If (ReturnData And &H200) Then
                CheckBoxThyratronFaultBit9.Checked = True
            Else
                CheckBoxThyratronFaultBit9.Checked = False
            End If
            If (ReturnData And &H400) Then
                CheckBoxThyratronFaultBit10.Checked = True
            Else
                CheckBoxThyratronFaultBit10.Checked = False
            End If
            If (ReturnData And &H800) Then
                CheckBoxThyratronFaultBit11.Checked = True
            Else
                CheckBoxThyratronFaultBit11.Checked = False
            End If
            If (ReturnData And &H1000) Then
                CheckBoxThyratronFaultBit12.Checked = True
            Else
                CheckBoxThyratronFaultBit12.Checked = False
            End If
            If (ReturnData And &H2000) Then
                CheckBoxThyratronFaultBit13.Checked = True
            Else
                CheckBoxThyratronFaultBit13.Checked = False
            End If
            If (ReturnData And &H4000) Then
                CheckBoxThyratronFaultBit14.Checked = True
            Else
                CheckBoxThyratronFaultBit14.Checked = False
            End If
            If (ReturnData And &H8000) Then
                CheckBoxThyratronFaultBit15.Checked = True
            Else
                CheckBoxThyratronFaultBit15.Checked = False
            End If
        End If


        ' Thyratron Statuss
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_FAULT_STATUS_REGISTER, 0, 0) = True Then
            If (ReturnData And &H1) Then
                CheckBoxThyratronStatusBit0.Checked = True
            Else
                CheckBoxThyratronStatusBit0.Checked = False
            End If
            If (ReturnData And &H2) Then
                CheckBoxThyratronStatusBit1.Checked = True
            Else
                CheckBoxThyratronStatusBit1.Checked = False
            End If
            If (ReturnData And &H4) Then
                CheckBoxThyratronStatusBit2.Checked = True
            Else
                CheckBoxThyratronStatusBit2.Checked = False
            End If
            If (ReturnData And &H8) Then
                CheckBoxThyratronStatusBit3.Checked = True
            Else
                CheckBoxThyratronStatusBit3.Checked = False
            End If
            If (ReturnData And &H10) Then
                CheckBoxThyratronStatusBit4.Checked = True
            Else
                CheckBoxThyratronStatusBit4.Checked = False
            End If
            If (ReturnData And &H20) Then
                CheckBoxThyratronStatusBit5.Checked = True
            Else
                CheckBoxThyratronStatusBit5.Checked = False
            End If
            If (ReturnData And &H40) Then
                CheckBoxThyratronStatusBit6.Checked = True
            Else
                CheckBoxThyratronStatusBit6.Checked = False
            End If
            If (ReturnData And &H80) Then
                CheckBoxThyratronStatusBit7.Checked = True
            Else
                CheckBoxThyratronStatusBit7.Checked = False
            End If
            If (ReturnData And &H100) Then
                CheckBoxThyratronStatusBit8.Checked = True
            Else
                CheckBoxThyratronStatusBit8.Checked = False
            End If
            If (ReturnData And &H200) Then
                CheckBoxThyratronStatusBit9.Checked = True
            Else
                CheckBoxThyratronStatusBit9.Checked = False
            End If
            If (ReturnData And &H400) Then
                CheckBoxThyratronStatusBit10.Checked = True
            Else
                CheckBoxThyratronStatusBit10.Checked = False
            End If
            If (ReturnData And &H800) Then
                CheckBoxThyratronStatusBit11.Checked = True
            Else
                CheckBoxThyratronStatusBit11.Checked = False
            End If
            If (ReturnData And &H1000) Then
                CheckBoxThyratronStatusBit12.Checked = True
            Else
                CheckBoxThyratronStatusBit12.Checked = False
            End If
            If (ReturnData And &H2000) Then
                CheckBoxThyratronStatusBit13.Checked = True
            Else
                CheckBoxThyratronStatusBit13.Checked = False
            End If
            If (ReturnData And &H4000) Then
                CheckBoxThyratronStatusBit14.Checked = True
            Else
                CheckBoxThyratronStatusBit14.Checked = False
            End If
            If (ReturnData And &H8000) Then
                CheckBoxThyratronStatusBit15.Checked = True
            Else
                CheckBoxThyratronStatusBit15.Checked = False
            End If
        End If


    End Sub

    Private Sub WriteToLogFile()
        ' Dim filePath As String
        ' filePath = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "ETM_Lund_Log.csv")
        ' Dim file As System.IO.StreamWriter
        ' file = My.Computer.FileSystem.OpenTextFileWriter(filePath, True)
        ' file.Write(LabelTime.Text & " , ")
        ' file.Write(LabelState.Text & " , ")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ReadAllFaults()
        ReadAllFromRam()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        WriteToLogFile()
    End Sub

   

    Private Sub ButtonSetBaudRate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSetBaudRate.Click

        Try
            My.Settings.SelectedBaudRate = TextBoxBaudRate.Text
        Catch ex As Exception
            MsgBox("Baud Rate not a valid Number")
        End Try


        Try
            SerialPortETM.BaudRate = My.Settings.SelectedBaudRate
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CalibrationDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form2.Show()
        Form2.BringToFront()
    End Sub

    Private Sub MagnetSupplyCalibrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form3.Show()
        Form3.BringToFront()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ReadAllFaults()
        ReadAllFromRam()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Read Control State
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_STATE, 0, 0) = True Then
            If ReturnData = &H1 Then
                LabelState.Text = "Start Up"
            ElseIf ReturnData = &H5 Then
                LabelState.Text = "Flash LEDs"
            ElseIf ReturnData = &H11 Then
                LabelState.Text = "RF Off"
            ElseIf ReturnData = &H21 Then
                LabelState.Text = "RF On"
            ElseIf ReturnData = &H25 Then
                LabelState.Text = "RF On Foldback"
            ElseIf ReturnData = &H31 Then
                LabelState.Text = "Fault - General"
            ElseIf ReturnData = &H35 Then
                LabelState.Text = "Fault - Over Temp"
            End If
        Else
            LabelState.Text = "error"
        End If
    End Sub

    Private Sub ButtonSetPwrLevel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSetPwrLevel.Click
        Dim ProgramWord As UInt16
        Dim ProgramHB As Byte
        Dim ProgramLB As Byte
        ProgramWord = (TextPowerLevel.Text * 100)
        ProgramHB = Int(ProgramWord / 256)
        ProgramLB = ProgramWord Mod 256

        If SendAndValidateCommand(CMD_SET_TARGET_POWER, 0, ProgramHB, ProgramLB) = True Then
            ' the command Succeded
        Else
            MsgBox("Set Power Level Command Failed")
        End If
    End Sub

    Private Sub ButtonReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonReset.Click


        If SendAndValidateCommand(CMD_RESET, 0, 0, 0) = True Then
            ' the command Succeded
        Else
            MsgBox("Reset Command Failed")
        End If
    End Sub

    Private Sub ReadPID()
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_PID_P_COEF, 0, 0) = True Then
            TextBoxPCoeff.Text = Math.Round(ReturnData * 2 / 2 ^ 16, 5)
        Else
            TextBoxPCoeff.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_PID_I_COEF, 0, 0) = True Then
            TextBoxICoeff.Text = Math.Round(ReturnData * 2 / 2 ^ 16, 5)
        Else
            TextBoxICoeff.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_PID_D_COEF, 0, 0) = True Then
            TextBoxDCoeff.Text = Math.Round(ReturnData * 2 / 2 ^ 16, 5)
        Else
            TextBoxDCoeff.Text = "error"
        End If
    End Sub

    Private Sub ButtonReadPID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonReadPID.Click
        ReadPID()
    End Sub

    Private Sub ButtonWritePID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonWritePID.Click
        Dim data As Single
        Dim ProgramWord As UInt16
        Dim ProgramHB As Byte
        Dim ProgramLB As Byte

        data = TextBoxPCoeff.Text
        If data > 0.99 Then
            data = 0.99
        End If
        If data < 0 Then
            data = 0
        End If
        ProgramWord = (data * 2 ^ 15)
        ProgramHB = Int(ProgramWord / 256)
        ProgramLB = ProgramWord Mod 256
        SendAndValidateCommand(CMD_SET_PID, RAM_READ_PID_P_COEF, ProgramHB, ProgramLB)

        data = TextBoxICoeff.Text
        If data > 0.99 Then
            data = 0.99
        End If
        If data < 0 Then
            data = 0
        End If
        ProgramWord = (data * 2 ^ 15)
        ProgramHB = Int(ProgramWord / 256)
        ProgramLB = ProgramWord Mod 256
        SendAndValidateCommand(CMD_SET_PID, RAM_READ_PID_I_COEF, ProgramHB, ProgramLB)

        data = TextBoxDCoeff.Text
        If data > 0.99 Then
            data = 0.99
        End If
        If data < 0 Then
            data = 0
        End If
        ProgramWord = (data * 2 ^ 15)
        ProgramHB = Int(ProgramWord / 256)
        ProgramLB = ProgramWord Mod 256
        SendAndValidateCommand(CMD_SET_PID, RAM_READ_PID_D_COEF, ProgramHB, ProgramLB)

        ReadPID()

    End Sub
End Class
