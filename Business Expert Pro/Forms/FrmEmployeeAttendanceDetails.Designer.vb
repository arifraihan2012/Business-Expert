<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmployeeAttendanceDetails
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
        Me.TxtSearchEmployeeID = New System.Windows.Forms.TextBox
        Me.PnlEmployeeAttendanceDetails = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.LblEmployeeAttendanceDetails = New System.Windows.Forms.Label
        Me.LblSearchEmployeeID = New System.Windows.Forms.Label
        Me.GrdEmployeeAttendanceDetails = New System.Windows.Forms.DataGridView
        Me.PnlEmployeeAttendanceDetails.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GrdEmployeeAttendanceDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtSearchEmployeeID
        '
        Me.TxtSearchEmployeeID.Location = New System.Drawing.Point(260, 121)
        Me.TxtSearchEmployeeID.Name = "TxtSearchEmployeeID"
        Me.TxtSearchEmployeeID.Size = New System.Drawing.Size(309, 20)
        Me.TxtSearchEmployeeID.TabIndex = 102
        '
        'PnlEmployeeAttendanceDetails
        '
        Me.PnlEmployeeAttendanceDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlEmployeeAttendanceDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlEmployeeAttendanceDetails.Controls.Add(Me.Panel1)
        Me.PnlEmployeeAttendanceDetails.Controls.Add(Me.LblEmployeeAttendanceDetails)
        Me.PnlEmployeeAttendanceDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlEmployeeAttendanceDetails.Location = New System.Drawing.Point(1, 0)
        Me.PnlEmployeeAttendanceDetails.Name = "PnlEmployeeAttendanceDetails"
        Me.PnlEmployeeAttendanceDetails.Size = New System.Drawing.Size(737, 97)
        Me.PnlEmployeeAttendanceDetails.TabIndex = 1092
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Btnclose)
        Me.Panel1.Controls.Add(Me.Btnminimized)
        Me.Panel1.Controls.Add(Me.Btnmaximized)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(736, 30)
        Me.Panel1.TabIndex = 7
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(709, 0)
        Me.Btnclose.Name = "Btnclose"
        Me.Btnclose.Size = New System.Drawing.Size(24, 24)
        Me.Btnclose.TabIndex = 1159
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
        Me.Btnminimized.Location = New System.Drawing.Point(658, 0)
        Me.Btnminimized.Name = "Btnminimized"
        Me.Btnminimized.Size = New System.Drawing.Size(24, 24)
        Me.Btnminimized.TabIndex = 1158
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
        Me.Btnmaximized.Location = New System.Drawing.Point(683, 0)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1157
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'LblEmployeeAttendanceDetails
        '
        Me.LblEmployeeAttendanceDetails.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblEmployeeAttendanceDetails.AutoSize = True
        Me.LblEmployeeAttendanceDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmployeeAttendanceDetails.ForeColor = System.Drawing.Color.White
        Me.LblEmployeeAttendanceDetails.Location = New System.Drawing.Point(138, 43)
        Me.LblEmployeeAttendanceDetails.Name = "LblEmployeeAttendanceDetails"
        Me.LblEmployeeAttendanceDetails.Size = New System.Drawing.Size(461, 37)
        Me.LblEmployeeAttendanceDetails.TabIndex = 2
        Me.LblEmployeeAttendanceDetails.Text = "Employee Attendance Details"
        '
        'LblSearchEmployeeID
        '
        Me.LblSearchEmployeeID.AutoSize = True
        Me.LblSearchEmployeeID.Location = New System.Drawing.Point(92, 124)
        Me.LblSearchEmployeeID.Name = "LblSearchEmployeeID"
        Me.LblSearchEmployeeID.Size = New System.Drawing.Size(107, 13)
        Me.LblSearchEmployeeID.TabIndex = 101
        Me.LblSearchEmployeeID.Text = "Search Employee ID:"
        '
        'GrdEmployeeAttendanceDetails
        '
        Me.GrdEmployeeAttendanceDetails.AllowUserToAddRows = False
        Me.GrdEmployeeAttendanceDetails.AllowUserToDeleteRows = False
        Me.GrdEmployeeAttendanceDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdEmployeeAttendanceDetails.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdEmployeeAttendanceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdEmployeeAttendanceDetails.Location = New System.Drawing.Point(7, 164)
        Me.GrdEmployeeAttendanceDetails.Name = "GrdEmployeeAttendanceDetails"
        Me.GrdEmployeeAttendanceDetails.ReadOnly = True
        Me.GrdEmployeeAttendanceDetails.Size = New System.Drawing.Size(720, 331)
        Me.GrdEmployeeAttendanceDetails.TabIndex = 1093
        '
        'FrmEmployeeAttendanceDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(736, 505)
        Me.Controls.Add(Me.GrdEmployeeAttendanceDetails)
        Me.Controls.Add(Me.LblSearchEmployeeID)
        Me.Controls.Add(Me.TxtSearchEmployeeID)
        Me.Controls.Add(Me.PnlEmployeeAttendanceDetails)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmEmployeeAttendanceDetails"
        Me.Text = "Employee Attendance Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.PnlEmployeeAttendanceDetails.ResumeLayout(False)
        Me.PnlEmployeeAttendanceDetails.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.GrdEmployeeAttendanceDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtSearchEmployeeID As System.Windows.Forms.TextBox
    Friend WithEvents PnlEmployeeAttendanceDetails As System.Windows.Forms.Panel
    Friend WithEvents LblEmployeeAttendanceDetails As System.Windows.Forms.Label
    Friend WithEvents LblSearchEmployeeID As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
    Friend WithEvents GrdEmployeeAttendanceDetails As System.Windows.Forms.DataGridView
End Class
