Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmCustomerCategory
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCustomerCategoryID.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCustomerCategoryName.TextChanged

    End Sub

    Private Sub FrmCustomerCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

       

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
            If dr.HasRows Then


                Me.TxtCustomerCategoryID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtCustomerCategoryName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))

                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

                Me.GrdCustomerCategory.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdCustomerCategory.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)

                'MsgBox(dr.Item("Language Font"))
            End If

            dr.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while changing language on table..." & ex.Message, "Change language")
        Finally
            con.Close()
        End Try

        'End Language

    End Sub

    Private Sub LblEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub BtnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click
        'Enable Group Box
        GrpCustomerCategory.Enabled = True
        Try
            'Focus on Group Name
            TxtCustomerCategoryName.Focus()



            'Making Clear
            ClearData()
        Catch ex As Exception
            MessageBox.Show("Error while adding data on table..." & ex.Message, "Add New Button")
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
            cmd.CommandText = "select top 1 * from [Customer Category] where [User account ID]='" + FrmHome.LblUserID.Text + "' and [Computer ID]='" + FrmHome.LblComputerID.Text + "'  order by [Customer Category ID] desc"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then



                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd1.CommandText = "INSERT INTO [Log Details]([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID])VALUES('" + Me.Text + "','INSERT','Customer Category ID: " + dr.Item("Customer Category ID").ToString + " , Customer Category Name: " + TxtCustomerCategoryName.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + dr.Item("Customer Category ID").ToString + "' )"
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



        'Data Insert Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand


        Try
            'Same id Twice insert restriction code
            If Not Me.TxtCustomerCategoryID.Text = "" Then
                MsgBox("This ID is already Exist.", MsgBoxStyle.OkOnly, "Customer Category")


            Else
                'Empty Txt Box Can Not Be Save Code
                If Me.TxtCustomerCategoryName.Text = "" Then
                    MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Customer Category")

                Else

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO [Customer Category] ([Customer Category Name],[User Account ID],[Computer ID]) VALUES ('" + TxtCustomerCategoryName.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "')"
                    cmd.ExecuteNonQuery()
                    con.Close()


                    'Insert into log 
                    InsertIntoLog()

                    'Insert Click Msg
                    MsgBox("Data Inserted Successfully", MsgBoxStyle.OkOnly, "Customer Category")
                    'Making Clear
                    ClearData()



                    'Refresh Data
                    RefreshData()

                    'Load Customer category
                    FrmCustomerInformation.LoadComboBoxCustomerCategory()
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

        Dim CurrentDate As DateTime = DateTime.Today
        Dim CurrentTime As DateTime = DateTime.Now


        Try
            'Empty Customer Category ID Can Not Be Update
            If Me.TxtCustomerCategoryID.Text = "" Then
                MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Customer Category")

                'Empty Text Box Can Not Be update Code
            ElseIf Me.TxtCustomerCategoryName.Text = "" Then
                MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Customer Category")


            Else
                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "UPDATE [Customer Category] SET [Customer Category Name]= '" + TxtCustomerCategoryName.Text + "' WHERE [Customer Category ID]= '" + TxtCustomerCategoryID.Text + "'   INSERT INTO [Log Details]([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID])VALUES('" + Me.Text + "','UPDATE','Customer Category ID: " + TxtCustomerCategoryID.Text + " , Customer Category Name: " + TxtCustomerCategoryName.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtCustomerCategoryID.Text + "' ) "




                cmd.ExecuteNonQuery()
                con.Close()


                'Update Click Msg
                MsgBox("Data Updated Successfully", MsgBoxStyle.OkOnly, "Customer Category")

                'Making Clear
                ClearData()



                'Refresh Data
                RefreshData()

                'Load Customer category
                FrmCustomerInformation.LoadComboBoxCustomerCategory()

            End If

        Catch ex As Exception
            MessageBox.Show("Error while Updating record on table..." & ex.Message, "Update Records")
        Finally

        End Try
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click

        'Empty Customer Category ID Can Not Be Delete
        If Me.TxtCustomerCategoryID.Text = "" Then
            MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Customer Category")
        Else

            'Data Delete Code
            Dim q As MsgBoxResult
            q = MsgBox("Do you really want to Delete the row?", MsgBoxStyle.YesNo, "Customer Category")
            If q = MsgBoxResult.Yes Then

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand

                Dim CurrentDate As DateTime = DateTime.Today
                Dim CurrentTime As DateTime = DateTime.Now


                Try
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "Delete from [Customer Category] where [Customer Category ID]= '" + TxtCustomerCategoryID.Text + "'  INSERT INTO [Log Details]([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID])VALUES('" + Me.Text + "','DELETE','Customer Category ID: " + TxtCustomerCategoryID.Text + " , Customer Category Name: " + TxtCustomerCategoryName.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtCustomerCategoryID.Text + "' )"

                    cmd.ExecuteNonQuery()
                    con.Close()

                    'Making Clear
                    ClearData()



                    'Refresh Data
                    RefreshData()

                    'Load Customer category
                    FrmCustomerInformation.LoadComboBoxCustomerCategory()


                Catch ex As Exception
                    MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Records")
                Finally

                End Try
            End If


        End If
    End Sub

    Private Sub GrdCustomerCategory_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub
    Sub ClearData()
        'Making Clear
        TxtCustomerCategoryID.Text = ""
        TxtCustomerCategoryName.Text = ""


    End Sub
    'Creating Privet Sub of Refreshing Data


    Sub RefreshData()

        Try

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Customer Category ID],[Customer Category Name] FROM [Customer Category]"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Customer Category")
            connection.Close()
            GrdCustomerCategory.DataSource = ds
            GrdCustomerCategory.DataMember = "BizPro_Customer Category"

            'GrdProductSubcategory.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductSubcategory.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdCustomerCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


            'End Refresh Data
        Catch ex As Exception
            MessageBox.Show("Error while refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try

    End Sub


    Private Sub GrdCustomerCategory_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

    End Sub

    Private Sub TxtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then
            Me.GrpCustomerCategory.Enabled = True
            'Foucs on Subcategory Name
            Me.TxtCustomerCategoryName.Focus()
        End If
    End Sub

    Private Sub TxtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CmbSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub CmbSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Enable Group Box
        GrpCustomerCategory.Enabled = True
    End Sub

    Private Sub GrdCustomerCategory_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdCustomerCategory.CellContentClick

    End Sub

    Private Sub GrdCustomerCategory_CellMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdCustomerCategory.CellMouseClick
        'Data Grid view code
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdCustomerCategory.Rows(e.RowIndex)

                TxtCustomerCategoryID.Text = row.Cells("Customer Category ID").Value.ToString
                TxtCustomerCategoryName.Text = row.Cells("Customer Category Name").Value.ToString




            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

        End Try
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