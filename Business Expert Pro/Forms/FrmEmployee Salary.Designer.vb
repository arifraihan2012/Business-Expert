<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmployeeSalary
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
        Me.PnlEmployeeSalary = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.LblEmployeeSalary = New System.Windows.Forms.Label
        Me.LblEmployeeID = New System.Windows.Forms.Label
        Me.LblPaidAmount = New System.Windows.Forms.Label
        Me.LblDeductionAmount = New System.Windows.Forms.Label
        Me.LblRemarks = New System.Windows.Forms.Label
        Me.LblPaymentDate = New System.Windows.Forms.Label
        Me.LblSalaryID = New System.Windows.Forms.Label
        Me.TxtSalaryID = New System.Windows.Forms.TextBox
        Me.TxtDeductionAmount = New System.Windows.Forms.TextBox
        Me.TxtRemarks = New System.Windows.Forms.TextBox
        Me.TxtPaidAmount = New System.Windows.Forms.TextBox
        Me.GrpEmployeeSalary = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmbEmployeeID = New System.Windows.Forms.ComboBox
        Me.DtpPaymentDate = New System.Windows.Forms.DateTimePicker
        Me.CmbSearch = New System.Windows.Forms.ComboBox
        Me.TxtSearch = New System.Windows.Forms.TextBox
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnRefresh = New System.Windows.Forms.Button
        Me.BtnAddNew = New System.Windows.Forms.Button
        Me.GrdEmployeeSalary = New System.Windows.Forms.DataGridView
        Me.PnlEmployeeSalary.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GrpEmployeeSalary.SuspendLayout()
        CType(Me.GrdEmployeeSalary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlEmployeeSalary
        '
        Me.PnlEmployeeSalary.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlEmployeeSalary.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlEmployeeSalary.Controls.Add(Me.Panel1)
        Me.PnlEmployeeSalary.Controls.Add(Me.LblEmployeeSalary)
        Me.PnlEmployeeSalary.Location = New System.Drawing.Point(1, 0)
        Me.PnlEmployeeSalary.Name = "PnlEmployeeSalary"
        Me.PnlEmployeeSalary.Size = New System.Drawing.Size(852, 87)
        Me.PnlEmployeeSalary.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Btnclose)
        Me.Panel1.Controls.Add(Me.Btnminimized)
        Me.Panel1.Controls.Add(Me.Btnmaximized)
        Me.Panel1.Location = New System.Drawing.Point(-2, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(851, 29)
        Me.Panel1.TabIndex = 4
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(824, 0)
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
        Me.Btnminimized.Location = New System.Drawing.Point(773, 0)
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
        Me.Btnmaximized.Location = New System.Drawing.Point(798, 0)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1157
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'LblEmployeeSalary
        '
        Me.LblEmployeeSalary.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblEmployeeSalary.AutoSize = True
        Me.LblEmployeeSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblEmployeeSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmployeeSalary.ForeColor = System.Drawing.Color.White
        Me.LblEmployeeSalary.Location = New System.Drawing.Point(291, 36)
        Me.LblEmployeeSalary.Name = "LblEmployeeSalary"
        Me.LblEmployeeSalary.Size = New System.Drawing.Size(271, 37)
        Me.LblEmployeeSalary.TabIndex = 0
        Me.LblEmployeeSalary.Text = "Employee Salary"
        Me.LblEmployeeSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblEmployeeID
        '
        Me.LblEmployeeID.AutoSize = True
        Me.LblEmployeeID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblEmployeeID.Location = New System.Drawing.Point(20, 64)
        Me.LblEmployeeID.Name = "LblEmployeeID"
        Me.LblEmployeeID.Size = New System.Drawing.Size(70, 13)
        Me.LblEmployeeID.TabIndex = 6
        Me.LblEmployeeID.Text = "Employee ID:"
        '
        'LblPaidAmount
        '
        Me.LblPaidAmount.AutoSize = True
        Me.LblPaidAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblPaidAmount.Location = New System.Drawing.Point(19, 96)
        Me.LblPaidAmount.Name = "LblPaidAmount"
        Me.LblPaidAmount.Size = New System.Drawing.Size(70, 13)
        Me.LblPaidAmount.TabIndex = 7
        Me.LblPaidAmount.Text = "Paid Amount:"
        '
        'LblDeductionAmount
        '
        Me.LblDeductionAmount.AutoSize = True
        Me.LblDeductionAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblDeductionAmount.Location = New System.Drawing.Point(368, 28)
        Me.LblDeductionAmount.Name = "LblDeductionAmount"
        Me.LblDeductionAmount.Size = New System.Drawing.Size(98, 13)
        Me.LblDeductionAmount.TabIndex = 8
        Me.LblDeductionAmount.Text = "Deduction Amount:"
        '
        'LblRemarks
        '
        Me.LblRemarks.AutoSize = True
        Me.LblRemarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblRemarks.Location = New System.Drawing.Point(368, 93)
        Me.LblRemarks.Name = "LblRemarks"
        Me.LblRemarks.Size = New System.Drawing.Size(52, 13)
        Me.LblRemarks.TabIndex = 9
        Me.LblRemarks.Text = "Remarks:"
        '
        'LblPaymentDate
        '
        Me.LblPaymentDate.AutoSize = True
        Me.LblPaymentDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblPaymentDate.Location = New System.Drawing.Point(368, 58)
        Me.LblPaymentDate.Name = "LblPaymentDate"
        Me.LblPaymentDate.Size = New System.Drawing.Size(77, 13)
        Me.LblPaymentDate.TabIndex = 10
        Me.LblPaymentDate.Text = "Payment Date:"
        '
        'LblSalaryID
        '
        Me.LblSalaryID.AutoSize = True
        Me.LblSalaryID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblSalaryID.Location = New System.Drawing.Point(19, 32)
        Me.LblSalaryID.Name = "LblSalaryID"
        Me.LblSalaryID.Size = New System.Drawing.Size(53, 13)
        Me.LblSalaryID.TabIndex = 11
        Me.LblSalaryID.Text = "Salary ID:"
        '
        'TxtSalaryID
        '
        Me.TxtSalaryID.Enabled = False
        Me.TxtSalaryID.Location = New System.Drawing.Point(118, 32)
        Me.TxtSalaryID.Name = "TxtSalaryID"
        Me.TxtSalaryID.Size = New System.Drawing.Size(68, 20)
        Me.TxtSalaryID.TabIndex = 101
        '
        'TxtDeductionAmount
        '
        Me.TxtDeductionAmount.Location = New System.Drawing.Point(472, 25)
        Me.TxtDeductionAmount.Name = "TxtDeductionAmount"
        Me.TxtDeductionAmount.Size = New System.Drawing.Size(86, 20)
        Me.TxtDeductionAmount.TabIndex = 104
        '
        'TxtRemarks
        '
        Me.TxtRemarks.Location = New System.Drawing.Point(472, 81)
        Me.TxtRemarks.Multiline = True
        Me.TxtRemarks.Name = "TxtRemarks"
        Me.TxtRemarks.Size = New System.Drawing.Size(293, 40)
        Me.TxtRemarks.TabIndex = 106
        '
        'TxtPaidAmount
        '
        Me.TxtPaidAmount.Location = New System.Drawing.Point(118, 93)
        Me.TxtPaidAmount.Name = "TxtPaidAmount"
        Me.TxtPaidAmount.Size = New System.Drawing.Size(88, 20)
        Me.TxtPaidAmount.TabIndex = 103
        '
        'GrpEmployeeSalary
        '
        Me.GrpEmployeeSalary.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpEmployeeSalary.Controls.Add(Me.Label2)
        Me.GrpEmployeeSalary.Controls.Add(Me.Label3)
        Me.GrpEmployeeSalary.Controls.Add(Me.Label1)
        Me.GrpEmployeeSalary.Controls.Add(Me.CmbEmployeeID)
        Me.GrpEmployeeSalary.Controls.Add(Me.DtpPaymentDate)
        Me.GrpEmployeeSalary.Controls.Add(Me.TxtPaidAmount)
        Me.GrpEmployeeSalary.Controls.Add(Me.TxtRemarks)
        Me.GrpEmployeeSalary.Controls.Add(Me.TxtDeductionAmount)
        Me.GrpEmployeeSalary.Controls.Add(Me.TxtSalaryID)
        Me.GrpEmployeeSalary.Controls.Add(Me.LblSalaryID)
        Me.GrpEmployeeSalary.Controls.Add(Me.LblPaymentDate)
        Me.GrpEmployeeSalary.Controls.Add(Me.LblRemarks)
        Me.GrpEmployeeSalary.Controls.Add(Me.LblDeductionAmount)
        Me.GrpEmployeeSalary.Controls.Add(Me.LblPaidAmount)
        Me.GrpEmployeeSalary.Controls.Add(Me.LblEmployeeID)
        Me.GrpEmployeeSalary.Location = New System.Drawing.Point(6, 153)
        Me.GrpEmployeeSalary.Name = "GrpEmployeeSalary"
        Me.GrpEmployeeSalary.Size = New System.Drawing.Size(839, 131)
        Me.GrpEmployeeSalary.TabIndex = 18
        Me.GrpEmployeeSalary.TabStop = False
        Me.GrpEmployeeSalary.Text = "Employee Salary"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(86, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 24)
        Me.Label2.TabIndex = 2017
        Me.Label2.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(89, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 24)
        Me.Label3.TabIndex = 2018
        Me.Label3.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(281, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 2012
        Me.Label1.Text = "[F4]"
        '
        'CmbEmployeeID
        '
        Me.CmbEmployeeID.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbEmployeeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbEmployeeID.FormattingEnabled = True
        Me.CmbEmployeeID.Location = New System.Drawing.Point(118, 62)
        Me.CmbEmployeeID.Name = "CmbEmployeeID"
        Me.CmbEmployeeID.Size = New System.Drawing.Size(157, 21)
        Me.CmbEmployeeID.TabIndex = 102
        '
        'DtpPaymentDate
        '
        Me.DtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpPaymentDate.Location = New System.Drawing.Point(472, 53)
        Me.DtpPaymentDate.Name = "DtpPaymentDate"
        Me.DtpPaymentDate.Size = New System.Drawing.Size(100, 20)
        Me.DtpPaymentDate.TabIndex = 105
        Me.DtpPaymentDate.Value = New Date(2017, 3, 4, 0, 0, 0, 0)
        '
        'CmbSearch
        '
        Me.CmbSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbSearch.FormattingEnabled = True
        Me.CmbSearch.Items.AddRange(New Object() {"Employee ID", "Date"})
        Me.CmbSearch.Location = New System.Drawing.Point(596, 93)
        Me.CmbSearch.Name = "CmbSearch"
        Me.CmbSearch.Size = New System.Drawing.Size(114, 21)
        Me.CmbSearch.TabIndex = 112
        '
        'TxtSearch
        '
        Me.TxtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSearch.Location = New System.Drawing.Point(714, 93)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(96, 20)
        Me.TxtSearch.TabIndex = 113
        '
        'BtnSearch
        '
        Me.BtnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Image = Global.Business_Expert_Pro.My.Resources.Resources.Button_15_1281
        Me.BtnSearch.Location = New System.Drawing.Point(816, 93)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(19, 19)
        Me.BtnSearch.TabIndex = 114
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Image = Global.Business_Expert_Pro.My.Resources.Resources.Save_32px_32
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(435, 98)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(85, 40)
        Me.BtnSave.TabIndex = 107
        Me.BtnSave.Text = "Save"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Image = Global.Business_Expert_Pro.My.Resources.Resources.Edit_File_32px2
        Me.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUpdate.Location = New System.Drawing.Point(108, 98)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(85, 40)
        Me.BtnUpdate.TabIndex = 109
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
        Me.BtnDelete.Location = New System.Drawing.Point(199, 98)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(85, 40)
        Me.BtnDelete.TabIndex = 110
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnRefresh
        '
        Me.BtnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefresh.Image = Global.Business_Expert_Pro.My.Resources.Resources.Reboot_32px2
        Me.BtnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRefresh.Location = New System.Drawing.Point(315, 98)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(85, 40)
        Me.BtnRefresh.TabIndex = 111
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'BtnAddNew
        '
        Me.BtnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddNew.Image = Global.Business_Expert_Pro.My.Resources.Resources.Add_New4
        Me.BtnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddNew.Location = New System.Drawing.Point(9, 98)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(93, 40)
        Me.BtnAddNew.TabIndex = 108
        Me.BtnAddNew.Text = "Add New"
        Me.BtnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'GrdEmployeeSalary
        '
        Me.GrdEmployeeSalary.AllowUserToAddRows = False
        Me.GrdEmployeeSalary.AllowUserToDeleteRows = False
        Me.GrdEmployeeSalary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdEmployeeSalary.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdEmployeeSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdEmployeeSalary.Location = New System.Drawing.Point(6, 297)
        Me.GrdEmployeeSalary.Name = "GrdEmployeeSalary"
        Me.GrdEmployeeSalary.ReadOnly = True
        Me.GrdEmployeeSalary.Size = New System.Drawing.Size(839, 263)
        Me.GrdEmployeeSalary.TabIndex = 115
        '
        'FrmEmployeeSalary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(851, 571)
        Me.Controls.Add(Me.GrdEmployeeSalary)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.CmbSearch)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.GrpEmployeeSalary)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.PnlEmployeeSalary)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmEmployeeSalary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Salary"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.PnlEmployeeSalary.ResumeLayout(False)
        Me.PnlEmployeeSalary.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GrpEmployeeSalary.ResumeLayout(False)
        Me.GrpEmployeeSalary.PerformLayout()
        CType(Me.GrdEmployeeSalary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PnlEmployeeSalary As System.Windows.Forms.Panel
    Friend WithEvents LblEmployeeSalary As System.Windows.Forms.Label
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents LblEmployeeID As System.Windows.Forms.Label
    Friend WithEvents LblPaidAmount As System.Windows.Forms.Label
    Friend WithEvents LblDeductionAmount As System.Windows.Forms.Label
    Friend WithEvents LblRemarks As System.Windows.Forms.Label
    Friend WithEvents LblPaymentDate As System.Windows.Forms.Label
    Friend WithEvents LblSalaryID As System.Windows.Forms.Label
    Friend WithEvents TxtSalaryID As System.Windows.Forms.TextBox
    Friend WithEvents TxtDeductionAmount As System.Windows.Forms.TextBox
    Friend WithEvents TxtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents TxtPaidAmount As System.Windows.Forms.TextBox
    Friend WithEvents GrpEmployeeSalary As System.Windows.Forms.GroupBox
    Friend WithEvents DtpPaymentDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmbEmployeeID As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents CmbSearch As System.Windows.Forms.ComboBox
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
    Friend WithEvents GrdEmployeeSalary As System.Windows.Forms.DataGridView
End Class
