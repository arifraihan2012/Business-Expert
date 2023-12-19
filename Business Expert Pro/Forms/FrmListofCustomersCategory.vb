Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmListofCustomersCategory

    Private Sub FrmListofCustomers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Focus on Search Group
        TxtSearchCustomerName.Focus()
        'Refreshing Data
        RefreshData()
        'change Language
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

            Me.TxtSearchCustomerName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)



            Me.GrdListofCustomers.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.GrdListofCustomers.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)


            'MsgBox(dr.Item("Language Font"))

            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            con.Close()
        End Try

        'End Language

    End Sub
    Sub RefreshData()
        Try
            ' Load Data
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT * FROM [Customer Category]"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Customer Category")
            connection.Close()
            GrdListofCustomers.DataSource = ds
            GrdListofCustomers.DataMember = "BizPro_Customer Category"

            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdListofCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            con.Close()

            'End Refresh Data
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally

        End Try

    End Sub

    Private Sub TxtSearchCustomerName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearchCustomerName.KeyDown

        'key Down Code and Enter Press Select code
        If e.KeyCode = Keys.Down Then
            GrdListofCustomers.Focus()

        End If


        If e.KeyCode = Keys.Enter Then



            'Data Grid view code
            Try

                GrdListofCustomers.Focus()
                Dim i As Integer
                i = GrdListofCustomers.CurrentRow.Index

                FrmCustomerInformation.CmbCustomerCategoryID.ValueMember = GrdListofCustomers.Item(0, i).Value
                FrmCustomerInformation.CmbCustomerCategoryID.Text = GrdListofCustomers.Item(1, i).Value
                FrmProductInformation.CmbProductCategoryID.Focus()
                Me.Close()



            Catch ex As Exception
                MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

            End Try


        End If

    End Sub

    Private Sub TxtSearchCustomerName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearchCustomerName.TextChanged


        Try
            ' Load Data
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT  *FROM [Customer Category]  WHERE ([Customer Category Name] LIKE '%" + Me.TxtSearchCustomerName.Text + "%')"


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Customer Category")
            GrdListofCustomers.DataSource = ds
            GrdListofCustomers.DataMember = "BizPro_Customer Category"


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            con.Close()

            'End Refresh Data

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

        End Try

    End Sub

    Private Sub GrdListofCustomers_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdListofCustomers.CellContentClick

    End Sub

    Private Sub GrdListofCustomers_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdListofCustomers.CellMouseDoubleClick

        'Cell Mouse Double Click code
        Try

            Dim i As Integer
            i = GrdListofCustomers.CurrentRow.Index



            FrmCustomerInformation.CmbCustomerCategoryID.ValueMember = GrdListofCustomers.Item(0, i).Value
            FrmCustomerInformation.CmbCustomerCategoryID.Text = GrdListofCustomers.Item(1, i).Value
            FrmProductInformation.CmbProductCategoryID.Focus()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

        End Try




    End Sub

    Private Sub GrdListofCustomers_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdListofCustomers.KeyDown

        'Enter press Focus Grid view and grid view code
        If e.KeyCode = Keys.Enter Then


            Try

                Dim i As Integer
                i = GrdListofCustomers.CurrentRow.Index

                FrmCustomerInformation.CmbCustomerCategoryID.ValueMember = GrdListofCustomers.Item(0, i).Value
                FrmCustomerInformation.CmbCustomerCategoryID.Text = GrdListofCustomers.Item(1, i).Value

                FrmProductInformation.CmbProductCategoryID.Focus()

                Me.Close()

            Catch ex As Exception
                MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

            End Try

        End If

    End Sub

    Private Sub GrdListofCustomers_ParentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdListofCustomers.ParentChanged

    End Sub
End Class