<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWarrantySerial
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
        Me.PnlWarrantySerial = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Btnclose = New System.Windows.Forms.Button
        Me.Btnminimized = New System.Windows.Forms.Button
        Me.Btnmaximized = New System.Windows.Forms.Button
        Me.LblWarrantySerial = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.BtnUpdate = New System.Windows.Forms.Button
        Me.BtnAddNew = New System.Windows.Forms.Button
        Me.TxtWarrantyInvoice = New System.Windows.Forms.TextBox
        Me.LblWarrantyInvoice = New System.Windows.Forms.Label
        Me.TxtAddress = New System.Windows.Forms.TextBox
        Me.TxtPhoneNo = New System.Windows.Forms.TextBox
        Me.Label57 = New System.Windows.Forms.Label
        Me.label56 = New System.Windows.Forms.Label
        Me.LblName = New System.Windows.Forms.Label
        Me.GrpSerialNumber = New System.Windows.Forms.GroupBox
        Me.LblWarrantyStatus = New System.Windows.Forms.Label
        Me.LblWarrantyStatusLbl = New System.Windows.Forms.Label
        Me.LblProductNameLbl = New System.Windows.Forms.Label
        Me.LblProductName = New System.Windows.Forms.Label
        Me.LblUsingDays = New System.Windows.Forms.Label
        Me.LblUsingDaysLbl = New System.Windows.Forms.Label
        Me.LblWarrantyDays = New System.Windows.Forms.Label
        Me.LblWarrantyDaysLbl = New System.Windows.Forms.Label
        Me.LblSaleDate = New System.Windows.Forms.Label
        Me.LblSaleDateLbl = New System.Windows.Forms.Label
        Me.TxtProblemDetails = New System.Windows.Forms.TextBox
        Me.LblProblemDetails = New System.Windows.Forms.Label
        Me.TxtSolutionDetails = New System.Windows.Forms.TextBox
        Me.LblSolutionDetails = New System.Windows.Forms.Label
        Me.LblDeliveryDate = New System.Windows.Forms.Label
        Me.DtpDeliveryDate = New System.Windows.Forms.DateTimePicker
        Me.GrpWarrantyDetails = New System.Windows.Forms.GroupBox
        Me.TxtReceiveItem = New System.Windows.Forms.TextBox
        Me.LblReceiveItem = New System.Windows.Forms.Label
        Me.TxtSerialID = New System.Windows.Forms.TextBox
        Me.LblSerialID = New System.Windows.Forms.Label
        Me.TxtName = New System.Windows.Forms.TextBox
        Me.CmbStatus = New System.Windows.Forms.ComboBox
        Me.LblStatus = New System.Windows.Forms.Label
        Me.BtnAddToWarranty = New System.Windows.Forms.Button
        Me.TxtSerialNumber = New System.Windows.Forms.TextBox
        Me.LblSerialNumber = New System.Windows.Forms.Label
        Me.GrpCustomerDetails = New System.Windows.Forms.GroupBox
        Me.LbLCustomerNameLbl = New System.Windows.Forms.Label
        Me.LblCustomerName = New System.Windows.Forms.Label
        Me.LblAddress = New System.Windows.Forms.Label
        Me.LblAddressLbl = New System.Windows.Forms.Label
        Me.LblPhoneNo = New System.Windows.Forms.Label
        Me.LblPhoneNoLbl = New System.Windows.Forms.Label
        Me.LblDate = New System.Windows.Forms.Label
        Me.DtpDate = New System.Windows.Forms.DateTimePicker
        Me.BtnDeleteInv = New System.Windows.Forms.Button
        Me.GrdWarrantySerial = New System.Windows.Forms.DataGridView
        Me.PnlWarrantySerial.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GrpSerialNumber.SuspendLayout()
        Me.GrpWarrantyDetails.SuspendLayout()
        Me.GrpCustomerDetails.SuspendLayout()
        CType(Me.GrdWarrantySerial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlWarrantySerial
        '
        Me.PnlWarrantySerial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlWarrantySerial.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.PnlWarrantySerial.Controls.Add(Me.Panel1)
        Me.PnlWarrantySerial.Controls.Add(Me.LblWarrantySerial)
        Me.PnlWarrantySerial.Location = New System.Drawing.Point(-1, 0)
        Me.PnlWarrantySerial.Name = "PnlWarrantySerial"
        Me.PnlWarrantySerial.Size = New System.Drawing.Size(1015, 66)
        Me.PnlWarrantySerial.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Btnclose)
        Me.Panel1.Controls.Add(Me.Btnminimized)
        Me.Panel1.Controls.Add(Me.Btnmaximized)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1015, 27)
        Me.Panel1.TabIndex = 4
        '
        'Btnclose
        '
        Me.Btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclose.BackColor = System.Drawing.SystemColors.Control
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnclose.Image = Global.Business_Expert_Pro.My.Resources.Resources.icons8_Close_Window_32px_2
        Me.Btnclose.Location = New System.Drawing.Point(988, 0)
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
        Me.Btnminimized.Location = New System.Drawing.Point(934, 0)
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
        Me.Btnmaximized.Location = New System.Drawing.Point(961, 0)
        Me.Btnmaximized.Name = "Btnmaximized"
        Me.Btnmaximized.Size = New System.Drawing.Size(24, 24)
        Me.Btnmaximized.TabIndex = 1160
        Me.Btnmaximized.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnmaximized.UseVisualStyleBackColor = False
        '
        'LblWarrantySerial
        '
        Me.LblWarrantySerial.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblWarrantySerial.AutoSize = True
        Me.LblWarrantySerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWarrantySerial.ForeColor = System.Drawing.Color.White
        Me.LblWarrantySerial.Location = New System.Drawing.Point(381, 26)
        Me.LblWarrantySerial.Name = "LblWarrantySerial"
        Me.LblWarrantySerial.Size = New System.Drawing.Size(253, 37)
        Me.LblWarrantySerial.TabIndex = 0
        Me.LblWarrantySerial.Text = "Warranty Serial"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Business_Expert_Pro.My.Resources.Resources.Save_32px_3
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(638, 444)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 34)
        Me.Button1.TabIndex = 112
        Me.Button1.Text = "Save"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.Image = Global.Business_Expert_Pro.My.Resources.Resources.Edit_File_32px
        Me.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUpdate.Location = New System.Drawing.Point(755, 444)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(107, 34)
        Me.BtnUpdate.TabIndex = 113
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnAddNew
        '
        Me.BtnAddNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddNew.Image = Global.Business_Expert_Pro.My.Resources.Resources.Add_New2
        Me.BtnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddNew.Location = New System.Drawing.Point(523, 444)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(107, 34)
        Me.BtnAddNew.TabIndex = 111
        Me.BtnAddNew.Text = "Add New"
        Me.BtnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddNew.UseVisualStyleBackColor = True
        '
        'TxtWarrantyInvoice
        '
        Me.TxtWarrantyInvoice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtWarrantyInvoice.Location = New System.Drawing.Point(879, 72)
        Me.TxtWarrantyInvoice.Name = "TxtWarrantyInvoice"
        Me.TxtWarrantyInvoice.Size = New System.Drawing.Size(123, 20)
        Me.TxtWarrantyInvoice.TabIndex = 114
        '
        'LblWarrantyInvoice
        '
        Me.LblWarrantyInvoice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblWarrantyInvoice.AutoSize = True
        Me.LblWarrantyInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWarrantyInvoice.Location = New System.Drawing.Point(811, 72)
        Me.LblWarrantyInvoice.Name = "LblWarrantyInvoice"
        Me.LblWarrantyInvoice.Size = New System.Drawing.Size(67, 15)
        Me.LblWarrantyInvoice.TabIndex = 1069
        Me.LblWarrantyInvoice.Text = "Invoice No:"
        '
        'TxtAddress
        '
        Me.TxtAddress.Location = New System.Drawing.Point(132, 122)
        Me.TxtAddress.Multiline = True
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(245, 57)
        Me.TxtAddress.TabIndex = 104
        '
        'TxtPhoneNo
        '
        Me.TxtPhoneNo.Location = New System.Drawing.Point(132, 96)
        Me.TxtPhoneNo.Name = "TxtPhoneNo"
        Me.TxtPhoneNo.Size = New System.Drawing.Size(245, 20)
        Me.TxtPhoneNo.TabIndex = 103
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.Location = New System.Drawing.Point(23, 124)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(54, 15)
        Me.Label57.TabIndex = 116
        Me.Label57.Text = "Address:"
        '
        'label56
        '
        Me.label56.AutoSize = True
        Me.label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label56.Location = New System.Drawing.Point(23, 96)
        Me.label56.Name = "label56"
        Me.label56.Size = New System.Drawing.Size(65, 15)
        Me.label56.TabIndex = 115
        Me.label56.Text = "Phone No:"
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName.Location = New System.Drawing.Point(23, 69)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(44, 15)
        Me.LblName.TabIndex = 114
        Me.LblName.Text = "Name:"
        '
        'GrpSerialNumber
        '
        Me.GrpSerialNumber.Controls.Add(Me.LblWarrantyStatus)
        Me.GrpSerialNumber.Controls.Add(Me.LblWarrantyStatusLbl)
        Me.GrpSerialNumber.Controls.Add(Me.LblProductNameLbl)
        Me.GrpSerialNumber.Controls.Add(Me.LblProductName)
        Me.GrpSerialNumber.Controls.Add(Me.LblUsingDays)
        Me.GrpSerialNumber.Controls.Add(Me.LblUsingDaysLbl)
        Me.GrpSerialNumber.Controls.Add(Me.LblWarrantyDays)
        Me.GrpSerialNumber.Controls.Add(Me.LblWarrantyDaysLbl)
        Me.GrpSerialNumber.Controls.Add(Me.LblSaleDate)
        Me.GrpSerialNumber.Controls.Add(Me.LblSaleDateLbl)
        Me.GrpSerialNumber.Location = New System.Drawing.Point(442, 180)
        Me.GrpSerialNumber.Name = "GrpSerialNumber"
        Me.GrpSerialNumber.Size = New System.Drawing.Size(345, 147)
        Me.GrpSerialNumber.TabIndex = 2035
        Me.GrpSerialNumber.TabStop = False
        Me.GrpSerialNumber.Text = "Product Details"
        '
        'LblWarrantyStatus
        '
        Me.LblWarrantyStatus.AutoSize = True
        Me.LblWarrantyStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWarrantyStatus.Location = New System.Drawing.Point(128, 116)
        Me.LblWarrantyStatus.Name = "LblWarrantyStatus"
        Me.LblWarrantyStatus.Size = New System.Drawing.Size(37, 15)
        Me.LblWarrantyStatus.TabIndex = 130
        Me.LblWarrantyStatus.Text = "None"
        '
        'LblWarrantyStatusLbl
        '
        Me.LblWarrantyStatusLbl.AutoSize = True
        Me.LblWarrantyStatusLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWarrantyStatusLbl.Location = New System.Drawing.Point(15, 116)
        Me.LblWarrantyStatusLbl.Name = "LblWarrantyStatusLbl"
        Me.LblWarrantyStatusLbl.Size = New System.Drawing.Size(95, 15)
        Me.LblWarrantyStatusLbl.TabIndex = 129
        Me.LblWarrantyStatusLbl.Text = "Warranty Status:"
        '
        'LblProductNameLbl
        '
        Me.LblProductNameLbl.AutoSize = True
        Me.LblProductNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProductNameLbl.Location = New System.Drawing.Point(15, 16)
        Me.LblProductNameLbl.Name = "LblProductNameLbl"
        Me.LblProductNameLbl.Size = New System.Drawing.Size(89, 15)
        Me.LblProductNameLbl.TabIndex = 128
        Me.LblProductNameLbl.Text = "Product Name:"
        '
        'LblProductName
        '
        Me.LblProductName.AutoSize = True
        Me.LblProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProductName.Location = New System.Drawing.Point(128, 16)
        Me.LblProductName.Name = "LblProductName"
        Me.LblProductName.Size = New System.Drawing.Size(37, 15)
        Me.LblProductName.TabIndex = 127
        Me.LblProductName.Text = "None"
        '
        'LblUsingDays
        '
        Me.LblUsingDays.AutoSize = True
        Me.LblUsingDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsingDays.Location = New System.Drawing.Point(128, 91)
        Me.LblUsingDays.Name = "LblUsingDays"
        Me.LblUsingDays.Size = New System.Drawing.Size(21, 15)
        Me.LblUsingDays.TabIndex = 124
        Me.LblUsingDays.Text = "00"
        '
        'LblUsingDaysLbl
        '
        Me.LblUsingDaysLbl.AutoSize = True
        Me.LblUsingDaysLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsingDaysLbl.Location = New System.Drawing.Point(15, 91)
        Me.LblUsingDaysLbl.Name = "LblUsingDaysLbl"
        Me.LblUsingDaysLbl.Size = New System.Drawing.Size(72, 15)
        Me.LblUsingDaysLbl.TabIndex = 123
        Me.LblUsingDaysLbl.Text = "Using Days:"
        '
        'LblWarrantyDays
        '
        Me.LblWarrantyDays.AutoSize = True
        Me.LblWarrantyDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWarrantyDays.Location = New System.Drawing.Point(128, 66)
        Me.LblWarrantyDays.Name = "LblWarrantyDays"
        Me.LblWarrantyDays.Size = New System.Drawing.Size(21, 15)
        Me.LblWarrantyDays.TabIndex = 122
        Me.LblWarrantyDays.Text = "00"
        '
        'LblWarrantyDaysLbl
        '
        Me.LblWarrantyDaysLbl.AutoSize = True
        Me.LblWarrantyDaysLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWarrantyDaysLbl.Location = New System.Drawing.Point(15, 66)
        Me.LblWarrantyDaysLbl.Name = "LblWarrantyDaysLbl"
        Me.LblWarrantyDaysLbl.Size = New System.Drawing.Size(88, 15)
        Me.LblWarrantyDaysLbl.TabIndex = 121
        Me.LblWarrantyDaysLbl.Text = "Warranty Days:"
        '
        'LblSaleDate
        '
        Me.LblSaleDate.AutoSize = True
        Me.LblSaleDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSaleDate.Location = New System.Drawing.Point(128, 41)
        Me.LblSaleDate.Name = "LblSaleDate"
        Me.LblSaleDate.Size = New System.Drawing.Size(55, 15)
        Me.LblSaleDate.TabIndex = 120
        Me.LblSaleDate.Text = "00/00/00"
        '
        'LblSaleDateLbl
        '
        Me.LblSaleDateLbl.AutoSize = True
        Me.LblSaleDateLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSaleDateLbl.Location = New System.Drawing.Point(15, 41)
        Me.LblSaleDateLbl.Name = "LblSaleDateLbl"
        Me.LblSaleDateLbl.Size = New System.Drawing.Size(64, 15)
        Me.LblSaleDateLbl.TabIndex = 119
        Me.LblSaleDateLbl.Text = "Sale Date:"
        '
        'TxtProblemDetails
        '
        Me.TxtProblemDetails.Location = New System.Drawing.Point(132, 185)
        Me.TxtProblemDetails.Multiline = True
        Me.TxtProblemDetails.Name = "TxtProblemDetails"
        Me.TxtProblemDetails.Size = New System.Drawing.Size(245, 57)
        Me.TxtProblemDetails.TabIndex = 105
        '
        'LblProblemDetails
        '
        Me.LblProblemDetails.AutoSize = True
        Me.LblProblemDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProblemDetails.Location = New System.Drawing.Point(23, 187)
        Me.LblProblemDetails.Name = "LblProblemDetails"
        Me.LblProblemDetails.Size = New System.Drawing.Size(98, 15)
        Me.LblProblemDetails.TabIndex = 2037
        Me.LblProblemDetails.Text = "Problem Details:"
        '
        'TxtSolutionDetails
        '
        Me.TxtSolutionDetails.Location = New System.Drawing.Point(132, 295)
        Me.TxtSolutionDetails.Multiline = True
        Me.TxtSolutionDetails.Name = "TxtSolutionDetails"
        Me.TxtSolutionDetails.Size = New System.Drawing.Size(245, 57)
        Me.TxtSolutionDetails.TabIndex = 107
        '
        'LblSolutionDetails
        '
        Me.LblSolutionDetails.AutoSize = True
        Me.LblSolutionDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSolutionDetails.Location = New System.Drawing.Point(23, 297)
        Me.LblSolutionDetails.Name = "LblSolutionDetails"
        Me.LblSolutionDetails.Size = New System.Drawing.Size(96, 15)
        Me.LblSolutionDetails.TabIndex = 2039
        Me.LblSolutionDetails.Text = "Solution Details:"
        '
        'LblDeliveryDate
        '
        Me.LblDeliveryDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblDeliveryDate.AutoSize = True
        Me.LblDeliveryDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDeliveryDate.Location = New System.Drawing.Point(23, 358)
        Me.LblDeliveryDate.Name = "LblDeliveryDate"
        Me.LblDeliveryDate.Size = New System.Drawing.Size(82, 15)
        Me.LblDeliveryDate.TabIndex = 2041
        Me.LblDeliveryDate.Text = "Delivery Date:"
        '
        'DtpDeliveryDate
        '
        Me.DtpDeliveryDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtpDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDeliveryDate.Location = New System.Drawing.Point(132, 358)
        Me.DtpDeliveryDate.Name = "DtpDeliveryDate"
        Me.DtpDeliveryDate.Size = New System.Drawing.Size(151, 20)
        Me.DtpDeliveryDate.TabIndex = 108
        Me.DtpDeliveryDate.Value = New Date(2017, 7, 28, 0, 0, 0, 0)
        '
        'GrpWarrantyDetails
        '
        Me.GrpWarrantyDetails.Controls.Add(Me.TxtReceiveItem)
        Me.GrpWarrantyDetails.Controls.Add(Me.LblReceiveItem)
        Me.GrpWarrantyDetails.Controls.Add(Me.TxtSerialID)
        Me.GrpWarrantyDetails.Controls.Add(Me.LblSerialID)
        Me.GrpWarrantyDetails.Controls.Add(Me.TxtName)
        Me.GrpWarrantyDetails.Controls.Add(Me.CmbStatus)
        Me.GrpWarrantyDetails.Controls.Add(Me.LblStatus)
        Me.GrpWarrantyDetails.Controls.Add(Me.LblDeliveryDate)
        Me.GrpWarrantyDetails.Controls.Add(Me.BtnAddToWarranty)
        Me.GrpWarrantyDetails.Controls.Add(Me.DtpDeliveryDate)
        Me.GrpWarrantyDetails.Controls.Add(Me.TxtSolutionDetails)
        Me.GrpWarrantyDetails.Controls.Add(Me.LblSolutionDetails)
        Me.GrpWarrantyDetails.Controls.Add(Me.TxtProblemDetails)
        Me.GrpWarrantyDetails.Controls.Add(Me.LblProblemDetails)
        Me.GrpWarrantyDetails.Controls.Add(Me.TxtAddress)
        Me.GrpWarrantyDetails.Controls.Add(Me.Label57)
        Me.GrpWarrantyDetails.Controls.Add(Me.TxtPhoneNo)
        Me.GrpWarrantyDetails.Controls.Add(Me.label56)
        Me.GrpWarrantyDetails.Controls.Add(Me.LblName)
        Me.GrpWarrantyDetails.Controls.Add(Me.TxtSerialNumber)
        Me.GrpWarrantyDetails.Controls.Add(Me.LblSerialNumber)
        Me.GrpWarrantyDetails.Location = New System.Drawing.Point(12, 72)
        Me.GrpWarrantyDetails.Name = "GrpWarrantyDetails"
        Me.GrpWarrantyDetails.Size = New System.Drawing.Size(424, 413)
        Me.GrpWarrantyDetails.TabIndex = 2042
        Me.GrpWarrantyDetails.TabStop = False
        Me.GrpWarrantyDetails.Text = "Warranty Details"
        '
        'TxtReceiveItem
        '
        Me.TxtReceiveItem.Location = New System.Drawing.Point(132, 248)
        Me.TxtReceiveItem.Multiline = True
        Me.TxtReceiveItem.Name = "TxtReceiveItem"
        Me.TxtReceiveItem.Size = New System.Drawing.Size(245, 41)
        Me.TxtReceiveItem.TabIndex = 106
        '
        'LblReceiveItem
        '
        Me.LblReceiveItem.AutoSize = True
        Me.LblReceiveItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReceiveItem.Location = New System.Drawing.Point(23, 248)
        Me.LblReceiveItem.Name = "LblReceiveItem"
        Me.LblReceiveItem.Size = New System.Drawing.Size(81, 15)
        Me.LblReceiveItem.TabIndex = 2047
        Me.LblReceiveItem.Text = "Receive Item:"
        '
        'TxtSerialID
        '
        Me.TxtSerialID.Enabled = False
        Me.TxtSerialID.Location = New System.Drawing.Point(132, 18)
        Me.TxtSerialID.Name = "TxtSerialID"
        Me.TxtSerialID.Size = New System.Drawing.Size(88, 20)
        Me.TxtSerialID.TabIndex = 2044
        '
        'LblSerialID
        '
        Me.LblSerialID.AutoSize = True
        Me.LblSerialID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSerialID.Location = New System.Drawing.Point(23, 18)
        Me.LblSerialID.Name = "LblSerialID"
        Me.LblSerialID.Size = New System.Drawing.Size(57, 15)
        Me.LblSerialID.TabIndex = 2045
        Me.LblSerialID.Text = "Serial ID:"
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(132, 70)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(245, 20)
        Me.TxtName.TabIndex = 102
        '
        'CmbStatus
        '
        Me.CmbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbStatus.FormattingEnabled = True
        Me.CmbStatus.Items.AddRange(New Object() {"Complete", "Incomplete"})
        Me.CmbStatus.Location = New System.Drawing.Point(132, 384)
        Me.CmbStatus.Name = "CmbStatus"
        Me.CmbStatus.Size = New System.Drawing.Size(151, 21)
        Me.CmbStatus.TabIndex = 109
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatus.Location = New System.Drawing.Point(23, 384)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(44, 15)
        Me.LblStatus.TabIndex = 2043
        Me.LblStatus.Text = "Status:"
        '
        'BtnAddToWarranty
        '
        Me.BtnAddToWarranty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAddToWarranty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddToWarranty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddToWarranty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddToWarranty.Location = New System.Drawing.Point(295, 379)
        Me.BtnAddToWarranty.Name = "BtnAddToWarranty"
        Me.BtnAddToWarranty.Size = New System.Drawing.Size(123, 28)
        Me.BtnAddToWarranty.TabIndex = 110
        Me.BtnAddToWarranty.Text = "Add To Warranty"
        Me.BtnAddToWarranty.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAddToWarranty.UseVisualStyleBackColor = True
        '
        'TxtSerialNumber
        '
        Me.TxtSerialNumber.Location = New System.Drawing.Point(132, 43)
        Me.TxtSerialNumber.Name = "TxtSerialNumber"
        Me.TxtSerialNumber.Size = New System.Drawing.Size(245, 20)
        Me.TxtSerialNumber.TabIndex = 101
        '
        'LblSerialNumber
        '
        Me.LblSerialNumber.AutoSize = True
        Me.LblSerialNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSerialNumber.Location = New System.Drawing.Point(23, 43)
        Me.LblSerialNumber.Name = "LblSerialNumber"
        Me.LblSerialNumber.Size = New System.Drawing.Size(90, 15)
        Me.LblSerialNumber.TabIndex = 118
        Me.LblSerialNumber.Text = "Serial Number:"
        '
        'GrpCustomerDetails
        '
        Me.GrpCustomerDetails.Controls.Add(Me.LbLCustomerNameLbl)
        Me.GrpCustomerDetails.Controls.Add(Me.LblCustomerName)
        Me.GrpCustomerDetails.Controls.Add(Me.LblAddress)
        Me.GrpCustomerDetails.Controls.Add(Me.LblAddressLbl)
        Me.GrpCustomerDetails.Controls.Add(Me.LblPhoneNo)
        Me.GrpCustomerDetails.Controls.Add(Me.LblPhoneNoLbl)
        Me.GrpCustomerDetails.Location = New System.Drawing.Point(442, 72)
        Me.GrpCustomerDetails.Name = "GrpCustomerDetails"
        Me.GrpCustomerDetails.Size = New System.Drawing.Size(345, 102)
        Me.GrpCustomerDetails.TabIndex = 2036
        Me.GrpCustomerDetails.TabStop = False
        Me.GrpCustomerDetails.Text = "Customer Details"
        '
        'LbLCustomerNameLbl
        '
        Me.LbLCustomerNameLbl.AutoSize = True
        Me.LbLCustomerNameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLCustomerNameLbl.Location = New System.Drawing.Point(15, 23)
        Me.LbLCustomerNameLbl.Name = "LbLCustomerNameLbl"
        Me.LbLCustomerNameLbl.Size = New System.Drawing.Size(100, 15)
        Me.LbLCustomerNameLbl.TabIndex = 128
        Me.LbLCustomerNameLbl.Text = "Customer Name:"
        '
        'LblCustomerName
        '
        Me.LblCustomerName.AutoSize = True
        Me.LblCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCustomerName.Location = New System.Drawing.Point(128, 23)
        Me.LblCustomerName.Name = "LblCustomerName"
        Me.LblCustomerName.Size = New System.Drawing.Size(37, 15)
        Me.LblCustomerName.TabIndex = 127
        Me.LblCustomerName.Text = "None"
        '
        'LblAddress
        '
        Me.LblAddress.AutoSize = True
        Me.LblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAddress.Location = New System.Drawing.Point(128, 73)
        Me.LblAddress.Name = "LblAddress"
        Me.LblAddress.Size = New System.Drawing.Size(37, 15)
        Me.LblAddress.TabIndex = 122
        Me.LblAddress.Text = "None"
        '
        'LblAddressLbl
        '
        Me.LblAddressLbl.AutoSize = True
        Me.LblAddressLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAddressLbl.Location = New System.Drawing.Point(15, 73)
        Me.LblAddressLbl.Name = "LblAddressLbl"
        Me.LblAddressLbl.Size = New System.Drawing.Size(54, 15)
        Me.LblAddressLbl.TabIndex = 121
        Me.LblAddressLbl.Text = "Address:"
        '
        'LblPhoneNo
        '
        Me.LblPhoneNo.AutoSize = True
        Me.LblPhoneNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPhoneNo.Location = New System.Drawing.Point(128, 48)
        Me.LblPhoneNo.Name = "LblPhoneNo"
        Me.LblPhoneNo.Size = New System.Drawing.Size(37, 15)
        Me.LblPhoneNo.TabIndex = 120
        Me.LblPhoneNo.Text = "None"
        '
        'LblPhoneNoLbl
        '
        Me.LblPhoneNoLbl.AutoSize = True
        Me.LblPhoneNoLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPhoneNoLbl.Location = New System.Drawing.Point(15, 48)
        Me.LblPhoneNoLbl.Name = "LblPhoneNoLbl"
        Me.LblPhoneNoLbl.Size = New System.Drawing.Size(65, 15)
        Me.LblPhoneNoLbl.TabIndex = 119
        Me.LblPhoneNoLbl.Text = "Phone No:"
        '
        'LblDate
        '
        Me.LblDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblDate.AutoSize = True
        Me.LblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDate.Location = New System.Drawing.Point(811, 99)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(36, 15)
        Me.LblDate.TabIndex = 2044
        Me.LblDate.Text = "Date:"
        '
        'DtpDate
        '
        Me.DtpDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDate.Location = New System.Drawing.Point(879, 98)
        Me.DtpDate.Name = "DtpDate"
        Me.DtpDate.Size = New System.Drawing.Size(123, 20)
        Me.DtpDate.TabIndex = 2043
        Me.DtpDate.Value = New Date(2017, 7, 28, 0, 0, 0, 0)
        '
        'BtnDeleteInv
        '
        Me.BtnDeleteInv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDeleteInv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnDeleteInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDeleteInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteInv.Image = Global.Business_Expert_Pro.My.Resources.Resources.Delete_32px
        Me.BtnDeleteInv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDeleteInv.Location = New System.Drawing.Point(872, 444)
        Me.BtnDeleteInv.Name = "BtnDeleteInv"
        Me.BtnDeleteInv.Size = New System.Drawing.Size(107, 34)
        Me.BtnDeleteInv.TabIndex = 114
        Me.BtnDeleteInv.Text = "Delete Inv."
        Me.BtnDeleteInv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDeleteInv.UseVisualStyleBackColor = True
        '
        'GrdWarrantySerial
        '
        Me.GrdWarrantySerial.AllowUserToAddRows = False
        Me.GrdWarrantySerial.AllowUserToDeleteRows = False
        Me.GrdWarrantySerial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdWarrantySerial.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.GrdWarrantySerial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdWarrantySerial.Location = New System.Drawing.Point(10, 491)
        Me.GrdWarrantySerial.Name = "GrdWarrantySerial"
        Me.GrdWarrantySerial.ReadOnly = True
        Me.GrdWarrantySerial.Size = New System.Drawing.Size(992, 239)
        Me.GrdWarrantySerial.TabIndex = 2045
        '
        'FrmWarrantySerial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1014, 736)
        Me.Controls.Add(Me.GrdWarrantySerial)
        Me.Controls.Add(Me.BtnDeleteInv)
        Me.Controls.Add(Me.LblDate)
        Me.Controls.Add(Me.DtpDate)
        Me.Controls.Add(Me.GrpCustomerDetails)
        Me.Controls.Add(Me.GrpWarrantyDetails)
        Me.Controls.Add(Me.GrpSerialNumber)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LblWarrantyInvoice)
        Me.Controls.Add(Me.TxtWarrantyInvoice)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnAddNew)
        Me.Controls.Add(Me.PnlWarrantySerial)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmWarrantySerial"
        Me.Text = "Warranty Serial"
        Me.PnlWarrantySerial.ResumeLayout(False)
        Me.PnlWarrantySerial.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GrpSerialNumber.ResumeLayout(False)
        Me.GrpSerialNumber.PerformLayout()
        Me.GrpWarrantyDetails.ResumeLayout(False)
        Me.GrpWarrantyDetails.PerformLayout()
        Me.GrpCustomerDetails.ResumeLayout(False)
        Me.GrpCustomerDetails.PerformLayout()
        CType(Me.GrdWarrantySerial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PnlWarrantySerial As System.Windows.Forms.Panel
    Friend WithEvents LblWarrantySerial As System.Windows.Forms.Label
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
    Friend WithEvents TxtWarrantyInvoice As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LblWarrantyInvoice As System.Windows.Forms.Label
    Friend WithEvents TxtAddress As System.Windows.Forms.TextBox
    Friend WithEvents TxtPhoneNo As System.Windows.Forms.TextBox
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents label56 As System.Windows.Forms.Label
    Friend WithEvents LblName As System.Windows.Forms.Label
    Friend WithEvents GrpSerialNumber As System.Windows.Forms.GroupBox
    Friend WithEvents LblUsingDays As System.Windows.Forms.Label
    Friend WithEvents LblUsingDaysLbl As System.Windows.Forms.Label
    Friend WithEvents LblWarrantyDays As System.Windows.Forms.Label
    Friend WithEvents LblWarrantyDaysLbl As System.Windows.Forms.Label
    Friend WithEvents LblSaleDate As System.Windows.Forms.Label
    Friend WithEvents LblSaleDateLbl As System.Windows.Forms.Label
    Friend WithEvents LblProductNameLbl As System.Windows.Forms.Label
    Friend WithEvents LblProductName As System.Windows.Forms.Label
    Friend WithEvents LblWarrantyStatus As System.Windows.Forms.Label
    Friend WithEvents LblWarrantyStatusLbl As System.Windows.Forms.Label
    Friend WithEvents TxtProblemDetails As System.Windows.Forms.TextBox
    Friend WithEvents LblProblemDetails As System.Windows.Forms.Label
    Friend WithEvents TxtSolutionDetails As System.Windows.Forms.TextBox
    Friend WithEvents LblSolutionDetails As System.Windows.Forms.Label
    Friend WithEvents LblDeliveryDate As System.Windows.Forms.Label
    Friend WithEvents DtpDeliveryDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GrpWarrantyDetails As System.Windows.Forms.GroupBox
    Friend WithEvents GrpCustomerDetails As System.Windows.Forms.GroupBox
    Friend WithEvents LbLCustomerNameLbl As System.Windows.Forms.Label
    Friend WithEvents LblCustomerName As System.Windows.Forms.Label
    Friend WithEvents LblAddress As System.Windows.Forms.Label
    Friend WithEvents LblAddressLbl As System.Windows.Forms.Label
    Friend WithEvents LblPhoneNo As System.Windows.Forms.Label
    Friend WithEvents LblPhoneNoLbl As System.Windows.Forms.Label
    Friend WithEvents TxtName As System.Windows.Forms.TextBox
    Friend WithEvents TxtSerialID As System.Windows.Forms.TextBox
    Friend WithEvents LblSerialID As System.Windows.Forms.Label
    Friend WithEvents BtnAddToWarranty As System.Windows.Forms.Button
    Friend WithEvents LblStatus As System.Windows.Forms.Label
    Friend WithEvents CmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents TxtSerialNumber As System.Windows.Forms.TextBox
    Friend WithEvents LblSerialNumber As System.Windows.Forms.Label
    Friend WithEvents LblDate As System.Windows.Forms.Label
    Friend WithEvents DtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtReceiveItem As System.Windows.Forms.TextBox
    Friend WithEvents LblReceiveItem As System.Windows.Forms.Label
    Friend WithEvents BtnDeleteInv As System.Windows.Forms.Button
    Friend WithEvents GrdWarrantySerial As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btnclose As System.Windows.Forms.Button
    Friend WithEvents Btnminimized As System.Windows.Forms.Button
    Friend WithEvents Btnmaximized As System.Windows.Forms.Button
End Class
