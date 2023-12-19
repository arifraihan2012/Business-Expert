
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO


Public Class FrmListOfProductStock
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point

    Private Sub FrmListOfProductStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'Change Language
        ChangeLanguage()

        'Load ComboBox For Product Group And Category And Sub category
        LoadComboBoxForProductGroupAndCategoryAndSubcategory()

        'Making  Clear
        ClearData()


        ' If RdbCurrentBranch.Checked = True Then
        'Refresh Data For Current Branch
        'RefreshDataForCurrentBranch()
        'Else
        'Refresh Data For All Branch
        'RefreshDataForAllBranch()

        'End If


        RdbCurrentBranch.Checked = True

    End Sub

    'Making  Clear
    Sub ClearData()
        CmbSearchProductCategory.SelectedValue = 0
        CmbSearchProductSubcategory.SelectedValue = 0
        CmbSearchProductGroup.SelectedValue = 0
        TxtsearchProduct.Text = ""

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


                Me.TxtsearchProduct.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.CmbSearchProductSubcategory.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.CmbSearchProductGroup.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.CmbSearchProductCategory.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))

                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)



                Me.GrdStockInformation.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdStockInformation.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)



                'MsgBox(dr.Item("Language Font"))
            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while changing language record on table..." & ex.Message, "Change Language")
        Finally

        End Try

        'End Language

    End Sub

    'Refresh Data For Current Branch
    Sub RefreshDataForCurrentBranch()
        Try

            ' Load Data
           

            Dim connectionString As String = FrmHome.ConnectionString
            'Dim sql As String = "SELECT * FROM [Stock Information]"

            Dim sql As String = _
           "select top 10 [Purchase Date],[Purchase ID],[Supplier Name],[Product ID],[Product Name],[Branch Name],[Purchase Cost],[Sale Price],(isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))[Stock Available]From (select [Purchase].[Purchase Date],Purchase.[Purchase ID],[Supplier Information].[Supplier Name],[Products].[Product ID],[Products].[Product Name],[Branch Information].[Branch Name],[Branch Information].[Branch ID],Purchase.[Purchase Unit Cost][Purchase Cost],[Products].[Sale Price],case when [Purchase Quantity] =0  then (select isnull(sum( [Added Quantity]),0)[Added Quantity] from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  [Product Transfer].[Purchase ID]=Purchase.[Purchase ID] and [Product Transfer].Status='Added' and   [Product Transfer Invoice].Status='Complete'  and [Product Transfer].[Product ID]=Purchase.[Product ID]  group by [Purchase ID] )  ELSE isnull([Purchase].[Purchase Quantity],0) end [Purchase] ,(select isnull(sum([Sale Quantity]),0)      from  sale join [Sale Invoice] on sale.[Sale Invoice No]= [Sale Invoice].[Sale Invoice No] where Sale.[Branch ID]='" + FrmHome.lblBranchID.Text + "' and Sale.[Purchase ID]=Purchase.[Purchase ID]  group by [Purchase ID])[Sale],(select isnull(sum([Returned Quantity]),0)  from [Sale Return] join [Sale Return Invoice] on [Sale Return].[Sale Return Invoice No]=[Sale Return Invoice].[Sale Return Invoice No] where  [Sale Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Sale Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Sale Return],(select isnull(sum([Returned Quantity]),0)  from [Purchase Return] join [Purchase Return Invoice] on [Purchase Return].[Purchase Return Invoice No]=[Purchase Return Invoice].[Purchase Return Invoice No] where [Purchase Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Purchase Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Purchase Return], (select isnull(sum([Deducted Quantity]),0)  from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  Purchase.[Purchase ID]=[Product Transfer].[Purchase ID] and [Product Transfer].Status='Deducted'     group by [Purchase ID] )[Deducted]from Purchase  join Products on Purchase.[Product ID]=products.[Product ID]  join [Branch Information] on [Purchase].[Branch ID]=[Branch Information].[Branch ID]	  Join [Purchase Invoice] on [Purchase Invoice].[Purchase Invoice No]=[Purchase].[Purchase Invoice No] join [Supplier Information] on [Purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID] Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID]  Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID]  Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID]   where Purchase.[Branch ID]='" + FrmHome.lblBranchID.Text + "') as a  group by [Purchase Date],[Purchase ID],[Supplier Name],[Branch Name],[Product ID],[Product Name],[Purchase Cost],[Sale Price] having (isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))>0"



            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Purchase")
            connection.Close()
            GrdStockInformation.DataSource = ds
            GrdStockInformation.DataMember = "BizPro_Purchase"





            'GrdStockInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdStockInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdStockInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells


            'End Refresh Data
        Catch ex As Exception
            MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Records")
        Finally

        End Try

    End Sub
    'Refresh Data For All Branch
    Sub RefreshDataForAllBranch()
        Try

            ' Load Data
           

            Dim connectionString As String = FrmHome.ConnectionString
            'Dim sql As String = "SELECT * FROM [Stock Information]"

            Dim sql As String = _
           "select top 10 [Purchase Date],[Purchase ID],[Supplier Name],[Product ID],[Product Name],[Branch Name],[Purchase Cost],[Sale Price],(isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))[Stock Available] from ( select [Purchase].[Purchase Date],Purchase.[Purchase ID],[Supplier Information].[Supplier Name],[Products].[Product ID],[Products].[Product Name],[Branch Information].[Branch Name],[Branch Information].[Branch ID],Purchase.[Purchase Unit Cost][Purchase Cost],[Products].[Sale Price], case when [Purchase Quantity] =0  then  (select isnull(sum( [Added Quantity]),0)[Added Quantity] from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where  [Product Transfer].[Purchase ID]=Purchase.[Purchase ID] and [Product Transfer].Status='Added' and   [Product Transfer Invoice].Status='Complete'  and [Product Transfer].[Product ID]=Purchase.[Product ID]  group by [Purchase ID] )   ELSE isnull([Purchase].[Purchase Quantity],0) end [Purchase] , (select isnull(sum([Sale Quantity]),0)      from  sale join [Sale Invoice] on sale.[Sale Invoice No]= [Sale Invoice].[Sale Invoice No] where  Sale.[Purchase ID]=Purchase.[Purchase ID]  group by [Purchase ID])[Sale], (select isnull(sum([Returned Quantity]),0)  from [Sale Return] join [Sale Return Invoice] on [Sale Return].[Sale Return Invoice No]=[Sale Return Invoice].[Sale Return Invoice No] where   [Sale Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Sale Return],(select isnull(sum([Returned Quantity]),0)  from [Purchase Return] join [Purchase Return Invoice] on [Purchase Return].[Purchase Return Invoice No]=[Purchase Return Invoice].[Purchase Return Invoice No] where  [Purchase Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Purchase Return], (select isnull(sum([Deducted Quantity]),0)  from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where  Purchase.[Purchase ID]=[Product Transfer].[Purchase ID] and [Product Transfer].Status='Deducted'     group by [Purchase ID] )[Deducted] from Purchase  join Products on Purchase.[Product ID]=products.[Product ID]  join [Branch Information] on [Purchase].[Branch ID]=[Branch Information].[Branch ID]	   Join [Purchase Invoice] on [Purchase Invoice].[Purchase Invoice No]=[Purchase].[Purchase Invoice No]  join [Supplier Information] on [Purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID]  Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID]  Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID]   Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID]    ) as a  group by [Purchase Date],[Purchase ID],[Supplier Name],[Branch Name],[Product ID],[Product Name],[Purchase Cost],[Sale Price] having (isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))>0"



            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Purchase")
            connection.Close()
            GrdStockInformation.DataSource = ds
            GrdStockInformation.DataMember = "BizPro_Purchase"





            'GrdStockInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdStockInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdStockInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells


            'End Refresh Data
        Catch ex As Exception
            MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Records")
        Finally

        End Try

    End Sub


    'Privet sub for Search SalePrice on Customer
    Sub SearchSalePriceFromCustomerForChalan()


        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        con.ConnectionString = FrmHome.ConnectionString
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT  *FROM [Customer price list]  WHERE [Product ID] = '" + FrmChalan.cmbProductName.ValueMember + "' and [Customer ID]= '" + FrmChalan.CmbCustomerName.ValueMember + "' "

        dr = cmd.ExecuteReader()
        dr.Read()

        If dr.HasRows Then

            FrmChalan.TxtChalanUnitPrice.Text = (dr.Item("Price").ToString)

        End If

        dr.Close()
        con.Close()

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
            cmd.CommandText = "SELECT  *FROM [Purchase]  WHERE [Purchase ID] = '" + FrmSale.TxtPurchaseID.Text + "' and [Product ID]= '" + FrmSale.cmbProductName.ValueMember + "' "

            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                FrmSale.TxtWarrantyDays.Text = (dr.Item("Warranty Days").ToString)

            End If

            dr.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub GrdStockInformation_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)

        'permission for update and Delete
        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand
            Dim dr As SqlDataReader
            Dim dr1 As SqlDataReader




            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd1.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + FrmHome.LblUserID.Text + "' AND [Category Name] = 'VIEW PRICE PERMISSION' And [Update Delete Permission]='YES'"
            cmd1.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + FrmHome.LblUserID.Text + "' AND [Category Name] = 'VIEW SUPPLIER PERMISSION' And [Update Delete Permission]='YES'"

            'Dr for show or hide Price
            dr = cmd.ExecuteReader()
            dr.Read()

            If Not dr.HasRows Then


                If GrdStockInformation.Columns(e.ColumnIndex).Name.Equals("Purchase Cost") Then

                    If (Not e.Value Is Nothing) Then
                        e.Value = New String(CChar("*"), e.Value.ToString.Length)



                    End If

                End If



            End If
            dr.Close()

            'Dr for show or hide supplier name
            dr1 = cmd1.ExecuteReader()
            dr1.Read()

            If Not dr1.HasRows Then


                If GrdStockInformation.Columns(e.ColumnIndex).Name.Equals("Supplier Name") Then

                    If (Not e.Value Is Nothing) Then
                        e.Value = New String(CChar("*"), e.Value.ToString.Length)



                    End If

                End If



            End If
            dr1.Close()
            con.Close()




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub



    Private Sub GrdStockInformation_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

    End Sub

  

   

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtsearchProduct.KeyDown
        If e.KeyCode = Keys.Down Then
            GrdStockInformation.Focus()

        ElseIf e.KeyCode = Keys.F2 Then

            ClearData()

        End If


        'Enter on Focus Grid view and Enter Grid View code
        If e.KeyCode = Keys.Enter Then


            'Data Grid view code
            Try

                Dim i As Integer
                i = GrdStockInformation.CurrentRow.Index

                If RdbCurrentBranch.Checked = True Then


                    If Label1.Text = "Sale" Then
                        FrmSale.cmbProductName.ValueMember = GrdStockInformation.Item(3, i).Value
                        FrmSale.cmbProductName.Text = GrdStockInformation.Item(4, i).Value


                        FrmSale.TxtPurchaseID.Text = GrdStockInformation.Item(1, i).Value

                        FrmSale.TxtSaleUnitPrice.Text = GrdStockInformation.Item(7, i).Value

                        'show available quantity in sale
                        FrmSale.ShowQuantityInLable()


                        FrmSale.TxtQuantity.Focus()

                        'Search Whole Sale Price From Product Information
                        FrmSale.SearchWholeSalePriceFromProductInformation()

                        'Privet sub for Search SalePrice on Customer
                        FrmSale.SearchSalePriceFromCustomerForSale()

                        'Search Available Serial Number or not
                        FrmSale.SearchSerialStatus()

                        'Search Warranty Days
                        SearchWarrantyDays()

                        'Serial Number Show if available
                        ' FrmSale.LoadComboBoxforSerialNumber()

                        'Find Sale ID To Show In Lable
                        FrmSale.FindSaleIDToShowInLableWhileSelectingNewProduct()

                        'Find Total Stock Available of this product and send it to variable
                        'FrmSale.FindTotalQuantityOfSelectedProduct()

                        'Find Last Sold Product Price
                        FrmSale.FindLastSoldProductPrice()

                        Me.Close()

                    ElseIf Label1.Text = "Chalan" Then
                        FrmChalan.cmbProductName.ValueMember = GrdStockInformation.Item(3, i).Value
                        FrmChalan.cmbProductName.Text = GrdStockInformation.Item(4, i).Value


                        FrmChalan.TxtPurchaseID.Text = GrdStockInformation.Item(1, i).Value

                        FrmChalan.TxtChalanUnitPrice.Text = GrdStockInformation.Item(7, i).Value
                        FrmChalan.lblQuantity.Text = GrdStockInformation.Item(8, i).Value

                        FrmChalan.TxtQuantity.Focus()

                        'Privet sub for Search SalePrice on Customer
                        SearchSalePriceFromCustomerForChalan()

                        Me.Close()

                    ElseIf Label1.Text = "Product Transfer" Then


                        FrmProductTransfer.cmbProductName.ValueMember = GrdStockInformation.Item(3, i).Value
                        FrmProductTransfer.cmbProductName.Text = GrdStockInformation.Item(4, i).Value

                        FrmProductTransfer.TxtPurchaseID.Text = GrdStockInformation.Item(1, i).Value
                        FrmProductTransfer.lblQuantity.Text = GrdStockInformation.Item(8, i).Value
                        FrmProductTransfer.PurchaseUnitCost = GrdStockInformation.Item(6, i).Value
                        FrmProductTransfer.LoadComboBoxforSerialNumber()

                        FrmProductTransfer.TxtQuantity.Focus()
                        FrmProductTransfer.SearchSerialStatus()
                        FrmProductTransfer.SearchWarrantyDays()
                        FrmProductTransfer.SearchPurchaseInvoiceNoForPurchaseReturn()
                        FrmProductTransfer.ShowQuantityInLable()


                        'Find Transfer ID To Show In Lable While Selecting New Product
                        'FrmProductTransfer.FindTransferIDToShowInLableWhileSelectingNewProduct()

                        Me.Close()

                    End If
                Else
                    MsgBox("Please Select Current Branch", MsgBoxStyle.OkOnly, "Product Stock")
                End If


            Catch ex As Exception
                MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

            End Try

        End If
    End Sub

    Private Sub TxtsearchProduct_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtsearchProduct.KeyPress

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtsearchProduct.TextChanged

        If CmbSearchProductGroup.Text = "" And CmbSearchProductCategory.Text = "" And CmbSearchProductSubcategory.Text = "" Then
            If Not TxtsearchProduct.Text = "" Then
                If RdbCurrentBranch.Checked = True Then

                    'Search By Product Name For Current Branch()
                    SearchByProductNameForCurrentBranch()
                ElseIf RdbAllBranch.Checked = True Then

                    'Search By Product Name For All Branch()
                    SearchByProductNameForAllBranch()



                End If
            ElseIf TxtsearchProduct.Text = "" Then
                GrdStockInformation.Columns.Clear()
            End If




        Else

            If Not TxtsearchProduct.Text = "" Then


                If RdbCurrentBranch.Checked = True Then

                    'Search Product Name By Group Category And SubCategory And Product Name For Current Branch
                    SearchProductNameByGroupCategoryAndSubCategoryAndProductNameForCurrentBranch()
                Else
                    'Search Product Name By Group Category And SubCategory And Product Name For All Branch
                    SearchProductNameByGroupCategoryAndSubCategoryndProductNameForAllBranch()

                End If
            ElseIf TxtsearchProduct.Text = "" Then
                GrdStockInformation.Columns.Clear()
            End If
        End If
    End Sub

    'Search Product Name By Group Category And SubCategory And Product Name For Current Branch
    Sub SearchProductNameByGroupCategoryAndSubCategoryAndProductNameForCurrentBranch()
        ' Load Data
        Try
        


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select top 10 [Purchase Date],[Purchase ID],[Supplier Name],[Product ID],[Product Name],[Branch Name],[Purchase Cost],[Sale Price],(isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))[Stock Available]from (select [Purchase].[Purchase Date],Purchase.[Purchase ID],[Supplier Information].[Supplier Name],[Products].[Product ID],[Products].[Product Name],[Branch Information].[Branch Name],[Branch Information].[Branch ID],Purchase.[Purchase Unit Cost][Purchase Cost],[Products].[Sale Price],case when [Purchase Quantity] =0  then (select isnull(sum( [Added Quantity]),0)[Added Quantity] from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  [Product Transfer].[Purchase ID]=Purchase.[Purchase ID] and [Product Transfer].Status='Added' and   [Product Transfer Invoice].Status='Complete'  and [Product Transfer].[Product ID]=Purchase.[Product ID]  group by [Purchase ID] )  ELSE isnull([Purchase].[Purchase Quantity],0) end [Purchase] ,(select isnull(sum([Sale Quantity]),0)      from  sale join [Sale Invoice] on sale.[Sale Invoice No]= [Sale Invoice].[Sale Invoice No] where Sale.[Branch ID]='" + FrmHome.lblBranchID.Text + "' and Sale.[Purchase ID]=Purchase.[Purchase ID]  group by [Purchase ID])[Sale],(select isnull(sum([Returned Quantity]),0)  from [Sale Return] join [Sale Return Invoice] on [Sale Return].[Sale Return Invoice No]=[Sale Return Invoice].[Sale Return Invoice No] where  [Sale Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Sale Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Sale Return],(select isnull(sum([Returned Quantity]),0)  from [Purchase Return] join [Purchase Return Invoice] on [Purchase Return].[Purchase Return Invoice No]=[Purchase Return Invoice].[Purchase Return Invoice No] where [Purchase Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Purchase Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Purchase Return], (select isnull(sum([Deducted Quantity]),0)  from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  Purchase.[Purchase ID]=[Product Transfer].[Purchase ID] and [Product Transfer].Status='Deducted'     group by [Purchase ID] )[Deducted]from Purchase  join Products on Purchase.[Product ID]=products.[Product ID]  join [Branch Information] on [Purchase].[Branch ID]=[Branch Information].[Branch ID]	  Join [Purchase Invoice] on [Purchase Invoice].[Purchase Invoice No]=[Purchase].[Purchase Invoice No] join [Supplier Information] on [Purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID] Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID]  Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID] Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID]    where Purchase.[Branch ID]='" + FrmHome.lblBranchID.Text + "' And [Product Group]. [Product Group ID] =  '" + Me.CmbSearchProductGroup.SelectedValue.ToString + "' And [Product Category].[Product Category ID] =  '" + Me.CmbSearchProductCategory.SelectedValue.ToString + "' And [Product Subcategory].[Product Subcategory ID] =  '" + Me.CmbSearchProductSubcategory.SelectedValue.ToString + "' And products. [Product Name] LIKE '%" + Me.TxtsearchProduct.Text + "%') as a  group by [Purchase Date],[Purchase ID],[Supplier Name],[Branch Name],[Product ID],[Product Name],[Purchase Cost],[Sale Price]having (isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))>0"


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Purchase")
            connection.Close()
            GrdStockInformation.DataSource = ds
            GrdStockInformation.DataMember = "BizPro_Purchase"


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            GrdStockInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records")
        Finally

        End Try

        'End Refresh Data

    End Sub

    'Search Product Name By Group Category And SubCategory ndProductName For All Branch
    Sub SearchProductNameByGroupCategoryAndSubCategoryndProductNameForAllBranch()
        ' Load Data
        Try
            

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select top 10 [Purchase Date],[Purchase ID],[Supplier Name],[Product ID],[Product Name],[Branch Name],[Purchase Cost],[Sale Price],(isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))[Stock Available] from ( select [Purchase].[Purchase Date],Purchase.[Purchase ID],[Supplier Information].[Supplier Name],[Products].[Product ID],[Products].[Product Name],[Branch Information].[Branch Name],[Branch Information].[Branch ID],Purchase.[Purchase Unit Cost][Purchase Cost],[Products].[Sale Price], case when [Purchase Quantity] =0  then  (select isnull(sum( [Added Quantity]),0)[Added Quantity] from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where  [Product Transfer].[Purchase ID]=Purchase.[Purchase ID] and [Product Transfer].Status='Added' and   [Product Transfer Invoice].Status='Complete'  and [Product Transfer].[Product ID]=Purchase.[Product ID]  group by [Purchase ID] )   ELSE isnull([Purchase].[Purchase Quantity],0) end [Purchase] , (select isnull(sum([Sale Quantity]),0)      from  sale join [Sale Invoice] on sale.[Sale Invoice No]= [Sale Invoice].[Sale Invoice No] where  Sale.[Purchase ID]=Purchase.[Purchase ID]  group by [Purchase ID])[Sale], (select isnull(sum([Returned Quantity]),0)  from [Sale Return] join [Sale Return Invoice] on [Sale Return].[Sale Return Invoice No]=[Sale Return Invoice].[Sale Return Invoice No] where   [Sale Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Sale Return],(select isnull(sum([Returned Quantity]),0)  from [Purchase Return] join [Purchase Return Invoice] on [Purchase Return].[Purchase Return Invoice No]=[Purchase Return Invoice].[Purchase Return Invoice No] where  [Purchase Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Purchase Return], (select isnull(sum([Deducted Quantity]),0)  from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where  Purchase.[Purchase ID]=[Product Transfer].[Purchase ID] and [Product Transfer].Status='Deducted'     group by [Purchase ID] )[Deducted] from Purchase  join Products on Purchase.[Product ID]=products.[Product ID]  join [Branch Information] on [Purchase].[Branch ID]=[Branch Information].[Branch ID]	   Join [Purchase Invoice] on [Purchase Invoice].[Purchase Invoice No]=[Purchase].[Purchase Invoice No]  join [Supplier Information] on [Purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID]  Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID]  Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID]   Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID] where ( [Product Group]. [Product Group ID] =  '" + Me.CmbSearchProductGroup.SelectedValue.ToString + "' And [Product Category].[Product Category ID] =  '" + Me.CmbSearchProductCategory.SelectedValue.ToString + "' And [Product Subcategory].[Product Subcategory ID] =  '" + Me.CmbSearchProductSubcategory.SelectedValue.ToString + "' And products. [Product Name] LIKE '%" + Me.TxtsearchProduct.Text + "%')  ) as a  group by [Purchase Date],[Purchase ID],[Supplier Name],[Branch Name],[Product ID],[Product Name],[Purchase Cost],[Sale Price] having (isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))>0"


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Purchase")
            connection.Close()
            GrdStockInformation.DataSource = ds
            GrdStockInformation.DataMember = "BizPro_Purchase"


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            GrdStockInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells


        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records")
        Finally

        End Try

        'End Refresh Data

    End Sub

    'Search By Product Name For Current Branch
    Sub SearchByProductNameForCurrentBranch()
        ' Load Data
        Try
         

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select top 10 [Purchase Date],[Purchase ID],[Supplier Name],[Product ID],[Product Name],[Branch Name],[Purchase Cost],[Sale Price],(isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))[Stock Available]from (select [Purchase].[Purchase Date],Purchase.[Purchase ID],[Supplier Information].[Supplier Name],[Products].[Product ID],[Products].[Product Name],[Branch Information].[Branch Name],[Branch Information].[Branch ID],Purchase.[Purchase Unit Cost][Purchase Cost],[Products].[Sale Price],case when [Purchase Quantity] =0  then (select isnull(sum( [Added Quantity]),0)[Added Quantity] from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  [Product Transfer].[Purchase ID]=Purchase.[Purchase ID] and [Product Transfer].Status='Added' and   [Product Transfer Invoice].Status='Complete'  and [Product Transfer].[Product ID]=Purchase.[Product ID]  group by [Purchase ID] )  ELSE isnull([Purchase].[Purchase Quantity],0) end [Purchase] ,(select isnull(sum([Sale Quantity]),0)      from  sale join [Sale Invoice] on sale.[Sale Invoice No]= [Sale Invoice].[Sale Invoice No] where Sale.[Branch ID]='" + FrmHome.lblBranchID.Text + "' and Sale.[Purchase ID]=Purchase.[Purchase ID]  group by [Purchase ID])[Sale],(select isnull(sum([Returned Quantity]),0)  from [Sale Return] join [Sale Return Invoice] on [Sale Return].[Sale Return Invoice No]=[Sale Return Invoice].[Sale Return Invoice No] where  [Sale Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Sale Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Sale Return],(select isnull(sum([Returned Quantity]),0)  from [Purchase Return] join [Purchase Return Invoice] on [Purchase Return].[Purchase Return Invoice No]=[Purchase Return Invoice].[Purchase Return Invoice No] where [Purchase Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Purchase Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Purchase Return], (select isnull(sum([Deducted Quantity]),0)  from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  Purchase.[Purchase ID]=[Product Transfer].[Purchase ID] and [Product Transfer].Status='Deducted'     group by [Purchase ID] )[Deducted]from Purchase  join Products on Purchase.[Product ID]=products.[Product ID]  join [Branch Information] on [Purchase].[Branch ID]=[Branch Information].[Branch ID]	  Join [Purchase Invoice] on [Purchase Invoice].[Purchase Invoice No]=[Purchase].[Purchase Invoice No] join [Supplier Information] on [Purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID] Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID]  Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID]  Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID]    where Purchase.[Branch ID]='" + FrmHome.lblBranchID.Text + "' and  products. [Product Name] LIKE '%" + Me.TxtsearchProduct.Text + "%' ) as a   group by [Purchase Date],[Purchase ID],[Supplier Name],[Branch Name],[Product ID],[Product Name],[Purchase Cost],[Sale Price]  having (isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))>0"


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Purchase")
            connection.Close()
            GrdStockInformation.DataSource = ds
            GrdStockInformation.DataMember = "BizPro_Purchase"


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            GrdStockInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells


        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records")
        Finally

        End Try

        'End Refresh Data

    End Sub
    'Search By Product Name For All Branch
    Sub SearchByProductNameForAllBranch()


        ' Load Data
        Try
            

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select top 10 [Purchase Date],[Purchase ID],[Supplier Name],[Product ID],[Product Name],[Branch Name],[Purchase Cost],[Sale Price],(isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))[Stock Available]from (select [Purchase].[Purchase Date],Purchase.[Purchase ID],[Supplier Information].[Supplier Name],[Products].[Product ID],[Products].[Product Name],[Branch Information].[Branch Name],[Branch Information].[Branch ID],Purchase.[Purchase Unit Cost][Purchase Cost],[Products].[Sale Price],case when [Purchase Quantity] =0  then (select isnull(sum( [Added Quantity]),0)[Added Quantity] from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where   [Product Transfer].[Purchase ID]=Purchase.[Purchase ID] and [Product Transfer].Status='Added' and   [Product Transfer Invoice].Status='Complete'  and [Product Transfer].[Product ID]=Purchase.[Product ID]  group by [Purchase ID] )  ELSE isnull([Purchase].[Purchase Quantity],0) end [Purchase] ,(select isnull(sum([Sale Quantity]),0)      from  sale join [Sale Invoice] on sale.[Sale Invoice No]= [Sale Invoice].[Sale Invoice No] where  Sale.[Purchase ID]=Purchase.[Purchase ID]  group by [Purchase ID])[Sale],(select isnull(sum([Returned Quantity]),0)  from [Sale Return] join [Sale Return Invoice] on [Sale Return].[Sale Return Invoice No]=[Sale Return Invoice].[Sale Return Invoice No] where   [Sale Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Sale Return],(select isnull(sum([Returned Quantity]),0)  from [Purchase Return] join [Purchase Return Invoice] on [Purchase Return].[Purchase Return Invoice No]=[Purchase Return Invoice].[Purchase Return Invoice No] where  [Purchase Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Purchase Return], (select isnull(sum([Deducted Quantity]),0)  from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where   Purchase.[Purchase ID]=[Product Transfer].[Purchase ID] and [Product Transfer].Status='Deducted'     group by [Purchase ID] )[Deducted]from Purchase  join Products on Purchase.[Product ID]=products.[Product ID]  join [Branch Information] on [Purchase].[Branch ID]=[Branch Information].[Branch ID]	  Join [Purchase Invoice] on [Purchase Invoice].[Purchase Invoice No]=[Purchase].[Purchase Invoice No]  join [Supplier Information] on [Purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID]  Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID]   Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID]   Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID]    where  products. [Product Name] LIKE '%" + Me.TxtsearchProduct.Text + "%') as a   group by [Purchase Date],[Purchase ID],[Supplier Name],[Branch Name],[Product ID],[Product Name],[Purchase Cost],[Sale Price] having (isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))>0"


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Purchase")
            connection.Close()
            GrdStockInformation.DataSource = ds
            GrdStockInformation.DataMember = "BizPro_Purchase"


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            GrdStockInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
           
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records")
        Finally

        End Try

        'End Refresh Data

    End Sub

    'Search By Product Group For Current Branch
    Sub SearchByProductGroupForCurrentBranch()

        ' Load Data
        Try
          


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select top 10 [Purchase Date],[Purchase ID],[Supplier Name],[Product ID],[Product Name],[Branch Name],[Purchase Cost],[Sale Price],(isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))[Stock Available]from (select [Purchase].[Purchase Date],Purchase.[Purchase ID],[Supplier Information].[Supplier Name],[Products].[Product ID],[Products].[Product Name],[Branch Information].[Branch Name],[Branch Information].[Branch ID],Purchase.[Purchase Unit Cost][Purchase Cost],[Products].[Sale Price],case when [Purchase Quantity] =0  then (select isnull(sum( [Added Quantity]),0)[Added Quantity] from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  [Product Transfer].[Purchase ID]=Purchase.[Purchase ID] and [Product Transfer].Status='Added' and   [Product Transfer Invoice].Status='Complete'  and [Product Transfer].[Product ID]=Purchase.[Product ID]  group by [Purchase ID] )  ELSE isnull([Purchase].[Purchase Quantity],0) end [Purchase] ,(select isnull(sum([Sale Quantity]),0)      from  sale join [Sale Invoice] on sale.[Sale Invoice No]= [Sale Invoice].[Sale Invoice No] where Sale.[Branch ID]='" + FrmHome.lblBranchID.Text + "' and Sale.[Purchase ID]=Purchase.[Purchase ID]  group by [Purchase ID])[Sale],(select isnull(sum([Returned Quantity]),0)  from [Sale Return] join [Sale Return Invoice] on [Sale Return].[Sale Return Invoice No]=[Sale Return Invoice].[Sale Return Invoice No] where  [Sale Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Sale Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Sale Return],(select isnull(sum([Returned Quantity]),0)  from [Purchase Return] join [Purchase Return Invoice] on [Purchase Return].[Purchase Return Invoice No]=[Purchase Return Invoice].[Purchase Return Invoice No] where [Purchase Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Purchase Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Purchase Return], (select isnull(sum([Deducted Quantity]),0)  from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  Purchase.[Purchase ID]=[Product Transfer].[Purchase ID] and [Product Transfer].Status='Deducted'     group by [Purchase ID] )[Deducted]from Purchase  join Products on Purchase.[Product ID]=products.[Product ID]  join [Branch Information] on [Purchase].[Branch ID]=[Branch Information].[Branch ID]	   Join [Purchase Invoice] on [Purchase Invoice].[Purchase Invoice No]=[Purchase].[Purchase Invoice No] join [Supplier Information] on [Purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID] Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID]  Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID]  Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID]    where ([Purchase].[Branch ID]= '" + FrmHome.lblBranchID.Text + "' And [Product Group].[Product Group ID] =  '" + Me.CmbSearchProductGroup.SelectedValue.ToString + "') ) as a  group by [Purchase Date],[Purchase ID],[Supplier Name],[Branch Name],[Product ID],[Product Name],[Purchase Cost],[Sale Price] having (isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))>0"


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Purchase")
            connection.Close()
            GrdStockInformation.DataSource = ds
            GrdStockInformation.DataMember = "BizPro_Purchase"


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            GrdStockInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells


        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records")
        Finally

        End Try

        'End Refresh Data


    End Sub

    'Search By Product Group For All Branch
    Sub SearchByProductGroupForAllBranch()

        ' Load Data
        Try
            

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select top 10 [Purchase Date],[Purchase ID],[Supplier Name],[Product ID],[Product Name],[Branch Name],[Purchase Cost],[Sale Price],(isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))[Stock Available] from ( select [Purchase].[Purchase Date],Purchase.[Purchase ID],[Supplier Information].[Supplier Name],[Products].[Product ID],[Products].[Product Name],[Branch Information].[Branch Name],[Branch Information].[Branch ID],Purchase.[Purchase Unit Cost][Purchase Cost],[Products].[Sale Price], case when [Purchase Quantity] =0  then  (select isnull(sum( [Added Quantity]),0)[Added Quantity] from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where  [Product Transfer].[Purchase ID]=Purchase.[Purchase ID] and [Product Transfer].Status='Added' and   [Product Transfer Invoice].Status='Complete'  and [Product Transfer].[Product ID]=Purchase.[Product ID]  group by [Purchase ID] )   ELSE isnull([Purchase].[Purchase Quantity],0) end [Purchase] , (select isnull(sum([Sale Quantity]),0)      from  sale join [Sale Invoice] on sale.[Sale Invoice No]= [Sale Invoice].[Sale Invoice No] where  Sale.[Purchase ID]=Purchase.[Purchase ID]  group by [Purchase ID])[Sale], (select isnull(sum([Returned Quantity]),0)  from [Sale Return] join [Sale Return Invoice] on [Sale Return].[Sale Return Invoice No]=[Sale Return Invoice].[Sale Return Invoice No] where   [Sale Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Sale Return],(select isnull(sum([Returned Quantity]),0)  from [Purchase Return] join [Purchase Return Invoice] on [Purchase Return].[Purchase Return Invoice No]=[Purchase Return Invoice].[Purchase Return Invoice No] where  [Purchase Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Purchase Return], (select isnull(sum([Deducted Quantity]),0)  from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where  Purchase.[Purchase ID]=[Product Transfer].[Purchase ID] and [Product Transfer].Status='Deducted'     group by [Purchase ID] )[Deducted] from Purchase  join Products on Purchase.[Product ID]=products.[Product ID]  join [Branch Information] on [Purchase].[Branch ID]=[Branch Information].[Branch ID]	   Join [Purchase Invoice] on [Purchase Invoice].[Purchase Invoice No]=[Purchase].[Purchase Invoice No]  join [Supplier Information] on [Purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID]  Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID]  Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID]   Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID] where ( [Product Group].[Product Group ID] =  '" + Me.CmbSearchProductGroup.SelectedValue.ToString + "')  ) as a  group by [Purchase Date],[Purchase ID],[Supplier Name],[Branch Name],[Product ID],[Product Name],[Purchase Cost],[Sale Price] having (isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))>0"


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Purchase")
            connection.Close()
            GrdStockInformation.DataSource = ds
            GrdStockInformation.DataMember = "BizPro_Purchase"


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            GrdStockInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells


        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records")
        Finally

        End Try

        'End Refresh Data


    End Sub

    'Search By Product Group And Category For Current Branch
    Sub SearchByProductGroupAndCategoryForCurrentBranch()

        ' Load Data
        Try
            

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select top 10 [Purchase Date],[Purchase ID],[Supplier Name],[Product ID],[Product Name],[Branch Name],[Purchase Cost],[Sale Price],(isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))[Stock Available]from (select [Purchase].[Purchase Date],Purchase.[Purchase ID],[Supplier Information].[Supplier Name],[Products].[Product ID],[Products].[Product Name],[Branch Information].[Branch Name],[Branch Information].[Branch ID],Purchase.[Purchase Unit Cost][Purchase Cost],[Products].[Sale Price],case when [Purchase Quantity] =0  then (select isnull(sum( [Added Quantity]),0)[Added Quantity] from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  [Product Transfer].[Purchase ID]=Purchase.[Purchase ID] and [Product Transfer].Status='Added' and   [Product Transfer Invoice].Status='Complete'  and [Product Transfer].[Product ID]=Purchase.[Product ID]  group by [Purchase ID] )  ELSE isnull([Purchase].[Purchase Quantity],0) end [Purchase] ,(select isnull(sum([Sale Quantity]),0)      from  sale join [Sale Invoice] on sale.[Sale Invoice No]= [Sale Invoice].[Sale Invoice No] where Sale.[Branch ID]='" + FrmHome.lblBranchID.Text + "' and Sale.[Purchase ID]=Purchase.[Purchase ID]  group by [Purchase ID])[Sale],(select isnull(sum([Returned Quantity]),0)  from [Sale Return] join [Sale Return Invoice] on [Sale Return].[Sale Return Invoice No]=[Sale Return Invoice].[Sale Return Invoice No] where  [Sale Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Sale Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Sale Return],(select isnull(sum([Returned Quantity]),0)  from [Purchase Return] join [Purchase Return Invoice] on [Purchase Return].[Purchase Return Invoice No]=[Purchase Return Invoice].[Purchase Return Invoice No] where [Purchase Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Purchase Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Purchase Return], (select isnull(sum([Deducted Quantity]),0)  from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  Purchase.[Purchase ID]=[Product Transfer].[Purchase ID] and [Product Transfer].Status='Deducted'     group by [Purchase ID] )[Deducted]from Purchase  join Products on Purchase.[Product ID]=products.[Product ID]  join [Branch Information] on [Purchase].[Branch ID]=[Branch Information].[Branch ID]	   Join [Purchase Invoice] on [Purchase Invoice].[Purchase Invoice No]=[Purchase].[Purchase Invoice No] join [Supplier Information] on [Purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID] Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID]  Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID]  Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID]    where ([Purchase].[Branch ID]= '" + FrmHome.lblBranchID.Text + "' And [Product Group]. [Product Group ID] =  '" + Me.CmbSearchProductGroup.SelectedValue.ToString + "' And [Product Category]. [Product Category ID] =  '" + Me.CmbSearchProductCategory.SelectedValue.ToString + "') ) as a  group by [Purchase Date],[Purchase ID],[Supplier Name],[Branch Name],[Product ID],[Product Name],[Purchase Cost],[Sale Price] having (isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))>0"


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Purchase")
            connection.Close()
            GrdStockInformation.DataSource = ds
            GrdStockInformation.DataMember = "BizPro_Purchase"


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            GrdStockInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells


        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records")
        Finally

        End Try

        'End Refresh Data


    End Sub

    'Search By Product Group And Category For All Branch
    Sub SearchByProductGroupAndCategoryForAllBranch()

        ' Load Data
        Try
            
            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select top 10 [Purchase Date],[Purchase ID],[Supplier Name],[Product ID],[Product Name],[Branch Name],[Purchase Cost],[Sale Price],(isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))[Stock Available] from ( select [Purchase].[Purchase Date],Purchase.[Purchase ID],[Supplier Information].[Supplier Name],[Products].[Product ID],[Products].[Product Name],[Branch Information].[Branch Name],[Branch Information].[Branch ID],Purchase.[Purchase Unit Cost][Purchase Cost],[Products].[Sale Price], case when [Purchase Quantity] =0  then  (select isnull(sum( [Added Quantity]),0)[Added Quantity] from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where  [Product Transfer].[Purchase ID]=Purchase.[Purchase ID] and [Product Transfer].Status='Added' and   [Product Transfer Invoice].Status='Complete'  and [Product Transfer].[Product ID]=Purchase.[Product ID]  group by [Purchase ID] )   ELSE isnull([Purchase].[Purchase Quantity],0) end [Purchase] , (select isnull(sum([Sale Quantity]),0)      from  sale join [Sale Invoice] on sale.[Sale Invoice No]= [Sale Invoice].[Sale Invoice No] where  Sale.[Purchase ID]=Purchase.[Purchase ID]  group by [Purchase ID])[Sale], (select isnull(sum([Returned Quantity]),0)  from [Sale Return] join [Sale Return Invoice] on [Sale Return].[Sale Return Invoice No]=[Sale Return Invoice].[Sale Return Invoice No] where   [Sale Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Sale Return],(select isnull(sum([Returned Quantity]),0)  from [Purchase Return] join [Purchase Return Invoice] on [Purchase Return].[Purchase Return Invoice No]=[Purchase Return Invoice].[Purchase Return Invoice No] where  [Purchase Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Purchase Return], (select isnull(sum([Deducted Quantity]),0)  from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where  Purchase.[Purchase ID]=[Product Transfer].[Purchase ID] and [Product Transfer].Status='Deducted'     group by [Purchase ID] )[Deducted] from Purchase  join Products on Purchase.[Product ID]=products.[Product ID]  join [Branch Information] on [Purchase].[Branch ID]=[Branch Information].[Branch ID]	   Join [Purchase Invoice] on [Purchase Invoice].[Purchase Invoice No]=[Purchase].[Purchase Invoice No]  join [Supplier Information] on [Purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID]  Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID]  Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID]   Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID] where ( [Product Group]. [Product Group ID] =  '" + Me.CmbSearchProductGroup.SelectedValue.ToString + "' And [Product Category]. [Product Category ID] =  '" + Me.CmbSearchProductCategory.SelectedValue.ToString + "')  ) as a  group by [Purchase Date],[Purchase ID],[Supplier Name],[Branch Name],[Product ID],[Product Name],[Purchase Cost],[Sale Price] having (isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))>0"


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Purchase")
            connection.Close()
            GrdStockInformation.DataSource = ds
            GrdStockInformation.DataMember = "BizPro_Purchase"


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            GrdStockInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells


        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records")
        Finally

        End Try

        'End Refresh Data


    End Sub

    'Search By Product Group And Category And Subcategory For Current Branch
    Sub SearchByProductGroupAndCategoryAndSubcategoryForCurrentBranch()

        ' Load Data
        Try
          
            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select top 10 [Purchase Date],[Purchase ID],[Supplier Name],[Product ID],[Product Name],[Branch Name],[Purchase Cost],[Sale Price],(isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))[Stock Available]from (select [Purchase].[Purchase Date],Purchase.[Purchase ID],[Supplier Information].[Supplier Name],[Products].[Product ID],[Products].[Product Name],[Branch Information].[Branch Name],[Branch Information].[Branch ID],Purchase.[Purchase Unit Cost][Purchase Cost],[Products].[Sale Price],case when [Purchase Quantity] =0  then (select isnull(sum( [Added Quantity]),0)[Added Quantity] from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  [Product Transfer].[Purchase ID]=Purchase.[Purchase ID] and [Product Transfer].Status='Added' and   [Product Transfer Invoice].Status='Complete'  and [Product Transfer].[Product ID]=Purchase.[Product ID]  group by [Purchase ID] )  ELSE isnull([Purchase].[Purchase Quantity],0) end [Purchase] ,(select isnull(sum([Sale Quantity]),0)      from  sale join [Sale Invoice] on sale.[Sale Invoice No]= [Sale Invoice].[Sale Invoice No] where Sale.[Branch ID]='" + FrmHome.lblBranchID.Text + "' and Sale.[Purchase ID]=Purchase.[Purchase ID]  group by [Purchase ID])[Sale],(select isnull(sum([Returned Quantity]),0)  from [Sale Return] join [Sale Return Invoice] on [Sale Return].[Sale Return Invoice No]=[Sale Return Invoice].[Sale Return Invoice No] where  [Sale Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Sale Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Sale Return],(select isnull(sum([Returned Quantity]),0)  from [Purchase Return] join [Purchase Return Invoice] on [Purchase Return].[Purchase Return Invoice No]=[Purchase Return Invoice].[Purchase Return Invoice No] where [Purchase Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Purchase Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Purchase Return], (select isnull(sum([Deducted Quantity]),0)  from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  Purchase.[Purchase ID]=[Product Transfer].[Purchase ID] and [Product Transfer].Status='Deducted'     group by [Purchase ID] )[Deducted]from Purchase  join Products on Purchase.[Product ID]=products.[Product ID]  join [Branch Information] on [Purchase].[Branch ID]=[Branch Information].[Branch ID]	  Join [Purchase Invoice] on [Purchase Invoice].[Purchase Invoice No]=[Purchase].[Purchase Invoice No] join [Supplier Information] on [Purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID] Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID]  Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID]  Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID]  where [Purchase].[Branch ID]= '" + FrmHome.lblBranchID.Text + "' And [Product Group]. [Product Group ID] =  '" + Me.CmbSearchProductGroup.SelectedValue.ToString + "' And [Product Category].[Product Category ID] =  '" + Me.CmbSearchProductCategory.SelectedValue.ToString + "' And [Product Subcategory].[Product Subcategory ID] =  '" + Me.CmbSearchProductSubcategory.SelectedValue.ToString + "') as a   group by [Purchase Date],[Purchase ID],[Supplier Name],[Branch Name],[Product ID],[Product Name],[Purchase Cost],[Sale Price] having (isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))>0"


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Purchase")
            connection.Close()
            GrdStockInformation.DataSource = ds
            GrdStockInformation.DataMember = "BizPro_Purchase"


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            GrdStockInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells


        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records")
        Finally

        End Try

        'End Refresh Data


    End Sub

    'Search By Product Group And Category Subcategory For All Branch
    Sub SearchByProductGroupAndCategorySubcategoryForAllBranch()

        ' Load Data
        Try
         


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select top 10 [Purchase Date],[Purchase ID],[Supplier Name],[Product ID],[Product Name],[Branch Name],[Purchase Cost],[Sale Price],(isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))[Stock Available] from ( select [Purchase].[Purchase Date],Purchase.[Purchase ID],[Supplier Information].[Supplier Name],[Products].[Product ID],[Products].[Product Name],[Branch Information].[Branch Name],[Branch Information].[Branch ID],Purchase.[Purchase Unit Cost][Purchase Cost],[Products].[Sale Price], case when [Purchase Quantity] =0  then  (select isnull(sum( [Added Quantity]),0)[Added Quantity] from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where  [Product Transfer].[Purchase ID]=Purchase.[Purchase ID] and [Product Transfer].Status='Added' and   [Product Transfer Invoice].Status='Complete'  and [Product Transfer].[Product ID]=Purchase.[Product ID]  group by [Purchase ID] )   ELSE isnull([Purchase].[Purchase Quantity],0) end [Purchase] , (select isnull(sum([Sale Quantity]),0)      from  sale join [Sale Invoice] on sale.[Sale Invoice No]= [Sale Invoice].[Sale Invoice No] where  Sale.[Purchase ID]=Purchase.[Purchase ID]  group by [Purchase ID])[Sale], (select isnull(sum([Returned Quantity]),0)  from [Sale Return] join [Sale Return Invoice] on [Sale Return].[Sale Return Invoice No]=[Sale Return Invoice].[Sale Return Invoice No] where   [Sale Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Sale Return],(select isnull(sum([Returned Quantity]),0)  from [Purchase Return] join [Purchase Return Invoice] on [Purchase Return].[Purchase Return Invoice No]=[Purchase Return Invoice].[Purchase Return Invoice No] where  [Purchase Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Purchase Return], (select isnull(sum([Deducted Quantity]),0)  from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where  Purchase.[Purchase ID]=[Product Transfer].[Purchase ID] and [Product Transfer].Status='Deducted'     group by [Purchase ID] )[Deducted] from Purchase  join Products on Purchase.[Product ID]=products.[Product ID]  join [Branch Information] on [Purchase].[Branch ID]=[Branch Information].[Branch ID]	   Join [Purchase Invoice] on [Purchase Invoice].[Purchase Invoice No]=[Purchase].[Purchase Invoice No]  join [Supplier Information] on [Purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID]  Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID]  Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID]   Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID] where ( [Product Group]. [Product Group ID] =  '" + Me.CmbSearchProductGroup.SelectedValue.ToString + "' And [Product Category].[Product Category ID] =  '" + Me.CmbSearchProductCategory.SelectedValue.ToString + "' And [Product Subcategory].[Product Subcategory ID] =  '" + Me.CmbSearchProductSubcategory.SelectedValue.ToString + "')  ) as a  group by [Purchase Date],[Purchase ID],[Supplier Name],[Branch Name],[Product ID],[Product Name],[Purchase Cost],[Sale Price] having (isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))>0"


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Purchase")
            connection.Close()
            GrdStockInformation.DataSource = ds
            GrdStockInformation.DataMember = "BizPro_Purchase"


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            GrdStockInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
           
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records")
        Finally

        End Try

        'End Refresh Data


    End Sub

    Private Sub CmbSearchProductGroup_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbSearchProductGroup.KeyDown
        If e.KeyCode = Keys.Enter Then

            If Me.Text = "" Then
                CmbSearchProductCategory.Focus()
            Else

                If RdbCurrentBranch.Checked = True Then
                    ' Search By Product Group For Current Branch()
                    SearchByProductGroupForCurrentBranch()

                    CmbSearchProductCategory.Focus()

                Else
                    ' Search By Product Group For All Branch()
                    SearchByProductGroupForAllBranch()

                    CmbSearchProductCategory.Focus()

                End If



            End If
        End If
    End Sub

    Private Sub CmbSearchProductGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSearchProductGroup.SelectedIndexChanged

    End Sub

    Private Sub CmbSearchProductCategory_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbSearchProductCategory.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.Text = "" Then
                CmbSearchProductSubcategory.Focus()

            Else

                If RdbCurrentBranch.Checked = True Then

                    'Search By Product Group And Category For Current Branch
                    SearchByProductGroupAndCategoryForCurrentBranch()


                    CmbSearchProductSubcategory.Focus()
                Else

                    'Search By Product Group And Category For All Branch
                    SearchByProductGroupAndCategoryForAllBranch()

                    CmbSearchProductSubcategory.Focus()
                End If


            End If
        End If
    End Sub

    Private Sub CmbSearchProductCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSearchProductCategory.SelectedIndexChanged

    End Sub

    Private Sub CmbSearchProductSubcategory_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbSearchProductSubcategory.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.Text = "" Then
                TxtsearchProduct.Focus()

            Else

                If RdbCurrentBranch.Checked = True Then
                    'Search By Product Group And Category And Subcategory For Current Branch
                    SearchByProductGroupAndCategoryAndSubcategoryForCurrentBranch()

                    TxtsearchProduct.Focus()
                Else
                    'Search By Product Group And Category Subcategory For All Branch
                    SearchByProductGroupAndCategorySubcategoryForAllBranch()

                    TxtsearchProduct.Focus()

                End If



            End If
        End If
    End Sub

    Private Sub CmbSearchProductGroup_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbSearchProductGroup.SelectedValueChanged

    End Sub

    Private Sub CmbSearchProductCategory_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbSearchProductCategory.SelectedValueChanged

    End Sub

    Private Sub CmbSearchProductSubcategory_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbSearchProductSubcategory.SelectedValueChanged

    End Sub

    Private Sub RdbCurrentBranch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdbCurrentBranch.CheckedChanged



    End Sub

    Private Sub RdbAllBranch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdbAllBranch.CheckedChanged

        If RdbAllBranch.Checked = True Then
            RdbCurrentBranch.Checked = False
        End If


        If RdbCurrentBranch.Checked = True Then
            'Refresh Data For Current Branch
            RefreshDataForCurrentBranch()
        Else
            If TxtsearchProduct.Text = "" Then
                'Refresh Data For All Branch
                RefreshDataForAllBranch()
            Else

                SearchByProductNameForAllBranch()
            End If

        End If
    End Sub

    Private Sub CmbSearchProductSubcategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSearchProductSubcategory.SelectedIndexChanged

    End Sub




    Private Sub GrdStockInformation_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

    End Sub


    Private Sub GrdStockInformation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub GrdStockInformation_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdStockInformation_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdStockInformation.CellContentClick

    End Sub

    Private Sub GrdStockInformation_CellMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdStockInformation.CellMouseClick

    End Sub

    Private Sub GrdStockInformation_CellMouseDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdStockInformation.CellMouseDoubleClick
        'Grid view Cell Mouse Double Click Codde

        Try

            Dim i As Integer
            i = GrdStockInformation.CurrentRow.Index



            If RdbCurrentBranch.Checked = True Then

                If Label1.Text = "Sale" Then

                    FrmSale.cmbProductName.ValueMember = GrdStockInformation.Item(3, i).Value
                    FrmSale.cmbProductName.Text = GrdStockInformation.Item(4, i).Value


                    FrmSale.TxtPurchaseID.Text = GrdStockInformation.Item(1, i).Value

                    FrmSale.TxtSaleUnitPrice.Text = GrdStockInformation.Item(7, i).Value

                    'show available quantity in sale
                    FrmSale.ShowQuantityInLable()

                    FrmSale.TxtQuantity.Focus()

                    'Search Whole Sale Price From Product Information
                    FrmSale.SearchWholeSalePriceFromProductInformation()

                    'Privet sub for Search SalePrice on Customer
                    FrmSale.SearchSalePriceFromCustomerForSale()

                    'Search Available Serial Number or not
                    FrmSale.SearchSerialStatus()

                    'Search Warranty Days
                    SearchWarrantyDays()

                    'Serial Number Show if available
                    'FrmSale.LoadComboBoxforSerialNumber()

                    'Find Sale ID To Show In Lable
                    FrmSale.FindSaleIDToShowInLableWhileSelectingNewProduct()

                    'Find Total Stock Available of this product and send it to variable
                    'FrmSale.FindTotalQuantityOfSelectedProduct()


                    'Find Last Sold Product Price
                    FrmSale.FindLastSoldProductPrice()


                    Me.Close()

                ElseIf Label1.Text = "Chalan" Then
                    FrmChalan.cmbProductName.ValueMember = GrdStockInformation.Item(3, i).Value
                    FrmChalan.cmbProductName.Text = GrdStockInformation.Item(4, i).Value


                    FrmChalan.TxtPurchaseID.Text = GrdStockInformation.Item(1, i).Value

                    FrmChalan.TxtChalanUnitPrice.Text = GrdStockInformation.Item(7, i).Value
                    FrmChalan.lblQuantity.Text = GrdStockInformation.Item(8, i).Value

                    FrmChalan.TxtQuantity.Focus()

                    'Privet sub for Search SalePrice on Customer
                    SearchSalePriceFromCustomerForChalan()
                    Me.Close()
                ElseIf Label1.Text = "Product Transfer" Then

                    FrmProductTransfer.cmbProductName.ValueMember = GrdStockInformation.Item(3, i).Value
                    FrmProductTransfer.cmbProductName.Text = GrdStockInformation.Item(4, i).Value

                    FrmProductTransfer.TxtPurchaseID.Text = GrdStockInformation.Item(1, i).Value
                    FrmProductTransfer.lblQuantity.Text = GrdStockInformation.Item(8, i).Value
                    FrmProductTransfer.PurchaseUnitCost = GrdStockInformation.Item(6, i).Value
                    FrmProductTransfer.LoadComboBoxforSerialNumber()

                    FrmProductTransfer.TxtQuantity.Focus()
                    FrmProductTransfer.SearchSerialStatus()
                    FrmProductTransfer.SearchWarrantyDays()
                    FrmProductTransfer.SearchPurchaseInvoiceNoForPurchaseReturn()
                    FrmProductTransfer.ShowQuantityInLable()
                    'Find Transfer ID To Show In Lable While Selecting New Product
                    'FrmProductTransfer.FindTransferIDToShowInLableWhileSelectingNewProduct()

                    Me.Close()
                End If

            Else
                MsgBox("Please Select Current Branch", MsgBoxStyle.OkOnly, "Product Stock")
            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

        End Try
    End Sub

    Private Sub GrdStockInformation_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdStockInformation.KeyDown
        'Grid view Keydown code
        If e.KeyCode = Keys.Enter Then


            'Data Grid view code
            Try

                Dim i As Integer
                i = GrdStockInformation.CurrentRow.Index

                If RdbCurrentBranch.Checked = True Then

                    If Label1.Text = "Sale" Then
                        FrmSale.cmbProductName.ValueMember = GrdStockInformation.Item(3, i).Value
                        FrmSale.cmbProductName.Text = GrdStockInformation.Item(4, i).Value


                        FrmSale.TxtPurchaseID.Text = GrdStockInformation.Item(1, i).Value

                        FrmSale.TxtSaleUnitPrice.Text = GrdStockInformation.Item(7, i).Value

                        'show available quantity in sale
                        FrmSale.ShowQuantityInLable()


                        FrmSale.TxtQuantity.Focus()

                        'Search Whole Sale Price From Product Information
                        FrmSale.SearchWholeSalePriceFromProductInformation()

                        'Privet sub for Search SalePrice on Customer
                        FrmSale.SearchSalePriceFromCustomerForSale()

                        'Search Available Serial Number or not
                        FrmSale.SearchSerialStatus()


                        'Search Warranty Days
                        SearchWarrantyDays()

                        'Serial Number Show if available
                        'FrmSale.LoadComboBoxforSerialNumber()

                        'Find Sale ID To Show In Lable
                        FrmSale.FindSaleIDToShowInLableWhileSelectingNewProduct()

                        'Find Total Stock Available of this product and send it to variable
                        'FrmSale.FindTotalQuantityOfSelectedProduct()
                        'Find Last Sold Product Price
                        FrmSale.FindLastSoldProductPrice()


                        Me.Close()

                    ElseIf Label1.Text = "Chalan" Then
                        FrmChalan.cmbProductName.ValueMember = GrdStockInformation.Item(3, i).Value
                        FrmChalan.cmbProductName.Text = GrdStockInformation.Item(4, i).Value


                        FrmChalan.TxtPurchaseID.Text = GrdStockInformation.Item(1, i).Value

                        FrmChalan.TxtChalanUnitPrice.Text = GrdStockInformation.Item(7, i).Value
                        FrmChalan.lblQuantity.Text = GrdStockInformation.Item(8, i).Value

                        FrmChalan.TxtQuantity.Focus()

                        'Privet sub for Search SalePrice on Customer
                        SearchSalePriceFromCustomerForChalan()

                        Me.Close()
                    ElseIf Label1.Text = "Product Transfer" Then


                        FrmProductTransfer.cmbProductName.ValueMember = GrdStockInformation.Item(3, i).Value
                        FrmProductTransfer.cmbProductName.Text = GrdStockInformation.Item(4, i).Value

                        FrmProductTransfer.TxtPurchaseID.Text = GrdStockInformation.Item(1, i).Value
                        FrmProductTransfer.lblQuantity.Text = GrdStockInformation.Item(8, i).Value
                        FrmProductTransfer.PurchaseUnitCost = GrdStockInformation.Item(6, i).Value
                        FrmProductTransfer.LoadComboBoxforSerialNumber()

                        FrmProductTransfer.TxtQuantity.Focus()
                        FrmProductTransfer.SearchSerialStatus()
                        FrmProductTransfer.SearchWarrantyDays()
                        FrmProductTransfer.SearchPurchaseInvoiceNoForPurchaseReturn()
                        FrmProductTransfer.ShowQuantityInLable()

                        'Find Transfer ID To Show In Lable While Selecting New Product
                        'FrmProductTransfer.FindTransferIDToShowInLableWhileSelectingNewProduct()

                        Me.Close()
                    End If

                Else
                    MsgBox("Please Select Current Branch", MsgBoxStyle.OkOnly, "Product Stock")
                End If


            Catch ex As Exception
                MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

            End Try

        End If
    End Sub

    Private Sub RdbCurrentBranch_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RdbCurrentBranch.MouseClick
        If RdbCurrentBranch.Checked = True Then
            RdbAllBranch.Checked = False
        End If

        If RdbCurrentBranch.Checked = True Then
            'Refresh Data For Current Branch
            RefreshDataForCurrentBranch()

            TxtsearchProduct.Focus()
        Else
            'Refresh Data For All Branch
            RefreshDataForAllBranch()

            TxtsearchProduct.Focus()

        End If
    End Sub

    Private Sub Panel2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= (X)
            newpoint.Y -= (Y)
            Me.Location = newpoint

        End If
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

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

    Private Sub Btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnclose.Click
        Me.Close()

    End Sub
End Class