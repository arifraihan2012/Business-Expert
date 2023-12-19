<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPurchase
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
        Me.LblSupplierDiscount = New System.Windows.Forms.Label
        Me.TxtSupplierDiscount = New System.Windows.Forms.TextBox
        Me.LblPaidBy = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtSearchBarcode = New System.Windows.Forms.TextBox
        Me.lbl100 = New System.Windows.Forms.Label
        Me.TxtPurchaseInvoiceNo = New System.Windows.Forms.TextBox
        Me.TxtVat = New System.Windows.Forms.TextBox
        Me.DtpPurchaseDate = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Btnsave = New System.Windows.Forms.Button
        Me.BtnAddNew = New System.Windows.Forms.Button
        Me.BtnInvoice = New System.Windows.Forms.Button
        Me.GrpSupplierInformation = New System.Windows.Forms.GroupBox
        Me.BtnSupplierName = New System.Windows.Forms.Button
        Me.TxtAddress = New System.Windows.Forms.TextBox
        Me.TxtPhoneNo = New System.Windows.Forms.TextBox
        Me.CmbSupplierName = New System.Windows.Forms.ComboBox
        Me.LblAddress = New System.Windows.Forms.Label
        Me.LblPhoneNo = New System.Windows.Forms.Label
        Me.LblSupplierName = New System.Windows.Forms.Label
        Me.GrdSupplierList = New System.Windows.Forms.DataGridView
        Me.TxtDiscount = New System.Windows.Forms.TextBox
        Me.GrpPaymentInfo = New System.Windows.Forms.GroupBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.CmbPaidBy = New System.Windows.Forms.ComboBox
        Me.TxtNetPayable = New System.Windows.Forms.TextBox
        Me.TxtPaidAmount = New System.Windows.Forms.TextBox
        Me.TxtReturnAmount = New System.Windows.Forms.TextBox
        Me.LblReturnAmount = New System.Windows.Forms.Label
        Me.TxtBalance = New System.Windows.Forms.TextBox
        Me.TxtDiscountPercentage = New System.Windows.Forms.TextBox
        Me.TxtTotal = New System.Windows.Forms.TextBox
        Me.TxtVatPercentage = New System.Windows.Forms.TextBox
        Me.TxtPreviousDues = New System.Windows.Forms.TextBox
        Me.TxtAdvance = New System.Windows.Forms.TextBox
        Me.LblBalance = New System.Windows.Forms.Label
        Me.LblPaidAmount = New System.Windows.Forms.Label
        Me.LblNetPayable = New System.Windows.Forms.Label
        Me.LblDiscount = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.LblVat = New System.Windows.Forms.Label
        Me.LblAdvance = New System.Windows.Forms.Label
        Me.LblPreviousDues = New System.Windows.Forms.Label
        Me.LblTotal = New System.Windows.Forms.Label
        Me.PnlPurchase = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.LblPurchase = New System.Windows.Forms.Label
        Me.LblSearchBarcode = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtQuantity = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtPurchaseUnitCost = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtPurchaseAmount = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.CmbProductName = New System.Windows.Forms.ComboBox
        Me.CmbLocationID = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.LblPurchaseID = New System.Windows.Forms.Label
        Me.GrpAmount = New System.Windows.Forms.GroupBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.TxtWarrantyDays = New System.Windows.Forms.TextBox
        Me.LblWarrantyDays = New System.Windows.Forms.Label
        Me.TxtFromSerial = New System.Windows.Forms.TextBox
        Me.TxtToSerial = New System.Windows.Forms.TextBox
        Me.RdbRangeSerial = New System.Windows.Forms.RadioButton
        Me.LblTo = New System.Windows.Forms.Label
        Me.LblFrom = New System.Windows.Forms.Label
        Me.TxtSerialNumber = New System.Windows.Forms.TextBox
        Me.LblSerialNumber = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtMemoNo = New System.Windows.Forms.TextBox
        Me.GrdAvailableSerialNumber = New System.Windows.Forms.DataGridView
        Me.GrdPurchase = New System.Windows.Forms.DataGridView
        Me.GrdProductList = New System.Windows.Forms.DataGridView
        Me.GrdLocationList = New System.Windows.Forms.DataGridView
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GroupBox1.SuspendLayout()
        Me.GrpSupplierInformation.SuspendLayout()
        CType(Me.GrdSupplierList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpPaymentInfo.SuspendLayout()
        Me.PnlPurchase.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GrpAmount.SuspendLayout()
        CType(Me.GrdAvailableSerialNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdPurchase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdProductList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdLocationList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblSupplierDiscount
        '
        Me.LblSupplierDiscount.AutoSize = True
        Me.LblSupplierDiscount.Location = New System.Drawing.Point(19, 130)
        Me.LblSupplierDiscount.Name = "LblSupplierDiscount"
        Me.LblSupplierDiscount.Size = New System.Drawing.Size(93, 13)
        Me.LblSupplierDiscount.TabIndex = 163
        Me.LblSupplierDiscount.Text = "Supplier Discount:"
        '
        'TxtSupplierDiscount
        '
        Me.TxtSupplierDiscount.Location = New System.Drawing.Point(129, 125)
        Me.TxtSupplierDiscount.Name = "TxtSupplierDiscount"
        Me.TxtSupplierDiscount.ReadOnly = True
        Me.TxtSupplierDiscount.Size = New System.Drawing.Size(63, 20)
        Me.TxtSupplierDiscount.TabIndex = 104
        '
        'LblPaidBy
        '
        Me.LblPaidBy.AutoSize = True
        Me.LblPaidBy.Location = New System.Drawing.Point(8, 281)
        Me.LblPaidBy.Name = "LblPaidBy"
        Me.LblPaidBy.Size = New System.Drawing.Size(46, 13)
        Me.LblPaidBy.TabIndex = 154
        Me.LblPaidBy.Text = "Paid By:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(96, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 13)
        Me.Label2.TabIndex = 151
        Me.Label2.Text = "%"
        '
        'TxtSearchBarcode
        '
        Me.TxtSearchBarcode.Location = New System.Drawing.Point(141, 246)
        Me.TxtSearchBarcode.Name = "TxtSearchBarcode"
        Me.TxtSearchBarcode.Size = New System.Drawing.Size(203, 20)
        Me.TxtSearchBarcode.TabIndex = 1019
        '
        'lbl100
        '
        Me.lbl100.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl100.AutoSize = True
        Me.lbl100.Location = New System.Drawing.Point(860, 118)
        Me.lbl100.Name = "lbl100"
        Me.lbl100.Size = New System.Drawing.Size(81, 13)
        Me.lbl100.TabIndex = 1018
        Me.lbl100.Text = "Purchase Date:"
        '
        'TxtPurchaseInvoiceNo
        '
        Me.TxtPurchaseInvoiceNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPurchaseInvoiceNo.Location = New System.Drawing.Point(949, 87)
        Me.TxtPurchaseInvoiceNo.Name = "TxtPurchaseInvoiceNo"
        Me.TxtPurchaseInvoiceNo.ReadOnly = True
        Me.TxtPurchaseInvoiceNo.Size = New System.Drawing.Size(213, 20)
        Me.TxtPurchaseInvoiceNo.TabIndex = 1017
        '
        'TxtVat
        '
        Me.TxtVat.Location = New System.Drawing.Point(132, 115)
        Me.TxtVat.Name = "TxtVat"
        Me.TxtVat.Size = New System.Drawing.Size(100, 20)
        Me.TxtVat.TabIndex = 109
        '
        'DtpPurchaseDate
        '
        Me.DtpPurchaseDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtpPurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpPurchaseDate.Location = New System.Drawing.Point(949, 115)
        Me.DtpPurchaseDate.Name = "DtpPurchaseDate"
        Me.DtpPurchaseDate.Size = New System.Drawing.Size(129, 20)
        Me.DtpPurchaseDate.TabIndex = 1016
        Me.DtpPurchaseDate.Value = New Date(2017, 8, 5, 0, 0, 0, 0)
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Btnsave)
        Me.GroupBox1.Controls.Add(Me.BtnAddNew)
        Me.GroupBox1.Controls.Add(Me.BtnInvoice)
        Me.GroupBox1.Location = New System.Drawing.Point(912, 644)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(251, 80)
        Me.GroupBox1.TabIndex = 1015
        Me.GroupBox1.TabStop = False
        '
        'Btnsave
        '
        Me.Btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnsave.Image = Global.Business_Expert_Pro.My.Resources.Resources.Save_32px_32
        Me.Btnsave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btnsave.Location = New System.Drawing.Point(89, 12)
        Me.Btnsave.Name = "Btnsave"
        Me.Btnsave.Size = New System.Drawing.Size(78, 61)
        Me.Btnsave.TabIndex = 2010
        Me.Btnsave.Text = "Save"
        Me.Btnsave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btnsave.UseVisualStyleBackColor = True
        '
        'BtnAddNew
        '
        Me.BtnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddNew.Image = Global.Business_Expert_Pro.My.Resources.Resources.Print
        Me.BtnAddNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAddNew.Location = New System.Drawing.Point(11, 12)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(78, 61)
        Me.BtnAddNew.TabIndex = 2008
        Me.BtnAddNew.Text = "Pint"
        Me.BtnAddNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'BtnInvoice
        '
        Me.BtnInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInvoice.Image = Global.Business_Expert_Pro.My.Resources.Resources.Last_view1
        Me.BtnInvoice.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnInvoice.Location = New System.Drawing.Point(167, 12)
        Me.BtnInvoice.Name = "BtnInvoice"
        Me.BtnInvoice.Size = New System.Drawing.Size(78, 61)
        Me.BtnInvoice.TabIndex = 2009
        Me.BtnInvoice.Text = "Last Invoice"
        Me.BtnInvoice.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnInvoice.UseVisualStyleBackColor = True
        '
        'GrpSupplierInformation
        '
        Me.GrpSupplierInformation.Controls.Add(Me.TxtSupplierDiscount)
        Me.GrpSupplierInformation.Controls.Add(Me.LblSupplierDiscount)
        Me.GrpSupplierInformation.Controls.Add(Me.BtnSupplierName)
        Me.GrpSupplierInformation.Controls.Add(Me.TxtAddress)
        Me.GrpSupplierInformation.Controls.Add(Me.TxtPhoneNo)
        Me.GrpSupplierInformation.Controls.Add(Me.CmbSupplierName)
        Me.GrpSupplierInformation.Controls.Add(Me.LblAddress)
        Me.GrpSupplierInformation.Controls.Add(Me.LblPhoneNo)
        Me.GrpSupplierInformation.Controls.Add(Me.LblSupplierName)
        Me.GrpSupplierInformation.Location = New System.Drawing.Point(12, 82)
        Me.GrpSupplierInformation.Name = "GrpSupplierInformation"
        Me.GrpSupplierInformation.Size = New System.Drawing.Size(473, 153)
        Me.GrpSupplierInformation.TabIndex = 1013
        Me.GrpSupplierInformation.TabStop = False
        Me.GrpSupplierInformation.Text = "Supplier Information"
        '
        'BtnSupplierName
        '
        Me.BtnSupplierName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnSupplierName.BackgroundImage = Global.Business_Expert_Pro.My.Resources.Resources.newButton
        Me.BtnSupplierName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSupplierName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSupplierName.Location = New System.Drawing.Point(394, 24)
        Me.BtnSupplierName.Name = "BtnSupplierName"
        Me.BtnSupplierName.Size = New System.Drawing.Size(23, 22)
        Me.BtnSupplierName.TabIndex = 1
        Me.BtnSupplierName.UseVisualStyleBackColor = True
        '
        'TxtAddress
        '
        Me.TxtAddress.Location = New System.Drawing.Point(129, 92)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(203, 20)
        Me.TxtAddress.TabIndex = 103
        '
        'TxtPhoneNo
        '
        Me.TxtPhoneNo.Location = New System.Drawing.Point(129, 59)
        Me.TxtPhoneNo.Name = "TxtPhoneNo"
        Me.TxtPhoneNo.Size = New System.Drawing.Size(203, 20)
        Me.TxtPhoneNo.TabIndex = 102
        '
        'CmbSupplierName
        '
        Me.CmbSupplierName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbSupplierName.FormattingEnabled = True
        Me.CmbSupplierName.Location = New System.Drawing.Point(129, 25)
        Me.CmbSupplierName.Name = "CmbSupplierName"
        Me.CmbSupplierName.Size = New System.Drawing.Size(245, 21)
        Me.CmbSupplierName.TabIndex = 101
        '
        'LblAddress
        '
        Me.LblAddress.AutoSize = True
        Me.LblAddress.Location = New System.Drawing.Point(19, 96)
        Me.LblAddress.Name = "LblAddress"
        Me.LblAddress.Size = New System.Drawing.Size(48, 13)
        Me.LblAddress.TabIndex = 116
        Me.LblAddress.Text = "Address:"
        '
        'LblPhoneNo
        '
        Me.LblPhoneNo.AutoSize = True
        Me.LblPhoneNo.Location = New System.Drawing.Point(19, 62)
        Me.LblPhoneNo.Name = "LblPhoneNo"
        Me.LblPhoneNo.Size = New System.Drawing.Size(58, 13)
        Me.LblPhoneNo.TabIndex = 115
        Me.LblPhoneNo.Text = "Phone No:"
        '
        'LblSupplierName
        '
        Me.LblSupplierName.AutoSize = True
        Me.LblSupplierName.Location = New System.Drawing.Point(19, 28)
        Me.LblSupplierName.Name = "LblSupplierName"
        Me.LblSupplierName.Size = New System.Drawing.Size(79, 13)
        Me.LblSupplierName.TabIndex = 114
        Me.LblSupplierName.Text = "Supplier Name:"
        '
        'GrdSupplierList
        '
        Me.GrdSupplierList.AllowUserToAddRows = False
        Me.GrdSupplierList.AllowUserToDeleteRows = False
        Me.GrdSupplierList.BackgroundColor = System.Drawing.Color.White
        Me.GrdSupplierList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdSupplierList.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GrdSupplierList.Location = New System.Drawing.Point(141, 127)
        Me.GrdSupplierList.Name = "GrdSupplierList"
        Me.GrdSupplierList.ReadOnly = True
        Me.GrdSupplierList.Size = New System.Drawing.Size(245, 10)
        Me.GrdSupplierList.TabIndex = 2056
        Me.GrdSupplierList.Visible = False
        '
        'TxtDiscount
        '
        Me.TxtDiscount.Location = New System.Drawing.Point(132, 145)
        Me.TxtDiscount.Name = "TxtDiscount"
        Me.TxtDiscount.Size = New System.Drawing.Size(100, 20)
        Me.TxtDiscount.TabIndex = 111
        '
        'GrpPaymentInfo
        '
        Me.GrpPaymentInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpPaymentInfo.Controls.Add(Me.Label16)
        Me.GrpPaymentInfo.Controls.Add(Me.Label15)
        Me.GrpPaymentInfo.Controls.Add(Me.CmbPaidBy)
        Me.GrpPaymentInfo.Controls.Add(Me.LblPaidBy)
        Me.GrpPaymentInfo.Controls.Add(Me.Label2)
        Me.GrpPaymentInfo.Controls.Add(Me.TxtVat)
        Me.GrpPaymentInfo.Controls.Add(Me.TxtDiscount)
        Me.GrpPaymentInfo.Controls.Add(Me.TxtNetPayable)
        Me.GrpPaymentInfo.Controls.Add(Me.TxtPaidAmount)
        Me.GrpPaymentInfo.Controls.Add(Me.TxtReturnAmount)
        Me.GrpPaymentInfo.Controls.Add(Me.LblReturnAmount)
        Me.GrpPaymentInfo.Controls.Add(Me.TxtBalance)
        Me.GrpPaymentInfo.Controls.Add(Me.TxtDiscountPercentage)
        Me.GrpPaymentInfo.Controls.Add(Me.TxtTotal)
        Me.GrpPaymentInfo.Controls.Add(Me.TxtVatPercentage)
        Me.GrpPaymentInfo.Controls.Add(Me.TxtPreviousDues)
        Me.GrpPaymentInfo.Controls.Add(Me.TxtAdvance)
        Me.GrpPaymentInfo.Controls.Add(Me.LblBalance)
        Me.GrpPaymentInfo.Controls.Add(Me.LblPaidAmount)
        Me.GrpPaymentInfo.Controls.Add(Me.LblNetPayable)
        Me.GrpPaymentInfo.Controls.Add(Me.LblDiscount)
        Me.GrpPaymentInfo.Controls.Add(Me.Label1)
        Me.GrpPaymentInfo.Controls.Add(Me.LblVat)
        Me.GrpPaymentInfo.Controls.Add(Me.LblAdvance)
        Me.GrpPaymentInfo.Controls.Add(Me.LblPreviousDues)
        Me.GrpPaymentInfo.Controls.Add(Me.LblTotal)
        Me.GrpPaymentInfo.Location = New System.Drawing.Point(912, 288)
        Me.GrpPaymentInfo.Name = "GrpPaymentInfo"
        Me.GrpPaymentInfo.Size = New System.Drawing.Size(251, 350)
        Me.GrpPaymentInfo.TabIndex = 1014
        Me.GrpPaymentInfo.TabStop = False
        Me.GrpPaymentInfo.Text = "Payment Information"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(110, 212)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(20, 25)
        Me.Label16.TabIndex = 2012
        Me.Label16.Text = "*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(64, 278)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(20, 25)
        Me.Label15.TabIndex = 2011
        Me.Label15.Text = "*"
        '
        'CmbPaidBy
        '
        Me.CmbPaidBy.FormattingEnabled = True
        Me.CmbPaidBy.Location = New System.Drawing.Point(132, 282)
        Me.CmbPaidBy.Name = "CmbPaidBy"
        Me.CmbPaidBy.Size = New System.Drawing.Size(100, 21)
        Me.CmbPaidBy.TabIndex = 155
        '
        'TxtNetPayable
        '
        Me.TxtNetPayable.Location = New System.Drawing.Point(132, 177)
        Me.TxtNetPayable.Name = "TxtNetPayable"
        Me.TxtNetPayable.ReadOnly = True
        Me.TxtNetPayable.Size = New System.Drawing.Size(100, 20)
        Me.TxtNetPayable.TabIndex = 112
        '
        'TxtPaidAmount
        '
        Me.TxtPaidAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TxtPaidAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.TxtPaidAmount.ForeColor = System.Drawing.Color.White
        Me.TxtPaidAmount.Location = New System.Drawing.Point(132, 212)
        Me.TxtPaidAmount.Name = "TxtPaidAmount"
        Me.TxtPaidAmount.Size = New System.Drawing.Size(100, 24)
        Me.TxtPaidAmount.TabIndex = 113
        '
        'TxtReturnAmount
        '
        Me.TxtReturnAmount.BackColor = System.Drawing.Color.OrangeRed
        Me.TxtReturnAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.TxtReturnAmount.ForeColor = System.Drawing.Color.White
        Me.TxtReturnAmount.Location = New System.Drawing.Point(132, 314)
        Me.TxtReturnAmount.Name = "TxtReturnAmount"
        Me.TxtReturnAmount.ReadOnly = True
        Me.TxtReturnAmount.Size = New System.Drawing.Size(100, 24)
        Me.TxtReturnAmount.TabIndex = 116
        '
        'LblReturnAmount
        '
        Me.LblReturnAmount.AutoSize = True
        Me.LblReturnAmount.Location = New System.Drawing.Point(8, 314)
        Me.LblReturnAmount.Name = "LblReturnAmount"
        Me.LblReturnAmount.Size = New System.Drawing.Size(81, 13)
        Me.LblReturnAmount.TabIndex = 135
        Me.LblReturnAmount.Text = "Return Amount:"
        '
        'TxtBalance
        '
        Me.TxtBalance.BackColor = System.Drawing.Color.White
        Me.TxtBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBalance.ForeColor = System.Drawing.Color.Black
        Me.TxtBalance.Location = New System.Drawing.Point(132, 247)
        Me.TxtBalance.Name = "TxtBalance"
        Me.TxtBalance.ReadOnly = True
        Me.TxtBalance.Size = New System.Drawing.Size(100, 24)
        Me.TxtBalance.TabIndex = 114
        '
        'TxtDiscountPercentage
        '
        Me.TxtDiscountPercentage.Location = New System.Drawing.Point(69, 145)
        Me.TxtDiscountPercentage.Name = "TxtDiscountPercentage"
        Me.TxtDiscountPercentage.Size = New System.Drawing.Size(23, 20)
        Me.TxtDiscountPercentage.TabIndex = 110
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(132, 22)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(100, 20)
        Me.TxtTotal.TabIndex = 105
        '
        'TxtVatPercentage
        '
        Me.TxtVatPercentage.Location = New System.Drawing.Point(45, 112)
        Me.TxtVatPercentage.Name = "TxtVatPercentage"
        Me.TxtVatPercentage.Size = New System.Drawing.Size(23, 20)
        Me.TxtVatPercentage.TabIndex = 108
        '
        'TxtPreviousDues
        '
        Me.TxtPreviousDues.Location = New System.Drawing.Point(132, 53)
        Me.TxtPreviousDues.Name = "TxtPreviousDues"
        Me.TxtPreviousDues.ReadOnly = True
        Me.TxtPreviousDues.Size = New System.Drawing.Size(100, 20)
        Me.TxtPreviousDues.TabIndex = 106
        '
        'TxtAdvance
        '
        Me.TxtAdvance.Location = New System.Drawing.Point(132, 85)
        Me.TxtAdvance.Name = "TxtAdvance"
        Me.TxtAdvance.ReadOnly = True
        Me.TxtAdvance.Size = New System.Drawing.Size(100, 20)
        Me.TxtAdvance.TabIndex = 107
        '
        'LblBalance
        '
        Me.LblBalance.AutoSize = True
        Me.LblBalance.Location = New System.Drawing.Point(8, 248)
        Me.LblBalance.Name = "LblBalance"
        Me.LblBalance.Size = New System.Drawing.Size(49, 13)
        Me.LblBalance.TabIndex = 136
        Me.LblBalance.Text = "Balance:"
        '
        'LblPaidAmount
        '
        Me.LblPaidAmount.AutoSize = True
        Me.LblPaidAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPaidAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblPaidAmount.Location = New System.Drawing.Point(8, 212)
        Me.LblPaidAmount.Name = "LblPaidAmount"
        Me.LblPaidAmount.Size = New System.Drawing.Size(103, 16)
        Me.LblPaidAmount.TabIndex = 134
        Me.LblPaidAmount.Text = "Paid Amount :"
        '
        'LblNetPayable
        '
        Me.LblNetPayable.AutoSize = True
        Me.LblNetPayable.Location = New System.Drawing.Point(13, 177)
        Me.LblNetPayable.Name = "LblNetPayable"
        Me.LblNetPayable.Size = New System.Drawing.Size(68, 13)
        Me.LblNetPayable.TabIndex = 133
        Me.LblNetPayable.Text = "Net Payable:"
        '
        'LblDiscount
        '
        Me.LblDiscount.AutoSize = True
        Me.LblDiscount.Location = New System.Drawing.Point(13, 145)
        Me.LblDiscount.Name = "LblDiscount"
        Me.LblDiscount.Size = New System.Drawing.Size(52, 13)
        Me.LblDiscount.TabIndex = 132
        Me.LblDiscount.Text = "Discount:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 13)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "%"
        '
        'LblVat
        '
        Me.LblVat.AutoSize = True
        Me.LblVat.Location = New System.Drawing.Point(13, 115)
        Me.LblVat.Name = "LblVat"
        Me.LblVat.Size = New System.Drawing.Size(26, 13)
        Me.LblVat.TabIndex = 131
        Me.LblVat.Text = "Vat:"
        '
        'LblAdvance
        '
        Me.LblAdvance.AutoSize = True
        Me.LblAdvance.Location = New System.Drawing.Point(13, 85)
        Me.LblAdvance.Name = "LblAdvance"
        Me.LblAdvance.Size = New System.Drawing.Size(53, 13)
        Me.LblAdvance.TabIndex = 130
        Me.LblAdvance.Text = "Advance:"
        '
        'LblPreviousDues
        '
        Me.LblPreviousDues.AutoSize = True
        Me.LblPreviousDues.Location = New System.Drawing.Point(13, 53)
        Me.LblPreviousDues.Name = "LblPreviousDues"
        Me.LblPreviousDues.Size = New System.Drawing.Size(79, 13)
        Me.LblPreviousDues.TabIndex = 129
        Me.LblPreviousDues.Text = "Previous Dues:"
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(13, 22)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(34, 13)
        Me.LblTotal.TabIndex = 128
        Me.LblTotal.Text = "Total:"
        '
        'PnlPurchase
        '
        Me.PnlPurchase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlPurchase.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlPurchase.Controls.Add(Me.Panel1)
        Me.PnlPurchase.Controls.Add(Me.LblPurchase)
        Me.PnlPurchase.Location = New System.Drawing.Point(1, 0)
        Me.PnlPurchase.Name = "PnlPurchase"
        Me.PnlPurchase.Size = New System.Drawing.Size(1182, 81)
        Me.PnlPurchase.TabIndex = 1009
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
        Me.Panel1.Size = New System.Drawing.Size(1182, 28)
        Me.Panel1.TabIndex = 2052
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(1158, 0)
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
        Me.Btnminimized.Location = New System.Drawing.Point(1098, 0)
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
        Me.Btnmaximized.Location = New System.Drawing.Point(1128, 0)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1160
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'LblPurchase
        '
        Me.LblPurchase.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblPurchase.AutoSize = True
        Me.LblPurchase.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPurchase.ForeColor = System.Drawing.Color.White
        Me.LblPurchase.Location = New System.Drawing.Point(509, 31)
        Me.LblPurchase.Name = "LblPurchase"
        Me.LblPurchase.Size = New System.Drawing.Size(160, 37)
        Me.LblPurchase.TabIndex = 0
        Me.LblPurchase.Text = "Purchase"
        '
        'LblSearchBarcode
        '
        Me.LblSearchBarcode.AutoSize = True
        Me.LblSearchBarcode.Location = New System.Drawing.Point(31, 249)
        Me.LblSearchBarcode.Name = "LblSearchBarcode"
        Me.LblSearchBarcode.Size = New System.Drawing.Size(87, 13)
        Me.LblSearchBarcode.TabIndex = 1020
        Me.LblSearchBarcode.Text = "Search Barcode:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(91, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 1020
        Me.Label3.Text = "Product Name:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(320, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 1023
        Me.Label4.Text = "Location:"
        '
        'TxtQuantity
        '
        Me.TxtQuantity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtQuantity.Location = New System.Drawing.Point(415, 34)
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.Size = New System.Drawing.Size(48, 20)
        Me.TxtQuantity.TabIndex = 103
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(415, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 1025
        Me.Label5.Text = "Quantity:"
        '
        'TxtPurchaseUnitCost
        '
        Me.TxtPurchaseUnitCost.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPurchaseUnitCost.Location = New System.Drawing.Point(698, 34)
        Me.TxtPurchaseUnitCost.Name = "TxtPurchaseUnitCost"
        Me.TxtPurchaseUnitCost.Size = New System.Drawing.Size(71, 20)
        Me.TxtPurchaseUnitCost.TabIndex = 106
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(707, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 1027
        Me.Label6.Text = "Unit Cost:"
        '
        'TxtPurchaseAmount
        '
        Me.TxtPurchaseAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPurchaseAmount.Location = New System.Drawing.Point(776, 34)
        Me.TxtPurchaseAmount.Name = "TxtPurchaseAmount"
        Me.TxtPurchaseAmount.Size = New System.Drawing.Size(100, 20)
        Me.TxtPurchaseAmount.TabIndex = 107
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(779, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 13)
        Me.Label7.TabIndex = 1029
        Me.Label7.Text = "Purchase Amount:"
        '
        'CmbProductName
        '
        Me.CmbProductName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbProductName.FormattingEnabled = True
        Me.CmbProductName.Location = New System.Drawing.Point(7, 34)
        Me.CmbProductName.Name = "CmbProductName"
        Me.CmbProductName.Size = New System.Drawing.Size(246, 21)
        Me.CmbProductName.TabIndex = 101
        '
        'CmbLocationID
        '
        Me.CmbLocationID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbLocationID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbLocationID.FormattingEnabled = True
        Me.CmbLocationID.Location = New System.Drawing.Point(285, 34)
        Me.CmbLocationID.Name = "CmbLocationID"
        Me.CmbLocationID.Size = New System.Drawing.Size(121, 20)
        Me.CmbLocationID.TabIndex = 102
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(860, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 1018
        Me.Label8.Text = "Invoice No:"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 708)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 1033
        Me.Label9.Text = "Purchase ID:"
        '
        'LblPurchaseID
        '
        Me.LblPurchaseID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblPurchaseID.AutoSize = True
        Me.LblPurchaseID.Location = New System.Drawing.Point(91, 708)
        Me.LblPurchaseID.Name = "LblPurchaseID"
        Me.LblPurchaseID.Size = New System.Drawing.Size(19, 13)
        Me.LblPurchaseID.TabIndex = 1033
        Me.LblPurchaseID.Text = "00"
        '
        'GrpAmount
        '
        Me.GrpAmount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpAmount.Controls.Add(Me.Button4)
        Me.GrpAmount.Controls.Add(Me.TxtWarrantyDays)
        Me.GrpAmount.Controls.Add(Me.LblWarrantyDays)
        Me.GrpAmount.Controls.Add(Me.TxtFromSerial)
        Me.GrpAmount.Controls.Add(Me.TxtToSerial)
        Me.GrpAmount.Controls.Add(Me.RdbRangeSerial)
        Me.GrpAmount.Controls.Add(Me.LblTo)
        Me.GrpAmount.Controls.Add(Me.LblFrom)
        Me.GrpAmount.Controls.Add(Me.TxtSerialNumber)
        Me.GrpAmount.Controls.Add(Me.LblSerialNumber)
        Me.GrpAmount.Controls.Add(Me.CmbLocationID)
        Me.GrpAmount.Controls.Add(Me.CmbProductName)
        Me.GrpAmount.Controls.Add(Me.TxtPurchaseAmount)
        Me.GrpAmount.Controls.Add(Me.Label7)
        Me.GrpAmount.Controls.Add(Me.TxtPurchaseUnitCost)
        Me.GrpAmount.Controls.Add(Me.Label6)
        Me.GrpAmount.Controls.Add(Me.Label4)
        Me.GrpAmount.Controls.Add(Me.TxtQuantity)
        Me.GrpAmount.Controls.Add(Me.Label5)
        Me.GrpAmount.Controls.Add(Me.Label3)
        Me.GrpAmount.Location = New System.Drawing.Point(12, 278)
        Me.GrpAmount.Name = "GrpAmount"
        Me.GrpAmount.Size = New System.Drawing.Size(889, 101)
        Me.GrpAmount.TabIndex = 2031
        Me.GrpAmount.TabStop = False
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackgroundImage = Global.Business_Expert_Pro.My.Resources.Resources.newButton
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(259, 32)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(20, 20)
        Me.Button4.TabIndex = 2058
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TxtWarrantyDays
        '
        Me.TxtWarrantyDays.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtWarrantyDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtWarrantyDays.Location = New System.Drawing.Point(605, 34)
        Me.TxtWarrantyDays.Name = "TxtWarrantyDays"
        Me.TxtWarrantyDays.Size = New System.Drawing.Size(87, 22)
        Me.TxtWarrantyDays.TabIndex = 105
        '
        'LblWarrantyDays
        '
        Me.LblWarrantyDays.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblWarrantyDays.AutoSize = True
        Me.LblWarrantyDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWarrantyDays.Location = New System.Drawing.Point(608, 18)
        Me.LblWarrantyDays.Name = "LblWarrantyDays"
        Me.LblWarrantyDays.Size = New System.Drawing.Size(80, 13)
        Me.LblWarrantyDays.TabIndex = 2050
        Me.LblWarrantyDays.Text = "Warranty Days:"
        '
        'TxtFromSerial
        '
        Me.TxtFromSerial.Enabled = False
        Me.TxtFromSerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFromSerial.Location = New System.Drawing.Point(149, 68)
        Me.TxtFromSerial.Name = "TxtFromSerial"
        Me.TxtFromSerial.Size = New System.Drawing.Size(124, 22)
        Me.TxtFromSerial.TabIndex = 108
        '
        'TxtToSerial
        '
        Me.TxtToSerial.Enabled = False
        Me.TxtToSerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtToSerial.Location = New System.Drawing.Point(320, 69)
        Me.TxtToSerial.Name = "TxtToSerial"
        Me.TxtToSerial.Size = New System.Drawing.Size(124, 22)
        Me.TxtToSerial.TabIndex = 109
        '
        'RdbRangeSerial
        '
        Me.RdbRangeSerial.AutoSize = True
        Me.RdbRangeSerial.Location = New System.Drawing.Point(12, 71)
        Me.RdbRangeSerial.Name = "RdbRangeSerial"
        Me.RdbRangeSerial.Size = New System.Drawing.Size(86, 17)
        Me.RdbRangeSerial.TabIndex = 107
        Me.RdbRangeSerial.TabStop = True
        Me.RdbRangeSerial.Text = "Range Serial"
        Me.RdbRangeSerial.UseVisualStyleBackColor = True
        '
        'LblTo
        '
        Me.LblTo.AutoSize = True
        Me.LblTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTo.Location = New System.Drawing.Point(282, 72)
        Me.LblTo.Name = "LblTo"
        Me.LblTo.Size = New System.Drawing.Size(27, 15)
        Me.LblTo.TabIndex = 2049
        Me.LblTo.Text = "To:"
        '
        'LblFrom
        '
        Me.LblFrom.AutoSize = True
        Me.LblFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFrom.Location = New System.Drawing.Point(100, 71)
        Me.LblFrom.Name = "LblFrom"
        Me.LblFrom.Size = New System.Drawing.Size(44, 15)
        Me.LblFrom.TabIndex = 2048
        Me.LblFrom.Text = "From:"
        '
        'TxtSerialNumber
        '
        Me.TxtSerialNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSerialNumber.Location = New System.Drawing.Point(470, 34)
        Me.TxtSerialNumber.Name = "TxtSerialNumber"
        Me.TxtSerialNumber.Size = New System.Drawing.Size(128, 20)
        Me.TxtSerialNumber.TabIndex = 104
        '
        'LblSerialNumber
        '
        Me.LblSerialNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblSerialNumber.AutoSize = True
        Me.LblSerialNumber.Location = New System.Drawing.Point(498, 18)
        Me.LblSerialNumber.Name = "LblSerialNumber"
        Me.LblSerialNumber.Size = New System.Drawing.Size(73, 13)
        Me.LblSerialNumber.TabIndex = 1031
        Me.LblSerialNumber.Text = "Serial Number"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(244, 708)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(166, 16)
        Me.Label11.TabIndex = 2033
        Me.Label11.Text = "For Billing : Ctrl+Space"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(606, 708)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(121, 16)
        Me.Label12.TabIndex = 2032
        Me.Label12.Text = "Delete : Click 2X"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(138, 708)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 16)
        Me.Label13.TabIndex = 2035
        Me.Label13.Text = "Clear : F2"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(416, 708)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(175, 16)
        Me.Label14.TabIndex = 2034
        Me.Label14.Text = "Add New Product : Enter"
        '
        'BtnDelete
        '
        Me.BtnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.Location = New System.Drawing.Point(803, 249)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(98, 26)
        Me.BtnDelete.TabIndex = 2036
        Me.BtnDelete.Text = "Delete Invoice"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(699, 249)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 26)
        Me.Button1.TabIndex = 2037
        Me.Button1.Text = "History"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(595, 249)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(98, 26)
        Me.Button3.TabIndex = 2039
        Me.Button3.Text = "New Invoice"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(860, 147)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 2046
        Me.Label10.Text = "Memo No:"
        '
        'TxtMemoNo
        '
        Me.TxtMemoNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMemoNo.Location = New System.Drawing.Point(949, 144)
        Me.TxtMemoNo.Name = "TxtMemoNo"
        Me.TxtMemoNo.Size = New System.Drawing.Size(213, 20)
        Me.TxtMemoNo.TabIndex = 2045
        '
        'GrdAvailableSerialNumber
        '
        Me.GrdAvailableSerialNumber.AllowUserToAddRows = False
        Me.GrdAvailableSerialNumber.AllowUserToDeleteRows = False
        Me.GrdAvailableSerialNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GrdAvailableSerialNumber.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdAvailableSerialNumber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdAvailableSerialNumber.Location = New System.Drawing.Point(13, 399)
        Me.GrdAvailableSerialNumber.Name = "GrdAvailableSerialNumber"
        Me.GrdAvailableSerialNumber.ReadOnly = True
        Me.GrdAvailableSerialNumber.Size = New System.Drawing.Size(205, 306)
        Me.GrdAvailableSerialNumber.TabIndex = 2047
        '
        'GrdPurchase
        '
        Me.GrdPurchase.AllowUserToAddRows = False
        Me.GrdPurchase.AllowUserToDeleteRows = False
        Me.GrdPurchase.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdPurchase.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdPurchase.Location = New System.Drawing.Point(224, 399)
        Me.GrdPurchase.Name = "GrdPurchase"
        Me.GrdPurchase.ReadOnly = True
        Me.GrdPurchase.Size = New System.Drawing.Size(677, 306)
        Me.GrdPurchase.TabIndex = 2048
        '
        'GrdProductList
        '
        Me.GrdProductList.AllowUserToAddRows = False
        Me.GrdProductList.AllowUserToDeleteRows = False
        Me.GrdProductList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdProductList.BackgroundColor = System.Drawing.Color.White
        Me.GrdProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdProductList.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GrdProductList.Location = New System.Drawing.Point(19, 333)
        Me.GrdProductList.Name = "GrdProductList"
        Me.GrdProductList.ReadOnly = True
        Me.GrdProductList.Size = New System.Drawing.Size(246, 13)
        Me.GrdProductList.TabIndex = 2056
        Me.GrdProductList.Visible = False
        '
        'GrdLocationList
        '
        Me.GrdLocationList.AllowUserToAddRows = False
        Me.GrdLocationList.AllowUserToDeleteRows = False
        Me.GrdLocationList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdLocationList.BackgroundColor = System.Drawing.Color.White
        Me.GrdLocationList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdLocationList.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GrdLocationList.Location = New System.Drawing.Point(298, 333)
        Me.GrdLocationList.Name = "GrdLocationList"
        Me.GrdLocationList.ReadOnly = True
        Me.GrdLocationList.Size = New System.Drawing.Size(121, 13)
        Me.GrdLocationList.TabIndex = 2057
        Me.GrdLocationList.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Indigo
        Me.Panel2.Location = New System.Drawing.Point(12, 387)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(889, 10)
        Me.Panel2.TabIndex = 2059
        '
        'FrmPurchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 730)
        Me.Controls.Add(Me.GrdLocationList)
        Me.Controls.Add(Me.GrdProductList)
        Me.Controls.Add(Me.GrdSupplierList)
        Me.Controls.Add(Me.GrdPurchase)
        Me.Controls.Add(Me.GrdAvailableSerialNumber)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtMemoNo)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GrpAmount)
        Me.Controls.Add(Me.LblPurchaseID)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtSearchBarcode)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbl100)
        Me.Controls.Add(Me.TxtPurchaseInvoiceNo)
        Me.Controls.Add(Me.DtpPurchaseDate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GrpSupplierInformation)
        Me.Controls.Add(Me.GrpPaymentInfo)
        Me.Controls.Add(Me.PnlPurchase)
        Me.Controls.Add(Me.LblSearchBarcode)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPurchase"
        Me.Text = "Purchase"
        Me.GroupBox1.ResumeLayout(False)
        Me.GrpSupplierInformation.ResumeLayout(False)
        Me.GrpSupplierInformation.PerformLayout()
        CType(Me.GrdSupplierList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpPaymentInfo.ResumeLayout(False)
        Me.GrpPaymentInfo.PerformLayout()
        Me.PnlPurchase.ResumeLayout(False)
        Me.PnlPurchase.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GrpAmount.ResumeLayout(False)
        Me.GrpAmount.PerformLayout()
        CType(Me.GrdAvailableSerialNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdPurchase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdProductList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdLocationList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblSupplierDiscount As System.Windows.Forms.Label
    Friend WithEvents TxtSupplierDiscount As System.Windows.Forms.TextBox
    Friend WithEvents LblPaidBy As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtSearchBarcode As System.Windows.Forms.TextBox
    Friend WithEvents lbl100 As System.Windows.Forms.Label
    Friend WithEvents TxtPurchaseInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtVat As System.Windows.Forms.TextBox
    Friend WithEvents DtpPurchaseDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Btnsave As System.Windows.Forms.Button
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
    Friend WithEvents BtnInvoice As System.Windows.Forms.Button
    Friend WithEvents GrpSupplierInformation As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSupplierName As System.Windows.Forms.Button
    Friend WithEvents TxtAddress As System.Windows.Forms.TextBox
    Friend WithEvents TxtPhoneNo As System.Windows.Forms.TextBox
    Friend WithEvents CmbSupplierName As System.Windows.Forms.ComboBox
    Friend WithEvents LblAddress As System.Windows.Forms.Label
    Friend WithEvents LblPhoneNo As System.Windows.Forms.Label
    Friend WithEvents LblSupplierName As System.Windows.Forms.Label
    Friend WithEvents TxtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents GrpPaymentInfo As System.Windows.Forms.GroupBox
    Friend WithEvents TxtNetPayable As System.Windows.Forms.TextBox
    Friend WithEvents TxtPaidAmount As System.Windows.Forms.TextBox
    Friend WithEvents TxtReturnAmount As System.Windows.Forms.TextBox
    Friend WithEvents LblReturnAmount As System.Windows.Forms.Label
    Friend WithEvents TxtBalance As System.Windows.Forms.TextBox
    Friend WithEvents TxtDiscountPercentage As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents TxtVatPercentage As System.Windows.Forms.TextBox
    Friend WithEvents TxtPreviousDues As System.Windows.Forms.TextBox
    Friend WithEvents TxtAdvance As System.Windows.Forms.TextBox
    Friend WithEvents LblBalance As System.Windows.Forms.Label
    Friend WithEvents LblPaidAmount As System.Windows.Forms.Label
    Friend WithEvents LblNetPayable As System.Windows.Forms.Label
    Friend WithEvents LblDiscount As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblVat As System.Windows.Forms.Label
    Friend WithEvents LblAdvance As System.Windows.Forms.Label
    Friend WithEvents LblPreviousDues As System.Windows.Forms.Label
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents PnlPurchase As System.Windows.Forms.Panel
    Friend WithEvents LblPurchase As System.Windows.Forms.Label
    Friend WithEvents LblSearchBarcode As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtPurchaseUnitCost As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtPurchaseAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CmbProductName As System.Windows.Forms.ComboBox
    Friend WithEvents CmbLocationID As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LblPurchaseID As System.Windows.Forms.Label
    Friend WithEvents GrpAmount As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents CmbPaidBy As System.Windows.Forms.ComboBox
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TxtSerialNumber As System.Windows.Forms.TextBox
    Friend WithEvents LblSerialNumber As System.Windows.Forms.Label
    Friend WithEvents TxtFromSerial As System.Windows.Forms.TextBox
    Friend WithEvents TxtToSerial As System.Windows.Forms.TextBox
    Friend WithEvents RdbRangeSerial As System.Windows.Forms.RadioButton
    Friend WithEvents LblTo As System.Windows.Forms.Label
    Friend WithEvents LblFrom As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtMemoNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtWarrantyDays As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
    Friend WithEvents GrdAvailableSerialNumber As System.Windows.Forms.DataGridView
    Friend WithEvents GrdPurchase As System.Windows.Forms.DataGridView
    Friend WithEvents GrdSupplierList As System.Windows.Forms.DataGridView
    Friend WithEvents GrdProductList As System.Windows.Forms.DataGridView
    Friend WithEvents GrdLocationList As System.Windows.Forms.DataGridView
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents LblWarrantyDays As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
