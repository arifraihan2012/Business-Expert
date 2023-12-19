Imports System.Data
Imports System.Data.SqlClient
Imports System.IO


Public Class FrmChalan

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
        NetPayableAmount()
    End Sub

    Sub NewInvoice()
        'Chalan Invoice 
        Me.TxtChalanInvoiceNo.Text = FrmHome.LblUserID.Text & Format(Now, "ddMMyyhhmmssms") & FrmHome.LblComputerID.Text
    End Sub

    Private Sub FrmSale_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If (MessageBox.Show(" Do you really want to Close?", "Bizpro", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No) Then
            e.Cancel = True

        End If
    End Sub


    Private Sub FrmSale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


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


                dr.Close()
                con.Close()


            End If

        Catch ex As Exception
            MessageBox.Show("Error while  permission delete to form..." & ex.Message, "Form Load")

        End Try








        'New Invoice
        NewInvoice()



        'ClearData
        cleardataCustomer()

        'Change Language
        ChangeLanguage()


        'Date time auto today
        DtpChalanDate.Value = Now



    End Sub


    Sub TotalAmount()
        Dim total As String = 0
        For i As Integer = 0 To GrdSale.RowCount - 1
            total += GrdSale.Rows(i).Cells(6).Value
        Next
        Me.TxtTotal.Text = total
    End Sub

    Sub cleardataProduct()

        cmbProductName.Text = ""
        cmbProductName.ValueMember = ""

        TxtPurchaseID.Text = ""
        TxtQuantity.Text = ""
        TxtChalanUnitPrice.Text = ""
        TxtChalanAmount.Text = ""
        lblChalanID.Text = "00"
        lblQuantity.Text = "00"
    End Sub

    Sub ClearAllData()


        cmbProductName.Text = ""
        cmbProductName.ValueMember = ""

        TxtPurchaseID.Text = ""
        TxtQuantity.Text = ""
        TxtChalanUnitPrice.Text = ""
        TxtChalanAmount.Text = ""
        lblChalanID.Text = "00"
        lblQuantity.Text = "00"


        CmbCustomerName.ValueMember = ""
        CmbCustomerName.Text = ""


        TxtPhoneNo.Text = ""
        TxtAddress.Text = ""
        TxtCustomerDiscount.Text = ""

        TxtTotal.Text = ""

        TxtDiscountPercentage.Text = ""
        TxtDiscount.Text = ""
        TxtVatPercentage.Text = ""
        TxtVat.Text = ""
        TxtNetPayable.Text = ""
        TxtTotalAmount.Text = ""

        TxtChalanInvoiceNo.Text = ""

        DtpChalanDate.Value = Now

    End Sub
    Sub cleardataCustomer()
        'Clear Customer Name
        CmbCustomerName.ValueMember = ""
        CmbCustomerName.Text = ""

        TxtPhoneNo.Text = ""
        TxtAddress.Text = ""
        TxtCustomerDiscount.Text = ""
        TxtDiscountPercentage.Text = ""

    End Sub

    'Creating Privet Sub for Refresh
    Sub RefreshData()

        ' Load Data
        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Chalan].[Chalan ID],[Chalan].[Chalan Invoice No],[Chalan].[Purchase ID],[Products].[Product Name],[Chalan].[Chalan Quantity],[Chalan].[Chalan Unit Price],[Chalan].[Chalan Amount] from [Chalan] join [Products] on [Chalan].[product ID]=[products].[Product ID]  where [Chalan].[Chalan Invoice No]= '" + Me.TxtChalanInvoiceNo.Text + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Chalan")
            connection.Close()
            GrdSale.DataSource = ds
            GrdSale.DataMember = "BizPro_Chalan"

            'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)


            GrdSale.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            con.Close()



            'Total Count
            TotalAmount()


            TxtVat.Text = (Val(TxtTotal.Text) * Val(TxtVatPercentage.Text)) / 100
            DiscountAndPercentage()
            'Calculate Net Payable Amount
            NetPayableAmount()


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

            Me.CmbCustomerName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtPhoneNo.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtAddress.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtCustomerDiscount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtSearchBarcode.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtChalanInvoiceNo.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.cmbProductName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtPurchaseID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtQuantity.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtChalanUnitPrice.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtChalanAmount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))

            Me.TxtTotal.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, 13, FontStyle.Bold)
            Me.TxtVatPercentage.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtVat.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtDiscountPercentage.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtDiscount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtNetPayable.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, 13, FontStyle.Bold)
            Me.TxtTotalAmount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, 13, FontStyle.Bold)

            Me.lblQuantity.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.lblChalanID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.DtpChalanDate.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))

            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            Me.GrdSale.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.GrdSale.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)


            'MsgBox(dr.Item("Language Font"))

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


            FrmListOfProductStock.Show()
            FrmListOfProductStock.TxtsearchProduct.Focus()
            FrmListOfProductStock.Label1.Text = "Chalan"



        ElseIf e.KeyCode = Keys.F8 Then

            NetPayableAmount()
            TxtTotalAmount.Text = Val(Me.TxtNetPayable.Text)
            TxtTotalAmount.Focus()


        ElseIf e.KeyCode = Keys.F2 Then
            'Clear Data Product
            cleardataProduct()

            'Focus on cmb Product name
            cmbProductName.Focus()

        End If




    End Sub

    Private Sub cmbProduct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProductName.SelectedIndexChanged

    End Sub

    Private Sub TxtQuantity_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtQuantity.KeyDown

        Try



            If e.KeyCode = Keys.Enter Then


                If Val(TxtQuantity.Text) > Val(lblQuantity.Text) Or Val(lblQuantity.Text) = 0 Or TxtQuantity.Text = "" Or TxtQuantity.Text = "0" Then

                    MsgBox("Insufficient Stock", MsgBoxStyle.OkOnly, "Chalan")

                    'Focus on quantity
                    TxtQuantity.Focus()

                Else
                    Me.TxtChalanUnitPrice.Focus()
                End If
            End If


        Catch ex As Exception
            MessageBox.Show("Error while Calculation Amount" & ex.Message, "Quantity Text Box Keydown")
        End Try

    End Sub



    Private Sub TxtQuantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtQuantity.TextChanged
        TxtChalanAmount.Text = Val(TxtQuantity.Text) * Val(TxtChalanUnitPrice.Text)
    End Sub

    Private Sub TxtSalePrice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtChalanUnitPrice.KeyDown

        If e.KeyCode = Keys.Enter Then


            If CmbCustomerName.ValueMember = "" Or CmbCustomerName.Text = "" Then
                MsgBox("Please Select a Customer First", MsgBoxStyle.OkOnly, "Chalan")

                'Focus on Customer 'Combobox
                CmbCustomerName.Focus()

            Else
                'Insert or update data
                InsertOrUpdateChalan()

                'Insert into Chalan Invoice
                InsertIntoChalanInvoice()
            End If
        End If


    End Sub
    Private Sub TxtSalePrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtChalanUnitPrice.TextChanged
        TxtChalanAmount.Text = Val(TxtQuantity.Text) * Val(TxtChalanUnitPrice.Text)
    End Sub

    Private Sub BtnCustomerName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCustomerName.Click
        FrmCustomerInformation.Show()
        FrmCustomerInformation.CmbCustomerName.Focus()
        FrmCustomerInformation.LblFormName.Text = "Chalan"
        FrmCustomerInformation.TxtDiscountPercentage.Text = "0"

    End Sub
    Private Sub CmbCustomerName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbCustomerName.KeyDown


        If e.KeyCode = Keys.Enter Then
            FrmListofCustomers.Show()
            FrmListofCustomers.TxtSearchCustomerName.Focus()
            FrmListofCustomers.Label1.Text = "Chalan"
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
            cmd.CommandText = "SELECT [Customer Information].[Customer ID],[Customer Category].[Customer Category Name],[Customer Information].[Customer Name],[Customer Information].[Company Name],[Customer Information].[Designation],[Customer Information].[Mobile No],[Customer Information].[Email Address],[Customer Information].[Address],[Customer Information].[Web Address],[Customer Information].[City],[Customer Information].[Country],[Customer Information].[SMS Notification],[Customer Information].[Status],[Customer Information].[Discount Percentage] FROM [Customer Information] Join [Customer Category] on [Customer Information].[Customer Category ID]=[Customer Category].[Customer Category ID]  WHERE [Customer Information].[Customer ID] = '" + CmbCustomerName.ValueMember + "'"


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
            MessageBox.Show("Error while Searching Customer Information" & ex.Message, "Customer Information Sub")
        End Try
    End Sub

    Private Sub TxtPurchaseInvoice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPurchaseID.KeyDown
        'Focus on quantity  Text box
        If e.KeyCode = Keys.Enter Then
            Me.TxtQuantity.Focus()

        End If
    End Sub


    Private Sub TxtPurchaseInvoice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPurchaseID.TextChanged

    End Sub

    Private Sub TxtAmount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtChalanAmount.KeyDown
        If e.KeyCode = Keys.Enter Then


        End If


    End Sub

    Private Sub TxtAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtChalanAmount.TextChanged

    End Sub
    Sub InsertIntoChalanInvoice()

        'Insert Into Chalan Invoice code
        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim con2 As New SqlConnection
            Dim cmd2 As New SqlCommand
            Dim dr1 As SqlDataReader

            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now




            con2.ConnectionString = FrmHome.ConnectionString
            con2.Open()
            cmd2.Connection = con2
            cmd2.CommandText = "SELECT  *FROM [Chalan Invoice]  WHERE [Chalan Invoice No] = '" + Me.TxtChalanInvoiceNo.Text + "'"

            dr1 = cmd2.ExecuteReader()


            If Not dr1.HasRows Then

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "INSERT INTO [Chalan Invoice] ([Chalan Invoice No],[Total],[Vat percentage],[Vat],[Discount Percentage],[Discount],[Net Payable],[Total Amount],[Status],[Customer ID],[Chalan Date],[Chalan Time],[User Account ID],[Computer ID]) values ('" + TxtChalanInvoiceNo.Text + "','" + TxtTotal.Text + "','" + TxtVatPercentage.Text + "','" + TxtVat.Text + "','" + TxtDiscountPercentage.Text + "','" + TxtDiscount.Text + "','" + TxtNetPayable.Text + "','" + TxtTotalAmount.Text + "','INCOMPLETE','" + CmbCustomerName.ValueMember + "','" + DtpChalanDate.Value + "','" + currentTime + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "')"
                cmd.ExecuteNonQuery()
                con.Close()

            ElseIf dr1.HasRows Then

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "UPDATE  [Chalan Invoice] SET [Total]='" + TxtTotal.Text + "',[Chalan Time]= '" + currentTime + "', [Chalan Date]= '" + DtpChalanDate.Value + "', [User Account ID]= '" + FrmHome.LblUserID.Text + "',[Customer ID]='" + CmbCustomerName.ValueMember + "' where [Chalan Invoice No] = '" + TxtChalanInvoiceNo.Text + "' "
                cmd.ExecuteNonQuery()
                con.Close()

            End If

            con2.Close()
            dr1.Close()



        Catch ex As Exception
            MessageBox.Show("Error while Inserting to Chalan invoice record on table..." & ex.Message, "Insert Into Chalan Invoice Sub")
        Finally

        End Try



    End Sub
    Sub InsertOrUpdateChalan()
        If lblChalanID.Text = "00" Then

            'Data Insert Code
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now
            Try

                'Same id Twice insert restriction code
                If Not Me.lblChalanID.Text = "00" Then
                    MsgBox("Can not insert please click update.", MsgBoxStyle.OkOnly, "Chalan")


                Else
                    'Empty Txt Box Can Not Be Save Code
                    If CmbCustomerName.Text = "" Or CmbCustomerName.ValueMember = "" Or cmbProductName.ValueMember = "" Or cmbProductName.Text = "" Or TxtPurchaseID.Text = "" Or TxtQuantity.Text = "" Or TxtChalanUnitPrice.Text = "" Or TxtChalanAmount.Text = "" Then
                        MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Chalan")

                    Else

                        con.ConnectionString = FrmHome.ConnectionString
                        con.Open()
                        cmd.Connection = con
                        cmd1.Connection = con
                        cmd.CommandText = "INSERT INTO [Chalan] ([Chalan Invoice No],[Product ID],[Chalan Quantity],[Chalan Unit Price],[Chalan Amount],[Purchase ID],[Branch ID],[Computer ID],[User Account ID]) VALUES ('" + TxtChalanInvoiceNo.Text + "','" + cmbProductName.ValueMember + "','" + TxtQuantity.Text + "','" + TxtChalanUnitPrice.Text + "','" + TxtChalanAmount.Text + "','" + TxtPurchaseID.Text + "','" + FrmHome.lblBranchID.Text + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "')"
                        cmd1.CommandText = "INSERT INTO [Log Details] ([Log Category],[Log Description],[User Account ID],[Log Date],[Log Time],[Task ID]) VALUES ('Chalan','Data Inserted Successfully [" + cmbProductName.ValueMember + "]','" + FrmHome.LblUserID.Text + "','" + currentDate + "','" + currentTime + "','New Data Inserted')"
                        cmd.ExecuteNonQuery()
                        cmd1.ExecuteNonQuery()



                        'Making Clear
                        cleardataProduct()



                        'Refresh Data
                        RefreshData()

                        'Focus on Product text box
                        cmbProductName.Focus()


                        ' discount and vat percentage
                        DiscountAndPercentage()



                    End If
                End If

            Catch ex As Exception
                MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Or Update Chalan Sub")
            Finally
                con.Close()

            End Try

        Else

            'Data Update Code
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now

            Try

                'Empty Bank Transaction ID Can Not Be Update
                If lblChalanID.Text = "00" Then
                    MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Chalan")

                    'Empty Txt Box Can Not Be Save Code

                    'Empty Txt Box Can Not Be Save Code
                ElseIf CmbCustomerName.Text = "" Or CmbCustomerName.ValueMember = "" Or cmbProductName.ValueMember = "" Or cmbProductName.Text = "" Or TxtPurchaseID.Text = "" Or TxtQuantity.Text = "" Or TxtChalanUnitPrice.Text = "" Or TxtChalanAmount.Text = "" Then
                    MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Chalan")

                Else
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd1.Connection = con
                    cmd.CommandText = "UPDATE [Chalan] SET [Chalan Invoice No]= '" + TxtChalanInvoiceNo.Text + "',[Product ID]= '" + cmbProductName.ValueMember + "',[Chalan Quantity]= '" + TxtQuantity.Text + "',[Chalan Unit Price]= '" + TxtChalanUnitPrice.Text + "',[Chalan Amount]= '" + TxtChalanAmount.Text + "', [Purchase ID]= '" + TxtPurchaseID.Text + "',[Branch ID]= '" + FrmHome.lblBranchID.Text + "',[Computer ID]= '" + FrmHome.LblComputerID.Text + "',[User Account ID]= '" + FrmHome.LblUserID.Text + "' WHERE [Chalan ID]= '" + lblChalanID.Text + "'"
                    cmd1.CommandText = "INSERT INTO [Log Details] ([Log Category],[Log Description],[User Account ID],[Log Date],[Log Time],[Task ID]) VALUES ('Chalan','Data Updated Successfully','" + FrmHome.LblUserID.Text + "','" + currentDate + "','" + currentTime + "','" + lblChalanID.Text + "')"
                    cmd.ExecuteNonQuery()
                    cmd1.ExecuteNonQuery()




                    'Making Clear
                    cleardataProduct()



                    'Refresh Data
                    RefreshData()

                    'Focus on Product text box
                    cmbProductName.Focus()

                    ' discount and vat percentage
                    DiscountAndPercentage()


                End If
            Catch ex As Exception
                MessageBox.Show("Error while Updating record on table..." & ex.Message, "Insert Or Update Chalan Sub")
            Finally
                con.Close()
            End Try


        End If
    End Sub



    Private Sub GrdSale_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdSale.CellContentClick

    End Sub

    Private Sub GrdSale_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdSale.CellMouseClick
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdSale.Rows(e.RowIndex)

                cmbProductName.Text = row.Cells("Product Name").Value.ToString
                TxtQuantity.Text = row.Cells("Chalan Quantity").Value.ToString
                TxtPurchaseID.Text = row.Cells("Purchase ID").Value.ToString
                TxtChalanUnitPrice.Text = row.Cells("Chalan Unit Price").Value.ToString
                TxtChalanAmount.Text = row.Cells("Chalan Amount").Value.ToString
                lblChalanID.Text = row.Cells("Chalan ID").Value.ToString

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim cmd1 As New SqlCommand
                Dim dr As SqlDataReader
                Dim dr1 As SqlDataReader

                'Data reader for Product Id
                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "SELECT  *FROM [Chalan]  WHERE [Chalan ID] = '" + lblChalanID.Text + "'"
                dr = cmd.ExecuteReader()
                dr.Read()

                Me.cmbProductName.ValueMember = (dr.Item("Product ID").ToString)
                dr.Close()


                'Data reader for Available stock
                cmd1.Connection = con
                cmd1.CommandText = "select   [Purchase Date],[Purchase ID],[Supplier Name],[Product ID],[Product Name],[Branch Name],[Purchase Cost],[Sale Price] ,((isnull(sum([Purchase]),0)+isnull(sum([Sale Return]),0))-(isnull(sum([Deducted]),0)+isnull(sum([total Sale]),0)+isnull(sum([Purchase Return]),0)))[Stock Available] from (select [Purchase Date],[Purchase ID],[Supplier Name],[Branch Name],[Product ID],[Product Name],[Purchase Cost],[Purchase],[Sale Price],case when   [Deducted] is null then  00 else  [Deducted] end [Deducted], case when   [Sale] is null then  00 else  Sale end[Total Sale], case when   [Sale Return] is null then  00 else  [Sale Return] end[Sale Return] , case when   [Purchase Return] is null then  00 else  [Purchase Return] end[Purchase Return]  from (select [Purchase].[Purchase Date],Purchase.[Purchase ID],[Supplier Information].[Supplier Name],[Products].[Product ID],[Products].[Product Name],[Branch Information].[Branch Name],[Branch Information].[Branch ID],Purchase.[Purchase Unit Cost][Purchase Cost],[Products].[Sale Price],case when [Purchase Quantity] =0  then (select [Added Quantity] from [Product Transfer] where [Product Transfer].[Purchase ID]=Purchase.[Purchase ID] and [Product Transfer].Status='Added' and [Product Transfer].[Product ID]=Purchase.[Product ID])   ELSE isnull([Purchase].[Purchase Quantity],0) end[Purchase] ,(select isnull(sum([Sale Quantity]),0)  from sale where Sale.[Purchase ID]=Purchase.[Purchase ID] group by [Purchase ID])[Sale],(select isnull(sum([Returned Quantity]),0)  from [Sale Return] where [Sale Return].[Purchase ID]=Purchase.[Purchase ID] group by [Purchase ID])[Sale Return],(select isnull(sum([Returned Quantity]),0)  from [Purchase Return] where [Purchase Return].[Purchase ID]=Purchase.[Purchase ID] group by [Purchase ID])[Purchase Return], (select isnull(sum([Deducted Quantity]),0)  from [Product Transfer] where Purchase.[Purchase ID]=[Product Transfer].[Purchase ID] and [Product Transfer].Status='Deducted'  group by [Purchase ID] )[Deducted] from Purchase  join Products on Purchase.[Product ID]=products.[Product ID]  join [Branch Information] on [Purchase].[Branch ID]=[Branch Information].[Branch ID]	  Join [Purchase Invoice] on [Purchase Invoice].[Purchase Invoice No]=[Purchase].[Purchase Invoice No] join [Supplier Information] on [Purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID] Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID]  Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID]  Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID]   WHERE (Purchase.[Purchase ID] = '" + Me.TxtPurchaseID.Text + "' and products. [Product ID] = '" + Me.cmbProductName.ValueMember + "')  ) as a   ) as a   group by [Purchase ID],[Purchase],[Product ID],[Total Sale],[Deducted] ,[Purchase Return],[Product Name],[Branch Name],[Sale Return],[Purchase Date],[Supplier Name],[Purchase Cost],[Sale Price]   having ((isnull(sum([Purchase]),0)+isnull(sum([Sale Return]),0))-(isnull(sum([Deducted]),0)+isnull(sum([total Sale]),0)+isnull(sum([Purchase Return]),0)))>0 order by [Purchase Date] asc"
                dr1 = cmd1.ExecuteReader()
                dr1.Read()

                lblQuantity.Text = (dr1.Item("stock Available").ToString)
                dr1.Close()



                con.Close()

                'Focus on product name
                cmbProductName.Focus()

            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview")

        End Try


    End Sub

    Private Sub CmbCustomerName_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbCustomerName.SelectedValueChanged

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

    Private Sub GrdSale_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdSale.CellMouseDoubleClick

        'Empty Chalan ID Can Not Be Update
        If Me.lblChalanID.Text = "" Then
            MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Chalan")

        Else


            'Data Delete Code
            Dim q As MsgBoxResult
            q = MsgBox("Do you really want to Delete the row?", MsgBoxStyle.YesNo, "Chalan")
            If q = MsgBoxResult.Yes Then

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim cmd1 As New SqlCommand
                Dim currentDate As DateTime = DateTime.Today
                Dim currentTime As DateTime = DateTime.Now
                Try
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd1.Connection = con
                    cmd.CommandText = "Delete from [Chalan] where [Chalan ID]= '" + lblChalanID.Text + "'"
                    cmd1.CommandText = "INSERT INTO [Log Details] ([Log Category],[Log Description],[User Account ID],[Log Date],[Log Time],[Task ID]) VALUES ('Chalan','Data Deleted Successfully','" + FrmHome.LblUserID.Text + "','" + currentDate + "','" + currentTime + "','" + lblChalanID.Text + "')"
                    cmd.ExecuteNonQuery()
                    cmd1.ExecuteNonQuery()

                    'Refresh Data
                    RefreshData()


                    'Making Clear
                    cleardataProduct()

                    'focus on product textbox
                    cmbProductName.Focus()



                Catch ex As Exception
                    MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Cell Mouse Double Click")
                Finally
                    con.Close()
                End Try


            End If
        End If


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

    Private Sub GrdSale_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdSale.KeyDown

    End Sub


    Sub UpdateChalanInvoice()

        Try


            'Update Chalan Invoice
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "UPDATE  [Chalan Invoice] SET  [Total]= '" + TxtTotal.Text + "', [Vat percentage]= '" + TxtVatPercentage.Text + "', [Vat]= '" + TxtVat.Text + "', [Discount Percentage]= '" + TxtDiscountPercentage.Text + "', [Discount]= '" + TxtDiscount.Text + "', [Net Payable]= '" + TxtNetPayable.Text + "', [Total Amount]= '" + TxtTotalAmount.Text + "', [Status]= 'COMPLETE',[Chalan Date]='" + DtpChalanDate.Value + "',[Customer ID]='" + CmbCustomerName.ValueMember + "',[User Account ID]= '" + FrmHome.LblUserID.Text + "',[Computer ID]= '" + FrmHome.LblComputerID.Text + "' where [Chalan Invoice No] ='" + TxtChalanInvoiceNo.Text + "'"
            cmd.ExecuteNonQuery()

            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while Updating record on table..." & ex.Message, "Update Chalan Invoice Sub")

        End Try
    End Sub


    Sub DeleteCustomerLedger()


        Try


            Dim con As New SqlConnection
            Dim con1 As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now


            Dim cmd2 As New SqlCommand
            Dim dr As SqlDataReader



            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd2.Connection = con
            cmd2.CommandText = "SELECT  *FROM [Customer Ledger]  WHERE [Chalan Invoice No] = '" + TxtChalanInvoiceNo.Text + "'"
            dr = cmd2.ExecuteReader()
            dr.Read()


            If dr.HasRows Then



                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd.Connection = con1
                cmd1.Connection = con1
                cmd.CommandText = "Delete from [Customer Ledger] where [Chalan Invoice No]= '" + TxtChalanInvoiceNo.Text + "'"
                cmd1.CommandText = "INSERT INTO [Log Details] ([Log Category],[Log Description],[User Account ID],[Log Date],[Log Time],[Task ID]) VALUES ('Bank Transaction','Data Deleted Successfully','" + FrmHome.LblUserID.Text + "','" + currentDate + "','" + currentTime + "','" + CmbCustomerName.Text + "')"
                cmd.ExecuteNonQuery()
                cmd1.ExecuteNonQuery()
                con1.Close()

            End If


            dr.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Customer ladger Sub")
        Finally

        End Try


    End Sub


    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        Dim q As MsgBoxResult
        q = MsgBox("Do you really want to Save?", MsgBoxStyle.YesNo, "Chalan")



        If q = MsgBoxResult.Yes Then




            'Chalan Invoice update code
            UpdateChalanInvoice()




            'RptChalanInvoice.ShowInvoice()


            'Clear All
            ClearAllData()


            'New INvoice
            NewInvoice()

            'RefreshData
            RefreshData()


            'Focus on Customer cobobbox
            CmbCustomerName.Focus()

            'RptChalanInvoice.Show()


        ElseIf q = MsgBoxResult.No Then


            'Save Button Focus
            TxtTotalAmount.Focus()

        End If







    End Sub
    'Update or insert Customer ledger For dues
    Sub InsertorUpdateCustomerLedgerForDues()

        Try

            Dim con As New SqlConnection
            Dim con1 As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now
            Dim dr As SqlDataReader




            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Customer Ledger]  WHERE [Chalan Invoice No] = '" + TxtChalanInvoiceNo.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()




            If Not dr.HasRows Then

                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd1.CommandText = "INSERT INTO [Customer Ledger] ([Customer ID],[Transaction Date],[Chalan Invoice No],[User Account ID],[Computer ID],[Prepared Date] ,[Prepared Time],[Credited Amount],[Debited Amount]) VALUES ('" + CmbCustomerName.ValueMember + "','" + DtpChalanDate.Value + "','" + TxtChalanInvoiceNo.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + TxtTotalAmount.Text + "','" + TxtNetPayable.Text + "' )"
                cmd1.ExecuteNonQuery()
                con1.Close()




            ElseIf dr.HasRows Then



                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd1.CommandText = "UPDATE  [Customer Ledger] SET [Customer ID]= '" + CmbCustomerName.ValueMember + "',[Transaction Date]= '" + DtpChalanDate.Value + "',[Credited Amount]= '" + TxtTotalAmount.Text + "',[Debited Amount]= '" + TxtNetPayable.Text + "' WHERE [Chalan Invoice No]= '" + TxtChalanInvoiceNo.Text + "'"
                cmd1.ExecuteNonQuery()


            End If

            dr.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while inserting or Updating record on table..." & ex.Message, " Insert or Update Customer Ledger For Dues Sub")
        Finally

        End Try
    End Sub


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click


        Try




            If Not CmbCustomerName.ValueMember = "" Or Not CmbCustomerName.Text = "" Then

                Dim q As MsgBoxResult
                q = MsgBox("Do you really want to Cancel Invoice?", MsgBoxStyle.YesNo, "Chalan")
                If q = MsgBoxResult.Yes Then

                    Dim con2 As New SqlConnection
                    Dim cmd2 As New SqlCommand

                    Dim con As New SqlConnection
                    Dim cmd As New SqlCommand
                    Dim cmd1 As New SqlCommand
                    Dim currentDate As DateTime = DateTime.Today
                    Dim currentTime As DateTime = DateTime.Now

                    con2.ConnectionString = FrmHome.ConnectionString
                    con2.Open()
                    cmd2.Connection = con2
                    cmd2.CommandText = "Delete from [Chalan Invoice] where [Chalan Invoice No]= '" + TxtChalanInvoiceNo.Text + "'"
                    cmd2.ExecuteNonQuery()

                    con2.Close()



                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd1.Connection = con
                    cmd.CommandText = "Delete from [Chalan] where [Chalan Invoice No]= '" + TxtChalanInvoiceNo.Text + "'"
                    cmd1.CommandText = "INSERT INTO [Log Details] ([Log Category],[Log Description],[User Account ID],[Log Date],[Log Time],[Task ID]) VALUES ('Chalan','Data Deleted Successfully','" + FrmHome.LblUserID.Text + "','" + currentDate + "','" + currentTime + "','" + lblChalanID.Text + "')"
                    cmd.ExecuteNonQuery()
                    cmd1.ExecuteNonQuery()
                    con.Close()

                    'Delete From Customer Ledger
                    'DeleteCustomerLedger()




                    'Clear all data
                    ClearAllData()



                    'Focus on Custome  name
                    CmbCustomerName.Focus()


                    NewInvoice()

                    'Refresh Data
                    RefreshData()

                End If

            Else

                MsgBox("Please Insert Invoice Number First.", MsgBoxStyle.OkOnly, "Chalan")

            End If



        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try





    End Sub


    Private Sub TxtAdvance_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    'Calculate Net Payable Amount

    Sub NetPayableAmount()
        TxtNetPayable.Text = ((Val(TxtTotal.Text) + Val(TxtVat.Text)) - (Val(TxtDiscount.Text)))

    End Sub


    Private Sub TxtVat_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtVat.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtDiscountPercentage.Focus()
        End If
    End Sub

    Private Sub TxtVat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtVat.TextChanged
        'Calculate netpayable amount
        NetPayableAmount()
    End Sub

    Private Sub TxtDiscount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDiscount.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtNetPayable.Focus()
        End If
    End Sub

    Private Sub TxtDiscount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDiscount.TextChanged
        'Calculate Net Payable Amount
        NetPayableAmount()
    End Sub

    Private Sub TxtNetPayable_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNetPayable.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtTotalAmount.Focus()

        End If
    End Sub
    Private Sub TxtNetPayable_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNetPayable.TextChanged

    End Sub

    Private Sub TxtPaidAmount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTotalAmount.KeyDown
        'CalCulate Return amount and focus on return amount if cash of due
        If e.KeyCode = Keys.Enter Then
            BtnSave.PerformClick()
        End If

    End Sub

    Private Sub TxtPaidAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTotalAmount.TextChanged

    End Sub

    Private Sub TxtSaleInvoice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtChalanInvoiceNo.KeyDown


        If e.KeyCode = Keys.Enter Then

            ' Load Data
            Try
                'Refreshdata
                RefreshData()

                SearchChalanInvoice()


            Catch ex As Exception
                MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records on keydown")
            Finally

            End Try
        End If
    End Sub


    Sub SearchChalanInvoice()

        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader


            'Data reader for Product Id
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Chalan Invoice] join [Customer information] on[Chalan Invoice].[Customer ID]=[Customer information].[Customer ID]   WHERE [Chalan Invoice].[Chalan Invoice No] =  '" + TxtChalanInvoiceNo.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()
            If dr.HasRows Then

                Me.CmbCustomerName.Text = (dr.Item("Customer Name").ToString)
                Me.CmbCustomerName.ValueMember = (dr.Item("Customer ID").ToString)
                TxtDiscountPercentage.Text = (dr.Item("Discount Percentage").ToString)
                TxtDiscount.Text = (dr.Item("Discount").ToString)
                TxtTotalAmount.Text = (dr.Item("Total Amount").ToString)
                TxtNetPayable.Text = (dr.Item("Net Payable").ToString)
                TxtVatPercentage.Text = (dr.Item("Vat Percentage").ToString)
                TxtVat.Text = (dr.Item("Vat").ToString)


                dr.Close()
                con.Close()




                'Focus on Product name
                cmbProductName.Focus()

            End If
        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records on keydown")
        Finally

        End Try


    End Sub

    Private Sub TxtSaleInvoice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtChalanInvoiceNo.TextChanged

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
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnChalanHistory.Click
        FrmChalanHistory.Show()
        FrmChalanHistory.TxtSearchChalanInvoice.Focus()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim q As MsgBoxResult
        q = MsgBox("Do You Really Want to Create New Invoice?", MsgBoxStyle.YesNo, "Chalan Invoice")
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

    Private Sub LblSelectProduct_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblSelectProduct.Enter

    End Sub

    Private Sub cmbPaidBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInvoice.Click
        'RptSaleReturnInvoice.Show()
        'RptSaleReturnInvoice.ShowInvoice()
    End Sub

    Private Sub GrpCustomerInformation_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrpCustomerInformation.Enter

    End Sub

    Private Sub CmbCustomerName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCustomerName.SelectedIndexChanged

    End Sub

    Private Sub CmbCustomerName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbCustomerName.KeyPress

        e.Handled = True
    End Sub
End Class