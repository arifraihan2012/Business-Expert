Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmProductTransferHistory
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point
    Private Sub TxtSearchStudentID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearchInvoice.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Search Sale Invoice
            SearchProductTransferInvoice()



            'Refresh Data sale
            RefreshProductTransferDetails()

        End If

    End Sub

    ' Show Incomplete Sale Data By Status And UserID
    Sub ShowIncompleteTransferDataByStatusAndUserID()


        Try
            
            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Product Transfer Invoice].[Transfer Invoice No],[Product Transfer Invoice].[Transfer Date],[User Account].[User Name],[Branch Information].[Branch Name] from [Product Transfer Invoice] join  [User Account] on [Product Transfer Invoice].[User Account ID]=[User Account].[User Account ID]join [Branch Information] on [Product Transfer Invoice].[Branch ID]=[Branch Information].[Branch ID] where [User Account].[User Account ID]='" + FrmHome.LblUserID.Text + "' and [Product Transfer Invoice].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Product Transfer Invoice].[Status]='INCOMPLETE' order by [Product Transfer Invoice].[Transfer Invoice No] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Product Transfer Invoice")
            connection.Close()
            GrdSaleInvoice.DataSource = ds
            GrdSaleInvoice.DataMember = "BizPro_Product Transfer Invoice"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdSaleInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill






        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show Incomplete Sale Data By Invoice And UserID Sub")
        Finally

        End Try



    End Sub
    'Show Todays  Complete Transfer By login ID 

    Sub ShowCompleteTransferDataByUserIDToday()

        Try
             
            Dim currentDate As DateTime = DateTime.Today

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Product Transfer Invoice].[Transfer Invoice No],[Product Transfer Invoice].[Transfer Date],[User Account].[User Name],[Branch Information].[Branch Name] from [Product Transfer Invoice] join  [User Account] on [Product Transfer Invoice].[User Account ID]=[User Account].[User Account ID]join [Branch Information] on [Product Transfer Invoice].[Branch ID]=[Branch Information].[Branch ID] where [User Account].[User Account ID]='" + FrmHome.LblUserID.Text + "' and [Product Transfer Invoice].[Branch ID]='" + FrmHome.lblBranchID.Text + "'and [Product Transfer Invoice].[Status]='COMPLETE' And [Product Transfer Invoice].[transfer Date] = '" + currentDate + "' order by [Product Transfer Invoice].[Transfer Invoice No] desc  "
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Product Transfer Invoice")
            connection.Close()
            GrdSaleInvoice.DataSource = ds
            GrdSaleInvoice.DataMember = "BizPro_Product Transfer Invoice"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdSaleInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill






        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show Complete Sale Data By UserID Today Sub")
        Finally

        End Try



    End Sub
    'Show  All Complete Invoice 

    Sub ShowAllCompleteTransferData()

        Try
             
            Dim currentDate As DateTime = DateTime.Today

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Product Transfer Invoice].[Transfer Invoice No],[Product Transfer Invoice].[Transfer Date],[User Account].[User Name],[Branch Information].[Branch Name] from [Product Transfer Invoice] join  [User Account] on [Product Transfer Invoice].[User Account ID]=[User Account].[User Account ID]join [Branch Information] on [Product Transfer Invoice].[Branch ID]=[Branch Information].[Branch ID] where  [Product Transfer Invoice].[Status]='COMPLETE' and  [Product Transfer Invoice].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [User Account].[User Account ID]='" + FrmHome.LblUserID.Text + "'  order by [Product Transfer Invoice].[Transfer Invoice No] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Product Transfer Invoice")
            connection.Close()
            GrdSaleInvoice.DataSource = ds
            GrdSaleInvoice.DataMember = "BizPro_Product Transfer Invoice"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdSaleInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill






        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show All Complete Sale Data Sub")
        Finally

        End Try



    End Sub
    ' Search Sale Invoice

    Sub SearchProductTransferInvoice()
        Try
             

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Product Transfer Invoice].[Transfer Invoice No],[Product Transfer Invoice].[Transfer Date],[User Account].[User Name],[Branch Information].[Branch Name] from [Product Transfer Invoice] join  [User Account] on [Product Transfer Invoice].[User Account ID]=[User Account].[User Account ID]join [Branch Information] on [Product Transfer Invoice].[Branch ID]=[Branch Information].[Branch ID] where  [Product Transfer Invoice].[Transfer Invoice No] = '" + TxtSearchInvoice.Text + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Product Transfer Invoice")
            connection.Close()
            GrdSaleInvoice.DataSource = ds
            GrdSaleInvoice.DataMember = "BizPro_Product Transfer Invoice"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdSaleInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill






        Catch ex As Exception
            MessageBox.Show("Error while Searching record on table..." & ex.Message, "Search Sale Invoice Sub")
        Finally

        End Try



    End Sub

    Private Sub TxtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearchInvoice.TextChanged

    End Sub


    Private Sub GrdStudentPaymentInvoice_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdSaleInvoice.CellContentClick

    End Sub

    Private Sub GrdStudentPaymentInvoice_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdSaleInvoice.CellMouseClick
        'Data Grid view code
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdSaleInvoice.Rows(e.RowIndex)

                TxtSearchInvoice.Text = row.Cells("Transfer Invoice No").Value.ToString





                'RefreshSale Details
                RefreshProductTransferDetails()



            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview")

        End Try

    End Sub


    'Privet sub for refresh sale details
    Sub RefreshProductTransferDetails()

        Try


            


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select [Product Transfer].[Transfer ID],[Branch Information].[Branch Name][Transfer To Branch],[Products].[Product Name],[Added Quantity][Transfer Quantity] from [product transfer] join [Products] on [product transfer].[product ID]=[products].[Product ID] join [Branch Information] on [Product Transfer].[Transfer Branch ID] = [Branch Information].[Branch ID] where [Status]='Added' And [Transfer Invoice No]= '" + TxtSearchInvoice.Text + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Product Transfer")
            connection.Close()
            GrdSale.DataSource = ds
            GrdSale.DataMember = "BizPro_Product Transfer"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdSale.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill







        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Refresh Sale Details Sub")

        End Try
    End Sub


    Private Sub GrdStudentPaymentInvoice_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdSaleInvoice.CellMouseDoubleClick
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdSaleInvoice.Rows(e.RowIndex)


                If Me.TxtSearchInvoice.Text = "" Then
                    MsgBox("Please select a row from list")
                Else

                    If row.Cells("Branch Name").Value.ToString = FrmHome.LblBranchName.Text Then
                        'Show form Product Transfer 
                        FrmProductTransfer.Show()

                        'Transfer Invoice And date
                        FrmProductTransfer.TxtProductTransferInvoiceNo.Text = Me.TxtSearchInvoice.Text
                        FrmProductTransfer.DtpTransferDate.Value = row.Cells("Transfer Date").Value


                        'Focus on Product Name field
                        FrmProductTransfer.cmbProductName.Focus()

                        'Search Purchase Invoice
                        FrmProductTransfer.RefreshDataProductTransfer()

                        'Product Transfer edit confirmation
                        FrmProductTransfer.ProductTransferEditStatus = True
                    Else
                        MsgBox("You do not have permission to edit invoice of other branch .", MsgBoxStyle.Critical, "Product Transfer History")
                    End If

                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Cell Mouse Double Click Gridview")
        Finally

        End Try


    End Sub

    'Clear Data

    Sub ClearData()

        TxtSearchInvoice.Text = ""
    End Sub


    Private Sub FrmStudentPaymentHistory_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub


    Private Sub FrmStudentPaymentHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 0)
        Me.Size = My.Computer.Screen.WorkingArea.Size


        'Change Language
        ChangeLanguage()



        'Show Incomplete Sale Data By Status And User ID
        ShowIncompleteTransferDataByStatusAndUserID()


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


                Me.TxtSearchInvoice.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))


                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

                Me.GrdSaleInvoice.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdSaleInvoice.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)

                Me.GrdSale.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdSale.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)
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

    Private Sub GrdStudentPaymentInvoice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdSaleInvoice.KeyDown

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub


    'Show All Incomplete Product Transfer
    Sub ShowAllIncompleteProductTransfer()

        Try
             

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Product Transfer Invoice].[Transfer Invoice No],[Product Transfer Invoice].[Transfer Date],[User Account].[User Name],[Branch Information].[Branch Name] from [Product Transfer Invoice] join  [User Account] on [Product Transfer Invoice].[User Account ID]=[User Account].[User Account ID]join [Branch Information] on [Product Transfer Invoice].[Branch ID]=[Branch Information].[Branch ID] where  [Product Transfer Invoice].[Status]='INCOMPLETE' and [Product Transfer Invoice].[Branch ID]='" + FrmHome.lblBranchID.Text + "' order by [Product Transfer Invoice].[Transfer Invoice No] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Product Transfer Invoice")
            connection.Close()
            GrdSaleInvoice.DataSource = ds
            GrdSaleInvoice.DataMember = "BizPro_Product Transfer Invoice"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdSaleInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill






        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show All Incomplete Sale  Sub")
        Finally

        End Try



    End Sub

    'Show All Pending Product Transfer
    Sub ShowAllIPendingProductTransfer()

        Try
             

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Product Transfer Invoice].[Transfer Invoice No],[Product Transfer Invoice].[Transfer Date],[User Account].[User Name],[Branch Information].[Branch Name] from [Product Transfer Invoice] join  [User Account] on [Product Transfer Invoice].[User Account ID]=[User Account].[User Account ID]join [Branch Information] on [Product Transfer Invoice].[Branch ID]=[Branch Information].[Branch ID] where  [Product Transfer Invoice].[Status]='Pending' and [Product Transfer Invoice].[Branch ID]='" + FrmHome.lblBranchID.Text + "' order by [Product Transfer Invoice].[Transfer Invoice No] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Product Transfer Invoice")
            connection.Close()
            GrdSaleInvoice.DataSource = ds
            GrdSaleInvoice.DataMember = "BizPro_Product Transfer Invoice"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdSaleInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill






        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show All Incomplete Sale  Sub")
        Finally

        End Try



    End Sub



    Private Sub TxtUpdate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        'Clear data
        ClearData()


        'Show Todays  Complete Transfer By login ID
        ShowCompleteTransferDataByUserIDToday()

        'Refresh Data sale
        RefreshProductTransferDetails()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        'Clear data
        ClearData()

        'Show  All Complete Invoice 
        ShowAllCompleteTransferData()

        'Refresh Data sale
        RefreshProductTransferDetails()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        'Clear data
        ClearData()

        'Show Incomplete Sale Data By Status And User ID
        ShowIncompleteTransferDataByStatusAndUserID()

        'Refresh Data sale
        RefreshProductTransferDetails()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        'Clear data
        ClearData()

        'Show All Incomplete Product Transfer
        ShowAllIncompleteProductTransfer()

        'Refresh Data sale
        RefreshProductTransferDetails()
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

    Private Sub Btnminimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnminimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseMove
        ' If e.Button = Windows.Forms.MouseButtons.Left Then
        ' newpoint = Control.MousePosition
        ' newpoint.X -= (X)
        '  newpoint.Y -= (Y)
        '  Me.Location = newpoint

        'End If
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'Clear data
        ClearData()

        'Show Pending Data By Status And User ID
        ShowAllIPendingProductTransfer()

        'Refresh Data sale
        RefreshProductTransferDetails()
    End Sub
End Class