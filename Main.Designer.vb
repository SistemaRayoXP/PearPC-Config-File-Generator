<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.CreateConfig = New System.Windows.Forms.Button
        Me.SaveConfigFile = New System.Windows.Forms.SaveFileDialog
        Me.StandardResolution = New System.Windows.Forms.ComboBox
        Me.BitDepth = New System.Windows.Forms.ComboBox
        Me.WelcomeText = New System.Windows.Forms.Label
        Me.Resolution = New System.Windows.Forms.Label
        Me.CustomResolutionCheck = New System.Windows.Forms.CheckBox
        Me.FullscreenCheck = New System.Windows.Forms.CheckBox
        Me.Fullscreen = New System.Windows.Forms.Label
        Me.XCustomResolution = New System.Windows.Forms.TextBox
        Me.YCustomResolution = New System.Windows.Forms.TextBox
        Me.Browser = New System.Windows.Forms.OpenFileDialog
        Me.ToggleFullscreenKeyLabel = New System.Windows.Forms.Label
        Me.ToggleFullscreenKey = New System.Windows.Forms.TextBox
        Me.ShowAdvanced = New System.Windows.Forms.CheckBox
        Me.Redraw = New System.Windows.Forms.Label
        Me.RedrawTime = New System.Windows.Forms.TextBox
        Me.GraphicSettings = New System.Windows.Forms.GroupBox
        Me.BrowseDriver = New System.Windows.Forms.Button
        Me.GraphicDriver = New System.Windows.Forms.TextBox
        Me.GraphicDriverLabel = New System.Windows.Forms.Label
        Me.Frequency = New System.Windows.Forms.NumericUpDown
        Me.DisksSettings = New System.Windows.Forms.GroupBox
        Me.SlaveBrowseDrive = New System.Windows.Forms.Button
        Me.SlaveTypeLabel = New System.Windows.Forms.Label
        Me.SlaveImageLabel = New System.Windows.Forms.Label
        Me.SlaveDrive = New System.Windows.Forms.TextBox
        Me.SlaveEnabled = New System.Windows.Forms.CheckBox
        Me.SlaveDriveType = New System.Windows.Forms.ComboBox
        Me.MasterDriveTypeBasic = New System.Windows.Forms.Label
        Me.MasterBrowseDrive = New System.Windows.Forms.Button
        Me.MasterTypeLabel = New System.Windows.Forms.Label
        Me.MasterImageLabel = New System.Windows.Forms.Label
        Me.MasterDrive = New System.Windows.Forms.TextBox
        Me.MasterEnabled = New System.Windows.Forms.CheckBox
        Me.MasterDriveType = New System.Windows.Forms.ComboBox
        Me.SelectDrive = New System.Windows.Forms.FolderBrowserDialog
        Me.NetworkSettings = New System.Windows.Forms.GroupBox
        Me.Net8139MacLabel = New System.Windows.Forms.Label
        Me.Net3c90MacLabel = New System.Windows.Forms.Label
        Me.Mac68139 = New System.Windows.Forms.TextBox
        Me.Mac58139 = New System.Windows.Forms.TextBox
        Me.Mac48139 = New System.Windows.Forms.TextBox
        Me.Mac38139 = New System.Windows.Forms.TextBox
        Me.Mac28139 = New System.Windows.Forms.TextBox
        Me.Mac18139 = New System.Windows.Forms.TextBox
        Me.Mac63c90 = New System.Windows.Forms.TextBox
        Me.Mac53c90 = New System.Windows.Forms.TextBox
        Me.Mac43c90 = New System.Windows.Forms.TextBox
        Me.Mac33c90 = New System.Windows.Forms.TextBox
        Me.Mac23c90 = New System.Windows.Forms.TextBox
        Me.Mac13c90 = New System.Windows.Forms.TextBox
        Me.NetRTL8139 = New System.Windows.Forms.CheckBox
        Me.Net3c90x = New System.Windows.Forms.CheckBox
        Me.MiscellaneousSettings = New System.Windows.Forms.GroupBox
        Me.EnableSerialPort = New System.Windows.Forms.CheckBox
        Me.ComposeDialogKeyLabel = New System.Windows.Forms.Label
        Me.ComposeDialogKey = New System.Windows.Forms.TextBox
        Me.ChangeCDKeyLabel = New System.Windows.Forms.Label
        Me.ChangeCDKey = New System.Windows.Forms.TextBox
        Me.MouseGrabKeyLabel = New System.Windows.Forms.Label
        Me.EnableUSB = New System.Windows.Forms.CheckBox
        Me.MouseToggleKey = New System.Windows.Forms.TextBox
        Me.MB = New System.Windows.Forms.Label
        Me.RAM = New System.Windows.Forms.TextBox
        Me.ProcessorLabel = New System.Windows.Forms.Label
        Me.RAMLabel = New System.Windows.Forms.Label
        Me.PPCG4 = New System.Windows.Forms.RadioButton
        Me.PPCG3 = New System.Windows.Forms.RadioButton
        Me.AdvancedSettings = New System.Windows.Forms.GroupBox
        Me.AdvancedWarning = New System.Windows.Forms.Label
        Me.PageTable = New System.Windows.Forms.TextBox
        Me.PageTableLabel = New System.Windows.Forms.Label
        Me.NVRAMFile = New System.Windows.Forms.TextBox
        Me.NVRAMFileLabel = New System.Windows.Forms.Label
        Me.BootMode = New System.Windows.Forms.Label
        Me.BootAuto = New System.Windows.Forms.RadioButton
        Me.BootSelect = New System.Windows.Forms.RadioButton
        Me.BootForce = New System.Windows.Forms.RadioButton
        Me.MachArguments = New System.Windows.Forms.TextBox
        Me.BootArguments = New System.Windows.Forms.TextBox
        Me.MachArgumentsLabel = New System.Windows.Forms.Label
        Me.BootArgumentsLabel = New System.Windows.Forms.Label
        Me.PROMBootPath = New System.Windows.Forms.TextBox
        Me.PROMFile = New System.Windows.Forms.TextBox
        Me.PROMBootPathLabel = New System.Windows.Forms.Label
        Me.PROMFileLabel = New System.Windows.Forms.Label
        Me.GraphicSettings.SuspendLayout()
        CType(Me.Frequency, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DisksSettings.SuspendLayout()
        Me.NetworkSettings.SuspendLayout()
        Me.MiscellaneousSettings.SuspendLayout()
        Me.AdvancedSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'CreateConfig
        '
        Me.CreateConfig.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateConfig.Location = New System.Drawing.Point(426, 445)
        Me.CreateConfig.Margin = New System.Windows.Forms.Padding(2)
        Me.CreateConfig.Name = "CreateConfig"
        Me.CreateConfig.Size = New System.Drawing.Size(273, 30)
        Me.CreateConfig.TabIndex = 0
        Me.CreateConfig.Text = "Create config file"
        Me.CreateConfig.UseVisualStyleBackColor = True
        '
        'SaveConfigFile
        '
        Me.SaveConfigFile.FileName = "PearPC"
        Me.SaveConfigFile.Filter = "PearPC Configuration Files (*.cfg)|*.cfg|All files (*.*)|*.*"
        '
        'StandardResolution
        '
        Me.StandardResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StandardResolution.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StandardResolution.ForeColor = System.Drawing.SystemColors.ControlText
        Me.StandardResolution.FormattingEnabled = True
        Me.StandardResolution.Items.AddRange(New Object() {"640x480", "800x600", "1024x768", "1152x864", "1280x960", "1600x1200"})
        Me.StandardResolution.Location = New System.Drawing.Point(116, 17)
        Me.StandardResolution.Margin = New System.Windows.Forms.Padding(2)
        Me.StandardResolution.Name = "StandardResolution"
        Me.StandardResolution.Size = New System.Drawing.Size(69, 21)
        Me.StandardResolution.TabIndex = 2
        '
        'BitDepth
        '
        Me.BitDepth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BitDepth.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BitDepth.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BitDepth.FormattingEnabled = True
        Me.BitDepth.Items.AddRange(New Object() {"15", "32"})
        Me.BitDepth.Location = New System.Drawing.Point(190, 17)
        Me.BitDepth.Margin = New System.Windows.Forms.Padding(2)
        Me.BitDepth.Name = "BitDepth"
        Me.BitDepth.Size = New System.Drawing.Size(35, 21)
        Me.BitDepth.TabIndex = 3
        '
        'WelcomeText
        '
        Me.WelcomeText.Dock = System.Windows.Forms.DockStyle.Top
        Me.WelcomeText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WelcomeText.Location = New System.Drawing.Point(0, 0)
        Me.WelcomeText.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.WelcomeText.Name = "WelcomeText"
        Me.WelcomeText.Padding = New System.Windows.Forms.Padding(9, 10, 9, 0)
        Me.WelcomeText.Size = New System.Drawing.Size(710, 56)
        Me.WelcomeText.TabIndex = 4
        Me.WelcomeText.Text = resources.GetString("WelcomeText.Text")
        '
        'Resolution
        '
        Me.Resolution.AutoSize = True
        Me.Resolution.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resolution.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Resolution.Location = New System.Drawing.Point(5, 20)
        Me.Resolution.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Resolution.Name = "Resolution"
        Me.Resolution.Size = New System.Drawing.Size(61, 13)
        Me.Resolution.TabIndex = 5
        Me.Resolution.Text = "Resolution:"
        '
        'CustomResolutionCheck
        '
        Me.CustomResolutionCheck.AutoSize = True
        Me.CustomResolutionCheck.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomResolutionCheck.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CustomResolutionCheck.Location = New System.Drawing.Point(276, 19)
        Me.CustomResolutionCheck.Margin = New System.Windows.Forms.Padding(2)
        Me.CustomResolutionCheck.Name = "CustomResolutionCheck"
        Me.CustomResolutionCheck.Size = New System.Drawing.Size(131, 17)
        Me.CustomResolutionCheck.TabIndex = 6
        Me.CustomResolutionCheck.Text = "Use custom resolution"
        Me.CustomResolutionCheck.UseVisualStyleBackColor = True
        '
        'FullscreenCheck
        '
        Me.FullscreenCheck.AutoSize = True
        Me.FullscreenCheck.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullscreenCheck.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FullscreenCheck.Location = New System.Drawing.Point(118, 46)
        Me.FullscreenCheck.Margin = New System.Windows.Forms.Padding(2)
        Me.FullscreenCheck.Name = "FullscreenCheck"
        Me.FullscreenCheck.Size = New System.Drawing.Size(146, 17)
        Me.FullscreenCheck.TabIndex = 7
        Me.FullscreenCheck.Text = "Start always in fullscreen"
        Me.FullscreenCheck.UseVisualStyleBackColor = True
        '
        'Fullscreen
        '
        Me.Fullscreen.AutoSize = True
        Me.Fullscreen.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fullscreen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Fullscreen.Location = New System.Drawing.Point(5, 45)
        Me.Fullscreen.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Fullscreen.Name = "Fullscreen"
        Me.Fullscreen.Size = New System.Drawing.Size(59, 13)
        Me.Fullscreen.TabIndex = 8
        Me.Fullscreen.Text = "Fullscreen:"
        '
        'XCustomResolution
        '
        Me.XCustomResolution.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XCustomResolution.ForeColor = System.Drawing.SystemColors.ControlText
        Me.XCustomResolution.Location = New System.Drawing.Point(117, 17)
        Me.XCustomResolution.Margin = New System.Windows.Forms.Padding(2)
        Me.XCustomResolution.Name = "XCustomResolution"
        Me.XCustomResolution.Size = New System.Drawing.Size(32, 21)
        Me.XCustomResolution.TabIndex = 9
        Me.XCustomResolution.Visible = False
        '
        'YCustomResolution
        '
        Me.YCustomResolution.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YCustomResolution.ForeColor = System.Drawing.SystemColors.ControlText
        Me.YCustomResolution.Location = New System.Drawing.Point(153, 17)
        Me.YCustomResolution.Margin = New System.Windows.Forms.Padding(2)
        Me.YCustomResolution.Name = "YCustomResolution"
        Me.YCustomResolution.Size = New System.Drawing.Size(32, 21)
        Me.YCustomResolution.TabIndex = 10
        Me.YCustomResolution.Visible = False
        '
        'Browser
        '
        Me.Browser.Filter = "Disc images(*.iso)|*.iso|Disk images (*.img)|*.img|All files (*.*)|*.*"
        '
        'ToggleFullscreenKeyLabel
        '
        Me.ToggleFullscreenKeyLabel.AutoSize = True
        Me.ToggleFullscreenKeyLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToggleFullscreenKeyLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ToggleFullscreenKeyLabel.Location = New System.Drawing.Point(5, 70)
        Me.ToggleFullscreenKeyLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ToggleFullscreenKeyLabel.Name = "ToggleFullscreenKeyLabel"
        Me.ToggleFullscreenKeyLabel.Size = New System.Drawing.Size(112, 13)
        Me.ToggleFullscreenKeyLabel.TabIndex = 11
        Me.ToggleFullscreenKeyLabel.Text = "Toggle fullscreen key:"
        '
        'ToggleFullscreenKey
        '
        Me.ToggleFullscreenKey.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToggleFullscreenKey.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ToggleFullscreenKey.Location = New System.Drawing.Point(116, 67)
        Me.ToggleFullscreenKey.Margin = New System.Windows.Forms.Padding(2)
        Me.ToggleFullscreenKey.Name = "ToggleFullscreenKey"
        Me.ToggleFullscreenKey.Size = New System.Drawing.Size(69, 21)
        Me.ToggleFullscreenKey.TabIndex = 12
        Me.ToggleFullscreenKey.Text = "F11"
        Me.ToggleFullscreenKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ShowAdvanced
        '
        Me.ShowAdvanced.AutoSize = True
        Me.ShowAdvanced.Dock = System.Windows.Forms.DockStyle.Top
        Me.ShowAdvanced.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowAdvanced.Location = New System.Drawing.Point(0, 56)
        Me.ShowAdvanced.Margin = New System.Windows.Forms.Padding(2)
        Me.ShowAdvanced.Name = "ShowAdvanced"
        Me.ShowAdvanced.Padding = New System.Windows.Forms.Padding(10, 0, 0, 4)
        Me.ShowAdvanced.Size = New System.Drawing.Size(710, 21)
        Me.ShowAdvanced.TabIndex = 13
        Me.ShowAdvanced.Text = "Show advanced options"
        Me.ShowAdvanced.UseVisualStyleBackColor = True
        '
        'Redraw
        '
        Me.Redraw.AutoSize = True
        Me.Redraw.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Redraw.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Redraw.Location = New System.Drawing.Point(5, 95)
        Me.Redraw.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Redraw.Name = "Redraw"
        Me.Redraw.Size = New System.Drawing.Size(87, 13)
        Me.Redraw.TabIndex = 14
        Me.Redraw.Text = "Redraw interval:"
        Me.Redraw.Visible = False
        '
        'RedrawTime
        '
        Me.RedrawTime.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RedrawTime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RedrawTime.Location = New System.Drawing.Point(116, 94)
        Me.RedrawTime.Margin = New System.Windows.Forms.Padding(2)
        Me.RedrawTime.Name = "RedrawTime"
        Me.RedrawTime.Size = New System.Drawing.Size(69, 21)
        Me.RedrawTime.TabIndex = 15
        Me.RedrawTime.TabStop = False
        Me.RedrawTime.Text = "40"
        Me.RedrawTime.Visible = False
        '
        'GraphicSettings
        '
        Me.GraphicSettings.Controls.Add(Me.BrowseDriver)
        Me.GraphicSettings.Controls.Add(Me.GraphicDriver)
        Me.GraphicSettings.Controls.Add(Me.GraphicDriverLabel)
        Me.GraphicSettings.Controls.Add(Me.Frequency)
        Me.GraphicSettings.Controls.Add(Me.Resolution)
        Me.GraphicSettings.Controls.Add(Me.RedrawTime)
        Me.GraphicSettings.Controls.Add(Me.Redraw)
        Me.GraphicSettings.Controls.Add(Me.StandardResolution)
        Me.GraphicSettings.Controls.Add(Me.ToggleFullscreenKey)
        Me.GraphicSettings.Controls.Add(Me.BitDepth)
        Me.GraphicSettings.Controls.Add(Me.ToggleFullscreenKeyLabel)
        Me.GraphicSettings.Controls.Add(Me.CustomResolutionCheck)
        Me.GraphicSettings.Controls.Add(Me.Fullscreen)
        Me.GraphicSettings.Controls.Add(Me.FullscreenCheck)
        Me.GraphicSettings.Controls.Add(Me.XCustomResolution)
        Me.GraphicSettings.Controls.Add(Me.YCustomResolution)
        Me.GraphicSettings.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GraphicSettings.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GraphicSettings.Location = New System.Drawing.Point(0, 77)
        Me.GraphicSettings.Margin = New System.Windows.Forms.Padding(2)
        Me.GraphicSettings.Name = "GraphicSettings"
        Me.GraphicSettings.Size = New System.Drawing.Size(420, 100)
        Me.GraphicSettings.TabIndex = 16
        Me.GraphicSettings.TabStop = False
        Me.GraphicSettings.Text = "Graphics"
        '
        'BrowseDriver
        '
        Me.BrowseDriver.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrowseDriver.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BrowseDriver.Location = New System.Drawing.Point(379, 67)
        Me.BrowseDriver.Margin = New System.Windows.Forms.Padding(2)
        Me.BrowseDriver.Name = "BrowseDriver"
        Me.BrowseDriver.Size = New System.Drawing.Size(29, 19)
        Me.BrowseDriver.TabIndex = 21
        Me.BrowseDriver.TabStop = False
        Me.BrowseDriver.Text = "..."
        Me.BrowseDriver.UseVisualStyleBackColor = True
        Me.BrowseDriver.Visible = False
        '
        'GraphicDriver
        '
        Me.GraphicDriver.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GraphicDriver.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GraphicDriver.Location = New System.Drawing.Point(306, 67)
        Me.GraphicDriver.Margin = New System.Windows.Forms.Padding(2)
        Me.GraphicDriver.Name = "GraphicDriver"
        Me.GraphicDriver.Size = New System.Drawing.Size(69, 21)
        Me.GraphicDriver.TabIndex = 20
        Me.GraphicDriver.TabStop = False
        Me.GraphicDriver.Text = "video.x"
        Me.GraphicDriver.Visible = False
        '
        'GraphicDriverLabel
        '
        Me.GraphicDriverLabel.AutoSize = True
        Me.GraphicDriverLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GraphicDriverLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GraphicDriverLabel.Location = New System.Drawing.Point(226, 69)
        Me.GraphicDriverLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GraphicDriverLabel.Name = "GraphicDriverLabel"
        Me.GraphicDriverLabel.Size = New System.Drawing.Size(78, 13)
        Me.GraphicDriverLabel.TabIndex = 19
        Me.GraphicDriverLabel.Text = "Graphic driver:"
        Me.GraphicDriverLabel.Visible = False
        '
        'Frequency
        '
        Me.Frequency.Enabled = False
        Me.Frequency.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frequency.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frequency.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.Frequency.Location = New System.Drawing.Point(230, 17)
        Me.Frequency.Maximum = New Decimal(New Integer() {140, 0, 0, 0})
        Me.Frequency.Name = "Frequency"
        Me.Frequency.Size = New System.Drawing.Size(41, 21)
        Me.Frequency.TabIndex = 17
        Me.Frequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Frequency.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'DisksSettings
        '
        Me.DisksSettings.Controls.Add(Me.SlaveBrowseDrive)
        Me.DisksSettings.Controls.Add(Me.SlaveTypeLabel)
        Me.DisksSettings.Controls.Add(Me.SlaveImageLabel)
        Me.DisksSettings.Controls.Add(Me.SlaveDrive)
        Me.DisksSettings.Controls.Add(Me.SlaveEnabled)
        Me.DisksSettings.Controls.Add(Me.SlaveDriveType)
        Me.DisksSettings.Controls.Add(Me.MasterDriveTypeBasic)
        Me.DisksSettings.Controls.Add(Me.MasterBrowseDrive)
        Me.DisksSettings.Controls.Add(Me.MasterTypeLabel)
        Me.DisksSettings.Controls.Add(Me.MasterImageLabel)
        Me.DisksSettings.Controls.Add(Me.MasterDrive)
        Me.DisksSettings.Controls.Add(Me.MasterEnabled)
        Me.DisksSettings.Controls.Add(Me.MasterDriveType)
        Me.DisksSettings.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisksSettings.ForeColor = System.Drawing.SystemColors.Highlight
        Me.DisksSettings.Location = New System.Drawing.Point(0, 177)
        Me.DisksSettings.Name = "DisksSettings"
        Me.DisksSettings.Size = New System.Drawing.Size(420, 200)
        Me.DisksSettings.TabIndex = 17
        Me.DisksSettings.TabStop = False
        Me.DisksSettings.Text = "Disks"
        '
        'SlaveBrowseDrive
        '
        Me.SlaveBrowseDrive.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlaveBrowseDrive.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SlaveBrowseDrive.Location = New System.Drawing.Point(382, 143)
        Me.SlaveBrowseDrive.Name = "SlaveBrowseDrive"
        Me.SlaveBrowseDrive.Size = New System.Drawing.Size(32, 23)
        Me.SlaveBrowseDrive.TabIndex = 30
        Me.SlaveBrowseDrive.Text = "..."
        Me.SlaveBrowseDrive.UseVisualStyleBackColor = True
        '
        'SlaveTypeLabel
        '
        Me.SlaveTypeLabel.AutoSize = True
        Me.SlaveTypeLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlaveTypeLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SlaveTypeLabel.Location = New System.Drawing.Point(6, 121)
        Me.SlaveTypeLabel.Name = "SlaveTypeLabel"
        Me.SlaveTypeLabel.Size = New System.Drawing.Size(61, 13)
        Me.SlaveTypeLabel.TabIndex = 28
        Me.SlaveTypeLabel.Text = "Drive type:"
        '
        'SlaveImageLabel
        '
        Me.SlaveImageLabel.AutoSize = True
        Me.SlaveImageLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlaveImageLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SlaveImageLabel.Location = New System.Drawing.Point(6, 148)
        Me.SlaveImageLabel.Name = "SlaveImageLabel"
        Me.SlaveImageLabel.Size = New System.Drawing.Size(51, 13)
        Me.SlaveImageLabel.TabIndex = 29
        Me.SlaveImageLabel.Text = "Location:"
        '
        'SlaveDrive
        '
        Me.SlaveDrive.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlaveDrive.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SlaveDrive.Location = New System.Drawing.Point(118, 145)
        Me.SlaveDrive.Name = "SlaveDrive"
        Me.SlaveDrive.Size = New System.Drawing.Size(258, 21)
        Me.SlaveDrive.TabIndex = 29
        '
        'SlaveEnabled
        '
        Me.SlaveEnabled.AutoSize = True
        Me.SlaveEnabled.Checked = True
        Me.SlaveEnabled.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SlaveEnabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlaveEnabled.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SlaveEnabled.Location = New System.Drawing.Point(9, 101)
        Me.SlaveEnabled.Name = "SlaveEnabled"
        Me.SlaveEnabled.Size = New System.Drawing.Size(115, 17)
        Me.SlaveEnabled.TabIndex = 27
        Me.SlaveEnabled.Text = "Enable Slave Drive"
        Me.SlaveEnabled.UseVisualStyleBackColor = True
        '
        'SlaveDriveType
        '
        Me.SlaveDriveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SlaveDriveType.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlaveDriveType.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SlaveDriveType.FormattingEnabled = True
        Me.SlaveDriveType.Items.AddRange(New Object() {"Hard disk", "CD-ROM", "Physical drive"})
        Me.SlaveDriveType.Location = New System.Drawing.Point(118, 118)
        Me.SlaveDriveType.Name = "SlaveDriveType"
        Me.SlaveDriveType.Size = New System.Drawing.Size(121, 21)
        Me.SlaveDriveType.TabIndex = 28
        '
        'MasterDriveTypeBasic
        '
        Me.MasterDriveTypeBasic.AutoSize = True
        Me.MasterDriveTypeBasic.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterDriveTypeBasic.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MasterDriveTypeBasic.Location = New System.Drawing.Point(117, 40)
        Me.MasterDriveTypeBasic.Name = "MasterDriveTypeBasic"
        Me.MasterDriveTypeBasic.Size = New System.Drawing.Size(51, 13)
        Me.MasterDriveTypeBasic.TabIndex = 26
        Me.MasterDriveTypeBasic.Text = "Hard disk"
        '
        'MasterBrowseDrive
        '
        Me.MasterBrowseDrive.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterBrowseDrive.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MasterBrowseDrive.Location = New System.Drawing.Point(382, 64)
        Me.MasterBrowseDrive.Name = "MasterBrowseDrive"
        Me.MasterBrowseDrive.Size = New System.Drawing.Size(32, 23)
        Me.MasterBrowseDrive.TabIndex = 21
        Me.MasterBrowseDrive.Text = "..."
        Me.MasterBrowseDrive.UseVisualStyleBackColor = True
        '
        'MasterTypeLabel
        '
        Me.MasterTypeLabel.AutoSize = True
        Me.MasterTypeLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterTypeLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MasterTypeLabel.Location = New System.Drawing.Point(6, 40)
        Me.MasterTypeLabel.Name = "MasterTypeLabel"
        Me.MasterTypeLabel.Size = New System.Drawing.Size(61, 13)
        Me.MasterTypeLabel.TabIndex = 18
        Me.MasterTypeLabel.Text = "Drive type:"
        '
        'MasterImageLabel
        '
        Me.MasterImageLabel.AutoSize = True
        Me.MasterImageLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterImageLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MasterImageLabel.Location = New System.Drawing.Point(6, 69)
        Me.MasterImageLabel.Name = "MasterImageLabel"
        Me.MasterImageLabel.Size = New System.Drawing.Size(51, 13)
        Me.MasterImageLabel.TabIndex = 19
        Me.MasterImageLabel.Text = "Location:"
        '
        'MasterDrive
        '
        Me.MasterDrive.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterDrive.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MasterDrive.Location = New System.Drawing.Point(118, 66)
        Me.MasterDrive.Name = "MasterDrive"
        Me.MasterDrive.Size = New System.Drawing.Size(258, 21)
        Me.MasterDrive.TabIndex = 20
        '
        'MasterEnabled
        '
        Me.MasterEnabled.AutoSize = True
        Me.MasterEnabled.Checked = True
        Me.MasterEnabled.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MasterEnabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterEnabled.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MasterEnabled.Location = New System.Drawing.Point(8, 20)
        Me.MasterEnabled.Name = "MasterEnabled"
        Me.MasterEnabled.Size = New System.Drawing.Size(122, 17)
        Me.MasterEnabled.TabIndex = 18
        Me.MasterEnabled.Text = "Enable Master Drive"
        Me.MasterEnabled.UseVisualStyleBackColor = True
        '
        'MasterDriveType
        '
        Me.MasterDriveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MasterDriveType.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterDriveType.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MasterDriveType.FormattingEnabled = True
        Me.MasterDriveType.Items.AddRange(New Object() {"Hard disk", "CD-ROM", "Physical drive"})
        Me.MasterDriveType.Location = New System.Drawing.Point(118, 37)
        Me.MasterDriveType.Name = "MasterDriveType"
        Me.MasterDriveType.Size = New System.Drawing.Size(121, 21)
        Me.MasterDriveType.TabIndex = 19
        Me.MasterDriveType.TabStop = False
        Me.MasterDriveType.Visible = False
        '
        'SelectDrive
        '
        Me.SelectDrive.Description = "Select a physical drive to use with PearPC"
        '
        'NetworkSettings
        '
        Me.NetworkSettings.Controls.Add(Me.Net8139MacLabel)
        Me.NetworkSettings.Controls.Add(Me.Net3c90MacLabel)
        Me.NetworkSettings.Controls.Add(Me.Mac68139)
        Me.NetworkSettings.Controls.Add(Me.Mac58139)
        Me.NetworkSettings.Controls.Add(Me.Mac48139)
        Me.NetworkSettings.Controls.Add(Me.Mac38139)
        Me.NetworkSettings.Controls.Add(Me.Mac28139)
        Me.NetworkSettings.Controls.Add(Me.Mac18139)
        Me.NetworkSettings.Controls.Add(Me.Mac63c90)
        Me.NetworkSettings.Controls.Add(Me.Mac53c90)
        Me.NetworkSettings.Controls.Add(Me.Mac43c90)
        Me.NetworkSettings.Controls.Add(Me.Mac33c90)
        Me.NetworkSettings.Controls.Add(Me.Mac23c90)
        Me.NetworkSettings.Controls.Add(Me.Mac13c90)
        Me.NetworkSettings.Controls.Add(Me.NetRTL8139)
        Me.NetworkSettings.Controls.Add(Me.Net3c90x)
        Me.NetworkSettings.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NetworkSettings.ForeColor = System.Drawing.SystemColors.Highlight
        Me.NetworkSettings.Location = New System.Drawing.Point(426, 77)
        Me.NetworkSettings.Name = "NetworkSettings"
        Me.NetworkSettings.Size = New System.Drawing.Size(273, 114)
        Me.NetworkSettings.TabIndex = 19
        Me.NetworkSettings.TabStop = False
        Me.NetworkSettings.Text = "Network"
        '
        'Net8139MacLabel
        '
        Me.Net8139MacLabel.AutoSize = True
        Me.Net8139MacLabel.Enabled = False
        Me.Net8139MacLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Net8139MacLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Net8139MacLabel.Location = New System.Drawing.Point(6, 91)
        Me.Net8139MacLabel.Name = "Net8139MacLabel"
        Me.Net8139MacLabel.Size = New System.Drawing.Size(33, 13)
        Me.Net8139MacLabel.TabIndex = 20
        Me.Net8139MacLabel.Text = "MAC:"
        '
        'Net3c90MacLabel
        '
        Me.Net3c90MacLabel.AutoSize = True
        Me.Net3c90MacLabel.Enabled = False
        Me.Net3c90MacLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Net3c90MacLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Net3c90MacLabel.Location = New System.Drawing.Point(6, 41)
        Me.Net3c90MacLabel.Name = "Net3c90MacLabel"
        Me.Net3c90MacLabel.Size = New System.Drawing.Size(33, 13)
        Me.Net3c90MacLabel.TabIndex = 19
        Me.Net3c90MacLabel.Text = "MAC:"
        '
        'Mac68139
        '
        Me.Mac68139.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Mac68139.Enabled = False
        Me.Mac68139.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mac68139.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Mac68139.Location = New System.Drawing.Point(207, 88)
        Me.Mac68139.MaxLength = 2
        Me.Mac68139.Name = "Mac68139"
        Me.Mac68139.Size = New System.Drawing.Size(27, 21)
        Me.Mac68139.TabIndex = 13
        Me.Mac68139.Text = "01"
        '
        'Mac58139
        '
        Me.Mac58139.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Mac58139.Enabled = False
        Me.Mac58139.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mac58139.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Mac58139.Location = New System.Drawing.Point(174, 88)
        Me.Mac58139.MaxLength = 2
        Me.Mac58139.Name = "Mac58139"
        Me.Mac58139.Size = New System.Drawing.Size(27, 21)
        Me.Mac58139.TabIndex = 12
        Me.Mac58139.Text = "25"
        '
        'Mac48139
        '
        Me.Mac48139.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Mac48139.Enabled = False
        Me.Mac48139.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mac48139.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Mac48139.Location = New System.Drawing.Point(141, 88)
        Me.Mac48139.MaxLength = 2
        Me.Mac48139.Name = "Mac48139"
        Me.Mac48139.Size = New System.Drawing.Size(27, 21)
        Me.Mac48139.TabIndex = 11
        Me.Mac48139.Text = "58"
        '
        'Mac38139
        '
        Me.Mac38139.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Mac38139.Enabled = False
        Me.Mac38139.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mac38139.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Mac38139.Location = New System.Drawing.Point(108, 88)
        Me.Mac38139.MaxLength = 2
        Me.Mac38139.Name = "Mac38139"
        Me.Mac38139.Size = New System.Drawing.Size(27, 21)
        Me.Mac38139.TabIndex = 10
        Me.Mac38139.Text = "PC"
        '
        'Mac28139
        '
        Me.Mac28139.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Mac28139.Enabled = False
        Me.Mac28139.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mac28139.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Mac28139.Location = New System.Drawing.Point(75, 88)
        Me.Mac28139.MaxLength = 2
        Me.Mac28139.Name = "Mac28139"
        Me.Mac28139.Size = New System.Drawing.Size(27, 21)
        Me.Mac28139.TabIndex = 9
        Me.Mac28139.Text = "AR"
        '
        'Mac18139
        '
        Me.Mac18139.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Mac18139.Enabled = False
        Me.Mac18139.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mac18139.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Mac18139.Location = New System.Drawing.Point(42, 88)
        Me.Mac18139.MaxLength = 2
        Me.Mac18139.Name = "Mac18139"
        Me.Mac18139.Size = New System.Drawing.Size(27, 21)
        Me.Mac18139.TabIndex = 8
        Me.Mac18139.Text = "PE"
        '
        'Mac63c90
        '
        Me.Mac63c90.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Mac63c90.Enabled = False
        Me.Mac63c90.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mac63c90.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Mac63c90.Location = New System.Drawing.Point(207, 38)
        Me.Mac63c90.MaxLength = 2
        Me.Mac63c90.Name = "Mac63c90"
        Me.Mac63c90.Size = New System.Drawing.Size(27, 21)
        Me.Mac63c90.TabIndex = 7
        Me.Mac63c90.Text = "34"
        '
        'Mac53c90
        '
        Me.Mac53c90.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Mac53c90.Enabled = False
        Me.Mac53c90.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mac53c90.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Mac53c90.Location = New System.Drawing.Point(174, 38)
        Me.Mac53c90.MaxLength = 2
        Me.Mac53c90.Name = "Mac53c90"
        Me.Mac53c90.Size = New System.Drawing.Size(27, 21)
        Me.Mac53c90.TabIndex = 6
        Me.Mac53c90.Text = "12"
        '
        'Mac43c90
        '
        Me.Mac43c90.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Mac43c90.Enabled = False
        Me.Mac43c90.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mac43c90.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Mac43c90.Location = New System.Drawing.Point(141, 38)
        Me.Mac43c90.MaxLength = 2
        Me.Mac43c90.Name = "Mac43c90"
        Me.Mac43c90.Size = New System.Drawing.Size(27, 21)
        Me.Mac43c90.TabIndex = 5
        Me.Mac43c90.Text = "FE"
        '
        'Mac33c90
        '
        Me.Mac33c90.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Mac33c90.Enabled = False
        Me.Mac33c90.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mac33c90.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Mac33c90.Location = New System.Drawing.Point(108, 38)
        Me.Mac33c90.MaxLength = 2
        Me.Mac33c90.Name = "Mac33c90"
        Me.Mac33c90.Size = New System.Drawing.Size(27, 21)
        Me.Mac33c90.TabIndex = 4
        Me.Mac33c90.Text = "CA"
        '
        'Mac23c90
        '
        Me.Mac23c90.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Mac23c90.Enabled = False
        Me.Mac23c90.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mac23c90.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Mac23c90.Location = New System.Drawing.Point(75, 38)
        Me.Mac23c90.MaxLength = 2
        Me.Mac23c90.Name = "Mac23c90"
        Me.Mac23c90.Size = New System.Drawing.Size(27, 21)
        Me.Mac23c90.TabIndex = 3
        Me.Mac23c90.Text = "AD"
        '
        'Mac13c90
        '
        Me.Mac13c90.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Mac13c90.Enabled = False
        Me.Mac13c90.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mac13c90.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Mac13c90.Location = New System.Drawing.Point(42, 38)
        Me.Mac13c90.MaxLength = 2
        Me.Mac13c90.Name = "Mac13c90"
        Me.Mac13c90.Size = New System.Drawing.Size(27, 21)
        Me.Mac13c90.TabIndex = 2
        Me.Mac13c90.Text = "DE"
        '
        'NetRTL8139
        '
        Me.NetRTL8139.AutoSize = True
        Me.NetRTL8139.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NetRTL8139.ForeColor = System.Drawing.SystemColors.ControlText
        Me.NetRTL8139.Location = New System.Drawing.Point(6, 66)
        Me.NetRTL8139.Name = "NetRTL8139"
        Me.NetRTL8139.Size = New System.Drawing.Size(137, 17)
        Me.NetRTL8139.TabIndex = 1
        Me.NetRTL8139.Text = "Network Card RTL8139"
        Me.NetRTL8139.UseVisualStyleBackColor = True
        '
        'Net3c90x
        '
        Me.Net3c90x.AutoSize = True
        Me.Net3c90x.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Net3c90x.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Net3c90x.Location = New System.Drawing.Point(6, 18)
        Me.Net3c90x.Name = "Net3c90x"
        Me.Net3c90x.Size = New System.Drawing.Size(124, 17)
        Me.Net3c90x.TabIndex = 0
        Me.Net3c90x.Text = "Network Card 3c90x"
        Me.Net3c90x.UseVisualStyleBackColor = True
        '
        'MiscellaneousSettings
        '
        Me.MiscellaneousSettings.Controls.Add(Me.EnableSerialPort)
        Me.MiscellaneousSettings.Controls.Add(Me.ComposeDialogKeyLabel)
        Me.MiscellaneousSettings.Controls.Add(Me.ComposeDialogKey)
        Me.MiscellaneousSettings.Controls.Add(Me.ChangeCDKeyLabel)
        Me.MiscellaneousSettings.Controls.Add(Me.ChangeCDKey)
        Me.MiscellaneousSettings.Controls.Add(Me.MouseGrabKeyLabel)
        Me.MiscellaneousSettings.Controls.Add(Me.EnableUSB)
        Me.MiscellaneousSettings.Controls.Add(Me.MouseToggleKey)
        Me.MiscellaneousSettings.Controls.Add(Me.MB)
        Me.MiscellaneousSettings.Controls.Add(Me.RAM)
        Me.MiscellaneousSettings.Controls.Add(Me.ProcessorLabel)
        Me.MiscellaneousSettings.Controls.Add(Me.RAMLabel)
        Me.MiscellaneousSettings.Controls.Add(Me.PPCG4)
        Me.MiscellaneousSettings.Controls.Add(Me.PPCG3)
        Me.MiscellaneousSettings.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiscellaneousSettings.ForeColor = System.Drawing.SystemColors.Highlight
        Me.MiscellaneousSettings.Location = New System.Drawing.Point(3, 382)
        Me.MiscellaneousSettings.Name = "MiscellaneousSettings"
        Me.MiscellaneousSettings.Size = New System.Drawing.Size(417, 93)
        Me.MiscellaneousSettings.TabIndex = 18
        Me.MiscellaneousSettings.TabStop = False
        Me.MiscellaneousSettings.Text = "Miscellaneous Settings"
        '
        'EnableSerialPort
        '
        Me.EnableSerialPort.AutoSize = True
        Me.EnableSerialPort.BackColor = System.Drawing.Color.Transparent
        Me.EnableSerialPort.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnableSerialPort.ForeColor = System.Drawing.SystemColors.ControlText
        Me.EnableSerialPort.Location = New System.Drawing.Point(169, 71)
        Me.EnableSerialPort.Name = "EnableSerialPort"
        Me.EnableSerialPort.Size = New System.Drawing.Size(151, 17)
        Me.EnableSerialPort.TabIndex = 28
        Me.EnableSerialPort.Text = "Enable serial port (Debug)"
        Me.EnableSerialPort.UseVisualStyleBackColor = False
        Me.EnableSerialPort.Visible = False
        '
        'ComposeDialogKeyLabel
        '
        Me.ComposeDialogKeyLabel.AutoSize = True
        Me.ComposeDialogKeyLabel.BackColor = System.Drawing.Color.Transparent
        Me.ComposeDialogKeyLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ComposeDialogKeyLabel.Location = New System.Drawing.Point(309, 54)
        Me.ComposeDialogKeyLabel.Name = "ComposeDialogKeyLabel"
        Me.ComposeDialogKeyLabel.Size = New System.Drawing.Size(102, 13)
        Me.ComposeDialogKeyLabel.TabIndex = 27
        Me.ComposeDialogKeyLabel.Text = "Compose dialog key"
        Me.ComposeDialogKeyLabel.Visible = False
        '
        'ComposeDialogKey
        '
        Me.ComposeDialogKey.Location = New System.Drawing.Point(333, 70)
        Me.ComposeDialogKey.Name = "ComposeDialogKey"
        Me.ComposeDialogKey.Size = New System.Drawing.Size(78, 21)
        Me.ComposeDialogKey.TabIndex = 26
        Me.ComposeDialogKey.Text = "Ctrl+F11"
        Me.ComposeDialogKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ComposeDialogKey.Visible = False
        '
        'ChangeCDKeyLabel
        '
        Me.ChangeCDKeyLabel.AutoSize = True
        Me.ChangeCDKeyLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChangeCDKeyLabel.Location = New System.Drawing.Point(239, 15)
        Me.ChangeCDKeyLabel.Name = "ChangeCDKeyLabel"
        Me.ChangeCDKeyLabel.Size = New System.Drawing.Size(81, 13)
        Me.ChangeCDKeyLabel.TabIndex = 25
        Me.ChangeCDKeyLabel.Text = "Change CD key"
        '
        'ChangeCDKey
        '
        Me.ChangeCDKey.Location = New System.Drawing.Point(242, 29)
        Me.ChangeCDKey.Name = "ChangeCDKey"
        Me.ChangeCDKey.Size = New System.Drawing.Size(78, 21)
        Me.ChangeCDKey.TabIndex = 24
        Me.ChangeCDKey.Text = "Ctrl+F12"
        Me.ChangeCDKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MouseGrabKeyLabel
        '
        Me.MouseGrabKeyLabel.AutoSize = True
        Me.MouseGrabKeyLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MouseGrabKeyLabel.Location = New System.Drawing.Point(330, 15)
        Me.MouseGrabKeyLabel.Name = "MouseGrabKeyLabel"
        Me.MouseGrabKeyLabel.Size = New System.Drawing.Size(83, 13)
        Me.MouseGrabKeyLabel.TabIndex = 23
        Me.MouseGrabKeyLabel.Text = "Mouse grab key"
        '
        'EnableUSB
        '
        Me.EnableUSB.AutoSize = True
        Me.EnableUSB.BackColor = System.Drawing.Color.Transparent
        Me.EnableUSB.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnableUSB.ForeColor = System.Drawing.SystemColors.ControlText
        Me.EnableUSB.Location = New System.Drawing.Point(169, 53)
        Me.EnableUSB.Name = "EnableUSB"
        Me.EnableUSB.Size = New System.Drawing.Size(129, 17)
        Me.EnableUSB.TabIndex = 20
        Me.EnableUSB.Text = "Enable USB emulation"
        Me.EnableUSB.UseVisualStyleBackColor = False
        '
        'MouseToggleKey
        '
        Me.MouseToggleKey.Location = New System.Drawing.Point(333, 29)
        Me.MouseToggleKey.Name = "MouseToggleKey"
        Me.MouseToggleKey.Size = New System.Drawing.Size(78, 21)
        Me.MouseToggleKey.TabIndex = 22
        Me.MouseToggleKey.Text = "F12"
        Me.MouseToggleKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MB
        '
        Me.MB.AutoSize = True
        Me.MB.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MB.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MB.Location = New System.Drawing.Point(215, 30)
        Me.MB.Name = "MB"
        Me.MB.Size = New System.Drawing.Size(21, 13)
        Me.MB.TabIndex = 20
        Me.MB.Text = "MB"
        '
        'RAM
        '
        Me.RAM.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RAM.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RAM.Location = New System.Drawing.Point(169, 27)
        Me.RAM.MaxLength = 4
        Me.RAM.Name = "RAM"
        Me.RAM.Size = New System.Drawing.Size(45, 21)
        Me.RAM.TabIndex = 5
        Me.RAM.Text = "256"
        Me.RAM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ProcessorLabel
        '
        Me.ProcessorLabel.AutoSize = True
        Me.ProcessorLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProcessorLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ProcessorLabel.Location = New System.Drawing.Point(5, 13)
        Me.ProcessorLabel.Name = "ProcessorLabel"
        Me.ProcessorLabel.Size = New System.Drawing.Size(58, 13)
        Me.ProcessorLabel.TabIndex = 4
        Me.ProcessorLabel.Text = "Processor:"
        '
        'RAMLabel
        '
        Me.RAMLabel.AutoSize = True
        Me.RAMLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RAMLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RAMLabel.Location = New System.Drawing.Point(166, 13)
        Me.RAMLabel.Name = "RAMLabel"
        Me.RAMLabel.Size = New System.Drawing.Size(29, 13)
        Me.RAMLabel.TabIndex = 3
        Me.RAMLabel.Text = "RAM"
        '
        'PPCG4
        '
        Me.PPCG4.AutoSize = True
        Me.PPCG4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PPCG4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PPCG4.Location = New System.Drawing.Point(5, 54)
        Me.PPCG4.Name = "PPCG4"
        Me.PPCG4.Size = New System.Drawing.Size(84, 17)
        Me.PPCG4.TabIndex = 1
        Me.PPCG4.Text = "PowerPC G4"
        Me.PPCG4.UseVisualStyleBackColor = True
        '
        'PPCG3
        '
        Me.PPCG3.AutoSize = True
        Me.PPCG3.Checked = True
        Me.PPCG3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PPCG3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PPCG3.Location = New System.Drawing.Point(5, 31)
        Me.PPCG3.Name = "PPCG3"
        Me.PPCG3.Size = New System.Drawing.Size(165, 17)
        Me.PPCG3.TabIndex = 1
        Me.PPCG3.TabStop = True
        Me.PPCG3.Text = "PowerPC G3 (Recommended)"
        Me.PPCG3.UseVisualStyleBackColor = True
        '
        'AdvancedSettings
        '
        Me.AdvancedSettings.Controls.Add(Me.AdvancedWarning)
        Me.AdvancedSettings.Controls.Add(Me.PageTable)
        Me.AdvancedSettings.Controls.Add(Me.PageTableLabel)
        Me.AdvancedSettings.Controls.Add(Me.NVRAMFile)
        Me.AdvancedSettings.Controls.Add(Me.NVRAMFileLabel)
        Me.AdvancedSettings.Controls.Add(Me.BootMode)
        Me.AdvancedSettings.Controls.Add(Me.BootAuto)
        Me.AdvancedSettings.Controls.Add(Me.BootSelect)
        Me.AdvancedSettings.Controls.Add(Me.BootForce)
        Me.AdvancedSettings.Controls.Add(Me.MachArguments)
        Me.AdvancedSettings.Controls.Add(Me.BootArguments)
        Me.AdvancedSettings.Controls.Add(Me.MachArgumentsLabel)
        Me.AdvancedSettings.Controls.Add(Me.BootArgumentsLabel)
        Me.AdvancedSettings.Controls.Add(Me.PROMBootPath)
        Me.AdvancedSettings.Controls.Add(Me.PROMFile)
        Me.AdvancedSettings.Controls.Add(Me.PROMBootPathLabel)
        Me.AdvancedSettings.Controls.Add(Me.PROMFileLabel)
        Me.AdvancedSettings.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdvancedSettings.ForeColor = System.Drawing.SystemColors.Highlight
        Me.AdvancedSettings.Location = New System.Drawing.Point(426, 197)
        Me.AdvancedSettings.Name = "AdvancedSettings"
        Me.AdvancedSettings.Size = New System.Drawing.Size(272, 243)
        Me.AdvancedSettings.TabIndex = 20
        Me.AdvancedSettings.TabStop = False
        Me.AdvancedSettings.Text = "Advanced"
        Me.AdvancedSettings.Visible = False
        '
        'AdvancedWarning
        '
        Me.AdvancedWarning.AutoSize = True
        Me.AdvancedWarning.ForeColor = System.Drawing.Color.Red
        Me.AdvancedWarning.Location = New System.Drawing.Point(3, 44)
        Me.AdvancedWarning.Name = "AdvancedWarning"
        Me.AdvancedWarning.Size = New System.Drawing.Size(261, 13)
        Me.AdvancedWarning.TabIndex = 16
        Me.AdvancedWarning.Text = "Warning! Only change if you know what you're doing"
        '
        'PageTable
        '
        Me.PageTable.Location = New System.Drawing.Point(75, 212)
        Me.PageTable.MaxLength = 10
        Me.PageTable.Name = "PageTable"
        Me.PageTable.Size = New System.Drawing.Size(191, 21)
        Me.PageTable.TabIndex = 15
        Me.PageTable.Text = "0x00300000"
        '
        'PageTableLabel
        '
        Me.PageTableLabel.AutoSize = True
        Me.PageTableLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PageTableLabel.Location = New System.Drawing.Point(6, 215)
        Me.PageTableLabel.Name = "PageTableLabel"
        Me.PageTableLabel.Size = New System.Drawing.Size(64, 13)
        Me.PageTableLabel.TabIndex = 14
        Me.PageTableLabel.Text = "Page Table:"
        '
        'NVRAMFile
        '
        Me.NVRAMFile.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NVRAMFile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.NVRAMFile.Location = New System.Drawing.Point(75, 185)
        Me.NVRAMFile.Name = "NVRAMFile"
        Me.NVRAMFile.Size = New System.Drawing.Size(191, 21)
        Me.NVRAMFile.TabIndex = 13
        Me.NVRAMFile.Text = "Nvram"
        '
        'NVRAMFileLabel
        '
        Me.NVRAMFileLabel.AutoSize = True
        Me.NVRAMFileLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NVRAMFileLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.NVRAMFileLabel.Location = New System.Drawing.Point(6, 188)
        Me.NVRAMFileLabel.Name = "NVRAMFileLabel"
        Me.NVRAMFileLabel.Size = New System.Drawing.Size(65, 13)
        Me.NVRAMFileLabel.TabIndex = 12
        Me.NVRAMFileLabel.Text = "NVRAM File:"
        '
        'BootMode
        '
        Me.BootMode.AutoSize = True
        Me.BootMode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BootMode.Location = New System.Drawing.Point(6, 20)
        Me.BootMode.Name = "BootMode"
        Me.BootMode.Size = New System.Drawing.Size(58, 13)
        Me.BootMode.TabIndex = 11
        Me.BootMode.Text = "Boot Mode"
        '
        'BootAuto
        '
        Me.BootAuto.AutoSize = True
        Me.BootAuto.Checked = True
        Me.BootAuto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BootAuto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BootAuto.Location = New System.Drawing.Point(82, 18)
        Me.BootAuto.Name = "BootAuto"
        Me.BootAuto.Size = New System.Drawing.Size(48, 17)
        Me.BootAuto.TabIndex = 10
        Me.BootAuto.TabStop = True
        Me.BootAuto.Text = "Auto"
        Me.BootAuto.UseVisualStyleBackColor = True
        '
        'BootSelect
        '
        Me.BootSelect.AutoSize = True
        Me.BootSelect.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BootSelect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BootSelect.Location = New System.Drawing.Point(136, 18)
        Me.BootSelect.Name = "BootSelect"
        Me.BootSelect.Size = New System.Drawing.Size(54, 17)
        Me.BootSelect.TabIndex = 9
        Me.BootSelect.TabStop = True
        Me.BootSelect.Text = "Select"
        Me.BootSelect.UseVisualStyleBackColor = True
        '
        'BootForce
        '
        Me.BootForce.AutoSize = True
        Me.BootForce.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BootForce.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BootForce.Location = New System.Drawing.Point(196, 18)
        Me.BootForce.Name = "BootForce"
        Me.BootForce.Size = New System.Drawing.Size(52, 17)
        Me.BootForce.TabIndex = 8
        Me.BootForce.TabStop = True
        Me.BootForce.Text = "Force"
        Me.BootForce.UseVisualStyleBackColor = True
        '
        'MachArguments
        '
        Me.MachArguments.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MachArguments.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MachArguments.Location = New System.Drawing.Point(99, 125)
        Me.MachArguments.Name = "MachArguments"
        Me.MachArguments.Size = New System.Drawing.Size(167, 21)
        Me.MachArguments.TabIndex = 7
        '
        'BootArguments
        '
        Me.BootArguments.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BootArguments.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BootArguments.Location = New System.Drawing.Point(99, 155)
        Me.BootArguments.Name = "BootArguments"
        Me.BootArguments.Size = New System.Drawing.Size(167, 21)
        Me.BootArguments.TabIndex = 6
        '
        'MachArgumentsLabel
        '
        Me.MachArgumentsLabel.AutoSize = True
        Me.MachArgumentsLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MachArgumentsLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MachArgumentsLabel.Location = New System.Drawing.Point(6, 128)
        Me.MachArgumentsLabel.Name = "MachArgumentsLabel"
        Me.MachArgumentsLabel.Size = New System.Drawing.Size(91, 13)
        Me.MachArgumentsLabel.TabIndex = 5
        Me.MachArgumentsLabel.Text = "Mach Arguments:"
        '
        'BootArgumentsLabel
        '
        Me.BootArgumentsLabel.AutoSize = True
        Me.BootArgumentsLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BootArgumentsLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BootArgumentsLabel.Location = New System.Drawing.Point(6, 158)
        Me.BootArgumentsLabel.Name = "BootArgumentsLabel"
        Me.BootArgumentsLabel.Size = New System.Drawing.Size(88, 13)
        Me.BootArgumentsLabel.TabIndex = 4
        Me.BootArgumentsLabel.Text = "Boot Arguments:"
        '
        'PROMBootPath
        '
        Me.PROMBootPath.Enabled = False
        Me.PROMBootPath.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PROMBootPath.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PROMBootPath.Location = New System.Drawing.Point(64, 95)
        Me.PROMBootPath.Name = "PROMBootPath"
        Me.PROMBootPath.Size = New System.Drawing.Size(202, 21)
        Me.PROMBootPath.TabIndex = 3
        '
        'PROMFile
        '
        Me.PROMFile.Enabled = False
        Me.PROMFile.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PROMFile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PROMFile.Location = New System.Drawing.Point(64, 65)
        Me.PROMFile.Name = "PROMFile"
        Me.PROMFile.Size = New System.Drawing.Size(202, 21)
        Me.PROMFile.TabIndex = 2
        '
        'PROMBootPathLabel
        '
        Me.PROMBootPathLabel.AutoSize = True
        Me.PROMBootPathLabel.Enabled = False
        Me.PROMBootPathLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PROMBootPathLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PROMBootPathLabel.Location = New System.Drawing.Point(6, 98)
        Me.PROMBootPathLabel.Name = "PROMBootPathLabel"
        Me.PROMBootPathLabel.Size = New System.Drawing.Size(58, 13)
        Me.PROMBootPathLabel.TabIndex = 1
        Me.PROMBootPathLabel.Text = "Boot Path:"
        '
        'PROMFileLabel
        '
        Me.PROMFileLabel.AutoSize = True
        Me.PROMFileLabel.Enabled = False
        Me.PROMFileLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PROMFileLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PROMFileLabel.Location = New System.Drawing.Point(6, 68)
        Me.PROMFileLabel.Name = "PROMFileLabel"
        Me.PROMFileLabel.Size = New System.Drawing.Size(59, 13)
        Me.PROMFileLabel.TabIndex = 0
        Me.PROMFileLabel.Text = "PROM File:"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(710, 484)
        Me.Controls.Add(Me.AdvancedSettings)
        Me.Controls.Add(Me.DisksSettings)
        Me.Controls.Add(Me.MiscellaneousSettings)
        Me.Controls.Add(Me.NetworkSettings)
        Me.Controls.Add(Me.GraphicSettings)
        Me.Controls.Add(Me.ShowAdvanced)
        Me.Controls.Add(Me.WelcomeText)
        Me.Controls.Add(Me.CreateConfig)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Text = "PearPC Config File Generator"
        Me.GraphicSettings.ResumeLayout(False)
        Me.GraphicSettings.PerformLayout()
        CType(Me.Frequency, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DisksSettings.ResumeLayout(False)
        Me.DisksSettings.PerformLayout()
        Me.NetworkSettings.ResumeLayout(False)
        Me.NetworkSettings.PerformLayout()
        Me.MiscellaneousSettings.ResumeLayout(False)
        Me.MiscellaneousSettings.PerformLayout()
        Me.AdvancedSettings.ResumeLayout(False)
        Me.AdvancedSettings.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CreateConfig As System.Windows.Forms.Button
    Friend WithEvents SaveConfigFile As System.Windows.Forms.SaveFileDialog
    Friend WithEvents StandardResolution As System.Windows.Forms.ComboBox
    Friend WithEvents BitDepth As System.Windows.Forms.ComboBox
    Friend WithEvents WelcomeText As System.Windows.Forms.Label
    Friend WithEvents Resolution As System.Windows.Forms.Label
    Friend WithEvents CustomResolutionCheck As System.Windows.Forms.CheckBox
    Friend WithEvents FullscreenCheck As System.Windows.Forms.CheckBox
    Friend WithEvents Fullscreen As System.Windows.Forms.Label
    Friend WithEvents XCustomResolution As System.Windows.Forms.TextBox
    Friend WithEvents YCustomResolution As System.Windows.Forms.TextBox
    Friend WithEvents Browser As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToggleFullscreenKeyLabel As System.Windows.Forms.Label
    Friend WithEvents ToggleFullscreenKey As System.Windows.Forms.TextBox
    Friend WithEvents ShowAdvanced As System.Windows.Forms.CheckBox
    Friend WithEvents Redraw As System.Windows.Forms.Label
    Friend WithEvents RedrawTime As System.Windows.Forms.TextBox
    Friend WithEvents GraphicSettings As System.Windows.Forms.GroupBox
    Friend WithEvents Frequency As System.Windows.Forms.NumericUpDown
    Friend WithEvents DisksSettings As System.Windows.Forms.GroupBox
    Friend WithEvents MasterTypeLabel As System.Windows.Forms.Label
    Friend WithEvents MasterImageLabel As System.Windows.Forms.Label
    Friend WithEvents MasterDrive As System.Windows.Forms.TextBox
    Friend WithEvents MasterEnabled As System.Windows.Forms.CheckBox
    Friend WithEvents MasterDriveType As System.Windows.Forms.ComboBox
    Friend WithEvents MasterBrowseDrive As System.Windows.Forms.Button
    Friend WithEvents SelectDrive As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents MasterDriveTypeBasic As System.Windows.Forms.Label
    Friend WithEvents SlaveBrowseDrive As System.Windows.Forms.Button
    Friend WithEvents SlaveTypeLabel As System.Windows.Forms.Label
    Friend WithEvents SlaveImageLabel As System.Windows.Forms.Label
    Friend WithEvents SlaveDrive As System.Windows.Forms.TextBox
    Friend WithEvents SlaveEnabled As System.Windows.Forms.CheckBox
    Friend WithEvents SlaveDriveType As System.Windows.Forms.ComboBox
    Friend WithEvents BrowseDriver As System.Windows.Forms.Button
    Friend WithEvents GraphicDriver As System.Windows.Forms.TextBox
    Friend WithEvents GraphicDriverLabel As System.Windows.Forms.Label
    Friend WithEvents NetworkSettings As System.Windows.Forms.GroupBox
    Friend WithEvents NetRTL8139 As System.Windows.Forms.CheckBox
    Friend WithEvents Net3c90x As System.Windows.Forms.CheckBox
    Friend WithEvents Mac68139 As System.Windows.Forms.TextBox
    Friend WithEvents Mac58139 As System.Windows.Forms.TextBox
    Friend WithEvents Mac48139 As System.Windows.Forms.TextBox
    Friend WithEvents Mac38139 As System.Windows.Forms.TextBox
    Friend WithEvents Mac28139 As System.Windows.Forms.TextBox
    Friend WithEvents Mac18139 As System.Windows.Forms.TextBox
    Friend WithEvents Mac63c90 As System.Windows.Forms.TextBox
    Friend WithEvents Mac53c90 As System.Windows.Forms.TextBox
    Friend WithEvents Mac43c90 As System.Windows.Forms.TextBox
    Friend WithEvents Mac33c90 As System.Windows.Forms.TextBox
    Friend WithEvents Mac23c90 As System.Windows.Forms.TextBox
    Friend WithEvents Mac13c90 As System.Windows.Forms.TextBox
    Friend WithEvents Net8139MacLabel As System.Windows.Forms.Label
    Friend WithEvents Net3c90MacLabel As System.Windows.Forms.Label
    Friend WithEvents MiscellaneousSettings As System.Windows.Forms.GroupBox
    Friend WithEvents RAM As System.Windows.Forms.TextBox
    Friend WithEvents ProcessorLabel As System.Windows.Forms.Label
    Friend WithEvents RAMLabel As System.Windows.Forms.Label
    Friend WithEvents PPCG4 As System.Windows.Forms.RadioButton
    Friend WithEvents PPCG3 As System.Windows.Forms.RadioButton
    Friend WithEvents MB As System.Windows.Forms.Label
    Friend WithEvents EnableUSB As System.Windows.Forms.CheckBox
    Friend WithEvents AdvancedSettings As System.Windows.Forms.GroupBox
    Friend WithEvents PROMBootPath As System.Windows.Forms.TextBox
    Friend WithEvents PROMFile As System.Windows.Forms.TextBox
    Friend WithEvents PROMBootPathLabel As System.Windows.Forms.Label
    Friend WithEvents PROMFileLabel As System.Windows.Forms.Label
    Friend WithEvents MachArguments As System.Windows.Forms.TextBox
    Friend WithEvents BootArguments As System.Windows.Forms.TextBox
    Friend WithEvents MachArgumentsLabel As System.Windows.Forms.Label
    Friend WithEvents BootArgumentsLabel As System.Windows.Forms.Label
    Friend WithEvents NVRAMFile As System.Windows.Forms.TextBox
    Friend WithEvents NVRAMFileLabel As System.Windows.Forms.Label
    Friend WithEvents PageTableLabel As System.Windows.Forms.Label
    Friend WithEvents PageTable As System.Windows.Forms.TextBox
    Friend WithEvents MouseGrabKeyLabel As System.Windows.Forms.Label
    Friend WithEvents MouseToggleKey As System.Windows.Forms.TextBox
    Friend WithEvents AdvancedWarning As System.Windows.Forms.Label
    Friend WithEvents BootMode As System.Windows.Forms.Label
    Friend WithEvents BootAuto As System.Windows.Forms.RadioButton
    Friend WithEvents BootSelect As System.Windows.Forms.RadioButton
    Friend WithEvents BootForce As System.Windows.Forms.RadioButton
    Friend WithEvents ChangeCDKeyLabel As System.Windows.Forms.Label
    Friend WithEvents ChangeCDKey As System.Windows.Forms.TextBox
    Friend WithEvents ComposeDialogKeyLabel As System.Windows.Forms.Label
    Friend WithEvents ComposeDialogKey As System.Windows.Forms.TextBox
    Friend WithEvents EnableSerialPort As System.Windows.Forms.CheckBox

End Class
