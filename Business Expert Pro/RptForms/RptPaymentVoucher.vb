Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class RptPaymentVoucher
    Public InvoiceNo As String
    Private Sub RptPaymentVoucher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowVoucherInvoice()
    End Sub
    Sub ShowVoucherInvoice()

        Try
            Dim cryRpt As New ReportDocument
            Dim crtableLogoninfos As New TableLogOnInfos
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim CrTables As Tables
            Dim CrTable As Table






            cryRpt.Load("" + FrmHome.ReportLocation + "" & "PaymentVoucher.rpt")

            'cryRpt.Load(System.Windows.Forms.Application.StartupPath + "\SaleInvoice.rpt")
            With crConnectionInfo
                .ServerName = FrmHome.ServerName
                .DatabaseName = FrmHome.DatabaseName
                .UserID = FrmHome.ID
                .Password = FrmHome.Password

            End With


            CrTables = cryRpt.Database.Tables
            cryRpt.SetDatabaseLogon("" + FrmHome.ID + "", "" + FrmHome.Password + "")

            cryRpt.SetParameterValue("VoucherNo", InvoiceNo)




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
End Class