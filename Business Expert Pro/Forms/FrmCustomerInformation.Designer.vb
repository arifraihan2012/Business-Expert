<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCustomerInformation
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
        Me.PnlCustomerInformation = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.LblCustomerInformation = New System.Windows.Forms.Label
        Me.LblCustomerID = New System.Windows.Forms.Label
        Me.LblCustomerName = New System.Windows.Forms.Label
        Me.LblCompanyName = New System.Windows.Forms.Label
        Me.LblDesignation = New System.Windows.Forms.Label
        Me.LblMobileNo = New System.Windows.Forms.Label
        Me.LblEmailAddress = New System.Windows.Forms.Label
        Me.LblAddress = New System.Windows.Forms.Label
        Me.LblCity = New System.Windows.Forms.Label
        Me.LblCountry = New System.Windows.Forms.Label
        Me.LblSMSNotification = New System.Windows.Forms.Label
        Me.LblStatus = New System.Windows.Forms.Label
        Me.LblDiscountPercentage = New System.Windows.Forms.Label
        Me.TxtCustomerID = New System.Windows.Forms.TextBox
        Me.TxtCompanyName = New System.Windows.Forms.TextBox
        Me.TxtDesignation = New System.Windows.Forms.TextBox
        Me.TxtMobileNo = New System.Windows.Forms.TextBox
        Me.TxtAddress = New System.Windows.Forms.TextBox
        Me.TxtEmailAddress = New System.Windows.Forms.TextBox
        Me.TxtCity = New System.Windows.Forms.TextBox
        Me.TxtCountry = New System.Windows.Forms.TextBox
        Me.TxtDiscountPercentage = New System.Windows.Forms.TextBox
        Me.GrpCustomerInformation = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.CmbEmployeeID = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.CmbBranchID = New System.Windows.Forms.ComboBox
        Me.LblBranchID = New System.Windows.Forms.Label
        Me.DtpLedgerDate = New System.Windows.Forms.DateTimePicker
        Me.TxtTransactionLimit = New System.Windows.Forms.TextBox
        Me.LblTransactionLimit = New System.Windows.Forms.Label
        Me.CmbCustomerName = New System.Windows.Forms.ComboBox
        Me.BtnAddToSupplier = New System.Windows.Forms.Button
        Me.TxtOpeningBalance = New System.Windows.Forms.TextBox
        Me.LblOpeningBalance = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.CmbCustomerCategoryID = New System.Windows.Forms.ComboBox
        Me.LblCustomerCategoryID = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtPrice = New System.Windows.Forms.TextBox
        Me.LblPrice = New System.Windows.Forms.Label
        Me.CmbProductID = New System.Windows.Forms.ComboBox
        Me.lblProductID = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblTotalCustomer = New System.Windows.Forms.Label
        Me.CmbSmsNotification = New System.Windows.Forms.ComboBox
        Me.BtnRemove = New System.Windows.Forms.Button
        Me.BtnChoose = New System.Windows.Forms.Button
        Me.CmbStatus = New System.Windows.Forms.ComboBox
        Me.CustomerPictureBox = New System.Windows.Forms.PictureBox
        Me.TxtWebAddress = New System.Windows.Forms.TextBox
        Me.LblWebAddress = New System.Windows.Forms.Label
        Me.CmbSearch = New System.Windows.Forms.ComboBox
        Me.TxtSearch = New System.Windows.Forms.TextBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.lblListIDlbl = New System.Windows.Forms.Label
        Me.lblListID = New System.Windows.Forms.Label
        Me.LblFormName = New System.Windows.Forms.Label
        Me.LblF4Lbl = New System.Windows.Forms.Label
        Me.CmbSearchProductPrice = New System.Windows.Forms.ComboBox
        Me.GrdCustomerInformation = New System.Windows.Forms.DataGridView
        Me.GrdPriceList = New System.Windows.Forms.DataGridView
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.BtnRefresh = New System.Windows.Forms.Button
        Me.BtnInsert = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnAddNew = New System.Windows.Forms.Button
        Me.PnlCustomerInformation.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GrpCustomerInformation.SuspendLayout()
        CType(Me.CustomerPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdCustomerInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdPriceList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlCustomerInformation
        '
        Me.PnlCustomerInformation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlCustomerInformation.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlCustomerInformation.Controls.Add(Me.Panel1)
        Me.PnlCustomerInformation.Controls.Add(Me.LblCustomerInformation)
        Me.PnlCustomerInformation.Location = New System.Drawing.Point(-1, 0)
        Me.PnlCustomerInformation.Name = "PnlCustomerInformation"
        Me.PnlCustomerInformation.Size = New System.Drawing.Size(1017, 90)
        Me.PnlCustomerInformation.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Btnclose)
        Me.Panel1.Controls.Add(Me.Btnminimized)
        Me.Panel1.Controls.Add(Me.Btnmaximized)
        Me.Panel1.Location = New System.Drawing.Point(1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1014, 30)
        Me.Panel1.TabIndex = 4
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(988, 1)
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
        Me.Btnminimized.Location = New System.Drawing.Point(936, 1)
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
        Me.Btnmaximized.Location = New System.Drawing.Point(962, 1)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1157
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'LblCustomerInformation
        '
        Me.LblCustomerInformation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblCustomerInformation.AutoSize = True
        Me.LblCustomerInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCustomerInformation.ForeColor = System.Drawing.Color.White
        Me.LblCustomerInformation.Location = New System.Drawing.Point(335, 35)
        Me.LblCustomerInformation.Name = "LblCustomerInformation"
        Me.LblCustomerInformation.Size = New System.Drawing.Size(346, 37)
        Me.LblCustomerInformation.TabIndex = 0
        Me.LblCustomerInformation.Text = "Customer Information"
        '
        'LblCustomerID
        '
        Me.LblCustomerID.AutoSize = True
        Me.LblCustomerID.Location = New System.Drawing.Point(19, 21)
        Me.LblCustomerID.Name = "LblCustomerID"
        Me.LblCustomerID.Size = New System.Drawing.Size(68, 13)
        Me.LblCustomerID.TabIndex = 1
        Me.LblCustomerID.Text = "Customer ID:"
        '
        'LblCustomerName
        '
        Me.LblCustomerName.AutoSize = True
        Me.LblCustomerName.Location = New System.Drawing.Point(19, 50)
        Me.LblCustomerName.Name = "LblCustomerName"
        Me.LblCustomerName.Size = New System.Drawing.Size(85, 13)
        Me.LblCustomerName.TabIndex = 2
        Me.LblCustomerName.Text = "Customer Name:"
        '
        'LblCompanyName
        '
        Me.LblCompanyName.AutoSize = True
        Me.LblCompanyName.Location = New System.Drawing.Point(19, 108)
        Me.LblCompanyName.Name = "LblCompanyName"
        Me.LblCompanyName.Size = New System.Drawing.Size(85, 13)
        Me.LblCompanyName.TabIndex = 3
        Me.LblCompanyName.Text = "Company Name:"
        '
        'LblDesignation
        '
        Me.LblDesignation.AutoSize = True
        Me.LblDesignation.Location = New System.Drawing.Point(19, 137)
        Me.LblDesignation.Name = "LblDesignation"
        Me.LblDesignation.Size = New System.Drawing.Size(66, 13)
        Me.LblDesignation.TabIndex = 4
        Me.LblDesignation.Text = "Designation:"
        '
        'LblMobileNo
        '
        Me.LblMobileNo.AutoSize = True
        Me.LblMobileNo.Location = New System.Drawing.Point(19, 166)
        Me.LblMobileNo.Name = "LblMobileNo"
        Me.LblMobileNo.Size = New System.Drawing.Size(58, 13)
        Me.LblMobileNo.TabIndex = 5
        Me.LblMobileNo.Text = "Mobile No:"
        '
        'LblEmailAddress
        '
        Me.LblEmailAddress.AutoSize = True
        Me.LblEmailAddress.Location = New System.Drawing.Point(19, 195)
        Me.LblEmailAddress.Name = "LblEmailAddress"
        Me.LblEmailAddress.Size = New System.Drawing.Size(76, 13)
        Me.LblEmailAddress.TabIndex = 6
        Me.LblEmailAddress.Text = "Email Address:"
        '
        'LblAddress
        '
        Me.LblAddress.AutoSize = True
        Me.LblAddress.Location = New System.Drawing.Point(19, 229)
        Me.LblAddress.Name = "LblAddress"
        Me.LblAddress.Size = New System.Drawing.Size(48, 13)
        Me.LblAddress.TabIndex = 7
        Me.LblAddress.Text = "Address:"
        '
        'LblCity
        '
        Me.LblCity.AutoSize = True
        Me.LblCity.Location = New System.Drawing.Point(424, 21)
        Me.LblCity.Name = "LblCity"
        Me.LblCity.Size = New System.Drawing.Size(27, 13)
        Me.LblCity.TabIndex = 10
        Me.LblCity.Text = "City:"
        '
        'LblCountry
        '
        Me.LblCountry.AutoSize = True
        Me.LblCountry.Location = New System.Drawing.Point(424, 50)
        Me.LblCountry.Name = "LblCountry"
        Me.LblCountry.Size = New System.Drawing.Size(46, 13)
        Me.LblCountry.TabIndex = 11
        Me.LblCountry.Text = "Country:"
        '
        'LblSMSNotification
        '
        Me.LblSMSNotification.AutoSize = True
        Me.LblSMSNotification.Location = New System.Drawing.Point(424, 108)
        Me.LblSMSNotification.Name = "LblSMSNotification"
        Me.LblSMSNotification.Size = New System.Drawing.Size(89, 13)
        Me.LblSMSNotification.TabIndex = 13
        Me.LblSMSNotification.Text = "SMS Notification:"
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Location = New System.Drawing.Point(424, 79)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(40, 13)
        Me.LblStatus.TabIndex = 14
        Me.LblStatus.Text = "Status:"
        '
        'LblDiscountPercentage
        '
        Me.LblDiscountPercentage.AutoSize = True
        Me.LblDiscountPercentage.Location = New System.Drawing.Point(424, 137)
        Me.LblDiscountPercentage.Name = "LblDiscountPercentage"
        Me.LblDiscountPercentage.Size = New System.Drawing.Size(110, 13)
        Me.LblDiscountPercentage.TabIndex = 15
        Me.LblDiscountPercentage.Text = "Discount Percentage:"
        '
        'TxtCustomerID
        '
        Me.TxtCustomerID.Enabled = False
        Me.TxtCustomerID.Location = New System.Drawing.Point(159, 21)
        Me.TxtCustomerID.Name = "TxtCustomerID"
        Me.TxtCustomerID.Size = New System.Drawing.Size(104, 20)
        Me.TxtCustomerID.TabIndex = 1023
        '
        'TxtCompanyName
        '
        Me.TxtCompanyName.Location = New System.Drawing.Point(159, 110)
        Me.TxtCompanyName.Name = "TxtCompanyName"
        Me.TxtCompanyName.Size = New System.Drawing.Size(245, 20)
        Me.TxtCompanyName.TabIndex = 1026
        '
        'TxtDesignation
        '
        Me.TxtDesignation.Location = New System.Drawing.Point(159, 139)
        Me.TxtDesignation.Name = "TxtDesignation"
        Me.TxtDesignation.Size = New System.Drawing.Size(245, 20)
        Me.TxtDesignation.TabIndex = 1027
        '
        'TxtMobileNo
        '
        Me.TxtMobileNo.Location = New System.Drawing.Point(159, 168)
        Me.TxtMobileNo.Name = "TxtMobileNo"
        Me.TxtMobileNo.Size = New System.Drawing.Size(245, 20)
        Me.TxtMobileNo.TabIndex = 1028
        '
        'TxtAddress
        '
        Me.TxtAddress.Location = New System.Drawing.Point(159, 226)
        Me.TxtAddress.Multiline = True
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(245, 41)
        Me.TxtAddress.TabIndex = 1030
        '
        'TxtEmailAddress
        '
        Me.TxtEmailAddress.Location = New System.Drawing.Point(159, 197)
        Me.TxtEmailAddress.Name = "TxtEmailAddress"
        Me.TxtEmailAddress.Size = New System.Drawing.Size(245, 20)
        Me.TxtEmailAddress.TabIndex = 1029
        '
        'TxtCity
        '
        Me.TxtCity.Location = New System.Drawing.Point(553, 21)
        Me.TxtCity.Name = "TxtCity"
        Me.TxtCity.Size = New System.Drawing.Size(118, 20)
        Me.TxtCity.TabIndex = 1032
        '
        'TxtCountry
        '
        Me.TxtCountry.Location = New System.Drawing.Point(553, 50)
        Me.TxtCountry.Name = "TxtCountry"
        Me.TxtCountry.Size = New System.Drawing.Size(118, 20)
        Me.TxtCountry.TabIndex = 1033
        '
        'TxtDiscountPercentage
        '
        Me.TxtDiscountPercentage.Location = New System.Drawing.Point(553, 139)
        Me.TxtDiscountPercentage.Name = "TxtDiscountPercentage"
        Me.TxtDiscountPercentage.Size = New System.Drawing.Size(118, 20)
        Me.TxtDiscountPercentage.TabIndex = 1036
        '
        'GrpCustomerInformation
        '
        Me.GrpCustomerInformation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpCustomerInformation.Controls.Add(Me.Label9)
        Me.GrpCustomerInformation.Controls.Add(Me.CmbEmployeeID)
        Me.GrpCustomerInformation.Controls.Add(Me.Label10)
        Me.GrpCustomerInformation.Controls.Add(Me.Label8)
        Me.GrpCustomerInformation.Controls.Add(Me.CmbBranchID)
        Me.GrpCustomerInformation.Controls.Add(Me.LblBranchID)
        Me.GrpCustomerInformation.Controls.Add(Me.DtpLedgerDate)
        Me.GrpCustomerInformation.Controls.Add(Me.TxtTransactionLimit)
        Me.GrpCustomerInformation.Controls.Add(Me.LblTransactionLimit)
        Me.GrpCustomerInformation.Controls.Add(Me.CmbCustomerName)
        Me.GrpCustomerInformation.Controls.Add(Me.BtnAddToSupplier)
        Me.GrpCustomerInformation.Controls.Add(Me.TxtOpeningBalance)
        Me.GrpCustomerInformation.Controls.Add(Me.LblOpeningBalance)
        Me.GrpCustomerInformation.Controls.Add(Me.Label7)
        Me.GrpCustomerInformation.Controls.Add(Me.Label2)
        Me.GrpCustomerInformation.Controls.Add(Me.Label5)
        Me.GrpCustomerInformation.Controls.Add(Me.CmbCustomerCategoryID)
        Me.GrpCustomerInformation.Controls.Add(Me.LblCustomerCategoryID)
        Me.GrpCustomerInformation.Controls.Add(Me.Label4)
        Me.GrpCustomerInformation.Controls.Add(Me.Label3)
        Me.GrpCustomerInformation.Controls.Add(Me.Label1)
        Me.GrpCustomerInformation.Controls.Add(Me.TxtPrice)
        Me.GrpCustomerInformation.Controls.Add(Me.LblPrice)
        Me.GrpCustomerInformation.Controls.Add(Me.CmbProductID)
        Me.GrpCustomerInformation.Controls.Add(Me.lblProductID)
        Me.GrpCustomerInformation.Controls.Add(Me.Label15)
        Me.GrpCustomerInformation.Controls.Add(Me.Label6)
        Me.GrpCustomerInformation.Controls.Add(Me.lblTotalCustomer)
        Me.GrpCustomerInformation.Controls.Add(Me.CmbSmsNotification)
        Me.GrpCustomerInformation.Controls.Add(Me.BtnRemove)
        Me.GrpCustomerInformation.Controls.Add(Me.BtnChoose)
        Me.GrpCustomerInformation.Controls.Add(Me.CmbStatus)
        Me.GrpCustomerInformation.Controls.Add(Me.CustomerPictureBox)
        Me.GrpCustomerInformation.Controls.Add(Me.TxtDiscountPercentage)
        Me.GrpCustomerInformation.Controls.Add(Me.TxtWebAddress)
        Me.GrpCustomerInformation.Controls.Add(Me.TxtCountry)
        Me.GrpCustomerInformation.Controls.Add(Me.LblStatus)
        Me.GrpCustomerInformation.Controls.Add(Me.TxtCity)
        Me.GrpCustomerInformation.Controls.Add(Me.TxtEmailAddress)
        Me.GrpCustomerInformation.Controls.Add(Me.TxtAddress)
        Me.GrpCustomerInformation.Controls.Add(Me.TxtMobileNo)
        Me.GrpCustomerInformation.Controls.Add(Me.TxtDesignation)
        Me.GrpCustomerInformation.Controls.Add(Me.TxtCompanyName)
        Me.GrpCustomerInformation.Controls.Add(Me.TxtCustomerID)
        Me.GrpCustomerInformation.Controls.Add(Me.LblDiscountPercentage)
        Me.GrpCustomerInformation.Controls.Add(Me.LblSMSNotification)
        Me.GrpCustomerInformation.Controls.Add(Me.LblCountry)
        Me.GrpCustomerInformation.Controls.Add(Me.LblCity)
        Me.GrpCustomerInformation.Controls.Add(Me.LblWebAddress)
        Me.GrpCustomerInformation.Controls.Add(Me.LblAddress)
        Me.GrpCustomerInformation.Controls.Add(Me.LblEmailAddress)
        Me.GrpCustomerInformation.Controls.Add(Me.LblMobileNo)
        Me.GrpCustomerInformation.Controls.Add(Me.LblDesignation)
        Me.GrpCustomerInformation.Controls.Add(Me.LblCompanyName)
        Me.GrpCustomerInformation.Controls.Add(Me.LblCustomerName)
        Me.GrpCustomerInformation.Controls.Add(Me.LblCustomerID)
        Me.GrpCustomerInformation.Location = New System.Drawing.Point(9, 165)
        Me.GrpCustomerInformation.Name = "GrpCustomerInformation"
        Me.GrpCustomerInformation.Size = New System.Drawing.Size(1001, 336)
        Me.GrpCustomerInformation.TabIndex = 31
        Me.GrpCustomerInformation.TabStop = False
        Me.GrpCustomerInformation.Text = "Customer Information"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label9.Location = New System.Drawing.Point(517, 223)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(17, 24)
        Me.Label9.TabIndex = 2061
        Me.Label9.Text = "*"
        '
        'CmbEmployeeID
        '
        Me.CmbEmployeeID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CmbEmployeeID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbEmployeeID.FormattingEnabled = True
        Me.CmbEmployeeID.Items.AddRange(New Object() {"CONNECTED", "DISCONNECTED"})
        Me.CmbEmployeeID.Location = New System.Drawing.Point(553, 226)
        Me.CmbEmployeeID.Name = "CmbEmployeeID"
        Me.CmbEmployeeID.Size = New System.Drawing.Size(118, 21)
        Me.CmbEmployeeID.TabIndex = 1039
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(424, 226)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 13)
        Me.Label10.TabIndex = 2060
        Me.Label10.Text = "Employee Name:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label8.Location = New System.Drawing.Point(517, 195)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 24)
        Me.Label8.TabIndex = 2058
        Me.Label8.Text = "*"
        '
        'CmbBranchID
        '
        Me.CmbBranchID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CmbBranchID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbBranchID.FormattingEnabled = True
        Me.CmbBranchID.Items.AddRange(New Object() {"CONNECTED", "DISCONNECTED"})
        Me.CmbBranchID.Location = New System.Drawing.Point(553, 197)
        Me.CmbBranchID.Name = "CmbBranchID"
        Me.CmbBranchID.Size = New System.Drawing.Size(118, 21)
        Me.CmbBranchID.TabIndex = 1038
        '
        'LblBranchID
        '
        Me.LblBranchID.AutoSize = True
        Me.LblBranchID.Location = New System.Drawing.Point(424, 197)
        Me.LblBranchID.Name = "LblBranchID"
        Me.LblBranchID.Size = New System.Drawing.Size(75, 13)
        Me.LblBranchID.TabIndex = 2057
        Me.LblBranchID.Text = "Branch Name:"
        '
        'DtpLedgerDate
        '
        Me.DtpLedgerDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpLedgerDate.Location = New System.Drawing.Point(305, 305)
        Me.DtpLedgerDate.Name = "DtpLedgerDate"
        Me.DtpLedgerDate.Size = New System.Drawing.Size(98, 20)
        Me.DtpLedgerDate.TabIndex = 2056
        Me.DtpLedgerDate.Value = New Date(2018, 3, 3, 0, 0, 0, 0)
        '
        'TxtTransactionLimit
        '
        Me.TxtTransactionLimit.Location = New System.Drawing.Point(553, 168)
        Me.TxtTransactionLimit.Name = "TxtTransactionLimit"
        Me.TxtTransactionLimit.Size = New System.Drawing.Size(118, 20)
        Me.TxtTransactionLimit.TabIndex = 1037
        '
        'LblTransactionLimit
        '
        Me.LblTransactionLimit.AutoSize = True
        Me.LblTransactionLimit.Location = New System.Drawing.Point(424, 166)
        Me.LblTransactionLimit.Name = "LblTransactionLimit"
        Me.LblTransactionLimit.Size = New System.Drawing.Size(90, 13)
        Me.LblTransactionLimit.TabIndex = 2055
        Me.LblTransactionLimit.Text = "Transaction Limit:"
        '
        'CmbCustomerName
        '
        Me.CmbCustomerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbCustomerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbCustomerName.FormattingEnabled = True
        Me.CmbCustomerName.Location = New System.Drawing.Point(159, 50)
        Me.CmbCustomerName.Name = "CmbCustomerName"
        Me.CmbCustomerName.Size = New System.Drawing.Size(245, 21)
        Me.CmbCustomerName.TabIndex = 1024
        '
        'BtnAddToSupplier
        '
        Me.BtnAddToSupplier.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAddToSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAddToSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddToSupplier.Image = Global.Business_Expert_Pro.My.Resources.Resources.new1
        Me.BtnAddToSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddToSupplier.Location = New System.Drawing.Point(871, 261)
        Me.BtnAddToSupplier.Name = "BtnAddToSupplier"
        Me.BtnAddToSupplier.Size = New System.Drawing.Size(116, 27)
        Me.BtnAddToSupplier.TabIndex = 2053
        Me.BtnAddToSupplier.Text = "Add To Supplier"
        Me.BtnAddToSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddToSupplier.UseVisualStyleBackColor = True
        '
        'TxtOpeningBalance
        '
        Me.TxtOpeningBalance.Location = New System.Drawing.Point(159, 305)
        Me.TxtOpeningBalance.Name = "TxtOpeningBalance"
        Me.TxtOpeningBalance.Size = New System.Drawing.Size(140, 20)
        Me.TxtOpeningBalance.TabIndex = 1037
        '
        'LblOpeningBalance
        '
        Me.LblOpeningBalance.AutoSize = True
        Me.LblOpeningBalance.Location = New System.Drawing.Point(19, 305)
        Me.LblOpeningBalance.Name = "LblOpeningBalance"
        Me.LblOpeningBalance.Size = New System.Drawing.Size(92, 13)
        Me.LblOpeningBalance.TabIndex = 2052
        Me.LblOpeningBalance.Text = "Opening Balance:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label7.Location = New System.Drawing.Point(530, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 24)
        Me.Label7.TabIndex = 2051
        Me.Label7.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label2.Location = New System.Drawing.Point(677, 299)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 15)
        Me.Label2.TabIndex = 2050
        Me.Label2.Text = "[Enter]"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Location = New System.Drawing.Point(138, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 24)
        Me.Label5.TabIndex = 2049
        Me.Label5.Text = "*"
        '
        'CmbCustomerCategoryID
        '
        Me.CmbCustomerCategoryID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbCustomerCategoryID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbCustomerCategoryID.FormattingEnabled = True
        Me.CmbCustomerCategoryID.Location = New System.Drawing.Point(159, 80)
        Me.CmbCustomerCategoryID.Name = "CmbCustomerCategoryID"
        Me.CmbCustomerCategoryID.Size = New System.Drawing.Size(245, 21)
        Me.CmbCustomerCategoryID.TabIndex = 1025
        '
        'LblCustomerCategoryID
        '
        Me.LblCustomerCategoryID.AutoSize = True
        Me.LblCustomerCategoryID.Location = New System.Drawing.Point(19, 79)
        Me.LblCustomerCategoryID.Name = "LblCustomerCategoryID"
        Me.LblCustomerCategoryID.Size = New System.Drawing.Size(113, 13)
        Me.LblCustomerCategoryID.TabIndex = 2047
        Me.LblCustomerCategoryID.Text = "Customer Category ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(517, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 24)
        Me.Label4.TabIndex = 2046
        Me.Label4.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(470, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 24)
        Me.Label3.TabIndex = 2045
        Me.Label3.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(677, 268)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 15)
        Me.Label1.TabIndex = 2044
        Me.Label1.Text = "[F4]"
        '
        'TxtPrice
        '
        Me.TxtPrice.Location = New System.Drawing.Point(553, 297)
        Me.TxtPrice.Name = "TxtPrice"
        Me.TxtPrice.Size = New System.Drawing.Size(118, 20)
        Me.TxtPrice.TabIndex = 1040
        '
        'LblPrice
        '
        Me.LblPrice.AutoSize = True
        Me.LblPrice.Location = New System.Drawing.Point(424, 298)
        Me.LblPrice.Name = "LblPrice"
        Me.LblPrice.Size = New System.Drawing.Size(34, 13)
        Me.LblPrice.TabIndex = 2042
        Me.LblPrice.Text = "Price:"
        '
        'CmbProductID
        '
        Me.CmbProductID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbProductID.FormattingEnabled = True
        Me.CmbProductID.Location = New System.Drawing.Point(553, 265)
        Me.CmbProductID.Name = "CmbProductID"
        Me.CmbProductID.Size = New System.Drawing.Size(118, 20)
        Me.CmbProductID.TabIndex = 1039
        '
        'lblProductID
        '
        Me.lblProductID.AutoSize = True
        Me.lblProductID.Location = New System.Drawing.Point(424, 266)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(61, 13)
        Me.lblProductID.TabIndex = 2041
        Me.lblProductID.Text = "Product ID:"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(948, 29)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(21, 13)
        Me.Label15.TabIndex = 1163
        Me.Label15.Text = "00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(110, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 24)
        Me.Label6.TabIndex = 2029
        Me.Label6.Text = "*"
        '
        'lblTotalCustomer
        '
        Me.lblTotalCustomer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalCustomer.AutoSize = True
        Me.lblTotalCustomer.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTotalCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCustomer.Location = New System.Drawing.Point(841, 28)
        Me.lblTotalCustomer.Name = "lblTotalCustomer"
        Me.lblTotalCustomer.Size = New System.Drawing.Size(102, 16)
        Me.lblTotalCustomer.TabIndex = 1162
        Me.lblTotalCustomer.Text = "Total Customer:"
        '
        'CmbSmsNotification
        '
        Me.CmbSmsNotification.FormattingEnabled = True
        Me.CmbSmsNotification.Items.AddRange(New Object() {"ON", "OFF"})
        Me.CmbSmsNotification.Location = New System.Drawing.Point(553, 109)
        Me.CmbSmsNotification.Name = "CmbSmsNotification"
        Me.CmbSmsNotification.Size = New System.Drawing.Size(118, 21)
        Me.CmbSmsNotification.TabIndex = 1035
        '
        'BtnRemove
        '
        Me.BtnRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRemove.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRemove.Location = New System.Drawing.Point(919, 197)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(68, 25)
        Me.BtnRemove.TabIndex = 1132
        Me.BtnRemove.Text = "Remove"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'BtnChoose
        '
        Me.BtnChoose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnChoose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnChoose.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnChoose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnChoose.Location = New System.Drawing.Point(845, 197)
        Me.BtnChoose.Name = "BtnChoose"
        Me.BtnChoose.Size = New System.Drawing.Size(68, 25)
        Me.BtnChoose.TabIndex = 1133
        Me.BtnChoose.Text = "Choose.."
        Me.BtnChoose.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnChoose.UseVisualStyleBackColor = True
        '
        'CmbStatus
        '
        Me.CmbStatus.FormattingEnabled = True
        Me.CmbStatus.Items.AddRange(New Object() {"CONNECTED", "DISCONNECTED"})
        Me.CmbStatus.Location = New System.Drawing.Point(553, 79)
        Me.CmbStatus.Name = "CmbStatus"
        Me.CmbStatus.Size = New System.Drawing.Size(118, 21)
        Me.CmbStatus.TabIndex = 1034
        '
        'CustomerPictureBox
        '
        Me.CustomerPictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CustomerPictureBox.BackgroundImage = Global.Business_Expert_Pro.My.Resources.Resources.worker
        Me.CustomerPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CustomerPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CustomerPictureBox.Location = New System.Drawing.Point(844, 57)
        Me.CustomerPictureBox.Name = "CustomerPictureBox"
        Me.CustomerPictureBox.Size = New System.Drawing.Size(137, 133)
        Me.CustomerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CustomerPictureBox.TabIndex = 35
        Me.CustomerPictureBox.TabStop = False
        '
        'TxtWebAddress
        '
        Me.TxtWebAddress.Location = New System.Drawing.Point(159, 276)
        Me.TxtWebAddress.Name = "TxtWebAddress"
        Me.TxtWebAddress.Size = New System.Drawing.Size(244, 20)
        Me.TxtWebAddress.TabIndex = 1031
        '
        'LblWebAddress
        '
        Me.LblWebAddress.AutoSize = True
        Me.LblWebAddress.Location = New System.Drawing.Point(19, 279)
        Me.LblWebAddress.Name = "LblWebAddress"
        Me.LblWebAddress.Size = New System.Drawing.Size(74, 13)
        Me.LblWebAddress.TabIndex = 8
        Me.LblWebAddress.Text = "Web Address:"
        '
        'CmbSearch
        '
        Me.CmbSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbSearch.FormattingEnabled = True
        Me.CmbSearch.Items.AddRange(New Object() {"ID", "Customer Name", "Company Name", "Mobile No", "Customer Category", "Product Price By Customer"})
        Me.CmbSearch.Location = New System.Drawing.Point(634, 101)
        Me.CmbSearch.Name = "CmbSearch"
        Me.CmbSearch.Size = New System.Drawing.Size(158, 21)
        Me.CmbSearch.TabIndex = 1043
        '
        'TxtSearch
        '
        Me.TxtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSearch.Location = New System.Drawing.Point(804, 101)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(124, 20)
        Me.TxtSearch.TabIndex = 1044
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblListIDlbl
        '
        Me.lblListIDlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblListIDlbl.AutoSize = True
        Me.lblListIDlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListIDlbl.Location = New System.Drawing.Point(915, 775)
        Me.lblListIDlbl.Name = "lblListIDlbl"
        Me.lblListIDlbl.Size = New System.Drawing.Size(29, 9)
        Me.lblListIDlbl.TabIndex = 2048
        Me.lblListIDlbl.Text = "List ID:"
        '
        'lblListID
        '
        Me.lblListID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblListID.AutoSize = True
        Me.lblListID.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListID.Location = New System.Drawing.Point(954, 775)
        Me.lblListID.Name = "lblListID"
        Me.lblListID.Size = New System.Drawing.Size(13, 9)
        Me.lblListID.TabIndex = 2047
        Me.lblListID.Text = "00"
        '
        'LblFormName
        '
        Me.LblFormName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblFormName.AutoSize = True
        Me.LblFormName.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblFormName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFormName.Location = New System.Drawing.Point(835, 132)
        Me.LblFormName.Name = "LblFormName"
        Me.LblFormName.Size = New System.Drawing.Size(79, 16)
        Me.LblFormName.TabIndex = 2050
        Me.LblFormName.Text = "Form Name"
        '
        'LblF4Lbl
        '
        Me.LblF4Lbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblF4Lbl.AutoSize = True
        Me.LblF4Lbl.Location = New System.Drawing.Point(950, 104)
        Me.LblF4Lbl.Name = "LblF4Lbl"
        Me.LblF4Lbl.Size = New System.Drawing.Size(25, 13)
        Me.LblF4Lbl.TabIndex = 2052
        Me.LblF4Lbl.Text = "[F4]"
        Me.LblF4Lbl.Visible = False
        '
        'CmbSearchProductPrice
        '
        Me.CmbSearchProductPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbSearchProductPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbSearchProductPrice.FormattingEnabled = True
        Me.CmbSearchProductPrice.Location = New System.Drawing.Point(804, 101)
        Me.CmbSearchProductPrice.Name = "CmbSearchProductPrice"
        Me.CmbSearchProductPrice.Size = New System.Drawing.Size(140, 21)
        Me.CmbSearchProductPrice.TabIndex = 2051
        Me.CmbSearchProductPrice.Visible = False
        '
        'GrdCustomerInformation
        '
        Me.GrdCustomerInformation.AllowUserToAddRows = False
        Me.GrdCustomerInformation.AllowUserToDeleteRows = False
        Me.GrdCustomerInformation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdCustomerInformation.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdCustomerInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdCustomerInformation.Location = New System.Drawing.Point(8, 510)
        Me.GrdCustomerInformation.Name = "GrdCustomerInformation"
        Me.GrdCustomerInformation.ReadOnly = True
        Me.GrdCustomerInformation.Size = New System.Drawing.Size(575, 264)
        Me.GrdCustomerInformation.TabIndex = 2053
        '
        'GrdPriceList
        '
        Me.GrdPriceList.AllowUserToAddRows = False
        Me.GrdPriceList.AllowUserToDeleteRows = False
        Me.GrdPriceList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdPriceList.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdPriceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdPriceList.Location = New System.Drawing.Point(587, 510)
        Me.GrdPriceList.Name = "GrdPriceList"
        Me.GrdPriceList.ReadOnly = True
        Me.GrdPriceList.Size = New System.Drawing.Size(423, 263)
        Me.GrdPriceList.TabIndex = 2054
        '
        'BtnSearch
        '
        Me.BtnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Image = Global.Business_Expert_Pro.My.Resources.Resources.Button_15_1282
        Me.BtnSearch.Location = New System.Drawing.Point(977, 101)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(19, 19)
        Me.BtnSearch.TabIndex = 2015
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'BtnRefresh
        '
        Me.BtnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefresh.Image = Global.Business_Expert_Pro.My.Resources.Resources.Reboot_32px1
        Me.BtnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRefresh.Location = New System.Drawing.Point(296, 116)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(89, 35)
        Me.BtnRefresh.TabIndex = 1046
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'BtnInsert
        '
        Me.BtnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInsert.Image = Global.Business_Expert_Pro.My.Resources.Resources.Save_32px_31
        Me.BtnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInsert.Location = New System.Drawing.Point(441, 116)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(90, 35)
        Me.BtnInsert.TabIndex = 1039
        Me.BtnInsert.Text = "Save"
        Me.BtnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnInsert.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Image = Global.Business_Expert_Pro.My.Resources.Resources.Edit_File_32px1
        Me.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUpdate.Location = New System.Drawing.Point(102, 116)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(90, 35)
        Me.BtnUpdate.TabIndex = 1040
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Image = Global.Business_Expert_Pro.My.Resources.Resources.Delete_32px1
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(200, 116)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(90, 35)
        Me.BtnDelete.TabIndex = 1042
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.UseVisualStyleBackColor = True
        Me.BtnDelete.Visible = False
        '
        'BtnAddNew
        '
        Me.BtnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddNew.Image = Global.Business_Expert_Pro.My.Resources.Resources.Add_New3
        Me.BtnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddNew.Location = New System.Drawing.Point(8, 116)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(90, 35)
        Me.BtnAddNew.TabIndex = 1041
        Me.BtnAddNew.Text = "Add New"
        Me.BtnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'FrmCustomerInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1014, 784)
        Me.Controls.Add(Me.GrdPriceList)
        Me.Controls.Add(Me.GrdCustomerInformation)
        Me.Controls.Add(Me.LblF4Lbl)
        Me.Controls.Add(Me.CmbSearchProductPrice)
        Me.Controls.Add(Me.LblFormName)
        Me.Controls.Add(Me.lblListIDlbl)
        Me.Controls.Add(Me.lblListID)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.BtnInsert)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.CmbSearch)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.GrpCustomerInformation)
        Me.Controls.Add(Me.PnlCustomerInformation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCustomerInformation"
        Me.Text = "Customer Information"
        Me.PnlCustomerInformation.ResumeLayout(False)
        Me.PnlCustomerInformation.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GrpCustomerInformation.ResumeLayout(False)
        Me.GrpCustomerInformation.PerformLayout()
        CType(Me.CustomerPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdCustomerInformation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdPriceList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PnlCustomerInformation As System.Windows.Forms.Panel
    Friend WithEvents LblCustomerInformation As System.Windows.Forms.Label
    Friend WithEvents LblCustomerID As System.Windows.Forms.Label
    Friend WithEvents LblCustomerName As System.Windows.Forms.Label
    Friend WithEvents LblCompanyName As System.Windows.Forms.Label
    Friend WithEvents LblDesignation As System.Windows.Forms.Label
    Friend WithEvents LblMobileNo As System.Windows.Forms.Label
    Friend WithEvents LblEmailAddress As System.Windows.Forms.Label
    Friend WithEvents LblAddress As System.Windows.Forms.Label
    Friend WithEvents LblCity As System.Windows.Forms.Label
    Friend WithEvents LblCountry As System.Windows.Forms.Label
    Friend WithEvents LblSMSNotification As System.Windows.Forms.Label
    Friend WithEvents LblStatus As System.Windows.Forms.Label
    Friend WithEvents LblDiscountPercentage As System.Windows.Forms.Label
    Friend WithEvents TxtCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents TxtCompanyName As System.Windows.Forms.TextBox
    Friend WithEvents TxtDesignation As System.Windows.Forms.TextBox
    Friend WithEvents TxtMobileNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtAddress As System.Windows.Forms.TextBox
    Friend WithEvents TxtEmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents TxtCity As System.Windows.Forms.TextBox
    Friend WithEvents TxtCountry As System.Windows.Forms.TextBox
    Friend WithEvents TxtDiscountPercentage As System.Windows.Forms.TextBox
    Friend WithEvents GrpCustomerInformation As System.Windows.Forms.GroupBox
    Friend WithEvents CustomerPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents CmbSearch As System.Windows.Forms.ComboBox
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents BtnInsert As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button
    Friend WithEvents BtnRemove As System.Windows.Forms.Button
    Friend WithEvents BtnChoose As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents CmbSmsNotification As System.Windows.Forms.ComboBox
    Friend WithEvents CmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblTotalCustomer As System.Windows.Forms.Label
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents lblListIDlbl As System.Windows.Forms.Label
    Friend WithEvents lblListID As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtPrice As System.Windows.Forms.TextBox
    Friend WithEvents LblPrice As System.Windows.Forms.Label
    Friend WithEvents CmbProductID As System.Windows.Forms.ComboBox
    Friend WithEvents lblProductID As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CmbCustomerCategoryID As System.Windows.Forms.ComboBox
    Friend WithEvents LblCustomerCategoryID As System.Windows.Forms.Label
    Friend WithEvents LblFormName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblF4Lbl As System.Windows.Forms.Label
    Friend WithEvents CmbSearchProductPrice As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtOpeningBalance As System.Windows.Forms.TextBox
    Friend WithEvents LblOpeningBalance As System.Windows.Forms.Label
    Friend WithEvents TxtWebAddress As System.Windows.Forms.TextBox
    Friend WithEvents LblWebAddress As System.Windows.Forms.Label
    Friend WithEvents BtnAddToSupplier As System.Windows.Forms.Button
    Friend WithEvents CmbCustomerName As System.Windows.Forms.ComboBox
    Friend WithEvents TxtTransactionLimit As System.Windows.Forms.TextBox
    Friend WithEvents LblTransactionLimit As System.Windows.Forms.Label
    Friend WithEvents DtpLedgerDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
    Friend WithEvents GrdCustomerInformation As System.Windows.Forms.DataGridView
    Friend WithEvents GrdPriceList As System.Windows.Forms.DataGridView
    Friend WithEvents CmbBranchID As System.Windows.Forms.ComboBox
    Friend WithEvents LblBranchID As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CmbEmployeeID As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
