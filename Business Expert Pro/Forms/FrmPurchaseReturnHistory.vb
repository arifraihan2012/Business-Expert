Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmPurchaseReturnHistory
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point

    Private Sub TxtSearchStudentID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearchPurchaseReturnInvoice.KeyDown
        If e.KeyCode = Keys.Enter Then

            'Search Purchase Return Invoice
            SearchPurchaseReturnInvoice()

            'Show Customer Details
            DataReaderForSupplierLabel()

            'Refresh Data Purchase Return
            RefreshPurchaseReturnDetails()

        End If

    End Sub

    ' Show Incomplete Purchase Data By Status And UserID
    Sub ShowIncompletePurchaseReturnDataByStatusAndUserID()


        Try
             
            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Purchase Return Invoice].[Purchase Return Invoice No],[Supplier Information].[Supplier Name],[Purchase Return Invoice].[Return Date],[Purchase Return Invoice].[Prepared Time],[Purchase Return Invoice].[Total] from [Purchase Return Invoice] join  [User Account] on [Purchase Return Invoice].[User Account ID]=[User Account].[User Account ID]join [Supplier Information] on [Purchase Return Invoice].[Supplier ID]=[Supplier Information].[Supplier ID]   where [User Account].[User Account ID]='" + FrmHome.LblUserID.Text + "' and [Purchase Return Invoice].[Status]='INCOMPLETE' order by [Purchase Return Invoice].[Return Date] desc, [Purchase Return Invoice].[Prepared Time] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Purchase Return Invoice")
            connection.Close()
            GrdPurchaseReturnInvoice.DataSource = ds
            GrdPurchaseReturnInvoice.DataMember = "BizPro_Purchase Return Invoice"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdPurchaseReturnInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill






        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show Incomplete Purchase Return Data By Invoice And UserID Sub")
        Finally

        End Try



    End Sub
    'Show Todays  Complete Purchase Return By loginID 

    Sub ShowCompletePurchaseReturnDataByUserIDToday()

        Try
           
            Dim currentDate As DateTime = DateTime.Today

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Purchase Return Invoice].[Purchase Return Invoice No],[Supplier Information].[Supplier Name],[Purchase Return Invoice].[Return Date],[Purchase Return Invoice].[Prepared Time],[Purchase Return Invoice].[Total] from [Purchase Return Invoice] join  [User Account] on [Purchase Return Invoice].[User Account ID]=[User Account].[User Account ID]join [Supplier Information] on [Purchase Return Invoice].[Supplier ID]=[Supplier Information].[Supplier ID]   where [User Account].[User Account ID]='" + FrmHome.LblUserID.Text + "' and [Purchase Return Invoice].[Status]='COMPLETE' and [Purchase Return Invoice].[Return Date]= '" + currentDate + "' order by [Purchase Return Invoice].[Return Date] desc, [Purchase Return Invoice].[Prepared Time] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Purchase Return Invoice")
            connection.Close()
            GrdPurchaseReturnInvoice.DataSource = ds
            GrdPurchaseReturnInvoice.DataMember = "BizPro_Purchase Return Invoice"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdPurchaseReturnInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill






        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show Complete Purchase Return Data By UserID Today Sub")
        Finally

        End Try



    End Sub
    'Show  All Complete Purchase Return Invoice 

    Sub ShowAllCompletePurchaseReturnData()

        Try
            
            Dim currentDate As DateTime = DateTime.Today

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Purchase Return Invoice].[Purchase Return Invoice No],[Supplier Information].[Supplier Name],[Purchase Return Invoice].[Return Date],[Purchase Return Invoice].[Prepared Time],[Purchase Return Invoice].[Total] from [Purchase Return Invoice] join  [User Account] on [Purchase Return Invoice].[User Account ID]=[User Account].[User Account ID]join [Supplier Information] on [Purchase Return Invoice].[Supplier ID]=[Supplier Information].[Supplier ID]   where [User Account].[User Account ID]='" + FrmHome.LblUserID.Text + "' and [Purchase Return Invoice].[Status]='COMPLETE'  order by [Purchase Return Invoice].[Return Date] desc, [Purchase Return Invoice].[Prepared Time] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Purchase Return Invoice")
            connection.Close()
            GrdPurchaseReturnInvoice.DataSource = ds
            GrdPurchaseReturnInvoice.DataMember = "BizPro_Purchase Return Invoice"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdPurchaseReturnInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
           




        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show All Complete Purchase Return Data Sub")
        Finally

        End Try



    End Sub
    ' Search Purchase Return Invoice

    Sub SearchPurchaseReturnInvoice()
        Try
             

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Purchase Return Invoice].[Purchase Return Invoice No],[Supplier Information].[Supplier Name],[Purchase Return Invoice].[Return Date],[Purchase Return Invoice].[Prepared Time],[Purchase Return Invoice].[Total] from [Purchase Return Invoice] join  [User Account] on [Purchase Return Invoice].[User Account ID]=[User Account].[User Account ID]join [Supplier Information] on [Purchase Return Invoice].[Supplier ID]=[Supplier Information].[Supplier ID]   where [Purchase Return Invoice].[Purchase Return Invoice No] = '" + TxtSearchPurchaseReturnInvoice.Text + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Purchase Return Invoice")
            connection.Close()
            GrdPurchaseReturnInvoice.DataSource = ds
            GrdPurchaseReturnInvoice.DataMember = "BizPro_Purchase Return Invoice"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdPurchaseReturnInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
             




        Catch ex As Exception
            MessageBox.Show("Error while Searching record on table..." & ex.Message, "Search Purchase Return Invoice Sub")
        Finally

        End Try



    End Sub

    Private Sub TxtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearchPurchaseReturnInvoice.TextChanged

    End Sub


    Private Sub GrdStudentPaymentInvoice_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdPurchaseReturnInvoice_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)

    End Sub

    Private Sub GrdStudentPaymentInvoice_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

    End Sub


    'Privet sub for refresh Purchase Return details
    Sub RefreshPurchaseReturnDetails()


        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader


            'Data reader for Product Id
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT * from [Purchase Return Invoice] WHERE [Purchase Return Invoice No] =  '" + TxtSearchPurchaseReturnInvoice.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()



            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Purchase Return].[Purchase Return ID],[Products].[Product Name],[Purchase Return].[Returned Quantity],([Purchase Return].[Returned Quantity]* (select [Purchase Unit Cost] from  Purchase where [Purchase Invoice No]='" + dr.Item("Purchase Invoice No").ToString + "' and [Product ID]=products.[Product ID]))[Total Amount] from [Purchase Return] join Purchase on [Purchase Return].[purchase ID]=Purchase.[Purchase ID]  join Products on Purchase.[Product ID]=Products.[Product ID] join [Purchase Return Invoice] on [Purchase Return].[Purchase Return Invoice No]=[Purchase Return Invoice].[Purchase Return Invoice No] Where [Purchase Return].[Purchase Return Invoice No]='" + TxtSearchPurchaseReturnInvoice.Text + "' And [Purchase Return Invoice].[Purchase Invoice No]='" + dr.Item("Purchase Invoice No").ToString + "' Order by [Purchase Return].[Purchase Return ID] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Purchase Return")
            connection.Close()
            GrdPurchaseReturn.DataSource = ds
            GrdPurchaseReturn.DataMember = "BizPro_Purchase Return"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdPurchaseReturn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            dr.Close()
            con.Close()

            'Show Students Total Amount payable
            AMOUNTPAYABLE()




        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Refresh Purchase Return Details Sub")

        End Try
    End Sub


    Private Sub GrdStudentPaymentInvoice_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)



    End Sub

    'Sub For Supplier info show in label
    Sub DataReaderForSupplierLabel()

        Try



            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT * from [Supplier Information] join [Purchase Invoice] on [Supplier Information].[Supplier ID]=[Purchase Invoice].[Supplier ID] join [Customer Information] on [Supplier Information].[Supplier ID]= [Customer Information].[Supplier ID] join [Purchase Return Invoice] on [Purchase Invoice].[Purchase Invoice No]=[Purchase Return Invoice].[Purchase Invoice No]  WHERE [Purchase Return Invoice].[Purchase Return Invoice No] = '" + Me.TxtSearchPurchaseReturnInvoice.Text + "'"


            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then


                Me.LblSupplierID.Text = dr.Item("Supplier ID").ToString
                Me.LblSupplierName.Text = dr.Item("Supplier Name").ToString
                Me.LblMobileNo.Text = dr.Item("Mobile No").ToString

            ElseIf Not dr.HasRows Then

                MsgBox("No Supplier Found")

                ClearData()

            End If

            dr.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while Searching Customer ..." & ex.Message, "Data Reader For Supplier Label Sub")

        End Try

    End Sub
    'Clear Data

    Sub ClearData()


        LblSupplierName.Text = ""
        LblSupplierID.Text = ""
        LblMobileNo.Text = ""

        TxtSearchPurchaseReturnInvoice.Text = ""
    End Sub
    Sub AMOUNTPAYABLE()
        Try


            Dim total As String = 0
            For i As Integer = 0 To GrdPurchaseReturn.RowCount - 1
                total += GrdPurchaseReturn.Rows(i).Cells(3).Value
            Next
            Me.LblAmount.Text = total

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmStudentPaymentHistory_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub


    Private Sub FrmStudentPaymentHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 0)
        Me.Size = My.Computer.Screen.WorkingArea.Size









        'Change Language
        ChangeLanguage()



        'Show Incomplete Purchase Data By Status And User ID
        ShowIncompletePurchaseReturnDataByStatusAndUserID()


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


                Me.TxtSearchPurchaseReturnInvoice.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.LblSupplierID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.LblSupplierName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.LblMobileNo.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.LblAmount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))


                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

                Me.GrdPurchaseReturnInvoice.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdPurchaseReturnInvoice.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)

                Me.GrdPurchaseReturn.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdPurchaseReturn.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)
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


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub


    'Show All Incomplete Purchase Return
    Sub ShowAllIncompletePurchaseReturn()

        Try
             
            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Purchase Return Invoice].[Purchase Return Invoice No],[Supplier Information].[Supplier Name],[Purchase Return Invoice].[Return Date],[Purchase Return Invoice].[Prepared Time],[Purchase Return Invoice].[Total] from [Purchase Return Invoice] join  [User Account] on [Purchase Return Invoice].[User Account ID]=[User Account].[User Account ID]join [Supplier Information] on [Purchase Return Invoice].[Supplier ID]=[Supplier Information].[Supplier ID]   where [Purchase Return Invoice].[Status]='INCOMPLETE'  order by [Purchase Return Invoice].[Return Date] desc, [Purchase Return Invoice].[Prepared Time] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Purchase Return Invoice")
            connection.Close()
            GrdPurchaseReturnInvoice.DataSource = ds
            GrdPurchaseReturnInvoice.DataMember = "BizPro_Purchase Return Invoice"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdPurchaseReturnInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            




        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show All Incomplete Purchase  Return Sub")
        Finally

        End Try



    End Sub



    Private Sub TxtUpdate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        'Clear data
        ClearData()


        'Show Todays  Complete Purchase Return By loginID
        ShowCompletePurchaseReturnDataByUserIDToday()

        'Clear sale return columns
        GrdPurchaseReturn.Columns.Clear()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        'Clear data
        ClearData()

        'Show  All Complete  Purchase Return Invoice 
        ShowAllCompletePurchaseReturnData()

        'Clear sale return columns
        GrdPurchaseReturn.Columns.Clear()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        'Clear data
        ClearData()

        'Show Incomplete Purchase Return Data By Status And User ID
        ShowIncompletePurchaseReturnDataByStatusAndUserID()

        'Clear sale return columns
        GrdPurchaseReturn.Columns.Clear()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        'Clear data
        ClearData()

        'Show All Incomplete Sale Return
        ShowAllIncompletePurchaseReturn()

        'Clear sale return columns
        GrdPurchaseReturn.Columns.Clear()
    End Sub

    Private Sub GrdPurchaseReturn_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdPurchaseReturn_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)

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

    Private Sub GrdPurchaseReturnInvoice_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdPurchaseReturnInvoice.CellContentClick

    End Sub

    Private Sub GrdPurchaseReturnInvoice_CellFormatting1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles GrdPurchaseReturnInvoice.CellFormatting
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

                If GrdPurchaseReturnInvoice.Columns(e.ColumnIndex).Name.Equals("Total") Then
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

    Private Sub GrdPurchaseReturnInvoice_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdPurchaseReturnInvoice.CellMouseClick
        'Data Grid view code
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdPurchaseReturnInvoice.Rows(e.RowIndex)

                TxtSearchPurchaseReturnInvoice.Text = row.Cells("Purchase Return Invoice No").Value.ToString



                'Show Supplier Details in label
                DataReaderForSupplierLabel()

                'Refresh Purchase  ReturnDetails
                RefreshPurchaseReturnDetails()



            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview")

        End Try
    End Sub

    Private Sub GrdPurchaseReturnInvoice_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdPurchaseReturnInvoice.CellMouseDoubleClick
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdPurchaseReturnInvoice.Rows(e.RowIndex)


                If Me.TxtSearchPurchaseReturnInvoice.Text = "" Then
                    MsgBox("Please select a row from list")

                Else


                    'Show form Purchase Return 
                    FrmPurchaseReturn.Show()

                    'Select Search By
                    FrmPurchaseReturn.CmbSearch.SelectedIndex = 1

                    'Purchase Invoice
                    FrmPurchaseReturn.TxtPurchaseReturnInvoiceNo.Text = Me.TxtSearchPurchaseReturnInvoice.Text


                    'Search Purchase Return Invoice
                    FrmPurchaseReturn.SearchPurchaseReturnInvoice()

                    'Refresh data
                    FrmPurchaseReturn.RefreshPurchaseReturn()

                    'Show Supplier information
                    FrmPurchaseReturn.SupplierInformation()

                    'Search Sale Invoice
                    FrmPurchaseReturn.SearchInvoiceNumberAndProductDetails()

                    'Purchase Form All Data input
                    FrmPurchaseReturn.TxtPaidAmount.Focus()
                    FrmPurchaseReturn.DtpReturnedDate.Value = row.Cells("Return Date").Value




                   
                    'send Paid by id to variable to update
                    FrmPurchaseReturn.PreviousPaidbyID = FrmPurchaseReturn.cmbPaidBy.SelectedValue

                    'Purchase Return edit confirmation
                    FrmPurchaseReturn.PurchaseReturnEditStatus = True

                    'Focus on Product Name field
                    FrmPurchaseReturn.TxtSearch.Focus()


                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Cell Mouse Double Click Gridview")
        Finally

        End Try
    End Sub

    Private Sub GrdPurchaseReturn_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdPurchaseReturn.CellContentClick

    End Sub

    Private Sub GrdPurchaseReturn_CellFormatting1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles GrdPurchaseReturn.CellFormatting
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