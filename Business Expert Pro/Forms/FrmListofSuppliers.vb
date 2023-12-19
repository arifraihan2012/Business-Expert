Imports System.Data
Imports System.Data.SqlClient
Imports System.IO



Public Class FrmListofSuppliers

    Private Sub FrmListofSuppliers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Focus on Search Group
        TxtSearchSupplierName.Focus()
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

            Me.TxtSearchSupplierName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)



            Me.GrdListofSuppliers.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.GrdListofSuppliers.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)


            'MsgBox(dr.Item("Language Font"))

            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            con.Close()
        End Try

        'End Language

    End Sub
    'Creating Privet Sube For Refresh Data
    Sub RefreshData()
        Try
            ' Load Data
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Supplier Information].[Supplier ID],[Supplier Information].[Supplier Name],[Supplier Information].[Company Name],[Supplier Information].[Supplier Category ID],[Supplier Category].[Supplier Category Name],[Supplier Information].[Mobile No] FROM [Supplier Information] Join [Supplier Category] on [Supplier Information].[Supplier Category ID]= [Supplier Category].[Supplier Category ID]"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Supplier Information")
            connection.Close()
            GrdListofSuppliers.DataSource = ds
            GrdListofSuppliers.DataMember = "BizPro_Supplier Information"

            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdListofSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            con.Close()

            'End Refresh Data
        Catch ex As Exception
            MessageBox.Show("Error while refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try

    End Sub

    Private Sub TxtSearchSupplierName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearchSupplierName.KeyDown

        'key Down Code and Enter Press Select code
        If e.KeyCode = Keys.Down Then
            GrdListofSuppliers.Focus()

        End If


        If e.KeyCode = Keys.Enter Then



            'Data Grid view code
            Try

                GrdListofSuppliers.Focus()
                Dim i As Integer
                i = GrdListofSuppliers.CurrentRow.Index
                If Label1.Text = "Supplier Ledger" Then
                    FrmSupplierLedger.CmbSupplierID.ValueMember = GrdListofSuppliers.Item(0, i).Value
                    FrmSupplierLedger.CmbSupplierID.Text = GrdListofSuppliers.Item(1, i).Value
                    FrmSupplierLedger.TxtDebitedAmount.Focus()
                    FrmSupplierLedger.RefreshData()
                    Me.Close()
                ElseIf Label1.Text = "Search Supplier" Then
                    FrmSupplierLedger.CmbSearchName.ValueMember = GrdListofSuppliers.Item(0, i).Value
                    FrmSupplierLedger.CmbSearchName.Text = GrdListofSuppliers.Item(1, i).Value
                    FrmSupplierLedger.SearchSupplier()
                    Me.Close()

                ElseIf Label1.Text = "Purchase" Then

                    FrmPurchase.CmbSupplierName.SelectedValue = GrdListofSuppliers.Item(0, i).Value
                    FrmPurchase.CmbSupplierName.Text = GrdListofSuppliers.Item(1, i).Value
                    FrmPurchase.CmbProductName.Focus()
                    FrmPurchase.SupplierInformation()
                    FrmPurchase.ShowDueOrAdvance()
                    FrmPurchase.NetpayableAmount()
                    Me.Close()
                ElseIf Label1.Text = "Purchase Return" Then



                End If


            Catch ex As Exception
                MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

            End Try


        End If

    End Sub

    Private Sub TxtSearchSupplierName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearchSupplierName.TextChanged
        Try
            ' Load Data
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Supplier ID],[Supplier Name],[Company Name],[Designation],[Mobile No] FROM [Supplier Information]  WHERE ([Supplier Name] LIKE '%" + Me.TxtSearchSupplierName.Text + "%')"


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Supplier Information")
            GrdListofSuppliers.DataSource = ds
            GrdListofSuppliers.DataMember = "BizPro_Supplier Information"


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            con.Close()

            'End Refresh Data

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

        End Try

    End Sub

    Private Sub GrdListofSuppliers_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdListofSuppliers.CellContentClick

    End Sub

    Private Sub GrdListofSuppliers_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdListofSuppliers.CellMouseDoubleClick
        'Grid view cell Mouse Double Click Code

        'Cell Mouse Double Click code
        Try

            Dim i As Integer
            i = GrdListofSuppliers.CurrentRow.Index


            If Label1.Text = "Supplier Ledger" Then
                FrmSupplierLedger.CmbSupplierID.ValueMember = GrdListofSuppliers.Item(0, i).Value
                FrmSupplierLedger.CmbSupplierID.Text = GrdListofSuppliers.Item(1, i).Value
                FrmSupplierLedger.TxtDebitedAmount.Focus()
                FrmSupplierLedger.RefreshData()
                Me.Close()
            ElseIf Label1.Text = "Search Supplier" Then
                FrmSupplierLedger.CmbSearchName.ValueMember = GrdListofSuppliers.Item(0, i).Value
                FrmSupplierLedger.CmbSearchName.Text = GrdListofSuppliers.Item(1, i).Value
                FrmSupplierLedger.SearchSupplier()
                Me.Close()

            ElseIf Label1.Text = "Purchase" Then
                FrmPurchase.CmbSupplierName.SelectedValue = GrdListofSuppliers.Item(0, i).Value
                FrmPurchase.CmbSupplierName.Text = GrdListofSuppliers.Item(1, i).Value
                FrmPurchase.CmbProductName.Focus()
                FrmPurchase.SupplierInformation()
                FrmPurchase.ShowDueOrAdvance()
                FrmPurchase.NetpayableAmount()
                Me.Close()
            ElseIf Label1.Text = "Purchase Return" Then
               

            End If


        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")
        End Try


    End Sub

    Private Sub GrdListofSuppliers_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdListofSuppliers.KeyDown
        'Enter press Focus Grid view and grid view code
        If e.KeyCode = Keys.Enter Then


            Try

                Dim i As Integer
                i = GrdListofSuppliers.CurrentRow.Index

                If Label1.Text = "Supplier Ledger" Then
                    FrmSupplierLedger.CmbSupplierID.ValueMember = GrdListofSuppliers.Item(0, i).Value
                    FrmSupplierLedger.CmbSupplierID.Text = GrdListofSuppliers.Item(1, i).Value
                    FrmSupplierLedger.TxtDebitedAmount.Focus()
                    FrmSupplierLedger.RefreshData()
                    Me.Close()

                ElseIf Label1.Text = "Search Supplier" Then
                    FrmSupplierLedger.CmbSearchName.ValueMember = GrdListofSuppliers.Item(0, i).Value
                    FrmSupplierLedger.CmbSearchName.Text = GrdListofSuppliers.Item(1, i).Value
                    FrmSupplierLedger.SearchSupplier()
                    Me.Close()

                ElseIf Label1.Text = "Purchase" Then
                    FrmPurchase.CmbSupplierName.SelectedValue = GrdListofSuppliers.Item(0, i).Value
                    FrmPurchase.CmbSupplierName.Text = GrdListofSuppliers.Item(1, i).Value
                    FrmPurchase.CmbProductName.Focus()
                    FrmPurchase.SupplierInformation()
                    FrmPurchase.ShowDueOrAdvance()
                    FrmPurchase.NetpayableAmount()

                    Me.Close()
                ElseIf Label1.Text = "Purchase Return" Then

                   

                End If


            Catch ex As Exception
                MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

            End Try

        End If
    End Sub
End Class