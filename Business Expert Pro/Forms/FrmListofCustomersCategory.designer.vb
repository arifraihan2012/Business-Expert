<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListofCustomersCategory
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
        Me.PnlListofCustomers = New System.Windows.Forms.Panel
        Me.LblListofCustomers = New System.Windows.Forms.Label
        Me.LblSearchCustomerName = New System.Windows.Forms.Label
        Me.TxtSearchCustomerName = New System.Windows.Forms.TextBox
        Me.GrdListofCustomers = New System.Windows.Forms.DataGridView
        Me.PnlListofCustomers.SuspendLayout()
        CType(Me.GrdListofCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlListofCustomers
        '
        Me.PnlListofCustomers.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlListofCustomers.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PnlListofCustomers.Controls.Add(Me.LblListofCustomers)
        Me.PnlListofCustomers.Location = New System.Drawing.Point(1, -2)
        Me.PnlListofCustomers.Name = "PnlListofCustomers"
        Me.PnlListofCustomers.Size = New System.Drawing.Size(743, 94)
        Me.PnlListofCustomers.TabIndex = 0
        '
        'LblListofCustomers
        '
        Me.LblListofCustomers.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblListofCustomers.AutoSize = True
        Me.LblListofCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblListofCustomers.ForeColor = System.Drawing.Color.White
        Me.LblListofCustomers.Location = New System.Drawing.Point(229, 29)
        Me.LblListofCustomers.Name = "LblListofCustomers"
        Me.LblListofCustomers.Size = New System.Drawing.Size(284, 37)
        Me.LblListofCustomers.TabIndex = 2
        Me.LblListofCustomers.Text = "List of Customers"
        '
        'LblSearchCustomerName
        '
        Me.LblSearchCustomerName.AutoSize = True
        Me.LblSearchCustomerName.Location = New System.Drawing.Point(50, 126)
        Me.LblSearchCustomerName.Name = "LblSearchCustomerName"
        Me.LblSearchCustomerName.Size = New System.Drawing.Size(122, 13)
        Me.LblSearchCustomerName.TabIndex = 1
        Me.LblSearchCustomerName.Text = "Search Customer Name:"
        '
        'TxtSearchCustomerName
        '
        Me.TxtSearchCustomerName.Location = New System.Drawing.Point(216, 123)
        Me.TxtSearchCustomerName.Name = "TxtSearchCustomerName"
        Me.TxtSearchCustomerName.Size = New System.Drawing.Size(312, 20)
        Me.TxtSearchCustomerName.TabIndex = 100
        '
        'GrdListofCustomers
        '
        Me.GrdListofCustomers.AllowUserToAddRows = False
        Me.GrdListofCustomers.AllowUserToDeleteRows = False
        Me.GrdListofCustomers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdListofCustomers.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GrdListofCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdListofCustomers.Location = New System.Drawing.Point(6, 184)
        Me.GrdListofCustomers.Name = "GrdListofCustomers"
        Me.GrdListofCustomers.ReadOnly = True
        Me.GrdListofCustomers.Size = New System.Drawing.Size(732, 289)
        Me.GrdListofCustomers.TabIndex = 101
        '
        'FrmListofCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(744, 480)
        Me.Controls.Add(Me.GrdListofCustomers)
        Me.Controls.Add(Me.TxtSearchCustomerName)
        Me.Controls.Add(Me.LblSearchCustomerName)
        Me.Controls.Add(Me.PnlListofCustomers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmListofCustomers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List of Customers"
        Me.PnlListofCustomers.ResumeLayout(False)
        Me.PnlListofCustomers.PerformLayout()
        CType(Me.GrdListofCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PnlListofCustomers As System.Windows.Forms.Panel
    Friend WithEvents LblSearchCustomerName As System.Windows.Forms.Label
    Friend WithEvents TxtSearchCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents LblListofCustomers As System.Windows.Forms.Label
    Friend WithEvents GrdListofCustomers As System.Windows.Forms.DataGridView
End Class
