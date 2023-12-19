Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmStockInformation

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblStockID.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblBranchID.Click

    End Sub

    Private Sub CmbWarehouse_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbBranchID.KeyDown
        'Focus on Location ID
        If e.KeyCode = Keys.Enter Then
            Me.CmbLocationID.Focus()

        End If
        'If e.KeyCode = Keys.F4 Then
        'FrmListofBranches.Show()
        'FrmListofBranches.Label1.Text = "Stock Information"
        'FrmListofBranches.TxtSearchBranchName.Focus()
        'End If

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbBranchID.SelectedIndexChanged
        'Focus on Location combo box
        CmbLocationID.Focus()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblLocationID.Click

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtWholeSalePrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtSalePrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub LblQuantity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LblWholeSalePrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LblSalePrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub TextBox4_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtQuantity.TextChanged

    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
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

            Me.TxtStockID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.CmbProductID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.CmbBranchID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.CmbLocationID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtQuantity.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtSearch.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)


            Me.GrdStockInformation.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.GrdStockInformation.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)


            'MsgBox(dr.Item("Language Font"))

            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            con.Close()
        End Try

        'End Language

    End Sub

    Private Sub StockInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'ComboBox Load Code
        loadComboBox()



        'Change Language
        ChangeLanguage()

        'Clear Data
        ClearData()

    End Sub



    'Lode Combo box Private sub

    Sub loadComboBox()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = FrmHome.ConnectionString

        Dim strSQL As String = "SELECT [Product ID],[Product Name] FROM products"
        Dim da As New System.Data.SqlClient.SqlDataAdapter(strSQL, con)
        Dim ds As New DataSet
        da.Fill(ds, "Products")

        With Me.CmbProductID
            .DataSource = ds.Tables("products")
            .ValueMember = "Product ID"
            .DisplayMember = "Product Name"




        End With




        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        con1.ConnectionString = FrmHome.ConnectionString

        Dim strSQL1 As String = "SELECT [Branch ID],[Branch Name] FROM [Branch Information]"
        Dim da1 As New System.Data.SqlClient.SqlDataAdapter(strSQL1, con1)
        Dim ds1 As New DataSet
        da1.Fill(ds1, "[Branch Information]")

        With Me.CmbBranchID
            .DataSource = ds1.Tables("[Branch Information]")
            .DisplayMember = "Branch Name"
            .ValueMember = "Branch ID"
        End With


        Dim con2 As New SqlConnection
        Dim cmd2 As New SqlCommand
        con2.ConnectionString = FrmHome.ConnectionString

        Dim strSQL2 As String = "SELECT [Location ID],[Location Name] FROM [Location Information]"
        Dim da2 As New System.Data.SqlClient.SqlDataAdapter(strSQL2, con2)
        Dim ds2 As New DataSet
        da2.Fill(ds2, "[Location Information]")

        With Me.CmbLocationID
            .DataSource = ds2.Tables("[Location Information]")
            .DisplayMember = "Location Name"
            .ValueMember = "Location ID"

        End With



    End Sub

    Private Sub BtnUpdate_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        'Data Update Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        Try
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "UPDATE [Stock Information] SET [Product ID]= '" + CmbProductID.SelectedValue.ToString + "', [Branch ID]= '" + CmbBranchID.SelectedValue.ToString + "',[Location ID] = '" + CmbLocationID.SelectedValue.ToString + "',[Quantity]= '" + TxtQuantity.Text + "' WHERE [Stock ID]= '" + TxtStockID.Text + "'"




            cmd.ExecuteNonQuery()



            'Update Click Msg
            MsgBox("Data Updated Successfully", MsgBoxStyle.OkOnly, "Stock Information")

            'Making Clear
            ClearData()

            'Refresh Data
            RefreshData()
        Catch ex As Exception
            MessageBox.Show("Error while Updating record on table..." & ex.Message, "Update Records")
        Finally
            con.Close()
        End Try


    End Sub
    'Creating Prive Sub For Clear Data
    Sub ClearData()
        TxtStockID.Text = ""
        CmbProductID.Text = ""
        CmbBranchID.Text = ""
        CmbLocationID.Text = ""
        TxtQuantity.Text = ""

    End Sub
    'Creating Prive Sub For Refresh Data
    Sub RefreshData()
        Try
            ' Load Data
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim connectionString As String = FrmHome.ConnectionString
            'Dim sql As String = "SELECT * FROM [Stock Information]"

            Dim sql As String = "SELECT [Stock Information].[Stock ID],[Products].[Barcode Serial],Products.[Product Name],[Branch Information].[Branch Name],[Location Information].[Location Name], [Stock Information].Quantity FROM [Stock Information]  Join [Products] on [Stock Information].[Product ID]= Products.[Product ID] Join [Branch Information] on [Stock Information].[Branch ID]= [Branch Information].[Branch ID] Join [Location Information] on [Stock Information].[Location ID]= [Location Information].[Location ID] Where [Stock Information].[Product ID] = " + Me.CmbProductID.SelectedValue.ToString + ""

            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Stock Information")
            connection.Close()
            GrdStockInformation.DataSource = ds
            GrdStockInformation.DataMember = "BizPro_Stock Information"

            'GrdStockInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdStockInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdStockInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            con.Close()

            'Total Row Count
            NumberofRow()


            'End Refresh Data
        Catch ex As Exception
            MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Records")
        Finally

        End Try


    End Sub

    Sub NumberofRow()
        Dim total As String = 0
        For i As Integer = 0 To GrdStockInformation.RowCount - 1
            total += GrdStockInformation.Rows(i).Cells(5).Value
        Next
        Me.Label1.Text = total
    End Sub



    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        'Data Delete Code
        Dim q As MsgBoxResult
        q = MsgBox("Do you really want to Delete the row?", MsgBoxStyle.YesNo, "Stock Information")
        If q = MsgBoxResult.Yes Then

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Try
                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "Delete from [Stock Information] where [Stock ID]= '" + TxtStockID.Text + "'"
                cmd.ExecuteNonQuery()


                'Making Clear
                ClearData()



                'Refresh Data
                RefreshData()

            Catch ex As Exception
                MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Records")
            Finally
                con.Close()
            End Try


        End If

    End Sub



    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        'Data Insert Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        Try
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO [Stock Information] ([Product ID],[Branch ID],[Location ID],Quantity) VALUES ('" + CmbProductID.SelectedValue.ToString + "','" + CmbBranchID.SelectedValue.ToString + "','" + CmbLocationID.SelectedValue.ToString + "','" + TxtQuantity.Text + "')"
            cmd.ExecuteNonQuery()


            'Refresh Data
            RefreshData()


        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            con.Close()

        End Try

    End Sub




    Private Sub TxtSearchProductID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CmbProductID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbProductID.KeyDown
        'Focus Ware house
        If e.KeyCode = Keys.Enter Then
            Me.CmbBranchID.Focus()

        End If
    End Sub

    Private Sub CmbProductID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbProductID.SelectedIndexChanged

    End Sub

    Private Sub CmbLocationID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbLocationID.KeyDown
        'Focus on Location ID
        If e.KeyCode = Keys.Enter Then
            Me.TxtQuantity.Focus()

        End If
        'If e.KeyCode = Keys.F4 Then
        'FrmListofLocations.Show()
        'FrmListofLocations.TxtSearchLocation.Focus()
        'End If
    End Sub



    Private Sub GrdStockInformation_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdStockInformation.CellContentClick

    End Sub

    Private Sub GrdStockInformation_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdStockInformation.CellMouseClick
        'Data Grid view Cell Mouse Double Click Code


        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdStockInformation.Rows(e.RowIndex)

                TxtStockID.Text = row.Cells("Stock ID").Value.ToString
                CmbProductID.Text = row.Cells("Product Name").Value.ToString
                CmbBranchID.Text = row.Cells("Branch Name").Value.ToString
                CmbLocationID.Text = row.Cells("Location Name").Value.ToString
                TxtQuantity.Text = row.Cells("Quantity").Value.ToString

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim dr As SqlDataReader

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "SELECT  *FROM [Stock Information]  WHERE [Stock ID] = " + Me.TxtStockID.Text + ""


                dr = cmd.ExecuteReader()
                dr.Read()

                Me.CmbProductID.SelectedValue = (dr.Item("Product ID").ToString)
                Me.CmbBranchID.SelectedValue = (dr.Item("Branch ID").ToString)
                Me.CmbLocationID.SelectedValue = (dr.Item("Location ID").ToString)


            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

        End Try
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        'Refresh Data
        RefreshData()

    End Sub
    Private Sub BtnAddNew_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click

        'Focus On Branch Name
        CmbProductID.Focus()

        'Making Clear
        ClearData()


    End Sub

    Private Sub TxtStockID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtStockID.KeyDown

    End Sub

    Private Sub TxtStockID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtStockID.TextChanged

    End Sub



    Private Sub PnlStockInformation_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PnlStockInformation.Paint

    End Sub

    Private Sub CmbLocationID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbLocationID.SelectedIndexChanged
        'Quantity Text box focus
        TxtQuantity.Focus()
    End Sub

    Private Sub TxtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try


                'Search Code
                ' Load Data
                Dim con As New SqlConnection
                Dim cmd As New SqlCommand

                Dim connectionString As String = FrmHome.ConnectionString
                If Me.CmbSearch.SelectedIndex = 0 Then
                    Dim sql As String = "SELECT [Stock Information].[Stock ID],[Products].[Barcode Serial],Products.[Product Name],[Branch Information].[Branch Name],[Location Information].[Location Name], [Stock Information].Quantity FROM [Stock Information]  Join [Products] on [Stock Information].[Product ID]= Products.[Product ID] Join [Branch Information] on [Stock Information].[Branch ID]= [Branch Information].[Branch ID] Join [Location Information] on [Stock Information].[Location ID]= [Location Information].[Location ID] WHERE ([Products].[Barcode Serial]  Like '%" + Me.TxtSearch.Text + "%')"

                    Dim connection As New SqlConnection(connectionString)

                    Dim dataadapter As New SqlDataAdapter(sql, connection)
                    Dim ds As New DataSet()
                    connection.Open()
                    dataadapter.Fill(ds, "BizPro_Products")
                    GrdStockInformation.DataSource = ds
                    GrdStockInformation.DataMember = "BizPro_Products"
                    GrdStockInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                    'Row Count
                    NumberofRow()

                    con.Close()


                End If
            Catch ex As Exception
                MessageBox.Show("Error while searching records on table..." & ex.Message, "Search Records")
            Finally

            End Try
        End If
    End Sub

    Private Sub TxtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearch.TextChanged
        Try



            'Search Code
            ' Load Data
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim connectionString As String = FrmHome.ConnectionString
            If Me.CmbSearch.SelectedIndex = 1 Then
                Dim sql As String = "SELECT [Stock Information].[Stock ID],[Products].[Barcode Serial],Products.[Product Name],[Branch Information].[Branch Name],[Location Information].[Location Name], [Stock Information].Quantity FROM [Stock Information]  Join [Products] on [Stock Information].[Product ID]= Products.[Product ID] Join [Branch Information] on [Stock Information].[Branch ID]= [Branch Information].[Branch ID] Join [Location Information] on [Stock Information].[Location ID]= [Location Information].[Location ID] WHERE ([Products].[Product Name]  Like '%" + Me.TxtSearch.Text + "%')"

                Dim connection As New SqlConnection(connectionString)

                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Products")
                GrdStockInformation.DataSource = ds
                GrdStockInformation.DataMember = "BizPro_Products"
                GrdStockInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                'Row Count
                NumberofRow()

                con.Close()

            ElseIf Me.CmbSearch.SelectedIndex = 2 Then


                Dim sql As String = "SELECT [Stock Information].[Stock ID],[Products].[Barcode Serial],Products.[Product Name],[Branch Information].[Branch Name],[Location Information].[Location Name], [Stock Information].Quantity FROM [Stock Information]  Join [Products] on [Stock Information].[Product ID]= Products.[Product ID] Join [Branch Information] on [Stock Information].[Branch ID]= [Branch Information].[Branch ID] Join [Location Information] on [Stock Information].[Location ID]= [Location Information].[Location ID] WHERE ([Location Information].[Location Name] Like '%" + Me.TxtSearch.Text + "%')"

                Dim connection As New SqlConnection(connectionString)

                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Products")
                GrdStockInformation.DataSource = ds
                GrdStockInformation.DataMember = "BizPro_Products"
                GrdStockInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                'Row Count
                NumberofRow()

                con.Close()

            End If
        Catch ex As Exception
            MessageBox.Show("Error while searching records on table..." & ex.Message, "Search Records")
        Finally

        End Try
    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        Try


            'Search Code
            ' Load Data
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim connectionString As String = FrmHome.ConnectionString
            If Me.CmbSearch.SelectedIndex = 0 Then
                Dim sql As String = "SELECT [Stock Information].[Stock ID],[Products].[Barcode Serial],Products.[Product Name],[Branch Information].[Branch Name],[Location Information].[Location Name], [Stock Information].Quantity FROM [Stock Information]  Join [Products] on [Stock Information].[Product ID]= Products.[Product ID] Join [Branch Information] on [Stock Information].[Branch ID]= [Branch Information].[Branch ID] Join [Location Information] on [Stock Information].[Location ID]= [Location Information].[Location ID] WHERE ([Products].[Barcode Serial]  Like '%" + Me.TxtSearch.Text + "%')"

                Dim connection As New SqlConnection(connectionString)

                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Products")
                GrdStockInformation.DataSource = ds
                GrdStockInformation.DataMember = "BizPro_Products"
                GrdStockInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                'Row Count
                NumberofRow()

                con.Close()


            End If
        Catch ex As Exception
            MessageBox.Show("Error while searching records on table..." & ex.Message, "Search Records")
        Finally

        End Try
    End Sub

    Private Sub CmbSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSearch.SelectedIndexChanged
        'search Text box Focus
        Me.TxtSearch.Focus()
    End Sub
End Class