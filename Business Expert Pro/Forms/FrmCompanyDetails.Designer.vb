<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCompanyDetails
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
        Me.PnlSchoolDetails = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.LblCompanyDetails = New System.Windows.Forms.Label
        Me.LblCompanyID = New System.Windows.Forms.Label
        Me.LblSchoolName = New System.Windows.Forms.Label
        Me.LblSchoolTitle = New System.Windows.Forms.Label
        Me.LblContactNo = New System.Windows.Forms.Label
        Me.LblAddress = New System.Windows.Forms.Label
        Me.LblEmail = New System.Windows.Forms.Label
        Me.LblStatus = New System.Windows.Forms.Label
        Me.TxtCompanyID = New System.Windows.Forms.TextBox
        Me.TxtContactNo = New System.Windows.Forms.TextBox
        Me.TxtCompanyTitle = New System.Windows.Forms.TextBox
        Me.TxtCompanyName = New System.Windows.Forms.TextBox
        Me.TxtAddress = New System.Windows.Forms.TextBox
        Me.TxtEmail = New System.Windows.Forms.TextBox
        Me.GrpCompanyDetails = New System.Windows.Forms.GroupBox
        Me.BtnMemberChoose = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.BtnMemberRemove = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.PtbCompanyImage = New System.Windows.Forms.PictureBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.CmbBranchID = New System.Windows.Forms.ComboBox
        Me.LblBranchName = New System.Windows.Forms.Label
        Me.BtnRefresh = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnAddNew = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.GrdCompanyDetails = New System.Windows.Forms.DataGridView
        Me.TxtStatus = New System.Windows.Forms.TextBox
        Me.PnlSchoolDetails.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GrpCompanyDetails.SuspendLayout()
        CType(Me.PtbCompanyImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdCompanyDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlSchoolDetails
        '
        Me.PnlSchoolDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlSchoolDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlSchoolDetails.Controls.Add(Me.Panel1)
        Me.PnlSchoolDetails.Controls.Add(Me.LblCompanyDetails)
        Me.PnlSchoolDetails.Location = New System.Drawing.Point(-6, 0)
        Me.PnlSchoolDetails.Name = "PnlSchoolDetails"
        Me.PnlSchoolDetails.Size = New System.Drawing.Size(953, 101)
        Me.PnlSchoolDetails.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Btnclose)
        Me.Panel1.Controls.Add(Me.Btnminimized)
        Me.Panel1.Controls.Add(Me.Btnmaximized)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(954, 29)
        Me.Panel1.TabIndex = 7
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(927, 1)
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
        Me.Btnminimized.Location = New System.Drawing.Point(876, 1)
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
        Me.Btnmaximized.Location = New System.Drawing.Point(901, 1)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1157
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'LblCompanyDetails
        '
        Me.LblCompanyDetails.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblCompanyDetails.AutoSize = True
        Me.LblCompanyDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCompanyDetails.ForeColor = System.Drawing.Color.White
        Me.LblCompanyDetails.Location = New System.Drawing.Point(357, 44)
        Me.LblCompanyDetails.Name = "LblCompanyDetails"
        Me.LblCompanyDetails.Size = New System.Drawing.Size(275, 37)
        Me.LblCompanyDetails.TabIndex = 0
        Me.LblCompanyDetails.Text = "Company Details"
        '
        'LblCompanyID
        '
        Me.LblCompanyID.AutoSize = True
        Me.LblCompanyID.Location = New System.Drawing.Point(35, 22)
        Me.LblCompanyID.Name = "LblCompanyID"
        Me.LblCompanyID.Size = New System.Drawing.Size(68, 13)
        Me.LblCompanyID.TabIndex = 186
        Me.LblCompanyID.Text = "Company ID:"
        '
        'LblSchoolName
        '
        Me.LblSchoolName.AutoSize = True
        Me.LblSchoolName.Location = New System.Drawing.Point(35, 49)
        Me.LblSchoolName.Name = "LblSchoolName"
        Me.LblSchoolName.Size = New System.Drawing.Size(85, 13)
        Me.LblSchoolName.TabIndex = 187
        Me.LblSchoolName.Text = "Company Name:"
        '
        'LblSchoolTitle
        '
        Me.LblSchoolTitle.AutoSize = True
        Me.LblSchoolTitle.Location = New System.Drawing.Point(35, 100)
        Me.LblSchoolTitle.Name = "LblSchoolTitle"
        Me.LblSchoolTitle.Size = New System.Drawing.Size(77, 13)
        Me.LblSchoolTitle.TabIndex = 188
        Me.LblSchoolTitle.Text = "Company Title:"
        '
        'LblContactNo
        '
        Me.LblContactNo.AutoSize = True
        Me.LblContactNo.Location = New System.Drawing.Point(373, 26)
        Me.LblContactNo.Name = "LblContactNo"
        Me.LblContactNo.Size = New System.Drawing.Size(64, 13)
        Me.LblContactNo.TabIndex = 189
        Me.LblContactNo.Text = "Contact No:"
        '
        'LblAddress
        '
        Me.LblAddress.AutoSize = True
        Me.LblAddress.Location = New System.Drawing.Point(373, 57)
        Me.LblAddress.Name = "LblAddress"
        Me.LblAddress.Size = New System.Drawing.Size(48, 13)
        Me.LblAddress.TabIndex = 190
        Me.LblAddress.Text = "Address:"
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Location = New System.Drawing.Point(373, 99)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(35, 13)
        Me.LblEmail.TabIndex = 192
        Me.LblEmail.Text = "Email:"
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Location = New System.Drawing.Point(373, 125)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(66, 13)
        Me.LblStatus.TabIndex = 193
        Me.LblStatus.Text = "SMS Status:"
        '
        'TxtCompanyID
        '
        Me.TxtCompanyID.Enabled = False
        Me.TxtCompanyID.Location = New System.Drawing.Point(148, 19)
        Me.TxtCompanyID.Name = "TxtCompanyID"
        Me.TxtCompanyID.Size = New System.Drawing.Size(82, 20)
        Me.TxtCompanyID.TabIndex = 101
        '
        'TxtContactNo
        '
        Me.TxtContactNo.Location = New System.Drawing.Point(478, 22)
        Me.TxtContactNo.Name = "TxtContactNo"
        Me.TxtContactNo.Size = New System.Drawing.Size(187, 20)
        Me.TxtContactNo.TabIndex = 105
        '
        'TxtCompanyTitle
        '
        Me.TxtCompanyTitle.Location = New System.Drawing.Point(148, 100)
        Me.TxtCompanyTitle.Multiline = True
        Me.TxtCompanyTitle.Name = "TxtCompanyTitle"
        Me.TxtCompanyTitle.Size = New System.Drawing.Size(187, 39)
        Me.TxtCompanyTitle.TabIndex = 103
        '
        'TxtCompanyName
        '
        Me.TxtCompanyName.Enabled = False
        Me.TxtCompanyName.Location = New System.Drawing.Point(148, 48)
        Me.TxtCompanyName.Multiline = True
        Me.TxtCompanyName.Name = "TxtCompanyName"
        Me.TxtCompanyName.Size = New System.Drawing.Size(187, 42)
        Me.TxtCompanyName.TabIndex = 102
        '
        'TxtAddress
        '
        Me.TxtAddress.Location = New System.Drawing.Point(478, 49)
        Me.TxtAddress.Multiline = True
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(187, 39)
        Me.TxtAddress.TabIndex = 106
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(478, 95)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(187, 20)
        Me.TxtEmail.TabIndex = 107
        '
        'GrpCompanyDetails
        '
        Me.GrpCompanyDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpCompanyDetails.Controls.Add(Me.TxtStatus)
        Me.GrpCompanyDetails.Controls.Add(Me.BtnMemberChoose)
        Me.GrpCompanyDetails.Controls.Add(Me.Label2)
        Me.GrpCompanyDetails.Controls.Add(Me.BtnMemberRemove)
        Me.GrpCompanyDetails.Controls.Add(Me.Label1)
        Me.GrpCompanyDetails.Controls.Add(Me.PtbCompanyImage)
        Me.GrpCompanyDetails.Controls.Add(Me.Label6)
        Me.GrpCompanyDetails.Controls.Add(Me.CmbBranchID)
        Me.GrpCompanyDetails.Controls.Add(Me.LblBranchName)
        Me.GrpCompanyDetails.Controls.Add(Me.TxtEmail)
        Me.GrpCompanyDetails.Controls.Add(Me.TxtAddress)
        Me.GrpCompanyDetails.Controls.Add(Me.TxtCompanyName)
        Me.GrpCompanyDetails.Controls.Add(Me.TxtCompanyTitle)
        Me.GrpCompanyDetails.Controls.Add(Me.TxtContactNo)
        Me.GrpCompanyDetails.Controls.Add(Me.TxtCompanyID)
        Me.GrpCompanyDetails.Controls.Add(Me.LblStatus)
        Me.GrpCompanyDetails.Controls.Add(Me.LblEmail)
        Me.GrpCompanyDetails.Controls.Add(Me.LblAddress)
        Me.GrpCompanyDetails.Controls.Add(Me.LblSchoolTitle)
        Me.GrpCompanyDetails.Controls.Add(Me.LblContactNo)
        Me.GrpCompanyDetails.Controls.Add(Me.LblSchoolName)
        Me.GrpCompanyDetails.Controls.Add(Me.LblCompanyID)
        Me.GrpCompanyDetails.Location = New System.Drawing.Point(5, 175)
        Me.GrpCompanyDetails.Name = "GrpCompanyDetails"
        Me.GrpCompanyDetails.Size = New System.Drawing.Size(936, 188)
        Me.GrpCompanyDetails.TabIndex = 203
        Me.GrpCompanyDetails.TabStop = False
        Me.GrpCompanyDetails.Text = "Company Details"
        '
        'BtnMemberChoose
        '
        Me.BtnMemberChoose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMemberChoose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMemberChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMemberChoose.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMemberChoose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMemberChoose.Location = New System.Drawing.Point(780, 149)
        Me.BtnMemberChoose.Name = "BtnMemberChoose"
        Me.BtnMemberChoose.Size = New System.Drawing.Size(71, 25)
        Me.BtnMemberChoose.TabIndex = 2075
        Me.BtnMemberChoose.Text = "Choose.."
        Me.BtnMemberChoose.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnMemberChoose.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(99, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 24)
        Me.Label2.TabIndex = 2031
        Me.Label2.Text = "*"
        '
        'BtnMemberRemove
        '
        Me.BtnMemberRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMemberRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMemberRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMemberRemove.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMemberRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMemberRemove.Location = New System.Drawing.Point(857, 149)
        Me.BtnMemberRemove.Name = "BtnMemberRemove"
        Me.BtnMemberRemove.Size = New System.Drawing.Size(71, 25)
        Me.BtnMemberRemove.TabIndex = 2074
        Me.BtnMemberRemove.Text = "Remove"
        Me.BtnMemberRemove.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(437, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 24)
        Me.Label1.TabIndex = 2030
        Me.Label1.Text = "*"
        '
        'PtbCompanyImage
        '
        Me.PtbCompanyImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PtbCompanyImage.BackgroundImage = Global.Business_Expert_Pro.My.Resources.Resources.logo
        Me.PtbCompanyImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PtbCompanyImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PtbCompanyImage.Cursor = System.Windows.Forms.Cursors.Default
        Me.PtbCompanyImage.ErrorImage = Nothing
        Me.PtbCompanyImage.InitialImage = Nothing
        Me.PtbCompanyImage.Location = New System.Drawing.Point(793, 19)
        Me.PtbCompanyImage.Name = "PtbCompanyImage"
        Me.PtbCompanyImage.Size = New System.Drawing.Size(124, 124)
        Me.PtbCompanyImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PtbCompanyImage.TabIndex = 2073
        Me.PtbCompanyImage.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(125, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 24)
        Me.Label6.TabIndex = 2029
        Me.Label6.Text = "*"
        '
        'CmbBranchID
        '
        Me.CmbBranchID.FormattingEnabled = True
        Me.CmbBranchID.Location = New System.Drawing.Point(148, 145)
        Me.CmbBranchID.Name = "CmbBranchID"
        Me.CmbBranchID.Size = New System.Drawing.Size(187, 21)
        Me.CmbBranchID.TabIndex = 104
        '
        'LblBranchName
        '
        Me.LblBranchName.AutoSize = True
        Me.LblBranchName.Location = New System.Drawing.Point(35, 145)
        Me.LblBranchName.Name = "LblBranchName"
        Me.LblBranchName.Size = New System.Drawing.Size(58, 13)
        Me.LblBranchName.TabIndex = 202
        Me.LblBranchName.Text = "Branch ID:"
        '
        'BtnRefresh
        '
        Me.BtnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefresh.Image = Global.Business_Expert_Pro.My.Resources.Resources.Reboot_32px2
        Me.BtnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRefresh.Location = New System.Drawing.Point(321, 119)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(95, 39)
        Me.BtnRefresh.TabIndex = 207
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Image = Global.Business_Expert_Pro.My.Resources.Resources.Save_32px_32
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(498, 119)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(94, 39)
        Me.BtnSave.TabIndex = 206
        Me.BtnSave.Text = "Save"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.UseVisualStyleBackColor = True
        Me.BtnSave.Visible = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Image = Global.Business_Expert_Pro.My.Resources.Resources.Edit_File_32px2
        Me.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUpdate.Location = New System.Drawing.Point(111, 119)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(94, 39)
        Me.BtnUpdate.TabIndex = 205
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
        Me.BtnDelete.Location = New System.Drawing.Point(216, 119)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(94, 39)
        Me.BtnDelete.TabIndex = 204
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
        Me.BtnAddNew.Location = New System.Drawing.Point(6, 119)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(94, 39)
        Me.BtnAddNew.TabIndex = 203
        Me.BtnAddNew.Text = "Add New"
        Me.BtnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GrdCompanyDetails
        '
        Me.GrdCompanyDetails.AllowUserToAddRows = False
        Me.GrdCompanyDetails.AllowUserToDeleteRows = False
        Me.GrdCompanyDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdCompanyDetails.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdCompanyDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdCompanyDetails.Location = New System.Drawing.Point(5, 374)
        Me.GrdCompanyDetails.Name = "GrdCompanyDetails"
        Me.GrdCompanyDetails.ReadOnly = True
        Me.GrdCompanyDetails.Size = New System.Drawing.Size(936, 309)
        Me.GrdCompanyDetails.TabIndex = 208
        '
        'TxtStatus
        '
        Me.TxtStatus.Enabled = False
        Me.TxtStatus.Location = New System.Drawing.Point(478, 125)
        Me.TxtStatus.Name = "TxtStatus"
        Me.TxtStatus.Size = New System.Drawing.Size(187, 20)
        Me.TxtStatus.TabIndex = 2076
        '
        'FrmCompanyDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(946, 690)
        Me.Controls.Add(Me.GrdCompanyDetails)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GrpCompanyDetails)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.PnlSchoolDetails)
        Me.Controls.Add(Me.BtnAddNew)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCompanyDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Company Details"
        Me.PnlSchoolDetails.ResumeLayout(False)
        Me.PnlSchoolDetails.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GrpCompanyDetails.ResumeLayout(False)
        Me.GrpCompanyDetails.PerformLayout()
        CType(Me.PtbCompanyImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdCompanyDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlSchoolDetails As System.Windows.Forms.Panel
    Friend WithEvents LblCompanyDetails As System.Windows.Forms.Label
    Friend WithEvents LblCompanyID As System.Windows.Forms.Label
    Friend WithEvents LblSchoolName As System.Windows.Forms.Label
    Friend WithEvents LblSchoolTitle As System.Windows.Forms.Label
    Friend WithEvents LblContactNo As System.Windows.Forms.Label
    Friend WithEvents LblAddress As System.Windows.Forms.Label
    Friend WithEvents LblEmail As System.Windows.Forms.Label
    Friend WithEvents LblStatus As System.Windows.Forms.Label
    Friend WithEvents TxtCompanyID As System.Windows.Forms.TextBox
    Friend WithEvents TxtContactNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtCompanyTitle As System.Windows.Forms.TextBox
    Friend WithEvents TxtCompanyName As System.Windows.Forms.TextBox
    Friend WithEvents TxtAddress As System.Windows.Forms.TextBox
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents GrpCompanyDetails As System.Windows.Forms.GroupBox
    Friend WithEvents CmbBranchID As System.Windows.Forms.ComboBox
    Friend WithEvents LblBranchName As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnMemberChoose As System.Windows.Forms.Button
    Friend WithEvents BtnMemberRemove As System.Windows.Forms.Button
    Friend WithEvents PtbCompanyImage As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
    Friend WithEvents GrdCompanyDetails As System.Windows.Forms.DataGridView
    Friend WithEvents TxtStatus As System.Windows.Forms.TextBox
End Class
