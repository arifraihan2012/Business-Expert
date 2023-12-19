Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class FrmComputerAccount
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point
    Private Sub FrmComputerAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


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



    Private Sub LblComputerID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblComputerID.Click

    End Sub

    Private Sub LblMacAddress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblMACAddress.Click

    End Sub

    Private Sub LblComputerName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblComputerName.Click

    End Sub

    Private Sub LblComputerLocation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblComputerLocation.Click

    End Sub

    Private Sub TxtComputerID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtComputerID.TextChanged

    End Sub

    Private Sub TxtComputerName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtComputerName.KeyDown
        'Focus on Computer Location Text Box
        If e.KeyCode = Keys.Enter Then
            Me.TxtComputerLocation.Focus()

        End If
    End Sub

    Private Sub TxtComputerName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtComputerName.TextChanged

    End Sub

    Private Sub TxtComputerLocation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtComputerLocation.KeyDown
        'Focus on Remarks Text Box
        If e.KeyCode = Keys.Enter Then
            Me.TxtRemarks.Focus()

        End If
    End Sub

    Private Sub TxtComputerLocation_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtComputerLocation.TextChanged

    End Sub

    Private Sub TxtMACAddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtMACAddress.KeyDown
        'Focus on Computer Name Text Box
        If e.KeyCode = Keys.Enter Then
            Me.TxtComputerName.Focus()

        End If
    End Sub

    Private Sub TxtMacAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtMACAddress.TextChanged
        'Change all text entered to be Upercase.
        TxtMACAddress.CharacterCasing = CharacterCasing.Upper
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
    'Crating Privet Sub for Clear Data
    Sub ClearData()
        Try
            TxtComputerID.Text = ""
            TxtMACAddress.Text = ""
            TxtComputerName.Text = ""
            TxtComputerLocation.Text = ""
            TxtRemarks.Text = ""



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
            Dim sql As String = "SELECT * FROM [Computer Account]"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Computer Account")
            connection.Close()
            GrdComputerAccount.DataSource = ds
            GrdComputerAccount.DataMember = "BizPro_Computer Account"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdComputerAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try
        'End Refresh Data

    End Sub

    Private Sub BtnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click

        Try
            'Focus on Group Name
            TxtMACAddress.Focus()



            'Making Clear
            ClearData()

        Catch ex As Exception
            MessageBox.Show("Error while clearing data on table..." & ex.Message, "Clear Data")
        Finally

        End Try
    End Sub
    

    Private Sub BtnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        'Data Insert Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now
        Try

            'Same id Twice insert restriction code
            If Not Me.TxtComputerID.Text = "" Then
                MsgBox("This ID is already exists.", MsgBoxStyle.OkOnly, "Computer Account")


            Else
                'Emty Txt Box Can Not Be Save Code
                If Me.TxtComputerName.Text = "" Then
                    MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Computer Account")

                Else
                    If GrdComputerAccount.Rows.Count = 8 Then
                        MsgBox("You do not have permission to add more then 8 computer.", MsgBoxStyle.Critical, "Computer Account")
                    Else
                        con.ConnectionString = FrmHome.ConnectionString
                        con.Open()
                        cmd.Connection = con
                        cmd.CommandText = "INSERT INTO [Computer Account]([MAC Address],[Computer Name],[Computer Location],[Remarks]) VALUES ('" + TxtMACAddress.Text + "','" + TxtComputerName.Text + "','" + TxtComputerLocation.Text + "','" + TxtRemarks.Text + "')"
                        cmd.ExecuteNonQuery()
                        con.Close()

                        'Insert Click Msg
                        MsgBox("Data Inserted Successfully", MsgBoxStyle.OkOnly, "Computer Account")


                        'Making Clear
                        ClearData()



                        'Refresh Data
                        RefreshData()


                        'Focus on Bank name text box
                        TxtMACAddress.Focus()

                        'Show Computer ID
                        FrmHome.FindComputerID()

                    End If
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
            'Empty Computer ID Can Not Be Update
            If Me.TxtComputerID.Text = "" Then
                MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Computer Account")

                'Emty Txt Box Can Not Be Save Code
            ElseIf Me.TxtComputerName.Text = "" Then
                MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Computer Account")


            Else

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = ("UPDATE [Computer Account] SET [MAC Address]= '" + TxtMACAddress.Text + "', [Computer Name]= '" + TxtComputerName.Text + "',[Computer Location] = '" + TxtComputerLocation.Text + "',[Remarks]= '" + TxtRemarks.Text + "' WHERE [Computer ID]= '" + TxtComputerID.Text + "'")

                cmd.ExecuteNonQuery()
                con.Close()

                'Update Click Msg
                MsgBox("Data Updated Successfully", MsgBoxStyle.OkOnly, "Computer Account")

                'Making Clear
                ClearData()


                'Refresh Data
                RefreshData()

                'Show Computer ID
                FrmHome.FindComputerID()

            End If
        Catch ex As Exception
            MessageBox.Show("Error while Updating record on table..." & ex.Message, "Update Records")
        Finally

        End Try

    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click

        'Empty Computer ID Can Not Be Update
        If Me.TxtComputerID.Text = "" Then
            MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Computer Account")

        Else

            'Data Delete Code
            Dim q As MsgBoxResult
            q = MsgBox("Do you really want to Delete the row?", MsgBoxStyle.YesNo, "Computer Account")
            If q = MsgBoxResult.Yes Then

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim currentDate As DateTime = DateTime.Today
                Dim currentTime As DateTime = DateTime.Now
                Try
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "Delete from [Computer Account] where [Computer ID]= '" + TxtComputerID.Text + "'"
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

    Private Sub GrdComputerAccount_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdComputerAccount_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

    End Sub

    Private Sub GrpComputerAccount_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrpComputerAccount.Enter

    End Sub

    Private Sub TxtRemarks_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtRemarks.KeyDown

    End Sub

    Private Sub TxtRemarks_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtRemarks.TextChanged

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

    Private Sub GrdComputerAccount_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdComputerAccount.CellContentClick

    End Sub

    Private Sub GrdComputerAccount_CellMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdComputerAccount.CellMouseClick
        'Data Grid view code
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdComputerAccount.Rows(e.RowIndex)

                TxtComputerID.Text = row.Cells("Computer ID").Value.ToString
                TxtMACAddress.Text = row.Cells("MAC Address").Value.ToString
                TxtComputerName.Text = row.Cells("Computer Name").Value.ToString
                TxtComputerLocation.Text = row.Cells("Computer Location").Value.ToString
                TxtRemarks.Text = row.Cells("Remarks").Value.ToString





            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview")

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