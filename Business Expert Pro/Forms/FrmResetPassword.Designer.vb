<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmResetPassword
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
        Me.PnlResetPassword = New System.Windows.Forms.Panel
        Me.LblResetPassword = New System.Windows.Forms.Label
        Me.LblUserName = New System.Windows.Forms.Label
        Me.TxtOldPassword = New System.Windows.Forms.TextBox
        Me.LblOldPassword = New System.Windows.Forms.Label
        Me.TxtNewPassword = New System.Windows.Forms.TextBox
        Me.LblNewPassword = New System.Windows.Forms.Label
        Me.cmbUserName = New System.Windows.Forms.ComboBox
        Me.BtnReset = New System.Windows.Forms.Button
        Me.GrpResetPassword = New System.Windows.Forms.GroupBox
        Me.PnlResetPassword.SuspendLayout()
        Me.GrpResetPassword.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlResetPassword
        '
        Me.PnlResetPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlResetPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlResetPassword.Controls.Add(Me.LblResetPassword)
        Me.PnlResetPassword.Location = New System.Drawing.Point(-3, 0)
        Me.PnlResetPassword.Name = "PnlResetPassword"
        Me.PnlResetPassword.Size = New System.Drawing.Size(602, 95)
        Me.PnlResetPassword.TabIndex = 1084
        '
        'LblResetPassword
        '
        Me.LblResetPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblResetPassword.AutoSize = True
        Me.LblResetPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblResetPassword.ForeColor = System.Drawing.Color.White
        Me.LblResetPassword.Location = New System.Drawing.Point(160, 29)
        Me.LblResetPassword.Name = "LblResetPassword"
        Me.LblResetPassword.Size = New System.Drawing.Size(262, 37)
        Me.LblResetPassword.TabIndex = 0
        Me.LblResetPassword.Text = "Reset Password"
        '
        'LblUserName
        '
        Me.LblUserName.AutoSize = True
        Me.LblUserName.Location = New System.Drawing.Point(60, 30)
        Me.LblUserName.Name = "LblUserName"
        Me.LblUserName.Size = New System.Drawing.Size(63, 13)
        Me.LblUserName.TabIndex = 1086
        Me.LblUserName.Text = "User Name:"
        '
        'TxtOldPassword
        '
        Me.TxtOldPassword.Location = New System.Drawing.Point(150, 66)
        Me.TxtOldPassword.Name = "TxtOldPassword"
        Me.TxtOldPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtOldPassword.Size = New System.Drawing.Size(155, 20)
        Me.TxtOldPassword.TabIndex = 1087
        '
        'LblOldPassword
        '
        Me.LblOldPassword.AutoSize = True
        Me.LblOldPassword.Location = New System.Drawing.Point(60, 69)
        Me.LblOldPassword.Name = "LblOldPassword"
        Me.LblOldPassword.Size = New System.Drawing.Size(75, 13)
        Me.LblOldPassword.TabIndex = 1088
        Me.LblOldPassword.Text = "Old Password:"
        '
        'TxtNewPassword
        '
        Me.TxtNewPassword.Enabled = False
        Me.TxtNewPassword.Location = New System.Drawing.Point(150, 103)
        Me.TxtNewPassword.Name = "TxtNewPassword"
        Me.TxtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtNewPassword.Size = New System.Drawing.Size(155, 20)
        Me.TxtNewPassword.TabIndex = 1089
        '
        'LblNewPassword
        '
        Me.LblNewPassword.AutoSize = True
        Me.LblNewPassword.Location = New System.Drawing.Point(60, 106)
        Me.LblNewPassword.Name = "LblNewPassword"
        Me.LblNewPassword.Size = New System.Drawing.Size(81, 13)
        Me.LblNewPassword.TabIndex = 1090
        Me.LblNewPassword.Text = "New Password:"
        '
        'cmbUserName
        '
        Me.cmbUserName.FormattingEnabled = True
        Me.cmbUserName.Location = New System.Drawing.Point(150, 30)
        Me.cmbUserName.Name = "cmbUserName"
        Me.cmbUserName.Size = New System.Drawing.Size(155, 21)
        Me.cmbUserName.TabIndex = 1091
        '
        'BtnReset
        '
        Me.BtnReset.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnReset.BackColor = System.Drawing.Color.DarkBlue
        Me.BtnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReset.Location = New System.Drawing.Point(179, 147)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnReset.Size = New System.Drawing.Size(91, 29)
        Me.BtnReset.TabIndex = 1107
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = False
        '
        'GrpResetPassword
        '
        Me.GrpResetPassword.Controls.Add(Me.BtnReset)
        Me.GrpResetPassword.Controls.Add(Me.cmbUserName)
        Me.GrpResetPassword.Controls.Add(Me.TxtNewPassword)
        Me.GrpResetPassword.Controls.Add(Me.LblNewPassword)
        Me.GrpResetPassword.Controls.Add(Me.TxtOldPassword)
        Me.GrpResetPassword.Controls.Add(Me.LblOldPassword)
        Me.GrpResetPassword.Controls.Add(Me.LblUserName)
        Me.GrpResetPassword.Location = New System.Drawing.Point(116, 122)
        Me.GrpResetPassword.Name = "GrpResetPassword"
        Me.GrpResetPassword.Size = New System.Drawing.Size(364, 193)
        Me.GrpResetPassword.TabIndex = 1108
        Me.GrpResetPassword.TabStop = False
        '
        'FrmResetPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(596, 351)
        Me.Controls.Add(Me.GrpResetPassword)
        Me.Controls.Add(Me.PnlResetPassword)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmResetPassword"
        Me.Text = "Reset Password"
        Me.PnlResetPassword.ResumeLayout(False)
        Me.PnlResetPassword.PerformLayout()
        Me.GrpResetPassword.ResumeLayout(False)
        Me.GrpResetPassword.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlResetPassword As System.Windows.Forms.Panel
    Friend WithEvents LblResetPassword As System.Windows.Forms.Label
    Friend WithEvents LblUserName As System.Windows.Forms.Label
    Friend WithEvents TxtOldPassword As System.Windows.Forms.TextBox
    Friend WithEvents LblOldPassword As System.Windows.Forms.Label
    Friend WithEvents TxtNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents LblNewPassword As System.Windows.Forms.Label
    Friend WithEvents cmbUserName As System.Windows.Forms.ComboBox
    Friend WithEvents BtnReset As System.Windows.Forms.Button
    Friend WithEvents GrpResetPassword As System.Windows.Forms.GroupBox
End Class
