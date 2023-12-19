Imports System.Data
Imports System.Data.SqlClient
Imports System.IO


Public Class FrmWarrantyDeliveryHistory
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point

    Dim WarrantyInvoiceNo As String


    Private Sub TxtSearchStudentID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearchWarrantyInvoice.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Search Sale Invoice
            SearchSaleInvoice()

            'Show Customer Details
            DataReaderForCustomerLabel()

            'Privet sub for refresh Warranty Delivery details
            RefreshWarrantyDeliveryDetails()

        End If

    End Sub

    ' Show Incomplete Warranty Delivery Data By Status And UserID
    Sub ShowIncompleteWarrantyDeliveryDataByStatusAndUserID()


        Try
 

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "Select [Warranty Delivery Invoice].[Warranty Delivery Invoice No],[Warranty Invoice Number].[Complainer Name],[Warranty Delivery Invoice].[Delivery Date],[Warranty Delivery Invoice].[Prepared Time]  from [Warranty Delivery Invoice] join [Warranty Invoice Number] on [Warranty Delivery Invoice].[Warranty Invoice No]=[Warranty Invoice Number].[Warranty Invoice No] where [Warranty Delivery Invoice].[User Account ID]='" + FrmHome.LblUserID.Text + "' and [Warranty Delivery Invoice].[Status]='INCOMPLETE' order by [Warranty Delivery Invoice].[Delivery Date] desc, [Warranty Delivery Invoice].[Prepared Time] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Warranty Delivery Invoice")
            connection.Close()
            GrdWarrantyDeliveryInvoice.DataSource = ds
            GrdWarrantyDeliveryInvoice.DataMember = "BizPro_Warranty Delivery Invoice"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdWarrantyDeliveryInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            




        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show Incomplete Sale Data By Invoice And UserID Sub")
        Finally

        End Try



    End Sub


    'Show Todays  Complete Warranty Delivery By loginID of Current Branch
    Sub ShowCompleteWarrantyDeliveryDataByUserIDTodayofCurrentBranch()

        Try
            
            Dim currentDate As DateTime = DateTime.Today

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "Select [Warranty Delivery Invoice].[Warranty Delivery Invoice No],[Warranty Invoice Number].[Complainer Name],[Warranty Delivery Invoice].[Delivery Date],[Warranty Delivery Invoice].[Prepared Time]  from [Warranty Delivery Invoice] join [Warranty Invoice Number] on [Warranty Delivery Invoice].[Warranty Invoice No]=[Warranty Invoice Number].[Warranty Invoice No]  where [Warranty Delivery Invoice].[User Account ID]='" + FrmHome.LblUserID.Text + "' and [Warranty Delivery Invoice].[Status]='COMPLETE' And [Warranty Delivery Invoice].[Branch ID]='" + FrmHome.lblBranchID.Text + "' order by [Warranty Delivery Invoice].[Delivery Date] desc, [Warranty Delivery Invoice].[Prepared Time] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Warranty Delivery Invoice")
            connection.Close()
            GrdWarrantyDeliveryInvoice.DataSource = ds
            GrdWarrantyDeliveryInvoice.DataMember = "BizPro_Warranty Delivery Invoice"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdWarrantyDeliveryInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill






        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show Complete Sale Data By UserID Today Sub")
        Finally

        End Try



    End Sub


    'Show  All Complete Warranty Delivery Invoice of Current Branch 
    Sub ShowAllCompleteWarrantyDeliveryDataofCurrentBranch()

        Try
            
            Dim currentDate As DateTime = DateTime.Today

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "Select [Warranty Delivery Invoice].[Warranty Delivery Invoice No],[Warranty Invoice Number].[Complainer Name],[Warranty Delivery Invoice].[Delivery Date],[Warranty Delivery Invoice].[Prepared Time]  from [Warranty Delivery Invoice] join [Warranty Invoice Number] on [Warranty Delivery Invoice].[Warranty Invoice No]=[Warranty Invoice Number].[Warranty Invoice No] where [Warranty Delivery Invoice].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Warranty Delivery Invoice].[Status]='COMPLETE' order by [Warranty Delivery Invoice].[Delivery Date] desc, [Warranty Delivery Invoice].[Prepared Time] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Warranty Invoice Number")
            connection.Close()
            GrdWarrantyDeliveryInvoice.DataSource = ds
            GrdWarrantyDeliveryInvoice.DataMember = "BizPro_Warranty Invoice Number"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdWarrantyDeliveryInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill






        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show All Complete Sale Data Sub")
        Finally

        End Try



    End Sub
    ' Search Sale Invoice

    Sub SearchSaleInvoice()
        Try

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "Select [Warranty Delivery Invoice].[Warranty Delivery Invoice No],[Warranty Invoice Number].[Complainer Name],[Warranty Delivery Invoice].[Delivery Date],[Warranty Delivery Invoice].[Prepared Time]  from [Warranty Delivery Invoice] join [Warranty Invoice Number] on [Warranty Delivery Invoice].[Warranty Invoice No]=[Warranty Invoice Number].[Warranty Invoice No] where [Warranty Delivery Invoice].[Warranty Delivery Invoice No]='" + TxtSearchWarrantyInvoice.Text + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Warranty Invoice Number")
            connection.Close()
            GrdWarrantyDeliveryInvoice.DataSource = ds
            GrdWarrantyDeliveryInvoice.DataMember = "BizPro_Warranty Invoice Number"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdWarrantyDeliveryInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill






        Catch ex As Exception
            MessageBox.Show("Error while Searching record on table..." & ex.Message, "Search Sale Invoice Sub")
        Finally

        End Try



    End Sub

    Private Sub TxtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearchWarrantyInvoice.TextChanged

    End Sub


    Private Sub GrdStudentPaymentInvoice_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub


    Private Sub GrdStudentPaymentInvoice_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        'Data Grid view code
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdWarrantyDeliveryInvoice.Rows(e.RowIndex)

                TxtSearchWarrantyInvoice.Text = row.Cells("Warranty Delivery Invoice No").Value.ToString



                'Show Students Details in label
                DataReaderForCustomerLabel()

                'Privet sub for refresh Warranty Delivery details
                RefreshWarrantyDeliveryDetails()


            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview")

        End Try

    End Sub


    'Privet sub for refresh Warranty Delivery details
    Sub RefreshWarrantyDeliveryDetails()

        Try


            
            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "Select [Warranty Delivery].[Warranty Delivery ID],products.[Product Name], [Warranty Delivery].[Delivery Quantity] from [Warranty Delivery] join [products] on [Warranty Delivery].[Product ID]= products.[Product ID] Where [Warranty Delivery Invoice No]='" + TxtSearchWarrantyInvoice.Text + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Warranty")
            connection.Close()
            GrdWarrantyDeliveryDetails.DataSource = ds
            GrdWarrantyDeliveryDetails.DataMember = "BizPro_Warranty"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdWarrantyDeliveryDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        




        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Refresh Sale Details Sub")

        End Try
    End Sub


    Private Sub GrdStudentPaymentInvoice_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)


        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdWarrantyDeliveryInvoice.Rows(e.RowIndex)


                If Me.TxtSearchWarrantyInvoice.Text = "" Then
                    MsgBox("Please select a row from list")
                Else


                    'Show form Student Payment 
                    FrmWarrantyDelivery.Show()

                    'Clear All Data
                    'FrmWarrantyDelivery.ClearData()


                    'Warranty Invoice no to search
                    FrmWarrantyDelivery.TxtSearch.Text = WarrantyInvoiceNo

                    'Search Warranty Invoice Number
                    FrmWarrantyDelivery.SearchWarrantyInvoiceNumber()


                    'Show Invoice Invoice
                    FrmWarrantyDelivery.TxtWarrantyDeliveryInvoiceNo.Text = Me.TxtSearchWarrantyInvoice.Text

                    'Show Date on Warranty
                    FrmWarrantyDelivery.DtpDeliveryDate.Value = row.Cells("Delivery Date").Value



                    'Refresh Warranty Delivery Products
                    FrmWarrantyDelivery.RefreshWarrantyDeliveryDetails()

                    'Refresh Data Serial Number
                    FrmWarrantyDelivery.RefreshDataDeliverySerial()

                    'Set Focus field
                    FrmWarrantyDelivery.TxtSerialNumber.Focus()


                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Cell Mouse Double Click Gridview")
        Finally

        End Try


    End Sub
    'Sub For Customer info show in label
    Sub DataReaderForCustomerLabel()

        Try



            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Warranty Delivery Invoice] join [Warranty Invoice Number] on [Warranty Delivery Invoice].[Warranty Invoice No]= [Warranty Invoice Number].[Warranty Invoice No] join [Customer Information] on [Warranty Invoice Number].[Customer ID]=[Customer Information].[Customer ID] WHERE [Warranty Delivery Invoice].[Warranty Delivery Invoice No] = '" + Me.TxtSearchWarrantyInvoice.Text + "'"


            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                WarrantyInvoiceNo = dr.Item("Warranty Invoice No").ToString
                Me.LblCustomerID.Text = dr.Item("Customer ID").ToString
                Me.LblCustomerName.Text = dr.Item("Complainer Name").ToString
                Me.LblMobileNo.Text = dr.Item("Complainer Mobile No").ToString

            ElseIf Not dr.HasRows Then

                MsgBox("No Customer Found")

                ClearData()

            End If

            dr.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while Searching Customer ..." & ex.Message, "Data Reader For Customer Label Sub")

        End Try

    End Sub
    'Clear Data

    Sub ClearData()


        LblCustomerName.Text = ""
        LblCustomerID.Text = ""
        LblMobileNo.Text = ""

        TxtSearchWarrantyInvoice.Text = ""
    End Sub


    Private Sub FrmStudentPaymentHistory_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub


    Private Sub FrmStudentPaymentHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 0)
        Me.Size = My.Computer.Screen.WorkingArea.Size







        'Change Language
        ChangeLanguage()



        ' Show Incomplete Warranty Delivery Data By Status And UserID
        ShowIncompleteWarrantyDeliveryDataByStatusAndUserID()


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

                Me.TxtSearchWarrantyInvoice.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.LblCustomerID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.LblCustomerName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.LblMobileNo.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))


                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

                Me.GrdWarrantyDeliveryInvoice.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdWarrantyDeliveryInvoice.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)

                Me.GrdWarrantyDeliveryDetails.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdWarrantyDeliveryDetails.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)
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

    Private Sub GrdStudentPaymentInvoice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Sub DeleteCustomerLedger()


        Try
            Dim con As New SqlConnection
            Dim con1 As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now


            Dim cmd2 As New SqlCommand
            Dim dr As SqlDataReader



            con1.ConnectionString = FrmHome.ConnectionString
            con1.Open()
            cmd2.Connection = con1
            cmd2.CommandText = "SELECT  *FROM [Customer Ledger]  WHERE [Sale Invoice No] = '" + TxtSearchWarrantyInvoice.Text + "'"
            dr = cmd2.ExecuteReader()
            dr.Read()


            If dr.HasRows Then



                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd1.Connection = con
                cmd.CommandText = "Delete from [Customer Ledger] where [Sale Invoice No]= '" + TxtSearchWarrantyInvoice.Text + "'"
                cmd1.CommandText = "INSERT INTO [Log Details] ([Log Category],[Log Description],[User Account ID],[Log Date],[Log Time],[Task ID]) VALUES ('Bank Transaction','Data Deleted Successfully','" + FrmHome.LblUserID.Text + "','" + currentDate + "','" + currentTime + "','" + TxtSearchWarrantyInvoice.Text + "')"
                cmd.ExecuteNonQuery()
                cmd1.ExecuteNonQuery()
                con.Close()

            End If


            dr.Close()
            con1.Close()

        Catch ex As Exception
            MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Customer Ledger Sub")
        Finally

        End Try


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub


    'Show All Incomplete warranty
    Sub ShowAllIncompleteWarranty()

        Try
             
            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "Select [Warranty Delivery Invoice].[Warranty Delivery Invoice No],[Warranty Invoice Number].[Complainer Name],[Warranty Delivery Invoice].[Delivery Date],[Warranty Delivery Invoice].[Prepared Time]  from [Warranty Delivery Invoice] join [Warranty Invoice Number] on [Warranty Delivery Invoice].[Warranty Invoice No]=[Warranty Invoice Number].[Warranty Invoice No] where  [Warranty Delivery Invoice].[Status]='INCOMPLETE' order by [Warranty Delivery Invoice].[Delivery Date] desc, [Warranty Delivery Invoice].[Prepared Time] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Warranty Invoice Number")
            connection.Close()
            GrdWarrantyDeliveryInvoice.DataSource = ds
            GrdWarrantyDeliveryInvoice.DataMember = "BizPro_Warranty Invoice Number"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdWarrantyDeliveryInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill






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

        'If FrmHome.LblUserName.Text = "Admin" Then
        'Show Todays  Complete Sale By loginID
        'ShowCompleteSaleDataByUserIDToday()
        'Else

        'Show Todays  Complete Warranty Delivery By loginID of Current Branch
        ShowCompleteWarrantyDeliveryDataByUserIDTodayofCurrentBranch()
        'End If

        'Privet sub for refresh Warranty Delivery details
        RefreshWarrantyDeliveryDetails()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        'Clear data
        ClearData()

        'If FrmHome.LblUserName.Text = "Admin" Then
        'Show  All Complete Invoice 
        'ShowAllCompleteSaleData()

        'Else

        'Show  All Complete Warranty Delivery Invoice of Current Branch 
        ShowAllCompleteWarrantyDeliveryDataofCurrentBranch()
        'End If

        'Privet sub for refresh Warranty Delivery details
        RefreshWarrantyDeliveryDetails()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        'Clear data
        ClearData()

        ' Show Incomplete Warranty Delivery Data By Status And UserID
        ShowIncompleteWarrantyDeliveryDataByStatusAndUserID()


        'Privet sub for refresh Warranty Delivery details
        RefreshWarrantyDeliveryDetails()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        'Clear data
        ClearData()


        'Show All Incomplete Warranty
        ShowAllIncompleteWarranty()

        'Privet sub for refresh Warranty Delivery details
        RefreshWarrantyDeliveryDetails()

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

    Private Sub GrdWarrantyDeliveryInvoice_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdWarrantyDeliveryInvoice.CellContentClick

    End Sub

    Private Sub GrdWarrantyDeliveryInvoice_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdWarrantyDeliveryInvoice.CellMouseClick
        'Data Grid view code
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdWarrantyDeliveryInvoice.Rows(e.RowIndex)

                TxtSearchWarrantyInvoice.Text = row.Cells("Warranty Delivery Invoice No").Value.ToString



                'Show Students Details in label
                DataReaderForCustomerLabel()

                'Privet sub for refresh Warranty Delivery details
                RefreshWarrantyDeliveryDetails()


            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview")

        End Try
    End Sub

    Private Sub GrdWarrantyDeliveryInvoice_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdWarrantyDeliveryInvoice.CellMouseDoubleClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdWarrantyDeliveryInvoice.Rows(e.RowIndex)


                If Me.TxtSearchWarrantyInvoice.Text = "" Then
                    MsgBox("Please select a row from list")
                Else


                    'Show form Student Payment 
                    FrmWarrantyDelivery.Show()

                    'Clear All Data
                    'FrmWarrantyDelivery.ClearData()


                    'Warranty Invoice no to search
                    FrmWarrantyDelivery.TxtSearch.Text = WarrantyInvoiceNo

                    'Search Warranty Invoice Number
                    FrmWarrantyDelivery.SearchWarrantyInvoiceNumber()


                    'Show Invoice Invoice
                    FrmWarrantyDelivery.TxtWarrantyDeliveryInvoiceNo.Text = Me.TxtSearchWarrantyInvoice.Text

                    'Show Date on Warranty
                    FrmWarrantyDelivery.DtpDeliveryDate.Value = row.Cells("Delivery Date").Value



                    'Refresh Warranty Delivery Products
                    FrmWarrantyDelivery.RefreshWarrantyDeliveryDetails()

                    'Refresh Data Serial Number
                    FrmWarrantyDelivery.RefreshDataDeliverySerial()

                    'Set Focus field
                    FrmWarrantyDelivery.TxtSerialNumber.Focus()


                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Cell Mouse Double Click Gridview")
        Finally

        End Try
    End Sub

    Private Sub GrdWarrantyDeliveryDetails_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdWarrantyDeliveryDetails_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdWarrantyDeliveryDetails.CellContentClick

    End Sub

    Private Sub GrdWarrantyDeliveryDetails_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdWarrantyDeliveryDetails.CellMouseClick

    End Sub

    Private Sub GrdWarrantyDeliveryDetails_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdWarrantyDeliveryDetails.CellMouseDoubleClick

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