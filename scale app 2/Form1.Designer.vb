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
        Me.TabMain = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CheckBoxMuteAlarm = New System.Windows.Forms.CheckBox()
        Me.Timer_LBL = New System.Windows.Forms.Label()
        Me.LabelStream = New System.Windows.Forms.Label()
        Me.LabelWgt = New System.Windows.Forms.Label()
        Me.LabelScale = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ButtonSetLowLevel = New System.Windows.Forms.Button()
        Me.TextLowlabel = New System.Windows.Forms.TextBox()
        Me.CommConnectButton = New System.Windows.Forms.Button()
        Me.CommPortBox = New System.Windows.Forms.ComboBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabMain.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabMain
        '
        Me.TabMain.AccessibleName = ""
        Me.TabMain.Controls.Add(Me.TabPage1)
        Me.TabMain.Controls.Add(Me.TabPage2)
        Me.TabMain.Location = New System.Drawing.Point(12, 12)
        Me.TabMain.Name = "TabMain"
        Me.TabMain.SelectedIndex = 0
        Me.TabMain.Size = New System.Drawing.Size(344, 176)
        Me.TabMain.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.CheckBoxMuteAlarm)
        Me.TabPage1.Controls.Add(Me.Timer_LBL)
        Me.TabPage1.Controls.Add(Me.LabelStream)
        Me.TabPage1.Controls.Add(Me.LabelWgt)
        Me.TabPage1.Controls.Add(Me.LabelScale)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(336, 150)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Main"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'CheckBoxMuteAlarm
        '
        Me.CheckBoxMuteAlarm.AutoSize = True
        Me.CheckBoxMuteAlarm.Location = New System.Drawing.Point(206, 96)
        Me.CheckBoxMuteAlarm.Name = "CheckBoxMuteAlarm"
        Me.CheckBoxMuteAlarm.Size = New System.Drawing.Size(79, 17)
        Me.CheckBoxMuteAlarm.TabIndex = 5
        Me.CheckBoxMuteAlarm.Text = "Mute Alarm"
        Me.CheckBoxMuteAlarm.UseVisualStyleBackColor = True
        '
        'Timer_LBL
        '
        Me.Timer_LBL.AutoSize = True
        Me.Timer_LBL.Location = New System.Drawing.Point(36, 97)
        Me.Timer_LBL.Name = "Timer_LBL"
        Me.Timer_LBL.Size = New System.Drawing.Size(66, 13)
        Me.Timer_LBL.TabIndex = 3
        Me.Timer_LBL.Text = "Timer Status"
        '
        'LabelStream
        '
        Me.LabelStream.AutoSize = True
        Me.LabelStream.Location = New System.Drawing.Point(46, 125)
        Me.LabelStream.Name = "LabelStream"
        Me.LabelStream.Size = New System.Drawing.Size(91, 13)
        Me.LabelStream.TabIndex = 2
        Me.LabelStream.Text = "Serial Port Stream"
        '
        'LabelWgt
        '
        Me.LabelWgt.AutoSize = True
        Me.LabelWgt.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWgt.Location = New System.Drawing.Point(193, 14)
        Me.LabelWgt.Name = "LabelWgt"
        Me.LabelWgt.Size = New System.Drawing.Size(150, 73)
        Me.LabelWgt.TabIndex = 1
        Me.LabelWgt.Text = "Port"
        '
        'LabelScale
        '
        Me.LabelScale.AutoSize = True
        Me.LabelScale.BackColor = System.Drawing.Color.Transparent
        Me.LabelScale.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelScale.Location = New System.Drawing.Point(6, 14)
        Me.LabelScale.Name = "LabelScale"
        Me.LabelScale.Size = New System.Drawing.Size(167, 73)
        Me.LabelScale.TabIndex = 0
        Me.LabelScale.Text = "Com"
        Me.LabelScale.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ButtonSetLowLevel)
        Me.TabPage2.Controls.Add(Me.TextLowlabel)
        Me.TabPage2.Controls.Add(Me.CommConnectButton)
        Me.TabPage2.Controls.Add(Me.CommPortBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(336, 150)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Settings"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ButtonSetLowLevel
        '
        Me.ButtonSetLowLevel.Location = New System.Drawing.Point(169, 54)
        Me.ButtonSetLowLevel.Name = "ButtonSetLowLevel"
        Me.ButtonSetLowLevel.Size = New System.Drawing.Size(137, 23)
        Me.ButtonSetLowLevel.TabIndex = 6
        Me.ButtonSetLowLevel.Text = "Set Low Level Alarm"
        Me.ButtonSetLowLevel.UseVisualStyleBackColor = True
        '
        'TextLowlabel
        '
        Me.TextLowlabel.Location = New System.Drawing.Point(18, 54)
        Me.TextLowlabel.Name = "TextLowlabel"
        Me.TextLowlabel.Size = New System.Drawing.Size(145, 20)
        Me.TextLowlabel.TabIndex = 4
        '
        'CommConnectButton
        '
        Me.CommConnectButton.Location = New System.Drawing.Point(206, 27)
        Me.CommConnectButton.Name = "CommConnectButton"
        Me.CommConnectButton.Size = New System.Drawing.Size(100, 20)
        Me.CommConnectButton.TabIndex = 1
        Me.CommConnectButton.Text = "Connect"
        Me.CommConnectButton.UseVisualStyleBackColor = True
        '
        'CommPortBox
        '
        Me.CommPortBox.FormattingEnabled = True
        Me.CommPortBox.Location = New System.Drawing.Point(18, 27)
        Me.CommPortBox.Name = "CommPortBox"
        Me.CommPortBox.Size = New System.Drawing.Size(171, 21)
        Me.CommPortBox.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 201)
        Me.Controls.Add(Me.TabMain)
        Me.MaximumSize = New System.Drawing.Size(386, 240)
        Me.Name = "Form1"
        Me.Text = "Scale"
        Me.TabMain.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabMain As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents CommConnectButton As Button
    Friend WithEvents CommPortBox As ComboBox
    Friend WithEvents LabelScale As Label
    Friend WithEvents TextLowlabel As TextBox
    Friend WithEvents LabelWgt As Label
    Friend WithEvents LabelStream As Label
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer_LBL As Label
    Friend WithEvents CheckBoxMuteAlarm As CheckBox
    Friend WithEvents ButtonSetLowLevel As Button
End Class
