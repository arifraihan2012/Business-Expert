<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSale
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
        Me.PnlSale = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.LblSale = New System.Windows.Forms.Label
        Me.LblCustomerName = New System.Windows.Forms.Label
        Me.LblPhoneNo = New System.Windows.Forms.Label
        Me.LblAddress = New System.Windows.Forms.Label
        Me.CmbCustomerName = New System.Windows.Forms.ComboBox
        Me.TxtPhoneNo = New System.Windows.Forms.TextBox
        Me.TxtAddress = New System.Windows.Forms.TextBox
        Me.LblPreviousDues = New System.Windows.Forms.Label
        Me.LblVat = New System.Windows.Forms.Label
        Me.LblDiscount = New System.Windows.Forms.Label
        Me.LblNetPayable = New System.Windows.Forms.Label
        Me.LblPaidAmount = New System.Windows.Forms.Label
        Me.LblReturnAmount = New System.Windows.Forms.Label
        Me.LblBalance = New System.Windows.Forms.Label
        Me.TxtAdvance = New System.Windows.Forms.TextBox
        Me.TxtPreviousDues = New System.Windows.Forms.TextBox
        Me.TxtVatPercentage = New System.Windows.Forms.TextBox
        Me.TxtTotal = New System.Windows.Forms.TextBox
        Me.TxtDiscountPercentage = New System.Windows.Forms.TextBox
        Me.TxtReturnAmount = New System.Windows.Forms.TextBox
        Me.TxtBalance = New System.Windows.Forms.TextBox
        Me.TxtPaidAmount = New System.Windows.Forms.TextBox
        Me.TxtNetPayable = New System.Windows.Forms.TextBox
        Me.TxtDiscount = New System.Windows.Forms.TextBox
        Me.TxtVat = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GrpCustomerInformation = New System.Windows.Forms.GroupBox
        Me.TxtCustomerDiscount = New System.Windows.Forms.TextBox
        Me.LblCustomerDiscount = New System.Windows.Forms.Label
        Me.BtnCustomerName = New System.Windows.Forms.Button
        Me.GrdCustomerList = New System.Windows.Forms.DataGridView
        Me.LblPaidBy = New System.Windows.Forms.Label
        Me.GrdSale = New System.Windows.Forms.DataGridView
        Me.LblTotal = New System.Windows.Forms.Label
        Me.LblAdvance = New System.Windows.Forms.Label
        Me.GrpPaymentInformation = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbPaidBy = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.BtnInvoice = New System.Windows.Forms.Button
        Me.DtpSaleDate = New System.Windows.Forms.DateTimePicker
        Me.TxtSaleInvoiceNo = New System.Windows.Forms.TextBox
        Me.lblInvoiceNo = New System.Windows.Forms.Label
        Me.TxtSearchBarcode = New System.Windows.Forms.TextBox
        Me.LblSearchBarcode = New System.Windows.Forms.Label
        Me.cmbProductName = New System.Windows.Forms.ComboBox
        Me.TxtSaleAmount = New System.Windows.Forms.TextBox
        Me.TxtSaleUnitPrice = New System.Windows.Forms.TextBox
        Me.TxtQuantity = New System.Windows.Forms.TextBox
        Me.LblSaleAmount = New System.Windows.Forms.Label
        Me.LblSaleUnitPrice = New System.Windows.Forms.Label
        Me.LblQuantitylbl = New System.Windows.Forms.Label
        Me.LblProductName = New System.Windows.Forms.Label
        Me.LblSelectProduct = New System.Windows.Forms.GroupBox
        Me.GrdSerialNumber = New System.Windows.Forms.DataGridView
        Me.LblDiscountAmount = New System.Windows.Forms.Label
        Me.TxtDiscountAmount = New System.Windows.Forms.TextBox
        Me.TxtUnitDiscount = New System.Windows.Forms.TextBox
        Me.LblProductDiscount = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxtBonus = New System.Windows.Forms.TextBox
        Me.CmbSerialNumber = New System.Windows.Forms.ComboBox
        Me.TxtWarrantyDays = New System.Windows.Forms.TextBox
        Me.LblWarrantyDays = New System.Windows.Forms.Label
        Me.LblStatus = New System.Windows.Forms.Label
        Me.TxtFromSerial = New System.Windows.Forms.TextBox
        Me.TxtToSerial = New System.Windows.Forms.TextBox
        Me.RdbRangeSerial = New System.Windows.Forms.RadioButton
        Me.LblTo = New System.Windows.Forms.Label
        Me.LblSingleSerialNumber = New System.Windows.Forms.Label
        Me.LblFrom = New System.Windows.Forms.Label
        Me.TxtPurchaseID = New System.Windows.Forms.TextBox
        Me.LblPurchaseID = New System.Windows.Forms.Label
        Me.LblLastSoldPrice = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GrdProductList = New System.Windows.Forms.DataGridView
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtRemarks = New System.Windows.Forms.TextBox
        Me.lblQuantityAvailable = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblSaleID = New System.Windows.Forms.Label
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.lblsaleDate = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.BtnSaleHistory = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.GrdAvailableSerialNumber = New System.Windows.Forms.DataGridView
        Me.lblTotalQuantityAvailable = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtNetPayableLarge = New System.Windows.Forms.TextBox
        Me.PnlSale.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GrpCustomerInformation.SuspendLayout()
        CType(Me.GrdCustomerList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdSale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpPaymentInformation.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.LblSelectProduct.SuspendLayout()
        CType(Me.GrdSerialNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdProductList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdAvailableSerialNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlSale
        '
        Me.PnlSale.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlSale.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlSale.Controls.Add(Me.Panel2)
        Me.PnlSale.Controls.Add(Me.LblSale)
        Me.PnlSale.Location = New System.Drawing.Point(0, 0)
        Me.PnlSale.Name = "PnlSale"
        Me.PnlSale.Size = New System.Drawing.Size(1193, 61)
        Me.PnlSale.TabIndex = 113
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Btnclose)
        Me.Panel2.Controls.Add(Me.Btnminimized)
        Me.Panel2.Controls.Add(Me.Btnmaximized)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1183, 27)
        Me.Panel2.TabIndex = 2062
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(1159, 0)
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
        Me.Btnminimized.Location = New System.Drawing.Point(1099, 0)
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
        Me.Btnmaximized.Location = New System.Drawing.Point(1129, 0)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1160
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'LblSale
        '
        Me.LblSale.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblSale.AutoSize = True
        Me.LblSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSale.ForeColor = System.Drawing.Color.White
        Me.LblSale.Location = New System.Drawing.Point(546, 24)
        Me.LblSale.Name = "LblSale"
        Me.LblSale.Size = New System.Drawing.Size(84, 37)
        Me.LblSale.TabIndex = 0
        Me.LblSale.Text = "Sale"
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
        Me.LblPhoneNo.Location = New System.Drawing.Point(18, 65)
        Me.LblPhoneNo.Name = "LblPhoneNo"
        Me.LblPhoneNo.Size = New System.Drawing.Size(58, 13)
        Me.LblPhoneNo.TabIndex = 115
        Me.LblPhoneNo.Text = "Phone No:"
        '
        'LblAddress
        '
        Me.LblAddress.AutoSize = True
        Me.LblAddress.Location = New System.Drawing.Point(18, 96)
        Me.LblAddress.Name = "LblAddress"
        Me.LblAddress.Size = New System.Drawing.Size(48, 13)
        Me.LblAddress.TabIndex = 116
        Me.LblAddress.Text = "Address:"
        '
        'CmbCustomerName
        '
        Me.CmbCustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbCustomerName.FormattingEnabled = True
        Me.CmbCustomerName.Location = New System.Drawing.Point(129, 25)
        Me.CmbCustomerName.Name = "CmbCustomerName"
        Me.CmbCustomerName.Size = New System.Drawing.Size(245, 21)
        Me.CmbCustomerName.TabIndex = 101
        '
        'TxtPhoneNo
        '
        Me.TxtPhoneNo.Location = New System.Drawing.Point(128, 62)
        Me.TxtPhoneNo.Name = "TxtPhoneNo"
        Me.TxtPhoneNo.Size = New System.Drawing.Size(203, 20)
        Me.TxtPhoneNo.TabIndex = 102
        '
        'TxtAddress
        '
        Me.TxtAddress.Location = New System.Drawing.Point(128, 92)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(203, 20)
        Me.TxtAddress.TabIndex = 103
        '
        'LblPreviousDues
        '
        Me.LblPreviousDues.AutoSize = True
        Me.LblPreviousDues.Location = New System.Drawing.Point(4, 56)
        Me.LblPreviousDues.Name = "LblPreviousDues"
        Me.LblPreviousDues.Size = New System.Drawing.Size(79, 13)
        Me.LblPreviousDues.TabIndex = 129
        Me.LblPreviousDues.Text = "Previous Dues:"
        '
        'LblVat
        '
        Me.LblVat.AutoSize = True
        Me.LblVat.Location = New System.Drawing.Point(4, 120)
        Me.LblVat.Name = "LblVat"
        Me.LblVat.Size = New System.Drawing.Size(26, 13)
        Me.LblVat.TabIndex = 131
        Me.LblVat.Text = "Vat:"
        '
        'LblDiscount
        '
        Me.LblDiscount.AutoSize = True
        Me.LblDiscount.Location = New System.Drawing.Point(4, 152)
        Me.LblDiscount.Name = "LblDiscount"
        Me.LblDiscount.Size = New System.Drawing.Size(52, 13)
        Me.LblDiscount.TabIndex = 132
        Me.LblDiscount.Text = "Discount:"
        '
        'LblNetPayable
        '
        Me.LblNetPayable.AutoSize = True
        Me.LblNetPayable.Location = New System.Drawing.Point(4, 184)
        Me.LblNetPayable.Name = "LblNetPayable"
        Me.LblNetPayable.Size = New System.Drawing.Size(68, 13)
        Me.LblNetPayable.TabIndex = 133
        Me.LblNetPayable.Text = "Net Payable:"
        '
        'LblPaidAmount
        '
        Me.LblPaidAmount.AutoSize = True
        Me.LblPaidAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPaidAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblPaidAmount.Location = New System.Drawing.Point(4, 217)
        Me.LblPaidAmount.Name = "LblPaidAmount"
        Me.LblPaidAmount.Size = New System.Drawing.Size(99, 16)
        Me.LblPaidAmount.TabIndex = 134
        Me.LblPaidAmount.Text = "Paid Amount:"
        '
        'LblReturnAmount
        '
        Me.LblReturnAmount.AutoSize = True
        Me.LblReturnAmount.Location = New System.Drawing.Point(4, 328)
        Me.LblReturnAmount.Name = "LblReturnAmount"
        Me.LblReturnAmount.Size = New System.Drawing.Size(81, 13)
        Me.LblReturnAmount.TabIndex = 135
        Me.LblReturnAmount.Text = "Return Amount:"
        '
        'LblBalance
        '
        Me.LblBalance.AutoSize = True
        Me.LblBalance.Location = New System.Drawing.Point(4, 256)
        Me.LblBalance.Name = "LblBalance"
        Me.LblBalance.Size = New System.Drawing.Size(49, 13)
        Me.LblBalance.TabIndex = 136
        Me.LblBalance.Text = "Balance:"
        '
        'TxtAdvance
        '
        Me.TxtAdvance.Location = New System.Drawing.Point(115, 85)
        Me.TxtAdvance.Name = "TxtAdvance"
        Me.TxtAdvance.ReadOnly = True
        Me.TxtAdvance.Size = New System.Drawing.Size(100, 20)
        Me.TxtAdvance.TabIndex = 107
        '
        'TxtPreviousDues
        '
        Me.TxtPreviousDues.Location = New System.Drawing.Point(115, 53)
        Me.TxtPreviousDues.Name = "TxtPreviousDues"
        Me.TxtPreviousDues.ReadOnly = True
        Me.TxtPreviousDues.Size = New System.Drawing.Size(100, 20)
        Me.TxtPreviousDues.TabIndex = 106
        '
        'TxtVatPercentage
        '
        Me.TxtVatPercentage.Location = New System.Drawing.Point(36, 117)
        Me.TxtVatPercentage.Name = "TxtVatPercentage"
        Me.TxtVatPercentage.Size = New System.Drawing.Size(20, 20)
        Me.TxtVatPercentage.TabIndex = 108
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(115, 21)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(100, 20)
        Me.TxtTotal.TabIndex = 105
        '
        'TxtDiscountPercentage
        '
        Me.TxtDiscountPercentage.Location = New System.Drawing.Point(56, 149)
        Me.TxtDiscountPercentage.Name = "TxtDiscountPercentage"
        Me.TxtDiscountPercentage.Size = New System.Drawing.Size(20, 20)
        Me.TxtDiscountPercentage.TabIndex = 110
        '
        'TxtReturnAmount
        '
        Me.TxtReturnAmount.BackColor = System.Drawing.Color.OrangeRed
        Me.TxtReturnAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReturnAmount.ForeColor = System.Drawing.Color.White
        Me.TxtReturnAmount.Location = New System.Drawing.Point(115, 325)
        Me.TxtReturnAmount.Name = "TxtReturnAmount"
        Me.TxtReturnAmount.ReadOnly = True
        Me.TxtReturnAmount.Size = New System.Drawing.Size(100, 24)
        Me.TxtReturnAmount.TabIndex = 116
        '
        'TxtBalance
        '
        Me.TxtBalance.BackColor = System.Drawing.Color.White
        Me.TxtBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.TxtBalance.ForeColor = System.Drawing.Color.Black
        Me.TxtBalance.Location = New System.Drawing.Point(115, 252)
        Me.TxtBalance.Name = "TxtBalance"
        Me.TxtBalance.ReadOnly = True
        Me.TxtBalance.Size = New System.Drawing.Size(100, 24)
        Me.TxtBalance.TabIndex = 114
        '
        'TxtPaidAmount
        '
        Me.TxtPaidAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.TxtPaidAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPaidAmount.ForeColor = System.Drawing.Color.White
        Me.TxtPaidAmount.Location = New System.Drawing.Point(115, 214)
        Me.TxtPaidAmount.Name = "TxtPaidAmount"
        Me.TxtPaidAmount.Size = New System.Drawing.Size(100, 24)
        Me.TxtPaidAmount.TabIndex = 113
        '
        'TxtNetPayable
        '
        Me.TxtNetPayable.Location = New System.Drawing.Point(115, 181)
        Me.TxtNetPayable.Name = "TxtNetPayable"
        Me.TxtNetPayable.ReadOnly = True
        Me.TxtNetPayable.Size = New System.Drawing.Size(100, 20)
        Me.TxtNetPayable.TabIndex = 112
        '
        'TxtDiscount
        '
        Me.TxtDiscount.Location = New System.Drawing.Point(115, 149)
        Me.TxtDiscount.Name = "TxtDiscount"
        Me.TxtDiscount.Size = New System.Drawing.Size(100, 20)
        Me.TxtDiscount.TabIndex = 111
        '
        'TxtVat
        '
        Me.TxtVat.Location = New System.Drawing.Point(115, 117)
        Me.TxtVat.Name = "TxtVat"
        Me.TxtVat.Size = New System.Drawing.Size(100, 20)
        Me.TxtVat.TabIndex = 109
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 16)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "%"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(76, 151)
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
        Me.GrpCustomerInformation.Size = New System.Drawing.Size(468, 128)
        Me.GrpCustomerInformation.TabIndex = 1001
        Me.GrpCustomerInformation.TabStop = False
        Me.GrpCustomerInformation.Text = "Customer Information"
        '
        'TxtCustomerDiscount
        '
        Me.TxtCustomerDiscount.Location = New System.Drawing.Point(371, 93)
        Me.TxtCustomerDiscount.Name = "TxtCustomerDiscount"
        Me.TxtCustomerDiscount.Size = New System.Drawing.Size(63, 20)
        Me.TxtCustomerDiscount.TabIndex = 104
        Me.TxtCustomerDiscount.Visible = False
        '
        'LblCustomerDiscount
        '
        Me.LblCustomerDiscount.AutoSize = True
        Me.LblCustomerDiscount.Location = New System.Drawing.Point(360, 77)
        Me.LblCustomerDiscount.Name = "LblCustomerDiscount"
        Me.LblCustomerDiscount.Size = New System.Drawing.Size(99, 13)
        Me.LblCustomerDiscount.TabIndex = 163
        Me.LblCustomerDiscount.Text = "Customer Discount:"
        Me.LblCustomerDiscount.Visible = False
        '
        'BtnCustomerName
        '
        Me.BtnCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnCustomerName.BackgroundImage = Global.Business_Expert_Pro.My.Resources.Resources.newButton
        Me.BtnCustomerName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCustomerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCustomerName.Location = New System.Drawing.Point(388, 25)
        Me.BtnCustomerName.Name = "BtnCustomerName"
        Me.BtnCustomerName.Size = New System.Drawing.Size(23, 22)
        Me.BtnCustomerName.TabIndex = 1
        Me.BtnCustomerName.UseVisualStyleBackColor = True
        '
        'GrdCustomerList
        '
        Me.GrdCustomerList.AllowUserToAddRows = False
        Me.GrdCustomerList.AllowUserToDeleteRows = False
        Me.GrdCustomerList.BackgroundColor = System.Drawing.Color.White
        Me.GrdCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdCustomerList.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GrdCustomerList.Location = New System.Drawing.Point(141, 107)
        Me.GrdCustomerList.Name = "GrdCustomerList"
        Me.GrdCustomerList.ReadOnly = True
        Me.GrdCustomerList.Size = New System.Drawing.Size(245, 10)
        Me.GrdCustomerList.TabIndex = 2055
        Me.GrdCustomerList.Visible = False
        '
        'LblPaidBy
        '
        Me.LblPaidBy.AutoSize = True
        Me.LblPaidBy.Location = New System.Drawing.Point(4, 292)
        Me.LblPaidBy.Name = "LblPaidBy"
        Me.LblPaidBy.Size = New System.Drawing.Size(46, 13)
        Me.LblPaidBy.TabIndex = 154
        Me.LblPaidBy.Text = "Paid By:"
        '
        'GrdSale
        '
        Me.GrdSale.AllowUserToAddRows = False
        Me.GrdSale.AllowUserToDeleteRows = False
        Me.GrdSale.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdSale.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GrdSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdSale.Location = New System.Drawing.Point(227, 360)
        Me.GrdSale.Name = "GrdSale"
        Me.GrdSale.ReadOnly = True
        Me.GrdSale.Size = New System.Drawing.Size(691, 347)
        Me.GrdSale.TabIndex = 156
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(4, 24)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(34, 13)
        Me.LblTotal.TabIndex = 128
        Me.LblTotal.Text = "Total:"
        '
        'LblAdvance
        '
        Me.LblAdvance.AutoSize = True
        Me.LblAdvance.Location = New System.Drawing.Point(4, 88)
        Me.LblAdvance.Name = "LblAdvance"
        Me.LblAdvance.Size = New System.Drawing.Size(53, 13)
        Me.LblAdvance.TabIndex = 130
        Me.LblAdvance.Text = "Advance:"
        '
        'GrpPaymentInformation
        '
        Me.GrpPaymentInformation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpPaymentInformation.Controls.Add(Me.Label6)
        Me.GrpPaymentInformation.Controls.Add(Me.Label3)
        Me.GrpPaymentInformation.Controls.Add(Me.cmbPaidBy)
        Me.GrpPaymentInformation.Controls.Add(Me.LblPaidBy)
        Me.GrpPaymentInformation.Controls.Add(Me.Label2)
        Me.GrpPaymentInformation.Controls.Add(Me.TxtVat)
        Me.GrpPaymentInformation.Controls.Add(Me.TxtDiscount)
        Me.GrpPaymentInformation.Controls.Add(Me.TxtNetPayable)
        Me.GrpPaymentInformation.Controls.Add(Me.TxtPaidAmount)
        Me.GrpPaymentInformation.Controls.Add(Me.TxtReturnAmount)
        Me.GrpPaymentInformation.Controls.Add(Me.LblReturnAmount)
        Me.GrpPaymentInformation.Controls.Add(Me.TxtBalance)
        Me.GrpPaymentInformation.Controls.Add(Me.TxtDiscountPercentage)
        Me.GrpPaymentInformation.Controls.Add(Me.TxtTotal)
        Me.GrpPaymentInformation.Controls.Add(Me.TxtVatPercentage)
        Me.GrpPaymentInformation.Controls.Add(Me.TxtPreviousDues)
        Me.GrpPaymentInformation.Controls.Add(Me.TxtAdvance)
        Me.GrpPaymentInformation.Controls.Add(Me.LblBalance)
        Me.GrpPaymentInformation.Controls.Add(Me.LblPaidAmount)
        Me.GrpPaymentInformation.Controls.Add(Me.LblNetPayable)
        Me.GrpPaymentInformation.Controls.Add(Me.LblDiscount)
        Me.GrpPaymentInformation.Controls.Add(Me.Label1)
        Me.GrpPaymentInformation.Controls.Add(Me.LblVat)
        Me.GrpPaymentInformation.Controls.Add(Me.LblAdvance)
        Me.GrpPaymentInformation.Controls.Add(Me.LblPreviousDues)
        Me.GrpPaymentInformation.Controls.Add(Me.LblTotal)
        Me.GrpPaymentInformation.Location = New System.Drawing.Point(920, 247)
        Me.GrpPaymentInformation.Name = "GrpPaymentInformation"
        Me.GrpPaymentInformation.Size = New System.Drawing.Size(251, 364)
        Me.GrpPaymentInformation.TabIndex = 1002
        Me.GrpPaymentInformation.TabStop = False
        Me.GrpPaymentInformation.Text = "Payment Information"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(51, 292)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 25)
        Me.Label6.TabIndex = 157
        Me.Label6.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(96, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 25)
        Me.Label3.TabIndex = 156
        Me.Label3.Text = "*"
        '
        'cmbPaidBy
        '
        Me.cmbPaidBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbPaidBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPaidBy.FormattingEnabled = True
        Me.cmbPaidBy.Location = New System.Drawing.Point(115, 290)
        Me.cmbPaidBy.Name = "cmbPaidBy"
        Me.cmbPaidBy.Size = New System.Drawing.Size(100, 21)
        Me.cmbPaidBy.TabIndex = 155
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.BtnSave)
        Me.GroupBox1.Controls.Add(Me.BtnPrint)
        Me.GroupBox1.Controls.Add(Me.BtnInvoice)
        Me.GroupBox1.Location = New System.Drawing.Point(920, 624)
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
        'DtpSaleDate
        '
        Me.DtpSaleDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtpSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpSaleDate.Location = New System.Drawing.Point(1042, 95)
        Me.DtpSaleDate.Name = "DtpSaleDate"
        Me.DtpSaleDate.Size = New System.Drawing.Size(129, 20)
        Me.DtpSaleDate.TabIndex = 1004
        Me.DtpSaleDate.Value = New Date(2018, 9, 10, 0, 0, 0, 0)
        '
        'TxtSaleInvoiceNo
        '
        Me.TxtSaleInvoiceNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSaleInvoiceNo.Location = New System.Drawing.Point(1042, 67)
        Me.TxtSaleInvoiceNo.Name = "TxtSaleInvoiceNo"
        Me.TxtSaleInvoiceNo.ReadOnly = True
        Me.TxtSaleInvoiceNo.Size = New System.Drawing.Size(129, 20)
        Me.TxtSaleInvoiceNo.TabIndex = 1005
        '
        'lblInvoiceNo
        '
        Me.lblInvoiceNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInvoiceNo.AutoSize = True
        Me.lblInvoiceNo.Location = New System.Drawing.Point(952, 70)
        Me.lblInvoiceNo.Name = "lblInvoiceNo"
        Me.lblInvoiceNo.Size = New System.Drawing.Size(62, 13)
        Me.lblInvoiceNo.TabIndex = 1006
        Me.lblInvoiceNo.Text = "Invoice No:"
        '
        'TxtSearchBarcode
        '
        Me.TxtSearchBarcode.BackColor = System.Drawing.Color.Indigo
        Me.TxtSearchBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearchBarcode.ForeColor = System.Drawing.Color.White
        Me.TxtSearchBarcode.Location = New System.Drawing.Point(124, 220)
        Me.TxtSearchBarcode.Name = "TxtSearchBarcode"
        Me.TxtSearchBarcode.Size = New System.Drawing.Size(262, 22)
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
        Me.cmbProductName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbProductName.FormattingEnabled = True
        Me.cmbProductName.Location = New System.Drawing.Point(9, 35)
        Me.cmbProductName.Name = "cmbProductName"
        Me.cmbProductName.Size = New System.Drawing.Size(278, 21)
        Me.cmbProductName.TabIndex = 1010
        '
        'TxtSaleAmount
        '
        Me.TxtSaleAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSaleAmount.Location = New System.Drawing.Point(812, 35)
        Me.TxtSaleAmount.Name = "TxtSaleAmount"
        Me.TxtSaleAmount.Size = New System.Drawing.Size(80, 20)
        Me.TxtSaleAmount.TabIndex = 1016
        '
        'TxtSaleUnitPrice
        '
        Me.TxtSaleUnitPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSaleUnitPrice.Location = New System.Drawing.Point(751, 35)
        Me.TxtSaleUnitPrice.Name = "TxtSaleUnitPrice"
        Me.TxtSaleUnitPrice.Size = New System.Drawing.Size(55, 20)
        Me.TxtSaleUnitPrice.TabIndex = 1015
        '
        'TxtQuantity
        '
        Me.TxtQuantity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtQuantity.Location = New System.Drawing.Point(319, 35)
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.Size = New System.Drawing.Size(53, 20)
        Me.TxtQuantity.TabIndex = 1011
        '
        'LblSaleAmount
        '
        Me.LblSaleAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblSaleAmount.AutoSize = True
        Me.LblSaleAmount.Location = New System.Drawing.Point(817, 16)
        Me.LblSaleAmount.Name = "LblSaleAmount"
        Me.LblSaleAmount.Size = New System.Drawing.Size(46, 13)
        Me.LblSaleAmount.TabIndex = 1015
        Me.LblSaleAmount.Text = "Amount:"
        '
        'LblSaleUnitPrice
        '
        Me.LblSaleUnitPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblSaleUnitPrice.AutoSize = True
        Me.LblSaleUnitPrice.Location = New System.Drawing.Point(755, 16)
        Me.LblSaleUnitPrice.Name = "LblSaleUnitPrice"
        Me.LblSaleUnitPrice.Size = New System.Drawing.Size(56, 13)
        Me.LblSaleUnitPrice.TabIndex = 1016
        Me.LblSaleUnitPrice.Text = "Unit Price:"
        '
        'LblQuantitylbl
        '
        Me.LblQuantitylbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblQuantitylbl.AutoSize = True
        Me.LblQuantitylbl.Location = New System.Drawing.Point(321, 16)
        Me.LblQuantitylbl.Name = "LblQuantitylbl"
        Me.LblQuantitylbl.Size = New System.Drawing.Size(49, 13)
        Me.LblQuantitylbl.TabIndex = 1017
        Me.LblQuantitylbl.Text = "Quantity:"
        '
        'LblProductName
        '
        Me.LblProductName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblProductName.AutoSize = True
        Me.LblProductName.Location = New System.Drawing.Point(111, 16)
        Me.LblProductName.Name = "LblProductName"
        Me.LblProductName.Size = New System.Drawing.Size(78, 13)
        Me.LblProductName.TabIndex = 1018
        Me.LblProductName.Text = "Product Name:"
        '
        'LblSelectProduct
        '
        Me.LblSelectProduct.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblSelectProduct.Controls.Add(Me.GrdSerialNumber)
        Me.LblSelectProduct.Controls.Add(Me.LblDiscountAmount)
        Me.LblSelectProduct.Controls.Add(Me.TxtDiscountAmount)
        Me.LblSelectProduct.Controls.Add(Me.TxtUnitDiscount)
        Me.LblSelectProduct.Controls.Add(Me.LblProductDiscount)
        Me.LblSelectProduct.Controls.Add(Me.Button4)
        Me.LblSelectProduct.Controls.Add(Me.Label9)
        Me.LblSelectProduct.Controls.Add(Me.TxtBonus)
        Me.LblSelectProduct.Controls.Add(Me.CmbSerialNumber)
        Me.LblSelectProduct.Controls.Add(Me.TxtWarrantyDays)
        Me.LblSelectProduct.Controls.Add(Me.LblWarrantyDays)
        Me.LblSelectProduct.Controls.Add(Me.LblStatus)
        Me.LblSelectProduct.Controls.Add(Me.TxtFromSerial)
        Me.LblSelectProduct.Controls.Add(Me.TxtToSerial)
        Me.LblSelectProduct.Controls.Add(Me.RdbRangeSerial)
        Me.LblSelectProduct.Controls.Add(Me.LblTo)
        Me.LblSelectProduct.Controls.Add(Me.LblSingleSerialNumber)
        Me.LblSelectProduct.Controls.Add(Me.LblFrom)
        Me.LblSelectProduct.Controls.Add(Me.TxtPurchaseID)
        Me.LblSelectProduct.Controls.Add(Me.LblPurchaseID)
        Me.LblSelectProduct.Controls.Add(Me.LblProductName)
        Me.LblSelectProduct.Controls.Add(Me.LblQuantitylbl)
        Me.LblSelectProduct.Controls.Add(Me.LblSaleUnitPrice)
        Me.LblSelectProduct.Controls.Add(Me.LblSaleAmount)
        Me.LblSelectProduct.Controls.Add(Me.TxtSaleUnitPrice)
        Me.LblSelectProduct.Controls.Add(Me.TxtSaleAmount)
        Me.LblSelectProduct.Controls.Add(Me.TxtQuantity)
        Me.LblSelectProduct.Controls.Add(Me.cmbProductName)
        Me.LblSelectProduct.Location = New System.Drawing.Point(13, 247)
        Me.LblSelectProduct.Name = "LblSelectProduct"
        Me.LblSelectProduct.Size = New System.Drawing.Size(901, 101)
        Me.LblSelectProduct.TabIndex = 1019
        Me.LblSelectProduct.TabStop = False
        '
        'GrdSerialNumber
        '
        Me.GrdSerialNumber.AllowUserToAddRows = False
        Me.GrdSerialNumber.AllowUserToDeleteRows = False
        Me.GrdSerialNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdSerialNumber.BackgroundColor = System.Drawing.Color.White
        Me.GrdSerialNumber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdSerialNumber.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GrdSerialNumber.Location = New System.Drawing.Point(426, 58)
        Me.GrdSerialNumber.Name = "GrdSerialNumber"
        Me.GrdSerialNumber.ReadOnly = True
        Me.GrdSerialNumber.Size = New System.Drawing.Size(251, 10)
        Me.GrdSerialNumber.TabIndex = 2056
        Me.GrdSerialNumber.Visible = False
        '
        'LblDiscountAmount
        '
        Me.LblDiscountAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblDiscountAmount.AutoSize = True
        Me.LblDiscountAmount.Location = New System.Drawing.Point(680, 16)
        Me.LblDiscountAmount.Name = "LblDiscountAmount"
        Me.LblDiscountAmount.Size = New System.Drawing.Size(73, 13)
        Me.LblDiscountAmount.TabIndex = 100020
        Me.LblDiscountAmount.Text = "Disc. Amount:"
        '
        'TxtDiscountAmount
        '
        Me.TxtDiscountAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDiscountAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDiscountAmount.Location = New System.Drawing.Point(683, 35)
        Me.TxtDiscountAmount.Name = "TxtDiscountAmount"
        Me.TxtDiscountAmount.Size = New System.Drawing.Size(62, 20)
        Me.TxtDiscountAmount.TabIndex = 100019
        '
        'TxtUnitDiscount
        '
        Me.TxtUnitDiscount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtUnitDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUnitDiscount.Location = New System.Drawing.Point(611, 35)
        Me.TxtUnitDiscount.Name = "TxtUnitDiscount"
        Me.TxtUnitDiscount.Size = New System.Drawing.Size(66, 20)
        Me.TxtUnitDiscount.TabIndex = 100017
        '
        'LblProductDiscount
        '
        Me.LblProductDiscount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblProductDiscount.AutoSize = True
        Me.LblProductDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProductDiscount.Location = New System.Drawing.Point(617, 16)
        Me.LblProductDiscount.Name = "LblProductDiscount"
        Me.LblProductDiscount.Size = New System.Drawing.Size(60, 13)
        Me.LblProductDiscount.TabIndex = 100018
        Me.LblProductDiscount.Text = "U.Discount"
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackgroundImage = Global.Business_Expert_Pro.My.Resources.Resources.newButton
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(293, 35)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(20, 20)
        Me.Button4.TabIndex = 2056
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(380, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 2055
        Me.Label9.Text = "Bonus:"
        '
        'TxtBonus
        '
        Me.TxtBonus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBonus.Location = New System.Drawing.Point(378, 35)
        Me.TxtBonus.Name = "TxtBonus"
        Me.TxtBonus.Size = New System.Drawing.Size(45, 20)
        Me.TxtBonus.TabIndex = 1012
        '
        'CmbSerialNumber
        '
        Me.CmbSerialNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbSerialNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbSerialNumber.Location = New System.Drawing.Point(426, 35)
        Me.CmbSerialNumber.Name = "CmbSerialNumber"
        Me.CmbSerialNumber.Size = New System.Drawing.Size(123, 21)
        Me.CmbSerialNumber.TabIndex = 1013
        '
        'TxtWarrantyDays
        '
        Me.TxtWarrantyDays.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtWarrantyDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtWarrantyDays.Location = New System.Drawing.Point(555, 35)
        Me.TxtWarrantyDays.Name = "TxtWarrantyDays"
        Me.TxtWarrantyDays.Size = New System.Drawing.Size(50, 22)
        Me.TxtWarrantyDays.TabIndex = 1014
        '
        'LblWarrantyDays
        '
        Me.LblWarrantyDays.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblWarrantyDays.AutoSize = True
        Me.LblWarrantyDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWarrantyDays.Location = New System.Drawing.Point(531, 16)
        Me.LblWarrantyDays.Name = "LblWarrantyDays"
        Me.LblWarrantyDays.Size = New System.Drawing.Size(80, 13)
        Me.LblWarrantyDays.TabIndex = 2047
        Me.LblWarrantyDays.Text = "Warranty Days:"
        '
        'LblStatus
        '
        Me.LblStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Location = New System.Drawing.Point(500, 16)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(37, 13)
        Me.LblStatus.TabIndex = 2047
        Me.LblStatus.Text = "Status"
        '
        'TxtFromSerial
        '
        Me.TxtFromSerial.Enabled = False
        Me.TxtFromSerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFromSerial.Location = New System.Drawing.Point(140, 71)
        Me.TxtFromSerial.Name = "TxtFromSerial"
        Me.TxtFromSerial.Size = New System.Drawing.Size(129, 22)
        Me.TxtFromSerial.TabIndex = 1017
        '
        'TxtToSerial
        '
        Me.TxtToSerial.Enabled = False
        Me.TxtToSerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtToSerial.Location = New System.Drawing.Point(300, 71)
        Me.TxtToSerial.Name = "TxtToSerial"
        Me.TxtToSerial.Size = New System.Drawing.Size(129, 22)
        Me.TxtToSerial.TabIndex = 1018
        '
        'RdbRangeSerial
        '
        Me.RdbRangeSerial.AutoSize = True
        Me.RdbRangeSerial.Location = New System.Drawing.Point(7, 74)
        Me.RdbRangeSerial.Name = "RdbRangeSerial"
        Me.RdbRangeSerial.Size = New System.Drawing.Size(86, 17)
        Me.RdbRangeSerial.TabIndex = 1023
        Me.RdbRangeSerial.TabStop = True
        Me.RdbRangeSerial.Text = "Range Serial"
        Me.RdbRangeSerial.UseVisualStyleBackColor = True
        '
        'LblTo
        '
        Me.LblTo.AutoSize = True
        Me.LblTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTo.Location = New System.Drawing.Point(273, 74)
        Me.LblTo.Name = "LblTo"
        Me.LblTo.Size = New System.Drawing.Size(27, 15)
        Me.LblTo.TabIndex = 2044
        Me.LblTo.Text = "To:"
        '
        'LblSingleSerialNumber
        '
        Me.LblSingleSerialNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblSingleSerialNumber.AutoSize = True
        Me.LblSingleSerialNumber.Location = New System.Drawing.Point(423, 16)
        Me.LblSingleSerialNumber.Name = "LblSingleSerialNumber"
        Me.LblSingleSerialNumber.Size = New System.Drawing.Size(76, 13)
        Me.LblSingleSerialNumber.TabIndex = 1022
        Me.LblSingleSerialNumber.Text = "Serial Number:"
        '
        'LblFrom
        '
        Me.LblFrom.AutoSize = True
        Me.LblFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFrom.Location = New System.Drawing.Point(95, 74)
        Me.LblFrom.Name = "LblFrom"
        Me.LblFrom.Size = New System.Drawing.Size(44, 15)
        Me.LblFrom.TabIndex = 2043
        Me.LblFrom.Text = "From:"
        '
        'TxtPurchaseID
        '
        Me.TxtPurchaseID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPurchaseID.Location = New System.Drawing.Point(533, 73)
        Me.TxtPurchaseID.Name = "TxtPurchaseID"
        Me.TxtPurchaseID.ReadOnly = True
        Me.TxtPurchaseID.Size = New System.Drawing.Size(76, 20)
        Me.TxtPurchaseID.TabIndex = 100012
        Me.TxtPurchaseID.Visible = False
        '
        'LblPurchaseID
        '
        Me.LblPurchaseID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblPurchaseID.AutoSize = True
        Me.LblPurchaseID.Location = New System.Drawing.Point(461, 75)
        Me.LblPurchaseID.Name = "LblPurchaseID"
        Me.LblPurchaseID.Size = New System.Drawing.Size(69, 13)
        Me.LblPurchaseID.TabIndex = 1020
        Me.LblPurchaseID.Text = "Purchase ID:"
        Me.LblPurchaseID.Visible = False
        '
        'LblLastSoldPrice
        '
        Me.LblLastSoldPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblLastSoldPrice.AutoSize = True
        Me.LblLastSoldPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LblLastSoldPrice.Location = New System.Drawing.Point(736, 710)
        Me.LblLastSoldPrice.Name = "LblLastSoldPrice"
        Me.LblLastSoldPrice.Size = New System.Drawing.Size(22, 16)
        Me.LblLastSoldPrice.TabIndex = 2051
        Me.LblLastSoldPrice.Text = "00"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(646, 712)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 2051
        Me.Label8.Text = "Last Sold Price:"
        '
        'GrdProductList
        '
        Me.GrdProductList.AllowUserToAddRows = False
        Me.GrdProductList.AllowUserToDeleteRows = False
        Me.GrdProductList.BackgroundColor = System.Drawing.Color.White
        Me.GrdProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdProductList.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GrdProductList.Location = New System.Drawing.Point(22, 303)
        Me.GrdProductList.Name = "GrdProductList"
        Me.GrdProductList.ReadOnly = True
        Me.GrdProductList.Size = New System.Drawing.Size(414, 10)
        Me.GrdProductList.TabIndex = 2054
        Me.GrdProductList.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(416, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 2049
        Me.Label7.Text = "Remarks:"
        '
        'TxtRemarks
        '
        Me.TxtRemarks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRemarks.Location = New System.Drawing.Point(486, 211)
        Me.TxtRemarks.Multiline = True
        Me.TxtRemarks.Name = "TxtRemarks"
        Me.TxtRemarks.Size = New System.Drawing.Size(421, 36)
        Me.TxtRemarks.TabIndex = 2048
        '
        'lblQuantityAvailable
        '
        Me.lblQuantityAvailable.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblQuantityAvailable.AutoSize = True
        Me.lblQuantityAvailable.BackColor = System.Drawing.Color.White
        Me.lblQuantityAvailable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantityAvailable.Location = New System.Drawing.Point(108, 710)
        Me.lblQuantityAvailable.Name = "lblQuantityAvailable"
        Me.lblQuantityAvailable.Size = New System.Drawing.Size(22, 16)
        Me.lblQuantityAvailable.TabIndex = 2020
        Me.lblQuantityAvailable.Text = "00"
        Me.lblQuantityAvailable.Visible = False
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
        Me.Label5.Location = New System.Drawing.Point(779, 711)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 2023
        Me.Label5.Text = "Sale ID:"
        '
        'lblSaleID
        '
        Me.lblSaleID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSaleID.AutoSize = True
        Me.lblSaleID.Location = New System.Drawing.Point(830, 710)
        Me.lblSaleID.Name = "lblSaleID"
        Me.lblSaleID.Size = New System.Drawing.Size(19, 13)
        Me.lblSaleID.TabIndex = 2022
        Me.lblSaleID.Text = "00"
        '
        'BtnDelete
        '
        Me.BtnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Location = New System.Drawing.Point(1093, 214)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(86, 26)
        Me.BtnDelete.TabIndex = 2024
        Me.BtnDelete.Text = "Delete Invoice"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'lblsaleDate
        '
        Me.lblsaleDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblsaleDate.AutoSize = True
        Me.lblsaleDate.Location = New System.Drawing.Point(952, 100)
        Me.lblsaleDate.Name = "lblsaleDate"
        Me.lblsaleDate.Size = New System.Drawing.Size(57, 13)
        Me.lblsaleDate.TabIndex = 2031
        Me.lblsaleDate.Text = "Sale Date:"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(308, 708)
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
        Me.Label14.Location = New System.Drawing.Point(388, 708)
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
        Me.Label11.Size = New System.Drawing.Size(166, 16)
        Me.Label11.TabIndex = 2037
        Me.Label11.Text = "For Billing : Ctrl+Space"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(513, 708)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 16)
        Me.Label12.TabIndex = 2036
        Me.Label12.Text = "Delete: Click 2X"
        '
        'BtnSaleHistory
        '
        Me.BtnSaleHistory.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSaleHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSaleHistory.Location = New System.Drawing.Point(1003, 214)
        Me.BtnSaleHistory.Name = "BtnSaleHistory"
        Me.BtnSaleHistory.Size = New System.Drawing.Size(86, 26)
        Me.BtnSaleHistory.TabIndex = 2040
        Me.BtnSaleHistory.Text = "Sale History"
        Me.BtnSaleHistory.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(913, 214)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 26)
        Me.Button2.TabIndex = 2041
        Me.Button2.Text = "New Invoice"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GrdAvailableSerialNumber
        '
        Me.GrdAvailableSerialNumber.AllowUserToAddRows = False
        Me.GrdAvailableSerialNumber.AllowUserToDeleteRows = False
        Me.GrdAvailableSerialNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GrdAvailableSerialNumber.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GrdAvailableSerialNumber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdAvailableSerialNumber.Location = New System.Drawing.Point(13, 360)
        Me.GrdAvailableSerialNumber.Name = "GrdAvailableSerialNumber"
        Me.GrdAvailableSerialNumber.ReadOnly = True
        Me.GrdAvailableSerialNumber.Size = New System.Drawing.Size(205, 347)
        Me.GrdAvailableSerialNumber.TabIndex = 2043
        '
        'lblTotalQuantityAvailable
        '
        Me.lblTotalQuantityAvailable.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotalQuantityAvailable.AutoSize = True
        Me.lblTotalQuantityAvailable.BackColor = System.Drawing.Color.White
        Me.lblTotalQuantityAvailable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalQuantityAvailable.Location = New System.Drawing.Point(70, 710)
        Me.lblTotalQuantityAvailable.Name = "lblTotalQuantityAvailable"
        Me.lblTotalQuantityAvailable.Size = New System.Drawing.Size(22, 16)
        Me.lblTotalQuantityAvailable.TabIndex = 2050
        Me.lblTotalQuantityAvailable.Text = "00"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Indigo
        Me.Panel1.Location = New System.Drawing.Point(13, 348)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(901, 10)
        Me.Panel1.TabIndex = 2058
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(915, 138)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 2060
        Me.Label10.Text = "Net Payable"
        '
        'TxtNetPayableLarge
        '
        Me.TxtNetPayableLarge.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNetPayableLarge.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.TxtNetPayableLarge.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNetPayableLarge.ForeColor = System.Drawing.Color.White
        Me.TxtNetPayableLarge.Location = New System.Drawing.Point(913, 154)
        Me.TxtNetPayableLarge.Name = "TxtNetPayableLarge"
        Me.TxtNetPayableLarge.ReadOnly = True
        Me.TxtNetPayableLarge.Size = New System.Drawing.Size(266, 53)
        Me.TxtNetPayableLarge.TabIndex = 2061
        Me.TxtNetPayableLarge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FrmSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 730)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtNetPayableLarge)
        Me.Controls.Add(Me.GrdCustomerList)
        Me.Controls.Add(Me.GrdProductList)
        Me.Controls.Add(Me.LblLastSoldPrice)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblTotalQuantityAvailable)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GrdAvailableSerialNumber)
        Me.Controls.Add(Me.TxtRemarks)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnSaleHistory)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblsaleDate)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblSaleID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblQuantityAvailable)
        Me.Controls.Add(Me.LblSelectProduct)
        Me.Controls.Add(Me.LblSearchBarcode)
        Me.Controls.Add(Me.TxtSearchBarcode)
        Me.Controls.Add(Me.lblInvoiceNo)
        Me.Controls.Add(Me.TxtSaleInvoiceNo)
        Me.Controls.Add(Me.DtpSaleDate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GrpPaymentInformation)
        Me.Controls.Add(Me.GrdSale)
        Me.Controls.Add(Me.GrpCustomerInformation)
        Me.Controls.Add(Me.PnlSale)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSale"
        Me.Text = "Sale"
        Me.PnlSale.ResumeLayout(False)
        Me.PnlSale.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GrpCustomerInformation.ResumeLayout(False)
        Me.GrpCustomerInformation.PerformLayout()
        CType(Me.GrdCustomerList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdSale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpPaymentInformation.ResumeLayout(False)
        Me.GrpPaymentInformation.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.LblSelectProduct.ResumeLayout(False)
        Me.LblSelectProduct.PerformLayout()
        CType(Me.GrdSerialNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdProductList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdAvailableSerialNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PnlSale As System.Windows.Forms.Panel
    Friend WithEvents LblSale As System.Windows.Forms.Label
    Friend WithEvents LblCustomerName As System.Windows.Forms.Label
    Friend WithEvents LblPhoneNo As System.Windows.Forms.Label
    Friend WithEvents LblAddress As System.Windows.Forms.Label
    Friend WithEvents CmbCustomerName As System.Windows.Forms.ComboBox
    Friend WithEvents TxtPhoneNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtAddress As System.Windows.Forms.TextBox
    Friend WithEvents LblPreviousDues As System.Windows.Forms.Label
    Friend WithEvents LblVat As System.Windows.Forms.Label
    Friend WithEvents LblDiscount As System.Windows.Forms.Label
    Friend WithEvents LblNetPayable As System.Windows.Forms.Label
    Friend WithEvents LblPaidAmount As System.Windows.Forms.Label
    Friend WithEvents LblReturnAmount As System.Windows.Forms.Label
    Friend WithEvents LblBalance As System.Windows.Forms.Label
    Friend WithEvents TxtAdvance As System.Windows.Forms.TextBox
    Friend WithEvents TxtPreviousDues As System.Windows.Forms.TextBox
    Friend WithEvents TxtVatPercentage As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents TxtDiscountPercentage As System.Windows.Forms.TextBox
    Friend WithEvents TxtReturnAmount As System.Windows.Forms.TextBox
    Friend WithEvents TxtBalance As System.Windows.Forms.TextBox
    Friend WithEvents TxtPaidAmount As System.Windows.Forms.TextBox
    Friend WithEvents TxtNetPayable As System.Windows.Forms.TextBox
    Friend WithEvents TxtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents TxtVat As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GrpCustomerInformation As System.Windows.Forms.GroupBox
    Friend WithEvents LblPaidBy As System.Windows.Forms.Label
    Friend WithEvents GrdSale As System.Windows.Forms.DataGridView
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents LblAdvance As System.Windows.Forms.Label
    Friend WithEvents GrpPaymentInformation As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCustomerName As System.Windows.Forms.Button
    Friend WithEvents TxtCustomerDiscount As System.Windows.Forms.TextBox
    Friend WithEvents LblCustomerDiscount As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnInvoice As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents DtpSaleDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtSaleInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents lblInvoiceNo As System.Windows.Forms.Label
    Friend WithEvents TxtSearchBarcode As System.Windows.Forms.TextBox
    Friend WithEvents LblSearchBarcode As System.Windows.Forms.Label
    Friend WithEvents cmbProductName As System.Windows.Forms.ComboBox
    Friend WithEvents TxtSaleAmount As System.Windows.Forms.TextBox
    Friend WithEvents TxtSaleUnitPrice As System.Windows.Forms.TextBox
    Friend WithEvents TxtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents LblSaleAmount As System.Windows.Forms.Label
    Friend WithEvents LblSaleUnitPrice As System.Windows.Forms.Label
    Friend WithEvents LblQuantitylbl As System.Windows.Forms.Label
    Friend WithEvents LblProductName As System.Windows.Forms.Label
    Friend WithEvents LblSelectProduct As System.Windows.Forms.GroupBox
    Friend WithEvents TxtPurchaseID As System.Windows.Forms.TextBox
    Friend WithEvents LblPurchaseID As System.Windows.Forms.Label
    Friend WithEvents lblQuantityAvailable As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblSaleID As System.Windows.Forms.Label
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents lblsaleDate As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbPaidBy As System.Windows.Forms.ComboBox
    Friend WithEvents BtnSaleHistory As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LblSingleSerialNumber As System.Windows.Forms.Label
    Friend WithEvents RdbRangeSerial As System.Windows.Forms.RadioButton
    Friend WithEvents TxtFromSerial As System.Windows.Forms.TextBox
    Friend WithEvents TxtToSerial As System.Windows.Forms.TextBox
    Friend WithEvents LblTo As System.Windows.Forms.Label
    Friend WithEvents GrdAvailableSerialNumber As System.Windows.Forms.DataGridView
    Friend WithEvents LblStatus As System.Windows.Forms.Label
    Friend WithEvents TxtWarrantyDays As System.Windows.Forms.TextBox
    Friend WithEvents LblWarrantyDays As System.Windows.Forms.Label
    Friend WithEvents LblFrom As System.Windows.Forms.Label
    Friend WithEvents CmbSerialNumber As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblTotalQuantityAvailable As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LblLastSoldPrice As System.Windows.Forms.Label
    Friend WithEvents GrdProductList As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtBonus As System.Windows.Forms.TextBox
    Friend WithEvents GrdCustomerList As System.Windows.Forms.DataGridView
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GrdSerialNumber As System.Windows.Forms.DataGridView
    Friend WithEvents LblDiscountAmount As System.Windows.Forms.Label
    Friend WithEvents TxtDiscountAmount As System.Windows.Forms.TextBox
    Friend WithEvents TxtUnitDiscount As System.Windows.Forms.TextBox
    Friend WithEvents LblProductDiscount As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtNetPayableLarge As System.Windows.Forms.TextBox
End Class
