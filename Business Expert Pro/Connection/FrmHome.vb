Imports System.Management
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Imports System.Speech.Synthesis
Imports System.Collections.ObjectModel



Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Net

Public Class FrmHome

    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point
    Private p_objSynth As New SpeechSynthesizer





    'Server Account Details
    Public ServerName As String = "server.ryansoftbd.com"
    Public DatabaseName As String = "BizProES"
    Public ID As String = "rserver"
    Public Password As String = "rSERVEr2012"


    'SMS Account Details
    Public SMSUserName As String = "01767590658"
    Public SMSPassword As String = "RyansofT2012"
    Public ApiKey As String = "Zzqwbociuc2SnVsnYQZ0"


    Public SenderID As String = "ES Trading"



    Public SMSPhoneNo As String
    Public SMSText As String

    Public ConnectionString As String = "Data Source=" + ServerName + ";Initial Catalog=" + DatabaseName + ";Persist Security Info=True;User ID=" + ID + ";Password=" + Password + ""
    'contact in the end of message body
    Public SMSNumber As String
   
    Public EmployeeID As Integer

    Public ReportLocation As String = System.Windows.Forms.Application.StartupPath + "\"
    'Public ReportLocation As String = "C:\Business Expert Pro\IReports\"


    Dim IncomingTransferInvoiceNo As String


    Public Sub BulksmsbdToAll()



        Dim userid As String = SMSUserName
        Dim password As String = SMSPassword
        Dim message As String = SMSText


        Dim request As WebRequest = WebRequest.Create("http://bulksmsbd.net/api/smsapi?")
        request.Method = "POST"
        Dim postData As String = "api_key=" + ApiKey + "&type=text&number=" + SMSPhoneNo + "&senderid=8809617611021&message=" + SMSText + ""
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)

        request.ContentType = "application/x-www-form-urlencoded"
        request.ContentLength = byteArray.Length
        Dim dataStream As Stream = request.GetRequestStream()
        dataStream.Write(byteArray, 0, byteArray.Length)
        dataStream.Close()
        Dim response As WebResponse = request.GetResponse()
        Console.WriteLine((CType(response, HttpWebResponse)).StatusDescription)
        dataStream = response.GetResponseStream()
        Dim reader As StreamReader = New StreamReader(dataStream)
        Dim result As String = reader.ReadToEnd()

        If result = "1000" Then
            MsgBox("Invalid Username or Password", MsgBoxStyle.Critical, "SMS")
        ElseIf result = "1002" Then
            MsgBox("Empty Number", MsgBoxStyle.Critical, "SMS")

        ElseIf result = "1003" Then
            MsgBox("Invalid or Empty Message", MsgBoxStyle.Critical, "SMS")
        ElseIf result = "1004" Then
            MsgBox("Invalid Number", MsgBoxStyle.Critical, "SMS")
        ElseIf result = "1005" Then
            MsgBox("All Numbers are Invalid", MsgBoxStyle.Critical, "SMS")

        ElseIf result = "1006" Then
            MsgBox("Insufficient Balance", MsgBoxStyle.Critical, "SMS")
        ElseIf result = "1009" Then
            MsgBox("Inactive Account", MsgBoxStyle.Critical, "SMS")
        ElseIf result = "1010" Then
            MsgBox("Max Number Limit Exceeded", MsgBoxStyle.Critical, "SMS")

        ElseIf result.Substring(0, 4) = "1101" Then
            'MsgBox("Sent Successfully", MsgBoxStyle.OkOnly, "SMS")

        End If

        reader.Close()
        dataStream.Close()
        response.Close()


    End Sub




    Public Sub MaskingBulksmsbdToAll()



        Dim userid As String = SMSUserName
        Dim password As String = SMSPassword
        Dim message As String = SMSText

        Dim request As WebRequest = WebRequest.Create("http://bulksmsbd.net/api/smsapi?")
        request.Method = "POST"


        Dim postData As String = "username=" & userid & "&password=" + password & "&number=" + SMSPhoneNo + "&senderid=" + SenderID + "&message=" + message
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
        request.ContentType = "application/x-www-form-urlencoded"
        request.ContentLength = byteArray.Length
        Dim dataStream As Stream = request.GetRequestStream()
        dataStream.Write(byteArray, 0, byteArray.Length)
        dataStream.Close()
        Dim response As WebResponse = request.GetResponse()
        Console.WriteLine((CType(response, HttpWebResponse)).StatusDescription)
        dataStream = response.GetResponseStream()
        Dim reader As StreamReader = New StreamReader(dataStream)
        Dim result As String = reader.ReadToEnd()

        If result = "1000" Then
            MsgBox("Invalid Username or Password", MsgBoxStyle.Critical, "SMS")
        ElseIf result = "1002" Then
            MsgBox("Empty Number", MsgBoxStyle.Critical, "SMS")

        ElseIf result = "1003" Then
            MsgBox("Invalid or Empty Message", MsgBoxStyle.Critical, "SMS")
        ElseIf result = "1004" Then
            MsgBox("Invalid Number", MsgBoxStyle.Critical, "SMS")
        ElseIf result = "1005" Then
            MsgBox("All Numbers are Invalid", MsgBoxStyle.Critical, "SMS")

        ElseIf result = "1006" Then
            MsgBox("Insufficient Balance", MsgBoxStyle.Critical, "SMS")
        ElseIf result = "1009" Then
            MsgBox("Inactive Account", MsgBoxStyle.Critical, "SMS")
        ElseIf result = "1010" Then
            MsgBox("Max Number Limit Exceeded", MsgBoxStyle.Critical, "SMS")

        ElseIf result.Substring(0, 4) = "1101" Then
            'MsgBox("Sent Successfully", MsgBoxStyle.OkOnly, "SMS")

        End If

        reader.Close()
        dataStream.Close()
        response.Close()


    End Sub




    Private Sub FrmHome_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If (MessageBox.Show("Are you sure want to exit?", "Home", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No) Then
            e.Cancel = True
        Else
            'Insert into log 
            InsertIntoLog()

            'AutoBackupDatabase()

            FrmUserLogin.Close()
        End If

    End Sub
    Sub AutoBackupDatabase()

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim currentDate As String = " " & Format(Now, "ddMMMyy")





        
        Try

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "BACKUP DATABASE " + DatabaseName + " TO DISK = 'D:\BizProBackupData\" + DatabaseName + ".Bak'  WITH FORMAT,        MEDIANAME = '" + DatabaseName + " Test Backup',        NAME = '" + DatabaseName + "Data'; "
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try








    End Sub




    Sub VoiceCommand()

        ' p_objSynth.SelectVoice("Microsoft Zira Desktop")

        p_objSynth.Volume = 100
        p_objSynth.Rate = -2
        p_objSynth.SpeakAsync("Welcome, to Business Expert Pro")

    End Sub

    Private Sub FrmHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Location = New Point(0, 0)
        Me.Size = My.Computer.Screen.WorkingArea.Size



        Dim iDate As String = "2050-05-06"
        Dim oDate As DateTime = Convert.ToDateTime(iDate)
        Dim ExpireDate As Date = (oDate.Day & " " & oDate.Month & "  " & oDate.Year)


        If Now >= ExpireDate Then

            MsgBox("Invalid Connection")

            Me.OfflineLicense()
            End

        Else



            VoiceCommand()


            FindMacAddress()
            FindComputerID()




            'change Language
            ChangeLanguage()


            LoadTop10Products()
            LoadTop10Customers()

            LoadIncomingPendigProductTransfer()

            Me.Timer1.Start()

        End If


    End Sub
    Private Sub ProductInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductInformationToolStripMenuItem.Click

    End Sub
    'Clear Data
    Sub ClearData()
        IncomingTransferInvoiceNo = 0
    End Sub
    'Update Transfer Invoice Pending To Complete
    Sub UpdateTransferInvoicePendingToComplete()

        Try


            If Not IncomingTransferInvoiceNo = 0 Then


                'Update Sale Invoice
                Dim con As New SqlConnection
                Dim cmd As New SqlCommand

                con.ConnectionString = Me.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "UPDATE  [Product Transfer Invoice] Set [Status]= 'Complete' where [Transfer Invoice No] ='" + IncomingTransferInvoiceNo + "'"
                cmd.ExecuteNonQuery()
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error while Updating record on table..." & ex.Message, "Update Sale Invoice Sub")
        End Try
    End Sub

    Sub ChangeLanguage()
        ' Changing Language
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        Try
            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Select *From [Language Information] where Status= 1"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then


                Me.lblBranchID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, 12)
                Me.LblBranchName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, 12)
                Me.LblComputerID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, 12)
                Me.LblUserID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, 12)
                'Me.LblUserName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, 12)

                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)



            End If
            'MsgBox(dr.Item("Language Font"))
            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while changing language on table..." & ex.Message, "Change Language")
        Finally

        End Try

        'End Language

    End Sub
    Sub FindMacAddress()
        Try


            Dim cpuInfo As String = String.Empty
            Dim temp As String = String.Empty
            Dim mc As ManagementClass = New ManagementClass("Win32_Processor")
            Dim moc As ManagementObjectCollection = mc.GetInstances
            For Each mo As ManagementObject In moc
                If (cpuInfo = String.Empty) Then
                    ' only return cpuInfo from first CPU
                    cpuInfo = mo.Properties("ProcessorId").Value.ToString
                    Console.WriteLine(("CPU ID : " & cpuInfo))
                    Me.LblComputerSerial.Text = ((cpuInfo))
                End If
            Next
            Console.ReadLine()


        Catch ex As Exception

        End Try

    End Sub


    Sub FindComputerID()
        Try



            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT * from [Computer Account] where [Mac Address]= '" + Me.LblComputerSerial.Text + "'"


            dr = cmd.ExecuteReader()
            dr.Read()


            If dr.HasRows Then

                Try



                    Me.LblComputerID.Text = (dr.Item("Computer ID").ToString)



                Catch ex As Exception

                End Try

            End If

            dr.Close()
            con.Close()



        Catch ex As Exception

        End Try

    End Sub


    Sub LoadTop10Products()
        ' Load Data
        Try
            

            Dim connectionString As String = Me.ConnectionString
            Dim sql As String = "select top 10 Products.[Product Name] , isnull(sum(sale.[sale quantity]),0)[Total sold]  from Sale join Products on Sale.[Product ID]=Products.[Product ID] join [Sale Invoice] on sale.[Sale Invoice No] =[Sale Invoice].[Sale Invoice No] WHERE DATEPART(m, [Sale Date]) = DATEPART(m, DATEADD(m, 0, getdate()))AND DATEPART(yyyy, [Sale Date]) = DATEPART(yyyy, DATEADD(m, 0, getdate())) and [Sale Invoice].Status='Complete' and [Sale].[Branch ID]='" + Me.lblBranchID.Text + "'group by Products.[Product ID], Products.[Product Name] order by [Total sold] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Sale")
            connection.Close()
            GrdTopProducts.DataSource = ds
            GrdTopProducts.DataMember = "BizPro_Sale"

            'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdTopProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill



        Catch ex As Exception
            ' MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Products")
        Finally

        End Try

        'End Refresh Data

    End Sub


    Sub LoadTop10Customers()
        ' Load Data
        Try


            Dim connectionString As String = Me.ConnectionString
            Dim sql As String = "select top 10  [Customer information].[customer Name] from [Sale Invoice] join [Customer Information] on [Sale Invoice].[Customer ID]=[Customer Information].[Customer ID]  join sale on [Sale Invoice].[Sale Invoice No]=sale.[Sale Invoice No] WHERE DATEPART(m, [Sale Date]) = DATEPART(m, DATEADD(m, 0, getdate())) AND DATEPART(yyyy, [Sale Date]) = DATEPART(yyyy, DATEADD(yyyy, 0, getdate())) and [Sale Invoice].Status='Complete' and sale.[branch id]='" + Me.lblBranchID.Text + "' group by [Customer Information].[Customer Name] order by ISNULL (sum([Total]),0)desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Sale Invoice")
            connection.Close()
            GrdTopCustomers.DataSource = ds
            GrdTopCustomers.DataMember = "BizPro_Sale Invoice"

            'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdTopCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill





        Catch ex As Exception
            '  MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Customers")
        Finally

        End Try

        'End Refresh Data

    End Sub



    Sub LoadIncomingPendigProductTransfer()
        ' Load Data
        Try
           
            Dim connectionString As String = Me.ConnectionString
            Dim sql As String = "SELECT [Product Transfer Invoice].[Transfer Invoice No],[Product Transfer Invoice].[Transfer Date],[User Account].[User Name],[Branch Information].[Branch Name]from [Product Transfer Invoice] join  [User Account] on [Product Transfer Invoice].[User Account ID]=[User Account].[User Account ID] join [Branch Information] on [Product Transfer Invoice].[Branch ID]=[Branch Information].[Branch ID] join [Product Transfer] on [Product Transfer Invoice].[Transfer Invoice No]=[Product Transfer].[Transfer Invoice No] where  [Product Transfer Invoice].[Status]='Pending' and [Product Transfer].[Deducted Quantity]=0 and [Product Transfer].[Transfer Branch ID]='" + Me.lblBranchID.Text + "' group by  [Product Transfer Invoice].[Transfer Invoice No],[Product Transfer Invoice].[Transfer Date],[User Account].[User Name],[Branch Information].[Branch Name] "
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Product Transfer Invoice")
            connection.Close()
            GrdToDoList.DataSource = ds
            GrdToDoList.DataMember = "BizPro_Product Transfer Invoice"

            'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdToDoList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill



        Catch ex As Exception
            ' MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Customers")
        Finally

        End Try

        'End Refresh Data

    End Sub
    Sub RefreshdIncomingPendigProductTransfer()
        ' Load Data
        Try
           
            Dim connectionString As String = Me.ConnectionString
            Dim sql As String = "select [Product Transfer].[Transfer ID],[Branch Information].[Branch Name][Transfer To Branch],[Products].[Product Name],[Added Quantity][Transfer Quantity] from [product transfer] join [Products] on [product transfer].[product ID]=[products].[Product ID] join [Branch Information] on [Product Transfer].[Transfer Branch ID] = [Branch Information].[Branch ID] where [Status]='Added' And [Transfer Invoice No]= '" + IncomingTransferInvoiceNo + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Product Transfer")
            connection.Close()
            GrdToDoList.DataSource = ds
            GrdToDoList.DataMember = "BizPro_Product Transfer"

            'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdToDoList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill



        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Customers")
        Finally

        End Try

        'End Refresh Data

    End Sub

    Private Sub AddProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddProductToolStripMenuItem.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                FrmProductCategory.Show()
                FrmProductCategory.TxtCategoryName.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If

            dr.Close()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub AddProductCategoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddProductCategoryToolStripMenuItem.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                FrmProductSubcategory.Show()
                FrmProductSubcategory.TxtProductSubcategoryName.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub AddProductCategoryToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddProductCategoryToolStripMenuItem1.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                FrmProductGroup.Show()
                FrmProductGroup.TxtProductGroupName.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If

            dr.Close()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub AddSubCateogoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSubCateogoryToolStripMenuItem.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                FrmProductInformation.Show()
                FrmProductInformation.CmbProductGroupID.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub CompanyDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompanyDetailsToolStripMenuItem.Click

    End Sub

    Private Sub SaleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleToolStripMenuItem.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                FrmSale.Show()
                FrmSale.CmbCustomerName.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        'Me.Hide()




        For Each Form In My.Application.OpenForms
            Form.hide()

            'Form Login Open
            FrmUserLogin.Show()
            FrmUserLogin.CmbUserAccountID.Focus()

            'Clear Data
            FrmUserLogin.TxtPassword.Text = ""
            FrmUserLogin.CmbUserAccountID.SelectedValue = 0


        Next

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub ComputerAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComputerAccountToolStripMenuItem.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                FrmComputerAccount.Show()
                FrmComputerAccount.TxtMACAddress.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CompanyDetailsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompanyDetailsToolStripMenuItem1.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                FrmCompanyDetails.Show()
                FrmCompanyDetails.TxtCompanyName.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub LanguageInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LanguageInformationToolStripMenuItem.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                FrmLanguageInformation.Show()
                FrmLanguageInformation.TxtLanguageName.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub SaleReturnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleReturnToolStripMenuItem.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                FrmSaleReturn.Show()
                FrmSaleReturn.CmbSearch.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PurchaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseToolStripMenuItem.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                FrmPurchase.Show()
                FrmPurchase.CmbSupplierName.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PurchaseReturnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseReturnToolStripMenuItem.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                FrmPurchaseReturn.Show()
                FrmPurchaseReturn.TxtSearch.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AddCustomerCategoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddCustomerCategoryToolStripMenuItem.Click

    End Sub
    Private Sub AddExpensePurposeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddExpensePurposeToolStripMenuItem.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                frmHeadOfAccount.Show()
                frmHeadOfAccount.TxtAccountName.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AddCashExpenditureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddCashExpenditureToolStripMenuItem.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                FrmChartofAccount.Show()
                FrmChartofAccount.CmbHeadofAccountID.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PermissionSetupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermissionSetupToolStripMenuItem.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                FrmPermissionSetup.Show()
                FrmPermissionSetup.CmbUserAccountID.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub





    Private Sub QuotationsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuotationsToolStripMenuItem.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                FrmQuotation.Show()
                FrmQuotation.CmbCustomerName.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub CashExpenditureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CashExpenditureToolStripMenuItem.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                FrmLedger.Show()
                FrmLedger.BtnCollection.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BankInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BankInformationToolStripMenuItem.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                FrmBankInformation.Show()
                FrmBankInformation.TxtBankName.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BankTransactionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BankTransactionToolStripMenuItem.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                FrmCheckProcessing.Show()
                FrmCheckProcessing.BtnRefresh.Focus()
            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub SMSNoticeBoardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SMSNoticeBoardToolStripMenuItem.Click

    End Sub


    Private Sub EmployeeInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeInformationToolStripMenuItem.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                FrmEmployeeInformation.Show()
                FrmEmployeeInformation.TxtEmployeeName.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EmployeeSalaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmEmployeeSalary.Show()
    End Sub

    Private Sub EmployeeAttendanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmEmployeeAttendanceDetails.Show()
    End Sub

    Private Sub BranchInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BranchInformationToolStripMenuItem.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                FrmBranchInformation.Show()

                FrmBranchInformation.TxtBranchName.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub StockInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LocationInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocationInformationToolStripMenuItem.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                FrmLocationInformation.Show()
                FrmLocationInformation.CmbBranchID.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SaleHistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleHistoryToolStripMenuItem.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                FrmSaleHistory.Show()
                FrmSaleHistory.TxtSearchSaleInvoice.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub PurchaseHistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseHistoryToolStripMenuItem.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                FrmPurchaseHistory.Show()
                FrmPurchaseHistory.TxtSearchPurchaseInvoice.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub






    Private Sub QuotationHistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuotationHistoryToolStripMenuItem.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                FrmQuotationHistory.Show()
                FrmQuotationHistory.TxtSearchQuotationInvoice.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToDoListToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToDoListToolStripMenuItem2.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                FrmToDoList.Show()
                FrmToDoList.txtDescription.Focus()
            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ViewToDoListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewToDoListToolStripMenuItem.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then



                FrmViewToDoList.Show()
                FrmViewToDoList.BtnSearch.Focus()
            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub



    Private Sub VoucherHistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VoucherHistoryToolStripMenuItem.Click

        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                FrmLedgerHistory.Show()
                FrmLedgerHistory.TxtLedgerInvoiceNo.Focus()


            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub StockReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                RptStockReport.Show()
                RptStockReport.CmbSearchBy.Focus()
            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CustomerCategoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerCategoryToolStripMenuItem.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                FrmCustomerCategory.Show()
                FrmCustomerCategory.TxtCustomerCategoryName.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CustomerInformationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerInformationToolStripMenuItem1.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                FrmCustomerInformation.Show()
                FrmCustomerInformation.CmbCustomerName.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SupplierInformationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierInformationToolStripMenuItem1.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                FrmSupplierInformation.Show()
                FrmSupplierInformation.CmbSupplierName.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SupplierCategoryToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierCategoryToolStripMenuItem1.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                FrmSupplierCategory.Show()
                FrmSupplierCategory.TxtSupplierCategoryName.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub







    Private Sub Panel4_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel4.MouseClick

        ' Me.Panel4.BackColor = Color.FromArgb(0, 102, 204)

    End Sub

    Private Sub Panel4_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel4.MouseMove

        '  If e.Button = Windows.Forms.MouseButtons.Left Then
        'newpoint = Control.MousePosition
        ' newpoint.X -= (X)
        ' newpoint.Y -= (Y)
        'Me.Location = newpoint

        'End If
    End Sub

    Private Sub Panel4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        


        Me.Close()

    End Sub



    Private Sub Button6_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal

        Else
            Me.WindowState = FormWindowState.Maximized

        End If
    End Sub

    Private Sub Button7_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub



    Private Sub Button2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHome.Click
        PnlHighlight.Visible = True
        PnlHighlight.Top = Me.BtnHome.Top


        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader


            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = 'Product Information'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                FrmProductInformation.Show()
                FrmProductInformation.CmbProductGroupID.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button4_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPurchase.Click
        PnlHighlight.Visible = True
        PnlHighlight.Top = Me.BtnPurchase.Top

        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader


            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = 'Purchase'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                FrmPurchase.Show()
                FrmPurchase.CmbSupplierName.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

   


    Private Sub Panel11_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PnlMenustrip.Paint

    End Sub

  

    Private Sub FrmHome_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick






        If PnlRyansoft.Width >= 111 Then


            Me.PnlRyansoft.Width = PnlRyansoft.Width + 1

        End If


        If PnlRyansoft.Width = 886 Then
            Me.LblDevelopedBy.Show()
            Me.LblRyansoft.Show()
            Me.Timer1.Interval = 10000

        End If
        If PnlRyansoft.Width = 887 Then


       

            Me.PnlRyansoft.Width = 111
            Me.LblDevelopedBy.Hide()
            Me.LblRyansoft.Hide()
            Me.Timer1.Interval = 10

            LoadTop10Products()
            LoadTop10Customers()

          
        End If


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProducts.Click
        PnlHighlight.Visible = True
        PnlHighlight.Top = Me.BtnProducts.Top

        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader


            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = 'Stock Report'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                RptStockReport.Show()
                RptStockReport.CmbSearchBy.Focus()
            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnLedger_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLedger.Click
        PnlHighlight.Visible = True
        PnlHighlight.Top = Me.BtnLedger.Top

        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader


            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = 'Ledger Details'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                RptLedgerDetails.Show()
                RptLedgerDetails.CmbChartOfAccount.Focus()
            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub BtnAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAccount.Click
        PnlHighlight.Visible = True
        PnlHighlight.Top = Me.BtnAccount.Top

        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader


            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = 'Collection/Payment'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                FrmLedger.Show()
                FrmLedger.BtnCollection.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnPOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPOS.Click
        'Try


        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        con.ConnectionString = Me.ConnectionString
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = 'POS'"
        dr = cmd.ExecuteReader()
        dr.Read()

        If dr.HasRows Then

            'Show Reset Password Form
            FrmPOS.Show()
            LoadPOSDetailsOnStart()


        Else
            MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
        End If
        dr.Close()

        con.Close()

        ' Catch ex As Exception
        'MsgBox(ex.Message)
        ' End Try



    End Sub


    Sub LoadPOSDetailsOnStart()


        FrmPOS.CmbCustomerName.Text = "Cash Sale"
        FrmPOS.CmbCustomerName.ValueMember = 3
        FrmPOS.TxtSearchBarcode.Focus()

        FrmPOS.customerInformation()

        'Show Customer Dues or advanced
        FrmPOS.ShowDueOrAdvance()


        'CalCulate Netpayable
        FrmPOS.NetPayableAmount()

        'Calculation Of Balance And ReturnAmount
        FrmPOS.CalculationOfBalanceAndReturnAmount()


        'Focus on product combobox
        FrmPOS.TxtSearchBarcode.Focus()






        'hide product list gridview
        FrmPOS.GrdCustomerList.Visible = False
        FrmPOS.cmbPaidBy.Text = "CASH"
        FrmPOS.cmbPaidBy.SelectedValue = 5
    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        System.Diagnostics.Process.Start("https://www.facebook.com/ryansoft")
    End Sub


    Private Sub WarrToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WarrToolStripMenuItem.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                FrmProductTransfer.Show()
                FrmProductTransfer.CmbToBranch.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ProductTransferHistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductTransferHistoryToolStripMenuItem.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                FrmProductTransferHistory.Show()
                FrmProductTransferHistory.TxtSearchInvoice.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub GrdTopCustomers_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdTopCustomers.CellContentClick

    End Sub

    Private Sub BtnSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSale.Click
        PnlHighlight.Visible = True
        PnlHighlight.Top = Me.BtnSale.Top

        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader


            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = 'Sale'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                FrmSale.Show()
                FrmSale.CmbCustomerName.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnWarranty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnWarranty.Click
        PnlHighlight.Visible = True
        PnlHighlight.Top = Me.BtnWarranty.Top

        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader


            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  * FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = 'Warranty Look up'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                FrmWarrantyLookUp.Show()
                FrmWarrantyLookUp.TxtSerialNumber.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

    End Sub

    Private Sub LedgerSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LedgerSummaryToolStripMenuItem.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                RptLedgerDetails.Show()
                RptLedgerDetails.CmbChartOfAccount.Focus()
            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub GrdTopProducts_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdTopProducts.CellContentClick

    End Sub

    Private Sub WarrantyHistoryToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WarrantyHistoryToolStripMenuItem.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                FrmWarrantyLookUp.Show()
                FrmWarrantyLookUp.TxtSerialNumber.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub WarrantyHistoryToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WarrantyHistoryToolStripMenuItem1.Click

        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                FrmWarrantyHistory.Show()
                FrmWarrantyHistory.TxtSearchWarrantyInvoice.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub WarrantyHistoryToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WarrantyHistoryToolStripMenuItem2.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then


                FrmWarrantyDelivery.Show()
                FrmWarrantyDelivery.TxtSearch.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub WarrantyDeliveryHistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WarrantyDeliveryHistoryToolStripMenuItem.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then


                FrmWarrantyDeliveryHistory.Show()
                FrmWarrantyDeliveryHistory.TxtSearchWarrantyInvoice.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub WarrantyProcessingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WarrantyProcessingToolStripMenuItem.Click

        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then


                FrmWarrantyProcessing.Show()
                FrmWarrantyProcessing.TxtSearchInvice.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub SaleReturnHistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleReturnHistoryToolStripMenuItem.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                FrmSaleReturnHistory.Show()
                FrmSaleReturnHistory.TxtSearchSaleReturnInvoice.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub UserAccountToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserAccountToolStripMenuItem3.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                FrmUserAccount.Show()
                FrmUserAccount.TxtUserName.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ResetPasswordToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetPasswordToolStripMenuItem1.Click
        FrmResetPassword.Show()
        FrmResetPassword.cmbUserName.Focus()
    End Sub

    Private Sub ToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem8.Click

    End Sub

    Private Sub SaleReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleReportToolStripMenuItem.Click

        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then


                RptSaleReport.Show()
                RptSaleReport.CmbSelectSearchBy.Focus()
            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CashFlowReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CashFlowReportToolStripMenuItem.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then


                RptCashFlow.Show()


            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub UnitInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnitInformationToolStripMenuItem.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Unit Information show
                FrmUnitInformation.Show()
                FrmUnitInformation.TxtUnitName.Focus()
            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ProblemDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProblemDetailsToolStripMenuItem.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Unit Information show
                FrmProblemCategory.Show()
                FrmProblemCategory.TxtProblemCategoryName.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PurchaseReturnHistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseReturnHistoryToolStripMenuItem.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                FrmPurchaseReturnHistory.Show()
                FrmPurchaseReturnHistory.TxtSearchPurchaseReturnInvoice.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AccountsReceivablePayableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountsReceivablePayableToolStripMenuItem.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                RptAccountsReceivableAndPayable.Show()
                RptAccountsReceivableAndPayable.CmbShowReport.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ProductLifeCycleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductLifeCycleToolStripMenuItem.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                FrmProductLifeCycle.Show()
                FrmProductLifeCycle.cmbProductName.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GrdToDoList_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdToDoList.CellContentClick

    End Sub

    Private Sub GrdToDoList_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdToDoList.CellMouseClick

    End Sub

    Private Sub GrdToDoList_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdToDoList.CellMouseDoubleClick
        Try



            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdToDoList.Rows(e.RowIndex)

                IncomingTransferInvoiceNo = row.Cells("Transfer Invoice No").Value

                'refresh data product transfer information
                RefreshdIncomingPendigProductTransfer()

              


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

 

  

    Private Sub PnlHighlight_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PnlHighlight.Paint

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        System.Diagnostics.Process.Start("https://mail.google.com/mail/u/0/#inbox?compose=new")
    End Sub

    Private Sub BtnExit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click


        PnlHighlight.Visible = True
        PnlHighlight.Top = Me.BtnExit.Top


        Me.Close()
    End Sub
    'Insert into log 
    Sub InsertIntoLog()
        Try

            'Data Insert Code
            Dim con1 As New SqlConnection
            Dim cmd1 As New SqlCommand
            Dim CurrentDate As DateTime = DateTime.Today
            Dim CurrentTime As DateTime = DateTime.Now


            con1.ConnectionString = Me.ConnectionString
            con1.Open()
            cmd1.Connection = con1
            cmd1.CommandText = "INSERT INTO [Log Details] ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID])VALUES('" + Me.Text + "','Log Out', 'User Name: " + Me.LblUserName.Text + " loged Out from software','" + Me.LblUserID.Text + "','" + Me.LblComputerID.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + Me.lblBranchID.Text + "','" + Me.LblUserID.Text + "' )"
            cmd1.ExecuteNonQuery()
            con1.Close()



        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally


        End Try
    End Sub



    Private Sub BackupToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        System.Diagnostics.Process.Start("https://www.facebook.com/ryansoft/inbox")
    End Sub

    Private Sub UserAccountToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserAccountToolStripMenuItem2.Click

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Panel100_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel100.Paint

    End Sub

    Private Sub PurchaseReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseReportToolStripMenuItem.Click
        'Show purchase Report
        RptPurchaseReport.Show()

    End Sub

    Private Sub EmployeeCategoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeCategoryToolStripMenuItem.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                FrmEmployeeCategory.Show()
                FrmEmployeeCategory.TxtEmployeeCategoryName.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DToolStripMenuItem.Click
        RptDailyStatement.Show()
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub IncomeStatementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IncomeStatementToolStripMenuItem.Click
        RptIncomeStatement.Show()
    End Sub

    Private Sub StockReportToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockReportToolStripMenuItem.Click
        RptStockReport.Show()

    End Sub

              Sub DataRestore()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now
        'D:\Dropbox\456.Bak
        Dim GetDrivePath As String
        OpenFileDialog1.Filter = "Backup Files (*.bak)|*.*"
        GetDrivePath = OpenFileDialog1.ShowDialog()
        If GetDrivePath = Windows.Forms.DialogResult.OK Then
            GetDrivePath = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)



            Try

                con.ConnectionString = Me.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "USE [master] ALTER DATABASE BizProDoubleClick SET SINGLE_USER WITH ROLLBACK IMMEDIATE DROP DATABASE BizProDoubleClick Use master RESTORE DATABASE BizProDoubleClick  FROM DISK = '" + GetDrivePath + "'"


                cmd.ExecuteNonQuery()
                'Insert Click Msg
                MsgBox("Data Restored Successfully", MsgBoxStyle.OkOnly, "Data Restore")


                'Shell(System.Windows.Forms.Application.StartupPath + "\Business Expert Pro.exe")

                End


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If



    End Sub

    Private Sub BalaceSheetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BalaceSheetToolStripMenuItem.Click
        RptBalanceSheet.Show()

    End Sub

    Private Sub ProblemDetailsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProblemDetailsToolStripMenuItem1.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Unit Information show
                FrmProblemCategory.Show()
                FrmProblemCategory.TxtProblemCategoryName.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Sub OfflineLicense()
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand


            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Update [Computer Account] set [Mac Address]='Expired' "
            cmd.ExecuteNonQuery()
            con.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub PnlRyansoft_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PnlRyansoft.Paint

    End Sub

    Private Sub POSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles POSToolStripMenuItem.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            Dim myToolstrip As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

            con.ConnectionString = Me.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + Me.LblUserID.Text + "' AND [Category Name] = '" + myToolstrip.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                'Show Reset Password Form
                FrmPOS.Show()
                LoadPOSDetailsOnStart()


            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CustomerListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerListToolStripMenuItem.Click
        RptCustomerList.Show()

    End Sub
End Class
