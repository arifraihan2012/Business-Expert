Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmVoucherHistory

    Private Sub TxtSearchStudentID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearchVoucherNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Search Voucher
            SearchVoucherNo()

        End If

    End Sub

    'sub for search voucher No
    Sub SearchVoucherNo()

        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select [Voucher Number].[Voucher No],[Voucher Number].[Voucher Category Name],[Voucher Number].[Name],[voucher Number].[Date],[Voucher Number].[Prepared Time],[Voucher Number].[Total Amount] from [Voucher Nmber] Join [Voucher] on [Voucher Nmber].[Voucher No]= [Voucher].[Voucher No]  where [voucher].[Voucher No]='" + TxtSearchVoucherNo.Text + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Voucher Number")
            connection.Close()
            GrdVoucherNo.DataSource = ds
            GrdVoucherNo.DataMember = "BizPro_Voucher Number"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdVoucherNo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            con.Close()





        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show All Complete Voucher Data Sub")
        Finally

        End Try





    End Sub

    ' Show Incomplete Voucher Data By Status And UserID
    Sub ShowIncompleteVoucherDataByStatusAndUserID()


        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select [Voucher Number].[Voucher No],[Voucher Number].[Voucher Category Name],[voucher Number].[Date],[Voucher Number].[Prepared Time],[Voucher Number].[Name],[Voucher Number].[Total Amount] from [Voucher Number]  where [Voucher Number].[Status]='INCOMPLETE' And [Voucher Number].[User Account ID]='" + FrmHome.LblUserID.Text + "' order by [Voucher Number].[Date] desc, [Voucher Number].[Prepared Time] desc "

            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Voucher Number")
            connection.Close()
            GrdVoucherNo.DataSource = ds
            GrdVoucherNo.DataMember = "BizPro_Voucher Number"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdVoucherNo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            con.Close()





        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show Incomplete Voucher Data By Invoice And User ID Sub")
        Finally

        End Try



    End Sub
    'Show Todays  Complete Voucher By loginID 

    Sub ShowCompleteVoucherDataByUserIDToday()

        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select [Voucher Number].[Voucher No],[Voucher Number].[Voucher Category Name],[Voucher Number].[Name],[voucher Number].[Date],[Voucher Number].[Prepared Time],[Voucher Number].[Total Amount] from [Voucher Number]  where [Voucher Number].[Status]='COMPLETE' And [Voucher Number].[Date]= '" + currentDate + "' And  [Voucher Number].[User Account ID]='" + FrmHome.LblUserID.Text + "'   order by [voucher Number].[Date] desc, [Voucher Number].[Prepared Time] desc "


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Voucher Number")
            connection.Close()
            GrdVoucherNo.DataSource = ds
            GrdVoucherNo.DataMember = "BizPro_Voucher Number"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdVoucherNo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            con.Close()





        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show Complete Voucher Data By User ID Today Sub")
        Finally

        End Try



    End Sub
    'Show  All Complete Invoice 

    Sub ShowAllCompleteVoucherData()

        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select [Voucher Number].[Voucher No],[Voucher Number].[Voucher Category Name],[Voucher Number].[Name],[voucher Number].[Date],[Voucher Number].[Prepared Time],[Voucher Number].[Total Amount] from [Voucher Number]  where [voucher Number].[Status]='COMPLETE'    order by [voucher Number].[Date] desc, [Voucher Number].[Prepared Time] desc "
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Voucher Number")
            connection.Close()
            GrdVoucherNo.DataSource = ds
            GrdVoucherNo.DataMember = "BizPro_Voucher Number"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdVoucherNo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            con.Close()





        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show All Complete Voucher Data Sub")
        Finally

        End Try



    End Sub


    Private Sub TxtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearchVoucherNo.TextChanged

    End Sub


    Private Sub GrdStudentPaymentInvoice_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdVoucherNo.CellContentClick

    End Sub

    Private Sub GrdStudentPaymentInvoice_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdVoucherNo.CellMouseClick
        'Data Grid view code
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdVoucherNo.Rows(e.RowIndex)

                TxtSearchVoucherNo.Text = row.Cells("Voucher No").Value.ToString



                'RefreshVoucher Details
                RefreshVoucherDetails()




            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview")

        End Try

    End Sub


    'Privet sub for refresh Voucher details
    Sub RefreshVoucherDetails()

        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Voucher Subcategory].[Voucher Subcategory Name],[Voucher Purpose].[Voucher Purpose Name],[Voucher].[Paid Amount],[Voucher].[Received Amount] From [Voucher] Join [Voucher Purpose] On [Voucher].[Voucher Purpose ID]=[Voucher Purpose].[Voucher Purpose ID] Join [Voucher Subcategory] On [Voucher].[Voucher Subcategory ID]=[Voucher Subcategory].[Voucher Subcategory ID] join [Voucher Number] on [Voucher].[Voucher No]= [Voucher Number].[Voucher No] Join [Branch Information] On [Branch Information].[Branch ID]=[Voucher Number].[Branch ID] where [Voucher Number].[Voucher No] = '" + TxtSearchVoucherNo.Text + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Voucher")
            connection.Close()
            GrdVoucherDetails.DataSource = ds
            GrdVoucherDetails.DataMember = "BizPro_Voucher"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdVoucherDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            con.Close()

            'Show Students Total Amount payable
            TotalAmount()





        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Refresh Voucher Details Sub")

        End Try
    End Sub


    Private Sub GrdStudentPaymentInvoice_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdVoucherNo.CellMouseDoubleClick
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdVoucherNo.Rows(e.RowIndex)





                If Me.TxtSearchVoucherNo.Text = "" Then
                    MsgBox("Please select a row from list")
                Else


                    'Show form Student Payment 
                    FrmVoucher.Show()

                    'Click Debit Voucher or credit voucher button

                    If row.Cells("Voucher Category Name").Value = "Debit Voucher" Then

                        FrmVoucher.BtnDebitVoucher.PerformClick()

                    ElseIf row.Cells("Voucher Category Name").Value = "Credit Voucher" Then

                        FrmVoucher.BtnCreditVoucher.PerformClick()

                    End If







                    'Voucher
                    FrmVoucher.TxtVoucherNo.Text = Me.TxtSearchVoucherNo.Text

                    'Voucher Form All Data input
                    FrmVoucher.CmbVoucherSubcategoryID.Focus()





                    'Refresh data
                    FrmVoucher.Search()




                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Cell Mouse Double Click Gridview")
        Finally

        End Try


    End Sub

    'Clear Data

    Sub ClearData()




        TxtSearchVoucherNo.Text = ""
    End Sub
    Sub TotalAmount()
        Dim total As String = 0
        For i As Integer = 0 To GrdVoucherDetails.RowCount - 1
            total += GrdVoucherDetails.Rows(i).Cells(2).Value + GrdVoucherDetails.Rows(i).Cells(3).Value
        Next
        Me.LblAmount.Text = total
    End Sub

    Private Sub FrmStudentPaymentHistory_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Attention mesasge for form close
        If (MessageBox.Show(" Do you really want to Close?", "Bizpro", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No) Then
            e.Cancel = True

        End If
    End Sub


    Private Sub FrmStudentPaymentHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'Change Language
        ChangeLanguage()



        'Show Incomplete Voucher Data By Status And User ID
        ShowIncompleteVoucherDataByStatusAndUserID()

        'Show total voucher today
        TotalDebitVoucherToday()
        TotalCreditVoucherToday()



    End Sub

    Sub TotalCreditVoucherToday()

        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "select sum([Received Amount]) as [Total Received Amount] from [Voucher]  Join [Voucher Number] on [Voucher].[Voucher No]= [Voucher Number].[Voucher No] where  datediff(DAY, [Date], getdate())  between 0 and 0"


            dr = cmd.ExecuteReader()
            dr.Read()

            Me.lblTotalReceived.Text = (dr.Item("Total Received Amount").ToString)



            dr.Close()
            con.Close()

        Catch ex As Exception

        End Try

        'Lode Combo box Private sub
    End Sub
    'Load Total Debit Voucher Today

    Sub TotalDebitVoucherToday()

        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "select sum([Paid Amount]) as [Total Paid Amount] from [Voucher] Join [Voucher Number] on [Voucher].[Voucher No]= [Voucher Number].[Voucher No] where datediff(DAY, [Date], getdate())  between 0 and 0"


            dr = cmd.ExecuteReader()
            dr.Read()

            Me.lblTotalPaid.Text = (dr.Item("Total Paid Amount").ToString)



            dr.Close()
            con.Close()

        Catch ex As Exception

        End Try

        'Lode Combo box Private sub
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

            Me.TxtSearchVoucherNo.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))



            Me.LblAmount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.lblTotalPaid.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.lblTotalReceived.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            Me.GrdVoucherNo.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.GrdVoucherNo.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)

            Me.GrdVoucherDetails.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.GrdVoucherDetails.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)
            'MsgBox(dr.Item("Language Font"))

            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Change Language Sub")
        Finally
            con.Close()
        End Try

        'End Language

    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLoadIncomplete.Click

        'Clear data
        ClearData()

        'Show Incomplete Voucher Data By Status And User ID
        ShowIncompleteVoucherDataByStatusAndUserID()

        'Refresh Data Voucher
        RefreshVoucherDetails()

        'Show total voucher today
        TotalDebitVoucherToday()
        TotalCreditVoucherToday()

    End Sub

    Private Sub GrdStudentPaymentInvoice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdVoucherNo.KeyDown

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'Clear data
        ClearData()


        'Show Todays  Complete Voucher By loginID
        ShowCompleteVoucherDataByUserIDToday()

        'Refresh Data Voucher
        RefreshVoucherDetails()

        'Show total voucher today
        TotalDebitVoucherToday()
        TotalCreditVoucherToday()

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        'Clear data
        ClearData()

        'Show  All Complete Invoice 
        ShowAllCompleteVoucherData()

        'Refresh Data Voucher
        RefreshVoucherDetails()

        'Show total voucher today
        TotalDebitVoucherToday()
        TotalCreditVoucherToday()

    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'Clear data
        ClearData()

        'Show All Incomplete Voucher Data 
        ShowAllIncompleteVoucherData()

        'Refresh Data Voucher
        RefreshVoucherDetails()

        'Show total voucher today
        TotalDebitVoucherToday()
        TotalCreditVoucherToday()


    End Sub

    'Show All Incomplete Voucher Data 
    Sub ShowAllIncompleteVoucherData()

        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select [Voucher Number].[Voucher No],[Voucher Number].[Voucher Category Name],[Voucher Number].[Name],[voucher Number].[Date],[Voucher Number].[Prepared Time],[Voucher Number].[Total Amount] from [Voucher Number]  where [voucher Number].[Status]='INCOMPLETE' order by [voucher Number].[Date] desc, [Voucher Number].[Prepared Time] desc "
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Voucher Number")
            connection.Close()
            GrdVoucherNo.DataSource = ds
            GrdVoucherNo.DataMember = "BizPro_Voucher Number"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdVoucherNo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            con.Close()





        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show All Complete Voucher Data Sub")
        Finally

        End Try



    End Sub

    Private Sub lblTotalPaid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTotalPaid.Click

    End Sub
End Class