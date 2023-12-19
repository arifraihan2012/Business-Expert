Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmSaleReturn
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point

    Public ProductIDForSearchSaleSerialNumber As String
    Public SaleInvoiceNumber As String
    Public ProductIDForSearchReturnSerialNumber As String
    Public PurchaseID As String
    'Public CustomerChartofAccountID As String
    Public PreviousPaidbyID As String
    Public CustomerID As String
    Public SaleReturnEditStatus As Boolean

    Dim pendingInvoiceNo As String



    'Search Sale Record
    Sub SearchSaleInvoice()

        ' Load Data
        Try
            'search by Customer Name
            If CmbSearch.SelectedIndex = 0 Then

                 
                Dim currentDate As DateTime = DateTime.Today

                Dim connectionString As String = FrmHome.ConnectionString
                Dim sql As String = "SELECT [Sale Invoice].[Sale Invoice No],[Branch Information].[Branch Name],[Customer Information].[Customer Name],[Sale Invoice].[Sale Date],[Sale Invoice].[Sale Time],[Sale Invoice].[Total] from [Sale Invoice] join sale on [Sale Invoice].[Sale Invoice No]=Sale.[Sale Invoice No] join [Branch Information] on Sale.[Branch ID]= [Branch Information].[Branch ID] join [User Account] on [Sale Invoice].[User Account ID]=[User Account].[User Account ID]join [Customer Information] on [Sale Invoice].[Customer ID]=[Customer Information].[Customer ID]   where [Customer Information].[Customer Name] Like '%" + TxtSearch.Text + "%' and  [Sale Invoice].[Status]='Complete' group by [Sale Invoice].[Sale Invoice No],[Branch Information].[Branch Name],[Customer Information].[Customer Name],[Sale Invoice].[Sale Date],[Sale Invoice].[Sale Time],[Sale Invoice].[Total] order by [Sale Invoice].[Sale Date]  desc, [Sale Invoice].[Sale Time] desc"
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
           


            ElseIf CmbSearch.SelectedIndex = 2 Then

                'search by Mobile No

              
                Dim currentDate As DateTime = DateTime.Today

                Dim connectionString As String = FrmHome.ConnectionString
                Dim sql As String = "SELECT [Sale Invoice].[Sale Invoice No],[Branch Information].[Branch Name],[Customer Information].[Customer Name],[Sale Invoice].[Sale Date],[Sale Invoice].[Sale Time],[Sale Invoice].[Total] from [Sale Invoice] join sale on [Sale Invoice].[Sale Invoice No]=Sale.[Sale Invoice No] join [Branch Information] on Sale.[Branch ID]= [Branch Information].[Branch ID] join [User Account] on [Sale Invoice].[User Account ID]=[User Account].[User Account ID]join [Customer Information] on [Sale Invoice].[Customer ID]=[Customer Information].[Customer ID]   where [Customer Information].[Mobile No] Like '%" + TxtSearch.Text + "%' and  [Sale Invoice].[Status]='Complete' group by [Sale Invoice].[Sale Invoice No],[Branch Information].[Branch Name],[Customer Information].[Customer Name],[Sale Invoice].[Sale Date],[Sale Invoice].[Sale Time],[Sale Invoice].[Total] order by [Sale Invoice].[Sale Date]  desc, [Sale Invoice].[Sale Time] desc"
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


            ElseIf CmbSearch.SelectedIndex = 3 Then

                'search by Product Name
                
                Dim currentDate As DateTime = DateTime.Today

                Dim connectionString As String = FrmHome.ConnectionString
                Dim sql As String = "SELECT [Sale Invoice].[Sale Invoice No],[Branch Information].[Branch Name],[Customer Information].[Customer Name],[Sale Invoice].[Sale Date],[Sale Invoice].[Sale Time],[Sale Invoice].[Total] from [Sale Invoice] join sale on [Sale Invoice].[Sale Invoice No]=Sale.[Sale Invoice No] join [Branch Information] on Sale.[Branch ID]= [Branch Information].[Branch ID] join [User Account] on [Sale Invoice].[User Account ID]=[User Account].[User Account ID]join [Customer Information] on [Sale Invoice].[Customer ID]=[Customer Information].[Customer ID] join Products on sale.[Product ID]= products.[Product ID]   where  products.[Product Name] Like '%" + TxtSearch.Text + "%' and  [Sale Invoice].[Status]='Complete' group by [Sale Invoice].[Sale Invoice No],[Branch Information].[Branch Name],[Customer Information].[Customer Name],[Sale Invoice].[Sale Date],[Sale Invoice].[Sale Time],[Sale Invoice].[Total] order by [Sale Invoice].[Sale Date]  desc, [Sale Invoice].[Sale Time] desc"
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





            End If

        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try

    End Sub
    'Search Pendig Invoice No for adujust balance
    Sub SearchPendingInvoice()
        Try



            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader


            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Select * from Ledger Where [Category Name]='Sale' and [Invoice No]='" + SaleInvoiceNumber + "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then


                pendingInvoiceNo = dr.Item("Pending Invoice").ToString
            End If
            dr.Close()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Update or insert Customer ledger For dues
    Sub InsertorUpdateCustomerLedgerForDues()



        Try

            Dim con As New SqlConnection
            Dim con1 As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand
            Dim cmd3 As New SqlCommand
            Dim cmd4 As New SqlCommand
            'Dim cmd5 As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now
            Dim dr As SqlDataReader
            Dim dr3 As SqlDataReader

            Dim SaleReturnChartOfAccountID As String
            Dim NetPayable As String

            NetPayable = (Val(TxtTotal.Text) - Val(TxtDiscount.Text))

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd3.Connection = con
            cmd3.CommandText = "SELECT  *FROM [Chart Of Account]  WHERE [Account Name] = 'SALE RETURN'"

            dr3 = cmd3.ExecuteReader()
            dr3.Read()
            If dr3.HasRows Then


                SaleReturnChartOfAccountID = (dr3.Item("Chart Of Account ID").ToString)
            End If
            dr3.Close()


            cmd.CommandText = "SELECT  *FROM [Ledger]  WHERE  [Category Name]='Sale Return' And [Invoice No] = '" + TxtSaleReturnInvoiceNo.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()




            If Not dr.HasRows Then

                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd4.Connection = con1
                cmd1.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart Of Account ID],[Invoice No],[Category Name],[User Account ID],[Computer ID],[Prepared Date] ,[Prepared Time],[Debited Amount],[Credited Amount],[Status],[Voucher No],[Description],[Branch ID],[Pending Invoice]) VALUES ('" + DtpReturnedDate.Value + "','" + SaleReturnChartOfAccountID + "','" + TxtSaleReturnInvoiceNo.Text + "','Sale Return','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + NetPayable + "','00','Completed','" + TxtSaleReturnInvoiceNo.Text + "','Sale Return From " + CmbCustomerName.Text + "','" + FrmHome.lblBranchID.Text + "','" + pendingInvoiceNo + "')"
                cmd4.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart Of Account ID],[Invoice No],[Category Name],[User Account ID],[Computer ID],[Prepared Date] ,[Prepared Time],[Debited Amount],[Credited Amount],[Status],[Voucher No],[Description],[Branch ID],[Pending Invoice]) VALUES ('" + DtpReturnedDate.Value + "','" + CmbCustomerName.ValueMember + "','" + TxtSaleReturnInvoiceNo.Text + "','Sale Return','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','00','" + NetPayable + "','Completed','" + TxtSaleReturnInvoiceNo.Text + "','Sale Return','" + FrmHome.lblBranchID.Text + "','" + pendingInvoiceNo + "')"
                cmd1.ExecuteNonQuery()
                cmd4.ExecuteNonQuery()
                con1.Close()




            ElseIf dr.HasRows Then



                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd4.Connection = con1
                cmd1.CommandText = "Update [Ledger]  Set [Ledger Date]='" + DtpReturnedDate.Value + "',[Chart Of Account ID]='" + SaleReturnChartOfAccountID + "',[Invoice No]='" + TxtSaleReturnInvoiceNo.Text + "',[Category Name]='Sale Return',[User Account ID]='" + FrmHome.LblUserID.Text + "',[Computer ID]='" + FrmHome.LblComputerID.Text + "',[Prepared Time]='" + currentTime + "',[Debited Amount]='" + NetPayable + "',[Credited Amount]='00',[Description]= 'Sale Return From " + SaleReturnChartOfAccountID + "' Where [Chart Of Account ID]='" + SaleReturnChartOfAccountID + "' And [Invoice No]='" + TxtSaleReturnInvoiceNo.Text + "' And [Category Name]='Sale Return'"
                cmd4.CommandText = "Update [Ledger] Set  [Ledger Date]='" + DtpReturnedDate.Value + "',[Chart Of Account ID]='" + CmbCustomerName.ValueMember + "',[Invoice No]='" + TxtSaleReturnInvoiceNo.Text + "',[Category Name]='Sale Return',[User Account ID]='" + FrmHome.LblUserID.Text + "',[Computer ID]='" + FrmHome.LblComputerID.Text + "',[Prepared Time]='" + currentTime + "',[Debited Amount]='00',[Credited Amount]='" + NetPayable + "',[Description]= 'Sale Return' Where [Chart Of Account ID]='" + CmbCustomerName.ValueMember + "' And [Invoice No]='" + TxtSaleReturnInvoiceNo.Text + "' And [Category Name]='Sale Return'"

                cmd1.ExecuteNonQuery()
                cmd4.ExecuteNonQuery()



                con1.Close()




            End If

            dr.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records to Customer ledger")
        Finally

        End Try

    End Sub
    'Update or insert  ledger For Cash Paid For Sale Return
    Sub InsertorUpdateLedgerForCashPaidForSaleReturn()



        Try

            Dim con As New SqlConnection
            Dim con1 As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand
            Dim cmd2 As New SqlCommand
            Dim cmd4 As New SqlCommand
            ' Dim cmd5 As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now
            Dim dr As SqlDataReader








            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd2.Connection = con
            cmd.CommandText = "SELECT  *FROM [Ledger]  WHERE  [Category Name]='Cash Sale Return' And [Invoice No] = '" + TxtSaleReturnInvoiceNo.Text + "'"

            dr = cmd.ExecuteReader()
            dr.Read()




            If Not dr.HasRows Then

                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd4.Connection = con1
                cmd1.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart Of Account ID],[Invoice No],[Category Name],[User Account ID],[Computer ID],[Prepared Date] ,[Prepared Time],[Debited Amount],[Credited Amount],[Status],[Voucher No],[Description],[Branch ID],[Pending Invoice]) VALUES ('" + DtpReturnedDate.Value + "','" + CmbCustomerName.ValueMember + "','" + TxtSaleReturnInvoiceNo.Text + "','Cash Sale Return','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + TxtPaidAmount.Text + "','00','CASH','" + TxtSaleReturnInvoiceNo.Text + "','Paid By " + cmbPaidBy.Text + "','" + FrmHome.lblBranchID.Text + "','" + pendingInvoiceNo + "')"
                cmd4.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart Of Account ID],[Invoice No],[Category Name],[User Account ID],[Computer ID],[Prepared Date] ,[Prepared Time],[Debited Amount],[Credited Amount],[Status],[Voucher No],[Description],[Branch ID],[Pending Invoice]) VALUES ('" + DtpReturnedDate.Value + "','" + cmbPaidBy.SelectedValue.ToString + "','" + TxtSaleReturnInvoiceNo.Text + "','Cash Sale Return','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','00','" + TxtPaidAmount.Text + "','CASH','" + TxtSaleReturnInvoiceNo.Text + "','Paid To " + CmbCustomerName.Text + "','" + FrmHome.lblBranchID.Text + "','" + pendingInvoiceNo + "'  )"
                cmd1.ExecuteNonQuery()
                cmd4.ExecuteNonQuery()
                con1.Close()




            ElseIf dr.HasRows Then



                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd4.Connection = con1
                cmd1.CommandText = "Update [Ledger] Set [Ledger Date]='" + DtpReturnedDate.Value + "',[Chart Of Account ID]='" + CmbCustomerName.ValueMember + "',[Invoice No]='" + TxtSaleReturnInvoiceNo.Text + "',[Category Name]='Cash Sale Return',[User Account ID]='" + FrmHome.LblUserID.Text + "',[Computer ID]='" + FrmHome.LblComputerID.Text + "' ,[Prepared Time]='" + currentTime + "',[Debited Amount]='" + TxtPaidAmount.Text + "',[Credited Amount]='00',[Description]='Paid By " + cmbPaidBy.Text + "'  Where [Chart Of Account ID]='" + CmbCustomerName.ValueMember + "' And [Invoice No]='" + TxtSaleReturnInvoiceNo.Text + "' And [Category Name]='Cash Sale Return'"
                cmd4.CommandText = "Update [Ledger] Set [Ledger Date]='" + DtpReturnedDate.Value + "',[Chart Of Account ID]='" + cmbPaidBy.SelectedValue.ToString + "',[Invoice No]='" + TxtSaleReturnInvoiceNo.Text + "',[Category Name]='Cash Sale Return',[User Account ID]='" + FrmHome.LblUserID.Text + "',[Computer ID]='" + FrmHome.LblComputerID.Text + "' ,[Prepared Time]='" + currentTime + "',[Debited Amount]='00',[Credited Amount]='" + TxtPaidAmount.Text + "',[Description]='Paid To " + CmbCustomerName.Text + "' Where [Chart Of Account ID]='" + PreviousPaidbyID + "' And [Invoice No]='" + TxtSaleReturnInvoiceNo.Text + "' And [Category Name]='Cash Sale Return'"

                cmd1.ExecuteNonQuery()
                cmd4.ExecuteNonQuery()



                con1.Close()




            End If

            dr.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records to Customer ledger")
        Finally

        End Try
    End Sub


    'Delete invoice from ledger
    Sub DeleteinvoiceLedger()


        Try


            Dim con As New SqlConnection
            Dim con1 As New SqlConnection
            Dim cmd As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now


            Dim cmd2 As New SqlCommand
            Dim dr As SqlDataReader

            Dim cmd3 As New SqlCommand
            Dim dr3 As SqlDataReader



            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd2.Connection = con
            cmd3.Connection = con
            cmd2.CommandText = "SELECT  *FROM [Ledger]  WHERE [Invoice No] = '" + TxtSaleReturnInvoiceNo.Text + "' And [Category Name]='Sale Return' "
            cmd3.CommandText = "SELECT  *FROM [Ledger]  WHERE [Invoice No] = '" + TxtSaleReturnInvoiceNo.Text + "' And [Category Name]='Cash Sale Return' "


            dr3 = cmd3.ExecuteReader()
            dr3.Read()


            If dr3.HasRows Then



                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd.Connection = con1
                cmd.CommandText = "Delete from [Ledger] where [Invoice No]= '" + TxtSaleReturnInvoiceNo.Text + "' And [Category Name]='Cash Sale Return'"
                cmd.ExecuteNonQuery()
                con1.Close()

            End If
            dr3.Close()




            dr = cmd2.ExecuteReader()
            dr.Read()


            If dr.HasRows Then



                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd.Connection = con1
                cmd.CommandText = "Delete from [Ledger] where [Invoice No]= '" + TxtSaleReturnInvoiceNo.Text + "' And [Category Name]='Sale Return'"
                cmd.ExecuteNonQuery()
                con1.Close()

            End If


            dr.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Records to Customer ladger")
        Finally

        End Try


    End Sub
    'Update Sale Return Invoice As Complete
    Sub UpdateSaleReturnInvoiceToComplete()
        Try



            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Update [Sale Return Invoice] Set [Status]='COMPLETE',[Return Date]='" + DtpReturnedDate.Value + "',[Total]='" + TxtTotal.Text + "',[Discount Percentage]='" + TxtDiscountPercentage.Text + "',[Discount]='" + TxtDiscount.Text + "',[Net Payable]='" + TxtNetPayable.Text + "',[Paid Amount]='" + TxtPaidAmount.Text + "',[Paid By]='" + cmbPaidBy.SelectedValue.ToString + "' Where [Sale Return Invoice No]='" + TxtSaleReturnInvoiceNo.Text + "'"
            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Insert And Update Into Sale Return Serial No And Purchase Serial No
    Sub InsertAndUpdateIntoSaleReturnSerialNoAndPurchaseSerialNo()

        Try

            'Data Insert Code




            Dim con3 As New SqlConnection
            Dim cmd3 As New SqlCommand
            Dim dr3 As SqlDataReader

            con3.ConnectionString = FrmHome.ConnectionString
            con3.Open()
            cmd3.Connection = con3
            cmd3.CommandText = "SELECT *from [Sale Serial Number] where [Product ID]= '" + ProductIDForSearchSaleSerialNumber + "' And [Sale Serial Number]='" + CmbSerialNumber.Text + "' And [Status]='Sold' And [Sale Invoice No]='" + SaleInvoiceNumber + "' "

            dr3 = cmd3.ExecuteReader()
            dr3.Read()

            If dr3.HasRows Then

                'Insert Into Sale Return Invoice Number
                InsertIntoSaleReturnInvoice()

                'Same Serial Twice Insert Restriction Code
                SameSerialTwiceInsertRestrictionCode()

                'Refresh data after insert
                RefreshSaleReturnSerialNumber()

                'Count row after adding serial number
                TxtReturnedQuantity.Text = GrdSaleReturnSerialNumber.RowCount

                'Insert Or Update Into Sale Return For More Then One Quantity
                InsertOrUpdateIntoSaleReturnForMoreThenOneQuantity()


                'Refresh sale return
                RefreshSaleReturn()

                'Clear serial number tex box
                CmbSerialNumber.Text = ""

            Else

                MsgBox("No Available Serial Number", MsgBoxStyle.OkOnly, "Sale")

            End If

            dr3.Close()
            con3.Close()

        Catch ex As Exception
            MessageBox.Show("Error while insert and updating record on table..." & ex.Message, "Insert And Update Into Sale Serial No And Purchase Serial No Sub")

        End Try

    End Sub
    'Same Serial Twice Insert Restriction Code
    Sub SameSerialTwiceInsertRestrictionCode()

        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd2 As New SqlCommand

            Dim con3 As New SqlConnection
            Dim cmd3 As New SqlCommand
            Dim dr3 As SqlDataReader

            con3.ConnectionString = FrmHome.ConnectionString
            con3.Open()
            cmd3.Connection = con3
            cmd3.CommandText = "SELECT *from [Sale Return Serial] where [Product ID]= '" + ProductIDForSearchSaleSerialNumber + "' And [Sale Return Serial Number]='" + CmbSerialNumber.Text + "' And [Status]='Return' "

            dr3 = cmd3.ExecuteReader()
            dr3.Read()

            If Not dr3.HasRows Then

                'Update And Insert Into Purchase And Sale Serial Number
                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd2.Connection = con
                cmd.CommandText = "INSERT INTO [Sale Return Serial] ([Product ID],[Sale Return Invoice No],[Sale Return Serial Number],[Status]) values ('" + ProductIDForSearchSaleSerialNumber + "','" + TxtSaleReturnInvoiceNo.Text + "','" + CmbSerialNumber.Text + "','Return')"
                cmd2.CommandText = "Update [Purchase Serial Number] set [Status]='Available' where [Product ID]= '" + ProductIDForSearchSaleSerialNumber + "' And [Purchase Serial Number]= '" + CmbSerialNumber.Text + "'"

                cmd.ExecuteNonQuery()
                cmd2.ExecuteNonQuery()
                con.Close()
            Else

                MsgBox("Alrady Exixts.", MsgBoxStyle.OkOnly, "Sale Return")
            End If
            dr3.Close()
            con3.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    'Insert Or Update Into Sale Return For More Then One Quantity
    Sub InsertOrUpdateIntoSaleReturnForMoreThenOneQuantity()
        Try



            'Insert into sale return and return serial number
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand


            Dim con3 As New SqlConnection
            Dim cmd3 As New SqlCommand
            Dim dr3 As SqlDataReader

            con3.ConnectionString = FrmHome.ConnectionString
            con3.Open()
            cmd3.Connection = con3
            cmd3.CommandText = "SELECT *from [Sale Return] where [Purchase ID]= '" + PurchaseID + "' And [Sale Return Invoice No]='" + TxtSaleReturnInvoiceNo.Text + "' "

            dr3 = cmd3.ExecuteReader()
            dr3.Read()

            If Not dr3.HasRows Then

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "INSERT INTO [Sale Return] ([Returned Quantity],[Branch ID],[Purchase ID],[Sale Return Invoice No],[Product ID]) VALUES ('" + TxtReturnedQuantity.Text + "','" + FrmHome.lblBranchID.Text + "','" + PurchaseID + "','" + TxtSaleReturnInvoiceNo.Text + "','" + ProductIDForSearchSaleSerialNumber + "' )"
                cmd.ExecuteNonQuery()
                con.Close()

            ElseIf dr3.HasRows Then

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = " Update [Sale Return] Set [Returned Quantity]='" + TxtReturnedQuantity.Text + "' Where  [Purchase ID]= '" + PurchaseID + "' And [Sale Return Invoice No]='" + TxtSaleReturnInvoiceNo.Text + "' "
                cmd.ExecuteNonQuery()
                con.Close()

            End If

            dr3.Close()
            con3.Close()

            'Making Clear Sale Return
            ClearDataSaleReturn()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    'Insert And Update Into Sale Serial Number And Purchase Serial Number
    Sub InsertAndUpdateIntoSaleReturnSerialNumberAndPurchaseSerialNumber()
        Try
            'Data Insert Code
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand

            Dim total As String = 0

            For i As Integer = 0 To GrdSaleSerialNumber.RowCount - 1
                total += GrdSaleSerialNumber.Rows(i).Cells(0).Value

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd1.Connection = con
                cmd.CommandText = "INSERT INTO [Sale Return Serial] ([Product ID],[Sale Return Invoice No],[Sale Return Serial Number],[Status]) VALUES ('" + ProductIDForSearchSaleSerialNumber + "','" + TxtSaleReturnInvoiceNo.Text + "','" + GrdSaleSerialNumber.Rows(i).Cells(0).Value.ToString + "','Return' )"
                cmd1.CommandText = "Update [Purchase Serial Number] set [Status]='Available' where [Product ID]= '" + ProductIDForSearchSaleSerialNumber + "' And [Purchase Serial Number]= '" + GrdSaleSerialNumber.Rows(i).Cells(0).Value.ToString + "'"
                cmd.ExecuteNonQuery()
                cmd1.ExecuteNonQuery()
                con.Close()

            Next


        Catch ex As Exception
            MessageBox.Show("Error while Marking record on table..." & ex.Message, "Update And Insert Into Purchase And SaleSerial Number")
        Finally

        End Try
    End Sub

    'Search Sale Return Serial Number
    Sub RefreshSaleReturnSerialNumber()

        Try



            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Sale Return Serial Number] From  [Sale Return Serial]  where [Sale Return Invoice No]  = '" + TxtSaleReturnInvoiceNo.Text + "'  And [Product ID]='" + ProductIDForSearchReturnSerialNumber + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Sale Return Serial Number")
            connection.Close()
            GrdSaleReturnSerialNumber.DataSource = ds
            GrdSaleReturnSerialNumber.DataMember = "BizPro_Sale Return Serial Number"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdSaleReturnSerialNumber.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Search Sale Return Serial Number For Delete Invoice
    Sub RefreshSaleReturnSerialNumberForDeleteInvoice()

        Try



            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Product ID],[Sale Return Serial Number] From  [Sale Return Serial]  where [Sale Return Invoice No]  = '" + TxtSaleReturnInvoiceNo.Text + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Sale Return Serial Number")
            connection.Close()
            GrdSaleReturnSerialNumber.DataSource = ds
            GrdSaleReturnSerialNumber.DataMember = "BizPro_Sale Return Serial Number"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdSaleReturnSerialNumber.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand


            Dim total As String = 0

            For i As Integer = 0 To GrdSaleReturnSerialNumber.RowCount - 1
                total += GrdSaleReturnSerialNumber.Rows(i).Cells(0).Value & GrdSaleReturnSerialNumber.Rows(i).Cells(1).Value


                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd1.Connection = con
                cmd.CommandText = "Update [Purchase Serial Number] set [Status]='Sold' where [Product ID]= '" + GrdSaleReturnSerialNumber.Rows(i).Cells(0).Value.ToString + "' And [Purchase Serial Number]= '" + GrdSaleReturnSerialNumber.Rows(i).Cells(1).Value.ToString + "'"
                cmd1.CommandText = " Delete from [Sale Return Serial]  where [Sale Return Invoice No]  = '" + TxtSaleReturnInvoiceNo.Text + "'  "

                cmd.ExecuteNonQuery()
                cmd1.ExecuteNonQuery()

                con.Close()


            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Load Combobox for Payment method
    Sub LoadComboBoxPaymentMethod()
        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            con.ConnectionString = FrmHome.ConnectionString

            Dim strSQL As String = "Select [Chart of Account].[Chart of Account ID],[Chart of Account].[Account Name] from  [Chart of Account] join [Head Of Account]  on [Chart of Account].[Head of Account ID]=[Head Of Account].[Head of Account ID] where [Head of Account].[Account Name]='CASH AND BANK'"
            Dim da As New System.Data.SqlClient.SqlDataAdapter(strSQL, con)
            Dim ds As New DataSet
            da.Fill(ds, "[Hade Of Account]")

            With Me.cmbPaidBy
                .DataSource = ds.Tables("[Hade Of Account]")
                .ValueMember = "Chart of Account ID"
                .DisplayMember = "Account Name"
            End With
            con.Close()

            cmbPaidBy.Text = "DUE"


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Insert Into Sale Return Invoice code
    Sub InsertIntoSaleReturnInvoice()


        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim con2 As New SqlConnection
            Dim cmd2 As New SqlCommand
            Dim dr1 As SqlDataReader

            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now



            If TxtSaleReturnInvoiceNo.Text = "" Then

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "INSERT INTO [Sale Return Invoice] ([Sale Invoice No],[Return Date],[Prepared Date],[Prepared Time],[Computer ID],[User Account ID],[Customer ID],[Status],[Total],[Discount Percentage],[Discount],[Net Payable],[Paid Amount],[Paid By]) values ('" + SaleInvoiceNumber + "','" + DtpReturnedDate.Value + "','" + currentDate + "','" + currentTime + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + CustomerID + "','INCOMPLETE','" + TxtTotal.Text + "','" + TxtDiscountPercentage.Text + "','" + TxtDiscount.Text + "','" + TxtNetPayable.Text + "','" + TxtPaidAmount.Text + "','" + cmbPaidBy.SelectedValue.ToString + "')"
                cmd.ExecuteNonQuery()
                con.Close()


                con2.ConnectionString = FrmHome.ConnectionString
                con2.Open()
                cmd2.Connection = con2
                cmd2.CommandText = "SELECT top 1 [Sale Return Invoice No] FROM [Sale Return Invoice] where [User Account ID]= '" + FrmHome.LblUserID.Text + "' And [Computer ID]='" + FrmHome.LblComputerID.Text + "'   order by [Sale Return Invoice No] desc"

                dr1 = cmd2.ExecuteReader()
                dr1.Read()
                If dr1.HasRows Then


                    TxtSaleReturnInvoiceNo.Text = (dr1.Item("Sale Return Invoice No").ToString)
                End If

                con2.Close()
                dr1.Close()


            ElseIf Not TxtSaleReturnInvoiceNo.Text = "" Then

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "Update [Sale Return Invoice] Set [Status]='INCOMPLETE',[Total]='" + TxtTotal.Text + "',[Discount Percentage]='" + TxtDiscountPercentage.Text + "',[Discount]='" + TxtDiscount.Text + "',[Net Payable]='" + TxtNetPayable.Text + "',[Paid Amount]='" + TxtPaidAmount.Text + "',[Paid By]='" + cmbPaidBy.SelectedValue.ToString + "' Where [Sale Return Invoice No]='" + TxtSaleReturnInvoiceNo.Text + "'"
                cmd.ExecuteNonQuery()
                con.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Error while Inserting to sale invoice record on table..." & ex.Message, "Insert Records Sale Invoice")
        Finally

        End Try



    End Sub
    Sub RefreshSaleReturn()

        ' Load Data
        Try

             

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Sale Return].[Sale Return ID],[Products].[Product Name],[Sale Return].[Returned Quantity],([Sale Return].[Returned Quantity]* Sale.[Sale Unit Price])[Total Amount] from [sale Return] join Sale on [Sale Return].[Purchase ID]=Sale.[Purchase ID]  join Products on Sale.[Product ID]=Products.[Product ID] Where [Sale Return].[Sale Return Invoice No]='" + TxtSaleReturnInvoiceNo.Text + "' And Sale.[Sale Invoice No]='" + SaleInvoiceNumber + "' Order by [Sale Return].[Sale Return ID] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Sale Return")
            connection.Close()
            GrdSaleReturn.DataSource = ds
            GrdSaleReturn.DataMember = "BizPro_Sale Return"

            'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)


            GrdSaleReturn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


            'Count Total Amount
            TotalAmount()

            'Net Payable Calculate
            NetPayable()


        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try

        'End Refresh Data

    End Sub

    'Search Sale Return Invoice
    Sub SearchSaleReturnInvoice()

        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader


            'Data reader for Product Id
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT * from [Sale Return Invoice] join  [User Account] on [Sale Return Invoice].[User Account ID]=[User Account].[User Account ID]join [Customer Information] on [Sale Return Invoice].[Customer ID]=[Customer Information].[Customer ID] WHERE [Sale Return Invoice].[Sale Return Invoice No] =  '" + TxtSaleReturnInvoiceNo.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()
            If dr.HasRows Then



                TxtTotal.Text = (dr.Item("Total").ToString)
                TxtDiscountPercentage.Text = (dr.Item("Discount Percentage").ToString)
                TxtDiscount.Text = (dr.Item("Discount").ToString)
                cmbPaidBy.SelectedValue = (dr.Item("Paid By").ToString)
                TxtPaidAmount.Text = (dr.Item("Paid Amount").ToString)
                TxtNetPayable.Text = (dr.Item("Net Payable").ToString)
                TxtSearch.Text = (dr.Item("Sale Invoice No").ToString)
                SaleInvoiceNumber = (dr.Item("Sale Invoice No").ToString)

             

            End If
            dr.Close()
            con.Close()




        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Search Sale Return Invoice")
        Finally

        End Try


    End Sub
    'Count Totla amount and shoe in total textbox
    Sub TotalAmount()
        Try

            Dim total As String = 0
            For i As Integer = 0 To GrdSaleReturn.RowCount - 1
                total += GrdSaleReturn.Rows(i).Cells(3).Value
            Next
            Me.TxtTotal.Text = total


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Search Invoice Number And Product Details
    Sub SearchInvoiceNumberAndProductDetails()

        Try

            If CmbSearch.SelectedIndex = 1 Then
                'search by Invoice No

               
                Dim currentDate As DateTime = DateTime.Today

                Dim connectionString As String = FrmHome.ConnectionString
                Dim sql As String = "SELECT [Sale Invoice].[Sale Invoice No],[Branch Information].[Branch Name],[Customer Information].[Customer Name],[Sale Invoice].[Sale Date],[Sale Invoice].[Sale Time],[Sale Invoice].[Total] from [Sale Invoice] join sale on [Sale Invoice].[Sale Invoice No]=Sale.[Sale Invoice No] join [Branch Information] on Sale.[Branch ID]= [Branch Information].[Branch ID] join [User Account] on [Sale Invoice].[User Account ID]=[User Account].[User Account ID]join [Customer Information] on [Sale Invoice].[Customer ID]=[Customer Information].[Customer ID]   where [Sale Invoice].[Sale Invoice No] = '" + TxtSearch.Text + "'and [Sale Invoice].[Status]='Complete' group by [Sale Invoice].[Sale Invoice No],[Branch Information].[Branch Name],[Customer Information].[Customer Name],[Sale Invoice].[Sale Date],[Sale Invoice].[Sale Time],[Sale Invoice].[Total] order by [Sale Invoice].[Sale Date]  desc, [Sale Invoice].[Sale Time] desc"
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




                Dim connectionString1 As String = FrmHome.ConnectionString
                Dim sql1 As String = "SELECT [Sale].[Purchase ID],[Products].[Product Name],[Sale].[Sale Quantity],[Sale].[Sale Unit Price],[Sale].[Sale Amount] from [Sale] join [Products] on [sale].[product ID]=[products].[Product ID] join [sale Invoice] on Sale.[Sale Invoice No]= [Sale Invoice].[Sale Invoice No] where [sale].[sale Invoice No]= '" + TxtSearch.Text + "' and [Sale Invoice].[Status]='Complete' "
                Dim connection1 As New SqlConnection(connectionString1)
                Dim dataadapter1 As New SqlDataAdapter(sql1, connection1)
                Dim ds1 As New DataSet()
                connection1.Open()
                dataadapter1.Fill(ds1, "BizPro_Sale")
                connection1.Close()
                GrdSaleDetails.DataSource = ds1
                GrdSaleDetails.DataMember = "BizPro_Sale"

                'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)


                GrdSaleDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    'Privet sub for customer information
    Sub customerInformation()
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT * from [Customer Information] join [sale Invoice] on [Customer Information].[Customer ID]=[sale Invoice].[Customer ID] WHERE [sale Invoice].[Sale Invoice No] = '" + SaleInvoiceNumber + "'"


            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then


                Me.CmbCustomerName.Text = dr.Item("Customer Name").ToString
                Me.CmbCustomerName.ValueMember = dr.Item("Chart Of Account ID").ToString
                Me.TxtPhoneNo.Text = dr.Item("Mobile No").ToString
                Me.TxtAddress.Text = dr.Item("Address").ToString

                CustomerID = dr.Item("Customer ID").ToString
            End If

            dr.Close()
            con.Close()

        Catch ex As Exception

        End Try
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


                Me.CmbCustomerName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtPhoneNo.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtAddress.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtSearch.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtSaleReturnInvoiceNo.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.DtpReturnedDate.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.CmbSerialNumber.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtReturnedQuantity.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtTotal.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtDiscount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtDiscountPercentage.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtNetPayable.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtPaidAmount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.cmbPaidBy.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))


                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

                Me.GrdSaleInvoice.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdSaleInvoice.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)

                Me.GrdSaleDetails.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdSaleDetails.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)

                Me.GrdSaleSerialNumber.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdSaleSerialNumber.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)


                Me.GrdSaleReturn.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdSaleReturn.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)



                Me.GrdSaleReturnSerialNumber.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdSaleReturnSerialNumber.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)

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
    'Clear All Data
    Sub ClearAllData()

        CmbSearch.Text = ""
        TxtSearch.Text = ""
        TxtReturnedQuantity.Text = ""
        CmbSerialNumber.Text = ""

        GrdSaleReturnSerialNumber.Columns.Clear()
        GrdSaleReturn.Columns.Clear()
        GrdSaleDetails.Columns.Clear()
        GrdSaleInvoice.Columns.Clear()
        GrdSaleSerialNumber.Columns.Clear()

        TxtSaleReturnInvoiceNo.Text = ""

        LblSaleReturnID.Text = "00"
        DtpReturnedDate.Value = Now

        TxtTotal.Text = ""
        TxtDiscount.Text = ""
        TxtDiscountPercentage.Text = "00"
        TxtNetPayable.Text = ""
        TxtPaidAmount.Text = ""
        cmbPaidBy.Text = "DUE"

        CmbCustomerName.Text = ""
        CmbCustomerName.ValueMember = ""
        TxtPhoneNo.Text = ""
        TxtAddress.Text = ""


        GrpSaleReturn.Enabled = False
        SaleReturnEditStatus = False
    End Sub
    Sub ClearDataSaleReturn()

        CmbSerialNumber.Text = ""
        TxtReturnedQuantity.Text = ""
        LblSaleReturnID.Text = "00"

        'Calculate Netpayable
        NetPayable()

    End Sub

    'Clear Data For Search
    Sub ClearDataForSearch()


        'Clear Gridview and Textbox
        GrdSaleInvoice.Columns.Clear()
        GrdSaleDetails.Columns.Clear()
        GrdSaleSerialNumber.Columns.Clear()

        CmbCustomerName.Text = ""
        CmbCustomerName.ValueMember = ""
        TxtPhoneNo.Text = ""
        TxtAddress.Text = ""

        TxtSearch.Text = ""
        TxtSearch.Focus()

    End Sub





    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click

        'Set sale invoice number to variable
        SaleInvoiceNumber = Val(TxtSearch.Text)

        'Search Sale Invoice
        SearchSaleInvoice()

        'Search Invoice Number And Product Details
        SearchInvoiceNumberAndProductDetails()

        'Show Customer Information
        customerInformation()

        'For Search Sale Invoice Number
        If CmbSearch.SelectedIndex = 1 Then
            SaleInvoiceNumber = Val(TxtSearch.Text)
        End If

        GrdSaleSerialNumber.Columns.Clear()


    End Sub

    Private Sub TxtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then

            'For Search Sale Invoice Number
            If CmbSearch.SelectedIndex = 1 Then

                'Search Invoice Number And Product Details
                SearchInvoiceNumberAndProductDetails()

                SaleInvoiceNumber = Val(TxtSearch.Text)
                'Show Customer Information
                customerInformation()
            End If
        End If


    End Sub
    Private Sub CmbSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSearch.SelectedIndexChanged

        'Clear Data For Search
        ClearDataForSearch()



    End Sub

    Private Sub GrdSaleInvoice_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)


    End Sub


    Private Sub GrdSale_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)


    End Sub






    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click

        'Insert Into Sale Return Invoice Number
        InsertIntoSaleReturnInvoice()

        'Insert Or Update Into Sale Return For More Then One Quantity
        InsertOrUpdateIntoSaleReturnForMoreThenOneQuantity()

        'Refresh sale return
        RefreshSaleReturn()

    End Sub



    Private Sub GrdSaleReturn_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)


    End Sub

    Private Sub GrdSaleReturn_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

    End Sub
    Private Sub TxtReturnedQuantity_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtReturnedQuantity.KeyDown

        If e.KeyCode = Keys.Enter Then
            If TxtReturnedQuantity.Text = "" Or Val(TxtReturnedQuantity.Text) = 0 Then
                MsgBox("Insufficient Stock", MsgBoxStyle.OkOnly, "Sale")


            Else

                'Insert Into Sale Return Invoice Number
                InsertIntoSaleReturnInvoice()

                'Insert Or Update Into Sale Return For More Then One Quantity
                InsertOrUpdateIntoSaleReturnForMoreThenOneQuantity()

                'Refresh sale return
                RefreshSaleReturn()

                'Net Payable Calculate
                NetPayable()

                'Focus on Paid amount
                TxtPaidAmount.Focus()

            End If

        ElseIf e.KeyCode = Keys.Space AndAlso e.Control Then

            TxtPaidAmount.Focus()
            NetPayable()
            TxtPaidAmount.Text = TxtNetPayable.Text

        End If

    End Sub

    Private Sub TxtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearch.TextChanged

        'Search Sale Invoice
        SearchSaleInvoice()

        GrdSaleSerialNumber.Columns.Clear()



    End Sub

    Private Sub GrdSaleInvoice_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub FrmSaleReturn_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'If (MessageBox.Show(" Do you really want to Close?", "Sale Return", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No) Then
        'e.Cancel = True

        'End If

        If Not TxtSaleReturnInvoiceNo.Text = "" And Not SaleReturnEditStatus = True Then

            Dim q As MsgBoxResult = MsgBox("Do you want to keep this Invoice as draft?", MsgBoxStyle.YesNoCancel, "Sale Return")

            If q = MsgBoxResult.No Then

                'Delete Full Invoice
                DeleteFullInvoice()
            ElseIf q = MsgBoxResult.Cancel Then
                e.Cancel = True
            End If
        ElseIf Not TxtSaleReturnInvoiceNo.Text = "" And SaleReturnEditStatus = True Then
            If (MessageBox.Show(" Do you really want to Close?", "Bizpro", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No) Then

                e.Cancel = True


            End If


        End If

    End Sub

    Private Sub FrmSaleReturn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
                BtnSave.Enabled = True

            ElseIf Not dr.HasRows Then
                BtnDelete.Enabled = False
                BtnSave.Enabled = True


            End If


            dr.Close()
            con.Close()


        Catch ex As Exception
            MessageBox.Show("Error while  permission delete to form..." & ex.Message, "Form Load")

        End Try

        'Load Combobox for Payment method
        LoadComboBoxPaymentMethod()


        'Clear all data
        ClearAllData()


    End Sub

    Private Sub GrdSaleDetails_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdSaleDetails_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

    End Sub


    Private Sub GrdSaleDetails_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)



    End Sub


    Private Sub GrdSaleReturn_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub CmbSerialNumber_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbSerialNumber.KeyDown
        If e.KeyCode = Keys.Enter Then


            If CmbSerialNumber.Text = "" Then

                TxtPaidAmount.Focus()

            Else

                'Insert And Update Into Sale Return Serial No And Purchase Serial No
                InsertAndUpdateIntoSaleReturnSerialNoAndPurchaseSerialNo()

            End If

        ElseIf e.KeyCode = Keys.Space AndAlso e.Control Then

            TxtPaidAmount.Focus()
            NetPayable()
            TxtPaidAmount.Text = TxtNetPayable.Text


        End If
    End Sub

    Private Sub CmbSerialNumber_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSerialNumber.SelectedIndexChanged

    End Sub


    Private Sub TxtReturnedQuantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtReturnedQuantity.TextChanged

    End Sub

    'Delete Full Invoice
    Sub DeleteFullInvoice()
        Try

            Dim con2 As New SqlConnection
            Dim cmd2 As New SqlCommand

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now

            con2.ConnectionString = FrmHome.ConnectionString
            con2.Open()
            cmd.Connection = con2
            cmd2.Connection = con2
            cmd2.CommandText = "Delete from [Sale Return Invoice] where [Sale Return Invoice No]= '" + TxtSaleReturnInvoiceNo.Text + "'"
            cmd.CommandText = "Delete from [Sale Return] where [Sale Return Invoice No]= '" + TxtSaleReturnInvoiceNo.Text + "'"

            cmd2.ExecuteNonQuery()
            cmd.ExecuteNonQuery()

            con2.Close()



            'Delete invoice from ledger
            DeleteinvoiceLedger()





            'Search Sale Return Serial Number For Delete Invoice
            RefreshSaleReturnSerialNumberForDeleteInvoice()



            'Clear all data
            ClearAllData()



            'Focus on Custome  name
            CmbSearch.Focus()


            'NewInvoice()


            'Refresh Data
            'RefreshData()






        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click


        Try




            If Not TxtSaleReturnInvoiceNo.Text = "" Then

                Dim q As MsgBoxResult
                q = MsgBox("Do you really want to Delete Invoice?", MsgBoxStyle.YesNo, "Sale Return")
                If q = MsgBoxResult.Yes Then

                    'Insert into log code For Delete
                    InsertIntoLogForDelete()

                    'Delete Full Invoice
                    DeleteFullInvoice()
                End If

            Else

                MsgBox("Please Insert Invoice Number First.", MsgBoxStyle.OkOnly, "Sale")

            End If



        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try

    End Sub

    'Insert into log code For Delete
    Sub InsertIntoLogForDelete()

        'Data Insert Code
        Dim con As New SqlConnection
        Dim con1 As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim dr As SqlDataReader
        Dim CurrentDate As DateTime = DateTime.Today
        Dim CurrentTime As DateTime = DateTime.Now

        Dim SaleReturnDetails As String
        Dim BillStatus As String
        Try
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd2.Connection = con
            cmd.CommandText = "Select SUBSTRING( ( SELECT   '-------'+  [Product Name],'  Returned Quantity : ',isnull(sum([Sale Return].[Returned Quantity]),0)     FROM [Sale Return] join products on [Sale Return].[Product ID]=products.[Product ID]  where [Sale Return Invoice No]='" + TxtSaleReturnInvoiceNo.Text + "'   group by [Product Name],[Sale Return].[Returned Quantity] FOR XML PATH('') ), 2 , 9999) As [Sale Return]"
            cmd2.CommandText = "Select [Status] From [Sale Return Invoice] Where [Sale Return Invoice No]='" + TxtSaleReturnInvoiceNo.Text + "'"

            'Data Reader For Find Sale Details
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                SaleReturnDetails = dr.Item("Sale Return").ToString

            End If
            dr.Close()

            'Data Reader For Find invoice Status
            dr = cmd2.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                BillStatus = dr.Item("Status").ToString

            End If
            dr.Close()
            con.Close()


            con1.ConnectionString = FrmHome.ConnectionString
            con1.Open()
            cmd1.Connection = con1
            cmd1.CommandText = "INSERT INTO [Log Details]  ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES('" + Me.Text + "','DELETE', 'Customer Name : " + CmbCustomerName.Text + " , Customer ID : " + CmbCustomerName.ValueMember + " , Return Details :( " + SaleReturnDetails + ") Bill Status : " + BillStatus + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtSaleReturnInvoiceNo.Text + "' )"
            cmd1.ExecuteNonQuery()
            con1.Close()



        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally


        End Try
    End Sub

    'Insert into log code For Save
    Sub InsertIntoLogForSave()

        'Data Insert Code
        Dim con As New SqlConnection
        Dim con1 As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim dr As SqlDataReader
        Dim CurrentDate As DateTime = DateTime.Today
        Dim CurrentTime As DateTime = DateTime.Now

        Dim SaleReturnDetails As String

        Try
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Select SUBSTRING( ( SELECT   '-------'+  [Product Name],'  Returned Quantity : ',isnull(sum([Sale Return].[Returned Quantity]),0)     FROM [Sale Return] join products on [Sale Return].[Product ID]=products.[Product ID]  where [Sale Return Invoice No]='" + TxtSaleReturnInvoiceNo.Text + "'   group by [Product Name],[Sale Return].[Returned Quantity] FOR XML PATH('') ), 2 , 9999) As [Sale Return]"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                SaleReturnDetails = dr.Item("Sale Return").ToString

            End If
            dr.Close()
            con.Close()


            con1.ConnectionString = FrmHome.ConnectionString
            con1.Open()
            cmd1.Connection = con1
            cmd1.CommandText = "INSERT INTO [Log Details]  ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES('" + Me.Text + "','INSERT', 'Customer Name : " + CmbCustomerName.Text + " , Customer ID : " + CmbCustomerName.ValueMember + " , Return Details :( " + SaleReturnDetails + ")','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtSaleReturnInvoiceNo.Text + "' )"
            cmd1.ExecuteNonQuery()
            con1.Close()



        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally


        End Try

    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        'Search Pendig Invoice No for adujust balance
        SearchPendingInvoice()

        TxtPaidAmount.Text = "00"
        cmbPaidBy.Text = "Due"

        If TxtPaidAmount.Text = "" Or cmbPaidBy.Text = "" Or Val(TxtPaidAmount.Text) < 0 Or Val(TxtPaidAmount.Text) > Val(TxtNetPayable.Text) Then
            MsgBox("Please Insert Valid Amount", MsgBoxStyle.Critical, "Sale Return")
            TxtPaidAmount.Focus()
        Else

            'Send Value to Sale Invoice Variable
            RptSaleReturnInvoice.SaleInvoiceNo = SaleInvoiceNumber
            RptSaleReturnInvoice.SaleReturnInvoiceNo = TxtSaleReturnInvoiceNo.Text



            Dim q As MsgBoxResult
            q = MsgBox("Do you really want to save invoice?", MsgBoxStyle.YesNo, "Sale Return")
            If q = MsgBoxResult.Yes Then

                'Insert into log code For Save
                InsertIntoLogForSave()


                'Update Sale Return Invoice As Complete
                UpdateSaleReturnInvoiceToComplete()


                If cmbPaidBy.Text = "DUE" Then
                    'Delete invoice from ledger
                    DeleteinvoiceLedger()

                    'Update or insert Customer ledger For dues
                    InsertorUpdateCustomerLedgerForDues()



                Else
                    'Update or insert Customer ledger For dues
                    InsertorUpdateCustomerLedgerForDues()

                    'Update or insert  ledger For Cash Sale
                    InsertorUpdateLedgerForCashPaidForSaleReturn()


                End If

                'Focus on search
                CmbSearch.Focus()


                'Open Invoice
                RptSaleReturnInvoice.ShowInvoice()
                RptSaleReturnInvoice.Show()


                'Clear All Data
                ClearAllData()



            End If
        End If
    End Sub
    Private Sub GrdSaleReturnSerialNumber_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdSaleSerialNumber_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdSaleSerialNumber_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)


    End Sub

    Private Sub GrdSaleReturnSerialNumber_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)


    End Sub

    Private Sub GrdSaleReturnSerialNumber_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub BtnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewInvoice.Click


        If Not TxtSaleReturnInvoiceNo.Text = "" And Not SaleReturnEditStatus = True Then

            Dim q As MsgBoxResult = MsgBox("Do you want to keep this Invoice as draft?", MsgBoxStyle.YesNoCancel, "Sale Return")

            If q = MsgBoxResult.No Then

                'Insert into log code For Delete
                InsertIntoLogForDelete()

                'Delete Full Invoice
                DeleteFullInvoice()

            ElseIf q = MsgBoxResult.Yes Then

                'Clear All Data
                ClearAllData()



                'Focus on search combobx
                CmbSearch.Focus()

            End If




        ElseIf Not TxtSaleReturnInvoiceNo.Text = "" And SaleReturnEditStatus = True Then

            If (MessageBox.Show(" Are you sure want to creat new invoice?", "Bizpro", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then


                'Clear All Data
                ClearAllData()



                'Focus on search combobx
                CmbSearch.Focus()


            End If
        ElseIf TxtSaleReturnInvoiceNo.Text = "" Then

            'Clear All Data
            ClearAllData()
        End If
    End Sub



    Private Sub TxtSaleReturnInvoiceNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSaleReturnInvoiceNo.TextChanged

    End Sub

    Private Sub GrpCustomerInformation_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrpCustomerInformation.Enter

    End Sub

    Private Sub GrdSaleInvoice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub GrpCustomerInformation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GrpCustomerInformation.KeyPress

    End Sub

    Private Sub CmbCustomerName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbCustomerName.KeyDown

    End Sub

    Private Sub CmbCustomerName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbCustomerName.KeyPress
        e.Handled = True
    End Sub

    Private Sub CmbCustomerName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCustomerName.SelectedIndexChanged

    End Sub

    Private Sub TxtDiscountPercentage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDiscountPercentage.TextChanged

        'Sub For discount and vat percentage
        TxtDiscount.Text = (Val(TxtTotal.Text) * Val(TxtDiscountPercentage.Text)) / 100


    End Sub

    Private Sub TxtNetPayable_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNetPayable.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtPaidAmount.Focus()
            TxtPaidAmount.Text = TxtNetPayable.Text

        End If
    End Sub

    Private Sub TxtNetPayable_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNetPayable.TextChanged

    End Sub

    Private Sub TxtDiscount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDiscount.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtNetPayable.Focus()

        End If
    End Sub

    Private Sub TxtDiscount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDiscount.TextChanged
        NetPayable()
    End Sub
    'Net Payable Calculate
    Sub NetPayable()
        TxtNetPayable.Text = (Val(TxtTotal.Text) - Val(TxtDiscount.Text))
    End Sub

    Private Sub TxtPaidAmount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPaidAmount.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Val(TxtPaidAmount.Text) <= 0 Then
                cmbPaidBy.Text = "DUE"
                cmbPaidBy.Focus()
            ElseIf Val(TxtPaidAmount.Text) > 0 Then


                cmbPaidBy.Focus()
            End If
        End If
    End Sub

    Private Sub TxtPaidAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPaidAmount.TextChanged

    End Sub

    Private Sub cmbPaidBy_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbPaidBy.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnSave.PerformClick()

        End If
    End Sub

    Private Sub cmbPaidBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPaidBy.SelectedIndexChanged
        If cmbPaidBy.Text = "DUE" Then
            TxtPaidAmount.Text = "00"
        End If
    End Sub

    Private Sub BtnHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHistory.Click

        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader


            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + FrmHome.LblUserID.Text + "' AND [Category Name] = 'Sale Return History'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                FrmSaleReturnHistory.Show()
                FrmSaleReturnHistory.TxtSearchSaleReturnInvoice.Focus()
            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Permission for SaleReturnHistory")
        End Try




      
    End Sub

    Private Sub BtnInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInvoice.Click
        'Send Value to Sale Invoice Variable
        RptSaleReturnInvoice.SaleInvoiceNo = SaleInvoiceNumber
        RptSaleReturnInvoice.SaleReturnInvoiceNo = TxtSaleReturnInvoiceNo.Text

        'Open Invoice
        RptSaleReturnInvoice.ShowInvoice()
        RptSaleReturnInvoice.Show()
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

    Private Sub GrdSaleInvoice_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdSaleInvoice.CellContentClick

    End Sub

    Private Sub GrdSaleInvoice_CellMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdSaleInvoice.CellMouseClick

        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdSaleInvoice.Rows(e.RowIndex)

                If TxtSaleReturnInvoiceNo.Text = "" Then
                    ' Load Data

                    Dim connectionString As String = FrmHome.ConnectionString
                    Dim sql As String = "SELECT [Sale].[Purchase ID],[Products].[Product Name],[Sale].[Sale Quantity],[Sale].[Sale Unit Price],[Sale].[Sale Amount] from [Sale] join [Products] on [sale].[product ID]=[products].[Product ID] where [sale].[sale Invoice No]= '" + row.Cells("Sale Invoice No").Value.ToString + "'"
                    Dim connection As New SqlConnection(connectionString)
                    Dim dataadapter As New SqlDataAdapter(sql, connection)
                    Dim ds As New DataSet()
                    connection.Open()
                    dataadapter.Fill(ds, "BizPro_Sale")
                    connection.Close()
                    GrdSaleDetails.DataSource = ds
                    GrdSaleDetails.DataMember = "BizPro_Sale"

                    'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                    'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
                    GrdSaleDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


                    'Send SaleInvoice Number to variable
                    SaleInvoiceNumber = row.Cells("Sale Invoice No").Value.ToString

                    'Show Customer Information
                    customerInformation()

                    'Clear Gridview
                    GrdSaleSerialNumber.Columns.Clear()
                Else
                    MsgBox("Please complete this invoice", MsgBoxStyle.OkOnly, "Sale Return")
                End If

            End If
        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try

    End Sub

    Private Sub GrdSaleInvoice_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdSaleInvoice.CellMouseDoubleClick
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdSaleInvoice.Rows(e.RowIndex)

                'TxtPurchaseID.Text = row.Cells("Purchase ID").Value.ToString

            End If

            'Text Box Return Quantity Focus
            TxtReturnedQuantity.Focus()


        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Grid view")

        End Try
    End Sub

    Private Sub GrdSaleDetails_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdSaleDetails.CellContentClick

    End Sub

    Private Sub GrdSaleDetails_CellMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdSaleDetails.CellMouseClick


        Try


            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdSaleDetails.Rows(e.RowIndex)





                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim dr As SqlDataReader

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "SELECT  *FROM [Purchase]  WHERE [Purchase ID] = '" + row.Cells("Purchase ID").Value.ToString + "'"


                dr = cmd.ExecuteReader()
                dr.Read()

                If dr.HasRows Then


                    ProductIDForSearchSaleSerialNumber = dr.Item("Product ID").ToString
                    ProductIDForSearchReturnSerialNumber = dr.Item("Product ID").ToString
                    PurchaseID = dr.Item("Purchase ID").ToString

                End If

                dr.Close()
                con.Close()




                'Search Sale Serial Number
                Dim connectionString As String = FrmHome.ConnectionString
                Dim sql As String = "SELECT [Sale Serial Number] From  [Sale Serial Number]  where [Sale Invoice No]  = '" + SaleInvoiceNumber + "'  And [Product ID]='" + ProductIDForSearchSaleSerialNumber + "'"
                Dim connection As New SqlConnection(connectionString)
                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Sale Serial Number")
                connection.Close()
                GrdSaleSerialNumber.DataSource = ds
                GrdSaleSerialNumber.DataMember = "BizPro_Sale Serial Number"

                'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
                GrdSaleSerialNumber.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill






            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub GrdSaleDetails_CellMouseDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdSaleDetails.CellMouseDoubleClick


        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow

                row = Me.GrdSaleDetails.Rows(e.RowIndex)

                If row.Cells("Sale Quantity").Value = 1 Then


                    'Insert Sale Return Invoice 
                    InsertIntoSaleReturnInvoice()

                    Dim con3 As New SqlConnection
                    Dim cmd3 As New SqlCommand
                    Dim dr3 As SqlDataReader

                    con3.ConnectionString = FrmHome.ConnectionString
                    con3.Open()
                    cmd3.Connection = con3
                    cmd3.CommandText = "SELECT *from [Sale Return] where [Purchase ID]= '" + row.Cells("Purchase ID").Value.ToString + "' And [Sale Return Invoice No]='" + TxtSaleReturnInvoiceNo.Text + "' "

                    dr3 = cmd3.ExecuteReader()
                    dr3.Read()

                    If Not dr3.HasRows Then

                        'Insert into sale return and return serial number
                        Dim con As New SqlConnection
                        Dim cmd As New SqlCommand

                        con.ConnectionString = FrmHome.ConnectionString
                        con.Open()
                        cmd.Connection = con
                        cmd.CommandText = " INSERT INTO [Sale Return] ([Returned Quantity],[Branch ID],[Purchase ID],[Sale Return Invoice No],[Product ID]) VALUES ('" + row.Cells("Sale Quantity").Value.ToString + "','" + FrmHome.lblBranchID.Text + "','" + row.Cells("Purchase ID").Value.ToString + "','" + TxtSaleReturnInvoiceNo.Text + "','" + ProductIDForSearchSaleSerialNumber + "' )"
                        cmd.ExecuteNonQuery()
                        con.Close()

                        'If There is single serial number then
                        If GrdSaleSerialNumber.RowCount = 1 Then
                            'Insert And Update Into Sale Serial Number And Purchase Serial Number
                            InsertAndUpdateIntoSaleReturnSerialNumberAndPurchaseSerialNumber()

                        End If
                        'Focus on Paid amount
                        TxtPaidAmount.Focus()
                    Else
                        MsgBox("Already Exists", MsgBoxStyle.OkOnly, "Sale Return")
                    End If
                    dr3.Close()
                    con3.Close()

                    'Refresh Sale Return
                    RefreshSaleReturn()

                    'Search Sale Return Serial Number
                    RefreshSaleReturnSerialNumber()

                Else

                    'Group Box Enable Making true
                    GrpSaleReturn.Enabled = True

                    If GrdSaleSerialNumber.RowCount > 1 Then

                        'Focus on serial number
                        CmbSerialNumber.Focus()
                    Else
                        'Focus on Return Quantity 
                        TxtReturnedQuantity.Focus()

                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdSaleSerialNumber.CellContentClick

    End Sub

    Private Sub GrdSaleSerialNumber_CellMouseDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdSaleSerialNumber.CellMouseDoubleClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.GrdSaleSerialNumber.Rows(e.RowIndex)

            GrpSaleReturn.Enabled = True
            CmbSerialNumber.Text = row.Cells("Sale Serial Number").Value.ToString

            'Insert And Update Into Sale Return Serial No And Purchase Serial No
            InsertAndUpdateIntoSaleReturnSerialNoAndPurchaseSerialNo()


            CmbSerialNumber.Focus()
        End If


    End Sub

    Private Sub GrdSaleReturn_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdSaleReturn.CellContentClick

    End Sub

    Private Sub GrdSaleReturn_CellMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdSaleReturn.CellMouseClick

        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdSaleReturn.Rows(e.RowIndex)


                TxtReturnedQuantity.Text = row.Cells("Returned Quantity").Value.ToString
                TxtReturnedQuantity.Focus()


                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim dr As SqlDataReader

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "SELECT *from [sale Return] join Purchase on [Sale Return].[Purchase ID]=Purchase.[Purchase ID] WHERE [sale Return ID]= '" + row.Cells("sale Return ID").Value.ToString + "'"

                dr = cmd.ExecuteReader()
                dr.Read()

                If dr.HasRows Then
                    ProductIDForSearchReturnSerialNumber = dr.Item("Product ID").ToString
                    PurchaseID = dr.Item("Purchase ID").ToString
                End If

                dr.Close()
                con.Close()



                LblSaleReturnID.Text = row.Cells("Sale Return ID").Value.ToString

                'Search Sale Return Serial Number
                RefreshSaleReturnSerialNumber()


            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Grid view")

        End Try
    End Sub

    Private Sub GrdSaleReturn_CellMouseDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdSaleReturn.CellMouseDoubleClick

        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdSaleReturn.Rows(e.RowIndex)

                'Data Delete Code
                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim cmd1 As New SqlCommand
                Dim cmd2 As New SqlCommand



                Dim q As MsgBoxResult
                q = MsgBox("Do you really want to Delete the row?", MsgBoxStyle.YesNo, "Sale Return")
                If q = MsgBoxResult.Yes Then



                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd1.Connection = con
                    cmd2.Connection = con
                    cmd.CommandText = " Delete from [Sale Return]  where [Sale Return ID]=  " + row.Cells("Sale Return ID").Value.ToString + " "
                    cmd1.CommandText = " Delete from [Sale Return Serial]  where [Sale Return Invoice No]  = '" + TxtSaleReturnInvoiceNo.Text + "'  And [Product ID]='" + ProductIDForSearchReturnSerialNumber + "'"

                    cmd.ExecuteNonQuery()
                    cmd1.ExecuteNonQuery()





                    Dim total As String = 0
                    For i As Integer = 0 To GrdSaleReturnSerialNumber.RowCount - 1
                        total += GrdSaleReturnSerialNumber.Rows(i).Cells(0).Value

                        cmd2.CommandText = "Update [Purchase Serial Number] set [Status]='Sold'  where [Product ID]= '" + ProductIDForSearchReturnSerialNumber + "' And [Purchase Serial Number]= '" + GrdSaleReturnSerialNumber.Rows(i).Cells(0).Value.ToString + "' "
                        cmd2.ExecuteNonQuery()

                    Next

                    con.Close()

                    'Refreshdata
                    RefreshSaleReturn()

                    'Search Sale Return Serial Number
                    RefreshSaleReturnSerialNumber()

                    'Clear Data Sale Return
                    ClearDataSaleReturn()

                    'Focus on Paid amount
                    TxtPaidAmount.Focus()





                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Grdview Cell Mouse Double Click")
        Finally

        End Try

    End Sub

    Private Sub GrdSaleReturnSerialNumber_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdSaleReturnSerialNumber.CellContentClick

    End Sub

    Private Sub GrdSaleReturnSerialNumber_CellMouseDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdSaleReturnSerialNumber.CellMouseDoubleClick

        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow
            row = Me.GrdSaleReturnSerialNumber.Rows(e.RowIndex)



            'Data Insert Code
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now
            Dim cmd2 As New SqlCommand





            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd2.Connection = con
            cmd.CommandText = "Update [Purchase Serial Number] set [Status]='Sold'  where [Product ID]= '" + ProductIDForSearchReturnSerialNumber + "' And [Purchase Serial Number]= '" + row.Cells("Sale Return Serial Number").Value.ToString + "' "
            cmd2.CommandText = "Delete from [Sale Return Serial] where [Product ID]= '" + ProductIDForSearchReturnSerialNumber + "' And [Sale Return Serial Number]= '" + row.Cells("Sale Return Serial Number").Value.ToString + "' And [Sale Return Invoice No] = '" + TxtSaleReturnInvoiceNo.Text + "' "

            cmd.ExecuteNonQuery()
            cmd2.ExecuteNonQuery()
            con.Close()

            'Refresh Sal Return Serial Number
            RefreshSaleReturnSerialNumber()

            'Count row after adding serial number
            TxtReturnedQuantity.Text = GrdSaleReturnSerialNumber.RowCount

            'Insert Or Update Into Sale Return For More Then One Quantity
            InsertOrUpdateIntoSaleReturnForMoreThenOneQuantity()

            'Refresh Sale Return
            RefreshSaleReturn()

            'Net Payable Calculate
            NetPayable()

            'Focus on Paid amount
            TxtPaidAmount.Focus()
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

    Private Sub GrpSearch_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrpSearch.Enter

    End Sub
End Class