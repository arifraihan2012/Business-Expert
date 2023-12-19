Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmProblemCategory
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point

    Private Sub BtnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click
        Try
            'Focus on Group Name
            TxtProblemCategoryName.Focus()

            'Making Clear
            ClearData()

        Catch ex As Exception
            MessageBox.Show("Error while adding data on table..." & ex.Message, "Add New Button")
        Finally

        End Try
    End Sub
    'Crating Privet Sub for Clear Data
    Sub ClearData()
        Try
            TxtProblemcategoryID.Text = ""
            TxtProblemCategoryName.Text = ""

        Catch ex As Exception
            MessageBox.Show("Error while clearing record on table..." & ex.Message, "Clear Records")
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
            cmd.CommandText = "select top 1 * from [Problem Category] where [User account ID]='" + FrmHome.LblUserID.Text + "' and [Computer ID]='" + FrmHome.LblComputerID.Text + "'  order by [Problem Category ID] desc"
            dr = cmd.ExecuteReader
            dr.Read()

            If dr.HasRows Then

                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd1.CommandText = "INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES ('" + Me.Text + "','INSERT','Problem category ID: " + dr.Item("Problem category ID").ToString + " ,Problem Category Name: " + TxtProblemCategoryName.Text + " ','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + dr.Item("Problem category ID").ToString + "' )"
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
        Dim cmd1 As New SqlCommand
        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now
        Try
            'Same id Twice insert restriction code
            If Not Me.TxtProblemcategoryID.Text = "" Then
                MsgBox("This ID is already Exist.", MsgBoxStyle.OkOnly, "Problem Category")


            Else
                'Empty Txt Box Can Not Be Save Code
                If Me.TxtProblemCategoryName.Text = "" Then
                    MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Problem Category")

                Else

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO [Problem Category] ([Problem Category Name],[User Account ID],[Computer ID],[Current Date],[Current Time],[Branch ID]) VALUES ('" + TxtProblemCategoryName.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "')"
                    cmd.ExecuteNonQuery()
                    con.Close()

                    'Insert into log 
                    InsertIntoLog()

                    'Insert Click Msg
                    MsgBox("Data Inserted Successfully", MsgBoxStyle.OkOnly, "Problem Category")

                    'Making Clear
                    ClearData()



                    'Refresh Data
                    RefreshData()

                    If Application.OpenForms().OfType(Of FrmWarrantyLookUp).Any Then

                        'Load problem Details on warranty look up 
                        FrmWarrantyLookUp.LoadComboBoxProblemDetails()

                    End If


                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally


        End Try

    End Sub
    'Creating Privet Sub for Refresh
    Sub RefreshData()

        ' Load Data
        Try
      

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Problem Category].[Problem Category ID],[Problem Category].[Problem Category Name] FROM [Problem Category]"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Problem Category")
            connection.Close()
            GrdProblemCategory.DataSource = ds
            GrdProblemCategory.DataMember = "BizPro_Problem Category"

            'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdProblemCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill




        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try

        'End Refresh Data
    End Sub

    Private Sub BtnRefrersh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefrersh.Click


        Try
            'Refresh Data
            RefreshData()


        Catch ex As Exception
            MessageBox.Show("Error while refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try


    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click

        'Data Update Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand

        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now
        Try

            'Empty Problem Category ID Can Not Be Update
            If Me.TxtProblemcategoryID.Text = "" Then
                MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Problem Category")


                'Empty Text Box Can Not Be update Code
            ElseIf Me.TxtProblemCategoryName.Text = "" Then
                MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Problem Category")


            Else
                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "UPDATE [Problem Category] SET [Problem Category Name]= '" + TxtProblemCategoryName.Text + "' WHERE [Problem Category ID]= '" + TxtProblemcategoryID.Text + "'   INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES ('" + Me.Text + "','UPDATE','Problem category ID: " + TxtProblemcategoryID.Text + " ,Problem Category Name: " + TxtProblemCategoryName.Text + " ','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtProblemcategoryID.Text + "' )"
                cmd.ExecuteNonQuery()
                con.Close()


                'Update Click Msg
                MsgBox("Data Updated Successfully", MsgBoxStyle.OkOnly, "Problem Category")

                'Making Clear
                ClearData()


                'Refresh Data
                RefreshData()


                If Application.OpenForms().OfType(Of FrmWarrantyLookUp).Any Then

                    'Load problem Details on warranty look up 
                    FrmWarrantyLookUp.LoadComboBoxProblemDetails()

                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Error while Updating record on table..." & ex.Message, "Update Records")
        Finally

        End Try


    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click

        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now

            'Empty Bank ID Can Not Be Delete
            If Me.TxtProblemcategoryID.Text = "" Then
                MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Problem Category")

            Else

                'Data Delete Code
                Dim q As MsgBoxResult
                q = MsgBox("Do you really want to Delete the row?", MsgBoxStyle.YesNo, "Problem Category")
                If q = MsgBoxResult.Yes Then

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "Delete from [Problem Category] where [Problem Category ID]= '" + TxtProblemcategoryID.Text + "'  INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES ('" + Me.Text + "','DELETE','Problem category ID: " + TxtProblemcategoryID.Text + " ,Problem Category Name: " + TxtProblemCategoryName.Text + " ','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtProblemcategoryID.Text + "' )"
                    cmd.ExecuteNonQuery()
                    con.Close()

                    'Making Clear
                    ClearData()


                    'Refresh Data
                    RefreshData()

                    If Application.OpenForms().OfType(Of FrmWarrantyLookUp).Any Then

                        'Load problem Details on warranty look up 
                        FrmWarrantyLookUp.LoadComboBoxProblemDetails()

                    End If

                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Records")
        Finally

        End Try

    End Sub
    Private Sub GrdProblemCategory_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdProblemCategory_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

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

    Private Sub GrdProblemCategory_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdProblemCategory.CellContentClick

    End Sub

    Private Sub GrdProblemCategory_CellMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdProblemCategory.CellMouseClick

        'Grid View Codes
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdProblemCategory.Rows(e.RowIndex)

                TxtProblemcategoryID.Text = row.Cells("Problem Category ID").Value.ToString
                TxtProblemCategoryName.Text = row.Cells("Problem Category Name").Value.ToString




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

    Private Sub FrmProblemCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub
End Class