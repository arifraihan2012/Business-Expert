<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListofSuppliers
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
        Me.PnlListofSuppliers = New System.Windows.Forms.Panel
        Me.LblListofSuppliers = New System.Windows.Forms.Label
        Me.TxtSearchSupplierName = New System.Windows.Forms.TextBox
        Me.LblSearchSupplierName = New System.Windows.Forms.Label
        Me.GrdListofSuppliers = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.PnlListofSuppliers.SuspendLayout()
        CType(Me.GrdListofSuppliers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlListofSuppliers
        '
        Me.PnlListofSuppliers.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlListofSuppliers.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PnlListofSuppliers.Controls.Add(Me.LblListofSuppliers)
        Me.PnlListofSuppliers.Location = New System.Drawing.Point(1, 0)
        Me.PnlListofSuppliers.Name = "PnlListofSuppliers"
        Me.PnlListofSuppliers.Size = New System.Drawing.Size(743, 94)
        Me.PnlListofSuppliers.TabIndex = 1
        '
        'LblListofSuppliers
        '
        Me.LblListofSuppliers.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblListofSuppliers.AutoSize = True
        Me.LblListofSuppliers.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblListofSuppliers.ForeColor = System.Drawing.Color.White
        Me.LblListofSuppliers.Location = New System.Drawing.Point(240, 29)
        Me.LblListofSuppliers.Name = "LblListofSuppliers"
        Me.LblListofSuppliers.Size = New System.Drawing.Size(262, 37)
        Me.LblListofSuppliers.TabIndex = 2
        Me.LblListofSuppliers.Text = "List of Suppliers"
        '
        'TxtSearchSupplierName
        '
        Me.TxtSearchSupplierName.Location = New System.Drawing.Point(216, 127)
        Me.TxtSearchSupplierName.Name = "TxtSearchSupplierName"
        Me.TxtSearchSupplierName.Size = New System.Drawing.Size(312, 20)
        Me.TxtSearchSupplierName.TabIndex = 102
        '
        'LblSearchSupplierName
        '
        Me.LblSearchSupplierName.AutoSize = True
        Me.LblSearchSupplierName.Location = New System.Drawing.Point(77, 130)
        Me.LblSearchSupplierName.Name = "LblSearchSupplierName"
        Me.LblSearchSupplierName.Size = New System.Drawing.Size(116, 13)
        Me.LblSearchSupplierName.TabIndex = 101
        Me.LblSearchSupplierName.Text = "Search Supplier Name:"
        '
        'GrdListofSuppliers
        '
        Me.GrdListofSuppliers.AllowUserToAddRows = False
        Me.GrdListofSuppliers.AllowUserToDeleteRows = False
        Me.GrdListofSuppliers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdListofSuppliers.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GrdListofSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdListofSuppliers.Location = New System.Drawing.Point(6, 182)
        Me.GrdListofSuppliers.Name = "GrdListofSuppliers"
        Me.GrdListofSuppliers.ReadOnly = True
        Me.GrdListofSuppliers.Size = New System.Drawing.Size(732, 289)
        Me.GrdListofSuppliers.TabIndex = 103
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(580, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Label1"
        '
        'FrmListofSuppliers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(744, 480)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GrdListofSuppliers)
        Me.Controls.Add(Me.TxtSearchSupplierName)
        Me.Controls.Add(Me.LblSearchSupplierName)
        Me.Controls.Add(Me.PnlListofSuppliers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmListofSuppliers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List of Suppliers"
        Me.PnlListofSuppliers.ResumeLayout(False)
        Me.PnlListofSuppliers.PerformLayout()
        CType(Me.GrdListofSuppliers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PnlListofSuppliers As System.Windows.Forms.Panel
    Friend WithEvents LblListofSuppliers As System.Windows.Forms.Label
    Friend WithEvents TxtSearchSupplierName As System.Windows.Forms.TextBox
    Friend WithEvents LblSearchSupplierName As System.Windows.Forms.Label
    Friend WithEvents GrdListofSuppliers As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
