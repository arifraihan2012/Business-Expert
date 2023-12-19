Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class RptLedger

    Private Sub RptLedger_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load





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

                CmbSelectSearchType.SelectedIndex = 0
            ElseIf Not dr.HasRows Then

                CmbSelectSearchType.SelectedIndex = 0
                CmbBranchID.SelectedValue = FrmHome.lblBranchID.Text

                CmbSelectSearchType.Visible = False
                CmbBranchID.Visible = False
                Label1.Visible = False
                Label2.Visible = False



            End If

            dr.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while  permission delete to form..." & ex.Message, "Form Load")

        End Try






        LoadComboBoxChartOfAccountForTransfer()
        'Me.DtpFromDate.Value = Now
        Me.DtpToDate.Value = Now

    End Sub


    'Show All Branch Ledger Report
    Sub ShowTotalBranchLedgerReport()

        Try
            Dim cryRpt As New ReportDocument
            Dim crtableLogoninfos As New TableLogOnInfos
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim CrTables As Tables
            Dim CrTable As Table






            cryRpt.Load("" + FrmHome.ReportLocation + "" & "LedgerDetails.rpt")

            'cryRpt.Load(System.Windows.Forms.Application.StartupPath + "\SaleInvoice.rpt")




            With crConnectionInfo
                .ServerName = FrmHome.ServerName
                .DatabaseName = FrmHome.DatabaseName
                .UserID = FrmHome.ID
                .Password = FrmHome.Password

            End With


            CrTables = cryRpt.Database.Tables
            cryRpt.SetDatabaseLogon("" + FrmHome.ID + "", "" + FrmHome.Password + "")

            cryRpt.SetParameterValue("AccountName", Me.CmbChartOfAccount.SelectedValue.ToString)
            cryRpt.SetParameterValue("LedgerFromDate", Me.DtpFromDate.Value)
            cryRpt.SetParameterValue("LedgerToDate", Me.DtpToDate.Value)




            Me.CrystalReportViewer1.ShowGroupTreeButton = False
            Me.CrystalReportViewer1.ShowRefreshButton = False


            For Each CrTable In CrTables
                crtableLogoninfo = CrTable.LogOnInfo
                crtableLogoninfo.ConnectionInfo = crConnectionInfo
                CrTable.ApplyLogOnInfo(crtableLogoninfo)

            Next

            Me.CrystalReportViewer1.ReportSource = cryRpt
            Me.CrystalReportViewer1.Refresh()




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Show Current Branch Ledger Report
    Sub ShowCurrentBranchLedgerReport()


        Try
            Dim cryRpt As New ReportDocument
            Dim crtableLogoninfos As New TableLogOnInfos
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim CrTables As Tables
            Dim CrTable As Table






            cryRpt.Load("" + FrmHome.ReportLocation + "" & "LedgerDetailsByBranch.rpt")

            'cryRpt.Load(System.Windows.Forms.Application.StartupPath + "\SaleInvoice.rpt")



            With crConnectionInfo
                .ServerName = FrmHome.ServerName
                .DatabaseName = FrmHome.DatabaseName
                .UserID = FrmHome.ID
                .Password = FrmHome.Password

            End With


            CrTables = cryRpt.Database.Tables
            cryRpt.SetDatabaseLogon("" + FrmHome.ID + "", "" + FrmHome.Password + "")

            cryRpt.SetParameterValue("AccountName", Me.CmbChartOfAccount.SelectedValue.ToString)
            cryRpt.SetParameterValue("LedgerFromDate", Me.DtpFromDate.Value)
            cryRpt.SetParameterValue("LedgerToDate", Me.DtpToDate.Value)
            cryRpt.SetParameterValue("BranchID", Me.CmbBranchID.SelectedValue.ToString)



            Me.CrystalReportViewer1.ShowGroupTreeButton = False
            Me.CrystalReportViewer1.ShowRefreshButton = False


            For Each CrTable In CrTables
                crtableLogoninfo = CrTable.LogOnInfo
                crtableLogoninfo.ConnectionInfo = crConnectionInfo
                CrTable.ApplyLogOnInfo(crtableLogoninfo)

            Next

            Me.CrystalReportViewer1.ReportSource = cryRpt
            Me.CrystalReportViewer1.Refresh()




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Sub LoadComboBoxChartOfAccountForTransfer()

        Try

            ' Load Chart of Account Name
            Dim con1 As New SqlConnection
            Dim cmd1 As New SqlCommand
            con1.ConnectionString = FrmHome.ConnectionString

            Dim strSQL1 As String = "Select [Chart of Account].[Chart of Account ID],[Chart of Account].[Account Name] from  [Chart of Account] join [Head Of Account]  on [Chart of Account].[Head of Account ID]=[Head Of Account].[Head of Account ID] "
            Dim da1 As New System.Data.SqlClient.SqlDataAdapter(strSQL1, con1)
            Dim ds1 As New DataSet
            da1.Fill(ds1, "[Chart Of Account]")

            With Me.CmbChartOfAccount
                .DataSource = ds1.Tables("[Chart Of Account]")
                .ValueMember = "Chart Of Account ID"
                .DisplayMember = "Account Name"
            End With
            con1.Close()
            CmbChartOfAccount.SelectedValue = 0



            ' Load Branch information
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            con.ConnectionString = FrmHome.ConnectionString

            Dim strSQL As String = "SELECT [Branch ID],[Branch Name] FROM [Branch Information]"
            Dim da As New System.Data.SqlClient.SqlDataAdapter(strSQL, con)
            Dim ds As New DataSet
            da.Fill(ds, "[Branch Information]")

            With Me.CmbBranchID
                .DataSource = ds.Tables("[Branch Information]")
                .ValueMember = "Branch ID"
                .DisplayMember = "Branch Name"

            End With
            con.Close()
            CmbBranchID.SelectedValue = FrmHome.lblBranchID.Text


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub





    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShow.Click

        If CmbSelectSearchType.SelectedIndex = 0 Then

            'Show Current Branch Ledger Report
            ShowCurrentBranchLedgerReport()

        ElseIf CmbSelectSearchType.SelectedIndex = 1 Then
            'Show All Branch Ledger Report
            ShowTotalBranchLedgerReport()


        End If

    End Sub

    Private Sub CmbChartOfAccount_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbChartOfAccount.SelectedIndexChanged

    End Sub
End Class