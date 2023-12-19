<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLocationInformation
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
        Me.PnlLocationDetails = New System.Windows.Forms.Panel
        Me.LblLocationInformation = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.LblLocationID = New System.Windows.Forms.Label
        Me.LblBranchID = New System.Windows.Forms.Label
        Me.LblLocationName = New System.Windows.Forms.Label
        Me.LblLocationDetails = New System.Windows.Forms.Label
        Me.TxtLocationDetails = New System.Windows.Forms.TextBox
        Me.TxtLocationName = New System.Windows.Forms.TextBox
        Me.TxtLocationID = New System.Windows.Forms.TextBox
        Me.CmbBranchID = New System.Windows.Forms.ComboBox
        Me.GrpLocationInfromation = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.BtnInsert = New System.Windows.Forms.Button
        Me.CmbSearch = New System.Windows.Forms.ComboBox
        Me.TxtSearch = New System.Windows.Forms.TextBox
        Me.BtnRefresh = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnAddNew = New System.Windows.Forms.Button
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.lblTotalLocation = New System.Windows.Forms.Label
        Me.lblTotalLocationLbl = New System.Windows.Forms.Label
        Me.CmbSearchBranch = New System.Windows.Forms.ComboBox
        Me.GrdLocationInformation = New System.Windows.Forms.DataGridView
        Me.PnlLocationDetails.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GrpLocationInfromation.SuspendLayout()
        CType(Me.GrdLocationInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlLocationDetails
        '
        Me.PnlLocationDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlLocationDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlLocationDetails.Controls.Add(Me.LblLocationInformation)
        Me.PnlLocationDetails.Controls.Add(Me.Panel1)
        Me.PnlLocationDetails.Location = New System.Drawing.Point(0, 0)
        Me.PnlLocationDetails.Name = "PnlLocationDetails"
        Me.PnlLocationDetails.Size = New System.Drawing.Size(820, 88)
        Me.PnlLocationDetails.TabIndex = 1
        '
        'LblLocationInformation
        '
        Me.LblLocationInformation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblLocationInformation.AutoSize = True
        Me.LblLocationInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLocationInformation.ForeColor = System.Drawing.Color.White
        Me.LblLocationInformation.Location = New System.Drawing.Point(260, 40)
        Me.LblLocationInformation.Name = "LblLocationInformation"
        Me.LblLocationInformation.Size = New System.Drawing.Size(329, 37)
        Me.LblLocationInformation.TabIndex = 1
        Me.LblLocationInformation.Text = "Location Information"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Btnclose)
        Me.Panel1.Controls.Add(Me.Btnminimized)
        Me.Panel1.Controls.Add(Me.Btnmaximized)
        Me.Panel1.Location = New System.Drawing.Point(1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(818, 34)
        Me.Panel1.TabIndex = 6
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(794, 5)
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
        Me.Btnminimized.Location = New System.Drawing.Point(734, 5)
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
        Me.Btnmaximized.Location = New System.Drawing.Point(764, 5)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1160
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'LblLocationID
        '
        Me.LblLocationID.AutoSize = True
        Me.LblLocationID.Location = New System.Drawing.Point(16, 20)
        Me.LblLocationID.Name = "LblLocationID"
        Me.LblLocationID.Size = New System.Drawing.Size(65, 13)
        Me.LblLocationID.TabIndex = 2
        Me.LblLocationID.Text = "Location ID:"
        '
        'LblBranchID
        '
        Me.LblBranchID.AutoSize = True
        Me.LblBranchID.Location = New System.Drawing.Point(16, 46)
        Me.LblBranchID.Name = "LblBranchID"
        Me.LblBranchID.Size = New System.Drawing.Size(58, 13)
        Me.LblBranchID.TabIndex = 3
        Me.LblBranchID.Text = "Branch ID:"
        '
        'LblLocationName
        '
        Me.LblLocationName.AutoSize = True
        Me.LblLocationName.Location = New System.Drawing.Point(16, 72)
        Me.LblLocationName.Name = "LblLocationName"
        Me.LblLocationName.Size = New System.Drawing.Size(82, 13)
        Me.LblLocationName.TabIndex = 4
        Me.LblLocationName.Text = "Location Name:"
        '
        'LblLocationDetails
        '
        Me.LblLocationDetails.AutoSize = True
        Me.LblLocationDetails.Location = New System.Drawing.Point(16, 98)
        Me.LblLocationDetails.Name = "LblLocationDetails"
        Me.LblLocationDetails.Size = New System.Drawing.Size(86, 13)
        Me.LblLocationDetails.TabIndex = 5
        Me.LblLocationDetails.Text = "Location Details:"
        '
        'TxtLocationDetails
        '
        Me.TxtLocationDetails.Location = New System.Drawing.Point(128, 96)
        Me.TxtLocationDetails.Name = "TxtLocationDetails"
        Me.TxtLocationDetails.Size = New System.Drawing.Size(266, 20)
        Me.TxtLocationDetails.TabIndex = 204
        '
        'TxtLocationName
        '
        Me.TxtLocationName.Location = New System.Drawing.Point(128, 71)
        Me.TxtLocationName.Name = "TxtLocationName"
        Me.TxtLocationName.Size = New System.Drawing.Size(266, 20)
        Me.TxtLocationName.TabIndex = 203
        '
        'TxtLocationID
        '
        Me.TxtLocationID.Enabled = False
        Me.TxtLocationID.Location = New System.Drawing.Point(128, 20)
        Me.TxtLocationID.Name = "TxtLocationID"
        Me.TxtLocationID.Size = New System.Drawing.Size(76, 20)
        Me.TxtLocationID.TabIndex = 201
        '
        'CmbBranchID
        '
        Me.CmbBranchID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbBranchID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbBranchID.FormattingEnabled = True
        Me.CmbBranchID.Location = New System.Drawing.Point(128, 45)
        Me.CmbBranchID.Name = "CmbBranchID"
        Me.CmbBranchID.Size = New System.Drawing.Size(266, 21)
        Me.CmbBranchID.TabIndex = 202
        '
        'GrpLocationInfromation
        '
        Me.GrpLocationInfromation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpLocationInfromation.Controls.Add(Me.Label6)
        Me.GrpLocationInfromation.Controls.Add(Me.CmbBranchID)
        Me.GrpLocationInfromation.Controls.Add(Me.TxtLocationDetails)
        Me.GrpLocationInfromation.Controls.Add(Me.TxtLocationName)
        Me.GrpLocationInfromation.Controls.Add(Me.BtnInsert)
        Me.GrpLocationInfromation.Controls.Add(Me.TxtLocationID)
        Me.GrpLocationInfromation.Controls.Add(Me.LblLocationDetails)
        Me.GrpLocationInfromation.Controls.Add(Me.LblLocationName)
        Me.GrpLocationInfromation.Controls.Add(Me.LblBranchID)
        Me.GrpLocationInfromation.Controls.Add(Me.LblLocationID)
        Me.GrpLocationInfromation.Location = New System.Drawing.Point(12, 166)
        Me.GrpLocationInfromation.Name = "GrpLocationInfromation"
        Me.GrpLocationInfromation.Size = New System.Drawing.Size(796, 133)
        Me.GrpLocationInfromation.TabIndex = 225
        Me.GrpLocationInfromation.TabStop = False
        Me.GrpLocationInfromation.Text = "Location Information"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(72, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 24)
        Me.Label6.TabIndex = 2030
        Me.Label6.Text = "*"
        '
        'BtnInsert
        '
        Me.BtnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInsert.Image = Global.Business_Expert_Pro.My.Resources.Resources.Save_32px_32
        Me.BtnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInsert.Location = New System.Drawing.Point(416, 77)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(89, 39)
        Me.BtnInsert.TabIndex = 1027
        Me.BtnInsert.Text = "Save"
        Me.BtnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnInsert.UseVisualStyleBackColor = True
        '
        'CmbSearch
        '
        Me.CmbSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbSearch.FormattingEnabled = True
        Me.CmbSearch.Items.AddRange(New Object() {"Location Name", "Branch Name"})
        Me.CmbSearch.Location = New System.Drawing.Point(504, 95)
        Me.CmbSearch.Name = "CmbSearch"
        Me.CmbSearch.Size = New System.Drawing.Size(129, 21)
        Me.CmbSearch.TabIndex = 1031
        '
        'TxtSearch
        '
        Me.TxtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSearch.Location = New System.Drawing.Point(639, 96)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(136, 20)
        Me.TxtSearch.TabIndex = 1032
        '
        'BtnRefresh
        '
        Me.BtnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefresh.Image = Global.Business_Expert_Pro.My.Resources.Resources.Reboot_32px1
        Me.BtnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRefresh.Location = New System.Drawing.Point(312, 118)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(89, 39)
        Me.BtnRefresh.TabIndex = 1034
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Image = Global.Business_Expert_Pro.My.Resources.Resources.Edit_File_32px3
        Me.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUpdate.Location = New System.Drawing.Point(112, 119)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(89, 39)
        Me.BtnUpdate.TabIndex = 1029
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Image = Global.Business_Expert_Pro.My.Resources.Resources.Delete_32px2
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(212, 119)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(89, 39)
        Me.BtnDelete.TabIndex = 1030
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnAddNew
        '
        Me.BtnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddNew.Image = Global.Business_Expert_Pro.My.Resources.Resources.Add_New2
        Me.BtnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddNew.Location = New System.Drawing.Point(12, 119)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(89, 39)
        Me.BtnAddNew.TabIndex = 1028
        Me.BtnAddNew.Text = "Add New"
        Me.BtnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'BtnSearch
        '
        Me.BtnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Image = Global.Business_Expert_Pro.My.Resources.Resources.Button_15_1282
        Me.BtnSearch.Location = New System.Drawing.Point(791, 96)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(20, 17)
        Me.BtnSearch.TabIndex = 1033
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'lblTotalLocation
        '
        Me.lblTotalLocation.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalLocation.AutoSize = True
        Me.lblTotalLocation.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTotalLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalLocation.Location = New System.Drawing.Point(740, 149)
        Me.lblTotalLocation.Name = "lblTotalLocation"
        Me.lblTotalLocation.Size = New System.Drawing.Size(21, 13)
        Me.lblTotalLocation.TabIndex = 2015
        Me.lblTotalLocation.Text = "00"
        '
        'lblTotalLocationLbl
        '
        Me.lblTotalLocationLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalLocationLbl.AutoSize = True
        Me.lblTotalLocationLbl.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTotalLocationLbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalLocationLbl.Location = New System.Drawing.Point(625, 148)
        Me.lblTotalLocationLbl.Name = "lblTotalLocationLbl"
        Me.lblTotalLocationLbl.Size = New System.Drawing.Size(104, 15)
        Me.lblTotalLocationLbl.TabIndex = 2014
        Me.lblTotalLocationLbl.Text = "Total Location:"
        '
        'CmbSearchBranch
        '
        Me.CmbSearchBranch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbSearchBranch.FormattingEnabled = True
        Me.CmbSearchBranch.Items.AddRange(New Object() {"Location Name", "Branch Name"})
        Me.CmbSearchBranch.Location = New System.Drawing.Point(639, 96)
        Me.CmbSearchBranch.Name = "CmbSearchBranch"
        Me.CmbSearchBranch.Size = New System.Drawing.Size(136, 21)
        Me.CmbSearchBranch.TabIndex = 2016
        Me.CmbSearchBranch.Visible = False
        '
        'GrdLocationInformation
        '
        Me.GrdLocationInformation.AllowUserToAddRows = False
        Me.GrdLocationInformation.AllowUserToDeleteRows = False
        Me.GrdLocationInformation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdLocationInformation.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GrdLocationInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdLocationInformation.Location = New System.Drawing.Point(12, 305)
        Me.GrdLocationInformation.Name = "GrdLocationInformation"
        Me.GrdLocationInformation.ReadOnly = True
        Me.GrdLocationInformation.Size = New System.Drawing.Size(796, 239)
        Me.GrdLocationInformation.TabIndex = 2017
        '
        'FrmLocationInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(820, 556)
        Me.Controls.Add(Me.GrdLocationInformation)
        Me.Controls.Add(Me.CmbSearchBranch)
        Me.Controls.Add(Me.lblTotalLocation)
        Me.Controls.Add(Me.lblTotalLocationLbl)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.CmbSearch)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.GrpLocationInfromation)
        Me.Controls.Add(Me.PnlLocationDetails)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmLocationInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Location Information"
        Me.PnlLocationDetails.ResumeLayout(False)
        Me.PnlLocationDetails.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GrpLocationInfromation.ResumeLayout(False)
        Me.GrpLocationInfromation.PerformLayout()
        CType(Me.GrdLocationInformation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PnlLocationDetails As System.Windows.Forms.Panel
    Friend WithEvents LblLocationInformation As System.Windows.Forms.Label
    Friend WithEvents LblLocationID As System.Windows.Forms.Label
    Friend WithEvents LblBranchID As System.Windows.Forms.Label
    Friend WithEvents LblLocationName As System.Windows.Forms.Label
    Friend WithEvents LblLocationDetails As System.Windows.Forms.Label
    Friend WithEvents TxtLocationDetails As System.Windows.Forms.TextBox
    Friend WithEvents TxtLocationName As System.Windows.Forms.TextBox
    Friend WithEvents TxtLocationID As System.Windows.Forms.TextBox
    Friend WithEvents CmbBranchID As System.Windows.Forms.ComboBox
    Friend WithEvents GrpLocationInfromation As System.Windows.Forms.GroupBox
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button
    Friend WithEvents BtnInsert As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents CmbSearch As System.Windows.Forms.ComboBox
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblTotalLocation As System.Windows.Forms.Label
    Friend WithEvents lblTotalLocationLbl As System.Windows.Forms.Label
    Friend WithEvents CmbSearchBranch As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
    Friend WithEvents GrdLocationInformation As System.Windows.Forms.DataGridView
End Class
