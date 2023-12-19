Imports System.Data
Imports System.Data.SqlClient
Imports System.IO


Public Class FrmListOfPaymentMethod

    Private Sub PnlListofPaymentMethod_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PnlListofPaymentMethod.Paint

    End Sub

    Private Sub FrmListOfPaymentMethod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtSearchPaymentMethod.Focus()

        'Refreshing Data
        Try
            RefreshData()

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally

        End Try
        'Change Language
        Try
            ChangeLanguage()

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
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

            Me.TxtSearchPaymentMethod.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            Me.GrdListofPaymentMethod.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.GrdListofPaymentMethod.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)


            'MsgBox(dr.Item("Language Font"))

            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            con.Close()
        End Try

        'End Language

    End Sub

    'Private Sub for Refresh Data
    Sub RefreshData()
        Try
            ' Load Data
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT * FROM [Payment Method]"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Payment Method")
            connection.Close()
            GrdListofPaymentMethod.DataSource = ds
            GrdListofPaymentMethod.DataMember = "BizPro_Payment Method"

            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdListofPaymentMethod.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally

        End Try

        'End Refresh Data
    End Sub

    Private Sub TxtSearchPaymentMethod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearchPaymentMethod.KeyDown
        ' Focus on Grid View
        If e.KeyCode = Keys.Down Then
            GrdListofPaymentMethod.Focus()

        End If
    End Sub



    Private Sub TxtSearchPaymentMethod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearchPaymentMethod.TextChanged
        ' Load Data
        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT  *FROM [Payment Method]  WHERE ([Payment Method Name] LIKE '%" + Me.TxtSearchPaymentMethod.Text + "%')"


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Payment Method")
            GrdListofPaymentMethod.DataSource = ds
            GrdListofPaymentMethod.DataMember = "BizPro_Payment Method"


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally

        End Try
        'End Refresh Data

    End Sub

    Private Sub GrdListofPaymentMethod_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdListofPaymentMethod.CellContentClick

    End Sub

    Private Sub GrdListofPaymentMethod_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdListofPaymentMethod.CellMouseDoubleClick
        
    End Sub
End Class