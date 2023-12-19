<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListofProductSubcategories
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
        Me.PnlListofProductSubcategories = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.LblListofProductSubcategories = New System.Windows.Forms.Label
        Me.TxtSearchProductsSubcategories = New System.Windows.Forms.TextBox
        Me.LblSearchProductSubcategories = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GrdListofProductSubcategories = New System.Windows.Forms.DataGridView
        Me.PnlListofProductSubcategories.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GrdListofProductSubcategories, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlListofProductSubcategories
        '
        Me.PnlListofProductSubcategories.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlListofProductSubcategories.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlListofProductSubcategories.Controls.Add(Me.Panel1)
        Me.PnlListofProductSubcategories.Controls.Add(Me.LblListofProductSubcategories)
        Me.PnlListofProductSubcategories.Location = New System.Drawing.Point(2, 0)
        Me.PnlListofProductSubcategories.Name = "PnlListofProductSubcategories"
        Me.PnlListofProductSubcategories.Size = New System.Drawing.Size(740, 100)
        Me.PnlListofProductSubcategories.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Btnclose)
        Me.Panel1.Controls.Add(Me.Btnminimized)
        Me.Panel1.Controls.Add(Me.Btnmaximized)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
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
        Me.Btnclose.Location = New System.Drawing.Point(716, 4)
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
        Me.Btnminimized.Location = New System.Drawing.Point(656, 4)
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
        Me.Btnmaximized.Location = New System.Drawing.Point(686, 4)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1160
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'LblListofProductSubcategories
        '
        Me.LblListofProductSubcategories.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblListofProductSubcategories.AutoSize = True
        Me.LblListofProductSubcategories.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblListofProductSubcategories.ForeColor = System.Drawing.Color.White
        Me.LblListofProductSubcategories.Location = New System.Drawing.Point(138, 43)
        Me.LblListofProductSubcategories.Name = "LblListofProductSubcategories"
        Me.LblListofProductSubcategories.Size = New System.Drawing.Size(465, 37)
        Me.LblListofProductSubcategories.TabIndex = 2
        Me.LblListofProductSubcategories.Text = "List of Product Subcategories"
        '
        'TxtSearchProductsSubcategories
        '
        Me.TxtSearchProductsSubcategories.Location = New System.Drawing.Point(236, 134)
        Me.TxtSearchProductsSubcategories.Name = "TxtSearchProductsSubcategories"
        Me.TxtSearchProductsSubcategories.Size = New System.Drawing.Size(312, 20)
        Me.TxtSearchProductsSubcategories.TabIndex = 104
        '
        'LblSearchProductSubcategories
        '
        Me.LblSearchProductSubcategories.AutoSize = True
        Me.LblSearchProductSubcategories.Location = New System.Drawing.Point(58, 136)
        Me.LblSearchProductSubcategories.Name = "LblSearchProductSubcategories"
        Me.LblSearchProductSubcategories.Size = New System.Drawing.Size(155, 13)
        Me.LblSearchProductSubcategories.TabIndex = 103
        Me.LblSearchProductSubcategories.Text = "Search Product Subcategories:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(584, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 110
        Me.Label1.Text = "Label1"
        '
        'GrdListofProductSubcategories
        '
        Me.GrdListofProductSubcategories.AllowUserToAddRows = False
        Me.GrdListofProductSubcategories.AllowUserToDeleteRows = False
        Me.GrdListofProductSubcategories.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdListofProductSubcategories.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdListofProductSubcategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdListofProductSubcategories.Location = New System.Drawing.Point(7, 186)
        Me.GrdListofProductSubcategories.Name = "GrdListofProductSubcategories"
        Me.GrdListofProductSubcategories.ReadOnly = True
        Me.GrdListofProductSubcategories.Size = New System.Drawing.Size(732, 289)
        Me.GrdListofProductSubcategories.TabIndex = 111
        '
        'FrmListofProductSubcategories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(744, 480)
        Me.Controls.Add(Me.GrdListofProductSubcategories)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtSearchProductsSubcategories)
        Me.Controls.Add(Me.LblSearchProductSubcategories)
        Me.Controls.Add(Me.PnlListofProductSubcategories)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmListofProductSubcategories"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List of Product Subcategories"
        Me.PnlListofProductSubcategories.ResumeLayout(False)
        Me.PnlListofProductSubcategories.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.GrdListofProductSubcategories, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PnlListofProductSubcategories As System.Windows.Forms.Panel
    Friend WithEvents LblListofProductSubcategories As System.Windows.Forms.Label
    Friend WithEvents TxtSearchProductsSubcategories As System.Windows.Forms.TextBox
    Friend WithEvents LblSearchProductSubcategories As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
    Friend WithEvents GrdListofProductSubcategories As System.Windows.Forms.DataGridView
End Class
