<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChartofAccount
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
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnRefresh = New System.Windows.Forms.Button
        Me.BtnInsert = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.BtnAddNew = New System.Windows.Forms.Button
        Me.PnlChartofAccount = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.LblChartofAccount = New System.Windows.Forms.Label
        Me.GrpChartofAccount = New System.Windows.Forms.GroupBox
        Me.TxtOpeningBalance = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtAccountName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CmbHeadofAccountID = New System.Windows.Forms.ComboBox
        Me.LblOpeningBalance = New System.Windows.Forms.Label
        Me.LblAccountName = New System.Windows.Forms.Label
        Me.LblHeadofAccountID = New System.Windows.Forms.Label
        Me.TxtChartofAccountID = New System.Windows.Forms.TextBox
        Me.LblChartofAccountID = New System.Windows.Forms.Label
        Me.GrdChartofAccount = New System.Windows.Forms.DataGridView
        Me.PnlChartofAccount.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GrpChartofAccount.SuspendLayout()
        CType(Me.GrdChartofAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnDelete
        '
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.BtnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.BtnDelete.Image = Global.Business_Expert_Pro.My.Resources.Resources.Delete_32px3
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(313, 105)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(94, 36)
        Me.BtnDelete.TabIndex = 53
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.UseVisualStyleBackColor = True
        Me.BtnDelete.Visible = False
        '
        'BtnRefresh
        '
        Me.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.BtnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.BtnRefresh.Image = Global.Business_Expert_Pro.My.Resources.Resources.Reboot_32px
        Me.BtnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRefresh.Location = New System.Drawing.Point(213, 105)
        Me.BtnRefresh.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(94, 36)
        Me.BtnRefresh.TabIndex = 52
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'BtnInsert
        '
        Me.BtnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.BtnInsert.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.BtnInsert.Image = Global.Business_Expert_Pro.My.Resources.Resources.Save_32px_31
        Me.BtnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInsert.Location = New System.Drawing.Point(433, 105)
        Me.BtnInsert.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(94, 36)
        Me.BtnInsert.TabIndex = 54
        Me.BtnInsert.Text = "Save"
        Me.BtnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnInsert.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.BtnUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.BtnUpdate.Image = Global.Business_Expert_Pro.My.Resources.Resources.Edit_File_32px3
        Me.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUpdate.Location = New System.Drawing.Point(114, 105)
        Me.BtnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(94, 36)
        Me.BtnUpdate.TabIndex = 51
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnAddNew
        '
        Me.BtnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.BtnAddNew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.BtnAddNew.Image = Global.Business_Expert_Pro.My.Resources.Resources.Add_New2
        Me.BtnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddNew.Location = New System.Drawing.Point(6, 105)
        Me.BtnAddNew.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(103, 36)
        Me.BtnAddNew.TabIndex = 50
        Me.BtnAddNew.Text = "Add New"
        Me.BtnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'PnlChartofAccount
        '
        Me.PnlChartofAccount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlChartofAccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlChartofAccount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlChartofAccount.Controls.Add(Me.Panel1)
        Me.PnlChartofAccount.Controls.Add(Me.LblChartofAccount)
        Me.PnlChartofAccount.Location = New System.Drawing.Point(0, 0)
        Me.PnlChartofAccount.Name = "PnlChartofAccount"
        Me.PnlChartofAccount.Size = New System.Drawing.Size(833, 90)
        Me.PnlChartofAccount.TabIndex = 49
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Btnclose)
        Me.Panel1.Controls.Add(Me.Btnminimized)
        Me.Panel1.Controls.Add(Me.Btnmaximized)
        Me.Panel1.Location = New System.Drawing.Point(-4, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(833, 28)
        Me.Panel1.TabIndex = 3
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(806, 0)
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
        Me.Btnminimized.Location = New System.Drawing.Point(752, 0)
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
        Me.Btnmaximized.Location = New System.Drawing.Point(779, 0)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1160
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'LblChartofAccount
        '
        Me.LblChartofAccount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblChartofAccount.AutoSize = True
        Me.LblChartofAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblChartofAccount.ForeColor = System.Drawing.SystemColors.Window
        Me.LblChartofAccount.Location = New System.Drawing.Point(272, 35)
        Me.LblChartofAccount.Name = "LblChartofAccount"
        Me.LblChartofAccount.Size = New System.Drawing.Size(284, 37)
        Me.LblChartofAccount.TabIndex = 0
        Me.LblChartofAccount.Text = "Chart of Account "
        '
        'GrpChartofAccount
        '
        Me.GrpChartofAccount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpChartofAccount.Controls.Add(Me.TxtOpeningBalance)
        Me.GrpChartofAccount.Controls.Add(Me.Label1)
        Me.GrpChartofAccount.Controls.Add(Me.TxtAccountName)
        Me.GrpChartofAccount.Controls.Add(Me.Label3)
        Me.GrpChartofAccount.Controls.Add(Me.CmbHeadofAccountID)
        Me.GrpChartofAccount.Controls.Add(Me.LblOpeningBalance)
        Me.GrpChartofAccount.Controls.Add(Me.LblAccountName)
        Me.GrpChartofAccount.Controls.Add(Me.LblHeadofAccountID)
        Me.GrpChartofAccount.Controls.Add(Me.TxtChartofAccountID)
        Me.GrpChartofAccount.Controls.Add(Me.LblChartofAccountID)
        Me.GrpChartofAccount.Location = New System.Drawing.Point(6, 156)
        Me.GrpChartofAccount.Name = "GrpChartofAccount"
        Me.GrpChartofAccount.Size = New System.Drawing.Size(821, 146)
        Me.GrpChartofAccount.TabIndex = 55
        Me.GrpChartofAccount.TabStop = False
        Me.GrpChartofAccount.Text = "Chart of Account"
        '
        'TxtOpeningBalance
        '
        Me.TxtOpeningBalance.Location = New System.Drawing.Point(181, 113)
        Me.TxtOpeningBalance.Name = "TxtOpeningBalance"
        Me.TxtOpeningBalance.Size = New System.Drawing.Size(89, 20)
        Me.TxtOpeningBalance.TabIndex = 104
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(155, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 20)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "*"
        '
        'TxtAccountName
        '
        Me.TxtAccountName.Location = New System.Drawing.Point(181, 83)
        Me.TxtAccountName.Name = "TxtAccountName"
        Me.TxtAccountName.Size = New System.Drawing.Size(185, 20)
        Me.TxtAccountName.TabIndex = 103
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(134, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 20)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "*"
        '
        'CmbHeadofAccountID
        '
        Me.CmbHeadofAccountID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbHeadofAccountID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbHeadofAccountID.FormattingEnabled = True
        Me.CmbHeadofAccountID.Location = New System.Drawing.Point(181, 52)
        Me.CmbHeadofAccountID.Name = "CmbHeadofAccountID"
        Me.CmbHeadofAccountID.Size = New System.Drawing.Size(185, 21)
        Me.CmbHeadofAccountID.TabIndex = 102
        '
        'LblOpeningBalance
        '
        Me.LblOpeningBalance.AutoSize = True
        Me.LblOpeningBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LblOpeningBalance.Location = New System.Drawing.Point(20, 113)
        Me.LblOpeningBalance.Name = "LblOpeningBalance"
        Me.LblOpeningBalance.Size = New System.Drawing.Size(118, 16)
        Me.LblOpeningBalance.TabIndex = 36
        Me.LblOpeningBalance.Text = "Opening Balance :"
        '
        'LblAccountName
        '
        Me.LblAccountName.AutoSize = True
        Me.LblAccountName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LblAccountName.Location = New System.Drawing.Point(20, 83)
        Me.LblAccountName.Name = "LblAccountName"
        Me.LblAccountName.Size = New System.Drawing.Size(102, 16)
        Me.LblAccountName.TabIndex = 33
        Me.LblAccountName.Text = "Account Name :"
        '
        'LblHeadofAccountID
        '
        Me.LblHeadofAccountID.AutoSize = True
        Me.LblHeadofAccountID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LblHeadofAccountID.Location = New System.Drawing.Point(20, 52)
        Me.LblHeadofAccountID.Name = "LblHeadofAccountID"
        Me.LblHeadofAccountID.Size = New System.Drawing.Size(129, 16)
        Me.LblHeadofAccountID.TabIndex = 32
        Me.LblHeadofAccountID.Text = "Head of Account ID :"
        '
        'TxtChartofAccountID
        '
        Me.TxtChartofAccountID.Enabled = False
        Me.TxtChartofAccountID.Location = New System.Drawing.Point(181, 22)
        Me.TxtChartofAccountID.Name = "TxtChartofAccountID"
        Me.TxtChartofAccountID.Size = New System.Drawing.Size(89, 20)
        Me.TxtChartofAccountID.TabIndex = 101
        '
        'LblChartofAccountID
        '
        Me.LblChartofAccountID.AutoSize = True
        Me.LblChartofAccountID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.LblChartofAccountID.Location = New System.Drawing.Point(20, 22)
        Me.LblChartofAccountID.Name = "LblChartofAccountID"
        Me.LblChartofAccountID.Size = New System.Drawing.Size(126, 16)
        Me.LblChartofAccountID.TabIndex = 30
        Me.LblChartofAccountID.Text = "Chart of Account ID :"
        '
        'GrdChartofAccount
        '
        Me.GrdChartofAccount.AllowUserToAddRows = False
        Me.GrdChartofAccount.AllowUserToDeleteRows = False
        Me.GrdChartofAccount.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdChartofAccount.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdChartofAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdChartofAccount.Location = New System.Drawing.Point(7, 309)
        Me.GrdChartofAccount.Name = "GrdChartofAccount"
        Me.GrdChartofAccount.ReadOnly = True
        Me.GrdChartofAccount.Size = New System.Drawing.Size(820, 221)
        Me.GrdChartofAccount.TabIndex = 56
        '
        'FrmChartofAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(832, 538)
        Me.Controls.Add(Me.GrdChartofAccount)
        Me.Controls.Add(Me.GrpChartofAccount)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.BtnInsert)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.PnlChartofAccount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmChartofAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chart of Account"
        Me.PnlChartofAccount.ResumeLayout(False)
        Me.PnlChartofAccount.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GrpChartofAccount.ResumeLayout(False)
        Me.GrpChartofAccount.PerformLayout()
        CType(Me.GrdChartofAccount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button
    Friend WithEvents BtnInsert As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
    Friend WithEvents PnlChartofAccount As System.Windows.Forms.Panel
    Friend WithEvents LblChartofAccount As System.Windows.Forms.Label
    Friend WithEvents GrpChartofAccount As System.Windows.Forms.GroupBox
    Friend WithEvents CmbHeadofAccountID As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblOpeningBalance As System.Windows.Forms.Label
    Friend WithEvents LblAccountName As System.Windows.Forms.Label
    Friend WithEvents LblHeadofAccountID As System.Windows.Forms.Label
    Friend WithEvents TxtChartofAccountID As System.Windows.Forms.TextBox
    Friend WithEvents LblChartofAccountID As System.Windows.Forms.Label
    Friend WithEvents TxtAccountName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtOpeningBalance As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
    Friend WithEvents GrdChartofAccount As System.Windows.Forms.DataGridView

End Class
