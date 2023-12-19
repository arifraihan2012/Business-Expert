<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWarrantyDelivery
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
        Me.LblWarrantyDelivery = New System.Windows.Forms.Label
        Me.PnlWarrantyLookUp = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LblDate = New System.Windows.Forms.Label
        Me.DtpDeliveryDate = New System.Windows.Forms.DateTimePicker
        Me.TxtWarrantyDeliveryInvoiceNo = New System.Windows.Forms.TextBox
        Me.LblWarrantyInvoice = New System.Windows.Forms.Label
        Me.TxtSerialNumber = New System.Windows.Forms.TextBox
        Me.LblSerialNumber = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.BtnAddToDelivery = New System.Windows.Forms.Button
        Me.TxtSearch = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.LblRemarks = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.LblAddressCustomer = New System.Windows.Forms.Label
        Me.LblAddressLbl = New System.Windows.Forms.Label
        Me.LbLCustomerNameLbl = New System.Windows.Forms.Label
        Me.LblCustomerName = New System.Windows.Forms.Label
        Me.LblPhoneNoCustomer = New System.Windows.Forms.Label
        Me.LblPhoneNoLbl = New System.Windows.Forms.Label
        Me.TxtRemarks = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.BtnHistory = New System.Windows.Forms.Button
        Me.BtnInvoice = New System.Windows.Forms.Button
        Me.TxtReplacedSerialNumber = New System.Windows.Forms.TextBox
        Me.LblReplacedSerialNumber = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.GrdProductsDetails = New System.Windows.Forms.DataGridView
        Me.GrdWarrantySerialNumber = New System.Windows.Forms.DataGridView
        Me.GrdProblemDetails = New System.Windows.Forms.DataGridView
        Me.GrdDeliveryDetails = New System.Windows.Forms.DataGridView
        Me.GrdDeliverySerial = New System.Windows.Forms.DataGridView
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnAddNew = New System.Windows.Forms.Button
        Me.BtnRefresh = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.PnlWarrantyLookUp.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GrdProductsDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdWarrantySerialNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdProblemDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdDeliveryDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdDeliverySerial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblWarrantyDelivery
        '
        Me.LblWarrantyDelivery.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblWarrantyDelivery.AutoSize = True
        Me.LblWarrantyDelivery.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWarrantyDelivery.ForeColor = System.Drawing.Color.White
        Me.LblWarrantyDelivery.Location = New System.Drawing.Point(445, 35)
        Me.LblWarrantyDelivery.Name = "LblWarrantyDelivery"
        Me.LblWarrantyDelivery.Size = New System.Drawing.Size(286, 37)
        Me.LblWarrantyDelivery.TabIndex = 0
        Me.LblWarrantyDelivery.Text = "Warranty Delivery"
        '
        'PnlWarrantyLookUp
        '
        Me.PnlWarrantyLookUp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlWarrantyLookUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlWarrantyLookUp.Controls.Add(Me.LblWarrantyDelivery)
        Me.PnlWarrantyLookUp.Location = New System.Drawing.Point(0, 0)
        Me.PnlWarrantyLookUp.Name = "PnlWarrantyLookUp"
        Me.PnlWarrantyLookUp.Size = New System.Drawing.Size(1191, 83)
        Me.PnlWarrantyLookUp.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.LblDate)
        Me.GroupBox1.Controls.Add(Me.DtpDeliveryDate)
        Me.GroupBox1.Controls.Add(Me.TxtWarrantyDeliveryInvoiceNo)
        Me.GroupBox1.Controls.Add(Me.LblWarrantyInvoice)
        Me.GroupBox1.Location = New System.Drawing.Point(989, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(184, 62)
        Me.GroupBox1.TabIndex = 2085
        Me.GroupBox1.TabStop = False
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
        'DtpDeliveryDate
        '
        Me.DtpDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDeliveryDate.Location = New System.Drawing.Point(81, 37)
        Me.DtpDeliveryDate.Name = "DtpDeliveryDate"
        Me.DtpDeliveryDate.Size = New System.Drawing.Size(95, 20)
        Me.DtpDeliveryDate.TabIndex = 2050
        Me.DtpDeliveryDate.Value = New Date(2017, 7, 28, 0, 0, 0, 0)
        '
        'TxtWarrantyDeliveryInvoiceNo
        '
        Me.TxtWarrantyDeliveryInvoiceNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtWarrantyDeliveryInvoiceNo.Enabled = False
        Me.TxtWarrantyDeliveryInvoiceNo.Location = New System.Drawing.Point(81, 10)
        Me.TxtWarrantyDeliveryInvoiceNo.Name = "TxtWarrantyDeliveryInvoiceNo"
        Me.TxtWarrantyDeliveryInvoiceNo.Size = New System.Drawing.Size(95, 20)
        Me.TxtWarrantyDeliveryInvoiceNo.TabIndex = 2070
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
        'TxtSerialNumber
        '
        Me.TxtSerialNumber.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtSerialNumber.Location = New System.Drawing.Point(96, 47)
        Me.TxtSerialNumber.Name = "TxtSerialNumber"
        Me.TxtSerialNumber.Size = New System.Drawing.Size(183, 20)
        Me.TxtSerialNumber.TabIndex = 2089
        '
        'LblSerialNumber
        '
        Me.LblSerialNumber.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblSerialNumber.AutoSize = True
        Me.LblSerialNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSerialNumber.Location = New System.Drawing.Point(6, 46)
        Me.LblSerialNumber.Name = "LblSerialNumber"
        Me.LblSerialNumber.Size = New System.Drawing.Size(90, 15)
        Me.LblSerialNumber.TabIndex = 2090
        Me.LblSerialNumber.Text = "Serial Number:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox3.Controls.Add(Me.BtnAddToDelivery)
        Me.GroupBox3.Controls.Add(Me.TxtSearch)
        Me.GroupBox3.Controls.Add(Me.TxtSerialNumber)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.LblSerialNumber)
        Me.GroupBox3.Location = New System.Drawing.Point(378, 91)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(430, 83)
        Me.GroupBox3.TabIndex = 2091
        Me.GroupBox3.TabStop = False
        '
        'BtnAddToDelivery
        '
        Me.BtnAddToDelivery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAddToDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddToDelivery.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddToDelivery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddToDelivery.Location = New System.Drawing.Point(285, 45)
        Me.BtnAddToDelivery.Name = "BtnAddToDelivery"
        Me.BtnAddToDelivery.Size = New System.Drawing.Size(139, 25)
        Me.BtnAddToDelivery.TabIndex = 2091
        Me.BtnAddToDelivery.Text = "Add to Delivery"
        Me.BtnAddToDelivery.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.BtnAddToDelivery.UseVisualStyleBackColor = True
        '
        'TxtSearch
        '
        Me.TxtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtSearch.Location = New System.Drawing.Point(96, 18)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(183, 20)
        Me.TxtSearch.TabIndex = 2089
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 2090
        Me.Label1.Text = "Invoice No:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblRemarks)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.LblAddressCustomer)
        Me.GroupBox2.Controls.Add(Me.LblAddressLbl)
        Me.GroupBox2.Controls.Add(Me.LbLCustomerNameLbl)
        Me.GroupBox2.Controls.Add(Me.LblCustomerName)
        Me.GroupBox2.Controls.Add(Me.LblPhoneNoCustomer)
        Me.GroupBox2.Controls.Add(Me.LblPhoneNoLbl)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 86)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(340, 88)
        Me.GroupBox2.TabIndex = 2092
        Me.GroupBox2.TabStop = False
        '
        'LblRemarks
        '
        Me.LblRemarks.AutoSize = True
        Me.LblRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.LblRemarks.Location = New System.Drawing.Point(97, 68)
        Me.LblRemarks.Name = "LblRemarks"
        Me.LblRemarks.Size = New System.Drawing.Size(32, 13)
        Me.LblRemarks.TabIndex = 2094
        Me.LblRemarks.Text = "None"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label4.Location = New System.Drawing.Point(11, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 2093
        Me.Label4.Text = "Remarks:"
        '
        'LblAddressCustomer
        '
        Me.LblAddressCustomer.AutoSize = True
        Me.LblAddressCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.LblAddressCustomer.Location = New System.Drawing.Point(97, 51)
        Me.LblAddressCustomer.Name = "LblAddressCustomer"
        Me.LblAddressCustomer.Size = New System.Drawing.Size(32, 13)
        Me.LblAddressCustomer.TabIndex = 134
        Me.LblAddressCustomer.Text = "None"
        '
        'LblAddressLbl
        '
        Me.LblAddressLbl.AutoSize = True
        Me.LblAddressLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.LblAddressLbl.Location = New System.Drawing.Point(11, 50)
        Me.LblAddressLbl.Name = "LblAddressLbl"
        Me.LblAddressLbl.Size = New System.Drawing.Size(48, 13)
        Me.LblAddressLbl.TabIndex = 133
        Me.LblAddressLbl.Text = "Address:"
        '
        'LbLCustomerNameLbl
        '
        Me.LbLCustomerNameLbl.AutoSize = True
        Me.LbLCustomerNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.LbLCustomerNameLbl.Location = New System.Drawing.Point(11, 16)
        Me.LbLCustomerNameLbl.Name = "LbLCustomerNameLbl"
        Me.LbLCustomerNameLbl.Size = New System.Drawing.Size(84, 13)
        Me.LbLCustomerNameLbl.TabIndex = 132
        Me.LbLCustomerNameLbl.Text = "Customer Name:"
        '
        'LblCustomerName
        '
        Me.LblCustomerName.AutoSize = True
        Me.LblCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.LblCustomerName.Location = New System.Drawing.Point(97, 17)
        Me.LblCustomerName.Name = "LblCustomerName"
        Me.LblCustomerName.Size = New System.Drawing.Size(32, 13)
        Me.LblCustomerName.TabIndex = 131
        Me.LblCustomerName.Text = "None"
        '
        'LblPhoneNoCustomer
        '
        Me.LblPhoneNoCustomer.AutoSize = True
        Me.LblPhoneNoCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.LblPhoneNoCustomer.Location = New System.Drawing.Point(97, 34)
        Me.LblPhoneNoCustomer.Name = "LblPhoneNoCustomer"
        Me.LblPhoneNoCustomer.Size = New System.Drawing.Size(32, 13)
        Me.LblPhoneNoCustomer.TabIndex = 130
        Me.LblPhoneNoCustomer.Text = "None"
        '
        'LblPhoneNoLbl
        '
        Me.LblPhoneNoLbl.AutoSize = True
        Me.LblPhoneNoLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.LblPhoneNoLbl.Location = New System.Drawing.Point(11, 33)
        Me.LblPhoneNoLbl.Name = "LblPhoneNoLbl"
        Me.LblPhoneNoLbl.Size = New System.Drawing.Size(57, 13)
        Me.LblPhoneNoLbl.TabIndex = 129
        Me.LblPhoneNoLbl.Text = "Phone No:"
        '
        'TxtRemarks
        '
        Me.TxtRemarks.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtRemarks.Location = New System.Drawing.Point(80, 19)
        Me.TxtRemarks.Multiline = True
        Me.TxtRemarks.Name = "TxtRemarks"
        Me.TxtRemarks.Size = New System.Drawing.Size(603, 43)
        Me.TxtRemarks.TabIndex = 2091
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.TxtRemarks)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 409)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1161, 79)
        Me.GroupBox4.TabIndex = 2094
        Me.GroupBox4.TabStop = False
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 15)
        Me.Label5.TabIndex = 2091
        Me.Label5.Text = "Remarks:"
        '
        'BtnHistory
        '
        Me.BtnHistory.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHistory.Image = Global.Business_Expert_Pro.My.Resources.Resources.Last_view1
        Me.BtnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHistory.Location = New System.Drawing.Point(365, 368)
        Me.BtnHistory.Name = "BtnHistory"
        Me.BtnHistory.Size = New System.Drawing.Size(94, 35)
        Me.BtnHistory.TabIndex = 2099
        Me.BtnHistory.Text = "History"
        Me.BtnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnHistory.UseVisualStyleBackColor = True
        '
        'BtnInvoice
        '
        Me.BtnInvoice.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInvoice.Image = Global.Business_Expert_Pro.My.Resources.Resources.Last_view1
        Me.BtnInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInvoice.Location = New System.Drawing.Point(465, 368)
        Me.BtnInvoice.Name = "BtnInvoice"
        Me.BtnInvoice.Size = New System.Drawing.Size(94, 35)
        Me.BtnInvoice.TabIndex = 2093
        Me.BtnInvoice.Text = "Invoice"
        Me.BtnInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnInvoice.UseVisualStyleBackColor = True
        '
        'TxtReplacedSerialNumber
        '
        Me.TxtReplacedSerialNumber.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtReplacedSerialNumber.Location = New System.Drawing.Point(474, 177)
        Me.TxtReplacedSerialNumber.Name = "TxtReplacedSerialNumber"
        Me.TxtReplacedSerialNumber.Size = New System.Drawing.Size(183, 20)
        Me.TxtReplacedSerialNumber.TabIndex = 2092
        Me.TxtReplacedSerialNumber.Visible = False
        '
        'LblReplacedSerialNumber
        '
        Me.LblReplacedSerialNumber.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblReplacedSerialNumber.AutoSize = True
        Me.LblReplacedSerialNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReplacedSerialNumber.Location = New System.Drawing.Point(325, 179)
        Me.LblReplacedSerialNumber.Name = "LblReplacedSerialNumber"
        Me.LblReplacedSerialNumber.Size = New System.Drawing.Size(143, 15)
        Me.LblReplacedSerialNumber.TabIndex = 2093
        Me.LblReplacedSerialNumber.Text = "Replaced Serial Number"
        Me.LblReplacedSerialNumber.Visible = False
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
        Me.Panel1.Size = New System.Drawing.Size(1183, 28)
        Me.Panel1.TabIndex = 2100
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(1159, 1)
        Me.Btnclose.Name = "Btnclose"
        Me.Btnclose.Size = New System.Drawing.Size(21, 24)
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
        Me.Btnminimized.Location = New System.Drawing.Point(1102, 1)
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
        Me.Btnmaximized.Location = New System.Drawing.Point(1129, 1)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1160
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
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
        Me.GrdProductsDetails.Location = New System.Drawing.Point(7, 211)
        Me.GrdProductsDetails.Name = "GrdProductsDetails"
        Me.GrdProductsDetails.ReadOnly = True
        Me.GrdProductsDetails.Size = New System.Drawing.Size(423, 134)
        Me.GrdProductsDetails.TabIndex = 2101
        '
        'GrdWarrantySerialNumber
        '
        Me.GrdWarrantySerialNumber.AllowUserToAddRows = False
        Me.GrdWarrantySerialNumber.AllowUserToDeleteRows = False
        Me.GrdWarrantySerialNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdWarrantySerialNumber.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdWarrantySerialNumber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdWarrantySerialNumber.Location = New System.Drawing.Point(436, 211)
        Me.GrdWarrantySerialNumber.Name = "GrdWarrantySerialNumber"
        Me.GrdWarrantySerialNumber.ReadOnly = True
        Me.GrdWarrantySerialNumber.Size = New System.Drawing.Size(231, 134)
        Me.GrdWarrantySerialNumber.TabIndex = 2102
        '
        'GrdProblemDetails
        '
        Me.GrdProblemDetails.AllowUserToAddRows = False
        Me.GrdProblemDetails.AllowUserToDeleteRows = False
        Me.GrdProblemDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdProblemDetails.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdProblemDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdProblemDetails.Location = New System.Drawing.Point(673, 211)
        Me.GrdProblemDetails.Name = "GrdProblemDetails"
        Me.GrdProblemDetails.ReadOnly = True
        Me.GrdProblemDetails.Size = New System.Drawing.Size(500, 134)
        Me.GrdProblemDetails.TabIndex = 2103
        '
        'GrdDeliveryDetails
        '
        Me.GrdDeliveryDetails.AllowUserToAddRows = False
        Me.GrdDeliveryDetails.AllowUserToDeleteRows = False
        Me.GrdDeliveryDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdDeliveryDetails.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdDeliveryDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdDeliveryDetails.Location = New System.Drawing.Point(8, 496)
        Me.GrdDeliveryDetails.Name = "GrdDeliveryDetails"
        Me.GrdDeliveryDetails.ReadOnly = True
        Me.GrdDeliveryDetails.Size = New System.Drawing.Size(907, 156)
        Me.GrdDeliveryDetails.TabIndex = 2104
        '
        'GrdDeliverySerial
        '
        Me.GrdDeliverySerial.AllowUserToAddRows = False
        Me.GrdDeliverySerial.AllowUserToDeleteRows = False
        Me.GrdDeliverySerial.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdDeliverySerial.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdDeliverySerial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdDeliverySerial.Location = New System.Drawing.Point(923, 496)
        Me.GrdDeliverySerial.Name = "GrdDeliverySerial"
        Me.GrdDeliverySerial.ReadOnly = True
        Me.GrdDeliverySerial.Size = New System.Drawing.Size(250, 156)
        Me.GrdDeliverySerial.TabIndex = 2105
        '
        'BtnDelete
        '
        Me.BtnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.Image = Global.Business_Expert_Pro.My.Resources.Resources.Delete_32px1
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(588, 368)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(107, 35)
        Me.BtnDelete.TabIndex = 2098
        Me.BtnDelete.Text = "Delete Inv."
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnAddNew
        '
        Me.BtnAddNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddNew.Image = Global.Business_Expert_Pro.My.Resources.Resources.Add_New2
        Me.BtnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddNew.Location = New System.Drawing.Point(12, 368)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(95, 35)
        Me.BtnAddNew.TabIndex = 2097
        Me.BtnAddNew.Text = "New Inv."
        Me.BtnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefresh.Image = Global.Business_Expert_Pro.My.Resources.Resources.Reboot_32px2
        Me.BtnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRefresh.Location = New System.Drawing.Point(112, 368)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(95, 35)
        Me.BtnRefresh.TabIndex = 2096
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Business_Expert_Pro.My.Resources.Resources.Save_32px_31
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(212, 368)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 35)
        Me.Button1.TabIndex = 2095
        Me.Button1.Text = "Save Inv."
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmWarrantyDelivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 664)
        Me.Controls.Add(Me.GrdDeliverySerial)
        Me.Controls.Add(Me.GrdDeliveryDetails)
        Me.Controls.Add(Me.GrdProblemDetails)
        Me.Controls.Add(Me.GrdWarrantySerialNumber)
        Me.Controls.Add(Me.GrdProductsDetails)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TxtReplacedSerialNumber)
        Me.Controls.Add(Me.LblReplacedSerialNumber)
        Me.Controls.Add(Me.BtnHistory)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.BtnInvoice)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PnlWarrantyLookUp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmWarrantyDelivery"
        Me.Text = "Warranty Delivery"
        Me.PnlWarrantyLookUp.ResumeLayout(False)
        Me.PnlWarrantyLookUp.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.GrdProductsDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdWarrantySerialNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdProblemDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdDeliveryDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdDeliverySerial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblWarrantyDelivery As System.Windows.Forms.Label
    Friend WithEvents PnlWarrantyLookUp As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LblDate As System.Windows.Forms.Label
    Friend WithEvents DtpDeliveryDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtWarrantyDeliveryInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents LblWarrantyInvoice As System.Windows.Forms.Label
    Friend WithEvents TxtSerialNumber As System.Windows.Forms.TextBox
    Friend WithEvents LblSerialNumber As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LbLCustomerNameLbl As System.Windows.Forms.Label
    Friend WithEvents LblCustomerName As System.Windows.Forms.Label
    Friend WithEvents LblPhoneNoCustomer As System.Windows.Forms.Label
    Friend WithEvents LblPhoneNoLbl As System.Windows.Forms.Label
    Friend WithEvents LblAddressCustomer As System.Windows.Forms.Label
    Friend WithEvents LblAddressLbl As System.Windows.Forms.Label
    Friend WithEvents LblRemarks As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents BtnInvoice As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnHistory As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtnAddToDelivery As System.Windows.Forms.Button
    Friend WithEvents TxtReplacedSerialNumber As System.Windows.Forms.TextBox
    Friend WithEvents LblReplacedSerialNumber As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
    Friend WithEvents GrdProductsDetails As System.Windows.Forms.DataGridView
    Friend WithEvents GrdWarrantySerialNumber As System.Windows.Forms.DataGridView
    Friend WithEvents GrdProblemDetails As System.Windows.Forms.DataGridView
    Friend WithEvents GrdDeliveryDetails As System.Windows.Forms.DataGridView
    Friend WithEvents GrdDeliverySerial As System.Windows.Forms.DataGridView
End Class
