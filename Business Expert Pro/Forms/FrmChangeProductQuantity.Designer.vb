<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChangeProductQuantity
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
        Me.PnlChangeProductQuantity = New System.Windows.Forms.Panel
        Me.LblChangeProductQuantity = New System.Windows.Forms.Label
        Me.LblSalePrice = New System.Windows.Forms.Label
        Me.Lbl = New System.Windows.Forms.Label
        Me.LblQuantity = New System.Windows.Forms.Label
        Me.LblFrom = New System.Windows.Forms.Label
        Me.LblTo = New System.Windows.Forms.Label
        Me.TxtFrom = New System.Windows.Forms.TextBox
        Me.TxtTo = New System.Windows.Forms.TextBox
        Me.TxtQuantity = New System.Windows.Forms.TextBox
        Me.TxtSalePrice = New System.Windows.Forms.TextBox
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.GrdProductSerials = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtSingleSerial = New System.Windows.Forms.TextBox
        Me.LblSingleSerial = New System.Windows.Forms.Label
        Me.GrpWarrantySerial = New System.Windows.Forms.GroupBox
        Me.BtnDeleteAll = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.PnlChangeProductQuantity.SuspendLayout()
        CType(Me.GrdProductSerials, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GrpWarrantySerial.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlChangeProductQuantity
        '
        Me.PnlChangeProductQuantity.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlChangeProductQuantity.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PnlChangeProductQuantity.Controls.Add(Me.LblChangeProductQuantity)
        Me.PnlChangeProductQuantity.Location = New System.Drawing.Point(0, 0)
        Me.PnlChangeProductQuantity.Name = "PnlChangeProductQuantity"
        Me.PnlChangeProductQuantity.Size = New System.Drawing.Size(584, 86)
        Me.PnlChangeProductQuantity.TabIndex = 0
        '
        'LblChangeProductQuantity
        '
        Me.LblChangeProductQuantity.AutoSize = True
        Me.LblChangeProductQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblChangeProductQuantity.ForeColor = System.Drawing.Color.White
        Me.LblChangeProductQuantity.Location = New System.Drawing.Point(98, 29)
        Me.LblChangeProductQuantity.Name = "LblChangeProductQuantity"
        Me.LblChangeProductQuantity.Size = New System.Drawing.Size(302, 29)
        Me.LblChangeProductQuantity.TabIndex = 0
        Me.LblChangeProductQuantity.Text = "Change Product Quantity"
        '
        'LblSalePrice
        '
        Me.LblSalePrice.AutoSize = True
        Me.LblSalePrice.Location = New System.Drawing.Point(1, 19)
        Me.LblSalePrice.Name = "LblSalePrice"
        Me.LblSalePrice.Size = New System.Drawing.Size(58, 13)
        Me.LblSalePrice.TabIndex = 2
        Me.LblSalePrice.Text = "Sale Price:"
        '
        'Lbl
        '
        Me.Lbl.AutoSize = True
        Me.Lbl.Location = New System.Drawing.Point(244, 15)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.Size = New System.Drawing.Size(0, 13)
        Me.Lbl.TabIndex = 3
        '
        'LblQuantity
        '
        Me.LblQuantity.AutoSize = True
        Me.LblQuantity.Location = New System.Drawing.Point(1, 46)
        Me.LblQuantity.Name = "LblQuantity"
        Me.LblQuantity.Size = New System.Drawing.Size(49, 13)
        Me.LblQuantity.TabIndex = 4
        Me.LblQuantity.Text = "Quantity:"
        '
        'LblFrom
        '
        Me.LblFrom.AutoSize = True
        Me.LblFrom.Location = New System.Drawing.Point(2, 40)
        Me.LblFrom.Name = "LblFrom"
        Me.LblFrom.Size = New System.Drawing.Size(33, 13)
        Me.LblFrom.TabIndex = 5
        Me.LblFrom.Text = "From:"
        '
        'LblTo
        '
        Me.LblTo.AutoSize = True
        Me.LblTo.Location = New System.Drawing.Point(113, 40)
        Me.LblTo.Name = "LblTo"
        Me.LblTo.Size = New System.Drawing.Size(23, 13)
        Me.LblTo.TabIndex = 6
        Me.LblTo.Text = "To:"
        '
        'TxtFrom
        '
        Me.TxtFrom.Location = New System.Drawing.Point(38, 37)
        Me.TxtFrom.Name = "TxtFrom"
        Me.TxtFrom.Size = New System.Drawing.Size(69, 20)
        Me.TxtFrom.TabIndex = 103
        '
        'TxtTo
        '
        Me.TxtTo.Location = New System.Drawing.Point(142, 37)
        Me.TxtTo.Name = "TxtTo"
        Me.TxtTo.Size = New System.Drawing.Size(77, 20)
        Me.TxtTo.TabIndex = 104
        '
        'TxtQuantity
        '
        Me.TxtQuantity.Location = New System.Drawing.Point(76, 42)
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.Size = New System.Drawing.Size(100, 20)
        Me.TxtQuantity.TabIndex = 102
        '
        'TxtSalePrice
        '
        Me.TxtSalePrice.Location = New System.Drawing.Point(76, 16)
        Me.TxtSalePrice.Name = "TxtSalePrice"
        Me.TxtSalePrice.Size = New System.Drawing.Size(100, 20)
        Me.TxtSalePrice.TabIndex = 101
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(235, 35)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(34, 23)
        Me.BtnAdd.TabIndex = 105
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'GrdProductSerials
        '
        Me.GrdProductSerials.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdProductSerials.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GrdProductSerials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdProductSerials.Location = New System.Drawing.Point(343, 139)
        Me.GrdProductSerials.Name = "GrdProductSerials"
        Me.GrdProductSerials.Size = New System.Drawing.Size(229, 344)
        Me.GrdProductSerials.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtSingleSerial)
        Me.GroupBox1.Controls.Add(Me.LblSingleSerial)
        Me.GroupBox1.Controls.Add(Me.TxtSalePrice)
        Me.GroupBox1.Controls.Add(Me.TxtQuantity)
        Me.GroupBox1.Controls.Add(Me.LblQuantity)
        Me.GroupBox1.Controls.Add(Me.LblSalePrice)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 161)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(253, 105)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'TxtSingleSerial
        '
        Me.TxtSingleSerial.Location = New System.Drawing.Point(76, 71)
        Me.TxtSingleSerial.Name = "TxtSingleSerial"
        Me.TxtSingleSerial.Size = New System.Drawing.Size(100, 20)
        Me.TxtSingleSerial.TabIndex = 104
        '
        'LblSingleSerial
        '
        Me.LblSingleSerial.AutoSize = True
        Me.LblSingleSerial.Location = New System.Drawing.Point(1, 73)
        Me.LblSingleSerial.Name = "LblSingleSerial"
        Me.LblSingleSerial.Size = New System.Drawing.Size(68, 13)
        Me.LblSingleSerial.TabIndex = 103
        Me.LblSingleSerial.Text = "Single Serial:"
        '
        'GrpWarrantySerial
        '
        Me.GrpWarrantySerial.Controls.Add(Me.BtnAdd)
        Me.GrpWarrantySerial.Controls.Add(Me.TxtTo)
        Me.GrpWarrantySerial.Controls.Add(Me.TxtFrom)
        Me.GrpWarrantySerial.Controls.Add(Me.LblTo)
        Me.GrpWarrantySerial.Controls.Add(Me.LblFrom)
        Me.GrpWarrantySerial.Controls.Add(Me.Lbl)
        Me.GrpWarrantySerial.Location = New System.Drawing.Point(11, 272)
        Me.GrpWarrantySerial.Name = "GrpWarrantySerial"
        Me.GrpWarrantySerial.Size = New System.Drawing.Size(301, 75)
        Me.GrpWarrantySerial.TabIndex = 15
        Me.GrpWarrantySerial.TabStop = False
        Me.GrpWarrantySerial.Text = "Serial Range"
        '
        'BtnDeleteAll
        '
        Me.BtnDeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDeleteAll.Location = New System.Drawing.Point(504, 92)
        Me.BtnDeleteAll.Name = "BtnDeleteAll"
        Me.BtnDeleteAll.Size = New System.Drawing.Size(68, 34)
        Me.BtnDeleteAll.TabIndex = 106
        Me.BtnDeleteAll.Text = "Delete All"
        Me.BtnDeleteAll.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Location = New System.Drawing.Point(342, 92)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(58, 34)
        Me.BtnDelete.TabIndex = 107
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'FrmChangeProductQuantity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(584, 495)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnDeleteAll)
        Me.Controls.Add(Me.GrpWarrantySerial)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GrdProductSerials)
        Me.Controls.Add(Me.PnlChangeProductQuantity)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmChangeProductQuantity"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmChangeProductQuantity"
        Me.PnlChangeProductQuantity.ResumeLayout(False)
        Me.PnlChangeProductQuantity.PerformLayout()
        CType(Me.GrdProductSerials, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GrpWarrantySerial.ResumeLayout(False)
        Me.GrpWarrantySerial.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlChangeProductQuantity As System.Windows.Forms.Panel
    Friend WithEvents LblChangeProductQuantity As System.Windows.Forms.Label
    Friend WithEvents LblSalePrice As System.Windows.Forms.Label
    Friend WithEvents Lbl As System.Windows.Forms.Label
    Friend WithEvents LblQuantity As System.Windows.Forms.Label
    Friend WithEvents LblFrom As System.Windows.Forms.Label
    Friend WithEvents LblTo As System.Windows.Forms.Label
    Friend WithEvents TxtFrom As System.Windows.Forms.TextBox
    Friend WithEvents TxtTo As System.Windows.Forms.TextBox
    Friend WithEvents TxtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents TxtSalePrice As System.Windows.Forms.TextBox
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents GrdProductSerials As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GrpWarrantySerial As System.Windows.Forms.GroupBox
    Friend WithEvents TxtSingleSerial As System.Windows.Forms.TextBox
    Friend WithEvents LblSingleSerial As System.Windows.Forms.Label
    Friend WithEvents BtnDeleteAll As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
End Class
