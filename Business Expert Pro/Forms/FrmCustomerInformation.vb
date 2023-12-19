Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class FrmCustomerInformation
    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point
    Dim OpeningBalance As String
    Dim ChartOfAccountIDforOpeningBalanceAdd As String


    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblCustomerName.Click

    End Sub

    Private Sub TxtDesignation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDesignation.KeyDown
        'Focus on Mobile No text box

        If e.KeyCode = Keys.Enter Then
            Me.TxtMobileNo.Focus()

        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDesignation.TextChanged

    End Sub

    Private Sub TxtCity_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCity.KeyDown
        'Focus on Country text box

        If e.KeyCode = Keys.Enter Then
            Me.TxtCountry.Focus()

        End If
    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCity.TextChanged

    End Sub

    Private Sub TxtCustomerID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCustomerID.TextChanged

    End Sub

    Private Sub TxtCompanyName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCompanyName.KeyDown

        'Focus on Designation text box

        If e.KeyCode = Keys.Enter Then
            Me.TxtDesignation.Focus()

        End If
    End Sub

    Private Sub TxtCompanyName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCompanyName.TextChanged
        'Change all text entered to be Upercase.
        'TxtCompanyName.CharacterCasing = CharacterCasing.Upper

    End Sub

    Private Sub TxtWebAddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtWebAddress.KeyDown

        'Focus on City text box
        If e.KeyCode = Keys.Enter Then
            Me.TxtCity.Focus()

        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtWebAddress.TextChanged

    End Sub

    Private Sub ChkOff_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub FrmCustomerInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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










        'Change Lnaguage
        ChangeLanguage()

        'Load Combo Box Branch ID()
        LoadComboBranchID()

        'Load Combo Box Employee()
        LoadComboBoxEmployee()

        'Load Combobox Customer
        LoadComboBoxCustomer()

        'Load Combo Box Customer Category()
        LoadComboBoxCustomerCategory()

        'clear data
        ClearData()


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


                Me.TxtCustomerID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.CmbCustomerCategoryID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.CmbCustomerName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtCompanyName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtDesignation.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtMobileNo.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtEmailAddress.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtAddress.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtWebAddress.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtCity.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtCountry.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.CmbProductID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtPrice.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.CmbSearchProductPrice.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtSearch.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtOpeningBalance.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtTransactionLimit.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.DtpLedgerDate.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))

                Me.TxtDiscountPercentage.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.CmbBranchID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.CmbEmployeeID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))

                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)


                Me.GrdCustomerInformation.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdCustomerInformation.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)
                Me.GrdPriceList.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdPriceList.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)


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

    Private Sub BtnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Eneble Group Box
        GrpCustomerInformation.Enabled = True
    End Sub

    Private Sub BtnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CmbCustomerCategory_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        'Focus on Customer Name
        If e.KeyCode = Keys.Enter Then
            Me.CmbCustomerName.Focus()

        End If



    End Sub

    Private Sub CmbCustomerCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub TxtCustomerName_Layout(ByVal sender As Object, ByVal e As System.Windows.Forms.LayoutEventArgs)

    End Sub


    Private Sub TxtMobileNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtMobileNo.KeyDown

        'Focus on Email Address Text box
        If e.KeyCode = Keys.Enter Then
            Me.TxtEmailAddress.Focus()

        End If
    End Sub

    Private Sub TxtMobileNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtMobileNo.TextChanged

    End Sub

    Private Sub TxtEmailAddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtEmailAddress.KeyDown

        'Focus on Address Text box
        If e.KeyCode = Keys.Enter Then
            Me.TxtAddress.Focus()

        End If
    End Sub

    Private Sub TxtEmailAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtEmailAddress.TextChanged

    End Sub

    Private Sub TxtAddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtAddress.KeyDown
        'Focus on Web Address Text box

        If e.KeyCode = Keys.Enter Then
            Me.TxtWebAddress.Focus()

        End If
    End Sub

    Private Sub TxtAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtAddress.TextChanged

    End Sub

    Private Sub TxtCountry_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCountry.KeyDown
        'Focus on Sms Notification Combo box

        If e.KeyCode = Keys.Enter Then
            Me.CmbStatus.Focus()

        End If
    End Sub

    Private Sub TxtCountry_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCountry.TextChanged

    End Sub

    Private Sub CmbStatus_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'Focus on DiscountPercentage  text box

        If e.KeyCode = Keys.Enter Then
            Me.TxtDiscountPercentage.Focus()


        End If
    End Sub

    Private Sub CmbStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CmbSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbSearch.KeyDown
        'Focus on Search  text box


        If e.KeyCode = Keys.Enter Then
            Me.TxtSearch.Focus()

        End If
    End Sub

    Private Sub CmbSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSearch.SelectedIndexChanged

        If CmbSearch.SelectedIndex = 5 Then
            TxtSearch.Visible = False
            CmbSearchProductPrice.Visible = True
            CmbSearchProductPrice.Focus()
            LblF4Lbl.Visible = True
        Else
            TxtSearch.Visible = True
            CmbSearchProductPrice.Visible = False
            TxtSearch.Focus()
            LblF4Lbl.Visible = False
        End If

    End Sub

    Private Sub TxtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearch.KeyDown
        'Eneble Group Box
        If e.KeyCode = Keys.Enter Then
            Try



                'Search Code
                
                Dim connectionString As String = FrmHome.ConnectionString
                If Me.CmbSearch.SelectedIndex = 0 Then

                    Dim sql As String = "SELECT [Customer Information].[Customer ID],[Customer Information].[Customer Name],[Customer Category].[Customer Category Name],[Customer Information].[Company Name],[Customer Information].[Designation],[Customer Information].[Mobile No],[Customer Information].[Email Address],[Customer Information].[Address],[Customer Information].[Web Address],[Customer Information].[City],[Customer Information].[Country],[Customer Information].[SMS Notification],[Customer Information].[Status],[Customer Information].[Discount Percentage],[Branch Information].[Branch Name],[Employee Information].[Employee Name] FROM [Customer Information] Join [Customer Category] on [Customer Information].[Customer Category ID]=[Customer Category].[Customer Category ID] join [Branch Information] on [Customer Information].[Branch ID]=[Branch Information].[Branch ID] join [Employee Information] on [Customer Information].[employee ID]=[Employee Information].[employee ID] WHERE ([Customer Information].[Customer ID]  = '" + Me.TxtSearch.Text + "') order by [Customer Information].[Customer ID] desc "
                    Dim connection As New SqlConnection(connectionString)
                    Dim dataadapter As New SqlDataAdapter(sql, connection)
                    Dim ds As New DataSet()
                    connection.Open()
                    dataadapter.Fill(ds, "BizPro_Customer Information")
                    connection.Close()
                    GrdCustomerInformation.DataSource = ds
                    GrdCustomerInformation.DataMember = "BizPro_Customer Information"
                    'GrdCustomerInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                    'Row Count
                    NUmberOfRow()



                ElseIf Me.CmbSearch.SelectedIndex = 3 Then


                    Dim sql As String = "SELECT [Customer Information].[Customer ID],[Customer Information].[Customer Name],[Customer Category].[Customer Category Name],[Customer Information].[Company Name],[Customer Information].[Designation],[Customer Information].[Mobile No],[Customer Information].[Email Address],[Customer Information].[Address],[Customer Information].[Web Address],[Customer Information].[City],[Customer Information].[Country],[Customer Information].[SMS Notification],[Customer Information].[Status],[Customer Information].[Discount Percentage],[Branch Information].[Branch Name],[Employee Information].[Employee Name]  FROM [Customer Information] Join [Customer Category] on [Customer Information].[Customer Category ID]=[Customer Category].[Customer Category ID] join [Branch Information] on [Customer Information].[Branch ID]=[Branch Information].[Branch ID] join [Employee Information] on [Customer Information].[employee ID]=[Employee Information].[employee ID]   WHERE ([Customer Information].[Mobile No]  = '" + Me.TxtSearch.Text + "') order by [Customer Information].[Customer ID] desc "
                    Dim connection As New SqlConnection(connectionString)
                    Dim dataadapter As New SqlDataAdapter(sql, connection)
                    Dim ds As New DataSet()
                    connection.Open()
                    dataadapter.Fill(ds, "BizPro_Customer Information")
                    connection.Close()
                    GrdCustomerInformation.DataSource = ds
                    GrdCustomerInformation.DataMember = "BizPro_Customer Information"
                    'GrdCustomerInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                    'Row Count
                    NUmberOfRow()



                End If

            Catch ex As Exception
                MessageBox.Show("Error while searching records on table..." & ex.Message, "Search Records on KeyDown")
            Finally

            End Try
        End If
    End Sub

    Private Sub TxtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearch.TextChanged
        Try



            'Search Code


            Dim connectionString As String = FrmHome.ConnectionString
            If Me.CmbSearch.SelectedIndex = 1 Then

                Dim sql As String = "SELECT [Customer Information].[Customer ID],[Customer Information].[Customer Name],[Customer Category].[Customer Category Name],[Customer Information].[Company Name],[Customer Information].[Designation],[Customer Information].[Mobile No],[Customer Information].[Email Address],[Customer Information].[Address],[Customer Information].[Web Address],[Customer Information].[City],[Customer Information].[Country],[Customer Information].[SMS Notification],[Customer Information].[Status],[Customer Information].[Discount Percentage],[Branch Information].[Branch Name],[Employee Information].[Employee Name]   FROM [Customer Information] Join [Customer Category] on [Customer Information].[Customer Category ID]=[Customer Category].[Customer Category ID] join [Branch Information] on [Customer Information].[Branch ID]=[Branch Information].[Branch ID] join [Employee Information] on [Customer Information].[employee ID]=[Employee Information].[employee ID]     WHERE ([Customer Information].[Customer Name]  Like '%" + Me.TxtSearch.Text + "%') order by [Customer Information].[Customer ID] desc "
                Dim connection As New SqlConnection(connectionString)
                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Customer Information")
                connection.Close()
                GrdCustomerInformation.DataSource = ds
                GrdCustomerInformation.DataMember = "BizPro_Customer Information"
                'GrdCustomerInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                'Row Count
                NUmberOfRow()



            ElseIf Me.CmbSearch.SelectedIndex = 2 Then


                Dim sql As String = "SELECT [Customer Information].[Customer ID],[Customer Information].[Customer Name],[Customer Category].[Customer Category Name],[Customer Information].[Company Name],[Customer Information].[Designation],[Customer Information].[Mobile No],[Customer Information].[Email Address],[Customer Information].[Address],[Customer Information].[Web Address],[Customer Information].[City],[Customer Information].[Country],[Customer Information].[SMS Notification],[Customer Information].[Status],[Customer Information].[Discount Percentage],[Branch Information].[Branch Name] ,[Employee Information].[Employee Name]  FROM [Customer Information] Join [Customer Category] on [Customer Information].[Customer Category ID]=[Customer Category].[Customer Category ID] join [Branch Information] on [Customer Information].[Branch ID]=[Branch Information].[Branch ID] join [Employee Information] on [Customer Information].[employee ID]=[Employee Information].[employee ID] WHERE ([Customer Information].[company Name]  Like '%" + Me.TxtSearch.Text + "%')  order by [Customer Information].[Customer ID] desc   "
                Dim connection As New SqlConnection(connectionString)
                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Customer Information")
                connection.Close()
                GrdCustomerInformation.DataSource = ds
                GrdCustomerInformation.DataMember = "BizPro_Customer Information"
                'GrdCustomerInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                'Row Count
                NUmberOfRow()



            ElseIf Me.CmbSearch.SelectedIndex = 4 Then


                Dim sql As String = "SELECT [Customer Information].[Customer ID],[Customer Information].[Customer Name],[Customer Category].[Customer Category Name],[Customer Information].[Company Name],[Customer Information].[Designation],[Customer Information].[Mobile No],[Customer Information].[Email Address],[Customer Information].[Address],[Customer Information].[Web Address],[Customer Information].[City],[Customer Information].[Country],[Customer Information].[SMS Notification],[Customer Information].[Status],[Customer Information].[Discount Percentage],[Branch Information].[Branch Name],[Employee Information].[Employee Name] FROM [Customer Information] Join [Customer Category] on [Customer Information].[Customer Category ID]=[Customer Category].[Customer Category ID] join [Branch Information] on [Customer Information].[Branch ID]=[Branch Information].[Branch ID] join [Employee Information] on [Customer Information].[employee ID]=[Employee Information].[employee ID]   WHERE ([Customer Category].[Customer Category Name]  Like '%" + Me.TxtSearch.Text + "%')   order by [Customer Information].[Customer ID] desc "
                Dim connection As New SqlConnection(connectionString)
                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Customer Information")
                connection.Close()
                GrdCustomerInformation.DataSource = ds
                GrdCustomerInformation.DataMember = "BizPro_Customer Information"
                'GrdCustomerInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                'Row Count
                NUmberOfRow()


            End If

        Catch ex As Exception
            MessageBox.Show("Error while searching records on table..." & ex.Message, "Search Records")
        Finally

        End Try
    End Sub

    Private Sub LblInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    'Creating Privet Sub For Clear Data
    Sub ClearData()
        TxtCustomerID.Text = ""

        CmbCustomerCategoryID.SelectedValue = 0
        CmbBranchID.SelectedValue = 0
        CmbEmployeeID.SelectedValue = 0


        CmbCustomerName.Text = ""
        TxtCompanyName.Text = ""
        TxtDesignation.Text = ""
        TxtMobileNo.Text = ""
        TxtEmailAddress.Text = ""
        TxtAddress.Text = ""
        TxtWebAddress.Text = ""
        TxtCity.Text = ""
        TxtCountry.Text = ""

        CmbSmsNotification.SelectedIndex = -1
        CmbSmsNotification.Text = ""

        CmbStatus.SelectedIndex = -1
        CmbStatus.Text = ""

        TxtOpeningBalance.Text = ""


        TxtDiscountPercentage.Text = ""

        Me.CustomerPictureBox.Image = Nothing


        CmbProductID.Text = ""
        CmbProductID.ValueMember = ""
        TxtPrice.Text = ""
        lblListID.Text = "00"

        TxtTransactionLimit.Text = ""

        DtpLedgerDate.Value = Now
    End Sub
    'Clear Data Product Price
    Sub ClearDataProductPrice()

        CmbProductID.Text = ""
        CmbProductID.ValueMember = ""
        TxtPrice.Text = ""
        lblListID.Text = "00"


    End Sub

    'Creating Privet Sub of Refreshing Product Data
    Sub RefreshDataProductSpecificCustomer()

        Try



           
            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Customer price list].[Customer price list ID][ID],[Products].[Product Name],[Customer Price list].[Price] FROM [Customer Price list] Join [Products] on [Customer Price list].[Product ID]=[Products].[Product ID] where [Customer price list].[Customer ID]='" + TxtCustomerID.Text + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Customer Information")
            connection.Close()
            GrdPriceList.DataSource = ds
            GrdPriceList.DataMember = "BizPro_Customer Information"

            'GrdCustomerInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdCustomerInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdPriceList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill



            'Number of row count


            'End Refresh Data
        Catch ex As Exception
            MessageBox.Show("Error while refreshing record on table..." & ex.Message, "Refresh Records")
        Finally


        End Try

        'End Refresh Data

    End Sub
    'Creating Privet Sub of Refreshing Data
    Sub RefreshData()

        Try


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Customer Information].[Customer ID],[Customer Information].[Customer Name],[Customer Category].[Customer Category Name],[Customer Information].[Company Name],[Customer Information].[Designation],[Customer Information].[Mobile No],[Customer Information].[Email Address],[Customer Information].[Address],[Customer Information].[Web Address],[Customer Information].[City],[Customer Information].[Country],[Customer Information].[SMS Notification],[Customer Information].[Status],[Customer Information].[Discount Percentage],[Branch Information].[Branch Name] ,[Employee Information].[Employee Name] FROM [Customer Information] Join [Customer Category] on [Customer Information].[Customer Category ID]=[Customer Category].[Customer Category ID] join [Branch Information] on [Customer Information].[Branch ID]=[Branch Information].[Branch ID] join [Employee Information] on [Customer Information].[employee ID]=[Employee Information].[employee ID]   order by [Customer Information].[Customer ID] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Customer Information")
            connection.Close()
            GrdCustomerInformation.DataSource = ds
            GrdCustomerInformation.DataMember = "BizPro_Customer Information"

            'GrdCustomerInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdCustomerInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)


            'Number of row count
            NUmberOfRow()

            'Creating Privet Sub of Refreshing Product Data
            RefreshDataProductSpecificCustomer()



        Catch ex As Exception
            MessageBox.Show("Error while refreshing data on table..." & ex.Message, "Refresh records")
        Finally

        End Try

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click

        Try


            'Making Clear
            ClearData()

            'show status= connected and sms notification= on 
            CmbStatus.SelectedIndex = 0
            CmbSmsNotification.SelectedIndex = 0
            TxtDiscountPercentage.Text = "0"
            CmbBranchID.SelectedValue = FrmHome.lblBranchID.Text
            CmbEmployeeID.SelectedValue = FrmHome.EmployeeID

            'Focus On Branch Name
            CmbCustomerName.Focus()




        Catch ex As Exception
            MessageBox.Show("Error while adding data on table..." & ex.Message, "Add New Button")
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
            cmd.CommandText = "select top 1 * from [Customer Information] where [User account ID]='" + FrmHome.LblUserID.Text + "' and [Computer ID]='" + FrmHome.LblComputerID.Text + "'  order by [Customer ID] desc"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then



                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd1.CommandText = "INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES ('" + Me.Text + "','INSERT', 'Customer ID: " + dr.Item("Customer ID").ToString + " , Customer Name: " + CmbCustomerName.Text + " , Customer Category ID: " + CmbCustomerCategoryID.Text + ",  Company Name: " + TxtCompanyName.Text + " , Designation: " + TxtDesignation.Text + ",  Mobile No: " + TxtMobileNo.Text + " ,  Email Address: " + TxtEmailAddress.Text + " ,  Address: " + TxtAddress.Text + " ,  Web Address: " + TxtWebAddress.Text + " ,  Opening Balance: " + TxtOpeningBalance.Text + " ,  Opening Balance Date: " + DtpLedgerDate.Value + " ,  City: " + TxtCity.Text + " ,  Country: " + TxtCountry.Text + " ,  Status: " + CmbStatus.Text + " ,  SMS Notification: " + CmbSmsNotification.Text + " ,  Discount Percentage: " + TxtDiscountPercentage.Text + " ,  Transaction Limit: " + TxtTransactionLimit.Text + " ,  Product ID: " + CmbProductID.Text + " ,  Price: " + TxtPrice.Text + " ' ,'" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + dr.Item("Customer ID").ToString + "' )"
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInsert.Click
        'Data Insert Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand


        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now


        Try

            'Same id Twice insert restriction code
            If Not Me.TxtCustomerID.Text = "" Then
                MsgBox("This ID is already Exist.", MsgBoxStyle.OkOnly, "Customer Information")


            Else


                'Empty Txt Box Can Not Be Save Code
                If Me.CmbCustomerCategoryID.SelectedValue = 0 Or Me.CmbCustomerName.Text = "" Or Me.CmbSmsNotification.Text = "" Or Me.CmbStatus.Text = "" Or Me.TxtDiscountPercentage.Text = "" Or CmbBranchID.Text = "" Or CmbEmployeeID.Text = "" Then
                    MsgBox("Required field can not be empty", MsgBoxStyle.Critical, "Customer Information")

                Else

                    Dim con5 As New SqlConnection
                    Dim cmd7 As New SqlCommand
                    Dim cmd5 As New SqlCommand
                    Dim cmd6 As New SqlCommand
                    Dim dr5 As SqlDataReader
                    Dim dr6 As SqlDataReader

                    Dim HeadOfAccountID As String
                    Dim ChartOfAccountID As String

                    Dim AccountsReceivable As String
                    AccountsReceivable = Val(TxtOpeningBalance.Text) * -1


                    con5.ConnectionString = FrmHome.ConnectionString
                    con5.Open()
                    cmd5.Connection = con5
                    cmd6.Connection = con5
                    cmd7.Connection = con5
                    cmd5.CommandText = "select [Head Of Account ID] from [Head Of Account] where [Account Name]='Supplier And Customer'"
                    cmd6.CommandText = "SELECT top 1 [Chart of Account ID] FROM [Chart of Account] where [User Account ID]='" + FrmHome.LblUserID.Text + "' and [Computer ID]='" + FrmHome.LblComputerID.Text + "' order by [Chart of Account ID] DESC"

                    'Data reader find head of account then send it to insert chart of account as customer
                    dr5 = cmd5.ExecuteReader()
                    dr5.Read()
                    If dr5.HasRows Then
                        HeadOfAccountID = (dr5.Item("Head Of Account ID").ToString)
                    End If
                    dr5.Close()


                    cmd7.CommandText = "INSERT INTO [Chart Of Account] ([Head Of Account ID],[Account Name],[Prepared Time],[Prepared Date],[Computer ID],[User Account ID],[Transaction Limit]) VALUES ('" + HeadOfAccountID + "','" + CmbCustomerName.Text + "','" + currentTime + "','" + currentDate + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + TxtTransactionLimit.Text + "')"
                    cmd7.ExecuteNonQuery()

                    'Data reader find Chart of account then send it to insert  customer
                    dr6 = cmd6.ExecuteReader()
                    dr6.Read()
                    If dr6.HasRows Then
                        ChartOfAccountID = (dr6.Item("Chart Of Account ID").ToString)
                    End If
                    dr6.Close()

                    con5.Close()



                    If Not Me.CustomerPictureBox.Image Is Nothing Then

                        con.ConnectionString = FrmHome.ConnectionString
                        con.Open()
                        cmd.Connection = con
                        cmd1.Connection = con
                        cmd2.Connection = con
                        cmd.CommandText = "INSERT INTO [Customer Information] ([Customer Category ID],[Customer Name],[Company Name],[Designation],[Mobile No],[Email Address],[Address],[Web Address],[City],[Country],[Sms Notification],[Status],[Discount Percentage],[Customer Image],[Prepared Time],[Prepared Date],[Computer ID],[User Account ID],[Branch ID],[Chart Of Account ID],[Employee ID]) VALUES ('" + CmbCustomerCategoryID.SelectedValue.ToString + "','" + CmbCustomerName.Text + "','" + TxtCompanyName.Text + "','" + TxtDesignation.Text + "','" + TxtMobileNo.Text + "','" + TxtEmailAddress.Text + "','" + TxtAddress.Text + "','" + TxtWebAddress.Text + "','" + TxtCity.Text + "','" + TxtCountry.Text + "','" + CmbSmsNotification.Text + "','" + CmbStatus.Text + "','" + TxtDiscountPercentage.Text + "',@test,'" + currentTime + "','" + currentDate + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + CmbBranchID.SelectedValue.ToString + "','" + ChartOfAccountID + "','" + CmbEmployeeID.SelectedValue.ToString + "')"
                        cmd1.CommandText = "INSERT INTO [Ledger] ([Chart of Account ID],[Debited Amount],[Credited Amount],[Category Name],[Ledger Date],[Prepared Time],[Prepared Date],[Computer ID],[User Account ID],[Branch ID],[Invoice No],[Status],[Description],[Voucher No]) VALUES ('" + ChartOfAccountID + "','" + TxtOpeningBalance.Text + "','0','Customer Opening Balance','" + DtpLedgerDate.Value + "','" + currentTime + "','" + currentDate + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.lblBranchID.Text + "','OB','CASH','Opening Balance','OB')"
                        cmd2.CommandText = "INSERT INTO [Ledger] ([Chart of Account ID],[Debited Amount],[Credited Amount],[Category Name],[Ledger Date],[Prepared Time],[Prepared Date],[Computer ID],[User Account ID],[Branch ID],[Invoice No],[Status],[Description],[Voucher No]) VALUES ('" + ChartOfAccountID + "','0','" + AccountsReceivable + "','Customer Opening Balance','" + DtpLedgerDate.Value + "','" + currentTime + "','" + currentDate + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.lblBranchID.Text + "','OB','CASH','Opening Balance','OB')"

                        Dim ms As New MemoryStream()
                        CustomerPictureBox.Image.Save(ms, CustomerPictureBox.Image.RawFormat)
                        Dim data As Byte() = ms.GetBuffer()
                        Dim p As New SqlParameter("@test", SqlDbType.Image)
                        p.Value = data
                        cmd.Parameters.Add(p)

                        cmd.ExecuteNonQuery()


                        If Val(TxtOpeningBalance.Text) > 0 Then
                            cmd1.ExecuteNonQuery()
                        ElseIf Val(TxtOpeningBalance.Text) < 0 Then
                            cmd2.ExecuteNonQuery()
                        End If
                        con.Close()

                        'Insert into log 
                        InsertIntoLog()

                    ElseIf Me.CustomerPictureBox.Image Is Nothing Then
                        con.ConnectionString = FrmHome.ConnectionString
                        con.Open()
                        cmd.Connection = con
                        cmd1.Connection = con
                        cmd2.Connection = con
                        cmd.CommandText = "INSERT INTO [Customer Information] ([Customer Category ID],[Customer Name],[Company Name],[Designation],[Mobile No],[Email Address],[Address],[Web Address],[City],[Country],[Sms Notification],[Status],[Discount Percentage],[Prepared Time],[Prepared Date],[Computer ID],[User Account ID],[Branch ID],[Chart Of Account ID],[Employee ID]) VALUES ('" + CmbCustomerCategoryID.SelectedValue.ToString + "','" + CmbCustomerName.Text + "','" + TxtCompanyName.Text + "','" + TxtDesignation.Text + "','" + TxtMobileNo.Text + "','" + TxtEmailAddress.Text + "','" + TxtAddress.Text + "','" + TxtWebAddress.Text + "','" + TxtCity.Text + "','" + TxtCountry.Text + "','" + CmbSmsNotification.Text + "','" + CmbStatus.Text + "','" + TxtDiscountPercentage.Text + "','" + currentTime + "','" + currentDate + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + CmbBranchID.SelectedValue.ToString + "','" + ChartOfAccountID + "','" + CmbEmployeeID.SelectedValue.ToString + "')"
                        cmd1.CommandText = "INSERT INTO [Ledger] ([Chart of Account ID],[Debited Amount],[Credited Amount],[Category Name],[Ledger Date],[Prepared Time],[Prepared Date],[Computer ID],[User Account ID],[Branch ID],[Invoice No],[Status],[Description],[Voucher No]) VALUES ('" + ChartOfAccountID + "','" + TxtOpeningBalance.Text + "','0','Customer Opening Balance','" + DtpLedgerDate.Value + "','" + currentTime + "','" + currentDate + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.lblBranchID.Text + "','OB','CASH','Opening Balance','OB')"
                        cmd2.CommandText = "INSERT INTO [Ledger] ([Chart of Account ID],[Debited Amount],[Credited Amount],[Category Name],[Ledger Date],[Prepared Time],[Prepared Date],[Computer ID],[User Account ID],[Branch ID],[Invoice No],[Status],[Description],[Voucher No]) VALUES ('" + ChartOfAccountID + "','0','" + AccountsReceivable + "','Customer Opening Balance','" + DtpLedgerDate.Value + "','" + currentTime + "','" + currentDate + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.lblBranchID.Text + "','OB','CASH','Opening Balance','OB')"

                        cmd.ExecuteNonQuery()



                        If Val(TxtOpeningBalance.Text) > 0 Then
                            cmd1.ExecuteNonQuery()
                        ElseIf Val(TxtOpeningBalance.Text) < 0 Then
                            cmd2.ExecuteNonQuery()
                        End If
                        con.Close()


                        'Insert into log 
                        InsertIntoLog()

                    End If





                    'Insert Click Msg
                    MsgBox("Data Inserted Successfully", MsgBoxStyle.OkOnly, "Customer Information")

                    'Making Clear
                    ClearData()


                    'Refresh Data
                    RefreshData()

                    'Load Combobox Customer
                    LoadComboBoxCustomer()


                    'Focus on Customer information
                    CmbCustomerName.Focus()

                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally


        End Try
    End Sub

    Sub NUmberOfRow()

        'Total gridview line show in label code
        Dim total As String = 0

        total = GrdCustomerInformation.Rows.Count

        Me.Label15.Text = total


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click

        'Data Update Code
        Dim con As New SqlConnection
        Dim con2 As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim cmd3 As New SqlCommand
        Dim cmd4 As New SqlCommand
        Dim cmd5 As New SqlCommand
        Dim cmd6 As New SqlCommand
        Dim cmd7 As New SqlCommand

        Dim dr2 As SqlDataReader

        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now

        Dim AccountsReceivable As String
        AccountsReceivable = Val(TxtOpeningBalance.Text) * -1



        Try

            'Empty Customer ID Can Not Be Update
            If Me.TxtCustomerID.Text = "" Then
                MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Customer Information")

                'Empty Text Box Can Not Be update Code
            ElseIf Me.CmbCustomerCategoryID.SelectedValue = 0 Or Me.CmbCustomerCategoryID.Text = "" Or Me.CmbCustomerName.Text = "" Or Me.CmbSmsNotification.Text = "" Or Me.CmbStatus.Text = "" Or Me.TxtDiscountPercentage.Text = "" Or CmbBranchID.Text = "" Or CmbEmployeeID.Text = "" Then
                MsgBox("Required field can not be empty", MsgBoxStyle.Critical, "Branch Information")

            Else
                If Not Me.CustomerPictureBox.Image Is Nothing Then


                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd3.Connection = con
                    cmd4.Connection = con
                    cmd5.Connection = con
                    cmd.CommandText = "UPDATE [Customer Information] SET [Customer Category ID]= '" + CmbCustomerCategoryID.SelectedValue.ToString + "', [Customer Name]= '" + CmbCustomerName.Text + "',[Company Name] = '" + TxtCompanyName.Text + "',[Designation]= '" + TxtDesignation.Text + "',[Mobile No]= '" + TxtMobileNo.Text + "',[Email Address]= '" + TxtEmailAddress.Text + "',[Address]= '" + TxtAddress.Text + "',[Web Address]= '" + TxtWebAddress.Text + "',[City]= '" + TxtCity.Text + "',[Country]= '" + TxtCountry.Text + "',[Sms Notification]= '" + CmbSmsNotification.Text + "',[Status]= '" + CmbStatus.Text + "',[Discount Percentage]= '" + TxtDiscountPercentage.Text + "',[Customer Image]=@test,[Computer ID]= '" + FrmHome.LblComputerID.Text + "',[User Account ID]='" + FrmHome.LblUserID.Text + "',[Branch ID]='" + CmbBranchID.SelectedValue.ToString + "' ,[Employee ID]='" + CmbEmployeeID.SelectedValue.ToString + "' WHERE [Customer ID]= '" + TxtCustomerID.Text + "'  INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES ('" + Me.Text + "','UPDATE', 'Customer ID: " + TxtCustomerID.Text + " , Customer Name: " + CmbCustomerName.Text + " , Customer Category ID: " + CmbCustomerCategoryID.Text + ",  Company Name: " + TxtCompanyName.Text + " , Designation: " + TxtDesignation.Text + ",  Mobile No: " + TxtMobileNo.Text + " ,  Email Address: " + TxtEmailAddress.Text + " ,  Address: " + TxtAddress.Text + " ,  Web Address: " + TxtWebAddress.Text + " ,  Opening Balance: " + TxtOpeningBalance.Text + " ,  Opening Balance Date: " + DtpLedgerDate.Value + " ,  City: " + TxtCity.Text + " ,  Country: " + TxtCountry.Text + " ,  Status: " + CmbStatus.Text + " ,  SMS Notification: " + CmbSmsNotification.Text + " ,  Discount Percentage: " + TxtDiscountPercentage.Text + " ,  Transaction Limit: " + TxtTransactionLimit.Text + " ,  Product ID: " + CmbProductID.Text + " ,  Price: " + TxtPrice.Text + " ' ,'" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtCustomerID.Text + "' )"
                    cmd3.CommandText = "UPDATE [Chart Of Account] SET [Account Name]= '" + CmbCustomerName.Text + "',[Transaction Limit]='" + TxtTransactionLimit.Text + "'  WHERE [Chart Of Account ID]= '" + ChartOfAccountIDforOpeningBalanceAdd + "'"

                    Dim ms As New MemoryStream()
                    CustomerPictureBox.Image.Save(ms, CustomerPictureBox.Image.RawFormat)
                    Dim data As Byte() = ms.GetBuffer()
                    Dim p As New SqlParameter("@test", SqlDbType.Image)
                    p.Value = data
                    cmd.Parameters.Add(p)

                    cmd.ExecuteNonQuery()
                    cmd3.ExecuteNonQuery()


                    cmd5.CommandText = "Select * From [Ledger] WHERE [Chart Of Account ID]= '" + ChartOfAccountIDforOpeningBalanceAdd + "' And [Category Name] = 'Customer Opening Balance' And [Branch ID]='" + FrmHome.lblBranchID.Text + "'"
                    If Val(TxtOpeningBalance.Text) >= 0 Then

                        dr2 = cmd5.ExecuteReader
                        dr2.Read()

                        If Not dr2.HasRows Then
                            If Not TxtOpeningBalance.Text = "" Then
                                con2.ConnectionString = FrmHome.ConnectionString
                                con2.Open()
                                cmd6.Connection = con2
                                cmd6.CommandText = "INSERT INTO [Ledger] ([Chart of Account ID],[Debited Amount],[Credited Amount],[Category Name],[Prepared Time],[Prepared Date],[Computer ID],[User Account ID],[Branch ID],[Invoice No],[Status],[Description],[Voucher No],[Ledger Date]) VALUES ('" + ChartOfAccountIDforOpeningBalanceAdd + "','" + TxtOpeningBalance.Text + "','0','Customer Opening Balance','" + currentTime + "','" + currentDate + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.lblBranchID.Text + "','OB','CASH','Opening Balance','OB','" + DtpLedgerDate.Value + "')"
                                cmd6.ExecuteNonQuery()
                                con2.Close()
                            End If
                        ElseIf dr2.HasRows Then
                            con2.ConnectionString = FrmHome.ConnectionString
                            con2.Open()
                            cmd1.Connection = con2
                            cmd1.CommandText = "UPDATE [Ledger] SET [Debited Amount]= '" + TxtOpeningBalance.Text + "',[Credited Amount]= '0',[Ledger Date]='" + DtpLedgerDate.Value + "' WHERE [Chart Of Account ID]= '" + ChartOfAccountIDforOpeningBalanceAdd + "' And [Category Name] = 'Customer Opening Balance' And [Branch ID]='" + FrmHome.lblBranchID.Text + "'"
                            cmd1.ExecuteNonQuery()
                            con2.Close()

                        End If
                        dr2.Close()

                    ElseIf Val(TxtOpeningBalance.Text) < 0 Then

                        dr2 = cmd5.ExecuteReader
                        dr2.Read()

                        If Not dr2.HasRows Then

                            con2.ConnectionString = FrmHome.ConnectionString
                            con2.Open()
                            cmd7.Connection = con2
                            cmd7.CommandText = "INSERT INTO [Ledger] ([Chart of Account ID],[Debited Amount],[Credited Amount],[Category Name],[Prepared Time],[Prepared Date],[Computer ID],[User Account ID],[Branch ID],[Invoice No],[Status],[Description],[Voucher No],[Ledger Date]) VALUES ('" + ChartOfAccountIDforOpeningBalanceAdd + "','0','" + AccountsReceivable + "','Customer Opening Balance','" + currentTime + "','" + currentDate + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.lblBranchID.Text + "','OB','CASH','Opening Balance','OB''" + DtpLedgerDate.Value + "')"
                            cmd7.ExecuteNonQuery()
                            con2.Close()

                        ElseIf dr2.HasRows Then
                            con2.ConnectionString = FrmHome.ConnectionString
                            con2.Open()
                            cmd2.Connection = con2
                            cmd2.CommandText = "UPDATE [Ledger] SET [Credited Amount]= '" + AccountsReceivable + "',[Debited Amount]= '0',[Ledger Date]='" + DtpLedgerDate.Value + "' WHERE [Chart Of Account ID]= '" + ChartOfAccountIDforOpeningBalanceAdd + "' And [Category Name] = 'Customer Opening Balance' And [Branch ID]='" + FrmHome.lblBranchID.Text + "'"
                            cmd2.ExecuteNonQuery()
                            con2.Close()

                        End If
                        dr2.Close()
                    End If



                ElseIf Me.CustomerPictureBox.Image Is Nothing Then
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd1.Connection = con
                    cmd2.Connection = con
                    cmd3.Connection = con
                    cmd5.Connection = con
                    cmd.CommandText = "UPDATE [Customer Information] SET [Customer Category ID]= '" + CmbCustomerCategoryID.SelectedValue.ToString + "', [Customer Name]= '" + CmbCustomerName.Text + "',[Company Name] = '" + TxtCompanyName.Text + "',[Designation]= '" + TxtDesignation.Text + "',[Mobile No]= '" + TxtMobileNo.Text + "',[Email Address]= '" + TxtEmailAddress.Text + "',[Address]= '" + TxtAddress.Text + "',[Web Address]= '" + TxtWebAddress.Text + "',[City]= '" + TxtCity.Text + "',[Country]= '" + TxtCountry.Text + "',[Sms Notification]= '" + CmbSmsNotification.Text + "',[Status]= '" + CmbStatus.Text + "',[Discount Percentage]= '" + TxtDiscountPercentage.Text + "',[Customer Image]= '" + Nothing + "',[Computer ID]= '" + FrmHome.LblComputerID.Text + "',[User Account ID]='" + FrmHome.LblUserID.Text + "',[Branch ID]='" + CmbBranchID.SelectedValue.ToString + "',[Employee Id]= '" + CmbEmployeeID.SelectedValue.ToString + "' WHERE [Customer ID]= '" + TxtCustomerID.Text + "'  INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES ('" + Me.Text + "','UPDATE', 'Customer ID: " + TxtCustomerID.Text + " , Customer Name: " + CmbCustomerName.Text + " , Customer Category ID: " + CmbCustomerCategoryID.Text + ",  Company Name: " + TxtCompanyName.Text + " , Designation: " + TxtDesignation.Text + ",  Mobile No: " + TxtMobileNo.Text + " ,  Email Address: " + TxtEmailAddress.Text + " ,  Address: " + TxtAddress.Text + " ,  Web Address: " + TxtWebAddress.Text + " ,  Opening Balance: " + TxtOpeningBalance.Text + " ,  Opening Balance Date: " + DtpLedgerDate.Value + " ,  City: " + TxtCity.Text + " ,  Country: " + TxtCountry.Text + " ,  Status: " + CmbStatus.Text + " ,  SMS Notification: " + CmbSmsNotification.Text + " ,  Discount Percentage: " + TxtDiscountPercentage.Text + " ,  Transaction Limit: " + TxtTransactionLimit.Text + " ,  Product ID: " + CmbProductID.Text + " ,  Price: " + TxtPrice.Text + " ' ,'" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtCustomerID.Text + "' )"
                    cmd3.CommandText = "UPDATE [Chart Of Account] SET [Account Name]= '" + CmbCustomerName.Text + "',[Transaction Limit]='" + TxtTransactionLimit.Text + "'  WHERE [Chart Of Account ID]= '" + ChartOfAccountIDforOpeningBalanceAdd + "'"

                    cmd.ExecuteNonQuery()
                    cmd3.ExecuteNonQuery()


                    'Update or insert opening balance to Ledger
                    cmd5.CommandText = "Select * From [Ledger] WHERE [Chart Of Account ID]= '" + ChartOfAccountIDforOpeningBalanceAdd + "' And [Category Name] = 'Customer Opening Balance' And [Branch ID]='" + FrmHome.lblBranchID.Text + "'"
                    If Val(TxtOpeningBalance.Text) >= 0 Then


                        dr2 = cmd5.ExecuteReader
                        dr2.Read()

                        If Not dr2.HasRows Then
                            If Not TxtOpeningBalance.Text = "" Then
                                con2.ConnectionString = FrmHome.ConnectionString
                                con2.Open()
                                cmd6.Connection = con2
                                cmd6.CommandText = "INSERT INTO [Ledger] ([Chart of Account ID],[Debited Amount],[Credited Amount],[Category Name],[Ledger Date],[Prepared Time],[Prepared Date],[Computer ID],[User Account ID],[Branch ID],[Status],[Description],[Voucher No]) VALUES ('" + ChartOfAccountIDforOpeningBalanceAdd + "','" + TxtOpeningBalance.Text + "','0','Customer Opening Balance','" + DtpLedgerDate.Value + "','" + currentTime + "','" + currentDate + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.lblBranchID.Text + "','CASH','Opening Balance','OB')"
                                cmd6.ExecuteNonQuery()
                                con2.Close()
                            End If
                        ElseIf dr2.HasRows Then
                            con2.ConnectionString = FrmHome.ConnectionString
                            con2.Open()
                            cmd1.Connection = con2
                            cmd1.CommandText = "UPDATE [Ledger] SET [Debited Amount]= '" + TxtOpeningBalance.Text + "',[Credited Amount]= '0',[Ledger Date]='" + DtpLedgerDate.Value + "' WHERE [Chart Of Account ID]= '" + ChartOfAccountIDforOpeningBalanceAdd + "' And [Category Name] = 'Customer Opening Balance' And [Branch ID]='" + FrmHome.lblBranchID.Text + "'"
                            cmd1.ExecuteNonQuery()
                            con2.Close()

                        End If
                        dr2.Close()

                    ElseIf Val(TxtOpeningBalance.Text) < 0 Then

                        dr2 = cmd5.ExecuteReader
                        dr2.Read()

                        If Not dr2.HasRows Then
                            con2.ConnectionString = FrmHome.ConnectionString
                            con2.Open()
                            cmd7.Connection = con2
                            cmd7.CommandText = "INSERT INTO [Ledger] ([Chart of Account ID],[Debited Amount],[Credited Amount],[Category Name],[Ledger Date],[Prepared Time],[Prepared Date],[Computer ID],[User Account ID],[Branch ID],[Status],[Description],[Voucher No]) VALUES ('" + ChartOfAccountIDforOpeningBalanceAdd + "','0','" + TxtOpeningBalance.Text + "','Customer Opening Balance','" + DtpLedgerDate.Value + "','" + currentTime + "','" + currentDate + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.lblBranchID.Text + "','CASH','Opening Balance','OB')"
                            cmd7.ExecuteNonQuery()
                            con2.Close()

                        ElseIf dr2.HasRows Then
                            con2.ConnectionString = FrmHome.ConnectionString
                            con2.Open()
                            cmd2.Connection = con2
                            cmd2.CommandText = "UPDATE [Ledger] SET [Credited Amount]= '" + AccountsReceivable + "',[Debited Amount]= '0',[Ledger Date]='" + DtpLedgerDate.Value + "' WHERE [Chart Of Account ID]= '" + ChartOfAccountIDforOpeningBalanceAdd + "' And [Category Name] = 'Customer Opening Balance' And [Branch ID]='" + FrmHome.lblBranchID.Text + "'"
                            cmd2.ExecuteNonQuery()
                            con2.Close()

                        End If
                        dr2.Close()
                    End If


                End If

                'Update Click Msg
                MsgBox("Data Updated Successfully", MsgBoxStyle.OkOnly, "Customer Information")

                'Making Clear
                ClearData()

                'Refresh Data
                RefreshData()

                'Load Combobox Customer
                LoadComboBoxCustomer()
            End If
        Catch ex As Exception
            MessageBox.Show("Error while Updating record on table..." & ex.Message, "Update Records")
        Finally
            con.Close()
        End Try
    End Sub
    'Load Combobox Customer
    Sub LoadComboBoxCustomer()


        Try


            Dim con1 As New SqlConnection
            Dim cmd1 As New SqlCommand
            con1.ConnectionString = FrmHome.ConnectionString

            Dim strSQL1 As String = "SELECT [Customer ID],[Customer Name] FROM [Customer Information]"
            Dim da1 As New System.Data.SqlClient.SqlDataAdapter(strSQL1, con1)
            Dim ds1 As New DataSet
            da1.Fill(ds1, "[Customer Information]")

            With Me.CmbCustomerName
                .DataSource = ds1.Tables("[Customer Information]")
                .ValueMember = "Customer ID"
                .DisplayMember = "Customer Name"
            End With
            con1.Close()


            'Supplier Category clear code
            CmbCustomerName.SelectedValue = 0

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    'Load Combobox Employee
    Sub LoadComboBoxEmployee()


        Try


            Dim con1 As New SqlConnection
            Dim cmd1 As New SqlCommand
            con1.ConnectionString = FrmHome.ConnectionString

            Dim strSQL1 As String = "SELECT [Employee ID],[Employee Name] FROM [Employee Information]"
            Dim da1 As New System.Data.SqlClient.SqlDataAdapter(strSQL1, con1)
            Dim ds1 As New DataSet
            da1.Fill(ds1, "[Employee Information]")

            With Me.CmbEmployeeID
                .DataSource = ds1.Tables("[Employee Information]")
                .ValueMember = "Employee ID"
                .DisplayMember = "Employee Name"
            End With
            con1.Close()


            'Supplier Category clear code
            CmbEmployeeID.SelectedValue = 0

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Load Combo Box Customer Category()
    Sub LoadComboBoxCustomerCategory()

        Try


            Dim con1 As New SqlConnection
            Dim cmd1 As New SqlCommand
            con1.ConnectionString = FrmHome.ConnectionString

            Dim strSQL1 As String = "SELECT [Customer Category ID],[Customer Category Name] FROM [Customer Category]"
            Dim da1 As New System.Data.SqlClient.SqlDataAdapter(strSQL1, con1)
            Dim ds1 As New DataSet
            da1.Fill(ds1, "[Customer Category]")

            With Me.CmbCustomerCategoryID
                .DataSource = ds1.Tables("[Customer Category]")
                .ValueMember = "Customer Category ID"
                .DisplayMember = "Customer Category Name"
            End With
            con1.Close()

            'customer Category clear code
            CmbCustomerCategoryID.SelectedValue = 0

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Load Combo Box Branch ID()
    Sub LoadComboBranchID()

        Try


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


            'customer Category clear code
            CmbBranchID.SelectedValue = 0

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        'Empty Company ID Can Not Be Delete
        If Me.TxtCustomerID.Text = "" Then
            MsgBox("Please select a row", MsgBoxStyle.OkOnly, "Customer Information")
        Else
            'Data Delete Code
            Dim q As MsgBoxResult
            q = MsgBox("Do you really want to Delete the row?", MsgBoxStyle.YesNo, "Customer Information")
            If q = MsgBoxResult.Yes Then

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim cmd1 As New SqlCommand
                Dim cmd2 As New SqlCommand

                Dim CurrentDate As DateTime = DateTime.Today
                Dim CurrentTime As DateTime = DateTime.Now


                Try
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd1.Connection = con
                    cmd2.Connection = con
                    cmd.CommandText = "Delete from [Customer Information] where [Customer ID]= '" + TxtCustomerID.Text + "' INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES ('" + Me.Text + "','DELETE', 'Customer ID: " + TxtCustomerID.Text + " , Customer Name: " + CmbCustomerName.Text + " , Customer Category ID: " + CmbCustomerCategoryID.Text + ",  Company Name: " + TxtCompanyName.Text + " , Designation: " + TxtDesignation.Text + ",  Mobile No: " + TxtMobileNo.Text + " ,  Email Address: " + TxtEmailAddress.Text + " ,  Address: " + TxtAddress.Text + " ,  Web Address: " + TxtWebAddress.Text + " ,  Opening Balance: " + TxtOpeningBalance.Text + " ,  Opening Balance Date: " + DtpLedgerDate.Value + " ,  City: " + TxtCity.Text + " ,  Country: " + TxtCountry.Text + " ,  Status: " + CmbStatus.Text + " ,  SMS Notification: " + CmbSmsNotification.Text + " ,  Discount Percentage: " + TxtDiscountPercentage.Text + " ,  Transaction Limit: " + TxtTransactionLimit.Text + " ,  Product ID: " + CmbProductID.Text + " ,  Price: " + TxtPrice.Text + " ' ,'" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtCustomerID.Text + "' )"
                    cmd1.CommandText = "Delete from [Ledger] where [Chart of Account ID]= '" + ChartOfAccountIDforOpeningBalanceAdd + "' And [Category Name]= 'Customer Opening Balance' "
                    cmd2.CommandText = "Delete from [Chart of Account] where [Chart of Account ID]= '" + ChartOfAccountIDforOpeningBalanceAdd + "'"
                    cmd.ExecuteNonQuery()
                    cmd1.ExecuteNonQuery()
                    cmd2.ExecuteNonQuery()
                    con.Close()

                    'Making Clear
                    ClearData()


                    'Refresh Data
                    RefreshData()

                    'Load Combobox Customer
                    LoadComboBoxCustomer()

                Catch ex As Exception
                    MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Records")
                Finally

                End Try

            End If

        End If

    End Sub

    Private Sub CmbSmsNotification_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'Focus On Status Name

        If e.KeyCode = Keys.Enter Then
            Me.CmbStatus.Focus()
        End If
    End Sub

    Private Sub CmbSmsNotification_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GrdCustomerInformation_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub
    Private Sub GrdCustomerInformation_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

    End Sub

    Private Sub GrpCustomerInformation_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrpCustomerInformation.Enter

    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click

        Try
            'Refreshing Data
            RefreshData()



            'Clear Data
            ClearData()



        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records Refresh Button")
        Finally

        End Try

    End Sub

    Private Sub BtnAddCustomerCategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Focus on From List of Customer 
        FrmListofCustomersCategory.Show()
        FrmListofCustomersCategory.TxtSearchCustomerName.Focus()

    End Sub

    Private Sub CmbCustomerCategoryID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'Focus on Customer name Text box
        If e.KeyCode = Keys.Enter Then
            Me.CmbCustomerName.Focus()

        End If


    End Sub


    Private Sub BtnChoose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnChoose.Click
        'Image choose button code
        Dim Getimage As Integer
        OpenFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*"
        Getimage = OpenFileDialog1.ShowDialog()
        If Getimage = Windows.Forms.DialogResult.OK Then
            CustomerPictureBox.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub BtnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemove.Click
        'Clear Picture Box Code
        Me.CustomerPictureBox.Image = Nothing
    End Sub

    Private Sub LblDiscountPercentage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblDiscountPercentage.Click

    End Sub

    Private Sub CmbSmsNotification_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbSmsNotification.KeyDown
        'Focus on Status Text box
        If e.KeyCode = Keys.Enter Then
            Me.CmbStatus.Focus()

        End If
    End Sub

    Private Sub CmbSmsNotification_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSmsNotification.SelectedIndexChanged
        'Focus on Status combobox
        TxtDiscountPercentage.Focus()
    End Sub

    Private Sub CmbStatus_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbStatus.KeyDown
        'Focus on Customer name Text box
        If e.KeyCode = Keys.Enter Then
            Me.TxtDiscountPercentage.Focus()

        End If
    End Sub

    Private Sub CmbStatus_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbStatus.SelectedIndexChanged

        'Focus on discount percentage
        CmbSmsNotification.Focus()
    End Sub

    Private Sub BtnSearch_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub BtnSearch_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        Try



            'Search Code
            ' Load Data
            

            Dim connectionString As String = FrmHome.ConnectionString
            If Me.CmbSearch.SelectedIndex = 0 Then

                Dim sql As String = "SELECT [Customer Information].[Customer ID],[Customer Information].[Customer Name],[Customer Category].[Customer Category Name],[Customer Information].[Company Name],[Customer Information].[Designation],[Customer Information].[Mobile No],[Customer Information].[Email Address],[Customer Information].[Address],[Customer Information].[Web Address],[Customer Information].[City],[Customer Information].[Country],[Customer Information].[SMS Notification],[Customer Information].[Status],[Customer Information].[Discount Percentage],[Branch Information].[Branch Name] ,[Employee Information].[Employee Name]  FROM [Customer Information] Join [Customer Category] on [Customer Information].[Customer Category ID]=[Customer Category].[Customer Category ID] join [Branch Information] on [Customer Information].[Branch ID]=[Branch Information].[Branch ID] join [Employee Information] on [Customer Information].[employee ID]=[Employee Information].[employee ID] WHERE ([Customer Information].[Customer ID]  = '" + Me.TxtSearch.Text + "')"
                Dim connection As New SqlConnection(connectionString)
                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Customer Information")
                connection.Close()
                GrdCustomerInformation.DataSource = ds
                GrdCustomerInformation.DataMember = "BizPro_Customer Information"
                'GrdCustomerInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                'Row Count
                NUmberOfRow()



            ElseIf Me.CmbSearch.SelectedIndex = 3 Then


                Dim sql As String = "SELECT [Customer Information].[Customer ID],[Customer Information].[Customer Name],[Customer Category].[Customer Category Name],[Customer Information].[Company Name],[Customer Information].[Designation],[Customer Information].[Mobile No],[Customer Information].[Email Address],[Customer Information].[Address],[Customer Information].[Web Address],[Customer Information].[City],[Customer Information].[Country],[Customer Information].[SMS Notification],[Customer Information].[Status],[Customer Information].[Discount Percentage] ,[Branch Information].[Branch Name] ,[Employee Information].[Employee Name]  FROM [Customer Information] Join [Customer Category] on [Customer Information].[Customer Category ID]=[Customer Category].[Customer Category ID] join [Branch Information] on [Customer Information].[Branch ID]=[Branch Information].[Branch ID] join [Employee Information] on [Customer Information].[employee ID]=[Employee Information].[employee ID]  WHERE ([Customer Information].[Mobile No]  = '" + Me.TxtSearch.Text + "')"
                Dim connection As New SqlConnection(connectionString)
                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Customer Information")
                connection.Close()
                GrdCustomerInformation.DataSource = ds
                GrdCustomerInformation.DataMember = "BizPro_Customer Information"
                'GrdCustomerInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                'Row Count
                NUmberOfRow()

              
            End If

        Catch ex As Exception
            MessageBox.Show("Error while searching records on table..." & ex.Message, "Search Records on Button")
        Finally

        End Try

    End Sub

    Private Sub CmbCustomerCategoryID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CmbCustomerCategoryID_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'Customer name focus
        CmbCustomerName.Focus()
    End Sub


    'Add Customer Price 
    Sub AddCustomerPrice()

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        Try
            'Same id Twice insert restriction code
            If Me.TxtCustomerID.Text = "" Then
                MsgBox("Please select a customer.", MsgBoxStyle.OkOnly, "Customer price list")


            Else
                'Empty Txt Box Can Not Be Save Code
                If Me.CmbProductID.ValueMember = "" Or Me.CmbProductID.Text = "" Then

                    MsgBox("Please select a product.", MsgBoxStyle.Critical, "Customer price list")

                ElseIf Me.TxtPrice.Text = "" Then
                    MsgBox("Price field can not be empty.", MsgBoxStyle.Critical, "Customer price list")
                    TxtPrice.Focus()
                Else
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO [Customer Price List] ([Product ID],[Price],[Customer ID]) VALUES ('" + CmbProductID.ValueMember + "','" + TxtPrice.Text + "','" + TxtCustomerID.Text + "')"
                    cmd.ExecuteNonQuery()

                    con.Close()

                    'Insert Click Msg
                    MsgBox("Listed Successfully", MsgBoxStyle.OkOnly, "Customer price list")

                    'Making Clear

                    ClearDataProductPrice()
                    'Refresh Customer Price List on Specific Customer
                    RefreshDataProductSpecificCustomer()

                    'Product id focus
                    CmbProductID.Focus()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on Customer Price list..." & ex.Message, " Add Customer Price Sub")
        Finally


        End Try

    End Sub

    'Update Product Price Sub
    Sub UpdateCustomerPrice()

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand


        Try
            'Same id Twice insert restriction code
            If Me.TxtCustomerID.Text = "" Then
                MsgBox("Please select a customer.", MsgBoxStyle.OkOnly, "Customer price list")


            Else
                'Empty Txt Box Can Not Be Save Code
                If Me.CmbProductID.ValueMember = "" Or Me.CmbProductID.Text = "" Then

                    MsgBox("Please select a product.", MsgBoxStyle.Critical, "Customer price list")

                ElseIf Me.TxtPrice.Text = "" Then
                    MsgBox("Price field can not be empty.", MsgBoxStyle.Critical, "Customer price list")
                    TxtPrice.Focus()
                Else

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "UPDATE [Customer price list] SET [Product ID]='" + CmbProductID.ValueMember + "',[Price]='" + TxtPrice.Text + "',[Customer ID]='" + TxtCustomerID.Text + "' where [Product ID]='" + CmbProductID.ValueMember + "' and [Customer ID]='" + TxtCustomerID.Text + "' "
                    cmd.ExecuteNonQuery()
                    con.Close()


                    'Insert Click Msg
                    MsgBox("Updated Successfully", MsgBoxStyle.OkOnly, "Customer Information")

                    'Making Clear
                    ClearDataProductPrice()

                    'Refresh Customer Price List on Specific Customer
                    RefreshDataProductSpecificCustomer()


                    'Product id focus
                    CmbProductID.Focus()

                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error while Updating record on table..." & ex.Message, "Update Product Price Sub")
        Finally

        End Try

    End Sub


    'Sub for delete customer product
    Sub DeleteCustomerProduct()


        'Data Delete Code
        Dim q As MsgBoxResult
        q = MsgBox("Do you really want to Delete the row?", MsgBoxStyle.YesNo, "Customer price list")
        If q = MsgBoxResult.Yes Then

            Try


                Dim con As New SqlConnection
                Dim cmd As New SqlCommand


                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "Delete from [Customer price list] where [Product ID]= '" + CmbProductID.ValueMember + "' and [Customer ID]= '" + TxtCustomerID.Text + "'"
                cmd.ExecuteNonQuery()
                con.Close()

                'Making Clear
                ClearDataProductPrice()

                'Refresh Customer Price List on Specific Customer
                RefreshDataProductSpecificCustomer()

                'Product id focus
                CmbProductID.Focus()


            Catch ex As Exception
                MessageBox.Show("Error while Deleting record on Customer price list..." & ex.Message, "Delete Records Customer price list")
            Finally

            End Try

        End If

    End Sub

    Private Sub GrdPriceList_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GrdPriceList_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

    End Sub


    Private Sub GrdCustomerInformation_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)








    End Sub

    Private Sub CmbCustomerCategoryID_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCustomerCategoryID.SelectedIndexChanged

    End Sub

    Private Sub CmbCustomerCategoryID_SelectedValueChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbCustomerCategoryID.SelectedValueChanged
        'Company name text box focus
        TxtCompanyName.Focus()
    End Sub

    Private Sub TxtPrice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPrice.KeyDown

        'Insert or update customer price list
        If e.KeyCode = Keys.Enter Then


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Customer Price List]  WHERE [Product ID] = '" + Me.CmbProductID.ValueMember + "' and [Customer ID]='" + TxtCustomerID.Text + "'"

            dr = cmd.ExecuteReader()
            dr.Read()

            If Not dr.HasRows Then

                'Add Customer Price
                AddCustomerPrice()

            ElseIf dr.HasRows Then

                'Update Product Price Sub
                UpdateCustomerPrice()

            End If

            dr.Close()
            con.Close()

        End If


    End Sub

    Private Sub TxtPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPrice.TextChanged

    End Sub

    Private Sub CmbSearchProductPrice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbSearchProductPrice.KeyDown

        If e.KeyCode = Keys.F4 Then

            FrmListofProducts.Show()
            FrmListofProducts.TxtSearchProductName.Focus()
            FrmListofProducts.Label1.Text = "Customer Information Search"



        End If
    End Sub

    'Search Product Price By Customer

    Sub SearchProductPriceByCustomer()
        Try

            'Search Code
            ' Load Data
           

            Dim connectionString As String = FrmHome.ConnectionString
            If Me.CmbSearch.SelectedIndex = 5 Then

                Dim sql As String = "SELECT [Customer Information].[Customer ID],[Customer Information].[Customer Name],[Customer Category].[Customer Category Name],[Customer Information].[Company Name],[products].[Product Name],[Customer Price List].[Price],[Customer Information].[Mobile No],[Customer Information].[Address],[Customer Information].[Email Address],[Customer Information].[Designation],[Customer Information].[Web Address],[Customer Information].[City],[Customer Information].[Country],[Customer Information].[SMS Notification],[Customer Information].[Status],[Customer Information].[Discount Percentage] ,[Branch Information].[Branch Name],[Employee Information].[Employee Name]  FROM [Customer Information] Join [Customer Category] on [Customer Information].[Customer Category ID]=[Customer Category].[Customer Category ID] join [Customer Price List] on [Customer information].[Customer ID]=[Customer Price List].[Customer ID]  join [Products] on [Customer Price List].[product ID]=[Products].[Product ID] join [Branch Information] on [Customer Information].[Branch ID]=[Branch Information].[Branch ID] join [Employee Information] on [Customer Information].[employee ID]=[Employee Information].[employee ID]  WHERE ([products].[Product ID]  = '" + CmbSearchProductPrice.ValueMember + "')  order by [Customer Price List].[Price] asc"
                Dim connection As New SqlConnection(connectionString)
                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Customer Price List")
                connection.Close()
                GrdCustomerInformation.DataSource = ds
                GrdCustomerInformation.DataMember = "BizPro_Customer Price List"
                'GrdCustomerInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                'Row Count
                NUmberOfRow()

            End If

        Catch ex As Exception
            MessageBox.Show("Error while Searching record from table..." & ex.Message, "Search Product Price By Customer Sub")

        End Try


    End Sub

    Private Sub CmbSearchProductPrice_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSearchProductPrice.SelectedIndexChanged

    End Sub

    Private Sub GrdPriceList_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

    End Sub

    Private Sub TxtDiscountPercentage_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDiscountPercentage.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtOpeningBalance.Focus()
        End If
    End Sub

    Private Sub TxtDiscountPercentage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDiscountPercentage.TextChanged

    End Sub

    Private Sub GrdCustomerInformation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub BtnAddToSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddToSupplier.Click
        Try



            Dim con2 As New SqlConnection
            Dim con3 As New SqlConnection

            Dim cmd As New SqlCommand
            Dim cmd2 As New SqlCommand
            Dim cmd3 As New SqlCommand
            Dim cmd4 As New SqlCommand
            Dim cmd7 As New SqlCommand


            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now

            Dim dr1 As SqlDataReader
            Dim dr2 As SqlDataReader
            Dim dr3 As SqlDataReader



            If TxtCustomerID.Text = "" Then
                MsgBox("Please Select A Customer First", MsgBoxStyle.Exclamation, "Customer Information")
            Else




                'Search For Supplier Supplier Listed Or Not
                con2.ConnectionString = FrmHome.ConnectionString
                con2.Open()

                cmd.Connection = con2
                cmd.CommandText = "select *From [Customer Information] where [Customer ID] =  '" + TxtCustomerID.Text + "'"

                dr2 = cmd.ExecuteReader
                dr2.Read()

                If Not Val(dr2.Item("Supplier ID").ToString) = 0 Then

                    MsgBox("This Customer Is Already Listed To Supplier.", MsgBoxStyle.Critical, "Customer Information")
                Else
                    dr2.Close()


                    'Data reader find Supplier Category ID  then send it to insert Supplier information
                    cmd2.Connection = con2
                    cmd2.CommandText = "SELECT top 1 [Supplier Category ID] FROM [Supplier Category]   order by [Supplier Category ID] Asc"


                    dr1 = cmd2.ExecuteReader()
                    dr1.Read()

                    If dr1.HasRows Then
                        con3.ConnectionString = FrmHome.ConnectionString
                        con3.Open()
                        cmd7.Connection = con3
                        cmd7.CommandText = "INSERT INTO [Supplier Information] ([Supplier Name],[Supplier Category ID],[Mobile No],[Address],[Company Name] ,[Designation] ,[Web Address],[City] ,[Country] ,[Sms Notification],[Status],[Prepared Time],[Prepared Date],[Computer ID],[User Account ID],[Branch ID],[Discount Percentage]) VALUES ('" + CmbCustomerName.Text + "','" + (dr1.Item("Supplier Category ID").ToString) + "','" + TxtMobileNo.Text + "','" + TxtAddress.Text + "','" + TxtCompanyName.Text + "', '" + TxtDesignation.Text + "', '" + TxtWebAddress.Text + "', '" + TxtCity.Text + "', '" + TxtCountry.Text + "', '" + CmbSmsNotification.Text + "','" + CmbStatus.Text + "','" + currentTime + "','" + currentDate + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + CmbBranchID.SelectedValue.ToString + "','0')"
                        cmd7.ExecuteNonQuery()
                        con3.Close()
                    End If
                    dr1.Close()

                    'Search Supplier ID And Then Update Customer Information

                    cmd3.Connection = con2
                    cmd3.CommandText = "SELECT top 1 [Supplier ID] FROM [Supplier Information] where [User Account ID]= '" + FrmHome.LblUserID.Text + "' And [Computer ID]='" + FrmHome.LblComputerID.Text + "'  order by [Supplier ID] desc"

                    dr3 = cmd3.ExecuteReader()
                    dr3.Read()

                    If dr3.HasRows Then

                        con3.ConnectionString = FrmHome.ConnectionString
                        con3.Open()
                        cmd4.Connection = con3
                        cmd4.CommandText = "Update [Customer Information] set [Supplier ID]= '" + (dr3.Item("Supplier ID").ToString) + "' where [Customer ID]='" + TxtCustomerID.Text + "'"
                        cmd4.ExecuteNonQuery()
                        dr3.Close()
                        con3.Close()
                        MsgBox("Successfully Listed As Supplier.", MsgBoxStyle.OkOnly, "Customer Information")


                    End If
                End If
                con2.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Add To Supplier Button")
        Finally

        End Try
    End Sub

    Private Sub CmbCustomerName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbCustomerName.KeyDown
        'Focus on Company Name Text Box

        If e.KeyCode = Keys.Enter Then

            Me.CmbCustomerCategoryID.Focus()

        End If
    End Sub



    Private Sub CmbCustomerName_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCustomerName.SelectedIndexChanged

    End Sub

    Private Sub CmbProductID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbProductID.KeyDown
        If e.KeyCode = Keys.F4 Then
            If TxtCustomerID.Text = "" Then
                MsgBox("Please select a customer first.", MsgBoxStyle.Critical, "Customer price list")

            Else
                FrmListofProducts.Show()
                FrmListofProducts.TxtSearchProductName.Focus()
                FrmListofProducts.Label1.Text = "Customer Information"
            End If

        End If
    End Sub

    Private Sub CmbProductID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbProductID.SelectedIndexChanged

    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnminimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnmaximized.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal

        Else
            Me.WindowState = FormWindowState.Maximized

        End If
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnclose.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdCustomerInformation.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdCustomerInformation.CellMouseClick


        'Data Grid view code
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdCustomerInformation.Rows(e.RowIndex)

                TxtCustomerID.Text = row.Cells("Customer ID").Value.ToString
                CmbCustomerCategoryID.Text = row.Cells("Customer Category Name").Value.ToString
                CmbBranchID.Text = row.Cells("Branch Name").Value.ToString
                CmbEmployeeID.Text = row.Cells("Employee Name").Value.ToString
                CmbCustomerName.Text = row.Cells("Customer Name").Value.ToString
                TxtCompanyName.Text = row.Cells("Company Name").Value.ToString
                TxtMobileNo.Text = row.Cells("Mobile No").Value.ToString
                TxtDesignation.Text = row.Cells("Designation").Value.ToString
                TxtEmailAddress.Text = row.Cells("Email Address").Value.ToString
                TxtAddress.Text = row.Cells("Address").Value.ToString
                TxtWebAddress.Text = row.Cells("Web Address").Value.ToString
                TxtCity.Text = row.Cells("City").Value.ToString
                TxtCountry.Text = row.Cells("Country").Value.ToString
                CmbSmsNotification.Text = row.Cells("Sms Notification").Value.ToString
                CmbStatus.Text = row.Cells("Status").Value.ToString
                TxtDiscountPercentage.Text = row.Cells("Discount Percentage").Value.ToString
                TxtOpeningBalance.Text = ""





                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim cmd1 As New SqlCommand
                Dim cmd2 As New SqlCommand
                Dim dr As SqlDataReader
                Dim dr1 As SqlDataReader
                Dim dr2 As SqlDataReader


                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd1.Connection = con
                cmd2.Connection = con
                cmd.CommandText = "SELECT  *FROM [Customer Information] join [Chart of Account] on [Customer Information].[Chart Of Account ID]=[Chart Of Account].[Chart Of Account ID] WHERE [Customer ID] = '" + Me.TxtCustomerID.Text + "'"




                dr = cmd.ExecuteReader()
                dr.Read()
                If dr.HasRows Then
                    ChartOfAccountIDforOpeningBalanceAdd = (dr.Item("Chart Of Account ID").ToString)
                    TxtTransactionLimit.Text = (dr.Item("Transaction Limit").ToString)
                    Me.CmbCustomerCategoryID.SelectedValue = (dr.Item("Customer Category ID").ToString)
                    Me.CustomerPictureBox.Image = Nothing

                End If
                dr.Close()

                cmd1.CommandText = "SELECT  *FROM [Customer Information]  WHERE [Customer ID] = '" + Me.TxtCustomerID.Text + "' AND [Customer Image] IS NOT NULL"
                dr1 = cmd1.ExecuteReader()
                dr1.Read()

                Try
                    If dr1.HasRows Then
                        Dim data As Byte() = DirectCast(dr1("Customer Image"), Byte())
                        Dim ms As New MemoryStream(data)
                        CustomerPictureBox.Image = Image.FromStream(ms)
                    End If

                Catch ex As Exception

                End Try
                dr1.Close()


                cmd2.CommandText = "SELECT  *FROM [Ledger]    WHERE [Chart Of Account ID] = '" + ChartOfAccountIDforOpeningBalanceAdd + "' And [Ledger].[Category Name]='Customer Opening Balance' And [Branch ID]='" + FrmHome.lblBranchID.Text + "'"
                dr2 = cmd2.ExecuteReader()
                dr2.Read()

                If dr2.HasRows Then

                    If Val(dr2.Item("Debited Amount").ToString) = 0 Then

                        TxtOpeningBalance.Text = Val(dr2.Item("Credited Amount").ToString) * -1
                        DtpLedgerDate.Value = dr2.Item("Ledger Date").ToString

                    ElseIf Not Val(dr2.Item("Debited Amount").ToString) = 0 Then

                        TxtOpeningBalance.Text = Val(dr2.Item("Debited Amount").ToString)
                        DtpLedgerDate.Value = dr2.Item("Ledger Date").ToString

                    End If

                End If
                dr2.Close()
                con.Close()

                'Creating Privet Sub of Refreshing Product Data
                RefreshDataProductSpecificCustomer()

                'Focus on product id
                CmbProductID.Focus()

                'Clear Data Product Price
                ClearDataProductPrice()

            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

        End Try
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdCustomerInformation.CellMouseDoubleClick
        Dim i As Integer
        i = GrdCustomerInformation.CurrentRow.Index

        If Me.LblFormName.Text = "Sale" Then

            'FrmSale.LoadComboBoxforcustomer()
            FrmSale.CmbCustomerName.ValueMember = GrdCustomerInformation.Item(0, i).Value
            FrmSale.CmbCustomerName.Text = GrdCustomerInformation.Item(1, i).Value

            FrmSale.TxtPhoneNo.Text = GrdCustomerInformation.Item(5, i).Value
            FrmSale.TxtAddress.Text = GrdCustomerInformation.Item(7, i).Value
            FrmSale.TxtCustomerDiscount.Text = GrdCustomerInformation.Item(13, i).Value

            FrmSale.cmbProductName.Focus()
            FrmSale.customerInformation()
            FrmSale.ShowDueOrAdvance()
            Me.Close()

        ElseIf Me.LblFormName.Text = "Chalan" Then

            FrmChalan.CmbCustomerName.ValueMember = GrdCustomerInformation.Item(0, i).Value
            FrmChalan.CmbCustomerName.Text = GrdCustomerInformation.Item(1, i).Value

            FrmChalan.TxtPhoneNo.Text = GrdCustomerInformation.Item(5, i).Value
            FrmChalan.TxtAddress.Text = GrdCustomerInformation.Item(7, i).Value
            FrmChalan.TxtCustomerDiscount.Text = GrdCustomerInformation.Item(13, i).Value


            FrmChalan.cmbProductName.Focus()
            FrmChalan.customerInformation()
            Me.Close()

        ElseIf Me.LblFormName.Text = "Quotation" Then

            FrmQuotation.LoadComboBoxforcustomer()
            FrmQuotation.CmbCustomerName.ValueMember = GrdCustomerInformation.Item(0, i).Value
            FrmQuotation.CmbCustomerName.Text = GrdCustomerInformation.Item(1, i).Value

            FrmQuotation.TxtPhoneNo.Text = GrdCustomerInformation.Item(5, i).Value
            FrmQuotation.TxtAddress.Text = GrdCustomerInformation.Item(7, i).Value
            FrmQuotation.TxtCustomerDiscount.Text = GrdCustomerInformation.Item(13, i).Value


            FrmQuotation.cmbProductName.Focus()
            FrmQuotation.customerInformation()

            Me.Close()

        End If
    End Sub

    Private Sub GrdPriceList_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdPriceList.CellContentClick

    End Sub

    Private Sub GrdPriceList_CellMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdPriceList.CellMouseClick

        'Data Grid view code
        Try

            If e.RowIndex >= 0 Then



                Dim row As DataGridViewRow
                row = Me.GrdPriceList.Rows(e.RowIndex)


                CmbProductID.Text = row.Cells("Product Name").Value.ToString
                TxtPrice.Text = row.Cells("Price").Value.ToString
                lblListID.Text = row.Cells("ID").Value.ToString

                'price Text box focus
                TxtPrice.Focus()




                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim dr As SqlDataReader

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "SELECT  *FROM [Customer price list]  WHERE [Customer price list ID] = '" + Me.lblListID.Text + "'"

                dr = cmd.ExecuteReader()
                dr.Read()


                Me.CmbProductID.ValueMember = (dr.Item("Product ID").ToString)

                dr.Close()
                con.Close()


            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

        End Try
    End Sub

    Private Sub GrdPriceList_CellMouseDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdPriceList.CellMouseDoubleClick
        'Sub for delete customer product
        DeleteCustomerProduct()
    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= (X)
            newpoint.Y -= (Y)
            Me.Location = newpoint

        End If
    End Sub

    Private Sub Panel1_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TxtTransactionLimit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTransactionLimit.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbBranchID.Focus()

        End If
    End Sub

    Private Sub TxtTransactionLimit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTransactionLimit.TextChanged

    End Sub
End Class