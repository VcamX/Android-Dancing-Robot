Public Class AndroidFigureControl
    Private RealTimeControlOpen As Boolean
    Private CommandControlOpen As Boolean
    Private CommandRealTimeControlOpen As Boolean
    Private CommandFileControlOpen As Boolean
    Private CommandMultiFileControlOpen As Boolean
    Private FigureConnected As Boolean

    Private Const LeftEyePin As Integer = 6
    Private Const RightEyePin As Integer = 7
    Private Const LeftArmPin As Integer = 2
    Private Const RightArmPin As Integer = 3
    Private Const HeadPin As Integer = 4
    Private Const BodyPin As Integer = 5

    Private Const FlagA As Integer = LeftArmPin
    Private Const FlagD As Integer = RightArmPin
    Private Const FlagW As Integer = HeadPin
    Private Const FlagS As Integer = BodyPin
    Private Const FlagQ As Integer = LeftEyePin
    Private Const FlagE As Integer = RightEyePin

    Private Const START_FLAG As String = "#START#"
    Private Const END_FLAG As String = "#END#"

    Private CommandFileName As String '命令文件名
    Private fsTemp As System.IO.StreamWriter
    Private sTempFileName As String

    Private MissionBeginTime As DateTime = Now

    Private MyThread As Threading.Thread '定义线程类

    Private Sub RealTimeControlButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RealTimeControlButton.Click
        If RealTimeControlOpen Then
            CommandControlButton.Enabled = True
            RealTimeControlGroupBox.Enabled = False
            RealTimeControlButton.Text = "打开实时控制"
        Else
            CommandControlButton.Enabled = False
            RealTimeControlGroupBox.Enabled = True
            RealTimeControlButton.Text = "关闭实时控制"

            InitialPinMode()
            InitialPosition(0)
        End If

        RealTimeControlOpen = Not RealTimeControlOpen
        UpdateConnectionEnable()
    End Sub

    Private Sub CommandControlButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandControlButton.Click
        If CommandControlOpen Then
            RealTimeControlButton.Enabled = True
            CommandControlGroupBox.Enabled = False
            CommandControlButton.Text = "打开命令控制"
        Else
            RealTimeControlButton.Enabled = False
            CommandControlGroupBox.Enabled = True
            CommandControlButton.Text = "关闭命令控制"

            InitialPinMode()
            InitialPosition(1)
        End If

        CommandControlOpen = Not CommandControlOpen
        UpdateConnectionEnable()
    End Sub

    '更新设备连接按钮
    Private Sub UpdateConnectionEnable()
        If RealTimeControlOpen Or CommandControlOpen Then
            ConnectToolStripButton.Enabled = False
        Else
            ConnectToolStripButton.Enabled = True
        End If
    End Sub

    Private Sub ConnectionToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConnectToolStripButton.Click
        If FigureConnected Then
            FirmataVB1.Disconnect()
            UpdateToolStrip()

            RealTimeControlButton.Enabled = False
            CommandControlButton.Enabled = False
        Else
            FirmataVB1.Connect(COMListToolStripComboBox.Text, CInt(BaudListToolStripComboBox.Text))
            FirmataVB1.QueryVersion()
            UpdateToolStrip()

            RealTimeControlButton.Enabled = True
            CommandControlButton.Enabled = True
            InfoGroupBox.Enabled = True
        End If
    End Sub

    '更新工具栏
    Private Sub UpdateToolStrip()
        If (COMListToolStripComboBox.Text <> "" And BaudListToolStripComboBox.Text <> "") And FirmataVB1.PortOpen() = False Then
            FigureConnected = False
            ConnectToolStripButton.Enabled = True
            ConnectToolStripButton.Text = "连接设备"
            ConnectionStatusToolStripLabel.Text = "设备未连接"
            COMListToolStripComboBox.Enabled = True
            BaudListToolStripComboBox.Enabled = True
        ElseIf FirmataVB1.PortOpen() = True Then
            FigureConnected = True
            ConnectToolStripButton.Enabled = True
            ConnectToolStripButton.Text = "断开设备"
            ' Need a property of FirmataVB to get port name in use
            ConnectionStatusToolStripLabel.Text = "设备" & FirmataVB1.PortName() & "已连接"
            COMListToolStripComboBox.Enabled = False
            BaudListToolStripComboBox.Enabled = False
        Else
            FigureConnected = False
            ConnectToolStripButton.Enabled = False
            ConnectToolStripButton.Text = "连接设备"
            ConnectionStatusToolStripLabel.Text = "设备未连接"
            COMListToolStripComboBox.Enabled = True
            BaudListToolStripComboBox.Enabled = True
        End If
    End Sub

    Private Sub CommandRealTimeControlButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandRealTimeControlButton.Click
        If CommandRealTimeControlOpen Then
            CommandFileControlButton.Enabled = True
            CommandMultiFileControlButton.Enabled = True
            CommandRealTimeControlGroupBox.Enabled = False
            CommandRealTimeControlButton.Text = "打开实时命令控制"
        Else
            CommandFileControlButton.Enabled = False
            CommandMultiFileControlButton.Enabled = False
            CommandRealTimeControlGroupBox.Enabled = True
            CommandRealTimeControlButton.Text = "关闭实时命令控制"
        End If

        CommandRealTimeControlOpen = Not CommandRealTimeControlOpen
        UpdateCommandControlEnable()
    End Sub

    Private Sub CommandFileControlButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandFileControlButton.Click
        If CommandFileControlOpen Then
            CommandRealTimeControlButton.Enabled = True
            CommandMultiFileControlButton.Enabled = True
            CommandFileControlGroupBox.Enabled = False
            CommandFileControlButton.Text = "打开文件命令控制"
        Else
            CommandRealTimeControlButton.Enabled = False
            CommandMultiFileControlButton.Enabled = False
            CommandFileControlGroupBox.Enabled = True
            CommandFileControlButton.Text = "关闭文件命令控制"

            fsTemp = Nothing
            sTempFileName = ""
        End If

        CommandFileControlOpen = Not CommandFileControlOpen
    End Sub

    '更新命令控制按钮
    Private Sub UpdateCommandControlEnable()
        If CommandRealTimeControlOpen Or CommandFileControlOpen Then

        End If
    End Sub

    '清除记录
    Private Sub ClrInfoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClrInfoButton.Click
        InfoTextBox.Text = ""
    End Sub

    Private Sub AndroidFigureControl_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If FirmataVB1.PortOpen Then
            FirmataVB1.Disconnect()
        End If
    End Sub

    '窗口载入
    Private Sub AndroidFigureControl_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadComList()
        LoadBaudList()
        UpdateToolStrip()
        CheckForIllegalCrossThreadCalls = False

    End Sub

    '初始化界面
    Public Sub InitialEnable()
        CommandControlOpen = False
        RealTimeControlOpen = False
        FigureConnected = False
        CommandRealTimeControlOpen = False
        CommandFileControlOpen = False
        CommandMultiFileControlOpen = False
    End Sub

    '载入串口列表
    Public Sub LoadComList()
        COMListToolStripComboBox.Items.AddRange(FirmataVB1.COMPortList())
        COMListToolStripComboBox.Text = Firmata.FirmataVB.DEFAULT_COM_PORT
        COMListToolStripComboBox.Text = FirmataVB1.COMPortList(FirmataVB1.COMPortList.Length - 1)
    End Sub

    '载入波特率列表
    Public Sub LoadBaudList()
        BaudListToolStripComboBox.Items.AddRange(FirmataVB1.CommonBaudRates())
        BaudListToolStripComboBox.Text = Firmata.FirmataVB.DEFAULT_BAUD_RATE
    End Sub

    Private Sub 退出ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 退出ToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub LeftEyeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeftEyeButton.Click
        EyeAction(LeftEyeButton, LeftEyePin)
    End Sub

    Private Sub RightEyeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RightEyeButton.Click
        EyeAction(RightEyeButton, RightEyePin)
    End Sub

    '眼睛动作
    Private Sub EyeAction(ByVal Button As Button, ByVal Pin As Integer)
        If Button.Text = "关闭" Then
            FirmataVB1.DigitalWrite(Pin, 0)
            Button.Text = "打开"
        Else
            FirmataVB1.DigitalWrite(Pin, 1)
            Button.Text = "关闭"
        End If
    End Sub

    '控制模式切换为实时控制时，恢复原有眼睛设置
    Private Sub EyeCheck(ByVal Button As Button, ByVal Pin As Integer)
        If Button.Text = "关闭" Then
            FirmataVB1.DigitalWrite(Pin, 1)
        Else
            FirmataVB1.DigitalWrite(Pin, 0)
        End If
    End Sub

    '引脚初始化
    Private Sub InitialPinMode()
        FirmataVB1.PinMode(LeftEyePin, Firmata.FirmataVB.OUTUPT)
        FirmataVB1.PinMode(RightEyePin, Firmata.FirmataVB.OUTUPT)
        FirmataVB1.PinMode(LeftArmPin, Firmata.FirmataVB.SERVO)
        FirmataVB1.PinMode(RightArmPin, Firmata.FirmataVB.SERVO)
        FirmataVB1.PinMode(HeadPin, Firmata.FirmataVB.SERVO)
        FirmataVB1.PinMode(BodyPin, Firmata.FirmataVB.SERVO)
    End Sub

    '部件位置初始化
    Private Sub InitialPosition(ByVal Mode As Integer)
        Dim RealTimeLeftArmPosition As Integer
        Dim RealTimeRightArmPosition As Integer
        Dim RealTimeBodyPosition As Integer
        Dim RealTimeHeadPosition As Integer

        If Mode = 0 Then
            RealTimeLeftArmPosition = LeftArmControlTrackBar.Value * 180 / LeftArmControlTrackBar.Maximum
            RealTimeRightArmPosition = 180 - RightArmControlTrackBar.Value * 180 / RightArmControlTrackBar.Maximum
            RealTimeHeadPosition = HeadControlTrackBar.Value * 180 / HeadControlTrackBar.Maximum
            RealTimeBodyPosition = BodyControlTrackBar.Value * 180 / BodyControlTrackBar.Maximum

            FirmataVB1.AnalogWrite(LeftArmPin, RealTimeLeftArmPosition)
            FirmataVB1.AnalogWrite(RightArmPin, RealTimeRightArmPosition)
            FirmataVB1.AnalogWrite(HeadPin, RealTimeHeadPosition)
            FirmataVB1.AnalogWrite(BodyPin, RealTimeBodyPosition)
            EyeCheck(LeftEyeButton, LeftEyePin)
            EyeCheck(RightEyeButton, RightEyePin)
        Else
            ResetPosition()
        End If
    End Sub

    Private Sub ResetPosition()
        ServoControl(LeftArmPin, 0)
        ServoControl(RightArmPin, 0)
        ServoControl(HeadPin, 90)
        ServoControl(BodyPin, 90)
        FirmataVB1.DigitalWrite(LeftEyePin, 0)
        FirmataVB1.DigitalWrite(RightEyePin, 0)
    End Sub

    Private Sub LeftArmControlTrackBar_Scroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles LeftArmControlTrackBar.Scroll
        Dim Value As Integer = LeftArmControlTrackBar.Value * 180 / LeftArmControlTrackBar.Maximum
        ServoControl(LeftArmPin, Value)
    End Sub

    Private Sub RightArmControlTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RightArmControlTrackBar.Scroll
        Dim Value As Integer = RightArmControlTrackBar.Value * 180 / RightArmControlTrackBar.Maximum
        ServoControl(RightArmPin, Value)
    End Sub

    Private Sub BodyControlTrackBar_Scroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles BodyControlTrackBar.Scroll
        Dim Value As Integer = BodyControlTrackBar.Value * 180 / BodyControlTrackBar.Maximum
        ServoControl(BodyPin, Value)
    End Sub

    Private Sub HeadControlTrackBar_Scroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles HeadControlTrackBar.Scroll
        Dim Value As Integer = HeadControlTrackBar.Value * 180 / HeadControlTrackBar.Maximum
        ServoControl(HeadPin, Value)
    End Sub

    Private Sub RealTimeCommandSendButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RealTimeCommandSendButton.Click
        SingleCommandProcess(Trim(RealTimeCommandControlTextBox.Text).Split) '去掉首尾空格，并分割命令符
        RealTimeCommandControlTextBox.Text = ""
    End Sub

    Private Sub ServoControl(ByVal Pin As Integer, ByVal Value As Integer)
        If Pin = RightArmPin Then
            FirmataVB1.AnalogWrite(Pin, 180 - Value)
        Else
            FirmataVB1.AnalogWrite(Pin, Value)
        End If
    End Sub

    '暂停动作
    Private Sub Delay(ByVal Timeout As Integer)
        Threading.Thread.Sleep(Timeout)
    End Sub

    '显示当前信息
    Private Sub AddInfo(ByVal Info As String)
        InfoTextBox.Text = InfoTextBox.Text & Info & vbCrLf
    End Sub

    '显示当前信息
    Private Sub AddInfo()
        InfoTextBox.Text = InfoTextBox.Text & vbCrLf
    End Sub

    '单动作处理
    Private Sub SingleActionProcess(ByVal Pin As Integer, ByVal Argv As String())
        Dim Timeout As Integer = 5
        Dim StepSize As Integer = 1
        Dim Repeat As Integer = 1
        Dim Beginangle As Integer = 0
        Dim Endangle As Integer = 0
        Dim Angle As Integer

        If Argv.Length > 1 Then
            Beginangle = Val(Argv(1))
        Else
            Exit Sub
        End If

        If Argv.Length > 2 Then
            Endangle = Val(Argv(2))
        Else
            Endangle = Beginangle
        End If

        If Argv.Length > 3 Then
            StepSize = Math.Abs(Val(Argv(3)))
            StepSize *= (Endangle - Beginangle) / Math.Abs(Endangle - Beginangle) '加上步长符号
        Else
            If Argv.Length = 3 Then
                StepSize = Endangle - Beginangle
            End If
        End If

        If Argv.Length > 4 Then
            Timeout = Val(Argv(4))
        Else
            If Argv.Length = 3 Then
                Timeout = Math.Abs((Endangle - Beginangle) * 1.1) '保证舵机有足够的时间移动角度位置
            End If
        End If

        If Argv.Length > 5 Then
            Repeat = Val(Argv(5))
        End If

        For j = 1 To Repeat
            For Angle = Beginangle To Endangle Step StepSize
                ServoControl(Pin, Angle)
                Threading.Thread.Sleep(Timeout)
            Next
        Next
    End Sub

    '单命令处理
    '舵机指令格式： 部件代号 初始角度 [结束角度 步长（绝对值） 间隔时间 重复次数]
    'LED指令格式： 部件代号 状态值
    Private Sub SingleCommandProcess(ByVal Argv() As String)
        Select Case Argv(0)
            Case "A", "a" '左臂
                SingleActionProcess(FlagA, Argv)
            Case "D", "d" '右臂
                SingleActionProcess(FlagD, Argv)
            Case "W", "w" '头
                SingleActionProcess(FlagW, Argv)
            Case "S", "s" '身
                SingleActionProcess(FlagS, Argv)
            Case "Q", "q" '左眼
                FirmataVB1.DigitalWrite(FlagQ, Val(Argv(1)))
            Case "E", "e" '右眼
                FirmataVB1.DigitalWrite(FlagE, Val(Argv(1)))
            Case "B", "b" '眼睛
                FirmataVB1.DigitalWrite(FlagQ, Val(Argv(1)))
                FirmataVB1.DigitalWrite(FlagE, Val(Argv(1)))
            Case "T", "t" '延时
                Delay(Val(Argv(1)))
            Case "R", "r" '恢复初始位置
                ResetPosition()
        End Select
    End Sub

    '多命令处理
    '舵机指令格式:
    ' * 时间间隔(ms) [重复次数]
    ' 部件代号 初始角度 [结束角度 步长（绝对值）]
    ' 部件代号 初始角度 [结束角度 步长（绝对值）]
    ' ……
    'LED闪烁指令格式：
    ' 部件代号 [初始状态]
    Private Sub MultiCommandProcess(ByVal MultiArgv() As String, ByVal MultiAgrc As Integer)
        Dim Timeout As Integer = 15
        Dim Repeat As Integer = 1
        Dim Pin(10) As Integer
        Dim BeginAngle(10) As Integer
        Dim EndAngle(10) As Integer
        Dim Angle(10) As Integer
        Dim StepSize(10) As Integer
        Dim ActionDone As Boolean
        Dim i, j As Integer

        Dim Argv() As String = Trim(MultiArgv(0)).Split
        If Argv(0) = "*" Then
            If Argv.Length > 1 Then
                Timeout = Val(Argv(1))
            End If
            If Argv.Length > 2 Then
                Repeat = Val(Argv(2))
            End If
        End If

        '命令解析
        For i = 1 To MultiAgrc - 1
            AddInfo(Trim(MultiArgv(i)))

            Argv = Trim(MultiArgv(i)).Split
            Select Case Argv(0)
                Case "A", "a"
                    Pin(i) = FlagA
                Case "D", "d"
                    Pin(i) = FlagD
                Case "W", "w"
                    Pin(i) = FlagW
                Case "S", "s"
                    Pin(i) = FlagS
                Case "Q", "q"
                    Pin(i) = FlagQ
                Case "E", "e"
                    Pin(i) = FlagE
            End Select

            If Pin(i) = FlagQ Or Pin(i) = FlagE Then
                If Argv.Length > 1 Then
                    BeginAngle(i) = Val(Argv(1))
                    If BeginAngle(i) > 0 Then
                        BeginAngle(i) = 1
                    Else
                        BeginAngle(i) = 0
                    End If
                Else
                    BeginAngle(i) = 0
                End If
                If Argv.Length > 2 Then
                    EndAngle(i) = Val(Argv(2))
                Else
                    EndAngle(i) = 250
                End If
            Else
                If Argv.Length > 1 Then
                    BeginAngle(i) = Val(Argv(1))
                End If
                If Argv.Length > 2 Then
                    EndAngle(i) = Val(Argv(2))
                Else
                    EndAngle(i) = BeginAngle(i)
                End If
                If Argv.Length > 3 Then
                    StepSize(i) = Math.Abs(Val(Argv(3)))
                    StepSize(i) *= (EndAngle(i) - BeginAngle(i)) / Math.Abs(EndAngle(i) - BeginAngle(i)) '加上步长符号
                Else
                    StepSize(i) = EndAngle(i) - BeginAngle(i)
                End If

                Angle(i) = BeginAngle(i) - StepSize(i)
            End If
        Next

        '传输命令
        For j = 1 To Repeat
            For i = 1 To MultiAgrc - 1
                If Pin(i) = FlagQ Or Pin(i) = FlagE Then
                    Angle(i) = BeginAngle(i)
                Else
                    Angle(i) = BeginAngle(i) - StepSize(i)
                End If
            Next

            While True
                ActionDone = True
                For i = 1 To MultiAgrc - 1
                    If Pin(i) = FlagQ Or Pin(i) = FlagE Then
                        Angle(i) = 1 - Angle(i)
                        FirmataVB1.DigitalWrite(Pin(i), Angle(i))
                    Else
                        If Math.Abs(EndAngle(i) - Angle(i)) >= Math.Abs(StepSize(i)) Then
                            ActionDone = False
                            Angle(i) += StepSize(i)
                            ServoControl(Pin(i), Angle(i))
                        End If
                    End If
                Next

                If ActionDone Then
                    Exit While
                Else
                    Threading.Thread.Sleep(Timeout) '挂起
                End If
            End While
        Next
    End Sub

    '= 数字 重复执行起始符，数字为重复次数
    '...
    '...
    '= * 重复执行终止符
    Private Sub FileCommandProcess(ByVal sender As System.Object)

        Dim CommdArray(), Commd() As String
        Dim Point As Integer = 0
        Dim ParsingMulti As Boolean = False
        Dim MultiCommd(10) As String
        Dim MultiCount As Integer = 0
        Dim Repeat As Integer = 0
        Dim RepeatS As Integer = 0
        Dim RewindAddress As Integer = 0

        '读取命令文件
        Try
            CommdArray = System.IO.File.ReadAllLines(CommandFileName)
        Catch ex As Exception
            MessageBox.Show("Problem file open" & vbCrLf & ex.ToString())
            UpdateFileCommandControlEnable()
            Exit Sub
        End Try

        While Point < CommdArray.Length
            If CommandMultiFileStopButton.Text = "继续" Or CommandFileStopButton.Text = "继续" Then
                AddInfo("#----- 暂停中 -----#")
                While CommandMultiFileStopButton.Text = "继续" Or CommandFileStopButton.Text = "继续"

                End While
            End If

            If Point = 0 Then
                If CommdArray(0) <> START_FLAG Then
                    MsgBox("不是有效的动作命令文件！", vbExclamation, "警告")
                    Exit Sub
                Else
                    MissionBeginTime = Now
                    AddInfo("******** 开始读取命令 ********")
                End If
            Else
                Commd = Trim(CommdArray(Point)).Split '分割当前行

                If ParsingMulti Then
                    If Commd(0) <> "#" Then
                        MultiCommd(MultiCount) = CommdArray(Point) '储存当前语句
                        MultiCount += 1
                    Else
                        ParsingMulti = False
                        MultiCommandProcess(MultiCommd, MultiCount) '处理多语句命令

                        AddInfo("#----- 同步运行命令结束 -----#")
                    End If
                Else
                    If Commd(0) <> "#" Then
                        If Commd(0) = "=" Then
                            If Commd(1) <> "*" Then
                                Repeat = Val(Commd(1)) '循环次数
                                RepeatS = Repeat
                                RewindAddress = Point '记录循环初始位置

                                AddInfo("#当前为第 1 次循环，共" & Str(RepeatS) & " 次循环#")
                                AddInfo("#--- 本次循环开始 ---#")
                            Else
                                Repeat -= 1
                                AddInfo("#--- 本次循环结束 ---#")

                                If Repeat > 0 Then
                                    Point = RewindAddress '重置循环初始位置

                                    AddInfo("#当前为第" & Str(RepeatS - Repeat + 1) & " 次循环，共" & Str(RepeatS) & " 次循环#")
                                    AddInfo("#--- 本次循环开始 ---#")
                                End If
                            End If
                        Else
                            SingleCommandProcess(Commd)

                            AddInfo(CommdArray(Point))
                        End If
                    Else '标记多命令处理开始
                        If Not ParsingMulti Then
                            ParsingMulti = True
                            MultiCount = 0

                            AddInfo("#----- 同步运行命令开始 -----#")
                        End If
                    End If
                End If
            End If

            Point += 1
        End While

        AddInfo("******** 读取命令结束 ********")
        AddInfo()
        AddInfo("运行时间：" & Now.Subtract(MissionBeginTime).TotalMilliseconds.ToString & " 毫秒")
        AddInfo()

        If sender.Equals(CommandFileBeginButton) Then
            UpdateFileCommandControlEnable()
        End If

        If sender.Equals(CommandMultiFileBeginButton) Then
            UpdateMultiFileCommandControlEnable()
        End If
    End Sub

    Private Sub FileCommandBeginButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandFileBeginButton.Click, CommandMultiFileBeginButton.Click
        MyThread = New Threading.Thread(AddressOf FileCommandProcess) '让线程类指向子程序

        If sender.Equals(CommandFileBeginButton) Then
            CommandFileBeginButton.Enabled = False
            CommandFileStopButton.Enabled = True
            CommandFileExitButton.Enabled = True

            CommandFileOpenButton.Enabled = False
            CommandFileControlButton.Enabled = False
            CommandControlButton.Enabled = False

            MyThread.Start(CommandFileBeginButton) '启动线程
        End If

        If sender.Equals(CommandMultiFileBeginButton) Then
            CommandMultiFileBeginButton.Enabled = False
            CommandMultiFileAddButton.Enabled = False
            CommandMultiFileDelButton.Enabled = False
            CommandMultiFileUpButton.Enabled = False
            CommandMultiFileDownButton.Enabled = False
            CommandMultiFileSaveButton.Enabled = False

            CommandMultiFileStopButton.Enabled = True
            CommandMultiFileExitButton.Enabled = True

            CommandMultiFileCombine()

            MyThread.Start(CommandMultiFileBeginButton) '启动线程
        End If
    End Sub

    Private Sub FileCommandOpenButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandFileOpenButton.Click
        OpenFileDialog1.Filter = "动作命令文件 (*.act)|*.act"
        OpenFileDialog1.RestoreDirectory = True
        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.DefaultExt = "act"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            FileCommandInfoLabel.Text = OpenFileDialog1.FileName
            CommandFileName = FileCommandInfoLabel.Text
        End If
    End Sub

    Private Sub InfoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InfoTextBox.TextChanged
        InfoTextBox.SelectionLength = 0
        InfoTextBox.SelectionStart = InfoTextBox.Text.Length
        InfoTextBox.ScrollToCaret()
    End Sub

    Private Sub COMListToolStripComboBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COMListToolStripComboBox.Click
        COMListToolStripComboBox.Items.Clear()
        COMListToolStripComboBox.Items.AddRange(FirmataVB1.COMPortList())
        COMListToolStripComboBox.Text = Firmata.FirmataVB.DEFAULT_COM_PORT
        COMListToolStripComboBox.Text = FirmataVB1.COMPortList(FirmataVB1.COMPortList.Length - 1)
    End Sub

    Private Sub FileCommandStopButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandFileStopButton.Click, CommandMultiFileStopButton.Click
        If sender.Text = "暂停" Then
            sender.Text = "继续"
        Else
            sender.Text = "暂停"
        End If
    End Sub

    Private Sub FileCommandExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandFileExitButton.Click, CommandMultiFileExitButton.Click
        Try
            MyThread.Abort()
        Catch ex As Exception

        End Try

        AddInfo("#----- 命令读取强行终止 -----#")
        AddInfo()
        AddInfo("运行时间：" & Now.Subtract(MissionBeginTime).TotalMilliseconds.ToString & " 毫秒")
        AddInfo()

        If sender.Equals(CommandFileExitButton) Then
            UpdateFileCommandControlEnable()
        End If

        If sender.Equals(CommandMultiFileExitButton) Then
            UpdateMultiFileCommandControlEnable()
        End If
    End Sub

    Private Sub UpdateMultiFileCommandControlEnable()
        CommandMultiFileStopButton.Text = "暂停"
        CommandMultiFileBeginButton.Enabled = True
        CommandMultiFileAddButton.Enabled = True
        CommandMultiFileDelButton.Enabled = True
        CommandMultiFileUpButton.Enabled = True
        CommandMultiFileDownButton.Enabled = True
        CommandMultiFileSaveButton.Enabled = True

        CommandMultiFileStopButton.Enabled = False
        CommandMultiFileExitButton.Enabled = False
    End Sub

    Private Sub UpdateFileCommandControlEnable()
        CommandFileStopButton.Text = "暂停"
        CommandFileStopButton.Enabled = False
        CommandFileExitButton.Enabled = False

        CommandFileBeginButton.Enabled = True
        CommandFileOpenButton.Enabled = True
        CommandFileControlButton.Enabled = True
        CommandControlButton.Enabled = True
    End Sub

    Private Sub CommandMultiFileCombine()
        sTempFileName = System.IO.Path.GetTempFileName()
        fsTemp = New System.IO.StreamWriter(sTempFileName, False)
        fsTemp.WriteLine(START_FLAG)

        Dim fString As String
        For Each fString In CommandMultiFileListBox.Items
            Dim Lines() As String
            Dim i As Integer

            Lines = System.IO.File.ReadAllLines(fString)
            If Lines(0) = START_FLAG Then
                i = 1
                While i < Lines.Length
                    If Lines(i) = END_FLAG Then
                        Exit While
                    End If
                    fsTemp.WriteLine(Lines(i))
                    i += 1
                End While
            End If
        Next

        fsTemp.Close()
        CommandFileName = sTempFileName
    End Sub

    Private Sub CommandMultiFileAddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandMultiFileAddButton.Click
        OpenFileDialog1.Filter = "动作命令文件 (*.act)|*.act"
        OpenFileDialog1.RestoreDirectory = True
        OpenFileDialog1.Multiselect = True
        OpenFileDialog1.DefaultExt = "act"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim sFile As String
            For Each sFile In OpenFileDialog1.FileNames
                CommandMultiFileListBox.Items.Add(sFile)
            Next
        End If
    End Sub

    Private Sub CommandMultiFileUpButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandMultiFileUpButton.Click
        Dim index As Integer
        Dim name As String
        For index = 0 To CommandMultiFileListBox.Items.Count - 1
            If CommandMultiFileListBox.SelectedIndices.Contains(index) Then
                If index = 0 Then
                    Exit For
                End If
                name = CommandMultiFileListBox.Items(index).ToString
                CommandMultiFileListBox.Items.RemoveAt(index)
                CommandMultiFileListBox.Items.Insert(index - 1, name)
                CommandMultiFileListBox.SelectedIndex = index - 1
            End If
        Next
    End Sub

    Private Sub CommandMultiFileDownButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandMultiFileDownButton.Click
        Dim index As Integer
        Dim name As String
        For index = CommandMultiFileListBox.Items.Count - 1 To 0 Step -1
            If CommandMultiFileListBox.SelectedIndices.Contains(index) Then
                If index = CommandMultiFileListBox.Items.Count - 1 Then
                    Exit For
                End If
                name = CommandMultiFileListBox.Items(index).ToString
                CommandMultiFileListBox.Items.RemoveAt(index)
                CommandMultiFileListBox.Items.Insert(index + 1, name)
                CommandMultiFileListBox.SelectedIndex = index + 1
            End If
        Next
    End Sub

    Private Sub CommandMultiFileDelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandMultiFileDelButton.Click
        While CommandMultiFileListBox.SelectedIndex <> -1
            CommandMultiFileListBox.Items.RemoveAt(CommandMultiFileListBox.SelectedIndex)
        End While
    End Sub

    Private Sub CommandMultiFileControlButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandMultiFileControlButton.Click
        If CommandMultiFileControlOpen Then
            CommandRealTimeControlButton.Enabled = True
            CommandFileControlButton.Enabled = True
            CommandMultiFileControlGroupBox.Enabled = False
            CommandMultiFileControlButton.Text = "打开多文件命令控制"
        Else
            CommandRealTimeControlButton.Enabled = False
            CommandFileControlButton.Enabled = False
            CommandMultiFileControlGroupBox.Enabled = True
            CommandMultiFileControlButton.Text = "关闭多文件命令控制"

            fsTemp = Nothing
            sTempFileName = ""
        End If

        CommandMultiFileControlOpen = Not CommandMultiFileControlOpen
    End Sub

    Private Sub CommandMultiFileSaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandMultiFileSaveButton.Click
        If CommandMultiFile2FileRadioButton.Checked Then
            CommandMultiFileCombine()

            SaveFileDialog1.InitialDirectory = "C:\"
            SaveFileDialog1.Filter = "动作命令文件 (*.act)|*.act"
            SaveFileDialog1.Title = "保存合并的动作命令文件"
            SaveFileDialog1.FileName = "action"
            If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                If fsTemp IsNot Nothing Then
                    System.IO.File.Copy(sTempFileName, SaveFileDialog1.FileName, True)
                End If
            End If
        End If
        If CommandMultiFile2ListRadioButton.Checked Then
            SaveFileDialog1.InitialDirectory = "C:\"
            SaveFileDialog1.Filter = "动作命令列表文件 (*.actl)|*.actl"
            SaveFileDialog1.Title = "保存动作命令列表文件"
            SaveFileDialog1.FileName = "actionlist"
            If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim myStream As New System.IO.StreamWriter(SaveFileDialog1.FileName, False)
                Dim tString As String
                For Each tString In CommandMultiFileListBox.Items
                    myStream.Write(tString & vbCrLf)
                Next
                myStream.Close()
            End If
        End If
    End Sub

    Private Sub SaveInfoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveInfoButton.Click
        SaveFileDialog1.InitialDirectory = "C:\"
        SaveFileDialog1.RestoreDirectory = True
        SaveFileDialog1.Filter = "文本文件 (*.txt)|*.txt"
        SaveFileDialog1.Title = "保存记录"
        SaveFileDialog1.FileName = "record"
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim myStream As New System.IO.StreamWriter(SaveFileDialog1.FileName, False)
            If Not (myStream Is Nothing) Then
                myStream.Write(InfoTextBox.Text)
                myStream.Close()
            End If
        End If
    End Sub

    Private Sub CommandMultiFileLoadButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandMultiFileLoadButton.Click
        OpenFileDialog1.Filter = "动作命令列表文件 (*.actl)|*.actl"
        OpenFileDialog1.RestoreDirectory = True
        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.DefaultExt = "actl"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim FilesArray = System.IO.File.ReadAllLines(OpenFileDialog1.FileName)
            Dim tString As String
            For Each tString In FilesArray
                CommandMultiFileListBox.Items.Add(tString)
            Next
        End If
    End Sub
End Class
