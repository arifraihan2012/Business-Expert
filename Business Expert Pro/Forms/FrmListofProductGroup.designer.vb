<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListofProductGroups
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
        Me.PnlListofProductGroup = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.LblListofProductGroups = New System.Windows.Forms.Label
        Me.TxtSearchGroup = New System.Windows.Forms.TextBox
        Me.LblSearchGroup = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GrdListofProductGroups = New System.Windows.Forms.DataGridView
        Me.PnlListofProductGroup.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GrdListofProductGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlListofProductGroup
        '
        Me.PnlListofProductGroup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlListofProductGroup.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlListofProductGroup.Controls.Add(Me.Panel1)
        Me.PnlListofProductGroup.Controls.Add(Me.LblListofProductGroups)
        Me.PnlListofProductGroup.Location = New System.Drawing.Point(2, 0)
        Me.PnlListofProductGroup.Name = "PnlListofProductGroup"
        Me.PnlListofProductGroup.Size = New System.Drawing.Size(743, 100)
        Me.PnlListofProductGroup.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Btnclose)
        Me.Panel1.Controls.Add(Me.Btnminimized)
        Me.Panel1.Controls.Add(Me.Btnmaximized)
        Me.Panel1.Location = New System.Drawing.Point(-8, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(749, 31)
        Me.Panel1.TabIndex = 4
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(725, 2)
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
        Me.Btnminimized.Location = New System.Drawing.Point(665, 2)
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
        Me.Btnmaximized.Location = New System.Drawing.Point(695, 2)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1160
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'LblListofProductGroups
        '
        Me.LblListofProductGroups.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblListofProductGroups.AutoSize = True
        Me.LblListofProductGroups.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblListofProductGroups.ForeColor = System.Drawing.Color.White
        Me.LblListofProductGroups.Location = New System.Drawing.Point(191, 46)
        Me.LblListofProductGroups.Name = "LblListofProductGroups"
        Me.LblListofProductGroups.Size = New System.Drawing.Size(360, 37)
        Me.LblListofProductGroups.TabIndex = 2
        Me.LblListofProductGroups.Text = "List of Product Groups"
        '
        'TxtSearchGroup
        '
        Me.TxtSearchGroup.Location = New System.Drawing.Point(216, 128)
        Me.TxtSearchGroup.Name = "TxtSearchGroup"
        Me.TxtSearchGroup.Size = New System.Drawing.Size(312, 20)
        Me.TxtSearchGroup.TabIndex = 106
        '
        'LblSearchGroup
        '
        Me.LblSearchGroup.AutoSize = True
        Me.LblSearchGroup.Location = New System.Drawing.Point(104, 130)
        Me.LblSearchGroup.Name = "LblSearchGroup"
        Me.LblSearchGroup.Size = New System.Drawing.Size(76, 13)
        Me.LblSearchGroup.TabIndex = 105
        Me.LblSearchGroup.Text = "Search Group:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(566, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "Label1"
        '
        'GrdListofProductGroups
        '
        Me.GrdListofProductGroups.AllowUserToAddRows = False
        Me.GrdListofProductGroups.AllowUserToDeleteRows = False
        Me.GrdListofProductGroups.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdListofProductGroups.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdListofProductGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdListofProductGroups.Location = New System.Drawing.Point(7, 184)
        Me.GrdListofProductGroups.Name = "GrdListofProductGroups"
        Me.GrdListofProductGroups.ReadOnly = True
        Me.GrdListofProductGroups.Size = New System.Drawing.Size(732, 289)
        Me.GrdListofProductGroups.TabIndex = 109
        '
        'FrmListofProductGroups
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(744, 480)
        Me.Controls.Add(Me.GrdListofProductGroups)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtSearchGroup)
        Me.Controls.Add(Me.LblSearchGroup)
        Me.Controls.Add(Me.PnlListofProductGroup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmListofProductGroups"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List of Product Groups"
        Me.PnlListofProductGroup.ResumeLayout(False)
        Me.PnlListofProductGroup.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.GrdListofProductGroups, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PnlListofProductGroup As System.Windows.Forms.Panel
    Friend WithEvents LblListofProductGroups As System.Windows.Forms.Label
    Friend WithEvents TxtSearchGroup As System.Windows.Forms.TextBox
    Friend WithEvents LblSearchGroup As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
    Friend WithEvents GrdListofProductGroups As System.Windows.Forms.DataGridView
End Class
