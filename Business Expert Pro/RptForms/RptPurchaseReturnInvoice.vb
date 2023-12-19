Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class RptPurchaseReturnInvoice
    Public PurchaseReturnInvoiceNo As String
    Public PurchaseInvoiceNo As String

    Private Sub RptPurchaseReturnInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ShowInvoice()

    End Sub

    Sub ShowInvoice()

        ' Try

        Dim cryRpt As New ReportDocument
        Dim crtableLogoninfos As New TableLogOnInfos
        Dim crtableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo
        Dim CrTables As Tables
        Dim CrTable As Table






        cryRpt.Load("" + FrmHome.ReportLocation + "" & "PurchaseReturnInvoice.rpt")

        'cryRpt.Load(System.Windows.Forms.Application.StartupPath + "\SaleInvoice.rpt")



        With crConnectionInfo
            .ServerName = FrmHome.ServerName
            .DatabaseName = FrmHome.DatabaseName
            .UserID = FrmHome.ID
            .Password = FrmHome.Password

        End With


        CrTables = cryRpt.Database.Tables
        cryRpt.SetDatabaseLogon("" + FrmHome.ID + "", "" + FrmHome.Password + "")

        cryRpt.SetParameterValue("PurchaseReturnInvoiceNo", PurchaseReturnInvoiceNo)
        cryRpt.SetParameterValue("PurchaseInvoiceNo", PurchaseInvoiceNo)


        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowRefreshButton = False


        For Each CrTable In CrTables
            crtableLogoninfo = CrTable.LogOnInfo
            crtableLogoninfo.ConnectionInfo = crConnectionInfo
            CrTable.ApplyLogOnInfo(crtableLogoninfo)

        Next

        Me.CrystalReportViewer1.ReportSource = cryRpt
        ' Me.CrystalReportViewer1.Refresh()




        'Catch ex As Exception
        ' MsgBox(ex.Message)
        'End Try

    End Sub
End Class