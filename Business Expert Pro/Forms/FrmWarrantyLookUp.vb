Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class FrmWarrantyLookUp
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point

    Dim CustomerID As String
    Dim WarrantySerialID As String


    Private Sub TxtSerialNumber_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    'Load Combo Box Problem Details
    Sub LoadComboBoxProblemDetails()

        Try

            Dim con1 As New SqlConnection
            Dim cmd1 As New SqlCommand
            con1.ConnectionString = FrmHome.ConnectionString

            Dim strSQL1 As String = "SELECT [Problem Category ID],[Problem Category Name] FROM [Problem Category]"
            Dim da1 As New System.Data.SqlClient.SqlDataAdapter(strSQL1, con1)
            Dim ds1 As New DataSet
            da1.Fill(ds1, "[Problem Category]")

            With Me.CmbProblemDetails
                .DataSource = ds1.Tables("[Problem Category]")
                .ValueMember = "Problem Category ID"
                .DisplayMember = "Problem Category Name"
            End With
            con1.Close()
            CmbProblemDetails.SelectedValue = 0

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    'Insert or update Into Warranty Invoice code
    Sub InsertOrUpdateIntoWarrantyInvoice()

        'Insert Into Sale Invoice code
        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim con2 As New SqlConnection
            Dim cmd2 As New SqlCommand
            Dim dr1 As SqlDataReader

            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now



            If TxtWarrantyInvoiceNo.Text = "" Then

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "INSERT INTO [Warranty Invoice Number] ([Prepared Date],[Prepared Time],[Branch ID],[Computer ID],[User Account ID],[Status],[Customer ID],[Complainer Name],[Complainer Mobile No],[Address],[Remarks],[Received Date]) values ('" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','INCOMPLETE','" + CustomerID + "','" + CmbComplainerName.Text + "','" + TxtMobileNo.Text + "','" + TxtAddress.Text + "','" + TxtRemarks.Text + "','" + DtpReceiveDate.Value + "')"
                cmd.ExecuteNonQuery()
                con.Close()


                con2.ConnectionString = FrmHome.ConnectionString
                con2.Open()
                cmd2.Connection = con2
                cmd2.CommandText = "SELECT top 1 [Warranty Invoice No] FROM [Warranty Invoice Number] where [User Account ID]= '" + FrmHome.LblUserID.Text + "' AND [Computer ID]='" + FrmHome.LblComputerID.Text + "' AND [Branch ID]='" + FrmHome.lblBranchID.Text + "'  order by [Warranty Invoice No] desc"

                dr1 = cmd2.ExecuteReader()
                dr1.Read()
                If dr1.HasRows Then


                    TxtWarrantyInvoiceNo.Text = (dr1.Item("Warranty Invoice No").ToString)
                End If
                con2.Close()
                dr1.Close()



            Else





                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "UPDATE  [Warranty Invoice Number] set [Status]='INCOMPLETE',[User Account ID]='" + FrmHome.LblUserID.Text + "',[Computer ID]='" + FrmHome.LblComputerID.Text + "',[Customer ID]='" + CustomerID + "',[Complainer Name]='" + CmbComplainerName.Text + "',[Complainer Mobile No]='" + TxtMobileNo.Text + "',[Address]='" + TxtAddress.Text + "',[Remarks]='" + TxtRemarks.Text + "' where [Warranty Invoice No] = '" + TxtWarrantyInvoiceNo.Text + "' "
                cmd.ExecuteNonQuery()
                con.Close()


            End If

        Catch ex As Exception
            MessageBox.Show("Error while Inserting to sale invoice record on table..." & ex.Message, "Insert Records Sale Invoice")
        Finally

        End Try



    End Sub
    Sub SearchCustomerInformationAndProductDetails()

        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand
            Dim cmd3 As New SqlCommand
            Dim dr As SqlDataReader
            Dim dr1 As SqlDataReader
            Dim dr2 As SqlDataReader



            con.ConnectionString = FrmHome.ConnectionString
            con.Open()

            Dim UsingDays As String



            cmd1.Connection = con
            cmd1.CommandText = "select *from [Purchase Serial Number] join [Purchase Invoice] on [Purchase Serial Number].[Purchase Invoice No]=[Purchase Invoice].[Purchase Invoice No] join [Supplier Information] on [purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID] join Purchase on [Purchase Serial Number].[Purchase Invoice No]= Purchase.[Purchase Invoice No] join Products on [purchase Serial Number].[Product ID]=[Products].[Product ID] join [Branch Information] on [Purchase Serial Number].[Branch ID]=[Branch Information].[Branch ID] where [purchase Serial Number].[purchase Serial Number]=  '" + TxtSerialNumber.Text + "'"

            dr1 = cmd1.ExecuteReader()
            dr1.Read()

            If dr1.HasRows Then

                cmbProductName.Text = dr1.Item("Product Name").ToString
                cmbProductName.ValueMember = dr1.Item("Product ID").ToString

                LblSupplierName.Text = dr1.Item("Supplier Name").ToString
                LblPhoneNoSupplier.Text = dr1.Item("Mobile No").ToString
                LblPurchaseDate.Text = dr1.Item("Purchase Date").ToString
                LblPurchaseInvoiceNo.Text = Val(dr1.Item("Purchase Invoice No").ToString)
                LblPurchaseBranchName.Text = dr1.Item("Branch Name").ToString


            End If

            dr1.Close()


            cmd3.Connection = con
            cmd3.CommandText = "select top 1 DATEDIFF (DAY, [Sale Date], '" + Today + "') AS [Days] from [Sale Serial Number] join [Sale Invoice] on [Sale Serial Number].[Sale Invoice No]=[Sale Invoice].[Sale Invoice No] join sale on [Sale Invoice].[Sale Invoice No]=Sale.[Sale Invoice No] join [Customer Information] on [Sale Invoice].[Customer ID]=[Customer Information].[Customer ID] join Purchase on [Sale Serial Number].[Purchase ID]=Purchase.[Purchase ID] join Products on [Sale Serial Number].[Product ID]=[Products].[Product ID] where [Sale Serial Number].[Sale Serial Number]= '" + TxtSerialNumber.Text + "' And Products.[Product ID]='" + cmbProductName.ValueMember + "'  order by [Sale Serial Number].[Sale Invoice No] desc"
            dr2 = cmd3.ExecuteReader()
            dr2.Read()

            If dr2.HasRows Then
                UsingDays = dr2.Item("Days").ToString
            End If

            dr2.Close()




            cmd.Connection = con
            cmd.CommandText = "select  top 1 *from [Sale Serial Number] join [Sale Invoice] on [Sale Serial Number].[Sale Invoice No]=[Sale Invoice].[Sale Invoice No] join sale on [Sale Invoice].[Sale Invoice No]=Sale.[Sale Invoice No] join [Customer Information] on [Sale Invoice].[Customer ID]=[Customer Information].[Customer ID] join Purchase on [Sale Serial Number].[Purchase ID]=Purchase.[Purchase ID] join Products on [Sale Serial Number].[Product ID]=[Products].[Product ID] join [Branch Information] on sale.[Branch ID]=[Branch Information].[Branch ID] where [Sale Serial Number].[Sale Serial Number]= '" + TxtSerialNumber.Text + "'  And Products.[Product ID]='" + cmbProductName.ValueMember + "' order by [Sale Serial Number].[Sale Invoice No] desc"
            dr = cmd.ExecuteReader()
            dr.Read()



            If dr.HasRows Then


                LblUsedDays.Text = UsingDays & " Days"
                LblCustomerName.Text = dr.Item("Customer Name").ToString
                LblAddressCustomer.Text = dr.Item("Address").ToString
                LblPhoneNoCustomer.Text = dr.Item("Mobile No").ToString
                LblSaleDate.Text = dr.Item("Sale Date").ToString
                LblSaleUnitPrice.Text = Val(dr.Item("Sale Unit Price").ToString)
                LblSaleInvoiceNo.Text = Val(dr.Item("Sale Invoice No").ToString)
                LblSaleBranchName.Text = dr.Item("Branch Name").ToString
                CustomerID = dr.Item("Customer ID").ToString
                LblWarranty.Text = dr.Item("Warranty Days").ToString & " Days"

            End If

            dr.Close()

            con.Close()


            If Val(LblUsedDays.Text) > Val(LblWarranty.Text) Then

                LblWarrantyStatus.Text = "Warranty Void"
                LblWarrantyStatus.ForeColor = Color.Maroon
            ElseIf Val(LblUsedDays.Text) <= Val(LblWarranty.Text) Then

                LblWarrantyStatus.Text = "Warranty Available"
                LblWarrantyStatus.ForeColor = Color.DarkBlue


            End If

            'Visible Group box
            VisibleGroupBox()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SearchCustomerInformationAndProductDetails")
        End Try
    End Sub

    Sub SearchCustomerInformationAndProductDetailsWithProductID()

        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand
            Dim cmd3 As New SqlCommand
            Dim dr As SqlDataReader
            Dim dr1 As SqlDataReader
            Dim dr2 As SqlDataReader



            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd1.Connection = con
            cmd3.Connection = con
            cmd.CommandText = "select top 1 *from [Sale Serial Number] join [Sale Invoice] on [Sale Serial Number].[Sale Invoice No]=[Sale Invoice].[Sale Invoice No] join sale on [Sale Invoice].[Sale Invoice No]=Sale.[Sale Invoice No] join [Customer Information] on [Sale Invoice].[Customer ID]=[Customer Information].[Customer ID] join Purchase on [Sale Serial Number].[Purchase ID]=Purchase.[Purchase ID] join Products on [Sale Serial Number].[Product ID]=[Products].[Product ID] join [Branch Information] on sale.[Branch ID]=[Branch Information].[Branch ID] where [Sale Serial Number].[Sale Serial Number]= '" + TxtSerialNumber.Text + "' And Products.[Product ID]='" + cmbProductName.ValueMember + "' order by [Sale Serial Number].[Sale Invoice No] desc"
            cmd1.CommandText = "select *from [Purchase Serial Number] join [Purchase Invoice] on [Purchase Serial Number].[Purchase Invoice No]=[Purchase Invoice].[Purchase Invoice No] join [Supplier Information] on [purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID] join Purchase on [Purchase Serial Number].[Purchase Invoice No]= Purchase.[Purchase Invoice No] join Products on [purchase Serial Number].[Product ID]=[Products].[Product ID] join [Branch Information] on [Purchase Serial Number].[Branch ID]=[Branch Information].[Branch ID] where [purchase Serial Number].[purchase Serial Number]=  '" + TxtSerialNumber.Text + "' And Products.[Product ID]='" + cmbProductName.ValueMember + "' "
            cmd3.CommandText = "select DATEDIFF (DAY, [Sale Date], '" + Today + "') AS [Days] from [Sale Serial Number] join [Sale Invoice] on [Sale Serial Number].[Sale Invoice No]=[Sale Invoice].[Sale Invoice No] join sale on [Sale Invoice].[Sale Invoice No]=Sale.[Sale Invoice No] join [Customer Information] on [Sale Invoice].[Customer ID]=[Customer Information].[Customer ID] join Purchase on [Sale Serial Number].[Purchase ID]=Purchase.[Purchase ID] join Products on [Sale Serial Number].[Product ID]=[Products].[Product ID]  where [Sale Serial Number].[Sale Serial Number]= '" + TxtSerialNumber.Text + "' And Products.[Product ID]='" + cmbProductName.ValueMember + "' "


            Dim UsingDays As String

            dr2 = cmd3.ExecuteReader()
            dr2.Read()
            If dr2.HasRows Then

                UsingDays = dr2.Item("Days").ToString
            End If

            dr2.Close()





            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then


                LblUsedDays.Text = UsingDays & " Days"
                LblCustomerName.Text = dr.Item("Customer Name").ToString
                LblAddressCustomer.Text = dr.Item("Address").ToString
                LblPhoneNoCustomer.Text = dr.Item("Mobile No").ToString
                LblSaleDate.Text = dr.Item("Sale Date").ToString
                LblSaleUnitPrice.Text = Val(dr.Item("Sale Unit Price").ToString)
                LblSaleInvoiceNo.Text = Val(dr.Item("Sale Invoice No").ToString)
                LblSaleBranchName.Text = dr.Item("Branch Name").ToString
                CustomerID = dr.Item("Customer ID").ToString
            End If

            dr.Close()
            'con.Close()

            dr1 = cmd1.ExecuteReader()
            dr1.Read()

            If dr1.HasRows Then

                'cmbProductName.Text = dr1.Item("Product Name").ToString
                'cmbProductName.ValueMember = dr1.Item("Product ID").ToString
                LblWarranty.Text = dr1.Item("Warranty Days").ToString & " Days"
                LblSupplierName.Text = dr1.Item("Supplier Name").ToString
                LblPhoneNoSupplier.Text = dr1.Item("Mobile No").ToString
                LblPurchaseDate.Text = dr1.Item("Purchase Date").ToString
                LblPurchaseInvoiceNo.Text = Val(dr1.Item("Purchase Invoice No").ToString)
                LblPurchaseBranchName.Text = dr1.Item("Branch Name").ToString


            End If

            dr1.Close()
            con.Close()


            If Val(LblUsedDays.Text) > Val(LblWarranty.Text) Then

                LblWarrantyStatus.Text = "Warranty Void"
                LblWarrantyStatus.ForeColor = Color.Maroon
            ElseIf Val(LblUsedDays.Text) <= Val(LblWarranty.Text) Then

                LblWarrantyStatus.Text = "Warranty Available"
                LblWarrantyStatus.ForeColor = Color.DarkBlue


            End If

            'Visible Group box
            VisibleGroupBox()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SearchCustomerInformationAndProductDetailsWithProductID")
        End Try
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


                Me.LblCustomerName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.LblPhoneNoCustomer.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.LblAddressCustomer.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.LblSaleDate.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.LblSaleUnitPrice.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))

                Me.LblSupplierName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.LblPhoneNoSupplier.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.LblPurchaseDate.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))



                Me.LblWarranty.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.LblUsedDays.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))



                Me.TxtWarrantyID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.CmbComplainerName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtMobileNo.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtAddress.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtReceivedItem.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.DtpReceiveDate.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.DtpDeliveryDate.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtSerialNumber.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.cmbProductName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))

                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

                Me.GrdProductsDetails.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdProductsDetails.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)


                'MsgBox(dr.Item("Language Font"))

            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while inserting Language on table..." & ex.Message, "Change Language")
        Finally
            con.Close()
        End Try

        'End Language

    End Sub
    'Clear All Data
    Sub ClearAllData()
        'for customer part
        LblCustomerName.Text = "None"
        LblPhoneNoCustomer.Text = "None"
        LblAddressCustomer.Text = "None"
        LblSaleDate.Text = "None"
        LblSaleUnitPrice.Text = "None"
        LblSaleInvoiceNo.Text = "None"
        LblSaleBranchName.Text = "None"

        'For Supplier Part
        LblSupplierName.Text = "None"
        LblPhoneNoSupplier.Text = "None"
        LblPurchaseDate.Text = "None"
        LblPurchaseInvoiceNo.Text = "None"
        LblPurchaseBranchName.Text = "None"

        'For warranty part
        LblWarranty.Text = "00"
        LblUsedDays.Text = "00"
        LblWarrantyStatus.Text = "None"

        'clear data for customer
        TxtWarrantyID.Text = ""
        CmbComplainerName.Text = ""
        TxtMobileNo.Text = ""
        TxtAddress.Text = ""
        TxtReceivedItem.Text = ""
        TxtRemarks.Text = ""
        DtpReceiveDate.Value = Now
        DtpDeliveryDate.Value = Now.AddDays(+5)

        TxtSerialNumber.Text = ""
        cmbProductName.Text = ""
        cmbProductName.ValueMember = ""

        CmbProblemDetails.Text = "---Press enter after selecting any problem---"

        GrdProblemDetails.Columns.Clear()
        GrdWarrantySerialNumber.Columns.Clear()
        GrdProductsDetails.Columns.Clear()

        TxtWarrantyInvoiceNo.Text = ""

        'Invisible Group box
        InvisibleGroupBox()

    End Sub
    'Clear Data for add warranty item again
    Sub ClearDataForNewWarrantyItem()
        'for customer part
        LblCustomerName.Text = "None"
        LblPhoneNoCustomer.Text = "None"
        LblAddressCustomer.Text = "None"
        LblSaleDate.Text = "None"
        LblSaleUnitPrice.Text = "None"
        LblSaleBranchName.Text = "None"
        LblSaleInvoiceNo.Text = "None"

        'For Supplier Part
        LblSupplierName.Text = "None"
        LblPhoneNoSupplier.Text = "None"
        LblPurchaseDate.Text = "None"
        LblPurchaseBranchName.Text = "None"
        LblPurchaseInvoiceNo.Text = "None"

        'For warranty part
        LblWarranty.Text = "00"
        LblUsedDays.Text = "00"
        LblWarrantyStatus.Text = "None"





        'clear data for customer
        TxtWarrantyID.Text = ""


        TxtSerialNumber.Text = ""
        cmbProductName.Text = ""
        cmbProductName.ValueMember = ""

        CmbProblemDetails.SelectedValue = 0

        TxtReceivedItem.Text = ""

        WarrantySerialID = 0

        'Invisible Group box
        InvisibleGroupBox()
    End Sub
    'Clear Data for Search New Warranty
    Sub ClearDataForSearchNewWarranty()
        'for customer part
        LblCustomerName.Text = "None"
        LblPhoneNoCustomer.Text = "None"
        LblAddressCustomer.Text = "None"
        LblSaleDate.Text = "None"
        LblSaleUnitPrice.Text = "None"
        LblSaleBranchName.Text = "None"
        LblSaleInvoiceNo.Text = "None"

        'For Supplier Part
        LblSupplierName.Text = "None"
        LblPhoneNoSupplier.Text = "None"
        LblPurchaseDate.Text = "None"
        LblPurchaseBranchName.Text = "None"
        LblPurchaseInvoiceNo.Text = "None"

        'For warranty part
        LblWarranty.Text = "00"
        LblUsedDays.Text = "00"
        LblWarrantyStatus.Text = "None"

        'Invisible Group box
        InvisibleGroupBox()

    End Sub
    Sub VisibleGroupBox()
        GrpCustomerDetails.Visible = True
        GrpSupplierDetails.Visible = True
        GrpSerialNumber.Visible = True
    End Sub
    Sub InvisibleGroupBox()
        GrpCustomerDetails.Visible = False
        GrpSupplierDetails.Visible = False
        GrpSerialNumber.Visible = False
    End Sub

    'Insert or Update into Warranty 
    Sub InsertOrUpdateIntoWarranty()

        'Data Insert Code
        Dim con As New SqlConnection
        Dim con1 As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim cmd3 As New SqlCommand
        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now
        Dim dr As SqlDataReader


        Try

            'Empty Txt Box Can Not Be Save Code
            If Me.CmbComplainerName.Text = "" Or Me.TxtMobileNo.Text = "" Or TxtSerialNumber.Text = "" Or cmbProductName.Text = "" Then
                MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Warranty Look Up")

            Else

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd3.Connection = con
                cmd3.CommandText = "select *from [Warranty]  where [Warranty Invoice No]='" + TxtWarrantyInvoiceNo.Text + "' And [Product ID] = '" + cmbProductName.ValueMember + "'"

                dr = cmd3.ExecuteReader
                dr.Read()

                If Not dr.HasRows Then

                    con1.ConnectionString = FrmHome.ConnectionString
                    con1.Open()
                    cmd.Connection = con1
                    cmd1.Connection = con1
                    cmd.CommandText = "INSERT INTO [Warranty] ([Warranty Invoice No],[Product ID],[Prepared Date],[Prepared Time],[Branch ID],[Computer ID],[User Account ID],[Warranty Quantity]) VALUES ('" + TxtWarrantyInvoiceNo.Text + "','" + cmbProductName.ValueMember + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + GrdWarrantySerialNumber.RowCount.ToString + "')"
                    cmd1.CommandText = "INSERT INTO [Log Details] ([Log Category],[Log Description],[User Account ID],[Log Date],[Log Time],[Task ID]) VALUES ('Bank Information','Data Inserted Successfully [" + CmbComplainerName.Text + "]','" + FrmHome.LblUserID.Text + "','" + currentDate + "','" + currentTime + "','New Data Inserted')"
                    cmd.ExecuteNonQuery()
                    cmd1.ExecuteNonQuery()

                    con1.Close()


                    'Refresh Data Warranty Products
                    RefreshDataWarrantyProducts()

                ElseIf dr.HasRows Then

                    'show warranty id to text box
                    TxtWarrantyID.Text = dr.Item("Warranty ID").ToString

                    con1.ConnectionString = FrmHome.ConnectionString
                    con1.Open()
                    cmd.Connection = con1
                    cmd1.Connection = con1
                    cmd.CommandText = "Update [Warranty] set [Product ID]='" + cmbProductName.ValueMember + "',[Prepared Date]='" + currentDate + "',[Prepared Time]='" + currentTime + "',[Branch ID]='" + FrmHome.lblBranchID.Text + "',[Computer ID]='" + FrmHome.LblComputerID.Text + "',[User Account ID]='" + FrmHome.LblUserID.Text + "',[Warranty Quantity]='" + GrdWarrantySerialNumber.RowCount.ToString + "' Where [Warranty ID]='" + TxtWarrantyID.Text + "' "
                    cmd1.CommandText = "INSERT INTO [Log Details] ([Log Category],[Log Description],[User Account ID],[Log Date],[Log Time],[Task ID]) VALUES ('Bank Information','Data Inserted Successfully [" + CmbComplainerName.Text + "]','" + FrmHome.LblUserID.Text + "','" + currentDate + "','" + currentTime + "','New Data Inserted')"
                    cmd.ExecuteNonQuery()
                    cmd1.ExecuteNonQuery()

                    con1.Close()


                    'Refresh Data Warranty Products
                    RefreshDataWarrantyProducts()


                End If
                dr.Close()
                con.Close()




            End If

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally

        End Try
    End Sub
    'Insert Data into Warranty Serial Number 
    Sub InsertIntoWarrantySerialNumber()

        'Data Insert Code
        Dim con As New SqlConnection
        Dim con1 As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand

        Dim Dr As SqlDataReader

        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now


        Try

            'Empty Txt Box Can Not Be Save Code
            If Me.CmbComplainerName.Text = "" Or Me.TxtMobileNo.Text = "" Or CmbProblemDetails.Text = "" Or CmbProblemDetails.SelectedValue = 0 Or TxtSerialNumber.Text = "" Or cmbProductName.Text = "" Then
                MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Warranty Look Up")

            Else

                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd2.Connection = con1
                cmd2.CommandText = "select * from [Warranty Serial]  Where [Product ID]='" + cmbProductName.ValueMember + "' And [Warranty Invoice No]='" + TxtWarrantyInvoiceNo.Text + "' And [Warranty Serial Number]='" + TxtSerialNumber.Text + "'"

                Dr = cmd2.ExecuteReader
                Dr.Read()
                If Not Dr.HasRows Then

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd1.Connection = con
                    cmd.CommandText = "INSERT INTO [Warranty Serial] ([Warranty Invoice No],[Product ID],[Warranty Serial Number],[Prepared Date],[Prepared Time],[Branch ID],[Computer ID],[User Account ID],[Received Item],[Delivery Date]) VALUES ('" + TxtWarrantyInvoiceNo.Text + "','" + cmbProductName.ValueMember + "','" + TxtSerialNumber.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + TxtReceivedItem.Text + "','" + DtpDeliveryDate.Value + "')"
                    cmd1.CommandText = "INSERT INTO [Log Details] ([Log Category],[Log Description],[User Account ID],[Log Date],[Log Time],[Task ID]) VALUES ('Bank Information','Data Inserted Successfully [" + CmbComplainerName.Text + "]','" + FrmHome.LblUserID.Text + "','" + currentDate + "','" + currentTime + "','New Data Inserted')"
                    cmd.ExecuteNonQuery()
                    cmd1.ExecuteNonQuery()
                    con.Close()


                    'Refresh Data Warranty Products
                    RefreshDataSerialNumber()
                ElseIf Dr.HasRows Then

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd1.Connection = con
                    cmd.CommandText = "Update [Warranty Serial] set [Product ID]='" + cmbProductName.ValueMember + "',[Warranty Serial Number]='" + TxtSerialNumber.Text + "',[Branch ID]='" + FrmHome.lblBranchID.Text + "',[Computer ID]='" + FrmHome.LblComputerID.Text + "',[User Account ID]='" + FrmHome.LblUserID.Text + "',[Received Item]='" + TxtReceivedItem.Text + "',[Delivery Date]='" + DtpDeliveryDate.Value + "' Where [Warranty Invoice No]='" + TxtWarrantyInvoiceNo.Text + "' And [Product ID]='" + cmbProductName.ValueMember + "' And [Warranty Serial Number]='" + TxtSerialNumber.Text + "'"
                    cmd1.CommandText = "INSERT INTO [Log Details] ([Log Category],[Log Description],[User Account ID],[Log Date],[Log Time],[Task ID]) VALUES ('Bank Information','Data Updated Successfully [" + CmbComplainerName.Text + "]','" + FrmHome.LblUserID.Text + "','" + currentDate + "','" + currentTime + "','New Data Inserted')"
                    cmd.ExecuteNonQuery()
                    cmd1.ExecuteNonQuery()
                    con.Close()


                    'Refresh Data Warranty Products
                    RefreshDataSerialNumber()



                End If
                Dr.Close()
                con1.Close()


                'Insert or Update into Warranty 
                InsertOrUpdateIntoWarranty()

                'Insert Data into Warranty Problem
                InsertIntoWarrantyProblem()



            End If
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally

        End Try

    End Sub
    'Insert Data into Warranty Problem
    Sub InsertIntoWarrantyProblem()

        'Data Insert Code
        Dim con As New SqlConnection
        Dim con1 As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim cmd3 As New SqlCommand
        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now

        Dim Dr As SqlDataReader


        Try

            'Empty Txt Box Can Not Be Save Code
            If Me.CmbComplainerName.Text = "" Or Me.cmbProductName.Text = "" Or Me.TxtMobileNo.Text = "" Or CmbProblemDetails.Text = "" Or TxtSerialNumber.Text = "" Then
                MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Warranty Look Up")

            Else

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd2.Connection = con
                cmd2.CommandText = "Select * From [Warranty Serial] Where [Warranty Serial Number]='" + TxtSerialNumber.Text + "' and [Warranty Invoice No]='" + TxtWarrantyInvoiceNo.Text + "' And [Product ID]='" + cmbProductName.ValueMember + "'"

                'Find Warranty Serial ID
                Dr = cmd2.ExecuteReader
                Dr.Read()
                If Dr.HasRows Then
                    WarrantySerialID = Dr.Item("Warranty Serial ID").ToString
                End If
                Dr.Close()


                cmd3.Connection = con
                cmd3.CommandText = "select * from [Warranty Problem Details] Where [Problem ID] = '" + CmbProblemDetails.SelectedValue.ToString + "' and [Warranty Invoice No]='" + TxtWarrantyInvoiceNo.Text + "' and [Warranty Serial ID]='" + WarrantySerialID + "'"

                Dr = cmd3.ExecuteReader
                Dr.Read()
                If Not Dr.HasRows Then

                    con1.ConnectionString = FrmHome.ConnectionString
                    con1.Open()
                    cmd.Connection = con1
                    cmd1.Connection = con1
                    cmd.CommandText = "INSERT INTO [Warranty Problem Details] ([Product ID],[Problem ID],[Warranty Serial ID],[Warranty Invoice No],[Prepared Date],[Prepared Time],[Branch ID],[Computer ID],[User Account ID],[Status]) VALUES ('" + cmbProductName.ValueMember + "','" + CmbProblemDetails.SelectedValue.ToString + "','" + WarrantySerialID + "','" + TxtWarrantyInvoiceNo.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','INCOMPLETE')"
                    cmd1.CommandText = "INSERT INTO [Log Details] ([Log Category],[Log Description],[User Account ID],[Log Date],[Log Time],[Task ID]) VALUES ('Bank Information','Data Inserted Successfully [" + CmbComplainerName.Text + "]','" + FrmHome.LblUserID.Text + "','" + currentDate + "','" + currentTime + "','New Data Inserted')"

                    cmd.ExecuteNonQuery()
                    cmd1.ExecuteNonQuery()
                    con1.Close()

                    'Refresh Data Warranty Products
                    RefreshDataProblemDetails()

                End If
                Dr.Close()
                con.Close()


            End If
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally


        End Try
    End Sub

    Private Sub TxtSerialNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub WarrantyLookUp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 0)
        Me.Size = My.Computer.Screen.WorkingArea.Size



        'Load Combo Box Problem Details
        LoadComboBoxProblemDetails()
        LoadComboComplainerName()

        'Clear All Data
        ClearAllData()


        'Change Language
        ChangeLanguage()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub BtnAddToWarranty_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddToWarranty.Click

        'Insert or update Into Warranty Invoice code
        InsertOrUpdateIntoWarrantyInvoice()



        If CmbComplainerName.Text = "" And TxtAddress.Text = "" And TxtMobileNo.Text = "" Then
            CmbComplainerName.Text = LblCustomerName.Text
            TxtAddress.Text = LblAddressCustomer.Text
            TxtMobileNo.Text = LblPhoneNoCustomer.Text

            CmbComplainerName.Focus()
        Else
            CmbProblemDetails.Focus()
        End If




    End Sub

    Private Sub cmbProductName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbProductName.KeyDown
        If e.KeyCode = Keys.Enter Then


            FrmListofProducts.Show()
            FrmListofProducts.Label1.Text = "Warranty Look Up"
            FrmListofProducts.TxtSearchProductName.Focus()

        End If
    End Sub

    Private Sub cmbProductName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProductName.SelectedIndexChanged

    End Sub


    'Refresh Data Warranty Products
    Sub RefreshDataWarrantyProducts()

        ' Load Data
        Try

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "Select Warranty.[Warranty ID],products.[Product Name], Warranty.[Warranty Quantity] from [Warranty] join [products] on Warranty.[Product ID]= products.[Product ID] Where [Warranty Invoice No]='" + TxtWarrantyInvoiceNo.Text + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Warranty")
            connection.Close()
            GrdProductsDetails.DataSource = ds
            GrdProductsDetails.DataMember = "BizPro_Warranty"

            'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdProductsDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill




        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try

        'End Refresh Data
    End Sub
    'Refresh Data Warranty Serial
    Sub RefreshDataSerialNumber()

        ' Load Data
        Try


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select [Warranty Serial Number] from [Warranty Serial]  Where [Product ID]='" + cmbProductName.ValueMember + "' And [Warranty Invoice No]='" + TxtWarrantyInvoiceNo.Text + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Warranty Serial")
            connection.Close()
            GrdWarrantySerialNumber.DataSource = ds
            GrdWarrantySerialNumber.DataMember = "BizPro_Warranty Serial"

            'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdWarrantySerialNumber.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill




        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try

        'End Refresh Data
    End Sub

    'Refresh Data Warranty Products
    Sub RefreshDataProblemDetails()

        ' Load Data
        Try


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select [Problem Category Name] from [Warranty Problem Details]join [Problem Category] on  [Warranty Problem Details].[Problem ID]=[Problem Category].[Problem Category ID] Where [Warranty Serial ID]='" + WarrantySerialID + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Warranty")
            connection.Close()
            GrdProblemDetails.DataSource = ds
            GrdProblemDetails.DataMember = "BizPro_Warranty"

            'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdProblemDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill




        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try

        'End Refresh Data
    End Sub





    Private Sub GrdWarrantyLookUp_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdWarrantyLookUp_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdProductsDetails.Rows(e.RowIndex)

                TxtWarrantyID.Text = row.Cells("Warranty ID").Value.ToString

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim dr As SqlDataReader


                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "Select * from [Warranty]  join [Warranty Invoice Number] on [Warranty].[Warranty Invoice No]=[Warranty Invoice Number].[Warranty Invoice No] join [Products] on [Warranty].[Product ID]=[Products].[Product ID] Where [Warranty].[warranty ID]='" + TxtWarrantyID.Text + "' "

                'Find Warranty Serial ID
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then

                    CmbComplainerName.Text = dr.Item("Complainer Name").ToString
                    TxtMobileNo.Text = dr.Item("Complainer Mobile No").ToString
                    TxtAddress.Text = dr.Item("Address").ToString
                    TxtRemarks.Text = dr.Item("Remarks").ToString
                    cmbProductName.Text = dr.Item("Product Name").ToString
                    cmbProductName.ValueMember = dr.Item("Product ID").ToString
                End If
                dr.Close()
                con.Close()


                'Refresh Data Warranty Serial
                RefreshDataSerialNumber()

                'Problem Details Gridview Clear
                GrdProblemDetails.Columns.Clear()

                'Invisible Group box
                InvisibleGroupBox()

            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview")

        End Try
    End Sub
    'Update Invoice to Complete
    Sub UpdateInvoiceToComplete()

        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "UPDATE  [Warranty Invoice Number] set [Status]='COMPLETE',[User Account ID]='" + FrmHome.LblUserID.Text + "',[Computer ID]='" + FrmHome.LblComputerID.Text + "',[Customer ID]='" + CustomerID + "',[Complainer Name]='" + CmbComplainerName.Text + "',[Complainer Mobile No]='" + TxtMobileNo.Text + "',[Address]='" + TxtAddress.Text + "',[Remarks]='" + TxtRemarks.Text + "' where [Warranty Invoice No] = '" + TxtWarrantyInvoiceNo.Text + "' "
            cmd.ExecuteNonQuery()
            con.Close()



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub







    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try

            If CustomerID = 0 Then
                CustomerID = Me.CmbComplainerName.SelectedValue.ToString

            End If

            If Not TxtWarrantyInvoiceNo.Text = "" Then


                If GrdProductsDetails.RowCount < 1 Then

                    MsgBox("Please add product to save this invoice or delete this invoice", MsgBoxStyle.Critical, "Warranty look up")
                Else

                    Dim q As MsgBoxResult
                    q = MsgBox("Are you sure want to save this invoice?", MsgBoxStyle.YesNo, "Warranty look up")

                    If q = MsgBoxResult.Yes Then


                        'Update Invoice to Complete
                        UpdateInvoiceToComplete()

                        'Show Reports
                        RptWarrantyInvoice.ShowWarrantyInvoice()
                        RptWarrantyInvoice.Show()

                        'Clear All Data
                        ClearAllData()

                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Sub BtnAddNew_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click

        Dim Q As MsgBoxResult
        Q = MsgBox("Are you sure want to create new invoice?", MsgBoxStyle.YesNo, "Warranty look up")

        If Q = MsgBoxResult.Yes Then
            'Clear All Data
            ClearAllData()

            TxtSerialNumber.Focus()
        End If

    End Sub

    Private Sub BtnRefresh_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click

        'Clear Data for add warranty item again
        ClearDataForNewWarrantyItem()

        'Refresh Data Warranty Products
        RefreshDataWarrantyProducts()

    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click

        Dim q As MsgBoxResult
        q = MsgBox("Are you sure want to delete this invoice?", MsgBoxStyle.YesNo, "Warranty look up")

        If q = MsgBoxResult.Yes Then

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand


            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Delete From [Warranty] where [Warranty Invoice No]='" + TxtWarrantyInvoiceNo.Text + "' Delete From [Warranty Problem Details] where  [Warranty Invoice No]='" + TxtWarrantyInvoiceNo.Text + "' Delete From [Warranty Serial] where  [Warranty Invoice No]='" + TxtWarrantyInvoiceNo.Text + "' Delete From [Warranty Invoice Number] where [Warranty Invoice No]='" + TxtWarrantyInvoiceNo.Text + "'"
            cmd.ExecuteNonQuery()
            con.Close()


            'Clear Data All 
            ClearAllData()


            'Refresh Data Warranty Serial
            RefreshDataSerialNumber()


            'Refresh Data Warranty Products
            RefreshDataProblemDetails()


            'Refresh Data Warranty Products
            RefreshDataWarrantyProducts()


            'Focus on Serial Number
            TxtSerialNumber.Focus()



        End If
    End Sub

    Private Sub TxtCustomerName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            TxtMobileNo.Focus()
        End If
    End Sub

    Private Sub TxtCustomerName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtMobileNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtMobileNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtAddress.Focus()
        End If
    End Sub

    Private Sub TxtMobileNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtMobileNo.TextChanged

    End Sub

    Private Sub TxtAddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtAddress.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtReceivedItem.Focus()
        End If
    End Sub

    Private Sub TxtAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtAddress.TextChanged

    End Sub

    Private Sub CmbProblemDetails_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles CmbProblemDetails.DrawItem

    End Sub

    Private Sub CmbProblemDetails_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbProblemDetails.KeyDown
        If e.KeyCode = Keys.Enter Then

            If CustomerID = 0 Then
                CustomerID = Me.CmbComplainerName.SelectedValue.ToString
            End If

            If CmbProblemDetails.Text = "" Then
                TxtRemarks.Focus()

            Else



                BtnListProblem.PerformClick()
            End If
        End If
    End Sub

    Private Sub CmbProblemDetails_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbProblemDetails.SelectedIndexChanged

    End Sub

    Private Sub TxtReceiveItem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            TxtRemarks.Focus()
        End If
    End Sub

    Private Sub TxtReceiveItem_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnListProblem.Click


        If CustomerID = 0 Then
            CustomerID = Me.CmbComplainerName.SelectedValue.ToString

        End If

        'Insert or update into warranty invoice number
        InsertOrUpdateIntoWarrantyInvoice()

        If CmbProblemDetails.SelectedValue = 0 Or CmbProblemDetails.Text = "" Then
            Dim q As MsgBoxResult
            q = MsgBox("Do you want to list new problem ?", MsgBoxStyle.YesNo, "Warranty look up")
            If q = MsgBoxResult.Yes Then
                FrmProblemCategory.Show()
                FrmProblemCategory.TxtProblemCategoryName.Focus()
            End If
        Else



            If Not TxtWarrantyInvoiceNo.Text = "" Then


                'Insert into warranty serial number
                InsertIntoWarrantySerialNumber()




                'Making Clear Problem Details Combobox
                CmbProblemDetails.Text = ""

                CmbProblemDetails.Focus()
            End If
        End If
    End Sub

    Private Sub BtnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddItem.Click


        If CustomerID = 0 Then
            CustomerID = Me.CmbComplainerName.SelectedValue.ToString

        End If

        'Set text in Combobx to shwo
        CmbProblemDetails.Text = "---Press enter after selecting any problem---"

        'Insert or update into warranty invoice number
        InsertOrUpdateIntoWarrantyInvoice()

        If Not TxtWarrantyInvoiceNo.Text = "" Then


            'Insert into warranty serial number
            InsertIntoWarrantySerialNumber()


            'Clear Data for add warranty item again
            ClearDataForNewWarrantyItem()

            'Focus on serial number text box
            TxtSerialNumber.Focus()
        End If

    End Sub

    Private Sub GrdWarrantySerialNumber_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)






    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click

        'Clear Data for Search New Warranty
        ClearDataForSearchNewWarranty()

        If cmbProductName.Text = "" Then
            SearchCustomerInformationAndProductDetails()
        Else
            SearchCustomerInformationAndProductDetailsWithProductID()

        End If
    End Sub

    Private Sub GrdWarrantySerialNumber_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdWarrantySerialNumber.Rows(e.RowIndex)


                TxtSerialNumber.Text = row.Cells("Warranty Serial Number").Value.ToString


                BtnSearch.PerformClick()

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim dr As SqlDataReader


                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "Select * from [Warranty Serial] Where [Warranty Serial Number]='" + TxtSerialNumber.Text + "' And [Warranty Invoice No]='" + TxtWarrantyInvoiceNo.Text + "'"

                'Find Warranty Serial ID
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then

                    WarrantySerialID = dr.Item("Warranty Serial ID").ToString
                    TxtReceivedItem.Text = dr.Item("Received Item").ToString
                End If
                dr.Close()
                con.Close()


                'Refresh Data Warranty problems
                RefreshDataProblemDetails()

            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview")

        End Try
    End Sub

    Private Sub GrdProblemDetails_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdProblemDetails_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = GrdProblemDetails.Rows(e.RowIndex)

            CmbProblemDetails.Text = row.Cells("Problem Category Name").Value.ToString

        End If
    End Sub

    Private Sub GrdProblemDetails_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = GrdProblemDetails.Rows(e.RowIndex)

            Try

                Dim q As MsgBoxResult
                q = MsgBox("Are you sure want to remove this problem?", MsgBoxStyle.YesNo, "Warranty look up")

                If q = MsgBoxResult.Yes Then

                    Dim con As New SqlConnection
                    Dim cmd As New SqlCommand


                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "Delete From [Warranty Problem Details] where [Warranty Serial ID]='" + WarrantySerialID + "' And [Warranty Invoice No]='" + TxtWarrantyInvoiceNo.Text + "' And [Problem ID]='" + CmbProblemDetails.SelectedValue.ToString + "'"
                    cmd.ExecuteNonQuery()
                    con.Close()

                    'Refresh Problem Details
                    RefreshDataProblemDetails()

                    'Making Clear Problem Details Combobox
                    CmbProblemDetails.Text = ""

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub GrdWarrantySerialNumber_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)


        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = GrdWarrantySerialNumber.Rows(e.RowIndex)

            MsgBox(WarrantySerialID)
            Try

                Dim q As MsgBoxResult
                q = MsgBox("Are you sure want to delete this serial number?", MsgBoxStyle.YesNo, "Warranty look up")

                If q = MsgBoxResult.Yes Then

                    Dim con As New SqlConnection
                    Dim cmd As New SqlCommand


                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "Delete From [Warranty Problem Details] where [Warranty Serial ID]='" + WarrantySerialID + "' And [Warranty Invoice No]='" + TxtWarrantyInvoiceNo.Text + "' Delete From [Warranty Serial] where [Warranty Serial ID]='" + WarrantySerialID + "'"
                    cmd.ExecuteNonQuery()
                    con.Close()

                    'Refresh Data Warranty Serial
                    RefreshDataSerialNumber()


                    'Refresh Data Warranty Products
                    RefreshDataProblemDetails()

                    'Insert or Update into Warranty 
                    InsertOrUpdateIntoWarranty()

                    'Making Clear Problem Details Combobox
                    CmbProblemDetails.Text = ""

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub



    Private Sub GrdProductsDetails_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = GrdProductsDetails.Rows(e.RowIndex)



                Dim q As MsgBoxResult
                q = MsgBox("Are you sure want to delete this product?", MsgBoxStyle.YesNo, "Warranty look up")

                If q = MsgBoxResult.Yes Then

                    Dim con As New SqlConnection
                    Dim cmd As New SqlCommand


                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "Delete From [Warranty] where [Product ID]='" + cmbProductName.ValueMember + "' And [Warranty Invoice No]='" + TxtWarrantyInvoiceNo.Text + "' Delete From [Warranty Problem Details] where [Product ID]='" + cmbProductName.ValueMember + "' And [Warranty Invoice No]='" + TxtWarrantyInvoiceNo.Text + "' Delete From [Warranty Serial]where [Product ID]='" + cmbProductName.ValueMember + "' And [Warranty Invoice No]='" + TxtWarrantyInvoiceNo.Text + "'"
                    cmd.ExecuteNonQuery()
                    con.Close()


                    'Clear Data for add warranty item again
                    ClearDataForNewWarrantyItem()


                    'Refresh Data Warranty Serial
                    RefreshDataSerialNumber()


                    'Refresh Data Warranty Products
                    RefreshDataProblemDetails()


                    'Refresh Data Warranty Products
                    RefreshDataWarrantyProducts()


                    'Focus on Serial Number
                    TxtSerialNumber.Focus()



                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub GrpCustomerInfo_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrpCustomerInfo.Enter

    End Sub

    Private Sub TxtReceivedItem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtReceivedItem.KeyDown
        If e.KeyCode = Keys.Enter Then

            CmbProblemDetails.Focus()

        End If
    End Sub


    Private Sub TxtReceivedItem_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtReceivedItem.TextChanged

    End Sub

    Private Sub BtnHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHistory.Click
        'Open Warranty History form
        FrmWarrantyHistory.Show()
        FrmWarrantyHistory.TxtSearchWarrantyInvoice.Focus()
    End Sub

    Private Sub TxtSerialNumber_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSerialNumber.KeyDown
        If e.KeyCode = Keys.Enter Then


            'Clear Data for Search New Warranty
            ClearDataForSearchNewWarranty()

            If cmbProductName.Text = "" Then
                SearchCustomerInformationAndProductDetails()
            Else
                SearchCustomerInformationAndProductDetailsWithProductID()

            End If
        End If
    End Sub

    Private Sub TxtSerialNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSerialNumber.KeyPress

    End Sub


    Private Sub TxtSerialNumber_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSerialNumber.TextChanged

    End Sub

    Private Sub BtnInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInvoice.Click
        'Show Reports
        RptWarrantyInvoice.ShowWarrantyInvoice()
        RptWarrantyInvoice.Show()
    End Sub

    Private Sub GrdProductsDetails_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdProductsDetails.CellContentClick

    End Sub

    Private Sub GrdProductsDetails_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdProductsDetails.CellMouseClick
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdProductsDetails.Rows(e.RowIndex)

                TxtWarrantyID.Text = row.Cells("Warranty ID").Value.ToString

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim dr As SqlDataReader


                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "Select * from [Warranty]  join [Warranty Invoice Number] on [Warranty].[Warranty Invoice No]=[Warranty Invoice Number].[Warranty Invoice No] join [Products] on [Warranty].[Product ID]=[Products].[Product ID] Where [Warranty].[warranty ID]='" + TxtWarrantyID.Text + "' "

                'Find Warranty Serial ID
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then

                    CmbComplainerName.Text = dr.Item("Complainer Name").ToString
                    TxtMobileNo.Text = dr.Item("Complainer Mobile No").ToString
                    TxtAddress.Text = dr.Item("Address").ToString
                    TxtRemarks.Text = dr.Item("Remarks").ToString
                    cmbProductName.Text = dr.Item("Product Name").ToString
                    cmbProductName.ValueMember = dr.Item("Product ID").ToString
                End If
                dr.Close()
                con.Close()


                'Refresh Data Warranty Serial
                RefreshDataSerialNumber()

                'Problem Details Gridview Clear
                GrdProblemDetails.Columns.Clear()

                'Invisible Group box
                InvisibleGroupBox()

            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview")

        End Try
    End Sub

    Private Sub GrdProductsDetails_CellMouseDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdProductsDetails.CellMouseDoubleClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = GrdProductsDetails.Rows(e.RowIndex)



                Dim q As MsgBoxResult
                q = MsgBox("Are you sure want to delete this product?", MsgBoxStyle.YesNo, "Warranty look up")

                If q = MsgBoxResult.Yes Then

                    Dim con As New SqlConnection
                    Dim cmd As New SqlCommand


                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "Delete From [Warranty] where [Product ID]='" + cmbProductName.ValueMember + "' And [Warranty Invoice No]='" + TxtWarrantyInvoiceNo.Text + "' Delete From [Warranty Problem Details] where [Product ID]='" + cmbProductName.ValueMember + "' And [Warranty Invoice No]='" + TxtWarrantyInvoiceNo.Text + "' Delete From [Warranty Serial]where [Product ID]='" + cmbProductName.ValueMember + "' And [Warranty Invoice No]='" + TxtWarrantyInvoiceNo.Text + "'"
                    cmd.ExecuteNonQuery()
                    con.Close()


                    'Clear Data for add warranty item again
                    ClearDataForNewWarrantyItem()


                    'Refresh Data Warranty Serial
                    RefreshDataSerialNumber()


                    'Refresh Data Warranty Products
                    RefreshDataProblemDetails()


                    'Refresh Data Warranty Products
                    RefreshDataWarrantyProducts()


                    'Focus on Serial Number
                    TxtSerialNumber.Focus()



                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub GrdWarrantySerialNumber_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdWarrantySerialNumber.CellContentClick

    End Sub

    Private Sub GrdWarrantySerialNumber_CellMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdWarrantySerialNumber.CellMouseClick
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdWarrantySerialNumber.Rows(e.RowIndex)


                TxtSerialNumber.Text = row.Cells("Warranty Serial Number").Value.ToString


                BtnSearch.PerformClick()

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim dr As SqlDataReader


                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "Select * from [Warranty Serial] Where [Warranty Serial Number]='" + TxtSerialNumber.Text + "' And [Warranty Invoice No]='" + TxtWarrantyInvoiceNo.Text + "'"

                'Find Warranty Serial ID
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then

                    WarrantySerialID = dr.Item("Warranty Serial ID").ToString
                    TxtReceivedItem.Text = dr.Item("Received Item").ToString
                End If
                dr.Close()
                con.Close()


                'Refresh Data Warranty problems
                RefreshDataProblemDetails()

            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview")

        End Try
    End Sub

    Private Sub GrdWarrantySerialNumber_CellMouseDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdWarrantySerialNumber.CellMouseDoubleClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = GrdWarrantySerialNumber.Rows(e.RowIndex)

            MsgBox(WarrantySerialID)
            Try

                Dim q As MsgBoxResult
                q = MsgBox("Are you sure want to delete this serial number?", MsgBoxStyle.YesNo, "Warranty look up")

                If q = MsgBoxResult.Yes Then

                    Dim con As New SqlConnection
                    Dim cmd As New SqlCommand


                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "Delete From [Warranty Problem Details] where [Warranty Serial ID]='" + WarrantySerialID + "' And [Warranty Invoice No]='" + TxtWarrantyInvoiceNo.Text + "' Delete From [Warranty Serial] where [Warranty Serial ID]='" + WarrantySerialID + "'"
                    cmd.ExecuteNonQuery()
                    con.Close()

                    'Refresh Data Warranty Serial
                    RefreshDataSerialNumber()


                    'Refresh Data Warranty Products
                    RefreshDataProblemDetails()

                    'Insert or Update into Warranty 
                    InsertOrUpdateIntoWarranty()

                    'Making Clear Problem Details Combobox
                    CmbProblemDetails.Text = ""

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdProblemDetails.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdProblemDetails.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = GrdProblemDetails.Rows(e.RowIndex)

            CmbProblemDetails.Text = row.Cells("Problem Category Name").Value.ToString

        End If
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdProblemDetails.CellMouseDoubleClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = GrdProblemDetails.Rows(e.RowIndex)

            Try

                Dim q As MsgBoxResult
                q = MsgBox("Are you sure want to remove this problem?", MsgBoxStyle.YesNo, "Warranty look up")

                If q = MsgBoxResult.Yes Then

                    Dim con As New SqlConnection
                    Dim cmd As New SqlCommand


                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "Delete From [Warranty Problem Details] where [Warranty Serial ID]='" + WarrantySerialID + "' And [Warranty Invoice No]='" + TxtWarrantyInvoiceNo.Text + "' And [Problem ID]='" + CmbProblemDetails.SelectedValue.ToString + "'"
                    cmd.ExecuteNonQuery()
                    con.Close()

                    'Refresh Problem Details
                    RefreshDataProblemDetails()

                    'Making Clear Problem Details Combobox
                    CmbProblemDetails.Text = ""

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
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

    Private Sub LblRemarks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblRemarks.Click

    End Sub

    Private Sub TxtRemarks_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtRemarks.TextChanged

    End Sub

    Private Sub LblReceivedItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblReceivedItem.Click

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

    Private Sub CmbComplainerName_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CmbComplainerName.MouseClick

    End Sub

   

    Private Sub CmbComplainerName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbComplainerName.SelectedIndexChanged
        FindCustomerDetails()
    End Sub


    Sub FindCustomerDetails()


            Try




                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim dr As SqlDataReader



                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "SELECT  *FROM [Customer Information]  WHERE [Customer ID] = '" + Me.CmbComplainerName.SelectedValue.ToString + "' "
                dr = cmd.ExecuteReader()
                dr.Read()

                If dr.HasRows Then


                    Me.TxtMobileNo.Text = dr.Item("Mobile No").ToString
                    Me.TxtAddress.Text = dr.Item("Address").ToString




                End If
                dr.Close()

                con.Close()

            Catch ex As Exception
            'MsgBox(ex.Message)
            End Try

    
    End Sub

    Sub LoadComboComplainerName()
        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            con.ConnectionString = FrmHome.ConnectionString

            Dim strSQL As String = "Select * from [Customer Information] "
            Dim da As New System.Data.SqlClient.SqlDataAdapter(strSQL, con)
            Dim ds As New DataSet
            da.Fill(ds, "[Customer Information]")

            With Me.CmbComplainerName
                .DataSource = ds.Tables("[Customer Information]")
                .ValueMember = "Customer ID"
                .DisplayMember = "Customer Name"
            End With
            con.Close()
            CmbComplainerName.SelectedValue = 0


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FrmCustomerInformation.Show()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        FrmProductInformation.Show()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        LoadComboComplainerName()
    End Sub

  
End Class