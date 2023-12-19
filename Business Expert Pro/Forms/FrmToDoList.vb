
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmToDoList
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point
    Private Sub FrmToDoList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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




        'Change Langeuge Privet Sub
        ChangeLanguage()


        DtpRemindDate.Value = Now
        CmbStatus.SelectedIndex = 1
    End Sub

    Private Sub GrpToDoList_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrpToDoList.Enter

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


                Me.TxtAppointmentID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.txtDescription.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtTaskPersonName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtSmsNotificationNo.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.DtpRemindDate.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtRemindTime.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.CmbNotificationStatus.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.CmbStatus.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))


                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

                Me.GrdToDoList.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdToDoList.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)


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
    Sub ClearData()
        'Creating Privet sub of Clearing text 
        Try

            TxtAppointmentID.Text = ""

            txtDescription.Text = ""

            TxtTaskPersonName.Text = ""

            TxtSmsNotificationNo.Text = ""
            DtpRemindDate.Value = Now
            TxtRemindTime.Text = ""
            CmbNotificationStatus.Text = ""
            CmbStatus.SelectedIndex = 1

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
            Dim sql As String = "SELECT [Appointment ID],[Description],[Task Person Name],[SMS Notification Number],[Remind Date],[Remind Time],[Notification Status],[Status] FROM [To Do List]"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_To Do List")
            connection.Close()
            GrdToDoList.DataSource = ds
            GrdToDoList.DataMember = "BizPro_To Do List"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            GrdToDoList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill



        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try
        'End Refresh Data

    End Sub


    Private Sub BtnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click
        Try

            'Clear Data
            ClearData()


            'Focus on Bank ID
            Me.txtDescription.Focus()

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
            cmd.CommandText = "select top 1 * from [To Do List] where [User account ID]='" + FrmHome.LblUserID.Text + "' and [Computer ID]='" + FrmHome.LblComputerID.Text + "'  order by [Appointment ID] desc"
            dr = cmd.ExecuteReader
            dr.Read()

            If dr.HasRows Then

                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd1.CommandText = "INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID])VALUES('" + Me.Text + "','INSERT','Appointment ID: " + dr.Item("Appointment ID").ToString + " , Description: " + txtDescription.Text + " , Task PersonName: " + TxtTaskPersonName.Text + ",  Sms Notification No: " + TxtSmsNotificationNo.Text + " , Remind Date: " + DtpRemindDate.Value + ", Remind Time: " + TxtRemindTime.Text + ", Notification Status: " + CmbNotificationStatus.Text + ", CmbStatus: " + CmbStatus.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + dr.Item("Appointment ID").ToString + "' )"
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


    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        'Data Insert Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now
        Try



            'Same ID twice insert restriction code
            If Not Me.TxtAppointmentID.Text = "" Then
                MsgBox("This ID is already Exist", MsgBoxStyle.OkOnly, "To Do List")
            Else
                If Me.txtDescription.Text = "" Or Me.TxtTaskPersonName.Text = "" Or Me.TxtSmsNotificationNo.Text = "" Then
                    MsgBox("Required Field can not be empty", MsgBoxStyle.OkOnly, "To Do List")

                Else


                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO [To Do List] ([Description],[Task Person Name],[SMS Notification Number],[Remind Date],[Remind Time],[Notification Status],[Prepared Time],[Prepared Date],[User Account ID],[Status],[Computer ID]) VALUES ('" + txtDescription.Text + "','" + TxtTaskPersonName.Text + "','" + TxtSmsNotificationNo.Text + "','" + DtpRemindDate.Value + "','" + TxtRemindTime.Text + "','" + CmbNotificationStatus.Text + "','" + currentTime + "','" + currentDate + "','" + FrmHome.LblUserID.Text + "','" + CmbStatus.Text + "','" + FrmHome.LblComputerID.Text + "')"
                    cmd.ExecuteNonQuery()
                    con.Close()

                    'Insert into log
                    InsertIntoLog()






                    'Refresh Data
                    RefreshData()


                    'Insert Click Msg
                    MsgBox("Data Inserted Successfully", MsgBoxStyle.OkOnly, "To Do List")
                    'Making Clear
                    ClearData()

                    'Focus on Bank ID text box
                    txtDescription.Focus()



                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally


        End Try



    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        'Data Update Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now

        Try

            'Empty Bank Transaction ID Can Not Be Update
            If Me.TxtAppointmentID.Text = "" Then
                MsgBox("Please select a row", MsgBoxStyle.OkOnly, "To Do List")

                'Empty Txt Box Can Not Be Save Code

            ElseIf Me.txtDescription.Text = "" Or Me.TxtTaskPersonName.Text = "" Or Me.TxtSmsNotificationNo.Text = "" Then
                MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "To Do List")

            Else
                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "UPDATE [To Do List] SET [Description]= '" + txtDescription.Text + "', [Task Person Name]= '" + TxtTaskPersonName.Text + "',[SMS Notification Number] = '" + TxtSmsNotificationNo.Text + "',[Remind Date]= '" + DtpRemindDate.Value + "',[Remind Time]= '" + TxtRemindTime.Text + "',[Notification Status]= '" + CmbNotificationStatus.Text + "',[Prepared Time]='" + currentTime + "',[Prepared Date]='" + currentDate + "',[User Account ID]= '" + FrmHome.LblUserID.Text + "',[Status]='" + CmbStatus.Text + "' WHERE [Appointment ID]= '" + TxtAppointmentID.Text + "'  INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID])VALUES('" + Me.Text + "','UPDATE','Appointment ID: " + TxtAppointmentID.Text + " , Description: " + txtDescription.Text + " , Task PersonName: " + TxtTaskPersonName.Text + ",  Sms Notification No: " + TxtSmsNotificationNo.Text + " , Remind Date: " + DtpRemindDate.Value + ", Remind Time: " + TxtRemindTime.Text + ", Notification Status: " + CmbNotificationStatus.Text + ", CmbStatus: " + CmbStatus.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtAppointmentID.Text + "' )"
                cmd.ExecuteNonQuery()
                con.Close()


                'Update Click Msg
                MsgBox("Data Updated Successfully", MsgBoxStyle.OkOnly, "To Do List")

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
        'Empty Bank Transaction ID Can Not Be Update
        If Me.TxtAppointmentID.Text = "" Then
            MsgBox("Please select a row", MsgBoxStyle.OkOnly, "To Do List")

        Else


            'Data Delete Code
            Dim q As MsgBoxResult
            q = MsgBox("Do you really want to Delete the row?", MsgBoxStyle.YesNo, "To Do List")
            If q = MsgBoxResult.Yes Then

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim currentDate As DateTime = DateTime.Today
                Dim currentTime As DateTime = DateTime.Now

                Try
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "Delete from [To Do List] where [Appointment ID]= '" + TxtAppointmentID.Text + "'   INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID])VALUES('" + Me.Text + "','DELETE','Appointment ID: " + TxtAppointmentID.Text + " , Description: " + txtDescription.Text + " , Task PersonName: " + TxtTaskPersonName.Text + ",  Sms Notification No: " + TxtSmsNotificationNo.Text + " , Remind Date: " + DtpRemindDate.Value + ", Remind Time: " + TxtRemindTime.Text + ", Notification Status: " + CmbNotificationStatus.Text + ", CmbStatus: " + CmbStatus.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtAppointmentID.Text + "' )"
                    cmd.ExecuteNonQuery()
                    con.Close()

                    'Refresh Data
                    RefreshData()


                    'Making Clear
                    ClearData()





                Catch ex As Exception
                    MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Records")
                Finally

                End Try


            End If
        End If




    End Sub

    Private Sub GrdToDoList_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdToDoList_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click

        Try
            'Refresh Data
            RefreshData()


        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try

    End Sub

    Private Sub TxtDescription_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        
    End Sub

    Private Sub TxtDescription_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtTaskPersonName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTaskPersonName.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TxtSmsNotificationNo.Focus()

        End If
    End Sub

    Private Sub TxtTaskPersonName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTaskPersonName.TextChanged

    End Sub

    Private Sub TxtSmsNotificationNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSmsNotificationNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.DtpRemindDate.Focus()

        End If
    End Sub

    Private Sub TxtSmsNotificationNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSmsNotificationNo.TextChanged

    End Sub

    Private Sub DtpRemindDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DtpRemindDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TxtRemindTime.Focus()

        End If
    End Sub

    Private Sub DtpRemindDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtpRemindDate.ValueChanged

    End Sub

    Private Sub TxtRemindTime_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtRemindTime.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.CmbNotificationStatus.Focus()

        End If
    End Sub

    Private Sub TxtRemindTime_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtRemindTime.TextChanged

    End Sub

    Private Sub TxtDescription_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub TxtDescription_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescription.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TxtTaskPersonName.Focus()

        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescription.TextChanged

    End Sub

    Private Sub CmbNotificationStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbNotificationStatus.SelectedIndexChanged
        CmbStatus.Focus()
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

    Private Sub GrdToDoList_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdToDoList.CellContentClick

    End Sub

    Private Sub GrdToDoList_CellMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdToDoList.CellMouseClick

        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdToDoList.Rows(e.RowIndex)

                TxtAppointmentID.Text = row.Cells("Appointment ID").Value.ToString
                txtDescription.Text = row.Cells("Description").Value.ToString
                TxtTaskPersonName.Text = row.Cells("Task Person Name").Value.ToString
                TxtSmsNotificationNo.Text = row.Cells("SMS Notification Number").Value.ToString
                DtpRemindDate.Text = row.Cells("Remind Date").Value.ToString
                TxtRemindTime.Text = row.Cells("Remind Time").Value.ToString
                CmbNotificationStatus.Text = row.Cells("Notification Status").Value.ToString
                CmbStatus.Text = row.Cells("Status").Value.ToString



            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview")

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