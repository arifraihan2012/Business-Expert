Imports System.Data
Imports System.Data.SqlClient
Imports System.IO


Public Class FrmWarrantyProcessing
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point

    Dim ProductID As String
    Dim WarrantySerialID As String
    Dim WarrantyID As String
    Dim WarrantyProblemID As String
    Dim SearchSerial As String
    Private Sub FrmWarrantyProcessing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 0)
        Me.Size = My.Computer.Screen.WorkingArea.Size

        Me.Width = My.Computer.Screen.Bounds.Size.Width

    End Sub

    'Clear Data
    Sub ClearAllData()
        TxtSearchInvice.Text = ""
        TxtSerialNumber.Text = ""

        GrdWarrantyInvoice.Columns.Clear()
        GrdProductsDetails.Columns.Clear()
        GrdWarrantySerialNumber.Columns.Clear()
        GrdProblemDetails.Columns.Clear()


    End Sub

    'Clear Data For Search Again
    Sub ClearDataForSearchAgain()

        TxtSerialNumber.Text = ""
        GrdWarrantyInvoice.Columns.Clear()
        GrdProductsDetails.Columns.Clear()
        GrdWarrantySerialNumber.Columns.Clear()
        GrdProblemDetails.Columns.Clear()


    End Sub
    'Clear Data For Search Serial Number
    Sub ClearDataForSearchSerialNumber()

        GrdWarrantyInvoice.Columns.Clear()
        GrdProductsDetails.Columns.Clear()
        GrdProblemDetails.Columns.Clear()


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
            cmd.CommandText = "Select * from [Warranty Invoice Number] Where [Warranty Invoice No]='" + TxtSearchInvice.Text + "' "

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

    'Refresh Data Warranty Invoice Serial Incomplete
    Sub RefreshWarrantyInvoiceDetailsIncomplete()

        ' Load Data
        Try


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select [Warranty Invoice Number].[Warranty Invoice No],[Warranty Invoice Number].[Complainer Name],[Warranty Invoice Number].[Complainer Mobile No] from [Warranty Invoice Number] join [Warranty Problem Details] on [Warranty Invoice Number].[Warranty Invoice No]=[Warranty Problem Details].[Warranty Invoice No] where [Warranty Problem Details].Status='INCOMPLETE' Group by  [Warranty Invoice Number].[Warranty Invoice No],[Warranty Invoice Number].[Complainer Name],[Warranty Invoice Number].[Complainer Mobile No] order by [Warranty Invoice Number].[Warranty Invoice No] asc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Warranty Invoice Number")
            connection.Close()
            GrdWarrantyInvoice.DataSource = ds
            GrdWarrantyInvoice.DataMember = "BizPro_Warranty Invoice Number"

            'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdWarrantyInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill



        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try

        'End Refresh Data
    End Sub
    'Refresh Data Warranty Invoice Serial Complete
    Sub RefreshWarrantyInvoiceDetailsComplete()

        ' Load Data
        Try


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select [Warranty Invoice Number].[Warranty Invoice No],[Warranty Invoice Number].[Complainer Name],[Warranty Invoice Number].[Complainer Mobile No] from [Warranty Invoice Number] join [Warranty Problem Details] on [Warranty Invoice Number].[Warranty Invoice No]=[Warranty Problem Details].[Warranty Invoice No] where [Warranty Problem Details].Status='COMPLETE' Group by  [Warranty Invoice Number].[Warranty Invoice No],[Warranty Invoice Number].[Complainer Name],[Warranty Invoice Number].[Complainer Mobile No] order by [Warranty Invoice Number].[Warranty Invoice No] asc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Warranty Invoice Number")
            connection.Close()
            GrdWarrantyInvoice.DataSource = ds
            GrdWarrantyInvoice.DataMember = "BizPro_Warranty Invoice Number"

            'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdWarrantyInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill



        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try

        'End Refresh Data
    End Sub

    'Search Data Warranty Invoice Serial
    Sub SearchWarrantyInvoiceDetails()

        ' Load Data
        Try


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select [Warranty Invoice Number].[Warranty Invoice No],[Warranty Invoice Number].[Complainer Name],[Warranty Invoice Number].[Complainer Mobile No] from [Warranty Invoice Number] join [Warranty Problem Details] on [Warranty Invoice Number].[Warranty Invoice No]=[Warranty Problem Details].[Warranty Invoice No] where [Warranty Problem Details].Status='INCOMPLETE' And  [Warranty Invoice Number].[Warranty Invoice No] ='" + TxtSearchInvice.Text + "'Group by  [Warranty Invoice Number].[Warranty Invoice No],[Warranty Invoice Number].[Complainer Name],[Warranty Invoice Number].[Complainer Mobile No] order by [Warranty Invoice Number].[Warranty Invoice No] asc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Warranty Invoice Number")
            connection.Close()
            GrdWarrantyInvoice.DataSource = ds
            GrdWarrantyInvoice.DataMember = "BizPro_Warranty Invoice Number"

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
                Dim sql As String = "select [Problem Category].[Problem Category Name],[Warranty Problem Details].[Status],[Warranty Problem Details].[Remarks] from [Warranty Problem Details]join [Problem Category] on  [Warranty Problem Details].[Problem ID]=[Problem Category].[Problem Category ID] Where [Warranty Invoice No]='" + TxtSearchInvice.Text + "'"
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
    'Refresh Warrnaty Problem Details For Single Product By Search
    Sub RefreshWarrantyProblemDetailsForSingleProductBySearch()

        Try

            If GrdWarrantySerialNumber.RowCount = 1 Then


                Dim connectionString As String = FrmHome.ConnectionString
                Dim sql As String = "select [Problem Category].[Problem Category Name],[Warranty Problem Details].[Status],[Warranty Problem Details].[Remarks] from [Warranty Problem Details] join [Warranty Serial] on [Warranty Serial].[Warranty Serial ID]=[Warranty Problem Details].[Warranty Serial ID] join [Problem Category] on  [Warranty Problem Details].[Problem ID]=[Problem Category].[Problem Category ID] where [Warranty Problem Details].[Warranty Invoice No]='" + TxtSearchInvice.Text + "'  and [Warranty Serial].[Warranty Serial Number]='" + TxtSerialNumber.Text + "' "
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
            Dim sql As String = "select [Problem Category].[Problem Category Name],[Warranty Problem Details].[Status],[Warranty Problem Details].[Remarks] from [Warranty Problem Details]join [Problem Category] on  [Warranty Problem Details].[Problem ID]=[Problem Category].[Problem Category ID] Where [Warranty Serial ID]='" + WarrantySerialID + "'"
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
            Dim sql As String = "select [Warranty Serial Number] from [Warranty Serial]  Where [Product ID]='" + ProductID + "' And [Warranty Invoice No]='" + TxtSearchInvice.Text + "'"
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
    'Search Warranty Serial
    Sub SearchWarrantySerialNumber()

        ' Load Data
        Try


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select [Warranty Serial Number] from [Warranty Serial]  where [Warranty Serial Number] not in (Select [Delivery Serial Number] from [Warranty Delivery Serial] join [Warranty Delivery Invoice] on [Warranty Delivery Serial].[Warranty Delivery Invoice No]=[Warranty Delivery Invoice].[Warranty Delivery Invoice No] where [Warranty Delivery Invoice].[Warranty Invoice No]=[Warranty Serial].[Warranty Invoice No]) and [Warranty Invoice No] not in (Select [Warranty Invoice No] from [Warranty Delivery Serial] join [Warranty Delivery Invoice] on [Warranty Delivery Serial].[Warranty Delivery Invoice No]=[Warranty Delivery Invoice].[Warranty Delivery Invoice No] where [Warranty Delivery Invoice].[Warranty Invoice No]=[Warranty Serial].[Warranty Invoice No]) and  [warranty Serial Number] Like '%" + TxtSerialNumber.Text + "%'"
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
            Dim sql As String = "select [Warranty Serial Number] from [Warranty Serial]  Where [Warranty Invoice No]='" + TxtSearchInvice.Text + "'"
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

    'Refresh Data Warranty Serial
    Sub RefreshWarrantyDetails()

        ' Load Data
        Try


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "Select Warranty.[Warranty ID],products.[Product Name], Warranty.[Warranty Quantity] from [Warranty] join [products] on Warranty.[Product ID]= products.[Product ID] Where Warranty.[Warranty Invoice No]='" + TxtSearchInvice.Text + "'"
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
    'Refresh Data Warranty Serial For Search Serial Number
    Sub RefreshWarrantyDetailsForSearchSerialNumber()

        ' Load Data
        Try


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select [products].[Product Name] from [Warranty Serial] join [products] on [Warranty Serial].[Product ID]= products.[Product ID]  where [Warranty Serial Number] not in (Select [Delivery Serial Number] from [Warranty Delivery Serial] join [Warranty Delivery Invoice] on [Warranty Delivery Serial].[Warranty Delivery Invoice No]=[Warranty Delivery Invoice].[Warranty Delivery Invoice No] where [Warranty Delivery Invoice].[Warranty Invoice No]=[Warranty Serial].[Warranty Invoice No]) and [Warranty Invoice No] not in (Select [Warranty Invoice No] from [Warranty Delivery Serial] join [Warranty Delivery Invoice] on [Warranty Delivery Serial].[Warranty Delivery Invoice No]=[Warranty Delivery Invoice].[Warranty Delivery Invoice No] where [Warranty Delivery Invoice].[Warranty Invoice No]=[Warranty Serial].[Warranty Invoice No]) and  [warranty Serial Number]='" + TxtSerialNumber.Text + "'"
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

    'Refresh Data Warranty Serial Completed
    Sub RefreshWarrantyDetailsCompleted()

        ' Load Data
        Try


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "Select Warranty.[Warranty ID],products.[Product Name], Warranty.[Warranty Quantity] from [Warranty] join [products] on Warranty.[Product ID]= products.[Product ID] Where Warranty.[Warranty Invoice No]='" + TxtSearchInvice.Text + "'"
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

    ' Find Product ID and Warranty Serial Number For Single Product Warranty Serial ID
    Sub FindProductIDandWarrantySerialNumberAndWarrantySerialIDForSingleProduct()
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand
            Dim dr As SqlDataReader



            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Select * from [Warranty Problem Details] join [Warranty Serial] on [Warranty Problem Details].[Warranty Serial ID] = [Warranty Serial].[Warranty Serial ID]  Where [Warranty Problem Details].[Warranty Invoice No]='" + TxtSearchInvice.Text + "'"

            dr = cmd.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                ProductID = dr.Item("Product ID").ToString
                TxtSerialNumber.Text = dr.Item("Warranty Serial Number").ToString
                WarrantySerialID = dr.Item("Warranty Serial ID").ToString
            End If

            dr.Close()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    'Find Product ID and Warranty SerialID For Single Serial Number()
    Sub FindProductIDandWarrantySerialIDForSingleSerialNumber()

        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader


            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Select * from [Warranty Serial] Where [Warranty Serial Number]='" + TxtSerialNumber.Text + "' And [Warranty Invoice No]='" + TxtSearchInvice.Text + "'"

            'Find Warranty Serial ID
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then

                WarrantySerialID = dr.Item("Warranty Serial ID").ToString
                ProductID = dr.Item("Product ID").ToString

            End If

            dr.Close()
            con.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    'Find Warranty Invoice Number For Search Serial Number
    Sub FindWarrantyInvoiceNumberForSearchSerialNumber()

        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader


            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "select * from [Warranty Serial]  where [Warranty Serial Number] not in (Select [Delivery Serial Number] from [Warranty Delivery Serial] join [Warranty Delivery Invoice] on [Warranty Delivery Serial].[Warranty Delivery Invoice No]=[Warranty Delivery Invoice].[Warranty Delivery Invoice No] where [Warranty Delivery Invoice].[Warranty Invoice No]=[Warranty Serial].[Warranty Invoice No]) and [Warranty Invoice No] not in (Select [Warranty Invoice No] from [Warranty Delivery Serial] join [Warranty Delivery Invoice] on [Warranty Delivery Serial].[Warranty Delivery Invoice No]=[Warranty Delivery Invoice].[Warranty Delivery Invoice No] where [Warranty Delivery Invoice].[Warranty Invoice No]=[Warranty Serial].[Warranty Invoice No]) and [Warranty Serial Number]='" + TxtSerialNumber.Text + "' "

            'Find Warranty Serial ID
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then

                TxtSearchInvice.Text = dr.Item("Warranty Invoice No").ToString


            End If

            dr.Close()
            con.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    ' Warranty Status Change And List Solution
    Sub WarrantyStatusChangeAndListSolution()

        Try


            Dim cmd As New SqlCommand
            Dim con As New SqlConnection


            Dim total As String = 0
            For i As Integer = 0 To GrdProblemDetails.RowCount - 1
                total += GrdProblemDetails.Rows(i).Cells(0).Value & GrdProblemDetails.Rows(i).Cells(1).Value & GrdProblemDetails.Rows(i).Cells(2).Value


                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "Update [Warranty Problem Details] set [Status]='COMPLETE',[Remarks]='" + GrdProblemDetails.Rows(i).Cells(2).Value.ToString + "' Where [Warranty Invoice No]='" + TxtSearchInvice.Text + "' and [Problem ID] = (Select [Problem Category ID] from [Problem Category] where [Problem Category Name]='" + GrdProblemDetails.Rows(i).Cells(0).Value.ToString + "') and [Product ID]='" + ProductID + "' and [Warranty Serial ID]=(Select [Warranty Serial ID] from [Warranty Serial] where [Warranty Serial Number]='" + TxtSerialNumber.Text + "' and [Warranty Invoice No]='" + TxtSearchInvice.Text + "'  and [Product ID]='" + ProductID + "' )"
                cmd.ExecuteNonQuery()
                con.Close()

            Next


            If GrdWarrantySerialNumber.RowCount = 1 Then

                If GrdProductsDetails.Columns.Count = 1 Then
                    'Refresh Warrnaty Problem Details For Single Product By Search
                    RefreshWarrantyProblemDetailsForSingleProductBySearch()
                Else

                    'Refresh Problem Details for single Serial
                    RefreshWarrantyProblemDetailsForSingleProduct()
                End If
            Else

                'Refresh Warranty Problem Details
                RefreshWarrantyProblemDetails()

            End If






        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        'Clear Data
        ClearAllData()

        'Refresh Data Warranty Invoice Serial Complete
        RefreshWarrantyInvoiceDetailsIncomplete()

    End Sub

    Private Sub GrdWarrantyInvoice_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdWarrantyInvoice_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.GrdWarrantyInvoice.Rows(e.RowIndex)

            TxtSearchInvice.Text = row.Cells("Warranty Invoice No").Value.ToString


            'Refresh Data Warranty Serial
            RefreshWarrantyDetails()

            If GrdProductsDetails.RowCount = 1 Then

                'Refresh Data Warranty Serial For Single Product
                RefreshDataWarrantySerialNumberForSingleProduct()

            Else

                'Clear Warranty Serial data
                GrdWarrantySerialNumber.Columns.Clear()


            End If

            If GrdWarrantySerialNumber.RowCount = 1 Then

                'Refresh Problem Details for single Serial
                RefreshWarrantyProblemDetailsForSingleProduct()
            Else

                'Clear Gridview data
                GrdProblemDetails.Columns.Clear()

            End If


            'Show Customer Information
            ShowCustomerInformation()


        End If
    End Sub

    Private Sub GrdProductsDetails_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdProductsDetails_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.GrdProductsDetails.Rows(e.RowIndex)

            Try

                If GrdProductsDetails.Columns.Count > 1 Then
                    'Find warranty id and send to warranty ID 
                    WarrantyID = row.Cells("Warranty ID").Value.ToString
                End If

                'Search Product ID
                SearchProductID()

                'Refresh Data Warranty Serial
                RefreshDataWarrantySerialNumber()


                'Problem Details Gridview Clear
                GrdProblemDetails.Columns.Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If


    End Sub

    Private Sub GrdWarrantySerialNumber_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdWarrantySerialNumber_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        Try
            If e.RowIndex >= 0 Then

                Dim row As DataGridViewRow
                row = Me.GrdWarrantySerialNumber.Rows(e.RowIndex)

                TxtSerialNumber.Text = row.Cells("Warranty Serial Number").Value.ToString



                'This condition is used for search serial number
                If Not GrdProductsDetails.RowCount > 0 Then

                    BtnSearchInvice.PerformClick()

                    'Find Warranty Invoice Number For Search Serial Number
                    FindWarrantyInvoiceNumberForSearchSerialNumber()

                    'Refresh Data Warranty Serial For Search Serial Number
                    RefreshWarrantyDetailsForSearchSerialNumber()

                    'Search Data Warranty Invoice Serial
                    SearchWarrantyInvoiceDetails()

                End If

                'Find Product ID and Warranty SerialID For Single Serial Number()
                FindProductIDandWarrantySerialIDForSingleSerialNumber()


                'Refresh Warrnaty Problem Details
                RefreshWarrantyProblemDetails()

            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview")
        End Try
    End Sub

    Private Sub TxtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearchInvice.KeyDown

        If e.KeyCode = Keys.Enter Then


            'Clear Data For Search Again
            ClearDataForSearchAgain()

            'Search Data Warranty Invoice Serial
            SearchWarrantyInvoiceDetails()


            'Show Customer Information
            ShowCustomerInformation()

            'Refresh Data Warranty Serial
            RefreshWarrantyDetails()

            If GrdProductsDetails.RowCount = 1 Then

                'Refresh Data Warranty Serial For Single Product
                RefreshDataWarrantySerialNumberForSingleProduct()

            Else

                'Refresh Data Warranty Serial For 
                RefreshDataWarrantySerialNumber()


            End If

            If GrdWarrantySerialNumber.RowCount = 1 Then

                ' Find Product ID and Warranty Serial Number For Single Product Warranty Serial ID
                FindProductIDandWarrantySerialNumberAndWarrantySerialIDForSingleProduct()

                'Refresh Problem Details for single Serial
                RefreshWarrantyProblemDetailsForSingleProduct()

            End If


        End If
    End Sub

    Private Sub TxtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearchInvice.TextChanged

    End Sub

    Private Sub GrdProblemDetails_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub BtnAddToDelivery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearchInvice.Click


        'Clear Data For Search Serial Number
        ClearDataForSearchSerialNumber()

        'Search Warranty Serial
        SearchWarrantySerialNumber()



    End Sub

    Private Sub TxtSerialNumber_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSerialNumber.KeyDown
        If e.KeyCode = Keys.Enter Then

            'Clear Data For Search Serial Number
            ClearDataForSearchSerialNumber()

            'Search Warranty Serial
            SearchWarrantySerialNumber()


        End If
    End Sub

    Private Sub TxtSerialNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSerialNumber.TextChanged



    End Sub

    Private Sub GrdProblemDetails_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

    End Sub

    Private Sub GrdProblemDetails_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        Try


            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then

                Dim row As DataGridViewRow
                row = Me.GrdProblemDetails.Rows(e.RowIndex)




                If e.ColumnIndex = 1 Then




                    Dim con As New SqlConnection
                    Dim cmd As New SqlCommand
                    Dim cmd1 As New SqlCommand
                    Dim dr As SqlDataReader



                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "Select * from [Warranty Problem Details] join [Problem Category] on [Warranty Problem Details].[Problem ID] = [Problem Category].[Problem Category ID]  Where [Problem Category].[Problem Category Name]='" + row.Cells("Problem Category Name").Value.ToString + "' and   [Warranty Problem Details].[Warranty Serial ID]='" + WarrantySerialID + "'"

                    dr = cmd.ExecuteReader
                    dr.Read()

                    If dr.HasRows Then
                        WarrantyProblemID = dr.Item("Warranty Problem ID").ToString

                    End If
                    dr.Close()
                    con.Close()


                    If row.Cells("Status").Value.ToString = "INCOMPLETE" Then

                        row.Cells("Status").Value = "COMPLETE"


                    ElseIf row.Cells("Status").Value.ToString = "COMPLETE" Then

                        row.Cells("Status").Value = "INCOMPLETE"


                    End If




                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If GrdProblemDetails.RowCount > 0 Then

            Dim q As MsgBoxResult
            q = MsgBox("Are you want to save this problem", MsgBoxStyle.YesNo, "Warranty Processing")

            If q = MsgBoxResult.Yes Then
                ' Warranty Status Change And List Solution
                WarrantyStatusChangeAndListSolution()

                SendSMS()

            End If
        End If

    End Sub
    Sub SendSMS()
        Try

            If FrmHome.LblStatus.Text = "Active" Or FrmHome.LblStatus.Text = "Masking" Then


                Dim q As MsgBoxResult
                q = MsgBox("Do you want to send SMS?", MsgBoxStyle.YesNo, "Warranty")

                If q = MsgBoxResult.Yes Then



                    Dim con As New SqlConnection
                    Dim cmd As New SqlCommand
                    Dim cmd2 As New SqlCommand
                   

                

                    FrmHome.SMSPhoneNo = Me.LblPhoneNoCustomer.Text

                  
                    FrmHome.SMSText = "Dear Customer, Your Product of Servicing/Warranty is Ready to Deliver. Please visit us to collect the product. Thank you."

                    If FrmHome.LblStatus.Text = "Active" Then
                        FrmHome.BulksmsbdToAll()
                    ElseIf FrmHome.LblStatus.Text = "Masking" Then
                        FrmHome.MaskingBulksmsbdToAll()
                    End If

                   

                    con.Close()

            End If


            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Refresh Data Warranty Invoice Serial Complete
        RefreshWarrantyInvoiceDetailsComplete()

    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        'Clear All Data
        ClearAllData()

        'Focus on invoice no
        TxtSearchInvice.Focus()
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

    Private Sub GrdWarrantyInvoice_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

    End Sub

    Private Sub GrdWarrantyInvoice_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdWarrantyInvoice.CellContentClick

    End Sub

    Private Sub GrdWarrantyInvoice_CellMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdWarrantyInvoice.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.GrdWarrantyInvoice.Rows(e.RowIndex)

            TxtSearchInvice.Text = row.Cells("Warranty Invoice No").Value.ToString


            'Refresh Data Warranty Serial
            RefreshWarrantyDetails()

            If GrdProductsDetails.RowCount = 1 Then

                'Refresh Data Warranty Serial For Single Product
                RefreshDataWarrantySerialNumberForSingleProduct()

            Else

                'Clear Warranty Serial data
                GrdWarrantySerialNumber.Columns.Clear()


            End If

            If GrdWarrantySerialNumber.RowCount = 1 Then

                'Refresh Problem Details for single Serial
                RefreshWarrantyProblemDetailsForSingleProduct()
            Else

                'Clear Gridview data
                GrdProblemDetails.Columns.Clear()

            End If


            'Show Customer Information
            ShowCustomerInformation()


        End If







    End Sub

    Private Sub GrdProductsDetails_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdProductsDetails.CellContentClick

    End Sub

    Private Sub GrdProductsDetails_CellMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdProductsDetails.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.GrdProductsDetails.Rows(e.RowIndex)

            Try

                If GrdProductsDetails.Columns.Count > 1 Then
                    'Find warranty id and send to warranty ID 
                    WarrantyID = row.Cells("Warranty ID").Value.ToString
                End If

                'Search Product ID
                SearchProductID()

                'Refresh Data Warranty Serial
                RefreshDataWarrantySerialNumber()


                'Problem Details Gridview Clear
                GrdProblemDetails.Columns.Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub GrdWarrantySerialNumber_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdWarrantySerialNumber.CellContentClick

    End Sub

    Private Sub GrdWarrantySerialNumber_CellMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdWarrantySerialNumber.CellMouseClick
        Try
            If e.RowIndex >= 0 Then

                Dim row As DataGridViewRow
                row = Me.GrdWarrantySerialNumber.Rows(e.RowIndex)

                TxtSerialNumber.Text = row.Cells("Warranty Serial Number").Value.ToString



                'This condition is used for search serial number
                If Not GrdProductsDetails.RowCount > 0 Then

                    BtnSearchInvice.PerformClick()

                    'Find Warranty Invoice Number For Search Serial Number
                    FindWarrantyInvoiceNumberForSearchSerialNumber()

                    'Refresh Data Warranty Serial For Search Serial Number
                    RefreshWarrantyDetailsForSearchSerialNumber()

                    'Search Data Warranty Invoice Serial
                    SearchWarrantyInvoiceDetails()

                End If

                'Find Product ID and Warranty SerialID For Single Serial Number()
                FindProductIDandWarrantySerialIDForSingleSerialNumber()


                'Refresh Warrnaty Problem Details
                RefreshWarrantyProblemDetails()

            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview")
        End Try
    End Sub

    Private Sub GrdWarrantySerialNumber_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdWarrantySerialNumber.CellMouseDoubleClick

    End Sub

    Private Sub GrdProblemDetails_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdProblemDetails.CellContentClick

    End Sub

    Private Sub GrdProblemDetails_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdProblemDetails.KeyDown
        If e.KeyCode = Keys.Enter Then


            'Clear Data For Search Again
            ClearDataForSearchAgain()

            'Search Data Warranty Invoice Serial
            SearchWarrantyInvoiceDetails()


            'Show Customer Information
            ShowCustomerInformation()

            'Refresh Data Warranty Serial
            RefreshWarrantyDetails()

            If GrdProductsDetails.RowCount = 1 Then

                'Refresh Data Warranty Serial For Single Product
                RefreshDataWarrantySerialNumberForSingleProduct()

            Else

                'Refresh Data Warranty Serial For 
                RefreshDataWarrantySerialNumber()


            End If

            If GrdWarrantySerialNumber.RowCount = 1 Then

                ' Find Product ID and Warranty Serial Number For Single Product Warranty Serial ID
                FindProductIDandWarrantySerialNumberAndWarrantySerialIDForSingleProduct()

                'Refresh Problem Details for single Serial
                RefreshWarrantyProblemDetailsForSingleProduct()

            End If


        End If
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
End Class