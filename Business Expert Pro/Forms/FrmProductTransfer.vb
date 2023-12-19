Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmProductTransfer
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point


    Public PurchaseUnitCost As String
    Dim DeductedPurchaseID As String
    Dim AddedPurchaseID As String
    Public PurchaseInvoiceNumber As String
    Dim DeletePermission As String

    Dim PurchaseInvoiceNoForDeleteAndUpdateSerialNo As String

    Dim PurchaseInvoiceNoForPurchaseReturn As String
    Dim NewPurchaseInvoiceInsertedForProductTransfer As String
    Dim QuantityWritten As String
    Dim TransferQuantity As String
    Dim TotalRangeSerialCount As String
    Dim TotalInsertedQuantity As String
    Public ProductTransferEditStatus As Boolean

    Private Sub FrmProductTransfer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If Not TxtProductTransferInvoiceNo.Text = "" And Not ProductTransferEditStatus = True Then

            Dim q As MsgBoxResult = MsgBox("Do you want to keep this Invoice as draft?", MsgBoxStyle.YesNoCancel, "Product Transfer")

            If q = MsgBoxResult.No Then

                'Delete Full Invoice
                DeleteFullInvoice()

            ElseIf q = MsgBoxResult.Cancel Then
                e.Cancel = True
            End If
        ElseIf Not TxtProductTransferInvoiceNo.Text = "" And ProductTransferEditStatus = True Then
            If (MessageBox.Show(" Do you really want to Close?", "Bizpro", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No) Then

                e.Cancel = True


            End If


        End If
    End Sub

    Private Sub FrmProductTransfer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 0)
        Me.Size = My.Computer.Screen.WorkingArea.Size

        'permission for update and Delete
        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim MyFormName As Form = CType(sender, Form)



            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + FrmHome.LblUserID.Text + "' AND [Category Name] = '" + MyFormName.Text + "' And  [Update Delete Permission]='Yes'"


            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then
                BtnDelete.Enabled = True
                BtnSave.Enabled = True

                DeletePermission = "Yes"

            ElseIf Not dr.HasRows Then
                BtnDelete.Enabled = False
                BtnSave.Enabled = False
            End If


            dr.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while  permission delete to form..." & ex.Message, "Form Load")

        End Try


        'Combobox Load From Branch
        LoadComboboxFromBranch()

        'Combobox Load To Branch
        LoadComboboxToBranch()

        DtpTransferDate.Value = Now
        CmbFromBranch.SelectedValue = FrmHome.lblBranchID.Text


    End Sub

    'Search Purchase Invoice No For Purchase Return
    Sub SearchPurchaseInvoiceNoForPurchaseReturn()



        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader




            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT SUBSTRING([Transfer Status],10,LEN([Transfer Status])-2)[Transfer Status],[Purchase Invoice No]   FROM [Purchase]  WHERE [Purchase ID] = '" + TxtPurchaseID.Text + "'"


            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.Item("Transfer Status") Is DBNull.Value Then

                PurchaseInvoiceNoForPurchaseReturn = dr.Item("Purchase Invoice No")

            ElseIf dr.Item("Transfer Status") IsNot DBNull.Value Then

                PurchaseInvoiceNoForPurchaseReturn = dr.Item("Transfer status")


            End If

            dr.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while  permission delete to form..." & ex.Message, "Form Load")

        End Try


    End Sub

    'Clear data for list new product
    Sub cleardataProduct()

        cmbProductName.Text = ""
        cmbProductName.ValueMember = ""

        TxtPurchaseID.Text = ""
        TxtQuantity.Text = ""

        lblTransferID.Text = "00"
        lblQuantity.Text = "00"

        LblTotalAvailableStock.Text = "00"

        CmbSerialNumber.Text = ""

        TxtFromSerial.Text = ""
        TxtToSerial.Text = ""


        TxtWarrantyDays.Text = ""

        RdbRangeSerial.Checked = False
        cmbProductName.Enabled = True

        LblStatus.Text = "Status"
        LblStatus.ForeColor = Color.Black

        GrdAvailableSerialNumber.Columns.Clear()

        TransferQuantity = 0
        TotalInsertedQuantity = 0

    End Sub

    'Clear Data for make new invoice
    Sub ClearAllData()

        cmbProductName.Text = ""
        cmbProductName.ValueMember = ""

        TxtPurchaseID.Text = ""
        TxtQuantity.Text = ""

        lblTransferID.Text = "00"
        lblQuantity.Text = "00"
        LblTotalAvailableStock.Text = "00"

        CmbSerialNumber.Text = ""

        TxtFromSerial.Text = ""
        TxtToSerial.Text = ""

        RdbRangeSerial.Checked = False
        cmbProductName.Enabled = True

        LblStatus.Text = "Status"
        LblStatus.ForeColor = Color.Black


        TxtProductTransferInvoiceNo.Text = ""
        CmbToBranch.SelectedValue = 0
        DtpTransferDate.Value = Now
        CmbLocationID.SelectedValue = 0

        TransferQuantity = 0
        TotalInsertedQuantity = 0

        ProductTransferEditStatus = False

        GrdAvailableSerialNumber.Columns.Clear()
        GrdProductTransfer.Columns.Clear()



    End Sub

    'Serach Serial Number Available or not
    Sub SearchSerialStatus()
        Try


            Dim con2 As New SqlConnection
            Dim cmd2 As New SqlCommand
            Dim dr1 As SqlDataReader

            con2.ConnectionString = FrmHome.ConnectionString
            con2.Open()
            cmd2.Connection = con2
            cmd2.CommandText = "select * from [Purchase Serial Number]  where ([Purchase Serial Number].[Product ID]='" + cmbProductName.ValueMember + "' And [Purchase Serial Number].[Status]='Available' And [Purchase Serial Number].[Branch ID]= '" + CmbFromBranch.SelectedValue.ToString + "')"

            dr1 = cmd2.ExecuteReader()
            dr1.Read()

            If dr1.HasRows Then

                LblStatus.Text = "Available"
                LblStatus.ForeColor = Color.DarkGreen

            ElseIf Not dr1.HasRows Then

                LblStatus.Text = "Not Available"
                LblStatus.ForeColor = Color.DarkRed

            End If

            dr1.Close()
            con2.Close()

        Catch ex As Exception

        End Try

    End Sub

    'Load Combo Box for Serial Number
    Sub LoadComboBoxforSerialNumber()

        Try


            Dim con1 As New SqlConnection
            Dim cmd1 As New SqlCommand
            con1.ConnectionString = FrmHome.ConnectionString

            Dim strSQL1 As String = "Select [Purchase Serial Number].[Purchase Serial Number] From [Purchase Serial Number] Where [Purchase Serial Number].[Status]='Available' And [Purchase Serial Number]. [Product ID]='" + cmbProductName.ValueMember + "' And [Purchase Serial Number].[Branch ID]= '" + CmbFromBranch.SelectedValue.ToString + "'"
            Dim da1 As New System.Data.SqlClient.SqlDataAdapter(strSQL1, con1)
            Dim ds1 As New DataSet
            da1.Fill(ds1, "[Purchase Serial Number]")

            With Me.CmbSerialNumber
                .DataSource = ds1.Tables("[Purchase Serial Number]")
                .DisplayMember = "Purchase Serial Number"
            End With
            con1.Close()

            'Serial number combobox clear
            CmbSerialNumber.Text = ""


        Catch ex As Exception
            MessageBox.Show("Error while loading Customer record on table..." & ex.Message, "Load ComboBox for customer Sub")

        End Try

    End Sub

    'Load combobox for load from branch
    Sub LoadComboboxFromBranch()

        Try

            Dim con1 As New SqlConnection
            Dim cmd1 As New SqlCommand
            con1.ConnectionString = FrmHome.ConnectionString

            Dim strSQL1 As String = "SELECT [Branch ID],[Branch Name] FROM [Branch Information] where [Branch ID]= '" + FrmHome.lblBranchID.Text + "'"
            Dim da1 As New System.Data.SqlClient.SqlDataAdapter(strSQL1, con1)
            Dim ds1 As New DataSet
            da1.Fill(ds1, "[Branch Information]")

            With Me.CmbFromBranch
                .DataSource = ds1.Tables("[Branch Information]")
                .ValueMember = "Branch ID"
                .DisplayMember = "Branch Name"
            End With
            con1.Close()


        Catch ex As Exception
            MessageBox.Show("Error while searching records on table..." & ex.Message, "Load Combo Box From Branch")
        Finally

        End Try

    End Sub

    ' load combobox for load to branch
    Sub LoadComboboxToBranch()

        Try

            Dim con1 As New SqlConnection
            Dim cmd1 As New SqlCommand
            con1.ConnectionString = FrmHome.ConnectionString

            Dim strSQL1 As String = "SELECT [Branch ID],[Branch Name] FROM [Branch Information] Where Not [Branch ID]= '" + FrmHome.lblBranchID.Text + "'"
            Dim da1 As New System.Data.SqlClient.SqlDataAdapter(strSQL1, con1)
            Dim ds1 As New DataSet
            da1.Fill(ds1, "[Branch Information]")

            With Me.CmbToBranch
                .DataSource = ds1.Tables("[Branch Information]")
                .ValueMember = "Branch ID"
                .DisplayMember = "Branch Name"
            End With
            con1.Close()

            CmbToBranch.SelectedValue = 0

        Catch ex As Exception
            MessageBox.Show("Error while searching records on table..." & ex.Message, "Load Combo Box To Branch")
        Finally

        End Try

    End Sub

    'load combobox for load location for this branch
    Sub LoadComboboxLocationOfBranch()

        Try

            Dim con1 As New SqlConnection
            Dim cmd1 As New SqlCommand
            con1.ConnectionString = FrmHome.ConnectionString

            Dim strSQL1 As String = "SELECT [Location ID],[Location Name] FROM [Location Information] Where [Branch ID]= '" + CmbToBranch.SelectedValue.ToString + "'"
            Dim da1 As New System.Data.SqlClient.SqlDataAdapter(strSQL1, con1)
            Dim ds1 As New DataSet
            da1.Fill(ds1, "[Location Information]")

            With Me.CmbLocationID
                .DataSource = ds1.Tables("[Location Information]")
                .ValueMember = "Location ID"
                .DisplayMember = "Location Name"
            End With
            con1.Close()

            CmbLocationID.SelectedValue = 0

        Catch ex As Exception
            'No Message Box
        Finally

        End Try

    End Sub

    ' Refresh product transfer
    Sub RefreshDataProductTransfer()

        ' Load Data
        Try
         

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select [Product Transfer].[Transfer ID],[Branch Information].[Branch Name][Transfer To Branch],[Products].[Product Name],[Added Quantity][Transfer Quantity] from [product transfer] join [Products] on [product transfer].[product ID]=[products].[Product ID] join [Branch Information] on [Product Transfer].[Transfer Branch ID] = [Branch Information].[Branch ID] where [Status]='Added' And [Transfer Invoice No]= '" + TxtProductTransferInvoiceNo.Text + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Product Transfer")
            connection.Close()
            GrdProductTransfer.DataSource = ds
            GrdProductTransfer.DataMember = "BizPro_Product Transfer"

            'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)


            GrdProductTransfer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill



        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Data Product Transfer")
        Finally

        End Try

        'End Refresh Data
    End Sub
    'Insert Into Purchase And Product Transfer
    Sub InsertIntoPurchaseAndProductTransferForRangeSerial()

        Try

            'Data Insert Code
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd2 As New SqlCommand
            Dim cmd3 As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now
            Dim dr1 As SqlDataReader



            'Empty Txt Box Can Not Be Save Code
            If TxtProductTransferInvoiceNo.Text = "" Or CmbFromBranch.SelectedValue = 0 Or CmbToBranch.SelectedValue = 0 Or cmbProductName.ValueMember = "" Or cmbProductName.Text = "" Or TxtPurchaseID.Text = "" Or TxtQuantity.Text = "" Or CmbLocationID.SelectedValue = 0 Then
                MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Product Transfer")

            Else


                If Not Val(PurchaseInvoiceNumber) = 0 Then

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO [Purchase] ([Purchase Invoice No],[Product ID],[Purchase Location ID],[Purchase Quantity],[Purchase Unit Cost],[Amount],[Branch ID],[Computer ID],[User Account ID],[Purchase Date],[Warranty Days],[Memo No],[Transfer Status]) VALUES ('" + PurchaseInvoiceNumber + "','" + cmbProductName.ValueMember + "','" + CmbLocationID.SelectedValue.ToString + "','00','" + PurchaseUnitCost + "','00','" + CmbToBranch.SelectedValue.ToString + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + currentDate + "','" + TxtWarrantyDays.Text + "','" + TxtPurchaseID.Text + "','Transfer-" + PurchaseInvoiceNoForPurchaseReturn + "')"
                    cmd.ExecuteNonQuery()

                    cmd2.Connection = con
                    cmd2.CommandText = "SELECT top 1 [Purchase ID],[Purchase Invoice No] FROM [Purchase] where [User Account ID]= '" + FrmHome.LblUserID.Text + "' And [Computer ID]='" + FrmHome.LblComputerID.Text + "' order by [Purchase ID] desc"


                    dr1 = cmd2.ExecuteReader()
                    dr1.Read()
                    If dr1.HasRows Then


                        AddedPurchaseID = (dr1.Item("Purchase ID").ToString)
                        NewPurchaseInvoiceInsertedForProductTransfer = (dr1.Item("Purchase Invoice No").ToString)
                    End If
                    dr1.Close()



                    cmd3.Connection = con
                    cmd3.CommandText = "INSERT INTO [Product Transfer] ([Product ID],[Purchase ID],[Added Quantity],[Deducted Quantity],[Transfer Invoice No],[Transfer Branch ID],[Status],[Location ID],[Purchase Invoice No]) VALUES ('" + cmbProductName.ValueMember + "','" + AddedPurchaseID + "','" + TxtQuantity.Text + "','00','" + TxtProductTransferInvoiceNo.Text + "','" + CmbToBranch.SelectedValue.ToString + "','Added','" + CmbLocationID.SelectedValue.ToString + "','" + PurchaseInvoiceNoForPurchaseReturn + "')"
                    cmd3.ExecuteNonQuery()

                    cmd2.Connection = con
                    cmd2.CommandText = "INSERT INTO [Product Transfer] ([Product ID],[Purchase ID],[Added Quantity],[Deducted Quantity],[Transfer Invoice No],[Transfer Branch ID],[Status],[Purchase Invoice No]) VALUES ('" + cmbProductName.ValueMember + "','" + TxtPurchaseID.Text + "','00','" + TxtQuantity.Text + "','" + TxtProductTransferInvoiceNo.Text + "','" + CmbFromBranch.SelectedValue.ToString + "','Deducted','" + PurchaseInvoiceNoForPurchaseReturn + "')"
                    cmd2.ExecuteNonQuery()

                    con.Close()

                    'Refresh Product Transfer Data
                    RefreshDataProductTransfer()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Insert Into Purchase And Product Transfer
    Sub InsertIntoPurchaseAndProductTransfer()

        Try

            'Data Insert Code
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd2 As New SqlCommand
            Dim cmd3 As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now
            Dim dr1 As SqlDataReader



            'Empty Txt Box Can Not Be Save Code
            If TxtProductTransferInvoiceNo.Text = "" Or CmbFromBranch.SelectedValue = 0 Or CmbToBranch.SelectedValue = 0 Or cmbProductName.ValueMember = "" Or cmbProductName.Text = "" Or TxtPurchaseID.Text = "" Or TxtQuantity.Text = "" Or CmbLocationID.SelectedValue = 0 Then
                MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Product Transfer")

            Else

                If Not Val(PurchaseInvoiceNumber) = 0 Then


                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO [Purchase] ([Purchase Invoice No],[Product ID],[Purchase Location ID],[Purchase Quantity],[Purchase Unit Cost],[Amount],[Branch ID],[Computer ID],[User Account ID],[Purchase Date],[Warranty Days],[Memo No],[Transfer Status]) VALUES ('" + PurchaseInvoiceNumber + "','" + cmbProductName.ValueMember + "','" + CmbLocationID.SelectedValue.ToString + "','00','" + PurchaseUnitCost + "','00','" + CmbToBranch.SelectedValue.ToString + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + currentDate + "','" + TxtWarrantyDays.Text + "','" + TxtPurchaseID.Text + "','Transfer-" + PurchaseInvoiceNoForDeleteAndUpdateSerialNo + "')"
                    cmd.ExecuteNonQuery()

                    cmd2.Connection = con
                    cmd2.CommandText = "SELECT top 1 [Purchase ID],[Purchase Invoice No] FROM [Purchase] where [User Account ID]= '" + FrmHome.LblUserID.Text + "' And [Computer ID]='" + FrmHome.LblComputerID.Text + "' order by [Purchase ID] desc"


                    dr1 = cmd2.ExecuteReader()
                    dr1.Read()

                    If dr1.HasRows Then
                        AddedPurchaseID = (dr1.Item("Purchase ID").ToString)
                        NewPurchaseInvoiceInsertedForProductTransfer = (dr1.Item("Purchase Invoice No").ToString)

                    End If
                    dr1.Close()



                    cmd3.Connection = con
                    cmd3.CommandText = "INSERT INTO [Product Transfer] ([Product ID],[Purchase ID],[Added Quantity],[Deducted Quantity],[Transfer Invoice No],[Transfer Branch ID],[Status],[Location ID],[Purchase Invoice No]) VALUES ('" + cmbProductName.ValueMember + "','" + AddedPurchaseID + "','" + TxtQuantity.Text + "','00','" + TxtProductTransferInvoiceNo.Text + "','" + CmbToBranch.SelectedValue.ToString + "','Added','" + CmbLocationID.SelectedValue.ToString + "','" + PurchaseInvoiceNoForDeleteAndUpdateSerialNo + "')"
                    cmd3.ExecuteNonQuery()

                    cmd2.Connection = con
                    cmd2.CommandText = "INSERT INTO [Product Transfer] ([Product ID],[Purchase ID],[Added Quantity],[Deducted Quantity],[Transfer Invoice No],[Transfer Branch ID],[Status],[Purchase Invoice No]) VALUES ('" + cmbProductName.ValueMember + "','" + TxtPurchaseID.Text + "','00','" + TxtQuantity.Text + "','" + TxtProductTransferInvoiceNo.Text + "','" + CmbFromBranch.SelectedValue.ToString + "','Deducted','" + PurchaseInvoiceNoForDeleteAndUpdateSerialNo + "')"
                    cmd2.ExecuteNonQuery()

                    con.Close()


                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    'Insert or Update Into Purchase And Product Transfer
    Sub InsertorUpdateIntoPurchaseAndProductTransfer()

        Try

            'Data Update Code
            Dim con As New SqlConnection
            Dim con1 As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now
            Dim dr As SqlDataReader




            'Empty Txt Box Can Not Be Save Code
            If TxtProductTransferInvoiceNo.Text = "" Or CmbFromBranch.SelectedValue = 0 Or CmbToBranch.SelectedValue = 0 Or cmbProductName.ValueMember = "" Or cmbProductName.Text = "" Or TxtPurchaseID.Text = "" Or TxtQuantity.Text = "" Or CmbLocationID.SelectedValue = 0 Then
                MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Product Transfer")

            Else


                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd1.CommandText = " select * from [Product Transfer] where [Product ID]='" + cmbProductName.ValueMember + "' And [Transfer Invoice No]='" + TxtProductTransferInvoiceNo.Text + "' and [Purchase Invoice No]='" + PurchaseInvoiceNoForDeleteAndUpdateSerialNo + "' and [Purchase ID]='" + TxtPurchaseID.Text + "'"
                'MsgBox(PurchaseInvoiceNoForDeleteAndUpdateSerialNo)
                dr = cmd1.ExecuteReader
                dr.Read()

                'MsgBox(cmbProductName.ValueMember & "-1-" & TxtProductTransferInvoiceNo.Text & "-2-" & PurchaseInvoiceNoForDeleteAndUpdateSerialNo & "-3-" & TxtPurchaseID.Text)
                If dr.HasRows Then



                    'Update Into Product Transfer
                    UpdateIntoProductTransfer()

                ElseIf Not dr.HasRows Then

                    'Insert Into Purchase And Product Transfer
                    InsertIntoPurchaseAndProductTransfer()

                End If

                dr.Close()
                con1.Close()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    'Update Into Product Transfer
    Sub UpdateIntoProductTransfer()


        Try

            'Data Update Code
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            'Empty Txt Box Can Not Be Save Code
            If CmbFromBranch.SelectedValue = 0 Or CmbToBranch.SelectedValue = 0 Or cmbProductName.ValueMember = "" Or cmbProductName.Text = "" Or TxtPurchaseID.Text = "" Or TxtQuantity.Text = "" Or CmbLocationID.SelectedValue = 0 Then
                MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Product Transfer")
            Else




                'Find Added Purchase ID
                FindAddedPurchaseID()

                'Find Transfer ID To Show In Lable
                FindTransferIDToShowInLable()

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "Update [Product Transfer] Set  [Added Quantity]='" + TxtQuantity.Text + "',[Deducted Quantity]='00',[Transfer Branch ID]='" + CmbToBranch.SelectedValue.ToString + "' where [Product ID]='" + cmbProductName.ValueMember + "' And [Transfer Invoice No]='" + TxtProductTransferInvoiceNo.Text + "' and [Purchase Invoice No]='" + PurchaseInvoiceNoForDeleteAndUpdateSerialNo + "' and [Status]='Added' and [Purchase ID]='" + AddedPurchaseID + "'  Update [Product Transfer] Set  [Added Quantity]='00',[Deducted Quantity]='" + TxtQuantity.Text + "',[Transfer Branch ID]='" + CmbFromBranch.SelectedValue.ToString + "' where [Product ID]='" + cmbProductName.ValueMember + "' And [Transfer Invoice No]='" + TxtProductTransferInvoiceNo.Text + "' and [Purchase Invoice No]='" + PurchaseInvoiceNoForDeleteAndUpdateSerialNo + "' and [Status]='Deducted' and [Purchase ID]='" + DeductedPurchaseID + "'  Update [Purchase] Set  [Purchase Location ID]='" + CmbLocationID.SelectedValue.ToString + "',[Purchase Unit Cost]='" + PurchaseUnitCost + "'  where [Purchase ID]='" + AddedPurchaseID + "'"
                cmd.ExecuteNonQuery()
                con.Close()

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub




    Private Sub CmbFromBranch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbFromBranch.KeyPress

        e.Handled = True

    End Sub

    Private Sub CmbFromBranch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbFromBranch.SelectedIndexChanged

    End Sub

    Private Sub cmbProductName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbProductName.KeyDown

        If e.KeyCode = Keys.Enter Then

            If CmbToBranch.Text = "" Or CmbLocationID.Text = "" Then
                MsgBox("Please Select Transfer To Branch And Location", MsgBoxStyle.OkOnly, "Product Transfer")
                CmbToBranch.Focus()
            Else


                'Clear Data Product
                cleardataProduct()

                FrmListOfProductStock.Show()
                FrmListOfProductStock.TxtsearchProduct.Focus()
                FrmListOfProductStock.Label1.Text = "Product Transfer"
            End If
        ElseIf e.KeyCode = Keys.F2 Then
            'Clear Data Product
            cleardataProduct()

            'Focus on cmb Product name
            cmbProductName.Focus()



            'Load Combo Box for Serial Number()
            LoadComboBoxforSerialNumber()
        ElseIf e.KeyCode = Keys.Space AndAlso e.Control Then
            BtnSave.PerformClick()
        End If


    End Sub

    Private Sub cmbProductName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbProductName.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmbProductName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProductName.SelectedIndexChanged

    End Sub

    Private Sub TxtQuantity_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtQuantity.KeyDown
        If e.KeyCode = Keys.Enter Then


            If Val(TxtQuantity.Text) > Val(LblTotalAvailableStock.Text) Or Val(lblQuantity.Text) = 0 Or TxtQuantity.Text = "" Or Val(TxtQuantity.Text) = 0 Then

                MsgBox("Insufficient Stock", MsgBoxStyle.OkOnly, "Product Transfer")

                'Focus on quantity
                TxtQuantity.Focus()

            Else


                Me.CmbSerialNumber.Focus()
            End If
        ElseIf e.KeyCode = Keys.F2 Then
            'Clear Data Product
            cleardataProduct()

            'Focus on cmb Product name
            cmbProductName.Focus()

            'Refresh Data Serial Number To Gridview  Click
            RefreshDataSerialNumberToGridviewForCellMouseClick()

            'Load Combo Box for Serial Number()
            LoadComboBoxforSerialNumber()


        End If
    End Sub

    Private Sub TxtQuantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtQuantity.TextChanged

    End Sub

    Private Sub RdbRangeSerial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdbRangeSerial.CheckedChanged


        If RdbRangeSerial.Checked = True Then
            TxtFromSerial.Enabled = True

            TxtToSerial.Enabled = True

            TxtFromSerial.Focus()
            CmbSerialNumber.Text = ""

        ElseIf RdbRangeSerial.Checked = False Then
            TxtFromSerial.Enabled = False

            TxtToSerial.Enabled = False

        End If


    End Sub
    Private Sub CmbToBranch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbToBranch.SelectedIndexChanged
        LoadComboboxLocationOfBranch()
        CmbLocationID.Focus()
    End Sub

    Private Sub CmbSerialNumber_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbSerialNumber.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try


                If CmbToBranch.Text = "" Or CmbFromBranch.SelectedValue = 0 Then
                    MsgBox("Please Select Branch To Transfer Your Product")
                Else
                    If CmbSerialNumber.Text = "" Then
                        BtnAdd.Focus()
                    Else

                        RdbRangeSerial.Checked = False

                        'Insert Into Transfer Invoice No
                        InsertIntoProductTransferInvoice()

                        If Not TxtProductTransferInvoiceNo.Text = "" Or Not Val(PurchaseInvoiceNumber) = 0 Then


                            'If Val(TxtQuantity.Text) = Val(lblQuantity.Text) Then
                            'Find PurchaseID To Show In Textbox
                            'FindPurchaseIDToShowInTextbox()

                            'Insert  Product Transfer Serial No
                            'InsertIntoProductSerialTransferAndUpdatePurchaseSerialNumber()

                            'Refresh Product Transfer Serial Number 
                            ' RefreshDataSerialNumberToGridviewForCellMouseClick()

                            'Total Serial Inserted Row Count
                            'TxtQuantity.Text = GrdAvailableSerialNumber.RowCount

                            'Insert Product Transfer
                            'If lblTransferID.Text = "00" Then

                            'TxtQuantity.Text = "00"

                            'Insert or Update Into Purchase And Product Transfer
                            'InsertorUpdateIntoPurchaseAndProductTransfer()

                            'Find Transfer ID To Show In Lable
                            'FindTransferIDToShowInLable()

                            ' End If


                            'Else
                            'Find PurchaseID To Show In Textbox
                            'FindPurchaseIDToShowInTextbox()



                            'Insert or Update Into Purchase And Product Transfer
                            'InsertorUpdateIntoPurchaseAndProductTransfer()
                            'FindTransferIDToShowInLable()

                            'Insert  Product Transfer Serial No
                            InsertIntoProductSerialTransferAndUpdatePurchaseSerialNumber()

                            'Refresh Product Transfer Serial Number 
                            'RefreshDataSerialNumberToGridviewForCellMouseClick()

                            'Total Serial Inserted Row Count
                            'TxtQuantity.Text = GrdAvailableSerialNumber.RowCount

                            'Insert Product Transfer
                            'If lblTransferID.Text = "00" Then

                            'TxtQuantity.Text = "00"

                            'Insert or Update Into Purchase And Product Transfer
                            'InsertorUpdateIntoPurchaseAndProductTransfer()

                            'Find PurchaseID To Show In Textbox
                            ' FindPurchaseIDToShowInTextbox()

                            'Find Transfer ID To Show In Lable
                            'FindTransferIDToShowInLable()
                            'Find Transfer ID To Show In Lable
                            'FindTransferIDToShowInLable()

                            ' End If




                            'If Me.GrdAvailableSerialNumber.RowCount < Val(Me.TxtQuantity.Text) Then




                            'Update Product Transfer
                            'If Not lblTransferID.Text = "00" Then
                            'Update product transfer
                            'UpdateIntoProductTransfer()
                            'End If






                            'End If






                            'Refresh Product Transfer Data
                            RefreshDataProductTransfer()


                            CmbSerialNumber.Focus()

                            'Serial Number Show if available
                            LoadComboBoxforSerialNumber()


                            'TxtSaleAmount.Text = Val(TxtQuantity.Text) * Val(TxtSaleAmount.Text)
                            'Else
                            'CmbSerialNumber.Text = ""


                        End If


                    End If
                End If



            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    'Find Transfer ID To Show In Lable
    Sub FindTransferIDToShowInLableWhileAddingNewProduct()

        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            'Data reader for Product Id
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Product Transfer] WHERE [Purchase ID] = '" + AddedPurchaseID + "' And [Product ID]='" + cmbProductName.ValueMember + "' And [Transfer Invoice No]= '" + TxtProductTransferInvoiceNo.Text + "' And [Status]='Added'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                lblTransferID.Text = (dr.Item("Transfer ID").ToString)
                TxtQuantity.Text = (dr.Item("Added Quantity").ToString)

                'Show Available stock to lable
                ShowQuantityInLable()

                'Refresh Data Serial Number To Gridview  Click
                RefreshDataSerialNumberToGridviewForCellMouseClick()

            Else
                lblTransferID.Text = "00"
                TxtQuantity.Text = "00"

            End If

            dr.Close()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Show Available stock to lable
    Sub ShowQuantityInLable()

        Try
            Dim con As New SqlConnection
            Dim cmd1 As New SqlCommand
            Dim cmd As New SqlCommand
            Dim dr1 As SqlDataReader
            Dim dr As SqlDataReader

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd1.Connection = con
            cmd1.CommandText = "select top 10 [Purchase Date],[Purchase ID],[Supplier Name],[Product ID],[Product Name],[Branch Name],[Purchase Cost],[Sale Price],(isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))[Stock Available] from (select [Purchase].[Purchase Date],Purchase.[Purchase ID],[Supplier Information].[Supplier Name],[Products].[Product ID],[Products].[Product Name],[Branch Information].[Branch Name],[Branch Information].[Branch ID],Purchase.[Purchase Unit Cost][Purchase Cost],[Products].[Sale Price],case when [Purchase Quantity] =0  then (select isnull(sum( [Added Quantity]),0)[Added Quantity] from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  [Product Transfer].[Purchase ID]=Purchase.[Purchase ID] and [Product Transfer].Status='Added' and   [Product Transfer Invoice].Status='Complete'  and [Product Transfer].[Product ID]=Purchase.[Product ID]  group by [Purchase ID] )   ELSE isnull([Purchase].[Purchase Quantity],0) end [Purchase] ,(select isnull(sum([Sale Quantity]),0)      from  sale join [Sale Invoice] on sale.[Sale Invoice No]= [Sale Invoice].[Sale Invoice No] where Sale.[Branch ID]='" + FrmHome.lblBranchID.Text + "' and Sale.[Purchase ID]=Purchase.[Purchase ID]  group by [Purchase ID])[Sale],(select isnull(sum([Returned Quantity]),0)  from [Sale Return] join [Sale Return Invoice] on [Sale Return].[Sale Return Invoice No]=[Sale Return Invoice].[Sale Return Invoice No] where  [Sale Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Sale Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Sale Return],(select isnull(sum([Returned Quantity]),0)  from [Purchase Return] join [Purchase Return Invoice] on [Purchase Return].[Purchase Return Invoice No]=[Purchase Return Invoice].[Purchase Return Invoice No] where [Purchase Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Purchase Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Purchase Return], (select isnull(sum([Deducted Quantity]),0)  from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  Purchase.[Purchase ID]=[Product Transfer].[Purchase ID] and [Product Transfer].Status='Deducted'     group by [Purchase ID] )[Deducted] from Purchase  join Products on Purchase.[Product ID]=products.[Product ID]   join [Branch Information] on [Purchase].[Branch ID]=[Branch Information].[Branch ID]	   Join [Purchase Invoice] on [Purchase Invoice].[Purchase Invoice No]=[Purchase].[Purchase Invoice No]  join [Supplier Information] on [Purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID]  Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID]   Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID]   Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID]    where Purchase.[Branch ID]= '" + FrmHome.lblBranchID.Text + "' And Purchase.[Purchase ID] = '" + DeductedPurchaseID + "' and products. [Product ID] = '" + Me.cmbProductName.ValueMember + "') as a    group by [Purchase Date],[Purchase ID],[Supplier Name],[Branch Name],[Product ID],[Product Name],[Purchase Cost],[Sale Price] having (isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))>=0"

            dr1 = cmd1.ExecuteReader()
            dr1.Read()

            If dr1.HasRows Then


                lblQuantity.Text = (Val(dr1.Item("stock Available").ToString) + Val(TxtQuantity.Text))
            End If
            dr1.Close()

            cmd.Connection = con
            cmd.CommandText = "select isnull(sum([Stock Available]),0)[Stock Available]  from (select [Purchase Date],[Purchase ID],[Supplier Name],[Product ID],[Product Name],[Branch Name],[Purchase Cost],[Sale Price],(isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))[Stock Available] from (select [Purchase].[Purchase Date],Purchase.[Purchase ID],[Supplier Information].[Supplier Name],[Products].[Product ID],[Products].[Product Name],[Branch Information].[Branch Name],[Branch Information].[Branch ID],Purchase.[Purchase Unit Cost][Purchase Cost],[Products].[Sale Price],case when [Purchase Quantity] =0  then (select isnull(sum( [Added Quantity]),0)[Added Quantity] from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  [Product Transfer].[Purchase ID]=Purchase.[Purchase ID] and [Product Transfer].Status='Added' and   [Product Transfer Invoice].Status='Complete'  and [Product Transfer].[Product ID]=Purchase.[Product ID]  group by [Purchase ID] )   ELSE isnull([Purchase].[Purchase Quantity],0) end [Purchase] ,(select isnull(sum([Sale Quantity]),0)      from  sale join [Sale Invoice] on sale.[Sale Invoice No]= [Sale Invoice].[Sale Invoice No] where Sale.[Branch ID]='" + FrmHome.lblBranchID.Text + "' and Sale.[Purchase ID]=Purchase.[Purchase ID]  group by [Purchase ID])[Sale],(select isnull(sum([Returned Quantity]),0)  from [Sale Return] join [Sale Return Invoice] on [Sale Return].[Sale Return Invoice No]=[Sale Return Invoice].[Sale Return Invoice No] where  [Sale Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Sale Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Sale Return],(select isnull(sum([Returned Quantity]),0)  from [Purchase Return] join [Purchase Return Invoice] on [Purchase Return].[Purchase Return Invoice No]=[Purchase Return Invoice].[Purchase Return Invoice No] where [Purchase Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Purchase Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Purchase Return], (select isnull(sum([Deducted Quantity]),0)  from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  Purchase.[Purchase ID]=[Product Transfer].[Purchase ID] and [Product Transfer].Status='Deducted'     group by [Purchase ID] )[Deducted] from Purchase  join Products on Purchase.[Product ID]=products.[Product ID]   join [Branch Information] on [Purchase].[Branch ID]=[Branch Information].[Branch ID]	   Join [Purchase Invoice] on [Purchase Invoice].[Purchase Invoice No]=[Purchase].[Purchase Invoice No]  join [Supplier Information] on [Purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID]  Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID]   Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID]   Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID]    where Purchase.[Branch ID]= '" + FrmHome.lblBranchID.Text + "'  and products. [Product ID] = '" + Me.cmbProductName.ValueMember + "') as a    group by [Purchase Date],[Purchase ID],[Supplier Name],[Branch Name],[Product ID],[Product Name],[Purchase Cost],[Sale Price] having (isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))>=0) as a "


            dr = cmd.ExecuteReader()
            dr.Read()
            If dr.HasRows Then


                LblTotalAvailableStock.Text = (Val(dr.Item("stock Available").ToString) + Val(TotalInsertedQuantity))
            End If
            dr.Close()

            con.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Find PurchaseID To Show In Textbox
    Sub FindPurchaseIDToShowInTextbox()

        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            'Data reader for Product Id
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "select top 10 [Purchase Date],[Purchase ID],[Supplier Name],[Product ID],[Product Name],[Branch Name],[Purchase Cost],[Sale Price],(isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))[Stock Available] from (select [Purchase].[Purchase Date],Purchase.[Purchase ID],[Supplier Information].[Supplier Name],[Products].[Product ID],[Products].[Product Name],[Branch Information].[Branch Name],[Branch Information].[Branch ID],Purchase.[Purchase Unit Cost][Purchase Cost],[Products].[Sale Price],case when [Purchase Quantity] =0  then (select isnull(sum( [Added Quantity]),0)[Added Quantity] from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  [Product Transfer].[Purchase ID]=Purchase.[Purchase ID] and [Product Transfer].Status='Added' and   [Product Transfer Invoice].Status='Complete'  and [Product Transfer].[Product ID]=Purchase.[Product ID]  group by [Purchase ID] )   ELSE isnull([Purchase].[Purchase Quantity],0) end [Purchase] ,(select isnull(sum([Sale Quantity]),0)      from  sale join [Sale Invoice] on sale.[Sale Invoice No]= [Sale Invoice].[Sale Invoice No] where Sale.[Branch ID]='" + FrmHome.lblBranchID.Text + "' and Sale.[Purchase ID]=Purchase.[Purchase ID]  group by [Purchase ID])[Sale],(select isnull(sum([Returned Quantity]),0)  from [Sale Return] join [Sale Return Invoice] on [Sale Return].[Sale Return Invoice No]=[Sale Return Invoice].[Sale Return Invoice No] where  [Sale Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Sale Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Sale Return],(select isnull(sum([Returned Quantity]),0)  from [Purchase Return] join [Purchase Return Invoice] on [Purchase Return].[Purchase Return Invoice No]=[Purchase Return Invoice].[Purchase Return Invoice No] where [Purchase Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Purchase Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Purchase Return], (select isnull(sum([Deducted Quantity]),0)  from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  Purchase.[Purchase ID]=[Product Transfer].[Purchase ID] and [Product Transfer].Status='Deducted'     group by [Purchase ID] )[Deducted] from Purchase  join Products on Purchase.[Product ID]=products.[Product ID]   join [Branch Information] on [Purchase].[Branch ID]=[Branch Information].[Branch ID]	   Join [Purchase Invoice] on [Purchase Invoice].[Purchase Invoice No]=[Purchase].[Purchase Invoice No]  join [Supplier Information] on [Purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID]  Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID]   Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID]   Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID]    where Purchase.[Branch ID]= '" + FrmHome.lblBranchID.Text + "'  and products. [Product ID] = '" + Me.cmbProductName.ValueMember + "') as a    group by [Purchase Date],[Purchase ID],[Supplier Name],[Branch Name],[Product ID],[Product Name],[Purchase Cost],[Sale Price] having (isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))>0"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                TxtPurchaseID.Text = (dr.Item("Purchase ID").ToString)
                lblQuantity.Text = (dr.Item("Stock Available").ToString)


                'Find Transfer ID To Show In Lable
                'FindTransferIDToShowInLableWhileAddingNewProduct()



            ElseIf Not dr.HasRows Then
                TxtPurchaseID.Text = ""

            End If

            dr.Close()
            con.Close()



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Insert  Into Sale Serial No And Purchase Serial No
    Sub InsertIntoProductSerialTransferAndUpdatePurchaseSerialNumber()



        Try

            'Data Insert Code
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now



            Dim con3 As New SqlConnection
            Dim cmd3 As New SqlCommand
            Dim dr3 As SqlDataReader


            con3.ConnectionString = FrmHome.ConnectionString
            con3.Open()
            cmd3.Connection = con3
            cmd3.CommandText = "SELECT *from [Purchase Serial Number] where [Product ID]= '" + cmbProductName.ValueMember + "' And [Purchase Serial Number]='" + CmbSerialNumber.Text + "' And [Status]='Available' And [Branch ID]='" + CmbFromBranch.SelectedValue.ToString + "'"

            dr3 = cmd3.ExecuteReader()
            dr3.Read()

            If dr3.HasRows Then



                PurchaseInvoiceNoForDeleteAndUpdateSerialNo = dr3.Item("Purchase Invoice No").ToString

                'Find PurchaseID To Show In Textbox
                FindPurchaseIDToShowInTextbox()


                If Not TxtPurchaseID.Text = "" Then

                    'Set Temporaryly quantity =1
                    TxtQuantity.Text = "1"

                    'Insert or Update Into Purchase And Product Transfer
                    InsertorUpdateIntoPurchaseAndProductTransfer()

                    'FindTransferIDToShowInLable()

                    'Insert  Product Transfer Serial No
                    ' InsertIntoProductSerialTransferAndUpdatePurchaseSerialNumber()



                    'Update And Insert Into Purchase And Sale Serial Number
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd1.Connection = con
                    cmd.CommandText = "INSERT INTO [Product Serial Transfer] ([Product ID],[Transfer Invoice No],[Transfer Serial Number],[Status],[Branch ID],[Purchase ID],[Purchase Invoice No]) values ('" + cmbProductName.ValueMember + "','" + TxtProductTransferInvoiceNo.Text + "','" + CmbSerialNumber.Text + "','Transfer','" + CmbFromBranch.SelectedValue.ToString + "','" + AddedPurchaseID + "','" + PurchaseInvoiceNoForDeleteAndUpdateSerialNo + "')"
                    cmd1.CommandText = "Update [Purchase Serial Number] Set [Branch ID]='" + CmbToBranch.SelectedValue.ToString + "' where [Product ID]= '" + cmbProductName.ValueMember + "' And [Purchase Serial Number]= '" + CmbSerialNumber.Text + "'   INSERT INTO [Product Serial Transfer] ([Product ID],[Transfer Invoice No],[Transfer Serial Number],[Status],[Branch ID],[Purchase ID],[Purchase Invoice No]) values ('" + cmbProductName.ValueMember + "','" + TxtProductTransferInvoiceNo.Text + "','" + CmbSerialNumber.Text + "','Transfer','" + CmbFromBranch.SelectedValue.ToString + "','" + AddedPurchaseID + "','" + PurchaseInvoiceNoForDeleteAndUpdateSerialNo + "')"

                    'cmd.ExecuteNonQuery()
                    cmd1.ExecuteNonQuery()

                    con.Close()



                    'Refresh Product Transfer Serial Number 
                    RefreshDataSerialNumberToGridviewForCellMouseClick()

                    'Total Serial Inserted Row Count
                    TxtQuantity.Text = GrdAvailableSerialNumber.RowCount

                    'Insert Product Transfer
                    'If lblTransferID.Text = "00" Then

                    'TxtQuantity.Text = "00"


                    'Insert or Update Into Purchase And Product Transfer
                    InsertorUpdateIntoPurchaseAndProductTransfer()

                    'Find PurchaseID To Show In Textbox
                    'FindPurchaseIDToShowInTextbox()

                    'Find Transfer ID To Show In Lable
                    'FindTransferIDToShowInLable()

                End If

            Else

                MsgBox("No Available Serial Number", MsgBoxStyle.OkOnly, "Product Serial Transfer")
            End If

            dr3.Close()
            con3.Close()

        Catch ex As Exception
            MessageBox.Show("Error while insert and updating record on table..." & ex.Message, "Insert Into Product SerialTransfer Sub")

        End Try






    End Sub
    'Refresh Data Serial Number To Gridview Click
    Sub RefreshDataSerialNumberToGridviewForCellMouseClick()

        ' Load Data
        Try
            
            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT   [Product Serial Transfer].[Transfer Serial Number] FROM [Product Serial Transfer] WHERE [Transfer Invoice No] = '" + TxtProductTransferInvoiceNo.Text + "' And [Product ID]= '" + cmbProductName.ValueMember + "' And [Purchase ID]= '" + AddedPurchaseID + "' " 'and [Purchase Invoice No]='" + PurchaseInvoiceNoForDeleteAndUpdateSerialNo + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Product Serial Transfer")
            connection.Close()
            GrdAvailableSerialNumber.DataSource = ds
            GrdAvailableSerialNumber.DataMember = "BizPro_Product Serial Transfer"

            'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)


            GrdAvailableSerialNumber.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill





        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Data Serial Number To Gridview")
        Finally

        End Try

        'End Refresh Data
    End Sub
    'Refresh All Inserted Serial Number Of One Product For Range
    Sub RefreshAllInsertedSerialNumberOfOneProductForRange()

        ' Load Data
        Try
          

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT   [Product Serial Transfer].[Transfer Serial Number] FROM [Product Serial Transfer] WHERE [Transfer Invoice No] = '" + TxtProductTransferInvoiceNo.Text + "' And [Product ID]= '" + cmbProductName.ValueMember + "' And [Purchase ID]= '" + AddedPurchaseID + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Product Serial Transfer")
            connection.Close()
            GrdAvailableSerialNumber.DataSource = ds
            GrdAvailableSerialNumber.DataMember = "BizPro_Product Serial Transfer"

            'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)


            TxtQuantity.Text = GrdAvailableSerialNumber.Rows.Count


            GrdAvailableSerialNumber.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill





        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Data Serial Number To Gridview")
        Finally

        End Try

        'End Refresh Data
    End Sub

    'Find PurchaseID To Show InCombobox
    Sub FindTotalRangeSerial()

        Try

            Dim TL As Integer
            Dim FirstLength As String
            TL = Me.TxtFromSerial.TextLength - 4
            Me.TxtFromSerial.SelectionStart = 0
            Me.TxtFromSerial.SelectionLength = TL
            FirstLength = TL

            Dim First As String
            First = (Me.TxtFromSerial.SelectedText)


            'Find the Last Section of the from serial text box
            Dim s As String = Me.TxtFromSerial.Text
            Dim LastFrom As String
            LastFrom = (s.Substring(s.Length - 4))

            'Find the Last Section of the to serial text box
            Dim L As String = Me.TxtToSerial.Text
            Dim LastTo As String
            LastTo = (L.Substring(L.Length - 4))


            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now

            If TxtQuantity.Text = "" Or Val(TxtQuantity.Text) = 0 Or Not lblTransferID.Text = "00" Then
                TxtQuantity.Text = Val(TotalRangeSerialCount)
            End If

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            'Data reader for Product Id
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Select count([Purchase Serial Number].[Purchase Serial Number])[Transfer Serial Number]  From [Purchase Serial Number] Where [Purchase Serial Number].[Product ID]=   '" + cmbProductName.ValueMember + "'  And [Branch ID]='" + CmbFromBranch.SelectedValue.ToString + "' And [Purchase Serial Number].[Status]='Available' And left ([Purchase Serial Number].[Purchase Serial Number],'" + FirstLength + "' ) ='" + First + "' And RIGHT([Purchase Serial Number].[Purchase Serial Number], 4)  Between '" + LastFrom + "' And '" + LastTo + "' "
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then


                TotalRangeSerialCount = (dr.Item("Transfer Serial Number").ToString)



            End If

            dr.Close()
            con.Close()



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    'Insert And Update Into Sale Serial No And Purchase Serial No
    Sub RfreshDataRangeSerialTransferBeforeInsert()

        Try

            Dim TL As Integer
            Dim FirstLength As String
            TL = Me.TxtFromSerial.TextLength - 4
            Me.TxtFromSerial.SelectionStart = 0
            Me.TxtFromSerial.SelectionLength = TL
            FirstLength = TL

            Dim First As String
            First = (Me.TxtFromSerial.SelectedText)


            'Find the Last Section of the from serial text box
            Dim s As String = Me.TxtFromSerial.Text
            Dim LastFrom As String
            LastFrom = (s.Substring(s.Length - 4))

            'Find the Last Section of the to serial text box
            Dim L As String = Me.TxtToSerial.Text
            Dim LastTo As String
            LastTo = (L.Substring(L.Length - 4))


            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now

            If TxtQuantity.Text = "" Or Val(TxtQuantity.Text) = 0 Then
                TxtQuantity.Text = Val(TotalRangeSerialCount)
            End If

            ' Load Data
            

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "Select top " + TxtQuantity.Text + " [Purchase Serial Number].[Purchase Serial Number][Transfer Serial Number]  From [Purchase Serial Number] Where [Purchase Serial Number].[Product ID]=   '" + cmbProductName.ValueMember + "'  And [Branch ID]='" + CmbFromBranch.SelectedValue.ToString + "' And [Purchase Serial Number].[Status]='Available' And left ([Purchase Serial Number].[Purchase Serial Number],'" + FirstLength + "' ) ='" + First + "' And RIGHT([Purchase Serial Number].[Purchase Serial Number], 4)  Between '" + LastFrom + "' And '" + LastTo + "' "
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "Bizpro_Purchase Serial Number")
            connection.Close()
            GrdAvailableSerialNumber.DataSource = ds
            GrdAvailableSerialNumber.DataMember = "Bizpro_Purchase Serial Number"

            'GrdProductSubcategory.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductSubcategory.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            GrdAvailableSerialNumber.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            'Total Serial Number Count and show quantity in quantity text box
            'NUmberOfRowForQuantityCount()



            'Total Serial Number Count and show quantity in quantity text box
            TxtQuantity.Text = ((GrdAvailableSerialNumber.Rows.Count) + (TotalInsertedQuantity))

        Catch ex As Exception
            MessageBox.Show("Error while insert and updating record on table..." & ex.Message, "Insert Into Product SerialTransfer Sub")

        End Try






    End Sub
    'Total Serial Number Count and show quantity in quantity text box
    Sub NUmberOfRowForQuantityCount()
        Dim total As String = 0

        total = GrdAvailableSerialNumber.Rows.Count

        Me.TxtQuantity.Text = total


    End Sub



    'Insert Into Purchase Invoice code
    Sub InsertIntoPurchaseInvoice()




        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd2 As New SqlCommand
            Dim cmd3 As New SqlCommand
            Dim dr1 As SqlDataReader

            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now


            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO [Purchase Invoice] ([Memo No],[Total],[Previous Dues],[Advance],[Vat percentage],[Vat],[Discount Percentage],[Discount],[Net Payable],[Paid Amount],[Balance],[Return Amount],[Status],[Supplier ID],[Purchase Date],[Purchase Time],[User Account ID],[Computer ID],[Paid By],[Prepared Date]) values ('" + TxtProductTransferInvoiceNo.Text + "','00','00','00','00','00','00','00','00','00','00','00','TRANSFER','1','" + DtpTransferDate.Value + "','" + currentTime + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','00','" + currentDate + "')"
            cmd.ExecuteNonQuery()
            cmd2.Connection = con
            cmd2.CommandText = "Select * from [Purchase Invoice] Where [Memo No]='" + TxtProductTransferInvoiceNo.Text + "' And [Status]='TRANSFER'"

            dr1 = cmd2.ExecuteReader()
            dr1.Read()
            If dr1.HasRows Then


                PurchaseInvoiceNumber = (dr1.Item("Purchase Invoice No").ToString)
            End If
            dr1.Close()
            con.Close()



        Catch ex As Exception
            MessageBox.Show("Error while Inserting to Purchase invoice record on table..." & ex.Message, "Insert Records Purchase Invoice")
        Finally

        End Try



    End Sub

    Sub InsertIntoProductTransferInvoice()

        'Insert Into Product transfer Invoice code
        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim con2 As New SqlConnection
            Dim cmd2 As New SqlCommand
            Dim dr1 As SqlDataReader

            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now



            If TxtProductTransferInvoiceNo.Text = "" Then

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "INSERT INTO [Product Transfer Invoice] ([User Account ID],[Computer ID],[Prepared Time],[Prepared Date],[Branch ID],[Status],[Transfer Date]) values ('" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentTime + "','" + currentDate + "','" + FrmHome.lblBranchID.Text + "','Incomplete','" + DtpTransferDate.Value + "')"
                cmd.ExecuteNonQuery()
                con.Close()


                con2.ConnectionString = FrmHome.ConnectionString
                con2.Open()
                cmd2.Connection = con2
                cmd2.CommandText = "SELECT top 1 [Transfer Invoice No] FROM [Product Transfer Invoice] where [User Account ID]= '" + FrmHome.LblUserID.Text + "'  order by [Transfer Invoice No] desc"

                dr1 = cmd2.ExecuteReader()
                dr1.Read()
                If dr1.HasRows Then

                    TxtProductTransferInvoiceNo.Text = (dr1.Item("Transfer Invoice No").ToString)
                End If
                con2.Close()
                dr1.Close()

                'Insert into purchase Invoice number
                InsertIntoPurchaseInvoice()
            End If

        Catch ex As Exception
            MessageBox.Show("Error while Inserting to sale invoice record on table..." & ex.Message, "Insert Records Sale Invoice")
        Finally

        End Try



    End Sub

    Private Sub CmbSerialNumber_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CmbSerialNumber.MouseClick
        'Range Serial Number is checking off clicking serial number
        RdbRangeSerial.Checked = False
    End Sub
    Private Sub CmbSerialNumber_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSerialNumber.SelectedIndexChanged

    End Sub

    Private Sub GrdAvailableSerialNumber_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdAvailableSerialNumber.CellContentClick

    End Sub


    Private Sub GrdAvailableSerialNumber_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdAvailableSerialNumber.CellMouseDoubleClick
        Try

            If DeletePermission = "Yes" Then

                If e.RowIndex >= 0 Then

                    Dim row As DataGridViewRow
                    row = Me.GrdAvailableSerialNumber.Rows(e.RowIndex)


                    'Data Insert Code
                    Dim con As New SqlConnection
                    Dim con1 As New SqlConnection
                    Dim cmd As New SqlCommand
                    Dim cmd2 As New SqlCommand
                    Dim cmd3 As New SqlCommand
                    Dim currentDate As DateTime = DateTime.Today
                    Dim currentTime As DateTime = DateTime.Now

                    Dim dr As SqlDataReader


                    con1.ConnectionString = FrmHome.ConnectionString
                    con1.Open()
                    cmd3.Connection = con1
                    cmd3.CommandText = "SELECT *from [Purchase Serial Number]   where [Product ID]= '" + cmbProductName.ValueMember + "' And [Purchase Serial Number]='" + row.Cells("Transfer Serial Number").Value.ToString + "' And [Status]='Available' And [Branch ID]='" + CmbToBranch.SelectedValue.ToString + "' "

                    dr = cmd3.ExecuteReader()
                    dr.Read()

                    If dr.HasRows Then
                        'PurchaseInvoiceNoForDeleteAndUpdateSerialNo = dr.Item("Purchase Invoice No").ToString


                        'Update And Insert Into Purchase And Sale Serial Number
                        con.ConnectionString = FrmHome.ConnectionString
                        con.Open()
                        cmd.Connection = con
                        cmd2.Connection = con
                        cmd.CommandText = "Update [Purchase Serial Number] Set [Branch ID]='" + FrmHome.lblBranchID.Text + "'  where [Product ID]= '" + cmbProductName.ValueMember + "' And [Purchase Serial Number]= '" + row.Cells("Transfer Serial Number").Value.ToString + "'   Delete from [Product Serial Transfer] where [Product ID]= '" + cmbProductName.ValueMember + "' And [Transfer Serial Number]= '" + row.Cells("Transfer Serial Number").Value.ToString + "' And [Transfer Invoice No] = '" + TxtProductTransferInvoiceNo.Text + "'  "
                        cmd2.CommandText = "Delete from [Product Serial Transfer] where [Product ID]= '" + cmbProductName.ValueMember + "' And [Transfer Serial Number]= '" + row.Cells("Transfer Serial Number").Value.ToString + "' And [Transfer Invoice No] = '" + TxtProductTransferInvoiceNo.Text + "' "
                        cmd.ExecuteNonQuery()
                        'cmd2.ExecuteNonQuery()

                        con.Close()

                    End If
                    con1.Close()
                    dr.Close()

                    'Refresh Available serial Number
                    RefreshDataSerialNumberToGridviewForCellMouseClick()


                    'Total Serial Inserted Row Count
                    TxtQuantity.Text = GrdAvailableSerialNumber.RowCount

                    'Insert or Update Into Purchase And Product Transfer
                    InsertorUpdateIntoPurchaseAndProductTransfer()

                    'Refresh Product Transfer Data
                    RefreshDataProductTransfer()

                    'Load comboobx For serial Number
                    LoadComboBoxforSerialNumber()

                End If

            Else
                MsgBox("You do not have permission to delete product transfer.", MsgBoxStyle.Critical, "Product Transfer")
            End If

        Catch ex As Exception
            MessageBox.Show("Error while insert and updating record on table..." & ex.Message, "Update Into Purchase Serial Number Sub")
        End Try


    End Sub

    Private Sub TxtToSerial_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtToSerial.KeyDown
        If e.KeyCode = Keys.Enter Then
            'find total range serial and sent it to variable
            FindTotalRangeSerial()


            RfreshDataRangeSerialTransferBeforeInsert()

            BtnAdd.Focus()
        End If
    End Sub

    'Update And Insert Into Purchase And Product Serial Transfer
    Sub UpdateAndInsertIntoPurchaseAndProductSerialTransfer()
        Try
            'Data Insert Code
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now
            Dim cmd2 As New SqlCommand


            If CmbToBranch.Text = "" Then
                MsgBox("Please Select Branch To Transfer Your Product")
            Else

                InsertIntoProductTransferInvoice()

                Dim total As String = 0

                For i As Integer = 0 To GrdAvailableSerialNumber.RowCount - 1
                    total += GrdAvailableSerialNumber.Rows(i).Cells(0).Value





                    Dim con3 As New SqlConnection
                    Dim cmd3 As New SqlCommand
                    Dim dr3 As SqlDataReader

                    con3.ConnectionString = FrmHome.ConnectionString
                    con3.Open()
                    cmd3.Connection = con3
                    cmd3.CommandText = "SELECT *from [Purchase Serial Number] where [Product ID]= '" + cmbProductName.ValueMember + "' And [Purchase Serial Number]='" + GrdAvailableSerialNumber.Rows(i).Cells(0).Value.ToString + "' And [Status]='Available' And [Branch ID]='" + CmbFromBranch.SelectedValue.ToString + "' "

                    dr3 = cmd3.ExecuteReader()
                    dr3.Read()

                    If dr3.HasRows Then

                        PurchaseInvoiceNoForDeleteAndUpdateSerialNo = dr3.Item("Purchase Invoice No").ToString


                        con.ConnectionString = FrmHome.ConnectionString
                        con.Open()
                        cmd.Connection = con
                        cmd2.Connection = con
                        cmd.CommandText = "INSERT INTO [Product Serial Transfer] ([Product ID],[Transfer Invoice No],[Transfer Serial Number],[Status],[Branch ID],[Purchase ID]) values ('" + cmbProductName.ValueMember + "', '" + TxtProductTransferInvoiceNo.Text + "' ,'" + GrdAvailableSerialNumber.Rows(i).Cells(0).Value.ToString + "' ,'Transfer','" + CmbToBranch.SelectedValue.ToString + "','" + AddedPurchaseID + "')"
                        cmd2.CommandText = "Update [Purchase Serial Number] Set [Branch ID]='" + CmbToBranch.SelectedValue.ToString + "'  where [Product ID]= '" + cmbProductName.ValueMember + "' And [Purchase Serial Number]= '" + GrdAvailableSerialNumber.Rows(i).Cells(0).Value.ToString + "'   INSERT INTO [Product Serial Transfer] ([Product ID],[Transfer Invoice No],[Transfer Serial Number],[Status],[Branch ID],[Purchase ID],[Purchase Invoice No]) values ('" + cmbProductName.ValueMember + "','" + TxtProductTransferInvoiceNo.Text + "','" + GrdAvailableSerialNumber.Rows(i).Cells(0).Value.ToString + "','Transfer','" + CmbFromBranch.SelectedValue.ToString + "','" + AddedPurchaseID + "','" + PurchaseInvoiceNoForDeleteAndUpdateSerialNo + "')"

                        'cmd.ExecuteNonQuery()
                        cmd2.ExecuteNonQuery()


                        con.Close()


                    End If
                    con3.Close()
                    dr3.Close()
                Next

            End If

        Catch ex As Exception
            MessageBox.Show("Error while Marking record on table..." & ex.Message, "Update And Insert Into Purchase And SaleSerial Number")
        Finally

        End Try
    End Sub

    Private Sub TxtToSerial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtToSerial.TextChanged

    End Sub

    Private Sub TxtFromSerial_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtFromSerial.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtToSerial.Focus()
        End If
    End Sub

    Private Sub TxtFromSerial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtFromSerial.TextChanged

    End Sub

    Private Sub GrdSale_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdProductTransfer.CellContentClick

    End Sub

    Private Sub GrdSale_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdProductTransfer.CellMouseClick
        Try
            If e.RowIndex >= 0 Then

                Dim row As DataGridViewRow
                row = Me.GrdProductTransfer.Rows(e.RowIndex)

                cmbProductName.Enabled = False

                cmbProductName.Text = row.Cells("Product Name").Value.ToString
                TxtQuantity.Text = row.Cells("Transfer Quantity").Value.ToString
                lblTransferID.Text = row.Cells("Transfer ID").Value.ToString
                CmbToBranch.Text = row.Cells("Transfer To Branch").Value.ToString
                TxtQuantity.Focus()

                'cmbProductName.Enabled = False


                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim cmd1 As New SqlCommand
                Dim cmd2 As New SqlCommand
                Dim dr As SqlDataReader
                Dim dr2 As SqlDataReader

                'Data reader for Product Id
                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "SELECT  *FROM [Product Transfer]  WHERE [Transfer ID] = '" + row.Cells("Transfer ID").Value.ToString + "'"
                dr = cmd.ExecuteReader()
                dr.Read()
                If dr.HasRows Then


                    AddedPurchaseID = (dr.Item("Purchase ID").ToString)
                    Me.cmbProductName.ValueMember = (dr.Item("Product ID").ToString)
                    TxtPurchaseID.Text = (dr.Item("Purchase ID").ToString)
                    CmbLocationID.SelectedValue = (dr.Item("Location ID").ToString)
                    PurchaseInvoiceNoForDeleteAndUpdateSerialNo = (dr.Item("Purchase Invoice No").ToString)
                End If
                dr.Close()



                'Data reader for Available stock
                cmd1.Connection = con
                cmd2.Connection = con

                cmd2.CommandText = "select * from [Purchase] where [Purchase ID] = '" + TxtPurchaseID.Text + "'"

                dr2 = cmd2.ExecuteReader()
                dr2.Read()

                If dr2.HasRows Then

                    DeductedPurchaseID = (dr2.Item("Memo No").ToString)
                End If

                dr2.Close()
                con.Close()


                'Show Quantity in lable
                ShowQuantityInLable()

                'find total inserted quantity of selected product and send to variable
                ShowTotalInsertedQuantity()


                'Show Warranty Days
                SearchWarrantyDays()

                'Focus on product name
                cmbProductName.Focus()

                'Refresh Data Serial Number To Gridview  Click
                RefreshDataSerialNumberToGridviewForCellMouseClick()

                'Load Combo Box for Serial Number
                LoadComboBoxforSerialNumber()

                'Search Serial Status
                SearchSerialStatus()

            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview")

        End Try


    End Sub
    'find total inserted quantity of selected product and send to variable
    Sub ShowTotalInsertedQuantity()

        Try
            Dim con As New SqlConnection
            Dim cmd1 As New SqlCommand
            Dim dr1 As SqlDataReader

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd1.Connection = con
            cmd1.CommandText = "select isnull(sum([Added quantity]),0)[Total] from [Product Transfer] where [Transfer Invoice No]= '" + TxtProductTransferInvoiceNo.Text + "' and [Product ID]='" + cmbProductName.ValueMember + "'"

            dr1 = cmd1.ExecuteReader()
            dr1.Read()
            If dr1.HasRows Then


                TotalInsertedQuantity = (Val(dr1.Item("Total").ToString))
                TxtQuantity.Text = (Val(dr1.Item("Total").ToString))
            End If
            dr1.Close()
            con.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Refresh Data Serial Number To Gridview For Delete Button
    Sub RefreshDataSerialNumberToGridviewForDeleteInvoice()

        ' Load Data
        Try
             

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT   [Product Serial Transfer].[Product ID],[Product Serial Transfer].[Transfer Serial Number] FROM [Product Serial Transfer] WHERE [Transfer Invoice No] = '" + TxtProductTransferInvoiceNo.Text + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Product Serial Transfer")
            connection.Close()
            GrdAvailableSerialNumber.DataSource = ds
            GrdAvailableSerialNumber.DataMember = "BizPro_Product Serial Transfer"

            'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)


            GrdAvailableSerialNumber.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

 


        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Data Serial Number To Gridview")
        Finally

        End Try

        'End Refresh Data
    End Sub

    'Refresh And Update Branch ID In Purchase Serial Number
    Sub RefreshAndUpdateBranchIDInPurchaseSerialNumber()

        ' Load Data
        Try


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT   [Product Serial Transfer].[Product ID],[Product Serial Transfer].[Transfer Serial Number] FROM [Product Serial Transfer] WHERE  [Transfer Invoice No] = '" + TxtProductTransferInvoiceNo.Text + "' And [Product ID]= '" + cmbProductName.ValueMember + "' And [Purchase ID]= '" + AddedPurchaseID + "' " 'and [Purchase Invoice No]='" + PurchaseInvoiceNoForDeleteAndUpdateSerialNo + "' "
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Product Serial Transfer")
            connection.Close()
            GrdAvailableSerialNumber.DataSource = ds
            GrdAvailableSerialNumber.DataMember = "BizPro_Product Serial Transfer"

            'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)


            GrdAvailableSerialNumber.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill



            Dim con1 As New SqlConnection
            Dim cmd2 As New SqlCommand

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now

            Dim dr As SqlDataReader

            Dim total As String = 0

            For i As Integer = 0 To GrdAvailableSerialNumber.RowCount - 1
                total += GrdAvailableSerialNumber.Rows(i).Cells(0).Value & GrdAvailableSerialNumber.Rows(i).Cells(1).Value

                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd2.Connection = con1
                cmd2.CommandText = "SELECT *from [Purchase Serial Number] where [Product ID]= '" + GrdAvailableSerialNumber.Rows(i).Cells(0).Value.ToString + "' And [Purchase Serial Number]='" + GrdAvailableSerialNumber.Rows(i).Cells(1).Value.ToString + "' And [Status]='Available' And [Branch ID]='" + CmbToBranch.SelectedValue.ToString + "' "

                dr = cmd2.ExecuteReader()
                dr.Read()

                If dr.HasRows Then

                    PurchaseInvoiceNoForDeleteAndUpdateSerialNo = dr.Item("Purchase Invoice No").ToString



                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "Update [Purchase Serial Number] Set [Branch ID]='" + FrmHome.lblBranchID.Text + "' where [Product ID]= '" + GrdAvailableSerialNumber.Rows(i).Cells(0).Value.ToString + "' And [Purchase Serial Number]= '" + GrdAvailableSerialNumber.Rows(i).Cells(1).Value.ToString + "' "
                    cmd.ExecuteNonQuery()
                    con.Close()

                End If
                dr.Close()
                con1.Close()

            Next



        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Data Serial Number To Gridview")
        Finally

        End Try

        'End Refresh Data
    End Sub
    'Update Branch ID To Purchase Serial Number
    Sub UpdateBranchIDToPurchaseSerialNumber()




        Try
            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT   [Product Serial Transfer].[Product ID],[Product Serial Transfer].[Transfer Serial Number] FROM [Product Serial Transfer] WHERE [Transfer Invoice No] = '" + TxtProductTransferInvoiceNo.Text + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Product Serial Transfer")
            connection.Close()
            GrdAvailableSerialNumber.DataSource = ds
            GrdAvailableSerialNumber.DataMember = "BizPro_Product Serial Transfer"

            'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)


            GrdAvailableSerialNumber.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


            Dim con As New SqlConnection
            Dim con1 As New SqlConnection
            Dim cmd As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now
            Dim cmd2 As New SqlCommand

            Dim dr As SqlDataReader

            Dim total As String = 0

            For i As Integer = 0 To GrdAvailableSerialNumber.RowCount - 1
                total += GrdAvailableSerialNumber.Rows(i).Cells(0).Value & GrdAvailableSerialNumber.Rows(i).Cells(1).Value

                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd2.Connection = con1
                cmd2.CommandText = "SELECT *from [Purchase Serial Number] where [Product ID]= '" + GrdAvailableSerialNumber.Rows(i).Cells(0).Value.ToString + "' And [Purchase Serial Number]='" + GrdAvailableSerialNumber.Rows(i).Cells(1).Value.ToString + "' And [Status]='Available' And [Branch ID]='" + CmbToBranch.SelectedValue.ToString + "' "

                dr = cmd2.ExecuteReader()
                dr.Read()

                If dr.HasRows Then

                    PurchaseInvoiceNoForDeleteAndUpdateSerialNo = dr.Item("Purchase Invoice No").ToString


                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = " Update [Purchase Serial Number] Set [Branch ID]='" + FrmHome.lblBranchID.Text + "'  where [Product ID]= '" + GrdAvailableSerialNumber.Rows(i).Cells(0).Value.ToString + "' And [Purchase Serial Number]= '" + GrdAvailableSerialNumber.Rows(i).Cells(1).Value.ToString + "' "
                    cmd.ExecuteNonQuery()

                    con.Close()
                End If
                dr.Close()
                con1.Close()

            Next

        Catch ex As Exception
            MessageBox.Show("Error while Updating record on table..." & ex.Message, "Update Records Purchase Serial")
        Finally

        End Try
        'Update Purchase Invoice
    End Sub
    'Delete Stock From Purchase And Purchase Invoice
    Sub DeleteFromPurchaseAndPurchaseInvoice()


        Try

            Dim con As New SqlConnection
            Dim con1 As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd2 As New SqlCommand
            Dim cmd3 As New SqlCommand
            Dim dr1 As SqlDataReader

            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now


            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd2.Connection = con
            cmd2.CommandText = "Select * from [Purchase Invoice] Where [Memo No]='" + TxtProductTransferInvoiceNo.Text + "' And [Status]='TRANSFER'"

            dr1 = cmd2.ExecuteReader()
            dr1.Read()
            If dr1.HasRows Then


                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd.Connection = con1
                cmd3.Connection = con1
                cmd.CommandText = "Delete From [Purchase] Where [Purchase Invoice No]= '" + (dr1.Item("Purchase Invoice No").ToString) + "' "
                cmd3.CommandText = "Delete From [Purchase Invoice] Where [Purchase Invoice No]= '" + (dr1.Item("Purchase Invoice No").ToString) + "' "
                dr1.Close()

                cmd.ExecuteNonQuery()
                cmd3.ExecuteNonQuery()
                con1.Close()
            End If
            dr1.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while Updating record on table..." & ex.Message, "Delete Stock From  Purchase")
        Finally

        End Try
        'Update Purchase Invoice
    End Sub
    'Delete From Sale Serial Number
    Sub DeleteFromProductTransferSerialNumber()


        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Delete from [Product Serial Transfer] where [Transfer Invoice No]= '" + TxtProductTransferInvoiceNo.Text + "'"
            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Records Sale Serial")
        Finally

        End Try
        'Update Purchase Invoice
    End Sub

    ' Delete Full Invoice
    Sub DeleteFullInvoice()

        Try



            'Delete Stock From Purchase And Purchase Invoice
            DeleteFromPurchaseAndPurchaseInvoice()



            Dim con2 As New SqlConnection

            Dim cmd1 As New SqlCommand
            Dim cmd2 As New SqlCommand

            Dim currentdate As DateTime = DateTime.Today
            Dim CurrentTime As DateTime = DateTime.Now


            con2.ConnectionString = FrmHome.ConnectionString
            con2.Open()
            cmd2.Connection = con2
            cmd1.Connection = con2
            cmd2.CommandText = "Delete from [Product Transfer] where [Transfer Invoice No]= '" + TxtProductTransferInvoiceNo.Text + "'"
            cmd1.CommandText = "Delete from [Product Transfer Invoice] where [Transfer Invoice No]= '" + TxtProductTransferInvoiceNo.Text + "'"
            cmd2.ExecuteNonQuery()
            cmd1.ExecuteNonQuery()
            con2.Close()




            'Update Branch ID To Purchase Serial Number
            UpdateBranchIDToPurchaseSerialNumber()


            'Delete From Product Transfer Serial Number
            DeleteFromProductTransferSerialNumber()

            'Clear all data
            ClearAllData()



            GrdAvailableSerialNumber.Columns.Clear()
            GrdProductTransfer.Columns.Clear()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Try




            If Not TxtProductTransferInvoiceNo.Text = "" Then

                Dim q As MsgBoxResult
                q = MsgBox("Do you really want to Delete Invoice?", MsgBoxStyle.YesNo, "Product Transfer")
                If q = MsgBoxResult.Yes Then

                    'Insert into log code For Delete
                    InsertIntoLogForDelete()

                    ' Delete Full Invoice
                    DeleteFullInvoice()


                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try
    End Sub
    'Insert into log code For Delete
    Sub InsertIntoLogForDelete()

        'Data Insert Code
        Dim con As New SqlConnection
        Dim con1 As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim dr As SqlDataReader
        Dim CurrentDate As DateTime = DateTime.Today
        Dim CurrentTime As DateTime = DateTime.Now

        Dim TransferDetails As String
        Dim BillStatus As String

        Try
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd2.Connection = con
            cmd.CommandText = "Select SUBSTRING( ( SELECT   '-------'+  [Product Name],'  Transfered Quantity : ',isnull(sum([Product Transfer].[Added Quantity]),0),'  Transfer To Branch : ', isnull(([Product Transfer].[Transfer Branch ID]),0),'  Transfer from  Branch : " + FrmHome.lblBranchID.Text + "'      FROM [Product Transfer] join products on [Product Transfer].[Product ID]=products.[Product ID]  where [Transfer Invoice No]='" + TxtProductTransferInvoiceNo.Text + "' and [Status]='Added'  group by [Product Transfer].[Transfer Branch ID],products.[Product Name] FOR XML PATH('') ), 2 , 9999) As [Transfer Details]"
            cmd2.CommandText = "Select [Status] From [Product Transfer Invoice] Where [Transfer Invoice No]='" + TxtProductTransferInvoiceNo.Text + "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                TransferDetails = dr.Item("Transfer Details").ToString

            End If
            dr.Close()


            'Data Reader For Find invoice Status
            dr = cmd2.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                BillStatus = dr.Item("Status").ToString

            End If
            dr.Close()
            con.Close()


            con1.ConnectionString = FrmHome.ConnectionString
            con1.Open()
            cmd1.Connection = con1
            cmd1.CommandText = "INSERT INTO [Log Details]  ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES('" + Me.Text + "','DELETE','Transfer Details :( " + TransferDetails + ") by " + FrmHome.LblUserName.Text + "  , Bill Status : " + BillStatus + "' ,'" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtProductTransferInvoiceNo.Text + "' )"
            cmd1.ExecuteNonQuery()
            con1.Close()



        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally


        End Try
    End Sub
    'Insert into log code For Save
    Sub InsertIntoLogForSave()

        'Data Insert Code
        Dim con As New SqlConnection
        Dim con1 As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim dr As SqlDataReader
        Dim CurrentDate As DateTime = DateTime.Today
        Dim CurrentTime As DateTime = DateTime.Now

        Dim TransferDetails As String

        Try
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Select SUBSTRING( ( SELECT   '-------'+  [Product Name],'  Transfered Quantity : ',isnull(sum([Product Transfer].[Added Quantity]),0),'  Transfer To Branch : ', isnull(([Product Transfer].[Transfer Branch ID]),0),'  Transfer from  Branch : " + FrmHome.lblBranchID.Text + "'      FROM [Product Transfer] join products on [Product Transfer].[Product ID]=products.[Product ID]  where [Transfer Invoice No]='" + TxtProductTransferInvoiceNo.Text + "' and [Status]='Added'  group by [Product Transfer].[Transfer Branch ID],products.[Product Name] FOR XML PATH('') ), 2 , 9999) As [Transfer Details]"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                TransferDetails = dr.Item("Transfer Details").ToString

            End If
            dr.Close()
            con.Close()


            con1.ConnectionString = FrmHome.ConnectionString
            con1.Open()
            cmd1.Connection = con1
            cmd1.CommandText = "INSERT INTO [Log Details]  ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES('" + Me.Text + "','INSERT','Transfer Details :( " + TransferDetails + ") by " + FrmHome.LblUserName.Text + "' ,'" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtProductTransferInvoiceNo.Text + "' )"
            cmd1.ExecuteNonQuery()
            con1.Close()



        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally


        End Try
    End Sub

    Private Sub BtnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        If CmbFromBranch.Text = "" Then
            MsgBox("Please select branch first.", MsgBoxStyle.OkOnly, "Product Transfer")
        Else

            Dim q As MsgBoxResult
            q = MsgBox("Do you really want to Save?", MsgBoxStyle.YesNo, "Product Transfer")
            If q = MsgBoxResult.Yes Then


                'Insert into log code For Save
                InsertIntoLogForSave()


                'Purchase For Add Quantit

                'Update Transfer Invoice Incomplete To Complete
                UpdateTransferInvoiceIncompleteToComplete()


                'Send invoice no to report
                RptProductTransferInvoice.InvoiceNo = Me.TxtProductTransferInvoiceNo.Text




                'Making Clear
                ClearAllData()


                'Open Invoice
                RptProductTransferInvoice.ShowProductTransferInvoice()
                RptProductTransferInvoice.Show()
            End If
        End If
    End Sub

    'Find Transfer ID To Show In Lable
    Sub FindTransferIDToShowInLable()

        Try



            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand
            Dim dr As SqlDataReader
            Dim dr1 As SqlDataReader



            'Data reader for Product Id
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Product Transfer]  WHERE [Purchase ID] = '" + AddedPurchaseID + "' And [Transfer Invoice No]= '" + TxtProductTransferInvoiceNo.Text + "' And [Status]='Added' And [Purchase Invoice No]='" + PurchaseInvoiceNoForDeleteAndUpdateSerialNo + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then


                ' lblTransferID.Text = (dr.Item("Transfer ID").ToString)
                TxtPurchaseID.Text = (dr.Item("Purchase ID").ToString)

            End If

            dr.Close()

            cmd1.Connection = con
            cmd1.CommandText = "select * from [Purchase] where [Purchase ID] = '" + AddedPurchaseID + "' "
            dr1 = cmd1.ExecuteReader()
            dr1.Read()

            If dr1.HasRows Then

                DeductedPurchaseID = (dr1.Item("Memo No").ToString)

            End If

            dr1.Close()
            con.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    'Find Added Purchase ID
    Sub FindAddedPurchaseID()

        Try



            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand
            Dim dr As SqlDataReader



            'Data reader for Product Id
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Purchase]  WHERE   [Memo No]= '" + TxtPurchaseID.Text + "' And SUBSTRING([Transfer Status],10,LEN([Transfer Status])-2)='" + PurchaseInvoiceNoForDeleteAndUpdateSerialNo + "' and [Purchase Invoice No]='" + NewPurchaseInvoiceInsertedForProductTransfer + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                ' lblTransferID.Text = (dr.Item("Transfer ID").ToString)
                AddedPurchaseID = (dr.Item("Purchase ID").ToString)

            End If

            dr.Close()
            con.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    'Find Transfer ID To Show In Lable While Selecting New Product
    Sub FindTransferIDToShowInLableWhileSelectingNewProduct()

        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand
            Dim dr As SqlDataReader
            Dim dr1 As SqlDataReader

            'Data reader for Product Id
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Product Transfer]  WHERE  [Product ID] = '" + cmbProductName.ValueMember + "' And [Transfer Invoice No]= '" + TxtProductTransferInvoiceNo.Text + "' And [Status]='Added'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                lblTransferID.Text = (dr.Item("Transfer ID").ToString)
                TxtPurchaseID.Text = (dr.Item("Purchase ID").ToString)
            End If
            dr.Close()

            cmd1.Connection = con
            cmd1.CommandText = "select * from [Product Transfer] where  [Product ID]='" + cmbProductName.ValueMember + "' And [Transfer Invoice No] = '" + Me.TxtProductTransferInvoiceNo.Text + "' And [Status] = 'Deducted' "
            dr1 = cmd1.ExecuteReader()
            dr1.Read()

            If dr1.HasRows Then

                DeductedPurchaseID = (dr1.Item("Purchase ID").ToString)

            End If
            dr1.Close()


            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    'Update Transfer Invoice Incomplete To Complete
    Sub UpdateTransferInvoiceIncompleteToComplete()

        Try


            'Update Sale Invoice
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand



            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "UPDATE  [Product Transfer Invoice] Set [Status]= 'Complete',[Transfer Date]='" + DtpTransferDate.Value + "' where [Transfer Invoice No] ='" + TxtProductTransferInvoiceNo.Text + "' update [Product Transfer] set [Transfer Branch ID]='" + CmbToBranch.SelectedValue.ToString + "'  Where [Transfer Invoice No]='" + TxtProductTransferInvoiceNo.Text + "' and [Status]='Added'"
            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while Updating record on table..." & ex.Message, "Update Sale Invoice Sub")
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click


        If Not TxtProductTransferInvoiceNo.Text = "" And Not ProductTransferEditStatus = True Then

            Dim q As MsgBoxResult = MsgBox("Do you want to keep this Invoice as draft?", MsgBoxStyle.YesNoCancel, "Product Transfer")

            If q = MsgBoxResult.No Then

                'Delete Full Invoice
                DeleteFullInvoice()

            ElseIf q = MsgBoxResult.Yes Then

                'Clear All Data
                ClearAllData()


            End If

        ElseIf Not TxtProductTransferInvoiceNo.Text = "" And ProductTransferEditStatus = True Then

            If (MessageBox.Show(" Are you sure want to creat new invoice?", "Bizpro", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then


                'Clear All Data
                ClearAllData()



            End If

        End If



    End Sub
    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)




    End Sub
    'Update Into Product Transfer code
    Sub UpdateIntoProductTransferOld()



        'Data Insert Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim cmd3 As New SqlCommand
        Dim cmd4 As New SqlCommand
        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now

        Try


            'Empty Txt Box Can Not Be Save Code
            If CmbFromBranch.SelectedValue = 0 Or CmbToBranch.SelectedValue = 0 Or cmbProductName.ValueMember = "" Or cmbProductName.Text = "" Or TxtPurchaseID.Text = "" Or TxtQuantity.Text = "" Or CmbLocationID.SelectedValue = 0 Then
                MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Product Transfer")
            Else


                con.ConnectionString = FrmHome.ConnectionString
                con.Open()

                cmd.Connection = con
                cmd.CommandText = "Update [Product Transfer] Set  [Added Quantity]='" + TxtQuantity.Text + "',[Deducted Quantity]='00',[Transfer Branch ID]='" + CmbToBranch.SelectedValue.ToString + "' where [Purchase ID]='" + TxtPurchaseID.Text + "'  And [Transfer Invoice No]='" + TxtProductTransferInvoiceNo.Text + "' And [Status]='Added'"
                cmd.ExecuteNonQuery()

                cmd2.Connection = con
                cmd2.CommandText = "Update [Product Transfer] Set  [Added Quantity]='00',[Deducted Quantity]='" + TxtQuantity.Text + "',[Transfer Branch ID]='" + CmbFromBranch.SelectedValue.ToString + "' where [Purchase ID]='" + DeductedPurchaseID + "'  And [Transfer Invoice No]='" + TxtProductTransferInvoiceNo.Text + "' And [Status]='Deducted'"
                cmd2.ExecuteNonQuery()

                cmd3.Connection = con
                cmd3.CommandText = "Update [Purchase] Set  [Purchase Location ID]='" + CmbLocationID.SelectedValue.ToString + "',[Purchase Unit Cost]='" + PurchaseUnitCost + "',[Branch ID]='" + CmbToBranch.SelectedValue.ToString + "'  where [Purchase ID]='" + TxtPurchaseID.Text + "'"
                cmd3.ExecuteNonQuery()

                con.Close()






            End If


        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Or Update Records")
        Finally


        End Try


    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHistory.Click
        FrmProductTransferHistory.Show()
        FrmProductTransferHistory.TxtSearchInvoice.Focus()
    End Sub

    Private Sub GrdProductTransfer_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdProductTransfer.CellMouseDoubleClick
        Try
            If DeletePermission = "Yes" Then

                Dim q As MsgBoxResult
                q = MsgBox("Do you really want to Delete This Product?", MsgBoxStyle.YesNo, "Product Transfer")
                If q = MsgBoxResult.Yes Then

                    'Data Insert Code
                    Dim con As New SqlConnection
                    Dim cmd As New SqlCommand
                    Dim cmd2 As New SqlCommand
                    Dim cmd3 As New SqlCommand
                    Dim cmd4 As New SqlCommand
                    Dim currentDate As DateTime = DateTime.Today
                    Dim currentTime As DateTime = DateTime.Now


                    'Refresh And Update Branch ID In Purchase Serial Number
                    RefreshAndUpdateBranchIDInPurchaseSerialNumber()


                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd2.Connection = con
                    cmd3.Connection = con
                    cmd4.Connection = con
                    cmd.CommandText = "Delete From [Product Transfer]  where [Purchase ID]='" + DeductedPurchaseID + "'  And [Transfer Invoice No]='" + TxtProductTransferInvoiceNo.Text + "' " 'and [Purchase Invoice No]='" + PurchaseInvoiceNoForDeleteAndUpdateSerialNo + "'"
                    cmd3.CommandText = "Delete From [Purchase]  where [Purchase ID]='" + AddedPurchaseID + "'"
                    cmd4.CommandText = "Delete From [Product Transfer]  where [Purchase ID]='" + AddedPurchaseID + "'  And [Transfer Invoice No]='" + TxtProductTransferInvoiceNo.Text + "'" '  and [Purchase Invoice No]='" + PurchaseInvoiceNoForDeleteAndUpdateSerialNo + "'"

                    cmd2.CommandText = "Delete From [Product Serial Transfer]  where [Product ID]='" + cmbProductName.ValueMember + "'  And [Transfer Invoice No]='" + TxtProductTransferInvoiceNo.Text + "' And [Purchase ID]='" + AddedPurchaseID + "'"
                    cmd.ExecuteNonQuery()
                    cmd2.ExecuteNonQuery()
                    cmd3.ExecuteNonQuery()
                    cmd4.ExecuteNonQuery()



                    con.Close()

                    'Clear Data
                    cleardataProduct()

                    'Refresh Data Product Transfer
                    RefreshDataProductTransfer()


                    'Load combobox for serial number 
                    LoadComboBoxforSerialNumber()
                End If
            Else
                MsgBox("You do not have permission to delete product transfer.", MsgBoxStyle.Critical, "Product Transfer")
            End If

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Or Update Records")
        Finally


        End Try






    End Sub

    Private Sub CmbLocationID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbLocationID.KeyDown

    End Sub

    Private Sub CmbLocationID_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CmbLocationID.MouseClick

    End Sub
    Private Sub CmbLocationID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbLocationID.SelectedIndexChanged
        cmbProductName.Focus()
    End Sub

    Private Sub TxtWarrantyDays_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtWarrantyDays.TextChanged

    End Sub
    'Privet sub for Warranty days 
    Sub SearchWarrantyDays()

        Try



            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Purchase]  WHERE [Purchase ID] = '" + TxtPurchaseID.Text + "' and [Product ID]= '" + cmbProductName.ValueMember + "' "

            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                TxtWarrantyDays.Text = (dr.Item("Warranty Days").ToString)

            End If

            dr.Close()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnAdd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub BtnInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInvoice.Click

        'Send invoice no to report
        RptProductTransferInvoice.InvoiceNo = Me.TxtProductTransferInvoiceNo.Text


        'Open Invoice
        RptProductTransferInvoice.ShowProductTransferInvoice()
        RptProductTransferInvoice.Show()
    End Sub



    Private Sub BtnSave_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BtnSave.KeyDown

    End Sub
    'Find PurchaseID To Show InCombobox
    Sub FindPurchaseIDToShowInCombobox()

        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            'Data reader for Product Id
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "select top 1 [Purchase Date],[Purchase ID],[Supplier Name],[Product ID],[Product Name],[Branch Name],[Purchase Cost],[Sale Price],(isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))[Stock Available]from (select [Purchase].[Purchase Date],Purchase.[Purchase ID],[Supplier Information].[Supplier Name],[Products].[Product ID],[Products].[Product Name],[Branch Information].[Branch Name],[Branch Information].[Branch ID],Purchase.[Purchase Unit Cost][Purchase Cost],[Products].[Sale Price],case when [Purchase Quantity] =0  then (select isnull(sum( [Added Quantity]),0)[Added Quantity] from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  [Product Transfer].[Purchase ID]=Purchase.[Purchase ID] and [Product Transfer].Status='Added' and   [Product Transfer Invoice].Status='Complete'  and [Product Transfer].[Product ID]=Purchase.[Product ID]  group by [Purchase ID] )  ELSE isnull([Purchase].[Purchase Quantity],0) end [Purchase] ,(select isnull(sum([Sale Quantity]),0)      from  sale join [Sale Invoice] on sale.[Sale Invoice No]= [Sale Invoice].[Sale Invoice No] where Sale.[Branch ID]='" + FrmHome.lblBranchID.Text + "' and Sale.[Purchase ID]=Purchase.[Purchase ID]  group by [Purchase ID])[Sale],(select isnull(sum([Returned Quantity]),0)  from [Sale Return] join [Sale Return Invoice] on [Sale Return].[Sale Return Invoice No]=[Sale Return Invoice].[Sale Return Invoice No] where  [Sale Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Sale Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Sale Return],(select isnull(sum([Returned Quantity]),0)  from [Purchase Return] join [Purchase Return Invoice] on [Purchase Return].[Purchase Return Invoice No]=[Purchase Return Invoice].[Purchase Return Invoice No] where [Purchase Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Purchase Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Purchase Return], (select isnull(sum([Deducted Quantity]),0)  from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  Purchase.[Purchase ID]=[Product Transfer].[Purchase ID] and [Product Transfer].Status='Deducted'     group by [Purchase ID] )[Deducted]from Purchase  join Products on Purchase.[Product ID]=products.[Product ID]  join [Branch Information] on [Purchase].[Branch ID]=[Branch Information].[Branch ID]	  Join [Purchase Invoice] on [Purchase Invoice].[Purchase Invoice No]=[Purchase].[Purchase Invoice No] join [Supplier Information] on [Purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID] Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID]  Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID]  Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID]    where Purchase.[Branch ID]='" + FrmHome.lblBranchID.Text + "' And Products.[Product ID] ='" + cmbProductName.ValueMember + "'  ) as a   group by [Purchase Date],[Purchase ID],[Supplier Name],[Branch Name],[Product ID],[Product Name],[Purchase Cost],[Sale Price] having (isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))>0 order by [Purchase Date] asc "
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                TxtPurchaseID.Text = (dr.Item("Purchase ID").ToString)




                lblQuantity.Text = (dr.Item("Stock Available").ToString)



            End If

            dr.Close()
            con.Close()



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    'Insert Into Product Transfer By Loop
    Sub InsertIntoProductTransferByLoop()

        Try

            Dim con As New SqlConnection
            Dim con1 As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand
            Dim cmd2 As New SqlCommand

            Dim dr As SqlDataReader


            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now




            'Data reader for Product Id
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd1.Connection = con
            cmd.Connection = con
            cmd.CommandText = "SELECT  isnull(sum([Added Quantity]),0)[Transfer quantity]  FROM [Product Transfer]  WHERE  [Product ID]='" + cmbProductName.ValueMember + "' And [Transfer Invoice No]= '" + TxtProductTransferInvoiceNo.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then


                If Val(dr.Item("Transfer Quantity").ToString) < Val(QuantityWritten) Then

                    'Find Purchase ID To Show In TextBox
                    FindPurchaseIDToShowInCombobox()

                    'Search Purchase Invoice No 
                    SearchPurchaseInvoiceNoForPurchaseReturn()

                    Dim QuantityRemaining As String
                    QuantityRemaining = Val(QuantityWritten) - Val(dr.Item("Transfer Quantity").ToString)

                    If Val(lblQuantity.Text) > Val(QuantityRemaining) Then
                        TxtQuantity.Text = QuantityRemaining


                    Else
                        TxtQuantity.Text = Val(lblQuantity.Text)
                    End If

                    If Not TxtProductTransferInvoiceNo.Text = "" Then


                        'Insert Into Purchase And Product Transfer
                        InsertIntoPurchaseAndProductTransferForRangeSerial()




                        If RdbRangeSerial.Checked = True Then
                            'Insert And Update Into Sale Serial No And Purchase Serial No
                            RfreshDataRangeSerialTransferBeforeInsert()

                            'Update And Insert Into Purchase And Product Serial Transfer
                            UpdateAndInsertIntoPurchaseAndProductSerialTransfer()
                        End If


                    End If
                End If

                TransferQuantity = Val(dr.Item("Transfer Quantity").ToString)

            ElseIf Not dr.HasRows Then
                TxtQuantity.Text = Val(lblQuantity.Text)


                If Not TxtProductTransferInvoiceNo.Text = "" Then



                    'Insert Into Purchase And Product Transfer
                    InsertIntoPurchaseAndProductTransferForRangeSerial()



                    If RdbRangeSerial.Checked = True Then
                        'Insert And Update Into Sale Serial No And Purchase Serial No
                        RfreshDataRangeSerialTransferBeforeInsert()

                        'Update And Insert Into Purchase And Product Serial Transfer
                        UpdateAndInsertIntoPurchaseAndProductSerialTransfer()

                    End If

                End If
                TransferQuantity = Val(dr.Item("Transfer Quantity").ToString)
            End If




            dr.Close()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Button1_Click_4(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click

        'Insert Purchase Serial Number
        If TxtProductTransferInvoiceNo.Text = "" Then
            InsertIntoProductTransferInvoice()


        End If


        If Not TxtProductTransferInvoiceNo.Text = "" Then

            'Total Quantity to insert is Sending to veriable
            QuantityWritten = TxtQuantity.Text


            If LblStatus.Text = "Not Available" Then

                If Val(TotalInsertedQuantity) <> Val(QuantityWritten) Then

                    'Delete Non Serial Product For Update
                    DeleteNonSerialProductForUpdate()

                    'find total inserted quantity of selected product and send to variable
                    ShowTotalInsertedQuantity()

                End If


                Do Until Val(TransferQuantity) >= Val(QuantityWritten)

                    InsertIntoProductTransferByLoop()

                Loop


            ElseIf LblStatus.Text = "Available" And RdbRangeSerial.Checked = True Then



                Do Until Val(TransferQuantity) >= Val(QuantityWritten)

                    InsertIntoProductTransferByLoop()

                Loop



            ElseIf LblStatus.Text = "Available" And RdbRangeSerial.Checked = False Then
                'Clear Data Product
                cleardataProduct()
            Else
                MsgBox("Please insert serial number", MsgBoxStyle.Critical, "Product Transfer")
            End If

            If Val(TransferQuantity) >= Val(QuantityWritten) Then

                'Clear Data Products
                cleardataProduct()


            End If
        End If


        'Load ComboBox for Serial Number()
        LoadComboBoxforSerialNumber()
        cmbProductName.Focus()

    End Sub



    'Delete Non Serial Product For Update
    Sub DeleteNonSerialProductForUpdate()


        Try
            'Data Insert Code
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Delete From [Product Transfer]  where [Product ID]='" + cmbProductName.ValueMember + "'  And [Transfer Invoice No]='" + TxtProductTransferInvoiceNo.Text + "' "
            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Panel2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseMove
        'If e.Button = Windows.Forms.MouseButtons.Left Then
        'newpoint = Control.MousePosition
        'newpoint.X -= (X)
        'newpoint.Y -= (Y)
        'Me.Location = newpoint

        'End If
    End Sub



    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Btnminimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnminimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Btnmaximized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnmaximized.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal

        Else
            Me.WindowState = FormWindowState.Maximized

        End If
    End Sub

    Private Sub Btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnclose.Click
        Me.Close()
    End Sub
End Class
