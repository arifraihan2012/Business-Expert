<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWarrantyLookUp
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
        Me.PnlWarrantyLookUp = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.LblWarrantyLookUp = New System.Windows.Forms.Label
        Me.GrpSerialNumber = New System.Windows.Forms.GroupBox
        Me.LblWarrantyStatus = New System.Windows.Forms.Label
        Me.LblWarrantyStatusLbl = New System.Windows.Forms.Label
        Me.LblUsedDays = New System.Windows.Forms.Label
        Me.LblUsedDaysLbl = New System.Windows.Forms.Label
        Me.LblWarranty = New System.Windows.Forms.Label
        Me.LblWarrantyDaysLbl = New System.Windows.Forms.Label
        Me.BtnAddToWarranty = New System.Windows.Forms.Button
        Me.DtpReceiveDate = New System.Windows.Forms.DateTimePicker
        Me.LblProductName = New System.Windows.Forms.Label
        Me.cmbProductName = New System.Windows.Forms.ComboBox
        Me.LblDate = New System.Windows.Forms.Label
        Me.LblWarrantyInvoice = New System.Windows.Forms.Label
        Me.TxtWarrantyInvoiceNo = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TxtSerialNumber = New System.Windows.Forms.TextBox
        Me.LblSerialNumber = New System.Windows.Forms.Label
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.TxtComplainer = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.LblPhoneNoSupplier = New System.Windows.Forms.Label
        Me.LblPurchaseDateLbl = New System.Windows.Forms.Label
        Me.LblPurchaseDate = New System.Windows.Forms.Label
        Me.LblSupplierName = New System.Windows.Forms.Label
        Me.LblSupplierNameLbl = New System.Windows.Forms.Label
        Me.LblPurchaseBranchName = New System.Windows.Forms.Label
        Me.label5 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.LblPurchaseInvoiceNo = New System.Windows.Forms.Label
        Me.GrpSupplierDetails = New System.Windows.Forms.GroupBox
        Me.TxtMobileNo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtAddress = New System.Windows.Forms.TextBox
        Me.DtpDeliveryDate = New System.Windows.Forms.DateTimePicker
        Me.LlbDeliveryDate = New System.Windows.Forms.Label
        Me.LblWarrantyID = New System.Windows.Forms.Label
        Me.LblComplainerMobileNo = New System.Windows.Forms.Label
        Me.TxtWarrantyID = New System.Windows.Forms.TextBox
        Me.LblComplainerName = New System.Windows.Forms.Label
        Me.LblRemarks = New System.Windows.Forms.Label
        Me.TxtRemarks = New System.Windows.Forms.TextBox
        Me.GrpCustomerInfo = New System.Windows.Forms.GroupBox
        Me.CmbComplainerName = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtReceivedItem = New System.Windows.Forms.TextBox
        Me.LblReceivedItem = New System.Windows.Forms.Label
        Me.BtnAddItem = New System.Windows.Forms.Button
        Me.BtnListProblem = New System.Windows.Forms.Button
        Me.CmbProblemDetails = New System.Windows.Forms.ComboBox
        Me.LblProblemDetalis = New System.Windows.Forms.Label
        Me.GrpCustomerDetails = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.LblSaleInvoiceNo = New System.Windows.Forms.Label
        Me.LblSaleBranchName = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.LblSaleUnitPrice = New System.Windows.Forms.Label
        Me.LblUnitPriceLbl = New System.Windows.Forms.Label
        Me.LblSaleDate = New System.Windows.Forms.Label
        Me.LblSaleDateLbl = New System.Windows.Forms.Label
        Me.LbLCustomerNameLbl = New System.Windows.Forms.Label
        Me.LblCustomerName = New System.Windows.Forms.Label
        Me.LblAddressCustomer = New System.Windows.Forms.Label
        Me.LblAddressLbl = New System.Windows.Forms.Label
        Me.LblPhoneNoCustomer = New System.Windows.Forms.Label
        Me.LblPhoneNoLbl = New System.Windows.Forms.Label
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnAddNew = New System.Windows.Forms.Button
        Me.BtnRefresh = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.BtnHistory = New System.Windows.Forms.Button
        Me.BtnInvoice = New System.Windows.Forms.Button
        Me.GrdProductsDetails = New System.Windows.Forms.DataGridView
        Me.GrdWarrantySerialNumber = New System.Windows.Forms.DataGridView
        Me.GrdProblemDetails = New System.Windows.Forms.DataGridView
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.PnlWarrantyLookUp.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GrpSerialNumber.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GrpSupplierDetails.SuspendLayout()
        Me.GrpCustomerInfo.SuspendLayout()
        Me.GrpCustomerDetails.SuspendLayout()
        CType(Me.GrdProductsDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdWarrantySerialNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdProblemDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlWarrantyLookUp
        '
        Me.PnlWarrantyLookUp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlWarrantyLookUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlWarrantyLookUp.Controls.Add(Me.Panel1)
        Me.PnlWarrantyLookUp.Controls.Add(Me.LblWarrantyLookUp)
        Me.PnlWarrantyLookUp.Location = New System.Drawing.Point(-1, 0)
        Me.PnlWarrantyLookUp.Name = "PnlWarrantyLookUp"
        Me.PnlWarrantyLookUp.Size = New System.Drawing.Size(1207, 77)
        Me.PnlWarrantyLookUp.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Btnclose)
        Me.Panel1.Controls.Add(Me.Btnminimized)
        Me.Panel1.Controls.Add(Me.Btnmaximized)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1203, 28)
        Me.Panel1.TabIndex = 4
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(1176, 0)
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
        Me.Btnminimized.Location = New System.Drawing.Point(1122, 0)
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
        Me.Btnmaximized.Location = New System.Drawing.Point(1149, 0)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1160
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'LblWarrantyLookUp
        '
        Me.LblWarrantyLookUp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblWarrantyLookUp.AutoSize = True
        Me.LblWarrantyLookUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWarrantyLookUp.ForeColor = System.Drawing.Color.White
        Me.LblWarrantyLookUp.Location = New System.Drawing.Point(452, 34)
        Me.LblWarrantyLookUp.Name = "LblWarrantyLookUp"
        Me.LblWarrantyLookUp.Size = New System.Drawing.Size(287, 37)
        Me.LblWarrantyLookUp.TabIndex = 0
        Me.LblWarrantyLookUp.Text = "Warranty /Service"
        '
        'GrpSerialNumber
        '
        Me.GrpSerialNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpSerialNumber.Controls.Add(Me.LblWarrantyStatus)
        Me.GrpSerialNumber.Controls.Add(Me.LblWarrantyStatusLbl)
        Me.GrpSerialNumber.Controls.Add(Me.LblUsedDays)
        Me.GrpSerialNumber.Controls.Add(Me.LblUsedDaysLbl)
        Me.GrpSerialNumber.Controls.Add(Me.LblWarranty)
        Me.GrpSerialNumber.Controls.Add(Me.LblWarrantyDaysLbl)
        Me.GrpSerialNumber.Location = New System.Drawing.Point(852, 425)
        Me.GrpSerialNumber.Name = "GrpSerialNumber"
        Me.GrpSerialNumber.Size = New System.Drawing.Size(342, 81)
        Me.GrpSerialNumber.TabIndex = 2037
        Me.GrpSerialNumber.TabStop = False
        Me.GrpSerialNumber.Text = "Product Details"
        Me.GrpSerialNumber.Visible = False
        '
        'LblWarrantyStatus
        '
        Me.LblWarrantyStatus.AutoSize = True
        Me.LblWarrantyStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.LblWarrantyStatus.Location = New System.Drawing.Point(106, 54)
        Me.LblWarrantyStatus.Name = "LblWarrantyStatus"
        Me.LblWarrantyStatus.Size = New System.Drawing.Size(42, 17)
        Me.LblWarrantyStatus.TabIndex = 130
        Me.LblWarrantyStatus.Text = "None"
        '
        'LblWarrantyStatusLbl
        '
        Me.LblWarrantyStatusLbl.AutoSize = True
        Me.LblWarrantyStatusLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.LblWarrantyStatusLbl.Location = New System.Drawing.Point(9, 54)
        Me.LblWarrantyStatusLbl.Name = "LblWarrantyStatusLbl"
        Me.LblWarrantyStatusLbl.Size = New System.Drawing.Size(86, 13)
        Me.LblWarrantyStatusLbl.TabIndex = 129
        Me.LblWarrantyStatusLbl.Text = "Warranty Status:"
        '
        'LblUsedDays
        '
        Me.LblUsedDays.AutoSize = True
        Me.LblUsedDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.LblUsedDays.Location = New System.Drawing.Point(106, 38)
        Me.LblUsedDays.Name = "LblUsedDays"
        Me.LblUsedDays.Size = New System.Drawing.Size(19, 13)
        Me.LblUsedDays.TabIndex = 124
        Me.LblUsedDays.Text = "00"
        '
        'LblUsedDaysLbl
        '
        Me.LblUsedDaysLbl.AutoSize = True
        Me.LblUsedDaysLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.LblUsedDaysLbl.Location = New System.Drawing.Point(9, 38)
        Me.LblUsedDaysLbl.Name = "LblUsedDaysLbl"
        Me.LblUsedDaysLbl.Size = New System.Drawing.Size(62, 13)
        Me.LblUsedDaysLbl.TabIndex = 123
        Me.LblUsedDaysLbl.Text = "Used Days:"
        '
        'LblWarranty
        '
        Me.LblWarranty.AutoSize = True
        Me.LblWarranty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.LblWarranty.Location = New System.Drawing.Point(106, 19)
        Me.LblWarranty.Name = "LblWarranty"
        Me.LblWarranty.Size = New System.Drawing.Size(19, 13)
        Me.LblWarranty.TabIndex = 122
        Me.LblWarranty.Text = "00"
        '
        'LblWarrantyDaysLbl
        '
        Me.LblWarrantyDaysLbl.AutoSize = True
        Me.LblWarrantyDaysLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.LblWarrantyDaysLbl.Location = New System.Drawing.Point(9, 19)
        Me.LblWarrantyDaysLbl.Name = "LblWarrantyDaysLbl"
        Me.LblWarrantyDaysLbl.Size = New System.Drawing.Size(53, 13)
        Me.LblWarrantyDaysLbl.TabIndex = 121
        Me.LblWarrantyDaysLbl.Text = "Warranty:"
        '
        'BtnAddToWarranty
        '
        Me.BtnAddToWarranty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAddToWarranty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddToWarranty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BtnAddToWarranty.ForeColor = System.Drawing.Color.Maroon
        Me.BtnAddToWarranty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddToWarranty.Location = New System.Drawing.Point(526, 98)
        Me.BtnAddToWarranty.Name = "BtnAddToWarranty"
        Me.BtnAddToWarranty.Size = New System.Drawing.Size(87, 46)
        Me.BtnAddToWarranty.TabIndex = 2059
        Me.BtnAddToWarranty.Text = "Add To Warranty"
        Me.BtnAddToWarranty.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAddToWarranty.UseVisualStyleBackColor = True
        '
        'DtpReceiveDate
        '
        Me.DtpReceiveDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpReceiveDate.Location = New System.Drawing.Point(81, 36)
        Me.DtpReceiveDate.Name = "DtpReceiveDate"
        Me.DtpReceiveDate.Size = New System.Drawing.Size(95, 20)
        Me.DtpReceiveDate.TabIndex = 2050
        Me.DtpReceiveDate.Value = New Date(2017, 7, 28, 0, 0, 0, 0)
        '
        'LblProductName
        '
        Me.LblProductName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblProductName.AutoSize = True
        Me.LblProductName.Location = New System.Drawing.Point(3, 43)
        Me.LblProductName.Name = "LblProductName"
        Me.LblProductName.Size = New System.Drawing.Size(78, 13)
        Me.LblProductName.TabIndex = 2063
        Me.LblProductName.Text = "Product Name:"
        '
        'cmbProductName
        '
        Me.cmbProductName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbProductName.FormattingEnabled = True
        Me.cmbProductName.Location = New System.Drawing.Point(91, 40)
        Me.cmbProductName.Name = "cmbProductName"
        Me.cmbProductName.Size = New System.Drawing.Size(287, 21)
        Me.cmbProductName.TabIndex = 2062
        '
        'LblDate
        '
        Me.LblDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblDate.AutoSize = True
        Me.LblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDate.Location = New System.Drawing.Point(8, 37)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(36, 15)
        Me.LblDate.TabIndex = 2073
        Me.LblDate.Text = "Date:"
        '
        'LblWarrantyInvoice
        '
        Me.LblWarrantyInvoice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblWarrantyInvoice.AutoSize = True
        Me.LblWarrantyInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWarrantyInvoice.Location = New System.Drawing.Point(8, 10)
        Me.LblWarrantyInvoice.Name = "LblWarrantyInvoice"
        Me.LblWarrantyInvoice.Size = New System.Drawing.Size(67, 15)
        Me.LblWarrantyInvoice.TabIndex = 2071
        Me.LblWarrantyInvoice.Text = "Invoice No:"
        '
        'TxtWarrantyInvoiceNo
        '
        Me.TxtWarrantyInvoiceNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtWarrantyInvoiceNo.Enabled = False
        Me.TxtWarrantyInvoiceNo.Location = New System.Drawing.Point(81, 10)
        Me.TxtWarrantyInvoiceNo.Name = "TxtWarrantyInvoiceNo"
        Me.TxtWarrantyInvoiceNo.Size = New System.Drawing.Size(95, 20)
        Me.TxtWarrantyInvoiceNo.TabIndex = 2070
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.LblDate)
        Me.GroupBox1.Controls.Add(Me.DtpReceiveDate)
        Me.GroupBox1.Controls.Add(Me.TxtWarrantyInvoiceNo)
        Me.GroupBox1.Controls.Add(Me.LblWarrantyInvoice)
        Me.GroupBox1.Location = New System.Drawing.Point(1010, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(184, 62)
        Me.GroupBox1.TabIndex = 2074
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.TxtSerialNumber)
        Me.GroupBox2.Controls.Add(Me.LblSerialNumber)
        Me.GroupBox2.Controls.Add(Me.BtnSearch)
        Me.GroupBox2.Controls.Add(Me.LblProductName)
        Me.GroupBox2.Controls.Add(Me.cmbProductName)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 83)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(508, 70)
        Me.GroupBox2.TabIndex = 2075
        Me.GroupBox2.TabStop = False
        '
        'TxtSerialNumber
        '
        Me.TxtSerialNumber.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtSerialNumber.Location = New System.Drawing.Point(91, 14)
        Me.TxtSerialNumber.Name = "TxtSerialNumber"
        Me.TxtSerialNumber.Size = New System.Drawing.Size(318, 20)
        Me.TxtSerialNumber.TabIndex = 2089
        '
        'LblSerialNumber
        '
        Me.LblSerialNumber.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblSerialNumber.AutoSize = True
        Me.LblSerialNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSerialNumber.Location = New System.Drawing.Point(3, 14)
        Me.LblSerialNumber.Name = "LblSerialNumber"
        Me.LblSerialNumber.Size = New System.Drawing.Size(90, 15)
        Me.LblSerialNumber.TabIndex = 2090
        Me.LblSerialNumber.Text = "Serial Number:"
        '
        'BtnSearch
        '
        Me.BtnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BtnSearch.ForeColor = System.Drawing.Color.Navy
        Me.BtnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSearch.Location = New System.Drawing.Point(415, 14)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(87, 46)
        Me.BtnSearch.TabIndex = 2088
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'TxtComplainer
        '
        Me.TxtComplainer.BackColor = System.Drawing.SystemColors.HotTrack
        Me.TxtComplainer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtComplainer.Location = New System.Drawing.Point(145, 48)
        Me.TxtComplainer.Name = "TxtComplainer"
        Me.TxtComplainer.Size = New System.Drawing.Size(245, 20)
        Me.TxtComplainer.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 119
        Me.Label6.Text = "Phone No:"
        '
        'LblPhoneNoSupplier
        '
        Me.LblPhoneNoSupplier.AutoSize = True
        Me.LblPhoneNoSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPhoneNoSupplier.Location = New System.Drawing.Point(106, 82)
        Me.LblPhoneNoSupplier.Name = "LblPhoneNoSupplier"
        Me.LblPhoneNoSupplier.Size = New System.Drawing.Size(33, 13)
        Me.LblPhoneNoSupplier.TabIndex = 120
        Me.LblPhoneNoSupplier.Text = "None"
        '
        'LblPurchaseDateLbl
        '
        Me.LblPurchaseDateLbl.AutoSize = True
        Me.LblPurchaseDateLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPurchaseDateLbl.Location = New System.Drawing.Point(9, 99)
        Me.LblPurchaseDateLbl.Name = "LblPurchaseDateLbl"
        Me.LblPurchaseDateLbl.Size = New System.Drawing.Size(81, 13)
        Me.LblPurchaseDateLbl.TabIndex = 133
        Me.LblPurchaseDateLbl.Text = "Purchase Date:"
        '
        'LblPurchaseDate
        '
        Me.LblPurchaseDate.AutoSize = True
        Me.LblPurchaseDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPurchaseDate.Location = New System.Drawing.Point(106, 100)
        Me.LblPurchaseDate.Name = "LblPurchaseDate"
        Me.LblPurchaseDate.Size = New System.Drawing.Size(33, 13)
        Me.LblPurchaseDate.TabIndex = 134
        Me.LblPurchaseDate.Text = "None"
        '
        'LblSupplierName
        '
        Me.LblSupplierName.AutoSize = True
        Me.LblSupplierName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSupplierName.Location = New System.Drawing.Point(106, 62)
        Me.LblSupplierName.Name = "LblSupplierName"
        Me.LblSupplierName.Size = New System.Drawing.Size(33, 13)
        Me.LblSupplierName.TabIndex = 127
        Me.LblSupplierName.Text = "None"
        '
        'LblSupplierNameLbl
        '
        Me.LblSupplierNameLbl.AutoSize = True
        Me.LblSupplierNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSupplierNameLbl.Location = New System.Drawing.Point(9, 61)
        Me.LblSupplierNameLbl.Name = "LblSupplierNameLbl"
        Me.LblSupplierNameLbl.Size = New System.Drawing.Size(79, 13)
        Me.LblSupplierNameLbl.TabIndex = 128
        Me.LblSupplierNameLbl.Text = "Supplier Name:"
        '
        'LblPurchaseBranchName
        '
        Me.LblPurchaseBranchName.AutoSize = True
        Me.LblPurchaseBranchName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPurchaseBranchName.Location = New System.Drawing.Point(106, 22)
        Me.LblPurchaseBranchName.Name = "LblPurchaseBranchName"
        Me.LblPurchaseBranchName.Size = New System.Drawing.Size(33, 13)
        Me.LblPurchaseBranchName.TabIndex = 139
        Me.LblPurchaseBranchName.Text = "None"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(9, 21)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(75, 13)
        Me.label5.TabIndex = 140
        Me.label5.Text = "Branch Name:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 137
        Me.Label9.Text = "Invoice No:"
        '
        'LblPurchaseInvoiceNo
        '
        Me.LblPurchaseInvoiceNo.AutoSize = True
        Me.LblPurchaseInvoiceNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPurchaseInvoiceNo.Location = New System.Drawing.Point(106, 42)
        Me.LblPurchaseInvoiceNo.Name = "LblPurchaseInvoiceNo"
        Me.LblPurchaseInvoiceNo.Size = New System.Drawing.Size(33, 13)
        Me.LblPurchaseInvoiceNo.TabIndex = 138
        Me.LblPurchaseInvoiceNo.Text = "None"
        '
        'GrpSupplierDetails
        '
        Me.GrpSupplierDetails.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpSupplierDetails.Controls.Add(Me.LblPurchaseInvoiceNo)
        Me.GrpSupplierDetails.Controls.Add(Me.Label9)
        Me.GrpSupplierDetails.Controls.Add(Me.label5)
        Me.GrpSupplierDetails.Controls.Add(Me.LblPurchaseBranchName)
        Me.GrpSupplierDetails.Controls.Add(Me.LblSupplierNameLbl)
        Me.GrpSupplierDetails.Controls.Add(Me.LblSupplierName)
        Me.GrpSupplierDetails.Controls.Add(Me.LblPurchaseDate)
        Me.GrpSupplierDetails.Controls.Add(Me.LblPurchaseDateLbl)
        Me.GrpSupplierDetails.Controls.Add(Me.LblPhoneNoSupplier)
        Me.GrpSupplierDetails.Controls.Add(Me.Label6)
        Me.GrpSupplierDetails.Location = New System.Drawing.Point(852, 299)
        Me.GrpSupplierDetails.Name = "GrpSupplierDetails"
        Me.GrpSupplierDetails.Size = New System.Drawing.Size(342, 124)
        Me.GrpSupplierDetails.TabIndex = 2039
        Me.GrpSupplierDetails.TabStop = False
        Me.GrpSupplierDetails.Text = "Supplier Details"
        Me.GrpSupplierDetails.Visible = False
        '
        'TxtMobileNo
        '
        Me.TxtMobileNo.Location = New System.Drawing.Point(168, 67)
        Me.TxtMobileNo.Name = "TxtMobileNo"
        Me.TxtMobileNo.Size = New System.Drawing.Size(245, 20)
        Me.TxtMobileNo.TabIndex = 1003
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 15)
        Me.Label3.TabIndex = 2049
        Me.Label3.Text = "Address:"
        '
        'TxtAddress
        '
        Me.TxtAddress.Location = New System.Drawing.Point(168, 92)
        Me.TxtAddress.Multiline = True
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(343, 40)
        Me.TxtAddress.TabIndex = 1004
        '
        'DtpDeliveryDate
        '
        Me.DtpDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDeliveryDate.Location = New System.Drawing.Point(606, 24)
        Me.DtpDeliveryDate.Name = "DtpDeliveryDate"
        Me.DtpDeliveryDate.Size = New System.Drawing.Size(97, 20)
        Me.DtpDeliveryDate.TabIndex = 2052
        Me.DtpDeliveryDate.Value = New Date(2018, 11, 1, 0, 0, 0, 0)
        '
        'LlbDeliveryDate
        '
        Me.LlbDeliveryDate.AutoSize = True
        Me.LlbDeliveryDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LlbDeliveryDate.Location = New System.Drawing.Point(518, 24)
        Me.LlbDeliveryDate.Name = "LlbDeliveryDate"
        Me.LlbDeliveryDate.Size = New System.Drawing.Size(82, 15)
        Me.LlbDeliveryDate.TabIndex = 2053
        Me.LlbDeliveryDate.Text = "Delivery Date:"
        '
        'LblWarrantyID
        '
        Me.LblWarrantyID.AutoSize = True
        Me.LblWarrantyID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWarrantyID.Location = New System.Drawing.Point(5, 16)
        Me.LblWarrantyID.Name = "LblWarrantyID"
        Me.LblWarrantyID.Size = New System.Drawing.Size(73, 15)
        Me.LblWarrantyID.TabIndex = 2055
        Me.LblWarrantyID.Text = "Warranty ID:"
        '
        'LblComplainerMobileNo
        '
        Me.LblComplainerMobileNo.AutoSize = True
        Me.LblComplainerMobileNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblComplainerMobileNo.Location = New System.Drawing.Point(5, 63)
        Me.LblComplainerMobileNo.Name = "LblComplainerMobileNo"
        Me.LblComplainerMobileNo.Size = New System.Drawing.Size(134, 15)
        Me.LblComplainerMobileNo.TabIndex = 2080
        Me.LblComplainerMobileNo.Text = "Complainer Mobile No:"
        '
        'TxtWarrantyID
        '
        Me.TxtWarrantyID.Enabled = False
        Me.TxtWarrantyID.Location = New System.Drawing.Point(168, 16)
        Me.TxtWarrantyID.Name = "TxtWarrantyID"
        Me.TxtWarrantyID.Size = New System.Drawing.Size(99, 20)
        Me.TxtWarrantyID.TabIndex = 1001
        '
        'LblComplainerName
        '
        Me.LblComplainerName.AutoSize = True
        Me.LblComplainerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblComplainerName.Location = New System.Drawing.Point(5, 38)
        Me.LblComplainerName.Name = "LblComplainerName"
        Me.LblComplainerName.Size = New System.Drawing.Size(111, 15)
        Me.LblComplainerName.TabIndex = 2086
        Me.LblComplainerName.Text = "Complainer Name:"
        '
        'LblRemarks
        '
        Me.LblRemarks.AutoSize = True
        Me.LblRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRemarks.Location = New System.Drawing.Point(5, 212)
        Me.LblRemarks.Name = "LblRemarks"
        Me.LblRemarks.Size = New System.Drawing.Size(60, 15)
        Me.LblRemarks.TabIndex = 2087
        Me.LblRemarks.Text = "Remarks:"
        '
        'TxtRemarks
        '
        Me.TxtRemarks.Location = New System.Drawing.Point(168, 212)
        Me.TxtRemarks.Multiline = True
        Me.TxtRemarks.Name = "TxtRemarks"
        Me.TxtRemarks.Size = New System.Drawing.Size(343, 41)
        Me.TxtRemarks.TabIndex = 1007
        '
        'GrpCustomerInfo
        '
        Me.GrpCustomerInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpCustomerInfo.Controls.Add(Me.Button3)
        Me.GrpCustomerInfo.Controls.Add(Me.Button2)
        Me.GrpCustomerInfo.Controls.Add(Me.CmbComplainerName)
        Me.GrpCustomerInfo.Controls.Add(Me.Label4)
        Me.GrpCustomerInfo.Controls.Add(Me.Label2)
        Me.GrpCustomerInfo.Controls.Add(Me.Label1)
        Me.GrpCustomerInfo.Controls.Add(Me.TxtReceivedItem)
        Me.GrpCustomerInfo.Controls.Add(Me.LblReceivedItem)
        Me.GrpCustomerInfo.Controls.Add(Me.BtnAddItem)
        Me.GrpCustomerInfo.Controls.Add(Me.BtnListProblem)
        Me.GrpCustomerInfo.Controls.Add(Me.CmbProblemDetails)
        Me.GrpCustomerInfo.Controls.Add(Me.LblProblemDetalis)
        Me.GrpCustomerInfo.Controls.Add(Me.TxtRemarks)
        Me.GrpCustomerInfo.Controls.Add(Me.LblRemarks)
        Me.GrpCustomerInfo.Controls.Add(Me.LblComplainerName)
        Me.GrpCustomerInfo.Controls.Add(Me.TxtWarrantyID)
        Me.GrpCustomerInfo.Controls.Add(Me.LblComplainerMobileNo)
        Me.GrpCustomerInfo.Controls.Add(Me.LblWarrantyID)
        Me.GrpCustomerInfo.Controls.Add(Me.LlbDeliveryDate)
        Me.GrpCustomerInfo.Controls.Add(Me.DtpDeliveryDate)
        Me.GrpCustomerInfo.Controls.Add(Me.TxtAddress)
        Me.GrpCustomerInfo.Controls.Add(Me.Label3)
        Me.GrpCustomerInfo.Controls.Add(Me.TxtMobileNo)
        Me.GrpCustomerInfo.Location = New System.Drawing.Point(12, 243)
        Me.GrpCustomerInfo.Name = "GrpCustomerInfo"
        Me.GrpCustomerInfo.Size = New System.Drawing.Size(831, 265)
        Me.GrpCustomerInfo.TabIndex = 2058
        Me.GrpCustomerInfo.TabStop = False
        '
        'CmbComplainerName
        '
        Me.CmbComplainerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CmbComplainerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbComplainerName.FormattingEnabled = True
        Me.CmbComplainerName.Location = New System.Drawing.Point(167, 41)
        Me.CmbComplainerName.Name = "CmbComplainerName"
        Me.CmbComplainerName.Size = New System.Drawing.Size(242, 21)
        Me.CmbComplainerName.TabIndex = 2098
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(119, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 24)
        Me.Label4.TabIndex = 2097
        Me.Label4.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(65, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 24)
        Me.Label2.TabIndex = 2096
        Me.Label2.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(142, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 24)
        Me.Label1.TabIndex = 2095
        Me.Label1.Text = "*"
        '
        'TxtReceivedItem
        '
        Me.TxtReceivedItem.Location = New System.Drawing.Point(168, 138)
        Me.TxtReceivedItem.Multiline = True
        Me.TxtReceivedItem.Name = "TxtReceivedItem"
        Me.TxtReceivedItem.Size = New System.Drawing.Size(343, 41)
        Me.TxtReceivedItem.TabIndex = 1005
        '
        'LblReceivedItem
        '
        Me.LblReceivedItem.AutoSize = True
        Me.LblReceivedItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReceivedItem.Location = New System.Drawing.Point(5, 137)
        Me.LblReceivedItem.Name = "LblReceivedItem"
        Me.LblReceivedItem.Size = New System.Drawing.Size(88, 15)
        Me.LblReceivedItem.TabIndex = 2094
        Me.LblReceivedItem.Text = "Received Item:"
        '
        'BtnAddItem
        '
        Me.BtnAddItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddItem.Image = Global.Business_Expert_Pro.My.Resources.Resources.newButton
        Me.BtnAddItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddItem.Location = New System.Drawing.Point(520, 218)
        Me.BtnAddItem.Name = "BtnAddItem"
        Me.BtnAddItem.Size = New System.Drawing.Size(105, 35)
        Me.BtnAddItem.TabIndex = 2092
        Me.BtnAddItem.Text = "More Item"
        Me.BtnAddItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddItem.UseVisualStyleBackColor = True
        '
        'BtnListProblem
        '
        Me.BtnListProblem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnListProblem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnListProblem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnListProblem.Image = Global.Business_Expert_Pro.My.Resources.Resources.Add_New5
        Me.BtnListProblem.Location = New System.Drawing.Point(521, 186)
        Me.BtnListProblem.Name = "BtnListProblem"
        Me.BtnListProblem.Size = New System.Drawing.Size(24, 21)
        Me.BtnListProblem.TabIndex = 2088
        Me.BtnListProblem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnListProblem.UseVisualStyleBackColor = True
        '
        'CmbProblemDetails
        '
        Me.CmbProblemDetails.FormattingEnabled = True
        Me.CmbProblemDetails.Location = New System.Drawing.Point(168, 185)
        Me.CmbProblemDetails.Name = "CmbProblemDetails"
        Me.CmbProblemDetails.Size = New System.Drawing.Size(343, 21)
        Me.CmbProblemDetails.TabIndex = 1006
        '
        'LblProblemDetalis
        '
        Me.LblProblemDetalis.AutoSize = True
        Me.LblProblemDetalis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProblemDetalis.Location = New System.Drawing.Point(5, 186)
        Me.LblProblemDetalis.Name = "LblProblemDetalis"
        Me.LblProblemDetalis.Size = New System.Drawing.Size(101, 15)
        Me.LblProblemDetalis.TabIndex = 2090
        Me.LblProblemDetalis.Text = "Problem Detalis :"
        '
        'GrpCustomerDetails
        '
        Me.GrpCustomerDetails.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpCustomerDetails.Controls.Add(Me.Label10)
        Me.GrpCustomerDetails.Controls.Add(Me.LblSaleInvoiceNo)
        Me.GrpCustomerDetails.Controls.Add(Me.LblSaleBranchName)
        Me.GrpCustomerDetails.Controls.Add(Me.Label8)
        Me.GrpCustomerDetails.Controls.Add(Me.LblSaleUnitPrice)
        Me.GrpCustomerDetails.Controls.Add(Me.LblUnitPriceLbl)
        Me.GrpCustomerDetails.Controls.Add(Me.LblSaleDate)
        Me.GrpCustomerDetails.Controls.Add(Me.LblSaleDateLbl)
        Me.GrpCustomerDetails.Controls.Add(Me.LbLCustomerNameLbl)
        Me.GrpCustomerDetails.Controls.Add(Me.LblCustomerName)
        Me.GrpCustomerDetails.Controls.Add(Me.LblAddressCustomer)
        Me.GrpCustomerDetails.Controls.Add(Me.LblAddressLbl)
        Me.GrpCustomerDetails.Controls.Add(Me.LblPhoneNoCustomer)
        Me.GrpCustomerDetails.Controls.Add(Me.LblPhoneNoLbl)
        Me.GrpCustomerDetails.Location = New System.Drawing.Point(852, 140)
        Me.GrpCustomerDetails.Name = "GrpCustomerDetails"
        Me.GrpCustomerDetails.Size = New System.Drawing.Size(342, 159)
        Me.GrpCustomerDetails.TabIndex = 2077
        Me.GrpCustomerDetails.TabStop = False
        Me.GrpCustomerDetails.Text = "Customer Details"
        Me.GrpCustomerDetails.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(9, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 13)
        Me.Label10.TabIndex = 2067
        Me.Label10.Text = "Branch Name:"
        '
        'LblSaleInvoiceNo
        '
        Me.LblSaleInvoiceNo.AutoSize = True
        Me.LblSaleInvoiceNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSaleInvoiceNo.Location = New System.Drawing.Point(106, 42)
        Me.LblSaleInvoiceNo.Name = "LblSaleInvoiceNo"
        Me.LblSaleInvoiceNo.Size = New System.Drawing.Size(33, 13)
        Me.LblSaleInvoiceNo.TabIndex = 136
        Me.LblSaleInvoiceNo.Text = "None"
        '
        'LblSaleBranchName
        '
        Me.LblSaleBranchName.AutoSize = True
        Me.LblSaleBranchName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.LblSaleBranchName.Location = New System.Drawing.Point(106, 21)
        Me.LblSaleBranchName.Name = "LblSaleBranchName"
        Me.LblSaleBranchName.Size = New System.Drawing.Size(33, 13)
        Me.LblSaleBranchName.TabIndex = 2066
        Me.LblSaleBranchName.Text = "None"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 135
        Me.Label8.Text = "Invoice No:"
        '
        'LblSaleUnitPrice
        '
        Me.LblSaleUnitPrice.AutoSize = True
        Me.LblSaleUnitPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSaleUnitPrice.Location = New System.Drawing.Point(106, 137)
        Me.LblSaleUnitPrice.Name = "LblSaleUnitPrice"
        Me.LblSaleUnitPrice.Size = New System.Drawing.Size(33, 13)
        Me.LblSaleUnitPrice.TabIndex = 132
        Me.LblSaleUnitPrice.Text = "None"
        '
        'LblUnitPriceLbl
        '
        Me.LblUnitPriceLbl.AutoSize = True
        Me.LblUnitPriceLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUnitPriceLbl.Location = New System.Drawing.Point(9, 136)
        Me.LblUnitPriceLbl.Name = "LblUnitPriceLbl"
        Me.LblUnitPriceLbl.Size = New System.Drawing.Size(56, 13)
        Me.LblUnitPriceLbl.TabIndex = 131
        Me.LblUnitPriceLbl.Text = "Unit Price:"
        '
        'LblSaleDate
        '
        Me.LblSaleDate.AutoSize = True
        Me.LblSaleDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSaleDate.Location = New System.Drawing.Point(106, 118)
        Me.LblSaleDate.Name = "LblSaleDate"
        Me.LblSaleDate.Size = New System.Drawing.Size(33, 13)
        Me.LblSaleDate.TabIndex = 130
        Me.LblSaleDate.Text = "None"
        '
        'LblSaleDateLbl
        '
        Me.LblSaleDateLbl.AutoSize = True
        Me.LblSaleDateLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSaleDateLbl.Location = New System.Drawing.Point(9, 117)
        Me.LblSaleDateLbl.Name = "LblSaleDateLbl"
        Me.LblSaleDateLbl.Size = New System.Drawing.Size(57, 13)
        Me.LblSaleDateLbl.TabIndex = 129
        Me.LblSaleDateLbl.Text = "Sale Date:"
        '
        'LbLCustomerNameLbl
        '
        Me.LbLCustomerNameLbl.AutoSize = True
        Me.LbLCustomerNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLCustomerNameLbl.Location = New System.Drawing.Point(9, 60)
        Me.LbLCustomerNameLbl.Name = "LbLCustomerNameLbl"
        Me.LbLCustomerNameLbl.Size = New System.Drawing.Size(85, 13)
        Me.LbLCustomerNameLbl.TabIndex = 128
        Me.LbLCustomerNameLbl.Text = "Customer Name:"
        '
        'LblCustomerName
        '
        Me.LblCustomerName.AutoSize = True
        Me.LblCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCustomerName.Location = New System.Drawing.Point(106, 61)
        Me.LblCustomerName.Name = "LblCustomerName"
        Me.LblCustomerName.Size = New System.Drawing.Size(33, 13)
        Me.LblCustomerName.TabIndex = 127
        Me.LblCustomerName.Text = "None"
        '
        'LblAddressCustomer
        '
        Me.LblAddressCustomer.AutoSize = True
        Me.LblAddressCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAddressCustomer.Location = New System.Drawing.Point(106, 99)
        Me.LblAddressCustomer.Name = "LblAddressCustomer"
        Me.LblAddressCustomer.Size = New System.Drawing.Size(33, 13)
        Me.LblAddressCustomer.TabIndex = 122
        Me.LblAddressCustomer.Text = "None"
        '
        'LblAddressLbl
        '
        Me.LblAddressLbl.AutoSize = True
        Me.LblAddressLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAddressLbl.Location = New System.Drawing.Point(9, 98)
        Me.LblAddressLbl.Name = "LblAddressLbl"
        Me.LblAddressLbl.Size = New System.Drawing.Size(48, 13)
        Me.LblAddressLbl.TabIndex = 121
        Me.LblAddressLbl.Text = "Address:"
        '
        'LblPhoneNoCustomer
        '
        Me.LblPhoneNoCustomer.AutoSize = True
        Me.LblPhoneNoCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPhoneNoCustomer.Location = New System.Drawing.Point(106, 80)
        Me.LblPhoneNoCustomer.Name = "LblPhoneNoCustomer"
        Me.LblPhoneNoCustomer.Size = New System.Drawing.Size(33, 13)
        Me.LblPhoneNoCustomer.TabIndex = 120
        Me.LblPhoneNoCustomer.Text = "None"
        '
        'LblPhoneNoLbl
        '
        Me.LblPhoneNoLbl.AutoSize = True
        Me.LblPhoneNoLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPhoneNoLbl.Location = New System.Drawing.Point(9, 79)
        Me.LblPhoneNoLbl.Name = "LblPhoneNoLbl"
        Me.LblPhoneNoLbl.Size = New System.Drawing.Size(58, 13)
        Me.LblPhoneNoLbl.TabIndex = 119
        Me.LblPhoneNoLbl.Text = "Phone No:"
        '
        'BtnDelete
        '
        Me.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.Image = Global.Business_Expert_Pro.My.Resources.Resources.Delete_32px
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(568, 177)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(110, 35)
        Me.BtnDelete.TabIndex = 2087
        Me.BtnDelete.Text = "Delete Inv."
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnAddNew
        '
        Me.BtnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddNew.Image = Global.Business_Expert_Pro.My.Resources.Resources.Add_New1
        Me.BtnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddNew.Location = New System.Drawing.Point(12, 177)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(95, 35)
        Me.BtnAddNew.TabIndex = 2086
        Me.BtnAddNew.Text = "New Inv."
        Me.BtnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'BtnRefresh
        '
        Me.BtnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefresh.Image = Global.Business_Expert_Pro.My.Resources.Resources.Reboot_32px
        Me.BtnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRefresh.Location = New System.Drawing.Point(112, 177)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(95, 35)
        Me.BtnRefresh.TabIndex = 2085
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Business_Expert_Pro.My.Resources.Resources.Save_32px_3
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(212, 177)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 35)
        Me.Button1.TabIndex = 2084
        Me.Button1.Text = "Save Inv."
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnHistory
        '
        Me.BtnHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHistory.Image = Global.Business_Expert_Pro.My.Resources.Resources.Last_view1
        Me.BtnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHistory.Location = New System.Drawing.Point(441, 177)
        Me.BtnHistory.Name = "BtnHistory"
        Me.BtnHistory.Size = New System.Drawing.Size(94, 35)
        Me.BtnHistory.TabIndex = 2088
        Me.BtnHistory.Text = "History"
        Me.BtnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnHistory.UseVisualStyleBackColor = True
        '
        'BtnInvoice
        '
        Me.BtnInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInvoice.Image = Global.Business_Expert_Pro.My.Resources.Resources.Last_view1
        Me.BtnInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInvoice.Location = New System.Drawing.Point(341, 177)
        Me.BtnInvoice.Name = "BtnInvoice"
        Me.BtnInvoice.Size = New System.Drawing.Size(94, 35)
        Me.BtnInvoice.TabIndex = 2089
        Me.BtnInvoice.Text = "Invoice"
        Me.BtnInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnInvoice.UseVisualStyleBackColor = True
        '
        'GrdProductsDetails
        '
        Me.GrdProductsDetails.AllowUserToAddRows = False
        Me.GrdProductsDetails.AllowUserToDeleteRows = False
        Me.GrdProductsDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdProductsDetails.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdProductsDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdProductsDetails.Location = New System.Drawing.Point(12, 516)
        Me.GrdProductsDetails.Name = "GrdProductsDetails"
        Me.GrdProductsDetails.ReadOnly = True
        Me.GrdProductsDetails.Size = New System.Drawing.Size(439, 237)
        Me.GrdProductsDetails.TabIndex = 2090
        '
        'GrdWarrantySerialNumber
        '
        Me.GrdWarrantySerialNumber.AllowUserToAddRows = False
        Me.GrdWarrantySerialNumber.AllowUserToDeleteRows = False
        Me.GrdWarrantySerialNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdWarrantySerialNumber.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdWarrantySerialNumber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdWarrantySerialNumber.Location = New System.Drawing.Point(457, 516)
        Me.GrdWarrantySerialNumber.Name = "GrdWarrantySerialNumber"
        Me.GrdWarrantySerialNumber.ReadOnly = True
        Me.GrdWarrantySerialNumber.Size = New System.Drawing.Size(231, 237)
        Me.GrdWarrantySerialNumber.TabIndex = 2091
        '
        'GrdProblemDetails
        '
        Me.GrdProblemDetails.AllowUserToAddRows = False
        Me.GrdProblemDetails.AllowUserToDeleteRows = False
        Me.GrdProblemDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdProblemDetails.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdProblemDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdProblemDetails.Location = New System.Drawing.Point(694, 516)
        Me.GrdProblemDetails.Name = "GrdProblemDetails"
        Me.GrdProblemDetails.ReadOnly = True
        Me.GrdProblemDetails.Size = New System.Drawing.Size(500, 237)
        Me.GrdProblemDetails.TabIndex = 2092
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Business_Expert_Pro.My.Resources.Resources.Add_New5
        Me.Button2.Location = New System.Drawing.Point(415, 39)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(24, 21)
        Me.Button2.TabIndex = 2099
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.Business_Expert_Pro.My.Resources.Resources.Reboot_32px
        Me.Button3.Location = New System.Drawing.Point(446, 38)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(24, 21)
        Me.Button3.TabIndex = 2100
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.Business_Expert_Pro.My.Resources.Resources.Add_New5
        Me.Button4.Location = New System.Drawing.Point(385, 39)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(24, 21)
        Me.Button4.TabIndex = 2101
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'FrmWarrantyLookUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1200, 765)
        Me.Controls.Add(Me.GrdProblemDetails)
        Me.Controls.Add(Me.GrdWarrantySerialNumber)
        Me.Controls.Add(Me.GrdProductsDetails)
        Me.Controls.Add(Me.BtnInvoice)
        Me.Controls.Add(Me.BtnHistory)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GrpCustomerDetails)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnAddToWarranty)
        Me.Controls.Add(Me.GrpCustomerInfo)
        Me.Controls.Add(Me.GrpSupplierDetails)
        Me.Controls.Add(Me.GrpSerialNumber)
        Me.Controls.Add(Me.PnlWarrantyLookUp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmWarrantyLookUp"
        Me.Text = "Warranty Look Up"
        Me.PnlWarrantyLookUp.ResumeLayout(False)
        Me.PnlWarrantyLookUp.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GrpSerialNumber.ResumeLayout(False)
        Me.GrpSerialNumber.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GrpSupplierDetails.ResumeLayout(False)
        Me.GrpSupplierDetails.PerformLayout()
        Me.GrpCustomerInfo.ResumeLayout(False)
        Me.GrpCustomerInfo.PerformLayout()
        Me.GrpCustomerDetails.ResumeLayout(False)
        Me.GrpCustomerDetails.PerformLayout()
        CType(Me.GrdProductsDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdWarrantySerialNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdProblemDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlWarrantyLookUp As System.Windows.Forms.Panel
    Friend WithEvents LblWarrantyLookUp As System.Windows.Forms.Label
    Friend WithEvents GrpSerialNumber As System.Windows.Forms.GroupBox
    Friend WithEvents LblWarrantyStatus As System.Windows.Forms.Label
    Friend WithEvents LblWarrantyStatusLbl As System.Windows.Forms.Label
    Friend WithEvents LblUsedDays As System.Windows.Forms.Label
    Friend WithEvents LblUsedDaysLbl As System.Windows.Forms.Label
    Friend WithEvents LblWarranty As System.Windows.Forms.Label
    Friend WithEvents LblWarrantyDaysLbl As System.Windows.Forms.Label
    Friend WithEvents BtnAddToWarranty As System.Windows.Forms.Button
    Friend WithEvents DtpReceiveDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblProductName As System.Windows.Forms.Label
    Friend WithEvents cmbProductName As System.Windows.Forms.ComboBox
    Friend WithEvents LblDate As System.Windows.Forms.Label
    Friend WithEvents LblWarrantyInvoice As System.Windows.Forms.Label
    Friend WithEvents TxtWarrantyInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtComplainer As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GrpSupplierDetails As System.Windows.Forms.GroupBox
    Friend WithEvents LblPurchaseInvoiceNo As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents LblPurchaseBranchName As System.Windows.Forms.Label
    Friend WithEvents LblSupplierNameLbl As System.Windows.Forms.Label
    Friend WithEvents LblSupplierName As System.Windows.Forms.Label
    Friend WithEvents LblPurchaseDate As System.Windows.Forms.Label
    Friend WithEvents LblPurchaseDateLbl As System.Windows.Forms.Label
    Friend WithEvents LblPhoneNoSupplier As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GrdProblemDescription As System.Windows.Forms.DataGridView
    Friend WithEvents GrdWarrentySerialNo As System.Windows.Forms.DataGridView
    Friend WithEvents TxtMobileNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtAddress As System.Windows.Forms.TextBox
    Friend WithEvents DtpDeliveryDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LlbDeliveryDate As System.Windows.Forms.Label
    Friend WithEvents LblWarrantyID As System.Windows.Forms.Label
    Friend WithEvents LblComplainerMobileNo As System.Windows.Forms.Label
    Friend WithEvents TxtWarrantyID As System.Windows.Forms.TextBox
    Friend WithEvents LblComplainerName As System.Windows.Forms.Label
    Friend WithEvents LblRemarks As System.Windows.Forms.Label
    Friend WithEvents TxtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents GrpCustomerInfo As System.Windows.Forms.GroupBox
    Friend WithEvents GrpCustomerDetails As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LblSaleInvoiceNo As System.Windows.Forms.Label
    Friend WithEvents LblSaleBranchName As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LblSaleUnitPrice As System.Windows.Forms.Label
    Friend WithEvents LblUnitPriceLbl As System.Windows.Forms.Label
    Friend WithEvents LblSaleDate As System.Windows.Forms.Label
    Friend WithEvents LblSaleDateLbl As System.Windows.Forms.Label
    Friend WithEvents LbLCustomerNameLbl As System.Windows.Forms.Label
    Friend WithEvents LblCustomerName As System.Windows.Forms.Label
    Friend WithEvents LblAddressCustomer As System.Windows.Forms.Label
    Friend WithEvents LblAddressLbl As System.Windows.Forms.Label
    Friend WithEvents LblPhoneNoCustomer As System.Windows.Forms.Label
    Friend WithEvents LblPhoneNoLbl As System.Windows.Forms.Label
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CmbProblemDetails As System.Windows.Forms.ComboBox
    Friend WithEvents LblProblemDetalis As System.Windows.Forms.Label
    Friend WithEvents BtnListProblem As System.Windows.Forms.Button
    Friend WithEvents BtnAddItem As System.Windows.Forms.Button
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents TxtReceivedItem As System.Windows.Forms.TextBox
    Friend WithEvents LblReceivedItem As System.Windows.Forms.Label
    Friend WithEvents TxtSerialNumber As System.Windows.Forms.TextBox
    Friend WithEvents LblSerialNumber As System.Windows.Forms.Label
    Friend WithEvents BtnHistory As System.Windows.Forms.Button
    Friend WithEvents BtnInvoice As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GrdProductsDetails As System.Windows.Forms.DataGridView
    Friend WithEvents GrdWarrantySerialNumber As System.Windows.Forms.DataGridView
    Friend WithEvents GrdProblemDetails As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
    Friend WithEvents CmbComplainerName As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
