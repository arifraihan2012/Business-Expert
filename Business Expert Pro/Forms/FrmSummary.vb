Imports System.Data
Imports System.Data.SqlClient
Imports System.IO


Public Class FrmSummary

    Private Sub FrmSearchMemberDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Load All Data
        LodeData()


        'CalCulate Total Cash In hand
        CalCulateTotalCashInhand()

    End Sub
   

    'Load Total Deposit collection Today

    Sub TotalCopiesSaleToday()
        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "select  sum([Quantity]) as [Total Quantity] from [Sale Invoice] where datediff(DAY, [Sale Date], getdate())  between 0 and 0"


            dr = cmd.ExecuteReader()
            dr.Read()

            Me.lblTotalCopiesSaleToday.Text = (dr.Item("Total Quantity").ToString)



            dr.Close()
            con.Close()

        Catch ex As Exception

        End Try

    End Sub

    'Load Total Loan Installment collection Today

    Sub TotalSaleAmountToday()
        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "select  sum([Net Payable]) as [Total Amount Sale] from [Sale Invoice] where datediff(DAY, [Sale Date], getdate())  between 0 and 0"


            dr = cmd.ExecuteReader()
            dr.Read()

            Me.lblTotalSaleAmountToday.Text = (dr.Item("Total Amount Sale").ToString)



            dr.Close()
            con.Close()

        Catch ex As Exception

        End Try

    End Sub


    'Load Total Share Holder Cash collection Today

    Sub TotalShareHolderCashcollectionToday()

        Try


            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            con.ConnectionString = FrmHome.ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "select  sum([Amount]) as [Total Amount] from [Share Holder Account] where datediff(DAY, [Date], getdate())  between 0 and 0"


            dr = cmd.ExecuteReader()
            dr.Read()

            Me.lblTotalDueSaleToday.Text = (dr.Item("Total Amount").ToString)



            dr.Close()
            con.Close()

        Catch ex As Exception

        End Try
    End Sub

  


    'Load All Data
    Sub LodeData()


        TotalCopiesSaleToday()

        TotalSaleAmountToday()
        TotalShareHolderCashcollectionToday()











    End Sub
    'CalCulate Total Cash In hand
    Sub CalCulateTotalCashInhand()




    End Sub




    Private Sub Btnload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnload.Click
        'Load All Data
        LodeData()

        'CalCulate Total Cash In hand
        CalCulateTotalCashInhand()

    End Sub
End Class