﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RptPurchaseReport
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
        Me.GrpSearchBy = New System.Windows.Forms.GroupBox
        Me.CmbSelectSearchBy = New System.Windows.Forms.ComboBox
        Me.LblSearchBy = New System.Windows.Forms.Label
        Me.BtnSeach = New System.Windows.Forms.Button
        Me.LblTo = New System.Windows.Forms.Label
        Me.DtpFromDate = New System.Windows.Forms.DateTimePicker
        Me.LblFrom = New System.Windows.Forms.Label
        Me.DtpToDate = New System.Windows.Forms.DateTimePicker
        Me.GrpSearchBy.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(3, 84)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(778, 397)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'GrpSearchBy
        '
        Me.GrpSearchBy.Controls.Add(Me.CmbSelectSearchBy)
        Me.GrpSearchBy.Controls.Add(Me.LblSearchBy)
        Me.GrpSearchBy.Controls.Add(Me.BtnSeach)
        Me.GrpSearchBy.Controls.Add(Me.LblTo)
        Me.GrpSearchBy.Controls.Add(Me.DtpFromDate)
        Me.GrpSearchBy.Controls.Add(Me.LblFrom)
        Me.GrpSearchBy.Controls.Add(Me.DtpToDate)
        Me.GrpSearchBy.Location = New System.Drawing.Point(3, 3)
        Me.GrpSearchBy.Name = "GrpSearchBy"
        Me.GrpSearchBy.Size = New System.Drawing.Size(492, 75)
        Me.GrpSearchBy.TabIndex = 2056
        Me.GrpSearchBy.TabStop = False
        '
        'CmbSelectSearchBy
        '
        Me.CmbSelectSearchBy.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmbSelectSearchBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.CmbSelectSearchBy.FormattingEnabled = True
        Me.CmbSelectSearchBy.Items.AddRange(New Object() {"INVOICE"})
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
        'BtnSeach
        '
        Me.BtnSeach.BackColor = System.Drawing.Color.White
        Me.BtnSeach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSeach.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSeach.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSeach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSeach.Location = New System.Drawing.Point(376, 43)
        Me.BtnSeach.Name = "BtnSeach"
        Me.BtnSeach.Size = New System.Drawing.Size(97, 24)
        Me.BtnSeach.TabIndex = 2049
        Me.BtnSeach.Text = "Search"
        Me.BtnSeach.UseVisualStyleBackColor = False
        '
        'LblTo
        '
        Me.LblTo.AutoSize = True
        Me.LblTo.Location = New System.Drawing.Point(215, 51)
        Me.LblTo.Name = "LblTo"
        Me.LblTo.Size = New System.Drawing.Size(23, 13)
        Me.LblTo.TabIndex = 2052
        Me.LblTo.Text = "To:"
        '
        'DtpFromDate
        '
        Me.DtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFromDate.Location = New System.Drawing.Point(94, 47)
        Me.DtpFromDate.Name = "DtpFromDate"
        Me.DtpFromDate.Size = New System.Drawing.Size(99, 20)
        Me.DtpFromDate.TabIndex = 2051
        Me.DtpFromDate.Value = New Date(2017, 7, 28, 0, 0, 0, 0)
        '
        'LblFrom
        '
        Me.LblFrom.AutoSize = True
        Me.LblFrom.Location = New System.Drawing.Point(14, 51)
        Me.LblFrom.Name = "LblFrom"
        Me.LblFrom.Size = New System.Drawing.Size(33, 13)
        Me.LblFrom.TabIndex = 2048
        Me.LblFrom.Text = "From:"
        '
        'DtpToDate
        '
        Me.DtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpToDate.Location = New System.Drawing.Point(253, 47)
        Me.DtpToDate.Name = "DtpToDate"
        Me.DtpToDate.Size = New System.Drawing.Size(98, 20)
        Me.DtpToDate.TabIndex = 2047
        Me.DtpToDate.Value = New Date(2017, 7, 28, 0, 0, 0, 0)
        '
        'RptPurchaseReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(781, 482)
        Me.Controls.Add(Me.GrpSearchBy)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "RptPurchaseReport"
        Me.Text = "RptPurchaseReport"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpSearchBy.ResumeLayout(False)
        Me.GrpSearchBy.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GrpSearchBy As System.Windows.Forms.GroupBox
    Friend WithEvents CmbSelectSearchBy As System.Windows.Forms.ComboBox
    Friend WithEvents LblSearchBy As System.Windows.Forms.Label
    Friend WithEvents BtnSeach As System.Windows.Forms.Button
    Friend WithEvents LblTo As System.Windows.Forms.Label
    Friend WithEvents DtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblFrom As System.Windows.Forms.Label
    Friend WithEvents DtpToDate As System.Windows.Forms.DateTimePicker
End Class
