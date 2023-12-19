Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmUnitInformation
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point

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

                Me.TxtUntID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtUnitName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))


                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

                Me.GrdProductGroup.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)


                'MsgBox(dr.Item("Language Font"))

            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            con.Close()
        End Try

        'End Language

    End Sub

    Private Sub FrmProductGroup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        

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


    End Sub
    'Crating Privet Sub for Clear Data
    Sub ClearData()
        Try
            TxtUntID.Text = ""
            TxtUnitName.Text = ""

        Catch ex As Exception
            MessageBox.Show("Error while clearing record on table..." & ex.Message, "Clear Records")
        Finally

        End Try
    End Sub
    'Creating Privet Sub of Refreshing Data
    Sub RefreshData()

        ' Load Data
        Try
             

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Unit Information].[Unit ID],[Unit Information].[Unit Name] FROM [Unit Information]"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Unit Information")
            connection.Close()
            GrdProductGroup.DataSource = ds
            GrdProductGroup.DataMember = "BizPro_Unit Information"



            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdProductGroup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try
        'End Refresh Data

    End Sub
    Private Sub BtnAddNew_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click
        Try
            'Focus on Group Name
            TxtUnitName.Focus()

            'Making Clear
            ClearData()

        Catch ex As Exception
            MessageBox.Show("Error while adding data on table..." & ex.Message, "Add New Button")
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
            cmd.CommandText = "select top 1 * from [Unit Information] where [User account ID]='" + FrmHome.LblUserID.Text + "' and [Computer ID]='" + FrmHome.LblComputerID.Text + "'  order by [Unit ID] desc"
            dr = cmd.ExecuteReader
            dr.Read()

            If dr.HasRows Then

                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd1.CommandText = "INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID])VALUES('" + Me.Text + "','INSERT','Unit ID: " + dr.Item("Unit ID").ToString + " , Unit Name: " + TxtUnitName.Text + "' ,'" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + dr.Item("Unit ID").ToString + "' )"
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

    Private Sub BtnInsert_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInsert.Click


        Try


            'Same id Twice insert restriction code
            If Not Me.TxtUntID.Text = "" Then
                MsgBox("This ID is already Exist.", MsgBoxStyle.OkOnly, "Unit Information")


            Else


                Dim con2 As New SqlConnection
                Dim cmd2 As New SqlCommand
                Dim dr2 As SqlDataReader

                Dim Currentdate As DateTime = DateTime.Today
                Dim Currenttime As DateTime = DateTime.Now


                con2.ConnectionString = FrmHome.ConnectionString
                con2.Open()
                cmd2.Connection = con2
                cmd2.CommandText = "SELECT * from [Unit Information]  WHERE [Unit Name] = '" + Me.TxtUnitName.Text + "'"


                dr2 = cmd2.ExecuteReader()
                dr2.Read()

                If dr2.HasRows Then

                    MsgBox("This Unit Name Is Already Exist", MsgBoxStyle.Critical, "Unit Information")
                    TxtUnitName.Focus()

                ElseIf Not dr2.HasRows Then







                    'Data Insert Code
                    Dim con As New SqlConnection
                    Dim cmd As New SqlCommand


                    'Empty Txt Box Can Not Be Save Code
                    If Me.TxtUnitName.Text = "" Then
                        MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Unit Information")

                    Else
                        con.ConnectionString = FrmHome.ConnectionString
                        con.Open()
                        cmd.Connection = con
                        cmd.CommandText = "INSERT INTO [Unit Information] ([Unit Name],[Prepared Date],[Prepared Time],[Branch ID],[Computer ID],[User Account ID]) VALUES ('" + TxtUnitName.Text + "','" + Currentdate + "','" + Currenttime + "','" + FrmHome.lblBranchID.Text + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "')"
                        cmd.ExecuteNonQuery()

                        con.Close()

                        'Insert into log 
                        InsertIntoLog()


                        'Insert Click Msg
                        MsgBox("Data Inserted Successfully", MsgBoxStyle.OkOnly, "Unit Information")

                        'Making Clear
                        ClearData()

                        'Refresh Data
                        RefreshData()

                        'Focus on Group Name
                        TxtUnitName.Focus()

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

    Private Sub BtnUpdate_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click


        Try

            Dim con2 As New SqlConnection
            Dim cmd2 As New SqlCommand
            Dim dr2 As SqlDataReader

            Dim Currentdate As DateTime = DateTime.Today
            Dim Currenttime As DateTime = DateTime.Now

            con2.ConnectionString = FrmHome.ConnectionString
            con2.Open()
            cmd2.Connection = con2
            cmd2.CommandText = "SELECT * from [Unit Information]  WHERE [Unit Name] = '" + Me.TxtUnitName.Text + "'  INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID])VALUES('" + Me.Text + "','UPDATE','Unit ID: " + TxtUntID.Text + " , Unit Name: " + TxtUnitName.Text + "' ,'" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + Currentdate + "','" + Currenttime + "','" + FrmHome.lblBranchID.Text + "','" + TxtUntID.Text + "' )"

            dr2 = cmd2.ExecuteReader()
            dr2.Read()

            If dr2.HasRows Then

                MsgBox("This Group Name Is Already Exist", MsgBoxStyle.Critical, "Unit Information")
                TxtUnitName.Focus()

            ElseIf Not dr2.HasRows Then





                'Data Update Code
                Dim con As New SqlConnection
                Dim cmd As New SqlCommand

                'Empty Product Group ID Can Not Be Update
                If Me.TxtUntID.Text = "" Then
                    MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Unit Information")

                    'Empty Txt Box Can Not Be Save Code
                ElseIf Me.TxtUnitName.Text = "" Then
                    MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Unit Information")


                Else
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "UPDATE [Unit Information] SET [Unit Name]= '" + TxtUnitName.Text + "',[Branch ID]='" + FrmHome.lblBranchID.Text + "',[Computer ID]='" + FrmHome.LblComputerID.Text + "',[User Account ID]= '" + FrmHome.LblUserID.Text + "' WHERE [Unit ID]= '" + TxtUntID.Text + "'"
                    cmd.ExecuteNonQuery()

                    con.Close()

                    'Update Click Msg
                    MsgBox("Data Updated Successfully", MsgBoxStyle.OkOnly, "Unit Information")

                    'Making Clear
                    ClearData()

                    'Refresh Data
                    RefreshData()

                End If


            End If


            dr2.Close()
            con2.Close()

        Catch ex As Exception
            MessageBox.Show("Error while Updating record on table..." & ex.Message, "Update Records")
        Finally

        End Try

    End Sub

    Private Sub BtnDelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click

        'Empty Product Group ID Can Not Be Delete
        If Me.TxtUntID.Text = "" Then
            MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Unit Information")

        Else
            'Data Delete Code
            Dim q As MsgBoxResult
            q = MsgBox("Do you really want to Delete the row?", MsgBoxStyle.YesNo, "Unit Information")
            If q = MsgBoxResult.Yes Then

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand

                Dim CurrentDate As DateTime = DateTime.Today
                Dim CurrentTime As DateTime = DateTime.Now


                Try
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "Delete from [Unit Information] where [Unit ID]= '" + TxtUntID.Text + "'  INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID])VALUES('" + Me.Text + "','DELETE','Unit ID: " + TxtUntID.Text + " , Unit Name: " + TxtUnitName.Text + "' ,'" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtUntID.Text + "' )"
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

    Private Sub GrdProductGroup_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

    End Sub

    Private Sub BtnRefrersh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefrersh.Click

        Try

            'Refresh Data
            RefreshData()

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records Refresh Button")
        Finally

        End Try

    End Sub

    Private Sub TxtProductGroupName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtUnitName.KeyDown
        If e.KeyCode = Keys.Enter Then

            BtnInsert.PerformClick()
        End If
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

    Private Sub GrdProductGroup_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdProductGroup_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdProductGroup.CellContentClick

    End Sub

    Private Sub GrdProductGroup_CellMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdProductGroup.CellMouseClick
        'Data Grid view code
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdProductGroup.Rows(e.RowIndex)

                TxtUntID.Text = row.Cells("Unit ID").Value.ToString
                TxtUnitName.Text = row.Cells("Unit Name").Value.ToString




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
End Class