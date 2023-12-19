Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmListofProducts
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point


    Private Sub FrmListofProducts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        ChangeLanguage()

        'Load ComboBox For Product Group And Category And Sub category
        LoadComboBoxForProductGroupAndCategoryAndSubcategory()

        'Focus on Product Name Text box
        RefreshData()


    End Sub
    'Load ComboBox For Product Group And Category And Sub category
    Sub LoadComboBoxForProductGroupAndCategoryAndSubcategory()


        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = FrmHome.ConnectionString

        Dim strSQL As String = "SELECT [Product Group ID],[Product Group Name] FROM [Product Group]"
        Dim da As New System.Data.SqlClient.SqlDataAdapter(strSQL, con)
        Dim ds As New DataSet
        da.Fill(ds, "[Product Group]")

        With Me.CmbSearchProductGroup
            .DataSource = ds.Tables("[Product Group]")
            .DisplayMember = "Product Group Name"
            .ValueMember = "Product Group ID"

        End With
        con.Close()



        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        con1.ConnectionString = FrmHome.ConnectionString

        Dim strSQL1 As String = "SELECT [Product Category ID],[Product Category Name] FROM [Product Category]"
        Dim da1 As New System.Data.SqlClient.SqlDataAdapter(strSQL1, con1)
        Dim ds1 As New DataSet
        da1.Fill(ds1, "[Product Category]")

        With Me.CmbSearchProductCategory
            .DataSource = ds1.Tables("[Product Category]")
            .DisplayMember = "Product Category Name"
            .ValueMember = "Product Category ID"
        End With
        con1.Close()


        Dim con2 As New SqlConnection
        Dim cmd2 As New SqlCommand
        con2.ConnectionString = FrmHome.ConnectionString

        Dim strSQL2 As String = "SELECT [Product Subcategory ID],[Product Subcategory Name] FROM [Product Subcategory]"
        Dim da2 As New System.Data.SqlClient.SqlDataAdapter(strSQL2, con2)
        Dim ds2 As New DataSet
        da2.Fill(ds2, "[Product Subcategory]")

        With Me.CmbSearchProductSubcategory
            .DataSource = ds2.Tables("[Product Subcategory]")
            .DisplayMember = "Product Subcategory Name"
            .ValueMember = "Product Subcategory ID"

        End With
        con2.Close()
        'Clear textbox and combobox data
        ClearData()


    End Sub
    Sub ClearData()

        CmbSearchProductSubcategory.SelectedValue = 0
        CmbSearchProductCategory.SelectedValue = 0
        CmbSearchProductGroup.SelectedValue = 0
        TxtSearchProductName.Text = ""
        TxtSearchProductName.Focus()
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
            If dr.HasRows Then

                Me.TxtSearchProductName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))


                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)



                'MsgBox(dr.Item("Language Font"))

                Me.GrdListofProducts.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdListofProducts.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)
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



    Sub RefreshData()
        Try
            ' Load Data
          

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT Products.[Product ID],Products.[Product Name],[Product Category].[Product Category Name], [Product Group].[Product Group Name],[Product SubCategory].[Product SubCategory Name],Products.[Purchase Price],Products.[Sale Price] FROM [Products] Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID] Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID] Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID]"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Products")
            connection.Close()
            GrdListofProducts.DataSource = ds
            GrdListofProducts.DataMember = "BizPro_Products"

            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdListofProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            'End Refresh Data
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally

        End Try

    End Sub

    Private Sub TxtSearchProductName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearchProductName.KeyDown


        If e.KeyCode = Keys.Down Then
            GrdListofProducts.Focus()

        ElseIf e.KeyCode = Keys.F2 Then

            'Clear textbox and combobox data
            ClearData()

        End If


        'Enter on Focus Grid view and Enter Grid View code
        If e.KeyCode = Keys.Enter Then


            'Data Grid view code
            Try

                Dim i As Integer
                i = GrdListofProducts.CurrentRow.Index
                If Label1.Text = "Purchase" Then
                    FrmPurchase.CmbProductName.ValueMember = GrdListofProducts.Item(0, i).Value
                    FrmPurchase.CmbProductName.Text = GrdListofProducts.Item(1, i).Value
                    FrmPurchase.TxtPurchaseUnitCost.Text = GrdListofProducts.Item(5, i).Value
                    FrmPurchase.TxtWarrantyDays.Text = "00"
                    FrmPurchase.CmbLocationID.Focus()
                    FrmPurchase.FindPurchaseIDToShowInLableWhileSelectingNewProduct()



                    'Privet sub for Search Purchase Price on supplier
                    FrmPurchase.SearchPurchasePriceFromSupplier()

                    Me.Close()
                ElseIf Label1.Text = "Supplier Information" Then


                    FrmSupplierInformation.CmbProductID.ValueMember = GrdListofProducts.Item(0, i).Value
                    FrmSupplierInformation.CmbProductID.Text = GrdListofProducts.Item(1, i).Value
                    FrmSupplierInformation.TxtPrice.Focus()
                    Me.Close()
                ElseIf Label1.Text = "Customer Information" Then


                    FrmCustomerInformation.CmbProductID.ValueMember = GrdListofProducts.Item(0, i).Value
                    FrmCustomerInformation.CmbProductID.Text = GrdListofProducts.Item(1, i).Value
                    FrmCustomerInformation.TxtPrice.Focus()
                    Me.Close()

                ElseIf Label1.Text = "Supplier Information Search" Then


                    FrmSupplierInformation.CmbSearchProductPrice.ValueMember = GrdListofProducts.Item(0, i).Value
                    FrmSupplierInformation.CmbSearchProductPrice.Text = GrdListofProducts.Item(1, i).Value
                    FrmSupplierInformation.SearchProductPriceBySupplier()
                    Me.Close()

                ElseIf Label1.Text = "Customer Information Search" Then


                    FrmCustomerInformation.CmbSearchProductPrice.ValueMember = GrdListofProducts.Item(0, i).Value
                    FrmCustomerInformation.CmbSearchProductPrice.Text = GrdListofProducts.Item(1, i).Value
                    FrmCustomerInformation.SearchProductPriceByCustomer()
                    Me.Close()

                ElseIf Label1.Text = "Warranty Look Up" Then

                    FrmWarrantyLookUp.cmbProductName.ValueMember = GrdListofProducts.Item(0, i).Value
                    FrmWarrantyLookUp.cmbProductName.Text = GrdListofProducts.Item(1, i).Value
                    FrmWarrantyLookUp.TxtSerialNumber.Focus()
                    Me.Close()

                ElseIf Label1.Text = "Quotation" Then

                    FrmQuotation.cmbProductName.ValueMember = GrdListofProducts.Item(0, i).Value
                    FrmQuotation.cmbProductName.Text = GrdListofProducts.Item(1, i).Value
                    'FrmQuotation.TxtPurchaseID.Text = GrdListofProducts.Item(1, i).Value
                    FrmQuotation.TxtQuotationUnitPrice.Text = GrdListofProducts.Item(6, i).Value
                    'FrmQuotation.lblQuantity.Text = GrdListofProducts.Item(8, i).Value
                    FrmQuotation.TxtQuantity.Focus()
                    Me.Close()

                ElseIf Label1.Text = "Product Life Cycle" Then

                    FrmProductLifeCycle.cmbProductName.ValueMember = GrdListofProducts.Item(0, i).Value
                    FrmProductLifeCycle.cmbProductName.Text = GrdListofProducts.Item(1, i).Value
                    FrmProductLifeCycle.BtnSearch.PerformClick()
                    Me.Close()

                End If
            Catch ex As Exception
                MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

            End Try

        End If




    End Sub

    


    Private Sub TxtSearchProductName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearchProductName.TextChanged
        If CmbSearchProductGroup.Text = "" And CmbSearchProductCategory.Text = "" And CmbSearchProductSubcategory.Text = "" Then

            'Search Only Product Name()
            SearchbyProductname()

        Else

            'Search Product Name By Group ,Category And SubCategory()
            SearchbyProductnameGroupAndCategoryAndSubcategory()

        End If

    End Sub
    'Search by Product name()
    Sub SearchbyProductname()
        ' Load Data
        Try
            


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT Products.[Product ID],Products.[Product Name],[Product Category].[Product Category Name], [Product Group].[Product Group Name],[Product SubCategory].[Product SubCategory Name],Products.[Purchase Price],Products.[Sale Price] FROM [Products] Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID] Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID] Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID]  WHERE (products.[Product Name] LIKE '%" + Me.TxtSearchProductName.Text + "%')"


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Products")
            connection.Close()
            GrdListofProducts.DataSource = ds
            GrdListofProducts.DataMember = "BizPro_Products"


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)



        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records")
        Finally

        End Try

        'End Refresh Data
    End Sub

    'Search by Product name Group And Category And Subcategory()
    Sub SearchbyProductnameGroupAndCategoryAndSubcategory()
        ' Load Data
        Try
           


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT Products.[Product ID],Products.[Product Name],[Product Category].[Product Category Name], [Product Group].[Product Group Name],[Product SubCategory].[Product SubCategory Name],Products.[Purchase Price],Products.[Sale Price] FROM [Products] Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID] Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID] Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID]  WHERE ([Product Group]. [Product Group ID] =  '" + Me.CmbSearchProductGroup.SelectedValue.ToString + "' And [Product Category].[Product Category ID] =  '" + Me.CmbSearchProductCategory.SelectedValue.ToString + "' And [Product Subcategory].[Product Subcategory ID] =  '" + Me.CmbSearchProductSubcategory.SelectedValue.ToString + "' And products.[Product Name] LIKE '%" + Me.TxtSearchProductName.Text + "%')"


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Products")
            connection.Close()
            GrdListofProducts.DataSource = ds
            GrdListofProducts.DataMember = "BizPro_Products"


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)


        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Searchby Product name Group And Category And Subcategory")
        Finally

        End Try

        'End Refresh Data
    End Sub
    'Search by Product Group 
    Sub SearchbyProductGroup()
        ' Load Data
        Try
            

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT Products.[Product ID],Products.[Product Name],[Product Category].[Product Category Name], [Product Group].[Product Group Name],[Product SubCategory].[Product SubCategory Name],Products.[Purchase Price],Products.[Sale Price] FROM [Products] Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID] Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID] Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID]  WHERE ([Product Group]. [Product Group ID] =  '" + Me.CmbSearchProductGroup.SelectedValue.ToString + "' )"


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Products")
            connection.Close()
            GrdListofProducts.DataSource = ds
            GrdListofProducts.DataMember = "BizPro_Products"


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)


        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Search Group ")
        Finally

        End Try

        'End Refresh Data
    End Sub
    'Search by Product Category ()
    Sub SearchbyProductCategory()
        ' Load Data
        Try
           
            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT Products.[Product ID],Products.[Product Name],[Product Category].[Product Category Name], [Product Group].[Product Group Name],[Product SubCategory].[Product SubCategory Name],Products.[Purchase Price],Products.[Sale Price] FROM [Products] Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID] Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID] Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID]  WHERE ( [Product Group]. [Product Group ID] =  '" + Me.CmbSearchProductGroup.SelectedValue.ToString + "' And [Product Category].[Product Category ID] =  '" + Me.CmbSearchProductCategory.SelectedValue.ToString + "' )"


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Products")
            connection.Close()
            GrdListofProducts.DataSource = ds
            GrdListofProducts.DataMember = "BizPro_Products"


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)


        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Search Category")
        Finally

        End Try

        'End Refresh Data
    End Sub
    'Search by Product Subcategory()
    Sub SearchbyProductSubcategory()
        ' Load Data
        Try
            
            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT Products.[Product ID],Products.[Product Name],[Product Category].[Product Category Name], [Product Group].[Product Group Name],[Product SubCategory].[Product SubCategory Name],Products.[Purchase Price],Products.[Sale Price] FROM [Products] Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID] Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID] Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID]  WHERE ([Product Group]. [Product Group ID] =  '" + Me.CmbSearchProductGroup.SelectedValue.ToString + "' And [Product Category].[Product Category ID] =  '" + Me.CmbSearchProductCategory.SelectedValue.ToString + "' And [Product Subcategory].[Product Subcategory ID] =  '" + Me.CmbSearchProductSubcategory.SelectedValue.ToString + "')"


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Products")
            connection.Close()
            GrdListofProducts.DataSource = ds
            GrdListofProducts.DataMember = "BizPro_Products"


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)



        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Search Subcategory")
        Finally

        End Try

        'End Refresh Data
    End Sub

    Private Sub GrdListofProducts_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdListofProducts_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)




    End Sub

    Private Sub GrdListofProducts_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)





    End Sub

    Private Sub GrdListofProducts_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub CmbSearchProductGroup_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbSearchProductGroup.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.Text = "" Then
                CmbSearchProductCategory.Focus()


            Else
                'Search by Product Group()
                SearchbyProductGroup()

                CmbSearchProductCategory.Focus()
            End If
        End If
    End Sub

    Private Sub CmbSearchProductGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSearchProductGroup.SelectedIndexChanged

    End Sub

    Private Sub CmbSearchProductGroup_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbSearchProductGroup.SelectedValueChanged

    End Sub

    Private Sub CmbSearchProductCategory_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbSearchProductCategory.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.Text = "" Then
                CmbSearchProductSubcategory.Focus()

            Else
                'Search by Product Category()
                SearchbyProductCategory()

                CmbSearchProductSubcategory.Focus()
            End If
        End If
    End Sub

    Private Sub CmbSearchProductCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSearchProductCategory.SelectedIndexChanged

    End Sub

    Private Sub CmbSearchProductCategory_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbSearchProductCategory.SelectedValueChanged

    End Sub

    Private Sub CmbSearchProductSubcategory_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbSearchProductSubcategory.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.Text = "" Then
                TxtSearchProductName.Focus()


            Else
                'Search by Product Subcategory()
                SearchbyProductSubcategory()

                TxtSearchProductName.Focus()
            End If
        End If
    End Sub

    Private Sub CmbSearchProductSubcategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSearchProductSubcategory.SelectedIndexChanged

    End Sub

    Private Sub CmbSearchProductSubcategory_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbSearchProductSubcategory.SelectedValueChanged


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

    Private Sub GrdListofProducts_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdListofProducts.CellContentClick

    End Sub

    Private Sub GrdListofProducts_CellFormatting1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles GrdListofProducts.CellFormatting

        'permission for update and Delete
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


                If GrdListofProducts.Columns(e.ColumnIndex).Name.Equals("Purchase Price") Then

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

    Private Sub GrdListofProducts_CellMouseDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdListofProducts.CellMouseDoubleClick
        'Data Grid view code
        Try

            Dim i As Integer
            i = GrdListofProducts.CurrentRow.Index


            If Label1.Text = "Purchase" Then
                FrmPurchase.CmbProductName.ValueMember = GrdListofProducts.Item(0, i).Value
                FrmPurchase.CmbProductName.Text = GrdListofProducts.Item(1, i).Value
                FrmPurchase.TxtPurchaseUnitCost.Text = GrdListofProducts.Item(5, i).Value
                FrmPurchase.TxtWarrantyDays.Text = "00"

                FrmPurchase.CmbLocationID.Focus()
                FrmPurchase.FindPurchaseIDToShowInLableWhileSelectingNewProduct()

                'Privet sub for Search Purchase Price on supplier
                FrmPurchase.SearchPurchasePriceFromSupplier()

                Me.Close()

            ElseIf Label1.Text = "Supplier Information" Then


                FrmSupplierInformation.CmbProductID.ValueMember = GrdListofProducts.Item(0, i).Value
                FrmSupplierInformation.CmbProductID.Text = GrdListofProducts.Item(1, i).Value
                FrmSupplierInformation.TxtPrice.Focus()
                Me.Close()
            ElseIf Label1.Text = "Customer Information" Then


                FrmCustomerInformation.CmbProductID.ValueMember = GrdListofProducts.Item(0, i).Value
                FrmCustomerInformation.CmbProductID.Text = GrdListofProducts.Item(1, i).Value
                FrmCustomerInformation.TxtPrice.Focus()
                Me.Close()
            ElseIf Label1.Text = "Supplier Information Search" Then


                FrmSupplierInformation.CmbSearchProductPrice.ValueMember = GrdListofProducts.Item(0, i).Value
                FrmSupplierInformation.CmbSearchProductPrice.Text = GrdListofProducts.Item(1, i).Value
                FrmSupplierInformation.SearchProductPriceBySupplier()
                Me.Close()

            ElseIf Label1.Text = "Customer Information Search" Then


                FrmCustomerInformation.CmbSearchProductPrice.ValueMember = GrdListofProducts.Item(0, i).Value
                FrmCustomerInformation.CmbSearchProductPrice.Text = GrdListofProducts.Item(1, i).Value
                FrmCustomerInformation.SearchProductPriceByCustomer()
                Me.Close()
            ElseIf Label1.Text = "Warranty Look Up" Then

                FrmWarrantyLookUp.cmbProductName.ValueMember = GrdListofProducts.Item(0, i).Value
                FrmWarrantyLookUp.cmbProductName.Text = GrdListofProducts.Item(1, i).Value
                FrmWarrantyLookUp.TxtSerialNumber.Focus()
                Me.Close()


            ElseIf Label1.Text = "Quotation" Then

                FrmQuotation.cmbProductName.ValueMember = GrdListofProducts.Item(0, i).Value
                FrmQuotation.cmbProductName.Text = GrdListofProducts.Item(1, i).Value
                'FrmQuotation.TxtPurchaseID.Text = GrdListofProducts.Item(1, i).Value
                FrmQuotation.TxtQuotationUnitPrice.Text = GrdListofProducts.Item(6, i).Value
                'FrmQuotation.lblQuantity.Text = GrdListofProducts.Item(8, i).Value
                FrmQuotation.TxtQuantity.Focus()
                Me.Close()


            ElseIf Label1.Text = "Product Life Cycle" Then

                FrmProductLifeCycle.cmbProductName.ValueMember = GrdListofProducts.Item(0, i).Value
                FrmProductLifeCycle.cmbProductName.Text = GrdListofProducts.Item(1, i).Value
                FrmProductLifeCycle.BtnSearch.PerformClick()
                Me.Close()


            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

        End Try
    End Sub

    Private Sub GrdListofProducts_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdListofProducts.KeyDown
        If e.KeyCode = Keys.Enter Then


            'Data Grid view code
            Try

                Dim i As Integer
                i = GrdListofProducts.CurrentRow.Index

                If Label1.Text = "Purchase" Then
                    FrmPurchase.CmbProductName.ValueMember = GrdListofProducts.Item(0, i).Value
                    FrmPurchase.CmbProductName.Text = GrdListofProducts.Item(1, i).Value
                    FrmPurchase.TxtPurchaseUnitCost.Text = GrdListofProducts.Item(5, i).Value
                    FrmPurchase.TxtWarrantyDays.Text = "00"

                    FrmPurchase.CmbLocationID.Focus()
                    FrmPurchase.FindPurchaseIDToShowInLableWhileSelectingNewProduct()
                    'Privet sub for Search Purchase Price on supplier
                    FrmPurchase.SearchPurchasePriceFromSupplier()

                    Me.Close()

                ElseIf Label1.Text = "Supplier Information" Then


                    FrmSupplierInformation.CmbProductID.ValueMember = GrdListofProducts.Item(0, i).Value
                    FrmSupplierInformation.CmbProductID.Text = GrdListofProducts.Item(1, i).Value
                    FrmSupplierInformation.TxtPrice.Focus()
                    Me.Close()
                ElseIf Label1.Text = "Customer Information" Then


                    FrmCustomerInformation.CmbProductID.ValueMember = GrdListofProducts.Item(0, i).Value
                    FrmCustomerInformation.CmbProductID.Text = GrdListofProducts.Item(1, i).Value
                    FrmCustomerInformation.TxtPrice.Focus()
                    Me.Close()
                ElseIf Label1.Text = "Supplier Information Search" Then


                    FrmSupplierInformation.CmbSearchProductPrice.ValueMember = GrdListofProducts.Item(0, i).Value
                    FrmSupplierInformation.CmbSearchProductPrice.Text = GrdListofProducts.Item(1, i).Value
                    FrmSupplierInformation.SearchProductPriceBySupplier()
                    Me.Close()

                ElseIf Label1.Text = "Customer Information Search" Then


                    FrmCustomerInformation.CmbSearchProductPrice.ValueMember = GrdListofProducts.Item(0, i).Value
                    FrmCustomerInformation.CmbSearchProductPrice.Text = GrdListofProducts.Item(1, i).Value
                    FrmCustomerInformation.SearchProductPriceByCustomer()
                    Me.Close()

                ElseIf Label1.Text = "Warranty Look Up" Then

                    FrmWarrantyLookUp.cmbProductName.ValueMember = GrdListofProducts.Item(0, i).Value
                    FrmWarrantyLookUp.cmbProductName.Text = GrdListofProducts.Item(1, i).Value
                    FrmWarrantyLookUp.TxtSerialNumber.Focus()
                    Me.Close()

                ElseIf Label1.Text = "Quotation" Then

                    FrmQuotation.cmbProductName.ValueMember = GrdListofProducts.Item(0, i).Value
                    FrmQuotation.cmbProductName.Text = GrdListofProducts.Item(1, i).Value
                    'FrmQuotation.TxtPurchaseID.Text = GrdListofProducts.Item(1, i).Value
                    FrmQuotation.TxtQuotationUnitPrice.Text = GrdListofProducts.Item(6, i).Value
                    'FrmQuotation.lblQuantity.Text = GrdListofProducts.Item(8, i).Value
                    FrmQuotation.TxtQuantity.Focus()
                    Me.Close()


                ElseIf Label1.Text = "Product Life Cycle" Then

                    FrmProductLifeCycle.cmbProductName.ValueMember = GrdListofProducts.Item(0, i).Value
                    FrmProductLifeCycle.cmbProductName.Text = GrdListofProducts.Item(1, i).Value
                    FrmProductLifeCycle.BtnSearch.PerformClick()
                    Me.Close()

                End If

            Catch ex As Exception
                MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

            End Try

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

    Private Sub PnlListofProducts_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PnlListofProducts.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= (X)
            newpoint.Y -= (Y)
            Me.Location = newpoint

        End If
    End Sub

    Private Sub PnlListofProducts_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PnlListofProducts.Paint

    End Sub
End Class