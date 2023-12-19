<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListofServices
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
        Me.GrdListofServices = New System.Windows.Forms.DataGridView
        Me.PnlListofServices = New System.Windows.Forms.Panel
        Me.LblListofServices = New System.Windows.Forms.Label
        Me.TxtSearchServices = New System.Windows.Forms.TextBox
        Me.LblSearchServices = New System.Windows.Forms.Label
        CType(Me.GrdListofServices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlListofServices.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrdListofServices
        '
        Me.GrdListofServices.AllowUserToAddRows = False
        Me.GrdListofServices.AllowUserToDeleteRows = False
        Me.GrdListofServices.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdListofServices.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GrdListofServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdListofServices.Location = New System.Drawing.Point(6, 185)
        Me.GrdListofServices.Name = "GrdListofServices"
        Me.GrdListofServices.ReadOnly = True
        Me.GrdListofServices.Size = New System.Drawing.Size(732, 289)
        Me.GrdListofServices.TabIndex = 5
        '
        'PnlListofServices
        '
        Me.PnlListofServices.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlListofServices.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PnlListofServices.Controls.Add(Me.LblListofServices)
        Me.PnlListofServices.Location = New System.Drawing.Point(-3, -2)
        Me.PnlListofServices.Name = "PnlListofServices"
        Me.PnlListofServices.Size = New System.Drawing.Size(743, 94)
        Me.PnlListofServices.TabIndex = 4
        '
        'LblListofServices
        '
        Me.LblListofServices.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblListofServices.AutoSize = True
        Me.LblListofServices.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblListofServices.ForeColor = System.Drawing.Color.White
        Me.LblListofServices.Location = New System.Drawing.Point(247, 29)
        Me.LblListofServices.Name = "LblListofServices"
        Me.LblListofServices.Size = New System.Drawing.Size(248, 37)
        Me.LblListofServices.TabIndex = 0
        Me.LblListofServices.Text = "List of Services"
        '
        'TxtSearchServices
        '
        Me.TxtSearchServices.Location = New System.Drawing.Point(216, 129)
        Me.TxtSearchServices.Name = "TxtSearchServices"
        Me.TxtSearchServices.Size = New System.Drawing.Size(312, 20)
        Me.TxtSearchServices.TabIndex = 9
        '
        'LblSearchServices
        '
        Me.LblSearchServices.AutoSize = True
        Me.LblSearchServices.Location = New System.Drawing.Point(94, 132)
        Me.LblSearchServices.Name = "LblSearchServices"
        Me.LblSearchServices.Size = New System.Drawing.Size(88, 13)
        Me.LblSearchServices.TabIndex = 8
        Me.LblSearchServices.Text = "Search Services:"
        '
        'FrmListofServices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(744, 480)
        Me.Controls.Add(Me.TxtSearchServices)
        Me.Controls.Add(Me.LblSearchServices)
        Me.Controls.Add(Me.GrdListofServices)
        Me.Controls.Add(Me.PnlListofServices)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MinimizeBox = False
        Me.Name = "FrmListofServices"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List of Services"
        CType(Me.GrdListofServices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlListofServices.ResumeLayout(False)
        Me.PnlListofServices.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrdListofServices As System.Windows.Forms.DataGridView
    Friend WithEvents PnlListofServices As System.Windows.Forms.Panel
    Friend WithEvents LblListofServices As System.Windows.Forms.Label
    Friend WithEvents TxtSearchServices As System.Windows.Forms.TextBox
    Friend WithEvents LblSearchServices As System.Windows.Forms.Label
End Class
