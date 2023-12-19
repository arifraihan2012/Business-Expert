Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.IO.Ports


Public Class FrmProductLifeCycle
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point

    Private Sub cmbProductName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbProductName.KeyDown
        If e.KeyCode = Keys.Enter Then

            'Clear Data Product For add new Product
            CleardataForNewSearch()

            FrmListofProducts.Show()
            FrmListofProducts.TxtSearchProductName.Focus()
            FrmListofProducts.Label1.Text = "Product Life Cycle"

        End If
    End Sub
    Sub CleardataForNewSearch()

        GrdPurchaseDetails.Columns.Clear()
        GrdPurchaseReturnDetails.Columns.Clear()
        GrdSaleDetails.Columns.Clear()
        GrdSaleReturnDetails.Columns.Clear()
        GrdProductTransferFrom.Columns.Clear()
        GrdProductTransferTo.Columns.Clear()


    End Sub
    Sub ClearAllData()

        GrdPurchaseDetails.Columns.Clear()
        GrdPurchaseReturnDetails.Columns.Clear()
        GrdSaleDetails.Columns.Clear()
        GrdSaleReturnDetails.Columns.Clear()
        GrdProductTransferFrom.Columns.Clear()
        GrdProductTransferTo.Columns.Clear()


        DtpFromDate.Value = "1/1/2015"
        DtpTodate.Value = Now
    End Sub

    Private Sub cmbProductName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProductName.SelectedIndexChanged

    End Sub

    Private Sub FrmProductLifeCycle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Location = New Point(0, 0)
        Me.Size = My.Computer.Screen.WorkingArea.Size

        ClearAllData()

        GrdPurchaseDetails.Width = (Me.Width / 2) - 15
        GrdPurchaseReturnDetails.Width = GrdPurchaseDetails.Width
        GrdSaleDetails.Width = GrdPurchaseDetails.Width
        GrdSaleReturnDetails.Width = GrdPurchaseDetails.Width
        GrdProductTransferFrom.Width = GrdPurchaseDetails.Width
        GrdProductTransferTo.Width = GrdPurchaseDetails.Width

    End Sub
    'Search Purchase Details()
    Sub SearchPurchaseDetails()
        ' Load Data
        Try



            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select Purchase.[Purchase Date][Date],[Supplier Information].[Supplier Name],[Purchase].[Purchase Invoice No][Invoice No],[Branch Information].[Branch Name], cast(CAST(Purchase.[Purchase Quantity] as decimal(18,5)) as float)[Quantity],cast(CAST(Purchase.[Purchase Unit Cost] as decimal(18,5)) as float)[Unit Cost],cast(CAST(Purchase.[Amount] as decimal(18,5))as float) [Amount]  from purchase join Products on Purchase.[Product ID]=products.[Product ID] join [Branch Information] on Purchase.[Branch ID]=[Branch Information].[Branch ID]  join [Purchase Invoice] on [purchase].[Purchase Invoice No]=[Purchase Invoice].[Purchase Invoice No]  join [Supplier Information] on [Purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID] Where  Purchase.[Product ID]='" + cmbProductName.ValueMember + "' And   Purchase.[Purchase Date] between '" + DtpFromDate.Value + "' And '" + DtpTodate.Value + "' and ([Purchase Invoice].[Status]='Complete' or [Purchase Invoice].[Status]= 'Opening" + FrmHome.lblBranchID.Text + "')  and [purchase].[Branch ID]='" + FrmHome.lblBranchID.Text + "'"


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Purchase")
            connection.Close()
            GrdPurchaseDetails.DataSource = ds
            GrdPurchaseDetails.DataMember = "BizPro_Purchase"


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            GrdPurchaseDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill



            Dim Total As String = 0
            Dim Total1 As String = 0
            For i As Integer = 0 To GrdPurchaseDetails.RowCount - 1
                Total += GrdPurchaseDetails.Rows(i).Cells(6).Value
                Total1 += GrdPurchaseDetails.Rows(i).Cells(4).Value

            Next

            LblTotalPurchaeAmount.Text = Total
            LblTotalPurchaseQuantity.Text = Total1


        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records")
        Finally

        End Try

        'End Refresh Data
    End Sub
    'Search Sale Details()
    Sub SearchSaleDetails()
        ' Load Data
        Try



            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select [Sale Invoice].[Sale Date][Date],[Customer Information].[Customer Name],Sale.[Sale Invoice No][Invoice No],[Branch Information].[Branch Name],cast(cast(Sale.[Sale Quantity] as decimal (18,5)) as Float)[Quantity] ,Cast(Cast(Sale.[Sale Unit Price] as Decimal(18,5))as Float)[Unit Price], cast(cast(Sale.[Sale Amount] as Decimal (18,5)) as Float)[Amount]  from Sale join Products on Sale.[Product ID]=products.[Product ID] join [Branch Information] on Sale.[Branch ID]=[Branch Information].[Branch ID] join [Sale Invoice] on sale.[Sale Invoice No]=[Sale Invoice].[Sale Invoice No] join [Customer Information] on [Sale Invoice].[Customer ID]=[Customer Information].[Customer ID] Where Sale.[Product ID]='" + cmbProductName.ValueMember + "' and [Sale Invoice].[Sale Date] between '" + DtpFromDate.Value + "' And '" + DtpTodate.Value + "' and [Sale Invoice].[Status]='Complete' and [sale].[branch id]='" + FrmHome.lblBranchID.Text + "'"


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Sale")
            connection.Close()
            GrdSaleDetails.DataSource = ds
            GrdSaleDetails.DataMember = "BizPro_Sale"


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            GrdSaleDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            Dim Total As String = 0
            Dim Total1 As String = 0
            For i As Integer = 0 To GrdSaleDetails.RowCount - 1
                Total += GrdSaleDetails.Rows(i).Cells(6).Value
                Total1 += GrdSaleDetails.Rows(i).Cells(4).Value
            Next

            LblTotalSaleAmount.Text = Total
            LblTotalSaleQuantity.Text = Total1



        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records")
        Finally

        End Try

        'End Refresh Data
    End Sub
    'Search Purchase Return Details()
    Sub SearchPurchaseReturnDetails()
        ' Load Data
        Try



            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select [Purchase Return Invoice].[Return Date][Date],[Purchase Return].[Purchase Return Invoice No][Return Invoice No],[Purchase Return Invoice].[Purchase Invoice No],[Supplier Information].[Supplier Name],cast(cast([Purchase Return].[Returned Quantity] as decimal(18,5)) as float)[Quantity] , cast(cast(Purchase.[Purchase Unit Cost] as decimal(18,5)) as Float)[Unit Cost], cast(cast( [Purchase Return].[Returned Quantity]* Purchase.[Purchase Unit Cost] as decimal(18,5)) as float)[Amount]from [Purchase Return] join [Purchase Return Invoice] on [Purchase Return].[Purchase Return Invoice No]=[Purchase Return Invoice].[Purchase Return Invoice No] join Purchase on [Purchase Return].[Purchase ID]=Purchase.[Purchase ID] join products on  Purchase.[Product ID]=products.[Product ID] join [Supplier Information] on [Purchase Return Invoice].[Supplier ID]=[Supplier Information].[Supplier ID]  Where products.[Product ID]='" + cmbProductName.ValueMember + "' and [Purchase Return Invoice].[Return Date] between '" + DtpFromDate.Value + "' And '" + DtpTodate.Value + "' and [Purchase Return Invoice].[Status]='Complete' and [purchase return].[branch id]='" + FrmHome.lblBranchID.Text + "'"


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Purchase Return")
            connection.Close()
            GrdPurchaseReturnDetails.DataSource = ds
            GrdPurchaseReturnDetails.DataMember = "BizPro_Purchase Return"


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            GrdPurchaseReturnDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            Dim Total As String = 0
            For i As Integer = 0 To GrdPurchaseReturnDetails.RowCount - 1
                Total += GrdPurchaseReturnDetails.Rows(i).Cells(4).Value
            Next
            LblTotalPurchaseReturnQuantity.Text = Total



        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records")
        Finally

        End Try

        'End Refresh Data
    End Sub
    'Search Sale Return Details()
    Sub SearchSaleReturnDetails()
        ' Load Data
        Try



            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select [Sale Return Invoice].[Return Date][Date],[Sale Return].[Sale Return Invoice No][Return Invoice No],[Sale Return Invoice].[Sale Invoice No],[Customer Information].[Customer Name],cast(cast([Sale Return].[Returned Quantity] as decimal (18,5)) as Float)[Quantity] ,cast (cast(sale.[Sale Unit Price] as decimal (18,5)) as float)[Unit Price], cast(cast([Sale Return].[Returned Quantity]*sale.[Sale Unit Price] as decimal (18,5)) as float)[Amount] from [Sale Return] join [Sale Return Invoice] on [Sale Return].[Sale Return Invoice No]=[Sale Return Invoice].[Sale Return Invoice No]  join Sale on [Sale Return].[Purchase ID]=sale.[Purchase ID] join products on  Sale.[Product ID]=products.[Product ID]  join [Customer Information] on [Sale Return Invoice].[Customer ID]=[Customer Information].[Customer ID] where  [Sale Return Invoice].[Status]='Complete' and Sale.[Product ID]='" + cmbProductName.ValueMember + "' and [Sale return].[branch id]='" + FrmHome.lblBranchID.Text + "' and [Sale Return Invoice].[Return Date] between '" + DtpFromDate.Value + "' And '" + DtpTodate.Value + "' and [Sale Return].[Purchase ID]=sale.[Purchase ID] and [Sale Return Invoice].[Sale Invoice No] =Sale.[Sale Invoice No] group by [Sale Return Invoice].[Return Date],[Sale Return].[Sale Return Invoice No],[Sale Return Invoice].[Sale Invoice No],[Customer Information].[Customer Name],[Sale Return].[Returned Quantity] ,sale.[Sale Unit Price],[Sale Return].[Returned Quantity]*sale.[Sale Unit Price]"


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Sale Return")
            connection.Close()
            GrdSaleReturnDetails.DataSource = ds
            GrdSaleReturnDetails.DataMember = "BizPro_Sale Return"


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            GrdSaleReturnDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


            Dim Total As String = 0
            For i As Integer = 0 To GrdSaleReturnDetails.RowCount - 1
                Total += GrdSaleReturnDetails.Rows(i).Cells(4).Value

            Next
            LblTotalSaleReturnQuantity.Text = Total

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records")
        Finally

        End Try

        'End Refresh Data
    End Sub
    'Search Product Transfered From This Branch
    Sub SearchProductTransferedFromThisBranch()
        ' Load Data
        Try



            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select [Product Transfer Invoice].[Transfer Date][Date], [Product Transfer Invoice].[Transfer Invoice No][Invoice No], [Branch Information].[Branch Name][Transferred To],[Product Transfer].[Added Quantity][Quantity] from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No] = [Product Transfer Invoice].[Transfer Invoice No] join [Branch Information] on [Product Transfer].[Transfer Branch ID] = [Branch Information].[Branch ID] where [Product Transfer].[Product ID] = '" + cmbProductName.ValueMember + "' and  [Product Transfer Invoice].[Branch ID] = '" + FrmHome.lblBranchID.Text + "' and [Product Transfer].[Status] = 'Added' and [Product Transfer Invoice].[Transfer Date] between '" + DtpFromDate.Value + "' and '" + DtpTodate.Value + "'  and [Product Transfer Invoice].[Status] = 'Complete' order by [Product Transfer Invoice].[Transfer Invoice No] desc"


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Product Transfer")
            connection.Close()
            GrdProductTransferFrom.DataSource = ds
            GrdProductTransferFrom.DataMember = "BizPro_Product Transfer"


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            GrdProductTransferFrom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


            Dim Total As String = 0
            For i As Integer = 0 To GrdProductTransferFrom.RowCount - 1
                Total += GrdProductTransferFrom.Rows(i).Cells(3).Value

            Next
            LblTotalTransferFrom.Text = Total

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records")
        Finally

        End Try

        'End Refresh Data
    End Sub
    'Show Available stock to lable
    Sub ShowTotalQuantityInLable()


        Try
            Dim con As New SqlConnection
            Dim cmd1 As New SqlCommand
            Dim cmd2 As New SqlCommand
            Dim cmd As New SqlCommand
            Dim dr1 As SqlDataReader
            Dim dr2 As SqlDataReader
            Dim dr As SqlDataReader



            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "select isnull(sum([Stock Available]),0)[Stock Available]  from (select [Purchase Date],[Purchase ID],[Supplier Name],[Product ID],[Product Name],[Branch Name],[Purchase Cost],[Sale Price],(isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))[Stock Available]from (select [Purchase].[Purchase Date],Purchase.[Purchase ID],[Supplier Information].[Supplier Name],[Products].[Product ID],[Products].[Product Name],[Branch Information].[Branch Name],[Branch Information].[Branch ID],Purchase.[Purchase Unit Cost][Purchase Cost],[Products].[Sale Price],case when [Purchase Quantity] =0  then (select isnull(sum( [Added Quantity]),0)[Added Quantity] from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  [Product Transfer].[Purchase ID]=Purchase.[Purchase ID] and [Product Transfer].Status='Added' and   [Product Transfer Invoice].Status='Complete'  and [Product Transfer].[Product ID]=Purchase.[Product ID]  group by [Purchase ID] )  ELSE isnull([Purchase].[Purchase Quantity],0) end [Purchase] ,(select isnull(sum([Sale Quantity]),0)      from  sale join [Sale Invoice] on sale.[Sale Invoice No]= [Sale Invoice].[Sale Invoice No] where Sale.[Branch ID]='" + FrmHome.lblBranchID.Text + "' and Sale.[Purchase ID]=Purchase.[Purchase ID]  group by [Purchase ID])[Sale],(select isnull(sum([Returned Quantity]),0)  from [Sale Return] join [Sale Return Invoice] on [Sale Return].[Sale Return Invoice No]=[Sale Return Invoice].[Sale Return Invoice No] where  [Sale Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Sale Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Sale Return],(select isnull(sum([Returned Quantity]),0)  from [Purchase Return] join [Purchase Return Invoice] on [Purchase Return].[Purchase Return Invoice No]=[Purchase Return Invoice].[Purchase Return Invoice No] where [Purchase Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Purchase Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Purchase Return], (select isnull(sum([Deducted Quantity]),0)  from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  Purchase.[Purchase ID]=[Product Transfer].[Purchase ID] and [Product Transfer].Status='Deducted'     group by [Purchase ID] )[Deducted]from Purchase  join Products on Purchase.[Product ID]=products.[Product ID]  join [Branch Information] on [Purchase].[Branch ID]=[Branch Information].[Branch ID]	  Join [Purchase Invoice] on [Purchase Invoice].[Purchase Invoice No]=[Purchase].[Purchase Invoice No]  join [Supplier Information] on [Purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID]  Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID]   Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID]   Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID]    where Purchase.[Branch ID]='" + FrmHome.lblBranchID.Text + "' and products. [Product ID] = '" + Me.cmbProductName.ValueMember + "') as a   group by [Purchase Date],[Purchase ID],[Supplier Name],[Branch Name],[Product ID],[Product Name],[Purchase Cost],[Sale Price] having (isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0)) -(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0)) >0 ) as a "

            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then


                lblCurrentStock.Text = (Val(dr.Item("stock Available").ToString))
            End If

            dr.Close()
            con.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Search Product Transfered To This Branch
    Sub SearchProductTransferedToThisBranch()
        ' Load Data
        Try



            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select [Product Transfer Invoice].[Transfer Date][Date], [Product Transfer Invoice].[Transfer Invoice No][Invoice No], [Branch Information].[Branch Name][Transferred To],[Product Transfer].[Added Quantity][Quantity] from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No] = [Product Transfer Invoice].[Transfer Invoice No] join [Branch Information] on [Product Transfer Invoice].[Branch ID] = [Branch Information].[Branch ID] where [Product Transfer].[Product ID] = '" + cmbProductName.ValueMember + "' and  [Product Transfer].[Transfer Branch ID] = '" + FrmHome.lblBranchID.Text + "' and [Product Transfer].[Status] = 'Added' and [Product Transfer Invoice].[Transfer Date] between '" + DtpFromDate.Value + "' and '" + DtpTodate.Value + "'  and [Product Transfer Invoice].[Status] = 'Complete' order by [Product Transfer Invoice].[Transfer Invoice No] desc"


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Product Transfer")
            connection.Close()
            GrdProductTransferTo.DataSource = ds
            GrdProductTransferTo.DataMember = "BizPro_Product Transfer"


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            GrdProductTransferTo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


            Dim Total As String = 0
            For i As Integer = 0 To GrdProductTransferTo.RowCount - 1
                Total += GrdProductTransferTo.Rows(i).Cells(3).Value

            Next
            LblTotalTransferTo.Text = Total

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records")
        Finally

        End Try

        'End Refresh Data
    End Sub
    'Insert into log 
    Sub InsertIntoLog()

        'Data Insert Code
        Dim con As New SqlConnection
        Dim con1 As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim CurrentDate As DateTime = DateTime.Today
        Dim CurrentTime As DateTime = DateTime.Now

        Try
            

            con1.ConnectionString = FrmHome.ConnectionString
            con1.Open()
            cmd1.Connection = con1
            cmd1.CommandText = "INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES ('" + Me.Text + "','SEARCH',' Product Name: " + cmbProductName.Text + "  is been sarched by " + FrmHome.LblUserName.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + cmbProductName.ValueMember + "' )"
            cmd1.ExecuteNonQuery()
            con1.Close()







        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally


        End Try
    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        'Search Purchase Details()
        SearchPurchaseDetails()

        'Search Sale Details()
        SearchSaleDetails()

        'Search Purchase Return Details()
        SearchPurchaseReturnDetails()

        'Search Sale Return Details()
        SearchSaleReturnDetails()

        'Search Product Transfered From This Branch
        SearchProductTransferedFromThisBranch()

        'Search Product Transfered To This Branch
        SearchProductTransferedToThisBranch()

        'Insert into log 
        InsertIntoLog()

        'Show Available stock to lable
        ShowTotalQuantityInLable()
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

    Private Sub GrdPurchaseDetails_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdPurchaseReturnDetails_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub




    Private Sub GrdSaleDetails_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdSaleReturnDetails_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

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

    Private Sub GrdPurchaseReturnDetails_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdPurchaseReturnDetails.CellContentClick

    End Sub

    Private Sub GrdSaleDetails_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdSaleDetails.CellContentClick

    End Sub
End Class