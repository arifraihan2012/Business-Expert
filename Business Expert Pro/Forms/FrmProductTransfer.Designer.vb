<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProductTransfer
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
        Me.LblSelectProduct = New System.Windows.Forms.GroupBox
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.TxtWarrantyDays = New System.Windows.Forms.TextBox
        Me.LblWarrantyDays = New System.Windows.Forms.Label
        Me.CmbLocationID = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.CmbSerialNumber = New System.Windows.Forms.ComboBox
        Me.LblStatus = New System.Windows.Forms.Label
        Me.TxtFromSerial = New System.Windows.Forms.TextBox
        Me.TxtToSerial = New System.Windows.Forms.TextBox
        Me.RdbRangeSerial = New System.Windows.Forms.RadioButton
        Me.LblTo = New System.Windows.Forms.Label
        Me.LblSingleSerialNumber = New System.Windows.Forms.Label
        Me.LblFrom = New System.Windows.Forms.Label
        Me.TxtPurchaseID = New System.Windows.Forms.TextBox
        Me.LblPurchaseID = New System.Windows.Forms.Label
        Me.LblProductName = New System.Windows.Forms.Label
        Me.LblQuantitylbl = New System.Windows.Forms.Label
        Me.TxtQuantity = New System.Windows.Forms.TextBox
        Me.cmbProductName = New System.Windows.Forms.ComboBox
        Me.LblToBranch = New System.Windows.Forms.Label
        Me.CmbToBranch = New System.Windows.Forms.ComboBox
        Me.CmbFromBranch = New System.Windows.Forms.ComboBox
        Me.LblFromBranch = New System.Windows.Forms.Label
        Me.GrdAvailableSerialNumber = New System.Windows.Forms.DataGridView
        Me.GrdProductTransfer = New System.Windows.Forms.DataGridView
        Me.PnlProductTransfer = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblTransferDate = New System.Windows.Forms.Label
        Me.lblInvoiceNo = New System.Windows.Forms.Label
        Me.TxtProductTransferInvoiceNo = New System.Windows.Forms.TextBox
        Me.DtpTransferDate = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblTransferID = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblQuantity = New System.Windows.Forms.Label
        Me.BtnHistory = New System.Windows.Forms.Button
        Me.BtnAddNew = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnInvoice = New System.Windows.Forms.Button
        Me.LblTotalAvailableStock = New System.Windows.Forms.Label
        Me.LblSelectProduct.SuspendLayout()
        CType(Me.GrdAvailableSerialNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdProductTransfer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlProductTransfer.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblSelectProduct
        '
        Me.LblSelectProduct.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblSelectProduct.Controls.Add(Me.BtnAdd)
        Me.LblSelectProduct.Controls.Add(Me.TxtWarrantyDays)
        Me.LblSelectProduct.Controls.Add(Me.LblWarrantyDays)
        Me.LblSelectProduct.Controls.Add(Me.CmbLocationID)
        Me.LblSelectProduct.Controls.Add(Me.Label4)
        Me.LblSelectProduct.Controls.Add(Me.CmbSerialNumber)
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
        Me.LblSelectProduct.Controls.Add(Me.TxtQuantity)
        Me.LblSelectProduct.Controls.Add(Me.cmbProductName)
        Me.LblSelectProduct.Controls.Add(Me.LblToBranch)
        Me.LblSelectProduct.Controls.Add(Me.CmbToBranch)
        Me.LblSelectProduct.Location = New System.Drawing.Point(15, 173)
        Me.LblSelectProduct.Name = "LblSelectProduct"
        Me.LblSelectProduct.Size = New System.Drawing.Size(987, 112)
        Me.LblSelectProduct.TabIndex = 1020
        Me.LblSelectProduct.TabStop = False
        '
        'BtnAdd
        '
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.BtnAdd.Location = New System.Drawing.Point(854, 72)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(112, 25)
        Me.BtnAdd.TabIndex = 2069
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'TxtWarrantyDays
        '
        Me.TxtWarrantyDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtWarrantyDays.Location = New System.Drawing.Point(555, 74)
        Me.TxtWarrantyDays.Name = "TxtWarrantyDays"
        Me.TxtWarrantyDays.ReadOnly = True
        Me.TxtWarrantyDays.Size = New System.Drawing.Size(158, 20)
        Me.TxtWarrantyDays.TabIndex = 2067
        '
        'LblWarrantyDays
        '
        Me.LblWarrantyDays.AutoSize = True
        Me.LblWarrantyDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWarrantyDays.Location = New System.Drawing.Point(594, 59)
        Me.LblWarrantyDays.Name = "LblWarrantyDays"
        Me.LblWarrantyDays.Size = New System.Drawing.Size(80, 13)
        Me.LblWarrantyDays.TabIndex = 2068
        Me.LblWarrantyDays.Text = "Warranty Days:"
        '
        'CmbLocationID
        '
        Me.CmbLocationID.FormattingEnabled = True
        Me.CmbLocationID.Location = New System.Drawing.Point(171, 28)
        Me.CmbLocationID.Name = "CmbLocationID"
        Me.CmbLocationID.Size = New System.Drawing.Size(167, 21)
        Me.CmbLocationID.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(229, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 2058
        Me.Label4.Text = "Location:"
        '
        'CmbSerialNumber
        '
        Me.CmbSerialNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmbSerialNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbSerialNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbSerialNumber.FormattingEnabled = True
        Me.CmbSerialNumber.Location = New System.Drawing.Point(785, 28)
        Me.CmbSerialNumber.Name = "CmbSerialNumber"
        Me.CmbSerialNumber.Size = New System.Drawing.Size(181, 21)
        Me.CmbSerialNumber.TabIndex = 5
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Location = New System.Drawing.Point(890, 14)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(37, 13)
        Me.LblStatus.TabIndex = 2047
        Me.LblStatus.Text = "Status"
        '
        'TxtFromSerial
        '
        Me.TxtFromSerial.Enabled = False
        Me.TxtFromSerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFromSerial.Location = New System.Drawing.Point(175, 74)
        Me.TxtFromSerial.Name = "TxtFromSerial"
        Me.TxtFromSerial.Size = New System.Drawing.Size(167, 22)
        Me.TxtFromSerial.TabIndex = 6
        '
        'TxtToSerial
        '
        Me.TxtToSerial.Enabled = False
        Me.TxtToSerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtToSerial.Location = New System.Drawing.Point(381, 74)
        Me.TxtToSerial.Name = "TxtToSerial"
        Me.TxtToSerial.Size = New System.Drawing.Size(167, 22)
        Me.TxtToSerial.TabIndex = 7
        '
        'RdbRangeSerial
        '
        Me.RdbRangeSerial.AutoSize = True
        Me.RdbRangeSerial.Location = New System.Drawing.Point(10, 76)
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
        Me.LblTo.Location = New System.Drawing.Point(348, 76)
        Me.LblTo.Name = "LblTo"
        Me.LblTo.Size = New System.Drawing.Size(27, 15)
        Me.LblTo.TabIndex = 2044
        Me.LblTo.Text = "To:"
        '
        'LblSingleSerialNumber
        '
        Me.LblSingleSerialNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblSingleSerialNumber.AutoSize = True
        Me.LblSingleSerialNumber.Location = New System.Drawing.Point(783, 14)
        Me.LblSingleSerialNumber.Name = "LblSingleSerialNumber"
        Me.LblSingleSerialNumber.Size = New System.Drawing.Size(108, 13)
        Me.LblSingleSerialNumber.TabIndex = 1022
        Me.LblSingleSerialNumber.Text = "Single Serial Number:"
        '
        'LblFrom
        '
        Me.LblFrom.AutoSize = True
        Me.LblFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFrom.Location = New System.Drawing.Point(120, 76)
        Me.LblFrom.Name = "LblFrom"
        Me.LblFrom.Size = New System.Drawing.Size(44, 15)
        Me.LblFrom.TabIndex = 2043
        Me.LblFrom.Text = "From:"
        '
        'TxtPurchaseID
        '
        Me.TxtPurchaseID.Location = New System.Drawing.Point(719, 74)
        Me.TxtPurchaseID.Name = "TxtPurchaseID"
        Me.TxtPurchaseID.ReadOnly = True
        Me.TxtPurchaseID.Size = New System.Drawing.Size(76, 20)
        Me.TxtPurchaseID.TabIndex = 1011
        '
        'LblPurchaseID
        '
        Me.LblPurchaseID.AutoSize = True
        Me.LblPurchaseID.Location = New System.Drawing.Point(723, 57)
        Me.LblPurchaseID.Name = "LblPurchaseID"
        Me.LblPurchaseID.Size = New System.Drawing.Size(69, 13)
        Me.LblPurchaseID.TabIndex = 1020
        Me.LblPurchaseID.Text = "Purchase ID:"
        '
        'LblProductName
        '
        Me.LblProductName.AutoSize = True
        Me.LblProductName.Location = New System.Drawing.Point(488, 14)
        Me.LblProductName.Name = "LblProductName"
        Me.LblProductName.Size = New System.Drawing.Size(78, 13)
        Me.LblProductName.TabIndex = 1018
        Me.LblProductName.Text = "Product Name:"
        '
        'LblQuantitylbl
        '
        Me.LblQuantitylbl.AutoSize = True
        Me.LblQuantitylbl.Location = New System.Drawing.Point(723, 14)
        Me.LblQuantitylbl.Name = "LblQuantitylbl"
        Me.LblQuantitylbl.Size = New System.Drawing.Size(49, 13)
        Me.LblQuantitylbl.TabIndex = 1017
        Me.LblQuantitylbl.Text = "Quantity:"
        '
        'TxtQuantity
        '
        Me.TxtQuantity.Location = New System.Drawing.Point(717, 28)
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.Size = New System.Drawing.Size(61, 20)
        Me.TxtQuantity.TabIndex = 4
        '
        'cmbProductName
        '
        Me.cmbProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbProductName.FormattingEnabled = True
        Me.cmbProductName.Location = New System.Drawing.Point(345, 28)
        Me.cmbProductName.Name = "cmbProductName"
        Me.cmbProductName.Size = New System.Drawing.Size(365, 21)
        Me.cmbProductName.TabIndex = 3
        '
        'LblToBranch
        '
        Me.LblToBranch.AutoSize = True
        Me.LblToBranch.Location = New System.Drawing.Point(57, 14)
        Me.LblToBranch.Name = "LblToBranch"
        Me.LblToBranch.Size = New System.Drawing.Size(63, 13)
        Me.LblToBranch.TabIndex = 2056
        Me.LblToBranch.Text = "To Branch :"
        '
        'CmbToBranch
        '
        Me.CmbToBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbToBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbToBranch.FormattingEnabled = True
        Me.CmbToBranch.Location = New System.Drawing.Point(13, 28)
        Me.CmbToBranch.Name = "CmbToBranch"
        Me.CmbToBranch.Size = New System.Drawing.Size(151, 21)
        Me.CmbToBranch.TabIndex = 1
        '
        'CmbFromBranch
        '
        Me.CmbFromBranch.FormattingEnabled = True
        Me.CmbFromBranch.Location = New System.Drawing.Point(103, 77)
        Me.CmbFromBranch.Name = "CmbFromBranch"
        Me.CmbFromBranch.Size = New System.Drawing.Size(151, 21)
        Me.CmbFromBranch.TabIndex = 2053
        '
        'LblFromBranch
        '
        Me.LblFromBranch.AutoSize = True
        Me.LblFromBranch.Location = New System.Drawing.Point(12, 81)
        Me.LblFromBranch.Name = "LblFromBranch"
        Me.LblFromBranch.Size = New System.Drawing.Size(73, 13)
        Me.LblFromBranch.TabIndex = 2054
        Me.LblFromBranch.Text = "From Branch :"
        '
        'GrdAvailableSerialNumber
        '
        Me.GrdAvailableSerialNumber.AllowUserToAddRows = False
        Me.GrdAvailableSerialNumber.AllowUserToDeleteRows = False
        Me.GrdAvailableSerialNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GrdAvailableSerialNumber.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GrdAvailableSerialNumber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdAvailableSerialNumber.Location = New System.Drawing.Point(15, 291)
        Me.GrdAvailableSerialNumber.Name = "GrdAvailableSerialNumber"
        Me.GrdAvailableSerialNumber.ReadOnly = True
        Me.GrdAvailableSerialNumber.Size = New System.Drawing.Size(192, 416)
        Me.GrdAvailableSerialNumber.TabIndex = 2052
        '
        'GrdProductTransfer
        '
        Me.GrdProductTransfer.AllowUserToAddRows = False
        Me.GrdProductTransfer.AllowUserToDeleteRows = False
        Me.GrdProductTransfer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdProductTransfer.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GrdProductTransfer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdProductTransfer.Location = New System.Drawing.Point(211, 291)
        Me.GrdProductTransfer.Name = "GrdProductTransfer"
        Me.GrdProductTransfer.ReadOnly = True
        Me.GrdProductTransfer.Size = New System.Drawing.Size(791, 416)
        Me.GrdProductTransfer.TabIndex = 2049
        '
        'PnlProductTransfer
        '
        Me.PnlProductTransfer.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlProductTransfer.Controls.Add(Me.Panel2)
        Me.PnlProductTransfer.Controls.Add(Me.Label1)
        Me.PnlProductTransfer.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlProductTransfer.Location = New System.Drawing.Point(0, 0)
        Me.PnlProductTransfer.Name = "PnlProductTransfer"
        Me.PnlProductTransfer.Size = New System.Drawing.Size(1014, 66)
        Me.PnlProductTransfer.TabIndex = 2049
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Btnclose)
        Me.Panel2.Controls.Add(Me.Btnminimized)
        Me.Panel2.Controls.Add(Me.Btnmaximized)
        Me.Panel2.Location = New System.Drawing.Point(1, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1010, 27)
        Me.Panel2.TabIndex = 2072
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(986, 0)
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
        Me.Btnminimized.Location = New System.Drawing.Point(926, 0)
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
        Me.Btnmaximized.Location = New System.Drawing.Point(956, 0)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1160
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(383, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 33)
        Me.Label1.TabIndex = 2049
        Me.Label1.Text = "Product Transfer"
        '
        'lblTransferDate
        '
        Me.lblTransferDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTransferDate.AutoSize = True
        Me.lblTransferDate.Location = New System.Drawing.Point(789, 109)
        Me.lblTransferDate.Name = "lblTransferDate"
        Me.lblTransferDate.Size = New System.Drawing.Size(75, 13)
        Me.lblTransferDate.TabIndex = 2053
        Me.lblTransferDate.Text = "Transfer Date:"
        '
        'lblInvoiceNo
        '
        Me.lblInvoiceNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInvoiceNo.AutoSize = True
        Me.lblInvoiceNo.Location = New System.Drawing.Point(789, 81)
        Me.lblInvoiceNo.Name = "lblInvoiceNo"
        Me.lblInvoiceNo.Size = New System.Drawing.Size(62, 13)
        Me.lblInvoiceNo.TabIndex = 2052
        Me.lblInvoiceNo.Text = "Invoice No:"
        '
        'TxtProductTransferInvoiceNo
        '
        Me.TxtProductTransferInvoiceNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtProductTransferInvoiceNo.Location = New System.Drawing.Point(879, 77)
        Me.TxtProductTransferInvoiceNo.Name = "TxtProductTransferInvoiceNo"
        Me.TxtProductTransferInvoiceNo.ReadOnly = True
        Me.TxtProductTransferInvoiceNo.Size = New System.Drawing.Size(129, 20)
        Me.TxtProductTransferInvoiceNo.TabIndex = 2051
        '
        'DtpTransferDate
        '
        Me.DtpTransferDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtpTransferDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpTransferDate.Location = New System.Drawing.Point(879, 106)
        Me.DtpTransferDate.Name = "DtpTransferDate"
        Me.DtpTransferDate.Size = New System.Drawing.Size(129, 20)
        Me.DtpTransferDate.TabIndex = 2050
        Me.DtpTransferDate.Value = New Date(2017, 7, 28, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(873, 714)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 2058
        Me.Label5.Text = "Transfer ID:"
        '
        'lblTransferID
        '
        Me.lblTransferID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTransferID.AutoSize = True
        Me.lblTransferID.Location = New System.Drawing.Point(938, 714)
        Me.lblTransferID.Name = "lblTransferID"
        Me.lblTransferID.Size = New System.Drawing.Size(19, 13)
        Me.lblTransferID.TabIndex = 2057
        Me.lblTransferID.Text = "00"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(212, 714)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 16)
        Me.Label13.TabIndex = 2061
        Me.Label13.Text = "Clear : F2"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(292, 714)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(114, 16)
        Me.Label14.TabIndex = 2060
        Me.Label14.Text = "Add New: Enter"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(417, 714)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 16)
        Me.Label12.TabIndex = 2059
        Me.Label12.Text = "Delete: Click 2X"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 714)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 2068
        Me.Label2.Text = "Quantity:"
        '
        'lblQuantity
        '
        Me.lblQuantity.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.BackColor = System.Drawing.Color.White
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(157, 714)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(22, 16)
        Me.lblQuantity.TabIndex = 2067
        Me.lblQuantity.Text = "00"
        Me.lblQuantity.Visible = False
        '
        'BtnHistory
        '
        Me.BtnHistory.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHistory.Image = Global.Business_Expert_Pro.My.Resources.Resources.Last_view1
        Me.BtnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHistory.Location = New System.Drawing.Point(510, 137)
        Me.BtnHistory.Name = "BtnHistory"
        Me.BtnHistory.Size = New System.Drawing.Size(104, 35)
        Me.BtnHistory.TabIndex = 2066
        Me.BtnHistory.Text = "History"
        Me.BtnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnHistory.UseVisualStyleBackColor = True
        '
        'BtnAddNew
        '
        Me.BtnAddNew.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddNew.Image = Global.Business_Expert_Pro.My.Resources.Resources.Add_New1
        Me.BtnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddNew.Location = New System.Drawing.Point(290, 137)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(104, 35)
        Me.BtnAddNew.TabIndex = 2065
        Me.BtnAddNew.Text = "New Inv."
        Me.BtnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Image = Global.Business_Expert_Pro.My.Resources.Resources.Save1
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(400, 137)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(104, 35)
        Me.BtnSave.TabIndex = 2063
        Me.BtnSave.Text = "Save"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.Image = Global.Business_Expert_Pro.My.Resources.Resources.Delete1
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(730, 137)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(104, 35)
        Me.BtnDelete.TabIndex = 2062
        Me.BtnDelete.Text = " Delete Inv."
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnInvoice
        '
        Me.BtnInvoice.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInvoice.Image = Global.Business_Expert_Pro.My.Resources.Resources.Last_view1
        Me.BtnInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInvoice.Location = New System.Drawing.Point(620, 137)
        Me.BtnInvoice.Name = "BtnInvoice"
        Me.BtnInvoice.Size = New System.Drawing.Size(104, 35)
        Me.BtnInvoice.TabIndex = 2069
        Me.BtnInvoice.Text = "Invoice"
        Me.BtnInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnInvoice.UseVisualStyleBackColor = True
        '
        'LblTotalAvailableStock
        '
        Me.LblTotalAvailableStock.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblTotalAvailableStock.AutoSize = True
        Me.LblTotalAvailableStock.BackColor = System.Drawing.Color.White
        Me.LblTotalAvailableStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalAvailableStock.Location = New System.Drawing.Point(72, 714)
        Me.LblTotalAvailableStock.Name = "LblTotalAvailableStock"
        Me.LblTotalAvailableStock.Size = New System.Drawing.Size(22, 16)
        Me.LblTotalAvailableStock.TabIndex = 2071
        Me.LblTotalAvailableStock.Text = "00"
        '
        'FrmProductTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1014, 736)
        Me.Controls.Add(Me.LblTotalAvailableStock)
        Me.Controls.Add(Me.BtnInvoice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.BtnHistory)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblTransferID)
        Me.Controls.Add(Me.lblTransferDate)
        Me.Controls.Add(Me.PnlProductTransfer)
        Me.Controls.Add(Me.lblInvoiceNo)
        Me.Controls.Add(Me.TxtProductTransferInvoiceNo)
        Me.Controls.Add(Me.DtpTransferDate)
        Me.Controls.Add(Me.GrdAvailableSerialNumber)
        Me.Controls.Add(Me.GrdProductTransfer)
        Me.Controls.Add(Me.LblSelectProduct)
        Me.Controls.Add(Me.CmbFromBranch)
        Me.Controls.Add(Me.LblFromBranch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmProductTransfer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Transfer"
        Me.LblSelectProduct.ResumeLayout(False)
        Me.LblSelectProduct.PerformLayout()
        CType(Me.GrdAvailableSerialNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdProductTransfer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlProductTransfer.ResumeLayout(False)
        Me.PnlProductTransfer.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblSelectProduct As System.Windows.Forms.GroupBox
    Friend WithEvents CmbSerialNumber As System.Windows.Forms.ComboBox
    Friend WithEvents LblStatus As System.Windows.Forms.Label
    Friend WithEvents TxtFromSerial As System.Windows.Forms.TextBox
    Friend WithEvents TxtToSerial As System.Windows.Forms.TextBox
    Friend WithEvents RdbRangeSerial As System.Windows.Forms.RadioButton
    Friend WithEvents LblTo As System.Windows.Forms.Label
    Friend WithEvents LblSingleSerialNumber As System.Windows.Forms.Label
    Friend WithEvents LblFrom As System.Windows.Forms.Label
    Friend WithEvents TxtPurchaseID As System.Windows.Forms.TextBox
    Friend WithEvents LblPurchaseID As System.Windows.Forms.Label
    Friend WithEvents LblProductName As System.Windows.Forms.Label
    Friend WithEvents LblQuantitylbl As System.Windows.Forms.Label
    Friend WithEvents TxtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents cmbProductName As System.Windows.Forms.ComboBox
    Friend WithEvents GrdAvailableSerialNumber As System.Windows.Forms.DataGridView
    Friend WithEvents GrdProductTransfer As System.Windows.Forms.DataGridView
    Friend WithEvents CmbFromBranch As System.Windows.Forms.ComboBox
    Friend WithEvents LblFromBranch As System.Windows.Forms.Label
    Friend WithEvents LblToBranch As System.Windows.Forms.Label
    Friend WithEvents CmbToBranch As System.Windows.Forms.ComboBox
    Friend WithEvents PnlProductTransfer As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTransferDate As System.Windows.Forms.Label
    Friend WithEvents lblInvoiceNo As System.Windows.Forms.Label
    Friend WithEvents TxtProductTransferInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents DtpTransferDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblTransferID As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
    Friend WithEvents BtnHistory As System.Windows.Forms.Button
    Friend WithEvents CmbLocationID As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtWarrantyDays As System.Windows.Forms.TextBox
    Friend WithEvents LblWarrantyDays As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents BtnInvoice As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents LblTotalAvailableStock As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button

End Class
