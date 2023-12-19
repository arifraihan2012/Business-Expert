Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class RptAccountsReceivableAndPayable

    Private Sub RptAccountsReceivableAndPayable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Sub ShowIndividualBranchAccountsReceivable()

        Try
            Dim cryRpt As New ReportDocument
            Dim crtableLogoninfos As New TableLogOnInfos
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim CrTables As Tables
            Dim CrTable As Table






            cryRpt.Load("" + FrmHome.ReportLocation + "" & "AccountsReceivable.rpt")

            'cryRpt.Load(System.Windows.Forms.Application.StartupPath + "\SaleInvoice.rpt")




            With crConnectionInfo
                .ServerName = FrmHome.ServerName
                .DatabaseName = FrmHome.DatabaseName
                .UserID = FrmHome.ID
                .Password = FrmHome.Password

            End With

          
            CrTables = cryRpt.Database.Tables
            cryRpt.SetDatabaseLogon("" + FrmHome.ID + "", "" + FrmHome.Password + "")



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

    Sub ShowIndividualBranchAccountsPayable()

        Try
            Dim cryRpt As New ReportDocument
            Dim crtableLogoninfos As New TableLogOnInfos
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim CrTables As Tables
            Dim CrTable As Table






            cryRpt.Load("" + FrmHome.ReportLocation + "" & "AccountsPayable.rpt")

            'cryRpt.Load(System.Windows.Forms.Application.StartupPath + "\SaleInvoice.rpt")



            With crConnectionInfo
                .ServerName = FrmHome.ServerName
                .DatabaseName = FrmHome.DatabaseName
                .UserID = FrmHome.ID
                .Password = FrmHome.Password

            End With


            CrTables = cryRpt.Database.Tables
            cryRpt.SetDatabaseLogon("" + FrmHome.ID + "", "" + FrmHome.Password + "")





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
    Sub ShowAllBranchAccountsPayable()

        Try
            Dim cryRpt As New ReportDocument
            Dim crtableLogoninfos As New TableLogOnInfos
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim CrTables As Tables
            Dim CrTable As Table






            cryRpt.Load("" + FrmHome.ReportLocation + "" & "AllBranchAccountsPayable.rpt")

            'cryRpt.Load(System.Windows.Forms.Application.StartupPath + "\SaleInvoice.rpt")


            With crConnectionInfo
                .ServerName = FrmHome.ServerName
                .DatabaseName = FrmHome.DatabaseName
                .UserID = FrmHome.ID
                .Password = FrmHome.Password

            End With


            CrTables = cryRpt.Database.Tables
            cryRpt.SetDatabaseLogon("" + FrmHome.ID + "", "" + FrmHome.Password + "")




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
    Sub ShowAllBranchAccountsReceivable()

        Try
            Dim cryRpt As New ReportDocument
            Dim crtableLogoninfos As New TableLogOnInfos
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim CrTables As Tables
            Dim CrTable As Table






            cryRpt.Load("" + FrmHome.ReportLocation + "" & "AllBranchAccountsReceivable.rpt")

            'cryRpt.Load(System.Windows.Forms.Application.StartupPath + "\SaleInvoice.rpt")



            With crConnectionInfo
                .ServerName = FrmHome.ServerName
                .DatabaseName = FrmHome.DatabaseName
                .UserID = FrmHome.ID
                .Password = FrmHome.Password

            End With


            CrTables = cryRpt.Database.Tables
            cryRpt.SetDatabaseLogon("" + FrmHome.ID + "", "" + FrmHome.Password + "")




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

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        If CmbShowReport.SelectedIndex = 0 Then
            ShowIndividualBranchAccountsReceivable()

        ElseIf CmbShowReport.SelectedIndex = 1 Then
            ShowIndividualBranchAccountsPayable()

        End If
    End Sub

    Private Sub CmbShowBill_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbShowReport.KeyDown

    End Sub

    Private Sub CmbShowBill_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbShowReport.SelectedIndexChanged
        If CmbShowReport.SelectedIndex = 0 Then
            ShowIndividualBranchAccountsReceivable()

        ElseIf CmbShowReport.SelectedIndex = 1 Then
            ShowIndividualBranchAccountsPayable()

        End If
    End Sub
End Class