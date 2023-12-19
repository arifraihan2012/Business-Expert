<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLanguageInformation
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
        Me.PnlLanguageSetting = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.LblLanguageSetting = New System.Windows.Forms.Label
        Me.TxtLanguageID = New System.Windows.Forms.TextBox
        Me.LblLanguageID = New System.Windows.Forms.Label
        Me.TxtLanguageStatus = New System.Windows.Forms.TextBox
        Me.LblLanguageStatus = New System.Windows.Forms.Label
        Me.TxtLanguageFont = New System.Windows.Forms.TextBox
        Me.LblLanguageFont = New System.Windows.Forms.Label
        Me.TxtLanguageName = New System.Windows.Forms.TextBox
        Me.LblLanguageName = New System.Windows.Forms.Label
        Me.GrpLanguageSetting = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtFontSize = New System.Windows.Forms.TextBox
        Me.LblFontSize = New System.Windows.Forms.Label
        Me.BtnInsert = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.BtnAddNew = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.GrdLanguageSetting = New System.Windows.Forms.DataGridView
        Me.PnlLanguageSetting.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GrpLanguageSetting.SuspendLayout()
        CType(Me.GrdLanguageSetting, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlLanguageSetting
        '
        Me.PnlLanguageSetting.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlLanguageSetting.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlLanguageSetting.Controls.Add(Me.Panel1)
        Me.PnlLanguageSetting.Controls.Add(Me.LblLanguageSetting)
        Me.PnlLanguageSetting.Location = New System.Drawing.Point(0, 0)
        Me.PnlLanguageSetting.Name = "PnlLanguageSetting"
        Me.PnlLanguageSetting.Size = New System.Drawing.Size(834, 100)
        Me.PnlLanguageSetting.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Btnclose)
        Me.Panel1.Controls.Add(Me.Btnminimized)
        Me.Panel1.Controls.Add(Me.Btnmaximized)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(831, 31)
        Me.Panel1.TabIndex = 5
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(806, 2)
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
        Me.Btnminimized.Location = New System.Drawing.Point(746, 2)
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
        Me.Btnmaximized.Location = New System.Drawing.Point(776, 2)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1160
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'LblLanguageSetting
        '
        Me.LblLanguageSetting.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblLanguageSetting.AutoSize = True
        Me.LblLanguageSetting.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLanguageSetting.ForeColor = System.Drawing.Color.White
        Me.LblLanguageSetting.Location = New System.Drawing.Point(242, 43)
        Me.LblLanguageSetting.Name = "LblLanguageSetting"
        Me.LblLanguageSetting.Size = New System.Drawing.Size(350, 37)
        Me.LblLanguageSetting.TabIndex = 0
        Me.LblLanguageSetting.Text = "Language Information"
        '
        'TxtLanguageID
        '
        Me.TxtLanguageID.Enabled = False
        Me.TxtLanguageID.Location = New System.Drawing.Point(160, 23)
        Me.TxtLanguageID.Name = "TxtLanguageID"
        Me.TxtLanguageID.Size = New System.Drawing.Size(89, 20)
        Me.TxtLanguageID.TabIndex = 201
        '
        'LblLanguageID
        '
        Me.LblLanguageID.AutoSize = True
        Me.LblLanguageID.Location = New System.Drawing.Point(25, 26)
        Me.LblLanguageID.Name = "LblLanguageID"
        Me.LblLanguageID.Size = New System.Drawing.Size(72, 13)
        Me.LblLanguageID.TabIndex = 179
        Me.LblLanguageID.Text = "Language ID:"
        '
        'TxtLanguageStatus
        '
        Me.TxtLanguageStatus.Location = New System.Drawing.Point(160, 131)
        Me.TxtLanguageStatus.Name = "TxtLanguageStatus"
        Me.TxtLanguageStatus.Size = New System.Drawing.Size(76, 20)
        Me.TxtLanguageStatus.TabIndex = 205
        '
        'LblLanguageStatus
        '
        Me.LblLanguageStatus.AutoSize = True
        Me.LblLanguageStatus.Location = New System.Drawing.Point(25, 134)
        Me.LblLanguageStatus.Name = "LblLanguageStatus"
        Me.LblLanguageStatus.Size = New System.Drawing.Size(91, 13)
        Me.LblLanguageStatus.TabIndex = 181
        Me.LblLanguageStatus.Text = "Language Status:"
        '
        'TxtLanguageFont
        '
        Me.TxtLanguageFont.Location = New System.Drawing.Point(160, 79)
        Me.TxtLanguageFont.Name = "TxtLanguageFont"
        Me.TxtLanguageFont.Size = New System.Drawing.Size(155, 20)
        Me.TxtLanguageFont.TabIndex = 203
        '
        'LblLanguageFont
        '
        Me.LblLanguageFont.AutoSize = True
        Me.LblLanguageFont.Location = New System.Drawing.Point(25, 82)
        Me.LblLanguageFont.Name = "LblLanguageFont"
        Me.LblLanguageFont.Size = New System.Drawing.Size(82, 13)
        Me.LblLanguageFont.TabIndex = 183
        Me.LblLanguageFont.Text = "Language Font:"
        '
        'TxtLanguageName
        '
        Me.TxtLanguageName.Location = New System.Drawing.Point(160, 51)
        Me.TxtLanguageName.Name = "TxtLanguageName"
        Me.TxtLanguageName.Size = New System.Drawing.Size(155, 20)
        Me.TxtLanguageName.TabIndex = 202
        '
        'LblLanguageName
        '
        Me.LblLanguageName.AutoSize = True
        Me.LblLanguageName.Location = New System.Drawing.Point(25, 54)
        Me.LblLanguageName.Name = "LblLanguageName"
        Me.LblLanguageName.Size = New System.Drawing.Size(89, 13)
        Me.LblLanguageName.TabIndex = 185
        Me.LblLanguageName.Text = "Language Name:"
        '
        'GrpLanguageSetting
        '
        Me.GrpLanguageSetting.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpLanguageSetting.Controls.Add(Me.Label2)
        Me.GrpLanguageSetting.Controls.Add(Me.Label6)
        Me.GrpLanguageSetting.Controls.Add(Me.Label1)
        Me.GrpLanguageSetting.Controls.Add(Me.TxtFontSize)
        Me.GrpLanguageSetting.Controls.Add(Me.LblFontSize)
        Me.GrpLanguageSetting.Controls.Add(Me.TxtLanguageName)
        Me.GrpLanguageSetting.Controls.Add(Me.LblLanguageName)
        Me.GrpLanguageSetting.Controls.Add(Me.TxtLanguageFont)
        Me.GrpLanguageSetting.Controls.Add(Me.LblLanguageFont)
        Me.GrpLanguageSetting.Controls.Add(Me.TxtLanguageStatus)
        Me.GrpLanguageSetting.Controls.Add(Me.LblLanguageStatus)
        Me.GrpLanguageSetting.Controls.Add(Me.TxtLanguageID)
        Me.GrpLanguageSetting.Controls.Add(Me.LblLanguageID)
        Me.GrpLanguageSetting.Location = New System.Drawing.Point(7, 175)
        Me.GrpLanguageSetting.Name = "GrpLanguageSetting"
        Me.GrpLanguageSetting.Size = New System.Drawing.Size(820, 162)
        Me.GrpLanguageSetting.TabIndex = 186
        Me.GrpLanguageSetting.TabStop = False
        Me.GrpLanguageSetting.Text = "Language Setting"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(103, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 24)
        Me.Label2.TabIndex = 2031
        Me.Label2.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(80, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 24)
        Me.Label6.TabIndex = 2029
        Me.Label6.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(120, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 24)
        Me.Label1.TabIndex = 2030
        Me.Label1.Text = "*"
        '
        'TxtFontSize
        '
        Me.TxtFontSize.Location = New System.Drawing.Point(160, 105)
        Me.TxtFontSize.Name = "TxtFontSize"
        Me.TxtFontSize.Size = New System.Drawing.Size(103, 20)
        Me.TxtFontSize.TabIndex = 204
        '
        'LblFontSize
        '
        Me.LblFontSize.AutoSize = True
        Me.LblFontSize.Location = New System.Drawing.Point(25, 108)
        Me.LblFontSize.Name = "LblFontSize"
        Me.LblFontSize.Size = New System.Drawing.Size(54, 13)
        Me.LblFontSize.TabIndex = 205
        Me.LblFontSize.Text = "Font Size:"
        '
        'BtnInsert
        '
        Me.BtnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInsert.Image = Global.Business_Expert_Pro.My.Resources.Resources.Save_32px_31
        Me.BtnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInsert.Location = New System.Drawing.Point(441, 115)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(94, 42)
        Me.BtnInsert.TabIndex = 192
        Me.BtnInsert.Text = "Save"
        Me.BtnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnInsert.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Image = Global.Business_Expert_Pro.My.Resources.Resources.Edit_File_32px2
        Me.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUpdate.Location = New System.Drawing.Point(113, 115)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(94, 42)
        Me.BtnUpdate.TabIndex = 191
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnAddNew
        '
        Me.BtnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddNew.Image = Global.Business_Expert_Pro.My.Resources.Resources.Add_New2
        Me.BtnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddNew.Location = New System.Drawing.Point(10, 115)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(94, 42)
        Me.BtnAddNew.TabIndex = 189
        Me.BtnAddNew.Text = "Add New"
        Me.BtnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.Image = Global.Business_Expert_Pro.My.Resources.Resources.Delete_32px2
        Me.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndelete.Location = New System.Drawing.Point(216, 115)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(94, 42)
        Me.btndelete.TabIndex = 190
        Me.btndelete.Text = "Delete"
        Me.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btndelete.UseVisualStyleBackColor = True
        Me.btndelete.Visible = False
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.Business_Expert_Pro.My.Resources.Resources.Reboot_32px
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(319, 115)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 42)
        Me.Button2.TabIndex = 193
        Me.Button2.Text = "Refresh"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GrdLanguageSetting
        '
        Me.GrdLanguageSetting.AllowUserToAddRows = False
        Me.GrdLanguageSetting.AllowUserToDeleteRows = False
        Me.GrdLanguageSetting.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdLanguageSetting.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdLanguageSetting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdLanguageSetting.Location = New System.Drawing.Point(7, 345)
        Me.GrdLanguageSetting.Name = "GrdLanguageSetting"
        Me.GrdLanguageSetting.ReadOnly = True
        Me.GrdLanguageSetting.Size = New System.Drawing.Size(820, 196)
        Me.GrdLanguageSetting.TabIndex = 194
        '
        'FrmLanguageInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(833, 546)
        Me.Controls.Add(Me.GrdLanguageSetting)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnInsert)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.GrpLanguageSetting)
        Me.Controls.Add(Me.PnlLanguageSetting)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmLanguageInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Language Information"
        Me.PnlLanguageSetting.ResumeLayout(False)
        Me.PnlLanguageSetting.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GrpLanguageSetting.ResumeLayout(False)
        Me.GrpLanguageSetting.PerformLayout()
        CType(Me.GrdLanguageSetting, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlLanguageSetting As System.Windows.Forms.Panel
    Friend WithEvents LblLanguageSetting As System.Windows.Forms.Label
    Friend WithEvents TxtLanguageID As System.Windows.Forms.TextBox
    Friend WithEvents LblLanguageID As System.Windows.Forms.Label
    Friend WithEvents TxtLanguageStatus As System.Windows.Forms.TextBox
    Friend WithEvents LblLanguageStatus As System.Windows.Forms.Label
    Friend WithEvents TxtLanguageFont As System.Windows.Forms.TextBox
    Friend WithEvents LblLanguageFont As System.Windows.Forms.Label
    Friend WithEvents TxtLanguageName As System.Windows.Forms.TextBox
    Friend WithEvents LblLanguageName As System.Windows.Forms.Label
    Friend WithEvents GrpLanguageSetting As System.Windows.Forms.GroupBox
    Friend WithEvents BtnInsert As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents TxtFontSize As System.Windows.Forms.TextBox
    Friend WithEvents LblFontSize As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
    Friend WithEvents GrdLanguageSetting As System.Windows.Forms.DataGridView
End Class
