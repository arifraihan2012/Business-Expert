Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class FrmLogDetails

    Private Sub GrpLogDetails_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrpLogDetails.Enter

    End Sub
    'Creating Privet Sub of Clear Data
    Sub ClearData()
        Try

            TxtLogID.Text = ""
            TxtLogCategory.Text = ""
            TxtLogDescription.Text = ""
           


        Catch ex As Exception
            MessageBox.Show("Error while clearing data on table..." & ex.Message, "Clear Data")
        Finally

        End Try



    End Sub

    Private Sub BtnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click


        Try

            'Making Clear
            ClearData()

            'Focus on Log Category
            Me.TxtLogCategory.Focus()
        Catch ex As Exception
            MessageBox.Show("Error while clearing data on table..." & ex.Message, "Add New Button")
        Finally

        End Try
    End Sub
    'Creating Privet Sub for Refresh
    Sub RefreshData()

        ' Load Data
        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT * FROM [Log Details]"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Log Details")
            connection.Close()
            GrdLogDetails.DataSource = ds
            GrdLogDetails.DataMember = "BizPro_Log Details"



            'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdLogDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try

        'End Refresh Data
    End Sub

    Private Sub BtnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        'Data Insert Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now

        Try
            'Same id Twice insert restriction code
            If Not Me.TxtLogID.Text = "" Then
                MsgBox("This ID is already exists.", MsgBoxStyle.OkOnly, "Log Details")


            Else
                'Empty Txt Box Can Not Be Save Code
                If Me.TxtLogCategory.Text = "" Or Me.TxtLogDescription.Text = "" Then
                    MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Log Details")

                Else

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO [Log Details] ([Log Category],[Log Description],[Log Date],[Log Time],[Computer ID],[Branch ID]) VALUES ('" + TxtLogCategory.Text + "','" + TxtLogDescription.Text + "','" + currentTime + "','" + currentDate + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.lblBranchID.Text + "')"
                    cmd.ExecuteNonQuery()


                    'Insert Click Msg
                    MsgBox("Data Inserted Successfully", MsgBoxStyle.OkOnly, "Log Details")

                    'Making Clear
                    ClearData()



                    'Refresh Data
                    RefreshData()

                    'Focus on Bank name text box
                    TxtLogCategory.Focus()


                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            con.Close()

        End Try
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        'Data Update Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now

        Try

            'Empty Bank ID Can Not Be Update
            If Me.TxtLogID.Text = "" Then
                MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Log Details")


                'Empty Text Box Can Not Be update Code
            ElseIf Me.TxtLogCategory.Text = "" Or Me.TxtLogDescription.Text = "" Then
                MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Log Details")


            Else
                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "UPDATE [Log Details] SET [Log Category]= '" + TxtLogCategory.Text + "', [Log Description]= '" + TxtLogCategory.Text + "',[Log Time]='" + currentTime + "',[Log Date]='" + currentDate + "',[Computer ID]= '" + FrmHome.LblComputerID.Text + "',[Branch ID]= '" + FrmHome.lblBranchID.Text + "' WHERE [Log ID]= '" + TxtLogID.Text + "'"





                cmd.ExecuteNonQuery()



                'Update Click Msg
                MsgBox("Data Updated Successfully", MsgBoxStyle.OkOnly, "Log Details")

                'Making Clear
                ClearData()


                'Refresh Data
                RefreshData()

            End If

        Catch ex As Exception
            MessageBox.Show("Error while Updating record on table..." & ex.Message, "Update Records")
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        'Empty Branch ID Can Not Be Update
        If Me.TxtLogID.Text = "" Then
            MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Log Details")

        Else


            'Data Delete Code
            Dim q As MsgBoxResult
            q = MsgBox("Do you really want to Delete the row?", MsgBoxStyle.YesNo, "Log Details")
            If q = MsgBoxResult.Yes Then

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand

                Try
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "Delete from [Log Details] where [Log ID]= '" + TxtLogID.Text + "'"
                    cmd.ExecuteNonQuery()


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

    Private Sub BtnRefrersh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefrersh.Click

        Try
            'Refreshing Data
            RefreshData()




            'Clear Data
            ClearData()

        Catch ex As Exception
            MessageBox.Show("Error while refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try

    End Sub

    Private Sub GrdLogDetails_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdLogDetails.CellContentClick

    End Sub

    Private Sub GrdLogDetails_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdLogDetails.CellMouseClick
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdLogDetails.Rows(e.RowIndex)

                TxtLogID.Text = row.Cells("Log ID").Value.ToString
                TxtLogCategory.Text = row.Cells("Log Category").Value.ToString
                TxtLogDescription.Text = row.Cells("Log Description").Value.ToString



                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim dr As SqlDataReader

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "SELECT  *FROM [Log Details]  WHERE [Log ID] = " + Me.TxtLogID.Text + ""


                dr = cmd.ExecuteReader()
                dr.Read()








                dr.Close()
                con.Close()

            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview")

        End Try

    End Sub

    Private Sub TxtLogCategory_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtLogCategory.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TxtLogDescription.Focus()
        End If
    End Sub

    Private Sub TxtLogCategory_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtLogCategory.TextChanged

    End Sub

    Private Sub FrmLogDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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


                dr.Close()
                con.Close()


            End If

        Catch ex As Exception
            MessageBox.Show("Error while  permission delete to form..." & ex.Message, "Form Load")

        End Try
    End Sub
End Class