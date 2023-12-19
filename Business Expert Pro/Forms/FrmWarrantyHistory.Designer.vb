<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWarrantyHistory
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
        Me.PnlWarrantyHistory = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.LblWarrantyHistory = New System.Windows.Forms.Label
        Me.TxtSearchWarrantyInvoice = New System.Windows.Forms.TextBox
        Me.LblCustomerNameLbl = New System.Windows.Forms.Label
        Me.LblCustomerName = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GrpWarrantyInvoice = New System.Windows.Forms.GroupBox
        Me.LblCustomerID = New System.Windows.Forms.Label
        Me.lbl89 = New System.Windows.Forms.Label
        Me.LblMobileNo = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GrpCustomerDetails = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.GrdWarrantyInvoice = New System.Windows.Forms.DataGridView
        Me.GrdWarrantyDetails = New System.Windows.Forms.DataGridView
        Me.PnlWarrantyHistory.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GrpWarrantyInvoice.SuspendLayout()
        Me.GrpCustomerDetails.SuspendLayout()
        CType(Me.GrdWarrantyInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdWarrantyDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlWarrantyHistory
        '
        Me.PnlWarrantyHistory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlWarrantyHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlWarrantyHistory.Controls.Add(Me.Panel1)
        Me.PnlWarrantyHistory.Controls.Add(Me.LblWarrantyHistory)
        Me.PnlWarrantyHistory.Location = New System.Drawing.Point(-2, -1)
        Me.PnlWarrantyHistory.Name = "PnlWarrantyHistory"
        Me.PnlWarrantyHistory.Size = New System.Drawing.Size(1035, 88)
        Me.PnlWarrantyHistory.TabIndex = 118
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Btnclose)
        Me.Panel1.Controls.Add(Me.Btnminimized)
        Me.Panel1.Controls.Add(Me.Btnmaximized)
        Me.Panel1.Location = New System.Drawing.Point(3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1028, 28)
        Me.Panel1.TabIndex = 4
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
        Me.Btnclose.Size = New System.Drawing.Size(21, 24)
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
        Me.Btnminimized.Location = New System.Drawing.Point(947, 0)
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
        'LblWarrantyHistory
        '
        Me.LblWarrantyHistory.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblWarrantyHistory.AutoSize = True
        Me.LblWarrantyHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWarrantyHistory.ForeColor = System.Drawing.Color.White
        Me.LblWarrantyHistory.Location = New System.Drawing.Point(384, 39)
        Me.LblWarrantyHistory.Name = "LblWarrantyHistory"
        Me.LblWarrantyHistory.Size = New System.Drawing.Size(272, 37)
        Me.LblWarrantyHistory.TabIndex = 0
        Me.LblWarrantyHistory.Text = "Warranty History"
        '
        'TxtSearchWarrantyInvoice
        '
        Me.TxtSearchWarrantyInvoice.Location = New System.Drawing.Point(192, 18)
        Me.TxtSearchWarrantyInvoice.Name = "TxtSearchWarrantyInvoice"
        Me.TxtSearchWarrantyInvoice.Size = New System.Drawing.Size(243, 20)
        Me.TxtSearchWarrantyInvoice.TabIndex = 120
        '
        'LblCustomerNameLbl
        '
        Me.LblCustomerNameLbl.AutoSize = True
        Me.LblCustomerNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.LblCustomerNameLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblCustomerNameLbl.Location = New System.Drawing.Point(15, 42)
        Me.LblCustomerNameLbl.Name = "LblCustomerNameLbl"
        Me.LblCustomerNameLbl.Size = New System.Drawing.Size(146, 18)
        Me.LblCustomerNameLbl.TabIndex = 1172
        Me.LblCustomerNameLbl.Text = "CUSTOMER NAME:"
        '
        'LblCustomerName
        '
        Me.LblCustomerName.AutoSize = True
        Me.LblCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.LblCustomerName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblCustomerName.Location = New System.Drawing.Point(199, 46)
        Me.LblCustomerName.Name = "LblCustomerName"
        Me.LblCustomerName.Size = New System.Drawing.Size(0, 18)
        Me.LblCustomerName.TabIndex = 1171
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label1.Location = New System.Drawing.Point(15, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 18)
        Me.Label1.TabIndex = 1171
        Me.Label1.Text = "Search Warranty Invoice:"
        '
        'GrpWarrantyInvoice
        '
        Me.GrpWarrantyInvoice.Controls.Add(Me.LblCustomerNameLbl)
        Me.GrpWarrantyInvoice.Controls.Add(Me.LblCustomerName)
        Me.GrpWarrantyInvoice.Controls.Add(Me.Label1)
        Me.GrpWarrantyInvoice.Controls.Add(Me.TxtSearchWarrantyInvoice)
        Me.GrpWarrantyInvoice.Location = New System.Drawing.Point(27, 93)
        Me.GrpWarrantyInvoice.Name = "GrpWarrantyInvoice"
        Me.GrpWarrantyInvoice.Size = New System.Drawing.Size(448, 72)
        Me.GrpWarrantyInvoice.TabIndex = 1175
        Me.GrpWarrantyInvoice.TabStop = False
        '
        'LblCustomerID
        '
        Me.LblCustomerID.AutoSize = True
        Me.LblCustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCustomerID.Location = New System.Drawing.Point(203, 24)
        Me.LblCustomerID.Name = "LblCustomerID"
        Me.LblCustomerID.Size = New System.Drawing.Size(0, 18)
        Me.LblCustomerID.TabIndex = 1169
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
        Me.LblMobileNo.Location = New System.Drawing.Point(203, 52)
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
        'GrdWarrantyInvoice
        '
        Me.GrdWarrantyInvoice.AllowUserToAddRows = False
        Me.GrdWarrantyInvoice.AllowUserToDeleteRows = False
        Me.GrdWarrantyInvoice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GrdWarrantyInvoice.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdWarrantyInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdWarrantyInvoice.Location = New System.Drawing.Point(17, 227)
        Me.GrdWarrantyInvoice.Name = "GrdWarrantyInvoice"
        Me.GrdWarrantyInvoice.ReadOnly = True
        Me.GrdWarrantyInvoice.Size = New System.Drawing.Size(474, 503)
        Me.GrdWarrantyInvoice.TabIndex = 2041
        '
        'GrdWarrantyDetails
        '
        Me.GrdWarrantyDetails.AllowUserToAddRows = False
        Me.GrdWarrantyDetails.AllowUserToDeleteRows = False
        Me.GrdWarrantyDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdWarrantyDetails.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdWarrantyDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdWarrantyDetails.Location = New System.Drawing.Point(497, 227)
        Me.GrdWarrantyDetails.Name = "GrdWarrantyDetails"
        Me.GrdWarrantyDetails.ReadOnly = True
        Me.GrdWarrantyDetails.Size = New System.Drawing.Size(521, 503)
        Me.GrdWarrantyDetails.TabIndex = 2042
        '
        'FrmWarrantyHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1030, 736)
        Me.Controls.Add(Me.GrdWarrantyDetails)
        Me.Controls.Add(Me.GrdWarrantyInvoice)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.GrpWarrantyInvoice)
        Me.Controls.Add(Me.GrpCustomerDetails)
        Me.Controls.Add(Me.PnlWarrantyHistory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmWarrantyHistory"
        Me.Text = "Warranty History"
        Me.PnlWarrantyHistory.ResumeLayout(False)
        Me.PnlWarrantyHistory.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GrpWarrantyInvoice.ResumeLayout(False)
        Me.GrpWarrantyInvoice.PerformLayout()
        Me.GrpCustomerDetails.ResumeLayout(False)
        Me.GrpCustomerDetails.PerformLayout()
        CType(Me.GrdWarrantyInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdWarrantyDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlWarrantyHistory As System.Windows.Forms.Panel
    Friend WithEvents LblWarrantyHistory As System.Windows.Forms.Label
    Friend WithEvents TxtSearchWarrantyInvoice As System.Windows.Forms.TextBox
    Friend WithEvents LblCustomerNameLbl As System.Windows.Forms.Label
    Friend WithEvents LblCustomerName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GrpWarrantyInvoice As System.Windows.Forms.GroupBox
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
    Friend WithEvents GrdWarrantyInvoice As System.Windows.Forms.DataGridView
    Friend WithEvents GrdWarrantyDetails As System.Windows.Forms.DataGridView
End Class
