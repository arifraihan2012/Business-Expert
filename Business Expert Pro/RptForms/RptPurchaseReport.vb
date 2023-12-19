Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared


Public Class RptPurchaseReport

    Private Sub RptPurchaseReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DtpFromDate.Value = Now
        DtpToDate.Value = Now


        CmbSelectSearchBy.SelectedIndex = 0

    End Sub


    Sub DailyPurchaseReportByInvoice()


        Try
            Dim cryRpt As New ReportDocument
            Dim crtableLogoninfos As New TableLogOnInfos
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim CrTables As Tables
            Dim CrTable As Table






            cryRpt.Load("" + FrmHome.ReportLocation + "" & "PurchaseReportByInvoice.rpt")

            'cryRpt.Load(System.Windows.Forms.Application.StartupPath + "\SaleInvoice.rpt")




            With crConnectionInfo
                .ServerName = FrmHome.ServerName
                .DatabaseName = FrmHome.DatabaseName
                .UserID = FrmHome.ID
                .Password = FrmHome.Password

            End With


            CrTables = cryRpt.Database.Tables
            cryRpt.SetDatabaseLogon("" + FrmHome.ID + "", "" + FrmHome.Password + "")

            cryRpt.SetParameterValue("FromDate", Me.DtpFromDate.Value)
            cryRpt.SetParameterValue("ToDate", Me.DtpToDate.Value)




            Me.CrystalReportViewer1.ShowGroupTreeButton = False
            Me.CrystalReportViewer1.ShowRefreshButton = False


            For Each CrTable In CrTables
                crtableLogoninfo = CrTable.LogOnInfo
                crtableLogoninfo.ConnectionInfo = crConnectionInfo
                CrTable.ApplyLogOnInfo(crtableLogoninfo)

            Next

            Me.CrystalReportViewer1.ReportSource = cryRpt
            ' Me.CrystalReportViewer1.Refresh()




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnSeach_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSeach.Click

        'Search Reports
        DailyPurchaseReportByInvoice()
    End Sub

    Private Sub CmbSelectSearchBy_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbSelectSearchBy.KeyPress
        e.Handled = True

    End Sub

    Private Sub CmbSelectSearchBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSelectSearchBy.SelectedIndexChanged

    End Sub

    Private Sub DtpFromDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DtpFromDate.KeyDown
        If e.KeyCode = Keys.Enter Then

            DtpToDate.Focus()

        End If
    End Sub

    Private Sub DtpFromDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtpFromDate.ValueChanged

    End Sub
End Class