<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQuotationHistory
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
        Me.PnlQuotationHistory = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.LblQuotationHistory = New System.Windows.Forms.Label
        Me.TxtSearchQuotationInvoice = New System.Windows.Forms.TextBox
        Me.LblCustomerNameLbl = New System.Windows.Forms.Label
        Me.LblCustomerName = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GrpStudentID = New System.Windows.Forms.GroupBox
        Me.LblAmount = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.LblCustomerID = New System.Windows.Forms.Label
        Me.lbl89 = New System.Windows.Forms.Label
        Me.LblMobileNo = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GrpCustomerDetails = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.GrdQuotationInvoice = New System.Windows.Forms.DataGridView
        Me.GrdQuotation = New System.Windows.Forms.DataGridView
        Me.PnlQuotationHistory.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GrpStudentID.SuspendLayout()
        Me.GrpCustomerDetails.SuspendLayout()
        CType(Me.GrdQuotationInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdQuotation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlQuotationHistory
        '
        Me.PnlQuotationHistory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlQuotationHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlQuotationHistory.Controls.Add(Me.Panel1)
        Me.PnlQuotationHistory.Controls.Add(Me.LblQuotationHistory)
        Me.PnlQuotationHistory.Location = New System.Drawing.Point(-2, -1)
        Me.PnlQuotationHistory.Name = "PnlQuotationHistory"
        Me.PnlQuotationHistory.Size = New System.Drawing.Size(1120, 88)
        Me.PnlQuotationHistory.TabIndex = 118
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Btnclose)
        Me.Panel1.Controls.Add(Me.Btnminimized)
        Me.Panel1.Controls.Add(Me.Btnmaximized)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1115, 27)
        Me.Panel1.TabIndex = 2056
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(1091, 0)
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
        Me.Btnminimized.Location = New System.Drawing.Point(1031, 0)
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
        Me.Btnmaximized.Location = New System.Drawing.Point(1061, 0)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1160
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'LblQuotationHistory
        '
        Me.LblQuotationHistory.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblQuotationHistory.AutoSize = True
        Me.LblQuotationHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQuotationHistory.ForeColor = System.Drawing.Color.White
        Me.LblQuotationHistory.Location = New System.Drawing.Point(460, 32)
        Me.LblQuotationHistory.Name = "LblQuotationHistory"
        Me.LblQuotationHistory.Size = New System.Drawing.Size(282, 37)
        Me.LblQuotationHistory.TabIndex = 0
        Me.LblQuotationHistory.Text = "Quotation History"
        '
        'TxtSearchQuotationInvoice
        '
        Me.TxtSearchQuotationInvoice.Location = New System.Drawing.Point(224, 19)
        Me.TxtSearchQuotationInvoice.Name = "TxtSearchQuotationInvoice"
        Me.TxtSearchQuotationInvoice.Size = New System.Drawing.Size(243, 20)
        Me.TxtSearchQuotationInvoice.TabIndex = 120
        '
        'LblCustomerNameLbl
        '
        Me.LblCustomerNameLbl.AutoSize = True
        Me.LblCustomerNameLbl.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.LblCustomerNameLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblCustomerNameLbl.Location = New System.Drawing.Point(15, 49)
        Me.LblCustomerNameLbl.Name = "LblCustomerNameLbl"
        Me.LblCustomerNameLbl.Size = New System.Drawing.Size(142, 20)
        Me.LblCustomerNameLbl.TabIndex = 1172
        Me.LblCustomerNameLbl.Text = "CUSTOMER NAME:"
        '
        'LblCustomerName
        '
        Me.LblCustomerName.AutoSize = True
        Me.LblCustomerName.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.LblCustomerName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblCustomerName.Location = New System.Drawing.Point(240, 49)
        Me.LblCustomerName.Name = "LblCustomerName"
        Me.LblCustomerName.Size = New System.Drawing.Size(0, 20)
        Me.LblCustomerName.TabIndex = 1171
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label1.Location = New System.Drawing.Point(15, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 20)
        Me.Label1.TabIndex = 1171
        Me.Label1.Text = "Search Quotation Invoice:"
        '
        'GrpStudentID
        '
        Me.GrpStudentID.Controls.Add(Me.LblCustomerNameLbl)
        Me.GrpStudentID.Controls.Add(Me.LblCustomerName)
        Me.GrpStudentID.Controls.Add(Me.Label1)
        Me.GrpStudentID.Controls.Add(Me.TxtSearchQuotationInvoice)
        Me.GrpStudentID.Location = New System.Drawing.Point(16, 93)
        Me.GrpStudentID.Name = "GrpStudentID"
        Me.GrpStudentID.Size = New System.Drawing.Size(476, 87)
        Me.GrpStudentID.TabIndex = 1175
        Me.GrpStudentID.TabStop = False
        '
        'LblAmount
        '
        Me.LblAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblAmount.AutoSize = True
        Me.LblAmount.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblAmount.Location = New System.Drawing.Point(984, 202)
        Me.LblAmount.Name = "LblAmount"
        Me.LblAmount.Size = New System.Drawing.Size(27, 19)
        Me.LblAmount.TabIndex = 1179
        Me.LblAmount.Text = "00"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(838, 202)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 19)
        Me.Label9.TabIndex = 1178
        Me.Label9.Text = "Amount:"
        '
        'LblCustomerID
        '
        Me.LblCustomerID.AutoSize = True
        Me.LblCustomerID.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCustomerID.Location = New System.Drawing.Point(203, 24)
        Me.LblCustomerID.Name = "LblCustomerID"
        Me.LblCustomerID.Size = New System.Drawing.Size(0, 20)
        Me.LblCustomerID.TabIndex = 1169
        '
        'lbl89
        '
        Me.lbl89.AutoSize = True
        Me.lbl89.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl89.Location = New System.Drawing.Point(43, 42)
        Me.lbl89.Name = "lbl89"
        Me.lbl89.Size = New System.Drawing.Size(98, 20)
        Me.lbl89.TabIndex = 1167
        Me.lbl89.Text = "MOBILE NO:"
        '
        'LblMobileNo
        '
        Me.LblMobileNo.AutoSize = True
        Me.LblMobileNo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMobileNo.Location = New System.Drawing.Point(203, 52)
        Me.LblMobileNo.Name = "LblMobileNo"
        Me.LblMobileNo.Size = New System.Drawing.Size(0, 20)
        Me.LblMobileNo.TabIndex = 1168
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 20)
        Me.Label3.TabIndex = 1170
        Me.Label3.Text = "CUSTOMER ID:"
        '
        'GrpCustomerDetails
        '
        Me.GrpCustomerDetails.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpCustomerDetails.Controls.Add(Me.Label3)
        Me.GrpCustomerDetails.Controls.Add(Me.LblMobileNo)
        Me.GrpCustomerDetails.Controls.Add(Me.lbl89)
        Me.GrpCustomerDetails.Controls.Add(Me.LblCustomerID)
        Me.GrpCustomerDetails.Location = New System.Drawing.Point(710, 93)
        Me.GrpCustomerDetails.Name = "GrpCustomerDetails"
        Me.GrpCustomerDetails.Size = New System.Drawing.Size(393, 96)
        Me.GrpCustomerDetails.TabIndex = 1172
        Me.GrpCustomerDetails.TabStop = False
        Me.GrpCustomerDetails.Text = "Customer Detials"
        '
        'Button3
        '
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(380, 195)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(114, 26)
        Me.Button3.TabIndex = 2048
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
        Me.Button5.Location = New System.Drawing.Point(140, 195)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(114, 26)
        Me.Button5.TabIndex = 2047
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
        Me.Button6.Location = New System.Drawing.Point(20, 195)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(114, 26)
        Me.Button6.TabIndex = 2046
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
        Me.Button7.Location = New System.Drawing.Point(260, 195)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(114, 26)
        Me.Button7.TabIndex = 2045
        Me.Button7.Text = "User Incompleted"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button7.UseVisualStyleBackColor = True
        '
        'GrdQuotationInvoice
        '
        Me.GrdQuotationInvoice.AllowUserToAddRows = False
        Me.GrdQuotationInvoice.AllowUserToDeleteRows = False
        Me.GrdQuotationInvoice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GrdQuotationInvoice.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdQuotationInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdQuotationInvoice.Location = New System.Drawing.Point(16, 227)
        Me.GrdQuotationInvoice.Name = "GrdQuotationInvoice"
        Me.GrdQuotationInvoice.ReadOnly = True
        Me.GrdQuotationInvoice.Size = New System.Drawing.Size(484, 393)
        Me.GrdQuotationInvoice.TabIndex = 2049
        '
        'GrdQuotation
        '
        Me.GrdQuotation.AllowUserToAddRows = False
        Me.GrdQuotation.AllowUserToDeleteRows = False
        Me.GrdQuotation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdQuotation.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdQuotation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdQuotation.Location = New System.Drawing.Point(506, 227)
        Me.GrdQuotation.Name = "GrdQuotation"
        Me.GrdQuotation.ReadOnly = True
        Me.GrdQuotation.Size = New System.Drawing.Size(597, 393)
        Me.GrdQuotation.TabIndex = 2050
        '
        'FrmQuotationHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1115, 626)
        Me.Controls.Add(Me.GrdQuotation)
        Me.Controls.Add(Me.GrdQuotationInvoice)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.LblAmount)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GrpStudentID)
        Me.Controls.Add(Me.GrpCustomerDetails)
        Me.Controls.Add(Me.PnlQuotationHistory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmQuotationHistory"
        Me.Text = "Quotation History"
        Me.PnlQuotationHistory.ResumeLayout(False)
        Me.PnlQuotationHistory.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GrpStudentID.ResumeLayout(False)
        Me.GrpStudentID.PerformLayout()
        Me.GrpCustomerDetails.ResumeLayout(False)
        Me.GrpCustomerDetails.PerformLayout()
        CType(Me.GrdQuotationInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdQuotation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PnlQuotationHistory As System.Windows.Forms.Panel
    Friend WithEvents LblQuotationHistory As System.Windows.Forms.Label
    Friend WithEvents TxtSearchQuotationInvoice As System.Windows.Forms.TextBox
    Friend WithEvents LblCustomerNameLbl As System.Windows.Forms.Label
    Friend WithEvents LblCustomerName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GrpStudentID As System.Windows.Forms.GroupBox
    Friend WithEvents LblAmount As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LblCustomerID As System.Windows.Forms.Label
    Friend WithEvents lbl89 As System.Windows.Forms.Label
    Friend WithEvents LblMobileNo As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GrpCustomerDetails As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
    Friend WithEvents GrdQuotationInvoice As System.Windows.Forms.DataGridView
    Friend WithEvents GrdQuotation As System.Windows.Forms.DataGridView
End Class
