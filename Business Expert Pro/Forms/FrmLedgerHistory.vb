Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmLedgerHistory
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point

    Private Sub TxtSearchStudentID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtLedgerInvoiceNo.KeyDown
        If e.KeyCode = Keys.Enter Then

            ' Search Ledger Invoice
            SearchLedgerInvoice()

            'Privet sub for refresh Ledger details
            RefreshLedgerDetails()

          

        End If

    End Sub


    'Show Incomplete Ledger Data By Status And UserID
    Sub ShowIncompleteLedgerDataByStatusAndUserID()

        Try
            

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select  [Ledger Invoice 2].[Ledger Invoice ID 2][Ledger Invoice No],[Chart of Account].[Account Name],[Ledger Invoice 2].[Ledger Date],[Ledger Invoice 2].[Prepared Time][Ledger Time],[Ledger].[Category Name], (isnull(sum([Ledger].[Debited Amount]),0))[Amount] from [Ledger Invoice 2] join [Chart of Account] on [Ledger Invoice 2].[Chart of Account ID]=[Chart of Account].[Chart of Account ID]  join Ledger on   [Ledger Invoice 2].[Ledger Invoice ID 2]=Ledger.[Ledger Invoice ID 2]where [Ledger Invoice 2].[User Account ID]='" + FrmHome.LblUserID.Text + "' and [Ledger Invoice 2].[Status]='INCOMPLETE'     group by  [Ledger Invoice 2].[Ledger Invoice ID 2],[Chart of Account].[Account Name],[Ledger Invoice 2].[Ledger Date],[Ledger Invoice 2].[Prepared Time],[Ledger].[Category Name] order by [Ledger Invoice 2].[Ledger Date]  desc, [Ledger Invoice 2].[Prepared Time] desc "
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Ledger Invoice 2")
            connection.Close()
            GrdLedgerInvoice.DataSource = ds
            GrdLedgerInvoice.DataMember = "BizPro_Ledger Invoice 2"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdLedgerInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill





        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try



    End Sub
    'Show Todays  Complete Ledger By login ID 

    Sub ShowCompleteLedgerDataByUserIDToday()

        Try
            
            Dim currentDate As DateTime = DateTime.Today

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select  [Ledger Invoice 2].[Ledger Invoice ID 2][Ledger Invoice No],[Chart of Account].[Account Name],[Ledger Invoice 2].[Ledger Date],[Ledger Invoice 2].[Prepared Time][Ledger Time],[Ledger].[Category Name], (isnull(sum([Ledger].[Debited Amount]),0))[Amount] from [Ledger Invoice 2] join [Chart of Account] on [Ledger Invoice 2].[Chart of Account ID]=[Chart of Account].[Chart of Account ID]  join Ledger on   [Ledger Invoice 2].[Ledger Invoice ID 2]=Ledger.[Ledger Invoice ID 2] where [Ledger Invoice 2].[User Account ID]='" + FrmHome.LblUserID.Text + "' and [Ledger Invoice 2].[Status]='COMPLETE' and [Ledger Invoice 2].[Ledger Date]= '" + currentDate + "'  group by  [Ledger Invoice 2].[Ledger Invoice ID 2],[Chart of Account].[Account Name],[Ledger Invoice 2].[Ledger Date],[Ledger Invoice 2].[Prepared Time],[Ledger].[Category Name]  order by [Ledger Invoice 2].[Ledger Date]  desc, [Ledger Invoice 2].[Prepared Time] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Ledger Invoice 2")
            connection.Close()
            GrdLedgerInvoice.DataSource = ds
            GrdLedgerInvoice.DataMember = "BizPro_Ledger Invoice 2"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdLedgerInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill





        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show Complete Purchase Data By User ID Today sub")
        Finally

        End Try



    End Sub

    'Show  All Complete Ledger Invoice Invoice 
    Sub ShowAllCompleteLedgerData()
        Try
           
            Dim currentDate As DateTime = DateTime.Today

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select  [Ledger Invoice 2].[Ledger Invoice ID 2][Ledger Invoice No],[Chart of Account].[Account Name],[Ledger Invoice 2].[Ledger Date],[Ledger Invoice 2].[Prepared Time][Ledger Time],[Ledger].[Category Name], (isnull(sum([Ledger].[Debited Amount]),0))[Amount] from [Ledger Invoice 2] join [Chart of Account] on [Ledger Invoice 2].[Chart of Account ID]=[Chart of Account].[Chart of Account ID]  join Ledger on   [Ledger Invoice 2].[Ledger Invoice ID 2]=Ledger.[Ledger Invoice ID 2] where [Ledger Invoice 2].[Status]='COMPLETE'  and [Ledger Invoice 2].[Branch ID]='" + FrmHome.lblBranchID.Text + "'   group by  [Ledger Invoice 2].[Ledger Invoice ID 2],[Chart of Account].[Account Name],[Ledger Invoice 2].[Ledger Date],[Ledger Invoice 2].[Prepared Time],[Ledger].[Category Name] ORDER BY [Ledger Invoice 2].[Ledger Date] desc, [Ledger Invoice 2].[Prepared Time] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Ledger Invoice 2")
            connection.Close()
            GrdLedgerInvoice.DataSource = ds
            GrdLedgerInvoice.DataMember = "BizPro_Ledger Invoice 2"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdLedgerInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill





        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show All Complete Purchase Data Sub")
        Finally

        End Try



    End Sub

    'Show  All Complete Ledger Collection
    Sub ShowAllCompleteLedgerCollection()
        Try
            
            Dim currentDate As DateTime = DateTime.Today

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select  [Ledger Invoice 2].[Ledger Invoice ID 2][Ledger Invoice No],[Chart of Account].[Account Name],[Ledger Invoice 2].[Ledger Date],[Ledger Invoice 2].[Prepared Time][Ledger Time],[Ledger].[Category Name], (isnull(sum([Ledger].[Debited Amount]),0))[Amount] from [Ledger Invoice 2] join [Chart of Account] on [Ledger Invoice 2].[Chart of Account ID]=[Chart of Account].[Chart of Account ID]  join Ledger on   [Ledger Invoice 2].[Ledger Invoice ID 2]=Ledger.[Ledger Invoice ID 2] where [Ledger Invoice 2].[Status]='COMPLETE' and [Category Name]='COLLECTION'   group by  [Ledger Invoice 2].[Ledger Invoice ID 2],[Chart of Account].[Account Name],[Ledger Invoice 2].[Ledger Date],[Ledger Invoice 2].[Prepared Time],[Ledger].[Category Name] ORDER BY [Ledger Invoice 2].[Ledger Date] desc, [Ledger Invoice 2].[Prepared Time] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Ledger Invoice 2")
            connection.Close()
            GrdLedgerInvoice.DataSource = ds
            GrdLedgerInvoice.DataMember = "BizPro_Ledger Invoice 2"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdLedgerInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill





        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show All Complete Purchase Data Sub")
        Finally

        End Try



    End Sub
    ' Search Ledger Invoice
    Sub SearchLedgerInvoice()

        Try
            

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select  [Ledger Invoice 2].[Ledger Invoice ID 2][Ledger Invoice No],[Chart of Account].[Account Name],[Ledger Invoice 2].[Ledger Date],[Ledger Invoice 2].[Prepared Time][Ledger Time],[Ledger].[Category Name], (isnull(sum([Ledger].[Debited Amount]),0))[Amount] from [Ledger Invoice 2] join [Chart of Account] on [Ledger Invoice 2].[Chart of Account ID]=[Chart of Account].[Chart of Account ID]  join Ledger on   [Ledger Invoice 2].[Ledger Invoice ID 2]=Ledger.[Ledger Invoice ID 2] where [Ledger Invoice 2].[Ledger Invoice ID 2]='" + TxtLedgerInvoiceNo.Text + "' group by  [Ledger Invoice 2].[Ledger Invoice ID 2],[Chart of Account].[Account Name],[Ledger Invoice 2].[Ledger Date],[Ledger Invoice 2].[Prepared Time],[Ledger].[Category Name]  order by [Ledger Invoice 2].[Ledger Date]  desc, [Ledger Invoice 2].[Prepared Time] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Purchase Invoice")
            connection.Close()
            GrdLedgerInvoice.DataSource = ds
            GrdLedgerInvoice.DataMember = "BizPro_Purchase Invoice"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdLedgerInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill





        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Search Purchase Invoice Sub")
        Finally

        End Try



    End Sub

    Private Sub TxtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtLedgerInvoiceNo.TextChanged

    End Sub


    Private Sub GrdStudentPaymentInvoice_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdLedgerInvoice.CellContentClick

    End Sub

    Private Sub GrdPurchaseInvoice_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles GrdLedgerInvoice.CellFormatting
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

                If GrdLedgerInvoice.Columns(e.ColumnIndex).Name.Equals("Total") Then
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

    Private Sub GrdStudentPaymentInvoice_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdLedgerInvoice.CellMouseClick

        'Data Grid view code
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdLedgerInvoice.Rows(e.RowIndex)

                TxtLedgerInvoiceNo.Text = row.Cells("Ledger Invoice No").Value.ToString



                'Sub For Customer info show in label
                'DataReaderForCustomerLabel()


                'Privet sub for refresh Ledger details
                RefreshLedgerDetails()



            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview")

        End Try

    End Sub

    'Privet sub for refresh Ledger details
    Sub RefreshLedgerDetails()

        Try

            

            Dim connectionString As String = FrmHome.ConnectionString

            Dim sql As String = "WITH RankedData AS (SELECT *, RN = ROW_NUMBER() OVER(PARTITION BY [invoice No], [Category Name] ORDER BY [invoice No],[Category Name]) FROM Ledger where [Branch ID]='" + FrmHome.lblBranchID.Text + "' and [ledger invoice id 2]='" + TxtLedgerInvoiceNo.Text + "') SELECT [Value+] = MAX(CASE WHEN RN = 1 THEN [Chart of Account]. [Account Name] ELSE '' END), [Value-] = MAX(CASE WHEN RN = 2 THEN [Chart of Account]. [Account Name] ELSE '' END),[Voucher No],[Check No],Remarks,sum([Debited Amount])[Amount], [Check Issue Date] FROM RankedData join [Chart of Account] on RankedData.[Chart Of Account ID]=[Chart of Account].[Chart of Account ID] where   RankedData.[Category Name]='Collection' or RankedData.[Category Name]='Payment' or RankedData.[Category Name]='Expense' or RankedData.[Category Name]='Transfer'  GROUP BY [ledger invoice id 2],[Invoice No],[Voucher No],[Check No],Remarks,[Ledger Date],[category Name], [Check Issue Date] order by RankedData.[ledger Date]  desc, RankedData.[Invoice No] desc   "


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Ledger")
            connection.Close()
            GrdLedger.DataSource = ds
            GrdLedger.DataMember = "BizPro_Ledger"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdLedger.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


            'Total Amount Count
            TotalAmount()

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Refresh Purchase Details Sub")

        End Try
    End Sub


    Private Sub GrdStudentPaymentInvoice_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdLedgerInvoice.CellMouseDoubleClick

        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdLedgerInvoice.Rows(e.RowIndex)





                If Me.TxtLedgerInvoiceNo.Text = "" Then
                    MsgBox("Please select a row from list")
                Else


                    'Show form Ledger
                    FrmLedger.Show()

                    'Clear All Data
                    FrmLedger.clearAllData()


                    'Show Ledger Invoice no
                    FrmLedger.TxtLedgerInvoiceNo.Text = Me.TxtLedgerInvoiceNo.Text



                    'Refresh data
                    FrmLedger.RefreshData()

                    'Focus on Product Name field
                    FrmLedger.BtnCollection.Focus()



                    'Show All Data To Ledger

                    FrmLedger.DtpLedgerDate.Value = row.Cells("Ledger Date").Value


                    'Change the color of the button on ledger form
                    If row.Cells("Category Name").Value.ToString = "Collection" Then
                        FrmLedger.BtnCollection.ForeColor = Color.Blue
                    ElseIf row.Cells("Category Name").Value.ToString = "Payment" Then
                        FrmLedger.BtnPayment.ForeColor = Color.Red
                    ElseIf row.Cells("Category Name").Value.ToString = "Expense" Then
                        FrmLedger.BtnExpense.ForeColor = Color.Red
                    ElseIf row.Cells("Category Name").Value.ToString = "Transfer" Then
                        FrmLedger.BtnTransfer.ForeColor = Color.Green
                    End If

                    'Enable ledger gridview
                    FrmLedger.GrpLedger.Enabled = True
                End If




            End If
        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Cell Mouse Double Click Gridview")

        Finally

        End Try




    End Sub


    'Clear Data

    Sub ClearData()

        BtnCollection.ForeColor = Color.Black
        BtnPayment.ForeColor = Color.Black
        BtnExpense.ForeColor = Color.Black
        BtnTransfer.ForeColor = Color.Black


        TxtLedgerInvoiceNo.Text = ""
    End Sub
    'Total Amount Count
    Sub TotalAmount()
        Dim total As String = 0
        For i As Integer = 0 To GrdLedger.RowCount - 1
            total += GrdLedger.Rows(i).Cells(5).Value
        Next
        Me.LblAmount.Text = total
    End Sub

    Private Sub FrmStudentPaymentHistory_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub


    Private Sub FrmStudentPaymentHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Location = New Point(0, 0)
        Me.Size = My.Computer.Screen.WorkingArea.Size



        'Change Language
        ChangeLanguage()



        'Show Incomplete Ledger Data By Status And UserID
        ShowIncompleteLedgerDataByStatusAndUserID()


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

                Me.TxtLedgerInvoiceNo.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.LblAmount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))


                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

                Me.GrdLedgerInvoice.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdLedgerInvoice.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)

                Me.GrdLedger.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdLedger.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)
                'MsgBox(dr.Item("Language Font"))
            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Change Language Sub")
        Finally
        End Try

        'End Language

    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub GrdPurchaseInvoice_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles GrdLedgerInvoice.DragEnter

    End Sub

    Private Sub GrdStudentPaymentInvoice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdLedgerInvoice.KeyDown

    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    'Show All Incomplete Ledger data
    Sub ShowAllIncompleteLedgerData()

        Try
            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select  [Ledger Invoice 2].[Ledger Invoice ID 2][Ledger Invoice No],[Chart of Account].[Account Name],[Ledger Invoice 2].[Ledger Date],[Ledger Invoice 2].[Prepared Time][Ledger Time],[Ledger].[Category Name], (isnull(sum([Ledger].[Debited Amount]),0))[Amount] from [Ledger Invoice 2] join [Chart of Account] on [Ledger Invoice 2].[Chart of Account ID]=[Chart of Account].[Chart of Account ID]  join Ledger on   [Ledger Invoice 2].[Ledger Invoice ID 2]=Ledger.[Ledger Invoice ID 2] where [Ledger Invoice 2].[Status]='INCOMPLETE'     group by  [Ledger Invoice 2].[Ledger Invoice ID 2],[Chart of Account].[Account Name],[Ledger Invoice 2].[Ledger Date],[Ledger Invoice 2].[Prepared Time],[Ledger].[Category Name] order by [Ledger Invoice 2].[Ledger Date]  desc, [Ledger Invoice 2].[Prepared Time] desc "
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Ledger Invoice 2")
            connection.Close()
            GrdLedgerInvoice.DataSource = ds
            GrdLedgerInvoice.DataMember = "BizPro_Ledger Invoice 2"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdLedgerInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill





        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show All Incomplete Purchase Data Sub")
        Finally

        End Try


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub


    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'Clear data
        ClearData()

        'Show Todays  Complete Ledger By loginID 
        ShowCompleteLedgerDataByUserIDToday()


        'Privet sub for refresh Ledger details
        RefreshLedgerDetails()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'Clear data
        ClearData()

        'Show  All Complete Ledger Invoice Invoice 
        ShowAllCompleteLedgerData()


        'Privet sub for refresh Ledger details
        RefreshLedgerDetails()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click


        'Clear data
        ClearData()

        'Show Incomplete Ledger Data By Status And UserID
        ShowIncompleteLedgerDataByStatusAndUserID()


        'Privet sub for refresh Ledger details
        RefreshLedgerDetails()


    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click



        'Clear data
        ClearData()


        'Show All Incomplete Ledger data
        ShowAllIncompleteLedgerData()



        'Privet sub for refresh Ledger details
        RefreshLedgerDetails()


    End Sub

    Private Sub GrdPurchase_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdLedger.CellContentClick

    End Sub

    Private Sub GrdPurchase_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles GrdLedger.CellFormatting
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

                If GrdLedger.Columns(e.ColumnIndex).Name.Equals("Purchase Unit Cost") Then

                    If (Not e.Value Is Nothing) Then
                        e.Value = New String(CChar("*"), e.Value.ToString.Length)

                    End If

                ElseIf GrdLedger.Columns(e.ColumnIndex).Name.Equals("Amount") Then
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

    Private Sub CmbVoucherName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbVoucherName.KeyPress
        e.Handled = True
    End Sub

    Private Sub CmbVoucherName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbVoucherName.SelectedIndexChanged

    End Sub

    Private Sub BtnCollection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCollection.Click

        BtnCollection.ForeColor = Color.Blue
        BtnPayment.ForeColor = Color.Black
        BtnExpense.ForeColor = Color.Black
        BtnTransfer.ForeColor = Color.Black


        'Show  All Complete Ledger Collection
        ShowAllCompleteLedgerCollection()

    End Sub

    Private Sub BtnPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPayment.Click
        BtnCollection.ForeColor = Color.Black
        BtnPayment.ForeColor = Color.Red
        BtnExpense.ForeColor = Color.Black
        BtnTransfer.ForeColor = Color.Black

    End Sub

    Private Sub BtnExpense_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExpense.Click
        BtnCollection.ForeColor = Color.Black
        BtnPayment.ForeColor = Color.Black
        BtnExpense.ForeColor = Color.Red
        BtnTransfer.ForeColor = Color.Black

    End Sub

    Private Sub BtnTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTransfer.Click
        BtnCollection.ForeColor = Color.Black
        BtnPayment.ForeColor = Color.Black
        BtnExpense.ForeColor = Color.Black
        BtnTransfer.ForeColor = Color.Green
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

 
End Class