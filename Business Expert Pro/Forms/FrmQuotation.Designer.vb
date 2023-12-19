<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQuotation
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
        Me.PnlQuotation = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.LblQuotation = New System.Windows.Forms.Label
        Me.LblCustomerName = New System.Windows.Forms.Label
        Me.LblPhoneNo = New System.Windows.Forms.Label
        Me.LblAddress = New System.Windows.Forms.Label
        Me.CmbCustomerName = New System.Windows.Forms.ComboBox
        Me.TxtPhoneNo = New System.Windows.Forms.TextBox
        Me.TxtAddress = New System.Windows.Forms.TextBox
        Me.LblVat = New System.Windows.Forms.Label
        Me.LblDiscount = New System.Windows.Forms.Label
        Me.LblTotalAmount = New System.Windows.Forms.Label
        Me.TxtVatPercentage = New System.Windows.Forms.TextBox
        Me.TxtTotal = New System.Windows.Forms.TextBox
        Me.TxtDiscountPercentage = New System.Windows.Forms.TextBox
        Me.TxtTotalAmount = New System.Windows.Forms.TextBox
        Me.TxtDiscount = New System.Windows.Forms.TextBox
        Me.TxtVat = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GrpCustomerInformation = New System.Windows.Forms.GroupBox
        Me.TxtCustomerDiscount = New System.Windows.Forms.TextBox
        Me.LblCustomerDiscount = New System.Windows.Forms.Label
        Me.BtnCustomerName = New System.Windows.Forms.Button
        Me.LblTotal = New System.Windows.Forms.Label
        Me.GrpPaymentInformation = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.BtnLastInvoice = New System.Windows.Forms.Button
        Me.DtpQuotationDate = New System.Windows.Forms.DateTimePicker
        Me.TxtQuotationInvoiceNo = New System.Windows.Forms.TextBox
        Me.lblQuotationInvoiceNo = New System.Windows.Forms.Label
        Me.TxtSearchBarcode = New System.Windows.Forms.TextBox
        Me.LblSearchBarcode = New System.Windows.Forms.Label
        Me.cmbProductName = New System.Windows.Forms.ComboBox
        Me.TxtSaleAmount = New System.Windows.Forms.TextBox
        Me.TxtQuotationUnitPrice = New System.Windows.Forms.TextBox
        Me.TxtQuantity = New System.Windows.Forms.TextBox
        Me.LblQuotationAmount = New System.Windows.Forms.Label
        Me.LblQuotationUnitPrice = New System.Windows.Forms.Label
        Me.LblQuantitylbl = New System.Windows.Forms.Label
        Me.LblProductName = New System.Windows.Forms.Label
        Me.LblSelectProduct = New System.Windows.Forms.GroupBox
        Me.LblWarrantyDays = New System.Windows.Forms.Label
        Me.TxtWarrantyDays = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblQuotationID = New System.Windows.Forms.Label
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.lblQuotationDate = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.GrdQuotation = New System.Windows.Forms.DataGridView
        Me.PnlQuotation.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GrpCustomerInformation.SuspendLayout()
        Me.GrpPaymentInformation.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.LblSelectProduct.SuspendLayout()
        CType(Me.GrdQuotation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlQuotation
        '
        Me.PnlQuotation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlQuotation.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlQuotation.Controls.Add(Me.Panel1)
        Me.PnlQuotation.Controls.Add(Me.LblQuotation)
        Me.PnlQuotation.Location = New System.Drawing.Point(-5, 0)
        Me.PnlQuotation.Name = "PnlQuotation"
        Me.PnlQuotation.Size = New System.Drawing.Size(1123, 90)
        Me.PnlQuotation.TabIndex = 113
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
        Me.Panel1.Size = New System.Drawing.Size(1122, 27)
        Me.Panel1.TabIndex = 2055
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(1098, 0)
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
        Me.Btnminimized.Location = New System.Drawing.Point(1038, 0)
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
        Me.Btnmaximized.Location = New System.Drawing.Point(1068, 0)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1160
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'LblQuotation
        '
        Me.LblQuotation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblQuotation.AutoSize = True
        Me.LblQuotation.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQuotation.ForeColor = System.Drawing.Color.White
        Me.LblQuotation.Location = New System.Drawing.Point(519, 34)
        Me.LblQuotation.Name = "LblQuotation"
        Me.LblQuotation.Size = New System.Drawing.Size(166, 37)
        Me.LblQuotation.TabIndex = 0
        Me.LblQuotation.Text = "Quotation"
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
        Me.CmbCustomerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbCustomerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
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
        Me.TxtPhoneNo.Size = New System.Drawing.Size(203, 20)
        Me.TxtPhoneNo.TabIndex = 102
        '
        'TxtAddress
        '
        Me.TxtAddress.Location = New System.Drawing.Point(129, 86)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(203, 20)
        Me.TxtAddress.TabIndex = 103
        '
        'LblVat
        '
        Me.LblVat.AutoSize = True
        Me.LblVat.Location = New System.Drawing.Point(18, 50)
        Me.LblVat.Name = "LblVat"
        Me.LblVat.Size = New System.Drawing.Size(26, 13)
        Me.LblVat.TabIndex = 131
        Me.LblVat.Text = "Vat:"
        '
        'LblDiscount
        '
        Me.LblDiscount.AutoSize = True
        Me.LblDiscount.Location = New System.Drawing.Point(18, 82)
        Me.LblDiscount.Name = "LblDiscount"
        Me.LblDiscount.Size = New System.Drawing.Size(52, 13)
        Me.LblDiscount.TabIndex = 132
        Me.LblDiscount.Text = "Discount:"
        '
        'LblTotalAmount
        '
        Me.LblTotalAmount.AutoSize = True
        Me.LblTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblTotalAmount.Location = New System.Drawing.Point(18, 143)
        Me.LblTotalAmount.Name = "LblTotalAmount"
        Me.LblTotalAmount.Size = New System.Drawing.Size(103, 16)
        Me.LblTotalAmount.TabIndex = 134
        Me.LblTotalAmount.Text = "Total Amount:"
        '
        'TxtVatPercentage
        '
        Me.TxtVatPercentage.Location = New System.Drawing.Point(50, 47)
        Me.TxtVatPercentage.Name = "TxtVatPercentage"
        Me.TxtVatPercentage.Size = New System.Drawing.Size(20, 20)
        Me.TxtVatPercentage.TabIndex = 108
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(126, 21)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(100, 20)
        Me.TxtTotal.TabIndex = 105
        '
        'TxtDiscountPercentage
        '
        Me.TxtDiscountPercentage.Location = New System.Drawing.Point(70, 79)
        Me.TxtDiscountPercentage.Name = "TxtDiscountPercentage"
        Me.TxtDiscountPercentage.Size = New System.Drawing.Size(20, 20)
        Me.TxtDiscountPercentage.TabIndex = 110
        '
        'TxtTotalAmount
        '
        Me.TxtTotalAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TxtTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalAmount.ForeColor = System.Drawing.Color.White
        Me.TxtTotalAmount.Location = New System.Drawing.Point(126, 140)
        Me.TxtTotalAmount.Name = "TxtTotalAmount"
        Me.TxtTotalAmount.Size = New System.Drawing.Size(100, 24)
        Me.TxtTotalAmount.TabIndex = 113
        '
        'TxtDiscount
        '
        Me.TxtDiscount.Location = New System.Drawing.Point(126, 79)
        Me.TxtDiscount.Name = "TxtDiscount"
        Me.TxtDiscount.Size = New System.Drawing.Size(100, 20)
        Me.TxtDiscount.TabIndex = 111
        '
        'TxtVat
        '
        Me.TxtVat.Location = New System.Drawing.Point(126, 47)
        Me.TxtVat.Name = "TxtVat"
        Me.TxtVat.Size = New System.Drawing.Size(100, 20)
        Me.TxtVat.TabIndex = 109
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(78, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 16)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "%"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(90, 81)
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
        Me.GrpCustomerInformation.Location = New System.Drawing.Point(12, 98)
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
        Me.BtnCustomerName.Location = New System.Drawing.Point(390, 25)
        Me.BtnCustomerName.Name = "BtnCustomerName"
        Me.BtnCustomerName.Size = New System.Drawing.Size(23, 22)
        Me.BtnCustomerName.TabIndex = 1
        Me.BtnCustomerName.UseVisualStyleBackColor = True
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(18, 24)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(34, 13)
        Me.LblTotal.TabIndex = 128
        Me.LblTotal.Text = "Total:"
        '
        'GrpPaymentInformation
        '
        Me.GrpPaymentInformation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpPaymentInformation.Controls.Add(Me.Label2)
        Me.GrpPaymentInformation.Controls.Add(Me.TxtVat)
        Me.GrpPaymentInformation.Controls.Add(Me.TxtDiscount)
        Me.GrpPaymentInformation.Controls.Add(Me.TxtTotalAmount)
        Me.GrpPaymentInformation.Controls.Add(Me.TxtDiscountPercentage)
        Me.GrpPaymentInformation.Controls.Add(Me.TxtTotal)
        Me.GrpPaymentInformation.Controls.Add(Me.TxtVatPercentage)
        Me.GrpPaymentInformation.Controls.Add(Me.LblTotalAmount)
        Me.GrpPaymentInformation.Controls.Add(Me.LblDiscount)
        Me.GrpPaymentInformation.Controls.Add(Me.Label1)
        Me.GrpPaymentInformation.Controls.Add(Me.LblVat)
        Me.GrpPaymentInformation.Controls.Add(Me.LblTotal)
        Me.GrpPaymentInformation.Location = New System.Drawing.Point(859, 364)
        Me.GrpPaymentInformation.Name = "GrpPaymentInformation"
        Me.GrpPaymentInformation.Size = New System.Drawing.Size(240, 220)
        Me.GrpPaymentInformation.TabIndex = 1002
        Me.GrpPaymentInformation.TabStop = False
        Me.GrpPaymentInformation.Text = "Payment Information"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.BtnSave)
        Me.GroupBox1.Controls.Add(Me.BtnPrint)
        Me.GroupBox1.Controls.Add(Me.BtnLastInvoice)
        Me.GroupBox1.Location = New System.Drawing.Point(848, 595)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(251, 80)
        Me.GroupBox1.TabIndex = 1003
        Me.GroupBox1.TabStop = False
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Image = Global.Business_Expert_Pro.My.Resources.Resources.Save_32px_32
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
        'BtnLastInvoice
        '
        Me.BtnLastInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnLastInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLastInvoice.Image = Global.Business_Expert_Pro.My.Resources.Resources.Last_view1
        Me.BtnLastInvoice.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnLastInvoice.Location = New System.Drawing.Point(167, 11)
        Me.BtnLastInvoice.Name = "BtnLastInvoice"
        Me.BtnLastInvoice.Size = New System.Drawing.Size(78, 61)
        Me.BtnLastInvoice.TabIndex = 2009
        Me.BtnLastInvoice.Text = "Last Invoice"
        Me.BtnLastInvoice.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnLastInvoice.UseVisualStyleBackColor = True
        '
        'DtpQuotationDate
        '
        Me.DtpQuotationDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtpQuotationDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpQuotationDate.Location = New System.Drawing.Point(886, 131)
        Me.DtpQuotationDate.Name = "DtpQuotationDate"
        Me.DtpQuotationDate.Size = New System.Drawing.Size(129, 20)
        Me.DtpQuotationDate.TabIndex = 1004
        Me.DtpQuotationDate.Value = New Date(2017, 7, 28, 23, 26, 50, 0)
        '
        'TxtQuotationInvoiceNo
        '
        Me.TxtQuotationInvoiceNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtQuotationInvoiceNo.Location = New System.Drawing.Point(886, 103)
        Me.TxtQuotationInvoiceNo.Name = "TxtQuotationInvoiceNo"
        Me.TxtQuotationInvoiceNo.ReadOnly = True
        Me.TxtQuotationInvoiceNo.Size = New System.Drawing.Size(213, 20)
        Me.TxtQuotationInvoiceNo.TabIndex = 1005
        '
        'lblQuotationInvoiceNo
        '
        Me.lblQuotationInvoiceNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuotationInvoiceNo.AutoSize = True
        Me.lblQuotationInvoiceNo.Location = New System.Drawing.Point(767, 106)
        Me.lblQuotationInvoiceNo.Name = "lblQuotationInvoiceNo"
        Me.lblQuotationInvoiceNo.Size = New System.Drawing.Size(111, 13)
        Me.lblQuotationInvoiceNo.TabIndex = 1006
        Me.lblQuotationInvoiceNo.Text = "Quotation Invoice No:"
        '
        'TxtSearchBarcode
        '
        Me.TxtSearchBarcode.Location = New System.Drawing.Point(141, 256)
        Me.TxtSearchBarcode.Name = "TxtSearchBarcode"
        Me.TxtSearchBarcode.Size = New System.Drawing.Size(202, 20)
        Me.TxtSearchBarcode.TabIndex = 1007
        '
        'LblSearchBarcode
        '
        Me.LblSearchBarcode.AutoSize = True
        Me.LblSearchBarcode.Location = New System.Drawing.Point(31, 259)
        Me.LblSearchBarcode.Name = "LblSearchBarcode"
        Me.LblSearchBarcode.Size = New System.Drawing.Size(87, 13)
        Me.LblSearchBarcode.TabIndex = 1008
        Me.LblSearchBarcode.Text = "Search Barcode:"
        '
        'cmbProductName
        '
        Me.cmbProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbProductName.FormattingEnabled = True
        Me.cmbProductName.Location = New System.Drawing.Point(8, 30)
        Me.cmbProductName.Name = "cmbProductName"
        Me.cmbProductName.Size = New System.Drawing.Size(353, 21)
        Me.cmbProductName.TabIndex = 1010
        '
        'TxtSaleAmount
        '
        Me.TxtSaleAmount.Location = New System.Drawing.Point(714, 30)
        Me.TxtSaleAmount.Name = "TxtSaleAmount"
        Me.TxtSaleAmount.Size = New System.Drawing.Size(89, 20)
        Me.TxtSaleAmount.TabIndex = 1014
        '
        'TxtQuotationUnitPrice
        '
        Me.TxtQuotationUnitPrice.Location = New System.Drawing.Point(600, 30)
        Me.TxtQuotationUnitPrice.Name = "TxtQuotationUnitPrice"
        Me.TxtQuotationUnitPrice.Size = New System.Drawing.Size(103, 20)
        Me.TxtQuotationUnitPrice.TabIndex = 1013
        '
        'TxtQuantity
        '
        Me.TxtQuantity.Location = New System.Drawing.Point(372, 30)
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.Size = New System.Drawing.Size(103, 20)
        Me.TxtQuantity.TabIndex = 1011
        '
        'LblQuotationAmount
        '
        Me.LblQuotationAmount.AutoSize = True
        Me.LblQuotationAmount.Location = New System.Drawing.Point(735, 12)
        Me.LblQuotationAmount.Name = "LblQuotationAmount"
        Me.LblQuotationAmount.Size = New System.Drawing.Size(46, 13)
        Me.LblQuotationAmount.TabIndex = 1015
        Me.LblQuotationAmount.Text = "Amount:"
        '
        'LblQuotationUnitPrice
        '
        Me.LblQuotationUnitPrice.AutoSize = True
        Me.LblQuotationUnitPrice.Location = New System.Drawing.Point(623, 12)
        Me.LblQuotationUnitPrice.Name = "LblQuotationUnitPrice"
        Me.LblQuotationUnitPrice.Size = New System.Drawing.Size(56, 13)
        Me.LblQuotationUnitPrice.TabIndex = 1016
        Me.LblQuotationUnitPrice.Text = "Unit Price:"
        '
        'LblQuantitylbl
        '
        Me.LblQuantitylbl.AutoSize = True
        Me.LblQuantitylbl.Location = New System.Drawing.Point(399, 11)
        Me.LblQuantitylbl.Name = "LblQuantitylbl"
        Me.LblQuantitylbl.Size = New System.Drawing.Size(49, 13)
        Me.LblQuantitylbl.TabIndex = 1017
        Me.LblQuantitylbl.Text = "Quantity:"
        '
        'LblProductName
        '
        Me.LblProductName.AutoSize = True
        Me.LblProductName.Location = New System.Drawing.Point(145, 13)
        Me.LblProductName.Name = "LblProductName"
        Me.LblProductName.Size = New System.Drawing.Size(78, 13)
        Me.LblProductName.TabIndex = 1018
        Me.LblProductName.Text = "Product Name:"
        '
        'LblSelectProduct
        '
        Me.LblSelectProduct.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblSelectProduct.Controls.Add(Me.LblWarrantyDays)
        Me.LblSelectProduct.Controls.Add(Me.TxtWarrantyDays)
        Me.LblSelectProduct.Controls.Add(Me.LblProductName)
        Me.LblSelectProduct.Controls.Add(Me.LblQuantitylbl)
        Me.LblSelectProduct.Controls.Add(Me.LblQuotationUnitPrice)
        Me.LblSelectProduct.Controls.Add(Me.LblQuotationAmount)
        Me.LblSelectProduct.Controls.Add(Me.TxtQuantity)
        Me.LblSelectProduct.Controls.Add(Me.TxtQuotationUnitPrice)
        Me.LblSelectProduct.Controls.Add(Me.TxtSaleAmount)
        Me.LblSelectProduct.Controls.Add(Me.cmbProductName)
        Me.LblSelectProduct.Location = New System.Drawing.Point(13, 278)
        Me.LblSelectProduct.Name = "LblSelectProduct"
        Me.LblSelectProduct.Size = New System.Drawing.Size(824, 63)
        Me.LblSelectProduct.TabIndex = 1019
        Me.LblSelectProduct.TabStop = False
        '
        'LblWarrantyDays
        '
        Me.LblWarrantyDays.AutoSize = True
        Me.LblWarrantyDays.Location = New System.Drawing.Point(497, 11)
        Me.LblWarrantyDays.Name = "LblWarrantyDays"
        Me.LblWarrantyDays.Size = New System.Drawing.Size(80, 13)
        Me.LblWarrantyDays.TabIndex = 1020
        Me.LblWarrantyDays.Text = "Warranty Days:"
        '
        'TxtWarrantyDays
        '
        Me.TxtWarrantyDays.Location = New System.Drawing.Point(486, 30)
        Me.TxtWarrantyDays.Name = "TxtWarrantyDays"
        Me.TxtWarrantyDays.Size = New System.Drawing.Size(103, 20)
        Me.TxtWarrantyDays.TabIndex = 1012
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 680)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 2021
        Me.Label4.Text = "Quantity:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(709, 680)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 2023
        Me.Label5.Text = "Quotation ID:"
        '
        'lblQuotationID
        '
        Me.lblQuotationID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuotationID.AutoSize = True
        Me.lblQuotationID.Location = New System.Drawing.Point(785, 680)
        Me.lblQuotationID.Name = "lblQuotationID"
        Me.lblQuotationID.Size = New System.Drawing.Size(19, 13)
        Me.lblQuotationID.TabIndex = 2022
        Me.lblQuotationID.Text = "00"
        '
        'BtnDelete
        '
        Me.BtnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Location = New System.Drawing.Point(728, 250)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(108, 30)
        Me.BtnDelete.TabIndex = 2024
        Me.BtnDelete.Text = "Delete Invoice"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'lblQuotationDate
        '
        Me.lblQuotationDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuotationDate.AutoSize = True
        Me.lblQuotationDate.Location = New System.Drawing.Point(767, 135)
        Me.lblQuotationDate.Name = "lblQuotationDate"
        Me.lblQuotationDate.Size = New System.Drawing.Size(82, 13)
        Me.lblQuotationDate.TabIndex = 2031
        Me.lblQuotationDate.Text = "Quotation Date:"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(247, 680)
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
        Me.Label14.Location = New System.Drawing.Point(341, 680)
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
        Me.Label11.Location = New System.Drawing.Point(121, 680)
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
        Me.Label12.Location = New System.Drawing.Point(466, 680)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 16)
        Me.Label12.TabIndex = 2036
        Me.Label12.Text = "Delete: Click 2X"
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(614, 250)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 30)
        Me.Button3.TabIndex = 2040
        Me.Button3.Text = "Quotation History"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(499, 250)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 30)
        Me.Button2.TabIndex = 2041
        Me.Button2.Text = "New Invoice"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GrdQuotation
        '
        Me.GrdQuotation.AllowUserToAddRows = False
        Me.GrdQuotation.AllowUserToDeleteRows = False
        Me.GrdQuotation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdQuotation.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdQuotation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdQuotation.Location = New System.Drawing.Point(13, 359)
        Me.GrdQuotation.Name = "GrdQuotation"
        Me.GrdQuotation.ReadOnly = True
        Me.GrdQuotation.Size = New System.Drawing.Size(824, 316)
        Me.GrdQuotation.TabIndex = 2042
        '
        'FrmQuotation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1119, 700)
        Me.Controls.Add(Me.GrdQuotation)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblQuotationDate)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblQuotationID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LblSelectProduct)
        Me.Controls.Add(Me.LblSearchBarcode)
        Me.Controls.Add(Me.TxtSearchBarcode)
        Me.Controls.Add(Me.lblQuotationInvoiceNo)
        Me.Controls.Add(Me.TxtQuotationInvoiceNo)
        Me.Controls.Add(Me.DtpQuotationDate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GrpPaymentInformation)
        Me.Controls.Add(Me.GrpCustomerInformation)
        Me.Controls.Add(Me.PnlQuotation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmQuotation"
        Me.Text = "Quotations"
        Me.PnlQuotation.ResumeLayout(False)
        Me.PnlQuotation.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GrpCustomerInformation.ResumeLayout(False)
        Me.GrpCustomerInformation.PerformLayout()
        Me.GrpPaymentInformation.ResumeLayout(False)
        Me.GrpPaymentInformation.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.LblSelectProduct.ResumeLayout(False)
        Me.LblSelectProduct.PerformLayout()
        CType(Me.GrdQuotation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PnlQuotation As System.Windows.Forms.Panel
    Friend WithEvents LblQuotation As System.Windows.Forms.Label
    Friend WithEvents LblCustomerName As System.Windows.Forms.Label
    Friend WithEvents LblPhoneNo As System.Windows.Forms.Label
    Friend WithEvents LblAddress As System.Windows.Forms.Label
    Friend WithEvents CmbCustomerName As System.Windows.Forms.ComboBox
    Friend WithEvents TxtPhoneNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtAddress As System.Windows.Forms.TextBox
    Friend WithEvents LblVat As System.Windows.Forms.Label
    Friend WithEvents LblDiscount As System.Windows.Forms.Label
    Friend WithEvents LblTotalAmount As System.Windows.Forms.Label
    Friend WithEvents TxtVatPercentage As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents TxtDiscountPercentage As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents TxtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents TxtVat As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GrpCustomerInformation As System.Windows.Forms.GroupBox
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents GrpPaymentInformation As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCustomerName As System.Windows.Forms.Button
    Friend WithEvents TxtCustomerDiscount As System.Windows.Forms.TextBox
    Friend WithEvents LblCustomerDiscount As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnLastInvoice As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents DtpQuotationDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtQuotationInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents lblQuotationInvoiceNo As System.Windows.Forms.Label
    Friend WithEvents TxtSearchBarcode As System.Windows.Forms.TextBox
    Friend WithEvents LblSearchBarcode As System.Windows.Forms.Label
    Friend WithEvents cmbProductName As System.Windows.Forms.ComboBox
    Friend WithEvents TxtSaleAmount As System.Windows.Forms.TextBox
    Friend WithEvents TxtQuotationUnitPrice As System.Windows.Forms.TextBox
    Friend WithEvents TxtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents LblQuotationAmount As System.Windows.Forms.Label
    Friend WithEvents LblQuotationUnitPrice As System.Windows.Forms.Label
    Friend WithEvents LblQuantitylbl As System.Windows.Forms.Label
    Friend WithEvents LblProductName As System.Windows.Forms.Label
    Friend WithEvents LblSelectProduct As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblQuotationID As System.Windows.Forms.Label
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents lblQuotationDate As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LblWarrantyDays As System.Windows.Forms.Label
    Friend WithEvents TxtWarrantyDays As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
    Friend WithEvents GrdQuotation As System.Windows.Forms.DataGridView
End Class
