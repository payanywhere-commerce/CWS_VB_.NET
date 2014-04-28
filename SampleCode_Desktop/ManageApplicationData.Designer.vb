Namespace SampleCode
    Partial Class ManageApplicationData
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.cmdDelete = New System.Windows.Forms.Button()
            Me.cmdSave = New System.Windows.Forms.Button()
            Me.cmdClose = New System.Windows.Forms.Button()
            Me.txtPTLSSocketId = New System.Windows.Forms.TextBox()
            Me.applicationProfileId = New System.Windows.Forms.Label()
            Me.txtApplicationProfileId = New System.Windows.Forms.TextBox()
            Me.label2 = New System.Windows.Forms.Label()
            Me.label3 = New System.Windows.Forms.Label()
            Me.label4 = New System.Windows.Forms.Label()
            Me.label5 = New System.Windows.Forms.Label()
            Me.label6 = New System.Windows.Forms.Label()
            Me.label7 = New System.Windows.Forms.Label()
            Me.label8 = New System.Windows.Forms.Label()
            Me.label9 = New System.Windows.Forms.Label()
            Me.label10 = New System.Windows.Forms.Label()
            Me.label11 = New System.Windows.Forms.Label()
            Me.label12 = New System.Windows.Forms.Label()
            Me.label13 = New System.Windows.Forms.Label()
            Me.txtApplicationName = New System.Windows.Forms.TextBox()
            Me.txtDeveloperId = New System.Windows.Forms.TextBox()
            Me.txtSerialNumber = New System.Windows.Forms.TextBox()
            Me.txtSoftwareVersion = New System.Windows.Forms.TextBox()
            Me.txtSoftwareVersionDate = New System.Windows.Forms.TextBox()
            Me.txtVendorId = New System.Windows.Forms.TextBox()
            Me.cboApplicationAttended = New System.Windows.Forms.ComboBox()
            Me.cboApplicationLocation = New System.Windows.Forms.ComboBox()
            Me.cboHardwareType = New System.Windows.Forms.ComboBox()
            Me.cboPINCapability = New System.Windows.Forms.ComboBox()
            Me.cboReadCapability = New System.Windows.Forms.ComboBox()
            Me.cmdPopulateTestValues = New System.Windows.Forms.Button()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
	Me.label1 = New System.Windows.Forms.Label()
			Me.TxtDeviceSerialNumber = New System.Windows.Forms.TextBox()
			Me.label14 = New System.Windows.Forms.Label()
			Me.CboEncryptionType = New System.Windows.Forms.ComboBox()
			Me.groupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' cmdDelete
			' 
			Me.cmdDelete.Location = New System.Drawing.Point(184, 36)
			Me.cmdDelete.Name = "cmdDelete"
			Me.cmdDelete.Size = New System.Drawing.Size(162, 23)
			Me.cmdDelete.TabIndex = 1
			Me.cmdDelete.Text = "Delete this ApplicaitonProfileId"
			Me.cmdDelete.UseVisualStyleBackColor = True
            AddHandler Me.cmdDelete.Click, AddressOf Me.cmdDelete_Click
            ' 
            ' cmdSave
            ' 
            Me.cmdSave.Location = New System.Drawing.Point(302, 526)
            Me.cmdSave.Name = "cmdSave"
            Me.cmdSave.Size = New System.Drawing.Size(75, 23)
            Me.cmdSave.TabIndex = 2
            Me.cmdSave.Text = "Save"
            Me.cmdSave.UseVisualStyleBackColor = True
            AddHandler Me.cmdSave.Click, AddressOf Me.cmdSave_Click
            ' 
            ' cmdClose
            ' 
            Me.cmdClose.Location = New System.Drawing.Point(383, 526)
            Me.cmdClose.Name = "cmdClose"
            Me.cmdClose.Size = New System.Drawing.Size(75, 23)
            Me.cmdClose.TabIndex = 3
            Me.cmdClose.Text = "Close"
            Me.cmdClose.UseVisualStyleBackColor = True
            AddHandler Me.cmdClose.Click, AddressOf Me.cmdClose_Click
            ' 
            ' txtPTLSSocketId
            ' 
            Me.txtPTLSSocketId.Location = New System.Drawing.Point(184, 244)
            Me.txtPTLSSocketId.Multiline = True
            Me.txtPTLSSocketId.Name = "txtPTLSSocketId"
            Me.txtPTLSSocketId.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Me.txtPTLSSocketId.Size = New System.Drawing.Size(259, 51)
            Me.txtPTLSSocketId.TabIndex = 39
            ' 
            ' applicationProfileId
            ' 
            Me.applicationProfileId.AutoSize = True
            Me.applicationProfileId.Location = New System.Drawing.Point(27, 22)
            Me.applicationProfileId.Name = "applicationProfileId"
            Me.applicationProfileId.Size = New System.Drawing.Size(97, 13)
            Me.applicationProfileId.TabIndex = 6
            Me.applicationProfileId.Text = "ApplicationProfileId"
            ' 
            ' txtApplicationProfileId
            ' 
            Me.txtApplicationProfileId.Location = New System.Drawing.Point(27, 38)
            Me.txtApplicationProfileId.Name = "txtApplicationProfileId"
            Me.txtApplicationProfileId.[ReadOnly] = True
            Me.txtApplicationProfileId.Size = New System.Drawing.Size(149, 20)
            Me.txtApplicationProfileId.TabIndex = 7
            ' 
            ' label2
            ' 
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(15, 42)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(154, 13)
            Me.label2.TabIndex = 9
            Me.label2.Text = "ApplicationAttended (Required)"
            ' 
            ' label3
            ' 
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(15, 68)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(152, 13)
            Me.label3.TabIndex = 10
            Me.label3.Text = "ApplicationLocation (Required)"
            ' 
            ' label4
            ' 
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(15, 94)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(139, 13)
            Me.label4.TabIndex = 11
            Me.label4.Text = "ApplicationName (Required)"
            ' 
            ' label5
            ' 
            Me.label5.AutoSize = True
            Me.label5.Location = New System.Drawing.Point(15, 120)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(126, 13)
            Me.label5.TabIndex = 12
            Me.label5.Text = "DeveloperId (Conditional)"
            ' 
            ' label6
            ' 
            Me.label6.AutoSize = True
            Me.label6.Location = New System.Drawing.Point(15, 221)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(122, 13)
            Me.label6.TabIndex = 13
            Me.label6.Text = "PINCapability (Required)"
            ' 
            ' label7
            ' 
            Me.label7.AutoSize = True
            Me.label7.Location = New System.Drawing.Point(15, 195)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(129, 13)
            Me.label7.TabIndex = 14
            Me.label7.Text = "HardwareType (Required)"
            ' 
            ' label8
            ' 
            Me.label8.AutoSize = True
            Me.label8.Location = New System.Drawing.Point(15, 247)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(129, 13)
            Me.label8.TabIndex = 15
            Me.label8.Text = "PTLSSocketId (Required)"
            ' 
            ' label9
            ' 
            Me.label9.AutoSize = True
            Me.label9.Location = New System.Drawing.Point(15, 304)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(130, 13)
            Me.label9.TabIndex = 16
            Me.label9.Text = "ReadCapability (Required)"
            ' 
            ' label10
            ' 
            Me.label10.AutoSize = True
            Me.label10.Location = New System.Drawing.Point(15, 330)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(122, 13)
            Me.label10.TabIndex = 17
            Me.label10.Text = "SerialNumber (Required)"
            ' 
            ' label11
            ' 
            Me.label11.AutoSize = True
            Me.label11.Location = New System.Drawing.Point(15, 356)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(136, 13)
            Me.label11.TabIndex = 18
            Me.label11.Text = "SoftwareVersion (Required)"
            ' 
            ' label12
            ' 
            Me.label12.AutoSize = True
            Me.label12.Location = New System.Drawing.Point(15, 382)
            Me.label12.Name = "label12"
            Me.label12.Size = New System.Drawing.Size(159, 13)
            Me.label12.TabIndex = 19
            Me.label12.Text = "SoftwareVersionDate (Required)"
            ' 
            ' label13
            ' 
            Me.label13.AutoSize = True
            Me.label13.Location = New System.Drawing.Point(15, 408)
            Me.label13.Name = "label13"
            Me.label13.Size = New System.Drawing.Size(111, 13)
            Me.label13.TabIndex = 20
            Me.label13.Text = "VendorId (Conditional)"
            ' 
            ' txtApplicationName
            ' 
            Me.txtApplicationName.Location = New System.Drawing.Point(184, 91)
            Me.txtApplicationName.Name = "txtApplicationName"
            Me.txtApplicationName.Size = New System.Drawing.Size(256, 20)
            Me.txtApplicationName.TabIndex = 35
            ' 
            ' txtDeveloperId
            ' 
            Me.txtDeveloperId.Location = New System.Drawing.Point(184, 117)
            Me.txtDeveloperId.Name = "txtDeveloperId"
            Me.txtDeveloperId.Size = New System.Drawing.Size(256, 20)
            Me.txtDeveloperId.TabIndex = 36
            ' 
            ' txtSerialNumber
            ' 
            Me.txtSerialNumber.Location = New System.Drawing.Point(184, 327)
            Me.txtSerialNumber.Name = "txtSerialNumber"
            Me.txtSerialNumber.Size = New System.Drawing.Size(256, 20)
            Me.txtSerialNumber.TabIndex = 41
            ' 
            ' txtSoftwareVersion
            ' 
            Me.txtSoftwareVersion.Location = New System.Drawing.Point(184, 353)
            Me.txtSoftwareVersion.Name = "txtSoftwareVersion"
            Me.txtSoftwareVersion.Size = New System.Drawing.Size(256, 20)
            Me.txtSoftwareVersion.TabIndex = 42
            ' 
            ' txtSoftwareVersionDate
            ' 
            Me.txtSoftwareVersionDate.Location = New System.Drawing.Point(184, 379)
            Me.txtSoftwareVersionDate.Name = "txtSoftwareVersionDate"
            Me.txtSoftwareVersionDate.Size = New System.Drawing.Size(256, 20)
            Me.txtSoftwareVersionDate.TabIndex = 43
            ' 
            ' txtVendorId
            ' 
            Me.txtVendorId.Location = New System.Drawing.Point(184, 405)
            Me.txtVendorId.Name = "txtVendorId"
            Me.txtVendorId.Size = New System.Drawing.Size(256, 20)
            Me.txtVendorId.TabIndex = 44
            ' 
            ' cboApplicationAttended
            ' 
            Me.cboApplicationAttended.FormattingEnabled = True
            Me.cboApplicationAttended.Location = New System.Drawing.Point(184, 39)
            Me.cboApplicationAttended.Name = "cboApplicationAttended"
            Me.cboApplicationAttended.Size = New System.Drawing.Size(256, 21)
            Me.cboApplicationAttended.TabIndex = 33
            ' 
            ' cboApplicationLocation
            ' 
            Me.cboApplicationLocation.FormattingEnabled = True
            Me.cboApplicationLocation.Location = New System.Drawing.Point(184, 65)
            Me.cboApplicationLocation.Name = "cboApplicationLocation"
            Me.cboApplicationLocation.Size = New System.Drawing.Size(256, 21)
            Me.cboApplicationLocation.TabIndex = 34
            AddHandler Me.cboApplicationLocation.SelectedIndexChanged, AddressOf Me.cboApplicationLocation_SelectedIndexChanged
            ' 
            ' cboHardwareType
            ' 
            Me.cboHardwareType.FormattingEnabled = True
            Me.cboHardwareType.Location = New System.Drawing.Point(184, 192)
            Me.cboHardwareType.Name = "cboHardwareType"
            Me.cboHardwareType.Size = New System.Drawing.Size(256, 21)
            Me.cboHardwareType.TabIndex = 37
            AddHandler Me.cboHardwareType.SelectedIndexChanged, AddressOf Me.cboHardwareType_SelectedIndexChanged
            ' 
            ' cboPINCapability
            ' 
            Me.cboPINCapability.FormattingEnabled = True
            Me.cboPINCapability.Location = New System.Drawing.Point(184, 218)
            Me.cboPINCapability.Name = "cboPINCapability"
            Me.cboPINCapability.Size = New System.Drawing.Size(256, 21)
            Me.cboPINCapability.TabIndex = 38
            AddHandler Me.cboPINCapability.SelectedIndexChanged, AddressOf Me.cboPINCapability_SelectedIndexChanged
            ' 
            ' cboReadCapability
            ' 
            Me.cboReadCapability.FormattingEnabled = True
            Me.cboReadCapability.Location = New System.Drawing.Point(184, 301)
            Me.cboReadCapability.Name = "cboReadCapability"
            Me.cboReadCapability.Size = New System.Drawing.Size(256, 21)
            Me.cboReadCapability.TabIndex = 40
            AddHandler Me.cboReadCapability.SelectedIndexChanged, AddressOf Me.cboReadCapability_SelectedIndexChanged
            ' 
            ' cmdPopulateTestValues
            ' 
            Me.cmdPopulateTestValues.Location = New System.Drawing.Point(299, 10)
            Me.cmdPopulateTestValues.Name = "cmdPopulateTestValues"
            Me.cmdPopulateTestValues.Size = New System.Drawing.Size(147, 23)
            Me.cmdPopulateTestValues.TabIndex = 45
            Me.cmdPopulateTestValues.Text = "Populate With Test Values"
            Me.cmdPopulateTestValues.UseVisualStyleBackColor = True
            AddHandler Me.cmdPopulateTestValues.Click, AddressOf Me.cmdPopulateTestValues_Click
            ' 
            ' groupBox1
            ' 
            Me.groupBox1.Controls.Add(Me.CboEncryptionType)
            Me.groupBox1.Controls.Add(Me.label14)
            Me.groupBox1.Controls.Add(Me.label1)
            Me.groupBox1.Controls.Add(Me.TxtDeviceSerialNumber)
            Me.groupBox1.Controls.Add(Me.label2)
            Me.groupBox1.Controls.Add(Me.cmdPopulateTestValues)
            Me.groupBox1.Controls.Add(Me.cboReadCapability)
            Me.groupBox1.Controls.Add(Me.cboPINCapability)
            Me.groupBox1.Controls.Add(Me.txtPTLSSocketId)
            Me.groupBox1.Controls.Add(Me.cboHardwareType)
            Me.groupBox1.Controls.Add(Me.label3)
            Me.groupBox1.Controls.Add(Me.cboApplicationLocation)
            Me.groupBox1.Controls.Add(Me.label4)
            Me.groupBox1.Controls.Add(Me.cboApplicationAttended)
            Me.groupBox1.Controls.Add(Me.label5)
            Me.groupBox1.Controls.Add(Me.txtVendorId)
            Me.groupBox1.Controls.Add(Me.label6)
            Me.groupBox1.Controls.Add(Me.txtSoftwareVersionDate)
            Me.groupBox1.Controls.Add(Me.label7)
            Me.groupBox1.Controls.Add(Me.txtSoftwareVersion)
            Me.groupBox1.Controls.Add(Me.label8)
            Me.groupBox1.Controls.Add(Me.txtSerialNumber)
            Me.groupBox1.Controls.Add(Me.label9)
            Me.groupBox1.Controls.Add(Me.txtDeveloperId)
            Me.groupBox1.Controls.Add(Me.label10)
            Me.groupBox1.Controls.Add(Me.txtApplicationName)
            Me.groupBox1.Controls.Add(Me.label11)
            Me.groupBox1.Controls.Add(Me.label13)
            Me.groupBox1.Controls.Add(Me.label12)
            Me.groupBox1.Location = New System.Drawing.Point(12, 80)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(446, 440)
            Me.groupBox1.TabIndex = 46
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Application Data"
            ' 
            ' label1
            ' 
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(15, 144)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(165, 13)
            Me.label1.TabIndex = 46
            Me.label1.Text = "DeviceSerialNumber (Conditional)"
            ' 
            ' TxtDeviceSerialNumber
            ' 
            Me.TxtDeviceSerialNumber.AcceptsReturn = True
            Me.TxtDeviceSerialNumber.Location = New System.Drawing.Point(184, 141)
            Me.TxtDeviceSerialNumber.Name = "TxtDeviceSerialNumber"
            Me.TxtDeviceSerialNumber.Size = New System.Drawing.Size(256, 20)
            Me.TxtDeviceSerialNumber.TabIndex = 47
            ' 
            ' label14
            ' 
            Me.label14.AutoSize = True
            Me.label14.Location = New System.Drawing.Point(15, 170)
            Me.label14.Name = "label14"
            Me.label14.Size = New System.Drawing.Size(142, 13)
            Me.label14.TabIndex = 48
            Me.label14.Text = "EncryptionType (Conditional)"
            ' 
            ' CboEncryptionType
            ' 
            Me.CboEncryptionType.FormattingEnabled = True
            Me.CboEncryptionType.Location = New System.Drawing.Point(184, 167)
            Me.CboEncryptionType.Name = "CboEncryptionType"
            Me.CboEncryptionType.Size = New System.Drawing.Size(256, 21)
            Me.CboEncryptionType.TabIndex = 49
            AddHandler Me.CboEncryptionType.SelectedIndexChanged, AddressOf Me.CboEncryptionType_SelectedIndexChanged
            ' 
            ' ManageApplicationData
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(470, 564)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.txtApplicationProfileId)
            Me.Controls.Add(Me.cmdSave)
            Me.Controls.Add(Me.applicationProfileId)
            Me.Controls.Add(Me.cmdClose)
            Me.Controls.Add(Me.cmdDelete)
            Me.Name = "ManageApplicationData"
            Me.Text = "Manage Application Configuration Data - CWS 1.17.17"
            AddHandler Me.Load, AddressOf Me.ManageApplicationData_Load
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

        End Sub

#End Region

		Private cmdDelete As System.Windows.Forms.Button
		Private cmdSave As System.Windows.Forms.Button
		Private cmdClose As System.Windows.Forms.Button
		Private txtPTLSSocketId As System.Windows.Forms.TextBox
		Private applicationProfileId As System.Windows.Forms.Label
		Private txtApplicationProfileId As System.Windows.Forms.TextBox
		Private label2 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private label5 As System.Windows.Forms.Label
		Private label6 As System.Windows.Forms.Label
		Private label7 As System.Windows.Forms.Label
		Private label8 As System.Windows.Forms.Label
		Private label9 As System.Windows.Forms.Label
		Private label10 As System.Windows.Forms.Label
		Private label11 As System.Windows.Forms.Label
		Private label12 As System.Windows.Forms.Label
		Private label13 As System.Windows.Forms.Label
		Private txtApplicationName As System.Windows.Forms.TextBox
		Private txtDeveloperId As System.Windows.Forms.TextBox
		Private txtSerialNumber As System.Windows.Forms.TextBox
		Private txtSoftwareVersion As System.Windows.Forms.TextBox
		Private txtSoftwareVersionDate As System.Windows.Forms.TextBox
		Private txtVendorId As System.Windows.Forms.TextBox
		Private cboApplicationAttended As System.Windows.Forms.ComboBox
		Private cboApplicationLocation As System.Windows.Forms.ComboBox
		Private cboHardwareType As System.Windows.Forms.ComboBox
		Private cboPINCapability As System.Windows.Forms.ComboBox
		Private cboReadCapability As System.Windows.Forms.ComboBox
		Private cmdPopulateTestValues As System.Windows.Forms.Button
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private label14 As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Private TxtDeviceSerialNumber As System.Windows.Forms.TextBox
		Private CboEncryptionType As System.Windows.Forms.ComboBox
	End Class
End Namespace