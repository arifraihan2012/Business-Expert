<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBranchInformation
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
        Me.PnlBranchInformation = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.LblBranchInformation = New System.Windows.Forms.Label
        Me.TxtBranchPhoneNo = New System.Windows.Forms.TextBox
        Me.TxtBranchAddress = New System.Windows.Forms.TextBox
        Me.TxtBranchManager = New System.Windows.Forms.TextBox
        Me.TxtBranchID = New System.Windows.Forms.TextBox
        Me.LblBranchPhoneNo = New System.Windows.Forms.Label
        Me.LblBranchAddress = New System.Windows.Forms.Label
        Me.LblBranchManager = New System.Windows.Forms.Label
        Me.LblBranchName = New System.Windows.Forms.Label
        Me.LblBranchID = New System.Windows.Forms.Label
        Me.GrpBranchInformation = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtBranchName = New System.Windows.Forms.TextBox
        Me.GrdBranchInformation = New System.Windows.Forms.DataGridView
        Me.BtnRefresh = New System.Windows.Forms.Button
        Me.BtnInsert = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnAddNew = New System.Windows.Forms.Button
        Me.PnlBranchInformation.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GrpBranchInformation.SuspendLayout()
        CType(Me.GrdBranchInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlBranchInformation
        '
        Me.PnlBranchInformation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlBranchInformation.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlBranchInformation.Controls.Add(Me.Panel1)
        Me.PnlBranchInformation.Controls.Add(Me.LblBranchInformation)
        Me.PnlBranchInformation.Location = New System.Drawing.Point(0, 0)
        Me.PnlBranchInformation.Name = "PnlBranchInformation"
        Me.PnlBranchInformation.Size = New System.Drawing.Size(839, 95)
        Me.PnlBranchInformation.TabIndex = 0
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
        Me.Panel1.Location = New System.Drawing.Point(-5, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(844, 31)
        Me.Panel1.TabIndex = 3
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(817, 2)
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
        Me.Btnminimized.Location = New System.Drawing.Point(757, 2)
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
        Me.Btnmaximized.Location = New System.Drawing.Point(787, 2)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1157
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'LblBranchInformation
        '
        Me.LblBranchInformation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblBranchInformation.AutoSize = True
        Me.LblBranchInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBranchInformation.ForeColor = System.Drawing.Color.White
        Me.LblBranchInformation.Location = New System.Drawing.Point(266, 39)
        Me.LblBranchInformation.Name = "LblBranchInformation"
        Me.LblBranchInformation.Size = New System.Drawing.Size(307, 37)
        Me.LblBranchInformation.TabIndex = 0
        Me.LblBranchInformation.Text = "Branch Information"
        '
        'TxtBranchPhoneNo
        '
        Me.TxtBranchPhoneNo.Location = New System.Drawing.Point(497, 81)
        Me.TxtBranchPhoneNo.Name = "TxtBranchPhoneNo"
        Me.TxtBranchPhoneNo.Size = New System.Drawing.Size(211, 20)
        Me.TxtBranchPhoneNo.TabIndex = 1014
        '
        'TxtBranchAddress
        '
        Me.TxtBranchAddress.Location = New System.Drawing.Point(497, 19)
        Me.TxtBranchAddress.Multiline = True
        Me.TxtBranchAddress.Name = "TxtBranchAddress"
        Me.TxtBranchAddress.Size = New System.Drawing.Size(211, 51)
        Me.TxtBranchAddress.TabIndex = 1013
        '
        'TxtBranchManager
        '
        Me.TxtBranchManager.Location = New System.Drawing.Point(109, 88)
        Me.TxtBranchManager.Name = "TxtBranchManager"
        Me.TxtBranchManager.Size = New System.Drawing.Size(174, 20)
        Me.TxtBranchManager.TabIndex = 1012
        '
        'TxtBranchID
        '
        Me.TxtBranchID.Enabled = False
        Me.TxtBranchID.Location = New System.Drawing.Point(109, 26)
        Me.TxtBranchID.Name = "TxtBranchID"
        Me.TxtBranchID.Size = New System.Drawing.Size(75, 20)
        Me.TxtBranchID.TabIndex = 1010
        '
        'LblBranchPhoneNo
        '
        Me.LblBranchPhoneNo.AutoSize = True
        Me.LblBranchPhoneNo.Location = New System.Drawing.Point(367, 84)
        Me.LblBranchPhoneNo.Name = "LblBranchPhoneNo"
        Me.LblBranchPhoneNo.Size = New System.Drawing.Size(95, 13)
        Me.LblBranchPhoneNo.TabIndex = 119
        Me.LblBranchPhoneNo.Text = "Branch Phone No:"
        '
        'LblBranchAddress
        '
        Me.LblBranchAddress.AutoSize = True
        Me.LblBranchAddress.Location = New System.Drawing.Point(367, 37)
        Me.LblBranchAddress.Name = "LblBranchAddress"
        Me.LblBranchAddress.Size = New System.Drawing.Size(85, 13)
        Me.LblBranchAddress.TabIndex = 118
        Me.LblBranchAddress.Text = "Branch Address:"
        '
        'LblBranchManager
        '
        Me.LblBranchManager.AutoSize = True
        Me.LblBranchManager.Location = New System.Drawing.Point(14, 88)
        Me.LblBranchManager.Name = "LblBranchManager"
        Me.LblBranchManager.Size = New System.Drawing.Size(89, 13)
        Me.LblBranchManager.TabIndex = 117
        Me.LblBranchManager.Text = "Branch Manager:"
        '
        'LblBranchName
        '
        Me.LblBranchName.AutoSize = True
        Me.LblBranchName.Location = New System.Drawing.Point(14, 57)
        Me.LblBranchName.Name = "LblBranchName"
        Me.LblBranchName.Size = New System.Drawing.Size(75, 13)
        Me.LblBranchName.TabIndex = 102
        Me.LblBranchName.Text = "Branch Name:"
        '
        'LblBranchID
        '
        Me.LblBranchID.AutoSize = True
        Me.LblBranchID.Location = New System.Drawing.Point(14, 26)
        Me.LblBranchID.Name = "LblBranchID"
        Me.LblBranchID.Size = New System.Drawing.Size(58, 13)
        Me.LblBranchID.TabIndex = 101
        Me.LblBranchID.Text = "Branch ID:"
        '
        'GrpBranchInformation
        '
        Me.GrpBranchInformation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpBranchInformation.Controls.Add(Me.Label1)
        Me.GrpBranchInformation.Controls.Add(Me.Label4)
        Me.GrpBranchInformation.Controls.Add(Me.TxtBranchName)
        Me.GrpBranchInformation.Controls.Add(Me.TxtBranchPhoneNo)
        Me.GrpBranchInformation.Controls.Add(Me.TxtBranchAddress)
        Me.GrpBranchInformation.Controls.Add(Me.TxtBranchManager)
        Me.GrpBranchInformation.Controls.Add(Me.TxtBranchID)
        Me.GrpBranchInformation.Controls.Add(Me.LblBranchPhoneNo)
        Me.GrpBranchInformation.Controls.Add(Me.LblBranchAddress)
        Me.GrpBranchInformation.Controls.Add(Me.LblBranchManager)
        Me.GrpBranchInformation.Controls.Add(Me.LblBranchName)
        Me.GrpBranchInformation.Controls.Add(Me.LblBranchID)
        Me.GrpBranchInformation.Location = New System.Drawing.Point(13, 151)
        Me.GrpBranchInformation.Name = "GrpBranchInformation"
        Me.GrpBranchInformation.Size = New System.Drawing.Size(813, 131)
        Me.GrpBranchInformation.TabIndex = 133
        Me.GrpBranchInformation.TabStop = False
        Me.GrpBranchInformation.Text = "Branch Information"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(459, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 24)
        Me.Label1.TabIndex = 2017
        Me.Label1.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(91, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 24)
        Me.Label4.TabIndex = 2016
        Me.Label4.Text = "*"
        '
        'TxtBranchName
        '
        Me.TxtBranchName.Location = New System.Drawing.Point(109, 57)
        Me.TxtBranchName.Name = "TxtBranchName"
        Me.TxtBranchName.Size = New System.Drawing.Size(174, 20)
        Me.TxtBranchName.TabIndex = 1011
        '
        'GrdBranchInformation
        '
        Me.GrdBranchInformation.AllowUserToAddRows = False
        Me.GrdBranchInformation.AllowUserToDeleteRows = False
        Me.GrdBranchInformation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdBranchInformation.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdBranchInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdBranchInformation.Location = New System.Drawing.Point(11, 292)
        Me.GrdBranchInformation.Name = "GrdBranchInformation"
        Me.GrdBranchInformation.ReadOnly = True
        Me.GrdBranchInformation.Size = New System.Drawing.Size(815, 223)
        Me.GrdBranchInformation.TabIndex = 1027
        '
        'BtnRefresh
        '
        Me.BtnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefresh.Image = Global.Business_Expert_Pro.My.Resources.Resources.Reboot_32px
        Me.BtnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRefresh.Location = New System.Drawing.Point(296, 105)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(89, 39)
        Me.BtnRefresh.TabIndex = 1026
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'BtnInsert
        '
        Me.BtnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInsert.Image = Global.Business_Expert_Pro.My.Resources.Resources.Save_32px_3
        Me.BtnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInsert.Location = New System.Drawing.Point(413, 105)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(89, 39)
        Me.BtnInsert.TabIndex = 1015
        Me.BtnInsert.Text = "Save"
        Me.BtnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnInsert.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Image = Global.Business_Expert_Pro.My.Resources.Resources.Edit_File_32px
        Me.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUpdate.Location = New System.Drawing.Point(106, 105)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(89, 39)
        Me.BtnUpdate.TabIndex = 1017
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Image = Global.Business_Expert_Pro.My.Resources.Resources.Delete_32px
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(201, 105)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(89, 39)
        Me.BtnDelete.TabIndex = 1018
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
        Me.BtnAddNew.Location = New System.Drawing.Point(11, 105)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(89, 39)
        Me.BtnAddNew.TabIndex = 1016
        Me.BtnAddNew.Text = "Add New"
        Me.BtnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'FrmBranchInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(838, 523)
        Me.Controls.Add(Me.GrdBranchInformation)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.BtnInsert)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.GrpBranchInformation)
        Me.Controls.Add(Me.PnlBranchInformation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmBranchInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Branch Information"
        Me.PnlBranchInformation.ResumeLayout(False)
        Me.PnlBranchInformation.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GrpBranchInformation.ResumeLayout(False)
        Me.GrpBranchInformation.PerformLayout()
        CType(Me.GrdBranchInformation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlBranchInformation As System.Windows.Forms.Panel
    Friend WithEvents LblBranchInformation As System.Windows.Forms.Label
    Friend WithEvents TxtBranchPhoneNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtBranchAddress As System.Windows.Forms.TextBox
    Friend WithEvents TxtBranchManager As System.Windows.Forms.TextBox
    Friend WithEvents TxtBranchID As System.Windows.Forms.TextBox
    Friend WithEvents LblBranchPhoneNo As System.Windows.Forms.Label
    Friend WithEvents LblBranchAddress As System.Windows.Forms.Label
    Friend WithEvents LblBranchManager As System.Windows.Forms.Label
    Friend WithEvents LblBranchName As System.Windows.Forms.Label
    Friend WithEvents LblBranchID As System.Windows.Forms.Label
    Friend WithEvents GrpBranchInformation As System.Windows.Forms.GroupBox
    Friend WithEvents TxtBranchName As System.Windows.Forms.TextBox
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button
    Friend WithEvents BtnInsert As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
    Friend WithEvents GrdBranchInformation As System.Windows.Forms.DataGridView
End Class
