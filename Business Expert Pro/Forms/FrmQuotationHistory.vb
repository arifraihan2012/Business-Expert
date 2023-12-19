Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmQuotationHistory
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point

    Private Sub TxtSearchStudentID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearchQuotationInvoice.KeyDown
        If e.KeyCode = Keys.Enter Then

            'Search Student
            SearchAllCompleteIncomplete()

            'Refresh quotation
            RefreshQuotationDetails()

            'Show Students Details
            DataReaderForCustomerLabel()
        End If

    End Sub
    'Search Student Incomplete BY loginID

    Sub SearchQuotationDataByInvoiceAndUserID()

        Try
             

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Quotation Invoice].[Quotation Invoice No],[Customer Information].[Customer Name],[Quotation Invoice].[Quotation Date],[Quotation Invoice].[Quotation Time],[Quotation Invoice].[Total Amount] from [Quotation Invoice] join [User Account] on [Quotation Invoice].[User Account ID]=[User Account].[User Account ID]join [Customer Information] on [Quotation Invoice].[Customer ID]=[Customer Information].[Customer ID]   where [User Account].[User Account ID]='" + FrmHome.LblUserID.Text + "' and [Quotation Invoice].[Status]='INCOMPLETE' order by [Quotation Invoice].[Quotation Date] desc, [Quotation Invoice].[Quotation Time] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Quotation Invoice")
            connection.Close()
            GrdQuotationInvoice.DataSource = ds
            GrdQuotationInvoice.DataMember = "BizPro_Quotation Invoice"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdQuotationInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill






        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try



    End Sub
    'Search Student Incomplete BY loginID

    Sub SearchCompleteQuotationDataByInvoiceAndUserID()

        Try
             
            Dim currentDate As DateTime = DateTime.Today

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Quotation Invoice].[Quotation Invoice No],[Customer Information].[Customer Name],[Quotation Invoice].[Quotation Date],[Quotation Invoice].[Quotation Time],[Quotation Invoice].[Total Amount] from [Quotation Invoice] join [User Account] on [Quotation Invoice].[User Account ID]=[User Account].[User Account ID]join [Customer Information] on [Quotation Invoice].[Customer ID]=[Customer Information].[Customer ID]   where [User Account].[User Account ID]='" + FrmHome.LblUserID.Text + "' and [Quotation Invoice].[Status]='COMPLETE' and [Quotation Invoice].[Quotation Date]= '" + currentDate + "' order by [Quotation Invoice].[Quotation Date] desc, [Quotation Invoice].[Quotation Time] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Quotation Invoice")
            connection.Close()
            GrdQuotationInvoice.DataSource = ds
            GrdQuotationInvoice.DataMember = "BizPro_Quotation Invoice"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdQuotationInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill






        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try



    End Sub
    'Search Student Incomplete BY loginID

    Sub SearchAllCompleteQuotationData()

        Try

            Dim currentDate As DateTime = DateTime.Today

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Quotation Invoice].[Quotation Invoice No],[Customer Information].[Customer Name],[Quotation Invoice].[Quotation Date],[Quotation Invoice].[Quotation Time],[Quotation Invoice].[Total Amount] from [Quotation Invoice]  join [User Account] on [Quotation Invoice].[User Account ID]=[User Account].[User Account ID]join [Customer Information] on [Quotation Invoice].[Customer ID]=[Customer Information].[Customer ID]   where [Quotation Invoice].[Status]='COMPLETE'  order by [Quotation Invoice].[Quotation Date] desc, [Quotation Invoice].[Quotation Time] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Quotation Invoice")
            connection.Close()
            GrdQuotationInvoice.DataSource = ds
            GrdQuotationInvoice.DataMember = "BizPro_Quotation Invoice"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdQuotationInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill






        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try



    End Sub
    'Search Student

    Sub SearchAllCompleteIncomplete()

        Try
        
            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Quotation Invoice].[Quotation Invoice No],[Quotation Invoice].[Quotation Date],[Quotation Invoice].[Quotation Time],[Quotation Invoice].[Total Amount],[Customer Information].[customer name] from [Quotation Invoice] join [User Account] on [Quotation Invoice].[User Account ID]=[User Account].[User Account ID] join [Customer Information] on [Quotation Invoice].[Customer ID]=[Customer Information].[Customer ID] where  [Quotation Invoice].[Quotation Invoice No] = '" + TxtSearchQuotationInvoice.Text + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Quotation Invoice")
            connection.Close()
            GrdQuotationInvoice.DataSource = ds
            GrdQuotationInvoice.DataMember = "BizPro_Quotation Invoice"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdQuotationInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill






        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try



    End Sub

    Private Sub TxtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearchQuotationInvoice.TextChanged

    End Sub


    Private Sub GrdStudentPaymentInvoice_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdStudentPaymentInvoice_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)


    End Sub


    'Privet sub for refresh Quotation details
    Sub RefreshQuotationDetails()

        Try


             


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Quotation].[Quotation ID],[Products].[Product Name],[Quotation].[Quotation Quantity],[Quotation].[Quotation Unit Price],[Quotation].[Quotation Amount] from [Quotation] join [Products] on [Quotation].[product ID]=[products].[Product ID] where [Quotation].[Quotation Invoice No]= '" + TxtSearchQuotationInvoice.Text + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Quotation")
            connection.Close()
            GrdQuotation.DataSource = ds
            GrdQuotation.DataMember = "BizPro_Quotation"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdQuotation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill



            'Show Students Total Amount payable
            AMOUNTPAYABLE()





        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview")

        End Try
    End Sub


    Private Sub GrdStudentPaymentInvoice_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)



    End Sub
    'Sub For Student info show in label
    Sub DataReaderForCustomerLabel()


        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        con.ConnectionString = FrmHome.ConnectionString
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT  *FROM [Quotation Invoice] join [Customer Information] on [Quotation Invoice].[Customer ID]=[Customer Information].[Customer ID] WHERE [Quotation Invoice].[Quotation Invoice No] = '" + Me.TxtSearchQuotationInvoice.Text + "'"


        dr = cmd.ExecuteReader()
        dr.Read()

        If dr.HasRows Then


            Me.LblCustomerID.Text = dr.Item("Customer ID").ToString
            Me.LblCustomerName.Text = dr.Item("Customer Name").ToString
            Me.LblMobileNo.Text = dr.Item("Mobile No").ToString

        ElseIf Not dr.HasRows Then

            MsgBox("No Customer Found")

            ClearData()

        End If

        dr.Close()
        con.Close()


    End Sub
    'Clear Data

    Sub ClearData()


        LblCustomerName.Text = ""
        LblCustomerID.Text = ""
        LblMobileNo.Text = ""

        TxtSearchQuotationInvoice.Text = ""
    End Sub
    Sub AMOUNTPAYABLE()
        Dim total As String = 0
        For i As Integer = 0 To GrdQuotation.RowCount - 1
            total += GrdQuotation.Rows(i).Cells(4).Value
        Next
        Me.LblAmount.Text = total
    End Sub

    Private Sub FrmStudentPaymentHistory_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub


    Private Sub FrmStudentPaymentHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 0)
        Me.Size = My.Computer.Screen.WorkingArea.Size

        'Change Language
        ChangeLanguage()



        'Search Student Incomplete BY loginID
        SearchQuotationDataByInvoiceAndUserID()


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

                Me.TxtSearchQuotationInvoice.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.LblCustomerID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.LblCustomerName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.LblMobileNo.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.LblAmount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))


                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

                Me.GrdQuotationInvoice.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdQuotationInvoice.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)

                Me.GrdQuotation.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdQuotation.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)
                'MsgBox(dr.Item("Language Font"))

            End If
            dr.Close
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    'Search All Incomplete Quotation
    Sub SearchAllQuotationData()

        Try
            
            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Quotation Invoice].[Quotation Invoice No],[Customer Information].[Customer Name],[Quotation Invoice].[Quotation Date],[Quotation Invoice].[Quotation Time],[Quotation Invoice].[Total Amount] from [Quotation Invoice] join [User Account] on [Quotation Invoice].[User Account ID]=[User Account].[User Account ID]join [Customer Information] on [Quotation Invoice].[Customer ID]=[Customer Information].[Customer ID]   where  [Quotation Invoice].[Status]='INCOMPLETE'   order by [Quotation Invoice].[Quotation Date] desc, [Quotation Invoice].[Quotation Time] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Quotation Invoice")
            connection.Close()
            GrdQuotationInvoice.DataSource = ds
            GrdQuotationInvoice.DataMember = "BizPro_Quotation Invoice"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdQuotationInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill






        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try




    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        'Clear data
        ClearData()

        'Current date all complete history show
        SearchCompleteQuotationDataByInvoiceAndUserID()

        'Refresh Data Quotation
        RefreshQuotationDetails()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        'Clear data
        ClearData()

        'Search All Complete Quotation Data
        SearchAllCompleteQuotationData()

        'Refresh Data Quotation
        RefreshQuotationDetails()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        'Clear data
        ClearData()


        'Search  Incomplete Quotation BY loginID
        SearchQuotationDataByInvoiceAndUserID()

        'Refresh Data Quotation
        RefreshQuotationDetails()


    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        'Clear data
        ClearData()


        'Search All Incomplete Quotation
        SearchAllQuotationData()


        'Refresh Data Quotation
        RefreshQuotationDetails()
    End Sub

    Private Sub PnlQuotationHistory_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PnlQuotationHistory.Paint

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

    Private Sub GrdQuotationInvoice_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdQuotationInvoice.CellContentClick

    End Sub

    Private Sub GrdQuotationInvoice_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdQuotationInvoice.CellMouseClick
        'Data Grid view code
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdQuotationInvoice.Rows(e.RowIndex)

                TxtSearchQuotationInvoice.Text = row.Cells("Quotation Invoice No").Value.ToString



                'Show Students Details in label
                DataReaderForCustomerLabel()

                'RefreshQuotation Details
                RefreshQuotationDetails()




            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview")

        End Try
    End Sub

    Private Sub GrdQuotationInvoice_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdQuotationInvoice.CellMouseDoubleClick
        Try

            If e.RowIndex >= 0 Then

                Dim row As DataGridViewRow
                row = Me.GrdQuotationInvoice.Rows(e.RowIndex)




                If Me.TxtSearchQuotationInvoice.Text = "" Then
                    MsgBox("Please select a row from list")
                Else


                    'Show form Student Payment 
                    FrmQuotation.Show()

                    'Quotation Invoice
                    FrmQuotation.TxtQuotationInvoiceNo.Text = Me.TxtSearchQuotationInvoice.Text

                    'Quotation Form All Data input

                    FrmQuotation.CmbCustomerName.Focus()
                    FrmQuotation.CmbCustomerName.Text = LblCustomerName.Text
                    FrmQuotation.CmbCustomerName.SelectedValue = LblCustomerID.Text
                    FrmQuotation.DtpQuotationDate.Value = row.Cells("Quotation Date").Value


                    'Refresh data
                    FrmQuotation.RefreshData()

                    'Focus on Product Name field
                    FrmQuotation.cmbProductName.Focus()

                    'Search Purchase Invoice
                    FrmQuotation.SearchQuotationInvoice()

                    'show Cusotmer Information
                    FrmQuotation.customerInformation()


                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try
    End Sub

    Private Sub GrdQuotation_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

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