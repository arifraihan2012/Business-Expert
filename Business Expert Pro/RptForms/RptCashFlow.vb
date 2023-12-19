Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared


Public Class RptCashFlow

    Private Sub RptCashFlow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


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

            If Not dr.HasRows Then

                CmbBranchID.Visible = False
                Label1.Visible = False
            End If

            dr.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while  permission delete to form..." & ex.Message, "Form Load")

        End Try







        Me.DtpFromDate.Value = Now
        Me.DtpToDate.Value = Now

        LoadComboBoxBranch()
        Me.CmbBranchID.Text = FrmHome.LblBranchName.Text


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
            con1.Close()

            CmbBranchID.SelectedValue = 0


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Sub ShowInvoice()

        Try
            Dim cryRpt As New ReportDocument
            Dim crtableLogoninfos As New TableLogOnInfos
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim CrTables As Tables
            Dim CrTable As Table






            cryRpt.Load("" + FrmHome.ReportLocation + "" & "CashFlowReport.rpt")

            'cryRpt.Load(System.Windows.Forms.Application.StartupPath + "\SaleInvoice.rpt")




            With crConnectionInfo
                .ServerName = FrmHome.ServerName
                .DatabaseName = FrmHome.DatabaseName
                .UserID = FrmHome.ID
                .Password = FrmHome.Password

            End With

            CrTables = cryRpt.Database.Tables
            cryRpt.SetDatabaseLogon("" + FrmHome.ID + "", "" + FrmHome.Password + "")

            cryRpt.SetParameterValue("LedgerFromDate", Me.DtpFromDate.Value)
            cryRpt.SetParameterValue("LedgerToDate", Me.DtpToDate.Value)
            cryRpt.SetParameterValue("FromDate", Me.DtpFromDate.Value)
            cryRpt.SetParameterValue("Branch ID", Me.CmbBranchID.SelectedValue.ToString)
            cryRpt.SetParameterValue("BranchID", Me.CmbBranchID.SelectedValue.ToString)




            Me.CrystalReportViewer1.ShowGroupTreeButton = False
            Me.CrystalReportViewer1.ShowRefreshButton = False


            For Each CrTable In CrTables
                crtableLogoninfo = CrTable.LogOnInfo
                crtableLogoninfo.ConnectionInfo = crConnectionInfo
                CrTable.ApplyLogOnInfo(crtableLogoninfo)

            Next

            cryRpt.PrintOptions.PrinterName = "Microsoft XPS Document Writer"
            Me.CrystalReportViewer1.ReportSource = cryRpt


            Me.CrystalReportViewer1.Refresh()





        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub




    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click

        If DtpToDate.Value < DtpFromDate.Value Then
            MsgBox("Please select correct date. ", MsgBoxStyle.Critical, "Sale")
        Else
            ShowInvoice()
        End If



    End Sub
End Class