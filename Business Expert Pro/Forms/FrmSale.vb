Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.IO.Ports
Imports System.Text.RegularExpressions


Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Net



Public Class FrmSale

    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point


    Dim ProductIDForBarcode As String
    Dim ProductNameForBarcode As String
    Dim TotalRowForBarcode As String

    Dim CustomerChartofAccountIDForUpdate As String
    Public PreviousPaidbyID As String
    Dim TransactionLimit As String
    Dim DeletePermission As String
    Dim QuantityWritten As String
    Public StockAvailableForAutoInsertQuantity As String

    Dim TotalSoldQuantity As String

    Dim PurchaseInvoiceNo As String
    Dim TotalRangeSerialCount As String
    Dim TotalInsertedQuantity As String
    Dim TotalInsertedBonusQuantity As String
    Dim TotalInsertedSerialCount As String
    Dim QuantityWrittenForBonus As String
    Public CustomerChartofAccountID As String


    Dim PurchaseInvoiceNoForAdvanceSale As String
    Public SaleEditStatus As Boolean









    'Sub for show dues or advanced or Greeting
    Sub SendSMS()
        Try

            If FrmHome.LblStatus.Text = "Active" Or FrmHome.LblStatus.Text = "Masking" Then

                Dim q As MsgBoxResult
                q = MsgBox("Do you want to send SMS?", MsgBoxStyle.YesNo, "Sale")

                If q = MsgBoxResult.Yes Then

                    Dim con As New SqlConnection
                    Dim con1 As New SqlConnection
                    Dim cmd As New SqlCommand
                    Dim dr As SqlDataReader
                    Dim cmd2 As New SqlCommand
                    Dim dr2 As SqlDataReader
                    Dim CustomerChartOfAccountID As String

                    Dim CurrentDate As DateTime = DateTime.Today
                    Dim CurrentTime As DateTime = DateTime.Now


                    Dim SaleAmount As String
                    SaleAmount = Val(TxtTotal.Text) + Val(TxtVat.Text) - Val(TxtDiscount.Text)

                    FrmHome.SMSPhoneNo = Me.TxtPhoneNo.Text

                    'Data reader for Product Id
                    con1.ConnectionString = FrmHome.ConnectionString
                    con1.Open()
                    cmd2.Connection = con1
                    cmd2.CommandText = "SELECT  *FROM [Customer Information]  WHERE [Customer ID] = '" + CmbCustomerName.ValueMember.ToString + "'"

                    dr2 = cmd2.ExecuteReader()
                    dr2.Read()
                    CustomerChartOfAccountID = (dr2.Item("Chart Of Account ID").ToString)
                    dr2.Close()


                    cmd.Connection = con1
                    cmd.CommandText = "select (isnull(sum([Debited Amount]),0)- (isnull(sum([Credited Amount]),0))) as [Amount]  from [Ledger] where [Ledger].[Chart Of Account ID]= '" + CustomerChartOfAccountID + "' "

                    dr = cmd.ExecuteReader()
                    dr.Read()


                    If dr.HasRows Then


                        'Send due sms
                        If Val(dr.Item("Amount").ToString) > 0 Then

                            FrmHome.SMSText = "Dear Customer, " & "your sale amount is BDT " & "" + SaleAmount + "" & ". Received in cash BDT " & "" + TxtPaidAmount.Text + "" & ". Your Current Balance is BDT " & Val(dr.Item("Amount").ToString) & " due. " & "" + FrmHome.lblCompanyName.Text + "" & ". Contact No: " & "" + FrmHome.SMSNumber + ""

                            If FrmHome.LblStatus.Text = "Active" Then
                                FrmHome.BulksmsbdToAll()
                            ElseIf FrmHome.LblStatus.Text = "Masking" Then
                                FrmHome.MaskingBulksmsbdToAll()
                            End If





                            'Send advance sms
                        ElseIf Val(dr.Item("Amount").ToString) < 0 Then


                            FrmHome.SMSText = "Dear Customer, " & "your sale amount is BDT " & "" + SaleAmount + "" & ". Received in cash BDT " & "" + TxtPaidAmount.Text + "" & ". Your Current Balance is BDT " & Val(dr.Item("Amount").ToString) & " Advance. " & "" + FrmHome.lblCompanyName.Text + "" & ". Contact No: " & "" + FrmHome.SMSNumber + ""

                            If FrmHome.LblStatus.Text = "Active" Then
                                FrmHome.BulksmsbdToAll()
                            ElseIf FrmHome.LblStatus.Text = "Masking" Then
                                FrmHome.MaskingBulksmsbdToAll()
                            End If




                            'Send grading sms
                        ElseIf Val(dr.Item("Amount").ToString) = 0 Then



                            FrmHome.SMSText = "Dear Customer, " & "your sale amount is BDT " & "" + SaleAmount + "" & ". Received in cash BDT " & "" + TxtPaidAmount.Text + "" & ". Your Current Balance is BDT " & Val(dr.Item("Amount").ToString) & " . " + FrmHome.lblCompanyName.Text + "" & ". Contact No: " & "" + FrmHome.SMSNumber + ""

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
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Sub SendSms")
        End Try
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub TxtVatPercentage_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtVatPercentage.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtVat.Focus()
        End If
    End Sub



    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtVatPercentage.TextChanged
        'Calculate Vat
        TxtVat.Text = (Val(TxtTotal.Text) * Val(TxtVatPercentage.Text)) / 100
        'Calculate Net Payable Amount
        NetPayableAmount()
    End Sub

    Sub NewInvoice()


        cmbPaidBy.Text = "CASH"

        'Sale Invoice 
        Me.TxtSaleInvoiceNo.Text = "" 'Format(Now, "ddMMyyhhmmssms") & FrmHome.LblUserID.Text & FrmHome.LblComputerID.Text

        'Date time auto today
        DtpSaleDate.Value = Now


    End Sub

    Private Sub FrmSale_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'If (MessageBox.Show(" Do you really want to Close?", "Bizpro", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No) Then
        'e.Cancel = True

        'End If

        If Not TxtSaleInvoiceNo.Text = "" And Not SaleEditStatus = True Then

            Dim q As MsgBoxResult = MsgBox("Do you want to keep this Invoice as draft?", MsgBoxStyle.YesNoCancel, "Sale")

            If q = MsgBoxResult.No Then

                'Insert into log code For Delete
                InsertIntoLogForDelete()

                'Delete Full Invoice
                DeleteFullInvoice()
            ElseIf q = MsgBoxResult.Cancel Then
                e.Cancel = True
            End If
        ElseIf Not TxtSaleInvoiceNo.Text = "" And SaleEditStatus = True Then
            If (MessageBox.Show(" Do you really want to Close?", "Bizpro", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No) Then

                e.Cancel = True


            End If

       
        End If


    End Sub

    Private Sub FrmSale_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus

    End Sub

    Private Sub FrmSale_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave

    End Sub


    Private Sub FrmSale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
                'TxtPaidAmount.ReadOnly = False
                DeletePermission = "Yes"
            ElseIf Not dr.HasRows Then

                BtnDelete.Enabled = False
                'TxtPaidAmount.ReadOnly = True


                TxtPaidAmount.Text = "00"

            End If
            dr.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while  permission delete to form..." & ex.Message, "Form Load")

        End Try


        'Load combobox customer information
        'LoadComboBoxforcustomer()






        'Load combobox
        LoadComboBoxPaymentMethod()

        'clearData
        cleardataCustomer()

        'Change Language
        ChangeLanguage()

        'New INvoice
        NewInvoice()



    End Sub

    'Serach Serial Number Available or not
    Sub SearchSerialStatus()
        Try


            Dim con2 As New SqlConnection
            Dim cmd2 As New SqlCommand
            Dim dr1 As SqlDataReader

            con2.ConnectionString = FrmHome.ConnectionString
            con2.Open()
            cmd2.Connection = con2
            cmd2.CommandText = "select * from [Purchase Serial Number]  where ([Product ID]='" + cmbProductName.ValueMember + "' and [Status]='Available' and [Branch ID]='" + FrmHome.lblBranchID.Text + "' )"

            dr1 = cmd2.ExecuteReader()
            dr1.Read()

            If dr1.HasRows Then

                LblStatus.Text = "Available"
                LblStatus.ForeColor = Color.DarkGreen

            ElseIf Not dr1.HasRows Then

                LblStatus.Text = "Not Available"
                LblStatus.ForeColor = Color.DarkRed



            End If
            dr1.Close()
            con2.Close()


        Catch ex As Exception

        End Try

    End Sub
    'Count Totla amount and shoe in total textbox
    Sub TotalAmount()
        Dim total As String = 0
        For i As Integer = 0 To GrdSale.RowCount - 1
            total += GrdSale.Rows(i).Cells(5).Value
        Next
        Me.TxtTotal.Text = total
    End Sub
    'Making Clear Data For Products For Barcode
    Sub cleardataProductForBarcode()

        cmbProductName.Text = ""
        cmbProductName.ValueMember = ""

        TxtPurchaseID.Text = ""
        TxtQuantity.Text = ""
        TxtSaleUnitPrice.Text = ""
        TxtSaleAmount.Text = ""
        lblSaleID.Text = "00"
        lblQuantityAvailable.Text = "00"
        lblTotalQuantityAvailable.Text = "00"

        CmbSerialNumber.Text = ""

        TxtFromSerial.Text = ""
        TxtToSerial.Text = ""

        RdbRangeSerial.Checked = False

        LblStatus.Text = "Status"
        LblStatus.ForeColor = Color.Black
        TxtWarrantyDays.Text = ""

        TxtUnitDiscount.Text = ""
        TxtDiscountAmount.Text = ""


        'cmbProductName.Focus()

        GrdAvailableSerialNumber.Columns.Clear()

        LblLastSoldPrice.Text = "00"
        TxtBonus.Text = ""
        TotalInsertedBonusQuantity = ""
    End Sub
    'Making Clear Data For Products
    Sub cleardataProduct()

        cmbProductName.Text = ""
        cmbProductName.ValueMember = ""

        TxtPurchaseID.Text = ""
        TxtQuantity.Text = ""
        TxtSaleUnitPrice.Text = ""
        TxtSaleAmount.Text = ""
        lblSaleID.Text = "00"
        lblQuantityAvailable.Text = "00"
        lblTotalQuantityAvailable.Text = "00"

        CmbSerialNumber.Text = ""

        TxtFromSerial.Text = ""
        TxtToSerial.Text = ""

        RdbRangeSerial.Checked = False

        LblStatus.Text = "Status"
        LblStatus.ForeColor = Color.Black

        TxtWarrantyDays.Text = ""

        TxtUnitDiscount.Text = ""
        TxtDiscountAmount.Text = ""


        cmbProductName.Focus()

        GrdAvailableSerialNumber.Columns.Clear()

        TxtSearchBarcode.Text = ""

        TotalInsertedQuantity = 0
        TotalInsertedSerialCount = 0
        LblLastSoldPrice.Text = "00"
        TxtBonus.Text = ""
        TotalInsertedBonusQuantity = ""


    End Sub
    'Making Clear Data For Products for dropdown
    Sub cleardataProductForDropdown()

        cmbProductName.Text = ""
        cmbProductName.ValueMember = ""

        TxtPurchaseID.Text = ""
        TxtQuantity.Text = ""
        TxtSaleUnitPrice.Text = ""
        TxtSaleAmount.Text = ""
        lblSaleID.Text = "00"
        lblQuantityAvailable.Text = "00"
        lblTotalQuantityAvailable.Text = "00"

        CmbSerialNumber.Text = ""

        TxtFromSerial.Text = ""
        TxtToSerial.Text = ""

        RdbRangeSerial.Checked = False

        LblStatus.Text = "Status"
        LblStatus.ForeColor = Color.Black

        TxtWarrantyDays.Text = ""

        TxtUnitDiscount.Text = ""
        TxtDiscountAmount.Text = ""

        ' cmbProductName.Focus()



        TxtSearchBarcode.Text = ""

        TotalInsertedQuantity = 0
        TotalInsertedSerialCount = 0
        LblLastSoldPrice.Text = "00"
        TxtBonus.Text = ""



    End Sub
    'Making Clear Data For Products Update Serial Number
    Sub CleardataProductForUpdateSerialNumber()

        cmbProductName.Text = ""
        cmbProductName.ValueMember = ""

        TxtPurchaseID.Text = ""
        TxtQuantity.Text = ""
        TxtSaleUnitPrice.Text = ""
        TxtSaleAmount.Text = ""

        lblQuantityAvailable.Text = "00"
        lblTotalQuantityAvailable.Text = "00"

        CmbSerialNumber.Text = ""

        TxtFromSerial.Text = ""
        TxtToSerial.Text = ""

        TxtUnitDiscount.Text = ""
        TxtDiscountAmount.Text = ""

        RdbRangeSerial.Checked = False

        LblStatus.Text = "Status"
        LblStatus.ForeColor = Color.Black

        TxtWarrantyDays.Text = ""
        TxtSearchBarcode.Text = ""
        TxtSearchBarcode.Text = ""
        LblLastSoldPrice.Text = "00"


    End Sub
    Sub ClearAllData()


        cmbProductName.Text = ""
        cmbProductName.ValueMember = ""

        TxtPurchaseID.Text = ""
        TxtQuantity.Text = ""
        TxtSaleUnitPrice.Text = ""
        TxtSaleAmount.Text = ""
        lblSaleID.Text = "00"
        lblQuantityAvailable.Text = "00"
        lblTotalQuantityAvailable.Text = "00"

        CmbCustomerName.ValueMember = ""
        CmbCustomerName.Text = ""



        TxtPhoneNo.Text = ""
        TxtAddress.Text = ""
        TxtCustomerDiscount.Text = ""

        TxtTotal.Text = ""
        TxtPreviousDues.Text = ""
        TxtAdvance.Text = ""
        TxtDiscountPercentage.Text = ""
        TxtDiscount.Text = ""
        TxtVatPercentage.Text = ""
        TxtVat.Text = ""
        TxtNetPayable.Text = ""
        TxtPaidAmount.Text = ""
        TxtBalance.Text = ""
        TxtReturnAmount.Text = ""
        TxtSaleInvoiceNo.Text = ""
        DtpSaleDate.Value = Now

        CmbSerialNumber.Text = ""

        TxtFromSerial.Text = ""
        TxtToSerial.Text = ""

        TxtUnitDiscount.Text = ""
        TxtDiscountAmount.Text = ""

        TxtFromSerial.Enabled = False
        TxtToSerial.Enabled = False

        RdbRangeSerial.Checked = False


        LblStatus.Text = "Status"
        LblStatus.ForeColor = Color.Black

        TxtWarrantyDays.Text = ""
        TxtRemarks.Text = ""
        TxtSearchBarcode.Text = ""
        TxtSearchBarcode.Text = ""

        TotalInsertedQuantity = 0
        TotalInsertedSerialCount = 0
        LblLastSoldPrice.Text = "00"

        SaleEditStatus = False
        TxtBonus.Text = ""
        TotalInsertedBonusQuantity = ""
    End Sub

    Sub cleardataCustomer()
        'Clear Customer Name

        CmbCustomerName.ValueMember = ""
        CmbCustomerName.Text = ""

        TxtPhoneNo.Text = ""
        TxtAddress.Text = ""
        TxtCustomerDiscount.Text = ""
        TxtDiscountPercentage.Text = ""
        LblLastSoldPrice.Text = "00"

    End Sub


    Sub LoadComboBoxPaymentMethod()
        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            con.ConnectionString = FrmHome.ConnectionString

            Dim strSQL As String = "Select [Chart of Account].[Chart of Account ID],[Chart of Account].[Account Name] from  [Chart of Account] join [Head Of Account]  on [Chart of Account].[Head of Account ID]=[Head Of Account].[Head of Account ID] where [Head of Account].[Account Name] = 'CASH AND BANK'"
            Dim da As New System.Data.SqlClient.SqlDataAdapter(strSQL, con)
            Dim ds As New DataSet
            da.Fill(ds, "[Hade Of Account]")

            With Me.cmbPaidBy
                .DataSource = ds.Tables("[Hade Of Account]")
                .ValueMember = "Chart of Account ID"
                .DisplayMember = "Account Name"
            End With
            con.Close()
            cmbPaidBy.Text = "CASH"


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "LoadComboBoxPaymentMethod")
        End Try
    End Sub
    'Creating Privet Sub for Refresh
    Sub RefreshData()

        ' Load Data
        Try


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT [Sale].[Sale ID],[Sale].[Purchase ID],[Products].[Product Name],Sum([Sale].[Sale Quantity])[Quantity], [Sale].[Sale Unit Price],[Sale].[Sale Amount],[Sale].[Warranty Days],[sale].[Unit Discount],[sale].[Discount Amount] from [Sale] join [Products] on [sale].[product ID]=[products].[Product ID]  where [sale].[sale Invoice No]= '" + Me.TxtSaleInvoiceNo.Text + "' group by  [Sale].[Sale ID],[Sale].[Purchase ID],[Products].[Product Name],[Sale].[Sale Quantity],[Sale].[Sale Unit Price],[Sale].[Sale Amount],[Sale].[Warranty Days],[sale].[Unit Discount],[sale].[Discount Amount]"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Sale")
            connection.Close()
            GrdSale.DataSource = ds
            GrdSale.DataMember = "BizPro_Sale"

            'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)


            GrdSale.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            'Total Count
            TotalAmount()


            TxtVat.Text = (Val(TxtTotal.Text) * Val(TxtVatPercentage.Text)) / 100
            DiscountAndPercentage()
            'Calculate Net Payable Amount
            NetPayableAmount()


        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try

        'End Refresh Data
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

                Me.CmbCustomerName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtPhoneNo.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtAddress.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtCustomerDiscount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtSearchBarcode.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtSaleInvoiceNo.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.cmbProductName.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtPurchaseID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtQuantity.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtSaleUnitPrice.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtSaleAmount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))

                Me.TxtTotal.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, 13, FontStyle.Bold)
                Me.TxtPreviousDues.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtAdvance.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtVatPercentage.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtVat.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtDiscountPercentage.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtDiscount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtNetPayable.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, 13, FontStyle.Bold)
                Me.TxtPaidAmount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, 13, FontStyle.Bold)
                Me.CmbSerialNumber.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")), FontStyle.Bold)

                Me.TxtBalance.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, 13, FontStyle.Bold)
                Me.cmbPaidBy.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtReturnAmount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, 13, FontStyle.Bold)
                Me.lblQuantityAvailable.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.lblTotalQuantityAvailable.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.lblSaleID.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.DtpSaleDate.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtFromSerial.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtToSerial.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.TxtWarrantyDays.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")), FontStyle.Bold)
                Me.TxtRemarks.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")), FontStyle.Bold)
                Me.TxtBonus.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")), FontStyle.Bold)
                Me.TxtUnitDiscount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")), FontStyle.Bold)
                Me.TxtDiscountAmount.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")), FontStyle.Bold)



                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

                Me.GrdSale.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdSale.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)

                Me.GrdProductList.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdCustomerList.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))

                Me.GrdSerialNumber.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))
                Me.GrdSerialNumber.Font = New System.Drawing.Font(dr.Item("Language Font").ToString, (dr.Item("Font Size")))


                ' Me.GrdProductList.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Regular)


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

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    'Find Branch ID For Edit Sale
    Sub FindBranchIDForEditSale()
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "select * from [Sale Invoice] join [User Account] on [Sale Invoice].[User Account ID]=[User Account].[User Account ID] where [Sale Invoice No]= '" + TxtSaleInvoiceNo.Text + "'"


            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then


                FrmHome.lblBranchID.Text = Val(dr.Item("Branch ID").ToString)


            End If

            dr.Close()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "FindBranchIDForEditSale")
        End Try

    End Sub
    'Find Current User Branch ID 
    Sub FindCurrentUserBranchID()
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "select * from [User Account] where [User Account ID]= '" + FrmHome.LblUserID.Text + "'"


            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then


                FrmHome.lblBranchID.Text = Val(dr.Item("Branch ID").ToString)


            End If

            dr.Close()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "FindCurrentUserBranchID")
        End Try

    End Sub

    Private Sub cmbProductName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbProductName.GotFocus


        If SaleEditStatus = True Then
            'Find Branch ID For Edit Sale
            FindBranchIDForEditSale()

        ElseIf Not SaleEditStatus = True Then
            'Find Current User Branch ID 
            FindCurrentUserBranchID()
        End If

        'Hide serial number gridview
        GrdSerialNumber.Visible = False


    End Sub

    Private Sub cmbProduct_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbProductName.KeyDown
        If e.KeyCode = Keys.Down Then

            GrdProductList.Visible = True

            GrdProductList.Focus()

        ElseIf e.KeyCode = Keys.Enter Then
            'Set Sale system
            Me.Text = "General Sale System"

            If CmbCustomerName.Text = "" Then

                MsgBox("Please Select Customer", MsgBoxStyle.OkOnly, "Sale")
                CmbCustomerName.Focus()
            Else


                If GrdProductList.Visible = False Then

                    'Show Product Details To Textboxes
                    ShowProductDetailsToTextboxes()


                    'Clear Data Product For add new Product
                    ' cleardataProduct()

                    'FrmListOfProductStock.Show()
                    'FrmListOfProductStock.TxtsearchProduct.Focus()
                    'FrmListOfProductStock.Label1.Text = "Sale"

                    'Available serial number columns clear
                    'GrdAvailableSerialNumber.Columns.Clear()
                Else

                    'Show product details to textbox
                    ShowProductDetailsToTextboxes()

                End If
            End If

        ElseIf e.KeyCode = Keys.Space AndAlso e.Control Then



            NetPayableAmount()

            If Val(TxtNetPayable.Text) < 0 Then
                TxtPaidAmount.Text = 0

            Else
                TxtPaidAmount.Text = Val(Me.TxtNetPayable.Text)
            End If

            TxtPaidAmount.Focus()


        ElseIf e.KeyCode = Keys.F2 Then
            'Clear Data Product
            cleardataProduct()

            'Focus on cmb Product name
            cmbProductName.Focus()

            'Available serial number columns clear
            GrdAvailableSerialNumber.Columns.Clear()


        End If



    End Sub

    Private Sub cmbProductName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbProductName.KeyPress
        'e.Handled = True
    End Sub


    Private Sub cmbProductName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbProductName.LostFocus
        If SaleEditStatus = True Then
            'Find Current User Branch ID 
            FindCurrentUserBranchID()
        End If


        'hide product list gridview
        'GrdProductList.Visible = False



    End Sub

    Private Sub TxtQuantity_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtQuantity.GotFocus
        If SaleEditStatus = True Then
            'Find Branch ID For Edit Sale
            FindBranchIDForEditSale()

        ElseIf Not SaleEditStatus = True Then
            'Find Current User Branch ID 
            FindCurrentUserBranchID()
        End If
    End Sub



    Private Sub TxtQuantity_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtQuantity.KeyDown
        If e.KeyCode = Keys.Enter Then


            If Val(TxtQuantity.Text) > Val(StockAvailableForAutoInsertQuantity) Or Val(lblQuantityAvailable.Text) = 0 Or TxtQuantity.Text = "" Or Val(TxtQuantity.Text) = 0 Then

                MsgBox("Insufficient Stock", MsgBoxStyle.Critical, "Sale")

                'Focus on quantity
                CmbSerialNumber.Focus()

            Else


                Me.TxtSaleUnitPrice.Focus()
            End If
        End If
    End Sub

    Private Sub TxtQuantity_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtQuantity.LostFocus
        If SaleEditStatus = True Then
            'Find Current User Branch ID 
            FindCurrentUserBranchID()
        End If
    End Sub

    Private Sub TxtQuantity_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TxtQuantity.MouseClick

    End Sub



    Private Sub TxtQuantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtQuantity.TextChanged
        Me.TxtDiscountAmount.Text = Val(TxtQuantity.Text) * Val(TxtUnitDiscount.Text)
        TxtSaleAmount.Text = (Val(TxtQuantity.Text) * Val(TxtSaleUnitPrice.Text)) - Val(TxtDiscountAmount.Text)
    End Sub

    'Insert data to sale 
    Sub InsertDataToSale()


        Try

            If Not cmbProductName.ValueMember = "" And RdbRangeSerial.Checked = False And Not LblStatus.Text = "Not Available" Then

                'find total inserted quantity of selected product and send to variable
                ShowTotalInsertedQuantity()

            End If


            If CmbCustomerName.Text = "" Then
                MsgBox("Please select a customer first.", MsgBoxStyle.OkOnly, "Sale")

                'Focus on Customer 'Combobox
                CmbCustomerName.Focus()

            ElseIf Val(TxtQuantity.Text) > Val(StockAvailableForAutoInsertQuantity) Or Val(lblQuantityAvailable.Text) = 0 Or TxtQuantity.Text = "" Or Val(TxtQuantity.Text) = 0 Then

                'this condition is only for adding bounus.
                If Val(TxtBonus.Text) = 0 Then

                    MsgBox("Insufficient Stock", MsgBoxStyle.Critical, "Sale")
                End If

                TxtQuantity.Focus()


                ElseIf LblStatus.Text = "Available" And Not Val(TotalInsertedSerialCount) = Val(TxtQuantity.Text) And RdbRangeSerial.Checked = False Then


                    MsgBox("Please insert serial number", MsgBoxStyle.Critical, "Sale")
                    CmbSerialNumber.Focus()


                Else

                    QuantityWritten = TxtQuantity.Text

                    'Insert or update Into Sale Invoice code
                    InsertOrUpdateIntoSaleInvoice()

                    If Not TxtSaleInvoiceNo.Text = "" Then
                        If LblStatus.Text = "Not Available" Then

                            If Val(TotalInsertedQuantity) <> Val(QuantityWritten) Then
                                'Delete From Sale
                                DeleteFromsale()

                                'find total inserted quantity of selected product and send to variable
                                ShowTotalInsertedQuantity()

                            End If

                            Do Until Val(TotalInsertedQuantity) = Val(QuantityWritten)

                                InsertIntoSaleByLoop()

                            Loop



                        ElseIf LblStatus.Text = "Available" And RdbRangeSerial.Checked = True Then


                            Do Until Val(TotalInsertedQuantity) = Val(QuantityWritten)

                                InsertIntoSaleByLoop()

                            Loop









                        ElseIf LblStatus.Text = "Available" And RdbRangeSerial.Checked = False And GrdAvailableSerialNumber.Rows.Count > 0 Then



                            'Update sale Unit Price for Loop
                            UpdateSalePriceOnLoop()

                            'Refreshdata
                            RefreshData()
                            'Else
                            'MsgBox("Please insert serial number", MsgBoxStyle.Critical, "Product Transfer")




                        End If



                        If Val(TotalInsertedQuantity) = Val(QuantityWritten) Then


                            'Update sale Unit Price for Loop
                            UpdateSalePriceOnLoop()

                            'Refreshdata
                            RefreshData()


                        End If



                    End If
                End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "InsertDataToSale")
        End Try


    End Sub


    Private Sub TxtSaleUnitPrice_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSaleUnitPrice.GotFocus

        If SaleEditStatus = True Then
            'Find Branch ID For Edit Sale
            FindBranchIDForEditSale()

        ElseIf Not SaleEditStatus = True Then
            'Find Current User Branch ID 
            FindCurrentUserBranchID()
        End If



    End Sub
    Private Sub TxtSalePrice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSaleUnitPrice.KeyDown


        If e.KeyCode = Keys.Enter Then

            Me.TxtUnitDiscount.Text = Val(TxtDiscountAmount.Text) / Val(TxtQuantity.Text)

            QuantityWrittenForBonus = TxtBonus.Text


            'Show quantity in lable
            ShowQuantityInLable()

            'Insert data to sale 
            InsertDataToSale()



            If Not TxtBonus.Text = "" And Not (Val(QuantityWrittenForBonus) + Val(TotalInsertedQuantity)) > Val(lblTotalQuantityAvailable.Text) And Not TxtSaleInvoiceNo.Text = "" Or Not Val(TxtBonus.Text) = 0 And Not (Val(QuantityWrittenForBonus) + Val(TotalInsertedQuantity)) > Val(lblTotalQuantityAvailable.Text) And Not TxtSaleInvoiceNo.Text = "" Then


                If Val(TotalInsertedBonusQuantity) <> Val(QuantityWrittenForBonus) Then
                    'Delete From Sale
                    DeleteFromsaleForBonus()

                    'Insert into sale for bonus
                    InsertIntosaleForBonus()
                End If



            End If


            'Refresh Data Products
            RefreshData()

            'Clear Data Product
            cleardataProduct()

            'Insert Or Update Into Sale Invoice()
            InsertOrUpdateIntoSaleInvoice()

        End If


    End Sub
    'Insert Into Sale For Bonus
    Sub InsertIntosaleForBonus()

        'Set 00 value to warranty days so warranty days not remain blank
        If TxtWarrantyDays.Text = "" Then
            TxtWarrantyDays.Text = "00"
        End If


        'Data Insert Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now



        Try


            'Empty Txt Box Can Not Be Save Code
            If CmbCustomerName.Text = "" Or CmbCustomerName.ValueMember = "" Or cmbProductName.ValueMember = "" Or cmbProductName.Text = "" Or TxtPurchaseID.Text = "" Then
                MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Sale")

            Else

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "DECLARE @PurchaseID INT declare @RemainingQuantity decimal(10, 2) Declare @WrittenQuantity decimal(10, 2) Declare @AddedQuantity decimal(10, 2) Declare @InsertQuantity decimal(10, 2) set @AddedQuantity=(SELECT  isnull(sum([Sale Quantity]),0)[Sale Quantity]  FROM [sale]  WHERE  [Product ID]='" + cmbProductName.ValueMember + "' And [Sale Invoice No]= '" + TxtSaleInvoiceNo.Text + "' and [Bonus Status]='Bonus')  set @WrittenQuantity='" + TxtBonus.Text + "' set @RemainingQuantity= @WrittenQuantity-@AddedQuantity while (@AddedQuantity <'" + TxtBonus.Text + "') BEGIN   set @InsertQuantity=  case when( select top 1 (isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0)) -(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))[Stock Available] from (select [Purchase].[Purchase Date],Purchase.[Purchase ID],[Supplier Information].[Supplier Name],[Products].[Product ID],[Products].[Product Name],[Branch Information].[Branch Name],[Branch Information].[Branch ID],Purchase.[Purchase Unit Cost][Purchase Cost],[Products].[Sale Price], case when [Purchase Quantity] =0  then  (select isnull(sum( [Added Quantity]),0)[Added Quantity] from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  [Product Transfer].[Purchase ID]=Purchase.[Purchase ID] and [Product Transfer].Status='Added' and   [Product Transfer Invoice].Status='Complete'  and [Product Transfer].[Product ID]=Purchase.[Product ID]  group by [Purchase ID] )   ELSE isnull([Purchase].[Purchase Quantity],0) end [Purchase] , (select isnull(sum([Sale Quantity]),0)      from  sale join [Sale Invoice] on sale.[Sale Invoice No]= [Sale Invoice].[Sale Invoice No] where Sale.[Branch ID]='" + FrmHome.lblBranchID.Text + "' and Sale.[Purchase ID]=Purchase.[Purchase ID]  group by [Purchase ID])[Sale], (select isnull(sum([Returned Quantity]),0)  from [Sale Return] join [Sale Return Invoice] on [Sale Return].[Sale Return Invoice No]=[Sale Return Invoice].[Sale Return Invoice No] where  [Sale Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Sale Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Sale Return], (select isnull(sum([Returned Quantity]),0)  from [Purchase Return] join [Purchase Return Invoice] on [Purchase Return].[Purchase Return Invoice No]=[Purchase Return Invoice].[Purchase Return Invoice No] where [Purchase Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Purchase Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Purchase Return], (select isnull(sum([Deducted Quantity]),0)  from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  Purchase.[Purchase ID]=[Product Transfer].[Purchase ID] and [Product Transfer].Status='Deducted'     group by [Purchase ID] )[Deducted] from Purchase  join Products on Purchase.[Product ID]=products.[Product ID]   join [Branch Information] on [Purchase].[Branch ID]=[Branch Information].[Branch ID]	   Join [Purchase Invoice] on [Purchase Invoice].[Purchase Invoice No]=[Purchase].[Purchase Invoice No]  join [Supplier Information] on [Purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID]  Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID]   Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID]   Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID]    where Purchase.[Branch ID]='" + FrmHome.lblBranchID.Text + "'  And products. [Product ID] = '" + Me.cmbProductName.ValueMember + "') as a   group by [Purchase Date],[Purchase ID],[Supplier Name],[Branch Name],[Product ID],[Product Name],[Purchase Cost],[Sale Price] having (isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0)) -(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0)) >0) < @RemainingQuantity then ( select top 1 (isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0)) -(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))[Stock Available] from (select [Purchase].[Purchase Date],Purchase.[Purchase ID],[Supplier Information].[Supplier Name],[Products].[Product ID],[Products].[Product Name],[Branch Information].[Branch Name],[Branch Information].[Branch ID],Purchase.[Purchase Unit Cost][Purchase Cost],[Products].[Sale Price], case when [Purchase Quantity] =0  then  (select isnull(sum( [Added Quantity]),0)[Added Quantity] from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  [Product Transfer].[Purchase ID]=Purchase.[Purchase ID] and [Product Transfer].Status='Added' and   [Product Transfer Invoice].Status='Complete'  and [Product Transfer].[Product ID]=Purchase.[Product ID]  group by [Purchase ID] )   ELSE isnull([Purchase].[Purchase Quantity],0) end [Purchase] , (select isnull(sum([Sale Quantity]),0)      from  sale join [Sale Invoice] on sale.[Sale Invoice No]= [Sale Invoice].[Sale Invoice No] where Sale.[Branch ID]='" + FrmHome.lblBranchID.Text + "' and Sale.[Purchase ID]=Purchase.[Purchase ID]  group by [Purchase ID])[Sale], (select isnull(sum([Returned Quantity]),0)  from [Sale Return] join [Sale Return Invoice] on [Sale Return].[Sale Return Invoice No]=[Sale Return Invoice].[Sale Return Invoice No] where  [Sale Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Sale Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Sale Return], (select isnull(sum([Returned Quantity]),0)  from [Purchase Return] join [Purchase Return Invoice] on [Purchase Return].[Purchase Return Invoice No]=[Purchase Return Invoice].[Purchase Return Invoice No] where [Purchase Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Purchase Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Purchase Return], (select isnull(sum([Deducted Quantity]),0)  from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  Purchase.[Purchase ID]=[Product Transfer].[Purchase ID] and [Product Transfer].Status='Deducted'     group by [Purchase ID] )[Deducted] from Purchase  join Products on Purchase.[Product ID]=products.[Product ID]   join [Branch Information] on [Purchase].[Branch ID]=[Branch Information].[Branch ID]	   Join [Purchase Invoice] on [Purchase Invoice].[Purchase Invoice No]=[Purchase].[Purchase Invoice No]  join [Supplier Information] on [Purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID]  Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID]   Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID]   Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID]    where Purchase.[Branch ID]='" + FrmHome.lblBranchID.Text + "'  And products. [Product ID] = '" + Me.cmbProductName.ValueMember + "') as a   group by [Purchase Date],[Purchase ID],[Supplier Name],[Branch Name],[Product ID],[Product Name],[Purchase Cost],[Sale Price] having (isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0)) -(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0)) >0) else @RemainingQuantity end   set @PurchaseID = (select top 1 [Purchase ID] from (select [Purchase].[Purchase Date],Purchase.[Purchase ID],[Supplier Information].[Supplier Name],[Products].[Product ID],[Products].[Product Name],[Branch Information].[Branch Name],[Branch Information].[Branch ID],Purchase.[Purchase Unit Cost][Purchase Cost],[Products].[Sale Price], case when [Purchase Quantity] =0  then  (select isnull(sum( [Added Quantity]),0)[Added Quantity] from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  [Product Transfer].[Purchase ID]=Purchase.[Purchase ID] and [Product Transfer].Status='Added' and   [Product Transfer Invoice].Status='Complete'  and [Product Transfer].[Product ID]=Purchase.[Product ID]  group by [Purchase ID] )   ELSE isnull([Purchase].[Purchase Quantity],0) end [Purchase] , (select isnull(sum([Sale Quantity]),0)      from  sale join [Sale Invoice] on sale.[Sale Invoice No]= [Sale Invoice].[Sale Invoice No] where Sale.[Branch ID]='" + FrmHome.lblBranchID.Text + "' and Sale.[Purchase ID]=Purchase.[Purchase ID]  group by [Purchase ID])[Sale], (select isnull(sum([Returned Quantity]),0)  from [Sale Return] join [Sale Return Invoice] on [Sale Return].[Sale Return Invoice No]=[Sale Return Invoice].[Sale Return Invoice No] where  [Sale Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Sale Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Sale Return], (select isnull(sum([Returned Quantity]),0)  from [Purchase Return] join [Purchase Return Invoice] on [Purchase Return].[Purchase Return Invoice No]=[Purchase Return Invoice].[Purchase Return Invoice No] where [Purchase Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Purchase Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Purchase Return], (select isnull(sum([Deducted Quantity]),0)  from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  Purchase.[Purchase ID]=[Product Transfer].[Purchase ID] and [Product Transfer].Status='Deducted'     group by [Purchase ID] )[Deducted] from Purchase  join Products on Purchase.[Product ID]=products.[Product ID]   join [Branch Information] on [Purchase].[Branch ID]=[Branch Information].[Branch ID]	   Join [Purchase Invoice] on [Purchase Invoice].[Purchase Invoice No]=[Purchase].[Purchase Invoice No]  join [Supplier Information] on [Purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID]  Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID]   Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID]   Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID]    where Purchase.[Branch ID]='" + FrmHome.lblBranchID.Text + "'  And products. [Product ID] = '" + Me.cmbProductName.ValueMember + "') as a   group by [Purchase Date],[Purchase ID],[Supplier Name],[Branch Name],[Product ID],[Product Name],[Purchase Cost],[Sale Price] having (isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0)) -(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0)) >0) INSERT INTO [Sale] ([Sale Invoice No],[Product ID],[Sale Quantity],[Sale Unit Price],[Sale Amount],[Purchase ID],[Branch ID],[Computer ID],[User Account ID],[Bonus Status])    VALUES ('" + TxtSaleInvoiceNo.Text + "','" + cmbProductName.ValueMember + "',@InsertQuantity,'00','00',@purchaseID,'" + FrmHome.lblBranchID.Text + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','Bonus')  	  set @AddedQuantity= (SELECT  isnull(sum([Sale Quantity]),0)[Sale Quantity]  FROM [sale]  WHERE  [Product ID]='" + cmbProductName.ValueMember + "' And [Sale Invoice No]= '" + TxtSaleInvoiceNo.Text + "' and [Bonus Status]='Bonus') set @RemainingQuantity= (@WrittenQuantity - @AddedQuantity) END  "
                cmd.ExecuteNonQuery()
                con.Close()
            End If


        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "InsertOrUpdate Records")
        Finally


        End Try



    End Sub

  

    Private Sub TxtSaleUnitPrice_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSaleUnitPrice.LostFocus
        If SaleEditStatus = True Then
            'Find Current User Branch ID 
            FindCurrentUserBranchID()
        End If
    End Sub

    Private Sub TxtSaleUnitPrice_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TxtSaleUnitPrice.MouseClick

    End Sub


    Private Sub TxtSalePrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSaleUnitPrice.TextChanged

        TxtSaleAmount.Text = (Val(TxtQuantity.Text) * Val(TxtSaleUnitPrice.Text)) - Val(TxtDiscountAmount.Text)
    End Sub
    Private Sub BtnCustomerName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCustomerName.Click
        FrmCustomerInformation.Show()


        'show status= connected and sms notification= on 
        FrmCustomerInformation.CmbStatus.SelectedIndex = 0
        FrmCustomerInformation.CmbSmsNotification.SelectedIndex = 0
        FrmCustomerInformation.TxtDiscountPercentage.Text = "0"


        FrmCustomerInformation.CmbCustomerName.Focus()
        FrmCustomerInformation.LblFormName.Text = "Sale"

    End Sub
    Private Sub CmbCustomerName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbCustomerName.KeyDown

        If e.KeyCode = Keys.Enter Then

            'Show Customer Details In Textboxs
            ShowCustomerDetailsInTextboxs()

            TxtPhoneNo.Focus()


        ElseIf e.KeyCode = Keys.Down Then

            'Resize Customer GridView And Make it Visible()
            ResizeCustomerGridViewAndMakeitVisible()

            'Search By Customer Name For Current Branch
            SearchByCustomerNameForCurrentBranch()


            GrdCustomerList.Visible = True

            GrdCustomerList.Focus()
        End If



    End Sub


    'Privet sub for customer information
    Sub customerInformation()
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT * from [Customer Information] Left join [Chart of Account] on [Customer Information].[Chart of Account ID]=[Chart of Account].[Chart of Account ID]  WHERE [Customer ID] = '" + CmbCustomerName.ValueMember + "'"


            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then


                Me.TxtPhoneNo.Text = dr.Item("Mobile No").ToString
                Me.TxtAddress.Text = dr.Item("Address").ToString
                Me.TxtCustomerDiscount.Text = dr.Item("Discount Percentage").ToString
                Me.TxtDiscountPercentage.Text = dr.Item("Discount Percentage").ToString
                TransactionLimit = dr.Item("Transaction Limit").ToString
                CustomerChartofAccountID = dr.Item("Chart of Account ID").ToString

            ElseIf Not dr.HasRows Then

                MsgBox("No Customer Found")

                cleardataProduct()

            End If

            dr.Close()
            con.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtPurchaseInvoice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPurchaseID.KeyDown
        'Focus on quantity  Text box
        If e.KeyCode = Keys.Enter Then
            Me.TxtQuantity.Focus()

        End If
    End Sub


    Private Sub TxtPurchaseInvoice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPurchaseID.TextChanged

    End Sub

    Private Sub TxtAmount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSaleAmount.KeyDown

        If e.KeyCode = Keys.Enter Then

            TxtSaleUnitPrice.Focus()

        End If


    End Sub

    Private Sub TxtAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSaleAmount.TextChanged



    End Sub


    'Insert or update Into Sale Invoice code
    Sub InsertOrUpdateIntoSaleInvoice()

        'Insert Into Sale Invoice code
        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim con2 As New SqlConnection
            Dim cmd2 As New SqlCommand
            Dim dr1 As SqlDataReader

            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now



            'InsertinotCustomer
            InsertIntoCustomer()


            If TxtSaleInvoiceNo.Text = "" Then

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "INSERT INTO [Sale Invoice] ([Total],[Previous Dues],[Advance],[Vat percentage],[Vat],[Discount Percentage],[Discount],[Net Payable],[Paid Amount],[Balance],[Return Amount],[Status],[Customer ID],[Sale Date],[Sale Time],[User Account ID],[Computer ID],[Paid By],[Prepared Date],[Remarks]) values ('" + TxtTotal.Text + "','" + TxtPreviousDues.Text + "','" + TxtAdvance.Text + "','" + TxtVatPercentage.Text + "','" + TxtVat.Text + "','" + TxtDiscountPercentage.Text + "','" + TxtDiscount.Text + "','" + TxtNetPayable.Text + "','" + TxtPaidAmount.Text + "','" + TxtBalance.Text + "','" + TxtReturnAmount.Text + "','INCOMPLETE','" + CmbCustomerName.ValueMember + "','" + DtpSaleDate.Value + "','" + currentTime + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + cmbPaidBy.SelectedValue.ToString + "','" + currentDate + "','" + TxtRemarks.Text + "')"
                cmd.ExecuteNonQuery()
                con.Close()


                con2.ConnectionString = FrmHome.ConnectionString
                con2.Open()
                cmd2.Connection = con2
                cmd2.CommandText = "SELECT top 1 [Sale Invoice No] FROM [Sale Invoice] where [User Account ID]= '" + FrmHome.LblUserID.Text + "'  order by [Sale Invoice No] desc"

                dr1 = cmd2.ExecuteReader()
                dr1.Read()
                If dr1.HasRows Then

                    TxtSaleInvoiceNo.Text = (dr1.Item("Sale Invoice No").ToString)

                End If
                con2.Close()
                dr1.Close()


            Else





                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "UPDATE  [Sale Invoice] SET [Total]='" + TxtTotal.Text + "',[Previous Dues]='" + TxtPreviousDues.Text + "',[Advance]='" + TxtAdvance.Text + "',[Vat percentage]='" + TxtVatPercentage.Text + "',[Vat]='" + TxtVat.Text + "',[Discount Percentage]='" + TxtDiscountPercentage.Text + "',[Discount]='" + TxtDiscount.Text + "',[Net Payable]='" + TxtNetPayable.Text + "',[Paid Amount]='" + TxtPaidAmount.Text + "',[Balance]='" + TxtBalance.Text + "',[Return Amount]='" + TxtReturnAmount.Text + "',[Sale Time]= '" + currentTime + "', [Sale Date]= '" + DtpSaleDate.Value + "',[Customer ID]='" + CmbCustomerName.ValueMember + "',[Status]='INCOMPLETE',[Remarks]='" + TxtRemarks.Text + "' where [Sale Invoice No] = '" + TxtSaleInvoiceNo.Text + "' "
                cmd.ExecuteNonQuery()
                con.Close()


            End If

        Catch ex As Exception
            MessageBox.Show("Error while Inserting to sale invoice record on table..." & ex.Message, "Insert Records Sale Invoice")
        Finally

        End Try



    End Sub

    'Insert Into Sale
    Sub InsertIntosale()

        'Set 00 value to warranty days so warranty days not remain blank
        If TxtWarrantyDays.Text = "" Then
            TxtWarrantyDays.Text = "00"
        End If


        'Data Insert Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now



        Try


            'Empty Txt Box Can Not Be Save Code
            If Not CmbCustomerName.Text = "" Or Not CmbCustomerName.ValueMember = "" Or Not cmbProductName.ValueMember = "" Or Not cmbProductName.Text = "" Or Not TxtPurchaseID.Text = "" Or Not TxtQuantity.Text = "" Or Not TxtSaleUnitPrice.Text = "" Or Not TxtSaleAmount.Text = "" Then



                con.ConnectionString = FrmHome.ConnectionString
                con.Open()



                cmd.Connection = con
                cmd.CommandText = "INSERT INTO [Sale] ([Sale Invoice No],[Product ID],[Sale Quantity],[Sale Unit Price],[Sale Amount],[Purchase ID],[Branch ID],[Computer ID],[User Account ID],[Sale Serial Number],[Warranty Days],[Bonus Status],[Unit Discount],[Discount Amount]) VALUES ('" + TxtSaleInvoiceNo.Text + "','" + cmbProductName.ValueMember + "','" + TxtQuantity.Text + "','" + TxtSaleUnitPrice.Text + "','" + TxtSaleAmount.Text + "','" + TxtPurchaseID.Text + "','" + FrmHome.lblBranchID.Text + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + TxtFromSerial.Text + "-" + TxtToSerial.Text + "','" + TxtWarrantyDays.Text + "','None','" + TxtUnitDiscount.Text + "','" + TxtDiscountAmount.Text + "')"
                cmd.ExecuteNonQuery()
                con.Close()
            End If


        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "InsertOrUpdate Records")
        Finally


        End Try



    End Sub
    'Delete From Sale
    Sub DeleteFromsale()

        'Set 00 value to warranty days so warranty days not remain blank
        If TxtWarrantyDays.Text = "" Then
            TxtWarrantyDays.Text = "00"
        End If


        'Data Insert Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now



        Try


            'Empty Txt Box Can Not Be Save Code
            If CmbCustomerName.Text = "" Or CmbCustomerName.ValueMember = "" Or cmbProductName.ValueMember = "" Or cmbProductName.Text = "" Or TxtPurchaseID.Text = "" Or TxtQuantity.Text = "" Or TxtSaleUnitPrice.Text = "" Or TxtSaleAmount.Text = "" Then
                MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Sale")

            Else

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()



                cmd.Connection = con
                cmd.CommandText = "delete from sale where [Sale Invoice No]= '" + TxtSaleInvoiceNo.Text + "' and [Product ID]='" + cmbProductName.ValueMember + "' and not [Bonus Status]='Bonus'"
                cmd.ExecuteNonQuery()
                con.Close()
            End If


        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "InsertOrUpdate Records")
        Finally


        End Try



    End Sub
    'Delete From Sale Bonus
    Sub DeleteFromsaleForBonus()

        'Set 00 value to warranty days so warranty days not remain blank
        If TxtWarrantyDays.Text = "" Then
            TxtWarrantyDays.Text = "00"
        End If


        'Data Insert Code
        Dim con As New SqlConnection
        Dim con1 As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now
        Dim dr As SqlDataReader


        Try


            'Empty Txt Box Can Not Be Save Code
            If CmbCustomerName.Text = "" Or CmbCustomerName.ValueMember = "" Or cmbProductName.ValueMember = "" Or cmbProductName.Text = "" Or TxtPurchaseID.Text = "" Or TxtQuantity.Text = "" Or TxtSaleUnitPrice.Text = "" Or TxtSaleAmount.Text = "" Then
                'MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Sale")

            Else
                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd1.CommandText = "Select * from sale where [Sale Invoice No]= '" + TxtSaleInvoiceNo.Text + "' and [Product ID]='" + cmbProductName.ValueMember + "' and  [Bonus Status]='Bonus'"
                dr = cmd1.ExecuteReader
                dr.Read()
                If dr.HasRows Then

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "delete from sale where [Sale Invoice No]= '" + TxtSaleInvoiceNo.Text + "' and [Product ID]='" + cmbProductName.ValueMember + "' and  [Bonus Status]='Bonus'"
                    cmd.ExecuteNonQuery()
                    con.Close()

                End If
                dr.Close()
                con1.Close()

            End If


        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "InsertOrUpdate Records")
        Finally


        End Try

    End Sub


    Sub InsertOrUpdatesale()

        'Set 00 value to warranty days so warranty days not remain blank
        If TxtWarrantyDays.Text = "" Then
            TxtWarrantyDays.Text = "00"
        End If

        If lblSaleID.Text = "00" Then

            'Data Insert Code
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
      
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now



            Try


                'Empty Txt Box Can Not Be Save Code
                If CmbCustomerName.Text = "" Or CmbCustomerName.ValueMember = "" Or cmbProductName.ValueMember = "" Or cmbProductName.Text = "" Or TxtPurchaseID.Text = "" Or TxtQuantity.Text = "" Or TxtSaleUnitPrice.Text = "" Or TxtSaleAmount.Text = "" Then
                    MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Sale")

                Else

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO [Sale] ([Sale Invoice No],[Product ID],[Sale Quantity],[Sale Unit Price],[Sale Amount],[Purchase ID],[Branch ID],[Computer ID],[User Account ID],[Sale Serial Number],[Warranty Days],[Bonus Status],[Unit Discount],[Discount Amount]) VALUES ('" + TxtSaleInvoiceNo.Text + "','" + cmbProductName.ValueMember + "','" + TxtQuantity.Text + "','" + TxtSaleUnitPrice.Text + "','" + TxtSaleAmount.Text + "','" + TxtPurchaseID.Text + "','" + FrmHome.lblBranchID.Text + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + TxtFromSerial.Text + "-" + TxtToSerial.Text + "','" + TxtWarrantyDays.Text + "','None','" + TxtUnitDiscount.Text + "','" + TxtDiscountAmount.Text + "')"
                    cmd.ExecuteNonQuery()

                    con.Close()
                End If


            Catch ex As Exception
                MessageBox.Show("Error while inserting record on table..." & ex.Message, "InsertOrUpdate Records")
            Finally


            End Try

        Else




            'Data Update Code
            Dim con As New SqlConnection
            Dim cmd2 As New SqlCommand
    

            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now

            Try

                If CmbCustomerName.Text = "" Or CmbCustomerName.ValueMember = "" Or cmbProductName.ValueMember = "" Or cmbProductName.Text = "" Or TxtPurchaseID.Text = "" Or TxtQuantity.Text = "" Or TxtSaleUnitPrice.Text = "" Or TxtSaleAmount.Text = "" Then
                    MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Sale")

                Else
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd2.Connection = con
                    cmd2.CommandText = "UPDATE [Sale] SET [Sale Invoice No]= '" + TxtSaleInvoiceNo.Text + "',[Product ID]= '" + cmbProductName.ValueMember + "',[Sale Quantity]= '" + TxtQuantity.Text + "',[Sale Unit Price]= '" + TxtSaleUnitPrice.Text + "',[Sale Amount]= '" + TxtSaleAmount.Text + "', [Purchase ID]= '" + TxtPurchaseID.Text + "',[Branch ID]= '" + FrmHome.lblBranchID.Text + "',[Computer ID]= '" + FrmHome.LblComputerID.Text + "',[User Account ID]= '" + FrmHome.LblUserID.Text + "',[Sale Serial Number]='" + CmbSerialNumber.Text + "',[Warranty Days]='" + TxtWarrantyDays.Text + "',[Unit Discount]='" + TxtUnitDiscount.Text + "',[Discount Amount]='" + TxtDiscountAmount.Text + "' WHERE [Sale ID]= '" + lblSaleID.Text + "'"
                    cmd2.ExecuteNonQuery()
                    con.Close()

                End If
            Catch ex As Exception
                MessageBox.Show("Error while Updating record on table..." & ex.Message, "Update Records")
            Finally

            End Try


        End If

    End Sub

    'Update sale Unit Price for Loop
    Sub UpdateSalePriceOnLoop()

        Try
            'Data Update Code
            Dim con As New SqlConnection
            Dim cmd2 As New SqlCommand

            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now

            Dim CalculatedSalePrice As String = Val(TxtSaleUnitPrice.Text) - Val(TxtUnitDiscount.Text)


            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd2.Connection = con
            cmd2.CommandText = "UPDATE [Sale] SET [Sale Unit Price]= '" + TxtSaleUnitPrice.Text + "', [Warranty Days]= '" + TxtWarrantyDays.Text + "', [Sale Amount]=  '" + CalculatedSalePrice + "' *[Sale Quantity],[Unit Discount] = '" + TxtUnitDiscount.Text + "',[Discount Amount] = '" + TxtDiscountAmount.Text + "'  WHERE  [Product ID]= '" + cmbProductName.ValueMember + "' and [Sale Invoice No]='" + TxtSaleInvoiceNo.Text + "' and not [Bonus Status]='Bonus' "
            cmd2.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "UpdateSalePriceOnLoop")
        End Try
    End Sub
    Private Sub GrdSale_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdSale.CellContentClick

    End Sub


    'find total inserted quantity of selected product and send to variable
    Sub ShowTotalInsertedQuantity()

        Try
            Dim con As New SqlConnection
            Dim cmd1 As New SqlCommand
            Dim dr1 As SqlDataReader

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd1.Connection = con
            cmd1.CommandText = "select isnull(sum([sale quantity]),0)[Total],[Sale Unit Price] from sale where [Sale Invoice No]= '" + TxtSaleInvoiceNo.Text + "' and [Product ID]='" + cmbProductName.ValueMember + "' and not [Bonus Status]='Bonus' group by [Sale Unit Price]"

            dr1 = cmd1.ExecuteReader()
            dr1.Read()
            If dr1.HasRows Then


                TotalInsertedQuantity = (Val(dr1.Item("Total").ToString))
                TxtQuantity.Text = (Val(dr1.Item("Total").ToString))

                If Val(TxtSaleUnitPrice.Text) = 0 Then
                    TxtSaleUnitPrice.Text = (Val(dr1.Item("Sale Unit Price").ToString))
                End If

            End If
            dr1.Close()
            con.Close()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "ShowTotalInsertedQuantity")
        End Try
    End Sub

    'find total Bonus inserted quantity of selected product and send to variable
    Sub ShowTotalBonusInsertedQuantity()

        Try
            Dim con As New SqlConnection
            Dim cmd1 As New SqlCommand
            Dim dr1 As SqlDataReader

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd1.Connection = con
            cmd1.CommandText = "select isnull(sum([sale quantity]),0)[Bonus] from sale where [Sale Invoice No]= '" + TxtSaleInvoiceNo.Text + "' and [Product ID]='" + cmbProductName.ValueMember + "' and [Bonus Status]='Bonus'"

            dr1 = cmd1.ExecuteReader()
            dr1.Read()
            If dr1.HasRows Then



                TxtBonus.Text = (Val(dr1.Item("Bonus").ToString))
                TotalInsertedBonusQuantity = (Val(dr1.Item("Bonus").ToString))
            End If
            dr1.Close()
            con.Close()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "ShowTotalBonusInsertedQuantity")
        End Try
    End Sub

    'find total inserted  Serial Of Specific Product
    Sub ShowTotalInsertedSerialOfSpecificProduct()

        Try
            Dim con As New SqlConnection
            Dim cmd1 As New SqlCommand
            Dim dr1 As SqlDataReader

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd1.Connection = con
            cmd1.CommandText = "select count ([Sale Serial Number])[Total] from [Sale Serial Number] where [Sale Invoice No]= '" + TxtSaleInvoiceNo.Text + "' and [Product ID]='" + cmbProductName.ValueMember + "'"

            dr1 = cmd1.ExecuteReader()
            dr1.Read()
            If dr1.HasRows Then


                TotalInsertedSerialCount = (Val(dr1.Item("Total").ToString))
            End If
            dr1.Close()
            con.Close()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "ShowTotalInsertedSerialOfSpecificProduct")
        End Try
    End Sub

    Private Sub GrdSale_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdSale.CellMouseClick

        Try
            If e.RowIndex >= 0 Then

                Dim row As DataGridViewRow
                row = Me.GrdSale.Rows(e.RowIndex)

                lblSaleID.Text = row.Cells("Sale ID").Value.ToString
                cmbProductName.Text = row.Cells("Product Name").Value.ToString
                'TxtQuantity.Text = row.Cells("Quantity").Value.ToString
                TxtPurchaseID.Text = row.Cells("Purchase ID").Value.ToString
                TxtSaleUnitPrice.Text = Double.Parse(row.Cells("Sale Unit Price").Value.ToString).ToString
                TxtSaleAmount.Text = Double.Parse(row.Cells("Sale Amount").Value.ToString).ToString
                TxtWarrantyDays.Text = row.Cells("Warranty Days").Value.ToString

                TxtUnitDiscount.Text = Double.Parse(row.Cells("Unit Discount").Value.ToString).ToString
                TxtDiscountAmount.Text = Double.Parse(row.Cells("Discount Amount").Value.ToString).ToString


                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim cmd1 As New SqlCommand
                Dim dr As SqlDataReader

                'Data reader for Product Id
                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "SELECT  *FROM [sale]  WHERE [Sale ID] = '" + lblSaleID.Text + "'"
                dr = cmd.ExecuteReader()
                dr.Read()
                If dr.HasRows Then


                    Me.cmbProductName.ValueMember = (dr.Item("Product ID").ToString)
                End If
                dr.Close()
                con.Close()

                'Sale Edit detection
                If SaleEditStatus = True Then
                    'Find Branch ID For Edit Sale
                    FindBranchIDForEditSale()

                ElseIf Not SaleEditStatus = True Then
                    'Find Current User Branch ID 
                    FindCurrentUserBranchID()
                End If


                'Show Available stock to lable
                ShowQuantityInLable()

                'find total inserted quantity of selected product and send to variable
                ShowTotalInsertedQuantity()


                'find total Bonus inserted quantity of selected product and send to variable
                ShowTotalBonusInsertedQuantity()

                'find total inserted  Serial Of Specific Product
                ShowTotalInsertedSerialOfSpecificProduct()

                'Focus on product name
                cmbProductName.Focus()

                'Refresh Data Serial Number To Gridview  Click
                RefreshDataSerialNumberToGridviewForCellMouseClick()

                'Show Serial Number Status
                SearchSerialStatus()

                'Load Combo Box for Serial Number
                'LoadComboBoxforSerialNumber()


                'Find Last Sold Product Price
                FindLastSoldProductPrice()



            End If

        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records Gridview")

        End Try


    End Sub

    'Find Last Sold Product Price
    Sub FindLastSoldProductPrice()


        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader



            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "select top 1 * from sale join [Sale Invoice] on Sale.[Sale Invoice No] =[Sale Invoice].[Sale Invoice No] where [sale].[Product ID]='" + cmbProductName.ValueMember + "' and [Sale Invoice].[Customer ID]='" + CmbCustomerName.ValueMember + "' order by [Sale Date] desc"

            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then


                LblLastSoldPrice.Text = (Val(dr.Item("Sale Unit Price").ToString))
            ElseIf Not dr.HasRows Then
                LblLastSoldPrice.Text = "No record found"

            End If

            dr.Close()
            con.Close()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "FindLastSoldProductPrice")
        End Try
    End Sub

    'Show Available stock to lable
    Sub ShowQuantityInLable()


        Try
            Dim con As New SqlConnection
            Dim cmd1 As New SqlCommand
            Dim cmd2 As New SqlCommand
            Dim cmd As New SqlCommand
            Dim dr1 As SqlDataReader
            Dim dr2 As SqlDataReader
            Dim dr As SqlDataReader



            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd1.Connection = con
            cmd1.CommandText = "select [Purchase Date],[Purchase ID],[Supplier Name],[Product ID],[Product Name],[Branch Name],[Purchase Cost],[Sale Price],(isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))[Stock Available]from (select [Purchase].[Purchase Date],Purchase.[Purchase ID],[Supplier Information].[Supplier Name],[Products].[Product ID],[Products].[Product Name],[Branch Information].[Branch Name],[Branch Information].[Branch ID],Purchase.[Purchase Unit Cost][Purchase Cost],[Products].[Sale Price],case when [Purchase Quantity] =0  then (select isnull(sum( [Added Quantity]),0)[Added Quantity] from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  [Product Transfer].[Purchase ID]=Purchase.[Purchase ID] and [Product Transfer].Status='Added' and   [Product Transfer Invoice].Status='Complete'  and [Product Transfer].[Product ID]=Purchase.[Product ID]  group by [Purchase ID] )  ELSE isnull([Purchase].[Purchase Quantity],0) end [Purchase] ,(select isnull(sum([Sale Quantity]),0)      from  sale join [Sale Invoice] on sale.[Sale Invoice No]= [Sale Invoice].[Sale Invoice No] where Sale.[Branch ID]='" + FrmHome.lblBranchID.Text + "' and Sale.[Purchase ID]=Purchase.[Purchase ID]  group by [Purchase ID])[Sale],(select isnull(sum([Returned Quantity]),0)  from [Sale Return] join [Sale Return Invoice] on [Sale Return].[Sale Return Invoice No]=[Sale Return Invoice].[Sale Return Invoice No] where  [Sale Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Sale Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Sale Return],(select isnull(sum([Returned Quantity]),0)  from [Purchase Return] join [Purchase Return Invoice] on [Purchase Return].[Purchase Return Invoice No]=[Purchase Return Invoice].[Purchase Return Invoice No] where [Purchase Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Purchase Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Purchase Return], (select isnull(sum([Deducted Quantity]),0)  from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  Purchase.[Purchase ID]=[Product Transfer].[Purchase ID] and [Product Transfer].Status='Deducted'     group by [Purchase ID] )[Deducted]from Purchase  join Products on Purchase.[Product ID]=products.[Product ID]  join [Branch Information] on [Purchase].[Branch ID]=[Branch Information].[Branch ID]	  Join [Purchase Invoice] on [Purchase Invoice].[Purchase Invoice No]=[Purchase].[Purchase Invoice No] join [Supplier Information] on [Purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID] Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID]  Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID]  Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID]    where Purchase.[Branch ID]='" + FrmHome.lblBranchID.Text + "' And Purchase.[Purchase ID] = '" + Me.TxtPurchaseID.Text + "' and products. [Product ID] = '" + Me.cmbProductName.ValueMember + "' ) as a  group by [Purchase Date],[Purchase ID],[Supplier Name],[Branch Name],[Product ID],[Product Name],[Purchase Cost],[Sale Price] having (isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))>=0"

            dr1 = cmd1.ExecuteReader()
            dr1.Read()
            If dr1.HasRows Then


                lblQuantityAvailable.Text = (Val(dr1.Item("Stock Available").ToString) + Val(TxtQuantity.Text))
            End If
            dr1.Close()
            con.Close()

            'Finding out total quantity sold
            con.Open()
            cmd2.Connection = con
            cmd2.CommandText = "select    isnull(sum([Sale Quantity]),0)[Sale Quantity] from  [Sale] where [Product ID]='" + cmbProductName.ValueMember + "' and [Sale Invoice No]='" + TxtSaleInvoiceNo.Text + "'"

            dr2 = cmd2.ExecuteReader()
            dr2.Read()

            If dr2.HasRows Then
                TotalSoldQuantity = dr2.Item("Sale Quantity").ToString
            End If
            dr2.Close()
            con.Close()

            'Show total quantity to label and set total stock available to variable
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "select isnull(sum([Stock Available]),0)[Stock Available]  from (select [Purchase Date],[Purchase ID],[Supplier Name],[Product ID],[Product Name],[Branch Name],[Purchase Cost],[Sale Price],(isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))[Stock Available]from (select [Purchase].[Purchase Date],Purchase.[Purchase ID],[Supplier Information].[Supplier Name],[Products].[Product ID],[Products].[Product Name],[Branch Information].[Branch Name],[Branch Information].[Branch ID],Purchase.[Purchase Unit Cost][Purchase Cost],[Products].[Sale Price],case when [Purchase Quantity] =0  then (select isnull(sum( [Added Quantity]),0)[Added Quantity] from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  [Product Transfer].[Purchase ID]=Purchase.[Purchase ID] and [Product Transfer].Status='Added' and   [Product Transfer Invoice].Status='Complete'  and [Product Transfer].[Product ID]=Purchase.[Product ID]  group by [Purchase ID] )  ELSE isnull([Purchase].[Purchase Quantity],0) end [Purchase] ,(select isnull(sum([Sale Quantity]),0)      from  sale join [Sale Invoice] on sale.[Sale Invoice No]= [Sale Invoice].[Sale Invoice No] where Sale.[Branch ID]='" + FrmHome.lblBranchID.Text + "' and Sale.[Purchase ID]=Purchase.[Purchase ID]  group by [Purchase ID])[Sale],(select isnull(sum([Returned Quantity]),0)  from [Sale Return] join [Sale Return Invoice] on [Sale Return].[Sale Return Invoice No]=[Sale Return Invoice].[Sale Return Invoice No] where  [Sale Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Sale Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Sale Return],(select isnull(sum([Returned Quantity]),0)  from [Purchase Return] join [Purchase Return Invoice] on [Purchase Return].[Purchase Return Invoice No]=[Purchase Return Invoice].[Purchase Return Invoice No] where [Purchase Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Purchase Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Purchase Return], (select isnull(sum([Deducted Quantity]),0)  from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  Purchase.[Purchase ID]=[Product Transfer].[Purchase ID] and [Product Transfer].Status='Deducted'     group by [Purchase ID] )[Deducted]from Purchase  join Products on Purchase.[Product ID]=products.[Product ID]  join [Branch Information] on [Purchase].[Branch ID]=[Branch Information].[Branch ID]	  Join [Purchase Invoice] on [Purchase Invoice].[Purchase Invoice No]=[Purchase].[Purchase Invoice No]  join [Supplier Information] on [Purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID]  Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID]   Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID]   Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID]    where Purchase.[Branch ID]='" + FrmHome.lblBranchID.Text + "' and products. [Product ID] = '" + Me.cmbProductName.ValueMember + "') as a   group by [Purchase Date],[Purchase ID],[Supplier Name],[Branch Name],[Product ID],[Product Name],[Purchase Cost],[Sale Price] having (isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0)) -(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0)) >=0 ) as a "

            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then


                lblTotalQuantityAvailable.Text = (Val(dr.Item("stock Available").ToString) + Val(TotalSoldQuantity))
                StockAvailableForAutoInsertQuantity = (Val(dr.Item("stock Available").ToString) + Val(TotalSoldQuantity))
            End If

            dr.Close()
            con.Close()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "ShowQuantityInLable")
        End Try
    End Sub


    Private Sub CmbCustomerName_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbCustomerName.SelectedValueChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub TxtTotal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTotal.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtVatPercentage.Focus()
        End If
    End Sub




    Private Sub TxtTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTotal.TextChanged

    End Sub

    Private Sub BtnAddProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GrdSale_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdSale.CellMouseDoubleClick



        Try

            
            If Me.lblSaleID.Text = "" Then
                MsgBox("Please select a row", MsgBoxStyle.OkOnly, "sale")

            Else


                'Data Delete Code
                Dim q As MsgBoxResult
                q = MsgBox("Do you really want to Delete the row?", MsgBoxStyle.YesNo, "Sale")
                If q = MsgBoxResult.Yes Then

                    Dim con As New SqlConnection
                    Dim cmd As New SqlCommand
                    Dim currentDate As DateTime = DateTime.Today
                    Dim currentTime As DateTime = DateTime.Now

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "Delete from [Sale] where [Sale ID]= '" + lblSaleID.Text + "'"
                    cmd.ExecuteNonQuery()
                    con.Close()





                    'Update And Delete Into Purchase And Sale Serial Number
                    UpdateAndDeleteIntoPurchaseAndSaleSerialNumber()


                    'Refresh Data Serial Number To Gridview  Click
                    RefreshDataSerialNumberToGridviewForCellMouseClick()

                    'Refresh Data
                    RefreshData()

                    'Insert or update Into Sale Invoice to show correct value to amount field in report
                    InsertOrUpdateIntoSaleInvoice()


                    'Making Clear
                    cleardataProduct()

                    'focus on product textbox
                    cmbProductName.Focus()

                    'Serial Number Show if available
                    'LoadComboBoxforSerialNumber()

                End If
            End If

         

        Catch ex As Exception
            MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Records")
        Finally

        End Try





    End Sub

    'Update Purchase Serial Number From Sold To Available
    Sub UpdatePurchaseSerialNumberFromSoldToAvailable()




        Try

            Dim con As New SqlConnection
            Dim con1 As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd2 As New SqlCommand
     
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now

            Dim dr As SqlDataReader

            Dim total As String = 0

            For i As Integer = 0 To GrdAvailableSerialNumber.RowCount - 1
                total += GrdAvailableSerialNumber.Rows(i).Cells(0).Value & GrdAvailableSerialNumber.Rows(i).Cells(1).Value

                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd2.Connection = con1
                cmd2.CommandText = "SELECT *from [Purchase Serial Number] where [Product ID]= '" + GrdAvailableSerialNumber.Rows(i).Cells(0).Value.ToString + "' And [Purchase Serial Number]='" + GrdAvailableSerialNumber.Rows(i).Cells(1).Value.ToString + "' And [Status]='Sold' And [Branch ID]='" + FrmHome.lblBranchID.Text + "' "

                dr = cmd2.ExecuteReader()
                dr.Read()

                If dr.HasRows Then
                    PurchaseInvoiceNo = dr.Item("Purchase Invoice No").ToString

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "Update [Purchase Serial Number] set  [Status]='Available'  where [Product ID]= '" + GrdAvailableSerialNumber.Rows(i).Cells(0).Value.ToString + "' And [Purchase Serial Number]= '" + GrdAvailableSerialNumber.Rows(i).Cells(1).Value.ToString + "' "
                    cmd.ExecuteNonQuery()
                    con.Close()
                End If
                dr.Close()
                con1.Close()

            Next

        Catch ex As Exception
            MessageBox.Show("Error while Updating record on table..." & ex.Message, "Update Records Purchase Serial")
        Finally

        End Try
        'Update Purchase Invoice
    End Sub

    'Refresh Data Serial Number To Gridview For Delete Button
    Sub RefreshDataSerialNumberToGridviewForDeleteButton()

        ' Load Data
        Try


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT   [Sale Serial Number].[Product ID],[Sale Serial Number].[Sale Serial Number] FROM [Sale Serial Number] WHERE [Sale Invoice No] = '" + TxtSaleInvoiceNo.Text + "' "
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Sale Serial Number")
            connection.Close()
            GrdAvailableSerialNumber.DataSource = ds
            GrdAvailableSerialNumber.DataMember = "BizPro_Sale Serial Number"

            'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)


            GrdAvailableSerialNumber.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill



        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Data Serial Number To Gridview")
        Finally

        End Try

        'End Refresh Data
    End Sub

    'Refresh Data Range Serial For Inserting More Range Serial
    Sub RefreshDataRangeSerialForInsertingMoreRangeSerial()

        ' Load Data
        Try

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT   [Sale Serial Number].[Sale Serial Number] FROM [Sale Serial Number]  WHERE [Sale Serial Number].[Sale Invoice No] = '" + TxtSaleInvoiceNo.Text + "' And [Sale Serial Number].[Product ID]= '" + cmbProductName.ValueMember + "' and [Sale Serial Number].[Purchase ID]='" + TxtPurchaseID.Text + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Sale Serial Number")
            connection.Close()
            GrdAvailableSerialNumber.DataSource = ds
            GrdAvailableSerialNumber.DataMember = "BizPro_Sale Serial Number"

            'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            GrdAvailableSerialNumber.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            TxtQuantity.Text = GrdAvailableSerialNumber.Rows.Count




        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Data Serial Number To Gridview")
        Finally

        End Try

        'End Refresh Data
    End Sub

    'Refresh Data Serial Number To Gridview Click
    Sub RefreshDataSerialNumberToGridviewForCellMouseClick()

        ' Load Data
        Try
            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT   [Sale Serial Number].[Sale Serial Number] FROM [Sale Serial Number]  WHERE [Sale Serial Number].[Sale Invoice No] = '" + TxtSaleInvoiceNo.Text + "' And [Sale Serial Number].[Product ID]= '" + cmbProductName.ValueMember + "' and [Sale Serial Number].[Purchase ID]='" + TxtPurchaseID.Text + "' and [Sale ID]='" + lblSaleID.Text + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Sale Serial Number")
            connection.Close()
            GrdAvailableSerialNumber.DataSource = ds
            GrdAvailableSerialNumber.DataMember = "BizPro_Sale Serial Number"

            'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)


            GrdAvailableSerialNumber.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Data Serial Number To Gridview")
        Finally

        End Try

        'End Refresh Data
    End Sub

    'Refresh Data Serial Number 
    Sub RefreshDataSerialNumber()

        ' Load Data
        Try
            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "SELECT   [Sale Serial Number].[Sale Serial Number] FROM [Sale Serial Number]  WHERE [Sale Serial Number].[Sale Invoice No] = '" + TxtSaleInvoiceNo.Text + "' And [Sale Serial Number].[Product ID]= '" + cmbProductName.ValueMember + "' and [Sale Serial Number].[Purchase ID]='" + TxtPurchaseID.Text + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Sale Serial Number")
            connection.Close()
            GrdAvailableSerialNumber.DataSource = ds
            GrdAvailableSerialNumber.DataMember = "BizPro_Sale Serial Number"

            'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)


            GrdAvailableSerialNumber.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Data Serial Number To Gridview")
        Finally

        End Try

        'End Refresh Data
    End Sub

    'Delete From Sale Serial Number
    Sub DeleteFromSaleSerialNumber()


        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Delete from [Sale Serial Number] where [Sale Invoice No]= '" + TxtSaleInvoiceNo.Text + "'"
            cmd.ExecuteNonQuery()
            con.Close()



        Catch ex As Exception
            MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Records Sale Serial")
        Finally

        End Try
        'Update Purchase Invoice
    End Sub
    'Delete From Sale Serial Number Selected Product
    Sub DeleteFromSaleSerialNumberSelectedProduct()


        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Delete from [Sale Serial Number] where [Sale Invoice No]= '" + TxtSaleInvoiceNo.Text + "' And [Product ID]= '" + cmbProductName.ValueMember + "' "
            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Records Sale Serial")
        Finally

        End Try
        'Update Purchase Invoice
    End Sub

    Sub DiscountAndPercentage()
        'Sub For discount and vat percentage
        TxtDiscount.Text = (Val(TxtTotal.Text) * Val(TxtDiscountPercentage.Text)) / 100

    End Sub

    Private Sub TxtDiscountPercentage_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDiscountPercentage.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtDiscount.Focus()
        End If
    End Sub

    Private Sub TxtDiscountPercentage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDiscountPercentage.TextChanged
        'Discount Percentage
        DiscountAndPercentage()
    End Sub

    Private Sub BtnDeleteProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GrdSale_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdSale.CellMouseDown

    End Sub

    Private Sub GrdSale_CellMouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdSale.CellMouseMove

        'Hide product list
        GrdProductList.Visible = False
        GrdCustomerList.Visible = False
        GrdSerialNumber.Visible = False
    End Sub

    Private Sub GrdSale_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdSale.CurrentCellDirtyStateChanged

    End Sub

    Private Sub GrdSale_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdSale.KeyDown

    End Sub

    Sub UpdateSaleInvoice()

        Try


            'Update Sale Invoice
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "UPDATE  [Sale Invoice] SET  [Total]= '" + TxtTotal.Text + "',[Previous Dues]= '" + TxtPreviousDues.Text + "', [Advance]= '" + TxtAdvance.Text + "', [Vat percentage]= '" + TxtVatPercentage.Text + "', [Vat]= '" + TxtVat.Text + "', [Discount Percentage]= '" + TxtDiscountPercentage.Text + "', [Discount]= '" + TxtDiscount.Text + "', [Net Payable]= '" + TxtNetPayable.Text + "', [Paid Amount]= '" + TxtPaidAmount.Text + "', [Balance]= '" + TxtBalance.Text + "', [Return Amount]= '" + TxtReturnAmount.Text + "', [Status]= 'COMPLETE',[Sale Date]='" + DtpSaleDate.Value + "',[Customer ID]='" + CmbCustomerName.ValueMember + "',[Paid by]='" + cmbPaidBy.SelectedValue.ToString + "',[Computer ID]= '" + FrmHome.LblComputerID.Text + "',[Remarks]='" + TxtRemarks.Text + "' where [Sale Invoice No] ='" + TxtSaleInvoiceNo.Text + "'"
            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while Updating record on table..." & ex.Message, "Update Sale Invoice Sub")
        End Try
    End Sub

    'Find Char of Account ID For Update ledger
    Sub SearchChartOfAccountIDForUpdateLedger()

        Try

        
            Dim con As New SqlConnection
            Dim cmd3 As New SqlCommand
            Dim dr3 As SqlDataReader


            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd3.Connection = con
            cmd3.CommandText = "SELECT  *FROM [Customer Information]  WHERE [Customer ID] = '" + CmbCustomerName.ValueMember + "' "

            dr3 = cmd3.ExecuteReader()
            dr3.Read()
            If dr3.HasRows Then

                CustomerChartofAccountIDForUpdate = dr3.Item("Chart Of Account ID").ToString
            End If
            dr3.Close()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "SearchChartOfAccountIDForUpdateLedger")

        End Try
    End Sub


    'Delete invoice from ledger
    Sub DeleteCustomerLedger()


        Try


            Dim con As New SqlConnection
            Dim con1 As New SqlConnection
            Dim cmd As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now


            Dim cmd2 As New SqlCommand
            Dim dr As SqlDataReader

            Dim cmd3 As New SqlCommand
            Dim dr3 As SqlDataReader



            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd2.Connection = con
            cmd3.Connection = con
            cmd2.CommandText = "SELECT  *FROM [Ledger]  WHERE [Invoice No] = '" + TxtSaleInvoiceNo.Text + "' And [Category Name]='Sale' "
            cmd3.CommandText = "SELECT  *FROM [Ledger]  WHERE [Invoice No] = '" + TxtSaleInvoiceNo.Text + "' And [Category Name]='Cash Sale' "


            dr3 = cmd3.ExecuteReader()
            dr3.Read()


            If dr3.HasRows Then



                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd.Connection = con1
                cmd.CommandText = "Delete from [Ledger] where [Invoice No]= '" + TxtSaleInvoiceNo.Text + "' And [Category Name]='Cash Sale'"
                cmd.ExecuteNonQuery()
                con1.Close()

            End If
            dr3.Close()




            dr = cmd2.ExecuteReader()
            dr.Read()


            If dr.HasRows Then



                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd.Connection = con1
                cmd.CommandText = "Delete from [Ledger] where [Invoice No]= '" + TxtSaleInvoiceNo.Text + "' And [Category Name]='Sale'"
                cmd.ExecuteNonQuery()
                con1.Close()

            End If


            dr.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while Deleting record on table..." & ex.Message, "Delete Records to Customer ladger")
        Finally

        End Try


    End Sub

    

    'Insert into log code For Delete
    Sub InsertIntoLogForDelete()

        'Data Insert Code
        Dim con As New SqlConnection
        Dim con1 As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim dr As SqlDataReader
        Dim CurrentDate As DateTime = DateTime.Today
        Dim CurrentTime As DateTime = DateTime.Now

        Dim SaleDetails As String

        Try
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd2.Connection = con
            cmd.CommandText = "Select SUBSTRING( ( SELECT   '-------'+  [Product Name],'  Sale Quantity : ',isnull(sum(sale.[Sale Quantity]),0),'  Sale Unit Price : ', isnull((sale.[Sale Unit Price]),0),'  Total Sale Amount : ', isnull (sum(sale.[Sale Amount]),0)        FROM [sale] join products on sale.[Product ID]=products.[Product ID]  where [Sale Invoice No]='" + TxtSaleInvoiceNo.Text + "'   group by sale.[Sale Unit Price],products.[Product Name] FOR XML PATH('') ), 2 , 9999) As [Sale Details]"
            cmd2.CommandText = "Select [Status] From [Sale Invoice] Where [Sale Invoice No]='" + TxtSaleInvoiceNo.Text + "'"

            'Data Reader For Find Sale Details
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                SaleDetails = dr.Item("Sale Details").ToString

            End If
            dr.Close()

            'Data Reader For Find invoice Status
            dr = cmd2.ExecuteReader
            dr.Read()
            Dim BillStatus As String
            If dr.HasRows Then

                BillStatus = dr.Item("Status").ToString

            End If
            dr.Close()
            con.Close()


            con1.ConnectionString = FrmHome.ConnectionString
            con1.Open()
            cmd1.Connection = con1
            cmd1.CommandText = "INSERT INTO [Log Details]  ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES('SALE','DELETE','Customer Name : " + CmbCustomerName.Text + " , Customer ID : " + CmbCustomerName.ValueMember + " , Sale Details :( " + SaleDetails + "),  Sale Invoice Details :(Sale Date : " + DtpSaleDate.Value + ", Total : " + TxtTotal.Text + ", Previous Dues : " + TxtPreviousDues.Text + ", Advance : " + TxtAdvance.Text + " , Vat Percentage : " + TxtVatPercentage.Text + ", Vat Amount : " + TxtVat.Text + ", Discount Percentage : " + TxtDiscountPercentage.Text + ", Discount Amount : " + TxtDiscount.Text + ", Net Payable : " + TxtNetPayable.Text + " , Paid Amount : " + TxtPaidAmount.Text + " , Balance : " + TxtBalance.Text + " , Paid By : " + cmbPaidBy.Text + ", Return Amount : " + TxtReturnAmount.Text + ", Remarks : " + TxtRemarks.Text + ", Bill Status : " + BillStatus + ")' ,'" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtSaleInvoiceNo.Text + "' )"
            cmd1.ExecuteNonQuery()
            con1.Close()



        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally


        End Try
    End Sub

    'Insert into log code For Save
    Sub InsertIntoLogForSave()

        'Data Insert Code
        Dim con As New SqlConnection
        Dim con1 As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim dr As SqlDataReader
        Dim CurrentDate As DateTime = DateTime.Today
        Dim CurrentTime As DateTime = DateTime.Now

        Dim SaleDetails As String

        Try
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Select SUBSTRING( ( SELECT   '-------'+  [Product Name],'  Sale Quantity : ',isnull(sum(sale.[Sale Quantity]),0),'  Sale Unit Price : ', isnull((sale.[Sale Unit Price]),0),'  Total Sale Amount : ', isnull (sum(sale.[Sale Amount]),0)        FROM [sale] join products on sale.[Product ID]=products.[Product ID]  where [Sale Invoice No]='" + TxtSaleInvoiceNo.Text + "'   group by sale.[Sale Unit Price],products.[Product Name] FOR XML PATH('') ), 2 , 9999) As [Sale Details]"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                SaleDetails = dr.Item("Sale Details").ToString

            End If
            dr.Close()
            con.Close()


            con1.ConnectionString = FrmHome.ConnectionString
            con1.Open()
            cmd1.Connection = con1
            cmd1.CommandText = "INSERT INTO [Log Details]  ([Form Name],[Log Category],[Log Description],[User Account ID],[Computer ID],[Log Date],[Log Time],[Branch ID],[Task ID]) VALUES('SALE','INSERT','Customer Name : " + CmbCustomerName.Text + " , Customer ID : " + CmbCustomerName.ValueMember + " , Sale Details :( " + SaleDetails + "),  Sale Invoice Details :(Sale Date : " + DtpSaleDate.Value + ", Total : " + TxtTotal.Text + ", Previous Dues : " + TxtPreviousDues.Text + ", Advance : " + TxtAdvance.Text + " , Vat Percentage : " + TxtVatPercentage.Text + ", Vat Amount : " + TxtVat.Text + ", Discount Percentage : " + TxtDiscountPercentage.Text + ", Discount Amount : " + TxtDiscount.Text + ", Net Payable : " + TxtNetPayable.Text + " , Paid Amount : " + TxtPaidAmount.Text + " , Balance : " + TxtBalance.Text + " , Paid By : " + cmbPaidBy.Text + ", Return Amount : " + TxtReturnAmount.Text + ", Remarks : " + TxtRemarks.Text + ")' ,'" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + CurrentDate + "','" + CurrentTime + "','" + FrmHome.lblBranchID.Text + "','" + TxtSaleInvoiceNo.Text + "' )"
            cmd1.ExecuteNonQuery()
            con1.Close()



        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records")
        Finally


        End Try
    End Sub



    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        'Send Invoice Number to sale report
        RptSaleInvoice.SaleInvoiceNo = Me.TxtSaleInvoiceNo.Text

        Try



            'InsertinotCustomer
            InsertIntoCustomer()



            If TxtPaidAmount.Text = "" Or cmbPaidBy.Text = "" Or Val(TxtPaidAmount.Text) < 0 Then
                MsgBox("Please Insert Valid Amount", MsgBoxStyle.Critical, "Sale")

            Else

                'Calculation Of Balance And ReturnAmount
                CalculationOfBalanceAndReturnAmount()

               


                Dim q As MsgBoxResult

                'Condition for show dues and advanced on msg box
                If Val(TxtPaidAmount.Text) >= Val(TxtNetPayable.Text) Then

                    q = MsgBox("Balance = " + TxtBalance.Text + ", Return Amount =  " + TxtReturnAmount.Text + ", Do you really want to Save?", MsgBoxStyle.YesNo, "Sale")
                Else
                    q = MsgBox("Dues Amount = " + TxtBalance.Text + ", Paid Amount =  " + TxtPaidAmount.Text + ", Do you really want to Save?", MsgBoxStyle.YesNo, "Sale")

                End If

                If q = MsgBoxResult.Yes Then

                    'Insert Into Log For Save
                    InsertIntoLogForSave()

                    If cmbPaidBy.Text = "DUE" Then

                        If Val(TxtNetPayable.Text) <= Val(TransactionLimit) Or Val(TransactionLimit) = 0 Then
                            'Delete invoice from ledger
                            DeleteCustomerLedger()

                            'Update or insert Customer ledger For dues
                            InsertorUpdateCustomerLedgerForDues()

                            'Update Sale Invoice To Complete And Send SMS And Show Report
                            UpdateSaleInvoiceToCompleteAndSendSMSAndShowReport()
                        Else
                            MsgBox("Transaction limit of this customer is exceeded.", MsgBoxStyle.Critical, "Sale")
                        End If

                    ElseIf cmbPaidBy.Text = "CASH" Then

                        'Update or insert Customer ledger For dues
                        InsertorUpdateCustomerLedgerForDues()

                        'Update or insert  ledger For Cash Sale
                        InsertorUpdateLedgerForCashSale()




                        If Val(TxtPaidAmount.Text) > Val(TxtNetPayable.Text) Then
                            Dim Q1 As MsgBoxResult
                            Q1 = MsgBox("DO YOU WANT TO RECEIVE EXTRA AMOUNT AS ADVANCE?", MsgBoxStyle.YesNo, "SALE")

                            If Q1 = MsgBoxResult.Yes Then

                                'UPDATE OR INSERT  LEDGER FOR CASH SALE
                                InsertorUpdateLedgerForAdvanceReceiveOnCashSale()

                                'RETURN AMOUNT CLEAR
                                TxtReturnAmount.Text = "00"

                            End If
                        End If




                        'Update Sale Invoice To Complete And Send SMS And Show Report
                        UpdateSaleInvoiceToCompleteAndSendSMSAndShowReport()




                    ElseIf Not cmbPaidBy.Text = "DUE" Or Not cmbPaidBy.Text = "CASH" Then

                        'Update or insert Customer ledger For dues
                        InsertorUpdateCustomerLedgerForDues()


                        'Update or insert  ledger For Bank Sale
                        InsertorUpdateLedgerForBankSale()


                        If Val(TxtPaidAmount.Text) > Val(TxtNetPayable.Text) Then
                            Dim q1 As MsgBoxResult
                            q1 = MsgBox("do you want to receive extra amount as advance?", MsgBoxStyle.YesNo, "sale")

                            If q1 = MsgBoxResult.Yes Then

                                'update or insert  ledger for bank sale
                                InsertorUpdateLedgerForAdvanceReceiveOnBankSale()

                                'return amount clear
                                TxtReturnAmount.Text = "00"


                            End If
                        End If

                        'Update Sale Invoice To Complete And Send SMS And Show Report
                        UpdateSaleInvoiceToCompleteAndSendSMSAndShowReport()


                    End If

                ElseIf q = MsgBoxResult.No Then


                    'Save Button Focus
                    TxtPaidAmount.Focus()

                End If
            End If





        Catch ex As Exception
            MessageBox.Show("Error while inserting record on Customer Ledger..." & ex.Message, "Save Button")
        End Try

    End Sub

    'Update Sale Invoice To Complete And Send SMS And Show Report
    Sub UpdateSaleInvoiceToCompleteAndSendSMSAndShowReport()


        Try



            'Sale Invoice update code
            UpdateSaleInvoice()



            'Dim qs As MsgBoxResult
            ' qs = MsgBox("Do you really want to Send Sms?", MsgBoxStyle.YesNo, "SMS")
            ' If qs = MsgBoxResult.Yes Then

            'Sub for show dues or advanced or Greeting
            SendSMS()

            'End If

            'Row clear Code
            GrdAvailableSerialNumber.Columns.Clear()
            GrdSale.Columns.Clear()


            'New INvoice
            NewInvoice()

            'Clear All
            ClearAllData()

            'Focus on Customer cobobbox
            CmbCustomerName.Focus()

            'Open Invoice
            RptSaleInvoice.ShowSaleInvoice()
            RptSaleInvoice.Show()




        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "UpdateSaleInvoiceToCompleteAndSendSMSAndShowReport")
        End Try
    End Sub
    'Update or insert Customer ledger For dues
    Sub InsertorUpdateCustomerLedgerForDues()



        Try

            Dim con As New SqlConnection
            Dim con1 As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand
            Dim cmd2 As New SqlCommand
            Dim cmd3 As New SqlCommand
            Dim cmd4 As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now
            Dim dr As SqlDataReader
            Dim dr2 As SqlDataReader
            Dim dr3 As SqlDataReader

            Dim CustomerChartOfAccountID As String
            Dim SaleChartOfAccountID As String
            Dim NetPayable As String

            NetPayable = ((Val(TxtTotal.Text) + Val(TxtVat.Text)) - Val(TxtDiscount.Text))

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd2.Connection = con
            cmd3.Connection = con
            cmd2.CommandText = "SELECT  *FROM [Customer Information]  WHERE [Customer ID] = '" + CmbCustomerName.ValueMember + "'"
            cmd3.CommandText = "SELECT  *FROM [Chart Of Account]  WHERE [Account Name] = 'Sale'"

            dr3 = cmd3.ExecuteReader()
            dr3.Read()
            If dr3.HasRows Then


                SaleChartOfAccountID = (dr3.Item("Chart Of Account ID").ToString)
            End If
            dr3.Close()

            dr2 = cmd2.ExecuteReader()
            dr2.Read()
            If dr2.HasRows Then

                CustomerChartOfAccountID = (dr2.Item("Chart Of Account ID").ToString)
            End If

            dr2.Close()


            cmd.CommandText = "SELECT  *FROM [Ledger]  WHERE  [Category Name]='Sale' And [Invoice No] = '" + TxtSaleInvoiceNo.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()




            If Not dr.HasRows Then

                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd4.Connection = con1
                cmd1.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart Of Account ID],[Invoice No],[Category Name],[User Account ID],[Computer ID],[Prepared Date] ,[Prepared Time],[Debited Amount],[Credited Amount],[Status],[Voucher No],[Description],[Branch ID],[Pending Invoice]) VALUES ('" + DtpSaleDate.Value + "','" + CustomerChartOfAccountID + "','" + TxtSaleInvoiceNo.Text + "','Sale','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + NetPayable + "','00','Completed','" + TxtSaleInvoiceNo.Text + "','Sale','" + FrmHome.lblBranchID.Text + "','" + (DtpSaleDate.Value.ToString("dd-MMM-yyyy")) + "-S-INV-" + TxtSaleInvoiceNo.Text + "')"
                cmd4.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart Of Account ID],[Invoice No],[Category Name],[User Account ID],[Computer ID],[Prepared Date] ,[Prepared Time],[Debited Amount],[Credited Amount],[Status],[Voucher No],[Description],[Branch ID],[Pending Invoice]) VALUES ('" + DtpSaleDate.Value + "','" + SaleChartOfAccountID + "','" + TxtSaleInvoiceNo.Text + "','Sale','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','00','" + NetPayable + "','Completed','" + TxtSaleInvoiceNo.Text + "','Sale To " + CmbCustomerName.Text + "','" + FrmHome.lblBranchID.Text + "','" + (DtpSaleDate.Value.ToString("dd-MMM-yyyy")) + "-S-INV-" + TxtSaleInvoiceNo.Text + "')"
                cmd1.ExecuteNonQuery()
                cmd4.ExecuteNonQuery()
                con1.Close()




            ElseIf dr.HasRows Then



                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd4.Connection = con1
                cmd1.CommandText = "Update [Ledger]  Set [Ledger Date]='" + DtpSaleDate.Value + "',[Chart Of Account ID]='" + CustomerChartOfAccountID + "',[Invoice No]='" + TxtSaleInvoiceNo.Text + "',[Category Name]='Sale',[User Account ID]='" + FrmHome.LblUserID.Text + "',[Computer ID]='" + FrmHome.LblComputerID.Text + "',[Prepared Time]='" + currentTime + "',[Debited Amount]='" + NetPayable + "',[Credited Amount]='00',[Description]= 'Sale' Where [Chart Of Account ID]='" + CustomerChartofAccountIDForUpdate + "' And [Invoice No]='" + TxtSaleInvoiceNo.Text + "' And [Category Name]='Sale'"
                cmd4.CommandText = "Update [Ledger] Set  [Ledger Date]='" + DtpSaleDate.Value + "',[Chart Of Account ID]='" + SaleChartOfAccountID + "',[Invoice No]='" + TxtSaleInvoiceNo.Text + "',[Category Name]='Sale',[User Account ID]='" + FrmHome.LblUserID.Text + "',[Computer ID]='" + FrmHome.LblComputerID.Text + "',[Prepared Time]='" + currentTime + "',[Debited Amount]='00',[Credited Amount]='" + NetPayable + "',[Description]= 'Sale To " + CmbCustomerName.Text + "' Where [Chart Of Account ID]='" + SaleChartOfAccountID + "' And [Invoice No]='" + TxtSaleInvoiceNo.Text + "' And [Category Name]='Sale'"

                cmd1.ExecuteNonQuery()
                cmd4.ExecuteNonQuery()



                con1.Close()




            End If

            dr.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records to Customer ledger")
        Finally

        End Try

    End Sub

    'Update or insert  ledger For Cash Sale
    Sub InsertorUpdateLedgerForCashSale()



        Try

            Dim con As New SqlConnection
            Dim con1 As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand
            Dim cmd2 As New SqlCommand
            Dim cmd4 As New SqlCommand
            ' Dim cmd5 As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now
            Dim dr As SqlDataReader
            Dim dr2 As SqlDataReader


            Dim CustomerChartOfAccountID As String

            Dim ReceiveAmount As String

            If (Val(TxtPaidAmount.Text) - Val(TxtReturnAmount.Text)) < 0 Then
                ReceiveAmount = Val(TxtPaidAmount.Text)
            Else

                ReceiveAmount = (Val(TxtPaidAmount.Text) - Val(TxtReturnAmount.Text))
            End If



            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd2.Connection = con
            cmd.CommandText = "SELECT  *FROM [Ledger]  WHERE  [Category Name]='Cash Sale' And [Invoice No] = '" + TxtSaleInvoiceNo.Text + "'"
            cmd2.CommandText = "SELECT  *FROM [Customer Information]  WHERE [Customer ID] = '" + CmbCustomerName.ValueMember + "'"

            dr2 = cmd2.ExecuteReader()
            dr2.Read()
            If dr2.HasRows Then

                CustomerChartOfAccountID = (dr2.Item("Chart Of Account ID").ToString)
            End If

            dr2.Close()

            dr = cmd.ExecuteReader()
            dr.Read()




            If Not dr.HasRows Then

                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd4.Connection = con1
                cmd1.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart Of Account ID],[Invoice No],[Category Name],[User Account ID],[Computer ID],[Prepared Date] ,[Prepared Time],[Debited Amount],[Credited Amount],[Status],[Voucher No],[Description],[Branch ID],[Pending Invoice]) VALUES ('" + DtpSaleDate.Value + "','" + cmbPaidBy.SelectedValue.ToString + "','" + TxtSaleInvoiceNo.Text + "','Cash Sale','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + ReceiveAmount + "','00','CASH','" + TxtSaleInvoiceNo.Text + "','Collection From " + CmbCustomerName.Text + "','" + FrmHome.lblBranchID.Text + "','" + (DtpSaleDate.Value.ToString("dd-MMM-yyyy")) + "-S-INV-" + TxtSaleInvoiceNo.Text + "')"
                cmd4.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart Of Account ID],[Invoice No],[Category Name],[User Account ID],[Computer ID],[Prepared Date] ,[Prepared Time],[Debited Amount],[Credited Amount],[Status],[Voucher No],[Description],[Branch ID],[Pending Invoice]) VALUES ('" + DtpSaleDate.Value + "','" + CustomerChartOfAccountID + "','" + TxtSaleInvoiceNo.Text + "','Cash Sale','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','00','" + ReceiveAmount + "','CASH','" + TxtSaleInvoiceNo.Text + "','" + cmbPaidBy.Text + "  Collection','" + FrmHome.lblBranchID.Text + "','" + (DtpSaleDate.Value.ToString("dd-MMM-yyyy")) + "-S-INV-" + TxtSaleInvoiceNo.Text + "'  )"
                cmd1.ExecuteNonQuery()
                cmd4.ExecuteNonQuery()
                con1.Close()




            ElseIf dr.HasRows Then



                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                'cmd5.Connection = con1
                cmd1.Connection = con1
                cmd4.Connection = con1
                'cmd5.CommandText = "Delete from  [Ledger] WHERE [Category Name]='Sale' And[Invoice No]= '" + TxtSaleInvoiceNo.Text + "'"
                cmd1.CommandText = "Update [Ledger] Set [Ledger Date]='" + DtpSaleDate.Value + "',[Chart Of Account ID]='" + CustomerChartOfAccountID + "',[Invoice No]='" + TxtSaleInvoiceNo.Text + "',[Category Name]='Cash Sale',[User Account ID]='" + FrmHome.LblUserID.Text + "',[Computer ID]='" + FrmHome.LblComputerID.Text + "' ,[Prepared Time]='" + currentTime + "',[Debited Amount]='00',[Credited Amount]='" + ReceiveAmount + "',[Description]='" + cmbPaidBy.Text + "  Collection',[Status]='CASH' Where [Chart Of Account ID]='" + CustomerChartofAccountIDForUpdate + "' And [Invoice No]='" + TxtSaleInvoiceNo.Text + "' And [Category Name]='Cash Sale'"
                cmd4.CommandText = "Update [Ledger] Set [Ledger Date]='" + DtpSaleDate.Value + "',[Chart Of Account ID]='" + cmbPaidBy.SelectedValue.ToString + "',[Invoice No]='" + TxtSaleInvoiceNo.Text + "',[Category Name]='Cash Sale',[User Account ID]='" + FrmHome.LblUserID.Text + "',[Computer ID]='" + FrmHome.LblComputerID.Text + "' ,[Prepared Time]='" + currentTime + "',[Debited Amount]='" + ReceiveAmount + "',[Credited Amount]='00',[Description]='Collection From " + CmbCustomerName.Text + "',[Status]='CASH' Where [Chart Of Account ID]='" + PreviousPaidbyID + "' And [Invoice No]='" + TxtSaleInvoiceNo.Text + "' And [Category Name]='Cash Sale'"

                'cmd5.ExecuteNonQuery()
                cmd1.ExecuteNonQuery()
                cmd4.ExecuteNonQuery()



                con1.Close()




            End If

            dr.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records to Customer ledger")
        Finally

        End Try
    End Sub
    'Update or insert  ledger For Cash Sale
    Sub InsertorUpdateLedgerForAdvanceReceiveOnCashSale()

        'Find Char of Account ID For Update ledger
        SearchChartOfAccountIDForUpdateLedger()


        Try

            Dim con As New SqlConnection
            Dim con1 As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand
            Dim cmd2 As New SqlCommand
            Dim cmd4 As New SqlCommand
            ' Dim cmd5 As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now
            Dim dr As SqlDataReader
            Dim dr2 As SqlDataReader


            Dim CustomerChartOfAccountID As String

            Dim ReceiveAmount As String


            ReceiveAmount = TxtPaidAmount.Text



            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd2.Connection = con
            cmd.CommandText = "SELECT  *FROM [Ledger]  WHERE  [Category Name]='Cash Sale' And [Invoice No] = '" + TxtSaleInvoiceNo.Text + "'"
            cmd2.CommandText = "SELECT  *FROM [Customer Information]  WHERE [Customer ID] = '" + CmbCustomerName.ValueMember + "'"

            dr2 = cmd2.ExecuteReader()
            dr2.Read()

            If dr2.HasRows Then
                CustomerChartOfAccountID = (dr2.Item("Chart Of Account ID").ToString)
            End If

            dr2.Close()

            dr = cmd.ExecuteReader()
            dr.Read()

            If Not dr.HasRows Then

                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd4.Connection = con1
                cmd1.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart Of Account ID],[Invoice No],[Category Name],[User Account ID],[Computer ID],[Prepared Date] ,[Prepared Time],[Debited Amount],[Credited Amount],[Status],[Voucher No],[Description],[Branch ID],[Pending Invoice]) VALUES ('" + DtpSaleDate.Value + "','" + cmbPaidBy.SelectedValue.ToString + "','" + TxtSaleInvoiceNo.Text + "','Cash Sale','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + ReceiveAmount + "','00','CASH','" + TxtSaleInvoiceNo.Text + "','Collection From " + CmbCustomerName.Text + "','" + FrmHome.lblBranchID.Text + "','" + (DtpSaleDate.Value.ToString("dd-MMM-yyyy")) + "-S-INV-" + TxtSaleInvoiceNo.Text + "')"
                cmd4.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart Of Account ID],[Invoice No],[Category Name],[User Account ID],[Computer ID],[Prepared Date] ,[Prepared Time],[Debited Amount],[Credited Amount],[Status],[Voucher No],[Description],[Branch ID],[Pending Invoice]) VALUES ('" + DtpSaleDate.Value + "','" + CustomerChartOfAccountID + "','" + TxtSaleInvoiceNo.Text + "','Cash Sale','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','00','" + ReceiveAmount + "','CASH','" + TxtSaleInvoiceNo.Text + "','" + cmbPaidBy.Text + "  Collection','" + FrmHome.lblBranchID.Text + "','" + (DtpSaleDate.Value.ToString("dd-MMM-yyyy")) + "-S-INV-" + TxtSaleInvoiceNo.Text + "'  )"
                cmd1.ExecuteNonQuery()
                cmd4.ExecuteNonQuery()
                con1.Close()

            ElseIf dr.HasRows Then



                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                'cmd5.Connection = con1
                cmd1.Connection = con1
                cmd4.Connection = con1
                'cmd5.CommandText = "Delete from  [Ledger] WHERE [Category Name]='Sale' And[Invoice No]= '" + TxtSaleInvoiceNo.Text + "'"
                cmd1.CommandText = "Update [Ledger] Set [Ledger Date]='" + DtpSaleDate.Value + "',[Chart Of Account ID]='" + CustomerChartOfAccountID + "',[Invoice No]='" + TxtSaleInvoiceNo.Text + "',[Category Name]='Cash Sale',[User Account ID]='" + FrmHome.LblUserID.Text + "',[Computer ID]='" + FrmHome.LblComputerID.Text + "' ,[Prepared Time]='" + currentTime + "',[Debited Amount]='00',[Credited Amount]='" + ReceiveAmount + "',[Description]='" + cmbPaidBy.Text + "  Collection',[Status]='CASH' Where [Chart Of Account ID]='" + CustomerChartofAccountIDForUpdate + "' And [Invoice No]='" + TxtSaleInvoiceNo.Text + "' And [Category Name]='Cash Sale'"
                cmd4.CommandText = "Update [Ledger] Set [Ledger Date]='" + DtpSaleDate.Value + "',[Chart Of Account ID]='" + cmbPaidBy.SelectedValue.ToString + "',[Invoice No]='" + TxtSaleInvoiceNo.Text + "',[Category Name]='Cash Sale',[User Account ID]='" + FrmHome.LblUserID.Text + "',[Computer ID]='" + FrmHome.LblComputerID.Text + "' ,[Prepared Time]='" + currentTime + "',[Debited Amount]='" + ReceiveAmount + "',[Credited Amount]='00',[Description]='Collection From " + CmbCustomerName.Text + "',[Status]='CASH' Where [Chart Of Account ID]='" + PreviousPaidbyID + "' And [Invoice No]='" + TxtSaleInvoiceNo.Text + "' And [Category Name]='Cash Sale'"

                'cmd5.ExecuteNonQuery()
                cmd1.ExecuteNonQuery()
                cmd4.ExecuteNonQuery()
                con1.Close()

            End If

            dr.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records to Customer ledger")
        Finally

        End Try
    End Sub
    'Update or insert  ledger For Bank Sale
    Sub InsertorUpdateLedgerForBankSale()

        Try

            Dim con As New SqlConnection
            Dim con1 As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand
            Dim cmd2 As New SqlCommand
            Dim cmd4 As New SqlCommand
            ' Dim cmd5 As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now
            Dim dr As SqlDataReader
            Dim dr2 As SqlDataReader


            Dim CustomerChartOfAccountID As String

            Dim ReceiveAmount As String

            ReceiveAmount = (Val(TxtPaidAmount.Text) - Val(TxtReturnAmount.Text))

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd2.Connection = con
            cmd.CommandText = "SELECT  *FROM [Ledger]  WHERE  [Category Name]='Cash Sale' And [Invoice No] = '" + TxtSaleInvoiceNo.Text + "'"
            cmd2.CommandText = "SELECT  *FROM [Customer Information]  WHERE [Customer ID] = '" + CmbCustomerName.ValueMember + "'"

            dr2 = cmd2.ExecuteReader()
            dr2.Read()

            If dr2.HasRows Then
                CustomerChartOfAccountID = (dr2.Item("Chart Of Account ID").ToString)
            End If
            dr2.Close()



            dr = cmd.ExecuteReader()
            dr.Read()


            If Not dr.HasRows Then

                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd4.Connection = con1
                cmd1.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart Of Account ID],[Invoice No],[Category Name],[User Account ID],[Computer ID],[Prepared Date] ,[Prepared Time],[Debited Amount],[Credited Amount],[Status],[Voucher No],[Description],[Branch ID],[Pending Invoice]) VALUES ('" + DtpSaleDate.Value + "','" + cmbPaidBy.SelectedValue.ToString + "','" + TxtSaleInvoiceNo.Text + "','Cash Sale','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + ReceiveAmount + "','00','WithHeld','" + TxtSaleInvoiceNo.Text + "','Collection From " + CmbCustomerName.Text + "','" + FrmHome.lblBranchID.Text + "','" + (DtpSaleDate.Value.ToString("dd-MMM-yyyy")) + "-S-INV-" + TxtSaleInvoiceNo.Text + "')"
                cmd4.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart Of Account ID],[Invoice No],[Category Name],[User Account ID],[Computer ID],[Prepared Date] ,[Prepared Time],[Debited Amount],[Credited Amount],[Status],[Voucher No],[Description],[Branch ID],[Pending Invoice]) VALUES ('" + DtpSaleDate.Value + "','" + CustomerChartOfAccountID + "','" + TxtSaleInvoiceNo.Text + "','Cash Sale','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','00','" + ReceiveAmount + "','WithHeld','" + TxtSaleInvoiceNo.Text + "','" + cmbPaidBy.Text + "  Collection','" + FrmHome.lblBranchID.Text + "','" + (DtpSaleDate.Value.ToString("dd-MMM-yyyy")) + "-S-INV-" + TxtSaleInvoiceNo.Text + "'  )"
                cmd1.ExecuteNonQuery()
                cmd4.ExecuteNonQuery()
                con1.Close()




            ElseIf dr.HasRows Then



                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                'cmd5.Connection = con1
                cmd1.Connection = con1
                cmd4.Connection = con1
                'cmd5.CommandText = "Delete from  [Ledger] WHERE [Category Name]='Sale' And[Invoice No]= '" + TxtSaleInvoiceNo.Text + "'"
                cmd1.CommandText = "Update [Ledger] Set [Ledger Date]='" + DtpSaleDate.Value + "',[Chart Of Account ID]='" + CustomerChartOfAccountID + "',[Invoice No]='" + TxtSaleInvoiceNo.Text + "',[Category Name]='Cash Sale',[User Account ID]='" + FrmHome.LblUserID.Text + "',[Computer ID]='" + FrmHome.LblComputerID.Text + "' ,[Prepared Time]='" + currentTime + "',[Debited Amount]='00',[Credited Amount]='" + ReceiveAmount + "',[Description]='Collection From " + CmbCustomerName.Text + "',[Status]='WithHeld' Where [Chart Of Account ID]='" + CustomerChartofAccountIDForUpdate + "' And [Invoice No]='" + TxtSaleInvoiceNo.Text + "' And [Category Name]='Cash Sale'"
                cmd4.CommandText = "Update [Ledger] Set [Ledger Date]='" + DtpSaleDate.Value + "',[Chart Of Account ID]='" + cmbPaidBy.SelectedValue.ToString + "',[Invoice No]='" + TxtSaleInvoiceNo.Text + "',[Category Name]='Cash Sale',[User Account ID]='" + FrmHome.LblUserID.Text + "',[Computer ID]='" + FrmHome.LblComputerID.Text + "' ,[Prepared Time]='" + currentTime + "',[Debited Amount]='" + ReceiveAmount + "',[Credited Amount]='00',[Description]='" + cmbPaidBy.Text + "  Collection',[Status]='WithHeld' Where [Chart Of Account ID]='" + PreviousPaidbyID + "' And [Invoice No]='" + TxtSaleInvoiceNo.Text + "' And [Category Name]='Cash Sale'"

                'cmd5.ExecuteNonQuery()
                cmd1.ExecuteNonQuery()
                cmd4.ExecuteNonQuery()



                con1.Close()




            End If

            dr.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records to Customer ledger")
        Finally

        End Try
    End Sub
    'Update or insert  ledger For Bank Sale
    Sub InsertorUpdateLedgerForAdvanceReceiveOnBankSale()

        'Search Chart Of Account ID For Update Ledger
        SearchChartOfAccountIDForUpdateLedger()

        Try

            Dim con As New SqlConnection
            Dim con1 As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand
            Dim cmd2 As New SqlCommand
            Dim cmd4 As New SqlCommand
            ' Dim cmd5 As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now
            Dim dr As SqlDataReader
            Dim dr2 As SqlDataReader


            Dim CustomerChartOfAccountID As String

            Dim ReceiveAmount As String

            ReceiveAmount = Val(TxtPaidAmount.Text)

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd2.Connection = con
            cmd.CommandText = "SELECT  *FROM [Ledger]  WHERE  [Category Name]='Cash Sale' And [Invoice No] = '" + TxtSaleInvoiceNo.Text + "'"
            cmd2.CommandText = "SELECT  *FROM [Customer Information]  WHERE [Customer ID] = '" + CmbCustomerName.ValueMember + "'"

            dr2 = cmd2.ExecuteReader()
            dr2.Read()

            If dr2.HasRows Then
                CustomerChartOfAccountID = (dr2.Item("Chart Of Account ID").ToString)
            End If
            dr2.Close()



            dr = cmd.ExecuteReader()
            dr.Read()




            If Not dr.HasRows Then

                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd4.Connection = con1
                cmd1.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart Of Account ID],[Invoice No],[Category Name],[User Account ID],[Computer ID],[Prepared Date] ,[Prepared Time],[Debited Amount],[Credited Amount],[Status],[Voucher No],[Description],[Branch ID],[Pending Invoice]) VALUES ('" + DtpSaleDate.Value + "','" + cmbPaidBy.SelectedValue.ToString + "','" + TxtSaleInvoiceNo.Text + "','Cash Sale','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','" + ReceiveAmount + "','00','WithHeld','" + TxtSaleInvoiceNo.Text + "','Collection From " + CmbCustomerName.Text + "','" + FrmHome.lblBranchID.Text + "','" + (DtpSaleDate.Value.ToString("dd-MMM-yyyy")) + "-S-INV-" + TxtSaleInvoiceNo.Text + "')"
                cmd4.CommandText = "INSERT INTO [Ledger] ([Ledger Date],[Chart Of Account ID],[Invoice No],[Category Name],[User Account ID],[Computer ID],[Prepared Date] ,[Prepared Time],[Debited Amount],[Credited Amount],[Status],[Voucher No],[Description],[Branch ID],[Pending Invoice]) VALUES ('" + DtpSaleDate.Value + "','" + CustomerChartOfAccountID + "','" + TxtSaleInvoiceNo.Text + "','Cash Sale','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + currentDate + "','" + currentTime + "','00','" + ReceiveAmount + "','WithHeld','" + TxtSaleInvoiceNo.Text + "','" + cmbPaidBy.Text + "  Collection','" + FrmHome.lblBranchID.Text + "','" + (DtpSaleDate.Value.ToString("dd-MMM-yyyy")) + "-S-INV-" + TxtSaleInvoiceNo.Text + "'  )"
                cmd1.ExecuteNonQuery()
                cmd4.ExecuteNonQuery()
                con1.Close()




            ElseIf dr.HasRows Then



                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                'cmd5.Connection = con1
                cmd1.Connection = con1
                cmd4.Connection = con1
                'cmd5.CommandText = "Delete from  [Ledger] WHERE [Category Name]='Sale' And[Invoice No]= '" + TxtSaleInvoiceNo.Text + "'"
                cmd1.CommandText = "Update [Ledger] Set [Ledger Date]='" + DtpSaleDate.Value + "',[Chart Of Account ID]='" + CustomerChartOfAccountID + "',[Invoice No]='" + TxtSaleInvoiceNo.Text + "',[Category Name]='Cash Sale',[User Account ID]='" + FrmHome.LblUserID.Text + "',[Computer ID]='" + FrmHome.LblComputerID.Text + "' ,[Prepared Time]='" + currentTime + "',[Debited Amount]='00',[Credited Amount]='" + ReceiveAmount + "',[Description]='Collection From " + CmbCustomerName.Text + "',[Status]='WithHeld' Where [Chart Of Account ID]='" + CustomerChartofAccountIDForUpdate + "' And [Invoice No]='" + TxtSaleInvoiceNo.Text + "' And [Category Name]='Cash Sale'"
                cmd4.CommandText = "Update [Ledger] Set [Ledger Date]='" + DtpSaleDate.Value + "',[Chart Of Account ID]='" + cmbPaidBy.SelectedValue.ToString + "',[Invoice No]='" + TxtSaleInvoiceNo.Text + "',[Category Name]='Cash Sale',[User Account ID]='" + FrmHome.LblUserID.Text + "',[Computer ID]='" + FrmHome.LblComputerID.Text + "' ,[Prepared Time]='" + currentTime + "',[Debited Amount]='" + ReceiveAmount + "',[Credited Amount]='00',[Description]='" + cmbPaidBy.Text + "  Collection',[Status]='WithHeld' Where [Chart Of Account ID]='" + PreviousPaidbyID + "' And [Invoice No]='" + TxtSaleInvoiceNo.Text + "' And [Category Name]='Cash Sale'"

                'cmd5.ExecuteNonQuery()
                cmd1.ExecuteNonQuery()
                cmd4.ExecuteNonQuery()
                con1.Close()




            End If

            dr.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Records to Customer ledger")
        Finally

        End Try
    End Sub
    Sub ShowDueOrAdvance()


       
        'Dim con As New SqlConnection
        ' Dim cmd As New SqlCommand
        ' Dim dr As SqlDataReader

        ' con.ConnectionString = FrmHome.ConnectionString
        ' con.Open()
        'cmd.Connection = con
        'cmd.CommandText = "SELECT  top 1 * FROM [Ledger]  WHERE [Invoice No] = '" + TxtSaleInvoiceNo.Text + "' and [Category Name]='Sale' and [Chart of account id]='" + CustomerChartofAccountID + "' "

        'dr = cmd.ExecuteReader()
        'dr.Read()
        'If Not dr.HasRows Then

        'MsgBox(dr.Item("chart of account id"))
        'Finddues Or advanced
        FindDueOrAdvance()

        'End If
        ' dr.Close()
        'con.Close()


    End Sub

    'Sub for Find dues or advanced
    Sub FindDueOrAdvance()
        Try


            Me.TxtPreviousDues.Text = ""
            Me.TxtAdvance.Text = ""

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader
            Dim cmd2 As New SqlCommand
            Dim dr2 As SqlDataReader
            Dim CustomerChartOfAccountID As String


            'Data reader for Product Id
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd2.Connection = con
            cmd2.CommandText = "SELECT  *FROM [Customer Information]  WHERE [Customer ID] = '" + CmbCustomerName.ValueMember + "'"

            dr2 = cmd2.ExecuteReader()
            dr2.Read()
            If dr2.HasRows Then
                CustomerChartOfAccountID = (dr2.Item("Chart Of Account ID").ToString)
            End If
            dr2.Close()



            cmd.Connection = con
            cmd.CommandText = "select (isnull(sum([Debited Amount]),0)- (isnull(sum([Credited Amount]),0))) as [Amount]  from [Ledger] where  [Ledger].[Chart Of Account ID]= '" + CustomerChartOfAccountID + "' and not  [Ledger].[Status]= 'WithHeld' "

            dr = cmd.ExecuteReader()
            dr.Read()




            If dr.HasRows Then


                If Val(dr.Item("Amount")) > 0 Then
                    Me.TxtPreviousDues.Text = (dr.Item("Amount").ToString)
                    Me.TxtAdvance.Text = ""

                ElseIf Val(dr.Item("Amount")) < 0 Then

                    Me.TxtAdvance.Text = Val(dr.Item("Amount").ToString) * -1
                    Me.TxtPreviousDues.Text = ""
                End If



            End If




            dr.Close()
            con.Close()





        Catch ex As Exception

        End Try
    End Sub

    'Delete Full Invoice
    Sub DeleteFullInvoice()

        Try



            Dim con2 As New SqlConnection
            Dim cmd2 As New SqlCommand

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now

            con2.ConnectionString = FrmHome.ConnectionString
            con2.Open()
            cmd2.Connection = con2
            cmd2.CommandText = "Delete from [Sale Invoice] where [Sale Invoice No]= '" + TxtSaleInvoiceNo.Text + "'"
            cmd2.ExecuteNonQuery()
            con2.Close()



            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Delete from [Sale] where [Sale Invoice No]= '" + TxtSaleInvoiceNo.Text + "'"
            cmd.ExecuteNonQuery()
            con.Close()

            'Delete From Customer Ledger
            DeleteCustomerLedger()


            'Refresh Data Serial Number To Gridview For Delete Button
            RefreshDataSerialNumberToGridviewForDeleteButton()

            'Update Purchase Serial Number From Sold To Available
            UpdatePurchaseSerialNumberFromSoldToAvailable()

            'Delete From Sale Serial Number
            DeleteFromSaleSerialNumber()



            'Clear all data
            ClearAllData()



            'Focus on Custome  name
            CmbCustomerName.Focus()


            NewInvoice()


            'Refresh Data
            'RefreshData()

            GrdAvailableSerialNumber.Columns.Clear()
            GrdSale.Columns.Clear()


            'Serial Number Show if available
            'LoadComboBoxforSerialNumber()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "DeleteFullInvoice")
        End Try

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click


        Try




            If Not CmbCustomerName.ValueMember = "" Or Not CmbCustomerName.Text = "" Then

                Dim q As MsgBoxResult
                q = MsgBox("Do you really want to Delete Invoice?", MsgBoxStyle.YesNo, "Sale")
                If q = MsgBoxResult.Yes Then

                    'Insert into log code For Delete
                    InsertIntoLogForDelete()

                    'Delete Full Invoice
                    DeleteFullInvoice()
                End If

            Else

                MsgBox("Please Insert Invoice Number First.", MsgBoxStyle.OkOnly, "Sale")

            End If



        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records")
        Finally

        End Try





    End Sub
    Private Sub TxtAdvance_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtAdvance.KeyDown
        If e.KeyCode = Keys.Enter Then

            'Calculate return amount
            TxtReturnAmount.Text = Val(TxtReturnAmount.Text) - Val(TxtAdvance.Text)


            BtnSave.Focus()

        End If
    End Sub

    Private Sub TxtAdvance_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtAdvance.TextChanged

    End Sub
    'Calculate Net Payable Amount

    Sub NetPayableAmount()

        TxtNetPayable.Text = ((Val(TxtTotal.Text) + Val(TxtPreviousDues.Text) + Val(TxtVat.Text)) - (Val(TxtDiscount.Text) + Val(TxtAdvance.Text)))



    End Sub


    Private Sub TxtVat_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtVat.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtDiscountPercentage.Focus()
        End If
    End Sub

    Private Sub TxtVat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtVat.TextChanged
        'Calculate netpayable amount
        NetPayableAmount()
    End Sub

    Private Sub TxtDiscount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDiscount.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtNetPayable.Focus()
        End If
    End Sub

    Private Sub TxtDiscount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDiscount.TextChanged
        'Calculate Net Payable Amount
        NetPayableAmount()
    End Sub

    Private Sub TxtNetPayable_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNetPayable.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtPaidAmount.Focus()
            TxtPaidAmount.Text = TxtNetPayable.Text

        End If
    End Sub
    Private Sub TxtNetPayable_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNetPayable.TextChanged
        Me.TxtNetPayableLarge.Text = Me.TxtNetPayable.Text

    End Sub

    Private Sub TxtPaidAmount_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtPaidAmount.GotFocus

        'Hide product list
        GrdProductList.Visible = False
        GrdCustomerList.Visible = False
    End Sub

    Private Sub TxtPaidAmount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPaidAmount.KeyDown

        'CalCulate Return amount and focus on return amount if cash of due
        If e.KeyCode = Keys.Enter Then
            'Calculation Of Balance And ReturnAmount
            CalculationOfBalanceAndReturnAmount()

            If Val(TxtPaidAmount.Text) <= 0 Then
                cmbPaidBy.Text = "DUE"
                TxtBalance.Text = "00"
            ElseIf Val(TxtPaidAmount.Text) > 0 Then
                cmbPaidBy.Text = "CASH"
            End If

        End If

    End Sub

    'Calculation Of Balance And ReturnAmount
    Sub CalculationOfBalanceAndReturnAmount()
        Try


            If Val(TxtPaidAmount.Text) >= Val(TxtNetPayable.Text) Then

                'Calculate Return amount
                TxtReturnAmount.Text = Val(TxtPaidAmount.Text) - Val(TxtNetPayable.Text)

                'Calculate Balance amount
                TxtBalance.Text = Val(TxtPaidAmount.Text) - Val(TxtReturnAmount.Text)

                cmbPaidBy.Focus()

            ElseIf Val(TxtPaidAmount.Text) < Val(TxtNetPayable.Text) Then

                'Calculate Balance amount
                TxtBalance.Text = Val(TxtNetPayable.Text) - Val(TxtPaidAmount.Text)
                TxtReturnAmount.Text = "00"
                cmbPaidBy.Focus()

            End If


            If Val(TxtPaidAmount.Text) <= 0 Then
                cmbPaidBy.Text = "DUE"
                TxtBalance.Text = "00"
            ElseIf Val(TxtPaidAmount.Text) > 0 Then

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "CalculationOfBalanceAndReturnAmount")
        End Try
    End Sub

    Private Sub TxtPaidAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPaidAmount.TextChanged

    End Sub

    Private Sub TxtSaleInvoice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSaleInvoiceNo.KeyDown


        If e.KeyCode = Keys.Enter Then

            ' Load Data
            Try
                'Refreshdata
                RefreshData()

                SearchSaleInvoice()


            Catch ex As Exception
                MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records on keydown")
            Finally

            End Try
        End If
    End Sub


    Sub SearchSaleInvoice()

        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader


            'Data reader for Product Id
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Sale Invoice] join [Customer information] on[Sale Invoice].[Customer ID]=[Customer information].[Customer ID] join [Chart of Account] on [Sale Invoice].[Paid By]=[Chart of Account].[Chart of Account ID]   WHERE [Sale Invoice].[Sale Invoice No] =  '" + TxtSaleInvoiceNo.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()
            If dr.HasRows Then

                Me.CmbCustomerName.Text = (dr.Item("Customer Name").ToString)
                Me.CmbCustomerName.ValueMember = (dr.Item("Customer ID").ToString)
                TxtPhoneNo.Text = (dr.Item("Mobile No").ToString)
                TxtAddress.Text = (dr.Item("Address").ToString)
                TxtDiscountPercentage.Text = (dr.Item("Discount Percentage").ToString)
                TxtDiscount.Text = Double.Parse((dr.Item("Discount").ToString)).ToString
                TxtRemarks.Text = (dr.Item("Remarks").ToString)
                cmbPaidBy.SelectedValue = (dr.Item("Paid By").ToString)
                TxtPaidAmount.Text = Double.Parse((dr.Item("Paid Amount").ToString)).ToString
                TxtBalance.Text = Double.Parse((dr.Item("Balance").ToString)).ToString
                TxtReturnAmount.Text = Double.Parse((dr.Item("Return Amount").ToString)).ToString
                TxtNetPayable.Text = Double.Parse((dr.Item("Net Payable").ToString)).ToString
                TxtPreviousDues.Text = Double.Parse((dr.Item("Previous Dues").ToString)).ToString
                TxtAdvance.Text = Double.Parse((dr.Item("Advance").ToString)).ToString
                TxtVatPercentage.Text = (dr.Item("Vat Percentage").ToString)
                TxtVat.Text = Double.Parse((dr.Item("Vat").ToString)).ToString


                'Focus on Product name
                cmbProductName.Focus()

            End If
            dr.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh Records on keydown")
        Finally

        End Try


    End Sub

    Private Sub TxtSaleInvoice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSaleInvoiceNo.TextChanged

    End Sub


    Private Sub CmbPaymentStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Focus on Paid Text box
        TxtPaidAmount.Focus()
    End Sub

    Private Sub BtnDeleteProduct_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub BtnAddProduct_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub CmbPaymentStatus_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Me.TxtPaidAmount.Focus()
        End If
    End Sub

    Private Sub CmbPaymentStatus_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Focus on Paid Text box
        TxtPaidAmount.Focus()

    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaleHistory.Click
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader


            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + FrmHome.LblUserID.Text + "' AND [Category Name] = 'Sale History'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                FrmSaleHistory.Show()
                FrmSaleHistory.TxtSearchSaleInvoice.Focus()

            Else
                MsgBox("You do not have permission to access this form.", MsgBoxStyle.Critical, "Home")
            End If
            dr.Close()

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Permission for SaleHistory")
        End Try





    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        If Not TxtSaleInvoiceNo.Text = "" And Not SaleEditStatus = True Then

            Dim q As MsgBoxResult = MsgBox("Do you want to keep this Invoice as draft?", MsgBoxStyle.YesNoCancel, "Sale")

            If q = MsgBoxResult.No Then

                'Insert into log code For Delete
                InsertIntoLogForDelete()

                'Delete Full Invoice
                DeleteFullInvoice()
            ElseIf q = MsgBoxResult.Yes Then

                'Clear All Data
                ClearAllData()

                'New Invoice
                NewInvoice()

                'Row clear Code
                GrdAvailableSerialNumber.Columns.Clear()
                GrdSale.Columns.Clear()

                'Focus on Custome  name
                CmbCustomerName.Focus()

            End If




        ElseIf Not TxtSaleInvoiceNo.Text = "" And SaleEditStatus = True Then

            If (MessageBox.Show(" Are you sure want to creat new invoice?", "Bizpro", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then


                'Clear All Data
                ClearAllData()

                'New Invoice
                NewInvoice()

                'Row clear Code
                GrdAvailableSerialNumber.Columns.Clear()
                GrdSale.Columns.Clear()

                'Focus on Custome  name
                CmbCustomerName.Focus()

            End If

        End If


    End Sub

    Private Sub cmbPaidBy_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbPaidBy.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.BtnSave.PerformClick()

        End If
    End Sub

    'Search Whole Sale Price From Product Information
    Sub SearchWholeSalePriceFromProductInformation()

        Try


            If Not CmbCustomerName.ValueMember = "" Or Not CmbCustomerName.Text = "" Then

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim cmd1 As New SqlCommand
                Dim dr As SqlDataReader
                Dim dr1 As SqlDataReader

                Dim WholeSalePrice As String



                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "SELECT  *FROM [Products]  WHERE [Product ID] = '" + cmbProductName.ValueMember + "'"

                'Dr for search wholesale price and declare in memory
                dr = cmd.ExecuteReader()
                dr.Read()


                If dr.HasRows Then

                    WholeSalePrice = (dr.Item("Wholesale Price").ToString)

                End If
                dr.Close()
                con.Close()


                '2nd dr for show whole sale price if customer is wholesaler
                con.Open()
                cmd1.Connection = con
                cmd1.CommandText = "select * from [Customer Information] join [Customer Category] on [Customer Information].[Customer Category ID]=[Customer Category].[Customer Category ID]  WHERE [Customer ID] = '" + CmbCustomerName.ValueMember + "'"
                dr1 = cmd1.ExecuteReader()
                dr1.Read()

                If dr1.HasRows Then

                    If dr1.Item("Customer Category Name").ToString = "WHOLESALER" Then
                        TxtSaleUnitPrice.Text = WholeSalePrice

                    End If
                End If
                dr1.Close()
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "SearchWholeSalePriceFromProductInformation")
        End Try
    End Sub
    'Privet sub for Search SalePrice on Customer
    Sub SearchSalePriceFromCustomerForSale()

        Try


            If Not CmbCustomerName.ValueMember = "" Then

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim dr As SqlDataReader

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "SELECT  *FROM [Customer price list]  WHERE [Product ID] = '" + cmbProductName.ValueMember + "' and [Customer ID]= '" + CmbCustomerName.ValueMember + "' "

                dr = cmd.ExecuteReader()
                dr.Read()

                If dr.HasRows Then

                    TxtSaleUnitPrice.Text = (dr.Item("Price").ToString)

                End If

                dr.Close()
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "SearchSalePriceFromCustomerForSale")
        End Try
    End Sub


    'Search Product Id From Products by barcode serial number and insert into sale
    Sub SearchBarcodeSerialNumberAndInsertIntoSale()

        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand
            Dim cmd2 As New SqlCommand
            Dim cmd3 As New SqlCommand
            'Dim dr As SqlDataReader
            Dim dr2 As SqlDataReader
            Dim dr3 As SqlDataReader


            'Clear Products Data For Barcode
            cleardataProductForBarcode()



            con.ConnectionString = FrmHome.ConnectionString
            con.Open()

            'cmd.Connection = con
            'cmd.CommandText = "Select * from [Products] where [Barcode Serial]='" + TxtSearchBarcode.Text + "'"

            'Search Product ID And Name And Set It In Variable
            'dr = cmd.ExecuteReader()
            'dr.Read()

            ' If dr.HasRows Then
            'ProductIDForBarcode = dr.Item("Product ID").ToString
            ' ProductNameForBarcode = dr.Item("Product Name").ToString
            ' ElseIf Not dr.HasRows Then
            'ProductIDForBarcode = 0

            'End If
            'dr.Close()


            cmd2.Connection = con
            cmd2.CommandText = "select top 1 [Purchase Date],[Purchase ID],[Supplier Name],[Product ID],[Product Name],[Branch Name],[Purchase Cost],[Sale Price],(isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))[Stock Available]from (select [Purchase].[Purchase Date],Purchase.[Purchase ID],[Supplier Information].[Supplier Name],[Products].[Product ID],[Products].[Product Name],[Branch Information].[Branch Name],[Branch Information].[Branch ID],Purchase.[Purchase Unit Cost][Purchase Cost],[Products].[Sale Price],case when [Purchase Quantity] =0  then (select isnull(sum( [Added Quantity]),0)[Added Quantity] from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  [Product Transfer].[Purchase ID]=Purchase.[Purchase ID] and [Product Transfer].Status='Added' and   [Product Transfer Invoice].Status='Complete'  and [Product Transfer].[Product ID]=Purchase.[Product ID]  group by [Purchase ID] )  ELSE isnull([Purchase].[Purchase Quantity],0) end [Purchase] ,(select isnull(sum([Sale Quantity]),0)      from  sale join [Sale Invoice] on sale.[Sale Invoice No]= [Sale Invoice].[Sale Invoice No] where Sale.[Branch ID]='" + FrmHome.lblBranchID.Text + "' and Sale.[Purchase ID]=Purchase.[Purchase ID]  group by [Purchase ID])[Sale],(select isnull(sum([Returned Quantity]),0)  from [Sale Return] join [Sale Return Invoice] on [Sale Return].[Sale Return Invoice No]=[Sale Return Invoice].[Sale Return Invoice No] where  [Sale Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Sale Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Sale Return],(select isnull(sum([Returned Quantity]),0)  from [Purchase Return] join [Purchase Return Invoice] on [Purchase Return].[Purchase Return Invoice No]=[Purchase Return Invoice].[Purchase Return Invoice No] where [Purchase Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Purchase Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Purchase Return], (select isnull(sum([Deducted Quantity]),0)  from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  Purchase.[Purchase ID]=[Product Transfer].[Purchase ID] and [Product Transfer].Status='Deducted'     group by [Purchase ID] )[Deducted]from Purchase  join Products on Purchase.[Product ID]=products.[Product ID]  join [Branch Information] on [Purchase].[Branch ID]=[Branch Information].[Branch ID]	  Join [Purchase Invoice] on [Purchase Invoice].[Purchase Invoice No]=[Purchase].[Purchase Invoice No] join [Supplier Information] on [Purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID] Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID]  Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID]  Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID]    where Purchase.[Branch ID]='" + FrmHome.lblBranchID.Text + "' And Products.[Barcode Serial] ='" + TxtSearchBarcode.Text + "'  ) as a   group by [Purchase Date],[Purchase ID],[Supplier Name],[Branch Name],[Product ID],[Product Name],[Purchase Cost],[Sale Price] having (isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))>0 order by [Purchase Date] asc "

            dr2 = cmd2.ExecuteReader
            dr2.Read()
            If dr2.HasRows Then

                cmbProductName.Text = dr2.Item("Product Name").ToString
                cmbProductName.ValueMember = dr2.Item("Product ID").ToString

                TxtPurchaseID.Text = dr2.Item("Purchase ID").ToString
                TxtSaleUnitPrice.Text = dr2.Item("Sale Price").ToString


                'Focus on quantity
                TxtQuantity.Focus()


                'Search Whole Sale Price From Product Information
                SearchWholeSalePriceFromProductInformation()

                'Search Discount Amount From Product Information
                SearchDiscountAmountFromProductInformation()

                'Privet sub for Search SalePrice on Customer
                SearchSalePriceFromCustomerForSale()

                'Search Available Serial Number or not
                SearchSerialStatus()

                'Search Warranty Days
                SearchWarrantyDays()

                'Serial Number Show if available
                'LoadComboBoxforSerialNumber()

                'Show Total Inserted Quantity
                ShowTotalInsertedQuantity()

            ElseIf Not dr2.HasRows Then
                'Clear Product Data
                cleardataProduct()
                'Focus on Barcode text box
                TxtSearchBarcode.Focus()
            End If
            dr2.Close()




            cmd3.Connection = con
            cmd3.CommandText = "SELECT * FROM [Sale] where [Product ID]='" + cmbProductName.ValueMember + "'  and [Sale Invoice No]='" + TxtSaleInvoiceNo.Text + "' "

            'Search Sale and send it to lable to update product
            dr3 = cmd3.ExecuteReader()
            dr3.Read()

            If dr3.HasRows Then
                lblSaleID.Text = dr3.Item("Sale ID").ToString
                TxtQuantity.Text = Val(TotalInsertedQuantity) + 1

                'show available quantity in sale
                ShowQuantityInLable()

            ElseIf Not dr3.HasRows Then

                lblSaleID.Text = "00"
                'show available quantity in sale
                ShowQuantityInLable()
                TxtQuantity.Text = Val(TotalInsertedQuantity) + 1

            End If
            dr3.Close()
            con.Close()





            'Set focus on
            If LblStatus.Text = "Available" Then
                CmbSerialNumber.Focus()

            ElseIf LblStatus.Text = "Not Available" And Not TxtSearchBarcode.Text = "" Then



                'Insert Data To Sale 
                InsertDataToSale()

                'Clear Product Data
                cleardataProduct()

                'Focus on Barcode text box
                TxtSearchBarcode.Focus()
            Else
                'Clear Product Data
                cleardataProduct()

                MsgBox("No product found.", MsgBoxStyle.Critical, "BizPro")

                'Focus on Barcode text box
                TxtSearchBarcode.Focus()

            End If



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "SearchBarcodeSerialNumberAndInsertIntoSale")
        End Try
    End Sub
    'Privet sub for Warranty days 
    Sub SearchWarrantyDays()
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Purchase]  WHERE [Purchase ID] = '" + TxtPurchaseID.Text + "' and [Product ID]= '" + cmbProductName.ValueMember + "' "

            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                TxtWarrantyDays.Text = (dr.Item("Warranty Days").ToString)

            End If

            dr.Close()
            con.Close()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "SearchWarrantyDays")
        End Try

    End Sub

    Private Sub TxtSearchBarcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearchBarcode.KeyDown

        If e.KeyCode = Keys.Enter Then

            If CmbCustomerName.Text = "" Then
                MsgBox("Please Select a Customer First.", MsgBoxStyle.OkOnly, "Sale")

                'Focus on Customer 'Combobox
                CmbCustomerName.Focus()
            Else

                'Search Product Id From Products by barcode serial number and insert into sale
                SearchBarcodeSerialNumberAndInsertIntoSale()
            End If
        End If
    End Sub

    Private Sub TxtSearchBarcode_MouseCaptureChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSearchBarcode.MouseCaptureChanged

    End Sub

    Private Sub TxtSearchBarcode_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TxtSearchBarcode.MouseClick
        Me.Text = "Barcode Sale System"
    End Sub

    Private Sub TxtSearchBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearchBarcode.TextChanged
        Me.Text = "Barcode Sale System"

        'Making Clear Data For Products For Barcode
        cleardataProductForBarcode()

    End Sub

    Private Sub LblSelectProduct_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblSelectProduct.Enter

    End Sub

  

    Private Sub cmbPaidBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPaidBy.SelectedIndexChanged
        If cmbPaidBy.Text = "DUE" Then
            TxtPaidAmount.Text = "00"
        End If
    End Sub

    Private Sub BtnInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInvoice.Click
        'Send Invoice Number to sale report
        RptSaleInvoice.SaleInvoiceNo = Me.TxtSaleInvoiceNo.Text

        RptSaleInvoice.ShowSaleInvoice()
        RptSaleInvoice.Show()
    End Sub

    Private Sub GrpCustomerInformation_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrpCustomerInformation.Enter

    End Sub

    Private Sub BtnPrint_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        MsgBox(Me.CmbCustomerName.ValueMember.ToString())

    End Sub

    Private Sub CmbCustomerName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCustomerName.SelectedIndexChanged


    End Sub


    'Insert Into Customer
    Sub InsertIntoCustomer()

        Try

            If CmbCustomerName.ValueMember = "" Then

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim cmd1 As New SqlCommand
                Dim cmd4 As New SqlCommand

                Dim currentDate As DateTime = DateTime.Today
                Dim currentTime As DateTime = DateTime.Now

                Dim con2 As New SqlConnection
                Dim cmd2 As New SqlCommand
                Dim dr1 As SqlDataReader

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
                cmd5.CommandText = "select [Head Of Account ID] from [Head Of Account] where [Account Name]='Supplier And Customer'"


                'Data reader find head of account then send it to insert chart of account as customer
                dr5 = cmd5.ExecuteReader()
                dr5.Read()
                If dr5.HasRows Then
                    HeadOfAccountID = (dr5.Item("Head Of Account ID").ToString)
                End If
                dr5.Close()


                cmd7.CommandText = "INSERT INTO [Chart Of Account] ([Head Of Account ID],[Account Name],[Prepared Time],[Prepared Date],[Computer ID],[User Account ID]) VALUES ('" + HeadOfAccountID + "','" + CmbCustomerName.Text + "','" + currentTime + "','" + currentDate + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "')"
                cmd7.ExecuteNonQuery()

                'Data reader find Chart of account then send it to insert  customer
                cmd6.CommandText = "SELECT top 1 [Chart of Account ID] FROM [Chart of Account] where [User Account ID]='" + FrmHome.LblUserID.Text + "' and [Computer ID]='" + FrmHome.LblComputerID.Text + "' order by [Chart of Account ID] DESC"
                dr6 = cmd6.ExecuteReader()
                dr6.Read()
                If dr6.HasRows Then
                    ChartOfAccountID = (dr6.Item("Chart Of Account ID").ToString)
                End If
                dr6.Close()
                con5.Close()




                con2.ConnectionString = FrmHome.ConnectionString
                con2.Open()
                cmd2.Connection = con2
                cmd2.CommandText = "SELECT top 1 [Customer Category ID] FROM [Customer Category]   order by [Customer Category ID] Asc"

                dr1 = cmd2.ExecuteReader()
                dr1.Read()


                con.ConnectionString = FrmHome.ConnectionString
                con.Open()

                If Not TxtCustomerDiscount.Text = "" Then
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO [Customer Information] ([Customer Name],[Customer Category ID],[Mobile No],[Address],[Discount Percentage],[Prepared Time],[Prepared Date],[Computer ID],[User Account ID],[Branch ID],[Status],[Sms Notification],[Chart Of Account ID],[Employee ID]) VALUES ('" + CmbCustomerName.Text + "','" + (dr1.Item("Customer Category ID").ToString) + "','" + TxtPhoneNo.Text + "','" + TxtAddress.Text + "','" + TxtCustomerDiscount.Text + "','" + currentTime + "','" + currentDate + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.lblBranchID.Text + "','CONNECTED','ON','" + ChartOfAccountID + "','" + FrmHome.EmployeeID.ToString + "')"
                    cmd.ExecuteNonQuery()
                ElseIf TxtCustomerDiscount.Text = "" Then
                    cmd4.Connection = con
                    cmd4.CommandText = "INSERT INTO [Customer Information] ([Customer Name],[Customer Category ID],[Mobile No],[Address],[Discount Percentage],[Prepared Time],[Prepared Date],[Computer ID],[User Account ID],[Branch ID],[Status],[SMS Notification],[Chart Of Account ID],[Employee ID]) VALUES ('" + CmbCustomerName.Text + "','" + (dr1.Item("Customer Category ID").ToString) + "','" + TxtPhoneNo.Text + "','" + TxtAddress.Text + "','0','" + currentTime + "','" + currentDate + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.lblBranchID.Text + "','CONNECTED','ON','" + ChartOfAccountID + "','" + FrmHome.EmployeeID.ToString + "')"
                    cmd4.ExecuteNonQuery()
                End If
                con.Close()
                dr1.Close()
                con2.Close()




                'Load Combobox For refresh
                'LoadComboBoxforcustomer()

                'Clear Data  Customer for refresh
                ' cleardataCustomer()



                Dim con3 As New SqlConnection
                Dim cmd3 As New SqlCommand
                Dim dr3 As SqlDataReader

                con3.ConnectionString = FrmHome.ConnectionString
                con3.Open()
                cmd3.Connection = con3
                cmd3.CommandText = "SELECT top 1 [Customer ID],[Customer Name] FROM [Customer Information] where [User Account ID]= '" + FrmHome.LblUserID.Text + "' and [Computer ID]='" + FrmHome.LblComputerID.Text + "'  order by [Customer ID] desc"

                dr3 = cmd3.ExecuteReader()
                dr3.Read()

                If dr3.HasRows Then
                    CmbCustomerName.ValueMember = (dr3.Item("Customer ID").ToString)
                    ' CmbCustomerName.Text = (dr3.Item("Customer Name").ToString)
                End If
                con3.Close()
                dr3.Close()

                'Show customer information
                customerInformation()

            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "InsertIntoCustomer")
        End Try

    End Sub

    Private Sub CmbCustomerName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbCustomerName.KeyPress
        'e.Handled = True

    End Sub

    Private Sub TxtSerialNumber_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)





    End Sub

    Sub LoadComboBoxforcustomer()

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

            CmbCustomerName.SelectedValue = 0



        Catch ex As Exception
            MessageBox.Show("Error while loading Customer record on table..." & ex.Message, "Load ComboBox for customer Sub")

        End Try

    End Sub


    Private Sub TxtSerialNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    End Sub

    Private Sub TxtSerialNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    'Load Combo Box for Serial Number
    'Sub LoadComboBoxforSerialNumber()

    '  Try


    '  Dim con1 As New SqlConnection
    'Dim cmd1 As New SqlCommand
    '   con1.ConnectionString = FrmHome.ConnectionString
    'Dim strSQL1 As String = "Select [Purchase Serial Number].[Purchase Serial Number] From [Purchase Serial Number] Where [Purchase Serial Number].[Status]='Available' And [Purchase Serial Number]. [Product ID]='" + cmbProductName.ValueMember + "' And [Branch ID]='" + FrmHome.lblBranchID.Text + "'"
    'Dim da1 As New System.Data.SqlClient.SqlDataAdapter(strSQL1, con1)
    ' Dim ds1 As New DataSet
    'da1.Fill(ds1, "[Purchase Serial Number]")
    '
    'With Me.CmbSerialNumber
    '.DataSource = ds1.Tables("[Purchase Serial Number]")
    '.DisplayMember = "Purchase Serial Number"
    ' End With

    'con1.Close()

    'Serial number combobox clear
    'CmbSerialNumber.Text = ""


    'Catch ex As Exception
    '   MessageBox.Show("Error while loading Customer record on table..." & ex.Message, "Load ComboBox for customer Sub")

    'End Try

    'End Sub

    'Insert And Update Into Sale Serial No And Purchase Serial No
    Sub InsertAndUpdateIntoSaleSerialNoAndPurchaseSerialNo()

        Try

            'Data Insert Code
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now
            Dim cmd2 As New SqlCommand



            Dim con3 As New SqlConnection
            Dim cmd3 As New SqlCommand
            Dim dr3 As SqlDataReader




            con3.ConnectionString = FrmHome.ConnectionString
            con3.Open()
            cmd3.Connection = con3
            cmd3.CommandText = "SELECT *from [Purchase Serial Number] where [Product ID]= '" + cmbProductName.ValueMember + "' And [Purchase Serial Number]='" + CmbSerialNumber.Text + "' And [Status]='Available' And [Branch ID]='" + FrmHome.lblBranchID.Text + "' "

            dr3 = cmd3.ExecuteReader()
            dr3.Read()

            If dr3.HasRows Then
                PurchaseInvoiceNo = dr3.Item("Purchase Invoice No").ToString

                'Pre insert in sale to insert in sale serial number with sale id
                If TxtQuantity.Text = "" Then
                    TxtQuantity.Text = 1
                End If

                'Insert or Update Product To Saale
                InsertOrUpdatesale()

                'Find Sale ID To Show In Lable
                FindSaleIDToShowInLableWhileInsertingSerialNumber()

                'Update And Insert Into Purchase And Sale Serial Number
                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd2.Connection = con
                cmd.CommandText = "INSERT INTO [Sale Serial Number] ([Product ID],[Sale Invoice No],[Sale Serial Number],[Status],[Purchase ID]) values ('" + cmbProductName.ValueMember + "','" + TxtSaleInvoiceNo.Text + "','" + CmbSerialNumber.Text + "','Sold','" + TxtPurchaseID.Text + "')"
                cmd2.CommandText = "Update [Purchase Serial Number] Set [Status]='Sold'  where [Product ID]= '" + cmbProductName.ValueMember + "' And [Purchase Serial Number]= '" + CmbSerialNumber.Text + "'    INSERT INTO [Sale Serial Number] ([Product ID],[Sale Invoice No],[Sale Serial Number],[Status],[Purchase ID],[Sale ID]) values ('" + cmbProductName.ValueMember + "','" + TxtSaleInvoiceNo.Text + "','" + CmbSerialNumber.Text + "','Sold','" + TxtPurchaseID.Text + "','" + lblSaleID.Text + "')"

                'cmd.ExecuteNonQuery()
                cmd2.ExecuteNonQuery()
                con.Close()

                'Refresh Data Serial Number 
                RefreshDataSerialNumber()

                'find total inserted  Serial Of Specific Product
                ShowTotalInsertedSerialOfSpecificProduct()

                'refresh available serial number to form sale serial number
                'FrmSaleSerialNumber.RefreshDataAvailableSerial()

                TxtQuantity.Text = GrdAvailableSerialNumber.RowCount

                'Insert or Update Product To Saale
                InsertOrUpdatesale()

                'Find Sale ID To Show In Lable
                FindSaleIDToShowInLableWhileInsertingSerialNumber()


                'Refresh Data After insert or update sale
                RefreshData()

                CmbSerialNumber.Text = ""
                CmbSerialNumber.Focus()

                'Serial Number Show if available
                'LoadComboBoxforSerialNumber()


                'Search Serial Number Details
                SearchSerialNumberForCurrentBranch()
            Else

                MsgBox("No Available Stock", MsgBoxStyle.OkOnly, "Sale")
            End If

            dr3.Close()
            con3.Close()


        Catch ex As Exception
            MessageBox.Show("Error while insert and updating record on table..." & ex.Message, "Insert And Update Into Sale Serial No And Purchase Serial No Sub")

        End Try






    End Sub

    'RefreshData For Select Single serial For sale
    Sub RefreshDataForSingleSerial()
        Try


            ' Load Data

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "Select [Purchase Serial Number].[Purchase Serial Number] From [Purchase Serial Number] Where [Purchase Serial Number].[Product ID]=   '" + cmbProductName.ValueMember + "'  And [Purchase Serial Number].[Purchase Serial Number] = '" + CmbSerialNumber.Text + "' And [Purchase Serial Number].[Status]='Available'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "Bizpro_Purchase Serial Number")
            connection.Close()
            GrdAvailableSerialNumber.DataSource = ds
            GrdAvailableSerialNumber.DataMember = "Bizpro_Purchase Serial Number"

            'GrdProductSubcategory.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductSubcategory.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            GrdAvailableSerialNumber.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            'Total Serial Number Count and show quantity in quantity text box
            NUmberOfRowForQuantityCount()

        Catch ex As Exception
            MessageBox.Show("Error while refreshing record on table..." & ex.Message, "Refresh Data For Single Serial Sub")

        End Try

    End Sub
    'Find PurchaseID To Show InCombobox
    Sub FindTotalRangeSerial()

        Try

            Dim TL As Integer
            Dim FirstLength As String
            TL = Me.TxtFromSerial.TextLength - 4
            Me.TxtFromSerial.SelectionStart = 0
            Me.TxtFromSerial.SelectionLength = TL
            FirstLength = TL

            Dim First As String
            First = (Me.TxtFromSerial.SelectedText)


            'Find the Last Section of the from serial text box
            Dim s As String = Me.TxtFromSerial.Text
            Dim LastFrom As String
            LastFrom = (s.Substring(s.Length - 4))

            'Find the Last Section of the to serial text box
            Dim L As String = Me.TxtToSerial.Text
            Dim LastTo As String
            LastTo = (L.Substring(L.Length - 4))


            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now

            If TxtQuantity.Text = "" Or Val(TxtQuantity.Text) = 0 Then
                TxtQuantity.Text = Val(TotalRangeSerialCount)
            End If

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            'Data reader for Product Id
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Select count([Purchase Serial Number].[Purchase Serial Number])[Transfer Serial Number]  From [Purchase Serial Number] Where [Purchase Serial Number].[Product ID]=   '" + cmbProductName.ValueMember + "'  And [Branch ID]='" + FrmHome.lblBranchID.Text + "' And [Purchase Serial Number].[Status]='Available' And left ([Purchase Serial Number].[Purchase Serial Number],'" + FirstLength + "' ) ='" + First + "' And RIGHT([Purchase Serial Number].[Purchase Serial Number], 4)  Between '" + LastFrom + "' And '" + LastTo + "' and [Branch ID]='" + FrmHome.lblBranchID.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then


                TotalRangeSerialCount = (dr.Item("Transfer Serial Number").ToString)



            End If

            dr.Close()
            con.Close()



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "FindTotalRangeSerial")
        End Try

    End Sub

    'Insert And Update Into Sale Serial No And Purchase Serial No
    Sub RfreshDataRangeSerialTransferBeforeInsert()

        Try

            Dim TL As Integer
            Dim FirstLength As String
            TL = Me.TxtFromSerial.TextLength - 4
            Me.TxtFromSerial.SelectionStart = 0
            Me.TxtFromSerial.SelectionLength = TL
            FirstLength = TL

            Dim First As String
            First = (Me.TxtFromSerial.SelectedText)


            'Find the Last Section of the from serial text box
            Dim s As String = Me.TxtFromSerial.Text
            Dim LastFrom As String
            LastFrom = (s.Substring(s.Length - 4))

            'Find the Last Section of the to serial text box
            Dim L As String = Me.TxtToSerial.Text
            Dim LastTo As String
            LastTo = (L.Substring(L.Length - 4))


            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now

            If TxtQuantity.Text = "" Or Val(TxtQuantity.Text) = 0 Then
                TxtQuantity.Text = Val(TotalRangeSerialCount)
            End If

            ' Load Data
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "Select top " + TxtQuantity.Text + " [Purchase Serial Number].[Purchase Serial Number][Transfer Serial Number]  From [Purchase Serial Number] Where [Purchase Serial Number].[Product ID]=   '" + cmbProductName.ValueMember + "'  And [Branch ID]='" + FrmHome.lblBranchID.Text + "' And [Purchase Serial Number].[Status]='Available' And left ([Purchase Serial Number].[Purchase Serial Number],'" + FirstLength + "' ) ='" + First + "' And RIGHT([Purchase Serial Number].[Purchase Serial Number], 4)  Between '" + LastFrom + "' And '" + LastTo + "' and [Branch ID]='" + FrmHome.lblBranchID.Text + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "Bizpro_Purchase Serial Number")
            connection.Close()
            GrdAvailableSerialNumber.DataSource = ds
            GrdAvailableSerialNumber.DataMember = "Bizpro_Purchase Serial Number"

            'GrdProductSubcategory.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductSubcategory.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            GrdAvailableSerialNumber.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            'Total Serial Number Count and show quantity in quantity text box
            'NUmberOfRowForQuantityCount()

            con.Close()


        Catch ex As Exception
            MessageBox.Show("Error while insert and updating record on table..." & ex.Message, "Insert Into Product SerialTransfer Sub")

        End Try






    End Sub

    'RefreshData For Select Range serial For sale
    Sub RefreshDataForRangeSerial()
        Try



            Dim TL As Integer
            Dim FirstLength As String
            TL = Me.TxtFromSerial.TextLength - 4
            Me.TxtFromSerial.SelectionStart = 0
            Me.TxtFromSerial.SelectionLength = TL
            FirstLength = TL

            Dim First As String
            First = (Me.TxtFromSerial.SelectedText)




            'Find the Last Section of the from serial text box
            Dim s As String = Me.TxtFromSerial.Text
            Dim LastFrom As String
            LastFrom = (s.Substring(s.Length - 4))

            'Find the Last Section of the to serial text box
            Dim L As String = Me.TxtToSerial.Text
            Dim LastTo As String
            LastTo = (L.Substring(L.Length - 4))





            ' Load Data

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "Select [Purchase Serial Number].[Purchase Serial Number] From [Purchase Serial Number] Where [Purchase Serial Number].[Product ID]=   '" + cmbProductName.ValueMember + "'   And [Purchase Serial Number].[Status]='Available'  And left ([Purchase Serial Number].[Purchase Serial Number],'" + FirstLength + "' ) ='" + First + "' And RIGHT([Purchase Serial Number].[Purchase Serial Number], 4)  Between '" + LastFrom + "' And '" + LastTo + "' and [Branch ID]='" + FrmHome.lblBranchID.Text + "'"
            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "Bizpro_Purchase Serial Number")
            connection.Close()
            GrdAvailableSerialNumber.DataSource = ds
            GrdAvailableSerialNumber.DataMember = "Bizpro_Purchase Serial Number"

            'GrdProductSubcategory.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdProductSubcategory.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            GrdAvailableSerialNumber.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            'Total Serial Number Count and show quantity in quantity text box
            TxtQuantity.Text = ((GrdAvailableSerialNumber.Rows.Count) + (TotalInsertedQuantity))



            'End Refresh Data
        Catch ex As Exception
            MessageBox.Show("Error while refreshing record on table..." & ex.Message, "Refresh Serial Record")
        Finally


        End Try

    End Sub

    Private Sub TxtToSerial_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtToSerial.KeyDown
        If e.KeyCode = Keys.Enter Then

            'RefreshData For Select Range serial For sale
            RefreshDataForRangeSerial()

            TxtWarrantyDays.Focus()

            TxtSaleAmount.Text = Val(TxtQuantity.Text) * Val(TxtSaleUnitPrice.Text)

            'find total range serial and sent it to variable
            FindTotalRangeSerial()

        End If

    End Sub

    Private Sub TxtToSerial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtToSerial.TextChanged

    End Sub

    Private Sub RdbRangeSerial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdbRangeSerial.CheckedChanged


        If RdbRangeSerial.Checked = True Then
            TxtFromSerial.Enabled = True

            TxtToSerial.Enabled = True

            TxtFromSerial.Focus()
            CmbSerialNumber.Text = ""

        ElseIf RdbRangeSerial.Checked = False Then
            TxtFromSerial.Enabled = False

            TxtToSerial.Enabled = False

        End If



    End Sub

    Private Sub TxtFromSerial_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtFromSerial.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtToSerial.Focus()
        End If
    End Sub

    'Total Serial Number Count and show quantity in quantity text box
    Sub NUmberOfRowForQuantityCount()
        Dim total As String = 0

        total = GrdAvailableSerialNumber.Rows.Count

        Me.TxtQuantity.Text = total


    End Sub

    Private Sub TxtFromSerial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtFromSerial.TextChanged

    End Sub

    Private Sub RdbRangeSerial_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RdbRangeSerial.Click

    End Sub

    Private Sub RdbRangeSerial_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RdbRangeSerial.MouseClick

    End Sub


    'Update And Insert Into Purchase And Sale Serial Number
    Sub UpdateAndInsertIntoPurchaseAndSaleSerialNumber()
        Try
            'Data Insert Code
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now
            Dim cmd2 As New SqlCommand





            Dim total As String = 0

            For i As Integer = 0 To GrdAvailableSerialNumber.RowCount - 1
                total += GrdAvailableSerialNumber.Rows(i).Cells(0).Value





                Dim con3 As New SqlConnection
                Dim cmd3 As New SqlCommand
                Dim dr3 As SqlDataReader

                con3.ConnectionString = FrmHome.ConnectionString
                con3.Open()
                cmd3.Connection = con3
                cmd3.CommandText = "SELECT *from [Purchase Serial Number] where [Product ID]= '" + cmbProductName.ValueMember + "' And [Purchase Serial Number]='" + GrdAvailableSerialNumber.Rows(i).Cells(0).Value.ToString + "' And [Status]='Available' And [Branch ID]='" + FrmHome.lblBranchID.Text + "' "

                dr3 = cmd3.ExecuteReader()
                dr3.Read()

                If dr3.HasRows Then

                    PurchaseInvoiceNo = dr3.Item("Purchase Invoice No").ToString


                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd2.Connection = con
                    cmd.CommandText = "INSERT INTO [Sale Serial Number] ([Product ID],[Sale Invoice No],[Sale Serial Number],[Status],[Purchase ID]) values ('" + cmbProductName.ValueMember + "', '" + TxtSaleInvoiceNo.Text + "' ,'" + GrdAvailableSerialNumber.Rows(i).Cells(0).Value.ToString + "' ,'Sold','" + TxtPurchaseID.Text + "')"
                    cmd2.CommandText = "Update [Purchase Serial Number] Set [Status]='Sold' where [Product ID]= '" + cmbProductName.ValueMember + "' And [Purchase Serial Number]= '" + GrdAvailableSerialNumber.Rows(i).Cells(0).Value.ToString + "'    INSERT INTO [Sale Serial Number] ([Product ID],[Sale Invoice No],[Sale Serial Number],[Status],[Purchase ID],[Sale ID]) values ('" + cmbProductName.ValueMember + "', '" + TxtSaleInvoiceNo.Text + "' ,'" + GrdAvailableSerialNumber.Rows(i).Cells(0).Value.ToString + "' ,'Sold','" + TxtPurchaseID.Text + "','" + lblSaleID.Text + "')"

                    'cmd.ExecuteNonQuery()
                    cmd2.ExecuteNonQuery()


                    con.Close()


                End If
                con3.Close()
                dr3.Close()
            Next


        Catch ex As Exception
            MessageBox.Show("Error while Marking record on table..." & ex.Message, "Update And Insert Into Purchase And SaleSerial Number")
        Finally

        End Try
    End Sub

    'Update And Delete Into Purchase And Sale Serial Number
    Sub UpdateAndDeleteIntoPurchaseAndSaleSerialNumber()

        Try


            'Data Insert Code
            Dim con As New SqlConnection
            Dim con1 As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now
            Dim cmd2 As New SqlCommand
            Dim dr As SqlDataReader




            Dim total As String = 0

            For i As Integer = 0 To GrdAvailableSerialNumber.RowCount - 1
                total += GrdAvailableSerialNumber.Rows(i).Cells(0).Value


                con1.ConnectionString = FrmHome.ConnectionString
                con1.Open()
                cmd1.Connection = con1
                cmd1.CommandText = "SELECT *from [Purchase Serial Number] where [Product ID]= '" + cmbProductName.ValueMember + "' And [Purchase Serial Number]='" + GrdAvailableSerialNumber.Rows(i).Cells(0).Value.ToString + "' And [Status]='Sold' And [Branch ID]='" + FrmHome.lblBranchID.Text + "' "

                dr = cmd1.ExecuteReader()
                dr.Read()

                If dr.HasRows Then



                    PurchaseInvoiceNo = dr.Item("Purchase Invoice No").ToString


                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd2.Connection = con
                    cmd.CommandText = "Update [Purchase Serial Number] Set [Status]='Available' where [Product ID]= '" + cmbProductName.ValueMember + "' And [Purchase Serial Number]= '" + GrdAvailableSerialNumber.Rows(i).Cells(0).Value.ToString + "'  Delete from [Sale Serial Number] where [Product ID]= '" + cmbProductName.ValueMember + "' And [Sale Serial Number]= '" + GrdAvailableSerialNumber.Rows(i).Cells(0).Value.ToString + "' And [Sale Invoice No] = '" + TxtSaleInvoiceNo.Text + "'  "
                    cmd2.CommandText = "Delete from [Sale Serial Number] where [Product ID]= '" + cmbProductName.ValueMember + "' And [Sale Serial Number]= '" + GrdAvailableSerialNumber.Rows(i).Cells(0).Value.ToString + "' And [Sale Invoice No] = '" + TxtSaleInvoiceNo.Text + "' "

                    cmd.ExecuteNonQuery()
                    'cmd2.ExecuteNonQuery()

                    con.Close()


                End If
                dr.Close()
                con1.Close()
            Next




        Catch ex As Exception
            MessageBox.Show("Error while Unmarking record on table..." & ex.Message, "UNmark All Button")
        End Try

    End Sub

    Private Sub TxtWarrantyDays_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtWarrantyDays.KeyDown
        If e.KeyCode = Keys.Enter Then

            TxtUnitDiscount.Focus()
        End If
    End Sub

    Private Sub TxtWarrantyDays_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtWarrantyDays.TextChanged

    End Sub

    Private Sub TxtCustomerDiscount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCustomerDiscount.KeyDown
        If e.KeyCode = Keys.Enter Then

            cmbProductName.Focus()

        End If

    End Sub

    Private Sub TxtCustomerDiscount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCustomerDiscount.TextChanged

    End Sub

    Private Sub TxtPhoneNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPhoneNo.KeyDown
        If e.KeyCode = Keys.Enter Then


            TxtAddress.Focus()

        End If


    End Sub

    Private Sub TxtPhoneNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPhoneNo.TextChanged

    End Sub

    Private Sub TxtAddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtAddress.KeyDown
        If e.KeyCode = Keys.Enter Then

            cmbProductName.Focus()

        End If


    End Sub

    Private Sub TxtAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtAddress.TextChanged

    End Sub

    Private Sub GrdAvailableSerialNumber_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdAvailableSerialNumber.CellContentClick

    End Sub

    Private Sub GrdAvailableSerialNumber_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdAvailableSerialNumber.CellContentDoubleClick

    End Sub

    Private Sub GrdAvailableSerialNumber_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdAvailableSerialNumber.CellMouseDoubleClick

        Try
            If DeletePermission = "Yes" Then


                If e.RowIndex >= 0 Then

                    Dim row As DataGridViewRow
                    row = Me.GrdAvailableSerialNumber.Rows(e.RowIndex)




                    'Data Insert Code
                    Dim con As New SqlConnection
                    Dim con2 As New SqlConnection
                    Dim cmd As New SqlCommand
                    Dim currentDate As DateTime = DateTime.Today
                    Dim currentTime As DateTime = DateTime.Now
                    Dim cmd2 As New SqlCommand
                    Dim cmd3 As New SqlCommand
                    Dim cmd4 As New SqlCommand

                    Dim Dr As SqlDataReader
                    Dim Dr1 As SqlDataReader



                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd3.Connection = con
                    cmd3.CommandText = "Select * From [Sale] join [Products] on Sale.[Product ID]=products.[Product ID]  Where [Sale ID]= '" + lblSaleID.Text + "'"

                    Dr = cmd3.ExecuteReader
                    Dr.Read()
                    If Dr.HasRows Then

                        cmbProductName.Text = Dr.Item("Product Name").ToString
                        cmbProductName.ValueMember = Dr.Item("Product ID").ToString
                        TxtQuantity.Text = Dr.Item("Sale Quantity").ToString
                        TxtPurchaseID.Text = Dr.Item("Purchase ID").ToString
                        TxtSaleUnitPrice.Text = Dr.Item("Sale Unit Price").ToString
                        TxtSaleAmount.Text = Dr.Item("Sale Amount").ToString
                        lblSaleID.Text = Dr.Item("Sale ID").ToString
                        TxtWarrantyDays.Text = Dr.Item("Warranty Days").ToString
                    End If
                    Dr.Close()



                    cmd4.Connection = con
                    cmd4.CommandText = "SELECT *from [Purchase Serial Number] where [Product ID]= '" + cmbProductName.ValueMember + "' And [Purchase Serial Number]='" + row.Cells("Sale Serial Number").Value.ToString + "' And [Status]='Sold' And [Branch ID]='" + FrmHome.lblBranchID.Text + "' "

                    Dr1 = cmd4.ExecuteReader()
                    Dr1.Read()

                    If Dr1.HasRows Then
                        PurchaseInvoiceNo = Dr1.Item("Purchase Invoice No").ToString



                        con2.ConnectionString = FrmHome.ConnectionString
                        con2.Open()
                        cmd.Connection = con2
                        cmd2.Connection = con2
                        cmd.CommandText = "Update [Purchase Serial Number] Set [Status]='Available'  where [Product ID]= '" + cmbProductName.ValueMember + "' And [Purchase Serial Number]= '" + row.Cells("Sale Serial Number").Value.ToString + "'  Delete from [Sale Serial Number] where [Product ID]= '" + cmbProductName.ValueMember + "' And [Sale Serial Number]= '" + row.Cells("Sale Serial Number").Value.ToString + "' And [Sale Invoice No] = '" + TxtSaleInvoiceNo.Text + "'  "
                        cmd2.CommandText = "Delete from [Sale Serial Number] where [Product ID]= '" + cmbProductName.ValueMember + "' And [Sale Serial Number]= '" + row.Cells("Sale Serial Number").Value.ToString + "' And [Sale Invoice No] = '" + TxtSaleInvoiceNo.Text + "' "

                        cmd.ExecuteNonQuery()
                        'cmd2.ExecuteNonQuery()
                        con2.Close()

                    End If
                    Dr1.Close()
                    con.Close()



                    'Refresh Data Serial Number To Gridview Click
                    RefreshDataSerialNumberToGridviewForCellMouseClick()

                    'NUmber Of Row For Quantity Count
                    NUmberOfRowForQuantityCount()

                    'Insert or Update Product To Saale
                    InsertOrUpdatesale()

                    'Refresh Data After insert or update sale
                    RefreshData()

                    'Insert or update Into Sale Invoice to show correct value to amount field in report
                    InsertOrUpdateIntoSaleInvoice()

                    'Making Clear Data For Products Update Serial Number
                    CleardataProductForUpdateSerialNumber()



                    'Load Combo Box for Serial Number
                    'LoadComboBoxforSerialNumber()

                End If
            Else
                MsgBox("You do not have permission to delete sale.", MsgBoxStyle.Critical, "Sale")
            End If

        Catch ex As Exception
            MessageBox.Show("Error while Unmarking record on table..." & ex.Message, "UNmark All Button")
        End Try

    End Sub
    'Find Sale ID To Show In Lable
    Sub FindSaleIDToShowInLableWhileSelectingNewProduct()

        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            'Data reader for Product Id
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  top 1 * FROM [Sale]  WHERE [Purchase ID] = '" + TxtPurchaseID.Text + "' And [Product ID]='" + cmbProductName.ValueMember + "' And [Sale Invoice No]= '" + TxtSaleInvoiceNo.Text + "' and [User Account ID]='" + FrmHome.LblUserID.Text + "' and[Computer ID]='" + FrmHome.LblComputerID.Text + "' and [Branch ID]='" + FrmHome.lblBranchID.Text + "' order by [Sale ID] Desc"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then
                lblSaleID.Text = (dr.Item("Sale ID").ToString)
                'TxtQuantity.Text = (dr.Item("Sale Quantity").ToString)
                'TxtSaleUnitPrice.Text = (dr.Item("Sale Unit Price").ToString)
                'TxtWarrantyDays.Text = (dr.Item("Warranty Days").ToString)
                'Show Available stock to lable
                ShowQuantityInLable()

                'Refresh Data Serial Number To Gridview  Click
                RefreshDataSerialNumberToGridviewForCellMouseClick()
            Else
                lblSaleID.Text = "00"
                TxtQuantity.Text = ""
            End If

            dr.Close()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "FindSaleIDToShowInLableWhileSelectingNewProduct")
        End Try

    End Sub

    'Find Sale ID To Show In Lable
    Sub FindSaleIDToShowInLableWhileInsertingSerialNumber()

        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            'Data reader for Product Id
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT  *FROM [Sale]  WHERE [Purchase ID] = '" + TxtPurchaseID.Text + "' And [Sale Invoice No]= '" + TxtSaleInvoiceNo.Text + "'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                lblSaleID.Text = (dr.Item("Sale ID").ToString)



            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "FindSaleIDToShowInLableWhileInsertingSerialNumber")
        End Try

    End Sub

    'Find PurchaseID To Show InCombobox
    Sub FindPurchaseIDToShowInCombobox()

        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            'Data reader for Product Id
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "select [Purchase ID],(isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0)) -(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0)) [Stock Available] from ( select [Purchase].[Purchase Date],Purchase.[Purchase ID],[Supplier Information].[Supplier Name],[Products].[Product ID],[Products].[Product Name],[Branch Information].[Branch Name],[Branch Information].[Branch ID],Purchase.[Purchase Unit Cost][Purchase Cost],[Products].[Sale Price], case when [Purchase Quantity] =0  then  (select isnull(sum( [Added Quantity]),0)[Added Quantity] from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  [Product Transfer].[Purchase ID]=Purchase.[Purchase ID] and [Product Transfer].Status='Added' and   [Product Transfer Invoice].Status='Complete'  and [Product Transfer].[Product ID]=Purchase.[Product ID]  group by [Purchase ID] )   ELSE isnull([Purchase].[Purchase Quantity],0) end [Purchase] , (select isnull(sum([Sale Quantity]),0)      from  sale join [Sale Invoice] on sale.[Sale Invoice No]= [Sale Invoice].[Sale Invoice No] where Sale.[Branch ID]='" + FrmHome.lblBranchID.Text + "' and Sale.[Purchase ID]=Purchase.[Purchase ID]  group by [Purchase ID])[Sale], (select isnull(sum([Returned Quantity]),0)  from [Sale Return] join [Sale Return Invoice] on [Sale Return].[Sale Return Invoice No]=[Sale Return Invoice].[Sale Return Invoice No] where  [Sale Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Sale Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Sale Return], (select isnull(sum([Returned Quantity]),0)  from [Purchase Return] join [Purchase Return Invoice] on [Purchase Return].[Purchase Return Invoice No]=[Purchase Return Invoice].[Purchase Return Invoice No] where [Purchase Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Purchase Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Purchase Return],  (select isnull(sum([Deducted Quantity]),0)  from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  Purchase.[Purchase ID]=[Product Transfer].[Purchase ID] and [Product Transfer].Status='Deducted'     group by [Purchase ID] )[Deducted] from Purchase  join Products on Purchase.[Product ID]=products.[Product ID]   join [Branch Information] on [Purchase].[Branch ID]=[Branch Information].[Branch ID]	   Join [Purchase Invoice] on [Purchase Invoice].[Purchase Invoice No]=[Purchase].[Purchase Invoice No]  join [Supplier Information] on [Purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID]  Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID]  Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID]   Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID]    where Purchase.[Branch ID]='" + FrmHome.lblBranchID.Text + "'  and products. [Product ID] = '" + Me.cmbProductName.ValueMember + "' ) as a  group by [Purchase Date],[Purchase ID],[Supplier Name],[Branch Name],[Product ID],[Product Name],[Purchase Cost],[Sale Price] having (isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))>0"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                TxtPurchaseID.Text = (dr.Item("Purchase ID").ToString)


                'Find Sale ID To Show In Lable
                FindSaleIDToShowInLableWhileSelectingNewProduct()


                lblQuantityAvailable.Text = (dr.Item("Stock Available").ToString)

            ElseIf Not dr.HasRows Then
                'Clear Data Products
                cleardataProduct()

            End If

            dr.Close()
            con.Close()



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "FindPurchaseIDToShowInCombobox")
        End Try

    End Sub


    Private Sub CmbSerialNumber_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbSerialNumber.GotFocus
        If SaleEditStatus = True Then
            'Find Branch ID For Edit Sale
            FindBranchIDForEditSale()

        ElseIf Not SaleEditStatus = True Then
            'Find Current User Branch ID 
            FindCurrentUserBranchID()
        End If
    End Sub

    Private Sub performActionForSerialEntry(ByVal e As Keys)


        If e = Keys.Enter Then


            'Show Available stock to lable
            ShowQuantityInLable()

            If CmbSerialNumber.Text = "" Then

                TxtWarrantyDays.Focus()

                'invisible number gridview 
                GrdSerialNumber.Visible = False
            Else

                RdbRangeSerial.Checked = False

                'Insert into customer
                InsertIntoCustomer()

                'Insert or update Into Sale Invoice code
                InsertOrUpdateIntoSaleInvoice()

                'If sale invoice no is blank would not insert into sale
                If Not TxtSaleInvoiceNo.Text = "" Then





                    If Val(TxtQuantity.Text) = Val(lblQuantityAvailable.Text) Then
                        'Find Purchase Id and show it in combobox
                        FindPurchaseIDToShowInCombobox()


                        'Insert And Update Into Sale Serial No And Purchase Serial No and sale invoice
                        InsertAndUpdateIntoSaleSerialNoAndPurchaseSerialNo()




                    ElseIf Val(TxtQuantity.Text) < Val(lblQuantityAvailable.Text) Then

                        'Insert And Update Into Sale Serial No And Purchase Serial No and sale invoice
                        InsertAndUpdateIntoSaleSerialNoAndPurchaseSerialNo()




                    End If
                    'find total inserted  Serial Of Specific Product
                    'ShowTotalInsertedSerialOfSpecificProduct()
                End If

                'Insert or update Into Sale Invoice code For Update Sale Invoice Amount
                InsertOrUpdateIntoSaleInvoice()

            End If
        End If

    End Sub

    Private Sub CmbSerialNumber_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbSerialNumber.KeyDown
        If e.KeyCode = Keys.Down Then

            'Resize Serial List Grid view and Make it visible
            ResizeSerialListGridviewandMakeitvisible()


            GrdSerialNumber.Focus()


            'Search SerialNumber For Current Branch
            SearchSerialNumberForCurrentBranch()


        ElseIf e.KeyCode = Keys.Up Then

            'Resize Serial List Grid view and Make it visible
            ResizeSerialListGridviewandMakeitvisible()


            GrdSerialNumber.Focus()

            'Search SerialNumber For Current Branch
            SearchSerialNumberForCurrentBranch()


        ElseIf e.KeyCode = Keys.Enter Then

            'Show Serial Number to textbox
            'ShowSerialNumberToTextboxes()

            performActionForSerialEntry(Keys.Enter)

       
        End If

    End Sub

    Private Sub CmbSerialNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbSerialNumber.KeyPress


        If Not cmbProductName.Text = "" And Not cmbProductName.ValueMember = "" Then

            'Resize Serial List Grid view and Make it visible
            ResizeSerialListGridviewandMakeitvisible()

            'Search Serial Number Details
            SearchSerialNumberForCurrentBranch()




        ElseIf cmbProductName.Text = "" Then

            GrdSerialNumber.Visible = False
            GrdSerialNumber.Columns.Clear()


        End If

    End Sub


    Private Sub CmbSerialNumber_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbSerialNumber.LostFocus
        If SaleEditStatus = True Then
            'Find Current User Branch ID 
            FindCurrentUserBranchID()
        End If
    End Sub

    Private Sub CmbSerialNumber_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CmbSerialNumber.MouseClick
        'Range Serial Number is checking off clicking serial number
        RdbRangeSerial.Checked = False

        'Resize Serial List Grid view and Make it visible
        ResizeSerialListGridviewandMakeitvisible()

        'Search SerialNumber For Current Branch
        SearchSerialNumberForCurrentBranch()

    End Sub
    'Search SerialNumber For Current Branch
    Sub SearchSerialNumberForCurrentBranch()
        ' Load Data
        Try
           

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "Select [Purchase Serial Number].[Purchase Serial Number] From [Purchase Serial Number] Where [Purchase Serial Number].[Status]='Available' And [Purchase Serial Number]. [Product ID]='" + cmbProductName.ValueMember + "' And [Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Purchase Serial Number] like '%" + CmbSerialNumber.Text + "%' "


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Purchase Serial Number")
            connection.Close()
            GrdSerialNumber.DataSource = ds
            GrdSerialNumber.DataMember = "BizPro_Purchase Serial Number"


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            GrdSerialNumber.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records")
        Finally

        End Try

        'End Refresh Data

    End Sub
    'Resize Serial List Gridviewand Make it visible
    Sub ResizeSerialListGridviewandMakeitvisible()
        GrdSerialNumber.Visible = True
        GrdSerialNumber.Width = 177
        GrdSerialNumber.Height = 200

        'Column visiblity false
        GrdSerialNumber.ColumnHeadersVisible = False

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSerialNumber.SelectedIndexChanged

    End Sub

    Private Sub BtnSave_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BtnSave.KeyDown

    End Sub

    Private Sub TxtBalance_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBalance.KeyDown

    End Sub

    Private Sub TxtBalance_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBalance.TextChanged

    End Sub



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub







    'Insert into sale by loop
    Sub InsertIntoSaleByLoop()

        Try

            Dim con As New SqlConnection
            Dim con1 As New SqlConnection
            Dim cmd As New SqlCommand
            Dim cmd1 As New SqlCommand
            Dim cmd2 As New SqlCommand

            Dim dr As SqlDataReader


            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now




            'Data reader for Product Id
            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd1.Connection = con
            cmd.Connection = con
            cmd.CommandText = "SELECT  isnull(sum([Sale Quantity]),0)[Sale quantity]  FROM [Sale]  WHERE  [Product ID]='" + cmbProductName.ValueMember + "' And [Sale Invoice No]= '" + TxtSaleInvoiceNo.Text + "' and not [Bonus Status]='Bonus'"
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then


                If Val(dr.Item("Sale Quantity").ToString) < Val(QuantityWritten) Then

                    'Find Purchase ID To Show In TextBox
                    FindPurchaseIDToShowInCombobox()



                    Dim QuantityRemaining As String
                    QuantityRemaining = Val(QuantityWritten) - Val(dr.Item("Sale Quantity").ToString)

                    If Val(lblQuantityAvailable.Text) > Val(QuantityRemaining) Then
                        TxtQuantity.Text = QuantityRemaining


                    Else
                        TxtQuantity.Text = Val(lblQuantityAvailable.Text)
                    End If

                    If Not TxtSaleInvoiceNo.Text = "" Then


                        'Insert Into Sale
                        InsertIntosale()

                        'Find Sale ID
                        FindSaleIDToShowInLableWhileSelectingNewProduct()

                        'Refresh Data sale
                        RefreshData()


                        If RdbRangeSerial.Checked = True Then
                            'Insert And Update Into Sale Serial No And Purchase Serial No
                            RfreshDataRangeSerialTransferBeforeInsert()

                            'Update And Insert Into Purchase And Sale Serial Number
                            UpdateAndInsertIntoPurchaseAndSaleSerialNumber()
                        End If


                    End If
                End If

                TotalInsertedQuantity = Val(dr.Item("sale Quantity").ToString)

            ElseIf Not dr.HasRows Then
                TxtQuantity.Text = Val(lblQuantityAvailable.Text)


                If Not TxtSaleInvoiceNo.Text = "" Then



                    'Insert Into Sale
                    InsertIntosale()


                    'Refresh Data sale
                    RefreshData()



                    If RdbRangeSerial.Checked = True Then
                        'Insert And Update Into Sale Serial No And Purchase Serial No
                        RfreshDataRangeSerialTransferBeforeInsert()

                        'Update And Insert Into Purchase And Sale Serial Number
                        UpdateAndInsertIntoPurchaseAndSaleSerialNumber()
                    End If

                End If
                TotalInsertedQuantity = Val(dr.Item("sale Quantity").ToString)
            End If




            dr.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "InsertIntoSaleByLoop")
        End Try
    End Sub



    Private Sub PnlSale_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PnlSale.Paint

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

    Private Sub Panel2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseMove
        'If e.Button = Windows.Forms.MouseButtons.Left Then
        'newpoint = Control.MousePosition
        'newpoint.X -= (X)
        'newpoint.Y -= (Y)
        'Me.Location = newpoint

        'End If
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Sub InsertOrUpdatePurchase()







        If lblSaleID.Text = "00" Then

            'Data Insert Code
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now
            Try

                'Empty Txt Box Can Not Be Save Code
                If cmbProductName.ValueMember = "" Or cmbProductName.Text = "" Or TxtQuantity.Text = "" Then
                    MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Purchase")

                Else

                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO [Purchase] ([Purchase Invoice No],[Product ID],[Purchase Location ID],[Purchase Quantity],[Purchase Unit Cost],[Amount],[Branch ID],[Computer ID],[User Account ID],[Purchase Date],[Purchase Serial Number],[Warranty Days]) VALUES ('" + PurchaseInvoiceNoForAdvanceSale + "','" + cmbProductName.ValueMember + "','1','" + TxtQuantity.Text + "','0','0','" + FrmHome.lblBranchID.Text + "','" + FrmHome.LblComputerID.Text + "','" + FrmHome.LblUserID.Text + "','" + DtpSaleDate.Value + "','" + CmbSerialNumber.Text + "" + TxtFromSerial.Text + "-" + TxtToSerial.Text + "','" + TxtWarrantyDays.Text + "')"
                    cmd.ExecuteNonQuery()
                    con.Close()
                End If


            Catch ex As Exception
                MessageBox.Show("Error while inserting record on table..." & ex.Message, "InsertOrUpdate Records")
            Finally


            End Try

        Else

            'Data Update Code
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now

            Try

                If CmbCustomerName.ValueMember = "" Or CmbCustomerName.Text = "" Or cmbProductName.ValueMember = "" Or cmbProductName.Text = "" Or TxtQuantity.Text = "" Or TxtSaleUnitPrice.Text = "" Or TxtSaleAmount.Text = "" Then
                    MsgBox("Required field can not be empty", MsgBoxStyle.OkOnly, "Purchase")

                Else
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "UPDATE [Purchase] SET [Purchase Invoice No]= '" + PurchaseInvoiceNoForAdvanceSale + "',[Product ID]= '" + cmbProductName.ValueMember + "',[Purchase Quantity]= '" + TxtQuantity.Text + "',[Branch ID]= '" + FrmHome.lblBranchID.Text + "',[Computer ID]= '" + FrmHome.LblComputerID.Text + "',[User Account ID]= '" + FrmHome.LblUserID.Text + "',[Warranty Days]='" + TxtWarrantyDays.Text + "' WHERE [Purchase Invoice No]= '" + PurchaseInvoiceNoForAdvanceSale + "' and [Product ID]='" + cmbProductName.ValueMember + "'"
                    cmd.ExecuteNonQuery()
                    con.Close()

                End If


            Catch ex As Exception
                MessageBox.Show("Error while Updating record on table..." & ex.Message, "Update Records")
            Finally

            End Try
        End If


    End Sub

    Sub InsertIntoPurchaseInvoice()

        'Insert Into Purchase Invoice code
        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            Dim con2 As New SqlConnection
            Dim cmd2 As New SqlCommand
            Dim dr1 As SqlDataReader

            Dim currentDate As DateTime = DateTime.Today
            Dim currentTime As DateTime = DateTime.Now




            If Val(PurchaseInvoiceNoForAdvanceSale) = "0" Then


                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "INSERT INTO [Purchase Invoice] ([Memo No],[Total],[Previous Dues],[Advance],[Vat percentage],[Vat],[Discount Percentage],[Discount],[Net Payable],[Paid Amount],[Balance],[Return Amount],[Status],[Supplier ID],[Purchase Date],[Purchase Time],[User Account ID],[Computer ID],[Paid By],[Prepared Date]) values ('00','00','00','00','00','00','00','00','00','00','00','00','Pending','" + CmbCustomerName.ValueMember + "','" + DtpSaleDate.Value + "','" + currentTime + "','" + FrmHome.LblUserID.Text + "','" + FrmHome.LblComputerID.Text + "','" + cmbPaidBy.SelectedValue.ToString + "','" + currentDate + "')"
                cmd.ExecuteNonQuery()
                con.Close()


                con2.ConnectionString = FrmHome.ConnectionString
                con2.Open()
                cmd2.Connection = con2
                cmd2.CommandText = "SELECT top 1 [Purchase Invoice No] FROM [Purchase Invoice] where [User Account ID]= '" + FrmHome.LblUserID.Text + "' and [Computer ID]= '" + FrmHome.LblComputerID.Text + "' order by [Purchase Invoice No] desc"

                dr1 = cmd2.ExecuteReader()
                dr1.Read()
                If dr1.HasRows Then


                    PurchaseInvoiceNoForAdvanceSale = (dr1.Item("Purchase Invoice No").ToString)
                End If
                con2.Close()
                dr1.Close()

            End If

        Catch ex As Exception
            MessageBox.Show("Error while Inserting to Purchase invoice record on table..." & ex.Message, "Insert Records Purchase Invoice")
        Finally

        End Try



    End Sub

  

    'Find Total Serial Number From Purchase Serial Number
    Sub FindTotalSerialNumberFromPurchaseSerialNumber()


        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader




            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "select count([Purchase Serial Number])[Total] from [Purchase Serial Number] Where [Product ID]='" + cmbProductName.ValueMember + "' and [Purchase Invoice No]='" + PurchaseInvoiceNoForAdvanceSale + "'"


            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then


                TxtQuantity.Text = dr.Item("Total").ToString
            End If
            dr.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while  permission delete to form..." & ex.Message, "Form Load")

        End Try


    End Sub
    'Insert Single Serial Into Purchase And  Serial Number
    Sub InsertSingleSerialtoPurchaseSerialNumber()
        Try
            'Data Insert Code
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand


            Dim total As String = 0



            Dim con3 As New SqlConnection
            Dim cmd3 As New SqlCommand
            Dim dr3 As SqlDataReader

            con3.ConnectionString = FrmHome.ConnectionString
            con3.Open()
            cmd3.Connection = con3
            cmd3.CommandText = "SELECT *from [Purchase Serial Number] where [Product ID]= '" + cmbProductName.ValueMember + "' And [Purchase Serial Number]='" + CmbSerialNumber.Text + "' "

            dr3 = cmd3.ExecuteReader()
            dr3.Read()

            If Not dr3.HasRows Then

                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "INSERT INTO [Purchase Serial Number] ([Product ID],[Purchase Invoice No],[Purchase Serial Number],[Status],[Branch ID]) values ('" + cmbProductName.ValueMember + "', '" + PurchaseInvoiceNoForAdvanceSale + "' ,'" + CmbSerialNumber.Text + "' ,'Available','" + FrmHome.lblBranchID.Text + "')"
                cmd.ExecuteNonQuery()
                con.Close()


                RdbRangeSerial.Checked = False

            Else
                MsgBox("This Serial Number Already exists", MsgBoxStyle.OkOnly, "Purchase")

            End If


            dr3.Close()
            con3.Close()


            'Refresh Data Serial Number To Grid view For Cell Mouse Click
            'RefreshDataSerialNumberToGridviewForCellMouseClick()

            'Find Total Serial Number From Purchase Serial Number
            FindTotalSerialNumberFromPurchaseSerialNumber()

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Insert Into Purchase Serial")
        Finally

        End Try
    End Sub



    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub FrmSale_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        If SaleEditStatus = True Then
            'Find Current User Branch ID 
            FindCurrentUserBranchID()
        End If
    End Sub

    Private Sub FrmSale_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave

    End Sub


    Private Sub FrmSale_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        'Hide product list
        GrdProductList.Visible = False
        GrdCustomerList.Visible = False
        GrdSerialNumber.Visible = False
    End Sub
    'Search By Product Name For Current Branch
    Sub SearchByProductNameForCurrentBranch()
        ' Load Data
        Try
            

            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select  top 10  [Purchase Date],[Product ID],[Product Name], cast(cast([Sale Price] as decimal(18,5)) as float) [Sale Price] ,cast(cast((isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0)) as decimal (18,5)) as float) [Stock Available],cast(cast([Purchase Cost] as decimal (18,5))as float) [Purchase Cost],[Product Subcategory Name]    from (select [Purchase].[Purchase Date],Purchase.[Purchase ID],[Supplier Information].[Supplier Name],[Products].[Product ID],[Products].[Product Name],[Branch Information].[Branch Name],[Branch Information].[Branch ID],Purchase.[Purchase Unit Cost][Purchase Cost],[Products].[Sale Price],case when [Purchase Quantity] =0  then (select isnull(sum( [Added Quantity]),0)[Added Quantity] from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  [Product Transfer].[Purchase ID]=Purchase.[Purchase ID] and [Product Transfer].Status='Added' and   [Product Transfer Invoice].Status='Complete'  and [Product Transfer].[Product ID]=Purchase.[Product ID]  group by [Purchase ID] )  ELSE isnull([Purchase].[Purchase Quantity],0) end [Purchase] ,(select isnull(sum([Sale Quantity]),0)   from  sale join [Sale Invoice] on sale.[Sale Invoice No]= [Sale Invoice].[Sale Invoice No] where Sale.[Branch ID]='" + FrmHome.lblBranchID.Text + "' and Sale.[Purchase ID]=Purchase.[Purchase ID]  group by [Purchase ID])[Sale],(select isnull(sum([Returned Quantity]),0)  from [Sale Return] join [Sale Return Invoice] on [Sale Return].[Sale Return Invoice No]=[Sale Return Invoice].[Sale Return Invoice No] where  [Sale Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Sale Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Sale Return],(select isnull(sum([Returned Quantity]),0)  from [Purchase Return] join [Purchase Return Invoice] on [Purchase Return].[Purchase Return Invoice No]=[Purchase Return Invoice].[Purchase Return Invoice No] where [Purchase Return].[Branch ID]='" + FrmHome.lblBranchID.Text + "' and [Purchase Return].[Purchase ID]=Purchase.[Purchase ID]   group by [Purchase ID])[Purchase Return], (select isnull(sum([Deducted Quantity]),0)  from [Product Transfer] join [Product Transfer Invoice] on [Product Transfer].[Transfer Invoice No]=[Product Transfer Invoice].[Transfer Invoice No] where [Product Transfer].[Transfer Branch ID]='" + FrmHome.lblBranchID.Text + "' and  Purchase.[Purchase ID]=[Product Transfer].[Purchase ID] and [Product Transfer].Status='Deducted'     group by [Purchase ID] )[Deducted],[Product Subcategory].[Product Subcategory Name] from Purchase  join Products on Purchase.[Product ID]=products.[Product ID]  join [Branch Information] on [Purchase].[Branch ID]=[Branch Information].[Branch ID]	  Join [Purchase Invoice] on [Purchase Invoice].[Purchase Invoice No]=[Purchase].[Purchase Invoice No] join [Supplier Information] on [Purchase Invoice].[Supplier ID]=[Supplier Information].[Supplier ID] Join [Product Category] on Products.[Product Category ID]= [Product Category].[Product Category ID]  Join [Product Group] on Products.[Product Group ID]= [Product Group].[Product Group ID]  Join [Product SubCategory] on Products.[Product SubCategory ID]= [Product SubCategory].[Product SubCategory ID]    where Purchase.[Branch ID]='" + FrmHome.lblBranchID.Text + "' And products. [Product Name] LIKE '%" + cmbProductName.Text + "%') as a  group by [Purchase Date],[Purchase ID],[Supplier Name],[Branch Name],[Product ID],[Product Name],[Purchase Cost],[Sale Price],[Product Subcategory Name] having (isnull(sum ([Purchase]),0)+isnull(sum (case when   [Sale Return] is null then  00 else  [Sale Return] end ) ,0))-(isnull(sum (case when   [Sale] is null then  00 else  Sale end) ,0)+isnull(sum ( case when   [Purchase Return] is null then  00 else  [Purchase Return] end ) ,0)+isnull(sum (case when   [Deducted] is null then  00 else  [Deducted] end ),0))>0"


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Purchase")
            connection.Close()
            GrdProductList.DataSource = ds
            GrdProductList.DataMember = "BizPro_Purchase"


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            GrdProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells


        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records")
        Finally

        End Try

        'End Refresh Data

    End Sub
    'Search By Customer Name For Current Branch
    Sub SearchByCustomerNameForCurrentBranch()
        ' Load Data
        Try
         


            Dim connectionString As String = FrmHome.ConnectionString
            Dim sql As String = "select  [Customer ID], [Customer Name],[Mobile No] from [Customer Information] where [Customer Name]+[Mobile No] LIKE '%" + CmbCustomerName.Text + "%' or [Customer Name] LIKE '%" + CmbCustomerName.Text + "%'"


            Dim connection As New SqlConnection(connectionString)
            Dim dataadapter As New SqlDataAdapter(sql, connection)
            Dim ds As New DataSet()
            connection.Open()
            dataadapter.Fill(ds, "BizPro_Customer Information")
            connection.Close()
            GrdCustomerList.DataSource = ds
            GrdCustomerList.DataMember = "BizPro_Customer Information"


            'GrdLanguageSetting.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
            'GrdLanguageSetting.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)

            GrdCustomerList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells


            If GrdCustomerList.RowCount < 1 Then
                GrdCustomerList.Visible = False
            End If

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "Show Records")
        Finally

        End Try

        'End Refresh Data

    End Sub
    'Resize Product List Gridviewand Make it visible
    Sub ResizeProductListGridviewandMakeitvisible()
        GrdProductList.Visible = True
        GrdProductList.Width = 600
        GrdProductList.Height = 113

        'Column visiblity false
        GrdProductList.ColumnHeadersVisible = False

    End Sub

    Private Sub cmbProductName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbProductName.TextChanged
        If Not cmbProductName.Text = "" And lblSaleID.Text = "00" Then

            'Resize Product List Gridviewand Make it visible
            ResizeProductListGridviewandMakeitvisible()

            'Search Product Details
            SearchByProductNameForCurrentBranch()




        ElseIf cmbProductName.Text = "" Then

            GrdProductList.Visible = False

            'Clear Data Products For Drop down
            cleardataProductForDropdown()

        End If
    End Sub

    Private Sub cmbProductName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProductName.SelectedIndexChanged

    End Sub

    Private Sub GrdProductList_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdProductList.CellContentClick

    End Sub


    Private Sub cmbProductName_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbProductName.Leave

    End Sub
    'Show product details to textbox
    Sub ShowProductDetailsToTextboxes()
        Try

            Dim i As Integer
            i = GrdProductList.CurrentRow.Index






            'Show value member to combobox
            cmbProductName.ValueMember = GrdProductList.Item(1, i).Value



            'FrmSale.TxtPurchaseID.Text = GrdStockInformation.Item(1, i).Value

            TxtSaleUnitPrice.Text = GrdProductList.Item(3, i).Value


            'Serial Number Show if available
            'LoadComboBoxforSerialNumber()


            'show available quantity in sale
            ShowQuantityInLable()



            'Search Whole Sale Price From Product Information
            SearchWholeSalePriceFromProductInformation()

            'Search Discount Amount From Product Information
            SearchDiscountAmountFromProductInformation()

            'Privet sub for Search SalePrice on Customer
            SearchSalePriceFromCustomerForSale()

            'Search Available Serial Number or not
            SearchSerialStatus()

            'Search Warranty Days
            SearchWarrantyDays()



            'Find Sale ID To Show In Lable
            FindSaleIDToShowInLableWhileSelectingNewProduct()



            'Find Last Sold Product Price
            FindLastSoldProductPrice()

            'Find PurchaseID To Show InCombobox
            FindPurchaseIDToShowInCombobox()

            'Show Product name to combobox
            cmbProductName.Text = GrdProductList.Item(2, i).Value




            'Focus on quantity
            If LblStatus.Text = "Available" Then
                CmbSerialNumber.Focus()
            Else

                TxtQuantity.Focus()
            End If

            'hide product list gridview
            GrdProductList.Visible = False




        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

        End Try
    End Sub

    Private Sub GrdProductList_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdProductList.CellMouseClick

    End Sub


    Private Sub GrdProductList_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdProductList.CellMouseDoubleClick



        'Show Product Details To Text boxes
        ShowProductDetailsToTextboxes()
    End Sub

    Private Sub GrdProductList_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdProductList.CellMouseDown
        'Dim i As Integer
        'i = GrdProductList.CurrentRow.Index


        'GrdProductList.Rows(i).DefaultCellStyle.BackColor = Color.Red
    End Sub

    Private Sub GrdProductList_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdProductList.GotFocus
        If SaleEditStatus = True Then
            'Find Branch ID For Edit Sale
            FindBranchIDForEditSale()

        ElseIf Not SaleEditStatus = True Then
            'Find Current User Branch ID 
            FindCurrentUserBranchID()
        End If
    End Sub

    Private Sub GrdProductList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdProductList.KeyDown
        If e.KeyCode = Keys.Enter Then

            'Show Product Details To Textboxes
            ShowProductDetailsToTextboxes()
        End If
    End Sub

    Private Sub GrdProductList_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdProductList.LostFocus
        If SaleEditStatus = True Then
            'Find Branch ID For Edit Sale
            FindBranchIDForEditSale()

        ElseIf Not SaleEditStatus = True Then
            'Find Current User Branch ID 
            FindCurrentUserBranchID()
        End If
    End Sub

    Private Sub GrdProductList_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GrdProductList.MouseMove
        'visible product list gridview
        GrdProductList.Visible = True



    End Sub

    Private Sub TxtBonus_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBonus.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbSerialNumber.Focus()

        End If
    End Sub

    Private Sub TxtBonus_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBonus.TextChanged

    End Sub

    Private Sub Button4_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        FrmProductInformation.Show()
        FrmProductInformation.BtnAddNew.PerformClick()
    End Sub
    Sub ResizeCustomerGridViewAndMakeitVisible()

        GrdCustomerList.Visible = True
        GrdCustomerList.Width = 400
        GrdCustomerList.Height = 113

        'Column visiblity false
        GrdCustomerList.ColumnHeadersVisible = False

    End Sub

    Private Sub CmbCustomerName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbCustomerName.TextChanged

        If Not CmbCustomerName.Text = "" Then


            ' Resize Customer GridView And Make it Visible()
            ResizeCustomerGridViewAndMakeitVisible()

            'Search By Customer Name For Current Branch
            SearchByCustomerNameForCurrentBranch()




        ElseIf CmbCustomerName.Text = "" Then

            GrdCustomerList.Visible = False

            'Clear Data Products For Drop down
            cleardataCustomer()

        End If
    End Sub

    Private Sub GrdCustomerList_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdCustomerList.CellContentClick

    End Sub

    'Show Customer Details In Textboxs
    Sub ShowCustomerDetailsInTextboxs()
        Try

            Dim i As Integer
            i = GrdCustomerList.CurrentRow.Index




            'Show customer name and valumember
            CmbCustomerName.ValueMember = GrdCustomerList.Item(0, i).Value

            'Show Product name to combobox
            CmbCustomerName.Text = GrdCustomerList.Item(1, i).Value



            customerInformation()

            'Show Customer Dues or advanced
            ShowDueOrAdvance()


            'CalCulate Netpayable
            NetPayableAmount()

            'Calculation Of Balance And ReturnAmount
            CalculationOfBalanceAndReturnAmount()


            'Focus on product combobox
            cmbProductName.Focus()






            'hide product list gridview
            GrdCustomerList.Visible = False




        Catch ex As Exception
            MessageBox.Show("Error while showing record from table..." & ex.Message, "Show Records")

        End Try
    End Sub

    Private Sub GrdCustomerList_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdCustomerList.CellMouseClick

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CmbCustomerName_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbCustomerName.TabIndexChanged

    End Sub

    Private Sub GrdCustomerList_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdCustomerList.CellMouseDoubleClick
        'Show Customer Details In Textboxs
        ShowCustomerDetailsInTextboxs()
    End Sub

    Private Sub GrdCustomerList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdCustomerList.KeyDown
        If e.KeyCode = Keys.Enter Then

            'Show Customer Details In Textboxs
            ShowCustomerDetailsInTextboxs()

        End If
    End Sub



    Private Sub GrdProductList_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles GrdProductList.Scroll

    End Sub

    Private Sub GrdProductList_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdProductList.SelectionChanged

    End Sub



    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub CmbCustomerName_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CmbCustomerName.MouseClick
        'Resize Customer GridView And Make it Visible()
        ResizeCustomerGridViewAndMakeitVisible()

        'Search By Customer Name For Current Branch
        SearchByCustomerNameForCurrentBranch()
    End Sub

    Private Sub cmbProductName_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmbProductName.MouseClick
        'Resize Product List Gridviewand Make it visible
        ResizeProductListGridviewandMakeitvisible()

        'Search Product Details
        SearchByProductNameForCurrentBranch()

    End Sub



    Private Sub LblSelectProduct_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LblSelectProduct.MouseMove

        'Hide product list
        GrdProductList.Visible = False
        GrdCustomerList.Visible = False
        GrdSerialNumber.Visible = False

    End Sub

    Private Sub CmbSerialNumber_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbSerialNumber.TextChanged

    End Sub

    Private Sub GrdSerialNumber_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdSerialNumber.CellContentClick

    End Sub
    'Show Serial Number to textbox
    Sub ShowSerialNumberToTextboxes()
        Try


            Dim i As Integer
            i = GrdSerialNumber.CurrentRow.Index

            'show serial number to combobox

            CmbSerialNumber.Text = GrdSerialNumber.Item(0, i).Value
            CmbSerialNumber.Focus()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "ShowSerialNumberToTextboxes")
        End Try

    End Sub
    Private Sub GrdSerialNumber_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdSerialNumber.CellMouseDoubleClick
        'Show Serial Number to textbox
        ShowSerialNumberToTextboxes()
    End Sub

    

    Private Sub GrdSerialNumber_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdSerialNumber.KeyDown



        If e.KeyCode = Keys.Enter Then

            'Show Serial Number to textbox
            ShowSerialNumberToTextboxes()

            performActionForSerialEntry(Keys.Enter)

            

        ElseIf e.KeyCode = Keys.Down Then
            Try
                If GrdSerialNumber.CurrentRow.Index >= 0 Then



                    Dim i As Integer
                    i = GrdSerialNumber.CurrentRow.Index + 1
                    CmbSerialNumber.Text = GrdSerialNumber.Item(0, i).Value
                End If
            Catch ex As Exception

            End Try



        ElseIf e.KeyCode = Keys.Up Then
            Try
                If GrdSerialNumber.CurrentRow.Index >= 0 Then





                    Dim i As Integer
                    i = GrdSerialNumber.CurrentRow.Index - 1
                    CmbSerialNumber.Text = GrdSerialNumber.Item(0, i).Value
                End If
            Catch ex As Exception

            End Try


        End If

    End Sub

    Private Sub GrdAvailableSerialNumber_CellMouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdAvailableSerialNumber.CellMouseMove

        'Hide product list
        GrdProductList.Visible = False
        GrdCustomerList.Visible = False
        GrdSerialNumber.Visible = False
    End Sub

    Private Sub TxtUnitDiscount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtUnitDiscount.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TxtDiscountAmount.Focus()

        End If
    End Sub
   

    




    


   

    Private Sub TxtUnitDiscount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtUnitDiscount.TextChanged
        Me.TxtDiscountAmount.Text = Val(TxtQuantity.Text) * Val(TxtUnitDiscount.Text)
        TxtSaleAmount.Text = (Val(TxtQuantity.Text) * Val(TxtSaleUnitPrice.Text)) - Val(TxtDiscountAmount.Text)
    End Sub

    Private Sub TxtDiscountAmount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDiscountAmount.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtUnitDiscount.Text = Val(TxtDiscountAmount.Text) / Val(TxtQuantity.Text)
            Me.TxtSaleUnitPrice.Focus()

        End If
    End Sub

    Private Sub TxtDiscountAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDiscountAmount.TextChanged
        TxtSaleAmount.Text = (Val(TxtQuantity.Text) * Val(TxtSaleUnitPrice.Text)) - Val(TxtDiscountAmount.Text)
    End Sub

    Sub SearchDiscountAmountFromProductInformation()

        Try


            If Not CmbCustomerName.ValueMember = "" Or Not CmbCustomerName.Text = "" Then

                Dim con As New SqlConnection
                Dim cmd As New SqlCommand
                Dim cmd1 As New SqlCommand
                Dim dr As SqlDataReader
                Dim dr1 As SqlDataReader




                con.ConnectionString = FrmHome.ConnectionString
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "SELECT  *FROM [Products]  WHERE [Product ID] = '" + cmbProductName.ValueMember + "'"

                'Dr for search wholesale price and declare in memory
                dr = cmd.ExecuteReader()
                dr.Read()


                If dr.HasRows Then

                    TxtUnitDiscount.Text = (dr.Item("Discount Amount").ToString)

                End If
                dr.Close()
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



End Class