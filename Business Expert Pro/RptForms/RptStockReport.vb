Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared


Public Class RptStockReport

    Private Sub RptStockReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Product Name Load To combobox
        LoadComboBoxForProductDetails()


        DtpDate.Value = Now




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

                GroupBox1.Visible = False

                'Show current branch automatically
                CmbBranchList.SelectedValue = FrmHome.lblBranchID.Text


                'Show Report
                ShowStockByBranch()
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

            With Me.CmbProductList
                .DataSource = ds1.Tables("Products")
                .ValueMember = "Product ID"
                .DisplayMember = "Product Name"
            End With
            con1.Close()

            CmbProductList.SelectedValue = 0



            'load Branch
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            con.ConnectionString = FrmHome.ConnectionString

            Dim strSQL As String = "SELECT [Branch ID],[Branch Name] FROM [Branch Information]"
            Dim da As New System.Data.SqlClient.SqlDataAdapter(strSQL, con)
            Dim ds As New DataSet
            da.Fill(ds, "[Branch Information]")

            With Me.CmbBranchList
                .DataSource = ds.Tables("[Branch Information]")
                .ValueMember = "Branch ID"
                .DisplayMember = "Branch Name"


            End With
            con.Close()

            CmbBranchList.SelectedValue = 0
          

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Show All Branch Stock Report
    Sub ShowAllBranchStock()

        Try
            Dim cryRpt As New ReportDocument
            Dim crtableLogoninfos As New TableLogOnInfos
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim CrTables As Tables
            Dim CrTable As Table


            cryRpt.Load("" + FrmHome.ReportLocation + "" & "StockReports.rpt")
            'cryRpt.Load(System.Windows.Forms.Application.StartupPath + "\CashFlowReport.rpt")




            With crConnectionInfo
                .ServerName = FrmHome.ServerName
                .DatabaseName = FrmHome.DatabaseName
                .UserID = FrmHome.ID
                .Password = FrmHome.Password


            End With


            CrTables = cryRpt.Database.Tables
            cryRpt.SetDatabaseLogon("" + FrmHome.ID + "", "" + FrmHome.Password + "")

            cryRpt.SetParameterValue("UptoDate", Me.DtpDate.Value)
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


    Sub StockQuantity()

        Try
            Dim cryRpt As New ReportDocument
            Dim crtableLogoninfos As New TableLogOnInfos
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim CrTables As Tables
            Dim CrTable As Table


            cryRpt.Load("" + FrmHome.ReportLocation + "" & "StockReportsOnlyQuantity.rpt")
            'cryRpt.Load(System.Windows.Forms.Application.StartupPath + "\CashFlowReport.rpt")




            With crConnectionInfo
                .ServerName = FrmHome.ServerName
                .DatabaseName = FrmHome.DatabaseName
                .UserID = FrmHome.ID
                .Password = FrmHome.Password


            End With


            CrTables = cryRpt.Database.Tables
            cryRpt.SetDatabaseLogon("" + FrmHome.ID + "", "" + FrmHome.Password + "")

            cryRpt.SetParameterValue("UptoDate", Me.DtpDate.Value)
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

    'Show Stock By Searching Product
    Sub ShowStockBySearchingProduct()

        Try
            Dim cryRpt As New ReportDocument
            Dim crtableLogoninfos As New TableLogOnInfos
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim CrTables As Tables
            Dim CrTable As Table



            cryRpt.Load("" + FrmHome.ReportLocation + "" & "StockReportsProductSearch.rpt")

            'cryRpt.Load(System.Windows.Forms.Application.StartupPath + "\CashFlowReport.rpt")



            With crConnectionInfo
                .ServerName = FrmHome.ServerName
                .DatabaseName = FrmHome.DatabaseName
                .UserID = FrmHome.ID
                .Password = FrmHome.Password

            End With


            CrTables = cryRpt.Database.Tables
            cryRpt.SetDatabaseLogon("" + FrmHome.ID + "", "" + FrmHome.Password + "")

            cryRpt.SetParameterValue("ProductID", Me.CmbProductList.SelectedValue.ToString)
            cryRpt.SetParameterValue("UptoDate", Me.DtpDate.Value)
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
    'Show Stock By Branch
    Sub ShowStockByBranch()

        Try
            Dim cryRpt As New ReportDocument
            Dim crtableLogoninfos As New TableLogOnInfos
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim CrTables As Tables
            Dim CrTable As Table


            If CmbSearchBy.Text = "Selected Branch Stock Report" Then

                cryRpt.Load("" + FrmHome.ReportLocation + "" & "StockReportsForSelectedBranch.rpt")

            ElseIf CmbSearchBy.Text = "Low Stock Report" Then

                cryRpt.Load("" + FrmHome.ReportLocation + "" & "StockReportsofReorderForSelectedBranch.rpt")

            End If
            'cryRpt.Load(System.Windows.Forms.Application.StartupPath + "\CashFlowReport.rpt")



            With crConnectionInfo
                .ServerName = FrmHome.ServerName
                .DatabaseName = FrmHome.DatabaseName
                .UserID = FrmHome.ID
                .Password = FrmHome.Password

            End With


            CrTables = cryRpt.Database.Tables
            cryRpt.SetDatabaseLogon("" + FrmHome.ID + "", "" + FrmHome.Password + "")

            cryRpt.SetParameterValue("BranchID", Me.CmbBranchList.SelectedValue.ToString)
            cryRpt.SetParameterValue("UptoDate", Me.DtpDate.Value)
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
    'Show Low Stock Report
    Sub ShowLowStockReport()

        Try
            Dim cryRpt As New ReportDocument
            Dim crtableLogoninfos As New TableLogOnInfos
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim CrTables As Tables
            Dim CrTable As Table



            cryRpt.Load("" + FrmHome.ReportLocation + "" & "StockReportsofReorder.rpt")

            'cryRpt.Load(System.Windows.Forms.Application.StartupPath + "\CashFlowReport.rpt")


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

            cryRpt.PrintOptions.PrinterName = "Microsoft XPS Document Writer"
            Me.CrystalReportViewer1.ReportSource = cryRpt
            Me.CrystalReportViewer1.Refresh()




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Show Low Stock Report for Selected Branch
    Sub ShowLowStockReportForSelectedBranch()

        Try
            Dim cryRpt As New ReportDocument
            Dim crtableLogoninfos As New TableLogOnInfos
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim CrTables As Tables
            Dim CrTable As Table



            cryRpt.Load("" + FrmHome.ReportLocation + "" & "StockReportsofReorderForSelectedBranch.rpt")

            'cryRpt.Load(System.Windows.Forms.Application.StartupPath + "\CashFlowReport.rpt")


            With crConnectionInfo
                .ServerName = FrmHome.ServerName
                .DatabaseName = FrmHome.DatabaseName
                .UserID = FrmHome.ID
                .Password = FrmHome.Password

            End With


            CrTables = cryRpt.Database.Tables
            cryRpt.SetDatabaseLogon("" + FrmHome.ID + "", "" + FrmHome.Password + "")

            cryRpt.SetParameterValue("BranchID", Me.CmbBranchList.SelectedValue.ToString)
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CmbSearchBy_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbSearchBy.KeyPress
        e.Handled = True
    End Sub

    Private Sub CmbSearchBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSearchBy.SelectedIndexChanged
        If CmbSearchBy.SelectedIndex = 0 Then

            CmbBranchList.Visible = False
            CmbProductList.Visible = False

            'Show All Branch Stock()
            ShowAllBranchStock()

            'Select Date show
            DtpDate.Visible = True

        ElseIf CmbSearchBy.SelectedIndex = 1 Then
            CmbBranchList.Visible = True
            CmbProductList.Visible = False
            CmbBranchList.Focus()


            'Select Date hide
            DtpDate.Visible = True


        ElseIf CmbSearchBy.SelectedIndex = 2 Then
            CmbBranchList.Visible = False
            CmbProductList.Visible = True
            CmbProductList.Focus()
        ElseIf CmbSearchBy.SelectedIndex = 3 Then

            CmbBranchList.Visible = True
            CmbProductList.Visible = False
            'Select Date hide
            DtpDate.Visible = False


        ElseIf CmbSearchBy.SelectedIndex = 4 Then

            CmbBranchList.Visible = False
            CmbProductList.Visible = False

            'Show All Branch Stock()
            StockQuantity()

            'Select Date show
            DtpDate.Visible = True

        End If
    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click

        If CmbSearchBy.SelectedIndex = 0 Then
            CmbBranchList.Visible = False
            CmbProductList.Visible = False

            'Show All Branch Stock()
            ShowAllBranchStock()

            'Select Date show
            DtpDate.Visible = True

        ElseIf CmbSearchBy.SelectedIndex = 1 Then

            'Show Stock By Branch
            ShowStockByBranch()

            'Select Date show
            DtpDate.Visible = True

        ElseIf CmbSearchBy.SelectedIndex = 2 Then
            'Show Stock By Searching Product
            ShowStockBySearchingProduct()


        ElseIf CmbSearchBy.SelectedIndex = 3 Then

            If CmbBranchList.Text = "" Then
              
                'Show Low Stock Report
                ShowLowStockReport()
            ElseIf Not CmbBranchList.Text = "" Then
                'Show Stock By Branch
                ShowLowStockReportForSelectedBranch()
            End If
            


        End If
    End Sub

    Private Sub CmbProductList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbProductList.KeyDown
        If e.KeyCode = Keys.Enter Then

            'Show Stock By Searching Product
            ShowStockBySearchingProduct()
        End If
    End Sub

    Private Sub CmbProductList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbProductList.SelectedIndexChanged

    End Sub

    Private Sub CmbBranchList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbBranchList.KeyDown
        If e.KeyCode = Keys.Enter Then

            'Show Stock By Branch
            ShowStockByBranch()

        End If
    End Sub

    Private Sub CmbBranchList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbBranchList.SelectedIndexChanged

    End Sub
End Class