Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class FrmUserAccount
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point
    Private Sub TxtAccountFullName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'Focus on Designation Text Box
        If e.KeyCode = Keys.Enter Then
            Me.TxtDesignation.Focus()

        End If
    End Sub

    Private Sub TxtAccountFullName_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub ClearData()
        'Making Clear
        Try
            TxtUserAccountID.Text = ""

            cmbBranchID.SelectedValue = 0
            CmbEmployeeID.SelectedValue = 0


            CmbEmployeeID.Text = ""
            TxtDesignation.Text = ""
            TxtUserName.Text = ""
            TxtPassword.Text = ""
            TxtStatus.Text = ""
            PtbUserImage.Image = Nothing



        Catch ex As Exception
            MessageBox.Show("Error while clearing data on table..." & ex.Message, "Clear Data")
        Finally

        End Try
    End Sub
    'Creating Privet Sub of Refreshing Data


    Sub RefreshData()

        ' Load Data
        Try

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [User Account].[User Account ID],[User Account].[User Name],[Branch Information].[Branch Name],[Employee Information].[Employee Name],[User Account].[Designation],[User Account].[Password],[User Account].[Status] From [User Account]join [Branch Information]on [User Account].[Branch ID]=[Branch Information].[Branch ID] join [Employee Information] on [User Account].[Employee ID]=[Employee Information].[Employee ID]"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_User Account")
            connection.Close()
            GrdUserAccount.DataSource = ds
            GrdUserAccount.DataMember = "BizPro_User Account"

            'GrdProductSubcategory.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductSubcategory.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdUserAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


            'Row Count
            NUmberOfRow()


        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try
        'End Refresh Data


    End Sub
    Private Sub GrpUserAccount_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrpUserAccount.Enter

    End Sub

    Private Sub FrmUserAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 0)
        Me.Size = My.Computer.Screen.WorkingArea.Size


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










        'Load Combobox
        LoadComboBoxBranch()

        'Load combobox employee
        LoadComboBoxEmployee()

        'Clear Data
        ClearData()

        'Change Language
        'ChangeLanguage()



    End Sub

    Sub LoadComboBoxBranch()

        Try


            Dim con1 As New SqlConnection
            Dim cmd1 As New SqlCommand
            con1.ConnectionString = FrmHome.ConnectionString

            Dim strSQL1 As String = "SELECT [Branch ID],[Branch Name] FROM [Branch Information]"
            Dim da1 As New System.Data.SqlClient.SqlDataAdapter(strSQL1, con1)
            Dim ds1 As New DataSet
            da1.Fill(ds1, "[Branch Information]")

            With Me.cmbBranchID
                .DataSource = ds1.Tables("[Branch Information]")
                .ValueMember = "Branch ID"
                .DisplayMember = "Branch Name"
            End With

            cmbBranchID.SelectedValue = 0

            con1.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub LoadComboBoxEmployee()

        Try


            Dim con1 As New SqlConnection
            Dim cmd1 As New SqlCommand
            con1.ConnectionString = FrmHome.ConnectionString

            Dim strSQL1 As String = "SELECT [Employee ID],[Employee Name] FROM [Employee Information]"
            Dim da1 As New System.Data.SqlClient.SqlDataAdapter(strSQL1, con1)
            Dim ds1 As New DataSet
            da1.Fill(ds1, "[Employee Information]")

            With Me.CmbEmployeeID
                .DataSource = ds1.Tables("[Employee Information]")
                .ValueMember = "Employee ID"
                .DisplayMember = "Employee Name"
            End With

            CmbEmployeeID.SelectedValue = 0
            con1.Close()

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
            If dr.HasRows Then

                Me.TxtUserAccountID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.cmbBranchID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.CmbEmployeeID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.CmbEmployeeID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtDesignation.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtUserName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtPassword.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtStatus.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))

                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

                Me.GrdUserAccount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdUserAccount.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)


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


    Private Sub BtnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click


        'Focus on Group Name
        Try
            TxtUserName.Focus()



            'Making Clear
            ClearData()

        Catch ex As Exception
            MessageBox.Show("Error while clearing data on table..." & ex.Message, "Clear Data")
        Finally

        End Try
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
            cmd.CommandText = "select top 1 * from [User Account] where [Log User account ID]='" + FrmHome.LblUserID.Text + "' and [Computer ID]='" + FrmHome.LblComputerID.Text + "'  order by [User Account ID] desc"
            dr = cmd.ExecuteReader
            dr.Read()

            If dr.HasRows Then

                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd1.CommandText = "INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID])VALUES('" + Me.Text + "','INSERT','User Account  ID: " + dr.Item("User Account ID").ToString + " , User Name: " + TxtUserName.Text + " , Branch ID: " + cmbBranchID.Text + ",  Employee Name: " + CmbEmployeeID.Text + " , Designation: " + TxtDesignation.Text + " , Password: " + TxtPassword.Text + " , Status: " + TxtStatus.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + dr.Item("User Account ID").ToString + "' )"
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
    Private Sub BtnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click



        'Data Insert Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now
        Try

            'Same ID twice insert restriction code
            If Not Me.TxtUserAccountID.Text = "" Then
                MsgBox("This ID is already Exist", MsgBoxStyle.OkOnly, "User Account")


            Else
                'Empty Txt Box Can Not Be Save Code
                If Me.cmbBranchID.SelectedValue = 0 Or Me.CmbEmployeeID.Text = "" Then
                    MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "User Account")

                Else
                    If GrdUserAccount.Rows.Count = 15 Then
                        MsgBox("You do not have permission to add more then 8 user.", MsgBoxStyle.Critical, "User Account")
                    Else




                        Dim con2 As New SqlConnection
                        Dim cmd2 As New SqlCommand
                        Dim dr2 As SqlDataReader

                        con2.ConnectionString = FrmHome.ConnectionString
                        con2.Open()
                        cmd2.Connection = con2
                        cmd2.CommandText = "SELECT * from [User Account]  WHERE [User Name] = '" + Me.TxtUserName.Text + "'"

                        dr2 = cmd2.ExecuteReader()
                        dr2.Read()

                        If dr2.HasRows Then

                            MsgBox("This user name is already exist", MsgBoxStyle.Critical, "User Account")
                            TxtUserName.Focus()

                        ElseIf Not dr2.HasRows Then




                            If Not Me.PtbUserImage.Image Is Nothing Then
                                con.ConnectionString = FrmHome.ConnectionString
                                con.Open()
                                cmd.Connection = con
                                cmd.CommandText = "INSERT INTO [User Account] ([User Name],[Branch ID],[Employee ID],[Designation],[Password],[Status],[User Image],[Log User Account ID],[Computer ID]) VALUES ('" + TxtUserName.Text + "','" + cmbBranchID.SelectedValue.ToString + "','" + CmbEmployeeID.SelectedValue.ToString + "','" + TxtDesignation.Text + "','" + TxtPassword.Text + "','" + TxtStatus.Text + "',@test,'" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "')"


                                Dim ms As New MemoryStream()
                                PtbUserImage.Image.Save(ms, PtbUserImage.Image.RawFormat)
                                Dim data As Byte() = ms.GetBuffer()
                                Dim p As New SqlParameter("@test", SqlDbType.Image)
                                p.Value = data
                                cmd.Parameters.Add(p)


                                cmd.ExecuteNonQuery()
                                con.Close()


                                'Insert into log 
                                InsertIntoLog()

                            ElseIf Me.PtbUserImage.Image Is Nothing Then

                                con.ConnectionString = FrmHome.ConnectionString
                                con.Open()
                                cmd.Connection = con
                                cmd.CommandText = "INSERT INTO [User Account] ([User Name],[Branch ID],[Employee ID],[Designation],[Password],[Status],[Log User Account ID],[Computer ID]) VALUES ('" + TxtUserName.Text + "','" + cmbBranchID.SelectedValue.ToString + "','" + CmbEmployeeID.SelectedValue.ToString + "','" + TxtDesignation.Text + "','" + TxtPassword.Text + "','" + TxtStatus.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "')"
                                cmd.ExecuteNonQuery()
                                con.Close()

                                'Insert into log 
                                InsertIntoLog()
                            End If



                            'Insert Click Msg
                            MsgBox("Data Inserted Successfully", MsgBoxStyle.OkOnly, "User Account")
                            'Making Clear
                            ClearData()



                            'Refresh Data
                            RefreshData()

                            'Focus on user name text box
                            TxtUserName.Focus()


                        End If
                        dr2.Close()
                        con2.Close()
                    End If
                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally


        End Try
    End Sub
    Sub NUmberOfRow()

        'Total gridview line show in label code
        Dim total As String = 0

        total = GrdUserAccount.Rows.Count

        Me.Label15.Text = total


    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        'Data Update Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now
        Try
            'Empty User Account ID Can Not Be Update
            If Me.TxtUserAccountID.Text = "" Then
                MsgBox("Please select a row", MsgBoxStyle.OkOnly, "User Account")

                'Empty Txt Box Can Not Be Save Code
            ElseIf Me.cmbBranchID.SelectedValue = 0 Or Me.cmbBranchID.Text = "" Or Me.TxtUserName.Text = "" Or Me.TxtPassword.Text = "" Then
                MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "User Account")


            Else


                Dim con2 As New SqlConnection
                Dim cmd2 As New SqlCommand
                Dim dr2 As SqlDataReader

                con2.ConnectionString = FrmHome.ConnectionString
                con2.Open()
                cmd2.Connection = con2
                cmd2.CommandText = "SELECT count ([User Name])[Total]  from [User Account] where [User Name] = '" + Me.TxtUserName.Text + "'"

                dr2 = cmd2.ExecuteReader()
                dr2.Read()

                If dr2.HasRows Then

                    If Val(dr2.Item("Total").ToString) = 1 Then

                        If Not Me.PtbUserImage.Image Is Nothing Then
                            con.ConnectionString = FrmHome.ConnectionString
                            con.Open()
                            cmd.Connection = con
                            cmd.CommandText = "UPDATE [User Account] SET [Branch ID]= '" + cmbBranchID.SelectedValue.ToString + "',[Employee ID]= '" + CmbEmployeeID.SelectedValue.ToString + "',[Designation]= '" + TxtDesignation.Text + "',[Password]= '" + TxtPassword.Text + "',[Status]= '" + TxtStatus.Text + "',[User Image]= @test WHERE [User Account ID]= '" + TxtUserAccountID.Text + "'  INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID])VALUES('" + Me.Text + "','UPDATE','User Account  ID: " + TxtUserAccountID.Text + " , User Name: " + TxtUserName.Text + " , Branch ID: " + cmbBranchID.Text + ",  Account Full Name: " + CmbEmployeeID.Text + " , Designation: " + TxtDesignation.Text + " , Password: " + TxtPassword.Text + " , Status: " + TxtStatus.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtUserAccountID.Text + "' )"


                            Dim ms As New MemoryStream()
                            PtbUserImage.Image.Save(ms, PtbUserImage.Image.RawFormat)
                            Dim data As Byte() = ms.GetBuffer()
                            Dim p As New SqlParameter("@test", SqlDbType.Image)
                            p.Value = data
                            cmd.Parameters.Add(p)


                            cmd.ExecuteNonQuery()
                            con.Close()




                        ElseIf Me.PtbUserImage.Image Is Nothing Then
                            con.ConnectionString = FrmHome.ConnectionString
                            con.Open()
                            cmd.Connection = con
                            cmd.CommandText = "UPDATE [User Account] SET [Branch ID]= '" + cmbBranchID.SelectedValue.ToString + "',[Employee ID]= '" + CmbEmployeeID.SelectedValue.ToString + "',[Designation]= '" + TxtDesignation.Text + "',[Password]= '" + TxtPassword.Text + "',[Status]= '" + TxtStatus.Text + "',[User Image]= '" + Nothing + "' WHERE [User Account ID]= '" + TxtUserAccountID.Text + "'  INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID])VALUES('" + Me.Text + "','UPDATE','User Account  ID: " + TxtUserAccountID.Text + " , User Name: " + TxtUserName.Text + " , Branch ID: " + cmbBranchID.Text + ",  Account Full Name: " + CmbEmployeeID.Text + " , Designation: " + TxtDesignation.Text + " , Password: " + TxtPassword.Text + " , Status: " + TxtStatus.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtUserAccountID.Text + "' )"

                            cmd.ExecuteNonQuery()
                            con.Close()

                        End If

                        MsgBox("This user name is already exist. Try different name.", MsgBoxStyle.Exclamation, "User Account")
                        TxtUserName.Focus()

                        'Refresh Data
                        RefreshData()

                    Else

                        If Not Me.PtbUserImage.Image Is Nothing Then
                            con.ConnectionString = FrmHome.ConnectionString
                            con.Open()
                            cmd.Connection = con
                            cmd.CommandText = "UPDATE [User Account] SET [User Name]= '" + TxtUserName.Text + "',[Branch ID]= '" + cmbBranchID.SelectedValue.ToString + "',[Employee ID]= '" + CmbEmployeeID.SelectedValue.ToString + "',[Designation]= '" + TxtDesignation.Text + "',[Password]= '" + TxtPassword.Text + "',[Status]= '" + TxtStatus.Text + "',[User Image]= @test WHERE [User Account ID]= '" + TxtUserAccountID.Text + "'  INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID])VALUES('" + Me.Text + "','UPDATE','User Account  ID: " + TxtUserAccountID.Text + " , User Name: " + TxtUserName.Text + " , Branch ID: " + cmbBranchID.Text + ",  Account Full Name: " + CmbEmployeeID.Text + " , Designation: " + TxtDesignation.Text + " , Password: " + TxtPassword.Text + " , Status: " + TxtStatus.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtUserAccountID.Text + "' )"


                            Dim ms As New MemoryStream()
                            PtbUserImage.Image.Save(ms, PtbUserImage.Image.RawFormat)
                            Dim data As Byte() = ms.GetBuffer()
                            Dim p As New SqlParameter("@test", SqlDbType.Image)
                            p.Value = data
                            cmd.Parameters.Add(p)


                            cmd.ExecuteNonQuery()
                            con.Close()


                        ElseIf Me.PtbUserImage.Image Is Nothing Then
                            con.ConnectionString = FrmHome.ConnectionString
                            con.Open()
                            cmd.Connection = con
                            cmd.CommandText = "UPDATE [User Account] SET [User Name]= '" + TxtUserName.Text + "',[Branch ID]= '" + cmbBranchID.SelectedValue.ToString + "',[Employee ID]= '" + CmbEmployeeID.SelectedValue.ToString + "',[Designation]= '" + TxtDesignation.Text + "',[Password]= '" + TxtPassword.Text + "',[Status]= '" + TxtStatus.Text + "',[User Image]= '" + Nothing + "' WHERE [User Account ID]= '" + TxtUserAccountID.Text + "'  INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID])VALUES('" + Me.Text + "','UPDATE','User Account  ID: " + TxtUserAccountID.Text + " , User Name: " + TxtUserName.Text + " , Branch ID: " + cmbBranchID.Text + ",  Account Full Name: " + CmbEmployeeID.Text + " , Designation: " + TxtDesignation.Text + " , Password: " + TxtPassword.Text + " , Status: " + TxtStatus.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtUserAccountID.Text + "' )"

                            cmd.ExecuteNonQuery()
                            con.Close()
                        End If

                        'Update Click Msg
                        MsgBox("Data Updated Successfully", MsgBoxStyle.OkOnly, "User Account")

                        'Making Clear
                        ClearData()

                        'Refresh Data
                        RefreshData()
                    End If
                End If
                dr2.Close()
                con2.Close()

            End If
        Catch ex As Exception
            MessageBox.Show("Error while Updating record on table..." & ex.Message, "Update Records")
        Finally

        End Try
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click

        'Empty User Account ID Can Not Be Update
        If Me.TxtUserAccountID.Text = "" Then
            MsgBox("Please select a row", MsgBoxStyle.OkOnly, "User Account")

        Else

            'Data Delete Code
            Dim q As MsgBoxResult
            q = MsgBox("Do you really want to Delete the row?", MsgBoxStyle.YesNo, "User Account")
            If q = MsgBoxResult.Yes Then

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim currentDate As DateTime = DateTime.Today
                Dim currentTime As DateTime = DateTime.Now
                Try
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "Delete from [User Account] where [User Account ID]= '" + TxtUserAccountID.Text + "'  INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID])VALUES('" + Me.Text + "','DELETE','User Account  ID: " + TxtUserAccountID.Text + " , User Name: " + TxtUserName.Text + " , Branch ID: " + cmbBranchID.Text + ",  Account Full Name: " + CmbEmployeeID.Text + " , Designation: " + TxtDesignation.Text + " , Password: " + TxtPassword.Text + " , Status: " + TxtStatus.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtUserAccountID.Text + "' )"
                    cmd.ExecuteNonQuery()
                    con.Close()
                    'Making Clear
                    ClearData()

                    'Refresh Data
                    RefreshData()

                Catch ex As Exception
                    MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Records")
                Finally

                End Try

            End If
        End If
    End Sub

    Private Sub GrdUserAccount_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdUserAccount_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

    End Sub

    Private Sub BtnRefrersh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefrersh.Click

        Try
            'Refresh Data
            RefreshData()



        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try

    End Sub

    Private Sub TxtBranchID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'Focus on Account Full Name Text Box
        If e.KeyCode = Keys.Enter Then
            Me.CmbEmployeeID.Focus()

        End If
    End Sub

    Private Sub TxtBranchID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtDesignation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDesignation.KeyDown
        'Focus on User Name Text Box
        If e.KeyCode = Keys.Enter Then
            Me.TxtPassword.Focus()

        End If
    End Sub

    Private Sub TxtDesignation_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDesignation.TextChanged

    End Sub

    Private Sub TxtUserName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtUserName.KeyDown
        'Focus on Password Text Box
        If e.KeyCode = Keys.Enter Then
            Me.cmbBranchID.Focus()

        End If
    End Sub

    Private Sub TxtUserName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtUserName.TextChanged

    End Sub

    Private Sub TxtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPassword.KeyDown
        'Focus on Status Text Box
        If e.KeyCode = Keys.Enter Then
            Me.TxtStatus.Focus()

        End If
    End Sub

    Private Sub TxtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPassword.TextChanged

    End Sub

    Private Sub CmbSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub CmbSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmbBranchID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbBranchID.KeyDown
        'Focus on Designation Text Box
        If e.KeyCode = Keys.Enter Then
            Me.CmbEmployeeID.Focus()

        End If


    End Sub

    Private Sub cmbBranchID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBranchID.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub TxtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click

    End Sub


    Private Sub BtnMemberRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        PtbUserImage.Image = Nothing
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

    Private Sub GrdUserAccount_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdUserAccount.CellContentClick

    End Sub

    Private Sub GrdUserAccount_CellMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdUserAccount.CellMouseClick
        'Data Grid view code
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdUserAccount.Rows(e.RowIndex)

                TxtUserAccountID.Text = row.Cells("User Account ID").Value.ToString
                TxtUserName.Text = row.Cells("User Name").Value.ToString
                cmbBranchID.Text = row.Cells("Branch Name").Value.ToString
                CmbEmployeeID.Text = row.Cells("Employee Name").Value.ToString
                TxtDesignation.Text = row.Cells("Designation").Value.ToString
                TxtPassword.Text = row.Cells("Password").Value.ToString
                TxtStatus.Text = row.Cells("Status").Value.ToString

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim dr As SqlDataReader

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "SELECT  *FROM [User Account]  WHERE [User Account ID] = " + Me.TxtUserAccountID.Text + ""


                dr = cmd.ExecuteReader()
                dr.Read()
                If dr.HasRows Then

                    Me.cmbBranchID.SelectedValue = (dr.Item("Branch ID").ToString)
                    PtbUserImage.Image = Nothing
                End If
                dr.Close()



                'Dr search For company Image
                cmd.CommandText = "SELECT  *FROM [User Account]  WHERE [User Account ID] = " + Me.TxtUserAccountID.Text + " AND [User Image] IS NOT NULL"


                dr = cmd.ExecuteReader()
                dr.Read()


                Try



                    If dr.HasRows Then

                        Dim data As Byte() = DirectCast(dr("User Image"), Byte())
                        Dim ms As New MemoryStream(data)
                        PtbUserImage.Image = Image.FromStream(ms)
                    End If
                Catch ex As Exception

                End Try

                dr.Close()
                con.Close()




            End If




        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

        End Try
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

    Private Sub CmbEmployeeName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbEmployeeID.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtDesignation.Focus()

        End If
    End Sub

    Private Sub CmbEmployeeName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbEmployeeID.SelectedIndexChanged

    End Sub

    Private Sub BtnChoose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnChoose.Click
        'Choose Button Code
        Try


            Dim Getimage As Integer
            OpenFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*"
            Getimage = OpenFileDialog1.ShowDialog()
            If Getimage = Windows.Forms.DialogResult.OK Then
                PtbUserImage.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If

        Catch ex As Exception
            MessageBox.Show("Error while Inserting Picture on table..." & ex.Message, "Insert Picture")
        Finally

        End Try
    End Sub
End Class