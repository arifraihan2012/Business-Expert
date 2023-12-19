<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListofBranches
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
        Me.PnlListofBranches = New System.Windows.Forms.Panel
        Me.LblListofBranches = New System.Windows.Forms.Label
        Me.TxtSearchBranchName = New System.Windows.Forms.TextBox
        Me.LblSearchBranchName = New System.Windows.Forms.Label
        Me.GrdListofBranches = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.PnlListofBranches.SuspendLayout()
        CType(Me.GrdListofBranches, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlListofBranches
        '
        Me.PnlListofBranches.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlListofBranches.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PnlListofBranches.Controls.Add(Me.LblListofBranches)
        Me.PnlListofBranches.Location = New System.Drawing.Point(2, 0)
        Me.PnlListofBranches.Name = "PnlListofBranches"
        Me.PnlListofBranches.Size = New System.Drawing.Size(743, 94)
        Me.PnlListofBranches.TabIndex = 2
        '
        'LblListofBranches
        '
        Me.LblListofBranches.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblListofBranches.AutoSize = True
        Me.LblListofBranches.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblListofBranches.ForeColor = System.Drawing.Color.White
        Me.LblListofBranches.Location = New System.Drawing.Point(240, 29)
        Me.LblListofBranches.Name = "LblListofBranches"
        Me.LblListofBranches.Size = New System.Drawing.Size(263, 37)
        Me.LblListofBranches.TabIndex = 2
        Me.LblListofBranches.Text = "List of Branches"
        '
        'TxtSearchBranchName
        '
        Me.TxtSearchBranchName.Location = New System.Drawing.Point(193, 127)
        Me.TxtSearchBranchName.Name = "TxtSearchBranchName"
        Me.TxtSearchBranchName.Size = New System.Drawing.Size(312, 20)
        Me.TxtSearchBranchName.TabIndex = 104
        '
        'LblSearchBranchName
        '
        Me.LblSearchBranchName.AutoSize = True
        Me.LblSearchBranchName.Location = New System.Drawing.Point(52, 127)
        Me.LblSearchBranchName.Name = "LblSearchBranchName"
        Me.LblSearchBranchName.Size = New System.Drawing.Size(112, 13)
        Me.LblSearchBranchName.TabIndex = 103
        Me.LblSearchBranchName.Text = "Search Branch Name:"
        '
        'GrdListofBranches
        '
        Me.GrdListofBranches.AllowUserToAddRows = False
        Me.GrdListofBranches.AllowUserToDeleteRows = False
        Me.GrdListofBranches.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdListofBranches.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GrdListofBranches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdListofBranches.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GrdListofBranches.Location = New System.Drawing.Point(12, 188)
        Me.GrdListofBranches.Name = "GrdListofBranches"
        Me.GrdListofBranches.ReadOnly = True
        Me.GrdListofBranches.Size = New System.Drawing.Size(720, 289)
        Me.GrdListofBranches.TabIndex = 105
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(637, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Label1"
        '
        'FrmListofBranches
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(744, 480)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GrdListofBranches)
        Me.Controls.Add(Me.TxtSearchBranchName)
        Me.Controls.Add(Me.LblSearchBranchName)
        Me.Controls.Add(Me.PnlListofBranches)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmListofBranches"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List of Branches"
        Me.PnlListofBranches.ResumeLayout(False)
        Me.PnlListofBranches.PerformLayout()
        CType(Me.GrdListofBranches, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PnlListofBranches As System.Windows.Forms.Panel
    Friend WithEvents LblListofBranches As System.Windows.Forms.Label
    Friend WithEvents TxtSearchBranchName As System.Windows.Forms.TextBox
    Friend WithEvents LblSearchBranchName As System.Windows.Forms.Label
    Friend WithEvents GrdListofBranches As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
