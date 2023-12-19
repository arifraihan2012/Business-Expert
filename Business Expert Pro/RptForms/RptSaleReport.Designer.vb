<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RptSaleReport
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
        Me.BtnSeach = New System.Windows.Forms.Button
        Me.LblFrom = New System.Windows.Forms.Label
        Me.DtpToDate = New System.Windows.Forms.DateTimePicker
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.DtpFromDate = New System.Windows.Forms.DateTimePicker
        Me.LblTo = New System.Windows.Forms.Label
        Me.CmbSelectSearchBy = New System.Windows.Forms.ComboBox
        Me.LblSearchBy = New System.Windows.Forms.Label
        Me.GrpSearchBy = New System.Windows.Forms.GroupBox
        Me.LblBranchName = New System.Windows.Forms.Label
        Me.CmbBranchName = New System.Windows.Forms.ComboBox
        Me.LblProductName = New System.Windows.Forms.Label
        Me.CmbProductName = New System.Windows.Forms.ComboBox
        Me.GrpSearchBy.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnSeach
        '
        Me.BtnSeach.BackColor = System.Drawing.Color.White
        Me.BtnSeach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSeach.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSeach.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSeach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSeach.Location = New System.Drawing.Point(376, 91)
        Me.BtnSeach.Name = "BtnSeach"
        Me.BtnSeach.Size = New System.Drawing.Size(97, 24)
        Me.BtnSeach.TabIndex = 2049
        Me.BtnSeach.Text = "Search"
        Me.BtnSeach.UseVisualStyleBackColor = False
        '
        'LblFrom
        '
        Me.LblFrom.AutoSize = True
        Me.LblFrom.Location = New System.Drawing.Point(14, 99)
        Me.LblFrom.Name = "LblFrom"
        Me.LblFrom.Size = New System.Drawing.Size(33, 13)
        Me.LblFrom.TabIndex = 2048
        Me.LblFrom.Text = "From:"
        '
        'DtpToDate
        '
        Me.DtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpToDate.Location = New System.Drawing.Point(253, 95)
        Me.DtpToDate.Name = "DtpToDate"
        Me.DtpToDate.Size = New System.Drawing.Size(98, 20)
        Me.DtpToDate.TabIndex = 2047
        Me.DtpToDate.Value = New Date(2017, 7, 28, 0, 0, 0, 0)
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(3, 143)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1001, 508)
        Me.CrystalReportViewer1.TabIndex = 2050
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'DtpFromDate
        '
        Me.DtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFromDate.Location = New System.Drawing.Point(94, 95)
        Me.DtpFromDate.Name = "DtpFromDate"
        Me.DtpFromDate.Size = New System.Drawing.Size(99, 20)
        Me.DtpFromDate.TabIndex = 2051
        Me.DtpFromDate.Value = New Date(2017, 7, 28, 0, 0, 0, 0)
        '
        'LblTo
        '
        Me.LblTo.AutoSize = True
        Me.LblTo.Location = New System.Drawing.Point(215, 99)
        Me.LblTo.Name = "LblTo"
        Me.LblTo.Size = New System.Drawing.Size(23, 13)
        Me.LblTo.TabIndex = 2052
        Me.LblTo.Text = "To:"
        '
        'CmbSelectSearchBy
        '
        Me.CmbSelectSearchBy.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbSelectSearchBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.CmbSelectSearchBy.FormattingEnabled = True
        Me.CmbSelectSearchBy.Items.AddRange(New Object() {"ALL PRODUCT", "INVOICE", "SINGLE PRODUCT", "CUSTOMER CATEGORY", "CUSTOMER NAME", "PRODUCT GROUP", "PRODUCT GROUP [DETAILS]", "USER ACCOUNT"})
        Me.CmbSelectSearchBy.Location = New System.Drawing.Point(94, 14)
        Me.CmbSelectSearchBy.Name = "CmbSelectSearchBy"
        Me.CmbSelectSearchBy.Size = New System.Drawing.Size(379, 23)
        Me.CmbSelectSearchBy.TabIndex = 2054
        '
        'LblSearchBy
        '
        Me.LblSearchBy.AutoSize = True
        Me.LblSearchBy.Location = New System.Drawing.Point(14, 19)
        Me.LblSearchBy.Name = "LblSearchBy"
        Me.LblSearchBy.Size = New System.Drawing.Size(59, 13)
        Me.LblSearchBy.TabIndex = 2053
        Me.LblSearchBy.Text = "Search By:"
        '
        'GrpSearchBy
        '
        Me.GrpSearchBy.Controls.Add(Me.LblBranchName)
        Me.GrpSearchBy.Controls.Add(Me.CmbBranchName)
        Me.GrpSearchBy.Controls.Add(Me.LblProductName)
        Me.GrpSearchBy.Controls.Add(Me.CmbProductName)
        Me.GrpSearchBy.Controls.Add(Me.CmbSelectSearchBy)
        Me.GrpSearchBy.Controls.Add(Me.LblSearchBy)
        Me.GrpSearchBy.Controls.Add(Me.BtnSeach)
        Me.GrpSearchBy.Controls.Add(Me.LblTo)
        Me.GrpSearchBy.Controls.Add(Me.DtpFromDate)
        Me.GrpSearchBy.Controls.Add(Me.LblFrom)
        Me.GrpSearchBy.Controls.Add(Me.DtpToDate)
        Me.GrpSearchBy.Location = New System.Drawing.Point(5, 4)
        Me.GrpSearchBy.Name = "GrpSearchBy"
        Me.GrpSearchBy.Size = New System.Drawing.Size(492, 133)
        Me.GrpSearchBy.TabIndex = 2055
        Me.GrpSearchBy.TabStop = False
        '
        'LblBranchName
        '
        Me.LblBranchName.AutoSize = True
        Me.LblBranchName.Location = New System.Drawing.Point(14, 67)
        Me.LblBranchName.Name = "LblBranchName"
        Me.LblBranchName.Size = New System.Drawing.Size(75, 13)
        Me.LblBranchName.TabIndex = 2058
        Me.LblBranchName.Text = "Branch Name:"
        Me.LblBranchName.Visible = False
        '
        'CmbBranchName
        '
        Me.CmbBranchName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbBranchName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbBranchName.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbBranchName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBranchName.FormattingEnabled = True
        Me.CmbBranchName.Location = New System.Drawing.Point(94, 62)
        Me.CmbBranchName.Name = "CmbBranchName"
        Me.CmbBranchName.Size = New System.Drawing.Size(379, 23)
        Me.CmbBranchName.TabIndex = 2057
        Me.CmbBranchName.Visible = False
        '
        'LblProductName
        '
        Me.LblProductName.AutoSize = True
        Me.LblProductName.Location = New System.Drawing.Point(14, 44)
        Me.LblProductName.Name = "LblProductName"
        Me.LblProductName.Size = New System.Drawing.Size(78, 13)
        Me.LblProductName.TabIndex = 2056
        Me.LblProductName.Text = "Product Name:"
        Me.LblProductName.Visible = False
        '
        'CmbProductName
        '
        Me.CmbProductName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbProductName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbProductName.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbProductName.FormattingEnabled = True
        Me.CmbProductName.Location = New System.Drawing.Point(94, 39)
        Me.CmbProductName.Name = "CmbProductName"
        Me.CmbProductName.Size = New System.Drawing.Size(379, 23)
        Me.CmbProductName.TabIndex = 2055
        Me.CmbProductName.Visible = False
        '
        'RptSaleReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 654)
        Me.Controls.Add(Me.GrpSearchBy)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "RptSaleReport"
        Me.Text = "Sale Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpSearchBy.ResumeLayout(False)
        Me.GrpSearchBy.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnSeach As System.Windows.Forms.Button
    Friend WithEvents LblFrom As System.Windows.Forms.Label
    Friend WithEvents DtpToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents DtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblTo As System.Windows.Forms.Label
    Friend WithEvents CmbSelectSearchBy As System.Windows.Forms.ComboBox
    Friend WithEvents LblSearchBy As System.Windows.Forms.Label
    Friend WithEvents GrpSearchBy As System.Windows.Forms.GroupBox
    Friend WithEvents LblProductName As System.Windows.Forms.Label
    Friend WithEvents CmbProductName As System.Windows.Forms.ComboBox
    Friend WithEvents LblBranchName As System.Windows.Forms.Label
    Friend WithEvents CmbBranchName As System.Windows.Forms.ComboBox
End Class
