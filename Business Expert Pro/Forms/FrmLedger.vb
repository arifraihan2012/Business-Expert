
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.IO.Ports
Imports System.Text.RegularExpressions

Public Class FrmLedger


    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point

    Dim SMSPort As New SerialPort


    Dim TotalAmount As String
    Dim TotalExpense As String
    Dim TransactionLimit As String
    Dim DeletePermission As Boolean
    Dim UpdatePermission As Boolean
    Public LogCategoryStatus As String






    

    'Sub for show dues or advanced or Greeting
    Sub SendSMS()
        Try

            If FrmHome.LblStatus.Text = "Active" Or FrmHome.LblStatus.Text = "Masking" Then


                Dim q As MsgBoxResult
                q = MsgBox("Do you want to send SMS?", MsgBoxStyle.YesNo, "Accounts")

                If q = MsgBoxResult.Yes Then


                    Dim con1 As New SqlConnection
                    Dim con As New SqlConnection
                    Dim cmd As New SqlCommand
                    Dim cmd2 As New SqlCommand
                    Dim dr As SqlDataReader
                    Dim CurrentDate As DateTime = DateTime.Today
                    Dim CurrentTime As DateTime = DateTime.Now


                    Dim MobileNumber As String

                    'Data reader for Product Id
                    con1.ConnectionString = FrmHome.ConnectionString
                    con1.Open()
                    cmd.Connection = con1
                    cmd.CommandText = "select * from [Customer Information] where [Chart Of Account ID]= '" + CmbChartOfAccount.ValueMember.ToString + "' "

                    dr = cmd.ExecuteReader()
                    dr.Read()


                    If dr.HasRows Then
                        MobileNumber = dr.Item("Mobile No").ToString


                        FrmHome.SMSPhoneNo = MobileNumber

                        'Send due sms
                        If Val(LblBalance1.Text) > 0 Then

                            FrmHome.SMSText = "Dear Customer, " & "BDT " & "" + TotalAmount + "" & " has been received on  " & "" + (DtpLedgerDate.Value.ToString("dd-MMM-yy")) + "" & ". Your current due is BDT " & Val(LblBalance1.Text) & ". Thank you. " & "" + FrmHome.lblCompanyName.Text + "" & ". Contact No: " & "" + FrmHome.SMSNumber + ""

                            If FrmHome.LblStatus.Text = "Active" Then
                                FrmHome.BulksmsbdToAll()
                            ElseIf FrmHome.LblStatus.Text = "Masking" Then
                                FrmHome.MaskingBulksmsbdToAll()
                            End If

                            'Send advance sms
                        ElseIf Val(LblBalance1.Text) < 0 Then


                            FrmHome.SMSText = "Dear Customer, " & "BDT " & "" + TotalAmount + "" & " has been received on  " & "" + (DtpLedgerDate.Value.ToString("dd-MMM-yy")) + "" & ". Your current advance is BDT " & Val(LblBalance1.Text) * -1 & ". Thank you. " & "" + FrmHome.lblCompanyName.Text + "" & ". Contact No: " & "" + FrmHome.SMSNumber + ""

                            If FrmHome.LblStatus.Text = "Active" Then
                                FrmHome.BulksmsbdToAll()
                            ElseIf FrmHome.LblStatus.Text = "Masking" Then
                                FrmHome.MaskingBulksmsbdToAll()
                            End If

                        ElseIf Val(LblBalance1.Text) = 0 Then

                            FrmHome.SMSText = "Dear Customer, " & "BDT " & "" + TotalAmount + "" & " has been received on  " & "" + (DtpLedgerDate.Value.ToString("dd-MMM-yy")) + "" & ". Thank you. " & "" + FrmHome.lblCompanyName.Text + "" & ". Contact No: " & "" + FrmHome.SMSNumber + ""

                            If FrmHome.LblStatus.Text = "Active" Then
                                FrmHome.BulksmsbdToAll()
                            ElseIf FrmHome.LblStatus.Text = "Masking" Then
                                FrmHome.MaskingBulksmsbdToAll()
                            End If


                        End If
                    End If

                    dr.Close()
                    con1.Close()

                End If


            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPayment.Click

        'permission for update and Delete
        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader





            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + FrmHome.LblUserID.Text + "' AND [Category Name] = 'Ledger Payment' And  [Update Delete Permission]='Yes'"


            dr = cmd.ExecuteReader()
            dr.Read()

            If Not TxtLedgerInvoiceNo.Text = "" And Not BtnCollection.ForeColor = Color.Black And Not GrdLedger.RowCount = 0 Or Not TxtLedgerInvoiceNo.Text = "" And Not BtnPayment.ForeColor = Color.Black And Not GrdLedger.RowCount = 0 Or Not TxtLedgerInvoiceNo.Text = "" And Not BtnExpense.ForeColor = Color.Black And Not GrdLedger.RowCount = 0 Or Not TxtLedgerInvoiceNo.Text = "" And Not BtnTransfer.ForeColor = Color.Black And Not GrdLedger.RowCount = 0 Or Not GrdLedger.RowCount = 0 Then
                MsgBox("Please complete this voucher first.", MsgBoxStyle.Critical, "Ledger")

                'Clear Data
                clearData()

            Else
                If dr.HasRows Then

                    'Clear Data
                    'clearData()

                    BtnCollection.ForeColor = Color.Black
                    BtnPayment.ForeColor = Color.Red
                    BtnExpense.ForeColor = Color.Black
                    BtnTransfer.ForeColor = Color.Black

                    LblChartOfAccount.Text = "Paid To:"
                    LblPaidBy.Text = "Paid By:"


                    GrpLedger.Enabled = True


                    clearData()

                    'Insert or  Update for 2nd Invoice Number For An Invoice
                    InsertOrUpdateIntoLedgerInvoiceNo2ForAnInvoice()

                    'Focus on Voucher Name
                    CmbVoucherName.Focus()

                    'Find Delete permission
                    DeletePermission = True

                ElseIf Not dr.HasRows Then

                    Me.BtnCollection.ForeColor = Color.Black
                    Me.BtnPayment.ForeColor = Color.Black
                    Me.BtnExpense.ForeColor = Color.Black
                    Me.BtnTransfer.ForeColor = Color.Black
                    Me.GrpLedger.Enabled = False

                End If
            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while  permission delete to form..." & ex.Message, "Form Load")

        End Try

    End Sub

    Private Sub BtnReceive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCollection.Click


        'permission for update and Delete
        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader





            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + FrmHome.LblUserID.Text + "' AND [Category Name] = 'Ledger Collection' And  [Update Delete Permission]='Yes'"


            dr = cmd.ExecuteReader()
            dr.Read()

            If Not TxtLedgerInvoiceNo.Text = "" And Not BtnCollection.ForeColor = Color.Black And Not GrdLedger.RowCount = 0 Or Not TxtLedgerInvoiceNo.Text = "" And Not BtnPayment.ForeColor = Color.Black And Not GrdLedger.RowCount = 0 Or Not TxtLedgerInvoiceNo.Text = "" And Not BtnExpense.ForeColor = Color.Black And Not GrdLedger.RowCount = 0 Or Not TxtLedgerInvoiceNo.Text = "" And Not BtnTransfer.ForeColor = Color.Black And Not GrdLedger.RowCount = 0 Or Not GrdLedger.RowCount = 0 Then
                MsgBox("Please complete this voucher first.", MsgBoxStyle.Critical, "Ledger")

                'Clear Data
                clearData()
            Else

                If dr.HasRows Then





                    BtnCollection.ForeColor = Color.Blue
                    BtnPayment.ForeColor = Color.Black
                    BtnExpense.ForeColor = Color.Black
                    BtnTransfer.ForeColor = Color.Black

                    LblChartOfAccount.Text = "Received From:"
                    LblPaidBy.Text = "Received By:"


                    GrpLedger.Enabled = True

                    ' LoadComboBoxChartOfAccountForCollPay()

                    'Load Combobox For Voucher Name
                    'LoadComboBoxForVoucherName()

                    'Clear Data
                    clearData()

                    'Insert or  Update for 2nd Invoice Number For An Invoice
                    InsertOrUpdateIntoLedgerInvoiceNo2ForAnInvoice()

                    'Focus on Voucher Name
                    CmbVoucherName.Focus()

                ElseIf Not dr.HasRows Then

                    Me.BtnCollection.ForeColor = Color.Black
                    Me.BtnPayment.ForeColor = Color.Black
                    Me.BtnExpense.ForeColor = Color.Black
                    Me.BtnTransfer.ForeColor = Color.Black
                    Me.GrpLedger.Enabled = False

                End If
            End If

            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while  permission delete to form..." & ex.Message, "Form Load")

        End Try




    End Sub

    Private Sub GrpLedger_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrpLedger.Enter

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


                Me.TxtLedgerNo.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.CmbVoucherName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.CmbChartOfAccount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.CmbPaidBy.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtAmount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtCheckNo.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.DtpIssueDate.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtVoucherNo.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtRemarks.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtLedgerInvoiceNo.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.DtpLedgerDate.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))


                Me.TxtRemarks.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")), FontStyle.Bold)

                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

                Me.GrdLedger.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdLedger.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)

                Me.GrdShowDueBills.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdShowDueBills.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)

                'MsgBox(dr.Item("Language Font"))
            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally

        End Try

        'End Language

    End Sub


    Sub clearData()

        Me.TxtLedgerNo.Text = ""

        Me.CmbChartOfAccount.Text = ""
        Me.CmbChartOfAccount.ValueMember = ""

        Me.CmbPaidBy.Text = ""
        Me.CmbPaidBy.ValueMember = ""

       

        Me.TxtAmount.Text = ""
        Me.TxtCheckNo.Text = ""
        Me.TxtVoucherNo.Text = ""
        Me.TxtRemarks.Text = ""
        ' Me.DtpLedgerDate.Value = Now
        Me.DtpIssueDate.Value = Now

        LblBalance1Lbl.ForeColor = Color.Black
        LblBalance2Lbl.ForeColor = Color.Black
        GrdShowDueBills.Columns.Clear()

        LblBalance1.Text = "00"
        LblBalance2.Text = "00"

    End Sub

    'Clear Data For Collection And Payment
    Sub ClearDataForCollectionAndPayment()

        Me.TxtLedgerNo.Text = ""

        Me.TxtAmount.Text = ""
        Me.TxtCheckNo.Text = ""
        Me.TxtVoucherNo.Text = ""
        Me.TxtRemarks.Text = ""


        Me.DtpIssueDate.Value = Now
        LblBalance1.Text = "00"
        LblBalance2.Text = "00"
        LblBalance1Lbl.ForeColor = Color.Black
        LblBalance2Lbl.ForeColor = Color.Black

        If Not BtnPayment.ForeColor = Color.Black Then
            'Refresh Data For Show Pending Purchase Bills
            RefreshDataForShowPendingPurchaseBills()

        ElseIf Not BtnCollection.ForeColor = Color.Black Then

            'Refresh Data For Show Pending Sale Bills
            RefreshDataForShowPendingSaleBills()

        End If
    End Sub

    'Clear Data For Expense and Transfer
    Sub ClearDataForExpenseAndTransfer()

        Me.TxtLedgerNo.Text = ""

        Me.CmbChartOfAccount.Text = ""
        Me.CmbChartOfAccount.ValueMember = ""

       

        Me.TxtAmount.Text = ""
        Me.TxtCheckNo.Text = ""
        Me.TxtVoucherNo.Text = ""
        Me.TxtRemarks.Text = ""


        Me.DtpIssueDate.Value = Now
        LblBalance1.Text = "00"
        LblBalance2.Text = "00"
        LblBalance1Lbl.ForeColor = Color.Black
        LblBalance2Lbl.ForeColor = Color.Black


    End Sub

    'Clear All Data
    Sub clearAllData()

        Me.TxtLedgerNo.Text = ""
        Me.TxtLedgerInvoiceNo.Text = ""

        Me.CmbChartOfAccount.Text = ""
        Me.CmbChartOfAccount.ValueMember = ""

        Me.CmbPaidBy.Text = ""
        Me.CmbPaidBy.ValueMember = ""

        Me.CmbVoucherName.ValueMember = ""
        Me.CmbVoucherName.Text = ""

        Me.TxtAmount.Text = ""
        Me.TxtCheckNo.Text = ""
        Me.TxtVoucherNo.Text = ""
        Me.TxtRemarks.Text = ""
        Me.DtpLedgerDate.Value = Now
        Me.DtpIssueDate.Value = Now

        LblBalance1Lbl.ForeColor = Color.Black
        LblBalance2Lbl.ForeColor = Color.Black

        GrdShowDueBills.Columns.Clear()
        GrdLedger.Columns.Clear()

        CmbVoucherName.SelectedValue = 0

        Me.BtnCollection.ForeColor = Color.Black
        Me.BtnPayment.ForeColor = Color.Black
        Me.BtnExpense.ForeColor = Color.Black
        Me.BtnTransfer.ForeColor = Color.Black
        Me.GrpLedger.Enabled = False

        TxtVoucherNo.ReadOnly = False

        LblBalance1.Text = "00"
        LblBalance2.Text = "00"

    End Sub
    'Search Voucher Name
    Sub SearchVoucherName()
        ' Load Data
        Try
          
            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select [Chart of Account ID],[Employee Name] from [Employee Information] Where [Employee Name] LIKE '%" + CmbVoucherName.Text + "%'"


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Employee Information")
            connection.Close()
            GrdVoucherName.DataSource = ds
            GrdVoucherName.DataMember = "BizPro_Employee Information"
            connection.Close()

            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            GrdVoucherName.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells


        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records")
        Finally

        End Try

        'End Refresh Data

    End Sub
    'Search Chart of Account
    Sub SearchChartofAccount()
        ' Load Data
        Try
          

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select [Chart of Account].[Chart of Account ID],[Chart of Account].[Account Name],[Customer Information].[Mobile No],[Head of Account].[Account Name] from [Chart of Account] join [Head of Account] on [Chart of Account].[Head of Account ID]=[Head of Account].[Head Of Account ID] Left join [Customer Information] on [Chart of Account].[Chart of Account ID]=[Customer Information].[Chart of Account ID] Where [Chart of Account].[Account Name] + [Customer Information].[Mobile No] LIKE '%" + CmbChartOfAccount.Text + "%' or [Chart of Account].[Account Name] LIKE '%" + CmbChartOfAccount.Text + "%'"


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Chart of Account")
            connection.Close()
            GrdChartofAccount.DataSource = ds
            GrdChartofAccount.DataMember = "BizPro_Chart of Account"
            connection.Close()

            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            GrdChartofAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells


        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records")
        Finally

        End Try

        'End Refresh Data

    End Sub
    'Search Chart of Account for Expense
    Sub SearchChartofAccountForExpense()
        ' Load Data
        Try


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select [Chart of Account].[Chart of Account ID],[Chart of Account].[Account Name],[Head of Account].[Account Name] from [Chart of Account]  join [Head of Account] on [Chart of Account].[Head of Account ID]=[Head of Account].[Head Of Account ID] Where [Head of Account].[Account Category] ='EXPENSE' And [Chart of Account].[Account Name] LIKE '%" + CmbChartOfAccount.Text + "%'"


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Chart of Account")
            connection.Close()
            GrdChartofAccount.DataSource = ds
            GrdChartofAccount.DataMember = "BizPro_Chart of Account"
            connection.Close()

            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            GrdChartofAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells


        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records")
        Finally

        End Try

        'End Refresh Data

    End Sub
    'Search Chart of Account To Paid by For Transfer
    Sub SearchChartofAccountToPaidbyForTransfer()
        ' Load Data
        Try


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select [Chart of Account].[Chart of Account ID],[Chart of Account].[Account Name],[Customer Information].[Mobile No],[Head of Account].[Account Name] from [Chart of Account] join [Head of Account] on [Chart of Account].[Head of Account ID]=[Head of Account].[Head Of Account ID] Left join [Customer Information] on [Chart of Account].[Chart of Account ID]=[Customer Information].[Chart of Account ID] Where [Chart of Account].[Account Name] + [Customer Information].[Mobile No] LIKE '%" + CmbPaidBy.Text + "%' or [Chart of Account].[Account Name] LIKE '%" + CmbPaidBy.Text + "%'"


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Chart of Account")
            connection.Close()
            GrdPaidBy.DataSource = ds
            GrdPaidBy.DataMember = "BizPro_Chart of Account"
            connection.Close()

            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            GrdPaidBy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells


        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records")
        Finally

        End Try

        'End Refresh Data

    End Sub
    'Search Paid By
    Sub SearchPaidBy()
        ' Load Data
        Try


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select [Chart of Account].[Chart of Account ID],[Chart of Account].[Account Name] from [Chart of Account] join [Head of Account] on [Chart of Account].[Head of Account ID]=[Head of Account].[Head Of Account ID] where   [Chart of Account].[Account Name] LIKE '%" + CmbPaidBy.Text + "%'"


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Chart of Account")
            connection.Close()
            GrdPaidBy.DataSource = ds
            GrdPaidBy.DataMember = "BizPro_Chart of Account"
            connection.Close()

            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            GrdPaidBy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells


        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records")
        Finally

        End Try

        'End Refresh Data

    End Sub

    Private Sub GrpLedger_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GrpLedger.KeyPress

    End Sub

    Private Sub FrmLedger_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
                UpdatePermission = True

                DeletePermission = True
            ElseIf Not dr.HasRows Then
                BtnDelete.Enabled = False
                UpdatePermission = False
                DeletePermission = False
            End If

            dr.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while  permission delete to form..." & ex.Message, "Form Load")

        End Try

        'LoadComboBoxPaidByForCollPay()
        Me.CmbPaidBy.Text = ""

        'Change Langeuge Privet Sub
        ChangeLanguage()

        'Clear all data
        clearAllData()


    End Sub


    Sub insertDataForCollection()
        'Data Insert Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now
        Try

            'Empty Txt Box Can Not Be Save Code
            If Me.CmbChartOfAccount.Text = "" Or Me.CmbPaidBy.Text = "" Or Me.TxtAmount.Text = "" Then
                MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Ledger")

            Else

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd1.Connection = con
                cmd.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart of Account ID],[Invoice No],[Debited Amount],[Credited Amount],[Voucher No],[Description],[Remarks],[Status],[Branch ID],[Prepared Date],[Prepared Time],[User Account ID],[Computer ID],[Check No],[Category Name],[Pending Invoice],[Ledger Invoice ID 2]) VALUES ('" + DtpLedgerDate.Value + "','" + CmbPaidBy.ValueMember + "','" + TxtLedgerNo.Text + "','" + TxtAmount.Text + "','0','" + TxtVoucherNo.Text + "', 'Collection From " + Me.CmbChartOfAccount.Text + "','" + Me.TxtRemarks.Text + "','CASH','" + FrmHome.lblBranchID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + TxtCheckNo.Text + "','Collection','" + TxtVoucherNo.Text + "','" + TxtLedgerInvoiceNo.Text + "')   INSERT INTO [Log Details]   ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES('LEDGER COLLECTION','" + LogCategoryStatus + "','Ledger No:" + TxtLedgerNo.Text + ",Voucher Name: " + CmbVoucherName.Text + " , Collection From: " + CmbChartOfAccount.Text + " , Collection By: " + CmbPaidBy.Text + ",  Amount: " + TxtAmount.Text + " , Check No: " + TxtCheckNo.Text + ", Voucher No: " + TxtVoucherNo.Text + " , Remarks: " + TxtRemarks.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtLedgerInvoiceNo.Text + "' )"
                cmd1.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart of Account ID],[Invoice No],[Credited Amount],[Debited Amount],[Voucher No],[Description],[Remarks],[Status],[Branch ID],[Prepared Date],[Prepared Time],[User Account ID],[Computer ID],[Check No],[Category Name],[Pending Invoice],[Ledger Invoice ID 2]) VALUES ('" + DtpLedgerDate.Value + "','" + CmbChartOfAccount.ValueMember + "','" + TxtLedgerNo.Text + "','" + TxtAmount.Text + "','0','" + TxtVoucherNo.Text + "','Cash Collection','" + Me.TxtRemarks.Text + "','CASH','" + FrmHome.lblBranchID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + TxtCheckNo.Text + "','Collection','" + TxtVoucherNo.Text + "','" + TxtLedgerInvoiceNo.Text + "')"

                cmd.ExecuteNonQuery()
                cmd1.ExecuteNonQuery()
                con.Close()

                'Insert Click Msg
                'MsgBox("Data Inserted Successfully", MsgBoxStyle.OkOnly, "Ledger")

                'Show Invoice
                'RptReceitpVoucher.ShowVoucherInvoice()
                'RptReceitpVoucher.Show()

                'Clear Data For Collection And Payment
                ClearDataForCollectionAndPayment()



            End If

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally

        End Try
    End Sub


    Sub insertDataForCollectionWithHeld()
        'Data Insert Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now
        Try

            'Empty Txt Box Can Not Be Save Code
            If Me.CmbChartOfAccount.Text = "" Or Me.CmbPaidBy.Text = "" Or Me.TxtAmount.Text = "" Then
                MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Ledger")

            Else

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd1.Connection = con
                cmd.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart of Account ID],[Invoice No],[Debited Amount],[Credited Amount],[Voucher No],[Remarks],[Description],[Check Issue Date],[Status],[Branch ID],[Prepared Date],[Prepared Time],[User Account ID],[Computer ID],[Check No],[Category Name],[Pending Invoice],[Ledger Invoice ID 2]) VALUES ('" + DtpLedgerDate.Value + "','" + CmbPaidBy.ValueMember + "','" + TxtLedgerNo.Text + "','" + TxtAmount.Text + "','0','" + TxtVoucherNo.Text + "','" + TxtRemarks.Text + "','Collection From " + Me.CmbChartOfAccount.Text + " Check No: " + Me.TxtCheckNo.Text + " ','" + Me.DtpIssueDate.Value + "','Withheld','" + FrmHome.lblBranchID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + TxtCheckNo.Text + "','Collection','" + TxtVoucherNo.Text + "','" + TxtLedgerInvoiceNo.Text + "')    INSERT INTO [Log Details]   ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES('LEDGER COLLECTION','" + LogCategoryStatus + "','Ledger No:" + TxtLedgerNo.Text + ",Voucher Name: " + CmbVoucherName.Text + " , Collection From: " + CmbChartOfAccount.Text + " , Collection By: " + CmbPaidBy.Text + ",  Amount: " + TxtAmount.Text + " , Check No: " + TxtCheckNo.Text + ", Voucher No: " + TxtVoucherNo.Text + " , Remarks: " + TxtRemarks.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtLedgerInvoiceNo.Text + "' )"
                cmd1.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart of Account ID],[Invoice No],[Credited Amount],[Debited Amount],[Voucher No],[Remarks],[Description],[Check Issue Date],[Status],[Branch ID],[Prepared Date],[Prepared Time],[User Account ID],[Computer ID],[Check No],[Category Name],[Pending Invoice],[Ledger Invoice ID 2]) VALUES ('" + DtpLedgerDate.Value + "','" + CmbChartOfAccount.ValueMember + "','" + TxtLedgerNo.Text + "','" + TxtAmount.Text + "','0','" + TxtVoucherNo.Text + "','" + TxtRemarks.Text + "','Check Collection (" + Me.CmbPaidBy.Text + ": " + Me.TxtCheckNo.Text + ") ','" + Me.DtpIssueDate.Value + "','Withheld','" + FrmHome.lblBranchID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + TxtCheckNo.Text + "','Collection','" + TxtVoucherNo.Text + "','" + TxtLedgerInvoiceNo.Text + "')"

                cmd.ExecuteNonQuery()
                cmd1.ExecuteNonQuery()
                con.Close()

                'Insert Click Msg
                'MsgBox("Data Inserted Successfully", MsgBoxStyle.OkOnly, "Ledger")

                'Show Voucher
                'RptReceitpVoucher.ShowVoucherInvoice()
                'RptReceitpVoucher.Show()



                'Clear Data For Collection And Payment
                ClearDataForCollectionAndPayment()


            End If

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally

        End Try
    End Sub


    Sub insertDataForPayment()
        'Data Insert Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now
        Try

            'Empty Txt Box Can Not Be Save Code
            If Me.CmbChartOfAccount.Text = "" Or Me.CmbPaidBy.Text = "" Or Me.TxtAmount.Text = "" Then
                MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Ledger")

            Else

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd1.Connection = con
                cmd.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart of Account ID],[Invoice No],[Debited Amount],[Credited Amount],[Voucher No],[Remarks],[Description],[Status],[Branch ID],[Prepared Date],[Prepared Time],[User Account ID],[Computer ID],[Check No],[Category Name],[Pending Invoice],[Ledger Invoice ID 2]) VALUES ('" + DtpLedgerDate.Value + "','" + CmbChartOfAccount.ValueMember + "','" + TxtLedgerNo.Text + "','" + TxtAmount.Text + "','0','" + TxtVoucherNo.Text + "','" + TxtRemarks.Text + "','Cash Payment','CASH','" + FrmHome.lblBranchID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + TxtCheckNo.Text + "','Payment','" + TxtVoucherNo.Text + "','" + TxtLedgerInvoiceNo.Text + "')     INSERT INTO [Log Details]   ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES('LEDGER PAYMENT','" + LogCategoryStatus + "','Ledger No:" + TxtLedgerNo.Text + ",Voucher Name: " + CmbVoucherName.Text + " , Paid To: " + CmbChartOfAccount.Text + " , Paid By: " + CmbPaidBy.Text + ",  Amount: " + TxtAmount.Text + " , Check No: " + TxtCheckNo.Text + ", Voucher No: " + TxtVoucherNo.Text + " , Remarks: " + TxtRemarks.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtLedgerInvoiceNo.Text + "' )"
                cmd1.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart of Account ID],[Invoice No],[Credited Amount],[Debited Amount],[Voucher No],[Remarks],[Description],[Status],[Branch ID],[Prepared Date],[Prepared Time],[User Account ID],[Computer ID],[Check No],[Category Name],[Pending Invoice],[Ledger Invoice ID 2]) VALUES ('" + DtpLedgerDate.Value + "','" + CmbPaidBy.ValueMember + "','" + TxtLedgerNo.Text + "','" + TxtAmount.Text + "','0','" + TxtVoucherNo.Text + "','" + TxtRemarks.Text + "','Paid to " + Me.CmbChartOfAccount.Text + " ','CASH','" + FrmHome.lblBranchID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + TxtCheckNo.Text + "','Payment','" + TxtVoucherNo.Text + "','" + TxtLedgerInvoiceNo.Text + "')"

                cmd.ExecuteNonQuery()
                cmd1.ExecuteNonQuery()
                con.Close()

                'Insert Click Msg
                ' MsgBox("Data Inserted Successfully", MsgBoxStyle.OkOnly, "LedgerInsertForPayment")

                'Show Voucher
                'RptPaymentVoucher.ShowVoucherInvoice()
                'RptPaymentVoucher.Show()


                'Clear Data For Collection And Payment
                ClearDataForCollectionAndPayment()


            End If

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally

        End Try
    End Sub
    Sub insertDataForPaymentWithHeld()
        'Data Insert Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now
        Try

            'Empty Txt Box Can Not Be Save Code
            If Me.CmbChartOfAccount.Text = "" Or Me.CmbPaidBy.Text = "" Or Me.TxtAmount.Text = "" Then
                MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Ledger")

            Else

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd1.Connection = con
                cmd.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart of Account ID],[Invoice No],[Debited Amount],[Credited Amount],[Voucher No],[Remarks],[Description],[Check Issue Date],[Status],[Branch ID],[Prepared Date],[Prepared Time],[User Account ID],[Computer ID],[Check No],[Category Name],[Pending Invoice],[Ledger Invoice ID 2]) VALUES ('" + DtpLedgerDate.Value + "','" + CmbChartOfAccount.ValueMember + "','" + TxtLedgerNo.Text + "','" + TxtAmount.Text + "','0','" + TxtVoucherNo.Text + "','" + TxtRemarks.Text + "','Check Payment ( " + Me.CmbPaidBy.Text + ": " + Me.TxtCheckNo.Text + ")','" + Me.DtpIssueDate.Value + "','WithHeld','" + FrmHome.lblBranchID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + TxtCheckNo.Text + "','Payment','" + TxtVoucherNo.Text + "','" + TxtLedgerInvoiceNo.Text + "')     INSERT INTO [Log Details]   ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES('LEDGER PAYMENT','" + LogCategoryStatus + "','Ledger No:" + TxtLedgerNo.Text + ",Voucher Name: " + CmbVoucherName.Text + " , Paid To: " + CmbChartOfAccount.Text + " , Paid By: " + CmbPaidBy.Text + ",  Amount: " + TxtAmount.Text + " , Check No: " + TxtCheckNo.Text + ", Voucher No: " + TxtVoucherNo.Text + " , Remarks: " + TxtRemarks.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtLedgerInvoiceNo.Text + "' )"
                cmd1.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart of Account ID],[Invoice No],[Credited Amount],[Debited Amount],[Voucher No],[Remarks],[Description],[Check Issue Date],[Status],[Branch ID],[Prepared Date],[Prepared Time],[User Account ID],[Computer ID],[Check No],[Category Name],[Pending Invoice],[Ledger Invoice ID 2]) VALUES ('" + DtpLedgerDate.Value + "','" + CmbPaidBy.ValueMember + "','" + TxtLedgerNo.Text + "','" + TxtAmount.Text + "','0','" + TxtVoucherNo.Text + "','" + TxtRemarks.Text + "','Paid to " + Me.CmbChartOfAccount.Text + " (Check No:" + Me.TxtCheckNo.Text + ")','" + Me.DtpIssueDate.Value + "','WithHeld','" + FrmHome.lblBranchID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + TxtCheckNo.Text + "','Payment','" + TxtVoucherNo.Text + "','" + TxtLedgerInvoiceNo.Text + "')"

                cmd.ExecuteNonQuery()
                cmd1.ExecuteNonQuery()
                con.Close()

                'Insert Click Msg
                'MsgBox("Data Inserted Successfully", MsgBoxStyle.OkOnly, "LedgerInsertForPayment")

                'Show Voucher
                ' RptPaymentVoucher.ShowVoucherInvoice()
                ' RptPaymentVoucher.Show()




                'Clear Data For Collection And Payment
                ClearDataForCollectionAndPayment()


            End If

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally

        End Try
    End Sub

    Sub InsertDataForExpense()

        'Data Insert Code
        Dim con As New SqlConnection
        Dim con1 As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim cmd3 As New SqlCommand
        Dim Dr As SqlDataReader


        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now


        Try

            'Empty Txt Box Can Not Be Save Code
            If Me.CmbChartOfAccount.Text = "" Or Me.CmbPaidBy.Text = "" Or Me.TxtAmount.Text = "" Then
                MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Ledger")

            Else
                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd2.Connection = con1
                cmd3.Connection = con1
                cmd2.CommandText = "SELECT isnull(sum([Debited Amount]),0)[Total] FROM [Ledger] WHERE MONTH([Ledger Date]) = MONTH('" + currentDate + "') and  [Chart of Account ID]='" + CmbChartOfAccount.ValueMember + "' "
                cmd3.CommandText = "select * from [Chart of Account] where [Chart of Account ID]='" + CmbChartOfAccount.ValueMember + "'"

                Dr = cmd2.ExecuteReader()
                Dr.Read()
                If Dr.HasRows Then
                    TotalExpense = Dr.Item("Total").ToString
                End If
                Dr.Close()

                Dr = cmd3.ExecuteReader
                Dr.Read()
                If Dr.HasRows Then
                    TransactionLimit = Dr.Item("Transaction Limit").ToString
                End If
                Dr.Close()
                con1.Close()

                If (Val(TotalExpense) + Val(TxtAmount.Text)) <= Val(TransactionLimit) Or Val(TransactionLimit) = 0 Then

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd1.Connection = con
                    cmd.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart of Account ID],[Invoice No],[Debited Amount],[Credited Amount],[Voucher No],[Remarks],[Description],[Status],[Branch ID],[Prepared Date],[Prepared Time],[User Account ID],[Computer ID],[Check No],[Category Name],[Ledger Invoice ID 2]) VALUES ('" + DtpLedgerDate.Value + "','" + CmbChartOfAccount.ValueMember + "','" + TxtLedgerNo.Text + "','" + TxtAmount.Text + "','0','" + TxtVoucherNo.Text + "','" + TxtRemarks.Text + "','" + Me.TxtRemarks.Text + "','CASH','" + FrmHome.lblBranchID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + TxtCheckNo.Text + "','Expense','" + TxtLedgerInvoiceNo.Text + "')    INSERT INTO [Log Details]   ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES('LEDGER EXPENSE','" + LogCategoryStatus + "','Ledger No:" + TxtLedgerNo.Text + ",Voucher Name: " + CmbVoucherName.Text + " , Expense Name: " + CmbChartOfAccount.Text + " , Paid By: " + CmbPaidBy.Text + ",  Amount: " + TxtAmount.Text + " , Check No: " + TxtCheckNo.Text + ", Voucher No: " + TxtVoucherNo.Text + " , Remarks: " + TxtRemarks.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtLedgerInvoiceNo.Text + "' )"
                    cmd1.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart of Account ID],[Invoice No],[Credited Amount],[Debited Amount],[Voucher No],[Remarks],[Description],[Status],[Branch ID],[Prepared Date],[Prepared Time],[User Account ID],[Computer ID],[Check No],[Category Name],[Ledger Invoice ID 2]) VALUES ('" + DtpLedgerDate.Value + "','" + CmbPaidBy.ValueMember + "','" + TxtLedgerNo.Text + "','" + TxtAmount.Text + "','0','" + TxtVoucherNo.Text + "','" + TxtRemarks.Text + "','Cash Expense for " + Me.CmbChartOfAccount.Text + " (" + Me.TxtRemarks.Text + ")','CASH','" + FrmHome.lblBranchID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + TxtCheckNo.Text + "','Expense','" + TxtLedgerInvoiceNo.Text + "')"

                    cmd.ExecuteNonQuery()
                    cmd1.ExecuteNonQuery()
                    con.Close()
                    'Insert Click Msg
                    'MsgBox("Data Inserted Successfully", MsgBoxStyle.OkOnly, "LedgerInsertForExpense")


                    'Show Invoice
                    'RptExpenseVoucher.ShowExpenseVoucherInvoice()
                    'RptExpenseVoucher.Show()


                    'Clear Data For Expense and Transfer
                    ClearDataForExpenseAndTransfer()


                Else
                    MsgBox("Transaction limit exceeded.", MsgBoxStyle.Critical, "Ledger")

                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records Ledger Expense")
        Finally

        End Try

    End Sub




    Sub insertDataForTransfer()
        'Data Insert Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now
        Try

            'Empty Txt Box Can Not Be Save Code
            If Me.CmbChartOfAccount.Text = "" Or Me.CmbPaidBy.Text = "" Or Me.TxtAmount.Text = "" Then
                MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Ledger")

            Else

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd1.Connection = con
                If Me.CmbChartOfAccount.Text = "CASH" Then
                    cmd.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart of Account ID],[Invoice No],[Debited Amount],[Credited Amount],[Voucher No],[Remarks],[Description],[Status],[Branch ID],[Prepared Date],[Prepared Time],[User Account ID],[Computer ID],[Check No],[Category Name],[Ledger Invoice ID 2]) VALUES ('" + DtpLedgerDate.Value + "','" + CmbPaidBy.ValueMember + "','" + TxtLedgerNo.Text + "','" + TxtAmount.Text + "','0','" + TxtVoucherNo.Text + "','" + TxtRemarks.Text + "','Transferred from " + Me.CmbChartOfAccount.Text + "','CASH','" + FrmHome.lblBranchID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + TxtCheckNo.Text + "','Transfer','" + TxtLedgerInvoiceNo.Text + "') INSERT INTO [Log Details]   ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES('LEDGER TRANSFER','" + LogCategoryStatus + "','Ledger No:" + TxtLedgerNo.Text + ",Voucher Name: " + CmbVoucherName.Text + " , Transfer From: " + CmbChartOfAccount.Text + " , Transfer To: " + CmbPaidBy.Text + ",  Amount: " + TxtAmount.Text + " , Check No: " + TxtCheckNo.Text + ", Voucher No: " + TxtVoucherNo.Text + " , Remarks: " + TxtRemarks.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtLedgerInvoiceNo.Text + "' )"
                    cmd1.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart of Account ID],[Invoice No],[Credited Amount],[Debited Amount],[Voucher No],[Remarks],[Description],[Status],[Branch ID],[Prepared Date],[Prepared Time],[User Account ID],[Computer ID],[Check No],[Category Name],[Ledger Invoice ID 2]) VALUES ('" + DtpLedgerDate.Value + "','" + CmbChartOfAccount.ValueMember + "','" + TxtLedgerNo.Text + "','" + TxtAmount.Text + "','0','" + TxtVoucherNo.Text + "','" + TxtRemarks.Text + "','Transferred to " + Me.CmbPaidBy.Text + "','CASH','" + FrmHome.lblBranchID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + TxtCheckNo.Text + "','Transfer','" + TxtLedgerInvoiceNo.Text + "')"
                ElseIf Me.CmbPaidBy.Text = "CASH" Then
                    cmd.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart of Account ID],[Invoice No],[Debited Amount],[Credited Amount],[Voucher No],[Remarks],[Description],[Status],[Branch ID],[Prepared Date],[Prepared Time],[User Account ID],[Computer ID],[Check No],[Category Name],[Ledger Invoice ID 2]) VALUES ('" + DtpLedgerDate.Value + "','" + CmbPaidBy.ValueMember + "','" + TxtLedgerNo.Text + "','" + TxtAmount.Text + "','0','" + TxtVoucherNo.Text + "','" + TxtRemarks.Text + "','Transferred from " + Me.CmbChartOfAccount.Text + "','CASH','" + FrmHome.lblBranchID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + TxtCheckNo.Text + "','Transfer','" + TxtLedgerInvoiceNo.Text + "')   INSERT INTO [Log Details]   ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES('LEDGER TRANSFER','" + LogCategoryStatus + "','Ledger No:" + TxtLedgerNo.Text + ",Voucher Name: " + CmbVoucherName.Text + " , Transfer From: " + CmbChartOfAccount.Text + " , Transfer To: " + CmbPaidBy.Text + ",  Amount: " + TxtAmount.Text + " , Check No: " + TxtCheckNo.Text + ", Voucher No: " + TxtVoucherNo.Text + " , Remarks: " + TxtRemarks.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtLedgerInvoiceNo.Text + "' )"
                    cmd1.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart of Account ID],[Invoice No],[Credited Amount],[Debited Amount],[Voucher No],[Remarks],[Description],[Status],[Branch ID],[Prepared Date],[Prepared Time],[User Account ID],[Computer ID],[Check No],[Category Name],[Ledger Invoice ID 2]) VALUES ('" + DtpLedgerDate.Value + "','" + CmbChartOfAccount.ValueMember + "','" + TxtLedgerNo.Text + "','" + TxtAmount.Text + "','0','" + TxtVoucherNo.Text + "','" + TxtRemarks.Text + "','Transferred to " + Me.CmbPaidBy.Text + "','CASH','" + FrmHome.lblBranchID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + TxtCheckNo.Text + "','Transfer','" + TxtLedgerInvoiceNo.Text + "')"
                Else
                    cmd.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart of Account ID],[Invoice No],[Debited Amount],[Credited Amount],[Voucher No],[Remarks],[Description],[Status],[Branch ID],[Prepared Date],[Prepared Time],[User Account ID],[Computer ID],[Check No],[Category Name],[Ledger Invoice ID 2]) VALUES ('" + DtpLedgerDate.Value + "','" + CmbPaidBy.ValueMember + "','" + TxtLedgerNo.Text + "','" + TxtAmount.Text + "','0','" + TxtVoucherNo.Text + "','" + TxtRemarks.Text + "','Transferred from " + Me.CmbChartOfAccount.Text + "','Completed','" + FrmHome.lblBranchID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + TxtCheckNo.Text + "','Transfer','" + TxtLedgerInvoiceNo.Text + "')  INSERT INTO [Log Details]   ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES('LEDGER TRANSFER','" + LogCategoryStatus + "','Ledger No:" + TxtLedgerNo.Text + ",Voucher Name: " + CmbVoucherName.Text + " , Transfer From: " + CmbChartOfAccount.Text + " , Transfer To: " + CmbPaidBy.Text + ",  Amount: " + TxtAmount.Text + " , Check No: " + TxtCheckNo.Text + ", Voucher No: " + TxtVoucherNo.Text + " , Remarks: " + TxtRemarks.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtLedgerInvoiceNo.Text + "' )"
                    cmd1.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart of Account ID],[Invoice No],[Credited Amount],[Debited Amount],[Voucher No],[Remarks],[Description],[Status],[Branch ID],[Prepared Date],[Prepared Time],[User Account ID],[Computer ID],[Check No],[Category Name],[Ledger Invoice ID 2]) VALUES ('" + DtpLedgerDate.Value + "','" + CmbChartOfAccount.ValueMember + "','" + TxtLedgerNo.Text + "','" + TxtAmount.Text + "','0','" + TxtVoucherNo.Text + "','" + TxtRemarks.Text + "','Transferred to " + Me.CmbPaidBy.Text + "','Completed','" + FrmHome.lblBranchID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + TxtCheckNo.Text + "','Transfer','" + TxtLedgerInvoiceNo.Text + "')"

                End If
                cmd.ExecuteNonQuery()
                cmd1.ExecuteNonQuery()

                con.Close()
                'Insert Click Msg
                ' MsgBox("Data Inserted Successfully", MsgBoxStyle.OkOnly, "Ledger")

                'Show Invoice
                'RptTransferVoucher.ShowTransferVoucherInvoice()
                'RptTransferVoucher.Show()

                'Clear Data For Expense and Transfer
                ClearDataForExpenseAndTransfer()


            End If

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally

        End Try
    End Sub





    Private Sub CmbHeadOfAccount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            CmbChartOfAccount.Focus()
        End If
    End Sub

    Private Sub CmbHeadOfAccount_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CmbChartOfAccount_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbChartOfAccount.GotFocus
        GrdVoucherName.Visible = False
        GrdPaidBy.Visible = False
    End Sub

    Private Sub CmbChartOfAccount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbChartOfAccount.KeyDown
        If e.KeyCode = Keys.Down Then

            'Resize Chart of Account Gridview and Make it Visible
            ResizeChartofAccountGridviewandMakeitVisible()


            If Not BtnExpense.ForeColor = Color.Black Then
                'Search Chart of Account for Expense
                SearchChartofAccountForExpense()
            Else

                'Search Voucher Name
                SearchChartofAccount()

            End If


            GrdChartofAccount.Visible = True

            GrdChartofAccount.Focus()
        ElseIf e.KeyCode = Keys.Enter Then

            'Show Chart Of Account to Combobox
            ShowChartOfAccountToCombobox()

            CmbPaidBy.Focus()
        End If
    End Sub

    Private Sub CmbChartOfAccount_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbChartOfAccount.Leave


    End Sub

    Private Sub CmbChartOfAccount_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CmbChartOfAccount.MouseClick
        'Resize Chart of Account Gridview and Make it Visible
        ResizeChartofAccountGridviewandMakeitVisible()


        If Not BtnExpense.ForeColor = Color.Black Then
            'Search Chart of Account for Expense
            SearchChartofAccountForExpense()
        Else

            'Search Voucher Name
            SearchChartofAccount()

        End If
        GrdVoucherName.Visible = False
        GrdPaidBy.Visible = False

    End Sub

    Private Sub CmbChartOfAccount_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CmbChartOfAccount.MouseDoubleClick

    End Sub

   

    Private Sub CmbChartOfAccount_RightToLeftChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbChartOfAccount.RightToLeftChanged

    End Sub

    Private Sub CmbChartOfAccount_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbChartOfAccount.SelectedIndexChanged
        

    End Sub

    Private Sub TxtAmount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtAmount.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtCheckNo.Focus()
        End If
    End Sub

    Private Sub TxtAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtAmount.TextChanged
        
    End Sub

    Private Sub TxtDiscountAmount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            CmbPaidBy.Focus()
        End If
    End Sub

    Private Sub TxtDiscountAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TxtCheckNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCheckNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtVoucherNo.Focus()
        End If
    End Sub

    Private Sub TxtCheckNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCheckNo.TextChanged

    End Sub

    Private Sub CmbPaidBy_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbPaidBy.GotFocus
        GrdVoucherName.Visible = False
        GrdChartofAccount.Visible = False
    End Sub

    Private Sub CmbPaidBy_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbPaidBy.KeyDown
        If e.KeyCode = Keys.Down Then


            'Resize Paid By Gridview and Make it Visible
            ResizePaidByGridviewandMakeitVisible()

            If Not BtnTransfer.ForeColor = Color.Black Then
                'Search Chart of Account To Paid by For Transfer
                SearchChartofAccountToPaidbyForTransfer()
            Else
                'Search Paid By
                SearchPaidBy()

            End If


            GrdPaidBy.Visible = True

            GrdPaidBy.Focus()
        ElseIf e.KeyCode = Keys.Enter Then

            'Show Paid By to Combobox
            ShowPaidByToCombobox()


            TxtAmount.Focus()
        End If
    End Sub

    Private Sub CmbPaidBy_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CmbPaidBy.MouseClick
        'Resize Paid By Gridview and Make it Visible
        ResizePaidByGridviewandMakeitVisible()

        If Not BtnTransfer.ForeColor = Color.Black Then
            'Search Chart of Account To Paid by For Transfer
            SearchChartofAccountToPaidbyForTransfer()
        Else
            'Search Paid By
            SearchPaidBy()

        End If


        GrdVoucherName.Visible = False
        GrdChartofAccount.Visible = False
    End Sub

    Private Sub CmbPaidBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbPaidBy.SelectedIndexChanged

    End Sub

    Private Sub BtnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        'Save invoice
        FinalSaveInvoice()
    End Sub
    Sub FinalSaveInvoice()


        If Not TxtLedgerInvoiceNo.Text = "" Then

            If Not Me.TxtLedgerNo.Text = "" Then
                MsgBox("Please complete this list.", MsgBoxStyle.Critical, "Ledger")

            ElseIf Me.TxtLedgerNo.Text = "" And GrdLedger.Rows.Count = 0 Then

                'Add Item And Save In One Click
                BtnAddItem.PerformClick()

                
                'Save Invoice And Show Report
                SaveInvoiceAndShowReport()



            ElseIf CmbVoucherName.Text = "" Or CmbVoucherName.ValueMember = "" Or CmbChartOfAccount.Text = "" Or CmbChartOfAccount.ValueMember = "" Or CmbPaidBy.Text = "" Or CmbPaidBy.ValueMember = "" Or TxtAmount.Text = "" Or GrdLedger.RowCount > 0 Then

                'Save Invoice And Show Report
                SaveInvoiceAndShowReport()


            Else

                MsgBox("Please complete this list.", MsgBoxStyle.Critical, "Ledger")
            End If

        End If

    End Sub

    'Save Invoice And Show Report
    Sub SaveInvoiceAndShowReport()

        Try

            Dim q As MsgBoxResult
            q = MsgBox("Are you really want to save this Invoice?", MsgBoxStyle.YesNo, "Bizpro")

            If q = MsgBoxResult.Yes Then

                'Update for 2nd Invoice Number To Make It Complete
                UpdateLedgerInvoiceNo2ToMakeItComplete()

                If Not Me.BtnCollection.ForeColor = Color.Black Then


                    '  Dim qs As MsgBoxResult
                    ' qs = MsgBox("Do you really want to Send Sms?", MsgBoxStyle.YesNo, "SMS")
                    'If qs = MsgBoxResult.Yes Then

                    'Sub for show dues or advanced or Greeting
                    SendSMS()

                    'End If

                    RptReceitpVoucher.InvoiceNo = TxtLedgerInvoiceNo.Text

                    'Show Invoice
                    RptReceitpVoucher.ShowVoucherInvoice()
                    RptReceitpVoucher.Show()

                ElseIf Not Me.BtnPayment.ForeColor = Color.Black Then
                    RptPaymentVoucher.InvoiceNo = TxtLedgerInvoiceNo.Text


                    'Show Voucher
                    RptPaymentVoucher.ShowVoucherInvoice()
                    RptPaymentVoucher.Show()

                ElseIf Not Me.BtnExpense.ForeColor = Color.Black Then

                    RptExpenseVoucher.InvoiceNo = TxtLedgerInvoiceNo.Text


                    'Show Invoice
                    RptExpenseVoucher.ShowExpenseVoucherInvoice()
                    RptExpenseVoucher.Show()


                ElseIf Not Me.BtnTransfer.ForeColor = Color.Black Then
                    RptTransferVoucher.InvoiceNo = TxtLedgerInvoiceNo.Text


                    'Show Invoice
                    RptTransferVoucher.ShowTransferVoucherInvoice()
                    RptTransferVoucher.Show()


                End If


                'Refresh Data
                RefreshData()


                'Clear All Data
                clearAllData()





            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Search 1st Balance
    Sub Search1stBalance()
        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader




            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "select (isnull(sum([debited amount]),0)- isnull(sum([Credited Amount]),0))[Balance] from ledger join [Chart of Account] on Ledger.[Chart Of Account ID]=[Chart of Account].[Chart of Account ID] where not  [Ledger].[Status]= 'WithHeld' And Ledger.[Chart Of Account ID]= [Chart of Account].[Chart of Account ID] and Ledger.[Chart Of Account ID]= '" + CmbChartOfAccount.ValueMember + "'"

            dr = cmd.ExecuteReader
            dr.Read()

            If dr.HasRows Then

                LblBalance1.Text = Double.Parse((dr.Item("Balance").ToString)).ToString()
            End If
            dr.Close()
            con.Close()

            If Val(LblBalance1.Text) >= 0 Then
                LblBalance1Lbl.ForeColor = Color.Green

            Else
                LblBalance1Lbl.ForeColor = Color.Red
            End If




        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try

    End Sub
    'Search 2nd Balance
    Sub Search2ndBalance()
        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader




            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "select (isnull(sum([debited amount]),0)- isnull(sum([Credited Amount]),0))[Balance] from ledger join [Chart of Account] on Ledger.[Chart Of Account ID]=[Chart of Account].[Chart of Account ID] where not  [Ledger].[Status]= 'WithHeld' And Ledger.[Chart Of Account ID]= [Chart of Account].[Chart of Account ID] and Ledger.[Chart Of Account ID]= '" + CmbPaidBy.ValueMember + "'"

            dr = cmd.ExecuteReader
            dr.Read()

            If dr.HasRows Then

                LblBalance2.Text = Double.Parse((dr.Item("Balance").ToString)).ToString()
            End If
            dr.Close()
            con.Close()

            If Val(LblBalance2.Text) >= 0 Then
                LblBalance2Lbl.ForeColor = Color.Green

            Else
                LblBalance2Lbl.ForeColor = Color.Red
            End If

        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub


    'Insert into Ledger Invoice For Per Transaction
    Sub InsertIntoLedgerInvoiceForPerTransaction()

        'Insert Into Sale Invoice code
        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now



            If TxtLedgerNo.Text = "" Then

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "INSERT INTO [Ledger Invoice] ([User Account ID],[Computer ID],[Prepared Date],[Prepared Time]) values ('" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "')"
                cmd.ExecuteNonQuery()
                con.Close()


                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "SELECT top 1 [Ledger Invoice ID] FROM [Ledger Invoice] where [User Account ID]= '" + FrmHome.LblUserID.Text + "'  order by [Ledger Invoice ID] desc"

                dr = cmd.ExecuteReader()
                dr.Read()
                If dr.HasRows Then


                    TxtLedgerNo.Text = (dr.Item("Ledger Invoice ID").ToString)
                End If
                con.Close()
                dr.Close()

            End If

        Catch ex As Exception
            MessageBox.Show("Error while Inserting to sale invoice record on table..." & ex.Message, "Insert Ledger Invoice")
        Finally

        End Try



    End Sub



    'Insert or  Update for 2nd Invoice Number For An Invoice
    Sub InsertOrUpdateIntoLedgerInvoiceNo2ForAnInvoice()

        'Insert Into Sale Invoice code
        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now



            If TxtLedgerInvoiceNo.Text = "" Then

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "INSERT INTO [Ledger Invoice 2] ([User Account ID],[Computer ID],[Prepared Date],[Prepared Time],[Ledger Date],[Status],[Branch ID],[Chart of Account ID]) values ('" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + DtpLedgerDate.Value + "','INCOMPLETE','" + FrmHome.lblBranchID.Text + "','" + CmbVoucherName.ValueMember + "')"
                cmd.ExecuteNonQuery()
                con.Close()


                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "SELECT top 1 [Ledger Invoice ID 2] FROM [Ledger Invoice 2] where [User Account ID]= '" + FrmHome.LblUserID.Text + "'  order by [Ledger Invoice ID 2] desc"

                dr = cmd.ExecuteReader()
                dr.Read()
                If dr.HasRows Then

                    TxtLedgerInvoiceNo.Text = (dr.Item("Ledger Invoice ID 2").ToString)
                End If

                con.Close()
                dr.Close()

            ElseIf Not TxtLedgerInvoiceNo.Text = "" Then

                If Not CmbVoucherName.Text = "" Or CmbVoucherName.ValueMember = "" Then
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "Update [Ledger Invoice 2] Set [Status]='INCOMPLETE',[Chart of Account ID]='" + CmbVoucherName.ValueMember + "' Where [Ledger Invoice ID 2]='" + TxtLedgerInvoiceNo.Text + "'"
                    cmd.ExecuteNonQuery()
                    con.Close()



                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error while Inserting to sale invoice record on table..." & ex.Message, "Insert Ledger Invoice 2")
        Finally

        End Try



    End Sub

    'Update for 2nd Invoice Number To Make It Complete
    Sub UpdateLedgerInvoiceNo2ToMakeItComplete()


        'Insert Into Sale Invoice code
        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now



            If Not TxtLedgerInvoiceNo.Text = "" Then

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = " UPDATE [Ledger Invoice 2] SET [Ledger Date]='" + DtpLedgerDate.Value + "' ,[Status]='COMPLETE' Where [Ledger Invoice ID 2]='" + TxtLedgerInvoiceNo.Text + "' "
                cmd.ExecuteNonQuery()
                con.Close()

            End If

        Catch ex As Exception
            MessageBox.Show("Error while Inserting to sale invoice record on table..." & ex.Message, "Insert Ledger Invoice 2")
        Finally

        End Try



    End Sub



    Sub DeleteForUpdate()

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now
        Dim BtnName As String


        If Not Me.BtnCollection.ForeColor = Color.Black Then
            BtnName = BtnCollection.Text
        ElseIf Not Me.BtnPayment.ForeColor = Color.Black Then
            BtnName = BtnPayment.Text
        ElseIf Not Me.BtnExpense.ForeColor = Color.Black Then
            BtnName = BtnExpense.Text
        ElseIf Not Me.BtnTransfer.ForeColor = Color.Black Then
            BtnName = BtnTransfer.Text
        End If


        Try

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con

            cmd.CommandText = "Delete from [Ledger] where [Invoice No]= '" + TxtLedgerNo.Text + "' and [Category Name]= '" + BtnName.ToString + "'"
            cmd.ExecuteNonQuery()
            con.Close()
            Me.TxtLedgerNo.Text = ""


        Catch ex As Exception
            MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Records for Update")
        Finally





        End Try

    End Sub

    
    Sub UpdateDataForCollectionAndTransfer()

        'Data Insert Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now
        Try

            'Empty Txt Box Can Not Be Save Code
            If Me.CmbChartOfAccount.Text = "" Or Me.CmbPaidBy.Text = "" Or Me.TxtAmount.Text = "" Then
                MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Ledger")

            Else

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd1.Connection = con

                If Me.CmbChartOfAccount.Text = "CASH" Then
                    cmd.CommandText = "update Ledger set [Ledger Date]='" + Me.DtpLedgerDate.Value + "', [Voucher No] ='" + Me.TxtVoucherNo.Text + "' , [Check No]='" + TxtCheckNo.Text + "' , [Chart of Account ID]='" + Me.CmbPaidBy.ValueMember + "', [Status]='CASH', [Debited Amount]='" + Me.TxtAmount.Text + "' where [Credited Amount]= 0 and [Invoice No]='" + TxtLedgerNo.Text + "'"
                    cmd1.CommandText = "update Ledger set [Ledger Date]='" + Me.DtpLedgerDate.Value + "' , [Voucher No] ='" + Me.TxtVoucherNo.Text + "' , [Check No]='" + TxtCheckNo.Text + "' , [Chart of Account ID]='" + Me.CmbChartOfAccount.ValueMember + "', [Status]='CASH', [Credited Amount]='" + Me.TxtAmount.Text + "' where [Debited Amount]= 0 and [Invoice No]='" + TxtLedgerNo.Text + "'"

                ElseIf Me.CmbPaidBy.Text = "CASH" Then
                    cmd.CommandText = "update Ledger set [Ledger Date]='" + Me.DtpLedgerDate.Value + "', [Voucher No] ='" + Me.TxtVoucherNo.Text + "' , [Check No]='" + TxtCheckNo.Text + "' , [Chart of Account ID]='" + Me.CmbPaidBy.ValueMember + "', [Status]='CASH', [Debited Amount]='" + Me.TxtAmount.Text + "' where [Credited Amount]= 0 and [Invoice No]='" + TxtLedgerNo.Text + "'"
                    cmd1.CommandText = "update Ledger set [Ledger Date]='" + Me.DtpLedgerDate.Value + "' , [Voucher No] ='" + Me.TxtVoucherNo.Text + "' , [Check No]='" + TxtCheckNo.Text + "' , [Chart of Account ID]='" + Me.CmbChartOfAccount.ValueMember + "', [Status]='CASH', [Credited Amount]='" + Me.TxtAmount.Text + "' where [Debited Amount]= 0 and [Invoice No]='" + TxtLedgerNo.Text + "'"
                Else

                    cmd.CommandText = "update Ledger set [Ledger Date]='" + Me.DtpLedgerDate.Value + "', [Voucher No] ='" + Me.TxtVoucherNo.Text + "' , [Check No]='" + TxtCheckNo.Text + "' , [Chart of Account ID]='" + Me.CmbPaidBy.ValueMember + "', [Debited Amount]='" + Me.TxtAmount.Text + "' where [Credited Amount]= 0 and [Invoice No]='" + TxtLedgerNo.Text + "'"
                    cmd1.CommandText = "update Ledger set [Ledger Date]='" + Me.DtpLedgerDate.Value + "' , [Voucher No] ='" + Me.TxtVoucherNo.Text + "' , [Check No]='" + TxtCheckNo.Text + "' , [Chart of Account ID]='" + Me.CmbChartOfAccount.ValueMember + "', [Credited Amount]='" + Me.TxtAmount.Text + "' where [Debited Amount]= 0 and [Invoice No]='" + TxtLedgerNo.Text + "'"

                End If

                cmd.ExecuteNonQuery()
                cmd1.ExecuteNonQuery()
                con.Close()
                'Insert Click Msg
                MsgBox("Data Inserted Successfully", MsgBoxStyle.OkOnly, "UpdateCollection")
                'Making Clear
                clearData()

                RefreshData()

            End If

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally


        End Try
    End Sub

    Sub UpdateDataForPaymentAndExpense()

        'Data Insert Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now
        Try

            'Empty Txt Box Can Not Be Save Code
            If Me.CmbChartOfAccount.Text = "" Or Me.CmbPaidBy.Text = "" Or Me.TxtAmount.Text = "" Then
                MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Ledger")

            Else

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd1.Connection = con

                If Me.CmbChartOfAccount.Text = "CASH" Then

                    cmd.CommandText = "update Ledger set [Ledger Date]='" + Me.DtpLedgerDate.Value + "', [Voucher No] ='" + Me.TxtVoucherNo.Text + "' , [Check No]='" + TxtCheckNo.Text + "' , [Chart of Account ID]='" + Me.CmbChartOfAccount.ValueMember + "', [Status]='Completed', [Debited Amount]='" + Me.TxtAmount.Text + "' where [Credited Amount]= 0 and [Invoice No]='" + TxtLedgerNo.Text + "'"
                    cmd1.CommandText = "update Ledger set [Ledger Date]='" + Me.DtpLedgerDate.Value + "' , [Voucher No] ='" + Me.TxtVoucherNo.Text + "' , [Check No]='" + TxtCheckNo.Text + "' , [Chart of Account ID]='" + Me.CmbPaidBy.ValueMember + "', [Status]='CASH', [Credited Amount]='" + Me.TxtAmount.Text + "' where [Debited Amount]= 0 and [Invoice No]='" + TxtLedgerNo.Text + "'"

                ElseIf Me.CmbChartOfAccount.Text = "CASH" Then
                    cmd.CommandText = "update Ledger set [Ledger Date]='" + Me.DtpLedgerDate.Value + "', [Voucher No] ='" + Me.TxtVoucherNo.Text + "' , [Check No]='" + TxtCheckNo.Text + "' , [Chart of Account ID]='" + Me.CmbChartOfAccount.ValueMember + "', [Status]='CASH', [Debited Amount]='" + Me.TxtAmount.Text + "' where [Credited Amount]= 0 and [Invoice No]='" + TxtLedgerNo.Text + "'"
                    cmd1.CommandText = "update Ledger set [Ledger Date]='" + Me.DtpLedgerDate.Value + "' , [Voucher No] ='" + Me.TxtVoucherNo.Text + "' , [Check No]='" + TxtCheckNo.Text + "' , [Chart of Account ID]='" + Me.CmbPaidBy.ValueMember + "', [Status]='Completed', [Credited Amount]='" + Me.TxtAmount.Text + "' where [Debited Amount]= 0 and [Invoice No]='" + TxtLedgerNo.Text + "'"

                Else
                    cmd.CommandText = "update Ledger set [Ledger Date]='" + Me.DtpLedgerDate.Value + "', [Voucher No] ='" + Me.TxtVoucherNo.Text + "' , [Check No]='" + TxtCheckNo.Text + "' , [Chart of Account ID]='" + Me.CmbChartOfAccount.ValueMember + "', [Debited Amount]='" + Me.TxtAmount.Text + "' where [Credited Amount]= 0 and [Invoice No]='" + TxtLedgerNo.Text + "'"
                    cmd1.CommandText = "update Ledger set [Ledger Date]='" + Me.DtpLedgerDate.Value + "' , [Voucher No] ='" + Me.TxtVoucherNo.Text + "' , [Check No]='" + TxtCheckNo.Text + "' , [Chart of Account ID]='" + Me.CmbPaidBy.ValueMember + "', [Credited Amount]='" + Me.TxtAmount.Text + "' where [Debited Amount]= 0 and [Invoice No]='" + TxtLedgerNo.Text + "'"


                End If



                cmd.ExecuteNonQuery()
                cmd1.ExecuteNonQuery()
                con.Close()
                'Insert Click Msg
                MsgBox("Data Inserted Successfully", MsgBoxStyle.OkOnly, "UpdateCollection")
                'Making Clear
                clearData()

                RefreshData()


            End If

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally

        End Try
    End Sub


    Private Sub BtnExpense_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExpense.Click

        'permission for update and Delete
        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand
            Dim dr As SqlDataReader
            Dim dr1 As SqlDataReader

            Dim CashChartID As Integer
            Dim CashChartName As String





            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd1.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + FrmHome.LblUserID.Text + "' AND [Category Name] = 'Ledger Expense' And  [Update Delete Permission]='Yes'"
            cmd1.CommandText = "select [Chart of Account].[Chart of Account ID],[Chart of Account].[Account Name] from [Chart of Account] join [Head of Account] on [Chart of Account].[Head of Account ID]=[Head of Account].[Head Of Account ID] where  [Chart of Account].[Account Name]='Cash'"

            dr1 = cmd1.ExecuteReader()
            dr1.Read()
            If dr1.HasRows Then
                CashChartID = dr1.Item("Chart of Account ID").ToString
                CashChartName = dr1.Item("Account Name").ToString
            End If
            dr1.Close()



            dr = cmd.ExecuteReader()
            dr.Read()

            If Not TxtLedgerInvoiceNo.Text = "" And Not BtnCollection.ForeColor = Color.Black And Not GrdLedger.RowCount = 0 Or Not TxtLedgerInvoiceNo.Text = "" And Not BtnPayment.ForeColor = Color.Black And Not GrdLedger.RowCount = 0 Or Not TxtLedgerInvoiceNo.Text = "" And Not BtnExpense.ForeColor = Color.Black And Not GrdLedger.RowCount = 0 Or Not TxtLedgerInvoiceNo.Text = "" And Not BtnTransfer.ForeColor = Color.Black And Not GrdLedger.RowCount = 0 Or Not GrdLedger.RowCount = 0 Then
                MsgBox("Please complete this voucher first.", MsgBoxStyle.Critical, "Ledger")

                'Clear Data
                clearData()
            Else


                If dr.HasRows Then

                    'Clear Data
                    clearData()

                    CmbPaidBy.Text = CashChartName
                    CmbPaidBy.ValueMember = CashChartID

                    BtnCollection.ForeColor = Color.Black
                    BtnPayment.ForeColor = Color.Black
                    BtnExpense.ForeColor = Color.Red
                    BtnTransfer.ForeColor = Color.Black

                    LblChartOfAccount.Text = "Expense Name:"
                    LblPaidBy.Text = "Expense By:"


                    GrpLedger.Enabled = True


                   

                    Me.CmbChartOfAccount.Focus()

                    'Search 2nd Balance
                    Search2ndBalance()


                    'Insert or  Update for 2nd Invoice Number For An Invoice
                    InsertOrUpdateIntoLedgerInvoiceNo2ForAnInvoice()

                    'Focus on Voucher Name
                    CmbVoucherName.Focus()

                ElseIf Not dr.HasRows Then

                    Me.BtnCollection.ForeColor = Color.Black
                    Me.BtnPayment.ForeColor = Color.Black
                    Me.BtnExpense.ForeColor = Color.Black
                    Me.BtnTransfer.ForeColor = Color.Black
                    Me.GrpLedger.Enabled = False

                End If
            End If
            dr.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while  permission delete to form..." & ex.Message, "Form Load")

        End Try



    End Sub

    Private Sub BtnTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTransfer.Click


        'permission for update and Delete
        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader





            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + FrmHome.LblUserID.Text + "' AND [Category Name] = 'Ledger Transfer' And  [Update Delete Permission]='Yes'"


            dr = cmd.ExecuteReader()
            dr.Read()


            If Not TxtLedgerInvoiceNo.Text = "" And Not BtnCollection.ForeColor = Color.Black And Not GrdLedger.RowCount = 0 Or Not TxtLedgerInvoiceNo.Text = "" And Not BtnPayment.ForeColor = Color.Black And Not GrdLedger.RowCount = 0 Or Not TxtLedgerInvoiceNo.Text = "" And Not BtnExpense.ForeColor = Color.Black And Not GrdLedger.RowCount = 0 Or Not TxtLedgerInvoiceNo.Text = "" And Not BtnTransfer.ForeColor = Color.Black And Not GrdLedger.RowCount = 0 Or Not GrdLedger.RowCount = 0 Then
                MsgBox("Please complete this voucher first.", MsgBoxStyle.Critical, "Ledger")

                'Clear Data
                clearData()
            Else

                If dr.HasRows Then

                    'Clear Data
                    clearData()

                    Me.GrpLedger.Enabled = True


                    BtnCollection.ForeColor = Color.Black
                    BtnPayment.ForeColor = Color.Black
                    BtnExpense.ForeColor = Color.Black
                    BtnTransfer.ForeColor = Color.Green

                    LblChartOfAccount.Text = "Transfer From:"
                    LblPaidBy.Text = "Transfer To:"






                    'Insert or  Update for 2nd Invoice Number For An Invoice
                    InsertOrUpdateIntoLedgerInvoiceNo2ForAnInvoice()

                    'Focus on Voucher Name
                    CmbVoucherName.Focus()

                ElseIf Not dr.HasRows Then

                    Me.BtnCollection.ForeColor = Color.Black
                    Me.BtnPayment.ForeColor = Color.Black
                    Me.BtnExpense.ForeColor = Color.Black
                    Me.BtnTransfer.ForeColor = Color.Black
                    Me.GrpLedger.Enabled = False


                End If
            End If
            dr.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while  permission delete to form..." & ex.Message, "Form Load")

        End Try







    End Sub


    Private Sub cmbSearchName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub RefreshData()


        ' Load Data
        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "WITH RankedData AS (SELECT *, RN = ROW_NUMBER() OVER(PARTITION BY [invoice No], [Category Name] ORDER BY [invoice No],[Category Name]) FROM Ledger where [Branch ID]='" + FrmHome.lblBranchID.Text + "' and [ledger invoice id 2]='" + TxtLedgerInvoiceNo.Text + "') SELECT [ledger invoice id 2][Invoice No],[Invoice No][Ledger No], [Ledger Date],[Category Name], [Value+] = MAX(CASE WHEN RN = 1 THEN [Chart of Account]. [Account Name] ELSE '' END), [Value-] = MAX(CASE WHEN RN = 2 THEN [Chart of Account]. [Account Name] ELSE '' END),[Voucher No],[Check No],Remarks,sum([Debited Amount])[Amount], [Check Issue Date] FROM RankedData join [Chart of Account] on RankedData.[Chart Of Account ID]=[Chart of Account].[Chart of Account ID] where   RankedData.[Category Name]='Collection' or RankedData.[Category Name]='Payment' or RankedData.[Category Name]='Expense' or RankedData.[Category Name]='Transfer'  GROUP BY [ledger invoice id 2],[Invoice No],[Voucher No],[Check No],Remarks,[Ledger Date],[category Name], [Check Issue Date] order by RankedData.[ledger Date]  desc, RankedData.[Invoice No] desc"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Ledger")
            connection.Close()
            GrdLedger.DataSource = ds
            GrdLedger.DataMember = "BizPro_Ledger"

            'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdLedger.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            con.Close()

            'Me.DtpLedgerDate.Value = Now

            'Search 1st Balance
            Search1stBalance()

            'Search 2nd Balance
            Search2ndBalance()



            Dim total As String = 0
            For i As Integer = 0 To GrdLedger.RowCount - 1
                total += GrdLedger.Rows(i).Cells(9).Value

            Next

            TotalAmount = total



        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try

        'End Refresh Data


    End Sub

    'Refresh Data For Show Pending Sale Bills
    Sub RefreshDataForShowPendingSaleBills()


        ' Load Data
        Try


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select [Pending Invoice], ((isnull(sum([Debited Amount]),0) - isnull(sum([Credited Amount]),0))) [Dues Amount]  from Ledger where  [Category Name]='Sale' and not [Pending Invoice]='' and [Chart of account ID]='" + CmbChartOfAccount.ValueMember + "'  or  [Category Name]='Sale Return' and not [Pending Invoice]='' and [Chart of account ID]='" + CmbChartOfAccount.ValueMember + "'   or [Category Name]='Cash Sale' and not [Pending Invoice]='' and [Chart of account ID]='" + CmbChartOfAccount.ValueMember + "'      or [Category Name]='Cash Sale Return' and not [Pending Invoice]='' and [Chart of account ID]='" + CmbChartOfAccount.ValueMember + "'        or [Category Name]='Collection' and not [Pending Invoice]='' and [Chart of account ID]='" + CmbChartOfAccount.ValueMember + "' and not [Status]='Withheld'	    group by [Pending Invoice] Having isnull(sum([Debited Amount]),0) - isnull(sum([Credited Amount]),0)>0"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Ledger")
            connection.Close()
            GrdShowDueBills.DataSource = ds
            GrdShowDueBills.DataMember = "BizPro_Ledger"

            'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdShowDueBills.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells


            'Me.DtpLedgerDate.Value = Now


        Catch ex As Exception
            'MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try

        'End Refresh Data


    End Sub

    'Refresh Data For Show Pending Purchase Bills
    Sub RefreshDataForShowPendingPurchaseBills()


        ' Load Data
        Try


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select [Pending Invoice], ((isnull(sum([Debited Amount]),0) - isnull(sum([Credited Amount]),0))* -1) [Dues Amount]  from Ledger where  [Category Name]='Purchase' and not [Pending Invoice]='' and [Chart of account ID]='" + CmbChartOfAccount.ValueMember + "'  or  [Category Name]='Purchase Return' and not [Pending Invoice]='' and [Chart of account ID]='" + CmbChartOfAccount.ValueMember + "'   or [Category Name]='Cash Purchase' and not [Pending Invoice]='' and [Chart of account ID]='" + CmbChartOfAccount.ValueMember + "'      or [Category Name]='Cash Purchase Return' and not [Pending Invoice]='' and [Chart of account ID]='" + CmbChartOfAccount.ValueMember + "'        or [Category Name]='Payment' and not [Pending Invoice]='' and [Chart of account ID]='" + CmbChartOfAccount.ValueMember + "' and not [Status]='Withheld'	    group by [Pending Invoice] Having isnull(sum([Debited Amount]),0) - isnull(sum([Credited Amount]),0)<0"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Ledger")
            connection.Close()
            GrdShowDueBills.DataSource = ds
            GrdShowDueBills.DataMember = "BizPro_Ledger"

            'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
            GrdShowDueBills.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells




            'Me.DtpLedgerDate.Value = Now


        Catch ex As Exception
            'MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try

        'End Refresh Data


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'Clear Data
        clearData()

        RefreshData()
    End Sub

    Private Sub GrdLedger_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdLedger.CellContentClick

    End Sub

    Private Sub GrdLedger_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdLedger.CellMouseClick
        'Grid View Codes
        Try

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.GrdLedger.Rows(e.RowIndex)









                If row.Cells("Category Name").Value.ToString = "Collection" Then

                    BtnCollection.ForeColor = Color.Blue
                    BtnPayment.ForeColor = Color.Black
                    BtnExpense.ForeColor = Color.Black
                    BtnTransfer.ForeColor = Color.Black

                    LblChartOfAccount.Text = "Received From:"
                    LblPaidBy.Text = "Received By:"


                    GrpLedger.Enabled = True

                    'Clear Data
                    clearData()

                ElseIf row.Cells("Category Name").Value.ToString = "Payment" Then

                    'Clear Data
                    clearData()

                    BtnCollection.ForeColor = Color.Black
                    BtnPayment.ForeColor = Color.Red
                    BtnExpense.ForeColor = Color.Black
                    BtnTransfer.ForeColor = Color.Black

                    LblChartOfAccount.Text = "Paid To:"
                    LblPaidBy.Text = "Paid By:"


                    GrpLedger.Enabled = True

                    



                    

                ElseIf row.Cells("Category Name").Value.ToString = "Expense" Then
                    'Clear Data
                    clearData()

                    Me.CmbPaidBy.Text = "CASH"
                    BtnCollection.ForeColor = Color.Black
                    BtnPayment.ForeColor = Color.Black
                    BtnExpense.ForeColor = Color.Red
                    BtnTransfer.ForeColor = Color.Black

                    LblChartOfAccount.Text = "Expense Name:"
                    LblPaidBy.Text = "Expense By:"


                    GrpLedger.Enabled = True


                   


                    Me.CmbChartOfAccount.Focus()

                    'Search 2nd Balance
                    Search2ndBalance()


                   

                ElseIf row.Cells("Category Name").Value.ToString = "Transfer" Then

                    'Clear Data
                    clearData()

                    Me.GrpLedger.Enabled = True


                    BtnCollection.ForeColor = Color.Black
                    BtnPayment.ForeColor = Color.Black
                    BtnExpense.ForeColor = Color.Black
                    BtnTransfer.ForeColor = Color.Green

                    LblChartOfAccount.Text = "Transfer From:"
                    LblPaidBy.Text = "Transfer To:"




                End If



                TxtVoucherNo.Text = row.Cells("Voucher No").Value.ToString
                TxtLedgerNo.Text = row.Cells("Ledger No").Value.ToString
                TxtLedgerInvoiceNo.Text = row.Cells("Invoice No").Value.ToString
                TxtAmount.Text = Double.Parse(row.Cells("Amount").Value.ToString).ToString
                TxtCheckNo.Text = row.Cells("Check No").Value.ToString
                TxtRemarks.Text = row.Cells("Remarks").Value.ToString
                DtpLedgerDate.Value = row.Cells("Ledger Date").Value.ToString



                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim dr As SqlDataReader

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.Connection = con
                cmd.CommandText = "SELECT  [Chart of Account].[Account Name],[Chart of Account].[Chart of Account ID] FROM [Ledger Invoice 2] join [Chart of Account] on [Ledger Invoice 2].[Chart of Account ID]=[Chart of Account].[Chart of Account ID] WHERE [Ledger Invoice ID 2] = " + Me.TxtLedgerInvoiceNo.Text + " "

                dr = cmd.ExecuteReader
                dr.Read()


                If dr.HasRows Then
                    CmbVoucherName.Text = dr.Item("Account Name").ToString
                    CmbVoucherName.ValueMember = dr.Item("Chart of Account ID").ToString

                End If
                dr.Close()
                con.Close()


                'Show chart of account name and paid by to combobox
                If row.Cells("Category Name").Value.ToString = "Collection" Then


                   
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.Connection = con
                    cmd.CommandText = "WITH RankedData AS (SELECT *, RN = ROW_NUMBER() OVER(PARTITION BY [invoice No], [Category Name] ORDER BY [invoice No],[Category Name]) FROM Ledger where [Branch ID]='" + FrmHome.lblBranchID.Text + "' and [ledger invoice id 2]='" + TxtLedgerInvoiceNo.Text + "' and [Invoice No]='" + TxtLedgerNo.Text + "')  SELECT [ledger invoice id 2][Invoice No],[Invoice No][Ledger No], [Ledger Date],[Category Name], [Value+ID] = MAX(CASE WHEN RN = 1 THEN [Chart of Account]. [Chart of Account ID] ELSE '' END), [Value+] = MAX(CASE WHEN RN = 1 THEN [Chart of Account]. [Account Name] ELSE '' END), [Value-ID] = MAX(CASE WHEN RN = 2 THEN [Chart of Account].[Chart of Account ID] ELSE '' END), [Value-] = MAX(CASE WHEN RN = 2 THEN [Chart of Account]. [Account Name] ELSE '' END),[Voucher No],[Check No],Remarks,sum([Debited Amount])[Amount], [Check Issue Date] FROM RankedData join [Chart of Account] on RankedData.[Chart Of Account ID]=[Chart of Account].[Chart of Account ID] where   RankedData.[Category Name]='Collection' or RankedData.[Category Name]='Payment' or RankedData.[Category Name]='Expense' or RankedData.[Category Name]='Transfer'  GROUP BY [ledger invoice id 2],[Invoice No],[Voucher No],[Check No],Remarks,[Ledger Date],[category Name], [Check Issue Date] order by RankedData.[ledger Date]  desc, RankedData.[Invoice No] desc"

                    dr = cmd.ExecuteReader
                    dr.Read()


                    If dr.HasRows Then
                        CmbChartOfAccount.ValueMember = dr.Item("Value-ID").ToString
                        CmbPaidBy.ValueMember = dr.Item("Value+ID").ToString

                    End If
                    dr.Close()
                    con.Close()


                    CmbChartOfAccount.Text = row.Cells("Value-").Value.ToString
                    CmbPaidBy.Text = row.Cells("Value+").Value.ToString

                    'Invisible all gridview as combobx
                    GrdVoucherName.Hide()
                    GrdChartofAccount.Hide()
                    GrdPaidBy.Hide()


                    'Refresh Data For Show Pending Sale Bills
                    RefreshDataForShowPendingSaleBills()

                ElseIf row.Cells("Category Name").Value.ToString = "Payment" Then

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.Connection = con
                    cmd.CommandText = "WITH RankedData AS (SELECT *, RN = ROW_NUMBER() OVER(PARTITION BY [invoice No], [Category Name] ORDER BY [invoice No],[Category Name]) FROM Ledger where [Branch ID]='" + FrmHome.lblBranchID.Text + "' and [ledger invoice id 2]='" + TxtLedgerInvoiceNo.Text + "' and [Invoice No]='" + TxtLedgerNo.Text + "')  SELECT [ledger invoice id 2][Invoice No],[Invoice No][Ledger No], [Ledger Date],[Category Name], [Value+ID] = MAX(CASE WHEN RN = 1 THEN [Chart of Account]. [Chart of Account ID] ELSE '' END), [Value+] = MAX(CASE WHEN RN = 1 THEN [Chart of Account]. [Account Name] ELSE '' END), [Value-ID] = MAX(CASE WHEN RN = 2 THEN [Chart of Account].[Chart of Account ID] ELSE '' END), [Value-] = MAX(CASE WHEN RN = 2 THEN [Chart of Account]. [Account Name] ELSE '' END),[Voucher No],[Check No],Remarks,sum([Debited Amount])[Amount], [Check Issue Date] FROM RankedData join [Chart of Account] on RankedData.[Chart Of Account ID]=[Chart of Account].[Chart of Account ID] where   RankedData.[Category Name]='Collection' or RankedData.[Category Name]='Payment' or RankedData.[Category Name]='Expense' or RankedData.[Category Name]='Transfer'  GROUP BY [ledger invoice id 2],[Invoice No],[Voucher No],[Check No],Remarks,[Ledger Date],[category Name], [Check Issue Date] order by RankedData.[ledger Date]  desc, RankedData.[Invoice No] desc"

                    dr = cmd.ExecuteReader
                    dr.Read()


                    If dr.HasRows Then
                        CmbChartOfAccount.ValueMember = dr.Item("Value+ID").ToString
                        CmbPaidBy.ValueMember = dr.Item("Value-ID").ToString

                    End If
                    dr.Close()
                    con.Close()


                    CmbChartOfAccount.Text = row.Cells("Value+").Value.ToString
                    CmbPaidBy.Text = row.Cells("Value-").Value.ToString

                    'Invisible all gridview as combobx
                    GrdVoucherName.Hide()
                    GrdChartofAccount.Hide()
                    GrdPaidBy.Hide()


                    'Refresh Data For Show Pending Purchase Bills
                    RefreshDataForShowPendingPurchaseBills()

                ElseIf row.Cells("Category Name").Value.ToString = "Expense" Then

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.Connection = con
                    cmd.CommandText = "WITH RankedData AS (SELECT *, RN = ROW_NUMBER() OVER(PARTITION BY [invoice No], [Category Name] ORDER BY [invoice No],[Category Name]) FROM Ledger where [Branch ID]='" + FrmHome.lblBranchID.Text + "' and [ledger invoice id 2]='" + TxtLedgerInvoiceNo.Text + "' and [Invoice No]='" + TxtLedgerNo.Text + "')  SELECT [ledger invoice id 2][Invoice No],[Invoice No][Ledger No], [Ledger Date],[Category Name], [Value+ID] = MAX(CASE WHEN RN = 1 THEN [Chart of Account]. [Chart of Account ID] ELSE '' END), [Value+] = MAX(CASE WHEN RN = 1 THEN [Chart of Account]. [Account Name] ELSE '' END), [Value-ID] = MAX(CASE WHEN RN = 2 THEN [Chart of Account].[Chart of Account ID] ELSE '' END), [Value-] = MAX(CASE WHEN RN = 2 THEN [Chart of Account]. [Account Name] ELSE '' END),[Voucher No],[Check No],Remarks,sum([Debited Amount])[Amount], [Check Issue Date] FROM RankedData join [Chart of Account] on RankedData.[Chart Of Account ID]=[Chart of Account].[Chart of Account ID] where   RankedData.[Category Name]='Collection' or RankedData.[Category Name]='Payment' or RankedData.[Category Name]='Expense' or RankedData.[Category Name]='Transfer'  GROUP BY [ledger invoice id 2],[Invoice No],[Voucher No],[Check No],Remarks,[Ledger Date],[category Name], [Check Issue Date] order by RankedData.[ledger Date]  desc, RankedData.[Invoice No] desc"

                    dr = cmd.ExecuteReader
                    dr.Read()


                    If dr.HasRows Then
                        CmbChartOfAccount.ValueMember = dr.Item("Value+ID").ToString
                        CmbPaidBy.ValueMember = dr.Item("Value-ID").ToString

                    End If
                    dr.Close()
                    con.Close()


                    CmbChartOfAccount.Text = row.Cells("Value+").Value.ToString
                    CmbPaidBy.Text = row.Cells("Value-").Value.ToString


                    'Invisible all gridview as combobx
                    GrdVoucherName.Hide()
                    GrdChartofAccount.Hide()
                    GrdPaidBy.Hide()

                ElseIf row.Cells("Category Name").Value.ToString = "Transfer" Then

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.Connection = con
                    cmd.CommandText = "WITH RankedData AS (SELECT *, RN = ROW_NUMBER() OVER(PARTITION BY [invoice No], [Category Name] ORDER BY [invoice No],[Category Name]) FROM Ledger where [Branch ID]='" + FrmHome.lblBranchID.Text + "' and [ledger invoice id 2]='" + TxtLedgerInvoiceNo.Text + "' and [Invoice No]='" + TxtLedgerNo.Text + "')  SELECT [ledger invoice id 2][Invoice No],[Invoice No][Ledger No], [Ledger Date],[Category Name], [Value+ID] = MAX(CASE WHEN RN = 1 THEN [Chart of Account]. [Chart of Account ID] ELSE '' END), [Value+] = MAX(CASE WHEN RN = 1 THEN [Chart of Account]. [Account Name] ELSE '' END), [Value-ID] = MAX(CASE WHEN RN = 2 THEN [Chart of Account].[Chart of Account ID] ELSE '' END), [Value-] = MAX(CASE WHEN RN = 2 THEN [Chart of Account]. [Account Name] ELSE '' END),[Voucher No],[Check No],Remarks,sum([Debited Amount])[Amount], [Check Issue Date] FROM RankedData join [Chart of Account] on RankedData.[Chart Of Account ID]=[Chart of Account].[Chart of Account ID] where   RankedData.[Category Name]='Collection' or RankedData.[Category Name]='Payment' or RankedData.[Category Name]='Expense' or RankedData.[Category Name]='Transfer'  GROUP BY [ledger invoice id 2],[Invoice No],[Voucher No],[Check No],Remarks,[Ledger Date],[category Name], [Check Issue Date] order by RankedData.[ledger Date]  desc, RankedData.[Invoice No] desc"

                    dr = cmd.ExecuteReader
                    dr.Read()


                    If dr.HasRows Then
                        CmbChartOfAccount.ValueMember = dr.Item("Value-ID").ToString
                        CmbPaidBy.ValueMember = dr.Item("Value+ID").ToString

                    End If
                    dr.Close()
                    con.Close()


                    CmbChartOfAccount.Text = row.Cells("Value-").Value.ToString
                    CmbPaidBy.Text = row.Cells("Value+").Value.ToString

                    'Invisible all gridview as combobx
                    GrdVoucherName.Hide()
                    GrdChartofAccount.Hide()
                    GrdPaidBy.Hide()

                End If


                'Show Check Issu date at last becuase its values remain empty max time. which cause problem
                DtpIssueDate.Value = row.Cells("Check Issue Date").Value.ToString






            End If



        Catch ex As Exception
            'MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview")

        End Try
    End Sub


    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If TxtLedgerInvoiceNo.Text = "" Then
            MsgBox("Please select an invoice.", MsgBoxStyle.Exclamation, "Ledger")
        Else

            'Data Delete Code
            Dim q As MsgBoxResult
            q = MsgBox("Do you really want to delete this Invoice?", MsgBoxStyle.YesNo, "Ledger")
            If q = MsgBoxResult.Yes Then

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim cmd1 As New SqlCommand
                Dim currentDate As DateTime = DateTime.Today
                Dim currentTime As DateTime = DateTime.Now

                Dim LedgerName As String

                If Not Me.BtnCollection.ForeColor = Color.Black Then
                    LedgerName = "LEDGER COLLECTION"

                ElseIf Not Me.BtnPayment.ForeColor = Color.Black Then
                    LedgerName = "LEDGER PAYMENT"

                ElseIf Not Me.BtnExpense.ForeColor = Color.Black Then
                    LedgerName = "LEDGER EXPENSE"


                ElseIf Not Me.BtnTransfer.ForeColor = Color.Black Then
                    LedgerName = "LEDGER TRANSFER"

                End If

                Try

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con

                    cmd.CommandText = " delete [Ledger Invoice]  from Ledger where [Ledger Invoice].[Ledger Invoice ID]= Ledger.[Invoice No] and Ledger.[Ledger Invoice ID 2]= '" + TxtLedgerInvoiceNo.Text + "'  Delete from [Ledger] where [Ledger Invoice ID 2]= '" + TxtLedgerInvoiceNo.Text + "' Delete from [Ledger Invoice 2] where [Ledger Invoice ID 2]= '" + TxtLedgerInvoiceNo.Text + "'    INSERT INTO [Log Details]   ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES('" + LedgerName + "','DELETE','Ledger Invoice No: " + TxtLedgerInvoiceNo.Text + " Is Been Deleted By " + FrmHome.LblUserName.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtLedgerInvoiceNo.Text + "' )"
                    cmd.ExecuteNonQuery()
                    con.Close()
                    'Making Clear
                    clearAllData()


                    'Refresh Data
                    RefreshData()


                Catch ex As Exception
                    MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Records")
                Finally





                End Try

            End If
        End If

    End Sub

    Private Sub TxtVoucherNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtVoucherNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtRemarks.Focus()
        End If
    End Sub

    Private Sub TxtVoucherNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtVoucherNo.TextChanged

    End Sub

    Private Sub BtnInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInvoice.Click
        If Not Me.BtnCollection.ForeColor = Color.Black Then


            RptReceitpVoucher.InvoiceNo = TxtLedgerInvoiceNo.Text


            'Show Invoice
            RptReceitpVoucher.ShowVoucherInvoice()
            RptReceitpVoucher.Show()

        ElseIf Not Me.BtnPayment.ForeColor = Color.Black Then

            RptPaymentVoucher.InvoiceNo = TxtLedgerInvoiceNo.Text

            'Show Invoice
            RptPaymentVoucher.ShowVoucherInvoice()
            RptPaymentVoucher.Show()

        ElseIf Not Me.BtnExpense.ForeColor = Color.Black Then

            RptExpenseVoucher.InvoiceNo = TxtLedgerInvoiceNo.Text

            'Show Invoice
            RptExpenseVoucher.ShowExpenseVoucherInvoice()
            RptExpenseVoucher.Show()

        ElseIf Not Me.BtnTransfer.ForeColor = Color.Black Then

            RptTransferVoucher.InvoiceNo = TxtLedgerInvoiceNo.Text


            'Show Invoice
            RptTransferVoucher.ShowTransferVoucherInvoice()
            RptTransferVoucher.Show()


        End If

    End Sub

    Private Sub LblBalance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblBalance1.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    'Insert into ledger 
    Sub InsertIntoLedger()

        If CmbVoucherName.Text = "" Or CmbVoucherName.ValueMember = "" Or CmbChartOfAccount.Text = "" Or CmbChartOfAccount.ValueMember = "" Or CmbPaidBy.Text = "" Or CmbPaidBy.ValueMember = "" Or TxtAmount.Text = "" Then
            MsgBox("Required field can not be empty.", MsgBoxStyle.Exclamation, "Ledger")
        ElseIf Me.TxtLedgerNo.Text = "" And Not TxtLedgerInvoiceNo.Text = "" Then



            'Insert into Ledger Invoice For Per Transaction
            InsertIntoLedgerInvoiceForPerTransaction()

            'Insert or  Update for 2nd Invoice Number For An Invoice
            InsertOrUpdateIntoLedgerInvoiceNo2ForAnInvoice()

            If Not Me.BtnCollection.ForeColor = Color.Black Then
                If Me.CmbPaidBy.Text = "CASH" Then
                    insertDataForCollection()


                Else
                    insertDataForCollectionWithHeld()
                End If

            ElseIf Not Me.BtnPayment.ForeColor = Color.Black Then
                If Me.CmbPaidBy.Text = "CASH" Then
                    insertDataForPayment()
                Else
                    insertDataForPaymentWithHeld()
                End If

            ElseIf Not Me.BtnExpense.ForeColor = Color.Black Then
                InsertDataForExpense()
            ElseIf Not Me.BtnTransfer.ForeColor = Color.Black Then
                insertDataForTransfer()
            End If

            'Refresh Data
            RefreshData()




            'Else
            ' MsgBox("Already inserted, you can only update Now", MsgBoxStyle.Critical, "Ledger")
        End If
    End Sub

    Private Sub BtnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddItem.Click
        If TxtLedgerNo.Text = "" Then

            LogCategoryStatus = "INSERT"

            'Insert into ledger 
            InsertIntoLedger()


        ElseIf Not TxtLedgerNo.Text = "" Then
            If UpdatePermission = True Then

                LogCategoryStatus = "UPDATE"

                'Delete Data For Update Ledger
                DeleteForUpdate()

                'Insert into ledger 
                InsertIntoLedger()
            Else
                MsgBox("You do not have update permission.", MsgBoxStyle.Critical, "Collection / Payment")
            End If
        End If
    End Sub

    Private Sub CmbVoucherName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbVoucherName.GotFocus
        GrdChartofAccount.Visible = False
        GrdPaidBy.Visible = False
    End Sub

    Private Sub CmbVoucherName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbVoucherName.KeyDown
        If e.KeyCode = Keys.Down Then


            'Resize Voucher Name Gridview and Make it Visible
            ResizeVoucherNameGridviewandMakeitVisible()


            'Search Voucher Name
            SearchVoucherName()


            GrdVoucherName.Visible = True

            GrdVoucherName.Focus()
        ElseIf e.KeyCode = Keys.Enter Then

            'Show Voucher Name to Combobox
            ShowVoucherNameToCombobox()

            CmbChartOfAccount.Focus()
        End If

    End Sub

    Private Sub CmbVoucherName_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CmbVoucherName.MouseClick
        'Resize Voucher Name Gridview and Make it Visible
        ResizeVoucherNameGridviewandMakeitVisible()


        'Search Voucher Name
        SearchVoucherName()

        GrdChartofAccount.Visible = False
        GrdPaidBy.Visible = False
    End Sub

    Private Sub CmbVoucherName_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbVoucherName.MouseLeave

    End Sub

    Private Sub CmbVoucherName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbVoucherName.SelectedIndexChanged


        If Not BtnCollection.ForeColor = Color.Black Or Not BtnPayment.ForeColor = Color.Black Then
            ' CmbChartOfAccount.Text = CmbVoucherName.Text
        End If

    End Sub

    'Insert into log 
    Sub InsertIntoLogForDeleteLedgerCollection()

        'Data Insert Code
        Dim con As New SqlConnection
        Dim con1 As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim CurrentDate As DateTime = DateTime.Today
        Dim CurrentTime As DateTime = DateTime.Now

        Try
            

            con1.ConnectionString = FrmHome.ConnectionString
            con1.Open()
            cmd1.Connection = con1
            cmd1.CommandText = " INSERT INTO [Log Details]   ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES('LEDGER COLLECTION','DELETE','Ledger No:" + TxtLedgerNo.Text + ",Voucher Name: " + CmbVoucherName.Text + " , Collection From: " + CmbChartOfAccount.Text + " , Collection By: " + CmbPaidBy.Text + ",  Amount: " + TxtAmount.Text + " , Check No: " + TxtCheckNo.Text + ", Voucher No: " + TxtVoucherNo.Text + " , Remarks: " + TxtRemarks.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtLedgerInvoiceNo.Text + "' )"
            cmd1.ExecuteNonQuery()
            con1.Close()

           

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally


        End Try

    End Sub
    'Insert into log 
    Sub InsertIntoLogForDeleteLedgerPayment()

        'Data Insert Code
        Dim con As New SqlConnection
        Dim con1 As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim CurrentDate As DateTime = DateTime.Today
        Dim CurrentTime As DateTime = DateTime.Now

        Try


            con1.ConnectionString = FrmHome.ConnectionString
            con1.Open()
            cmd1.Connection = con1
            cmd1.CommandText = "   INSERT INTO [Log Details]   ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES('LEDGER PAYMENT','DELETE','Ledger No:" + TxtLedgerNo.Text + ",Voucher Name: " + CmbVoucherName.Text + " , Paid To: " + CmbChartOfAccount.Text + " , Paid By: " + CmbPaidBy.Text + ",  Amount: " + TxtAmount.Text + " , Check No: " + TxtCheckNo.Text + ", Voucher No: " + TxtVoucherNo.Text + " , Remarks: " + TxtRemarks.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtLedgerInvoiceNo.Text + "' )"
            cmd1.ExecuteNonQuery()
            con1.Close()



        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally


        End Try

    End Sub
    'Insert into log 
    Sub InsertIntoLogForDeleteLedgerExpense()

        'Data Insert Code
        Dim con As New SqlConnection
        Dim con1 As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim CurrentDate As DateTime = DateTime.Today
        Dim CurrentTime As DateTime = DateTime.Now

        Try


            con1.ConnectionString = FrmHome.ConnectionString
            con1.Open()
            cmd1.Connection = con1
            cmd1.CommandText = "  INSERT INTO [Log Details]   ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES('LEDGER EXPENSE','DELETE','Ledger No:" + TxtLedgerNo.Text + ",Voucher Name: " + CmbVoucherName.Text + " , Expense Name: " + CmbChartOfAccount.Text + " , Paid By: " + CmbPaidBy.Text + ",  Amount: " + TxtAmount.Text + " , Check No: " + TxtCheckNo.Text + ", Voucher No: " + TxtVoucherNo.Text + " , Remarks: " + TxtRemarks.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtLedgerInvoiceNo.Text + "' )"
            cmd1.ExecuteNonQuery()
            con1.Close()



        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally


        End Try

    End Sub
    'Insert into log 
    Sub InsertIntoLogForDeleteLedgerTransfer()

        'Data Insert Code
        Dim con As New SqlConnection
        Dim con1 As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim CurrentDate As DateTime = DateTime.Today
        Dim CurrentTime As DateTime = DateTime.Now

        Try


            con1.ConnectionString = FrmHome.ConnectionString
            con1.Open()
            cmd1.Connection = con1
            cmd1.CommandText = " INSERT INTO [Log Details]   ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES('LEDGER TRANSFER','DELETE','Ledger No:" + TxtLedgerNo.Text + ",Voucher Name: " + CmbVoucherName.Text + " , Transfer From: " + CmbChartOfAccount.Text + " , Transfer To: " + CmbPaidBy.Text + ",  Amount: " + TxtAmount.Text + " , Check No: " + TxtCheckNo.Text + ", Voucher No: " + TxtVoucherNo.Text + " , Remarks: " + TxtRemarks.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtLedgerInvoiceNo.Text + "' )"
            cmd1.ExecuteNonQuery()
            con1.Close()



        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally


        End Try

    End Sub

    Private Sub GrdLedger_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdLedger.CellMouseDoubleClick

        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow
            row = Me.GrdLedger.Rows(e.RowIndex)

            If DeletePermission = True Then
                'Data Delete Code
                Dim q As MsgBoxResult
                q = MsgBox("Do you really want to Delete the row?", MsgBoxStyle.YesNo, "Ledger")
                If q = MsgBoxResult.Yes Then

                    Dim con As New SqlConnection
                    Dim cmd As New SqlCommand
                    Dim cmd1 As New SqlCommand
                    Dim currentDate As DateTime = DateTime.Today
                    Dim currentTime As DateTime = DateTime.Now
                    Dim BtnName As String


                    If Not Me.BtnCollection.ForeColor = Color.Black Then
                        BtnName = BtnCollection.Text

                        'Insert into log 
                        InsertIntoLogForDeleteLedgerCollection()

                    ElseIf Not Me.BtnPayment.ForeColor = Color.Black Then
                        BtnName = BtnPayment.Text

                        'Insert into log 
                        InsertIntoLogForDeleteLedgerPayment()

                    ElseIf Not Me.BtnExpense.ForeColor = Color.Black Then
                        BtnName = BtnExpense.Text

                        'Insert into log 
                        InsertIntoLogForDeleteLedgerExpense()

                    ElseIf Not Me.BtnTransfer.ForeColor = Color.Black Then
                        BtnName = BtnTransfer.Text

                        'Insert into log 
                        InsertIntoLogForDeleteLedgerTransfer()
                    End If


                    Try


                        con.ConnectionString = FrmHome.ConnectionString
                        con.Open()
                        cmd.Connection = con

                        cmd.CommandText = "Delete from [Ledger] where [Invoice No]= '" + TxtLedgerNo.Text + "' and [Category Name]= '" + BtnName.ToString + "'  "
                        cmd.ExecuteNonQuery()
                        con.Close()




                        If Not BtnCollection.ForeColor = Color.Black Or Not BtnPayment.ForeColor = Color.Black Then

                            'Clear Data For Collection And Payment
                            ClearDataForCollectionAndPayment()

                        ElseIf Not BtnExpense.ForeColor = Color.Black Or Not BtnTransfer.ForeColor = Color.Black Then

                            'Clear Data For Expense and Transfer
                            ClearDataForExpenseAndTransfer()
                        End If

                        'Focus on Amount Textbox
                        TxtAmount.Focus()



                        'Refresh Data
                        RefreshData()




                    Catch ex As Exception
                        MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Records")
                    Finally




                    End Try

                End If

            ElseIf Not DeletePermission = True Then
                MsgBox("You do not have permission to delete this row.", MsgBoxStyle.Critical, "Ledger")
            End If

        End If


    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FrmLedgerHistory.Show()
        FrmLedgerHistory.TxtLedgerInvoiceNo.Focus()
    End Sub

    Private Sub GrdShowDueBills_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdShowDueBills.CellContentClick

    End Sub

    Private Sub GrdShowDueBills_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdShowDueBills.CellContentDoubleClick

    End Sub

    Private Sub GrdShowDueBills_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdShowDueBills.CellMouseDoubleClick
        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow
            row = GrdShowDueBills.Rows(e.RowIndex)

            Try



                TxtVoucherNo.Text = row.Cells("Pending Invoice").Value.ToString
                TxtAmount.Text = Double.Parse(row.Cells("Dues Amount").Value.ToString).ToString


                TxtVoucherNo.ReadOnly = True

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim q As MsgBoxResult
        q = MsgBox("Are you sure want to creat new invoice?", MsgBoxStyle.YesNo, "Ledger")

        If q = MsgBoxResult.Yes Then
            'Clear all data for new invoice
            clearAllData()
        End If

    End Sub

    Private Sub Btnmaximized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Btnminimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Btnminimized_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnminimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Btnmaximized_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnmaximized.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal

        Else
            Me.WindowState = FormWindowState.Maximized

        End If
    End Sub

    Private Sub Btnclose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnclose.Click
        Me.Close()
    End Sub

    Private Sub Panel2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseMove

        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= (X)
            newpoint.Y -= (Y)
            Me.Location = newpoint

        End If
    End Sub



    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub
    'Resize Voucher Name Gridview and Make it Visible
    Sub ResizeVoucherNameGridviewandMakeitVisible()

        GrdVoucherName.Visible = True
        GrdVoucherName.Width = CmbVoucherName.Width
        GrdVoucherName.Height = 113

        'Column visiblity false
        GrdVoucherName.ColumnHeadersVisible = False
    End Sub
    'Resize Chart of Account Gridview and Make it Visible
    Sub ResizeChartofAccountGridviewandMakeitVisible()

        GrdChartofAccount.Visible = True
        GrdChartofAccount.Width = CmbChartOfAccount.Width
        GrdChartofAccount.Height = 113

        'Column visiblity false
        GrdChartofAccount.ColumnHeadersVisible = False
    End Sub
    'Resize CPaid By Gridview and Make it Visible
    Sub ResizePaidByGridviewandMakeitVisible()

        GrdPaidBy.Visible = True
        GrdPaidBy.Width = CmbChartOfAccount.Width
        GrdPaidBy.Height = 113

        'Column visiblity false
        GrdPaidBy.ColumnHeadersVisible = False
    End Sub


    Private Sub CmbVoucherName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbVoucherName.TextChanged
        If Not CmbVoucherName.Text = "" Then

            'Resize Voucher Name Gridview and Make it Visible
            ResizeVoucherNameGridviewandMakeitVisible()


            'Search Voucher Name
            SearchVoucherName()




        ElseIf CmbVoucherName.Text = "" Then

            CmbVoucherName.ValueMember = ""
            GrdVoucherName.Visible = False

        End If
    End Sub

    Private Sub FrmLedger_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        'Hide product list
        GrdVoucherName.Visible = False

        'Hide Chart list
        GrdChartofAccount.Visible = False

        'Hide Paid by list
        GrdPaidBy.Visible = False

    End Sub

    Private Sub GrdVoucherName_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdVoucherName.CellContentClick

    End Sub
    'Show Vooucher Name to Combobox
    Sub ShowVoucherNameToCombobox()
        Try

            Dim i As Integer
            i = GrdVoucherName.CurrentRow.Index






            'Show value member to combobox
            CmbVoucherName.ValueMember = GrdVoucherName.Item(0, i).Value
            CmbVoucherName.Text = GrdVoucherName.Item(1, i).Value



            CmbChartOfAccount.Focus()


            'hide product list gridview
            GrdVoucherName.Visible = False




        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

        End Try
    End Sub
    'Show Chart Of Account to Combobox
    Sub ShowChartOfAccountToCombobox()
        Try

            Dim i As Integer
            i = GrdChartofAccount.CurrentRow.Index






            'Show value member to combobox
            CmbChartOfAccount.ValueMember = GrdChartofAccount.Item(0, i).Value
            CmbChartOfAccount.Text = GrdChartofAccount.Item(1, i).Value



            CmbPaidBy.Focus()


            'hide product list gridview
            GrdChartofAccount.Visible = False


            'Search 1st Balance
            Search1stBalance()

            If Not BtnPayment.ForeColor = Color.Black Then
                'Refresh Data For Show Pending Purchase Bills
                RefreshDataForShowPendingPurchaseBills()

            ElseIf Not BtnCollection.ForeColor = Color.Black Then

                'Refresh Data For Show Pending Sale Bills
                RefreshDataForShowPendingSaleBills()

            End If


        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

        End Try
    End Sub
    'Show Pai dBy
    Sub ShowPaidByToCombobox()
        Try

            Dim i As Integer
            i = GrdPaidBy.CurrentRow.Index






            'Show value member to combobox
            CmbPaidBy.ValueMember = GrdPaidBy.Item(0, i).Value
            CmbPaidBy.Text = GrdPaidBy.Item(1, i).Value



            TxtAmount.Focus()


            'hide product list gridview
            GrdPaidBy.Visible = False


            'Search 2nd Balance
            Search2ndBalance()




        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

        End Try
    End Sub




    Private Sub GrdVoucherName_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdVoucherName.CellMouseDoubleClick
        'Show Voucher Name to Combobox
        ShowVoucherNameToCombobox()
    End Sub

    Private Sub GrdVoucherName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdVoucherName.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Show Voucher Name to Combobox
            ShowVoucherNameToCombobox()
        End If
    End Sub

    Private Sub CmbChartOfAccount_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbChartOfAccount.TextChanged
        If Not CmbChartOfAccount.Text = "" Then

            'Resize Chart of Account Gridview and Make it Visible
            ResizeChartofAccountGridviewandMakeitVisible()

            If Not BtnExpense.ForeColor = Color.Black Then
                'Search Chart of Account for Expense
                SearchChartofAccountForExpense()
            Else

                'Search Voucher Name
                SearchChartofAccount()

            End If





        ElseIf CmbChartOfAccount.Text = "" Then

            'CmbChartOfAccount.ValueMember = ""
            GrdChartofAccount.Visible = False

        End If
    End Sub

    Private Sub GrpLedger_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GrpLedger.MouseClick

        'Hide product list
        GrdVoucherName.Visible = False

        'Hide Chart list
        GrdChartofAccount.Visible = False

        'Hide Paid by list
        GrdPaidBy.Visible = False
    End Sub

    Private Sub GrdChartofAccount_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdChartofAccount.CellContentClick

    End Sub

    Private Sub GrdChartofAccount_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdChartofAccount.CellMouseDoubleClick

        'Show Chart Of Account to Combobox
        ShowChartOfAccountToCombobox()

    End Sub

    Private Sub GrdChartofAccount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdChartofAccount.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Show Chart Of Account to Combobox
            ShowChartOfAccountToCombobox()
        End If
    End Sub

    Private Sub CmbPaidBy_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbPaidBy.TextChanged
        If Not CmbPaidBy.Text = "" Then

            'Resize Chart of Account Gridview and Make it Visible
            ResizePaidByGridviewandMakeitVisible()

            If Not BtnTransfer.ForeColor = Color.Black Then
                'Search Chart of Account To Paid by For Transfer
                SearchChartofAccountToPaidbyForTransfer()
            Else
                'Search Paid By
                SearchPaidBy()

            End If

        ElseIf CmbPaidBy.Text = "" Then

            CmbPaidBy.ValueMember = ""
            GrdPaidBy.Visible = False

        End If
    End Sub

    Private Sub GrdPaidBy_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdPaidBy.CellContentClick

    End Sub

    Private Sub GrdPaidBy_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdPaidBy.CellMouseDoubleClick
        'Show Paid By to Combobox
        ShowPaidByToCombobox()
    End Sub

    Private Sub GrdPaidBy_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdPaidBy.KeyDown
        If e.KeyCode = Keys.Enter Then

            'Show Paid By to Combobox
            ShowPaidByToCombobox()

        End If
    End Sub
End Class