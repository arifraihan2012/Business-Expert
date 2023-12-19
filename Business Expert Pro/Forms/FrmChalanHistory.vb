Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmChalanHistory

    Private Sub TxtSearchStudentID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearchChalanInvoice.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Search Customer
            SearchChalanInvoice()

            'Show Customer Details
            DataReaderForCustomerLabel()
        End If

    End Sub

    'Show  Incomplete Chalan BY loginID and Status

    Sub ShowIncompleteChalanDataByStatusAndUserID()

        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Chalan Invoice].[Chalan Invoice No],[Customer Information].[Customer Name],[Chalan Invoice].[Chalan Date],[Chalan Invoice].[Chalan Time],[Chalan Invoice].[Total] from [Chalan Invoice] join  [User Account] on [Chalan Invoice].[User Account ID]=[User Account].[User Account ID]join [Customer Information] on [Chalan Invoice].[Customer ID]=[Customer Information].[Customer ID]   where [User Account].[User Account ID]='" + FrmHome.LblUserID.Text + "' and [Chalan Invoice].[Status]='INCOMPLETE' order by [Chalan Invoice].[Chalan Date] desc, [Chalan Invoice].[Chalan Time] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Chalan Invoice")
            connection.Close()
            GrdChalanInvoice.DataSource = ds
            GrdChalanInvoice.DataMember = "BizPro_Chalan Invoice"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdChalanInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            con.Close()





        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show Incomplete Chalan Data By Invoice And UserID Sub")
        Finally

        End Try



    End Sub
    'Show Todays  Complete Chalan By loginID

    Sub ShowCompleteChalanDataByInvoiceAndUserID()

        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Chalan Invoice].[Chalan Invoice No],[Customer Information].[Customer Name],[Chalan Invoice].[Chalan Date],[Chalan Invoice].[Chalan Time],[Chalan Invoice].[Total] from [Chalan Invoice]  join [User Account] on [Chalan Invoice].[User Account ID]=[User Account].[User Account ID]join [Customer Information] on [Chalan Invoice].[Customer ID]=[Customer Information].[Customer ID]   where [User Account].[User Account ID]='" + FrmHome.LblUserID.Text + "' and [Chalan Invoice].[Status]='COMPLETE' and [Chalan Invoice].[Chalan Date]= '" + currentDate + "'  order by [Chalan Invoice].[Chalan Date] desc, [Chalan Invoice].[Chalan Time] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Chalan Invoice")
            connection.Close()
            GrdChalanInvoice.DataSource = ds
            GrdChalanInvoice.DataMember = "BizPro_Chalan Invoice"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdChalanInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            con.Close()





        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show Todays  Complete Chalan By loginID Sub")

        Finally

        End Try



    End Sub
    'Show  All Complete Invoice 

    Sub ShowAllCompleteChalanData()

        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Chalan Invoice].[Chalan Invoice No],[Customer Information].[Customer Name],[Chalan Invoice].[Chalan Date],[Chalan Invoice].[Chalan Time],[Chalan Invoice].[Total] from [Chalan Invoice]  join [User Account] on [Chalan Invoice].[User Account ID]=[User Account].[User Account ID]join [Customer Information] on [Chalan Invoice].[Customer ID]=[Customer Information].[Customer ID]   where [Chalan Invoice].[Status]='COMPLETE'  order by [Chalan Invoice].[Chalan Date]  desc, [Chalan Invoice].[Chalan Time] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Chalan Invoice")
            connection.Close()
            GrdChalanInvoice.DataSource = ds
            GrdChalanInvoice.DataMember = "BizPro_Chalan Invoice"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdChalanInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            con.Close()





        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show All Complete Chalan Data Sub")

        Finally

        End Try



    End Sub
    ' Search Chalan Invoice

    Sub SearchChalanInvoice()

        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Chalan Invoice].[Chalan Invoice No],[Chalan Invoice].[Chalan Date],[Chalan Invoice].[Chalan Time],[Chalan].[Chalan Amount] from [Chalan Invoice] join [Products] on [Chalan Invoice].[product ID]=[products].[Product ID] join [Chalan] on [Chalan Invoice].[Chalan Invoice No]=[Chalan].[Chalan Invoice No] join [User Account] on [Chalan Invoice].[User Account ID]=[User Account].[User Account ID] where [Chalan Invoice].[Chalan Invoice No] = '" + TxtSearchChalanInvoice.Text + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Chalan Invoice")
            connection.Close()
            GrdChalanInvoice.DataSource = ds
            GrdChalanInvoice.DataMember = "BizPro_Chalan Invoice"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdChalanInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            con.Close()





        Catch ex As Exception
            MessageBox.Show("Error while Searching record on table..." & ex.Message, "Search Chalan Invoice Sub")

        Finally

        End Try



    End Sub

    Private Sub TxtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearchChalanInvoice.TextChanged

    End Sub


    Private Sub GrdStudentPaymentInvoice_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdChalanInvoice.CellContentClick

    End Sub

    Private Sub GrdStudentPaymentInvoice_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdChalanInvoice.CellMouseClick
        'Data Grid view code
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdChalanInvoice.Rows(e.RowIndex)

                TxtSearchChalanInvoice.Text = row.Cells("Chalan Invoice No").Value.ToString



                'Show customer Details in label
                DataReaderForCustomerLabel()

                'RefreshChalan Details
                RefreshChalanDetails()




            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview")

        End Try

    End Sub


    'Privet sub for refresh Chalan details
    Sub RefreshChalanDetails()

        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Chalan].[Chalan ID],[Chalan].[Chalan Invoice NO],[Chalan].[Purchase ID],[Products].[Product Name],[Chalan].[Chalan Quantity],[Chalan].[Chalan Unit Price],[Chalan].[Chalan Amount] from [Chalan] join [Products] on [Chalan].[product ID]=[products].[Product ID] where [Chalan].[Chalan Invoice No]= '" + TxtSearchChalanInvoice.Text + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Chalan")
            connection.Close()
            GrdChalan.DataSource = ds
            GrdChalan.DataMember = "BizPro_Chalan"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdChalan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            con.Close()

            'Show  Total Amount payable
            AMOUNTPAYABLE()





        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Refresh Chalan Details Sub")


        End Try
    End Sub


    Private Sub GrdStudentPaymentInvoice_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdChalanInvoice.CellMouseDoubleClick
        Try


            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdChalanInvoice.Rows(e.RowIndex)



                If Me.TxtSearchChalanInvoice.Text = "" Then
                    MsgBox("Please select a row from list")
                Else


                    'Show Chalan From 
                    FrmChalan.Show()

                    'Show Chalan Invoice  Chalan History to Chalan
                    FrmChalan.TxtChalanInvoiceNo.Text = Me.TxtSearchChalanInvoice.Text


                    'Show Customer Details From Chalan History to Chalan
                    FrmChalan.CmbCustomerName.Focus()
                    FrmChalan.CmbCustomerName.Text = LblCustomerName.Text
                    FrmChalan.CmbCustomerName.ValueMember = LblCustomerID.Text
                    FrmChalan.DtpChalanDate.Value = row.Cells("Chalan Date").Value


                    'Refresh data to Chalan
                    FrmChalan.RefreshData()

                    'Focus on Product Name Combobox
                    FrmChalan.cmbProductName.Focus()

                    'Search Purchase Invoice
                    FrmChalan.SearchChalanInvoice()

                    'show Customer Information
                    FrmChalan.customerInformation()

                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Cell Mouse Double Click Gridview")
        Finally

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
            cmd.CommandText = "SELECT  *FROM [Chalan Invoice] join [Customer Information] on [Chalan Invoice].[Customer ID]=[Customer Information].[Customer ID] WHERE [Chalan Invoice].[Chalan Invoice No] = '" + Me.TxtSearchChalanInvoice.Text + "'"


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
            MessageBox.Show("Error while Searching record on table..." & ex.Message, "Data Reader For Customer Label Sub")

        End Try

    End Sub
    'Clear Data

    Sub ClearData()


        LblCustomerName.Text = ""
        LblCustomerID.Text = ""
        LblMobileNo.Text = ""

        TxtSearchChalanInvoice.Text = ""
    End Sub
    Sub AMOUNTPAYABLE()
        Dim total As String = 0
        For i As Integer = 0 To GrdChalan.RowCount - 1
            total += GrdChalan.Rows(i).Cells(6).Value
        Next
        Me.LblAmount.Text = total
    End Sub

    Private Sub FrmStudentPaymentHistory_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub


    Private Sub FrmStudentPaymentHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Change Language
        ChangeLanguage()

        'Search  Incomplete  Chalan By loginID and Status
        ShowIncompleteChalanDataByStatusAndUserID()

    End Sub

    'Change Langeuge Privet Sub

    Sub ChangeLanguage()


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

            Me.TxtSearchChalanInvoice.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.LblCustomerID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.LblCustomerName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.LblMobileNo.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.LblAmount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            Me.GrdChalanInvoice.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.GrdChalanInvoice.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)

            Me.GrdChalan.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.GrdChalan.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)
            'MsgBox(dr.Item("Language Font"))

            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Change Language")
        Finally
            con.Close()
        End Try

        'End Language

    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub GrdStudentPaymentInvoice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdChalanInvoice.KeyDown

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub


    'Search All Incomplete  Chalan 
    Sub ShowAllIncompleteChalan()


        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Chalan Invoice].[Chalan Invoice No],[Customer Information].[Customer Name],[Chalan Invoice].[Chalan Date],[Chalan Invoice].[Chalan Time],[Chalan Invoice].[Total] from [Chalan Invoice] join  [User Account] on [Chalan Invoice].[User Account ID]=[User Account].[User Account ID]join [Customer Information] on [Chalan Invoice].[Customer ID]=[Customer Information].[Customer ID]   where  [Chalan Invoice].[Status]='INCOMPLETE' order by [Chalan Invoice].[Chalan Date] desc, [Chalan Invoice].[Chalan Time] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Chalan Invoice")
            connection.Close()
            GrdChalanInvoice.DataSource = ds
            GrdChalanInvoice.DataMember = "BizPro_Chalan Invoice"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdChalanInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            con.Close()





        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show All Incomplete Chalan  Sub")
        Finally

        End Try




    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        'Clear data
        ClearData()

        'Current date all complete history show
        ShowCompleteChalanDataByInvoiceAndUserID()

        'Refresh Data Chalan
        RefreshChalanDetails()


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'Clear data
        ClearData()


        'Search All Complete Chalan Data
        ShowAllCompleteChalanData()

        'Refresh Data Chalan
        RefreshChalanDetails()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        'Clear data
        ClearData()

        'Search  Incomplete  Chalan By loginID and Status
        ShowIncompleteChalanDataByStatusAndUserID()

        'Refresh Data Chalan
        RefreshChalanDetails()
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        'Clear data
        ClearData()

        'Search All Incomplete  Chalan 
        ShowAllIncompleteChalan()

        'Refresh Data Chalan
        RefreshChalanDetails()

    End Sub
End Class