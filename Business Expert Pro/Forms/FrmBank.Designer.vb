<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBank
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
        Me.BtnRefrersh = New System.Windows.Forms.Button
        Me.BtnInsert = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnAddNew = New System.Windows.Forms.Button
        Me.GrdBank = New System.Windows.Forms.DataGridView
        Me.GrpBank = New System.Windows.Forms.GroupBox
        Me.TxtBankName = New System.Windows.Forms.TextBox
        Me.LblBankName = New System.Windows.Forms.Label
        Me.TxtBankID = New System.Windows.Forms.TextBox
        Me.LblBankID = New System.Windows.Forms.Label
        Me.PnlBank = New System.Windows.Forms.Panel
        Me.LblBank = New System.Windows.Forms.Label
        CType(Me.GrdBank, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBank.SuspendLayout()
        Me.PnlBank.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnRefrersh
        '
        Me.BtnRefrersh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRefrersh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefrersh.Image = Global.Business_Expert_Pro.My.Resources.Resources.icon_ios7_refresh_empty_128__1_
        Me.BtnRefrersh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRefrersh.Location = New System.Drawing.Point(302, 126)
        Me.BtnRefrersh.Name = "BtnRefrersh"
        Me.BtnRefrersh.Size = New System.Drawing.Size(89, 39)
        Me.BtnRefrersh.TabIndex = 1087
        Me.BtnRefrersh.Text = "Refresh"
        Me.BtnRefrersh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRefrersh.UseVisualStyleBackColor = True
        '
        'BtnInsert
        '
        Me.BtnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInsert.Image = Global.Business_Expert_Pro.My.Resources.Resources.Save1
        Me.BtnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInsert.Location = New System.Drawing.Point(419, 126)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(89, 39)
        Me.BtnInsert.TabIndex = 1086
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
        Me.BtnUpdate.Location = New System.Drawing.Point(112, 126)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(89, 39)
        Me.BtnUpdate.TabIndex = 1085
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
        Me.BtnDelete.Location = New System.Drawing.Point(207, 126)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(89, 39)
        Me.BtnDelete.TabIndex = 1084
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
        Me.BtnAddNew.Location = New System.Drawing.Point(17, 126)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(89, 39)
        Me.BtnAddNew.TabIndex = 1083
        Me.BtnAddNew.Text = "Add New"
        Me.BtnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'GrdBank
        '
        Me.GrdBank.AllowUserToAddRows = False
        Me.GrdBank.AllowUserToDeleteRows = False
        Me.GrdBank.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdBank.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GrdBank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdBank.Location = New System.Drawing.Point(12, 287)
        Me.GrdBank.Name = "GrdBank"
        Me.GrdBank.ReadOnly = True
        Me.GrdBank.Size = New System.Drawing.Size(772, 190)
        Me.GrdBank.TabIndex = 1082
        '
        'GrpBank
        '
        Me.GrpBank.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpBank.Controls.Add(Me.TxtBankName)
        Me.GrpBank.Controls.Add(Me.LblBankName)
        Me.GrpBank.Controls.Add(Me.TxtBankID)
        Me.GrpBank.Controls.Add(Me.LblBankID)
        Me.GrpBank.Location = New System.Drawing.Point(12, 171)
        Me.GrpBank.Name = "GrpBank"
        Me.GrpBank.Size = New System.Drawing.Size(772, 101)
        Me.GrpBank.TabIndex = 1081
        Me.GrpBank.TabStop = False
        Me.GrpBank.Text = "Bank"
        '
        'TxtBankName
        '
        Me.TxtBankName.Location = New System.Drawing.Point(124, 53)
        Me.TxtBankName.Name = "TxtBankName"
        Me.TxtBankName.Size = New System.Drawing.Size(155, 20)
        Me.TxtBankName.TabIndex = 102
        '
        'LblBankName
        '
        Me.LblBankName.AutoSize = True
        Me.LblBankName.Location = New System.Drawing.Point(24, 60)
        Me.LblBankName.Name = "LblBankName"
        Me.LblBankName.Size = New System.Drawing.Size(66, 13)
        Me.LblBankName.TabIndex = 173
        Me.LblBankName.Text = "Bank Name:"
        '
        'TxtBankID
        '
        Me.TxtBankID.Enabled = False
        Me.TxtBankID.Location = New System.Drawing.Point(124, 28)
        Me.TxtBankID.Name = "TxtBankID"
        Me.TxtBankID.Size = New System.Drawing.Size(89, 20)
        Me.TxtBankID.TabIndex = 101
        '
        'LblBankID
        '
        Me.LblBankID.AutoSize = True
        Me.LblBankID.Location = New System.Drawing.Point(22, 35)
        Me.LblBankID.Name = "LblBankID"
        Me.LblBankID.Size = New System.Drawing.Size(49, 13)
        Me.LblBankID.TabIndex = 171
        Me.LblBankID.Text = "Bank ID:"
        '
        'PnlBank
        '
        Me.PnlBank.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlBank.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PnlBank.Controls.Add(Me.LblBank)
        Me.PnlBank.Location = New System.Drawing.Point(-4, 0)
        Me.PnlBank.Name = "PnlBank"
        Me.PnlBank.Size = New System.Drawing.Size(803, 100)
        Me.PnlBank.TabIndex = 1080
        '
        'LblBank
        '
        Me.LblBank.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblBank.AutoSize = True
        Me.LblBank.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBank.ForeColor = System.Drawing.Color.White
        Me.LblBank.Location = New System.Drawing.Point(354, 32)
        Me.LblBank.Name = "LblBank"
        Me.LblBank.Size = New System.Drawing.Size(94, 37)
        Me.LblBank.TabIndex = 0
        Me.LblBank.Text = "Bank"
        '
        'FrmBank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(796, 489)
        Me.Controls.Add(Me.BtnRefrersh)
        Me.Controls.Add(Me.BtnInsert)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.GrdBank)
        Me.Controls.Add(Me.GrpBank)
        Me.Controls.Add(Me.PnlBank)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmBank"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bank"
        CType(Me.GrdBank, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBank.ResumeLayout(False)
        Me.GrpBank.PerformLayout()
        Me.PnlBank.ResumeLayout(False)
        Me.PnlBank.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnRefrersh As System.Windows.Forms.Button
    Friend WithEvents BtnInsert As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
    Friend WithEvents GrdBank As System.Windows.Forms.DataGridView
    Friend WithEvents GrpBank As System.Windows.Forms.GroupBox
    Friend WithEvents TxtBankName As System.Windows.Forms.TextBox
    Friend WithEvents LblBankName As System.Windows.Forms.Label
    Friend WithEvents TxtBankID As System.Windows.Forms.TextBox
    Friend WithEvents LblBankID As System.Windows.Forms.Label
    Friend WithEvents PnlBank As System.Windows.Forms.Panel
    Friend WithEvents LblBank As System.Windows.Forms.Label
End Class
