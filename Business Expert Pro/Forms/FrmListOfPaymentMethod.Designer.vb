<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListOfPaymentMethod
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
        Me.GrdListofPaymentMethod = New System.Windows.Forms.DataGridView
        Me.TxtSearchPaymentMethod = New System.Windows.Forms.TextBox
        Me.LblListofPaymentMethod = New System.Windows.Forms.Label
        Me.LblSearchPaymentMethod = New System.Windows.Forms.Label
        Me.PnlListofPaymentMethod = New System.Windows.Forms.Panel
        CType(Me.GrdListofPaymentMethod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlListofPaymentMethod.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrdListofPaymentMethod
        '
        Me.GrdListofPaymentMethod.AllowUserToAddRows = False
        Me.GrdListofPaymentMethod.AllowUserToDeleteRows = False
        Me.GrdListofPaymentMethod.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdListofPaymentMethod.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GrdListofPaymentMethod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdListofPaymentMethod.Location = New System.Drawing.Point(7, 183)
        Me.GrdListofPaymentMethod.Name = "GrdListofPaymentMethod"
        Me.GrdListofPaymentMethod.ReadOnly = True
        Me.GrdListofPaymentMethod.Size = New System.Drawing.Size(732, 289)
        Me.GrdListofPaymentMethod.TabIndex = 107
        '
        'TxtSearchPaymentMethod
        '
        Me.TxtSearchPaymentMethod.Location = New System.Drawing.Point(216, 122)
        Me.TxtSearchPaymentMethod.Name = "TxtSearchPaymentMethod"
        Me.TxtSearchPaymentMethod.Size = New System.Drawing.Size(312, 20)
        Me.TxtSearchPaymentMethod.TabIndex = 106
        '
        'LblListofPaymentMethod
        '
        Me.LblListofPaymentMethod.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblListofPaymentMethod.AutoSize = True
        Me.LblListofPaymentMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblListofPaymentMethod.ForeColor = System.Drawing.Color.White
        Me.LblListofPaymentMethod.Location = New System.Drawing.Point(184, 29)
        Me.LblListofPaymentMethod.Name = "LblListofPaymentMethod"
        Me.LblListofPaymentMethod.Size = New System.Drawing.Size(374, 37)
        Me.LblListofPaymentMethod.TabIndex = 2
        Me.LblListofPaymentMethod.Text = "List of Payment Method"
        '
        'LblSearchPaymentMethod
        '
        Me.LblSearchPaymentMethod.AutoSize = True
        Me.LblSearchPaymentMethod.Location = New System.Drawing.Point(46, 125)
        Me.LblSearchPaymentMethod.Name = "LblSearchPaymentMethod"
        Me.LblSearchPaymentMethod.Size = New System.Drawing.Size(127, 13)
        Me.LblSearchPaymentMethod.TabIndex = 105
        Me.LblSearchPaymentMethod.Text = "Search Payment Method:"
        '
        'PnlListofPaymentMethod
        '
        Me.PnlListofPaymentMethod.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlListofPaymentMethod.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PnlListofPaymentMethod.Controls.Add(Me.LblListofPaymentMethod)
        Me.PnlListofPaymentMethod.Location = New System.Drawing.Point(1, 0)
        Me.PnlListofPaymentMethod.Name = "PnlListofPaymentMethod"
        Me.PnlListofPaymentMethod.Size = New System.Drawing.Size(743, 94)
        Me.PnlListofPaymentMethod.TabIndex = 104
        '
        'FrmListOfPaymentMethod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(744, 480)
        Me.Controls.Add(Me.GrdListofPaymentMethod)
        Me.Controls.Add(Me.TxtSearchPaymentMethod)
        Me.Controls.Add(Me.LblSearchPaymentMethod)
        Me.Controls.Add(Me.PnlListofPaymentMethod)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmListOfPaymentMethod"
        Me.Text = "List of Payment Method"
        CType(Me.GrdListofPaymentMethod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlListofPaymentMethod.ResumeLayout(False)
        Me.PnlListofPaymentMethod.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrdListofPaymentMethod As System.Windows.Forms.DataGridView
    Friend WithEvents TxtSearchPaymentMethod As System.Windows.Forms.TextBox
    Friend WithEvents LblListofPaymentMethod As System.Windows.Forms.Label
    Friend WithEvents LblSearchPaymentMethod As System.Windows.Forms.Label
    Friend WithEvents PnlListofPaymentMethod As System.Windows.Forms.Panel
End Class
