Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmWarrantySerial
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point

    Private Sub LblStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click

        'Making Clear All Data
        ClearAllData()

        'Refresh Data By Invoice No
        RefreshDataByInvoiceNo()

    End Sub
    'Making Clear All Data
    Sub ClearAllData()

        TxtSerialID.Text = ""
        TxtSerialNumber.Text = ""
        TxtName.Text = ""
        TxtPhoneNo.Text = ""
        TxtAddress.Text = ""
        TxtProblemDetails.Text = ""
        TxtReceiveItem.Text = ""
        TxtSolutionDetails.Text = ""
        CmbStatus.Text = ""
        DtpDate.Value = Now
        DtpDeliveryDate.Value = Now
        TxtWarrantyInvoice.Text = ""
        TxtName.Text = "None"
        TxtPhoneNo.Text = "None"
        TxtAddress.Text = "None"



    End Sub
    'Making Clear Data For Add Again
    Sub ClearAllDataForAddAgain()

        TxtSerialID.Text = ""
        TxtSerialNumber.Text = ""

        TxtProblemDetails.Text = ""
        TxtReceiveItem.Text = ""
        TxtSolutionDetails.Text = ""

        DtpDate.Value = Now
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click

        'Data Update Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand

        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now

        Dim con3 As New SqlConnection
        Dim cmd3 As New SqlCommand
        Dim dr As SqlDataReader






        Try
            'Empty Bank ID Can Not Be Update
            If Me.TxtSerialID.Text = "" Then
                MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Warranty Serial")

            ElseIf TxtSerialNumber.Text = "" Or TxtPhoneNo.Text = "" Or TxtProblemDetails.Text = "" Or TxtWarrantyInvoice.Text = "" Then

                MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Warranty Serial")

            Else


                'Dr for find Product ID

                con3.ConnectionString = FrmHome.ConnectionString
                con3.Open()
                cmd3.Connection = con3
                cmd3.CommandText = "select *from [Sale Serial Number] join [Sale Invoice] on [Sale Serial Number].[Sale Invoice No]=[Sale Invoice].[Sale Invoice No] join [Customer Information] on [Sale Invoice].[Customer ID]=[Customer Information].[Customer ID] join Purchase on [Sale Serial Number].[Purchase ID]=Purchase.[Purchase ID] join Products on [Sale Serial Number].[Product ID]=[Products].[Product ID] where [Sale Serial Number].[Sale Serial Number]= '" + TxtSerialNumber.Text + "'"


                dr = cmd3.ExecuteReader()
                dr.Read()

                Dim ProductID As String
                ProductID = dr.Item("Product ID").ToString

                dr.Close()
                con3.Close()



                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd2.Connection = con
                cmd2.CommandText = "Update [Warranty Serial] Set [Product ID]= '" + ProductID + "',[Serial Number]= '" + TxtSerialNumber.Text + "',[warranty Invoice No]= '" + TxtWarrantyInvoice.Text + "',[Problem Details]= '" + TxtProblemDetails.Text + "',[Solution Details]= '" + TxtSolutionDetails.Text + "',[Status]= '" + CmbStatus.Text + "',[Receive Item]= '" + TxtReceiveItem.Text + "' WHERE [Warranty Serial ID]= '" + TxtSerialID.Text + "'"
                cmd2.Connection = con
                cmd2.ExecuteNonQuery()

                cmd1.Connection = con
                cmd1.CommandText = "INSERT INTO [Log Details] ([Log Category],[Log Description],[User Account ID],[Log Date],[Log Time],[Task ID]) VALUES ('Warranty Serial','Data Updated Successfully','" + FrmHome.LblUserID.Text + "','" + currentDate + "','" + currentTime + "','" + TxtSerialID.Text + "')"
                cmd1.ExecuteNonQuery()
                con.Close()

                'Refresh Data By Invoice No
                RefreshDataByInvoiceNo()

                'Clear All Data For Add Again
                ClearAllDataForAddAgain()

                'Update data messagebox 
                MsgBox("Data Updated Successfully", MsgBoxStyle.OkOnly, "Warranty Serial")



            End If

        Catch ex As Exception
            MessageBox.Show("Error while Updating record on table..." & ex.Message, "Update Records")
        Finally

        End Try

    End Sub

    Sub DeleteData()

        'Data Delete Code
        Dim q As MsgBoxResult
        q = MsgBox("Do you really want to Delete the row?", MsgBoxStyle.YesNo, "Warranty Serial")
        If q = MsgBoxResult.Yes Then

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Try
                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "Delete from [Warranty Serial] where [Warranty Serial ID]= '" + TxtSerialID.Text + "'"
                cmd.ExecuteNonQuery()
                con.Close()

                'Making Clear
                ClearAllDataForAddAgain()



                'Refresh Data By Invoice No
                RefreshDataByInvoiceNo()

            Catch ex As Exception
                MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Records")
            Finally

            End Try


        End If
    End Sub


    Private Sub BtnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddToWarranty.Click




        'Data Insert Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now
        Dim con3 As New SqlConnection
        Dim cmd3 As New SqlCommand
        Dim dr As SqlDataReader






        'Insert Into Warranty Invoice
        InsertIntoWarrantyInvoice()




        Try
            'Same id Twice insert restriction code
            If Not Me.TxtSerialID.Text = "" Then
                MsgBox("This ID is already Exist.", MsgBoxStyle.OkOnly, "Warranty Serial")

            Else
                'Empty Txt Box Can Not Be Save Code
                If TxtSerialNumber.Text = "" Or TxtPhoneNo.Text = "" Or TxtProblemDetails.Text = "" Or TxtWarrantyInvoice.Text = "" Then
                    MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Warranty Serial")

                Else



                    'Dr for find Product ID
                    con3.ConnectionString = FrmHome.ConnectionString
                    con3.Open()
                    cmd3.Connection = con3
                    cmd3.CommandText = "select *from [Sale Serial Number] join [Sale Invoice] on [Sale Serial Number].[Sale Invoice No]=[Sale Invoice].[Sale Invoice No] join [Customer Information] on [Sale Invoice].[Customer ID]=[Customer Information].[Customer ID] join Purchase on [Sale Serial Number].[Purchase ID]=Purchase.[Purchase ID] join Products on [Sale Serial Number].[Product ID]=[Products].[Product ID] where [Sale Serial Number].[Sale Serial Number]= '" + TxtSerialNumber.Text + "'"


                    dr = cmd3.ExecuteReader()
                    dr.Read()

                    Dim ProductID As String
                    If dr.HasRows Then


                        ProductID = dr.Item("Product ID").ToString
                    End If
                    dr.Close()
                    con3.Close()



                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd2.Connection = con
                    cmd2.CommandText = "INSERT INTO [Warranty Serial] ([Product ID],[Serial Number],[warranty Invoice No],[Problem Details],[Solution Details],[Status],[Receive Item]) VALUES ('" + ProductID + "','" + TxtSerialNumber.Text + "','" + TxtWarrantyInvoice.Text + "','" + TxtProblemDetails.Text + "','" + TxtSolutionDetails.Text + "','" + CmbStatus.Text + "','" + TxtReceiveItem.Text + "')"
                    cmd2.ExecuteNonQuery()
                    cmd1.Connection = con
                    cmd1.CommandText = "INSERT INTO [Log Details] ([Log Category],[Log Description],[User Account ID],[Log Date],[Log Time],[Task ID]) VALUES ('warranty Serial','Data Inserted Successfully [" + TxtSerialNumber.Text + "]','" + FrmHome.LblUserID.Text + "','" + currentDate + "','" + currentTime + "','New Data Inserted')"
                    cmd1.ExecuteNonQuery()

                    'Refresh Data By Invoice No
                    RefreshDataByInvoiceNo()

                    'Clear All Data For Add Again
                    ClearAllDataForAddAgain()

                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            con.Close()

        End Try

    End Sub


    Sub InsertIntoWarrantyInvoice()

        'Insert Into Sale Invoice code
        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim con2 As New SqlConnection
            Dim cmd2 As New SqlCommand
            Dim dr1 As SqlDataReader

            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now

            Dim con3 As New SqlConnection
            Dim cmd3 As New SqlCommand
            Dim dr As SqlDataReader




            'Dr for find Product ID
            con3.ConnectionString = FrmHome.ConnectionString
            con3.Open()
            cmd3.Connection = con3
            cmd3.CommandText = "select *from [Sale Serial Number] join [Sale Invoice] on [Sale Serial Number].[Sale Invoice No]=[Sale Invoice].[Sale Invoice No] join [Customer Information] on [Sale Invoice].[Customer ID]=[Customer Information].[Customer ID] join Purchase on [Sale Serial Number].[Purchase ID]=Purchase.[Purchase ID] join Products on [Sale Serial Number].[Product ID]=[Products].[Product ID] where [Sale Serial Number].[Sale Serial Number]= '" + TxtSerialNumber.Text + "'"


            dr = cmd3.ExecuteReader()
            dr.Read()

            Dim SaleInvoiceNo As String
            If dr.HasRows Then

                SaleInvoiceNo = dr.Item("Sale Invoice No").ToString
            End If
            dr.Close()
            con3.Close()


            If TxtWarrantyInvoice.Text = "" Then

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "INSERT INTO [Warranty Invoice] ([Customer Name],[Mobile Number],[Address],[Delivery Date],[Sale Invoice No],[Status],[User Account ID],[Computer ID],[Prepared Date],[Prepared Time],[Date]) values ('" + TxtName.Text + "','" + TxtPhoneNo.Text + "','" + TxtAddress.Text + "','" + DtpDeliveryDate.Value + "','" + SaleInvoiceNo + "','INCOMPLETE','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + DtpDate.Value + "')"
                cmd.ExecuteNonQuery()
                con.Close()


                con2.ConnectionString = FrmHome.ConnectionString
                con2.Open()
                cmd2.Connection = con2
                cmd2.CommandText = "SELECT top 1 [warranty Invoice No] FROM [Warranty Invoice] where [User Account ID]= '" + FrmHome.LblUserID.Text + "'  order by [Sale Invoice No] desc"

                dr1 = cmd2.ExecuteReader()
                dr1.Read()
                If dr1.HasRows Then

                    TxtWarrantyInvoice.Text = (dr1.Item("warranty Invoice No").ToString)

                End If
                con2.Close()
                dr1.Close()



            Else





                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "Update [Warranty Invoice] Set [Customer Name]= '" + TxtName.Text + "',[Mobile Number]= '" + TxtPhoneNo.Text + "',[Address]= '" + TxtAddress.Text + "',[Delivery Date]= '" + DtpDeliveryDate.Value + "',[Sale Invoice No]= '" + SaleInvoiceNo + "',[Status]= 'INCOMPLETE',[User Account ID]= '" + FrmHome.LblUserID.Text + "',[Computer ID]= '" + FrmHome.LblComputerID.Text + "',[Date]'" + DtpDate.Value + "' where [warranty Invoice No] = '" + TxtWarrantyInvoice.Text + "' "
                cmd.ExecuteNonQuery()
                con.Close()


            End If

        Catch ex As Exception
            MessageBox.Show("Error while Inserting to sale invoice record on table..." & ex.Message, "Insert Records Sale Invoice")
        Finally

        End Try



    End Sub





    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtToSerail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CmbSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        'Focus on Search Text Box
        If e.KeyCode = Keys.Enter Then
            Me.TxtWarrantyInvoice.Focus()

        End If
    End Sub

    Private Sub CmbSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtWarrantyInvoice.KeyDown


        If e.KeyCode = Keys.Enter Then

            'Search invoice no by keydown
            RefreshDataByInvoiceNo()


            'Search Warranty Invoice Details()
            SearchWarrantyInvoiceDetails()

        End If


    End Sub

    Sub SearchWarrantyInvoiceDetails()

        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader





            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "select *from [Warranty Invoice] where [warranty Invoice No]= '" + TxtWarrantyInvoice.Text + "'"


            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then




                DtpDate.Value = dr.Item("Date").ToString
                DtpDeliveryDate.Value = dr.Item("Delivery Date").ToString
                LblName.Text = dr.Item("Customer Name").ToString
                LblPhoneNo.Text = dr.Item("Mobile Number").ToString
                LblAddress.Text = dr.Item("Address").ToString

            End If


            dr.Close()
            con.Close()


        Catch ex As Exception

        End Try

    End Sub

    'Creating Privet Sub of Refreshing Data
    Sub RefreshDataByInvoiceNo()
        Try
            ' Load Data
           

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select [Warranty Serial].[Warranty Serial ID],[Products].[Product Name],[Warranty Serial].[Serial Number],[Warranty Serial].[Problem Details],[Warranty Serial].[Receive Item],[Warranty Serial].[Solution Details],[Warranty Serial].[Status] from [Warranty Serial] join [Products] on [Warranty Serial].[Product ID]=[products].[Product ID] where [warranty Invoice No]='" + TxtWarrantyInvoice.Text + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Warranty Serial")
            connection.Close()
            GrdWarrantySerial.DataSource = ds
            GrdWarrantySerial.DataMember = "BizPro_Warranty Serial"

            'GrdWarrantySerial.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdWarrantySerial.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdWarrantySerial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


            'End Refresh Data

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally

        End Try


    End Sub

    Private Sub TxtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtWarrantyInvoice.TextChanged

    End Sub

    Private Sub FrmWarrantySerial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 0)
        Me.Size = My.Computer.Screen.WorkingArea.Size

        DtpDeliveryDate.Value = Now
        DtpDate.Value = Now

    End Sub


    Private Sub GrdWarrantySerial_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdWarrantySerial_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        'Data Grid view code
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdWarrantySerial.Rows(e.RowIndex)


                TxtSerialID.Text = row.Cells("Warranty Serial ID").Value.ToString
                TxtSerialNumber.Text = row.Cells("Serial Number").Value.ToString

                TxtProblemDetails.Text = row.Cells("Problem Details").Value.ToString
                TxtReceiveItem.Text = row.Cells("Receive Item").Value.ToString
                TxtSolutionDetails.Text = row.Cells("Solution Details").Value.ToString


                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim dr As SqlDataReader





                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "select *from [Warranty Invoice] where [warranty Invoice No]= '" + TxtWarrantyInvoice.Text + "'"


                dr = cmd.ExecuteReader()
                dr.Read()
                If dr.HasRows Then


                    DtpDate.Value = dr.Item("Date").ToString
                    DtpDeliveryDate.Value = dr.Item("Delivery Date").ToString
                    TxtName.Text = dr.Item("Customer Name").ToString
                    TxtPhoneNo.Text = dr.Item("Mobile Number").ToString
                    TxtAddress.Text = dr.Item("Address").ToString



                End If

                dr.Close()
                con.Close()


            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'Insert Into Warranty Invoice()
        InsertIntoWarrantyInvoice()

        'Clear All
        ClearAllData()

        'Refresh Data By Invoice No
        RefreshDataByInvoiceNo()



    End Sub

    Private Sub BtnSearch_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LblProductNameLbl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblProductNameLbl.Click

    End Sub


    Private Sub LblProductName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblProductName.Click

    End Sub

    Private Sub TxtSerialNumber_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSerialNumber.KeyDown
        If e.KeyCode = Keys.Enter Then

            SearchCustomerInformationAndProductDetails()

            TxtName.Focus()

            CmbStatus.SelectedIndex = 1
        End If
    End Sub


    Sub SearchCustomerInformationAndProductDetails()

        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader





            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "select *from [Sale Serial Number] join [Sale Invoice] on [Sale Serial Number].[Sale Invoice No]=[Sale Invoice].[Sale Invoice No] join [Customer Information] on [Sale Invoice].[Customer ID]=[Customer Information].[Customer ID] join Purchase on [Sale Serial Number].[Purchase ID]=Purchase.[Purchase ID] join Products on [Sale Serial Number].[Product ID]=[Products].[Product ID] where [Sale Serial Number].[Sale Serial Number]= '" + TxtSerialNumber.Text + "'"


            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                LblProductName.Text = dr.Item("Product Name").ToString
                LblSaleDate.Text = dr.Item("Sale Date").ToString
                LblWarrantyDays.Text = dr.Item("Warranty Days").ToString
                LblCustomerName.Text = dr.Item("Customer Name").ToString
                LblAddress.Text = dr.Item("Address").ToString
                LblPhoneNo.Text = dr.Item("Mobile No").ToString


            End If

            dr.Close()
            con.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtSerialNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSerialNumber.TextChanged

    End Sub

    Private Sub TxtName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtName.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtPhoneNo.Focus()

        ElseIf e.KeyCode = Keys.Space AndAlso e.Control Then

            TxtName.Text = LblCustomerName.Text
        End If
    End Sub

    Private Sub TxtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtName.TextChanged

    End Sub

    Private Sub TxtPhoneNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPhoneNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtAddress.Focus()
        ElseIf e.KeyCode = Keys.Space AndAlso e.Control Then

            TxtPhoneNo.Text = LblPhoneNo.Text
        End If

    End Sub

    Private Sub TxtPhoneNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPhoneNo.KeyPress

    End Sub

    Private Sub TxtPhoneNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPhoneNo.TextChanged

    End Sub

    Private Sub TxtAddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtAddress.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtProblemDetails.Focus()
        ElseIf e.KeyCode = Keys.Space AndAlso e.Control Then

            TxtAddress.Text = LblAddress.Text
        End If
    End Sub

    Private Sub TxtAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtAddress.TextChanged

    End Sub

    Private Sub TxtProblemDetails_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtProblemDetails.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtReceiveItem.Focus()
        End If
    End Sub

    Private Sub TxtProblemDetails_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtProblemDetails.TextChanged

    End Sub

    Private Sub TxtSolutionDetails_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSolutionDetails.KeyDown
        If e.KeyCode = Keys.Enter Then
            DtpDeliveryDate.Focus()
        End If
    End Sub

    Private Sub TxtSolutionDetails_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSolutionDetails.TextChanged

    End Sub

    Private Sub DtpDeliveryDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DtpDeliveryDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbStatus.Focus()
        End If
    End Sub

    Private Sub DtpDeliveryDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtpDeliveryDate.ValueChanged

    End Sub

    Private Sub LblProblemDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtReceiveItem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtReceiveItem.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtSolutionDetails.Focus()
        End If
    End Sub

    Private Sub TxtReceiveItem_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtReceiveItem.TextChanged

    End Sub

    Private Sub GrdWarrantySerial_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        Try


            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdWarrantySerial.Rows(e.RowIndex)

                'Delete data from Warranty serial
                DeleteData()


            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnDeleteInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteInv.Click


        'Data Delete Code
        Dim q As MsgBoxResult
        q = MsgBox("Do you really want to Delete the row?", MsgBoxStyle.YesNo, "Warranty Invoice")
        If q = MsgBoxResult.Yes Then

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand

            Try
                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd1.Connection = con
                cmd.CommandText = "Delete from [Warranty Serial] where [warranty Invoice No]= '" + TxtWarrantyInvoice.Text + "'"
                cmd1.CommandText = "Delete from [Warranty Invoice] where [warranty Invoice No]= '" + TxtWarrantyInvoice.Text + "'"
                cmd.ExecuteNonQuery()
                cmd1.ExecuteNonQuery()


                'Making Clear
                ClearAllData()



                'Refresh Data By Invoice No
                RefreshDataByInvoiceNo()

            Catch ex As Exception
                MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Records")
            Finally
                con.Close()
            End Try


        End If


    End Sub

    Private Sub CmbStatus_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbStatus.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnAddToWarranty.Focus()
        End If
    End Sub

    Private Sub CmbStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbStatus.SelectedIndexChanged

    End Sub

    Private Sub LblSerialNumber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblSerialNumber.Click

    End Sub

    Private Sub GrdWarrantySerial_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdWarrantySerial.CellContentClick

    End Sub

    Private Sub GrdWarrantySerial_CellMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdWarrantySerial.CellMouseClick
        'Data Grid view code
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdWarrantySerial.Rows(e.RowIndex)


                TxtSerialID.Text = row.Cells("Warranty Serial ID").Value.ToString
                TxtSerialNumber.Text = row.Cells("Serial Number").Value.ToString

                TxtProblemDetails.Text = row.Cells("Problem Details").Value.ToString
                TxtReceiveItem.Text = row.Cells("Receive Item").Value.ToString
                TxtSolutionDetails.Text = row.Cells("Solution Details").Value.ToString


                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim dr As SqlDataReader





                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "select *from [Warranty Invoice] where [warranty Invoice No]= '" + TxtWarrantyInvoice.Text + "'"


                dr = cmd.ExecuteReader()
                dr.Read()

                If dr.HasRows Then

                    DtpDate.Value = dr.Item("Date").ToString
                    DtpDeliveryDate.Value = dr.Item("Delivery Date").ToString
                    TxtName.Text = dr.Item("Customer Name").ToString
                    TxtPhoneNo.Text = dr.Item("Mobile Number").ToString
                    TxtAddress.Text = dr.Item("Address").ToString



                End If

                dr.Close()
                con.Close()


            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

        End Try
    End Sub

    Private Sub GrdWarrantySerial_CellMouseDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdWarrantySerial.CellMouseDoubleClick
        Try


            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdWarrantySerial.Rows(e.RowIndex)

                'Delete data from Warranty serial
                DeleteData()


            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub LblWarrantySerial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblWarrantySerial.Click

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