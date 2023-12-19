Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmListofLocations

    Private Sub FrmListofLocations_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        'Refreshing Data
        RefreshData()


        'Change language
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

            Me.TxtSearchLocation.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            Me.GrdListofLocations.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.GrdListofLocations.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)


            'MsgBox(dr.Item("Language Font"))

            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            con.Close()
        End Try

        'End Language

    End Sub
    'Private Sub For Refresh Data

    Sub RefreshData()
        Try
            ' Load Data
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Location Information].[Location ID], [Branch Information].[Branch Name],[Location Information].[Location Name]  FROM [Location Information] join [Branch Information] on [Location Information].[Branch ID] = [Branch Information].[Branch ID]"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Location Information")
            connection.Close()
            GrdListofLocations.DataSource = ds
            GrdListofLocations.DataMember = "BizPro_Location Information"

            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdListofLocations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            con.Close()


        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally

        End Try
        'End Refresh Data
    End Sub

    Private Sub TxtSearchLocation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearchLocation.KeyDown


        'Focus on Grid view
        If e.KeyCode = Keys.Down Then
            GrdListofLocations.Focus()

        End If
        'Enter on Focus Grid view and Enter Grid View code
        If e.KeyCode = Keys.Enter Then

            'Data Grid view code
            Try


                Dim i As Integer
                i = GrdListofLocations.CurrentRow.Index

                FrmPurchase.CmbLocationID.ValueMember = GrdListofLocations.Item(0, i).Value
                FrmPurchase.CmbLocationID.Text = GrdListofLocations.Item(2, i).Value
                FrmPurchase.TxtQuantity.Focus()
                Me.Close()



            Catch ex As Exception
                MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

            End Try

        End If


    End Sub

    Private Sub TxtSearchLocation_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearchLocation.TextChanged
        'Search Code
        ' Load Data
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand


        Dim connectionString As String = FrmHome.ConnectionString
        Dim sql As String = "SELECT [Location Information].[Location ID], [Branch Information].[Branch Name],[Location Information].[Location Name]  FROM [Location Information] join [Branch Information] on [Location Information].[Branch ID] = [Branch Information].[Branch ID]  WHERE ([Location Information].[Location Name] LIKE '%" + Me.TxtSearchLocation.Text + "%')"


        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "BizPro_Location Information")
        GrdListofLocations.DataSource = ds
        GrdListofLocations.DataMember = "BizPro_Location Information"


        'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
        'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

        con.Close()

        'End Refresh Data
    End Sub

    Private Sub GrdListofLocations_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdListofLocations.CellContentClick

    End Sub

    Private Sub GrdListofLocations_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdListofLocations.CellMouseDoubleClick
        'Data Grid view code
        Try

            Dim i As Integer
            i = GrdListofLocations.CurrentRow.Index

            FrmPurchase.CmbLocationID.ValueMember = GrdListofLocations.Item(0, i).Value
            FrmPurchase.CmbLocationID.Text = GrdListofLocations.Item(2, i).Value
            FrmPurchase.TxtQuantity.Focus()
            Me.Close()


        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

        End Try
    End Sub

    Private Sub GrdListofLocations_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdListofLocations.KeyDown
        'Enter on Focus Grid view and Enter Grid View code
        If e.KeyCode = Keys.Enter Then

            'Data Grid view code
            Try




                Dim i As Integer
                i = GrdListofLocations.CurrentRow.Index

                FrmPurchase.CmbLocationID.ValueMember = GrdListofLocations.Item(0, i).Value
                FrmPurchase.CmbLocationID.Text = GrdListofLocations.Item(2, i).Value
                FrmPurchase.TxtQuantity.Focus()
                Me.Close()



            Catch ex As Exception
                MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

            End Try

        End If


    End Sub
End Class