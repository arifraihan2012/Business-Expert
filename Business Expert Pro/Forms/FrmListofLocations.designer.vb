<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListofLocations
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
        Me.PnlListofLocations = New System.Windows.Forms.Panel
        Me.LblListofLocations = New System.Windows.Forms.Label
        Me.GrdListofLocations = New System.Windows.Forms.DataGridView
        Me.TxtSearchLocation = New System.Windows.Forms.TextBox
        Me.LblSearchLocation = New System.Windows.Forms.Label
        Me.PnlListofLocations.SuspendLayout()
        CType(Me.GrdListofLocations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlListofLocations
        '
        Me.PnlListofLocations.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlListofLocations.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PnlListofLocations.Controls.Add(Me.LblListofLocations)
        Me.PnlListofLocations.Location = New System.Drawing.Point(-1, -4)
        Me.PnlListofLocations.Name = "PnlListofLocations"
        Me.PnlListofLocations.Size = New System.Drawing.Size(921, 94)
        Me.PnlListofLocations.TabIndex = 2
        '
        'LblListofLocations
        '
        Me.LblListofLocations.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblListofLocations.AutoSize = True
        Me.LblListofLocations.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblListofLocations.ForeColor = System.Drawing.Color.White
        Me.LblListofLocations.Location = New System.Drawing.Point(327, 29)
        Me.LblListofLocations.Name = "LblListofLocations"
        Me.LblListofLocations.Size = New System.Drawing.Size(267, 37)
        Me.LblListofLocations.TabIndex = 0
        Me.LblListofLocations.Text = "List of Locations"
        '
        'GrdListofLocations
        '
        Me.GrdListofLocations.AllowUserToAddRows = False
        Me.GrdListofLocations.AllowUserToDeleteRows = False
        Me.GrdListofLocations.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdListofLocations.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GrdListofLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdListofLocations.Location = New System.Drawing.Point(7, 176)
        Me.GrdListofLocations.Name = "GrdListofLocations"
        Me.GrdListofLocations.ReadOnly = True
        Me.GrdListofLocations.Size = New System.Drawing.Size(907, 299)
        Me.GrdListofLocations.TabIndex = 3
        '
        'TxtSearchLocation
        '
        Me.TxtSearchLocation.Location = New System.Drawing.Point(281, 125)
        Me.TxtSearchLocation.Name = "TxtSearchLocation"
        Me.TxtSearchLocation.Size = New System.Drawing.Size(364, 20)
        Me.TxtSearchLocation.TabIndex = 7
        '
        'LblSearchLocation
        '
        Me.LblSearchLocation.AutoSize = True
        Me.LblSearchLocation.Location = New System.Drawing.Point(170, 128)
        Me.LblSearchLocation.Name = "LblSearchLocation"
        Me.LblSearchLocation.Size = New System.Drawing.Size(88, 13)
        Me.LblSearchLocation.TabIndex = 6
        Me.LblSearchLocation.Text = "Search Location:"
        '
        'FrmListofLocations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(922, 480)
        Me.Controls.Add(Me.TxtSearchLocation)
        Me.Controls.Add(Me.LblSearchLocation)
        Me.Controls.Add(Me.GrdListofLocations)
        Me.Controls.Add(Me.PnlListofLocations)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MinimizeBox = False
        Me.Name = "FrmListofLocations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List of Locations"
        Me.PnlListofLocations.ResumeLayout(False)
        Me.PnlListofLocations.PerformLayout()
        CType(Me.GrdListofLocations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PnlListofLocations As System.Windows.Forms.Panel
    Friend WithEvents LblListofLocations As System.Windows.Forms.Label
    Friend WithEvents GrdListofLocations As System.Windows.Forms.DataGridView
    Friend WithEvents TxtSearchLocation As System.Windows.Forms.TextBox
    Friend WithEvents LblSearchLocation As System.Windows.Forms.Label
End Class
