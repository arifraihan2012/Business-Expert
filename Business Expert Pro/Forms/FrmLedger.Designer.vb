<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLedger
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
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.LbLedger = New System.Windows.Forms.Label
        Me.LblChartOfAccount = New System.Windows.Forms.Label
        Me.LblRemarks = New System.Windows.Forms.Label
        Me.TxtRemarks = New System.Windows.Forms.TextBox
        Me.GrpLedger = New System.Windows.Forms.GroupBox
        Me.CmbVoucherName = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.LblVoucherName = New System.Windows.Forms.Label
        Me.BtnAddItem = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LblBalance2Lbl = New System.Windows.Forms.Label
        Me.LblBalance2 = New System.Windows.Forms.Label
        Me.LblBalance1Lbl = New System.Windows.Forms.Label
        Me.LblBalance1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.DtpIssueDate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtVoucherNo = New System.Windows.Forms.TextBox
        Me.LblVoucherNo = New System.Windows.Forms.Label
        Me.TxtCheckNo = New System.Windows.Forms.TextBox
        Me.LblCheckNo = New System.Windows.Forms.Label
        Me.TxtLedgerNo = New System.Windows.Forms.TextBox
        Me.LblLedgerNo = New System.Windows.Forms.Label
        Me.CmbPaidBy = New System.Windows.Forms.ComboBox
        Me.LblPaidBy = New System.Windows.Forms.Label
        Me.CmbChartOfAccount = New System.Windows.Forms.ComboBox
        Me.TxtAmount = New System.Windows.Forms.TextBox
        Me.LblAmount = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.GrdShowDueBills = New System.Windows.Forms.DataGridView
        Me.DtpLedgerDate = New System.Windows.Forms.DateTimePicker
        Me.LblLedgerDate = New System.Windows.Forms.Label
        Me.GrdLedger = New System.Windows.Forms.DataGridView
        Me.BtnPayment = New System.Windows.Forms.Button
        Me.BtnCollection = New System.Windows.Forms.Button
        Me.BtnTransfer = New System.Windows.Forms.Button
        Me.BtnExpense = New System.Windows.Forms.Button
        Me.BtnInvoice = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.TxtLedgerInvoiceNo = New System.Windows.Forms.TextBox
        Me.LblLedgerInvoiceNo = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.GrdVoucherName = New System.Windows.Forms.DataGridView
        Me.GrdChartofAccount = New System.Windows.Forms.DataGridView
        Me.GrdPaidBy = New System.Windows.Forms.DataGridView
        Me.PnlLedger.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GrpLedger.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GrdShowDueBills, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdLedger, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdVoucherName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdChartofAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdPaidBy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlLedger
        '
        Me.PnlLedger.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlLedger.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlLedger.Controls.Add(Me.Panel2)
        Me.PnlLedger.Controls.Add(Me.LbLedger)
        Me.PnlLedger.Location = New System.Drawing.Point(1, 0)
        Me.PnlLedger.Name = "PnlLedger"
        Me.PnlLedger.Size = New System.Drawing.Size(1031, 84)
        Me.PnlLedger.TabIndex = 0
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
        Me.Panel2.Size = New System.Drawing.Size(1028, 27)
        Me.Panel2.TabIndex = 2076
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(1004, 0)
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
        Me.Btnminimized.Location = New System.Drawing.Point(944, 0)
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
        Me.Btnmaximized.Location = New System.Drawing.Point(974, 0)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1160
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'LbLedger
        '
        Me.LbLedger.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LbLedger.AutoSize = True
        Me.LbLedger.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LbLedger.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLedger.ForeColor = System.Drawing.Color.White
        Me.LbLedger.Location = New System.Drawing.Point(412, 45)
        Me.LbLedger.Name = "LbLedger"
        Me.LbLedger.Size = New System.Drawing.Size(206, 37)
        Me.LbLedger.TabIndex = 0
        Me.LbLedger.Text = "ACCOUNTS"
        Me.LbLedger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblChartOfAccount
        '
        Me.LblChartOfAccount.AutoSize = True
        Me.LblChartOfAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblChartOfAccount.Location = New System.Drawing.Point(13, 82)
        Me.LblChartOfAccount.Name = "LblChartOfAccount"
        Me.LblChartOfAccount.Size = New System.Drawing.Size(90, 13)
        Me.LblChartOfAccount.TabIndex = 6
        Me.LblChartOfAccount.Text = "Chart of Account:"
        '
        'LblRemarks
        '
        Me.LblRemarks.AutoSize = True
        Me.LblRemarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblRemarks.Location = New System.Drawing.Point(13, 238)
        Me.LblRemarks.Name = "LblRemarks"
        Me.LblRemarks.Size = New System.Drawing.Size(52, 13)
        Me.LblRemarks.TabIndex = 9
        Me.LblRemarks.Text = "Remarks:"
        '
        'TxtRemarks
        '
        Me.TxtRemarks.Location = New System.Drawing.Point(133, 232)
        Me.TxtRemarks.Multiline = True
        Me.TxtRemarks.Name = "TxtRemarks"
        Me.TxtRemarks.Size = New System.Drawing.Size(402, 41)
        Me.TxtRemarks.TabIndex = 109
        '
        'GrpLedger
        '
        Me.GrpLedger.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpLedger.Controls.Add(Me.CmbVoucherName)
        Me.GrpLedger.Controls.Add(Me.Label5)
        Me.GrpLedger.Controls.Add(Me.LblVoucherName)
        Me.GrpLedger.Controls.Add(Me.BtnAddItem)
        Me.GrpLedger.Controls.Add(Me.GroupBox1)
        Me.GrpLedger.Controls.Add(Me.Label4)
        Me.GrpLedger.Controls.Add(Me.DtpIssueDate)
        Me.GrpLedger.Controls.Add(Me.Label2)
        Me.GrpLedger.Controls.Add(Me.Label1)
        Me.GrpLedger.Controls.Add(Me.TxtVoucherNo)
        Me.GrpLedger.Controls.Add(Me.LblVoucherNo)
        Me.GrpLedger.Controls.Add(Me.TxtCheckNo)
        Me.GrpLedger.Controls.Add(Me.LblCheckNo)
        Me.GrpLedger.Controls.Add(Me.TxtLedgerNo)
        Me.GrpLedger.Controls.Add(Me.LblLedgerNo)
        Me.GrpLedger.Controls.Add(Me.CmbPaidBy)
        Me.GrpLedger.Controls.Add(Me.LblPaidBy)
        Me.GrpLedger.Controls.Add(Me.CmbChartOfAccount)
        Me.GrpLedger.Controls.Add(Me.TxtAmount)
        Me.GrpLedger.Controls.Add(Me.LblAmount)
        Me.GrpLedger.Controls.Add(Me.Label3)
        Me.GrpLedger.Controls.Add(Me.TxtRemarks)
        Me.GrpLedger.Controls.Add(Me.LblRemarks)
        Me.GrpLedger.Controls.Add(Me.LblChartOfAccount)
        Me.GrpLedger.Enabled = False
        Me.GrpLedger.Location = New System.Drawing.Point(16, 175)
        Me.GrpLedger.Name = "GrpLedger"
        Me.GrpLedger.Size = New System.Drawing.Size(1002, 284)
        Me.GrpLedger.TabIndex = 18
        Me.GrpLedger.TabStop = False
        Me.GrpLedger.Text = "Ledger"
        '
        'CmbVoucherName
        '
        Me.CmbVoucherName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbVoucherName.FormattingEnabled = True
        Me.CmbVoucherName.Location = New System.Drawing.Point(133, 49)
        Me.CmbVoucherName.Name = "CmbVoucherName"
        Me.CmbVoucherName.Size = New System.Drawing.Size(402, 21)
        Me.CmbVoucherName.TabIndex = 102
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Location = New System.Drawing.Point(107, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 24)
        Me.Label5.TabIndex = 2077
        Me.Label5.Text = "*"
        '
        'LblVoucherName
        '
        Me.LblVoucherName.AutoSize = True
        Me.LblVoucherName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblVoucherName.Location = New System.Drawing.Point(13, 52)
        Me.LblVoucherName.Name = "LblVoucherName"
        Me.LblVoucherName.Size = New System.Drawing.Size(81, 13)
        Me.LblVoucherName.TabIndex = 2075
        Me.LblVoucherName.Text = "Voucher Name:"
        '
        'BtnAddItem
        '
        Me.BtnAddItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddItem.Image = Global.Business_Expert_Pro.My.Resources.Resources.Add_New3
        Me.BtnAddItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddItem.Location = New System.Drawing.Point(541, 138)
        Me.BtnAddItem.Name = "BtnAddItem"
        Me.BtnAddItem.Size = New System.Drawing.Size(98, 35)
        Me.BtnAddItem.TabIndex = 2074
        Me.BtnAddItem.Text = "Add Item"
        Me.BtnAddItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddItem.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblBalance2Lbl)
        Me.GroupBox1.Controls.Add(Me.LblBalance2)
        Me.GroupBox1.Controls.Add(Me.LblBalance1Lbl)
        Me.GroupBox1.Controls.Add(Me.LblBalance1)
        Me.GroupBox1.Location = New System.Drawing.Point(541, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(291, 57)
        Me.GroupBox1.TabIndex = 2070
        Me.GroupBox1.TabStop = False
        '
        'LblBalance2Lbl
        '
        Me.LblBalance2Lbl.AutoSize = True
        Me.LblBalance2Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBalance2Lbl.Location = New System.Drawing.Point(7, 31)
        Me.LblBalance2Lbl.Name = "LblBalance2Lbl"
        Me.LblBalance2Lbl.Size = New System.Drawing.Size(71, 20)
        Me.LblBalance2Lbl.TabIndex = 2069
        Me.LblBalance2Lbl.Text = "Balance:"
        '
        'LblBalance2
        '
        Me.LblBalance2.AutoSize = True
        Me.LblBalance2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBalance2.Location = New System.Drawing.Point(85, 31)
        Me.LblBalance2.Name = "LblBalance2"
        Me.LblBalance2.Size = New System.Drawing.Size(27, 20)
        Me.LblBalance2.TabIndex = 2068
        Me.LblBalance2.Text = "00"
        '
        'LblBalance1Lbl
        '
        Me.LblBalance1Lbl.AutoSize = True
        Me.LblBalance1Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBalance1Lbl.Location = New System.Drawing.Point(7, 11)
        Me.LblBalance1Lbl.Name = "LblBalance1Lbl"
        Me.LblBalance1Lbl.Size = New System.Drawing.Size(71, 20)
        Me.LblBalance1Lbl.TabIndex = 2067
        Me.LblBalance1Lbl.Text = "Balance:"
        '
        'LblBalance1
        '
        Me.LblBalance1.AutoSize = True
        Me.LblBalance1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBalance1.Location = New System.Drawing.Point(85, 11)
        Me.LblBalance1.Name = "LblBalance1"
        Me.LblBalance1.Size = New System.Drawing.Size(27, 20)
        Me.LblBalance1.TabIndex = 2066
        Me.LblBalance1.Text = "00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(345, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 2065
        Me.Label4.Text = "Issue Date:"
        '
        'DtpIssueDate
        '
        Me.DtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpIssueDate.Location = New System.Drawing.Point(412, 172)
        Me.DtpIssueDate.Name = "DtpIssueDate"
        Me.DtpIssueDate.Size = New System.Drawing.Size(123, 20)
        Me.DtpIssueDate.TabIndex = 107
        Me.DtpIssueDate.Value = New Date(2018, 3, 4, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(107, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 24)
        Me.Label2.TabIndex = 2063
        Me.Label2.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(107, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 24)
        Me.Label1.TabIndex = 2063
        Me.Label1.Text = "*"
        '
        'TxtVoucherNo
        '
        Me.TxtVoucherNo.Location = New System.Drawing.Point(133, 202)
        Me.TxtVoucherNo.Name = "TxtVoucherNo"
        Me.TxtVoucherNo.Size = New System.Drawing.Size(206, 20)
        Me.TxtVoucherNo.TabIndex = 108
        '
        'LblVoucherNo
        '
        Me.LblVoucherNo.AutoSize = True
        Me.LblVoucherNo.Location = New System.Drawing.Point(13, 202)
        Me.LblVoucherNo.Name = "LblVoucherNo"
        Me.LblVoucherNo.Size = New System.Drawing.Size(67, 13)
        Me.LblVoucherNo.TabIndex = 2062
        Me.LblVoucherNo.Text = "Voucher No:"
        '
        'TxtCheckNo
        '
        Me.TxtCheckNo.Location = New System.Drawing.Point(133, 172)
        Me.TxtCheckNo.Name = "TxtCheckNo"
        Me.TxtCheckNo.Size = New System.Drawing.Size(206, 20)
        Me.TxtCheckNo.TabIndex = 106
        '
        'LblCheckNo
        '
        Me.LblCheckNo.AutoSize = True
        Me.LblCheckNo.Location = New System.Drawing.Point(13, 172)
        Me.LblCheckNo.Name = "LblCheckNo"
        Me.LblCheckNo.Size = New System.Drawing.Size(58, 13)
        Me.LblCheckNo.TabIndex = 2057
        Me.LblCheckNo.Text = "Check No:"
        '
        'TxtLedgerNo
        '
        Me.TxtLedgerNo.Enabled = False
        Me.TxtLedgerNo.Location = New System.Drawing.Point(133, 19)
        Me.TxtLedgerNo.Name = "TxtLedgerNo"
        Me.TxtLedgerNo.Size = New System.Drawing.Size(137, 20)
        Me.TxtLedgerNo.TabIndex = 101
        '
        'LblLedgerNo
        '
        Me.LblLedgerNo.AutoSize = True
        Me.LblLedgerNo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblLedgerNo.Location = New System.Drawing.Point(13, 22)
        Me.LblLedgerNo.Name = "LblLedgerNo"
        Me.LblLedgerNo.Size = New System.Drawing.Size(60, 13)
        Me.LblLedgerNo.TabIndex = 2047
        Me.LblLedgerNo.Text = "Ledger No:"
        '
        'CmbPaidBy
        '
        Me.CmbPaidBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbPaidBy.FormattingEnabled = True
        Me.CmbPaidBy.Location = New System.Drawing.Point(133, 111)
        Me.CmbPaidBy.Name = "CmbPaidBy"
        Me.CmbPaidBy.Size = New System.Drawing.Size(402, 21)
        Me.CmbPaidBy.TabIndex = 104
        '
        'LblPaidBy
        '
        Me.LblPaidBy.AutoSize = True
        Me.LblPaidBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblPaidBy.Location = New System.Drawing.Point(13, 112)
        Me.LblPaidBy.Name = "LblPaidBy"
        Me.LblPaidBy.Size = New System.Drawing.Size(46, 13)
        Me.LblPaidBy.TabIndex = 2052
        Me.LblPaidBy.Text = "Paid By:"
        '
        'CmbChartOfAccount
        '
        Me.CmbChartOfAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbChartOfAccount.FormattingEnabled = True
        Me.CmbChartOfAccount.Location = New System.Drawing.Point(133, 80)
        Me.CmbChartOfAccount.Name = "CmbChartOfAccount"
        Me.CmbChartOfAccount.Size = New System.Drawing.Size(402, 21)
        Me.CmbChartOfAccount.TabIndex = 103
        '
        'TxtAmount
        '
        Me.TxtAmount.Location = New System.Drawing.Point(133, 142)
        Me.TxtAmount.Name = "TxtAmount"
        Me.TxtAmount.Size = New System.Drawing.Size(118, 20)
        Me.TxtAmount.TabIndex = 105
        '
        'LblAmount
        '
        Me.LblAmount.AutoSize = True
        Me.LblAmount.Location = New System.Drawing.Point(13, 142)
        Me.LblAmount.Name = "LblAmount"
        Me.LblAmount.Size = New System.Drawing.Size(46, 13)
        Me.LblAmount.TabIndex = 2032
        Me.LblAmount.Text = "Amount:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(107, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 24)
        Me.Label3.TabIndex = 2018
        Me.Label3.Text = "*"
        '
        'BtnDelete
        '
        Me.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.BtnDelete.Image = Global.Business_Expert_Pro.My.Resources.Resources.Delete_32px
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(932, 138)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(86, 35)
        Me.BtnDelete.TabIndex = 110
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'GrdShowDueBills
        '
        Me.GrdShowDueBills.AllowUserToAddRows = False
        Me.GrdShowDueBills.AllowUserToDeleteRows = False
        Me.GrdShowDueBills.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdShowDueBills.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GrdShowDueBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdShowDueBills.Location = New System.Drawing.Point(755, 469)
        Me.GrdShowDueBills.Name = "GrdShowDueBills"
        Me.GrdShowDueBills.ReadOnly = True
        Me.GrdShowDueBills.Size = New System.Drawing.Size(263, 255)
        Me.GrdShowDueBills.TabIndex = 2071
        '
        'DtpLedgerDate
        '
        Me.DtpLedgerDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtpLedgerDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpLedgerDate.Location = New System.Drawing.Point(881, 113)
        Me.DtpLedgerDate.Name = "DtpLedgerDate"
        Me.DtpLedgerDate.Size = New System.Drawing.Size(137, 20)
        Me.DtpLedgerDate.TabIndex = 102
        Me.DtpLedgerDate.Value = New Date(2018, 3, 3, 0, 0, 0, 0)
        '
        'LblLedgerDate
        '
        Me.LblLedgerDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblLedgerDate.AutoSize = True
        Me.LblLedgerDate.Location = New System.Drawing.Point(806, 113)
        Me.LblLedgerDate.Name = "LblLedgerDate"
        Me.LblLedgerDate.Size = New System.Drawing.Size(69, 13)
        Me.LblLedgerDate.TabIndex = 2026
        Me.LblLedgerDate.Text = "Ledger Date:"
        '
        'GrdLedger
        '
        Me.GrdLedger.AllowUserToAddRows = False
        Me.GrdLedger.AllowUserToDeleteRows = False
        Me.GrdLedger.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdLedger.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GrdLedger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdLedger.Location = New System.Drawing.Point(12, 469)
        Me.GrdLedger.Name = "GrdLedger"
        Me.GrdLedger.ReadOnly = True
        Me.GrdLedger.Size = New System.Drawing.Size(737, 255)
        Me.GrdLedger.TabIndex = 19
        '
        'BtnPayment
        '
        Me.BtnPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPayment.ForeColor = System.Drawing.Color.Black
        Me.BtnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPayment.Location = New System.Drawing.Point(120, 139)
        Me.BtnPayment.Name = "BtnPayment"
        Me.BtnPayment.Size = New System.Drawing.Size(86, 35)
        Me.BtnPayment.TabIndex = 2056
        Me.BtnPayment.Text = "Payment"
        Me.BtnPayment.UseVisualStyleBackColor = True
        '
        'BtnCollection
        '
        Me.BtnCollection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCollection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCollection.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCollection.ForeColor = System.Drawing.Color.Black
        Me.BtnCollection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCollection.Location = New System.Drawing.Point(18, 139)
        Me.BtnCollection.Name = "BtnCollection"
        Me.BtnCollection.Size = New System.Drawing.Size(86, 35)
        Me.BtnCollection.TabIndex = 2057
        Me.BtnCollection.Text = "Collection"
        Me.BtnCollection.UseVisualStyleBackColor = True
        '
        'BtnTransfer
        '
        Me.BtnTransfer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTransfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTransfer.ForeColor = System.Drawing.Color.Black
        Me.BtnTransfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTransfer.Location = New System.Drawing.Point(314, 139)
        Me.BtnTransfer.Name = "BtnTransfer"
        Me.BtnTransfer.Size = New System.Drawing.Size(86, 35)
        Me.BtnTransfer.TabIndex = 2058
        Me.BtnTransfer.Text = "Transfer"
        Me.BtnTransfer.UseVisualStyleBackColor = True
        '
        'BtnExpense
        '
        Me.BtnExpense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExpense.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExpense.ForeColor = System.Drawing.Color.Black
        Me.BtnExpense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExpense.Location = New System.Drawing.Point(212, 139)
        Me.BtnExpense.Name = "BtnExpense"
        Me.BtnExpense.Size = New System.Drawing.Size(86, 35)
        Me.BtnExpense.TabIndex = 2059
        Me.BtnExpense.Text = "Expense"
        Me.BtnExpense.UseVisualStyleBackColor = True
        '
        'BtnInvoice
        '
        Me.BtnInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInvoice.Image = Global.Business_Expert_Pro.My.Resources.Resources.Last_view1
        Me.BtnInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInvoice.Location = New System.Drawing.Point(710, 139)
        Me.BtnInvoice.Name = "BtnInvoice"
        Me.BtnInvoice.Size = New System.Drawing.Size(94, 35)
        Me.BtnInvoice.TabIndex = 2070
        Me.BtnInvoice.Text = "Invoice"
        Me.BtnInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnInvoice.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Business_Expert_Pro.My.Resources.Resources.Reboot_32px
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(610, 139)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 35)
        Me.Button1.TabIndex = 2060
        Me.Button1.Text = "Refresh"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Image = Global.Business_Expert_Pro.My.Resources.Resources.Save_32px_3
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(518, 139)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(86, 35)
        Me.BtnSave.TabIndex = 107
        Me.BtnSave.Text = "Save"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'TxtLedgerInvoiceNo
        '
        Me.TxtLedgerInvoiceNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtLedgerInvoiceNo.Enabled = False
        Me.TxtLedgerInvoiceNo.Location = New System.Drawing.Point(881, 90)
        Me.TxtLedgerInvoiceNo.Name = "TxtLedgerInvoiceNo"
        Me.TxtLedgerInvoiceNo.Size = New System.Drawing.Size(137, 20)
        Me.TxtLedgerInvoiceNo.TabIndex = 2072
        '
        'LblLedgerInvoiceNo
        '
        Me.LblLedgerInvoiceNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblLedgerInvoiceNo.AutoSize = True
        Me.LblLedgerInvoiceNo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblLedgerInvoiceNo.Location = New System.Drawing.Point(806, 93)
        Me.LblLedgerInvoiceNo.Name = "LblLedgerInvoiceNo"
        Me.LblLedgerInvoiceNo.Size = New System.Drawing.Size(62, 13)
        Me.LblLedgerInvoiceNo.TabIndex = 2073
        Me.LblLedgerInvoiceNo.Text = "Invoice No:"
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Business_Expert_Pro.My.Resources.Resources.Last_view1
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(832, 138)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 35)
        Me.Button2.TabIndex = 2074
        Me.Button2.Text = "History"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(426, 139)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 35)
        Me.Button3.TabIndex = 2075
        Me.Button3.Text = "New Invoice"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GrdVoucherName
        '
        Me.GrdVoucherName.AllowUserToAddRows = False
        Me.GrdVoucherName.AllowUserToDeleteRows = False
        Me.GrdVoucherName.BackgroundColor = System.Drawing.Color.White
        Me.GrdVoucherName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdVoucherName.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GrdVoucherName.Location = New System.Drawing.Point(148, 245)
        Me.GrdVoucherName.Name = "GrdVoucherName"
        Me.GrdVoucherName.ReadOnly = True
        Me.GrdVoucherName.Size = New System.Drawing.Size(403, 13)
        Me.GrdVoucherName.TabIndex = 2078
        Me.GrdVoucherName.Visible = False
        '
        'GrdChartofAccount
        '
        Me.GrdChartofAccount.AllowUserToAddRows = False
        Me.GrdChartofAccount.AllowUserToDeleteRows = False
        Me.GrdChartofAccount.BackgroundColor = System.Drawing.Color.White
        Me.GrdChartofAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdChartofAccount.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GrdChartofAccount.Location = New System.Drawing.Point(148, 276)
        Me.GrdChartofAccount.Name = "GrdChartofAccount"
        Me.GrdChartofAccount.ReadOnly = True
        Me.GrdChartofAccount.Size = New System.Drawing.Size(403, 13)
        Me.GrdChartofAccount.TabIndex = 2079
        Me.GrdChartofAccount.Visible = False
        '
        'GrdPaidBy
        '
        Me.GrdPaidBy.AllowUserToAddRows = False
        Me.GrdPaidBy.AllowUserToDeleteRows = False
        Me.GrdPaidBy.BackgroundColor = System.Drawing.Color.White
        Me.GrdPaidBy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdPaidBy.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GrdPaidBy.Location = New System.Drawing.Point(148, 307)
        Me.GrdPaidBy.Name = "GrdPaidBy"
        Me.GrdPaidBy.ReadOnly = True
        Me.GrdPaidBy.Size = New System.Drawing.Size(403, 13)
        Me.GrdPaidBy.TabIndex = 2080
        Me.GrdPaidBy.Visible = False
        '
        'FrmLedger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1030, 736)
        Me.Controls.Add(Me.GrdPaidBy)
        Me.Controls.Add(Me.GrdChartofAccount)
        Me.Controls.Add(Me.GrdVoucherName)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TxtLedgerInvoiceNo)
        Me.Controls.Add(Me.LblLedgerInvoiceNo)
        Me.Controls.Add(Me.BtnInvoice)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GrdShowDueBills)
        Me.Controls.Add(Me.BtnTransfer)
        Me.Controls.Add(Me.BtnExpense)
        Me.Controls.Add(Me.BtnPayment)
        Me.Controls.Add(Me.BtnCollection)
        Me.Controls.Add(Me.GrdLedger)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.GrpLedger)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.PnlLedger)
        Me.Controls.Add(Me.DtpLedgerDate)
        Me.Controls.Add(Me.LblLedgerDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmLedger"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Collection/Payment"
        Me.PnlLedger.ResumeLayout(False)
        Me.PnlLedger.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GrpLedger.ResumeLayout(False)
        Me.GrpLedger.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GrdShowDueBills, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdLedger, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdVoucherName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdChartofAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdPaidBy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PnlLedger As System.Windows.Forms.Panel
    Friend WithEvents LbLedger As System.Windows.Forms.Label
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents LblChartOfAccount As System.Windows.Forms.Label
    Friend WithEvents LblRemarks As System.Windows.Forms.Label
    Friend WithEvents TxtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents GrpLedger As System.Windows.Forms.GroupBox
    Friend WithEvents GrdLedger As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DtpLedgerDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblLedgerDate As System.Windows.Forms.Label
    Friend WithEvents TxtAmount As System.Windows.Forms.TextBox
    Friend WithEvents LblAmount As System.Windows.Forms.Label
    Friend WithEvents CmbChartOfAccount As System.Windows.Forms.ComboBox
    Friend WithEvents TxtLedgerNo As System.Windows.Forms.TextBox
    Friend WithEvents LblLedgerNo As System.Windows.Forms.Label
    Friend WithEvents CmbPaidBy As System.Windows.Forms.ComboBox
    Friend WithEvents LblPaidBy As System.Windows.Forms.Label
    Friend WithEvents BtnPayment As System.Windows.Forms.Button
    Friend WithEvents BtnCollection As System.Windows.Forms.Button
    Friend WithEvents TxtCheckNo As System.Windows.Forms.TextBox
    Friend WithEvents LblCheckNo As System.Windows.Forms.Label
    Friend WithEvents BtnTransfer As System.Windows.Forms.Button
    Friend WithEvents BtnExpense As System.Windows.Forms.Button
    Friend WithEvents TxtVoucherNo As System.Windows.Forms.TextBox
    Friend WithEvents LblVoucherNo As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DtpIssueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnInvoice As System.Windows.Forms.Button
    Friend WithEvents LblBalance1 As System.Windows.Forms.Label
    Friend WithEvents LblBalance1Lbl As System.Windows.Forms.Label
    Friend WithEvents LblBalance2Lbl As System.Windows.Forms.Label
    Friend WithEvents LblBalance2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GrdShowDueBills As System.Windows.Forms.DataGridView
    Friend WithEvents TxtLedgerInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents LblLedgerInvoiceNo As System.Windows.Forms.Label
    Friend WithEvents BtnAddItem As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LblVoucherName As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
    Friend WithEvents GrdVoucherName As System.Windows.Forms.DataGridView
    Friend WithEvents GrdChartofAccount As System.Windows.Forms.DataGridView
    Friend WithEvents GrdPaidBy As System.Windows.Forms.DataGridView
    Friend WithEvents CmbVoucherName As System.Windows.Forms.ComboBox
End Class
