<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSupplierInformation
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
        Me.GrpSupplierInformation = New System.Windows.Forms.GroupBox
        Me.DtpLedgerDate = New System.Windows.Forms.DateTimePicker
        Me.CmbSupplierName = New System.Windows.Forms.ComboBox
        Me.TxtOpeningBalance = New System.Windows.Forms.TextBox
        Me.LblOpeningBalance = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.CmbSupplierCategoryID = New System.Windows.Forms.ComboBox
        Me.LblSupplierCategoryID = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtPrice = New System.Windows.Forms.TextBox
        Me.LblPrice = New System.Windows.Forms.Label
        Me.CmbProductID = New System.Windows.Forms.ComboBox
        Me.lblProductID = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.lblTotalSupplier = New System.Windows.Forms.Label
        Me.BtnRemove = New System.Windows.Forms.Button
        Me.BtnChoose = New System.Windows.Forms.Button
        Me.CmbStatus = New System.Windows.Forms.ComboBox
        Me.SupplierPictureBox = New System.Windows.Forms.PictureBox
        Me.CmbSmsNotification = New System.Windows.Forms.ComboBox
        Me.TxtDiscountPercentage = New System.Windows.Forms.TextBox
        Me.TxtWebAddress = New System.Windows.Forms.TextBox
        Me.TxtCountry = New System.Windows.Forms.TextBox
        Me.TxtCity = New System.Windows.Forms.TextBox
        Me.TxtEmailAddress = New System.Windows.Forms.TextBox
        Me.TxtAddress = New System.Windows.Forms.TextBox
        Me.TxtMobileNo = New System.Windows.Forms.TextBox
        Me.TxtDesignation = New System.Windows.Forms.TextBox
        Me.TxtCompanyName = New System.Windows.Forms.TextBox
        Me.TxtSupplierID = New System.Windows.Forms.TextBox
        Me.LblDiscountPercentage = New System.Windows.Forms.Label
        Me.LblStatus = New System.Windows.Forms.Label
        Me.LblSMSNotification = New System.Windows.Forms.Label
        Me.LblCountry = New System.Windows.Forms.Label
        Me.LblCity = New System.Windows.Forms.Label
        Me.LblWebAddress = New System.Windows.Forms.Label
        Me.LblAddress = New System.Windows.Forms.Label
        Me.LblEmailAddress = New System.Windows.Forms.Label
        Me.LblMobileNo = New System.Windows.Forms.Label
        Me.LblDesignation = New System.Windows.Forms.Label
        Me.LblCompanyName = New System.Windows.Forms.Label
        Me.LblSupplierName = New System.Windows.Forms.Label
        Me.LblSupplierID = New System.Windows.Forms.Label
        Me.PnlCustomerInformation = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.LblSupplierInformation = New System.Windows.Forms.Label
        Me.CmbSearch = New System.Windows.Forms.ComboBox
        Me.TxtSearch = New System.Windows.Forms.TextBox
        Me.BtnRefresh = New System.Windows.Forms.Button
        Me.BtnInsert = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnAddNew = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.CmbSearchProductPrice = New System.Windows.Forms.ComboBox
        Me.LblF4Lbl = New System.Windows.Forms.Label
        Me.lblListID = New System.Windows.Forms.Label
        Me.lblListIDlbl = New System.Windows.Forms.Label
        Me.LblFormName = New System.Windows.Forms.Label
        Me.GrdSupplierInformation = New System.Windows.Forms.DataGridView
        Me.GrdPriceList = New System.Windows.Forms.DataGridView
        Me.GrpSupplierInformation.SuspendLayout()
        CType(Me.SupplierPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlCustomerInformation.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GrdSupplierInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdPriceList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpSupplierInformation
        '
        Me.GrpSupplierInformation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpSupplierInformation.Controls.Add(Me.DtpLedgerDate)
        Me.GrpSupplierInformation.Controls.Add(Me.CmbSupplierName)
        Me.GrpSupplierInformation.Controls.Add(Me.TxtOpeningBalance)
        Me.GrpSupplierInformation.Controls.Add(Me.LblOpeningBalance)
        Me.GrpSupplierInformation.Controls.Add(Me.Label7)
        Me.GrpSupplierInformation.Controls.Add(Me.Label6)
        Me.GrpSupplierInformation.Controls.Add(Me.Label5)
        Me.GrpSupplierInformation.Controls.Add(Me.CmbSupplierCategoryID)
        Me.GrpSupplierInformation.Controls.Add(Me.LblSupplierCategoryID)
        Me.GrpSupplierInformation.Controls.Add(Me.Label1)
        Me.GrpSupplierInformation.Controls.Add(Me.TxtPrice)
        Me.GrpSupplierInformation.Controls.Add(Me.LblPrice)
        Me.GrpSupplierInformation.Controls.Add(Me.CmbProductID)
        Me.GrpSupplierInformation.Controls.Add(Me.lblProductID)
        Me.GrpSupplierInformation.Controls.Add(Me.Label4)
        Me.GrpSupplierInformation.Controls.Add(Me.Label3)
        Me.GrpSupplierInformation.Controls.Add(Me.Label2)
        Me.GrpSupplierInformation.Controls.Add(Me.Label15)
        Me.GrpSupplierInformation.Controls.Add(Me.lblTotalSupplier)
        Me.GrpSupplierInformation.Controls.Add(Me.BtnRemove)
        Me.GrpSupplierInformation.Controls.Add(Me.BtnChoose)
        Me.GrpSupplierInformation.Controls.Add(Me.CmbStatus)
        Me.GrpSupplierInformation.Controls.Add(Me.SupplierPictureBox)
        Me.GrpSupplierInformation.Controls.Add(Me.CmbSmsNotification)
        Me.GrpSupplierInformation.Controls.Add(Me.TxtDiscountPercentage)
        Me.GrpSupplierInformation.Controls.Add(Me.TxtWebAddress)
        Me.GrpSupplierInformation.Controls.Add(Me.TxtCountry)
        Me.GrpSupplierInformation.Controls.Add(Me.TxtCity)
        Me.GrpSupplierInformation.Controls.Add(Me.TxtEmailAddress)
        Me.GrpSupplierInformation.Controls.Add(Me.TxtAddress)
        Me.GrpSupplierInformation.Controls.Add(Me.TxtMobileNo)
        Me.GrpSupplierInformation.Controls.Add(Me.TxtDesignation)
        Me.GrpSupplierInformation.Controls.Add(Me.TxtCompanyName)
        Me.GrpSupplierInformation.Controls.Add(Me.TxtSupplierID)
        Me.GrpSupplierInformation.Controls.Add(Me.LblDiscountPercentage)
        Me.GrpSupplierInformation.Controls.Add(Me.LblStatus)
        Me.GrpSupplierInformation.Controls.Add(Me.LblSMSNotification)
        Me.GrpSupplierInformation.Controls.Add(Me.LblCountry)
        Me.GrpSupplierInformation.Controls.Add(Me.LblCity)
        Me.GrpSupplierInformation.Controls.Add(Me.LblWebAddress)
        Me.GrpSupplierInformation.Controls.Add(Me.LblAddress)
        Me.GrpSupplierInformation.Controls.Add(Me.LblEmailAddress)
        Me.GrpSupplierInformation.Controls.Add(Me.LblMobileNo)
        Me.GrpSupplierInformation.Controls.Add(Me.LblDesignation)
        Me.GrpSupplierInformation.Controls.Add(Me.LblCompanyName)
        Me.GrpSupplierInformation.Controls.Add(Me.LblSupplierName)
        Me.GrpSupplierInformation.Controls.Add(Me.LblSupplierID)
        Me.GrpSupplierInformation.Location = New System.Drawing.Point(12, 139)
        Me.GrpSupplierInformation.Name = "GrpSupplierInformation"
        Me.GrpSupplierInformation.Size = New System.Drawing.Size(990, 332)
        Me.GrpSupplierInformation.TabIndex = 120
        Me.GrpSupplierInformation.TabStop = False
        Me.GrpSupplierInformation.Text = "Supplier Information"
        '
        'DtpLedgerDate
        '
        Me.DtpLedgerDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpLedgerDate.Location = New System.Drawing.Point(288, 299)
        Me.DtpLedgerDate.Name = "DtpLedgerDate"
        Me.DtpLedgerDate.Size = New System.Drawing.Size(98, 20)
        Me.DtpLedgerDate.TabIndex = 2057
        Me.DtpLedgerDate.Value = New Date(2018, 3, 3, 0, 0, 0, 0)
        '
        'CmbSupplierName
        '
        Me.CmbSupplierName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbSupplierName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbSupplierName.FormattingEnabled = True
        Me.CmbSupplierName.Location = New System.Drawing.Point(170, 57)
        Me.CmbSupplierName.Name = "CmbSupplierName"
        Me.CmbSupplierName.Size = New System.Drawing.Size(216, 21)
        Me.CmbSupplierName.TabIndex = 102
        '
        'TxtOpeningBalance
        '
        Me.TxtOpeningBalance.Location = New System.Drawing.Point(170, 299)
        Me.TxtOpeningBalance.Name = "TxtOpeningBalance"
        Me.TxtOpeningBalance.Size = New System.Drawing.Size(108, 20)
        Me.TxtOpeningBalance.TabIndex = 115
        '
        'LblOpeningBalance
        '
        Me.LblOpeningBalance.AutoSize = True
        Me.LblOpeningBalance.Location = New System.Drawing.Point(38, 304)
        Me.LblOpeningBalance.Name = "LblOpeningBalance"
        Me.LblOpeningBalance.Size = New System.Drawing.Size(92, 13)
        Me.LblOpeningBalance.TabIndex = 2054
        Me.LblOpeningBalance.Text = "Opening Balance:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label7.Location = New System.Drawing.Point(533, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 24)
        Me.Label7.TabIndex = 2052
        Me.Label7.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label6.Location = New System.Drawing.Point(679, 281)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 15)
        Me.Label6.TabIndex = 2051
        Me.Label6.Text = "[Enter]"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Location = New System.Drawing.Point(147, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 24)
        Me.Label5.TabIndex = 2042
        Me.Label5.Text = "*"
        '
        'CmbSupplierCategoryID
        '
        Me.CmbSupplierCategoryID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbSupplierCategoryID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbSupplierCategoryID.FormattingEnabled = True
        Me.CmbSupplierCategoryID.Location = New System.Drawing.Point(170, 86)
        Me.CmbSupplierCategoryID.Name = "CmbSupplierCategoryID"
        Me.CmbSupplierCategoryID.Size = New System.Drawing.Size(216, 21)
        Me.CmbSupplierCategoryID.TabIndex = 103
        '
        'LblSupplierCategoryID
        '
        Me.LblSupplierCategoryID.AutoSize = True
        Me.LblSupplierCategoryID.Location = New System.Drawing.Point(38, 88)
        Me.LblSupplierCategoryID.Name = "LblSupplierCategoryID"
        Me.LblSupplierCategoryID.Size = New System.Drawing.Size(107, 13)
        Me.LblSupplierCategoryID.TabIndex = 2041
        Me.LblSupplierCategoryID.Text = "Supplier Category ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(679, 251)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 15)
        Me.Label1.TabIndex = 2039
        Me.Label1.Text = "[F4]"
        '
        'TxtPrice
        '
        Me.TxtPrice.Location = New System.Drawing.Point(550, 280)
        Me.TxtPrice.Name = "TxtPrice"
        Me.TxtPrice.Size = New System.Drawing.Size(123, 20)
        Me.TxtPrice.TabIndex = 2018
        '
        'LblPrice
        '
        Me.LblPrice.AutoSize = True
        Me.LblPrice.Location = New System.Drawing.Point(425, 277)
        Me.LblPrice.Name = "LblPrice"
        Me.LblPrice.Size = New System.Drawing.Size(34, 13)
        Me.LblPrice.TabIndex = 2037
        Me.LblPrice.Text = "Price:"
        '
        'CmbProductID
        '
        Me.CmbProductID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbProductID.FormattingEnabled = True
        Me.CmbProductID.Location = New System.Drawing.Point(550, 248)
        Me.CmbProductID.Name = "CmbProductID"
        Me.CmbProductID.Size = New System.Drawing.Size(123, 21)
        Me.CmbProductID.TabIndex = 2017
        '
        'lblProductID
        '
        Me.lblProductID.AutoSize = True
        Me.lblProductID.Location = New System.Drawing.Point(425, 246)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(61, 13)
        Me.lblProductID.TabIndex = 2018
        Me.lblProductID.Text = "Product ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(471, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 24)
        Me.Label4.TabIndex = 2036
        Me.Label4.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(522, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 24)
        Me.Label3.TabIndex = 2035
        Me.Label3.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(123, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 24)
        Me.Label2.TabIndex = 2034
        Me.Label2.Text = "*"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(930, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(21, 13)
        Me.Label15.TabIndex = 1163
        Me.Label15.Text = "00"
        '
        'lblTotalSupplier
        '
        Me.lblTotalSupplier.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalSupplier.AutoSize = True
        Me.lblTotalSupplier.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTotalSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSupplier.Location = New System.Drawing.Point(822, 16)
        Me.lblTotalSupplier.Name = "lblTotalSupplier"
        Me.lblTotalSupplier.Size = New System.Drawing.Size(95, 16)
        Me.lblTotalSupplier.TabIndex = 1162
        Me.lblTotalSupplier.Text = "Total Supplier:"
        '
        'BtnRemove
        '
        Me.BtnRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRemove.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRemove.Location = New System.Drawing.Point(902, 192)
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
        Me.BtnChoose.Location = New System.Drawing.Point(828, 192)
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
        Me.CmbStatus.Location = New System.Drawing.Point(550, 92)
        Me.CmbStatus.Name = "CmbStatus"
        Me.CmbStatus.Size = New System.Drawing.Size(123, 21)
        Me.CmbStatus.TabIndex = 112
        '
        'SupplierPictureBox
        '
        Me.SupplierPictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SupplierPictureBox.BackgroundImage = Global.Business_Expert_Pro.My.Resources.Resources.worker
        Me.SupplierPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SupplierPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SupplierPictureBox.Location = New System.Drawing.Point(830, 49)
        Me.SupplierPictureBox.Name = "SupplierPictureBox"
        Me.SupplierPictureBox.Size = New System.Drawing.Size(137, 133)
        Me.SupplierPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SupplierPictureBox.TabIndex = 35
        Me.SupplierPictureBox.TabStop = False
        '
        'CmbSmsNotification
        '
        Me.CmbSmsNotification.FormattingEnabled = True
        Me.CmbSmsNotification.Items.AddRange(New Object() {"ON", "OFF"})
        Me.CmbSmsNotification.Location = New System.Drawing.Point(550, 124)
        Me.CmbSmsNotification.Name = "CmbSmsNotification"
        Me.CmbSmsNotification.Size = New System.Drawing.Size(123, 21)
        Me.CmbSmsNotification.TabIndex = 113
        '
        'TxtDiscountPercentage
        '
        Me.TxtDiscountPercentage.Location = New System.Drawing.Point(550, 156)
        Me.TxtDiscountPercentage.Name = "TxtDiscountPercentage"
        Me.TxtDiscountPercentage.Size = New System.Drawing.Size(123, 20)
        Me.TxtDiscountPercentage.TabIndex = 114
        '
        'TxtWebAddress
        '
        Me.TxtWebAddress.Location = New System.Drawing.Point(170, 271)
        Me.TxtWebAddress.Name = "TxtWebAddress"
        Me.TxtWebAddress.Size = New System.Drawing.Size(216, 20)
        Me.TxtWebAddress.TabIndex = 109
        '
        'TxtCountry
        '
        Me.TxtCountry.Location = New System.Drawing.Point(550, 61)
        Me.TxtCountry.Name = "TxtCountry"
        Me.TxtCountry.Size = New System.Drawing.Size(123, 20)
        Me.TxtCountry.TabIndex = 111
        '
        'TxtCity
        '
        Me.TxtCity.Location = New System.Drawing.Point(550, 30)
        Me.TxtCity.Name = "TxtCity"
        Me.TxtCity.Size = New System.Drawing.Size(123, 20)
        Me.TxtCity.TabIndex = 110
        '
        'TxtEmailAddress
        '
        Me.TxtEmailAddress.Location = New System.Drawing.Point(170, 199)
        Me.TxtEmailAddress.Name = "TxtEmailAddress"
        Me.TxtEmailAddress.Size = New System.Drawing.Size(216, 20)
        Me.TxtEmailAddress.TabIndex = 107
        '
        'TxtAddress
        '
        Me.TxtAddress.Location = New System.Drawing.Point(170, 227)
        Me.TxtAddress.Multiline = True
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(216, 36)
        Me.TxtAddress.TabIndex = 108
        '
        'TxtMobileNo
        '
        Me.TxtMobileNo.Location = New System.Drawing.Point(170, 171)
        Me.TxtMobileNo.Name = "TxtMobileNo"
        Me.TxtMobileNo.Size = New System.Drawing.Size(216, 20)
        Me.TxtMobileNo.TabIndex = 106
        '
        'TxtDesignation
        '
        Me.TxtDesignation.Location = New System.Drawing.Point(170, 143)
        Me.TxtDesignation.Name = "TxtDesignation"
        Me.TxtDesignation.Size = New System.Drawing.Size(216, 20)
        Me.TxtDesignation.TabIndex = 105
        '
        'TxtCompanyName
        '
        Me.TxtCompanyName.Location = New System.Drawing.Point(170, 115)
        Me.TxtCompanyName.Name = "TxtCompanyName"
        Me.TxtCompanyName.Size = New System.Drawing.Size(216, 20)
        Me.TxtCompanyName.TabIndex = 104
        '
        'TxtSupplierID
        '
        Me.TxtSupplierID.Enabled = False
        Me.TxtSupplierID.Location = New System.Drawing.Point(170, 29)
        Me.TxtSupplierID.Name = "TxtSupplierID"
        Me.TxtSupplierID.Size = New System.Drawing.Size(100, 20)
        Me.TxtSupplierID.TabIndex = 101
        '
        'LblDiscountPercentage
        '
        Me.LblDiscountPercentage.AutoSize = True
        Me.LblDiscountPercentage.Location = New System.Drawing.Point(425, 154)
        Me.LblDiscountPercentage.Name = "LblDiscountPercentage"
        Me.LblDiscountPercentage.Size = New System.Drawing.Size(110, 13)
        Me.LblDiscountPercentage.TabIndex = 15
        Me.LblDiscountPercentage.Text = "Discount Percentage:"
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Location = New System.Drawing.Point(425, 92)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(40, 13)
        Me.LblStatus.TabIndex = 14
        Me.LblStatus.Text = "Status:"
        '
        'LblSMSNotification
        '
        Me.LblSMSNotification.AutoSize = True
        Me.LblSMSNotification.Location = New System.Drawing.Point(425, 123)
        Me.LblSMSNotification.Name = "LblSMSNotification"
        Me.LblSMSNotification.Size = New System.Drawing.Size(89, 13)
        Me.LblSMSNotification.TabIndex = 13
        Me.LblSMSNotification.Text = "SMS Notification:"
        '
        'LblCountry
        '
        Me.LblCountry.AutoSize = True
        Me.LblCountry.Location = New System.Drawing.Point(425, 61)
        Me.LblCountry.Name = "LblCountry"
        Me.LblCountry.Size = New System.Drawing.Size(46, 13)
        Me.LblCountry.TabIndex = 11
        Me.LblCountry.Text = "Country:"
        '
        'LblCity
        '
        Me.LblCity.AutoSize = True
        Me.LblCity.Location = New System.Drawing.Point(425, 30)
        Me.LblCity.Name = "LblCity"
        Me.LblCity.Size = New System.Drawing.Size(27, 13)
        Me.LblCity.TabIndex = 10
        Me.LblCity.Text = "City:"
        '
        'LblWebAddress
        '
        Me.LblWebAddress.AutoSize = True
        Me.LblWebAddress.Location = New System.Drawing.Point(38, 275)
        Me.LblWebAddress.Name = "LblWebAddress"
        Me.LblWebAddress.Size = New System.Drawing.Size(74, 13)
        Me.LblWebAddress.TabIndex = 8
        Me.LblWebAddress.Text = "Web Address:"
        '
        'LblAddress
        '
        Me.LblAddress.AutoSize = True
        Me.LblAddress.Location = New System.Drawing.Point(38, 233)
        Me.LblAddress.Name = "LblAddress"
        Me.LblAddress.Size = New System.Drawing.Size(48, 13)
        Me.LblAddress.TabIndex = 7
        Me.LblAddress.Text = "Address:"
        '
        'LblEmailAddress
        '
        Me.LblEmailAddress.AutoSize = True
        Me.LblEmailAddress.Location = New System.Drawing.Point(38, 204)
        Me.LblEmailAddress.Name = "LblEmailAddress"
        Me.LblEmailAddress.Size = New System.Drawing.Size(76, 13)
        Me.LblEmailAddress.TabIndex = 6
        Me.LblEmailAddress.Text = "Email Address:"
        '
        'LblMobileNo
        '
        Me.LblMobileNo.AutoSize = True
        Me.LblMobileNo.Location = New System.Drawing.Point(38, 175)
        Me.LblMobileNo.Name = "LblMobileNo"
        Me.LblMobileNo.Size = New System.Drawing.Size(58, 13)
        Me.LblMobileNo.TabIndex = 5
        Me.LblMobileNo.Text = "Mobile No:"
        '
        'LblDesignation
        '
        Me.LblDesignation.AutoSize = True
        Me.LblDesignation.Location = New System.Drawing.Point(38, 146)
        Me.LblDesignation.Name = "LblDesignation"
        Me.LblDesignation.Size = New System.Drawing.Size(66, 13)
        Me.LblDesignation.TabIndex = 4
        Me.LblDesignation.Text = "Designation:"
        '
        'LblCompanyName
        '
        Me.LblCompanyName.AutoSize = True
        Me.LblCompanyName.Location = New System.Drawing.Point(38, 117)
        Me.LblCompanyName.Name = "LblCompanyName"
        Me.LblCompanyName.Size = New System.Drawing.Size(85, 13)
        Me.LblCompanyName.TabIndex = 3
        Me.LblCompanyName.Text = "Company Name:"
        '
        'LblSupplierName
        '
        Me.LblSupplierName.AutoSize = True
        Me.LblSupplierName.Location = New System.Drawing.Point(38, 59)
        Me.LblSupplierName.Name = "LblSupplierName"
        Me.LblSupplierName.Size = New System.Drawing.Size(79, 13)
        Me.LblSupplierName.TabIndex = 2
        Me.LblSupplierName.Text = "Supplier Name:"
        '
        'LblSupplierID
        '
        Me.LblSupplierID.AutoSize = True
        Me.LblSupplierID.Location = New System.Drawing.Point(38, 30)
        Me.LblSupplierID.Name = "LblSupplierID"
        Me.LblSupplierID.Size = New System.Drawing.Size(62, 13)
        Me.LblSupplierID.TabIndex = 1
        Me.LblSupplierID.Text = "Supplier ID:"
        '
        'PnlCustomerInformation
        '
        Me.PnlCustomerInformation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlCustomerInformation.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlCustomerInformation.Controls.Add(Me.Panel2)
        Me.PnlCustomerInformation.Controls.Add(Me.LblSupplierInformation)
        Me.PnlCustomerInformation.Location = New System.Drawing.Point(0, 0)
        Me.PnlCustomerInformation.Name = "PnlCustomerInformation"
        Me.PnlCustomerInformation.Size = New System.Drawing.Size(1017, 76)
        Me.PnlCustomerInformation.TabIndex = 119
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Btnclose)
        Me.Panel2.Controls.Add(Me.Btnminimized)
        Me.Panel2.Controls.Add(Me.Btnmaximized)
        Me.Panel2.Location = New System.Drawing.Point(-3, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1016, 27)
        Me.Panel2.TabIndex = 2061
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(992, 0)
        Me.Btnclose.Name = "Btnclose"
        Me.Btnclose.Size = New System.Drawing.Size(24, 24)
        Me.Btnclose.TabIndex = 1162
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
        Me.Btnminimized.Location = New System.Drawing.Point(932, 0)
        Me.Btnminimized.Name = "Btnminimized"
        Me.Btnminimized.Size = New System.Drawing.Size(24, 24)
        Me.Btnminimized.TabIndex = 1161
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
        Me.Btnmaximized.Location = New System.Drawing.Point(962, 0)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1160
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'LblSupplierInformation
        '
        Me.LblSupplierInformation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblSupplierInformation.AutoSize = True
        Me.LblSupplierInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSupplierInformation.ForeColor = System.Drawing.Color.White
        Me.LblSupplierInformation.Location = New System.Drawing.Point(335, 30)
        Me.LblSupplierInformation.Name = "LblSupplierInformation"
        Me.LblSupplierInformation.Size = New System.Drawing.Size(324, 37)
        Me.LblSupplierInformation.TabIndex = 0
        Me.LblSupplierInformation.Text = "Supplier Information"
        '
        'CmbSearch
        '
        Me.CmbSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbSearch.FormattingEnabled = True
        Me.CmbSearch.Items.AddRange(New Object() {"ID", "Supplier Name", "Company Name", "Mobile No", "Supplier Category", "Product Price By Supplier"})
        Me.CmbSearch.Location = New System.Drawing.Point(634, 82)
        Me.CmbSearch.Name = "CmbSearch"
        Me.CmbSearch.Size = New System.Drawing.Size(173, 21)
        Me.CmbSearch.TabIndex = 121
        '
        'TxtSearch
        '
        Me.TxtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSearch.Location = New System.Drawing.Point(813, 82)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(140, 20)
        Me.TxtSearch.TabIndex = 122
        '
        'BtnRefresh
        '
        Me.BtnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefresh.Image = Global.Business_Expert_Pro.My.Resources.Resources.Reboot_32px1
        Me.BtnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRefresh.Location = New System.Drawing.Point(321, 91)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(89, 36)
        Me.BtnRefresh.TabIndex = 130
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'BtnInsert
        '
        Me.BtnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInsert.Image = Global.Business_Expert_Pro.My.Resources.Resources.Save_32px_32
        Me.BtnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInsert.Location = New System.Drawing.Point(466, 91)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(89, 36)
        Me.BtnInsert.TabIndex = 117
        Me.BtnInsert.Text = "Save"
        Me.BtnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnInsert.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Image = Global.Business_Expert_Pro.My.Resources.Resources.Edit_File_32px3
        Me.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUpdate.Location = New System.Drawing.Point(115, 91)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(89, 36)
        Me.BtnUpdate.TabIndex = 118
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Image = Global.Business_Expert_Pro.My.Resources.Resources.Delete_32px3
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(218, 91)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(89, 36)
        Me.BtnDelete.TabIndex = 120
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
        Me.BtnAddNew.Location = New System.Drawing.Point(12, 91)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(89, 36)
        Me.BtnAddNew.TabIndex = 119
        Me.BtnAddNew.Text = "Add New"
        Me.BtnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BtnSearch
        '
        Me.BtnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Image = Global.Business_Expert_Pro.My.Resources.Resources.Button_15_1282
        Me.BtnSearch.Location = New System.Drawing.Point(988, 82)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(19, 19)
        Me.BtnSearch.TabIndex = 2016
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'CmbSearchProductPrice
        '
        Me.CmbSearchProductPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbSearchProductPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbSearchProductPrice.FormattingEnabled = True
        Me.CmbSearchProductPrice.Location = New System.Drawing.Point(813, 82)
        Me.CmbSearchProductPrice.Name = "CmbSearchProductPrice"
        Me.CmbSearchProductPrice.Size = New System.Drawing.Size(140, 21)
        Me.CmbSearchProductPrice.TabIndex = 2041
        Me.CmbSearchProductPrice.Visible = False
        '
        'LblF4Lbl
        '
        Me.LblF4Lbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblF4Lbl.AutoSize = True
        Me.LblF4Lbl.Location = New System.Drawing.Point(962, 85)
        Me.LblF4Lbl.Name = "LblF4Lbl"
        Me.LblF4Lbl.Size = New System.Drawing.Size(25, 13)
        Me.LblF4Lbl.TabIndex = 2042
        Me.LblF4Lbl.Text = "[F4]"
        Me.LblF4Lbl.Visible = False
        '
        'lblListID
        '
        Me.lblListID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblListID.AutoSize = True
        Me.lblListID.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListID.Location = New System.Drawing.Point(963, 725)
        Me.lblListID.Name = "lblListID"
        Me.lblListID.Size = New System.Drawing.Size(13, 9)
        Me.lblListID.TabIndex = 2039
        Me.lblListID.Text = "00"
        '
        'lblListIDlbl
        '
        Me.lblListIDlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblListIDlbl.AutoSize = True
        Me.lblListIDlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListIDlbl.Location = New System.Drawing.Point(907, 725)
        Me.lblListIDlbl.Name = "lblListIDlbl"
        Me.lblListIDlbl.Size = New System.Drawing.Size(29, 9)
        Me.lblListIDlbl.TabIndex = 2040
        Me.lblListIDlbl.Text = "List ID:"
        '
        'LblFormName
        '
        Me.LblFormName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblFormName.AutoSize = True
        Me.LblFormName.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblFormName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFormName.Location = New System.Drawing.Point(839, 112)
        Me.LblFormName.Name = "LblFormName"
        Me.LblFormName.Size = New System.Drawing.Size(79, 16)
        Me.LblFormName.TabIndex = 2051
        Me.LblFormName.Text = "Form Name"
        '
        'GrdSupplierInformation
        '
        Me.GrdSupplierInformation.AllowUserToAddRows = False
        Me.GrdSupplierInformation.AllowUserToDeleteRows = False
        Me.GrdSupplierInformation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdSupplierInformation.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdSupplierInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdSupplierInformation.Location = New System.Drawing.Point(12, 481)
        Me.GrdSupplierInformation.Name = "GrdSupplierInformation"
        Me.GrdSupplierInformation.ReadOnly = True
        Me.GrdSupplierInformation.Size = New System.Drawing.Size(572, 241)
        Me.GrdSupplierInformation.TabIndex = 2052
        '
        'GrdPriceList
        '
        Me.GrdPriceList.AllowUserToAddRows = False
        Me.GrdPriceList.AllowUserToDeleteRows = False
        Me.GrdPriceList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdPriceList.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdPriceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdPriceList.Location = New System.Drawing.Point(590, 481)
        Me.GrdPriceList.Name = "GrdPriceList"
        Me.GrdPriceList.ReadOnly = True
        Me.GrdPriceList.Size = New System.Drawing.Size(412, 241)
        Me.GrdPriceList.TabIndex = 2053
        '
        'FrmSupplierInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1014, 736)
        Me.Controls.Add(Me.GrdPriceList)
        Me.Controls.Add(Me.GrdSupplierInformation)
        Me.Controls.Add(Me.LblFormName)
        Me.Controls.Add(Me.LblF4Lbl)
        Me.Controls.Add(Me.CmbSearchProductPrice)
        Me.Controls.Add(Me.lblListIDlbl)
        Me.Controls.Add(Me.lblListID)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.CmbSearch)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.BtnInsert)
        Me.Controls.Add(Me.GrpSupplierInformation)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.PnlCustomerInformation)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnAddNew)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSupplierInformation"
        Me.Text = "Supplier Information"
        Me.GrpSupplierInformation.ResumeLayout(False)
        Me.GrpSupplierInformation.PerformLayout()
        CType(Me.SupplierPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlCustomerInformation.ResumeLayout(False)
        Me.PnlCustomerInformation.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.GrdSupplierInformation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdPriceList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SupplierPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents GrpSupplierInformation As System.Windows.Forms.GroupBox
    Friend WithEvents CmbSmsNotification As System.Windows.Forms.ComboBox
    Friend WithEvents TxtDiscountPercentage As System.Windows.Forms.TextBox
    Friend WithEvents TxtWebAddress As System.Windows.Forms.TextBox
    Friend WithEvents TxtCountry As System.Windows.Forms.TextBox
    Friend WithEvents TxtCity As System.Windows.Forms.TextBox
    Friend WithEvents TxtAddress As System.Windows.Forms.TextBox
    Friend WithEvents TxtMobileNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtDesignation As System.Windows.Forms.TextBox
    Friend WithEvents TxtCompanyName As System.Windows.Forms.TextBox
    Friend WithEvents TxtSupplierID As System.Windows.Forms.TextBox
    Friend WithEvents LblDiscountPercentage As System.Windows.Forms.Label
    Friend WithEvents LblStatus As System.Windows.Forms.Label
    Friend WithEvents LblSMSNotification As System.Windows.Forms.Label
    Friend WithEvents LblCountry As System.Windows.Forms.Label
    Friend WithEvents LblCity As System.Windows.Forms.Label
    Friend WithEvents LblWebAddress As System.Windows.Forms.Label
    Friend WithEvents LblAddress As System.Windows.Forms.Label
    Friend WithEvents LblEmailAddress As System.Windows.Forms.Label
    Friend WithEvents LblMobileNo As System.Windows.Forms.Label
    Friend WithEvents LblDesignation As System.Windows.Forms.Label
    Friend WithEvents LblCompanyName As System.Windows.Forms.Label
    Friend WithEvents LblSupplierName As System.Windows.Forms.Label
    Friend WithEvents LblSupplierID As System.Windows.Forms.Label
    Friend WithEvents PnlCustomerInformation As System.Windows.Forms.Panel
    Friend WithEvents LblSupplierInformation As System.Windows.Forms.Label
    Friend WithEvents BtnInsert As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
    Friend WithEvents CmbSearch As System.Windows.Forms.ComboBox
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents CmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button
    Friend WithEvents TxtEmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents BtnRemove As System.Windows.Forms.Button
    Friend WithEvents BtnChoose As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblTotalSupplier As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents TxtPrice As System.Windows.Forms.TextBox
    Friend WithEvents LblPrice As System.Windows.Forms.Label
    Friend WithEvents CmbProductID As System.Windows.Forms.ComboBox
    Friend WithEvents lblProductID As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CmbSupplierCategoryID As System.Windows.Forms.ComboBox
    Friend WithEvents LblSupplierCategoryID As System.Windows.Forms.Label
    Friend WithEvents CmbSearchProductPrice As System.Windows.Forms.ComboBox
    Friend WithEvents LblF4Lbl As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblListID As System.Windows.Forms.Label
    Friend WithEvents lblListIDlbl As System.Windows.Forms.Label
    Friend WithEvents LblFormName As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtOpeningBalance As System.Windows.Forms.TextBox
    Friend WithEvents LblOpeningBalance As System.Windows.Forms.Label
    Friend WithEvents CmbSupplierName As System.Windows.Forms.ComboBox
    Friend WithEvents DtpLedgerDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
    Friend WithEvents GrdSupplierInformation As System.Windows.Forms.DataGridView
    Friend WithEvents GrdPriceList As System.Windows.Forms.DataGridView
End Class
