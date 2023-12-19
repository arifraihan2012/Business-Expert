<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBankTransaction
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
        Me.PnlBankID = New System.Windows.Forms.Panel
        Me.LblBankTransaction = New System.Windows.Forms.Label
        Me.GrdBankTransaction = New System.Windows.Forms.DataGridView
        Me.CmbSearch = New System.Windows.Forms.ComboBox
        Me.TxtSearch = New System.Windows.Forms.TextBox
        Me.GrpBankTransaction = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtCreditedAmount = New System.Windows.Forms.TextBox
        Me.LblCreditedAmount = New System.Windows.Forms.Label
        Me.TxtDebitedAmount = New System.Windows.Forms.TextBox
        Me.LblDebitedAmount = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.CmbBankID = New System.Windows.Forms.ComboBox
        Me.LblBankID = New System.Windows.Forms.Label
        Me.DtpTransactionDate = New System.Windows.Forms.DateTimePicker
        Me.TxtCheckNo = New System.Windows.Forms.TextBox
        Me.TxtRemarks = New System.Windows.Forms.TextBox
        Me.LblRemarks = New System.Windows.Forms.Label
        Me.LblCheckNo = New System.Windows.Forms.Label
        Me.TxtBankTransactionID = New System.Windows.Forms.TextBox
        Me.LblTransactionDate = New System.Windows.Forms.Label
        Me.LblBankTransactionID = New System.Windows.Forms.Label
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.BtnRefresh = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.BtnDebitVoucher = New System.Windows.Forms.Button
        Me.BtnCreditVoucher = New System.Windows.Forms.Button
        Me.CmbSearchBankName = New System.Windows.Forms.ComboBox
        Me.PnlBankID.SuspendLayout()
        CType(Me.GrdBankTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBankTransaction.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlBankID
        '
        Me.PnlBankID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlBankID.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PnlBankID.Controls.Add(Me.LblBankTransaction)
        Me.PnlBankID.Location = New System.Drawing.Point(-2, 0)
        Me.PnlBankID.Name = "PnlBankID"
        Me.PnlBankID.Size = New System.Drawing.Size(1017, 98)
        Me.PnlBankID.TabIndex = 5
        '
        'LblBankTransaction
        '
        Me.LblBankTransaction.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblBankTransaction.AutoSize = True
        Me.LblBankTransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBankTransaction.ForeColor = System.Drawing.Color.White
        Me.LblBankTransaction.Location = New System.Drawing.Point(366, 31)
        Me.LblBankTransaction.Name = "LblBankTransaction"
        Me.LblBankTransaction.Size = New System.Drawing.Size(284, 37)
        Me.LblBankTransaction.TabIndex = 0
        Me.LblBankTransaction.Text = "Bank Transaction"
        '
        'GrdBankTransaction
        '
        Me.GrdBankTransaction.AllowUserToAddRows = False
        Me.GrdBankTransaction.AllowUserToDeleteRows = False
        Me.GrdBankTransaction.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdBankTransaction.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GrdBankTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdBankTransaction.Location = New System.Drawing.Point(12, 439)
        Me.GrdBankTransaction.Name = "GrdBankTransaction"
        Me.GrdBankTransaction.ReadOnly = True
        Me.GrdBankTransaction.Size = New System.Drawing.Size(992, 294)
        Me.GrdBankTransaction.TabIndex = 21
        '
        'CmbSearch
        '
        Me.CmbSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbSearch.FormattingEnabled = True
        Me.CmbSearch.Items.AddRange(New Object() {"BANK ID", "CHECK NO"})
        Me.CmbSearch.Location = New System.Drawing.Point(620, 104)
        Me.CmbSearch.Name = "CmbSearch"
        Me.CmbSearch.Size = New System.Drawing.Size(134, 21)
        Me.CmbSearch.TabIndex = 116
        '
        'TxtSearch
        '
        Me.TxtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSearch.Location = New System.Drawing.Point(771, 104)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(172, 20)
        Me.TxtSearch.TabIndex = 117
        '
        'GrpBankTransaction
        '
        Me.GrpBankTransaction.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpBankTransaction.Controls.Add(Me.Label1)
        Me.GrpBankTransaction.Controls.Add(Me.Label2)
        Me.GrpBankTransaction.Controls.Add(Me.TxtCreditedAmount)
        Me.GrpBankTransaction.Controls.Add(Me.LblCreditedAmount)
        Me.GrpBankTransaction.Controls.Add(Me.TxtDebitedAmount)
        Me.GrpBankTransaction.Controls.Add(Me.LblDebitedAmount)
        Me.GrpBankTransaction.Controls.Add(Me.Label6)
        Me.GrpBankTransaction.Controls.Add(Me.CmbBankID)
        Me.GrpBankTransaction.Controls.Add(Me.LblBankID)
        Me.GrpBankTransaction.Controls.Add(Me.DtpTransactionDate)
        Me.GrpBankTransaction.Controls.Add(Me.TxtCheckNo)
        Me.GrpBankTransaction.Controls.Add(Me.TxtRemarks)
        Me.GrpBankTransaction.Controls.Add(Me.LblRemarks)
        Me.GrpBankTransaction.Controls.Add(Me.LblCheckNo)
        Me.GrpBankTransaction.Controls.Add(Me.TxtBankTransactionID)
        Me.GrpBankTransaction.Controls.Add(Me.LblTransactionDate)
        Me.GrpBankTransaction.Controls.Add(Me.LblBankTransactionID)
        Me.GrpBankTransaction.Location = New System.Drawing.Point(12, 179)
        Me.GrpBankTransaction.Name = "GrpBankTransaction"
        Me.GrpBankTransaction.Size = New System.Drawing.Size(990, 254)
        Me.GrpBankTransaction.TabIndex = 116
        Me.GrpBankTransaction.TabStop = False
        Me.GrpBankTransaction.Text = "BankTransaction"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(290, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 15)
        Me.Label1.TabIndex = 2037
        Me.Label1.Text = "[Payment]"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(290, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 15)
        Me.Label2.TabIndex = 2036
        Me.Label2.Text = "[Withdraw]"
        '
        'TxtCreditedAmount
        '
        Me.TxtCreditedAmount.Enabled = False
        Me.TxtCreditedAmount.Location = New System.Drawing.Point(151, 115)
        Me.TxtCreditedAmount.Name = "TxtCreditedAmount"
        Me.TxtCreditedAmount.Size = New System.Drawing.Size(133, 20)
        Me.TxtCreditedAmount.TabIndex = 2033
        '
        'LblCreditedAmount
        '
        Me.LblCreditedAmount.AutoSize = True
        Me.LblCreditedAmount.Location = New System.Drawing.Point(32, 114)
        Me.LblCreditedAmount.Name = "LblCreditedAmount"
        Me.LblCreditedAmount.Size = New System.Drawing.Size(88, 13)
        Me.LblCreditedAmount.TabIndex = 2035
        Me.LblCreditedAmount.Text = "Credited Amount:"
        '
        'TxtDebitedAmount
        '
        Me.TxtDebitedAmount.Enabled = False
        Me.TxtDebitedAmount.Location = New System.Drawing.Point(151, 86)
        Me.TxtDebitedAmount.Name = "TxtDebitedAmount"
        Me.TxtDebitedAmount.Size = New System.Drawing.Size(133, 20)
        Me.TxtDebitedAmount.TabIndex = 2032
        '
        'LblDebitedAmount
        '
        Me.LblDebitedAmount.AutoSize = True
        Me.LblDebitedAmount.Location = New System.Drawing.Point(32, 86)
        Me.LblDebitedAmount.Name = "LblDebitedAmount"
        Me.LblDebitedAmount.Size = New System.Drawing.Size(86, 13)
        Me.LblDebitedAmount.TabIndex = 2034
        Me.LblDebitedAmount.Text = "Debited Amount:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(90, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 24)
        Me.Label6.TabIndex = 2031
        Me.Label6.Text = "*"
        '
        'CmbBankID
        '
        Me.CmbBankID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbBankID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.CmbBankID.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbBankID.Location = New System.Drawing.Point(151, 56)
        Me.CmbBankID.Name = "CmbBankID"
        Me.CmbBankID.Size = New System.Drawing.Size(133, 21)
        Me.CmbBankID.TabIndex = 104
        '
        'LblBankID
        '
        Me.LblBankID.AutoSize = True
        Me.LblBankID.Location = New System.Drawing.Point(32, 58)
        Me.LblBankID.Name = "LblBankID"
        Me.LblBankID.Size = New System.Drawing.Size(52, 13)
        Me.LblBankID.TabIndex = 2030
        Me.LblBankID.Text = "Bank  ID:"
        '
        'DtpTransactionDate
        '
        Me.DtpTransactionDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpTransactionDate.Location = New System.Drawing.Point(498, 24)
        Me.DtpTransactionDate.Name = "DtpTransactionDate"
        Me.DtpTransactionDate.Size = New System.Drawing.Size(101, 20)
        Me.DtpTransactionDate.TabIndex = 107
        Me.DtpTransactionDate.Value = New Date(2017, 10, 25, 0, 0, 0, 0)
        '
        'TxtCheckNo
        '
        Me.TxtCheckNo.Location = New System.Drawing.Point(151, 144)
        Me.TxtCheckNo.Name = "TxtCheckNo"
        Me.TxtCheckNo.Size = New System.Drawing.Size(205, 20)
        Me.TxtCheckNo.TabIndex = 105
        '
        'TxtRemarks
        '
        Me.TxtRemarks.Location = New System.Drawing.Point(151, 173)
        Me.TxtRemarks.Multiline = True
        Me.TxtRemarks.Name = "TxtRemarks"
        Me.TxtRemarks.Size = New System.Drawing.Size(205, 66)
        Me.TxtRemarks.TabIndex = 106
        '
        'LblRemarks
        '
        Me.LblRemarks.AutoSize = True
        Me.LblRemarks.Location = New System.Drawing.Point(32, 170)
        Me.LblRemarks.Name = "LblRemarks"
        Me.LblRemarks.Size = New System.Drawing.Size(52, 13)
        Me.LblRemarks.TabIndex = 15
        Me.LblRemarks.Text = "Remarks:"
        '
        'LblCheckNo
        '
        Me.LblCheckNo.AutoSize = True
        Me.LblCheckNo.Location = New System.Drawing.Point(32, 142)
        Me.LblCheckNo.Name = "LblCheckNo"
        Me.LblCheckNo.Size = New System.Drawing.Size(58, 13)
        Me.LblCheckNo.TabIndex = 13
        Me.LblCheckNo.Text = "Check No:"
        '
        'TxtBankTransactionID
        '
        Me.TxtBankTransactionID.Enabled = False
        Me.TxtBankTransactionID.Location = New System.Drawing.Point(151, 27)
        Me.TxtBankTransactionID.Name = "TxtBankTransactionID"
        Me.TxtBankTransactionID.Size = New System.Drawing.Size(79, 20)
        Me.TxtBankTransactionID.TabIndex = 101
        '
        'LblTransactionDate
        '
        Me.LblTransactionDate.AutoSize = True
        Me.LblTransactionDate.Location = New System.Drawing.Point(388, 27)
        Me.LblTransactionDate.Name = "LblTransactionDate"
        Me.LblTransactionDate.Size = New System.Drawing.Size(92, 13)
        Me.LblTransactionDate.TabIndex = 7
        Me.LblTransactionDate.Text = "Transaction Date:"
        '
        'LblBankTransactionID
        '
        Me.LblBankTransactionID.AutoSize = True
        Me.LblBankTransactionID.Location = New System.Drawing.Point(32, 30)
        Me.LblBankTransactionID.Name = "LblBankTransactionID"
        Me.LblBankTransactionID.Size = New System.Drawing.Size(108, 13)
        Me.LblBankTransactionID.TabIndex = 6
        Me.LblBankTransactionID.Text = "Bank Transaction ID:"
        '
        'BtnSearch
        '
        Me.BtnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Image = Global.Business_Expert_Pro.My.Resources.Resources.Button_15_1282
        Me.BtnSearch.Location = New System.Drawing.Point(981, 104)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(19, 19)
        Me.BtnSearch.TabIndex = 118
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'BtnRefresh
        '
        Me.BtnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefresh.Image = Global.Business_Expert_Pro.My.Resources.Resources.icon_ios7_refresh_empty_128__1_
        Me.BtnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRefresh.Location = New System.Drawing.Point(437, 131)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(84, 39)
        Me.BtnRefresh.TabIndex = 115
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Image = Global.Business_Expert_Pro.My.Resources.Resources.Delete21
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(347, 131)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(84, 39)
        Me.BtnDelete.TabIndex = 114
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Image = Global.Business_Expert_Pro.My.Resources.Resources.Save1
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(544, 131)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(84, 39)
        Me.BtnSave.TabIndex = 111
        Me.BtnSave.Text = "Save"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Image = Global.Business_Expert_Pro.My.Resources.Resources.Edit1
        Me.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUpdate.Location = New System.Drawing.Point(257, 131)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(84, 39)
        Me.BtnUpdate.TabIndex = 113
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDebitVoucher
        '
        Me.BtnDebitVoucher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnDebitVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDebitVoucher.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnDebitVoucher.ForeColor = System.Drawing.Color.Red
        Me.BtnDebitVoucher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDebitVoucher.Location = New System.Drawing.Point(125, 131)
        Me.BtnDebitVoucher.Name = "BtnDebitVoucher"
        Me.BtnDebitVoucher.Size = New System.Drawing.Size(94, 42)
        Me.BtnDebitVoucher.TabIndex = 344
        Me.BtnDebitVoucher.Text = "WITHDRAW"
        Me.BtnDebitVoucher.UseVisualStyleBackColor = True
        '
        'BtnCreditVoucher
        '
        Me.BtnCreditVoucher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCreditVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCreditVoucher.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnCreditVoucher.ForeColor = System.Drawing.Color.Blue
        Me.BtnCreditVoucher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCreditVoucher.Location = New System.Drawing.Point(12, 131)
        Me.BtnCreditVoucher.Name = "BtnCreditVoucher"
        Me.BtnCreditVoucher.Size = New System.Drawing.Size(94, 42)
        Me.BtnCreditVoucher.TabIndex = 343
        Me.BtnCreditVoucher.Text = "PAYMENT"
        Me.BtnCreditVoucher.UseVisualStyleBackColor = True
        '
        'CmbSearchBankName
        '
        Me.CmbSearchBankName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbSearchBankName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbSearchBankName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.CmbSearchBankName.FormattingEnabled = True
        Me.CmbSearchBankName.Location = New System.Drawing.Point(771, 104)
        Me.CmbSearchBankName.Name = "CmbSearchBankName"
        Me.CmbSearchBankName.Size = New System.Drawing.Size(178, 21)
        Me.CmbSearchBankName.TabIndex = 345
        Me.CmbSearchBankName.Visible = False
        '
        'FrmBankTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1014, 736)
        Me.Controls.Add(Me.CmbSearchBankName)
        Me.Controls.Add(Me.BtnDebitVoucher)
        Me.Controls.Add(Me.BtnCreditVoucher)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.GrpBankTransaction)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.CmbSearch)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.GrdBankTransaction)
        Me.Controls.Add(Me.PnlBankID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmBankTransaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bank Transaction"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PnlBankID.ResumeLayout(False)
        Me.PnlBankID.PerformLayout()
        CType(Me.GrdBankTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBankTransaction.ResumeLayout(False)
        Me.GrpBankTransaction.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PnlBankID As System.Windows.Forms.Panel
    Friend WithEvents LblBankTransaction As System.Windows.Forms.Label
    Friend WithEvents GrdBankTransaction As System.Windows.Forms.DataGridView
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents CmbSearch As System.Windows.Forms.ComboBox
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button
    Friend WithEvents GrpBankTransaction As System.Windows.Forms.GroupBox
    Friend WithEvents DtpTransactionDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtCheckNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents LblRemarks As System.Windows.Forms.Label
    Friend WithEvents LblCheckNo As System.Windows.Forms.Label
    Friend WithEvents TxtBankTransactionID As System.Windows.Forms.TextBox
    Friend WithEvents LblTransactionDate As System.Windows.Forms.Label
    Friend WithEvents LblBankTransactionID As System.Windows.Forms.Label
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents BtnDebitVoucher As System.Windows.Forms.Button
    Friend WithEvents BtnCreditVoucher As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CmbBankID As System.Windows.Forms.ComboBox
    Friend WithEvents LblBankID As System.Windows.Forms.Label
    Friend WithEvents CmbSearchBankName As System.Windows.Forms.ComboBox
    Friend WithEvents TxtCreditedAmount As System.Windows.Forms.TextBox
    Friend WithEvents LblCreditedAmount As System.Windows.Forms.Label
    Friend WithEvents TxtDebitedAmount As System.Windows.Forms.TextBox
    Friend WithEvents LblDebitedAmount As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
