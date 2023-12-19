Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmWarrantyHistory
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point


    Private Sub TxtSearchStudentID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearchWarrantyInvoice.KeyDown
        If e.KeyCode = Keys.Enter Then

            'Search Warranty Invoice
            SearchWarrantyInvoice()

            'Show Customer Details
            DataReaderForCustomerLabel()

            'Privet sub for refresh Warranty details
            RefreshWarrantyDetails()
        End If

    End Sub

    ' Show Incomplete Warranty Data By Status And UserID
    Sub ShowIncompleteWarrantyDataByStatusAndUserID()


        Try
             
            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "Select [Warranty Invoice Number].[Warranty Invoice No],[Warranty Invoice Number].[Complainer Name],[Warranty Invoice Number].[Received Date],[Warranty Invoice Number].[Prepared Time]  from [Warranty Invoice Number] where [Warranty Invoice Number].[User Account ID]='" + FrmHome.LblUserID.Text + "' and [Warranty Invoice Number].[Status]='INCOMPLETE' order by [Warranty Invoice Number].[Received Date] desc, [Warranty Invoice Number].[Prepared Time] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Warranty Invoice Number")
            connection.Close()
            GrdWarrantyInvoice.DataSource = ds
            GrdWarrantyInvoice.DataMember = "BizPro_Warranty Invoice Number"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdWarrantyInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill






        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show Incomplete Sale Data By Invoice And UserID Sub")
        Finally

        End Try



    End Sub
    'Show Todays  Complete Sale By loginID 

    Sub ShowCompleteSaleDataByUserIDToday()

        Try
            
            Dim currentDate As DateTime = DateTime.Today

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Sale Invoice].[Sale Invoice No],[Customer Information].[Customer Name],[Sale Invoice].[Sale Date],[Sale Invoice].[Sale Time],[Sale Invoice].[Total] from [Sale Invoice]  join [User Account] on [Sale Invoice].[User Account ID]=[User Account].[User Account ID]join [Customer Information] on [Sale Invoice].[Customer ID]=[Customer Information].[Customer ID]   where [User Account].[User Account ID]='" + FrmHome.LblUserID.Text + "' and [Sale Invoice].[Status]='COMPLETE' and [Sale Invoice].[Sale Date]= '" + currentDate + "'  order by [Sale Invoice].[Sale Date] desc, [Sale Invoice].[Sale Time] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Warranty Invoice Number")
            connection.Close()
            GrdWarrantyInvoice.DataSource = ds
            GrdWarrantyInvoice.DataMember = "BizPro_Warranty Invoice Number"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdWarrantyInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill






        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show Complete Sale Data By UserID Today Sub")
        Finally

        End Try



    End Sub
    'Show Todays  Complete Warranty By loginID of Current Branch
    Sub ShowCompleteWarrantyDataByUserIDTodayofCurrentBranch()

        Try
           
            Dim currentDate As DateTime = DateTime.Today

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "Select [Warranty Invoice Number].[Warranty Invoice No],[Warranty Invoice Number].[Complainer Name],[Warranty Invoice Number].[Received Date],[Warranty Invoice Number].[Prepared Time]  from [Warranty Invoice Number] where [Warranty Invoice Number].[User Account ID]='" + FrmHome.LblUserID.Text + "' and [Warranty Invoice Number].[Status]='COMPLETE' And [Warranty Invoice Number].[Branch ID]='" + FrmHome.lblBranchID.Text + "' And [Warranty Invoice Number].[Received Date]='" + currentDate + "' order by [Warranty Invoice Number].[Received Date] desc, [Warranty Invoice Number].[Prepared Time] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Warranty Invoice Number")
            connection.Close()
            GrdWarrantyInvoice.DataSource = ds
            GrdWarrantyInvoice.DataMember = "BizPro_Warranty Invoice Number"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdWarrantyInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill






        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show Complete Sale Data By UserID Today Sub")
        Finally

        End Try



    End Sub

    'Show  All Complete Invoice 

    Sub ShowAllCompleteSaleData()

        Try
             
            Dim currentDate As DateTime = DateTime.Today

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Sale Invoice].[Sale Invoice No],[Customer Information].[Customer Name],[Sale Invoice].[Sale Date],[Sale Invoice].[Sale Time],[Sale Invoice].[Total] from [Sale Invoice]  join [User Account] on [Sale Invoice].[User Account ID]=[User Account].[User Account ID]join [Customer Information] on [Sale Invoice].[Customer ID]=[Customer Information].[Customer ID]   where [Sale Invoice].[Status]='COMPLETE'  order by [Sale Invoice].[Sale Date]  desc, [Sale Invoice].[Sale Time] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Warranty Invoice Number")
            connection.Close()
            GrdWarrantyInvoice.DataSource = ds
            GrdWarrantyInvoice.DataMember = "BizPro_Warranty Invoice Number"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdWarrantyInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
             




        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show All Complete Sale Data Sub")
        Finally

        End Try



    End Sub
    'Show  All Complete Invoice of Current Branch 

    Sub ShowAllCompleteWarrantyDataofCurrentBranch()

        Try
            
            Dim currentDate As DateTime = DateTime.Today

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "Select [Warranty Invoice Number].[Warranty Invoice No],[Warranty Invoice Number].[Complainer Name],[Warranty Invoice Number].[Received Date],[Warranty Invoice Number].[Prepared Time]  from [Warranty Invoice Number] where [Warranty Invoice Number].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Warranty Invoice Number].[Status]='COMPLETE' order by [Warranty Invoice Number].[Received Date] desc, [Warranty Invoice Number].[Prepared Time] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Warranty Invoice Number")
            connection.Close()
            GrdWarrantyInvoice.DataSource = ds
            GrdWarrantyInvoice.DataMember = "BizPro_Warranty Invoice Number"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdWarrantyInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill






        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show All Complete Sale Data Sub")
        Finally

        End Try



    End Sub
    ' Search Warranty Invoice
    Sub SearchWarrantyInvoice()
        Try
            
            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "Select [Warranty Invoice Number].[Warranty Invoice No],[Warranty Invoice Number].[Complainer Name],[Warranty Invoice Number].[Received Date],[Warranty Invoice Number].[Prepared Time]  from [Warranty Invoice Number] where [Warranty Invoice Number].[Warranty Invoice No]='" + TxtSearchWarrantyInvoice.Text + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Warranty Invoice Number")
            connection.Close()
            GrdWarrantyInvoice.DataSource = ds
            GrdWarrantyInvoice.DataMember = "BizPro_Warranty Invoice Number"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdWarrantyInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill






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


    End Sub


    'Privet sub for refresh Warranty details
    Sub RefreshWarrantyDetails()

        Try


             

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "Select Warranty.[Warranty ID],products.[Product Name], Warranty.[Warranty Quantity] from [Warranty] join [products] on Warranty.[Product ID]= products.[Product ID] Where [Warranty Invoice No]='" + TxtSearchWarrantyInvoice.Text + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Warranty")
            connection.Close()
            GrdWarrantyDetails.DataSource = ds
            GrdWarrantyDetails.DataMember = "BizPro_Warranty"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdWarrantyDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            




        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Refresh Sale Details Sub")

        End Try
    End Sub


    Private Sub GrdStudentPaymentInvoice_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)



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
            cmd.CommandText = "SELECT  *FROM [Warranty Invoice Number] join [Customer Information] on [Warranty Invoice Number].[Customer ID]=[Customer Information].[Customer ID] WHERE [Warranty Invoice Number].[Warranty Invoice No] = '" + Me.TxtSearchWarrantyInvoice.Text + "'"


            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then


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



        'Show Incomplete warranty Data By Status And User ID
        ShowIncompleteWarrantyDataByStatusAndUserID()


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

                Me.GrdWarrantyInvoice.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdWarrantyInvoice.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)

                Me.GrdWarrantyDetails.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdWarrantyDetails.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)
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
            Dim sql As String = "Select [Warranty Invoice Number].[Warranty Invoice No],[Warranty Invoice Number].[Complainer Name],[Warranty Invoice Number].[Received Date],[Warranty Invoice Number].[Prepared Time]  from [Warranty Invoice Number] where  [Warranty Invoice Number].[Status]='INCOMPLETE' order by [Warranty Invoice Number].[Received Date] desc, [Warranty Invoice Number].[Prepared Time] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Warranty Invoice Number")
            connection.Close()
            GrdWarrantyInvoice.DataSource = ds
            GrdWarrantyInvoice.DataMember = "BizPro_Warranty Invoice Number"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdWarrantyInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
          




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

        'Show Todays  Complete Warranty By loginID of Current Branch
        ShowCompleteWarrantyDataByUserIDTodayofCurrentBranch()
        'End If

        'Privet sub for refresh Warranty details
        RefreshWarrantyDetails()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        'Clear data
        ClearData()

        'If FrmHome.LblUserName.Text = "Admin" Then
        'Show  All Complete Invoice 
        'ShowAllCompleteSaleData()

        'Else

        'Show  All Complete Invoice of Current Branch 
        ShowAllCompleteWarrantyDataofCurrentBranch()
        'End If

        'Privet sub for refresh Warranty details
        RefreshWarrantyDetails()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        'Clear data
        ClearData()

        'Show Incomplete warranty Data By Status And User ID
        ShowIncompleteWarrantyDataByStatusAndUserID()

        'Privet sub for refresh Warranty details
        RefreshWarrantyDetails()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        'Clear data
        ClearData()


        'Show All Incomplete Warranty
        ShowAllIncompleteWarranty()


        'Privet sub for refresh Warranty details
        RefreshWarrantyDetails()
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

    Private Sub GrdWarrantyInvoice_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdWarrantyInvoice.CellContentClick

    End Sub

    Private Sub GrdWarrantyInvoice_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdWarrantyInvoice.CellMouseClick
        'Data Grid view code
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdWarrantyInvoice.Rows(e.RowIndex)

                TxtSearchWarrantyInvoice.Text = row.Cells("Warranty Invoice No").Value.ToString



                'Show Students Details in label
                DataReaderForCustomerLabel()

                'Privet sub for refresh Warranty details
                RefreshWarrantyDetails()



            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview")

        End Try
    End Sub

    Private Sub GrdWarrantyInvoice_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdWarrantyInvoice.CellMouseDoubleClick
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdWarrantyInvoice.Rows(e.RowIndex)


                If Me.TxtSearchWarrantyInvoice.Text = "" Then
                    MsgBox("Please select a row from list")
                Else


                    'Show form Student Payment 
                    FrmWarrantyLookUp.Show()

                    'Clear All Data
                    FrmWarrantyLookUp.ClearAllData()

                    'Sale Invoice
                    FrmWarrantyLookUp.TxtWarrantyInvoiceNo.Text = Me.TxtSearchWarrantyInvoice.Text

                    'Show Date on Warranty
                    FrmWarrantyLookUp.DtpReceiveDate.Value = row.Cells("Received Date").Value

                    'Refresh data
                    FrmWarrantyLookUp.RefreshDataWarrantyProducts()


                    'Set Focus field
                    FrmWarrantyLookUp.TxtSerialNumber.Focus()

                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Cell Mouse Double Click Gridview")
        Finally

        End Try
    End Sub

    Private Sub GrdWarrantyDetails_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

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