<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVoucherHistory
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
        Me.GrdVoucherNo = New System.Windows.Forms.DataGridView
        Me.PnlVoucherHistory = New System.Windows.Forms.Panel
        Me.LblVoucherHistory = New System.Windows.Forms.Label
        Me.TxtSearchVoucherNo = New System.Windows.Forms.TextBox
        Me.GrdVoucherDetails = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnLoadIncomplete = New System.Windows.Forms.Button
        Me.GrpStudentID = New System.Windows.Forms.GroupBox
        Me.LblAmount = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblTotalReceived = New System.Windows.Forms.Label
        Me.lblTotalPaid = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.label43 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        CType(Me.GrdVoucherNo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlVoucherHistory.SuspendLayout()
        CType(Me.GrdVoucherDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpStudentID.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrdVoucherNo
        '
        Me.GrdVoucherNo.AllowUserToAddRows = False
        Me.GrdVoucherNo.AllowUserToDeleteRows = False
        Me.GrdVoucherNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GrdVoucherNo.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GrdVoucherNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdVoucherNo.Location = New System.Drawing.Point(16, 227)
        Me.GrdVoucherNo.Name = "GrdVoucherNo"
        Me.GrdVoucherNo.ReadOnly = True
        Me.GrdVoucherNo.Size = New System.Drawing.Size(518, 503)
        Me.GrdVoucherNo.TabIndex = 119
        '
        'PnlVoucherHistory
        '
        Me.PnlVoucherHistory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlVoucherHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PnlVoucherHistory.Controls.Add(Me.LblVoucherHistory)
        Me.PnlVoucherHistory.Location = New System.Drawing.Point(-2, -1)
        Me.PnlVoucherHistory.Name = "PnlVoucherHistory"
        Me.PnlVoucherHistory.Size = New System.Drawing.Size(1035, 88)
        Me.PnlVoucherHistory.TabIndex = 118
        '
        'LblVoucherHistory
        '
        Me.LblVoucherHistory.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblVoucherHistory.AutoSize = True
        Me.LblVoucherHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVoucherHistory.ForeColor = System.Drawing.Color.White
        Me.LblVoucherHistory.Location = New System.Drawing.Point(417, 26)
        Me.LblVoucherHistory.Name = "LblVoucherHistory"
        Me.LblVoucherHistory.Size = New System.Drawing.Size(260, 37)
        Me.LblVoucherHistory.TabIndex = 0
        Me.LblVoucherHistory.Text = "Voucher History"
        '
        'TxtSearchVoucherNo
        '
        Me.TxtSearchVoucherNo.Location = New System.Drawing.Point(190, 19)
        Me.TxtSearchVoucherNo.Name = "TxtSearchVoucherNo"
        Me.TxtSearchVoucherNo.Size = New System.Drawing.Size(243, 20)
        Me.TxtSearchVoucherNo.TabIndex = 120
        '
        'GrdVoucherDetails
        '
        Me.GrdVoucherDetails.AllowUserToAddRows = False
        Me.GrdVoucherDetails.AllowUserToDeleteRows = False
        Me.GrdVoucherDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdVoucherDetails.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GrdVoucherDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdVoucherDetails.Location = New System.Drawing.Point(540, 227)
        Me.GrdVoucherDetails.Name = "GrdVoucherDetails"
        Me.GrdVoucherDetails.ReadOnly = True
        Me.GrdVoucherDetails.Size = New System.Drawing.Size(478, 503)
        Me.GrdVoucherDetails.TabIndex = 213
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label1.Location = New System.Drawing.Point(15, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 20)
        Me.Label1.TabIndex = 1171
        Me.Label1.Text = "Search Voucher No:"
        '
        'BtnLoadIncomplete
        '
        Me.BtnLoadIncomplete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnLoadIncomplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLoadIncomplete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLoadIncomplete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLoadIncomplete.Location = New System.Drawing.Point(284, 194)
        Me.BtnLoadIncomplete.Name = "BtnLoadIncomplete"
        Me.BtnLoadIncomplete.Size = New System.Drawing.Size(114, 26)
        Me.BtnLoadIncomplete.TabIndex = 1173
        Me.BtnLoadIncomplete.Text = "User Incompleted"
        Me.BtnLoadIncomplete.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnLoadIncomplete.UseVisualStyleBackColor = True
        '
        'GrpStudentID
        '
        Me.GrpStudentID.Controls.Add(Me.Label1)
        Me.GrpStudentID.Controls.Add(Me.TxtSearchVoucherNo)
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
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(16, 194)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 26)
        Me.Button1.TabIndex = 1181
        Me.Button1.Text = "Completed Today"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(150, 194)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(114, 26)
        Me.Button2.TabIndex = 1182
        Me.Button2.Text = "All Completed"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lblTotalReceived)
        Me.GroupBox1.Controls.Add(Me.lblTotalPaid)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.label43)
        Me.GroupBox1.Location = New System.Drawing.Point(757, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 52)
        Me.GroupBox1.TabIndex = 2035
        Me.GroupBox1.TabStop = False
        '
        'lblTotalReceived
        '
        Me.lblTotalReceived.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalReceived.AutoSize = True
        Me.lblTotalReceived.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTotalReceived.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalReceived.Location = New System.Drawing.Point(172, 30)
        Me.lblTotalReceived.Name = "lblTotalReceived"
        Me.lblTotalReceived.Size = New System.Drawing.Size(21, 13)
        Me.lblTotalReceived.TabIndex = 1162
        Me.lblTotalReceived.Text = "00"
        '
        'lblTotalPaid
        '
        Me.lblTotalPaid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalPaid.AutoSize = True
        Me.lblTotalPaid.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTotalPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPaid.Location = New System.Drawing.Point(172, 13)
        Me.lblTotalPaid.Name = "lblTotalPaid"
        Me.lblTotalPaid.Size = New System.Drawing.Size(21, 13)
        Me.lblTotalPaid.TabIndex = 1163
        Me.lblTotalPaid.Text = "00"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 15)
        Me.Label3.TabIndex = 1160
        Me.Label3.Text = "Total Received Today:"
        '
        'label43
        '
        Me.label43.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label43.AutoSize = True
        Me.label43.Cursor = System.Windows.Forms.Cursors.Default
        Me.label43.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label43.Location = New System.Drawing.Point(14, 13)
        Me.label43.Name = "label43"
        Me.label43.Size = New System.Drawing.Size(118, 15)
        Me.label43.TabIndex = 1161
        Me.label43.Text = "Total Paid Today:"
        '
        'Button4
        '
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(418, 194)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(114, 26)
        Me.Button4.TabIndex = 2036
        Me.Button4.Text = "All Incompleted"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'FrmVoucherHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1030, 736)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LblAmount)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GrpStudentID)
        Me.Controls.Add(Me.BtnLoadIncomplete)
        Me.Controls.Add(Me.GrdVoucherDetails)
        Me.Controls.Add(Me.GrdVoucherNo)
        Me.Controls.Add(Me.PnlVoucherHistory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmVoucherHistory"
        Me.Text = "Voucher History"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GrdVoucherNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlVoucherHistory.ResumeLayout(False)
        Me.PnlVoucherHistory.PerformLayout()
        CType(Me.GrdVoucherDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpStudentID.ResumeLayout(False)
        Me.GrpStudentID.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrdVoucherNo As System.Windows.Forms.DataGridView
    Friend WithEvents PnlVoucherHistory As System.Windows.Forms.Panel
    Friend WithEvents LblVoucherHistory As System.Windows.Forms.Label
    Friend WithEvents TxtSearchVoucherNo As System.Windows.Forms.TextBox
    Friend WithEvents GrdVoucherDetails As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnLoadIncomplete As System.Windows.Forms.Button
    Friend WithEvents GrpStudentID As System.Windows.Forms.GroupBox
    Friend WithEvents LblAmount As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalReceived As System.Windows.Forms.Label
    Friend WithEvents lblTotalPaid As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents label43 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
