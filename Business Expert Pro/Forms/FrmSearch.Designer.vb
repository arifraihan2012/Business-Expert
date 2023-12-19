<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSearch
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GrdSearch = New System.Windows.Forms.DataGridView
        Me.LblSearchLbl = New System.Windows.Forms.Label
        Me.PnlSearchProductStock = New System.Windows.Forms.Panel
        Me.GrpSearchSupplierInformation = New System.Windows.Forms.GroupBox
        Me.GrpVoucher = New System.Windows.Forms.GroupBox
        Me.GrpBankTransaction = New System.Windows.Forms.GroupBox
        Me.DtpBankToDate = New System.Windows.Forms.DateTimePicker
        Me.Label13 = New System.Windows.Forms.Label
        Me.DtpBankFromDate = New System.Windows.Forms.DateTimePicker
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.CmbBankSearch = New System.Windows.Forms.ComboBox
        Me.CmbSeachBankNameBank = New System.Windows.Forms.ComboBox
        Me.TxtSearchCheckNoBank = New System.Windows.Forms.TextBox
        Me.CmbSearchVoucherPurpose = New System.Windows.Forms.ComboBox
        Me.DtpVoucherToDate = New System.Windows.Forms.DateTimePicker
        Me.CmbSearchVoucherSubcategory = New System.Windows.Forms.ComboBox
        Me.CmbSearchVoucherCategory = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.CmbSearchVoucher = New System.Windows.Forms.ComboBox
        Me.DtpVoucherFromDate = New System.Windows.Forms.DateTimePicker
        Me.Label12 = New System.Windows.Forms.Label
        Me.TxtSearchVoucherNo = New System.Windows.Forms.TextBox
        Me.GrpSale = New System.Windows.Forms.GroupBox
        Me.cmbCustomerCategory = New System.Windows.Forms.ComboBox
        Me.DtpSaleToDate = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.CmbSearchSale = New System.Windows.Forms.ComboBox
        Me.DtpSaleFromDate = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxtSearchSaleInvoice = New System.Windows.Forms.TextBox
        Me.GrpPurchase = New System.Windows.Forms.GroupBox
        Me.DtpPurchaseTodate = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.LblToDate = New System.Windows.Forms.Label
        Me.CmbSearchPurchase = New System.Windows.Forms.ComboBox
        Me.DtpPurchaseFromDate = New System.Windows.Forms.DateTimePicker
        Me.LblFromDate = New System.Windows.Forms.Label
        Me.TxtSearchPurchaseInvoice = New System.Windows.Forms.TextBox
        Me.GrpProducts = New System.Windows.Forms.GroupBox
        Me.CmbSearchProductSubcategory = New System.Windows.Forms.ComboBox
        Me.CmbSearchProductCategory = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.CmbSearchProduct = New System.Windows.Forms.ComboBox
        Me.CmbSearchProductGroup = New System.Windows.Forms.ComboBox
        Me.TxtSearchProductName = New System.Windows.Forms.TextBox
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.CmbSelectSearchBy = New System.Windows.Forms.ComboBox
        Me.LblSelectSearchBy = New System.Windows.Forms.Label
        Me.GrpProductDetails = New System.Windows.Forms.GroupBox
        Me.LblApproximateProfit = New System.Windows.Forms.Label
        Me.LblTotalSalePrice = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.LblTotalPurchasePrice = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblTotalStock = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GrpPurchaseDetails = New System.Windows.Forms.GroupBox
        Me.LblTotalPurchaseInvoice = New System.Windows.Forms.Label
        Me.LblTotalPurchaseInvoiceLbl = New System.Windows.Forms.Label
        Me.LblTotalPurchaseAmount = New System.Windows.Forms.Label
        Me.LblTotalPurchaseAmountLbl = New System.Windows.Forms.Label
        Me.GrpSaleDetails = New System.Windows.Forms.GroupBox
        Me.LblTotalSaleInvoice = New System.Windows.Forms.Label
        Me.LblTotalSaleInvoiceLbl = New System.Windows.Forms.Label
        Me.LblTotalReceivedAmount = New System.Windows.Forms.Label
        Me.LblTotalSaleAmountLbl = New System.Windows.Forms.Label
        Me.GrpVoucherDetails = New System.Windows.Forms.GroupBox
        Me.GrpBankTransactionTotal = New System.Windows.Forms.GroupBox
        Me.LblTotalWithdraw = New System.Windows.Forms.Label
        Me.LblTotalWithdrawLbl = New System.Windows.Forms.Label
        Me.LblTotalPayment = New System.Windows.Forms.Label
        Me.LblTotalPaymentLbl = New System.Windows.Forms.Label
        Me.LblReceivedAmount = New System.Windows.Forms.Label
        Me.LblTotalReceivedAmountLbl = New System.Windows.Forms.Label
        Me.LblTotalVoucher = New System.Windows.Forms.Label
        Me.LblTotalVoucherLbl = New System.Windows.Forms.Label
        Me.LblPaidAmount = New System.Windows.Forms.Label
        Me.LblTotalPaidAmountLbl = New System.Windows.Forms.Label
        Me.LblTotalSaleAmount = New System.Windows.Forms.Label
        Me.lebel15 = New System.Windows.Forms.Label
        CType(Me.GrdSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlSearchProductStock.SuspendLayout()
        Me.GrpSearchSupplierInformation.SuspendLayout()
        Me.GrpVoucher.SuspendLayout()
        Me.GrpBankTransaction.SuspendLayout()
        Me.GrpSale.SuspendLayout()
        Me.GrpPurchase.SuspendLayout()
        Me.GrpProducts.SuspendLayout()
        Me.GrpProductDetails.SuspendLayout()
        Me.GrpPurchaseDetails.SuspendLayout()
        Me.GrpSaleDetails.SuspendLayout()
        Me.GrpVoucherDetails.SuspendLayout()
        Me.GrpBankTransactionTotal.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrdSearch
        '
        Me.GrdSearch.AllowUserToAddRows = False
        Me.GrdSearch.AllowUserToDeleteRows = False
        Me.GrdSearch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdSearch.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrdSearch.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.GrdSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GrdSearch.DefaultCellStyle = DataGridViewCellStyle5
        Me.GrdSearch.Location = New System.Drawing.Point(5, 344)
        Me.GrdSearch.Name = "GrdSearch"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrdSearch.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.GrdSearch.Size = New System.Drawing.Size(998, 374)
        Me.GrdSearch.TabIndex = 36
        '
        'LblSearchLbl
        '
        Me.LblSearchLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblSearchLbl.AutoSize = True
        Me.LblSearchLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSearchLbl.ForeColor = System.Drawing.Color.White
        Me.LblSearchLbl.Location = New System.Drawing.Point(445, 22)
        Me.LblSearchLbl.Name = "LblSearchLbl"
        Me.LblSearchLbl.Size = New System.Drawing.Size(124, 37)
        Me.LblSearchLbl.TabIndex = 0
        Me.LblSearchLbl.Text = "Search"
        '
        'PnlSearchProductStock
        '
        Me.PnlSearchProductStock.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlSearchProductStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PnlSearchProductStock.Controls.Add(Me.LblSearchLbl)
        Me.PnlSearchProductStock.Location = New System.Drawing.Point(-3, 0)
        Me.PnlSearchProductStock.Name = "PnlSearchProductStock"
        Me.PnlSearchProductStock.Size = New System.Drawing.Size(1014, 80)
        Me.PnlSearchProductStock.TabIndex = 39
        '
        'GrpSearchSupplierInformation
        '
        Me.GrpSearchSupplierInformation.Controls.Add(Me.GrpVoucher)
        Me.GrpSearchSupplierInformation.Controls.Add(Me.GrpSale)
        Me.GrpSearchSupplierInformation.Controls.Add(Me.GrpPurchase)
        Me.GrpSearchSupplierInformation.Controls.Add(Me.GrpProducts)
        Me.GrpSearchSupplierInformation.Controls.Add(Me.BtnSearch)
        Me.GrpSearchSupplierInformation.Controls.Add(Me.CmbSelectSearchBy)
        Me.GrpSearchSupplierInformation.Controls.Add(Me.LblSelectSearchBy)
        Me.GrpSearchSupplierInformation.Location = New System.Drawing.Point(12, 82)
        Me.GrpSearchSupplierInformation.Name = "GrpSearchSupplierInformation"
        Me.GrpSearchSupplierInformation.Size = New System.Drawing.Size(576, 252)
        Me.GrpSearchSupplierInformation.TabIndex = 1169
        Me.GrpSearchSupplierInformation.TabStop = False
        '
        'GrpVoucher
        '
        Me.GrpVoucher.Controls.Add(Me.GrpBankTransaction)
        Me.GrpVoucher.Controls.Add(Me.CmbSearchVoucherPurpose)
        Me.GrpVoucher.Controls.Add(Me.DtpVoucherToDate)
        Me.GrpVoucher.Controls.Add(Me.CmbSearchVoucherSubcategory)
        Me.GrpVoucher.Controls.Add(Me.CmbSearchVoucherCategory)
        Me.GrpVoucher.Controls.Add(Me.Label10)
        Me.GrpVoucher.Controls.Add(Me.Label11)
        Me.GrpVoucher.Controls.Add(Me.CmbSearchVoucher)
        Me.GrpVoucher.Controls.Add(Me.DtpVoucherFromDate)
        Me.GrpVoucher.Controls.Add(Me.Label12)
        Me.GrpVoucher.Controls.Add(Me.TxtSearchVoucherNo)
        Me.GrpVoucher.Location = New System.Drawing.Point(8, 98)
        Me.GrpVoucher.Name = "GrpVoucher"
        Me.GrpVoucher.Size = New System.Drawing.Size(561, 96)
        Me.GrpVoucher.TabIndex = 2084
        Me.GrpVoucher.TabStop = False
        Me.GrpVoucher.Text = "Voucher:"
        Me.GrpVoucher.Visible = False
        '
        'GrpBankTransaction
        '
        Me.GrpBankTransaction.Controls.Add(Me.DtpBankToDate)
        Me.GrpBankTransaction.Controls.Add(Me.Label13)
        Me.GrpBankTransaction.Controls.Add(Me.DtpBankFromDate)
        Me.GrpBankTransaction.Controls.Add(Me.Label14)
        Me.GrpBankTransaction.Controls.Add(Me.Label24)
        Me.GrpBankTransaction.Controls.Add(Me.CmbBankSearch)
        Me.GrpBankTransaction.Controls.Add(Me.CmbSeachBankNameBank)
        Me.GrpBankTransaction.Controls.Add(Me.TxtSearchCheckNoBank)
        Me.GrpBankTransaction.Location = New System.Drawing.Point(1, 0)
        Me.GrpBankTransaction.Name = "GrpBankTransaction"
        Me.GrpBankTransaction.Size = New System.Drawing.Size(561, 96)
        Me.GrpBankTransaction.TabIndex = 2085
        Me.GrpBankTransaction.TabStop = False
        Me.GrpBankTransaction.Text = "Bank Transaction"
        Me.GrpBankTransaction.Visible = False
        '
        'DtpBankToDate
        '
        Me.DtpBankToDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpBankToDate.Location = New System.Drawing.Point(283, 61)
        Me.DtpBankToDate.Name = "DtpBankToDate"
        Me.DtpBankToDate.Size = New System.Drawing.Size(105, 20)
        Me.DtpBankToDate.TabIndex = 2082
        Me.DtpBankToDate.Value = New Date(2017, 5, 7, 0, 0, 0, 0)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(228, 62)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 13)
        Me.Label13.TabIndex = 2083
        Me.Label13.Text = "To Date:"
        '
        'DtpBankFromDate
        '
        Me.DtpBankFromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpBankFromDate.Location = New System.Drawing.Point(118, 61)
        Me.DtpBankFromDate.Name = "DtpBankFromDate"
        Me.DtpBankFromDate.Size = New System.Drawing.Size(104, 20)
        Me.DtpBankFromDate.TabIndex = 2080
        Me.DtpBankFromDate.Value = New Date(2017, 5, 7, 0, 0, 0, 0)
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(53, 63)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 13)
        Me.Label14.TabIndex = 2081
        Me.Label14.Text = "From Date:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(7, 20)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(83, 16)
        Me.Label24.TabIndex = 2079
        Me.Label24.Text = "Search By:"
        '
        'CmbBankSearch
        '
        Me.CmbBankSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbBankSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBankSearch.FormattingEnabled = True
        Me.CmbBankSearch.Items.AddRange(New Object() {"Bank Name", "Check No", "All Transaction"})
        Me.CmbBankSearch.Location = New System.Drawing.Point(97, 15)
        Me.CmbBankSearch.Name = "CmbBankSearch"
        Me.CmbBankSearch.Size = New System.Drawing.Size(267, 24)
        Me.CmbBankSearch.TabIndex = 1194
        '
        'CmbSeachBankNameBank
        '
        Me.CmbSeachBankNameBank.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbSeachBankNameBank.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSeachBankNameBank.FormattingEnabled = True
        Me.CmbSeachBankNameBank.Location = New System.Drawing.Point(369, 15)
        Me.CmbSeachBankNameBank.Name = "CmbSeachBankNameBank"
        Me.CmbSeachBankNameBank.Size = New System.Drawing.Size(185, 24)
        Me.CmbSeachBankNameBank.TabIndex = 1197
        Me.CmbSeachBankNameBank.Visible = False
        '
        'TxtSearchCheckNoBank
        '
        Me.TxtSearchCheckNoBank.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSearchCheckNoBank.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearchCheckNoBank.Location = New System.Drawing.Point(369, 15)
        Me.TxtSearchCheckNoBank.Name = "TxtSearchCheckNoBank"
        Me.TxtSearchCheckNoBank.Size = New System.Drawing.Size(178, 22)
        Me.TxtSearchCheckNoBank.TabIndex = 1195
        Me.TxtSearchCheckNoBank.Visible = False
        '
        'CmbSearchVoucherPurpose
        '
        Me.CmbSearchVoucherPurpose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbSearchVoucherPurpose.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbSearchVoucherPurpose.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbSearchVoucherPurpose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSearchVoucherPurpose.FormattingEnabled = True
        Me.CmbSearchVoucherPurpose.Location = New System.Drawing.Point(370, 15)
        Me.CmbSearchVoucherPurpose.Name = "CmbSearchVoucherPurpose"
        Me.CmbSearchVoucherPurpose.Size = New System.Drawing.Size(185, 23)
        Me.CmbSearchVoucherPurpose.TabIndex = 2080
        Me.CmbSearchVoucherPurpose.Visible = False
        '
        'DtpVoucherToDate
        '
        Me.DtpVoucherToDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpVoucherToDate.Location = New System.Drawing.Point(283, 61)
        Me.DtpVoucherToDate.Name = "DtpVoucherToDate"
        Me.DtpVoucherToDate.Size = New System.Drawing.Size(105, 20)
        Me.DtpVoucherToDate.TabIndex = 2048
        Me.DtpVoucherToDate.Value = New Date(2017, 5, 7, 0, 0, 0, 0)
        '
        'CmbSearchVoucherSubcategory
        '
        Me.CmbSearchVoucherSubcategory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbSearchVoucherSubcategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbSearchVoucherSubcategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbSearchVoucherSubcategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSearchVoucherSubcategory.FormattingEnabled = True
        Me.CmbSearchVoucherSubcategory.Location = New System.Drawing.Point(370, 15)
        Me.CmbSearchVoucherSubcategory.Name = "CmbSearchVoucherSubcategory"
        Me.CmbSearchVoucherSubcategory.Size = New System.Drawing.Size(185, 23)
        Me.CmbSearchVoucherSubcategory.TabIndex = 2079
        Me.CmbSearchVoucherSubcategory.Visible = False
        '
        'CmbSearchVoucherCategory
        '
        Me.CmbSearchVoucherCategory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbSearchVoucherCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSearchVoucherCategory.FormattingEnabled = True
        Me.CmbSearchVoucherCategory.Items.AddRange(New Object() {"DEBIT VOUCHER", "CREDIT VOUCHER"})
        Me.CmbSearchVoucherCategory.Location = New System.Drawing.Point(370, 15)
        Me.CmbSearchVoucherCategory.Name = "CmbSearchVoucherCategory"
        Me.CmbSearchVoucherCategory.Size = New System.Drawing.Size(185, 23)
        Me.CmbSearchVoucherCategory.TabIndex = 2081
        Me.CmbSearchVoucherCategory.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 16)
        Me.Label10.TabIndex = 2078
        Me.Label10.Text = "Search By:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(228, 62)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 2049
        Me.Label11.Text = "To Date:"
        '
        'CmbSearchVoucher
        '
        Me.CmbSearchVoucher.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbSearchVoucher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSearchVoucher.FormattingEnabled = True
        Me.CmbSearchVoucher.Items.AddRange(New Object() {"Voucher No", "Voucher Category By Date", "Voucher Subcategory By Date", "Voucher Purpose By Date", "Total Voucher Details By Date", "Voucher Details Group Wise By Date"})
        Me.CmbSearchVoucher.Location = New System.Drawing.Point(97, 15)
        Me.CmbSearchVoucher.Name = "CmbSearchVoucher"
        Me.CmbSearchVoucher.Size = New System.Drawing.Size(267, 23)
        Me.CmbSearchVoucher.TabIndex = 1194
        '
        'DtpVoucherFromDate
        '
        Me.DtpVoucherFromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpVoucherFromDate.Location = New System.Drawing.Point(118, 61)
        Me.DtpVoucherFromDate.Name = "DtpVoucherFromDate"
        Me.DtpVoucherFromDate.Size = New System.Drawing.Size(104, 20)
        Me.DtpVoucherFromDate.TabIndex = 2046
        Me.DtpVoucherFromDate.Value = New Date(2017, 5, 7, 0, 0, 0, 0)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(53, 62)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 13)
        Me.Label12.TabIndex = 2047
        Me.Label12.Text = "From Date:"
        '
        'TxtSearchVoucherNo
        '
        Me.TxtSearchVoucherNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearchVoucherNo.Location = New System.Drawing.Point(370, 15)
        Me.TxtSearchVoucherNo.Name = "TxtSearchVoucherNo"
        Me.TxtSearchVoucherNo.Size = New System.Drawing.Size(185, 22)
        Me.TxtSearchVoucherNo.TabIndex = 1198
        Me.TxtSearchVoucherNo.Visible = False
        '
        'GrpSale
        '
        Me.GrpSale.Controls.Add(Me.cmbCustomerCategory)
        Me.GrpSale.Controls.Add(Me.DtpSaleToDate)
        Me.GrpSale.Controls.Add(Me.Label7)
        Me.GrpSale.Controls.Add(Me.Label8)
        Me.GrpSale.Controls.Add(Me.CmbSearchSale)
        Me.GrpSale.Controls.Add(Me.DtpSaleFromDate)
        Me.GrpSale.Controls.Add(Me.Label9)
        Me.GrpSale.Controls.Add(Me.TxtSearchSaleInvoice)
        Me.GrpSale.Location = New System.Drawing.Point(8, 98)
        Me.GrpSale.Name = "GrpSale"
        Me.GrpSale.Size = New System.Drawing.Size(561, 96)
        Me.GrpSale.TabIndex = 2083
        Me.GrpSale.TabStop = False
        Me.GrpSale.Text = "Sale:"
        Me.GrpSale.Visible = False
        '
        'cmbCustomerCategory
        '
        Me.cmbCustomerCategory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCustomerCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbCustomerCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCustomerCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCustomerCategory.FormattingEnabled = True
        Me.cmbCustomerCategory.Location = New System.Drawing.Point(397, 16)
        Me.cmbCustomerCategory.Name = "cmbCustomerCategory"
        Me.cmbCustomerCategory.Size = New System.Drawing.Size(158, 23)
        Me.cmbCustomerCategory.TabIndex = 2082
        Me.cmbCustomerCategory.Visible = False
        '
        'DtpSaleToDate
        '
        Me.DtpSaleToDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpSaleToDate.Location = New System.Drawing.Point(283, 61)
        Me.DtpSaleToDate.Name = "DtpSaleToDate"
        Me.DtpSaleToDate.Size = New System.Drawing.Size(105, 20)
        Me.DtpSaleToDate.TabIndex = 2048
        Me.DtpSaleToDate.Value = New Date(2017, 5, 7, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 16)
        Me.Label7.TabIndex = 2078
        Me.Label7.Text = "Search By:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(228, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 2049
        Me.Label8.Text = "To Date:"
        '
        'CmbSearchSale
        '
        Me.CmbSearchSale.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbSearchSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSearchSale.FormattingEnabled = True
        Me.CmbSearchSale.Items.AddRange(New Object() {"Sale Invoice No", "All Sale Records By Date", "Maximum Sale Of Products By Date", "Customer Category By Date", "Product Sale History"})
        Me.CmbSearchSale.Location = New System.Drawing.Point(97, 16)
        Me.CmbSearchSale.Name = "CmbSearchSale"
        Me.CmbSearchSale.Size = New System.Drawing.Size(294, 23)
        Me.CmbSearchSale.TabIndex = 1194
        '
        'DtpSaleFromDate
        '
        Me.DtpSaleFromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpSaleFromDate.Location = New System.Drawing.Point(118, 61)
        Me.DtpSaleFromDate.Name = "DtpSaleFromDate"
        Me.DtpSaleFromDate.Size = New System.Drawing.Size(104, 20)
        Me.DtpSaleFromDate.TabIndex = 2046
        Me.DtpSaleFromDate.Value = New Date(2017, 5, 7, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(53, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 2047
        Me.Label9.Text = "From Date:"
        '
        'TxtSearchSaleInvoice
        '
        Me.TxtSearchSaleInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearchSaleInvoice.Location = New System.Drawing.Point(397, 16)
        Me.TxtSearchSaleInvoice.Name = "TxtSearchSaleInvoice"
        Me.TxtSearchSaleInvoice.Size = New System.Drawing.Size(158, 22)
        Me.TxtSearchSaleInvoice.TabIndex = 1198
        Me.TxtSearchSaleInvoice.Visible = False
        '
        'GrpPurchase
        '
        Me.GrpPurchase.Controls.Add(Me.DtpPurchaseTodate)
        Me.GrpPurchase.Controls.Add(Me.Label6)
        Me.GrpPurchase.Controls.Add(Me.LblToDate)
        Me.GrpPurchase.Controls.Add(Me.CmbSearchPurchase)
        Me.GrpPurchase.Controls.Add(Me.DtpPurchaseFromDate)
        Me.GrpPurchase.Controls.Add(Me.LblFromDate)
        Me.GrpPurchase.Controls.Add(Me.TxtSearchPurchaseInvoice)
        Me.GrpPurchase.Location = New System.Drawing.Point(9, 99)
        Me.GrpPurchase.Name = "GrpPurchase"
        Me.GrpPurchase.Size = New System.Drawing.Size(561, 96)
        Me.GrpPurchase.TabIndex = 2082
        Me.GrpPurchase.TabStop = False
        Me.GrpPurchase.Text = "Purchase:"
        Me.GrpPurchase.Visible = False
        '
        'DtpPurchaseTodate
        '
        Me.DtpPurchaseTodate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpPurchaseTodate.Location = New System.Drawing.Point(283, 61)
        Me.DtpPurchaseTodate.Name = "DtpPurchaseTodate"
        Me.DtpPurchaseTodate.Size = New System.Drawing.Size(105, 20)
        Me.DtpPurchaseTodate.TabIndex = 2048
        Me.DtpPurchaseTodate.Value = New Date(2017, 5, 7, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 16)
        Me.Label6.TabIndex = 2078
        Me.Label6.Text = "Search By:"
        '
        'LblToDate
        '
        Me.LblToDate.AutoSize = True
        Me.LblToDate.Location = New System.Drawing.Point(228, 62)
        Me.LblToDate.Name = "LblToDate"
        Me.LblToDate.Size = New System.Drawing.Size(49, 13)
        Me.LblToDate.TabIndex = 2049
        Me.LblToDate.Text = "To Date:"
        '
        'CmbSearchPurchase
        '
        Me.CmbSearchPurchase.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbSearchPurchase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSearchPurchase.FormattingEnabled = True
        Me.CmbSearchPurchase.Items.AddRange(New Object() {"Purchase Invoice No", "All Purchase Records By Date", "Maximum Purchase Of Products By Date"})
        Me.CmbSearchPurchase.Location = New System.Drawing.Point(97, 16)
        Me.CmbSearchPurchase.Name = "CmbSearchPurchase"
        Me.CmbSearchPurchase.Size = New System.Drawing.Size(294, 23)
        Me.CmbSearchPurchase.TabIndex = 1194
        '
        'DtpPurchaseFromDate
        '
        Me.DtpPurchaseFromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpPurchaseFromDate.Location = New System.Drawing.Point(118, 61)
        Me.DtpPurchaseFromDate.Name = "DtpPurchaseFromDate"
        Me.DtpPurchaseFromDate.Size = New System.Drawing.Size(104, 20)
        Me.DtpPurchaseFromDate.TabIndex = 2046
        Me.DtpPurchaseFromDate.Value = New Date(2017, 5, 7, 0, 0, 0, 0)
        '
        'LblFromDate
        '
        Me.LblFromDate.AutoSize = True
        Me.LblFromDate.Location = New System.Drawing.Point(53, 62)
        Me.LblFromDate.Name = "LblFromDate"
        Me.LblFromDate.Size = New System.Drawing.Size(59, 13)
        Me.LblFromDate.TabIndex = 2047
        Me.LblFromDate.Text = "From Date:"
        '
        'TxtSearchPurchaseInvoice
        '
        Me.TxtSearchPurchaseInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearchPurchaseInvoice.Location = New System.Drawing.Point(397, 16)
        Me.TxtSearchPurchaseInvoice.Name = "TxtSearchPurchaseInvoice"
        Me.TxtSearchPurchaseInvoice.Size = New System.Drawing.Size(158, 22)
        Me.TxtSearchPurchaseInvoice.TabIndex = 1198
        Me.TxtSearchPurchaseInvoice.Visible = False
        '
        'GrpProducts
        '
        Me.GrpProducts.Controls.Add(Me.CmbSearchProductSubcategory)
        Me.GrpProducts.Controls.Add(Me.CmbSearchProductCategory)
        Me.GrpProducts.Controls.Add(Me.Label2)
        Me.GrpProducts.Controls.Add(Me.CmbSearchProduct)
        Me.GrpProducts.Controls.Add(Me.CmbSearchProductGroup)
        Me.GrpProducts.Controls.Add(Me.TxtSearchProductName)
        Me.GrpProducts.Location = New System.Drawing.Point(9, 99)
        Me.GrpProducts.Name = "GrpProducts"
        Me.GrpProducts.Size = New System.Drawing.Size(561, 96)
        Me.GrpProducts.TabIndex = 2045
        Me.GrpProducts.TabStop = False
        Me.GrpProducts.Text = "Products:"
        Me.GrpProducts.Visible = False
        '
        'CmbSearchProductSubcategory
        '
        Me.CmbSearchProductSubcategory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbSearchProductSubcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbSearchProductSubcategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSearchProductSubcategory.FormattingEnabled = True
        Me.CmbSearchProductSubcategory.Location = New System.Drawing.Point(290, 16)
        Me.CmbSearchProductSubcategory.Name = "CmbSearchProductSubcategory"
        Me.CmbSearchProductSubcategory.Size = New System.Drawing.Size(265, 24)
        Me.CmbSearchProductSubcategory.TabIndex = 2081
        Me.CmbSearchProductSubcategory.Visible = False
        '
        'CmbSearchProductCategory
        '
        Me.CmbSearchProductCategory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbSearchProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbSearchProductCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSearchProductCategory.FormattingEnabled = True
        Me.CmbSearchProductCategory.Location = New System.Drawing.Point(290, 16)
        Me.CmbSearchProductCategory.Name = "CmbSearchProductCategory"
        Me.CmbSearchProductCategory.Size = New System.Drawing.Size(265, 24)
        Me.CmbSearchProductCategory.TabIndex = 2080
        Me.CmbSearchProductCategory.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 16)
        Me.Label2.TabIndex = 2078
        Me.Label2.Text = "Search By:"
        '
        'CmbSearchProduct
        '
        Me.CmbSearchProduct.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbSearchProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSearchProduct.FormattingEnabled = True
        Me.CmbSearchProduct.Items.AddRange(New Object() {"Product Name", "Product Group", "Product Category", "Product Subcategory", "Low Stock Product"})
        Me.CmbSearchProduct.Location = New System.Drawing.Point(97, 16)
        Me.CmbSearchProduct.Name = "CmbSearchProduct"
        Me.CmbSearchProduct.Size = New System.Drawing.Size(184, 23)
        Me.CmbSearchProduct.TabIndex = 1194
        '
        'CmbSearchProductGroup
        '
        Me.CmbSearchProductGroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbSearchProductGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbSearchProductGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSearchProductGroup.FormattingEnabled = True
        Me.CmbSearchProductGroup.Location = New System.Drawing.Point(290, 16)
        Me.CmbSearchProductGroup.Name = "CmbSearchProductGroup"
        Me.CmbSearchProductGroup.Size = New System.Drawing.Size(265, 24)
        Me.CmbSearchProductGroup.TabIndex = 2079
        Me.CmbSearchProductGroup.Visible = False
        '
        'TxtSearchProductName
        '
        Me.TxtSearchProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearchProductName.Location = New System.Drawing.Point(290, 16)
        Me.TxtSearchProductName.Name = "TxtSearchProductName"
        Me.TxtSearchProductName.Size = New System.Drawing.Size(265, 22)
        Me.TxtSearchProductName.TabIndex = 1198
        Me.TxtSearchProductName.Visible = False
        '
        'BtnSearch
        '
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Location = New System.Drawing.Point(251, 216)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(75, 23)
        Me.BtnSearch.TabIndex = 1167
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'CmbSelectSearchBy
        '
        Me.CmbSelectSearchBy.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbSelectSearchBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.CmbSelectSearchBy.FormattingEnabled = True
        Me.CmbSelectSearchBy.Items.AddRange(New Object() {"PRODUCT", "PURCHASE", "SALE", "VOUCHER", "BANK TRANSACTION"})
        Me.CmbSelectSearchBy.Location = New System.Drawing.Point(173, 30)
        Me.CmbSelectSearchBy.Name = "CmbSelectSearchBy"
        Me.CmbSelectSearchBy.Size = New System.Drawing.Size(334, 23)
        Me.CmbSelectSearchBy.TabIndex = 101
        '
        'LblSelectSearchBy
        '
        Me.LblSelectSearchBy.AutoSize = True
        Me.LblSelectSearchBy.Location = New System.Drawing.Point(70, 34)
        Me.LblSelectSearchBy.Name = "LblSelectSearchBy"
        Me.LblSelectSearchBy.Size = New System.Drawing.Size(92, 13)
        Me.LblSelectSearchBy.TabIndex = 0
        Me.LblSelectSearchBy.Text = "Select Search By:"
        '
        'GrpProductDetails
        '
        Me.GrpProductDetails.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpProductDetails.Controls.Add(Me.LblApproximateProfit)
        Me.GrpProductDetails.Controls.Add(Me.LblTotalSalePrice)
        Me.GrpProductDetails.Controls.Add(Me.Label4)
        Me.GrpProductDetails.Controls.Add(Me.Label5)
        Me.GrpProductDetails.Controls.Add(Me.LblTotalPurchasePrice)
        Me.GrpProductDetails.Controls.Add(Me.Label3)
        Me.GrpProductDetails.Controls.Add(Me.lblTotalStock)
        Me.GrpProductDetails.Controls.Add(Me.Label1)
        Me.GrpProductDetails.Location = New System.Drawing.Point(604, 132)
        Me.GrpProductDetails.Name = "GrpProductDetails"
        Me.GrpProductDetails.Size = New System.Drawing.Size(392, 175)
        Me.GrpProductDetails.TabIndex = 2051
        Me.GrpProductDetails.TabStop = False
        Me.GrpProductDetails.Text = "Product Details"
        Me.GrpProductDetails.Visible = False
        '
        'LblApproximateProfit
        '
        Me.LblApproximateProfit.AutoSize = True
        Me.LblApproximateProfit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.LblApproximateProfit.Location = New System.Drawing.Point(172, 101)
        Me.LblApproximateProfit.Name = "LblApproximateProfit"
        Me.LblApproximateProfit.Size = New System.Drawing.Size(23, 15)
        Me.LblApproximateProfit.TabIndex = 1185
        Me.LblApproximateProfit.Text = "00"
        '
        'LblTotalSalePrice
        '
        Me.LblTotalSalePrice.AutoSize = True
        Me.LblTotalSalePrice.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.LblTotalSalePrice.Location = New System.Drawing.Point(172, 80)
        Me.LblTotalSalePrice.Name = "LblTotalSalePrice"
        Me.LblTotalSalePrice.Size = New System.Drawing.Size(23, 15)
        Me.LblTotalSalePrice.TabIndex = 1183
        Me.LblTotalSalePrice.Text = "00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(20, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 15)
        Me.Label4.TabIndex = 1184
        Me.Label4.Text = "Approximate Profit:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(20, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 15)
        Me.Label5.TabIndex = 1182
        Me.Label5.Text = "Total Sale Price:"
        '
        'LblTotalPurchasePrice
        '
        Me.LblTotalPurchasePrice.AutoSize = True
        Me.LblTotalPurchasePrice.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.LblTotalPurchasePrice.Location = New System.Drawing.Point(172, 57)
        Me.LblTotalPurchasePrice.Name = "LblTotalPurchasePrice"
        Me.LblTotalPurchasePrice.Size = New System.Drawing.Size(23, 15)
        Me.LblTotalPurchasePrice.TabIndex = 1181
        Me.LblTotalPurchasePrice.Text = "00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(20, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 15)
        Me.Label3.TabIndex = 1180
        Me.Label3.Text = "Total Purchase Price:"
        '
        'lblTotalStock
        '
        Me.lblTotalStock.AutoSize = True
        Me.lblTotalStock.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.lblTotalStock.Location = New System.Drawing.Point(172, 35)
        Me.lblTotalStock.Name = "lblTotalStock"
        Me.lblTotalStock.Size = New System.Drawing.Size(23, 15)
        Me.lblTotalStock.TabIndex = 1179
        Me.lblTotalStock.Text = "00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(20, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 15)
        Me.Label1.TabIndex = 1178
        Me.Label1.Text = "Total Stock:"
        '
        'GrpPurchaseDetails
        '
        Me.GrpPurchaseDetails.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpPurchaseDetails.Controls.Add(Me.LblTotalPurchaseInvoice)
        Me.GrpPurchaseDetails.Controls.Add(Me.LblTotalPurchaseInvoiceLbl)
        Me.GrpPurchaseDetails.Controls.Add(Me.LblTotalPurchaseAmount)
        Me.GrpPurchaseDetails.Controls.Add(Me.LblTotalPurchaseAmountLbl)
        Me.GrpPurchaseDetails.Location = New System.Drawing.Point(604, 133)
        Me.GrpPurchaseDetails.Name = "GrpPurchaseDetails"
        Me.GrpPurchaseDetails.Size = New System.Drawing.Size(392, 175)
        Me.GrpPurchaseDetails.TabIndex = 2052
        Me.GrpPurchaseDetails.TabStop = False
        Me.GrpPurchaseDetails.Text = "Purchase Details"
        Me.GrpPurchaseDetails.Visible = False
        '
        'LblTotalPurchaseInvoice
        '
        Me.LblTotalPurchaseInvoice.AutoSize = True
        Me.LblTotalPurchaseInvoice.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.LblTotalPurchaseInvoice.Location = New System.Drawing.Point(233, 34)
        Me.LblTotalPurchaseInvoice.Name = "LblTotalPurchaseInvoice"
        Me.LblTotalPurchaseInvoice.Size = New System.Drawing.Size(23, 15)
        Me.LblTotalPurchaseInvoice.TabIndex = 1181
        Me.LblTotalPurchaseInvoice.Text = "00"
        '
        'LblTotalPurchaseInvoiceLbl
        '
        Me.LblTotalPurchaseInvoiceLbl.AutoSize = True
        Me.LblTotalPurchaseInvoiceLbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.LblTotalPurchaseInvoiceLbl.Location = New System.Drawing.Point(36, 34)
        Me.LblTotalPurchaseInvoiceLbl.Name = "LblTotalPurchaseInvoiceLbl"
        Me.LblTotalPurchaseInvoiceLbl.Size = New System.Drawing.Size(159, 15)
        Me.LblTotalPurchaseInvoiceLbl.TabIndex = 1180
        Me.LblTotalPurchaseInvoiceLbl.Text = "Total Purchase Invoice:"
        '
        'LblTotalPurchaseAmount
        '
        Me.LblTotalPurchaseAmount.AutoSize = True
        Me.LblTotalPurchaseAmount.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.LblTotalPurchaseAmount.Location = New System.Drawing.Point(233, 57)
        Me.LblTotalPurchaseAmount.Name = "LblTotalPurchaseAmount"
        Me.LblTotalPurchaseAmount.Size = New System.Drawing.Size(23, 15)
        Me.LblTotalPurchaseAmount.TabIndex = 1179
        Me.LblTotalPurchaseAmount.Text = "00"
        '
        'LblTotalPurchaseAmountLbl
        '
        Me.LblTotalPurchaseAmountLbl.AutoSize = True
        Me.LblTotalPurchaseAmountLbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.LblTotalPurchaseAmountLbl.Location = New System.Drawing.Point(36, 57)
        Me.LblTotalPurchaseAmountLbl.Name = "LblTotalPurchaseAmountLbl"
        Me.LblTotalPurchaseAmountLbl.Size = New System.Drawing.Size(162, 15)
        Me.LblTotalPurchaseAmountLbl.TabIndex = 1178
        Me.LblTotalPurchaseAmountLbl.Text = "Total Purchase Amount:"
        '
        'GrpSaleDetails
        '
        Me.GrpSaleDetails.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpSaleDetails.Controls.Add(Me.LblTotalSaleAmount)
        Me.GrpSaleDetails.Controls.Add(Me.lebel15)
        Me.GrpSaleDetails.Controls.Add(Me.LblTotalSaleInvoice)
        Me.GrpSaleDetails.Controls.Add(Me.LblTotalSaleInvoiceLbl)
        Me.GrpSaleDetails.Controls.Add(Me.LblTotalReceivedAmount)
        Me.GrpSaleDetails.Controls.Add(Me.LblTotalSaleAmountLbl)
        Me.GrpSaleDetails.Location = New System.Drawing.Point(604, 132)
        Me.GrpSaleDetails.Name = "GrpSaleDetails"
        Me.GrpSaleDetails.Size = New System.Drawing.Size(392, 116)
        Me.GrpSaleDetails.TabIndex = 2053
        Me.GrpSaleDetails.TabStop = False
        Me.GrpSaleDetails.Text = "Sale Details"
        Me.GrpSaleDetails.Visible = False
        '
        'LblTotalSaleInvoice
        '
        Me.LblTotalSaleInvoice.AutoSize = True
        Me.LblTotalSaleInvoice.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.LblTotalSaleInvoice.Location = New System.Drawing.Point(233, 34)
        Me.LblTotalSaleInvoice.Name = "LblTotalSaleInvoice"
        Me.LblTotalSaleInvoice.Size = New System.Drawing.Size(23, 15)
        Me.LblTotalSaleInvoice.TabIndex = 1181
        Me.LblTotalSaleInvoice.Text = "00"
        '
        'LblTotalSaleInvoiceLbl
        '
        Me.LblTotalSaleInvoiceLbl.AutoSize = True
        Me.LblTotalSaleInvoiceLbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.LblTotalSaleInvoiceLbl.Location = New System.Drawing.Point(36, 34)
        Me.LblTotalSaleInvoiceLbl.Name = "LblTotalSaleInvoiceLbl"
        Me.LblTotalSaleInvoiceLbl.Size = New System.Drawing.Size(126, 15)
        Me.LblTotalSaleInvoiceLbl.TabIndex = 1180
        Me.LblTotalSaleInvoiceLbl.Text = "Total Sale Invoice:"
        '
        'LblTotalReceivedAmount
        '
        Me.LblTotalReceivedAmount.AutoSize = True
        Me.LblTotalReceivedAmount.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.LblTotalReceivedAmount.Location = New System.Drawing.Point(233, 86)
        Me.LblTotalReceivedAmount.Name = "LblTotalReceivedAmount"
        Me.LblTotalReceivedAmount.Size = New System.Drawing.Size(23, 15)
        Me.LblTotalReceivedAmount.TabIndex = 1179
        Me.LblTotalReceivedAmount.Text = "00"
        '
        'LblTotalSaleAmountLbl
        '
        Me.LblTotalSaleAmountLbl.AutoSize = True
        Me.LblTotalSaleAmountLbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.LblTotalSaleAmountLbl.Location = New System.Drawing.Point(36, 86)
        Me.LblTotalSaleAmountLbl.Name = "LblTotalSaleAmountLbl"
        Me.LblTotalSaleAmountLbl.Size = New System.Drawing.Size(166, 15)
        Me.LblTotalSaleAmountLbl.TabIndex = 1178
        Me.LblTotalSaleAmountLbl.Text = "Total Receiverd Amount:"
        '
        'GrpVoucherDetails
        '
        Me.GrpVoucherDetails.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpVoucherDetails.Controls.Add(Me.LblReceivedAmount)
        Me.GrpVoucherDetails.Controls.Add(Me.LblTotalReceivedAmountLbl)
        Me.GrpVoucherDetails.Controls.Add(Me.LblTotalVoucher)
        Me.GrpVoucherDetails.Controls.Add(Me.LblTotalVoucherLbl)
        Me.GrpVoucherDetails.Controls.Add(Me.LblPaidAmount)
        Me.GrpVoucherDetails.Controls.Add(Me.LblTotalPaidAmountLbl)
        Me.GrpVoucherDetails.Location = New System.Drawing.Point(598, 281)
        Me.GrpVoucherDetails.Name = "GrpVoucherDetails"
        Me.GrpVoucherDetails.Size = New System.Drawing.Size(392, 175)
        Me.GrpVoucherDetails.TabIndex = 2054
        Me.GrpVoucherDetails.TabStop = False
        Me.GrpVoucherDetails.Text = "Voucher Details"
        Me.GrpVoucherDetails.Visible = False
        '
        'GrpBankTransactionTotal
        '
        Me.GrpBankTransactionTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpBankTransactionTotal.Controls.Add(Me.LblTotalWithdraw)
        Me.GrpBankTransactionTotal.Controls.Add(Me.LblTotalWithdrawLbl)
        Me.GrpBankTransactionTotal.Controls.Add(Me.LblTotalPayment)
        Me.GrpBankTransactionTotal.Controls.Add(Me.LblTotalPaymentLbl)
        Me.GrpBankTransactionTotal.Location = New System.Drawing.Point(604, 314)
        Me.GrpBankTransactionTotal.Name = "GrpBankTransactionTotal"
        Me.GrpBankTransactionTotal.Size = New System.Drawing.Size(392, 175)
        Me.GrpBankTransactionTotal.TabIndex = 2055
        Me.GrpBankTransactionTotal.TabStop = False
        Me.GrpBankTransactionTotal.Text = "BankTransactionTotal"
        Me.GrpBankTransactionTotal.Visible = False
        '
        'LblTotalWithdraw
        '
        Me.LblTotalWithdraw.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTotalWithdraw.AutoSize = True
        Me.LblTotalWithdraw.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalWithdraw.Location = New System.Drawing.Point(186, 49)
        Me.LblTotalWithdraw.Name = "LblTotalWithdraw"
        Me.LblTotalWithdraw.Size = New System.Drawing.Size(24, 16)
        Me.LblTotalWithdraw.TabIndex = 1186
        Me.LblTotalWithdraw.Text = "00"
        '
        'LblTotalWithdrawLbl
        '
        Me.LblTotalWithdrawLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTotalWithdrawLbl.AutoSize = True
        Me.LblTotalWithdrawLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalWithdrawLbl.Location = New System.Drawing.Point(33, 48)
        Me.LblTotalWithdrawLbl.Name = "LblTotalWithdrawLbl"
        Me.LblTotalWithdrawLbl.Size = New System.Drawing.Size(119, 16)
        Me.LblTotalWithdrawLbl.TabIndex = 1185
        Me.LblTotalWithdrawLbl.Text = "Total Withdraw :"
        '
        'LblTotalPayment
        '
        Me.LblTotalPayment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTotalPayment.AutoSize = True
        Me.LblTotalPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalPayment.Location = New System.Drawing.Point(185, 24)
        Me.LblTotalPayment.Name = "LblTotalPayment"
        Me.LblTotalPayment.Size = New System.Drawing.Size(24, 16)
        Me.LblTotalPayment.TabIndex = 1184
        Me.LblTotalPayment.Text = "00"
        '
        'LblTotalPaymentLbl
        '
        Me.LblTotalPaymentLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTotalPaymentLbl.AutoSize = True
        Me.LblTotalPaymentLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalPaymentLbl.Location = New System.Drawing.Point(32, 23)
        Me.LblTotalPaymentLbl.Name = "LblTotalPaymentLbl"
        Me.LblTotalPaymentLbl.Size = New System.Drawing.Size(112, 16)
        Me.LblTotalPaymentLbl.TabIndex = 1183
        Me.LblTotalPaymentLbl.Text = "Total Payment:"
        '
        'LblReceivedAmount
        '
        Me.LblReceivedAmount.AutoSize = True
        Me.LblReceivedAmount.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.LblReceivedAmount.Location = New System.Drawing.Point(233, 88)
        Me.LblReceivedAmount.Name = "LblReceivedAmount"
        Me.LblReceivedAmount.Size = New System.Drawing.Size(23, 15)
        Me.LblReceivedAmount.TabIndex = 1183
        Me.LblReceivedAmount.Text = "00"
        '
        'LblTotalReceivedAmountLbl
        '
        Me.LblTotalReceivedAmountLbl.AutoSize = True
        Me.LblTotalReceivedAmountLbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.LblTotalReceivedAmountLbl.Location = New System.Drawing.Point(36, 88)
        Me.LblTotalReceivedAmountLbl.Name = "LblTotalReceivedAmountLbl"
        Me.LblTotalReceivedAmountLbl.Size = New System.Drawing.Size(160, 15)
        Me.LblTotalReceivedAmountLbl.TabIndex = 1182
        Me.LblTotalReceivedAmountLbl.Text = "Total Received Amount:"
        '
        'LblTotalVoucher
        '
        Me.LblTotalVoucher.AutoSize = True
        Me.LblTotalVoucher.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.LblTotalVoucher.Location = New System.Drawing.Point(233, 34)
        Me.LblTotalVoucher.Name = "LblTotalVoucher"
        Me.LblTotalVoucher.Size = New System.Drawing.Size(23, 15)
        Me.LblTotalVoucher.TabIndex = 1181
        Me.LblTotalVoucher.Text = "00"
        '
        'LblTotalVoucherLbl
        '
        Me.LblTotalVoucherLbl.AutoSize = True
        Me.LblTotalVoucherLbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.LblTotalVoucherLbl.Location = New System.Drawing.Point(36, 34)
        Me.LblTotalVoucherLbl.Name = "LblTotalVoucherLbl"
        Me.LblTotalVoucherLbl.Size = New System.Drawing.Size(102, 15)
        Me.LblTotalVoucherLbl.TabIndex = 1180
        Me.LblTotalVoucherLbl.Text = "Total Voucher:"
        '
        'LblPaidAmount
        '
        Me.LblPaidAmount.AutoSize = True
        Me.LblPaidAmount.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.LblPaidAmount.Location = New System.Drawing.Point(233, 61)
        Me.LblPaidAmount.Name = "LblPaidAmount"
        Me.LblPaidAmount.Size = New System.Drawing.Size(23, 15)
        Me.LblPaidAmount.TabIndex = 1179
        Me.LblPaidAmount.Text = "00"
        '
        'LblTotalPaidAmountLbl
        '
        Me.LblTotalPaidAmountLbl.AutoSize = True
        Me.LblTotalPaidAmountLbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.LblTotalPaidAmountLbl.Location = New System.Drawing.Point(36, 61)
        Me.LblTotalPaidAmountLbl.Name = "LblTotalPaidAmountLbl"
        Me.LblTotalPaidAmountLbl.Size = New System.Drawing.Size(93, 15)
        Me.LblTotalPaidAmountLbl.TabIndex = 1178
        Me.LblTotalPaidAmountLbl.Text = "Paid Amount:"
        '
        'LblTotalSaleAmount
        '
        Me.LblTotalSaleAmount.AutoSize = True
        Me.LblTotalSaleAmount.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.LblTotalSaleAmount.Location = New System.Drawing.Point(233, 57)
        Me.LblTotalSaleAmount.Name = "LblTotalSaleAmount"
        Me.LblTotalSaleAmount.Size = New System.Drawing.Size(23, 15)
        Me.LblTotalSaleAmount.TabIndex = 1183
        Me.LblTotalSaleAmount.Text = "00"
        '
        'lebel15
        '
        Me.lebel15.AutoSize = True
        Me.lebel15.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.lebel15.Location = New System.Drawing.Point(36, 57)
        Me.lebel15.Name = "lebel15"
        Me.lebel15.Size = New System.Drawing.Size(129, 15)
        Me.lebel15.TabIndex = 1182
        Me.lebel15.Text = "Total Sale Amount:"
        '
        'FrmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.GrpBankTransactionTotal)
        Me.Controls.Add(Me.GrpVoucherDetails)
        Me.Controls.Add(Me.GrpSaleDetails)
        Me.Controls.Add(Me.GrpPurchaseDetails)
        Me.Controls.Add(Me.GrpProductDetails)
        Me.Controls.Add(Me.GrpSearchSupplierInformation)
        Me.Controls.Add(Me.PnlSearchProductStock)
        Me.Controls.Add(Me.GrdSearch)
        Me.Name = "FrmSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GrdSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlSearchProductStock.ResumeLayout(False)
        Me.PnlSearchProductStock.PerformLayout()
        Me.GrpSearchSupplierInformation.ResumeLayout(False)
        Me.GrpSearchSupplierInformation.PerformLayout()
        Me.GrpVoucher.ResumeLayout(False)
        Me.GrpVoucher.PerformLayout()
        Me.GrpBankTransaction.ResumeLayout(False)
        Me.GrpBankTransaction.PerformLayout()
        Me.GrpSale.ResumeLayout(False)
        Me.GrpSale.PerformLayout()
        Me.GrpPurchase.ResumeLayout(False)
        Me.GrpPurchase.PerformLayout()
        Me.GrpProducts.ResumeLayout(False)
        Me.GrpProducts.PerformLayout()
        Me.GrpProductDetails.ResumeLayout(False)
        Me.GrpProductDetails.PerformLayout()
        Me.GrpPurchaseDetails.ResumeLayout(False)
        Me.GrpPurchaseDetails.PerformLayout()
        Me.GrpSaleDetails.ResumeLayout(False)
        Me.GrpSaleDetails.PerformLayout()
        Me.GrpVoucherDetails.ResumeLayout(False)
        Me.GrpVoucherDetails.PerformLayout()
        Me.GrpBankTransactionTotal.ResumeLayout(False)
        Me.GrpBankTransactionTotal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrdSearch As System.Windows.Forms.DataGridView
    Friend WithEvents LblSearchLbl As System.Windows.Forms.Label
    Friend WithEvents PnlSearchProductStock As System.Windows.Forms.Panel
    Friend WithEvents GrpSearchSupplierInformation As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents CmbSelectSearchBy As System.Windows.Forms.ComboBox
    Friend WithEvents LblSelectSearchBy As System.Windows.Forms.Label
    Friend WithEvents GrpProducts As System.Windows.Forms.GroupBox
    Friend WithEvents CmbSearchProductGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtSearchProductName As System.Windows.Forms.TextBox
    Friend WithEvents CmbSearchProduct As System.Windows.Forms.ComboBox
    Friend WithEvents GrpProductDetails As System.Windows.Forms.GroupBox
    Friend WithEvents DtpPurchaseTodate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblToDate As System.Windows.Forms.Label
    Friend WithEvents DtpPurchaseFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblFromDate As System.Windows.Forms.Label
    Friend WithEvents CmbSearchProductSubcategory As System.Windows.Forms.ComboBox
    Friend WithEvents CmbSearchProductCategory As System.Windows.Forms.ComboBox
    Friend WithEvents LblApproximateProfit As System.Windows.Forms.Label
    Friend WithEvents LblTotalSalePrice As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LblTotalPurchasePrice As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTotalStock As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GrpPurchase As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CmbSearchPurchase As System.Windows.Forms.ComboBox
    Friend WithEvents TxtSearchPurchaseInvoice As System.Windows.Forms.TextBox
    Friend WithEvents GrpPurchaseDetails As System.Windows.Forms.GroupBox
    Friend WithEvents LblTotalPurchaseInvoice As System.Windows.Forms.Label
    Friend WithEvents LblTotalPurchaseInvoiceLbl As System.Windows.Forms.Label
    Friend WithEvents LblTotalPurchaseAmount As System.Windows.Forms.Label
    Friend WithEvents LblTotalPurchaseAmountLbl As System.Windows.Forms.Label
    Friend WithEvents GrpSale As System.Windows.Forms.GroupBox
    Friend WithEvents DtpSaleToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CmbSearchSale As System.Windows.Forms.ComboBox
    Friend WithEvents DtpSaleFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtSearchSaleInvoice As System.Windows.Forms.TextBox
    Friend WithEvents GrpSaleDetails As System.Windows.Forms.GroupBox
    Friend WithEvents LblTotalSaleInvoice As System.Windows.Forms.Label
    Friend WithEvents LblTotalSaleInvoiceLbl As System.Windows.Forms.Label
    Friend WithEvents LblTotalReceivedAmount As System.Windows.Forms.Label
    Friend WithEvents LblTotalSaleAmountLbl As System.Windows.Forms.Label
    Friend WithEvents GrpVoucher As System.Windows.Forms.GroupBox
    Friend WithEvents DtpVoucherToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CmbSearchVoucher As System.Windows.Forms.ComboBox
    Friend WithEvents DtpVoucherFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtSearchVoucherNo As System.Windows.Forms.TextBox
    Friend WithEvents GrpVoucherDetails As System.Windows.Forms.GroupBox
    Friend WithEvents LblTotalVoucher As System.Windows.Forms.Label
    Friend WithEvents LblTotalVoucherLbl As System.Windows.Forms.Label
    Friend WithEvents LblPaidAmount As System.Windows.Forms.Label
    Friend WithEvents LblTotalPaidAmountLbl As System.Windows.Forms.Label
    Friend WithEvents LblReceivedAmount As System.Windows.Forms.Label
    Friend WithEvents LblTotalReceivedAmountLbl As System.Windows.Forms.Label
    Friend WithEvents CmbSearchVoucherSubcategory As System.Windows.Forms.ComboBox
    Friend WithEvents CmbSearchVoucherPurpose As System.Windows.Forms.ComboBox
    Friend WithEvents CmbSearchVoucherCategory As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCustomerCategory As System.Windows.Forms.ComboBox
    Friend WithEvents GrpBankTransaction As System.Windows.Forms.GroupBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents CmbBankSearch As System.Windows.Forms.ComboBox
    Friend WithEvents CmbSeachBankNameBank As System.Windows.Forms.ComboBox
    Friend WithEvents TxtSearchCheckNoBank As System.Windows.Forms.TextBox
    Friend WithEvents GrpBankTransactionTotal As System.Windows.Forms.GroupBox
    Friend WithEvents LblTotalWithdraw As System.Windows.Forms.Label
    Friend WithEvents LblTotalWithdrawLbl As System.Windows.Forms.Label
    Friend WithEvents LblTotalPayment As System.Windows.Forms.Label
    Friend WithEvents LblTotalPaymentLbl As System.Windows.Forms.Label
    Friend WithEvents DtpBankToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DtpBankFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents LblTotalSaleAmount As System.Windows.Forms.Label
    Friend WithEvents lebel15 As System.Windows.Forms.Label
End Class
