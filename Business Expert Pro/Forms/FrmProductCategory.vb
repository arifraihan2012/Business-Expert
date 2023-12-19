Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmProductCategory
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point



    Private Sub BtnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)




    End Sub


    'Creating Private Sub For Clear Data
    Sub ClearData()
        Try
            TxtCategoryID.Text = ""
            TxtCategoryName.Text = ""

        Catch ex As Exception
            MessageBox.Show("Error while Clearing record on table..." & ex.Message, "Clear Records")
        Finally

        End Try
    End Sub






    Private Sub CmbSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub CmbSearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    End Sub

    Private Sub CmbSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub TxtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub TxtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnAddNew_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click
        Try
            'Clear Data
            ClearData()

            'Focus Category Name
            TxtCategoryName.Focus()


        Catch ex As Exception
            MessageBox.Show("Error while adding data on table..." & ex.Message, "Add New Button")
        Finally

        End Try
    End Sub
    'Privare Sub For Refreshing Data

    Sub RefreshData()
        Try
            ' Refresh Data
             

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Product Category ID], [Product Category Name] FROM [Product Category]"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Product Category")
            connection.Close()
            GrdProductCategory.DataSource = ds
            GrdProductCategory.DataMember = "BizPro_Product Category"

            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdProductCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            
            'End Refresh Data
        Catch ex As Exception
            MessageBox.Show("Error while refreshing record on table..." & ex.Message, "Refresh Records")
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
            cmd.CommandText = "select top 1 * from [Product Category] where [User account ID]='" + FrmHome.LblUserID.Text + "' and [Computer ID]='" + FrmHome.LblComputerID.Text + "'  order by [Product Category ID] desc"
            dr = cmd.ExecuteReader
            dr.Read()

            If dr.HasRows Then

                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd1.CommandText = "INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES ('" + Me.Text + "','INSERT','Category ID: " + dr.Item("Product Category ID").ToString + " ,Category Name: " + TxtCategoryName.Text + " ','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + dr.Item("Product Category ID").ToString + "' )"
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
        Try


            'Same id Twice insert restriction code
            If Not Me.TxtCategoryID.Text = "" Then
                MsgBox("This ID is already Exist.", MsgBoxStyle.OkOnly, "Product Category")


            Else


                Dim con2 As New SqlConnection
                Dim cmd2 As New SqlCommand
                Dim dr2 As SqlDataReader

                con2.ConnectionString = FrmHome.ConnectionString
                con2.Open()
                cmd2.Connection = con2
                cmd2.CommandText = "SELECT * from [Product Category]  WHERE [Product Category Name] = '" + Me.TxtCategoryName.Text + "'"

                dr2 = cmd2.ExecuteReader()
                dr2.Read()

                If dr2.HasRows Then

                    MsgBox("This Category Name Is Already Exist", MsgBoxStyle.Critical, "Product Category")
                    TxtCategoryName.Focus()

                ElseIf Not dr2.HasRows Then




                    Dim con As New SqlConnection
                    Dim cmd As New SqlCommand




                    'Empty Txt Box Can Not Be Save Code
                    If Me.TxtCategoryName.Text = "" Then
                        MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Product Category")

                    Else
                        con.ConnectionString = FrmHome.ConnectionString
                        con.Open()
                        cmd.Connection = con
                        cmd.CommandText = "INSERT INTO [Product Category] ([Product Category Name],[User Account ID], [Computer ID]) VALUES ('" & TxtCategoryName.Text & "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "')"
                        cmd.ExecuteNonQuery()
                        con.Close()
                        'Insert into log 
                        InsertIntoLog()

                        MsgBox("Data Inserted Successfully", MsgBoxStyle.OkOnly, "Product Category")

                        'Clear data
                        ClearData()

                        'Refresh data
                        RefreshData()

                        'Focus on Category name
                        TxtCategoryName.Focus()

                    End If


                End If

                dr2.Close()
                con2.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally


        End Try
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click

        Try



            Dim con2 As New SqlConnection
            Dim cmd2 As New SqlCommand
            Dim dr2 As SqlDataReader

            Dim CurrentDate As DateTime = DateTime.Today
            Dim CurrentTime As DateTime = DateTime.Now



            con2.ConnectionString = FrmHome.ConnectionString
            con2.Open()
            cmd2.Connection = con2
            cmd2.CommandText = "SELECT * from [Product Category]  WHERE [Product Category Name] = '" + Me.TxtCategoryName.Text + "'"

            dr2 = cmd2.ExecuteReader()
            dr2.Read()

            If dr2.HasRows Then

                MsgBox("This Category Name Is Already Exist", MsgBoxStyle.Critical, "Product Category")
                TxtCategoryName.Focus()

            ElseIf Not dr2.HasRows Then





                'Update Data Code

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand



                'Empty Category ID Can Not Be Update
                If Me.TxtCategoryID.Text = "" Then
                    MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Product Category")

                    'Empty Text Box Can Not Be update Code
                ElseIf Me.TxtCategoryName.Text = "" Then
                    MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Product Category")


                Else
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "UPDATE [Product Category] SET [Product Category Name]= '" + TxtCategoryName.Text + "' WHERE [Product Category ID]= '" + TxtCategoryID.Text + "' INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES ('" + Me.Text + "','UPDATE','Category ID: " + TxtCategoryID.Text + " ,Category Name: " + TxtCategoryName.Text + " ','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtCategoryID.Text + "' )"


                    cmd.ExecuteNonQuery()
                    con.Close()


                    MsgBox("Data Updated Successfully", MsgBoxStyle.OkOnly, "Product Category")

                    'Clear Data
                    ClearData()

                    'Refresh data
                    RefreshData()

                End If



            End If

            dr2.Close()
            con2.Close()


        Catch ex As Exception
            MessageBox.Show("Error while Updating record on table..." & ex.Message, "Update Records")
        Finally

        End Try
    End Sub

    Private Sub GrdProductCategory_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdProductCategory_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        'Empty Product Category Can Not Be Delete
        If Me.TxtCategoryID.Text = "" Then
            MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Product Category")

        Else

            'Delete Data
            Dim q As MsgBoxResult
            q = MsgBox("Do you really want to Delete the row?", MsgBoxStyle.YesNo, "Product Category")
            If q = MsgBoxResult.Yes Then

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand



                Dim CurrentDate As DateTime = DateTime.Today
                Dim CurrentTime As DateTime = DateTime.Now


                Try
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "Delete from [Product Category] where [Product Category ID]= '" + TxtCategoryID.Text + "'  INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES ('" + Me.Text + "','DELETE','Category ID: " + TxtCategoryID.Text + " ,Category Name: " + TxtCategoryName.Text + " ','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtCategoryID.Text + "' )"
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


                Me.TxtCategoryID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtCategoryName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))

                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

                Me.GrdProductCategory.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdProductCategory.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)



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

    Private Sub FrmProductCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       


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

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        'Refresh data
        Try
            RefreshData()

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records Refresh Button")
        Finally

        End Try

    End Sub

    Private Sub TxtCategoryName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCategoryName.KeyDown
        If e.KeyCode = Keys.Enter Then

            BtnInsert.PerformClick()
        End If
    End Sub

    Private Sub TxtCategoryName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCategoryName.TextChanged

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

    Private Sub GrdProductCategory_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdProductCategory.CellContentClick

    End Sub

    Private Sub GrdProductCategory_CellMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdProductCategory.CellMouseClick
        'Grid View Cell Mouse Click Code
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdProductCategory.Rows(e.RowIndex)

                TxtCategoryID.Text = row.Cells("Product Category ID").Value.ToString
                TxtCategoryName.Text = row.Cells("Product Category Name").Value.ToString



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