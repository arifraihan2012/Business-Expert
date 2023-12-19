Imports System.Data
Imports System.Data.SqlClient
Imports System.IO


Public Class FrmBankInformation
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point
    Dim ChartofAccountIDForUpdate As String

    Private Sub TxtBankDetails_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    'Creating Privet Sub of Clear Data
    Sub ClearData()
        Try

            TxtBankID.Text = ""
            TxtBankName.Text = ""
            TxtBranchName.Text = ""
            TxtAccountNo.Text = ""
            TxtBankMobileNo.Text = ""
            CmbAccountType.Text = ""
            TxtBankAddress.Text = ""
            TxtBankWebAddress.Text = ""
            TxtBankEmailAddress.Text = ""
            TxtRemarks.Text = ""
            TxtOpeningBalance.Text = ""
            DtpLedgerDate.Value = Now

        Catch ex As Exception
            MessageBox.Show("Error while clearing data on table..." & ex.Message, "Clear Data")
        Finally

        End Try



    End Sub
    'Creating Privet Sub for Refresh
    Sub RefreshData()

        ' Load Data
        Try
          
            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Bank ID],[Bank Name],[Branch Name],[Account No],[Mobile No],[Account Type],[Bank Address],[Bank Web Address],[Bank Email Address],[Remarks] FROM [Bank Information]"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Bank Information")
            connection.Close()
            GrdBankInformation.DataSource = ds
            GrdBankInformation.DataMember = "BizPro_Bank Information"

            'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdBankInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            
            'Total Bank ID
            NUmberOfRow()

        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try

        'End Refresh Data
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

            Me.TxtBankID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtBankName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtBranchName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtAccountNo.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtBankMobileNo.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.CmbAccountType.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtBankAddress.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtBankWebAddress.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtBankEmailAddress.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtRemarks.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtOpeningBalance.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))

            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            Me.GrdBankInformation.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.GrdBankInformation.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)


            'MsgBox(dr.Item("Language Font"))
            dr.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while changing language on table..." & ex.Message, "Change Language")
        Finally
        End Try

        'End Language

    End Sub
    'Find Chart of Account id

    Sub FindChartOfAccountId()

        Try

            'Data Insert Code
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT top 1 [Chart of Account ID] FROM [Chart of Account] where [User Account ID]='" + FrmHome.LblUserID.Text + "' and [Computer ID]='" + FrmHome.LblComputerID.Text + "' order by [Chart of Account ID] DESC"

            dr = cmd.ExecuteReader()
            dr.Read()

            ChartofAccountIDForUpdate = (dr.Item("Chart of Account ID").ToString)

            con.Close()
            dr.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    'Insert Opening Balance To Ledger
    Sub InsertOpeningBalanceToLedger()
        'Data Insert Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now

        Dim OpeningBalance As String
        OpeningBalance = Val(TxtOpeningBalance.Text) * -1

        Try
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd1.Connection = con

            cmd.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart of Account ID],[Invoice No],[Debited Amount],[Credited Amount],[Status],[Prepared Date],[Prepared Time],[User Account ID],[Computer ID],[Category Name],[Branch ID],[Description],[Voucher No]) VALUES ('" + DtpLedgerDate.Value + "','" + ChartofAccountIDForUpdate + "','OB','" + TxtOpeningBalance.Text + "','0','CASH','" + currentDate + "','" + currentTime + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','Opening Balance','" + FrmHome.lblBranchID.Text + "','Opening Balance','OB')"
            cmd1.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart of Account ID],[Invoice No],[Credited Amount],[Debited Amount],[Status],[Prepared Date],[Prepared Time],[User Account ID],[Computer ID],[Category Name],[Description],[Voucher No],[Branch ID]) VALUES ('" + DtpLedgerDate.Value + "','" + ChartofAccountIDForUpdate + "','OB','" + OpeningBalance + "','0','CASH','" + currentDate + "','" + currentTime + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','Opening Balance','Opening Balance','OB','" + FrmHome.lblBranchID.Text + "')"


            If Val(Me.TxtOpeningBalance.Text) > 0 Then
                cmd.ExecuteNonQuery()
            ElseIf Val(Me.TxtOpeningBalance.Text) < 0 Then
                cmd1.ExecuteNonQuery()
            End If


            con.Close()

            'Making Clear
            'ClearData()

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally


        End Try
    End Sub


    Private Sub FrmBankInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Location = New Point(0, 0)
        Me.Size = My.Computer.Screen.WorkingArea.Size




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
            End If



            dr.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while  permission delete to form..." & ex.Message, "Form Load")

        End Try





        'Change Language
        ChangeLanguage()

        DtpLedgerDate.Value = Now

    End Sub

    Private Sub GrpBankInfromation_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GrpBankInformation_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrpBankInformation.Enter

    End Sub

    Private Sub TxtBankName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBankName.KeyDown
        'Focus on Branch Name Text Box
        If e.KeyCode = Keys.Enter Then
            Me.TxtBranchName.Focus()

        End If
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBankName.TextChanged

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblBankName.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblBranchName.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblAccountNo.Click

    End Sub

    Private Sub BtnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click



        Try

            'Making Clear
            ClearData()

            'Focus on Bank Name
            Me.TxtBankName.Focus()
        Catch ex As Exception
            MessageBox.Show("Error while clearing data on table..." & ex.Message, "Add New Button")
        Finally

        End Try

    End Sub

    Sub NUmberOfRow()

        'Total gridview line show in label code
        Dim total As String = 0

        total = GrdBankInformation.Rows.Count

        Me.Label15.Text = total


    End Sub

    Private Sub BtnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInsert.Click

        'Data Insert Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now
        Try
            'Same id Twice insert restriction code
            If Not Me.TxtBankID.Text = "" Then
                MsgBox("This ID is already Exist.", MsgBoxStyle.OkOnly, "Bank Information")


            Else
                'Empty Txt Box Can Not Be Save Code
                If Me.TxtBankName.Text = "" Or Me.TxtAccountNo.Text = "" Then
                    MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Bank Information")

                Else

                    Dim con5 As New SqlConnection
                    Dim cmd7 As New SqlCommand
                    Dim cmd5 As New SqlCommand
                    Dim cmd6 As New SqlCommand
                    Dim dr5 As SqlDataReader
                    Dim dr6 As SqlDataReader

                    Dim HeadOfAccountID As String
                    Dim ChartOfAccountID As String



                    con5.ConnectionString = FrmHome.ConnectionString
                    con5.Open()
                    cmd5.Connection = con5
                    cmd6.Connection = con5
                    cmd7.Connection = con5
                    cmd5.CommandText = "select [Head Of Account ID] from [Head Of Account] where [Account Name]='CASH AND BANK'"
                    cmd6.CommandText = "SELECT top 1 [Chart of Account ID] FROM [Chart of Account] where [User Account ID]='" + FrmHome.LblUserID.Text + "' and [Computer ID]='" + FrmHome.LblComputerID.Text + "' order by [Chart of Account ID] DESC"

                    'Data reader find head of account then send it to insert chart of account as customer
                    dr5 = cmd5.ExecuteReader()
                    dr5.Read()
                    If dr5.HasRows Then
                        HeadOfAccountID = (dr5.Item("Head Of Account ID").ToString)
                    End If
                    dr5.Close()


                    cmd7.CommandText = "INSERT INTO [Chart Of Account] ([Head Of Account ID],[Account Name],[Prepared Time],[Prepared Date],[Computer ID],[User Account ID],[Transaction Limit]) VALUES ('" + HeadOfAccountID + "','" + TxtBankName.Text + "','" + currentTime + "','" + currentDate + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','00')"
                    cmd7.ExecuteNonQuery()

                    'Data reader find Chart of account then send it to insert  customer
                    dr6 = cmd6.ExecuteReader()
                    dr6.Read()
                    If dr6.HasRows Then
                        ChartOfAccountID = (dr6.Item("Chart Of Account ID").ToString)
                    End If
                    dr6.Close()

                    con5.Close()


                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO [Bank Information] ([Bank Name],[Branch Name],[Account No],[Mobile No],[Account Type],[Bank Address],[Bank Web Address],[Bank Email Address],[Remarks],[Chart of Account ID],[User Account ID],[Computer ID]) VALUES ('" + TxtBankName.Text + "','" + TxtBranchName.Text + "','" + TxtAccountNo.Text + "','" + TxtBankMobileNo.Text + "','" + CmbAccountType.Text + "','" + TxtBankAddress.Text + "','" + TxtBankWebAddress.Text + "','" + TxtBankEmailAddress.Text + "','" + TxtRemarks.Text + "','" + ChartOfAccountID + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "')"
                    cmd.ExecuteNonQuery()
                    con.Close()

                    'Find chart of account Id
                    FindChartOfAccountId()

                    'Insert Opening Balance To Ledger
                    InsertOpeningBalanceToLedger()

                    'Insert into log code
                    InsertIntoLog()

                    'Insert Click Msg
                    MsgBox("Data Inserted Successfully", MsgBoxStyle.OkOnly, "Bank Information")
                    'Making Clear
                    ClearData()



                    'Refresh Data
                    RefreshData()


                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally


        End Try
    End Sub

    'Insert into log code
    Sub InsertIntoLog()

        'Data Insert Code
        Dim con As New SqlConnection
        Dim con1 As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim dr As SqlDataReader
        Dim CurrentDate As DateTime = DateTime.Today
        Dim CurrentTime As DateTime = DateTime.Now

        Try
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "select top 1 * from [Bank Information] where [User account ID]='" + FrmHome.LblUserID.Text + "' and [Computer ID]='" + FrmHome.LblComputerID.Text + "'  order by [bank Id] desc"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then



                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd1.CommandText = "INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES ('" + Me.Text + "','INSERT','Bank ID: " + dr.Item("Bank ID").ToString + " , Bank Name: " + dr.Item("Bank Name").ToString + " , Branch Name: " + dr.Item("Branch Name").ToString + ",  Account No: " + dr.Item("Account No").ToString + " , Mobile No: " + dr.Item("Mobile No").ToString + " , Account Type: " + dr.Item("Account Type").ToString + " , Bank Address: " + dr.Item("Bank Address").ToString + " , Bank Web Address: " + dr.Item("Bank Web Address").ToString + " , Bank Email Adress: " + dr.Item("Bank Email Address").ToString + " , Remarks: " + dr.Item("Remarks").ToString + " , Chart of Account ID: " + dr.Item("Chart of Account ID").ToString + " ,User Account ID: " + dr.Item("User Account ID").ToString + " ,Computer ID: " + dr.Item("Computer ID").ToString + " ,Opening Balance: " + TxtOpeningBalance.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + dr.Item("Bank ID").ToString + "' )"
                cmd1.ExecuteNonQuery()
                con1.Close()

            End If
            dr.Close()
            con.Close()



        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally


        End Try
    End Sub
    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click

        'Data Update Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        Dim con2 As New SqlConnection
        Dim cmd2 As New SqlCommand
        Dim cmd3 As New SqlCommand
        Dim dr2 As SqlDataReader

        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now


        Dim OpeningBalance As String
        OpeningBalance = Val(TxtOpeningBalance.Text) * -1


        Try

            'Empty Bank ID Can Not Be Update
            If Me.TxtBankID.Text = "" Then
                MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Bank Information")


                'Empty Text Box Can Not Be update Code
            ElseIf Me.TxtBankName.Text = "" Or Me.TxtAccountNo.Text = "" Then
                MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Bank Information")


            Else
                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con

                cmd3.Connection = con
                cmd.CommandText = "UPDATE [Bank Information] SET [Bank Name]= '" + TxtBankName.Text + "', [Branch Name]= '" + TxtBranchName.Text + "',[Account No] = '" + TxtAccountNo.Text + "',[Mobile No]= '" + TxtBankMobileNo.Text + "',[Account Type]= '" + CmbAccountType.Text + "',[Bank Address]= '" + TxtBankAddress.Text + "',[Bank Web Address]= '" + TxtBankWebAddress.Text + "',[Bank Email Address]= '" + TxtBankEmailAddress.Text + "',[Remarks]= '" + TxtRemarks.Text + "'WHERE [Bank ID]= '" + TxtBankID.Text + "'  UPDATE [Chart of Account] SET [Account Name]= '" + TxtBankName.Text + "' Where [Chart of Account ID]='" + ChartofAccountIDForUpdate + "' INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES ('" + Me.Text + "','UPDATE','Bank ID: " + TxtBankID.Text + " , Bank Name: " + TxtBankName.Text + " , Branch Name: " + TxtBranchName.Text + ",  Account No: " + TxtAccountNo.Text + " , Mobile No: " + TxtBankMobileNo.Text + " , Account Type: " + CmbAccountType.Text + " , Bank Address: " + TxtBankAddress.Text + " , Bank Web Address: " + TxtBankWebAddress.Text + " , Bank Email Adress: " + TxtBankEmailAddress.Text + " , Remarks: " + TxtRemarks.Text + "  ,User Account ID: " + FrmHome.LblUserID.Text + " ,Computer ID: " + FrmHome.LblComputerID.Text + " ,Opening Balance: " + TxtOpeningBalance.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtBankID.Text + "' )"
                cmd3.CommandText = "SELECT  *FROM [Ledger]    WHERE [Chart Of Account ID] = '" + ChartofAccountIDForUpdate + "' And [Category Name]='Opening Balance' and [Branch ID] = '" + FrmHome.lblBranchID.Text + "'"
                cmd.ExecuteNonQuery()


                dr2 = cmd3.ExecuteReader
                dr2.Read()

                If Not dr2.HasRows Then

                    'Insert Opening Balance To Ledger
                    InsertOpeningBalanceToLedger()


                ElseIf dr2.HasRows Then


                    If Val(TxtOpeningBalance.Text) >= 0 Then

                        con2.ConnectionString = FrmHome.ConnectionString
                        con2.Open()
                        cmd2.Connection = con2
                        cmd2.CommandText = "UPDATE [Ledger] SET [Debited Amount]= '" + TxtOpeningBalance.Text + "',[Credited Amount]= '00',[Ledger Date]='" + DtpLedgerDate.Value + "' WHERE [Chart Of Account ID]= '" + ChartofAccountIDForUpdate + "' And [Category Name] = 'Opening Balance' and [Branch ID] = '" + FrmHome.lblBranchID.Text + "'"
                        cmd2.ExecuteNonQuery()
                        con2.Close()

                    ElseIf Val(TxtOpeningBalance.Text) < 0 Then


                        con2.ConnectionString = FrmHome.ConnectionString
                        con2.Open()
                        cmd2.Connection = con2
                        cmd2.CommandText = "UPDATE [Ledger] SET [Debited Amount]= '00',[Credited Amount]= '" + OpeningBalance + "',[Ledger Date]='" + DtpLedgerDate.Value + "' WHERE [Chart Of Account ID]= '" + ChartofAccountIDForUpdate + "' And [Category Name] = 'Opening Balance' and [Branch ID] = '" + FrmHome.lblBranchID.Text + "'"
                        cmd2.ExecuteNonQuery()
                        con2.Close()


                    End If
                   

                End If

                dr2.Close()
                con.Close()

                'Update Click Msg
                MsgBox("Data Updated Successfully", MsgBoxStyle.OkOnly, "Bank Information")

                'Making Clear
                ClearData()


                'Refresh Data
                RefreshData()

            End If

        Catch ex As Exception
            MessageBox.Show("Error while Updating record on table..." & ex.Message, "Update Records")
        Finally

        End Try

    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click

        'Empty Bank ID Can Not Be Delete
        If Me.TxtBankID.Text = "" Then
            MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Bank Information")

        Else

            'Data Delete Code
            Dim q As MsgBoxResult
            q = MsgBox("Do you really want to Delete the row?", MsgBoxStyle.YesNo, "Bank Information")
            If q = MsgBoxResult.Yes Then

                Dim con As New SqlConnection
                Dim con2 As New SqlConnection
                Dim cmd As New SqlCommand
                Dim cmd2 As New SqlCommand
                Dim cmd3 As New SqlCommand
                Dim Dr2 As SqlDataReader

                Dim currentDate As DateTime = DateTime.Today
                Dim currentTime As DateTime = DateTime.Now
                Try

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "Delete from [Bank Information] where [Bank ID]= '" + TxtBankID.Text + "'   Delete from [Chart of Account] where [Chart of Account ID]= '" + ChartofAccountIDForUpdate + "' INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES ('" + Me.Text + "','DELETE','Bank ID: " + TxtBankID.Text + " , Bank Name: " + TxtBankName.Text + " , Branch Name: " + TxtBranchName.Text + ",  Account No: " + TxtAccountNo.Text + " , Mobile No: " + TxtBankMobileNo.Text + " , Account Type: " + CmbAccountType.Text + " , Bank Address: " + TxtBankAddress.Text + " , Bank Web Address: " + TxtBankWebAddress.Text + " , Bank Email Adress: " + TxtBankEmailAddress.Text + " , Remarks: " + TxtRemarks.Text + "  ,User Account ID: " + FrmHome.LblUserID.Text + " ,Computer ID: " + FrmHome.LblComputerID.Text + " ,Opening Balance: " + TxtOpeningBalance.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtBankID.Text + "' )"
                    cmd.ExecuteNonQuery()



                    cmd2.Connection = con
                    cmd2.CommandText = "SELECT  *FROM [Ledger]    WHERE [Chart Of Account ID] = '" + ChartofAccountIDForUpdate + "' And [Category Name]='Opening Balance' and [Branch ID] = '" + FrmHome.lblBranchID.Text + "'"

                    'Execute Data Reder for Delete From ledger
                    Dr2 = cmd2.ExecuteReader()
                    Dr2.Read()

                    If Dr2.HasRows Then
                        con2.ConnectionString = FrmHome.ConnectionString
                        con2.Open()
                        cmd3.Connection = con2
                        cmd3.CommandText = " Delete from [Ledger]  WHERE [Chart Of Account ID] = '" + ChartofAccountIDForUpdate + "' And [Category Name]='Opening Balance' and [Branch ID] = '" + FrmHome.lblBranchID.Text + "'"
                        cmd3.ExecuteNonQuery()
                        con.Close()
                    End If

                    Dr2.Close()
                    con.Close()


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

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click

        Try
            'Refresh Data
            RefreshData()


        Catch ex As Exception
            MessageBox.Show("Error while refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try

    End Sub

    Private Sub GrdBankInformation_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdBankInformation_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

    End Sub

    Private Sub TxtBranchName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBranchName.KeyDown
        'Focus on Account No Text Box
        If e.KeyCode = Keys.Enter Then
            Me.TxtAccountNo.Focus()

        End If
    End Sub

    Private Sub TxtBranchName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBranchName.TextChanged

    End Sub

    Private Sub TxtAccountNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtAccountNo.KeyDown
        'Focus on Mobile NoText Box
        If e.KeyCode = Keys.Enter Then
            Me.TxtBankMobileNo.Focus()

        End If
    End Sub

    Private Sub TxtAccountNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtAccountNo.TextChanged

    End Sub

    Private Sub TxtMobileNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBankMobileNo.KeyDown
        'Focus on Account Type Text Box
        If e.KeyCode = Keys.Enter Then
            Me.CmbAccountType.Focus()

        End If
    End Sub

    Private Sub TxtMobileNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBankMobileNo.TextChanged

    End Sub

    Private Sub TxtAccountType_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'Focus on Bank Address Text Box
        If e.KeyCode = Keys.Enter Then
            Me.TxtBankAddress.Focus()

        End If
    End Sub

    Private Sub TxtAccountType_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtBankAddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBankAddress.KeyDown
        'Focus on Bank Web Address Text Box
        If e.KeyCode = Keys.Enter Then
            Me.TxtBankWebAddress.Focus()

        End If
    End Sub

    Private Sub TxtBankAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBankAddress.TextChanged

    End Sub

    Private Sub TxtBankWebAddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBankWebAddress.KeyDown
        'Focus on Bank Email Address Text Box
        If e.KeyCode = Keys.Enter Then
            Me.TxtBankEmailAddress.Focus()

        End If
    End Sub

    Private Sub TxtBankWebAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBankWebAddress.TextChanged

    End Sub

    Private Sub TxtBankEmailAddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBankEmailAddress.KeyDown
        'Focus on Remarks Text Box
        If e.KeyCode = Keys.Enter Then
            Me.TxtRemarks.Focus()

        End If
    End Sub

    Private Sub TxtBankEmailAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBankEmailAddress.TextChanged

    End Sub

    Private Sub CmbAccountTypeID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbAccountType.KeyDown
        'Focus on Bank Address Text Box
        If e.KeyCode = Keys.Enter Then
            Me.TxtBankAddress.Focus()

        End If
    End Sub





    Private Sub GrdBankInformation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)



    End Sub

    Private Sub LblBankAddress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblBankAddress.Click

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

    Private Sub GrdBankInformation_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdBankInformation.CellContentClick

    End Sub

    Private Sub GrdBankInformation_CellMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdBankInformation.CellMouseClick


        'Grid View Codes
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdBankInformation.Rows(e.RowIndex)

                TxtBankID.Text = row.Cells("Bank ID").Value.ToString
                TxtBankName.Text = row.Cells("Bank Name").Value.ToString
                TxtBranchName.Text = row.Cells("Branch Name").Value.ToString
                TxtAccountNo.Text = row.Cells("Account No").Value.ToString
                TxtBankMobileNo.Text = row.Cells("Mobile No").Value.ToString
                CmbAccountType.Text = row.Cells("Account Type").Value.ToString
                TxtBankAddress.Text = row.Cells("Bank Address").Value.ToString
                TxtBankWebAddress.Text = row.Cells("Bank Web Address").Value.ToString
                TxtBankEmailAddress.Text = row.Cells("Bank Email Address").Value.ToString
                TxtRemarks.Text = row.Cells("Remarks").Value.ToString


                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim dr As SqlDataReader

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "SELECT  *FROM [Bank Information]  WHERE [Bank ID] = " + Me.TxtBankID.Text + " "

                dr = cmd.ExecuteReader
                dr.Read()


                If dr.HasRows Then
                    ChartofAccountIDForUpdate = dr.Item("Chart of Account ID").ToString

                End If
                dr.Close()
                con.Close()


                Dim con1 As New SqlConnection
                Dim cmd1 As New SqlCommand
                Dim cmd2 As New SqlCommand
                Dim dr2 As SqlDataReader


                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd2.Connection = con1
                cmd2.CommandText = "SELECT  *FROM [Ledger]    WHERE [Chart Of Account ID] = '" + ChartofAccountIDForUpdate + "' And [Category Name]='Opening Balance' and [Branch ID] = '" + FrmHome.lblBranchID.Text + "'"


                dr2 = cmd2.ExecuteReader()
                dr2.Read()

                If dr2.HasRows Then

                    If Val(dr2.Item("Debited Amount").ToString) > 0 Then

                        TxtOpeningBalance.Text = Val(dr2.Item("Debited Amount").ToString)
                        DtpLedgerDate.Value = dr2.Item("Ledger Date").ToString
                    ElseIf Val(dr2.Item("Credited Amount").ToString) > 0 Then

                        TxtOpeningBalance.Text = Val(dr2.Item("Credited Amount").ToString) * -1
                        DtpLedgerDate.Value = dr2.Item("Ledger Date").ToString
                    End If

                ElseIf Not dr2.HasRows Then
                    TxtOpeningBalance.Text = ""
                End If
                dr2.Close()
                con.Close()
            End If






        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview")

        End Try
    End Sub

    Private Sub PnlBankInformation_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PnlBankInformation.Paint

    End Sub

    Private Sub Panel2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= (X)
            newpoint.Y -= (Y)
            Me.Location = newpoint

        End If
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub


End Class