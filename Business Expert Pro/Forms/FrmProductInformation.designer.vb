<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProductInformation
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
        Me.BtnClear = New System.Windows.Forms.Button
        Me.TxtBarcodeSerial = New System.Windows.Forms.TextBox
        Me.TxtReorderPoint = New System.Windows.Forms.TextBox
        Me.BtnUpload = New System.Windows.Forms.Button
        Me.GrpProductInformation = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.TxtDiscountAmount = New System.Windows.Forms.TextBox
        Me.CmbUnitType = New System.Windows.Forms.ComboBox
        Me.LblUnitType = New System.Windows.Forms.Label
        Me.TxtFromSerial = New System.Windows.Forms.TextBox
        Me.LblTo = New System.Windows.Forms.Label
        Me.LblTotalSerial = New System.Windows.Forms.Label
        Me.TxtOpeningStock = New System.Windows.Forms.TextBox
        Me.TxtToSerial = New System.Windows.Forms.TextBox
        Me.RdbRangeSerial = New System.Windows.Forms.RadioButton
        Me.Label8 = New System.Windows.Forms.Label
        Me.LblOpeningStock = New System.Windows.Forms.Label
        Me.TxtSerialNumber = New System.Windows.Forms.TextBox
        Me.TxtPurchasePrice = New System.Windows.Forms.TextBox
        Me.LblPurchasePrice = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtRemarks = New System.Windows.Forms.TextBox
        Me.LblRemarks = New System.Windows.Forms.Label
        Me.LblwholesalePrice = New System.Windows.Forms.Label
        Me.TxtWholeSalePrice = New System.Windows.Forms.TextBox
        Me.TxtSalePrice = New System.Windows.Forms.TextBox
        Me.LblSalePrice = New System.Windows.Forms.Label
        Me.CmbProductGroupID = New System.Windows.Forms.ComboBox
        Me.CmbProductCategoryID = New System.Windows.Forms.ComboBox
        Me.CmbProductSubcategoryID = New System.Windows.Forms.ComboBox
        Me.ProductPictureBox = New System.Windows.Forms.PictureBox
        Me.TxtProductName = New System.Windows.Forms.TextBox
        Me.TxtProductID = New System.Windows.Forms.TextBox
        Me.LblReorderPoint = New System.Windows.Forms.Label
        Me.LblBarcodeSerial = New System.Windows.Forms.Label
        Me.LblProductName = New System.Windows.Forms.Label
        Me.LblProductSubcategoryID = New System.Windows.Forms.Label
        Me.LblProductCategoryID = New System.Windows.Forms.Label
        Me.LblProductGroupID = New System.Windows.Forms.Label
        Me.LblProductID = New System.Windows.Forms.Label
        Me.PnlProductInformation = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.LblProductInformation = New System.Windows.Forms.Label
        Me.CmbSearch = New System.Windows.Forms.ComboBox
        Me.TxtSearch = New System.Windows.Forms.TextBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Label15 = New System.Windows.Forms.Label
        Me.lblTotalproduct = New System.Windows.Forms.Label
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.BtnRefresh = New System.Windows.Forms.Button
        Me.BtnInsert = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnAddNew = New System.Windows.Forms.Button
        Me.CmbProductGroupSearch = New System.Windows.Forms.ComboBox
        Me.CmbProductSubcategorySearch = New System.Windows.Forms.ComboBox
        Me.CmbProductCategorySearch = New System.Windows.Forms.ComboBox
        Me.GrdAvailableSerialNumber = New System.Windows.Forms.DataGridView
        Me.GrdProductInformation = New System.Windows.Forms.DataGridView
        Me.Button1 = New System.Windows.Forms.Button
        Me.GrpProductInformation.SuspendLayout()
        CType(Me.ProductPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlProductInformation.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GrdAvailableSerialNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdProductInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnClear
        '
        Me.BtnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClear.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnClear.Location = New System.Drawing.Point(902, 172)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(65, 23)
        Me.BtnClear.TabIndex = 1059
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'TxtBarcodeSerial
        '
        Me.TxtBarcodeSerial.Location = New System.Drawing.Point(151, 172)
        Me.TxtBarcodeSerial.Name = "TxtBarcodeSerial"
        Me.TxtBarcodeSerial.Size = New System.Drawing.Size(216, 20)
        Me.TxtBarcodeSerial.TabIndex = 1053
        '
        'TxtReorderPoint
        '
        Me.TxtReorderPoint.Location = New System.Drawing.Point(638, 51)
        Me.TxtReorderPoint.Name = "TxtReorderPoint"
        Me.TxtReorderPoint.Size = New System.Drawing.Size(89, 20)
        Me.TxtReorderPoint.TabIndex = 1057
        '
        'BtnUpload
        '
        Me.BtnUpload.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpload.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpload.Location = New System.Drawing.Point(830, 172)
        Me.BtnUpload.Name = "BtnUpload"
        Me.BtnUpload.Size = New System.Drawing.Size(65, 23)
        Me.BtnUpload.TabIndex = 1058
        Me.BtnUpload.Text = "Upload"
        Me.BtnUpload.UseVisualStyleBackColor = True
        '
        'GrpProductInformation
        '
        Me.GrpProductInformation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpProductInformation.Controls.Add(Me.Label12)
        Me.GrpProductInformation.Controls.Add(Me.TxtDiscountAmount)
        Me.GrpProductInformation.Controls.Add(Me.CmbUnitType)
        Me.GrpProductInformation.Controls.Add(Me.LblUnitType)
        Me.GrpProductInformation.Controls.Add(Me.TxtFromSerial)
        Me.GrpProductInformation.Controls.Add(Me.LblTo)
        Me.GrpProductInformation.Controls.Add(Me.LblTotalSerial)
        Me.GrpProductInformation.Controls.Add(Me.TxtOpeningStock)
        Me.GrpProductInformation.Controls.Add(Me.TxtToSerial)
        Me.GrpProductInformation.Controls.Add(Me.RdbRangeSerial)
        Me.GrpProductInformation.Controls.Add(Me.Label8)
        Me.GrpProductInformation.Controls.Add(Me.LblOpeningStock)
        Me.GrpProductInformation.Controls.Add(Me.TxtSerialNumber)
        Me.GrpProductInformation.Controls.Add(Me.TxtPurchasePrice)
        Me.GrpProductInformation.Controls.Add(Me.LblPurchasePrice)
        Me.GrpProductInformation.Controls.Add(Me.Label6)
        Me.GrpProductInformation.Controls.Add(Me.Label4)
        Me.GrpProductInformation.Controls.Add(Me.Label5)
        Me.GrpProductInformation.Controls.Add(Me.Label11)
        Me.GrpProductInformation.Controls.Add(Me.Label9)
        Me.GrpProductInformation.Controls.Add(Me.Label10)
        Me.GrpProductInformation.Controls.Add(Me.Label3)
        Me.GrpProductInformation.Controls.Add(Me.Label2)
        Me.GrpProductInformation.Controls.Add(Me.Label1)
        Me.GrpProductInformation.Controls.Add(Me.Label7)
        Me.GrpProductInformation.Controls.Add(Me.TxtRemarks)
        Me.GrpProductInformation.Controls.Add(Me.LblRemarks)
        Me.GrpProductInformation.Controls.Add(Me.LblwholesalePrice)
        Me.GrpProductInformation.Controls.Add(Me.TxtWholeSalePrice)
        Me.GrpProductInformation.Controls.Add(Me.TxtSalePrice)
        Me.GrpProductInformation.Controls.Add(Me.LblSalePrice)
        Me.GrpProductInformation.Controls.Add(Me.CmbProductGroupID)
        Me.GrpProductInformation.Controls.Add(Me.CmbProductCategoryID)
        Me.GrpProductInformation.Controls.Add(Me.CmbProductSubcategoryID)
        Me.GrpProductInformation.Controls.Add(Me.BtnUpload)
        Me.GrpProductInformation.Controls.Add(Me.BtnClear)
        Me.GrpProductInformation.Controls.Add(Me.ProductPictureBox)
        Me.GrpProductInformation.Controls.Add(Me.TxtBarcodeSerial)
        Me.GrpProductInformation.Controls.Add(Me.TxtReorderPoint)
        Me.GrpProductInformation.Controls.Add(Me.TxtProductName)
        Me.GrpProductInformation.Controls.Add(Me.TxtProductID)
        Me.GrpProductInformation.Controls.Add(Me.LblReorderPoint)
        Me.GrpProductInformation.Controls.Add(Me.LblBarcodeSerial)
        Me.GrpProductInformation.Controls.Add(Me.LblProductName)
        Me.GrpProductInformation.Controls.Add(Me.LblProductSubcategoryID)
        Me.GrpProductInformation.Controls.Add(Me.LblProductCategoryID)
        Me.GrpProductInformation.Controls.Add(Me.LblProductGroupID)
        Me.GrpProductInformation.Controls.Add(Me.LblProductID)
        Me.GrpProductInformation.Location = New System.Drawing.Point(17, 139)
        Me.GrpProductInformation.Name = "GrpProductInformation"
        Me.GrpProductInformation.Size = New System.Drawing.Size(993, 262)
        Me.GrpProductInformation.TabIndex = 120
        Me.GrpProductInformation.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(534, 145)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 13)
        Me.Label12.TabIndex = 2070
        Me.Label12.Text = "Discount Amount:"
        '
        'TxtDiscountAmount
        '
        Me.TxtDiscountAmount.Location = New System.Drawing.Point(638, 142)
        Me.TxtDiscountAmount.Name = "TxtDiscountAmount"
        Me.TxtDiscountAmount.Size = New System.Drawing.Size(88, 20)
        Me.TxtDiscountAmount.TabIndex = 2069
        '
        'CmbUnitType
        '
        Me.CmbUnitType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbUnitType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbUnitType.FormattingEnabled = True
        Me.CmbUnitType.Location = New System.Drawing.Point(638, 112)
        Me.CmbUnitType.Name = "CmbUnitType"
        Me.CmbUnitType.Size = New System.Drawing.Size(157, 21)
        Me.CmbUnitType.TabIndex = 1059
        '
        'LblUnitType
        '
        Me.LblUnitType.AutoSize = True
        Me.LblUnitType.Location = New System.Drawing.Point(534, 116)
        Me.LblUnitType.Name = "LblUnitType"
        Me.LblUnitType.Size = New System.Drawing.Size(56, 13)
        Me.LblUnitType.TabIndex = 2068
        Me.LblUnitType.Text = "Unit Type:"
        '
        'TxtFromSerial
        '
        Me.TxtFromSerial.Enabled = False
        Me.TxtFromSerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFromSerial.Location = New System.Drawing.Point(638, 232)
        Me.TxtFromSerial.Name = "TxtFromSerial"
        Me.TxtFromSerial.Size = New System.Drawing.Size(138, 22)
        Me.TxtFromSerial.TabIndex = 1062
        '
        'LblTo
        '
        Me.LblTo.AutoSize = True
        Me.LblTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTo.Location = New System.Drawing.Point(791, 236)
        Me.LblTo.Name = "LblTo"
        Me.LblTo.Size = New System.Drawing.Size(27, 15)
        Me.LblTo.TabIndex = 2066
        Me.LblTo.Text = "To:"
        '
        'LblTotalSerial
        '
        Me.LblTotalSerial.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblTotalSerial.AutoSize = True
        Me.LblTotalSerial.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblTotalSerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalSerial.Location = New System.Drawing.Point(834, 205)
        Me.LblTotalSerial.Name = "LblTotalSerial"
        Me.LblTotalSerial.Size = New System.Drawing.Size(21, 13)
        Me.LblTotalSerial.TabIndex = 2061
        Me.LblTotalSerial.Text = "00"
        '
        'TxtOpeningStock
        '
        Me.TxtOpeningStock.Location = New System.Drawing.Point(638, 83)
        Me.TxtOpeningStock.Name = "TxtOpeningStock"
        Me.TxtOpeningStock.Size = New System.Drawing.Size(89, 20)
        Me.TxtOpeningStock.TabIndex = 1058
        '
        'TxtToSerial
        '
        Me.TxtToSerial.Enabled = False
        Me.TxtToSerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtToSerial.Location = New System.Drawing.Point(830, 232)
        Me.TxtToSerial.Name = "TxtToSerial"
        Me.TxtToSerial.Size = New System.Drawing.Size(137, 22)
        Me.TxtToSerial.TabIndex = 1063
        '
        'RdbRangeSerial
        '
        Me.RdbRangeSerial.AutoSize = True
        Me.RdbRangeSerial.Location = New System.Drawing.Point(537, 235)
        Me.RdbRangeSerial.Name = "RdbRangeSerial"
        Me.RdbRangeSerial.Size = New System.Drawing.Size(86, 17)
        Me.RdbRangeSerial.TabIndex = 2062
        Me.RdbRangeSerial.TabStop = True
        Me.RdbRangeSerial.Text = "Range Serial"
        Me.RdbRangeSerial.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(534, 206)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 2060
        Me.Label8.Text = "Serial Number:"
        '
        'LblOpeningStock
        '
        Me.LblOpeningStock.AutoSize = True
        Me.LblOpeningStock.Location = New System.Drawing.Point(534, 86)
        Me.LblOpeningStock.Name = "LblOpeningStock"
        Me.LblOpeningStock.Size = New System.Drawing.Size(81, 13)
        Me.LblOpeningStock.TabIndex = 2058
        Me.LblOpeningStock.Text = "Opening Stock:"
        '
        'TxtSerialNumber
        '
        Me.TxtSerialNumber.Location = New System.Drawing.Point(637, 201)
        Me.TxtSerialNumber.Name = "TxtSerialNumber"
        Me.TxtSerialNumber.Size = New System.Drawing.Size(188, 20)
        Me.TxtSerialNumber.TabIndex = 1061
        '
        'TxtPurchasePrice
        '
        Me.TxtPurchasePrice.Location = New System.Drawing.Point(151, 202)
        Me.TxtPurchasePrice.Name = "TxtPurchasePrice"
        Me.TxtPurchasePrice.Size = New System.Drawing.Size(88, 20)
        Me.TxtPurchasePrice.TabIndex = 1054
        '
        'LblPurchasePrice
        '
        Me.LblPurchasePrice.AutoSize = True
        Me.LblPurchasePrice.Location = New System.Drawing.Point(9, 203)
        Me.LblPurchasePrice.Name = "LblPurchasePrice"
        Me.LblPurchasePrice.Size = New System.Drawing.Size(82, 13)
        Me.LblPurchasePrice.TabIndex = 2057
        Me.LblPurchasePrice.Text = "Purchase Price:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(93, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 24)
        Me.Label6.TabIndex = 2055
        Me.Label6.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(128, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 24)
        Me.Label4.TabIndex = 2053
        Me.Label4.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Location = New System.Drawing.Point(108, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 24)
        Me.Label5.TabIndex = 2054
        Me.Label5.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label11.Location = New System.Drawing.Point(801, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(17, 24)
        Me.Label11.TabIndex = 2052
        Me.Label11.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label9.Location = New System.Drawing.Point(732, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(17, 24)
        Me.Label9.TabIndex = 2052
        Me.Label9.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label10.Location = New System.Drawing.Point(732, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(17, 24)
        Me.Label10.TabIndex = 2052
        Me.Label10.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(732, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 24)
        Me.Label3.TabIndex = 2052
        Me.Label3.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(70, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 24)
        Me.Label2.TabIndex = 2052
        Me.Label2.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(97, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 24)
        Me.Label1.TabIndex = 2052
        Me.Label1.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label7.Location = New System.Drawing.Point(108, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 24)
        Me.Label7.TabIndex = 2052
        Me.Label7.Text = "*"
        '
        'TxtRemarks
        '
        Me.TxtRemarks.Location = New System.Drawing.Point(638, 172)
        Me.TxtRemarks.Multiline = True
        Me.TxtRemarks.Name = "TxtRemarks"
        Me.TxtRemarks.Size = New System.Drawing.Size(187, 22)
        Me.TxtRemarks.TabIndex = 1060
        '
        'LblRemarks
        '
        Me.LblRemarks.AutoSize = True
        Me.LblRemarks.Location = New System.Drawing.Point(534, 176)
        Me.LblRemarks.Name = "LblRemarks"
        Me.LblRemarks.Size = New System.Drawing.Size(52, 13)
        Me.LblRemarks.TabIndex = 2016
        Me.LblRemarks.Text = "Remarks:"
        '
        'LblwholesalePrice
        '
        Me.LblwholesalePrice.AutoSize = True
        Me.LblwholesalePrice.Location = New System.Drawing.Point(535, 22)
        Me.LblwholesalePrice.Name = "LblwholesalePrice"
        Me.LblwholesalePrice.Size = New System.Drawing.Size(87, 13)
        Me.LblwholesalePrice.TabIndex = 2009
        Me.LblwholesalePrice.Text = "Wholesale Price:"
        '
        'TxtWholeSalePrice
        '
        Me.TxtWholeSalePrice.Location = New System.Drawing.Point(638, 18)
        Me.TxtWholeSalePrice.Name = "TxtWholeSalePrice"
        Me.TxtWholeSalePrice.Size = New System.Drawing.Size(88, 20)
        Me.TxtWholeSalePrice.TabIndex = 1056
        '
        'TxtSalePrice
        '
        Me.TxtSalePrice.Location = New System.Drawing.Point(150, 232)
        Me.TxtSalePrice.Name = "TxtSalePrice"
        Me.TxtSalePrice.Size = New System.Drawing.Size(89, 20)
        Me.TxtSalePrice.TabIndex = 1055
        '
        'LblSalePrice
        '
        Me.LblSalePrice.AutoSize = True
        Me.LblSalePrice.Location = New System.Drawing.Point(9, 233)
        Me.LblSalePrice.Name = "LblSalePrice"
        Me.LblSalePrice.Size = New System.Drawing.Size(58, 13)
        Me.LblSalePrice.TabIndex = 137
        Me.LblSalePrice.Text = "Sale Price:"
        '
        'CmbProductGroupID
        '
        Me.CmbProductGroupID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CmbProductGroupID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbProductGroupID.FormattingEnabled = True
        Me.CmbProductGroupID.Location = New System.Drawing.Point(151, 49)
        Me.CmbProductGroupID.Name = "CmbProductGroupID"
        Me.CmbProductGroupID.Size = New System.Drawing.Size(315, 21)
        Me.CmbProductGroupID.TabIndex = 1049
        '
        'CmbProductCategoryID
        '
        Me.CmbProductCategoryID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CmbProductCategoryID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbProductCategoryID.FormattingEnabled = True
        Me.CmbProductCategoryID.Location = New System.Drawing.Point(151, 80)
        Me.CmbProductCategoryID.Name = "CmbProductCategoryID"
        Me.CmbProductCategoryID.Size = New System.Drawing.Size(315, 21)
        Me.CmbProductCategoryID.TabIndex = 1050
        '
        'CmbProductSubcategoryID
        '
        Me.CmbProductSubcategoryID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CmbProductSubcategoryID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbProductSubcategoryID.FormattingEnabled = True
        Me.CmbProductSubcategoryID.Location = New System.Drawing.Point(151, 111)
        Me.CmbProductSubcategoryID.Name = "CmbProductSubcategoryID"
        Me.CmbProductSubcategoryID.Size = New System.Drawing.Size(315, 21)
        Me.CmbProductSubcategoryID.TabIndex = 1051
        '
        'ProductPictureBox
        '
        Me.ProductPictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProductPictureBox.BackgroundImage = Global.Business_Expert_Pro.My.Resources.Resources._icons_smart_objects_3d_book_mockup_psd_address_book_icon_psd_preview_5
        Me.ProductPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ProductPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ProductPictureBox.ErrorImage = Nothing
        Me.ProductPictureBox.InitialImage = Nothing
        Me.ProductPictureBox.Location = New System.Drawing.Point(830, 31)
        Me.ProductPictureBox.Name = "ProductPictureBox"
        Me.ProductPictureBox.Size = New System.Drawing.Size(137, 136)
        Me.ProductPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProductPictureBox.TabIndex = 35
        Me.ProductPictureBox.TabStop = False
        '
        'TxtProductName
        '
        Me.TxtProductName.Location = New System.Drawing.Point(151, 142)
        Me.TxtProductName.Name = "TxtProductName"
        Me.TxtProductName.Size = New System.Drawing.Size(315, 20)
        Me.TxtProductName.TabIndex = 1052
        '
        'TxtProductID
        '
        Me.TxtProductID.Enabled = False
        Me.TxtProductID.Location = New System.Drawing.Point(151, 19)
        Me.TxtProductID.Name = "TxtProductID"
        Me.TxtProductID.Size = New System.Drawing.Size(89, 20)
        Me.TxtProductID.TabIndex = 1048
        '
        'LblReorderPoint
        '
        Me.LblReorderPoint.AutoSize = True
        Me.LblReorderPoint.Location = New System.Drawing.Point(534, 54)
        Me.LblReorderPoint.Name = "LblReorderPoint"
        Me.LblReorderPoint.Size = New System.Drawing.Size(75, 13)
        Me.LblReorderPoint.TabIndex = 12
        Me.LblReorderPoint.Text = "Reorder Point:"
        '
        'LblBarcodeSerial
        '
        Me.LblBarcodeSerial.AutoSize = True
        Me.LblBarcodeSerial.Location = New System.Drawing.Point(9, 173)
        Me.LblBarcodeSerial.Name = "LblBarcodeSerial"
        Me.LblBarcodeSerial.Size = New System.Drawing.Size(79, 13)
        Me.LblBarcodeSerial.TabIndex = 8
        Me.LblBarcodeSerial.Text = "Barcode Serial:"
        '
        'LblProductName
        '
        Me.LblProductName.AutoSize = True
        Me.LblProductName.Location = New System.Drawing.Point(9, 143)
        Me.LblProductName.Name = "LblProductName"
        Me.LblProductName.Size = New System.Drawing.Size(78, 13)
        Me.LblProductName.TabIndex = 2
        Me.LblProductName.Text = "Product Name:"
        '
        'LblProductSubcategoryID
        '
        Me.LblProductSubcategoryID.AutoSize = True
        Me.LblProductSubcategoryID.Location = New System.Drawing.Point(9, 113)
        Me.LblProductSubcategoryID.Name = "LblProductSubcategoryID"
        Me.LblProductSubcategoryID.Size = New System.Drawing.Size(110, 13)
        Me.LblProductSubcategoryID.TabIndex = 5
        Me.LblProductSubcategoryID.Text = "Product Subcategory:"
        '
        'LblProductCategoryID
        '
        Me.LblProductCategoryID.AutoSize = True
        Me.LblProductCategoryID.Location = New System.Drawing.Point(9, 83)
        Me.LblProductCategoryID.Name = "LblProductCategoryID"
        Me.LblProductCategoryID.Size = New System.Drawing.Size(92, 13)
        Me.LblProductCategoryID.TabIndex = 4
        Me.LblProductCategoryID.Text = "Product Category:"
        '
        'LblProductGroupID
        '
        Me.LblProductGroupID.AutoSize = True
        Me.LblProductGroupID.Location = New System.Drawing.Point(9, 53)
        Me.LblProductGroupID.Name = "LblProductGroupID"
        Me.LblProductGroupID.Size = New System.Drawing.Size(79, 13)
        Me.LblProductGroupID.TabIndex = 3
        Me.LblProductGroupID.Text = "Product Group:"
        '
        'LblProductID
        '
        Me.LblProductID.AutoSize = True
        Me.LblProductID.Location = New System.Drawing.Point(9, 23)
        Me.LblProductID.Name = "LblProductID"
        Me.LblProductID.Size = New System.Drawing.Size(61, 13)
        Me.LblProductID.TabIndex = 1
        Me.LblProductID.Text = "Product ID:"
        '
        'PnlProductInformation
        '
        Me.PnlProductInformation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlProductInformation.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlProductInformation.Controls.Add(Me.Panel1)
        Me.PnlProductInformation.Controls.Add(Me.LblProductInformation)
        Me.PnlProductInformation.Location = New System.Drawing.Point(-2, 0)
        Me.PnlProductInformation.Name = "PnlProductInformation"
        Me.PnlProductInformation.Size = New System.Drawing.Size(1036, 75)
        Me.PnlProductInformation.TabIndex = 119
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Btnclose)
        Me.Panel1.Controls.Add(Me.Btnminimized)
        Me.Panel1.Controls.Add(Me.Btnmaximized)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1029, 29)
        Me.Panel1.TabIndex = 131
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(1005, 2)
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
        Me.Btnminimized.Location = New System.Drawing.Point(945, 2)
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
        Me.Btnmaximized.Location = New System.Drawing.Point(975, 2)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1160
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'LblProductInformation
        '
        Me.LblProductInformation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblProductInformation.AutoSize = True
        Me.LblProductInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProductInformation.ForeColor = System.Drawing.Color.White
        Me.LblProductInformation.Location = New System.Drawing.Point(360, 32)
        Me.LblProductInformation.Name = "LblProductInformation"
        Me.LblProductInformation.Size = New System.Drawing.Size(317, 37)
        Me.LblProductInformation.TabIndex = 130
        Me.LblProductInformation.Text = "Product Information"
        '
        'CmbSearch
        '
        Me.CmbSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbSearch.FormattingEnabled = True
        Me.CmbSearch.Items.AddRange(New Object() {"Product  ID", "Product Name", "Product Group", "Product Category", "Product Subcategory", "Barcode Serial"})
        Me.CmbSearch.Location = New System.Drawing.Point(710, 91)
        Me.CmbSearch.Name = "CmbSearch"
        Me.CmbSearch.Size = New System.Drawing.Size(102, 21)
        Me.CmbSearch.TabIndex = 1064
        '
        'TxtSearch
        '
        Me.TxtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSearch.Location = New System.Drawing.Point(818, 92)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(169, 20)
        Me.TxtSearch.TabIndex = 1065
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(963, 122)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(21, 13)
        Me.Label15.TabIndex = 2013
        Me.Label15.Text = "00"
        '
        'lblTotalproduct
        '
        Me.lblTotalproduct.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalproduct.AutoSize = True
        Me.lblTotalproduct.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTotalproduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalproduct.Location = New System.Drawing.Point(844, 120)
        Me.lblTotalproduct.Name = "lblTotalproduct"
        Me.lblTotalproduct.Size = New System.Drawing.Size(98, 16)
        Me.lblTotalproduct.TabIndex = 2012
        Me.lblTotalproduct.Text = "Total Products:"
        '
        'BtnSearch
        '
        Me.BtnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Image = Global.Business_Expert_Pro.My.Resources.Resources.Button_15_1282
        Me.BtnSearch.Location = New System.Drawing.Point(993, 96)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(19, 19)
        Me.BtnSearch.TabIndex = 2014
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'BtnRefresh
        '
        Me.BtnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefresh.Image = Global.Business_Expert_Pro.My.Resources.Resources.Reboot_32px1
        Me.BtnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRefresh.Location = New System.Drawing.Point(311, 91)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(89, 39)
        Me.BtnRefresh.TabIndex = 2009
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'BtnInsert
        '
        Me.BtnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInsert.Image = Global.Business_Expert_Pro.My.Resources.Resources.Save_32px_32
        Me.BtnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInsert.Location = New System.Drawing.Point(462, 91)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(89, 39)
        Me.BtnInsert.TabIndex = 1060
        Me.BtnInsert.Text = "Save"
        Me.BtnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnInsert.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Image = Global.Business_Expert_Pro.My.Resources.Resources.Edit_File_32px3
        Me.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUpdate.Location = New System.Drawing.Point(118, 91)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(89, 39)
        Me.BtnUpdate.TabIndex = 1061
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Image = Global.Business_Expert_Pro.My.Resources.Resources.Delete_32px2
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(213, 91)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(89, 39)
        Me.BtnDelete.TabIndex = 1063
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.UseVisualStyleBackColor = True
        Me.BtnDelete.Visible = False
        '
        'BtnAddNew
        '
        Me.BtnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddNew.Image = Global.Business_Expert_Pro.My.Resources.Resources.Add_New3
        Me.BtnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddNew.Location = New System.Drawing.Point(23, 91)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(89, 39)
        Me.BtnAddNew.TabIndex = 1062
        Me.BtnAddNew.Text = "New"
        Me.BtnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'CmbProductGroupSearch
        '
        Me.CmbProductGroupSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbProductGroupSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbProductGroupSearch.FormattingEnabled = True
        Me.CmbProductGroupSearch.Location = New System.Drawing.Point(818, 91)
        Me.CmbProductGroupSearch.Name = "CmbProductGroupSearch"
        Me.CmbProductGroupSearch.Size = New System.Drawing.Size(169, 21)
        Me.CmbProductGroupSearch.TabIndex = 2017
        Me.CmbProductGroupSearch.Visible = False
        '
        'CmbProductSubcategorySearch
        '
        Me.CmbProductSubcategorySearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbProductSubcategorySearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbProductSubcategorySearch.FormattingEnabled = True
        Me.CmbProductSubcategorySearch.Location = New System.Drawing.Point(818, 92)
        Me.CmbProductSubcategorySearch.Name = "CmbProductSubcategorySearch"
        Me.CmbProductSubcategorySearch.Size = New System.Drawing.Size(169, 21)
        Me.CmbProductSubcategorySearch.TabIndex = 2018
        Me.CmbProductSubcategorySearch.Visible = False
        '
        'CmbProductCategorySearch
        '
        Me.CmbProductCategorySearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbProductCategorySearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbProductCategorySearch.FormattingEnabled = True
        Me.CmbProductCategorySearch.Location = New System.Drawing.Point(818, 91)
        Me.CmbProductCategorySearch.Name = "CmbProductCategorySearch"
        Me.CmbProductCategorySearch.Size = New System.Drawing.Size(169, 21)
        Me.CmbProductCategorySearch.TabIndex = 2019
        Me.CmbProductCategorySearch.Visible = False
        '
        'GrdAvailableSerialNumber
        '
        Me.GrdAvailableSerialNumber.AllowUserToAddRows = False
        Me.GrdAvailableSerialNumber.AllowUserToDeleteRows = False
        Me.GrdAvailableSerialNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdAvailableSerialNumber.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdAvailableSerialNumber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdAvailableSerialNumber.Location = New System.Drawing.Point(836, 409)
        Me.GrdAvailableSerialNumber.Name = "GrdAvailableSerialNumber"
        Me.GrdAvailableSerialNumber.ReadOnly = True
        Me.GrdAvailableSerialNumber.Size = New System.Drawing.Size(174, 315)
        Me.GrdAvailableSerialNumber.TabIndex = 2062
        '
        'GrdProductInformation
        '
        Me.GrdProductInformation.AllowUserToAddRows = False
        Me.GrdProductInformation.AllowUserToDeleteRows = False
        Me.GrdProductInformation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdProductInformation.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdProductInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdProductInformation.Location = New System.Drawing.Point(17, 409)
        Me.GrdProductInformation.Name = "GrdProductInformation"
        Me.GrdProductInformation.ReadOnly = True
        Me.GrdProductInformation.Size = New System.Drawing.Size(813, 315)
        Me.GrdProductInformation.TabIndex = 2063
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.Business_Expert_Pro.My.Resources.Resources.Save_32px_32
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(582, 91)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 39)
        Me.Button1.TabIndex = 2064
        Me.Button1.Text = "Print Barcode"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmProductInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1028, 730)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GrdProductInformation)
        Me.Controls.Add(Me.GrdAvailableSerialNumber)
        Me.Controls.Add(Me.CmbProductGroupSearch)
        Me.Controls.Add(Me.CmbProductSubcategorySearch)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.CmbProductCategorySearch)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblTotalproduct)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.CmbSearch)
        Me.Controls.Add(Me.BtnInsert)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.GrpProductInformation)
        Me.Controls.Add(Me.PnlProductInformation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmProductInformation"
        Me.Text = "Product Information"
        Me.GrpProductInformation.ResumeLayout(False)
        Me.GrpProductInformation.PerformLayout()
        CType(Me.ProductPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlProductInformation.ResumeLayout(False)
        Me.PnlProductInformation.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.GrdAvailableSerialNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdProductInformation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents TxtBarcodeSerial As System.Windows.Forms.TextBox
    Friend WithEvents TxtReorderPoint As System.Windows.Forms.TextBox
    Friend WithEvents ProductPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents BtnUpload As System.Windows.Forms.Button
    Friend WithEvents GrpProductInformation As System.Windows.Forms.GroupBox
    Friend WithEvents TxtProductName As System.Windows.Forms.TextBox
    Friend WithEvents TxtProductID As System.Windows.Forms.TextBox
    Friend WithEvents LblReorderPoint As System.Windows.Forms.Label
    Friend WithEvents LblBarcodeSerial As System.Windows.Forms.Label
    Friend WithEvents LblProductSubcategoryID As System.Windows.Forms.Label
    Friend WithEvents LblProductCategoryID As System.Windows.Forms.Label
    Friend WithEvents LblProductGroupID As System.Windows.Forms.Label
    Friend WithEvents LblProductName As System.Windows.Forms.Label
    Friend WithEvents LblProductID As System.Windows.Forms.Label
    Friend WithEvents PnlProductInformation As System.Windows.Forms.Panel
    Friend WithEvents LblProductInformation As System.Windows.Forms.Label
    Friend WithEvents CmbProductCategoryID As System.Windows.Forms.ComboBox
    Friend WithEvents CmbProductSubcategoryID As System.Windows.Forms.ComboBox
    Friend WithEvents TxtSalePrice As System.Windows.Forms.TextBox
    Friend WithEvents LblSalePrice As System.Windows.Forms.Label
    Friend WithEvents BtnInsert As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
    Friend WithEvents LblwholesalePrice As System.Windows.Forms.Label
    Friend WithEvents TxtWholeSalePrice As System.Windows.Forms.TextBox
    Friend WithEvents CmbSearch As System.Windows.Forms.ComboBox
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblTotalproduct As System.Windows.Forms.Label
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents TxtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents LblRemarks As System.Windows.Forms.Label
    Friend WithEvents CmbProductGroupSearch As System.Windows.Forms.ComboBox
    Friend WithEvents CmbProductSubcategorySearch As System.Windows.Forms.ComboBox
    Friend WithEvents CmbProductCategorySearch As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtPurchasePrice As System.Windows.Forms.TextBox
    Friend WithEvents LblPurchasePrice As System.Windows.Forms.Label
    Friend WithEvents TxtOpeningStock As System.Windows.Forms.TextBox
    Friend WithEvents LblOpeningStock As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtSerialNumber As System.Windows.Forms.TextBox
    Friend WithEvents LblTotalSerial As System.Windows.Forms.Label
    Friend WithEvents TxtFromSerial As System.Windows.Forms.TextBox
    Friend WithEvents LblTo As System.Windows.Forms.Label
    Friend WithEvents TxtToSerial As System.Windows.Forms.TextBox
    Friend WithEvents RdbRangeSerial As System.Windows.Forms.RadioButton
    Friend WithEvents LblUnitType As System.Windows.Forms.Label
    Friend WithEvents CmbUnitType As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
    Friend WithEvents GrdAvailableSerialNumber As System.Windows.Forms.DataGridView
    Friend WithEvents CmbProductGroupID As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GrdProductInformation As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtDiscountAmount As System.Windows.Forms.TextBox
End Class
