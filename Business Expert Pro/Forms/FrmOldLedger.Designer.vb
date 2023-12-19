<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOldLedger
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
        Me.PnlLedger = New System.Windows.Forms.Panel
        Me.LbLedger = New System.Windows.Forms.Label
        Me.LblName = New System.Windows.Forms.Label
        Me.LblRemarks = New System.Windows.Forms.Label
        Me.LblLedgerID = New System.Windows.Forms.Label
        Me.TxtLedgerID = New System.Windows.Forms.TextBox
        Me.TxtRemarks = New System.Windows.Forms.TextBox
        Me.GrpLedger = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtCheckNo = New System.Windows.Forms.TextBox
        Me.TxtInitialBalance = New System.Windows.Forms.TextBox
        Me.LblCheckNo = New System.Windows.Forms.Label
        Me.LblInitialBalance = New System.Windows.Forms.Label
        Me.CmbPaidBy = New System.Windows.Forms.ComboBox
        Me.LblPaidBy = New System.Windows.Forms.Label
        Me.LblTotal = New System.Windows.Forms.Label
        Me.LblTotalDue = New System.Windows.Forms.Label
        Me.TxtDiscountAmount = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmbCustomerID = New System.Windows.Forms.ComboBox
        Me.TxtCreditedAmount = New System.Windows.Forms.TextBox
        Me.LblCreditedAmount = New System.Windows.Forms.Label
        Me.TxtDebitedAmount = New System.Windows.Forms.TextBox
        Me.LblDebitedAmount = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.DtpTransactionDate = New System.Windows.Forms.DateTimePicker
        Me.LblTransactionDate = New System.Windows.Forms.Label
        Me.GrdCustomerLedger = New System.Windows.Forms.DataGridView
        Me.BtnInsert = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.cmbSearchName = New System.Windows.Forms.ComboBox
        Me.LblSearchName = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.BtnDebitVoucher = New System.Windows.Forms.Button
        Me.BtnCreditVoucher = New System.Windows.Forms.Button
        Me.PnlLedger.SuspendLayout()
        Me.GrpLedger.SuspendLayout()
        CType(Me.GrdCustomerLedger, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlLedger
        '
        Me.PnlLedger.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlLedger.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PnlLedger.Controls.Add(Me.LbLedger)
        Me.PnlLedger.Location = New System.Drawing.Point(1, 0)
        Me.PnlLedger.Name = "PnlLedger"
        Me.PnlLedger.Size = New System.Drawing.Size(1031, 69)
        Me.PnlLedger.TabIndex = 0
        '
        'LbLedger
        '
        Me.LbLedger.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LbLedger.AutoSize = True
        Me.LbLedger.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LbLedger.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLedger.ForeColor = System.Drawing.Color.White
        Me.LbLedger.Location = New System.Drawing.Point(454, 12)
        Me.LbLedger.Name = "LbLedger"
        Me.LbLedger.Size = New System.Drawing.Size(122, 37)
        Me.LbLedger.TabIndex = 0
        Me.LbLedger.Text = "Ledger"
        Me.LbLedger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblName.Location = New System.Drawing.Point(30, 54)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(38, 13)
        Me.LblName.TabIndex = 6
        Me.LblName.Text = "Name:"
        '
        'LblRemarks
        '
        Me.LblRemarks.AutoSize = True
        Me.LblRemarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblRemarks.Location = New System.Drawing.Point(363, 103)
        Me.LblRemarks.Name = "LblRemarks"
        Me.LblRemarks.Size = New System.Drawing.Size(52, 13)
        Me.LblRemarks.TabIndex = 9
        Me.LblRemarks.Text = "Remarks:"
        '
        'LblLedgerID
        '
        Me.LblLedgerID.AutoSize = True
        Me.LblLedgerID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblLedgerID.Location = New System.Drawing.Point(30, 24)
        Me.LblLedgerID.Name = "LblLedgerID"
        Me.LblLedgerID.Size = New System.Drawing.Size(57, 13)
        Me.LblLedgerID.TabIndex = 11
        Me.LblLedgerID.Text = "Ledger ID:"
        '
        'TxtLedgerID
        '
        Me.TxtLedgerID.Enabled = False
        Me.TxtLedgerID.Location = New System.Drawing.Point(149, 23)
        Me.TxtLedgerID.Name = "TxtLedgerID"
        Me.TxtLedgerID.Size = New System.Drawing.Size(118, 20)
        Me.TxtLedgerID.TabIndex = 101
        '
        'TxtRemarks
        '
        Me.TxtRemarks.Location = New System.Drawing.Point(482, 103)
        Me.TxtRemarks.Multiline = True
        Me.TxtRemarks.Name = "TxtRemarks"
        Me.TxtRemarks.Size = New System.Drawing.Size(255, 55)
        Me.TxtRemarks.TabIndex = 108
        '
        'GrpLedger
        '
        Me.GrpLedger.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpLedger.Controls.Add(Me.Label6)
        Me.GrpLedger.Controls.Add(Me.Label5)
        Me.GrpLedger.Controls.Add(Me.TxtCheckNo)
        Me.GrpLedger.Controls.Add(Me.TxtInitialBalance)
        Me.GrpLedger.Controls.Add(Me.LblCheckNo)
        Me.GrpLedger.Controls.Add(Me.LblInitialBalance)
        Me.GrpLedger.Controls.Add(Me.CmbPaidBy)
        Me.GrpLedger.Controls.Add(Me.LblPaidBy)
        Me.GrpLedger.Controls.Add(Me.LblTotal)
        Me.GrpLedger.Controls.Add(Me.LblTotalDue)
        Me.GrpLedger.Controls.Add(Me.TxtDiscountAmount)
        Me.GrpLedger.Controls.Add(Me.Label2)
        Me.GrpLedger.Controls.Add(Me.Label1)
        Me.GrpLedger.Controls.Add(Me.CmbCustomerID)
        Me.GrpLedger.Controls.Add(Me.TxtCreditedAmount)
        Me.GrpLedger.Controls.Add(Me.LblCreditedAmount)
        Me.GrpLedger.Controls.Add(Me.TxtDebitedAmount)
        Me.GrpLedger.Controls.Add(Me.LblDebitedAmount)
        Me.GrpLedger.Controls.Add(Me.Label3)
        Me.GrpLedger.Controls.Add(Me.DtpTransactionDate)
        Me.GrpLedger.Controls.Add(Me.LblTransactionDate)
        Me.GrpLedger.Controls.Add(Me.TxtRemarks)
        Me.GrpLedger.Controls.Add(Me.TxtLedgerID)
        Me.GrpLedger.Controls.Add(Me.LblLedgerID)
        Me.GrpLedger.Controls.Add(Me.LblRemarks)
        Me.GrpLedger.Controls.Add(Me.LblName)
        Me.GrpLedger.Location = New System.Drawing.Point(16, 138)
        Me.GrpLedger.Name = "GrpLedger"
        Me.GrpLedger.Size = New System.Drawing.Size(1002, 241)
        Me.GrpLedger.TabIndex = 18
        Me.GrpLedger.TabStop = False
        Me.GrpLedger.Text = "Ledger"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(273, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 15)
        Me.Label6.TabIndex = 2055
        Me.Label6.Text = "[Paid]"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label5.Location = New System.Drawing.Point(273, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 15)
        Me.Label5.TabIndex = 2054
        Me.Label5.Text = "[Receive]"
        '
        'TxtCheckNo
        '
        Me.TxtCheckNo.Location = New System.Drawing.Point(149, 207)
        Me.TxtCheckNo.Name = "TxtCheckNo"
        Me.TxtCheckNo.Size = New System.Drawing.Size(206, 20)
        Me.TxtCheckNo.TabIndex = 107
        '
        'TxtInitialBalance
        '
        Me.TxtInitialBalance.Location = New System.Drawing.Point(482, 55)
        Me.TxtInitialBalance.Name = "TxtInitialBalance"
        Me.TxtInitialBalance.Size = New System.Drawing.Size(133, 20)
        Me.TxtInitialBalance.TabIndex = 2046
        '
        'LblCheckNo
        '
        Me.LblCheckNo.AutoSize = True
        Me.LblCheckNo.Location = New System.Drawing.Point(30, 204)
        Me.LblCheckNo.Name = "LblCheckNo"
        Me.LblCheckNo.Size = New System.Drawing.Size(55, 13)
        Me.LblCheckNo.TabIndex = 2053
        Me.LblCheckNo.Text = "Check No"
        '
        'LblInitialBalance
        '
        Me.LblInitialBalance.AutoSize = True
        Me.LblInitialBalance.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblInitialBalance.Location = New System.Drawing.Point(363, 55)
        Me.LblInitialBalance.Name = "LblInitialBalance"
        Me.LblInitialBalance.Size = New System.Drawing.Size(76, 13)
        Me.LblInitialBalance.TabIndex = 2047
        Me.LblInitialBalance.Text = "Initial Balance:"
        '
        'CmbPaidBy
        '
        Me.CmbPaidBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbPaidBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbPaidBy.FormattingEnabled = True
        Me.CmbPaidBy.Items.AddRange(New Object() {"Cash", "Check"})
        Me.CmbPaidBy.Location = New System.Drawing.Point(149, 174)
        Me.CmbPaidBy.Name = "CmbPaidBy"
        Me.CmbPaidBy.Size = New System.Drawing.Size(118, 21)
        Me.CmbPaidBy.TabIndex = 106
        '
        'LblPaidBy
        '
        Me.LblPaidBy.AutoSize = True
        Me.LblPaidBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblPaidBy.Location = New System.Drawing.Point(30, 174)
        Me.LblPaidBy.Name = "LblPaidBy"
        Me.LblPaidBy.Size = New System.Drawing.Size(46, 13)
        Me.LblPaidBy.TabIndex = 2052
        Me.LblPaidBy.Text = "Paid By:"
        '
        'LblTotal
        '
        Me.LblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.Location = New System.Drawing.Point(695, 16)
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
        Me.LblTotalDue.Location = New System.Drawing.Point(869, 16)
        Me.LblTotalDue.Name = "LblTotalDue"
        Me.LblTotalDue.Size = New System.Drawing.Size(26, 18)
        Me.LblTotalDue.TabIndex = 2044
        Me.LblTotalDue.Text = "00"
        '
        'TxtDiscountAmount
        '
        Me.TxtDiscountAmount.Location = New System.Drawing.Point(149, 144)
        Me.TxtDiscountAmount.Name = "TxtDiscountAmount"
        Me.TxtDiscountAmount.Size = New System.Drawing.Size(118, 20)
        Me.TxtDiscountAmount.TabIndex = 105
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 2039
        Me.Label2.Text = "Discount Amount:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(273, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 2037
        Me.Label1.Text = "[Enter]"
        '
        'CmbCustomerID
        '
        Me.CmbCustomerID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbCustomerID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.CmbCustomerID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbCustomerID.FormattingEnabled = True
        Me.CmbCustomerID.Location = New System.Drawing.Point(149, 53)
        Me.CmbCustomerID.Name = "CmbCustomerID"
        Me.CmbCustomerID.Size = New System.Drawing.Size(118, 21)
        Me.CmbCustomerID.TabIndex = 102
        '
        'TxtCreditedAmount
        '
        Me.TxtCreditedAmount.Enabled = False
        Me.TxtCreditedAmount.Location = New System.Drawing.Point(149, 114)
        Me.TxtCreditedAmount.Name = "TxtCreditedAmount"
        Me.TxtCreditedAmount.Size = New System.Drawing.Size(118, 20)
        Me.TxtCreditedAmount.TabIndex = 104
        '
        'LblCreditedAmount
        '
        Me.LblCreditedAmount.AutoSize = True
        Me.LblCreditedAmount.Location = New System.Drawing.Point(30, 114)
        Me.LblCreditedAmount.Name = "LblCreditedAmount"
        Me.LblCreditedAmount.Size = New System.Drawing.Size(88, 13)
        Me.LblCreditedAmount.TabIndex = 2032
        Me.LblCreditedAmount.Text = "Credited Amount:"
        '
        'TxtDebitedAmount
        '
        Me.TxtDebitedAmount.Enabled = False
        Me.TxtDebitedAmount.Location = New System.Drawing.Point(149, 84)
        Me.TxtDebitedAmount.Name = "TxtDebitedAmount"
        Me.TxtDebitedAmount.Size = New System.Drawing.Size(118, 20)
        Me.TxtDebitedAmount.TabIndex = 103
        '
        'LblDebitedAmount
        '
        Me.LblDebitedAmount.AutoSize = True
        Me.LblDebitedAmount.Location = New System.Drawing.Point(30, 84)
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
        Me.Label3.Location = New System.Drawing.Point(104, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 24)
        Me.Label3.TabIndex = 2018
        Me.Label3.Text = "*"
        '
        'DtpTransactionDate
        '
        Me.DtpTransactionDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpTransactionDate.Location = New System.Drawing.Point(482, 25)
        Me.DtpTransactionDate.Name = "DtpTransactionDate"
        Me.DtpTransactionDate.Size = New System.Drawing.Size(101, 20)
        Me.DtpTransactionDate.TabIndex = 2027
        '
        'LblTransactionDate
        '
        Me.LblTransactionDate.AutoSize = True
        Me.LblTransactionDate.Location = New System.Drawing.Point(363, 27)
        Me.LblTransactionDate.Name = "LblTransactionDate"
        Me.LblTransactionDate.Size = New System.Drawing.Size(92, 13)
        Me.LblTransactionDate.TabIndex = 2026
        Me.LblTransactionDate.Text = "Transaction Date:"
        '
        'GrdCustomerLedger
        '
        Me.GrdCustomerLedger.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdCustomerLedger.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GrdCustomerLedger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdCustomerLedger.Location = New System.Drawing.Point(12, 385)
        Me.GrdCustomerLedger.Name = "GrdCustomerLedger"
        Me.GrdCustomerLedger.Size = New System.Drawing.Size(1006, 339)
        Me.GrdCustomerLedger.TabIndex = 19
        '
        'BtnInsert
        '
        Me.BtnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInsert.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.BtnInsert.Image = Global.Business_Expert_Pro.My.Resources.Resources.Save1
        Me.BtnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInsert.Location = New System.Drawing.Point(381, 97)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(93, 35)
        Me.BtnInsert.TabIndex = 107
        Me.BtnInsert.Text = "Insert"
        Me.BtnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnInsert.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.BtnUpdate.Image = Global.Business_Expert_Pro.My.Resources.Resources.Edit1
        Me.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUpdate.Location = New System.Drawing.Point(282, 97)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(93, 35)
        Me.BtnUpdate.TabIndex = 109
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.BtnDelete.Image = Global.Business_Expert_Pro.My.Resources.Resources.Delete1
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(492, 97)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(93, 35)
        Me.BtnDelete.TabIndex = 110
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnSearch
        '
        Me.BtnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Image = Global.Business_Expert_Pro.My.Resources.Resources.Button_15_1281
        Me.BtnSearch.Location = New System.Drawing.Point(998, 75)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(19, 19)
        Me.BtnSearch.TabIndex = 114
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'cmbSearchName
        '
        Me.cmbSearchName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbSearchName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbSearchName.FormattingEnabled = True
        Me.cmbSearchName.Items.AddRange(New Object() {"Customer Name"})
        Me.cmbSearchName.Location = New System.Drawing.Point(784, 74)
        Me.cmbSearchName.Name = "cmbSearchName"
        Me.cmbSearchName.Size = New System.Drawing.Size(165, 21)
        Me.cmbSearchName.TabIndex = 2041
        '
        'LblSearchName
        '
        Me.LblSearchName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblSearchName.AutoSize = True
        Me.LblSearchName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSearchName.Location = New System.Drawing.Point(645, 77)
        Me.LblSearchName.Name = "LblSearchName"
        Me.LblSearchName.Size = New System.Drawing.Size(86, 15)
        Me.LblSearchName.TabIndex = 2044
        Me.LblSearchName.Text = "Search Name:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label4.Location = New System.Drawing.Point(952, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 15)
        Me.Label4.TabIndex = 2055
        Me.Label4.Text = "[Enter]"
        '
        'BtnDebitVoucher
        '
        Me.BtnDebitVoucher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnDebitVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDebitVoucher.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDebitVoucher.ForeColor = System.Drawing.Color.Red
        Me.BtnDebitVoucher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDebitVoucher.Location = New System.Drawing.Point(148, 97)
        Me.BtnDebitVoucher.Name = "BtnDebitVoucher"
        Me.BtnDebitVoucher.Size = New System.Drawing.Size(93, 35)
        Me.BtnDebitVoucher.TabIndex = 2056
        Me.BtnDebitVoucher.Text = "PAYMENT"
        Me.BtnDebitVoucher.UseVisualStyleBackColor = True
        '
        'BtnCreditVoucher
        '
        Me.BtnCreditVoucher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCreditVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCreditVoucher.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreditVoucher.ForeColor = System.Drawing.Color.Blue
        Me.BtnCreditVoucher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCreditVoucher.Location = New System.Drawing.Point(39, 97)
        Me.BtnCreditVoucher.Name = "BtnCreditVoucher"
        Me.BtnCreditVoucher.Size = New System.Drawing.Size(93, 35)
        Me.BtnCreditVoucher.TabIndex = 2057
        Me.BtnCreditVoucher.Text = "RECEIVE"
        Me.BtnCreditVoucher.UseVisualStyleBackColor = True
        '
        'FrmOldLedger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1030, 736)
        Me.Controls.Add(Me.BtnDebitVoucher)
        Me.Controls.Add(Me.BtnCreditVoucher)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LblSearchName)
        Me.Controls.Add(Me.cmbSearchName)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.GrdCustomerLedger)
        Me.Controls.Add(Me.GrpLedger)
        Me.Controls.Add(Me.BtnInsert)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.PnlLedger)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmOldLedger"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ledger"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PnlLedger.ResumeLayout(False)
        Me.PnlLedger.PerformLayout()
        Me.GrpLedger.ResumeLayout(False)
        Me.GrpLedger.PerformLayout()
        CType(Me.GrdCustomerLedger, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PnlLedger As System.Windows.Forms.Panel
    Friend WithEvents LbLedger As System.Windows.Forms.Label
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnInsert As System.Windows.Forms.Button
    Friend WithEvents LblName As System.Windows.Forms.Label
    Friend WithEvents LblRemarks As System.Windows.Forms.Label
    Friend WithEvents LblLedgerID As System.Windows.Forms.Label
    Friend WithEvents TxtLedgerID As System.Windows.Forms.TextBox
    Friend WithEvents TxtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents GrpLedger As System.Windows.Forms.GroupBox
    Friend WithEvents GrdCustomerLedger As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DtpTransactionDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblTransactionDate As System.Windows.Forms.Label
    Friend WithEvents TxtCreditedAmount As System.Windows.Forms.TextBox
    Friend WithEvents LblCreditedAmount As System.Windows.Forms.Label
    Friend WithEvents TxtDebitedAmount As System.Windows.Forms.TextBox
    Friend WithEvents LblDebitedAmount As System.Windows.Forms.Label
    Friend WithEvents CmbCustomerID As System.Windows.Forms.ComboBox
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtDiscountAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbSearchName As System.Windows.Forms.ComboBox
    Friend WithEvents LblSearchName As System.Windows.Forms.Label
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents LblTotalDue As System.Windows.Forms.Label
    Friend WithEvents TxtInitialBalance As System.Windows.Forms.TextBox
    Friend WithEvents LblInitialBalance As System.Windows.Forms.Label
    Friend WithEvents TxtCheckNo As System.Windows.Forms.TextBox
    Friend WithEvents LblCheckNo As System.Windows.Forms.Label
    Friend WithEvents CmbPaidBy As System.Windows.Forms.ComboBox
    Friend WithEvents LblPaidBy As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnDebitVoucher As System.Windows.Forms.Button
    Friend WithEvents BtnCreditVoucher As System.Windows.Forms.Button
End Class
