Imports System.Data
Imports System.Data.SqlClient
Imports System.IO


Public Class FrmSupplierInformation
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point
    Dim ChartOfAccountIDforOpeningBalanceAdd As String

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click


        'Data Update Code
        Dim con As New SqlConnection
        Dim con2 As New SqlConnection

        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim cmd3 As New SqlCommand

        Dim dr2 As SqlDataReader
        Dim cmd2 As New SqlCommand
        Dim cmd5 As New SqlCommand
        Dim cmd6 As New SqlCommand
        Dim cmd7 As New SqlCommand

        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now

        Dim AccountsReceivable As String
        AccountsReceivable = Val(TxtOpeningBalance.Text) * -1


        Try
            'Empty Supplier ID Can Not Be Update
            If Me.TxtSupplierID.Text = "" Then
                MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Supplier Information")

                'Empty Text Box Can Not Be update Code
            ElseIf Me.CmbSupplierCategoryID.SelectedValue = -1 Or Me.CmbSupplierCategoryID.Text = "" Or Me.CmbSupplierName.Text = "" Or Me.CmbStatus.Text = "" Or Me.CmbSmsNotification.Text = "" Or Me.TxtDiscountPercentage.Text = "" Then
                MsgBox("Required field can not be empty", MsgBoxStyle.Critical, "Product Information")

            Else

                If Not Me.SupplierPictureBox.Image Is Nothing Then

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd1.Connection = con
                    cmd3.Connection = con
                    cmd5.Connection = con

                    cmd.CommandText = "UPDATE [Supplier Information] SET [Supplier Category ID]= '" + CmbSupplierCategoryID.SelectedValue.ToString + "', [Supplier Name]= '" + CmbSupplierName.Text + "',[Company Name] = '" + TxtCompanyName.Text + "',[Designation]= '" + TxtDesignation.Text + "',[Mobile No]= '" + TxtMobileNo.Text + "',[Email Address]= '" + TxtEmailAddress.Text + "',[Address]= '" + TxtAddress.Text + "',[Web Address]= '" + TxtWebAddress.Text + "',[City]= '" + TxtCity.Text + "',[Country]= '" + TxtCountry.Text + "',[Sms Notification]= '" + CmbSmsNotification.Text + "',[Status]= '" + CmbSmsNotification.Text + "',[Discount Percentage]= '" + TxtDiscountPercentage.Text + "',[Supplier Image]=@test,[Computer ID]= '" + FrmHome.LblComputerID.Text + "',[User Account ID]='" + FrmHome.LblUserID.Text + "',[Branch ID]='" + FrmHome.lblBranchID.Text + "' WHERE [Supplier ID]= '" + TxtSupplierID.Text + "'   INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES ('" + Me.Text + "','UPDATE', 'Supplier ID: " + TxtSupplierID.Text + " , Supplier Name: " + CmbSupplierName.Text + " , Supplier Category ID: " + CmbSupplierCategoryID.Text + ",  Company Name: " + TxtCompanyName.Text + " , Designation: " + TxtDesignation.Text + ",  Mobile No: " + TxtMobileNo.Text + " ,  Email Address: " + TxtEmailAddress.Text + " ,  Address: " + TxtAddress.Text + " ,  Web Address: " + TxtWebAddress.Text + " ,  Opening Balance: " + TxtOpeningBalance.Text + " ,  Opening Balance Date: " + DtpLedgerDate.Value + " ,  City: " + TxtCity.Text + " ,  Country: " + TxtCountry.Text + " ,  Status: " + CmbStatus.Text + " ,  SMS Notification: " + CmbSmsNotification.Text + " ,  Discount Percentage: " + TxtDiscountPercentage.Text + " ,  Product ID: " + CmbProductID.Text + " ,  Price: " + TxtPrice.Text + " ' ,'" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtSupplierID.Text + "' )"
                    cmd1.CommandText = "UPDATE [Customer Information] SET [Customer Name]= '" + CmbSupplierName.Text + "',[Company Name] = '" + TxtCompanyName.Text + "',[Designation]= '" + TxtDesignation.Text + "',[Mobile No]= '" + TxtMobileNo.Text + "',[Email Address]= '" + TxtEmailAddress.Text + "',[Address]= '" + TxtAddress.Text + "',[Web Address]= '" + TxtWebAddress.Text + "',[City]= '" + TxtCity.Text + "',[Country]= '" + TxtCountry.Text + "',[Sms Notification]= '" + CmbSmsNotification.Text + "',[Status]= '" + CmbSmsNotification.Text + "',[Computer ID]= '" + FrmHome.LblComputerID.Text + "',[User Account ID]='" + FrmHome.LblUserID.Text + "',[Branch ID]='" + FrmHome.lblBranchID.Text + "' WHERE [Supplier ID]= '" + TxtSupplierID.Text + "'"
                    cmd3.CommandText = "UPDATE [Chart Of Account] SET [Account Name]= '" + CmbSupplierName.Text + "'  WHERE [Chart Of Account ID]= '" + ChartOfAccountIDforOpeningBalanceAdd + "'"


                    Dim ms As New MemoryStream()
                    SupplierPictureBox.Image.Save(ms, SupplierPictureBox.Image.RawFormat)
                    Dim data As Byte() = ms.GetBuffer()
                    Dim p As New SqlParameter("@test", SqlDbType.Image)
                    p.Value = data
                    cmd.Parameters.Add(p)

                    cmd.ExecuteNonQuery()
                    cmd1.ExecuteNonQuery()
                    cmd3.ExecuteNonQuery()



                    cmd5.CommandText = "Select * From [Ledger] WHERE [Chart Of Account ID]= '" + ChartOfAccountIDforOpeningBalanceAdd + "' And [Category Name] = 'Supplier Opening Balance' And [Branch ID]= '" + FrmHome.lblBranchID.Text + "'"
                    If Val(TxtOpeningBalance.Text) >= 0 Then

                        dr2 = cmd5.ExecuteReader
                        dr2.Read()

                        If Not dr2.HasRows Then
                            con2.ConnectionString = FrmHome.ConnectionString
                            con2.Open()
                            cmd6.Connection = con2
                            cmd6.CommandText = "INSERT INTO [Ledger] ([Chart of Account ID],[Credited Amount],[Debited Amount],[Category Name],[Ledger Date],[Prepared Time],[Prepared Date],[Computer ID],[User Account ID],[Branch ID],[Invoice No],[Status],[Description],[Voucher No]) VALUES ('" + ChartOfAccountIDforOpeningBalanceAdd + "','" + TxtOpeningBalance.Text + "','0','Supplier Opening Balance','" + DtpLedgerDate.Value + "','" + currentTime + "','" + currentDate + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.lblBranchID.Text + "','OB','CASH','Opening Balance','OB')"
                            cmd6.ExecuteNonQuery()
                            con2.Close()
                        ElseIf dr2.HasRows Then
                            con2.ConnectionString = FrmHome.ConnectionString
                            con2.Open()
                            cmd1.Connection = con2
                            cmd1.CommandText = "UPDATE [Ledger] SET [Debited Amount]= '00',[Credited Amount]= '" + TxtOpeningBalance.Text + "',[Ledger Date]='" + DtpLedgerDate.Value + "' WHERE [Chart Of Account ID]= '" + ChartOfAccountIDforOpeningBalanceAdd + "' And [Category Name] = 'Supplier Opening Balance' And [Branch ID]='" + FrmHome.lblBranchID.Text + "'"
                            cmd1.ExecuteNonQuery()
                            con2.Close()

                        End If
                        dr2.Close()

                    ElseIf Val(TxtOpeningBalance.Text) < 0 Then

                        dr2 = cmd5.ExecuteReader
                        dr2.Read()

                        If Not dr2.HasRows Then
                            con2.ConnectionString = FrmHome.ConnectionString
                            con2.Open()
                            cmd7.Connection = con2
                            cmd7.CommandText = "INSERT INTO [Ledger] ([Chart of Account ID],[Credited Amount],[Debited Amount],[Category Name],[Ledger Date],[Prepared Time],[Prepared Date],[Computer ID],[User Account ID],[Branch ID],[Invoice No],[Status],[Description],[Voucher No]) VALUES ('" + ChartOfAccountIDforOpeningBalanceAdd + "','0','" + AccountsReceivable + "','Supplier Opening Balance','" + DtpLedgerDate.Value + "','" + currentTime + "','" + currentDate + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.lblBranchID.Text + "','OB','CASH','Opening Balance','OB')"
                            cmd7.ExecuteNonQuery()
                            con2.Close()

                        ElseIf dr2.HasRows Then
                            con2.ConnectionString = FrmHome.ConnectionString
                            con2.Open()
                            cmd2.Connection = con2
                            cmd2.CommandText = "UPDATE [Ledger] SET [Credited Amount]= '00',[Debited Amount]= '" + AccountsReceivable + "',[Ledger Date]='" + DtpLedgerDate.Value + "' WHERE [Chart Of Account ID]= '" + ChartOfAccountIDforOpeningBalanceAdd + "' And [Category Name] = 'Supplier Opening Balance' And [Branch ID]='" + FrmHome.lblBranchID.Text + "'"
                            cmd2.ExecuteNonQuery()
                            con2.Close()

                        End If
                        dr2.Close()
                    End If
                    con.Close()




                ElseIf Me.SupplierPictureBox.Image Is Nothing Then
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd1.Connection = con
                    cmd3.Connection = con
                    cmd5.Connection = con

                    cmd.CommandText = "UPDATE [Supplier Information] SET [Supplier Category ID]= '" + CmbSupplierCategoryID.SelectedValue.ToString + "', [Supplier Name]= '" + CmbSupplierName.Text + "',[Company Name] = '" + TxtCompanyName.Text + "',[Designation]= '" + TxtDesignation.Text + "',[Mobile No]= '" + TxtMobileNo.Text + "',[Email Address]= '" + TxtEmailAddress.Text + "',[Address]= '" + TxtAddress.Text + "',[Web Address]= '" + TxtWebAddress.Text + "',[City]= '" + TxtCity.Text + "',[Country]= '" + TxtCountry.Text + "',[Sms Notification]= '" + CmbSmsNotification.Text + "',[Status]= '" + CmbStatus.Text + "',[Discount Percentage]= '" + TxtDiscountPercentage.Text + "',[Supplier Image]='" + Nothing + "',[Computer ID]= '" + FrmHome.LblComputerID.Text + "',[User Account ID]='" + FrmHome.LblUserID.Text + "',[Branch ID]='" + FrmHome.lblBranchID.Text + "' WHERE [Supplier ID]= '" + TxtSupplierID.Text + "'   INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES ('" + Me.Text + "','UPDATE', 'Supplier ID: " + TxtSupplierID.Text + " , Supplier Name: " + CmbSupplierName.Text + " , Supplier Category ID: " + CmbSupplierCategoryID.Text + ",  Company Name: " + TxtCompanyName.Text + " , Designation: " + TxtDesignation.Text + ",  Mobile No: " + TxtMobileNo.Text + " ,  Email Address: " + TxtEmailAddress.Text + " ,  Address: " + TxtAddress.Text + " ,  Web Address: " + TxtWebAddress.Text + " ,  Opening Balance: " + TxtOpeningBalance.Text + " ,  Opening Balance Date: " + DtpLedgerDate.Value + " ,  City: " + TxtCity.Text + " ,  Country: " + TxtCountry.Text + " ,  Status: " + CmbStatus.Text + " ,  SMS Notification: " + CmbSmsNotification.Text + " ,  Discount Percentage: " + TxtDiscountPercentage.Text + " ,  Product ID: " + CmbProductID.Text + " ,  Price: " + TxtPrice.Text + " ' ,'" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtSupplierID.Text + "' )"
                    cmd1.CommandText = "UPDATE [Customer Information] SET [Customer Name]= '" + CmbSupplierName.Text + "',[Company Name] = '" + TxtCompanyName.Text + "',[Designation]= '" + TxtDesignation.Text + "',[Mobile No]= '" + TxtMobileNo.Text + "',[Email Address]= '" + TxtEmailAddress.Text + "',[Address]= '" + TxtAddress.Text + "',[Web Address]= '" + TxtWebAddress.Text + "',[City]= '" + TxtCity.Text + "',[Country]= '" + TxtCountry.Text + "',[Sms Notification]= '" + CmbStatus.Text + "',[Status]= '" + CmbStatus.Text + "',[Computer ID]= '" + FrmHome.LblComputerID.Text + "',[User Account ID]='" + FrmHome.LblUserID.Text + "',[Branch ID]='" + FrmHome.lblBranchID.Text + "' WHERE [Supplier ID]= '" + TxtSupplierID.Text + "'"
                    cmd3.CommandText = "UPDATE [Chart Of Account] SET [Account Name]= '" + CmbSupplierName.Text + "'  WHERE [Chart Of Account ID]= '" + ChartOfAccountIDforOpeningBalanceAdd + "'"

                    cmd.ExecuteNonQuery()
                    cmd1.ExecuteNonQuery()
                    cmd3.ExecuteNonQuery()

                    cmd5.CommandText = "Select * From [Ledger] WHERE [Chart Of Account ID]= '" + ChartOfAccountIDforOpeningBalanceAdd + "' And [Category Name] = 'Supplier Opening Balance' And [Branch ID]='" + FrmHome.lblBranchID.Text + "'"
                    If Val(TxtOpeningBalance.Text) >= 0 Then

                        dr2 = cmd5.ExecuteReader
                        dr2.Read()

                        If Not dr2.HasRows Then
                            con2.ConnectionString = FrmHome.ConnectionString
                            con2.Open()
                            cmd6.Connection = con2
                            cmd6.CommandText = "INSERT INTO [Ledger] ([Chart of Account ID],[Credited Amount],[Debited Amount],[Category Name],[Ledger Date],[Prepared Time],[Prepared Date],[Computer ID],[User Account ID],[Branch ID],[Invoice No],[Status],[Description],[Voucher No]) VALUES ('" + ChartOfAccountIDforOpeningBalanceAdd + "','" + TxtOpeningBalance.Text + "','0','Supplier Opening Balance','" + DtpLedgerDate.Value + "','" + currentTime + "','" + currentDate + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.lblBranchID.Text + "','OB','CASH','Opening Balance','OB')"
                            cmd6.ExecuteNonQuery()
                            con2.Close()
                        ElseIf dr2.HasRows Then
                            con2.ConnectionString = FrmHome.ConnectionString
                            con2.Open()
                            cmd1.Connection = con2
                            cmd1.CommandText = "UPDATE [Ledger] SET [Debited Amount]= '00',[Credited Amount]= '" + TxtOpeningBalance.Text + "',[Ledger Date]='" + DtpLedgerDate.Value + "' WHERE [Chart Of Account ID]= '" + ChartOfAccountIDforOpeningBalanceAdd + "' And [Category Name] = 'Supplier Opening Balance' And [Branch ID]='" + FrmHome.lblBranchID.Text + "'"
                            cmd1.ExecuteNonQuery()
                            con2.Close()

                        End If
                        dr2.Close()

                    ElseIf Val(TxtOpeningBalance.Text) < 0 Then

                        dr2 = cmd5.ExecuteReader
                        dr2.Read()

                        If Not dr2.HasRows Then
                            con2.ConnectionString = FrmHome.ConnectionString
                            con2.Open()
                            cmd7.Connection = con2
                            cmd7.CommandText = "INSERT INTO [Ledger] ([Chart of Account ID],[Credited Amount],[Debited Amount],[Category Name],[Ledger Date],[Prepared Time],[Prepared Date],[Computer ID],[User Account ID],[Branch ID],[Invoice No],[Status],[Description],[Voucher No]) VALUES ('" + ChartOfAccountIDforOpeningBalanceAdd + "','0','" + TxtOpeningBalance.Text + "','Supplier Opening Balance','" + DtpLedgerDate.Value + "','" + currentTime + "','" + currentDate + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.lblBranchID.Text + "','OB','CASH','Opening Balance','OB')"
                            cmd7.ExecuteNonQuery()
                            con2.Close()

                        ElseIf dr2.HasRows Then
                            con2.ConnectionString = FrmHome.ConnectionString
                            con2.Open()
                            cmd2.Connection = con2
                            cmd2.CommandText = "UPDATE [Ledger] SET [Debited Amount]= '" + AccountsReceivable + "',[Credited Amount]= '0',[Ledger Date]='" + DtpLedgerDate.Value + "' WHERE [Chart Of Account ID]= '" + ChartOfAccountIDforOpeningBalanceAdd + "' And [Category Name] = 'Supplier Opening Balance' And [Branch ID]='" + FrmHome.lblBranchID.Text + "'"
                            cmd2.ExecuteNonQuery()
                            con2.Close()

                        End If
                        dr2.Close()
                    End If


                    con.Close()

                End If

                'Update Click Msg
                MsgBox("Data Updated Successfully", MsgBoxStyle.OkOnly, "Supplier Information")

                'Making Clear
                ClearData()


                'Load Combobox Supplier
                LoadComboBoxSupplier()

                'Refresh Data
                RefreshData()
            End If
        Catch ex As Exception
            MessageBox.Show("Error while Updating record on table..." & ex.Message, "Update Records")
        Finally

        End Try

    End Sub

    'Creating Privet sub of Clearing text
    Sub ClearData()

        Try
            TxtSupplierID.Text = ""

            CmbSupplierCategoryID.SelectedValue = 0

            CmbSupplierName.Text = ""
            TxtCompanyName.Text = ""
            TxtDesignation.Text = ""
            TxtMobileNo.Text = ""
            TxtEmailAddress.Text = ""
            TxtAddress.Text = ""
            TxtWebAddress.Text = ""
            TxtCity.Text = ""
            TxtCountry.Text = ""

            CmbStatus.SelectedIndex = -1
            CmbStatus.Text = ""

            CmbSmsNotification.SelectedIndex = -1
            CmbSmsNotification.Text = ""


            TxtDiscountPercentage.Text = ""

            Me.SupplierPictureBox.Image = Nothing


            CmbProductID.Text = ""
            CmbProductID.ValueMember = ""
            TxtPrice.Text = ""

            TxtOpeningBalance.Text = ""
            lblListID.Text = "00"

            DtpLedgerDate.Value = Now


        Catch ex As Exception
            MessageBox.Show("Error while Clearing record on table..." & ex.Message, "Clear Records")
        Finally

        End Try

    End Sub

    'Clear Data Product Price
    Sub ClearDataProductPrice()

        CmbProductID.Text = ""
        CmbProductID.ValueMember = ""
        TxtPrice.Text = ""
        lblListID.Text = "00"


    End Sub
    'Creating Privet Sub of Refreshing Data
    Sub RefreshData()

        Try

 
            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Supplier Information].[Supplier ID],[Supplier Information].[Supplier Name],[Supplier Category].[Supplier Category Name],[Supplier Information].[Company Name],[Supplier Information].[Designation],[Supplier Information].[Mobile No],[Supplier Information].[Email Address],[Supplier Information].[Address],[Supplier Information].[Web Address],[Supplier Information].[City],[Supplier Information].[Country],[Supplier Information].[SMS Notification],[Supplier Information].[Status],[Supplier Information].[Discount Percentage] FROM [Supplier Information] Join [Supplier Category] on [Supplier Information].[Supplier Category ID]=[Supplier Category].[Supplier Category ID] order by [Supplier ID] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Supplier Information")
            connection.Close()
            GrdSupplierInformation.DataSource = ds
            GrdSupplierInformation.DataMember = "BizPro_Supplier Information"

            'GrdSupplierInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdSupplierInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)



            'Number of row count
            NUmberOfRow()

            'End Refresh Data

            RefreshDataProductSpecificSupplier()

            'End Refresh Data
        Catch ex As Exception
            MessageBox.Show("Error while refreshing record on table..." & ex.Message, "Refresh Records")
        Finally


        End Try



    End Sub

    'Creating Privet Sub of Refreshing Product Data
    Sub RefreshDataProductSpecificSupplier()

        Try



            ' Load Data
            
            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Supplier price list].[Supplier price list ID][ID],[Products].[Product Name],[Supplier Price list].[Price] FROM [Supplier Price list] Join [Products] on [Supplier Price list].[Product ID]=[Products].[Product ID] where [Supplier price list].[Supplier ID]='" + TxtSupplierID.Text + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Supplier Information")
            connection.Close()
            GrdPriceList.DataSource = ds
            GrdPriceList.DataMember = "BizPro_Supplier Information"

            'GrdSupplierInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdSupplierInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdPriceList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


            'Number of row count


            'End Refresh Data
        Catch ex As Exception
            MessageBox.Show("Error while refreshing record on table..." & ex.Message, "Refresh Records")
        Finally


        End Try

        'End Refresh Data

    End Sub
    Sub NUmberOfRow()

        'Total gridview line show in label code
        Dim total As String = 0

        total = GrdSupplierInformation.Rows.Count

        Me.Label15.Text = total


    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        'Empty Product Group ID Can Not Be Delete
        If Me.TxtSupplierID.Text = "" Then
            MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Supplier Information")

        Else
            'Data Delete Code
            Dim q As MsgBoxResult
            q = MsgBox("Do you really want to Delete the row?", MsgBoxStyle.YesNo, "Supplier Information")
            If q = MsgBoxResult.Yes Then

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim cmd1 As New SqlCommand

                Dim CurrentDate As DateTime = DateTime.Today
                Dim CurrentTime As DateTime = DateTime.Now



                Try
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd1.Connection = con
                    cmd.CommandText = "Delete from [Supplier Information] where [Supplier ID]= '" + TxtSupplierID.Text + "'   INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES ('" + Me.Text + "','DELETE', 'Supplier ID: " + TxtSupplierID.Text + " , Supplier Name: " + CmbSupplierName.Text + " , Supplier Category ID: " + CmbSupplierCategoryID.Text + ",  Company Name: " + TxtCompanyName.Text + " , Designation: " + TxtDesignation.Text + ",  Mobile No: " + TxtMobileNo.Text + " ,  Email Address: " + TxtEmailAddress.Text + " ,  Address: " + TxtAddress.Text + " ,  Web Address: " + TxtWebAddress.Text + " ,  Opening Balance: " + TxtOpeningBalance.Text + " ,  Opening Balance Date: " + DtpLedgerDate.Value + " ,  City: " + TxtCity.Text + " ,  Country: " + TxtCountry.Text + " ,  Status: " + CmbStatus.Text + " ,  SMS Notification: " + CmbSmsNotification.Text + " ,  Discount Percentage: " + TxtDiscountPercentage.Text + " ,  Product ID: " + CmbProductID.Text + " ,  Price: " + TxtPrice.Text + " ' ,'" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtSupplierID.Text + "' )"
                    cmd1.CommandText = "Delete from [Ledger] where [Chart of Account ID]= '" + ChartOfAccountIDforOpeningBalanceAdd + "' And [Category Name]= 'Supplier Opening Balance' "
                    cmd.ExecuteNonQuery()
                    cmd1.ExecuteNonQuery()
                    con.Close()
                    'Making Clear
                    ClearData()

                    'Refresh Data
                    RefreshData()

                    'Load Combobox Supplier
                    LoadComboBoxSupplier()


                Catch ex As Exception
                    MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Records")
                Finally

                End Try

            End If
        End If


    End Sub

    Private Sub FrmSupplierInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
                BtnUpdate.Enabled = True

            ElseIf Not dr.HasRows Then
                BtnDelete.Enabled = False
                BtnUpdate.Enabled = False

            End If



            dr.Close()
            con.Close()


        Catch ex As Exception
            MessageBox.Show("Error while  permission delete to form..." & ex.Message, "Form Load")

        End Try






        'Focus on Supplier Cateogory ID Combo box
        CmbSupplierCategoryID.Focus()

        'change Language
        ChangeLanguage()

        'Load combobox Supplier category
        LoadComboBoxSupplierCategory()

        'Load Combobox Supplier
        LoadComboBoxSupplier()


        'Clear data
        ClearData()

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


                Me.TxtSupplierID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.CmbSupplierCategoryID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.CmbSupplierName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtCompanyName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtDesignation.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtMobileNo.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtEmailAddress.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtAddress.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtWebAddress.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtCity.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtCountry.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtDiscountPercentage.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtSearch.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.CmbProductID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.CmbSearchProductPrice.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtPrice.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtOpeningBalance.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))


                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

                Me.GrdSupplierInformation.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdSupplierInformation.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)
                Me.GrdPriceList.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdPriceList.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)


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
            cmd.CommandText = "select top 1 * from [Supplier Information] where [User account ID]='" + FrmHome.LblUserID.Text + "' and [Computer ID]='" + FrmHome.LblComputerID.Text + "'  order by [Supplier ID] desc"
            dr = cmd.ExecuteReader
            dr.Read()

            If dr.HasRows Then

                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd1.CommandText = "INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES ('" + Me.Text + "','INSERT', 'Supplier ID: " + dr.Item("Supplier ID").ToString + " , Supplier Name: " + CmbSupplierName.Text + " , Supplier Category ID: " + CmbSupplierCategoryID.Text + ",  Company Name: " + TxtCompanyName.Text + " , Designation: " + TxtDesignation.Text + ",  Mobile No: " + TxtMobileNo.Text + " ,  Email Address: " + TxtEmailAddress.Text + " ,  Address: " + TxtAddress.Text + " ,  Web Address: " + TxtWebAddress.Text + " ,  Opening Balance: " + TxtOpeningBalance.Text + " ,  Opening Balance Date: " + DtpLedgerDate.Value + " ,  City: " + TxtCity.Text + " ,  Country: " + TxtCountry.Text + " ,  Status: " + CmbStatus.Text + " ,  SMS Notification: " + CmbSmsNotification.Text + " ,  Discount Percentage: " + TxtDiscountPercentage.Text + " ,  Product ID: " + CmbProductID.Text + " ,  Price: " + TxtPrice.Text + " ' ,'" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + dr.Item("Supplier ID").ToString + "' )"
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
        'Data Insert Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand


        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now

        Try
            'Same id Twice insert restriction code
            If Not Me.TxtSupplierID.Text = "" Then
                MsgBox("This ID is already Exist.", MsgBoxStyle.OkOnly, "Supplier Information")


            Else
                'Empty Txt Box Can Not Be Save Code
                If Me.CmbSupplierCategoryID.SelectedValue = 0 Or Me.CmbSupplierName.Text = "" Or Me.CmbStatus.Text = "" Or Me.CmbSmsNotification.Text = "" Or Me.TxtDiscountPercentage.Text = "" Then
                    MsgBox("Required field can not be empty", MsgBoxStyle.Critical, "Supplier Information")

                Else
                    If Not Me.SupplierPictureBox.Image Is Nothing Then

                        con.ConnectionString = FrmHome.ConnectionString
                        con.Open()
                        cmd.Connection = con
                        cmd.CommandText = "INSERT INTO [Supplier Information] ([Supplier Category ID],[Supplier Name],[Company Name],[Designation],[Mobile No],[Email Address],[Address],[Web Address],[City],[Country],[Sms Notification],[Status],[Discount Percentage],[Supplier Image],[Prepared Time],[Prepared Date],[Computer ID],[User Account ID],[Branch ID]) VALUES ('" + CmbSupplierCategoryID.SelectedValue.ToString + "','" + CmbSupplierName.Text + "','" + TxtCompanyName.Text + "','" + TxtDesignation.Text + "','" + TxtMobileNo.Text + "','" + TxtEmailAddress.Text + "','" + TxtAddress.Text + "','" + TxtWebAddress.Text + "','" + TxtCity.Text + "','" + TxtCountry.Text + "','" + CmbSmsNotification.Text + "','" + CmbStatus.Text + "','" + TxtDiscountPercentage.Text + "',@test,'" + currentTime + "','" + currentDate + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.lblBranchID.Text + "')"


                        Dim ms As New MemoryStream()
                        SupplierPictureBox.Image.Save(ms, SupplierPictureBox.Image.RawFormat)
                        Dim data As Byte() = ms.GetBuffer()
                        Dim p As New SqlParameter("@test", SqlDbType.Image)
                        p.Value = data
                        cmd.Parameters.Add(p)

                        cmd.ExecuteNonQuery()
                        con.Close()

                        'Insert Into Customer Information
                        InsertIntoCustomerInformation()

                        'Insert into log 
                        InsertIntoLog()

                    ElseIf Me.SupplierPictureBox.Image Is Nothing Then

                        con.ConnectionString = FrmHome.ConnectionString
                        con.Open()
                        cmd.Connection = con
                        cmd.CommandText = "INSERT INTO [Supplier Information] ([Supplier Category ID],[Supplier Name],[Company Name],[Designation],[Mobile No],[Email Address],[Address],[Web Address],[City],[Country],[Sms Notification],[Status],[Discount Percentage],[Prepared Time],[Prepared Date],[Computer ID],[User Account ID],[Branch ID]) VALUES ('" + CmbSupplierCategoryID.SelectedValue.ToString + "','" + CmbSupplierName.Text + "','" + TxtCompanyName.Text + "','" + TxtDesignation.Text + "','" + TxtMobileNo.Text + "','" + TxtEmailAddress.Text + "','" + TxtAddress.Text + "','" + TxtWebAddress.Text + "','" + TxtCity.Text + "','" + TxtCountry.Text + "','" + CmbSmsNotification.Text + "','" + CmbStatus.Text + "','" + TxtDiscountPercentage.Text + "','" + currentTime + "','" + currentDate + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.lblBranchID.Text + "')"
                        cmd.ExecuteNonQuery()
                        con.Close()

                        'Insert Into Customer Information
                        InsertIntoCustomerInformation()

                        'Insert into log 
                        InsertIntoLog()

                    End If

                    'Insert Click Msg
                    MsgBox("Data Inserted Successfully", MsgBoxStyle.OkOnly, "Supplier Information")

                    'Making Clear
                    ClearData()


                    'Refresh Data
                    RefreshData()

                    'Load Combobox Supplier
                    LoadComboBoxSupplier()

                    'Focus on Supplier name combobox
                    CmbSupplierName.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally


        End Try
    End Sub


    'Insert Into Customer Information
    Sub InsertIntoCustomerInformation()

        Try



            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand

            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now

            Dim con2 As New SqlConnection
            Dim cmd2 As New SqlCommand
            Dim dr1 As SqlDataReader


            Dim con3 As New SqlConnection
            Dim cmd3 As New SqlCommand
            Dim dr3 As SqlDataReader


            con2.ConnectionString = FrmHome.ConnectionString
            con2.Open()
            cmd2.Connection = con2
            cmd2.CommandText = "SELECT top 1 [Customer Category ID] FROM [Customer Category]   order by [Customer Category ID] Asc"




            con3.ConnectionString = FrmHome.ConnectionString
            con3.Open()
            cmd3.Connection = con3
            cmd3.CommandText = "SELECT top 1 [Supplier ID] FROM [Supplier Information] where [User Account ID]= '" + FrmHome.LblUserID.Text + "'  order by [Supplier ID] desc"

            dr3 = cmd3.ExecuteReader()
            dr3.Read()

            Dim SupplierID As String
            If dr3.HasRows Then


                SupplierID = (dr3.Item("Supplier ID").ToString)
            End If
            con3.Close()
            dr3.Close()


            'Chart of account and Head of Account Find out
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
            cmd6.CommandText = "SELECT top 1 [Chart of Account ID] FROM [Chart of Account] where [User Account ID]='" + FrmHome.LblUserID.Text + "' and [Computer ID]='" + FrmHome.LblComputerID.Text + "' order by [Chart of Account ID] DESC"

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
            dr6 = cmd6.ExecuteReader()
            dr6.Read()
            If dr6.HasRows Then

                ChartOfAccountID = (dr6.Item("Chart Of Account ID").ToString)

            End If
            dr6.Close()

            con5.Close()




            Dim cmd8 As New SqlCommand
            Dim cmd9 As New SqlCommand

            Dim AccountsReceivable As String
            AccountsReceivable = Val(TxtOpeningBalance.Text) * -1



            dr1 = cmd2.ExecuteReader()
            dr1.Read()

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd8.Connection = con
            cmd9.Connection = con
            cmd.CommandText = "INSERT INTO [Customer Information] ([Customer Name],[Customer Category ID],[Mobile No],[Address],[Company Name] ,[Designation] ,[Web Address],[City] ,[Country] ,[Sms Notification],[Status],[Prepared Time],[Prepared Date],[Computer ID],[User Account ID],[Supplier ID],[Branch ID],[Discount Percentage],[Chart Of Account ID],[Employee ID]) VALUES ('" + CmbSupplierName.Text + "','" + (dr1.Item("Customer Category ID").ToString) + "','" + TxtMobileNo.Text + "','" + TxtAddress.Text + "','" + TxtCompanyName.Text + "', '" + TxtDesignation.Text + "', '" + TxtWebAddress.Text + "', '" + TxtCity.Text + "', '" + TxtCountry.Text + "', '" + CmbSmsNotification.Text + "','" + CmbStatus.Text + "','" + currentTime + "','" + currentDate + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + SupplierID + "','" + FrmHome.lblBranchID.Text + "','0','" + ChartOfAccountID + "','" + FrmHome.EmployeeID.ToString + "')"
            cmd8.CommandText = "INSERT INTO [Ledger] ([Chart of Account ID],[Credited Amount],[Debited Amount],[Category Name],[Ledger Date],[Prepared Time],[Prepared Date],[Computer ID],[User Account ID],[Branch ID],[Invoice No],[Status],[Description],[Voucher No]) VALUES ('" + ChartOfAccountID + "','" + TxtOpeningBalance.Text + "','0','Supplier Opening Balance','" + DtpLedgerDate.Value + "','" + currentTime + "','" + currentDate + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.lblBranchID.Text + "','OB','CASH','Opening Balance','OB')"
            cmd9.CommandText = "INSERT INTO [Ledger] ([Chart of Account ID],[Credited Amount],[Debited Amount],[Category Name],[Ledger Date],[Prepared Time],[Prepared Date],[Computer ID],[User Account ID],[Branch ID],[Invoice No],[Status],[Description],[Voucher No]) VALUES ('" + ChartOfAccountID + "','0','" + AccountsReceivable + "','Supplier Opening Balance','" + DtpLedgerDate.Value + "','" + currentTime + "','" + currentDate + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.lblBranchID.Text + "','OB','CASH','Opening Balance','OB')"
            con2.Close()
            dr1.Close()
            cmd.ExecuteNonQuery()



            If Val(TxtOpeningBalance.Text) > 0 Then
                cmd8.ExecuteNonQuery()
            ElseIf Val(TxtOpeningBalance.Text) < 0 Then
                cmd9.ExecuteNonQuery()
            End If

            con.Close()
            con2.Close()


        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records Customer")
        Finally

        End Try

    End Sub

    'Load Combobox Supplier
    Sub LoadComboBoxSupplier()

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

            'Supplier Category clear code
            CmbSupplierName.SelectedValue = 0

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub LoadComboBoxSupplierCategory()

        Try


            Dim con1 As New SqlConnection
            Dim cmd1 As New SqlCommand
            con1.ConnectionString = FrmHome.ConnectionString

            Dim strSQL1 As String = "SELECT [Supplier Category ID],[Supplier Category Name] FROM [Supplier Category]"
            Dim da1 As New System.Data.SqlClient.SqlDataAdapter(strSQL1, con1)
            Dim ds1 As New DataSet
            da1.Fill(ds1, "[Supplier Category]")

            With Me.CmbSupplierCategoryID
                .DataSource = ds1.Tables("[Supplier Category]")
                .ValueMember = "Supplier Category ID"
                .DisplayMember = "Supplier Category Name"
            End With
            con1.Close()

            'Supplier Category clear code
            CmbSupplierCategoryID.SelectedValue = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        'Enable Group Box
        GrpSupplierInformation.Enabled = True
    End Sub

    Private Sub CmbSupplierCategory_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        'Focus on Supplier Name
        If e.KeyCode = Keys.Enter Then
            Me.CmbSupplierName.Focus()
        End If




    End Sub

    Private Sub CmbSupplierCategoryID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    End Sub

    Private Sub CmbSupplierCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub TxtCompanyName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCompanyName.KeyDown

        'Focus on Designation Text Box on Enter
        If e.KeyCode = Keys.Enter Then
            Me.TxtDesignation.Focus()

        End If
    End Sub

    Private Sub TxtCompanyName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCompanyName.TextChanged
        'Change all text entered to be Upercase.
        'TxtCompanyName.CharacterCasing = CharacterCasing.Upper

    End Sub

    Private Sub TxtDesignation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDesignation.KeyDown
        'Focus on Mobile No Text Box on Enter
        If e.KeyCode = Keys.Enter Then
            Me.TxtMobileNo.Focus()

        End If
    End Sub

    Private Sub TxtDesignation_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDesignation.TextChanged

    End Sub

    Private Sub TxtMobileNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtMobileNo.KeyDown
        'Focus on Email Address Text Box on Enter
        If e.KeyCode = Keys.Enter Then
            Me.TxtEmailAddress.Focus()

        End If
    End Sub

    Private Sub TxtMobileNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtMobileNo.TextChanged

    End Sub

    Private Sub TxtEmailAddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtEmailAddress.KeyDown
        'Focus on Address Text Box on Enter
        If e.KeyCode = Keys.Enter Then
            Me.TxtAddress.Focus()

        End If
    End Sub

    Private Sub TxtEmailAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtEmailAddress.TextChanged

    End Sub

    Private Sub TxtAddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtAddress.KeyDown
        'Focus on Web Address Text Box on Enter
        If e.KeyCode = Keys.Enter Then
            Me.TxtWebAddress.Focus()

        End If
    End Sub

    Private Sub TxtAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtAddress.TextChanged

    End Sub

    Private Sub TxtWebAddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtWebAddress.KeyDown
        'Focus on City Text Box on Enter
        If e.KeyCode = Keys.Enter Then
            Me.TxtCity.Focus()

        End If
    End Sub

    Private Sub TxtWebAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtWebAddress.TextChanged

    End Sub

    Private Sub TxtCity_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCity.KeyDown
        'Focus on Country Text Box on Enter
        If e.KeyCode = Keys.Enter Then
            Me.TxtCountry.Focus()

        End If
    End Sub

    Private Sub TxtCity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCity.TextChanged

    End Sub

    Private Sub TxtCountry_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCountry.KeyDown
        'Focus on Status combo Box on Enter
        If e.KeyCode = Keys.Enter Then
            Me.CmbStatus.Focus()

        End If
    End Sub

    Private Sub TxtCountry_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCountry.TextChanged

    End Sub

    Private Sub CmbStatus_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbSmsNotification.KeyDown
        'Focus on Discount Percentage Text Box on Enter
        If e.KeyCode = Keys.Enter Then
            Me.TxtDiscountPercentage.Focus()

        End If
    End Sub

    Private Sub CmbStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSmsNotification.SelectedIndexChanged
        'Focus on Dicount percentage
        TxtDiscountPercentage.Focus()
    End Sub

    Private Sub CmbSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbSearch.KeyDown
        'Focus on Search Text Box on Enter
        If e.KeyCode = Keys.Enter Then
            Me.TxtSearch.Focus()

        End If
    End Sub

    Private Sub CmbSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSearch.SelectedIndexChanged
        If CmbSearch.SelectedIndex = 5 Then
            TxtSearch.Visible = False
            CmbSearchProductPrice.Visible = True
            CmbSearchProductPrice.Focus()
            LblF4Lbl.Visible = True
        Else
            TxtSearch.Visible = True
            CmbSearchProductPrice.Visible = False
            TxtSearch.Focus()
            LblF4Lbl.Visible = False
        End If

    End Sub

    Private Sub TxtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearch.KeyDown
        'Group Box Enebled 
        If e.KeyCode = Keys.Enter Then
            Try



                'Search Code
                ' Load Data
               
                Dim connectionString As String = FrmHome.ConnectionString
                If Me.CmbSearch.SelectedIndex = 0 Then

                    Dim sql As String = "SELECT [Supplier Information].[Supplier ID],[Supplier Information].[Supplier Name],[Supplier Category].[Supplier Category Name],[Supplier Information].[Company Name],[Supplier Information].[Designation],[Supplier Information].[Mobile No],[Supplier Information].[Email Address],[Supplier Information].[Address],[Supplier Information].[Web Address],[Supplier Information].[City],[Supplier Information].[Country],[Supplier Information].[SMS Notification],[Supplier Information].[Status],[Supplier Information].[Discount Percentage] FROM [Supplier Information] Join [Supplier Category] on [Supplier Information].[Supplier Category ID]=[Supplier Category].[Supplier Category ID] WHERE ([Supplier Information].[Supplier ID]  = '" + Me.TxtSearch.Text + "')"
                    Dim connection As New SqlConnection(connectionString)
                    Dim dataadapter As New SqlDataAdapter(sql, connection)
                    Dim ds As New DataSet()
                    connection.Open()
                    dataadapter.Fill(ds, "BizPro_Supplier Information")
                    connection.Close()
                    GrdSupplierInformation.DataSource = ds
                    GrdSupplierInformation.DataMember = "BizPro_Supplier Information"
                    'GrdSupplierInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                    'Row Count
                    NUmberOfRow()



                ElseIf Me.CmbSearch.SelectedIndex = 3 Then


                    Dim sql As String = "SELECT [Supplier Information].[Supplier ID],[Supplier Information].[Supplier Name],[Supplier Category].[Supplier Category Name],[Supplier Information].[Company Name],[Supplier Information].[Designation],[Supplier Information].[Mobile No],[Supplier Information].[Email Address],[Supplier Information].[Address],[Supplier Information].[Web Address],[Supplier Information].[City],[Supplier Information].[Country],[Supplier Information].[SMS Notification],[Supplier Information].[Status],[Supplier Information].[Discount Percentage] FROM [Supplier Information] Join [Supplier Category] on [Supplier Information].[Supplier Category ID]=[Supplier Category].[Supplier Category ID] WHERE ([Supplier Information].[Mobile No]  = '" + Me.TxtSearch.Text + "')"
                    Dim connection As New SqlConnection(connectionString)
                    Dim dataadapter As New SqlDataAdapter(sql, connection)
                    Dim ds As New DataSet()
                    connection.Open()
                    dataadapter.Fill(ds, "BizPro_Supplier Information")
                    connection.Close()
                    GrdSupplierInformation.DataSource = ds
                    GrdSupplierInformation.DataMember = "BizPro_Supplier Information"
                    'GrdSupplierInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                    'Row Count
                    NUmberOfRow()



                End If

            Catch ex As Exception
                MessageBox.Show("Error while searching records on table..." & ex.Message, "Search Records on Button")
            Finally

            End Try

        End If



    End Sub

    Sub SearchProductPriceBySupplier()


        'Search Code
        ' Load Data
        
        Dim connectionString As String = FrmHome.ConnectionString
        If Me.CmbSearch.SelectedIndex = 5 Then

            Dim sql As String = "SELECT [Supplier Information].[Supplier ID],[Supplier Information].[Supplier Name],[Supplier Category].[Supplier Category Name],[Supplier Information].[Company Name],[products].[Product Name],[Supplier Price List].[Price],[Supplier Information].[Mobile No],[Supplier Information].[Address],[Supplier Information].[Email Address],[Supplier Information].[Designation],[Supplier Information].[Web Address],[Supplier Information].[City],[Supplier Information].[Country],[Supplier Information].[SMS Notification],[Supplier Information].[Status],[Supplier Information].[Discount Percentage] FROM [Supplier Information] Join [Supplier Category] on [Supplier Information].[Supplier Category ID]=[Supplier Category].[Supplier Category ID] join [Supplier Price List] on [supplier information].[Supplier ID]=[Supplier Price List].[Supplier ID]  join [Products] on [Supplier Price List].[product ID]=[Products].[Product ID]  WHERE ([products].[Product ID]  = '" + CmbSearchProductPrice.ValueMember + "')  order by [Supplier Price List].[Price] asc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Supplier Price List")
            GrdSupplierInformation.DataSource = ds
            GrdSupplierInformation.DataMember = "BizPro_Supplier Price List"
            'GrdSupplierInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            'Row Count
            NUmberOfRow()

        End If


    End Sub

    Private Sub TxtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearch.TextChanged
        Try



            'Search Code
            ' Load Data
       

            Dim connectionString As String = FrmHome.ConnectionString
            If Me.CmbSearch.SelectedIndex = 1 Then

                Dim sql As String = "SELECT [Supplier Information].[Supplier ID],[Supplier Information].[Supplier Name],[Supplier Category].[Supplier Category Name],[Supplier Information].[Company Name],[Supplier Information].[Designation],[Supplier Information].[Mobile No],[Supplier Information].[Email Address],[Supplier Information].[Address],[Supplier Information].[Web Address],[Supplier Information].[City],[Supplier Information].[Country],[Supplier Information].[SMS Notification],[Supplier Information].[Status],[Supplier Information].[Discount Percentage] FROM [Supplier Information] Join [Supplier Category] on [Supplier Information].[Supplier Category ID]=[Supplier Category].[Supplier Category ID] WHERE ([Supplier Information].[Supplier Name]  Like '%" + Me.TxtSearch.Text + "%')"
                Dim connection As New SqlConnection(connectionString)
                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Supplier Information")
                connection.Close()
                GrdSupplierInformation.DataSource = ds
                GrdSupplierInformation.DataMember = "BizPro_Supplier Information"
                'GrdSupplierInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                'Row Count
                NUmberOfRow()

                
            ElseIf Me.CmbSearch.SelectedIndex = 2 Then


                Dim sql As String = "SELECT [Supplier Information].[Supplier ID],[Supplier Information].[Supplier Name],[Supplier Category].[Supplier Category Name],[Supplier Information].[Company Name],[Supplier Information].[Designation],[Supplier Information].[Mobile No],[Supplier Information].[Email Address],[Supplier Information].[Address],[Supplier Information].[Web Address],[Supplier Information].[City],[Supplier Information].[Country],[Supplier Information].[SMS Notification],[Supplier Information].[Status],[Supplier Information].[Discount Percentage] FROM [Supplier Information] Join [Supplier Category] on [Supplier Information].[Supplier Category ID]=[Supplier Category].[Supplier Category ID] WHERE ([Supplier Information].[company Name]  Like '%" + Me.TxtSearch.Text + "%')"
                Dim connection As New SqlConnection(connectionString)
                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Supplier Information")
                connection.Close()
                GrdSupplierInformation.DataSource = ds
                GrdSupplierInformation.DataMember = "BizPro_Supplier Information"
                'GrdSupplierInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                'Row Count
                NUmberOfRow()



            ElseIf Me.CmbSearch.SelectedIndex = 4 Then


                Dim sql As String = "SELECT [Supplier Information].[Supplier ID],[Supplier Information].[Supplier Name],[Supplier Category].[Supplier Category Name],[Supplier Information].[Company Name],[Supplier Information].[Designation],[Supplier Information].[Mobile No],[Supplier Information].[Email Address],[Supplier Information].[Address],[Supplier Information].[Web Address],[Supplier Information].[City],[Supplier Information].[Country],[Supplier Information].[SMS Notification],[Supplier Information].[Status],[Supplier Information].[Discount Percentage] FROM [Supplier Information] Join [Supplier Category] on [Supplier Information].[Supplier Category ID]=[Supplier Category].[Supplier Category ID] WHERE ([Supplier Category].[Supplier Category Name]  Like '%" + Me.TxtSearch.Text + "%')"
                Dim connection As New SqlConnection(connectionString)
                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Supplier Information")
                connection.Close()
                GrdSupplierInformation.DataSource = ds
                GrdSupplierInformation.DataMember = "BizPro_Supplier Information"
                'GrdSupplierInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                'Row Count
                NUmberOfRow()


            End If

        Catch ex As Exception
            MessageBox.Show("Error while searching records on table..." & ex.Message, "Search Records")
        Finally

        End Try
    End Sub

    Private Sub CmbSmsNotification_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbStatus.KeyDown
        'Focus on Status Combo Box
        If e.KeyCode = Keys.Enter Then
            Me.CmbSmsNotification.Focus()

        End If
    End Sub

    Private Sub CmbSmsNotification_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbStatus.SelectedIndexChanged
        'Focus on sms notification number
        CmbStatus.Focus()
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click

        Try
            'Refresh Data
            RefreshData()



        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records Refresh Button")
        Finally

        End Try

    End Sub

    Private Sub GrdSupplierInformation_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdSupplierInformation_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)


    End Sub

    Private Sub GrdSupplierInformation_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdSupplierInformation_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

    End Sub


    Private Sub BtnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click

        Try
            'Making Clear
            ClearData()

            'show status= connected and sms notification= on 
            CmbSmsNotification.SelectedIndex = 0
            CmbStatus.SelectedIndex = 0
            TxtDiscountPercentage.Text = "0"

            'Focus on Transaction Date
            Me.CmbSupplierName.Focus()


        Catch ex As Exception
            MessageBox.Show("Error while adding data on table..." & ex.Message, "Add New Button")
        Finally

        End Try
    End Sub

    Private Sub GrpSupplierInformation_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrpSupplierInformation.Enter

    End Sub

    Private Sub BtnSupplierCategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnChoose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnChoose.Click

        'Image choose button code
        Dim Getimage As Integer
        OpenFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*"
        Getimage = OpenFileDialog1.ShowDialog()
        If Getimage = Windows.Forms.DialogResult.OK Then
            SupplierPictureBox.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub BtnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemove.Click
        Me.SupplierPictureBox.Image = Nothing
    End Sub

    Private Sub BtnSearch_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnSearch_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        Try



            'Search Code
            ' Load Data
           
            Dim connectionString As String = FrmHome.ConnectionString
            If Me.CmbSearch.SelectedIndex = 0 Then

                Dim sql As String = "SELECT [Supplier Information].[Supplier ID],[Supplier Information].[Supplier Name],[Supplier Category].[Supplier Category Name],[Supplier Information].[Company Name],[Supplier Information].[Designation],[Supplier Information].[Mobile No],[Supplier Information].[Email Address],[Supplier Information].[Address],[Supplier Information].[Web Address],[Supplier Information].[City],[Supplier Information].[Country],[Supplier Information].[SMS Notification],[Supplier Information].[Status],[Supplier Information].[Discount Percentage] FROM [Supplier Information] Join [Supplier Category] on [Supplier Information].[Supplier Category ID]=[Supplier Category].[Supplier Category ID] WHERE ([Supplier Information].[Supplier ID]  = '" + Me.TxtSearch.Text + "')"
                Dim connection As New SqlConnection(connectionString)
                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Supplier Information")
                connection.Close()
                GrdSupplierInformation.DataSource = ds
                GrdSupplierInformation.DataMember = "BizPro_Supplier Information"
                'GrdSupplierInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                'Row Count
                NUmberOfRow()



            ElseIf Me.CmbSearch.SelectedIndex = 3 Then


                Dim sql As String = "SELECT [Supplier Information].[Supplier ID],[Supplier Information].[Supplier Name],[Supplier Category].[Supplier Category Name],[Supplier Information].[Company Name],[Supplier Information].[Designation],[Supplier Information].[Mobile No],[Supplier Information].[Email Address],[Supplier Information].[Address],[Supplier Information].[Web Address],[Supplier Information].[City],[Supplier Information].[Country],[Supplier Information].[SMS Notification],[Supplier Information].[Status],[Supplier Information].[Discount Percentage] FROM [Supplier Information] Join [Supplier Category] on [Supplier Information].[Supplier Category ID]=[Supplier Category].[Supplier Category ID] WHERE ([Supplier Information].[Mobile No]  = '" + Me.TxtSearch.Text + "')"
                Dim connection As New SqlConnection(connectionString)
                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Supplier Information")
                connection.Close()
                GrdSupplierInformation.DataSource = ds
                GrdSupplierInformation.DataMember = "BizPro_Supplier Information"
                'GrdSupplierInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                'Row Count
                NUmberOfRow()



            ElseIf Me.CmbSearch.SelectedIndex = 5 Then

                Dim sql As String = "SELECT [Supplier Information].[Supplier ID],[Supplier Information].[Supplier Name],[Supplier Category].[Supplier Category Name],[Supplier Information].[Company Name],[products].[Product Name],[Supplier Price List].[Price],[Supplier Information].[Mobile No],[Supplier Information].[Address],[Supplier Information].[Email Address],[Supplier Information].[Designation],[Supplier Information].[Web Address],[Supplier Information].[City],[Supplier Information].[Country],[Supplier Information].[SMS Notification],[Supplier Information].[Status],[Supplier Information].[Discount Percentage] FROM [Supplier Information] Join [Supplier Category] on [Supplier Information].[Supplier Category ID]=[Supplier Category].[Supplier Category ID] join [Supplier Price List] on [supplier information].[Supplier ID]=[Supplier Price List].[Supplier ID]  join [Products] on [Supplier Price List].[product ID]=[Products].[Product ID]  WHERE ([products].[Product ID]  = '" + CmbSearchProductPrice.ValueMember + "')  order by [Supplier Price List].[Price] asc"
                Dim connection As New SqlConnection(connectionString)
                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Supplier Price List")
                connection.Close()
                GrdSupplierInformation.DataSource = ds
                GrdSupplierInformation.DataMember = "BizPro_Supplier Price List"
                'GrdSupplierInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                'Row Count
                NUmberOfRow()


            End If

        Catch ex As Exception
            MessageBox.Show("Error while searching records on table..." & ex.Message, "Search Records on Button")
        Finally

        End Try
    End Sub

    Private Sub CmbSupplierCategoryID_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'Focus on supplier name
        CmbSupplierName.Focus()
    End Sub

    'Add Supplier Price
    Sub AddSupplierPrice()

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        Try
            'Same id Twice insert restriction code
            If Me.TxtSupplierID.Text = "" Then
                MsgBox("Please select a supplier.", MsgBoxStyle.Critical, "Supplier price list")


            Else
                'Empty Txt Box Can Not Be Save Code
                If Me.CmbProductID.ValueMember = "" Or Me.CmbProductID.Text = "" Then
                    MsgBox("Price select a product.", MsgBoxStyle.Critical, "Supplier price list")

                ElseIf Me.TxtPrice.Text = "" Then
                    MsgBox("Price field can not be empty.", MsgBoxStyle.Critical, "Supplier price list")
                Else
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO [Supplier Price List] ([Product ID],[Price],[Supplier ID]) VALUES ('" + CmbProductID.ValueMember + "','" + TxtPrice.Text + "','" + TxtSupplierID.Text + "')"
                    cmd.ExecuteNonQuery()

                    con.Close()

                    'Insert Click Msg
                    MsgBox("Listed Successfully", MsgBoxStyle.OkOnly, "Supplier price list")

                    'Making Clear

                    ClearDataProductPrice()

                    'Refresh Supplier Price List on Specific Supplier
                    RefreshDataProductSpecificSupplier()

                    'Product id focus
                    CmbProductID.Focus()

                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on Supplier Price list..." & ex.Message, "Insert Records Supplier Price list")
        Finally


        End Try
    End Sub

    Private Sub CmbProductID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbProductID.KeyDown

        If e.KeyCode = Keys.F4 Then
            If TxtSupplierID.Text = "" Then
                MsgBox("Please select a supplier first.", MsgBoxStyle.Critical, "Supplier price list")

            Else
                FrmListofProducts.Show()
                FrmListofProducts.TxtSearchProductName.Focus()
                FrmListofProducts.Label1.Text = "Supplier Information"

            End If

        End If
    End Sub

    Private Sub CmbProductID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbProductID.SelectedIndexChanged

    End Sub

    Private Sub GrdPriceList_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdPriceList_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)

    End Sub

    Private Sub GrdPriceList_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

    End Sub



    'Delete Supplier Price
    Sub DeleteSupplierPrice()


        'Data Delete Code
        Dim q As MsgBoxResult
        q = MsgBox("Do you really want to Delete the row?", MsgBoxStyle.YesNo, "Supplier price list")
        If q = MsgBoxResult.Yes Then

            Try


                Dim con As New SqlConnection
                Dim cmd As New SqlCommand


                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "Delete from [Supplier price list] where [Product ID]= '" + CmbProductID.ValueMember + "' and [Supplier ID]='" + TxtSupplierID.Text + "'"
                cmd.ExecuteNonQuery()


                con.Close()

                'Making Clear
                ClearDataProductPrice()

                'Refresh Supplier Price List on Specific Supplier
                RefreshDataProductSpecificSupplier()

                'Product id focus
                CmbProductID.Focus()


            Catch ex As Exception
                MessageBox.Show("Error while Deleting record on Supplier price list..." & ex.Message, "Delete Supplier Price Sub")
            Finally

            End Try

        End If


    End Sub


    'Update Supplier Price
    Sub UpdateSupplierPrice()

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand


        Try
            'Same id Twice insert restriction code
            If Me.TxtSupplierID.Text = "" Then
                MsgBox("Please select a Supplier.", MsgBoxStyle.Critical, "Supplier price list")


            Else
                'Empty Txt Box Can Not Be Save Code
                If Me.CmbProductID.ValueMember = "" Or Me.CmbProductID.Text = "" Then
                    MsgBox("Price select a product.", MsgBoxStyle.Critical, "Supplier price list")

                ElseIf Me.TxtPrice.Text = "" Then
                    MsgBox("Price field can not be empty.", MsgBoxStyle.Critical, "Supplier price list")
                Else

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "UPDATE [Supplier price list] SET [Product ID]='" + CmbProductID.ValueMember + "',[Price]='" + TxtPrice.Text + "',[Supplier ID]='" + TxtSupplierID.Text + "' where [Product ID]= '" + CmbProductID.ValueMember + "' and [Supplier ID]='" + TxtSupplierID.Text + "'"
                    cmd.ExecuteNonQuery()
                    con.Close()


                    'Insert Click Msg
                    MsgBox("Updated Successfully", MsgBoxStyle.OkOnly, "Supplier Information")

                    'Making Clear
                    ClearDataProductPrice()

                    'Refresh Supplier Price List on Specific Supplier
                    RefreshDataProductSpecificSupplier()


                    'Product id focus
                    CmbProductID.Focus()

                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error while Updating record on table..." & ex.Message, "Update Records")
        Finally

        End Try

    End Sub

    Private Sub GrdSupplierInformation_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)



    End Sub

    Private Sub CmbSupplierCategoryID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbSupplierCategoryID.KeyDown

    End Sub

    Private Sub CmbSupplierCategoryID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSupplierCategoryID.SelectedIndexChanged

    End Sub

    Private Sub CmbSupplierCategoryID_SelectedValueChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbSupplierCategoryID.SelectedValueChanged
        'Focus on Company name
        TxtCompanyName.Focus()
    End Sub

    Private Sub CmbSearchProductPrice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbSearchProductPrice.KeyDown

        If e.KeyCode = Keys.F4 Then

            FrmListofProducts.Show()
            FrmListofProducts.TxtSearchProductName.Focus()
            FrmListofProducts.Label1.Text = "Supplier Information Search"



        End If
    End Sub

    Private Sub CmbSearchProductPrice_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSearchProductPrice.SelectedIndexChanged

    End Sub

    Private Sub TxtPrice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPrice.KeyDown
        'Insert or update Supplier price list
        If e.KeyCode = Keys.Enter Then


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Supplier Price List]  WHERE [Product ID] = '" + Me.CmbProductID.ValueMember + "' and [Supplier ID]='" + TxtSupplierID.Text + "' "

            dr = cmd.ExecuteReader()
            dr.Read()

            If Not dr.HasRows Then

                'Add Customer Price
                AddSupplierPrice()

            ElseIf dr.HasRows Then

                'Update Product Price Sub
                UpdateSupplierPrice()

            End If
            dr.Close()
            con.Close()
        End If


    End Sub

    Private Sub TxtPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPrice.TextChanged

    End Sub

    Private Sub GrdPriceList_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

    End Sub

    Private Sub TxtDiscountPercentage_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDiscountPercentage.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtOpeningBalance.Focus()
        End If
    End Sub

    Private Sub TxtDiscountPercentage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDiscountPercentage.TextChanged

    End Sub

    Private Sub TxtOpeningBalance_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtOpeningBalance.TextChanged

    End Sub

    Private Sub TxtSupplierName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbSupplierName.KeyDown
        'Focus on Company Name Text Box on Enter
        If e.KeyCode = Keys.Enter Then
            Me.CmbSupplierCategoryID.Focus()

        End If
    End Sub

    Private Sub TxtSupplierName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSupplierName.SelectedIndexChanged

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

    Private Sub GrdSupplierInformation_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdSupplierInformation.CellContentClick

    End Sub

    Private Sub GrdSupplierInformation_CellMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdSupplierInformation.CellMouseClick
        'Data Grid view code
        Try




            If e.RowIndex >= 0 Then



                Dim row As DataGridViewRow
                row = Me.GrdSupplierInformation.Rows(e.RowIndex)

                TxtSupplierID.Text = row.Cells("Supplier ID").Value.ToString
                CmbSupplierCategoryID.Text = row.Cells("Supplier Category Name").Value.ToString
                CmbSupplierName.Text = row.Cells("Supplier Name").Value.ToString
                TxtCompanyName.Text = row.Cells("Company Name").Value.ToString
                TxtMobileNo.Text = row.Cells("Mobile No").Value.ToString
                TxtDesignation.Text = row.Cells("Designation").Value.ToString
                TxtEmailAddress.Text = row.Cells("Email Address").Value.ToString
                TxtAddress.Text = row.Cells("Address").Value.ToString
                TxtWebAddress.Text = row.Cells("Web Address").Value.ToString
                TxtCity.Text = row.Cells("City").Value.ToString
                TxtCountry.Text = row.Cells("Country").Value.ToString
                CmbSmsNotification.Text = row.Cells("Sms Notification").Value.ToString
                CmbStatus.Text = row.Cells("Status").Value.ToString
                TxtDiscountPercentage.Text = row.Cells("Discount Percentage").Value.ToString
                TxtOpeningBalance.Text = ""

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim cmd1 As New SqlCommand
                Dim cmd2 As New SqlCommand
                Dim dr As SqlDataReader
                Dim dr1 As SqlDataReader
                Dim dr2 As SqlDataReader

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd1.Connection = con
                cmd2.Connection = con
                cmd.CommandText = "SELECT  [Supplier Information].[Supplier Category ID],[Customer Information].[Chart of Account ID] FROM [Supplier Information] join [Customer Information] on [Supplier Information].[Supplier ID]=[Customer Information].[Supplier ID]  WHERE [Supplier Information].[Supplier ID]= '" + Me.TxtSupplierID.Text + "'"




                dr = cmd.ExecuteReader()
                dr.Read()
                If dr.HasRows Then


                    ChartOfAccountIDforOpeningBalanceAdd = dr.Item("Chart of Account ID").ToString
                    Me.CmbSupplierCategoryID.SelectedValue = (dr.Item("Supplier Category ID").ToString)
                    Me.SupplierPictureBox.Image = Nothing

                End If
                dr.Close()


                cmd1.CommandText = "SELECT  *FROM [Supplier Information]  WHERE [Supplier ID] = '" + Me.TxtSupplierID.Text + "' AND [Supplier Image] IS NOT NULL"

                dr1 = cmd1.ExecuteReader()
                dr1.Read()

                Try


                    If dr1.HasRows Then


                        Dim data As Byte() = DirectCast(dr1("Supplier Image"), Byte())
                        Dim ms As New MemoryStream(data)
                        SupplierPictureBox.Image = Image.FromStream(ms)
                    End If

                Catch ex As Exception

                End Try
                dr1.Close()




                cmd2.CommandText = "SELECT  *FROM [Ledger]    WHERE [Chart Of Account ID] = '" + ChartOfAccountIDforOpeningBalanceAdd + "' And [Ledger].[Category Name]='Supplier Opening Balance' And [Branch ID]='" + FrmHome.lblBranchID.Text + "'"
                dr2 = cmd2.ExecuteReader()
                dr2.Read()

                If dr2.HasRows Then

                    If Val(dr2.Item("Credited Amount").ToString) = 0 Then

                        TxtOpeningBalance.Text = Val(dr2.Item("Debited Amount").ToString) * -1
                        DtpLedgerDate.Value = dr2.Item("Ledger Date").ToString
                    ElseIf Not Val(dr2.Item("Credited Amount").ToString) = 0 Then

                        TxtOpeningBalance.Text = Val(dr2.Item("Credited Amount").ToString)
                        DtpLedgerDate.Value = dr2.Item("Ledger Date").ToString
                    End If

                End If
                dr2.Close()
                con.Close()


                'Show product list
                RefreshDataProductSpecificSupplier()

                'Focus on product id
                CmbProductID.Focus()


                'Clear Data Product Price
                ClearDataProductPrice()

            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

        End Try
    End Sub

    Private Sub GrdSupplierInformation_CellMouseDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdSupplierInformation.CellMouseDoubleClick
        Dim i As Integer
        i = GrdSupplierInformation.CurrentRow.Index

        If Me.LblFormName.Text = "Purchase" Then


            FrmPurchase.CmbSupplierName.ValueMember = GrdSupplierInformation.Item(0, i).Value
            FrmPurchase.CmbSupplierName.Text = GrdSupplierInformation.Item(1, i).Value

            FrmPurchase.TxtAddress.Text = GrdSupplierInformation.Item(5, i).Value
            FrmPurchase.TxtPhoneNo.Text = GrdSupplierInformation.Item(7, i).Value
            FrmPurchase.TxtSupplierDiscount.Text = GrdSupplierInformation.Item(13, i).Value

            FrmPurchase.CmbProductName.Focus()
            FrmPurchase.SupplierInformation()
            FrmPurchase.ShowDueOrAdvance()
            Me.Close()

        End If
    End Sub

    Private Sub GrdPriceList_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdPriceList.CellContentClick

    End Sub

    Private Sub GrdPriceList_CellFormatting1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles GrdPriceList.CellFormatting

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

                If GrdPriceList.Columns(e.ColumnIndex).Name.Equals("Price") Then
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

    Private Sub GrdPriceList_CellMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdPriceList.CellMouseClick

        'Data Grid view code
        Try

            If e.RowIndex >= 0 Then



                Dim row As DataGridViewRow
                row = Me.GrdPriceList.Rows(e.RowIndex)


                CmbProductID.Text = row.Cells("Product Name").Value.ToString
                TxtPrice.Text = row.Cells("Price").Value.ToString
                lblListID.Text = row.Cells("ID").Value.ToString

                'price Text box focus
                TxtPrice.Focus()



                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim dr As SqlDataReader

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "SELECT  *FROM [Supplier price list]  WHERE [Supplier price list ID] = '" + Me.lblListID.Text + "'"

                dr = cmd.ExecuteReader()
                dr.Read()

                If dr.HasRows Then
                    Me.CmbProductID.ValueMember = (dr.Item("Product ID").ToString)
                End If
                dr.Close()
                con.Close()






            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

        End Try
    End Sub

    Private Sub GrdPriceList_CellMouseDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdPriceList.CellMouseDoubleClick

        'Delete Supplier Price
        DeleteSupplierPrice()
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
End Class