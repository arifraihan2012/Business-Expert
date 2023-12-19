Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmChartofAccount
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point

    Private Sub BtnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click

        ClearAllData()
        CmbHeadofAccountID.Focus()

    End Sub
    Sub ClearData()

        TxtChartofAccountID.Text = ""
        'CmbHeadofAccountID.Text = ""
        TxtAccountName.Text = ""
        TxtOpeningBalance.Text = ""

    End Sub
    Sub ClearAllData()

        TxtChartofAccountID.Text = ""
        CmbHeadofAccountID.Text = ""
        TxtAccountName.Text = ""
        TxtOpeningBalance.Text = ""

    End Sub

    'Insert into log 
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
            cmd.CommandText = "select top 1 * from [Chart Of Account] where [User account ID]='" + FrmHome.LblUserID.Text + "' and [Computer ID]='" + FrmHome.LblComputerID.Text + "'  order by [Chart of Account Id] desc"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then



                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd1.CommandText = "INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID])VALUES('" + Me.Text + "','INSERT',   'Chart of Account ID : " + dr.Item("Chart of Account ID").ToString + " , HeadofAccountID : " + CmbHeadofAccountID.Text + " , Account Name : " + TxtAccountName.Text + ",  Opening Balance : " + TxtOpeningBalance.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + dr.Item("Chart of Account ID").ToString + "' )"
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

    Private Sub BtnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInsert.Click

        Try
            'Data Insert Code
            Dim con As New SqlConnection
            Dim con1 As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand
            Dim cmd2 As New SqlCommand
            Dim dr As SqlDataReader

            Dim CurrentDate As DateTime = DateTime.Today
            Dim CurrentTime As DateTime = DateTime.Now


            If Not TxtChartofAccountID.Text = "" Then
                MsgBox("This ID Is Already Exist", MsgBoxStyle.OkOnly, "Chart of Account")

            ElseIf CmbHeadofAccountID.Text = "" Or TxtAccountName.Text = "" Then
                MsgBox("Required Field Can Not Be Empty", MsgBoxStyle.OkOnly, "Chart of Account")

            Else


              

                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd1.CommandText = "Select * from [Chart of Account] where [Account Name]='" + TxtAccountName.Text + "' And [Head of Account ID]='" + CmbHeadofAccountID.SelectedValue.ToString + "'"

                dr = cmd1.ExecuteReader
                dr.Read()

                If Not dr.HasRows Then


                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd2.Connection = con
                    cmd.CommandText = "INSERT INTO [Chart of Account] ([Head of Account ID],[Account Name],[Prepared Date],[Prepared Time],[Computer ID],[User Account ID]) VALUES ('" + CmbHeadofAccountID.SelectedValue.ToString + "','" + TxtAccountName.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "') "
                    cmd2.CommandText = "INSERT INTO [Chart of Account] ([Head of Account ID],[Account Name],[Prepared Date],[Prepared Time],[Computer ID],[User Account ID],[Transaction Limit]) VALUES ('" + CmbHeadofAccountID.SelectedValue.ToString + "','" + TxtAccountName.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + TxtOpeningBalance.Text + "') "

                    'Insert Transaction Limit selection
                    If CmbHeadofAccountID.Text = "CASH AND BANK" Then
                        cmd.ExecuteNonQuery()
                    Else
                        cmd2.ExecuteNonQuery()

                    End If
                    con.Close()

                    'Insert Opening Balance Code
                    If CmbHeadofAccountID.Text = "CASH AND BANK" Then
                        'Find chart of account Id
                        FindChartOfAccountId()

                        'Insert Opening Balance To Ledger
                        InsertOpeningBalanceToLedger()

                    End If


                    'Insert into log 
                    InsertIntoLog()


                    'Insert Click Msg
                    MsgBox("Data Inserted Successfully", MsgBoxStyle.OkOnly, "Chart of Account")

                    'Making Clear
                    ClearData()

                    'Refreshdata
                    Refreshdata()

                Else
                    MsgBox("This account name is already exist.", MsgBoxStyle.Critical, "Chart of Account")
                End If

                dr.Close()

            End If

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally

        End Try

        CmbHeadofAccountID.Focus()

    End Sub
    'LoadCombobox Head of account
    Sub LoadComboboxHeadOfAccount()
        Try


            Dim con1 As New SqlConnection
            Dim cmd1 As New SqlCommand
            con1.ConnectionString = FrmHome.ConnectionString

            Dim strSQL1 As String = "SELECT [Head of Account ID],[Account Name] FROM [Head of Account]"
            Dim da1 As New System.Data.SqlClient.SqlDataAdapter(strSQL1, con1)
            Dim ds1 As New DataSet
            da1.Fill(ds1, "[Head of Account]")

            With Me.CmbHeadofAccountID
                .DataSource = ds1.Tables("[Head of Account]")
                .ValueMember = "Head of Account ID"
                .DisplayMember = "Account Name"
            End With
            con1.Close()


            CmbHeadofAccountID.SelectedValue = 0

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

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

            TxtChartofAccountID.Text = (dr.Item("Chart of Account ID").ToString)

            dr.Close()
            con.Close()

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

            cmd.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart of Account ID],[Invoice No],[Debited Amount],[Credited Amount],[Status],[Prepared Date],[Prepared Time],[User Account ID],[Computer ID],[Category Name],[Branch ID],[Description],[Voucher No]) VALUES ('" + currentDate + "','" + TxtChartofAccountID.Text + "','OB','" + TxtOpeningBalance.Text + "','0','CASH','" + currentDate + "','" + currentTime + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','Opening Balance','" + FrmHome.lblBranchID.Text + "','Opening Balance','OB')"
            cmd1.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart of Account ID],[Invoice No],[Credited Amount],[Debited Amount],[Status],[Prepared Date],[Prepared Time],[User Account ID],[Computer ID],[Category Name],[Description],[Voucher No],[Branch ID]) VALUES ('" + currentDate + "','" + TxtChartofAccountID.Text + "','OB','" + OpeningBalance + "','0','CASH','" + currentDate + "','" + currentTime + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','Opening Balance','Opening Balance','OB','" + FrmHome.lblBranchID.Text + "')"


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


                Me.TxtChartofAccountID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtAccountName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtOpeningBalance.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))

                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)


                Me.GrdChartofAccount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdChartofAccount.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)


                'MsgBox(dr.Item("Language Font"))
            End If

            dr.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while changing language on table..." & ex.Message, "Change Language")
        Finally

        End Try

        'End Language

    End Sub
    'Refresh Data
    Sub Refreshdata()

        Try

            ' Load Data
           

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "Select [Chart of Account].[Chart of Account ID],[Head of Account].[Account Name][Head of Account Name],[Chart of Account].[Account Name][Chart of Account Name],[Chart of Account].[Transaction Limit] from  [Chart of Account] join [Head Of Account]  on [Chart of Account].[Head of Account ID]=[Head Of Account].[Head of Account ID] where not [Head of Account].[Account Name]='Supplier and customer' "
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Chart of Account")
            connection.Close()
            GrdChartofAccount.DataSource = ds
            GrdChartofAccount.DataMember = "BizPro_Chart of Account"

            GrdChartofAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill





            'End Refresh Data
        Catch ex As Exception
            MessageBox.Show("Error while refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try

        CmbHeadofAccountID.Focus()

    End Sub

    'Search all Chart of account by head of account
    Sub SearchChartofAccountByHead()

        Try


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "Select [Chart of Account].[Chart of Account ID],[Head of Account].[Account Name][Head of Account Name],[Chart of Account].[Account Name][Chart of Account Name],[Chart of Account].[Transaction Limit] from  [Chart of Account] join [Head Of Account]  on [Chart of Account].[Head of Account ID]=[Head Of Account].[Head of Account ID] where [Chart of Account].[Head of Account ID] = '" + CmbHeadofAccountID.SelectedValue.ToString + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Chart of Account")
            connection.Close()
            GrdChartofAccount.DataSource = ds
            GrdChartofAccount.DataMember = "BizPro_Chart of Account"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdChartofAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub


    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click

        Refreshdata()

    End Sub

    Private Sub GrdChartofAccount_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)






    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click

        Try

            'Data Delete Code
            Dim con As New SqlConnection
            Dim con2 As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd2 As New SqlCommand
            Dim cmd3 As New SqlCommand
            Dim dr2 As SqlDataReader

            Dim CurrentDate As DateTime = DateTime.Today
            Dim CurrentTime As DateTime = DateTime.Now


            If TxtChartofAccountID.Text = "" Then
                MsgBox("Please Select A Row First", MsgBoxStyle.OkOnly, "Chart of Account")
            Else

                Dim q As MsgBoxResult
                q = MsgBox("Do you really want to Delete the row?", MsgBoxStyle.YesNo, "Chart of Account")
                If q = MsgBoxResult.Yes Then


                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = " Delete from [Chart of Account]  where [Chart of Account ID]='" + TxtChartofAccountID.Text + "'    INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID])VALUES('" + Me.Text + "','DELETE',   'Chart of Account ID : " + TxtChartofAccountID.Text + " , HeadofAccountID : " + CmbHeadofAccountID.Text + " , Account Name : " + TxtAccountName.Text + ",  Opening Balance : " + TxtOpeningBalance.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtChartofAccountID.Text + "' )"
                    cmd.ExecuteNonQuery()

                    cmd2.Connection = con
                    cmd2.CommandText = "SELECT  *FROM [Ledger]    WHERE [Chart Of Account ID] = '" + TxtChartofAccountID.Text + "' And [Category Name]='Opening Balance' and [Branch ID] = '" + FrmHome.lblBranchID.Text + "'"

                    'Execute Data Reder for Delete From ledger
                    dr2 = cmd2.ExecuteReader()
                    dr2.Read()

                    If dr2.HasRows Then
                        con2.ConnectionString = FrmHome.ConnectionString
                        con2.Open()
                        cmd3.Connection = con2
                        cmd3.CommandText = " Delete from [Ledger]  WHERE [Chart Of Account ID] = '" + TxtChartofAccountID.Text + "' And [Category Name]='Opening Balance' and [Branch ID] = '" + FrmHome.lblBranchID.Text + "'"
                        cmd3.ExecuteNonQuery()
                        con.Close()
                    End If

                    dr2.Close()
                    con.Close()

                    'Making Clear
                    ClearAllData()

                    'Refreshdata
                    Refreshdata()

                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally

        End Try

        CmbHeadofAccountID.Focus()

    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click

        Try
            'Data Update Code
            Dim con As New SqlConnection
            Dim con2 As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand
            Dim cmd3 As New SqlCommand
            Dim cmd6 As New SqlCommand
            Dim cmd2 As New SqlCommand
            Dim dr2 As SqlDataReader

            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now

            Dim OpeningBalance As String
            OpeningBalance = Val(TxtOpeningBalance.Text) * -1

            If TxtChartofAccountID.Text = "" Then
                MsgBox("Please Select A Row First", MsgBoxStyle.OkOnly, "Chart of Account")

            ElseIf CmbHeadofAccountID.Text = "" Or TxtAccountName.Text = "" Then
                MsgBox("Required Field Can Not Be Empty", MsgBoxStyle.OkOnly, "Chart of Account")
            Else

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd3.Connection = con
                cmd2.Connection = con
                cmd.CommandText = " Update [Chart of Account] set  [Head of Account ID]='" + CmbHeadofAccountID.SelectedValue.ToString + "',[Account Name]='" + TxtAccountName.Text + "',[Computer ID]='" + FrmHome.LblComputerID.Text + "',[User Account ID]='" + FrmHome.LblUserID.Text + "' where [Chart of Account ID]='" + TxtChartofAccountID.Text + "'    INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID])VALUES('" + Me.Text + "','UPDATE',   'Chart of Account ID : " + TxtChartofAccountID.Text + " , HeadofAccountID : " + CmbHeadofAccountID.Text + " , Account Name : " + TxtAccountName.Text + ",  Opening Balance : " + TxtOpeningBalance.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtChartofAccountID.Text + "' )"
                cmd2.CommandText = " Update [Chart of Account] set  [Head of Account ID]='" + CmbHeadofAccountID.SelectedValue.ToString + "',[Account Name]='" + TxtAccountName.Text + "',[Computer ID]='" + FrmHome.LblComputerID.Text + "',[User Account ID]='" + FrmHome.LblUserID.Text + "',[Transaction Limit]='" + TxtOpeningBalance.Text + "' where [Chart of Account ID]='" + TxtChartofAccountID.Text + "'       INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID])VALUES('" + Me.Text + "','UPDATE',   'Chart of Account ID : " + TxtChartofAccountID.Text + " , HeadofAccountID : " + CmbHeadofAccountID.Text + " , Account Name : " + TxtAccountName.Text + ",  Opening Balance : " + TxtOpeningBalance.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtChartofAccountID.Text + "' )"
                cmd3.CommandText = "SELECT  *FROM [Ledger]    WHERE [Chart Of Account ID] = '" + TxtChartofAccountID.Text + "' And [Category Name]='Opening Balance' and [Branch ID] = '" + FrmHome.lblBranchID.Text + "'"

                'Update Transaction Limit selection
                If CmbHeadofAccountID.Text = "CASH AND BANK" Then
                    cmd.ExecuteNonQuery()
                Else
                    cmd2.ExecuteNonQuery()
                End If



                If CmbHeadofAccountID.Text = "CASH AND BANK" Then

                    dr2 = cmd3.ExecuteReader
                    dr2.Read()

                    If Not dr2.HasRows Then

                        'Insert Opening Balance To Ledger
                        InsertOpeningBalanceToLedger()


                    ElseIf dr2.HasRows Then


                        If Val(TxtOpeningBalance.Text) >= 0 Then

                            con2.ConnectionString = FrmHome.ConnectionString
                            con2.Open()
                            cmd1.Connection = con2
                            cmd1.CommandText = "UPDATE [Ledger] SET [Debited Amount]= '" + TxtOpeningBalance.Text + "',[Credited Amount]= '0' WHERE [Chart Of Account ID]= '" + TxtChartofAccountID.Text + "' And [Category Name] = 'Opening Balance' and [Branch ID] = '" + FrmHome.lblBranchID.Text + "'"
                            cmd1.ExecuteNonQuery()
                            con2.Close()

                        ElseIf Val(TxtOpeningBalance.Text) < 0 Then


                            con2.ConnectionString = FrmHome.ConnectionString
                            con2.Open()
                            cmd1.Connection = con2
                            cmd1.CommandText = "UPDATE [Ledger] SET [Debited Amount]= '00',[Credited Amount]= '" + OpeningBalance + "' WHERE [Chart Of Account ID]= '" + TxtChartofAccountID.Text + "' And [Category Name] = 'Opening Balance' and [Branch ID] = '" + FrmHome.lblBranchID.Text + "'"
                            cmd1.ExecuteNonQuery()
                            con2.Close()


                        End If
                        dr2.Close()
                    End If



                End If


                con.Close()

                'Update Click Msg
                MsgBox("Data Updated Successfully", MsgBoxStyle.OkOnly, "Chart of Account")

                'Making Clear
                ClearAllData()

                'Refreshdata
                Refreshdata()

            End If


        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally

        End Try

        CmbHeadofAccountID.Focus()

    End Sub

    Private Sub CmbHeadofAccountID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbHeadofAccountID.KeyDown

        If e.KeyCode = Keys.Enter Then
            'Search all Chart of account by head of account
            SearchChartofAccountByHead()

            TxtAccountName.Focus()


        End If

    End Sub

    Private Sub TxtAccountName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtAccountName.KeyDown

        If e.KeyCode = Keys.Enter Then
            TxtOpeningBalance.Focus()

        End If

    End Sub




    Private Sub FrmChartofAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



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

            End If


            dr.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while  permission delete to form..." & ex.Message, "Form Load")

        End Try
        'Change Langeuge Privet Sub
        ChangeLanguage()

        'LoadCombobox Head of account
        LoadComboboxHeadOfAccount()


    End Sub


    Private Sub CmbHeadofAccountID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbHeadofAccountID.SelectedIndexChanged



        If Me.CmbHeadofAccountID.Text = "CASH AND BANK" Then

            Me.LblOpeningBalance.Text = "Opening Balance :"
        Else
            Me.LblOpeningBalance.Text = "Transaction Limit :"

        End If
    End Sub

    Private Sub GrdChartofAccount_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)




    End Sub

    Private Sub TxtAccountName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtAccountName.TextChanged
        'Auto Capital Word
        TxtAccountName.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub Btnminimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnminimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Btnmaximized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnmaximized.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal

        Else
            Me.Location = New Point(0, 0)
            Me.Size = My.Computer.Screen.WorkingArea.Size

        End If
    End Sub

    Private Sub Btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnclose.Click
        Me.Close()
    End Sub

    Private Sub GrdChartofAccount_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdChartofAccount.CellContentClick

    End Sub

    Private Sub GrdChartofAccount_CellMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdChartofAccount.CellMouseClick
        'Data Grid view code
        Try




            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdChartofAccount.Rows(e.RowIndex)

                TxtChartofAccountID.Text = row.Cells("Chart of Account ID").Value.ToString
                CmbHeadofAccountID.Text = row.Cells("Head of Account Name").Value.ToString
                TxtAccountName.Text = row.Cells("Chart of Account Name").Value.ToString
                TxtOpeningBalance.Text = row.Cells("Transaction Limit").Value.ToString





                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim cmd2 As New SqlCommand
                Dim dr2 As SqlDataReader


                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd2.Connection = con
                cmd2.CommandText = "SELECT  *FROM [Ledger]    WHERE [Chart Of Account ID] = '" + TxtChartofAccountID.Text + "' And [Category Name]='Opening Balance' and [Branch ID] = '" + FrmHome.lblBranchID.Text + "'"

                If CmbHeadofAccountID.Text = "CASH AND BANK" Then
                    dr2 = cmd2.ExecuteReader()
                    dr2.Read()

                    If dr2.HasRows Then

                        If Val(dr2.Item("Debited Amount").ToString) > 0 Then

                            TxtOpeningBalance.Text = Val(dr2.Item("Debited Amount").ToString)
                        ElseIf Val(dr2.Item("Credited Amount").ToString) > 0 Then

                            TxtOpeningBalance.Text = Val(dr2.Item("Credited Amount").ToString) * -1
                        End If

                    ElseIf Not dr2.HasRows Then
                        TxtOpeningBalance.Text = ""
                    End If
                    dr2.Close()
                    con.Close()
                End If




            End If



        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

        End Try
    End Sub

    Private Sub GrpChartofAccount_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrpChartofAccount.Enter

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
