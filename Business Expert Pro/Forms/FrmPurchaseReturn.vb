Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmPurchaseReturn



    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point

    Public ProductIDForSearchPurchaseSerialNumber As String
    Public PurchaseInvoiceNumber As String
    Public ProductIDForSearchReturnSerialNumber As String
    Public PurchaseID As String
    'Public CustomerChartofAccountID As String
    Public PreviousPaidbyID As String
    Public SupplierID As String

    Dim ShowInvoicePermission As String

    'Dim PurchaseIDForInsertIntoPurchaseSerialNumber As String
    Dim QuantityWritten As String
    Dim PendingInvoiceNo As String

    Public PurchaseReturnEditStatus As Boolean





    'Search Purchase Record
    Sub SearchPurchaseInvoice()

        ' Load Data
        Try
            'search by Customer Name
            If CmbSearch.SelectedIndex = 0 Then

               
                Dim currentDate As DateTime = DateTime.Today

                Dim connectionString As String = FrmHome.ConnectionString
                Dim sql As String = "SELECT [Purchase Invoice].[Purchase Invoice No],[Branch Information].[Branch Name],[Supplier Information].[Supplier Name],[Purchase Invoice].[Purchase Date],[Purchase Invoice].[Purchase Time],[Purchase Invoice].[Total] from [Purchase Invoice] join Purchase on [Purchase Invoice].[Purchase Invoice No]=Purchase.[Purchase Invoice No] join [Branch Information] on Purchase.[Branch ID]= [Branch Information].[Branch ID]  join [User Account] on [Purchase Invoice].[User Account ID]=[User Account].[User Account ID] join [supplier Information] on [Purchase Invoice].[supplier ID]=[supplier Information].[supplier ID] where [supplier Information].[supplier Name] Like '%" + TxtSearch.Text + "%' and [Purchase Invoice].[Status]='Complete'  Group by [Purchase Invoice].[Purchase Invoice No],[Branch Information].[Branch Name],[Supplier Information].[Supplier Name],[Purchase Invoice].[Purchase Date],[Purchase Invoice].[Purchase Time],[Purchase Invoice].[Total] order by [Purchase Invoice].[Purchase Date]  desc, [Purchase Invoice].[Purchase Time] desc"
                Dim connection As New SqlConnection(connectionString)
                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Purchase Invoice")
                connection.Close()
                GrdPurchaseInvoice.DataSource = ds
                GrdPurchaseInvoice.DataMember = "BizPro_Purchase Invoice"

                'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
                GrdPurchaseInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
               


            ElseIf CmbSearch.SelectedIndex = 2 Then

                'search by Mobile No
 
                Dim currentDate As DateTime = DateTime.Today

                Dim connectionString As String = FrmHome.ConnectionString
                Dim sql As String = "SELECT [Purchase Invoice].[Purchase Invoice No],[Branch Information].[Branch Name],[Supplier Information].[Supplier Name],[Purchase Invoice].[Purchase Date],[Purchase Invoice].[Purchase Time],[Purchase Invoice].[Total] from [Purchase Invoice] join Purchase on [Purchase Invoice].[Purchase Invoice No]=Purchase.[Purchase Invoice No] join [Branch Information] on Purchase.[Branch ID]= [Branch Information].[Branch ID]  join [User Account] on [Purchase Invoice].[User Account ID]=[User Account].[User Account ID] join [supplier Information] on [Purchase Invoice].[supplier ID]=[supplier Information].[supplier ID]  where [supplier Information].[Mobile No] Like '%" + TxtSearch.Text + "%' and [Purchase Invoice].[Status]='Complete'  Group by [Purchase Invoice].[Purchase Invoice No],[Branch Information].[Branch Name],[Supplier Information].[Supplier Name],[Purchase Invoice].[Purchase Date],[Purchase Invoice].[Purchase Time],[Purchase Invoice].[Total] order by [Purchase Invoice].[Purchase Date]  desc, [Purchase Invoice].[Purchase Time] desc"
                Dim connection As New SqlConnection(connectionString)
                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Purchase Invoice")
                connection.Close()
                GrdPurchaseInvoice.DataSource = ds
                GrdPurchaseInvoice.DataMember = "BizPro_Purchase Invoice"

                'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
                GrdPurchaseInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


            ElseIf CmbSearch.SelectedIndex = 3 Then

                'search by Product Name
                
                Dim currentDate As DateTime = DateTime.Today

                Dim connectionString As String = FrmHome.ConnectionString
                Dim sql As String = "SELECT [Purchase Invoice].[Purchase Invoice No],[Branch Information].[Branch Name],[Supplier Information].[Supplier Name],[Purchase Invoice].[Purchase Date],[Purchase Invoice].[Purchase Time],[Purchase Invoice].[Total] from [Purchase Invoice] join Purchase on [Purchase Invoice].[Purchase Invoice No]=Purchase.[Purchase Invoice No] join [Branch Information] on Purchase.[Branch ID]= [Branch Information].[Branch ID]  join [User Account] on [Purchase Invoice].[User Account ID]=[User Account].[User Account ID] join [supplier Information] on [Purchase Invoice].[supplier ID]=[supplier Information].[supplier ID]  join Products on Purchase.[Product ID]= products.[Product ID] where [products].[Product Name] Like '%" + TxtSearch.Text + "%' and [Purchase Invoice].[Status]='Complete'  Group by [Purchase Invoice].[Purchase Invoice No],[Branch Information].[Branch Name],[Supplier Information].[Supplier Name],[Purchase Invoice].[Purchase Date],[Purchase Invoice].[Purchase Time],[Purchase Invoice].[Total] order by [Purchase Invoice].[Purchase Date]  desc, [Purchase Invoice].[Purchase Time] desc"
                Dim connection As New SqlConnection(connectionString)
                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Purchase Invoice")
                connection.Close()
                GrdPurchaseInvoice.DataSource = ds
                GrdPurchaseInvoice.DataMember = "BizPro_Purchase Invoice"

                'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
                GrdPurchaseInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill





            End If

        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

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

            Dim PurchaseReturnChartOfAccountID As String
            Dim NetPayable As String

            NetPayable = (Val(TxtTotal.Text) - Val(TxtDiscount.Text))

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd3.Connection = con
            cmd3.CommandText = "SELECT  *FROM [Chart Of Account]  WHERE [Account Name] = 'Purchase Return'"

            dr3 = cmd3.ExecuteReader()
            dr3.Read()
            If dr3.HasRows Then
                PurchaseReturnChartOfAccountID = (dr3.Item("Chart Of Account ID").ToString)
            End If

            dr3.Close()


            cmd.CommandText = "SELECT  *FROM [Ledger]  WHERE  [Category Name]='Purchase Return' And [Invoice No] = '" + TxtPurchaseReturnInvoiceNo.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()




            If Not dr.HasRows Then

                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd4.Connection = con1
                cmd1.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart Of Account ID],[Invoice No],[Category Name],[User Account ID],[Computer ID],[Prepared Date] ,[Prepared Time],[Debited Amount],[Credited Amount],[Status],[Voucher No],[Description],[Branch ID],[Pending Invoice]) VALUES ('" + DtpReturnedDate.Value + "','" + CmbSupplierName.ValueMember + "','" + TxtPurchaseReturnInvoiceNo.Text + "','Purchase Return','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + NetPayable + "','00','Completed','" + TxtPurchaseReturnInvoiceNo.Text + "','Purchase Return','" + FrmHome.lblBranchID.Text + "','" + PendingInvoiceNo + "')"
                cmd4.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart Of Account ID],[Invoice No],[Category Name],[User Account ID],[Computer ID],[Prepared Date] ,[Prepared Time],[Debited Amount],[Credited Amount],[Status],[Voucher No],[Description],[Branch ID],[Pending Invoice]) VALUES ('" + DtpReturnedDate.Value + "','" + PurchaseReturnChartOfAccountID + "','" + TxtPurchaseReturnInvoiceNo.Text + "','Purchase Return','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','00','" + NetPayable + "','Completed','" + TxtPurchaseReturnInvoiceNo.Text + "','Purchase Return From " + CmbSupplierName.Text + "','" + FrmHome.lblBranchID.Text + "','" + PendingInvoiceNo + "')"
                cmd1.ExecuteNonQuery()
                cmd4.ExecuteNonQuery()
                con1.Close()




            ElseIf dr.HasRows Then



                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd4.Connection = con1
                cmd1.CommandText = "Update [Ledger]  Set [Ledger Date]='" + DtpReturnedDate.Value + "',[Chart Of Account ID]='" + CmbSupplierName.ValueMember + "',[Invoice No]='" + TxtPurchaseReturnInvoiceNo.Text + "',[Category Name]='Purchase Return',[User Account ID]='" + FrmHome.LblUserID.Text + "',[Computer ID]='" + FrmHome.LblComputerID.Text + "',[Prepared Time]='" + currentTime + "',[Debited Amount]='" + NetPayable + "',[Credited Amount]='00',[Description]= 'Purchase Return From " + PurchaseReturnChartOfAccountID + "' Where [Chart Of Account ID]='" + CmbSupplierName.ValueMember + "'  And [Invoice No]='" + TxtPurchaseReturnInvoiceNo.Text + "' And [Category Name]='Purchase Return'"
                cmd4.CommandText = "Update [Ledger] Set  [Ledger Date]='" + DtpReturnedDate.Value + "',[Chart Of Account ID]='" + PurchaseReturnChartOfAccountID + "',[Invoice No]='" + TxtPurchaseReturnInvoiceNo.Text + "',[Category Name]='Purchase Return',[User Account ID]='" + FrmHome.LblUserID.Text + "',[Computer ID]='" + FrmHome.LblComputerID.Text + "',[Prepared Time]='" + currentTime + "',[Debited Amount]='00',[Credited Amount]='" + NetPayable + "',[Description]= 'Purchase Return' Where [Chart Of Account ID]='" + PurchaseReturnChartOfAccountID + "'And [Invoice No]='" + TxtPurchaseReturnInvoiceNo.Text + "' And [Category Name]='Purchase Return'"

                cmd1.ExecuteNonQuery()
                cmd4.ExecuteNonQuery()



                con1.Close()




            End If

            dr.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records to Supplier ledger")
        Finally

        End Try

    End Sub
    'Update or insert  ledger For Cash Paid For Purchase Return
    Sub InsertorUpdateLedgerForCashPaidForPurchaseReturn()



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
            cmd.CommandText = "SELECT  *FROM [Ledger]  WHERE  [Category Name]='Cash Purchase Return' And [Invoice No] = '" + TxtPurchaseReturnInvoiceNo.Text + "'"

            dr = cmd.ExecuteReader()
            dr.Read()




            If Not dr.HasRows Then

                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd4.Connection = con1
                cmd1.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart Of Account ID],[Invoice No],[Category Name],[User Account ID],[Computer ID],[Prepared Date] ,[Prepared Time],[Debited Amount],[Credited Amount],[Status],[Voucher No],[Description],[Branch ID],[Pending Invoice]) VALUES ('" + DtpReturnedDate.Value + "','" + cmbPaidBy.SelectedValue.ToString + "','" + TxtPurchaseReturnInvoiceNo.Text + "','Cash Purchase Return','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + TxtPaidAmount.Text + "','00','CASH','" + TxtPurchaseReturnInvoiceNo.Text + "','Received From " + CmbSupplierName.Text + "','" + FrmHome.lblBranchID.Text + "','" + PendingInvoiceNo + "')"
                cmd4.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart Of Account ID],[Invoice No],[Category Name],[User Account ID],[Computer ID],[Prepared Date] ,[Prepared Time],[Debited Amount],[Credited Amount],[Status],[Voucher No],[Description],[Branch ID],[Pending Invoice]) VALUES ('" + DtpReturnedDate.Value + "','" + CmbSupplierName.ValueMember + "','" + TxtPurchaseReturnInvoiceNo.Text + "','Cash Purchase Return','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','00','" + TxtPaidAmount.Text + "','CASH','" + TxtPurchaseReturnInvoiceNo.Text + "','Received By " + cmbPaidBy.Text + "','" + FrmHome.lblBranchID.Text + "' ,'" + PendingInvoiceNo + "' )"
                cmd1.ExecuteNonQuery()
                cmd4.ExecuteNonQuery()
                con1.Close()




            ElseIf dr.HasRows Then



                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd4.Connection = con1
                cmd1.CommandText = "Update [Ledger] Set [Ledger Date]='" + DtpReturnedDate.Value + "',[Chart Of Account ID]='" + cmbPaidBy.SelectedValue.ToString + "',[Invoice No]='" + TxtPurchaseReturnInvoiceNo.Text + "',[Category Name]='Cash Purchase Return',[User Account ID]='" + FrmHome.LblUserID.Text + "',[Computer ID]='" + FrmHome.LblComputerID.Text + "' ,[Prepared Time]='" + currentTime + "',[Debited Amount]='" + TxtPaidAmount.Text + "',[Credited Amount]='00',[Description]= 'Received From " + CmbSupplierName.Text + "' Where [Chart Of Account ID]='" + PreviousPaidbyID + "' And [Invoice No]='" + TxtPurchaseReturnInvoiceNo.Text + "' And [Category Name]='Cash Purchase Return'"
                cmd4.CommandText = "Update [Ledger] Set [Ledger Date]='" + DtpReturnedDate.Value + "',[Chart Of Account ID]='" + CmbSupplierName.ValueMember + "',[Invoice No]='" + TxtPurchaseReturnInvoiceNo.Text + "',[Category Name]='Cash Purchase Return',[User Account ID]='" + FrmHome.LblUserID.Text + "',[Computer ID]='" + FrmHome.LblComputerID.Text + "' ,[Prepared Time]='" + currentTime + "',[Debited Amount]='00',[Credited Amount]='" + TxtPaidAmount.Text + "',[Description]='Received By " + cmbPaidBy.Text + "' Where [Chart Of Account ID]='" + CmbSupplierName.ValueMember + "' And [Invoice No]='" + TxtPurchaseReturnInvoiceNo.Text + "' And [Category Name]='Cash Purchase Return'"

                cmd1.ExecuteNonQuery()
                cmd4.ExecuteNonQuery()



                con1.Close()




            End If

            dr.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records to Supplier ledger")
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
            cmd2.CommandText = "SELECT  *FROM [Ledger]  WHERE [Invoice No] = '" + TxtPurchaseReturnInvoiceNo.Text + "' And [Category Name]='Purchase Return' "
            cmd3.CommandText = "SELECT  *FROM [Ledger]  WHERE [Invoice No] = '" + TxtPurchaseReturnInvoiceNo.Text + "' And [Category Name]='Cash Purchase Return' "


            dr3 = cmd3.ExecuteReader()
            dr3.Read()


            If dr3.HasRows Then



                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd.Connection = con1
                cmd.CommandText = "Delete from [Ledger] where [Invoice No]= '" + TxtPurchaseReturnInvoiceNo.Text + "' And [Category Name]='Cash Purchase Return'"
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
                cmd.CommandText = "Delete from [Ledger] where [Invoice No]= '" + TxtPurchaseReturnInvoiceNo.Text + "' And [Category Name]='Purchase Return'"
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
    'Search Pendig Invoice No for adujust balance
    Sub SearchPendingInvoice()
        Try



            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader


            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Select * from Ledger Where [Category Name]='Purchase' and [Invoice No]='" + PurchaseInvoiceNumber + "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then


                PendingInvoiceNo = dr.Item("Pending Invoice").ToString
            End If
            dr.Close()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Update Purchase Return Invoice As Complete
    Sub UpdatePurchaseReturnInvoiceToComplete()
        Try



            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Update [Purchase Return Invoice] Set [Status]='COMPLETE',[Return Date]='" + DtpReturnedDate.Value + "',[Total]='" + TxtTotal.Text + "',[Discount Percentage]='" + TxtDiscountPercentage.Text + "',[Discount]='" + TxtDiscount.Text + "',[Net Payable]='" + TxtNetPayable.Text + "',[Paid Amount]='" + TxtPaidAmount.Text + "',[Paid By]='" + cmbPaidBy.SelectedValue.ToString + "' Where [Purchase Return Invoice No]='" + TxtPurchaseReturnInvoiceNo.Text + "'"
            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Insert And Update Into Purchase Return Serial No And Purchase Serial No
    Sub InsertAndUpdateIntoPurchaseReturnSerialNoAndPurchaseSerialNo()

        Try

            'Data Insert Code



            Dim con3 As New SqlConnection
            Dim cmd3 As New SqlCommand
            Dim dr3 As SqlDataReader

            con3.ConnectionString = FrmHome.ConnectionString
            con3.Open()
            cmd3.Connection = con3
            cmd3.CommandText = "SELECT *from [Purchase Serial Number] where [Product ID]= '" + ProductIDForSearchPurchaseSerialNumber + "' And [Purchase Serial Number]='" + CmbSerialNumber.Text + "' And [Status]='Available' And [Purchase Invoice No]='" + PurchaseInvoiceNumber + "' "

            dr3 = cmd3.ExecuteReader()
            dr3.Read()

            If dr3.HasRows Then

                'Insert Into Purchase Return Invoice Number
                InsertIntoPurchaseReturnInvoice()

                'Insert Into Return Serial Number Same Serial Twice Insert Restriction Code
                InsertIntoReturnSerialNumberSameSerialTwiceInsertRestrictionCode()

                'Refresh data after insert
                RefreshPurchaseReturnSerialNumber()

                'Count row after adding serial number
                TxtReturnedQuantity.Text = GrdPurchaseReturnSerialNumber.RowCount

                'Insert Or Update Into Purchase Return For More Then One Quantity
                InsertOrUpdateIntoPurchaseReturnForMoreThenOneQuantity()


                'Refresh Purchase return
                RefreshPurchaseReturn()

                'Clear serial number tex box
                CmbSerialNumber.Text = ""


            Else

                MsgBox("No Available Serial Number", MsgBoxStyle.OkOnly, "Purchase Return")

                CmbSerialNumber.Text = ""
            End If

            dr3.Close()
            con3.Close()

        Catch ex As Exception
            MessageBox.Show("Error while insert and updating record on table..." & ex.Message, "Insert And Update Into Purchase Serial No And Purchase Serial No Sub")

        End Try

    End Sub
    'Insert Into Return Serial Number Same Serial Twice Insert Restriction Code
    Sub InsertIntoReturnSerialNumberSameSerialTwiceInsertRestrictionCode()

        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd2 As New SqlCommand

            Dim con3 As New SqlConnection
            Dim cmd3 As New SqlCommand
            Dim cmd4 As New SqlCommand
            Dim dr3 As SqlDataReader
            Dim dr4 As SqlDataReader





            con3.ConnectionString = FrmHome.ConnectionString
            con3.Open()
            cmd3.Connection = con3
            cmd4.Connection = con3
            cmd3.CommandText = "SELECT *from [Purchase Return Serial] where [Product ID]= '" + ProductIDForSearchPurchaseSerialNumber + "' And [Purchase Return Serial Number]='" + CmbSerialNumber.Text + "' And [Status]='Return' "
            cmd4.CommandText = "select top 1 [Purchase Date],[Purchase ID],[Supplier Name],[Product ID],[Product Name],[Branch Name],[Purchase Cost],[Sale Price],(isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))[Stock Available]from (select  [Purchase].[Purchase Date],Purchase.[Purchase ID],[Supplier Information].[Supplier Name],[Products].[Product ID],[Products].[Product Name],[Branch Information].[Branch Name],[Branch Information].[Branch ID],Purchase.[Purchase Unit Cost][Purchase Cost],[Products].[Sale Price],case when [Purchase Quantity] =0  then (select isnull(sum( [Added Quantity]),0)[Added Quantity] from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  [Product Transfer].[Purchase ID]=Purchase.[Purchase ID] and [Product Transfer].Status='Added' and   [Product Transfer Invoice].Status='Complete'  and [Product Transfer].[Product ID]=Purchase.[Product ID]  group by [Purchase ID] )  ELSE isnull([Purchase].[Purchase Quantity],0) end [Purchase] ,(select isnull(sum([Sale Quantity]),0)      from  sale join [Sale Invoice] on sale.[Sale Invoice No]= [Sale Invoice].[Sale Invoice No] where Sale.[Branch ID]='" + FrmHome.lblBranchID.Text + "' and Sale.[Purchase ID]=Purchase.[Purchase ID]  group by [Purchase ID])[Sale],(select isnull(sum([Returned Quantity]),0)  from [Sale Return] join [Sale Return Invoice] on [Sale Return].[Sale Return Invoice No]=[Sale Return Invoice].[Sale Return Invoice No] where  [Sale Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Sale Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Sale Return],(select isnull(sum([Returned Quantity]),0)  from [Purchase Return] join [Purchase Return Invoice] on [Purchase Return].[Purchase Return Invoice No]=[Purchase Return Invoice].[Purchase Return Invoice No] where [Purchase Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Purchase Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Purchase Return], (select isnull(sum([Deducted Quantity]),0)  from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  Purchase.[Purchase ID]=[Product Transfer].[Purchase ID] and [Product Transfer].Status='Deducted'     group by [Purchase ID] )[Deducted] from Purchase  join Products on Purchase.[Product ID]=products.[Product ID]  join [Branch Information] on [Purchase].[Branch ID]=[Branch Information].[Branch ID]	  Join [Purchase Invoice] on [Purchase Invoice].[Purchase Invoice No]=[Purchase].[Purchase Invoice No] join [Supplier Information] on [Purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID] Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID]  Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID]  Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID]    where [Purchase].[Branch ID]= '" + FrmHome.lblBranchID.Text + "' and [Purchase].[Product ID]='" + ProductIDForSearchPurchaseSerialNumber + "' and [Purchase].[Purchase Invoice No]='" + PurchaseInvoiceNumber + "' or [Purchase].[Branch ID]= '" + FrmHome.lblBranchID.Text + "' and [Purchase].[Product ID]='" + ProductIDForSearchPurchaseSerialNumber + "' And SUBSTRING([Purchase].[Transfer Status],10,LEN([Purchase].[Transfer Status])-2)='" + PurchaseInvoiceNumber + "' ) as a  group by [Purchase Date],[Purchase ID],[Supplier Name],[Branch Name],[Product ID],[Product Name],[Purchase Cost],[Sale Price] having (isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))>0 order by [Purchase Date] asc"

            dr4 = cmd4.ExecuteReader
            dr4.Read()

            If dr4.HasRows Then
                PurchaseID = dr4.Item("Purchase ID").ToString


            ElseIf Not dr4.HasRows Then
                PurchaseID = "NO"

            End If

            dr4.Close()


            dr3 = cmd3.ExecuteReader()
            dr3.Read()

            If Not dr3.HasRows Then
                If Not PurchaseID = "NO" Then
                    'Update And Insert Into Purchase And Purchase Serial Number
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd2.Connection = con
                    cmd.CommandText = "INSERT INTO [Purchase Return Serial] ([Product ID],[Purchase Return Invoice No],[Purchase Return Serial Number],[Status],[Purchase ID]) values ('" + ProductIDForSearchPurchaseSerialNumber + "','" + TxtPurchaseReturnInvoiceNo.Text + "','" + CmbSerialNumber.Text + "','Return','" + PurchaseID + "')"
                    cmd2.CommandText = "Update [Purchase Serial Number] set [Status]='Return' where [Product ID]= '" + ProductIDForSearchPurchaseSerialNumber + "' And [Purchase Serial Number]= '" + CmbSerialNumber.Text + "'"

                    cmd.ExecuteNonQuery()
                    cmd2.ExecuteNonQuery()
                    con.Close()
                Else
                    MsgBox("No stock available.", MsgBoxStyle.Critical, "Purchase Return")
                End If

            Else

                MsgBox("Alrady Exixts.", MsgBoxStyle.OkOnly, "Purchase Return")
            End If
            dr3.Close()
            con3.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    'Insert Or Update Into Purchase Return For More Then One Quantity For Non SerialProduct
    Sub InsertOrUpdateIntoPurchaseReturnForMoreThenOneQuantityForNonSerialProduct()

        Try



            'Insert into Purchase return and return serial number
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd2 As New SqlCommand
            Dim dr2 As SqlDataReader

            Dim TotalAvailableStock As String
            Dim TotalAvailableStockForMorThenOneRow As String

            Dim con3 As New SqlConnection
            Dim cmd3 As New SqlCommand
            Dim dr3 As SqlDataReader

            Dim cmd4 As New SqlCommand
            Dim dr4 As SqlDataReader

            con3.ConnectionString = FrmHome.ConnectionString
            con3.Open()
            cmd3.Connection = con3
            cmd2.Connection = con3
            cmd4.Connection = con3
            cmd3.CommandText = "SELECT *from [Purchase Return] where [Purchase ID]= '" + PurchaseID + "' And [Purchase Return Invoice No]='" + TxtPurchaseReturnInvoiceNo.Text + "' "
            cmd2.CommandText = "select isnull(sum([Stock Available]),0)[Stock Available] from (select  [Purchase Date],[Purchase ID],[Supplier Name],[Product ID],[Product Name],[Branch Name],[Purchase Cost],[Sale Price],(isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))[Stock Available]from (select  [Purchase].[Purchase Date],Purchase.[Purchase ID],[Supplier Information].[Supplier Name],[Products].[Product ID],[Products].[Product Name],[Branch Information].[Branch Name],[Branch Information].[Branch ID],Purchase.[Purchase Unit Cost][Purchase Cost],[Products].[Sale Price],case when [Purchase Quantity] =0  then (select isnull(sum( [Added Quantity]),0)[Added Quantity] from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  [Product Transfer].[Purchase ID]=Purchase.[Purchase ID] and [Product Transfer].Status='Added' and   [Product Transfer Invoice].Status='Complete'  and [Product Transfer].[Product ID]=Purchase.[Product ID]  group by [Purchase ID] )  ELSE isnull([Purchase].[Purchase Quantity],0) end [Purchase] ,(select isnull(sum([Sale Quantity]),0)      from  sale join [Sale Invoice] on sale.[Sale Invoice No]= [Sale Invoice].[Sale Invoice No] where Sale.[Branch ID]='" + FrmHome.lblBranchID.Text + "' and Sale.[Purchase ID]=Purchase.[Purchase ID]  group by [Purchase ID])[Sale],(select isnull(sum([Returned Quantity]),0)  from [Sale Return] join [Sale Return Invoice] on [Sale Return].[Sale Return Invoice No]=[Sale Return Invoice].[Sale Return Invoice No] where  [Sale Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Sale Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Sale Return],(select isnull(sum([Returned Quantity]),0)  from [Purchase Return] join [Purchase Return Invoice] on [Purchase Return].[Purchase Return Invoice No]=[Purchase Return Invoice].[Purchase Return Invoice No] where [Purchase Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Purchase Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Purchase Return], (select isnull(sum([Deducted Quantity]),0)  from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  Purchase.[Purchase ID]=[Product Transfer].[Purchase ID] and [Product Transfer].Status='Deducted'     group by [Purchase ID] )[Deducted] from Purchase  join Products on Purchase.[Product ID]=products.[Product ID]  join [Branch Information] on [Purchase].[Branch ID]=[Branch Information].[Branch ID]	  Join [Purchase Invoice] on [Purchase Invoice].[Purchase Invoice No]=[Purchase].[Purchase Invoice No] join [Supplier Information] on [Purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID] Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID]  Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID]  Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID]    where [Purchase].[Branch ID]= '" + FrmHome.lblBranchID.Text + "' and [Purchase].[Product ID]='" + ProductIDForSearchPurchaseSerialNumber + "' and [Purchase].[Purchase Invoice No]='" + PurchaseInvoiceNumber + "' or [Purchase].[Branch ID]= '" + FrmHome.lblBranchID.Text + "' and [Purchase].[Product ID]='" + ProductIDForSearchPurchaseSerialNumber + "' And SUBSTRING([Purchase].[Transfer Status],10,LEN([Purchase].[Transfer Status])-2)='" + PurchaseInvoiceNumber + "' ) as a  group by [Purchase Date],[Purchase ID],[Supplier Name],[Branch Name],[Product ID],[Product Name],[Purchase Cost],[Sale Price] having (isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))>0 ) as a"
            cmd4.CommandText = "select top 1 [Purchase Date],[Purchase ID],[Supplier Name],[Product ID],[Product Name],[Branch Name],[Purchase Cost],[Sale Price],(isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))[Stock Available]from (select  [Purchase].[Purchase Date],Purchase.[Purchase ID],[Supplier Information].[Supplier Name],[Products].[Product ID],[Products].[Product Name],[Branch Information].[Branch Name],[Branch Information].[Branch ID],Purchase.[Purchase Unit Cost][Purchase Cost],[Products].[Sale Price],case when [Purchase Quantity] =0  then (select isnull(sum( [Added Quantity]),0)[Added Quantity] from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  [Product Transfer].[Purchase ID]=Purchase.[Purchase ID] and [Product Transfer].Status='Added' and   [Product Transfer Invoice].Status='Complete'  and [Product Transfer].[Product ID]=Purchase.[Product ID]  group by [Purchase ID] )  ELSE isnull([Purchase].[Purchase Quantity],0) end [Purchase] ,(select isnull(sum([Sale Quantity]),0)      from  sale join [Sale Invoice] on sale.[Sale Invoice No]= [Sale Invoice].[Sale Invoice No] where Sale.[Branch ID]='" + FrmHome.lblBranchID.Text + "' and Sale.[Purchase ID]=Purchase.[Purchase ID]  group by [Purchase ID])[Sale],(select isnull(sum([Returned Quantity]),0)  from [Sale Return] join [Sale Return Invoice] on [Sale Return].[Sale Return Invoice No]=[Sale Return Invoice].[Sale Return Invoice No] where  [Sale Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Sale Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Sale Return],(select isnull(sum([Returned Quantity]),0)  from [Purchase Return] join [Purchase Return Invoice] on [Purchase Return].[Purchase Return Invoice No]=[Purchase Return Invoice].[Purchase Return Invoice No] where [Purchase Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Purchase Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Purchase Return], (select isnull(sum([Deducted Quantity]),0)  from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  Purchase.[Purchase ID]=[Product Transfer].[Purchase ID] and [Product Transfer].Status='Deducted'     group by [Purchase ID] )[Deducted] from Purchase  join Products on Purchase.[Product ID]=products.[Product ID]  join [Branch Information] on [Purchase].[Branch ID]=[Branch Information].[Branch ID]	  Join [Purchase Invoice] on [Purchase Invoice].[Purchase Invoice No]=[Purchase].[Purchase Invoice No] join [Supplier Information] on [Purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID] Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID]  Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID]  Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID]    where [Purchase].[Branch ID]= '" + FrmHome.lblBranchID.Text + "' and [Purchase].[Product ID]='" + ProductIDForSearchPurchaseSerialNumber + "' and [Purchase].[Purchase Invoice No]='" + PurchaseInvoiceNumber + "' or [Purchase].[Branch ID]= '" + FrmHome.lblBranchID.Text + "' and [Purchase].[Product ID]='" + ProductIDForSearchPurchaseSerialNumber + "' And SUBSTRING([Purchase].[Transfer Status],10,LEN([Purchase].[Transfer Status])-2)='" + PurchaseInvoiceNumber + "') as a  group by [Purchase Date],[Purchase ID],[Supplier Name],[Branch Name],[Product ID],[Product Name],[Purchase Cost],[Sale Price] having (isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))>0 order by [Purchase Date] asc"

            dr2 = cmd2.ExecuteReader()
            dr2.Read()
            If dr2.HasRows Then
                TotalAvailableStock = dr2.Item("Stock Available").ToString
                'MsgBox(TotalAvailableStock)
            End If

            dr2.Close()

            dr4 = cmd4.ExecuteReader()
            dr4.Read()
            If dr4.HasRows Then
                TotalAvailableStockForMorThenOneRow = dr4.Item("Stock Available").ToString
                'MsgBox(TotalAvailableStockForMorThenOneRow)

            End If

            dr4.Close()



            dr3 = cmd3.ExecuteReader()
            dr3.Read()

            If Not dr3.HasRows Then
                If Not Val(TxtReturnedQuantity.Text) > Val(TotalAvailableStock) Then

                    If Val(TxtReturnedQuantity.Text) <= Val(TotalAvailableStockForMorThenOneRow) Then
                        con.ConnectionString = FrmHome.ConnectionString
                        con.Open()
                        cmd.Connection = con
                        cmd.CommandText = "INSERT INTO [Purchase Return] ([Returned Quantity],[Branch ID],[Purchase ID],[Purchase Return Invoice No],[Product ID]) VALUES ('" + TxtReturnedQuantity.Text + "','" + FrmHome.lblBranchID.Text + "','" + PurchaseID + "','" + TxtPurchaseReturnInvoiceNo.Text + "','" + ProductIDForSearchReturnSerialNumber + "' )"
                        cmd.ExecuteNonQuery()
                        con.Close()
                    Else
                        'Timer starts
                        Timer1.Start()
                    End If

                Else
                    MsgBox("Insufficient Stock", MsgBoxStyle.Critical, "Purchase Return")
                    TxtReturnedQuantity.Focus()

                End If
            ElseIf dr3.HasRows Then

                If Val(TxtReturnedQuantity.Text) <= Val(TotalAvailableStockForMorThenOneRow) Then
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = " Update [Purchase Return] Set [Returned Quantity]='" + TxtReturnedQuantity.Text + "' Where  [Purchase ID]= '" + PurchaseID + "' And [Purchase Return Invoice No]='" + TxtPurchaseReturnInvoiceNo.Text + "' "
                    cmd.ExecuteNonQuery()
                    con.Close()
                Else
                    'Timer starts
                    Timer1.Start()
                End If
            End If
            dr3.Close()
            con3.Close()

            'Making Clear Purchase Return
            ClearDataPurchaseReturn()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Insert Or Update Into Purchase Return For More Then One Quantity
    Sub InsertOrUpdateIntoPurchaseReturnForMoreThenOneQuantity()
        Try



            If Not PurchaseID = "NO" Then
                'Insert into Purchase return and return serial number
                Dim con As New SqlConnection
                Dim cmd As New SqlCommand



                Dim con3 As New SqlConnection
                Dim cmd3 As New SqlCommand
                Dim dr3 As SqlDataReader

                con3.ConnectionString = FrmHome.ConnectionString
                con3.Open()
                cmd3.Connection = con3
                cmd3.CommandText = "SELECT *from [Purchase Return] where [Purchase ID]= '" + PurchaseID + "' And [Purchase Return Invoice No]='" + TxtPurchaseReturnInvoiceNo.Text + "' "




                dr3 = cmd3.ExecuteReader()
                dr3.Read()

                If Not dr3.HasRows Then

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO [Purchase Return] ([Returned Quantity],[Branch ID],[Purchase ID],[Purchase Return Invoice No],[Product ID]) VALUES ('" + TxtReturnedQuantity.Text + "','" + FrmHome.lblBranchID.Text + "','" + PurchaseID + "','" + TxtPurchaseReturnInvoiceNo.Text + "','" + ProductIDForSearchReturnSerialNumber + "' )"
                    cmd.ExecuteNonQuery()
                    con.Close()

                ElseIf dr3.HasRows Then

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = " Update [Purchase Return] Set [Returned Quantity]='" + TxtReturnedQuantity.Text + "' Where  [Purchase ID]= '" + PurchaseID + "' And [Purchase Return Invoice No]='" + TxtPurchaseReturnInvoiceNo.Text + "' "
                    cmd.ExecuteNonQuery()
                    con.Close()

                End If
                dr3.Close()
                con3.Close()
            End If

            'Making Clear Purchase Return
            ClearDataPurchaseReturn()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    'Insert And Update Into Purchase Return Serial Number And Purchase Serial Number
    Sub InsertAndUpdateIntoPurchaseReturnSerialNumberAndPurchaseSerialNumber()

        Try
            'Data Insert Code
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand

            Dim total As String = 0

            For i As Integer = 0 To GrdPurchaseSerialNumber.RowCount - 1
                total += GrdPurchaseSerialNumber.Rows(i).Cells(0).Value

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd1.Connection = con
                cmd.CommandText = "INSERT INTO [Purchase Return Serial] ([Product ID],[Purchase Return Invoice No],[Purchase Return Serial Number],[Status],[Purchase ID]) VALUES ('" + ProductIDForSearchPurchaseSerialNumber + "','" + TxtPurchaseReturnInvoiceNo.Text + "','" + GrdPurchaseSerialNumber.Rows(i).Cells(0).Value.ToString + "','Return','" + PurchaseID + "' )"
                cmd1.CommandText = "Update [Purchase Serial Number] set [Status]='Return' where [Product ID]= '" + ProductIDForSearchPurchaseSerialNumber + "' And [Purchase Serial Number]= '" + GrdPurchaseSerialNumber.Rows(i).Cells(0).Value.ToString + "'"
                cmd.ExecuteNonQuery()
                cmd1.ExecuteNonQuery()
                con.Close()

            Next


        Catch ex As Exception
            MessageBox.Show("Error while Marking record on table..." & ex.Message, "Update And Insert Into Purchase And PurchaseSerial Number")
        Finally

        End Try

    End Sub

    'Search Purchase Return Serial Number
    Sub RefreshPurchaseReturnSerialNumber()

        Try



            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Purchase Return Serial Number] From  [Purchase Return Serial]  where [Purchase Return Invoice No]  = '" + TxtPurchaseReturnInvoiceNo.Text + "'  And [Product ID]='" + ProductIDForSearchReturnSerialNumber + "' And [Purchase ID]='" + PurchaseID + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Purchase Return Serial Number")
            connection.Close()
            GrdPurchaseReturnSerialNumber.DataSource = ds
            GrdPurchaseReturnSerialNumber.DataMember = "BizPro_Purchase Return Serial Number"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdPurchaseReturnSerialNumber.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Search Purchase Return Serial Number For Delete Invoice
    Sub RefreshPurchaseReturnSerialNumberForDeleteInvoice()

        Try



            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Product ID],[Purchase Return Serial Number] From  [Purchase Return Serial]  where [Purchase Return Invoice No]  = '" + TxtPurchaseReturnInvoiceNo.Text + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Purchase Return Serial Number")
            connection.Close()
            GrdPurchaseReturnSerialNumber.DataSource = ds
            GrdPurchaseReturnSerialNumber.DataMember = "BizPro_Purchase Return Serial Number"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdPurchaseReturnSerialNumber.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand


            Dim total As String = 0

            For i As Integer = 0 To GrdPurchaseReturnSerialNumber.RowCount - 1
                total += GrdPurchaseReturnSerialNumber.Rows(i).Cells(0).Value & GrdPurchaseReturnSerialNumber.Rows(i).Cells(1).Value


                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd1.Connection = con
                cmd.CommandText = "Update [Purchase Serial Number] set [Status]='Available' where [Product ID]= '" + GrdPurchaseReturnSerialNumber.Rows(i).Cells(0).Value.ToString + "' And [Purchase Serial Number]= '" + GrdPurchaseReturnSerialNumber.Rows(i).Cells(1).Value.ToString + "'"
                cmd1.CommandText = " Delete from [Purchase Return Serial]  where [Purchase Return Invoice No]  = '" + TxtPurchaseReturnInvoiceNo.Text + "' "

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
    'Insert Into Purchase Return Invoice code
    Sub InsertIntoPurchaseReturnInvoice()


        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim con2 As New SqlConnection
            Dim cmd2 As New SqlCommand
            Dim dr1 As SqlDataReader

            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now



            If TxtPurchaseReturnInvoiceNo.Text = "" Then

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "INSERT INTO [Purchase Return Invoice] ([Purchase Invoice No],[Return Date],[Prepared Date],[Prepared Time],[Computer ID],[User Account ID],[Supplier ID],[Status],[Total],[Discount Percentage],[Discount],[Net Payable],[Paid Amount],[Paid By]) values ('" + PurchaseInvoiceNumber + "','" + DtpReturnedDate.Value + "','" + currentDate + "','" + currentTime + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + SupplierID + "','INCOMPLETE','" + TxtTotal.Text + "','" + TxtDiscountPercentage.Text + "','" + TxtDiscount.Text + "','" + TxtNetPayable.Text + "','" + TxtPaidAmount.Text + "','" + cmbPaidBy.SelectedValue.ToString + "')"
                cmd.ExecuteNonQuery()
                con.Close()


                con2.ConnectionString = FrmHome.ConnectionString
                con2.Open()
                cmd2.Connection = con2
                cmd2.CommandText = "SELECT top 1 [Purchase Return Invoice No] FROM [Purchase Return Invoice] where [User Account ID]= '" + FrmHome.LblUserID.Text + "' And [Computer ID]='" + FrmHome.LblComputerID.Text + "'   order by [Purchase Return Invoice No] desc"

                dr1 = cmd2.ExecuteReader()
                dr1.Read()

                If dr1.HasRows Then

             
                    TxtPurchaseReturnInvoiceNo.Text = (dr1.Item("Purchase Return Invoice No").ToString)
                End If

                dr1.Close()
                con2.Close()



            ElseIf Not TxtPurchaseReturnInvoiceNo.Text = "" Then

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "Update [Purchase Return Invoice] Set [Status]='INCOMPLETE',[Total]='" + TxtTotal.Text + "',[Discount Percentage]='" + TxtDiscountPercentage.Text + "',[Discount]='" + TxtDiscount.Text + "',[Net Payable]='" + TxtNetPayable.Text + "',[Paid Amount]='" + TxtPaidAmount.Text + "',[Paid By]='" + cmbPaidBy.SelectedValue.ToString + "' Where [Purchase Return Invoice No]='" + TxtPurchaseReturnInvoiceNo.Text + "'"
                cmd.ExecuteNonQuery()
                con.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Error while Inserting to Purchase invoice record on table..." & ex.Message, "Insert Records Purchase Invoice")
        Finally

        End Try



    End Sub
    Sub RefreshPurchaseReturn()

        ' Load Data
        Try

            

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Purchase Return].[Purchase Return ID],[Products].[Product Name],[Purchase Return].[Returned Quantity],([Purchase Return].[Returned Quantity]* (select [Purchase Unit Cost] from  Purchase where [Purchase Invoice No]='" + PurchaseInvoiceNumber + "' and [Product ID]=products.[Product ID]))[Total Amount] from [Purchase Return] join Purchase on [Purchase Return].[purchase ID]=Purchase.[Purchase ID]  join Products on Purchase.[Product ID]=Products.[Product ID] join [Purchase Return Invoice] on [Purchase Return].[Purchase Return Invoice No]=[Purchase Return Invoice].[Purchase Return Invoice No] Where [Purchase Return].[Purchase Return Invoice No]='" + TxtPurchaseReturnInvoiceNo.Text + "' And [Purchase Return Invoice].[Purchase Invoice No]='" + PurchaseInvoiceNumber + "' Order by [Purchase Return].[Purchase Return ID] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Purchase Return")
            connection.Close()
            GrdPurchaseReturn.DataSource = ds
            GrdPurchaseReturn.DataMember = "BizPro_Purchase Return"

            'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)


            GrdPurchaseReturn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


            'Count Total Amount
            TotalAmount()

            'Count NetPayable
            NetPayable()


        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try

        'End Refresh Data

    End Sub

    'Search Purchase Return Invoice
    Sub SearchPurchaseReturnInvoice()

        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader


            'Data reader for Product Id
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT * from [Purchase Return Invoice] join  [User Account] on [Purchase Return Invoice].[User Account ID]=[User Account].[User Account ID] join [Supplier Information] on [Purchase Return Invoice].[Supplier ID]=[Supplier Information].[Supplier ID] WHERE [Purchase Return Invoice].[Purchase Return Invoice No] =  '" + TxtPurchaseReturnInvoiceNo.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()
            If dr.HasRows Then



                TxtTotal.Text = (dr.Item("Total").ToString)
                TxtDiscountPercentage.Text = (dr.Item("Discount Percentage").ToString)
                TxtDiscount.Text = (dr.Item("Discount").ToString)
                cmbPaidBy.SelectedValue = (dr.Item("Paid By").ToString)
                TxtPaidAmount.Text = (dr.Item("Paid Amount").ToString)
                TxtNetPayable.Text = (dr.Item("Net Payable").ToString)
                TxtSearch.Text = (dr.Item("Purchase Invoice No").ToString)
                PurchaseInvoiceNumber = (dr.Item("Purchase Invoice No").ToString)




            End If

            dr.Close()
            con.Close()


        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Search Purchase Return Invoice")
        Finally

        End Try


    End Sub
    'Count Totla amount and shoe in total textbox
    Sub TotalAmount()
        Try

            Dim total As String = 0
            For i As Integer = 0 To GrdPurchaseReturn.RowCount - 1
                total += GrdPurchaseReturn.Rows(i).Cells(3).Value
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
                Dim sql As String = "SELECT [Purchase Invoice].[Purchase Invoice No],[Branch Information].[Branch Name],[Supplier Information].[Supplier Name],[Purchase Invoice].[Purchase Date],[Purchase Invoice].[Purchase Time],[Purchase Invoice].[Total] from [Purchase Invoice] join Purchase on [Purchase Invoice].[Purchase Invoice No]=Purchase.[Purchase Invoice No] join [Branch Information] on Purchase.[Branch ID]= [Branch Information].[Branch ID]  join [User Account] on [Purchase Invoice].[User Account ID]=[User Account].[User Account ID] join [supplier Information] on [Purchase Invoice].[supplier ID]=[supplier Information].[supplier ID]   where [Purchase Invoice].[Purchase Invoice No] = '" + TxtSearch.Text + "' and [Purchase Invoice].[Status]='Complete' Group by [Purchase Invoice].[Purchase Invoice No],[Branch Information].[Branch Name],[Supplier Information].[Supplier Name],[Purchase Invoice].[Purchase Date],[Purchase Invoice].[Purchase Time],[Purchase Invoice].[Total] order by [Purchase Invoice].[Purchase Date]  desc, [Purchase Invoice].[Purchase Time] desc"
                Dim connection As New SqlConnection(connectionString)
                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Purchase Invoice")
                connection.Close()
                GrdPurchaseInvoice.DataSource = ds
                GrdPurchaseInvoice.DataMember = "BizPro_Purchase Invoice"

                'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
                GrdPurchaseInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill




                Dim connectionString1 As String = FrmHome.ConnectionString
                Dim sql1 As String = "SELECT [Purchase].[Purchase ID],[Products].[Product Name],[Purchase].[Purchase Quantity],[Purchase].[Purchase Unit cost],[Purchase].[Amount] from [Purchase] join [Products] on [Purchase].[product ID]=[products].[Product ID] join [purchase Invoice] on [Purchase].[Purchase Invoice No]=[Purchase Invoice].[Purchase Invoice No] where [Purchase].[Purchase Invoice No]='" + TxtSearch.Text + "' and [Purchase Invoice].[Status]='Complete'"
                Dim connection1 As New SqlConnection(connectionString1)
                Dim dataadapter1 As New SqlDataAdapter(sql1, connection1)
                Dim ds1 As New DataSet()
                connection1.Open()
                dataadapter1.Fill(ds1, "BizPro_Purchase")
                connection1.Close()
                GrdPurchaseDetails.DataSource = ds1
                GrdPurchaseDetails.DataMember = "BizPro_Purchase"

                'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)


                GrdPurchaseDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    'Privet sub for customer information
    Sub SupplierInformation()
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT * from [Customer Information] join [Supplier Information] on [Customer Information].[Supplier ID] = [Supplier Information].[Supplier ID] join [Purchase Invoice] on [Supplier Information].[Supplier ID]=[Purchase Invoice].[Supplier ID] WHERE [Purchase Invoice].[Purchase Invoice No] =  '" + PurchaseInvoiceNumber + "'"


            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then


                Me.CmbSupplierName.Text = dr.Item("Supplier Name").ToString
                Me.CmbSupplierName.ValueMember = dr.Item("Chart Of Account ID").ToString
                Me.TxtPhoneNo.Text = dr.Item("Mobile No").ToString
                Me.TxtAddress.Text = dr.Item("Address").ToString

                SupplierID = dr.Item("Supplier ID").ToString
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


                Me.CmbSupplierName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtPhoneNo.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtAddress.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtSearch.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtPurchaseReturnInvoiceNo.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
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

                Me.GrdPurchaseInvoice.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdPurchaseInvoice.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)

                Me.GrdPurchaseDetails.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdPurchaseDetails.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)

                Me.GrdPurchaseSerialNumber.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdPurchaseSerialNumber.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)


                Me.GrdPurchaseReturn.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdPurchaseReturn.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)



                Me.GrdPurchaseReturnSerialNumber.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdPurchaseReturnSerialNumber.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)

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

        GrdPurchaseReturnSerialNumber.Columns.Clear()
        GrdPurchaseReturn.Columns.Clear()
        GrdPurchaseDetails.Columns.Clear()
        GrdPurchaseInvoice.Columns.Clear()
        GrdPurchaseSerialNumber.Columns.Clear()

        TxtPurchaseReturnInvoiceNo.Text = ""

        LblPurchaseReturnID.Text = "00"
        DtpReturnedDate.Value = Now

        TxtTotal.Text = ""
        TxtDiscount.Text = ""
        TxtDiscountPercentage.Text = "00"
        TxtNetPayable.Text = ""
        TxtPaidAmount.Text = ""
        cmbPaidBy.Text = "DUE"

        CmbSupplierName.Text = ""
        CmbSupplierName.ValueMember = ""
        TxtPhoneNo.Text = ""
        TxtAddress.Text = ""


        GrpPurchaseReturn.Enabled = False

        PurchaseReturnEditStatus = False

    End Sub
    Sub ClearDataPurchaseReturn()

        CmbSerialNumber.Text = ""
        TxtReturnedQuantity.Text = ""
        LblPurchaseReturnID.Text = "00"

        'Calculate Netpayable
        NetPayable()

    End Sub

    'Clear Data For Search 
    Sub ClearDataForSarch()


        'Clear Gridview and Textbox
        GrdPurchaseInvoice.Columns.Clear()
        GrdPurchaseDetails.Columns.Clear()
        GrdPurchaseSerialNumber.Columns.Clear()

        CmbSupplierName.Text = ""
        CmbSupplierName.ValueMember = ""
        TxtPhoneNo.Text = ""
        TxtAddress.Text = ""

        TxtSearch.Text = ""
        TxtSearch.Focus()

    End Sub




    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click

        'Set purchase invoice no to variable
        PurchaseInvoiceNumber = Val(TxtSearch.Text)

        'Search Purchase Invoice
        SearchPurchaseInvoice()

        'Show Customer Information
        SupplierInformation()

        'Search Invoice Number And Product Details
        SearchInvoiceNumberAndProductDetails()

        'For Search Purchase Invoice Number
        If CmbSearch.SelectedIndex = 1 Then
            PurchaseInvoiceNumber = Val(TxtSearch.Text)
        End If

        GrdPurchaseSerialNumber.Columns.Clear()


    End Sub

    Private Sub TxtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then

            'For Search Purchase Invoice Number
            If CmbSearch.SelectedIndex = 1 Then

                'Search Invoice Number And Product Details
                SearchInvoiceNumberAndProductDetails()

                PurchaseInvoiceNumber = Val(TxtSearch.Text)

                'Show Customer Information
                SupplierInformation()
            End If
        End If


    End Sub
    Private Sub CmbSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSearch.SelectedIndexChanged

        'Clear data For Search
        ClearDataForSarch()

    End Sub

    Private Sub GrdPurchaseInvoice_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles GrdPurchaseInvoice.CellFormatting
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

                If GrdPurchaseInvoice.Columns(e.ColumnIndex).Name.Equals("Total") Then
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

    Private Sub GrdPurchaseInvoice_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdPurchaseInvoice.CellMouseClick
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdPurchaseInvoice.Rows(e.RowIndex)

                If TxtPurchaseReturnInvoiceNo.Text = "" Then
                    ' Load Data

                    Dim connectionString As String = FrmHome.ConnectionString
                    Dim sql As String = "SELECT [Purchase].[Purchase ID],[Products].[Product Name],[Purchase].[Purchase Quantity],[Purchase].[Purchase Unit cost],[Purchase].[Amount] from [Purchase] join [Products] on [Purchase].[product ID]=[products].[Product ID]  where [Purchase].[Purchase Invoice No]= '" + row.Cells("Purchase Invoice No").Value.ToString + "'"
                    Dim connection As New SqlConnection(connectionString)
                    Dim dataadapter As New SqlDataAdapter(sql, connection)
                    Dim ds As New DataSet()
                    connection.Open()
                    dataadapter.Fill(ds, "BizPro_Purchase")
                    connection.Close()
                    GrdPurchaseDetails.DataSource = ds
                    GrdPurchaseDetails.DataMember = "BizPro_Purchase"

                    'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                    'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
                    GrdPurchaseDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


                    'Send PurchaseInvoice Number to variable
                    PurchaseInvoiceNumber = row.Cells("Purchase Invoice No").Value.ToString

                    'Show Customer Information
                    SupplierInformation()

                    'Clear Gridview
                    GrdPurchaseSerialNumber.Columns.Clear()
                Else
                    MsgBox("Please complete this invoice", MsgBoxStyle.OkOnly, "Purchase Return")
                End If

            End If
        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try


    End Sub


    Private Sub GrdSale_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdPurchaseInvoice.CellMouseDoubleClick

        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdPurchaseInvoice.Rows(e.RowIndex)

                'TxtPurchaseID.Text = row.Cells("Purchase ID").Value.ToString

            End If

            'Text Box Return Quantity Focus
            TxtReturnedQuantity.Focus()


        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Grid view")

        End Try


    End Sub






    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click

        'Insert Into Purchase Return Invoice Number
        InsertIntoPurchaseReturnInvoice()

        'Insert Or Update Into Purchase Return For More Then One Quantity
        InsertOrUpdateIntoPurchaseReturnForMoreThenOneQuantity()

        'Refresh Purchase return
        RefreshPurchaseReturn()

    End Sub

    Private Sub GrdPurchaseReturn_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles GrdPurchaseReturn.CellFormatting
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

                If GrdPurchaseReturn.Columns(e.ColumnIndex).Name.Equals("Total Amount") Then
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



    Private Sub GrdSaleReturn_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdPurchaseReturn.CellMouseClick
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdPurchaseReturn.Rows(e.RowIndex)


                TxtReturnedQuantity.Text = row.Cells("Returned Quantity").Value.ToString
                TxtReturnedQuantity.Focus()


                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim dr As SqlDataReader

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "SELECT *from [Purchase Return] join Purchase on [Purchase Return].[Purchase ID]=Purchase.[Purchase ID] WHERE [Purchase Return ID]= '" + row.Cells("Purchase Return ID").Value.ToString + "'"

                dr = cmd.ExecuteReader()
                dr.Read()

                If dr.HasRows Then
                    ProductIDForSearchReturnSerialNumber = dr.Item("Product ID").ToString
                    PurchaseID = dr.Item("Purchase ID").ToString
                    'PurchaseIDForInsertIntoPurchaseSerialNumber = dr.Item("Purchase ID").ToString
                End If

                dr.Close()
                con.Close()



                LblPurchaseReturnID.Text = row.Cells("Purchase Return ID").Value.ToString

                'Search Purchase Return Serial Number
                RefreshPurchaseReturnSerialNumber()


            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Grid view")

        End Try

    End Sub

    Private Sub GrdSaleReturn_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdPurchaseReturn.CellMouseDoubleClick


        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdPurchaseReturn.Rows(e.RowIndex)

                'Data Delete Code
                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim cmd1 As New SqlCommand
                Dim cmd2 As New SqlCommand



                Dim q As MsgBoxResult
                q = MsgBox("Do you really want to Delete the row?", MsgBoxStyle.YesNo, "Purchase Return")
                If q = MsgBoxResult.Yes Then



                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd1.Connection = con
                    cmd2.Connection = con
                    cmd.CommandText = " Delete from [Purchase Return]  where [Purchase Return ID]=  " + row.Cells("Purchase Return ID").Value.ToString + " "
                    cmd1.CommandText = " Delete from [Purchase Return Serial]  where [Purchase Return Invoice No]  = '" + TxtPurchaseReturnInvoiceNo.Text + "'  And [Product ID]='" + ProductIDForSearchReturnSerialNumber + "' And [Purchase ID]='" + PurchaseID + "'"

                    cmd.ExecuteNonQuery()
                    cmd1.ExecuteNonQuery()





                    Dim total As String = 0
                    For i As Integer = 0 To GrdPurchaseReturnSerialNumber.RowCount - 1
                        total += GrdPurchaseReturnSerialNumber.Rows(i).Cells(0).Value

                        cmd2.CommandText = "Update [Purchase Serial Number] set [Status]='Available'  where [Product ID]= '" + ProductIDForSearchReturnSerialNumber + "' And [Purchase Serial Number]= '" + GrdPurchaseReturnSerialNumber.Rows(i).Cells(0).Value.ToString + "' "
                        cmd2.ExecuteNonQuery()

                    Next

                    con.Close()

                    'Refreshdata
                    RefreshPurchaseReturn()

                    'Search Purchase Return Serial Number
                    RefreshPurchaseReturnSerialNumber()

                    'Clear Data Purchase Return
                    ClearDataPurchaseReturn()

                    'Focus on Paid amount
                    TxtPaidAmount.Focus()





                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Grdview Cell Mouse Double Click")
        Finally

        End Try

    End Sub
    Private Sub TxtReturnedQuantity_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtReturnedQuantity.KeyDown

        If e.KeyCode = Keys.Enter Then
            If TxtReturnedQuantity.Text = "" Or Val(TxtReturnedQuantity.Text) = 0 Then
                MsgBox("Insufficient Stock", MsgBoxStyle.OkOnly, "Purchase Return")


            Else

                'save quantity to variable
                QuantityWritten = TxtReturnedQuantity.Text

                'Insert Into Purchase Return Invoice Number
                InsertIntoPurchaseReturnInvoice()

                If Not TxtPurchaseReturnInvoiceNo.Text = "" And Not GrdPurchaseSerialNumber.RowCount > 0 Then

                    'Insert Or Update Into Purchase Return For More Then One Quantity For Non SerialProduct
                    InsertOrUpdateIntoPurchaseReturnForMoreThenOneQuantityForNonSerialProduct()
                End If
                'Refresh Purchase return
                RefreshPurchaseReturn()

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

        'Search Purchase Invoice
        SearchPurchaseInvoice()

        GrdPurchaseSerialNumber.Columns.Clear()



    End Sub

    Private Sub GrdSaleInvoice_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdPurchaseInvoice.CellContentClick

    End Sub

    Private Sub FrmSaleReturn_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'If (MessageBox.Show(" Do you really want to Close?", "Purchase Return", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No) Then
        'e.Cancel = True

        'End If


        If Not TxtPurchaseReturnInvoiceNo.Text = "" And Not PurchaseReturnEditStatus = True Then

            Dim q As MsgBoxResult = MsgBox("Do you want to keep this Invoice as draft?", MsgBoxStyle.YesNoCancel, "Purchase Return")

            If q = MsgBoxResult.No Then

                'Delete Full Invoice
                DeleteFullInvoice()
            ElseIf q = MsgBoxResult.Cancel Then
                e.Cancel = True
            End If
        ElseIf Not TxtPurchaseReturnInvoiceNo.Text = "" And PurchaseReturnEditStatus = True Then
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
                BtnSave.Enabled = True

            ElseIf Not dr.HasRows Then
                BtnDelete.Enabled = False
                BtnSave.Enabled = False

            End If
            dr.Close()




            'Permission For Show Purchase Price
            dr1 = cmd1.ExecuteReader()
            dr1.Read()

            If Not dr1.HasRows Then

                ShowInvoicePermission = "No"


                TxtTotal.PasswordChar = "*"
                TxtNetPayable.PasswordChar = "*"
                TxtPaidAmount.PasswordChar = "*"


            End If
            dr1.Close()
            con.Close()



        Catch ex As Exception
            MessageBox.Show("Error while  permission delete to form..." & ex.Message, "Form Load")

        End Try

        'Load Combobox for Payment method
        LoadComboBoxPaymentMethod()


        'Clear all data
        ClearAllData()


    End Sub

    Private Sub GrdSaleDetails_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdPurchaseDetails.CellContentClick

    End Sub

    Private Sub GrdPurchaseDetails_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles GrdPurchaseDetails.CellFormatting
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

                If GrdPurchaseDetails.Columns(e.ColumnIndex).Name.Equals("Purchase Unit cost") Then

                    If (Not e.Value Is Nothing) Then
                        e.Value = New String(CChar("*"), e.Value.ToString.Length)

                    End If

                ElseIf GrdPurchaseDetails.Columns(e.ColumnIndex).Name.Equals("Amount") Then
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

    Private Sub GrdSaleDetails_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdPurchaseDetails.CellMouseClick
        Try


            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdPurchaseDetails.Rows(e.RowIndex)





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


                    ProductIDForSearchPurchaseSerialNumber = dr.Item("Product ID").ToString
                    ProductIDForSearchReturnSerialNumber = dr.Item("Product ID").ToString
                    PurchaseID = dr.Item("Purchase ID").ToString
                    'PurchaseIDForInsertIntoPurchaseSerialNumber = dr.Item("Purchase ID").ToString
                End If

                dr.Close()
                con.Close()




                'Search Purchase Serial Number
                Dim connectionString As String = FrmHome.ConnectionString
                Dim sql As String = "SELECT [Purchase Serial Number] From  [Purchase Serial Number]  where [Purchase Invoice No]  = '" + PurchaseInvoiceNumber + "'  And [Product ID]='" + ProductIDForSearchPurchaseSerialNumber + "'"
                Dim connection As New SqlConnection(connectionString)
                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Purchase Serial Number")
                connection.Close()
                GrdPurchaseSerialNumber.DataSource = ds
                GrdPurchaseSerialNumber.DataMember = "BizPro_Purchase Serial Number"

                'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
                GrdPurchaseSerialNumber.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill






            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub GrdSaleDetails_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdPurchaseDetails.CellMouseDoubleClick

        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow

                row = Me.GrdPurchaseDetails.Rows(e.RowIndex)

                If row.Cells("Purchase Quantity").Value = 1 Then


                    'Insert Purchase Return Invoice 
                    InsertIntoPurchaseReturnInvoice()

                    Dim con3 As New SqlConnection
                    Dim cmd3 As New SqlCommand
                    Dim dr3 As SqlDataReader

                    Dim cmd4 As New SqlCommand
                    Dim dr4 As SqlDataReader



                    con3.ConnectionString = FrmHome.ConnectionString
                    con3.Open()
                    cmd3.Connection = con3
                    cmd4.Connection = con3
                    cmd3.CommandText = "SELECT *from [Purchase Return] where [Purchase ID]= '" + PurchaseID + "' And [Purchase Return Invoice No]='" + TxtPurchaseReturnInvoiceNo.Text + "' "

                    cmd4.CommandText = "select top 1 [Purchase Date],[Purchase ID],[Supplier Name],[Product ID],[Product Name],[Branch Name],[Purchase Cost],[Sale Price],(isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))[Stock Available]from (select  [Purchase].[Purchase Date],Purchase.[Purchase ID],[Supplier Information].[Supplier Name],[Products].[Product ID],[Products].[Product Name],[Branch Information].[Branch Name],[Branch Information].[Branch ID],Purchase.[Purchase Unit Cost][Purchase Cost],[Products].[Sale Price],case when [Purchase Quantity] =0  then (select isnull(sum( [Added Quantity]),0)[Added Quantity] from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  [Product Transfer].[Purchase ID]=Purchase.[Purchase ID] and [Product Transfer].Status='Added' and   [Product Transfer Invoice].Status='Complete'  and [Product Transfer].[Product ID]=Purchase.[Product ID]  group by [Purchase ID] )  ELSE isnull([Purchase].[Purchase Quantity],0) end [Purchase] ,(select isnull(sum([Sale Quantity]),0)      from  sale join [Sale Invoice] on sale.[Sale Invoice No]= [Sale Invoice].[Sale Invoice No] where Sale.[Branch ID]='" + FrmHome.lblBranchID.Text + "' and Sale.[Purchase ID]=Purchase.[Purchase ID]  group by [Purchase ID])[Sale],(select isnull(sum([Returned Quantity]),0)  from [Sale Return] join [Sale Return Invoice] on [Sale Return].[Sale Return Invoice No]=[Sale Return Invoice].[Sale Return Invoice No] where  [Sale Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Sale Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Sale Return],(select isnull(sum([Returned Quantity]),0)  from [Purchase Return] join [Purchase Return Invoice] on [Purchase Return].[Purchase Return Invoice No]=[Purchase Return Invoice].[Purchase Return Invoice No] where [Purchase Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Purchase Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Purchase Return], (select isnull(sum([Deducted Quantity]),0)  from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  Purchase.[Purchase ID]=[Product Transfer].[Purchase ID] and [Product Transfer].Status='Deducted'     group by [Purchase ID] )[Deducted] from Purchase  join Products on Purchase.[Product ID]=products.[Product ID]  join [Branch Information] on [Purchase].[Branch ID]=[Branch Information].[Branch ID]	  Join [Purchase Invoice] on [Purchase Invoice].[Purchase Invoice No]=[Purchase].[Purchase Invoice No] join [Supplier Information] on [Purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID] Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID]  Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID]  Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID]    where [Purchase].[Branch ID]= '" + FrmHome.lblBranchID.Text + "' and [Purchase].[Product ID]='" + ProductIDForSearchPurchaseSerialNumber + "' and [Purchase].[Purchase Invoice No]='" + PurchaseInvoiceNumber + "' or [Purchase].[Branch ID]= '" + FrmHome.lblBranchID.Text + "' and [Purchase].[Product ID]='" + ProductIDForSearchPurchaseSerialNumber + "' And SUBSTRING([Purchase].[Transfer Status],10,LEN([Purchase].[Transfer Status])-2)='" + PurchaseInvoiceNumber + "') as a  group by [Purchase Date],[Purchase ID],[Supplier Name],[Branch Name],[Product ID],[Product Name],[Purchase Cost],[Sale Price] having (isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))>0 order by [Purchase Date] asc"


                    dr4 = cmd4.ExecuteReader
                    dr4.Read()
                    If dr4.HasRows Then
                        PurchaseID = dr4.Item("Purchase ID").ToString

                    ElseIf Not dr4.HasRows Then
                        PurchaseID = "NO"
                    End If
                    dr4.Close()




                    dr3 = cmd3.ExecuteReader()
                    dr3.Read()

                    If Not dr3.HasRows Then
                        If Not PurchaseID = "NO" Then
                            'Insert into Purchase return and return serial number
                            Dim con As New SqlConnection
                            Dim cmd As New SqlCommand

                            con.ConnectionString = FrmHome.ConnectionString
                            con.Open()
                            cmd.Connection = con
                            cmd.CommandText = " INSERT INTO [Purchase Return] ([Returned Quantity],[Branch ID],[Purchase ID],[Purchase Return Invoice No],[Product ID]) VALUES ('" + row.Cells("Purchase Quantity").Value.ToString + "','" + FrmHome.lblBranchID.Text + "','" + PurchaseID + "','" + TxtPurchaseReturnInvoiceNo.Text + "','" + ProductIDForSearchReturnSerialNumber + "' )"
                            cmd.ExecuteNonQuery()
                            con.Close()

                            'If There is single serial number then
                            If GrdPurchaseSerialNumber.RowCount = 1 Then
                                'Insert And Update Into Purchase Serial Number And Purchase Serial Number
                                InsertAndUpdateIntoPurchaseReturnSerialNumberAndPurchaseSerialNumber()

                            End If
                            'Focus on Paid amount
                            TxtPaidAmount.Focus()
                        Else
                            MsgBox("Already Exists", MsgBoxStyle.OkOnly, "Purchase Return")
                        End If
                        'Refresh Purchase Return
                        RefreshPurchaseReturn()

                        'Search Purchase Return Serial Number
                        RefreshPurchaseReturnSerialNumber()

                    Else
                        MsgBox("No available stock.", MsgBoxStyle.Critical, "Purchase Return")

                    End If
                    dr3.Close()
                    con3.Close()

                Else

                    'Group Box Enable Making true
                    GrpPurchaseReturn.Enabled = True

                    If GrdPurchaseSerialNumber.RowCount > 1 Then

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


    Private Sub GrdSaleReturn_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdPurchaseReturn.CellContentClick

    End Sub

    Private Sub CmbSerialNumber_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbSerialNumber.KeyDown
        If e.KeyCode = Keys.Enter Then

            If CmbSerialNumber.Text = "" Then

                TxtPaidAmount.Focus()

            Else

                'Insert And Update Into Purchase Return Serial No And Purchase Serial No
                InsertAndUpdateIntoPurchaseReturnSerialNoAndPurchaseSerialNo()
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
            cmd2.CommandText = "Delete from [Purchase Return Invoice] where [Purchase Return Invoice No]= '" + TxtPurchaseReturnInvoiceNo.Text + "'"
            cmd.CommandText = "Delete from [Purchase Return] where [Purchase Return Invoice No]= '" + TxtPurchaseReturnInvoiceNo.Text + "'"

            cmd2.ExecuteNonQuery()
            cmd.ExecuteNonQuery()

            con2.Close()



            'Delete invoice from ledger
            DeleteinvoiceLedger()





            'Search Purchase Return Serial Number For Delete Invoice
            RefreshPurchaseReturnSerialNumberForDeleteInvoice()



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




            If Not TxtPurchaseReturnInvoiceNo.Text = "" Then

                Dim q As MsgBoxResult
                q = MsgBox("Do you really want to Delete Invoice?", MsgBoxStyle.YesNo, "Purchase Return")
                If q = MsgBoxResult.Yes Then

                    'Insert into log code For Delete
                    InsertIntoLogForDelete()

                    'Delete Full Invoice
                    DeleteFullInvoice()

                End If

            Else

                MsgBox("Please Insert Invoice Number First.", MsgBoxStyle.OkOnly, "Purchas Returne")

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

        Dim PurchaseReturnDetails As String
        Dim BillStatus As String
        Try
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd2.Connection = con
            cmd.CommandText = "Select SUBSTRING( ( SELECT   '-------'+  [Product Name],'  Returned Quantity : ',isnull(sum([Purchase Return].[Returned Quantity]),0)     FROM [Purchase Return] join products on [Purchase Return].[Product ID]=products.[Product ID]  where [Purchase Return Invoice No]='" + TxtPurchaseReturnInvoiceNo.Text + "'   group by [Product Name],[Purchase Return].[Returned Quantity] FOR XML PATH('') ), 2 , 9999) As [Purchase Return]"
            cmd2.CommandText = "Select [Status] From [Purchase Return Invoice] Where [Purchase Return Invoice No]='" + TxtPurchaseReturnInvoiceNo.Text + "'"

            'Data Reader For Find Sale Details
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                PurchaseReturnDetails = dr.Item("Purchase Return").ToString

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
            cmd1.CommandText = "INSERT INTO [Log Details]  ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES('" + Me.Text + "','DELETE', 'Supplier Name : " + CmbSupplierName.Text + " , Supplier ID : " + CmbSupplierName.ValueMember + " , Return Details :( " + PurchaseReturnDetails + ") Bill Status : " + BillStatus + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtPurchaseReturnInvoiceNo.Text + "' )"
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

        Dim PurchaseReturnDetails As String

        Try
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Select SUBSTRING( ( SELECT   '-------'+  [Product Name],'  Returned Quantity : ',isnull(sum([Purchase Return].[Returned Quantity]),0)     FROM [Purchase Return] join products on [Purchase Return].[Product ID]=products.[Product ID]  where [Purchase Return Invoice No]='" + TxtPurchaseReturnInvoiceNo.Text + "'   group by [Product Name],[Purchase Return].[Returned Quantity] FOR XML PATH('') ), 2 , 9999) As [Purchase Return]"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                PurchaseReturnDetails = dr.Item("Purchase Return").ToString

            End If
            dr.Close()
            con.Close()


            con1.ConnectionString = FrmHome.ConnectionString
            con1.Open()
            cmd1.Connection = con1
            cmd1.CommandText = "INSERT INTO [Log Details]  ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES('" + Me.Text + "','INSERT', 'Supplier Name : " + CmbSupplierName.Text + " , Supplier ID : " + CmbSupplierName.ValueMember + " , Return Details :( " + PurchaseReturnDetails + ")','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtPurchaseReturnInvoiceNo.Text + "' )"
            cmd1.ExecuteNonQuery()
            con1.Close()



        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally


        End Try
    End Sub




    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        TxtPaidAmount.Text = "00"
        cmbPaidBy.Text = "Due"


        'Search pending invoice and save in variable
        SearchPendingInvoice()

        If TxtPaidAmount.Text = "" Or cmbPaidBy.Text = "" Or Val(TxtPaidAmount.Text) < 0 Or Val(TxtPaidAmount.Text) > Val(TxtNetPayable.Text) Then
            MsgBox("Please Insert Valid Amount", MsgBoxStyle.Critical, "Purchase Return")
            TxtPaidAmount.Focus()
        Else


            'Send Value to purchase Invoice Variable
            RptPurchaseReturnInvoice.PurchaseInvoiceNo = PurchaseInvoiceNumber
            RptPurchaseReturnInvoice.PurchaseReturnInvoiceNo = TxtPurchaseReturnInvoiceNo.Text


            Dim q As MsgBoxResult
            q = MsgBox("Do you really want to save invoice?", MsgBoxStyle.YesNo, "Purchase Return")
            If q = MsgBoxResult.Yes Then

                'Insert into log code For Save
                InsertIntoLogForSave()

                'Update Purchase Return Invoice As Complete
                UpdatePurchaseReturnInvoiceToComplete()


                If cmbPaidBy.Text = "DUE" Then
                    'Delete invoice from ledger
                    DeleteinvoiceLedger()

                    'Update or insert Customer ledger For dues
                    InsertorUpdateCustomerLedgerForDues()



                Else
                    'Update or insert Customer ledger For dues
                    InsertorUpdateCustomerLedgerForDues()

                    'Update or insert  ledger For Cash Purchase
                    InsertorUpdateLedgerForCashPaidForPurchaseReturn()


                End If
                'Focus on Invoice number
                CmbSearch.Focus()

                If Not ShowInvoicePermission = "No" Then
                    'Open Invoice
                    RptPurchaseReturnInvoice.ShowInvoice()
                    RptPurchaseReturnInvoice.Show()

                End If

                'Clear All Data
                ClearAllData()



            End If
        End If
    End Sub
    Private Sub GrdSaleReturnSerialNumber_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdPurchaseReturnSerialNumber.CellContentDoubleClick

    End Sub

    Private Sub GrdSaleSerialNumber_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdPurchaseSerialNumber.CellContentClick

    End Sub

    Private Sub GrdSaleSerialNumber_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdPurchaseSerialNumber.CellMouseDoubleClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.GrdPurchaseSerialNumber.Rows(e.RowIndex)

            GrpPurchaseReturn.Enabled = True
            CmbSerialNumber.Text = row.Cells("Purchase Serial Number").Value.ToString

            'Insert And Update Into Purchase Return Serial No And Purchase Serial No
            InsertAndUpdateIntoPurchaseReturnSerialNoAndPurchaseSerialNo()


            CmbSerialNumber.Focus()
        End If


    End Sub

    Private Sub GrdSaleReturnSerialNumber_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdPurchaseReturnSerialNumber.CellMouseDoubleClick
        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow
            row = Me.GrdPurchaseReturnSerialNumber.Rows(e.RowIndex)



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
            cmd.CommandText = "Update [Purchase Serial Number] set [Status]='Available'  where [Product ID]= '" + ProductIDForSearchReturnSerialNumber + "' And [Purchase Serial Number]= '" + row.Cells("Purchase Return Serial Number").Value.ToString + "' "
            cmd2.CommandText = "Delete from [Purchase Return Serial] where [Product ID]= '" + ProductIDForSearchReturnSerialNumber + "' And [Purchase Return Serial Number]= '" + row.Cells("Purchase Return Serial Number").Value.ToString + "' And [Purchase Return Invoice No] = '" + TxtPurchaseReturnInvoiceNo.Text + "' "

            cmd.ExecuteNonQuery()
            cmd2.ExecuteNonQuery()
            con.Close()

            'Refresh Sal Return Serial Number
            RefreshPurchaseReturnSerialNumber()

            'Count row after adding serial number
            TxtReturnedQuantity.Text = GrdPurchaseReturnSerialNumber.RowCount

            'Insert Or Update Into Purchase Return For More Then One Quantity
            InsertOrUpdateIntoPurchaseReturnForMoreThenOneQuantity()

            'Refresh Purchase Return
            RefreshPurchaseReturn()

            'Net Payable Calculate
            NetPayable()

            'Focus on Paid amount
            TxtPaidAmount.Focus()
        End If


    End Sub

    Private Sub GrdSaleReturnSerialNumber_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdPurchaseReturnSerialNumber.CellContentClick

    End Sub

    Private Sub BtnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewInvoice.Click


        If Not TxtPurchaseReturnInvoiceNo.Text = "" And Not PurchaseReturnEditStatus = True Then

            Dim q As MsgBoxResult = MsgBox("Do you want to keep this Invoice as draft?", MsgBoxStyle.YesNoCancel, "Purchase Return")

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




        ElseIf Not TxtPurchaseReturnInvoiceNo.Text = "" And PurchaseReturnEditStatus = True Then

            If (MessageBox.Show(" Are you sure want to creat new invoice?", "Bizpro", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then


                'Clear All Data
                ClearAllData()



                'Focus on search combobx
                CmbSearch.Focus()

            End If
        ElseIf TxtPurchaseReturnInvoiceNo.Text = "" Then

            'Clear All Data
            ClearAllData()

        End If

    End Sub



    Private Sub TxtSaleReturnInvoiceNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPurchaseReturnInvoiceNo.TextChanged

    End Sub

    Private Sub GrpCustomerInformation_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrpSupplierInformation.Enter

    End Sub

    Private Sub GrdSaleInvoice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdPurchaseInvoice.KeyDown

    End Sub

    Private Sub GrpCustomerInformation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GrpSupplierInformation.KeyPress

    End Sub

    Private Sub CmbCustomerName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbSupplierName.KeyDown

    End Sub

    Private Sub CmbCustomerName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbSupplierName.KeyPress
        e.Handled = True
    End Sub

    Private Sub CmbCustomerName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSupplierName.SelectedIndexChanged

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
        FrmPurchaseReturnHistory.Show()
        FrmPurchaseReturnHistory.TxtSearchPurchaseReturnInvoice.Focus()
    End Sub

    Private Sub BtnInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInvoice.Click


        'Send Value to purchase Invoice Variable
        RptPurchaseReturnInvoice.PurchaseInvoiceNo = PurchaseInvoiceNumber
        RptPurchaseReturnInvoice.PurchaseReturnInvoiceNo = TxtPurchaseReturnInvoiceNo.Text

        If Not ShowInvoicePermission = "No" Then
            'Open Invoice
            RptPurchaseReturnInvoice.ShowInvoice()
            RptPurchaseReturnInvoice.Show()
        Else

            MsgBox("You do not have permission to open invoice.")
        End If

    End Sub

    Private Sub GrdPurchaseSerialNumber_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdPurchaseSerialNumber.KeyDown

    End Sub

    Private Sub GrpSaleReturnInvoice_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrpSaleReturnInvoice.Enter

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick



        Try

            Dim con As New SqlConnection
            Dim con1 As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand

            Dim dr As SqlDataReader


            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now

            Dim cmd3 As New SqlCommand
            Dim dr3 As SqlDataReader

            Dim QuantityOfFirsttRow As String
            Dim purchaseIDOfFirstRow As String


            'Data reader for Product Id
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd1.Connection = con
            cmd.Connection = con
            cmd3.Connection = con
            cmd.CommandText = "SELECT  isnull(sum([Returned Quantity]),0)[Returned Quantity] FROM [Purchase Return]  WHERE  [Product ID]='" + ProductIDForSearchReturnSerialNumber + "' And [Purchase Return Invoice No]= '" + TxtPurchaseReturnInvoiceNo.Text + "'"
            cmd3.CommandText = "select  [Purchase Date],[Purchase ID],[Supplier Name],[Product ID],[Product Name],[Branch Name],[Purchase Cost],[Sale Price],(isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))[Stock Available]from (select  [Purchase].[Purchase Date],Purchase.[Purchase ID],[Supplier Information].[Supplier Name],[Products].[Product ID],[Products].[Product Name],[Branch Information].[Branch Name],[Branch Information].[Branch ID],Purchase.[Purchase Unit Cost][Purchase Cost],[Products].[Sale Price],case when [Purchase Quantity] =0  then (select isnull(sum( [Added Quantity]),0)[Added Quantity] from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  [Product Transfer].[Purchase ID]=Purchase.[Purchase ID] and [Product Transfer].Status='Added' and   [Product Transfer Invoice].Status='Complete'  and [Product Transfer].[Product ID]=Purchase.[Product ID]  group by [Purchase ID] )  ELSE isnull([Purchase].[Purchase Quantity],0) end [Purchase] ,(select isnull(sum([Sale Quantity]),0)      from  sale join [Sale Invoice] on sale.[Sale Invoice No]= [Sale Invoice].[Sale Invoice No] where Sale.[Branch ID]='" + FrmHome.lblBranchID.Text + "' and Sale.[Purchase ID]=Purchase.[Purchase ID]  group by [Purchase ID])[Sale],(select isnull(sum([Returned Quantity]),0)  from [Sale Return] join [Sale Return Invoice] on [Sale Return].[Sale Return Invoice No]=[Sale Return Invoice].[Sale Return Invoice No] where  [Sale Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Sale Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Sale Return],(select isnull(sum([Returned Quantity]),0)  from [Purchase Return] join [Purchase Return Invoice] on [Purchase Return].[Purchase Return Invoice No]=[Purchase Return Invoice].[Purchase Return Invoice No] where [Purchase Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Purchase Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Purchase Return], (select isnull(sum([Deducted Quantity]),0)  from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  Purchase.[Purchase ID]=[Product Transfer].[Purchase ID] and [Product Transfer].Status='Deducted'     group by [Purchase ID] )[Deducted] from Purchase  join Products on Purchase.[Product ID]=products.[Product ID]  join [Branch Information] on [Purchase].[Branch ID]=[Branch Information].[Branch ID]	  Join [Purchase Invoice] on [Purchase Invoice].[Purchase Invoice No]=[Purchase].[Purchase Invoice No] join [Supplier Information] on [Purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID] Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID]  Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID]  Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID]    where [Purchase].[Branch ID]= '" + FrmHome.lblBranchID.Text + "' and [Purchase].[Product ID]='" + ProductIDForSearchPurchaseSerialNumber + "' and [Purchase].[Purchase Invoice No]='" + PurchaseInvoiceNumber + "' or [Purchase].[Branch ID]= '" + FrmHome.lblBranchID.Text + "' and [Purchase].[Product ID]='" + ProductIDForSearchPurchaseSerialNumber + "' And SUBSTRING([Purchase].[Transfer Status],10,LEN([Purchase].[Transfer Status])-2)='" + PurchaseInvoiceNumber + "') as a  group by [Purchase Date],[Purchase ID],[Supplier Name],[Branch Name],[Product ID],[Product Name],[Purchase Cost],[Sale Price] having (isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))>0 order by [Purchase Date] asc"

            dr3 = cmd3.ExecuteReader()
            dr3.Read()
            If dr3.HasRows Then
                QuantityOfFirsttRow = dr3.Item("Stock Available").ToString
                purchaseIDOfFirstRow = dr3.Item("Purchase ID").ToString

            End If
            dr3.Close()


            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then


                If Val(dr.Item("Returned Quantity").ToString) >= Val(QuantityWritten) Then

                    Timer1.Stop()

                    'Clear data Product
                    ClearDataPurchaseReturn()
                    GrdPurchaseReturnSerialNumber.Columns.Clear()

                ElseIf Val(dr.Item("Returned Quantity").ToString) < Val(QuantityWritten) Then




                    Dim QuantityRemaining As String
                    QuantityRemaining = Val(QuantityWritten) - Val(dr.Item("Returned Quantity").ToString)

                    If Val(QuantityOfFirsttRow) > Val(QuantityRemaining) Then
                        TxtReturnedQuantity.Text = QuantityRemaining


                    Else
                        TxtReturnedQuantity.Text = QuantityOfFirsttRow
                    End If

                    If Not TxtPurchaseReturnInvoiceNo.Text = "" Then
                        con1.ConnectionString = FrmHome.ConnectionString
                        con1.Open()
                        cmd1.Connection = con1
                        cmd1.CommandText = "INSERT INTO [Purchase Return] ([Returned Quantity],[Branch ID],[Purchase ID],[Purchase Return Invoice No],[Product ID]) VALUES ('" + TxtReturnedQuantity.Text + "','" + FrmHome.lblBranchID.Text + "','" + purchaseIDOfFirstRow + "','" + TxtPurchaseReturnInvoiceNo.Text + "','" + ProductIDForSearchReturnSerialNumber + "' )"
                        cmd1.ExecuteNonQuery()
                        con1.Close()


                        RefreshPurchaseReturn()
                    End If
                End If
            ElseIf Not dr.HasRows Then
                TxtReturnedQuantity.Text = QuantityOfFirsttRow


                If Not TxtPurchaseReturnInvoiceNo.Text = "" Then
                    con1.ConnectionString = FrmHome.ConnectionString
                    con1.Open()
                    cmd1.Connection = con1
                    cmd1.CommandText = "INSERT INTO [Purchase Return] ([Returned Quantity],[Branch ID],[Purchase ID],[Purchase Return Invoice No],[Product ID]) VALUES ('" + TxtReturnedQuantity.Text + "','" + FrmHome.lblBranchID.Text + "','" + purchaseIDOfFirstRow + "','" + TxtPurchaseReturnInvoiceNo.Text + "','" + ProductIDForSearchReturnSerialNumber + "' )"
                    cmd1.ExecuteNonQuery()
                    con1.Close()
                    RefreshPurchaseReturn()
                End If
            End If




            dr.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Btnclose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnclose.Click
        Me.Close()
    End Sub
    Private Sub Panel1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    End Sub
    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub
    Private Sub Btnmaximized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Btnminimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Btnmaximized_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnmaximized.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal

        Else
            Me.WindowState = FormWindowState.Maximized

        End If
    End Sub

    Private Sub Btnminimized_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnminimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel1_MouseMove1(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= (X)
            newpoint.Y -= (Y)
            Me.Location = newpoint

        End If
    End Sub

    Private Sub Panel1_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class