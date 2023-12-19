<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RptLedgerDetails
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
        Me.PnlSale = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.Lebal1 = New System.Windows.Forms.Label
        Me.GrdLedgerDetails = New System.Windows.Forms.DataGridView
        Me.CmbChartOfAccount = New System.Windows.Forms.ComboBox
        Me.DtpToDate = New System.Windows.Forms.DateTimePicker
        Me.DtpFromDate = New System.Windows.Forms.DateTimePicker
        Me.BtnShow = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnPrintLedger = New System.Windows.Forms.Button
        Me.LblBalanceLbl = New System.Windows.Forms.Label
        Me.LblBalance = New System.Windows.Forms.Label
        Me.LblPendingCheque = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.LblCheckAmount = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GrdCustomerList = New System.Windows.Forms.DataGridView
        Me.PnlSale.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GrdLedgerDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GrdCustomerList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlSale
        '
        Me.PnlSale.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlSale.Controls.Add(Me.Panel2)
        Me.PnlSale.Controls.Add(Me.Lebal1)
        Me.PnlSale.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlSale.Location = New System.Drawing.Point(0, 0)
        Me.PnlSale.Name = "PnlSale"
        Me.PnlSale.Size = New System.Drawing.Size(1064, 61)
        Me.PnlSale.TabIndex = 114
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
        Me.Panel2.Size = New System.Drawing.Size(1054, 27)
        Me.Panel2.TabIndex = 2062
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(1030, 0)
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
        Me.Btnminimized.Location = New System.Drawing.Point(970, 0)
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
        Me.Btnmaximized.Location = New System.Drawing.Point(1000, 0)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1160
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'Lebal1
        '
        Me.Lebal1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lebal1.AutoSize = True
        Me.Lebal1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lebal1.ForeColor = System.Drawing.Color.White
        Me.Lebal1.Location = New System.Drawing.Point(414, 24)
        Me.Lebal1.Name = "Lebal1"
        Me.Lebal1.Size = New System.Drawing.Size(236, 37)
        Me.Lebal1.TabIndex = 0
        Me.Lebal1.Text = "Ledger Details"
        '
        'GrdLedgerDetails
        '
        Me.GrdLedgerDetails.AllowUserToAddRows = False
        Me.GrdLedgerDetails.AllowUserToDeleteRows = False
        Me.GrdLedgerDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdLedgerDetails.BackgroundColor = System.Drawing.Color.White
        Me.GrdLedgerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdLedgerDetails.Location = New System.Drawing.Point(12, 163)
        Me.GrdLedgerDetails.Name = "GrdLedgerDetails"
        Me.GrdLedgerDetails.ReadOnly = True
        Me.GrdLedgerDetails.Size = New System.Drawing.Size(1042, 540)
        Me.GrdLedgerDetails.TabIndex = 115
        '
        'CmbChartOfAccount
        '
        Me.CmbChartOfAccount.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CmbChartOfAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbChartOfAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbChartOfAccount.FormattingEnabled = True
        Me.CmbChartOfAccount.Location = New System.Drawing.Point(18, 13)
        Me.CmbChartOfAccount.Name = "CmbChartOfAccount"
        Me.CmbChartOfAccount.Size = New System.Drawing.Size(402, 24)
        Me.CmbChartOfAccount.TabIndex = 116
        '
        'DtpToDate
        '
        Me.DtpToDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpToDate.Location = New System.Drawing.Point(141, 63)
        Me.DtpToDate.Name = "DtpToDate"
        Me.DtpToDate.Size = New System.Drawing.Size(109, 20)
        Me.DtpToDate.TabIndex = 119
        Me.DtpToDate.Value = New Date(2018, 2, 25, 0, 0, 0, 0)
        '
        'DtpFromDate
        '
        Me.DtpFromDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFromDate.Location = New System.Drawing.Point(18, 63)
        Me.DtpFromDate.Name = "DtpFromDate"
        Me.DtpFromDate.Size = New System.Drawing.Size(117, 20)
        Me.DtpFromDate.TabIndex = 118
        Me.DtpFromDate.Value = New Date(2017, 1, 1, 0, 0, 0, 0)
        '
        'BtnShow
        '
        Me.BtnShow.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnShow.Location = New System.Drawing.Point(256, 63)
        Me.BtnShow.Name = "BtnShow"
        Me.BtnShow.Size = New System.Drawing.Size(164, 23)
        Me.BtnShow.TabIndex = 117
        Me.BtnShow.Text = "Show"
        Me.BtnShow.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.DtpToDate)
        Me.GroupBox1.Controls.Add(Me.DtpFromDate)
        Me.GroupBox1.Controls.Add(Me.BtnShow)
        Me.GroupBox1.Controls.Add(Me.CmbChartOfAccount)
        Me.GroupBox1.Location = New System.Drawing.Point(316, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(433, 94)
        Me.GroupBox1.TabIndex = 120
        Me.GroupBox1.TabStop = False
        '
        'BtnPrintLedger
        '
        Me.BtnPrintLedger.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrintLedger.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrintLedger.Location = New System.Drawing.Point(12, 127)
        Me.BtnPrintLedger.Name = "BtnPrintLedger"
        Me.BtnPrintLedger.Size = New System.Drawing.Size(139, 30)
        Me.BtnPrintLedger.TabIndex = 120
        Me.BtnPrintLedger.Text = "Print Ledger"
        Me.BtnPrintLedger.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnPrintLedger.UseVisualStyleBackColor = True
        '
        'LblBalanceLbl
        '
        Me.LblBalanceLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblBalanceLbl.AutoSize = True
        Me.LblBalanceLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LblBalanceLbl.Location = New System.Drawing.Point(12, 56)
        Me.LblBalanceLbl.Name = "LblBalanceLbl"
        Me.LblBalanceLbl.Size = New System.Drawing.Size(106, 16)
        Me.LblBalanceLbl.TabIndex = 121
        Me.LblBalanceLbl.Text = "Current Balance:"
        '
        'LblBalance
        '
        Me.LblBalance.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblBalance.AutoSize = True
        Me.LblBalance.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBalance.Location = New System.Drawing.Point(132, 56)
        Me.LblBalance.Name = "LblBalance"
        Me.LblBalance.Size = New System.Drawing.Size(24, 16)
        Me.LblBalance.TabIndex = 122
        Me.LblBalance.Text = "00"
        '
        'LblPendingCheque
        '
        Me.LblPendingCheque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblPendingCheque.AutoSize = True
        Me.LblPendingCheque.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPendingCheque.Location = New System.Drawing.Point(132, 12)
        Me.LblPendingCheque.Name = "LblPendingCheque"
        Me.LblPendingCheque.Size = New System.Drawing.Size(24, 16)
        Me.LblPendingCheque.TabIndex = 124
        Me.LblPendingCheque.Text = "00"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label2.Location = New System.Drawing.Point(12, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 16)
        Me.Label2.TabIndex = 123
        Me.Label2.Text = "Pending Cheque :"
        '
        'LblCheckAmount
        '
        Me.LblCheckAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblCheckAmount.AutoSize = True
        Me.LblCheckAmount.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCheckAmount.Location = New System.Drawing.Point(132, 34)
        Me.LblCheckAmount.Name = "LblCheckAmount"
        Me.LblCheckAmount.Size = New System.Drawing.Size(24, 16)
        Me.LblCheckAmount.TabIndex = 126
        Me.LblCheckAmount.Text = "00"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label4.Location = New System.Drawing.Point(12, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "Check Amount :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.LblCheckAmount)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.LblPendingCheque)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.LblBalance)
        Me.GroupBox2.Controls.Add(Me.LblBalanceLbl)
        Me.GroupBox2.Location = New System.Drawing.Point(797, 61)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(255, 79)
        Me.GroupBox2.TabIndex = 127
        Me.GroupBox2.TabStop = False
        '
        'GrdCustomerList
        '
        Me.GrdCustomerList.AllowUserToAddRows = False
        Me.GrdCustomerList.AllowUserToDeleteRows = False
        Me.GrdCustomerList.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GrdCustomerList.BackgroundColor = System.Drawing.Color.White
        Me.GrdCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdCustomerList.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GrdCustomerList.Location = New System.Drawing.Point(334, 101)
        Me.GrdCustomerList.Name = "GrdCustomerList"
        Me.GrdCustomerList.ReadOnly = True
        Me.GrdCustomerList.Size = New System.Drawing.Size(402, 10)
        Me.GrdCustomerList.TabIndex = 2056
        Me.GrdCustomerList.Visible = False
        '
        'RptLedgerDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1064, 730)
        Me.Controls.Add(Me.GrdCustomerList)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnPrintLedger)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GrdLedgerDetails)
        Me.Controls.Add(Me.PnlSale)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RptLedgerDetails"
        Me.Text = "RptLedgerDetails"
        Me.PnlSale.ResumeLayout(False)
        Me.PnlSale.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.GrdLedgerDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GrdCustomerList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlSale As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
    Friend WithEvents Lebal1 As System.Windows.Forms.Label
    Friend WithEvents GrdLedgerDetails As System.Windows.Forms.DataGridView
    Friend WithEvents CmbChartOfAccount As System.Windows.Forms.ComboBox
    Friend WithEvents DtpToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnShow As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnPrintLedger As System.Windows.Forms.Button
    Friend WithEvents LblBalanceLbl As System.Windows.Forms.Label
    Friend WithEvents LblBalance As System.Windows.Forms.Label
    Friend WithEvents LblPendingCheque As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblCheckAmount As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GrdCustomerList As System.Windows.Forms.DataGridView
End Class
