Imports System.Data
Imports System.Data.SqlClient
Imports System.IO


Public Class FrmQuotation
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtVatPercentage_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtVatPercentage.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtVat.Focus()
        End If
    End Sub



    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtVatPercentage.TextChanged
        'Calculate Vat
        TxtVat.Text = (Val(TxtTotal.Text) * Val(TxtVatPercentage.Text)) / 100
        'Calculate Net Payable Amount
        TotalAmountPayable()
    End Sub

    Sub NewInvoice()
        'Quotation Invoice 
        Me.TxtQuotationInvoiceNo.Text = "" 'Format(Now, "ddMMyyhhmmssms") & FrmHome.LblUserID.Text & FrmHome.LblComputerID.Text
    End Sub

    Private Sub FrmSale_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If (MessageBox.Show(" Do you really want to Close?", "Bizpro", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No) Then
            e.Cancel = True

        End If
    End Sub


    Private Sub FrmSale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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


            ElseIf Not dr.HasRows Then
                BtnDelete.Enabled = False



            End If


            dr.Close()
            con.Close()


        Catch ex As Exception
            MessageBox.Show("Error while  permission delete to form..." & ex.Message, "Form Load")

        End Try


        'LoadComboBoxforcustomer
        LoadComboBoxforcustomer()



        'New INvoice
        NewInvoice()



        'clearData
        cleardataCustomer()

        'Change Language
        ChangeLanguage()


        'Date time auto today
        DtpQuotationDate.Value = Now

        cmbProductName.Text = "Press Enter"



    End Sub

    'Insert Into Customer

    Sub InsertIntoCustomer()

        Try

            If CmbCustomerName.SelectedValue = 0 Then

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


                cmd7.CommandText = "INSERT INTO [Chart Of Account] ([Head Of Account ID],[Account Name],[Prepared Time],[Prepared Date],[Computer ID],[User Account ID]) VALUES ('" + HeadOfAccountID + "','" + CmbCustomerName.Text + "','" + currentTime + "','" + currentDate + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "')"
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
                cmd2.CommandText = "SELECT top 1 [Customer Category ID] FROM [Customer Category]   order by [Customer Category ID] Asc"

                dr1 = cmd2.ExecuteReader()
                dr1.Read()



                con.ConnectionString = FrmHome.ConnectionString
                con.Open()

                If Not TxtCustomerDiscount.Text = "" Then
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO [Customer Information] ([Customer Name],[Customer Category ID],[Mobile No],[Address],[Discount Percentage],[Prepared Time],[Prepared Date],[Computer ID],[User Account ID],[Branch ID],[Status],[Sms Notification],[Chart Of Account ID]) VALUES ('" + CmbCustomerName.Text + "','" + (dr1.Item("Customer Category ID").ToString) + "','" + TxtPhoneNo.Text + "','" + TxtAddress.Text + "','" + TxtCustomerDiscount.Text + "','" + currentTime + "','" + currentDate + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.lblBranchID.Text + "','CONNECTED','ON','" + ChartOfAccountID + "')"
                    cmd.ExecuteNonQuery()
                ElseIf TxtCustomerDiscount.Text = "" Then
                    cmd4.Connection = con
                    cmd4.CommandText = "INSERT INTO [Customer Information] ([Customer Name],[Customer Category ID],[Mobile No],[Address],[Discount Percentage],[Prepared Time],[Prepared Date],[Computer ID],[User Account ID],[Branch ID],[Status],[SMS Notification],[Chart Of Account ID]) VALUES ('" + CmbCustomerName.Text + "','" + (dr1.Item("Customer Category ID").ToString) + "','" + TxtPhoneNo.Text + "','" + TxtAddress.Text + "','0','" + currentTime + "','" + currentDate + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.lblBranchID.Text + "','CONNECTED','ON','" + ChartOfAccountID + "')"
                    cmd4.ExecuteNonQuery()
                End If
                con2.Close()
                dr1.Close()
                con.Close()


                'Load Combobox For refresh
                LoadComboBoxforcustomer()

                'Clear Data  Customer for refresh
                cleardataCustomer()



                Dim con3 As New SqlConnection
                Dim cmd3 As New SqlCommand
                Dim dr3 As SqlDataReader

                con3.ConnectionString = FrmHome.ConnectionString
                con3.Open()
                cmd3.Connection = con3
                cmd3.CommandText = "SELECT top 1 [Customer ID] FROM [Customer Information] where [User Account ID]= '" + FrmHome.LblUserID.Text + "' and [Computer ID]='" + FrmHome.LblComputerID.Text + "'  order by [Customer ID] desc"

                dr3 = cmd3.ExecuteReader()
                dr3.Read()

                If dr3.HasRows Then


                    CmbCustomerName.SelectedValue = (dr3.Item("Customer ID").ToString)
                End If
                dr3.Close()
                con3.Close()




            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Load Combobox for customer
    Sub LoadComboBoxforcustomer()

        Try


            Dim con1 As New SqlConnection
            Dim cmd1 As New SqlCommand
            con1.ConnectionString = FrmHome.ConnectionString

            Dim strSQL1 As String = "SELECT [Customer ID],[Customer Name] FROM [Customer Information]"
            Dim da1 As New System.Data.SqlClient.SqlDataAdapter(strSQL1, con1)
            Dim ds1 As New DataSet
            da1.Fill(ds1, "[Customer Information]")

            With Me.CmbCustomerName
                .DataSource = ds1.Tables("[Customer Information]")
                .ValueMember = "Customer ID"
                .DisplayMember = "Customer Name"
            End With

            CmbCustomerName.SelectedValue = 0
            con1.Close()

        Catch ex As Exception
            MessageBox.Show("Error while loading Customer record on table..." & ex.Message, "Load ComboBox for customer Sub")

        End Try

    End Sub


    Sub TotalAmount()
        Dim total As String = 0
        For i As Integer = 0 To GrdQuotation.RowCount - 1
            total += GrdQuotation.Rows(i).Cells(4).Value
        Next
        Me.TxtTotal.Text = total
    End Sub
    Sub cleardataProduct()

        cmbProductName.Text = ""
        cmbProductName.ValueMember = ""

        TxtWarrantyDays.Text = ""
        TxtQuantity.Text = ""
        TxtQuotationUnitPrice.Text = ""
        TxtSaleAmount.Text = ""
        lblQuotationID.Text = "00"
        'lblQuantity.Text = "00"
    End Sub
    Sub ClearAllData()
        cmbProductName.Text = ""
        cmbProductName.ValueMember = ""

        TxtWarrantyDays.Text = ""
        TxtQuantity.Text = ""
        TxtQuotationUnitPrice.Text = ""
        TxtSaleAmount.Text = ""
        lblQuotationID.Text = "00"
        'lblQuantity.Text = "00"


        CmbCustomerName.SelectedValue = 0



        TxtPhoneNo.Text = ""
        TxtAddress.Text = ""
        TxtCustomerDiscount.Text = ""

        TxtTotal.Text = ""

        TxtDiscountPercentage.Text = ""
        TxtDiscount.Text = ""
        TxtVatPercentage.Text = ""
        TxtVat.Text = ""

        TxtTotalAmount.Text = ""

        TxtQuotationInvoiceNo.Text = ""

        DtpQuotationDate.Value = Now

    End Sub
    Sub cleardataCustomer()
        'Clear Customer Name
        CmbCustomerName.SelectedValue = 0

        TxtPhoneNo.Text = ""
        TxtAddress.Text = ""
        TxtCustomerDiscount.Text = ""
        TxtDiscountPercentage.Text = ""

    End Sub
    'Creating Privet Sub for Refresh
    Sub RefreshData()

        ' Load Data
        Try
             

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Quotation].[Quotation ID],[Products].[Product Name],[Quotation].[Quotation Quantity],[Quotation].[Quotation Unit Price],[Quotation].[Quotation Amount],[Quotation].[Warranty Days] from [Quotation] join [Products] on [Quotation].[product ID]=[products].[Product ID]  where [Quotation].[Quotation Invoice No]= '" + Me.TxtQuotationInvoiceNo.Text + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Quotation")
            connection.Close()
            GrdQuotation.DataSource = ds
            GrdQuotation.DataMember = "BizPro_Quotation"

            'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)


            GrdQuotation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill




            'Total Count
            TotalAmount()


            TxtVat.Text = (Val(TxtTotal.Text) * Val(TxtVatPercentage.Text)) / 100
            DiscountAndPercentage()
            'Calculate Net Payable Amount
            TotalAmountPayable()


        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try

        'End Refresh Data
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


                Me.CmbCustomerName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtPhoneNo.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtAddress.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtCustomerDiscount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtSearchBarcode.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtQuotationInvoiceNo.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.cmbProductName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtWarrantyDays.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtQuantity.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtQuotationUnitPrice.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtSaleAmount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))

                Me.TxtTotal.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, 13, FontStyle.Bold)
                Me.TxtVatPercentage.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtVat.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtDiscountPercentage.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtDiscount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtTotalAmount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, 13, FontStyle.Bold)

                'Me.lblQuantity.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.lblQuotationID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.DtpQuotationDate.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))

                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

                Me.GrdQuotation.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdQuotation.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)


                'MsgBox(dr.Item("Language Font"))
            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            con.Close()
        End Try

        'End Language

    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmbProduct_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbProductName.KeyDown
        If e.KeyCode = Keys.Enter Then


            FrmListofProducts.Show()
            FrmListofProducts.TxtSearchProductName.Focus()
            FrmListofProducts.Label1.Text = "Quotation"



        ElseIf e.KeyCode = Keys.Space AndAlso Keys.Control Then

            TotalAmountPayable()

            TxtTotalAmount.Focus()

        ElseIf e.KeyCode = Keys.F2 Then
            'Clear Data Product
            cleardataProduct()

            'Focus on cmb Product name
            cmbProductName.Focus()

        End If




    End Sub

    Private Sub cmbProductName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbProductName.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmbProduct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProductName.SelectedIndexChanged

    End Sub

    Private Sub TxtQuantity_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtQuantity.KeyDown
        If e.KeyCode = Keys.Enter Then


            If TxtQuantity.Text = "" Then 'Val(TxtQuantity.Text) > Val(lblQuantity.Text) Or Val(lblQuantity.Text) = 0 Or TxtQuantity.Text = "" Or TxtQuantity.Text = "0" Then

                MsgBox("Please Insert Quantity", MsgBoxStyle.OkOnly, "Quotation")

                'Focus on quantity
                TxtQuantity.Focus()

            Else
                Me.TxtWarrantyDays.Focus()
            End If
        End If
    End Sub



    Private Sub TxtQuantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtQuantity.TextChanged
        TxtSaleAmount.Text = Val(TxtQuantity.Text) * Val(TxtQuotationUnitPrice.Text)
    End Sub

    Private Sub TxtSalePrice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtQuotationUnitPrice.KeyDown

        If e.KeyCode = Keys.Enter Then


            If CmbCustomerName.Text = "" Then
                MsgBox("Please Select a Customer First", MsgBoxStyle.OkOnly, "Quotation")

                'Focus on Customer 'Combobox
                CmbCustomerName.Focus()

            Else


                'Insert New Customer Into Customer Information
                InsertIntoCustomer()



                'Insert into Quotation Invoice
                InsertIntoQuotationInvoice()

                'If sale invoice no is blank would not insert into sale
                If Not TxtQuotationInvoiceNo.Text = "" Then
                    'Insert or update data
                    InsertOrUpdateQuotation()


                    'Making Clear
                    cleardataProduct()



                    'Refresh Data
                    RefreshData()


                    'discount and vat percentage
                    DiscountAndPercentage()

                    'Focus on Product text box
                    cmbProductName.Focus()



                End If
            End If

        End If

    End Sub
    Private Sub TxtSalePrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtQuotationUnitPrice.TextChanged
        TxtSaleAmount.Text = Val(TxtQuantity.Text) * Val(TxtQuotationUnitPrice.Text)
    End Sub

    Private Sub BtnCustomerName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCustomerName.Click
        FrmCustomerInformation.Show()
        FrmCustomerInformation.CmbCustomerName.Focus()
        FrmCustomerInformation.LblFormName.Text = "Quotation"
    End Sub
    Private Sub CmbCustomerName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbCustomerName.KeyDown

        If e.KeyCode = Keys.Enter Then

            TxtPhoneNo.Focus()

            TxtPhoneNo.Focus()

        ElseIf e.KeyCode = Keys.F8 Then
            MsgBox(CmbCustomerName.SelectedValue)

        End If



    End Sub


    'Privet sub for customer information
    Sub customerInformation()
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT [Customer Information].[Customer ID],[Customer Category].[Customer Category Name],[Customer Information].[Customer Name],[Customer Information].[Company Name],[Customer Information].[Designation],[Customer Information].[Mobile No],[Customer Information].[Email Address],[Customer Information].[Address],[Customer Information].[Web Address],[Customer Information].[City],[Customer Information].[Country],[Customer Information].[SMS Notification],[Customer Information].[Status],[Customer Information].[Discount Percentage] FROM [Customer Information] Join [Customer Category] on [Customer Information].[Customer Category ID]=[Customer Category].[Customer Category ID]  WHERE [Customer Information].[Customer ID] = '" + CmbCustomerName.SelectedValue.ToString + "'"


            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then


                Me.TxtPhoneNo.Text = dr.Item("Mobile No").ToString
                Me.TxtAddress.Text = dr.Item("Address").ToString
                Me.TxtCustomerDiscount.Text = dr.Item("Discount Percentage").ToString
                Me.TxtDiscountPercentage.Text = dr.Item("Discount Percentage").ToString

            ElseIf Not dr.HasRows Then

                MsgBox("No Customer Found")

                cleardataProduct()

            End If

            dr.Close()
            con.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtPurchaseInvoice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'Focus on quantity  Text box
        If e.KeyCode = Keys.Enter Then
            Me.TxtQuantity.Focus()

        End If
    End Sub


    Private Sub TxtPurchaseInvoice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtAmount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSaleAmount.KeyDown
        If e.KeyCode = Keys.Enter Then


        End If


    End Sub

    Private Sub TxtAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSaleAmount.TextChanged

    End Sub
    Sub InsertIntoQuotationInvoice()

        'Insert Into Quotation Invoice code
        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim con2 As New SqlConnection
            Dim cmd2 As New SqlCommand
            Dim dr1 As SqlDataReader

            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now



            If TxtQuotationInvoiceNo.Text = "" Then

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "INSERT INTO [Quotation Invoice] ([Total],[Vat percentage],[Vat],[Discount Percentage],[Discount],[Total Amount],[Status],[Customer ID],[Quotation Date],[Quotation Time],[User Account ID],[Computer ID]) values ('" + TxtTotal.Text + "','" + TxtVatPercentage.Text + "','" + TxtVat.Text + "','" + TxtDiscountPercentage.Text + "','" + TxtDiscount.Text + "','" + TxtTotalAmount.Text + "','INCOMPLETE','" + CmbCustomerName.SelectedValue.ToString + "','" + DtpQuotationDate.Value + "','" + currentTime + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "')"
                cmd.ExecuteNonQuery()
                con.Close()


                con2.ConnectionString = FrmHome.ConnectionString
                con2.Open()
                cmd2.Connection = con2
                cmd2.CommandText = "SELECT top 1 [Quotation Invoice No] FROM [Quotation Invoice] where [User Account ID]= '" + FrmHome.LblUserID.Text + "'  order by [Quotation Invoice No] desc"

                dr1 = cmd2.ExecuteReader()
                dr1.Read()
                If dr1.HasRows Then


                    TxtQuotationInvoiceNo.Text = (dr1.Item("Quotation Invoice No").ToString)
                End If

                con2.Close()
                dr1.Close()



            Else





                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "UPDATE  [Quotation Invoice] SET [Total]='" + TxtTotal.Text + "',[Quotation Time]= '" + currentTime + "', [Quotation Date]= '" + DtpQuotationDate.Value + "', [User Account ID]= '" + FrmHome.LblUserID.Text + "',[Customer ID]='" + CmbCustomerName.SelectedValue.ToString + "',[Total Amount]='" + TxtTotalAmount.Text + "' where [Quotation Invoice No] = '" + TxtQuotationInvoiceNo.Text + "' "
                cmd.ExecuteNonQuery()
                con.Close()


            End If

        Catch ex As Exception
            MessageBox.Show("Error while Inserting to sale invoice record on table..." & ex.Message, "Insert Records Quotation Invoice")
        Finally

        End Try



    End Sub
    Sub InsertOrUpdateQuotation()
        If lblQuotationID.Text = "00" Then

            'Data Insert Code
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now
            Try

                'Same id Twice insert restriction code
                If Not Me.lblQuotationID.Text = "00" Then
                    MsgBox("Can not insert please click update.", MsgBoxStyle.OkOnly, "Quotation")


                Else
                    'Empty Txt Box Can Not Be Save Code
                    If CmbCustomerName.Text = "" Or CmbCustomerName.SelectedValue = 0 Or cmbProductName.ValueMember = "" Or cmbProductName.Text = "" Or TxtQuantity.Text = "" Or TxtQuotationUnitPrice.Text = "" Or TxtSaleAmount.Text = "" Then
                        MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Quotation")

                    Else

                        con.ConnectionString = FrmHome.ConnectionString
                        con.Open()
                        cmd.Connection = con
                        cmd.CommandText = "INSERT INTO [Quotation] ([Quotation Invoice No],[Product ID],[Quotation Quantity],[Quotation Unit Price],[Quotation Amount],[Branch ID],[Computer ID],[User Account ID],[Warranty Days]) VALUES ('" + TxtQuotationInvoiceNo.Text + "','" + cmbProductName.ValueMember + "','" + TxtQuantity.Text + "','" + TxtQuotationUnitPrice.Text + "','" + TxtSaleAmount.Text + "','" + FrmHome.lblBranchID.Text + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + TxtWarrantyDays.Text + "')"
                        cmd.ExecuteNonQuery()
                        con.Close()




                    End If
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
                If lblQuotationID.Text = "00" Then
                    MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Quotation")

                    'Empty Txt Box Can Not Be Save Code

                    'Empty Txt Box Can Not Be Save Code
                ElseIf CmbCustomerName.Text = "" Or CmbCustomerName.SelectedValue = 0 Or cmbProductName.ValueMember = "" Or cmbProductName.Text = "" Or TxtQuantity.Text = "" Or TxtQuotationUnitPrice.Text = "" Or TxtSaleAmount.Text = "" Then
                    MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Quotation")

                Else
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "UPDATE [Quotation] SET [Quotation Invoice No]= '" + TxtQuotationInvoiceNo.Text + "',[Product ID]= '" + cmbProductName.ValueMember + "',[Quotation Quantity]= '" + TxtQuantity.Text + "',[Quotation Unit Price]= '" + TxtQuotationUnitPrice.Text + "',[Quotation Amount]= '" + TxtSaleAmount.Text + "',[Branch ID]= '" + FrmHome.lblBranchID.Text + "',[Computer ID]= '" + FrmHome.LblComputerID.Text + "',[User Account ID]= '" + FrmHome.LblUserID.Text + "',[Warranty Days]='" + TxtWarrantyDays.Text + "' WHERE [Quotation ID]= '" + lblQuotationID.Text + "'"
                    cmd.ExecuteNonQuery()
                    con.Close()

                End If
            Catch ex As Exception
                MessageBox.Show("Error while Updating record on table..." & ex.Message, "Update Records")
            Finally

            End Try


        End If
    End Sub



    Private Sub GrdSale_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdSale_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)



    End Sub

    Private Sub CmbCustomerName_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbCustomerName.SelectedValueChanged
        customerInformation()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub TxtTotal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTotal.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtVatPercentage.Focus()
        End If
    End Sub




    Private Sub TxtTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTotal.TextChanged

    End Sub

    Private Sub BtnAddProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GrdSale_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)


    End Sub
    Sub DiscountAndPercentage()
        'Sub For discount and vat percentage
        TxtDiscount.Text = (Val(TxtTotal.Text) * Val(TxtDiscountPercentage.Text)) / 100

    End Sub

    Private Sub TxtDiscountPercentage_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDiscountPercentage.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtDiscount.Focus()
        End If
    End Sub

    Private Sub TxtDiscountPercentage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDiscountPercentage.TextChanged
        'Discount Percentage
        DiscountAndPercentage()
    End Sub

    Private Sub BtnDeleteProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GrdSale_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Sub UpdateQuotationInvoice()
        Try

            'Update Quotation Invoice
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "UPDATE  [Quotation Invoice] SET   [Vat percentage]= '" + TxtVatPercentage.Text + "', [Vat]= '" + TxtVat.Text + "', [Discount Percentage]= '" + TxtDiscountPercentage.Text + "', [Discount]= '" + TxtDiscount.Text + "', [Total Amount]= '" + TxtTotalAmount.Text + "', [Status]= 'COMPLETE',[Quotation Date]='" + DtpQuotationDate.Value + "',[Customer ID]='" + CmbCustomerName.SelectedValue.ToString + "',[User Account ID]= '" + FrmHome.LblUserID.Text + "',[Computer ID]= '" + FrmHome.LblComputerID.Text + "',[Total]='" + TxtTotal.Text + "' where [Quotation Invoice No] = '" + TxtQuotationInvoiceNo.Text + "'"
            cmd.ExecuteNonQuery()

            con.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
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

        Dim QuotationDetails As String

        Try
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Select SUBSTRING( ( SELECT   '-------'+  [Product Name],'  Quotation Quantity : ',isnull(sum(Quotation.[Quotation Quantity]),0),'  Quotation Unit Price : ', isnull((Quotation.[Quotation Unit Price]),0),'  Total Quotation Amount : ', isnull (sum(Quotation.[Quotation Amount]),0)        FROM [Quotation] join products on Quotation.[Product ID]=products.[Product ID]  where [Quotation Invoice No]='" + TxtQuotationInvoiceNo.Text + "'   group by Quotation.[Quotation Unit Price],products.[Product Name] FOR XML PATH('') ), 2 , 9999) As [Quotation Details]"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                QuotationDetails = dr.Item("Quotation Details").ToString

            End If
            dr.Close()
            con.Close()


            con1.ConnectionString = FrmHome.ConnectionString
            con1.Open()
            cmd1.Connection = con1
            cmd1.CommandText = "INSERT INTO [Log Details]  ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES('" + Me.Text + "','INSERT','Customer Name : " + CmbCustomerName.Text + " , Customer ID : " + CmbCustomerName.ValueMember + " , Quotation Details :( " + QuotationDetails + "),  Quotation Invoice Details :(Quotation Date : " + DtpQuotationDate.Value + ", Total : " + TxtTotal.Text + ", Vat Percentage : " + TxtVatPercentage.Text + ", Vat Amount : " + TxtVat.Text + ", Discount Percentage : " + TxtDiscountPercentage.Text + ", Discount Amount : " + TxtDiscount.Text + ", Total Amount : " + TxtTotalAmount.Text + ")' ,'" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtQuotationInvoiceNo.Text + "' )"
            cmd1.ExecuteNonQuery()
            con1.Close()



        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
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

        Dim QuotationDetails As String
        Dim BillStatus As String
        Try
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd2.Connection = con
            cmd.CommandText = "Select SUBSTRING( ( SELECT   '-------'+  [Product Name],'  Quotation Quantity : ',isnull(sum(Quotation.[Quotation Quantity]),0),'  Quotation Unit Price : ', isnull((Quotation.[Quotation Unit Price]),0),'  Total Quotation Amount : ', isnull (sum(Quotation.[Quotation Amount]),0)        FROM [Quotation] join products on Quotation.[Product ID]=products.[Product ID]  where [Quotation Invoice No]='" + TxtQuotationInvoiceNo.Text + "'   group by Quotation.[Quotation Unit Price],products.[Product Name] FOR XML PATH('') ), 2 , 9999) As [Quotation Details]"
            cmd2.CommandText = "Select [Status] From [Quotation Invoice] Where [Quotation Invoice No]='" + TxtQuotationInvoiceNo.Text + "'"

            'Data Reader For Find Sale Details
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                QuotationDetails = dr.Item("Quotation Details").ToString

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
            cmd1.CommandText = "INSERT INTO [Log Details]  ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES('" + Me.Text + "','DELETE','Customer Name : " + CmbCustomerName.Text + " , Customer ID : " + CmbCustomerName.ValueMember + " , Quotation Details :( " + QuotationDetails + "),  Quotation Invoice Details :(Quotation Date : " + DtpQuotationDate.Value + ", Total : " + TxtTotal.Text + ", Vat Percentage : " + TxtVatPercentage.Text + ", Vat Amount : " + TxtVat.Text + ", Discount Percentage : " + TxtDiscountPercentage.Text + ", Discount Amount : " + TxtDiscount.Text + ", Total Amount : " + TxtTotalAmount.Text + ") Bill Status : " + BillStatus + "' ,'" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtQuotationInvoiceNo.Text + "' )"
            cmd1.ExecuteNonQuery()
            con1.Close()



        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally


        End Try
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If TxtTotalAmount.Text = "" Then
            MsgBox("Please Insert Amount", MsgBoxStyle.OkOnly, "Quotation")

        Else

            Dim q As MsgBoxResult

            q = MsgBox("Do You Really Want To Save?", MsgBoxStyle.YesNo, "Quotation")
            If q = MsgBoxResult.Yes Then


                'Insert into log code For Save
                InsertIntoLogForSave()

                'Send invoice no as variable to quotation invoice report
                RptQuotationInvoice.QuotationInvoiceNo = TxtQuotationInvoiceNo.Text



                'Quotation Invoice update code
                UpdateQuotationInvoice()

                'Focus on Customer cobobbox
                CmbCustomerName.Focus()


                'Open Invoice
                RptQuotationInvoice.ShowQuotationInvoiceWithoutImage()
                RptQuotationInvoice.Show()





                'Clear All
                ClearAllData()


                'New INvoice
                NewInvoice()

                'RefreshData
                RefreshData()




            ElseIf q = MsgBoxResult.No Then


                'Save Button Focus
                TxtTotalAmount.Focus()

            End If






        End If

    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click


        Try




            If Not CmbCustomerName.SelectedValue = 0 Or Not CmbCustomerName.Text = "" Then

                Dim q As MsgBoxResult
                q = MsgBox("Do you really want to Cancel Invoice?", MsgBoxStyle.YesNo, "Quotation")
                If q = MsgBoxResult.Yes Then


                    'Insert into log code For Delete
                    InsertIntoLogForDelete()


                    Dim con2 As New SqlConnection
                    Dim cmd2 As New SqlCommand

                    Dim con As New SqlConnection
                    Dim cmd As New SqlCommand
                    Dim currentDate As DateTime = DateTime.Today
                    Dim currentTime As DateTime = DateTime.Now

                    con2.ConnectionString = FrmHome.ConnectionString
                    con2.Open()
                    cmd2.Connection = con2
                    cmd2.CommandText = "Delete from [Quotation Invoice] where [Quotation Invoice No]= '" + TxtQuotationInvoiceNo.Text + "'"
                    cmd2.ExecuteNonQuery()

                    con2.Close()



                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "Delete from [Quotation] where [Quotation Invoice No]= '" + TxtQuotationInvoiceNo.Text + "'"
                    cmd.ExecuteNonQuery()
                    con.Close()


                    'Clear all data
                    ClearAllData()



                    'Focus on Custome  name
                    CmbCustomerName.Focus()


                    NewInvoice()

                    'Refresh Data
                    RefreshData()

                End If

            Else

                MsgBox("Please Insert Invoice Number First.", MsgBoxStyle.OkOnly, "Quotation")

            End If



        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try





    End Sub


    Private Sub TxtAdvance_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    'Calculate Net Payable Amount

    Sub TotalAmountPayable()
        TxtTotalAmount.Text = ((Val(TxtTotal.Text) + Val(TxtVat.Text)) - (Val(TxtDiscount.Text)))

    End Sub


    Private Sub TxtVat_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtVat.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtDiscountPercentage.Focus()
        End If
    End Sub

    Private Sub TxtVat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtVat.TextChanged
        'Calculate netpayable amount
        TotalAmountPayable()
    End Sub

    Private Sub TxtDiscount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDiscount.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtTotalAmount.Focus()
        End If
    End Sub

    Private Sub TxtDiscount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDiscount.TextChanged
        'Calculate Net Payable Amount
        TotalAmountPayable()
    End Sub

    Private Sub TxtNetPayable_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            TxtTotalAmount.Focus()

        End If
    End Sub
    Private Sub TxtNetPayable_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtPaidAmount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTotalAmount.KeyDown
        'CalCulate Return amount and focus on return amount if cash of due
        If e.KeyCode = Keys.Enter Then

            BtnSave.PerformClick()

        End If

    End Sub

    Private Sub TxtPaidAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTotalAmount.TextChanged

    End Sub

    Private Sub TxtSaleInvoice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtQuotationInvoiceNo.KeyDown


        If e.KeyCode = Keys.Enter Then

            ' Load Data
            Try
                'Refreshdata
                RefreshData()

                SearchQuotationInvoice()


            Catch ex As Exception
                MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records on keydown")
            Finally

            End Try
        End If
    End Sub


    Sub SearchQuotationInvoice()

        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader


            'Data reader for Product Id
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Quotation Invoice] join [Customer information] on[Quotation Invoice].[Customer ID]=[Customer information].[Customer ID]   WHERE [Quotation Invoice].[Quotation Invoice No] =  '" + TxtQuotationInvoiceNo.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()
            If dr.HasRows Then

                Me.CmbCustomerName.Text = (dr.Item("Customer Name").ToString)
                Me.CmbCustomerName.SelectedValue = (dr.Item("Customer ID").ToString)
                TxtDiscountPercentage.Text = (dr.Item("Discount Percentage").ToString)
                TxtDiscount.Text = (dr.Item("Discount").ToString)
                TxtTotalAmount.Text = (dr.Item("Total Amount").ToString)
                TxtVatPercentage.Text = (dr.Item("Vat Percentage").ToString)
                TxtVat.Text = (dr.Item("Vat").ToString)
            End If

            dr.Close()
            con.Close()




            'Focus on Product name
            cmbProductName.Focus()


        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records on keydown")
        Finally

        End Try


    End Sub

    Private Sub TxtSaleInvoice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtQuotationInvoiceNo.TextChanged

    End Sub


    Private Sub CmbPaymentStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Focus on Paid Text box
        TxtTotalAmount.Focus()
    End Sub

    Private Sub BtnDeleteProduct_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub BtnAddProduct_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub CmbPaymentStatus_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Me.TxtTotalAmount.Focus()
        End If
    End Sub

    Private Sub CmbPaymentStatus_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Focus on Paid Text box
        TxtTotalAmount.Focus()

    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        FrmQuotationHistory.Show()
        FrmQuotationHistory.TxtSearchQuotationInvoice.Focus()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim q As MsgBoxResult
        q = MsgBox("Do You Really Want to Create New Invoice?", MsgBoxStyle.YesNo, "Quotation Invoice")
        If q = MsgBoxResult.Yes Then


            'Clear All Data
            ClearAllData()

            'New Invoice
            NewInvoice()

            'Refresh Data
            RefreshData()

            'Focus on Custome  name
            CmbCustomerName.Focus()

        End If
    End Sub

    Private Sub cmbPaidBy_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Me.BtnSave.PerformClick()

        End If
    End Sub

    Private Sub TxtSearchBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearchBarcode.TextChanged

    End Sub

    Private Sub CmbCustomerName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCustomerName.SelectedIndexChanged

    End Sub

    Private Sub cmbPaidBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DtpQuotationDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DtpQuotationDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbProductName.Focus()
        End If
    End Sub

    Private Sub DtpQuotationDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtpQuotationDate.ValueChanged

    End Sub

    Private Sub CmbCustomerName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbCustomerName.KeyPress

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
            TxtCustomerDiscount.Focus()
        End If
    End Sub

    Private Sub TxtAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtAddress.TextChanged

    End Sub

    Private Sub TxtCustomerDiscount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCustomerDiscount.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbProductName.Focus()
        End If
    End Sub

    Private Sub TxtCustomerDiscount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCustomerDiscount.TextChanged

    End Sub

    Private Sub TxtWarranty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtWarrantyDays.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtQuotationUnitPrice.Focus()
        End If
    End Sub


    Private Sub TxtWarranty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtWarrantyDays.TextChanged

    End Sub

    Private Sub BtnLastInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLastInvoice.Click

        'Send invoice no as variable to quotation invoice report
        RptQuotationInvoice.QuotationInvoiceNo = TxtQuotationInvoiceNo.Text


        'Open Invoice
        RptQuotationInvoice.ShowQuotationInvoiceWithoutImage()
        RptQuotationInvoice.Show()

    End Sub

    Private Sub Btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnclose.Click
        Me.Close()
    End Sub

    Private Sub Btnmaximized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnmaximized.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal

        Else
            Me.WindowState = FormWindowState.Maximized

        End If
    End Sub

    Private Sub Btnminimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnminimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub GrdQuotation_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdQuotation.CellContentClick

    End Sub

    Private Sub GrdQuotation_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdQuotation.CellMouseClick
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdQuotation.Rows(e.RowIndex)

                cmbProductName.Text = row.Cells("Product Name").Value.ToString
                TxtQuantity.Text = row.Cells("Quotation Quantity").Value.ToString
                'TxtPurchaseID.Text = row.Cells("Purchase ID").Value.ToString
                TxtQuotationUnitPrice.Text = row.Cells("Quotation Unit Price").Value.ToString
                TxtSaleAmount.Text = row.Cells("Quotation Amount").Value.ToString
                lblQuotationID.Text = row.Cells("Quotation ID").Value.ToString

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim cmd1 As New SqlCommand
                Dim dr As SqlDataReader
                ' Dim dr1 As SqlDataReader

                'Data reader for Product Id
                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "SELECT  *FROM [Quotation]  WHERE [Quotation ID] = '" + lblQuotationID.Text + "'"
                dr = cmd.ExecuteReader()
                dr.Read()
                If dr.HasRows Then
                    Me.cmbProductName.ValueMember = (dr.Item("Product ID").ToString)
                End If

                dr.Close()
                con.Close()

                'Data reader for Available stock
                'cmd1.Connection = con
                'cmd1.CommandText = "select [Purchase Invoice].[Purchase Date],Purchase.[Purchase ID] , products. [Product ID],products. [Product Name],[Branch Information].[Branch Name]+' - '+[Location Information].[Location Name] as Location,[Purchase].[Purchase Unit Cost][Purchase Cost],Avg([Products].[Sale Price])[Sale Price],isnull([Purchase].[Purchase Quantity],0)- isnull(Sum([sale].[Sale Quantity]),0)[Stock Available] from [purchase] join [Products] on [purchase].[Product ID] = [Products].[Product ID] join [Purchase Invoice] on [purchase].[Purchase Invoice No]=[Purchase Invoice].[Purchase Invoice No] join [Supplier Information] on [Purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID]  left join [Sale] on purchase.[Purchase Id] = [Sale].[Purchase ID] and [Purchase].[Product ID] =sale.[Product ID] join [Location Information] on [Purchase].[Purchase Location ID]=[Location Information].[Location ID] join [Branch Information] on [Purchase].[Purchase Location ID] = [Location Information].[Location ID]Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID] Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID] Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID]  WHERE (Purchase.[Purchase ID] = '" + Me.TxtPurchaseID.Text + "' and products. [Product ID] = '" + Me.cmbProductName.ValueMember + "') group by [Purchase Invoice].[Purchase Date], [Purchase].[Product ID],[Products].[Product Name], [Purchase].[Purchase Unit Cost],[Purchase].[Purchase Quantity],[products]. [Product ID],[Purchase].[Purchase ID],[Location Information].[Location Name],[Branch Information].[Branch Name]  order by [Purchase Invoice].[Purchase Date] asc"
                'dr1 = cmd1.ExecuteReader()
                'dr1.Read()

                'lblQuantity.Text = (dr1.Item("stock Available").ToString)
                'dr1.Close()





                'Focus on product name
                cmbProductName.Focus()

            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview")

        End Try
    End Sub

    Private Sub GrdQuotation_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdQuotation.CellMouseDoubleClick

        'Empty Bank Transaction ID Can Not Be Update
        If Me.lblQuotationID.Text = "" Then
            MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Quotation")

        Else


            'Data Delete Code
            Dim q As MsgBoxResult
            q = MsgBox("Do you really want to Delete the row?", MsgBoxStyle.YesNo, "Quotation")
            If q = MsgBoxResult.Yes Then

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim currentDate As DateTime = DateTime.Today
                Dim currentTime As DateTime = DateTime.Now
                Try
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "Delete from [Quotation] where [Quotation ID]= '" + lblQuotationID.Text + "'"
                    cmd.ExecuteNonQuery()
                    con.Close()

                    'Refresh Data
                    RefreshData()


                    'Making Clear
                    cleardataProduct()

                    'focus on product textbox
                    cmbProductName.Focus()



                Catch ex As Exception
                    MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Records")
                Finally

                End Try


            End If
        End If

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
End Class