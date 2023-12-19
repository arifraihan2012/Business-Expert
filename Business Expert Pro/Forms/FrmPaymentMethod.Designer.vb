<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPaymentMethod
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
        Me.LblMethodID = New System.Windows.Forms.Label
        Me.TxtPaymentMethodID = New System.Windows.Forms.TextBox
        Me.PnlPaymentMethod = New System.Windows.Forms.Panel
        Me.LblPaymentMethod = New System.Windows.Forms.Label
        Me.LblMethodName = New System.Windows.Forms.Label
        Me.TxtPaymentMethodName = New System.Windows.Forms.TextBox
        Me.GrdPaymentMethod = New System.Windows.Forms.DataGridView
        Me.TxtPaymentMethod = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.BtnInsert = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnAddNew = New System.Windows.Forms.Button
        Me.BtnRefresh = New System.Windows.Forms.Button
        Me.PnlPaymentMethod.SuspendLayout()
        CType(Me.GrdPaymentMethod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TxtPaymentMethod.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblMethodID
        '
        Me.LblMethodID.AutoSize = True
        Me.LblMethodID.Location = New System.Drawing.Point(36, 25)
        Me.LblMethodID.Name = "LblMethodID"
        Me.LblMethodID.Size = New System.Drawing.Size(107, 13)
        Me.LblMethodID.TabIndex = 1
        Me.LblMethodID.Text = " Payment Method ID:"
        '
        'TxtPaymentMethodID
        '
        Me.TxtPaymentMethodID.Enabled = False
        Me.TxtPaymentMethodID.Location = New System.Drawing.Point(173, 18)
        Me.TxtPaymentMethodID.Name = "TxtPaymentMethodID"
        Me.TxtPaymentMethodID.Size = New System.Drawing.Size(100, 20)
        Me.TxtPaymentMethodID.TabIndex = 2
        '
        'PnlPaymentMethod
        '
        Me.PnlPaymentMethod.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlPaymentMethod.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PnlPaymentMethod.Controls.Add(Me.LblPaymentMethod)
        Me.PnlPaymentMethod.Location = New System.Drawing.Point(1, 0)
        Me.PnlPaymentMethod.Name = "PnlPaymentMethod"
        Me.PnlPaymentMethod.Size = New System.Drawing.Size(831, 80)
        Me.PnlPaymentMethod.TabIndex = 3
        '
        'LblPaymentMethod
        '
        Me.LblPaymentMethod.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblPaymentMethod.AutoSize = True
        Me.LblPaymentMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPaymentMethod.ForeColor = System.Drawing.Color.White
        Me.LblPaymentMethod.Location = New System.Drawing.Point(280, 22)
        Me.LblPaymentMethod.Name = "LblPaymentMethod"
        Me.LblPaymentMethod.Size = New System.Drawing.Size(271, 37)
        Me.LblPaymentMethod.TabIndex = 0
        Me.LblPaymentMethod.Text = "Payment Method"
        '
        'LblMethodName
        '
        Me.LblMethodName.AutoSize = True
        Me.LblMethodName.Location = New System.Drawing.Point(36, 52)
        Me.LblMethodName.Name = "LblMethodName"
        Me.LblMethodName.Size = New System.Drawing.Size(121, 13)
        Me.LblMethodName.TabIndex = 170
        Me.LblMethodName.Text = "Payment Method Name:"
        '
        'TxtPaymentMethodName
        '
        Me.TxtPaymentMethodName.Location = New System.Drawing.Point(173, 49)
        Me.TxtPaymentMethodName.Name = "TxtPaymentMethodName"
        Me.TxtPaymentMethodName.Size = New System.Drawing.Size(168, 20)
        Me.TxtPaymentMethodName.TabIndex = 171
        '
        'GrdPaymentMethod
        '
        Me.GrdPaymentMethod.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdPaymentMethod.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GrdPaymentMethod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdPaymentMethod.Location = New System.Drawing.Point(12, 255)
        Me.GrdPaymentMethod.Name = "GrdPaymentMethod"
        Me.GrdPaymentMethod.Size = New System.Drawing.Size(806, 279)
        Me.GrdPaymentMethod.TabIndex = 172
        '
        'TxtPaymentMethod
        '
        Me.TxtPaymentMethod.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPaymentMethod.Controls.Add(Me.Label6)
        Me.TxtPaymentMethod.Controls.Add(Me.TxtPaymentMethodName)
        Me.TxtPaymentMethod.Controls.Add(Me.LblMethodName)
        Me.TxtPaymentMethod.Controls.Add(Me.TxtPaymentMethodID)
        Me.TxtPaymentMethod.Controls.Add(Me.LblMethodID)
        Me.TxtPaymentMethod.Location = New System.Drawing.Point(12, 158)
        Me.TxtPaymentMethod.Name = "TxtPaymentMethod"
        Me.TxtPaymentMethod.Size = New System.Drawing.Size(806, 88)
        Me.TxtPaymentMethod.TabIndex = 174
        Me.TxtPaymentMethod.TabStop = False
        Me.TxtPaymentMethod.Text = "Payment Method"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(150, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 24)
        Me.Label6.TabIndex = 2029
        Me.Label6.Text = "*"
        '
        'BtnInsert
        '
        Me.BtnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInsert.Image = Global.Business_Expert_Pro.My.Resources.Resources.Save1
        Me.BtnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInsert.Location = New System.Drawing.Point(453, 99)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(94, 42)
        Me.BtnInsert.TabIndex = 178
        Me.BtnInsert.Text = "Insert"
        Me.BtnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnInsert.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Image = Global.Business_Expert_Pro.My.Resources.Resources.Edit1
        Me.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUpdate.Location = New System.Drawing.Point(116, 99)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(94, 42)
        Me.BtnUpdate.TabIndex = 177
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Image = Global.Business_Expert_Pro.My.Resources.Resources.Delete3
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(221, 99)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(94, 42)
        Me.BtnDelete.TabIndex = 176
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnAddNew
        '
        Me.BtnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddNew.Image = Global.Business_Expert_Pro.My.Resources.Resources.Add_New1
        Me.BtnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddNew.Location = New System.Drawing.Point(11, 99)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(94, 42)
        Me.BtnAddNew.TabIndex = 175
        Me.BtnAddNew.Text = "Add New"
        Me.BtnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'BtnRefresh
        '
        Me.BtnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefresh.Image = Global.Business_Expert_Pro.My.Resources.Resources.icon_ios7_refresh_empty_128__1_
        Me.BtnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRefresh.Location = New System.Drawing.Point(326, 99)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(89, 42)
        Me.BtnRefresh.TabIndex = 179
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'FrmPaymentMethod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(830, 539)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.BtnInsert)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.TxtPaymentMethod)
        Me.Controls.Add(Me.GrdPaymentMethod)
        Me.Controls.Add(Me.PnlPaymentMethod)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmPaymentMethod"
        Me.Text = "Payment Method"
        Me.PnlPaymentMethod.ResumeLayout(False)
        Me.PnlPaymentMethod.PerformLayout()
        CType(Me.GrdPaymentMethod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TxtPaymentMethod.ResumeLayout(False)
        Me.TxtPaymentMethod.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblMethodID As System.Windows.Forms.Label
    Friend WithEvents TxtPaymentMethodID As System.Windows.Forms.TextBox
    Friend WithEvents PnlPaymentMethod As System.Windows.Forms.Panel
    Friend WithEvents LblPaymentMethod As System.Windows.Forms.Label
    Friend WithEvents LblMethodName As System.Windows.Forms.Label
    Friend WithEvents TxtPaymentMethodName As System.Windows.Forms.TextBox
    Friend WithEvents GrdPaymentMethod As System.Windows.Forms.DataGridView
    Friend WithEvents TxtPaymentMethod As System.Windows.Forms.GroupBox
    Friend WithEvents BtnInsert As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
