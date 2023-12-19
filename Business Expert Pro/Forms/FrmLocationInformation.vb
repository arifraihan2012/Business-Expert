Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class FrmLocationInformation
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point

    Private Sub TxtComputerID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtLocationID.TextChanged

    End Sub
    'Private sub For Clear Data
    Sub ClearData()
        Try
            TxtLocationID.Text = ""




            TxtLocationName.Text = ""
            TxtLocationDetails.Text = ""



        Catch ex As Exception
            MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Show Records")
        Finally

        End Try
    End Sub

    'Private sub For Clear Data
    Sub ClearDataAll()
        Try
            TxtLocationID.Text = ""

            CmbBranchID.SelectedValue = 0
            CmbSearchBranch.SelectedValue = 0


            TxtLocationName.Text = ""
            TxtLocationDetails.Text = ""
            CmbSearch.Text = ""
            TxtSearch.Text = ""
        Catch ex As Exception
            MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Show Records")
        Finally

        End Try
    End Sub


    'Refresh Data Privet Sub
    Sub RefreshData()
        Try
            ' Load Data
           

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Location Information].[Location ID],[Branch Information].[Branch Name],[Location Information].[Location Name],[Location Information].[Location Details] FROM [Location Information] Join [Branch Information] on [Location Information].[Branch ID]=[Branch Information].[Branch ID]"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Location Information")
            connection.Close()
            GrdLocationInformation.DataSource = ds
            GrdLocationInformation.DataMember = "BizPro_Location Information"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdLocationInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


            'End Refresh Data


            'Row Count
            NUmberOfRow()

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally

        End Try

    End Sub
    Private Sub TxtMacAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtLocationDetails_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtLocationDetails.KeyDown

        If e.KeyCode = Keys.Enter Then

            BtnInsert.PerformClick()

        End If

    End Sub
    Private Sub TxtComputerLocation_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtLocationDetails.TextChanged



    End Sub

    Private Sub TxtLocationName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtLocationName.KeyDown
        'Focus On Location Details text box
        If e.KeyCode = Keys.Enter Then
            Me.TxtLocationDetails.Focus()

        End If
    End Sub
    Private Sub TxtComputerName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtLocationName.TextChanged

    End Sub

    Private Sub BtnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click
        Try

            'Focus on Group Name
            CmbBranchID.Focus()



            'Making Clear
            ClearDataAll()

        Catch ex As Exception
            MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Show Records")
        Finally

        End Try
    End Sub

    Private Sub BtnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInsert.Click

        Try
            'Same id Twice insert restriction code
            If Not Me.TxtLocationID.Text = "" Then
                MsgBox("This ID is already Exist.", MsgBoxStyle.OkOnly, "Location Information")



            Else


                Dim con2 As New SqlConnection
                Dim cmd2 As New SqlCommand
                Dim dr2 As SqlDataReader

                con2.ConnectionString = FrmHome.ConnectionString
                con2.Open()
                cmd2.Connection = con2
                cmd2.CommandText = "SELECT * from [Location Information]  WHERE [Location Name] = '" + Me.TxtLocationName.Text + "' and [Branch ID]=  '" + Me.CmbBranchID.SelectedValue.ToString + "'"

                dr2 = cmd2.ExecuteReader()
                dr2.Read()

                If dr2.HasRows Then

                    MsgBox("This Location Name In This Branch Is Already Exist", MsgBoxStyle.Critical, "Location Information")
                    TxtLocationName.Focus()

                ElseIf Not dr2.HasRows Then






                    'Data Insert Code
                    Dim con As New SqlConnection
                    Dim cmd As New SqlCommand
                    Dim currentDate As DateTime = DateTime.Today
                    Dim currentTime As DateTime = DateTime.Now



                    'Empty Txt Box Can Not Be Save Code
                    If Me.TxtLocationName.Text = "" Or Me.CmbBranchID.SelectedValue = 0 Then
                        MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Location Information")

                    Else
                        con.ConnectionString = FrmHome.ConnectionString
                        con.Open()
                        cmd.Connection = con
                        cmd.CommandText = "INSERT INTO [Location Information] ([Branch ID],[Location Name],[Location Details],[Prepared Time],[Prepared Date],[Computer ID],[User Account ID]) VALUES ('" + CmbBranchID.SelectedValue.ToString + "','" + TxtLocationName.Text + "','" + TxtLocationDetails.Text + "','" + currentTime + "','" + currentDate + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "')"
                        cmd.ExecuteNonQuery()

                        'Insert Click Msg
                        MsgBox("Data Inserted Successfully", MsgBoxStyle.OkOnly, "Location Information")
                        'Making Clear
                        ClearData()


                        'Refresh Data
                        RefreshData()


                        'Location Name textbox focus
                        TxtLocationName.Focus()


                    End If
                    dr2.Close()
                    con.Close()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally


        End Try
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click

        Try

            'Empty Location Information Can Not Be Update
            If Me.TxtLocationID.Text = "" Then
                MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Location Information")

                'Empty Text Box Can Not Be update Code
            ElseIf Me.TxtLocationName.Text = "" Or Me.CmbBranchID.SelectedValue = 0 Then
                MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Location Information")


            Else



                Dim con2 As New SqlConnection
                Dim cmd2 As New SqlCommand
                Dim dr2 As SqlDataReader

                con2.ConnectionString = FrmHome.ConnectionString
                con2.Open()
                cmd2.Connection = con2
                cmd2.CommandText = "SELECT * from [Location Information]  WHERE [Location Name] = '" + Me.TxtLocationName.Text + "' and [Branch ID]=  '" + Me.CmbBranchID.SelectedValue.ToString + "'"

                dr2 = cmd2.ExecuteReader()
                dr2.Read()

                If dr2.HasRows Then

                    MsgBox("This Location Name In This Branch Is Already Exist", MsgBoxStyle.Critical, "Location Information")
                    TxtLocationName.Focus()

                ElseIf Not dr2.HasRows Then




                    'Data Update Code
                    Dim con As New SqlConnection
                    Dim cmd As New SqlCommand
                    Dim currentDate As DateTime = DateTime.Today
                    Dim currentTime As DateTime = DateTime.Now






                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "UPDATE [Location Information] SET [Branch ID]= '" + CmbBranchID.SelectedValue.ToString + "',[Location Name]= '" + TxtLocationName.Text + "',[Location Details]= '" + TxtLocationDetails.Text + "',[Computer ID]= '" + FrmHome.LblComputerID.Text + "',[User Account ID]='" + FrmHome.LblUserID.Text + "' WHERE [Location ID]= '" + TxtLocationID.Text + "'"
                    cmd.ExecuteNonQuery()
                    con.Close()


                    'Update Click Msg
                    MsgBox("Data Updated Successfully", MsgBoxStyle.OkOnly, "Location Information")

                    'Making Clear
                    ClearDataAll()


                    'Refresh Data
                    RefreshData()


                    'Focus on Branch combobox
                    CmbBranchID.Focus()

                   

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
        'Empty Location Information Can Not Be Delete
        If Me.TxtLocationID.Text = "" Then
            MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Location Information")

        Else
            'Data Delete Code
            Dim q As MsgBoxResult
            q = MsgBox("Do you really want to Delete the row?", MsgBoxStyle.YesNo, "Location Information")
            If q = MsgBoxResult.Yes Then

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand

                Try
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "Delete from [Location Information] where [Location ID]= '" + TxtLocationID.Text + "'"
                    cmd.ExecuteNonQuery()
                    con.Close()


                    'Making Clear
                    ClearDataAll()



                    'Refresh Data
                    RefreshData()

                    'Focus on Branch combobox
                    CmbBranchID.Focus()


                Catch ex As Exception
                    MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Records")
                Finally
                End Try
            End If

        End If
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        'Refresh Data
        Try
            RefreshData()

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records")
        Finally

        End Try

    End Sub

    Private Sub GrdLocationInformation_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdLocationInformation_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

    End Sub

    Private Sub FrmLocationInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

       



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




        'Change Language
        ChangeLanguage()

        'Load Combobox
        loadComboBox()

        'Clear data
        ClearDataAll()

    End Sub



    'Private Sub For Lode Combo box
    Sub loadComboBox()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = FrmHome.ConnectionString

        Dim strSQL As String = "SELECT [Branch ID],[Branch Name] FROM [Branch Information]"
        Dim da As New System.Data.SqlClient.SqlDataAdapter(strSQL, con)
        Dim ds As New DataSet
        da.Fill(ds, "[Branch Information]")

        With Me.CmbBranchID
            .DataSource = ds.Tables("[Branch Information]")
            .ValueMember = "Branch ID"
            .DisplayMember = "Branch Name"




        End With
        con.Close()

        Dim con2 As New SqlConnection
        Dim cmd2 As New SqlCommand
        con2.ConnectionString = FrmHome.ConnectionString

        Dim strSQL2 As String = "SELECT [Branch ID],[Branch Name] FROM [Branch Information]"
        Dim da2 As New System.Data.SqlClient.SqlDataAdapter(strSQL2, con2)
        Dim ds2 As New DataSet
        da2.Fill(ds2, "[Branch Information]")

        With Me.CmbSearchBranch
            .DataSource = ds2.Tables("[Branch Information]")
            .DisplayMember = "Branch Name"
            .ValueMember = "Branch ID"

        End With
        con.Close()
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


                Me.TxtSearch.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtLocationID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.CmbBranchID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtLocationName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtLocationDetails.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtSearch.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.CmbSearchBranch.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))

                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)


                Me.GrdLocationInformation.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdLocationInformation.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)


                'MsgBox(dr.Item("Language Font"))
            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally

        End Try

        'End Language

    End Sub

    Private Sub CmbBranchID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbBranchID.KeyDown
        'Focus On Location Name text box
        If e.KeyCode = Keys.Enter Then
            Me.TxtLocationName.Focus()

        End If

    End Sub

    Private Sub CmbBranchID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbBranchID.SelectedIndexChanged

    End Sub

    Private Sub CmbSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbSearch.KeyDown
        'Focus On Search  text box
        If e.KeyCode = Keys.Enter Then
            Me.TxtSearch.Focus()

        End If
    End Sub

    Private Sub CmbSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSearch.SelectedIndexChanged

        'True false search text box and combobox

        If CmbSearch.SelectedIndex = 0 Then

            TxtSearch.Visible = True
            CmbSearchBranch.Visible = False
            TxtSearch.Focus()

        ElseIf CmbSearch.SelectedIndex = 1 Then
            CmbSearchBranch.Visible = True
            TxtSearch.Visible = False
            CmbSearchBranch.Focus()

        End If

    End Sub

    Private Sub GrpLocationInfromation_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrpLocationInfromation.Enter

    End Sub

    Private Sub TxtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearch.KeyDown

    End Sub

    Private Sub TxtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearch.TextChanged
        'Search
        search()
    End Sub
    'Search code
    Sub search()

        Try



            'Search Code
            ' Load Data
           
            Dim connectionString As String = FrmHome.ConnectionString
            If Me.CmbSearch.SelectedIndex = 0 Then
                Dim sql As String = "SELECT [Location Information].[Location ID],[Branch Information].[Branch Name],[Location Information].[Location Name],[Location Information].[Location Details] FROM [Location Information] Join [Branch Information] on [Location Information].[Branch ID]=[Branch Information].[Branch ID] WHERE ([Location Information].[Location Name] Like '%" + Me.TxtSearch.Text + "%')"

                Dim connection As New SqlConnection(connectionString)

                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Location Information")
                connection.Close()
                GrdLocationInformation.DataSource = ds
                GrdLocationInformation.DataMember = "BizPro_Location Information"
                GrdLocationInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                'Row Count
                NUmberOfRow()



            ElseIf Me.CmbSearch.SelectedIndex = 1 Then


                Dim sql As String = "SELECT [Location Information].[Location ID],[Branch Information].[Branch Name],[Location Information].[Location Name],[Location Information].[Location Details] FROM [Location Information] Join [Branch Information] on [Location Information].[Branch ID]=[Branch Information].[Branch ID] WHERE ([Branch Information].[Branch ID] = '" + Me.CmbSearchBranch.SelectedValue.ToString + "')"

                Dim connection As New SqlConnection(connectionString)

                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Location Information")
                connection.Close()
                GrdLocationInformation.DataSource = ds
                GrdLocationInformation.DataMember = "BizPro_Location Information"
                GrdLocationInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                'Row Count
                NUmberOfRow()





            End If







        Catch ex As Exception
            MessageBox.Show("Error while searching records on table..." & ex.Message, "Search Records")
        Finally

        End Try


    End Sub
    Sub NUmberOfRow()

        'Total gridview line show in label code
        Dim total As String = 0

        total = GrdLocationInformation.Rows.Count

        Me.lblTotalLocation.Text = total


    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click

        'Search
        search()

    End Sub

    Private Sub CmbSearchBranch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSearchBranch.SelectedIndexChanged

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

    Private Sub GrdLocationInformation_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdLocationInformation.CellContentClick

    End Sub

    Private Sub GrdLocationInformation_CellMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdLocationInformation.CellMouseClick
        'Data Grid view code
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdLocationInformation.Rows(e.RowIndex)

                TxtLocationID.Text = row.Cells("Location ID").Value.ToString
                TxtLocationName.Text = row.Cells("Location Name").Value.ToString
                TxtLocationDetails.Text = row.Cells("Location Details").Value.ToString
                CmbBranchID.Text = row.Cells("Branch Name").Value.ToString

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim dr As SqlDataReader

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "SELECT  *FROM [Location Information]  WHERE [Location ID] = " + Me.TxtLocationID.Text + ""


                dr = cmd.ExecuteReader()
                dr.Read()
                If dr.HasRows Then
                    Me.CmbBranchID.SelectedValue = (dr.Item("Branch ID").ToString)
                End If
                dr.Close()
                con.Close()

            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

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