<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmViewToDoList
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
        Me.GrpSearch = New System.Windows.Forms.GroupBox
        Me.DtpTodate = New System.Windows.Forms.DateTimePicker
        Me.LblToDate = New System.Windows.Forms.Label
        Me.DtpFromDate = New System.Windows.Forms.DateTimePicker
        Me.LblFromDate = New System.Windows.Forms.Label
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.LblSearchToDoList = New System.Windows.Forms.Label
        Me.LblIncompleteList = New System.Windows.Forms.Label
        Me.LblCompleteList = New System.Windows.Forms.Label
        Me.LblTotalIncompleteList = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.LblTotalCompleteList = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.GrdViewToDoListIncomplete = New System.Windows.Forms.DataGridView
        Me.GrdViewToDoListComplete = New System.Windows.Forms.DataGridView
        Me.GrpSearch.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GrdViewToDoListIncomplete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdViewToDoListComplete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpSearch
        '
        Me.GrpSearch.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GrpSearch.Controls.Add(Me.DtpTodate)
        Me.GrpSearch.Controls.Add(Me.LblToDate)
        Me.GrpSearch.Controls.Add(Me.DtpFromDate)
        Me.GrpSearch.Controls.Add(Me.LblFromDate)
        Me.GrpSearch.Controls.Add(Me.BtnSearch)
        Me.GrpSearch.Controls.Add(Me.LblSearchToDoList)
        Me.GrpSearch.Location = New System.Drawing.Point(266, 28)
        Me.GrpSearch.Name = "GrpSearch"
        Me.GrpSearch.Size = New System.Drawing.Size(477, 89)
        Me.GrpSearch.TabIndex = 1191
        Me.GrpSearch.TabStop = False
        '
        'DtpTodate
        '
        Me.DtpTodate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpTodate.Location = New System.Drawing.Point(250, 51)
        Me.DtpTodate.Name = "DtpTodate"
        Me.DtpTodate.Size = New System.Drawing.Size(107, 20)
        Me.DtpTodate.TabIndex = 1186
        Me.DtpTodate.Value = New Date(2018, 2, 11, 0, 0, 0, 0)
        '
        'LblToDate
        '
        Me.LblToDate.AutoSize = True
        Me.LblToDate.Location = New System.Drawing.Point(195, 51)
        Me.LblToDate.Name = "LblToDate"
        Me.LblToDate.Size = New System.Drawing.Size(49, 13)
        Me.LblToDate.TabIndex = 1187
        Me.LblToDate.Text = "To Date:"
        '
        'DtpFromDate
        '
        Me.DtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFromDate.Location = New System.Drawing.Point(67, 51)
        Me.DtpFromDate.Name = "DtpFromDate"
        Me.DtpFromDate.Size = New System.Drawing.Size(113, 20)
        Me.DtpFromDate.TabIndex = 1184
        Me.DtpFromDate.Value = New Date(2018, 2, 11, 0, 0, 0, 0)
        '
        'LblFromDate
        '
        Me.LblFromDate.AutoSize = True
        Me.LblFromDate.Location = New System.Drawing.Point(7, 51)
        Me.LblFromDate.Name = "LblFromDate"
        Me.LblFromDate.Size = New System.Drawing.Size(59, 13)
        Me.LblFromDate.TabIndex = 1185
        Me.LblFromDate.Text = "From Date:"
        '
        'BtnSearch
        '
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Location = New System.Drawing.Point(396, 51)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(75, 23)
        Me.BtnSearch.TabIndex = 1167
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'LblSearchToDoList
        '
        Me.LblSearchToDoList.AutoSize = True
        Me.LblSearchToDoList.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSearchToDoList.ForeColor = System.Drawing.Color.Navy
        Me.LblSearchToDoList.Location = New System.Drawing.Point(164, 16)
        Me.LblSearchToDoList.Name = "LblSearchToDoList"
        Me.LblSearchToDoList.Size = New System.Drawing.Size(149, 20)
        Me.LblSearchToDoList.TabIndex = 0
        Me.LblSearchToDoList.Text = "SEARCH TO DO LIST"
        '
        'LblIncompleteList
        '
        Me.LblIncompleteList.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblIncompleteList.AutoSize = True
        Me.LblIncompleteList.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIncompleteList.ForeColor = System.Drawing.Color.Red
        Me.LblIncompleteList.Location = New System.Drawing.Point(438, 123)
        Me.LblIncompleteList.Name = "LblIncompleteList"
        Me.LblIncompleteList.Size = New System.Drawing.Size(133, 20)
        Me.LblIncompleteList.TabIndex = 1192
        Me.LblIncompleteList.Text = "INCOMPLETE LIST"
        '
        'LblCompleteList
        '
        Me.LblCompleteList.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblCompleteList.AutoSize = True
        Me.LblCompleteList.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCompleteList.ForeColor = System.Drawing.Color.DarkBlue
        Me.LblCompleteList.Location = New System.Drawing.Point(445, 435)
        Me.LblCompleteList.Name = "LblCompleteList"
        Me.LblCompleteList.Size = New System.Drawing.Size(119, 20)
        Me.LblCompleteList.TabIndex = 1193
        Me.LblCompleteList.Text = "COMPLETE LIST"
        '
        'LblTotalIncompleteList
        '
        Me.LblTotalIncompleteList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTotalIncompleteList.AutoSize = True
        Me.LblTotalIncompleteList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalIncompleteList.Location = New System.Drawing.Point(795, 134)
        Me.LblTotalIncompleteList.Name = "LblTotalIncompleteList"
        Me.LblTotalIncompleteList.Size = New System.Drawing.Size(160, 16)
        Me.LblTotalIncompleteList.TabIndex = 1196
        Me.LblTotalIncompleteList.Text = "Total Incomplete List :"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(962, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 16)
        Me.Label7.TabIndex = 1195
        Me.Label7.Text = "00"
        '
        'LblTotalCompleteList
        '
        Me.LblTotalCompleteList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTotalCompleteList.AutoSize = True
        Me.LblTotalCompleteList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalCompleteList.Location = New System.Drawing.Point(805, 419)
        Me.LblTotalCompleteList.Name = "LblTotalCompleteList"
        Me.LblTotalCompleteList.Size = New System.Drawing.Size(150, 16)
        Me.LblTotalCompleteList.TabIndex = 1198
        Me.LblTotalCompleteList.Text = "Total Complete List :"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(960, 419)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 16)
        Me.Label2.TabIndex = 1197
        Me.Label2.Text = "00"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(12, 109)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 34)
        Me.Button1.TabIndex = 2045
        Me.Button1.Text = "Add Appointment"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Btnclose)
        Me.Panel2.Controls.Add(Me.Btnminimized)
        Me.Panel2.Controls.Add(Me.Btnmaximized)
        Me.Panel2.Location = New System.Drawing.Point(-1, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1009, 27)
        Me.Panel2.TabIndex = 2065
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(985, 0)
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
        Me.Btnminimized.Location = New System.Drawing.Point(925, 0)
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
        Me.Btnmaximized.Location = New System.Drawing.Point(955, 0)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1160
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'GrdViewToDoListIncomplete
        '
        Me.GrdViewToDoListIncomplete.AllowUserToAddRows = False
        Me.GrdViewToDoListIncomplete.AllowUserToDeleteRows = False
        Me.GrdViewToDoListIncomplete.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdViewToDoListIncomplete.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdViewToDoListIncomplete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdViewToDoListIncomplete.Location = New System.Drawing.Point(10, 162)
        Me.GrdViewToDoListIncomplete.Name = "GrdViewToDoListIncomplete"
        Me.GrdViewToDoListIncomplete.ReadOnly = True
        Me.GrdViewToDoListIncomplete.Size = New System.Drawing.Size(990, 246)
        Me.GrdViewToDoListIncomplete.TabIndex = 2066
        '
        'GrdViewToDoListComplete
        '
        Me.GrdViewToDoListComplete.AllowUserToAddRows = False
        Me.GrdViewToDoListComplete.AllowUserToDeleteRows = False
        Me.GrdViewToDoListComplete.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdViewToDoListComplete.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdViewToDoListComplete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdViewToDoListComplete.Location = New System.Drawing.Point(9, 472)
        Me.GrdViewToDoListComplete.Name = "GrdViewToDoListComplete"
        Me.GrdViewToDoListComplete.ReadOnly = True
        Me.GrdViewToDoListComplete.Size = New System.Drawing.Size(990, 246)
        Me.GrdViewToDoListComplete.TabIndex = 2067
        '
        'FrmViewToDoList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.GrdViewToDoListComplete)
        Me.Controls.Add(Me.GrdViewToDoListIncomplete)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LblTotalCompleteList)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblTotalIncompleteList)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LblCompleteList)
        Me.Controls.Add(Me.LblIncompleteList)
        Me.Controls.Add(Me.GrpSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmViewToDoList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View To Do List"
        Me.GrpSearch.ResumeLayout(False)
        Me.GrpSearch.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.GrdViewToDoListIncomplete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdViewToDoListComplete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpSearch As System.Windows.Forms.GroupBox
    Friend WithEvents DtpTodate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblToDate As System.Windows.Forms.Label
    Friend WithEvents DtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblFromDate As System.Windows.Forms.Label
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents LblSearchToDoList As System.Windows.Forms.Label
    Friend WithEvents LblIncompleteList As System.Windows.Forms.Label
    Friend WithEvents LblCompleteList As System.Windows.Forms.Label
    Friend WithEvents LblTotalIncompleteList As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LblTotalCompleteList As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
    Friend WithEvents GrdViewToDoListIncomplete As System.Windows.Forms.DataGridView
    Friend WithEvents GrdViewToDoListComplete As System.Windows.Forms.DataGridView
End Class
