<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPurchaseHistory
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
        Me.PnlPurchasePaymentHistory = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.LblPurchaseHistory = New System.Windows.Forms.Label
        Me.TxtSearchPurchaseInvoice = New System.Windows.Forms.TextBox
        Me.label65 = New System.Windows.Forms.Label
        Me.LblSupplierName = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GrpStudentID = New System.Windows.Forms.GroupBox
        Me.LblAmount = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.LblSupplierID = New System.Windows.Forms.Label
        Me.lbl89 = New System.Windows.Forms.Label
        Me.LblMobileNo = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GrpSupplierDetails = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.GrdPurchaseInvoice = New System.Windows.Forms.DataGridView
        Me.GrdPurchase = New System.Windows.Forms.DataGridView
        Me.ProductPictureBox = New System.Windows.Forms.PictureBox
        Me.PnlPurchasePaymentHistory.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GrpStudentID.SuspendLayout()
        Me.GrpSupplierDetails.SuspendLayout()
        CType(Me.GrdPurchaseInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdPurchase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlPurchasePaymentHistory
        '
        Me.PnlPurchasePaymentHistory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlPurchasePaymentHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlPurchasePaymentHistory.Controls.Add(Me.Panel1)
        Me.PnlPurchasePaymentHistory.Controls.Add(Me.LblPurchaseHistory)
        Me.PnlPurchasePaymentHistory.Location = New System.Drawing.Point(-2, -1)
        Me.PnlPurchasePaymentHistory.Name = "PnlPurchasePaymentHistory"
        Me.PnlPurchasePaymentHistory.Size = New System.Drawing.Size(1035, 88)
        Me.PnlPurchasePaymentHistory.TabIndex = 118
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Btnclose)
        Me.Panel1.Controls.Add(Me.Btnminimized)
        Me.Panel1.Controls.Add(Me.Btnmaximized)
        Me.Panel1.Location = New System.Drawing.Point(-1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1033, 28)
        Me.Panel1.TabIndex = 2052
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(1009, 2)
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
        Me.Btnminimized.Location = New System.Drawing.Point(949, 2)
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
        Me.Btnmaximized.Location = New System.Drawing.Point(979, 2)
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
        Me.LblPurchaseHistory.Location = New System.Drawing.Point(417, 36)
        Me.LblPurchaseHistory.Name = "LblPurchaseHistory"
        Me.LblPurchaseHistory.Size = New System.Drawing.Size(276, 37)
        Me.LblPurchaseHistory.TabIndex = 0
        Me.LblPurchaseHistory.Text = "Purchase History"
        '
        'TxtSearchPurchaseInvoice
        '
        Me.TxtSearchPurchaseInvoice.Location = New System.Drawing.Point(213, 19)
        Me.TxtSearchPurchaseInvoice.Name = "TxtSearchPurchaseInvoice"
        Me.TxtSearchPurchaseInvoice.Size = New System.Drawing.Size(243, 20)
        Me.TxtSearchPurchaseInvoice.TabIndex = 120
        '
        'label65
        '
        Me.label65.AutoSize = True
        Me.label65.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.label65.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label65.Location = New System.Drawing.Point(15, 42)
        Me.label65.Name = "label65"
        Me.label65.Size = New System.Drawing.Size(146, 18)
        Me.label65.TabIndex = 1172
        Me.label65.Text = "CUSTOMER NAME:"
        '
        'LblSupplierName
        '
        Me.LblSupplierName.AutoSize = True
        Me.LblSupplierName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.LblSupplierName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblSupplierName.Location = New System.Drawing.Point(226, 45)
        Me.LblSupplierName.Name = "LblSupplierName"
        Me.LblSupplierName.Size = New System.Drawing.Size(0, 18)
        Me.LblSupplierName.TabIndex = 1171
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label1.Location = New System.Drawing.Point(15, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 18)
        Me.Label1.TabIndex = 1171
        Me.Label1.Text = "Search Purchase Invoice:"
        '
        'GrpStudentID
        '
        Me.GrpStudentID.Controls.Add(Me.label65)
        Me.GrpStudentID.Controls.Add(Me.LblSupplierName)
        Me.GrpStudentID.Controls.Add(Me.Label1)
        Me.GrpStudentID.Controls.Add(Me.TxtSearchPurchaseInvoice)
        Me.GrpStudentID.Location = New System.Drawing.Point(27, 93)
        Me.GrpStudentID.Name = "GrpStudentID"
        Me.GrpStudentID.Size = New System.Drawing.Size(462, 72)
        Me.GrpStudentID.TabIndex = 1175
        Me.GrpStudentID.TabStop = False
        '
        'LblAmount
        '
        Me.LblAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblAmount.AutoSize = True
        Me.LblAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblAmount.Location = New System.Drawing.Point(911, 202)
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
        Me.Label9.Location = New System.Drawing.Point(753, 202)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 20)
        Me.Label9.TabIndex = 1178
        Me.Label9.Text = "Amount:"
        '
        'LblSupplierID
        '
        Me.LblSupplierID.AutoSize = True
        Me.LblSupplierID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSupplierID.Location = New System.Drawing.Point(200, 22)
        Me.LblSupplierID.Name = "LblSupplierID"
        Me.LblSupplierID.Size = New System.Drawing.Size(0, 18)
        Me.LblSupplierID.TabIndex = 1169
        '
        'lbl89
        '
        Me.lbl89.AutoSize = True
        Me.lbl89.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl89.Location = New System.Drawing.Point(43, 42)
        Me.lbl89.Name = "lbl89"
        Me.lbl89.Size = New System.Drawing.Size(95, 18)
        Me.lbl89.TabIndex = 1167
        Me.lbl89.Text = "MOBILE NO:"
        '
        'LblMobileNo
        '
        Me.LblMobileNo.AutoSize = True
        Me.LblMobileNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMobileNo.Location = New System.Drawing.Point(200, 52)
        Me.LblMobileNo.Name = "LblMobileNo"
        Me.LblMobileNo.Size = New System.Drawing.Size(0, 18)
        Me.LblMobileNo.TabIndex = 1168
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 18)
        Me.Label3.TabIndex = 1170
        Me.Label3.Text = "CUSTOMER ID:"
        '
        'GrpSupplierDetails
        '
        Me.GrpSupplierDetails.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpSupplierDetails.Controls.Add(Me.Label3)
        Me.GrpSupplierDetails.Controls.Add(Me.LblMobileNo)
        Me.GrpSupplierDetails.Controls.Add(Me.lbl89)
        Me.GrpSupplierDetails.Controls.Add(Me.LblSupplierID)
        Me.GrpSupplierDetails.Location = New System.Drawing.Point(652, 103)
        Me.GrpSupplierDetails.Name = "GrpSupplierDetails"
        Me.GrpSupplierDetails.Size = New System.Drawing.Size(366, 96)
        Me.GrpSupplierDetails.TabIndex = 1172
        Me.GrpSupplierDetails.TabStop = False
        Me.GrpSupplierDetails.Text = "Customer Detials"
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
        Me.Button5.Location = New System.Drawing.Point(137, 195)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(114, 26)
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
        Me.Button6.Location = New System.Drawing.Point(17, 195)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(114, 26)
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
        Me.Button7.Location = New System.Drawing.Point(257, 195)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(114, 26)
        Me.Button7.TabIndex = 2041
        Me.Button7.Text = "User Incompleted"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button7.UseVisualStyleBackColor = True
        '
        'GrdPurchaseInvoice
        '
        Me.GrdPurchaseInvoice.AllowUserToAddRows = False
        Me.GrdPurchaseInvoice.AllowUserToDeleteRows = False
        Me.GrdPurchaseInvoice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GrdPurchaseInvoice.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdPurchaseInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdPurchaseInvoice.Location = New System.Drawing.Point(12, 227)
        Me.GrdPurchaseInvoice.Name = "GrdPurchaseInvoice"
        Me.GrdPurchaseInvoice.ReadOnly = True
        Me.GrdPurchaseInvoice.Size = New System.Drawing.Size(479, 503)
        Me.GrdPurchaseInvoice.TabIndex = 2045
        '
        'GrdPurchase
        '
        Me.GrdPurchase.AllowUserToAddRows = False
        Me.GrdPurchase.AllowUserToDeleteRows = False
        Me.GrdPurchase.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdPurchase.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdPurchase.Location = New System.Drawing.Point(497, 227)
        Me.GrdPurchase.Name = "GrdPurchase"
        Me.GrdPurchase.ReadOnly = True
        Me.GrdPurchase.Size = New System.Drawing.Size(521, 503)
        Me.GrdPurchase.TabIndex = 2046
        '
        'ProductPictureBox
        '
        Me.ProductPictureBox.Location = New System.Drawing.Point(511, 109)
        Me.ProductPictureBox.Name = "ProductPictureBox"
        Me.ProductPictureBox.Size = New System.Drawing.Size(135, 111)
        Me.ProductPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProductPictureBox.TabIndex = 2047
        Me.ProductPictureBox.TabStop = False
        '
        'FrmPurchaseHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1030, 736)
        Me.Controls.Add(Me.ProductPictureBox)
        Me.Controls.Add(Me.GrdPurchase)
        Me.Controls.Add(Me.GrdPurchaseInvoice)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.LblAmount)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GrpStudentID)
        Me.Controls.Add(Me.GrpSupplierDetails)
        Me.Controls.Add(Me.PnlPurchasePaymentHistory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPurchaseHistory"
        Me.Text = "Purchase History"
        Me.PnlPurchasePaymentHistory.ResumeLayout(False)
        Me.PnlPurchasePaymentHistory.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GrpStudentID.ResumeLayout(False)
        Me.GrpStudentID.PerformLayout()
        Me.GrpSupplierDetails.ResumeLayout(False)
        Me.GrpSupplierDetails.PerformLayout()
        CType(Me.GrdPurchaseInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdPurchase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PnlPurchasePaymentHistory As System.Windows.Forms.Panel
    Friend WithEvents LblPurchaseHistory As System.Windows.Forms.Label
    Friend WithEvents TxtSearchPurchaseInvoice As System.Windows.Forms.TextBox
    Friend WithEvents label65 As System.Windows.Forms.Label
    Friend WithEvents LblSupplierName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GrpStudentID As System.Windows.Forms.GroupBox
    Friend WithEvents LblAmount As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LblSupplierID As System.Windows.Forms.Label
    Friend WithEvents lbl89 As System.Windows.Forms.Label
    Friend WithEvents LblMobileNo As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GrpSupplierDetails As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
    Friend WithEvents GrdPurchaseInvoice As System.Windows.Forms.DataGridView
    Friend WithEvents GrdPurchase As System.Windows.Forms.DataGridView
    Friend WithEvents ProductPictureBox As System.Windows.Forms.PictureBox
End Class
