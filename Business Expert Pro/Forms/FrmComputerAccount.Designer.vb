<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmComputerAccount
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
        Me.PnlComputerAccount = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.LblComputerAccount = New System.Windows.Forms.Label
        Me.LblComputerID = New System.Windows.Forms.Label
        Me.LblMACAddress = New System.Windows.Forms.Label
        Me.LblComputerName = New System.Windows.Forms.Label
        Me.LblComputerLocation = New System.Windows.Forms.Label
        Me.TxtComputerID = New System.Windows.Forms.TextBox
        Me.TxtComputerName = New System.Windows.Forms.TextBox
        Me.TxtComputerLocation = New System.Windows.Forms.TextBox
        Me.TxtMACAddress = New System.Windows.Forms.TextBox
        Me.GrpComputerAccount = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtRemarks = New System.Windows.Forms.TextBox
        Me.LblRemarks = New System.Windows.Forms.Label
        Me.BtnRefresh = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnAddNew = New System.Windows.Forms.Button
        Me.GrdComputerAccount = New System.Windows.Forms.DataGridView
        Me.PnlComputerAccount.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GrpComputerAccount.SuspendLayout()
        CType(Me.GrdComputerAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlComputerAccount
        '
        Me.PnlComputerAccount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlComputerAccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlComputerAccount.Controls.Add(Me.Panel1)
        Me.PnlComputerAccount.Controls.Add(Me.LblComputerAccount)
        Me.PnlComputerAccount.Location = New System.Drawing.Point(0, 0)
        Me.PnlComputerAccount.Name = "PnlComputerAccount"
        Me.PnlComputerAccount.Size = New System.Drawing.Size(929, 101)
        Me.PnlComputerAccount.TabIndex = 0
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
        Me.Panel1.Location = New System.Drawing.Point(-3, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(932, 29)
        Me.Panel1.TabIndex = 6
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(905, 1)
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
        Me.Btnminimized.Location = New System.Drawing.Point(854, 1)
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
        Me.Btnmaximized.Location = New System.Drawing.Point(879, 1)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1157
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'LblComputerAccount
        '
        Me.LblComputerAccount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblComputerAccount.AutoSize = True
        Me.LblComputerAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblComputerAccount.ForeColor = System.Drawing.Color.White
        Me.LblComputerAccount.Location = New System.Drawing.Point(314, 43)
        Me.LblComputerAccount.Name = "LblComputerAccount"
        Me.LblComputerAccount.Size = New System.Drawing.Size(300, 37)
        Me.LblComputerAccount.TabIndex = 1
        Me.LblComputerAccount.Text = "Computer Account"
        '
        'LblComputerID
        '
        Me.LblComputerID.AutoSize = True
        Me.LblComputerID.Location = New System.Drawing.Point(15, 24)
        Me.LblComputerID.Name = "LblComputerID"
        Me.LblComputerID.Size = New System.Drawing.Size(72, 13)
        Me.LblComputerID.TabIndex = 1
        Me.LblComputerID.Text = "Computer  ID:"
        '
        'LblMACAddress
        '
        Me.LblMACAddress.AutoSize = True
        Me.LblMACAddress.Location = New System.Drawing.Point(15, 51)
        Me.LblMACAddress.Name = "LblMACAddress"
        Me.LblMACAddress.Size = New System.Drawing.Size(74, 13)
        Me.LblMACAddress.TabIndex = 2
        Me.LblMACAddress.Text = "MAC Address:"
        '
        'LblComputerName
        '
        Me.LblComputerName.AutoSize = True
        Me.LblComputerName.Location = New System.Drawing.Point(15, 78)
        Me.LblComputerName.Name = "LblComputerName"
        Me.LblComputerName.Size = New System.Drawing.Size(86, 13)
        Me.LblComputerName.TabIndex = 3
        Me.LblComputerName.Text = "Computer Name:"
        '
        'LblComputerLocation
        '
        Me.LblComputerLocation.AutoSize = True
        Me.LblComputerLocation.Location = New System.Drawing.Point(424, 23)
        Me.LblComputerLocation.Name = "LblComputerLocation"
        Me.LblComputerLocation.Size = New System.Drawing.Size(99, 13)
        Me.LblComputerLocation.TabIndex = 4
        Me.LblComputerLocation.Text = "Computer Location:"
        '
        'TxtComputerID
        '
        Me.TxtComputerID.Enabled = False
        Me.TxtComputerID.Location = New System.Drawing.Point(120, 21)
        Me.TxtComputerID.Name = "TxtComputerID"
        Me.TxtComputerID.Size = New System.Drawing.Size(70, 20)
        Me.TxtComputerID.TabIndex = 101
        '
        'TxtComputerName
        '
        Me.TxtComputerName.Location = New System.Drawing.Point(120, 75)
        Me.TxtComputerName.Name = "TxtComputerName"
        Me.TxtComputerName.Size = New System.Drawing.Size(222, 20)
        Me.TxtComputerName.TabIndex = 103
        '
        'TxtComputerLocation
        '
        Me.TxtComputerLocation.Location = New System.Drawing.Point(540, 21)
        Me.TxtComputerLocation.Name = "TxtComputerLocation"
        Me.TxtComputerLocation.Size = New System.Drawing.Size(222, 20)
        Me.TxtComputerLocation.TabIndex = 104
        '
        'TxtMACAddress
        '
        Me.TxtMACAddress.Location = New System.Drawing.Point(120, 48)
        Me.TxtMACAddress.Name = "TxtMACAddress"
        Me.TxtMACAddress.Size = New System.Drawing.Size(222, 20)
        Me.TxtMACAddress.TabIndex = 102
        '
        'GrpComputerAccount
        '
        Me.GrpComputerAccount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpComputerAccount.Controls.Add(Me.Label2)
        Me.GrpComputerAccount.Controls.Add(Me.TxtRemarks)
        Me.GrpComputerAccount.Controls.Add(Me.LblRemarks)
        Me.GrpComputerAccount.Controls.Add(Me.TxtMACAddress)
        Me.GrpComputerAccount.Controls.Add(Me.TxtComputerLocation)
        Me.GrpComputerAccount.Controls.Add(Me.TxtComputerName)
        Me.GrpComputerAccount.Controls.Add(Me.TxtComputerID)
        Me.GrpComputerAccount.Controls.Add(Me.LblComputerLocation)
        Me.GrpComputerAccount.Controls.Add(Me.LblComputerName)
        Me.GrpComputerAccount.Controls.Add(Me.LblMACAddress)
        Me.GrpComputerAccount.Controls.Add(Me.LblComputerID)
        Me.GrpComputerAccount.Location = New System.Drawing.Point(7, 169)
        Me.GrpComputerAccount.Name = "GrpComputerAccount"
        Me.GrpComputerAccount.Size = New System.Drawing.Size(914, 111)
        Me.GrpComputerAccount.TabIndex = 9
        Me.GrpComputerAccount.TabStop = False
        Me.GrpComputerAccount.Text = "Computer Account"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(99, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 24)
        Me.Label2.TabIndex = 2018
        Me.Label2.Text = "*"
        '
        'TxtRemarks
        '
        Me.TxtRemarks.Location = New System.Drawing.Point(540, 49)
        Me.TxtRemarks.Multiline = True
        Me.TxtRemarks.Name = "TxtRemarks"
        Me.TxtRemarks.Size = New System.Drawing.Size(222, 42)
        Me.TxtRemarks.TabIndex = 105
        '
        'LblRemarks
        '
        Me.LblRemarks.AutoSize = True
        Me.LblRemarks.Location = New System.Drawing.Point(424, 52)
        Me.LblRemarks.Name = "LblRemarks"
        Me.LblRemarks.Size = New System.Drawing.Size(52, 13)
        Me.LblRemarks.TabIndex = 105
        Me.LblRemarks.Text = "Remarks:"
        '
        'BtnRefresh
        '
        Me.BtnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefresh.Image = Global.Business_Expert_Pro.My.Resources.Resources.Reboot_32px
        Me.BtnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRefresh.Location = New System.Drawing.Point(303, 120)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(89, 37)
        Me.BtnRefresh.TabIndex = 111
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Image = Global.Business_Expert_Pro.My.Resources.Resources.Save_32px_31
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(481, 120)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(89, 36)
        Me.BtnSave.TabIndex = 107
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
        Me.BtnUpdate.Location = New System.Drawing.Point(107, 121)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(89, 36)
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
        Me.BtnDelete.Location = New System.Drawing.Point(205, 121)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(89, 36)
        Me.BtnDelete.TabIndex = 110
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.UseVisualStyleBackColor = True
        Me.BtnDelete.Visible = False
        '
        'BtnAddNew
        '
        Me.BtnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddNew.Image = Global.Business_Expert_Pro.My.Resources.Resources.Add_New2
        Me.BtnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddNew.Location = New System.Drawing.Point(9, 121)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(89, 36)
        Me.BtnAddNew.TabIndex = 108
        Me.BtnAddNew.Text = "Add New"
        Me.BtnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'GrdComputerAccount
        '
        Me.GrdComputerAccount.AllowUserToAddRows = False
        Me.GrdComputerAccount.AllowUserToDeleteRows = False
        Me.GrdComputerAccount.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdComputerAccount.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdComputerAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdComputerAccount.Location = New System.Drawing.Point(8, 291)
        Me.GrdComputerAccount.Name = "GrdComputerAccount"
        Me.GrdComputerAccount.ReadOnly = True
        Me.GrdComputerAccount.Size = New System.Drawing.Size(913, 222)
        Me.GrdComputerAccount.TabIndex = 112
        '
        'FrmComputerAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(929, 518)
        Me.Controls.Add(Me.GrdComputerAccount)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.GrpComputerAccount)
        Me.Controls.Add(Me.PnlComputerAccount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmComputerAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Computer Account"
        Me.PnlComputerAccount.ResumeLayout(False)
        Me.PnlComputerAccount.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GrpComputerAccount.ResumeLayout(False)
        Me.GrpComputerAccount.PerformLayout()
        CType(Me.GrdComputerAccount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlComputerAccount As System.Windows.Forms.Panel
    Friend WithEvents LblComputerAccount As System.Windows.Forms.Label
    Friend WithEvents LblComputerID As System.Windows.Forms.Label
    Friend WithEvents LblMACAddress As System.Windows.Forms.Label
    Friend WithEvents LblComputerName As System.Windows.Forms.Label
    Friend WithEvents LblComputerLocation As System.Windows.Forms.Label
    Friend WithEvents TxtComputerID As System.Windows.Forms.TextBox
    Friend WithEvents TxtComputerName As System.Windows.Forms.TextBox
    Friend WithEvents TxtComputerLocation As System.Windows.Forms.TextBox
    Friend WithEvents TxtMACAddress As System.Windows.Forms.TextBox
    Friend WithEvents GrpComputerAccount As System.Windows.Forms.GroupBox
    Friend WithEvents TxtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents LblRemarks As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
    Friend WithEvents GrdComputerAccount As System.Windows.Forms.DataGridView
End Class
