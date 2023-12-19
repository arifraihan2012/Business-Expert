<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListofBank
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
        Me.LblListofBank = New System.Windows.Forms.Label
        Me.PnlListofBank = New System.Windows.Forms.Panel
        Me.GrdListofBank = New System.Windows.Forms.DataGridView
        Me.TxtSearchBank = New System.Windows.Forms.TextBox
        Me.LblSearchBank = New System.Windows.Forms.Label
        Me.PnlListofBank.SuspendLayout()
        CType(Me.GrdListofBank, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblListofBank
        '
        Me.LblListofBank.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblListofBank.AutoSize = True
        Me.LblListofBank.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblListofBank.ForeColor = System.Drawing.Color.White
        Me.LblListofBank.Location = New System.Drawing.Point(273, 29)
        Me.LblListofBank.Name = "LblListofBank"
        Me.LblListofBank.Size = New System.Drawing.Size(197, 37)
        Me.LblListofBank.TabIndex = 0
        Me.LblListofBank.Text = "List of Bank" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PnlListofBank
        '
        Me.PnlListofBank.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlListofBank.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PnlListofBank.Controls.Add(Me.LblListofBank)
        Me.PnlListofBank.Location = New System.Drawing.Point(1, 0)
        Me.PnlListofBank.Name = "PnlListofBank"
        Me.PnlListofBank.Size = New System.Drawing.Size(743, 94)
        Me.PnlListofBank.TabIndex = 16
        '
        'GrdListofBank
        '
        Me.GrdListofBank.AllowUserToAddRows = False
        Me.GrdListofBank.AllowUserToDeleteRows = False
        Me.GrdListofBank.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdListofBank.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GrdListofBank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdListofBank.Location = New System.Drawing.Point(6, 179)
        Me.GrdListofBank.Name = "GrdListofBank"
        Me.GrdListofBank.ReadOnly = True
        Me.GrdListofBank.Size = New System.Drawing.Size(732, 289)
        Me.GrdListofBank.TabIndex = 17
        '
        'TxtSearchBank
        '
        Me.TxtSearchBank.Location = New System.Drawing.Point(216, 124)
        Me.TxtSearchBank.Name = "TxtSearchBank"
        Me.TxtSearchBank.Size = New System.Drawing.Size(312, 20)
        Me.TxtSearchBank.TabIndex = 18
        '
        'LblSearchBank
        '
        Me.LblSearchBank.AutoSize = True
        Me.LblSearchBank.Location = New System.Drawing.Point(88, 127)
        Me.LblSearchBank.Name = "LblSearchBank"
        Me.LblSearchBank.Size = New System.Drawing.Size(72, 13)
        Me.LblSearchBank.TabIndex = 21
        Me.LblSearchBank.Text = "Search Bank:"
        '
        'FrmListofBank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(744, 480)
        Me.Controls.Add(Me.LblSearchBank)
        Me.Controls.Add(Me.TxtSearchBank)
        Me.Controls.Add(Me.GrdListofBank)
        Me.Controls.Add(Me.PnlListofBank)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "FrmListofBank"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List of Bank"
        Me.PnlListofBank.ResumeLayout(False)
        Me.PnlListofBank.PerformLayout()
        CType(Me.GrdListofBank, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblListofBank As System.Windows.Forms.Label
    Friend WithEvents PnlListofBank As System.Windows.Forms.Panel
    Friend WithEvents GrdListofBank As System.Windows.Forms.DataGridView
    Friend WithEvents TxtSearchBank As System.Windows.Forms.TextBox
    Friend WithEvents LblSearchBank As System.Windows.Forms.Label
End Class
