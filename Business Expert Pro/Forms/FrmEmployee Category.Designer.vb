<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmployeeCategory
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
        Me.PnlEmployeeCategory = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.LblEmployeeCategory = New System.Windows.Forms.Label
        Me.BtnRefrersh = New System.Windows.Forms.Button
        Me.BtnInsert = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnAddNew = New System.Windows.Forms.Button
        Me.GrdEmployeeCategory = New System.Windows.Forms.DataGridView
        Me.GrpEmployeeCategory = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtEmployeeCategoryName = New System.Windows.Forms.TextBox
        Me.TxtEmployeeCategoryID = New System.Windows.Forms.TextBox
        Me.LblEmployeeCategoryName = New System.Windows.Forms.Label
        Me.LblEmployeeCategoryID = New System.Windows.Forms.Label
        Me.PnlEmployeeCategory.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GrdEmployeeCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpEmployeeCategory.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlEmployeeCategory
        '
        Me.PnlEmployeeCategory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlEmployeeCategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlEmployeeCategory.Controls.Add(Me.Panel1)
        Me.PnlEmployeeCategory.Controls.Add(Me.LblEmployeeCategory)
        Me.PnlEmployeeCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlEmployeeCategory.Location = New System.Drawing.Point(-13, 0)
        Me.PnlEmployeeCategory.Name = "PnlEmployeeCategory"
        Me.PnlEmployeeCategory.Size = New System.Drawing.Size(840, 82)
        Me.PnlEmployeeCategory.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Btnclose)
        Me.Panel1.Controls.Add(Me.Btnminimized)
        Me.Panel1.Controls.Add(Me.Btnmaximized)
        Me.Panel1.Location = New System.Drawing.Point(12, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(815, 29)
        Me.Panel1.TabIndex = 5
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(788, 1)
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
        Me.Btnminimized.Location = New System.Drawing.Point(737, 1)
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
        Me.Btnmaximized.Location = New System.Drawing.Point(762, 1)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1157
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'LblEmployeeCategory
        '
        Me.LblEmployeeCategory.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblEmployeeCategory.AutoSize = True
        Me.LblEmployeeCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmployeeCategory.ForeColor = System.Drawing.Color.White
        Me.LblEmployeeCategory.Location = New System.Drawing.Point(264, 30)
        Me.LblEmployeeCategory.Name = "LblEmployeeCategory"
        Me.LblEmployeeCategory.Size = New System.Drawing.Size(312, 37)
        Me.LblEmployeeCategory.TabIndex = 1
        Me.LblEmployeeCategory.Text = "Employee Category"
        '
        'BtnRefrersh
        '
        Me.BtnRefrersh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRefrersh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefrersh.Image = Global.Business_Expert_Pro.My.Resources.Resources.Reboot_32px
        Me.BtnRefrersh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRefrersh.Location = New System.Drawing.Point(288, 88)
        Me.BtnRefrersh.Name = "BtnRefrersh"
        Me.BtnRefrersh.Size = New System.Drawing.Size(89, 39)
        Me.BtnRefrersh.TabIndex = 1099
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
        Me.BtnInsert.Location = New System.Drawing.Point(402, 88)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(89, 39)
        Me.BtnInsert.TabIndex = 1095
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
        Me.BtnUpdate.Location = New System.Drawing.Point(98, 88)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(89, 39)
        Me.BtnUpdate.TabIndex = 1096
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
        Me.BtnDelete.Location = New System.Drawing.Point(193, 88)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(89, 39)
        Me.BtnDelete.TabIndex = 1098
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
        Me.BtnAddNew.Location = New System.Drawing.Point(3, 88)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(89, 39)
        Me.BtnAddNew.TabIndex = 1097
        Me.BtnAddNew.Text = "Add New"
        Me.BtnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'GrdEmployeeCategory
        '
        Me.GrdEmployeeCategory.AllowUserToAddRows = False
        Me.GrdEmployeeCategory.AllowUserToDeleteRows = False
        Me.GrdEmployeeCategory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdEmployeeCategory.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdEmployeeCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdEmployeeCategory.Location = New System.Drawing.Point(2, 239)
        Me.GrdEmployeeCategory.Name = "GrdEmployeeCategory"
        Me.GrdEmployeeCategory.ReadOnly = True
        Me.GrdEmployeeCategory.Size = New System.Drawing.Size(817, 261)
        Me.GrdEmployeeCategory.TabIndex = 1100
        '
        'GrpEmployeeCategory
        '
        Me.GrpEmployeeCategory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpEmployeeCategory.Controls.Add(Me.Label6)
        Me.GrpEmployeeCategory.Controls.Add(Me.TxtEmployeeCategoryName)
        Me.GrpEmployeeCategory.Controls.Add(Me.TxtEmployeeCategoryID)
        Me.GrpEmployeeCategory.Controls.Add(Me.LblEmployeeCategoryName)
        Me.GrpEmployeeCategory.Controls.Add(Me.LblEmployeeCategoryID)
        Me.GrpEmployeeCategory.Location = New System.Drawing.Point(4, 139)
        Me.GrpEmployeeCategory.Name = "GrpEmployeeCategory"
        Me.GrpEmployeeCategory.Size = New System.Drawing.Size(804, 87)
        Me.GrpEmployeeCategory.TabIndex = 1101
        Me.GrpEmployeeCategory.TabStop = False
        Me.GrpEmployeeCategory.Text = "Employee Category"
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
        'TxtEmployeeCategoryName
        '
        Me.TxtEmployeeCategoryName.Location = New System.Drawing.Point(186, 54)
        Me.TxtEmployeeCategoryName.Name = "TxtEmployeeCategoryName"
        Me.TxtEmployeeCategoryName.Size = New System.Drawing.Size(236, 20)
        Me.TxtEmployeeCategoryName.TabIndex = 502
        '
        'TxtEmployeeCategoryID
        '
        Me.TxtEmployeeCategoryID.Enabled = False
        Me.TxtEmployeeCategoryID.Location = New System.Drawing.Point(186, 27)
        Me.TxtEmployeeCategoryID.Name = "TxtEmployeeCategoryID"
        Me.TxtEmployeeCategoryID.Size = New System.Drawing.Size(65, 20)
        Me.TxtEmployeeCategoryID.TabIndex = 501
        '
        'LblEmployeeCategoryName
        '
        Me.LblEmployeeCategoryName.AutoSize = True
        Me.LblEmployeeCategoryName.Location = New System.Drawing.Point(32, 57)
        Me.LblEmployeeCategoryName.Name = "LblEmployeeCategoryName"
        Me.LblEmployeeCategoryName.Size = New System.Drawing.Size(132, 13)
        Me.LblEmployeeCategoryName.TabIndex = 1
        Me.LblEmployeeCategoryName.Text = "Employee Category Name:"
        '
        'LblEmployeeCategoryID
        '
        Me.LblEmployeeCategoryID.AutoSize = True
        Me.LblEmployeeCategoryID.Location = New System.Drawing.Point(32, 30)
        Me.LblEmployeeCategoryID.Name = "LblEmployeeCategoryID"
        Me.LblEmployeeCategoryID.Size = New System.Drawing.Size(115, 13)
        Me.LblEmployeeCategoryID.TabIndex = 0
        Me.LblEmployeeCategoryID.Text = "Employee Category ID:"
        '
        'FrmEmployeeCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(814, 501)
        Me.Controls.Add(Me.GrpEmployeeCategory)
        Me.Controls.Add(Me.GrdEmployeeCategory)
        Me.Controls.Add(Me.BtnRefrersh)
        Me.Controls.Add(Me.BtnInsert)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.PnlEmployeeCategory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmEmployeeCategory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Category"
        Me.PnlEmployeeCategory.ResumeLayout(False)
        Me.PnlEmployeeCategory.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.GrdEmployeeCategory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpEmployeeCategory.ResumeLayout(False)
        Me.GrpEmployeeCategory.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlEmployeeCategory As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
    Friend WithEvents LblEmployeeCategory As System.Windows.Forms.Label
    Friend WithEvents BtnRefrersh As System.Windows.Forms.Button
    Friend WithEvents BtnInsert As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
    Friend WithEvents GrdEmployeeCategory As System.Windows.Forms.DataGridView
    Friend WithEvents GrpEmployeeCategory As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtEmployeeCategoryName As System.Windows.Forms.TextBox
    Friend WithEvents TxtEmployeeCategoryID As System.Windows.Forms.TextBox
    Friend WithEvents LblEmployeeCategoryName As System.Windows.Forms.Label
    Friend WithEvents LblEmployeeCategoryID As System.Windows.Forms.Label
End Class
