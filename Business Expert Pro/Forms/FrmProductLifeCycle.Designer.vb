<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProductLifeCycle
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
        Me.LblWarrantyLookUp = New System.Windows.Forms.Label
        Me.PnlProductLifeCycle = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.GrpSearch = New System.Windows.Forms.GroupBox
        Me.LblProductName = New System.Windows.Forms.Label
        Me.cmbProductName = New System.Windows.Forms.ComboBox
        Me.DtpTodate = New System.Windows.Forms.DateTimePicker
        Me.LblToDate = New System.Windows.Forms.Label
        Me.DtpFromDate = New System.Windows.Forms.DateTimePicker
        Me.LblFromDate = New System.Windows.Forms.Label
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.LblTotalPurchaeAmount = New System.Windows.Forms.Label
        Me.LblTotalPurchaseReturnQuantity = New System.Windows.Forms.Label
        Me.LblTotalSaleReturnQuantity = New System.Windows.Forms.Label
        Me.LblTotalSaleAmount = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.LblTotalSaleQuantity = New System.Windows.Forms.Label
        Me.LblTotalPurchaseQuantity = New System.Windows.Forms.Label
        Me.GrdPurchaseDetails = New System.Windows.Forms.DataGridView
        Me.GrdPurchaseReturnDetails = New System.Windows.Forms.DataGridView
        Me.GrdSaleDetails = New System.Windows.Forms.DataGridView
        Me.GrdSaleReturnDetails = New System.Windows.Forms.DataGridView
        Me.GrdProductTransferFrom = New System.Windows.Forms.DataGridView
        Me.Label7 = New System.Windows.Forms.Label
        Me.GrdProductTransferTo = New System.Windows.Forms.DataGridView
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.LblTotalTransferFrom = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.LblTotalTransferTo = New System.Windows.Forms.Label
        Me.lblCurrentStock = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.PnlProductLifeCycle.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GrpSearch.SuspendLayout()
        CType(Me.GrdPurchaseDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdPurchaseReturnDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdSaleDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdSaleReturnDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdProductTransferFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdProductTransferTo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblWarrantyLookUp
        '
        Me.LblWarrantyLookUp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblWarrantyLookUp.AutoSize = True
        Me.LblWarrantyLookUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWarrantyLookUp.ForeColor = System.Drawing.Color.White
        Me.LblWarrantyLookUp.Location = New System.Drawing.Point(440, 30)
        Me.LblWarrantyLookUp.Name = "LblWarrantyLookUp"
        Me.LblWarrantyLookUp.Size = New System.Drawing.Size(293, 37)
        Me.LblWarrantyLookUp.TabIndex = 0
        Me.LblWarrantyLookUp.Text = "Product Life Cycle"
        '
        'PnlProductLifeCycle
        '
        Me.PnlProductLifeCycle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlProductLifeCycle.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlProductLifeCycle.Controls.Add(Me.Panel1)
        Me.PnlProductLifeCycle.Controls.Add(Me.LblWarrantyLookUp)
        Me.PnlProductLifeCycle.Location = New System.Drawing.Point(-3, 0)
        Me.PnlProductLifeCycle.Name = "PnlProductLifeCycle"
        Me.PnlProductLifeCycle.Size = New System.Drawing.Size(1191, 71)
        Me.PnlProductLifeCycle.TabIndex = 2066
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Btnclose)
        Me.Panel1.Controls.Add(Me.Btnminimized)
        Me.Panel1.Controls.Add(Me.Btnmaximized)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1188, 28)
        Me.Panel1.TabIndex = 2053
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(1164, 2)
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
        Me.Btnminimized.Location = New System.Drawing.Point(1104, 2)
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
        Me.Btnmaximized.Location = New System.Drawing.Point(1134, 2)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1160
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'GrpSearch
        '
        Me.GrpSearch.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GrpSearch.Controls.Add(Me.LblProductName)
        Me.GrpSearch.Controls.Add(Me.cmbProductName)
        Me.GrpSearch.Controls.Add(Me.DtpTodate)
        Me.GrpSearch.Controls.Add(Me.LblToDate)
        Me.GrpSearch.Controls.Add(Me.DtpFromDate)
        Me.GrpSearch.Controls.Add(Me.LblFromDate)
        Me.GrpSearch.Controls.Add(Me.BtnSearch)
        Me.GrpSearch.Location = New System.Drawing.Point(243, 71)
        Me.GrpSearch.Name = "GrpSearch"
        Me.GrpSearch.Size = New System.Drawing.Size(699, 67)
        Me.GrpSearch.TabIndex = 2067
        Me.GrpSearch.TabStop = False
        '
        'LblProductName
        '
        Me.LblProductName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblProductName.AutoSize = True
        Me.LblProductName.Location = New System.Drawing.Point(98, 13)
        Me.LblProductName.Name = "LblProductName"
        Me.LblProductName.Size = New System.Drawing.Size(78, 13)
        Me.LblProductName.TabIndex = 1189
        Me.LblProductName.Text = "Product Name:"
        '
        'cmbProductName
        '
        Me.cmbProductName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbProductName.FormattingEnabled = True
        Me.cmbProductName.Location = New System.Drawing.Point(177, 13)
        Me.cmbProductName.Name = "cmbProductName"
        Me.cmbProductName.Size = New System.Drawing.Size(291, 21)
        Me.cmbProductName.TabIndex = 1188
        '
        'DtpTodate
        '
        Me.DtpTodate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpTodate.Location = New System.Drawing.Point(360, 41)
        Me.DtpTodate.Name = "DtpTodate"
        Me.DtpTodate.Size = New System.Drawing.Size(107, 20)
        Me.DtpTodate.TabIndex = 1186
        Me.DtpTodate.Value = New Date(2018, 2, 11, 0, 0, 0, 0)
        '
        'LblToDate
        '
        Me.LblToDate.AutoSize = True
        Me.LblToDate.Location = New System.Drawing.Point(296, 41)
        Me.LblToDate.Name = "LblToDate"
        Me.LblToDate.Size = New System.Drawing.Size(49, 13)
        Me.LblToDate.TabIndex = 1187
        Me.LblToDate.Text = "To Date:"
        '
        'DtpFromDate
        '
        Me.DtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFromDate.Location = New System.Drawing.Point(177, 41)
        Me.DtpFromDate.Name = "DtpFromDate"
        Me.DtpFromDate.Size = New System.Drawing.Size(113, 20)
        Me.DtpFromDate.TabIndex = 1184
        Me.DtpFromDate.Value = New Date(2018, 2, 11, 0, 0, 0, 0)
        '
        'LblFromDate
        '
        Me.LblFromDate.AutoSize = True
        Me.LblFromDate.Location = New System.Drawing.Point(98, 41)
        Me.LblFromDate.Name = "LblFromDate"
        Me.LblFromDate.Size = New System.Drawing.Size(59, 13)
        Me.LblFromDate.TabIndex = 1185
        Me.LblFromDate.Text = "From Date:"
        '
        'BtnSearch
        '
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Location = New System.Drawing.Point(490, 24)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(75, 23)
        Me.BtnSearch.TabIndex = 1167
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(228, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Purchase Details"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(209, 337)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 16)
        Me.Label1.TabIndex = 2068
        Me.Label1.Text = "Purchase Return Details"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(874, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 2069
        Me.Label2.Text = "Sale Details"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(852, 337)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 16)
        Me.Label3.TabIndex = 2070
        Me.Label3.Text = "Sale Return Details"
        '
        'LblTotalPurchaeAmount
        '
        Me.LblTotalPurchaeAmount.AutoSize = True
        Me.LblTotalPurchaeAmount.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalPurchaeAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblTotalPurchaeAmount.Location = New System.Drawing.Point(507, 301)
        Me.LblTotalPurchaeAmount.Name = "LblTotalPurchaeAmount"
        Me.LblTotalPurchaeAmount.Size = New System.Drawing.Size(20, 16)
        Me.LblTotalPurchaeAmount.TabIndex = 2071
        Me.LblTotalPurchaeAmount.Text = "00"
        '
        'LblTotalPurchaseReturnQuantity
        '
        Me.LblTotalPurchaseReturnQuantity.AutoSize = True
        Me.LblTotalPurchaseReturnQuantity.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalPurchaseReturnQuantity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblTotalPurchaseReturnQuantity.Location = New System.Drawing.Point(508, 477)
        Me.LblTotalPurchaseReturnQuantity.Name = "LblTotalPurchaseReturnQuantity"
        Me.LblTotalPurchaseReturnQuantity.Size = New System.Drawing.Size(20, 16)
        Me.LblTotalPurchaseReturnQuantity.TabIndex = 2072
        Me.LblTotalPurchaseReturnQuantity.Text = "00"
        '
        'LblTotalSaleReturnQuantity
        '
        Me.LblTotalSaleReturnQuantity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTotalSaleReturnQuantity.AutoSize = True
        Me.LblTotalSaleReturnQuantity.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalSaleReturnQuantity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblTotalSaleReturnQuantity.Location = New System.Drawing.Point(1066, 477)
        Me.LblTotalSaleReturnQuantity.Name = "LblTotalSaleReturnQuantity"
        Me.LblTotalSaleReturnQuantity.Size = New System.Drawing.Size(20, 16)
        Me.LblTotalSaleReturnQuantity.TabIndex = 2074
        Me.LblTotalSaleReturnQuantity.Text = "00"
        '
        'LblTotalSaleAmount
        '
        Me.LblTotalSaleAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTotalSaleAmount.AutoSize = True
        Me.LblTotalSaleAmount.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalSaleAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblTotalSaleAmount.Location = New System.Drawing.Point(1092, 300)
        Me.LblTotalSaleAmount.Name = "LblTotalSaleAmount"
        Me.LblTotalSaleAmount.Size = New System.Drawing.Size(20, 16)
        Me.LblTotalSaleAmount.TabIndex = 2073
        Me.LblTotalSaleAmount.Text = "00"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(922, 477)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 16)
        Me.Label9.TabIndex = 2078
        Me.Label9.Text = "Total Return Quantity:"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(977, 299)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 16)
        Me.Label10.TabIndex = 2077
        Me.Label10.Text = "Total Sale Amount:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(364, 477)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(127, 16)
        Me.Label11.TabIndex = 2076
        Me.Label11.Text = "Total Return Quantity:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(364, 301)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(135, 16)
        Me.Label12.TabIndex = 2075
        Me.Label12.Text = "Total Purchaes Amount:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(796, 299)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 16)
        Me.Label4.TabIndex = 2082
        Me.Label4.Text = "Total Sale Quantity:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(183, 300)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 16)
        Me.Label5.TabIndex = 2081
        Me.Label5.Text = "Total Purchase Quantity:"
        '
        'LblTotalSaleQuantity
        '
        Me.LblTotalSaleQuantity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTotalSaleQuantity.AutoSize = True
        Me.LblTotalSaleQuantity.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalSaleQuantity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblTotalSaleQuantity.Location = New System.Drawing.Point(940, 299)
        Me.LblTotalSaleQuantity.Name = "LblTotalSaleQuantity"
        Me.LblTotalSaleQuantity.Size = New System.Drawing.Size(20, 16)
        Me.LblTotalSaleQuantity.TabIndex = 2080
        Me.LblTotalSaleQuantity.Text = "00"
        '
        'LblTotalPurchaseQuantity
        '
        Me.LblTotalPurchaseQuantity.AutoSize = True
        Me.LblTotalPurchaseQuantity.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalPurchaseQuantity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblTotalPurchaseQuantity.Location = New System.Drawing.Point(327, 300)
        Me.LblTotalPurchaseQuantity.Name = "LblTotalPurchaseQuantity"
        Me.LblTotalPurchaseQuantity.Size = New System.Drawing.Size(20, 16)
        Me.LblTotalPurchaseQuantity.TabIndex = 2079
        Me.LblTotalPurchaseQuantity.Text = "00"
        '
        'GrdPurchaseDetails
        '
        Me.GrdPurchaseDetails.AllowUserToAddRows = False
        Me.GrdPurchaseDetails.AllowUserToDeleteRows = False
        Me.GrdPurchaseDetails.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdPurchaseDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdPurchaseDetails.Location = New System.Drawing.Point(6, 163)
        Me.GrdPurchaseDetails.Name = "GrdPurchaseDetails"
        Me.GrdPurchaseDetails.ReadOnly = True
        Me.GrdPurchaseDetails.Size = New System.Drawing.Size(561, 133)
        Me.GrdPurchaseDetails.TabIndex = 2083
        '
        'GrdPurchaseReturnDetails
        '
        Me.GrdPurchaseReturnDetails.AllowUserToAddRows = False
        Me.GrdPurchaseReturnDetails.AllowUserToDeleteRows = False
        Me.GrdPurchaseReturnDetails.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdPurchaseReturnDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdPurchaseReturnDetails.Location = New System.Drawing.Point(6, 356)
        Me.GrdPurchaseReturnDetails.Name = "GrdPurchaseReturnDetails"
        Me.GrdPurchaseReturnDetails.ReadOnly = True
        Me.GrdPurchaseReturnDetails.Size = New System.Drawing.Size(563, 118)
        Me.GrdPurchaseReturnDetails.TabIndex = 2084
        '
        'GrdSaleDetails
        '
        Me.GrdSaleDetails.AllowUserToAddRows = False
        Me.GrdSaleDetails.AllowUserToDeleteRows = False
        Me.GrdSaleDetails.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GrdSaleDetails.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdSaleDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdSaleDetails.Location = New System.Drawing.Point(603, 163)
        Me.GrdSaleDetails.Name = "GrdSaleDetails"
        Me.GrdSaleDetails.ReadOnly = True
        Me.GrdSaleDetails.Size = New System.Drawing.Size(563, 133)
        Me.GrdSaleDetails.TabIndex = 2085
        '
        'GrdSaleReturnDetails
        '
        Me.GrdSaleReturnDetails.AllowUserToAddRows = False
        Me.GrdSaleReturnDetails.AllowUserToDeleteRows = False
        Me.GrdSaleReturnDetails.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GrdSaleReturnDetails.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdSaleReturnDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdSaleReturnDetails.Location = New System.Drawing.Point(603, 356)
        Me.GrdSaleReturnDetails.Name = "GrdSaleReturnDetails"
        Me.GrdSaleReturnDetails.ReadOnly = True
        Me.GrdSaleReturnDetails.Size = New System.Drawing.Size(563, 118)
        Me.GrdSaleReturnDetails.TabIndex = 2086
        '
        'GrdProductTransferFrom
        '
        Me.GrdProductTransferFrom.AllowUserToAddRows = False
        Me.GrdProductTransferFrom.AllowUserToDeleteRows = False
        Me.GrdProductTransferFrom.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdProductTransferFrom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdProductTransferFrom.Location = New System.Drawing.Point(6, 532)
        Me.GrdProductTransferFrom.Name = "GrdProductTransferFrom"
        Me.GrdProductTransferFrom.ReadOnly = True
        Me.GrdProductTransferFrom.Size = New System.Drawing.Size(557, 133)
        Me.GrdProductTransferFrom.TabIndex = 2088
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(172, 513)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(215, 16)
        Me.Label7.TabIndex = 2087
        Me.Label7.Text = "Product Transferred From This Branch"
        '
        'GrdProductTransferTo
        '
        Me.GrdProductTransferTo.AllowUserToAddRows = False
        Me.GrdProductTransferTo.AllowUserToDeleteRows = False
        Me.GrdProductTransferTo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GrdProductTransferTo.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdProductTransferTo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdProductTransferTo.Location = New System.Drawing.Point(603, 532)
        Me.GrdProductTransferTo.Name = "GrdProductTransferTo"
        Me.GrdProductTransferTo.ReadOnly = True
        Me.GrdProductTransferTo.Size = New System.Drawing.Size(563, 133)
        Me.GrdProductTransferTo.TabIndex = 2090
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(807, 513)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(201, 16)
        Me.Label8.TabIndex = 2089
        Me.Label8.Text = "Product Transferred To This Branch"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(364, 679)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 16)
        Me.Label13.TabIndex = 2092
        Me.Label13.Text = "Total Quantity:"
        '
        'LblTotalTransferFrom
        '
        Me.LblTotalTransferFrom.AutoSize = True
        Me.LblTotalTransferFrom.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalTransferFrom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblTotalTransferFrom.Location = New System.Drawing.Point(508, 679)
        Me.LblTotalTransferFrom.Name = "LblTotalTransferFrom"
        Me.LblTotalTransferFrom.Size = New System.Drawing.Size(20, 16)
        Me.LblTotalTransferFrom.TabIndex = 2091
        Me.LblTotalTransferFrom.Text = "00"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(922, 679)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(87, 16)
        Me.Label14.TabIndex = 2094
        Me.Label14.Text = "Total Quantity:"
        '
        'LblTotalTransferTo
        '
        Me.LblTotalTransferTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTotalTransferTo.AutoSize = True
        Me.LblTotalTransferTo.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalTransferTo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblTotalTransferTo.Location = New System.Drawing.Point(1066, 679)
        Me.LblTotalTransferTo.Name = "LblTotalTransferTo"
        Me.LblTotalTransferTo.Size = New System.Drawing.Size(20, 16)
        Me.LblTotalTransferTo.TabIndex = 2093
        Me.LblTotalTransferTo.Text = "00"
        '
        'lblCurrentStock
        '
        Me.lblCurrentStock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCurrentStock.AutoSize = True
        Me.lblCurrentStock.Font = New System.Drawing.Font("Trebuchet MS", 15.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.lblCurrentStock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCurrentStock.Location = New System.Drawing.Point(1092, 111)
        Me.lblCurrentStock.Name = "lblCurrentStock"
        Me.lblCurrentStock.Size = New System.Drawing.Size(36, 27)
        Me.lblCurrentStock.TabIndex = 2095
        Me.lblCurrentStock.Text = "00"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(1060, 79)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(106, 20)
        Me.Label16.TabIndex = 2096
        Me.Label16.Text = "Current Stock"
        '
        'FrmProductLifeCycle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 704)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblCurrentStock)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.LblTotalTransferTo)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.LblTotalTransferFrom)
        Me.Controls.Add(Me.GrdProductTransferTo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GrdProductTransferFrom)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GrdSaleReturnDetails)
        Me.Controls.Add(Me.GrdSaleDetails)
        Me.Controls.Add(Me.GrdPurchaseReturnDetails)
        Me.Controls.Add(Me.GrdPurchaseDetails)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LblTotalSaleQuantity)
        Me.Controls.Add(Me.LblTotalPurchaseQuantity)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.LblTotalSaleReturnQuantity)
        Me.Controls.Add(Me.LblTotalSaleAmount)
        Me.Controls.Add(Me.LblTotalPurchaseReturnQuantity)
        Me.Controls.Add(Me.LblTotalPurchaeAmount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GrpSearch)
        Me.Controls.Add(Me.PnlProductLifeCycle)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmProductLifeCycle"
        Me.Text = "Product Life Cycle"
        Me.PnlProductLifeCycle.ResumeLayout(False)
        Me.PnlProductLifeCycle.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GrpSearch.ResumeLayout(False)
        Me.GrpSearch.PerformLayout()
        CType(Me.GrdPurchaseDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdPurchaseReturnDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdSaleDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdSaleReturnDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdProductTransferFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdProductTransferTo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblWarrantyLookUp As System.Windows.Forms.Label
    Friend WithEvents PnlProductLifeCycle As System.Windows.Forms.Panel
    Friend WithEvents GrpSearch As System.Windows.Forms.GroupBox
    Friend WithEvents DtpTodate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblToDate As System.Windows.Forms.Label
    Friend WithEvents DtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblFromDate As System.Windows.Forms.Label
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LblProductName As System.Windows.Forms.Label
    Friend WithEvents cmbProductName As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblTotalPurchaeAmount As System.Windows.Forms.Label
    Friend WithEvents LblTotalPurchaseReturnQuantity As System.Windows.Forms.Label
    Friend WithEvents LblTotalSaleReturnQuantity As System.Windows.Forms.Label
    Friend WithEvents LblTotalSaleAmount As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LblTotalSaleQuantity As System.Windows.Forms.Label
    Friend WithEvents LblTotalPurchaseQuantity As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
    Friend WithEvents GrdPurchaseDetails As System.Windows.Forms.DataGridView
    Friend WithEvents GrdPurchaseReturnDetails As System.Windows.Forms.DataGridView
    Friend WithEvents GrdSaleDetails As System.Windows.Forms.DataGridView
    Friend WithEvents GrdSaleReturnDetails As System.Windows.Forms.DataGridView
    Friend WithEvents GrdProductTransferFrom As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GrdProductTransferTo As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LblTotalTransferFrom As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents LblTotalTransferTo As System.Windows.Forms.Label
    Friend WithEvents lblCurrentStock As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
