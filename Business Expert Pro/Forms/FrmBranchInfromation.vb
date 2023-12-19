Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmBranchInformation
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point

    Private Sub GrdBranchInformation_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)



    End Sub

    Private Sub TxtBranchName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBranchName.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TxtBranchManager.Focus()

        End If
    End Sub

    Private Sub TxtBranchName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBranchName.TextChanged

    End Sub

    Private Sub FrmBranchInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        



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




        'Focus on Branch Name
        TxtBranchName.Focus()






        'ChangeLanguage
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



            Me.TxtBranchID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtBranchName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtBranchManager.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtBranchAddress.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtBranchPhoneNo.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)



            Me.GrdBranchInformation.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)



            'MsgBox(dr.Item("Language Font"))
            dr.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while changing language record on table..." & ex.Message, "Change Language")
        Finally

        End Try

        'End Language

    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)




    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Eneble Group Box
        GrpBranchInformation.Enabled = True

    End Sub

    Private Sub BtnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtBranchID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBranchID.TextChanged

    End Sub

    Private Sub TxtBranchManager_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBranchManager.KeyDown
        'Focus on Branch Adress
        If e.KeyCode = Keys.Enter Then
            Me.TxtBranchAddress.Focus()

        End If
    End Sub

    Private Sub TxtBranchManager_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TxtBranchManager.MouseDoubleClick

    End Sub

    Private Sub TxtBranchManager_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBranchManager.TextChanged

    End Sub

    Private Sub TxtBranchAddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBranchAddress.KeyDown
        ' Focus on Branch Phone No
        If e.KeyCode = Keys.Enter Then
            Me.TxtBranchPhoneNo.Focus()

        End If
    End Sub

    Private Sub TxtBranchAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBranchAddress.TextChanged

    End Sub

    Private Sub CmbSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)



    End Sub

    Private Sub CmbSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)





    End Sub

    'Creating Privet Sub for Refresh
    Sub RefreshData()


        Try
            

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT * FROM [Branch Information]"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Branch Information")
            connection.Close()
            GrdBranchInformation.DataSource = ds
            GrdBranchInformation.DataMember = "BizPro_Branch Information"

            'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdBranchInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


        Catch ex As Exception
            MessageBox.Show("Error while refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try

        'End Refresh Data
    End Sub

    'Creating Privet Sub of Clear Data
    Sub ClearData()
        Try
            TxtBranchID.Text = ""
            TxtBranchName.Text = ""
            TxtBranchManager.Text = ""
            TxtBranchAddress.Text = ""
            TxtBranchPhoneNo.Text = ""


        Catch ex As Exception
            MessageBox.Show("Error while clearing record on table..." & ex.Message, "Clear Records")
        Finally

        End Try
    End Sub


    Private Sub TxtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'Eneble Group Box
        If e.KeyCode = Keys.Enter Then
            GrpBranchInformation.Enabled = True

        End If
    End Sub

    Private Sub TxtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnUpdate_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        'Data Update Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now

        Try


            'Empty textbox restriction code
            If Me.TxtBranchID.Text = "" Then
                MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Branch Information")

                'Empty Text Box Can Not Be update Code
            ElseIf Me.TxtBranchName.Text = "" Or Me.TxtBranchPhoneNo.Text = "" Then
                MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Branch Information")

            Else
                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "UPDATE [Branch Information] SET [Branch Name]= '" + TxtBranchName.Text + "', [Branch Manager]= '" + TxtBranchManager.Text + "',[Branch Address] = '" + TxtBranchAddress.Text + "',[Branch Phone No]= '" + TxtBranchPhoneNo.Text + "' WHERE [Branch ID]= '" + TxtBranchID.Text + "'    INSERT INTO [Log Details]   ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES('" + Me.Text + "','UPDATE',     'Branch ID: " + TxtBranchID.Text + " , Branch Name: " + TxtBranchName.Text + " , Branch Manager: " + TxtBranchManager.Text + ",  Branch Address: " + TxtBranchAddress.Text + " , Branch Phone No: " + TxtBranchPhoneNo.Text + "'   ,'" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtBranchID.Text + "' )"




                cmd.ExecuteNonQuery()



                'Update Click Msg
                MsgBox("Data Updated Successfully", MsgBoxStyle.OkOnly, "Branch Information")

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

    Private Sub BtnAddNew_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click
        'Eneble Group Box
        Me.GrpBranchInformation.Enabled = True
        Try
            'Making Clear
            ClearData()

            'Focus on Transaction Date
            Me.TxtBranchName.Focus()
        Catch ex As Exception
            MessageBox.Show("Error while adding data on table..." & ex.Message, "Add New Button")
        Finally

        End Try
    End Sub

    'Insert into log code
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
            cmd.CommandText = "select top 1 * from [Branch Information] where [User account ID]='" + FrmHome.LblUserID.Text + "' and [Computer ID]='" + FrmHome.LblComputerID.Text + "'  order by [Branch Id] desc"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then



                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd1.CommandText = "INSERT INTO [Log Details]   ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES('" + Me.Text + "','INSERT',     'Branch ID: " + dr.Item("Branch ID").ToString + " , Branch Name: " + dr.Item("Branch Name").ToString + " , Branch Manager: " + dr.Item("Branch Manager").ToString + ",  Branch Address: " + dr.Item("Branch Address").ToString + " , Branch Phone No: " + dr.Item("Branch Phone No").ToString + "'   ,'" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + dr.Item("Branch ID").ToString + "' )"
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
        'Data Insert Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        Try

            'Same id Twice insert restriction code
            If Not Me.TxtBranchID.Text = "" Then
                MsgBox("This ID is already Exist.", MsgBoxStyle.OkOnly, "Branch Information")


            Else
                'Empty Txt Box Can Not Be Save Code
                If Me.TxtBranchName.Text = "" Or Me.TxtBranchPhoneNo.Text = "" Then
                    MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Branch Information")

                Else

                    If GrdBranchInformation.Rows.Count = 8 Then
                        MsgBox("You do not have permission to add more then 8 branch.", MsgBoxStyle.Critical, "Branch Information")
                    Else
                        con.ConnectionString = FrmHome.ConnectionString
                        con.Open()
                        cmd.Connection = con
                        cmd.CommandText = "INSERT INTO [Branch Information] ([Branch Name],[Branch Manager],[Branch Address],[Branch Phone No],[User Account ID],[Computer ID]) VALUES ('" + TxtBranchName.Text + "','" + TxtBranchManager.Text + "','" + TxtBranchAddress.Text + "','" + TxtBranchPhoneNo.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "')"
                        cmd.ExecuteNonQuery()
                        con.Close()
                        'Insert into log code
                        InsertIntoLog()

                        'Insert Click Msg
                        MsgBox("Data Inserted Successfully", MsgBoxStyle.OkOnly, "Branch Information")
                        'Making Clear
                        ClearData()



                        'Refresh Data
                        RefreshData()
                    End If
                End If
            End If


        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally


        End Try



    End Sub

    Private Sub BtnDelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click

        'Empty Bank Transaction ID Can Not Be Update
        If Me.TxtBranchID.Text = "" Then
            MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Branch Information")

        Else


            'Data Delete Code
            Dim q As MsgBoxResult
            q = MsgBox("Do you really want to Delete the row?", MsgBoxStyle.YesNo, "Branch Information")
            If q = MsgBoxResult.Yes Then

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand

                Dim CurrentDate As DateTime = DateTime.Today
                Dim CurrentTime As DateTime = DateTime.Now



                Try
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "Delete from [Branch Information] where [Branch ID]= '" + TxtBranchID.Text + "'  INSERT INTO [Log Details]   ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES('" + Me.Text + "','DELETE',     'Branch ID: " + TxtBranchID.Text + " , Branch Name: " + TxtBranchName.Text + " , Branch Manager: " + TxtBranchManager.Text + ",  Branch Address: " + TxtBranchAddress.Text + " , Branch Phone No: " + TxtBranchPhoneNo.Text + "'   ,'" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtBranchID.Text + "' )"
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

    Private Sub GrdBranchInformation_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        'Refresh Data
        Try
            RefreshData()

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records Refresh Button")
        Finally

        End Try
    End Sub

    Private Sub PnlBranchInformation_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PnlBranchInformation.Paint

    End Sub

    Private Sub BtnSearch_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnminimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnmaximized.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal

        Else
            Me.Location = New Point(0, 0)
            Me.Size = My.Computer.Screen.WorkingArea.Size

        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnclose.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdBranchInformation.CellContentClick

    End Sub

    Private Sub GrdBranchInformation_CellMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdBranchInformation.CellMouseClick
        'Grid View Codes
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdBranchInformation.Rows(e.RowIndex)

                TxtBranchID.Text = row.Cells("Branch ID").Value.ToString
                TxtBranchName.Text = row.Cells("Branch Name").Value.ToString
                TxtBranchManager.Text = row.Cells("Branch Manager").Value.ToString
                TxtBranchAddress.Text = row.Cells("Branch Address").Value.ToString
                TxtBranchPhoneNo.Text = row.Cells("Branch Phone No").Value.ToString



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