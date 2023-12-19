Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmListofProductGroups
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point



    'Private Sub For Refresh Data
    Sub RefreshData()
        Try
            ' Load Data
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT * FROM [Product Group]"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Product Group")
            connection.Close()
            GrdListofProductGroups.DataSource = ds
            GrdListofProductGroups.DataMember = "BizPro_Product Group"

            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdListofProductGroups.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            con.Close()

            'End Refresh Data

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

            Me.TxtSearchGroup.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            Me.GrdListofProductGroups.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.GrdListofProductGroups.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)


            'MsgBox(dr.Item("Language Font"))

            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            con.Close()
        End Try

        'End Language

    End Sub


    Private Sub FrmListofProductGroups_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Focus on Search Group
        Me.TxtSearchGroup.Focus()
        'Refreshing Data
        Try
            RefreshData()

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records")
        Finally

        End Try

        'ChangeLanguage
        Try
            ChangeLanguage()

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records")
        Finally

        End Try

    End Sub

    Private Sub TxtSearchGroup_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearchGroup.KeyDown
        If e.KeyCode = Keys.Down Then
            GrdListofProductGroups.Focus()
        End If


        'Enter on Focus Grid view and Enter Grid View code
        If e.KeyCode = Keys.Enter Then


            'Data Grid view code
            Try

                Dim i As Integer
                i = GrdListofProductGroups.CurrentRow.Index

                If Label1.Text = "Product Information" Then
                    FrmProductInformation.CmbProductGroupID.ValueMember = GrdListofProductGroups.Item(0, i).Value
                    FrmProductInformation.CmbProductGroupID.Text = GrdListofProductGroups.Item(1, i).Value
                    FrmProductInformation.CmbProductCategoryID.Focus()
                    Me.Close()

                ElseIf Label1.Text = "Search Product Information" Then

                    FrmProductInformation.CmbProductGroupSearch.ValueMember = GrdListofProductGroups.Item(0, i).Value
                    FrmProductInformation.CmbProductGroupSearch.Text = GrdListofProductGroups.Item(1, i).Value
                    FrmProductInformation.Search()
                    Me.Close()
                ElseIf Label1.Text = "Search" Then

                    FrmSearch.CmbSearchProductGroup.ValueMember = GrdListofProductGroups.Item(0, i).Value
                    FrmSearch.CmbSearchProductGroup.Text = GrdListofProductGroups.Item(1, i).Value
                    FrmSearch.BtnSearch.PerformClick()
                    Me.Close()

                End If

            Catch ex As Exception
                MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

            End Try

        End If


    End Sub





    Private Sub TxtSearchGroup_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearchGroup.TextChanged


        ' Load Data
        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT  *FROM [Product Group]  WHERE ([Product Group Name] LIKE '%" + Me.TxtSearchGroup.Text + "%')"


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Product Group")
            GrdListofProductGroups.DataSource = ds
            GrdListofProductGroups.DataMember = "BizPro_Product Group"


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records")
        Finally

        End Try

        'End Refresh Data


    End Sub

    Private Sub GrdListofProductGroups_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdListofProductGroups_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)


    End Sub

    Private Sub GrdListofProductGroups_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub PnlListofProductGroup_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PnlListofProductGroup.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= (X)
            newpoint.Y -= (Y)
            Me.Location = newpoint

        End If
    End Sub

    Private Sub PnlListofProductGroup_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PnlListofProductGroup.Paint

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

    Private Sub GrdListofProductGroups_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdListofProductGroups.CellContentClick

    End Sub

    Private Sub GrdListofProductGroups_CellMouseDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdListofProductGroups.CellMouseDoubleClick
        'Grid view Cell Mouse Double Click Codde

        Try

            Dim i As Integer
            i = GrdListofProductGroups.CurrentRow.Index

            If Label1.Text = "Product Information" Then
                FrmProductInformation.CmbProductGroupID.ValueMember = GrdListofProductGroups.Item(0, i).Value
                FrmProductInformation.CmbProductGroupID.Text = GrdListofProductGroups.Item(1, i).Value
                FrmProductInformation.CmbProductCategoryID.Focus()
                Me.Close()

            ElseIf Label1.Text = "Search Product Information" Then

                FrmProductInformation.CmbProductGroupSearch.ValueMember = GrdListofProductGroups.Item(0, i).Value
                FrmProductInformation.CmbProductGroupSearch.Text = GrdListofProductGroups.Item(1, i).Value
                FrmProductInformation.Search()
                Me.Close()
            ElseIf Label1.Text = "Search" Then

                FrmSearch.CmbSearchProductGroup.ValueMember = GrdListofProductGroups.Item(0, i).Value
                FrmSearch.CmbSearchProductGroup.Text = GrdListofProductGroups.Item(1, i).Value
                FrmSearch.BtnSearch.PerformClick()
                Me.Close()

            End If
        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

        End Try
    End Sub

    Private Sub GrdListofProductGroups_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdListofProductGroups.KeyDown
        'Grid view Keydown code
        If e.KeyCode = Keys.Enter Then


            'Data Grid view code
            Try

                Dim i As Integer
                i = GrdListofProductGroups.CurrentRow.Index

                If Label1.Text = "Product Information" Then
                    FrmProductInformation.CmbProductGroupID.ValueMember = GrdListofProductGroups.Item(0, i).Value
                    FrmProductInformation.CmbProductGroupID.Text = GrdListofProductGroups.Item(1, i).Value
                    FrmProductInformation.CmbProductCategoryID.Focus()
                    Me.Close()

                ElseIf Label1.Text = "Search Product Information" Then

                    FrmProductInformation.CmbProductGroupSearch.ValueMember = GrdListofProductGroups.Item(0, i).Value
                    FrmProductInformation.CmbProductGroupSearch.Text = GrdListofProductGroups.Item(1, i).Value
                    FrmProductInformation.Search()
                    Me.Close()
                ElseIf Label1.Text = "Search" Then

                    FrmSearch.CmbSearchProductGroup.ValueMember = GrdListofProductGroups.Item(0, i).Value
                    FrmSearch.CmbSearchProductGroup.Text = GrdListofProductGroups.Item(1, i).Value
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