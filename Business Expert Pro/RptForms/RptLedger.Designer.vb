<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RptLedger
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.CmbChartOfAccount = New System.Windows.Forms.ComboBox
        Me.LblChartOfAccount = New System.Windows.Forms.Label
        Me.BtnShow = New System.Windows.Forms.Button
        Me.DtpFromDate = New System.Windows.Forms.DateTimePicker
        Me.DtpToDate = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmbBranchID = New System.Windows.Forms.ComboBox
        Me.CmbSelectSearchType = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 122)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(849, 253)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'CmbChartOfAccount
        '
        Me.CmbChartOfAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbChartOfAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbChartOfAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbChartOfAccount.FormattingEnabled = True
        Me.CmbChartOfAccount.Location = New System.Drawing.Point(351, 26)
        Me.CmbChartOfAccount.Name = "CmbChartOfAccount"
        Me.CmbChartOfAccount.Size = New System.Drawing.Size(402, 24)
        Me.CmbChartOfAccount.TabIndex = 104
        '
        'LblChartOfAccount
        '
        Me.LblChartOfAccount.AutoSize = True
        Me.LblChartOfAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblChartOfAccount.Location = New System.Drawing.Point(512, 10)
        Me.LblChartOfAccount.Name = "LblChartOfAccount"
        Me.LblChartOfAccount.Size = New System.Drawing.Size(81, 13)
        Me.LblChartOfAccount.TabIndex = 103
        Me.LblChartOfAccount.Text = "Account Name:"
        '
        'BtnShow
        '
        Me.BtnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnShow.Location = New System.Drawing.Point(589, 72)
        Me.BtnShow.Name = "BtnShow"
        Me.BtnShow.Size = New System.Drawing.Size(164, 23)
        Me.BtnShow.TabIndex = 105
        Me.BtnShow.Text = "Show"
        Me.BtnShow.UseVisualStyleBackColor = True
        '
        'DtpFromDate
        '
        Me.DtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFromDate.Location = New System.Drawing.Point(351, 72)
        Me.DtpFromDate.Name = "DtpFromDate"
        Me.DtpFromDate.Size = New System.Drawing.Size(117, 20)
        Me.DtpFromDate.TabIndex = 106
        Me.DtpFromDate.Value = New Date(2017, 1, 1, 0, 0, 0, 0)
        '
        'DtpToDate
        '
        Me.DtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpToDate.Location = New System.Drawing.Point(474, 72)
        Me.DtpToDate.Name = "DtpToDate"
        Me.DtpToDate.Size = New System.Drawing.Size(109, 20)
        Me.DtpToDate.TabIndex = 107
        Me.DtpToDate.Value = New Date(2018, 2, 25, 0, 0, 0, 0)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CmbBranchID)
        Me.GroupBox1.Controls.Add(Me.CmbSelectSearchType)
        Me.GroupBox1.Controls.Add(Me.DtpToDate)
        Me.GroupBox1.Controls.Add(Me.DtpFromDate)
        Me.GroupBox1.Controls.Add(Me.BtnShow)
        Me.GroupBox1.Controls.Add(Me.CmbChartOfAccount)
        Me.GroupBox1.Controls.Add(Me.LblChartOfAccount)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 109)
        Me.GroupBox1.TabIndex = 108
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Location = New System.Drawing.Point(137, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "Select Branch:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Location = New System.Drawing.Point(123, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 110
        Me.Label1.Text = "Select Search Type:"
        '
        'CmbBranchID
        '
        Me.CmbBranchID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbBranchID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbBranchID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBranchID.FormattingEnabled = True
        Me.CmbBranchID.Location = New System.Drawing.Point(6, 71)
        Me.CmbBranchID.Name = "CmbBranchID"
        Me.CmbBranchID.Size = New System.Drawing.Size(339, 24)
        Me.CmbBranchID.TabIndex = 109
        '
        'CmbSelectSearchType
        '
        Me.CmbSelectSearchType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbSelectSearchType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbSelectSearchType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSelectSearchType.FormattingEnabled = True
        Me.CmbSelectSearchType.Items.AddRange(New Object() {"Current Branch Ledger Report", "All Branch Ledger Report"})
        Me.CmbSelectSearchType.Location = New System.Drawing.Point(6, 26)
        Me.CmbSelectSearchType.Name = "CmbSelectSearchType"
        Me.CmbSelectSearchType.Size = New System.Drawing.Size(339, 24)
        Me.CmbSelectSearchType.TabIndex = 108
        '
        'RptLedger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(861, 387)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "RptLedger"
        Me.Text = "Ledger Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CmbChartOfAccount As System.Windows.Forms.ComboBox
    Friend WithEvents LblChartOfAccount As System.Windows.Forms.Label
    Friend WithEvents BtnShow As System.Windows.Forms.Button
    Friend WithEvents DtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbBranchID As System.Windows.Forms.ComboBox
    Friend WithEvents CmbSelectSearchType As System.Windows.Forms.ComboBox
End Class
