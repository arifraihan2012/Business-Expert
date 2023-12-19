Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class FrmListofBank

    Private Sub FrmListofBank_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            'Focus on Search Group
            Me.TxtSearchBank.Focus()

            'Refreshing Data
            RefreshData()

            'ChangeLanguage
            ChangeLanguage()

        Catch ex As Exception
            MessageBox.Show("Error while changing language or refreshing   record on table..." & ex.Message, "Form Load")
        Finally

        End Try

    End Sub
    Sub RefreshData()
        Try
            ' Load Data
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT * FROM [Bank Information]"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "Bizpro_Bank Information")
            connection.Close()
            GrdListofBank.DataSource = ds
            GrdListofBank.DataMember = "Bizpro_Bank Information"

            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdListofBank.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            con.Close()

            'End Refresh Data

        Catch ex As Exception
            MessageBox.Show("Error while refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try
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

            Me.TxtSearchBank.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)



            'MsgBox(dr.Item("Language Font"))

            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally

        End Try

        'End Language

    End Sub

    Private Sub TxtSearchBank_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearchBank.KeyDown

        'Focus on grid view 
        If e.KeyCode = Keys.Down Then
            GrdListofBank.Focus()
        End If

        'On Enter Press Data Select From Grid View Code
        If e.KeyCode = Keys.Enter Then



            'Data Grid view code
            Try

                GrdListofBank.Focus()
                Dim i As Integer
                i = GrdListofBank.CurrentRow.Index

                FrmBankTransaction.CmbBankID.ValueMember = GrdListofBank.Item(0, i).Value
                FrmBankTransaction.CmbBankID.Text = GrdListofBank.Item(1, i).Value
                FrmBankTransaction.TxtDebitedAmount.Focus()
                Me.Close()


            Catch ex As Exception
                MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

            End Try


        End If
    End Sub

    Private Sub TxtSearchBank_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearchBank.TextChanged
        Try
            ' Load Data
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT  *FROM [Bank Information]  WHERE ([Bank Name] LIKE '%" + Me.TxtSearchBank.Text + "%')"


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "Bizpro_Bank Information")
            GrdListofBank.DataSource = ds
            GrdListofBank.DataMember = "Bizpro_Bank Information"


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            con.Close()

            'End Refresh Data
        Catch ex As Exception
            MessageBox.Show("Error while searching record from table..." & ex.Message, "Search Records")

        End Try
    End Sub

    Private Sub GrdListofBank_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdListofBank.CellContentClick

    End Sub

    Private Sub GrdListofBank_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdListofBank.CellMouseDoubleClick
        'Data Grid view Cell Mouse Double Click code
        Try
            GrdListofBank.Focus()
            Dim i As Integer
            i = GrdListofBank.CurrentRow.Index

            FrmBankTransaction.CmbBankID.ValueMember = GrdListofBank.Item(0, i).Value
            FrmBankTransaction.CmbBankID.Text = GrdListofBank.Item(1, i).Value
            FrmBankTransaction.TxtDebitedAmount.Focus()
            Me.Close()


        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Cell Mouse Double Click")

        End Try



    End Sub

    Private Sub GrdListofBank_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdListofBank.KeyDown
        If e.KeyCode = Keys.Enter Then


            'Data Grid view code
            Try
                GrdListofBank.Focus()
                Dim i As Integer
                i = GrdListofBank.CurrentRow.Index

                FrmBankTransaction.CmbBankID.ValueMember = GrdListofBank.Item(0, i).Value
                FrmBankTransaction.CmbBankID.Text = GrdListofBank.Item(1, i).Value
                FrmBankTransaction.TxtDebitedAmount.Focus()
                Me.Close()


            Catch ex As Exception
                MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview Keydown")

            End Try
        End If
    End Sub
End Class