<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListOfPerposes
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
        Me.PnlListOfPurposes = New System.Windows.Forms.Panel
        Me.LblListOfPurposes = New System.Windows.Forms.Label
        Me.LblSearchPurposeName = New System.Windows.Forms.Label
        Me.TxtSearchPurposeName = New System.Windows.Forms.TextBox
        Me.GrdListOfPurposes = New System.Windows.Forms.DataGridView
        Me.PnlListOfPurposes.SuspendLayout()
        CType(Me.GrdListOfPurposes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlListOfPurposes
        '
        Me.PnlListOfPurposes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlListOfPurposes.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PnlListOfPurposes.Controls.Add(Me.LblListOfPurposes)
        Me.PnlListOfPurposes.Location = New System.Drawing.Point(2, -1)
        Me.PnlListOfPurposes.Name = "PnlListOfPurposes"
        Me.PnlListOfPurposes.Size = New System.Drawing.Size(743, 94)
        Me.PnlListOfPurposes.TabIndex = 3
        '
        'LblListOfPurposes
        '
        Me.LblListOfPurposes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblListOfPurposes.AutoSize = True
        Me.LblListOfPurposes.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblListOfPurposes.ForeColor = System.Drawing.Color.White
        Me.LblListOfPurposes.Location = New System.Drawing.Point(240, 29)
        Me.LblListOfPurposes.Name = "LblListOfPurposes"
        Me.LblListOfPurposes.Size = New System.Drawing.Size(263, 37)
        Me.LblListOfPurposes.TabIndex = 2
        Me.LblListOfPurposes.Text = "List of Purposes"
        '
        'LblSearchPurposeName
        '
        Me.LblSearchPurposeName.AutoSize = True
        Me.LblSearchPurposeName.Location = New System.Drawing.Point(70, 125)
        Me.LblSearchPurposeName.Name = "LblSearchPurposeName"
        Me.LblSearchPurposeName.Size = New System.Drawing.Size(120, 13)
        Me.LblSearchPurposeName.TabIndex = 104
        Me.LblSearchPurposeName.Text = "Search Purpose Name :"
        '
        'TxtSearchPurposeName
        '
        Me.TxtSearchPurposeName.Location = New System.Drawing.Point(211, 125)
        Me.TxtSearchPurposeName.Name = "TxtSearchPurposeName"
        Me.TxtSearchPurposeName.Size = New System.Drawing.Size(312, 20)
        Me.TxtSearchPurposeName.TabIndex = 105
        '
        'GrdListOfPurposes
        '
        Me.GrdListOfPurposes.AllowUserToAddRows = False
        Me.GrdListOfPurposes.AllowUserToDeleteRows = False
        Me.GrdListOfPurposes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdListOfPurposes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GrdListOfPurposes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdListOfPurposes.Location = New System.Drawing.Point(7, 179)
        Me.GrdListOfPurposes.Name = "GrdListOfPurposes"
        Me.GrdListOfPurposes.ReadOnly = True
        Me.GrdListOfPurposes.Size = New System.Drawing.Size(732, 289)
        Me.GrdListOfPurposes.TabIndex = 106
        '
        'FrmListOfPerposes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(744, 480)
        Me.Controls.Add(Me.GrdListOfPurposes)
        Me.Controls.Add(Me.TxtSearchPurposeName)
        Me.Controls.Add(Me.LblSearchPurposeName)
        Me.Controls.Add(Me.PnlListOfPurposes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmListOfPerposes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List Of Perposes"
        Me.PnlListOfPurposes.ResumeLayout(False)
        Me.PnlListOfPurposes.PerformLayout()
        CType(Me.GrdListOfPurposes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PnlListOfPurposes As System.Windows.Forms.Panel
    Friend WithEvents LblListOfPurposes As System.Windows.Forms.Label
    Friend WithEvents LblSearchPurposeName As System.Windows.Forms.Label
    Friend WithEvents TxtSearchPurposeName As System.Windows.Forms.TextBox
    Friend WithEvents GrdListOfPurposes As System.Windows.Forms.DataGridView
End Class
