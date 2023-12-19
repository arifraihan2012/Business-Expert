Imports System.Data
Imports System.Data.SqlClient


Public Class FrmLanguageInformation
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point

    Private Sub TxtLanguageName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtLanguageName.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TxtLanguageFont.Focus()
        End If
    End Sub

    Private Sub TxtLanguageName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtLanguageName.TextChanged

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
            cmd.CommandText = "select top 1 * from [Language Information] where [User account ID]='" + FrmHome.LblUserID.Text + "' and [Computer ID]='" + FrmHome.LblComputerID.Text + "'  order by [Language ID] desc"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then



                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd1.CommandText = "INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES ('" + Me.Text + "','INSERT','Language ID: " + dr.Item("Language ID").ToString + " , Language Name: " + TxtLanguageName.Text + " , Language Font: " + TxtLanguageFont.Text + ",  Font Size: " + TxtFontSize.Text + " , Language Status: " + TxtLanguageStatus.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + dr.Item("Language ID").ToString + "' )"
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
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        Try
            'Same id Twice insert restriction code
            If Not Me.TxtLanguageID.Text = "" Then
                MsgBox("This ID is already Exist.", MsgBoxStyle.OkOnly, "Language Information")


            Else
                'Empty Txt Box Can Not Be Save Code
                If Me.TxtLanguageName.Text = "" Or Me.TxtFontSize.Text = "" Then
                    MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Language Information")

                Else
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO [Language Information] ([Language Name],[Language Font],[Status],[Font Size],[User Account ID],[Computer ID]) VALUES ('" + TxtLanguageName.Text + "','" + TxtLanguageFont.Text + "','" + TxtLanguageStatus.Text + "', '" + TxtFontSize.Text + "', '" + FrmHome.LblUserID.Text + "', '" + FrmHome.LblComputerID.Text + "')"
                    cmd.ExecuteNonQuery()
                    con.Close()

                    'Insert into log 
                    InsertIntoLog()

                    MsgBox("Data Inserted Successfully")
                    clearData()
                    RefreshData()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally


        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        'Empty Language Information Can Not Be Delete
        If Me.TxtLanguageID.Text = "" Then
            MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Language Information")

        Else

            Dim q As MsgBoxResult
            q = MsgBox("Do you really want to Delete the row?", MsgBoxStyle.YesNo, "Language Information")
            If q = MsgBoxResult.Yes Then

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand

                Dim CurrentDate As DateTime = DateTime.Today
                Dim CurrentTime As DateTime = DateTime.Now


                Try
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "Delete from [Language Information] where [Language ID]= '" + TxtLanguageID.Text + "'   INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES ('" + Me.Text + "','DELETE','Language ID: " + TxtLanguageID.Text + " , Language Name: " + TxtLanguageName.Text + " , Language Font: " + TxtLanguageFont.Text + ",  Font Size: " + TxtFontSize.Text + " , Language Status: " + TxtLanguageStatus.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtLanguageID.Text + "' )"
                    cmd.ExecuteNonQuery()
                    con.Close()

                    clearData()
                    RefreshData()

                Catch ex As Exception
                    MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Records")
                Finally

                End Try


            End If
        End If

    End Sub



    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub FrmLanguageInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load




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
                btndelete.Enabled = True
                BtnUpdate.Enabled = True

            ElseIf Not dr.HasRows Then
                btndelete.Enabled = False
                BtnUpdate.Enabled = False

            End If


            dr.Close()
            con.Close()


        Catch ex As Exception
            MessageBox.Show("Error while  permission delete to form..." & ex.Message, "Form Load")

        End Try



    End Sub

    Private Sub GrdLanguageSetting_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)













    End Sub

    Private Sub GrdLanguageSetting_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        Dim CurrentDate As DateTime = DateTime.Today
        Dim CurrentTime As DateTime = DateTime.Now

        Try


            'Empty Language ID Can Not Be Update
            If Me.TxtLanguageID.Text = "" Then
                MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Language Information")

            Else
                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "UPDATE [Language Information] SET [Language Name]= '" + TxtLanguageName.Text + "', [Language Font]= '" + TxtLanguageFont.Text + "', Status = '" + TxtLanguageStatus.Text + "', [Font Size]= '" + TxtFontSize.Text + "' WHERE [Language ID]= '" + TxtLanguageID.Text + "'    INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES ('" + Me.Text + "','UPDATE','Language ID: " + TxtLanguageID.Text + " , Language Name: " + TxtLanguageName.Text + " , Language Font: " + TxtLanguageFont.Text + ",  Font Size: " + TxtFontSize.Text + " , Language Status: " + TxtLanguageStatus.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtLanguageID.Text + "' )"

                cmd.ExecuteNonQuery()
                con.Close()


                MsgBox("Data Updated Successfully")
                clearData()
                RefreshData()
            End If
        Catch ex As Exception
            MessageBox.Show("Error while Updating record on table..." & ex.Message, "Update Records")
        Finally

        End Try
    End Sub


    Sub RefreshData()

        ' Load Data
        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT * FROM [Language Information]"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Language Information")
            connection.Close()
            GrdLanguageSetting.DataSource = ds
            GrdLanguageSetting.DataMember = "BizPro_Language Information"

            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            GrdLanguageSetting.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Show Records")
        Finally

        End Try
        'End Refresh Data

    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try


            RefreshData()


        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records Refresh Button")
        Finally

        End Try

    End Sub

    Private Sub TxtLanguageFont_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtLanguageFont.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TxtFontSize.Focus()
        End If
    End Sub




    Private Sub TxtLanguageFont_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtLanguageFont.TextChanged

    End Sub



    Sub clearData()
        Try
            TxtLanguageID.Clear()
            TxtLanguageName.Clear()
            TxtLanguageFont.Clear()
            TxtFontSize.Clear()
            TxtLanguageStatus.Clear()


        Catch ex As Exception
            MessageBox.Show("Error while Clearing record on table..." & ex.Message, "Clear data")
        Finally

        End Try
    End Sub

    Private Sub BtnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click
        Try
            clearData()

            Me.TxtLanguageName.Focus()

        Catch ex As Exception
            MessageBox.Show("Error while adding data on table..." & ex.Message, "Add New Button")
        Finally

        End Try

    End Sub

    Private Sub TxtFontSize_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtFontSize.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TxtLanguageStatus.Focus()
        End If
    End Sub

    Private Sub TxtFontSize_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtFontSize.TextChanged

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

    Private Sub GrdLanguageSetting_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdLanguageSetting.CellContentClick

    End Sub

    Private Sub GrdLanguageSetting_CellMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdLanguageSetting.CellMouseClick
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdLanguageSetting.Rows(e.RowIndex)

                TxtLanguageID.Text = row.Cells("Language ID").Value.ToString
                TxtLanguageName.Text = row.Cells("Language Name").Value.ToString
                TxtLanguageFont.Text = row.Cells("Language Font").Value.ToString
                TxtLanguageStatus.Text = row.Cells("Status").Value.ToString
                TxtFontSize.Text = row.Cells("Font Size").Value.ToString


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