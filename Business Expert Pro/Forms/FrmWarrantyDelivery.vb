Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class FrmWarrantyDelivery
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point

    Dim ProductID As String
    Dim WarrantySerialID As String
    Dim WarrantyID As String


    Private Sub FrmWarrantyDelivery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 0)
        Me.Size = My.Computer.Screen.WorkingArea.Size

        'Clear All Data
        ClearData()
    End Sub

    Private Sub CmbSearchBy_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub CmbSearchBy_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True

    End Sub

    'Clear Data
    Sub ClearData()

        TxtSearch.Text = ""
        TxtSerialNumber.Text = ""

        DtpDeliveryDate.Value = Now
        LblCustomerName.Text = "None"
        LblPhoneNoCustomer.Text = "None"
        LblAddressCustomer.Text = "None"
        LblRemarks.Text = "None"


        GrdProductsDetails.Columns.Clear()
        GrdWarrantySerialNumber.Columns.Clear()
        GrdProblemDetails.Columns.Clear()

        GrdDeliveryDetails.Columns.Clear()
        GrdDeliverySerial.Columns.Clear()


        TxtWarrantyDeliveryInvoiceNo.Text = ""


        TxtReplacedSerialNumber.Visible = False
        LblReplacedSerialNumber.Visible = False

    End Sub
    'Clear Data To Search Invoice Number Again
    Sub ClearDataToSearchInvoiceNumberAgain()


        TxtSerialNumber.Text = ""

        DtpDeliveryDate.Value = Now
        LblCustomerName.Text = "None"
        LblPhoneNoCustomer.Text = "None"
        LblAddressCustomer.Text = "None"
        LblRemarks.Text = "None"


        GrdProductsDetails.Columns.Clear()
        GrdWarrantySerialNumber.Columns.Clear()
        GrdProblemDetails.Columns.Clear()

        GrdDeliveryDetails.Columns.Clear()
        GrdDeliverySerial.Columns.Clear()


        TxtWarrantyDeliveryInvoiceNo.Text = ""


        TxtReplacedSerialNumber.Visible = False
        LblReplacedSerialNumber.Visible = False

    End Sub
    'Clear Data After Delete Invoice
    Sub ClearDataAfterDeleteInvoice()


        TxtSerialNumber.Text = ""

        DtpDeliveryDate.Value = Now

        GrdDeliveryDetails.Columns.Clear()
        GrdDeliverySerial.Columns.Clear()


        TxtWarrantyDeliveryInvoiceNo.Text = ""

        TxtReplacedSerialNumber.Visible = False
        LblReplacedSerialNumber.Visible = False

    End Sub

    'Show Customer Information
    Sub ShowCustomerInformation()


        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader


            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Select * from [Warranty Invoice Number] Where [Warranty Invoice No]='" + TxtSearch.Text + "' "

            'Find Warranty Serial ID
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then

                LblCustomerName.Text = dr.Item("Complainer Name").ToString
                LblPhoneNoCustomer.Text = dr.Item("Complainer Mobile No").ToString
                LblAddressCustomer.Text = dr.Item("Address").ToString
                LblRemarks.Text = dr.Item("Remarks").ToString

            End If
            dr.Close()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Refresh Data Warranty Serial
    Sub RefreshWarrantyDetails()

        ' Load Data
        Try


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "Select Warranty.[Warranty ID],products.[Product Name], Warranty.[Warranty Quantity] from [Warranty] join [products] on Warranty.[Product ID]= products.[Product ID] Where Warranty.[Warranty Invoice No]='" + TxtSearch.Text + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Warranty")
            connection.Close()
            GrdProductsDetails.DataSource = ds
            GrdProductsDetails.DataMember = "BizPro_Warranty"

            'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdProductsDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill



        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try

        'End Refresh Data
    End Sub


    'Refresh Warrnaty Problem Details For Single Product
    Sub RefreshWarrantyProblemDetailsForSingleProduct()

        Try

            If GrdWarrantySerialNumber.RowCount = 1 Then


                Dim connectionString As String = FrmHome.ConnectionString
                Dim sql As String = "select [Problem Category].[Problem Category Name],[Warranty Problem Details].[Status] from [Warranty Problem Details]join [Problem Category] on  [Warranty Problem Details].[Problem ID]=[Problem Category].[Problem Category ID] Where [Warranty Invoice No]='" + TxtSearch.Text + "'"
                Dim connection As New SqlConnection(connectionString)
                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Warranty")
                connection.Close()
                GrdProblemDetails.DataSource = ds
                GrdProblemDetails.DataMember = "BizPro_Warranty"

                'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
                GrdProblemDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            End If


        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        End Try
    End Sub
    'RefreshWarrnatyProblemDetails
    Sub RefreshWarrantyProblemDetails()

        Try

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select [Problem Category].[Problem Category Name],[Warranty Problem Details].[Status] from [Warranty Problem Details]join [Problem Category] on  [Warranty Problem Details].[Problem ID]=[Problem Category].[Problem Category ID] Where [Warranty Serial ID]='" + WarrantySerialID + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Warranty")
            connection.Close()
            GrdProblemDetails.DataSource = ds
            GrdProblemDetails.DataMember = "BizPro_Warranty"

            'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdProblemDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        End Try
    End Sub
    'Refresh Data Warranty Serial
    Sub RefreshDataWarrantySerialNumber()

        ' Load Data
        Try


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select [Warranty Serial Number] from [Warranty Serial]  Where [Product ID]='" + ProductID + "' And [Warranty Invoice No]='" + TxtSearch.Text + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Warranty Serial")
            connection.Close()
            GrdWarrantySerialNumber.DataSource = ds
            GrdWarrantySerialNumber.DataMember = "BizPro_Warranty Serial"

            'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdWarrantySerialNumber.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill




        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try

        'End Refresh Data
    End Sub
    'Refresh Data Warranty Serial For Single Product
    Sub RefreshDataWarrantySerialNumberForSingleProduct()

        ' Load Data
        Try


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select [Warranty Serial Number] from [Warranty Serial]  Where  [Warranty Invoice No]='" + TxtSearch.Text + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Warranty Serial")
            connection.Close()
            GrdWarrantySerialNumber.DataSource = ds
            GrdWarrantySerialNumber.DataMember = "BizPro_Warranty Serial"

            'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdWarrantySerialNumber.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill




        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try

        'End Refresh Data
    End Sub


    'Insert or update Into Warranty Deliver Invoice code
    Sub InsertOrUpdateIntoWarrantyDeliverInvoice()

        'Insert Into Sale Invoice code
        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim con2 As New SqlConnection
            Dim cmd2 As New SqlCommand
            Dim dr1 As SqlDataReader

            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now



            If TxtWarrantyDeliveryInvoiceNo.Text = "" Then

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "INSERT INTO [Warranty Delivery Invoice] ([Warranty Invoice No],[Delivery Date],[Prepared Date],[Prepared Time],[Branch ID],[Computer ID],[User Account ID],[Status],[Remarks]) values ('" + TxtSearch.Text + "','" + DtpDeliveryDate.Value + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','INCOMPLETE','" + TxtRemarks.Text + "')"
                cmd.ExecuteNonQuery()
                con.Close()


                con2.ConnectionString = FrmHome.ConnectionString
                con2.Open()
                cmd2.Connection = con2
                cmd2.CommandText = "SELECT top 1 [Warranty Delivery Invoice No] FROM [Warranty Delivery Invoice] where [User Account ID]= '" + FrmHome.LblUserID.Text + "' AND [Computer ID]='" + FrmHome.LblComputerID.Text + "' AND [Branch ID]='" + FrmHome.lblBranchID.Text + "'  order by [Warranty Delivery Invoice No] desc"

                dr1 = cmd2.ExecuteReader()
                dr1.Read()
                If dr1.HasRows Then


                    TxtWarrantyDeliveryInvoiceNo.Text = (dr1.Item("Warranty Delivery Invoice No").ToString)
                End If
                con2.Close()
                dr1.Close()



            Else


                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "UPDATE  [Warranty Delivery Invoice] set [Status]='INCOMPLETE',[User Account ID]='" + FrmHome.LblUserID.Text + "',[Computer ID]='" + FrmHome.LblComputerID.Text + "',[Remarks]='" + TxtRemarks.Text + "' where [Warranty Delivery Invoice No] = '" + TxtWarrantyDeliveryInvoiceNo.Text + "' "
                cmd.ExecuteNonQuery()
                con.Close()


            End If

        Catch ex As Exception
            MessageBox.Show("Error while Inserting to sale invoice record on table..." & ex.Message, "Insert Records Sale Invoice")
        Finally

        End Try

    End Sub

    'Refresh Data Warranty Delivery Details
    Sub RefreshWarrantyDeliveryDetails()

        ' Load Data
        Try


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "Select [Warranty Delivery].[Warranty Delivery ID],products.[Product Name], [Warranty Delivery].[Delivery Quantity] from [Warranty Delivery] join [products] on [Warranty Delivery].[Product ID]= products.[Product ID] Where [Warranty Delivery].[Warranty Delivery Invoice No]='" + TxtWarrantyDeliveryInvoiceNo.Text + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Warranty Delivery")
            connection.Close()
            GrdDeliveryDetails.DataSource = ds
            GrdDeliveryDetails.DataMember = "BizPro_Warranty Delivery"

            'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdDeliveryDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill



        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try

        'End Refresh Data
    End Sub

    'Insert or Update into Warranty Delivery
    Sub InsertOrUpdateIntoWarrantyDelivery()

        'Data Insert Code
        Dim con As New SqlConnection
        Dim con1 As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim cmd3 As New SqlCommand
        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now
        Dim dr As SqlDataReader


        Try

            'Empty Txt Box Can Not Be Save Code
            If TxtSerialNumber.Text = "" Then
                MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Warranty Look Up")

            Else

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd3.Connection = con
                cmd3.CommandText = "select *from [Warranty Delivery]  where [Warranty Delivery Invoice No]='" + TxtWarrantyDeliveryInvoiceNo.Text + "' And [Product ID] = '" + ProductID + "'"

                dr = cmd3.ExecuteReader
                dr.Read()

                If Not dr.HasRows Then

                    con1.ConnectionString = FrmHome.ConnectionString
                    con1.Open()
                    cmd.Connection = con1
                    cmd1.Connection = con1
                    cmd.CommandText = "INSERT INTO [Warranty Delivery] ([Warranty Delivery Invoice No],[Product ID],[Prepared Date],[Prepared Time],[Branch ID],[Computer ID],[User Account ID],[Delivery Quantity]) VALUES ('" + TxtWarrantyDeliveryInvoiceNo.Text + "','" + ProductID + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + GrdDeliverySerial.RowCount.ToString + "')"
                    cmd1.CommandText = "INSERT INTO [Log Details] ([Log Category],[Log Description],[User Account ID],[Log Date],[Log Time],[Task ID]) VALUES ('Bank Information','Data Inserted Successfully [" + LblCustomerName.Text + "]','" + FrmHome.LblUserID.Text + "','" + currentDate + "','" + currentTime + "','New Data Inserted')"
                    cmd.ExecuteNonQuery()
                    cmd1.ExecuteNonQuery()

                    con1.Close()


                    'Refresh Data Warranty Delivery Details
                    RefreshWarrantyDeliveryDetails()

                ElseIf dr.HasRows Then

                    con1.ConnectionString = FrmHome.ConnectionString
                    con1.Open()
                    cmd.Connection = con1
                    cmd1.Connection = con1
                    cmd.CommandText = "Update [Warranty Delivery] set [Product ID]='" + ProductID + "',[Prepared Date]='" + currentDate + "',[Prepared Time]='" + currentTime + "',[Branch ID]='" + FrmHome.lblBranchID.Text + "',[Computer ID]='" + FrmHome.LblComputerID.Text + "',[User Account ID]='" + FrmHome.LblUserID.Text + "',[Delivery Quantity]='" + GrdDeliverySerial.RowCount.ToString + "' Where [Warranty Delivery Invoice No]='" + TxtWarrantyDeliveryInvoiceNo.Text + "' And [Product ID] = '" + ProductID + "' "
                    cmd1.CommandText = "INSERT INTO [Log Details] ([Log Category],[Log Description],[User Account ID],[Log Date],[Log Time],[Task ID]) VALUES ('Bank Information','Data Inserted Successfully [" + LblCustomerName.Text + "]','" + FrmHome.LblUserID.Text + "','" + currentDate + "','" + currentTime + "','New Data Inserted')"
                    cmd.ExecuteNonQuery()
                    cmd1.ExecuteNonQuery()

                    con1.Close()


                    'Refresh Data Warranty Delivery Details
                    RefreshWarrantyDeliveryDetails()

                End If
                dr.Close()
                con.Close()




            End If

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally

        End Try
    End Sub

    'Search Product ID
    Sub SearchProductID()

        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader


            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Select * from [Warranty] Where [warranty ID]='" + WarrantyID + "' "

            'Find Warranty Serial ID
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then

                ProductID = dr.Item("Product ID").ToString

            End If
            dr.Close()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Sub SearchWarrantyInvoiceNoBySerial()

        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader


            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Select * from [Warranty Serial] Where [Warranty Serial Number]='" + TxtSerialNumber.Text + "' "

            'Find Warranty Serial ID
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then

                TxtSearch.Text = dr.Item("Warranty Invoice No").ToString

            End If
            dr.Close()
            con.Close()

            SearchWarrantyInvoiceNumber()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Insert Data into Delivery Serial Number 
    Sub InsertIntoDeliverySerialNumber()




        Try

            'Empty Txt Box Can Not Be Save Code
            If TxtSerialNumber.Text = "" Or Val(ProductID) = 0 Then
                MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Warranty Look Up")

            Else


                'Data Insert Code
                Dim con As New SqlConnection
                Dim con1 As New SqlConnection
                Dim cmd As New SqlCommand
                Dim cmd1 As New SqlCommand
                Dim cmd2 As New SqlCommand

                Dim Dr As SqlDataReader

                Dim currentDate As DateTime = DateTime.Today
                Dim currentTime As DateTime = DateTime.Now


                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd2.Connection = con1
                cmd2.CommandText = "Select * from [Warranty Delivery Invoice] join [Warranty Delivery Serial] on [Warranty Delivery Invoice].[Warranty Delivery Invoice No]=[Warranty Delivery Serial].[Warranty Delivery Invoice No]  Where [Warranty Delivery Serial].[Product ID]='" + ProductID + "' And [Warranty Delivery Invoice].[Warranty Invoice No]='" + TxtSearch.Text + "' And [Warranty Delivery Serial].[Delivery Serial Number]='" + TxtSerialNumber.Text + "' "
                Dr = cmd2.ExecuteReader
                Dr.Read()


                If Not Dr.HasRows Then

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd1.Connection = con
                    cmd.CommandText = "INSERT INTO [Warranty Delivery Serial] ([Warranty Delivery Invoice No],[Product ID],[Delivery Serial Number],[Prepared Date],[Prepared Time],[Branch ID],[Computer ID],[User Account ID],[Replacement Product ID],[Replacement Serial Number]) VALUES ('" + TxtWarrantyDeliveryInvoiceNo.Text + "','" + ProductID + "','" + TxtSerialNumber.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + ProductID + "','" + TxtReplacedSerialNumber.Text + "')"
                    cmd1.CommandText = "INSERT INTO [Log Details] ([Log Category],[Log Description],[User Account ID],[Log Date],[Log Time],[Task ID]) VALUES ('Bank Information','Data Inserted Successfully [" + LblCustomerName.Text + "]','" + FrmHome.LblUserID.Text + "','" + currentDate + "','" + currentTime + "','New Data Inserted')"
                    cmd.ExecuteNonQuery()
                    cmd1.ExecuteNonQuery()
                    con.Close()



                    'Refresh Data Delivery Serial 
                    RefreshDataDeliverySerial()


                    'Insert into Warranty Delivery
                    InsertOrUpdateIntoWarrantyDelivery()

                ElseIf Dr.HasRows Then

                    'Message box 
                    MsgBox("This serial number is already exist", MsgBoxStyle.OkOnly, "Warranty Delivery")


                End If
                Dr.Close()
                con1.Close()


            End If
        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally
        End Try

    End Sub

    'Refresh Data Delivery Serial 
    Sub RefreshDataDeliverySerial()



        ' Load Data
        Try

            If GrdDeliveryDetails.RowCount = 1 Then


                Dim connectionString1 As String = FrmHome.ConnectionString
                Dim sql1 As String = "select [Delivery Serial Number] from [Warranty Delivery Serial]  Where  [Warranty Delivery Invoice No]='" + TxtWarrantyDeliveryInvoiceNo.Text + "'"
                Dim connection1 As New SqlConnection(connectionString1)
                Dim dataadapter1 As New SqlDataAdapter(sql1, connection1)
                Dim ds1 As New DataSet()
                connection1.Open()
                dataadapter1.Fill(ds1, "BizPro_Delivery Serial")
                connection1.Close()
                GrdDeliverySerial.DataSource = ds1
                GrdDeliverySerial.DataMember = "BizPro_Delivery Serial"

                'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
                GrdDeliverySerial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


            Else

                Dim connectionString As String = FrmHome.ConnectionString
                Dim sql As String = "select [Delivery Serial Number] from [Warranty Delivery Serial]  Where  [Warranty Delivery Invoice No]='" + TxtWarrantyDeliveryInvoiceNo.Text + "' and [Product ID]='" + ProductID + "'"
                Dim connection As New SqlConnection(connectionString)
                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Delivery Serial")
                connection.Close()
                GrdDeliverySerial.DataSource = ds
                GrdDeliverySerial.DataMember = "BizPro_Delivery Serial"

                'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
                GrdDeliverySerial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


            End If

        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try

        'End Refresh Data
    End Sub
    'Update Invoice to Complete
    Sub UpdateInvoiceToComplete()

        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "UPDATE  [Warranty Delivery Invoice] set [Status]='COMPLETE',[User Account ID]='" + FrmHome.LblUserID.Text + "',[Computer ID]='" + FrmHome.LblComputerID.Text + "',[Remarks]='" + TxtRemarks.Text + "' where [Warranty Delivery Invoice No] = '" + TxtWarrantyDeliveryInvoiceNo.Text + "' "
            cmd.ExecuteNonQuery()
            con.Close()



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Search Warranty Invoice Number
    Sub SearchWarrantyInvoiceNumber()

        'Clear Data To Search Invoice Number Again
        ClearDataToSearchInvoiceNumberAgain()



        'Refresh Warranty Details
        RefreshWarrantyDetails()

        'Show Customer Information
        ShowCustomerInformation()

        'Focus on Serial Text Box
        TxtSerialNumber.Focus()

        If GrdProductsDetails.RowCount = 1 Then

            'Refresh Data Warranty Serial Number For Single Product()
            RefreshDataWarrantySerialNumberForSingleProduct()

            'Refresh Warrnaty Problem Details For Single Product
            RefreshWarrantyProblemDetailsForSingleProduct()


        End If

    End Sub


    Private Sub TxtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then

            'Search Warranty Invoice Number
            SearchWarrantyInvoiceNumber()

        End If

    End Sub



    Private Sub TxtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearch.TextChanged

    End Sub

    Private Sub GrdProductsDetails_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdProductsDetails_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.GrdProductsDetails.Rows(e.RowIndex)


            'Find warranty id and send to warranty ID 
            WarrantyID = row.Cells("Warranty ID").Value.ToString


            'Search Product ID
            SearchProductID()

            'Refresh Data Warranty Serial
            RefreshDataWarrantySerialNumber()


            'Problem Details Gridview Clear
            GrdProblemDetails.Columns.Clear()

        End If
    End Sub

    Private Sub TxtSerialNumber_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSerialNumber.KeyDown
        If e.KeyCode = Keys.Enter Then

            'Search Product ID
            SearchWarrantyInvoiceNoBySerial()



        End If
    End Sub

    Private Sub TxtSerialNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSerialNumber.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdWarrantySerialNumber_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdWarrantySerialNumber_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdWarrantySerialNumber.Rows(e.RowIndex)

                TxtSerialNumber.Text = row.Cells("Warranty Serial Number").Value.ToString


                If e.Button = Windows.Forms.MouseButtons.Right Then

                    LblReplacedSerialNumber.Visible = True
                    TxtReplacedSerialNumber.Visible = True
                    TxtReplacedSerialNumber.Focus()



                Else


                    LblReplacedSerialNumber.Visible = False
                    TxtReplacedSerialNumber.Visible = False



                    Dim con As New SqlConnection
                    Dim cmd As New SqlCommand
                    Dim dr As SqlDataReader


                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "Select * from [Warranty Serial] Where [Warranty Serial Number]='" + row.Cells("Warranty Serial Number").Value.ToString + "' And [Warranty Invoice No]='" + TxtSearch.Text + "'"

                    'Find Warranty Serial ID
                    dr = cmd.ExecuteReader
                    dr.Read()
                    If dr.HasRows Then

                        WarrantySerialID = dr.Item("Warranty Serial ID").ToString
                        ProductID = dr.Item("Product ID").ToString
                    End If

                    dr.Close()
                    con.Close()

                    'Refresh Warrnaty Problem Details
                    RefreshWarrantyProblemDetails()

                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview")
        End Try
    End Sub

    Private Sub BtnInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInvoice.Click


    End Sub

    Private Sub TxtWarrantyDeliveryID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim q As MsgBoxResult
        q = MsgBox("Are you sure want to save this invoice?", MsgBoxStyle.YesNo, "Warranty Delivery")

        If q = MsgBoxResult.Yes Then


            'Update Invoice to complete.
            UpdateInvoiceToComplete()


            'Clear Data
            ClearData()
        End If


    End Sub

    Private Sub BtnAddToDelivery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddToDelivery.Click
        'Insert Or Update Into Warranty Deliver Invoice()
        InsertOrUpdateIntoWarrantyDeliverInvoice()

        'Insert Data into Delivery Serial Number 
        InsertIntoDeliverySerialNumber()
    End Sub

    Private Sub GrdWarrantySerialNumber_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdWarrantySerialNumber.Rows(e.RowIndex)

                BtnAddToDelivery.PerformClick()
            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview")
        End Try
    End Sub

    Private Sub GrdDeliverySerial_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdDeliverySerial_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)


    End Sub

    Private Sub GrdDeliverySerial_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdDeliverySerial.Rows(e.RowIndex)


                Dim q As MsgBoxResult
                q = MsgBox("Are you sure want to delete this serial number?", MsgBoxStyle.YesNo, "Warranty Delivery")

                If q = MsgBoxResult.Yes Then

                    Dim con As New SqlConnection
                    Dim cmd As New SqlCommand


                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "Delete From [Warranty Delivery Serial] where [Warranty Delivery Invoice No]='" + TxtWarrantyDeliveryInvoiceNo.Text + "' And [Product ID]='" + ProductID + "' And [Delivery Serial Number]='" + row.Cells("Delivery Serial Number").Value.ToString + "'"
                    cmd.ExecuteNonQuery()
                    con.Close()

                    'Refresh Delivery Serial Number
                    RefreshDataDeliverySerial()

                    'Insert or Update into Warranty Delivery
                    InsertOrUpdateIntoWarrantyDelivery()
                End If


            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview")
        End Try
    End Sub

    Private Sub GrdDeliveryDetails_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.GrdDeliveryDetails.Rows(e.RowIndex)


            Try


                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim dr As SqlDataReader


                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "Select * from [Warranty Delivery] Where [Warranty Delivery ID]='" + row.Cells("Warranty Delivery ID").Value.ToString + "'"

                'Find Warranty Serial ID
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then

                    ProductID = dr.Item("Product ID").ToString

                End If

                dr.Close()
                con.Close()


                'Refresh Delivery Serial Number
                RefreshDataDeliverySerial()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub GrdDeliveryDetails_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.GrdDeliveryDetails.Rows(e.RowIndex)


            Try

                Dim q As MsgBoxResult
                q = MsgBox("Are you sure want to delete this serial number?", MsgBoxStyle.YesNo, "Warranty Delivery")

                If q = MsgBoxResult.Yes Then



                    Dim con As New SqlConnection
                    Dim cmd As New SqlCommand


                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "Delete From [Warranty Delivery Serial] where [Warranty Delivery Invoice No]='" + TxtWarrantyDeliveryInvoiceNo.Text + "' And [Product ID]='" + ProductID + "'       Delete From [Warranty Delivery] where [Warranty Delivery Invoice No]='" + TxtWarrantyDeliveryInvoiceNo.Text + "'  And [Product ID]='" + ProductID + "'"

                    cmd.ExecuteReader()
                    con.Close()


                    'Refresh Data Delivery Serial 
                    RefreshDataDeliverySerial()

                    'Refresh Data Warranty Delivery Details
                    RefreshWarrantyDeliveryDetails()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Try

            Dim q As MsgBoxResult
            q = MsgBox("Are you sure want to delete this in invoice?", MsgBoxStyle.YesNo, "Warranty Delivery")

            If q = MsgBoxResult.Yes Then


                Dim con As New SqlConnection
                Dim cmd As New SqlCommand


                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "Delete From [Warranty Delivery Serial] where [Warranty Delivery Invoice No]='" + TxtWarrantyDeliveryInvoiceNo.Text + "'   Delete From [Warranty Delivery] where [Warranty Delivery Invoice No]='" + TxtWarrantyDeliveryInvoiceNo.Text + "'"
                cmd.ExecuteReader()
                con.Close()

                'Clear Data After Delete Invoice
                ClearDataAfterDeleteInvoice()



                'Refresh Data Delivery Serial 
                RefreshDataDeliverySerial()


                'Refresh Data Warranty Delivery Details
                RefreshWarrantyDeliveryDetails()




            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DtpReceiveDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtpDeliveryDate.ValueChanged

    End Sub

    Private Sub BtnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click
        'Clear Data
        ClearData()
    End Sub

    Private Sub GrdProductsDetails_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdProductsDetails.Rows(e.RowIndex)

                'Insert Or Update Into Warranty Deliver Invoice()
                InsertOrUpdateIntoWarrantyDeliverInvoice()


                Dim total As String = 0
                For i As Integer = 0 To GrdWarrantySerialNumber.RowCount - 1
                    total += GrdWarrantySerialNumber.Rows(i).Cells(0).Value

                    TxtSerialNumber.Text = GrdWarrantySerialNumber.Rows(i).Cells(0).Value


                    'Data Insert Code
                    Dim con As New SqlConnection
                    Dim con1 As New SqlConnection
                    Dim cmd As New SqlCommand
                    Dim cmd1 As New SqlCommand
                    Dim cmd2 As New SqlCommand

                    Dim Dr As SqlDataReader

                    Dim currentDate As DateTime = DateTime.Today
                    Dim currentTime As DateTime = DateTime.Now



                    'Empty Txt Box Can Not Be Save Code
                    If TxtSerialNumber.Text = "" Or Val(ProductID) = 0 Or TxtWarrantyDeliveryInvoiceNo.Text = "" Then
                        MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Warranty Look Up")

                    Else

                        con1.ConnectionString = FrmHome.ConnectionString
                        con1.Open()
                        cmd2.Connection = con1
                        cmd2.CommandText = "Select * from [Warranty Delivery Invoice] join [Warranty Delivery Serial] on [Warranty Delivery Invoice].[Warranty Delivery Invoice No]=[Warranty Delivery Serial].[Warranty Delivery Invoice No]  Where [Warranty Delivery Serial].[Product ID]='" + ProductID + "' And [Warranty Delivery Invoice].[Warranty Invoice No]='" + TxtSearch.Text + "' And [Warranty Delivery Serial].[Delivery Serial Number]='" + TxtSerialNumber.Text + "' "

                        Dr = cmd2.ExecuteReader
                        Dr.Read()
                        If Not Dr.HasRows Then

                            con.ConnectionString = FrmHome.ConnectionString
                            con.Open()
                            cmd.Connection = con
                            cmd1.Connection = con
                            cmd.CommandText = "INSERT INTO [Warranty Delivery Serial] ([Warranty Delivery Invoice No],[Product ID],[Delivery Serial Number],[Prepared Date],[Prepared Time],[Branch ID],[Computer ID],[User Account ID]) VALUES ('" + TxtWarrantyDeliveryInvoiceNo.Text + "','" + ProductID + "','" + GrdWarrantySerialNumber.Rows(i).Cells(0).Value + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "')"
                            cmd1.CommandText = "INSERT INTO [Log Details] ([Log Category],[Log Description],[User Account ID],[Log Date],[Log Time],[Task ID]) VALUES ('Bank Information','Data Inserted Successfully [" + LblCustomerName.Text + "]','" + FrmHome.LblUserID.Text + "','" + currentDate + "','" + currentTime + "','New Data Inserted')"
                            cmd.ExecuteNonQuery()
                            cmd1.ExecuteNonQuery()
                            con.Close()


                            'Refresh Data Delivery Serial 
                            RefreshDataDeliverySerial()


                            'Insert into Warranty Delivery
                            InsertOrUpdateIntoWarrantyDelivery()


                        ElseIf Dr.HasRows Then

                            'Message box 
                            MsgBox("This serial number is already exist", MsgBoxStyle.OkOnly, "Warranty Delivery")


                        End If
                        Dr.Close()
                        con1.Close()



                    End If



                Next

                'Clear Data Serial Number
                TxtSerialNumber.Text = ""



            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview")
        End Try
    End Sub


    Private Sub BtnHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHistory.Click

        'Show Warranty Delivery Form
        FrmWarrantyDeliveryHistory.Show()
        FrmWarrantyDeliveryHistory.TxtSearchWarrantyInvoice.Focus()
    End Sub

    Private Sub TxtReplacedSerialNumber_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtReplacedSerialNumber.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnAddToDelivery.PerformClick()
        End If
    End Sub

    Private Sub TxtReplacedSerialNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtReplacedSerialNumber.TextChanged

    End Sub

    Private Sub GrdProblemDetails_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdProblemDetails_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        Try



            If e.RowIndex >= 0 Then

                Dim row As DataGridViewRow
                row = Me.GrdWarrantySerialNumber.Rows(e.RowIndex)





            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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

    Private Sub GrdProblemDetails_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

    End Sub

    Private Sub GrdProductsDetails_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdProductsDetails.CellContentClick

    End Sub

    Private Sub GrdProductsDetails_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdProductsDetails.CellContentDoubleClick

    End Sub

    Private Sub GrdProductsDetails_CellMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdProductsDetails.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.GrdProductsDetails.Rows(e.RowIndex)


            'Find warranty id and send to warranty ID 
            WarrantyID = row.Cells("Warranty ID").Value.ToString


            'Search Product ID
            SearchProductID()

            'Refresh Data Warranty Serial
            RefreshDataWarrantySerialNumber()


            'Problem Details Gridview Clear
            GrdProblemDetails.Columns.Clear()

        End If
    End Sub

    Private Sub GrdProductsDetails_CellMouseDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdProductsDetails.CellMouseDoubleClick
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdProductsDetails.Rows(e.RowIndex)

                'Insert Or Update Into Warranty Deliver Invoice()
                InsertOrUpdateIntoWarrantyDeliverInvoice()


                Dim total As String = 0
                For i As Integer = 0 To GrdWarrantySerialNumber.RowCount - 1
                    total += GrdWarrantySerialNumber.Rows(i).Cells(0).Value

                    TxtSerialNumber.Text = GrdWarrantySerialNumber.Rows(i).Cells(0).Value


                    'Data Insert Code
                    Dim con As New SqlConnection
                    Dim con1 As New SqlConnection
                    Dim cmd As New SqlCommand
                    Dim cmd1 As New SqlCommand
                    Dim cmd2 As New SqlCommand

                    Dim Dr As SqlDataReader

                    Dim currentDate As DateTime = DateTime.Today
                    Dim currentTime As DateTime = DateTime.Now



                    'Empty Txt Box Can Not Be Save Code
                    If TxtSerialNumber.Text = "" Or Val(ProductID) = 0 Or TxtWarrantyDeliveryInvoiceNo.Text = "" Then
                        MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Warranty Look Up")

                    Else

                        con1.ConnectionString = FrmHome.ConnectionString
                        con1.Open()
                        cmd2.Connection = con1
                        cmd2.CommandText = "Select * from [Warranty Delivery Invoice] join [Warranty Delivery Serial] on [Warranty Delivery Invoice].[Warranty Delivery Invoice No]=[Warranty Delivery Serial].[Warranty Delivery Invoice No]  Where [Warranty Delivery Serial].[Product ID]='" + ProductID + "' And [Warranty Delivery Invoice].[Warranty Invoice No]='" + TxtSearch.Text + "' And [Warranty Delivery Serial].[Delivery Serial Number]='" + TxtSerialNumber.Text + "' "

                        Dr = cmd2.ExecuteReader
                        Dr.Read()
                        If Not Dr.HasRows Then

                            con.ConnectionString = FrmHome.ConnectionString
                            con.Open()
                            cmd.Connection = con
                            cmd1.Connection = con
                            cmd.CommandText = "INSERT INTO [Warranty Delivery Serial] ([Warranty Delivery Invoice No],[Product ID],[Delivery Serial Number],[Prepared Date],[Prepared Time],[Branch ID],[Computer ID],[User Account ID]) VALUES ('" + TxtWarrantyDeliveryInvoiceNo.Text + "','" + ProductID + "','" + GrdWarrantySerialNumber.Rows(i).Cells(0).Value + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "')"
                            cmd1.CommandText = "INSERT INTO [Log Details] ([Log Category],[Log Description],[User Account ID],[Log Date],[Log Time],[Task ID]) VALUES ('Bank Information','Data Inserted Successfully [" + LblCustomerName.Text + "]','" + FrmHome.LblUserID.Text + "','" + currentDate + "','" + currentTime + "','New Data Inserted')"
                            cmd.ExecuteNonQuery()
                            cmd1.ExecuteNonQuery()
                            con.Close()


                            'Refresh Data Delivery Serial 
                            RefreshDataDeliverySerial()


                            'Insert into Warranty Delivery
                            InsertOrUpdateIntoWarrantyDelivery()


                        ElseIf Dr.HasRows Then

                            'Message box 
                            MsgBox("This serial number is already exist", MsgBoxStyle.OkOnly, "Warranty Delivery")


                        End If
                        Dr.Close()
                        con1.Close()



                    End If



                Next

                'Clear Data Serial Number
                TxtSerialNumber.Text = ""



            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview")
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdWarrantySerialNumber.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdWarrantySerialNumber.CellMouseClick
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdWarrantySerialNumber.Rows(e.RowIndex)

                TxtSerialNumber.Text = row.Cells("Warranty Serial Number").Value.ToString


                If e.Button = Windows.Forms.MouseButtons.Right Then

                    LblReplacedSerialNumber.Visible = True
                    TxtReplacedSerialNumber.Visible = True
                    TxtReplacedSerialNumber.Focus()



                Else


                    LblReplacedSerialNumber.Visible = False
                    TxtReplacedSerialNumber.Visible = False



                    Dim con As New SqlConnection
                    Dim cmd As New SqlCommand
                    Dim dr As SqlDataReader


                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "Select * from [Warranty Serial] Where [Warranty Serial Number]='" + row.Cells("Warranty Serial Number").Value.ToString + "' And [Warranty Invoice No]='" + TxtSearch.Text + "'"

                    'Find Warranty Serial ID
                    dr = cmd.ExecuteReader
                    dr.Read()
                    If dr.HasRows Then

                        WarrantySerialID = dr.Item("Warranty Serial ID").ToString
                        ProductID = dr.Item("Product ID").ToString
                    End If

                    dr.Close()
                    con.Close()

                    'Refresh Warrnaty Problem Details
                    RefreshWarrantyProblemDetails()

                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview")
        End Try
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdWarrantySerialNumber.CellMouseDoubleClick
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdWarrantySerialNumber.Rows(e.RowIndex)

                BtnAddToDelivery.PerformClick()
            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview")
        End Try
    End Sub

    Private Sub GrdProblemDetails_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdProblemDetails.CellContentClick

    End Sub

    Private Sub GrdProblemDetails_CellMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdProblemDetails.CellMouseClick
        Try



            If e.RowIndex >= 0 Then

                Dim row As DataGridViewRow
                row = Me.GrdWarrantySerialNumber.Rows(e.RowIndex)





            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GrdDeliveryDetails_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdDeliveryDetails.CellContentClick

    End Sub

    Private Sub GrdDeliveryDetails_CellMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdDeliveryDetails.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.GrdDeliveryDetails.Rows(e.RowIndex)


            Try


                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim dr As SqlDataReader


                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "Select * from [Warranty Delivery] Where [Warranty Delivery ID]='" + row.Cells("Warranty Delivery ID").Value.ToString + "'"

                'Find Warranty Serial ID
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then

                    ProductID = dr.Item("Product ID").ToString

                End If

                dr.Close()
                con.Close()


                'Refresh Delivery Serial Number
                RefreshDataDeliverySerial()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub GrdDeliveryDetails_CellMouseDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdDeliveryDetails.CellMouseDoubleClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.GrdDeliveryDetails.Rows(e.RowIndex)


            Try

                Dim q As MsgBoxResult
                q = MsgBox("Are you sure want to delete this serial number?", MsgBoxStyle.YesNo, "Warranty Delivery")

                If q = MsgBoxResult.Yes Then



                    Dim con As New SqlConnection
                    Dim cmd As New SqlCommand


                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "Delete From [Warranty Delivery Serial] where [Warranty Delivery Invoice No]='" + TxtWarrantyDeliveryInvoiceNo.Text + "' And [Product ID]='" + ProductID + "'       Delete From [Warranty Delivery] where [Warranty Delivery Invoice No]='" + TxtWarrantyDeliveryInvoiceNo.Text + "'  And [Product ID]='" + ProductID + "'"

                    cmd.ExecuteReader()
                    con.Close()


                    'Refresh Data Delivery Serial 
                    RefreshDataDeliverySerial()

                    'Refresh Data Warranty Delivery Details
                    RefreshWarrantyDeliveryDetails()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub GrdDeliverySerial_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdDeliverySerial.CellContentClick

    End Sub

    Private Sub GrdDeliverySerial_CellMouseDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdDeliverySerial.CellMouseDoubleClick
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdDeliverySerial.Rows(e.RowIndex)


                Dim q As MsgBoxResult
                q = MsgBox("Are you sure want to delete this serial number?", MsgBoxStyle.YesNo, "Warranty Delivery")

                If q = MsgBoxResult.Yes Then

                    Dim con As New SqlConnection
                    Dim cmd As New SqlCommand


                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "Delete From [Warranty Delivery Serial] where [Warranty Delivery Invoice No]='" + TxtWarrantyDeliveryInvoiceNo.Text + "' And [Product ID]='" + ProductID + "' And [Delivery Serial Number]='" + row.Cells("Delivery Serial Number").Value.ToString + "'"
                    cmd.ExecuteNonQuery()
                    con.Close()

                    'Refresh Delivery Serial Number
                    RefreshDataDeliverySerial()

                    'Insert or Update into Warranty Delivery
                    InsertOrUpdateIntoWarrantyDelivery()
                End If


            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview")
        End Try
    End Sub
End Class