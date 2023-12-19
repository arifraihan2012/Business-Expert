<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVoucherPurpose
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
        Me.PnlVoucherPurpose = New System.Windows.Forms.Panel
        Me.LblVoucherPurpose = New System.Windows.Forms.Label
        Me.TxtVoucherPurposeID = New System.Windows.Forms.TextBox
        Me.LblVoucherPurposeID = New System.Windows.Forms.Label
        Me.TxtVoucherPurposeName = New System.Windows.Forms.TextBox
        Me.LblVoucherPurposeName = New System.Windows.Forms.Label
        Me.GrpVoucherPurpose = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GrdVoucherPurpose = New System.Windows.Forms.DataGridView
        Me.BtnRefrersh = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnAddNew = New System.Windows.Forms.Button
        Me.PnlVoucherPurpose.SuspendLayout()
        Me.GrpVoucherPurpose.SuspendLayout()
        CType(Me.GrdVoucherPurpose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlVoucherPurpose
        '
        Me.PnlVoucherPurpose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlVoucherPurpose.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PnlVoucherPurpose.Controls.Add(Me.LblVoucherPurpose)
        Me.PnlVoucherPurpose.Location = New System.Drawing.Point(1, 0)
        Me.PnlVoucherPurpose.Name = "PnlVoucherPurpose"
        Me.PnlVoucherPurpose.Size = New System.Drawing.Size(806, 84)
        Me.PnlVoucherPurpose.TabIndex = 3
        '
        'LblVoucherPurpose
        '
        Me.LblVoucherPurpose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblVoucherPurpose.AutoSize = True
        Me.LblVoucherPurpose.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVoucherPurpose.ForeColor = System.Drawing.Color.White
        Me.LblVoucherPurpose.Location = New System.Drawing.Point(262, 24)
        Me.LblVoucherPurpose.Name = "LblVoucherPurpose"
        Me.LblVoucherPurpose.Size = New System.Drawing.Size(280, 37)
        Me.LblVoucherPurpose.TabIndex = 0
        Me.LblVoucherPurpose.Text = "Voucher Purpose"
        '
        'TxtVoucherPurposeID
        '
        Me.TxtVoucherPurposeID.Enabled = False
        Me.TxtVoucherPurposeID.Location = New System.Drawing.Point(165, 24)
        Me.TxtVoucherPurposeID.Name = "TxtVoucherPurposeID"
        Me.TxtVoucherPurposeID.Size = New System.Drawing.Size(68, 20)
        Me.TxtVoucherPurposeID.TabIndex = 101
        '
        'LblVoucherPurposeID
        '
        Me.LblVoucherPurposeID.AutoSize = True
        Me.LblVoucherPurposeID.Location = New System.Drawing.Point(24, 27)
        Me.LblVoucherPurposeID.Name = "LblVoucherPurposeID"
        Me.LblVoucherPurposeID.Size = New System.Drawing.Size(106, 13)
        Me.LblVoucherPurposeID.TabIndex = 171
        Me.LblVoucherPurposeID.Text = "Voucher Purpose ID:"
        '
        'TxtVoucherPurposeName
        '
        Me.TxtVoucherPurposeName.Location = New System.Drawing.Point(165, 49)
        Me.TxtVoucherPurposeName.Name = "TxtVoucherPurposeName"
        Me.TxtVoucherPurposeName.Size = New System.Drawing.Size(155, 20)
        Me.TxtVoucherPurposeName.TabIndex = 102
        '
        'LblVoucherPurposeName
        '
        Me.LblVoucherPurposeName.AutoSize = True
        Me.LblVoucherPurposeName.Location = New System.Drawing.Point(24, 52)
        Me.LblVoucherPurposeName.Name = "LblVoucherPurposeName"
        Me.LblVoucherPurposeName.Size = New System.Drawing.Size(123, 13)
        Me.LblVoucherPurposeName.TabIndex = 173
        Me.LblVoucherPurposeName.Text = "Voucher Purpose Name:"
        '
        'GrpVoucherPurpose
        '
        Me.GrpVoucherPurpose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpVoucherPurpose.Controls.Add(Me.Label1)
        Me.GrpVoucherPurpose.Controls.Add(Me.TxtVoucherPurposeName)
        Me.GrpVoucherPurpose.Controls.Add(Me.LblVoucherPurposeName)
        Me.GrpVoucherPurpose.Controls.Add(Me.TxtVoucherPurposeID)
        Me.GrpVoucherPurpose.Controls.Add(Me.LblVoucherPurposeID)
        Me.GrpVoucherPurpose.Location = New System.Drawing.Point(16, 143)
        Me.GrpVoucherPurpose.Name = "GrpVoucherPurpose"
        Me.GrpVoucherPurpose.Size = New System.Drawing.Size(771, 88)
        Me.GrpVoucherPurpose.TabIndex = 174
        Me.GrpVoucherPurpose.TabStop = False
        Me.GrpVoucherPurpose.Text = "Voucher Purpose"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(146, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 24)
        Me.Label1.TabIndex = 2017
        Me.Label1.Text = "*"
        '
        'GrdVoucherPurpose
        '
        Me.GrdVoucherPurpose.AllowUserToAddRows = False
        Me.GrdVoucherPurpose.AllowUserToDeleteRows = False
        Me.GrdVoucherPurpose.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdVoucherPurpose.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GrdVoucherPurpose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdVoucherPurpose.Location = New System.Drawing.Point(16, 250)
        Me.GrdVoucherPurpose.Name = "GrdVoucherPurpose"
        Me.GrdVoucherPurpose.ReadOnly = True
        Me.GrdVoucherPurpose.Size = New System.Drawing.Size(771, 236)
        Me.GrdVoucherPurpose.TabIndex = 175
        '
        'BtnRefrersh
        '
        Me.BtnRefrersh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRefrersh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefrersh.Image = Global.Business_Expert_Pro.My.Resources.Resources.icon_ios7_refresh_empty_128__1_
        Me.BtnRefrersh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRefrersh.Location = New System.Drawing.Point(301, 98)
        Me.BtnRefrersh.Name = "BtnRefrersh"
        Me.BtnRefrersh.Size = New System.Drawing.Size(89, 39)
        Me.BtnRefrersh.TabIndex = 1079
        Me.BtnRefrersh.Text = "Refresh"
        Me.BtnRefrersh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRefrersh.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Image = Global.Business_Expert_Pro.My.Resources.Resources.Save1
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(453, 98)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(89, 39)
        Me.BtnSave.TabIndex = 179
        Me.BtnSave.Text = "Insert"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Image = Global.Business_Expert_Pro.My.Resources.Resources.Edit1
        Me.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUpdate.Location = New System.Drawing.Point(113, 98)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(89, 39)
        Me.BtnUpdate.TabIndex = 178
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Image = Global.Business_Expert_Pro.My.Resources.Resources.Delete1
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(207, 98)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(89, 39)
        Me.BtnDelete.TabIndex = 177
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
        Me.BtnAddNew.Location = New System.Drawing.Point(19, 98)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(89, 39)
        Me.BtnAddNew.TabIndex = 176
        Me.BtnAddNew.Text = "Add New"
        Me.BtnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'FrmVoucherPurpose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(799, 498)
        Me.Controls.Add(Me.BtnRefrersh)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.GrdVoucherPurpose)
        Me.Controls.Add(Me.GrpVoucherPurpose)
        Me.Controls.Add(Me.PnlVoucherPurpose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmVoucherPurpose"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Voucher Purpose"
        Me.PnlVoucherPurpose.ResumeLayout(False)
        Me.PnlVoucherPurpose.PerformLayout()
        Me.GrpVoucherPurpose.ResumeLayout(False)
        Me.GrpVoucherPurpose.PerformLayout()
        CType(Me.GrdVoucherPurpose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlVoucherPurpose As System.Windows.Forms.Panel
    Friend WithEvents LblVoucherPurpose As System.Windows.Forms.Label
    Friend WithEvents TxtVoucherPurposeID As System.Windows.Forms.TextBox
    Friend WithEvents LblVoucherPurposeID As System.Windows.Forms.Label
    Friend WithEvents TxtVoucherPurposeName As System.Windows.Forms.TextBox
    Friend WithEvents LblVoucherPurposeName As System.Windows.Forms.Label
    Friend WithEvents GrpVoucherPurpose As System.Windows.Forms.GroupBox
    Friend WithEvents GrdVoucherPurpose As System.Windows.Forms.DataGridView
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
    Friend WithEvents BtnRefrersh As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
