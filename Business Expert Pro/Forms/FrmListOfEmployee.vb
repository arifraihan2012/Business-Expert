Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class FrmListofEmployees

    Private Sub FrmListOfEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            'Focus on Search Group
            Me.TxtSearchEmployee.Focus()
            'Refreshing Data
            RefreshData()

            'ChangeLanguage
            ChangeLanguage()

        Catch ex As Exception
            MessageBox.Show("Error while refreshing record and changing language on table..." & ex.Message, "Form Load")
        Finally

        End Try
    End Sub
    Sub RefreshData()
        Try
            ' Load Data
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Employee Information].[Employee ID],[Employee Information].[Employee Name],[Employee Information].[Gender],[Employee Information].[Department],[Employee Information].[Employee Category],[Employee Information].[Religion],[Branch Information].[Branch Name],[Employee Information].[Basic Salary],[Employee Information].[Mobile Number] From [Employee Information] Join [Branch Information] On [Employee Information].[Branch ID]=[Branch Information].[Branch ID]"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Employee Information")
            connection.Close()
            GrdListOfEmployee.DataSource = ds
            GrdListOfEmployee.DataMember = "BizPro_Employee Information"

            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdListOfEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            'Row Count
            NUmberOfRow()

            con.Close()

            'End Refresh Data

        Catch ex As Exception
            MessageBox.Show("Error while refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try
    End Sub
    Sub NUmberOfRow()

        'Total gridview line show in label code
        Dim total As String = 0

        total = GrdListOfEmployee.Rows.Count

        Me.Label15.Text = total


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

            Me.TxtSearchEmployee.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)



            'MsgBox(dr.Item("Language Font"))

            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            con.Close()
        End Try

        'End Language

    End Sub

    Private Sub TxtSearchEmployee_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearchEmployee.KeyDown
        'Focus on grid view 
        If e.KeyCode = Keys.Down Then
            GrdListOfEmployee.Focus()
        End If

        'On Enter Press Data Select From Grid View Code
        If e.KeyCode = Keys.Enter Then



            'Data Grid view code
            Try

                GrdListOfEmployee.Focus()
                Dim i As Integer
                i = GrdListOfEmployee.CurrentRow.Index

                FrmEmployeeSalary.CmbEmployeeID.ValueMember = GrdListOfEmployee.Item(0, i).Value
                FrmEmployeeSalary.CmbEmployeeID.Text = GrdListOfEmployee.Item(1, i).Value
                FrmEmployeeSalary.TxtPaidAmount.Focus()
                Me.Close()


            Catch ex As Exception
                MessageBox.Show("Error while showing record from table..." & ex.Message, "Search Employee KeyDown")

            End Try


        End If
    End Sub

    Private Sub TxtSearchEmployee_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearchEmployee.TextChanged
        Try
            ' Load Data
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT  *FROM [Employee Information]  WHERE ([Employee Name] LIKE '%" + Me.TxtSearchEmployee.Text + "%')"


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Employee Information")
            GrdListOfEmployee.DataSource = ds
            GrdListOfEmployee.DataMember = "BizPro_Employee Information"


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)


            'Row Count
            NUmberOfRow()

            con.Close()

            'End Refresh Data
        Catch ex As Exception
            MessageBox.Show("Error while searching record from table..." & ex.Message, "Search Employee TextChanged")

        End Try
    End Sub

    Private Sub GrdListOfEmployee_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdListOfEmployee.CellContentClick

    End Sub

    Private Sub GrdListOfEmployee_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdListOfEmployee.CellMouseDoubleClick
        'Data Grid view code
        Try

            GrdListOfEmployee.Focus()
            Dim i As Integer
            i = GrdListOfEmployee.CurrentRow.Index

            FrmEmployeeSalary.CmbEmployeeID.ValueMember = GrdListOfEmployee.Item(0, i).Value
            FrmEmployeeSalary.CmbEmployeeID.Text = GrdListOfEmployee.Item(1, i).Value
            FrmEmployeeSalary.TxtPaidAmount.Focus()
            Me.Close()


        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Gridview Cell Mouse Double Click ")

        End Try
    End Sub

    Private Sub GrdListOfEmployee_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdListOfEmployee.KeyDown
        'On Enter Press Data Select From Grid View Code
        If e.KeyCode = Keys.Enter Then



            'Data Grid view code
            Try

                GrdListOfEmployee.Focus()
                Dim i As Integer
                i = GrdListOfEmployee.CurrentRow.Index

                FrmEmployeeSalary.CmbEmployeeID.ValueMember = GrdListOfEmployee.Item(0, i).Value
                FrmEmployeeSalary.CmbEmployeeID.Text = GrdListOfEmployee.Item(1, i).Value
                FrmEmployeeSalary.TxtPaidAmount.Focus()
                Me.Close()


            Catch ex As Exception
                MessageBox.Show("Error while showing record from table..." & ex.Message, "Gridview Keydown")

            End Try


        End If
    End Sub
End Class
