<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RptStockReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RptStockReport))
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DtpDate = New System.Windows.Forms.DateTimePicker
        Me.CmbBranchList = New System.Windows.Forms.ComboBox
        Me.CmbProductList = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.CmbSearchBy = New System.Windows.Forms.ComboBox
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
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(12, 85)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(804, 398)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DtpDate)
        Me.GroupBox1.Controls.Add(Me.CmbBranchList)
        Me.GroupBox1.Controls.Add(Me.CmbProductList)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.BtnSearch)
        Me.GroupBox1.Controls.Add(Me.CmbSearchBy)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(489, 71)
        Me.GroupBox1.TabIndex = 2042
        Me.GroupBox1.TabStop = False
        '
        'DtpDate
        '
        Me.DtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDate.Location = New System.Drawing.Point(358, 42)
        Me.DtpDate.Name = "DtpDate"
        Me.DtpDate.Size = New System.Drawing.Size(99, 20)
        Me.DtpDate.TabIndex = 2052
        Me.DtpDate.Value = New Date(2017, 7, 28, 0, 0, 0, 0)
        '
        'CmbBranchList
        '
        Me.CmbBranchList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbBranchList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbBranchList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.CmbBranchList.FormattingEnabled = True
        Me.CmbBranchList.Items.AddRange(New Object() {"Sale Invoice", "Only Sale", "Challan", "Headerless Sale Invoice", "Headerless Only Sale", "Headerless Challan"})
        Me.CmbBranchList.Location = New System.Drawing.Point(6, 42)
        Me.CmbBranchList.Name = "CmbBranchList"
        Me.CmbBranchList.Size = New System.Drawing.Size(346, 23)
        Me.CmbBranchList.TabIndex = 2075
        Me.CmbBranchList.Visible = False
        '
        'CmbProductList
        '
        Me.CmbProductList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbProductList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbProductList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.CmbProductList.FormattingEnabled = True
        Me.CmbProductList.Items.AddRange(New Object() {"Sale Invoice", "Only Sale", "Challan", "Headerless Sale Invoice", "Headerless Only Sale", "Headerless Challan"})
        Me.CmbProductList.Location = New System.Drawing.Point(6, 42)
        Me.CmbProductList.Name = "CmbProductList"
        Me.CmbProductList.Size = New System.Drawing.Size(346, 23)
        Me.CmbProductList.TabIndex = 2074
        Me.CmbProductList.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label4.Location = New System.Drawing.Point(6, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 16)
        Me.Label4.TabIndex = 2073
        Me.Label4.Text = "Search By:"
        '
        'BtnSearch
        '
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Image = CType(resources.GetObject("BtnSearch.Image"), System.Drawing.Image)
        Me.BtnSearch.Location = New System.Drawing.Point(385, 13)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(45, 21)
        Me.BtnSearch.TabIndex = 2040
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'CmbSearchBy
        '
        Me.CmbSearchBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbSearchBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbSearchBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.CmbSearchBy.FormattingEnabled = True
        Me.CmbSearchBy.Items.AddRange(New Object() {"All Branch Stock Report", "Selected Branch Stock Report", "Search Product", "Low Stock Report", "Stock Report Quantity"})
        Me.CmbSearchBy.Location = New System.Drawing.Point(85, 13)
        Me.CmbSearchBy.Name = "CmbSearchBy"
        Me.CmbSearchBy.Size = New System.Drawing.Size(267, 23)
        Me.CmbSearchBy.TabIndex = 2039
        '
        'RptStockReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(828, 495)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "RptStockReport"
        Me.Text = "Stock Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents CmbSearchBy As System.Windows.Forms.ComboBox
    Friend WithEvents CmbProductList As System.Windows.Forms.ComboBox
    Friend WithEvents CmbBranchList As System.Windows.Forms.ComboBox
    Friend WithEvents DtpDate As System.Windows.Forms.DateTimePicker
End Class
