Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmServerInformation
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point

    Private Sub FrmServerDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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


                dr.Close()
                con.Close()


            End If

        Catch ex As Exception
            MessageBox.Show("Error while  permission delete to form..." & ex.Message, "Form Load")

        End Try

    End Sub

    'Private Sub For Making clear

    Sub ClearData()
        'Making Clear 
        Try
            TxtServerID.Text = ""
            TxtBEMac.Text = ""
            TxtLicenceCode.Text = ""
            TxtStatus.Text = ""
            TxtDescription.Text = ""

        Catch ex As Exception
            MessageBox.Show("Error while clearing record on table..." & ex.Message, "Clear Records")
        Finally

        End Try
    End Sub

    Private Sub BtnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click
        Try
            'Focus on Group Name
            TxtBEMac.Focus()



            'Making Clear
            ClearData()
        Catch ex As Exception
            MessageBox.Show("Error while adding data on table..." & ex.Message, "Add New Button")
        Finally

        End Try
    End Sub

    'Private Sub for Refresh Data
    Sub RefreshData()
        Try
            ' Load Data
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT * FROM [Server Information]"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Server Information")
            connection.Close()
            GrdServerInformation.DataSource = ds
            GrdServerInformation.DataMember = "BizPro_Server Information"

            'GrdProductSubcategory.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductSubcategory.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdServerInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            con.Close()

            'End Refresh Data

        Catch ex As Exception
            MessageBox.Show("Error while refreshing record on table..." & ex.Message, "Refresh Records")
        Finally


        End Try
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDescription.TextChanged

    End Sub

    Private Sub BtnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInsert.Click
        'Data Insert Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand


        Try
            'Same id Twice insert restriction code
            If Not Me.TxtServerID.Text = "" Then
                MsgBox("This ID is already Exist.", MsgBoxStyle.OkOnly, "Server Information")


            Else
                'Empty Txt Box Can Not Be Save Code
                If Me.TxtLicenceCode.Text = "" Then
                    MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Server Information")

                Else
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO [Server Information]([BE Mac],[License Code],[Status],[Description]) VALUES ('" + TxtBEMac.Text + "','" + TxtLicenceCode.Text + "','" + TxtStatus.Text + "','" + TxtDescription.Text + "')"
                    cmd.ExecuteNonQuery()

                    'Insert Click Msg
                    MsgBox("Data Inserted Successfully", MsgBoxStyle.OkOnly, "Server Information")
                    'Making Clear
                    ClearData()



                    'Refresh Data
                    RefreshData()

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

        Try
            'Empty Server ID Can Not Be Update
            If Me.TxtServerID.Text = "" Then
                MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Server Information")

            Else
                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "UPDATE [Server Information] SET [BE Mac]= '" + TxtBEMac.Text + "',[License Code]= '" + TxtLicenceCode.Text + "',[Status]= '" + TxtStatus.Text + "' ,[Description]= '" + TxtDescription.Text + "'  WHERE [server ID]= '" + TxtServerID.Text + "'"




                cmd.ExecuteNonQuery()



                'Update Click Msg
                MsgBox("Data Updated Successfully", MsgBoxStyle.OkOnly, "Server Information")

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
        'Empty Product SubcategoryID Can Not Be Delete
        If Me.TxtServerID.Text = "" Then
            MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Server Information")

        Else
            'Data Delete Code
            Dim q As MsgBoxResult
            q = MsgBox("Do you really want to Delete the row?", MsgBoxStyle.YesNo, "Server Information")
            If q = MsgBoxResult.Yes Then

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand

                Try
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "Delete from [Server Information] where [Server ID]= '" + TxtServerID.Text + "'"
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
        'Refresh Data
        Try
            RefreshData()

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records Refresh Button")
        Finally

        End Try

    End Sub

    Private Sub GrdServerInformation_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdServerInformation_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

    End Sub

    Private Sub TxtBEMac_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBEMac.KeyDown
        'Focus on License Code Text Box
        If e.KeyCode = Keys.Enter Then
            Me.TxtLicenceCode.Focus()

        End If
    End Sub

    Private Sub TxtBEMac_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBEMac.TextChanged

    End Sub

    Private Sub TxtLicenceCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtLicenceCode.KeyDown
        'Focus on Status Text Box
        If e.KeyCode = Keys.Enter Then
            Me.TxtStatus.Focus()

        End If
    End Sub

    Private Sub TxtLicenceCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtLicenceCode.TextChanged

    End Sub

    Private Sub TxtStatus_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtStatus.KeyDown
        'Focus on Description Text Box
        If e.KeyCode = Keys.Enter Then
            Me.TxtDescription.Focus()

        End If
    End Sub

    Private Sub TxtStatus_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtStatus.TextChanged

    End Sub

    Private Sub GrdServerInformation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub CmbSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub CmbSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub GrdServerInformation_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdServerInformation.CellContentClick

    End Sub

    Private Sub GrdServerInformation_CellMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdServerInformation.CellMouseClick


        'Data Grid view code
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdServerInformation.Rows(e.RowIndex)

                TxtServerID.Text = row.Cells("Server ID").Value.ToString
                TxtBEMac.Text = row.Cells("BE Mac").Value.ToString
                TxtLicenceCode.Text = row.Cells("License Code").Value.ToString
                TxtStatus.Text = row.Cells("Status").Value.ToString
                TxtDescription.Text = row.Cells("Description").Value.ToString







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