<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmToDoList
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
        Me.BtnAddNew = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnRefresh = New System.Windows.Forms.Button
        Me.LblDescription = New System.Windows.Forms.Label
        Me.TxtAppointmentID = New System.Windows.Forms.TextBox
        Me.LblTaskPersonName = New System.Windows.Forms.Label
        Me.TxtTaskPersonName = New System.Windows.Forms.TextBox
        Me.TxtRemindTime = New System.Windows.Forms.TextBox
        Me.LblAppointmentID = New System.Windows.Forms.Label
        Me.LblAccountType = New System.Windows.Forms.Label
        Me.LblNotificationStatus = New System.Windows.Forms.Label
        Me.CmbNotificationStatus = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GrpToDoList = New System.Windows.Forms.GroupBox
        Me.CmbStatus = New System.Windows.Forms.ComboBox
        Me.LblStatus = New System.Windows.Forms.Label
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.DtpRemindDate = New System.Windows.Forms.DateTimePicker
        Me.LblRemindDate = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxtSmsNotificationNo = New System.Windows.Forms.TextBox
        Me.LblSmsNotificationNo = New System.Windows.Forms.Label
        Me.PnlToDoList = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.LblToDoList = New System.Windows.Forms.Label
        Me.GrdToDoList = New System.Windows.Forms.DataGridView
        Me.GrpToDoList.SuspendLayout()
        Me.PnlToDoList.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GrdToDoList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnAddNew
        '
        Me.BtnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddNew.Image = Global.Business_Expert_Pro.My.Resources.Resources.Add_New3
        Me.BtnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddNew.Location = New System.Drawing.Point(14, 87)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(89, 39)
        Me.BtnAddNew.TabIndex = 1157
        Me.BtnAddNew.Text = "Add New"
        Me.BtnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Image = Global.Business_Expert_Pro.My.Resources.Resources.Delete_32px1
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(200, 87)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(89, 39)
        Me.BtnDelete.TabIndex = 1159
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Image = Global.Business_Expert_Pro.My.Resources.Resources.Edit_File_32px3
        Me.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUpdate.Location = New System.Drawing.Point(107, 87)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(89, 39)
        Me.BtnUpdate.TabIndex = 1158
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Image = Global.Business_Expert_Pro.My.Resources.Resources.Save_32px_32
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(505, 87)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(89, 39)
        Me.BtnSave.TabIndex = 1156
        Me.BtnSave.Text = "Save"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnRefresh
        '
        Me.BtnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefresh.Image = Global.Business_Expert_Pro.My.Resources.Resources.Reboot_32px2
        Me.BtnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRefresh.Location = New System.Drawing.Point(308, 87)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(89, 39)
        Me.BtnRefresh.TabIndex = 1162
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'LblDescription
        '
        Me.LblDescription.AutoSize = True
        Me.LblDescription.Location = New System.Drawing.Point(18, 57)
        Me.LblDescription.Name = "LblDescription"
        Me.LblDescription.Size = New System.Drawing.Size(63, 13)
        Me.LblDescription.TabIndex = 4
        Me.LblDescription.Text = "Description:"
        '
        'TxtAppointmentID
        '
        Me.TxtAppointmentID.Enabled = False
        Me.TxtAppointmentID.Location = New System.Drawing.Point(150, 31)
        Me.TxtAppointmentID.Name = "TxtAppointmentID"
        Me.TxtAppointmentID.Size = New System.Drawing.Size(125, 20)
        Me.TxtAppointmentID.TabIndex = 201
        '
        'LblTaskPersonName
        '
        Me.LblTaskPersonName.AutoSize = True
        Me.LblTaskPersonName.Location = New System.Drawing.Point(18, 147)
        Me.LblTaskPersonName.Name = "LblTaskPersonName"
        Me.LblTaskPersonName.Size = New System.Drawing.Size(101, 13)
        Me.LblTaskPersonName.TabIndex = 205
        Me.LblTaskPersonName.Text = "Task Person Name:"
        '
        'TxtTaskPersonName
        '
        Me.TxtTaskPersonName.Location = New System.Drawing.Point(150, 144)
        Me.TxtTaskPersonName.Name = "TxtTaskPersonName"
        Me.TxtTaskPersonName.Size = New System.Drawing.Size(189, 20)
        Me.TxtTaskPersonName.TabIndex = 203
        '
        'TxtRemindTime
        '
        Me.TxtRemindTime.Location = New System.Drawing.Point(150, 219)
        Me.TxtRemindTime.Name = "TxtRemindTime"
        Me.TxtRemindTime.Size = New System.Drawing.Size(125, 20)
        Me.TxtRemindTime.TabIndex = 206
        '
        'LblAppointmentID
        '
        Me.LblAppointmentID.AutoSize = True
        Me.LblAppointmentID.Location = New System.Drawing.Point(18, 31)
        Me.LblAppointmentID.Name = "LblAppointmentID"
        Me.LblAppointmentID.Size = New System.Drawing.Size(86, 13)
        Me.LblAppointmentID.TabIndex = 208
        Me.LblAppointmentID.Text = "Appointment  ID:"
        '
        'LblAccountType
        '
        Me.LblAccountType.AutoSize = True
        Me.LblAccountType.Location = New System.Drawing.Point(18, 222)
        Me.LblAccountType.Name = "LblAccountType"
        Me.LblAccountType.Size = New System.Drawing.Size(72, 13)
        Me.LblAccountType.TabIndex = 210
        Me.LblAccountType.Text = "Remind Time:"
        '
        'LblNotificationStatus
        '
        Me.LblNotificationStatus.AutoSize = True
        Me.LblNotificationStatus.Location = New System.Drawing.Point(18, 247)
        Me.LblNotificationStatus.Name = "LblNotificationStatus"
        Me.LblNotificationStatus.Size = New System.Drawing.Size(96, 13)
        Me.LblNotificationStatus.TabIndex = 212
        Me.LblNotificationStatus.Text = "Notification Status:"
        '
        'CmbNotificationStatus
        '
        Me.CmbNotificationStatus.AutoCompleteCustomSource.AddRange(New String() {"CURRENT", "SAVINGS", "FIXED DEPOSITE"})
        Me.CmbNotificationStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbNotificationStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.CmbNotificationStatus.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbNotificationStatus.FormattingEnabled = True
        Me.CmbNotificationStatus.Items.AddRange(New Object() {"YES", "NO"})
        Me.CmbNotificationStatus.Location = New System.Drawing.Point(150, 244)
        Me.CmbNotificationStatus.Name = "CmbNotificationStatus"
        Me.CmbNotificationStatus.Size = New System.Drawing.Size(125, 21)
        Me.CmbNotificationStatus.TabIndex = 207
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(87, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 24)
        Me.Label1.TabIndex = 2016
        Me.Label1.Text = "*"
        '
        'GrpToDoList
        '
        Me.GrpToDoList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpToDoList.Controls.Add(Me.CmbStatus)
        Me.GrpToDoList.Controls.Add(Me.LblStatus)
        Me.GrpToDoList.Controls.Add(Me.txtDescription)
        Me.GrpToDoList.Controls.Add(Me.Label2)
        Me.GrpToDoList.Controls.Add(Me.Label8)
        Me.GrpToDoList.Controls.Add(Me.DtpRemindDate)
        Me.GrpToDoList.Controls.Add(Me.LblRemindDate)
        Me.GrpToDoList.Controls.Add(Me.Label9)
        Me.GrpToDoList.Controls.Add(Me.TxtSmsNotificationNo)
        Me.GrpToDoList.Controls.Add(Me.LblSmsNotificationNo)
        Me.GrpToDoList.Controls.Add(Me.Label1)
        Me.GrpToDoList.Controls.Add(Me.CmbNotificationStatus)
        Me.GrpToDoList.Controls.Add(Me.LblNotificationStatus)
        Me.GrpToDoList.Controls.Add(Me.LblAccountType)
        Me.GrpToDoList.Controls.Add(Me.LblAppointmentID)
        Me.GrpToDoList.Controls.Add(Me.TxtRemindTime)
        Me.GrpToDoList.Controls.Add(Me.TxtTaskPersonName)
        Me.GrpToDoList.Controls.Add(Me.LblTaskPersonName)
        Me.GrpToDoList.Controls.Add(Me.TxtAppointmentID)
        Me.GrpToDoList.Controls.Add(Me.LblDescription)
        Me.GrpToDoList.Location = New System.Drawing.Point(14, 134)
        Me.GrpToDoList.Name = "GrpToDoList"
        Me.GrpToDoList.Size = New System.Drawing.Size(982, 309)
        Me.GrpToDoList.TabIndex = 1163
        Me.GrpToDoList.TabStop = False
        Me.GrpToDoList.Text = "To Do List"
        '
        'CmbStatus
        '
        Me.CmbStatus.AutoCompleteCustomSource.AddRange(New String() {"CURRENT", "SAVINGS", "FIXED DEPOSITE"})
        Me.CmbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.CmbStatus.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbStatus.FormattingEnabled = True
        Me.CmbStatus.Items.AddRange(New Object() {"COMPLETE", "INCOMPLETE"})
        Me.CmbStatus.Location = New System.Drawing.Point(150, 273)
        Me.CmbStatus.Name = "CmbStatus"
        Me.CmbStatus.Size = New System.Drawing.Size(125, 21)
        Me.CmbStatus.TabIndex = 208
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Location = New System.Drawing.Point(18, 276)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(40, 13)
        Me.LblStatus.TabIndex = 2036
        Me.LblStatus.Text = "Status:"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(150, 57)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(666, 81)
        Me.txtDescription.TabIndex = 202
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(281, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 2033
        Me.Label2.Text = "HH:MM:SS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label8.Location = New System.Drawing.Point(125, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 24)
        Me.Label8.TabIndex = 2032
        Me.Label8.Text = "*"
        '
        'DtpRemindDate
        '
        Me.DtpRemindDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpRemindDate.Location = New System.Drawing.Point(150, 194)
        Me.DtpRemindDate.Name = "DtpRemindDate"
        Me.DtpRemindDate.Size = New System.Drawing.Size(125, 20)
        Me.DtpRemindDate.TabIndex = 205
        Me.DtpRemindDate.Value = New Date(2017, 5, 15, 0, 0, 0, 0)
        '
        'LblRemindDate
        '
        Me.LblRemindDate.AutoSize = True
        Me.LblRemindDate.Location = New System.Drawing.Point(18, 197)
        Me.LblRemindDate.Name = "LblRemindDate"
        Me.LblRemindDate.Size = New System.Drawing.Size(72, 13)
        Me.LblRemindDate.TabIndex = 2030
        Me.LblRemindDate.Text = "Remind Date:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label9.Location = New System.Drawing.Point(125, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(17, 24)
        Me.Label9.TabIndex = 2029
        Me.Label9.Text = "*"
        '
        'TxtSmsNotificationNo
        '
        Me.TxtSmsNotificationNo.Cursor = System.Windows.Forms.Cursors.Default
        Me.TxtSmsNotificationNo.Location = New System.Drawing.Point(150, 169)
        Me.TxtSmsNotificationNo.Name = "TxtSmsNotificationNo"
        Me.TxtSmsNotificationNo.Size = New System.Drawing.Size(189, 20)
        Me.TxtSmsNotificationNo.TabIndex = 204
        '
        'LblSmsNotificationNo
        '
        Me.LblSmsNotificationNo.AutoSize = True
        Me.LblSmsNotificationNo.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblSmsNotificationNo.Location = New System.Drawing.Point(18, 172)
        Me.LblSmsNotificationNo.Name = "LblSmsNotificationNo"
        Me.LblSmsNotificationNo.Size = New System.Drawing.Size(106, 13)
        Me.LblSmsNotificationNo.TabIndex = 2028
        Me.LblSmsNotificationNo.Text = "SMS Notification No:"
        '
        'PnlToDoList
        '
        Me.PnlToDoList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlToDoList.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlToDoList.Controls.Add(Me.Panel2)
        Me.PnlToDoList.Controls.Add(Me.LblToDoList)
        Me.PnlToDoList.Location = New System.Drawing.Point(-1, 0)
        Me.PnlToDoList.Name = "PnlToDoList"
        Me.PnlToDoList.Size = New System.Drawing.Size(1006, 78)
        Me.PnlToDoList.TabIndex = 1166
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
        Me.Panel2.Size = New System.Drawing.Size(1006, 27)
        Me.Panel2.TabIndex = 2062
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(982, 0)
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
        Me.Btnminimized.Location = New System.Drawing.Point(922, 0)
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
        Me.Btnmaximized.Location = New System.Drawing.Point(952, 0)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1160
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'LblToDoList
        '
        Me.LblToDoList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblToDoList.AutoSize = True
        Me.LblToDoList.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblToDoList.ForeColor = System.Drawing.Color.White
        Me.LblToDoList.Location = New System.Drawing.Point(416, 34)
        Me.LblToDoList.Name = "LblToDoList"
        Me.LblToDoList.Size = New System.Drawing.Size(174, 37)
        Me.LblToDoList.TabIndex = 1
        Me.LblToDoList.Text = "To Do List"
        '
        'GrdToDoList
        '
        Me.GrdToDoList.AllowUserToAddRows = False
        Me.GrdToDoList.AllowUserToDeleteRows = False
        Me.GrdToDoList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdToDoList.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdToDoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdToDoList.Location = New System.Drawing.Point(14, 462)
        Me.GrdToDoList.Name = "GrdToDoList"
        Me.GrdToDoList.ReadOnly = True
        Me.GrdToDoList.Size = New System.Drawing.Size(982, 254)
        Me.GrdToDoList.TabIndex = 1167
        '
        'FrmToDoList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.GrdToDoList)
        Me.Controls.Add(Me.PnlToDoList)
        Me.Controls.Add(Me.GrpToDoList)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnAddNew)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmToDoList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "To Do List"
        Me.GrpToDoList.ResumeLayout(False)
        Me.GrpToDoList.PerformLayout()
        Me.PnlToDoList.ResumeLayout(False)
        Me.PnlToDoList.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.GrdToDoList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button
    Friend WithEvents LblDescription As System.Windows.Forms.Label
    Friend WithEvents TxtAppointmentID As System.Windows.Forms.TextBox
    Friend WithEvents LblTaskPersonName As System.Windows.Forms.Label
    Friend WithEvents TxtTaskPersonName As System.Windows.Forms.TextBox
    Friend WithEvents TxtRemindTime As System.Windows.Forms.TextBox
    Friend WithEvents LblAppointmentID As System.Windows.Forms.Label
    Friend WithEvents LblAccountType As System.Windows.Forms.Label
    Friend WithEvents LblNotificationStatus As System.Windows.Forms.Label
    Friend WithEvents CmbNotificationStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GrpToDoList As System.Windows.Forms.GroupBox
    Friend WithEvents PnlToDoList As System.Windows.Forms.Panel
    Friend WithEvents LblToDoList As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtSmsNotificationNo As System.Windows.Forms.TextBox
    Friend WithEvents LblSmsNotificationNo As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DtpRemindDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblRemindDate As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents CmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents LblStatus As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
    Friend WithEvents GrdToDoList As System.Windows.Forms.DataGridView
End Class
