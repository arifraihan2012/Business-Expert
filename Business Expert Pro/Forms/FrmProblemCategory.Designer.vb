<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProblemCategory
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
        Me.PnlUnit = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.LblProblemCategory = New System.Windows.Forms.Label
        Me.BtnAddNew = New System.Windows.Forms.Button
        Me.GrpProblemCategory = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtProblemCategoryName = New System.Windows.Forms.TextBox
        Me.TxtProblemcategoryID = New System.Windows.Forms.TextBox
        Me.LblProblemCategoryName = New System.Windows.Forms.Label
        Me.LblProblemCategoryID = New System.Windows.Forms.Label
        Me.GrdProblemCategory = New System.Windows.Forms.DataGridView
        Me.PnlUnit.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GrpProblemCategory.SuspendLayout()
        CType(Me.GrdProblemCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnRefrersh
        '
        Me.BtnRefrersh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRefrersh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefrersh.Image = Global.Business_Expert_Pro.My.Resources.Resources.Reboot_32px2
        Me.BtnRefrersh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRefrersh.Location = New System.Drawing.Point(303, 87)
        Me.BtnRefrersh.Name = "BtnRefrersh"
        Me.BtnRefrersh.Size = New System.Drawing.Size(89, 36)
        Me.BtnRefrersh.TabIndex = 1083
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
        Me.BtnInsert.Location = New System.Drawing.Point(439, 87)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(89, 36)
        Me.BtnInsert.TabIndex = 1080
        Me.BtnInsert.Text = "Save"
        Me.BtnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnInsert.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Image = Global.Business_Expert_Pro.My.Resources.Resources.Edit_File_32px2
        Me.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUpdate.Location = New System.Drawing.Point(113, 87)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(89, 36)
        Me.BtnUpdate.TabIndex = 1081
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Image = Global.Business_Expert_Pro.My.Resources.Resources.Delete_32px2
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(208, 87)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(89, 36)
        Me.BtnDelete.TabIndex = 1082
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.UseVisualStyleBackColor = True
        Me.BtnDelete.Visible = False
        '
        'PnlUnit
        '
        Me.PnlUnit.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlUnit.Controls.Add(Me.Panel1)
        Me.PnlUnit.Controls.Add(Me.LblProblemCategory)
        Me.PnlUnit.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlUnit.Location = New System.Drawing.Point(0, 0)
        Me.PnlUnit.Name = "PnlUnit"
        Me.PnlUnit.Size = New System.Drawing.Size(834, 79)
        Me.PnlUnit.TabIndex = 1079
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Btnclose)
        Me.Panel1.Controls.Add(Me.Btnminimized)
        Me.Panel1.Controls.Add(Me.Btnmaximized)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(832, 30)
        Me.Panel1.TabIndex = 8
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(808, 3)
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
        Me.Btnminimized.Location = New System.Drawing.Point(748, 3)
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
        Me.Btnmaximized.Location = New System.Drawing.Point(778, 3)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1160
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'LblProblemCategory
        '
        Me.LblProblemCategory.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblProblemCategory.AutoSize = True
        Me.LblProblemCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProblemCategory.ForeColor = System.Drawing.Color.White
        Me.LblProblemCategory.Location = New System.Drawing.Point(295, 31)
        Me.LblProblemCategory.Name = "LblProblemCategory"
        Me.LblProblemCategory.Size = New System.Drawing.Size(290, 37)
        Me.LblProblemCategory.TabIndex = 2
        Me.LblProblemCategory.Text = "Problem Category"
        '
        'BtnAddNew
        '
        Me.BtnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddNew.Image = Global.Business_Expert_Pro.My.Resources.Resources.Add_New2
        Me.BtnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddNew.Location = New System.Drawing.Point(18, 87)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(89, 36)
        Me.BtnAddNew.TabIndex = 1084
        Me.BtnAddNew.Text = "Add New"
        Me.BtnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'GrpProblemCategory
        '
        Me.GrpProblemCategory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpProblemCategory.Controls.Add(Me.Label6)
        Me.GrpProblemCategory.Controls.Add(Me.TxtProblemCategoryName)
        Me.GrpProblemCategory.Controls.Add(Me.TxtProblemcategoryID)
        Me.GrpProblemCategory.Controls.Add(Me.LblProblemCategoryName)
        Me.GrpProblemCategory.Controls.Add(Me.LblProblemCategoryID)
        Me.GrpProblemCategory.Location = New System.Drawing.Point(10, 133)
        Me.GrpProblemCategory.Name = "GrpProblemCategory"
        Me.GrpProblemCategory.Size = New System.Drawing.Size(812, 109)
        Me.GrpProblemCategory.TabIndex = 1085
        Me.GrpProblemCategory.TabStop = False
        Me.GrpProblemCategory.Text = "Problem Category"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(136, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 24)
        Me.Label6.TabIndex = 2029
        Me.Label6.Text = "*"
        '
        'TxtProblemCategoryName
        '
        Me.TxtProblemCategoryName.Location = New System.Drawing.Point(164, 51)
        Me.TxtProblemCategoryName.Multiline = True
        Me.TxtProblemCategoryName.Name = "TxtProblemCategoryName"
        Me.TxtProblemCategoryName.Size = New System.Drawing.Size(631, 52)
        Me.TxtProblemCategoryName.TabIndex = 1066
        '
        'TxtProblemcategoryID
        '
        Me.TxtProblemcategoryID.Enabled = False
        Me.TxtProblemcategoryID.Location = New System.Drawing.Point(164, 25)
        Me.TxtProblemcategoryID.Name = "TxtProblemcategoryID"
        Me.TxtProblemcategoryID.Size = New System.Drawing.Size(73, 20)
        Me.TxtProblemcategoryID.TabIndex = 1065
        '
        'LblProblemCategoryName
        '
        Me.LblProblemCategoryName.AutoSize = True
        Me.LblProblemCategoryName.Location = New System.Drawing.Point(14, 54)
        Me.LblProblemCategoryName.Name = "LblProblemCategoryName"
        Me.LblProblemCategoryName.Size = New System.Drawing.Size(124, 13)
        Me.LblProblemCategoryName.TabIndex = 2
        Me.LblProblemCategoryName.Text = "Problem Category Name:"
        '
        'LblProblemCategoryID
        '
        Me.LblProblemCategoryID.AutoSize = True
        Me.LblProblemCategoryID.Location = New System.Drawing.Point(14, 28)
        Me.LblProblemCategoryID.Name = "LblProblemCategoryID"
        Me.LblProblemCategoryID.Size = New System.Drawing.Size(107, 13)
        Me.LblProblemCategoryID.TabIndex = 1
        Me.LblProblemCategoryID.Text = "Problem Category ID:"
        '
        'GrdProblemCategory
        '
        Me.GrdProblemCategory.AllowUserToAddRows = False
        Me.GrdProblemCategory.AllowUserToDeleteRows = False
        Me.GrdProblemCategory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdProblemCategory.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdProblemCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdProblemCategory.Location = New System.Drawing.Point(11, 252)
        Me.GrdProblemCategory.Name = "GrdProblemCategory"
        Me.GrdProblemCategory.ReadOnly = True
        Me.GrdProblemCategory.Size = New System.Drawing.Size(811, 199)
        Me.GrdProblemCategory.TabIndex = 1086
        '
        'FrmProblemCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(834, 461)
        Me.Controls.Add(Me.GrdProblemCategory)
        Me.Controls.Add(Me.GrpProblemCategory)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.BtnRefrersh)
        Me.Controls.Add(Me.BtnInsert)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.PnlUnit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmProblemCategory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Problem Category"
        Me.PnlUnit.ResumeLayout(False)
        Me.PnlUnit.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GrpProblemCategory.ResumeLayout(False)
        Me.GrpProblemCategory.PerformLayout()
        CType(Me.GrdProblemCategory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnRefrersh As System.Windows.Forms.Button
    Friend WithEvents BtnInsert As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents PnlUnit As System.Windows.Forms.Panel
    Friend WithEvents LblProblemCategory As System.Windows.Forms.Label
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
    Friend WithEvents GrpProblemCategory As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtProblemCategoryName As System.Windows.Forms.TextBox
    Friend WithEvents TxtProblemcategoryID As System.Windows.Forms.TextBox
    Friend WithEvents LblProblemCategoryName As System.Windows.Forms.Label
    Friend WithEvents LblProblemCategoryID As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
    Friend WithEvents GrdProblemCategory As System.Windows.Forms.DataGridView
End Class
