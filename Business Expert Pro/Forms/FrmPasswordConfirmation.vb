Imports System.Data
Imports System.Data.SqlClient
Imports System.IO


Public Class FrmPasswordConfirmation
    Public SaleDate As String

    Sub Login()

        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader
            Dim cmd1 As New SqlCommand


            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd1.Connection = con
            cmd.CommandText = "SELECT [User Account].[User Account ID],[User Account].[User Name],[Branch Information].[Branch ID],[Branch Information].[Branch Name],[User Account].[Account Full Name],[User Account].[Designation],[User Account].[Password],[User Account].[Status] From [User Account]join [Branch Information]on [User Account].[Branch ID]=[Branch Information].[Branch ID]  WHERE [User Account].[User Name] = 'Admin'"

            dr = cmd.ExecuteReader()
            dr.Read()
            If dr.HasRows Then
                If TxtPassword.Text = (dr.Item("Password")) Then


                    'Show form Student Payment 
                    FrmSale.Show()

                    'Clean all previous data
                    FrmSale.ClearAllData()

                    'Sale Invoice
                    FrmSale.TxtSaleInvoiceNo.Text = FrmSaleHistory.TxtSearchSaleInvoice.Text

                    'Sale Form All Data input
                    'FrmSale.CmbCustomerName.Focus()
                    FrmSale.CmbCustomerName.ValueMember = FrmSaleHistory.LblCustomerID.Text
                    FrmSale.CmbCustomerName.Text = FrmSaleHistory.LblCustomerName.Text
                    FrmSale.CmbCustomerName.SelectedValue = FrmSaleHistory.LblCustomerID.Text
                    FrmSale.DtpSaleDate.Value = SaleDate
                    FrmSale.SearchChartOfAccountIDForUpdateLedger()

                    'Refresh data
                    FrmSale.RefreshData()

                    'Clear Sale Serial Number
                    FrmSale.GrdAvailableSerialNumber.Columns.Clear()



                    'Show customer information
                    FrmSale.customerInformation()

                    'Search Purchase Invoice
                    FrmSale.SearchSaleInvoice()

                    'Set Previous Paid By Id To Variable to Update
                    FrmSale.PreviousPaidbyID = FrmSale.cmbPaidBy.SelectedValue.ToString

                    'Focus on Product Name field
                    FrmSale.cmbProductName.Focus()


                    'sale edit confirmation
                    FrmSale.SaleEditStatus = True

                    'Hide customer details
                    FrmSale.GrdCustomerList.Hide()

                    ' MsgBox(FrmSale.CustomerChartofAccountID)
                    Me.Close()
                Else
                    LblOutputText.Visible = True

                End If
            End If

            dr.Close()
            con.Close()



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub TxtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then

            'Login
            Login()

        End If
    End Sub

    Private Sub TxtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPassword.TextChanged

    End Sub


    Private Sub FrmConfirmPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Me.Location = New Point(0, 0)
        ' Me.Size = My.Computer.Screen.WorkingArea.Size

    End Sub

    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click
        Login()

    End Sub
End Class