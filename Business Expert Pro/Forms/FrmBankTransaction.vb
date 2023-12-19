Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmBankTransaction

    Private Sub FrmBankTransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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













        Try

            'Change Language
            ChangeLanguage()

            'Focus on ComboBox
            Me.CmbBankID.Focus()




            'Load combobox
            LoadComboBox()

            'clear data
            ClearData()

            DtpTransactionDate.Value = Now





        Catch ex As Exception
            MessageBox.Show("Error while changing language on table..." & ex.Message, "Form Load")
        Finally

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

            'Empty Bank Transaction ID Can Not Be Update
            If Me.TxtBankTransactionID.Text = "" Then
                MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Bank Transaction")

                'Empty Txt Box Can Not Be Save Code

            ElseIf Me.CmbBankID.Text = "" Or Me.CmbBankID.SelectedValue = 0 Then
                MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Bank Transaction")

            Else
                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd1.Connection = con
                cmd.CommandText = "UPDATE [Bank Transaction] SET [Bank ID]= '" + CmbBankID.SelectedValue.ToString + "', [Debited Amount]= '" + TxtDebitedAmount.Text + "',[Credited Amount] = '" + TxtCreditedAmount.Text + "',[Check No]= '" + TxtCheckNo.Text + "',[Remarks]= '" + TxtRemarks.Text + "',[Transaction Date]= '" + DtpTransactionDate.Value + "',[Prepared Time]='" + currentTime + "',[Prepared Date]='" + currentDate + "',[Computer ID]= '" + FrmHome.LblComputerID.Text + "',[Branch ID]= '" + FrmHome.lblBranchID.Text + "' WHERE [Bank Transaction ID]= '" + TxtBankTransactionID.Text + "'"
                cmd1.CommandText = "INSERT INTO [Log Details] ([Log Category],[Log Description],[User Account ID],[Log Date],[Log Time],[Task ID]) VALUES ('Bank Transaction','Data Updated Successfully','" + FrmHome.LblUserID.Text + "','" + currentDate + "','" + currentTime + "','" + TxtBankTransactionID.Text + "')"



                cmd.ExecuteNonQuery()
                cmd1.ExecuteNonQuery()


                'Update Click Msg
                MsgBox("Data Updated Successfully", MsgBoxStyle.OkOnly, "Bank Transaction")

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

    Sub LoadComboBox()
        Try



            Dim con1 As New SqlConnection
            Dim cmd1 As New SqlCommand
            con1.ConnectionString = FrmHome.ConnectionString

            Dim strSQL1 As String = "SELECT [Bank ID],[Bank Name] FROM [Bank Information]"
            Dim da1 As New System.Data.SqlClient.SqlDataAdapter(strSQL1, con1)
            Dim ds1 As New DataSet
            da1.Fill(ds1, "[Bank Information]")

            With Me.CmbBankID
                .DataSource = ds1.Tables("[Bank Information]")
                .ValueMember = "Bank ID"
                .DisplayMember = "Bank Name"
            End With


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            con.ConnectionString = FrmHome.ConnectionString

            Dim strSQL As String = "SELECT [Bank ID],[Bank Name] FROM [Bank Information]"
            Dim da As New System.Data.SqlClient.SqlDataAdapter(strSQL, con)
            Dim ds As New DataSet
            da.Fill(ds, "[Bank Information]")

            With Me.CmbSearchBankName
                .DataSource = ds.Tables("[Bank Information]")
                .ValueMember = "Bank ID"
                .DisplayMember = "Bank Name"




            End With

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

            Me.TxtBankTransactionID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.CmbBankID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtDebitedAmount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtCreditedAmount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtCheckNo.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtRemarks.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.DtpTransactionDate.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.CmbSearchBankName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtSearch.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))

            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            Me.GrdBankTransaction.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.GrdBankTransaction.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)


            'MsgBox(dr.Item("Language Font"))

            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while inserting Language on table..." & ex.Message, "Change Language")
        Finally
            con.Close()
        End Try

        'End Language

    End Sub


    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        'Empty Bank Transaction ID Can Not Be Update
        If Me.TxtBankTransactionID.Text = "" Then
            MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Bank Transaction")

        Else


            'Data Delete Code
            Dim q As MsgBoxResult
            q = MsgBox("Do you really want to Delete the row?", MsgBoxStyle.YesNo, "Bank Transaction")
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
                    cmd.CommandText = "Delete from [Bank Transaction] where [Bank Transaction ID]= '" + TxtBankTransactionID.Text + "'"
                    cmd1.CommandText = "INSERT INTO [Log Details] ([Log Category],[Log Description],[User Account ID],[Log Date],[Log Time],[Task ID]) VALUES ('Bank Transaction','Data Deleted Successfully','" + FrmHome.LblUserID.Text + "','" + currentDate + "','" + currentTime + "','" + TxtBankTransactionID.Text + "')"
                    cmd.ExecuteNonQuery()
                    cmd1.ExecuteNonQuery()

                    'Refresh Data
                    RefreshData()


                    'Making Clear
                    ClearData()





                Catch ex As Exception
                    MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Records")
                Finally
                    con.Close()
                End Try


            End If
        End If




    End Sub


    Sub ClearData()
        'Creating Privet sub of Clearing text 
        Try

            TxtBankTransactionID.Text = ""

            CmbBankID.SelectedValue = 0



            TxtDebitedAmount.Text = ""
            TxtCreditedAmount.Text = ""
            TxtCheckNo.Text = ""
            TxtRemarks.Text = ""
            DtpTransactionDate.Value = Now




            'TxtSearch.Text = ""
            'CmbSearchBankName.SelectedValue = 0

            TxtCreditedAmount.Enabled = False
            TxtDebitedAmount.Enabled = False



        Catch ex As Exception
            MessageBox.Show("Error while clearing data on table..." & ex.Message, "Clear Data")
        Finally

        End Try

    End Sub
    Sub ClearAllData()
        'Creating Privet sub of Clearing text 
        Try

            TxtBankTransactionID.Text = ""

            CmbBankID.SelectedValue = 0



            TxtDebitedAmount.Text = ""
            TxtCreditedAmount.Text = ""
            TxtCheckNo.Text = ""
            TxtRemarks.Text = ""
            DtpTransactionDate.Value = Now



            CmbSearch.Text = ""
            TxtSearch.Text = ""

            TxtSearch.Visible = True
            CmbSearchBankName.Visible = False



        Catch ex As Exception
            MessageBox.Show("Error while clearing data on table..." & ex.Message, "Clear Data")
        Finally

        End Try

    End Sub

    Private Sub BtnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        'Data Insert Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now

        Try
            'Same id Twice insert restriction code
            If Not Me.TxtBankTransactionID.Text = "" Then
                MsgBox("This ID is already exists.", MsgBoxStyle.OkOnly, "Bank Transaction")


            Else
                'Empty Txt Box Can Not Be Save Code
                If Me.CmbBankID.SelectedValue = 0 Then
                    MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Bank Transaction")

                Else
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd1.Connection = con
                    cmd.CommandText = "INSERT INTO [Bank Transaction] ([Bank ID],[Debited Amount],[Credited Amount],[Check No],[Remarks],[Transaction Date],[Prepared Time],[Prepared Date],[Computer ID],[Branch ID]) VALUES ('" + CmbBankID.SelectedValue.ToString + "','" + TxtDebitedAmount.Text + "','" + TxtCreditedAmount.Text + "','" + TxtCheckNo.Text + "','" + TxtRemarks.Text + "','" + DtpTransactionDate.Value + "','" + currentTime + "','" + currentDate + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.lblBranchID.Text + "')"
                    cmd1.CommandText = "INSERT INTO [Log Details] ([Log Category],[Log Description],[User Account ID],[Log Date],[Log Time],[Task ID]) VALUES ('Bank Transaction','Data Inserted Successfully [" + CmbBankID.Text + "]','" + FrmHome.LblUserID.Text + "','" + currentDate + "','" + currentTime + "','New Data Inserted')"
                    cmd.ExecuteNonQuery()
                    cmd1.ExecuteNonQuery()





                    'Refresh Data
                    RefreshData()


                    'Insert Click Msg
                    MsgBox("Data Inserted Successfully", MsgBoxStyle.OkOnly, "Bank Transaction")
                    'Making Clear
                    ClearData()

                    'Focus on Bank ID text box
                    CmbBankID.Focus()



                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            con.Close()

        End Try



    End Sub
    Private Sub TxtAccountNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'Focus on Remarks
        If e.KeyCode = Keys.Enter Then
            Me.TxtRemarks.Focus()

        End If
    End Sub

    Private Sub TxtAccountNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtAmount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub TxtAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CmbSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbSearch.KeyDown
        'Focus on Search Combo Box
        If e.KeyCode = Keys.Enter Then
            Me.TxtSearch.Focus()

        End If
    End Sub

    'Creating Prive Sub For Refresh Data
    Sub RefreshData()

        ' Load Data
        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Bank Transaction].[Bank Transaction ID],[Bank Information].[Bank Name],[Bank Transaction].[Check No],[Bank Transaction].[Remarks],[Bank Transaction].[Transaction Date],[Bank Transaction].[Debited Amount],[Bank Transaction].[Credited Amount] From [Bank Transaction] Join [Bank Information] On [Bank Transaction].[Bank ID]=[Bank Information].[Bank ID]"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "Shonchoy_Bank Transaction")
            connection.Close()
            GrdBankTransaction.DataSource = ds
            GrdBankTransaction.DataMember = "Shonchoy_Bank Transaction"

            'GrdBankTransaction.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBankTransaction.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdBankTransaction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            con.Close()


            'Clear Data
            ClearData()

        Catch ex As Exception
            MessageBox.Show("Error while refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try
        'End Refresh Data


    End Sub

    'Creating Prive Sub For Refresh Data
    Sub SearchBankName()

        ' Load Data
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            If CmbSearch.SelectedIndex = 0 Then

                Dim connectionString As String = FrmHome.ConnectionString
                Dim sql As String = "SELECT [Bank Transaction].[Bank Transaction ID],[Bank Information].[Bank Name],[Bank Transaction].[Check No],[Bank Transaction].[Remarks],[Bank Transaction].[Transaction Date],[Bank Transaction].[Debited Amount],[Bank Transaction].[Credited Amount] From [Bank Transaction] Join [Bank Information] On [Bank Transaction].[Bank ID] = [Bank Information].[Bank ID] where [Bank Information].[Bank ID]= '" + CmbSearchBankName.SelectedValue.ToString + "'"
                Dim connection As New SqlConnection(connectionString)
                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "Shonchoy_Bank Transaction")
                connection.Close()
                GrdBankTransaction.DataSource = ds
                GrdBankTransaction.DataMember = "Shonchoy_Bank Transaction"

                'GrdBankTransaction.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdBankTransaction.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
                GrdBankTransaction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                con.Close()


            End If
        Catch ex As Exception
            MessageBox.Show("Error while refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try
        'End Refresh Data


    End Sub



    Sub SearchCheckNo()
        ' Load Data
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            If CmbSearch.SelectedIndex = 1 Then

                Dim connectionString As String = FrmHome.ConnectionString
                Dim sql As String = "SELECT [Bank Transaction].[Bank Transaction ID],[Bank Information].[Bank Name],[Bank Transaction].[Check No],[Bank Transaction].[Remarks],[Bank Transaction].[Transaction Date],[Bank Transaction].[Debited Amount],[Bank Transaction].[Credited Amount] From [Bank Transaction] Join [Bank Information] On [Bank Transaction].[Bank ID]=[Bank Information].[Bank ID]  where [Bank Transaction].[Check No]= '" + TxtCheckNo.Text + "'"
                Dim connection As New SqlConnection(connectionString)
                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "Shonchoy_Bank Transaction")
                connection.Close()
                GrdBankTransaction.DataSource = ds
                GrdBankTransaction.DataMember = "Shonchoy_Bank Transaction"

                'GrdBankTransaction.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdBankTransaction.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
                GrdBankTransaction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error while refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try
        'End Refresh Data


    End Sub
    Private Sub CmbSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSearch.SelectedIndexChanged


        If CmbSearch.Text = "BANK ID" Then
            CmbSearchBankName.Visible = True
            TxtSearch.Visible = False
            TxtSearch.Focus()

        ElseIf CmbSearch.Text = "CHECK NO" Then
            CmbSearchBankName.Visible = False
            TxtSearch.Visible = True
            TxtSearch.Focus()

        End If

    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click


        'Refreshing Data
        RefreshData()





    End Sub

    Private Sub GrpBankTransaction_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GrdBankTransaction_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdBankTransaction.CellContentClick

    End Sub

    Private Sub GrdBankTransaction_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdBankTransaction.CellMouseClick
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdBankTransaction.Rows(e.RowIndex)

                TxtBankTransactionID.Text = row.Cells("Bank Transaction ID").Value.ToString
                CmbBankID.Text = row.Cells("Bank Name").Value.ToString
                TxtDebitedAmount.Text = row.Cells("Debited Amount").Value.ToString
                TxtCreditedAmount.Text = row.Cells("Credited Amount").Value.ToString
                TxtCheckNo.Text = row.Cells("Check No").Value.ToString
                TxtRemarks.Text = row.Cells("Remarks").Value.ToString
                DtpTransactionDate.Text = row.Cells("Transaction Date").Value.ToString


                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim dr As SqlDataReader

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "SELECT  *FROM [Bank Transaction]  WHERE [Bank Transaction ID] = " + Me.TxtBankTransactionID.Text + ""


                dr = cmd.ExecuteReader()
                dr.Read()


                Me.CmbBankID.SelectedValue = (dr.Item("Bank ID").ToString)





                dr.Close()
                con.Close()

                'Enable Amount text boxes
                TxtCreditedAmount.Enabled = True
                TxtDebitedAmount.Enabled = True

            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview")

        End Try
    End Sub

    Private Sub TxtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then

            'Search
            SearchCheckNo()

        End If
        

    End Sub



    Private Sub TxtDebitedAmount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'Focus on Credited Amount
        If e.KeyCode = Keys.Enter Then
            Me.TxtCreditedAmount.Focus()

        End If
    End Sub

    Private Sub TxtDebitedAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtCreditedAmount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'Focus on Check No
        If e.KeyCode = Keys.Enter Then
            Me.TxtCheckNo.Focus()

        End If
    End Sub
    Private Sub TxtDebitedAmount_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'Focus on Credited Amount Text Box
        If e.KeyCode = Keys.Enter Then
            Me.CmbBankID.Focus()

        End If
    End Sub

    Private Sub TxtDebitedAmount_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtCreditedAmount_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'Focus on Check No Text Box
        If e.KeyCode = Keys.Enter Then
            Me.CmbBankID.Focus()

        End If
    End Sub

    Private Sub TxtCreditedAmount_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtCheckNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCheckNo.KeyDown
        'Focus on Transaction Date Text Box
        If e.KeyCode = Keys.Enter Then
            Me.TxtRemarks.Focus()

        End If
    End Sub
    Private Sub BtnCreditVoucher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCreditVoucher.Click


        CmbBankID.Focus()
        TxtDebitedAmount.Enabled = False
        TxtCreditedAmount.Enabled = True
        'Clear Data
        ClearAllData()

      
    End Sub

    Private Sub BtnDebitVoucher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDebitVoucher.Click

        CmbBankID.Focus()
        TxtCreditedAmount.Enabled = False
        TxtDebitedAmount.Enabled = True
        'Clear Data
        ClearAllData()

      
    End Sub

    Private Sub CmbBankID_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbBankID.KeyDown

    End Sub

    Private Sub CmbBankID_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbBankID.SelectedIndexChanged

    End Sub

    Private Sub CmbBankID_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbBankID.SelectedValueChanged
        If TxtCreditedAmount.Enabled = False Then

            TxtDebitedAmount.Focus()

        ElseIf TxtDebitedAmount.Enabled = False Then

            TxtCreditedAmount.Focus()
        End If
    End Sub

    Private Sub BtnSearch_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        'Search
        SearchBankName()
        SearchCheckNo()
    End Sub

    Private Sub CmbSearchBankName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbSearchBankName.KeyDown

    End Sub

    Private Sub CmbSearchBankName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSearchBankName.SelectedIndexChanged

    End Sub

    Private Sub CmbSearchBankName_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbSearchBankName.SelectedValueChanged
        'Search
        SearchBankName()
    End Sub

    Private Sub TxtWithdrawAmount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDebitedAmount.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtCheckNo.Focus()
        End If

    End Sub

    Private Sub TxtWithdrawAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDebitedAmount.TextChanged

    End Sub

    Private Sub TxtPaymentAmount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCreditedAmount.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtCheckNo.Focus()
        End If
    End Sub

    Private Sub TxtPaymentAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCreditedAmount.TextChanged

    End Sub

    Private Sub TxtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearch.TextChanged

    End Sub
End Class