Imports System.Data
Imports System.Data.SqlClient
Public Class FrmBank

    Private Sub BtnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click
        'Focus on Group Name
        TxtBankName.Focus()



        'Making Clear
        ClearData()
    End Sub
    'Crating Privet Sub for Clear Data
    Sub ClearData()

        TxtBankID.Text = ""
        TxtBankName.Text = ""


    End Sub
    'Crating Privet Sub for Clear Data
    Sub RefreshData()

        ' Load Data
       

        Dim connectionString As String = FrmHome.ConnectionString
        Dim sql As String = "SELECT * FROM [Bank]"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "BizPro_Bank")
        connection.Close()
        GrdBank.DataSource = ds
        GrdBank.DataMember = "BizPro_Bank"

        'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
        'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
        GrdBank.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


        'End Refresh Data

    End Sub

    Private Sub BtnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInsert.Click
        'Data Insert Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        Try
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO [Bank] ([Bank Name]) VALUES ('" + TxtBankName.Text + "')"
            cmd.ExecuteNonQuery()
            con.Close()
            'Insert Click Msg
            MsgBox("Data Inserted Successfully", MsgBoxStyle.OkOnly, "Bank")
            'Making Clear
            ClearData()


            'Refresh Data
            RefreshData()


        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally


        End Try
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        'Data Update Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        Try
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "UPDATE [Bank] SET [Bank Name]= '" + TxtBankName.Text + "' WHERE [Bank ID]= '" + TxtBankID.Text + "'"
            con.Close()



            cmd.ExecuteNonQuery()



            'Update Click Msg
            MsgBox("Data Updated Successfully", MsgBoxStyle.OkOnly, "Bank")

            'Making Clear
            ClearData()

            'Refresh Data
            RefreshData()

        Catch ex As Exception
            MessageBox.Show("Error while Updating record on table..." & ex.Message, "Update Records")
        Finally

        End Try
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        'Data Delete Code
        Dim q As MsgBoxResult
        q = MsgBox("Do you really want to Delete the row?", MsgBoxStyle.YesNo, "Bank")
        If q = MsgBoxResult.Yes Then

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Try
                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "Delete from [Bank] where [Bank ID]= '" + TxtBankID.Text + "'"
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
    End Sub

    Private Sub BtnRefrersh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefrersh.Click
        'Refresh Data
        RefreshData()
    End Sub

    Private Sub GrdBank_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdBank.CellContentClick

    End Sub

    Private Sub GrdBank_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdBank.CellMouseClick
        'Data Grid view code
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdBank.Rows(e.RowIndex)

                TxtBankID.Text = row.Cells("Bank ID").Value.ToString
                TxtBankName.Text = row.Cells("Bank Name").Value.ToString




            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

        End Try
    End Sub

    Private Sub FrmBank_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        






    End Sub
End Class