<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPurchaseReturn
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPurchaseReturn))
        Me.PnlPurchaseReturn = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.LblPurchaseReturn = New System.Windows.Forms.Label
        Me.CmbSearch = New System.Windows.Forms.ComboBox
        Me.TxtSearch = New System.Windows.Forms.TextBox
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.GrdPurchaseInvoice = New System.Windows.Forms.DataGridView
        Me.GrdPurchaseReturn = New System.Windows.Forms.DataGridView
        Me.LblReturnedQuantity = New System.Windows.Forms.Label
        Me.LblReturnedDate = New System.Windows.Forms.Label
        Me.TxtReturnedQuantity = New System.Windows.Forms.TextBox
        Me.DtpReturnedDate = New System.Windows.Forms.DateTimePicker
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.GrdPurchaseDetails = New System.Windows.Forms.DataGridView
        Me.GrdPurchaseSerialNumber = New System.Windows.Forms.DataGridView
        Me.lblInvoiceNo = New System.Windows.Forms.Label
        Me.TxtPurchaseReturnInvoiceNo = New System.Windows.Forms.TextBox
        Me.GrdPurchaseReturnSerialNumber = New System.Windows.Forms.DataGridView
        Me.GrpPaymentInformation = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbPaidBy = New System.Windows.Forms.ComboBox
        Me.LblPaidBy = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtDiscount = New System.Windows.Forms.TextBox
        Me.TxtNetPayable = New System.Windows.Forms.TextBox
        Me.TxtPaidAmount = New System.Windows.Forms.TextBox
        Me.TxtDiscountPercentage = New System.Windows.Forms.TextBox
        Me.TxtTotal = New System.Windows.Forms.TextBox
        Me.LblPaidAmount = New System.Windows.Forms.Label
        Me.LblNetPayable = New System.Windows.Forms.Label
        Me.LblDiscount = New System.Windows.Forms.Label
        Me.LblTotal = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.BtnInvoice = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.LblPurchaseReturnID = New System.Windows.Forms.Label
        Me.CmbSerialNumber = New System.Windows.Forms.ComboBox
        Me.LblSingleSerialNumber = New System.Windows.Forms.Label
        Me.BtnHistory = New System.Windows.Forms.Button
        Me.BtnNewInvoice = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.GrpPurchaseReturn = New System.Windows.Forms.GroupBox
        Me.GrpSearch = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GrpSaleReturnInvoice = New System.Windows.Forms.GroupBox
        Me.GrpSupplierInformation = New System.Windows.Forms.GroupBox
        Me.TxtAddress = New System.Windows.Forms.TextBox
        Me.LblAddress = New System.Windows.Forms.Label
        Me.TxtPhoneNo = New System.Windows.Forms.TextBox
        Me.CmbSupplierName = New System.Windows.Forms.ComboBox
        Me.LblPhoneNo = New System.Windows.Forms.Label
        Me.LblSupplierName = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PnlPurchaseReturn.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GrdPurchaseInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdPurchaseReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdPurchaseDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdPurchaseSerialNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdPurchaseReturnSerialNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpPaymentInformation.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GrpPurchaseReturn.SuspendLayout()
        Me.GrpSearch.SuspendLayout()
        Me.GrpSaleReturnInvoice.SuspendLayout()
        Me.GrpSupplierInformation.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlPurchaseReturn
        '
        Me.PnlPurchaseReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.PnlPurchaseReturn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlPurchaseReturn.Controls.Add(Me.Panel1)
        Me.PnlPurchaseReturn.Controls.Add(Me.LblPurchaseReturn)
        Me.PnlPurchaseReturn.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlPurchaseReturn.Location = New System.Drawing.Point(0, 0)
        Me.PnlPurchaseReturn.Name = "PnlPurchaseReturn"
        Me.PnlPurchaseReturn.Size = New System.Drawing.Size(1014, 71)
        Me.PnlPurchaseReturn.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Btnclose)
        Me.Panel1.Controls.Add(Me.Btnminimized)
        Me.Panel1.Controls.Add(Me.Btnmaximized)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1012, 28)
        Me.Panel1.TabIndex = 2053
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(988, 0)
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
        Me.Btnminimized.Location = New System.Drawing.Point(928, 0)
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
        Me.Btnmaximized.Location = New System.Drawing.Point(958, 0)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1160
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'LblPurchaseReturn
        '
        Me.LblPurchaseReturn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblPurchaseReturn.AutoSize = True
        Me.LblPurchaseReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.LblPurchaseReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPurchaseReturn.ForeColor = System.Drawing.Color.White
        Me.LblPurchaseReturn.Location = New System.Drawing.Point(417, 31)
        Me.LblPurchaseReturn.Name = "LblPurchaseReturn"
        Me.LblPurchaseReturn.Size = New System.Drawing.Size(248, 33)
        Me.LblPurchaseReturn.TabIndex = 0
        Me.LblPurchaseReturn.Text = "Purchase Return"
        '
        'CmbSearch
        '
        Me.CmbSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.CmbSearch.FormattingEnabled = True
        Me.CmbSearch.Items.AddRange(New Object() {"Supplier Name", "Invoice No", "Mobile No", "Product"})
        Me.CmbSearch.Location = New System.Drawing.Point(85, 16)
        Me.CmbSearch.Name = "CmbSearch"
        Me.CmbSearch.Size = New System.Drawing.Size(206, 23)
        Me.CmbSearch.TabIndex = 1
        '
        'TxtSearch
        '
        Me.TxtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.TxtSearch.Location = New System.Drawing.Point(297, 18)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(250, 21)
        Me.TxtSearch.TabIndex = 2
        '
        'BtnSearch
        '
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Image = CType(resources.GetObject("BtnSearch.Image"), System.Drawing.Image)
        Me.BtnSearch.Location = New System.Drawing.Point(553, 16)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(45, 21)
        Me.BtnSearch.TabIndex = 3
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'GrdPurchaseInvoice
        '
        Me.GrdPurchaseInvoice.AllowUserToAddRows = False
        Me.GrdPurchaseInvoice.AllowUserToDeleteRows = False
        Me.GrdPurchaseInvoice.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdPurchaseInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdPurchaseInvoice.Location = New System.Drawing.Point(12, 209)
        Me.GrdPurchaseInvoice.Name = "GrdPurchaseInvoice"
        Me.GrdPurchaseInvoice.ReadOnly = True
        Me.GrdPurchaseInvoice.Size = New System.Drawing.Size(622, 214)
        Me.GrdPurchaseInvoice.TabIndex = 2050
        '
        'GrdPurchaseReturn
        '
        Me.GrdPurchaseReturn.AllowUserToAddRows = False
        Me.GrdPurchaseReturn.AllowUserToDeleteRows = False
        Me.GrdPurchaseReturn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdPurchaseReturn.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdPurchaseReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdPurchaseReturn.Location = New System.Drawing.Point(12, 489)
        Me.GrdPurchaseReturn.Name = "GrdPurchaseReturn"
        Me.GrdPurchaseReturn.ReadOnly = True
        Me.GrdPurchaseReturn.Size = New System.Drawing.Size(541, 227)
        Me.GrdPurchaseReturn.TabIndex = 2051
        '
        'LblReturnedQuantity
        '
        Me.LblReturnedQuantity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblReturnedQuantity.AutoSize = True
        Me.LblReturnedQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LblReturnedQuantity.Location = New System.Drawing.Point(347, 17)
        Me.LblReturnedQuantity.Name = "LblReturnedQuantity"
        Me.LblReturnedQuantity.Size = New System.Drawing.Size(120, 16)
        Me.LblReturnedQuantity.TabIndex = 2053
        Me.LblReturnedQuantity.Text = "Returned Quantity :"
        '
        'LblReturnedDate
        '
        Me.LblReturnedDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblReturnedDate.AutoSize = True
        Me.LblReturnedDate.Location = New System.Drawing.Point(13, 47)
        Me.LblReturnedDate.Name = "LblReturnedDate"
        Me.LblReturnedDate.Size = New System.Drawing.Size(83, 13)
        Me.LblReturnedDate.TabIndex = 2054
        Me.LblReturnedDate.Text = "Returned Date :"
        '
        'TxtReturnedQuantity
        '
        Me.TxtReturnedQuantity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtReturnedQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.TxtReturnedQuantity.Location = New System.Drawing.Point(471, 16)
        Me.TxtReturnedQuantity.Name = "TxtReturnedQuantity"
        Me.TxtReturnedQuantity.Size = New System.Drawing.Size(64, 21)
        Me.TxtReturnedQuantity.TabIndex = 2057
        '
        'DtpReturnedDate
        '
        Me.DtpReturnedDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtpReturnedDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpReturnedDate.Location = New System.Drawing.Point(105, 43)
        Me.DtpReturnedDate.Name = "DtpReturnedDate"
        Me.DtpReturnedDate.Size = New System.Drawing.Size(129, 20)
        Me.DtpReturnedDate.TabIndex = 2058
        Me.DtpReturnedDate.Value = New Date(2018, 3, 12, 0, 0, 0, 0)
        '
        'BtnAdd
        '
        Me.BtnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.BtnAdd.Location = New System.Drawing.Point(620, 11)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(105, 30)
        Me.BtnAdd.TabIndex = 2059
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'GrdPurchaseDetails
        '
        Me.GrdPurchaseDetails.AllowUserToAddRows = False
        Me.GrdPurchaseDetails.AllowUserToDeleteRows = False
        Me.GrdPurchaseDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdPurchaseDetails.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdPurchaseDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdPurchaseDetails.Location = New System.Drawing.Point(640, 209)
        Me.GrdPurchaseDetails.Name = "GrdPurchaseDetails"
        Me.GrdPurchaseDetails.ReadOnly = True
        Me.GrdPurchaseDetails.Size = New System.Drawing.Size(171, 214)
        Me.GrdPurchaseDetails.TabIndex = 2061
        '
        'GrdPurchaseSerialNumber
        '
        Me.GrdPurchaseSerialNumber.AllowUserToAddRows = False
        Me.GrdPurchaseSerialNumber.AllowUserToDeleteRows = False
        Me.GrdPurchaseSerialNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdPurchaseSerialNumber.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdPurchaseSerialNumber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdPurchaseSerialNumber.Location = New System.Drawing.Point(817, 209)
        Me.GrdPurchaseSerialNumber.Name = "GrdPurchaseSerialNumber"
        Me.GrdPurchaseSerialNumber.ReadOnly = True
        Me.GrdPurchaseSerialNumber.Size = New System.Drawing.Size(185, 214)
        Me.GrdPurchaseSerialNumber.TabIndex = 2062
        '
        'lblInvoiceNo
        '
        Me.lblInvoiceNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInvoiceNo.AutoSize = True
        Me.lblInvoiceNo.Location = New System.Drawing.Point(13, 20)
        Me.lblInvoiceNo.Name = "lblInvoiceNo"
        Me.lblInvoiceNo.Size = New System.Drawing.Size(62, 13)
        Me.lblInvoiceNo.TabIndex = 2064
        Me.lblInvoiceNo.Text = "Invoice No:"
        '
        'TxtPurchaseReturnInvoiceNo
        '
        Me.TxtPurchaseReturnInvoiceNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPurchaseReturnInvoiceNo.Location = New System.Drawing.Point(103, 17)
        Me.TxtPurchaseReturnInvoiceNo.Name = "TxtPurchaseReturnInvoiceNo"
        Me.TxtPurchaseReturnInvoiceNo.ReadOnly = True
        Me.TxtPurchaseReturnInvoiceNo.Size = New System.Drawing.Size(129, 20)
        Me.TxtPurchaseReturnInvoiceNo.TabIndex = 2063
        '
        'GrdPurchaseReturnSerialNumber
        '
        Me.GrdPurchaseReturnSerialNumber.AllowUserToAddRows = False
        Me.GrdPurchaseReturnSerialNumber.AllowUserToDeleteRows = False
        Me.GrdPurchaseReturnSerialNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdPurchaseReturnSerialNumber.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdPurchaseReturnSerialNumber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdPurchaseReturnSerialNumber.Location = New System.Drawing.Point(559, 488)
        Me.GrdPurchaseReturnSerialNumber.Name = "GrdPurchaseReturnSerialNumber"
        Me.GrdPurchaseReturnSerialNumber.ReadOnly = True
        Me.GrdPurchaseReturnSerialNumber.Size = New System.Drawing.Size(190, 227)
        Me.GrdPurchaseReturnSerialNumber.TabIndex = 2065
        '
        'GrpPaymentInformation
        '
        Me.GrpPaymentInformation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpPaymentInformation.Controls.Add(Me.Label6)
        Me.GrpPaymentInformation.Controls.Add(Me.Label3)
        Me.GrpPaymentInformation.Controls.Add(Me.cmbPaidBy)
        Me.GrpPaymentInformation.Controls.Add(Me.LblPaidBy)
        Me.GrpPaymentInformation.Controls.Add(Me.Label2)
        Me.GrpPaymentInformation.Controls.Add(Me.TxtDiscount)
        Me.GrpPaymentInformation.Controls.Add(Me.TxtNetPayable)
        Me.GrpPaymentInformation.Controls.Add(Me.TxtPaidAmount)
        Me.GrpPaymentInformation.Controls.Add(Me.TxtDiscountPercentage)
        Me.GrpPaymentInformation.Controls.Add(Me.TxtTotal)
        Me.GrpPaymentInformation.Controls.Add(Me.LblPaidAmount)
        Me.GrpPaymentInformation.Controls.Add(Me.LblNetPayable)
        Me.GrpPaymentInformation.Controls.Add(Me.LblDiscount)
        Me.GrpPaymentInformation.Controls.Add(Me.LblTotal)
        Me.GrpPaymentInformation.Location = New System.Drawing.Point(755, 490)
        Me.GrpPaymentInformation.Name = "GrpPaymentInformation"
        Me.GrpPaymentInformation.Size = New System.Drawing.Size(251, 168)
        Me.GrpPaymentInformation.TabIndex = 2066
        Me.GrpPaymentInformation.TabStop = False
        Me.GrpPaymentInformation.Text = "Payment Information"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(51, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 25)
        Me.Label6.TabIndex = 157
        Me.Label6.Text = "*"
        Me.Label6.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(96, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 25)
        Me.Label3.TabIndex = 156
        Me.Label3.Text = "*"
        Me.Label3.Visible = False
        '
        'cmbPaidBy
        '
        Me.cmbPaidBy.FormattingEnabled = True
        Me.cmbPaidBy.Location = New System.Drawing.Point(115, 139)
        Me.cmbPaidBy.Name = "cmbPaidBy"
        Me.cmbPaidBy.Size = New System.Drawing.Size(100, 21)
        Me.cmbPaidBy.TabIndex = 155
        Me.cmbPaidBy.Visible = False
        '
        'LblPaidBy
        '
        Me.LblPaidBy.AutoSize = True
        Me.LblPaidBy.Location = New System.Drawing.Point(4, 141)
        Me.LblPaidBy.Name = "LblPaidBy"
        Me.LblPaidBy.Size = New System.Drawing.Size(46, 13)
        Me.LblPaidBy.TabIndex = 154
        Me.LblPaidBy.Text = "Paid By:"
        Me.LblPaidBy.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(76, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 16)
        Me.Label2.TabIndex = 151
        Me.Label2.Text = "%"
        '
        'TxtDiscount
        '
        Me.TxtDiscount.Location = New System.Drawing.Point(115, 47)
        Me.TxtDiscount.Name = "TxtDiscount"
        Me.TxtDiscount.Size = New System.Drawing.Size(100, 20)
        Me.TxtDiscount.TabIndex = 111
        '
        'TxtNetPayable
        '
        Me.TxtNetPayable.Location = New System.Drawing.Point(115, 76)
        Me.TxtNetPayable.Name = "TxtNetPayable"
        Me.TxtNetPayable.ReadOnly = True
        Me.TxtNetPayable.Size = New System.Drawing.Size(100, 20)
        Me.TxtNetPayable.TabIndex = 112
        '
        'TxtPaidAmount
        '
        Me.TxtPaidAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TxtPaidAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPaidAmount.ForeColor = System.Drawing.Color.White
        Me.TxtPaidAmount.Location = New System.Drawing.Point(115, 109)
        Me.TxtPaidAmount.Name = "TxtPaidAmount"
        Me.TxtPaidAmount.Size = New System.Drawing.Size(100, 24)
        Me.TxtPaidAmount.TabIndex = 113
        Me.TxtPaidAmount.Visible = False
        '
        'TxtDiscountPercentage
        '
        Me.TxtDiscountPercentage.Location = New System.Drawing.Point(56, 47)
        Me.TxtDiscountPercentage.Name = "TxtDiscountPercentage"
        Me.TxtDiscountPercentage.Size = New System.Drawing.Size(20, 20)
        Me.TxtDiscountPercentage.TabIndex = 110
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(115, 21)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(100, 20)
        Me.TxtTotal.TabIndex = 105
        '
        'LblPaidAmount
        '
        Me.LblPaidAmount.AutoSize = True
        Me.LblPaidAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPaidAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblPaidAmount.Location = New System.Drawing.Point(4, 112)
        Me.LblPaidAmount.Name = "LblPaidAmount"
        Me.LblPaidAmount.Size = New System.Drawing.Size(99, 16)
        Me.LblPaidAmount.TabIndex = 134
        Me.LblPaidAmount.Text = "Paid Amount:"
        Me.LblPaidAmount.Visible = False
        '
        'LblNetPayable
        '
        Me.LblNetPayable.AutoSize = True
        Me.LblNetPayable.Location = New System.Drawing.Point(4, 79)
        Me.LblNetPayable.Name = "LblNetPayable"
        Me.LblNetPayable.Size = New System.Drawing.Size(68, 13)
        Me.LblNetPayable.TabIndex = 133
        Me.LblNetPayable.Text = "Net Payable:"
        '
        'LblDiscount
        '
        Me.LblDiscount.AutoSize = True
        Me.LblDiscount.Location = New System.Drawing.Point(4, 50)
        Me.LblDiscount.Name = "LblDiscount"
        Me.LblDiscount.Size = New System.Drawing.Size(52, 13)
        Me.LblDiscount.TabIndex = 132
        Me.LblDiscount.Text = "Discount:"
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
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.BtnSave)
        Me.GroupBox1.Controls.Add(Me.BtnPrint)
        Me.GroupBox1.Controls.Add(Me.BtnInvoice)
        Me.GroupBox1.Location = New System.Drawing.Point(755, 659)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(251, 72)
        Me.GroupBox1.TabIndex = 2067
        Me.GroupBox1.TabStop = False
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Image = Global.Business_Expert_Pro.My.Resources.Resources.Save1
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSave.Location = New System.Drawing.Point(86, 11)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(78, 55)
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
        Me.BtnPrint.Location = New System.Drawing.Point(5, 11)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(78, 55)
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
        Me.BtnInvoice.Size = New System.Drawing.Size(78, 55)
        Me.BtnInvoice.TabIndex = 2009
        Me.BtnInvoice.Text = "Invoice"
        Me.BtnInvoice.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnInvoice.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 722)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 2068
        Me.Label1.Text = "Purchase Return ID:"
        '
        'LblPurchaseReturnID
        '
        Me.LblPurchaseReturnID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblPurchaseReturnID.AutoSize = True
        Me.LblPurchaseReturnID.Location = New System.Drawing.Point(122, 722)
        Me.LblPurchaseReturnID.Name = "LblPurchaseReturnID"
        Me.LblPurchaseReturnID.Size = New System.Drawing.Size(19, 13)
        Me.LblPurchaseReturnID.TabIndex = 2069
        Me.LblPurchaseReturnID.Text = "00"
        '
        'CmbSerialNumber
        '
        Me.CmbSerialNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbSerialNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbSerialNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.CmbSerialNumber.FormattingEnabled = True
        Me.CmbSerialNumber.Location = New System.Drawing.Point(122, 16)
        Me.CmbSerialNumber.Name = "CmbSerialNumber"
        Me.CmbSerialNumber.Size = New System.Drawing.Size(192, 23)
        Me.CmbSerialNumber.TabIndex = 2070
        '
        'LblSingleSerialNumber
        '
        Me.LblSingleSerialNumber.AutoSize = True
        Me.LblSingleSerialNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LblSingleSerialNumber.Location = New System.Drawing.Point(19, 16)
        Me.LblSingleSerialNumber.Name = "LblSingleSerialNumber"
        Me.LblSingleSerialNumber.Size = New System.Drawing.Size(97, 16)
        Me.LblSingleSerialNumber.TabIndex = 2071
        Me.LblSingleSerialNumber.Text = "Serial Number:"
        '
        'BtnHistory
        '
        Me.BtnHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHistory.Image = Global.Business_Expert_Pro.My.Resources.Resources.Last_view1
        Me.BtnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHistory.Location = New System.Drawing.Point(755, 168)
        Me.BtnHistory.Name = "BtnHistory"
        Me.BtnHistory.Size = New System.Drawing.Size(108, 35)
        Me.BtnHistory.TabIndex = 2075
        Me.BtnHistory.Text = "History"
        Me.BtnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnHistory.UseVisualStyleBackColor = True
        '
        'BtnNewInvoice
        '
        Me.BtnNewInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnNewInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNewInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNewInvoice.Image = Global.Business_Expert_Pro.My.Resources.Resources.Add_New2
        Me.BtnNewInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNewInvoice.Location = New System.Drawing.Point(641, 168)
        Me.BtnNewInvoice.Name = "BtnNewInvoice"
        Me.BtnNewInvoice.Size = New System.Drawing.Size(108, 35)
        Me.BtnNewInvoice.TabIndex = 2074
        Me.BtnNewInvoice.Text = "New Inv."
        Me.BtnNewInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNewInvoice.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.Image = Global.Business_Expert_Pro.My.Resources.Resources.Delete_32px
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(869, 168)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(108, 35)
        Me.BtnDelete.TabIndex = 2072
        Me.BtnDelete.Text = "Delete Inv."
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'GrpPurchaseReturn
        '
        Me.GrpPurchaseReturn.Controls.Add(Me.LblSingleSerialNumber)
        Me.GrpPurchaseReturn.Controls.Add(Me.CmbSerialNumber)
        Me.GrpPurchaseReturn.Controls.Add(Me.TxtReturnedQuantity)
        Me.GrpPurchaseReturn.Controls.Add(Me.LblReturnedQuantity)
        Me.GrpPurchaseReturn.Controls.Add(Me.BtnAdd)
        Me.GrpPurchaseReturn.Enabled = False
        Me.GrpPurchaseReturn.Location = New System.Drawing.Point(18, 434)
        Me.GrpPurchaseReturn.Name = "GrpPurchaseReturn"
        Me.GrpPurchaseReturn.Size = New System.Drawing.Size(731, 49)
        Me.GrpPurchaseReturn.TabIndex = 2076
        Me.GrpPurchaseReturn.TabStop = False
        '
        'GrpSearch
        '
        Me.GrpSearch.Controls.Add(Me.Label4)
        Me.GrpSearch.Controls.Add(Me.BtnSearch)
        Me.GrpSearch.Controls.Add(Me.TxtSearch)
        Me.GrpSearch.Controls.Add(Me.CmbSearch)
        Me.GrpSearch.Location = New System.Drawing.Point(18, 159)
        Me.GrpSearch.Name = "GrpSearch"
        Me.GrpSearch.Size = New System.Drawing.Size(614, 49)
        Me.GrpSearch.TabIndex = 2077
        Me.GrpSearch.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 16)
        Me.Label4.TabIndex = 2072
        Me.Label4.Text = "Search By:"
        '
        'GrpSaleReturnInvoice
        '
        Me.GrpSaleReturnInvoice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpSaleReturnInvoice.Controls.Add(Me.lblInvoiceNo)
        Me.GrpSaleReturnInvoice.Controls.Add(Me.TxtPurchaseReturnInvoiceNo)
        Me.GrpSaleReturnInvoice.Controls.Add(Me.DtpReturnedDate)
        Me.GrpSaleReturnInvoice.Controls.Add(Me.LblReturnedDate)
        Me.GrpSaleReturnInvoice.Location = New System.Drawing.Point(760, 77)
        Me.GrpSaleReturnInvoice.Name = "GrpSaleReturnInvoice"
        Me.GrpSaleReturnInvoice.Size = New System.Drawing.Size(245, 76)
        Me.GrpSaleReturnInvoice.TabIndex = 2078
        Me.GrpSaleReturnInvoice.TabStop = False
        '
        'GrpSupplierInformation
        '
        Me.GrpSupplierInformation.Controls.Add(Me.TxtAddress)
        Me.GrpSupplierInformation.Controls.Add(Me.LblAddress)
        Me.GrpSupplierInformation.Controls.Add(Me.TxtPhoneNo)
        Me.GrpSupplierInformation.Controls.Add(Me.CmbSupplierName)
        Me.GrpSupplierInformation.Controls.Add(Me.LblPhoneNo)
        Me.GrpSupplierInformation.Controls.Add(Me.LblSupplierName)
        Me.GrpSupplierInformation.Location = New System.Drawing.Point(18, 77)
        Me.GrpSupplierInformation.Name = "GrpSupplierInformation"
        Me.GrpSupplierInformation.Size = New System.Drawing.Size(736, 76)
        Me.GrpSupplierInformation.TabIndex = 2079
        Me.GrpSupplierInformation.TabStop = False
        Me.GrpSupplierInformation.Text = "Supplier Information"
        '
        'TxtAddress
        '
        Me.TxtAddress.BackColor = System.Drawing.SystemColors.Control
        Me.TxtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.TxtAddress.Location = New System.Drawing.Point(430, 14)
        Me.TxtAddress.Multiline = True
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.ReadOnly = True
        Me.TxtAddress.Size = New System.Drawing.Size(296, 49)
        Me.TxtAddress.TabIndex = 116
        '
        'LblAddress
        '
        Me.LblAddress.AutoSize = True
        Me.LblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LblAddress.Location = New System.Drawing.Point(365, 17)
        Me.LblAddress.Name = "LblAddress"
        Me.LblAddress.Size = New System.Drawing.Size(62, 16)
        Me.LblAddress.TabIndex = 117
        Me.LblAddress.Text = "Address:"
        '
        'TxtPhoneNo
        '
        Me.TxtPhoneNo.BackColor = System.Drawing.SystemColors.Control
        Me.TxtPhoneNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.TxtPhoneNo.Location = New System.Drawing.Point(117, 43)
        Me.TxtPhoneNo.Name = "TxtPhoneNo"
        Me.TxtPhoneNo.ReadOnly = True
        Me.TxtPhoneNo.Size = New System.Drawing.Size(247, 21)
        Me.TxtPhoneNo.TabIndex = 102
        '
        'CmbSupplierName
        '
        Me.CmbSupplierName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbSupplierName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbSupplierName.BackColor = System.Drawing.SystemColors.Control
        Me.CmbSupplierName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbSupplierName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.CmbSupplierName.FormattingEnabled = True
        Me.CmbSupplierName.Location = New System.Drawing.Point(117, 14)
        Me.CmbSupplierName.Name = "CmbSupplierName"
        Me.CmbSupplierName.Size = New System.Drawing.Size(247, 21)
        Me.CmbSupplierName.TabIndex = 101
        '
        'LblPhoneNo
        '
        Me.LblPhoneNo.AutoSize = True
        Me.LblPhoneNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LblPhoneNo.Location = New System.Drawing.Point(7, 45)
        Me.LblPhoneNo.Name = "LblPhoneNo"
        Me.LblPhoneNo.Size = New System.Drawing.Size(71, 16)
        Me.LblPhoneNo.TabIndex = 115
        Me.LblPhoneNo.Text = "Phone No:"
        '
        'LblSupplierName
        '
        Me.LblSupplierName.AutoSize = True
        Me.LblSupplierName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LblSupplierName.Location = New System.Drawing.Point(7, 17)
        Me.LblSupplierName.Name = "LblSupplierName"
        Me.LblSupplierName.Size = New System.Drawing.Size(101, 16)
        Me.LblSupplierName.TabIndex = 114
        Me.LblSupplierName.Text = "Supplier Name:"
        '
        'Timer1
        '
        '
        'FrmPurchaseReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1014, 736)
        Me.Controls.Add(Me.GrpSupplierInformation)
        Me.Controls.Add(Me.GrpSaleReturnInvoice)
        Me.Controls.Add(Me.GrpSearch)
        Me.Controls.Add(Me.GrpPurchaseReturn)
        Me.Controls.Add(Me.BtnHistory)
        Me.Controls.Add(Me.BtnNewInvoice)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.LblPurchaseReturnID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GrpPaymentInformation)
        Me.Controls.Add(Me.GrdPurchaseReturnSerialNumber)
        Me.Controls.Add(Me.GrdPurchaseSerialNumber)
        Me.Controls.Add(Me.GrdPurchaseDetails)
        Me.Controls.Add(Me.GrdPurchaseReturn)
        Me.Controls.Add(Me.GrdPurchaseInvoice)
        Me.Controls.Add(Me.PnlPurchaseReturn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPurchaseReturn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase Return"
        Me.PnlPurchaseReturn.ResumeLayout(False)
        Me.PnlPurchaseReturn.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.GrdPurchaseInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdPurchaseReturn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdPurchaseDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdPurchaseSerialNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdPurchaseReturnSerialNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpPaymentInformation.ResumeLayout(False)
        Me.GrpPaymentInformation.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GrpPurchaseReturn.ResumeLayout(False)
        Me.GrpPurchaseReturn.PerformLayout()
        Me.GrpSearch.ResumeLayout(False)
        Me.GrpSearch.PerformLayout()
        Me.GrpSaleReturnInvoice.ResumeLayout(False)
        Me.GrpSaleReturnInvoice.PerformLayout()
        Me.GrpSupplierInformation.ResumeLayout(False)
        Me.GrpSupplierInformation.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PnlPurchaseReturn As System.Windows.Forms.Panel
    Friend WithEvents LblPurchaseReturn As System.Windows.Forms.Label
    Friend WithEvents CmbSearch As System.Windows.Forms.ComboBox
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents GrdPurchaseInvoice As System.Windows.Forms.DataGridView
    Friend WithEvents GrdPurchaseReturn As System.Windows.Forms.DataGridView
    Friend WithEvents LblReturnedQuantity As System.Windows.Forms.Label
    Friend WithEvents LblReturnedDate As System.Windows.Forms.Label
    Friend WithEvents TxtReturnedQuantity As System.Windows.Forms.TextBox
    Friend WithEvents DtpReturnedDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents GrdPurchaseDetails As System.Windows.Forms.DataGridView
    Friend WithEvents GrdPurchaseSerialNumber As System.Windows.Forms.DataGridView
    Friend WithEvents lblInvoiceNo As System.Windows.Forms.Label
    Friend WithEvents TxtPurchaseReturnInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents GrdPurchaseReturnSerialNumber As System.Windows.Forms.DataGridView
    Friend WithEvents GrpPaymentInformation As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbPaidBy As System.Windows.Forms.ComboBox
    Friend WithEvents LblPaidBy As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents TxtNetPayable As System.Windows.Forms.TextBox
    Friend WithEvents TxtPaidAmount As System.Windows.Forms.TextBox
    Friend WithEvents TxtDiscountPercentage As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents LblPaidAmount As System.Windows.Forms.Label
    Friend WithEvents LblNetPayable As System.Windows.Forms.Label
    Friend WithEvents LblDiscount As System.Windows.Forms.Label
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnInvoice As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblPurchaseReturnID As System.Windows.Forms.Label
    Friend WithEvents CmbSerialNumber As System.Windows.Forms.ComboBox
    Friend WithEvents LblSingleSerialNumber As System.Windows.Forms.Label
    Friend WithEvents BtnHistory As System.Windows.Forms.Button
    Friend WithEvents BtnNewInvoice As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents GrpPurchaseReturn As System.Windows.Forms.GroupBox
    Friend WithEvents GrpSearch As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GrpSaleReturnInvoice As System.Windows.Forms.GroupBox
    Friend WithEvents GrpSupplierInformation As System.Windows.Forms.GroupBox
    Friend WithEvents TxtAddress As System.Windows.Forms.TextBox
    Friend WithEvents LblAddress As System.Windows.Forms.Label
    Friend WithEvents TxtPhoneNo As System.Windows.Forms.TextBox
    Friend WithEvents CmbSupplierName As System.Windows.Forms.ComboBox
    Friend WithEvents LblPhoneNo As System.Windows.Forms.Label
    Friend WithEvents LblSupplierName As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
End Class
