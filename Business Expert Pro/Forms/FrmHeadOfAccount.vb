Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class frmHeadOfAccount
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point

    Private Sub BtnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click
        Cleardata()
        TxtAccountName.Focus()

    End Sub
    Sub Cleardata()
        TxtHeadOfAccountID.Text = ""
        TxtAccountName.Text = ""
        CmbCategory.Text = ""
    End Sub

    Private Sub TxtAccountName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtAccountName.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbCategory.Focus()
        End If
    End Sub
    Sub Insertdata()
        Try
            'Data Insert Code
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand

            Dim CurrentDate As DateTime = DateTime.Today
            Dim CurrentTime As DateTime = DateTime.Now


            If Not TxtHeadOfAccountID.Text = "" Then
                MsgBox("This ID Is Already Exist", MsgBoxStyle.OkOnly, "Head Of Account")

            ElseIf TxtAccountName.Text = "" Or CmbCategory.Text = "" Then
                MsgBox("Required Field Can Not Be Empty", MsgBoxStyle.OkOnly, "Head Of Account")

            Else
                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "INSERT INTO [Head Of Account] ([Account Name],[Account Category],[Prepared Date],[Prepared Time],[User account ID],[Computer ID]) VALUES ('" + TxtAccountName.Text + "','" + CmbCategory.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "') "
                cmd.ExecuteNonQuery()
                con.Close()

                'Insert Into Log
                InsertIntoLog()

                'Insert Click Msg
                MsgBox("Data Inserted Successfully", MsgBoxStyle.OkOnly, "Head Of Account")

                'Making Clear
                Cleardata()

                'Refreshdata
                Refreshdata()

            End If

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally

        End Try

        TxtAccountName.Focus()

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
            cmd.CommandText = "select top 1 * from [Head Of Account] where [User account ID]='" + FrmHome.LblUserID.Text + "' and [Computer ID]='" + FrmHome.LblComputerID.Text + "'  order by [Head Of Account ID] desc"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then



                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd1.CommandText = "INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID])VALUES('" + Me.Text + "','INSERT','Head Of Account ID: " + dr.Item("Head Of Account ID").ToString + " , Account Name: " + TxtAccountName.Text + " , Category: " + CmbCategory.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + dr.Item("Head Of Account ID").ToString + "' )"
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



            Dim con1 As New SqlConnection
            Dim cmd1 As New SqlCommand
            Dim Dr As SqlDataReader


            con1.ConnectionString = FrmHome.ConnectionString
            con1.Open()
            cmd1.Connection = con1
            cmd1.CommandText = "Select * from [Head of Account] where [Account Name]='" + TxtAccountName.Text + "' And [Account Category]='" + CmbCategory.Text + "'"

            Dr = cmd1.ExecuteReader
            Dr.Read()

            If Not Dr.HasRows Then

                Insertdata()
            Else
                MsgBox("This account name is already exist.", MsgBoxStyle.Critical, "Head of Account")

            End If

            Dr.Close()
            con1.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Sub Refreshdata()
        Try

            ' Load Data
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Head Of Account].[Head Of Account ID],[Account Name],[Account Category] from [Head Of Account]"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro Head Of Account")
            connection.Close()
            GrdHeadOfAcoount.DataSource = ds
            GrdHeadOfAcoount.DataMember = "BizPro Head Of Account"


            GrdHeadOfAcoount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            con.Close()

            'End Refresh Data
        Catch ex As Exception
            MessageBox.Show("Error while refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try

        TxtAccountName.Focus()

    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        Refreshdata()
    End Sub
    Private Sub GrdHeadOfAcoount_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

    End Sub
    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click

        Try
            'Data Update Code
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand

            Dim CurrentDate As DateTime = DateTime.Today
            Dim CurrentTime As DateTime = DateTime.Now


            If TxtHeadOfAccountID.Text = "" Then
                MsgBox("Please Select A Row First", MsgBoxStyle.OkOnly, "Head Of Account")

            ElseIf TxtAccountName.Text = "" Or CmbCategory.Text = "" Then
                MsgBox("Required Field Can Not Be Empty", MsgBoxStyle.OkOnly, "Head Of Account")
            Else

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = " Update [Head Of Account] set  [Account Name]='" + TxtAccountName.Text + "', [Account Category]='" + CmbCategory.Text + "' where [Head Of Account ID]='" + TxtHeadOfAccountID.Text + "'   INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID])VALUES('" + Me.Text + "','UPDATE','Head Of Account ID: " + TxtHeadOfAccountID.Text + " , Account Name: " + TxtAccountName.Text + " , Category: " + CmbCategory.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtHeadOfAccountID.Text + "' )"
                cmd.ExecuteNonQuery()

                con.Close()


                'Update Click Msg
                MsgBox("Data Updated Successfully", MsgBoxStyle.OkOnly, "Head Of Account")

                'Making Clear
                Cleardata()

                'Refreshdata
                Refreshdata()

            End If

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally


        End Try

        TxtAccountName.Focus()

    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Try

            'Data Delete Code
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand

            Dim CurrentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now


            If TxtHeadOfAccountID.Text = "" Then
                MsgBox("Please Select A Row First", MsgBoxStyle.OkOnly, "Head Of Account")
            Else

                Dim q As MsgBoxResult
                q = MsgBox("Do you really want to Delete the row?", MsgBoxStyle.YesNo, "Head Of Account")
                If q = MsgBoxResult.Yes Then


                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = " Delete from [Head Of Account]  where [Head Of Account ID]='" + TxtHeadOfAccountID.Text + "'   INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID])VALUES('" + Me.Text + "','DELETE','Head Of Account ID: " + TxtHeadOfAccountID.Text + " , Account Name: " + TxtAccountName.Text + " , Category: " + CmbCategory.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CurrentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtHeadOfAccountID.Text + "' )"
                    cmd.ExecuteNonQuery()

                    con.Close()

                    'Making Clear
                    Cleardata()

                    'Refreshdata
                    Refreshdata()

                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally

        End Try

        TxtAccountName.Focus()


    End Sub
    Private Sub CmbOpeningBalanceStatus_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbCategory.KeyDown
        If e.KeyCode = Keys.Enter Then
            Insertdata()
        End If
    End Sub

    Private Sub GrdHeadOfAcoount_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub frmHeadOfAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

      

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
    End Sub

    Private Sub CmbCategory_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbCategory.KeyPress
        e.Handled = True
    End Sub

    Private Sub CmbCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCategory.SelectedIndexChanged

    End Sub

    Private Sub TxtAccountName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtAccountName.TextChanged

        'All Capitalized word 
        TxtAccountName.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub Btnminimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnminimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Btnmaximized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnmaximized.Click

        If Me.Size = My.Computer.Screen.WorkingArea.Size Then
            Me.WindowState = FormWindowState.Normal

        Else
            Me.Location = New Point(0, 0)
            Me.Size = My.Computer.Screen.WorkingArea.Size

        End If
    End Sub

    Private Sub Btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnclose.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdHeadOfAcoount.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdHeadOfAcoount.CellMouseClick
        'Data Grid view code
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdHeadOfAcoount.Rows(e.RowIndex)

                TxtHeadOfAccountID.Text = row.Cells("Head Of Account ID").Value.ToString
                TxtAccountName.Text = row.Cells("Account Name").Value.ToString
                CmbCategory.Text = row.Cells("Account Category").Value.ToString
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
