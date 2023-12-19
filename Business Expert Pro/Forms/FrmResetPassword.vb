
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class FrmResetPassword

    Private Sub FrmResetPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Change Langeuge Privet Sub
        ChangeLanguage()

        'load combobox
        LoadComboBox()

        'clear Data
        clearData()

        cmbUserName.SelectedIndex = -1

    End Sub

    Sub clearData()

        TxtNewPassword.Text = ""
        TxtOldPassword.Text = ""
    End Sub


    'Load combo box privet sub
    Sub LoadComboBox()
        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        con1.ConnectionString = FrmHome.ConnectionString

        Dim strSQL1 As String = "SELECT [User Account ID],[User Name] FROM [User Account]"
        Dim da1 As New System.Data.SqlClient.SqlDataAdapter(strSQL1, con1)
        Dim ds1 As New DataSet
        da1.Fill(ds1, "[User Account]")

        With Me.cmbUserName
            .DataSource = ds1.Tables("[User Account]")
            .ValueMember = "User Account ID"
            .DisplayMember = "User Name"
        End With
        con1.Close()
    End Sub


    'Change Langeuge Privet Sub
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
            If dr.HasRows Then

                Me.cmbUserName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtNewPassword.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtOldPassword.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))


                'MsgBox(dr.Item("Language Font"))
            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            con.Close()
        End Try

        'End Language

    End Sub

    Private Sub TxtOldPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtOldPassword.KeyDown
        If e.KeyCode = Keys.Enter Then



            If Not cmbUserName.Text = "" Then

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim dr As SqlDataReader
                Dim cmd1 As New SqlCommand


                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd1.Connection = con
                cmd.CommandText = "SELECT [User Account].[User Account ID],[User Account].[User Name],[Branch Information].[Branch ID],[Branch Information].[Branch Name],[User Account].[Account Full Name],[User Account].[Designation],[User Account].[Password],[User Account].[Status] From [User Account]join [Branch Information]on [User Account].[Branch ID]=[Branch Information].[Branch ID]  WHERE [User Account].[User Name] = '" + Me.cmbUserName.Text + "'"

                dr = cmd.ExecuteReader()
                dr.Read()
                If dr.HasRows Then

                    If TxtOldPassword.Text = (dr.Item("Password")) Then

                        Me.TxtNewPassword.Enabled = True
                        TxtNewPassword.Focus()


                    ElseIf MsgBox("Incorrect Password", MsgBoxStyle.Critical, "User Login") Then
                        Me.TxtOldPassword.Text = ""
                    End If
                End If

                dr.Close()
                con.Close()

            Else
                MsgBox("Please select user name first", MsgBoxStyle.OkOnly, "User Login")
                Me.TxtOldPassword.Text = ""
            End If

        End If
    End Sub

    Private Sub TxtOldPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtOldPassword.TextChanged

    End Sub

    Private Sub TxtNewPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNewPassword.KeyDown

    End Sub

    Private Sub TxtNewPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNewPassword.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmbUserName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbUserName.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmbUserName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUserName.SelectedIndexChanged

        'Focus on old password
        TxtOldPassword.Focus()


        'Clear data
        clearData()
    End Sub

    Private Sub BtnResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReset.Click
        Try

            If Not TxtNewPassword.Text = "" Then



                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim currentDate As DateTime = DateTime.Today
                Dim currentTime As DateTime = DateTime.Now


                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "UPDATE [User Account] SET [Password]= '" + TxtNewPassword.Text + "' WHERE [User Account ID]= '" + cmbUserName.SelectedValue.ToString + "'    INSERT INTO [Log Details]  ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Task ID]) VALUES('" + Me.Text + "','INSERT','User Name : " + cmbUserName.Text + " Changed his password  from : " + TxtOldPassword.Text + "  to : " + TxtNewPassword.Text + "' ,'" + cmbUserName.SelectedValue.ToString + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + cmbUserName.SelectedValue.ToString + "' )"

                cmd.ExecuteNonQuery()



                'Update Click Msg
                MsgBox("Reset Password Successfully", MsgBoxStyle.OkOnly, "Reset Password")

                'Making Clear
                clearData()

                Me.TxtNewPassword.Enabled = False
                cmbUserName.SelectedIndex = -1

                con.Close()

            ElseIf cmbUserName.Text = "" Then
                MsgBox("Please select user name", MsgBoxStyle.OkOnly, "Reset Password")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class