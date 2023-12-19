Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.IO.Ports
Imports System.Text.RegularExpressions
Public Class FrmSaleHistory

    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point


    Dim SaleDate As String
    Dim ConfirmOrder As String

    Dim SMSPort As New SerialPort







    Private Sub TxtSearchStudentID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearchSaleInvoice.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Search Sale Invoice
            SearchSaleInvoice()

            'Show Customer Details
            DataReaderForCustomerLabel()

            'Refresh Data sale
            RefreshSaleDetails()

        End If

    End Sub
  

    ' Show Incomplete Sale Data By Status And UserID
    Sub ShowIncompleteSaleDataByStatusAndUserID()


        Try
            
            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Sale Invoice].[Sale Invoice No],[Customer Information].[Customer Name],[Sale Invoice].[Sale Date],[Sale Invoice].[Sale Time],[Sale Invoice].[Total] from [Sale Invoice] join  [User Account] on [Sale Invoice].[User Account ID]=[User Account].[User Account ID]join [Customer Information] on [Sale Invoice].[Customer ID]=[Customer Information].[Customer ID]   where [User Account].[User Account ID]='" + FrmHome.LblUserID.Text + "' and [Sale Invoice].[Status]='INCOMPLETE' order by [Sale Invoice].[Sale Date] desc, [Sale Invoice].[Sale Time] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Sale Invoice")
            connection.Close()
            GrdSaleInvoice.DataSource = ds
            GrdSaleInvoice.DataMember = "BizPro_Sale Invoice"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdSaleInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill






        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show Incomplete Sale Data By Invoice And UserID Sub")
        Finally

        End Try



    End Sub
    'Show Todays  Complete Sale By loginID 

    Sub ShowCompleteSaleDataByUserIDToday()

        Try
            
            Dim currentDate As DateTime = DateTime.Today

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Sale Invoice].[Sale Invoice No],[Customer Information].[Customer Name],[Sale Invoice].[Sale Date],[Sale Invoice].[Sale Time],[Sale Invoice].[Total] from [Sale Invoice]  join [User Account] on [Sale Invoice].[User Account ID]=[User Account].[User Account ID]join [Customer Information] on [Sale Invoice].[Customer ID]=[Customer Information].[Customer ID]   where [User Account].[User Account ID]='" + FrmHome.LblUserID.Text + "' and [Sale Invoice].[Status]='COMPLETE' and [Sale Invoice].[Sale Date]= '" + currentDate + "'  order by [Sale Invoice].[Sale Date] desc, [Sale Invoice].[Sale Time] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Sale Invoice")
            connection.Close()
            GrdSaleInvoice.DataSource = ds
            GrdSaleInvoice.DataMember = "BizPro_Sale Invoice"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdSaleInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill






        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show Complete Sale Data By UserID Today Sub")
        Finally

        End Try



    End Sub
    'Show Todays  Complete Sale By loginID of Current Branch
    Sub ShowCompleteSaleDataByUserIDTodayofCurrentBranch()

        Try
            
            Dim currentDate As DateTime = DateTime.Today

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Sale Invoice].[Sale Invoice No],[Customer Information].[Customer Name],[Sale Invoice].[Sale Date],[Sale Invoice].[Sale Time],[Sale Invoice].[Total] from [Sale Invoice]  join [User Account] on [Sale Invoice].[User Account ID]=[User Account].[User Account ID]join [Customer Information] on [Sale Invoice].[Customer ID]=[Customer Information].[Customer ID] join Sale on [sale invoice]. [Sale invoice no] =Sale.[Sale Invoice No]   where [User Account].[User Account ID]='" + FrmHome.LblUserID.Text + "' and [Sale Invoice].[Status]='COMPLETE' and [Sale Invoice].[Sale Date]= '" + currentDate + "' and sale.[Branch ID]= '" + FrmHome.lblBranchID.Text + "'    group by [Sale Invoice].[Sale Invoice No],[Customer Information].[Customer Name],[Sale Invoice].[Sale Date],[Sale Invoice].[Sale Time],[Sale Invoice].[Total]  order by [Sale Invoice].[Sale Date] desc, [Sale Invoice].[Sale Time] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Sale Invoice")
            connection.Close()
            GrdSaleInvoice.DataSource = ds
            GrdSaleInvoice.DataMember = "BizPro_Sale Invoice"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdSaleInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill






        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show Complete Sale Data By UserID Today Sub")
        Finally

        End Try



    End Sub

    'Show  All Complete Invoice 

    Sub ShowAllCompleteSaleData()

        Try
            
            Dim currentDate As DateTime = DateTime.Today

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Sale Invoice].[Sale Invoice No],[Customer Information].[Customer Name],[Sale Invoice].[Sale Date],[Sale Invoice].[Sale Time],[Sale Invoice].[Total] from [Sale Invoice]  join [User Account] on [Sale Invoice].[User Account ID]=[User Account].[User Account ID]join [Customer Information] on [Sale Invoice].[Customer ID]=[Customer Information].[Customer ID]   where [Sale Invoice].[Status]='COMPLETE'  order by [Sale Invoice].[Sale Date]  desc, [Sale Invoice].[Sale Time] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Sale Invoice")
            connection.Close()
            GrdSaleInvoice.DataSource = ds
            GrdSaleInvoice.DataMember = "BizPro_Sale Invoice"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdSaleInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill






        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show All Complete Sale Data Sub")
        Finally

        End Try



    End Sub
    'Show  All Complete Invoice of Current Branch 

    Sub ShowAllCompleteSaleDataofCurrentBranch()

        Try
           
            Dim currentDate As DateTime = DateTime.Today

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Sale Invoice].[Sale Invoice No],[Customer Information].[Customer Name],[Sale Invoice].[Sale Date],[Sale Invoice].[Sale Time],[Sale Invoice].[Total] from [Sale Invoice]  join [User Account] on [Sale Invoice].[User Account ID]=[User Account].[User Account ID]join [Customer Information] on [Sale Invoice].[Customer ID]=[Customer Information].[Customer ID] join Sale on [sale invoice]. [Sale invoice no] =Sale.[Sale Invoice No]  where [Sale Invoice].[Status]='COMPLETE' and sale.[Branch ID]= '" + FrmHome.lblBranchID.Text + "'   group by [Sale Invoice].[Sale Invoice No],[Customer Information].[Customer Name],[Sale Invoice].[Sale Date],[Sale Invoice].[Sale Time],[Sale Invoice].[Total]    order by [Sale Invoice].[Sale Date]  desc, [Sale Invoice].[Sale Time] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Sale Invoice")
            connection.Close()
            GrdSaleInvoice.DataSource = ds
            GrdSaleInvoice.DataMember = "BizPro_Sale Invoice"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdSaleInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
             




        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show All Complete Sale Data Sub")
        Finally

        End Try



    End Sub
    ' Search Sale Invoice

    Sub SearchSaleInvoice()
        Try
             

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Sale Invoice].[Sale Invoice No],[Customer Information].[Customer Name],[Sale Invoice].[Sale Date],[Sale Invoice].[Sale Time],[Sale Invoice].[Total] from [Sale Invoice]  join [User Account] on [Sale Invoice].[User Account ID]=[User Account].[User Account ID]join [Customer Information] on [Sale Invoice].[Customer ID]=[Customer Information].[Customer ID] where [Sale Invoice].[Sale Invoice No] = '" + TxtSearchSaleInvoice.Text + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Sale Invoice")
            connection.Close()
            GrdSaleInvoice.DataSource = ds
            GrdSaleInvoice.DataMember = "BizPro_Sale Invoice"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdSaleInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill






        Catch ex As Exception
            MessageBox.Show("Error while Searching record on table..." & ex.Message, "Search Sale Invoice Sub")
        Finally

        End Try



    End Sub

    Private Sub TxtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearchSaleInvoice.TextChanged

    End Sub


    Private Sub GrdStudentPaymentInvoice_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub




    'Privet sub for refresh sale details
    Sub RefreshSaleDetails()

        Try





            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Sale].[Sale ID],[Sale].[Sale Invoice NO],[Sale].[Purchase ID],[Products].[Product ID],[Products].[Product Name],[Sale].[Sale Quantity],[Sale].[Sale Unit Price],[Sale].[Sale Amount] from [Sale] join [Products] on [sale].[product ID]=[products].[Product ID] where [sale].[sale Invoice No]= '" + TxtSearchSaleInvoice.Text + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Sale")
            connection.Close()
            GrdSale.DataSource = ds
            GrdSale.DataMember = "BizPro_Sale"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdSale.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

          



        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Refresh Sale Details Sub")

        End Try
    End Sub



    'Sub For Customer info show in label
    Sub DataReaderForCustomerLabel()

        Try



            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [sale Invoice] join [Customer Information] on [Sale Invoice].[Customer ID]=[Customer Information].[Customer ID] WHERE [sale Invoice].[Sale Invoice No] = '" + Me.TxtSearchSaleInvoice.Text + "'"


            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then


                Me.LblCustomerID.Text = dr.Item("Customer ID").ToString
                Me.LblCustomerName.Text = dr.Item("Customer Name").ToString
                Me.LblMobileNo.Text = dr.Item("Mobile No").ToString

            ElseIf Not dr.HasRows Then

                MsgBox("No Customer Found")

                ClearData()

            End If

            dr.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while Searching Customer ..." & ex.Message, "Data Reader For Customer Label Sub")

        End Try

    End Sub
    'Clear Data

    Sub ClearData()


        LblCustomerName.Text = ""
        LblCustomerID.Text = ""
        LblMobileNo.Text = ""

        TxtSearchSaleInvoice.Text = ""
    End Sub


    Private Sub FrmStudentPaymentHistory_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub


    Private Sub FrmStudentPaymentHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 0)
        Me.Size = My.Computer.Screen.WorkingArea.Size







        'Change Language
        ChangeLanguage()



        'Show Incomplete Sale Data By Status And User ID
        ShowIncompleteSaleDataByStatusAndUserID()


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

                Me.TxtSearchSaleInvoice.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.LblCustomerID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.LblCustomerName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.LblMobileNo.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))


                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

                Me.GrdSaleInvoice.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdSaleInvoice.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)

                Me.GrdSale.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdSale.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)
                'MsgBox(dr.Item("Language Font"))

            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Change Language Sub")
        Finally
            con.Close()
        End Try

        'End Language

    End Sub

    'Search Sale Invoice For Amount
    Sub SearchSaleInvoiceForAmount()

        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand
            Dim dr As SqlDataReader


            'Data reader for Product Id
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Sale Invoice] join [Customer information] on[Sale Invoice].[Customer ID]=[Customer information].[Customer ID] left join [Chart of Account] on [Sale Invoice].[Paid By]=[Chart of Account].[Chart of Account ID]   WHERE [Sale Invoice].[Sale Invoice No] =  '" + TxtSearchSaleInvoice.Text + "'  select [Chart of Account ID][Due ID] from [Chart of Account] where [Account Name]='Due'"
            dr = cmd.ExecuteReader()
            dr.Read()
            If dr.HasRows Then


                LblTotal.Text = (dr.Item("Total").ToString)
                LblDiscount.Text = (dr.Item("Discount").ToString)
                LblNetPayable.Text = (dr.Item("Net Payable").ToString)
                LblPaidAmount.Text = (dr.Item("Paid Amount").ToString)
                LblStatus.Text = (dr.Item("Account Name").ToString)
            End If

            dr.Close()
            con.Close()


        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records on keydown")
        Finally

        End Try


    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub GrdStudentPaymentInvoice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


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



            con1.ConnectionString = FrmHome.ConnectionString
            con1.Open()
            cmd2.Connection = con1
            cmd2.CommandText = "SELECT  *FROM [Customer Ledger]  WHERE [Sale Invoice No] = '" + TxtSearchSaleInvoice.Text + "'"
            dr = cmd2.ExecuteReader()
            dr.Read()


            If dr.HasRows Then



                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd1.Connection = con
                cmd.CommandText = "Delete from [Customer Ledger] where [Sale Invoice No]= '" + TxtSearchSaleInvoice.Text + "'"
                cmd1.CommandText = "INSERT INTO [Log Details] ([Log Category],[Log Description],[User Account ID],[Log Date],[Log Time],[Task ID]) VALUES ('Bank Transaction','Data Deleted Successfully','" + FrmHome.LblUserID.Text + "','" + currentDate + "','" + currentTime + "','" + TxtSearchSaleInvoice.Text + "')"
                cmd.ExecuteNonQuery()
                cmd1.ExecuteNonQuery()
                con.Close()

            End If


            dr.Close()
            con1.Close()

        Catch ex As Exception
            MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Customer Ledger Sub")
        Finally

        End Try


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub
    'Show All Incomplete Sale of Current Branch
    Sub ShowAllIncompleteSaleofCurrentBranch()

        Try
            

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Sale Invoice].[Sale Invoice No],[Customer Information].[Customer Name],[Sale Invoice].[Sale Date],[Sale Invoice].[Sale Time],[Sale Invoice].[Total] from [Sale Invoice]  join [User Account] on [Sale Invoice].[User Account ID]=[User Account].[User Account ID]join [Customer Information] on [Sale Invoice].[Customer ID]=[Customer Information].[Customer ID] join Sale on [sale invoice]. [Sale invoice no] =Sale.[Sale Invoice No]  where [Sale Invoice].[Status]='INCOMPLETE' and sale.[Branch ID]= '" + FrmHome.lblBranchID.Text + "'   group by [Sale Invoice].[Sale Invoice No],[Customer Information].[Customer Name],[Sale Invoice].[Sale Date],[Sale Invoice].[Sale Time],[Sale Invoice].[Total]    order by [Sale Invoice].[Sale Date]  desc, [Sale Invoice].[Sale Time] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Sale Invoice")
            connection.Close()
            GrdSaleInvoice.DataSource = ds
            GrdSaleInvoice.DataMember = "BizPro_Sale Invoice"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdSaleInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill






        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show All Incomplete Sale  Sub")
        Finally

        End Try



    End Sub


    'Show All Incomplete Sale
    Sub ShowAllIncompleteSale()

        Try
             

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Sale Invoice].[Sale Invoice No],[Customer Information].[Customer Name],[Sale Invoice].[Sale Date],[Sale Invoice].[Sale Time],[Sale Invoice].[Total] from [Sale Invoice] join  [User Account] on [Sale Invoice].[User Account ID]=[User Account].[User Account ID]join [Customer Information] on [Sale Invoice].[Customer ID]=[Customer Information].[Customer ID]   where  [Sale Invoice].[Status]='INCOMPLETE' order by [Sale Invoice].[Sale Date] desc, [Sale Invoice].[Sale Time] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Sale Invoice")
            connection.Close()
            GrdSaleInvoice.DataSource = ds
            GrdSaleInvoice.DataMember = "BizPro_Sale Invoice"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdSaleInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            




        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show All Incomplete Sale  Sub")
        Finally

        End Try



    End Sub



    Private Sub TxtUpdate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        ConfirmOrder = ""
        'Clear data
        ClearData()

        'If FrmHome.LblUserName.Text = "Admin" Then
        'Show Todays  Complete Sale By loginID
        'ShowCompleteSaleDataByUserIDToday()
        'Else

        'Show Todays  Complete Sale By loginID of Current Branch
        ShowCompleteSaleDataByUserIDTodayofCurrentBranch()
        'End If

        'Refresh Data sale
        RefreshSaleDetails()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ConfirmOrder = ""
        'Clear data
        ClearData()

        If FrmHome.LblUserName.Text = "Admin" Then
            'Show  All Complete Invoice 
            ShowAllCompleteSaleData()

        Else

            'Show  All Complete Invoice of Current Branch 
            ShowAllCompleteSaleDataofCurrentBranch()
            'End If

            'Refresh Data sale
            RefreshSaleDetails()
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        ConfirmOrder = "Yes"
        'Clear data
        ClearData()

        'Show Incomplete Sale Data By Status And User ID
        ShowIncompleteSaleDataByStatusAndUserID()

        'Refresh Data sale
        RefreshSaleDetails()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ConfirmOrder = "Yes"

        'Clear data
        ClearData()

        If FrmHome.LblUserName.Text = "Admin" Then
            'Show All Incomplete Sale
            ShowAllIncompleteSale()
        Else

            'Show All Incomplete Sale of Current Branch
            ShowAllIncompleteSaleofCurrentBranch()
        End If

        'Refresh Data sale
        RefreshSaleDetails()
    End Sub
    'Sub for show dues or advanced or Gradings
    Sub SendSMS()
        Try

            If FrmHome.LblStatus.Text = "Active" Or FrmHome.LblStatus.Text = "Masking" Then

                Dim q As MsgBoxResult
                q = MsgBox("Do you want to send SMS?", MsgBoxStyle.YesNo, "Sale Hsitory")

                If q = MsgBoxResult.Yes Then


                    Dim con As New SqlConnection
                    Dim cmd As New SqlCommand
                    Dim dr As SqlDataReader
                    Dim cmd2 As New SqlCommand
                    Dim dr2 As SqlDataReader
                    Dim CustomerChartOfAccountID As String

                    Dim SaleAmount As String
                    SaleAmount = Val(LblTotal.Text) - Val(LblDiscount.Text)

                    'Data reader for Product Id
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd2.Connection = con
                    cmd2.CommandText = "SELECT  *FROM [Customer Information]  WHERE [Customer ID] = '" + LblCustomerID.Text + "'"

                    dr2 = cmd2.ExecuteReader()
                    dr2.Read()
                    If dr2.HasRows Then

                        CustomerChartOfAccountID = (dr2.Item("Chart Of Account ID").ToString)
                    End If
                    dr2.Close()


                    cmd.Connection = con
                    cmd.CommandText = "select (isnull(sum([Debited Amount]),0)- (isnull(sum([Credited Amount]),0))) as [Amount]  from [Ledger] where [Ledger].[Chart Of Account ID]= '" + CustomerChartOfAccountID + "' "

                    dr = cmd.ExecuteReader()
                    dr.Read()


                    If dr.HasRows Then

                        FrmHome.SMSPhoneNo = Me.LblMobileNo.Text

                        'Send due sms
                        If Val(dr.Item("Amount").ToString) > 0 Then
                            FrmHome.SMSText = "Dear Customer, " & "your sale amount is BDT " & "" + SaleAmount + "" & ". Received in cash BDT " & "00" & ". Your Current Balance is BDT " & Val(dr.Item("Amount").ToString) & " due. " & "" + FrmHome.lblCompanyName.Text + ""

                            If FrmHome.LblStatus.Text = "Active" Then
                                FrmHome.BulksmsbdToAll()
                            ElseIf FrmHome.LblStatus.Text = "Masking" Then
                                FrmHome.MaskingBulksmsbdToAll()
                            End If


                        ElseIf Val(dr.Item("Amount").ToString) < 0 Then

                            FrmHome.SMSText = "Dear Customer, " & "your sale amount is BDT " & "" + SaleAmount + "" & ". Received in cash BDT " & "00" & ". Your Current Balance is BDT " & Val(dr.Item("Amount").ToString) & " Advance. " & "" + FrmHome.lblCompanyName.Text + ""

                            If FrmHome.LblStatus.Text = "Active" Then
                                FrmHome.BulksmsbdToAll()
                            ElseIf FrmHome.LblStatus.Text = "Masking" Then
                                FrmHome.MaskingBulksmsbdToAll()
                            End If

                            'Send grading sms
                        ElseIf Val(dr.Item("Amount").ToString) = 0 Then

                            FrmHome.SMSText = "Dear Customer, " & "your sale amount is BDT " & "" + SaleAmount + "" & ". Received in cash BDT " & "00" & ". Your Current Balance is BDT " & Val(dr.Item("Amount").ToString) & " . " + FrmHome.lblCompanyName.Text + ""

                            If FrmHome.LblStatus.Text = "Active" Then
                                FrmHome.BulksmsbdToAll()
                            ElseIf FrmHome.LblStatus.Text = "Masking" Then
                                FrmHome.MaskingBulksmsbdToAll()
                            End If


                        End If



                    End If

                    dr.Close()
                    con.Close()

                    MsgBox("Sent Successfully")
                End If


            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ConfirmOrder = "Yes" And Not TxtSearchSaleInvoice.Text = "" Then

            Dim q As MsgBoxResult
            q = MsgBox("Do you really want to comfirm this order?", MsgBoxStyle.YesNo, "Sale History")
            If q = MsgBoxResult.Yes Then
                'Insert or update into customer ledger
                InsertorUpdateCustomerLedgerForDues()

                'Update into sale invoice And Send SMS
                UpdateSaleInvoiceAndSendSMS()




                'Show Incomplete Sale Data By Status And User ID
                ShowIncompleteSaleDataByStatusAndUserID()

                'Clear Sale data from grid view
                GrdSale.Columns.Clear()

            End If
        Else
            MsgBox("Please Select an incomplete order", MsgBoxStyle.Exclamation, "Sale History")
        End If


    End Sub

    'Update into sale invoice And Send SMS
    Sub UpdateSaleInvoiceAndSendSMS()

        Try


            'Update Sale Invoice
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand
            Dim dr1 As SqlDataReader
            Dim currentDate As DateTime = DateTime.Today

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd1.Connection = con
            cmd1.CommandText = " select [Chart of Account ID] from [Chart of Account] where [Account Name]='Due'"
            dr1 = cmd1.ExecuteReader()
            dr1.Read()
            If dr1.HasRows Then

                cmd.Connection = con
                cmd.CommandText = "Update [Sale Invoice] set  [Status]= 'COMPLETE',[Sale Date]='" + currentDate + "',[Paid by]='" + (dr1.Item("Chart of Account ID").ToString) + "'  where [Sale Invoice No] ='" + TxtSearchSaleInvoice.Text + "'"
                dr1.Close()
                cmd.ExecuteNonQuery()
            End If
            con.Close()
            dr1.Close()

            

            'Sub for show dues or advanced or Gradings
            SendSMS()


        Catch ex As Exception
            MessageBox.Show("Error while Updating record on table..." & ex.Message, "Update Sale Invoice Sub")
        End Try


    End Sub



    Sub InsertorUpdateCustomerLedgerForDues()



        Try

            Dim con As New SqlConnection
            Dim con1 As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand
            Dim cmd2 As New SqlCommand
            Dim cmd3 As New SqlCommand
            Dim cmd4 As New SqlCommand
            'Dim cmd5 As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now
            Dim dr As SqlDataReader
            Dim dr2 As SqlDataReader
            Dim dr3 As SqlDataReader

            Dim CustomerChartOfAccountID As String
            Dim SaleChartOfAccountID As String
            Dim NetPayable As String

            NetPayable = (Val(LblNetPayable.Text))

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd2.Connection = con
            cmd3.Connection = con
            cmd2.CommandText = "SELECT  *FROM [Customer Information]  WHERE [Customer ID] = '" + LblCustomerID.Text + "'"
            cmd3.CommandText = "SELECT  *FROM [Chart Of Account]  WHERE [Account Name] = 'Sale'"

            dr3 = cmd3.ExecuteReader()
            dr3.Read()
            If dr3.HasRows Then

                SaleChartOfAccountID = (dr3.Item("Chart Of Account ID").ToString)

            End If
            dr3.Close()

            dr2 = cmd2.ExecuteReader()
            dr2.Read()
            If dr2.HasRows Then
                CustomerChartOfAccountID = (dr2.Item("Chart Of Account ID").ToString)
            End If
            dr2.Close()


            cmd.CommandText = "SELECT  *FROM [Ledger]  WHERE  [Category Name]='Sale' And [Invoice No] = '" + TxtSearchSaleInvoice.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()




            If Not dr.HasRows Then

                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd4.Connection = con1
                cmd1.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart Of Account ID],[Invoice No],[Category Name],[User Account ID],[Computer ID],[Prepared Date] ,[Prepared Time],[Debited Amount],[Credited Amount],[Status],[Voucher No],[Description],[Branch ID],[Pending Invoice]) VALUES ('" + SaleDate + "','" + CustomerChartOfAccountID + "','" + TxtSearchSaleInvoice.Text + "','Sale','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + NetPayable + "','00','Completed','" + TxtSearchSaleInvoice.Text + "','Sale','" + FrmHome.lblBranchID.Text + "','00-S-INV-" + TxtSearchSaleInvoice.Text + "')"
                cmd4.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart Of Account ID],[Invoice No],[Category Name],[User Account ID],[Computer ID],[Prepared Date] ,[Prepared Time],[Debited Amount],[Credited Amount],[Status],[Voucher No],[Description],[Branch ID],[Pending Invoice]) VALUES ('" + SaleDate + "','" + SaleChartOfAccountID + "','" + TxtSearchSaleInvoice.Text + "','Sale','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','00','" + NetPayable + "','Completed','" + TxtSearchSaleInvoice.Text + "','Sale To " + LblCustomerName.Text + "','" + FrmHome.lblBranchID.Text + "','00-S-INV-" + TxtSearchSaleInvoice.Text + "')"
                cmd1.ExecuteNonQuery()
                cmd4.ExecuteNonQuery()
                con1.Close()




            ElseIf dr.HasRows Then



                'con1.ConnectionString = FrmHome.ConnectionString
                'con1.Open()
                'cmd5.Connection = con1
                'cmd1.Connection = con1
                'cmd4.Connection = con1
                'cmd5.CommandText = "Delete from  [Ledger] WHERE [Category Name]='Sale' And[Invoice No]= '" + TxtSaleInvoiceNo.Text + "'"
                'cmd1.CommandText = "Update [Ledger]  Set [Ledger Date]='" + SaleDate + "',[Chart Of Account ID]='" + CustomerChartOfAccountID + "',[Invoice No]='" + TxtSearchSaleInvoice.Text + "',[Category Name]='Sale',[User Account ID]='" + FrmHome.LblUserID.Text + "',[Computer ID]='" + FrmHome.LblComputerID.Text + "',[Prepared Time]='" + currentTime + "',[Debited Amount]='" + NetPayable + "',[Credited Amount]='00',[Description]= 'Sale' Where [Chart Of Account ID]='" + CustomerChartofAccountIDForUpdate + "' And [Invoice No]='" + TxtSaleInvoiceNo.Text + "' And [Category Name]='Sale'"
                'cmd4.CommandText = "Update [Ledger] Set  [Ledger Date]='" + SaleDate + "',[Chart Of Account ID]='" + SaleChartOfAccountID + "',[Invoice No]='" + TxtSearchSaleInvoice.Text + "',[Category Name]='Sale',[User Account ID]='" + FrmHome.LblUserID.Text + "',[Computer ID]='" + FrmHome.LblComputerID.Text + "',[Prepared Time]='" + currentTime + "',[Debited Amount]='00',[Credited Amount]='" + NetPayable + "',[Description]= 'Sale To " + LblCustomerName.Text + "' Where [Chart Of Account ID]='" + SaleChartOfAccountID + "' And [Invoice No]='" + TxtSaleInvoiceNo.Text + "' And [Category Name]='Sale'"

                'cmd5.ExecuteNonQuery()
                ' cmd1.ExecuteNonQuery()
                ' cmd4.ExecuteNonQuery()



                'con1.Close()




            End If

            dr.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records to Customer ledger")
        Finally

        End Try

    End Sub

    Private Sub GrdSaleInvoice_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdSaleInvoice.CellContentClick

    End Sub

    Private Sub GrdSaleInvoice_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdSaleInvoice.CellMouseClick
        'Data Grid view code
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdSaleInvoice.Rows(e.RowIndex)

                TxtSearchSaleInvoice.Text = row.Cells("Sale Invoice No").Value.ToString



                'Show Students Details in label
                DataReaderForCustomerLabel()

                'RefreshSale Details
                RefreshSaleDetails()


                'Search Sale Invoice For Amount
                SearchSaleInvoiceForAmount()

                SaleDate = row.Cells("Sale Date").Value


            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview")

        End Try
    End Sub

    Private Sub GrdSaleInvoice_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdSaleInvoice.CellMouseDoubleClick

        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdSaleInvoice.Rows(e.RowIndex)


                If Me.TxtSearchSaleInvoice.Text = "" Then
                    MsgBox("Please select a row from list")
                Else
                    If FrmHome.LblUserName.Text = "ADMIN" Then

                        Me.SaleDate = row.Cells("Sale Date").Value
                        Me.AdminLogin()




                    Else


                        FrmPasswordConfirmation.Show()
                        FrmPasswordConfirmation.SaleDate = row.Cells("Sale Date").Value
                        FrmPasswordConfirmation.TxtPassword.Focus()
                    End If

                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Cell Mouse Double Click Gridview")
        Finally

        End Try

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

    Private Sub GrdSale_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdSale.CellContentClick

    End Sub

    Private Sub GrdSale_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdSale.CellMouseClick

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader



        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.GrdSale.Rows(e.RowIndex)

            Dim ProductID As String = row.Cells("Product ID").Value.ToString

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Products]  WHERE [Product ID] = " + ProductID + " AND [Product Image] IS NOT NULL"
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

    End Sub

    Sub AdminLogin()

        Try

      



            'Show form Student Payment 
            FrmSale.Show()

            'Clean all previous data
            FrmSale.ClearAllData()

            'Sale Invoice
            FrmSale.TxtSaleInvoiceNo.Text = Me.TxtSearchSaleInvoice.Text

            'Sale Form All Data input
            'FrmSale.CmbCustomerName.Focus()
            FrmSale.CmbCustomerName.ValueMember = Me.LblCustomerID.Text
            FrmSale.CmbCustomerName.Text = Me.LblCustomerName.Text
            FrmSale.CmbCustomerName.SelectedValue = Me.LblCustomerID.Text
            FrmSale.DtpSaleDate.Value = SaleDate


            FrmSale.SearchChartOfAccountIDForUpdateLedger()

            'Refresh data
            FrmSale.RefreshData()

            'Clear Sale Serial Number
            FrmSale.GrdAvailableSerialNumber.Columns.Clear()



            'Show customer information
            FrmSale.customerInformation()

            'Search Purchase Invoice
            FrmSale.SearchSaleInvoice()

            'Set Previous Paid By Id To Variable to Update
            FrmSale.PreviousPaidbyID = FrmSale.cmbPaidBy.SelectedValue.ToString

            'Focus on Product Name field
            FrmSale.cmbProductName.Focus()


            'sale edit confirmation
            FrmSale.SaleEditStatus = True

            'Hide customer details
            FrmSale.GrdCustomerList.Hide()



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class