Imports System.Data
Imports System.Data.SqlClient
Imports System.IO


Public Class FrmViewToDoList
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point

    'Search Student Incomplete BY loginID

    Sub SearchToDoListIncomplete()


        Try
           
            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Appointment ID],[Status],[Description],[Task Person Name],[SMS Notification Number],[Remind Date],[Remind Time] FROM [To Do List] where [Status]='INCOMPLETE' and [Remind Date] between '" + DtpFromDate.Value + "'  and '" + DtpTodate.Value + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_To Do List")
            connection.Close()
            GrdViewToDoListIncomplete.DataSource = ds
            GrdViewToDoListIncomplete.DataMember = "BizPro_To Do List"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            'GrdSaleInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


            GrdViewToDoListIncomplete.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            'Count Total Services
            NUmberOfRowIncomplete()


        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try



    End Sub
    'Search Student Incomplete BY loginID

    Sub SearchToDoListComplete()

        Try
            
            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Appointment ID],[Status],[Description],[Task Person Name],[SMS Notification Number],[Remind Date],[Remind Time] FROM [To Do List] where [Status]='COMPLETE' and [Remind Date] between '" + DtpFromDate.Value + "'  and '" + DtpTodate.Value + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_To Do List")
            connection.Close()
            GrdViewToDoListComplete.DataSource = ds
            GrdViewToDoListComplete.DataMember = "BizPro_To Do List"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            'GrdSaleInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill



            GrdViewToDoListComplete.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


            'Count Total Services
            NUmberOfRowComplete()



        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try



    End Sub

    Private Sub FrmViewToDoList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 0)
        Me.Size = My.Computer.Screen.WorkingArea.Size

        ' Changing Language
        'ChangeLanguage()

        DtpFromDate.Value = Now
        DtpTodate.Value = Now

        SearchToDoListComplete()
        SearchToDoListIncomplete()


    End Sub

    ' Changing Language
    Sub ChangeLanguage()

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


                Me.DtpFromDate.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.DtpTodate.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))

                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

                Me.GrdViewToDoListComplete.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdViewToDoListComplete.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)

                Me.GrdViewToDoListIncomplete.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdViewToDoListIncomplete.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)



                'MsgBox(dr.Item("Language Font"))
            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while changing language on table..." & ex.Message, "Change Language")
        Finally
            con.Close()
        End Try

        'End Language

    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        SearchToDoListComplete()
        SearchToDoListIncomplete()
    End Sub
    Sub NUmberOfRowIncomplete()

        'Total gridview line show in label code
        Dim total As String = 0

        total = GrdViewToDoListIncomplete.Rows.Count

        Me.Label7.Text = total


    End Sub
    Sub NUmberOfRowComplete()

        'Total gridview line show in label code
        Dim total As String = 0

        total = GrdViewToDoListComplete.Rows.Count

        Me.Label2.Text = total

    End Sub

    Private Sub GrdViewToDoListIncomplete_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

    End Sub

    Private Sub GrdViewToDoListComplete_CellMouseDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)



    End Sub

    Private Sub GrdViewToDoListIncomplete_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdViewToDoListComplete_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'Me.Hide()
        FrmToDoList.Show()

    End Sub

    Private Sub GrdViewToDoListIncomplete_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdViewToDoListIncomplete.CellContentClick

    End Sub

    Private Sub GrdViewToDoListIncomplete_CellMouseDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdViewToDoListIncomplete.CellMouseDoubleClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.GrdViewToDoListIncomplete.Rows(e.RowIndex)




            'Data Update Code
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now

            Try




                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "UPDATE [To Do List] SET [Status]='COMPLETE' WHERE [Appointment ID]= '" + row.Cells("Appointment ID").Value.ToString + "'"
                cmd.ExecuteNonQuery()
                con.Close()

                'Update Click Msg
                MsgBox("Listed as complete.", MsgBoxStyle.OkOnly, "View To Do List")


                SearchToDoListComplete()
                SearchToDoListIncomplete()




            Catch ex As Exception
                MessageBox.Show("Error while Updating record on table..." & ex.Message, "Update Records")
            Finally

            End Try

        End If
    End Sub

    Private Sub GrdViewToDoListComplete_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdViewToDoListComplete.CellContentClick

    End Sub

    Private Sub GrdViewToDoListComplete_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdViewToDoListComplete.CellMouseDoubleClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.GrdViewToDoListComplete.Rows(e.RowIndex)




            'Data Update Code
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now

            Try




                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "UPDATE [To Do List] SET [Status]='INCOMPLETE' WHERE [Appointment ID]= '" + row.Cells("Appointment ID").Value.ToString + "'"
                cmd.ExecuteNonQuery()
                con.Close()

                'Update Click Msg
                MsgBox("Listed as incomplete.", MsgBoxStyle.OkOnly, "View To Do List")


                SearchToDoListComplete()
                SearchToDoListIncomplete()




            Catch ex As Exception
                MessageBox.Show("Error while Updating record on table..." & ex.Message, "Update Records")
            Finally

            End Try

        End If
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
End Class
