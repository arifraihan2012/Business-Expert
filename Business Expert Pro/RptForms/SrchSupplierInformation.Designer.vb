<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SrchSupplierInformation
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
        Me.GrpSearchSupplierInformation = New System.Windows.Forms.GroupBox
        Me.DtpTo = New System.Windows.Forms.DateTimePicker
        Me.LblTo = New System.Windows.Forms.Label
        Me.DtpFrom = New System.Windows.Forms.DateTimePicker
        Me.CmbSearchBy = New System.Windows.Forms.ComboBox
        Me.TxtSearch = New System.Windows.Forms.TextBox
        Me.LblFrom = New System.Windows.Forms.Label
        Me.LblSearch = New System.Windows.Forms.Label
        Me.LblSearchBy = New System.Windows.Forms.Label
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.GrpSearchSupplierInformation.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpSearchSupplierInformation
        '
        Me.GrpSearchSupplierInformation.Controls.Add(Me.DtpTo)
        Me.GrpSearchSupplierInformation.Controls.Add(Me.LblTo)
        Me.GrpSearchSupplierInformation.Controls.Add(Me.DtpFrom)
        Me.GrpSearchSupplierInformation.Controls.Add(Me.CmbSearchBy)
        Me.GrpSearchSupplierInformation.Controls.Add(Me.TxtSearch)
        Me.GrpSearchSupplierInformation.Controls.Add(Me.LblFrom)
        Me.GrpSearchSupplierInformation.Controls.Add(Me.LblSearch)
        Me.GrpSearchSupplierInformation.Controls.Add(Me.LblSearchBy)
        Me.GrpSearchSupplierInformation.Location = New System.Drawing.Point(19, 12)
        Me.GrpSearchSupplierInformation.Name = "GrpSearchSupplierInformation"
        Me.GrpSearchSupplierInformation.Size = New System.Drawing.Size(330, 116)
        Me.GrpSearchSupplierInformation.TabIndex = 105
        Me.GrpSearchSupplierInformation.TabStop = False
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
        'LblTo
        '
        Me.LblTo.AutoSize = True
        Me.LblTo.Location = New System.Drawing.Point(190, 86)
        Me.LblTo.Name = "LblTo"
        Me.LblTo.Size = New System.Drawing.Size(23, 13)
        Me.LblTo.TabIndex = 6
        Me.LblTo.Text = "To:"
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
        'CmbSearchBy
        '
        Me.CmbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSearchBy.FormattingEnabled = True
        Me.CmbSearchBy.Items.AddRange(New Object() {"Supplier ID ", "Supplier Name", "Company Name", "Date"})
        Me.CmbSearchBy.Location = New System.Drawing.Point(75, 15)
        Me.CmbSearchBy.Name = "CmbSearchBy"
        Me.CmbSearchBy.Size = New System.Drawing.Size(121, 21)
        Me.CmbSearchBy.TabIndex = 100
        '
        'TxtSearch
        '
        Me.TxtSearch.Location = New System.Drawing.Point(75, 48)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(100, 20)
        Me.TxtSearch.TabIndex = 101
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
        'LblSearch
        '
        Me.LblSearch.AutoSize = True
        Me.LblSearch.Location = New System.Drawing.Point(10, 51)
        Me.LblSearch.Name = "LblSearch"
        Me.LblSearch.Size = New System.Drawing.Size(44, 13)
        Me.LblSearch.TabIndex = 1
        Me.LblSearch.Text = "Search:"
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
        'BtnSearch
        '
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Location = New System.Drawing.Point(159, 137)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(75, 23)
        Me.BtnSearch.TabIndex = 104
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'SrchSupplierInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(368, 169)
        Me.Controls.Add(Me.GrpSearchSupplierInformation)
        Me.Controls.Add(Me.BtnSearch)
        Me.MaximizeBox = False
        Me.Name = "SrchSupplierInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Supplier Information"
        Me.GrpSearchSupplierInformation.ResumeLayout(False)
        Me.GrpSearchSupplierInformation.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpSearchSupplierInformation As System.Windows.Forms.GroupBox
    Friend WithEvents DtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblTo As System.Windows.Forms.Label
    Friend WithEvents DtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmbSearchBy As System.Windows.Forms.ComboBox
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents LblFrom As System.Windows.Forms.Label
    Friend WithEvents LblSearch As System.Windows.Forms.Label
    Friend WithEvents LblSearchBy As System.Windows.Forms.Label
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
End Class
