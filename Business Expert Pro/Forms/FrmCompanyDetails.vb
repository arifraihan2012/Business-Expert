Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmCompanyDetails
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point

    Private Sub FrmCompanyDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

       

        'permission for update and Delete
        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim MyFormName As Form = CType(sender, Form)



            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + FrmHome.LblUserID.Text + "' AND [Category Name] = '" + MyFormName.Text + "' And  [Update Delete Permission]='Yes'"


            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then
                BtnDelete.Enabled = True
                BtnUpdate.Enabled = True

            ElseIf Not dr.HasRows Then
                BtnDelete.Enabled = False
                BtnUpdate.Enabled = False


            End If


            dr.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while  permission delete to form..." & ex.Message, "Form Load")

        End Try





        'Load Combo Box
        LoadComboBox()

        'Clear Data
        ClearData()

        'Change Language
        ChangeLanguage()

    End Sub

    Sub CompanyNameAndAddress()


        'company Label Name show

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        con.ConnectionString = FrmHome.ConnectionString
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT [Company Details].[Company ID],[Company Details].[Company Name],[Branch Information].[Branch ID],[Company Details].[Company Title],[Company Details].[Address],[Company Details].[Email],[Company Details].[Status],[Company Details].[Contact No] FROM [Company Details] Join [Branch Information] on [Company Details].[Branch ID]= [Branch Information].[Branch ID] "


        dr = cmd.ExecuteReader()
        dr.Read()


        If dr.HasRows Then

            Try


                FrmUserLogin.lblCompanyName.Text = (dr.Item("Company Name").ToString)
                FrmUserLogin.LblTitle.Text = (dr.Item("Company Title").ToString)
                FrmHome.lblCompanyName.Text = (dr.Item("Company Name").ToString)
                FrmHome.LblTitle.Text = (dr.Item("Company Title").ToString)

                FrmUserLogin.lblCompanyName.Anchor = AnchorStyles.Top
                FrmUserLogin.lblCompanyName.Left = (FrmUserLogin.lblCompanyName.Parent.Width \ 2) - (FrmUserLogin.lblCompanyName.Width \ 2)

                FrmUserLogin.LblTitle.Anchor = AnchorStyles.Top
                FrmUserLogin.LblTitle.Left = (FrmUserLogin.LblTitle.Parent.Width \ 2) - (FrmUserLogin.LblTitle.Width \ 2)


                FrmHome.lblCompanyName.Anchor = AnchorStyles.Top
                FrmHome.lblCompanyName.Left = (FrmHome.lblCompanyName.Parent.Width \ 2) - (FrmHome.lblCompanyName.Width \ 2)


                FrmHome.LblTitle.Anchor = AnchorStyles.Top
                FrmHome.LblTitle.Left = (FrmHome.LblTitle.Parent.Width \ 2) - (FrmHome.LblTitle.Width \ 2)



                dr.Close()


                'Dr search For company Image
                cmd.CommandText = "SELECT  *FROM [Company Details]  WHERE  [Company Image] IS NOT NULL"


                dr = cmd.ExecuteReader()
                dr.Read()


                Try



                    If dr.HasRows Then
                        Dim data As Byte() = DirectCast(dr("Company Image"), Byte())
                        Dim ms As New MemoryStream(data)
                        FrmHome.PtbCompanyImage.Image = Image.FromStream(ms)
                        FrmUserLogin.PtbCompanyImage.Image = Image.FromStream(ms)

                    End If
                Catch ex As Exception

                End Try

                dr.Close()




            Catch ex As Exception

            End Try

        End If

        con.Close()





    End Sub



    Private Sub LblContact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblContactNo.Click

    End Sub

    Private Sub LblCompanyName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblSchoolName.Click

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



            Me.TxtCompanyID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtCompanyName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtCompanyTitle.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.CmbBranchID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtContactNo.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtAddress.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.TxtEmail.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))



            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)



            Me.GrdCompanyDetails.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
            Me.GrdCompanyDetails.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)



            'MsgBox(dr.Item("Language Font"))

            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally
            con.Close()
        End Try

        'End Language

    End Sub
    'Load combo box privet sub
    Sub LoadComboBox()
        Dim con1 As New SqlConnection
        Dim cmd1 As New SqlCommand
        con1.ConnectionString = FrmHome.ConnectionString

        Dim strSQL1 As String = "SELECT [Branch ID],[Branch Name] FROM [Branch Information]"
        Dim da1 As New System.Data.SqlClient.SqlDataAdapter(strSQL1, con1)
        Dim ds1 As New DataSet
        da1.Fill(ds1, "[Branch Information]")

        With Me.CmbBranchID
            .DataSource = ds1.Tables("[Branch Information]")
            .ValueMember = "Branch ID"
            .DisplayMember = "Branch Name"
        End With

        con1.Close()

    End Sub


    Private Sub GrpCompanyDetails_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrpCompanyDetails.Enter

    End Sub

    Private Sub BtnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click
        Try

            'Making Clear
            ClearData()

            'Focus on Transaction Date
            Me.TxtCompanyName.Focus()

        Catch ex As Exception
            MessageBox.Show("Error while Adding record on table..." & ex.Message, "Add New Button")
        Finally

        End Try
    End Sub
    'Insert into log 
    Sub InsertIntoLog()

        'Data Insert Code
        Dim con As New SqlConnection
        Dim con1 As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim dr As SqlDataReader
        Dim CurrentDate As DateTime = DateTime.Today
        Dim CurrentTime As DateTime = DateTime.Now

        Try
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "select top 1 * from [Company Details] where [User account ID]='" + FrmHome.LblUserID.Text + "' and [Computer ID]='" + FrmHome.LblComputerID.Text + "'  order by [Company ID] desc"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then



                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd1.CommandText = "INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID])VALUES('" + Me.Text + "','INSERT','Company ID: " + dr.Item("Company ID").ToString + " , Company Name: " + TxtCompanyName.Text + " , Company Title: " + TxtCompanyTitle.Text + ",  Branch ID: " + CmbBranchID.Text + " , Contact No: " + TxtContactNo.Text + " , Address: " + TxtAddress.Text + " , Email: " + TxtEmail.Text + " , Status: " + TxtStatus.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + dr.Item("Company ID").ToString + "' )"
                cmd1.ExecuteNonQuery()
                con1.Close()

            End If
            dr.Close()
            con.Close()



        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally


        End Try
    End Sub

    Private Sub BtnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        'Data Insert Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now

        Try

            'Same id Twice insert restriction code
            If Not Me.TxtCompanyID.Text = "" Then
                MsgBox("This ID is already exists.", MsgBoxStyle.OkOnly, "Company Details")


            Else
                'Empty Txt Box Can Not Be Save Code
                If Me.TxtCompanyName.Text = "" Or Me.CmbBranchID.ValueMember = "" Or Me.TxtContactNo.Text = "" Then
                    MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Company Details")

                Else

                    If Not Me.PtbCompanyImage.Image Is Nothing Then

                        con.ConnectionString = FrmHome.ConnectionString
                        con.Open()
                        cmd.Connection = con
                        cmd.CommandText = "INSERT INTO [Company Details] ([Company Name],[Company Title],[Branch ID],[Contact No],[Address],[Email],[Status],[Company Image],[User Account Id],[Computer ID]) VALUES ('" + TxtCompanyName.Text + "','" + TxtCompanyTitle.Text + "','" + CmbBranchID.SelectedValue.ToString + "','" + TxtContactNo.Text + "','" + TxtAddress.Text + "','" + TxtEmail.Text + "','" + TxtStatus.Text + "',@test,'" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "')"

                        Dim ms As New MemoryStream()
                        PtbCompanyImage.Image.Save(ms, PtbCompanyImage.Image.RawFormat)
                        Dim data As Byte() = ms.GetBuffer()
                        Dim p As New SqlParameter("@test", SqlDbType.Image)
                        p.Value = data
                        cmd.Parameters.Add(p)


                        cmd.ExecuteNonQuery()
                        con.Close()

                        'Insert into log 
                        InsertIntoLog()



                    ElseIf Me.PtbCompanyImage.Image Is Nothing Then



                        con.ConnectionString = FrmHome.ConnectionString
                        con.Open()
                        cmd.Connection = con
                        cmd.CommandText = "INSERT INTO [Company Details] ([Company Name],[Company Title],[Branch ID],[Contact No],[Address],[Email],[Status],[User Account Id],[Computer ID]) VALUES ('" + TxtCompanyName.Text + "','" + TxtCompanyTitle.Text + "','" + CmbBranchID.SelectedValue.ToString + "','" + TxtContactNo.Text + "','" + TxtAddress.Text + "','" + TxtEmail.Text + "','" + TxtStatus.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "')"
                        cmd.ExecuteNonQuery()
                        con.Close()

                        'Insert into log 
                        InsertIntoLog()

                    End If



                    'Insert Click Msg
                    MsgBox("Data Inserted Successfully", MsgBoxStyle.OkOnly, "Company Details")

                    'Making Clear
                    ClearData()



                    'Refresh Data
                    RefreshData()

                    'Focus on Company name text box
                    TxtCompanyName.Focus()





                End If
            End If


        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally


        End Try
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        'Data Update Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now
        Try

            'Empty Company ID Can Not Be Update
            If Me.TxtCompanyID.Text = "" Then
                MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Company Details")


                'Empty Text Box Can Not Be update Code
            ElseIf Me.TxtCompanyName.Text = "" Or CmbBranchID.SelectedValue = 0 Or Me.TxtContactNo.Text = "" Then
                MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Company Details")

            Else
                If Not Me.PtbCompanyImage.Image Is Nothing Then

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "UPDATE [Company Details] SET [Company Name]= '" + TxtCompanyName.Text + "', [Company Title]= '" + TxtCompanyTitle.Text + "',[Branch ID] = '" + CmbBranchID.SelectedValue.ToString + "',[Contact No]= '" + TxtContactNo.Text + "',[Address]= '" + TxtAddress.Text + "',[Email]= '" + TxtEmail.Text + "',[Status]= '" + TxtStatus.Text + "',[Company Image]= @test WHERE [Company ID]= '" + TxtCompanyID.Text + "'  INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID])VALUES('" + Me.Text + "','UPDATE','Company ID: " + TxtCompanyID.Text + " , Company Name: " + TxtCompanyName.Text + " , Company Title: " + TxtCompanyTitle.Text + ",  Branch ID: " + CmbBranchID.Text + " , Contact No: " + TxtContactNo.Text + " , Address: " + TxtAddress.Text + " , Email: " + TxtEmail.Text + " , Status: " + TxtStatus.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtCompanyID.Text + "' )"



                    Dim ms As New MemoryStream()
                    PtbCompanyImage.Image.Save(ms, PtbCompanyImage.Image.RawFormat)
                    Dim data As Byte() = ms.GetBuffer()
                    Dim p As New SqlParameter("@test", SqlDbType.Image)
                    p.Value = data
                    cmd.Parameters.Add(p)



                    cmd.ExecuteNonQuery()
                    con.Close()

                ElseIf Me.PtbCompanyImage.Image Is Nothing Then

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "UPDATE [Company Details] SET [Company Name]= '" + TxtCompanyName.Text + "', [Company Title]= '" + TxtCompanyTitle.Text + "',[Branch ID] = '" + CmbBranchID.SelectedValue.ToString + "',[Contact No]= '" + TxtContactNo.Text + "',[Address]= '" + TxtAddress.Text + "',[Email]= '" + TxtEmail.Text + "',[Status]= '" + TxtStatus.Text + "',[Company Image]= '" + Nothing + "' WHERE [Company ID]= '" + TxtCompanyID.Text + "'   INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID])VALUES('" + Me.Text + "','UPDATE','Company ID: " + TxtCompanyID.Text + " , Company Name: " + TxtCompanyName.Text + " , Company Title: " + TxtCompanyTitle.Text + ",  Branch ID: " + CmbBranchID.Text + " , Contact No: " + TxtContactNo.Text + " , Address: " + TxtAddress.Text + " , Email: " + TxtEmail.Text + " , Status: " + TxtStatus.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtCompanyID.Text + "' )"


                    cmd.ExecuteNonQuery()
                    con.Close()


                End If



                'Update Click Msg
                MsgBox("Data Updated Successfully", MsgBoxStyle.OkOnly, "Company Details")

                'Making Clear
                ClearData()



                'Refresh Data
                RefreshData()
            End If
        Catch ex As Exception
            MessageBox.Show("Error while Updating record on table..." & ex.Message, "Update Records")
        Finally

        End Try
    End Sub


    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click

        'Empty Company ID Can Not Be Delete
        If Me.TxtCompanyID.Text = "" Then
            MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Company Details")
        Else

            'Data Delete Code
            Dim q As MsgBoxResult
            q = MsgBox("Do you really want to Delete the row?", MsgBoxStyle.YesNo, "Company Details")
            If q = MsgBoxResult.Yes Then

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim currentDate As DateTime = DateTime.Today
                Dim currentTime As DateTime = DateTime.Now

                Try
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "Delete from [Company Details] where [Company ID]= '" + TxtCompanyID.Text + "' INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID])VALUES('" + Me.Text + "','DELETE','Company ID: " + TxtCompanyID.Text + " , Company Name: " + TxtCompanyName.Text + " , Company Title: " + TxtCompanyTitle.Text + ",  Branch ID: " + CmbBranchID.Text + " , Contact No: " + TxtContactNo.Text + " , Address: " + TxtAddress.Text + " , Email: " + TxtEmail.Text + " , Status: " + TxtStatus.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtCompanyID.Text + "' )"
                    cmd.ExecuteNonQuery()
                    con.Close()


                    'Making Clear
                    ClearData()



                    'Refresh Data
                    RefreshData()



                Catch ex As Exception
                    MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Records")
                Finally

                End Try


            End If

        End If



    End Sub



    Private Sub GrdCompanyDetails_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub
    'Creating Privet Sub for ClearData

    Sub ClearData()
        Try
            TxtCompanyID.Text = ""
            TxtCompanyName.Text = ""
            TxtCompanyTitle.Text = ""

            CmbBranchID.SelectedValue = 0

            TxtContactNo.Text = ""
            TxtAddress.Text = ""
            TxtEmail.Text = ""

            TxtStatus.Text = ""
            TxtStatus.Text = ""

            PtbCompanyImage.Image = Nothing

        Catch ex As Exception
            MessageBox.Show("Error while Adding record on table..." & ex.Message, "Show Records")
        Finally

        End Try

    End Sub

    'Creating Prive Sub For Refresh Data
    Sub RefreshData()

        Try

            ' Load Data

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Company Details].[Company ID],[Company Details].[Company Name],[Branch Information].[Branch Name],[Company Details].[Company Title],[Company Details].[Address],[Company Details].[Email],[Company Details].[Status],[Company Details].[Contact No] FROM [Company Details] Join [Branch Information] on [Company Details].[Branch ID]= [Branch Information].[Branch ID]"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Company Details")
            connection.Close()
            GrdCompanyDetails.DataSource = ds
            GrdCompanyDetails.DataMember = "BizPro_Company Details"

            'GrdCompanyDetails.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdCompanyDetails.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdCompanyDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            CompanyNameAndAddress()


            'End Refresh Data


        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try

    End Sub


    Private Sub GrdCompanyDetails_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        Try
            'Refresh Data
            RefreshData()




        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records Refresh Button")
        Finally

        End Try
    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Eneble GroupBox
        Me.GrpCompanyDetails.Enabled = True
    End Sub

    Private Sub TxtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'Eneble GroupBox
        If e.KeyCode = Keys.Enter Then
            Me.GrpCompanyDetails.Enabled = True
        End If

    End Sub

    Private Sub TxtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtCompanyName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCompanyName.KeyDown
        'Focus on Company Title Text Box
        If e.KeyCode = Keys.Enter Then
            Me.TxtCompanyTitle.Focus()

        End If
    End Sub

    Private Sub TxtCompanyName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCompanyName.TextChanged

    End Sub

    Private Sub TxtCompanyTitle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCompanyTitle.KeyDown
        'Focus on Branch ID combo Box
        If e.KeyCode = Keys.Enter Then
            Me.CmbBranchID.Focus()

        End If
    End Sub

    Private Sub TxtCompanyTitle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCompanyTitle.TextChanged

    End Sub

    Private Sub CmbBranchID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbBranchID.KeyDown
        'Focus on Contact No Text Box
        If e.KeyCode = Keys.Enter Then
            Me.TxtContactNo.Focus()
        End If

    End Sub

    Private Sub CmbBranchID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbBranchID.SelectedIndexChanged

    End Sub

    Private Sub TxtContactNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtContactNo.KeyDown
        'Focus on Address Text Box
        If e.KeyCode = Keys.Enter Then
            Me.TxtAddress.Focus()

        End If
    End Sub

    Private Sub TxtContactNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtContactNo.TextChanged

    End Sub

    Private Sub TxtAddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtAddress.KeyDown
        'Focus on Email Text Box
        If e.KeyCode = Keys.Enter Then
            Me.TxtEmail.Focus()

        End If
    End Sub

    Private Sub TxtAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtAddress.TextChanged

    End Sub

    Private Sub TxtEmail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtEmail.KeyDown
        'Focus on Status combo Box
        If e.KeyCode = Keys.Enter Then
            Me.TxtStatus.Focus()

        End If
    End Sub

    Private Sub TxtEmail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtEmail.TextChanged

    End Sub

    Private Sub CmbSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub CmbSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LblF4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnMemberChoose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMemberChoose.Click
        'Choose Button Code
        Try


            Dim Getimage As Integer
            OpenFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*"
            Getimage = OpenFileDialog1.ShowDialog()
            If Getimage = Windows.Forms.DialogResult.OK Then
                PtbCompanyImage.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If

        Catch ex As Exception
            MessageBox.Show("Error while Inserting Picture on table..." & ex.Message, "Insert Picture")
        Finally

        End Try
    End Sub

    Private Sub BtnMemberRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMemberRemove.Click
        PtbCompanyImage.Image = Nothing
    End Sub

    Private Sub GrdCompanyDetails_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub Btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnclose.Click
        Me.Close()
    End Sub

    Private Sub Btnmaximized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnmaximized.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal

        Else
            Me.Location = New Point(0, 0)
            Me.Size = My.Computer.Screen.WorkingArea.Size
        End If
    End Sub

    Private Sub Btnminimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnminimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub GrdCompanyDetails_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdCompanyDetails.CellContentClick

    End Sub

    Private Sub GrdCompanyDetails_CellMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdCompanyDetails.CellMouseClick

        ' Cell Mouse Click Grid view code
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdCompanyDetails.Rows(e.RowIndex)

                TxtCompanyID.Text = row.Cells("Company ID").Value.ToString
                TxtCompanyName.Text = row.Cells("Company Name").Value.ToString
                TxtCompanyTitle.Text = row.Cells("Company Title").Value.ToString
                CmbBranchID.Text = row.Cells("Branch Name").Value.ToString
                TxtContactNo.Text = row.Cells("Contact No").Value.ToString
                TxtAddress.Text = row.Cells("Address").Value.ToString
                TxtEmail.Text = row.Cells("Email").Value.ToString
                TxtStatus.Text = row.Cells("Status").Value.ToString



                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim dr As SqlDataReader

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "SELECT  *FROM [Company Details]  WHERE [Company ID] = " + Me.TxtCompanyID.Text + ""
                dr = cmd.ExecuteReader()
                dr.Read()

                Me.CmbBranchID.SelectedValue = (dr.Item("Branch ID").ToString)
                PtbCompanyImage.Image = Nothing

                dr.Close()



                'Dr search For company Image
                cmd.CommandText = "SELECT  *FROM [Company Details]  WHERE [Company ID] = " + Me.TxtCompanyID.Text + " AND [Company Image] IS NOT NULL"


                dr = cmd.ExecuteReader()
                dr.Read()


                Try



                    If dr.HasRows Then

                        Dim data As Byte() = DirectCast(dr("Company Image"), Byte())
                        Dim ms As New MemoryStream(data)
                        PtbCompanyImage.Image = Image.FromStream(ms)
                    End If
                Catch ex As Exception

                End Try

                dr.Close()
                con.Close()











            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

        End Try
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