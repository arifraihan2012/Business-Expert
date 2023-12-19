<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSupplierLedger
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
        Me.PnlSupplierLedger = New System.Windows.Forms.Panel
        Me.LblSupplierLedger = New System.Windows.Forms.Label
        Me.LblSupplierID = New System.Windows.Forms.Label
        Me.LblRemarks = New System.Windows.Forms.Label
        Me.LblLedgerID = New System.Windows.Forms.Label
        Me.TxtLedgerID = New System.Windows.Forms.TextBox
        Me.TxtRemarks = New System.Windows.Forms.TextBox
        Me.GrpSupplierLedger = New System.Windows.Forms.GroupBox
        Me.TxtCheckNo = New System.Windows.Forms.TextBox
        Me.LblCheckNo = New System.Windows.Forms.Label
        Me.CmbPaidBy = New System.Windows.Forms.ComboBox
        Me.LblPaidBy = New System.Windows.Forms.Label
        Me.TxtInitialBalance = New System.Windows.Forms.TextBox
        Me.LblTotal = New System.Windows.Forms.Label
        Me.LblTotalDue = New System.Windows.Forms.Label
        Me.LblInitialBalance = New System.Windows.Forms.Label
        Me.TxtDiscountAmount = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmbSupplierID = New System.Windows.Forms.ComboBox
        Me.TxtCreditedAmount = New System.Windows.Forms.TextBox
        Me.LblCreditedAmount = New System.Windows.Forms.Label
        Me.TxtDebitedAmount = New System.Windows.Forms.TextBox
        Me.LblDebitedAmount = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.DtpTransactionDate = New System.Windows.Forms.DateTimePicker
        Me.LblTransactionDate = New System.Windows.Forms.Label
        Me.GrdSupplierLedger = New System.Windows.Forms.DataGridView
        Me.BtnInsert = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnAddNew = New System.Windows.Forms.Button
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.CmbSearchName = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.PnlSupplierLedger.SuspendLayout()
        Me.GrpSupplierLedger.SuspendLayout()
        CType(Me.GrdSupplierLedger, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlSupplierLedger
        '
        Me.PnlSupplierLedger.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlSupplierLedger.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PnlSupplierLedger.Controls.Add(Me.LblSupplierLedger)
        Me.PnlSupplierLedger.Location = New System.Drawing.Point(1, 0)
        Me.PnlSupplierLedger.Name = "PnlSupplierLedger"
        Me.PnlSupplierLedger.Size = New System.Drawing.Size(1031, 69)
        Me.PnlSupplierLedger.TabIndex = 0
        '
        'LblSupplierLedger
        '
        Me.LblSupplierLedger.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblSupplierLedger.AutoSize = True
        Me.LblSupplierLedger.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblSupplierLedger.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSupplierLedger.ForeColor = System.Drawing.Color.White
        Me.LblSupplierLedger.Location = New System.Drawing.Point(380, 12)
        Me.LblSupplierLedger.Name = "LblSupplierLedger"
        Me.LblSupplierLedger.Size = New System.Drawing.Size(257, 37)
        Me.LblSupplierLedger.TabIndex = 0
        Me.LblSupplierLedger.Text = "Supplier Ledger"
        Me.LblSupplierLedger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblSupplierID
        '
        Me.LblSupplierID.AutoSize = True
        Me.LblSupplierID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblSupplierID.Location = New System.Drawing.Point(30, 55)
        Me.LblSupplierID.Name = "LblSupplierID"
        Me.LblSupplierID.Size = New System.Drawing.Size(62, 13)
        Me.LblSupplierID.TabIndex = 6
        Me.LblSupplierID.Text = "Supplier ID:"
        '
        'LblRemarks
        '
        Me.LblRemarks.AutoSize = True
        Me.LblRemarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblRemarks.Location = New System.Drawing.Point(382, 107)
        Me.LblRemarks.Name = "LblRemarks"
        Me.LblRemarks.Size = New System.Drawing.Size(52, 13)
        Me.LblRemarks.TabIndex = 9
        Me.LblRemarks.Text = "Remarks:"
        '
        'LblLedgerID
        '
        Me.LblLedgerID.AutoSize = True
        Me.LblLedgerID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblLedgerID.Location = New System.Drawing.Point(30, 23)
        Me.LblLedgerID.Name = "LblLedgerID"
        Me.LblLedgerID.Size = New System.Drawing.Size(57, 13)
        Me.LblLedgerID.TabIndex = 11
        Me.LblLedgerID.Text = "Ledger ID:"
        '
        'TxtLedgerID
        '
        Me.TxtLedgerID.Enabled = False
        Me.TxtLedgerID.Location = New System.Drawing.Point(149, 22)
        Me.TxtLedgerID.Name = "TxtLedgerID"
        Me.TxtLedgerID.Size = New System.Drawing.Size(118, 20)
        Me.TxtLedgerID.TabIndex = 101
        '
        'TxtRemarks
        '
        Me.TxtRemarks.Location = New System.Drawing.Point(501, 107)
        Me.TxtRemarks.Multiline = True
        Me.TxtRemarks.Name = "TxtRemarks"
        Me.TxtRemarks.Size = New System.Drawing.Size(255, 49)
        Me.TxtRemarks.TabIndex = 108
        '
        'GrpSupplierLedger
        '
        Me.GrpSupplierLedger.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpSupplierLedger.Controls.Add(Me.Label6)
        Me.GrpSupplierLedger.Controls.Add(Me.Label7)
        Me.GrpSupplierLedger.Controls.Add(Me.TxtCheckNo)
        Me.GrpSupplierLedger.Controls.Add(Me.LblCheckNo)
        Me.GrpSupplierLedger.Controls.Add(Me.CmbPaidBy)
        Me.GrpSupplierLedger.Controls.Add(Me.LblPaidBy)
        Me.GrpSupplierLedger.Controls.Add(Me.TxtInitialBalance)
        Me.GrpSupplierLedger.Controls.Add(Me.LblTotal)
        Me.GrpSupplierLedger.Controls.Add(Me.LblTotalDue)
        Me.GrpSupplierLedger.Controls.Add(Me.LblInitialBalance)
        Me.GrpSupplierLedger.Controls.Add(Me.TxtDiscountAmount)
        Me.GrpSupplierLedger.Controls.Add(Me.Label2)
        Me.GrpSupplierLedger.Controls.Add(Me.Label1)
        Me.GrpSupplierLedger.Controls.Add(Me.CmbSupplierID)
        Me.GrpSupplierLedger.Controls.Add(Me.TxtCreditedAmount)
        Me.GrpSupplierLedger.Controls.Add(Me.LblCreditedAmount)
        Me.GrpSupplierLedger.Controls.Add(Me.TxtDebitedAmount)
        Me.GrpSupplierLedger.Controls.Add(Me.LblDebitedAmount)
        Me.GrpSupplierLedger.Controls.Add(Me.Label3)
        Me.GrpSupplierLedger.Controls.Add(Me.DtpTransactionDate)
        Me.GrpSupplierLedger.Controls.Add(Me.LblTransactionDate)
        Me.GrpSupplierLedger.Controls.Add(Me.TxtRemarks)
        Me.GrpSupplierLedger.Controls.Add(Me.TxtLedgerID)
        Me.GrpSupplierLedger.Controls.Add(Me.LblLedgerID)
        Me.GrpSupplierLedger.Controls.Add(Me.LblRemarks)
        Me.GrpSupplierLedger.Controls.Add(Me.LblSupplierID)
        Me.GrpSupplierLedger.Location = New System.Drawing.Point(12, 144)
        Me.GrpSupplierLedger.Name = "GrpSupplierLedger"
        Me.GrpSupplierLedger.Size = New System.Drawing.Size(1002, 243)
        Me.GrpSupplierLedger.TabIndex = 18
        Me.GrpSupplierLedger.TabStop = False
        Me.GrpSupplierLedger.Text = "Supplier Ledger"
        '
        'TxtCheckNo
        '
        Me.TxtCheckNo.Location = New System.Drawing.Point(149, 216)
        Me.TxtCheckNo.Name = "TxtCheckNo"
        Me.TxtCheckNo.Size = New System.Drawing.Size(206, 20)
        Me.TxtCheckNo.TabIndex = 107
        '
        'LblCheckNo
        '
        Me.LblCheckNo.AutoSize = True
        Me.LblCheckNo.Location = New System.Drawing.Point(30, 215)
        Me.LblCheckNo.Name = "LblCheckNo"
        Me.LblCheckNo.Size = New System.Drawing.Size(55, 13)
        Me.LblCheckNo.TabIndex = 2049
        Me.LblCheckNo.Text = "Check No"
        '
        'CmbPaidBy
        '
        Me.CmbPaidBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbPaidBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbPaidBy.FormattingEnabled = True
        Me.CmbPaidBy.Items.AddRange(New Object() {"Cash", "Check"})
        Me.CmbPaidBy.Location = New System.Drawing.Point(149, 183)
        Me.CmbPaidBy.Name = "CmbPaidBy"
        Me.CmbPaidBy.Size = New System.Drawing.Size(118, 21)
        Me.CmbPaidBy.TabIndex = 106
        '
        'LblPaidBy
        '
        Me.LblPaidBy.AutoSize = True
        Me.LblPaidBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblPaidBy.Location = New System.Drawing.Point(30, 183)
        Me.LblPaidBy.Name = "LblPaidBy"
        Me.LblPaidBy.Size = New System.Drawing.Size(46, 13)
        Me.LblPaidBy.TabIndex = 2046
        Me.LblPaidBy.Text = "Paid By:"
        '
        'TxtInitialBalance
        '
        Me.TxtInitialBalance.Location = New System.Drawing.Point(501, 55)
        Me.TxtInitialBalance.Name = "TxtInitialBalance"
        Me.TxtInitialBalance.Size = New System.Drawing.Size(133, 20)
        Me.TxtInitialBalance.TabIndex = 2040
        '
        'LblTotal
        '
        Me.LblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.Location = New System.Drawing.Point(708, 21)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(105, 18)
        Me.LblTotal.TabIndex = 2045
        Me.LblTotal.Text = "TOTAL DUE:"
        '
        'LblTotalDue
        '
        Me.LblTotalDue.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTotalDue.AutoSize = True
        Me.LblTotalDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalDue.Location = New System.Drawing.Point(867, 21)
        Me.LblTotalDue.Name = "LblTotalDue"
        Me.LblTotalDue.Size = New System.Drawing.Size(26, 18)
        Me.LblTotalDue.TabIndex = 2044
        Me.LblTotalDue.Text = "00"
        '
        'LblInitialBalance
        '
        Me.LblInitialBalance.AutoSize = True
        Me.LblInitialBalance.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblInitialBalance.Location = New System.Drawing.Point(382, 55)
        Me.LblInitialBalance.Name = "LblInitialBalance"
        Me.LblInitialBalance.Size = New System.Drawing.Size(76, 13)
        Me.LblInitialBalance.TabIndex = 2041
        Me.LblInitialBalance.Text = "Initial Balance:"
        '
        'TxtDiscountAmount
        '
        Me.TxtDiscountAmount.Location = New System.Drawing.Point(149, 151)
        Me.TxtDiscountAmount.Name = "TxtDiscountAmount"
        Me.TxtDiscountAmount.Size = New System.Drawing.Size(118, 20)
        Me.TxtDiscountAmount.TabIndex = 105
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 2039
        Me.Label2.Text = "Discount Amount:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(273, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 2037
        Me.Label1.Text = "[Enter]"
        '
        'CmbSupplierID
        '
        Me.CmbSupplierID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbSupplierID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.CmbSupplierID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbSupplierID.FormattingEnabled = True
        Me.CmbSupplierID.Location = New System.Drawing.Point(149, 54)
        Me.CmbSupplierID.Name = "CmbSupplierID"
        Me.CmbSupplierID.Size = New System.Drawing.Size(118, 21)
        Me.CmbSupplierID.TabIndex = 102
        '
        'TxtCreditedAmount
        '
        Me.TxtCreditedAmount.Location = New System.Drawing.Point(149, 119)
        Me.TxtCreditedAmount.Name = "TxtCreditedAmount"
        Me.TxtCreditedAmount.Size = New System.Drawing.Size(118, 20)
        Me.TxtCreditedAmount.TabIndex = 104
        '
        'LblCreditedAmount
        '
        Me.LblCreditedAmount.AutoSize = True
        Me.LblCreditedAmount.Location = New System.Drawing.Point(30, 119)
        Me.LblCreditedAmount.Name = "LblCreditedAmount"
        Me.LblCreditedAmount.Size = New System.Drawing.Size(88, 13)
        Me.LblCreditedAmount.TabIndex = 2032
        Me.LblCreditedAmount.Text = "Credited Amount:"
        '
        'TxtDebitedAmount
        '
        Me.TxtDebitedAmount.Location = New System.Drawing.Point(149, 87)
        Me.TxtDebitedAmount.Name = "TxtDebitedAmount"
        Me.TxtDebitedAmount.Size = New System.Drawing.Size(118, 20)
        Me.TxtDebitedAmount.TabIndex = 103
        '
        'LblDebitedAmount
        '
        Me.LblDebitedAmount.AutoSize = True
        Me.LblDebitedAmount.Location = New System.Drawing.Point(30, 87)
        Me.LblDebitedAmount.Name = "LblDebitedAmount"
        Me.LblDebitedAmount.Size = New System.Drawing.Size(86, 13)
        Me.LblDebitedAmount.TabIndex = 2031
        Me.LblDebitedAmount.Text = "Debited Amount:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(104, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 24)
        Me.Label3.TabIndex = 2018
        Me.Label3.Text = "*"
        '
        'DtpTransactionDate
        '
        Me.DtpTransactionDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpTransactionDate.Location = New System.Drawing.Point(501, 23)
        Me.DtpTransactionDate.Name = "DtpTransactionDate"
        Me.DtpTransactionDate.Size = New System.Drawing.Size(101, 20)
        Me.DtpTransactionDate.TabIndex = 2027
        '
        'LblTransactionDate
        '
        Me.LblTransactionDate.AutoSize = True
        Me.LblTransactionDate.Location = New System.Drawing.Point(382, 25)
        Me.LblTransactionDate.Name = "LblTransactionDate"
        Me.LblTransactionDate.Size = New System.Drawing.Size(92, 13)
        Me.LblTransactionDate.TabIndex = 2026
        Me.LblTransactionDate.Text = "Transaction Date:"
        '
        'GrdSupplierLedger
        '
        Me.GrdSupplierLedger.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdSupplierLedger.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GrdSupplierLedger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdSupplierLedger.Location = New System.Drawing.Point(12, 393)
        Me.GrdSupplierLedger.Name = "GrdSupplierLedger"
        Me.GrdSupplierLedger.Size = New System.Drawing.Size(1006, 331)
        Me.GrdSupplierLedger.TabIndex = 19
        '
        'BtnInsert
        '
        Me.BtnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInsert.Image = Global.Business_Expert_Pro.My.Resources.Resources.Save1
        Me.BtnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInsert.Location = New System.Drawing.Point(318, 98)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(85, 40)
        Me.BtnInsert.TabIndex = 107
        Me.BtnInsert.Text = "Insert"
        Me.BtnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnInsert.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Image = Global.Business_Expert_Pro.My.Resources.Resources.Edit1
        Me.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUpdate.Location = New System.Drawing.Point(103, 98)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(85, 40)
        Me.BtnUpdate.TabIndex = 109
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Image = Global.Business_Expert_Pro.My.Resources.Resources.Delete1
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(194, 98)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(85, 40)
        Me.BtnDelete.TabIndex = 110
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnAddNew
        '
        Me.BtnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddNew.Image = Global.Business_Expert_Pro.My.Resources.Resources.Add_New1
        Me.BtnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddNew.Location = New System.Drawing.Point(12, 98)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(85, 40)
        Me.BtnAddNew.TabIndex = 108
        Me.BtnAddNew.Text = "Add New"
        Me.BtnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'BtnSearch
        '
        Me.BtnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Image = Global.Business_Expert_Pro.My.Resources.Resources.Button_15_1281
        Me.BtnSearch.Location = New System.Drawing.Point(997, 75)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(19, 19)
        Me.BtnSearch.TabIndex = 114
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'CmbSearchName
        '
        Me.CmbSearchName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbSearchName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbSearchName.FormattingEnabled = True
        Me.CmbSearchName.Items.AddRange(New Object() {"Supplier Name"})
        Me.CmbSearchName.Location = New System.Drawing.Point(792, 74)
        Me.CmbSearchName.Name = "CmbSearchName"
        Me.CmbSearchName.Size = New System.Drawing.Size(155, 21)
        Me.CmbSearchName.TabIndex = 2039
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(669, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 15)
        Me.Label5.TabIndex = 2046
        Me.Label5.Text = "Search Supplier:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label4.Location = New System.Drawing.Point(953, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 15)
        Me.Label4.TabIndex = 2056
        Me.Label4.Text = "[Enter]"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label7.Location = New System.Drawing.Point(273, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 15)
        Me.Label7.TabIndex = 2058
        Me.Label7.Text = "[Receive]"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(273, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 15)
        Me.Label6.TabIndex = 2059
        Me.Label6.Text = "[Paid]"
        '
        'FrmSupplierLedger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1030, 736)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CmbSearchName)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.GrdSupplierLedger)
        Me.Controls.Add(Me.GrpSupplierLedger)
        Me.Controls.Add(Me.BtnInsert)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.PnlSupplierLedger)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmSupplierLedger"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supplier Ledger"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PnlSupplierLedger.ResumeLayout(False)
        Me.PnlSupplierLedger.PerformLayout()
        Me.GrpSupplierLedger.ResumeLayout(False)
        Me.GrpSupplierLedger.PerformLayout()
        CType(Me.GrdSupplierLedger, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PnlSupplierLedger As System.Windows.Forms.Panel
    Friend WithEvents LblSupplierLedger As System.Windows.Forms.Label
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnInsert As System.Windows.Forms.Button
    Friend WithEvents LblSupplierID As System.Windows.Forms.Label
    Friend WithEvents LblRemarks As System.Windows.Forms.Label
    Friend WithEvents LblLedgerID As System.Windows.Forms.Label
    Friend WithEvents TxtLedgerID As System.Windows.Forms.TextBox
    Friend WithEvents TxtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents GrpSupplierLedger As System.Windows.Forms.GroupBox
    Friend WithEvents GrdSupplierLedger As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DtpTransactionDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblTransactionDate As System.Windows.Forms.Label
    Friend WithEvents TxtCreditedAmount As System.Windows.Forms.TextBox
    Friend WithEvents LblCreditedAmount As System.Windows.Forms.Label
    Friend WithEvents TxtDebitedAmount As System.Windows.Forms.TextBox
    Friend WithEvents LblDebitedAmount As System.Windows.Forms.Label
    Friend WithEvents CmbSupplierID As System.Windows.Forms.ComboBox
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtDiscountAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbSearchName As System.Windows.Forms.ComboBox
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents LblTotalDue As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtInitialBalance As System.Windows.Forms.TextBox
    Friend WithEvents LblInitialBalance As System.Windows.Forms.Label
    Friend WithEvents TxtCheckNo As System.Windows.Forms.TextBox
    Friend WithEvents LblCheckNo As System.Windows.Forms.Label
    Friend WithEvents CmbPaidBy As System.Windows.Forms.ComboBox
    Friend WithEvents LblPaidBy As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
