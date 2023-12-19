Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmListOfUserAccounts
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point

    Private Sub TxtSearchUserAccount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearchUserAccount.KeyDown

        ''Focus on grid view 
        If e.KeyCode = Keys.Down Then
            GrdListofUserAccount.Focus()
        End If

        'On Enter Press Data Select From Grid View Code
        If e.KeyCode = Keys.Enter Then
            Try
                GrdListofUserAccount.Focus()
                Dim i As Integer
                i = GrdListofUserAccount.CurrentRow.Index

                If Label1.Text = "Permission Setup" Then

                    FrmPermissionSetup.CmbUserAccountID.ValueMember = GrdListofUserAccount.Item(0, i).Value
                    FrmPermissionSetup.CmbUserAccountID.Text = GrdListofUserAccount.Item(1, i).Value
                    FrmPermissionSetup.CmbCategoryName.Focus()
                    Me.Close()
              
                End If
            Catch ex As Exception
                MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

            End Try
        End If
    End Sub

    Private Sub TxtSearchBank_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearchUserAccount.TextChanged





        Try
            ' Load Data
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [User Account].[User Account ID],[User Account].[User Name],[Branch Information].[Branch Name],[User Account].[Account Full Name],[User Account].[Designation] From [User Account]join [Branch Information]on [User Account].[Branch ID]=[Branch Information].[Branch ID]  WHERE ([User Account].[User Name] LIKE '%" + Me.TxtSearchUserAccount.Text + "%')"


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_User Account")
            GrdListofUserAccount.DataSource = ds
            GrdListofUserAccount.DataMember = "BizPro_User Account"


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            'Row Count
            NUmberOfRow()

            con.Close()

            'End Refresh Data
        Catch ex As Exception
            MessageBox.Show("Error while searching record from table..." & ex.Message, "Search Records")

        End Try
    End Sub
    Sub RefreshData()
        Try
            ' Load Data
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [User Account].[User Account ID],[User Account].[User Name],[Branch Information].[Branch Name],[User Account].[Account Full Name],[User Account].[Designation] From [User Account]join [Branch Information]on [User Account].[Branch ID]=[Branch Information].[Branch ID]"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_User Account")
            connection.Close()
            GrdListofUserAccount.DataSource = ds
            GrdListofUserAccount.DataMember = "BizPro_User Account"

            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdListofUserAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

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

        total = GrdListofUserAccount.Rows.Count

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

            Me.TxtSearchUserAccount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))


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

    Private Sub FrmListOfUserAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Location = New Point(0, 0)
        Me.Size = My.Computer.Screen.WorkingArea.Size


        Try

            'Focus on Search Group
            Me.TxtSearchUserAccount.Focus()
            'Refreshing Data
            RefreshData()

            'ChangeLanguage
            ChangeLanguage()

        Catch ex As Exception
            MessageBox.Show("Error while changing language or refreshing   record on table..." & ex.Message, "Form Load")
        Finally

        End Try
    End Sub

    Private Sub GrdListofUserAccount_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdListofUserAccount_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

    End Sub

    Private Sub GrdListofUserAccount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub GrdListofUserAccount_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdListofUserAccount.CellContentClick

    End Sub

    Private Sub GrdListofUserAccount_CellMouseDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdListofUserAccount.CellMouseDoubleClick
        'Data Grid view Cell Mouse Double Click code
        Try
            GrdListofUserAccount.Focus()
            Dim i As Integer
            i = GrdListofUserAccount.CurrentRow.Index

            If Me.Label1.Text = "Permission Setup" Then

                FrmPermissionSetup.CmbUserAccountID.ValueMember = GrdListofUserAccount.Item(0, i).Value
                FrmPermissionSetup.CmbUserAccountID.Text = GrdListofUserAccount.Item(1, i).Value
                FrmPermissionSetup.CmbCategoryName.Focus()
                Me.Close()

            
            End If


        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

        End Try
    End Sub

    Private Sub GrdListofUserAccount_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdListofUserAccount.KeyDown
        'On Enter Press Data Select From Grid View Code
        If e.KeyCode = Keys.Enter Then
            Try
                GrdListofUserAccount.Focus()
                Dim i As Integer
                i = GrdListofUserAccount.CurrentRow.Index

                If Me.Label1.Text = "Permission Setup" Then

                    FrmPermissionSetup.CmbUserAccountID.ValueMember = GrdListofUserAccount.Item(0, i).Value
                    FrmPermissionSetup.CmbUserAccountID.Text = GrdListofUserAccount.Item(1, i).Value
                    FrmPermissionSetup.CmbCategoryName.Focus()
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


 