<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPermissionSetup
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
        Me.PnlPaymentMethod = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.LblPermissionSetup = New System.Windows.Forms.Label
        Me.LblUserAccountID = New System.Windows.Forms.Label
        Me.LblCategoryName = New System.Windows.Forms.Label
        Me.CmbUserAccountID = New System.Windows.Forms.ComboBox
        Me.CmbCategoryName = New System.Windows.Forms.ComboBox
        Me.GrpPermissionSetup = New System.Windows.Forms.GroupBox
        Me.BtnAllPermission = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.CmbUpdateDeletePermission = New System.Windows.Forms.ComboBox
        Me.LblUpdateDeletePermission = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtPermissionID = New System.Windows.Forms.TextBox
        Me.LblPermissionID = New System.Windows.Forms.Label
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.CmbSearchCmb = New System.Windows.Forms.ComboBox
        Me.LblTotalAmount = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnRefresh = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.BtnDeleteAll = New System.Windows.Forms.Button
        Me.BtnAddNew = New System.Windows.Forms.Button
        Me.TxtSearch = New System.Windows.Forms.TextBox
        Me.GrdPermissionSetup = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.PnlPaymentMethod.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GrpPermissionSetup.SuspendLayout()
        CType(Me.GrdPermissionSetup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlPaymentMethod
        '
        Me.PnlPaymentMethod.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlPaymentMethod.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlPaymentMethod.Controls.Add(Me.Panel1)
        Me.PnlPaymentMethod.Controls.Add(Me.LblPermissionSetup)
        Me.PnlPaymentMethod.Location = New System.Drawing.Point(0, 0)
        Me.PnlPaymentMethod.Name = "PnlPaymentMethod"
        Me.PnlPaymentMethod.Size = New System.Drawing.Size(876, 96)
        Me.PnlPaymentMethod.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Btnclose)
        Me.Panel1.Controls.Add(Me.Btnminimized)
        Me.Panel1.Controls.Add(Me.Btnmaximized)
        Me.Panel1.Location = New System.Drawing.Point(-1, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(874, 34)
        Me.Panel1.TabIndex = 7
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(850, 5)
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
        Me.Btnminimized.Location = New System.Drawing.Point(790, 5)
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
        Me.Btnmaximized.Location = New System.Drawing.Point(820, 5)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1160
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'LblPermissionSetup
        '
        Me.LblPermissionSetup.AllowDrop = True
        Me.LblPermissionSetup.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblPermissionSetup.AutoSize = True
        Me.LblPermissionSetup.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPermissionSetup.ForeColor = System.Drawing.Color.White
        Me.LblPermissionSetup.Location = New System.Drawing.Point(297, 42)
        Me.LblPermissionSetup.Name = "LblPermissionSetup"
        Me.LblPermissionSetup.Size = New System.Drawing.Size(283, 37)
        Me.LblPermissionSetup.TabIndex = 1
        Me.LblPermissionSetup.Text = "Permission Setup"
        '
        'LblUserAccountID
        '
        Me.LblUserAccountID.AutoSize = True
        Me.LblUserAccountID.Location = New System.Drawing.Point(32, 53)
        Me.LblUserAccountID.Name = "LblUserAccountID"
        Me.LblUserAccountID.Size = New System.Drawing.Size(89, 13)
        Me.LblUserAccountID.TabIndex = 4
        Me.LblUserAccountID.Text = "User Account ID:"
        '
        'LblCategoryName
        '
        Me.LblCategoryName.AutoSize = True
        Me.LblCategoryName.Location = New System.Drawing.Point(32, 81)
        Me.LblCategoryName.Name = "LblCategoryName"
        Me.LblCategoryName.Size = New System.Drawing.Size(83, 13)
        Me.LblCategoryName.TabIndex = 5
        Me.LblCategoryName.Text = "Category Name:"
        '
        'CmbUserAccountID
        '
        Me.CmbUserAccountID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbUserAccountID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbUserAccountID.FormattingEnabled = True
        Me.CmbUserAccountID.Location = New System.Drawing.Point(189, 52)
        Me.CmbUserAccountID.Name = "CmbUserAccountID"
        Me.CmbUserAccountID.Size = New System.Drawing.Size(183, 21)
        Me.CmbUserAccountID.TabIndex = 202
        '
        'CmbCategoryName
        '
        Me.CmbCategoryName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbCategoryName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbCategoryName.FormattingEnabled = True
        Me.CmbCategoryName.Location = New System.Drawing.Point(189, 80)
        Me.CmbCategoryName.Name = "CmbCategoryName"
        Me.CmbCategoryName.Size = New System.Drawing.Size(183, 21)
        Me.CmbCategoryName.TabIndex = 203
        '
        'GrpPermissionSetup
        '
        Me.GrpPermissionSetup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpPermissionSetup.Controls.Add(Me.BtnAllPermission)
        Me.GrpPermissionSetup.Controls.Add(Me.Label6)
        Me.GrpPermissionSetup.Controls.Add(Me.Label5)
        Me.GrpPermissionSetup.Controls.Add(Me.CmbUpdateDeletePermission)
        Me.GrpPermissionSetup.Controls.Add(Me.LblUpdateDeletePermission)
        Me.GrpPermissionSetup.Controls.Add(Me.Label4)
        Me.GrpPermissionSetup.Controls.Add(Me.TxtPermissionID)
        Me.GrpPermissionSetup.Controls.Add(Me.LblPermissionID)
        Me.GrpPermissionSetup.Controls.Add(Me.BtnSave)
        Me.GrpPermissionSetup.Controls.Add(Me.CmbCategoryName)
        Me.GrpPermissionSetup.Controls.Add(Me.CmbUserAccountID)
        Me.GrpPermissionSetup.Controls.Add(Me.LblCategoryName)
        Me.GrpPermissionSetup.Controls.Add(Me.LblUserAccountID)
        Me.GrpPermissionSetup.Location = New System.Drawing.Point(12, 185)
        Me.GrpPermissionSetup.Name = "GrpPermissionSetup"
        Me.GrpPermissionSetup.Size = New System.Drawing.Size(853, 147)
        Me.GrpPermissionSetup.TabIndex = 229
        Me.GrpPermissionSetup.TabStop = False
        Me.GrpPermissionSetup.Text = "Permission Setup"
        '
        'BtnAllPermission
        '
        Me.BtnAllPermission.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAllPermission.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAllPermission.Image = Global.Business_Expert_Pro.My.Resources.Resources.Save_32px_32
        Me.BtnAllPermission.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAllPermission.Location = New System.Drawing.Point(545, 88)
        Me.BtnAllPermission.Name = "BtnAllPermission"
        Me.BtnAllPermission.Size = New System.Drawing.Size(89, 40)
        Me.BtnAllPermission.TabIndex = 2022
        Me.BtnAllPermission.Text = "Permit All"
        Me.BtnAllPermission.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAllPermission.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(123, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 24)
        Me.Label6.TabIndex = 2021
        Me.Label6.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Location = New System.Drawing.Point(168, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 24)
        Me.Label5.TabIndex = 2020
        Me.Label5.Text = "*"
        '
        'CmbUpdateDeletePermission
        '
        Me.CmbUpdateDeletePermission.AutoCompleteCustomSource.AddRange(New String() {"YES", "NO"})
        Me.CmbUpdateDeletePermission.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbUpdateDeletePermission.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbUpdateDeletePermission.FormattingEnabled = True
        Me.CmbUpdateDeletePermission.Items.AddRange(New Object() {"YES", "NO"})
        Me.CmbUpdateDeletePermission.Location = New System.Drawing.Point(189, 107)
        Me.CmbUpdateDeletePermission.Name = "CmbUpdateDeletePermission"
        Me.CmbUpdateDeletePermission.Size = New System.Drawing.Size(183, 21)
        Me.CmbUpdateDeletePermission.TabIndex = 204
        '
        'LblUpdateDeletePermission
        '
        Me.LblUpdateDeletePermission.AutoSize = True
        Me.LblUpdateDeletePermission.Location = New System.Drawing.Point(32, 108)
        Me.LblUpdateDeletePermission.Name = "LblUpdateDeletePermission"
        Me.LblUpdateDeletePermission.Size = New System.Drawing.Size(134, 13)
        Me.LblUpdateDeletePermission.TabIndex = 2016
        Me.LblUpdateDeletePermission.Text = "Update/Delete Permission:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(121, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 24)
        Me.Label4.TabIndex = 2019
        Me.Label4.Text = "*"
        '
        'TxtPermissionID
        '
        Me.TxtPermissionID.Enabled = False
        Me.TxtPermissionID.Location = New System.Drawing.Point(189, 24)
        Me.TxtPermissionID.Name = "TxtPermissionID"
        Me.TxtPermissionID.Size = New System.Drawing.Size(121, 20)
        Me.TxtPermissionID.TabIndex = 201
        '
        'LblPermissionID
        '
        Me.LblPermissionID.AutoSize = True
        Me.LblPermissionID.Location = New System.Drawing.Point(32, 25)
        Me.LblPermissionID.Name = "LblPermissionID"
        Me.LblPermissionID.Size = New System.Drawing.Size(74, 13)
        Me.LblPermissionID.TabIndex = 209
        Me.LblPermissionID.Text = "Permission ID:"
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Image = Global.Business_Expert_Pro.My.Resources.Resources.Save_32px_32
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(425, 88)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(89, 40)
        Me.BtnSave.TabIndex = 346
        Me.BtnSave.Text = "Save"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnSearch
        '
        Me.BtnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Image = Global.Business_Expert_Pro.My.Resources.Resources.Button_15_1281
        Me.BtnSearch.Location = New System.Drawing.Point(846, 108)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(19, 19)
        Me.BtnSearch.TabIndex = 1154
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'CmbSearchCmb
        '
        Me.CmbSearchCmb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbSearchCmb.FormattingEnabled = True
        Me.CmbSearchCmb.Items.AddRange(New Object() {"Form Name"})
        Me.CmbSearchCmb.Location = New System.Drawing.Point(581, 108)
        Me.CmbSearchCmb.Name = "CmbSearchCmb"
        Me.CmbSearchCmb.Size = New System.Drawing.Size(116, 21)
        Me.CmbSearchCmb.TabIndex = 1155
        '
        'LblTotalAmount
        '
        Me.LblTotalAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTotalAmount.AutoSize = True
        Me.LblTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblTotalAmount.Location = New System.Drawing.Point(829, 160)
        Me.LblTotalAmount.Name = "LblTotalAmount"
        Me.LblTotalAmount.Size = New System.Drawing.Size(29, 20)
        Me.LblTotalAmount.TabIndex = 2015
        Me.LblTotalAmount.Text = "00"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(633, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(194, 20)
        Me.Label2.TabIndex = 2014
        Me.Label2.Text = "Total Permitted Sector:"
        '
        'BtnRefresh
        '
        Me.BtnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefresh.Image = Global.Business_Expert_Pro.My.Resources.Resources.Reboot_32px1
        Me.BtnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRefresh.Location = New System.Drawing.Point(335, 137)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(93, 40)
        Me.BtnRefresh.TabIndex = 1047
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Image = Global.Business_Expert_Pro.My.Resources.Resources.Edit_File_32px3
        Me.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUpdate.Location = New System.Drawing.Point(110, 137)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(93, 40)
        Me.BtnUpdate.TabIndex = 345
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDeleteAll
        '
        Me.BtnDeleteAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnDeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDeleteAll.Image = Global.Business_Expert_Pro.My.Resources.Resources.Delete_32px3
        Me.BtnDeleteAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDeleteAll.Location = New System.Drawing.Point(209, 137)
        Me.BtnDeleteAll.Name = "BtnDeleteAll"
        Me.BtnDeleteAll.Size = New System.Drawing.Size(93, 40)
        Me.BtnDeleteAll.TabIndex = 344
        Me.BtnDeleteAll.Text = "Delete All"
        Me.BtnDeleteAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDeleteAll.UseVisualStyleBackColor = True
        '
        'BtnAddNew
        '
        Me.BtnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddNew.Image = Global.Business_Expert_Pro.My.Resources.Resources.Add_New2
        Me.BtnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddNew.Location = New System.Drawing.Point(12, 137)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(93, 40)
        Me.BtnAddNew.TabIndex = 343
        Me.BtnAddNew.Text = "Add New"
        Me.BtnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'TxtSearch
        '
        Me.TxtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSearch.Location = New System.Drawing.Point(703, 108)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(137, 20)
        Me.TxtSearch.TabIndex = 2022
        '
        'GrdPermissionSetup
        '
        Me.GrdPermissionSetup.AllowUserToAddRows = False
        Me.GrdPermissionSetup.AllowUserToDeleteRows = False
        Me.GrdPermissionSetup.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdPermissionSetup.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdPermissionSetup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdPermissionSetup.Location = New System.Drawing.Point(12, 338)
        Me.GrdPermissionSetup.Name = "GrdPermissionSetup"
        Me.GrdPermissionSetup.ReadOnly = True
        Me.GrdPermissionSetup.Size = New System.Drawing.Size(853, 281)
        Me.GrdPermissionSetup.TabIndex = 2023
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 622)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 16)
        Me.Label1.TabIndex = 2024
        Me.Label1.Text = "Click 2x for delete single permission"
        '
        'FrmPermissionSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(877, 642)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GrdPermissionSetup)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.LblTotalAmount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbSearchCmb)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnDeleteAll)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.GrpPermissionSetup)
        Me.Controls.Add(Me.PnlPaymentMethod)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPermissionSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Permission Setup"
        Me.PnlPaymentMethod.ResumeLayout(False)
        Me.PnlPaymentMethod.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GrpPermissionSetup.ResumeLayout(False)
        Me.GrpPermissionSetup.PerformLayout()
        CType(Me.GrdPermissionSetup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PnlPaymentMethod As System.Windows.Forms.Panel
    Friend WithEvents LblPermissionSetup As System.Windows.Forms.Label
    Friend WithEvents LblUserAccountID As System.Windows.Forms.Label
    Friend WithEvents LblCategoryName As System.Windows.Forms.Label
    Friend WithEvents CmbUserAccountID As System.Windows.Forms.ComboBox
    Friend WithEvents CmbCategoryName As System.Windows.Forms.ComboBox
    Friend WithEvents GrpPermissionSetup As System.Windows.Forms.GroupBox
    Friend WithEvents TxtPermissionID As System.Windows.Forms.TextBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnDeleteAll As System.Windows.Forms.Button
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LblPermissionID As System.Windows.Forms.Label
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents CmbSearchCmb As System.Windows.Forms.ComboBox
    Friend WithEvents LblTotalAmount As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbUpdateDeletePermission As System.Windows.Forms.ComboBox
    Friend WithEvents LblUpdateDeletePermission As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
    Friend WithEvents GrdPermissionSetup As System.Windows.Forms.DataGridView
    Friend WithEvents BtnAllPermission As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
