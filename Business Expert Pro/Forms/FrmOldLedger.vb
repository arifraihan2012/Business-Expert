
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class FrmOldLedger

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click

        'Empty Salary ID Can Not Be Update
        If Me.TxtLedgerID.Text = "" Then
            MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Customer Ledger")

        Else

            'Data Delete Code
            Dim q As MsgBoxResult
            q = MsgBox("Do you really want to Delete the row?", MsgBoxStyle.YesNo, "Customer Ledger")
            If q = MsgBoxResult.Yes Then

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand

                Try
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "Delete from [Customer Ledger] where [Ledger ID]= '" + TxtLedgerID.Text + "'"
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
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtRemarks.TextChanged

    End Sub
    'Creating Privet Sub of Clear Data
    Sub ClearData()
        Try
            TxtLedgerID.Text = ""


            DtpTransactionDate.Text = ""

            TxtDiscountAmount.Text = ""
            TxtDebitedAmount.Text = ""
            TxtCreditedAmount.Text = ""
            TxtInitialBalance.Text = ""

            TxtRemarks.Text = ""

            TxtCheckNo.Text = ""
            CmbPaidBy.Text = ""

            TxtDebitedAmount.Enabled = False
            TxtCreditedAmount.Enabled = False


        Catch ex As Exception
            MessageBox.Show("Error while clearing data on table..." & ex.Message, "Clear Data")
        Finally

        End Try


    End Sub

    Private Sub LblPaymentDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    'Creating Privet Sub of Clear Data
    Sub ClearAllData()
        Try
            TxtLedgerID.Text = ""

            CmbCustomerID.Text = ""
            CmbCustomerID.ValueMember = ""

            DtpTransactionDate.Text = ""

            TxtDiscountAmount.Text = ""
            TxtDebitedAmount.Text = ""
            TxtCreditedAmount.Text = ""

            TxtRemarks.Text = ""
            TxtInitialBalance.Text = ""

            cmbSearchName.Text = ""
            cmbSearchName.ValueMember = ""


            TxtCheckNo.Text = ""
            CmbPaidBy.Text = ""


        Catch ex As Exception
            MessageBox.Show("Error while clearing data on table..." & ex.Message, "Clear Data")
        Finally

        End Try


    End Sub
    'Creating Privet Sub for Refresh
    Sub RefreshData()

        ' Load Data
        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Customer Ledger].[Ledger ID],[Customer Information].[Customer Name][Name],[Customer Ledger].[Transaction Date],[Customer Ledger].[Sale Invoice No][Invoice No],[Customer Ledger].[Remarks],[Customer Ledger].[Paid By],[Customer Ledger].[Check No],[Customer Ledger].[Debited Amount],[Customer Ledger].[Credited Amount],[Customer Ledger].[Discount Amount],[Customer Ledger].[Initial Balance] FROM [Customer Ledger] join [Customer Information] on [Customer Ledger].[Customer ID]=[Customer Information].[Customer ID] where [Customer Information].[Customer ID]= '" + CmbCustomerID.ValueMember + "' "
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "Bizpro_Customer Ledger")
            connection.Close()
            GrdCustomerLedger.DataSource = ds
            GrdCustomerLedger.DataMember = "Bizpro_Customer Ledger"

            'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdCustomerLedger.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            con.Close()



            'Total Due amount
            TotalDueAmount()

        Catch ex As Exception
            MessageBox.Show("Error while refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try
        'End Refresh Data
    End Sub

    Private Sub FrmEmployeeSalary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
                BtnUpdate.Enabled = True

            ElseIf Not dr.HasRows Then
                BtnDelete.Enabled = False
                BtnUpdate.Enabled = False


                dr.Close()
                con.Close()


            End If

        Catch ex As Exception
            MessageBox.Show("Error while  permission delete to form..." & ex.Message, "Form Load")

        End Try






        'Change Language
        ChangeLanguage()


    End Sub

    'Total due amount

    Sub TotalDueAmount()

        Dim total As String = 0
        For i As Integer = 0 To GrdCustomerLedger.RowCount - 1
            total += GrdCustomerLedger.Rows(i).Cells(8).Value
        Next

        Dim total2 As String = 0
        For i As Integer = 0 To GrdCustomerLedger.RowCount - 1
            total2 += GrdCustomerLedger.Rows(i).Cells(7).Value
        Next


        Dim total3 As String = 0
        For i As Integer = 0 To GrdCustomerLedger.RowCount - 1
            total3 += GrdCustomerLedger.Rows(i).Cells(9).Value
        Next


        Dim total4 As String = 0
        For i As Integer = 0 To GrdCustomerLedger.RowCount - 1
            total4 += GrdCustomerLedger.Rows(i).Cells(10).Value
        Next

        Me.LblTotalDue.Text = ((Val(total2) + Val(total4)) - (Val(total3) + Val(total)))

        If Val(LblTotalDue.Text) < 0 Then


            Me.LblTotal.Text = "Total Advanced :"
            Me.LblTotalDue.Text = Val(LblTotalDue.Text) * -1

        Else
            Me.LblTotal.Text = "Total Due :"

        End If


    End Sub

    ' Changing Language
    Sub ChangeLanguage()

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

            Me.TxtLedgerID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.CmbCustomerID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.DtpTransactionDate.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))

            Me.TxtDebitedAmount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtCreditedAmount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtDiscountAmount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtRemarks.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.cmbSearchName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.CmbPaidBy.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtCheckNo.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtInitialBalance.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            'Me.LblTotalDue.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, 15, FontStyle.Bold)

            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            Me.GrdCustomerLedger.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.GrdCustomerLedger.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)


            'MsgBox(dr.Item("Language Font"))

            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while changing language on table..." & ex.Message, "Change Language")
        Finally
            con.Close()
        End Try

        'End Language

    End Sub

   

    Private Sub BtnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInsert.Click
        'Data Insert Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now
        Try
            'Same id Twice insert restriction code
            If Not Me.TxtLedgerID.Text = "" Then
                MsgBox("This ID is already Exist.", MsgBoxStyle.OkOnly, "Customer Ledger")


            Else
                'Emty Txt Box Can Not Be Save Code
                If Me.CmbCustomerID.ValueMember = "" Or Me.CmbCustomerID.Text = "" Then
                    MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Customer Ledger")

                Else

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO [Customer Ledger] ([Customer ID],[Transaction Date],[Debited Amount],[Credited Amount],[Remarks],[Prepared Time],[Prepared Date],[Computer ID],[User Account ID],[Discount Amount],[Initial Balance],[Paid By],[Check No]) VALUES ('" + CmbCustomerID.ValueMember + "','" + DtpTransactionDate.Text + "','" + TxtDebitedAmount.Text + "','" + TxtCreditedAmount.Text + "','" + TxtRemarks.Text + "','" + currentTime + "','" + currentDate + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + TxtDiscountAmount.Text + "','" + TxtInitialBalance.Text + "','" + CmbPaidBy.Text + "','" + TxtCheckNo.Text + "' )"
                    cmd.ExecuteNonQuery()

                    'Insert Click Msg
                    MsgBox("Data Inserted Successfully", MsgBoxStyle.OkOnly, "Customer Ledger")



                    'Dim qs As MsgBoxResult
                    'qs = MsgBox("Do you really want to Send Sms?", MsgBoxStyle.YesNo, "SMS")
                    'If qs = MsgBoxResult.Yes Then


                    'SendSmsForAmountReceivedfromCustomer()
                    'End If

                    'Making Clear
                    ClearData()



                    'Refresh Data
                    RefreshData()

                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            con.Close()

        End Try
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        'Data Update Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now
        Try
            'Empty Salary ID Can Not Be Update
            If Me.TxtLedgerID.Text = "" Then
                MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Customer Ledger")

                'Emty Txt Box Can Not Be Save Code
            ElseIf Me.CmbCustomerID.ValueMember = "" Or Me.CmbCustomerID.Text = "" Then
                MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Customer Ledger")


            Else
                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "UPDATE [Customer Ledger] SET [Customer ID]= '" + CmbCustomerID.ValueMember + "', [Transaction Date]= '" + DtpTransactionDate.Text + "', [Debited Amount]= '" + TxtDebitedAmount.Text + "', [Credited Amount]= '" + TxtCreditedAmount.Text + "', [Remarks]= '" + TxtRemarks.Text + "',[Prepared Time]='" + currentTime + "',[Prepared Date]='" + currentDate + "',[Computer ID]= '" + FrmHome.LblComputerID.Text + "',[User Account ID]= '" + FrmHome.LblUserID.Text + "',[Discount Amount]= '" + TxtDiscountAmount.Text + "',[Initial Balance]= '" + TxtInitialBalance.Text + "',[Paid By]= '" + CmbPaidBy.Text + "',[Check No]= '" + TxtCheckNo.Text + "' WHERE [Ledger ID]= '" + TxtLedgerID.Text + "'"
                cmd.ExecuteNonQuery()



                'Update Click Msg
                MsgBox("Data Updated Successfully", MsgBoxStyle.OkOnly, "Customer Ledger")

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
    End Sub

    Private Sub GrdEmployeeSalary_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdCustomerLedger.CellContentClick

    End Sub

    Private Sub GrdEmployeeSalary_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdCustomerLedger.CellMouseClick
        'Grid View Codes
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdCustomerLedger.Rows(e.RowIndex)

                TxtLedgerID.Text = row.Cells("Ledger ID").Value.ToString
                CmbCustomerID.Text = row.Cells("Name").Value.ToString
                DtpTransactionDate.Text = row.Cells("Transaction Date").Value.ToString
                TxtDebitedAmount.Text = row.Cells("Debited Amount").Value.ToString
                TxtCreditedAmount.Text = row.Cells("Credited Amount").Value.ToString
                TxtRemarks.Text = row.Cells("Remarks").Value.ToString
                TxtInitialBalance.Text = row.Cells("Initial Balance").Value.ToString
                TxtDiscountAmount.Text = row.Cells("Discount Amount").Value.ToString
                TxtCheckNo.Text = row.Cells("Check No").Value.ToString
                CmbPaidBy.Text = row.Cells("Paid By").Value.ToString

                'Textbox enebled
                TxtDebitedAmount.Enabled = True
                TxtCreditedAmount.Enabled = True



                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim dr As SqlDataReader

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "SELECT  *FROM [Customer Ledger]  WHERE [Ledger ID] = " + Me.TxtLedgerID.Text + ""


                dr = cmd.ExecuteReader()
                dr.Read()



                Me.CmbCustomerID.ValueMember = (dr.Item("Customer ID").ToString)




                dr.Close()

            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview")

        End Try
    End Sub




    Private Sub CmbSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Focus text search box
        cmbSearchName.Focus()
    End Sub

    'Privet sub for search Customer
    Sub SearchCustomer()
        Try

            'Search Code
            ' Load Data
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim connectionString As String = FrmHome.ConnectionString



            Dim sql As String = "SELECT [Customer Ledger].[Ledger ID],[Customer Information].[Customer Name][Name],[Customer Ledger].[Transaction Date],[Customer Ledger].[Sale Invoice No][Invoice No],[Customer Ledger].[Remarks],[Customer Ledger].[Paid By],[Customer Ledger].[Check No],[Customer Ledger].[Debited Amount],[Customer Ledger].[Credited Amount],[Customer Ledger].[Discount Amount],[Customer Ledger].[Initial Balance] FROM [Customer Ledger] join [Customer Information] on [Customer Ledger].[Customer ID]=[Customer Information].[Customer ID] WHERE ([Customer Ledger].[Customer ID] = '" + Me.cmbSearchName.ValueMember + "')"

            Dim connection As New SqlConnection(connectionString)

            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "Bizpro_Customer Ledger")
            GrdCustomerLedger.DataSource = ds
            GrdCustomerLedger.DataMember = "Bizpro_Customer Ledger"

            GrdCustomerLedger.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            con.Close()


            'Total Due amount
            TotalDueAmount()







        Catch ex As Exception
            MessageBox.Show("Error while searching records on table..." & ex.Message, "Search Button")
        Finally

        End Try
    End Sub

    Private Sub TxtDebitedAmount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDebitedAmount.KeyDown
        'Focus on Payment Date Text Box
        If e.KeyCode = Keys.Enter Then
            TxtDiscountAmount.Focus()

        End If
    End Sub

    Private Sub TxtDebitedAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDebitedAmount.TextChanged

    End Sub

    Private Sub TxtCreditedAmount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCreditedAmount.KeyDown
        'Focus on discount Text Box
        If e.KeyCode = Keys.Enter Then
            Me.TxtDiscountAmount.Focus()

        End If
    End Sub

    Private Sub TxtCreditedAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCreditedAmount.TextChanged

    End Sub

    Private Sub CmbCustomerID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbCustomerID.KeyDown
        'Focus on Payment Date Text Box
        If e.KeyCode = Keys.Enter Then
            FrmListofCustomers.Show()
            FrmListofCustomers.TxtSearchCustomerName.Focus()
            FrmListofCustomers.Label1.Text = "Customer Ledger"
        End If
    End Sub

    Private Sub CmbCustomerID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbCustomerID.KeyPress
        e.Handled = True
    End Sub

    Private Sub CmbCustomerID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCustomerID.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbSearchName.KeyDown
        If e.KeyCode = Keys.Enter Then
            FrmListofCustomers.Show()
            FrmListofCustomers.TxtSearchCustomerName.Focus()
            FrmListofCustomers.Label1.Text = "Search Customer"
        End If


        If e.KeyCode = Keys.Enter Then
            SearchCustomer()


        End If
    End Sub
    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click

        SearchCustomer()

    End Sub

    Private Sub TxtDiscountAmount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDiscountAmount.KeyDown
        'Focus on Paid by combo Box
        If e.KeyCode = Keys.Enter Then
            Me.CmbPaidBy.Focus()

        End If
    End Sub
    Private Sub TxtDiscountAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDiscountAmount.TextChanged

    End Sub

    Private Sub CmbPaidBy_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbPaidBy.KeyDown
        'Focus on check no text box
        If e.KeyCode = Keys.Enter Then
            Me.TxtCheckNo.Focus()

        End If
    End Sub

    Private Sub CmbPaidBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbPaidBy.SelectedIndexChanged
        'Focus on check no text box
        TxtCheckNo.Focus()
    End Sub

    Private Sub TxtCheckNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCheckNo.KeyDown
        'Focus on Remarks text box
        If e.KeyCode = Keys.Enter Then
            Me.TxtRemarks.Focus()
        End If
    End Sub

    Private Sub TxtCheckNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCheckNo.TextChanged

    End Sub

    Private Sub cmbSearchName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSearchName.SelectedIndexChanged

    End Sub

    Private Sub BtnDebitVoucher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDebitVoucher.Click
        Try

            'Making Clear
            ClearAllData()


            'ReadOnly Desible eneble
            TxtDebitedAmount.Enabled = True
            TxtCreditedAmount.Enabled = False


            'Focus on Employee ID
            Me.CmbCustomerID.Focus()


            'RefreshData
            RefreshData()

        Catch ex As Exception
            MessageBox.Show("Error while clearing data  on table..." & ex.Message, "Form Load")
        Finally

        End Try
    End Sub
    'Focus On Payment Or Receive TextBox
    Sub FocusOnPaymentOrReceiveTextBox()

        If TxtDebitedAmount.Enabled = False Then
            TxtCreditedAmount.Focus()

        ElseIf TxtCreditedAmount.Enabled = False Then
            TxtDebitedAmount.Focus()
        End If

    End Sub

    Private Sub BtnCreditVoucher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCreditVoucher.Click
        Try

            'Making Clear
            ClearAllData()


            'ReadOnly Desible eneble
            TxtDebitedAmount.Enabled = False
            TxtCreditedAmount.Enabled = True

            'Focus on Employee ID
            Me.CmbCustomerID.Focus()


            'RefreshData
            RefreshData()

        Catch ex As Exception
            MessageBox.Show("Error while clearing data  on table..." & ex.Message, "Form Load")
        Finally

        End Try
    End Sub

    Private Sub GrpLedger_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrpLedger.Enter

    End Sub

    Private Sub GrpLedger_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GrpLedger.KeyPress

    End Sub
End Class