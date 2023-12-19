<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmployeeInformation
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
        Me.BtnRemove = New System.Windows.Forms.Button
        Me.DtpDateofJoin = New System.Windows.Forms.DateTimePicker
        Me.DtpDateofDeparture = New System.Windows.Forms.DateTimePicker
        Me.GrpEmployeeInformation = New System.Windows.Forms.GroupBox
        Me.TxtRFID = New System.Windows.Forms.TextBox
        Me.LblRFID = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtEmployeeNIDNo = New System.Windows.Forms.TextBox
        Me.LblEmployeeNIDNo = New System.Windows.Forms.Label
        Me.TxtDepartment = New System.Windows.Forms.TextBox
        Me.CmbEmployeeStatus = New System.Windows.Forms.ComboBox
        Me.lblEmployeeStatus = New System.Windows.Forms.Label
        Me.TxtSmsNotificationNo = New System.Windows.Forms.TextBox
        Me.LblSmsNotificationNo = New System.Windows.Forms.Label
        Me.LblDateOfDeparture = New System.Windows.Forms.Label
        Me.PtbEmployeeInformation = New System.Windows.Forms.PictureBox
        Me.LblEmployeeCategory = New System.Windows.Forms.Label
        Me.BtnChoose = New System.Windows.Forms.Button
        Me.TxtMobileNumber = New System.Windows.Forms.TextBox
        Me.LblMobileNumber = New System.Windows.Forms.Label
        Me.TxtRemarks = New System.Windows.Forms.TextBox
        Me.LblRemarks = New System.Windows.Forms.Label
        Me.DtpDateofBirth = New System.Windows.Forms.DateTimePicker
        Me.LblDateofBirth = New System.Windows.Forms.Label
        Me.CmbReligion = New System.Windows.Forms.ComboBox
        Me.CmbNationality = New System.Windows.Forms.ComboBox
        Me.CmbBloodGroup = New System.Windows.Forms.ComboBox
        Me.LblReligion = New System.Windows.Forms.Label
        Me.LblNationality = New System.Windows.Forms.Label
        Me.LblBloodGroup = New System.Windows.Forms.Label
        Me.CmbGender = New System.Windows.Forms.ComboBox
        Me.LblDateOfJoin = New System.Windows.Forms.Label
        Me.LblDepartment = New System.Windows.Forms.Label
        Me.LblGender = New System.Windows.Forms.Label
        Me.TxtBasicSalary = New System.Windows.Forms.TextBox
        Me.TxtPreviousOrganization = New System.Windows.Forms.TextBox
        Me.TxtPresentAddress = New System.Windows.Forms.TextBox
        Me.TxtPermanentAddress = New System.Windows.Forms.TextBox
        Me.TxtEmailAddress = New System.Windows.Forms.TextBox
        Me.TxtEmployeeName = New System.Windows.Forms.TextBox
        Me.TxtEmployeeID = New System.Windows.Forms.TextBox
        Me.LblPreviousOrganization = New System.Windows.Forms.Label
        Me.LblEmailAddress = New System.Windows.Forms.Label
        Me.LblBasicSalary = New System.Windows.Forms.Label
        Me.LblPermanentAddress = New System.Windows.Forms.Label
        Me.LblPresentAddress = New System.Windows.Forms.Label
        Me.LblEmployeeName = New System.Windows.Forms.Label
        Me.LblEmployeeID = New System.Windows.Forms.Label
        Me.TxtSearch = New System.Windows.Forms.TextBox
        Me.LblEmployeeInformation = New System.Windows.Forms.Label
        Me.PnlEmployeeInformation = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.CmbSearch = New System.Windows.Forms.ComboBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Label15 = New System.Windows.Forms.Label
        Me.lblTotalEmployee = New System.Windows.Forms.Label
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.BtnRefrersh = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.BtnAddNew = New System.Windows.Forms.Button
        Me.GrdEmployeeInformation = New System.Windows.Forms.DataGridView
        Me.CmbEmployeeCategoryID = New System.Windows.Forms.ComboBox
        Me.GrpEmployeeInformation.SuspendLayout()
        CType(Me.PtbEmployeeInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlEmployeeInformation.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GrdEmployeeInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnRemove
        '
        Me.BtnRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRemove.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRemove.Location = New System.Drawing.Point(940, 179)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(68, 25)
        Me.BtnRemove.TabIndex = 1130
        Me.BtnRemove.Text = "Remove"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'DtpDateofJoin
        '
        Me.DtpDateofJoin.Cursor = System.Windows.Forms.Cursors.Default
        Me.DtpDateofJoin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDateofJoin.Location = New System.Drawing.Point(360, 18)
        Me.DtpDateofJoin.Name = "DtpDateofJoin"
        Me.DtpDateofJoin.Size = New System.Drawing.Size(100, 20)
        Me.DtpDateofJoin.TabIndex = 110
        '
        'DtpDateofDeparture
        '
        Me.DtpDateofDeparture.Cursor = System.Windows.Forms.Cursors.Default
        Me.DtpDateofDeparture.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDateofDeparture.Location = New System.Drawing.Point(360, 46)
        Me.DtpDateofDeparture.Name = "DtpDateofDeparture"
        Me.DtpDateofDeparture.Size = New System.Drawing.Size(100, 20)
        Me.DtpDateofDeparture.TabIndex = 111
        '
        'GrpEmployeeInformation
        '
        Me.GrpEmployeeInformation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpEmployeeInformation.Controls.Add(Me.CmbEmployeeCategoryID)
        Me.GrpEmployeeInformation.Controls.Add(Me.TxtRFID)
        Me.GrpEmployeeInformation.Controls.Add(Me.LblRFID)
        Me.GrpEmployeeInformation.Controls.Add(Me.Label9)
        Me.GrpEmployeeInformation.Controls.Add(Me.Label2)
        Me.GrpEmployeeInformation.Controls.Add(Me.Label3)
        Me.GrpEmployeeInformation.Controls.Add(Me.Label5)
        Me.GrpEmployeeInformation.Controls.Add(Me.TxtEmployeeNIDNo)
        Me.GrpEmployeeInformation.Controls.Add(Me.LblEmployeeNIDNo)
        Me.GrpEmployeeInformation.Controls.Add(Me.TxtDepartment)
        Me.GrpEmployeeInformation.Controls.Add(Me.CmbEmployeeStatus)
        Me.GrpEmployeeInformation.Controls.Add(Me.lblEmployeeStatus)
        Me.GrpEmployeeInformation.Controls.Add(Me.TxtSmsNotificationNo)
        Me.GrpEmployeeInformation.Controls.Add(Me.LblSmsNotificationNo)
        Me.GrpEmployeeInformation.Controls.Add(Me.BtnRemove)
        Me.GrpEmployeeInformation.Controls.Add(Me.DtpDateofJoin)
        Me.GrpEmployeeInformation.Controls.Add(Me.DtpDateofDeparture)
        Me.GrpEmployeeInformation.Controls.Add(Me.LblDateOfDeparture)
        Me.GrpEmployeeInformation.Controls.Add(Me.PtbEmployeeInformation)
        Me.GrpEmployeeInformation.Controls.Add(Me.LblEmployeeCategory)
        Me.GrpEmployeeInformation.Controls.Add(Me.BtnChoose)
        Me.GrpEmployeeInformation.Controls.Add(Me.TxtMobileNumber)
        Me.GrpEmployeeInformation.Controls.Add(Me.LblMobileNumber)
        Me.GrpEmployeeInformation.Controls.Add(Me.TxtRemarks)
        Me.GrpEmployeeInformation.Controls.Add(Me.LblRemarks)
        Me.GrpEmployeeInformation.Controls.Add(Me.DtpDateofBirth)
        Me.GrpEmployeeInformation.Controls.Add(Me.LblDateofBirth)
        Me.GrpEmployeeInformation.Controls.Add(Me.CmbReligion)
        Me.GrpEmployeeInformation.Controls.Add(Me.CmbNationality)
        Me.GrpEmployeeInformation.Controls.Add(Me.CmbBloodGroup)
        Me.GrpEmployeeInformation.Controls.Add(Me.LblReligion)
        Me.GrpEmployeeInformation.Controls.Add(Me.LblNationality)
        Me.GrpEmployeeInformation.Controls.Add(Me.LblBloodGroup)
        Me.GrpEmployeeInformation.Controls.Add(Me.CmbGender)
        Me.GrpEmployeeInformation.Controls.Add(Me.LblDateOfJoin)
        Me.GrpEmployeeInformation.Controls.Add(Me.LblDepartment)
        Me.GrpEmployeeInformation.Controls.Add(Me.LblGender)
        Me.GrpEmployeeInformation.Controls.Add(Me.TxtBasicSalary)
        Me.GrpEmployeeInformation.Controls.Add(Me.TxtPreviousOrganization)
        Me.GrpEmployeeInformation.Controls.Add(Me.TxtPresentAddress)
        Me.GrpEmployeeInformation.Controls.Add(Me.TxtPermanentAddress)
        Me.GrpEmployeeInformation.Controls.Add(Me.TxtEmailAddress)
        Me.GrpEmployeeInformation.Controls.Add(Me.TxtEmployeeName)
        Me.GrpEmployeeInformation.Controls.Add(Me.TxtEmployeeID)
        Me.GrpEmployeeInformation.Controls.Add(Me.LblPreviousOrganization)
        Me.GrpEmployeeInformation.Controls.Add(Me.LblEmailAddress)
        Me.GrpEmployeeInformation.Controls.Add(Me.LblBasicSalary)
        Me.GrpEmployeeInformation.Controls.Add(Me.LblPermanentAddress)
        Me.GrpEmployeeInformation.Controls.Add(Me.LblPresentAddress)
        Me.GrpEmployeeInformation.Controls.Add(Me.LblEmployeeName)
        Me.GrpEmployeeInformation.Controls.Add(Me.LblEmployeeID)
        Me.GrpEmployeeInformation.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrpEmployeeInformation.Location = New System.Drawing.Point(6, 151)
        Me.GrpEmployeeInformation.Name = "GrpEmployeeInformation"
        Me.GrpEmployeeInformation.Size = New System.Drawing.Size(1014, 267)
        Me.GrpEmployeeInformation.TabIndex = 1120
        Me.GrpEmployeeInformation.TabStop = False
        Me.GrpEmployeeInformation.Text = "Employee Information"
        '
        'TxtRFID
        '
        Me.TxtRFID.Cursor = System.Windows.Forms.Cursors.Default
        Me.TxtRFID.Location = New System.Drawing.Point(639, 199)
        Me.TxtRFID.Name = "TxtRFID"
        Me.TxtRFID.Size = New System.Drawing.Size(189, 20)
        Me.TxtRFID.TabIndex = 123
        '
        'LblRFID
        '
        Me.LblRFID.AutoSize = True
        Me.LblRFID.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblRFID.Location = New System.Drawing.Point(513, 200)
        Me.LblRFID.Name = "LblRFID"
        Me.LblRFID.Size = New System.Drawing.Size(38, 13)
        Me.LblRFID.TabIndex = 2039
        Me.LblRFID.Text = "RF ID:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label9.Location = New System.Drawing.Point(617, 174)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(17, 24)
        Me.Label9.TabIndex = 2026
        Me.Label9.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(60, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 24)
        Me.Label2.TabIndex = 2027
        Me.Label2.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(337, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 24)
        Me.Label3.TabIndex = 2028
        Me.Label3.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Location = New System.Drawing.Point(100, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 24)
        Me.Label5.TabIndex = 2030
        Me.Label5.Text = "*"
        '
        'TxtEmployeeNIDNo
        '
        Me.TxtEmployeeNIDNo.Cursor = System.Windows.Forms.Cursors.Default
        Me.TxtEmployeeNIDNo.Location = New System.Drawing.Point(360, 159)
        Me.TxtEmployeeNIDNo.Name = "TxtEmployeeNIDNo"
        Me.TxtEmployeeNIDNo.Size = New System.Drawing.Size(138, 20)
        Me.TxtEmployeeNIDNo.TabIndex = 116
        '
        'LblEmployeeNIDNo
        '
        Me.LblEmployeeNIDNo.AutoSize = True
        Me.LblEmployeeNIDNo.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblEmployeeNIDNo.Location = New System.Drawing.Point(263, 162)
        Me.LblEmployeeNIDNo.Name = "LblEmployeeNIDNo"
        Me.LblEmployeeNIDNo.Size = New System.Drawing.Size(95, 13)
        Me.LblEmployeeNIDNo.TabIndex = 2037
        Me.LblEmployeeNIDNo.Text = "Employee NID No:"
        '
        'TxtDepartment
        '
        Me.TxtDepartment.Cursor = System.Windows.Forms.Cursors.Default
        Me.TxtDepartment.Location = New System.Drawing.Point(121, 99)
        Me.TxtDepartment.Name = "TxtDepartment"
        Me.TxtDepartment.Size = New System.Drawing.Size(100, 20)
        Me.TxtDepartment.TabIndex = 104
        '
        'CmbEmployeeStatus
        '
        Me.CmbEmployeeStatus.AutoCompleteCustomSource.AddRange(New String() {"Residential", "Non Residential"})
        Me.CmbEmployeeStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbEmployeeStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.CmbEmployeeStatus.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbEmployeeStatus.FormattingEnabled = True
        Me.CmbEmployeeStatus.Items.AddRange(New Object() {"CURRENT", "ALUMNI"})
        Me.CmbEmployeeStatus.Location = New System.Drawing.Point(360, 130)
        Me.CmbEmployeeStatus.Name = "CmbEmployeeStatus"
        Me.CmbEmployeeStatus.Size = New System.Drawing.Size(100, 21)
        Me.CmbEmployeeStatus.TabIndex = 115
        '
        'lblEmployeeStatus
        '
        Me.lblEmployeeStatus.AutoSize = True
        Me.lblEmployeeStatus.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblEmployeeStatus.Location = New System.Drawing.Point(265, 133)
        Me.lblEmployeeStatus.Name = "lblEmployeeStatus"
        Me.lblEmployeeStatus.Size = New System.Drawing.Size(89, 13)
        Me.lblEmployeeStatus.TabIndex = 2033
        Me.lblEmployeeStatus.Text = "Employee Status:"
        '
        'TxtSmsNotificationNo
        '
        Me.TxtSmsNotificationNo.Cursor = System.Windows.Forms.Cursors.Default
        Me.TxtSmsNotificationNo.Location = New System.Drawing.Point(639, 173)
        Me.TxtSmsNotificationNo.Name = "TxtSmsNotificationNo"
        Me.TxtSmsNotificationNo.Size = New System.Drawing.Size(189, 20)
        Me.TxtSmsNotificationNo.TabIndex = 122
        '
        'LblSmsNotificationNo
        '
        Me.LblSmsNotificationNo.AutoSize = True
        Me.LblSmsNotificationNo.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblSmsNotificationNo.Location = New System.Drawing.Point(513, 175)
        Me.LblSmsNotificationNo.Name = "LblSmsNotificationNo"
        Me.LblSmsNotificationNo.Size = New System.Drawing.Size(106, 13)
        Me.LblSmsNotificationNo.TabIndex = 1133
        Me.LblSmsNotificationNo.Text = "SMS Notification No:"
        '
        'LblDateOfDeparture
        '
        Me.LblDateOfDeparture.AutoSize = True
        Me.LblDateOfDeparture.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblDateOfDeparture.Location = New System.Drawing.Point(263, 49)
        Me.LblDateOfDeparture.Name = "LblDateOfDeparture"
        Me.LblDateOfDeparture.Size = New System.Drawing.Size(95, 13)
        Me.LblDateOfDeparture.TabIndex = 1069
        Me.LblDateOfDeparture.Text = "Date of Departure:"
        '
        'PtbEmployeeInformation
        '
        Me.PtbEmployeeInformation.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PtbEmployeeInformation.BackgroundImage = Global.Business_Expert_Pro.My.Resources.Resources.worker
        Me.PtbEmployeeInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PtbEmployeeInformation.Cursor = System.Windows.Forms.Cursors.Default
        Me.PtbEmployeeInformation.ErrorImage = Nothing
        Me.PtbEmployeeInformation.InitialImage = Nothing
        Me.PtbEmployeeInformation.Location = New System.Drawing.Point(866, 23)
        Me.PtbEmployeeInformation.Name = "PtbEmployeeInformation"
        Me.PtbEmployeeInformation.Size = New System.Drawing.Size(133, 139)
        Me.PtbEmployeeInformation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PtbEmployeeInformation.TabIndex = 1119
        Me.PtbEmployeeInformation.TabStop = False
        '
        'LblEmployeeCategory
        '
        Me.LblEmployeeCategory.AutoSize = True
        Me.LblEmployeeCategory.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblEmployeeCategory.Location = New System.Drawing.Point(16, 127)
        Me.LblEmployeeCategory.Name = "LblEmployeeCategory"
        Me.LblEmployeeCategory.Size = New System.Drawing.Size(101, 13)
        Me.LblEmployeeCategory.TabIndex = 1066
        Me.LblEmployeeCategory.Text = "Employee Category:"
        '
        'BtnChoose
        '
        Me.BtnChoose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnChoose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnChoose.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnChoose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnChoose.Location = New System.Drawing.Point(866, 179)
        Me.BtnChoose.Name = "BtnChoose"
        Me.BtnChoose.Size = New System.Drawing.Size(68, 25)
        Me.BtnChoose.TabIndex = 1131
        Me.BtnChoose.Text = "Choose.."
        Me.BtnChoose.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnChoose.UseVisualStyleBackColor = True
        '
        'TxtMobileNumber
        '
        Me.TxtMobileNumber.Cursor = System.Windows.Forms.Cursors.Default
        Me.TxtMobileNumber.Location = New System.Drawing.Point(639, 147)
        Me.TxtMobileNumber.Name = "TxtMobileNumber"
        Me.TxtMobileNumber.Size = New System.Drawing.Size(189, 20)
        Me.TxtMobileNumber.TabIndex = 121
        '
        'LblMobileNumber
        '
        Me.LblMobileNumber.AutoSize = True
        Me.LblMobileNumber.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblMobileNumber.Location = New System.Drawing.Point(513, 147)
        Me.LblMobileNumber.Name = "LblMobileNumber"
        Me.LblMobileNumber.Size = New System.Drawing.Size(81, 13)
        Me.LblMobileNumber.TabIndex = 1062
        Me.LblMobileNumber.Text = "Mobile Number:"
        '
        'TxtRemarks
        '
        Me.TxtRemarks.Cursor = System.Windows.Forms.Cursors.Default
        Me.TxtRemarks.Location = New System.Drawing.Point(639, 104)
        Me.TxtRemarks.Multiline = True
        Me.TxtRemarks.Name = "TxtRemarks"
        Me.TxtRemarks.Size = New System.Drawing.Size(189, 37)
        Me.TxtRemarks.TabIndex = 120
        '
        'LblRemarks
        '
        Me.LblRemarks.AutoSize = True
        Me.LblRemarks.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblRemarks.Location = New System.Drawing.Point(513, 104)
        Me.LblRemarks.Name = "LblRemarks"
        Me.LblRemarks.Size = New System.Drawing.Size(52, 13)
        Me.LblRemarks.TabIndex = 1058
        Me.LblRemarks.Text = "Remarks:"
        '
        'DtpDateofBirth
        '
        Me.DtpDateofBirth.Cursor = System.Windows.Forms.Cursors.Default
        Me.DtpDateofBirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDateofBirth.Location = New System.Drawing.Point(121, 233)
        Me.DtpDateofBirth.Name = "DtpDateofBirth"
        Me.DtpDateofBirth.Size = New System.Drawing.Size(100, 20)
        Me.DtpDateofBirth.TabIndex = 109
        '
        'LblDateofBirth
        '
        Me.LblDateofBirth.AutoSize = True
        Me.LblDateofBirth.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblDateofBirth.Location = New System.Drawing.Point(16, 236)
        Me.LblDateofBirth.Name = "LblDateofBirth"
        Me.LblDateofBirth.Size = New System.Drawing.Size(69, 13)
        Me.LblDateofBirth.TabIndex = 78
        Me.LblDateofBirth.Text = "Date of Birth:"
        '
        'CmbReligion
        '
        Me.CmbReligion.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbReligion.FormattingEnabled = True
        Me.CmbReligion.Items.AddRange(New Object() {"ISLAM", "HINDU", "CHRISTIAN", "OTHER"})
        Me.CmbReligion.Location = New System.Drawing.Point(121, 179)
        Me.CmbReligion.Name = "CmbReligion"
        Me.CmbReligion.Size = New System.Drawing.Size(100, 21)
        Me.CmbReligion.TabIndex = 107
        '
        'CmbNationality
        '
        Me.CmbNationality.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbNationality.FormattingEnabled = True
        Me.CmbNationality.Items.AddRange(New Object() {"BANGLADESHI", "OTHERS"})
        Me.CmbNationality.Location = New System.Drawing.Point(121, 206)
        Me.CmbNationality.Name = "CmbNationality"
        Me.CmbNationality.Size = New System.Drawing.Size(100, 21)
        Me.CmbNationality.TabIndex = 108
        '
        'CmbBloodGroup
        '
        Me.CmbBloodGroup.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbBloodGroup.FormattingEnabled = True
        Me.CmbBloodGroup.Items.AddRange(New Object() {"NONE", "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-"})
        Me.CmbBloodGroup.Location = New System.Drawing.Point(121, 152)
        Me.CmbBloodGroup.Name = "CmbBloodGroup"
        Me.CmbBloodGroup.Size = New System.Drawing.Size(100, 21)
        Me.CmbBloodGroup.TabIndex = 106
        '
        'LblReligion
        '
        Me.LblReligion.AutoSize = True
        Me.LblReligion.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblReligion.Location = New System.Drawing.Point(16, 179)
        Me.LblReligion.Name = "LblReligion"
        Me.LblReligion.Size = New System.Drawing.Size(48, 13)
        Me.LblReligion.TabIndex = 70
        Me.LblReligion.Text = "Religion:"
        '
        'LblNationality
        '
        Me.LblNationality.AutoSize = True
        Me.LblNationality.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblNationality.Location = New System.Drawing.Point(16, 205)
        Me.LblNationality.Name = "LblNationality"
        Me.LblNationality.Size = New System.Drawing.Size(59, 13)
        Me.LblNationality.TabIndex = 69
        Me.LblNationality.Text = "Nationality:"
        '
        'LblBloodGroup
        '
        Me.LblBloodGroup.AutoSize = True
        Me.LblBloodGroup.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblBloodGroup.Location = New System.Drawing.Point(16, 153)
        Me.LblBloodGroup.Name = "LblBloodGroup"
        Me.LblBloodGroup.Size = New System.Drawing.Size(69, 13)
        Me.LblBloodGroup.TabIndex = 68
        Me.LblBloodGroup.Text = "Blood Group:"
        '
        'CmbGender
        '
        Me.CmbGender.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbGender.FormattingEnabled = True
        Me.CmbGender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.CmbGender.Location = New System.Drawing.Point(121, 72)
        Me.CmbGender.Name = "CmbGender"
        Me.CmbGender.Size = New System.Drawing.Size(100, 21)
        Me.CmbGender.TabIndex = 103
        '
        'LblDateOfJoin
        '
        Me.LblDateOfJoin.AutoSize = True
        Me.LblDateOfJoin.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblDateOfJoin.Location = New System.Drawing.Point(263, 21)
        Me.LblDateOfJoin.Name = "LblDateOfJoin"
        Me.LblDateOfJoin.Size = New System.Drawing.Size(67, 13)
        Me.LblDateOfJoin.TabIndex = 62
        Me.LblDateOfJoin.Text = "Date of Join:"
        '
        'LblDepartment
        '
        Me.LblDepartment.AutoSize = True
        Me.LblDepartment.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblDepartment.Location = New System.Drawing.Point(16, 101)
        Me.LblDepartment.Name = "LblDepartment"
        Me.LblDepartment.Size = New System.Drawing.Size(65, 13)
        Me.LblDepartment.TabIndex = 61
        Me.LblDepartment.Text = "Department:"
        '
        'LblGender
        '
        Me.LblGender.AutoSize = True
        Me.LblGender.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblGender.Location = New System.Drawing.Point(16, 75)
        Me.LblGender.Name = "LblGender"
        Me.LblGender.Size = New System.Drawing.Size(45, 13)
        Me.LblGender.TabIndex = 58
        Me.LblGender.Text = "Gender:"
        '
        'TxtBasicSalary
        '
        Me.TxtBasicSalary.Cursor = System.Windows.Forms.Cursors.Default
        Me.TxtBasicSalary.Location = New System.Drawing.Point(360, 102)
        Me.TxtBasicSalary.Name = "TxtBasicSalary"
        Me.TxtBasicSalary.Size = New System.Drawing.Size(100, 20)
        Me.TxtBasicSalary.TabIndex = 114
        '
        'TxtPreviousOrganization
        '
        Me.TxtPreviousOrganization.Cursor = System.Windows.Forms.Cursors.Default
        Me.TxtPreviousOrganization.Location = New System.Drawing.Point(639, 78)
        Me.TxtPreviousOrganization.Name = "TxtPreviousOrganization"
        Me.TxtPreviousOrganization.Size = New System.Drawing.Size(189, 20)
        Me.TxtPreviousOrganization.TabIndex = 119
        '
        'TxtPresentAddress
        '
        Me.TxtPresentAddress.Cursor = System.Windows.Forms.Cursors.Default
        Me.TxtPresentAddress.Location = New System.Drawing.Point(360, 187)
        Me.TxtPresentAddress.Multiline = True
        Me.TxtPresentAddress.Name = "TxtPresentAddress"
        Me.TxtPresentAddress.Size = New System.Drawing.Size(138, 58)
        Me.TxtPresentAddress.TabIndex = 117
        '
        'TxtPermanentAddress
        '
        Me.TxtPermanentAddress.Cursor = System.Windows.Forms.Cursors.Default
        Me.TxtPermanentAddress.Location = New System.Drawing.Point(639, 18)
        Me.TxtPermanentAddress.Multiline = True
        Me.TxtPermanentAddress.Name = "TxtPermanentAddress"
        Me.TxtPermanentAddress.Size = New System.Drawing.Size(189, 54)
        Me.TxtPermanentAddress.TabIndex = 118
        '
        'TxtEmailAddress
        '
        Me.TxtEmailAddress.Cursor = System.Windows.Forms.Cursors.Default
        Me.TxtEmailAddress.Location = New System.Drawing.Point(360, 74)
        Me.TxtEmailAddress.Name = "TxtEmailAddress"
        Me.TxtEmailAddress.Size = New System.Drawing.Size(100, 20)
        Me.TxtEmailAddress.TabIndex = 112
        '
        'TxtEmployeeName
        '
        Me.TxtEmployeeName.Cursor = System.Windows.Forms.Cursors.Default
        Me.TxtEmployeeName.Location = New System.Drawing.Point(121, 46)
        Me.TxtEmployeeName.Name = "TxtEmployeeName"
        Me.TxtEmployeeName.Size = New System.Drawing.Size(134, 20)
        Me.TxtEmployeeName.TabIndex = 102
        '
        'TxtEmployeeID
        '
        Me.TxtEmployeeID.Cursor = System.Windows.Forms.Cursors.Default
        Me.TxtEmployeeID.Enabled = False
        Me.TxtEmployeeID.Location = New System.Drawing.Point(121, 20)
        Me.TxtEmployeeID.Name = "TxtEmployeeID"
        Me.TxtEmployeeID.Size = New System.Drawing.Size(74, 20)
        Me.TxtEmployeeID.TabIndex = 101
        '
        'LblPreviousOrganization
        '
        Me.LblPreviousOrganization.AutoSize = True
        Me.LblPreviousOrganization.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblPreviousOrganization.Location = New System.Drawing.Point(513, 79)
        Me.LblPreviousOrganization.Name = "LblPreviousOrganization"
        Me.LblPreviousOrganization.Size = New System.Drawing.Size(113, 13)
        Me.LblPreviousOrganization.TabIndex = 21
        Me.LblPreviousOrganization.Text = "Previous Organization:"
        '
        'LblEmailAddress
        '
        Me.LblEmailAddress.AutoSize = True
        Me.LblEmailAddress.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblEmailAddress.Location = New System.Drawing.Point(263, 78)
        Me.LblEmailAddress.Name = "LblEmailAddress"
        Me.LblEmailAddress.Size = New System.Drawing.Size(79, 13)
        Me.LblEmailAddress.TabIndex = 12
        Me.LblEmailAddress.Text = "E-mail Address:"
        '
        'LblBasicSalary
        '
        Me.LblBasicSalary.AutoSize = True
        Me.LblBasicSalary.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblBasicSalary.Location = New System.Drawing.Point(263, 103)
        Me.LblBasicSalary.Name = "LblBasicSalary"
        Me.LblBasicSalary.Size = New System.Drawing.Size(68, 13)
        Me.LblBasicSalary.TabIndex = 11
        Me.LblBasicSalary.Text = "Basic Salary:"
        '
        'LblPermanentAddress
        '
        Me.LblPermanentAddress.AutoSize = True
        Me.LblPermanentAddress.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblPermanentAddress.Location = New System.Drawing.Point(513, 16)
        Me.LblPermanentAddress.Name = "LblPermanentAddress"
        Me.LblPermanentAddress.Size = New System.Drawing.Size(102, 13)
        Me.LblPermanentAddress.TabIndex = 9
        Me.LblPermanentAddress.Text = "Permanent Address:"
        '
        'LblPresentAddress
        '
        Me.LblPresentAddress.AutoSize = True
        Me.LblPresentAddress.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblPresentAddress.Location = New System.Drawing.Point(263, 191)
        Me.LblPresentAddress.Name = "LblPresentAddress"
        Me.LblPresentAddress.Size = New System.Drawing.Size(87, 13)
        Me.LblPresentAddress.TabIndex = 8
        Me.LblPresentAddress.Text = "Present Address:"
        '
        'LblEmployeeName
        '
        Me.LblEmployeeName.AutoSize = True
        Me.LblEmployeeName.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblEmployeeName.Location = New System.Drawing.Point(16, 49)
        Me.LblEmployeeName.Name = "LblEmployeeName"
        Me.LblEmployeeName.Size = New System.Drawing.Size(87, 13)
        Me.LblEmployeeName.TabIndex = 2
        Me.LblEmployeeName.Text = "Employee Name:"
        '
        'LblEmployeeID
        '
        Me.LblEmployeeID.AutoSize = True
        Me.LblEmployeeID.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblEmployeeID.Location = New System.Drawing.Point(16, 23)
        Me.LblEmployeeID.Name = "LblEmployeeID"
        Me.LblEmployeeID.Size = New System.Drawing.Size(70, 13)
        Me.LblEmployeeID.TabIndex = 1
        Me.LblEmployeeID.Text = "Employee ID:"
        '
        'TxtSearch
        '
        Me.TxtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSearch.Cursor = System.Windows.Forms.Cursors.Default
        Me.TxtSearch.Location = New System.Drawing.Point(869, 99)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(109, 20)
        Me.TxtSearch.TabIndex = 1123
        '
        'LblEmployeeInformation
        '
        Me.LblEmployeeInformation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblEmployeeInformation.AutoSize = True
        Me.LblEmployeeInformation.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblEmployeeInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmployeeInformation.ForeColor = System.Drawing.Color.White
        Me.LblEmployeeInformation.Location = New System.Drawing.Point(346, 45)
        Me.LblEmployeeInformation.Name = "LblEmployeeInformation"
        Me.LblEmployeeInformation.Size = New System.Drawing.Size(347, 37)
        Me.LblEmployeeInformation.TabIndex = 0
        Me.LblEmployeeInformation.Text = "Employee Information"
        '
        'PnlEmployeeInformation
        '
        Me.PnlEmployeeInformation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlEmployeeInformation.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlEmployeeInformation.Controls.Add(Me.Panel1)
        Me.PnlEmployeeInformation.Controls.Add(Me.LblEmployeeInformation)
        Me.PnlEmployeeInformation.Cursor = System.Windows.Forms.Cursors.Default
        Me.PnlEmployeeInformation.Location = New System.Drawing.Point(-7, -7)
        Me.PnlEmployeeInformation.Name = "PnlEmployeeInformation"
        Me.PnlEmployeeInformation.Size = New System.Drawing.Size(1038, 95)
        Me.PnlEmployeeInformation.TabIndex = 1121
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Btnclose)
        Me.Panel1.Controls.Add(Me.Btnminimized)
        Me.Panel1.Controls.Add(Me.Btnmaximized)
        Me.Panel1.Location = New System.Drawing.Point(6, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1027, 29)
        Me.Panel1.TabIndex = 5
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(1000, 0)
        Me.Btnclose.Name = "Btnclose"
        Me.Btnclose.Size = New System.Drawing.Size(24, 24)
        Me.Btnclose.TabIndex = 1159
        Me.Btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnclose.UseVisualStyleBackColor = False
        '
        'Btnminimized
        '
        Me.Btnminimized.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnminimized.BackColor = System.Drawing.SystemColors.Control
        Me.Btnminimized.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnminimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnminimized.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Minimize_Window_32px_2
        Me.Btnminimized.Location = New System.Drawing.Point(949, 0)
        Me.Btnminimized.Name = "Btnminimized"
        Me.Btnminimized.Size = New System.Drawing.Size(24, 24)
        Me.Btnminimized.TabIndex = 1158
        Me.Btnminimized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnminimized.UseVisualStyleBackColor = False
        '
        'Btnmaximized
        '
        Me.Btnmaximized.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnmaximized.BackColor = System.Drawing.SystemColors.Control
        Me.Btnmaximized.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnmaximized.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnmaximized.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Maximize_Window_32px_2
        Me.Btnmaximized.Location = New System.Drawing.Point(974, 0)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1157
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'CmbSearch
        '
        Me.CmbSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbSearch.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbSearch.FormattingEnabled = True
        Me.CmbSearch.Items.AddRange(New Object() {"Employee ID", "Employee Name"})
        Me.CmbSearch.Location = New System.Drawing.Point(739, 99)
        Me.CmbSearch.Name = "CmbSearch"
        Me.CmbSearch.Size = New System.Drawing.Size(124, 21)
        Me.CmbSearch.TabIndex = 1122
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(948, 136)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(21, 13)
        Me.Label15.TabIndex = 1155
        Me.Label15.Text = "00"
        '
        'lblTotalEmployee
        '
        Me.lblTotalEmployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalEmployee.AutoSize = True
        Me.lblTotalEmployee.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTotalEmployee.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalEmployee.Location = New System.Drawing.Point(837, 136)
        Me.lblTotalEmployee.Name = "lblTotalEmployee"
        Me.lblTotalEmployee.Size = New System.Drawing.Size(111, 15)
        Me.lblTotalEmployee.TabIndex = 1154
        Me.lblTotalEmployee.Text = "Total Employee:"
        '
        'BtnSearch
        '
        Me.BtnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Image = Global.Business_Expert_Pro.My.Resources.Resources.Button_15_1281
        Me.BtnSearch.Location = New System.Drawing.Point(996, 99)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(19, 19)
        Me.BtnSearch.TabIndex = 1132
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'BtnRefrersh
        '
        Me.BtnRefrersh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRefrersh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefrersh.Image = Global.Business_Expert_Pro.My.Resources.Resources.Reboot_32px1
        Me.BtnRefrersh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRefrersh.Location = New System.Drawing.Point(303, 101)
        Me.BtnRefrersh.Name = "BtnRefrersh"
        Me.BtnRefrersh.Size = New System.Drawing.Size(89, 36)
        Me.BtnRefrersh.TabIndex = 1128
        Me.BtnRefrersh.Text = "Refresh"
        Me.BtnRefrersh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRefrersh.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Image = Global.Business_Expert_Pro.My.Resources.Resources.Save_32px_32
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(431, 101)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(89, 36)
        Me.BtnSave.TabIndex = 1125
        Me.BtnSave.Text = "Save"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Image = Global.Business_Expert_Pro.My.Resources.Resources.Delete_32px3
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(191, 101)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(89, 36)
        Me.BtnDelete.TabIndex = 1127
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Image = Global.Business_Expert_Pro.My.Resources.Resources.Edit_File_32px3
        Me.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUpdate.Location = New System.Drawing.Point(98, 101)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(89, 36)
        Me.BtnUpdate.TabIndex = 1126
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnAddNew
        '
        Me.BtnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddNew.Image = Global.Business_Expert_Pro.My.Resources.Resources.Add_New5
        Me.BtnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddNew.Location = New System.Drawing.Point(5, 101)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(89, 36)
        Me.BtnAddNew.TabIndex = 1129
        Me.BtnAddNew.Text = "Add New"
        Me.BtnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'GrdEmployeeInformation
        '
        Me.GrdEmployeeInformation.AllowUserToAddRows = False
        Me.GrdEmployeeInformation.AllowUserToDeleteRows = False
        Me.GrdEmployeeInformation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdEmployeeInformation.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdEmployeeInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdEmployeeInformation.Location = New System.Drawing.Point(5, 424)
        Me.GrdEmployeeInformation.Name = "GrdEmployeeInformation"
        Me.GrdEmployeeInformation.ReadOnly = True
        Me.GrdEmployeeInformation.Size = New System.Drawing.Size(1014, 300)
        Me.GrdEmployeeInformation.TabIndex = 1156
        '
        'CmbEmployeeCategoryID
        '
        Me.CmbEmployeeCategoryID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CmbEmployeeCategoryID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbEmployeeCategoryID.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbEmployeeCategoryID.FormattingEnabled = True
        Me.CmbEmployeeCategoryID.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.CmbEmployeeCategoryID.Location = New System.Drawing.Point(121, 125)
        Me.CmbEmployeeCategoryID.Name = "CmbEmployeeCategoryID"
        Me.CmbEmployeeCategoryID.Size = New System.Drawing.Size(100, 21)
        Me.CmbEmployeeCategoryID.TabIndex = 2040
        '
        'FrmEmployeeInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1024, 736)
        Me.Controls.Add(Me.GrdEmployeeInformation)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblTotalEmployee)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.BtnRefrersh)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.GrpEmployeeInformation)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.PnlEmployeeInformation)
        Me.Controls.Add(Me.CmbSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmEmployeeInformation"
        Me.Text = "Employee Information"
        Me.GrpEmployeeInformation.ResumeLayout(False)
        Me.GrpEmployeeInformation.PerformLayout()
        CType(Me.PtbEmployeeInformation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlEmployeeInformation.ResumeLayout(False)
        Me.PnlEmployeeInformation.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.GrdEmployeeInformation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnRemove As System.Windows.Forms.Button
    Friend WithEvents DtpDateofJoin As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnRefrersh As System.Windows.Forms.Button
    Friend WithEvents DtpDateofDeparture As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
    Friend WithEvents GrpEmployeeInformation As System.Windows.Forms.GroupBox
    Friend WithEvents LblDateOfDeparture As System.Windows.Forms.Label
    Friend WithEvents LblEmployeeCategory As System.Windows.Forms.Label
    Friend WithEvents TxtMobileNumber As System.Windows.Forms.TextBox
    Friend WithEvents LblMobileNumber As System.Windows.Forms.Label
    Friend WithEvents TxtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents LblRemarks As System.Windows.Forms.Label
    Friend WithEvents DtpDateofBirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblDateofBirth As System.Windows.Forms.Label
    Friend WithEvents CmbReligion As System.Windows.Forms.ComboBox
    Friend WithEvents CmbNationality As System.Windows.Forms.ComboBox
    Friend WithEvents CmbBloodGroup As System.Windows.Forms.ComboBox
    Friend WithEvents LblReligion As System.Windows.Forms.Label
    Friend WithEvents LblNationality As System.Windows.Forms.Label
    Friend WithEvents LblBloodGroup As System.Windows.Forms.Label
    Friend WithEvents CmbGender As System.Windows.Forms.ComboBox
    Friend WithEvents LblDateOfJoin As System.Windows.Forms.Label
    Friend WithEvents LblDepartment As System.Windows.Forms.Label
    Friend WithEvents LblGender As System.Windows.Forms.Label
    Friend WithEvents TxtBasicSalary As System.Windows.Forms.TextBox
    Friend WithEvents TxtPreviousOrganization As System.Windows.Forms.TextBox
    Friend WithEvents TxtPresentAddress As System.Windows.Forms.TextBox
    Friend WithEvents TxtPermanentAddress As System.Windows.Forms.TextBox
    Friend WithEvents TxtEmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents TxtEmployeeName As System.Windows.Forms.TextBox
    Friend WithEvents TxtEmployeeID As System.Windows.Forms.TextBox
    Friend WithEvents LblPreviousOrganization As System.Windows.Forms.Label
    Friend WithEvents LblEmailAddress As System.Windows.Forms.Label
    Friend WithEvents LblBasicSalary As System.Windows.Forms.Label
    Friend WithEvents LblPermanentAddress As System.Windows.Forms.Label
    Friend WithEvents LblPresentAddress As System.Windows.Forms.Label
    Friend WithEvents LblEmployeeName As System.Windows.Forms.Label
    Friend WithEvents LblEmployeeID As System.Windows.Forms.Label
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents LblEmployeeInformation As System.Windows.Forms.Label
    Friend WithEvents PnlEmployeeInformation As System.Windows.Forms.Panel
    Friend WithEvents PtbEmployeeInformation As System.Windows.Forms.PictureBox
    Friend WithEvents BtnChoose As System.Windows.Forms.Button
    Friend WithEvents CmbSearch As System.Windows.Forms.ComboBox
    Friend WithEvents TxtSmsNotificationNo As System.Windows.Forms.TextBox
    Friend WithEvents LblSmsNotificationNo As System.Windows.Forms.Label
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents CmbEmployeeStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblEmployeeStatus As System.Windows.Forms.Label
    Friend WithEvents TxtDepartment As System.Windows.Forms.TextBox
    Friend WithEvents TxtEmployeeNIDNo As System.Windows.Forms.TextBox
    Friend WithEvents LblEmployeeNIDNo As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblTotalEmployee As System.Windows.Forms.Label
    Friend WithEvents TxtRFID As System.Windows.Forms.TextBox
    Friend WithEvents LblRFID As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
    Friend WithEvents GrdEmployeeInformation As System.Windows.Forms.DataGridView
    Friend WithEvents CmbEmployeeCategoryID As System.Windows.Forms.ComboBox
End Class
