<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProductSubcategory
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
        Me.PnlProductSubcategory = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.LblProductSubcategory = New System.Windows.Forms.Label
        Me.LblProductSubcategoryID = New System.Windows.Forms.Label
        Me.LblProductSubcategoryName = New System.Windows.Forms.Label
        Me.TxtProductSubcategoryID = New System.Windows.Forms.TextBox
        Me.TxtProductSubcategoryName = New System.Windows.Forms.TextBox
        Me.GrpProductSubcategory = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.BtnRefrersh = New System.Windows.Forms.Button
        Me.BtnInsert = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnAddNew = New System.Windows.Forms.Button
        Me.GrdProductSubcategory = New System.Windows.Forms.DataGridView
        Me.PnlProductSubcategory.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GrpProductSubcategory.SuspendLayout()
        CType(Me.GrdProductSubcategory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlProductSubcategory
        '
        Me.PnlProductSubcategory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlProductSubcategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlProductSubcategory.Controls.Add(Me.Panel1)
        Me.PnlProductSubcategory.Controls.Add(Me.LblProductSubcategory)
        Me.PnlProductSubcategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlProductSubcategory.Location = New System.Drawing.Point(-3, -1)
        Me.PnlProductSubcategory.Name = "PnlProductSubcategory"
        Me.PnlProductSubcategory.Size = New System.Drawing.Size(863, 84)
        Me.PnlProductSubcategory.TabIndex = 234
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Btnclose)
        Me.Panel1.Controls.Add(Me.Btnminimized)
        Me.Panel1.Controls.Add(Me.Btnmaximized)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(859, 29)
        Me.Panel1.TabIndex = 132
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(835, 2)
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
        Me.Btnminimized.Location = New System.Drawing.Point(775, 2)
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
        Me.Btnmaximized.Location = New System.Drawing.Point(805, 2)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1160
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'LblProductSubcategory
        '
        Me.LblProductSubcategory.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblProductSubcategory.AutoSize = True
        Me.LblProductSubcategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProductSubcategory.ForeColor = System.Drawing.Color.White
        Me.LblProductSubcategory.Location = New System.Drawing.Point(264, 35)
        Me.LblProductSubcategory.Name = "LblProductSubcategory"
        Me.LblProductSubcategory.Size = New System.Drawing.Size(335, 37)
        Me.LblProductSubcategory.TabIndex = 2
        Me.LblProductSubcategory.Text = "Product Subcategory"
        '
        'LblProductSubcategoryID
        '
        Me.LblProductSubcategoryID.AutoSize = True
        Me.LblProductSubcategoryID.Location = New System.Drawing.Point(51, 36)
        Me.LblProductSubcategoryID.Name = "LblProductSubcategoryID"
        Me.LblProductSubcategoryID.Size = New System.Drawing.Size(124, 13)
        Me.LblProductSubcategoryID.TabIndex = 1
        Me.LblProductSubcategoryID.Text = "Product Subcategory ID:"
        '
        'LblProductSubcategoryName
        '
        Me.LblProductSubcategoryName.AutoSize = True
        Me.LblProductSubcategoryName.Location = New System.Drawing.Point(51, 58)
        Me.LblProductSubcategoryName.Name = "LblProductSubcategoryName"
        Me.LblProductSubcategoryName.Size = New System.Drawing.Size(141, 13)
        Me.LblProductSubcategoryName.TabIndex = 2
        Me.LblProductSubcategoryName.Text = "Product Subcategory Name:"
        '
        'TxtProductSubcategoryID
        '
        Me.TxtProductSubcategoryID.Enabled = False
        Me.TxtProductSubcategoryID.Location = New System.Drawing.Point(207, 29)
        Me.TxtProductSubcategoryID.Name = "TxtProductSubcategoryID"
        Me.TxtProductSubcategoryID.Size = New System.Drawing.Size(73, 20)
        Me.TxtProductSubcategoryID.TabIndex = 201
        '
        'TxtProductSubcategoryName
        '
        Me.TxtProductSubcategoryName.Location = New System.Drawing.Point(207, 55)
        Me.TxtProductSubcategoryName.Name = "TxtProductSubcategoryName"
        Me.TxtProductSubcategoryName.Size = New System.Drawing.Size(213, 20)
        Me.TxtProductSubcategoryName.TabIndex = 202
        '
        'GrpProductSubcategory
        '
        Me.GrpProductSubcategory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpProductSubcategory.Controls.Add(Me.Label6)
        Me.GrpProductSubcategory.Controls.Add(Me.TxtProductSubcategoryName)
        Me.GrpProductSubcategory.Controls.Add(Me.TxtProductSubcategoryID)
        Me.GrpProductSubcategory.Controls.Add(Me.LblProductSubcategoryName)
        Me.GrpProductSubcategory.Controls.Add(Me.LblProductSubcategoryID)
        Me.GrpProductSubcategory.Location = New System.Drawing.Point(7, 160)
        Me.GrpProductSubcategory.Name = "GrpProductSubcategory"
        Me.GrpProductSubcategory.Size = New System.Drawing.Size(838, 91)
        Me.GrpProductSubcategory.TabIndex = 236
        Me.GrpProductSubcategory.TabStop = False
        Me.GrpProductSubcategory.Text = "Product Subcategory"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(184, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 24)
        Me.Label6.TabIndex = 2029
        Me.Label6.Text = "*"
        '
        'BtnRefrersh
        '
        Me.BtnRefrersh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRefrersh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefrersh.Image = Global.Business_Expert_Pro.My.Resources.Resources.Reboot_32px1
        Me.BtnRefrersh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRefrersh.Location = New System.Drawing.Point(294, 107)
        Me.BtnRefrersh.Name = "BtnRefrersh"
        Me.BtnRefrersh.Size = New System.Drawing.Size(89, 39)
        Me.BtnRefrersh.TabIndex = 238
        Me.BtnRefrersh.Text = "Refresh"
        Me.BtnRefrersh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRefrersh.UseVisualStyleBackColor = True
        '
        'BtnInsert
        '
        Me.BtnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInsert.Image = Global.Business_Expert_Pro.My.Resources.Resources.Save_32px_32
        Me.BtnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInsert.Location = New System.Drawing.Point(411, 107)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(89, 39)
        Me.BtnInsert.TabIndex = 203
        Me.BtnInsert.Text = "Save"
        Me.BtnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnInsert.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Image = Global.Business_Expert_Pro.My.Resources.Resources.Edit_File_32px3
        Me.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUpdate.Location = New System.Drawing.Point(104, 107)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(89, 39)
        Me.BtnUpdate.TabIndex = 204
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Image = Global.Business_Expert_Pro.My.Resources.Resources.Delete_32px1
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(199, 107)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(89, 39)
        Me.BtnDelete.TabIndex = 206
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnAddNew
        '
        Me.BtnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddNew.Image = Global.Business_Expert_Pro.My.Resources.Resources.Add_New3
        Me.BtnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddNew.Location = New System.Drawing.Point(10, 107)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(89, 39)
        Me.BtnAddNew.TabIndex = 205
        Me.BtnAddNew.Text = "Add New"
        Me.BtnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'GrdProductSubcategory
        '
        Me.GrdProductSubcategory.AllowUserToAddRows = False
        Me.GrdProductSubcategory.AllowUserToDeleteRows = False
        Me.GrdProductSubcategory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdProductSubcategory.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdProductSubcategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdProductSubcategory.Location = New System.Drawing.Point(7, 257)
        Me.GrdProductSubcategory.Name = "GrdProductSubcategory"
        Me.GrdProductSubcategory.ReadOnly = True
        Me.GrdProductSubcategory.Size = New System.Drawing.Size(838, 258)
        Me.GrdProductSubcategory.TabIndex = 239
        '
        'FrmProductSubcategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(857, 525)
        Me.Controls.Add(Me.GrdProductSubcategory)
        Me.Controls.Add(Me.BtnRefrersh)
        Me.Controls.Add(Me.BtnInsert)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.GrpProductSubcategory)
        Me.Controls.Add(Me.PnlProductSubcategory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmProductSubcategory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Subcategory"
        Me.PnlProductSubcategory.ResumeLayout(False)
        Me.PnlProductSubcategory.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GrpProductSubcategory.ResumeLayout(False)
        Me.GrpProductSubcategory.PerformLayout()
        CType(Me.GrdProductSubcategory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlProductSubcategory As System.Windows.Forms.Panel
    Friend WithEvents LblProductSubcategory As System.Windows.Forms.Label
    Friend WithEvents LblProductSubcategoryID As System.Windows.Forms.Label
    Friend WithEvents LblProductSubcategoryName As System.Windows.Forms.Label
    Friend WithEvents TxtProductSubcategoryID As System.Windows.Forms.TextBox
    Friend WithEvents TxtProductSubcategoryName As System.Windows.Forms.TextBox
    Friend WithEvents GrpProductSubcategory As System.Windows.Forms.GroupBox
    Friend WithEvents BtnInsert As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
    Friend WithEvents BtnRefrersh As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
    Friend WithEvents GrdProductSubcategory As System.Windows.Forms.DataGridView
End Class
