Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class RptDailyStatement

    Private Sub RptDailyStatement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LoadComboBoxBranch()
        DtpFromDate.Value = Now
        DtpToDate.Value = Now



    End Sub
    Sub ShowDailyStatement()

        Try
            Dim cryRpt As New ReportDocument
            Dim crtableLogoninfos As New TableLogOnInfos
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim CrTables As Tables
            Dim CrTable As Table



            cryRpt.Load("" + FrmHome.ReportLocation + "" & "DailyStatement.rpt")
            'cryRpt.Load(System.Windows.Forms.Application.StartupPath + "\SaleInvoice.rpt")



            With crConnectionInfo
                .ServerName = FrmHome.ServerName
                .DatabaseName = FrmHome.DatabaseName
                .UserID = FrmHome.ID
                .Password = FrmHome.Password

            End With


            CrTables = cryRpt.Database.Tables
            cryRpt.SetDatabaseLogon("" + FrmHome.ID + "", "" + FrmHome.Password + "")

            cryRpt.SetParameterValue("From Date", Me.DtpFromDate.Value)
            cryRpt.SetParameterValue("To Date", Me.DtpToDate.Value)
            cryRpt.SetParameterValue("Branch ID", Me.CmbBranchID.SelectedValue.ToString)



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
    Sub LoadComboBoxBranch()

        Try

            Dim con1 As New SqlConnection
            Dim cmd1 As New SqlCommand
            con1.ConnectionString = FrmHome.ConnectionString


            Dim strSQL1 As String = "Select * from  [Branch Information] "
            Dim da1 As New System.Data.SqlClient.SqlDataAdapter(strSQL1, con1)
            Dim ds1 As New DataSet
            da1.Fill(ds1, "[Branch Information]")

            With Me.CmbBranchID
                .DataSource = ds1.Tables("[Branch Information]")
                .ValueMember = "Branch ID"
                .DisplayMember = "Branch Name"
            End With

            CmbBranchID.SelectedValue = 0


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BtnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShow.Click
        If DtpToDate.Value < DtpFromDate.Value Then
            MsgBox("Please select correct date. ", MsgBoxStyle.Critical, "Pending Cheque")
        Else
            ShowDailyStatement()
        End If
    End Sub

End Class