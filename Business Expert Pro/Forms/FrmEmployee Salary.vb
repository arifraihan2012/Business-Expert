
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class FrmEmployeeSalary
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click

        'Empty Salary ID Can Not Be Update
        If Me.TxtSalaryID.Text = "" Then
            MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Employee Salary")

        Else

            'Data Delete Code
            Dim q As MsgBoxResult
            q = MsgBox("Do you really want to Delete the row?", MsgBoxStyle.YesNo, "Employee Salary")
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
                    cmd.CommandText = "Delete from [Employee Salary] where [Salary ID]= '" + TxtSalaryID.Text + "'"
                    cmd1.CommandText = "INSERT INTO [Log Details] ([Log Category],[Log Description],[User Account ID],[Log Date],[Log Time],[Task ID]) VALUES ('Employee Salary','Data Deleted Successfully [" + CmbEmployeeID.Text + "]','" + FrmHome.LblUserID.Text + "','" + currentDate + "','" + currentTime + "','" + TxtSalaryID.Text + "')"
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

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblPaidAmount.Click

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtRemarks.TextChanged

    End Sub
    'Creating Privet Sub of Clear Data
    Sub ClearData()
        Try
            TxtSalaryID.Text = ""

            CmbEmployeeID.Text = ""
            CmbEmployeeID.ValueMember = ""

            TxtPaidAmount.Text = ""
            TxtDeductionAmount.Text = ""
            DtpPaymentDate.Text = ""
            TxtRemarks.Text = ""
            CmbSearch.Text = ""
            TxtSearch.Text = ""

        Catch ex As Exception
            MessageBox.Show("Error while clearing data on table..." & ex.Message, "Clear Data")
        Finally

        End Try


    End Sub

    Private Sub LblPaymentDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblPaymentDate.Click

    End Sub

    Private Sub BtnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click
        Try

            'Making Clear
            ClearData()



            'Focus on Employee ID
            Me.CmbEmployeeID.Focus()

        Catch ex As Exception
            MessageBox.Show("Error while clearing data  on table..." & ex.Message, "Form Load")
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
            Dim sql As String = "SELECT [Employee Salary].[Salary ID],[Employee Information].[Employee Name],[Employee Salary].[Paid Amount],[Employee Salary].[Deduction Amount],[Employee Salary].[Payment Date],[Employee Salary].[Remarks] From [Employee Salary] Join [Employee Information] On [Employee Salary].[Employee ID]=[Employee Information].[Employee ID]"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Employee Salary")
            connection.Close()
            GrdEmployeeSalary.DataSource = ds
            GrdEmployeeSalary.DataMember = "BizPro_Employee Salary"

            'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdEmployeeSalary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try
        'End Refresh Data
    End Sub

    Private Sub FrmEmployeeSalary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

            Me.TxtSalaryID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.CmbEmployeeID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtPaidAmount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtDeductionAmount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.DtpPaymentDate.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtRemarks.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtSearch.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))

            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            Me.GrdEmployeeSalary.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.GrdEmployeeSalary.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)


            'MsgBox(dr.Item("Language Font"))

            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while changing language on table..." & ex.Message, "Change Language")
        Finally
            con.Close()
        End Try

        'End Language

    End Sub

    Private Sub BtnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        'Data Insert Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now

        Try
            'Same id Twice insert restriction code
            If Not Me.TxtSalaryID.Text = "" Then
                MsgBox("This ID is already Exist.", MsgBoxStyle.OkOnly, "Employee Salary")


            Else
                'Emty Txt Box Can Not Be Save Code
                If Me.CmbEmployeeID.ValueMember = "" Or Me.TxtPaidAmount.Text = "" Then
                    MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Employee Salary")

                Else

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd1.Connection = con
                    cmd.CommandText = "INSERT INTO [Employee Salary] ([Employee ID],[Paid Amount],[Deduction Amount],[Payment Date],[Remarks],[Prepared Time],[Prepared Date],[User Account ID]) VALUES ('" + CmbEmployeeID.ValueMember + "','" + TxtPaidAmount.Text + "','" + TxtDeductionAmount.Text + "','" + DtpPaymentDate.Value + "','" + TxtRemarks.Text + "','" + currentTime + "','" + currentDate + "','" + FrmHome.LblUserID.Text + "')"
                    cmd1.CommandText = "INSERT INTO [Log Details] ([Log Category],[Log Description],[User Account ID],[Log Date],[Log Time],[Task ID]) VALUES ('Employee Salary','Data Inserted Successfully [" + CmbEmployeeID.Text + "]','" + FrmHome.LblUserID.Text + "','" + currentDate + "','" + currentTime + "','New Data Inserted')"
                    cmd.ExecuteNonQuery()
                    cmd1.ExecuteNonQuery()
                    'Insert Click Msg
                    MsgBox("Data Inserted Successfully", MsgBoxStyle.OkOnly, "Employee Salary")
                    'Making Clear
                    ClearData()



                    'Refresh Data
                    RefreshData()


                    'Focus on Bank name text box
                    CmbEmployeeID.Focus()



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
        Dim cmd1 As New SqlCommand
        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now


        Try
            'Empty Salary ID Can Not Be Update
            If Me.TxtSalaryID.Text = "" Then
                MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Employee Salary")

                'Emty Txt Box Can Not Be Save Code
            ElseIf Me.CmbEmployeeID.ValueMember = "" Or Me.TxtPaidAmount.Text = "" Then
                MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Employee Salary")


            Else
                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd1.Connection = con
                cmd.CommandText = "UPDATE [Employee Salary] SET [Employee ID]= '" + CmbEmployeeID.ValueMember + "', [Paid Amount]= '" + TxtPaidAmount.Text + "',[Deduction Amount] = '" + TxtDeductionAmount.Text + "',[Payment Date]= '" + DtpPaymentDate.Value + "',[Remarks]= '" + TxtRemarks.Text + "',[Prepared Time]='" + currentTime + "',[Prepared Date]='" + currentDate + "',[User Account ID]='" + FrmHome.LblUserID.Text + "' WHERE [Salary ID]= '" + TxtSalaryID.Text + "'"
                cmd1.CommandText = "INSERT INTO [Log Details] ([Log Category],[Log Description],[User Account ID],[Log Date],[Log Time],[Task ID]) VALUES ('Employee Salary','Data Updated Successfully [" + CmbEmployeeID.Text + "]','" + FrmHome.LblUserID.Text + "','" + currentDate + "','" + currentTime + "','" + TxtSalaryID.Text + "')"



                cmd.ExecuteNonQuery()
                cmd1.ExecuteNonQuery()


                'Update Click Msg
                MsgBox("Data Updated Successfully", MsgBoxStyle.OkOnly, "Bank Information")

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

    Private Sub GrdEmployeeSalary_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdEmployeeSalary_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

    End Sub

    Private Sub CmbEmployeeID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbEmployeeID.KeyDown
        'Focus on Paid Amount Text Box
        If e.KeyCode = Keys.Enter Then
            Me.TxtPaidAmount.Focus()

        End If

        Try
            If e.KeyCode = Keys.F4 Then

                FrmListofEmployees.Show()
                FrmListofEmployees.TxtSearchEmployee.Focus()
            End If

        Catch ex As Exception
            MessageBox.Show("Error while opening Form on table..." & ex.Message, "Open Form")
        Finally

        End Try
    End Sub

    Private Sub CmbEmployeeID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbEmployeeID.SelectedIndexChanged

    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        'Refresh Data
        Try
            RefreshData()

        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try

    End Sub

    Private Sub TxtPaidAmount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPaidAmount.KeyDown
        'Focus on Deduction Amount Text Box
        If e.KeyCode = Keys.Enter Then
            Me.TxtDeductionAmount.Focus()

        End If
    End Sub

    Private Sub TxtPaidAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPaidAmount.TextChanged

    End Sub

    Private Sub TxtDeductionAmount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDeductionAmount.KeyDown
        'Focus on Payment Date Text Box
        If e.KeyCode = Keys.Enter Then
            Me.DtpPaymentDate.Focus()

        End If
    End Sub

    Private Sub TxtDeductionAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDeductionAmount.TextChanged

    End Sub

    Private Sub DtpPaymentDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DtpPaymentDate.KeyDown
        'Focus on Remarks Text Box
        If e.KeyCode = Keys.Enter Then
            Me.TxtRemarks.Focus()

        End If
    End Sub

    Private Sub DtpPaymentDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtpPaymentDate.ValueChanged

    End Sub

    Private Sub TxtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearch.KeyDown
        Try

            'Search Code
            ' Load Data
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim connectionString As String = FrmHome.ConnectionString
            If Me.CmbSearch.SelectedIndex = 0 Then



                Dim sql As String = "SELECT [Employee Salary].[Salary ID],[Employee Information].[Employee Name],[Employee Salary].[Paid Amount],[Employee Salary].[Deduction Amount],[Employee Salary].[Payment Date],[Employee Salary].[Remarks] From [Employee Salary] Join [Employee Information] On [Employee Salary].[Employee ID]=[Employee Information].[Employee ID] WHERE ([Employee Salary].[Employee ID] LIKE '" + Me.TxtSearch.Text + "')"

                Dim connection As New SqlConnection(connectionString)

                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Employee Salary")
                GrdEmployeeSalary.DataSource = ds
                GrdEmployeeSalary.DataMember = "BizPro_Employee Salary"

                con.Close()



            End If


        Catch ex As Exception
            MessageBox.Show("Error while searching records on table..." & ex.Message, "Search Records KeyDown")
        Finally

        End Try
    End Sub

    Private Sub TxtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearch.TextChanged

    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        Try

            'Search Code
            ' Load Data
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim connectionString As String = FrmHome.ConnectionString
            If Me.CmbSearch.SelectedIndex = 0 Then



                Dim sql As String = "SELECT [Employee Salary].[Salary ID],[Employee Information].[Employee Name],[Employee Salary].[Paid Amount],[Employee Salary].[Deduction Amount],[Employee Salary].[Payment Date],[Employee Salary].[Remarks] From [Employee Salary] Join [Employee Information] On [Employee Salary].[Employee ID]=[Employee Information].[Employee ID] WHERE ([Employee Salary].[Employee ID] = '" + Me.TxtSearch.Text + "')"

                Dim connection As New SqlConnection(connectionString)

                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Employee Salary")
                GrdEmployeeSalary.DataSource = ds
                GrdEmployeeSalary.DataMember = "BizPro_Employee Salary"

                con.Close()

            End If





        Catch ex As Exception
            MessageBox.Show("Error while searching records on table..." & ex.Message, "Search Button")
        Finally

        End Try
    End Sub

    Private Sub CmbSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSearch.SelectedIndexChanged
        'Focus text search box
        TxtSearch.Focus()
    End Sub

    Private Sub Label1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnminimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnmaximized.Click

        Me.Location = New Point(0, 0)
        Me.Size = My.Computer.Screen.WorkingArea.Size


        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal

        Else
            Me.WindowState = FormWindowState.Maximized

        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnclose.Click
        Me.Close()
    End Sub

    Private Sub GrdEmployeeSalary_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdEmployeeSalary.CellContentClick

    End Sub

    Private Sub GrdEmployeeSalary_CellMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdEmployeeSalary.CellMouseClick
        'Grid View Codes
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdEmployeeSalary.Rows(e.RowIndex)

                TxtSalaryID.Text = row.Cells("Salary ID").Value.ToString
                CmbEmployeeID.Text = row.Cells("Employee Name").Value.ToString
                TxtPaidAmount.Text = row.Cells("Paid Amount").Value.ToString
                TxtDeductionAmount.Text = row.Cells("Deduction Amount").Value.ToString
                DtpPaymentDate.Text = row.Cells("Payment Date").Value.ToString
                TxtRemarks.Text = row.Cells("Remarks").Value.ToString


                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim dr As SqlDataReader

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "SELECT  *FROM [Employee Salary]  WHERE [Salary ID] = '" + Me.TxtSalaryID.Text + "'"


                dr = cmd.ExecuteReader()
                dr.Read()



                Me.CmbEmployeeID.ValueMember = (dr.Item("Employee ID").ToString)




                dr.Close()

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