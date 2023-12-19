<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLedgerHistory
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
        Me.GrdLedgerInvoice = New System.Windows.Forms.DataGridView
        Me.PnlPurchasePaymentHistory = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.LblPurchaseHistory = New System.Windows.Forms.Label
        Me.TxtLedgerInvoiceNo = New System.Windows.Forms.TextBox
        Me.GrdLedger = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.GrpStudentID = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.LblAmount = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.BtnTransfer = New System.Windows.Forms.Button
        Me.BtnExpense = New System.Windows.Forms.Button
        Me.BtnPayment = New System.Windows.Forms.Button
        Me.BtnCollection = New System.Windows.Forms.Button
        Me.CmbVoucherName = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.GrdLedgerInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlPurchasePaymentHistory.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GrdLedger, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpStudentID.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrdLedgerInvoice
        '
        Me.GrdLedgerInvoice.AllowUserToAddRows = False
        Me.GrdLedgerInvoice.AllowUserToDeleteRows = False
        Me.GrdLedgerInvoice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GrdLedgerInvoice.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GrdLedgerInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdLedgerInvoice.Location = New System.Drawing.Point(16, 199)
        Me.GrdLedgerInvoice.Name = "GrdLedgerInvoice"
        Me.GrdLedgerInvoice.ReadOnly = True
        Me.GrdLedgerInvoice.Size = New System.Drawing.Size(475, 531)
        Me.GrdLedgerInvoice.TabIndex = 119
        '
        'PnlPurchasePaymentHistory
        '
        Me.PnlPurchasePaymentHistory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlPurchasePaymentHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlPurchasePaymentHistory.Controls.Add(Me.Panel2)
        Me.PnlPurchasePaymentHistory.Controls.Add(Me.LblPurchaseHistory)
        Me.PnlPurchasePaymentHistory.Location = New System.Drawing.Point(-2, -1)
        Me.PnlPurchasePaymentHistory.Name = "PnlPurchasePaymentHistory"
        Me.PnlPurchasePaymentHistory.Size = New System.Drawing.Size(1035, 88)
        Me.PnlPurchasePaymentHistory.TabIndex = 118
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Btnclose)
        Me.Panel2.Controls.Add(Me.Btnminimized)
        Me.Panel2.Controls.Add(Me.Btnmaximized)
        Me.Panel2.Location = New System.Drawing.Point(3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1029, 27)
        Me.Panel2.TabIndex = 2077
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(1005, 0)
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
        Me.Btnminimized.Location = New System.Drawing.Point(945, 0)
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
        Me.Btnmaximized.Location = New System.Drawing.Point(975, 0)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1160
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'LblPurchaseHistory
        '
        Me.LblPurchaseHistory.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblPurchaseHistory.AutoSize = True
        Me.LblPurchaseHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPurchaseHistory.ForeColor = System.Drawing.Color.White
        Me.LblPurchaseHistory.Location = New System.Drawing.Point(298, 51)
        Me.LblPurchaseHistory.Name = "LblPurchaseHistory"
        Me.LblPurchaseHistory.Size = New System.Drawing.Size(445, 37)
        Me.LblPurchaseHistory.TabIndex = 0
        Me.LblPurchaseHistory.Text = "Collection / Payment History"
        '
        'TxtLedgerInvoiceNo
        '
        Me.TxtLedgerInvoiceNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLedgerInvoiceNo.Location = New System.Drawing.Point(246, 12)
        Me.TxtLedgerInvoiceNo.Name = "TxtLedgerInvoiceNo"
        Me.TxtLedgerInvoiceNo.Size = New System.Drawing.Size(239, 21)
        Me.TxtLedgerInvoiceNo.TabIndex = 120
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
        Me.GrdLedger.Location = New System.Drawing.Point(497, 199)
        Me.GrdLedger.Name = "GrdLedger"
        Me.GrdLedger.ReadOnly = True
        Me.GrdLedger.Size = New System.Drawing.Size(521, 531)
        Me.GrdLedger.TabIndex = 213
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label1.Location = New System.Drawing.Point(15, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 18)
        Me.Label1.TabIndex = 1171
        Me.Label1.Text = "Search Ledger Invoice:"
        '
        'GrpStudentID
        '
        Me.GrpStudentID.Controls.Add(Me.Label1)
        Me.GrpStudentID.Controls.Add(Me.Button3)
        Me.GrpStudentID.Controls.Add(Me.TxtLedgerInvoiceNo)
        Me.GrpStudentID.Controls.Add(Me.Button5)
        Me.GrpStudentID.Controls.Add(Me.Button6)
        Me.GrpStudentID.Controls.Add(Me.Button7)
        Me.GrpStudentID.Location = New System.Drawing.Point(10, 98)
        Me.GrpStudentID.Name = "GrpStudentID"
        Me.GrpStudentID.Size = New System.Drawing.Size(490, 75)
        Me.GrpStudentID.TabIndex = 1175
        Me.GrpStudentID.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(367, 43)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(119, 26)
        Me.Button3.TabIndex = 2044
        Me.Button3.Text = "All Incompleted"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(125, 43)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(119, 26)
        Me.Button5.TabIndex = 2043
        Me.Button5.Text = "All Completed"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(4, 43)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(119, 26)
        Me.Button6.TabIndex = 2042
        Me.Button6.Text = "Completed Today"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(246, 43)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(119, 26)
        Me.Button7.TabIndex = 2041
        Me.Button7.Text = "User Incompleted"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button7.UseVisualStyleBackColor = True
        '
        'LblAmount
        '
        Me.LblAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblAmount.AutoSize = True
        Me.LblAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblAmount.Location = New System.Drawing.Point(935, 176)
        Me.LblAmount.Name = "LblAmount"
        Me.LblAmount.Size = New System.Drawing.Size(29, 20)
        Me.LblAmount.TabIndex = 1179
        Me.LblAmount.Text = "00"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(771, 176)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 20)
        Me.Label9.TabIndex = 1178
        Me.Label9.Text = "Amount:"
        '
        'BtnTransfer
        '
        Me.BtnTransfer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTransfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTransfer.ForeColor = System.Drawing.Color.Black
        Me.BtnTransfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTransfer.Location = New System.Drawing.Point(369, 38)
        Me.BtnTransfer.Name = "BtnTransfer"
        Me.BtnTransfer.Size = New System.Drawing.Size(97, 26)
        Me.BtnTransfer.TabIndex = 2062
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
        Me.BtnExpense.Location = New System.Drawing.Point(268, 38)
        Me.BtnExpense.Name = "BtnExpense"
        Me.BtnExpense.Size = New System.Drawing.Size(97, 26)
        Me.BtnExpense.TabIndex = 2063
        Me.BtnExpense.Text = "Expense"
        Me.BtnExpense.UseVisualStyleBackColor = True
        '
        'BtnPayment
        '
        Me.BtnPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPayment.ForeColor = System.Drawing.Color.Black
        Me.BtnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPayment.Location = New System.Drawing.Point(167, 38)
        Me.BtnPayment.Name = "BtnPayment"
        Me.BtnPayment.Size = New System.Drawing.Size(97, 26)
        Me.BtnPayment.TabIndex = 2060
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
        Me.BtnCollection.Location = New System.Drawing.Point(66, 38)
        Me.BtnCollection.Name = "BtnCollection"
        Me.BtnCollection.Size = New System.Drawing.Size(97, 26)
        Me.BtnCollection.TabIndex = 2061
        Me.BtnCollection.Text = "Collection"
        Me.BtnCollection.UseVisualStyleBackColor = True
        '
        'CmbVoucherName
        '
        Me.CmbVoucherName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbVoucherName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbVoucherName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbVoucherName.FormattingEnabled = True
        Me.CmbVoucherName.Items.AddRange(New Object() {"Search All Ledger", "Search Ledger Today"})
        Me.CmbVoucherName.Location = New System.Drawing.Point(65, 11)
        Me.CmbVoucherName.Name = "CmbVoucherName"
        Me.CmbVoucherName.Size = New System.Drawing.Size(402, 23)
        Me.CmbVoucherName.TabIndex = 2064
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CmbVoucherName)
        Me.GroupBox1.Controls.Add(Me.BtnTransfer)
        Me.GroupBox1.Controls.Add(Me.BtnExpense)
        Me.GroupBox1.Controls.Add(Me.BtnPayment)
        Me.GroupBox1.Controls.Add(Me.BtnCollection)
        Me.GroupBox1.Location = New System.Drawing.Point(506, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(512, 75)
        Me.GroupBox1.TabIndex = 2065
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label2.Location = New System.Drawing.Point(6, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 18)
        Me.Label2.TabIndex = 2045
        Me.Label2.Text = "Select:"
        '
        'FrmLedgerHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1030, 736)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblAmount)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GrpStudentID)
        Me.Controls.Add(Me.GrdLedger)
        Me.Controls.Add(Me.GrdLedgerInvoice)
        Me.Controls.Add(Me.PnlPurchasePaymentHistory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmLedgerHistory"
        Me.Text = "Collection / Payment History"
        CType(Me.GrdLedgerInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlPurchasePaymentHistory.ResumeLayout(False)
        Me.PnlPurchasePaymentHistory.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.GrdLedger, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpStudentID.ResumeLayout(False)
        Me.GrpStudentID.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrdLedgerInvoice As System.Windows.Forms.DataGridView
    Friend WithEvents PnlPurchasePaymentHistory As System.Windows.Forms.Panel
    Friend WithEvents LblPurchaseHistory As System.Windows.Forms.Label
    Friend WithEvents TxtLedgerInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents GrdLedger As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GrpStudentID As System.Windows.Forms.GroupBox
    Friend WithEvents LblAmount As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents BtnTransfer As System.Windows.Forms.Button
    Friend WithEvents BtnExpense As System.Windows.Forms.Button
    Friend WithEvents BtnPayment As System.Windows.Forms.Button
    Friend WithEvents BtnCollection As System.Windows.Forms.Button
    Friend WithEvents CmbVoucherName As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
End Class
