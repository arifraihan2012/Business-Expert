Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmSaleReturnHistory
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point

    Private Sub TxtSearchStudentID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearchSaleReturnInvoice.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Search Sale Return Invoice
            SearchSaleReturnInvoice()

            'Show Customer Details
            DataReaderForCustomerLabel()

            'Refresh Data sale Return
            RefreshSaleReturnDetails()

        End If

    End Sub

    ' Show Incomplete Sale Data By Status And UserID
    Sub ShowIncompleteSaleReturnDataByStatusAndUserID()


        Try
             

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Sale Return Invoice].[Sale Return Invoice No],[Customer Information].[Customer Name],[Sale Return Invoice].[Return Date],[Sale Return Invoice].[Prepared Time],[Sale Return Invoice].[Total] from [Sale Return Invoice] join  [User Account] on [Sale Return Invoice].[User Account ID]=[User Account].[User Account ID]join [Customer Information] on [Sale Return Invoice].[Customer ID]=[Customer Information].[Customer ID]   where [User Account].[User Account ID]='" + FrmHome.LblUserID.Text + "' and [Sale Return Invoice].[Status]='INCOMPLETE' order by [Sale Return Invoice].[Return Date] desc, [Sale Return Invoice].[Prepared Time] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Sale Return Invoice")
            connection.Close()
            GrdSaleReturnInvoice.DataSource = ds
            GrdSaleReturnInvoice.DataMember = "BizPro_Sale Return Invoice"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdSaleReturnInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill






        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show Incomplete Sale Return Data By Invoice And UserID Sub")
        Finally

        End Try



    End Sub
    'Show Todays  Complete Sale Return By loginID 

    Sub ShowCompleteSaleReturnDataByUserIDToday()

        Try
           
            Dim currentDate As DateTime = DateTime.Today

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Sale Return Invoice].[Sale Return Invoice No],[Customer Information].[Customer Name],[Sale Return Invoice].[Return Date],[Sale Return Invoice].[Prepared Time],[Sale Return Invoice].[Total] from [Sale Return Invoice] join  [User Account] on [Sale Return Invoice].[User Account ID]=[User Account].[User Account ID]join [Customer Information] on [Sale Return Invoice].[Customer ID]=[Customer Information].[Customer ID]   where [User Account].[User Account ID]='" + FrmHome.LblUserID.Text + "' and [Sale Return Invoice].[Status]='COMPLETE' and [Sale Return Invoice].[Return Date]= '" + currentDate + "' order by [Sale Return Invoice].[Return Date] desc, [Sale Return Invoice].[Prepared Time] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Sale Return Invoice")
            connection.Close()
            GrdSaleReturnInvoice.DataSource = ds
            GrdSaleReturnInvoice.DataMember = "BizPro_Sale Return Invoice"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdSaleReturnInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
             




        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show Complete Sale Return Data By UserID Today Sub")
        Finally

        End Try



    End Sub
    'Show  All Complete Sale Return Invoice 

    Sub ShowAllCompleteSaleReturnData()

        Try
             
            Dim currentDate As DateTime = DateTime.Today

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Sale Return Invoice].[Sale Return Invoice No],[Customer Information].[Customer Name],[Sale Return Invoice].[Return Date],[Sale Return Invoice].[Prepared Time],[Sale Return Invoice].[Total] from [Sale Return Invoice] join  [User Account] on [Sale Return Invoice].[User Account ID]=[User Account].[User Account ID]join [Customer Information] on [Sale Return Invoice].[Customer ID]=[Customer Information].[Customer ID]   where [User Account].[User Account ID]='" + FrmHome.LblUserID.Text + "' and [Sale Return Invoice].[Status]='COMPLETE'  order by [Sale Return Invoice].[Return Date] desc, [Sale Return Invoice].[Prepared Time] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(Sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Sale Return Invoice")
            connection.Close()
            GrdSaleReturnInvoice.DataSource = ds
            GrdSaleReturnInvoice.DataMember = "BizPro_Sale Return Invoice"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdSaleReturnInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill






        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show All Complete Sale Return Data Sub")
        Finally

        End Try



    End Sub
    ' Search Sale Return Invoice

    Sub SearchSaleReturnInvoice()
        Try
             

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Sale Return Invoice].[Sale Return Invoice No],[Customer Information].[Customer Name],[Sale Return Invoice].[Return Date],[Sale Return Invoice].[Prepared Time],[Sale Return Invoice].[Total] from [Sale Return Invoice] join  [User Account] on [Sale Return Invoice].[User Account ID]=[User Account].[User Account ID]join [Customer Information] on [Sale Return Invoice].[Customer ID]=[Customer Information].[Customer ID]   where [Sale Return Invoice].[Sale Return Invoice No] = '" + TxtSearchSaleReturnInvoice.Text + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Sale Return Invoice")
            connection.Close()
            GrdSaleReturnInvoice.DataSource = ds
            GrdSaleReturnInvoice.DataMember = "BizPro_Sale Return Invoice"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdSaleReturnInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill






        Catch ex As Exception
            MessageBox.Show("Error while Searching record on table..." & ex.Message, "Search Sale Return Invoice Sub")
        Finally

        End Try



    End Sub

    Private Sub TxtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearchSaleReturnInvoice.TextChanged

    End Sub


    Private Sub GrdStudentPaymentInvoice_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdStudentPaymentInvoice_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

    End Sub


    'Privet sub for refresh sale Return details
    Sub RefreshSaleReturnDetails()


        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader


            'Data reader for Product Id
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT * from [Sale Return Invoice] WHERE [Sale Return Invoice No] =  '" + TxtSearchSaleReturnInvoice.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()



            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Sale Return].[Sale Return ID],[Products].[Product Name],[Sale Return].[Returned Quantity],([Sale Return].[Returned Quantity]* Sale.[Sale Unit Price])[Total Amount] from [sale Return] join Sale on [Sale Return].[Purchase ID]=Sale.[Purchase ID]  join Products on Sale.[Product ID]=Products.[Product ID] where [Sale Return].[Sale Return Invoice No]= '" + TxtSearchSaleReturnInvoice.Text + "' And [Sale].[Sale Invoice No]='" + (dr.Item("Sale Invoice No").ToString) + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Sale Return")
            connection.Close()
            GrdSaleReturn.DataSource = ds
            GrdSaleReturn.DataMember = "BizPro_Sale Return"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdSaleReturn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            dr.Close()
            con.Close()

            'Show Students Total Amount payable
            AMOUNTPAYABLE()




        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Refresh Sale Return Details Sub")

        End Try
    End Sub


    Private Sub GrdStudentPaymentInvoice_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdSaleReturnInvoice.Rows(e.RowIndex)


                If Me.TxtSearchSaleReturnInvoice.Text = "" Then
                    MsgBox("Please select a row from list")

                Else


                    'Show form Student Payment 
                    FrmSaleReturn.Show()

                    'Select Search By
                    FrmSaleReturn.CmbSearch.SelectedIndex = 1

                    'Sale Invoice
                    FrmSaleReturn.TxtSaleReturnInvoiceNo.Text = Me.TxtSearchSaleReturnInvoice.Text


                    'Search Sale Return Invoice
                    FrmSaleReturn.SearchSaleReturnInvoice()

                    'Refresh data
                    FrmSaleReturn.RefreshSaleReturn()

                    'Show customer information
                    FrmSaleReturn.customerInformation()

                    'Search Sale Invoice
                    FrmSaleReturn.SearchInvoiceNumberAndProductDetails()

                    'Sale Form All Data input
                    FrmSaleReturn.TxtPaidAmount.Focus()
                    FrmSaleReturn.DtpReturnedDate.Value = row.Cells("Return Date").Value




                    'Focus on Product Name field
                    FrmSaleReturn.TxtPaidAmount.Focus()

                    'send Paid by id to variable to update
                    FrmSaleReturn.PreviousPaidbyID = FrmSaleReturn.cmbPaidBy.SelectedValue

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
            cmd.CommandText = "SELECT * from [Customer Information] join [sale Invoice] on [Customer Information].[Customer ID]=[sale Invoice].[Customer ID] join [Sale Return Invoice] on [Sale Invoice].[Sale Invoice No]=[Sale Return Invoice].[Sale Invoice No] WHERE [sale Return Invoice].[Sale Return Invoice No] = '" + Me.TxtSearchSaleReturnInvoice.Text + "'"


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

        TxtSearchSaleReturnInvoice.Text = ""
    End Sub
    Sub AMOUNTPAYABLE()
        Try


            Dim total As String = 0
            For i As Integer = 0 To GrdSaleReturn.RowCount - 1
                total += GrdSaleReturn.Rows(i).Cells(3).Value
            Next
            Me.LblAmount.Text = total

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmStudentPaymentHistory_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub


    Private Sub FrmStudentPaymentHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 0)
        Me.Size = My.Computer.Screen.WorkingArea.Size









        'Change Language
        ChangeLanguage()



        'Show Incomplete Sale Data By Status And User ID
        ShowIncompleteSaleReturnDataByStatusAndUserID()


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


                Me.TxtSearchSaleReturnInvoice.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.LblCustomerID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.LblCustomerName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.LblMobileNo.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.LblAmount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))


                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

                Me.GrdSaleReturnInvoice.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdSaleReturnInvoice.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)

                Me.GrdSaleReturn.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdSaleReturn.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)
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

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub GrdStudentPaymentInvoice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub


    'Show All Incomplete Sale Return
    Sub ShowAllIncompleteSaleReturn()

        Try
            

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Sale Return Invoice].[Sale Return Invoice No],[Customer Information].[Customer Name],[Sale Return Invoice].[Return Date],[Sale Return Invoice].[Prepared Time],[Sale Return Invoice].[Total] from [Sale Return Invoice] join  [User Account] on [Sale Return Invoice].[User Account ID]=[User Account].[User Account ID]join [Customer Information] on [Sale Return Invoice].[Customer ID]=[Customer Information].[Customer ID]   where  [Sale Return Invoice].[Status]='INCOMPLETE'  order by [Sale Return Invoice].[Return Date] desc, [Sale Return Invoice].[Prepared Time] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Sale Return Invoice")
            connection.Close()
            GrdSaleReturnInvoice.DataSource = ds
            GrdSaleReturnInvoice.DataMember = "BizPro_Sale Return Invoice"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdSaleReturnInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill






        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show All Incomplete Sale  Return Sub")
        Finally

        End Try



    End Sub



    Private Sub TxtUpdate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        'Clear data
        ClearData()


        'Show Todays  Complete Sale Return By loginID
        ShowCompleteSaleReturnDataByUserIDToday()

        'Clear sale return columns
        GrdSaleReturn.Columns.Clear()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        'Clear data
        ClearData()

        'Show  All Complete  Sale Return Invoice 
        ShowAllCompleteSaleReturnData()

        'Clear sale return columns
        GrdSaleReturn.Columns.Clear()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        'Clear data
        ClearData()

        'Show Incomplete Sale Return Data By Status And User ID
        ShowIncompleteSaleReturnDataByStatusAndUserID()

        'Clear sale return columns
        GrdSaleReturn.Columns.Clear()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        'Clear data
        ClearData()

        'Show All Incomplete Sale Return
        ShowAllIncompleteSaleReturn()

        'Clear sale return columns
        GrdSaleReturn.Columns.Clear()
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

    Private Sub GrdSaleReturnInvoice_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdSaleReturnInvoice.CellContentClick

    End Sub

    Private Sub GrdSaleReturnInvoice_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdSaleReturnInvoice.CellMouseClick
        'Data Grid view code
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdSaleReturnInvoice.Rows(e.RowIndex)

                TxtSearchSaleReturnInvoice.Text = row.Cells("Sale Return Invoice No").Value.ToString



                'Show Students Details in label
                DataReaderForCustomerLabel()

                'Refresh Sale  ReturnDetails
                RefreshSaleReturnDetails()



            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview")

        End Try
    End Sub

    Private Sub GrdSaleReturnInvoice_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdSaleReturnInvoice.CellMouseDoubleClick


        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdSaleReturnInvoice.Rows(e.RowIndex)


                If Me.TxtSearchSaleReturnInvoice.Text = "" Then
                    MsgBox("Please select a row from list")

                Else


                    'Show form Student Payment 
                    FrmSaleReturn.Show()

                    'Select Search By
                    FrmSaleReturn.CmbSearch.SelectedIndex = 1

                    'Sale Invoice
                    FrmSaleReturn.TxtSaleReturnInvoiceNo.Text = Me.TxtSearchSaleReturnInvoice.Text


                    'Search Sale Return Invoice
                    FrmSaleReturn.SearchSaleReturnInvoice()

                    'Refresh data
                    FrmSaleReturn.RefreshSaleReturn()

                    'Show customer information
                    FrmSaleReturn.customerInformation()

                    'Search Sale Invoice
                    FrmSaleReturn.SearchInvoiceNumberAndProductDetails()

                    'Sale Form All Data input
                    FrmSaleReturn.TxtPaidAmount.Focus()
                    FrmSaleReturn.DtpReturnedDate.Value = row.Cells("Return Date").Value




                  

                    'send Paid by id to variable to update
                    FrmSaleReturn.PreviousPaidbyID = FrmSaleReturn.cmbPaidBy.SelectedValue


                    'sale return edit confirmation
                    FrmSaleReturn.SaleReturnEditStatus = True

                    'Focus on Product Name field
                    FrmSaleReturn.TxtPaidAmount.Focus()


                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Cell Mouse Double Click Gridview")
        Finally

        End Try
    End Sub

    Private Sub GrdSaleReturn_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

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