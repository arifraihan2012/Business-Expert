<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStockInformation
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
        Me.LblStockID = New System.Windows.Forms.Label
        Me.LblProductID = New System.Windows.Forms.Label
        Me.LblBranchID = New System.Windows.Forms.Label
        Me.LblLocationID = New System.Windows.Forms.Label
        Me.CmbProductID = New System.Windows.Forms.ComboBox
        Me.CmbBranchID = New System.Windows.Forms.ComboBox
        Me.CmbLocationID = New System.Windows.Forms.ComboBox
        Me.TxtStockID = New System.Windows.Forms.TextBox
        Me.TxtQuantity = New System.Windows.Forms.TextBox
        Me.LblQuantity = New System.Windows.Forms.Label
        Me.PnlStockInformation = New System.Windows.Forms.Panel
        Me.LblStockInformation = New System.Windows.Forms.Label
        Me.GrpStockInformation = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GrdStockInformation = New System.Windows.Forms.DataGridView
        Me.BtnRefresh = New System.Windows.Forms.Button
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnAddNew = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.LblTotalQuantityTxt = New System.Windows.Forms.Label
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.CmbSearch = New System.Windows.Forms.ComboBox
        Me.TxtSearch = New System.Windows.Forms.TextBox
        Me.PnlStockInformation.SuspendLayout()
        Me.GrpStockInformation.SuspendLayout()
        CType(Me.GrdStockInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblStockID
        '
        Me.LblStockID.AutoSize = True
        Me.LblStockID.Location = New System.Drawing.Point(30, 34)
        Me.LblStockID.Name = "LblStockID"
        Me.LblStockID.Size = New System.Drawing.Size(52, 13)
        Me.LblStockID.TabIndex = 0
        Me.LblStockID.Text = "Stock ID:"
        '
        'LblProductID
        '
        Me.LblProductID.AutoSize = True
        Me.LblProductID.Location = New System.Drawing.Point(30, 60)
        Me.LblProductID.Name = "LblProductID"
        Me.LblProductID.Size = New System.Drawing.Size(61, 13)
        Me.LblProductID.TabIndex = 1
        Me.LblProductID.Text = "Product ID:"
        '
        'LblBranchID
        '
        Me.LblBranchID.AutoSize = True
        Me.LblBranchID.Location = New System.Drawing.Point(30, 86)
        Me.LblBranchID.Name = "LblBranchID"
        Me.LblBranchID.Size = New System.Drawing.Size(58, 13)
        Me.LblBranchID.TabIndex = 2
        Me.LblBranchID.Text = "Branch ID:"
        '
        'LblLocationID
        '
        Me.LblLocationID.AutoSize = True
        Me.LblLocationID.Location = New System.Drawing.Point(30, 112)
        Me.LblLocationID.Name = "LblLocationID"
        Me.LblLocationID.Size = New System.Drawing.Size(65, 13)
        Me.LblLocationID.TabIndex = 3
        Me.LblLocationID.Text = "Location ID:"
        '
        'CmbProductID
        '
        Me.CmbProductID.Enabled = False
        Me.CmbProductID.FormattingEnabled = True
        Me.CmbProductID.Location = New System.Drawing.Point(132, 54)
        Me.CmbProductID.Name = "CmbProductID"
        Me.CmbProductID.Size = New System.Drawing.Size(312, 21)
        Me.CmbProductID.TabIndex = 1068
        '
        'CmbBranchID
        '
        Me.CmbBranchID.FormattingEnabled = True
        Me.CmbBranchID.Location = New System.Drawing.Point(132, 82)
        Me.CmbBranchID.Name = "CmbBranchID"
        Me.CmbBranchID.Size = New System.Drawing.Size(312, 21)
        Me.CmbBranchID.TabIndex = 1069
        '
        'CmbLocationID
        '
        Me.CmbLocationID.FormattingEnabled = True
        Me.CmbLocationID.Location = New System.Drawing.Point(132, 110)
        Me.CmbLocationID.Name = "CmbLocationID"
        Me.CmbLocationID.Size = New System.Drawing.Size(312, 21)
        Me.CmbLocationID.TabIndex = 1070
        '
        'TxtStockID
        '
        Me.TxtStockID.Enabled = False
        Me.TxtStockID.Location = New System.Drawing.Point(132, 27)
        Me.TxtStockID.Name = "TxtStockID"
        Me.TxtStockID.Size = New System.Drawing.Size(90, 20)
        Me.TxtStockID.TabIndex = 1067
        '
        'TxtQuantity
        '
        Me.TxtQuantity.Location = New System.Drawing.Point(132, 138)
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.Size = New System.Drawing.Size(69, 20)
        Me.TxtQuantity.TabIndex = 1071
        '
        'LblQuantity
        '
        Me.LblQuantity.AutoSize = True
        Me.LblQuantity.Location = New System.Drawing.Point(30, 138)
        Me.LblQuantity.Name = "LblQuantity"
        Me.LblQuantity.Size = New System.Drawing.Size(49, 13)
        Me.LblQuantity.TabIndex = 13
        Me.LblQuantity.Text = "Quantity:"
        '
        'PnlStockInformation
        '
        Me.PnlStockInformation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlStockInformation.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PnlStockInformation.Controls.Add(Me.LblStockInformation)
        Me.PnlStockInformation.Location = New System.Drawing.Point(-2, -1)
        Me.PnlStockInformation.Name = "PnlStockInformation"
        Me.PnlStockInformation.Size = New System.Drawing.Size(829, 120)
        Me.PnlStockInformation.TabIndex = 16
        '
        'LblStockInformation
        '
        Me.LblStockInformation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblStockInformation.AutoSize = True
        Me.LblStockInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStockInformation.ForeColor = System.Drawing.Color.White
        Me.LblStockInformation.Location = New System.Drawing.Point(272, 42)
        Me.LblStockInformation.Name = "LblStockInformation"
        Me.LblStockInformation.Size = New System.Drawing.Size(284, 37)
        Me.LblStockInformation.TabIndex = 0
        Me.LblStockInformation.Text = "Stock Information"
        '
        'GrpStockInformation
        '
        Me.GrpStockInformation.Controls.Add(Me.Label4)
        Me.GrpStockInformation.Controls.Add(Me.Label3)
        Me.GrpStockInformation.Controls.Add(Me.Label2)
        Me.GrpStockInformation.Controls.Add(Me.LblQuantity)
        Me.GrpStockInformation.Controls.Add(Me.TxtQuantity)
        Me.GrpStockInformation.Controls.Add(Me.TxtStockID)
        Me.GrpStockInformation.Controls.Add(Me.CmbLocationID)
        Me.GrpStockInformation.Controls.Add(Me.CmbBranchID)
        Me.GrpStockInformation.Controls.Add(Me.CmbProductID)
        Me.GrpStockInformation.Controls.Add(Me.LblLocationID)
        Me.GrpStockInformation.Controls.Add(Me.LblBranchID)
        Me.GrpStockInformation.Controls.Add(Me.LblProductID)
        Me.GrpStockInformation.Controls.Add(Me.LblStockID)
        Me.GrpStockInformation.Location = New System.Drawing.Point(27, 241)
        Me.GrpStockInformation.Name = "GrpStockInformation"
        Me.GrpStockInformation.Size = New System.Drawing.Size(497, 169)
        Me.GrpStockInformation.TabIndex = 17
        Me.GrpStockInformation.TabStop = False
        Me.GrpStockInformation.Text = "Stock Information"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(450, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 1082
        Me.Label4.Text = "[F4]"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(450, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 1081
        Me.Label3.Text = "[F4]"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(450, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 1080
        Me.Label2.Text = "[F4]"
        '
        'GrdStockInformation
        '
        Me.GrdStockInformation.AllowUserToAddRows = False
        Me.GrdStockInformation.AllowUserToDeleteRows = False
        Me.GrdStockInformation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdStockInformation.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GrdStockInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdStockInformation.Location = New System.Drawing.Point(25, 425)
        Me.GrdStockInformation.Name = "GrdStockInformation"
        Me.GrdStockInformation.ReadOnly = True
        Me.GrdStockInformation.Size = New System.Drawing.Size(773, 197)
        Me.GrdStockInformation.TabIndex = 107
        '
        'BtnRefresh
        '
        Me.BtnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefresh.Image = Global.Business_Expert_Pro.My.Resources.Resources.icon_ios7_refresh_empty_128__1_1
        Me.BtnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRefresh.Location = New System.Drawing.Point(370, 167)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(94, 45)
        Me.BtnRefresh.TabIndex = 1077
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.Image = Global.Business_Expert_Pro.My.Resources.Resources.Save1
        Me.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdd.Location = New System.Drawing.Point(530, 347)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(92, 45)
        Me.BtnAdd.TabIndex = 1072
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Image = Global.Business_Expert_Pro.My.Resources.Resources.Edit1
        Me.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUpdate.Location = New System.Drawing.Point(134, 167)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(94, 45)
        Me.BtnUpdate.TabIndex = 1073
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Image = Global.Business_Expert_Pro.My.Resources.Resources.Delete3
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(246, 167)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(94, 45)
        Me.BtnDelete.TabIndex = 1075
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnAddNew
        '
        Me.BtnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddNew.Image = Global.Business_Expert_Pro.My.Resources.Resources.Add_New1
        Me.BtnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddNew.Location = New System.Drawing.Point(34, 167)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(94, 45)
        Me.BtnAddNew.TabIndex = 174
        Me.BtnAddNew.Text = "Add New"
        Me.BtnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Business_Expert_Pro.My.Resources.Resources.PC2_go_58_512
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(659, 230)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 136)
        Me.PictureBox1.TabIndex = 154
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(734, 403)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 15)
        Me.Label1.TabIndex = 1078
        Me.Label1.Text = "00"
        '
        'LblTotalQuantityTxt
        '
        Me.LblTotalQuantityTxt.AutoSize = True
        Me.LblTotalQuantityTxt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.LblTotalQuantityTxt.Location = New System.Drawing.Point(631, 403)
        Me.LblTotalQuantityTxt.Name = "LblTotalQuantityTxt"
        Me.LblTotalQuantityTxt.Size = New System.Drawing.Size(102, 15)
        Me.LblTotalQuantityTxt.TabIndex = 1079
        Me.LblTotalQuantityTxt.Text = "Total Quantity:"
        '
        'BtnSearch
        '
        Me.BtnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Image = Global.Business_Expert_Pro.My.Resources.Resources.Button_15_1282
        Me.BtnSearch.Location = New System.Drawing.Point(766, 126)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(19, 19)
        Me.BtnSearch.TabIndex = 2017
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'CmbSearch
        '
        Me.CmbSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbSearch.FormattingEnabled = True
        Me.CmbSearch.Items.AddRange(New Object() {"Barcode Serial", "Product Name", "Location"})
        Me.CmbSearch.Location = New System.Drawing.Point(526, 125)
        Me.CmbSearch.Name = "CmbSearch"
        Me.CmbSearch.Size = New System.Drawing.Size(127, 21)
        Me.CmbSearch.TabIndex = 2015
        '
        'TxtSearch
        '
        Me.TxtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSearch.Location = New System.Drawing.Point(659, 125)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(98, 20)
        Me.TxtSearch.TabIndex = 2016
        '
        'FrmStockInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(824, 631)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.CmbSearch)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.LblTotalQuantityTxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GrdStockInformation)
        Me.Controls.Add(Me.GrpStockInformation)
        Me.Controls.Add(Me.PnlStockInformation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmStockInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Information"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PnlStockInformation.ResumeLayout(False)
        Me.PnlStockInformation.PerformLayout()
        Me.GrpStockInformation.ResumeLayout(False)
        Me.GrpStockInformation.PerformLayout()
        CType(Me.GrdStockInformation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblStockID As System.Windows.Forms.Label
    Friend WithEvents LblProductID As System.Windows.Forms.Label
    Friend WithEvents LblBranchID As System.Windows.Forms.Label
    Friend WithEvents LblLocationID As System.Windows.Forms.Label
    Friend WithEvents CmbProductID As System.Windows.Forms.ComboBox
    Friend WithEvents CmbBranchID As System.Windows.Forms.ComboBox
    Friend WithEvents CmbLocationID As System.Windows.Forms.ComboBox
    Friend WithEvents TxtStockID As System.Windows.Forms.TextBox
    Friend WithEvents TxtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents LblQuantity As System.Windows.Forms.Label
    Friend WithEvents PnlStockInformation As System.Windows.Forms.Panel
    Friend WithEvents LblStockInformation As System.Windows.Forms.Label
    Friend WithEvents GrpStockInformation As System.Windows.Forms.GroupBox
    Friend WithEvents GrdStockInformation As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblTotalQuantityTxt As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents CmbSearch As System.Windows.Forms.ComboBox
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
End Class
