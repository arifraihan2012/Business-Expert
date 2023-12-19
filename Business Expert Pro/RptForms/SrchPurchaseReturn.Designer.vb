<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SrchPurchaseReturn
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
        Me.LblSearchBy = New System.Windows.Forms.Label
        Me.LblSearch = New System.Windows.Forms.Label
        Me.LblFrom = New System.Windows.Forms.Label
        Me.TxtSearch = New System.Windows.Forms.TextBox
        Me.CmbSearchBy = New System.Windows.Forms.ComboBox
        Me.DtpFrom = New System.Windows.Forms.DateTimePicker
        Me.LblTo = New System.Windows.Forms.Label
        Me.DtpTo = New System.Windows.Forms.DateTimePicker
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.GrpSearchPurchaseReturn = New System.Windows.Forms.GroupBox
        Me.GrpSearchPurchaseReturn.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblSearchBy
        '
        Me.LblSearchBy.AutoSize = True
        Me.LblSearchBy.Location = New System.Drawing.Point(10, 18)
        Me.LblSearchBy.Name = "LblSearchBy"
        Me.LblSearchBy.Size = New System.Drawing.Size(59, 13)
        Me.LblSearchBy.TabIndex = 0
        Me.LblSearchBy.Text = "Search By:"
        '
        'LblSearch
        '
        Me.LblSearch.AutoSize = True
        Me.LblSearch.Location = New System.Drawing.Point(10, 51)
        Me.LblSearch.Name = "LblSearch"
        Me.LblSearch.Size = New System.Drawing.Size(44, 13)
        Me.LblSearch.TabIndex = 1
        Me.LblSearch.Text = "Search:"
        '
        'LblFrom
        '
        Me.LblFrom.AutoSize = True
        Me.LblFrom.Location = New System.Drawing.Point(10, 87)
        Me.LblFrom.Name = "LblFrom"
        Me.LblFrom.Size = New System.Drawing.Size(33, 13)
        Me.LblFrom.TabIndex = 2
        Me.LblFrom.Text = "From:"
        '
        'TxtSearch
        '
        Me.TxtSearch.Location = New System.Drawing.Point(75, 48)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(100, 20)
        Me.TxtSearch.TabIndex = 101
        '
        'CmbSearchBy
        '
        Me.CmbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSearchBy.FormattingEnabled = True
        Me.CmbSearchBy.Items.AddRange(New Object() {"Product ID", "Product Name", "Date", "Supplier ID", "Supplier Name"})
        Me.CmbSearchBy.Location = New System.Drawing.Point(75, 15)
        Me.CmbSearchBy.Name = "CmbSearchBy"
        Me.CmbSearchBy.Size = New System.Drawing.Size(121, 21)
        Me.CmbSearchBy.TabIndex = 100
        '
        'DtpFrom
        '
        Me.DtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFrom.Location = New System.Drawing.Point(75, 80)
        Me.DtpFrom.Name = "DtpFrom"
        Me.DtpFrom.Size = New System.Drawing.Size(100, 20)
        Me.DtpFrom.TabIndex = 102
        Me.DtpFrom.Value = New Date(2017, 1, 3, 0, 0, 0, 0)
        '
        'LblTo
        '
        Me.LblTo.AutoSize = True
        Me.LblTo.Location = New System.Drawing.Point(190, 86)
        Me.LblTo.Name = "LblTo"
        Me.LblTo.Size = New System.Drawing.Size(23, 13)
        Me.LblTo.TabIndex = 6
        Me.LblTo.Text = "To:"
        '
        'DtpTo
        '
        Me.DtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpTo.Location = New System.Drawing.Point(219, 80)
        Me.DtpTo.Name = "DtpTo"
        Me.DtpTo.Size = New System.Drawing.Size(95, 20)
        Me.DtpTo.TabIndex = 103
        Me.DtpTo.Value = New Date(2017, 1, 3, 0, 0, 0, 0)
        '
        'BtnSearch
        '
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Location = New System.Drawing.Point(155, 140)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(75, 23)
        Me.BtnSearch.TabIndex = 104
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'GrpSearchPurchaseReturn
        '
        Me.GrpSearchPurchaseReturn.Controls.Add(Me.DtpTo)
        Me.GrpSearchPurchaseReturn.Controls.Add(Me.LblTo)
        Me.GrpSearchPurchaseReturn.Controls.Add(Me.DtpFrom)
        Me.GrpSearchPurchaseReturn.Controls.Add(Me.CmbSearchBy)
        Me.GrpSearchPurchaseReturn.Controls.Add(Me.TxtSearch)
        Me.GrpSearchPurchaseReturn.Controls.Add(Me.LblFrom)
        Me.GrpSearchPurchaseReturn.Controls.Add(Me.LblSearch)
        Me.GrpSearchPurchaseReturn.Controls.Add(Me.LblSearchBy)
        Me.GrpSearchPurchaseReturn.Location = New System.Drawing.Point(22, 15)
        Me.GrpSearchPurchaseReturn.Name = "GrpSearchPurchaseReturn"
        Me.GrpSearchPurchaseReturn.Size = New System.Drawing.Size(330, 116)
        Me.GrpSearchPurchaseReturn.TabIndex = 9
        Me.GrpSearchPurchaseReturn.TabStop = False
        '
        'SrchPurchaseReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(374, 175)
        Me.Controls.Add(Me.GrpSearchPurchaseReturn)
        Me.Controls.Add(Me.BtnSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "SrchPurchaseReturn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Purchase Return"
        Me.GrpSearchPurchaseReturn.ResumeLayout(False)
        Me.GrpSearchPurchaseReturn.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblSearchBy As System.Windows.Forms.Label
    Friend WithEvents LblSearch As System.Windows.Forms.Label
    Friend WithEvents LblFrom As System.Windows.Forms.Label
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents CmbSearchBy As System.Windows.Forms.ComboBox
    Friend WithEvents DtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblTo As System.Windows.Forms.Label
    Friend WithEvents DtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents GrpSearchPurchaseReturn As System.Windows.Forms.GroupBox
End Class
