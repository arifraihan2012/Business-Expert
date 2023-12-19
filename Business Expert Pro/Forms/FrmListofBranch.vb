Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmListofBranches

    Private Sub FrmListofBranches_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TxtSearchBranchName.Focus()
        'Refreshing Data
        RefreshData()

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

            Me.TxtSearchBranchName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            Me.GrdListofBranches.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.GrdListofBranches.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)


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
            Dim sql As String = "SELECT * FROM [Branch Information]"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Branch Information")
            connection.Close()
            GrdListofBranches.DataSource = ds
            GrdListofBranches.DataMember = "BizPro_Branch Information"

            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdListofBranches.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            con.Close()

            'End Refresh Data

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally

        End Try
    End Sub

    Private Sub TxtSearchBranchName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearchBranchName.KeyDown
        'Focus on  list of Branch Grid view
        If e.KeyCode = Keys.Down Then
            GrdListofBranches.Focus()

        End If
        'On Enter Press Data Select From Grid View Code
        If e.KeyCode = Keys.Enter Then
            Try

                Dim i As Integer
                i = GrdListofBranches.CurrentRow.Index

                If Me.Label1.Text = "Company Details" Then

                    FrmCompanyDetails.CmbBranchID.ValueMember = GrdListofBranches.Item(0, i).Value
                    FrmCompanyDetails.CmbBranchID.Text = GrdListofBranches.Item(1, i).Value
                    FrmCompanyDetails.TxtContactNo.Focus()
                    Me.Close()

                    'ElseIf Me.Label1.Text = "Stock Information" Then

                    'FrmStockInformation.CmbBranchID.ValueMember = GrdListofBranches.Item(0, i).Value
                    'FrmStockInformation.CmbBranchID.Text = GrdListofBranches.Item(1, i).Value
                    'FrmStockInformation.CmbLocationID.Focus()
                    'Me.Close()

                ElseIf Me.Label1.Text = "User Account" Then

                    FrmUserAccount.cmbBranchID.ValueMember = GrdListofBranches.Item(0, i).Value
                    FrmUserAccount.cmbBranchID.Text = GrdListofBranches.Item(1, i).Value
                    FrmUserAccount.CmbEmployeeID.Focus()
                    Me.Close()

                ElseIf Me.Label1.Text = "Location Information" Then

                    FrmLocationInformation.CmbBranchID.ValueMember = GrdListofBranches.Item(0, i).Value
                    FrmLocationInformation.CmbBranchID.Text = GrdListofBranches.Item(1, i).Value
                    FrmLocationInformation.TxtLocationName.Focus()
                    Me.Close()



                End If


            Catch ex As Exception
                MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

            End Try


        End If

    End Sub

    Private Sub TxtSearchBranchName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearchBranchName.TextChanged

        'Search Code
        ' Load Data
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand


        Dim connectionString As String = FrmHome.ConnectionString
        Dim sql As String = "SELECT  *FROM [Branch Information]  WHERE ([Branch Name] LIKE '%" + Me.TxtSearchBranchName.Text + "%')"


        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "BizPro_Branch Information")
        GrdListofBranches.DataSource = ds
        GrdListofBranches.DataMember = "BizPro_Branch Information"


        'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
        'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

        con.Close()

        ''End Refresh Data
    End Sub

    Private Sub GrdListofBranches_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdListofBranches.CellContentClick

    End Sub

    Private Sub GrdListofBranches_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdListofBranches.CellMouseDoubleClick

        'Cell Mouse Double click Code
        Try

            Dim i As Integer
            i = GrdListofBranches.CurrentRow.Index

            If Me.Label1.Text = "Company Details" Then

                FrmCompanyDetails.CmbBranchID.ValueMember = GrdListofBranches.Item(0, i).Value
                FrmCompanyDetails.CmbBranchID.Text = GrdListofBranches.Item(1, i).Value
                FrmCompanyDetails.TxtContactNo.Focus()
                Me.Close()

                'ElseIf Me.Label1.Text = "Stock Information" Then

                'FrmStockInformation.CmbBranchID.ValueMember = GrdListofBranches.Item(0, i).Value
                'FrmStockInformation.CmbBranchID.Text = GrdListofBranches.Item(1, i).Value
                'FrmStockInformation.CmbLocationID.Focus()
                'Me.Close()

            ElseIf Me.Label1.Text = "User Account" Then

                FrmUserAccount.CmbBranchID.ValueMember = GrdListofBranches.Item(0, i).Value
                FrmUserAccount.CmbBranchID.Text = GrdListofBranches.Item(1, i).Value
                FrmUserAccount.CmbEmployeeID.Focus()
                Me.Close()

            ElseIf Me.Label1.Text = "Location Information" Then

                FrmLocationInformation.CmbBranchID.ValueMember = GrdListofBranches.Item(0, i).Value
                FrmLocationInformation.CmbBranchID.Text = GrdListofBranches.Item(1, i).Value
                FrmLocationInformation.TxtLocationName.Focus()
                Me.Close()



            End If


        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

        End Try




    End Sub

    Private Sub GrdListofBranches_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdListofBranches.KeyDown
        If e.KeyCode = Keys.Enter Then


            'Data Grid view code
            Try

                Dim i As Integer
                i = GrdListofBranches.CurrentRow.Index

                If Me.Label1.Text = "Company Details" Then

                    FrmCompanyDetails.CmbBranchID.ValueMember = GrdListofBranches.Item(0, i).Value
                    FrmCompanyDetails.CmbBranchID.Text = GrdListofBranches.Item(1, i).Value
                    FrmCompanyDetails.TxtContactNo.Focus()
                    Me.Close()

                    'ElseIf Me.Label1.Text = "Stock Information" Then

                    'FrmStockInformation.CmbBranchID.ValueMember = GrdListofBranches.Item(0, i).Value
                    'FrmStockInformation.CmbBranchID.Text = GrdListofBranches.Item(1, i).Value
                    'FrmStockInformation.CmbLocationID.Focus()
                    'Me.Close()

                ElseIf Me.Label1.Text = "User Account" Then

                    FrmUserAccount.CmbBranchID.ValueMember = GrdListofBranches.Item(0, i).Value
                    FrmUserAccount.CmbBranchID.Text = GrdListofBranches.Item(1, i).Value
                    FrmUserAccount.CmbEmployeeID.Focus()
                    Me.Close()

                ElseIf Me.Label1.Text = "Location Information" Then

                    FrmLocationInformation.CmbBranchID.ValueMember = GrdListofBranches.Item(0, i).Value
                    FrmLocationInformation.CmbBranchID.Text = GrdListofBranches.Item(1, i).Value
                    FrmLocationInformation.TxtLocationName.Focus()
                    Me.Close()


                End If


            Catch ex As Exception
                MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

            End Try

        End If

    End Sub
End Class