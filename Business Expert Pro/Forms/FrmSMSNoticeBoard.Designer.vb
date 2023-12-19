<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSMSNoticeBoard
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
        Me.LblSMSNoticeBoard = New System.Windows.Forms.Label
        Me.PnlSMSNoticeBoard = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.TxtTeacherID = New System.Windows.Forms.TextBox
        Me.LblSMSID = New System.Windows.Forms.Label
        Me.lblSMSDescription = New System.Windows.Forms.Label
        Me.lblSMSGroup = New System.Windows.Forms.Label
        Me.CmbSMSGroup = New System.Windows.Forms.ComboBox
        Me.RtxtSMSDescription = New System.Windows.Forms.RichTextBox
        Me.BtnSend = New System.Windows.Forms.Button
        Me.BtnAddNew = New System.Windows.Forms.Button
        Me.GrdSMSNoticeBoard = New System.Windows.Forms.DataGridView
        Me.PnlSMSNoticeBoard.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GrdSMSNoticeBoard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblSMSNoticeBoard
        '
        Me.LblSMSNoticeBoard.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblSMSNoticeBoard.AutoSize = True
        Me.LblSMSNoticeBoard.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblSMSNoticeBoard.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSMSNoticeBoard.ForeColor = System.Drawing.Color.White
        Me.LblSMSNoticeBoard.Location = New System.Drawing.Point(337, 38)
        Me.LblSMSNoticeBoard.Name = "LblSMSNoticeBoard"
        Me.LblSMSNoticeBoard.Size = New System.Drawing.Size(296, 37)
        Me.LblSMSNoticeBoard.TabIndex = 0
        Me.LblSMSNoticeBoard.Text = "SMS Notice Board"
        '
        'PnlSMSNoticeBoard
        '
        Me.PnlSMSNoticeBoard.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlSMSNoticeBoard.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlSMSNoticeBoard.Controls.Add(Me.Panel2)
        Me.PnlSMSNoticeBoard.Controls.Add(Me.LblSMSNoticeBoard)
        Me.PnlSMSNoticeBoard.Cursor = System.Windows.Forms.Cursors.Default
        Me.PnlSMSNoticeBoard.Location = New System.Drawing.Point(1, 0)
        Me.PnlSMSNoticeBoard.Name = "PnlSMSNoticeBoard"
        Me.PnlSMSNoticeBoard.Size = New System.Drawing.Size(1023, 89)
        Me.PnlSMSNoticeBoard.TabIndex = 1108
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
        Me.Panel2.Size = New System.Drawing.Size(1022, 27)
        Me.Panel2.TabIndex = 2060
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(998, 0)
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
        Me.Btnminimized.Location = New System.Drawing.Point(938, 0)
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
        Me.Btnmaximized.Location = New System.Drawing.Point(968, 0)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1160
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'TxtTeacherID
        '
        Me.TxtTeacherID.Cursor = System.Windows.Forms.Cursors.Default
        Me.TxtTeacherID.Enabled = False
        Me.TxtTeacherID.Location = New System.Drawing.Point(150, 176)
        Me.TxtTeacherID.Name = "TxtTeacherID"
        Me.TxtTeacherID.Size = New System.Drawing.Size(147, 20)
        Me.TxtTeacherID.TabIndex = 1121
        '
        'LblSMSID
        '
        Me.LblSMSID.AutoSize = True
        Me.LblSMSID.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblSMSID.Location = New System.Drawing.Point(48, 180)
        Me.LblSMSID.Name = "LblSMSID"
        Me.LblSMSID.Size = New System.Drawing.Size(47, 13)
        Me.LblSMSID.TabIndex = 1120
        Me.LblSMSID.Text = "SMS ID:"
        '
        'lblSMSDescription
        '
        Me.lblSMSDescription.AutoSize = True
        Me.lblSMSDescription.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSMSDescription.Location = New System.Drawing.Point(48, 275)
        Me.lblSMSDescription.Name = "lblSMSDescription"
        Me.lblSMSDescription.Size = New System.Drawing.Size(89, 13)
        Me.lblSMSDescription.TabIndex = 1122
        Me.lblSMSDescription.Text = "SMS Description:"
        '
        'lblSMSGroup
        '
        Me.lblSMSGroup.AutoSize = True
        Me.lblSMSGroup.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSMSGroup.Location = New System.Drawing.Point(48, 207)
        Me.lblSMSGroup.Name = "lblSMSGroup"
        Me.lblSMSGroup.Size = New System.Drawing.Size(65, 13)
        Me.lblSMSGroup.TabIndex = 1124
        Me.lblSMSGroup.Text = "SMS Group:"
        '
        'CmbSMSGroup
        '
        Me.CmbSMSGroup.FormattingEnabled = True
        Me.CmbSMSGroup.Location = New System.Drawing.Point(150, 205)
        Me.CmbSMSGroup.Name = "CmbSMSGroup"
        Me.CmbSMSGroup.Size = New System.Drawing.Size(147, 21)
        Me.CmbSMSGroup.TabIndex = 1125
        '
        'RtxtSMSDescription
        '
        Me.RtxtSMSDescription.Location = New System.Drawing.Point(150, 239)
        Me.RtxtSMSDescription.Name = "RtxtSMSDescription"
        Me.RtxtSMSDescription.Size = New System.Drawing.Size(730, 96)
        Me.RtxtSMSDescription.TabIndex = 1126
        Me.RtxtSMSDescription.Text = ""
        '
        'BtnSend
        '
        Me.BtnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSend.Image = Global.Business_Expert_Pro.My.Resources.Resources.sendsms
        Me.BtnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSend.Location = New System.Drawing.Point(250, 114)
        Me.BtnSend.Name = "BtnSend"
        Me.BtnSend.Size = New System.Drawing.Size(102, 36)
        Me.BtnSend.TabIndex = 1130
        Me.BtnSend.Text = "Send"
        Me.BtnSend.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSend.UseVisualStyleBackColor = True
        '
        'BtnAddNew
        '
        Me.BtnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddNew.Image = Global.Business_Expert_Pro.My.Resources.Resources.newButton
        Me.BtnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddNew.Location = New System.Drawing.Point(54, 114)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(102, 36)
        Me.BtnAddNew.TabIndex = 1131
        Me.BtnAddNew.Text = "Add New"
        Me.BtnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'GrdSMSNoticeBoard
        '
        Me.GrdSMSNoticeBoard.AllowUserToAddRows = False
        Me.GrdSMSNoticeBoard.AllowUserToDeleteRows = False
        Me.GrdSMSNoticeBoard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdSMSNoticeBoard.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdSMSNoticeBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdSMSNoticeBoard.Location = New System.Drawing.Point(12, 352)
        Me.GrdSMSNoticeBoard.Name = "GrdSMSNoticeBoard"
        Me.GrdSMSNoticeBoard.ReadOnly = True
        Me.GrdSMSNoticeBoard.Size = New System.Drawing.Size(1000, 242)
        Me.GrdSMSNoticeBoard.TabIndex = 1132
        '
        'FrmSMSNoticeBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1024, 605)
        Me.Controls.Add(Me.GrdSMSNoticeBoard)
        Me.Controls.Add(Me.BtnSend)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.RtxtSMSDescription)
        Me.Controls.Add(Me.CmbSMSGroup)
        Me.Controls.Add(Me.lblSMSGroup)
        Me.Controls.Add(Me.lblSMSDescription)
        Me.Controls.Add(Me.TxtTeacherID)
        Me.Controls.Add(Me.LblSMSID)
        Me.Controls.Add(Me.PnlSMSNoticeBoard)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSMSNoticeBoard"
        Me.Text = "SMS Notice Board"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.PnlSMSNoticeBoard.ResumeLayout(False)
        Me.PnlSMSNoticeBoard.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.GrdSMSNoticeBoard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblSMSNoticeBoard As System.Windows.Forms.Label
    Friend WithEvents PnlSMSNoticeBoard As System.Windows.Forms.Panel
    Friend WithEvents TxtTeacherID As System.Windows.Forms.TextBox
    Friend WithEvents LblSMSID As System.Windows.Forms.Label
    Friend WithEvents lblSMSDescription As System.Windows.Forms.Label
    Friend WithEvents lblSMSGroup As System.Windows.Forms.Label
    Friend WithEvents CmbSMSGroup As System.Windows.Forms.ComboBox
    Friend WithEvents RtxtSMSDescription As System.Windows.Forms.RichTextBox
    Friend WithEvents BtnSend As System.Windows.Forms.Button
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
    Friend WithEvents GrdSMSNoticeBoard As System.Windows.Forms.DataGridView
End Class
