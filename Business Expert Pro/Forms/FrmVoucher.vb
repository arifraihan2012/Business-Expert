Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class FrmVoucher

  
    'Crating Privet Sub for Clear Data
    Sub ClearData()

        Try
            TxtVoucherID.Text = ""

            DtpDate.Value = Now

            CmbVoucherPurposeID.SelectedValue = 0
            TxtPaidAmount.Text = "0"
            TxtInitialBalance.Text = "0"

            CmbVoucherSubcategoryID.SelectedValue = 0
           

            


        Catch ex As Exception
            MessageBox.Show("Error while Clearing record on table..." & ex.Message, "Clear Records")
        Finally

        End Try
    End Sub


    Sub ClearAllData()

        Try
            TxtVoucherID.Text = ""
            DtpDate.Value = Now

            CmbVoucherCategoryID.SelectedIndex = 0
            CmbVoucherPurposeID.SelectedValue = 0


            TxtPaidAmount.Text = ""

            TxtName.Text = ""


            TxtRemarks.Text = ""
            TxtMobileNo.Text = ""
            TxtInitialBalance.Text = ""


            CmbVoucherSubcategoryID.SelectedValue = 0

            GrpName.Enabled = False
            GrpDetails.Enabled = False

           


        Catch ex As Exception
            MessageBox.Show("Error while Clearing record on table..." & ex.Message, "Clear Records")
        Finally

        End Try
    End Sub

    'sub for new invoice
    Sub NewInvoice()
        'Sale Invoice 
        Me.TxtVoucherNo.Text = "" 'Format(Now, "ddMMyyhhmmssms") & FrmHome.LblUserID.Text & FrmHome.LblComputerID.Text
    End Sub


    'Crating Privet Sub for Clear Data for voucher
    Sub ClearDataForVoucher()

        Try
            TxtVoucherID.Text = ""
            DtpDate.Value = Now





            CmbVoucherPurposeID.SelectedValue = 0


            TxtPaidAmount.Text = ""
            TxtReceivedAmount.Text = ""

            TxtName.Text = ""


            TxtRemarks.Text = ""
            TxtMobileNo.Text = ""
            TxtInitialBalance.Text = ""

            CmbVoucherSubcategoryID.SelectedValue = 0

           

            TxtTotalAmount.Text = ""

            'sub for new invoice
            NewInvoice()


        Catch ex As Exception
            MessageBox.Show("Error while Clearing record on table..." & ex.Message, "Clear Records")
        Finally

        End Try
    End Sub
  
    'Creating Privet Sub of Refreshing Data
    Sub RefreshData()

        ' Load Data
        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Voucher].[Voucher ID],[Voucher Subcategory].[Voucher Subcategory Name],[Voucher Purpose].[Voucher Purpose Name],[Voucher].[Paid Amount],[Voucher].[Received Amount] From [Voucher] Join [Voucher Purpose] On [Voucher].[Voucher Purpose ID]=[Voucher Purpose].[Voucher Purpose ID] Join [Voucher Subcategory] On [Voucher].[Voucher Subcategory ID]=[Voucher Subcategory].[Voucher Subcategory ID] where [Voucher].[Voucher No] = '" + TxtVoucherNo.Text + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "SHONCHOY_Voucher")
            connection.Close()
            GrdVoucher.DataSource = ds
            GrdVoucher.DataMember = "SHONCHOY_Voucher"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdVoucher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            con.Close()







            'Total Amount Count
            TotalAmountCount()





        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try
        'End Refresh Data

    End Sub

    'Total Amount Count
    Sub TotalAmountCount()

        Dim total As String = 0
        For i As Integer = 0 To GrdVoucher.RowCount - 1
            total += GrdVoucher.Rows(i).Cells(3).Value + GrdVoucher.Rows(i).Cells(4).Value
        Next
        Me.TxtTotalAmount.Text = total


    End Sub
   
   

    Private Sub BtnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click



        If TxtName.Text = "" Then
            MsgBox("Please Type Name")

        Else


            Dim q As MsgBoxResult


            q = MsgBox("Total Amount = " + TxtTotalAmount.Text + ", Do you really want to Save?", MsgBoxStyle.YesNo, "Voucher")


            If q = MsgBoxResult.Yes Then

                Try

                    'Update Voucher Number
                    UpdateVoucherNumber()

                    'Update Click Msg
                    MsgBox("Data Saved Successfully", MsgBoxStyle.OkOnly, "Voucher")


                    'Dim qs As MsgBoxResult
                    'qs = MsgBox("Do you really want to Send Sms?", MsgBoxStyle.YesNo, "SMS")
                    'If qs = MsgBoxResult.Yes Then

                    'If CmbVoucherCategoryID.Text = "Debit Voucher" Then

                    'SendSmsForvoucherForPaidAmount()
                    'ElseIf CmbVoucherCategoryID.Text = "Credit Voucher" Then
                    'SendSmsForvoucherForReceivedAmount()
                    'End If

                    'End If

                    'Making Clear
                    ClearAllData()


                    'sub for new invoice
                    NewInvoice()


                    'Refresh Data
                    RefreshData()



                Catch ex As Exception
                    MessageBox.Show("Error while Updating record on table..." & ex.Message, "Save Button")
                Finally

                End Try

            End If
        End If

    End Sub

    'Insert Or Update Voucher

    Sub InsertOrUpdateVoucher()

        If TxtVoucherID.Text = "" Then

            'Data Insert Code
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now

            Try

                'Emty Txt Box Can Not Be Save Code
                If Me.CmbVoucherCategoryID.Text = "" Or Me.CmbVoucherPurposeID.Text = "" Or Me.TxtPaidAmount.Text = "" Or Me.TxtReceivedAmount.Text = "" Or Me.CmbVoucherSubcategoryID.Text = "" Then
                    MsgBox("Required Field can not be empty", MsgBoxStyle.OkOnly, "Voucher")

                Else
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd1.Connection = con
                    cmd.CommandText = "INSERT INTO [Voucher]([Voucher Purpose ID],[Paid Amount],[Received Amount],[Remarks],[Voucher Subcategory ID],[Voucher No]) VALUES ('" + CmbVoucherPurposeID.SelectedValue.ToString + "','" + TxtPaidAmount.Text + "','" + TxtReceivedAmount.Text + "','" + TxtRemarks.Text + "','" + CmbVoucherSubcategoryID.SelectedValue.ToString + "','" + TxtVoucherNo.Text + "')"
                    cmd1.CommandText = "INSERT INTO [Log Details] ([Log Category],[Log Description],[User Account ID],[Log Date],[Log Time],[Task ID]) VALUES ('Voucher','Data Inserted Successfully [" + TxtRemarks.Text + "]','" + FrmHome.LblUserID.Text + "','" + currentDate + "','" + currentTime + "','New Data Inserted')"
                    cmd.ExecuteNonQuery()
                    cmd1.ExecuteNonQuery()



                    'Inserted Click Msg
                    'MsgBox("Data Inserted Successfully", MsgBoxStyle.OkOnly, "Voucher")


                    'Making Clear
                    ClearData()



                    'Refresh Data
                    RefreshData()

                    'Focus on Branch ID text box
                    CmbVoucherCategoryID.Focus()


                End If
            Catch ex As Exception
                MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
            Finally
                con.Close()

            End Try


        Else



            'Data Update Code
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now
            Try



                'Emty Txt Box Can Not Be Save Code
                If Me.DtpDate.Text = "" Or Me.CmbVoucherCategoryID.Text = "" Or Me.CmbVoucherPurposeID.SelectedValue = 0 Or Me.CmbVoucherPurposeID.Text = "" Or Me.CmbVoucherSubcategoryID.SelectedValue = 0 Or Me.CmbVoucherSubcategoryID.Text = "" Then
                    MsgBox("Required Field can not be empty", MsgBoxStyle.OkOnly, "Voucher")


                Else
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd1.Connection = con
                    cmd.CommandText = "UPDATE [Voucher] SET [Voucher Purpose ID]= '" + CmbVoucherPurposeID.SelectedValue.ToString + "',[Paid Amount]= '" + TxtPaidAmount.Text + "',[Received Amount]= '" + TxtReceivedAmount.Text + "',[Remarks]= '" + TxtRemarks.Text + "',[Voucher Subcategory ID]= '" + CmbVoucherSubcategoryID.SelectedValue.ToString + "',[Voucher No]= '" + TxtVoucherNo.Text + "' WHERE [Voucher ID]= '" + TxtVoucherID.Text + "'"
                    cmd1.CommandText = "INSERT INTO [Log Details] ([Log Category],[Log Description],[User Account ID],[Log Date],[Log Time],[Task ID]) VALUES ('Voucher','Data Updated Successfully [" + CmbVoucherCategoryID.Text + "]','" + FrmHome.LblUserID.Text + "','" + currentDate + "','" + currentTime + "','" + TxtVoucherID.Text + "')"


                    cmd.ExecuteNonQuery()
                    cmd1.ExecuteNonQuery()


                    'Update Click Msg
                    'MsgBox("Data Updated Successfully", MsgBoxStyle.OkOnly, "Voucher")

                    'Making Clear
                    ClearData()


                    'Refresh Data
                    RefreshData()

                End If
            Catch ex As Exception
                MessageBox.Show("Error while Updating record on table..." & ex.Message, "Update Records")
            Finally
                con.Close()
            End Try


        End If







    End Sub
    Private Sub GrdCashExpenditures_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdVoucher.CellMouseClick

        'Data Grid view code
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdVoucher.Rows(e.RowIndex)

                TxtVoucherID.Text = row.Cells("Voucher ID").Value.ToString
                CmbVoucherPurposeID.Text = row.Cells("Voucher Purpose Name").Value.ToString
                TxtPaidAmount.Text = row.Cells("Paid Amount").Value.ToString
                TxtReceivedAmount.Text = row.Cells("Received Amount").Value.ToString
                CmbVoucherSubcategoryID.Text = row.Cells("Voucher Subcategory Name").Value.ToString






                'Click on Focus on text box

                If Me.CmbVoucherCategoryID.SelectedIndex = 0 Then
                    Me.TxtPaidAmount.Focus()
                Else
                    Me.TxtReceivedAmount.Focus()

                End If



                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim dr As SqlDataReader

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "SELECT  *FROM [Voucher] Join [Voucher Purpose] On [Voucher].[Voucher Purpose ID]=[Voucher Purpose].[Voucher Purpose ID] Join [Voucher Subcategory] On [Voucher].[Voucher Subcategory ID]=[Voucher Subcategory].[Voucher Subcategory ID] Join [Voucher Number] on [Voucher].[Voucher No]=[Voucher Number].[Voucher No]   WHERE [Voucher ID] = '" + Me.TxtVoucherID.Text + "'"


                dr = cmd.ExecuteReader()
                dr.Read()



                Me.CmbVoucherCategoryID.Text = (dr.Item("Voucher Category Name").ToString)
                Me.CmbVoucherPurposeID.SelectedValue = (dr.Item("Voucher Purpose ID").ToString)
                Me.CmbVoucherSubcategoryID.SelectedValue = (dr.Item("Voucher Subcategory ID").ToString)
                Me.TxtVoucherNo.Text = (dr.Item("Voucher No").ToString)
                Me.TxtMobileNo.Text = (dr.Item("Mobile No").ToString)
                Me.TxtRemarks.Text = (dr.Item("Remarks").ToString)
                Me.DtpDate.Text = (dr.Item("Date").ToString)
                Me.TxtName.Text = (dr.Item("Name").ToString)
                Me.TxtInitialBalance.Text = (dr.Item("Initial Balance").ToString)


                dr.Close()
                con.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview")

        End Try
    End Sub



    Private Sub FrmCashExpenditures_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load




        'permission for update and Delete
        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim MyFormName As Form = CType(sender, Form)



            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + FrmHome.LblUserID.Text + "' AND [Category Name] = '" + MyFormName.Text + "' And  [Update Delete Permission]='Yes'"


            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then
                BtnDelete.Enabled = True


            ElseIf Not dr.HasRows Then
                BtnDelete.Enabled = False



                dr.Close()
                con.Close()


            End If

        Catch ex As Exception
            MessageBox.Show("Error while  permission delete to form..." & ex.Message, "Form Load")

        End Try






        'Change Language
        ChangeLanguage()

        'Focus On Date 
        Me.DtpDate.Value = Now()



        'Load Combobox For Voucher Purpose()
        loadComboBoxForVoucherPurpose()

        'Load Combobox For Voucher Subcategory()
        LoadComboboxForVoucherSubcategory()


        'Clear Data
        ClearData()






    End Sub

    'Load Combobox For Voucher Purpose()
    Sub loadComboBoxForVoucherPurpose()

        Try



            Dim con1 As New SqlConnection
            Dim cmd1 As New SqlCommand
            con1.ConnectionString = FrmHome.ConnectionString

            Dim strSQL1 As String = "SELECT [Voucher Purpose ID],[Voucher Purpose Name] FROM [Voucher Purpose]"
            Dim da1 As New System.Data.SqlClient.SqlDataAdapter(strSQL1, con1)
            Dim ds1 As New DataSet
            da1.Fill(ds1, "[Voucher Purpose]")

            With Me.CmbVoucherPurposeID
                .DataSource = ds1.Tables("[Voucher Purpose]")
                .DisplayMember = "Voucher Purpose Name"
                .ValueMember = "Voucher Purpose ID"
            End With

            CmbVoucherPurposeID.SelectedValue = 0

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Load Combobox For Voucher Subcategory()
    Sub LoadComboboxForVoucherSubcategory()

        Try
            Dim con2 As New SqlConnection
            Dim cmd2 As New SqlCommand
            con2.ConnectionString = FrmHome.ConnectionString

            Dim strSQL2 As String = "SELECT [Voucher Subcategory ID],[Voucher Subcategory Name] FROM [Voucher Subcategory]"
            Dim da2 As New System.Data.SqlClient.SqlDataAdapter(strSQL2, con2)
            Dim ds2 As New DataSet
            da2.Fill(ds2, "[Voucher Subcategory]")

            With Me.CmbVoucherSubcategoryID
                .DataSource = ds2.Tables("[Voucher Subcategory]")
                .DisplayMember = "Voucher Subcategory Name"
                .ValueMember = "Voucher Subcategory ID"

            End With

            CmbVoucherSubcategoryID.SelectedValue = 0


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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

            Me.TxtVoucherID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.DtpDate.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtVoucherNo.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.CmbVoucherPurposeID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))

            'Me.CmbVoucherCategoryID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))

            Me.TxtRemarks.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.CmbVoucherSubcategoryID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtMobileNo.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtPaidAmount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtReceivedAmount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtInitialBalance.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtTotalAmount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))



            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            Me.GrdVoucher.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.GrdVoucher.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)


            'MsgBox(dr.Item("Language Font"))












            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            con.Close()
        End Try

        'End Language

    End Sub


    Private Sub DtpExpenseDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DtpDate.KeyDown
        'Focus on Voucher Category Text Box
        If e.KeyCode = Keys.Enter Then
            Me.TxtRemarks.Focus()

        End If
    End Sub

    Private Sub DtpExpenseDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtpDate.ValueChanged

    End Sub

    Private Sub CmbExpenseCategory_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbVoucherCategoryID.KeyDown

        If e.KeyCode = Keys.Enter Then

            CmbVoucherSubcategoryID.Focus()
        End If
    End Sub

    Private Sub CmbExpenseCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbVoucherCategoryID.SelectedIndexChanged

    End Sub

    Private Sub CmbExpensePurpose_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbVoucherPurposeID.KeyDown
        'Focus on Amount Text Box
        If e.KeyCode = Keys.Enter Then

            TxtRemarks.Focus()



        End If

    End Sub

    Private Sub CmbVoucherPurposeID_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CmbVoucherPurposeID.MouseClick

        'Load Combobox For Voucher Purpose
        loadComboBoxForVoucherPurpose()

    End Sub

    Private Sub CmbExpensePurpose_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbVoucherPurposeID.SelectedIndexChanged

    End Sub
    Private Sub CmbExpenseBranch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'Focus on Remarks Text Box
        If e.KeyCode = Keys.Enter Then
            Me.CmbVoucherCategoryID.Focus()

        End If



    End Sub

    Private Sub CmbExpenseBranch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Focus on Voucher Category
        CmbVoucherCategoryID.Focus()
    End Sub
    Private Sub CmbSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub


    Private Sub CmbExpenseSubcategory_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub CmbExpenseSubcategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CmbExpenseSubcategoryID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbVoucherSubcategoryID.KeyDown
        If e.KeyCode = Keys.Enter Then

            CmbVoucherPurposeID.Focus()
        ElseIf e.KeyCode = Keys.Space AndAlso e.Control Then

            BtnSave.PerformClick()

        ElseIf e.KeyCode = Keys.F2 Then

            TxtVoucherID.Text = ""
            CmbVoucherSubcategoryID.SelectedValue = 0
            CmbVoucherPurposeID.SelectedValue = 0
            TxtInitialBalance.Text = ""
            TxtPaidAmount.Text = "0"
            TxtReceivedAmount.Text = "0"


        End If
    End Sub

    Private Sub CmbVoucherSubcategoryID_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CmbVoucherSubcategoryID.MouseClick
        'Load Combobox For Voucher Subcategory
        LoadComboboxForVoucherSubcategory()

    End Sub

    Private Sub CmbExpenseSubcategoryID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbVoucherSubcategoryID.SelectedIndexChanged

    End Sub

    Private Sub TxtMobileNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtMobileNo.KeyDown
        If e.KeyCode = Keys.Enter Then

            CmbVoucherSubcategoryID.Focus()


        End If
    End Sub

    Private Sub TxtMobileNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtMobileNo.TextChanged

    End Sub
    Sub Search()



        Try

            'Search Code

            ' Load Data
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Voucher].[Voucher ID],[Voucher Subcategory].[Voucher Subcategory Name],[Voucher Purpose].[Voucher Purpose Name],[Voucher].[Paid Amount],[Voucher].[Received Amount] From [Voucher] Join [Voucher Purpose] On [Voucher].[Voucher Purpose ID]=[Voucher Purpose].[Voucher Purpose ID]  Join [Voucher Subcategory] On [Voucher].[Voucher Subcategory ID]=[Voucher Subcategory].[Voucher Subcategory ID] where [Voucher].[Voucher No] = '" + TxtVoucherNo.Text + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "SHONCHOY_Voucher")
            connection.Close()
            GrdVoucher.DataSource = ds
            GrdVoucher.DataMember = "SHONCHOY_Voucher"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdVoucher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            con.Close()


            'Total Amount Count
            TotalAmountCount()





            Dim con1 As New SqlConnection
            Dim cmd1 As New SqlCommand
            Dim dr As SqlDataReader

            con1.ConnectionString = FrmHome.ConnectionString
            con1.Open()
            cmd1.Connection = con1
            cmd1.CommandText = "SELECT  *FROM [Voucher Number]   WHERE [Voucher No] = '" + Me.TxtVoucherNo.Text + "'"


            dr = cmd1.ExecuteReader()
            dr.Read()




            Me.TxtMobileNo.Text = (dr.Item("Mobile No").ToString)
            Me.DtpDate.Text = (dr.Item("Date").ToString)
            Me.TxtName.Text = (dr.Item("Name").ToString)

            dr.Close()
            con1.Close()




        Catch ex As Exception
            MessageBox.Show("Error while searching records on table..." & ex.Message, "Search Records")
        Finally

        End Try


    End Sub



    Private Sub TxtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub TxtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDebitVoucher.Click

        'Group Box enable 
        GrpName.Enabled = True
        GrpDetails.Enabled = True



        'Clear All Data for voucher
        ClearDataForVoucher()

        'Debit Voucher auto select
        CmbVoucherCategoryID.SelectedIndex = 0

        'Auto chose received or paid amount
        Me.TxtPaidAmount.Enabled = True
        Me.TxtReceivedAmount.Enabled = False

        'Total Amount Cannot count if the text box have no value, thats why value set 0
        Me.TxtReceivedAmount.Text = 0



        'Focus on Name Textbox
        TxtName.Focus()





    End Sub





    Private Sub TxtRemarks_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtRemarks.KeyDown
        'Focus on Date Text Box
        If e.KeyCode = Keys.Enter Then

            If Me.CmbVoucherCategoryID.SelectedIndex = 0 Then
                Me.TxtPaidAmount.Focus()
            Else
                Me.TxtReceivedAmount.Focus()

            End If

        End If
    End Sub

    Private Sub TxtRemarks_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtRemarks.TextChanged

    End Sub

    Private Sub BtnCreditVoucher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCreditVoucher.Click

        'Group Box enable 
        GrpName.Enabled = True
        GrpDetails.Enabled = True






        'Clear All Data for voucher
        ClearDataForVoucher()

        'Debit Voucher auto select
        CmbVoucherCategoryID.SelectedIndex = 1

        'Auto chose received or paid amount
        Me.TxtReceivedAmount.Enabled = True
        Me.TxtPaidAmount.Enabled = False

        'Total Amount Cannot count if the text box have no value, thats why value set 0
        Me.TxtPaidAmount.Text = 0

        'Focus on voucher subcategory
        CmbVoucherSubcategoryID.Focus()


        'Focus on Name Textbox
        TxtName.Focus()




    End Sub

    Private Sub TxtReceivedAmount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtReceivedAmount.KeyDown

        If e.KeyCode = Keys.Enter Then
            If TxtName.Text = "" Then
                MsgBox("Please Type Name")

                'Focus on name textbox
                TxtName.Focus()

            Else
                'Insert or update Into Voucher Number
                InsertorUpdateIntoVoucherNumber()


                'Insert Or Update Voucher
                InsertOrUpdateVoucher()

                'Voucher Subcategory focus
                CmbVoucherSubcategoryID.Focus()
            End If
        End If
    End Sub

    'Insert or update Into Voucher Number
    Sub InsertorUpdateIntoVoucherNumber()


        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim con2 As New SqlConnection
            Dim cmd2 As New SqlCommand
            Dim dr1 As SqlDataReader

            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now



            If TxtVoucherNo.Text = "" Then

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "INSERT INTO [Voucher Number] ([User Account ID],[Computer ID],[Prepared Date],[Prepared Time],[Branch ID],[Total Amount],[Status],[Voucher Category Name],[Name],[Mobile No],[Date]) values ('" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtTotalAmount.Text + "','INCOMPLETE','" + CmbVoucherCategoryID.Text + "','" + TxtName.Text + "','" + TxtMobileNo.Text + "','" + DtpDate.Value + "')"
                cmd.ExecuteNonQuery()
                con.Close()


                con2.ConnectionString = FrmHome.ConnectionString
                con2.Open()
                cmd2.Connection = con2
                cmd2.CommandText = "SELECT top 1 [Voucher No] FROM [Voucher Number] where [User Account ID]= '" + FrmHome.LblUserID.Text + "'  order by [Voucher No] desc"

                dr1 = cmd2.ExecuteReader()
                dr1.Read()

                TxtVoucherNo.Text = (dr1.Item("Voucher No").ToString)
                con2.Close()
                dr1.Close()



            Else





                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "Update [Voucher Number] set [User Account ID]= '" + FrmHome.LblUserID.Text + "',[Total Amount]= '" + TxtTotalAmount.Text + "',[Prepared Time]= '" + currentTime + "',[Branch ID]= '" + FrmHome.lblBranchID.Text + "',[Date]='" + DtpDate.Value + "',[Status]='INCOMPLETE',[Voucher Category Name]='" + CmbVoucherCategoryID.Text + "',[Name]= '" + TxtName.Text + "',[Mobile No]= '" + TxtMobileNo.Text + "' where [Voucher No]= '" + TxtVoucherNo.Text + "'"
                cmd.ExecuteNonQuery()
                con.Close()


            End If

        Catch ex As Exception
            MessageBox.Show("Error while Inserting to voucher number record on table..." & ex.Message, "Insert Voucher Number")
        Finally

        End Try



    End Sub

    Sub UpdateVoucherNumber()

        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim currentTime As DateTime = DateTime.Now

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Update [Voucher Number] set [Total Amount]= '" + TxtTotalAmount.Text + "',[Branch ID]='" + FrmHome.lblBranchID.Text + "',[User Account ID]='" + FrmHome.LblUserID.Text + "',[Computer ID]='" + FrmHome.LblComputerID.Text + "',[Date]='" + DtpDate.Value + "',[Status]='COMPLETE',[Voucher Category Name]='" + CmbVoucherCategoryID.Text + "',[Name]= '" + TxtName.Text + "',[Mobile No]= '" + TxtMobileNo.Text + "' where [Voucher No]= '" + TxtVoucherNo.Text + "'"
            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while Updating voucher number record on table..." & ex.Message, "Update Voucher Number")
        Finally

        End Try



    End Sub

    Private Sub TxtReceivedAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtReceivedAmount.TextChanged

    End Sub

    Private Sub TxtPaidAmount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPaidAmount.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TxtName.Text = "" Then
                MsgBox("Please Type Name")

                'Focus on name textbox
                TxtName.Focus()

            Else
                'Insert or Update Into Voucher Number
                InsertorUpdateIntoVoucherNumber()

                'Insert Or Update Voucher
                InsertOrUpdateVoucher()


                'Voucher Subcategory focus
                CmbVoucherSubcategoryID.Focus()
            End If
        End If
    End Sub

    Private Sub TxtPaidAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPaidAmount.TextChanged



    End Sub

    Private Sub CmbSearchVoucherSubcategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CmbSearchVoucherSubcategory_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'Search
        Search()
    End Sub

    Private Sub CmbSearchVoucherPurpose_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CmbSearchVoucherPurpose_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)


        'Search
        Search()


    End Sub

    Private Sub CmbSearchVoucherCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Search
        Search()
    End Sub


    Private Sub GrdVoucher_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdVoucher.CellMouseDoubleClick
        'Empty Voucher ID Can Not Be Update
        If Me.TxtVoucherID.Text = "" Then
            MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Voucher")

        Else


            'Data Delete Code
            Dim q As MsgBoxResult
            q = MsgBox("Do you really want to Delete the row?", MsgBoxStyle.YesNo, "Voucher")
            If q = MsgBoxResult.Yes Then

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim cmd1 As New SqlCommand
                Dim currentDate As DateTime = DateTime.Today
                Dim currentTime As DateTime = DateTime.Now
                Try
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd1.Connection = con
                    cmd.CommandText = "Delete from [Voucher] where [Voucher ID]= '" + TxtVoucherID.Text + "'"
                    cmd1.CommandText = "INSERT INTO [Log Details] ([Log Category],[Log Description],[User Account ID],[Log Date],[Log Time],[Task ID]) VALUES ('Voucher','Data Deleted Successfully [" + CmbVoucherCategoryID.Text + "]','" + FrmHome.LblUserID.Text + "','" + currentDate + "','" + currentTime + "','" + TxtVoucherID.Text + "')"
                    cmd.ExecuteNonQuery()
                    cmd1.ExecuteNonQuery()



                    'Making Clear
                    ClearData()

                    'Refresh Data
                    RefreshData()

                    CmbVoucherSubcategoryID.Focus()

                Catch ex As Exception
                    MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Records")
                Finally
                    con.Close()
                End Try


            End If
        End If
    End Sub



    Private Sub GrdVoucher_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdVoucher.CellContentClick

    End Sub

    Private Sub TxtName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtName.KeyDown
        If e.KeyCode = Keys.Enter Then

            TxtMobileNo.Focus()

        End If
    End Sub

    Private Sub TxtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtName.TextChanged
        'Change all text entered to be Upercase.
        'TxtName.CharacterCasing = CharacterCasing.Upper

    End Sub

    Private Sub TxtVoucherNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtVoucherNo.KeyDown
        If e.KeyCode = Keys.Enter Then

            Search()

        End If
    End Sub

    Private Sub TxtVoucherNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtVoucherNo.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FrmVoucherHistory.Show()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim q As MsgBoxResult
        q = MsgBox("Do You Really Want to Create New Invoice?", MsgBoxStyle.YesNo, "Voucher")
        If q = MsgBoxResult.Yes Then


            'Making Clear
            ClearAllData()


            'sub for new invoice
            NewInvoice()


            'Refresh Data
            RefreshData()

            'Name Textbox focus
            TxtName.Focus()

        End If


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click


        Try



            Dim q As MsgBoxResult
            q = MsgBox("Do you really want to Cancel Invoice?", MsgBoxStyle.YesNo, "Voucher History")
            If q = MsgBoxResult.Yes Then


                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim cmd1 As New SqlCommand
                Dim cmd2 As New SqlCommand
                Dim currentDate As DateTime = DateTime.Today
                Dim currentTime As DateTime = DateTime.Now



                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd1.Connection = con
                cmd2.Connection = con
                cmd.CommandText = "Delete from [Voucher] where [Voucher No]= '" + TxtVoucherNo.Text + "'"
                cmd2.CommandText = "Delete from [Voucher Number] where [Voucher No]= '" + TxtVoucherNo.Text + "'"
                cmd1.CommandText = "INSERT INTO [Log Details] ([Log Category],[Log Description],[User Account ID],[Log Date],[Log Time],[Task ID]) VALUES ('Voucher','Data Deleted Successfully','" + FrmHome.LblUserID.Text + "','" + currentDate + "','" + currentTime + "','" + TxtVoucherNo.Text + "')"
                cmd.ExecuteNonQuery()
                cmd1.ExecuteNonQuery()
                cmd2.ExecuteNonQuery()
                con.Close()





                'making Clear
                ClearAllData()

                'Refresh Data Voucher
                RefreshData()




            End If




        Catch ex As Exception
            MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Invoice Button")
        Finally

        End Try
    End Sub
End Class