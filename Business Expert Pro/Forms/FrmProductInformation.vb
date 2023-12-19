Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class FrmProductInformation
    Dim PurchaseInvoice As String
    Dim ProductID As String
    Dim FirstValue As String
    Dim LastFromValue As String
    Dim LastToValue As String
    Private Sub LblRecorderPoint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblReorderPoint.Click

    End Sub

    Private Sub LblWarrantySerial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LblPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LblLocation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click
        'Focus On Branch Name
        CmbProductGroupID.Focus()

        'Making Clear
        ClearDataAll()



    End Sub

    Private Sub GrpProductInformation_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrpProductInformation.Enter

    End Sub
    'Insert into log 
    Sub InsertIntoLog()

        'Data Insert Code
        Dim con As New SqlConnection
        Dim con1 As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim dr As SqlDataReader
        Dim CurrentDate As DateTime = DateTime.Today
        Dim CurrentTime As DateTime = DateTime.Now

        Try
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "select top 1 * from [Products] where [User account ID]='" + FrmHome.LblUserID.Text + "' and [Computer ID]='" + FrmHome.LblComputerID.Text + "'  order by [Product ID] desc"
            dr = cmd.ExecuteReader
            dr.Read()

            If dr.HasRows Then

                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd1.CommandText = "INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES ('" + Me.Text + "','INSERT','Product ID: " + dr.Item("Product ID").ToString + " ,Product Group ID: " + CmbProductGroupID.Text + " , Product Category ID: " + CmbProductCategoryID.Text + ",Product Subcategory ID: " + CmbProductSubcategoryID.Text + " ,Product Name: " + TxtProductName.Text + ",Barcode Serial: " + TxtBarcodeSerial.Text + ",Purchase Price: " + TxtPurchasePrice.Text + ",Sale Price: " + TxtSalePrice.Text + ",WholeSale Price: " + TxtWholeSalePrice.Text + ",Reorder Point: " + TxtReorderPoint.Text + ",Opening Stock: " + TxtOpeningStock.Text + ",Unit Type: " + CmbUnitType.Text + ",Remarks: " + TxtRemarks.Text + ",Serial Number: " + TxtSerialNumber.Text + ",Range Serial From: " + TxtFromSerial.Text + ",Range Serial To: " + TxtToSerial.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + dr.Item("Product ID").ToString + "' )"
                cmd1.ExecuteNonQuery()
                con1.Close()

            End If
            dr.Close()
            con.Close()



        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally


        End Try
    End Sub

    Private Sub BtnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInsert.Click

        'Insert into Product Information
        InsertIntoProductInformation()




    End Sub
    'Sub Update from serial add
    Sub UpdateorInserttoProductFromSerialAdd()


        Try

      
            If Not Me.TxtProductID.Text = "" Then

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand


                If Me.CmbProductCategoryID.Text = "" Or Me.CmbProductCategoryID.ValueMember = "" Or Me.CmbProductGroupID.Text = "" Or Me.CmbProductGroupID.ValueMember = "" Or Me.CmbProductSubcategoryID.Text = "" Or Me.CmbProductSubcategoryID.ValueMember = "" Or TxtProductName.Text = "" Then
                    MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Product Information")

                Else
                    If Not Me.ProductPictureBox.Image Is Nothing Then

                        con.ConnectionString = FrmHome.ConnectionString
                        con.Open()
                        cmd.Connection = con
                        cmd.CommandText = "UPDATE [Products] SET [Product Group ID]= '" + CmbProductGroupID.ValueMember + "', [Product Category ID]= '" + CmbProductCategoryID.ValueMember + "',[Product Subcategory ID] = '" + CmbProductSubcategoryID.ValueMember + "',[Product Name]= '" + TxtProductName.Text + "',[Barcode Serial]= '" + TxtBarcodeSerial.Text + "',[Purchase Price]= '" + TxtPurchasePrice.Text + "',[Sale Price]= '" + TxtSalePrice.Text + "',[Wholesale Price]= '" + TxtWholeSalePrice.Text + "',[Reorder Point]= '" + TxtReorderPoint.Text + "',[Product Image]=@test,[Remarks]='" + TxtRemarks.Text + "',[User Account ID]= '" + FrmHome.LblUserID.Text + "',[Computer ID]= '" + FrmHome.LblComputerID.Text + "',[Unit ID]= '" + CmbUnitType.SelectedValue.ToString + "' WHERE [Product ID]= '" + TxtProductID.Text + "'"

                        Dim ms As New MemoryStream()
                        ProductPictureBox.Image.Save(ms, ProductPictureBox.Image.RawFormat)
                        Dim data As Byte() = ms.GetBuffer()
                        Dim p As New SqlParameter("@test", SqlDbType.Image)
                        p.Value = data
                        cmd.Parameters.Add(p)

                        cmd.ExecuteNonQuery()
                        con.Close()


                    ElseIf Me.ProductPictureBox.Image Is Nothing Then

                        con.ConnectionString = FrmHome.ConnectionString
                        con.Open()
                        cmd.Connection = con
                        cmd.CommandText = "UPDATE [Products] SET [Product Group ID]= '" + CmbProductGroupID.ValueMember + "', [Product Category ID]= '" + CmbProductCategoryID.ValueMember + "',[Product Subcategory ID] = '" + CmbProductSubcategoryID.ValueMember + "',[Product Name]= '" + TxtProductName.Text + "',[Barcode Serial]= '" + TxtBarcodeSerial.Text + "',[Purchase Price]= '" + TxtPurchasePrice.Text + "',[Sale Price]= '" + TxtSalePrice.Text + "',[Wholesale Price]= '" + TxtWholeSalePrice.Text + "',[Reorder Point]= '" + TxtReorderPoint.Text + "',[Product Image]= '" + Nothing + "',[Remarks]='" + TxtRemarks.Text + "',[User Account ID]= '" + FrmHome.LblUserID.Text + "',[Computer ID]= '" + FrmHome.LblComputerID.Text + "',[Unit ID]= '" + CmbUnitType.SelectedValue.ToString + "' WHERE [Product ID]= '" + TxtProductID.Text + "'"

                        cmd.ExecuteNonQuery()
                        con.Close()
                    End If



                    'Refresh Data
                    'RefreshData()

                    ' Focus on Cmb Product GroupID 
                    TxtSerialNumber.Focus()


                End If




            ElseIf TxtProductID.Text = "" Then




                Dim con2 As New SqlConnection
                Dim cmd2 As New SqlCommand
                Dim dr2 As SqlDataReader
                Dim q As MsgBoxResult


                con2.ConnectionString = FrmHome.ConnectionString
                con2.Open()
                cmd2.Connection = con2
                cmd2.CommandText = "SELECT * from [Products]  WHERE [Product Name] = '" + Me.TxtProductName.Text + "'"

                dr2 = cmd2.ExecuteReader()
                dr2.Read()

                If dr2.HasRows Then



                    q = MsgBox("This Product Name Is Already Exist. Do You Want To Save?", MsgBoxStyle.YesNo, "Product Information")
                    If q = MsgBoxResult.Yes Then

                        'Save Data 
                        SaveCodeForInsertProductFromSerial()
                        ShowIDToProductID()
                    End If


                ElseIf Not dr2.HasRows Then


                    'Save data 
                    SaveCodeForInsertProductFromSerial()
                    ShowIDToProductID()


                End If





            End If
        Catch ex As Exception

        End Try
    End Sub
    Sub ShowIDToProductID()


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
            cmd2.CommandText = "SELECT top 1 [Product ID] FROM [Products] where [User Account ID]= '" + FrmHome.LblUserID.Text + "'  order by [Product ID] desc"

            dr1 = cmd2.ExecuteReader()
            dr1.Read()
            If dr1.HasRows Then


                TxtProductID.Text = (dr1.Item("Product ID").ToString)
            End If
            con2.Close()
            dr1.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    'Insert into Product Information

    Sub InsertIntoProductInformation()


        'Same id Twice insert restriction code
        If Not Me.TxtProductID.Text = "" Then
            MsgBox("This ID is already Exist.", MsgBoxStyle.Critical, "Product Information")


        Else



            Dim con2 As New SqlConnection
            Dim cmd2 As New SqlCommand
            Dim dr2 As SqlDataReader
            Dim q As MsgBoxResult


            con2.ConnectionString = FrmHome.ConnectionString
            con2.Open()
            cmd2.Connection = con2
            cmd2.CommandText = "SELECT * from [Products]  WHERE [Product Name] = '" + Me.TxtProductName.Text + "'"

            dr2 = cmd2.ExecuteReader()
            dr2.Read()

            If dr2.HasRows Then



                q = MsgBox("This Product Name Is Already Exist. Do You Want To Save?", MsgBoxStyle.YesNo, "Product Information")
                If q = MsgBoxResult.Yes Then

                    'Save Data 
                    SaveCode()

                End If


            ElseIf Not dr2.HasRows Then


                'Save data 
                SaveCode()

            End If
            dr2.Close()
            con2.Close()
        End If


    End Sub


    Sub AddNewGroupCatSubcat()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim con2 As New SqlConnection
        Dim cmd2 As New SqlCommand
        Dim dr As SqlDataReader
  

        'Insert Product Group
        If Me.CmbProductGroupID.SelectedValue = 0 Then

            Try
                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "INSERT INTO [Product Group] ([Product Group Name],[User Account ID],[Computer ID]) VALUES ('" + CmbProductGroupID.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "')"
                cmd.ExecuteNonQuery()
                con.Close()

            Catch ex As Exception
                MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records on Product Group")
            End Try

            Try
                con2.ConnectionString = FrmHome.ConnectionString
                con2.Open()
                cmd2.Connection = con2
                cmd2.CommandText = "Select top 1  [Product Group ID] from [Product Group] where [User Account ID]='" + FrmHome.LblUserID.Text + "' And [Computer ID]='" + FrmHome.LblComputerID.Text + "' order by [Product Group ID] desc"
                dr = cmd2.ExecuteReader
                dr.Read()
                If dr.HasRows Then


                    LoadComboBoxProductGroup()

                    CmbProductGroupID.SelectedValue = dr.Item("Product Group ID").ToString
                End If
                dr.Close()
                con2.Close()

            Catch ex As Exception
                MessageBox.Show("Error while finding record from table..." & ex.Message, "Search Product Group")
            End Try


        End If


        'Insert Product Category
        If Me.CmbProductCategoryID.SelectedValue = 0 Then

            Try
                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "INSERT INTO [Product Category] ([Product Category Name],[User Account ID],[Computer ID]) VALUES ('" + CmbProductCategoryID.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "')"
                cmd.ExecuteNonQuery()
                con.Close()

            Catch ex As Exception
                MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records on Product Category")
            End Try

            Try
                con2.ConnectionString = FrmHome.ConnectionString
                con2.Open()
                cmd2.Connection = con2
                cmd2.CommandText = "Select top 1  [Product Category ID] from [Product Category] where [User Account ID]='" + FrmHome.LblUserID.Text + "' And [Computer ID]='" + FrmHome.LblComputerID.Text + "' order by [Product Category ID] desc"
                dr = cmd2.ExecuteReader
                dr.Read()
                If dr.HasRows Then


                    LoadComboBoxProductCategory()

                    CmbProductCategoryID.SelectedValue = dr.Item("Product Category ID").ToString
                End If
                dr.Close()
                con2.Close()

            Catch ex As Exception
                MessageBox.Show("Error while finding record from table..." & ex.Message, "Search Product Category")
            End Try


        End If


        'Insert Product SubCategory
        If Me.CmbProductSubcategoryID.SelectedValue = 0 Then

            Try
                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "INSERT INTO [Product Subcategory] ([Product Subcategory Name],[User Account ID],[Computer ID]) VALUES ('" + CmbProductSubcategoryID.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "')"
                cmd.ExecuteNonQuery()
                con.Close()

            Catch ex As Exception
                MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records on Product Subcategory")
            End Try

            Try
                con2.ConnectionString = FrmHome.ConnectionString
                con2.Open()
                cmd2.Connection = con2
                cmd2.CommandText = "Select top 1  [Product Subcategory ID] from [Product Subcategory] where [User Account ID]='" + FrmHome.LblUserID.Text + "' And [Computer ID]='" + FrmHome.LblComputerID.Text + "' order by [Product Subcategory ID] desc"
                dr = cmd2.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    LoadComboBoxProductSubcategory()

                    CmbProductSubcategoryID.SelectedValue = dr.Item("Product Subcategory ID").ToString
                End If
                dr.Close()
                con2.Close()

            Catch ex As Exception
                MessageBox.Show("Error while finding record from table..." & ex.Message, "Search Product Subcategory")
            End Try


        End If




    End Sub

    Sub SaveCode()

        'Inserting Data
        Dim con As New SqlConnection
        Dim con1 As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim dr As SqlDataReader

        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now



        Try

            'Empty Txt Box Can Not Be Save Code
            If Me.CmbProductCategoryID.Text = "" Or Me.CmbProductCategoryID.ValueMember = "" Or Me.CmbProductGroupID.Text = "" Or Me.CmbProductGroupID.ValueMember = "" Or Me.CmbProductSubcategoryID.Text = "" Or Me.CmbProductSubcategoryID.ValueMember = "" Or TxtProductName.Text = "" Then
                MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Product Information")

            Else

                AddNewGroupCatSubcat()




                If Not Me.ProductPictureBox.Image Is Nothing Then

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO Products ([Product Group ID],[Product Category ID],[Product Subcategory ID],[Product Name],[Barcode Serial],[Purchase Price],[Sale Price],[Wholesale Price],[Reorder Point],[Product Image],[Remarks],[User Account ID],[Computer ID],[Prepared Date],[Prepared Time],[Unit ID],[Discount Amount]) VALUES ('" + CmbProductGroupID.SelectedValue.ToString + "','" + CmbProductCategoryID.SelectedValue.ToString + "','" + CmbProductSubcategoryID.SelectedValue.ToString + "','" + TxtProductName.Text + "','" + TxtBarcodeSerial.Text + "','" + TxtPurchasePrice.Text + "','" + TxtSalePrice.Text + "','" + TxtWholeSalePrice.Text + "','" + TxtReorderPoint.Text + "',@test,'" + TxtRemarks.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + CmbUnitType.SelectedValue.ToString + "','" + TxtDiscountAmount.Text + "')"

                    Dim ms As New MemoryStream()
                    ProductPictureBox.Image.Save(ms, ProductPictureBox.Image.RawFormat)
                    Dim data As Byte() = ms.GetBuffer()
                    Dim p As New SqlParameter("@test", SqlDbType.Image)
                    p.Value = data
                    cmd.Parameters.Add(p)



                    cmd.ExecuteNonQuery()
                    con.Close()




                ElseIf Me.ProductPictureBox.Image Is Nothing Then

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO Products ([Product Group ID],[Product Category ID],[Product Subcategory ID],[Product Name],[Barcode Serial],[Purchase Price],[Sale Price],[Wholesale Price],[Reorder Point],[Remarks],[User Account ID],[Computer ID],[Prepared Date],[Prepared Time],[Unit ID],[Discount Amount]) VALUES ('" + CmbProductGroupID.SelectedValue.ToString + "','" + CmbProductCategoryID.SelectedValue.ToString + "','" + CmbProductSubcategoryID.SelectedValue.ToString + "','" + TxtProductName.Text + "','" + TxtBarcodeSerial.Text + "','" + TxtPurchasePrice.Text + "','" + TxtSalePrice.Text + "','" + TxtWholeSalePrice.Text + "','" + TxtReorderPoint.Text + "','" + TxtRemarks.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + CmbUnitType.SelectedValue.ToString + "','" + TxtDiscountAmount.Text + "')"

                    cmd.ExecuteNonQuery()
                    con.Close()
                End If




                cmd2.Connection = con
                con.Open()
                cmd2.CommandText = "Select *From [Products] where [User Account ID]='" + FrmHome.LblUserID.Text + "' And [Computer ID]='" + FrmHome.LblComputerID.Text + "' order by [Product ID] desc"

                dr = cmd2.ExecuteReader
                dr.Read()
                If dr.HasRows Then

                    ProductID = dr.Item("Product ID").ToString

                End If
                dr.Close()
                con.Close()


                If Not Val(TxtOpeningStock.Text) = 0 Then
                    'Inserting Stock to purchase
                    InsertIntoPurchaseForInsertNewProduct()
                End If


                'Insert Click Msg
                MsgBox("Data Inserted Successfully", MsgBoxStyle.OkOnly, "Product Information")



                'Insert into log 
                InsertIntoLog()

                'Making Clear
                ClearData()

                'Refresh Data
                RefreshData()

                ' Focus on Cmb Product GroupID 
                CmbProductGroupID.Focus()

            End If

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally


        End Try

    End Sub
    'Save Code

    Sub SaveCodeForInsertProductFromSerial()

        'Inserting Data
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand

        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now



        Try

            'Empty Txt Box Can Not Be Save Code
            If Me.CmbProductCategoryID.Text = "" Or Me.CmbProductCategoryID.ValueMember = "" Or Me.CmbProductGroupID.Text = "" Or Me.CmbProductGroupID.ValueMember = "" Or Me.CmbProductSubcategoryID.Text = "" Or Me.CmbProductSubcategoryID.ValueMember = "" Or TxtProductName.Text = "" Then
                MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Product Information")

            Else



                If Not Me.ProductPictureBox.Image Is Nothing Then

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO Products ([Product Group ID],[Product Category ID],[Product Subcategory ID],[Product Name],[Barcode Serial],[Purchase Price],[Sale Price],[Wholesale Price],[Reorder Point],[Product Image],[Remarks],[User Account ID],[Computer ID],[Prepared Date],[Prepared Time],[Unit ID]) VALUES ('" + CmbProductGroupID.SelectedValue.ToString + "','" + CmbProductCategoryID.SelectedValue.ToString + "','" + CmbProductSubcategoryID.SelectedValue.ToString + "','" + TxtProductName.Text + "','" + TxtBarcodeSerial.Text + "','" + TxtPurchasePrice.Text + "','" + TxtSalePrice.Text + "','" + TxtWholeSalePrice.Text + "','" + TxtReorderPoint.Text + "',@test,'" + TxtRemarks.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + CmbUnitType.SelectedValue.ToString + "')"

                    Dim ms As New MemoryStream()
                    ProductPictureBox.Image.Save(ms, ProductPictureBox.Image.RawFormat)
                    Dim data As Byte() = ms.GetBuffer()
                    Dim p As New SqlParameter("@test", SqlDbType.Image)
                    p.Value = data
                    cmd.Parameters.Add(p)



                    cmd.ExecuteNonQuery()
                    con.Close()




                ElseIf Me.ProductPictureBox.Image Is Nothing Then

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO Products ([Product Group ID],[Product Category ID],[Product Subcategory ID],[Product Name],[Barcode Serial],[Purchase Price],[Sale Price],[Wholesale Price],[Reorder Point],[Remarks],[User Account ID],[Computer ID],[Prepared Date],[Prepared Time],[Unit ID]) VALUES ('" + CmbProductGroupID.SelectedValue.ToString + "','" + CmbProductCategoryID.SelectedValue.ToString + "','" + CmbProductSubcategoryID.SelectedValue.ToString + "','" + TxtProductName.Text + "','" + TxtBarcodeSerial.Text + "','" + TxtPurchasePrice.Text + "','" + TxtSalePrice.Text + "','" + TxtWholeSalePrice.Text + "','" + TxtReorderPoint.Text + "','" + TxtRemarks.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + CmbUnitType.SelectedValue.ToString + "')"

                    cmd.ExecuteNonQuery()
                    con.Close()


                End If





                'Insert Click Msg
                'MsgBox("Data Inserted Successfully", MsgBoxStyle.OkOnly, "Product Information")



                'Making Clear
                'ClearData()

                'Refresh Data
                RefreshData()

                ' Focus on Cmb Product GroupID 
                TxtSerialNumber.Focus()

            End If

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally

        End Try

    End Sub


    'Creating Privet Sub For Clear Data
    Sub ClearDataAll()

        TxtProductID.Text = ""
        CmbProductGroupID.Text = ""
        CmbProductCategoryID.Text = ""
        CmbProductSubcategoryID.Text = ""
        TxtProductName.Text = ""
        TxtBarcodeSerial.Text = ""
        TxtReorderPoint.Text = ""
        TxtPurchasePrice.Text = ""
        TxtSalePrice.Text = ""
        TxtWholeSalePrice.Text = ""
        TxtDiscountAmount.Text = ""
        'CmbSearch.Text = ""
        'TxtSearch.Text = ""
        TxtRemarks.Text = ""
        TxtOpeningStock.Text = ""
        CmbUnitType.SelectedValue = 0
        Me.ProductPictureBox.Image = Nothing


        'Refresh Data Serial Number To Grid view For Cell Mouse Click
        RefreshDataSerialNumberToGridviewForCellMouseClick()


    End Sub

    'Creating Privet Sub For Clear Data
    Sub ClearData()

        TxtProductID.Text = ""
        CmbProductGroupID.Text = ""
        CmbProductCategoryID.Text = ""
        CmbProductSubcategoryID.Text = ""
        TxtProductName.Text = ""
        TxtBarcodeSerial.Text = ""
        TxtReorderPoint.Text = ""
        TxtPurchasePrice.Text = ""
        TxtSalePrice.Text = ""
        TxtWholeSalePrice.Text = ""
        TxtDiscountAmount.Text = ""
        'TxtSearch.Text = ""
        TxtRemarks.Text = ""
        TxtOpeningStock.Text = ""
        CmbUnitType.SelectedValue = 0
        Me.ProductPictureBox.Image = Nothing

    End Sub


    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        'Data Update Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        Dim currentDate As DateTime = DateTime.Today
        Dim CurrentTime As DateTime = DateTime.Now


        Try




            If Me.TxtProductID.Text = "" Then
                MsgBox("Please select a row.", MsgBoxStyle.OkOnly, "Product Information")


                'Empty Txt Box Can Not Be Save Code
            ElseIf Me.CmbProductCategoryID.Text = "" Or Me.CmbProductCategoryID.ValueMember = "" Or Me.CmbProductGroupID.Text = "" Or Me.CmbProductGroupID.ValueMember = "" Or Me.CmbProductSubcategoryID.Text = "" Or Me.CmbProductSubcategoryID.ValueMember = "" Or TxtProductName.Text = "" Then
                MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Product Information")

            Else




                If Not Me.ProductPictureBox.Image Is Nothing Then

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "UPDATE [Products] SET [Product Group ID]= '" + CmbProductGroupID.SelectedValue.ToString + "', [Product Category ID]= '" + CmbProductCategoryID.SelectedValue.ToString + "',[Product Subcategory ID] = '" + CmbProductSubcategoryID.SelectedValue.ToString + "',[Product Name]= '" + TxtProductName.Text + "',[Barcode Serial]= '" + TxtBarcodeSerial.Text + "',[Purchase Price]= '" + TxtPurchasePrice.Text + "',[Sale Price]= '" + TxtSalePrice.Text + "',[Wholesale Price]= '" + TxtWholeSalePrice.Text + "',[Reorder Point]= '" + TxtReorderPoint.Text + "',[Product Image]=@test,[Remarks]='" + TxtRemarks.Text + "',[User Account ID]= '" + FrmHome.LblUserID.Text + "',[Computer ID]= '" + FrmHome.LblComputerID.Text + "',[Unit ID]= '" + CmbUnitType.SelectedValue.ToString + "' ,[Discount Amount]= '" + TxtDiscountAmount.Text + "' WHERE [Product ID]= '" + TxtProductID.Text + "'  INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES ('" + Me.Text + "','UPDATE','Product ID: " + TxtProductID.Text + " ,Product Group ID: " + CmbProductGroupID.Text + " , Product Category ID: " + CmbProductCategoryID.Text + ",Product Subcategory ID: " + CmbProductSubcategoryID.Text + " ,Product Name: " + TxtProductName.Text + ",Barcode Serial: " + TxtBarcodeSerial.Text + ",Purchase Price: " + TxtPurchasePrice.Text + ",Sale Price: " + TxtSalePrice.Text + ",WholeSale Price: " + TxtWholeSalePrice.Text + ",Reorder Point: " + TxtReorderPoint.Text + ",Opening Stock: " + TxtOpeningStock.Text + ",Unit Type: " + CmbUnitType.Text + ",Remarks: " + TxtRemarks.Text + ",Serial Number: " + TxtSerialNumber.Text + ",Range Serial From: " + TxtFromSerial.Text + ",Range Serial To: " + TxtToSerial.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtProductID.Text + "' )"

                    Dim ms As New MemoryStream()
                    ProductPictureBox.Image.Save(ms, ProductPictureBox.Image.RawFormat)
                    Dim data As Byte() = ms.GetBuffer()
                    Dim p As New SqlParameter("@test", SqlDbType.Image)
                    p.Value = data
                    cmd.Parameters.Add(p)

                    cmd.ExecuteNonQuery()
                    con.Close()
                    If Not TxtOpeningStock.Text = "" Then

                        'Insert Into purchase invoice
                        InsertIntoPurchaseInvoice()

                        'Inserting Stock to purchase
                        InsertIntoPurchase()
                    End If

                ElseIf Me.ProductPictureBox.Image Is Nothing Then

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "UPDATE [Products] SET [Product Group ID]= '" + CmbProductGroupID.SelectedValue.ToString + "', [Product Category ID]= '" + CmbProductCategoryID.SelectedValue.ToString + "',[Product Subcategory ID] = '" + CmbProductSubcategoryID.SelectedValue.ToString + "',[Product Name]= '" + TxtProductName.Text + "',[Barcode Serial]= '" + TxtBarcodeSerial.Text + "',[Purchase Price]= '" + TxtPurchasePrice.Text + "',[Sale Price]= '" + TxtSalePrice.Text + "',[Wholesale Price]= '" + TxtWholeSalePrice.Text + "',[Reorder Point]= '" + TxtReorderPoint.Text + "',[Product Image]= '" + Nothing + "',[Remarks]='" + TxtRemarks.Text + "',[User Account ID]= '" + FrmHome.LblUserID.Text + "',[Computer ID]= '" + FrmHome.LblComputerID.Text + "',[Unit ID]= '" + CmbUnitType.SelectedValue.ToString + "', [Discount Amount]='" + TxtDiscountAmount.Text + "' WHERE [Product ID]= '" + TxtProductID.Text + "'    INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES ('" + Me.Text + "','UPDATE','Product ID: " + TxtProductID.Text + " ,Product Group ID: " + CmbProductGroupID.Text + " , Product Category ID: " + CmbProductCategoryID.Text + ",Product Subcategory ID: " + CmbProductSubcategoryID.Text + " ,Product Name: " + TxtProductName.Text + ",Barcode Serial: " + TxtBarcodeSerial.Text + ",Purchase Price: " + TxtPurchasePrice.Text + ",Sale Price: " + TxtSalePrice.Text + ",WholeSale Price: " + TxtWholeSalePrice.Text + ",Reorder Point: " + TxtReorderPoint.Text + ",Opening Stock: " + TxtOpeningStock.Text + ",Unit Type: " + CmbUnitType.Text + ",Remarks: " + TxtRemarks.Text + ",Serial Number: " + TxtSerialNumber.Text + ",Range Serial From: " + TxtFromSerial.Text + ",Range Serial To: " + TxtToSerial.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtProductID.Text + "' )"

                    cmd.ExecuteNonQuery()
                    con.Close()
                    If Not TxtOpeningStock.Text = "" Then

                        'Insert Into purchase invoice
                        InsertIntoPurchaseInvoice()

                        'Inserting Stock to purchase
                        InsertIntoPurchase()
                    End If

                End If

                'Update Click Msg
                MsgBox("Data Updated Successfully", MsgBoxStyle.OkOnly, "Product Information")

                'Making Clear
                ClearData()



                'Refresh Data
                'RefreshData()


                ' Focus on Cmb Product GroupID 
                CmbProductGroupID.Focus()

            End If
        Catch ex As Exception
            MessageBox.Show("Error while Updating record on table..." & ex.Message, "Update Records")
        Finally

        End Try
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If Me.TxtProductID.Text = "" Then
            MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Product Information")

        Else



            'Data Delete Code
            Dim q As MsgBoxResult
            q = MsgBox("Do you really want to Delete the row?", MsgBoxStyle.YesNo, "Products Information")
            If q = MsgBoxResult.Yes Then

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand

                Try
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "Delete from [Products] where [Product ID]= '" + TxtProductID.Text + "'"
                    cmd.ExecuteNonQuery()
                    con.Close()

                    'Making Clear
                    ClearData()


                    'Refresh Data
                    RefreshData()

                    ' Focus on Cmb Product GroupID 
                    CmbProductGroupID.Focus()

                Catch ex As Exception
                    MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Records")
                Finally
                    con.Close()
                End Try


            End If

        End If
    End Sub



    Private Sub CmbProductGroup_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbProductGroupID.KeyDown
        'Focus on  Product category
        If (e.KeyCode And Not Keys.Modifiers) = Keys.F AndAlso e.Modifiers = Keys.Control Then

            FrmListofProductGroups.Show()
            FrmListofProductGroups.TxtSearchGroup.Focus()
            FrmListofProductGroups.Label1.Text = "Product Information"
        ElseIf e.KeyCode = Keys.Enter Then
            CmbProductCategoryID.Focus()
        End If



    End Sub





    Private Sub CmbProductGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbProductGroupID.SelectedIndexChanged

    End Sub

    Private Sub CmbProductCategory_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbProductCategoryID.KeyDown

        If (e.KeyCode And Not Keys.Modifiers) = Keys.F AndAlso e.Modifiers = Keys.Control Then
            FrmListofProductCategories.Show()
            FrmListofProductCategories.TxtSearchCategory.Focus()
            FrmListofProductCategories.Label1.Text = "Product Information"
        ElseIf e.KeyCode = Keys.Enter Then
            CmbProductSubcategoryID.Focus()
        End If




    End Sub



    Private Sub CmbProductCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbProductCategoryID.SelectedIndexChanged

    End Sub

    Private Sub CmbProductSubcategory_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbProductSubcategoryID.KeyDown
        If (e.KeyCode And Not Keys.Modifiers) = Keys.F AndAlso e.Modifiers = Keys.Control Then
            FrmListofProductSubcategories.Show()
            FrmListofProductSubcategories.TxtSearchProductsSubcategories.Focus()
            FrmListofProductSubcategories.Label1.Text = "Product Information"
        ElseIf e.KeyCode = Keys.Enter Then
            TxtProductName.Focus()
        End If



    End Sub



    Private Sub CmbProductSubcategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbProductSubcategoryID.SelectedIndexChanged

    End Sub

    Private Sub TxtProductName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtProductName.KeyDown
        'Focus on  Barcode Serial
        If e.KeyCode = Keys.Enter Then
            Me.TxtBarcodeSerial.Focus()

        End If
    End Sub

    Private Sub TxtProductName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtProductName.TextChanged

    End Sub

    Private Sub TxtBarcodeSerial_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBarcodeSerial.KeyDown
        'Focus on  purchase price
        If e.KeyCode = Keys.Enter Then
            Me.TxtPurchasePrice.Focus()


        End If
    End Sub

    Private Sub TxtBarcodeSerial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBarcodeSerial.TextChanged

    End Sub

    Private Sub TxtPurchasePrice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'Focus on  Sale Price
        If e.KeyCode = Keys.Enter Then
            Me.TxtSalePrice.Focus()
        End If
    End Sub

    Private Sub TxtPurchasePrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtSalePrice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSalePrice.KeyDown
        'Focus on Whole sale Price
        If e.KeyCode = Keys.Enter Then
            Me.TxtWholeSalePrice.Focus()
        End If
    End Sub

    Private Sub TxtSalePrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSalePrice.TextChanged

    End Sub

    Private Sub TxtWholeSalePrice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtWholeSalePrice.KeyDown
        'Focus on Reorder point
        If e.KeyCode = Keys.Enter Then
            Me.TxtReorderPoint.Focus()
        End If
    End Sub

    Private Sub TxtWholeSalePrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtWholeSalePrice.TextChanged

    End Sub

    Private Sub CmbSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbSearch.KeyDown
        'Focus on Search Text Box
        If e.KeyCode = Keys.Enter Then
            Me.TxtSearch.Focus()
        End If
    End Sub

    Private Sub CmbSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSearch.SelectedIndexChanged


        If CmbSearch.Text = "Product  ID" Then

            TxtSearch.Visible = True
            CmbProductGroupSearch.Visible = False
            CmbProductCategorySearch.Visible = False
            CmbProductSubcategorySearch.Visible = False
            TxtSearch.Focus()

        ElseIf CmbSearch.Text = "Product Name" Then

            TxtSearch.Visible = True
            CmbProductGroupSearch.Visible = False
            CmbProductCategorySearch.Visible = False
            CmbProductSubcategorySearch.Visible = False
            TxtSearch.Focus()

        ElseIf CmbSearch.Text = "Product Group" Then


            TxtSearch.Visible = False
            CmbProductGroupSearch.Visible = True
            CmbProductCategorySearch.Visible = False
            CmbProductSubcategorySearch.Visible = False
            CmbProductGroupSearch.Focus()
        ElseIf CmbSearch.Text = "Product Category" Then

            TxtSearch.Visible = False
            CmbProductGroupSearch.Visible = False
            CmbProductCategorySearch.Visible = True
            CmbProductSubcategorySearch.Visible = False
            CmbProductCategorySearch.Focus()

        ElseIf CmbSearch.Text = "Product Subcategory" Then

            TxtSearch.Visible = False
            CmbProductGroupSearch.Visible = False
            CmbProductCategorySearch.Visible = False
            CmbProductSubcategorySearch.Visible = True
            CmbProductSubcategorySearch.Focus()

        ElseIf CmbSearch.Text = "Barcode Serial" Then

            TxtSearch.Visible = True
            CmbProductGroupSearch.Visible = False
            CmbProductCategorySearch.Visible = False
            CmbProductSubcategorySearch.Visible = False
            TxtSearch.Focus()

        End If

    End Sub

    Private Sub FrmProductInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
                BtnUpdate.Enabled = True

            ElseIf Not dr.HasRows Then
                BtnDelete.Enabled = False
                BtnUpdate.Enabled = False



            End If
            dr.Close()

            'Permission For Show Purchase Price
            dr1 = cmd1.ExecuteReader()
            dr1.Read()

            If Not dr1.HasRows Then


                TxtPurchasePrice.PasswordChar = "*"

            End If
            dr1.Close()
            con.Close()



        Catch ex As Exception
            MessageBox.Show("Error while  permission delete to form..." & ex.Message, "Form Load")

        End Try




        'Change Language
        ChangeLanguage()

        'Load combobx unit information
        LoadComboBoxUnitInformation()
        LoadComboBoxProductGroup()
        LoadComboBoxProductCategory()
        LoadComboBoxProductSubcategory()
        Me.CmbProductGroupID.Focus()
    End Sub

    Sub LoadComboBoxProductGroup()


        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            con.ConnectionString = FrmHome.ConnectionString

            Dim strSQL As String = "SELECT [Product Group ID],[Product Group Name] FROM [Product Group]"
            Dim da As New System.Data.SqlClient.SqlDataAdapter(strSQL, con)
            Dim ds As New DataSet
            da.Fill(ds, "[Product Group]")

            With Me.CmbProductGroupID
                .DataSource = ds.Tables("[Product Group]")
                .ValueMember = "Product Group ID"
                .DisplayMember = "Product Group Name"
            End With
            con.Close()

            'Supplier Category clear code
            CmbProductGroupID.SelectedValue = 0

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub LoadComboBoxProductCategory()


        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            con.ConnectionString = FrmHome.ConnectionString

            Dim strSQL As String = "SELECT [Product Category ID],[Product Category Name] FROM [Product Category]"
            Dim da As New System.Data.SqlClient.SqlDataAdapter(strSQL, con)
            Dim ds As New DataSet
            da.Fill(ds, "[Product Category]")

            With Me.CmbProductCategoryID
                .DataSource = ds.Tables("[Product Category]")
                .ValueMember = "Product Category ID"
                .DisplayMember = "Product Category Name"
            End With
            con.Close()

            'Supplier Category clear code
            CmbProductCategoryID.SelectedValue = 0

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub LoadComboBoxProductSubcategory()


        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            con.ConnectionString = FrmHome.ConnectionString

            Dim strSQL As String = "SELECT [Product Subcategory ID],[Product Subcategory Name] FROM [Product Subcategory]"
            Dim da As New System.Data.SqlClient.SqlDataAdapter(strSQL, con)
            Dim ds As New DataSet
            da.Fill(ds, "[Product Subcategory]")

            With Me.CmbProductSubcategoryID
                .DataSource = ds.Tables("[Product Subcategory]")
                .ValueMember = "Product Subcategory ID"
                .DisplayMember = "Product Subcategory Name"
            End With
            con.Close()

            'Supplier Category clear code
            CmbProductSubcategoryID.SelectedValue = 0

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TxtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearch.KeyDown
        'Focus on Product Information
        If e.KeyCode = Keys.Enter Then


            Try



                'Search Code
                ' Load Data
                

                Dim connectionString As String = FrmHome.ConnectionString
                If Me.CmbSearch.SelectedIndex = 0 Then
                    Dim sql As String = "SELECT [Products].[Product ID],[Products].[Product Name],[Product Category].[Product Category Name], [Product Group].[Product Group Name],[Products].[Barcode Serial],[Products].[Purchase Price],[Product SubCategory].[Product SubCategory Name],[Products].[Sale Price],[Products].[Wholesale Price],[Products].[Reorder Point],[Products].[Remarks],[Unit Information].[Unit Name],[Products].[Discount Amount]  FROM [Products] Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID] Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID] Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID] Left join [Unit Information] on [products].[Unit ID]=[Unit Information].[Unit ID] WHERE ([Products].[Product ID] = '" + Me.TxtSearch.Text + "')"

                    Dim connection As New SqlConnection(connectionString)

                    Dim dataadapter As New SqlDataAdapter(sql, connection)
                    Dim ds As New DataSet()
                    connection.Open()
                    dataadapter.Fill(ds, "BizPro_Products")
                    connection.Close()
                    GrdProductInformation.DataSource = ds
                    GrdProductInformation.DataMember = "BizPro_Products"
                    GrdProductInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                    'Row Count
                    NUmberOfRow()



                ElseIf Me.CmbSearch.SelectedIndex = 5 Then


                    Dim sql As String = "SELECT [Products].[Product ID],[Products].[Product Name],[Product Category].[Product Category Name], [Product Group].[Product Group Name],[Products].[Barcode Serial],[Products].[Purchase Price],[Product SubCategory].[Product SubCategory Name],[Products].[Sale Price],[Products].[Wholesale Price],[Products].[Reorder Point],[Products].[Remarks],[Unit Information].[Unit Name],[Products].[Discount Amount]  FROM [Products] Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID] Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID] Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID] Left join [Unit Information] on [products].[Unit ID]=[Unit Information].[Unit ID] WHERE ([Products].[Barcode Serial] = '" + Me.TxtSearch.Text + "')"

                    Dim connection As New SqlConnection(connectionString)

                    Dim dataadapter As New SqlDataAdapter(sql, connection)
                    Dim ds As New DataSet()
                    connection.Open()
                    dataadapter.Fill(ds, "BizPro_Products")
                    connection.Close()
                    GrdProductInformation.DataSource = ds
                    GrdProductInformation.DataMember = "BizPro_Products"
                    GrdProductInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                    'Row Count
                    NUmberOfRow()





                End If


            Catch ex As Exception
                MessageBox.Show("Error while Searching record on table..." & ex.Message, "Search Records")
            Finally


            End Try

            'End Refresh Data



        End If
    End Sub
    Sub NUmberOfRow()

        'Total gridview line show in label code
        Dim total As String = 0

        total = GrdProductInformation.Rows.Count

        Me.Label15.Text = total


    End Sub
    Sub NUmberOfRowForSerial()

        'Total gridview line show in label code
        Dim total As String = 0

        total = GrdAvailableSerialNumber.Rows.Count

        Me.LblTotalSerial.Text = total


    End Sub
    'Creating Privet Sub of Refreshing Data
    Sub RefreshData()


        Try

            Dim command As New SqlCommand()
            Dim adapter As New SqlDataAdapter()
            Dim ds As New DataSet()
            Dim i As Integer = 0
            Dim sql As String = Nothing
            Dim connetionString As String = FrmHome.ConnectionString
            Dim connection As New SqlConnection(connetionString)
            
            Dim cmd As New SqlCommand()
            cmd.Connection = connection
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "SelectAllProducts"
            cmd.Connection.Open()
            cmd.ExecuteReader()
            cmd.Connection.Close()
            Dim adp As New SqlDataAdapter(cmd)
            Dim tb As New DataTable
            adp.Fill(tb)
            GrdProductInformation.DataSource = tb

            'Row count
            NUmberOfRow()

            'End Refresh Data
        Catch ex As Exception
            MessageBox.Show("Error while Showing record on table..." & ex.Message, "Showing Records")
        Finally


        End Try

        'End Refresh Data

    End Sub

    'Load Unit Information
    Sub LoadComboBoxUnitInformation()
        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            con.ConnectionString = FrmHome.ConnectionString

            Dim strSQL As String = "Select [Unit ID],[Unit Name] from [Unit Information] "
            Dim da As New System.Data.SqlClient.SqlDataAdapter(strSQL, con)
            Dim ds As New DataSet
            da.Fill(ds, "[Unit Information]")

            With Me.CmbUnitType
                .DataSource = ds.Tables("[Unit Information]")
                .ValueMember = "Unit ID"
                .DisplayMember = "Unit Name"
            End With
            con.Close()
            CmbUnitType.SelectedValue = 0


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearch.TextChanged
        Try



            'Search Code
            ' Load Data
           
            Dim connectionString As String = FrmHome.ConnectionString
            If Me.CmbSearch.SelectedIndex = 1 Then
                Dim sql As String = "SELECT Products.[Product ID],Products.[Product Name],[Product Group].[Product Group Name],[Product Category].[Product Category Name],[Product SubCategory].[Product SubCategory Name],Products.[Barcode Serial],Products.[Purchase Price],Products.[Sale Price],Products.[Wholesale Price],Products.[Reorder Point],[Products].[Remarks],[Unit Information].[Unit Name],[Products].[Discount Amount]  FROM [Products] Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID] Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID] Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID] Left join [Unit Information] on [products].[Unit ID]=[Unit Information].[Unit ID] WHERE ([Products].[Product Name]  Like '%" + Me.TxtSearch.Text + "%')"

                Dim connection As New SqlConnection(connectionString)

                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Products")
                connection.Close()
                GrdProductInformation.DataSource = ds
                GrdProductInformation.DataMember = "BizPro_Products"
                GrdProductInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                'Row Count
                NUmberOfRow()


            End If





        Catch ex As Exception
            MessageBox.Show("Error while searching records on table..." & ex.Message, "Search Records")
        Finally

        End Try
    End Sub

    Sub Search()

        Try



            'Search Code
            ' Load Data
         

            Dim connectionString As String = FrmHome.ConnectionString

            If Me.CmbSearch.SelectedIndex = 2 Then


                Dim sql As String = "SELECT Products.[Product ID],Products.[Product Name],[Product Group].[Product Group Name],[Product Category].[Product Category Name],[Product SubCategory].[Product SubCategory Name],Products.[Barcode Serial],Products.[Purchase Price],Products.[Sale Price],Products.[Wholesale Price],Products.[Reorder Point],[Products].[Remarks],[Unit Information].[Unit Name],[Products].[Discount Amount] FROM [Products] Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID] Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID] Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID] Left join [Unit Information] on [products].[Unit ID]=[Unit Information].[Unit ID] WHERE ([Product Group].[Product Group ID] = '" + CmbProductGroupSearch.ValueMember + "')"

                Dim connection As New SqlConnection(connectionString)

                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Products")
                connection.Close()
                GrdProductInformation.DataSource = ds
                GrdProductInformation.DataMember = "BizPro_Products"
                GrdProductInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                'Row Count
                NUmberOfRow()




            ElseIf Me.CmbSearch.SelectedIndex = 3 Then


                Dim sql As String = "SELECT Products.[Product ID],Products.[Product Name],[Product Group].[Product Group Name],[Product Category].[Product Category Name],[Product SubCategory].[Product SubCategory Name],Products.[Barcode Serial],Products.[Purchase Price],Products.[Sale Price],Products.[Wholesale Price],Products.[Reorder Point],[Products].[Remarks],[Unit Information].[Unit Name],[Products].[Discount Amount]  FROM [Products] Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID] Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID] Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID] Left join [Unit Information] on [products].[Unit ID]=[Unit Information].[Unit ID] WHERE ([Product Category].[Product Category ID] = '" + CmbProductCategorySearch.ValueMember + "')"

                Dim connection As New SqlConnection(connectionString)

                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Products")
                connection.Close()
                GrdProductInformation.DataSource = ds
                GrdProductInformation.DataMember = "BizPro_Products"
                GrdProductInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                'Row Count
                NUmberOfRow()




            ElseIf Me.CmbSearch.SelectedIndex = 4 Then


                Dim sql As String = "SELECT Products.[Product ID],Products.[Product Name],[Product Group].[Product Group Name],[Product Category].[Product Category Name],[Product SubCategory].[Product SubCategory Name],Products.[Barcode Serial],Products.[Purchase Price],Products.[Sale Price],Products.[Wholesale Price],Products.[Reorder Point],[Products].[Remarks] ,[Unit Information].[Unit Name],[Products].[Discount Amount]  FROM [Products] Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID] Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID] Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID] Left join [Unit Information] on [products].[Unit ID]=[Unit Information].[Unit ID] WHERE ([Product SubCategory].[Product SubCategory ID] = '" + Me.CmbProductSubcategorySearch.ValueMember + "')"

                Dim connection As New SqlConnection(connectionString)

                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Products")
                connection.Close()
                GrdProductInformation.DataSource = ds
                GrdProductInformation.DataMember = "BizPro_Products"
                GrdProductInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                'Row Count
                NUmberOfRow()
 

            End If

        Catch ex As Exception
            MessageBox.Show("Error while searching records on table..." & ex.Message, "Search Sub")
        Finally

        End Try


    End Sub

    'Search Opening old Purchase ID  and new purchase id  Inserted Product using old inserted product sub
    Sub SearchOpeningPurchaseIDForOldInsertedProduct()

        Dim con As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim dr1 As SqlDataReader

        Try

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd1.Connection = con
            cmd1.CommandText = "SELECT  *FROM [Purchase Invoice]  join [Purchase]  on [Purchase Invoice].[Purchase Invoice No]=[Purchase].[Purchase Invoice No]   WHERE [Status] = 'Opening" + FrmHome.lblBranchID.Text + "'  And [Branch ID]='" + FrmHome.lblBranchID.Text + "' And [Product ID] = '" + TxtProductID.Text + "'  or [Status] = 'Opening' And [Branch ID]='" + FrmHome.lblBranchID.Text + "' And [Product ID] = '" + TxtProductID.Text + "'"
            dr1 = cmd1.ExecuteReader()
            dr1.Read()

            If dr1.HasRows Then
                PurchaseInvoice = (dr1.Item("Purchase Invoice No").ToString)

            ElseIf Not dr1.HasRows Then
                'Search Opening Purchase ID For New Inserted Product
                SearchOpeningPurchaseIDForNewInsertedProduct()

            End If
            dr1.Close()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    'Search Opening Purchase ID For New Inserted Product
    Sub SearchOpeningPurchaseIDForNewInsertedProduct()

        Dim con As New SqlConnection
        Dim cmd1 As New SqlCommand
        Dim dr1 As SqlDataReader

        Try

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd1.Connection = con
            cmd1.CommandText = "SELECT  * FROM [Purchase Invoice] WHERE [Status] = 'Opening" + FrmHome.lblBranchID.Text + "'"
            dr1 = cmd1.ExecuteReader()
            dr1.Read()

            If dr1.HasRows Then
                PurchaseInvoice = (dr1.Item("Purchase Invoice No").ToString)

            End If
            dr1.Close()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub





    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        'Refreshing Data
        RefreshData()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)





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


                Me.TxtProductID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.CmbProductGroupID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.CmbProductCategoryID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.CmbProductSubcategoryID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtProductName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtBarcodeSerial.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtPurchasePrice.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtSalePrice.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtWholeSalePrice.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtReorderPoint.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtSearch.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtRemarks.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.CmbProductCategorySearch.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.CmbProductSubcategorySearch.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.CmbProductGroupSearch.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.CmbUnitType.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtOpeningStock.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtSerialNumber.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtFromSerial.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtToSerial.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtRemarks.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))

                Me.TxtOpeningStock.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))


                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

                Me.GrdProductInformation.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdProductInformation.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)

            End If
            'MsgBox(dr.Item("Language Font"))
            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            con.Close()
        End Try

        'End Language

    End Sub


    Private Sub GrdProductInformation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)


    End Sub


    Private Sub BtnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpload.Click
        Dim Getimage As Integer
        OpenFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*"
        Getimage = OpenFileDialog1.ShowDialog()
        If Getimage = Windows.Forms.DialogResult.OK Then
            ProductPictureBox.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub



    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        Me.ProductPictureBox.Image = Nothing

    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ProductPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductPictureBox.Click

    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub BtnSearch_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        Try



            'Search Code
            ' Load Data
            

            Dim connectionString As String = FrmHome.ConnectionString
            If Me.CmbSearch.SelectedIndex = 0 Then
                Dim sql As String = "SELECT Products.[Product ID],Products.[Product Name],[Product Group].[Product Group Name],[Product Category].[Product Category Name],[Product SubCategory].[Product SubCategory Name],Products.[Barcode Serial],Products.[Purchase Price],Products.[Sale Price],Products.[Wholesale Price],Products.[Reorder Point],Products.[Remarks],[Unit Information].[Unit Name] FROM [Products] Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID] Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID] Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID] Left join [Unit Information] on [products].[Unit ID]=[Unit Information].[Unit ID] WHERE ([Products].[Product ID] = '" + Me.TxtSearch.Text + "')"

                Dim connection As New SqlConnection(connectionString)

                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Products")
                connection.Close()
                GrdProductInformation.DataSource = ds
                GrdProductInformation.DataMember = "BizPro_Products"
                GrdProductInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                'Row Count
                NUmberOfRow()



            ElseIf Me.CmbSearch.SelectedIndex = 5 Then


                Dim sql As String = "SELECT Products.[Product ID],Products.[Product Name],[Product Group].[Product Group Name],[Product Category].[Product Category Name],[Product SubCategory].[Product SubCategory Name],Products.[Barcode Serial],Products.[Purchase Price],Products.[Sale Price],Products.[Wholesale Price],Products.[Reorder Point],Products.[Remarks],[Unit Information].[Unit Name] FROM [Products] Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID] Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID] Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID] Left join [Unit Information] on [products].[Unit ID]=[Unit Information].[Unit ID] WHERE ([Products].[Barcode Serial] = '" + Me.TxtSearch.Text + "')"

                Dim connection As New SqlConnection(connectionString)

                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Products")
                connection.Close()
                GrdProductInformation.DataSource = ds
                GrdProductInformation.DataMember = "BizPro_Products"
                GrdProductInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                'Row Count
                NUmberOfRow()





            End If


            'Search Group, category, subcategory
            Search()




        Catch ex As Exception
            MessageBox.Show("Error while searching records on table..." & ex.Message, "Search Records")
        Finally

        End Try
    End Sub

    Private Sub TxtReorderPoint_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtReorderPoint.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TxtOpeningStock.Focus()
        End If
    End Sub

    Private Sub TxtReorderPoint_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtReorderPoint.TextChanged

    End Sub

    Private Sub CmbProductGroupSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbProductGroupSearch.KeyDown
        'Focus on  Product category

        If e.KeyCode = Keys.Enter Then

            FrmListofProductGroups.Show()
            FrmListofProductGroups.TxtSearchGroup.Focus()
            FrmListofProductGroups.Label1.Text = "Search Product Information"


        End If

    End Sub

    Private Sub CmbProductGroupSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbProductGroupSearch.SelectedIndexChanged

    End Sub

    Private Sub CmbProductSubcategorySearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbProductSubcategorySearch.KeyDown


        If e.KeyCode = Keys.Enter Then

            FrmListofProductSubcategories.Show()
            'List of product Category search text box  Focus
            FrmListofProductSubcategories.TxtSearchProductsSubcategories.Focus()
            FrmListofProductSubcategories.Label1.Text = "Search Product Information"


        End If
    End Sub

    Private Sub CmbProductSubcategorySearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbProductSubcategorySearch.SelectedIndexChanged

    End Sub

    Private Sub CmbProductCategorySearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbProductCategorySearch.KeyDown

        If e.KeyCode = Keys.Enter Then

            FrmListofProductCategories.Show()
            FrmListofProductCategories.TxtSearchCategory.Focus()
            FrmListofProductCategories.Label1.Text = "Search Product Information"

        End If

    End Sub

    Private Sub CmbProductCategorySearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbProductCategorySearch.SelectedIndexChanged

    End Sub

    Private Sub BtnAddStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub TxtInitialStock_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtOpeningStock.KeyDown
        If e.KeyCode = Keys.Enter Then

            'Sub Insert For Add Opening Stock
            'InsertProductForAddOpeningStock()

            'Refresh Data Serial Number To Grid view For Cell Mouse Click
            'RefreshDataSerialNumberToGridviewForCellMouseClick()

            CmbUnitType.Focus()

        End If
    End Sub

    Private Sub TxtInitialStock_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtOpeningStock.TextChanged

    End Sub

    'Insert Into Purchase Invoice code
    Sub InsertIntoPurchaseInvoice()


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
            cmd2.CommandText = "SELECT * FROM [Purchase Invoice] where [Status]= 'Opening" + FrmHome.lblBranchID.Text + "'"

            dr1 = cmd2.ExecuteReader()
            dr1.Read()


            If Not dr1.HasRows Then

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "INSERT INTO [Purchase Invoice] ([Memo No],[Total],[Previous Dues],[Advance],[Vat percentage],[Vat],[Discount Percentage],[Discount],[Net Payable],[Paid Amount],[Balance],[Return Amount],[Status],[Supplier ID],[Purchase Date],[Purchase Time],[User Account ID],[Computer ID],[Paid By],[Prepared Date]) values ('00','00','00','00','00','00','00','00','00','00','00','00','Opening" + FrmHome.lblBranchID.Text + "','1','" + currentDate + "','" + currentTime + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','00','" + currentDate + "')"
                cmd.ExecuteNonQuery()
                con.Close()



              
            End If
            con2.Close()
            dr1.Close()

        Catch ex As Exception
            MessageBox.Show("Error while Inserting to Purchase invoice record on table..." & ex.Message, "Insert Records Purchase Invoice")
        Finally

        End Try



    End Sub

    'Inserting Stock to purchase
    Sub InsertIntoPurchase()


        Try





            'Refresh Data For Single Serial
            'RefreshDataForRangeSerial()

            'Data Insert Code
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now


            Dim con2 As New SqlConnection
            Dim cmd3 As New SqlCommand
            Dim dr3 As SqlDataReader

            Dim cmd4 As New SqlCommand
            Dim dr4 As SqlDataReader

            Dim LocationID As String

            con2.ConnectionString = FrmHome.ConnectionString
            con2.Open()
            cmd3.Connection = con2
            cmd4.Connection = con2
            cmd4.CommandText = "SELECT top 1 [Location ID] FROM [Location Information] Where [Branch ID]='" + FrmHome.lblBranchID.Text + "'  order by [Location ID] Asc"

            dr4 = cmd4.ExecuteReader()
            dr4.Read()
            If dr4.HasRows Then
                LocationID = dr4.Item("Location ID").ToString
            End If
            dr4.Close()




            'Search Opening old Purchase ID  and new purchase id  Inserted Product using old inserted product sub
            SearchOpeningPurchaseIDForOldInsertedProduct()


            'If Purchase id not found then block insert to purchase
            If Not Val(PurchaseInvoice) = 0 Then

                cmd3.CommandText = "SELECT * FROM [Purchase Invoice] join [Purchase] on [Purchase Invoice].[Purchase Invoice No]=[Purchase].[Purchase Invoice No]  WHERE [Status] = 'Opening" + FrmHome.lblBranchID.Text + "' And [Purchase].[Product ID] = '" + TxtProductID.Text + "'  And [Branch ID]= '" + FrmHome.lblBranchID.Text + "' or [Status] ='Opening'  And [Branch ID]= '" + FrmHome.lblBranchID.Text + "' And [Product ID] = '" + TxtProductID.Text + "'"
                dr3 = cmd3.ExecuteReader()
                dr3.Read()



                Dim TotalAmount As String
                TotalAmount = Val(TxtPurchasePrice.Text) * Val(TxtOpeningStock.Text)

                If Not dr3.HasRows Then

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO [Purchase] ([Purchase Invoice No],[Product ID],[Purchase Location ID],[Purchase Quantity],[Purchase Unit Cost],[Amount],[Branch ID],[Computer ID],[User Account ID],[Purchase Date],[Purchase Serial Number],[Warranty Days]) VALUES ('" + PurchaseInvoice + "','" + TxtProductID.Text + "','" + LocationID + "','" + TxtOpeningStock.Text + "','" + TxtPurchasePrice.Text + "','" + TotalAmount + "','" + FrmHome.lblBranchID.Text + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + currentDate + "','00','00')"
                    cmd.ExecuteNonQuery()
                    con.Close()
                ElseIf dr3.HasRows Then

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "Update [Purchase] set [Purchase Quantity]='" + TxtOpeningStock.Text + "',[Purchase Unit Cost]='" + TxtPurchasePrice.Text + "',[Amount]='" + TotalAmount + "' where Purchase.[Product ID]='" + TxtProductID.Text + "' And [Purchase].[Purchase Invoice No]= '" + PurchaseInvoice + "' And [Branch ID]= '" + FrmHome.lblBranchID.Text + "'"
                    cmd.ExecuteNonQuery()
                    con.Close()
                End If
                dr3.Close()
                con2.Close()
            End If


        Catch ex As Exception
            MessageBox.Show("Error while Inserting to Purchase invoice record on table..." & ex.Message, "Insert Records Purchase")
        Finally

        End Try


    End Sub

    'Inserting Stock to purchase
    Sub InsertIntoPurchaseForInsertNewProduct()


        Try

            'Insert Into Purchase Invoice code
            InsertIntoPurchaseInvoice()


            'Data Insert Code
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now


            Dim con2 As New SqlConnection

            Dim cmd3 As New SqlCommand
            Dim dr3 As SqlDataReader

            Dim cmd4 As New SqlCommand
            Dim dr4 As SqlDataReader

            Dim LocationID As String

            con2.ConnectionString = FrmHome.ConnectionString
            con2.Open()
            cmd3.Connection = con2
            cmd4.Connection = con2
            cmd4.CommandText = "SELECT top 1 [Location ID] FROM [Location Information]   order by [Location ID] Asc"

            dr4 = cmd4.ExecuteReader()
            dr4.Read()
            If dr4.HasRows Then

                LocationID = dr4.Item("Location ID").ToString

            End If
            dr4.Close()



            'Search Opening old Purchase ID  and new purchase id  Inserted Product using old inserted product sub
            SearchOpeningPurchaseIDForOldInsertedProduct()






            cmd3.CommandText = "SELECT  *FROM [Purchase Invoice]  join [Purchase]  on [Purchase Invoice].[Purchase Invoice No]=[Purchase].[Purchase Invoice No]   WHERE [Status] = 'Opening" + FrmHome.lblBranchID.Text + "'  And [Branch ID]='" + FrmHome.lblBranchID.Text + "' And [Product ID] = '" + TxtProductID.Text + "'  or [Status] = 'Opening' And [Branch ID]='" + FrmHome.lblBranchID.Text + "' And [Product ID] = '" + TxtProductID.Text + "'"
            dr3 = cmd3.ExecuteReader()
            dr3.Read()

            If TxtOpeningStock.Text = "" Then
                MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Product Information")


            Else

                Dim TotalAmount As String
                TotalAmount = Val(TxtPurchasePrice.Text) * Val(TxtOpeningStock.Text)

                If Not dr3.HasRows Then

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO [Purchase] ([Purchase Invoice No],[Product ID],[Purchase Location ID],[Purchase Quantity],[Purchase Unit Cost],[Amount],[Branch ID],[Computer ID],[User Account ID],[Purchase Date],[Purchase Serial Number],[Warranty Days]) VALUES ('" + PurchaseInvoice + "','" + ProductID + "','" + LocationID + "','" + TxtOpeningStock.Text + "','" + TxtPurchasePrice.Text + "','" + TotalAmount + "','" + FrmHome.lblBranchID.Text + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + currentDate + "','00','00')"
                    cmd.ExecuteNonQuery()
                    con.Close()
                ElseIf dr3.HasRows Then

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "Update [Purchase] set [Purchase Quantity]='" + TxtOpeningStock.Text + "',[Purchase Unit Cost]='" + TxtPurchasePrice.Text + "',[Amount]='" + TotalAmount + "' where Purchase.[Product ID]='" + ProductID + "' And [Purchase].[Purchase Invoice No]= '" + PurchaseInvoice + "' And [Branch ID]= '" + FrmHome.lblBranchID.Text + "'"
                    cmd.ExecuteNonQuery()
                    con.Close()

                End If
                
            End If
            dr3.Close()
            con2.Close()

        Catch ex As Exception
            MessageBox.Show("Error while Inserting to Purchase invoice record on table..." & ex.Message, "Insert Records Purchase")
        Finally

        End Try


    End Sub

    Private Sub TxtSerialNumber_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSerialNumber.KeyDown


        If e.KeyCode = Keys.Enter Then


            If Me.CmbProductCategoryID.Text = "" Or Me.CmbProductCategoryID.ValueMember = "" Or Me.CmbProductGroupID.Text = "" Or Me.CmbProductGroupID.ValueMember = "" Or Me.CmbProductSubcategoryID.Text = "" Or Me.CmbProductSubcategoryID.ValueMember = "" Or TxtProductName.Text = "" Then
                MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Product Information")

            Else
                'Sub update From Serial Add
                UpdateorInserttoProductFromSerialAdd()


                'Insert Into Prucchase and purchase Invoice
                InsertIntoPurchaseInvoice()

                'If Purchase id not found then block insert to purchase
                If Not Val(PurchaseInvoice) = 0 Then

                    'Insert Into  Single Serial Number
                    InsertIntoSingleSerialNumber()



                    'Opening Stock count By serial insert
                    TxtOpeningStock.Text = GrdAvailableSerialNumber.RowCount


                    'Insert into purchase
                    InsertIntoPurchase()

                End If


                TxtSerialNumber.Text = ""
                TxtSerialNumber.Focus()




            End If
        End If

    End Sub
    'Insert Into Purchase And  Serial Number
    Sub InsertIntoPurchaseSerialNumber()

        Try
            'Data Insert Code
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand


            Dim total As String = 0


            Dim con3 As New SqlConnection
            Dim cmd3 As New SqlCommand
            Dim dr3 As SqlDataReader

            con3.ConnectionString = FrmHome.ConnectionString
            con3.Open()
            cmd3.Connection = con3
            cmd3.CommandText = "SELECT *from [Purchase Serial Number] where [Product ID]= '" + TxtProductID.Text + "'  And RIGHT([Purchase Serial Number].[Purchase Serial Number], 4)  Between '" + LastFromValue + "' And '" + LastToValue + "'  And [Purchase Invoice No]='" + PurchaseInvoice + "' "

            dr3 = cmd3.ExecuteReader()
            dr3.Read()

            If Not dr3.HasRows Then

                For i As Integer = 0 To GrdAvailableSerialNumber.RowCount - 1
                    total += GrdAvailableSerialNumber.Rows(i).Cells(0).Value

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO [Purchase Serial Number] ([Product ID],[Purchase Invoice No],[Purchase Serial Number],[Status],[Branch ID]) values ('" + TxtProductID.Text + "', '" + PurchaseInvoice + "' ,'" + FirstValue + "" + GrdAvailableSerialNumber.Rows(i).Cells(0).Value.ToString + "' ,'Available','" + FrmHome.lblBranchID.Text + "')"
                    cmd.ExecuteNonQuery()
                    con.Close()

                Next
                RdbRangeSerial.Checked = False

            Else
                MsgBox("This Serial Number Already exists", MsgBoxStyle.OkOnly, "Purchase")

            End If


            dr3.Close()
            con3.Close()


            'Refresh Data Serial Number To Grid view For Cell Mouse Click
            RefreshDataSerialNumberToGridviewForCellMouseClick()


        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Into Purchase Serial")
        Finally

        End Try




    End Sub
    'Insert Into Purchase And  Serial Number
    Sub InsertIntoSingleSerialNumber()

        Try
            'Data Insert Code
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand




            Dim con3 As New SqlConnection
            Dim cmd3 As New SqlCommand
            Dim dr3 As SqlDataReader

            con3.ConnectionString = FrmHome.ConnectionString
            con3.Open()
            cmd3.Connection = con3
            cmd3.CommandText = "SELECT *from [Purchase Serial Number] where [Product ID]= '" + TxtProductID.Text + "' And [Purchase Serial Number]='" + TxtSerialNumber.Text + "'  "

            dr3 = cmd3.ExecuteReader()
            dr3.Read()


            If Not dr3.HasRows Then
                If Not TxtSerialNumber.Text = "" Then

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO [Purchase Serial Number] ([Product ID],[Purchase Invoice No],[Purchase Serial Number],[Status],[Branch ID]) values ('" + TxtProductID.Text + "', '" + PurchaseInvoice + "' ,'" + TxtSerialNumber.Text + "' ,'Available','" + FrmHome.lblBranchID.Text + "')"
                    cmd.ExecuteNonQuery()
                    con.Close()

                End If
                RdbRangeSerial.Checked = False

            Else
                MsgBox("This Serial Number Already exists", MsgBoxStyle.OkOnly, "Purchase")

            End If


            dr3.Close()
            con3.Close()


            'Refresh Data Serial Number To Grid view For Cell Mouse Click
            RefreshDataSerialNumberToGridviewForCellMouseClick()


        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Into Single Purchase Serial")
        Finally

        End Try




    End Sub

    'Refresh Data Serial Number To Gridview Click
    Sub RefreshDataSerialNumberToGridviewForCellMouseClick()

        'Load Data

        Try

            
            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT   [Purchase Serial Number].[Purchase Serial Number] FROM [Purchase Serial Number] WHERE [Purchase Invoice No] = '" + PurchaseInvoice + "' And [Product ID]= '" + TxtProductID.Text + "' And [Branch ID]= '" + FrmHome.lblBranchID.Text + "' "
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
            

            ' Count Total Serial number
            NUmberOfRowForSerial()




        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Data Serial Number To Gridview")
        Finally

        End Try

        'End Refresh Data
    End Sub

    Private Sub TxtSerialNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSerialNumber.TextChanged
        'Change all text entered to be Upercase.
        TxtSerialNumber.CharacterCasing = CharacterCasing.Upper
    End Sub


    Sub InsertRangeSerialNumber()

        Try


            'Find the first section of the Textbox

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

                'Insert Into Purchase And  Serial Number
                InsertIntoPurchaseSerialNumber()


                TxtFromSerial.Text = ""
                TxtToSerial.Text = ""

            ElseIf Not dr1.HasRows Then


                'Insert New Single Serial Number
                InsertNewRangeSerialNumber()

                ' Refresh Data For Single Serial
                RefreshDataForRangeSerial()

                'Insert Into Purchase And  Serial Number
                InsertIntoPurchaseSerialNumber()

                TxtFromSerial.Text = ""
                TxtToSerial.Text = ""
            End If





            dr1.Close()
            con2.Close()

        Catch ex As Exception
            MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Insert Range Serial")
        Finally

        End Try

    End Sub

    'Refresh Data For Single Serial
    Sub RefreshDataForRangeSerial()

        Try
            ' Load Data
            
            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT RIGHT('000'+CAST([Serial No].[Serial Number]AS VARCHAR(4)),4)[Purchase Serial Number]  from [Serial No] where [Serial Number] between  " + LastFromValue + " and " + LastToValue + ""
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

            ' Count Total Serial number
            NUmberOfRowForSerial()

             

        Catch ex As Exception
            MessageBox.Show("Error while refreshing record on table..." & ex.Message, "Refresh Records")
        Finally
        End Try

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
    'Insert New Serial Number

    Sub InsertNewRangeSerialNumber()

        Try

            'Data Insert Code
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now

            If Not TxtOpeningStock.Text = "" And Not TxtFromSerial.Text = "" And Not TxtToSerial.Text = "" Then

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "DECLARE @num bigint = '" + LastFromValue + "'  WHILE(@num<='" + LastToValue + "')   begin INSERT  INTO [Serial No]   ([Serial Number]) VALUES (@num)   SET @num = @num + 1 end"

                cmd.ExecuteNonQuery()


                con.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Error while Selecting All record on table..." & ex.Message, "Select all Button")
        Finally
        End Try


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



    Private Sub GrdAvailableSerialNumber_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdAvailableSerialNumber_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

    End Sub

    Private Sub GrdAvailableSerialNumber_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)



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

    Private Sub TxtToSerial_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtToSerial.KeyDown
        If e.KeyCode = Keys.Enter Then


            If Me.CmbProductCategoryID.Text = "" Or Me.CmbProductCategoryID.ValueMember = "" Or Me.CmbProductGroupID.Text = "" Or Me.CmbProductGroupID.ValueMember = "" Or Me.CmbProductSubcategoryID.Text = "" Or Me.CmbProductSubcategoryID.ValueMember = "" Or TxtProductName.Text = "" Or TxtOpeningStock.Text = "" Then
                MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Product Information")

            Else
                'Sub Update For Add Opening Stock
                UpdateorInserttoProductFromSerialAdd()

                'Insert Into Prucchase and purchase Invoice
                InsertIntoPurchaseInvoice()

                'Insert Range Serial Number
                InsertRangeSerialNumber()

                'Opening Stock count By serial insert
                TxtOpeningStock.Text = GrdAvailableSerialNumber.RowCount

                'Insert into purchase
                InsertIntoPurchase()

                'Refresh Data Serial Number To Gridview Click
                RefreshDataSerialNumberToGridviewForCellMouseClick()



            End If
        End If
    End Sub
    Private Sub TxtToSerial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtToSerial.TextChanged
        'Change all text entered to be Upercase.
        TxtToSerial.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub TxtFromSerial_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtFromSerial.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtToSerial.Focus()
        End If
    End Sub

    Private Sub TxtFromSerial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtFromSerial.TextChanged
        'Change all text entered to be Upercase.
        TxtFromSerial.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub TxtPurchasePrice_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPurchasePrice.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtSalePrice.Focus()
        End If
    End Sub

    Private Sub TxtPurchasePrice_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPurchasePrice.TextChanged

    End Sub

    Private Sub TxtRemarks_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtRemarks.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtSerialNumber.Focus()
        End If
    End Sub

    Private Sub TxtRemarks_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtRemarks.TextChanged

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

    Private Sub GrdProductInformation_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdProductInformation_CellFormatting1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)

    End Sub

    Private Sub GrdProductInformation_CellMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdAvailableSerialNumber.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdAvailableSerialNumber.CellMouseDoubleClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.GrdAvailableSerialNumber.Rows(e.RowIndex)

            Try






                Dim con As New SqlConnection
                Dim con1 As New SqlConnection
                Dim cmd As New SqlCommand
                Dim cmd2 As New SqlCommand
                Dim dr As SqlDataReader

                Dim currentDate As DateTime = DateTime.Today
                Dim currentTime As DateTime = DateTime.Now

                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd2.Connection = con1
                cmd2.CommandText = "SELECT   [Purchase Serial Number].[Purchase Serial Number] FROM [Purchase Serial Number] WHERE [Purchase Invoice No] = '" + PurchaseInvoice + "' And [Product ID]= '" + TxtProductID.Text + "'  And [Branch ID]='" + FrmHome.lblBranchID.Text + "' And [Status]='Available'  And [Purchase Serial Number]= '" + row.Cells("Purchase Serial Number").Value.ToString + "' "

                dr = cmd2.ExecuteReader
                dr.Read()

                If dr.HasRows Then

                    'Data Delete Code
                    Dim q As MsgBoxResult
                    q = MsgBox("Do you really want to Delete the row?", MsgBoxStyle.YesNo, "Products Information")
                    If q = MsgBoxResult.Yes Then

                        con.ConnectionString = FrmHome.ConnectionString
                        con.Open()
                        cmd.Connection = con
                        cmd.CommandText = "Delete from [Purchase Serial Number] where [Purchase Invoice No]= '" + PurchaseInvoice + "' And [Product ID]= '" + TxtProductID.Text + "' And [Purchase Serial Number]= '" + row.Cells("Purchase Serial Number").Value.ToString + "' "
                        cmd.ExecuteNonQuery()

                        con.Close()

                        'Refresh Data Serial Number To Gridview Click
                        RefreshDataSerialNumberToGridviewForCellMouseClick()

                        If Not Val(PurchaseInvoice) = 0 Then

                            'Opening Stock count By serial insert
                            TxtOpeningStock.Text = GrdAvailableSerialNumber.RowCount


                            'Insert into purchase
                            InsertIntoPurchase()

                        End If
                    End If

                Else
                    MsgBox("This serial is already sold.", MsgBoxStyle.OkOnly, "Product Information")
                End If
                dr.Close()
                con1.Close()


            Catch ex As Exception
                MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Records Purchase Serial")
            Finally


            End Try


        End If
    End Sub

    Private Sub CmbUnitType_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbUnitType.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtDiscountAmount.Focus()

        End If
    End Sub

    Private Sub CmbUnitType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbUnitType.SelectedIndexChanged

    End Sub



    Private Sub GrdProductInformation_CellContentClick_2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdProductInformation.CellContentClick

    End Sub

    Private Sub GrdProductInformation_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdProductInformation.CellEnter


        Try






            If e.RowIndex >= 0 Then


                Dim row As DataGridViewRow
                row = Me.GrdProductInformation.Rows(e.RowIndex)

                TxtProductID.Text = row.Cells("Product ID").Value.ToString
                CmbProductGroupID.Text = row.Cells("Product Group Name").Value.ToString
                CmbProductCategoryID.Text = row.Cells("Product Category Name").Value.ToString
                CmbProductSubcategoryID.Text = row.Cells("Product Subcategory Name").Value.ToString
                TxtProductName.Text = row.Cells("Product Name").Value.ToString
                TxtBarcodeSerial.Text = row.Cells("Barcode Serial").Value.ToString
                TxtPurchasePrice.Text = row.Cells("Purchase Price").Value.ToString
                TxtSalePrice.Text = row.Cells("Sale Price").Value.ToString
                TxtWholeSalePrice.Text = row.Cells("WholeSale Price").Value.ToString
                TxtReorderPoint.Text = row.Cells("Reorder Point").Value.ToString
                TxtRemarks.Text = row.Cells("Remarks").Value.ToString
                CmbUnitType.Text = row.Cells("Unit Name").Value.ToString
                TxtDiscountAmount.Text = row.Cells("Discount Amount").Value.ToString
                'TxtOpeningStock.Text = row.Cells("Initial Stock").Value.ToString


                'TxtSerialNumber.Focus()




                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim cmd2 As New SqlCommand
                Dim dr As SqlDataReader
                Dim dr2 As SqlDataReader


                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd2.Connection = con
                cmd.CommandText = "SELECT  *FROM [Products]  WHERE [Product ID] = " + Me.TxtProductID.Text + ""
                cmd2.CommandText = "SELECT  *FROM [Purchase Invoice] join [Purchase]  on [Purchase Invoice].[Purchase Invoice No]=[Purchase].[Purchase Invoice No]   WHERE [Status] = 'Opening" + FrmHome.lblBranchID.Text + "' And [Product ID] = '" + TxtProductID.Text + "'  And [Branch ID]= '" + FrmHome.lblBranchID.Text + "' or [Status] ='Opening'  And [Branch ID]= '" + FrmHome.lblBranchID.Text + "' And [Product ID] = '" + TxtProductID.Text + "'"

                dr2 = cmd2.ExecuteReader
                dr2.Read()
                If dr2.HasRows Then
                    TxtOpeningStock.Text = dr2.Item("Purchase Quantity").ToString
                Else
                    TxtOpeningStock.Text = "00"
                End If
                dr2.Close()



                'Search Opening old Purchase ID  and new purchase id  Inserted Product using old inserted product sub
                SearchOpeningPurchaseIDForOldInsertedProduct()


                dr = cmd.ExecuteReader()
                dr.Read()

                If dr.HasRows Then


                    Me.CmbProductGroupID.SelectedValue = (dr.Item("Product Group ID").ToString)
                    Me.CmbProductCategoryID.SelectedValue = (dr.Item("Product Category ID").ToString)
                    Me.CmbProductSubcategoryID.SelectedValue = (dr.Item("Product Subcategory ID").ToString)

                    Me.ProductPictureBox.Image = Nothing

                End If
                dr.Close()



                cmd.CommandText = "SELECT  *FROM [Products]  WHERE [Product ID] = " + Me.TxtProductID.Text + " AND [Product Image] IS NOT NULL"
                dr = cmd.ExecuteReader()
                dr.Read()

                Try


                    If dr.HasRows Then


                        Dim data As Byte() = DirectCast(dr("Product Image"), Byte())
                        Dim ms As New MemoryStream(data)
                        ProductPictureBox.Image = Image.FromStream(ms)
                    End If

                Catch ex As Exception

                End Try
                dr.Close()
                con.Close()

            End If

            'Refresh Data Serial Number To Gridview Click
            RefreshDataSerialNumberToGridviewForCellMouseClick()



        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

        End Try
    End Sub

    Private Sub GrdProductInformation_CellFormatting2(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles GrdProductInformation.CellFormatting

        'permission for update and Delete
        'Try

        '    Dim con As New SqlConnection
        '    Dim cmd As New SqlCommand
        '    Dim dr As SqlDataReader




        '    con.ConnectionString = FrmHome.ConnectionString
        '    con.Open()
        '    cmd.Connection = con
        '    cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + FrmHome.LblUserID.Text + "' AND [Category Name] = 'VIEW PRICE PERMISSION' And [Update Delete Permission]='YES'"


        '    dr = cmd.ExecuteReader()
        '    dr.Read()




        '    If Not dr.HasRows Then

        '        If GrdProductInformation.Columns(e.ColumnIndex).Name.Equals("Purchase Price") Then
        '            If (Not e.Value Is Nothing) Then
        '                e.Value = New String(CChar("*"), e.Value.ToString.Length)

        '            End If
        '        End If



        '    End If
        '    dr.Close()
        '    con.Close()




        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try


    End Sub

    Private Sub GrdProductInformation_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdProductInformation.CellLeave



    End Sub

    Private Sub GrdProductInformation_CellMouseClick2(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdProductInformation.CellMouseClick
        'Data Grid view code
        Try






            If e.RowIndex >= 0 Then


                Dim row As DataGridViewRow
                row = Me.GrdProductInformation.Rows(e.RowIndex)

                TxtProductID.Text = row.Cells("Product ID").Value.ToString
                CmbProductGroupID.Text = row.Cells("Product Group Name").Value.ToString
                CmbProductCategoryID.Text = row.Cells("Product Category Name").Value.ToString
                CmbProductSubcategoryID.Text = row.Cells("Product Subcategory Name").Value.ToString
                TxtProductName.Text = row.Cells("Product Name").Value.ToString
                TxtBarcodeSerial.Text = row.Cells("Barcode Serial").Value.ToString
                TxtPurchasePrice.Text = row.Cells("Purchase Price").Value.ToString
                TxtSalePrice.Text = row.Cells("Sale Price").Value.ToString
                TxtWholeSalePrice.Text = row.Cells("WholeSale Price").Value.ToString
                TxtReorderPoint.Text = row.Cells("Reorder Point").Value.ToString
                TxtRemarks.Text = row.Cells("Remarks").Value.ToString
                CmbUnitType.Text = row.Cells("Unit Name").Value.ToString
                TxtDiscountAmount.Text = row.Cells("Discount Amount").Value.ToString
                'TxtOpeningStock.Text = row.Cells("Initial Stock").Value.ToString


                'TxtSerialNumber.Focus()




                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim cmd2 As New SqlCommand
                Dim dr As SqlDataReader
                Dim dr2 As SqlDataReader


                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd2.Connection = con
                cmd.CommandText = "SELECT  *FROM [Products]  WHERE [Product ID] = " + Me.TxtProductID.Text + ""
                cmd2.CommandText = "SELECT  *FROM [Purchase Invoice] join [Purchase]  on [Purchase Invoice].[Purchase Invoice No]=[Purchase].[Purchase Invoice No]   WHERE [Status] = 'Opening" + FrmHome.lblBranchID.Text + "' And [Product ID] = '" + TxtProductID.Text + "'  And [Branch ID]= '" + FrmHome.lblBranchID.Text + "' or [Status] ='Opening'  And [Branch ID]= '" + FrmHome.lblBranchID.Text + "' And [Product ID] = '" + TxtProductID.Text + "'"

                dr2 = cmd2.ExecuteReader
                dr2.Read()
                If dr2.HasRows Then
                    TxtOpeningStock.Text = dr2.Item("Purchase Quantity").ToString
                Else
                    TxtOpeningStock.Text = "00"
                End If
                dr2.Close()



                'Search Opening old Purchase ID  and new purchase id  Inserted Product using old inserted product sub
                SearchOpeningPurchaseIDForOldInsertedProduct()


                dr = cmd.ExecuteReader()
                dr.Read()

                If dr.HasRows Then


                    Me.CmbProductGroupID.SelectedValue = (dr.Item("Product Group ID").ToString)
                    Me.CmbProductCategoryID.SelectedValue = (dr.Item("Product Category ID").ToString)
                    Me.CmbProductSubcategoryID.SelectedValue = (dr.Item("Product Subcategory ID").ToString)

                    Me.ProductPictureBox.Image = Nothing

                End If
                dr.Close()



                cmd.CommandText = "SELECT  *FROM [Products]  WHERE [Product ID] = " + Me.TxtProductID.Text + " AND [Product Image] IS NOT NULL"
                dr = cmd.ExecuteReader()
                dr.Read()

                Try


                    If dr.HasRows Then


                        Dim data As Byte() = DirectCast(dr("Product Image"), Byte())
                        Dim ms As New MemoryStream(data)
                        ProductPictureBox.Image = Image.FromStream(ms)
                    End If

                Catch ex As Exception

                End Try
                dr.Close()
                con.Close()

            End If

            'Refresh Data Serial Number To Gridview Click
            RefreshDataSerialNumberToGridviewForCellMouseClick()



        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

        End Try


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        RptPrintBarcode.Show()
        RptPrintBarcode.TxtProductID.Text = Me.TxtProductID.Text
        RptPrintBarcode.TextBox1.Focus()



    End Sub

    Private Sub TxtDiscountAmount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDiscountAmount.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtRemarks.Focus()

        End If
    End Sub

    Private Sub TxtDiscountAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDiscountAmount.TextChanged

    End Sub

    Private Sub GrdProductInformation_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdProductInformation.CurrentCellChanged

    End Sub

    

    Private Sub GrdProductInformation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GrdProductInformation.KeyPress
        'Data Grid view code


    End Sub
End Class