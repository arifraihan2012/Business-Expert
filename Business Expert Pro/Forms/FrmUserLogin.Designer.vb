<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUserLogin
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
        Me.TxtPassword = New System.Windows.Forms.TextBox
        Me.LblUserName = New System.Windows.Forms.Label
        Me.LblPasswrd = New System.Windows.Forms.Label
        Me.GrpLogin = New System.Windows.Forms.GroupBox
        Me.BtnLogin = New System.Windows.Forms.Button
        Me.lblResetPassword = New System.Windows.Forms.LinkLabel
        Me.CmbUserAccountID = New System.Windows.Forms.ComboBox
        Me.lblCompanyName = New System.Windows.Forms.Label
        Me.PnlLogin = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.LblUserLogin = New System.Windows.Forms.Label
        Me.LblTitle = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PtbCompanyImage = New System.Windows.Forms.PictureBox
        Me.GrpLogin.SuspendLayout()
        Me.PnlLogin.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PtbCompanyImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(132, 56)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(151, 20)
        Me.TxtPassword.TabIndex = 102
        '
        'LblUserName
        '
        Me.LblUserName.AutoSize = True
        Me.LblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUserName.ForeColor = System.Drawing.Color.Black
        Me.LblUserName.Location = New System.Drawing.Point(30, 25)
        Me.LblUserName.Name = "LblUserName"
        Me.LblUserName.Size = New System.Drawing.Size(80, 16)
        Me.LblUserName.TabIndex = 20
        Me.LblUserName.Text = "User Name:"
        '
        'LblPasswrd
        '
        Me.LblPasswrd.AutoSize = True
        Me.LblPasswrd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPasswrd.ForeColor = System.Drawing.Color.Black
        Me.LblPasswrd.Location = New System.Drawing.Point(30, 59)
        Me.LblPasswrd.Name = "LblPasswrd"
        Me.LblPasswrd.Size = New System.Drawing.Size(71, 16)
        Me.LblPasswrd.TabIndex = 21
        Me.LblPasswrd.Text = "Password:"
        '
        'GrpLogin
        '
        Me.GrpLogin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GrpLogin.Controls.Add(Me.BtnLogin)
        Me.GrpLogin.Controls.Add(Me.lblResetPassword)
        Me.GrpLogin.Controls.Add(Me.CmbUserAccountID)
        Me.GrpLogin.Controls.Add(Me.LblPasswrd)
        Me.GrpLogin.Controls.Add(Me.LblUserName)
        Me.GrpLogin.Controls.Add(Me.TxtPassword)
        Me.GrpLogin.Location = New System.Drawing.Point(225, 226)
        Me.GrpLogin.Name = "GrpLogin"
        Me.GrpLogin.Size = New System.Drawing.Size(411, 139)
        Me.GrpLogin.TabIndex = 22
        Me.GrpLogin.TabStop = False
        '
        'BtnLogin
        '
        Me.BtnLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnLogin.BackColor = System.Drawing.Color.DarkBlue
        Me.BtnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLogin.Location = New System.Drawing.Point(154, 103)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnLogin.Size = New System.Drawing.Size(91, 29)
        Me.BtnLogin.TabIndex = 2070
        Me.BtnLogin.Text = "Log In"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'lblResetPassword
        '
        Me.lblResetPassword.ActiveLinkColor = System.Drawing.Color.White
        Me.lblResetPassword.AutoSize = True
        Me.lblResetPassword.DisabledLinkColor = System.Drawing.Color.White
        Me.lblResetPassword.ForeColor = System.Drawing.Color.Black
        Me.lblResetPassword.LinkColor = System.Drawing.Color.Blue
        Me.lblResetPassword.Location = New System.Drawing.Point(159, 87)
        Me.lblResetPassword.Name = "lblResetPassword"
        Me.lblResetPassword.Size = New System.Drawing.Size(93, 13)
        Me.lblResetPassword.TabIndex = 1107
        Me.lblResetPassword.TabStop = True
        Me.lblResetPassword.Text = "Reset Password..."
        '
        'CmbUserAccountID
        '
        Me.CmbUserAccountID.BackColor = System.Drawing.SystemColors.Control
        Me.CmbUserAccountID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbUserAccountID.FormattingEnabled = True
        Me.CmbUserAccountID.Location = New System.Drawing.Point(132, 24)
        Me.CmbUserAccountID.Name = "CmbUserAccountID"
        Me.CmbUserAccountID.Size = New System.Drawing.Size(151, 26)
        Me.CmbUserAccountID.TabIndex = 24
        '
        'lblCompanyName
        '
        Me.lblCompanyName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCompanyName.BackColor = System.Drawing.Color.Transparent
        Me.lblCompanyName.Font = New System.Drawing.Font("Georgia", 20.25!)
        Me.lblCompanyName.ForeColor = System.Drawing.Color.Black
        Me.lblCompanyName.Location = New System.Drawing.Point(12, 153)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(836, 31)
        Me.lblCompanyName.TabIndex = 24
        Me.lblCompanyName.Text = "Company Name"
        Me.lblCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCompanyName.UseMnemonic = False
        '
        'PnlLogin
        '
        Me.PnlLogin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlLogin.Controls.Add(Me.Panel2)
        Me.PnlLogin.Controls.Add(Me.LblUserLogin)
        Me.PnlLogin.Location = New System.Drawing.Point(-1, 0)
        Me.PnlLogin.Name = "PnlLogin"
        Me.PnlLogin.Size = New System.Drawing.Size(861, 68)
        Me.PnlLogin.TabIndex = 17
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Btnclose)
        Me.Panel2.Controls.Add(Me.Btnminimized)
        Me.Panel2.Controls.Add(Me.Btnmaximized)
        Me.Panel2.Location = New System.Drawing.Point(-3, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(864, 27)
        Me.Panel2.TabIndex = 2064
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(828, 0)
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
        Me.Btnminimized.Location = New System.Drawing.Point(768, 0)
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
        Me.Btnmaximized.Enabled = False
        Me.Btnmaximized.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnmaximized.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Maximize_Window_32px_2
        Me.Btnmaximized.Location = New System.Drawing.Point(798, 0)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1160
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'LblUserLogin
        '
        Me.LblUserLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblUserLogin.AutoSize = True
        Me.LblUserLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUserLogin.ForeColor = System.Drawing.Color.White
        Me.LblUserLogin.Location = New System.Drawing.Point(360, 28)
        Me.LblUserLogin.Name = "LblUserLogin"
        Me.LblUserLogin.Size = New System.Drawing.Size(140, 29)
        Me.LblUserLogin.TabIndex = 0
        Me.LblUserLogin.Text = "User Login"
        '
        'LblTitle
        '
        Me.LblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblTitle.BackColor = System.Drawing.Color.Transparent
        Me.LblTitle.Font = New System.Drawing.Font("Gill Sans MT", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.Color.Black
        Me.LblTitle.Location = New System.Drawing.Point(45, 191)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(770, 16)
        Me.LblTitle.TabIndex = 1178
        Me.LblTitle.Text = "Title"
        Me.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblTitle.UseMnemonic = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 446)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(860, 12)
        Me.Panel3.TabIndex = 2066
        '
        'Panel5
        '
        Me.Panel5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel5.BackColor = System.Drawing.Color.Indigo
        Me.Panel5.Location = New System.Drawing.Point(225, 371)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(411, 10)
        Me.Panel5.TabIndex = 2068
        '
        'Panel6
        '
        Me.Panel6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel6.BackColor = System.Drawing.Color.Indigo
        Me.Panel6.Location = New System.Drawing.Point(225, 217)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(411, 10)
        Me.Panel6.TabIndex = 2069
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Indigo
        Me.Label3.Location = New System.Drawing.Point(790, 414)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 20)
        Me.Label3.TabIndex = 2070
        Me.Label3.Text = "v18.0"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Indigo
        Me.Label12.Location = New System.Drawing.Point(730, 379)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 39)
        Me.Label12.TabIndex = 2071
        Me.Label12.Text = "pert"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Business_Expert_Pro.My.Resources.Resources.Xpert_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(672, 366)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2072
        Me.PictureBox1.TabStop = False
        '
        'PtbCompanyImage
        '
        Me.PtbCompanyImage.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PtbCompanyImage.BackgroundImage = Global.Business_Expert_Pro.My.Resources.Resources.logo
        Me.PtbCompanyImage.Image = Global.Business_Expert_Pro.My.Resources.Resources.logo
        Me.PtbCompanyImage.Location = New System.Drawing.Point(391, 74)
        Me.PtbCompanyImage.Name = "PtbCompanyImage"
        Me.PtbCompanyImage.Size = New System.Drawing.Size(79, 76)
        Me.PtbCompanyImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PtbCompanyImage.TabIndex = 1168
        Me.PtbCompanyImage.TabStop = False
        '
        'FrmUserLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(860, 458)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.PtbCompanyImage)
        Me.Controls.Add(Me.lblCompanyName)
        Me.Controls.Add(Me.GrpLogin)
        Me.Controls.Add(Me.PnlLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmUserLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Login"
        Me.TopMost = True
        Me.GrpLogin.ResumeLayout(False)
        Me.GrpLogin.PerformLayout()
        Me.PnlLogin.ResumeLayout(False)
        Me.PnlLogin.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PtbCompanyImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox
    Friend WithEvents LblUserName As System.Windows.Forms.Label
    Friend WithEvents LblPasswrd As System.Windows.Forms.Label
    Friend WithEvents GrpLogin As System.Windows.Forms.GroupBox
    Friend WithEvents CmbUserAccountID As System.Windows.Forms.ComboBox
    Friend WithEvents lblCompanyName As System.Windows.Forms.Label
    Friend WithEvents PnlLogin As System.Windows.Forms.Panel
    Friend WithEvents LblUserLogin As System.Windows.Forms.Label
    Friend WithEvents PtbCompanyImage As System.Windows.Forms.PictureBox
    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents lblResetPassword As System.Windows.Forms.LinkLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents BtnLogin As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
