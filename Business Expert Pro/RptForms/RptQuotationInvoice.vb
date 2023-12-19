Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class RptQuotationInvoice
    Public QuotationInvoiceNo As String

    Private Sub RptQuotationInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Sub ShowQuotationInvoiceWithoutImage()

        Try
            Dim cryRpt As New ReportDocument
            Dim crtableLogoninfos As New TableLogOnInfos
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim CrTables As Tables
            Dim CrTable As Table






            cryRpt.Load("" + FrmHome.ReportLocation + "" & "QuotationInvoiceWithoutImage.rpt")

            'cryRpt.Load(System.Windows.Forms.Application.StartupPath + "\SaleInvoice.rpt")



            With crConnectionInfo
                .ServerName = FrmHome.ServerName
                .DatabaseName = FrmHome.DatabaseName
                .UserID = FrmHome.ID
                .Password = FrmHome.Password

            End With


            CrTables = cryRpt.Database.Tables
            cryRpt.SetDatabaseLogon("" + FrmHome.ID + "", "" + FrmHome.Password + "")

            cryRpt.SetParameterValue("QuotationInvoiceNo", QuotationInvoiceNo)





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

    Sub ShowQuotationInvoiceWithImage()

        Try
            Dim cryRpt As New ReportDocument
            Dim crtableLogoninfos As New TableLogOnInfos
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim CrTables As Tables
            Dim CrTable As Table






            cryRpt.Load("" + FrmHome.ReportLocation + "" & "QuotationInvoiceWithImage.rpt")

            'cryRpt.Load(System.Windows.Forms.Application.StartupPath + "\SaleInvoice.rpt")


            With crConnectionInfo
                .ServerName = FrmHome.ServerName
                .DatabaseName = FrmHome.DatabaseName
                .UserID = FrmHome.ID
                .Password = FrmHome.Password

            End With


            CrTables = cryRpt.Database.Tables
            cryRpt.SetDatabaseLogon("" + FrmHome.ID + "", "" + FrmHome.Password + "")

            cryRpt.SetParameterValue("QuotationInvoiceNo", QuotationInvoiceNo)





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

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        If CmbShowBill.SelectedIndex = 0 Then
            'Show Quotation Invoice With Image
            ShowQuotationInvoiceWithImage()
        ElseIf CmbShowBill.SelectedIndex = 1 Then

            'Show Quotation Invoice Without Image
            ShowQuotationInvoiceWithoutImage()

        End If
    End Sub

    Private Sub CmbShowBill_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbShowBill.SelectedIndexChanged
        If CmbShowBill.SelectedIndex = 0 Then
            'Show Quotation Invoice With Image
            ShowQuotationInvoiceWithImage()
        ElseIf CmbShowBill.SelectedIndex = 1 Then

            'Show Quotation Invoice Without Image
            ShowQuotationInvoiceWithoutImage()

        End If
    End Sub
End Class