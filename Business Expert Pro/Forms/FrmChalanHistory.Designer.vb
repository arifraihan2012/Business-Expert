<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChalanHistory
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
        Me.GrdChalanInvoice = New System.Windows.Forms.DataGridView
        Me.PnlChalanPaymentHistory = New System.Windows.Forms.Panel
        Me.LblChalanHistory = New System.Windows.Forms.Label
        Me.TxtSearchChalanInvoice = New System.Windows.Forms.TextBox
        Me.GrdChalan = New System.Windows.Forms.DataGridView
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
        CType(Me.GrdChalanInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlChalanPaymentHistory.SuspendLayout()
        CType(Me.GrdChalan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpStudentID.SuspendLayout()
        Me.GrpCustomerDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrdChalanInvoice
        '
        Me.GrdChalanInvoice.AllowUserToAddRows = False
        Me.GrdChalanInvoice.AllowUserToDeleteRows = False
        Me.GrdChalanInvoice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GrdChalanInvoice.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GrdChalanInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdChalanInvoice.Location = New System.Drawing.Point(16, 227)
        Me.GrdChalanInvoice.Name = "GrdChalanInvoice"
        Me.GrdChalanInvoice.ReadOnly = True
        Me.GrdChalanInvoice.Size = New System.Drawing.Size(474, 503)
        Me.GrdChalanInvoice.TabIndex = 119
        '
        'PnlChalanPaymentHistory
        '
        Me.PnlChalanPaymentHistory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlChalanPaymentHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PnlChalanPaymentHistory.Controls.Add(Me.LblChalanHistory)
        Me.PnlChalanPaymentHistory.Location = New System.Drawing.Point(-2, -1)
        Me.PnlChalanPaymentHistory.Name = "PnlChalanPaymentHistory"
        Me.PnlChalanPaymentHistory.Size = New System.Drawing.Size(1035, 88)
        Me.PnlChalanPaymentHistory.TabIndex = 118
        '
        'LblChalanHistory
        '
        Me.LblChalanHistory.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblChalanHistory.AutoSize = True
        Me.LblChalanHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblChalanHistory.ForeColor = System.Drawing.Color.White
        Me.LblChalanHistory.Location = New System.Drawing.Point(417, 26)
        Me.LblChalanHistory.Name = "LblChalanHistory"
        Me.LblChalanHistory.Size = New System.Drawing.Size(241, 37)
        Me.LblChalanHistory.TabIndex = 0
        Me.LblChalanHistory.Text = "Chalan History"
        '
        'TxtSearchChalanInvoice
        '
        Me.TxtSearchChalanInvoice.Location = New System.Drawing.Point(203, 19)
        Me.TxtSearchChalanInvoice.Name = "TxtSearchChalanInvoice"
        Me.TxtSearchChalanInvoice.Size = New System.Drawing.Size(230, 20)
        Me.TxtSearchChalanInvoice.TabIndex = 120
        '
        'GrdChalan
        '
        Me.GrdChalan.AllowUserToAddRows = False
        Me.GrdChalan.AllowUserToDeleteRows = False
        Me.GrdChalan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdChalan.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GrdChalan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdChalan.Location = New System.Drawing.Point(497, 227)
        Me.GrdChalan.Name = "GrdChalan"
        Me.GrdChalan.ReadOnly = True
        Me.GrdChalan.Size = New System.Drawing.Size(521, 503)
        Me.GrdChalan.TabIndex = 213
        '
        'LblCustomerNameLbl
        '
        Me.LblCustomerNameLbl.AutoSize = True
        Me.LblCustomerNameLbl.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.LblCustomerNameLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblCustomerNameLbl.Location = New System.Drawing.Point(5, 42)
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
        Me.LblCustomerName.Location = New System.Drawing.Point(199, 46)
        Me.LblCustomerName.Name = "LblCustomerName"
        Me.LblCustomerName.Size = New System.Drawing.Size(0, 20)
        Me.LblCustomerName.TabIndex = 1171
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label1.Location = New System.Drawing.Point(5, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 20)
        Me.Label1.TabIndex = 1171
        Me.Label1.Text = "Search Chalan Invoice:"
        '
        'GrpStudentID
        '
        Me.GrpStudentID.Controls.Add(Me.LblCustomerNameLbl)
        Me.GrpStudentID.Controls.Add(Me.LblCustomerName)
        Me.GrpStudentID.Controls.Add(Me.Label1)
        Me.GrpStudentID.Controls.Add(Me.TxtSearchChalanInvoice)
        Me.GrpStudentID.Location = New System.Drawing.Point(27, 93)
        Me.GrpStudentID.Name = "GrpStudentID"
        Me.GrpStudentID.Size = New System.Drawing.Size(439, 72)
        Me.GrpStudentID.TabIndex = 1175
        Me.GrpStudentID.TabStop = False
        '
        'LblAmount
        '
        Me.LblAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblAmount.AutoSize = True
        Me.LblAmount.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblAmount.Location = New System.Drawing.Point(899, 202)
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
        Me.Label9.Location = New System.Drawing.Point(753, 202)
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
        Me.GrpCustomerDetails.Location = New System.Drawing.Point(625, 93)
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
        Me.Button3.Location = New System.Drawing.Point(376, 195)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(114, 26)
        Me.Button3.TabIndex = 2052
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
        Me.Button5.Location = New System.Drawing.Point(136, 195)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(114, 26)
        Me.Button5.TabIndex = 2051
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
        Me.Button6.Location = New System.Drawing.Point(16, 195)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(114, 26)
        Me.Button6.TabIndex = 2050
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
        Me.Button7.Location = New System.Drawing.Point(256, 195)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(114, 26)
        Me.Button7.TabIndex = 2049
        Me.Button7.Text = "User Incompleted"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button7.UseVisualStyleBackColor = True
        '
        'FrmChalanHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1030, 736)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.LblAmount)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GrpStudentID)
        Me.Controls.Add(Me.GrpCustomerDetails)
        Me.Controls.Add(Me.GrdChalan)
        Me.Controls.Add(Me.GrdChalanInvoice)
        Me.Controls.Add(Me.PnlChalanPaymentHistory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmChalanHistory"
        Me.Text = "Chalan History"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GrdChalanInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlChalanPaymentHistory.ResumeLayout(False)
        Me.PnlChalanPaymentHistory.PerformLayout()
        CType(Me.GrdChalan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpStudentID.ResumeLayout(False)
        Me.GrpStudentID.PerformLayout()
        Me.GrpCustomerDetails.ResumeLayout(False)
        Me.GrpCustomerDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrdChalanInvoice As System.Windows.Forms.DataGridView
    Friend WithEvents PnlChalanPaymentHistory As System.Windows.Forms.Panel
    Friend WithEvents LblChalanHistory As System.Windows.Forms.Label
    Friend WithEvents TxtSearchChalanInvoice As System.Windows.Forms.TextBox
    Friend WithEvents GrdChalan As System.Windows.Forms.DataGridView
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
End Class
