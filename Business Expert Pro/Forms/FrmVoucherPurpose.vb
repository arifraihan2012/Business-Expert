Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class FrmVoucherPurpose

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    'Crating Privet Sub for Clear Data
    Sub ClearData()
        Try
            TxtVoucherPurposeID.Text = ""
            TxtVoucherPurposeName.Text = ""

        Catch ex As Exception
            MessageBox.Show("Error while Clearing language on table..." & ex.Message, "Clear Data")

        End Try

    End Sub

    'Crating Privet Sub for Clear Data
    Sub RefreshData()
        Try
            ' Load Data
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT * FROM [Voucher Purpose]"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "Shonchoy_Voucher Purpose")
            connection.Close()
            GrdVoucherPurpose.DataSource = ds
            GrdVoucherPurpose.DataMember = "Shonchoy_Voucher Purpose"

            'GrdProductGroup.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductGroup.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdVoucherPurpose.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            con.Close()

            'End Refresh Data
        Catch ex As Exception
            MessageBox.Show("Error while changing language on table..." & ex.Message, "Refresh Data")

        End Try


    End Sub

    Private Sub ExpensePurpose_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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




        'Change Language
        ChangeLanguage()



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

            Me.TxtVoucherPurposeID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtVoucherPurposeName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))

            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            Me.GrdVoucherPurpose.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.GrdVoucherPurpose.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)


            'MsgBox(dr.Item("Language Font"))

            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while changing language on table..." & ex.Message, "Change Language")
        Finally
            con.Close()
        End Try

        'End Language

    End Sub






    Private Sub BtnAddNew_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click
        Try
            'Focus on Group Name
            TxtVoucherPurposeName.Focus()



            'Making Clear
            ClearData()

        Catch ex As Exception
            MessageBox.Show("Error while clearing data on table..." & ex.Message, "Add New Button")
        Finally

        End Try
    End Sub

    Private Sub BtnInsert_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click


        Try


            'Same id Twice insert restriction code
            If Not Me.TxtVoucherPurposeID.Text = "" Then
                MsgBox("This ID is already Exist.", MsgBoxStyle.OkOnly, "Voucher Purpose")


            Else


                Dim con2 As New SqlConnection
                Dim cmd2 As New SqlCommand
                Dim dr2 As SqlDataReader

                con2.ConnectionString = FrmHome.ConnectionString
                con2.Open()
                cmd2.Connection = con2
                cmd2.CommandText = "SELECT * from [Voucher Purpose]  WHERE [Voucher Purpose Name] = '" + Me.TxtVoucherPurposeName.Text + "'"

                dr2 = cmd2.ExecuteReader()
                dr2.Read()

                If dr2.HasRows Then

                    MsgBox("This Purpose Name Is Already Exist", MsgBoxStyle.Critical, "Voucher Purpose")
                    TxtVoucherPurposeName.Focus()

                ElseIf Not dr2.HasRows Then







                    'Data Insert Code
                    Dim con As New SqlConnection
                    Dim cmd As New SqlCommand
                    Dim cmd1 As New SqlCommand
                    Dim currentDate As DateTime = DateTime.Today
                    Dim currentTime As DateTime = DateTime.Now



                    'Empty Txt Box Can Not Be Save Code
                    If Me.TxtVoucherPurposeName.Text = "" Then
                        MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Voucher Purpose")

                    Else
                        con.ConnectionString = FrmHome.ConnectionString
                        con.Open()
                        cmd.Connection = con
                        cmd1.Connection = con
                        cmd.CommandText = "INSERT INTO [Voucher Purpose] ([Voucher Purpose Name]) VALUES ('" + TxtVoucherPurposeName.Text + "')"
                        cmd1.CommandText = "INSERT INTO [Log Details] ([Log Category],[Log Description],[User Account ID],[Log Date],[Log Time],[Task ID]) VALUES ('Voucher Purpose','Data Inserted Successfully [" + TxtVoucherPurposeName.Text + "]','" + FrmHome.LblUserID.Text + "','" + currentDate + "','" + currentTime + "','New Data Inserted')"
                        cmd.ExecuteNonQuery()
                        cmd1.ExecuteNonQuery()


                        'Inserted Click Msg
                        MsgBox("Data Inserted Successfully", MsgBoxStyle.OkOnly, "Voucher Purpose")

                        'Making Clear
                        ClearData()


                        'Refresh Data
                        RefreshData()

                        'Focus on Bank name text box
                        TxtVoucherPurposeName.Focus()


                    End If
                    con.Close()
                    dr2.Close()
                End If
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

            con2.ConnectionString = FrmHome.ConnectionString
            con2.Open()
            cmd2.Connection = con2
            cmd2.CommandText = "SELECT * from [Voucher Purpose]  WHERE [Voucher Purpose Name] = '" + Me.TxtVoucherPurposeName.Text + "'"

            dr2 = cmd2.ExecuteReader()
            dr2.Read()

            If dr2.HasRows Then

                MsgBox("This Purpose Name Is Already Exist", MsgBoxStyle.Critical, "Voucher Purpose")
                TxtVoucherPurposeName.Focus()

            ElseIf Not dr2.HasRows Then








                'Data Update Code
                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim cmd1 As New SqlCommand
                Dim currentDate As DateTime = DateTime.Today
                Dim currentTime As DateTime = DateTime.Now



                'Empty Voucher PurposeID Can Not Be Update
                If Me.TxtVoucherPurposeID.Text = "" Then
                    MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Voucher Purpose")

                    'Empty Txt Box Can Not Be Save Code
                ElseIf Me.TxtVoucherPurposeName.Text = "" Then
                    MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Voucher Purpose")

                Else
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd1.Connection = con
                    cmd.CommandText = "UPDATE [Voucher Purpose] SET [Voucher Purpose Name]= '" + TxtVoucherPurposeName.Text + "' WHERE [Voucher Purpose ID]= '" + TxtVoucherPurposeID.Text + "'"
                    cmd1.CommandText = "INSERT INTO [Log Details] ([Log Category],[Log Description],[User Account ID],[Log Date],[Log Time],[Task ID]) VALUES ('Voucher Purpose','Data Updated Successfully [" + TxtVoucherPurposeName.Text + "]','" + FrmHome.LblUserID.Text + "','" + currentDate + "','" + currentTime + "','" + TxtVoucherPurposeID.Text + "')"



                    cmd.ExecuteNonQuery()
                    cmd1.ExecuteNonQuery()


                    'Update Click Msg
                    MsgBox("Data Updated Successfully", MsgBoxStyle.OkOnly, "Voucher Purpose")

                    'Making Clear
                    ClearData()

                    'Refresh Data
                    RefreshData()



                End If
                con.Close()
                dr2.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Error while Updating record on table..." & ex.Message, "Update Records")
        Finally

        End Try
    End Sub

    Private Sub BtnDelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        'Empty Voucher PurposeID Can Not Be Update
        If Me.TxtVoucherPurposeID.Text = "" Then
            MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Voucher Purpose")

        Else


            'Data Delete Code
            Dim q As MsgBoxResult
            q = MsgBox("Do you really want to Delete the row?", MsgBoxStyle.YesNo, "Voucher Purpose")
            If q = MsgBoxResult.Yes Then

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim cmd1 As New SqlCommand
                Dim currentDate As DateTime = DateTime.Today
                Dim currentTime As DateTime = DateTime.Now
                Try
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd1.Connection = con
                    cmd.CommandText = "Delete from [Voucher Purpose] where [Voucher Purpose ID]= '" + TxtVoucherPurposeID.Text + "'"
                    cmd1.CommandText = "INSERT INTO [Log Details] ([Log Category],[Log Description],[User Account ID],[Log Date],[Log Time],[Task ID]) VALUES ('Voucher Purpose','Data Deleted Successfully [" + TxtVoucherPurposeName.Text + "]','" + FrmHome.LblUserID.Text + "','" + currentDate + "','" + currentTime + "','" + TxtVoucherPurposeID.Text + "')"
                    cmd.ExecuteNonQuery()
                    cmd1.ExecuteNonQuery()


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
            MessageBox.Show("Error while refreshing record on table..." & ex.Message, "Refresh Button")
        Finally

        End Try

    End Sub

    Private Sub GrdExpensePurpose_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdVoucherPurpose.CellContentClick

    End Sub

    Private Sub GrdExpensePurpose_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdVoucherPurpose.CellMouseClick
        'Data Grid view code
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdVoucherPurpose.Rows(e.RowIndex)

                TxtVoucherPurposeID.Text = row.Cells("Voucher Purpose ID").Value.ToString
                TxtVoucherPurposeName.Text = row.Cells("Voucher Purpose Name").Value.ToString




            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview")

        End Try
    End Sub

    Private Sub TxtVoucherPurposeName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtVoucherPurposeName.KeyDown
        If e.KeyCode = Keys.Enter Then

            BtnSave.PerformClick()
        End If
    End Sub

    Private Sub TxtVoucherPurposeName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtVoucherPurposeName.TextChanged

    End Sub
End Class

