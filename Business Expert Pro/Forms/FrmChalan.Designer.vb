<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChalan
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
        Me.PnlChalan = New System.Windows.Forms.Panel
        Me.LblChalan = New System.Windows.Forms.Label
        Me.LblCustomerName = New System.Windows.Forms.Label
        Me.LblPhoneNo = New System.Windows.Forms.Label
        Me.LblAddress = New System.Windows.Forms.Label
        Me.CmbCustomerName = New System.Windows.Forms.ComboBox
        Me.TxtPhoneNo = New System.Windows.Forms.TextBox
        Me.TxtAddress = New System.Windows.Forms.TextBox
        Me.LblVat = New System.Windows.Forms.Label
        Me.LblDiscount = New System.Windows.Forms.Label
        Me.LblNetPayable = New System.Windows.Forms.Label
        Me.LbTotalAmount = New System.Windows.Forms.Label
        Me.TxtVatPercentage = New System.Windows.Forms.TextBox
        Me.TxtTotal = New System.Windows.Forms.TextBox
        Me.TxtDiscountPercentage = New System.Windows.Forms.TextBox
        Me.TxtTotalAmount = New System.Windows.Forms.TextBox
        Me.TxtNetPayable = New System.Windows.Forms.TextBox
        Me.TxtDiscount = New System.Windows.Forms.TextBox
        Me.TxtVat = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GrpCustomerInformation = New System.Windows.Forms.GroupBox
        Me.TxtCustomerDiscount = New System.Windows.Forms.TextBox
        Me.LblCustomerDiscount = New System.Windows.Forms.Label
        Me.BtnCustomerName = New System.Windows.Forms.Button
        Me.GrdSale = New System.Windows.Forms.DataGridView
        Me.LblTotal = New System.Windows.Forms.Label
        Me.GrpPaymentInformation = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.BtnInvoice = New System.Windows.Forms.Button
        Me.DtpChalanDate = New System.Windows.Forms.DateTimePicker
        Me.TxtChalanInvoiceNo = New System.Windows.Forms.TextBox
        Me.lblInvoiceNo = New System.Windows.Forms.Label
        Me.TxtSearchBarcode = New System.Windows.Forms.TextBox
        Me.LblSearchBarcode = New System.Windows.Forms.Label
        Me.cmbProductName = New System.Windows.Forms.ComboBox
        Me.TxtChalanAmount = New System.Windows.Forms.TextBox
        Me.TxtChalanUnitPrice = New System.Windows.Forms.TextBox
        Me.TxtQuantity = New System.Windows.Forms.TextBox
        Me.LblChalanAmount = New System.Windows.Forms.Label
        Me.LblChalanUnitPrice = New System.Windows.Forms.Label
        Me.LblQuantitylbl = New System.Windows.Forms.Label
        Me.LblProductName = New System.Windows.Forms.Label
        Me.LblSelectProduct = New System.Windows.Forms.GroupBox
        Me.TxtPurchaseID = New System.Windows.Forms.TextBox
        Me.LblPurchaseID = New System.Windows.Forms.Label
        Me.lblQuantity = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblChalanID = New System.Windows.Forms.Label
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.lblChalanDate = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.BtnChalanHistory = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.PnlChalan.SuspendLayout()
        Me.GrpCustomerInformation.SuspendLayout()
        CType(Me.GrdSale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpPaymentInformation.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.LblSelectProduct.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlChalan
        '
        Me.PnlChalan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlChalan.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PnlChalan.Controls.Add(Me.LblChalan)
        Me.PnlChalan.Location = New System.Drawing.Point(1, 0)
        Me.PnlChalan.Name = "PnlChalan"
        Me.PnlChalan.Size = New System.Drawing.Size(1006, 61)
        Me.PnlChalan.TabIndex = 113
        '
        'LblChalan
        '
        Me.LblChalan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblChalan.AutoSize = True
        Me.LblChalan.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblChalan.ForeColor = System.Drawing.Color.White
        Me.LblChalan.Location = New System.Drawing.Point(461, 12)
        Me.LblChalan.Name = "LblChalan"
        Me.LblChalan.Size = New System.Drawing.Size(125, 37)
        Me.LblChalan.TabIndex = 0
        Me.LblChalan.Text = "Chalan"
        '
        'LblCustomerName
        '
        Me.LblCustomerName.AutoSize = True
        Me.LblCustomerName.Location = New System.Drawing.Point(19, 28)
        Me.LblCustomerName.Name = "LblCustomerName"
        Me.LblCustomerName.Size = New System.Drawing.Size(85, 13)
        Me.LblCustomerName.TabIndex = 114
        Me.LblCustomerName.Text = "Customer Name:"
        '
        'LblPhoneNo
        '
        Me.LblPhoneNo.AutoSize = True
        Me.LblPhoneNo.Location = New System.Drawing.Point(19, 59)
        Me.LblPhoneNo.Name = "LblPhoneNo"
        Me.LblPhoneNo.Size = New System.Drawing.Size(58, 13)
        Me.LblPhoneNo.TabIndex = 115
        Me.LblPhoneNo.Text = "Phone No:"
        '
        'LblAddress
        '
        Me.LblAddress.AutoSize = True
        Me.LblAddress.Location = New System.Drawing.Point(19, 90)
        Me.LblAddress.Name = "LblAddress"
        Me.LblAddress.Size = New System.Drawing.Size(48, 13)
        Me.LblAddress.TabIndex = 116
        Me.LblAddress.Text = "Address:"
        '
        'CmbCustomerName
        '
        Me.CmbCustomerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbCustomerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.CmbCustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbCustomerName.FormattingEnabled = True
        Me.CmbCustomerName.Location = New System.Drawing.Point(129, 25)
        Me.CmbCustomerName.Name = "CmbCustomerName"
        Me.CmbCustomerName.Size = New System.Drawing.Size(245, 21)
        Me.CmbCustomerName.TabIndex = 101
        '
        'TxtPhoneNo
        '
        Me.TxtPhoneNo.Location = New System.Drawing.Point(129, 56)
        Me.TxtPhoneNo.Name = "TxtPhoneNo"
        Me.TxtPhoneNo.ReadOnly = True
        Me.TxtPhoneNo.Size = New System.Drawing.Size(203, 20)
        Me.TxtPhoneNo.TabIndex = 102
        '
        'TxtAddress
        '
        Me.TxtAddress.Location = New System.Drawing.Point(129, 86)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.ReadOnly = True
        Me.TxtAddress.Size = New System.Drawing.Size(203, 20)
        Me.TxtAddress.TabIndex = 103
        '
        'LblVat
        '
        Me.LblVat.AutoSize = True
        Me.LblVat.Location = New System.Drawing.Point(8, 59)
        Me.LblVat.Name = "LblVat"
        Me.LblVat.Size = New System.Drawing.Size(26, 13)
        Me.LblVat.TabIndex = 131
        Me.LblVat.Text = "Vat:"
        '
        'LblDiscount
        '
        Me.LblDiscount.AutoSize = True
        Me.LblDiscount.Location = New System.Drawing.Point(8, 91)
        Me.LblDiscount.Name = "LblDiscount"
        Me.LblDiscount.Size = New System.Drawing.Size(52, 13)
        Me.LblDiscount.TabIndex = 132
        Me.LblDiscount.Text = "Discount:"
        '
        'LblNetPayable
        '
        Me.LblNetPayable.AutoSize = True
        Me.LblNetPayable.Location = New System.Drawing.Point(8, 123)
        Me.LblNetPayable.Name = "LblNetPayable"
        Me.LblNetPayable.Size = New System.Drawing.Size(68, 13)
        Me.LblNetPayable.TabIndex = 133
        Me.LblNetPayable.Text = "Net Payable:"
        '
        'LbTotalAmount
        '
        Me.LbTotalAmount.AutoSize = True
        Me.LbTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTotalAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LbTotalAmount.Location = New System.Drawing.Point(8, 156)
        Me.LbTotalAmount.Name = "LbTotalAmount"
        Me.LbTotalAmount.Size = New System.Drawing.Size(103, 16)
        Me.LbTotalAmount.TabIndex = 134
        Me.LbTotalAmount.Text = "Total Amount:"
        '
        'TxtVatPercentage
        '
        Me.TxtVatPercentage.Location = New System.Drawing.Point(40, 56)
        Me.TxtVatPercentage.Name = "TxtVatPercentage"
        Me.TxtVatPercentage.Size = New System.Drawing.Size(20, 20)
        Me.TxtVatPercentage.TabIndex = 108
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(115, 21)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(125, 20)
        Me.TxtTotal.TabIndex = 105
        '
        'TxtDiscountPercentage
        '
        Me.TxtDiscountPercentage.Location = New System.Drawing.Point(60, 88)
        Me.TxtDiscountPercentage.Name = "TxtDiscountPercentage"
        Me.TxtDiscountPercentage.Size = New System.Drawing.Size(20, 20)
        Me.TxtDiscountPercentage.TabIndex = 110
        '
        'TxtTotalAmount
        '
        Me.TxtTotalAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TxtTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalAmount.ForeColor = System.Drawing.Color.White
        Me.TxtTotalAmount.Location = New System.Drawing.Point(115, 153)
        Me.TxtTotalAmount.Name = "TxtTotalAmount"
        Me.TxtTotalAmount.Size = New System.Drawing.Size(125, 24)
        Me.TxtTotalAmount.TabIndex = 113
        '
        'TxtNetPayable
        '
        Me.TxtNetPayable.Location = New System.Drawing.Point(115, 120)
        Me.TxtNetPayable.Name = "TxtNetPayable"
        Me.TxtNetPayable.ReadOnly = True
        Me.TxtNetPayable.Size = New System.Drawing.Size(125, 20)
        Me.TxtNetPayable.TabIndex = 112
        '
        'TxtDiscount
        '
        Me.TxtDiscount.Location = New System.Drawing.Point(115, 88)
        Me.TxtDiscount.Name = "TxtDiscount"
        Me.TxtDiscount.Size = New System.Drawing.Size(125, 20)
        Me.TxtDiscount.TabIndex = 111
        '
        'TxtVat
        '
        Me.TxtVat.Location = New System.Drawing.Point(115, 56)
        Me.TxtVat.Name = "TxtVat"
        Me.TxtVat.Size = New System.Drawing.Size(125, 20)
        Me.TxtVat.TabIndex = 109
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 16)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "%"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(80, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 16)
        Me.Label2.TabIndex = 151
        Me.Label2.Text = "%"
        '
        'GrpCustomerInformation
        '
        Me.GrpCustomerInformation.Controls.Add(Me.TxtCustomerDiscount)
        Me.GrpCustomerInformation.Controls.Add(Me.LblCustomerDiscount)
        Me.GrpCustomerInformation.Controls.Add(Me.BtnCustomerName)
        Me.GrpCustomerInformation.Controls.Add(Me.TxtAddress)
        Me.GrpCustomerInformation.Controls.Add(Me.TxtPhoneNo)
        Me.GrpCustomerInformation.Controls.Add(Me.CmbCustomerName)
        Me.GrpCustomerInformation.Controls.Add(Me.LblAddress)
        Me.GrpCustomerInformation.Controls.Add(Me.LblPhoneNo)
        Me.GrpCustomerInformation.Controls.Add(Me.LblCustomerName)
        Me.GrpCustomerInformation.Location = New System.Drawing.Point(12, 62)
        Me.GrpCustomerInformation.Name = "GrpCustomerInformation"
        Me.GrpCustomerInformation.Size = New System.Drawing.Size(468, 149)
        Me.GrpCustomerInformation.TabIndex = 1001
        Me.GrpCustomerInformation.TabStop = False
        Me.GrpCustomerInformation.Text = "Customer Information"
        '
        'TxtCustomerDiscount
        '
        Me.TxtCustomerDiscount.Location = New System.Drawing.Point(129, 116)
        Me.TxtCustomerDiscount.Name = "TxtCustomerDiscount"
        Me.TxtCustomerDiscount.ReadOnly = True
        Me.TxtCustomerDiscount.Size = New System.Drawing.Size(63, 20)
        Me.TxtCustomerDiscount.TabIndex = 104
        '
        'LblCustomerDiscount
        '
        Me.LblCustomerDiscount.AutoSize = True
        Me.LblCustomerDiscount.Location = New System.Drawing.Point(19, 121)
        Me.LblCustomerDiscount.Name = "LblCustomerDiscount"
        Me.LblCustomerDiscount.Size = New System.Drawing.Size(99, 13)
        Me.LblCustomerDiscount.TabIndex = 163
        Me.LblCustomerDiscount.Text = "Customer Discount:"
        '
        'BtnCustomerName
        '
        Me.BtnCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnCustomerName.BackgroundImage = Global.Business_Expert_Pro.My.Resources.Resources.newButton
        Me.BtnCustomerName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCustomerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCustomerName.Location = New System.Drawing.Point(391, 24)
        Me.BtnCustomerName.Name = "BtnCustomerName"
        Me.BtnCustomerName.Size = New System.Drawing.Size(23, 22)
        Me.BtnCustomerName.TabIndex = 1
        Me.BtnCustomerName.UseVisualStyleBackColor = True
        '
        'GrdSale
        '
        Me.GrdSale.AllowUserToAddRows = False
        Me.GrdSale.AllowUserToDeleteRows = False
        Me.GrdSale.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdSale.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GrdSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdSale.Location = New System.Drawing.Point(13, 311)
        Me.GrdSale.Name = "GrdSale"
        Me.GrdSale.ReadOnly = True
        Me.GrdSale.Size = New System.Drawing.Size(713, 394)
        Me.GrdSale.TabIndex = 156
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(8, 24)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(34, 13)
        Me.LblTotal.TabIndex = 128
        Me.LblTotal.Text = "Total:"
        '
        'GrpPaymentInformation
        '
        Me.GrpPaymentInformation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpPaymentInformation.Controls.Add(Me.Label2)
        Me.GrpPaymentInformation.Controls.Add(Me.TxtVat)
        Me.GrpPaymentInformation.Controls.Add(Me.TxtDiscount)
        Me.GrpPaymentInformation.Controls.Add(Me.TxtNetPayable)
        Me.GrpPaymentInformation.Controls.Add(Me.TxtTotalAmount)
        Me.GrpPaymentInformation.Controls.Add(Me.TxtDiscountPercentage)
        Me.GrpPaymentInformation.Controls.Add(Me.TxtTotal)
        Me.GrpPaymentInformation.Controls.Add(Me.TxtVatPercentage)
        Me.GrpPaymentInformation.Controls.Add(Me.LbTotalAmount)
        Me.GrpPaymentInformation.Controls.Add(Me.LblNetPayable)
        Me.GrpPaymentInformation.Controls.Add(Me.LblDiscount)
        Me.GrpPaymentInformation.Controls.Add(Me.Label1)
        Me.GrpPaymentInformation.Controls.Add(Me.LblVat)
        Me.GrpPaymentInformation.Controls.Add(Me.LblTotal)
        Me.GrpPaymentInformation.Location = New System.Drawing.Point(748, 380)
        Me.GrpPaymentInformation.Name = "GrpPaymentInformation"
        Me.GrpPaymentInformation.Size = New System.Drawing.Size(251, 239)
        Me.GrpPaymentInformation.TabIndex = 1002
        Me.GrpPaymentInformation.TabStop = False
        Me.GrpPaymentInformation.Text = "Payment Information"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.BtnSave)
        Me.GroupBox1.Controls.Add(Me.BtnPrint)
        Me.GroupBox1.Controls.Add(Me.BtnInvoice)
        Me.GroupBox1.Location = New System.Drawing.Point(748, 625)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(251, 80)
        Me.GroupBox1.TabIndex = 1003
        Me.GroupBox1.TabStop = False
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Image = Global.Business_Expert_Pro.My.Resources.Resources.Save1
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSave.Location = New System.Drawing.Point(89, 11)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(78, 61)
        Me.BtnSave.TabIndex = 2010
        Me.BtnSave.Text = "Save"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        Me.BtnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrint.Image = Global.Business_Expert_Pro.My.Resources.Resources.Print
        Me.BtnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnPrint.Location = New System.Drawing.Point(11, 11)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(78, 61)
        Me.BtnPrint.TabIndex = 2008
        Me.BtnPrint.Text = "Print"
        Me.BtnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'BtnInvoice
        '
        Me.BtnInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInvoice.Image = Global.Business_Expert_Pro.My.Resources.Resources.Last_view1
        Me.BtnInvoice.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnInvoice.Location = New System.Drawing.Point(167, 11)
        Me.BtnInvoice.Name = "BtnInvoice"
        Me.BtnInvoice.Size = New System.Drawing.Size(78, 61)
        Me.BtnInvoice.TabIndex = 2009
        Me.BtnInvoice.Text = "Invoice"
        Me.BtnInvoice.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnInvoice.UseVisualStyleBackColor = True
        '
        'DtpChalanDate
        '
        Me.DtpChalanDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtpChalanDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpChalanDate.Location = New System.Drawing.Point(775, 95)
        Me.DtpChalanDate.Name = "DtpChalanDate"
        Me.DtpChalanDate.Size = New System.Drawing.Size(129, 20)
        Me.DtpChalanDate.TabIndex = 1004
        Me.DtpChalanDate.Value = New Date(2017, 7, 28, 23, 26, 50, 0)
        '
        'TxtChalanInvoiceNo
        '
        Me.TxtChalanInvoiceNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtChalanInvoiceNo.Location = New System.Drawing.Point(775, 67)
        Me.TxtChalanInvoiceNo.Name = "TxtChalanInvoiceNo"
        Me.TxtChalanInvoiceNo.Size = New System.Drawing.Size(213, 20)
        Me.TxtChalanInvoiceNo.TabIndex = 1005
        '
        'lblInvoiceNo
        '
        Me.lblInvoiceNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInvoiceNo.AutoSize = True
        Me.lblInvoiceNo.Location = New System.Drawing.Point(685, 70)
        Me.lblInvoiceNo.Name = "lblInvoiceNo"
        Me.lblInvoiceNo.Size = New System.Drawing.Size(62, 13)
        Me.lblInvoiceNo.TabIndex = 1006
        Me.lblInvoiceNo.Text = "Invoice No:"
        '
        'TxtSearchBarcode
        '
        Me.TxtSearchBarcode.Location = New System.Drawing.Point(141, 220)
        Me.TxtSearchBarcode.Name = "TxtSearchBarcode"
        Me.TxtSearchBarcode.Size = New System.Drawing.Size(202, 20)
        Me.TxtSearchBarcode.TabIndex = 1007
        '
        'LblSearchBarcode
        '
        Me.LblSearchBarcode.AutoSize = True
        Me.LblSearchBarcode.Location = New System.Drawing.Point(31, 223)
        Me.LblSearchBarcode.Name = "LblSearchBarcode"
        Me.LblSearchBarcode.Size = New System.Drawing.Size(87, 13)
        Me.LblSearchBarcode.TabIndex = 1008
        Me.LblSearchBarcode.Text = "Search Barcode:"
        '
        'cmbProductName
        '
        Me.cmbProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbProductName.FormattingEnabled = True
        Me.cmbProductName.Location = New System.Drawing.Point(9, 30)
        Me.cmbProductName.Name = "cmbProductName"
        Me.cmbProductName.Size = New System.Drawing.Size(234, 21)
        Me.cmbProductName.TabIndex = 1010
        '
        'TxtChalanAmount
        '
        Me.TxtChalanAmount.Location = New System.Drawing.Point(618, 30)
        Me.TxtChalanAmount.Name = "TxtChalanAmount"
        Me.TxtChalanAmount.Size = New System.Drawing.Size(89, 20)
        Me.TxtChalanAmount.TabIndex = 1014
        '
        'TxtChalanUnitPrice
        '
        Me.TxtChalanUnitPrice.Location = New System.Drawing.Point(509, 30)
        Me.TxtChalanUnitPrice.Name = "TxtChalanUnitPrice"
        Me.TxtChalanUnitPrice.Size = New System.Drawing.Size(103, 20)
        Me.TxtChalanUnitPrice.TabIndex = 1013
        '
        'TxtQuantity
        '
        Me.TxtQuantity.Location = New System.Drawing.Point(400, 30)
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.Size = New System.Drawing.Size(103, 20)
        Me.TxtQuantity.TabIndex = 1012
        '
        'LblChalanAmount
        '
        Me.LblChalanAmount.AutoSize = True
        Me.LblChalanAmount.Location = New System.Drawing.Point(627, 12)
        Me.LblChalanAmount.Name = "LblChalanAmount"
        Me.LblChalanAmount.Size = New System.Drawing.Size(82, 13)
        Me.LblChalanAmount.TabIndex = 1015
        Me.LblChalanAmount.Text = "Chalan Amount:"
        '
        'LblChalanUnitPrice
        '
        Me.LblChalanUnitPrice.AutoSize = True
        Me.LblChalanUnitPrice.Location = New System.Drawing.Point(520, 12)
        Me.LblChalanUnitPrice.Name = "LblChalanUnitPrice"
        Me.LblChalanUnitPrice.Size = New System.Drawing.Size(92, 13)
        Me.LblChalanUnitPrice.TabIndex = 1016
        Me.LblChalanUnitPrice.Text = "Chalan Unit Price:"
        '
        'LblQuantitylbl
        '
        Me.LblQuantitylbl.AutoSize = True
        Me.LblQuantitylbl.Location = New System.Drawing.Point(434, 11)
        Me.LblQuantitylbl.Name = "LblQuantitylbl"
        Me.LblQuantitylbl.Size = New System.Drawing.Size(49, 13)
        Me.LblQuantitylbl.TabIndex = 1017
        Me.LblQuantitylbl.Text = "Quantity:"
        '
        'LblProductName
        '
        Me.LblProductName.AutoSize = True
        Me.LblProductName.Location = New System.Drawing.Point(87, 13)
        Me.LblProductName.Name = "LblProductName"
        Me.LblProductName.Size = New System.Drawing.Size(78, 13)
        Me.LblProductName.TabIndex = 1018
        Me.LblProductName.Text = "Product Name:"
        '
        'LblSelectProduct
        '
        Me.LblSelectProduct.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblSelectProduct.Controls.Add(Me.TxtPurchaseID)
        Me.LblSelectProduct.Controls.Add(Me.LblPurchaseID)
        Me.LblSelectProduct.Controls.Add(Me.LblProductName)
        Me.LblSelectProduct.Controls.Add(Me.LblQuantitylbl)
        Me.LblSelectProduct.Controls.Add(Me.LblChalanUnitPrice)
        Me.LblSelectProduct.Controls.Add(Me.LblChalanAmount)
        Me.LblSelectProduct.Controls.Add(Me.TxtQuantity)
        Me.LblSelectProduct.Controls.Add(Me.TxtChalanUnitPrice)
        Me.LblSelectProduct.Controls.Add(Me.TxtChalanAmount)
        Me.LblSelectProduct.Controls.Add(Me.cmbProductName)
        Me.LblSelectProduct.Location = New System.Drawing.Point(13, 242)
        Me.LblSelectProduct.Name = "LblSelectProduct"
        Me.LblSelectProduct.Size = New System.Drawing.Size(713, 63)
        Me.LblSelectProduct.TabIndex = 1019
        Me.LblSelectProduct.TabStop = False
        '
        'TxtPurchaseID
        '
        Me.TxtPurchaseID.Location = New System.Drawing.Point(249, 30)
        Me.TxtPurchaseID.Name = "TxtPurchaseID"
        Me.TxtPurchaseID.ReadOnly = True
        Me.TxtPurchaseID.Size = New System.Drawing.Size(145, 20)
        Me.TxtPurchaseID.TabIndex = 1011
        '
        'LblPurchaseID
        '
        Me.LblPurchaseID.AutoSize = True
        Me.LblPurchaseID.Location = New System.Drawing.Point(275, 12)
        Me.LblPurchaseID.Name = "LblPurchaseID"
        Me.LblPurchaseID.Size = New System.Drawing.Size(66, 13)
        Me.LblPurchaseID.TabIndex = 1020
        Me.LblPurchaseID.Text = "Purchase ID"
        '
        'lblQuantity
        '
        Me.lblQuantity.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(70, 710)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(19, 13)
        Me.lblQuantity.TabIndex = 2020
        Me.lblQuantity.Text = "00"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 710)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 2021
        Me.Label4.Text = "Quantity:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(611, 710)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 2023
        Me.Label5.Text = "Chalan ID:"
        '
        'lblChalanID
        '
        Me.lblChalanID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblChalanID.AutoSize = True
        Me.lblChalanID.Location = New System.Drawing.Point(674, 710)
        Me.lblChalanID.Name = "lblChalanID"
        Me.lblChalanID.Size = New System.Drawing.Size(19, 13)
        Me.lblChalanID.TabIndex = 2022
        Me.lblChalanID.Text = "00"
        '
        'BtnDelete
        '
        Me.BtnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Location = New System.Drawing.Point(617, 214)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(108, 30)
        Me.BtnDelete.TabIndex = 2024
        Me.BtnDelete.Text = "Delete Invoice"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'lblChalanDate
        '
        Me.lblChalanDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblChalanDate.AutoSize = True
        Me.lblChalanDate.Location = New System.Drawing.Point(685, 100)
        Me.lblChalanDate.Name = "lblChalanDate"
        Me.lblChalanDate.Size = New System.Drawing.Size(69, 13)
        Me.lblChalanDate.TabIndex = 2031
        Me.lblChalanDate.Text = "Chalan Date:"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(260, 708)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 16)
        Me.Label13.TabIndex = 2039
        Me.Label13.Text = "Clear : F2"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(354, 708)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(114, 16)
        Me.Label14.TabIndex = 2038
        Me.Label14.Text = "Add New: Enter"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(134, 708)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 16)
        Me.Label11.TabIndex = 2037
        Me.Label11.Text = "For Billing : F8"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(479, 708)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 16)
        Me.Label12.TabIndex = 2036
        Me.Label12.Text = "Delete: Click 2X"
        '
        'BtnChalanHistory
        '
        Me.BtnChalanHistory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnChalanHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnChalanHistory.Location = New System.Drawing.Point(503, 214)
        Me.BtnChalanHistory.Name = "BtnChalanHistory"
        Me.BtnChalanHistory.Size = New System.Drawing.Size(108, 30)
        Me.BtnChalanHistory.TabIndex = 2040
        Me.BtnChalanHistory.Text = "Chalan History"
        Me.BtnChalanHistory.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(388, 214)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 30)
        Me.Button2.TabIndex = 2041
        Me.Button2.Text = "New Invoice"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmChalan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnChalanHistory)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblChalanDate)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblChalanID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.LblSelectProduct)
        Me.Controls.Add(Me.LblSearchBarcode)
        Me.Controls.Add(Me.TxtSearchBarcode)
        Me.Controls.Add(Me.lblInvoiceNo)
        Me.Controls.Add(Me.TxtChalanInvoiceNo)
        Me.Controls.Add(Me.DtpChalanDate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GrpPaymentInformation)
        Me.Controls.Add(Me.GrdSale)
        Me.Controls.Add(Me.GrpCustomerInformation)
        Me.Controls.Add(Me.PnlChalan)
        Me.Name = "FrmChalan"
        Me.Text = "Chalan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PnlChalan.ResumeLayout(False)
        Me.PnlChalan.PerformLayout()
        Me.GrpCustomerInformation.ResumeLayout(False)
        Me.GrpCustomerInformation.PerformLayout()
        CType(Me.GrdSale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpPaymentInformation.ResumeLayout(False)
        Me.GrpPaymentInformation.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.LblSelectProduct.ResumeLayout(False)
        Me.LblSelectProduct.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PnlChalan As System.Windows.Forms.Panel
    Friend WithEvents LblChalan As System.Windows.Forms.Label
    Friend WithEvents LblCustomerName As System.Windows.Forms.Label
    Friend WithEvents LblPhoneNo As System.Windows.Forms.Label
    Friend WithEvents LblAddress As System.Windows.Forms.Label
    Friend WithEvents CmbCustomerName As System.Windows.Forms.ComboBox
    Friend WithEvents TxtPhoneNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtAddress As System.Windows.Forms.TextBox
    Friend WithEvents LblVat As System.Windows.Forms.Label
    Friend WithEvents LblDiscount As System.Windows.Forms.Label
    Friend WithEvents LblNetPayable As System.Windows.Forms.Label
    Friend WithEvents LbTotalAmount As System.Windows.Forms.Label
    Friend WithEvents TxtVatPercentage As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents TxtDiscountPercentage As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents TxtNetPayable As System.Windows.Forms.TextBox
    Friend WithEvents TxtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents TxtVat As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GrpCustomerInformation As System.Windows.Forms.GroupBox
    Friend WithEvents GrdSale As System.Windows.Forms.DataGridView
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents GrpPaymentInformation As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCustomerName As System.Windows.Forms.Button
    Friend WithEvents TxtCustomerDiscount As System.Windows.Forms.TextBox
    Friend WithEvents LblCustomerDiscount As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnInvoice As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents DtpChalanDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtChalanInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents lblInvoiceNo As System.Windows.Forms.Label
    Friend WithEvents TxtSearchBarcode As System.Windows.Forms.TextBox
    Friend WithEvents LblSearchBarcode As System.Windows.Forms.Label
    Friend WithEvents cmbProductName As System.Windows.Forms.ComboBox
    Friend WithEvents TxtChalanAmount As System.Windows.Forms.TextBox
    Friend WithEvents TxtChalanUnitPrice As System.Windows.Forms.TextBox
    Friend WithEvents TxtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents LblChalanAmount As System.Windows.Forms.Label
    Friend WithEvents LblChalanUnitPrice As System.Windows.Forms.Label
    Friend WithEvents LblQuantitylbl As System.Windows.Forms.Label
    Friend WithEvents LblProductName As System.Windows.Forms.Label
    Friend WithEvents LblSelectProduct As System.Windows.Forms.GroupBox
    Friend WithEvents TxtPurchaseID As System.Windows.Forms.TextBox
    Friend WithEvents LblPurchaseID As System.Windows.Forms.Label
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblChalanID As System.Windows.Forms.Label
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents lblChalanDate As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents BtnChalanHistory As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
