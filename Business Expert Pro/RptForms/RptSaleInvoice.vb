Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared



Public Class RptSaleInvoice
    Public SaleInvoiceNo As String

    Private Sub RptSaleInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Sub ShowSaleInvoice()

        Try
            Dim cryRpt As New ReportDocument
            Dim crtableLogoninfos As New TableLogOnInfos
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim CrTables As Tables
            Dim CrTable As Table




            cryRpt.Load("" + FrmHome.ReportLocation + "" & "SaleInvoice.rpt")

            'cryRpt.Load(System.Windows.Forms.Application.StartupPath + "\SaleInvoice.rpt")



            With crConnectionInfo
                .ServerName = FrmHome.ServerName
                .DatabaseName = FrmHome.DatabaseName
                .UserID = FrmHome.ID
                .Password = FrmHome.Password

            End With


            CrTables = cryRpt.Database.Tables
            cryRpt.SetDatabaseLogon("" + FrmHome.ID + "", "" + FrmHome.Password + "")

            cryRpt.SetParameterValue("SaleInvoiceNo", SaleInvoiceNo)
            cryRpt.SetParameterValue("CustomerSaleInvoiceNo", SaleInvoiceNo)




            Me.CrystalReportViewer1.ShowGroupTreeButton = False
            Me.CrystalReportViewer1.ShowRefreshButton = False


            For Each CrTable In CrTables
                crtableLogoninfo = CrTable.LogOnInfo
                crtableLogoninfo.ConnectionInfo = crConnectionInfo
                CrTable.ApplyLogOnInfo(crtableLogoninfo)

            Next

            Me.CrystalReportViewer1.ReportSource = cryRpt
            ' Me.CrystalReportViewer1.Refresh()


            'cryRpt.PrintToPrinter(1, True, 1, 1)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub ShowHeaderlessSaleInvoice()

        Try
            Dim cryRpt As New ReportDocument
            Dim crtableLogoninfos As New TableLogOnInfos
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim CrTables As Tables
            Dim CrTable As Table






            cryRpt.Load("" + FrmHome.ReportLocation + "" & "HeaderlessSaleInvoice.rpt")

            'cryRpt.Load(System.Windows.Forms.Application.StartupPath + "\SaleInvoice.rpt")



            With crConnectionInfo
                .ServerName = FrmHome.ServerName
                .DatabaseName = FrmHome.DatabaseName
                .UserID = FrmHome.ID
                .Password = FrmHome.Password

            End With


            CrTables = cryRpt.Database.Tables
            cryRpt.SetDatabaseLogon("" + FrmHome.ID + "", "" + FrmHome.Password + "")

            cryRpt.SetParameterValue("SaleInvoiceNo", SaleInvoiceNo)
            cryRpt.SetParameterValue("CustomerSaleInvoiceNo", SaleInvoiceNo)




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
    Sub ShowChalan()

        Try
            Dim cryRpt As New ReportDocument
            Dim crtableLogoninfos As New TableLogOnInfos
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim CrTables As Tables
            Dim CrTable As Table






            cryRpt.Load("" + FrmHome.ReportLocation + "" & "ChalanReport.rpt")

            'cryRpt.Load(System.Windows.Forms.Application.StartupPath + "\SaleInvoice.rpt")



            With crConnectionInfo
                .ServerName = FrmHome.ServerName
                .DatabaseName = FrmHome.DatabaseName
                .UserID = FrmHome.ID
                .Password = FrmHome.Password

            End With


            CrTables = cryRpt.Database.Tables
            cryRpt.SetDatabaseLogon("" + FrmHome.ID + "", "" + FrmHome.Password + "")

            cryRpt.SetParameterValue("SaleInvoiceNo", SaleInvoiceNo)
            cryRpt.SetParameterValue("CustomerSaleInvoiceNo", SaleInvoiceNo)




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
    Sub ShowHeaderlessChalan()

        Try
            Dim cryRpt As New ReportDocument
            Dim crtableLogoninfos As New TableLogOnInfos
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim CrTables As Tables
            Dim CrTable As Table






            cryRpt.Load("" + FrmHome.ReportLocation + "" & "HeaderlessChalanReport.rpt")

            'cryRpt.Load(System.Windows.Forms.Application.StartupPath + "\SaleInvoice.rpt")




            With crConnectionInfo
                .ServerName = FrmHome.ServerName
                .DatabaseName = FrmHome.DatabaseName
                .UserID = FrmHome.ID
                .Password = FrmHome.Password

            End With


            CrTables = cryRpt.Database.Tables
            cryRpt.SetDatabaseLogon("" + FrmHome.ID + "", "" + FrmHome.Password + "")

            cryRpt.SetParameterValue("SaleInvoiceNo", SaleInvoiceNo)
            cryRpt.SetParameterValue("CustomerSaleInvoiceNo", SaleInvoiceNo)




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


    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub BtnWithOutDue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Sub ShowSaleInvoicewithoutdue()

        Try
            Dim cryRpt As New ReportDocument
            Dim crtableLogoninfos As New TableLogOnInfos
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim CrTables As Tables
            Dim CrTable As Table






            cryRpt.Load("" + FrmHome.ReportLocation + "" & "SaleInvoiceWithoutDue.rpt")

            'cryRpt.Load(System.Windows.Forms.Application.StartupPath + "\SaleInvoice.rpt")




            With crConnectionInfo
                .ServerName = FrmHome.ServerName
                .DatabaseName = FrmHome.DatabaseName
                .UserID = FrmHome.ID
                .Password = FrmHome.Password

            End With


            CrTables = cryRpt.Database.Tables
            cryRpt.SetDatabaseLogon("" + FrmHome.ID + "", "" + FrmHome.Password + "")

            cryRpt.SetParameterValue("SaleInvoiceNo", SaleInvoiceNo)
            cryRpt.SetParameterValue("CustomerSaleInvoiceNo", SaleInvoiceNo)




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

    Sub ShowHeaderlessSaleInvoicewithoutdue()

        Try
            Dim cryRpt As New ReportDocument
            Dim crtableLogoninfos As New TableLogOnInfos
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim CrTables As Tables
            Dim CrTable As Table






            cryRpt.Load("" + FrmHome.ReportLocation + "" & "HeaderlessSaleInvoiceWithoutDue.rpt")

            'cryRpt.Load(System.Windows.Forms.Application.StartupPath + "\SaleInvoice.rpt")



            With crConnectionInfo
                .ServerName = FrmHome.ServerName
                .DatabaseName = FrmHome.DatabaseName
                .UserID = FrmHome.ID
                .Password = FrmHome.Password

            End With


            CrTables = cryRpt.Database.Tables
            cryRpt.SetDatabaseLogon("" + FrmHome.ID + "", "" + FrmHome.Password + "")

            cryRpt.SetParameterValue("SaleInvoiceNo", SaleInvoiceNo)
            cryRpt.SetParameterValue("CustomerSaleInvoiceNo", SaleInvoiceNo)




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

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click

        If CmbShowBill.SelectedIndex = 0 Then
            'Show Sale Invoice
            ShowSaleInvoice()
        ElseIf CmbShowBill.SelectedIndex = 1 Then

            'Show Sale Invoice without due()
            ShowSaleInvoicewithoutdue()
        ElseIf CmbShowBill.SelectedIndex = 2 Then
            'Show Chalan
            ShowChalan()
        ElseIf CmbShowBill.SelectedIndex = 3 Then

            'Show Header less Sale Invoice
            ShowHeaderlessSaleInvoice()
        ElseIf CmbShowBill.SelectedIndex = 4 Then

            'Show Header less Sale Invoice without due()
            ShowHeaderlessSaleInvoicewithoutdue()
        ElseIf CmbShowBill.SelectedIndex = 5 Then

            'Show Header less Chalan
            ShowHeaderlessChalan()
        End If
    End Sub

    Private Sub CmbShowBill_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbShowBill.KeyDown
      
    End Sub

    Private Sub CmbShowBill_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbShowBill.SelectedIndexChanged
        If CmbShowBill.SelectedIndex = 0 Then
            'Show Sale Invoice
            ShowSaleInvoice()
        ElseIf CmbShowBill.SelectedIndex = 1 Then

            'Show Sale Invoice without due()
            ShowSaleInvoicewithoutdue()
        ElseIf CmbShowBill.SelectedIndex = 2 Then
            'Show Chalan
            ShowChalan()
        ElseIf CmbShowBill.SelectedIndex = 3 Then

            'Show Header less Sale Invoice
            ShowHeaderlessSaleInvoice()
        ElseIf CmbShowBill.SelectedIndex = 4 Then

            'Show Header less Sale Invoice without due()
            ShowHeaderlessSaleInvoicewithoutdue()
        ElseIf CmbShowBill.SelectedIndex = 5 Then

            'Show Header less Chalan
            ShowHeaderlessChalan()
        End If
    End Sub
End Class