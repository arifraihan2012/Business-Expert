<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProductTransferHistory
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
        Me.GrdSaleInvoice = New System.Windows.Forms.DataGridView
        Me.PnlStudentPaymentHistory = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.LblProductTransferHistory = New System.Windows.Forms.Label
        Me.TxtSearchInvoice = New System.Windows.Forms.TextBox
        Me.GrdSale = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.GrpStudentID = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.GrdSaleInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlStudentPaymentHistory.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GrdSale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpStudentID.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrdSaleInvoice
        '
        Me.GrdSaleInvoice.AllowUserToAddRows = False
        Me.GrdSaleInvoice.AllowUserToDeleteRows = False
        Me.GrdSaleInvoice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GrdSaleInvoice.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GrdSaleInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdSaleInvoice.Location = New System.Drawing.Point(16, 227)
        Me.GrdSaleInvoice.Name = "GrdSaleInvoice"
        Me.GrdSaleInvoice.ReadOnly = True
        Me.GrdSaleInvoice.Size = New System.Drawing.Size(475, 503)
        Me.GrdSaleInvoice.TabIndex = 119
        '
        'PnlStudentPaymentHistory
        '
        Me.PnlStudentPaymentHistory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlStudentPaymentHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlStudentPaymentHistory.Controls.Add(Me.Panel2)
        Me.PnlStudentPaymentHistory.Controls.Add(Me.LblProductTransferHistory)
        Me.PnlStudentPaymentHistory.Location = New System.Drawing.Point(-2, -1)
        Me.PnlStudentPaymentHistory.Name = "PnlStudentPaymentHistory"
        Me.PnlStudentPaymentHistory.Size = New System.Drawing.Size(1035, 88)
        Me.PnlStudentPaymentHistory.TabIndex = 118
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Btnclose)
        Me.Panel2.Controls.Add(Me.Btnminimized)
        Me.Panel2.Controls.Add(Me.Btnmaximized)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1029, 27)
        Me.Panel2.TabIndex = 2079
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
        'LblProductTransferHistory
        '
        Me.LblProductTransferHistory.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblProductTransferHistory.AutoSize = True
        Me.LblProductTransferHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProductTransferHistory.ForeColor = System.Drawing.Color.White
        Me.LblProductTransferHistory.Location = New System.Drawing.Point(323, 51)
        Me.LblProductTransferHistory.Name = "LblProductTransferHistory"
        Me.LblProductTransferHistory.Size = New System.Drawing.Size(389, 37)
        Me.LblProductTransferHistory.TabIndex = 0
        Me.LblProductTransferHistory.Text = "Product Transfer History"
        '
        'TxtSearchInvoice
        '
        Me.TxtSearchInvoice.Location = New System.Drawing.Point(190, 19)
        Me.TxtSearchInvoice.Name = "TxtSearchInvoice"
        Me.TxtSearchInvoice.Size = New System.Drawing.Size(243, 20)
        Me.TxtSearchInvoice.TabIndex = 120
        '
        'GrdSale
        '
        Me.GrdSale.AllowUserToAddRows = False
        Me.GrdSale.AllowUserToDeleteRows = False
        Me.GrdSale.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdSale.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GrdSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdSale.Location = New System.Drawing.Point(497, 227)
        Me.GrdSale.Name = "GrdSale"
        Me.GrdSale.ReadOnly = True
        Me.GrdSale.Size = New System.Drawing.Size(521, 503)
        Me.GrdSale.TabIndex = 213
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label1.Location = New System.Drawing.Point(15, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 20)
        Me.Label1.TabIndex = 1171
        Me.Label1.Text = "Search Invoice:"
        '
        'GrpStudentID
        '
        Me.GrpStudentID.Controls.Add(Me.Label1)
        Me.GrpStudentID.Controls.Add(Me.TxtSearchInvoice)
        Me.GrpStudentID.Location = New System.Drawing.Point(27, 93)
        Me.GrpStudentID.Name = "GrpStudentID"
        Me.GrpStudentID.Size = New System.Drawing.Size(439, 72)
        Me.GrpStudentID.TabIndex = 1175
        Me.GrpStudentID.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(377, 195)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(114, 26)
        Me.Button3.TabIndex = 2040
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
        Me.Button5.Location = New System.Drawing.Point(137, 195)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(114, 26)
        Me.Button5.TabIndex = 2039
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
        Me.Button6.Location = New System.Drawing.Point(17, 195)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(114, 26)
        Me.Button6.TabIndex = 2038
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
        Me.Button7.Location = New System.Drawing.Point(257, 195)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(114, 26)
        Me.Button7.TabIndex = 2037
        Me.Button7.Text = "User Incompleted"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(497, 195)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 26)
        Me.Button1.TabIndex = 2041
        Me.Button1.Text = "Pending Invoice"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmProductTransferHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1030, 736)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.GrpStudentID)
        Me.Controls.Add(Me.GrdSale)
        Me.Controls.Add(Me.GrdSaleInvoice)
        Me.Controls.Add(Me.PnlStudentPaymentHistory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmProductTransferHistory"
        Me.Text = "Product Transfer History"
        CType(Me.GrdSaleInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlStudentPaymentHistory.ResumeLayout(False)
        Me.PnlStudentPaymentHistory.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.GrdSale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpStudentID.ResumeLayout(False)
        Me.GrpStudentID.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrdSaleInvoice As System.Windows.Forms.DataGridView
    Friend WithEvents PnlStudentPaymentHistory As System.Windows.Forms.Panel
    Friend WithEvents LblProductTransferHistory As System.Windows.Forms.Label
    Friend WithEvents TxtSearchInvoice As System.Windows.Forms.TextBox
    Friend WithEvents GrdSale As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GrpStudentID As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
