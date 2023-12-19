<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCheckProcessing
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
        Me.GrdWithheldChecks = New System.Windows.Forms.DataGridView
        Me.GrdHonoredChecks = New System.Windows.Forms.DataGridView
        Me.PnlBankReconcilation = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.LblBankReconcilation = New System.Windows.Forms.Label
        Me.BtnHonored = New System.Windows.Forms.Button
        Me.LblWithheldChecks = New System.Windows.Forms.Label
        Me.LblHonoredChecks = New System.Windows.Forms.Label
        Me.BtnWithHeld = New System.Windows.Forms.Button
        Me.LblInvoiceNo = New System.Windows.Forms.Label
        Me.LblCategory = New System.Windows.Forms.Label
        Me.BtnRefresh = New System.Windows.Forms.Button
        CType(Me.GrdWithheldChecks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdHonoredChecks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlBankReconcilation.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrdWithheldChecks
        '
        Me.GrdWithheldChecks.AllowUserToAddRows = False
        Me.GrdWithheldChecks.AllowUserToDeleteRows = False
        Me.GrdWithheldChecks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdWithheldChecks.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GrdWithheldChecks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdWithheldChecks.Location = New System.Drawing.Point(12, 149)
        Me.GrdWithheldChecks.Name = "GrdWithheldChecks"
        Me.GrdWithheldChecks.ReadOnly = True
        Me.GrdWithheldChecks.Size = New System.Drawing.Size(1016, 152)
        Me.GrdWithheldChecks.TabIndex = 0
        '
        'GrdHonoredChecks
        '
        Me.GrdHonoredChecks.AllowUserToAddRows = False
        Me.GrdHonoredChecks.AllowUserToDeleteRows = False
        Me.GrdHonoredChecks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdHonoredChecks.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GrdHonoredChecks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdHonoredChecks.Location = New System.Drawing.Point(12, 348)
        Me.GrdHonoredChecks.Name = "GrdHonoredChecks"
        Me.GrdHonoredChecks.ReadOnly = True
        Me.GrdHonoredChecks.Size = New System.Drawing.Size(1016, 152)
        Me.GrdHonoredChecks.TabIndex = 2
        '
        'PnlBankReconcilation
        '
        Me.PnlBankReconcilation.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlBankReconcilation.Controls.Add(Me.Panel2)
        Me.PnlBankReconcilation.Controls.Add(Me.LblBankReconcilation)
        Me.PnlBankReconcilation.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlBankReconcilation.Location = New System.Drawing.Point(0, 0)
        Me.PnlBankReconcilation.Name = "PnlBankReconcilation"
        Me.PnlBankReconcilation.Size = New System.Drawing.Size(1047, 100)
        Me.PnlBankReconcilation.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Btnclose)
        Me.Panel2.Controls.Add(Me.Btnminimized)
        Me.Panel2.Controls.Add(Me.Btnmaximized)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1047, 27)
        Me.Panel2.TabIndex = 2063
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(1023, 0)
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
        Me.Btnminimized.Location = New System.Drawing.Point(963, 0)
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
        Me.Btnmaximized.Location = New System.Drawing.Point(993, 0)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1160
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'LblBankReconcilation
        '
        Me.LblBankReconcilation.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblBankReconcilation.AutoSize = True
        Me.LblBankReconcilation.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBankReconcilation.ForeColor = System.Drawing.Color.White
        Me.LblBankReconcilation.Location = New System.Drawing.Point(384, 63)
        Me.LblBankReconcilation.Name = "LblBankReconcilation"
        Me.LblBankReconcilation.Size = New System.Drawing.Size(290, 37)
        Me.LblBankReconcilation.TabIndex = 7
        Me.LblBankReconcilation.Text = "Check Processing"
        '
        'BtnHonored
        '
        Me.BtnHonored.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnHonored.BackColor = System.Drawing.Color.White
        Me.BtnHonored.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHonored.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHonored.ForeColor = System.Drawing.Color.Black
        Me.BtnHonored.Location = New System.Drawing.Point(899, 106)
        Me.BtnHonored.Name = "BtnHonored"
        Me.BtnHonored.Size = New System.Drawing.Size(129, 35)
        Me.BtnHonored.TabIndex = 4
        Me.BtnHonored.Text = "Make It Honored"
        Me.BtnHonored.UseVisualStyleBackColor = False
        '
        'LblWithheldChecks
        '
        Me.LblWithheldChecks.AutoSize = True
        Me.LblWithheldChecks.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWithheldChecks.ForeColor = System.Drawing.Color.Black
        Me.LblWithheldChecks.Location = New System.Drawing.Point(11, 127)
        Me.LblWithheldChecks.Name = "LblWithheldChecks"
        Me.LblWithheldChecks.Size = New System.Drawing.Size(108, 14)
        Me.LblWithheldChecks.TabIndex = 8
        Me.LblWithheldChecks.Text = "Withheld Checks"
        '
        'LblHonoredChecks
        '
        Me.LblHonoredChecks.AutoSize = True
        Me.LblHonoredChecks.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHonoredChecks.ForeColor = System.Drawing.Color.Black
        Me.LblHonoredChecks.Location = New System.Drawing.Point(11, 321)
        Me.LblHonoredChecks.Name = "LblHonoredChecks"
        Me.LblHonoredChecks.Size = New System.Drawing.Size(106, 14)
        Me.LblHonoredChecks.TabIndex = 9
        Me.LblHonoredChecks.Text = "Honored Checks"
        '
        'BtnWithHeld
        '
        Me.BtnWithHeld.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnWithHeld.BackColor = System.Drawing.Color.White
        Me.BtnWithHeld.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnWithHeld.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnWithHeld.ForeColor = System.Drawing.Color.Black
        Me.BtnWithHeld.Location = New System.Drawing.Point(899, 307)
        Me.BtnWithHeld.Name = "BtnWithHeld"
        Me.BtnWithHeld.Size = New System.Drawing.Size(129, 35)
        Me.BtnWithHeld.TabIndex = 11
        Me.BtnWithHeld.Text = "Make It Withheld"
        Me.BtnWithHeld.UseVisualStyleBackColor = False
        '
        'LblInvoiceNo
        '
        Me.LblInvoiceNo.AutoSize = True
        Me.LblInvoiceNo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvoiceNo.ForeColor = System.Drawing.Color.Black
        Me.LblInvoiceNo.Location = New System.Drawing.Point(183, 127)
        Me.LblInvoiceNo.Name = "LblInvoiceNo"
        Me.LblInvoiceNo.Size = New System.Drawing.Size(15, 14)
        Me.LblInvoiceNo.TabIndex = 15
        Me.LblInvoiceNo.Text = ".."
        '
        'LblCategory
        '
        Me.LblCategory.AutoSize = True
        Me.LblCategory.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCategory.ForeColor = System.Drawing.Color.Black
        Me.LblCategory.Location = New System.Drawing.Point(315, 127)
        Me.LblCategory.Name = "LblCategory"
        Me.LblCategory.Size = New System.Drawing.Size(15, 14)
        Me.LblCategory.TabIndex = 16
        Me.LblCategory.Text = ".."
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRefresh.BackColor = System.Drawing.Color.White
        Me.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefresh.ForeColor = System.Drawing.Color.Black
        Me.BtnRefresh.Location = New System.Drawing.Point(764, 106)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(129, 35)
        Me.BtnRefresh.TabIndex = 17
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.UseVisualStyleBackColor = False
        '
        'FrmCheckProcessing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1047, 529)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.LblCategory)
        Me.Controls.Add(Me.LblInvoiceNo)
        Me.Controls.Add(Me.BtnWithHeld)
        Me.Controls.Add(Me.LblHonoredChecks)
        Me.Controls.Add(Me.LblWithheldChecks)
        Me.Controls.Add(Me.BtnHonored)
        Me.Controls.Add(Me.PnlBankReconcilation)
        Me.Controls.Add(Me.GrdHonoredChecks)
        Me.Controls.Add(Me.GrdWithheldChecks)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "FrmCheckProcessing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Check Processing"
        CType(Me.GrdWithheldChecks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdHonoredChecks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlBankReconcilation.ResumeLayout(False)
        Me.PnlBankReconcilation.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrdWithheldChecks As System.Windows.Forms.DataGridView
    Friend WithEvents GrdHonoredChecks As System.Windows.Forms.DataGridView
    Friend WithEvents PnlBankReconcilation As System.Windows.Forms.Panel
    Friend WithEvents BtnHonored As System.Windows.Forms.Button
    Friend WithEvents LblBankReconcilation As System.Windows.Forms.Label
    Friend WithEvents LblWithheldChecks As System.Windows.Forms.Label
    Friend WithEvents LblHonoredChecks As System.Windows.Forms.Label
    Friend WithEvents BtnWithHeld As System.Windows.Forms.Button
    Friend WithEvents LblInvoiceNo As System.Windows.Forms.Label
    Friend WithEvents LblCategory As System.Windows.Forms.Label
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
End Class
