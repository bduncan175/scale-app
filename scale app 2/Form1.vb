Imports System
Imports System.IO.Ports


Public Class Form1
    Dim CommPort As String
    Dim ReceivedData As String = ""
    Dim NewReceivedData As String = ""
    Dim WeightString As String() = Nothing
    Dim Lowlevel As String = -1000


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = False
        CommPort = ""
        If My.Settings.Lowlevelalarm <> Nothing Then
            TextLowlabel.Text = My.Settings.Lowlevelalarm
            Lowlevel = TextLowlabel.Text
        End If

        For Each sp As String In My.Computer.Ports.SerialPortNames
            CommPortBox.Items.Add(sp)
        Next

    End Sub


    Private Sub CommPortBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CommPortBox.SelectedIndexChanged
        If (CommPortBox.SelectedItem <> "") Then
            CommPort = CommPortBox.SelectedItem
        End If
    End Sub

    Private Sub CommConnectButton_Click(sender As Object, e As EventArgs) Handles CommConnectButton.Click
        If (CommConnectButton.Text = "Connect") Then
            If (CommPort <> "") Then
                SerialPort1.Close()
                SerialPort1.PortName = CommPort
                SerialPort1.BaudRate = 9600
                SerialPort1.DataBits = 8
                SerialPort1.Parity = Parity.None
                SerialPort1.StopBits = StopBits.One
                SerialPort1.Handshake = Handshake.None
                SerialPort1.Encoding = System.Text.Encoding.Default
                SerialPort1.ReadTimeout = 10000
                SerialPort1.Open()
                CommConnectButton.Text = "Disconnect"
                Timer1.Enabled = True
                Timer_LBL.Text = "Timer: ON"

            Else
                MsgBox("Select a COM port first")
            End If
        Else
            SerialPort1.Close()
            CommConnectButton.Text = "Connect"
            Timer1.Enabled = False
            Timer_LBL.Text = "Timer: OFF"

        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabelStream.Text = ""
        ReceivedData = ReceiveSerialData()
        WeightString = ReceivedData.Split(",")
        If WeightString.Count() > 2 Then
            LabelWgt.Text = ReceivedData.Substring(ReceivedData.Length - 3)
            LabelScale.Text = RemoveWhitespace(ReceivedData.Substring(6, 6))

        End If

        LabelStream.Text = ReceivedData
        If Lowlevel <> "" Then
            If IsNumeric((Lowlevel)) Then
                If IsNumeric((LabelScale.Text)) Then
                    If Int(LabelScale.Text) < Int(Lowlevel) Then
                        LabelScale.BackColor = Color.Red
                        If Not CheckBoxMuteAlarm.Checked Then
                            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Exclamation)

                        End If
                    Else
                        LabelScale.BackColor = Color.Transparent

                    End If

                End If

            End If

        End If


    End Sub

    Function ReceiveSerialData() As String
        Dim Incoming As String
        Try
            Incoming = SerialPort1.ReadLine()
            If Incoming Is Nothing Then
                Return "nothing" & vbCrLf
            Else
                SerialPort1.DiscardInBuffer()
                Return Incoming
            End If
        Catch ex As TimeoutException
            Return "Error: Serial Port read timed out."
        End Try
    End Function
    Function RemoveWhitespace(fullString As String) As String
        Return New String(fullString.Where(Function(x) Not Char.IsWhiteSpace(x)).ToArray())
    End Function

    Private Sub ButtonSetLowLevel_Click(sender As Object, e As EventArgs) Handles ButtonSetLowLevel.Click
        If IsNumeric(TextLowlabel.Text) And TextLowlabel.Text IsNot Nothing Then
            Lowlevel = TextLowlabel.Text
            My.Settings.Lowlevelalarm = Int(Lowlevel)
        End If
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class