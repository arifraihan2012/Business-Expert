
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.IO.Ports
Imports System.Text.RegularExpressions



Public Class FrmCheckProcessing

    Dim X, Y As Integer
    Dim newpoint As New System.Drawing.Point

    Dim CheckViewPermission As String
    Dim CurrentBalance As String
    Dim ReceivedAmount As String
    Dim ChartOfAccountID As String

    Dim SMSPort As New SerialPort
    Private Sub FrmBankReconcilation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Me.Location = New Point(0, 0)
        'Me.Size = My.Computer.Screen.WorkingArea.Size

        'permission for update and Delete
        Try
            Dim con As New SqlConnection
            Dim cmd1 As New SqlCommand
            Dim dr1 As SqlDataReader

            Dim MyFormName As Form = CType(sender, Form)



            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd1.Connection = con
            cmd1.CommandText = "SELECT  *FROM [Permission Setup]  WHERE [User Account ID] = '" + FrmHome.LblUserID.Text + "' AND [Category Name] = 'VIEW ALL BRANCH CHECK PERMISSION' And [Update Delete Permission]='YES'"
            'Permission For Show Purchase Price
            dr1 = cmd1.ExecuteReader()
            dr1.Read()

            If dr1.HasRows Then


                CheckViewPermission = "Yes"

            End If
            dr1.Close()
            con.Close()



        Catch ex As Exception
            MessageBox.Show("Error while  permission delete to form..." & ex.Message, "Form Load")

        End Try

        'Refresh All Data
        RefreshData()


    End Sub


    


    'Find chart of account id to find current balance
    Sub FindChartOfAccountIDAndCurrentBalanceAndSendSms()


        Try

            Dim con As New SqlConnection
            Dim cmd1 As New SqlCommand
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader
            Dim dr1 As SqlDataReader





            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd1.Connection = con
            cmd.Connection = con
            cmd1.CommandText = "WITH RankedData AS (SELECT *, RN = ROW_NUMBER() OVER(PARTITION BY [invoice No], [Category Name] ORDER BY [invoice No],[Category Name]) FROM Ledger ) SELECT [Invoice No], [Ledger Date],[Category Name], [Chart Of Account ID 1] = MAX(CASE WHEN RN = 1 THEN [Chart of Account]. [Chart of Account ID] ELSE '' END), [Chart Of Account ID 2] = MAX(CASE WHEN RN = 2 THEN [Chart of Account]. [Chart of Account ID] ELSE '' END), [Value+] = MAX(CASE WHEN RN = 1 THEN [Chart of Account]. [Account Name] ELSE '' END), [Value-] = MAX(CASE WHEN RN = 2 THEN [Chart of Account]. [Account Name] ELSE '' END),[Voucher No],[Check No],Remarks,sum([Debited Amount])[Amount] FROM RankedData join [Chart of Account] on RankedData.[Chart Of Account ID]=[Chart of Account].[Chart of Account ID] where  RankedData. [Status] = 'Honored' and RankedData.[Invoice No]='" + LblInvoiceNo.Text + "'  GROUP BY [Invoice No],[Voucher No],[Check No],Remarks,[Ledger Date],[category Name]order by RankedData.[ledger Date]  desc, RankedData.[Invoice No] desc"

            'Permission For Show Purchase Price
            dr = cmd1.ExecuteReader()
            dr.Read()

            If dr.HasRows Then

                If dr.Item("Category Name").ToString = "Collection" Then

                    ChartOfAccountID = dr.Item("Chart of Account ID 2").ToString
                    ReceivedAmount = dr.Item("Amount").ToString

                ElseIf dr.Item("Category Name").ToString = "Payment" Then


                    ChartOfAccountID = dr.Item("Chart of Account ID 1").ToString
                    ReceivedAmount = dr.Item("Amount").ToString


                End If


            End If
            dr.Close()


            cmd.CommandText = "select (isnull(sum([debited amount]),0)- isnull(sum([Credited Amount]),0))[Balance] from ledger join [Chart of Account] on Ledger.[Chart Of Account ID]=[Chart of Account].[Chart of Account ID] where not  [Ledger].[Status]= 'WithHeld' And Ledger.[Chart Of Account ID]= [Chart of Account].[Chart of Account ID] and Ledger.[Chart Of Account ID]= '" + ChartOfAccountID + "'"
            dr1 = cmd.ExecuteReader()
            dr1.Read()

            If dr1.HasRows Then


                CurrentBalance = dr1.Item("Balance").ToString


            End If
            dr1.Close()
            con.Close()


           
            SendSMS()



        Catch ex As Exception
            MessageBox.Show("Error while  permission delete to form..." & ex.Message, "Form Load")

        End Try



    End Sub
    'Sub for show dues or advanced or Greeting
    Sub SendSMS()
        Try
            If FrmHome.LblStatus.Text = "Active" Or FrmHome.LblStatus.Text = "Masking" Then

                Dim q As MsgBoxResult
                q = MsgBox("Do you want to send SMS?", MsgBoxStyle.YesNo, "Check Processing")

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
                    con.ConnectionString = FrmHome.ConnectionString
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "select * from [Customer Information] where [Chart Of Account ID]= '" + ChartOfAccountID + "' "

                    dr = cmd.ExecuteReader()
                    dr.Read()


                    If dr.HasRows Then
                        MobileNumber = dr.Item("Mobile No").ToString

                    End If
                    dr.Close()

                    FrmHome.SMSPhoneNo = MobileNumber

                    'Send due sms
                    If Val(CurrentBalance) > 0 Then

                        FrmHome.SMSText = "Dear Customer, " & "BDT " & "" + ReceivedAmount + "" & " has been honored on  " & "" + (CurrentDate.ToString("dd-MMM-yy")) + "" & ". Your current due is BDT " & Val(CurrentBalance) & ". Thank you. " & "" + FrmHome.lblCompanyName.Text + "" & ". Contact No: " & "" + FrmHome.SMSNumber + ""

                        If FrmHome.LblStatus.Text = "Active" Then
                            FrmHome.BulksmsbdToAll()
                        ElseIf FrmHome.LblStatus.Text = "Masking" Then
                            FrmHome.MaskingBulksmsbdToAll()
                        End If



                        'Send advance sms
                    ElseIf Val(CurrentBalance) < 0 Then





                        FrmHome.SMSText = "Dear Customer, " & "BDT " & "" + ReceivedAmount + "" & " has been honored on  " & "" + (CurrentDate.ToString("dd-MMM-yy")) + "" & ". Your current advance is BDT " & Val(CurrentBalance) * -1 & ". Thank you. " & "" + FrmHome.lblCompanyName.Text + "" & ". Contact No: " & "" + FrmHome.SMSNumber + ""

                        If FrmHome.LblStatus.Text = "Active" Then
                            FrmHome.BulksmsbdToAll()
                        ElseIf FrmHome.LblStatus.Text = "Masking" Then
                            FrmHome.MaskingBulksmsbdToAll()
                        End If

                    ElseIf Val(CurrentBalance) = 0 Then

                        FrmHome.SMSText = "Dear Customer, " & "BDT " & "" + ReceivedAmount + "" & " has been honored on  " & "" + (CurrentDate.ToString("dd-MMM-yy")) + "" & "" + FrmHome.lblCompanyName.Text + "" & ". Contact No: " & "" + FrmHome.SMSNumber + ""

                        If FrmHome.LblStatus.Text = "Active" Then
                            FrmHome.BulksmsbdToAll()
                        ElseIf FrmHome.LblStatus.Text = "Masking" Then
                            FrmHome.MaskingBulksmsbdToAll()
                        End If


                    End If


                    con.Close()

                End If

                    End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub RefreshData()
        RefreshDataForwithHeldChecks()
        RefreshDataForHonoredChecks()


    End Sub


    Sub RefreshDataForwithHeldChecks()

        ' Load Data
        Try

            If CheckViewPermission = "Yes" Then

                Dim connectionString As String = FrmHome.ConnectionString
                Dim sql As String = "WITH RankedData AS (SELECT *, RN = ROW_NUMBER() OVER(PARTITION BY [invoice No], [Category Name] ORDER BY [invoice No],[Category Name]) FROM Ledger ) SELECT [Invoice No], [Ledger Date],[Category Name], [Value+] = MAX(CASE WHEN RN = 1 THEN [Chart of Account]. [Account Name] ELSE '' END), [Value-] = MAX(CASE WHEN RN = 2 THEN [Chart of Account]. [Account Name] ELSE '' END),[Voucher No],[Check No],Remarks,sum([Debited Amount])[Amount] FROM RankedData join [Chart of Account] on RankedData.[Chart Of Account ID]=[Chart of Account].[Chart of Account ID] where  RankedData. [Status] = 'WithHeld'  GROUP BY [Invoice No],[Voucher No],[Check No],Remarks,[Ledger Date],[category Name]order by RankedData.[ledger Date]  desc, RankedData.[Invoice No] desc"
                Dim connection As New SqlConnection(connectionString)
                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Ledger")
                connection.Close()
                GrdWithheldChecks.DataSource = ds
                GrdWithheldChecks.DataMember = "BizPro_Ledger"

                'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
                GrdWithheldChecks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            Else

                Dim connectionString1 As String = FrmHome.ConnectionString
                Dim sql1 As String = "WITH RankedData AS (SELECT *, RN = ROW_NUMBER() OVER(PARTITION BY [invoice No], [Category Name] ORDER BY [invoice No],[Category Name]) FROM Ledger where [Branch ID]='" + FrmHome.lblBranchID.Text + "') SELECT [Invoice No], [Ledger Date],[Category Name], [Value+] = MAX(CASE WHEN RN = 1 THEN [Chart of Account]. [Account Name] ELSE '' END), [Value-] = MAX(CASE WHEN RN = 2 THEN [Chart of Account]. [Account Name] ELSE '' END),[Voucher No],[Check No],Remarks,sum([Debited Amount])[Amount] FROM RankedData join [Chart of Account] on RankedData.[Chart Of Account ID]=[Chart of Account].[Chart of Account ID] where  RankedData. [Status] = 'WithHeld'  GROUP BY [Invoice No],[Voucher No],[Check No],Remarks,[Ledger Date],[category Name]order by RankedData.[ledger Date]  desc, RankedData.[Invoice No] desc"
                Dim connection1 As New SqlConnection(connectionString1)
                Dim dataadapter1 As New SqlDataAdapter(sql1, connection1)
                Dim ds1 As New DataSet()
                connection1.Open()
                dataadapter1.Fill(ds1, "BizPro_Ledger")
                connection1.Close()
                GrdWithheldChecks.DataSource = ds1
                GrdWithheldChecks.DataMember = "BizPro_Ledger"

                'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
                GrdWithheldChecks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


            End If


        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh WithHeld")
        Finally

        End Try

        'End Refresh Data


    End Sub
    Sub RefreshDataForHonoredChecks()

        ' Load Data
        Try


            If CheckViewPermission = "Yes" Then

                Dim connectionString As String = FrmHome.ConnectionString
                Dim sql As String = "WITH RankedData AS (SELECT *, RN = ROW_NUMBER() OVER(PARTITION BY [invoice No], [Category Name] ORDER BY [invoice No],[Category Name]) FROM Ledger ) SELECT [Invoice No], [Ledger Date],[Category Name], [Value+] = MAX(CASE WHEN RN = 1 THEN [Chart of Account]. [Account Name] ELSE '' END), [Value-] = MAX(CASE WHEN RN = 2 THEN [Chart of Account]. [Account Name] ELSE '' END),[Voucher No],[Check No],Remarks,sum([Debited Amount])[Amount] FROM RankedData join [Chart of Account] on RankedData.[Chart Of Account ID]=[Chart of Account].[Chart of Account ID] where  RankedData. [Status] = 'Honored' and RankedData. [Category Name]='Payment' or  RankedData. [Category Name]='Collection'and RankedData. [Status] = 'Honored' or  RankedData. [Category Name]='Cash Sale'and RankedData. [Status] = 'Honored' GROUP BY [Invoice No],[Voucher No],[Check No],Remarks,[Ledger Date],[category Name]order by RankedData.[ledger Date]  desc, RankedData.[Invoice No] desc"
                Dim connection As New SqlConnection(connectionString)
                Dim dataadapter As New SqlDataAdapter(sql, connection)
                Dim ds As New DataSet()
                connection.Open()
                dataadapter.Fill(ds, "BizPro_Ledger")
                connection.Close()
                GrdHonoredChecks.DataSource = ds
                GrdHonoredChecks.DataMember = "BizPro_Ledger"

                'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
                GrdHonoredChecks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            Else

                Dim connectionString1 As String = FrmHome.ConnectionString
                Dim sql1 As String = " WITH RankedData AS (SELECT *, RN = ROW_NUMBER() OVER(PARTITION BY [invoice No], [Category Name] ORDER BY [invoice No],[Category Name]) FROM Ledger where [Branch ID]='" + FrmHome.lblBranchID.Text + "') SELECT [Invoice No], [Ledger Date],[Category Name], [Value+] = MAX(CASE WHEN RN = 1 THEN [Chart of Account]. [Account Name] ELSE '' END), [Value-] = MAX(CASE WHEN RN = 2 THEN [Chart of Account]. [Account Name] ELSE '' END),[Voucher No],[Check No],Remarks,sum([Debited Amount])[Amount] FROM RankedData join [Chart of Account] on RankedData.[Chart Of Account ID]=[Chart of Account].[Chart of Account ID] where  RankedData. [Status] = 'Honored' and RankedData. [Category Name]='Payment' or  RankedData. [Category Name]='Collection'and RankedData. [Status] = 'Honored' or  RankedData. [Category Name]='Cash Sale'and RankedData. [Status] = 'Honored' GROUP BY [Invoice No],[Voucher No],[Check No],Remarks,[Ledger Date],[category Name]order by RankedData.[ledger Date]  desc, RankedData.[Invoice No] desc"
                Dim connection1 As New SqlConnection(connectionString1)
                Dim dataadapter1 As New SqlDataAdapter(sql1, connection1)
                Dim ds1 As New DataSet()
                connection1.Open()
                dataadapter1.Fill(ds1, "BizPro_Ledger")
                connection1.Close()
                GrdHonoredChecks.DataSource = ds1
                GrdHonoredChecks.DataMember = "BizPro_Ledger"

                'GrdBranchInformation.ColumnHeadersDefaultCellStyle.Font = New Font("SutonnyMJ", 9.75F, FontStyle.Bold)
                'GrdBranchInformation.Columns(2).DefaultCellStyle.Font = New Font("SutonnyMJ", 15, FontStyle.Regular)
                GrdHonoredChecks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill



            End If



        Catch ex As Exception
            MessageBox.Show("Error while Refreshing record on table..." & ex.Message, "Refresh WithHeld")
        Finally

        End Try

        'End Refresh Data


    End Sub



    Private Sub GrdWithheldChecks_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdWithheldChecks.CellContentClick




    End Sub

    Private Sub BtnHonored_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHonored.Click

        If Me.LblInvoiceNo.Text = "..." Then
            MsgBox("Please Select a row first")

        Else

            UpdateDataWithHeldChecks()

            'Find chart of account id to find current balance
            FindChartOfAccountIDAndCurrentBalanceAndSendSms()

            RefreshData()
            ClearData()
        End If


    End Sub



    Sub ClearData()

        Me.LblInvoiceNo.Text = "..."
        Me.LblCategory.Text = "..."


    End Sub

    Sub UpdateDataWithHeldChecks()

        'Data Insert Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now
        Try


            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.Connection = con


            If Me.LblCategory.Text = "Collection" Then
                cmd.CommandText = "update Ledger set  [Status]='Honored' where [Category Name]= 'Collection' and [Invoice No]='" + LblInvoiceNo.Text + "'"

            ElseIf Me.LblCategory.Text = "Payment" Then
                cmd.CommandText = "update Ledger set  [Status]='Honored' where [Category Name]= 'Payment' and [Invoice No]='" + LblInvoiceNo.Text + "'"

            ElseIf Me.LblCategory.Text = "Cash Sale" Then
                cmd.CommandText = "update Ledger set  [Status]='Honored' where [Category Name]= 'Cash Sale' and [Invoice No]='" + LblInvoiceNo.Text + "'"

            End If




            cmd.ExecuteNonQuery()
            'Insert Click Msg
            'MsgBox("Data Inserted Successfully", MsgBoxStyle.OkOnly, "UpdateCollection")
            'Making Clear

            con.Close()
            RefreshDataForwithHeldChecks()

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "WithHeldUpdate")
        Finally


        End Try
    End Sub


    Sub UpdateDataHonoredChecks()

        'Data Insert Code
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim currentDate As DateTime = DateTime.Today
        Dim currentTime As DateTime = DateTime.Now
        Try


            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.Connection = con


            If Me.LblCategory.Text = "Collection" Then
                cmd.CommandText = "update Ledger set  [Status]='WithHeld' where [Category Name]= 'Collection' and [Invoice No]='" + LblInvoiceNo.Text + "'"

            ElseIf Me.LblCategory.Text = "Payment" Then
                cmd.CommandText = "update Ledger set  [Status]='WithHeld' where [Category Name]= 'Payment' and [Invoice No]='" + LblInvoiceNo.Text + "'"

            ElseIf Me.LblCategory.Text = "Cash Sale" Then
                cmd.CommandText = "update Ledger set  [Status]='WithHeld' where [Category Name]= 'Cash Sale' and [Invoice No]='" + LblInvoiceNo.Text + "'"

            End If




            cmd.ExecuteNonQuery()
            'Insert Click Msg
            'MsgBox("Data Inserted Successfully", MsgBoxStyle.OkOnly, "UpdateCollection")
            'Making Clear
            con.Close()

            RefreshDataForwithHeldChecks()

        Catch ex As Exception
            MessageBox.Show("Error while inserting record on table..." & ex.Message, "WithHeldUpdate")
        Finally


        End Try
    End Sub

    Private Sub GrdWithheldChecks_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdWithheldChecks.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.GrdWithheldChecks.Rows(e.RowIndex)

            LblInvoiceNo.Text = row.Cells("Invoice No").Value.ToString
            LblCategory.Text = row.Cells("Category Name").Value.ToString



        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnWithHeld.Click


        If Me.LblInvoiceNo.Text = "..." Then
            MsgBox("Please Select a row first")
        Else
            UpdateDataHonoredChecks()
            RefreshData()
            ClearData()
        End If


    End Sub

    Private Sub GrdHonoredChecks_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdHonoredChecks.CellContentClick

    End Sub

    Private Sub GrdHonoredChecks_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GrdHonoredChecks.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.GrdHonoredChecks.Rows(e.RowIndex)

            LblInvoiceNo.Text = row.Cells("Invoice No").Value.ToString
            LblCategory.Text = row.Cells("Category Name").Value.ToString


        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click

        'Refresh All Data
        RefreshData()

    End Sub

    Private Sub Btnmaximized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Btnminimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Btnclose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnclose.Click
        Me.Close()
    End Sub

    Private Sub Btnmaximized_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnmaximized.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal

        Else
            Me.WindowState = FormWindowState.Maximized

        End If
    End Sub

    Private Sub Btnminimized_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnminimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel2.MouseHover
      
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
End Class