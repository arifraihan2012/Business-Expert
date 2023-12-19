
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmEmployeeInformation
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point
    Dim ChartofAccountIDForUpdate As String

    Private Sub TxtTeacherID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtEmployeeID.TextChanged

    End Sub
    Sub RefreshData()
        Try
            ' Load Data
          
            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Employee Information].[Employee ID],[Employee Information].[Employee Name],[Employee Information].[Gender],[Employee Information].[Department],[Employee Category].[Employee Category Name],[Employee Information].[Blood Group],[Employee Information].[Religion],[Employee Information].[Nationality],[Employee Information].[Date of Birth],[Employee Information].[Date of join],[Employee Information].[Date of Departure],[Employee Information].[Email Address],[Branch Information].[Branch Name],[Employee Information].[Basic Salary],[Employee Information].[Employee Status],[Employee Information].[Employee NID No],[Employee Information].[Present Address],[Employee Information].[Permanent Address],[Employee Information].[Previous Organization],[Employee Information].[Remarks],[Employee Information].[Mobile Number],[Employee Information].[Sms Notification NO],[Employee Information].[RF ID] From [Employee Information] Join [Branch Information] On [Employee Information].[Branch ID]=[Branch Information].[Branch ID] join [Employee Category] on [Employee Information].[Employee Category id]=[Employee Category].[Employee Category ID]"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Employee Information")
            connection.Close()
            GrdEmployeeInformation.DataSource = ds
            GrdEmployeeInformation.DataMember = "BizPro_Employee Information"

            'GrdProductSubcategory.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductSubcategory.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)



            'Row Count
            NUmberOfRow()

            'End Refresh Data
        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try

    End Sub


    Private Sub BtnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click
        Try
            'Focus on Group Name
            TxtEmployeeName.Focus()



            'Making Clear
            ClearData()

        Catch ex As Exception
            MessageBox.Show("Error while clearing data on table..." & ex.Message, "Add New Button")
        Finally

        End Try
    End Sub
    Sub ClearData()
        'Making Clear
        Try
            TxtEmployeeID.Text = ""
            TxtEmployeeName.Text = ""

            CmbGender.SelectedIndex = -1
            CmbGender.Text = ""


            TxtDepartment.Text = ""



            CmbEmployeeCategoryID.SelectedValue = 0

            CmbBloodGroup.SelectedIndex = -1
            CmbBloodGroup.Text = ""

            CmbReligion.SelectedIndex = -1
            CmbReligion.Text = ""

            CmbNationality.SelectedIndex = -1
            CmbNationality.Text = ""

            DtpDateofBirth.Value = Now
            DtpDateofJoin.Value = Now
            DtpDateofDeparture.Value = Now
            TxtEmailAddress.Text = ""

            TxtRFID.Text = ""


            TxtBasicSalary.Text = ""
            TxtEmployeeNIDNo.Text = ""
            TxtPresentAddress.Text = ""
            TxtPermanentAddress.Text = ""
            TxtPreviousOrganization.Text = ""
            TxtRemarks.Text = ""
            TxtMobileNumber.Text = ""
            TxtSmsNotificationNo.Text = ""
            CmbSearch.Text = ""
            TxtSearch.Text = ""
            PtbEmployeeInformation.Image = Nothing
        Catch ex As Exception
            MessageBox.Show("Error while clearing data on table..." & ex.Message, "Clear Data")
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
            cmd.CommandText = "select top 1 * from [Employee Information] where [User account ID]='" + FrmHome.LblUserID.Text + "' and [Computer ID]='" + FrmHome.LblComputerID.Text + "'  order by [Employee ID] desc"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then



                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd1.CommandText = "INSERT INTO [Log Details]([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES ('" + Me.Text + "','INSERT', 'Employee ID: " + dr.Item("Employee ID").ToString + " , Employee Name: " + TxtEmployeeName.Text + " , Gender: " + CmbGender.Text + ",  Department: " + TxtDepartment.Text + " ,Employee Category: " + CmbEmployeeCategoryID.Text + ",Blood Group: " + CmbBloodGroup.Text + ",Religion: " + CmbReligion.Text + ",Nationality: " + CmbNationality.Text + ",Date of Birth: " + DtpDateofBirth.Value + ",Date of Join: " + DtpDateofJoin.Value + ",Date of Diparture: " + DtpDateofDeparture.Value + ",Email Address: " + TxtEmailAddress.Text + ",Employee Salary: " + TxtBasicSalary.Text + ",Employee Status: " + CmbEmployeeStatus.Text + ",Employee NID No: " + TxtEmployeeNIDNo.Text + ",Presene Address: " + TxtPresentAddress.Text + ",Permanent Address: " + TxtPermanentAddress.Text + ",Previous Organization: " + TxtPreviousOrganization.Text + ",Remarks: " + TxtRemarks.Text + ",Mobile Number: " + TxtMobileNumber.Text + ",Sms Notification No: " + TxtSmsNotificationNo.Text + ",RF ID: " + TxtRFID.Text + " ','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + dr.Item("Employee ID").ToString + "' )"
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



            'Same ID twice insert restriction code
            If Not Me.TxtEmployeeID.Text = "" Then
                MsgBox("This ID is already Exist", MsgBoxStyle.OkOnly, "Employee Information")
            Else
                If Me.TxtEmployeeName.Text = "" Or Me.TxtBasicSalary.Text = "" Or Me.TxtSmsNotificationNo.Text = "" Then
                    MsgBox("Required Field can not be empty", MsgBoxStyle.OkOnly, "Employee Information")

                Else




                    Dim con5 As New SqlConnection
                    Dim cmd7 As New SqlCommand
                    Dim cmd5 As New SqlCommand
                    Dim cmd6 As New SqlCommand
                    Dim dr5 As SqlDataReader
                    Dim dr6 As SqlDataReader

                    Dim HeadOfAccountID As String
                    Dim ChartOfAccountID As String



                    con5.ConnectionString = FrmHome.ConnectionString
                    con5.Open()
                    cmd5.Connection = con5
                    cmd6.Connection = con5
                    cmd7.Connection = con5
                    cmd5.CommandText = "select [Head Of Account ID] from [Head Of Account] where [Account Name]='SALARY EXPENSE'"
                    cmd6.CommandText = "SELECT top 1 [Chart of Account ID] FROM [Chart of Account] where [User Account ID]='" + FrmHome.LblUserID.Text + "' and [Computer ID]='" + FrmHome.LblComputerID.Text + "' order by [Chart of Account ID] DESC"

                    'Data reader find head of account then send it to insert chart of account as customer
                    dr5 = cmd5.ExecuteReader()
                    dr5.Read()
                    If dr5.HasRows Then
                        HeadOfAccountID = (dr5.Item("Head Of Account ID").ToString)
                    End If
                    dr5.Close()


                    cmd7.CommandText = "INSERT INTO [Chart Of Account] ([Head Of Account ID],[Account Name],[Prepared Time],[Prepared Date],[Computer ID],[User Account ID],[Transaction Limit]) VALUES ('" + HeadOfAccountID + "','" + TxtEmployeeName.Text + "','" + currentTime + "','" + currentDate + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','00')"
                    cmd7.ExecuteNonQuery()

                    'Data reader find Chart of account then send it to insert  customer
                    dr6 = cmd6.ExecuteReader()
                    dr6.Read()
                    If dr6.HasRows Then
                        ChartOfAccountID = (dr6.Item("Chart Of Account ID").ToString)
                    End If
                    dr6.Close()

                    con5.Close()


                    If Not Me.PtbEmployeeInformation.Image Is Nothing Then
                        con.ConnectionString = FrmHome.ConnectionString
                        con.Open()
                        cmd.Connection = con
                        cmd.CommandText = "INSERT INTO [Employee Information] ([Employee Name],[Gender],[Department],[Employee Category ID],[Blood Group],[Religion],[Nationality],[Date Of Birth],[Date Of Join],[Date Of Departure],[Email Address],[Branch ID],[Basic Salary],[Employee NID No],[Present Address],[Permanent Address],[Previous Organization],[Remarks],[Mobile Number],[Sms Notification No],[Employee Status],[Employee Image],[RF ID],[Chart of Account ID],[User Account ID],[Computer ID]) VALUES ('" + TxtEmployeeName.Text + "','" + CmbGender.Text + "','" + TxtDepartment.Text + "','" + CmbEmployeeCategoryID.SelectedValue.ToString + "','" + CmbBloodGroup.Text + "','" + CmbReligion.Text + "','" + CmbNationality.Text + "','" + DtpDateofBirth.Value + "','" + DtpDateofJoin.Value + "','" + DtpDateofDeparture.Value + "','" + TxtEmailAddress.Text + "','" + FrmHome.lblBranchID.Text + "','" + TxtBasicSalary.Text + "','" + TxtEmployeeNIDNo.Text + "','" + TxtPresentAddress.Text + "','" + TxtPermanentAddress.Text + "','" + TxtPreviousOrganization.Text + "','" + TxtRemarks.Text + "','" + TxtMobileNumber.Text + "','" + TxtSmsNotificationNo.Text + "','" + CmbEmployeeStatus.Text + "',@test,'" + TxtRFID.Text + "','" + ChartOfAccountID + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "')"

                        Dim ms As New MemoryStream()
                        PtbEmployeeInformation.Image.Save(ms, PtbEmployeeInformation.Image.RawFormat)
                        Dim data As Byte() = ms.GetBuffer()
                        Dim p As New SqlParameter("@test", SqlDbType.Image)
                        p.Value = data
                        cmd.Parameters.Add(p)


                        cmd.ExecuteNonQuery()
                        con.Close()
                        'Insert into log 
                        InsertIntoLog()


                    ElseIf Me.PtbEmployeeInformation.Image Is Nothing Then

                        con.ConnectionString = FrmHome.ConnectionString
                        con.Open()
                        cmd.Connection = con
                        cmd.CommandText = "INSERT INTO [Employee Information] ([Employee Name],[Gender],[Department],[Employee Category ID],[Blood Group],[Religion],[Nationality],[Date Of Birth],[Date Of Join],[Date Of Departure],[Email Address],[Branch ID],[Basic Salary],[Employee NID No],[Present Address],[Permanent Address],[Previous Organization],[Remarks],[Mobile Number],[Sms Notification No],[Employee Status],[RF ID],[Chart of Account ID],[User Account ID],[Computer ID]) VALUES ('" + TxtEmployeeName.Text + "','" + CmbGender.Text + "','" + TxtDepartment.Text + "','" + CmbEmployeeCategoryID.SelectedValue.ToString + "','" + CmbBloodGroup.Text + "','" + CmbReligion.Text + "','" + CmbNationality.Text + "','" + DtpDateofBirth.Value + "','" + DtpDateofJoin.Value + "','" + DtpDateofDeparture.Value + "','" + TxtEmailAddress.Text + "','" + FrmHome.lblBranchID.Text + "','" + TxtBasicSalary.Text + "','" + TxtEmployeeNIDNo.Text + "','" + TxtPresentAddress.Text + "','" + TxtPermanentAddress.Text + "','" + TxtPreviousOrganization.Text + "','" + TxtRemarks.Text + "','" + TxtMobileNumber.Text + "','" + TxtSmsNotificationNo.Text + "','" + CmbEmployeeStatus.Text + "','" + TxtRFID.Text + "','" + ChartOfAccountID + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "')"
                        cmd.ExecuteNonQuery()
                        con.Close()
                        'Insert into log 
                        InsertIntoLog()

                    End If


                    'Insert Click Msg
                    MsgBox("Data Inserted Successfully", MsgBoxStyle.OkOnly, "Employee Information")
                    'Making Clear
                    ClearData()



                    'Refresh Data
                    RefreshData()

                    'Focus on Employee name text box
                    TxtEmployeeName.Focus()



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

            'Empty Employee ID Can Not Be Update
            If Me.TxtEmployeeID.Text = "" Then
                MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Employee Information")

            ElseIf Me.TxtEmployeeName.Text = "" Or Me.TxtBasicSalary.Text = "" Or Me.TxtSmsNotificationNo.Text = "" Then
                MsgBox("Required Field can not be empty", MsgBoxStyle.OkOnly, "Employee Information")


            Else
                If Not Me.PtbEmployeeInformation.Image Is Nothing Then
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "UPDATE [Employee Information] SET [Employee Name]= '" + TxtEmployeeName.Text + "',[Employee Category id]='" + CmbEmployeeCategoryID.SelectedValue.ToString + "',[Gender]= '" + CmbGender.Text + "',[Department]= '" + TxtDepartment.Text + "' ,[Blood Group]= '" + CmbBloodGroup.Text + "',[Religion]= '" + CmbReligion.Text + "',[Nationality]= '" + CmbNationality.Text + "',[Date Of Birth]= '" + DtpDateofBirth.Value + "', [Date Of Join]= '" + DtpDateofJoin.Value + "',[Date Of Departure]= '" + DtpDateofDeparture.Value + "',[Email Address]= '" + TxtEmailAddress.Text + "',[Branch ID]= '" + FrmHome.lblBranchID.Text + "',[Basic Salary]= '" + TxtBasicSalary.Text + "',[Employee NID No]= '" + TxtEmployeeNIDNo.Text + "',[Present Address]= '" + TxtPresentAddress.Text + "',[Permanent Address]= '" + TxtPermanentAddress.Text + "',[Previous Organization]= '" + TxtPreviousOrganization.Text + "',[Remarks]= '" + TxtRemarks.Text + "',[Mobile Number]= '" + TxtMobileNumber.Text + "',[Sms Notification No]= '" + TxtSmsNotificationNo.Text + "',[Employee Status]='" + CmbEmployeeStatus.Text + "',[Employee Image]=@test,[RF ID]='" + TxtRFID.Text + "' WHERE [Employee ID]= '" + TxtEmployeeID.Text + "'  UPDATE [Chart of Account] SET [Account Name]= '" + TxtEmployeeName.Text + "' Where [Chart of Account ID]='" + ChartofAccountIDForUpdate + "'    INSERT INTO [Log Details]([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES ('" + Me.Text + "','UPDATE', 'Employee ID: " + TxtEmployeeID.Text + " , Employee Name: " + TxtEmployeeName.Text + " , Gender: " + CmbGender.Text + ",  Department: " + TxtDepartment.Text + " ,Employee Category: " + CmbEmployeeCategoryID.Text + ",Blood Group: " + CmbBloodGroup.Text + ",Religion: " + CmbReligion.Text + ",Nationality: " + CmbNationality.Text + ",Date of Birth: " + DtpDateofBirth.Value + ",Date of Join: " + DtpDateofJoin.Value + ",Date of Diparture: " + DtpDateofDeparture.Value + ",Email Address: " + TxtEmailAddress.Text + ",Employee Salary: " + TxtBasicSalary.Text + ",Employee Status: " + CmbEmployeeStatus.Text + ",Employee NID No: " + TxtEmployeeNIDNo.Text + ",Presene Address: " + TxtPresentAddress.Text + ",Permanent Address: " + TxtPermanentAddress.Text + ",Previous Organization: " + TxtPreviousOrganization.Text + ",Remarks: " + TxtRemarks.Text + ",Mobile Number: " + TxtMobileNumber.Text + ",Sms Notification No: " + TxtSmsNotificationNo.Text + ",RF ID: " + TxtRFID.Text + " ','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtEmployeeID.Text + "' )"


                    Dim ms As New MemoryStream()
                    PtbEmployeeInformation.Image.Save(ms, PtbEmployeeInformation.Image.RawFormat)
                    Dim data As Byte() = ms.GetBuffer()
                    Dim p As New SqlParameter("@test", SqlDbType.Image)
                    p.Value = data
                    cmd.Parameters.Add(p)
                    cmd.ExecuteNonQuery()
                    con.Close()



                ElseIf Me.PtbEmployeeInformation.Image Is Nothing Then

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "UPDATE [Employee Information] SET [Employee Name]= '" + TxtEmployeeName.Text + "',[Employee Category id]='" + CmbEmployeeCategoryID.SelectedValue.ToString + "',[Gender]= '" + CmbGender.Text + "',[Department]= '" + TxtDepartment.Text + "' ,[Blood Group]= '" + CmbBloodGroup.Text + "',[Religion]= '" + CmbReligion.Text + "',[Nationality]= '" + CmbNationality.Text + "',[Date Of Birth]= '" + DtpDateofBirth.Value + "', [Date Of Join]= '" + DtpDateofJoin.Value + "',[Date Of Departure]= '" + DtpDateofDeparture.Value + "',[Email Address]= '" + TxtEmailAddress.Text + "',[Branch ID]= '" + FrmHome.lblBranchID.Text + "',[Basic Salary]= '" + TxtBasicSalary.Text + "',[Employee NID No]= '" + TxtEmployeeNIDNo.Text + "',[Present Address]= '" + TxtPresentAddress.Text + "',[Permanent Address]= '" + TxtPermanentAddress.Text + "',[Previous Organization]= '" + TxtPreviousOrganization.Text + "',[Remarks]= '" + TxtRemarks.Text + "',[Mobile Number]= '" + TxtMobileNumber.Text + "',[Sms Notification No]= '" + TxtSmsNotificationNo.Text + "',[Employee Status]='" + CmbEmployeeStatus.Text + "',[Employee Image]= '" + Nothing + "',[RF ID]='" + TxtRFID.Text + "' WHERE [Employee ID]= '" + TxtEmployeeID.Text + "' UPDATE [Chart of Account] SET [Account Name]= '" + TxtEmployeeName.Text + "' Where [Chart of Account ID]='" + ChartofAccountIDForUpdate + "'   INSERT INTO [Log Details]([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES ('" + Me.Text + "','UPDATE', 'Employee ID: " + TxtEmployeeID.Text + " , Employee Name: " + TxtEmployeeName.Text + " , Gender: " + CmbGender.Text + ",  Department: " + TxtDepartment.Text + " ,Employee Category: " + CmbEmployeeCategoryID.Text + ",Blood Group: " + CmbBloodGroup.Text + ",Religion: " + CmbReligion.Text + ",Nationality: " + CmbNationality.Text + ",Date of Birth: " + DtpDateofBirth.Value + ",Date of Join: " + DtpDateofJoin.Value + ",Date of Diparture: " + DtpDateofDeparture.Value + ",Email Address: " + TxtEmailAddress.Text + ",Employee Salary: " + TxtBasicSalary.Text + ",Employee Status: " + CmbEmployeeStatus.Text + ",Employee NID No: " + TxtEmployeeNIDNo.Text + ",Presene Address: " + TxtPresentAddress.Text + ",Permanent Address: " + TxtPermanentAddress.Text + ",Previous Organization: " + TxtPreviousOrganization.Text + ",Remarks: " + TxtRemarks.Text + ",Mobile Number: " + TxtMobileNumber.Text + ",Sms Notification No: " + TxtSmsNotificationNo.Text + ",RF ID: " + TxtRFID.Text + " ','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtEmployeeID.Text + "' )"
                    cmd.ExecuteNonQuery()
                    con.Close()



                End If
                'Update Click Msg
                MsgBox("Data Updated Successfully", MsgBoxStyle.OkOnly, "Employee Information")

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

        'Empty Employee ID Can Not Be Update
        If Me.TxtEmployeeID.Text = "" Then
            MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Employee Information")

        Else


            'Data Delete Code
            Dim q As MsgBoxResult
            q = MsgBox("Do you really want to Delete the row?", MsgBoxStyle.YesNo, "Employee Information")
            If q = MsgBoxResult.Yes Then

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim currentDate As DateTime = DateTime.Today
                Dim currentTime As DateTime = DateTime.Now
                Try
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "Delete from [Employee Information] where [Employee ID]= '" + TxtEmployeeID.Text + "'  Delete from [Chart of Account] where [Chart of Account ID]= '" + ChartofAccountIDForUpdate + "'  INSERT INTO [Log Details]([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES ('" + Me.Text + "','DELETE', 'Employee ID: " + TxtEmployeeID.Text + " , Employee Name: " + TxtEmployeeName.Text + " , Gender: " + CmbGender.Text + ",  Department: " + TxtDepartment.Text + " ,Employee Category: " + CmbEmployeeCategoryID.Text + ",Blood Group: " + CmbBloodGroup.Text + ",Religion: " + CmbReligion.Text + ",Nationality: " + CmbNationality.Text + ",Date of Birth: " + DtpDateofBirth.Value + ",Date of Join: " + DtpDateofJoin.Value + ",Date of Diparture: " + DtpDateofDeparture.Value + ",Email Address: " + TxtEmailAddress.Text + ",Employee Salary: " + TxtBasicSalary.Text + ",Employee Status: " + CmbEmployeeStatus.Text + ",Employee NID No: " + TxtEmployeeNIDNo.Text + ",Presene Address: " + TxtPresentAddress.Text + ",Permanent Address: " + TxtPermanentAddress.Text + ",Previous Organization: " + TxtPreviousOrganization.Text + ",Remarks: " + TxtRemarks.Text + ",Mobile Number: " + TxtMobileNumber.Text + ",Sms Notification No: " + TxtSmsNotificationNo.Text + ",RF ID: " + TxtRFID.Text + " ','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtEmployeeID.Text + "' ) "
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

    Private Sub BtnRefrersh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefrersh.Click

        Try
            'Refresh Data
            RefreshData()


        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try

    End Sub

    Private Sub GrdEmployeeInformation_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdEmployeeInformation_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

    End Sub

    Private Sub TxtEmployeeName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtEmployeeName.KeyDown
        'Focus on Gender Text Box
        If e.KeyCode = Keys.Enter Then
            Me.CmbGender.Focus()

        End If
    End Sub

    Private Sub TxtEmployeeName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtEmployeeName.KeyPress
        Try

            'key press code for upercase 
            If Char.IsLower(e.KeyChar) Then

                'Convert to uppercase, and put at the caret position in the TextBox.
                TxtEmployeeName.SelectedText = Char.ToUpper(e.KeyChar)

                e.Handled = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error while Capitalizing character to table..." & ex.Message, "Capital Word")

        End Try
    End Sub

    Private Sub TxtEmployeeName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtEmployeeName.TextChanged

    End Sub

    Private Sub CmbGender_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbGender.KeyDown
        'Focus on Department Text Box
        If e.KeyCode = Keys.Enter Then
            Me.TxtDepartment.Focus()

        End If
    End Sub

    Private Sub CmbGender_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbGender.SelectedIndexChanged

    End Sub

    Private Sub CmbDepartment_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub CmbDepartment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CmbEmployeeCategory_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub CmbEmployeeCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CmbBloodGroup_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbBloodGroup.KeyDown
        'Focus on Religion Text Box
        If e.KeyCode = Keys.Enter Then
            Me.CmbReligion.Focus()

        End If
    End Sub

    Private Sub CmbBloodGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbBloodGroup.SelectedIndexChanged

    End Sub

    Private Sub CmbReligion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbReligion.KeyDown
        'Focus on Nationality Text Box
        If e.KeyCode = Keys.Enter Then
            Me.CmbNationality.Focus()

        End If
    End Sub

    Private Sub CmbReligion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbReligion.KeyPress

    End Sub

    Private Sub CmbReligion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbReligion.SelectedIndexChanged

    End Sub

    Private Sub CmbNationality_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbNationality.KeyDown
        'Focus on Date Of Birth Text Box
        If e.KeyCode = Keys.Enter Then
            Me.DtpDateofBirth.Focus()

        End If
    End Sub

    Private Sub CmbNationality_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbNationality.SelectedIndexChanged

    End Sub

    Private Sub DtpDateofBirth_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DtpDateofBirth.KeyDown
        'Focus on Date Of Join Text Box
        If e.KeyCode = Keys.Enter Then
            Me.DtpDateofJoin.Focus()

        End If
    End Sub

    Private Sub DtpDateofBirth_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtpDateofBirth.ValueChanged

    End Sub

    Private Sub DtpDateofJoin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DtpDateofJoin.KeyDown
        'Focus on Date Of Departure Text Box
        If e.KeyCode = Keys.Enter Then
            Me.DtpDateofDeparture.Focus()

        End If
    End Sub

    Private Sub DtpDateofJoin_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtpDateofJoin.ValueChanged

    End Sub

    Private Sub DtpDateofDeparture_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DtpDateofDeparture.KeyDown
        'Focus on E-Mail Address Text Box
        If e.KeyCode = Keys.Enter Then
            Me.TxtEmailAddress.Focus()

        End If

    End Sub

    Private Sub DtpDateofDeparture_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtpDateofDeparture.ValueChanged

    End Sub

    Private Sub CmbEmployeeSubjects_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)


    End Sub

    Private Sub CmbEmployeeSubjects_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtEmailAddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtEmailAddress.KeyDown
        'Focus on Branch Text Box
        If e.KeyCode = Keys.Enter Then
            Me.TxtBasicSalary.Focus()

        End If
    End Sub

    Private Sub TxtEmailAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtEmailAddress.TextChanged

    End Sub

    Private Sub CmbEmployeeGroup_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub CmbEmployeeGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CmbBranch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)




    End Sub

    Private Sub CmbBranch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CmbShift_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub CmbShift_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtSalary_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBasicSalary.KeyDown
        'Focus on Employee Status Text Box
        If e.KeyCode = Keys.Enter Then
            Me.CmbEmployeeStatus.Focus()

        End If
    End Sub

    Private Sub TxtSalary_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBasicSalary.TextChanged

    End Sub

    Private Sub CmbVersion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub CmbVersion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtEmployeeNIDNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub TxtEmployeeNIDNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtPresentAddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPresentAddress.KeyDown
        'Focus on Permanent Address Text Box
        If e.KeyCode = Keys.Enter Then
            Me.TxtPermanentAddress.Focus()

        End If
    End Sub

    Private Sub TxtPresentAddress_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPresentAddress.KeyPress
        Try

            'key press code for upercase 

            If e.KeyChar <> ChrW(Keys.Back) Then

                'Convert to Capitalized each word, and put at the caret position in the TextBox.
                If TxtPresentAddress.Text = "" Then
                    e.KeyChar = UCase(e.KeyChar)
                End If


            End If
        Catch ex As Exception
            MessageBox.Show("Error while Capitalizing character to table..." & ex.Message, "Capital Word")

        End Try
    End Sub

    Private Sub TxtPresentAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPresentAddress.TextChanged

    End Sub

    Private Sub TxtPermanentAddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPermanentAddress.KeyDown
        'Focus on Previous Organization Text Box
        If e.KeyCode = Keys.Enter Then
            Me.TxtPreviousOrganization.Focus()

        End If
    End Sub

    Private Sub TxtPermanentAddress_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPermanentAddress.KeyPress
        Try

            'key press code for upercase 

            If e.KeyChar <> ChrW(Keys.Back) Then

                'Convert to Capitalized each word, and put at the caret position in the TextBox.
                If TxtPermanentAddress.Text = "" Then
                    e.KeyChar = UCase(e.KeyChar)
                End If


            End If
        Catch ex As Exception
            MessageBox.Show("Error while Capitalizing character to table..." & ex.Message, "Capital Word")

        End Try
    End Sub

    Private Sub TxtPermanentAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPermanentAddress.TextChanged

    End Sub

    Private Sub TxtPreviousOrganization_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPreviousOrganization.KeyDown
        'Focus on Remarks Text Box
        If e.KeyCode = Keys.Enter Then
            Me.TxtRemarks.Focus()

        End If
    End Sub

    Private Sub TxtPreviousOrganization_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPreviousOrganization.KeyPress
        Try

            'key press code for upercase 

            If e.KeyChar <> ChrW(Keys.Back) Then

                'Convert to Capitalized each word, and put at the caret position in the TextBox.
                If TxtPreviousOrganization.Text = "" Then
                    e.KeyChar = UCase(e.KeyChar)
                End If


            End If
        Catch ex As Exception
            MessageBox.Show("Error while Capitalizing character to table..." & ex.Message, "Capital Word")

        End Try
    End Sub

    Private Sub TxtPreviousOrganization_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPreviousOrganization.TextChanged

    End Sub

    Private Sub TxtRemarks_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtRemarks.KeyDown
        'Focus on Mobile No Text Box
        If e.KeyCode = Keys.Enter Then
            Me.TxtMobileNumber.Focus()

        End If
    End Sub

    Private Sub TxtRemarks_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtRemarks.KeyPress
        Try

            'key press code for upercase 

            If e.KeyChar <> ChrW(Keys.Back) Then

                'Convert to Capitalized each word, and put at the caret position in the TextBox.
                If TxtRemarks.Text = "" Then
                    e.KeyChar = UCase(e.KeyChar)
                End If


            End If
        Catch ex As Exception
            MessageBox.Show("Error while Capitalizing character to table..." & ex.Message, "Capital Word")

        End Try
    End Sub

    Private Sub TxtRemarks_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtRemarks.TextChanged

    End Sub

    Private Sub LblEmployeeSubjects_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GrpEmployeeInformation_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrpEmployeeInformation.Enter

    End Sub

    Private Sub LblBranch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GrdEmployeeInformation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub
    Sub NUmberOfRow()

        'Total gridview line show in label code
        Dim total As String = 0

        total = GrdEmployeeInformation.Rows.Count

        Me.Label15.Text = total


    End Sub

    Private Sub FrmEmployeeInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Location = New Point(0, 0)
        Me.Size = My.Computer.Screen.WorkingArea.Size


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




        'Load Combobox Employee Category
        LoadComboBoxEmployeeCategory()


        'Change Language
        ChangeLanguage()


        'Clear Data
        ClearData()





    End Sub
    'Load Combobox Employee Category
    Sub LoadComboBoxEmployeeCategory()


        Try


            Dim con1 As New SqlConnection
            Dim cmd1 As New SqlCommand
            con1.ConnectionString = FrmHome.ConnectionString

            Dim strSQL1 As String = "SELECT [Employee Category ID],[Employee Category Name] FROM [Employee Category]"
            Dim da1 As New System.Data.SqlClient.SqlDataAdapter(strSQL1, con1)
            Dim ds1 As New DataSet
            da1.Fill(ds1, "[Employee Category]")

            With Me.CmbEmployeeCategoryID
                .DataSource = ds1.Tables("[Employee Category]")
                .ValueMember = "Employee Category ID"
                .DisplayMember = "Employee Category Name"
            End With
            con1.Close()


            'Supplier Category clear code
            CmbEmployeeCategoryID.SelectedValue = 0

        Catch ex As Exception
            MsgBox(ex.Message)
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


                Me.TxtEmployeeID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtEmployeeName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.CmbGender.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtDepartment.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.CmbEmployeeCategoryID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.CmbBloodGroup.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.CmbReligion.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.CmbNationality.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtEmailAddress.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtRFID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtBasicSalary.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtEmployeeNIDNo.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtPresentAddress.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtPermanentAddress.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtPreviousOrganization.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtMobileNumber.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtSmsNotificationNo.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtSearch.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.DtpDateofBirth.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.DtpDateofJoin.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.DtpDateofDeparture.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))

                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

                Me.GrdEmployeeInformation.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdEmployeeInformation.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)


                'MsgBox(dr.Item("Language Font"))
            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while changing language on table..." & ex.Message, "Change Language")
        Finally

        End Try

        'End Language

    End Sub

    Private Sub TxtMobileNumber_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtMobileNumber.KeyDown
        'Focus on Sms Notification No Text Box
        If e.KeyCode = Keys.Enter Then
            Me.TxtSmsNotificationNo.Focus()

        End If
    End Sub

    Private Sub TxtMobileNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtMobileNumber.TextChanged

    End Sub

    Private Sub CmbSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSearch.SelectedIndexChanged
        Me.TxtSearch.Focus()
    End Sub

    Private Sub TxtEmployeeCategory_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'Focus on Blood Group Text Box
        If e.KeyCode = Keys.Enter Then
            Me.CmbBloodGroup.Focus()

        End If
    End Sub

    Private Sub TxtEmployeeCategory_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtDepartment_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDepartment.KeyDown
        'Focus on Employee Category Text Box
        If e.KeyCode = Keys.Enter Then
            Me.CmbEmployeeCategoryID.Focus()

        End If
    End Sub

    Private Sub TxtDepartment_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDepartment.TextChanged

    End Sub

    Private Sub CmbEmployeeStatus_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbEmployeeStatus.KeyDown
        'Focus on Employee NID No Text Box
        If e.KeyCode = Keys.Enter Then
            Me.TxtEmployeeNIDNo.Focus()

        End If
    End Sub

    Private Sub CmbEmployeeStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbEmployeeStatus.SelectedIndexChanged

    End Sub

    Private Sub TxtEmployeeNIDNo_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtEmployeeNIDNo.KeyDown
        'Focus on Present Address Text Box
        If e.KeyCode = Keys.Enter Then
            Me.TxtPresentAddress.Focus()

        End If
    End Sub

    Private Sub TxtEmployeeNIDNo_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtEmployeeNIDNo.TextChanged

    End Sub

    Private Sub BtnChoose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnChoose.Click
        'Choose Button Code
        Try


            Dim Getimage As Integer
            OpenFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*"
            Getimage = OpenFileDialog1.ShowDialog()
            If Getimage = Windows.Forms.DialogResult.OK Then
                PtbEmployeeInformation.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If

        Catch ex As Exception
            MessageBox.Show("Error while Inserting Picture on table..." & ex.Message, "Insert Picture")
        Finally

        End Try
    End Sub

    Private Sub BtnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemove.Click
        Try

            'Remove Button Code
            Me.PtbEmployeeInformation.Image = Nothing

        Catch ex As Exception
            MessageBox.Show("Error while Removing Picture on table..." & ex.Message, "Remove Picture")
        Finally

        End Try
    End Sub

    Private Sub TxtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearch.KeyDown
        Try

            'Search Code
            ' Load Data
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim connectionString As String = FrmHome.ConnectionString

            If Me.CmbSearch.SelectedIndex = 0 Then


                Dim sql As String = "SELECT [Employee Information].[Employee ID],[Employee Information].[Employee Name],[Employee Information].[Gender],[Employee Information].[Department],[Employee Category].[Employee Category Name],[Employee Information].[Blood Group],[Employee Information].[Religion],[Employee Information].[Nationality],[Employee Information].[Date of Birth],[Employee Information].[Date of join],[Employee Information].[Date of Departure],[Employee Information].[Email Address],[Branch Information].[Branch Name],[Employee Information].[Basic Salary],[Employee Information].[Employee Status],[Employee Information].[Employee NID No],[Employee Information].[Present Address],[Employee Information].[Permanent Address],[Employee Information].[Previous Organization],[Employee Information].[Remarks],[Employee Information].[Mobile Number],[Employee Information].[Sms Notification NO],[Employee Information].[RF ID] From [Employee Information] Join [Branch Information] On [Employee Information].[Branch ID]=[Branch Information].[Branch ID] join [Employee Category] on [Employee Information].[Employee Category id]=[Employee Category].[employee Category ID] WHERE ([Employee Information].[Employee ID] LIKE '" + Me.TxtSearch.Text + "')"

                Dim connection As New SqlConnection(connectionString)

                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Employee Information")
                connection.Close()
                GrdEmployeeInformation.DataSource = ds
                GrdEmployeeInformation.DataMember = "BizPro_Employee Information"




                'Row Count
                NUmberOfRow()

            End If


        Catch ex As Exception
            MessageBox.Show("Error while searching records on table..." & ex.Message, "Search Records")
        Finally

        End Try
    End Sub

    Private Sub TxtSearch_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSearch.TabIndexChanged

    End Sub

    Private Sub TxtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearch.TextChanged
        Try

            'Search Code
            ' Load Data
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim connectionString As String = FrmHome.ConnectionString
            If Me.CmbSearch.SelectedIndex = 1 Then



                Dim sql As String = "SELECT [Employee Information].[Employee ID],[Employee Information].[Employee Name],[Employee Information].[Gender],[Employee Information].[Department],[Employee Category].[Employee Category Name],[Employee Information].[Blood Group],[Employee Information].[Religion],[Employee Information].[Nationality],[Employee Information].[Date of Birth],[Employee Information].[Date of join],[Employee Information].[Date of Departure],[Employee Information].[Email Address],[Branch Information].[Branch Name],[Employee Information].[Basic Salary],[Employee Information].[Employee Status],[Employee Information].[Employee NID No],[Employee Information].[Present Address],[Employee Information].[Permanent Address],[Employee Information].[Previous Organization],[Employee Information].[Remarks],[Employee Information].[Mobile Number],[Employee Information].[Sms Notification NO],[Employee Information].[RF ID] From [Employee Information] Join [Branch Information] On [Employee Information].[Branch ID]=[Branch Information].[Branch ID] join [Employee Category] on [Employee Information].[Employee Category id]=[Employee Category].[employee Category ID] WHERE ([Employee Information].[Employee Name] LIKE '%" + Me.TxtSearch.Text + "%')"

                Dim connection As New SqlConnection(connectionString)

                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Employee Information")
                connection.Close()
                GrdEmployeeInformation.DataSource = ds
                GrdEmployeeInformation.DataMember = "BizPro_Employee Information"



                'Row Count
                NUmberOfRow()
            End If


        Catch ex As Exception
            MessageBox.Show("Error while searching records on table..." & ex.Message, "Search Records")
        Finally

        End Try
    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        Try

            'Search Code
            ' Load Data
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim connectionString As String = FrmHome.ConnectionString
            If Me.CmbSearch.SelectedIndex = 0 Then



                Dim sql As String = "SELECT [Employee Information].[Employee ID],[Employee Information].[Employee Name],[Employee Information].[Gender],[Employee Information].[Department],[Employee Category].[Employee Category Name],[Employee Information].[Blood Group],[Employee Information].[Religion],[Employee Information].[Nationality],[Employee Information].[Date of Birth],[Employee Information].[Date of join],[Employee Information].[Date of Departure],[Employee Information].[Email Address],[Branch Information].[Branch Name],[Employee Information].[Basic Salary],[Employee Information].[Employee Status],[Employee Information].[Employee NID No],[Employee Information].[Present Address],[Employee Information].[Permanent Address],[Employee Information].[Previous Organization],[Employee Information].[Remarks],[Employee Information].[Mobile Number],[Employee Information].[Sms Notification NO],[Employee Information].[RF ID] From [Employee Information] Join [Branch Information] On [Employee Information].[Branch ID]=[Branch Information].[Branch ID] join [Employee Category] on [Employee Information].[Employee Category id]=[Employee Category].[employee Category ID] WHERE ([Employee Information].[Employee ID] = '" + Me.TxtSearch.Text + "')"

                Dim connection As New SqlConnection(connectionString)

                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Employee Information")
                connection.Close()
                GrdEmployeeInformation.DataSource = ds
                GrdEmployeeInformation.DataMember = "BizPro_Employee Information"




                'Row Count
                NUmberOfRow()
            End If


        Catch ex As Exception
            MessageBox.Show("Error while searching records on table..." & ex.Message, "Search Records Button Click")
        Finally

        End Try


    End Sub

    Private Sub TxtSmsNotificationNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSmsNotificationNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TxtRFID.Focus()
        End If
    End Sub

    Private Sub TxtSmsNotificationNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSmsNotificationNo.TextChanged

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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnminimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnmaximized.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal

        Else
            Me.WindowState = FormWindowState.Maximized

        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnclose.Click
        Me.Close()
    End Sub

    Private Sub GrdEmployeeInformation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    End Sub

    Private Sub GrdEmployeeInformation_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdEmployeeInformation.CellContentClick

    End Sub

    Private Sub GrdEmployeeInformation_CellMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdEmployeeInformation.CellMouseClick
        'Data Grid view code
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdEmployeeInformation.Rows(e.RowIndex)

                TxtEmployeeID.Text = row.Cells("Employee ID").Value.ToString
                TxtEmployeeName.Text = row.Cells("Employee Name").Value.ToString
                CmbGender.Text = row.Cells("Gender").Value.ToString
                TxtDepartment.Text = row.Cells("Department").Value.ToString
                CmbEmployeeCategoryID.Text = row.Cells("Employee Category Name").Value.ToString
                CmbBloodGroup.Text = row.Cells("Blood Group").Value.ToString
                CmbReligion.Text = row.Cells("Religion").Value.ToString
                CmbNationality.Text = row.Cells("Nationality").Value.ToString
                DtpDateofBirth.Text = row.Cells("Date Of Birth").Value.ToString
                DtpDateofJoin.Text = row.Cells("Date of Join").Value.ToString
                DtpDateofDeparture.Text = row.Cells("Date Of Departure").Value.ToString
                TxtEmailAddress.Text = row.Cells("Email Address").Value.ToString

                TxtBasicSalary.Text = row.Cells("Basic Salary").Value.ToString
                TxtEmployeeNIDNo.Text = row.Cells("Employee NID No").Value.ToString
                TxtPresentAddress.Text = row.Cells("Present Address").Value.ToString
                TxtPermanentAddress.Text = row.Cells("Permanent Address").Value.ToString
                TxtPreviousOrganization.Text = row.Cells("Previous Organization").Value.ToString
                TxtRemarks.Text = row.Cells("Remarks").Value.ToString
                TxtMobileNumber.Text = row.Cells("Mobile Number").Value.ToString
                TxtSmsNotificationNo.Text = row.Cells("Sms Notification No").Value.ToString
                CmbEmployeeStatus.Text = row.Cells("Employee Status").Value.ToString
                TxtRFID.Text = row.Cells("RF ID").Value.ToString

                Me.PtbEmployeeInformation.Image = Nothing


                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim dr As SqlDataReader


                Dim cmd1 As New SqlCommand
                Dim dr1 As SqlDataReader

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd1.Connection = con
                cmd1.CommandText = "SELECT  *FROM [Employee Information]  WHERE [Employee ID] = " + Me.TxtEmployeeID.Text + " "

                dr1 = cmd1.ExecuteReader
                dr1.Read()


                If dr1.HasRows Then
                    ChartofAccountIDForUpdate = dr1.Item("Chart of Account ID").ToString

                End If
                dr1.Close()




                cmd.CommandText = "SELECT  *FROM [Employee Information]  WHERE [Employee ID] = " + Me.TxtEmployeeID.Text + " AND [Employee Image] IS NOT NULL"

                dr = cmd.ExecuteReader()
                dr.Read()


                Try


                    If dr.HasRows Then


                        Dim data As Byte() = DirectCast(dr("Employee Image"), Byte())
                        Dim ms As New MemoryStream(data)
                        PtbEmployeeInformation.Image = Image.FromStream(ms)



                    End If
                    dr.Close()
                Catch ex As Exception

                End Try

                con.Close()

            End If



        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview")

        End Try

    End Sub

    Private Sub CmbEmployeeCategoryID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbEmployeeCategoryID.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbBloodGroup.Focus()
        End If
    End Sub

    Private Sub CmbEmployeeCategoryID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbEmployeeCategoryID.SelectedIndexChanged

    End Sub
End Class