<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCustomerCategory
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
        Me.LblCustomerCategoryID = New System.Windows.Forms.Label
        Me.LblCustomerCategoryName = New System.Windows.Forms.Label
        Me.TxtCustomerCategoryID = New System.Windows.Forms.TextBox
        Me.PnlCustomerCategory = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.LblCustomerCategory = New System.Windows.Forms.Label
        Me.TxtCustomerCategoryName = New System.Windows.Forms.TextBox
        Me.GrpCustomerCategory = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.BtnInsert = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnAddNew = New System.Windows.Forms.Button
        Me.BtnRefrersh = New System.Windows.Forms.Button
        Me.GrdCustomerCategory = New System.Windows.Forms.DataGridView
        Me.PnlCustomerCategory.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GrpCustomerCategory.SuspendLayout()
        CType(Me.GrdCustomerCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblCustomerCategoryID
        '
        Me.LblCustomerCategoryID.AutoSize = True
        Me.LblCustomerCategoryID.Location = New System.Drawing.Point(32, 30)
        Me.LblCustomerCategoryID.Name = "LblCustomerCategoryID"
        Me.LblCustomerCategoryID.Size = New System.Drawing.Size(113, 13)
        Me.LblCustomerCategoryID.TabIndex = 0
        Me.LblCustomerCategoryID.Text = "Customer Category ID:"
        '
        'LblCustomerCategoryName
        '
        Me.LblCustomerCategoryName.AutoSize = True
        Me.LblCustomerCategoryName.Location = New System.Drawing.Point(32, 57)
        Me.LblCustomerCategoryName.Name = "LblCustomerCategoryName"
        Me.LblCustomerCategoryName.Size = New System.Drawing.Size(130, 13)
        Me.LblCustomerCategoryName.TabIndex = 1
        Me.LblCustomerCategoryName.Text = "Customer Category Name:"
        '
        'TxtCustomerCategoryID
        '
        Me.TxtCustomerCategoryID.Enabled = False
        Me.TxtCustomerCategoryID.Location = New System.Drawing.Point(186, 27)
        Me.TxtCustomerCategoryID.Name = "TxtCustomerCategoryID"
        Me.TxtCustomerCategoryID.Size = New System.Drawing.Size(65, 20)
        Me.TxtCustomerCategoryID.TabIndex = 501
        '
        'PnlCustomerCategory
        '
        Me.PnlCustomerCategory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlCustomerCategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlCustomerCategory.Controls.Add(Me.Panel1)
        Me.PnlCustomerCategory.Controls.Add(Me.LblCustomerCategory)
        Me.PnlCustomerCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlCustomerCategory.Location = New System.Drawing.Point(-5, -1)
        Me.PnlCustomerCategory.Name = "PnlCustomerCategory"
        Me.PnlCustomerCategory.Size = New System.Drawing.Size(840, 101)
        Me.PnlCustomerCategory.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Btnclose)
        Me.Panel1.Controls.Add(Me.Btnminimized)
        Me.Panel1.Controls.Add(Me.Btnmaximized)
        Me.Panel1.Location = New System.Drawing.Point(3, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(834, 29)
        Me.Panel1.TabIndex = 5
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(807, 1)
        Me.Btnclose.Name = "Btnclose"
        Me.Btnclose.Size = New System.Drawing.Size(24, 24)
        Me.Btnclose.TabIndex = 1159
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
        Me.Btnminimized.Location = New System.Drawing.Point(756, 1)
        Me.Btnminimized.Name = "Btnminimized"
        Me.Btnminimized.Size = New System.Drawing.Size(24, 24)
        Me.Btnminimized.TabIndex = 1158
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
        Me.Btnmaximized.Location = New System.Drawing.Point(781, 1)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1157
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'LblCustomerCategory
        '
        Me.LblCustomerCategory.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblCustomerCategory.AutoSize = True
        Me.LblCustomerCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCustomerCategory.ForeColor = System.Drawing.Color.White
        Me.LblCustomerCategory.Location = New System.Drawing.Point(264, 45)
        Me.LblCustomerCategory.Name = "LblCustomerCategory"
        Me.LblCustomerCategory.Size = New System.Drawing.Size(311, 37)
        Me.LblCustomerCategory.TabIndex = 1
        Me.LblCustomerCategory.Text = "Customer Category"
        '
        'TxtCustomerCategoryName
        '
        Me.TxtCustomerCategoryName.Location = New System.Drawing.Point(186, 54)
        Me.TxtCustomerCategoryName.Name = "TxtCustomerCategoryName"
        Me.TxtCustomerCategoryName.Size = New System.Drawing.Size(236, 20)
        Me.TxtCustomerCategoryName.TabIndex = 502
        '
        'GrpCustomerCategory
        '
        Me.GrpCustomerCategory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpCustomerCategory.Controls.Add(Me.Label6)
        Me.GrpCustomerCategory.Controls.Add(Me.TxtCustomerCategoryName)
        Me.GrpCustomerCategory.Controls.Add(Me.TxtCustomerCategoryID)
        Me.GrpCustomerCategory.Controls.Add(Me.LblCustomerCategoryName)
        Me.GrpCustomerCategory.Controls.Add(Me.LblCustomerCategoryID)
        Me.GrpCustomerCategory.Location = New System.Drawing.Point(6, 177)
        Me.GrpCustomerCategory.Name = "GrpCustomerCategory"
        Me.GrpCustomerCategory.Size = New System.Drawing.Size(818, 87)
        Me.GrpCustomerCategory.TabIndex = 6
        Me.GrpCustomerCategory.TabStop = False
        Me.GrpCustomerCategory.Text = "Customer Category"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(163, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 24)
        Me.Label6.TabIndex = 2029
        Me.Label6.Text = "*"
        '
        'BtnInsert
        '
        Me.BtnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInsert.Image = Global.Business_Expert_Pro.My.Resources.Resources.Save_32px_32
        Me.BtnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInsert.Location = New System.Drawing.Point(407, 117)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(89, 39)
        Me.BtnInsert.TabIndex = 1090
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
        Me.BtnUpdate.Location = New System.Drawing.Point(103, 117)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(89, 39)
        Me.BtnUpdate.TabIndex = 1091
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
        Me.BtnDelete.Location = New System.Drawing.Point(198, 117)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(89, 39)
        Me.BtnDelete.TabIndex = 1093
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnAddNew
        '
        Me.BtnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddNew.Image = Global.Business_Expert_Pro.My.Resources.Resources.Add_New2
        Me.BtnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddNew.Location = New System.Drawing.Point(8, 117)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(89, 39)
        Me.BtnAddNew.TabIndex = 1092
        Me.BtnAddNew.Text = "Add New"
        Me.BtnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'BtnRefrersh
        '
        Me.BtnRefrersh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRefrersh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefrersh.Image = Global.Business_Expert_Pro.My.Resources.Resources.Reboot_32px
        Me.BtnRefrersh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRefrersh.Location = New System.Drawing.Point(293, 117)
        Me.BtnRefrersh.Name = "BtnRefrersh"
        Me.BtnRefrersh.Size = New System.Drawing.Size(89, 39)
        Me.BtnRefrersh.TabIndex = 1094
        Me.BtnRefrersh.Text = "Refresh"
        Me.BtnRefrersh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRefrersh.UseVisualStyleBackColor = True
        '
        'GrdCustomerCategory
        '
        Me.GrdCustomerCategory.AllowUserToAddRows = False
        Me.GrdCustomerCategory.AllowUserToDeleteRows = False
        Me.GrdCustomerCategory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdCustomerCategory.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdCustomerCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdCustomerCategory.Location = New System.Drawing.Point(8, 272)
        Me.GrdCustomerCategory.Name = "GrdCustomerCategory"
        Me.GrdCustomerCategory.ReadOnly = True
        Me.GrdCustomerCategory.Size = New System.Drawing.Size(817, 261)
        Me.GrdCustomerCategory.TabIndex = 1095
        '
        'FrmCustomerCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(830, 539)
        Me.Controls.Add(Me.GrdCustomerCategory)
        Me.Controls.Add(Me.BtnRefrersh)
        Me.Controls.Add(Me.BtnInsert)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.GrpCustomerCategory)
        Me.Controls.Add(Me.PnlCustomerCategory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCustomerCategory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Category"
        Me.PnlCustomerCategory.ResumeLayout(False)
        Me.PnlCustomerCategory.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GrpCustomerCategory.ResumeLayout(False)
        Me.GrpCustomerCategory.PerformLayout()
        CType(Me.GrdCustomerCategory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblCustomerCategoryID As System.Windows.Forms.Label
    Friend WithEvents LblCustomerCategoryName As System.Windows.Forms.Label
    Friend WithEvents TxtCustomerCategoryID As System.Windows.Forms.TextBox
    Friend WithEvents PnlCustomerCategory As System.Windows.Forms.Panel
    Friend WithEvents LblCustomerCategory As System.Windows.Forms.Label
    Friend WithEvents TxtCustomerCategoryName As System.Windows.Forms.TextBox
    Friend WithEvents GrpCustomerCategory As System.Windows.Forms.GroupBox
    Friend WithEvents BtnInsert As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnRefrersh As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
    Friend WithEvents GrdCustomerCategory As System.Windows.Forms.DataGridView
End Class
