<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVoucherSubCategory
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
        Me.GrdVoucherSubcategory = New System.Windows.Forms.DataGridView
        Me.GrpVoucherSubcategory = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtVoucherSubcategoryName = New System.Windows.Forms.TextBox
        Me.LblVoucherSubcategoryName = New System.Windows.Forms.Label
        Me.TxtVoucherSubcategoryID = New System.Windows.Forms.TextBox
        Me.LblVoucherSubcategoryID = New System.Windows.Forms.Label
        Me.PnlVoucherSubCategory = New System.Windows.Forms.Panel
        Me.LblVoucherSubcategory = New System.Windows.Forms.Label
        Me.BtnRefrersh = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnAddNew = New System.Windows.Forms.Button
        CType(Me.GrdVoucherSubcategory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpVoucherSubcategory.SuspendLayout()
        Me.PnlVoucherSubCategory.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrdVoucherSubcategory
        '
        Me.GrdVoucherSubcategory.AllowUserToAddRows = False
        Me.GrdVoucherSubcategory.AllowUserToDeleteRows = False
        Me.GrdVoucherSubcategory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdVoucherSubcategory.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GrdVoucherSubcategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdVoucherSubcategory.Location = New System.Drawing.Point(21, 248)
        Me.GrdVoucherSubcategory.Name = "GrdVoucherSubcategory"
        Me.GrdVoucherSubcategory.ReadOnly = True
        Me.GrdVoucherSubcategory.Size = New System.Drawing.Size(758, 238)
        Me.GrdVoucherSubcategory.TabIndex = 1090
        '
        'GrpVoucherSubcategory
        '
        Me.GrpVoucherSubcategory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpVoucherSubcategory.Controls.Add(Me.Label1)
        Me.GrpVoucherSubcategory.Controls.Add(Me.TxtVoucherSubcategoryName)
        Me.GrpVoucherSubcategory.Controls.Add(Me.LblVoucherSubcategoryName)
        Me.GrpVoucherSubcategory.Controls.Add(Me.TxtVoucherSubcategoryID)
        Me.GrpVoucherSubcategory.Controls.Add(Me.LblVoucherSubcategoryID)
        Me.GrpVoucherSubcategory.Location = New System.Drawing.Point(21, 155)
        Me.GrpVoucherSubcategory.Name = "GrpVoucherSubcategory"
        Me.GrpVoucherSubcategory.Size = New System.Drawing.Size(758, 88)
        Me.GrpVoucherSubcategory.TabIndex = 1089
        Me.GrpVoucherSubcategory.TabStop = False
        Me.GrpVoucherSubcategory.Text = "Voucher Subcategory"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(156, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 24)
        Me.Label1.TabIndex = 2017
        Me.Label1.Text = "*"
        '
        'TxtVoucherSubcategoryName
        '
        Me.TxtVoucherSubcategoryName.Location = New System.Drawing.Point(179, 53)
        Me.TxtVoucherSubcategoryName.Name = "TxtVoucherSubcategoryName"
        Me.TxtVoucherSubcategoryName.Size = New System.Drawing.Size(155, 20)
        Me.TxtVoucherSubcategoryName.TabIndex = 102
        '
        'LblVoucherSubcategoryName
        '
        Me.LblVoucherSubcategoryName.AutoSize = True
        Me.LblVoucherSubcategoryName.Location = New System.Drawing.Point(15, 52)
        Me.LblVoucherSubcategoryName.Name = "LblVoucherSubcategoryName"
        Me.LblVoucherSubcategoryName.Size = New System.Drawing.Size(144, 13)
        Me.LblVoucherSubcategoryName.TabIndex = 173
        Me.LblVoucherSubcategoryName.Text = "Voucher Subcategory Name:"
        '
        'TxtVoucherSubcategoryID
        '
        Me.TxtVoucherSubcategoryID.Enabled = False
        Me.TxtVoucherSubcategoryID.Location = New System.Drawing.Point(179, 27)
        Me.TxtVoucherSubcategoryID.Name = "TxtVoucherSubcategoryID"
        Me.TxtVoucherSubcategoryID.Size = New System.Drawing.Size(67, 20)
        Me.TxtVoucherSubcategoryID.TabIndex = 101
        '
        'LblVoucherSubcategoryID
        '
        Me.LblVoucherSubcategoryID.AutoSize = True
        Me.LblVoucherSubcategoryID.Location = New System.Drawing.Point(15, 27)
        Me.LblVoucherSubcategoryID.Name = "LblVoucherSubcategoryID"
        Me.LblVoucherSubcategoryID.Size = New System.Drawing.Size(127, 13)
        Me.LblVoucherSubcategoryID.TabIndex = 171
        Me.LblVoucherSubcategoryID.Text = "Voucher Subcategory ID:"
        '
        'PnlVoucherSubCategory
        '
        Me.PnlVoucherSubCategory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlVoucherSubCategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PnlVoucherSubCategory.Controls.Add(Me.LblVoucherSubcategory)
        Me.PnlVoucherSubCategory.Location = New System.Drawing.Point(-1, 0)
        Me.PnlVoucherSubCategory.Name = "PnlVoucherSubCategory"
        Me.PnlVoucherSubCategory.Size = New System.Drawing.Size(806, 84)
        Me.PnlVoucherSubCategory.TabIndex = 1083
        '
        'LblVoucherSubcategory
        '
        Me.LblVoucherSubcategory.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblVoucherSubcategory.AutoSize = True
        Me.LblVoucherSubcategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVoucherSubcategory.ForeColor = System.Drawing.Color.White
        Me.LblVoucherSubcategory.Location = New System.Drawing.Point(231, 24)
        Me.LblVoucherSubcategory.Name = "LblVoucherSubcategory"
        Me.LblVoucherSubcategory.Size = New System.Drawing.Size(344, 37)
        Me.LblVoucherSubcategory.TabIndex = 0
        Me.LblVoucherSubcategory.Text = "Voucher Subcategory"
        '
        'BtnRefrersh
        '
        Me.BtnRefrersh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRefrersh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefrersh.Image = Global.Business_Expert_Pro.My.Resources.Resources.icon_ios7_refresh_empty_128__1_
        Me.BtnRefrersh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRefrersh.Location = New System.Drawing.Point(310, 104)
        Me.BtnRefrersh.Name = "BtnRefrersh"
        Me.BtnRefrersh.Size = New System.Drawing.Size(90, 39)
        Me.BtnRefrersh.TabIndex = 1088
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
        Me.BtnSave.Location = New System.Drawing.Point(454, 104)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(91, 39)
        Me.BtnSave.TabIndex = 1087
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
        Me.BtnUpdate.Location = New System.Drawing.Point(118, 104)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(90, 39)
        Me.BtnUpdate.TabIndex = 1086
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
        Me.BtnDelete.Location = New System.Drawing.Point(214, 104)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(90, 39)
        Me.BtnDelete.TabIndex = 1085
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
        Me.BtnAddNew.Location = New System.Drawing.Point(21, 104)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(91, 39)
        Me.BtnAddNew.TabIndex = 1084
        Me.BtnAddNew.Text = "Add New"
        Me.BtnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'FrmVoucherSubCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(799, 498)
        Me.Controls.Add(Me.GrdVoucherSubcategory)
        Me.Controls.Add(Me.GrpVoucherSubcategory)
        Me.Controls.Add(Me.BtnRefrersh)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.PnlVoucherSubCategory)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnAddNew)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmVoucherSubCategory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Voucher Subcategory"
        CType(Me.GrdVoucherSubcategory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpVoucherSubcategory.ResumeLayout(False)
        Me.GrpVoucherSubcategory.PerformLayout()
        Me.PnlVoucherSubCategory.ResumeLayout(False)
        Me.PnlVoucherSubCategory.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrdVoucherSubcategory As System.Windows.Forms.DataGridView
    Friend WithEvents GrpVoucherSubcategory As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtVoucherSubcategoryName As System.Windows.Forms.TextBox
    Friend WithEvents LblVoucherSubcategoryName As System.Windows.Forms.Label
    Friend WithEvents TxtVoucherSubcategoryID As System.Windows.Forms.TextBox
    Friend WithEvents LblVoucherSubcategoryID As System.Windows.Forms.Label
    Friend WithEvents BtnRefrersh As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents PnlVoucherSubCategory As System.Windows.Forms.Panel
    Friend WithEvents LblVoucherSubcategory As System.Windows.Forms.Label
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
End Class
