<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBankInformation
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
        Me.PnlBankInformation = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.LblBankInformation = New System.Windows.Forms.Label
        Me.GrpBankInformation = New System.Windows.Forms.GroupBox
        Me.DtpLedgerDate = New System.Windows.Forms.DateTimePicker
        Me.TxtOpeningBalance = New System.Windows.Forms.TextBox
        Me.LblOpeningBalance = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmbAccountType = New System.Windows.Forms.ComboBox
        Me.TxtRemarks = New System.Windows.Forms.TextBox
        Me.LblRemarks = New System.Windows.Forms.Label
        Me.TxtBankEmailAddress = New System.Windows.Forms.TextBox
        Me.LblBankEmailAddress = New System.Windows.Forms.Label
        Me.TxtBankWebAddress = New System.Windows.Forms.TextBox
        Me.LblBankWebAddress = New System.Windows.Forms.Label
        Me.TxtBankAddress = New System.Windows.Forms.TextBox
        Me.LblBankAddress = New System.Windows.Forms.Label
        Me.LblAccountType = New System.Windows.Forms.Label
        Me.LblAccountNo = New System.Windows.Forms.Label
        Me.LblBankID = New System.Windows.Forms.Label
        Me.TxtAccountNo = New System.Windows.Forms.TextBox
        Me.TxtBranchName = New System.Windows.Forms.TextBox
        Me.LblBranchName = New System.Windows.Forms.Label
        Me.TxtBankMobileNo = New System.Windows.Forms.TextBox
        Me.TxtBankName = New System.Windows.Forms.TextBox
        Me.TxtBankID = New System.Windows.Forms.TextBox
        Me.LblBankMobileNo = New System.Windows.Forms.Label
        Me.LblBankName = New System.Windows.Forms.Label
        Me.BtnRefresh = New System.Windows.Forms.Button
        Me.BtnInsert = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnAddNew = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.lblTotalBank = New System.Windows.Forms.Label
        Me.GrdBankInformation = New System.Windows.Forms.DataGridView
        Me.PnlBankInformation.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GrpBankInformation.SuspendLayout()
        CType(Me.GrdBankInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlBankInformation
        '
        Me.PnlBankInformation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlBankInformation.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlBankInformation.Controls.Add(Me.Panel2)
        Me.PnlBankInformation.Controls.Add(Me.LblBankInformation)
        Me.PnlBankInformation.Location = New System.Drawing.Point(-3, -1)
        Me.PnlBankInformation.Name = "PnlBankInformation"
        Me.PnlBankInformation.Size = New System.Drawing.Size(817, 69)
        Me.PnlBankInformation.TabIndex = 1035
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Btnclose)
        Me.Panel2.Controls.Add(Me.Btnminimized)
        Me.Panel2.Controls.Add(Me.Btnmaximized)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(815, 27)
        Me.Panel2.TabIndex = 2065
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(791, 0)
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
        Me.Btnminimized.Location = New System.Drawing.Point(731, 0)
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
        Me.Btnmaximized.Location = New System.Drawing.Point(761, 0)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1160
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'LblBankInformation
        '
        Me.LblBankInformation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblBankInformation.AutoSize = True
        Me.LblBankInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBankInformation.ForeColor = System.Drawing.Color.White
        Me.LblBankInformation.Location = New System.Drawing.Point(269, 29)
        Me.LblBankInformation.Name = "LblBankInformation"
        Me.LblBankInformation.Size = New System.Drawing.Size(286, 37)
        Me.LblBankInformation.TabIndex = 1
        Me.LblBankInformation.Text = "Bank  Information"
        '
        'GrpBankInformation
        '
        Me.GrpBankInformation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpBankInformation.Controls.Add(Me.DtpLedgerDate)
        Me.GrpBankInformation.Controls.Add(Me.TxtOpeningBalance)
        Me.GrpBankInformation.Controls.Add(Me.LblOpeningBalance)
        Me.GrpBankInformation.Controls.Add(Me.Label4)
        Me.GrpBankInformation.Controls.Add(Me.Label1)
        Me.GrpBankInformation.Controls.Add(Me.CmbAccountType)
        Me.GrpBankInformation.Controls.Add(Me.TxtRemarks)
        Me.GrpBankInformation.Controls.Add(Me.LblRemarks)
        Me.GrpBankInformation.Controls.Add(Me.TxtBankEmailAddress)
        Me.GrpBankInformation.Controls.Add(Me.LblBankEmailAddress)
        Me.GrpBankInformation.Controls.Add(Me.TxtBankWebAddress)
        Me.GrpBankInformation.Controls.Add(Me.LblBankWebAddress)
        Me.GrpBankInformation.Controls.Add(Me.TxtBankAddress)
        Me.GrpBankInformation.Controls.Add(Me.LblBankAddress)
        Me.GrpBankInformation.Controls.Add(Me.LblAccountType)
        Me.GrpBankInformation.Controls.Add(Me.LblAccountNo)
        Me.GrpBankInformation.Controls.Add(Me.LblBankID)
        Me.GrpBankInformation.Controls.Add(Me.TxtAccountNo)
        Me.GrpBankInformation.Controls.Add(Me.TxtBranchName)
        Me.GrpBankInformation.Controls.Add(Me.LblBranchName)
        Me.GrpBankInformation.Controls.Add(Me.TxtBankMobileNo)
        Me.GrpBankInformation.Controls.Add(Me.TxtBankName)
        Me.GrpBankInformation.Controls.Add(Me.TxtBankID)
        Me.GrpBankInformation.Controls.Add(Me.LblBankMobileNo)
        Me.GrpBankInformation.Controls.Add(Me.LblBankName)
        Me.GrpBankInformation.Location = New System.Drawing.Point(11, 138)
        Me.GrpBankInformation.Name = "GrpBankInformation"
        Me.GrpBankInformation.Size = New System.Drawing.Size(788, 217)
        Me.GrpBankInformation.TabIndex = 1046
        Me.GrpBankInformation.TabStop = False
        Me.GrpBankInformation.Text = "Bank Information"
        '
        'DtpLedgerDate
        '
        Me.DtpLedgerDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpLedgerDate.Location = New System.Drawing.Point(251, 182)
        Me.DtpLedgerDate.Name = "DtpLedgerDate"
        Me.DtpLedgerDate.Size = New System.Drawing.Size(98, 20)
        Me.DtpLedgerDate.TabIndex = 2028
        Me.DtpLedgerDate.Value = New Date(2018, 3, 3, 0, 0, 0, 0)
        '
        'TxtOpeningBalance
        '
        Me.TxtOpeningBalance.Location = New System.Drawing.Point(137, 182)
        Me.TxtOpeningBalance.Name = "TxtOpeningBalance"
        Me.TxtOpeningBalance.Size = New System.Drawing.Size(108, 20)
        Me.TxtOpeningBalance.TabIndex = 2018
        '
        'LblOpeningBalance
        '
        Me.LblOpeningBalance.AutoSize = True
        Me.LblOpeningBalance.Location = New System.Drawing.Point(19, 182)
        Me.LblOpeningBalance.Name = "LblOpeningBalance"
        Me.LblOpeningBalance.Size = New System.Drawing.Size(92, 13)
        Me.LblOpeningBalance.TabIndex = 2017
        Me.LblOpeningBalance.Text = "Opening Balance:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(86, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 24)
        Me.Label4.TabIndex = 2015
        Me.Label4.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(88, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 24)
        Me.Label1.TabIndex = 2016
        Me.Label1.Text = "*"
        '
        'CmbAccountType
        '
        Me.CmbAccountType.AutoCompleteCustomSource.AddRange(New String() {"CURRENT", "SAVINGS", "FIXED DEPOSITE"})
        Me.CmbAccountType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbAccountType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.CmbAccountType.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbAccountType.FormattingEnabled = True
        Me.CmbAccountType.Items.AddRange(New Object() {"CURRENT", "SAVINGS", "FIXED DEPOSITE"})
        Me.CmbAccountType.Location = New System.Drawing.Point(137, 153)
        Me.CmbAccountType.Name = "CmbAccountType"
        Me.CmbAccountType.Size = New System.Drawing.Size(212, 21)
        Me.CmbAccountType.TabIndex = 206
        '
        'TxtRemarks
        '
        Me.TxtRemarks.Location = New System.Drawing.Point(535, 152)
        Me.TxtRemarks.Multiline = True
        Me.TxtRemarks.Name = "TxtRemarks"
        Me.TxtRemarks.Size = New System.Drawing.Size(247, 48)
        Me.TxtRemarks.TabIndex = 210
        '
        'LblRemarks
        '
        Me.LblRemarks.AutoSize = True
        Me.LblRemarks.Location = New System.Drawing.Point(417, 156)
        Me.LblRemarks.Name = "LblRemarks"
        Me.LblRemarks.Size = New System.Drawing.Size(52, 13)
        Me.LblRemarks.TabIndex = 218
        Me.LblRemarks.Text = "Remarks:"
        '
        'TxtBankEmailAddress
        '
        Me.TxtBankEmailAddress.Location = New System.Drawing.Point(535, 123)
        Me.TxtBankEmailAddress.Name = "TxtBankEmailAddress"
        Me.TxtBankEmailAddress.Size = New System.Drawing.Size(247, 20)
        Me.TxtBankEmailAddress.TabIndex = 209
        '
        'LblBankEmailAddress
        '
        Me.LblBankEmailAddress.AutoSize = True
        Me.LblBankEmailAddress.Location = New System.Drawing.Point(417, 125)
        Me.LblBankEmailAddress.Name = "LblBankEmailAddress"
        Me.LblBankEmailAddress.Size = New System.Drawing.Size(104, 13)
        Me.LblBankEmailAddress.TabIndex = 216
        Me.LblBankEmailAddress.Text = "Bank Email Address:"
        '
        'TxtBankWebAddress
        '
        Me.TxtBankWebAddress.Location = New System.Drawing.Point(535, 94)
        Me.TxtBankWebAddress.Name = "TxtBankWebAddress"
        Me.TxtBankWebAddress.Size = New System.Drawing.Size(247, 20)
        Me.TxtBankWebAddress.TabIndex = 208
        '
        'LblBankWebAddress
        '
        Me.LblBankWebAddress.AutoSize = True
        Me.LblBankWebAddress.Location = New System.Drawing.Point(417, 95)
        Me.LblBankWebAddress.Name = "LblBankWebAddress"
        Me.LblBankWebAddress.Size = New System.Drawing.Size(102, 13)
        Me.LblBankWebAddress.TabIndex = 214
        Me.LblBankWebAddress.Text = "Bank Web Address:"
        '
        'TxtBankAddress
        '
        Me.TxtBankAddress.Location = New System.Drawing.Point(535, 18)
        Me.TxtBankAddress.Multiline = True
        Me.TxtBankAddress.Name = "TxtBankAddress"
        Me.TxtBankAddress.Size = New System.Drawing.Size(247, 67)
        Me.TxtBankAddress.TabIndex = 207
        '
        'LblBankAddress
        '
        Me.LblBankAddress.AutoSize = True
        Me.LblBankAddress.Location = New System.Drawing.Point(417, 21)
        Me.LblBankAddress.Name = "LblBankAddress"
        Me.LblBankAddress.Size = New System.Drawing.Size(76, 13)
        Me.LblBankAddress.TabIndex = 212
        Me.LblBankAddress.Text = "Bank Address:"
        '
        'LblAccountType
        '
        Me.LblAccountType.AutoSize = True
        Me.LblAccountType.Location = New System.Drawing.Point(19, 153)
        Me.LblAccountType.Name = "LblAccountType"
        Me.LblAccountType.Size = New System.Drawing.Size(77, 13)
        Me.LblAccountType.TabIndex = 210
        Me.LblAccountType.Text = "Account Type:"
        '
        'LblAccountNo
        '
        Me.LblAccountNo.AutoSize = True
        Me.LblAccountNo.Location = New System.Drawing.Point(19, 99)
        Me.LblAccountNo.Name = "LblAccountNo"
        Me.LblAccountNo.Size = New System.Drawing.Size(67, 13)
        Me.LblAccountNo.TabIndex = 209
        Me.LblAccountNo.Text = "Account No:"
        '
        'LblBankID
        '
        Me.LblBankID.AutoSize = True
        Me.LblBankID.Location = New System.Drawing.Point(19, 18)
        Me.LblBankID.Name = "LblBankID"
        Me.LblBankID.Size = New System.Drawing.Size(52, 13)
        Me.LblBankID.TabIndex = 208
        Me.LblBankID.Text = "Bank  ID:"
        '
        'TxtAccountNo
        '
        Me.TxtAccountNo.Location = New System.Drawing.Point(137, 99)
        Me.TxtAccountNo.Name = "TxtAccountNo"
        Me.TxtAccountNo.Size = New System.Drawing.Size(212, 20)
        Me.TxtAccountNo.TabIndex = 204
        '
        'TxtBranchName
        '
        Me.TxtBranchName.Location = New System.Drawing.Point(137, 72)
        Me.TxtBranchName.Name = "TxtBranchName"
        Me.TxtBranchName.Size = New System.Drawing.Size(212, 20)
        Me.TxtBranchName.TabIndex = 203
        '
        'LblBranchName
        '
        Me.LblBranchName.AutoSize = True
        Me.LblBranchName.Location = New System.Drawing.Point(19, 72)
        Me.LblBranchName.Name = "LblBranchName"
        Me.LblBranchName.Size = New System.Drawing.Size(75, 13)
        Me.LblBranchName.TabIndex = 205
        Me.LblBranchName.Text = "Branch Name:"
        '
        'TxtBankMobileNo
        '
        Me.TxtBankMobileNo.Location = New System.Drawing.Point(137, 126)
        Me.TxtBankMobileNo.Name = "TxtBankMobileNo"
        Me.TxtBankMobileNo.Size = New System.Drawing.Size(212, 20)
        Me.TxtBankMobileNo.TabIndex = 205
        '
        'TxtBankName
        '
        Me.TxtBankName.Location = New System.Drawing.Point(137, 45)
        Me.TxtBankName.Name = "TxtBankName"
        Me.TxtBankName.Size = New System.Drawing.Size(212, 20)
        Me.TxtBankName.TabIndex = 202
        '
        'TxtBankID
        '
        Me.TxtBankID.Enabled = False
        Me.TxtBankID.Location = New System.Drawing.Point(137, 18)
        Me.TxtBankID.Name = "TxtBankID"
        Me.TxtBankID.Size = New System.Drawing.Size(76, 20)
        Me.TxtBankID.TabIndex = 201
        '
        'LblBankMobileNo
        '
        Me.LblBankMobileNo.AutoSize = True
        Me.LblBankMobileNo.Location = New System.Drawing.Point(19, 126)
        Me.LblBankMobileNo.Name = "LblBankMobileNo"
        Me.LblBankMobileNo.Size = New System.Drawing.Size(86, 13)
        Me.LblBankMobileNo.TabIndex = 5
        Me.LblBankMobileNo.Text = "Bank Mobile No:"
        '
        'LblBankName
        '
        Me.LblBankName.AutoSize = True
        Me.LblBankName.Location = New System.Drawing.Point(19, 45)
        Me.LblBankName.Name = "LblBankName"
        Me.LblBankName.Size = New System.Drawing.Size(66, 13)
        Me.LblBankName.TabIndex = 4
        Me.LblBankName.Text = "Bank Name:"
        '
        'BtnRefresh
        '
        Me.BtnRefresh.BackgroundImage = Global.Business_Expert_Pro.My.Resources.Resources.Reboot_32px2
        Me.BtnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRefresh.Location = New System.Drawing.Point(296, 93)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(89, 39)
        Me.BtnRefresh.TabIndex = 1045
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'BtnInsert
        '
        Me.BtnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInsert.Image = Global.Business_Expert_Pro.My.Resources.Resources.Save_32px_32
        Me.BtnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInsert.Location = New System.Drawing.Point(407, 93)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(89, 39)
        Me.BtnInsert.TabIndex = 211
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
        Me.BtnUpdate.Location = New System.Drawing.Point(106, 93)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(89, 39)
        Me.BtnUpdate.TabIndex = 213
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Image = Global.Business_Expert_Pro.My.Resources.Resources.Delete_32px3
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(201, 93)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(89, 39)
        Me.BtnDelete.TabIndex = 215
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
        Me.BtnAddNew.Location = New System.Drawing.Point(11, 93)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(89, 39)
        Me.BtnAddNew.TabIndex = 212
        Me.BtnAddNew.Text = "Add New"
        Me.BtnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(747, 123)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(21, 13)
        Me.Label15.TabIndex = 1155
        Me.Label15.Text = "00"
        '
        'lblTotalBank
        '
        Me.lblTotalBank.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalBank.AutoSize = True
        Me.lblTotalBank.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTotalBank.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBank.Location = New System.Drawing.Point(648, 121)
        Me.lblTotalBank.Name = "lblTotalBank"
        Me.lblTotalBank.Size = New System.Drawing.Size(76, 16)
        Me.lblTotalBank.TabIndex = 1154
        Me.lblTotalBank.Text = "Total Bank:"
        '
        'GrdBankInformation
        '
        Me.GrdBankInformation.AllowUserToAddRows = False
        Me.GrdBankInformation.AllowUserToDeleteRows = False
        Me.GrdBankInformation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdBankInformation.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdBankInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdBankInformation.Location = New System.Drawing.Point(11, 371)
        Me.GrdBankInformation.Name = "GrdBankInformation"
        Me.GrdBankInformation.ReadOnly = True
        Me.GrdBankInformation.Size = New System.Drawing.Size(788, 238)
        Me.GrdBankInformation.TabIndex = 1156
        '
        'FrmBankInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(812, 620)
        Me.Controls.Add(Me.GrdBankInformation)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblTotalBank)
        Me.Controls.Add(Me.GrpBankInformation)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.BtnInsert)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.PnlBankInformation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmBankInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bank Information"
        Me.PnlBankInformation.ResumeLayout(False)
        Me.PnlBankInformation.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GrpBankInformation.ResumeLayout(False)
        Me.GrpBankInformation.PerformLayout()
        CType(Me.GrdBankInformation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button
    Friend WithEvents BtnInsert As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
    Friend WithEvents PnlBankInformation As System.Windows.Forms.Panel
    Friend WithEvents LblBankInformation As System.Windows.Forms.Label
    Friend WithEvents GrpBankInformation As System.Windows.Forms.GroupBox
    Friend WithEvents TxtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents LblRemarks As System.Windows.Forms.Label
    Friend WithEvents TxtBankEmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents LblBankEmailAddress As System.Windows.Forms.Label
    Friend WithEvents TxtBankWebAddress As System.Windows.Forms.TextBox
    Friend WithEvents LblBankWebAddress As System.Windows.Forms.Label
    Friend WithEvents TxtBankAddress As System.Windows.Forms.TextBox
    Friend WithEvents LblBankAddress As System.Windows.Forms.Label
    Friend WithEvents LblAccountType As System.Windows.Forms.Label
    Friend WithEvents LblAccountNo As System.Windows.Forms.Label
    Friend WithEvents LblBankID As System.Windows.Forms.Label
    Friend WithEvents TxtAccountNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtBranchName As System.Windows.Forms.TextBox
    Friend WithEvents LblBranchName As System.Windows.Forms.Label
    Friend WithEvents TxtBankMobileNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtBankName As System.Windows.Forms.TextBox
    Friend WithEvents TxtBankID As System.Windows.Forms.TextBox
    Friend WithEvents LblBankMobileNo As System.Windows.Forms.Label
    Friend WithEvents LblBankName As System.Windows.Forms.Label
    Friend WithEvents CmbAccountType As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblTotalBank As System.Windows.Forms.Label
    Friend WithEvents TxtOpeningBalance As System.Windows.Forms.TextBox
    Friend WithEvents LblOpeningBalance As System.Windows.Forms.Label
    Friend WithEvents DtpLedgerDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
    Friend WithEvents GrdBankInformation As System.Windows.Forms.DataGridView
End Class
