<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListOfProductStock
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
        Me.TxtsearchProduct = New System.Windows.Forms.TextBox
        Me.LblSearchProduct = New System.Windows.Forms.Label
        Me.LblListofProductsStock = New System.Windows.Forms.Label
        Me.PnlListofProducts = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmbSearchProductSubcategory = New System.Windows.Forms.ComboBox
        Me.CmbSearchProductCategory = New System.Windows.Forms.ComboBox
        Me.CmbSearchProductGroup = New System.Windows.Forms.ComboBox
        Me.LblSearchProductGroup = New System.Windows.Forms.Label
        Me.LblSearchProductCategory = New System.Windows.Forms.Label
        Me.LblSearchProductSubcategory = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.RdbAllBranch = New System.Windows.Forms.RadioButton
        Me.RdbCurrentBranch = New System.Windows.Forms.RadioButton
        Me.GrdStockInformation = New System.Windows.Forms.DataGridView
        Me.PnlListofProducts.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GrdStockInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtsearchProduct
        '
        Me.TxtsearchProduct.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtsearchProduct.Location = New System.Drawing.Point(487, 164)
        Me.TxtsearchProduct.Name = "TxtsearchProduct"
        Me.TxtsearchProduct.Size = New System.Drawing.Size(235, 20)
        Me.TxtsearchProduct.TabIndex = 104
        '
        'LblSearchProduct
        '
        Me.LblSearchProduct.AutoSize = True
        Me.LblSearchProduct.Location = New System.Drawing.Point(325, 165)
        Me.LblSearchProduct.Name = "LblSearchProduct"
        Me.LblSearchProduct.Size = New System.Drawing.Size(84, 13)
        Me.LblSearchProduct.TabIndex = 1017
        Me.LblSearchProduct.Text = "Search Product:"
        '
        'LblListofProductsStock
        '
        Me.LblListofProductsStock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblListofProductsStock.AutoSize = True
        Me.LblListofProductsStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblListofProductsStock.ForeColor = System.Drawing.Color.White
        Me.LblListofProductsStock.Location = New System.Drawing.Point(494, 41)
        Me.LblListofProductsStock.Name = "LblListofProductsStock"
        Me.LblListofProductsStock.Size = New System.Drawing.Size(255, 37)
        Me.LblListofProductsStock.TabIndex = 0
        Me.LblListofProductsStock.Text = "List of Products"
        '
        'PnlListofProducts
        '
        Me.PnlListofProducts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlListofProducts.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlListofProducts.Controls.Add(Me.Panel2)
        Me.PnlListofProducts.Controls.Add(Me.LblListofProductsStock)
        Me.PnlListofProducts.Location = New System.Drawing.Point(-2, -1)
        Me.PnlListofProducts.Name = "PnlListofProducts"
        Me.PnlListofProducts.Size = New System.Drawing.Size(1245, 75)
        Me.PnlListofProducts.TabIndex = 1018
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Btnclose)
        Me.Panel2.Controls.Add(Me.Btnminimized)
        Me.Panel2.Controls.Add(Me.Btnmaximized)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1239, 27)
        Me.Panel2.TabIndex = 2078
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(1215, 0)
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
        Me.Btnminimized.Location = New System.Drawing.Point(1155, 0)
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
        Me.Btnmaximized.Location = New System.Drawing.Point(1185, 0)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1160
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1071, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 1019
        Me.Label1.Text = "Label1"
        '
        'CmbSearchProductSubcategory
        '
        Me.CmbSearchProductSubcategory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbSearchProductSubcategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbSearchProductSubcategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbSearchProductSubcategory.FormattingEnabled = True
        Me.CmbSearchProductSubcategory.Location = New System.Drawing.Point(487, 136)
        Me.CmbSearchProductSubcategory.Name = "CmbSearchProductSubcategory"
        Me.CmbSearchProductSubcategory.Size = New System.Drawing.Size(235, 21)
        Me.CmbSearchProductSubcategory.TabIndex = 103
        '
        'CmbSearchProductCategory
        '
        Me.CmbSearchProductCategory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbSearchProductCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbSearchProductCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbSearchProductCategory.FormattingEnabled = True
        Me.CmbSearchProductCategory.Location = New System.Drawing.Point(487, 108)
        Me.CmbSearchProductCategory.Name = "CmbSearchProductCategory"
        Me.CmbSearchProductCategory.Size = New System.Drawing.Size(235, 21)
        Me.CmbSearchProductCategory.TabIndex = 102
        '
        'CmbSearchProductGroup
        '
        Me.CmbSearchProductGroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbSearchProductGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbSearchProductGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbSearchProductGroup.FormattingEnabled = True
        Me.CmbSearchProductGroup.Location = New System.Drawing.Point(487, 80)
        Me.CmbSearchProductGroup.Name = "CmbSearchProductGroup"
        Me.CmbSearchProductGroup.Size = New System.Drawing.Size(235, 21)
        Me.CmbSearchProductGroup.TabIndex = 101
        '
        'LblSearchProductGroup
        '
        Me.LblSearchProductGroup.AutoSize = True
        Me.LblSearchProductGroup.Location = New System.Drawing.Point(325, 87)
        Me.LblSearchProductGroup.Name = "LblSearchProductGroup"
        Me.LblSearchProductGroup.Size = New System.Drawing.Size(116, 13)
        Me.LblSearchProductGroup.TabIndex = 2024
        Me.LblSearchProductGroup.Text = "Search Product Group:"
        '
        'LblSearchProductCategory
        '
        Me.LblSearchProductCategory.AutoSize = True
        Me.LblSearchProductCategory.Location = New System.Drawing.Point(325, 113)
        Me.LblSearchProductCategory.Name = "LblSearchProductCategory"
        Me.LblSearchProductCategory.Size = New System.Drawing.Size(129, 13)
        Me.LblSearchProductCategory.TabIndex = 2025
        Me.LblSearchProductCategory.Text = "Search Product Category:"
        '
        'LblSearchProductSubcategory
        '
        Me.LblSearchProductSubcategory.AutoSize = True
        Me.LblSearchProductSubcategory.Location = New System.Drawing.Point(325, 139)
        Me.LblSearchProductSubcategory.Name = "LblSearchProductSubcategory"
        Me.LblSearchProductSubcategory.Size = New System.Drawing.Size(147, 13)
        Me.LblSearchProductSubcategory.TabIndex = 2026
        Me.LblSearchProductSubcategory.Text = "Search Product Subcategory:"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(22, 522)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(254, 16)
        Me.Label13.TabIndex = 2040
        Me.Label13.Text = "Search By Product Name Press : F2"
        '
        'RdbAllBranch
        '
        Me.RdbAllBranch.AutoSize = True
        Me.RdbAllBranch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.RdbAllBranch.Location = New System.Drawing.Point(123, 87)
        Me.RdbAllBranch.Name = "RdbAllBranch"
        Me.RdbAllBranch.Size = New System.Drawing.Size(86, 20)
        Me.RdbAllBranch.TabIndex = 2044
        Me.RdbAllBranch.TabStop = True
        Me.RdbAllBranch.Text = "All Branch"
        Me.RdbAllBranch.UseVisualStyleBackColor = True
        '
        'RdbCurrentBranch
        '
        Me.RdbCurrentBranch.AutoSize = True
        Me.RdbCurrentBranch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.RdbCurrentBranch.Location = New System.Drawing.Point(4, 85)
        Me.RdbCurrentBranch.Name = "RdbCurrentBranch"
        Me.RdbCurrentBranch.Size = New System.Drawing.Size(113, 20)
        Me.RdbCurrentBranch.TabIndex = 2043
        Me.RdbCurrentBranch.TabStop = True
        Me.RdbCurrentBranch.Text = "Current Branch"
        Me.RdbCurrentBranch.UseVisualStyleBackColor = True
        '
        'GrdStockInformation
        '
        Me.GrdStockInformation.AllowUserToAddRows = False
        Me.GrdStockInformation.AllowUserToDeleteRows = False
        Me.GrdStockInformation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdStockInformation.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GrdStockInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdStockInformation.Location = New System.Drawing.Point(4, 195)
        Me.GrdStockInformation.Name = "GrdStockInformation"
        Me.GrdStockInformation.ReadOnly = True
        Me.GrdStockInformation.Size = New System.Drawing.Size(1224, 324)
        Me.GrdStockInformation.TabIndex = 2045
        '
        'FrmListOfProductStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1240, 541)
        Me.Controls.Add(Me.GrdStockInformation)
        Me.Controls.Add(Me.RdbAllBranch)
        Me.Controls.Add(Me.RdbCurrentBranch)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.LblSearchProductSubcategory)
        Me.Controls.Add(Me.LblSearchProductCategory)
        Me.Controls.Add(Me.LblSearchProductGroup)
        Me.Controls.Add(Me.CmbSearchProductSubcategory)
        Me.Controls.Add(Me.CmbSearchProductCategory)
        Me.Controls.Add(Me.CmbSearchProductGroup)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PnlListofProducts)
        Me.Controls.Add(Me.LblSearchProduct)
        Me.Controls.Add(Me.TxtsearchProduct)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "FrmListOfProductStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Stock"
        Me.PnlListofProducts.ResumeLayout(False)
        Me.PnlListofProducts.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.GrdStockInformation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtsearchProduct As System.Windows.Forms.TextBox
    Friend WithEvents LblSearchProduct As System.Windows.Forms.Label
    Friend WithEvents LblListofProductsStock As System.Windows.Forms.Label
    Friend WithEvents PnlListofProducts As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbSearchProductSubcategory As System.Windows.Forms.ComboBox
    Friend WithEvents CmbSearchProductCategory As System.Windows.Forms.ComboBox
    Friend WithEvents CmbSearchProductGroup As System.Windows.Forms.ComboBox
    Friend WithEvents LblSearchProductGroup As System.Windows.Forms.Label
    Friend WithEvents LblSearchProductCategory As System.Windows.Forms.Label
    Friend WithEvents LblSearchProductSubcategory As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents RdbAllBranch As System.Windows.Forms.RadioButton
    Friend WithEvents RdbCurrentBranch As System.Windows.Forms.RadioButton
    Friend WithEvents GrdStockInformation As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
End Class
