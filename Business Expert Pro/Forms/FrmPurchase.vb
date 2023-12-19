Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class FrmPurchase
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point
    Dim CustomerChartOfAccountIDForUpdateLedger As String
    Public PreviousPaidbyID As String
    Dim FirstValue As String
    Dim LastFromValue As String
    Dim LastToValue As String
    Dim ShowInvoicePermision As String
    Dim DeletePermission As String

    Public PurchaseEditStatus As Boolean





    Private Sub FrmPurchase_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Attention mesasge for form close
        ' If (MessageBox.Show(" Do you really want to Close?", "Bizpro", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No) Then
        'e.Cancel = True

        ' End If

        If Not TxtPurchaseInvoiceNo.Text = "" And Not PurchaseEditStatus = True Then

            Dim q As MsgBoxResult = MsgBox("Do you want to keep this Invoice as draft?", MsgBoxStyle.YesNoCancel, "Purchase")

            If q = MsgBoxResult.No Then

                'Insert into log code For Delete
                InsertIntoLogForDelete()

                'Delete Full Invoice
                DeleteFullInvoice()
            ElseIf q = MsgBoxResult.Cancel Then
                e.Cancel = True
            End If
        ElseIf Not TxtPurchaseInvoiceNo.Text = "" And PurchaseEditStatus = True Then
            If (MessageBox.Show(" Do you really want to Close?", "Bizpro", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No) Then

                e.Cancel = True


            End If


        End If
    End Sub
    Private Sub FrmPurchase_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown




    End Sub


    Private Sub FrmPurchase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 0)
        Me.Size = My.Computer.Screen.WorkingArea.Size

        'permission for update and Delete
        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand
            Dim dr As SqlDataReader
            Dim dr1 As SqlDataReader

            Dim MyFormName As Form = CType(sender, Form)



            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd1.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + FrmHome.LblUserID.Text + "' AND [Category Name] = '" + MyFormName.Text + "' And  [Update Delete Permission]='Yes'"
            cmd1.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + FrmHome.LblUserID.Text + "' AND [Category Name] = 'VIEW PRICE PERMISSION' And [Update Delete Permission]='YES'"


            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then
                BtnDelete.Enabled = True

                TxtPaidAmount.ReadOnly = False
                TxtBalance.ReadOnly = False
                TxtReturnAmount.ReadOnly = False

                DeletePermission = "Yes"

            ElseIf Not dr.HasRows Then

                BtnDelete.Enabled = False

                TxtPaidAmount.ReadOnly = True
                TxtBalance.ReadOnly = True
                TxtReturnAmount.ReadOnly = True

                TxtPaidAmount.Text = "00"


            End If

            dr.Close()




            'Permission For Show Purchase Price
            dr1 = cmd1.ExecuteReader()
            dr1.Read()

            If Not dr1.HasRows Then

                ShowInvoicePermision = "No"

                TxtPurchaseUnitCost.PasswordChar = "*"
                TxtPurchaseAmount.PasswordChar = "*"
                TxtTotal.PasswordChar = "*"
                TxtNetPayable.PasswordChar = "*"
                TxtPaidAmount.PasswordChar = "*"
                TxtBalance.PasswordChar = "*"

            End If
            dr1.Close()
            con.Close()



        Catch ex As Exception
            MessageBox.Show("Error while  permission delete to form..." & ex.Message, "Form Load")

        End Try

        'Load ComboBox for Supplier()
        'LoadComboBoxforSupplier()

        'Load ComboBox For Payment Method
        LoadComboBoxForPaymentMethod()

        'clearData
        cleardataSupplier()

        'Change Language
        ChangeLanguage()

       

        'Date time auto today
        DtpPurchaseDate.Value = Now


        'New Purchase Invoice
        Newinvoice()



    End Sub
    'Clear Supplier Name
    Sub cleardataSupplier()



        CmbSupplierName.ValueMember = ""
        CmbSupplierName.Text = ""


        TxtPhoneNo.Text = ""
        TxtAddress.Text = ""
        TxtSupplierDiscount.Text = ""

    End Sub

    'Clear only product data
    Sub cleardataProduct()

        CmbProductName.Text = ""
        CmbProductName.ValueMember = ""

        CmbLocationID.Text = ""
        CmbLocationID.ValueMember = ""
        TxtSerialNumber.Text = ""
        TxtQuantity.Text = ""
        TxtPurchaseUnitCost.Text = ""
        TxtPurchaseAmount.Text = ""
        LblPurchaseID.Text = "00"
        'lblQuantity.Text = "00"

        TxtSerialNumber.Text = ""

        TxtFromSerial.Text = ""
        TxtToSerial.Text = ""

        RdbRangeSerial.Checked = False

        TxtWarrantyDays.Text = ""

        GrdAvailableSerialNumber.Columns.Clear()

        TxtSearchBarcode.Text = ""

    End Sub
    'Making Clear Data For Products for dropdown
    Sub cleardataProductForDropdown()

        cmbProductName.Text = ""
        cmbProductName.ValueMember = ""

        TxtQuantity.Text = ""
        TxtPurchaseUnitCost.Text = ""
        TxtPurchaseAmount.Text = ""
        LblPurchaseID.Text = "00"
        

        TxtSerialNumber.Text = ""

        TxtFromSerial.Text = ""
        TxtToSerial.Text = ""

        RdbRangeSerial.Checked = False

       

        TxtWarrantyDays.Text = ""


        cmbProductName.Focus()



        TxtSearchBarcode.Text = ""

       
        CmbLocationID.Text = ""
        CmbLocationID.ValueMember = ""


    End Sub
    'Clear All Data

    Sub ClearAllData()
        CmbProductName.Text = ""
        CmbProductName.ValueMember = ""

        CmbLocationID.Text = ""
        CmbLocationID.ValueMember = ""

        TxtQuantity.Text = ""
        TxtPurchaseUnitCost.Text = ""
        TxtPurchaseAmount.Text = ""
        LblPurchaseID.Text = "00"
        'lblQuantity.Text = "00"

        CmbSupplierName.ValueMember = ""
        CmbSupplierName.Text = ""

        TxtSerialNumber.Text = ""

        TxtPhoneNo.Text = ""
        TxtAddress.Text = ""
        TxtSupplierDiscount.Text = ""

        TxtTotal.Text = ""
        TxtPreviousDues.Text = ""
        TxtAdvance.Text = ""
        TxtDiscountPercentage.Text = ""
        TxtDiscount.Text = ""
        TxtVatPercentage.Text = ""
        TxtVat.Text = ""
        TxtNetPayable.Text = ""
        TxtPaidAmount.Text = "0"
        TxtBalance.Text = ""

        TxtReturnAmount.Text = ""
        TxtPurchaseInvoiceNo.Text = ""
        DtpPurchaseDate.Value = Now

        TxtSerialNumber.Text = ""

        TxtFromSerial.Text = ""
        TxtToSerial.Text = ""

        TxtFromSerial.Enabled = False
        TxtToSerial.Enabled = False

        RdbRangeSerial.Checked = False


        TxtWarrantyDays.Text = ""

        PurchaseEditStatus = False

    End Sub

    'Making Clear Data For Products Update Serial Number
    Sub CleardataProductForUpdateSerialNumber()

        CmbProductName.Text = ""
        CmbProductName.ValueMember = ""

        CmbLocationID.Text = ""
        CmbLocationID.ValueMember = ""
        TxtSerialNumber.Text = ""
        TxtQuantity.Text = ""
        TxtPurchaseUnitCost.Text = ""
        TxtPurchaseAmount.Text = ""



        TxtSerialNumber.Text = ""

        TxtFromSerial.Text = ""
        TxtToSerial.Text = ""

        RdbRangeSerial.Checked = False

        TxtWarrantyDays.Text = ""

    End Sub
    ' New Purchase Invoice
    Sub Newinvoice()

        Me.TxtPurchaseInvoiceNo.Text = ""

        'Date time auto today
        DtpPurchaseDate.Value = Now
        CmbPaidBy.Text = "DUE"

    End Sub

    Sub LoadComboBoxforSupplier()

        Try


            Dim con1 As New SqlConnection
            Dim cmd1 As New SqlCommand
            con1.ConnectionString = FrmHome.ConnectionString

            Dim strSQL1 As String = "SELECT [Supplier ID],[Supplier Name] FROM [Supplier Information]"
            Dim da1 As New System.Data.SqlClient.SqlDataAdapter(strSQL1, con1)
            Dim ds1 As New DataSet
            da1.Fill(ds1, "[Supplier Information]")

            With Me.CmbSupplierName
                .DataSource = ds1.Tables("[Supplier Information]")
                .ValueMember = "Supplier ID"
                .DisplayMember = "Supplier Name"
            End With

            con1.Close()

        Catch ex As Exception
            MessageBox.Show("Error while loading Supplier record on table..." & ex.Message, "Load ComboBox for Supplier Sub")

        End Try

    End Sub
    'Load ComboBox For Payment Method
    Sub LoadComboBoxForPaymentMethod()
        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            con.ConnectionString = FrmHome.ConnectionString

            Dim strSQL As String = "Select [Chart of Account].[Chart of Account ID],[Chart of Account].[Account Name] from  [Chart of Account] join [Head Of Account]  on [Chart of Account].[Head of Account ID]=[Head Of Account].[Head of Account ID]"
            Dim da As New System.Data.SqlClient.SqlDataAdapter(strSQL, con)
            Dim ds As New DataSet
            da.Fill(ds, "[Hade Of Account]")

            With Me.CmbPaidBy
                .DataSource = ds.Tables("[Hade Of Account]")
                .ValueMember = "Chart of Account ID"
                .DisplayMember = "Account Name"
            End With
            con.Close()

            CmbPaidBy.Text = "DUE"


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Supplier information show
    Sub SupplierInformation()
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT [Supplier Information].[Supplier ID],[Supplier Category].[Supplier Category Name],[Supplier Information].[Supplier Name],[Supplier Information].[Company Name],[Supplier Information].[Designation],[Supplier Information].[Mobile No],[Supplier Information].[Email Address],[Supplier Information].[Address],[Supplier Information].[Web Address],[Supplier Information].[City],[Supplier Information].[Country],[Supplier Information].[SMS Notification],[Supplier Information].[Status],[Supplier Information].[Discount Percentage] FROM [Supplier Information] Join [Supplier Category] on [Supplier Information].[Supplier Category ID]=[Supplier Category].[Supplier Category ID]  WHERE [Supplier Information].[Supplier ID] = '" + CmbSupplierName.ValueMember + "'"


            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then


                Me.TxtPhoneNo.Text = dr.Item("Mobile No").ToString
                Me.TxtAddress.Text = dr.Item("Address").ToString
                Me.TxtSupplierDiscount.Text = dr.Item("Discount Percentage").ToString
                Me.TxtDiscountPercentage.Text = dr.Item("Discount Percentage").ToString

            ElseIf Not dr.HasRows Then

                MsgBox("No Supplier Found")

                cleardataProduct()

            End If

            dr.Close()
            con.Close()

        Catch ex As Exception

        End Try
    End Sub
    Sub DiscountAndPercentage()
        'Sub For discount and vat percentage
        TxtDiscount.Text = (Val(TxtTotal.Text) * Val(TxtDiscountPercentage.Text)) / 100

    End Sub

    'Change Langeuge Privet Sub
    Sub ChangeLanguage()
        ' Changing Language
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        Try
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Select *From [Language Information] where Status= 1"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                Me.CmbSupplierName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtPhoneNo.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtAddress.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtSupplierDiscount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtSearchBarcode.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtPurchaseInvoiceNo.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.CmbProductName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.CmbLocationID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtQuantity.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtPurchaseUnitCost.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtPurchaseAmount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))

                Me.TxtTotal.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, 13, FontStyle.Bold)
                Me.TxtPreviousDues.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtAdvance.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtVatPercentage.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtVat.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtDiscountPercentage.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtDiscount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtNetPayable.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, 13, FontStyle.Bold)
                Me.TxtPaidAmount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, 13, FontStyle.Bold)

                Me.TxtBalance.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, 13, FontStyle.Bold)
                Me.CmbPaidBy.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtReturnAmount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, 13, FontStyle.Bold)
                Me.DtpPurchaseDate.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.LblPurchaseID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtSerialNumber.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")), FontStyle.Bold)
                Me.TxtWarrantyDays.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")), FontStyle.Bold)
                Me.TxtMemoNo.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtFromSerial.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtToSerial.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))

                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

                Me.GrdPurchase.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdPurchase.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)


                'MsgBox(dr.Item("Language Font"))

            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while changing language on table..." & ex.Message, "Change Language")
        Finally
            con.Close()
        End Try

        'End Language
    End Sub
    'Creating Privet Sub for Refresh
    Sub RefreshData()

        ' Load Data
        Try
            

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Purchase].[Purchase ID],[Location Information].[Location Name],[Products].[Product Name],[Purchase].[Purchase Quantity],[Purchase].[Purchase Unit Cost],[Purchase].[Amount],[Purchase].[Warranty Days] from [Purchase] join [Products] on [Purchase].[product ID]=[products].[Product ID] join [Location Information] on [Purchase].[Purchase Location ID]=[Location Information].[Location ID]  where [Purchase].[Purchase Invoice No]= '" + TxtPurchaseInvoiceNo.Text + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Purchase")
            connection.Close()
            GrdPurchase.DataSource = ds
            GrdPurchase.DataMember = "BizPro_Purchase"

            'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)


            GrdPurchase.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill



            'Total Count
            TotalAmount()

            'Vat amount count
            TxtVat.Text = (Val(TxtTotal.Text) * Val(TxtVatPercentage.Text)) / 100

            'Discount percentage
            DiscountAndPercentage()

            'Net Payable amount calculation
            NetpayableAmount()


        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try

        'End Refresh Data
    End Sub
    'Find Purchase ID To Show In Lable
    Sub FindPurchaseIDToShowInLableWhileSelectingNewProduct()

        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            'Data reader for Product Id
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Purchase]  WHERE [Product ID]='" + CmbProductName.ValueMember + "' And [Purchase Invoice No]= '" + TxtPurchaseInvoiceNo.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                LblPurchaseID.Text = (dr.Item("Purchase ID").ToString)


                'Refresh Data Serial Number To Gridview  Click
                RefreshDataSerialNumberToGridviewForCellMouseClick()

            Else

                LblPurchaseID.Text = "00"


            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub TotalAmount()
        Dim total As String = 0
        For i As Integer = 0 To GrdPurchase.RowCount - 1
            total += GrdPurchase.Rows(i).Cells(5).Value
        Next
        Me.TxtTotal.Text = total
    End Sub

    Private Sub TxtQuantity_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtQuantity.KeyDown
        If e.KeyCode = Keys.Enter Then


            If TxtQuantity.Text = "" Then
                MsgBox("Please Enter Quantity", MsgBoxStyle.OkOnly, "Purchase")
            Else
              
                Me.TxtSerialNumber.Focus()



            End If



        End If
    End Sub




    Private Sub TxtQuantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtQuantity.TextChanged
      
        Me.TxtPurchaseAmount.Text = Val(TxtQuantity.Text) * Val(TxtPurchaseUnitCost.Text)


      

    End Sub
    'Refresh Data Serial Number For  Adding More Range Serial Togather 
    Sub RefreshDataSerialNumberForAddingMoreRangeSerialTogather()

        ' Load Data
        Try
            

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT   [Purchase Serial Number].[Purchase Serial Number] FROM [Purchase Serial Number] WHERE [Purchase Invoice No] = '" + TxtPurchaseInvoiceNo.Text + "' And [Product ID]= '" + CmbProductName.ValueMember + "' "
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Purchase Serial Number")
            connection.Close()
            GrdAvailableSerialNumber.DataSource = ds
            GrdAvailableSerialNumber.DataMember = "BizPro_Purchase Serial Number"

            'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)


            GrdAvailableSerialNumber.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill



            TxtQuantity.Text = GrdAvailableSerialNumber.RowCount



        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Data Serial Number To Gridview")
        Finally

        End Try

        'End Refresh Data
    End Sub

    Private Sub TxtUnitCost_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPurchaseUnitCost.KeyDown


        If e.KeyCode = Keys.Enter Then


            If CmbSupplierName.Text = "" Then

                MsgBox("Please select a supplier first.", MsgBoxStyle.OkOnly, "Purchase")

                CmbSupplierName.Focus()

            ElseIf TxtQuantity.Text = "" Or Val(TxtQuantity.Text) = 0 Then

                MsgBox("Please add quantity", MsgBoxStyle.OkOnly, "Purchase")
                TxtQuantity.Focus()
            ElseIf CmbLocationID.Text = "" Or CmbLocationID.ValueMember = "" Then

                MsgBox("Please Select Location", MsgBoxStyle.OkOnly, "Purchase")
                CmbLocationID.Focus()

            Else




                'Insert into Purchase Invoice
                InsertIntoPurchaseInvoice()

                'If Purchase invoice no is blank would not insert into Purchase
                If Not TxtPurchaseInvoiceNo.Text = "" Then



                    If RdbRangeSerial.Checked = True Then
                        'Insert RangeSerial Into Purchase And  Serial Number
                        InsertRangeSerialtoPurchaseSerialNumber()
                        'Refresh Data Serial Number For  Adding More Range Serial Togather 
                        RefreshDataSerialNumberForAddingMoreRangeSerialTogather()

                    End If


                    'Insert or update data
                    InsertOrUpdatePurchase()


                    'Making Clear
                    cleardataProduct()

                    'Refresh Data
                    RefreshData()

                    'Focus on Product text box
                    CmbProductName.Focus()


                    ' discount and vat percentage
                    DiscountAndPercentage()


                End If

                'Refresh Data Serial Number To Gridview Click
                RefreshDataSerialNumberToGridviewForCellMouseClick()

            End If

            'Insert into Purchase Invoice
            InsertIntoPurchaseInvoice()


        End If


    End Sub

    'Insert RangeSerial Into Purchase And  Serial Number
    Sub InsertRangeSerialtoPurchaseSerialNumber()
        Try
            'Data Insert Code
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand


            Dim total As String = 0

            For i As Integer = 0 To GrdAvailableSerialNumber.RowCount - 1
                total += GrdAvailableSerialNumber.Rows(i).Cells(0).Value


                Dim con3 As New SqlConnection
                Dim cmd3 As New SqlCommand
                Dim dr3 As SqlDataReader

                con3.ConnectionString = FrmHome.ConnectionString
                con3.Open()
                cmd3.Connection = con3
                cmd3.CommandText = "SELECT *from [Purchase Serial Number] where [Product ID]= '" + CmbProductName.ValueMember + "' And [Purchase Serial Number]='" + GrdAvailableSerialNumber.Rows(i).Cells(0).Value + "' And [Purchase Invoice No]='" + TxtPurchaseInvoiceNo.Text + "' "

                dr3 = cmd3.ExecuteReader()
                dr3.Read()

                If Not dr3.HasRows Then

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO [Purchase Serial Number] ([Product ID],[Purchase Invoice No],[Purchase Serial Number],[Status],[Branch ID]) values ('" + CmbProductName.ValueMember + "', '" + TxtPurchaseInvoiceNo.Text + "' , '" + GrdAvailableSerialNumber.Rows(i).Cells(0).Value.ToString + "' ,'Available','" + FrmHome.lblBranchID.Text + "')"
                    cmd.ExecuteNonQuery()
                    con.Close()


                    RdbRangeSerial.Checked = False

                Else
                    ' MsgBox("This Serial Number Already exists", MsgBoxStyle.OkOnly, "Purchase")

                End If


                dr3.Close()
                con3.Close()
            Next

            'Refresh Data Serial Number To Grid view For Cell Mouse Click
            RefreshDataSerialNumberToGridviewForCellMouseClick()

            'Clear Temp Serial After Insert purchase Serial 
            deleteForNewSerialInsert()

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Into Purchase Serial")
        Finally

        End Try

    End Sub
    'Insert Single Serial Into Purchase And  Serial Number
    Sub InsertSingleSerialtoPurchaseSerialNumber()
        Try
            'Data Insert Code
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand


            Dim total As String = 0

            For i As Integer = 0 To GrdAvailableSerialNumber.RowCount - 1
                total += GrdAvailableSerialNumber.Rows(i).Cells(0).Value


                Dim con3 As New SqlConnection
                Dim cmd3 As New SqlCommand
                Dim dr3 As SqlDataReader

                con3.ConnectionString = FrmHome.ConnectionString
                con3.Open()
                cmd3.Connection = con3
                cmd3.CommandText = "SELECT *from [Purchase Serial Number] where [Product ID]= '" + CmbProductName.ValueMember + "' And [Purchase Serial Number]='" + TxtSerialNumber.Text + "' "

                dr3 = cmd3.ExecuteReader()
                dr3.Read()

                If Not dr3.HasRows Then

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO [Purchase Serial Number] ([Product ID],[Purchase Invoice No],[Purchase Serial Number],[Status],[Branch ID]) values ('" + CmbProductName.ValueMember + "', '" + TxtPurchaseInvoiceNo.Text + "' ,'" + GrdAvailableSerialNumber.Rows(i).Cells(0).Value.ToString + "' ,'Available','" + FrmHome.lblBranchID.Text + "')"
                    cmd.ExecuteNonQuery()
                    con.Close()


                    RdbRangeSerial.Checked = False

                Else
                    MsgBox("This Serial Number Already exists", MsgBoxStyle.OkOnly, "Purchase")

                End If


                dr3.Close()
                con3.Close()
            Next

            'Refresh Data Serial Number To Grid view For Cell Mouse Click
            RefreshDataSerialNumberToGridviewForCellMouseClick()

            'Clear Temp Serial After Insert purchase Serial 
            deleteForNewSerialInsert()

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Into Purchase Serial")
        Finally

        End Try

    End Sub

    'Insert Into Supplier
    Sub InsertIntoSupplier()

        Try

            If CmbSupplierName.ValueMember = "" Then

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim cmd1 As New SqlCommand
                Dim cmd4 As New SqlCommand

                Dim currentDate As DateTime = DateTime.Today
                Dim currentTime As DateTime = DateTime.Now

                Dim con2 As New SqlConnection
                Dim cmd2 As New SqlCommand
                Dim dr1 As SqlDataReader

                Dim con5 As New SqlConnection
                Dim cmd7 As New SqlCommand
                Dim cmd5 As New SqlCommand
                Dim cmd6 As New SqlCommand
                Dim dr5 As SqlDataReader
                Dim dr6 As SqlDataReader

                Dim HeadOfAccountID As String
                Dim ChartOfAccountID As String

                con5.ConnectionString = FrmHome.ConnectionString
                con5.Open()
                cmd5.Connection = con5
                cmd6.Connection = con5
                cmd7.Connection = con5
                cmd5.CommandText = "select [Head Of Account ID] from [Head Of Account] where [Account Name]='Supplier And Customer'"


                'Data reader find head of account then send it to insert chart of account as customer
                dr5 = cmd5.ExecuteReader()
                dr5.Read()
                If dr5.HasRows Then
                    HeadOfAccountID = (dr5.Item("Head Of Account ID").ToString)
                End If
                dr5.Close()


                cmd7.CommandText = "INSERT INTO [Chart Of Account] ([Head Of Account ID],[Account Name],[Prepared Time],[Prepared Date],[Computer ID],[User Account ID]) VALUES ('" + HeadOfAccountID + "','" + CmbSupplierName.Text + "','" + currentTime + "','" + currentDate + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "')"
                cmd7.ExecuteNonQuery()

                'Data reader find Chart of account then send it to insert  customer
                cmd6.CommandText = "SELECT top 1 [Chart of Account ID] FROM [Chart of Account] where [User Account ID]='" + FrmHome.LblUserID.Text + "' and [Computer ID]='" + FrmHome.LblComputerID.Text + "' order by [Chart of Account ID] DESC"
                dr6 = cmd6.ExecuteReader()
                dr6.Read()
                If dr6.HasRows Then
                    ChartOfAccountID = (dr6.Item("Chart Of Account ID").ToString)
                End If
                dr6.Close()
                con5.Close()




                con2.ConnectionString = FrmHome.ConnectionString
                con2.Open()
                cmd2.Connection = con2
                cmd2.CommandText = "SELECT top 1 [Supplier Category ID] FROM [Supplier Category]   order by [Supplier Category ID] Asc"

                dr1 = cmd2.ExecuteReader()
                dr1.Read()

                If dr1.HasRows Then
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()

                    If Not TxtSupplierDiscount.Text = "" Then
                        cmd.Connection = con
                        cmd.CommandText = "INSERT INTO [Supplier Information] ([Supplier Name],[Customer Category ID],[Mobile No],[Address],[Discount Percentage],[Prepared Time],[Prepared Date],[Computer ID],[User Account ID],[Branch ID],[Status],[Sms Notification],[Chart Of Account ID]) VALUES ('" + CmbSupplierName.Text + "','" + (dr1.Item("Supplier Category ID").ToString) + "','" + TxtPhoneNo.Text + "','" + TxtAddress.Text + "','" + TxtSupplierDiscount.Text + "','" + currentTime + "','" + currentDate + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.lblBranchID.Text + "','CONNECTED','ON','" + ChartOfAccountID + "')"
                        cmd.ExecuteNonQuery()
                    ElseIf TxtSupplierDiscount.Text = "" Then
                        cmd4.Connection = con
                        cmd4.CommandText = "INSERT INTO [Supplier Information] ([Supplier Name],[Supplier Category ID],[Mobile No],[Address],[Discount Percentage],[Prepared Time],[Prepared Date],[Computer ID],[User Account ID],[Branch ID],[Status],[SMS Notification],[Chart Of Account ID]) VALUES ('" + CmbSupplierName.Text + "','" + (dr1.Item("Supplier Category ID").ToString) + "','" + TxtPhoneNo.Text + "','" + TxtAddress.Text + "','0','" + currentTime + "','" + currentDate + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.lblBranchID.Text + "','CONNECTED','ON','" + ChartOfAccountID + "')"
                        cmd4.ExecuteNonQuery()
                    End If
                    con.Close()
                End If


                dr1.Close()
                con2.Close()


                Dim con6 As New SqlConnection
                Dim cmd9 As New SqlCommand
                Dim dr4 As SqlDataReader
                Dim CustomerCategoryID As String


                con6.ConnectionString = FrmHome.ConnectionString
                con6.Open()
                cmd9.Connection = con6
                cmd9.CommandText = "SELECT top 1 [Customer Category ID] FROM [Customer Category]   order by [Customer Category ID] Asc"

                dr4 = cmd9.ExecuteReader()
                dr4.Read()
                If dr4.HasRows Then
                    CustomerCategoryID = dr4.Item("Customer Category ID").ToString
                End If
                dr4.Close()
                con6.Close()



                con.ConnectionString = FrmHome.ConnectionString
                con.Open()


                Dim con3 As New SqlConnection
                Dim con4 As New SqlConnection
                Dim cmd3 As New SqlCommand
                Dim cmd8 As New SqlCommand
                Dim dr3 As SqlDataReader

                con3.ConnectionString = FrmHome.ConnectionString
                con3.Open()
                cmd3.Connection = con3
                cmd3.CommandText = "SELECT top 1 [Supplier ID],[Supplier Name] FROM [Supplier Information] where [User Account ID]= '" + FrmHome.LblUserID.Text + "' and [Computer ID]='" + FrmHome.LblComputerID.Text + "'  order by [Supplier ID] desc"

                dr3 = cmd3.ExecuteReader()
                dr3.Read()

                If dr3.HasRows Then

                    CmbSupplierName.ValueMember = (dr3.Item("Supplier ID").ToString)

                    con4.ConnectionString = FrmHome.ConnectionString
                    con4.Open()
                    cmd8.Connection = con4
                    cmd8.CommandText = "INSERT INTO [Customer Information] ([Customer Name],[Customer Category ID],[Mobile No],[Address],[Discount Percentage],[Prepared Time],[Prepared Date],[Computer ID],[User Account ID],[Branch ID],[Status],[SMS Notification],[Chart Of Account ID],[Supplier ID]) VALUES ('" + CmbSupplierName.Text + "','" + CustomerCategoryID + "','" + TxtPhoneNo.Text + "','" + TxtAddress.Text + "','0','" + currentTime + "','" + currentDate + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.lblBranchID.Text + "','CONNECTED','ON','" + ChartOfAccountID + "','" + (dr3.Item("Supplier ID").ToString) + "')"
                    cmd8.ExecuteNonQuery()
                    con4.Close()

                End If
                con3.Close()
                dr3.Close()

                'Show customer information
                SupplierInformation()

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub InsertOrUpdatePurchase()


        'Set 00 value to warranty days so warranty days not remain blank
        If TxtWarrantyDays.Text = "" Then
            TxtWarrantyDays.Text = "00"
        End If


        If LblPurchaseID.Text = "00" Then



            'Data Insert Code
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now



            Try

                'Empty Txt Box Can Not Be Save Code
                If CmbSupplierName.ValueMember = "" Or CmbSupplierName.Text = "" Or CmbProductName.ValueMember = "" Or CmbProductName.Text = "" Or CmbLocationID.ValueMember = "" Or CmbLocationID.Text = "" Or TxtQuantity.Text = "" Or TxtPurchaseUnitCost.Text = "" Or TxtPurchaseAmount.Text = "" Then
                    MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Purchase")

                Else

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO [Purchase] ([Purchase Invoice No],[Product ID],[Purchase Location ID],[Purchase Quantity],[Purchase Unit Cost],[Amount],[Branch ID],[Computer ID],[User Account ID],[Purchase Date],[Purchase Serial Number],[Warranty Days]) VALUES ('" + TxtPurchaseInvoiceNo.Text + "','" + CmbProductName.ValueMember + "','" + CmbLocationID.ValueMember + "','" + TxtQuantity.Text + "','" + TxtPurchaseUnitCost.Text + "','" + TxtPurchaseAmount.Text + "','" + FrmHome.lblBranchID.Text + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + DtpPurchaseDate.Value + "','" + TxtSerialNumber.Text + "" + TxtFromSerial.Text + "-" + TxtToSerial.Text + "','" + TxtWarrantyDays.Text + "')"
                    cmd.ExecuteNonQuery()
                    con.Close()






                End If

            Catch ex As Exception
                MessageBox.Show("Error while inserting record on table..." & ex.Message, "InsertOrUpdate Records")
            Finally


            End Try

        Else

            'Data Update Code
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now

            Try

                'Empty Bank Transaction ID Can Not Be Update
                If LblPurchaseID.Text = "00" Then
                    MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Purchase")

                    'Empty Txt Box Can Not Be Save Code

                    'Empty Txt Box Can Not Be Save Code
                ElseIf CmbSupplierName.ValueMember = "" Or CmbSupplierName.Text = "" Or CmbProductName.ValueMember = "" Or CmbProductName.Text = "" Or CmbLocationID.ValueMember = "" Or CmbLocationID.Text = "" Or TxtQuantity.Text = "" Or TxtPurchaseUnitCost.Text = "" Or TxtPurchaseAmount.Text = "" Then
                    MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Purchase")

                Else
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "UPDATE [Purchase] SET [Purchase Invoice No]= '" + TxtPurchaseInvoiceNo.Text + "',[Product ID]= '" + CmbProductName.ValueMember + "',[Purchase Location ID]= '" + CmbLocationID.ValueMember + "',[Purchase Quantity]= '" + TxtQuantity.Text + "',[Purchase Unit Cost]= '" + TxtPurchaseUnitCost.Text + "',[Amount]= '" + TxtPurchaseAmount.Text + "',[Branch ID]= '" + FrmHome.lblBranchID.Text + "',[Computer ID]= '" + FrmHome.LblComputerID.Text + "',[User Account ID]= '" + FrmHome.LblUserID.Text + "',[Purchase Serial Number]= '" + TxtSerialNumber.Text + "',[Warranty Days]='" + TxtWarrantyDays.Text + "' WHERE [Purchase ID]= '" + LblPurchaseID.Text + "'"
                    cmd.ExecuteNonQuery()
                    con.Close()





                End If
            Catch ex As Exception
                MessageBox.Show("Error while Updating record on table..." & ex.Message, "Update Records")
            Finally

            End Try


        End If
    End Sub



    Private Sub TxtUnitCost_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPurchaseUnitCost.TextChanged
        Me.TxtPurchaseAmount.Text = Val(TxtQuantity.Text) * Val(TxtPurchaseUnitCost.Text)

    End Sub

    Private Sub CmbLocationID_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbLocationID.GotFocus


    End Sub

    Private Sub CmbLocationID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbLocationID.KeyDown

        If e.KeyCode = Keys.Down Then
            GrdLocationList.Visible = True
            GrdLocationList.Focus()
        ElseIf e.KeyCode = Keys.Enter Then
            'Show Location details to Combobox
            ShowLocationDetailsToCombobox()
        End If

    End Sub

    Private Sub CmbLocationID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbLocationID.KeyPress
        'e.Handled = True
    End Sub

    Private Sub CmbLocationID_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CmbLocationID.MouseClick

        'Resize Location Gridview and Make it Visible
        ResizeLocationGridviewandMakeitVisible()

        'Search By Location Name 
        SearchByLocationName()

        'Location grid view visible
        GrdLocationList.Visible = True

        'Hide product list gridview
        GrdProductList.Hide()
    End Sub

    Private Sub CmbLocationID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbLocationID.SelectedIndexChanged

    End Sub

    Private Sub BtnSearchInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

        Dim PurchaseDetails As String
        Dim BillStatus As String
        Try
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd2.Connection = con
            cmd.CommandText = "Select SUBSTRING( ( SELECT   '-------'+  [Product Name],'  Purchase Quantity : ',isnull(sum(Purchase.[Purchase Quantity]),0),'  Purchase unit Cost : ', isnull((Purchase.[Purchase Unit Cost]),0),'  Total Purchase Amount : ', isnull (sum(Purchase.[Amount]),0)        FROM [Purchase] join products on Purchase.[Product ID]=products.[Product ID]  where [Purchase Invoice No]='" + TxtPurchaseInvoiceNo.Text + "'   group by Purchase.[Purchase Unit Cost],products.[Product Name] FOR XML PATH('') ), 2 , 9999) As [Purchase Details]"
            cmd2.CommandText = "Select [Status] From [Purchase Invoice] Where [Purchase Invoice No]='" + TxtPurchaseInvoiceNo.Text + "'"

            'Data Reader For Find Sale Details
            dr = cmd.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                PurchaseDetails = dr.Item("Purchase Details").ToString

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
            cmd1.CommandText = "INSERT INTO [Log Details]  ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES('Purchase','DELETE','Supplier Name : " + CmbSupplierName.Text + " , Supplier ID : " + CmbSupplierName.ValueMember + " , Purchase Details :( " + PurchaseDetails + "),  Purchase Invoice Details :(Purchase Date : " + DtpPurchaseDate.Value + ", Total : " + TxtTotal.Text + ", Previous Dues : " + TxtPreviousDues.Text + ", Advance : " + TxtAdvance.Text + " , Vat Percentage : " + TxtVatPercentage.Text + ", Vat Amount : " + TxtVat.Text + ", Discount Percentage : " + TxtDiscountPercentage.Text + ", Discount Amount : " + TxtDiscount.Text + ", Net Payable : " + TxtNetPayable.Text + " , Paid Amount : " + TxtPaidAmount.Text + " , Balance : " + TxtBalance.Text + " , Paid By : " + CmbPaidBy.Text + ", Return Amount : " + TxtReturnAmount.Text + "), Bill Status: " + BillStatus + "' ,'" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtPurchaseInvoiceNo.Text + "' )"
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

        Dim PurchaseDetails As String

        Try
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Select SUBSTRING( ( SELECT   '-------'+  [Product Name],'  Purchase Quantity : ',isnull(sum(Purchase.[Purchase Quantity]),0),'  Purchase unit Cost : ', isnull((Purchase.[Purchase Unit Cost]),0),'  Total Purchase Amount : ', isnull (sum(Purchase.[Amount]),0)        FROM [Purchase] join products on Purchase.[Product ID]=products.[Product ID]  where [Purchase Invoice No]='" + TxtPurchaseInvoiceNo.Text + "'   group by Purchase.[Purchase Unit Cost],products.[Product Name] FOR XML PATH('') ), 2 , 9999) As [Purchase Details]"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                PurchaseDetails = dr.Item("Purchase Details").ToString

            End If
            dr.Close()
            con.Close()


            con1.ConnectionString = FrmHome.ConnectionString
            con1.Open()
            cmd1.Connection = con1
            cmd1.CommandText = "INSERT INTO [Log Details]  ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES('Purchase','INSERT','Supplier Name : " + CmbSupplierName.Text + " , Supplier ID : " + CmbSupplierName.ValueMember + " , Purchase Details :( " + PurchaseDetails + "),  Purchase Invoice Details :(Purchase Date : " + DtpPurchaseDate.Value + ", Total : " + TxtTotal.Text + ", Previous Dues : " + TxtPreviousDues.Text + ", Advance : " + TxtAdvance.Text + " , Vat Percentage : " + TxtVatPercentage.Text + ", Vat Amount : " + TxtVat.Text + ", Discount Percentage : " + TxtDiscountPercentage.Text + ", Discount Amount : " + TxtDiscount.Text + ", Net Payable : " + TxtNetPayable.Text + " , Paid Amount : " + TxtPaidAmount.Text + " , Balance : " + TxtBalance.Text + " , Paid By : " + CmbPaidBy.Text + ", Return Amount : " + TxtReturnAmount.Text + ")' ,'" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtPurchaseInvoiceNo.Text + "' )"
            cmd1.ExecuteNonQuery()
            con1.Close()



        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally


        End Try
    End Sub

    Private Sub BtnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsave.Click
        Try

            If TxtPaidAmount.Text = "" Or CmbPaidBy.Text = "" Or Val(TxtPaidAmount.Text) < 0 Then
                MsgBox("Please Insert Valid Amount", MsgBoxStyle.Critical, "Purchase")

            Else

                'Calculation Of Balance And ReturnAmount
                CalculationOfBalanceAndReturnAmount()


                Dim q As MsgBoxResult

                'Condition for show dues and advanced on msg box
                If Val(TxtPaidAmount.Text) >= Val(TxtNetPayable.Text) Then
                    If ShowInvoicePermision = "No" Then
                        q = MsgBox("Do you really want to Save?", MsgBoxStyle.YesNo, "Purchase")
                    Else
                        q = MsgBox("Balance = " + TxtBalance.Text + ", Return Amount =  " + TxtReturnAmount.Text + ", Do you really want to Save?", MsgBoxStyle.YesNo, "Purchase")
                    End If
                Else
                    If ShowInvoicePermision = "No" Then
                        q = MsgBox("Do you really want to Save?", MsgBoxStyle.YesNo, "Purchase")
                    Else
                        q = MsgBox("Dues Amount = " + TxtBalance.Text + ", Paid Amount =  " + TxtPaidAmount.Text + ", Do you really want to Save?", MsgBoxStyle.YesNo, "Purchase")

                    End If
                End If

                If q = MsgBoxResult.Yes Then

                    'Insert into log code For Save
                    InsertIntoLogForSave()

                    'Purchase Invoice update code
                    UpdatePurchaseInvoice()



                    If CmbPaidBy.Text = "DUE" Then


                        'Delete Supplier Ledger
                        DeleteSupplierLedger()

                        'Update or insert Supplier ledger For dues
                        InsertorUpdateSupplierLedgerForDues()



                    Else


                        'Update or insert Supplier ledger For dues
                        InsertorUpdateSupplierLedgerForDues()

                        'Update or insert  ledger For Cash Purchase
                        InsertorUpdateLedgerForCashPurchase()


                    End If



                    'Dim qs As MsgBoxResult
                    'qs = MsgBox("Do you really want to Send Sms?", MsgBoxStyle.YesNo, "SMS")
                    'If qs = MsgBoxResult.Yes Then


                    'SmsSendJustOnlyForNewPurchase()
                    'End If

                    'Send purchase invoice no to RptPurchase 
                    RptPurchaseInvoice.PurchaseInvoiceNo = TxtPurchaseInvoiceNo.Text





                    'Clear All
                    ClearAllData()

                    'New INvoice
                    Newinvoice()

                    'RefreshData
                    RefreshData()


                    If Not ShowInvoicePermision = "No" Then
                        RptPurchaseInvoice.ShowInvoice()
                        RptPurchaseInvoice.Show()

                    End If


                    'Row clear Code
                    GrdAvailableSerialNumber.Columns.Clear()
                    GrdPurchase.Columns.Clear()




                ElseIf q = MsgBoxResult.No Then


                    'Save Button Focus
                    TxtPaidAmount.Focus()





                End If
            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    'Find Supplier Char of Account ID 
    Sub SearchCustomerChartOfAccountIDForUpdateLedger()
        Dim con As New SqlConnection
        Dim cmd3 As New SqlCommand
        Dim dr3 As SqlDataReader


        con.ConnectionString = FrmHome.ConnectionString
        con.Open()
        cmd3.Connection = con
        cmd3.CommandText = "SELECT  *FROM [Customer Information]  WHERE [Supplier ID] = '" + CmbSupplierName.ValueMember + "' "

        dr3 = cmd3.ExecuteReader()
        dr3.Read()
        If dr3.HasRows Then
            CustomerChartOfAccountIDForUpdateLedger = dr3.Item("Chart Of Account ID").ToString
        End If
        dr3.Close()
        con.Close()

    End Sub


    'Delete Supplier Ledger
    Sub DeleteSupplierLedger()


        Try


            Dim con As New SqlConnection
            Dim con1 As New SqlConnection
            Dim cmd As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now


            Dim cmd2 As New SqlCommand
            Dim dr As SqlDataReader

            Dim cmd3 As New SqlCommand
            Dim dr3 As SqlDataReader



            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd2.Connection = con
            cmd3.Connection = con
            cmd2.CommandText = "SELECT  *FROM [Ledger]  WHERE [Invoice No] = '" + TxtPurchaseInvoiceNo.Text + "' And [Category Name]='Purchase' "
            cmd3.CommandText = "SELECT  *FROM [Ledger]  WHERE [Invoice No] = '" + TxtPurchaseInvoiceNo.Text + "' And [Category Name]='Cash Purchase' "

            dr3 = cmd3.ExecuteReader()
            dr3.Read()


            If dr3.HasRows Then
                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd.Connection = con1
                cmd.CommandText = "Delete from [Ledger] where [Invoice No]= '" + TxtPurchaseInvoiceNo.Text + "' And [Category Name]='Cash Purchase'"
                cmd.ExecuteNonQuery()
                con1.Close()
            End If


            dr3.Close()


            dr = cmd2.ExecuteReader()
            dr.Read()

            If dr.HasRows Then
                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd.Connection = con1
                cmd.CommandText = "Delete from [Ledger] where [Invoice No]= '" + TxtPurchaseInvoiceNo.Text + "' And [Category Name]='Purchase'"
                cmd.ExecuteNonQuery()
                con1.Close()

            End If


            dr.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Records to Supplier ladger")
        Finally

        End Try


    End Sub

    'Update or insert Supplier ledger For dues
    Sub InsertorUpdateSupplierLedgerForDues()



        Try

            Dim con As New SqlConnection
            Dim con1 As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand
            Dim cmd2 As New SqlCommand
            Dim cmd3 As New SqlCommand
            Dim cmd4 As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now
            Dim dr As SqlDataReader
            Dim dr2 As SqlDataReader
            Dim dr3 As SqlDataReader

            Dim SupplierChartOfAccountID As String
            Dim PurchaseChartOfAccountID As String
            Dim NetPayable As String

            NetPayable = ((Val(TxtTotal.Text) + Val(TxtVat.Text)) - Val(TxtDiscount.Text))

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd2.Connection = con
            cmd3.Connection = con
            cmd2.CommandText = "SELECT  *FROM [Customer Information]  WHERE [Supplier ID] = '" + CmbSupplierName.ValueMember + "'"
            cmd3.CommandText = "SELECT  *FROM [Chart Of Account]  WHERE [Account Name] = 'Purchase'"

            dr3 = cmd3.ExecuteReader()
            dr3.Read()
            If dr3.HasRows Then


                PurchaseChartOfAccountID = (dr3.Item("Chart Of Account ID").ToString)
            End If
            dr3.Close()

            dr2 = cmd2.ExecuteReader()
            dr2.Read()
            If dr2.HasRows Then

                SupplierChartOfAccountID = (dr2.Item("Chart Of Account ID").ToString)

            End If
            dr2.Close()


            cmd.CommandText = "SELECT  *FROM [Ledger]  WHERE  [Category Name]='Purchase' And [Invoice No] = '" + TxtPurchaseInvoiceNo.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If Not dr.HasRows Then

                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd4.Connection = con1
                cmd1.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart Of Account ID],[Invoice No],[Category Name],[User Account ID],[Computer ID],[Prepared Date] ,[Prepared Time],[Debited Amount],[Credited Amount],[Status],[Voucher No],[Description],[Branch ID],[Pending Invoice]) VALUES ('" + DtpPurchaseDate.Value + "','" + SupplierChartOfAccountID + "','" + TxtPurchaseInvoiceNo.Text + "','Purchase','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','00','" + NetPayable + "','Completed','" + TxtPurchaseInvoiceNo.Text + "','Purchase','" + FrmHome.lblBranchID.Text + "','" + (DtpPurchaseDate.Value.ToString("dd-MMM-yyyy")) + "-P-INV-" + TxtPurchaseInvoiceNo.Text + "')"
                cmd4.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart Of Account ID],[Invoice No],[Category Name],[User Account ID],[Computer ID],[Prepared Date] ,[Prepared Time],[Debited Amount],[Credited Amount],[Status],[Voucher No],[Description],[Branch ID],[Pending Invoice]) VALUES ('" + DtpPurchaseDate.Value + "','" + PurchaseChartOfAccountID + "','" + TxtPurchaseInvoiceNo.Text + "','Purchase','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + NetPayable + "','00','Completed','" + TxtPurchaseInvoiceNo.Text + "','Purchase From " + CmbSupplierName.Text + "','" + FrmHome.lblBranchID.Text + "' ,'" + (DtpPurchaseDate.Value.ToString("dd-MMM-yyyy")) + "-P-INV-" + TxtPurchaseInvoiceNo.Text + "')"
                cmd4.ExecuteNonQuery()
                cmd1.ExecuteNonQuery()

                con1.Close()




            ElseIf dr.HasRows Then



                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd4.Connection = con1
                cmd1.CommandText = "Update [Ledger] Set [Ledger Date]='" + DtpPurchaseDate.Value + "',[Chart Of Account ID]='" + SupplierChartOfAccountID + "',[Invoice No]='" + TxtPurchaseInvoiceNo.Text + "',[Category Name]='Purchase',[User Account ID]='" + FrmHome.LblUserID.Text + "',[Computer ID]='" + FrmHome.LblComputerID.Text + "',[Prepared Time]='" + currentTime + "',[Credited Amount]='" + NetPayable + "',[Debited Amount]='0',[Description]='Purchase'  Where [Chart Of Account ID]='" + CustomerChartOfAccountIDForUpdateLedger + "' And [Invoice No]='" + TxtPurchaseInvoiceNo.Text + "' And [Category Name]='Purchase'"
                cmd4.CommandText = "Update [Ledger] Set [Ledger Date]='" + DtpPurchaseDate.Value + "',[Chart Of Account ID]='" + PurchaseChartOfAccountID + "',[Invoice No]='" + TxtPurchaseInvoiceNo.Text + "',[Category Name]='Purchase',[User Account ID]='" + FrmHome.LblUserID.Text + "',[Computer ID]='" + FrmHome.LblComputerID.Text + "',[Prepared Time]='" + currentTime + "',[Debited Amount]='" + NetPayable + "',[Credited Amount]='0',[Description]= 'Purchase From " + CmbSupplierName.Text + "' Where [Chart Of Account ID]='" + PurchaseChartOfAccountID + "' And [Invoice No]='" + TxtPurchaseInvoiceNo.Text + "'And [Category Name]='Purchase' "


                cmd1.ExecuteNonQuery()
                cmd4.ExecuteNonQuery()



                con1.Close()




            End If

            dr.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records to  Ledger")
        Finally

        End Try

    End Sub
    'Update or insert  ledger For Cash Purchase
    Sub InsertorUpdateLedgerForCashPurchase()



        Try

            Dim con As New SqlConnection
            Dim con1 As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand
            Dim cmd2 As New SqlCommand
            Dim cmd4 As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now
            Dim dr As SqlDataReader
            Dim dr2 As SqlDataReader


            Dim CustomerChartOfAccountID As String

            Dim PaidAmount As String

            PaidAmount = (Val(TxtPaidAmount.Text) - Val(TxtReturnAmount.Text))

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd2.Connection = con
            cmd.CommandText = "SELECT  *FROM [Ledger]  WHERE  [Category Name]='Cash Purchase' And [Invoice No] = '" + TxtPurchaseInvoiceNo.Text + "'"
            cmd2.CommandText = "SELECT  *FROM [Customer Information]  WHERE [Supplier ID] = '" + CmbSupplierName.ValueMember + "'"

            dr2 = cmd2.ExecuteReader()
            dr2.Read()
            If dr2.HasRows Then

           
                CustomerChartOfAccountID = (dr2.Item("Chart Of Account ID").ToString)
            End If

            dr2.Close()

            dr = cmd.ExecuteReader()
            dr.Read()




            If Not dr.HasRows Then

                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd4.Connection = con1
                cmd1.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart Of Account ID],[Invoice No],[Category Name],[User Account ID],[Computer ID],[Prepared Date] ,[Prepared Time],[Debited Amount],[Credited Amount],[Status],[Voucher No],[Description],[Branch ID],[Pending Invoice]) VALUES ('" + DtpPurchaseDate.Value + "','" + CustomerChartOfAccountID + "','" + TxtPurchaseInvoiceNo.Text + "','Cash Purchase','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + PaidAmount + "','00','Cash','" + TxtPurchaseInvoiceNo.Text + "','Paid By " + CmbPaidBy.Text + "','" + FrmHome.lblBranchID.Text + "','" + (DtpPurchaseDate.Value.ToString("dd-MMM-yyyy")) + "-P-INV-" + TxtPurchaseInvoiceNo.Text + "')"
                cmd4.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart Of Account ID],[Invoice No],[Category Name],[User Account ID],[Computer ID],[Prepared Date] ,[Prepared Time],[Debited Amount],[Credited Amount],[Status],[Voucher No],[Description],[Branch ID],[Pending Invoice]) VALUES ('" + DtpPurchaseDate.Value + "','" + CmbPaidBy.SelectedValue.ToString + "','" + TxtPurchaseInvoiceNo.Text + "','Cash Purchase','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','00','" + PaidAmount + "','Cash','" + TxtPurchaseInvoiceNo.Text + "','Paid To " + CmbSupplierName.Text + "','" + FrmHome.lblBranchID.Text + "','" + (DtpPurchaseDate.Value.ToString("dd-MMM-yyyy")) + "-P-INV-" + TxtPurchaseInvoiceNo.Text + "')"
                cmd1.ExecuteNonQuery()
                cmd4.ExecuteNonQuery()
                con1.Close()




            ElseIf dr.HasRows Then



                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd4.Connection = con1
                cmd1.CommandText = "Update [Ledger] Set [Ledger Date]='" + DtpPurchaseDate.Value + "',[Chart Of Account ID]='" + CustomerChartOfAccountID + "',[Invoice No]='" + TxtPurchaseInvoiceNo.Text + "',[Category Name]='Cash Purchase',[User Account ID]='" + FrmHome.LblUserID.Text + "',[Prepared Time]='" + currentTime + "',[Computer ID]='" + FrmHome.LblComputerID.Text + "',[Credited Amount]='00',[Debited Amount]='" + PaidAmount + "',[Description]= 'Paid By " + CmbPaidBy.Text + "' Where  [Chart Of Account ID]='" + CustomerChartOfAccountIDForUpdateLedger + "' And [Invoice No]='" + TxtPurchaseInvoiceNo.Text + "' And [Category Name]='Cash Purchase'"
                cmd4.CommandText = "Update [Ledger] Set [Ledger Date]='" + DtpPurchaseDate.Value + "',[Chart Of Account ID]='" + CmbPaidBy.SelectedValue.ToString + "',[Invoice No]='" + TxtPurchaseInvoiceNo.Text + "',[Category Name]='Cash Purchase',[User Account ID]='" + FrmHome.LblUserID.Text + "',[Computer ID]='" + FrmHome.LblComputerID.Text + "',[Prepared Time]='" + currentTime + "',[Credited Amount]='" + PaidAmount + "',[Debited Amount]= '00',[Description]= 'Paid To " + CmbSupplierName.Text + "'  Where [Chart Of Account ID]='" + PreviousPaidbyID + "' And [Invoice No]='" + TxtPurchaseInvoiceNo.Text + "' And [Category Name]='Cash Purchase' "

                cmd1.ExecuteNonQuery()
                cmd4.ExecuteNonQuery()



                con1.Close()




            End If

            dr.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records to Customer ladger")
        Finally

        End Try
    End Sub

    Private Sub BtnSupplierName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSupplierName.Click
        'Form supplier information show
        FrmSupplierInformation.Show()

        'show status= connected and sms notification= on 
        FrmSupplierInformation.CmbSmsNotification.SelectedIndex = 0
        FrmSupplierInformation.CmbStatus.SelectedIndex = 0
        FrmSupplierInformation.TxtDiscountPercentage.Text = "0"

        FrmSupplierInformation.CmbSupplierName.Focus()
        FrmSupplierInformation.LblFormName.Text = "Purchase"




    End Sub



    Private Sub GrdPurchase_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    'Refresh Data Serial Number To Gridview Click
    Sub RefreshDataSerialNumberToGridviewForCellMouseClick()

        ' Load Data
        Try
            

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT   [Purchase Serial Number].[Purchase Serial Number] FROM [Purchase Serial Number] WHERE [Purchase Invoice No] = '" + TxtPurchaseInvoiceNo.Text + "' And [Product ID]= '" + CmbProductName.ValueMember + "' "
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Purchase Serial Number")
            connection.Close()
            GrdAvailableSerialNumber.DataSource = ds
            GrdAvailableSerialNumber.DataMember = "BizPro_Purchase Serial Number"

            'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)


            GrdAvailableSerialNumber.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill



        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Data Serial Number To Gridview")
        Finally

        End Try

        'End Refresh Data
    End Sub

    Private Sub GrdPurchase_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)



    End Sub

    Private Sub GrdPurchase_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)


    End Sub

    Private Sub GrdPurchase_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)



    End Sub

    'Delete From Purchase Serial NumberDoubleClick
    Sub DeleteFromPurchaseSerialNumberDoubleClick()



        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now
        Try
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Delete from [Purchase Serial Number] where [Purchase Invoice No]= '" + TxtPurchaseInvoiceNo.Text + "' And [Product ID]= '" + CmbProductName.ValueMember + "' "
            cmd.ExecuteNonQuery()
            con.Close()



        Catch ex As Exception
            MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Records Purchase Serial")
        Finally

        End Try
        'Update Purchase Invoice
    End Sub

    'Delete From Purchase Serial Delete Button
    Sub DeleteFromPurchaseSerialNumberDeleteButton()



        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now
        Try
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Delete from [Purchase Serial Number] where [Purchase Invoice No]= '" + TxtPurchaseInvoiceNo.Text + "' "
            cmd.ExecuteNonQuery()
            con.Close()



        Catch ex As Exception
            MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Records Purchase Serial")
        Finally

        End Try
        'Update Purchase Invoice
    End Sub
    Sub deleteForNewSerialInsert()



        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now
        Try
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Delete from [Serial No]"
            cmd.ExecuteNonQuery()
            con.Close()



        Catch ex As Exception
            MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Records Purchase Serial")
        Finally

        End Try



    End Sub

    'Update Purchase Invoice
    Sub UpdatePurchaseInvoice()
        Try

        
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim currentTime As DateTime = DateTime.Now

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "UPDATE  [Purchase Invoice] SET [Memo No]='" + TxtMemoNo.Text + "',  [Total]='" + TxtTotal.Text + "',[Previous Dues]= '" + TxtPreviousDues.Text + "', [Advance]= '" + TxtAdvance.Text + "', [Vat percentage]= '" + TxtVatPercentage.Text + "', [Vat]= '" + TxtVat.Text + "', [Discount Percentage]= '" + TxtDiscountPercentage.Text + "', [Discount]= '" + TxtDiscount.Text + "', [Net Payable]= '" + TxtNetPayable.Text + "',[Paid Amount]= '" + TxtPaidAmount.Text + "', [Balance]= '" + TxtBalance.Text + "', [Return Amount]= '" + TxtReturnAmount.Text + "', [Status]= 'COMPLETE',[Purchase Date]='" + DtpPurchaseDate.Value + "',[Paid by]='" + CmbPaidBy.SelectedValue.ToString + "',[Supplier ID]='" + CmbSupplierName.ValueMember + "',[User Account ID]= '" + FrmHome.LblUserID.Text + "',[Computer ID]= '" + FrmHome.LblComputerID.Text + "',[Purchase Time]= '" + currentTime + "'    where [Purchase Invoice No] ='" + TxtPurchaseInvoiceNo.Text + "'"
            cmd.ExecuteNonQuery()

            con.Close()

        Catch ex As Exception

        End Try
    End Sub


    Sub InsertIntoPurchaseInvoice()

        'Insert Into Purchase Invoice code
        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim con2 As New SqlConnection
            Dim cmd2 As New SqlCommand
            Dim dr1 As SqlDataReader

            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now




            'Insert Into Supplier
            InsertIntoSupplier()

            If TxtPurchaseInvoiceNo.Text = "" Then


                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "INSERT INTO [Purchase Invoice] ([Memo No],[Total],[Previous Dues],[Advance],[Vat percentage],[Vat],[Discount Percentage],[Discount],[Net Payable],[Paid Amount],[Balance],[Return Amount],[Status],[Supplier ID],[Purchase Date],[Purchase Time],[User Account ID],[Computer ID],[Paid By],[Prepared Date]) values ('" + TxtMemoNo.Text + "','" + TxtTotal.Text + "','" + TxtPreviousDues.Text + "','" + TxtAdvance.Text + "','" + TxtVatPercentage.Text + "','" + TxtVat.Text + "','" + TxtDiscountPercentage.Text + "','" + TxtDiscount.Text + "','" + TxtNetPayable.Text + "','" + TxtPaidAmount.Text + "','" + TxtBalance.Text + "','" + TxtReturnAmount.Text + "','INCOMPLETE','" + CmbSupplierName.ValueMember + "','" + DtpPurchaseDate.Value + "','" + currentTime + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CmbPaidBy.SelectedValue.ToString + "','" + currentDate + "')"
                cmd.ExecuteNonQuery()
                con.Close()


                con2.ConnectionString = FrmHome.ConnectionString
                con2.Open()
                cmd2.Connection = con2
                cmd2.CommandText = "SELECT top 1 [Purchase Invoice No] FROM [Purchase Invoice] where [User Account ID]= '" + FrmHome.LblUserID.Text + "'  order by [Purchase Invoice No] desc"

                dr1 = cmd2.ExecuteReader()
                dr1.Read()
                If dr1.HasRows Then


                    TxtPurchaseInvoiceNo.Text = (dr1.Item("Purchase Invoice No").ToString)
                End If
                con2.Close()
                dr1.Close()



            Else





                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "UPDATE  [Purchase Invoice] SET [Memo No]='" + TxtMemoNo.Text + "', [Total]='" + TxtTotal.Text + "',[Purchase Time]= '" + currentTime + "', [Purchase Date]= '" + DtpPurchaseDate.Value + "', [User Account ID]= '" + FrmHome.LblUserID.Text + "',[Supplier ID]='" + CmbSupplierName.ValueMember + "',[Status]='INCOMPLETE' where [Purchase Invoice No] = '" + TxtPurchaseInvoiceNo.Text + "' "
                cmd.ExecuteNonQuery()
                con.Close()


            End If

        Catch ex As Exception
            MessageBox.Show("Error while Inserting to Purchase invoice record on table..." & ex.Message, "Insert Records Purchase Invoice")
        Finally

        End Try



    End Sub

    Private Sub CmbSupplierName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbSupplierName.KeyDown

        If e.KeyCode = Keys.Enter Then

            'Show Supplier Details In Textboxs
            ShowSupplierDetailsInTextboxs()

            TxtPhoneNo.Focus()

        ElseIf e.KeyCode = Keys.Down Then

            'Resize Supplier List Grid view And Make it Visible
            ResizeSupplierListGridviewAndMakeitVisible()

            'Search By Supplier Name For Current Branch
            SearchBySupplierNameForCurrentBranch()


            GrdSupplierList.Visible = True

            GrdSupplierList.Focus()
        End If



    End Sub

    Private Sub CmbSupplierName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbSupplierName.KeyPress

    End Sub

    Private Sub CmbSupplierName_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CmbSupplierName.MouseClick

        'Resize Supplier List Grid view And Make it Visible
        ResizeSupplierListGridviewAndMakeitVisible()

        'Search By Supplier Name For Current Branch
        SearchBySupplierNameForCurrentBranch()
    End Sub
    Private Sub CmbSupplierName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSupplierName.SelectedIndexChanged


    End Sub


    Sub ShowDueOrAdvance()
        Try


            Me.TxtPreviousDues.Text = ""
            Me.TxtAdvance.Text = ""

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader


            Dim cmd2 As New SqlCommand
            Dim dr1 As SqlDataReader
            Dim SupplierChartOfAccountID As String





            'Data reader for Product Id
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd2.Connection = con
            cmd2.CommandText = "Select * from [Customer Information] where [Supplier ID]=  '" + CmbSupplierName.ValueMember + "'"

            'Dr search For Customer ID
            dr1 = cmd2.ExecuteReader
            dr1.Read()
            If dr1.HasRows Then


                SupplierChartOfAccountID = dr1.Item("Chart of Account ID").ToString
            End If
            dr1.Close()


            cmd.Connection = con
            cmd.CommandText = "select ((isnull(sum([Credited Amount]),0)) - isnull(sum([Debited Amount]),0) ) as [Amount]  from [Ledger] where [Ledger].[Chart Of Account ID]= '" + SupplierChartOfAccountID + "' and not  [Ledger].[Status]= 'WithHeld'"

            dr = cmd.ExecuteReader()
            dr.Read()




            If dr.HasRows Then

                If Val(dr.Item("Amount")) > 0 Then
                    Me.TxtPreviousDues.Text = Val(dr.Item("Amount").ToString)
                    Me.TxtAdvance.Text = ""

                ElseIf Val(dr.Item("Amount")) < 0 Then

                    Me.TxtAdvance.Text = Val(dr.Item("Amount").ToString) * -1
                    Me.TxtPreviousDues.Text = ""
                End If



            End If




            dr.Close()
            con.Close()





        Catch ex As Exception

        End Try

    End Sub


    Private Sub CmbSupplierName_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbSupplierName.SelectedValueChanged


    End Sub

    Private Sub CmbPaymentStatus_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Me.TxtPaidAmount.Focus()
        End If
    End Sub

    Private Sub CmbPaymentStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Focus on paid Amount
        TxtPaidAmount.Focus()
    End Sub

    Private Sub TxtTotal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTotal.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtVatPercentage.Focus()
        End If
    End Sub

    Private Sub TxtTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTotal.TextChanged

    End Sub

    Private Sub TxtPreviousDues_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPreviousDues.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TxtAdvance.Focus()
        End If
    End Sub

    Private Sub TxtPreviousDues_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPreviousDues.TextChanged

    End Sub

    Private Sub TxtAdvance_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtAdvance.KeyDown
        If e.KeyCode = Keys.Enter Then

            'Calculate return amount
            TxtReturnAmount.Text = Val(TxtReturnAmount.Text) - Val(TxtAdvance.Text)


            Btnsave.Focus()

        End If
    End Sub

    Private Sub TxtAdvance_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtAdvance.TextChanged

    End Sub

    Private Sub TxtVatPercentage_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtVatPercentage.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TxtVat.Focus()
        End If
    End Sub

    Private Sub TxtVatPercentage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtVatPercentage.TextChanged
        'Calculate Vat
        TxtVat.Text = (Val(TxtTotal.Text) * Val(TxtVatPercentage.Text)) / 100
        'Calculate netpayable amount
        NetpayableAmount()

    End Sub

    Private Sub TxtVat_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtVat.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TxtDiscountPercentage.Focus()
        End If
    End Sub

    Private Sub TxtVat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtVat.TextChanged
        'Calculate netpayable amount
        NetpayableAmount()

    End Sub

    Private Sub TxtDiscount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDiscount.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TxtNetPayable.Focus()
        End If
    End Sub

    Private Sub TxtDiscount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDiscount.TextChanged
        'Calculate netpayable amount
        NetpayableAmount()

    End Sub

    Private Sub TxtDiscountPercentage_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDiscountPercentage.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TxtDiscount.Focus()
        End If
    End Sub
    Sub NetpayableAmount()

        'Calculate Net Payable Amount
        TxtNetPayable.Text = ((Val(TxtTotal.Text) + Val(TxtPreviousDues.Text) + Val(TxtVat.Text)) - (Val(TxtDiscount.Text) + Val(TxtAdvance.Text)))

    End Sub


    Private Sub TxtDiscountPercentage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDiscountPercentage.TextChanged
        'Discount Percentage
        DiscountAndPercentage()
        'Calculate netpayable amount
        NetpayableAmount()
    End Sub

    Private Sub TxtNetPayable_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNetPayable.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TxtPaidAmount.Focus()

            If TxtPaidAmount.ReadOnly = False Then
                TxtPaidAmount.Text = TxtNetPayable.Text
            End If

        End If
    End Sub

    Private Sub TxtNetPayable_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNetPayable.TextChanged

    End Sub

    Private Sub TxtPaidAmount_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtPaidAmount.GotFocus

    End Sub

    Private Sub TxtPaidAmount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPaidAmount.KeyDown
        'CalCulate Return amount and focus on return amount if cash of due
        If e.KeyCode = Keys.Enter Then

            'Calculation Of Balance And ReturnAmount
            CalculationOfBalanceAndReturnAmount()


            If Val(TxtPaidAmount.Text) <= 0 Then
                CmbPaidBy.Text = "DUE"
                TxtBalance.Text = "00"
            ElseIf Val(TxtPaidAmount.Text) > 0 Then
                CmbPaidBy.Text = "CASH"
            End If
        End If
    End Sub

    'Calculation Of Balance And ReturnAmount
    Sub CalculationOfBalanceAndReturnAmount()
        Try


            If Val(TxtPaidAmount.Text) >= Val(TxtNetPayable.Text) Then

                'Calculate Return amount
                TxtReturnAmount.Text = Val(TxtPaidAmount.Text) - Val(TxtNetPayable.Text)

                'Calculate Balance amount
                TxtBalance.Text = Val(TxtPaidAmount.Text) - Val(TxtReturnAmount.Text)

                CmbPaidBy.Focus()

            ElseIf Val(TxtPaidAmount.Text) < Val(TxtNetPayable.Text) Then

                'Calculate Balance amount
                TxtBalance.Text = Val(TxtNetPayable.Text) - Val(TxtPaidAmount.Text)
                TxtReturnAmount.Text = "00"
                CmbPaidBy.Focus()

            End If


            If Val(TxtPaidAmount.Text) <= 0 Then
                CmbPaidBy.Text = "DUE"
                TxtBalance.Text = "00"
            ElseIf Val(TxtPaidAmount.Text) > 0 Then

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxtPaidAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPaidAmount.TextChanged

    End Sub

    Private Sub TxtPurchaseInvoiceNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPurchaseInvoiceNo.KeyDown



        If e.KeyCode = Keys.Enter Then
            ' Load Data
            Try



                'refreshdata
                RefreshData()

                'Search Purchase Invoice
                SearchPurchaseInvoice()




            Catch ex As Exception
                MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records on keydown")
            Finally

            End Try

        End If
    End Sub

    'Search Purchase Invoice
    Sub SearchPurchaseInvoice()


        Try





            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader


            'Data reader for Product Id
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Purchase Invoice] join [Supplier information] on[Purchase Invoice].[Supplier ID]=[Supplier information].[Supplier ID] join [Chart of Account] on [Purchase Invoice].[Paid By]=[Chart of Account].[Chart of Account ID]  WHERE [purchase Invoice].[Purchase Invoice No] =  '" + TxtPurchaseInvoiceNo.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then


                Me.CmbSupplierName.Text = (dr.Item("Supplier Name").ToString)
                Me.CmbSupplierName.ValueMember = (dr.Item("Supplier ID").ToString)

                TxtMemoNo.Text = (dr.Item("Memo No").ToString)

                TxtDiscountPercentage.Text = (dr.Item("Discount Percentage").ToString)
                TxtDiscount.Text = Double.Parse((dr.Item("Discount").ToString)).ToString
                CmbPaidBy.SelectedValue = (dr.Item("Paid By").ToString)
                CmbPaidBy.Text = (dr.Item("Account Name").ToString)
                TxtPaidAmount.Text = Double.Parse((dr.Item("Paid Amount").ToString)).ToString
                TxtBalance.Text = Double.Parse((dr.Item("Balance").ToString)).ToString
                TxtReturnAmount.Text = Double.Parse((dr.Item("Return Amount").ToString)).ToString
                TxtNetPayable.Text = Double.Parse((dr.Item("Net Payable").ToString)).ToString
                TxtPreviousDues.Text = Double.Parse((dr.Item("Previous Dues").ToString)).ToString
                TxtAdvance.Text = Double.Parse((dr.Item("Advance").ToString)).ToString
                TxtVatPercentage.Text = (dr.Item("Vat Percentage").ToString)
                TxtVat.Text = Double.Parse((dr.Item("Vat").ToString)).ToString

            End If
            dr.Close()

            con.Close()




            'Focus on Product name
            CmbProductName.Focus()




        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records on keydown")
        Finally

        End Try


    End Sub
    'Search Product Id From Products by barcode serial number and insert into sale
    Sub SearchBarcodeSerialNumberAndShowProducts()

        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader







            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Select * from [Products] where [Barcode Serial]='" + TxtSearchBarcode.Text + "'"

            'Search Product ID And Name And Set It In Variable
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then
                CmbProductName.Text = dr.Item("Product Name").ToString
                CmbProductName.ValueMember = dr.Item("Product ID").ToString
                TxtPurchaseUnitCost.Text = dr.Item("Purchase Price").ToString
                CmbLocationID.Focus()

            ElseIf Not dr.HasRows Then
                MsgBox("No product found.", MsgBoxStyle.Critical, "Purchase")

                'Clear Data
                cleardataProduct()

                'Focus on search barcode
                TxtSearchBarcode.Focus()

            End If
            dr.Close()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxtPurchaseInvoiceNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPurchaseInvoiceNo.TextChanged

    End Sub

    'Delete full invoice
    Sub DeleteFullInvoice()

        Try

            Dim con1 As New SqlConnection
            Dim cmd1 As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now

            con1.ConnectionString = FrmHome.ConnectionString
            con1.Open()
            cmd1.Connection = con1
            cmd1.CommandText = "Delete from [Purchase Invoice] where [Purchase Invoice No]= '" + TxtPurchaseInvoiceNo.Text + "'    Delete from [Purchase] where [Purchase Invoice No]= '" + TxtPurchaseInvoiceNo.Text + "'"
            cmd1.ExecuteNonQuery()

            con1.Close()


            'Delete Supplier Ledger
            DeleteSupplierLedger()

            'Delete From Purchase Serial Delete Button
            DeleteFromPurchaseSerialNumberDeleteButton()

            'Clear all data
            ClearAllData()



            'Focus Supplier Combobx 
            CmbSupplierName.Focus()

            'new  invoice
            Newinvoice()

            'Refresh Data
            RefreshData()


            'Row clear Code
            GrdAvailableSerialNumber.Columns.Clear()
            GrdPurchase.Columns.Clear()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Try

            If Not CmbSupplierName.ValueMember = "" Or Not CmbSupplierName.Text = "" Then





                Dim q As MsgBoxResult
                q = MsgBox("Do you really want to Delete Invoice?", MsgBoxStyle.YesNo, "Purchase")
                If q = MsgBoxResult.Yes Then
                    'Insert into log code For Delete
                    InsertIntoLogForDelete()

                    'Delete full invoice
                    DeleteFullInvoice()

                End If




            Else

                MsgBox("Please Insert Invoice Number First.", MsgBoxStyle.OkOnly, "Purchase")

            End If
        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader


            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + FrmHome.LblUserID.Text + "' AND [Category Name] = 'Purchase History'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then


                FrmPurchaseHistory.Show()
                FrmPurchaseHistory.TxtSearchPurchaseInvoice.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Permission for SaleHistory")
        End Try







    End Sub

    Private Sub TxtBalance_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBalance.TextChanged

    End Sub

    Private Sub CmbProductName_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbProductName.KeyDown
        If e.KeyCode = Keys.Down Then

            GrdProductList.Visible = True

            GrdProductList.Focus()

        ElseIf e.KeyCode = Keys.Enter Then

            If CmbSupplierName.Text = "" Then

                MsgBox("Please Select Supplier", MsgBoxStyle.OkOnly, "Purchase")
                CmbSupplierName.Focus()

            Else


                'Show Product Details To Text boxes
                ShowProductDetailsToTextboxes()


                'Clear Data Product For add new product
                'cleardataProduct()

                'FrmListofProducts.Show()
                'FrmListofProducts.TxtSearchProductName.Focus()
                'FrmListofProducts.Label1.Text = "Purchase"
            End If
        ElseIf e.KeyCode = Keys.Space AndAlso e.Control Then

            NetpayableAmount()

            If TxtPaidAmount.ReadOnly = False Then

                If Val(TxtNetPayable.Text) < 0 Then
                    TxtPaidAmount.Text = 0

                Else
                    TxtPaidAmount.Text = Val(Me.TxtNetPayable.Text)
                End If

            End If


            TxtPaidAmount.Focus()


        ElseIf e.KeyCode = Keys.F2 Then
            'Clear Data Product
            cleardataProduct()

            'Focus on cmb Product name
            CmbProductName.Focus()

            'Refresh Data Serial Number To Gridview Click
            RefreshDataSerialNumberToGridviewForCellMouseClick()
        End If


    End Sub




    Private Sub GrpAmount_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrpAmount.Enter

    End Sub

    Private Sub CmbPaidBy_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbPaidBy.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Btnsave.PerformClick()

        End If
    End Sub

    Private Sub CmbPaidBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbPaidBy.SelectedIndexChanged
        If CmbPaidBy.Text = "DUE" Then
            TxtPaidAmount.Text = "00"
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click


        If Not TxtPurchaseInvoiceNo.Text = "" And Not PurchaseEditStatus = True Then

            Dim q As MsgBoxResult = MsgBox("Do you want to keep this Invoice as draft?", MsgBoxStyle.YesNoCancel, "Purchase")

            If q = MsgBoxResult.No Then

                'Insert into log code For Delete
                InsertIntoLogForDelete()

                'Delete Full Invoice
                DeleteFullInvoice()
            ElseIf q = MsgBoxResult.Yes Then

                'Clear All Data
                ClearAllData()

                'New Invoice
                Newinvoice()

                'Row clear Code
                GrdAvailableSerialNumber.Columns.Clear()
                GrdPurchase.Columns.Clear()

                'Focus on Custome  name
                CmbSupplierName.Focus()

            End If




        ElseIf Not TxtPurchaseInvoiceNo.Text = "" And PurchaseEditStatus = True Then

            If (MessageBox.Show(" Are you sure want to creat new invoice?", "Bizpro", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then


                'Clear All Data
                ClearAllData()

                'New Invoice
                Newinvoice()

                'Row clear Code
                GrdAvailableSerialNumber.Columns.Clear()
                GrdPurchase.Columns.Clear()

                'Focus on supplier  name
                CmbSupplierName.Focus()

            End If

        End If

    End Sub

    Private Sub GrpPaymentInfo_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrpPaymentInfo.Enter

    End Sub

    Private Sub GrpSupplierInformation_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrpSupplierInformation.Enter

    End Sub

    'Find Purchase ID To Show In Lable
    Sub FindPurchaseIDToShowInLable()

        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            'Data reader for Product Id
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Purchase]  WHERE  [Purchase Invoice No]= '" + TxtPurchaseInvoiceNo.Text + "' And [Product ID] ='" + CmbProductName.ValueMember + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                LblPurchaseID.Text = (dr.Item("Purchase ID").ToString)


            End If
            dr.Close()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TxtSerialNumber_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSerialNumber.KeyDown

        If e.KeyCode = Keys.Enter Then

            If TxtSerialNumber.Text = "" Then
                TxtWarrantyDays.Focus()
            Else

                'Insert Into Purchase Invoice
                InsertIntoPurchaseInvoice()


                'If Purchase invoice no is blank would not insert into Purchase
                If Not TxtPurchaseInvoiceNo.Text = "" Then





                    'Show serial number which is inserted in temporary table
                    ShowSerial()
                    'Insert single serial number to purchase serial number
                    InsertSingleSerialtoPurchaseSerialNumber()

                    'Total Serial Number Count And show in quantity field
                    NUmberOfRow()

                    'Calculate Amount
                    'TxtPurchaseAmount.Text = Val(TxtQuantity.Text) * Val(TxtPurchaseUnitCost.Text)


                    'Insert or update data
                    InsertOrUpdatePurchase()

                    'Find Purchase ID To Show In Lable
                    FindPurchaseIDToShowInLable()


                    'Refresh Data After insert or update sale
                    RefreshData()





                    TxtSerialNumber.Clear()

                End If



            End If


        End If


    End Sub

    Sub ShowSerial()
        Dim con2 As New SqlConnection
        Dim cmd2 As New SqlCommand
        Dim dr1 As SqlDataReader

        con2.ConnectionString = FrmHome.ConnectionString
        con2.Open()
        cmd2.Connection = con2
        cmd2.CommandText = "SELECT * FROM [Serial No] where [Serial Number] = '" + TxtSerialNumber.Text + "' "

        dr1 = cmd2.ExecuteReader()
        dr1.Read()

        If dr1.HasRows Then

            RefreshDataForSingleSerial()

        ElseIf Not dr1.HasRows Then


            'Insert New Single Serial Number
            InsertNewSingleSerialNumber()

            ' Refresh Data For Single Serial
            RefreshDataForSingleSerial()


        End If
        dr1.Close()
        con2.Close()


    End Sub

    'Refresh Data For Single Serial
    Sub RefreshDataForSingleSerial()

        Try
            ' Load Data
             
            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select  [Serial No].[Serial Number] from [Serial No] where [Serial Number] = '" + TxtSerialNumber.Text + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "Bizpro_Serial No")
            connection.Close()
            GrdAvailableSerialNumber.DataSource = ds
            GrdAvailableSerialNumber.DataMember = "Bizpro_Serial No"

            'GrdProductSubcategory.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductSubcategory.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            GrdAvailableSerialNumber.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            'Row Count
            'NUmberOfRow()



            'End Refresh Data
        Catch ex As Exception
            MessageBox.Show("Error while refreshing record on table..." & ex.Message, "Refresh Records")
        Finally


        End Try

    End Sub
    'Refresh Data For Single Serial
    Sub RefreshDataForRangeSerial()

        Try
            ' Load Data
             
            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT ('" + FirstValue + "'+  RIGHT('000'+CAST([Serial No].[Serial Number] AS VARCHAR(4)),4))[Purchase Serial Number]  from [Serial No] where [Serial Number] between  " + LastFromValue + " and " + LastToValue + ""
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "Bizpro_Serial No")
            connection.Close()
            GrdAvailableSerialNumber.DataSource = ds
            GrdAvailableSerialNumber.DataMember = "Bizpro_Serial No"

            'GrdProductSubcategory.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductSubcategory.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            GrdAvailableSerialNumber.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            'Row Count
            NUmberOfRow()




        Catch ex As Exception
            MessageBox.Show("Error while refreshing record on table..." & ex.Message, "Refresh Records")
        Finally
        End Try

    End Sub
    'Total gridview line show in label code
    Sub NUmberOfRow()

        Try



            Dim total As String = 0

            total = GrdAvailableSerialNumber.Rows.Count

            Me.TxtQuantity.Text = total



        Catch ex As Exception

        End Try

    End Sub
    'Insert New Serial Number

    Sub InsertNewRangeSerialNumber()
        Try
            'Find the first section of the Textbox



            'Data Insert Code
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now


            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "DECLARE @num bigint = '" + LastFromValue + "'  WHILE(@num<='" + LastToValue + "')   begin INSERT  INTO [Serial No]   ([Serial Number]) VALUES (@num)   SET @num = @num + 1 end"

            cmd.ExecuteNonQuery()


            con.Close()


        Catch ex As Exception
            MessageBox.Show("Error while Selecting All record on table..." & ex.Message, "Select all Button")
        Finally
        End Try








    End Sub

    'Insert New Single Serial Number 
    Sub InsertNewSingleSerialNumber()

        Try
            'Data Insert Code
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now



            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO [Serial No]([serial Number]) VALUES ('" + TxtSerialNumber.Text + "') "


            cmd.ExecuteNonQuery()


            con.Close()


        Catch ex As Exception
            MessageBox.Show("Error while Selecting All record on table..." & ex.Message, "Select all Button")
        Finally

        End Try

    End Sub

    Private Sub TxtSerialNumber_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TxtSerialNumber.MouseClick
        'Range Serial Number is checking off clicking serial number
        RdbRangeSerial.Checked = False
    End Sub

    Private Sub TxtSerialNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSerialNumber.TextChanged
        'Change all text entered to be Upercase.
        TxtSerialNumber.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub TxtToSerial_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtToSerial.KeyDown

        If e.KeyCode = Keys.Enter Then

            Try


                Dim TL As Integer
                TL = Me.TxtFromSerial.TextLength - 4
                Me.TxtFromSerial.SelectionStart = 0
                Me.TxtFromSerial.SelectionLength = TL

                Dim First As String
                First = (Me.TxtFromSerial.SelectedText)

                FirstValue = First


                'Find the Last Section of the From Serail Text Box
                Dim s As String = Me.TxtFromSerial.Text

                Dim LastFrom As String
                LastFrom = (s.Substring(s.Length - 4))
                LastFromValue = LastFrom


                'Find the Last Section of the To Serail Text Box
                Dim L As String = Me.TxtToSerial.Text
                Dim LastTo As String
                LastTo = (L.Substring(L.Length - 4))
                LastToValue = LastTo




                'Insert Into Purchase Invoice
                InsertIntoPurchaseInvoice()

                'If Purchase invoice no is blank would not insert into Purchase
                If Not TxtPurchaseInvoiceNo.Text = "" Then





                    Dim con2 As New SqlConnection
                    Dim cmd2 As New SqlCommand
                    Dim dr1 As SqlDataReader

                    con2.ConnectionString = FrmHome.ConnectionString
                    con2.Open()
                    cmd2.Connection = con2
                    cmd2.CommandText = "SELECT * FROM [Serial No] where [Serial Number] Between " + LastFromValue + " And  " + LastToValue + " "

                    dr1 = cmd2.ExecuteReader()
                    dr1.Read()

                    If dr1.HasRows Then


                        'delete For New Serial Insert
                        deleteForNewSerialInsert()

                        'Insert New Single Serial Number
                        InsertNewRangeSerialNumber()


                        'Refresh Data For Single Serial
                        RefreshDataForRangeSerial()



                    ElseIf Not dr1.HasRows Then


                        'Insert New Single Serial Number
                        InsertNewRangeSerialNumber()

                        ' Refresh Data For Single Serial
                        RefreshDataForRangeSerial()



                    End If





                    dr1.Close()
                    con2.Close()


                    TxtPurchaseUnitCost.Focus()



                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If


    End Sub

    Private Sub TxtToSerial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtToSerial.TextChanged
        'Change all text entered to be Upercase.
        TxtToSerial.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub CmbProductName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbProductName.KeyPress
        'e.Handled = True
    End Sub

    Private Sub CmbProductName_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CmbProductName.MouseClick
        'Resize Product List Gridview and Make it Visible
        ResizeProductListGridviewandMakeitVisible()

        ' Search By Product Name 
        SearchByProductName()

        'hide Location List gridview
        GrdLocationList.Hide()

    End Sub

    Private Sub CmbProductName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbProductName.SelectedIndexChanged

    End Sub
    'Show product details to textbox
    Sub ShowProductDetailsToTextboxes()
        Try

            Dim i As Integer
            i = GrdProductList.CurrentRow.Index






            'Show value member to combobox
            CmbProductName.ValueMember = GrdProductList.Item(0, i).Value



            'FrmSale.TxtPurchaseID.Text = GrdStockInformation.Item(1, i).Value

            TxtPurchaseUnitCost.Text = GrdProductList.Item(2, i).Value


            TxtWarrantyDays.Text = "00"
            CmbLocationID.Focus()
            FindPurchaseIDToShowInLableWhileSelectingNewProduct()



            'Privet sub for Search Purchase Price on supplier
            SearchPurchasePriceFromSupplier()


            'Show Product name to combobox
            CmbProductName.Text = GrdProductList.Item(1, i).Value






            'Auto select Location Details
            AutoSelectLocationDetails()

            'hide product list gridview
            GrdProductList.Visible = False




        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

        End Try
    End Sub
    'Show Location details to Combobox
    Sub ShowLocationDetailsToCombobox()
        Try

            Dim i As Integer
            i = GrdLocationList.CurrentRow.Index






            'Show value member to combobox
            CmbLocationID.ValueMember = GrdLocationList.Item(0, i).Value
            CmbLocationID.Text = GrdLocationList.Item(1, i).Value



            TxtQuantity.Focus()


            'hide product list gridview
            GrdLocationList.Visible = False




        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

        End Try
    End Sub

    Private Sub RdbRangeSerial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdbRangeSerial.CheckedChanged


        If RdbRangeSerial.Checked = True Then
            TxtFromSerial.Enabled = True

            TxtToSerial.Enabled = True

            TxtFromSerial.Focus()
            TxtSerialNumber.Text = ""

        ElseIf RdbRangeSerial.Checked = False Then
            TxtFromSerial.Enabled = False

            TxtToSerial.Enabled = False

        End If


    End Sub

    Private Sub GrdAvailableSerialNumber_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdAvailableSerialNumber_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdAvailableSerialNumber_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

    End Sub

    Private Sub GrdAvailableSerialNumber_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)





    End Sub
    'Refresh Data For Single Serial After Delete a Serial number
    Sub RefreshDataToSerialNumber()

        Try
            ' Load Data


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select  [Purchase Serial Number].[Purchase Serial Number] from [Purchase Serial Number] where [Product ID] = '" + CmbProductName.ValueMember + "' and [Purchase Invoice No] = '" + TxtPurchaseInvoiceNo.Text + "' "
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

            'Row Count
            NUmberOfRow()


            'End Refresh Data
        Catch ex As Exception
            MessageBox.Show("Error while refreshing record on table..." & ex.Message, "Refresh Records")
        Finally


        End Try

    End Sub

    Private Sub TxtPurchaseAmount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPurchaseAmount.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtPurchaseUnitCost.Focus()

            TxtPurchaseUnitCost.Text = Val((TxtPurchaseAmount.Text) / Val(TxtQuantity.Text))

        End If
    End Sub


    Private Sub TxtPurchaseAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPurchaseAmount.TextChanged
        'calculate Purchase unit price
        ''
    End Sub

    Private Sub TxtFromSerial_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtFromSerial.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TxtToSerial.Focus()
        End If
    End Sub

    Private Sub TxtFromSerial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtFromSerial.TextChanged
        'Change all text entered to be Upercase.
        TxtFromSerial.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInvoice.Click

        'Send purchase invoice no to RptPurchase 
        RptPurchaseInvoice.PurchaseInvoiceNo = TxtPurchaseInvoiceNo.Text


        If Not ShowInvoicePermision = "No" Then
            RptPurchaseInvoice.ShowInvoice()
            RptPurchaseInvoice.Show()
        Else

            MsgBox("You do not have permission to open invoice.")
        End If
    End Sub

    Private Sub TxtMemoNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtMemoNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbProductName.Focus()


        End If
    End Sub

    Private Sub TxtMemoNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtMemoNo.TextChanged

    End Sub

    Private Sub TxtWarrantyDays_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtWarrantyDays.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtPurchaseUnitCost.Focus()
        End If
    End Sub


    Private Sub TxtWarrantyDays_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtWarrantyDays.TextChanged

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtSearchBarcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearchBarcode.KeyDown
        If e.KeyCode = Keys.Enter Then

            If CmbSupplierName.Text = "" Then
                MsgBox("Please Select a Customer First.", MsgBoxStyle.OkOnly, "Purchase")

                'Focus on Customer 'Combobox
                CmbSupplierName.Focus()
            Else
                ' Search Barcode Serial Number And Show Products
                SearchBarcodeSerialNumberAndShowProducts()
            End If
        End If
    End Sub

    Private Sub TxtSearchBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearchBarcode.TextChanged

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

    Private Sub GrdAvailableSerialNumber_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdAvailableSerialNumber.CellContentClick

    End Sub

    Private Sub GrdAvailableSerialNumber_CellMouseDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdAvailableSerialNumber.CellMouseDoubleClick
        Try
            If DeletePermission = "Yes" Then
                If e.RowIndex >= 0 Then
                    Dim row As DataGridViewRow
                    row = Me.GrdAvailableSerialNumber.Rows(e.RowIndex)



                    Dim con As New SqlConnection
                    Dim cmd As New SqlCommand
                    Dim cmd3 As New SqlCommand
                    Dim currentDate As DateTime = DateTime.Today
                    Dim currentTime As DateTime = DateTime.Now
                    Dim Dr As SqlDataReader


                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd3.Connection = con
                    cmd3.CommandText = "Select * From [Purchase] join [Products] on Purchase.[Product ID]=products.[Product ID] join [Location Information] on Purchase.[Purchase Location ID]=[Location Information].[Location ID]  Where [Purchase ID]= '" + LblPurchaseID.Text + "'"

                    Dr = cmd3.ExecuteReader
                    Dr.Read()
                    If Dr.HasRows Then



                        CmbProductName.Text = Dr.Item("Product Name").ToString
                        CmbProductName.ValueMember = Dr.Item("Product ID").ToString
                        TxtQuantity.Text = Dr.Item("Purchase Quantity").ToString

                        TxtPurchaseUnitCost.Text = Dr.Item("Purchase Unit Cost").ToString
                        TxtPurchaseAmount.Text = Dr.Item("Amount").ToString
                        LblPurchaseID.Text = Dr.Item("Purchase ID").ToString
                        TxtWarrantyDays.Text = Dr.Item("Warranty Days").ToString
                        CmbLocationID.ValueMember = Dr.Item("Purchase Location ID").ToString
                        CmbLocationID.Text = Dr.Item("Location Name").ToString
                    End If
                    Dr.Close()



                    cmd.Connection = con
                    cmd.CommandText = "Delete from [Purchase Serial Number] where [Purchase Invoice No]= '" + TxtPurchaseInvoiceNo.Text + "' And [Product ID]= '" + CmbProductName.ValueMember + "' And [Purchase Serial Number]= '" + row.Cells("Purchase Serial Number").Value.ToString + "' "
                    cmd.ExecuteNonQuery()
                    con.Close()


                    'Refresh Data For Single Serial After Delete a Serial number
                    RefreshDataToSerialNumber()

                    'Count Total Serial Number
                    NUmberOfRow()


                    'Calculate Purchase amount
                    TxtPurchaseAmount.Text = Val(TxtQuantity.Text) * Val(TxtPurchaseUnitCost.Text)

                    'Insert or update data
                    InsertOrUpdatePurchase()


                    'Refresh Data After insert or update Purchase 
                    RefreshData()


                    'Making Clear Data For Products Update Serial Number
                    CleardataProductForUpdateSerialNumber()


                    'Focus Purchase unit cost
                    TxtPurchaseUnitCost.Focus()

                End If
            Else
                MsgBox("You do not have permission to delete purchase.", MsgBoxStyle.Critical, "Purchase")
            End If

        Catch ex As Exception
            MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Records Purchase Serial")
        Finally

        End Try
        'Update Purchase Invoice
    End Sub

    Private Sub GrdPurchase_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdPurchase.CellContentClick

    End Sub

    Private Sub GrdPurchase_CellFormatting1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles GrdPurchase.CellFormatting
        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader




            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + FrmHome.LblUserID.Text + "' AND [Category Name] = 'VIEW PRICE PERMISSION' And [Update Delete Permission]='YES'"


            dr = cmd.ExecuteReader()
            dr.Read()




            If Not dr.HasRows Then

                If GrdPurchase.Columns(e.ColumnIndex).Name.Equals("Purchase Unit Cost") Then

                    If (Not e.Value Is Nothing) Then
                        e.Value = New String(CChar("*"), e.Value.ToString.Length)

                    End If

                ElseIf GrdPurchase.Columns(e.ColumnIndex).Name.Equals("Amount") Then
                    If (Not e.Value Is Nothing) Then
                        e.Value = New String(CChar("*"), e.Value.ToString.Length)

                    End If
                End If



            End If
            dr.Close()
            con.Close()




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub GrdPurchase_CellMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdPurchase.CellMouseClick
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdPurchase.Rows(e.RowIndex)

                LblPurchaseID.Text = row.Cells("Purchase ID").Value.ToString
                CmbProductName.Text = row.Cells("Product Name").Value.ToString
                TxtQuantity.Text = row.Cells("Purchase Quantity").Value.ToString
                CmbLocationID.Text = row.Cells("Location Name").Value.ToString
                TxtPurchaseUnitCost.Text = Double.Parse(row.Cells("Purchase Unit Cost").Value.ToString).ToString
                TxtPurchaseAmount.Text = Double.Parse(row.Cells("Amount").Value.ToString).ToString
                TxtWarrantyDays.Text = row.Cells("Warranty Days").Value.ToString
                ' TxtSerialNumber.Text = row.Cells("Purchase Serial Number").Value.ToString

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim dr As SqlDataReader


                'Data reader for Product Id
                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "SELECT  *FROM [Purchase]  WHERE [Purchase ID] = '" + LblPurchaseID.Text + "'"
                dr = cmd.ExecuteReader()
                dr.Read()

                Me.CmbProductName.ValueMember = (dr.Item("Product ID").ToString)
                Me.CmbLocationID.ValueMember = (dr.Item("Purchase Location ID").ToString)
                dr.Close()

                con.Close()





                'Refresh Data Serial Number To Gridview Click
                RefreshDataSerialNumberToGridviewForCellMouseClick()

            End If

            'Focus on product name
            CmbProductName.Focus()


        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview")

        End Try

    End Sub

    Private Sub GrdPurchase_CellMouseDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdPurchase.CellMouseDoubleClick
        Try


       
            If Me.LblPurchaseID.Text = "" Then
                MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Purchase")

            Else


                'Data Delete Code
                Dim q As MsgBoxResult
                q = MsgBox("Do you really want to Delete the row?", MsgBoxStyle.YesNo, "Purchase")
                If q = MsgBoxResult.Yes Then

                    Dim con As New SqlConnection
                    Dim cmd As New SqlCommand
                    Dim currentDate As DateTime = DateTime.Today
                    Dim currentTime As DateTime = DateTime.Now

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "Delete from [Purchase] where [Purchase ID]= '" + LblPurchaseID.Text + "'"
                    cmd.ExecuteNonQuery()
                    con.Close()


                    'Delete From Purchase Serial NumberDoubleClick
                    DeleteFromPurchaseSerialNumberDoubleClick()

                    'Refresh Data Serial Number To Gridview ForCell Mouse Click
                    RefreshDataSerialNumberToGridviewForCellMouseClick()


                    'Refresh Data
                    RefreshData()


                    'Making Clear
                    cleardataProduct()

                    'focus on product textbox
                    CmbProductName.Focus()


                End If
            End If
      
        Catch ex As Exception
            MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Records")
        Finally

        End Try
    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= (X)
            newpoint.Y -= (Y)
            Me.Location = newpoint

        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
    'Search By Supplier Name For Current Branch
    Sub SearchBySupplierNameForCurrentBranch()
        ' Load Data
        Try


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select  [Supplier ID], [Supplier Name],[Mobile No] from [Supplier Information] where [Supplier Name]+[Mobile No] LIKE '%" + CmbSupplierName.Text + "%' or [Supplier Name] LIKE '%" + CmbSupplierName.Text + "%'"


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Supplier Information")
            connection.Close()
            GrdSupplierList.DataSource = ds
            GrdSupplierList.DataMember = "BizPro_Supplier Information"


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            GrdSupplierList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

            If GrdSupplierList.RowCount < 1 Then
                GrdSupplierList.Visible = False
            End If

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records")
        Finally

        End Try

        'End Refresh Data

    End Sub

    Sub ResizeSupplierListGridviewAndMakeitVisible()

        GrdSupplierList.Visible = True
        GrdSupplierList.Width = 400
        GrdSupplierList.Height = 113

        'Column visiblity false
        GrdSupplierList.ColumnHeadersVisible = False

    End Sub

    Private Sub CmbSupplierName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbSupplierName.TextChanged

        If Not CmbSupplierName.Text = "" Then
            'Resize Supplier List Grid view And Make it Visible
            ResizeSupplierListGridviewAndMakeitVisible()

            'Search By Supplier Name For Current Branch
            SearchBySupplierNameForCurrentBranch()





        ElseIf CmbSupplierName.Text = "" Then

            GrdSupplierList.Visible = False

            'Clear Data Products For Drop down
            cleardataSupplier()

        End If
    End Sub
    'Show Supplier Details In Textboxs
    Sub ShowSupplierDetailsInTextboxs()
        Try

            Dim i As Integer
            i = GrdSupplierList.CurrentRow.Index




            'Show Supplier name and valumember
            CmbSupplierName.ValueMember = GrdSupplierList.Item(0, i).Value

            'Show Product name to combobox
            CmbSupplierName.Text = GrdSupplierList.Item(1, i).Value



            SupplierInformation()

            'Show Supplier Dues or advanced
            ShowDueOrAdvance()


            'CalCulate Netpayable
            NetpayableAmount()

            'Calculation Of Balance And ReturnAmount
            CalculationOfBalanceAndReturnAmount()


            'Focus on product combobox
            CmbProductName.Focus()






            'hide product list gridview
            GrdSupplierList.Visible = False




        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

        End Try
    End Sub

    Private Sub FrmPurchase_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        'Hide Supplier list
        GrdSupplierList.Visible = False
        'Hide product list
        GrdProductList.Visible = False

        'Hide Location list
        GrdLocationList.Visible = False
    End Sub

    Private Sub GrdSupplierList_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdSupplierList.CellContentClick

    End Sub

    Private Sub GrdSupplierList_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdSupplierList.CellMouseClick

    End Sub

    Private Sub GrdSupplierList_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdSupplierList.CellMouseDoubleClick
        'Show Supplier Details In Textboxs
        ShowSupplierDetailsInTextboxs()
    End Sub

    Private Sub GrdSupplierList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdSupplierList.KeyDown
        If e.KeyCode = Keys.Enter Then

            'Show Supplier Details In Textboxs
            ShowSupplierDetailsInTextboxs()

        End If
    End Sub

    Private Sub TxtPhoneNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPhoneNo.KeyDown

        If e.KeyCode = Keys.Enter Then
            TxtAddress.Focus()
        End If
    End Sub

    Private Sub TxtPhoneNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPhoneNo.TextChanged

    End Sub

    Private Sub TxtAddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtAddress.KeyDown

        If e.KeyCode = Keys.Enter Then
            CmbProductName.Focus()
        End If
    End Sub

    Private Sub TxtAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtAddress.TextChanged

    End Sub

    Private Sub Button2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    'Privet sub for Search Purchase Price on supplier
    Sub SearchPurchasePriceFromSupplier()


        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        con.ConnectionString = FrmHome.ConnectionString
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT  *FROM [Supplier price list]  WHERE [Product ID] = '" + CmbProductName.ValueMember + "' and [Supplier ID]= '" + CmbSupplierName.ValueMember + "' "

        dr = cmd.ExecuteReader()
        dr.Read()

        If dr.HasRows Then

            TxtPurchaseUnitCost.Text = (dr.Item("Price").ToString)

        End If




        dr.Close()
        con.Close()
    End Sub
    'Search By Product Name 
    Sub SearchByProductName()
        ' Load Data
        Try


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select  [Product ID],[Product Name],[Purchase Price],[Product Subcategory Name] from [Products] join [Product Subcategory] on [Products].[Product Subcategory ID]= [Product Subcategory].[Product Subcategory ID]where products. [Product Name] LIKE '%" + CmbProductName.Text + "%'"


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Products")
            connection.Close()
            GrdProductList.DataSource = ds
            GrdProductList.DataMember = "BizPro_Products"


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            GrdProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells


        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records")
        Finally

        End Try

        'End Refresh Data

    End Sub

    'Auto select Location Details
    Sub AutoSelectLocationDetails()
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  [Location Information].[Location ID],[Location Information].[Location Name], [Branch Information].[Branch Name],(select count(*) from [Location Information] where [Branch ID]=[Branch Information].[Branch ID])[Total]  FROM [Location Information] join [Branch Information] on [Location Information].[Branch ID] = [Branch Information].[Branch ID]  WHERE ( [Branch Information].[Branch ID]='" + FrmHome.lblBranchID.Text + "')"


            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                If Val(dr.Item("Total")) = 1 Then

                    CmbLocationID.Text = dr.Item("Location Name").ToString
                    CmbLocationID.ValueMember = dr.Item("Location ID").ToString
                    TxtQuantity.Focus()

                ElseIf Val(dr.Item("Total")) > 1 Then
                    CmbLocationID.Focus()
                End If

            End If



            dr.Close()
            con.Close()

        Catch ex As Exception

        End Try
    End Sub
    'Search By Location Name 
    Sub SearchByLocationName()
        ' Load Data
        Try



            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Location Information].[Location ID],[Location Information].[Location Name], [Branch Information].[Branch Name]  FROM [Location Information] join [Branch Information] on [Location Information].[Branch ID] = [Branch Information].[Branch ID]  WHERE ([Location Information].[Location Name] LIKE '%" + CmbLocationID.Text + "%' and [Branch Information].[Branch ID]='" + FrmHome.lblBranchID.Text + "')"


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Location Information")
            connection.Close()
            GrdLocationList.DataSource = ds
            GrdLocationList.DataMember = "BizPro_Location Information"


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            GrdLocationList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells


        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records")
        Finally

        End Try

        'End Refresh Data

    End Sub
    'Resize Product List Gridview and Make it Visible
    Sub ResizeProductListGridviewandMakeitVisible()

        GrdProductList.Visible = True
        GrdProductList.Width = 600
        GrdProductList.Height = 113

        'Column visiblity false
        GrdProductList.ColumnHeadersVisible = False
    End Sub


    Private Sub CmbProductName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbProductName.TextChanged
        If Not CmbProductName.Text = "" And LblPurchaseID.Text = "00" Then

            'Resize Product List Gridview and Make it Visible
            ResizeProductListGridviewandMakeitVisible()

            ' 'Search By Product Name 
            SearchByProductName()





        ElseIf CmbProductName.Text = "" Then

            GrdProductList.Visible = False

            'Clear Data Products For Drop down
            cleardataProductForDropdown()

        End If
    End Sub

    Private Sub GrdProductList_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdProductList.CellContentClick

    End Sub

    Private Sub GrdProductList_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdProductList.CellMouseClick

    End Sub

    Private Sub GrdProductList_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdProductList.CellMouseDoubleClick
        'Show Product Details To Text boxes
        ShowProductDetailsToTextboxes()
    End Sub

    Private Sub GrdProductList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdProductList.KeyDown
        If e.KeyCode = Keys.Enter Then


            'Show Product Details To Text boxes
            ShowProductDetailsToTextboxes()
        End If
    End Sub

    'Resize Location Gridview and Make it Visible
    Sub ResizeLocationGridviewandMakeitVisible()
        GrdLocationList.Visible = True
        GrdLocationList.Width = 400
        GrdLocationList.Height = 113
        'Column visiblity false
        GrdLocationList.ColumnHeadersVisible = False
    End Sub



    Private Sub CmbLocationID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbLocationID.TextChanged

        If Not CmbLocationID.Text = "" And LblPurchaseID.Text = "00" Then

            'Resize Location Gridview and Make it Visible
            ResizeLocationGridviewandMakeitVisible()

            'Search By Location Name 
            SearchByLocationName()





        ElseIf CmbLocationID.Text = "" Then

            CmbLocationID.ValueMember = ""

            GrdLocationList.Visible = False

        End If
    End Sub

    Private Sub GrdLocationList_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdLocationList.CellContentClick

    End Sub

    Private Sub GrdLocationList_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdLocationList.CellMouseClick

    End Sub

    Private Sub GrdLocationList_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdLocationList.CellMouseDoubleClick
        'Show Location details to Combobox
        ShowLocationDetailsToCombobox()
    End Sub

    Private Sub GrdLocationList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdLocationList.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Show Location details to Combobox
            ShowLocationDetailsToCombobox()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        FrmProductInformation.Show()
        FrmProductInformation.BtnAddNew.PerformClick()
    End Sub

   


   
    
End Class