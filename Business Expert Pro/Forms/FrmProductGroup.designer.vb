<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProductGroup
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
        Me.GrpProductGroup = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtProductGroupName = New System.Windows.Forms.TextBox
        Me.TxtProductGroupID = New System.Windows.Forms.TextBox
        Me.LblProductGroupName = New System.Windows.Forms.Label
        Me.LblProductGroupID = New System.Windows.Forms.Label
        Me.PnlProductGroup = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.LblProductGroup = New System.Windows.Forms.Label
        Me.BtnInsert = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnAddNew = New System.Windows.Forms.Button
        Me.BtnRefrersh = New System.Windows.Forms.Button
        Me.GrdProductGroup = New System.Windows.Forms.DataGridView
        Me.GrpProductGroup.SuspendLayout()
        Me.PnlProductGroup.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GrdProductGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpProductGroup
        '
        Me.GrpProductGroup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpProductGroup.Controls.Add(Me.Label6)
        Me.GrpProductGroup.Controls.Add(Me.TxtProductGroupName)
        Me.GrpProductGroup.Controls.Add(Me.TxtProductGroupID)
        Me.GrpProductGroup.Controls.Add(Me.LblProductGroupName)
        Me.GrpProductGroup.Controls.Add(Me.LblProductGroupID)
        Me.GrpProductGroup.Location = New System.Drawing.Point(11, 152)
        Me.GrpProductGroup.Name = "GrpProductGroup"
        Me.GrpProductGroup.Size = New System.Drawing.Size(835, 91)
        Me.GrpProductGroup.TabIndex = 214
        Me.GrpProductGroup.TabStop = False
        Me.GrpProductGroup.Text = "Product Group"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(120, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 24)
        Me.Label6.TabIndex = 2029
        Me.Label6.Text = "*"
        '
        'TxtProductGroupName
        '
        Me.TxtProductGroupName.Location = New System.Drawing.Point(143, 55)
        Me.TxtProductGroupName.Name = "TxtProductGroupName"
        Me.TxtProductGroupName.Size = New System.Drawing.Size(177, 20)
        Me.TxtProductGroupName.TabIndex = 1066
        '
        'TxtProductGroupID
        '
        Me.TxtProductGroupID.Enabled = False
        Me.TxtProductGroupID.Location = New System.Drawing.Point(143, 26)
        Me.TxtProductGroupID.Name = "TxtProductGroupID"
        Me.TxtProductGroupID.Size = New System.Drawing.Size(73, 20)
        Me.TxtProductGroupID.TabIndex = 1065
        '
        'LblProductGroupName
        '
        Me.LblProductGroupName.AutoSize = True
        Me.LblProductGroupName.Location = New System.Drawing.Point(14, 59)
        Me.LblProductGroupName.Name = "LblProductGroupName"
        Me.LblProductGroupName.Size = New System.Drawing.Size(110, 13)
        Me.LblProductGroupName.TabIndex = 2
        Me.LblProductGroupName.Text = "Product Group Name:"
        '
        'LblProductGroupID
        '
        Me.LblProductGroupID.AutoSize = True
        Me.LblProductGroupID.Location = New System.Drawing.Point(14, 33)
        Me.LblProductGroupID.Name = "LblProductGroupID"
        Me.LblProductGroupID.Size = New System.Drawing.Size(93, 13)
        Me.LblProductGroupID.TabIndex = 1
        Me.LblProductGroupID.Text = "Product Group ID:"
        '
        'PnlProductGroup
        '
        Me.PnlProductGroup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlProductGroup.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlProductGroup.Controls.Add(Me.Panel1)
        Me.PnlProductGroup.Controls.Add(Me.LblProductGroup)
        Me.PnlProductGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlProductGroup.Location = New System.Drawing.Point(1, 0)
        Me.PnlProductGroup.Name = "PnlProductGroup"
        Me.PnlProductGroup.Size = New System.Drawing.Size(858, 90)
        Me.PnlProductGroup.TabIndex = 212
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Btnclose)
        Me.Panel1.Controls.Add(Me.Btnminimized)
        Me.Panel1.Controls.Add(Me.Btnmaximized)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(856, 32)
        Me.Panel1.TabIndex = 9
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(829, 3)
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
        Me.Btnminimized.Location = New System.Drawing.Point(769, 3)
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
        Me.Btnmaximized.Location = New System.Drawing.Point(799, 3)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1160
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'LblProductGroup
        '
        Me.LblProductGroup.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblProductGroup.AutoSize = True
        Me.LblProductGroup.ForeColor = System.Drawing.Color.White
        Me.LblProductGroup.Location = New System.Drawing.Point(316, 40)
        Me.LblProductGroup.Name = "LblProductGroup"
        Me.LblProductGroup.Size = New System.Drawing.Size(227, 37)
        Me.LblProductGroup.TabIndex = 2
        Me.LblProductGroup.Text = "Product Group"
        '
        'BtnInsert
        '
        Me.BtnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInsert.Image = Global.Business_Expert_Pro.My.Resources.Resources.Save_32px_32
        Me.BtnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInsert.Location = New System.Drawing.Point(433, 100)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(89, 39)
        Me.BtnInsert.TabIndex = 1074
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
        Me.BtnUpdate.Location = New System.Drawing.Point(107, 100)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(89, 39)
        Me.BtnUpdate.TabIndex = 1075
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
        Me.BtnDelete.Location = New System.Drawing.Point(202, 100)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(89, 39)
        Me.BtnDelete.TabIndex = 1077
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
        Me.BtnAddNew.Location = New System.Drawing.Point(12, 100)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(89, 39)
        Me.BtnAddNew.TabIndex = 1076
        Me.BtnAddNew.Text = "Add New"
        Me.BtnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'BtnRefrersh
        '
        Me.BtnRefrersh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRefrersh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefrersh.Image = Global.Business_Expert_Pro.My.Resources.Resources.Reboot_32px2
        Me.BtnRefrersh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRefrersh.Location = New System.Drawing.Point(297, 100)
        Me.BtnRefrersh.Name = "BtnRefrersh"
        Me.BtnRefrersh.Size = New System.Drawing.Size(89, 39)
        Me.BtnRefrersh.TabIndex = 1078
        Me.BtnRefrersh.Text = "Refresh"
        Me.BtnRefrersh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRefrersh.UseVisualStyleBackColor = True
        '
        'GrdProductGroup
        '
        Me.GrdProductGroup.AllowUserToAddRows = False
        Me.GrdProductGroup.AllowUserToDeleteRows = False
        Me.GrdProductGroup.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdProductGroup.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdProductGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdProductGroup.Location = New System.Drawing.Point(11, 253)
        Me.GrdProductGroup.Name = "GrdProductGroup"
        Me.GrdProductGroup.ReadOnly = True
        Me.GrdProductGroup.Size = New System.Drawing.Size(835, 263)
        Me.GrdProductGroup.TabIndex = 1079
        '
        'FrmProductGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(857, 524)
        Me.Controls.Add(Me.GrdProductGroup)
        Me.Controls.Add(Me.BtnRefrersh)
        Me.Controls.Add(Me.BtnInsert)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.GrpProductGroup)
        Me.Controls.Add(Me.PnlProductGroup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmProductGroup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Group"
        Me.GrpProductGroup.ResumeLayout(False)
        Me.GrpProductGroup.PerformLayout()
        Me.PnlProductGroup.ResumeLayout(False)
        Me.PnlProductGroup.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.GrdProductGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpProductGroup As System.Windows.Forms.GroupBox
    Friend WithEvents TxtProductGroupName As System.Windows.Forms.TextBox
    Friend WithEvents TxtProductGroupID As System.Windows.Forms.TextBox
    Friend WithEvents LblProductGroupName As System.Windows.Forms.Label
    Friend WithEvents LblProductGroupID As System.Windows.Forms.Label
    Friend WithEvents PnlProductGroup As System.Windows.Forms.Panel
    Friend WithEvents LblProductGroup As System.Windows.Forms.Label
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
    Friend WithEvents GrdProductGroup As System.Windows.Forms.DataGridView
End Class
