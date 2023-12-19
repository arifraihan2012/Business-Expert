<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListofEmployees
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
        Me.LblSearchEmployee = New System.Windows.Forms.Label
        Me.TxtSearchEmployee = New System.Windows.Forms.TextBox
        Me.GrdListOfEmployee = New System.Windows.Forms.DataGridView
        Me.PnlListOfEmployee = New System.Windows.Forms.Panel
        Me.LblListOfEmployees = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.LblTotalEmployee = New System.Windows.Forms.Label
        CType(Me.GrdListOfEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlListOfEmployee.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblSearchEmployee
        '
        Me.LblSearchEmployee.AutoSize = True
        Me.LblSearchEmployee.Location = New System.Drawing.Point(80, 126)
        Me.LblSearchEmployee.Name = "LblSearchEmployee"
        Me.LblSearchEmployee.Size = New System.Drawing.Size(98, 13)
        Me.LblSearchEmployee.TabIndex = 31
        Me.LblSearchEmployee.Text = "Search Employees:"
        '
        'TxtSearchEmployee
        '
        Me.TxtSearchEmployee.Location = New System.Drawing.Point(214, 126)
        Me.TxtSearchEmployee.Name = "TxtSearchEmployee"
        Me.TxtSearchEmployee.Size = New System.Drawing.Size(312, 20)
        Me.TxtSearchEmployee.TabIndex = 30
        '
        'GrdListOfEmployee
        '
        Me.GrdListOfEmployee.AllowUserToAddRows = False
        Me.GrdListOfEmployee.AllowUserToDeleteRows = False
        Me.GrdListOfEmployee.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdListOfEmployee.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GrdListOfEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdListOfEmployee.Location = New System.Drawing.Point(8, 182)
        Me.GrdListOfEmployee.Name = "GrdListOfEmployee"
        Me.GrdListOfEmployee.ReadOnly = True
        Me.GrdListOfEmployee.Size = New System.Drawing.Size(729, 291)
        Me.GrdListOfEmployee.TabIndex = 29
        '
        'PnlListOfEmployee
        '
        Me.PnlListOfEmployee.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlListOfEmployee.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PnlListOfEmployee.Controls.Add(Me.LblListOfEmployees)
        Me.PnlListOfEmployee.Location = New System.Drawing.Point(-6, 0)
        Me.PnlListOfEmployee.Name = "PnlListOfEmployee"
        Me.PnlListOfEmployee.Size = New System.Drawing.Size(755, 92)
        Me.PnlListOfEmployee.TabIndex = 28
        '
        'LblListOfEmployees
        '
        Me.LblListOfEmployees.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblListOfEmployees.AutoSize = True
        Me.LblListOfEmployees.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblListOfEmployees.ForeColor = System.Drawing.Color.White
        Me.LblListOfEmployees.Location = New System.Drawing.Point(235, 28)
        Me.LblListOfEmployees.Name = "LblListOfEmployees"
        Me.LblListOfEmployees.Size = New System.Drawing.Size(281, 37)
        Me.LblListOfEmployees.TabIndex = 0
        Me.LblListOfEmployees.Text = "List of employees"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(667, 157)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(22, 16)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "00"
        '
        'LblTotalEmployee
        '
        Me.LblTotalEmployee.AutoSize = True
        Me.LblTotalEmployee.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalEmployee.Location = New System.Drawing.Point(555, 157)
        Me.LblTotalEmployee.Name = "LblTotalEmployee"
        Me.LblTotalEmployee.Size = New System.Drawing.Size(110, 16)
        Me.LblTotalEmployee.TabIndex = 32
        Me.LblTotalEmployee.Text = "Total Employee:"
        '
        'FrmListofEmployees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(744, 480)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.LblTotalEmployee)
        Me.Controls.Add(Me.LblSearchEmployee)
        Me.Controls.Add(Me.TxtSearchEmployee)
        Me.Controls.Add(Me.GrdListOfEmployee)
        Me.Controls.Add(Me.PnlListOfEmployee)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmListofEmployees"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List of Employees"
        CType(Me.GrdListOfEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlListOfEmployee.ResumeLayout(False)
        Me.PnlListOfEmployee.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblSearchEmployee As System.Windows.Forms.Label
    Friend WithEvents TxtSearchEmployee As System.Windows.Forms.TextBox
    Friend WithEvents GrdListOfEmployee As System.Windows.Forms.DataGridView
    Friend WithEvents PnlListOfEmployee As System.Windows.Forms.Panel
    Friend WithEvents LblListOfEmployees As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents LblTotalEmployee As System.Windows.Forms.Label
End Class
