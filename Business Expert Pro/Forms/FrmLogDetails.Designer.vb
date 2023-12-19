<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogDetails
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
        Me.GrdLogDetails = New System.Windows.Forms.DataGridView
        Me.GrpLogDetails = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtLogDescription = New System.Windows.Forms.TextBox
        Me.LblLogDescription = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtLogCategory = New System.Windows.Forms.TextBox
        Me.LblLogCategory = New System.Windows.Forms.Label
        Me.TxtLogID = New System.Windows.Forms.TextBox
        Me.LblLogID = New System.Windows.Forms.Label
        Me.BtnRefrersh = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.PnlLogDetails = New System.Windows.Forms.Panel
        Me.LblLogDetails = New System.Windows.Forms.Label
        Me.BtnAddNew = New System.Windows.Forms.Button
        CType(Me.GrdLogDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpLogDetails.SuspendLayout()
        Me.PnlLogDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrdLogDetails
        '
        Me.GrdLogDetails.AllowUserToAddRows = False
        Me.GrdLogDetails.AllowUserToDeleteRows = False
        Me.GrdLogDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdLogDetails.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GrdLogDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdLogDetails.Location = New System.Drawing.Point(14, 306)
        Me.GrdLogDetails.Name = "GrdLogDetails"
        Me.GrdLogDetails.ReadOnly = True
        Me.GrdLogDetails.Size = New System.Drawing.Size(736, 302)
        Me.GrdLogDetails.TabIndex = 1098
        '
        'GrpLogDetails
        '
        Me.GrpLogDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpLogDetails.Controls.Add(Me.Label7)
        Me.GrpLogDetails.Controls.Add(Me.TxtLogDescription)
        Me.GrpLogDetails.Controls.Add(Me.LblLogDescription)
        Me.GrpLogDetails.Controls.Add(Me.Label1)
        Me.GrpLogDetails.Controls.Add(Me.TxtLogCategory)
        Me.GrpLogDetails.Controls.Add(Me.LblLogCategory)
        Me.GrpLogDetails.Controls.Add(Me.TxtLogID)
        Me.GrpLogDetails.Controls.Add(Me.LblLogID)
        Me.GrpLogDetails.Location = New System.Drawing.Point(14, 162)
        Me.GrpLogDetails.Name = "GrpLogDetails"
        Me.GrpLogDetails.Size = New System.Drawing.Size(736, 126)
        Me.GrpLogDetails.TabIndex = 1097
        Me.GrpLogDetails.TabStop = False
        Me.GrpLogDetails.Text = "Log Details"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label7.Location = New System.Drawing.Point(93, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 24)
        Me.Label7.TabIndex = 2021
        Me.Label7.Text = "*"
        '
        'TxtLogDescription
        '
        Me.TxtLogDescription.Location = New System.Drawing.Point(136, 83)
        Me.TxtLogDescription.Name = "TxtLogDescription"
        Me.TxtLogDescription.Size = New System.Drawing.Size(155, 20)
        Me.TxtLogDescription.TabIndex = 103
        '
        'LblLogDescription
        '
        Me.LblLogDescription.AutoSize = True
        Me.LblLogDescription.Location = New System.Drawing.Point(15, 81)
        Me.LblLogDescription.Name = "LblLogDescription"
        Me.LblLogDescription.Size = New System.Drawing.Size(84, 13)
        Me.LblLogDescription.TabIndex = 2020
        Me.LblLogDescription.Text = "Log Description:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(94, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 24)
        Me.Label1.TabIndex = 2017
        Me.Label1.Text = "*"
        '
        'TxtLogCategory
        '
        Me.TxtLogCategory.Location = New System.Drawing.Point(136, 55)
        Me.TxtLogCategory.Name = "TxtLogCategory"
        Me.TxtLogCategory.Size = New System.Drawing.Size(155, 20)
        Me.TxtLogCategory.TabIndex = 102
        '
        'LblLogCategory
        '
        Me.LblLogCategory.AutoSize = True
        Me.LblLogCategory.Location = New System.Drawing.Point(15, 54)
        Me.LblLogCategory.Name = "LblLogCategory"
        Me.LblLogCategory.Size = New System.Drawing.Size(73, 13)
        Me.LblLogCategory.TabIndex = 173
        Me.LblLogCategory.Text = "Log Category:"
        '
        'TxtLogID
        '
        Me.TxtLogID.Enabled = False
        Me.TxtLogID.Location = New System.Drawing.Point(136, 27)
        Me.TxtLogID.Name = "TxtLogID"
        Me.TxtLogID.Size = New System.Drawing.Size(67, 20)
        Me.TxtLogID.TabIndex = 101
        '
        'LblLogID
        '
        Me.LblLogID.AutoSize = True
        Me.LblLogID.Location = New System.Drawing.Point(15, 27)
        Me.LblLogID.Name = "LblLogID"
        Me.LblLogID.Size = New System.Drawing.Size(42, 13)
        Me.LblLogID.TabIndex = 171
        Me.LblLogID.Text = "Log ID:"
        '
        'BtnRefrersh
        '
        Me.BtnRefrersh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRefrersh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefrersh.Image = Global.Business_Expert_Pro.My.Resources.Resources.icon_ios7_refresh_empty_128__1_
        Me.BtnRefrersh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRefrersh.Location = New System.Drawing.Point(303, 103)
        Me.BtnRefrersh.Name = "BtnRefrersh"
        Me.BtnRefrersh.Size = New System.Drawing.Size(90, 39)
        Me.BtnRefrersh.TabIndex = 1096
        Me.BtnRefrersh.Text = "Refresh"
        Me.BtnRefrersh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRefrersh.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Image = Global.Business_Expert_Pro.My.Resources.Resources.Save1
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(447, 103)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(91, 39)
        Me.BtnSave.TabIndex = 1095
        Me.BtnSave.Text = "Save"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Image = Global.Business_Expert_Pro.My.Resources.Resources.Edit1
        Me.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUpdate.Location = New System.Drawing.Point(111, 103)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(90, 39)
        Me.BtnUpdate.TabIndex = 1094
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Image = Global.Business_Expert_Pro.My.Resources.Resources.Delete21
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(207, 103)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(90, 39)
        Me.BtnDelete.TabIndex = 1093
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'PnlLogDetails
        '
        Me.PnlLogDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlLogDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PnlLogDetails.Controls.Add(Me.LblLogDetails)
        Me.PnlLogDetails.Location = New System.Drawing.Point(2, 0)
        Me.PnlLogDetails.Name = "PnlLogDetails"
        Me.PnlLogDetails.Size = New System.Drawing.Size(758, 86)
        Me.PnlLogDetails.TabIndex = 1099
        '
        'LblLogDetails
        '
        Me.LblLogDetails.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblLogDetails.AutoSize = True
        Me.LblLogDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLogDetails.ForeColor = System.Drawing.Color.White
        Me.LblLogDetails.Location = New System.Drawing.Point(267, 25)
        Me.LblLogDetails.Name = "LblLogDetails"
        Me.LblLogDetails.Size = New System.Drawing.Size(188, 37)
        Me.LblLogDetails.TabIndex = 0
        Me.LblLogDetails.Text = "Log Details"
        '
        'BtnAddNew
        '
        Me.BtnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddNew.Image = Global.Business_Expert_Pro.My.Resources.Resources.Add_New1
        Me.BtnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddNew.Location = New System.Drawing.Point(14, 103)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(91, 39)
        Me.BtnAddNew.TabIndex = 1092
        Me.BtnAddNew.Text = "Add New"
        Me.BtnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'FrmLogDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(762, 620)
        Me.Controls.Add(Me.PnlLogDetails)
        Me.Controls.Add(Me.GrdLogDetails)
        Me.Controls.Add(Me.GrpLogDetails)
        Me.Controls.Add(Me.BtnRefrersh)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Name = "FrmLogDetails"
        Me.Text = "Log Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GrdLogDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpLogDetails.ResumeLayout(False)
        Me.GrpLogDetails.PerformLayout()
        Me.PnlLogDetails.ResumeLayout(False)
        Me.PnlLogDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrdLogDetails As System.Windows.Forms.DataGridView
    Friend WithEvents GrpLogDetails As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtLogCategory As System.Windows.Forms.TextBox
    Friend WithEvents LblLogCategory As System.Windows.Forms.Label
    Friend WithEvents TxtLogID As System.Windows.Forms.TextBox
    Friend WithEvents LblLogID As System.Windows.Forms.Label
    Friend WithEvents BtnRefrersh As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
    Friend WithEvents TxtLogDescription As System.Windows.Forms.TextBox
    Friend WithEvents LblLogDescription As System.Windows.Forms.Label
    Friend WithEvents PnlLogDetails As System.Windows.Forms.Panel
    Friend WithEvents LblLogDetails As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
