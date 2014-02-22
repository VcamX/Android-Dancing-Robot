<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AndroidFigureControl
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AndroidFigureControl))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ConnectionToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ComListToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.COMListToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.BaudListToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.BaudListToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.ConnectToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ConnectionStatusToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.文件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.帮助ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.关于ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RealTimeControlGroupBox = New System.Windows.Forms.GroupBox()
        Me.HeadBodyControlCheckBox = New System.Windows.Forms.CheckBox()
        Me.EyesControlCheckBox = New System.Windows.Forms.CheckBox()
        Me.ArmsControlCheckBox = New System.Windows.Forms.CheckBox()
        Me.RightEyeButton = New System.Windows.Forms.Button()
        Me.RightEyeLabel = New System.Windows.Forms.Label()
        Me.LeftEyeButton = New System.Windows.Forms.Button()
        Me.LeftEyeLabel = New System.Windows.Forms.Label()
        Me.RightArmControlTrackBar = New System.Windows.Forms.TrackBar()
        Me.LeftArmControlTrackBar = New System.Windows.Forms.TrackBar()
        Me.RightArmLabel = New System.Windows.Forms.Label()
        Me.LeftArmLabel = New System.Windows.Forms.Label()
        Me.BodyControlTrackBar = New System.Windows.Forms.TrackBar()
        Me.BodyLabel = New System.Windows.Forms.Label()
        Me.HeadControlTrackBar = New System.Windows.Forms.TrackBar()
        Me.HeadLabel = New System.Windows.Forms.Label()
        Me.InfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.SaveInfoButton = New System.Windows.Forms.Button()
        Me.InfoTextBox = New System.Windows.Forms.TextBox()
        Me.ClrInfoButton = New System.Windows.Forms.Button()
        Me.CommandControlGroupBox = New System.Windows.Forms.GroupBox()
        Me.CommandMultiFileControlGroupBox = New System.Windows.Forms.GroupBox()
        Me.CommandMultiFileSaveButton = New System.Windows.Forms.Button()
        Me.CommandMultiFileDownButton = New System.Windows.Forms.Button()
        Me.CommandMultiFileUpButton = New System.Windows.Forms.Button()
        Me.CommandMultiFileDelButton = New System.Windows.Forms.Button()
        Me.CommandMultiFileAddButton = New System.Windows.Forms.Button()
        Me.CommandMultiFileExitButton = New System.Windows.Forms.Button()
        Me.CommandMultiFileStopButton = New System.Windows.Forms.Button()
        Me.CommandMultiFileBeginButton = New System.Windows.Forms.Button()
        Me.CommandMultiFileListBox = New System.Windows.Forms.ListBox()
        Me.CommandMultiFileControlButton = New System.Windows.Forms.Button()
        Me.CommandFileControlGroupBox = New System.Windows.Forms.GroupBox()
        Me.CommandFileExitButton = New System.Windows.Forms.Button()
        Me.CommandFileStopButton = New System.Windows.Forms.Button()
        Me.CommandFileBeginButton = New System.Windows.Forms.Button()
        Me.FileCommandInfoLabel = New System.Windows.Forms.Label()
        Me.CommandFileOpenButton = New System.Windows.Forms.Button()
        Me.CommandRealTimeControlButton = New System.Windows.Forms.Button()
        Me.CommandRealTimeControlGroupBox = New System.Windows.Forms.GroupBox()
        Me.RealTimeCommandControlTextBox = New System.Windows.Forms.TextBox()
        Me.RealTimeCommandSendButton = New System.Windows.Forms.Button()
        Me.CommandFileControlButton = New System.Windows.Forms.Button()
        Me.RealTimeControlButton = New System.Windows.Forms.Button()
        Me.CommandControlButton = New System.Windows.Forms.Button()
        Me.FirmataVB1 = New Firmata.FirmataVB(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.CommandMultiFileLoadButton = New System.Windows.Forms.Button()
        Me.CommandMultiFile2ListRadioButton = New System.Windows.Forms.RadioButton()
        Me.CommandMultiFile2FileRadioButton = New System.Windows.Forms.RadioButton()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.RealTimeControlGroupBox.SuspendLayout()
        CType(Me.RightArmControlTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftArmControlTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BodyControlTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeadControlTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InfoGroupBox.SuspendLayout()
        Me.CommandControlGroupBox.SuspendLayout()
        Me.CommandMultiFileControlGroupBox.SuspendLayout()
        Me.CommandFileControlGroupBox.SuspendLayout()
        Me.CommandRealTimeControlGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConnectionToolStripLabel, Me.ToolStripSeparator3, Me.ComListToolStripLabel, Me.COMListToolStripComboBox, Me.BaudListToolStripLabel, Me.BaudListToolStripComboBox, Me.ConnectToolStripButton, Me.ToolStripSeparator1, Me.ConnectionStatusToolStripLabel})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 25)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(713, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ConnectionToolStripLabel
        '
        Me.ConnectionToolStripLabel.Name = "ConnectionToolStripLabel"
        Me.ConnectionToolStripLabel.Size = New System.Drawing.Size(68, 22)
        Me.ConnectionToolStripLabel.Text = "设备连接："
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ComListToolStripLabel
        '
        Me.ComListToolStripLabel.Name = "ComListToolStripLabel"
        Me.ComListToolStripLabel.Size = New System.Drawing.Size(56, 22)
        Me.ComListToolStripLabel.Text = "串口号："
        '
        'COMListToolStripComboBox
        '
        Me.COMListToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.COMListToolStripComboBox.Name = "COMListToolStripComboBox"
        Me.COMListToolStripComboBox.Size = New System.Drawing.Size(121, 25)
        '
        'BaudListToolStripLabel
        '
        Me.BaudListToolStripLabel.Name = "BaudListToolStripLabel"
        Me.BaudListToolStripLabel.Size = New System.Drawing.Size(56, 22)
        Me.BaudListToolStripLabel.Text = "波特率："
        '
        'BaudListToolStripComboBox
        '
        Me.BaudListToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BaudListToolStripComboBox.Name = "BaudListToolStripComboBox"
        Me.BaudListToolStripComboBox.Size = New System.Drawing.Size(121, 25)
        '
        'ConnectToolStripButton
        '
        Me.ConnectToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ConnectToolStripButton.Image = CType(resources.GetObject("ConnectToolStripButton.Image"), System.Drawing.Image)
        Me.ConnectToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ConnectToolStripButton.Name = "ConnectToolStripButton"
        Me.ConnectToolStripButton.Size = New System.Drawing.Size(60, 22)
        Me.ConnectToolStripButton.Text = "连接设备"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ConnectionStatusToolStripLabel
        '
        Me.ConnectionStatusToolStripLabel.Name = "ConnectionStatusToolStripLabel"
        Me.ConnectionStatusToolStripLabel.Size = New System.Drawing.Size(68, 22)
        Me.ConnectionStatusToolStripLabel.Text = "设备未连接"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.文件ToolStripMenuItem, Me.帮助ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(713, 25)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '文件ToolStripMenuItem
        '
        Me.文件ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.退出ToolStripMenuItem})
        Me.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem"
        Me.文件ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.文件ToolStripMenuItem.Text = "文件"
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.退出ToolStripMenuItem.Text = "退出"
        '
        '帮助ToolStripMenuItem
        '
        Me.帮助ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.关于ToolStripMenuItem})
        Me.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem"
        Me.帮助ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.帮助ToolStripMenuItem.Text = "帮助"
        '
        '关于ToolStripMenuItem
        '
        Me.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem"
        Me.关于ToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.关于ToolStripMenuItem.Text = "关于"
        '
        'RealTimeControlGroupBox
        '
        Me.RealTimeControlGroupBox.Controls.Add(Me.HeadBodyControlCheckBox)
        Me.RealTimeControlGroupBox.Controls.Add(Me.EyesControlCheckBox)
        Me.RealTimeControlGroupBox.Controls.Add(Me.ArmsControlCheckBox)
        Me.RealTimeControlGroupBox.Controls.Add(Me.RightEyeButton)
        Me.RealTimeControlGroupBox.Controls.Add(Me.RightEyeLabel)
        Me.RealTimeControlGroupBox.Controls.Add(Me.LeftEyeButton)
        Me.RealTimeControlGroupBox.Controls.Add(Me.LeftEyeLabel)
        Me.RealTimeControlGroupBox.Controls.Add(Me.RightArmControlTrackBar)
        Me.RealTimeControlGroupBox.Controls.Add(Me.LeftArmControlTrackBar)
        Me.RealTimeControlGroupBox.Controls.Add(Me.RightArmLabel)
        Me.RealTimeControlGroupBox.Controls.Add(Me.LeftArmLabel)
        Me.RealTimeControlGroupBox.Controls.Add(Me.BodyControlTrackBar)
        Me.RealTimeControlGroupBox.Controls.Add(Me.BodyLabel)
        Me.RealTimeControlGroupBox.Controls.Add(Me.HeadControlTrackBar)
        Me.RealTimeControlGroupBox.Controls.Add(Me.HeadLabel)
        Me.RealTimeControlGroupBox.Enabled = False
        Me.RealTimeControlGroupBox.Location = New System.Drawing.Point(11, 87)
        Me.RealTimeControlGroupBox.Name = "RealTimeControlGroupBox"
        Me.RealTimeControlGroupBox.Size = New System.Drawing.Size(396, 229)
        Me.RealTimeControlGroupBox.TabIndex = 2
        Me.RealTimeControlGroupBox.TabStop = False
        Me.RealTimeControlGroupBox.Text = "实时控制"
        '
        'HeadBodyControlCheckBox
        '
        Me.HeadBodyControlCheckBox.AutoSize = True
        Me.HeadBodyControlCheckBox.Location = New System.Drawing.Point(287, 194)
        Me.HeadBodyControlCheckBox.Name = "HeadBodyControlCheckBox"
        Me.HeadBodyControlCheckBox.Size = New System.Drawing.Size(96, 16)
        Me.HeadBodyControlCheckBox.TabIndex = 14
        Me.HeadBodyControlCheckBox.Text = "头身同时控制"
        Me.HeadBodyControlCheckBox.UseVisualStyleBackColor = True
        '
        'EyesControlCheckBox
        '
        Me.EyesControlCheckBox.AutoSize = True
        Me.EyesControlCheckBox.Location = New System.Drawing.Point(147, 194)
        Me.EyesControlCheckBox.Name = "EyesControlCheckBox"
        Me.EyesControlCheckBox.Size = New System.Drawing.Size(96, 16)
        Me.EyesControlCheckBox.TabIndex = 13
        Me.EyesControlCheckBox.Text = "双眼同时控制"
        Me.EyesControlCheckBox.UseVisualStyleBackColor = True
        '
        'ArmsControlCheckBox
        '
        Me.ArmsControlCheckBox.AutoSize = True
        Me.ArmsControlCheckBox.Location = New System.Drawing.Point(15, 194)
        Me.ArmsControlCheckBox.Name = "ArmsControlCheckBox"
        Me.ArmsControlCheckBox.Size = New System.Drawing.Size(96, 16)
        Me.ArmsControlCheckBox.TabIndex = 12
        Me.ArmsControlCheckBox.Text = "手臂同时控制"
        Me.ArmsControlCheckBox.UseVisualStyleBackColor = True
        '
        'RightEyeButton
        '
        Me.RightEyeButton.Location = New System.Drawing.Point(239, 44)
        Me.RightEyeButton.Name = "RightEyeButton"
        Me.RightEyeButton.Size = New System.Drawing.Size(75, 23)
        Me.RightEyeButton.TabIndex = 11
        Me.RightEyeButton.Text = "打开"
        Me.RightEyeButton.UseVisualStyleBackColor = True
        '
        'RightEyeLabel
        '
        Me.RightEyeLabel.AutoSize = True
        Me.RightEyeLabel.Location = New System.Drawing.Point(198, 49)
        Me.RightEyeLabel.Name = "RightEyeLabel"
        Me.RightEyeLabel.Size = New System.Drawing.Size(35, 12)
        Me.RightEyeLabel.TabIndex = 10
        Me.RightEyeLabel.Text = "右眼E"
        '
        'LeftEyeButton
        '
        Me.LeftEyeButton.Location = New System.Drawing.Point(110, 44)
        Me.LeftEyeButton.Name = "LeftEyeButton"
        Me.LeftEyeButton.Size = New System.Drawing.Size(75, 23)
        Me.LeftEyeButton.TabIndex = 9
        Me.LeftEyeButton.Text = "打开"
        Me.LeftEyeButton.UseVisualStyleBackColor = True
        '
        'LeftEyeLabel
        '
        Me.LeftEyeLabel.AutoSize = True
        Me.LeftEyeLabel.Location = New System.Drawing.Point(69, 49)
        Me.LeftEyeLabel.Name = "LeftEyeLabel"
        Me.LeftEyeLabel.Size = New System.Drawing.Size(35, 12)
        Me.LeftEyeLabel.TabIndex = 8
        Me.LeftEyeLabel.Text = "左眼Q"
        '
        'RightArmControlTrackBar
        '
        Me.RightArmControlTrackBar.Location = New System.Drawing.Point(338, 39)
        Me.RightArmControlTrackBar.Maximum = 22
        Me.RightArmControlTrackBar.Name = "RightArmControlTrackBar"
        Me.RightArmControlTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.RightArmControlTrackBar.Size = New System.Drawing.Size(45, 137)
        Me.RightArmControlTrackBar.TabIndex = 7
        '
        'LeftArmControlTrackBar
        '
        Me.LeftArmControlTrackBar.Location = New System.Drawing.Point(15, 38)
        Me.LeftArmControlTrackBar.Maximum = 22
        Me.LeftArmControlTrackBar.Name = "LeftArmControlTrackBar"
        Me.LeftArmControlTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.LeftArmControlTrackBar.Size = New System.Drawing.Size(45, 138)
        Me.LeftArmControlTrackBar.TabIndex = 6
        '
        'RightArmLabel
        '
        Me.RightArmLabel.AutoSize = True
        Me.RightArmLabel.Location = New System.Drawing.Point(336, 22)
        Me.RightArmLabel.Name = "RightArmLabel"
        Me.RightArmLabel.Size = New System.Drawing.Size(47, 12)
        Me.RightArmLabel.TabIndex = 5
        Me.RightArmLabel.Text = "右手臂D"
        '
        'LeftArmLabel
        '
        Me.LeftArmLabel.AutoSize = True
        Me.LeftArmLabel.Location = New System.Drawing.Point(11, 23)
        Me.LeftArmLabel.Name = "LeftArmLabel"
        Me.LeftArmLabel.Size = New System.Drawing.Size(47, 12)
        Me.LeftArmLabel.TabIndex = 4
        Me.LeftArmLabel.Text = "左手臂A"
        '
        'BodyControlTrackBar
        '
        Me.BodyControlTrackBar.Location = New System.Drawing.Point(110, 131)
        Me.BodyControlTrackBar.Maximum = 22
        Me.BodyControlTrackBar.Name = "BodyControlTrackBar"
        Me.BodyControlTrackBar.Size = New System.Drawing.Size(206, 45)
        Me.BodyControlTrackBar.TabIndex = 3
        Me.BodyControlTrackBar.Value = 11
        '
        'BodyLabel
        '
        Me.BodyLabel.AutoSize = True
        Me.BodyLabel.Location = New System.Drawing.Point(69, 131)
        Me.BodyLabel.Name = "BodyLabel"
        Me.BodyLabel.Size = New System.Drawing.Size(35, 12)
        Me.BodyLabel.TabIndex = 2
        Me.BodyLabel.Text = "身体S"
        '
        'HeadControlTrackBar
        '
        Me.HeadControlTrackBar.Location = New System.Drawing.Point(110, 86)
        Me.HeadControlTrackBar.Maximum = 22
        Me.HeadControlTrackBar.Name = "HeadControlTrackBar"
        Me.HeadControlTrackBar.Size = New System.Drawing.Size(206, 45)
        Me.HeadControlTrackBar.TabIndex = 1
        Me.HeadControlTrackBar.Value = 11
        '
        'HeadLabel
        '
        Me.HeadLabel.AutoSize = True
        Me.HeadLabel.Location = New System.Drawing.Point(69, 86)
        Me.HeadLabel.Name = "HeadLabel"
        Me.HeadLabel.Size = New System.Drawing.Size(35, 12)
        Me.HeadLabel.TabIndex = 0
        Me.HeadLabel.Text = "头部W"
        '
        'InfoGroupBox
        '
        Me.InfoGroupBox.Controls.Add(Me.SaveInfoButton)
        Me.InfoGroupBox.Controls.Add(Me.InfoTextBox)
        Me.InfoGroupBox.Controls.Add(Me.ClrInfoButton)
        Me.InfoGroupBox.Enabled = False
        Me.InfoGroupBox.Location = New System.Drawing.Point(414, 88)
        Me.InfoGroupBox.Name = "InfoGroupBox"
        Me.InfoGroupBox.Size = New System.Drawing.Size(290, 228)
        Me.InfoGroupBox.TabIndex = 3
        Me.InfoGroupBox.TabStop = False
        Me.InfoGroupBox.Text = "信息"
        '
        'SaveInfoButton
        '
        Me.SaveInfoButton.Location = New System.Drawing.Point(128, 198)
        Me.SaveInfoButton.Name = "SaveInfoButton"
        Me.SaveInfoButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveInfoButton.TabIndex = 6
        Me.SaveInfoButton.Text = "保存记录"
        Me.SaveInfoButton.UseVisualStyleBackColor = True
        '
        'InfoTextBox
        '
        Me.InfoTextBox.Location = New System.Drawing.Point(7, 21)
        Me.InfoTextBox.Multiline = True
        Me.InfoTextBox.Name = "InfoTextBox"
        Me.InfoTextBox.ReadOnly = True
        Me.InfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.InfoTextBox.Size = New System.Drawing.Size(277, 171)
        Me.InfoTextBox.TabIndex = 0
        '
        'ClrInfoButton
        '
        Me.ClrInfoButton.Location = New System.Drawing.Point(209, 198)
        Me.ClrInfoButton.Name = "ClrInfoButton"
        Me.ClrInfoButton.Size = New System.Drawing.Size(75, 23)
        Me.ClrInfoButton.TabIndex = 5
        Me.ClrInfoButton.Text = "清空记录"
        Me.ClrInfoButton.UseVisualStyleBackColor = True
        '
        'CommandControlGroupBox
        '
        Me.CommandControlGroupBox.Controls.Add(Me.CommandMultiFileControlGroupBox)
        Me.CommandControlGroupBox.Controls.Add(Me.CommandMultiFileControlButton)
        Me.CommandControlGroupBox.Controls.Add(Me.CommandFileControlGroupBox)
        Me.CommandControlGroupBox.Controls.Add(Me.CommandRealTimeControlButton)
        Me.CommandControlGroupBox.Controls.Add(Me.CommandRealTimeControlGroupBox)
        Me.CommandControlGroupBox.Controls.Add(Me.CommandFileControlButton)
        Me.CommandControlGroupBox.Enabled = False
        Me.CommandControlGroupBox.Location = New System.Drawing.Point(12, 322)
        Me.CommandControlGroupBox.Name = "CommandControlGroupBox"
        Me.CommandControlGroupBox.Size = New System.Drawing.Size(692, 252)
        Me.CommandControlGroupBox.TabIndex = 4
        Me.CommandControlGroupBox.TabStop = False
        Me.CommandControlGroupBox.Text = "命令控制"
        '
        'CommandMultiFileControlGroupBox
        '
        Me.CommandMultiFileControlGroupBox.Controls.Add(Me.CommandMultiFile2FileRadioButton)
        Me.CommandMultiFileControlGroupBox.Controls.Add(Me.CommandMultiFile2ListRadioButton)
        Me.CommandMultiFileControlGroupBox.Controls.Add(Me.CommandMultiFileLoadButton)
        Me.CommandMultiFileControlGroupBox.Controls.Add(Me.CommandMultiFileSaveButton)
        Me.CommandMultiFileControlGroupBox.Controls.Add(Me.CommandMultiFileDownButton)
        Me.CommandMultiFileControlGroupBox.Controls.Add(Me.CommandMultiFileUpButton)
        Me.CommandMultiFileControlGroupBox.Controls.Add(Me.CommandMultiFileDelButton)
        Me.CommandMultiFileControlGroupBox.Controls.Add(Me.CommandMultiFileAddButton)
        Me.CommandMultiFileControlGroupBox.Controls.Add(Me.CommandMultiFileExitButton)
        Me.CommandMultiFileControlGroupBox.Controls.Add(Me.CommandMultiFileStopButton)
        Me.CommandMultiFileControlGroupBox.Controls.Add(Me.CommandMultiFileBeginButton)
        Me.CommandMultiFileControlGroupBox.Controls.Add(Me.CommandMultiFileListBox)
        Me.CommandMultiFileControlGroupBox.Enabled = False
        Me.CommandMultiFileControlGroupBox.Location = New System.Drawing.Point(311, 50)
        Me.CommandMultiFileControlGroupBox.Name = "CommandMultiFileControlGroupBox"
        Me.CommandMultiFileControlGroupBox.Size = New System.Drawing.Size(374, 193)
        Me.CommandMultiFileControlGroupBox.TabIndex = 10
        Me.CommandMultiFileControlGroupBox.TabStop = False
        Me.CommandMultiFileControlGroupBox.Text = "多文件命令控制"
        '
        'CommandMultiFileSaveButton
        '
        Me.CommandMultiFileSaveButton.Location = New System.Drawing.Point(242, 142)
        Me.CommandMultiFileSaveButton.Name = "CommandMultiFileSaveButton"
        Me.CommandMultiFileSaveButton.Size = New System.Drawing.Size(60, 23)
        Me.CommandMultiFileSaveButton.TabIndex = 8
        Me.CommandMultiFileSaveButton.Text = "保存"
        Me.CommandMultiFileSaveButton.UseVisualStyleBackColor = True
        '
        'CommandMultiFileDownButton
        '
        Me.CommandMultiFileDownButton.Location = New System.Drawing.Point(308, 113)
        Me.CommandMultiFileDownButton.Name = "CommandMultiFileDownButton"
        Me.CommandMultiFileDownButton.Size = New System.Drawing.Size(60, 23)
        Me.CommandMultiFileDownButton.TabIndex = 7
        Me.CommandMultiFileDownButton.Text = "下移"
        Me.CommandMultiFileDownButton.UseVisualStyleBackColor = True
        '
        'CommandMultiFileUpButton
        '
        Me.CommandMultiFileUpButton.Location = New System.Drawing.Point(308, 84)
        Me.CommandMultiFileUpButton.Name = "CommandMultiFileUpButton"
        Me.CommandMultiFileUpButton.Size = New System.Drawing.Size(60, 23)
        Me.CommandMultiFileUpButton.TabIndex = 6
        Me.CommandMultiFileUpButton.Text = "上移"
        Me.CommandMultiFileUpButton.UseVisualStyleBackColor = True
        '
        'CommandMultiFileDelButton
        '
        Me.CommandMultiFileDelButton.Location = New System.Drawing.Point(308, 49)
        Me.CommandMultiFileDelButton.Name = "CommandMultiFileDelButton"
        Me.CommandMultiFileDelButton.Size = New System.Drawing.Size(60, 23)
        Me.CommandMultiFileDelButton.TabIndex = 5
        Me.CommandMultiFileDelButton.Text = "删除"
        Me.CommandMultiFileDelButton.UseVisualStyleBackColor = True
        '
        'CommandMultiFileAddButton
        '
        Me.CommandMultiFileAddButton.Location = New System.Drawing.Point(308, 20)
        Me.CommandMultiFileAddButton.Name = "CommandMultiFileAddButton"
        Me.CommandMultiFileAddButton.Size = New System.Drawing.Size(60, 23)
        Me.CommandMultiFileAddButton.TabIndex = 4
        Me.CommandMultiFileAddButton.Text = "添加"
        Me.CommandMultiFileAddButton.UseVisualStyleBackColor = True
        '
        'CommandMultiFileExitButton
        '
        Me.CommandMultiFileExitButton.Enabled = False
        Me.CommandMultiFileExitButton.Location = New System.Drawing.Point(138, 142)
        Me.CommandMultiFileExitButton.Name = "CommandMultiFileExitButton"
        Me.CommandMultiFileExitButton.Size = New System.Drawing.Size(60, 23)
        Me.CommandMultiFileExitButton.TabIndex = 3
        Me.CommandMultiFileExitButton.Text = "停止"
        Me.CommandMultiFileExitButton.UseVisualStyleBackColor = True
        '
        'CommandMultiFileStopButton
        '
        Me.CommandMultiFileStopButton.Enabled = False
        Me.CommandMultiFileStopButton.Location = New System.Drawing.Point(72, 142)
        Me.CommandMultiFileStopButton.Name = "CommandMultiFileStopButton"
        Me.CommandMultiFileStopButton.Size = New System.Drawing.Size(60, 23)
        Me.CommandMultiFileStopButton.TabIndex = 2
        Me.CommandMultiFileStopButton.Text = "暂停"
        Me.CommandMultiFileStopButton.UseVisualStyleBackColor = True
        '
        'CommandMultiFileBeginButton
        '
        Me.CommandMultiFileBeginButton.Location = New System.Drawing.Point(6, 142)
        Me.CommandMultiFileBeginButton.Name = "CommandMultiFileBeginButton"
        Me.CommandMultiFileBeginButton.Size = New System.Drawing.Size(60, 23)
        Me.CommandMultiFileBeginButton.TabIndex = 1
        Me.CommandMultiFileBeginButton.Text = "运行"
        Me.CommandMultiFileBeginButton.UseVisualStyleBackColor = True
        '
        'CommandMultiFileListBox
        '
        Me.CommandMultiFileListBox.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CommandMultiFileListBox.FormattingEnabled = True
        Me.CommandMultiFileListBox.ItemHeight = 14
        Me.CommandMultiFileListBox.Location = New System.Drawing.Point(6, 20)
        Me.CommandMultiFileListBox.Name = "CommandMultiFileListBox"
        Me.CommandMultiFileListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.CommandMultiFileListBox.Size = New System.Drawing.Size(296, 116)
        Me.CommandMultiFileListBox.TabIndex = 0
        '
        'CommandMultiFileControlButton
        '
        Me.CommandMultiFileControlButton.Location = New System.Drawing.Point(555, 21)
        Me.CommandMultiFileControlButton.Name = "CommandMultiFileControlButton"
        Me.CommandMultiFileControlButton.Size = New System.Drawing.Size(130, 23)
        Me.CommandMultiFileControlButton.TabIndex = 9
        Me.CommandMultiFileControlButton.Text = "打开多文件命令控制"
        Me.CommandMultiFileControlButton.UseVisualStyleBackColor = True
        '
        'CommandFileControlGroupBox
        '
        Me.CommandFileControlGroupBox.Controls.Add(Me.CommandFileExitButton)
        Me.CommandFileControlGroupBox.Controls.Add(Me.CommandFileStopButton)
        Me.CommandFileControlGroupBox.Controls.Add(Me.CommandFileBeginButton)
        Me.CommandFileControlGroupBox.Controls.Add(Me.FileCommandInfoLabel)
        Me.CommandFileControlGroupBox.Controls.Add(Me.CommandFileOpenButton)
        Me.CommandFileControlGroupBox.Enabled = False
        Me.CommandFileControlGroupBox.Location = New System.Drawing.Point(6, 142)
        Me.CommandFileControlGroupBox.Name = "CommandFileControlGroupBox"
        Me.CommandFileControlGroupBox.Size = New System.Drawing.Size(290, 101)
        Me.CommandFileControlGroupBox.TabIndex = 8
        Me.CommandFileControlGroupBox.TabStop = False
        Me.CommandFileControlGroupBox.Text = "文件命令控制"
        '
        'CommandFileExitButton
        '
        Me.CommandFileExitButton.Enabled = False
        Me.CommandFileExitButton.Location = New System.Drawing.Point(151, 63)
        Me.CommandFileExitButton.Name = "CommandFileExitButton"
        Me.CommandFileExitButton.Size = New System.Drawing.Size(60, 23)
        Me.CommandFileExitButton.TabIndex = 5
        Me.CommandFileExitButton.Text = "停止"
        Me.CommandFileExitButton.UseVisualStyleBackColor = True
        '
        'CommandFileStopButton
        '
        Me.CommandFileStopButton.Enabled = False
        Me.CommandFileStopButton.Location = New System.Drawing.Point(79, 63)
        Me.CommandFileStopButton.Name = "CommandFileStopButton"
        Me.CommandFileStopButton.Size = New System.Drawing.Size(60, 23)
        Me.CommandFileStopButton.TabIndex = 4
        Me.CommandFileStopButton.Text = "暂停"
        Me.CommandFileStopButton.UseVisualStyleBackColor = True
        '
        'CommandFileBeginButton
        '
        Me.CommandFileBeginButton.Location = New System.Drawing.Point(8, 63)
        Me.CommandFileBeginButton.Name = "CommandFileBeginButton"
        Me.CommandFileBeginButton.Size = New System.Drawing.Size(60, 23)
        Me.CommandFileBeginButton.TabIndex = 3
        Me.CommandFileBeginButton.Text = "运行"
        Me.CommandFileBeginButton.UseVisualStyleBackColor = True
        '
        'FileCommandInfoLabel
        '
        Me.FileCommandInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FileCommandInfoLabel.Location = New System.Drawing.Point(6, 30)
        Me.FileCommandInfoLabel.Name = "FileCommandInfoLabel"
        Me.FileCommandInfoLabel.Size = New System.Drawing.Size(277, 21)
        Me.FileCommandInfoLabel.TabIndex = 1
        Me.FileCommandInfoLabel.Text = "文件未打开"
        Me.FileCommandInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CommandFileOpenButton
        '
        Me.CommandFileOpenButton.Location = New System.Drawing.Point(223, 63)
        Me.CommandFileOpenButton.Name = "CommandFileOpenButton"
        Me.CommandFileOpenButton.Size = New System.Drawing.Size(60, 23)
        Me.CommandFileOpenButton.TabIndex = 0
        Me.CommandFileOpenButton.Text = "浏览"
        Me.CommandFileOpenButton.UseVisualStyleBackColor = True
        '
        'CommandRealTimeControlButton
        '
        Me.CommandRealTimeControlButton.Location = New System.Drawing.Point(166, 21)
        Me.CommandRealTimeControlButton.Name = "CommandRealTimeControlButton"
        Me.CommandRealTimeControlButton.Size = New System.Drawing.Size(130, 23)
        Me.CommandRealTimeControlButton.TabIndex = 7
        Me.CommandRealTimeControlButton.Text = "打开实时命令控制"
        Me.CommandRealTimeControlButton.UseVisualStyleBackColor = True
        '
        'CommandRealTimeControlGroupBox
        '
        Me.CommandRealTimeControlGroupBox.Controls.Add(Me.RealTimeCommandControlTextBox)
        Me.CommandRealTimeControlGroupBox.Controls.Add(Me.RealTimeCommandSendButton)
        Me.CommandRealTimeControlGroupBox.Enabled = False
        Me.CommandRealTimeControlGroupBox.Location = New System.Drawing.Point(6, 50)
        Me.CommandRealTimeControlGroupBox.Name = "CommandRealTimeControlGroupBox"
        Me.CommandRealTimeControlGroupBox.Size = New System.Drawing.Size(290, 57)
        Me.CommandRealTimeControlGroupBox.TabIndex = 7
        Me.CommandRealTimeControlGroupBox.TabStop = False
        Me.CommandRealTimeControlGroupBox.Text = "实时命令控制"
        '
        'RealTimeCommandControlTextBox
        '
        Me.RealTimeCommandControlTextBox.Location = New System.Drawing.Point(6, 20)
        Me.RealTimeCommandControlTextBox.Name = "RealTimeCommandControlTextBox"
        Me.RealTimeCommandControlTextBox.Size = New System.Drawing.Size(205, 21)
        Me.RealTimeCommandControlTextBox.TabIndex = 8
        '
        'RealTimeCommandSendButton
        '
        Me.RealTimeCommandSendButton.Location = New System.Drawing.Point(224, 18)
        Me.RealTimeCommandSendButton.Name = "RealTimeCommandSendButton"
        Me.RealTimeCommandSendButton.Size = New System.Drawing.Size(60, 23)
        Me.RealTimeCommandSendButton.TabIndex = 6
        Me.RealTimeCommandSendButton.Text = "运行"
        Me.RealTimeCommandSendButton.UseVisualStyleBackColor = True
        '
        'CommandFileControlButton
        '
        Me.CommandFileControlButton.Location = New System.Drawing.Point(166, 113)
        Me.CommandFileControlButton.Name = "CommandFileControlButton"
        Me.CommandFileControlButton.Size = New System.Drawing.Size(130, 23)
        Me.CommandFileControlButton.TabIndex = 2
        Me.CommandFileControlButton.Text = "打开文件命令控制"
        Me.CommandFileControlButton.UseVisualStyleBackColor = True
        '
        'RealTimeControlButton
        '
        Me.RealTimeControlButton.Enabled = False
        Me.RealTimeControlButton.Location = New System.Drawing.Point(12, 58)
        Me.RealTimeControlButton.Name = "RealTimeControlButton"
        Me.RealTimeControlButton.Size = New System.Drawing.Size(110, 23)
        Me.RealTimeControlButton.TabIndex = 5
        Me.RealTimeControlButton.Text = "打开实时控制"
        Me.RealTimeControlButton.UseVisualStyleBackColor = True
        '
        'CommandControlButton
        '
        Me.CommandControlButton.Enabled = False
        Me.CommandControlButton.Location = New System.Drawing.Point(139, 58)
        Me.CommandControlButton.Name = "CommandControlButton"
        Me.CommandControlButton.Size = New System.Drawing.Size(115, 23)
        Me.CommandControlButton.TabIndex = 6
        Me.CommandControlButton.Text = "打开命令控制"
        Me.CommandControlButton.UseVisualStyleBackColor = True
        '
        'FirmataVB1
        '
        Me.FirmataVB1.Baud = 115200
        Me.FirmataVB1.BoardType = Firmata.FirmataVB.Board.DUEMILANOVE
        Me.FirmataVB1.COMPortName = "COM2"
        Me.FirmataVB1.WithAnalogReceiveEvents = True
        Me.FirmataVB1.WithDigitalReceiveEvents = True
        Me.FirmataVB1.WithVersionReceieveEvents = True
        '
        'CommandMultiFileLoadButton
        '
        Me.CommandMultiFileLoadButton.Location = New System.Drawing.Point(308, 142)
        Me.CommandMultiFileLoadButton.Name = "CommandMultiFileLoadButton"
        Me.CommandMultiFileLoadButton.Size = New System.Drawing.Size(60, 23)
        Me.CommandMultiFileLoadButton.TabIndex = 9
        Me.CommandMultiFileLoadButton.Text = "载入"
        Me.CommandMultiFileLoadButton.UseVisualStyleBackColor = True
        '
        'CommandMultiFile2ListRadioButton
        '
        Me.CommandMultiFile2ListRadioButton.AutoSize = True
        Me.CommandMultiFile2ListRadioButton.Location = New System.Drawing.Point(285, 171)
        Me.CommandMultiFile2ListRadioButton.Name = "CommandMultiFile2ListRadioButton"
        Me.CommandMultiFile2ListRadioButton.Size = New System.Drawing.Size(83, 16)
        Me.CommandMultiFile2ListRadioButton.TabIndex = 10
        Me.CommandMultiFile2ListRadioButton.TabStop = True
        Me.CommandMultiFile2ListRadioButton.Text = "保存为列表"
        Me.CommandMultiFile2ListRadioButton.UseVisualStyleBackColor = True
        '
        'CommandMultiFile2FileRadioButton
        '
        Me.CommandMultiFile2FileRadioButton.AutoSize = True
        Me.CommandMultiFile2FileRadioButton.Location = New System.Drawing.Point(196, 171)
        Me.CommandMultiFile2FileRadioButton.Name = "CommandMultiFile2FileRadioButton"
        Me.CommandMultiFile2FileRadioButton.Size = New System.Drawing.Size(83, 16)
        Me.CommandMultiFile2FileRadioButton.TabIndex = 11
        Me.CommandMultiFile2FileRadioButton.TabStop = True
        Me.CommandMultiFile2FileRadioButton.Text = "保存为文件"
        Me.CommandMultiFile2FileRadioButton.UseVisualStyleBackColor = True
        '
        'AndroidFigureControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 583)
        Me.Controls.Add(Me.CommandControlButton)
        Me.Controls.Add(Me.RealTimeControlButton)
        Me.Controls.Add(Me.CommandControlGroupBox)
        Me.Controls.Add(Me.InfoGroupBox)
        Me.Controls.Add(Me.RealTimeControlGroupBox)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "AndroidFigureControl"
        Me.Text = "Android跳舞公仔控制程序"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.RealTimeControlGroupBox.ResumeLayout(False)
        Me.RealTimeControlGroupBox.PerformLayout()
        CType(Me.RightArmControlTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftArmControlTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BodyControlTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeadControlTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InfoGroupBox.ResumeLayout(False)
        Me.InfoGroupBox.PerformLayout()
        Me.CommandControlGroupBox.ResumeLayout(False)
        Me.CommandMultiFileControlGroupBox.ResumeLayout(False)
        Me.CommandMultiFileControlGroupBox.PerformLayout()
        Me.CommandFileControlGroupBox.ResumeLayout(False)
        Me.CommandRealTimeControlGroupBox.ResumeLayout(False)
        Me.CommandRealTimeControlGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ComListToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ConnectionToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents COMListToolStripComboBox As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents BaudListToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BaudListToolStripComboBox As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ConnectToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ConnectionStatusToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents 文件ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 退出ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 帮助ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 关于ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RealTimeControlGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents HeadControlTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents HeadLabel As System.Windows.Forms.Label
    Friend WithEvents RightArmControlTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents LeftArmControlTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents RightArmLabel As System.Windows.Forms.Label
    Friend WithEvents LeftArmLabel As System.Windows.Forms.Label
    Friend WithEvents BodyControlTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents BodyLabel As System.Windows.Forms.Label
    Friend WithEvents LeftEyeLabel As System.Windows.Forms.Label
    Friend WithEvents RightEyeButton As System.Windows.Forms.Button
    Friend WithEvents RightEyeLabel As System.Windows.Forms.Label
    Friend WithEvents LeftEyeButton As System.Windows.Forms.Button
    Friend WithEvents HeadBodyControlCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents EyesControlCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ArmsControlCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents InfoGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents InfoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CommandControlGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ClrInfoButton As System.Windows.Forms.Button
    Friend WithEvents RealTimeControlButton As System.Windows.Forms.Button
    Friend WithEvents CommandControlButton As System.Windows.Forms.Button
    Friend WithEvents CommandFileControlGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents CommandRealTimeControlButton As System.Windows.Forms.Button
    Friend WithEvents CommandFileControlButton As System.Windows.Forms.Button
    Friend WithEvents FileCommandInfoLabel As System.Windows.Forms.Label
    Friend WithEvents CommandFileOpenButton As System.Windows.Forms.Button
    Friend WithEvents CommandFileExitButton As System.Windows.Forms.Button
    Friend WithEvents CommandFileStopButton As System.Windows.Forms.Button
    Friend WithEvents CommandFileBeginButton As System.Windows.Forms.Button
    Friend WithEvents SaveInfoButton As System.Windows.Forms.Button
    Friend WithEvents FirmataVB1 As Firmata.FirmataVB
    Friend WithEvents CommandRealTimeControlGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents RealTimeCommandControlTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RealTimeCommandSendButton As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents CommandMultiFileControlGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents CommandMultiFileControlButton As System.Windows.Forms.Button
    Friend WithEvents CommandMultiFileListBox As System.Windows.Forms.ListBox
    Friend WithEvents CommandMultiFileBeginButton As System.Windows.Forms.Button
    Friend WithEvents CommandMultiFileExitButton As System.Windows.Forms.Button
    Friend WithEvents CommandMultiFileStopButton As System.Windows.Forms.Button
    Friend WithEvents CommandMultiFileAddButton As System.Windows.Forms.Button
    Friend WithEvents CommandMultiFileDelButton As System.Windows.Forms.Button
    Friend WithEvents CommandMultiFileDownButton As System.Windows.Forms.Button
    Friend WithEvents CommandMultiFileUpButton As System.Windows.Forms.Button
    Friend WithEvents CommandMultiFileSaveButton As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents CommandMultiFileLoadButton As System.Windows.Forms.Button
    Friend WithEvents CommandMultiFile2ListRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents CommandMultiFile2FileRadioButton As System.Windows.Forms.RadioButton

End Class
