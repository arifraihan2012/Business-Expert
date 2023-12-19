<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWarrantyProcessing
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
        Me.LblWarrantyLookUp = New System.Windows.Forms.Label
        Me.PnlWarrantyLookUp = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.BtnSearchInvice = New System.Windows.Forms.Button
        Me.TxtSearchInvice = New System.Windows.Forms.TextBox
        Me.TxtSerialNumber = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.LblSerialNumber = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.LblRemarks = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.LblAddressCustomer = New System.Windows.Forms.Label
        Me.LblAddressLbl = New System.Windows.Forms.Label
        Me.LbLCustomerNameLbl = New System.Windows.Forms.Label
        Me.LblCustomerName = New System.Windows.Forms.Label
        Me.LblPhoneNoCustomer = New System.Windows.Forms.Label
        Me.LblPhoneNoLbl = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.GrdWarrantyInvoice = New System.Windows.Forms.DataGridView
        Me.GrdProductsDetails = New System.Windows.Forms.DataGridView
        Me.GrdWarrantySerialNumber = New System.Windows.Forms.DataGridView
        Me.GrdProblemDetails = New System.Windows.Forms.DataGridView
        Me.PnlWarrantyLookUp.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GrdWarrantyInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdProductsDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdWarrantySerialNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdProblemDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblWarrantyLookUp
        '
        Me.LblWarrantyLookUp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblWarrantyLookUp.AutoSize = True
        Me.LblWarrantyLookUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWarrantyLookUp.ForeColor = System.Drawing.Color.White
        Me.LblWarrantyLookUp.Location = New System.Drawing.Point(411, 28)
        Me.LblWarrantyLookUp.Name = "LblWarrantyLookUp"
        Me.LblWarrantyLookUp.Size = New System.Drawing.Size(334, 37)
        Me.LblWarrantyLookUp.TabIndex = 0
        Me.LblWarrantyLookUp.Text = "Warranty Processing"
        '
        'PnlWarrantyLookUp
        '
        Me.PnlWarrantyLookUp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlWarrantyLookUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlWarrantyLookUp.Controls.Add(Me.Panel1)
        Me.PnlWarrantyLookUp.Controls.Add(Me.LblWarrantyLookUp)
        Me.PnlWarrantyLookUp.Location = New System.Drawing.Point(0, 0)
        Me.PnlWarrantyLookUp.Name = "PnlWarrantyLookUp"
        Me.PnlWarrantyLookUp.Size = New System.Drawing.Size(1191, 72)
        Me.PnlWarrantyLookUp.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Btnclose)
        Me.Panel1.Controls.Add(Me.Btnminimized)
        Me.Panel1.Controls.Add(Me.Btnmaximized)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1183, 28)
        Me.Panel1.TabIndex = 5
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(1159, 0)
        Me.Btnclose.Name = "Btnclose"
        Me.Btnclose.Size = New System.Drawing.Size(21, 24)
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
        Me.Btnminimized.Location = New System.Drawing.Point(1102, 0)
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
        Me.Btnmaximized.Location = New System.Drawing.Point(1129, 0)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1160
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox3.Controls.Add(Me.BtnSearchInvice)
        Me.GroupBox3.Controls.Add(Me.TxtSearchInvice)
        Me.GroupBox3.Controls.Add(Me.TxtSerialNumber)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.LblSerialNumber)
        Me.GroupBox3.Location = New System.Drawing.Point(377, 78)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(430, 83)
        Me.GroupBox3.TabIndex = 2092
        Me.GroupBox3.TabStop = False
        '
        'BtnSearchInvice
        '
        Me.BtnSearchInvice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSearchInvice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearchInvice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearchInvice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSearchInvice.Location = New System.Drawing.Point(285, 43)
        Me.BtnSearchInvice.Name = "BtnSearchInvice"
        Me.BtnSearchInvice.Size = New System.Drawing.Size(139, 25)
        Me.BtnSearchInvice.TabIndex = 2091
        Me.BtnSearchInvice.Text = "Search serial"
        Me.BtnSearchInvice.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.BtnSearchInvice.UseVisualStyleBackColor = True
        '
        'TxtSearchInvice
        '
        Me.TxtSearchInvice.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtSearchInvice.Location = New System.Drawing.Point(96, 18)
        Me.TxtSearchInvice.Name = "TxtSearchInvice"
        Me.TxtSearchInvice.Size = New System.Drawing.Size(183, 20)
        Me.TxtSearchInvice.TabIndex = 2089
        '
        'TxtSerialNumber
        '
        Me.TxtSerialNumber.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtSerialNumber.Location = New System.Drawing.Point(96, 47)
        Me.TxtSerialNumber.Name = "TxtSerialNumber"
        Me.TxtSerialNumber.Size = New System.Drawing.Size(183, 20)
        Me.TxtSerialNumber.TabIndex = 2089
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 2090
        Me.Label1.Text = "Invoice No:"
        '
        'LblSerialNumber
        '
        Me.LblSerialNumber.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblSerialNumber.AutoSize = True
        Me.LblSerialNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSerialNumber.Location = New System.Drawing.Point(6, 46)
        Me.LblSerialNumber.Name = "LblSerialNumber"
        Me.LblSerialNumber.Size = New System.Drawing.Size(90, 15)
        Me.LblSerialNumber.TabIndex = 2090
        Me.LblSerialNumber.Text = "Serial Number:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblRemarks)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.LblAddressCustomer)
        Me.GroupBox2.Controls.Add(Me.LblAddressLbl)
        Me.GroupBox2.Controls.Add(Me.LbLCustomerNameLbl)
        Me.GroupBox2.Controls.Add(Me.LblCustomerName)
        Me.GroupBox2.Controls.Add(Me.LblPhoneNoCustomer)
        Me.GroupBox2.Controls.Add(Me.LblPhoneNoLbl)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 78)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(340, 88)
        Me.GroupBox2.TabIndex = 2093
        Me.GroupBox2.TabStop = False
        '
        'LblRemarks
        '
        Me.LblRemarks.AutoSize = True
        Me.LblRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.LblRemarks.Location = New System.Drawing.Point(97, 68)
        Me.LblRemarks.Name = "LblRemarks"
        Me.LblRemarks.Size = New System.Drawing.Size(32, 13)
        Me.LblRemarks.TabIndex = 2094
        Me.LblRemarks.Text = "None"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label4.Location = New System.Drawing.Point(11, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 2093
        Me.Label4.Text = "Remarks:"
        '
        'LblAddressCustomer
        '
        Me.LblAddressCustomer.AutoSize = True
        Me.LblAddressCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.LblAddressCustomer.Location = New System.Drawing.Point(97, 51)
        Me.LblAddressCustomer.Name = "LblAddressCustomer"
        Me.LblAddressCustomer.Size = New System.Drawing.Size(32, 13)
        Me.LblAddressCustomer.TabIndex = 134
        Me.LblAddressCustomer.Text = "None"
        '
        'LblAddressLbl
        '
        Me.LblAddressLbl.AutoSize = True
        Me.LblAddressLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.LblAddressLbl.Location = New System.Drawing.Point(11, 50)
        Me.LblAddressLbl.Name = "LblAddressLbl"
        Me.LblAddressLbl.Size = New System.Drawing.Size(48, 13)
        Me.LblAddressLbl.TabIndex = 133
        Me.LblAddressLbl.Text = "Address:"
        '
        'LbLCustomerNameLbl
        '
        Me.LbLCustomerNameLbl.AutoSize = True
        Me.LbLCustomerNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.LbLCustomerNameLbl.Location = New System.Drawing.Point(11, 16)
        Me.LbLCustomerNameLbl.Name = "LbLCustomerNameLbl"
        Me.LbLCustomerNameLbl.Size = New System.Drawing.Size(84, 13)
        Me.LbLCustomerNameLbl.TabIndex = 132
        Me.LbLCustomerNameLbl.Text = "Customer Name:"
        '
        'LblCustomerName
        '
        Me.LblCustomerName.AutoSize = True
        Me.LblCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.LblCustomerName.Location = New System.Drawing.Point(97, 17)
        Me.LblCustomerName.Name = "LblCustomerName"
        Me.LblCustomerName.Size = New System.Drawing.Size(32, 13)
        Me.LblCustomerName.TabIndex = 131
        Me.LblCustomerName.Text = "None"
        '
        'LblPhoneNoCustomer
        '
        Me.LblPhoneNoCustomer.AutoSize = True
        Me.LblPhoneNoCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.LblPhoneNoCustomer.Location = New System.Drawing.Point(97, 34)
        Me.LblPhoneNoCustomer.Name = "LblPhoneNoCustomer"
        Me.LblPhoneNoCustomer.Size = New System.Drawing.Size(32, 13)
        Me.LblPhoneNoCustomer.TabIndex = 130
        Me.LblPhoneNoCustomer.Text = "None"
        '
        'LblPhoneNoLbl
        '
        Me.LblPhoneNoLbl.AutoSize = True
        Me.LblPhoneNoLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.LblPhoneNoLbl.Location = New System.Drawing.Point(11, 33)
        Me.LblPhoneNoLbl.Name = "LblPhoneNoLbl"
        Me.LblPhoneNoLbl.Size = New System.Drawing.Size(57, 13)
        Me.LblPhoneNoLbl.TabIndex = 129
        Me.LblPhoneNoLbl.Text = "Phone No:"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(1024, 178)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 25)
        Me.Button1.TabIndex = 2092
        Me.Button1.Text = "Add to complete list"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(12, 172)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(95, 26)
        Me.Button7.TabIndex = 2096
        Me.Button7.Text = "Incompleted"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(122, 172)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 26)
        Me.Button2.TabIndex = 2097
        Me.Button2.Text = "Completed"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(257, 172)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(95, 26)
        Me.Button3.TabIndex = 2098
        Me.Button3.Text = "New Search"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GrdWarrantyInvoice
        '
        Me.GrdWarrantyInvoice.AllowUserToAddRows = False
        Me.GrdWarrantyInvoice.AllowUserToDeleteRows = False
        Me.GrdWarrantyInvoice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GrdWarrantyInvoice.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdWarrantyInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdWarrantyInvoice.Location = New System.Drawing.Point(12, 209)
        Me.GrdWarrantyInvoice.Name = "GrdWarrantyInvoice"
        Me.GrdWarrantyInvoice.ReadOnly = True
        Me.GrdWarrantyInvoice.Size = New System.Drawing.Size(340, 213)
        Me.GrdWarrantyInvoice.TabIndex = 2099
        '
        'GrdProductsDetails
        '
        Me.GrdProductsDetails.AllowUserToAddRows = False
        Me.GrdProductsDetails.AllowUserToDeleteRows = False
        Me.GrdProductsDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdProductsDetails.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdProductsDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdProductsDetails.Location = New System.Drawing.Point(358, 209)
        Me.GrdProductsDetails.Name = "GrdProductsDetails"
        Me.GrdProductsDetails.ReadOnly = True
        Me.GrdProductsDetails.Size = New System.Drawing.Size(157, 213)
        Me.GrdProductsDetails.TabIndex = 2100
        '
        'GrdWarrantySerialNumber
        '
        Me.GrdWarrantySerialNumber.AllowUserToAddRows = False
        Me.GrdWarrantySerialNumber.AllowUserToDeleteRows = False
        Me.GrdWarrantySerialNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdWarrantySerialNumber.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdWarrantySerialNumber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdWarrantySerialNumber.Location = New System.Drawing.Point(521, 209)
        Me.GrdWarrantySerialNumber.Name = "GrdWarrantySerialNumber"
        Me.GrdWarrantySerialNumber.ReadOnly = True
        Me.GrdWarrantySerialNumber.Size = New System.Drawing.Size(168, 213)
        Me.GrdWarrantySerialNumber.TabIndex = 2101
        '
        'GrdProblemDetails
        '
        Me.GrdProblemDetails.AllowUserToAddRows = False
        Me.GrdProblemDetails.AllowUserToDeleteRows = False
        Me.GrdProblemDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdProblemDetails.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdProblemDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdProblemDetails.Location = New System.Drawing.Point(695, 209)
        Me.GrdProblemDetails.Name = "GrdProblemDetails"
        Me.GrdProblemDetails.ReadOnly = True
        Me.GrdProblemDetails.Size = New System.Drawing.Size(482, 213)
        Me.GrdProblemDetails.TabIndex = 2102
        '
        'FrmWarrantyProcessing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 434)
        Me.Controls.Add(Me.GrdProblemDetails)
        Me.Controls.Add(Me.GrdWarrantySerialNumber)
        Me.Controls.Add(Me.GrdProductsDetails)
        Me.Controls.Add(Me.GrdWarrantyInvoice)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PnlWarrantyLookUp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmWarrantyProcessing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Warranty Processing"
        Me.PnlWarrantyLookUp.ResumeLayout(False)
        Me.PnlWarrantyLookUp.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GrdWarrantyInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdProductsDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdWarrantySerialNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdProblemDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblWarrantyLookUp As System.Windows.Forms.Label
    Friend WithEvents PnlWarrantyLookUp As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSearchInvice As System.Windows.Forms.Button
    Friend WithEvents TxtSearchInvice As System.Windows.Forms.TextBox
    Friend WithEvents TxtSerialNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblSerialNumber As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LblRemarks As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LblAddressCustomer As System.Windows.Forms.Label
    Friend WithEvents LblAddressLbl As System.Windows.Forms.Label
    Friend WithEvents LbLCustomerNameLbl As System.Windows.Forms.Label
    Friend WithEvents LblCustomerName As System.Windows.Forms.Label
    Friend WithEvents LblPhoneNoCustomer As System.Windows.Forms.Label
    Friend WithEvents LblPhoneNoLbl As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
    Friend WithEvents GrdWarrantyInvoice As System.Windows.Forms.DataGridView
    Friend WithEvents GrdProductsDetails As System.Windows.Forms.DataGridView
    Friend WithEvents GrdWarrantySerialNumber As System.Windows.Forms.DataGridView
    Friend WithEvents GrdProblemDetails As System.Windows.Forms.DataGridView
End Class
