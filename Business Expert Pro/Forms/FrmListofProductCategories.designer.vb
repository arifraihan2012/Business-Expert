<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListofProductCategories
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
        Me.PnlListofProductCategories = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.LblListofProductCategories = New System.Windows.Forms.Label
        Me.TxtSearchCategory = New System.Windows.Forms.TextBox
        Me.LblSearchCategory = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GrdListofProductCategories = New System.Windows.Forms.DataGridView
        Me.PnlListofProductCategories.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GrdListofProductCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlListofProductCategories
        '
        Me.PnlListofProductCategories.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlListofProductCategories.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlListofProductCategories.Controls.Add(Me.Panel1)
        Me.PnlListofProductCategories.Controls.Add(Me.LblListofProductCategories)
        Me.PnlListofProductCategories.Location = New System.Drawing.Point(1, -1)
        Me.PnlListofProductCategories.Name = "PnlListofProductCategories"
        Me.PnlListofProductCategories.Size = New System.Drawing.Size(743, 91)
        Me.PnlListofProductCategories.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Btnclose)
        Me.Panel1.Controls.Add(Me.Btnminimized)
        Me.Panel1.Controls.Add(Me.Btnmaximized)
        Me.Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(743, 31)
        Me.Panel1.TabIndex = 3
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(719, 2)
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
        Me.Btnminimized.Location = New System.Drawing.Point(659, 2)
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
        Me.Btnmaximized.Location = New System.Drawing.Point(689, 2)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1160
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'LblListofProductCategories
        '
        Me.LblListofProductCategories.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblListofProductCategories.AutoSize = True
        Me.LblListofProductCategories.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblListofProductCategories.ForeColor = System.Drawing.Color.White
        Me.LblListofProductCategories.Location = New System.Drawing.Point(179, 37)
        Me.LblListofProductCategories.Name = "LblListofProductCategories"
        Me.LblListofProductCategories.Size = New System.Drawing.Size(412, 37)
        Me.LblListofProductCategories.TabIndex = 0
        Me.LblListofProductCategories.Text = "List of Product Categories"
        '
        'TxtSearchCategory
        '
        Me.TxtSearchCategory.Location = New System.Drawing.Point(216, 126)
        Me.TxtSearchCategory.Name = "TxtSearchCategory"
        Me.TxtSearchCategory.Size = New System.Drawing.Size(312, 20)
        Me.TxtSearchCategory.TabIndex = 5
        '
        'LblSearchCategory
        '
        Me.LblSearchCategory.AutoSize = True
        Me.LblSearchCategory.Location = New System.Drawing.Point(91, 129)
        Me.LblSearchCategory.Name = "LblSearchCategory"
        Me.LblSearchCategory.Size = New System.Drawing.Size(89, 13)
        Me.LblSearchCategory.TabIndex = 4
        Me.LblSearchCategory.Text = "Search Category:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(592, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "Label1"
        '
        'GrdListofProductCategories
        '
        Me.GrdListofProductCategories.AllowUserToAddRows = False
        Me.GrdListofProductCategories.AllowUserToDeleteRows = False
        Me.GrdListofProductCategories.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdListofProductCategories.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdListofProductCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdListofProductCategories.Location = New System.Drawing.Point(7, 187)
        Me.GrdListofProductCategories.Name = "GrdListofProductCategories"
        Me.GrdListofProductCategories.ReadOnly = True
        Me.GrdListofProductCategories.Size = New System.Drawing.Size(732, 289)
        Me.GrdListofProductCategories.TabIndex = 110
        '
        'FrmListofProductCategories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(744, 480)
        Me.Controls.Add(Me.GrdListofProductCategories)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtSearchCategory)
        Me.Controls.Add(Me.LblSearchCategory)
        Me.Controls.Add(Me.PnlListofProductCategories)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmListofProductCategories"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List of Product Categories"
        Me.PnlListofProductCategories.ResumeLayout(False)
        Me.PnlListofProductCategories.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.GrdListofProductCategories, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PnlListofProductCategories As System.Windows.Forms.Panel
    Friend WithEvents LblListofProductCategories As System.Windows.Forms.Label
    Friend WithEvents TxtSearchCategory As System.Windows.Forms.TextBox
    Friend WithEvents LblSearchCategory As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
    Friend WithEvents GrdListofProductCategories As System.Windows.Forms.DataGridView
End Class
