Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmListofProductSubcategories
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point

    Private Sub FrmListofProductSubcategories_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Focus on Products Subcategories Text Box
        TxtSearchProductsSubcategories.Focus()
        'Refreshing Data
        Try
            RefreshData()

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records")
        Finally

        End Try

        'change Language
        Try
            ChangeLanguage()

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records")
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

            Me.TxtSearchProductsSubcategories.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            Me.GrdListofProductSubcategories.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.GrdListofProductSubcategories.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)


            'MsgBox(dr.Item("Language Font"))

            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            con.Close()
        End Try

        'End Language

    End Sub
    'Private sub for Refresh Data

    Sub RefreshData()
        Try
            ' Load Data
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT * FROM [Product Subcategory]"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Product Subcategory")
            connection.Close()
            GrdListofProductSubcategories.DataSource = ds
            GrdListofProductSubcategories.DataMember = "BizPro_Product Subcategory"

            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdListofProductSubcategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            con.Close()

            'End Refresh Data
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally

        End Try

    End Sub

    Private Sub TxtSearchProductsSubcategories_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearchProductsSubcategories.KeyDown
        'Focus on Grid view

        If e.KeyCode = Keys.Down Then
            GrdListofProductSubcategories.Focus()
        End If

        'Enter on Focus Grid view and Enter Grid View code
        If e.KeyCode = Keys.Enter Then


            'Data Grid view code
            Try

                Dim i As Integer
                i = GrdListofProductSubcategories.CurrentRow.Index

                If Label1.Text = "Product Information" Then


                    FrmProductInformation.CmbProductSubcategoryID.ValueMember = GrdListofProductSubcategories.Item(0, i).Value
                    FrmProductInformation.CmbProductSubcategoryID.Text = GrdListofProductSubcategories.Item(1, i).Value
                    FrmProductInformation.TxtProductName.Focus()
                    Me.Close()
                ElseIf Label1.Text = "Search Product Information" Then

                    FrmProductInformation.CmbProductSubcategorySearch.ValueMember = GrdListofProductSubcategories.Item(0, i).Value
                    FrmProductInformation.CmbProductSubcategorySearch.Text = GrdListofProductSubcategories.Item(1, i).Value
                    FrmProductInformation.Search()
                    Me.Close()

                ElseIf Label1.Text = "Search" Then

                    FrmSearch.CmbSearchProductSubcategory.ValueMember = GrdListofProductSubcategories.Item(0, i).Value
                    FrmSearch.CmbSearchProductSubcategory.Text = GrdListofProductSubcategories.Item(1, i).Value
                    FrmSearch.BtnSearch.PerformClick()
                    Me.Close()
                End If

            Catch ex As Exception
                MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

            End Try

        End If

    End Sub

    Private Sub TxtSearchProductsSubcategories_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TxtSearchProductsSubcategories.MouseDoubleClick

    End Sub

    Private Sub TxtSearchProductsSubcategories_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearchProductsSubcategories.TextChanged
        ' Load Data
        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT  *FROM [Product Subcategory]  WHERE ([Product Subcategory Name] LIKE '%" + Me.TxtSearchProductsSubcategories.Text + "%')"


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Product Subcategory")
            GrdListofProductSubcategories.DataSource = ds
            GrdListofProductSubcategories.DataMember = "BizPro_Product Subcategory"


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records")
        Finally

        End Try

        'End Refresh Data
    End Sub

    Private Sub GrdListofProductSubcategories_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdListofProductSubcategories_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

    End Sub

    Private Sub GrdListofProductSubcategories_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    End Sub

    Private Sub Btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnclose.Click
        Me.Close()
    End Sub

    Private Sub Btnmaximized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnmaximized.Click

        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal

        Else
            Me.WindowState = FormWindowState.Maximized

        End If
    End Sub

    Private Sub Btnminimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnminimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub GrdListofProductSubcategories_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdListofProductSubcategories.CellContentClick

    End Sub

    Private Sub GrdListofProductSubcategories_CellMouseDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdListofProductSubcategories.CellMouseDoubleClick


        'Grid view Cell Mouse Double Click Code

        Try

            Dim i As Integer
            i = GrdListofProductSubcategories.CurrentRow.Index

            If Label1.Text = "Product Information" Then


                FrmProductInformation.CmbProductSubcategoryID.ValueMember = GrdListofProductSubcategories.Item(0, i).Value
                FrmProductInformation.CmbProductSubcategoryID.Text = GrdListofProductSubcategories.Item(1, i).Value
                FrmProductInformation.TxtProductName.Focus()
                Me.Close()
            ElseIf Label1.Text = "Search Product Information" Then

                FrmProductInformation.CmbProductSubcategorySearch.ValueMember = GrdListofProductSubcategories.Item(0, i).Value
                FrmProductInformation.CmbProductSubcategorySearch.Text = GrdListofProductSubcategories.Item(1, i).Value
                FrmProductInformation.Search()
                Me.Close()

            ElseIf Label1.Text = "Search" Then

                FrmSearch.CmbSearchProductSubcategory.ValueMember = GrdListofProductSubcategories.Item(0, i).Value
                FrmSearch.CmbSearchProductSubcategory.Text = GrdListofProductSubcategories.Item(1, i).Value
                FrmSearch.BtnSearch.PerformClick()
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

        End Try
    End Sub

    Private Sub GrdListofProductSubcategories_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdListofProductSubcategories.KeyDown
        'Grid view keydown code

        If e.KeyCode = Keys.Enter Then


            'Data Grid view code
            Try

                Dim i As Integer
                i = GrdListofProductSubcategories.CurrentRow.Index

                If Label1.Text = "Product Information" Then


                    FrmProductInformation.CmbProductSubcategoryID.ValueMember = GrdListofProductSubcategories.Item(0, i).Value
                    FrmProductInformation.CmbProductSubcategoryID.Text = GrdListofProductSubcategories.Item(1, i).Value
                    FrmProductInformation.TxtProductName.Focus()
                    Me.Close()
                ElseIf Label1.Text = "Search Product Information" Then

                    FrmProductInformation.CmbProductSubcategorySearch.ValueMember = GrdListofProductSubcategories.Item(0, i).Value
                    FrmProductInformation.CmbProductSubcategorySearch.Text = GrdListofProductSubcategories.Item(1, i).Value
                    FrmProductInformation.Search()
                    Me.Close()

                ElseIf Label1.Text = "Search" Then

                    FrmSearch.CmbSearchProductSubcategory.ValueMember = GrdListofProductSubcategories.Item(0, i).Value
                    FrmSearch.CmbSearchProductSubcategory.Text = GrdListofProductSubcategories.Item(1, i).Value
                    FrmSearch.BtnSearch.PerformClick()
                    Me.Close()
                End If

            Catch ex As Exception
                MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

            End Try

        End If
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