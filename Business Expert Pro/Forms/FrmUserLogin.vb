
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class FrmUserLogin

    Private Sub FrmUserLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Location = New Point(0, 0)
        'Me.Size = My.Computer.Screen.WorkingArea.Size

        Try

       
            'Load ComboBox
            LoadComboBox()

            'Clear Data
            clearData()

            'Focus on User Name
            TxtPassword.Focus()


            'change language
            'ChangeLanguage()



            'company Label Name show

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT [Company Details].[Company ID],[Company Details].[Company Name],[Branch Information].[Branch ID],[Company Details].[Company Title],[Company Details].[Port Number],[Company Details].[Address],[Company Details].[Email],[Company Details].[Status],[Company Details].[Contact No],[Company Details].[SMS Number] FROM [Company Details] Join [Branch Information] on [Company Details].[Branch ID]= [Branch Information].[Branch ID] "


            dr = cmd.ExecuteReader()
            dr.Read()


            If dr.HasRows Then

                Me.lblCompanyName.Text = (dr.Item("Company Name").ToString)
                Me.LblTitle.Text = (dr.Item("Company Title").ToString)
                FrmHome.lblCompanyName.Text = (dr.Item("Company Name").ToString)
                FrmHome.LblStatus.Text = (dr.Item("Status").ToString)
                FrmHome.LblTitle.Text = (dr.Item("Company Title").ToString)
                FrmHome.SMSNumber = (dr.Item("SMS Number").ToString)
                Me.lblCompanyName.Anchor = AnchorStyles.Top
                Me.lblCompanyName.Left = (Me.lblCompanyName.Parent.Width \ 2) - (Me.lblCompanyName.Width \ 2)

                Me.LblTitle.Anchor = AnchorStyles.Top
                Me.LblTitle.Left = (Me.LblTitle.Parent.Width \ 2) - (Me.LblTitle.Width \ 2)





                dr.Close()




                'Dr search For company Image
                cmd.CommandText = "SELECT  *FROM [Company Details] where [Company Image] IS NOT NULL" ' WHERE [Company ID] = " + Me.TxtCompanyID.Text + " 


                dr = cmd.ExecuteReader()
                dr.Read()


                Try



                    If dr.HasRows Then

                        Dim data As Byte() = DirectCast(dr("Company Image"), Byte())
                        Dim ms As New MemoryStream(data)
                        FrmHome.PtbCompanyImage.Image = Image.FromStream(ms)
                        Me.PtbCompanyImage.Image = Image.FromStream(ms)
                    End If
                Catch ex As Exception

                End Try

                dr.Close()
                'con.Close()





            End If

            con.Close()



        Catch ex As Exception

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
            If dr.HasRows Then


                Me.CmbUserAccountID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtPassword.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))


                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)




                'MsgBox(dr.Item("Language Font"))
            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while changing language on table..." & ex.Message, "Change Language")
        Finally
            con.Close()
        End Try

        'End Language

    End Sub


    Private Sub TxtUserID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    'Clear Data

    Sub clearData()

        CmbUserAccountID.SelectedValue = -1
        TxtPassword.Text = ""

    End Sub

    'Load combo box privet sub
    Sub LoadComboBox()
        Try


            Dim con1 As New SqlConnection
            Dim cmd1 As New SqlCommand
            con1.ConnectionString = FrmHome.ConnectionString

            Dim strSQL1 As String = "SELECT [User Account ID],[User Name] FROM [User Account]"
            Dim da1 As New System.Data.SqlClient.SqlDataAdapter(strSQL1, con1)
            Dim ds1 As New DataSet
            da1.Fill(ds1, "[User Account]")

            With Me.CmbUserAccountID
                .DataSource = ds1.Tables("[User Account]")
                .ValueMember = "User Account ID"
                .DisplayMember = "User Name"
            End With
            con1.Close()

        Catch ex As Exception

        End Try
    End Sub


    Sub ClearPaasword()
        TxtPassword.Text = ""
        TxtPassword.Focus()
    End Sub
    Sub Login()

        Try

            If Not CmbUserAccountID.Text = "" Then

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim dr As SqlDataReader

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "SELECT * From [User Account]join [Branch Information]on [User Account].[Branch ID]=[Branch Information].[Branch ID] join [Employee Information] on [User Account].[employee ID]=[Employee Information].[employee ID]  WHERE [User Account].[User Name] = '" + Me.CmbUserAccountID.Text + "'"

                dr = cmd.ExecuteReader()
                dr.Read()
                If dr.HasRows Then


                    If TxtPassword.Text = (dr.Item("Password")) Then



                        FrmHome.LblUserID.Text = (dr.Item("User Account ID").ToString)
                        FrmHome.LblUserName.Text = (dr.Item("User Name").ToString)
                        FrmHome.LblBranchName.Text = (dr.Item("Branch Name").ToString)
                        FrmHome.lblBranchID.Text = (dr.Item("Branch ID").ToString)
                        FrmHome.EmployeeID = (dr.Item("Employee ID").ToString)



                        FrmHome.Show()


                        FrmHome.lblCompanyName.Anchor = AnchorStyles.Top
                        FrmHome.lblCompanyName.Left = (FrmHome.lblCompanyName.Parent.Width \ 2) - (FrmHome.lblCompanyName.Width \ 2)


                        FrmHome.LblTitle.Anchor = AnchorStyles.Top
                        FrmHome.LblTitle.Left = (FrmHome.LblTitle.Parent.Width \ 2) - (FrmHome.LblTitle.Width \ 2)


                        'Insert into log 
                        InsertIntoLog()


                        Me.Hide()




                    ElseIf MsgBox("Incorrect Password", MsgBoxStyle.Critical, "User Login") Then
                        ClearPaasword()
                    End If
                End If
                dr.Close()
                con.Close()

            Else
                MsgBox("Please select user name first", MsgBoxStyle.OkOnly, "User Login")

                ClearPaasword()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub TxtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPassword.KeyDown

        If e.KeyCode = Keys.Enter Then


            'Login to software
            Login()

        End If



    End Sub


    Private Sub TxtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPassword.TextChanged






    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CmbUserAccountID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbUserAccountID.KeyPress
        e.Handled = True
    End Sub

    Private Sub CmbUserAccountID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbUserAccountID.SelectedIndexChanged

        'Focus on Password and clear password text box
        ClearPaasword()
    End Sub

    'Insert into log 
    Sub InsertIntoLog()
        Try

            'Data Insert Code
            Dim con1 As New SqlConnection
            Dim cmd1 As New SqlCommand
            Dim CurrentDate As DateTime = DateTime.Today
            Dim CurrentTime As DateTime = DateTime.Now


            con1.ConnectionString = FrmHome.ConnectionString
            con1.Open()
            cmd1.Connection = con1
            cmd1.CommandText = "INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID])VALUES('" + Me.Text + "','Log In', 'User Name: " + CmbUserAccountID.Text + " loged in software','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + CmbUserAccountID.SelectedValue.ToString + "' )"
            cmd1.ExecuteNonQuery()
            con1.Close()



        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally


        End Try
    End Sub
    Private Sub BtnResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try



            If Not CmbUserAccountID.Text = "" Then

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim dr As SqlDataReader

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "SELECT * From [User Account] join [Branch Information]on [User Account].[Branch ID]=[Branch Information].[Branch ID] join [Employee Information] on [User Account].[employee ID]=[Employee Information].[employee ID]  WHERE [User Account].[User Name] = '" + Me.CmbUserAccountID.Text + "'"

                dr = cmd.ExecuteReader()
                dr.Read()

                If TxtPassword.Text = (dr.Item("Password")) Then



                    FrmHome.LblUserID.Text = (dr.Item("User Account ID").ToString)
                    FrmHome.LblUserName.Text = (dr.Item("User Name").ToString)
                    FrmHome.LblBranchName.Text = (dr.Item("Branch Name").ToString)
                    FrmHome.lblBranchID.Text = (dr.Item("Branch ID").ToString)
                    FrmHome.EmployeeID = (dr.Item("Employee ID").ToString)


                    FrmHome.Show()

                    'Insert into log 
                    InsertIntoLog()

                    Me.Hide()



                ElseIf MsgBox("Incorrect Password", MsgBoxStyle.Critical, "User Login") Then
                    ClearPaasword()
                End If
                dr.Close()
                con.Close()





            Else
                MsgBox("Please select user name first", MsgBoxStyle.OkOnly, "User Login")
                ClearPaasword()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub lblLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCompanyName.Click

    End Sub

    Private Sub LblTitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblTitle.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lblForgotPassword_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblResetPassword.LinkClicked
        FrmResetPassword.Show()
        FrmResetPassword.cmbUserName.Focus()


        FrmHome.FindMacAddress()
        FrmHome.FindComputerID()

    End Sub

    Private Sub Btnminimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnminimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Btnmaximized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnmaximized.Click
        'If Me.WindowState = FormWindowState.Maximized Then
        'Me.WindowState = FormWindowState.Normal

        'Else
        'Me.WindowState = FormWindowState.Maximized

        'End If
    End Sub

    Private Sub Btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnclose.Click
        Me.Close()
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub GrpLogin_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrpLogin.Enter

    End Sub

    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click
        'Login to software
        Login()
    End Sub
End Class