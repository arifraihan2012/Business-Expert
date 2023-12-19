<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPOSPasswordConfirmation
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
        Me.GrpResetPassword = New System.Windows.Forms.GroupBox
        Me.BtnLogin = New System.Windows.Forms.Button
        Me.TxtPassword = New System.Windows.Forms.TextBox
        Me.LblOutputText = New System.Windows.Forms.Label
        Me.LblPassword = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GrpResetPassword.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpResetPassword
        '
        Me.GrpResetPassword.Controls.Add(Me.BtnLogin)
        Me.GrpResetPassword.Controls.Add(Me.TxtPassword)
        Me.GrpResetPassword.Controls.Add(Me.LblOutputText)
        Me.GrpResetPassword.Controls.Add(Me.LblPassword)
        Me.GrpResetPassword.Location = New System.Drawing.Point(37, 43)
        Me.GrpResetPassword.Name = "GrpResetPassword"
        Me.GrpResetPassword.Size = New System.Drawing.Size(364, 84)
        Me.GrpResetPassword.TabIndex = 1109
        Me.GrpResetPassword.TabStop = False
        '
        'BtnLogin
        '
        Me.BtnLogin.Location = New System.Drawing.Point(271, 30)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(75, 23)
        Me.BtnLogin.TabIndex = 1091
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(100, 32)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(155, 20)
        Me.TxtPassword.TabIndex = 1089
        '
        'LblOutputText
        '
        Me.LblOutputText.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblOutputText.AutoSize = True
        Me.LblOutputText.ForeColor = System.Drawing.Color.Red
        Me.LblOutputText.Location = New System.Drawing.Point(133, 68)
        Me.LblOutputText.Name = "LblOutputText"
        Me.LblOutputText.Size = New System.Drawing.Size(88, 13)
        Me.LblOutputText.TabIndex = 1086
        Me.LblOutputText.Text = "Wrong Password"
        Me.LblOutputText.Visible = False
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Location = New System.Drawing.Point(38, 35)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(56, 13)
        Me.LblPassword.TabIndex = 1090
        Me.LblPassword.Text = "Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(221, 13)
        Me.Label2.TabIndex = 1092
        Me.Label2.Text = "Please type admin password and press Enter:"
        '
        'FrmPOSPasswordConfirmation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(437, 193)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GrpResetPassword)
        Me.Name = "FrmPOSPasswordConfirmation"
        Me.Text = "Password Confirmation (POS)"
        Me.GrpResetPassword.ResumeLayout(False)
        Me.GrpResetPassword.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpResetPassword As System.Windows.Forms.GroupBox
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox
    Friend WithEvents LblPassword As System.Windows.Forms.Label
    Friend WithEvents LblOutputText As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnLogin As System.Windows.Forms.Button
End Class
