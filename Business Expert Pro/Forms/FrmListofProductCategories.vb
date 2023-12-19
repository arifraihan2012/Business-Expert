Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmListofProductCategories
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point


    Private Sub FrmListofProductCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Location = New Point(0, 0)
        Me.Size = My.Computer.Screen.WorkingArea.Size

        TxtSearchCategory.Focus()
        'Refreshing Data
        Try
            RefreshData()

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records")
        Finally

        End Try
        'Change Language
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

            Me.TxtSearchCategory.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            Me.GrdListofProductCategories.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.GrdListofProductCategories.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)


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
            Dim sql As String = "SELECT * FROM [Product Category]"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Product Category")
            connection.Close()
            GrdListofProductCategories.DataSource = ds
            GrdListofProductCategories.DataMember = "BizPro_Product Category"

            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdListofProductCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally

        End Try

        'End Refresh Data
    End Sub

    Private Sub TxtSearchCategory_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearchCategory.KeyDown
        If e.KeyCode = Keys.Down Then
            GrdListofProductCategories.Focus()

        End If

        'Enter on Focus Grid view and Enter Grid View code
        If e.KeyCode = Keys.Enter Then


            'Data Grid view key down code
            Try

                Dim i As Integer
                i = GrdListofProductCategories.CurrentRow.Index


                If Label1.Text = "Product Information" Then
                    FrmProductInformation.CmbProductCategoryID.ValueMember = GrdListofProductCategories.Item(0, i).Value
                    FrmProductInformation.CmbProductCategoryID.Text = GrdListofProductCategories.Item(1, i).Value
                    FrmProductInformation.CmbProductSubcategoryID.Focus()
                    Me.Close()
                ElseIf Label1.Text = "Search Product Information" Then

                    FrmProductInformation.CmbProductCategorySearch.ValueMember = GrdListofProductCategories.Item(0, i).Value
                    FrmProductInformation.CmbProductCategorySearch.Text = GrdListofProductCategories.Item(1, i).Value
                    FrmProductInformation.Search()
                    Me.Close()
                ElseIf Label1.Text = "Search" Then

                    FrmSearch.CmbSearchProductCategory.ValueMember = GrdListofProductCategories.Item(0, i).Value
                    FrmSearch.CmbSearchProductCategory.Text = GrdListofProductCategories.Item(1, i).Value
                    FrmSearch.BtnSearch.PerformClick()
                    Me.Close()
                End If

            Catch ex As Exception
                MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

            End Try

        End If
    End Sub


    Private Sub TxtSearchCategory_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearchCategory.TextChanged
        ' Load Data
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand


        Dim connectionString As String = FrmHome.ConnectionString
        Dim sql As String = "SELECT  *FROM [Product Category]  WHERE ([Product Category Name] LIKE '%" + Me.TxtSearchCategory.Text + "%')"


        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "BizPro_Product Category")
        GrdListofProductCategories.DataSource = ds
        GrdListofProductCategories.DataMember = "BizPro_Product Category"


        'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
        'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

        con.Close()

        'End Refresh Data

    End Sub


    Private Sub GrdListofProductCategories_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdListofProductCategories_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)



    End Sub

    Private Sub GrdListofProductCategories_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub PnlListofProductCategories_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PnlListofProductCategories.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= (X)
            newpoint.Y -= (Y)
            Me.Location = newpoint

        End If
    End Sub

    Private Sub PnlListofProductCategories_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PnlListofProductCategories.Paint

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

    Private Sub GrdListofProductCategories_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdListofProductCategories.CellContentClick

    End Sub

    Private Sub GrdListofProductCategories_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdListofProductCategories.CellMouseClick


       
    End Sub

    Private Sub GrdListofProductCategories_CellMouseDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdListofProductCategories.CellMouseDoubleClick
        'Data grid view cell Mouse Double click code

        Try

            Dim i As Integer
            i = GrdListofProductCategories.CurrentRow.Index

            If Label1.Text = "Product Information" Then
                FrmProductInformation.CmbProductCategoryID.ValueMember = GrdListofProductCategories.Item(0, i).Value
                FrmProductInformation.CmbProductCategoryID.Text = GrdListofProductCategories.Item(1, i).Value
                FrmProductInformation.CmbProductSubcategoryID.Focus()
                Me.Close()
            ElseIf Label1.Text = "Search Product Information" Then

                FrmProductInformation.CmbProductCategorySearch.ValueMember = GrdListofProductCategories.Item(0, i).Value
                FrmProductInformation.CmbProductCategorySearch.Text = GrdListofProductCategories.Item(1, i).Value
                FrmProductInformation.Search()
                Me.Close()
            ElseIf Label1.Text = "Search" Then

                FrmSearch.CmbSearchProductCategory.ValueMember = GrdListofProductCategories.Item(0, i).Value
                FrmSearch.CmbSearchProductCategory.Text = GrdListofProductCategories.Item(1, i).Value
                FrmSearch.BtnSearch.PerformClick()
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

        End Try
    End Sub

    Private Sub GrdListofProductCategories_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdListofProductCategories.KeyDown
        If e.KeyCode = Keys.Enter Then


            'Data Grid view key down code
            Try

                Dim i As Integer
                i = GrdListofProductCategories.CurrentRow.Index

                If Label1.Text = "Product Information" Then
                    FrmProductInformation.CmbProductCategoryID.ValueMember = GrdListofProductCategories.Item(0, i).Value
                    FrmProductInformation.CmbProductCategoryID.Text = GrdListofProductCategories.Item(1, i).Value
                    FrmProductInformation.CmbProductSubcategoryID.Focus()
                    Me.Close()
                ElseIf Label1.Text = "Search Product Information" Then

                    FrmProductInformation.CmbProductCategorySearch.ValueMember = GrdListofProductCategories.Item(0, i).Value
                    FrmProductInformation.CmbProductCategorySearch.Text = GrdListofProductCategories.Item(1, i).Value
                    FrmProductInformation.Search()
                    Me.Close()
                ElseIf Label1.Text = "Search" Then

                    FrmSearch.CmbSearchProductCategory.ValueMember = GrdListofProductCategories.Item(0, i).Value
                    FrmSearch.CmbSearchProductCategory.Text = GrdListofProductCategories.Item(1, i).Value
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