Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class RptSaleReport

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    

    Sub DailySaleReport()


        Try
            Dim cryRpt As New ReportDocument
            Dim crtableLogoninfos As New TableLogOnInfos
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim CrTables As Tables
            Dim CrTable As Table



            cryRpt.Load("" + FrmHome.ReportLocation + "" & "SaleReport.rpt")

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

    Sub DailySaleReportByInvoice()


        Try
            Dim cryRpt As New ReportDocument
            Dim crtableLogoninfos As New TableLogOnInfos
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim CrTables As Tables
            Dim CrTable As Table






            cryRpt.Load("" + FrmHome.ReportLocation + "" & "SaleReportByInvoice.rpt")

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

    Sub DailySaleReportBySingProduct()


        Try
            Dim cryRpt As New ReportDocument
            Dim crtableLogoninfos As New TableLogOnInfos
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim CrTables As Tables
            Dim CrTable As Table






            cryRpt.Load("" + FrmHome.ReportLocation + "" & "SaleReportBySingleProduct.rpt")

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
            cryRpt.SetParameterValue("ProductID", Me.CmbProductName.SelectedValue.ToString)




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

    'Sale Report By Customer Category
    Sub DailySaleReportByCustomerCategory()


        Try
            Dim cryRpt As New ReportDocument
            Dim crtableLogoninfos As New TableLogOnInfos
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim CrTables As Tables
            Dim CrTable As Table






            cryRpt.Load("" + FrmHome.ReportLocation + "" & "SaleReportByCustomerCategory.rpt")

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
            'cryRpt.SetParameterValue("ProductID", Me.CmbProductName.SelectedValue.ToString)




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

    'Sale Report By Customer Category
    Sub DailySaleReportByCustomerCategoryByBranch()


        Try
            Dim cryRpt As New ReportDocument
            Dim crtableLogoninfos As New TableLogOnInfos
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim CrTables As Tables
            Dim CrTable As Table






            cryRpt.Load("" + FrmHome.ReportLocation + "" & "SaleReportByCustomerCategoryByBranch.rpt")

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
            cryRpt.SetParameterValue("BranchID", Me.CmbBranchName.SelectedValue)
            'cryRpt.SetParameterValue("ProductID", Me.CmbProductName.SelectedValue.ToString)




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

    Sub DailySaleReportByCustomerName()


        Try
            Dim cryRpt As New ReportDocument
            Dim crtableLogoninfos As New TableLogOnInfos
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim CrTables As Tables
            Dim CrTable As Table






            cryRpt.Load("" + FrmHome.ReportLocation + "" & "SaleReportByCustomerName.rpt")

            'cryRpt.Load(System.Windows.Forms.Application.StartupPath + "\SaleInvoice.rpt")



            With crConnectionInfo
                .ServerName = FrmHome.ServerName
                .DatabaseName = FrmHome.DatabaseName
                .UserID = FrmHome.ID
                .Password = FrmHome.Password

            End With


            CrTables = cryRpt.Database.Tables
            cryRpt.SetDatabaseLogon("" + FrmHome.ID + "", "" + FrmHome.Password + "")

            cryRpt.SetParameterValue("@FromDate", Me.DtpFromDate.Value)
            cryRpt.SetParameterValue("@ToDate", Me.DtpToDate.Value)
            'cryRpt.SetParameterValue("ProductID", Me.CmbProductName.SelectedValue.ToString)




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

    Sub DailySaleReportByProductGroup()


        Try
            Dim cryRpt As New ReportDocument
            Dim crtableLogoninfos As New TableLogOnInfos
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim CrTables As Tables
            Dim CrTable As Table






            cryRpt.Load("" + FrmHome.ReportLocation + "" & "SaleReportByProductGroup.rpt")

            'cryRpt.Load(System.Windows.Forms.Application.StartupPath + "\SaleInvoice.rpt")



            With crConnectionInfo
                .ServerName = FrmHome.ServerName
                .DatabaseName = FrmHome.DatabaseName
                .UserID = FrmHome.ID
                .Password = FrmHome.Password

            End With


            CrTables = cryRpt.Database.Tables
            cryRpt.SetDatabaseLogon("" + FrmHome.ID + "", "" + FrmHome.Password + "")

            cryRpt.SetParameterValue("@FromDate", Me.DtpFromDate.Value)
            cryRpt.SetParameterValue("@ToDate", Me.DtpToDate.Value)
            'cryRpt.SetParameterValue("ProductID", Me.CmbProductName.SelectedValue.ToString)




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

    Sub DailySaleReportByProductGroupDetails()


        Try
            Dim cryRpt As New ReportDocument
            Dim crtableLogoninfos As New TableLogOnInfos
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim CrTables As Tables
            Dim CrTable As Table






            cryRpt.Load("" + FrmHome.ReportLocation + "" & "SaleReportByProductGroupDetails.rpt")

            'cryRpt.Load(System.Windows.Forms.Application.StartupPath + "\SaleInvoice.rpt")



            With crConnectionInfo
                .ServerName = FrmHome.ServerName
                .DatabaseName = FrmHome.DatabaseName
                .UserID = FrmHome.ID
                .Password = FrmHome.Password

            End With


            CrTables = cryRpt.Database.Tables
            cryRpt.SetDatabaseLogon("" + FrmHome.ID + "", "" + FrmHome.Password + "")


            cryRpt.SetParameterValue("@FromDate", Me.DtpFromDate.Value)
            cryRpt.SetParameterValue("@ToDate", Me.DtpToDate.Value)
            'cryRpt.SetParameterValue("ProductID", Me.CmbProductName.SelectedValue.ToString)




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


    Sub DailySaleReportByUserAccount()


        'Try
        Dim cryRpt As New ReportDocument
        Dim crtableLogoninfos As New TableLogOnInfos
        Dim crtableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo
        Dim CrTables As Tables
        Dim CrTable As Table






        cryRpt.Load("" + FrmHome.ReportLocation + "" & "SaleReportByUserAccount.rpt")

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
        'cryRpt.SetParameterValue("ProductID", Me.CmbProductName.SelectedValue.ToString)




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
        'MsgBox(ex.Message)
        ' End Try
    End Sub




    Private Sub RptSaleReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DtpFromDate.Value = Now
        DtpToDate.Value = Now

        'Load Branch List to combobox
        LoadBranchList()

        'Load product to combobox
        LoadComboBoxForProductDetails()

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

                GrpSearchBy.Visible = False

            End If

            dr.Close()
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error while  permission delete to form..." & ex.Message, "Form Load")

        End Try


    End Sub

    'Product Name Load To combobox
    Sub LoadComboBoxForProductDetails()
        Try


            Dim con1 As New SqlConnection
            Dim cmd1 As New SqlCommand
            con1.ConnectionString = FrmHome.ConnectionString

            Dim strSQL1 As String = "SELECT [Product ID],[Product Name] FROM [Products]"
            Dim da1 As New System.Data.SqlClient.SqlDataAdapter(strSQL1, con1)
            Dim ds1 As New DataSet
            da1.Fill(ds1, "Products")

            With Me.CmbProductName
                .DataSource = ds1.Tables("Products")
                .ValueMember = "Product ID"
                .DisplayMember = "Product Name"
            End With
            con1.Close()

            CmbProductName.SelectedValue = 0


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub DtpSaleDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DtpToDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            If CmbSelectSearchBy.SelectedIndex = 0 Then
                'Show Report By Product
                DailySaleReport()

            ElseIf CmbSelectSearchBy.SelectedIndex = 1 Then
                'Show Report By Invoice
                DailySaleReportByInvoice()
            End If
        End If
    End Sub
    Private Sub DtpSaleDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtpToDate.ValueChanged

    End Sub

    Private Sub BtnSeach_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSeach.Click

        If CmbSelectSearchBy.SelectedIndex = 0 Then
            'Show Report By Product
            DailySaleReport()

        ElseIf CmbSelectSearchBy.SelectedIndex = 1 Then
            'Show Report By Invoice
            DailySaleReportByInvoice()

        ElseIf CmbSelectSearchBy.SelectedIndex = 2 Then
            'Show Single Product sale details
            DailySaleReportBySingProduct()

        ElseIf CmbSelectSearchBy.SelectedIndex = 3 Then

            If Me.CmbBranchName.Text = "" Then
                'Show Customer Category wise sale details
                DailySaleReportByCustomerCategory()
            Else
                'Show Customer Category wise sale details by Branch
                DailySaleReportByCustomerCategoryByBranch()
            End If
         

        ElseIf CmbSelectSearchBy.SelectedIndex = 4 Then
            'Show Customer Name wise sale details
            DailySaleReportByCustomerName()

        ElseIf CmbSelectSearchBy.SelectedIndex = 5 Then
            'Show Customer Name wise sale details
            DailySaleReportByProductGroup()
      
        ElseIf CmbSelectSearchBy.SelectedIndex = 6 Then
            'Show Customer Name wise sale details
            DailySaleReportByProductGroupDetails()


        ElseIf CmbSelectSearchBy.SelectedIndex = 7 Then
            'Show Customer Name wise sale details
            DailySaleReportByUserAccount()


        End If

    End Sub

    Private Sub DtpFromDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DtpFromDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            DtpToDate.Focus()
        End If
    End Sub

    Private Sub DtpFromDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtpFromDate.ValueChanged

    End Sub

    Private Sub CmbSelectSearchBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSelectSearchBy.SelectedIndexChanged
        If Not CmbSelectSearchBy.SelectedIndex = 2 Then
            CmbProductName.Visible = False
            LblProductName.Visible = False


        Else
            CmbProductName.Visible = True
            LblProductName.Visible = True

        End If

        If Not CmbSelectSearchBy.SelectedIndex = 3 Then
            CmbBranchName.Visible = False
            LblBranchName.Visible = False


        Else
            CmbBranchName.Visible = True
            LblBranchName.Visible = True

        End If


    End Sub

    Private Sub CmbProductName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbProductName.KeyDown
        If e.KeyCode = Keys.Enter Then


            If CmbSelectSearchBy.SelectedIndex = 2 Then
                'Show Single Product sale details
                DailySaleReportBySingProduct()
            End If


        End If
    End Sub

    Private Sub CmbProductName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbProductName.SelectedIndexChanged

    End Sub

    Sub LoadBranchList()
        'load Branch
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = FrmHome.ConnectionString

        Dim strSQL As String = "SELECT [Branch ID],[Branch Name] FROM [Branch Information]"
        Dim da As New System.Data.SqlClient.SqlDataAdapter(strSQL, con)
        Dim ds As New DataSet
        da.Fill(ds, "[Branch Information]")

        With Me.CmbBranchName
            .DataSource = ds.Tables("[Branch Information]")
            .ValueMember = "Branch ID"
            .DisplayMember = "Branch Name"


        End With
        con.Close()

        CmbBranchName.SelectedValue = 0
    End Sub


    Private Sub CmbBranchName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbBranchName.SelectedIndexChanged

    End Sub
End Class