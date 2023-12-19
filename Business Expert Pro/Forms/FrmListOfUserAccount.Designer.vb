<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListOfUserAccounts
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
        Me.LblSearchUserAccount = New System.Windows.Forms.Label
        Me.TxtSearchUserAccount = New System.Windows.Forms.TextBox
        Me.PnlListofUserAccount = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.LblListOfUserAccounts = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.LblTotalAccount = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GrdListofUserAccount = New System.Windows.Forms.DataGridView
        Me.PnlListofUserAccount.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GrdListofUserAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblSearchUserAccount
        '
        Me.LblSearchUserAccount.AutoSize = True
        Me.LblSearchUserAccount.Location = New System.Drawing.Point(57, 126)
        Me.LblSearchUserAccount.Name = "LblSearchUserAccount"
        Me.LblSearchUserAccount.Size = New System.Drawing.Size(117, 13)
        Me.LblSearchUserAccount.TabIndex = 25
        Me.LblSearchUserAccount.Text = "Search User Accounts:"
        '
        'TxtSearchUserAccount
        '
        Me.TxtSearchUserAccount.Location = New System.Drawing.Point(216, 126)
        Me.TxtSearchUserAccount.Name = "TxtSearchUserAccount"
        Me.TxtSearchUserAccount.Size = New System.Drawing.Size(312, 20)
        Me.TxtSearchUserAccount.TabIndex = 24
        '
        'PnlListofUserAccount
        '
        Me.PnlListofUserAccount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlListofUserAccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlListofUserAccount.Controls.Add(Me.Panel1)
        Me.PnlListofUserAccount.Controls.Add(Me.LblListOfUserAccounts)
        Me.PnlListofUserAccount.Location = New System.Drawing.Point(-2, 0)
        Me.PnlListofUserAccount.Name = "PnlListofUserAccount"
        Me.PnlListofUserAccount.Size = New System.Drawing.Size(747, 97)
        Me.PnlListofUserAccount.TabIndex = 22
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Btnclose)
        Me.Panel1.Controls.Add(Me.Btnminimized)
        Me.Panel1.Controls.Add(Me.Btnmaximized)
        Me.Panel1.Location = New System.Drawing.Point(3, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(740, 31)
        Me.Panel1.TabIndex = 5
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(716, 2)
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
        Me.Btnminimized.Location = New System.Drawing.Point(656, 2)
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
        Me.Btnmaximized.Location = New System.Drawing.Point(686, 2)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1160
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'LblListOfUserAccounts
        '
        Me.LblListOfUserAccounts.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblListOfUserAccounts.AutoSize = True
        Me.LblListOfUserAccounts.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblListOfUserAccounts.ForeColor = System.Drawing.Color.White
        Me.LblListOfUserAccounts.Location = New System.Drawing.Point(202, 42)
        Me.LblListOfUserAccounts.Name = "LblListOfUserAccounts"
        Me.LblListOfUserAccounts.Size = New System.Drawing.Size(342, 37)
        Me.LblListOfUserAccounts.TabIndex = 0
        Me.LblListOfUserAccounts.Text = "List of User Accounts"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(663, 154)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(22, 16)
        Me.Label15.TabIndex = 58
        Me.Label15.Text = "00"
        '
        'LblTotalAccount
        '
        Me.LblTotalAccount.AutoSize = True
        Me.LblTotalAccount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalAccount.Location = New System.Drawing.Point(551, 154)
        Me.LblTotalAccount.Name = "LblTotalAccount"
        Me.LblTotalAccount.Size = New System.Drawing.Size(98, 16)
        Me.LblTotalAccount.TabIndex = 57
        Me.LblTotalAccount.Text = "Total Account:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(551, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Label1"
        '
        'GrdListofUserAccount
        '
        Me.GrdListofUserAccount.AllowUserToAddRows = False
        Me.GrdListofUserAccount.AllowUserToDeleteRows = False
        Me.GrdListofUserAccount.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdListofUserAccount.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GrdListofUserAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdListofUserAccount.Location = New System.Drawing.Point(6, 182)
        Me.GrdListofUserAccount.Name = "GrdListofUserAccount"
        Me.GrdListofUserAccount.ReadOnly = True
        Me.GrdListofUserAccount.Size = New System.Drawing.Size(732, 289)
        Me.GrdListofUserAccount.TabIndex = 60
        '
        'FrmListOfUserAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(744, 480)
        Me.Controls.Add(Me.GrdListofUserAccount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.LblTotalAccount)
        Me.Controls.Add(Me.LblSearchUserAccount)
        Me.Controls.Add(Me.TxtSearchUserAccount)
        Me.Controls.Add(Me.PnlListofUserAccount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmListOfUserAccounts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List Of User Accounts"
        Me.PnlListofUserAccount.ResumeLayout(False)
        Me.PnlListofUserAccount.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.GrdListofUserAccount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblSearchUserAccount As System.Windows.Forms.Label
    Friend WithEvents TxtSearchUserAccount As System.Windows.Forms.TextBox
    Friend WithEvents PnlListofUserAccount As System.Windows.Forms.Panel
    Friend WithEvents LblListOfUserAccounts As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents LblTotalAccount As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
    Friend WithEvents GrdListofUserAccount As System.Windows.Forms.DataGridView
End Class
