<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListofProducts
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
        Me.PnlListofProducts = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.LblListofProducts = New System.Windows.Forms.Label
        Me.LblSearchProductName = New System.Windows.Forms.Label
        Me.TxtSearchProductName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.LblSearchProductSubcategory = New System.Windows.Forms.Label
        Me.LblSearchProductCategory = New System.Windows.Forms.Label
        Me.LblSearchProductGroup = New System.Windows.Forms.Label
        Me.CmbSearchProductSubcategory = New System.Windows.Forms.ComboBox
        Me.CmbSearchProductCategory = New System.Windows.Forms.ComboBox
        Me.CmbSearchProductGroup = New System.Windows.Forms.ComboBox
        Me.GrdListofProducts = New System.Windows.Forms.DataGridView
        Me.PnlListofProducts.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GrdListofProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlListofProducts
        '
        Me.PnlListofProducts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlListofProducts.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlListofProducts.Controls.Add(Me.Panel1)
        Me.PnlListofProducts.Controls.Add(Me.LblListofProducts)
        Me.PnlListofProducts.Location = New System.Drawing.Point(1, 0)
        Me.PnlListofProducts.Name = "PnlListofProducts"
        Me.PnlListofProducts.Size = New System.Drawing.Size(966, 81)
        Me.PnlListofProducts.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Btnclose)
        Me.Panel1.Controls.Add(Me.Btnminimized)
        Me.Panel1.Controls.Add(Me.Btnmaximized)
        Me.Panel1.Location = New System.Drawing.Point(-5, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(971, 28)
        Me.Panel1.TabIndex = 4
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(947, 0)
        Me.Btnclose.Name = "Btnclose"
        Me.Btnclose.Size = New System.Drawing.Size(24, 24)
        Me.Btnclose.TabIndex = 1162
        Me.Btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnclose.UseVisualStyleBackColor = False
        '
        'Btnminimized
        '
        Me.Btnminimized.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnminimized.BackColor = System.Drawing.SystemColors.Control
        Me.Btnminimized.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnminimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnminimized.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Minimize_Window_32px_2
        Me.Btnminimized.Location = New System.Drawing.Point(887, 0)
        Me.Btnminimized.Name = "Btnminimized"
        Me.Btnminimized.Size = New System.Drawing.Size(24, 24)
        Me.Btnminimized.TabIndex = 1161
        Me.Btnminimized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnminimized.UseVisualStyleBackColor = False
        '
        'Btnmaximized
        '
        Me.Btnmaximized.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnmaximized.BackColor = System.Drawing.SystemColors.Control
        Me.Btnmaximized.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnmaximized.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnmaximized.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Maximize_Window_32px_2
        Me.Btnmaximized.Location = New System.Drawing.Point(917, 0)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1160
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'LblListofProducts
        '
        Me.LblListofProducts.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblListofProducts.AutoSize = True
        Me.LblListofProducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblListofProducts.ForeColor = System.Drawing.Color.White
        Me.LblListofProducts.Location = New System.Drawing.Point(356, 31)
        Me.LblListofProducts.Name = "LblListofProducts"
        Me.LblListofProducts.Size = New System.Drawing.Size(255, 37)
        Me.LblListofProducts.TabIndex = 0
        Me.LblListofProducts.Text = "List of Products"
        '
        'LblSearchProductName
        '
        Me.LblSearchProductName.AutoSize = True
        Me.LblSearchProductName.Location = New System.Drawing.Point(286, 174)
        Me.LblSearchProductName.Name = "LblSearchProductName"
        Me.LblSearchProductName.Size = New System.Drawing.Size(115, 13)
        Me.LblSearchProductName.TabIndex = 2
        Me.LblSearchProductName.Text = "Search Product Name:"
        '
        'TxtSearchProductName
        '
        Me.TxtSearchProductName.Location = New System.Drawing.Point(448, 174)
        Me.TxtSearchProductName.Name = "TxtSearchProductName"
        Me.TxtSearchProductName.Size = New System.Drawing.Size(235, 20)
        Me.TxtSearchProductName.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(825, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'LblSearchProductSubcategory
        '
        Me.LblSearchProductSubcategory.AutoSize = True
        Me.LblSearchProductSubcategory.Location = New System.Drawing.Point(286, 148)
        Me.LblSearchProductSubcategory.Name = "LblSearchProductSubcategory"
        Me.LblSearchProductSubcategory.Size = New System.Drawing.Size(147, 13)
        Me.LblSearchProductSubcategory.TabIndex = 2032
        Me.LblSearchProductSubcategory.Text = "Search Product Subcategory:"
        '
        'LblSearchProductCategory
        '
        Me.LblSearchProductCategory.AutoSize = True
        Me.LblSearchProductCategory.Location = New System.Drawing.Point(286, 122)
        Me.LblSearchProductCategory.Name = "LblSearchProductCategory"
        Me.LblSearchProductCategory.Size = New System.Drawing.Size(129, 13)
        Me.LblSearchProductCategory.TabIndex = 2031
        Me.LblSearchProductCategory.Text = "Search Product Category:"
        '
        'LblSearchProductGroup
        '
        Me.LblSearchProductGroup.AutoSize = True
        Me.LblSearchProductGroup.Location = New System.Drawing.Point(286, 96)
        Me.LblSearchProductGroup.Name = "LblSearchProductGroup"
        Me.LblSearchProductGroup.Size = New System.Drawing.Size(116, 13)
        Me.LblSearchProductGroup.TabIndex = 2030
        Me.LblSearchProductGroup.Text = "Search Product Group:"
        '
        'CmbSearchProductSubcategory
        '
        Me.CmbSearchProductSubcategory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbSearchProductSubcategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbSearchProductSubcategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbSearchProductSubcategory.FormattingEnabled = True
        Me.CmbSearchProductSubcategory.Location = New System.Drawing.Point(448, 147)
        Me.CmbSearchProductSubcategory.Name = "CmbSearchProductSubcategory"
        Me.CmbSearchProductSubcategory.Size = New System.Drawing.Size(235, 21)
        Me.CmbSearchProductSubcategory.TabIndex = 2029
        '
        'CmbSearchProductCategory
        '
        Me.CmbSearchProductCategory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbSearchProductCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbSearchProductCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbSearchProductCategory.FormattingEnabled = True
        Me.CmbSearchProductCategory.Location = New System.Drawing.Point(448, 120)
        Me.CmbSearchProductCategory.Name = "CmbSearchProductCategory"
        Me.CmbSearchProductCategory.Size = New System.Drawing.Size(235, 21)
        Me.CmbSearchProductCategory.TabIndex = 2028
        '
        'CmbSearchProductGroup
        '
        Me.CmbSearchProductGroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbSearchProductGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbSearchProductGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbSearchProductGroup.FormattingEnabled = True
        Me.CmbSearchProductGroup.Location = New System.Drawing.Point(448, 93)
        Me.CmbSearchProductGroup.Name = "CmbSearchProductGroup"
        Me.CmbSearchProductGroup.Size = New System.Drawing.Size(235, 21)
        Me.CmbSearchProductGroup.TabIndex = 2027
        '
        'GrdListofProducts
        '
        Me.GrdListofProducts.AllowUserToAddRows = False
        Me.GrdListofProducts.AllowUserToDeleteRows = False
        Me.GrdListofProducts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdListofProducts.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GrdListofProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdListofProducts.Location = New System.Drawing.Point(5, 211)
        Me.GrdListofProducts.Name = "GrdListofProducts"
        Me.GrdListofProducts.ReadOnly = True
        Me.GrdListofProducts.Size = New System.Drawing.Size(960, 287)
        Me.GrdListofProducts.TabIndex = 2033
        '
        'FrmListofProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(968, 502)
        Me.Controls.Add(Me.GrdListofProducts)
        Me.Controls.Add(Me.LblSearchProductSubcategory)
        Me.Controls.Add(Me.LblSearchProductCategory)
        Me.Controls.Add(Me.LblSearchProductGroup)
        Me.Controls.Add(Me.CmbSearchProductSubcategory)
        Me.Controls.Add(Me.CmbSearchProductCategory)
        Me.Controls.Add(Me.CmbSearchProductGroup)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtSearchProductName)
        Me.Controls.Add(Me.LblSearchProductName)
        Me.Controls.Add(Me.PnlListofProducts)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "FrmListofProducts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List of Products"
        Me.PnlListofProducts.ResumeLayout(False)
        Me.PnlListofProducts.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.GrdListofProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PnlListofProducts As System.Windows.Forms.Panel
    Friend WithEvents LblListofProducts As System.Windows.Forms.Label
    Friend WithEvents LblSearchProductName As System.Windows.Forms.Label
    Friend WithEvents TxtSearchProductName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblSearchProductSubcategory As System.Windows.Forms.Label
    Friend WithEvents LblSearchProductCategory As System.Windows.Forms.Label
    Friend WithEvents LblSearchProductGroup As System.Windows.Forms.Label
    Friend WithEvents CmbSearchProductSubcategory As System.Windows.Forms.ComboBox
    Friend WithEvents CmbSearchProductCategory As System.Windows.Forms.ComboBox
    Friend WithEvents CmbSearchProductGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
    Friend WithEvents GrdListofProducts As System.Windows.Forms.DataGridView
End Class
