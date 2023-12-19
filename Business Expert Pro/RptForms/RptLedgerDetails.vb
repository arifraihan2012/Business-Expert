Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.IO.Ports
Imports System.Text.RegularExpressions



Public Class RptLedgerDetails
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point

    Dim saleReturnInvoiceNo
    Dim purchaseReturnInvoiceNo

    Private Sub Panel2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseMove
        'If e.Button = Windows.Forms.MouseButtons.Left Then
        'newpoint = Control.MousePosition
        'newpoint.X -= (X)
        'newpoint.Y -= (Y)
        'Me.Location = newpoint

        'End If

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

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

    Private Sub RptLedgerDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Location = New Point(0, 0)
        Me.Size = My.Computer.Screen.WorkingArea.Size

        'Me.DtpFromDate.Value = Now
        Me.DtpFromDate.Value = "2015-01-01"
        Me.DtpToDate.Value = Now

    End Sub
    'Search Balance
    Sub SearchBalance()
        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader




            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "select (isnull(sum([debited amount]),0)- isnull(sum([Credited Amount]),0))[Balance],(select  (isnull(sum([debited amount]),0)) from ledger join [Chart of Account] on Ledger.[Chart Of Account ID]=[Chart of Account].[Chart of Account ID] where   [Ledger].[Status]= 'WithHeld' And Ledger.[Chart Of Account ID]= [Chart of Account].[Chart of Account ID] and Ledger.[Chart Of Account ID]=  '" + CmbChartOfAccount.ValueMember + "')[Pending Check Amount],(select count([debited amount]) from ledger join [Chart of Account] on Ledger.[Chart Of Account ID]=[Chart of Account].[Chart of Account ID] where   [Ledger].[Status]= 'WithHeld' And Ledger.[Chart Of Account ID]= [Chart of Account].[Chart of Account ID] and Ledger.[Chart Of Account ID]=  '" + CmbChartOfAccount.ValueMember + "')[Number Of Cheque] from ledger join [Chart of Account] on Ledger.[Chart Of Account ID]=[Chart of Account].[Chart of Account ID] where not  [Ledger].[Status]= 'WithHeld' And Ledger.[Chart Of Account ID]= [Chart of Account].[Chart of Account ID] and Ledger.[Chart Of Account ID]=  '" + CmbChartOfAccount.ValueMember + "'"

            dr = cmd.ExecuteReader
            dr.Read()

            If dr.HasRows Then


                LblBalance.Text = Double.Parse((dr.Item("Balance").ToString)).ToString()
                LblPendingCheque.Text = (dr.Item("Number Of Cheque").ToString)
                LblCheckAmount.Text = (dr.Item("Pending Check Amount").ToString)


            End If
            dr.Close()
            con.Close()


            If Val(LblBalance.Text) >= 0 Then
                LblBalanceLbl.ForeColor = Color.Green

            Else
                LblBalanceLbl.ForeColor = Color.Red
            End If


            

        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try

    End Sub
    Sub SearchSaleInvoiceNoForSaleReturnInvoice()
        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader


            'Data reader for Product Id
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT * from [Sale Return Invoice] WHERE [Sale Return Invoice No] =  '" + saleReturnInvoiceNo + "'"
            dr = cmd.ExecuteReader()
            dr.Read()
            If dr.HasRows Then

                RptSaleReturnInvoice.SaleInvoiceNo = dr.Item("Sale Invoice No").ToString

            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Search Sale Return Invoice")
        Finally

        End Try
    End Sub
    Sub SearchPurchaseInvoiceNoForPurchaseReturnInvoice()
        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader


            'Data reader for Product Id
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT * from [Purchase Return Invoice] WHERE [Purchase Return Invoice No] =  '" + purchaseReturnInvoiceNo + "'"
            dr = cmd.ExecuteReader()
            dr.Read()
            If dr.HasRows Then

                RptPurchaseReturnInvoice.PurchaseInvoiceNo = dr.Item("Purchase Invoice No").ToString

            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Search Sale Return Invoice")
        Finally

        End Try
    End Sub
    'Creating Privet Sub for Refresh
    Sub RefreshData()

        ' Load Data
        Try


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select Ledger.[Ledger Date],case when [Category Name]='Collection' or  [Category Name]='Payment' or [Category Name]='Expense' or [Category Name]='Transfer' then [Ledger Invoice ID 2] else	[Invoice No] end [Invoice No],Remarks,Ledger.[Description],[Category Name],[Debited Amount]+[Credited Amount][Amount] from ledger join [Chart of Account] on Ledger.[Chart Of Account ID]=[Chart of Account].[Chart of Account ID] where Ledger.[Chart Of Account ID]='" + CmbChartOfAccount.ValueMember + "' and [Ledger Date] between  '" + DtpFromDate.Value + "' and '" + DtpToDate.Value + "' order by [Ledger Date] asc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Ledger")
            connection.Close()
            GrdLedgerDetails.DataSource = ds
            GrdLedgerDetails.DataMember = "BizPro_Ledger"

            'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)


            GrdLedgerDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

          


            


        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try

        'End Refresh Data
    End Sub

    Private Sub BtnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShow.Click
        If Not CmbChartOfAccount.Text = "" Then

            'Search Balance
            SearchBalance()

            RefreshData()

        End If
    End Sub

    Private Sub GrdLedgerDetails_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdLedgerDetails.CellContentClick

    End Sub

    Private Sub GrdLedgerDetails_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdLedgerDetails.CellMouseDoubleClick
        'Grid View Codes
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdLedgerDetails.Rows(e.RowIndex)


                If row.Cells("Category Name").Value = "Cash Sale" Or row.Cells("Category Name").Value = "Sale" Then

                    RptSaleInvoice.SaleInvoiceNo = row.Cells("Invoice No").Value.ToString

                    RptSaleInvoice.ShowSaleInvoice()
                    RptSaleInvoice.Show()

                ElseIf row.Cells("Category Name").Value = "Cash Purchase" Or row.Cells("Category Name").Value = "Purchase" Then

                    RptPurchaseInvoice.PurchaseInvoiceNo = row.Cells("Invoice No").Value.ToString

                    RptPurchaseInvoice.ShowInvoice()
                    RptPurchaseInvoice.Show()

                ElseIf row.Cells("Category Name").Value = "Collection" Then

                    RptReceitpVoucher.InvoiceNo = row.Cells("Invoice No").Value.ToString

                    RptReceitpVoucher.ShowVoucherInvoice()
                    RptReceitpVoucher.Show()

                ElseIf row.Cells("Category Name").Value = "Payment" Then

                    RptPaymentVoucher.InvoiceNo = row.Cells("Invoice No").Value.ToString

                    RptPaymentVoucher.ShowVoucherInvoice()
                    RptPaymentVoucher.Show()
                ElseIf row.Cells("Category Name").Value = "Expense" Then

                    RptExpenseVoucher.InvoiceNo = row.Cells("Invoice No").Value.ToString

                    RptExpenseVoucher.ShowExpenseVoucherInvoice()
                    RptExpenseVoucher.Show()

                ElseIf row.Cells("Category Name").Value = "Transfer" Then

                    RptTransferVoucher.InvoiceNo = row.Cells("Invoice No").Value.ToString

                    RptTransferVoucher.ShowTransferVoucherInvoice()
                    RptTransferVoucher.Show()
                ElseIf row.Cells("Category Name").Value = "Sale Return" Then


                    RptSaleReturnInvoice.SaleReturnInvoiceNo = row.Cells("Invoice No").Value.ToString
                    saleReturnInvoiceNo = row.Cells("Invoice No").Value.ToString
                    SearchSaleInvoiceNoForSaleReturnInvoice()


                    RptSaleReturnInvoice.ShowInvoice()
                    RptSaleReturnInvoice.Show()

                ElseIf row.Cells("Category Name").Value = "Purchase Return" Then

                    RptPurchaseReturnInvoice.PurchaseReturnInvoiceNo = row.Cells("Invoice No").Value.ToString
                    purchaseReturnInvoiceNo = row.Cells("Invoice No").Value.ToString
                    SearchPurchaseInvoiceNoForPurchaseReturnInvoice()


                    RptPurchaseReturnInvoice.ShowInvoice()
                    RptPurchaseReturnInvoice.Show()
                End If






            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

        End Try
    End Sub

    Private Sub BtnPrintLedger_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintLedger.Click
        RptLedger.Show()
        RptLedger.CmbChartOfAccount.SelectedValue = Me.CmbChartOfAccount.ValueMember
        RptLedger.DtpFromDate.Value = Me.DtpFromDate.Value
        RptLedger.DtpToDate.Value = Me.DtpToDate.Value
        RptLedger.CmbSelectSearchType.SelectedIndex = 1
        RptLedger.BtnShow.PerformClick()
    End Sub

    Private Sub CmbChartOfAccount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbChartOfAccount.KeyDown
        If e.KeyCode = Keys.Down Then

            ' Resize Customer GridView And Make it Visible()
            ResizeCustomerGridViewAndMakeitVisible()

            'Search By Customer Name For Current Branch
            SearchByCustomerNameForCurrentBranch()


            GrdCustomerList.Visible = True

            GrdCustomerList.Focus()
        ElseIf e.KeyCode = Keys.Enter Then
            'Show Customer Details In Textboxs
            ShowCustomerDetailsInTextboxs()
        End If

    End Sub

    

    Private Sub CmbChartOfAccount_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CmbChartOfAccount.MouseClick
        ' Resize Customer GridView And Make it Visible()
        ResizeCustomerGridViewAndMakeitVisible()

        'Search By Customer Name For Current Branch
        SearchByCustomerNameForCurrentBranch()
    End Sub

    Private Sub CmbChartOfAccount_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbChartOfAccount.SelectedIndexChanged

    End Sub

    'Resize Customer Grid View And Makeit Visible
    Sub ResizeCustomerGridViewAndMakeitVisible()

        GrdCustomerList.Visible = True
        GrdCustomerList.Width = 400
        GrdCustomerList.Height = 113

        'Column visiblity false
        GrdCustomerList.ColumnHeadersVisible = False

    End Sub
    'Search By Customer Name For Current Branch
    Sub SearchByCustomerNameForCurrentBranch()
        ' Load Data
        Try
             

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select  [Chart of Account].[Chart of Account ID], [Chart of Account].[Account Name],(case when [Customer Information].[Mobile No] is null then '00' else [Customer Information].[Mobile No] end)[Mobile No]from [Chart of Account] left join [Customer Information] on [Chart of Account].[Chart of Account ID]=[Customer Information].[Chart of Account ID] where [Chart of Account].[Account Name]+(case when [Customer Information].[Mobile No] is null then '00' else [Customer Information].[Mobile No] end) LIKE '%" + CmbChartOfAccount.Text + "%'"


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Customer Information")
            connection.Close()
            GrdCustomerList.DataSource = ds
            GrdCustomerList.DataMember = "BizPro_Customer Information"


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            GrdCustomerList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells


            If GrdCustomerList.RowCount < 1 Then
                GrdCustomerList.Visible = False
            End If

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records")
        Finally

        End Try

        'End Refresh Data

    End Sub
    'Show Customer Details In Textboxs
    Sub ShowCustomerDetailsInTextboxs()
        Try

            Dim i As Integer
            i = GrdCustomerList.CurrentRow.Index




            'Show customer name and valumember
            CmbChartOfAccount.ValueMember = GrdCustomerList.Item(0, i).Value

            'Show Product name to combobox
            CmbChartOfAccount.Text = GrdCustomerList.Item(1, i).Value


            BtnShow.PerformClick()

            'hide product list gridview
            GrdCustomerList.Visible = False




        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

        End Try
    End Sub

    Private Sub CmbChartOfAccount_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbChartOfAccount.TabIndexChanged

    End Sub

    Private Sub CmbChartOfAccount_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbChartOfAccount.TextChanged
        If Not CmbChartOfAccount.Text = "" Then


            ' Resize Customer GridView And Make it Visible()
            ResizeCustomerGridViewAndMakeitVisible()

            'Search By Customer Name For Current Branch
            SearchByCustomerNameForCurrentBranch()




        ElseIf CmbChartOfAccount.Text = "" Then

            GrdCustomerList.Visible = False

            CmbChartOfAccount.Text = ""
            CmbChartOfAccount.ValueMember = ""

        End If
    End Sub

    Private Sub RptLedgerDetails_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        'Hide Customer ledger gridview
        GrdCustomerList.Hide()
    End Sub

    Private Sub GrdCustomerList_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdCustomerList.CellContentClick

    End Sub

    Private Sub GrdCustomerList_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdCustomerList.CellMouseDoubleClick
        'Show Customer Details In Textboxs
        ShowCustomerDetailsInTextboxs()
    End Sub

    Private Sub GrdCustomerList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdCustomerList.KeyDown
        If e.KeyCode = Keys.Enter Then

            'Show Customer Details In Textboxs
            ShowCustomerDetailsInTextboxs()

        End If
    End Sub
End Class