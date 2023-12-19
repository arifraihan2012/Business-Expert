Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmEmployeeCategory

    Private Sub BtnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click
        'Enable Group Box
        GrpEmployeeCategory.Enabled = True
        Try
            'Focus on Group Name
            TxtEmployeeCategoryName.Focus()



            'Making Clear
            ClearData()


        Catch ex As Exception
            MessageBox.Show("Error while adding data on table..." & ex.Message, "Add New Button")
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
            'Empty Customer Category ID Can Not Be Update
            If Me.TxtEmployeeCategoryID.Text = "" Then
                MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Employee Category")

                'Empty Text Box Can Not Be update Code
            ElseIf Me.TxtEmployeeCategoryName.Text = "" Then
                MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Employee Category")


            Else
                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "UPDATE [Employee Category] SET [Employee Category Name]= '" + TxtEmployeeCategoryName.Text + "' WHERE [Employee Category ID]= '" + TxtEmployeeCategoryID.Text + "'  INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES ('" + Me.Text + "','Update','Employee ID: " + TxtEmployeeCategoryID.Text + " ,Employee Name: " + TxtEmployeeCategoryName.Text + " ','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtEmployeeCategoryID.Text + "' )"
                cmd.ExecuteNonQuery()
                con.Close()


                'Update Click Msg
                MsgBox("Data Updated Successfully", MsgBoxStyle.OkOnly, "Customer Category")

                'Making Clear
                ClearData()



                'Refresh Data
                RefreshData()

                'Load Employee category
                FrmEmployeeInformation.LoadComboBoxEmployeeCategory()

            End If

        Catch ex As Exception
            MessageBox.Show("Error while Updating record on table..." & ex.Message, "Update Records")
        Finally

        End Try
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click

        'Empty Customer Category ID Can Not Be Delete
        If Me.TxtEmployeeCategoryID.Text = "" Then
            MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Employee Category")
        Else

            'Data Delete Code
            Dim q As MsgBoxResult
            q = MsgBox("Do you really want to Delete the row?", MsgBoxStyle.YesNo, "Employee Category")
            If q = MsgBoxResult.Yes Then

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand

                Dim currentDate As DateTime = DateTime.Today
                Dim CurrentTime As DateTime = DateTime.Now
                Try
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "Delete from [Employee Category] where [Employee Category ID]= '" + TxtEmployeeCategoryID.Text + "' INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES ('" + Me.Text + "','Update','Employee ID: " + TxtEmployeeCategoryID.Text + " ,Employee Name: " + TxtEmployeeCategoryName.Text + " ','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtEmployeeCategoryID.Text + "' )"
                    cmd.ExecuteNonQuery()
                    con.Close()

                    'Making Clear
                    ClearData()



                    'Refresh Data
                    RefreshData()

                    'Load Employee category
                    FrmEmployeeInformation.LoadComboBoxEmployeeCategory()


                Catch ex As Exception
                    MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Records")
                Finally

                End Try
            End If


        End If
    End Sub
    'Creating Privet Sub of Refreshing Data


    Sub RefreshData()

        Try

            ' Load Data
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Employee Category ID],[Employee Category Name] FROM [Employee Category]"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Employee Category")
            connection.Close()
            GrdEmployeeCategory.DataSource = ds
            GrdEmployeeCategory.DataMember = "BizPro_Employee Category"

            'GrdProductSubcategory.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductSubcategory.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdEmployeeCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            con.Close()

            'End Refresh Data
        Catch ex As Exception
            MessageBox.Show("Error while refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try

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
    Sub ClearData()
        'Making Clear
        TxtEmployeeCategoryID.Text = ""
        TxtEmployeeCategoryName.Text = ""


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
            cmd.CommandText = "select top 1 * from [Employee Category] where [User account ID]='" + FrmHome.LblUserID.Text + "' and [Computer ID]='" + FrmHome.LblComputerID.Text + "'  order by [Employee Category ID] desc"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then



                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd1.CommandText = "INSERT INTO [Log Details]([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID])VALUES('" + Me.Text + "','INSERT','Employee Category ID: " + dr.Item("Employee Category ID").ToString + " , Employee Category Name: " + TxtEmployeeCategoryName.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + dr.Item("Employee Category ID").ToString + "' )"
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

        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now


        Try

            'Same id Twice insert restriction code
            If Not Me.TxtEmployeeCategoryID.Text = "" Then
                MsgBox("This ID is already Exist.", MsgBoxStyle.OkOnly, "Employee Category")


            Else
                'Empty Txt Box Can Not Be Save Code
                If Me.TxtEmployeeCategoryName.Text = "" Then
                    MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Employee Category")

                Else

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO [Employee Category] ([Employee Category Name],[Computer ID],[User Account ID],[Branch ID],[Prepared Date],[Prepared Time]) VALUES ('" + TxtEmployeeCategoryName.Text + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.lblBranchID.Text + "','" + currentDate + "','" + currentTime + "')"
                    cmd.ExecuteNonQuery()
                    con.Close()


                    'Insert into log 
                    InsertIntoLog()

                    'Insert Click Msg
                    MsgBox("Data Inserted Successfully", MsgBoxStyle.OkOnly, "Employee Category")
                    'Making Clear
                    ClearData()


                    'Refresh Data
                    RefreshData()

                    'Load Employee category
                    FrmEmployeeInformation.LoadComboBoxEmployeeCategory()
                End If
            End If


        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally


        End Try
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

    Private Sub FrmEmployeeCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GrdEmployeeCategory_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdEmployeeCategory.CellContentClick

    End Sub

    Private Sub GrdEmployeeCategory_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdEmployeeCategory.CellMouseClick
        'Data Grid view code
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdEmployeeCategory.Rows(e.RowIndex)

                TxtEmployeeCategoryID.Text = row.Cells("Employee Category ID").Value.ToString
                TxtEmployeeCategoryName.Text = row.Cells("Employee Category Name").Value.ToString




            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

        End Try
    End Sub
End Class