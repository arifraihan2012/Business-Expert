Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class FrmSearch

    Private Sub TxtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
       
    End Sub

    Private Sub TxtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
     
    End Sub


    Private Sub FrmSearchStudenDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Change Language
        ChangeLanguage()

        DtpPurchaseFromDate.Value = Now
        DtpPurchaseTodate.Value = Now


        DtpSaleFromDate.Value = Now
        DtpSaleToDate.Value = Now

        DtpVoucherFromDate.Value = Now
        DtpVoucherToDate.Value = Now

        DtpBankFromDate.Value = Now
        DtpBankToDate.Value = Now



        'load Combo Box For Voucher
        LoadComboBoxForVoucher()

        LoadComboBoxForSaleCustomerCategory()


        'Load Combo Box For Bank Transaction()
        LoadComboBoxForBankTransaction()


        'Clear Data  For Voucher
        ClearDataForVoucherDetails()

        'Clear Data For Sale Details
        ClearDataForSaleDetails()

        'Sub Celar Data for Bank Transaction
        ClearDataBankTransaction()


    End Sub
    'Clear Data  For Products
    Sub ClearDataForProductDetails()

        lblTotalStock.Text = "00"
        LblTotalPurchasePrice.Text = "00"
        LblTotalSalePrice.Text = "00"
        LblApproximateProfit.Text = "00"

        CmbSearchProductGroup.ValueMember = ""
        CmbSearchProductGroup.Text = ""

        CmbSearchProductCategory.ValueMember = ""
        CmbSearchProductCategory.Text = ""

        CmbSearchProductSubcategory.ValueMember = ""
        CmbSearchProductSubcategory.Text = ""

    End Sub
    'Clear Data  For Purchase
    Sub ClearDataForPurchaseDetails()

        LblTotalPurchaseInvoice.Text = "00"
        LblTotalPurchaseAmount.Text = "00"

        TxtSearchPurchaseInvoice.Text = ""


    End Sub
    'Clear Data  For Sale
    Sub ClearDataForSaleDetails()

        LblTotalSaleInvoice.Text = "00"
        LblTotalReceivedAmount.Text = "00"

        TxtSearchSaleInvoice.Text = ""
        cmbCustomerCategory.SelectedValue = 0

    End Sub

    'Clear Data  For Voucher
    Sub ClearDataForVoucherDetails()

        LblTotalVoucher.Text = "00"
        LblPaidAmount.Text = "00"
        LblReceivedAmount.Text = "00"

        CmbSearchVoucherCategory.SelectedIndex = 0
        CmbSearchVoucherSubcategory.SelectedValue = 0

        CmbSearchVoucherPurpose.SelectedValue = 0


    End Sub
    'Sub Celar Data for Bank Transaction
    Sub ClearDataBankTransaction()


        CmbSeachBankNameBank.SelectedValue = 0
        LblTotalPayment.Text = "00"
        LblTotalWithdraw.Text = "00"
        TxtSearchCheckNoBank.Text = ""

    End Sub

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
            'Product Sector
            Me.TxtSearchProductName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.CmbSearchProductSubcategory.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.CmbSearchProductCategory.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.CmbSearchProductGroup.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.lblTotalStock.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.LblTotalPurchasePrice.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.LblTotalSalePrice.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.LblApproximateProfit.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))

            'Purchase Sector

            Me.TxtSearchPurchaseInvoice.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.DtpPurchaseFromDate.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.DtpPurchaseTodate.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.LblTotalPurchaseAmount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.LblTotalPurchaseInvoice.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))


            'Sale Sector

            Me.TxtSearchSaleInvoice.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.cmbCustomerCategory.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.DtpSaleFromDate.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.DtpSaleToDate.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.LblTotalReceivedAmount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.LblTotalSaleInvoice.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))

            'Voucher Sector

            Me.TxtSearchVoucherNo.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.DtpVoucherFromDate.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.DtpVoucherToDate.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.CmbSearchVoucherCategory.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.CmbSearchVoucherSubcategory.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.CmbSearchVoucherPurpose.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.LblTotalVoucher.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.LblPaidAmount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.LblReceivedAmount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))

            'Bank Sector
            Me.CmbSeachBankNameBank.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtSearchCheckNoBank.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.DtpBankFromDate.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.DtpBankToDate.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.LblTotalPayment.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.LblTotalWithdraw.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)



            Me.GrdSearch.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.GrdSearch.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)



            'MsgBox(dr.Item("Language Font"))

            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while changing language record on table..." & ex.Message, "Change Language")
        Finally
            con.Close()
        End Try

        'End Language

    End Sub

    'load Combo Box For Voucher
    Sub LoadComboBoxForVoucher()


        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        con1.ConnectionString = FrmHome.ConnectionString

        Dim strSQL1 As String = "SELECT [Voucher Purpose ID],[Voucher Purpose Name] FROM [Voucher Purpose]"
        Dim da1 As New System.Data.SqlClient.SqlDataAdapter(strSQL1, con1)
        Dim ds1 As New DataSet
        da1.Fill(ds1, "[Voucher Purpose]")

        With Me.CmbSearchVoucherPurpose
            .DataSource = ds1.Tables("[Voucher Purpose]")
            .DisplayMember = "Voucher Purpose Name"
            .ValueMember = "Voucher Purpose ID"
        End With


        Dim con2 As New SqlConnection
        Dim cmd2 As New SqlCommand
        con2.ConnectionString = FrmHome.ConnectionString

        Dim strSQL2 As String = "SELECT [Voucher Subcategory ID],[Voucher Subcategory Name] FROM [Voucher Subcategory]"
        Dim da2 As New System.Data.SqlClient.SqlDataAdapter(strSQL2, con2)
        Dim ds2 As New DataSet
        da2.Fill(ds2, "[Voucher Subcategory]")

        With Me.CmbSearchVoucherSubcategory
            .DataSource = ds2.Tables("[Voucher Subcategory]")
            .DisplayMember = "Voucher Subcategory Name"
            .ValueMember = "Voucher Subcategory ID"

        End With

    End Sub

    'load Combo Box For Sale Customer Category
    Sub LoadComboBoxForSaleCustomerCategory()


        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        con1.ConnectionString = FrmHome.ConnectionString

        Dim strSQL1 As String = "SELECT [Customer Category ID],[Customer Category Name] FROM [Customer Category]"
        Dim da1 As New System.Data.SqlClient.SqlDataAdapter(strSQL1, con1)
        Dim ds1 As New DataSet
        da1.Fill(ds1, "[Customer Category]")

        With Me.cmbCustomerCategory
            .DataSource = ds1.Tables("[Customer Category]")
            .ValueMember = "Customer Category ID"
            .DisplayMember = "Customer Category Name"
        End With


    End Sub
    'Load Bank Name for search
    Sub LoadComboBoxForBankTransaction()


        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = FrmHome.ConnectionString

        Dim strSQL As String = "SELECT [Bank ID],[Bank Name] FROM [Bank Information]"
        Dim da As New System.Data.SqlClient.SqlDataAdapter(strSQL, con)
        Dim ds As New DataSet
        da.Fill(ds, "[Bank Information]")

        With Me.CmbSeachBankNameBank
            .DataSource = ds.Tables("[Bank Information]")
            .ValueMember = "Bank ID"
            .DisplayMember = "Bank Name"




        End With

    End Sub

    Private Sub CmbSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSelectSearchBy.SelectedIndexChanged
        If CmbSelectSearchBy.Text = "PRODUCT" Then

            GrpProductDetails.Visible = True
            GrpProducts.Visible = True


            GrpPurchase.Visible = False
            GrpPurchaseDetails.Visible = False

            GrpSale.Visible = False
            GrpSaleDetails.Visible = False

            GrpVoucher.Visible = False
            GrpVoucherDetails.Visible = False

            GrpBankTransaction.Visible = False
            GrpBankTransactionTotal.Visible = False

            'Gridview prvious load Clear code
            GrdSearch.Columns.Clear()

        ElseIf CmbSelectSearchBy.Text = "PURCHASE" Then

            GrpProductDetails.Visible = False
            GrpProducts.Visible = False

            GrpPurchase.Visible = True
            GrpPurchaseDetails.Visible = True

            GrpSale.Visible = False
            GrpSaleDetails.Visible = False

            GrpVoucher.Visible = False
            GrpVoucherDetails.Visible = False

            GrpBankTransaction.Visible = False
            GrpBankTransactionTotal.Visible = False

            'Gridview prvious load Clear code
            GrdSearch.Columns.Clear()
        ElseIf CmbSelectSearchBy.Text = "SALE" Then

            GrpProductDetails.Visible = False
            GrpProducts.Visible = False

            GrpPurchase.Visible = False
            GrpPurchaseDetails.Visible = False

            GrpSale.Visible = True
            GrpSaleDetails.Visible = True

            GrpVoucher.Visible = False
            GrpVoucherDetails.Visible = False

            GrpBankTransaction.Visible = False
            GrpBankTransactionTotal.Visible = False

            'Gridview prvious load Clear code
            GrdSearch.Columns.Clear()

        ElseIf CmbSelectSearchBy.Text = "VOUCHER" Then

            GrpProductDetails.Visible = False
            GrpProducts.Visible = False

            GrpPurchase.Visible = False
            GrpPurchaseDetails.Visible = False

            GrpSale.Visible = False
            GrpSaleDetails.Visible = False


            GrpVoucher.Visible = True
            GrpVoucherDetails.Visible = True


            GrpBankTransaction.Visible = False
            GrpBankTransactionTotal.Visible = False

            'Gridview prvious load Clear code
            GrdSearch.Columns.Clear()

        ElseIf CmbSelectSearchBy.Text = "BANK TRANSACTION" Then

            GrpProductDetails.Visible = False
            GrpProducts.Visible = False

            GrpPurchase.Visible = False
            GrpPurchaseDetails.Visible = False

            GrpSale.Visible = False
            GrpSaleDetails.Visible = False


            GrpVoucher.Visible = True
            GrpVoucherDetails.Visible = True


            GrpBankTransaction.Visible = True
            GrpBankTransactionTotal.Visible = True

            'Gridview prvious load Clear code
            GrdSearch.Columns.Clear()



        End If

    End Sub

    Private Sub CmbSearchProduct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSearchProduct.SelectedIndexChanged

        '"Product Name"
        If CmbSearchProduct.SelectedIndex = 0 Then

            TxtSearchProductName.Visible = True
            CmbSearchProductCategory.Visible = False
            CmbSearchProductSubcategory.Visible = False
            CmbSearchProductGroup.Visible = False




            TxtSearchProductName.Focus()
            'Clear Data  For Product Details

            ClearDataForProductDetails()

            'Gridview prvious load Clear code
            'GrdSearch.Columns.Clear()

            '"Product Group"
        ElseIf CmbSearchProduct.SelectedIndex = 1 Then

            TxtSearchProductName.Visible = False
            CmbSearchProductCategory.Visible = False
            CmbSearchProductSubcategory.Visible = False
            CmbSearchProductGroup.Visible = True



            CmbSearchProductGroup.Focus()

            'Clear Data  For Product Details
            ClearDataForProductDetails()


            '"Product Category"
        ElseIf CmbSearchProduct.SelectedIndex = 2 Then


            TxtSearchProductName.Visible = False
            CmbSearchProductCategory.Visible = True
            CmbSearchProductSubcategory.Visible = False
            CmbSearchProductGroup.Visible = False



            CmbSearchProductCategory.Focus()

            'Clear Data  For Product Details
            ClearDataForProductDetails()

            '"Product Subcategory"
        ElseIf CmbSearchProduct.SelectedIndex = 3 Then


            TxtSearchProductName.Visible = False
            CmbSearchProductCategory.Visible = False
            CmbSearchProductSubcategory.Visible = True
            CmbSearchProductGroup.Visible = False



            CmbSearchProductSubcategory.Focus()

            'Clear Data  For Product Details
            ClearDataForProductDetails()

            '"Low Stock Product"
        ElseIf CmbSearchProduct.SelectedIndex = 4 Then


            TxtSearchProductName.Visible = False
            CmbSearchProductCategory.Visible = False
            CmbSearchProductSubcategory.Visible = False
            CmbSearchProductGroup.Visible = False



            'Clear Data  For Product Details
            ClearDataForProductDetails()


        End If
    End Sub


    'SearchProducts
    Sub SearchForProduct()

        Try




            ' Load Data
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim connectionString As String = FrmHome.ConnectionString

            If Me.CmbSearchProduct.SelectedIndex = 0 Then


                Dim sql As String = "Select [Purchase Invoice].[Purchase Date],Purchase.[Purchase ID] , products. [Barcode Serial],products. [Product Name],[Product Group].[Product Group Name],[Product Category].[Product Category Name],[Product Subcategory].[Product Subcategory Name],[Branch Information].[Branch Name]+' - '+[Location Information].[Location Name] as Location,[Purchase].[Purchase Unit Cost][Purchase Cost],Avg([Products].[Sale Price])[Sale Price],isnull([Purchase].[Purchase Quantity],0)- isnull(Sum([sale].[Sale Quantity]),0)[Stock Available] from [purchase] join [Products] on [purchase].[Product ID] = [Products].[Product ID] left join [Sale] on purchase.[Purchase Id] = [Sale].[Purchase ID] and [Purchase].[Product ID] =sale.[Product ID] join [Location Information] on [Purchase].[Purchase Location ID]=[Location Information].[Location ID] join [Branch Information] on [Purchase].[Purchase Location ID] = [Location Information].[Location ID] Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID] Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID] Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID] WHERE (Products.[Product Name] Like '%" + TxtSearchProductName.Text + "%') group by   [Purchase Invoice].[Purchase Date], Products.[Barcode Serial], [Purchase].[Product ID],[Product Group].[Product Group Name],[Product Category].[Product Category Name],[Product Subcategory].[Product Subcategory Name],[Products].[Product Name], [Purchase].[Purchase Unit Cost],[Purchase].[Purchase Quantity],[Purchase].[Purchase ID],[Location Information].[Location Name],[Branch Information].[Branch Name] Having isnull(Purchase.[Purchase Quantity],0)- isnull(Sum(sale.[Sale Quantity]),0)>0 order by [Purchase Invoice].[Purchase Date] asc "

                Dim connection As New SqlConnection(connectionString)

                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Products")
                GrdSearch.DataSource = ds
                GrdSearch.DataMember = "BizPro_Products"
                GrdSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                'Total Stock Count
                TotalProductDetails()

                con.Close()



            ElseIf Me.CmbSearchProduct.SelectedIndex = 1 Then


                Dim sql As String = "Select [Purchase Invoice].[Purchase Date],Purchase.[Purchase ID] , products. [Barcode Serial],products. [Product Name],[Product Group].[Product Group Name],[Product Category].[Product Category Name],[Product Subcategory].[Product Subcategory Name],[Branch Information].[Branch Name]+' - '+[Location Information].[Location Name] as Location,[Purchase].[Purchase Unit Cost][Purchase Cost],Avg([Products].[Sale Price])[Sale Price],isnull([Purchase].[Purchase Quantity],0)- isnull(Sum([sale].[Sale Quantity]),0)[Stock Available] from [purchase] join [Products] on [purchase].[Product ID] = [Products].[Product ID] left join [Sale] on purchase.[Purchase Id] = [Sale].[Purchase ID] and [Purchase].[Product ID] =sale.[Product ID] join [Location Information] on [Purchase].[Purchase Location ID]=[Location Information].[Location ID] join [Branch Information] on [Purchase].[Purchase Location ID] = [Location Information].[Location ID] Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID] Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID] Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID]  WHERE ([Product Group].[Product Group ID] = '" + CmbSearchProductGroup.ValueMember + "') group by [Purchase Invoice].[Purchase Date], Products.[Barcode Serial], [Purchase].[Product ID],[Product Group].[Product Group Name],[Product Category].[Product Category Name],[Product Subcategory].[Product Subcategory Name],[Products].[Product Name], [Purchase].[Purchase Unit Cost],[Purchase].[Purchase Quantity],[Purchase].[Purchase ID],[Location Information].[Location Name],[Branch Information].[Branch Name] Having isnull(Purchase.[Purchase Quantity],0)- isnull(Sum(sale.[Sale Quantity]),0)>0 order by [Purchase Invoice].[Purchase Date] asc"

                Dim connection As New SqlConnection(connectionString)

                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Products")
                GrdSearch.DataSource = ds
                GrdSearch.DataMember = "BizPro_Products"
                GrdSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                'Total Stock Count
                TotalProductDetails()

                con.Close()


            ElseIf Me.CmbSearchProduct.SelectedIndex = 2 Then


                Dim sql As String = "Select [Purchase Invoice].[Purchase Date],Purchase.[Purchase ID] , products. [Barcode Serial],products. [Product Name],[Product Group].[Product Group Name],[Product Category].[Product Category Name],[Product Subcategory].[Product Subcategory Name],[Branch Information].[Branch Name]+' - '+[Location Information].[Location Name] as Location,[Purchase].[Purchase Unit Cost][Purchase Cost],Avg([Products].[Sale Price])[Sale Price],isnull([Purchase].[Purchase Quantity],0)- isnull(Sum([sale].[Sale Quantity]),0)[Stock Available] from [purchase] join [Products] on [purchase].[Product ID] = [Products].[Product ID] left join [Sale] on purchase.[Purchase Id] = [Sale].[Purchase ID] and [Purchase].[Product ID] =sale.[Product ID] join [Location Information] on [Purchase].[Purchase Location ID]=[Location Information].[Location ID] join [Branch Information] on [Purchase].[Purchase Location ID] = [Location Information].[Location ID] Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID] Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID] Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID] WHERE ([Product Category].[Product Category ID] = '" + CmbSearchProductCategory.ValueMember + "') group by [Purchase Invoice].[Purchase Date], Products.[Barcode Serial], [Purchase].[Product ID],[Product Group].[Product Group Name],[Product Category].[Product Category Name],[Product Subcategory].[Product Subcategory Name],[Products].[Product Name], [Purchase].[Purchase Unit Cost],[Purchase].[Purchase Quantity],[Purchase].[Purchase ID],[Location Information].[Location Name],[Branch Information].[Branch Name] Having isnull(Purchase.[Purchase Quantity],0)- isnull(Sum(sale.[Sale Quantity]),0)>0 order by [Purchase Invoice].[Purchase Date] asc "

                Dim connection As New SqlConnection(connectionString)

                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Products")
                GrdSearch.DataSource = ds
                GrdSearch.DataMember = "BizPro_Products"
                GrdSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                'Total Stock Count
                TotalProductDetails()

                con.Close()


            ElseIf Me.CmbSearchProduct.SelectedIndex = 3 Then


                Dim sql As String = "Select [Purchase Invoice].[Purchase Date],Purchase.[Purchase ID] , products. [Barcode Serial],products. [Product Name],[Product Group].[Product Group Name],[Product Category].[Product Category Name],[Product Subcategory].[Product Subcategory Name],[Branch Information].[Branch Name]+' - '+[Location Information].[Location Name] as Location,[Purchase].[Purchase Unit Cost][Purchase Cost],Avg([Products].[Sale Price])[Sale Price],isnull([Purchase].[Purchase Quantity],0)- isnull(Sum([sale].[Sale Quantity]),0)[Stock Available] from [purchase] join [Products] on [purchase].[Product ID] = [Products].[Product ID] left join [Sale] on purchase.[Purchase Id] = [Sale].[Purchase ID] and [Purchase].[Product ID] =sale.[Product ID] join [Location Information] on [Purchase].[Purchase Location ID]=[Location Information].[Location ID] join [Branch Information] on [Purchase].[Purchase Location ID] = [Location Information].[Location ID] Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID] Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID] Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID] WHERE ([Product SubCategory].[Product SubCategory ID] = '" + Me.CmbSearchProductSubcategory.ValueMember + "') group by [Purchase Invoice].[Purchase Date], Products.[Barcode Serial], [Purchase].[Product ID],[Product Group].[Product Group Name],[Product Category].[Product Category Name],[Product Subcategory].[Product Subcategory Name],[Products].[Product Name], [Purchase].[Purchase Unit Cost],[Purchase].[Purchase Quantity],[Purchase].[Purchase ID],[Location Information].[Location Name],[Branch Information].[Branch Name] Having isnull(Purchase.[Purchase Quantity],0)- isnull(Sum(sale.[Sale Quantity]),0)>0 order by [Purchase Invoice].[Purchase Date] asc "

                Dim connection As New SqlConnection(connectionString)

                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Products")
                GrdSearch.DataSource = ds
                GrdSearch.DataMember = "BizPro_Products"
                GrdSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                'Total Stock Count
                TotalProductDetails()

                con.Close()

            ElseIf Me.CmbSearchProduct.SelectedIndex = 4 Then


                Dim sql As String = "Select [Purchase Invoice].[Purchase Date],Purchase.[Purchase ID] , products. [Barcode Serial],products. [Product Name],[Product Group].[Product Group Name],[Product Category].[Product Category Name],[Product Subcategory].[Product Subcategory Name],[Branch Information].[Branch Name]+' - '+[Location Information].[Location Name] as Location,[Purchase].[Purchase Unit Cost][Purchase Cost],Avg([Products].[Sale Price])[Sale Price],isnull([Purchase].[Purchase Quantity],0)- isnull(Sum([sale].[Sale Quantity]),0)[Stock Available] from [purchase] join [Products] on [purchase].[Product ID] = [Products].[Product ID] left join [Sale] on purchase.[Purchase Id] = [Sale].[Purchase ID] and [Purchase].[Product ID] =sale.[Product ID] join [Location Information] on [Purchase].[Purchase Location ID]=[Location Information].[Location ID] join [Branch Information] on [Purchase].[Purchase Location ID] = [Location Information].[Location ID] Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID] Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID] Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID] group by [Purchase Invoice].[Purchase Date], Products.[Barcode Serial], [Purchase].[Product ID],[Product Group].[Product Group Name],[Product Category].[Product Category Name],[Product Subcategory].[Product Subcategory Name],[Products].[Product Name], [Purchase].[Purchase Unit Cost],[Purchase].[Purchase Quantity],[Purchase].[Purchase ID],[Location Information].[Location Name],[Branch Information].[Branch Name] Having isnull(Purchase.[Purchase Quantity],0)- isnull(Sum(sale.[Sale Quantity]),0)>0 order by [Purchase Invoice].[Purchase Date] asc WHERE ([Product SubCategory].[Product SubCategory ID] = '" + Me.CmbSearchProductSubcategory.ValueMember + "')"

                Dim connection As New SqlConnection(connectionString)

                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Products")
                GrdSearch.DataSource = ds
                GrdSearch.DataMember = "BizPro_Products"
                GrdSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill




                con.Close()

            End If

        Catch ex As Exception
            MessageBox.Show("Error while searching records on table..." & ex.Message, "Search Sub")
        Finally

        End Try


    End Sub


    'Search Purchase
    Sub SearchForPurchase()

        Try




            ' Load Data
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim connectionString As String = FrmHome.ConnectionString

            If Me.CmbSearchPurchase.SelectedIndex = 0 Then


                Dim sql As String = "SELECT [User Account].[User Name],[Purchase Invoice].[Purchase Invoice No],[Supplier Information].[Supplier Name],[Purchase Invoice].[Purchase Date],[Purchase Invoice].[Purchase Time],[Purchase Invoice].[Vat Percentage],[Purchase Invoice].[Vat],[Purchase Invoice].[Discount Percentage],[Purchase Invoice].[Discount],[Purchase Invoice].[Previous Dues],[Purchase Invoice].[Advance],[Purchase Invoice].[Net Payable],[Purchase Invoice].[Paid Amount],[Payment Method].[Payment Method Name] from [Purchase Invoice]  join [User Account] on [Purchase Invoice].[User Account ID]=[User Account].[User Account ID]join [Supplier Information] on [Purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID] join [Payment Method] on [Purchase Invoice].[Paid By]=[Payment Method].[Payment Method ID]  where  [Purchase Invoice].[Purchase Invoice No]='" + TxtSearchPurchaseInvoice.Text + "'  order by [Purchase Invoice].[Purchase Date]  desc, [Purchase Invoice].[Purchase Time] desc"

                Dim connection As New SqlConnection(connectionString)

                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Purchase Invoice")
                GrdSearch.DataSource = ds
                GrdSearch.DataMember = "BizPro_Purchase Invoice"
                GrdSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                'Total Purchase details
                TotalPurchaseDetails()

                con.Close()



            ElseIf Me.CmbSearchPurchase.SelectedIndex = 1 Then


                Dim sql As String = "SELECT [User Account].[User Name],[Purchase Invoice].[Purchase Invoice No],[Supplier Information].[Supplier Name],[Purchase Invoice].[Purchase Date],[Purchase Invoice].[Purchase Time],[Purchase Invoice].[Vat Percentage],[Purchase Invoice].[Vat],[Purchase Invoice].[Discount Percentage],[Purchase Invoice].[Discount],[Purchase Invoice].[Previous Dues],[Purchase Invoice].[Advance],[Purchase Invoice].[Net Payable],[Purchase Invoice].[Paid Amount],[Payment Method].[Payment Method Name] from [Purchase Invoice]  join [User Account] on [Purchase Invoice].[User Account ID]=[User Account].[User Account ID]join [Supplier Information] on [Purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID] join [Payment Method] on [Purchase Invoice].[Paid By]=[Payment Method].[Payment Method ID]  where  [Purchase Invoice].[Status]='COMPLETE' And [Purchase Invoice].[Purchase Date] Between '" + DtpPurchaseFromDate.Value + "' and '" + DtpPurchaseTodate.Value + "'  order by [Purchase Invoice].[Purchase Date]  desc, [Purchase Invoice].[Purchase Time] desc"

                Dim connection As New SqlConnection(connectionString)

                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Purchase Invoice")
                GrdSearch.DataSource = ds
                GrdSearch.DataMember = "BizPro_Purchase Invoice"
                GrdSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                'Total Purchase details
                TotalPurchaseDetails()

                con.Close()


            ElseIf Me.CmbSearchPurchase.SelectedIndex = 2 Then


                Dim sql As String = "SELECT [Products].[Product Name],[Product Group].[Product Group Name],[Product Category].[Product Category Name],[Product Subcategory].[Product Subcategory Name],[Branch Information].[Branch Name], isnull(Sum([Purchase].[Purchase Quantity]),0)[Total Purchase Quantity],isnull(Sum([Purchase].[Amount]),0)[Total Purchase Amount] from [Purchase] join [Products] on [Purchase].[product ID]=[products].[Product ID]Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID] Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID] Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID] join [Branch Information] on [Purchase].[Branch ID]=[Branch Information].[Branch ID]join [Purchase Invoice] on [Purchase].[Purchase Invoice No]=[Purchase Invoice].[Purchase Invoice No] where [Purchase Invoice].[Purchase Date] Between '" + DtpPurchaseFromDate.Value + "' and '" + DtpPurchaseTodate.Value + "' group by[Products].[Product Name],[Product Group].[Product Group Name],[Product Category].[Product Category Name],[Product Subcategory].[Product Subcategory Name],[Branch Information].[Branch Name] order by [Total Purchase Quantity] desc"

                Dim connection As New SqlConnection(connectionString)

                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Purchase Invoice")
                GrdSearch.DataSource = ds
                GrdSearch.DataMember = "BizPro_Purchase Invoice"
                GrdSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill



                con.Close()




            End If

        Catch ex As Exception
            MessageBox.Show("Error while searching records on table..." & ex.Message, "Search Sub")
        Finally

        End Try


    End Sub

    'Search Sale
    Sub SearchForSale()

        Try




            ' Load Data
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim connectionString As String = FrmHome.ConnectionString

            If Me.CmbSearchSale.SelectedIndex = 0 Then


                Dim sql As String = "SELECT [User Account].[User Name],[Sale Invoice].[Sale Invoice No],[Customer Information].[Customer Name],[Sale Invoice].[Sale Date],[Sale Invoice].[Sale Time],[Sale Invoice].[Vat Percentage],[Sale Invoice].[Vat],[Sale Invoice].[Discount Percentage],[Sale Invoice].[Discount],[Sale Invoice].[Previous Dues],[Sale Invoice].[Advance],[Sale Invoice].[Net Payable],[Sale Invoice].[Paid Amount],[Payment Method].[Payment Method Name] from [Sale Invoice]  join [User Account] on [Sale Invoice].[User Account ID]=[User Account].[User Account ID]join [Customer Information] on [Sale Invoice].[Customer ID]=[Customer Information].[Customer ID] join [Payment Method] on [Sale Invoice].[Paid By]=[Payment Method].[Payment Method ID]  where  [Sale Invoice].[Sale Invoice No]='" + TxtSearchSaleInvoice.Text + "'  order by [Sale Invoice].[Sale Date]  desc, [Sale Invoice].[Sale Time] desc"

                Dim connection As New SqlConnection(connectionString)

                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Sale Invoice")
                GrdSearch.DataSource = ds
                GrdSearch.DataMember = "BizPro_Sale Invoice"
                GrdSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                'Total Sale details
                TotalSaleDetails()

                con.Close()



            ElseIf Me.CmbSearchSale.SelectedIndex = 1 Then


                Dim sql As String = "SELECT [User Account].[User Name],[Sale Invoice].[Sale Invoice No],[Customer Information].[Customer Name],[Sale Invoice].[Sale Date],[Sale Invoice].[Sale Time],[Sale Invoice].[Vat Percentage],[Sale Invoice].[Vat],[Sale Invoice].[Discount Percentage],[Sale Invoice].[Discount],[Sale Invoice].[Previous Dues],[Sale Invoice].[Advance],[Sale Invoice].[Net Payable],[Sale Invoice].[Paid Amount],[Payment Method].[Payment Method Name] from [Sale Invoice]  join [User Account] on [Sale Invoice].[User Account ID]=[User Account].[User Account ID]join [Customer Information] on [Sale Invoice].[Customer ID]=[Customer Information].[Customer ID] join [Payment Method] on [Sale Invoice].[Paid By]=[Payment Method].[Payment Method ID]   where  [Sale Invoice].[Status]='COMPLETE' And [Sale Invoice].[Sale Date] Between '" + DtpSaleFromDate.Value + "' and '" + DtpSaleToDate.Value + "'  order by [Sale Invoice].[Sale Date]  desc, [Sale Invoice].[Sale Time] desc"

                Dim connection As New SqlConnection(connectionString)

                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Sale Invoice")
                GrdSearch.DataSource = ds
                GrdSearch.DataMember = "BizPro_Sale Invoice"
                GrdSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                'Total Sale details
                TotalSaleDetails()

                con.Close()


            ElseIf Me.CmbSearchSale.SelectedIndex = 2 Then


                Dim sql As String = "SELECT [Products].[Product Name],[Product Group].[Product Group Name],[Product Category].[Product Category Name],[Product Subcategory].[Product Subcategory Name],[Branch Information].[Branch Name], isnull(Sum([Sale].[Sale Quantity]),0)[Total Sale Quantity],isnull(Sum([Sale].[Sale Amount]),0)[Total Sale Amount] from [Sale] join [Products] on [Sale].[product ID]=[products].[Product ID]Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID] Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID] Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID] join [Branch Information] on [Sale].[Branch ID]=[Branch Information].[Branch ID]join [Sale Invoice] on [Sale].[Sale Invoice No]=[Sale Invoice].[Sale Invoice No] where [Sale Invoice].[Sale Date] Between '" + DtpSaleFromDate.Value + "' and '" + DtpSaleToDate.Value + "' group by[Products].[Product Name],[Product Group].[Product Group Name],[Product Category].[Product Category Name],[Product Subcategory].[Product Subcategory Name],[Branch Information].[Branch Name] order by [Total Sale Quantity] desc"

                Dim connection As New SqlConnection(connectionString)

                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Sale Invoice")
                GrdSearch.DataSource = ds
                GrdSearch.DataMember = "BizPro_Sale Invoice"
                GrdSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill



                con.Close()


            ElseIf Me.CmbSearchSale.SelectedIndex = 3 Then


                Dim sql As String = "SELECT [User Account].[User Name],[Sale Invoice].[Sale Invoice No],[Customer Information].[Customer Name],[Sale Invoice].[Sale Date],[Sale Invoice].[Sale Time],[Sale Invoice].[Vat Percentage],[Sale Invoice].[Vat],[Sale Invoice].[Discount Percentage],[Sale Invoice].[Discount],[Sale Invoice].[Previous Dues],[Sale Invoice].[Advance],[Sale Invoice].[Net Payable],[Sale Invoice].[Paid Amount],[Payment Method].[Payment Method Name] from [Sale Invoice]  join [User Account] on [Sale Invoice].[User Account ID]=[User Account].[User Account ID]join [Customer Information] on [Sale Invoice].[Customer ID]=[Customer Information].[Customer ID] join [Payment Method] on [Sale Invoice].[Paid By]=[Payment Method].[Payment Method ID] join [Customer Category] on [Customer Information].[Customer Category ID]=[Customer Category].[Customer Category ID] where  [Customer Category].[Customer Category ID]='" + cmbCustomerCategory.SelectedValue.ToString + "' And [Sale Invoice].[Sale Date] Between '" + DtpSaleFromDate.Value + "' and '" + DtpSaleToDate.Value + "' order by [Sale Invoice].[Sale Date]  desc, [Sale Invoice].[Sale Time] desc"

                Dim connection As New SqlConnection(connectionString)

                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Sale Invoice")
                GrdSearch.DataSource = ds
                GrdSearch.DataMember = "BizPro_Sale Invoice"
                GrdSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill



                con.Close()

                'Total Sale details
                TotalSaleDetails()

            ElseIf Me.CmbSearchSale.SelectedIndex = 4 Then


                Dim sql As String = "SELECT [Products].[Product Name],[Product Group].[Product Group Name],[Product Category].[Product Category Name],[Product Subcategory].[Product Subcategory Name],[Branch Information].[Branch Name], isnull(Sum([Sale].[Sale Quantity]),0)[Total Sale Quantity],isnull(Sum([Sale].[Sale Amount]),0)[Total Sale Amount] from [Sale] join [Products] on [Sale].[product ID]=[products].[Product ID]Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID] Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID] Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID] join [Branch Information] on [Sale].[Branch ID]=[Branch Information].[Branch ID]join [Sale Invoice] on [Sale].[Sale Invoice No]=[Sale Invoice].[Sale Invoice No] where [Products].[Product Name] Like '%" + TxtSearchSaleInvoice.Text + "%' And [Sale Invoice].[Sale Date] Between '" + DtpSaleFromDate.Value + "' and '" + DtpSaleToDate.Value + "' group by[Products].[Product Name],[Product Group].[Product Group Name],[Product Category].[Product Category Name],[Product Subcategory].[Product Subcategory Name],[Branch Information].[Branch Name] "

                Dim connection As New SqlConnection(connectionString)

                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Sale Invoice")
                GrdSearch.DataSource = ds
                GrdSearch.DataMember = "BizPro_Sale Invoice"
                GrdSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                con.Close()

            End If

        Catch ex As Exception
            MessageBox.Show("Error while searching records on table..." & ex.Message, "Search Sub")
        Finally

        End Try


    End Sub
    'Search Voucher
    Sub SearchForVoucher()

        Try




            ' Load Data
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim connectionString As String = FrmHome.ConnectionString

            If Me.CmbSearchVoucher.SelectedIndex = 0 Then


                Dim sql As String = "select [Voucher].[Voucher No],[Voucher].[Name],[voucher].[Date],[Voucher].[Prepared Time],[Branch Information].[Branch Name],[Voucher].[Voucher Category Name],[Voucher Subcategory].[Voucher Subcategory Name],[Voucher Purpose].[Voucher Purpose Name],isnull(Sum([Voucher].[Paid Amount]),0)[Paid Amount],isnull(Sum([Voucher].[Received Amount]),0)[Received Amount] from [Voucher] [Voucher] Join [Voucher Purpose] On [Voucher].[Voucher Purpose ID]=[Voucher Purpose].[Voucher Purpose ID]Join [Branch Information] On [Voucher].[Branch ID]=[Branch Information].[Branch ID] Join [Voucher Subcategory] On [Voucher].[Voucher Subcategory ID]=[Voucher Subcategory].[Voucher Subcategory ID] where [voucher].[Status]='COMPLETE' And [Voucher].[Voucher No]= '" + TxtSearchVoucherNo.Text + "' group by  [Voucher].[Voucher No],[Voucher].[Voucher Category Name],[Branch Information].[Branch Name],[Voucher Subcategory].[Voucher Subcategory Name],[Voucher Purpose].[Voucher Purpose Name],[Voucher].[Name],[voucher].[Date],[Voucher].[Prepared Time]  order by [voucher].[Date] desc, [Voucher].[Prepared Time] desc "

                Dim connection As New SqlConnection(connectionString)

                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Voucher")
                GrdSearch.DataSource = ds
                GrdSearch.DataMember = "BizPro_Voucher"
                GrdSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                'Total Voucher details
                TotalVoucherDetails()


                con.Close()



            ElseIf Me.CmbSearchVoucher.SelectedIndex = 1 Then


                Dim sql As String = "select [Voucher].[Voucher No],[Voucher].[Name],[voucher].[Date],[Voucher].[Prepared Time],[Branch Information].[Branch Name],[Voucher].[Voucher Category Name],[Voucher Subcategory].[Voucher Subcategory Name],[Voucher Purpose].[Voucher Purpose Name],isnull(Sum([Voucher].[Paid Amount]),0)[Paid Amount],isnull(Sum([Voucher].[Received Amount]),0)[Received Amount] from [Voucher] [Voucher] Join [Voucher Purpose] On [Voucher].[Voucher Purpose ID]=[Voucher Purpose].[Voucher Purpose ID]Join [Branch Information] On [Voucher].[Branch ID]=[Branch Information].[Branch ID] Join [Voucher Subcategory] On [Voucher].[Voucher Subcategory ID]=[Voucher Subcategory].[Voucher Subcategory ID] where [voucher].[Status]='COMPLETE' And [Voucher].[Voucher Category Name]='" + CmbSearchVoucherCategory.Text + "' And [voucher].[Date] Between '" + DtpVoucherFromDate.Value + "' and '" + DtpVoucherToDate.Value + "'  group by  [Voucher].[Voucher No],[Voucher].[Voucher Category Name],[Branch Information].[Branch Name],[Voucher Subcategory].[Voucher Subcategory Name],[Voucher Purpose].[Voucher Purpose Name],[Voucher].[Name],[voucher].[Date],[Voucher].[Prepared Time]  order by [voucher].[Date] desc, [Voucher].[Prepared Time] desc "

                Dim connection As New SqlConnection(connectionString)

                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Voucher")
                GrdSearch.DataSource = ds
                GrdSearch.DataMember = "BizPro_Voucher"
                GrdSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                'Total Voucher details
                TotalVoucherDetails()


                con.Close()


            ElseIf Me.CmbSearchVoucher.SelectedIndex = 2 Then


                Dim sql As String = "select [Voucher].[Voucher No],[Voucher].[Name],[voucher].[Date],[Voucher].[Prepared Time],[Branch Information].[Branch Name],[Voucher].[Voucher Category Name],[Voucher Subcategory].[Voucher Subcategory Name],[Voucher Purpose].[Voucher Purpose Name],isnull(Sum([Voucher].[Paid Amount]),0)[Paid Amount],isnull(Sum([Voucher].[Received Amount]),0)[Received Amount] from [Voucher] [Voucher] Join [Voucher Purpose] On [Voucher].[Voucher Purpose ID]=[Voucher Purpose].[Voucher Purpose ID]Join [Branch Information] On [Voucher].[Branch ID]=[Branch Information].[Branch ID] Join [Voucher Subcategory] On [Voucher].[Voucher Subcategory ID]=[Voucher Subcategory].[Voucher Subcategory ID] where [voucher].[Status]='COMPLETE' And [Voucher Subcategory].[Voucher Subcategory ID]='" + CmbSearchVoucherSubcategory.SelectedValue.ToString + "' And [voucher].[Date] Between '" + DtpVoucherFromDate.Value + "' and '" + DtpVoucherToDate.Value + "'   group by  [Voucher].[Voucher No],[Voucher].[Voucher Category Name],[Branch Information].[Branch Name],[Voucher Subcategory].[Voucher Subcategory Name],[Voucher Purpose].[Voucher Purpose Name],[Voucher].[Name],[voucher].[Date],[Voucher].[Prepared Time]  order by [voucher].[Date] desc, [Voucher].[Prepared Time] desc "

                Dim connection As New SqlConnection(connectionString)

                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Voucher")
                GrdSearch.DataSource = ds
                GrdSearch.DataMember = "BizPro_Voucher"
                GrdSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                'Total Voucher details
                TotalVoucherDetails()

                con.Close()

            ElseIf Me.CmbSearchVoucher.SelectedIndex = 3 Then


                Dim sql As String = "select [Voucher].[Voucher No],[Voucher].[Name],[voucher].[Date],[Voucher].[Prepared Time],[Branch Information].[Branch Name],[Voucher].[Voucher Category Name],[Voucher Subcategory].[Voucher Subcategory Name],[Voucher Purpose].[Voucher Purpose Name],isnull(Sum([Voucher].[Paid Amount]),0)[Paid Amount],isnull(Sum([Voucher].[Received Amount]),0)[Received Amount] from [Voucher] [Voucher] Join [Voucher Purpose] On [Voucher].[Voucher Purpose ID]=[Voucher Purpose].[Voucher Purpose ID]Join [Branch Information] On [Voucher].[Branch ID]=[Branch Information].[Branch ID] Join [Voucher Subcategory] On [Voucher].[Voucher Subcategory ID]=[Voucher Subcategory].[Voucher Subcategory ID] where [voucher].[Status]='COMPLETE' And [Voucher Purpose].[Voucher Purpose ID]='" + CmbSearchVoucherPurpose.SelectedValue.ToString + "' And [voucher].[Date] Between '" + DtpVoucherFromDate.Value + "' and '" + DtpVoucherToDate.Value + "'   group by  [Voucher].[Voucher No],[Voucher].[Voucher Category Name],[Branch Information].[Branch Name],[Voucher Subcategory].[Voucher Subcategory Name],[Voucher Purpose].[Voucher Purpose Name],[Voucher].[Name],[voucher].[Date],[Voucher].[Prepared Time]  order by [voucher].[Date] desc, [Voucher].[Prepared Time] desc"

                Dim connection As New SqlConnection(connectionString)

                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Voucher")
                GrdSearch.DataSource = ds
                GrdSearch.DataMember = "BizPro_Voucher"
                GrdSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                'Total Voucher details
                TotalVoucherDetails()


                con.Close()

            ElseIf Me.CmbSearchVoucher.SelectedIndex = 4 Then


                Dim sql As String = "select [Voucher].[Voucher No],[Voucher].[Name],[voucher].[Date],[Voucher].[Prepared Time],[Branch Information].[Branch Name],[Voucher].[Voucher Category Name],isnull(Sum([Voucher].[Paid Amount]),0)[Paid Amount],isnull(Sum([Voucher].[Received Amount]),0)[Received Amount] from [Voucher] [Voucher] Join [Voucher Purpose] On [Voucher].[Voucher Purpose ID]=[Voucher Purpose].[Voucher Purpose ID]Join [Branch Information] On [Voucher].[Branch ID]=[Branch Information].[Branch ID] Join [Voucher Subcategory] On [Voucher].[Voucher Subcategory ID]=[Voucher Subcategory].[Voucher Subcategory ID] where [voucher].[Status]='COMPLETE'  And [voucher].[Date] Between '" + DtpVoucherFromDate.Value + "' and '" + DtpVoucherToDate.Value + "' group by  [Voucher].[Voucher No],[Voucher].[Voucher Category Name],[Branch Information].[Branch Name],[Voucher].[Name],[voucher].[Date],[Voucher].[Prepared Time]  order by [voucher].[Date] desc, [Voucher].[Prepared Time] desc"

                Dim connection As New SqlConnection(connectionString)

                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Voucher")
                GrdSearch.DataSource = ds
                GrdSearch.DataMember = "BizPro_Voucher"
                GrdSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                con.Close()



                Dim total1 As String = 0
                For i As Integer = 0 To GrdSearch.RowCount - 1
                    total1 += GrdSearch.Rows(i).Cells(6).Value
                Next
                Me.LblPaidAmount.Text = total1


                Dim total2 As String = 0
                For i As Integer = 0 To GrdSearch.RowCount - 1
                    total2 += GrdSearch.Rows(i).Cells(7).Value
                Next
                Me.LblReceivedAmount.Text = total2


                Dim total3 As String = 0

                total3 = GrdSearch.Rows.Count

                Me.LblTotalVoucher.Text = total3





            ElseIf Me.CmbSearchVoucher.SelectedIndex = 5 Then


                Dim sql As String = "select [Branch Information].[Branch Name],[Voucher].[Voucher Category Name],[Voucher Subcategory].[Voucher Subcategory Name],[Voucher Purpose].[Voucher Purpose Name],isnull(Sum([Voucher].[Paid Amount]),0)[Paid Amount],isnull(Sum([Voucher].[Received Amount]),0)[Received Amount] from [Voucher] [Voucher] Join [Voucher Purpose] On [Voucher].[Voucher Purpose ID]=[Voucher Purpose].[Voucher Purpose ID]Join [Branch Information] On [Voucher].[Branch ID]=[Branch Information].[Branch ID] Join [Voucher Subcategory] On [Voucher].[Voucher Subcategory ID]=[Voucher Subcategory].[Voucher Subcategory ID] where [voucher].[Status]='COMPLETE' And [voucher].[Date] Between '" + DtpVoucherFromDate.Value + "' and '" + DtpVoucherToDate.Value + "'  group by  [Voucher].[Voucher Category Name],[Branch Information].[Branch Name],[Voucher Subcategory].[Voucher Subcategory Name],[Voucher Purpose].[Voucher Purpose Name]   "

                Dim connection As New SqlConnection(connectionString)

                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Voucher")
                GrdSearch.DataSource = ds
                GrdSearch.DataMember = "BizPro_Voucher"
                GrdSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                con.Close()



                Dim total1 As String = 0
                For i As Integer = 0 To GrdSearch.RowCount - 1
                    total1 += GrdSearch.Rows(i).Cells(4).Value
                Next
                Me.LblPaidAmount.Text = total1


                Dim total2 As String = 0
                For i As Integer = 0 To GrdSearch.RowCount - 1
                    total2 += GrdSearch.Rows(i).Cells(5).Value
                Next
                Me.LblReceivedAmount.Text = total2


            End If

        Catch ex As Exception
            MessageBox.Show("Error while searching records on table..." & ex.Message, "Search Sub")
        Finally

        End Try


    End Sub
    'Search For Bank Transaction
    Sub SearchBankTransaction()

        ' Load Data
        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            If CmbBankSearch.SelectedIndex = 0 Then

                Dim connectionString As String = FrmHome.ConnectionString
                Dim sql As String = "SELECT [Bank Transaction].[Bank Transaction ID],[Bank Information].[Bank Name],[Bank Transaction].[Check No],[Bank Transaction].[Remarks],[Bank Transaction].[Transaction Date],[Bank Transaction].[Debited Amount],[Bank Transaction].[Credited Amount] From [Bank Transaction] Join [Bank Information] On [Bank Transaction].[Bank ID] = [Bank Information].[Bank ID] where [Bank Information].[Bank ID]= '" + CmbSeachBankNameBank.SelectedValue.ToString + "' And [Bank Transaction].[Transaction Date]  between '" + DtpBankFromDate.Value + "'  and '" + DtpBankToDate.Value + "' "
                Dim connection As New SqlConnection(connectionString)
                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Bank Transaction")
                connection.Close()
                GrdSearch.DataSource = ds
                GrdSearch.DataMember = "BizPro_Bank Transaction"

                'GrdBankTransaction.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdBankTransaction.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
                GrdSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                con.Close()

                'Total Balance For Electricity Bill
                TotalBalanceForBankTransaction()

            ElseIf CmbBankSearch.SelectedIndex = 1 Then

                Dim connectionString As String = FrmHome.ConnectionString
                Dim sql As String = "SELECT [Bank Transaction].[Bank Transaction ID],[Bank Information].[Bank Name],[Bank Transaction].[Check No],[Bank Transaction].[Remarks],[Bank Transaction].[Transaction Date],[Bank Transaction].[Debited Amount],[Bank Transaction].[Credited Amount] From [Bank Transaction] Join [Bank Information] On [Bank Transaction].[Bank ID]=[Bank Information].[Bank ID]  where [Bank Transaction].[Check No]= '" + TxtSearchCheckNoBank.Text + "'"
                Dim connection As New SqlConnection(connectionString)
                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Bank Transaction")
                connection.Close()
                GrdSearch.DataSource = ds
                GrdSearch.DataMember = "BizPro_Bank Transaction"

                'GrdBankTransaction.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdBankTransaction.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
                GrdSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                con.Close()

                'Total Balance For Electricity Bill
                TotalBalanceForBankTransaction()


            ElseIf CmbBankSearch.SelectedIndex = 2 Then

                Dim connectionString As String = FrmHome.ConnectionString
                Dim sql As String = "SELECT [Bank Transaction].[Bank Transaction ID],[Bank Information].[Bank Name],[Bank Transaction].[Check No],[Bank Transaction].[Remarks],[Bank Transaction].[Transaction Date],[Bank Transaction].[Debited Amount],[Bank Transaction].[Credited Amount] From [Bank Transaction] Join [Bank Information] On [Bank Transaction].[Bank ID] = [Bank Information].[Bank ID] where  [Bank Transaction].[Transaction Date]  between '" + DtpBankFromDate.Value + "'  and '" + DtpBankToDate.Value + "' "
                Dim connection As New SqlConnection(connectionString)
                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Bank Transaction")
                connection.Close()
                GrdSearch.DataSource = ds
                GrdSearch.DataMember = "BizPro_Bank Transaction"

                'GrdBankTransaction.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdBankTransaction.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
                GrdSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                con.Close()

                'Total Balance For Electricity Bill
                TotalBalanceForBankTransaction()


            End If
        Catch ex As Exception
            MessageBox.Show("Error while refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try
        'End Refresh Data


    End Sub


    'Total Stock Count
    Sub TotalProductDetails()


        Dim total1 As String = 0
        For i As Integer = 0 To GrdSearch.RowCount - 1
            total1 += GrdSearch.Rows(i).Cells(10).Value
        Next
        Me.lblTotalStock.Text = total1


        Dim total2 As String = 0
        For i As Integer = 0 To GrdSearch.RowCount - 1
            total2 += (GrdSearch.Rows(i).Cells(8).Value) * (GrdSearch.Rows(i).Cells(10).Value)
        Next
        Me.LblTotalPurchasePrice.Text = total2


        Dim total3 As String = 0
        For i As Integer = 0 To GrdSearch.RowCount - 1
            total3 += (GrdSearch.Rows(i).Cells(9).Value) * (GrdSearch.Rows(i).Cells(10).Value)
        Next
        Me.LblTotalSalePrice.Text = total3


        LblApproximateProfit.Text = Val(LblTotalSalePrice.Text) - Val(LblTotalPurchasePrice.Text)

    End Sub


    'Total Purchase details
    Sub TotalPurchaseDetails()


        Dim total1 As String = 0
        For i As Integer = 0 To GrdSearch.RowCount - 1
            total1 += GrdSearch.Rows(i).Cells(11).Value
        Next
        Me.LblTotalPurchaseAmount.Text = total1


        Dim total2 As String = 0

        total2 = GrdSearch.Rows.Count

        Me.LblTotalPurchaseInvoice.Text = total2

    End Sub

    'Total Sale details
    Sub TotalSaleDetails()


        Dim total1 As String = 0
        Dim total3 As String = 0
        For i As Integer = 0 To GrdSearch.RowCount - 1
            total1 += GrdSearch.Rows(i).Cells(12).Value
            total3 += GrdSearch.Rows(i).Cells(11).Value

        Next
        Me.LblTotalReceivedAmount.Text = total1
        Me.LblTotalSaleAmount.Text = total3




        Dim total2 As String = 0

        total2 = GrdSearch.Rows.Count

        Me.LblTotalSaleInvoice.Text = total2



    End Sub

    'Total Voucher details
    Sub TotalVoucherDetails()


        Dim total1 As String = 0
        For i As Integer = 0 To GrdSearch.RowCount - 1
            total1 += GrdSearch.Rows(i).Cells(8).Value
        Next
        Me.LblPaidAmount.Text = total1


        Dim total2 As String = 0
        For i As Integer = 0 To GrdSearch.RowCount - 1
            total2 += GrdSearch.Rows(i).Cells(9).Value
        Next
        Me.LblReceivedAmount.Text = total2


        Dim total3 As String = 0

        total3 = GrdSearch.Rows.Count

        Me.LblTotalVoucher.Text = total3



    End Sub
    'Total Balance For Electricity Bill

    Sub TotalBalanceForBankTransaction()


        Dim total1 As String = 0
        For i As Integer = 0 To GrdSearch.RowCount - 1
            total1 += Val(GrdSearch.Rows(i).Cells(5).Value)
        Next
        Me.LblTotalPayment.Text = total1



        Dim total2 As String = 0
        For i As Integer = 0 To GrdSearch.RowCount - 1
            total2 += Val(GrdSearch.Rows(i).Cells(6).Value)
        Next
        Me.LblTotalWithdraw.Text = total2


    End Sub


    Private Sub CmbSearchProductGroup_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbSearchProductGroup.KeyDown
        If e.KeyCode = Keys.Enter Then

            FrmListofProductGroups.Show()
            FrmListofProductGroups.TxtSearchGroup.Focus()
            FrmListofProductGroups.Label1.Text = "Search"

        End If
    End Sub

    Private Sub CmbSearchProductGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSearchProductGroup.SelectedIndexChanged

    End Sub

    Private Sub CmbProductCategory_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbSearchProductCategory.KeyDown
        If e.KeyCode = Keys.Enter Then

            FrmListofProductCategories.Show()
            FrmListofProductCategories.TxtSearchCategory.Focus()
            FrmListofProductCategories.Label1.Text = "Search"
        End If
    End Sub

    Private Sub CmbProductCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSearchProductCategory.SelectedIndexChanged

    End Sub

    Private Sub CmbProductSubcategory_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbSearchProductSubcategory.KeyDown
        If e.KeyCode = Keys.Enter Then

            FrmListofProductSubcategories.Show()
            FrmListofProductSubcategories.TxtSearchProductsSubcategories.Focus()
            FrmListofProductSubcategories.Label1.Text = "Search"
        End If
    End Sub

    Private Sub CmbProductSubcategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSearchProductSubcategory.SelectedIndexChanged

    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click

        ' "PRODUCT"
        If CmbSelectSearchBy.SelectedIndex = 0 Then
            'Search Products
            SearchForProduct()

            '"PURCHASE"
        ElseIf CmbSelectSearchBy.SelectedIndex = 1 Then
            'Search Purchase
            SearchForPurchase()

            '"SALE"
        ElseIf CmbSelectSearchBy.SelectedIndex = 2 Then
            'Search Sale
            SearchForSale()

            '"VOUCHER"
        ElseIf CmbSelectSearchBy.SelectedIndex = 3 Then

            'Search Voucher
            SearchForVoucher()


            '"BANK TRANSACTION"
        ElseIf CmbSelectSearchBy.SelectedIndex = 4 Then
            'Search For Bank Transaction
            SearchBankTransaction()
        End If

    End Sub

    Private Sub TxtSearchProductName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearchProductName.TextChanged

        'Search Products
        SearchForProduct()


    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSearchPurchase.SelectedIndexChanged

        'Purchase Invoice No
        If CmbSearchPurchase.SelectedIndex = 0 Then

            TxtSearchPurchaseInvoice.Visible = True


            TxtSearchPurchaseInvoice.Focus()

            'Clear data purchase Details
            ClearDataForPurchaseDetails()


            'All Purchase Records By Date
        ElseIf CmbSearchPurchase.SelectedIndex = 1 Then

            TxtSearchPurchaseInvoice.Visible = False



            'Clear data purchase Details
            ClearDataForPurchaseDetails()


            '"Maximum Purchase Of Products By Date"
        ElseIf CmbSearchPurchase.SelectedIndex = 2 Then

            TxtSearchPurchaseInvoice.Visible = False


            'Clear data purchase Details
            ClearDataForPurchaseDetails()

        End If

    End Sub

    Private Sub TxtSearchPurchaseInvoice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearchPurchaseInvoice.KeyDown

        If e.KeyCode = Keys.Enter Then
            'Search For Purchase
            SearchForPurchase()

        End If

    End Sub

    Private Sub TxtSearchPurchaseInvoice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearchPurchaseInvoice.TextChanged

    End Sub

    Private Sub GrpSale_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrpSale.Enter

    End Sub

    Private Sub CmbSearchBySale_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSearchSale.SelectedIndexChanged

        'Sale Invoice No
        If CmbSearchSale.SelectedIndex = 0 Then

            TxtSearchSaleInvoice.Visible = True
            cmbCustomerCategory.Visible = False

            TxtSearchSaleInvoice.Focus()

            'Clear data Sale Details
            ClearDataForSaleDetails()


            'All Sale Records By Date
        ElseIf CmbSearchSale.SelectedIndex = 1 Then

            TxtSearchSaleInvoice.Visible = False
            cmbCustomerCategory.Visible = False


            'Clear data Sale Details
            ClearDataForSaleDetails()


            'Maximum Sale Of Products By Date
        ElseIf CmbSearchSale.SelectedIndex = 2 Then

            TxtSearchSaleInvoice.Visible = False
            cmbCustomerCategory.Visible = False


            'Clear data Sale Details
            ClearDataForSaleDetails()

            'Customer Category By Date
        ElseIf CmbSearchSale.SelectedIndex = 3 Then

            TxtSearchSaleInvoice.Visible = False
            cmbCustomerCategory.Visible = True


            'Clear data Sale Details
            ClearDataForSaleDetails()

            'Product Sale History
        ElseIf CmbSearchSale.SelectedIndex = 4 Then

            TxtSearchSaleInvoice.Visible = True
            cmbCustomerCategory.Visible = False

            TxtSearchSaleInvoice.Focus()

            'Clear data Sale Details
            ClearDataForSaleDetails()




        End If
    End Sub

    Private Sub CmbSearchVoucher_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSearchVoucher.SelectedIndexChanged
        'Voucher No
        If CmbSearchVoucher.SelectedIndex = 0 Then

            TxtSearchVoucherNo.Visible = True
            CmbSearchVoucherCategory.Visible = False
            CmbSearchVoucherSubcategory.Visible = False
            CmbSearchVoucherPurpose.Visible = False

            TxtSearchVoucherNo.Focus()

            'Clear data Voucher Details
            ClearDataForVoucherDetails()

            'Gridview prvious load Clear code
            GrdSearch.Columns.Clear()

            'Voucher Category By Date
        ElseIf CmbSearchVoucher.SelectedIndex = 1 Then


            TxtSearchVoucherNo.Visible = False
            CmbSearchVoucherCategory.Visible = True
            CmbSearchVoucherSubcategory.Visible = False
            CmbSearchVoucherPurpose.Visible = False

            CmbSearchVoucherCategory.Focus()

            'Clear data Voucher Details
            ClearDataForVoucherDetails()

            'Gridview prvious load Clear code
            GrdSearch.Columns.Clear()

            'Voucher Subcategory By Date
        ElseIf CmbSearchVoucher.SelectedIndex = 2 Then

            TxtSearchVoucherNo.Visible = False
            CmbSearchVoucherCategory.Visible = False
            CmbSearchVoucherSubcategory.Visible = True
            CmbSearchVoucherPurpose.Visible = False

            CmbSearchVoucherSubcategory.Focus()

            'Clear data Voucher Details
            ClearDataForVoucherDetails()

            'Gridview prvious load Clear code
            GrdSearch.Columns.Clear()

            'Voucher Purpose By Date
        ElseIf CmbSearchVoucher.SelectedIndex = 3 Then

            TxtSearchVoucherNo.Visible = False
            CmbSearchVoucherCategory.Visible = False
            CmbSearchVoucherSubcategory.Visible = False
            CmbSearchVoucherPurpose.Visible = True

            CmbSearchVoucherPurpose.Focus()

            'Clear data Voucher Details
            ClearDataForVoucherDetails()

            'Gridview prvious load Clear code
            GrdSearch.Columns.Clear()

            'Total Voucher Details By Date
        ElseIf CmbSearchVoucher.SelectedIndex = 4 Then

            TxtSearchVoucherNo.Visible = False
            CmbSearchVoucherCategory.Visible = False
            CmbSearchVoucherSubcategory.Visible = False
            CmbSearchVoucherPurpose.Visible = False



            'Clear data Voucher Details
            ClearDataForVoucherDetails()

            'Gridview prvious load Clear code
            GrdSearch.Columns.Clear()

            'Voucher Details Group Wise By Date
        ElseIf CmbSearchVoucher.SelectedIndex = 4 Then

            TxtSearchVoucherNo.Visible = False
            CmbSearchVoucherCategory.Visible = False
            CmbSearchVoucherSubcategory.Visible = False
            CmbSearchVoucherPurpose.Visible = False



            'Clear data Voucher Details
            ClearDataForVoucherDetails()

            'Gridview prvious load Clear code
            GrdSearch.Columns.Clear()


        End If
    End Sub

    Private Sub TxtSearchSaleInvoice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearchSaleInvoice.TextChanged

        'Search Sale
        SearchForSale()

    End Sub

    Private Sub CmbBankSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbBankSearch.SelectedIndexChanged

        '"Bank Name"
        If CmbBankSearch.SelectedIndex = 0 Then

            CmbSeachBankNameBank.Visible = True
            TxtSearchCheckNoBank.Visible = False
            CmbSeachBankNameBank.Focus()

            'Sub Celar Data for Bank Transaction
            ClearDataBankTransaction()


            ' "Check No"
        ElseIf CmbBankSearch.SelectedIndex = 1 Then
            CmbSeachBankNameBank.Visible = False
            TxtSearchCheckNoBank.Visible = True
            TxtSearchCheckNoBank.Focus()

            'Sub Celar Data for Bank Transaction
            ClearDataBankTransaction()

            '"All Transaction"
        ElseIf CmbBankSearch.SelectedIndex = 2 Then

            CmbSeachBankNameBank.Visible = False
            TxtSearchCheckNoBank.Visible = False


            'Search For Bank Transaction
            SearchBankTransaction()

        End If
    End Sub

    Private Sub TxtSearchCheckNoBank_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearchCheckNoBank.KeyDown
        If e.KeyCode = Keys.Enter Then

            'Search For Bank Transaction
            SearchBankTransaction()
        End If
    End Sub

    Private Sub TxtSearchCheckNoBank_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearchCheckNoBank.TextChanged

    End Sub
End Class