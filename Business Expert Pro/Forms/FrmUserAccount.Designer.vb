<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUserAccount
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
        Me.PnlUserAccount = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.LblUserAccount = New System.Windows.Forms.Label
        Me.LblUserAccountID = New System.Windows.Forms.Label
        Me.LblAccountFullName = New System.Windows.Forms.Label
        Me.LblDesignation = New System.Windows.Forms.Label
        Me.TxtUserAccountID = New System.Windows.Forms.TextBox
        Me.TxtDesignation = New System.Windows.Forms.TextBox
        Me.LblUserName = New System.Windows.Forms.Label
        Me.LblPassword = New System.Windows.Forms.Label
        Me.TxtPassword = New System.Windows.Forms.TextBox
        Me.TxtUserName = New System.Windows.Forms.TextBox
        Me.GrpUserAccount = New System.Windows.Forms.GroupBox
        Me.BtnChoose = New System.Windows.Forms.Button
        Me.CmbEmployeeID = New System.Windows.Forms.ComboBox
        Me.BtnClear = New System.Windows.Forms.Button
        Me.PtbUserImage = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbBranchID = New System.Windows.Forms.ComboBox
        Me.TxtStatus = New System.Windows.Forms.TextBox
        Me.LblStatus = New System.Windows.Forms.Label
        Me.LblBranchID = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.lblTotalUserAccount = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.BtnRefrersh = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnAddNew = New System.Windows.Forms.Button
        Me.GrdUserAccount = New System.Windows.Forms.DataGridView
        Me.PnlUserAccount.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GrpUserAccount.SuspendLayout()
        CType(Me.PtbUserImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdUserAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlUserAccount
        '
        Me.PnlUserAccount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlUserAccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlUserAccount.Controls.Add(Me.Panel2)
        Me.PnlUserAccount.Controls.Add(Me.LblUserAccount)
        Me.PnlUserAccount.Location = New System.Drawing.Point(-2, 0)
        Me.PnlUserAccount.Name = "PnlUserAccount"
        Me.PnlUserAccount.Size = New System.Drawing.Size(1021, 81)
        Me.PnlUserAccount.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Btnclose)
        Me.Panel2.Controls.Add(Me.Btnminimized)
        Me.Panel2.Controls.Add(Me.Btnmaximized)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1018, 27)
        Me.Panel2.TabIndex = 2063
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(994, 0)
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
        Me.Btnminimized.Location = New System.Drawing.Point(934, 0)
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
        Me.Btnmaximized.Location = New System.Drawing.Point(964, 0)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1160
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'LblUserAccount
        '
        Me.LblUserAccount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblUserAccount.AutoSize = True
        Me.LblUserAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUserAccount.ForeColor = System.Drawing.Color.White
        Me.LblUserAccount.Location = New System.Drawing.Point(399, 33)
        Me.LblUserAccount.Name = "LblUserAccount"
        Me.LblUserAccount.Size = New System.Drawing.Size(222, 37)
        Me.LblUserAccount.TabIndex = 0
        Me.LblUserAccount.Text = "User Account"
        '
        'LblUserAccountID
        '
        Me.LblUserAccountID.AutoSize = True
        Me.LblUserAccountID.Location = New System.Drawing.Point(12, 22)
        Me.LblUserAccountID.Name = "LblUserAccountID"
        Me.LblUserAccountID.Size = New System.Drawing.Size(92, 13)
        Me.LblUserAccountID.TabIndex = 130
        Me.LblUserAccountID.Text = "User Account  ID:"
        '
        'LblAccountFullName
        '
        Me.LblAccountFullName.AutoSize = True
        Me.LblAccountFullName.Location = New System.Drawing.Point(12, 112)
        Me.LblAccountFullName.Name = "LblAccountFullName"
        Me.LblAccountFullName.Size = New System.Drawing.Size(87, 13)
        Me.LblAccountFullName.TabIndex = 131
        Me.LblAccountFullName.Text = "Employee Name:"
        '
        'LblDesignation
        '
        Me.LblDesignation.AutoSize = True
        Me.LblDesignation.Location = New System.Drawing.Point(12, 145)
        Me.LblDesignation.Name = "LblDesignation"
        Me.LblDesignation.Size = New System.Drawing.Size(66, 13)
        Me.LblDesignation.TabIndex = 132
        Me.LblDesignation.Text = "Designation:"
        '
        'TxtUserAccountID
        '
        Me.TxtUserAccountID.Enabled = False
        Me.TxtUserAccountID.Location = New System.Drawing.Point(136, 19)
        Me.TxtUserAccountID.Name = "TxtUserAccountID"
        Me.TxtUserAccountID.Size = New System.Drawing.Size(86, 20)
        Me.TxtUserAccountID.TabIndex = 101
        '
        'TxtDesignation
        '
        Me.TxtDesignation.Location = New System.Drawing.Point(136, 142)
        Me.TxtDesignation.Name = "TxtDesignation"
        Me.TxtDesignation.Size = New System.Drawing.Size(136, 20)
        Me.TxtDesignation.TabIndex = 105
        '
        'LblUserName
        '
        Me.LblUserName.AutoSize = True
        Me.LblUserName.Location = New System.Drawing.Point(12, 52)
        Me.LblUserName.Name = "LblUserName"
        Me.LblUserName.Size = New System.Drawing.Size(63, 13)
        Me.LblUserName.TabIndex = 133
        Me.LblUserName.Text = "User Name:"
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Location = New System.Drawing.Point(331, 25)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(56, 13)
        Me.LblPassword.TabIndex = 134
        Me.LblPassword.Text = "Password:"
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(444, 22)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(136, 20)
        Me.TxtPassword.TabIndex = 106
        '
        'TxtUserName
        '
        Me.TxtUserName.Location = New System.Drawing.Point(136, 49)
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.Size = New System.Drawing.Size(136, 20)
        Me.TxtUserName.TabIndex = 102
        '
        'GrpUserAccount
        '
        Me.GrpUserAccount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpUserAccount.Controls.Add(Me.BtnChoose)
        Me.GrpUserAccount.Controls.Add(Me.CmbEmployeeID)
        Me.GrpUserAccount.Controls.Add(Me.BtnClear)
        Me.GrpUserAccount.Controls.Add(Me.PtbUserImage)
        Me.GrpUserAccount.Controls.Add(Me.Label1)
        Me.GrpUserAccount.Controls.Add(Me.Label2)
        Me.GrpUserAccount.Controls.Add(Me.Label3)
        Me.GrpUserAccount.Controls.Add(Me.cmbBranchID)
        Me.GrpUserAccount.Controls.Add(Me.TxtStatus)
        Me.GrpUserAccount.Controls.Add(Me.LblStatus)
        Me.GrpUserAccount.Controls.Add(Me.LblBranchID)
        Me.GrpUserAccount.Controls.Add(Me.TxtUserName)
        Me.GrpUserAccount.Controls.Add(Me.TxtPassword)
        Me.GrpUserAccount.Controls.Add(Me.LblPassword)
        Me.GrpUserAccount.Controls.Add(Me.LblUserName)
        Me.GrpUserAccount.Controls.Add(Me.TxtDesignation)
        Me.GrpUserAccount.Controls.Add(Me.TxtUserAccountID)
        Me.GrpUserAccount.Controls.Add(Me.LblDesignation)
        Me.GrpUserAccount.Controls.Add(Me.LblAccountFullName)
        Me.GrpUserAccount.Controls.Add(Me.LblUserAccountID)
        Me.GrpUserAccount.Location = New System.Drawing.Point(14, 152)
        Me.GrpUserAccount.Name = "GrpUserAccount"
        Me.GrpUserAccount.Size = New System.Drawing.Size(990, 177)
        Me.GrpUserAccount.TabIndex = 138
        Me.GrpUserAccount.TabStop = False
        Me.GrpUserAccount.Text = "User Account"
        '
        'BtnChoose
        '
        Me.BtnChoose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnChoose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnChoose.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnChoose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnChoose.Location = New System.Drawing.Point(832, 142)
        Me.BtnChoose.Name = "BtnChoose"
        Me.BtnChoose.Size = New System.Drawing.Size(66, 23)
        Me.BtnChoose.TabIndex = 2078
        Me.BtnChoose.Text = "Choose"
        Me.BtnChoose.UseVisualStyleBackColor = True
        '
        'CmbEmployeeID
        '
        Me.CmbEmployeeID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CmbEmployeeID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbEmployeeID.FormattingEnabled = True
        Me.CmbEmployeeID.Location = New System.Drawing.Point(136, 112)
        Me.CmbEmployeeID.Name = "CmbEmployeeID"
        Me.CmbEmployeeID.Size = New System.Drawing.Size(136, 21)
        Me.CmbEmployeeID.TabIndex = 104
        '
        'BtnClear
        '
        Me.BtnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClear.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClear.Location = New System.Drawing.Point(904, 142)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(66, 23)
        Me.BtnClear.TabIndex = 2077
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'PtbUserImage
        '
        Me.PtbUserImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PtbUserImage.BackgroundImage = Global.Business_Expert_Pro.My.Resources.Resources.worker
        Me.PtbUserImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PtbUserImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PtbUserImage.Cursor = System.Windows.Forms.Cursors.Default
        Me.PtbUserImage.ErrorImage = Nothing
        Me.PtbUserImage.InitialImage = Nothing
        Me.PtbUserImage.Location = New System.Drawing.Point(840, 12)
        Me.PtbUserImage.Name = "PtbUserImage"
        Me.PtbUserImage.Size = New System.Drawing.Size(124, 124)
        Me.PtbUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PtbUserImage.TabIndex = 2076
        Me.PtbUserImage.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(78, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 24)
        Me.Label1.TabIndex = 2017
        Me.Label1.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(74, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 24)
        Me.Label2.TabIndex = 2018
        Me.Label2.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(393, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 24)
        Me.Label3.TabIndex = 2019
        Me.Label3.Text = "*"
        '
        'cmbBranchID
        '
        Me.cmbBranchID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbBranchID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbBranchID.FormattingEnabled = True
        Me.cmbBranchID.Location = New System.Drawing.Point(136, 79)
        Me.cmbBranchID.Name = "cmbBranchID"
        Me.cmbBranchID.Size = New System.Drawing.Size(136, 21)
        Me.cmbBranchID.TabIndex = 103
        '
        'TxtStatus
        '
        Me.TxtStatus.Location = New System.Drawing.Point(444, 54)
        Me.TxtStatus.Name = "TxtStatus"
        Me.TxtStatus.Size = New System.Drawing.Size(136, 20)
        Me.TxtStatus.TabIndex = 107
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Location = New System.Drawing.Point(331, 57)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(40, 13)
        Me.LblStatus.TabIndex = 138
        Me.LblStatus.Text = "Status:"
        '
        'LblBranchID
        '
        Me.LblBranchID.AutoSize = True
        Me.LblBranchID.Location = New System.Drawing.Point(12, 82)
        Me.LblBranchID.Name = "LblBranchID"
        Me.LblBranchID.Size = New System.Drawing.Size(58, 13)
        Me.LblBranchID.TabIndex = 136
        Me.LblBranchID.Text = "Branch ID:"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(958, 127)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(21, 13)
        Me.Label15.TabIndex = 1155
        Me.Label15.Text = "00"
        '
        'lblTotalUserAccount
        '
        Me.lblTotalUserAccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalUserAccount.AutoSize = True
        Me.lblTotalUserAccount.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTotalUserAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalUserAccount.Location = New System.Drawing.Point(814, 125)
        Me.lblTotalUserAccount.Name = "lblTotalUserAccount"
        Me.lblTotalUserAccount.Size = New System.Drawing.Size(125, 16)
        Me.lblTotalUserAccount.TabIndex = 1154
        Me.lblTotalUserAccount.Text = "Total User Account:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BtnRefrersh
        '
        Me.BtnRefrersh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRefrersh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefrersh.Image = Global.Business_Expert_Pro.My.Resources.Resources.Reboot_32px1
        Me.BtnRefrersh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRefrersh.Location = New System.Drawing.Point(300, 92)
        Me.BtnRefrersh.Name = "BtnRefrersh"
        Me.BtnRefrersh.Size = New System.Drawing.Size(89, 39)
        Me.BtnRefrersh.TabIndex = 1090
        Me.BtnRefrersh.Text = "Refresh"
        Me.BtnRefrersh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRefrersh.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Image = Global.Business_Expert_Pro.My.Resources.Resources.Save_32px_32
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(458, 92)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(91, 39)
        Me.BtnSave.TabIndex = 350
        Me.BtnSave.Text = "Save"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Image = Global.Business_Expert_Pro.My.Resources.Resources.Edit_File_32px3
        Me.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUpdate.Location = New System.Drawing.Point(108, 92)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(91, 39)
        Me.BtnUpdate.TabIndex = 349
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
        Me.BtnDelete.Location = New System.Drawing.Point(205, 92)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(89, 39)
        Me.BtnDelete.TabIndex = 348
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
        Me.BtnAddNew.Location = New System.Drawing.Point(13, 92)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(89, 39)
        Me.BtnAddNew.TabIndex = 347
        Me.BtnAddNew.Text = "Add New"
        Me.BtnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'GrdUserAccount
        '
        Me.GrdUserAccount.AllowUserToAddRows = False
        Me.GrdUserAccount.AllowUserToDeleteRows = False
        Me.GrdUserAccount.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdUserAccount.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdUserAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdUserAccount.Location = New System.Drawing.Point(14, 335)
        Me.GrdUserAccount.Name = "GrdUserAccount"
        Me.GrdUserAccount.ReadOnly = True
        Me.GrdUserAccount.Size = New System.Drawing.Size(990, 252)
        Me.GrdUserAccount.TabIndex = 1156
        '
        'FrmUserAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1016, 599)
        Me.Controls.Add(Me.GrdUserAccount)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblTotalUserAccount)
        Me.Controls.Add(Me.BtnRefrersh)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.GrpUserAccount)
        Me.Controls.Add(Me.PnlUserAccount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmUserAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Account"
        Me.PnlUserAccount.ResumeLayout(False)
        Me.PnlUserAccount.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GrpUserAccount.ResumeLayout(False)
        Me.GrpUserAccount.PerformLayout()
        CType(Me.PtbUserImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdUserAccount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PnlUserAccount As System.Windows.Forms.Panel
    Friend WithEvents LblUserAccountID As System.Windows.Forms.Label
    Friend WithEvents LblAccountFullName As System.Windows.Forms.Label
    Friend WithEvents LblDesignation As System.Windows.Forms.Label
    Friend WithEvents TxtUserAccountID As System.Windows.Forms.TextBox
    Friend WithEvents TxtDesignation As System.Windows.Forms.TextBox
    Friend WithEvents LblUserName As System.Windows.Forms.Label
    Friend WithEvents LblPassword As System.Windows.Forms.Label
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox
    Friend WithEvents TxtUserName As System.Windows.Forms.TextBox
    Friend WithEvents GrpUserAccount As System.Windows.Forms.GroupBox
    Friend WithEvents TxtStatus As System.Windows.Forms.TextBox
    Friend WithEvents LblStatus As System.Windows.Forms.Label
    Friend WithEvents LblBranchID As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
    Friend WithEvents BtnRefrersh As System.Windows.Forms.Button
    Friend WithEvents cmbBranchID As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblTotalUserAccount As System.Windows.Forms.Label
    Friend WithEvents LblUserAccount As System.Windows.Forms.Label
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents PtbUserImage As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
    Friend WithEvents GrdUserAccount As System.Windows.Forms.DataGridView
    Friend WithEvents CmbEmployeeID As System.Windows.Forms.ComboBox
    Friend WithEvents BtnChoose As System.Windows.Forms.Button
End Class
