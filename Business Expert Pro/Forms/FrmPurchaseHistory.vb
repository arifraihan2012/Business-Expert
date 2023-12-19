Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmPurchaseHistory
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point

    Private Sub TxtSearchStudentID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearchPurchaseInvoice.KeyDown
        If e.KeyCode = Keys.Enter Then

            'Search Purchase Invoice
            SearchPurchaseInvoice()

            'Show Supplier Details
            DataReaderForSupplierLabel()

            'refresh purchase details
            RefreshPurchaseDetails()

        End If

    End Sub


    'Show Incomplete Purchase Data By Status And UserID

    Sub ShowIncompletePurchaseDataByStatusAndUserID()

        Try
            

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Purchase Invoice].[Purchase Invoice No],[Supplier Information].[Supplier Name],[Purchase Invoice].[Purchase Date],[Purchase Invoice].[Purchase Time],[Purchase Invoice].[Total] from [Purchase Invoice]  join [User Account] on [Purchase Invoice].[User Account ID]=[User Account].[User Account ID]join [Supplier Information] on [Purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID]   where [User Account].[User Account ID]='" + FrmHome.LblUserID.Text + "' and [Purchase Invoice].[Status]='INCOMPLETE' order by [Purchase Invoice].[Purchase Date]  desc, [Purchase Invoice].[Purchase Time] desc"
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






        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try



    End Sub
    'Show Todays  Complete Purchase By loginID 

    Sub ShowCompletePurchaseDataByUserIDToday()

        Try
             
            Dim currentDate As DateTime = DateTime.Today

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Purchase Invoice].[Purchase Invoice No],[Supplier Information].[Supplier Name],[Purchase Invoice].[Purchase Date],[Purchase Invoice].[Purchase Time],[Purchase Invoice].[Total] from [Purchase Invoice]  join [User Account] on [Purchase Invoice].[User Account ID]=[User Account].[User Account ID]join [Supplier Information] on [Purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID]   where [User Account].[User Account ID]='" + FrmHome.LblUserID.Text + "' and [Purchase Invoice].[Status]='COMPLETE' and [Purchase Invoice].[Purchase Date]= '" + currentDate + "' order by [Purchase Invoice].[Purchase Date]  desc, [Purchase Invoice].[Purchase Time] desc "
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






        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show Complete Purchase Data By User ID Today sub")
        Finally

        End Try



    End Sub
    'Show  All Complete Invoice 

    Sub ShowAllCompletePurchaseData()
        Try
            
            Dim currentDate As DateTime = DateTime.Today

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Purchase Invoice].[Purchase Invoice No],[Supplier Information].[Supplier Name],[Purchase Invoice].[Purchase Date],[Purchase Invoice].[Purchase Time],[Purchase Invoice].[Total] from [Purchase Invoice]  join [User Account] on [Purchase Invoice].[User Account ID]=[User Account].[User Account ID]join [Supplier Information] on [Purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID]   where [Purchase Invoice].[Status]='COMPLETE'  ORDER BY [Purchase Invoice].[Purchase Date] desc, [Purchase Invoice].[Purchase Time] desc"
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






        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show All Complete Purchase Data Sub")
        Finally

        End Try



    End Sub
    ' Search Purchase Invoice

    Sub SearchPurchaseInvoice()

        Try
             

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Purchase Invoice].[Purchase Invoice No],[Supplier Information].[Supplier Name],[Purchase Invoice].[Purchase Date],[Purchase Invoice].[Purchase Time],[Purchase Invoice].[Total] from [Purchase Invoice]  join [User Account] on [Purchase Invoice].[User Account ID]=[User Account].[User Account ID]join [Supplier Information] on [Purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID] where [Purchase Invoice].[Purchase Invoice No] = '" + TxtSearchPurchaseInvoice.Text + "' And not left ([Purchase Invoice].[Status],'7' ) ='opening'"
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






        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Search Purchase Invoice Sub")
        Finally

        End Try



    End Sub

    Private Sub TxtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearchPurchaseInvoice.TextChanged

    End Sub


    Private Sub GrdStudentPaymentInvoice_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdPurchaseInvoice_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)

    End Sub

    Private Sub GrdStudentPaymentInvoice_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

    End Sub

    'Privet sub for refresh purchase details
    Sub RefreshPurchaseDetails()

        Try

            


            Dim connectionString As String = FrmHome.ConnectionString

            Dim sql As String = "SELECT [Purchase].[Purchase ID],[Purchase].[Purchase Invoice NO],[Products].[Product ID],[Products].[Product Name],[Purchase].[Purchase Quantity],[Purchase].[Purchase Unit Cost],[Purchase].[Amount] from [Purchase] join [Products] on [Purchase].[product ID]=[products].[Product ID] where [Purchase].[Purchase Invoice No]= '" + TxtSearchPurchaseInvoice.Text + "'"


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Purchase")
            connection.Close()
            GrdPurchase.DataSource = ds
            GrdPurchase.DataMember = "BizPro_Purchase"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdPurchase.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill



            'Show Students Total Amount payable
            AMOUNTPAYABLE()

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Refresh Purchase Details Sub")

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
            cmd.CommandText = "SELECT  *FROM [Purchase Invoice] join [Supplier Information] on [Purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID] WHERE [Purchase Invoice].[Purchase Invoice No] = '" + Me.TxtSearchPurchaseInvoice.Text + "'"


            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then


                Me.LblSupplierID.Text = dr.Item("Supplier ID").ToString
                Me.LblSupplierName.Text = dr.Item("Supplier Name").ToString
                Me.LblMobileNo.Text = dr.Item("Mobile No").ToString

            ElseIf Not dr.HasRows Then

                MsgBox("No Customer Found")

                ClearData()

            End If

            dr.Close()
            con.Close()


        Catch ex As Exception
            MessageBox.Show("Error while Searching Supplier ..." & ex.Message, "Data Reader For Supplier Label Sub")

        End Try
    End Sub
    'Clear Data

    Sub ClearData()


        LblSupplierName.Text = ""
        LblSupplierID.Text = ""
        LblMobileNo.Text = ""

        TxtSearchPurchaseInvoice.Text = ""
    End Sub
    Sub AMOUNTPAYABLE()
        Dim total As String = 0
        For i As Integer = 0 To GrdPurchase.RowCount - 1
            total += GrdPurchase.Rows(i).Cells(5).Value
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


        'Show Incomplete Purchase Data By Status And UserID
        ShowIncompletePurchaseDataByStatusAndUserID()

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


                Me.TxtSearchPurchaseInvoice.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.LblSupplierID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.LblSupplierName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.LblMobileNo.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.LblAmount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))


                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

                Me.GrdPurchaseInvoice.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdPurchaseInvoice.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)

                Me.GrdPurchase.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdPurchase.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)
                'MsgBox(dr.Item("Language Font"))
            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Change Language Sub")
        Finally

        End Try

        'End Language

    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub GrdPurchaseInvoice_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)

    End Sub

    Private Sub GrdStudentPaymentInvoice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    'Delete Supplier Ledger
    Sub DeleteSupplierLedger()


        Try


            Dim con As New SqlConnection
            Dim con1 As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now


            Dim cmd2 As New SqlCommand
            Dim dr As SqlDataReader



            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd2.Connection = con
            cmd2.CommandText = "SELECT  *FROM [Supplier Ledger]  WHERE [Purchase Invoice No] = '" + TxtSearchPurchaseInvoice.Text + "'"
            dr = cmd2.ExecuteReader()
            dr.Read()


            If dr.HasRows Then



                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd.Connection = con1
                cmd1.Connection = con1
                cmd.CommandText = "Delete from [Supplier Ledger] where [Purchase Invoice No]= '" + TxtSearchPurchaseInvoice.Text + "'"
                cmd1.CommandText = "INSERT INTO [Log Details] ([Log Category],[Log Description],[User Account ID],[Log Date],[Log Time],[Task ID]) VALUES ('Bank Transaction','Data Deleted Successfully','" + FrmHome.LblUserID.Text + "','" + currentDate + "','" + currentTime + "','" + LblSupplierName.Text + "')"
                cmd.ExecuteNonQuery()
                cmd1.ExecuteNonQuery()
                con1.Close()

            End If


            dr.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Supplier Ledger Sub")
        Finally

        End Try


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    'Show All Incomplete data
    Sub ShowAllIncompletePurchaseData()

        Try
             

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Purchase Invoice].[Purchase Invoice No],[Supplier Information].[Supplier Name],[Purchase Invoice].[Purchase Date],[Purchase Invoice].[Purchase Time],[Purchase Invoice].[Total] from [Purchase Invoice]  join [User Account] on [Purchase Invoice].[User Account ID]=[User Account].[User Account ID]join [Supplier Information] on [Purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID]   where [Purchase Invoice].[Status]='INCOMPLETE' order by [Purchase Invoice].[Purchase Date]  desc, [Purchase Invoice].[Purchase Time] desc"
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






        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show All Incomplete Purchase Data Sub")
        Finally

        End Try


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub


    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'Clear data
        ClearData()

        'Show Todays  Complete Purchase By loginID 
        ShowCompletePurchaseDataByUserIDToday()


        'refresh purchase details
        RefreshPurchaseDetails()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'Clear data
        ClearData()

        'Show  All Complete Invoice 
        ShowAllCompletePurchaseData()


        'refresh purchase details
        RefreshPurchaseDetails()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click


        'Clear data
        ClearData()

        'Show Incomplete Purchase Data By Status And UserID
        ShowIncompletePurchaseDataByStatusAndUserID()


        'refresh purchase details
        RefreshPurchaseDetails()


    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click



        'Clear data
        ClearData()

        'Show Incomplete Purchase Data By Status And UserID
        ShowAllIncompletePurchaseData()



        'refresh purchase details
        RefreshPurchaseDetails()


    End Sub

    Private Sub GrdPurchase_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdPurchase_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)


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

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdPurchaseInvoice.CellContentClick

    End Sub

    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles GrdPurchaseInvoice.CellFormatting

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

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdPurchaseInvoice.CellMouseClick
        'Data Grid view code
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdPurchaseInvoice.Rows(e.RowIndex)

                TxtSearchPurchaseInvoice.Text = row.Cells("Purchase Invoice No").Value.ToString



                'Show Students Details in label
                DataReaderForSupplierLabel()


                'refresh purchase details
                RefreshPurchaseDetails()



            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview")

        End Try
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdPurchaseInvoice.CellMouseDoubleClick
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdPurchaseInvoice.Rows(e.RowIndex)





                If Me.TxtSearchPurchaseInvoice.Text = "" Then
                    MsgBox("Please select a row from list")
                Else


                    'Show form Student Payment 
                    FrmPurchase.Show()

                    'Purchase Invoice
                    FrmPurchase.TxtPurchaseInvoiceNo.Text = Me.TxtSearchPurchaseInvoice.Text

                    'Sale Form All Data input


                    FrmPurchase.CmbSupplierName.Text = LblSupplierName.Text
                    FrmPurchase.CmbSupplierName.ValueMember = LblSupplierID.Text
                    FrmPurchase.DtpPurchaseDate.Value = row.Cells("Purchase Date").Value
                    FrmPurchase.SearchCustomerChartOfAccountIDForUpdateLedger()
                    'Refresh data
                    FrmPurchase.RefreshData()

                    'Focus on Product Name field
                    FrmPurchase.CmbProductName.Focus()



                    'Supplier informatio show
                    FrmPurchase.SupplierInformation()


                    'Search Purchase Invoice
                    FrmPurchase.SearchPurchaseInvoice()

                    'Clear Purchase Serial Number
                    FrmPurchase.GrdAvailableSerialNumber.Columns.Clear()


                    'Set Previous Paidby id to variable to update ledger
                    FrmPurchase.PreviousPaidbyID = FrmPurchase.CmbPaidBy.SelectedValue.ToString

                    'Purchase edit confirmation
                    FrmPurchase.PurchaseEditStatus = True
                    'Hide supplier list
                    FrmPurchase.GrdSupplierList.Hide()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Cell Mouse Double Click Gridview")

        Finally

        End Try

    End Sub

    Private Sub GrdPurchase_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdPurchase.CellContentClick

    End Sub

    Private Sub GrdPurchase_CellFormatting1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles GrdPurchase.CellFormatting

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

                If GrdPurchase.Columns(e.ColumnIndex).Name.Equals("Purchase Unit Cost") Then

                    If (Not e.Value Is Nothing) Then
                        e.Value = New String(CChar("*"), e.Value.ToString.Length)

                    End If

                ElseIf GrdPurchase.Columns(e.ColumnIndex).Name.Equals("Amount") Then
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

    Private Sub GrdPurchase_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdPurchase.CellMouseClick


        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader



        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.GrdPurchase.Rows(e.RowIndex)

            Dim ProductID As String = row.Cells("Product ID").Value.ToString

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Products]  WHERE [Product ID] = " + ProductID + " AND [Product Image] IS NOT NULL"
            dr = cmd.ExecuteReader()
            dr.Read()

            Try


                If dr.HasRows Then


                    Dim data As Byte() = DirectCast(dr("Product Image"), Byte())
                    Dim ms As New MemoryStream(data)
                    ProductPictureBox.Image = Image.FromStream(ms)
                End If

            Catch ex As Exception

            End Try
            dr.Close()
            con.Close()

        End If

    End Sub
End Class