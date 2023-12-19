<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmServerInformation
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
        Me.BtnRefrersh = New System.Windows.Forms.Button
        Me.BtnInsert = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnAddNew = New System.Windows.Forms.Button
        Me.GrpServerInformation = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtDescription = New System.Windows.Forms.TextBox
        Me.LblDescription = New System.Windows.Forms.Label
        Me.TxtStatus = New System.Windows.Forms.TextBox
        Me.LblStatus = New System.Windows.Forms.Label
        Me.TxtLicenceCode = New System.Windows.Forms.TextBox
        Me.LblLicenceCode = New System.Windows.Forms.Label
        Me.TxtBEMac = New System.Windows.Forms.TextBox
        Me.TxtServerID = New System.Windows.Forms.TextBox
        Me.LblBEMac = New System.Windows.Forms.Label
        Me.LblServerID = New System.Windows.Forms.Label
        Me.PnlClassDetails = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.LblServerInformation = New System.Windows.Forms.Label
        Me.GrdServerInformation = New System.Windows.Forms.DataGridView
        Me.GrpServerInformation.SuspendLayout()
        Me.PnlClassDetails.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GrdServerInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnRefrersh
        '
        Me.BtnRefrersh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRefrersh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefrersh.Image = Global.Business_Expert_Pro.My.Resources.Resources.Reboot_32px1
        Me.BtnRefrersh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRefrersh.Location = New System.Drawing.Point(309, 122)
        Me.BtnRefrersh.Name = "BtnRefrersh"
        Me.BtnRefrersh.Size = New System.Drawing.Size(89, 39)
        Me.BtnRefrersh.TabIndex = 1112
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
        Me.BtnInsert.Location = New System.Drawing.Point(422, 122)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(89, 39)
        Me.BtnInsert.TabIndex = 1105
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
        Me.BtnUpdate.Location = New System.Drawing.Point(119, 122)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(89, 39)
        Me.BtnUpdate.TabIndex = 1106
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
        Me.BtnDelete.Location = New System.Drawing.Point(214, 122)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(89, 39)
        Me.BtnDelete.TabIndex = 1108
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnAddNew
        '
        Me.BtnAddNew.BackgroundImage = Global.Business_Expert_Pro.My.Resources.Resources.Add_New3
        Me.BtnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddNew.Location = New System.Drawing.Point(15, 122)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(89, 39)
        Me.BtnAddNew.TabIndex = 1107
        Me.BtnAddNew.Text = "Add New"
        Me.BtnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'GrpServerInformation
        '
        Me.GrpServerInformation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpServerInformation.Controls.Add(Me.Label6)
        Me.GrpServerInformation.Controls.Add(Me.TxtDescription)
        Me.GrpServerInformation.Controls.Add(Me.LblDescription)
        Me.GrpServerInformation.Controls.Add(Me.TxtStatus)
        Me.GrpServerInformation.Controls.Add(Me.LblStatus)
        Me.GrpServerInformation.Controls.Add(Me.TxtLicenceCode)
        Me.GrpServerInformation.Controls.Add(Me.LblLicenceCode)
        Me.GrpServerInformation.Controls.Add(Me.TxtBEMac)
        Me.GrpServerInformation.Controls.Add(Me.TxtServerID)
        Me.GrpServerInformation.Controls.Add(Me.LblBEMac)
        Me.GrpServerInformation.Controls.Add(Me.LblServerID)
        Me.GrpServerInformation.Location = New System.Drawing.Point(15, 179)
        Me.GrpServerInformation.Name = "GrpServerInformation"
        Me.GrpServerInformation.Size = New System.Drawing.Size(897, 169)
        Me.GrpServerInformation.TabIndex = 1103
        Me.GrpServerInformation.TabStop = False
        Me.GrpServerInformation.Text = "Server Information"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(89, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 24)
        Me.Label6.TabIndex = 2029
        Me.Label6.Text = "*"
        '
        'TxtDescription
        '
        Me.TxtDescription.Location = New System.Drawing.Point(112, 134)
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.Size = New System.Drawing.Size(124, 20)
        Me.TxtDescription.TabIndex = 105
        '
        'LblDescription
        '
        Me.LblDescription.AutoSize = True
        Me.LblDescription.Location = New System.Drawing.Point(14, 137)
        Me.LblDescription.Name = "LblDescription"
        Me.LblDescription.Size = New System.Drawing.Size(63, 13)
        Me.LblDescription.TabIndex = 107
        Me.LblDescription.Text = "Description:"
        '
        'TxtStatus
        '
        Me.TxtStatus.Location = New System.Drawing.Point(112, 108)
        Me.TxtStatus.Name = "TxtStatus"
        Me.TxtStatus.Size = New System.Drawing.Size(124, 20)
        Me.TxtStatus.TabIndex = 104
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Location = New System.Drawing.Point(14, 111)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(40, 13)
        Me.LblStatus.TabIndex = 105
        Me.LblStatus.Text = "Status:"
        '
        'TxtLicenceCode
        '
        Me.TxtLicenceCode.Location = New System.Drawing.Point(112, 82)
        Me.TxtLicenceCode.Name = "TxtLicenceCode"
        Me.TxtLicenceCode.Size = New System.Drawing.Size(124, 20)
        Me.TxtLicenceCode.TabIndex = 103
        '
        'LblLicenceCode
        '
        Me.LblLicenceCode.AutoSize = True
        Me.LblLicenceCode.Location = New System.Drawing.Point(14, 85)
        Me.LblLicenceCode.Name = "LblLicenceCode"
        Me.LblLicenceCode.Size = New System.Drawing.Size(76, 13)
        Me.LblLicenceCode.TabIndex = 103
        Me.LblLicenceCode.Text = "Licence Code:"
        '
        'TxtBEMac
        '
        Me.TxtBEMac.Location = New System.Drawing.Point(112, 56)
        Me.TxtBEMac.Name = "TxtBEMac"
        Me.TxtBEMac.Size = New System.Drawing.Size(124, 20)
        Me.TxtBEMac.TabIndex = 102
        '
        'TxtServerID
        '
        Me.TxtServerID.Enabled = False
        Me.TxtServerID.Location = New System.Drawing.Point(112, 30)
        Me.TxtServerID.Name = "TxtServerID"
        Me.TxtServerID.Size = New System.Drawing.Size(66, 20)
        Me.TxtServerID.TabIndex = 101
        '
        'LblBEMac
        '
        Me.LblBEMac.AutoSize = True
        Me.LblBEMac.Location = New System.Drawing.Point(14, 59)
        Me.LblBEMac.Name = "LblBEMac"
        Me.LblBEMac.Size = New System.Drawing.Size(48, 13)
        Me.LblBEMac.TabIndex = 2
        Me.LblBEMac.Text = "BE Mac:"
        '
        'LblServerID
        '
        Me.LblServerID.AutoSize = True
        Me.LblServerID.Location = New System.Drawing.Point(14, 33)
        Me.LblServerID.Name = "LblServerID"
        Me.LblServerID.Size = New System.Drawing.Size(55, 13)
        Me.LblServerID.TabIndex = 1
        Me.LblServerID.Text = "Server ID:"
        '
        'PnlClassDetails
        '
        Me.PnlClassDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlClassDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlClassDetails.Controls.Add(Me.Panel2)
        Me.PnlClassDetails.Controls.Add(Me.LblServerInformation)
        Me.PnlClassDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlClassDetails.Location = New System.Drawing.Point(0, 0)
        Me.PnlClassDetails.Name = "PnlClassDetails"
        Me.PnlClassDetails.Size = New System.Drawing.Size(923, 107)
        Me.PnlClassDetails.TabIndex = 1102
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
        Me.Panel2.Size = New System.Drawing.Size(922, 27)
        Me.Panel2.TabIndex = 2060
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(898, 0)
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
        Me.Btnminimized.Location = New System.Drawing.Point(838, 0)
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
        Me.Btnmaximized.Location = New System.Drawing.Point(868, 0)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1160
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'LblServerInformation
        '
        Me.LblServerInformation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblServerInformation.AutoSize = True
        Me.LblServerInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblServerInformation.ForeColor = System.Drawing.Color.White
        Me.LblServerInformation.Location = New System.Drawing.Point(313, 48)
        Me.LblServerInformation.Name = "LblServerInformation"
        Me.LblServerInformation.Size = New System.Drawing.Size(297, 37)
        Me.LblServerInformation.TabIndex = 2
        Me.LblServerInformation.Text = "Server Information"
        '
        'GrdServerInformation
        '
        Me.GrdServerInformation.AllowUserToAddRows = False
        Me.GrdServerInformation.AllowUserToDeleteRows = False
        Me.GrdServerInformation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdServerInformation.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdServerInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdServerInformation.Location = New System.Drawing.Point(15, 356)
        Me.GrdServerInformation.Name = "GrdServerInformation"
        Me.GrdServerInformation.ReadOnly = True
        Me.GrdServerInformation.Size = New System.Drawing.Size(897, 185)
        Me.GrdServerInformation.TabIndex = 1113
        '
        'FrmServerInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(924, 551)
        Me.Controls.Add(Me.GrdServerInformation)
        Me.Controls.Add(Me.BtnRefrersh)
        Me.Controls.Add(Me.BtnInsert)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.GrpServerInformation)
        Me.Controls.Add(Me.PnlClassDetails)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmServerInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Server Information"
        Me.GrpServerInformation.ResumeLayout(False)
        Me.GrpServerInformation.PerformLayout()
        Me.PnlClassDetails.ResumeLayout(False)
        Me.PnlClassDetails.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.GrdServerInformation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnRefrersh As System.Windows.Forms.Button
    Friend WithEvents BtnInsert As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
    Friend WithEvents GrpServerInformation As System.Windows.Forms.GroupBox
    Friend WithEvents TxtBEMac As System.Windows.Forms.TextBox
    Friend WithEvents TxtServerID As System.Windows.Forms.TextBox
    Friend WithEvents LblBEMac As System.Windows.Forms.Label
    Friend WithEvents LblServerID As System.Windows.Forms.Label
    Friend WithEvents PnlClassDetails As System.Windows.Forms.Panel
    Friend WithEvents LblServerInformation As System.Windows.Forms.Label
    Friend WithEvents TxtLicenceCode As System.Windows.Forms.TextBox
    Friend WithEvents LblLicenceCode As System.Windows.Forms.Label
    Friend WithEvents TxtDescription As System.Windows.Forms.TextBox
    Friend WithEvents LblDescription As System.Windows.Forms.Label
    Friend WithEvents TxtStatus As System.Windows.Forms.TextBox
    Friend WithEvents LblStatus As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
    Friend WithEvents GrdServerInformation As System.Windows.Forms.DataGridView
End Class
