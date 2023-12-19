<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVoucher
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
        Me.PnlVoucher = New System.Windows.Forms.Panel
        Me.LblVoucher = New System.Windows.Forms.Label
        Me.GrdVoucher = New System.Windows.Forms.DataGridView
        Me.LblRemarks = New System.Windows.Forms.Label
        Me.LblAmount = New System.Windows.Forms.Label
        Me.LblVoucherPurposeID = New System.Windows.Forms.Label
        Me.LblVoucherCategoryID = New System.Windows.Forms.Label
        Me.LblDate = New System.Windows.Forms.Label
        Me.LblVoucherID = New System.Windows.Forms.Label
        Me.TxtRemarks = New System.Windows.Forms.TextBox
        Me.TxtPaidAmount = New System.Windows.Forms.TextBox
        Me.TxtVoucherID = New System.Windows.Forms.TextBox
        Me.CmbVoucherCategoryID = New System.Windows.Forms.ComboBox
        Me.CmbVoucherPurposeID = New System.Windows.Forms.ComboBox
        Me.DtpDate = New System.Windows.Forms.DateTimePicker
        Me.GrpDetails = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.CmbVoucherSubcategoryID = New System.Windows.Forms.ComboBox
        Me.LblVoucherSubcategoryID = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GrpSaveBox = New System.Windows.Forms.GroupBox
        Me.TxtInitialBalance = New System.Windows.Forms.TextBox
        Me.LblInitialBalance = New System.Windows.Forms.Label
        Me.TxtTotalAmount = New System.Windows.Forms.TextBox
        Me.LblTotalAmount = New System.Windows.Forms.Label
        Me.TxtReceivedAmount = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnSave = New System.Windows.Forms.Button
        Me.TxtVoucherNo = New System.Windows.Forms.TextBox
        Me.LblVoucherNo = New System.Windows.Forms.Label
        Me.TxtMobileNo = New System.Windows.Forms.TextBox
        Me.LblMobileNO = New System.Windows.Forms.Label
        Me.BtnDebitVoucher = New System.Windows.Forms.Button
        Me.BtnCreditVoucher = New System.Windows.Forms.Button
        Me.TxtName = New System.Windows.Forms.TextBox
        Me.LblName = New System.Windows.Forms.Label
        Me.GrpName = New System.Windows.Forms.GroupBox
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.PnlVoucher.SuspendLayout()
        CType(Me.GrdVoucher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpDetails.SuspendLayout()
        Me.GrpSaveBox.SuspendLayout()
        Me.GrpName.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlVoucher
        '
        Me.PnlVoucher.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlVoucher.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PnlVoucher.Controls.Add(Me.LblVoucher)
        Me.PnlVoucher.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlVoucher.Location = New System.Drawing.Point(0, 0)
        Me.PnlVoucher.Name = "PnlVoucher"
        Me.PnlVoucher.Size = New System.Drawing.Size(1007, 65)
        Me.PnlVoucher.TabIndex = 1
        '
        'LblVoucher
        '
        Me.LblVoucher.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblVoucher.AutoSize = True
        Me.LblVoucher.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVoucher.ForeColor = System.Drawing.Color.White
        Me.LblVoucher.Location = New System.Drawing.Point(431, 14)
        Me.LblVoucher.Name = "LblVoucher"
        Me.LblVoucher.Size = New System.Drawing.Size(144, 37)
        Me.LblVoucher.TabIndex = 2
        Me.LblVoucher.Text = "Voucher"
        '
        'GrdVoucher
        '
        Me.GrdVoucher.AllowUserToAddRows = False
        Me.GrdVoucher.AllowUserToDeleteRows = False
        Me.GrdVoucher.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdVoucher.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrdVoucher.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.GrdVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GrdVoucher.DefaultCellStyle = DataGridViewCellStyle5
        Me.GrdVoucher.Location = New System.Drawing.Point(7, 389)
        Me.GrdVoucher.Name = "GrdVoucher"
        Me.GrdVoucher.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrdVoucher.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.GrdVoucher.Size = New System.Drawing.Size(710, 312)
        Me.GrdVoucher.TabIndex = 337
        '
        'LblRemarks
        '
        Me.LblRemarks.AutoSize = True
        Me.LblRemarks.Location = New System.Drawing.Point(274, 68)
        Me.LblRemarks.Name = "LblRemarks"
        Me.LblRemarks.Size = New System.Drawing.Size(52, 13)
        Me.LblRemarks.TabIndex = 311
        Me.LblRemarks.Text = "Remarks:"
        '
        'LblAmount
        '
        Me.LblAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblAmount.AutoSize = True
        Me.LblAmount.Location = New System.Drawing.Point(9, 80)
        Me.LblAmount.Name = "LblAmount"
        Me.LblAmount.Size = New System.Drawing.Size(70, 13)
        Me.LblAmount.TabIndex = 314
        Me.LblAmount.Text = "Paid Amount:"
        '
        'LblVoucherPurposeID
        '
        Me.LblVoucherPurposeID.AutoSize = True
        Me.LblVoucherPurposeID.Location = New System.Drawing.Point(533, 16)
        Me.LblVoucherPurposeID.Name = "LblVoucherPurposeID"
        Me.LblVoucherPurposeID.Size = New System.Drawing.Size(103, 13)
        Me.LblVoucherPurposeID.TabIndex = 315
        Me.LblVoucherPurposeID.Text = "Voucher PurposeID:"
        '
        'LblVoucherCategoryID
        '
        Me.LblVoucherCategoryID.AutoSize = True
        Me.LblVoucherCategoryID.Location = New System.Drawing.Point(67, 16)
        Me.LblVoucherCategoryID.Name = "LblVoucherCategoryID"
        Me.LblVoucherCategoryID.Size = New System.Drawing.Size(109, 13)
        Me.LblVoucherCategoryID.TabIndex = 316
        Me.LblVoucherCategoryID.Text = "Voucher Category ID:"
        '
        'LblDate
        '
        Me.LblDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblDate.AutoSize = True
        Me.LblDate.Location = New System.Drawing.Point(706, 99)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(33, 13)
        Me.LblDate.TabIndex = 313
        Me.LblDate.Text = "Date:"
        '
        'LblVoucherID
        '
        Me.LblVoucherID.AutoSize = True
        Me.LblVoucherID.Location = New System.Drawing.Point(26, 14)
        Me.LblVoucherID.Name = "LblVoucherID"
        Me.LblVoucherID.Size = New System.Drawing.Size(64, 13)
        Me.LblVoucherID.TabIndex = 317
        Me.LblVoucherID.Text = "Voucher ID:"
        '
        'TxtRemarks
        '
        Me.TxtRemarks.Location = New System.Drawing.Point(11, 84)
        Me.TxtRemarks.Multiline = True
        Me.TxtRemarks.Name = "TxtRemarks"
        Me.TxtRemarks.Size = New System.Drawing.Size(683, 57)
        Me.TxtRemarks.TabIndex = 206
        '
        'TxtPaidAmount
        '
        Me.TxtPaidAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPaidAmount.Location = New System.Drawing.Point(109, 76)
        Me.TxtPaidAmount.Name = "TxtPaidAmount"
        Me.TxtPaidAmount.Size = New System.Drawing.Size(134, 20)
        Me.TxtPaidAmount.TabIndex = 207
        '
        'TxtVoucherID
        '
        Me.TxtVoucherID.Enabled = False
        Me.TxtVoucherID.Location = New System.Drawing.Point(96, 14)
        Me.TxtVoucherID.Name = "TxtVoucherID"
        Me.TxtVoucherID.Size = New System.Drawing.Size(91, 20)
        Me.TxtVoucherID.TabIndex = 201
        '
        'CmbVoucherCategoryID
        '
        Me.CmbVoucherCategoryID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbVoucherCategoryID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.CmbVoucherCategoryID.Enabled = False
        Me.CmbVoucherCategoryID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbVoucherCategoryID.FormattingEnabled = True
        Me.CmbVoucherCategoryID.Items.AddRange(New Object() {"Debit Voucher", "Credit Voucher"})
        Me.CmbVoucherCategoryID.Location = New System.Drawing.Point(11, 41)
        Me.CmbVoucherCategoryID.Name = "CmbVoucherCategoryID"
        Me.CmbVoucherCategoryID.Size = New System.Drawing.Size(220, 23)
        Me.CmbVoucherCategoryID.TabIndex = 2038
        '
        'CmbVoucherPurposeID
        '
        Me.CmbVoucherPurposeID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbVoucherPurposeID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbVoucherPurposeID.FormattingEnabled = True
        Me.CmbVoucherPurposeID.Location = New System.Drawing.Point(474, 41)
        Me.CmbVoucherPurposeID.Name = "CmbVoucherPurposeID"
        Me.CmbVoucherPurposeID.Size = New System.Drawing.Size(220, 21)
        Me.CmbVoucherPurposeID.TabIndex = 205
        '
        'DtpDate
        '
        Me.DtpDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDate.Location = New System.Drawing.Point(779, 97)
        Me.DtpDate.Name = "DtpDate"
        Me.DtpDate.Size = New System.Drawing.Size(121, 20)
        Me.DtpDate.TabIndex = 207
        Me.DtpDate.Value = New Date(2017, 8, 24, 0, 0, 0, 0)
        '
        'GrpDetails
        '
        Me.GrpDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpDetails.Controls.Add(Me.Label8)
        Me.GrpDetails.Controls.Add(Me.CmbVoucherSubcategoryID)
        Me.GrpDetails.Controls.Add(Me.LblVoucherSubcategoryID)
        Me.GrpDetails.Controls.Add(Me.Label5)
        Me.GrpDetails.Controls.Add(Me.Label6)
        Me.GrpDetails.Controls.Add(Me.CmbVoucherPurposeID)
        Me.GrpDetails.Controls.Add(Me.CmbVoucherCategoryID)
        Me.GrpDetails.Controls.Add(Me.TxtRemarks)
        Me.GrpDetails.Controls.Add(Me.LblVoucherCategoryID)
        Me.GrpDetails.Controls.Add(Me.LblVoucherPurposeID)
        Me.GrpDetails.Controls.Add(Me.LblRemarks)
        Me.GrpDetails.Enabled = False
        Me.GrpDetails.Location = New System.Drawing.Point(12, 231)
        Me.GrpDetails.Name = "GrpDetails"
        Me.GrpDetails.Size = New System.Drawing.Size(705, 152)
        Me.GrpDetails.TabIndex = 335
        Me.GrpDetails.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label8.Location = New System.Drawing.Point(261, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 24)
        Me.Label8.TabIndex = 2028
        Me.Label8.Text = "*"
        '
        'CmbVoucherSubcategoryID
        '
        Me.CmbVoucherSubcategoryID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbVoucherSubcategoryID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbVoucherSubcategoryID.FormattingEnabled = True
        Me.CmbVoucherSubcategoryID.Location = New System.Drawing.Point(237, 41)
        Me.CmbVoucherSubcategoryID.Name = "CmbVoucherSubcategoryID"
        Me.CmbVoucherSubcategoryID.Size = New System.Drawing.Size(220, 21)
        Me.CmbVoucherSubcategoryID.TabIndex = 204
        '
        'LblVoucherSubcategoryID
        '
        Me.LblVoucherSubcategoryID.AutoSize = True
        Me.LblVoucherSubcategoryID.Location = New System.Drawing.Point(284, 16)
        Me.LblVoucherSubcategoryID.Name = "LblVoucherSubcategoryID"
        Me.LblVoucherSubcategoryID.Size = New System.Drawing.Size(127, 13)
        Me.LblVoucherSubcategoryID.TabIndex = 2026
        Me.LblVoucherSubcategoryID.Text = "Voucher Subcategory ID:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Location = New System.Drawing.Point(511, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 24)
        Me.Label5.TabIndex = 2018
        Me.Label5.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(44, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 24)
        Me.Label6.TabIndex = 2019
        Me.Label6.Text = "*"
        '
        'GrpSaveBox
        '
        Me.GrpSaveBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpSaveBox.Controls.Add(Me.TxtInitialBalance)
        Me.GrpSaveBox.Controls.Add(Me.LblInitialBalance)
        Me.GrpSaveBox.Controls.Add(Me.TxtTotalAmount)
        Me.GrpSaveBox.Controls.Add(Me.LblTotalAmount)
        Me.GrpSaveBox.Controls.Add(Me.TxtReceivedAmount)
        Me.GrpSaveBox.Controls.Add(Me.Label2)
        Me.GrpSaveBox.Controls.Add(Me.TxtPaidAmount)
        Me.GrpSaveBox.Controls.Add(Me.LblAmount)
        Me.GrpSaveBox.Controls.Add(Me.BtnSave)
        Me.GrpSaveBox.Location = New System.Drawing.Point(730, 389)
        Me.GrpSaveBox.Name = "GrpSaveBox"
        Me.GrpSaveBox.Size = New System.Drawing.Size(263, 312)
        Me.GrpSaveBox.TabIndex = 316
        Me.GrpSaveBox.TabStop = False
        '
        'TxtInitialBalance
        '
        Me.TxtInitialBalance.Location = New System.Drawing.Point(110, 30)
        Me.TxtInitialBalance.Name = "TxtInitialBalance"
        Me.TxtInitialBalance.Size = New System.Drawing.Size(133, 20)
        Me.TxtInitialBalance.TabIndex = 2037
        '
        'LblInitialBalance
        '
        Me.LblInitialBalance.AutoSize = True
        Me.LblInitialBalance.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblInitialBalance.Location = New System.Drawing.Point(9, 33)
        Me.LblInitialBalance.Name = "LblInitialBalance"
        Me.LblInitialBalance.Size = New System.Drawing.Size(76, 13)
        Me.LblInitialBalance.TabIndex = 2038
        Me.LblInitialBalance.Text = "Initial Balance:"
        '
        'TxtTotalAmount
        '
        Me.TxtTotalAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalAmount.Location = New System.Drawing.Point(109, 142)
        Me.TxtTotalAmount.Name = "TxtTotalAmount"
        Me.TxtTotalAmount.ReadOnly = True
        Me.TxtTotalAmount.Size = New System.Drawing.Size(134, 20)
        Me.TxtTotalAmount.TabIndex = 2041
        '
        'LblTotalAmount
        '
        Me.LblTotalAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTotalAmount.AutoSize = True
        Me.LblTotalAmount.Location = New System.Drawing.Point(9, 142)
        Me.LblTotalAmount.Name = "LblTotalAmount"
        Me.LblTotalAmount.Size = New System.Drawing.Size(73, 13)
        Me.LblTotalAmount.TabIndex = 2042
        Me.LblTotalAmount.Text = "Total Amount:"
        '
        'TxtReceivedAmount
        '
        Me.TxtReceivedAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtReceivedAmount.Location = New System.Drawing.Point(109, 109)
        Me.TxtReceivedAmount.Name = "TxtReceivedAmount"
        Me.TxtReceivedAmount.Size = New System.Drawing.Size(134, 20)
        Me.TxtReceivedAmount.TabIndex = 208
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 2032
        Me.Label2.Text = "Received Amount:"
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Image = Global.Business_Expert_Pro.My.Resources.Resources.Save1
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(125, 202)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(94, 32)
        Me.BtnSave.TabIndex = 209
        Me.BtnSave.Text = "Save"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'TxtVoucherNo
        '
        Me.TxtVoucherNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtVoucherNo.Enabled = False
        Me.TxtVoucherNo.Location = New System.Drawing.Point(779, 71)
        Me.TxtVoucherNo.Name = "TxtVoucherNo"
        Me.TxtVoucherNo.Size = New System.Drawing.Size(214, 20)
        Me.TxtVoucherNo.TabIndex = 2039
        '
        'LblVoucherNo
        '
        Me.LblVoucherNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblVoucherNo.AutoSize = True
        Me.LblVoucherNo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblVoucherNo.Location = New System.Drawing.Point(706, 74)
        Me.LblVoucherNo.Name = "LblVoucherNo"
        Me.LblVoucherNo.Size = New System.Drawing.Size(67, 13)
        Me.LblVoucherNo.TabIndex = 2040
        Me.LblVoucherNo.Text = "Voucher No:"
        '
        'TxtMobileNo
        '
        Me.TxtMobileNo.Location = New System.Drawing.Point(96, 79)
        Me.TxtMobileNo.Name = "TxtMobileNo"
        Me.TxtMobileNo.Size = New System.Drawing.Size(232, 20)
        Me.TxtMobileNo.TabIndex = 203
        '
        'LblMobileNO
        '
        Me.LblMobileNO.AutoSize = True
        Me.LblMobileNO.Location = New System.Drawing.Point(26, 82)
        Me.LblMobileNO.Name = "LblMobileNO"
        Me.LblMobileNO.Size = New System.Drawing.Size(58, 13)
        Me.LblMobileNO.TabIndex = 2030
        Me.LblMobileNO.Text = "Mobile No:"
        '
        'BtnDebitVoucher
        '
        Me.BtnDebitVoucher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnDebitVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDebitVoucher.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDebitVoucher.ForeColor = System.Drawing.Color.Red
        Me.BtnDebitVoucher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDebitVoucher.Location = New System.Drawing.Point(173, 71)
        Me.BtnDebitVoucher.Name = "BtnDebitVoucher"
        Me.BtnDebitVoucher.Size = New System.Drawing.Size(134, 42)
        Me.BtnDebitVoucher.TabIndex = 318
        Me.BtnDebitVoucher.Text = "DEBIT VOUCHER"
        Me.BtnDebitVoucher.UseVisualStyleBackColor = True
        '
        'BtnCreditVoucher
        '
        Me.BtnCreditVoucher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCreditVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCreditVoucher.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreditVoucher.ForeColor = System.Drawing.Color.Blue
        Me.BtnCreditVoucher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCreditVoucher.Location = New System.Drawing.Point(19, 71)
        Me.BtnCreditVoucher.Name = "BtnCreditVoucher"
        Me.BtnCreditVoucher.Size = New System.Drawing.Size(134, 42)
        Me.BtnCreditVoucher.TabIndex = 319
        Me.BtnCreditVoucher.Text = "CREDIT VOUCHER"
        Me.BtnCreditVoucher.UseVisualStyleBackColor = True
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(96, 44)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(232, 20)
        Me.TxtName.TabIndex = 202
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Location = New System.Drawing.Point(26, 47)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(38, 13)
        Me.LblName.TabIndex = 2045
        Me.LblName.Text = "Name:"
        '
        'GrpName
        '
        Me.GrpName.Controls.Add(Me.TxtName)
        Me.GrpName.Controls.Add(Me.LblName)
        Me.GrpName.Controls.Add(Me.TxtMobileNo)
        Me.GrpName.Controls.Add(Me.LblMobileNO)
        Me.GrpName.Controls.Add(Me.TxtVoucherID)
        Me.GrpName.Controls.Add(Me.LblVoucherID)
        Me.GrpName.Enabled = False
        Me.GrpName.Location = New System.Drawing.Point(15, 119)
        Me.GrpName.Name = "GrpName"
        Me.GrpName.Size = New System.Drawing.Size(345, 111)
        Me.GrpName.TabIndex = 317
        Me.GrpName.TabStop = False
        '
        'BtnDelete
        '
        Me.BtnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnDelete.Location = New System.Drawing.Point(909, 351)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(83, 40)
        Me.BtnDelete.TabIndex = 2047
        Me.BtnDelete.Text = "Delete Voucher"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(819, 351)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 40)
        Me.Button1.TabIndex = 2048
        Me.Button1.Text = "Voucher History"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(730, 351)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 40)
        Me.Button2.TabIndex = 2049
        Me.Button2.Text = "New Voucher"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(11, 705)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(177, 16)
        Me.Label11.TabIndex = 2050
        Me.Label11.Text = "For Billing : Ctrl+Space"
        '
        'FrmVoucher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.GrpName)
        Me.Controls.Add(Me.TxtVoucherNo)
        Me.Controls.Add(Me.LblVoucherNo)
        Me.Controls.Add(Me.GrpSaveBox)
        Me.Controls.Add(Me.BtnDebitVoucher)
        Me.Controls.Add(Me.BtnCreditVoucher)
        Me.Controls.Add(Me.DtpDate)
        Me.Controls.Add(Me.LblDate)
        Me.Controls.Add(Me.GrdVoucher)
        Me.Controls.Add(Me.GrpDetails)
        Me.Controls.Add(Me.PnlVoucher)
        Me.Name = "FrmVoucher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Voucher"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PnlVoucher.ResumeLayout(False)
        Me.PnlVoucher.PerformLayout()
        CType(Me.GrdVoucher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpDetails.ResumeLayout(False)
        Me.GrpDetails.PerformLayout()
        Me.GrpSaveBox.ResumeLayout(False)
        Me.GrpSaveBox.PerformLayout()
        Me.GrpName.ResumeLayout(False)
        Me.GrpName.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PnlVoucher As System.Windows.Forms.Panel
    Friend WithEvents LblVoucher As System.Windows.Forms.Label
    Friend WithEvents GrdVoucher As System.Windows.Forms.DataGridView
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents LblRemarks As System.Windows.Forms.Label
    Friend WithEvents LblAmount As System.Windows.Forms.Label
    Friend WithEvents LblVoucherPurposeID As System.Windows.Forms.Label
    Friend WithEvents LblVoucherCategoryID As System.Windows.Forms.Label
    Friend WithEvents LblDate As System.Windows.Forms.Label
    Friend WithEvents LblVoucherID As System.Windows.Forms.Label
    Friend WithEvents TxtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents TxtPaidAmount As System.Windows.Forms.TextBox
    Friend WithEvents TxtVoucherID As System.Windows.Forms.TextBox
    Friend WithEvents CmbVoucherPurposeID As System.Windows.Forms.ComboBox
    Friend WithEvents DtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GrpDetails As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CmbVoucherSubcategoryID As System.Windows.Forms.ComboBox
    Friend WithEvents LblVoucherSubcategoryID As System.Windows.Forms.Label
    Friend WithEvents TxtMobileNo As System.Windows.Forms.TextBox
    Friend WithEvents LblMobileNO As System.Windows.Forms.Label
    Friend WithEvents BtnDebitVoucher As System.Windows.Forms.Button
    Friend WithEvents BtnCreditVoucher As System.Windows.Forms.Button
    Friend WithEvents TxtReceivedAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbVoucherCategoryID As System.Windows.Forms.ComboBox
    Friend WithEvents TxtInitialBalance As System.Windows.Forms.TextBox
    Friend WithEvents LblInitialBalance As System.Windows.Forms.Label
    Friend WithEvents TxtVoucherNo As System.Windows.Forms.TextBox
    Friend WithEvents LblVoucherNo As System.Windows.Forms.Label
    Friend WithEvents TxtTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents LblTotalAmount As System.Windows.Forms.Label
    Friend WithEvents GrpSaveBox As System.Windows.Forms.GroupBox
    Friend WithEvents TxtName As System.Windows.Forms.TextBox
    Friend WithEvents LblName As System.Windows.Forms.Label
    Friend WithEvents GrpName As System.Windows.Forms.GroupBox
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
