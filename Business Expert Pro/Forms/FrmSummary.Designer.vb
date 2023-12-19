<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSummary
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
        Me.PnlSearchMemberDetails = New System.Windows.Forms.Panel
        Me.Lblsummary = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblTotalCopiesSaleToday = New System.Windows.Forms.Label
        Me.lblTotalSaleAmountToday = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblTotalDueSaleToday = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Btnload = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.lblCashInHandToday = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.PnlSearchMemberDetails.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlSearchMemberDetails
        '
        Me.PnlSearchMemberDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlSearchMemberDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PnlSearchMemberDetails.Controls.Add(Me.Lblsummary)
        Me.PnlSearchMemberDetails.Location = New System.Drawing.Point(1, 0)
        Me.PnlSearchMemberDetails.Name = "PnlSearchMemberDetails"
        Me.PnlSearchMemberDetails.Size = New System.Drawing.Size(1008, 71)
        Me.PnlSearchMemberDetails.TabIndex = 1170
        '
        'Lblsummary
        '
        Me.Lblsummary.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lblsummary.AutoSize = True
        Me.Lblsummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblsummary.ForeColor = System.Drawing.Color.White
        Me.Lblsummary.Location = New System.Drawing.Point(424, 17)
        Me.Lblsummary.Name = "Lblsummary"
        Me.Lblsummary.Size = New System.Drawing.Size(161, 37)
        Me.Lblsummary.TabIndex = 0
        Me.Lblsummary.Text = "Summary"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(8, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 19)
        Me.Label1.TabIndex = 1171
        Me.Label1.Text = "Total Copies Sale Today:"
        '
        'lblTotalCopiesSaleToday
        '
        Me.lblTotalCopiesSaleToday.AutoSize = True
        Me.lblTotalCopiesSaleToday.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalCopiesSaleToday.Location = New System.Drawing.Point(301, 27)
        Me.lblTotalCopiesSaleToday.Name = "lblTotalCopiesSaleToday"
        Me.lblTotalCopiesSaleToday.Size = New System.Drawing.Size(25, 19)
        Me.lblTotalCopiesSaleToday.TabIndex = 1172
        Me.lblTotalCopiesSaleToday.Text = "00"
        '
        'lblTotalSaleAmountToday
        '
        Me.lblTotalSaleAmountToday.AutoSize = True
        Me.lblTotalSaleAmountToday.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalSaleAmountToday.Location = New System.Drawing.Point(301, 53)
        Me.lblTotalSaleAmountToday.Name = "lblTotalSaleAmountToday"
        Me.lblTotalSaleAmountToday.Size = New System.Drawing.Size(25, 19)
        Me.lblTotalSaleAmountToday.TabIndex = 1174
        Me.lblTotalSaleAmountToday.Text = "00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(8, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 19)
        Me.Label3.TabIndex = 1173
        Me.Label3.Text = "Total Sale Amount Today:"
        '
        'lblTotalDueSaleToday
        '
        Me.lblTotalDueSaleToday.AutoSize = True
        Me.lblTotalDueSaleToday.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalDueSaleToday.Location = New System.Drawing.Point(301, 79)
        Me.lblTotalDueSaleToday.Name = "lblTotalDueSaleToday"
        Me.lblTotalDueSaleToday.Size = New System.Drawing.Size(25, 19)
        Me.lblTotalDueSaleToday.TabIndex = 1188
        Me.lblTotalDueSaleToday.Text = "00"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(8, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(152, 19)
        Me.Label10.TabIndex = 1187
        Me.Label10.Text = "Total Due Sale Today:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTotalDueSaleToday)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lblTotalSaleAmountToday)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblTotalCopiesSaleToday)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(525, 295)
        Me.GroupBox1.TabIndex = 1189
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Today's Transaction"
        '
        'Btnload
        '
        Me.Btnload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnload.Location = New System.Drawing.Point(684, 427)
        Me.Btnload.Name = "Btnload"
        Me.Btnload.Size = New System.Drawing.Size(94, 35)
        Me.Btnload.TabIndex = 1190
        Me.Btnload.Text = "Load"
        Me.Btnload.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnload.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblCashInHandToday)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Location = New System.Drawing.Point(643, 480)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(205, 109)
        Me.GroupBox5.TabIndex = 1204
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Visible = False
        '
        'lblCashInHandToday
        '
        Me.lblCashInHandToday.AutoSize = True
        Me.lblCashInHandToday.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCashInHandToday.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblCashInHandToday.Location = New System.Drawing.Point(90, 60)
        Me.lblCashInHandToday.Name = "lblCashInHandToday"
        Me.lblCashInHandToday.Size = New System.Drawing.Size(25, 19)
        Me.lblCashInHandToday.TabIndex = 1
        Me.lblCashInHandToday.Text = "00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.Location = New System.Drawing.Point(23, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "CASH IN HAND TODAY"
        '
        'FrmSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Btnload)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PnlSearchMemberDetails)
        Me.Name = "FrmSummary"
        Me.Text = "summary"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PnlSearchMemberDetails.ResumeLayout(False)
        Me.PnlSearchMemberDetails.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlSearchMemberDetails As System.Windows.Forms.Panel
    Friend WithEvents Lblsummary As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTotalCopiesSaleToday As System.Windows.Forms.Label
    Friend WithEvents lblTotalSaleAmountToday As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTotalDueSaleToday As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Btnload As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCashInHandToday As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
