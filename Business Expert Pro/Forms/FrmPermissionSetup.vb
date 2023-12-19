Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class FrmPermissionSetup
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point
    Private Sub GrpPermissionSetup_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrpPermissionSetup.Enter

    End Sub
    

    'Crating Privet Sub for Clear Data
    Sub ClearData()
        Try
            TxtPermissionID.Text = ""

            CmbUserAccountID.Text = ""
            CmbUserAccountID.SelectedValue = 0

            CmbCategoryName.SelectedIndex = -1
            CmbCategoryName.Text = ""


            CmbUpdateDeletePermission.SelectedIndex = -1
            CmbUpdateDeletePermission.Text = ""


            TxtSearch.Text = ""


        Catch ex As Exception
            MessageBox.Show("Error while Clearing record on table..." & ex.Message, "Clear Records Sub")
        Finally

        End Try

    End Sub
    Sub LoadComboBoxUserAccount()
        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            con.ConnectionString = FrmHome.ConnectionString

            Dim strSQL As String = "Select * from [User Account]"
            Dim da As New System.Data.SqlClient.SqlDataAdapter(strSQL, con)
            Dim ds As New DataSet
            da.Fill(ds, "[User Account]")

            With Me.CmbUserAccountID
                .DataSource = ds.Tables("[User Account]")
                .ValueMember = "User Account ID"
                .DisplayMember = "User Name"
            End With
            con.Close()
            CmbUserAccountID.SelectedValue = 0


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub LoadComboBoxAllPermissionName()
        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            con.ConnectionString = FrmHome.ConnectionString

            Dim strSQL As String = "Select * from [All Permission]"
            Dim da As New System.Data.SqlClient.SqlDataAdapter(strSQL, con)
            Dim ds As New DataSet
            da.Fill(ds, "[All Permission]")

            With Me.CmbCategoryName
                .DataSource = ds.Tables("[All Permission]")
                .ValueMember = "Permission ID"
                .DisplayMember = "Name"
            End With
            con.Close()
            CmbCategoryName.SelectedValue = 0


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub FrmPermissionSetup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
                BtnDeleteAll.Enabled = True
                BtnUpdate.Enabled = True

            ElseIf Not dr.HasRows Then
                BtnDeleteAll.Enabled = False
                BtnUpdate.Enabled = False


            End If


            dr.Close()
            con.Close()

            'CmbUserAccountID.Text = "Press [Enter] Key"


            'Load Combobox
            LoadComboBoxUserAccount()
            'Focus on user account ID combo box
            Me.CmbUserAccountID.Focus()

            'Load Combo Box All PermissionName
            LoadComboBoxAllPermissionName()

        Catch ex As Exception
            MessageBox.Show("Error while changing language on table..." & ex.Message, "Form Load")
        Finally

        End Try

    End Sub
    Sub TotalpermittedSector()
        Dim total As String = 0

        total = GrdPermissionSetup.Rows.Count

        Me.LblTotalAmount.Text = total



    End Sub
    'Crating Privet Sub for Clear Data
    Sub ClearDataForADD()
        Try
            TxtPermissionID.Text = ""



            CmbCategoryName.Text = ""




        Catch ex As Exception
            MessageBox.Show("Error while Clearing record on table..." & ex.Message, "Clear Records Sub")
        Finally

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


                Me.TxtPermissionID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.CmbUserAccountID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                'Me.CmbCategoryName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                'Me.CmbUpdateDeletePermission.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtSearch.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))



                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

                Me.GrdPermissionSetup.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdPermissionSetup.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)


                'MsgBox(dr.Item("Language Font"))
            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while changing language on table..." & ex.Message, "Sub Change Language")
        Finally
            con.Close()
        End Try

        'End Language

    End Sub

    'Crating Privet Sub for Clear Data
    Sub RefreshData()

        ' Load Data
        Try
             

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Permission Setup].[Permission ID],[User Account].[User Name],[Permission Setup].[Category Name],[Permission Setup].[Update Delete Permission] From [Permission Setup] Join [User Account] On [Permission Setup].[User Account ID]=[User Account].[User Account ID]"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Permission Setup")
            connection.Close()
            GrdPermissionSetup.DataSource = ds
            GrdPermissionSetup.DataMember = "BizPro_Permission Setup"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdPermissionSetup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            'Number of row
            TotalpermittedSector()






        Catch ex As Exception
            MessageBox.Show("Error while refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try
        'End Refresh Data

    End Sub
    'Crating Privet Sub for Clear Data
    Sub RefreshDataIndividualUser()

        ' Load Data
        Try
         
            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Permission Setup].[Permission ID],[User Account].[User Name],[Permission Setup].[Category Name],[Permission Setup].[Update Delete Permission] From [Permission Setup] Join [User Account] On [Permission Setup].[User Account ID]=[User Account].[User Account ID] Where [User Account].[User Account ID]='" + CmbUserAccountID.SelectedValue.ToString + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Permission Setup")
            connection.Close()
            GrdPermissionSetup.DataSource = ds
            GrdPermissionSetup.DataMember = "BizPro_Permission Setup"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdPermissionSetup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            'Number of row
            TotalpermittedSector()






        Catch ex As Exception
            MessageBox.Show("Error while refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try
        'End Refresh Data

    End Sub

    Private Sub BtnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click

        'Focus on Group Name
        Try
            CmbUserAccountID.Focus()



            'Making Clear
            ClearData()

            'auto select update delete permisssion 'NO'
            CmbUpdateDeletePermission.SelectedIndex = 1


        Catch ex As Exception
            MessageBox.Show("Error while Clearing record on table..." & ex.Message, "Button Add New")
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
            cmd.CommandText = "select top 1 * from [Permission Setup] where [Log User account ID]='" + FrmHome.LblUserID.Text + "' and [Computer ID]='" + FrmHome.LblComputerID.Text + "'  order by [Permission ID] desc"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then



                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd1.CommandText = "INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID])VALUES('" + Me.Text + "','INSERT','Permission ID: " + dr.Item("Permission ID").ToString + " , User Account ID: " + CmbUserAccountID.Text + " , Category Name: " + CmbCategoryName.Text + ", Update/Delete Permission: " + CmbUpdateDeletePermission.Text + " ','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + dr.Item("Permission ID").ToString + "' )"
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

        Try
            'Same ID twice insert restriction code
            If Not Me.TxtPermissionID.Text = "" Then
                MsgBox("This ID is already Exist", MsgBoxStyle.OkOnly, "Permission Setup")


            Else

                Dim con2 As New SqlConnection
                Dim cmd2 As New SqlCommand
                Dim dr2 As SqlDataReader

                con2.ConnectionString = FrmHome.ConnectionString
                con2.Open()
                cmd2.Connection = con2
                cmd2.CommandText = "SELECT * from [Permission Setup]  WHERE [User Account ID] = '" + Me.CmbUserAccountID.SelectedValue.ToString + "' and [Category Name]=  '" + Me.CmbCategoryName.Text + "'"

                dr2 = cmd2.ExecuteReader()
                dr2.Read()

                If dr2.HasRows Then

                    MsgBox("This form to this user is already permitted", MsgBoxStyle.Critical, "Permission Setup")
                    CmbCategoryName.Focus()

                ElseIf Not dr2.HasRows Then






                    'Data Insert Code
                    Dim con As New SqlConnection
                    Dim cmd As New SqlCommand
                    Dim currentDate As DateTime = DateTime.Today
                    Dim currentTime As DateTime = DateTime.Now




                    'Emty Txt Box Can Not Be Save Code
                    If Me.CmbUserAccountID.SelectedValue = 0 Then
                        MsgBox("Required Field can not be empty")

                    Else
                        con.ConnectionString = FrmHome.ConnectionString
                        con.Open()
                        cmd.Connection = con
                        cmd.CommandText = "INSERT INTO [Permission Setup] ([User Account ID],[Category Name],[Update Delete Permission],[Log User Account ID],[Computer ID]) VALUES ('" + CmbUserAccountID.SelectedValue.ToString + "','" + CmbCategoryName.Text + "','" + CmbUpdateDeletePermission.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "')"
                        cmd.ExecuteNonQuery()
                        con.Close()

                        'Insert into log 
                        InsertIntoLog()

                        'Making Clear
                        ClearDataForADD()


                        'add Click Msg
                        MsgBox("Permitted", MsgBoxStyle.OkOnly, "Permission Setup")

                        'Crating Privet Sub for Clear Data
                        RefreshDataIndividualUser()


                        'Focus on User Account ID combo box
                        CmbCategoryName.Focus()
                    End If

                End If

                dr2.Close()
                con2.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally


        End Try
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click


        Try

            'Empty Bank ID Can Not Be Delete
            If Me.TxtPermissionID.Text = "" Then
                MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Permission Setup")

                'Emty Txt Box Can Not Be Save Code
            ElseIf Me.CmbUserAccountID.SelectedValue = 0 Then
                MsgBox("Required Field can not be empty")

            Else


                Dim con2 As New SqlConnection
                Dim cmd2 As New SqlCommand
                Dim dr2 As SqlDataReader

                con2.ConnectionString = FrmHome.ConnectionString
                con2.Open()
                cmd2.Connection = con2
                cmd2.CommandText = "SELECT * from [Permission Setup]  WHERE [User Account ID] = '" + Me.CmbUserAccountID.SelectedValue.ToString + "' and [Category Name]=  '" + Me.CmbCategoryName.Text + "' and [Update Delete Permission]=  '" + Me.CmbUpdateDeletePermission.Text + "'  "

                dr2 = cmd2.ExecuteReader()
                dr2.Read()

                If dr2.HasRows Then

                    MsgBox("This form to this user is already permitted", MsgBoxStyle.Critical, "Permission Setup")
                    CmbCategoryName.Focus()

                ElseIf Not dr2.HasRows Then






                    'Data Update Code
                    Dim con As New SqlConnection
                    Dim cmd As New SqlCommand
                    Dim currentDate As DateTime = DateTime.Today
                    Dim currentTime As DateTime = DateTime.Now



                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "UPDATE [Permission Setup] SET [User Account ID]= '" + CmbUserAccountID.SelectedValue.ToString + "',[Category Name]= '" + CmbCategoryName.Text + "',[Update Delete Permission]= '" + CmbUpdateDeletePermission.Text + "' WHERE [Permission ID]= '" + TxtPermissionID.Text + "'  Delete from [Permission Setup] where [Permission ID]= '" + TxtPermissionID.Text + "'  INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID])VALUES('" + Me.Text + "','UPDATE','Permission ID: " + TxtPermissionID.Text + " , User Account ID: " + CmbUserAccountID.Text + " , Category Name: " + CmbCategoryName.Text + ", Update/Delete Permission: " + CmbUpdateDeletePermission.Text + " ','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtPermissionID.Text + "' )"



                    cmd.ExecuteNonQuery()
                    con.Close()

                    'Update Click Msg
                    MsgBox("Data Updated Successfully", MsgBoxStyle.OkOnly, "Permission Setup")

                    'Making Clear
                    ClearDataForADD()


                    'Crating Privet Sub for Clear Data
                    RefreshDataIndividualUser()

                End If

                dr2.Close()
                con2.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Error while Updating record on table..." & ex.Message, "Update Records")
        Finally

        End Try
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteAll.Click

        'Empty Bank ID Can Not Be Delete
        If CmbUserAccountID.Text = "" Then
            MsgBox("Please select a user", MsgBoxStyle.OkOnly, "Permission Setup")

        Else



            'Data Delete Code
            Dim q As MsgBoxResult
            q = MsgBox("Do you really want to delete all permission for this user?", MsgBoxStyle.YesNo, "Permission Setup")
            If q = MsgBoxResult.Yes Then

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim currentDate As DateTime = DateTime.Today
                Dim currentTime As DateTime = DateTime.Now
                Try
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "Delete from [Permission Setup] where [User Account ID]= '" + CmbUserAccountID.SelectedValue.ToString + "' INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID])VALUES('" + Me.Text + "','DELETE','All Permission Deleted','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtPermissionID.Text + "' )"
                    cmd.ExecuteNonQuery()
                    con.Close()
                    'Crating Privet Sub for Clear Data
                    ClearDataForADD()

                    'Crating Privet Sub for Clear Data
                    RefreshDataIndividualUser()

                Catch ex As Exception
                    MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Records")
                Finally

                End Try


            End If
        End If
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click

        Try

            If CmbUserAccountID.Text = "" Then
                'Refresh Data
                RefreshData()

            Else

                'Crating Privet Sub for Clear Data
                RefreshDataIndividualUser()
            End If

            'Focus on user account id
            CmbUserAccountID.Focus()

        Catch ex As Exception
            MessageBox.Show("Error while refreshing record on table..." & ex.Message, "Refresh Button")
        Finally

        End Try

    End Sub

    Private Sub GrdPermissionSetup_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdPermissionSetup_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

    End Sub

    Private Sub CmbUserAccountID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbUserAccountID.KeyDown
        'Focus on Category Name Text Box

        If e.KeyCode = Keys.Enter Then

            CmbCategoryName.Focus()

        End If
    End Sub

    Private Sub CmbUserAccountID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbUserAccountID.KeyPress


    End Sub

    Private Sub CmbUserAccountID_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbUserAccountID.KeyUp

    End Sub

    Private Sub CmbUserAccountID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbUserAccountID.SelectedIndexChanged

    End Sub

    Private Sub CmbCategoryName_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbCategoryName.Click

    End Sub

    Private Sub CmbCategoryName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbCategoryName.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.CmbUpdateDeletePermission.Focus()
        End If
    End Sub

    Private Sub CmbCategoryName_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CmbCategoryName.MouseClick

    End Sub

    Private Sub CmbCategoryName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCategoryName.SelectedIndexChanged

    End Sub

    Private Sub CmbPermissionStatus_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub CmbPermissionStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click

        'search
        search()

    End Sub


    Private Sub TxtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CmbSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSearchCmb.SelectedIndexChanged

        If CmbSearchCmb.SelectedIndex = 0 Then
            TxtSearch.Visible = True
            Me.TxtSearch.Focus()

        End If



    End Sub

    Private Sub cmbSearchID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)


    End Sub


    'Sub search
    Sub search()

        Try

            'Search by name

             



            If Me.CmbSearchCmb.SelectedIndex = 0 Then

                Dim connectionString As String = FrmHome.ConnectionString
                Dim sql As String = "SELECT [Permission Setup].[Permission ID],[User Account].[User Name],[Permission Setup].[Category Name],[Permission Setup].[Update Delete Permission] From [Permission Setup] Join [User Account] On [Permission Setup].[User Account ID]=[User Account].[User Account ID] WHERE ([Permission Setup].[Category Name] Like '%" + Me.TxtSearch.Text + "%')"

                Dim connection As New SqlConnection(connectionString)

                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Permission Setup")
                connection.Close()
                GrdPermissionSetup.DataSource = ds
                GrdPermissionSetup.DataMember = "BizPro_Permission Setup"


                GrdPermissionSetup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                'Number of row
                'TotalpermittedSector()



            End If

        Catch ex As Exception

            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records On Data Gridview")
        End Try






    End Sub

    Private Sub cmbSearchID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CmbUpdateDeletePermission_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbUpdateDeletePermission.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnSave.PerformClick()
        End If
    End Sub

    Private Sub CmbUpdateDeletePermission_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbUpdateDeletePermission.SelectedIndexChanged

    End Sub

    Private Sub TxtSearch_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearch.TextChanged

        'search
        search()



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

    Private Sub GrdPermissionSetup_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdPermissionSetup.CellContentClick

    End Sub

    Private Sub GrdPermissionSetup_CellMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdPermissionSetup.CellMouseClick

        'Data Grid view code
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdPermissionSetup.Rows(e.RowIndex)

                TxtPermissionID.Text = row.Cells("Permission ID").Value.ToString
                CmbUserAccountID.Text = row.Cells("User Name").Value.ToString
                CmbCategoryName.Text = row.Cells("Category Name").Value.ToString
                CmbUpdateDeletePermission.Text = row.Cells("Update Delete Permission").Value.ToString
                CmbUserAccountID.Text = row.Cells("User Name").Value.ToString





            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records On Data Gridview")

        End Try
    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        'If e.Button = Windows.Forms.MouseButtons.Left Then
        'newpoint = Control.MousePosition
        ' newpoint.X -= (X)
        ' newpoint.Y -= (Y)
        ' Me.Location = newpoint

        '  End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BtnAllPermission_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAllPermission.Click
        Try

            Dim q As MsgBoxResult
            q = MsgBox("Are you sure want to allow this user for all permission", MsgBoxStyle.YesNo)

            If q = MsgBoxResult.Yes Then


                'Same ID twice insert restriction code
                If Not Me.TxtPermissionID.Text = "" Then
                    MsgBox("This ID is already Exist", MsgBoxStyle.OkOnly, "Permission Setup")


                Else




                    'Data Insert Code
                    Dim con As New SqlConnection
                    Dim cmd As New SqlCommand
                    Dim currentDate As DateTime = DateTime.Today
                    Dim currentTime As DateTime = DateTime.Now




                    'Emty Txt Box Can Not Be Save Code
                    If Me.CmbUserAccountID.SelectedValue = 0 Then
                        MsgBox("Required Field can not be empty")

                    Else
                        con.ConnectionString = FrmHome.ConnectionString
                        con.Open()
                        cmd.Connection = con
                        cmd.CommandText = "INSERT INTO [Permission Setup] ([User Account ID],[Category Name],[Update Delete Permission])(select '" + CmbUserAccountID.SelectedValue.ToString + "',[name],'yes'from [all permission])   INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID])VALUES('" + Me.Text + "','INSERT','All Permission given to the user ','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtPermissionID.Text + "' )"
                        cmd.ExecuteNonQuery()
                        con.Close()
                        'Making Clear
                        ClearDataForADD()


                        'add Click Msg
                        MsgBox("Permitted", MsgBoxStyle.OkOnly, "Permission Setup")

                        'Crating Privet Sub for Clear Data
                        RefreshDataIndividualUser()


                        'Focus on User Account ID combo box
                        CmbCategoryName.Focus()
                    End If


                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally


        End Try
    End Sub

    Private Sub GrdPermissionSetup_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdPermissionSetup.CellMouseDoubleClick

        'Data Grid view code
        Try



            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdPermissionSetup.Rows(e.RowIndex)



                'Empty Bank ID Can Not Be Delete
                If Me.TxtPermissionID.Text = "" Then
                    MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Permission Setup")

                Else



                    'Data Delete Code
                    Dim q As MsgBoxResult
                    q = MsgBox("Do you really want to Delete the row?", MsgBoxStyle.YesNo, "Permission Setup")
                    If q = MsgBoxResult.Yes Then

                        Dim con As New SqlConnection
                        Dim cmd As New SqlCommand
                        Dim currentDate As DateTime = DateTime.Today
                        Dim currentTime As DateTime = DateTime.Now
                        Try
                            con.ConnectionString = FrmHome.ConnectionString
                            con.Open()
                            cmd.Connection = con
                            cmd.CommandText = "Delete from [Permission Setup] where [Permission ID]= '" + TxtPermissionID.Text + "'  INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID])VALUES('" + Me.Text + "','DELETE','Permission ID: " + TxtPermissionID.Text + " , User Account ID: " + CmbUserAccountID.Text + " , Category Name: " + CmbCategoryName.Text + ", Update/Delete Permission: " + CmbUpdateDeletePermission.Text + " ','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtPermissionID.Text + "' )"
                            cmd.ExecuteNonQuery()
                            con.Close()
                            'Crating Privet Sub for Clear Data
                            ClearDataForADD()

                            'Crating Privet Sub for Clear Data
                            RefreshDataIndividualUser()

                        Catch ex As Exception
                            MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Records")
                        Finally

                        End Try


                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class