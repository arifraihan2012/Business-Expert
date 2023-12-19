<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSaleReturn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSaleReturn))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.LblSaleReturn = New System.Windows.Forms.Label
        Me.CmbSearch = New System.Windows.Forms.ComboBox
        Me.TxtSearch = New System.Windows.Forms.TextBox
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.LblReturnedQuantity = New System.Windows.Forms.Label
        Me.LblReturnedDate = New System.Windows.Forms.Label
        Me.TxtReturnedQuantity = New System.Windows.Forms.TextBox
        Me.DtpReturnedDate = New System.Windows.Forms.DateTimePicker
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.lblInvoiceNo = New System.Windows.Forms.Label
        Me.TxtSaleReturnInvoiceNo = New System.Windows.Forms.TextBox
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
        Me.LblSaleReturnID = New System.Windows.Forms.Label
        Me.CmbSerialNumber = New System.Windows.Forms.ComboBox
        Me.LblSingleSerialNumber = New System.Windows.Forms.Label
        Me.BtnHistory = New System.Windows.Forms.Button
        Me.BtnNewInvoice = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.GrpSaleReturn = New System.Windows.Forms.GroupBox
        Me.GrpSearch = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GrpSaleReturnInvoice = New System.Windows.Forms.GroupBox
        Me.GrpCustomerInformation = New System.Windows.Forms.GroupBox
        Me.TxtAddress = New System.Windows.Forms.TextBox
        Me.LblAddress = New System.Windows.Forms.Label
        Me.TxtPhoneNo = New System.Windows.Forms.TextBox
        Me.CmbCustomerName = New System.Windows.Forms.ComboBox
        Me.LblPhoneNo = New System.Windows.Forms.Label
        Me.LblCustomerName = New System.Windows.Forms.Label
        Me.GrdSaleInvoice = New System.Windows.Forms.DataGridView
        Me.GrdSaleDetails = New System.Windows.Forms.DataGridView
        Me.GrdSaleSerialNumber = New System.Windows.Forms.DataGridView
        Me.GrdSaleReturn = New System.Windows.Forms.DataGridView
        Me.GrdSaleReturnSerialNumber = New System.Windows.Forms.DataGridView
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GrpPaymentInformation.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GrpSaleReturn.SuspendLayout()
        Me.GrpSearch.SuspendLayout()
        Me.GrpSaleReturnInvoice.SuspendLayout()
        Me.GrpCustomerInformation.SuspendLayout()
        CType(Me.GrdSaleInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdSaleDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdSaleSerialNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdSaleReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdSaleReturnSerialNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.LblSaleReturn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1014, 76)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Btnclose)
        Me.Panel2.Controls.Add(Me.Btnminimized)
        Me.Panel2.Controls.Add(Me.Btnmaximized)
        Me.Panel2.Location = New System.Drawing.Point(-1, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1014, 27)
        Me.Panel2.TabIndex = 2058
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(990, 0)
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
        Me.Btnminimized.Location = New System.Drawing.Point(930, 0)
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
        Me.Btnmaximized.Location = New System.Drawing.Point(960, 0)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1160
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'LblSaleReturn
        '
        Me.LblSaleReturn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblSaleReturn.AutoSize = True
        Me.LblSaleReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSaleReturn.ForeColor = System.Drawing.Color.White
        Me.LblSaleReturn.Location = New System.Drawing.Point(417, 30)
        Me.LblSaleReturn.Name = "LblSaleReturn"
        Me.LblSaleReturn.Size = New System.Drawing.Size(179, 33)
        Me.LblSaleReturn.TabIndex = 0
        Me.LblSaleReturn.Text = "Sale Return"
        '
        'CmbSearch
        '
        Me.CmbSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.CmbSearch.FormattingEnabled = True
        Me.CmbSearch.Items.AddRange(New Object() {"Customer Name", "Invoice No", "Mobile No", "Product"})
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
        'TxtSaleReturnInvoiceNo
        '
        Me.TxtSaleReturnInvoiceNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSaleReturnInvoiceNo.Location = New System.Drawing.Point(103, 17)
        Me.TxtSaleReturnInvoiceNo.Name = "TxtSaleReturnInvoiceNo"
        Me.TxtSaleReturnInvoiceNo.ReadOnly = True
        Me.TxtSaleReturnInvoiceNo.Size = New System.Drawing.Size(129, 20)
        Me.TxtSaleReturnInvoiceNo.TabIndex = 2063
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
        Me.GrpPaymentInformation.Location = New System.Drawing.Point(755, 487)
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
        Me.GroupBox1.Location = New System.Drawing.Point(755, 654)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(251, 72)
        Me.GroupBox1.TabIndex = 2067
        Me.GroupBox1.TabStop = False
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Image = Global.Business_Expert_Pro.My.Resources.Resources.Save_32px_32
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
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 2068
        Me.Label1.Text = "Sale Return ID:"
        '
        'LblSaleReturnID
        '
        Me.LblSaleReturnID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblSaleReturnID.AutoSize = True
        Me.LblSaleReturnID.Location = New System.Drawing.Point(98, 722)
        Me.LblSaleReturnID.Name = "LblSaleReturnID"
        Me.LblSaleReturnID.Size = New System.Drawing.Size(19, 13)
        Me.LblSaleReturnID.TabIndex = 2069
        Me.LblSaleReturnID.Text = "00"
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
        Me.BtnHistory.Location = New System.Drawing.Point(755, 173)
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
        Me.BtnNewInvoice.Image = Global.Business_Expert_Pro.My.Resources.Resources.Add_New3
        Me.BtnNewInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNewInvoice.Location = New System.Drawing.Point(641, 173)
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
        Me.BtnDelete.Image = Global.Business_Expert_Pro.My.Resources.Resources.Delete_32px3
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(869, 173)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(108, 35)
        Me.BtnDelete.TabIndex = 2072
        Me.BtnDelete.Text = "Delete Inv."
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'GrpSaleReturn
        '
        Me.GrpSaleReturn.Controls.Add(Me.LblSingleSerialNumber)
        Me.GrpSaleReturn.Controls.Add(Me.CmbSerialNumber)
        Me.GrpSaleReturn.Controls.Add(Me.TxtReturnedQuantity)
        Me.GrpSaleReturn.Controls.Add(Me.LblReturnedQuantity)
        Me.GrpSaleReturn.Controls.Add(Me.BtnAdd)
        Me.GrpSaleReturn.Enabled = False
        Me.GrpSaleReturn.Location = New System.Drawing.Point(18, 434)
        Me.GrpSaleReturn.Name = "GrpSaleReturn"
        Me.GrpSaleReturn.Size = New System.Drawing.Size(731, 49)
        Me.GrpSaleReturn.TabIndex = 2076
        Me.GrpSaleReturn.TabStop = False
        '
        'GrpSearch
        '
        Me.GrpSearch.Controls.Add(Me.Label4)
        Me.GrpSearch.Controls.Add(Me.BtnSearch)
        Me.GrpSearch.Controls.Add(Me.TxtSearch)
        Me.GrpSearch.Controls.Add(Me.CmbSearch)
        Me.GrpSearch.Location = New System.Drawing.Point(18, 164)
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
        Me.GrpSaleReturnInvoice.Controls.Add(Me.TxtSaleReturnInvoiceNo)
        Me.GrpSaleReturnInvoice.Controls.Add(Me.DtpReturnedDate)
        Me.GrpSaleReturnInvoice.Controls.Add(Me.LblReturnedDate)
        Me.GrpSaleReturnInvoice.Location = New System.Drawing.Point(760, 82)
        Me.GrpSaleReturnInvoice.Name = "GrpSaleReturnInvoice"
        Me.GrpSaleReturnInvoice.Size = New System.Drawing.Size(245, 76)
        Me.GrpSaleReturnInvoice.TabIndex = 2078
        Me.GrpSaleReturnInvoice.TabStop = False
        '
        'GrpCustomerInformation
        '
        Me.GrpCustomerInformation.Controls.Add(Me.TxtAddress)
        Me.GrpCustomerInformation.Controls.Add(Me.LblAddress)
        Me.GrpCustomerInformation.Controls.Add(Me.TxtPhoneNo)
        Me.GrpCustomerInformation.Controls.Add(Me.CmbCustomerName)
        Me.GrpCustomerInformation.Controls.Add(Me.LblPhoneNo)
        Me.GrpCustomerInformation.Controls.Add(Me.LblCustomerName)
        Me.GrpCustomerInformation.Location = New System.Drawing.Point(18, 82)
        Me.GrpCustomerInformation.Name = "GrpCustomerInformation"
        Me.GrpCustomerInformation.Size = New System.Drawing.Size(736, 76)
        Me.GrpCustomerInformation.TabIndex = 2079
        Me.GrpCustomerInformation.TabStop = False
        Me.GrpCustomerInformation.Text = "Customer Information"
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
        'CmbCustomerName
        '
        Me.CmbCustomerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbCustomerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbCustomerName.BackColor = System.Drawing.SystemColors.Control
        Me.CmbCustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.CmbCustomerName.FormattingEnabled = True
        Me.CmbCustomerName.Location = New System.Drawing.Point(117, 14)
        Me.CmbCustomerName.Name = "CmbCustomerName"
        Me.CmbCustomerName.Size = New System.Drawing.Size(247, 21)
        Me.CmbCustomerName.TabIndex = 101
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
        'LblCustomerName
        '
        Me.LblCustomerName.AutoSize = True
        Me.LblCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LblCustomerName.Location = New System.Drawing.Point(7, 17)
        Me.LblCustomerName.Name = "LblCustomerName"
        Me.LblCustomerName.Size = New System.Drawing.Size(108, 16)
        Me.LblCustomerName.TabIndex = 114
        Me.LblCustomerName.Text = "Customer Name:"
        '
        'GrdSaleInvoice
        '
        Me.GrdSaleInvoice.AllowUserToAddRows = False
        Me.GrdSaleInvoice.AllowUserToDeleteRows = False
        Me.GrdSaleInvoice.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdSaleInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdSaleInvoice.Location = New System.Drawing.Point(18, 219)
        Me.GrdSaleInvoice.Name = "GrdSaleInvoice"
        Me.GrdSaleInvoice.ReadOnly = True
        Me.GrdSaleInvoice.Size = New System.Drawing.Size(614, 204)
        Me.GrdSaleInvoice.TabIndex = 2080
        '
        'GrdSaleDetails
        '
        Me.GrdSaleDetails.AllowUserToAddRows = False
        Me.GrdSaleDetails.AllowUserToDeleteRows = False
        Me.GrdSaleDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdSaleDetails.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdSaleDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdSaleDetails.Location = New System.Drawing.Point(638, 219)
        Me.GrdSaleDetails.Name = "GrdSaleDetails"
        Me.GrdSaleDetails.ReadOnly = True
        Me.GrdSaleDetails.Size = New System.Drawing.Size(191, 204)
        Me.GrdSaleDetails.TabIndex = 2081
        '
        'GrdSaleSerialNumber
        '
        Me.GrdSaleSerialNumber.AllowUserToAddRows = False
        Me.GrdSaleSerialNumber.AllowUserToDeleteRows = False
        Me.GrdSaleSerialNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdSaleSerialNumber.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdSaleSerialNumber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdSaleSerialNumber.Location = New System.Drawing.Point(836, 219)
        Me.GrdSaleSerialNumber.Name = "GrdSaleSerialNumber"
        Me.GrdSaleSerialNumber.ReadOnly = True
        Me.GrdSaleSerialNumber.Size = New System.Drawing.Size(169, 204)
        Me.GrdSaleSerialNumber.TabIndex = 2082
        '
        'GrdSaleReturn
        '
        Me.GrdSaleReturn.AllowUserToAddRows = False
        Me.GrdSaleReturn.AllowUserToDeleteRows = False
        Me.GrdSaleReturn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdSaleReturn.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdSaleReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdSaleReturn.Location = New System.Drawing.Point(18, 488)
        Me.GrdSaleReturn.Name = "GrdSaleReturn"
        Me.GrdSaleReturn.ReadOnly = True
        Me.GrdSaleReturn.Size = New System.Drawing.Size(598, 227)
        Me.GrdSaleReturn.TabIndex = 2083
        '
        'GrdSaleReturnSerialNumber
        '
        Me.GrdSaleReturnSerialNumber.AllowUserToAddRows = False
        Me.GrdSaleReturnSerialNumber.AllowUserToDeleteRows = False
        Me.GrdSaleReturnSerialNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdSaleReturnSerialNumber.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdSaleReturnSerialNumber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdSaleReturnSerialNumber.Location = New System.Drawing.Point(622, 490)
        Me.GrdSaleReturnSerialNumber.Name = "GrdSaleReturnSerialNumber"
        Me.GrdSaleReturnSerialNumber.ReadOnly = True
        Me.GrdSaleReturnSerialNumber.Size = New System.Drawing.Size(121, 225)
        Me.GrdSaleReturnSerialNumber.TabIndex = 2084
        '
        'FrmSaleReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1014, 736)
        Me.Controls.Add(Me.GrdSaleReturnSerialNumber)
        Me.Controls.Add(Me.GrdSaleReturn)
        Me.Controls.Add(Me.GrdSaleSerialNumber)
        Me.Controls.Add(Me.GrdSaleDetails)
        Me.Controls.Add(Me.GrdSaleInvoice)
        Me.Controls.Add(Me.GrpCustomerInformation)
        Me.Controls.Add(Me.GrpSaleReturnInvoice)
        Me.Controls.Add(Me.GrpSearch)
        Me.Controls.Add(Me.GrpSaleReturn)
        Me.Controls.Add(Me.BtnHistory)
        Me.Controls.Add(Me.BtnNewInvoice)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.LblSaleReturnID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GrpPaymentInformation)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSaleReturn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sale Return"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GrpPaymentInformation.ResumeLayout(False)
        Me.GrpPaymentInformation.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GrpSaleReturn.ResumeLayout(False)
        Me.GrpSaleReturn.PerformLayout()
        Me.GrpSearch.ResumeLayout(False)
        Me.GrpSearch.PerformLayout()
        Me.GrpSaleReturnInvoice.ResumeLayout(False)
        Me.GrpSaleReturnInvoice.PerformLayout()
        Me.GrpCustomerInformation.ResumeLayout(False)
        Me.GrpCustomerInformation.PerformLayout()
        CType(Me.GrdSaleInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdSaleDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdSaleSerialNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdSaleReturn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdSaleReturnSerialNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LblSaleReturn As System.Windows.Forms.Label
    Friend WithEvents CmbSearch As System.Windows.Forms.ComboBox
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents LblReturnedQuantity As System.Windows.Forms.Label
    Friend WithEvents LblReturnedDate As System.Windows.Forms.Label
    Friend WithEvents TxtReturnedQuantity As System.Windows.Forms.TextBox
    Friend WithEvents DtpReturnedDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents lblInvoiceNo As System.Windows.Forms.Label
    Friend WithEvents TxtSaleReturnInvoiceNo As System.Windows.Forms.TextBox
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
    Friend WithEvents LblSaleReturnID As System.Windows.Forms.Label
    Friend WithEvents CmbSerialNumber As System.Windows.Forms.ComboBox
    Friend WithEvents LblSingleSerialNumber As System.Windows.Forms.Label
    Friend WithEvents BtnHistory As System.Windows.Forms.Button
    Friend WithEvents BtnNewInvoice As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents GrpSaleReturn As System.Windows.Forms.GroupBox
    Friend WithEvents GrpSearch As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GrpSaleReturnInvoice As System.Windows.Forms.GroupBox
    Friend WithEvents GrpCustomerInformation As System.Windows.Forms.GroupBox
    Friend WithEvents LblAddress As System.Windows.Forms.Label
    Friend WithEvents TxtPhoneNo As System.Windows.Forms.TextBox
    Friend WithEvents LblPhoneNo As System.Windows.Forms.Label
    Friend WithEvents LblCustomerName As System.Windows.Forms.Label
    Friend WithEvents TxtAddress As System.Windows.Forms.TextBox
    Friend WithEvents CmbCustomerName As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
    Friend WithEvents GrdSaleInvoice As System.Windows.Forms.DataGridView
    Friend WithEvents GrdSaleDetails As System.Windows.Forms.DataGridView
    Friend WithEvents GrdSaleSerialNumber As System.Windows.Forms.DataGridView
    Friend WithEvents GrdSaleReturn As System.Windows.Forms.DataGridView
    Friend WithEvents GrdSaleReturnSerialNumber As System.Windows.Forms.DataGridView
End Class
